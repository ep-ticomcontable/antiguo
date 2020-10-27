Imports Negocio
Public Class frmEleccionEmpresa

    Dim obj As New nEmpresas
    Dim objCrud As New nCrud
    Dim iCarga As Integer = 0

    Private Function codigoCeldaGrid() As Integer
        Dim c As String
        Try
            Dim f As Integer
            f = dgvEmpresas.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            c = dgvEmpresas.Rows(f).Cells("id").Value.ToString
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function

    Private Sub cargarPeriodos(codEmpresa As Integer)
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        'data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListarBD("usp_obtenerPeriodoCierre '" & codEmpresa & "'", CadenaConexion)
            Dim dataEmp As New DataTable
            dataEmp = obj.nDatosEmpresaPorIdBD(codEmpresa, CadenaConexion)
            data.Rows.Add(dataEmp.Rows(0)("periodo").ToString, dataEmp.Rows(0)("periodo").ToString)
            If data2.Rows.Count >= 0 Then
                For Each row As DataRow In data2.Rows
                    data.Rows.Add(row.Item(0).ToString, row.Item(0).ToString)
                Next
            End If
            With cboPeriodo
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
                '.SelectedItem = 1
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar los periodos")
        End Try
    End Sub
   
    Private Sub cargarEmpresas()
        Dim data As New DataTable
        If CodigoUsuarioSession = 1 Then
            data = objCrud.nCrudListarBD("select id,nombre,ruc from empresas where estado=1 order by id asc", CadenaConexion)
        Else
            data = obj.nListaEmpresasActivasPorUsuarioBD(CodigoUsuarioSession, CadenaConexion)
        End If
        dgvEmpresas.DataSource = data
    End Sub

    Private Sub frmEleccionEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox(CodigoUsuarioSession)
        cargarEmpresas()
        codigoCeldaGrid()
        iCarga = 1
        If iCarga = 1 Then
            'MsgBox(codigoCeldaGrid())
            cargarPeriodos(codigoCeldaGrid())
        End If
    End Sub

    Private Sub dgvEmpresas_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvEmpresas.SelectionChanged
        cargarInfoEmpresa()
    End Sub

    Private Sub dgvEmpresas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvEmpresas.KeyDown
        If e.KeyCode = Keys.Enter Then
            iniciarEmpresa()
        End If
    End Sub

    Private Sub cargarInfoEmpresa()
        Dim dtEmp As New DataTable
        dtEmp = objCrud.nCrudListarBD("select * from empresas where id='" & codigoCeldaGrid() & "'", CadenaConexion)

        Dim data As New DataTable
        data = obj.nDatosEmpresaPorAliasBD(dtEmp.Rows(0)("alias").ToString, CadenaConexion)

        lblInfo.Text = "Nombre: " & vbCrLf & data.Rows(0)("nombre").ToString & vbCrLf & _
        "RUC: " & vbCrLf & data.Rows(0)("ruc").ToString & vbCrLf & _
        "Dirección: " & vbCrLf & data.Rows(0)("direccion").ToString
        If iCarga = 1 Then
            'MsgBox(codigoCeldaGrid())
            cargarPeriodos(codigoCeldaGrid())
        End If
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        iniciarEmpresa()
    End Sub

    Private Sub iniciarEmpresa()
        Dim dtEmp As New DataTable
        dtEmp = objCrud.nCrudListarBD("select * from empresas where id='" & codigoCeldaGrid() & "'", CadenaConexion)

        CadenaConexion = "Server=" & SERVER & ";DataBase=" & dtEmp.Rows(0)("alias").ToString & ";Uid=sa;Password=123456;"
        'CadenaConexion = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\bd\bdTicomContable.mdf;Integrated Security=True"

        Dim data As New DataTable
        data = obj.nDatosEmpresaPorAliasBD(dtEmp.Rows(0)("alias").ToString, CadenaConexion)
        CodigoEmpresaSession = data.Rows(0)("id").ToString
        AnioEjercicio = cboPeriodo.SelectedValue
        'frmPanelPrincipal.Dispose()
        'frmPanelPrincipal.Text = "TICOM CONTABLE - EJERCICIO DE LA EMPRESA: (" & data.Rows(0)("nombre").ToString.ToUpper & ") - USUARIO: " & NombreUsuarioSession & " - PERIODO: (" & cboPeriodo.SelectedValue & ")"
        'frmPanelPrincipal.Show()
        frmPrincipal.Dispose()
        frmPrincipal.Text = "TICOM CONTABLE - EJERCICIO DE LA EMPRESA: (" & data.Rows(0)("nombre").ToString.ToUpper & ") - USUARIO: " & NombreUsuarioSession & " - PERIODO: (" & cboPeriodo.SelectedValue & ")"
        frmPrincipal.Label1.Text = data.Rows(0)("nombre").ToString.ToUpper & " - " & cboPeriodo.SelectedValue
        ' frmPrincipal.BackColor = Color.FromArgb(data.Rows(0)("color_fondo").ToString)
        frmPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If frmPrincipal.Visible = True Then
            Me.Dispose()
        Else
            If MsgBox("¿Está seguro que desea salir del Sistema?.", MsgBoxStyle.YesNo, "Cerrar Sistema") = MsgBoxResult.Yes Then
                Application.Exit()
            End If
        End If
        
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        cargarEmpresas()
    End Sub
End Class