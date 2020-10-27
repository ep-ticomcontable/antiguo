Imports Negocio
Imports Entidades
Imports System.IO

Public Class frmInicio
    Dim objUsu As New nUsuarios
    Dim objEmp As New nEmpresas

    Private Sub cargarEmpresas()
        dgvListaEmpresa.DataSource = objEmp.nListaEmpresasPorTipoDeUsuario(TipoUsuarioSession, CodigoUsuarioSession)
    End Sub

    Private Sub cargarArbolEmpresas()
        Dim dataEmpresa As New DataTable
        dataEmpresa = objEmp.nListaEmpresasTodas()
        tvEmpresas.Nodes.Clear()
        
        For i As Integer = 0 To dataEmpresa.Rows.Count - 1
            Dim node As TreeNode
            node = tvEmpresas.Nodes.Add(dataEmpresa.Rows(i)("id"), dataEmpresa.Rows(i)("nombre"))
            'MsgBox(node.Name.ToString)

            Dim tbEmpUsu As New DataTable
            tbEmpUsu = objEmp.nListaEmpresasPorTipoDeUsuario(TipoUsuarioSession, CodigoUsuarioSession)

            For j As Integer = 0 To tbEmpUsu.Rows.Count - 1
                If tbEmpUsu.Rows(j)("id") = dataEmpresa.Rows(i)("id") Then
                    'MsgBox(tbEmpUsu.Rows(j)("nombre") & "-" & dataEmpresa.Rows(i)("nombre"))
                    node.Checked = True
                End If
            Next
        Next
    End Sub

    Private Sub cargarComboUsuarios()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = objUsu.nListaUsuariosPorTipoDeUsuario("A", 1)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboUsuarios
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar Usuarios")
        End Try
    End Sub

    Private Sub cargarUsuarios()
        dgvListaUsuario.DataSource = objUsu.nListaUsuariosPorTipoDeUsuario(TipoUsuarioSession, CodigoUsuarioSession)
    End Sub
    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmEleccionEmpresa.Dispose()
        cargarEmpresas()
        cargarUsuarios()


        cargarArbolEmpresas()
    End Sub

    Private Sub btnGuardarEmpresa_Click(sender As Object, e As EventArgs) Handles btnGuardarEmpresa.Click
        Dim nomEmpresa As String = txtEmpresa.Text.Trim
        Dim rpta As String

        Dim ruta_base, archivo_script As String
        Dim sqlBD, sqlTablas, sqlStores As String
        Dim stores() As String

        ruta_base = Directory.GetCurrentDirectory
        ruta_base = ruta_base.Substring(0, ruta_base.Length - 9)
        archivo_script = ruta_base & "plantilla\script_bd.sql"

        Dim objReader As StreamReader
        objReader = New StreamReader(archivo_script)

        sqlBD = objReader.ReadToEnd
        objReader.Close()

        sqlBD = sqlBD.Replace("XXX", nomEmpresa)
        sqlBD = sqlBD.Replace("GO", ";")

        archivo_script = ruta_base & "plantilla\script_tables.sql"
        objReader = New StreamReader(archivo_script)
        sqlTablas = objReader.ReadToEnd
        objReader.Close()

        sqlTablas = sqlTablas.Replace("XXX", nomEmpresa)
        sqlTablas = sqlTablas.Replace("GO", ";")

        archivo_script = ruta_base & "plantilla\script_stores.sql"
        objReader = New StreamReader(archivo_script)
        sqlStores = objReader.ReadToEnd
        objReader.Close()

        sqlStores = sqlStores.Replace("GO", ";")

        stores = sqlStores.Split(";")

        rpta = objEmp.nRegNuevaEmpresa(nomEmpresa, sqlBD, sqlTablas, stores)

        If rpta = "1" Then
            MessageBox.Show("Empresa registrada correctamente", "Confirmacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error. Revise el Log de Errores. " & rpta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        cargarEmpresas()
    End Sub

    Private Sub btnGuardarUsuario_Click(sender As Object, e As EventArgs) Handles btnGuardarUsuario.Click
        Dim nomUsuario As String = txtUsuario.Text.Trim
        Dim rpta As String

        Dim entiUsu As New UsuariosE

        With entiUsu
            .usuario = nomUsuario
            .clave = "12" & nomUsuario & "34"
            .tipo = "A"
        End With
        rpta = objUsu.nRegistrarUsuario(entiUsu)

        If rpta = "1" Then
            MessageBox.Show("Usuario registrado correctamente", "Confirmacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error. Revise el Log de Errores. " & rpta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        cargarUsuarios()
    End Sub

    Private Sub btnPlanContable_Click(sender As Object, e As EventArgs) Handles btnPlanContable.Click
        frmPlanContable.Show()
    End Sub

    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click

    End Sub
End Class