Imports Negocio
Imports Entidades
Public Class frmAnexoPersonalCentroCosto

    Dim obj As New nCrud
    Public formInicio As String = ""
    Dim iCarga As Integer = 0

    Private Sub cargarCentroCosto()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("usp_dataCentroCosto", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(2).ToString)
            Next
            With cboCentroCosto
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Centro de Costos")
        End Try
    End Sub

    Private Sub cargarPersonal()
        Dim dt As New DataTable
        dt = obj.nCrudListarBD("select * from vista_listaPersonal", CadenaConexion)
        dgvPersonal.DataSource = dt
        lblTotal.Text = dgvPersonal.Rows.Count
    End Sub
    Private Sub frmAnexoPersonalCentroCosto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvPersonal.RowTemplate.Height = 25
        cebrasDatagrid(dgvPersonal, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        iCarga = 1
        If iCarga = 1 Then
            cargarCentroCosto()
            cargarPersonal()
            cargarMarcados()
        End If
        If frmListaCentrosPersonal.dgvLista.Rows.Count > 0 Then
            Dim f As Integer
            f = frmListaCentrosPersonal.dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            cboCentroCosto.SelectedValue = frmListaCentrosPersonal.dgvLista.Rows(f).Cells("id").Value.ToString
        End If
    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        If cboCentroCosto.SelectedValue <> 0 And dgvPersonal.Rows.Count > 0 Then
            Dim codCentro As Integer = 0
            codCentro = cboCentroCosto.SelectedValue.ToString
            obj.nEjecutarQueryBD("delete from centro_costo_personal where id_centro='" & codCentro & "'", CadenaConexion)
            Dim rpta As String = ""
            For Each row As DataGridViewRow In dgvPersonal.Rows
                If row.Cells(0).Value = True Then
                    obj.nCrudInsertarBD("@", "centro_costo_personal", "id_centro@id_personal", codCentro & "@" & row.Cells("id").Value.ToString, CadenaConexion)
                End If
            Next
            MsgBox("PERSONAL ANEXADO AL CENTRO DE COSTO CON ÉXITO")
            gbDatos.Enabled = False
            cargarCentroCosto()
            cargarMarcados()
            frmListaCentrosPersonal.cargarDataCentroCostos()
            Me.Close()
        Else
            MsgBox("ANEXE LOS DATOS PARA PODER PROCESAR")
        End If
    End Sub

    Private Sub btnAnexar_Click(sender As Object, e As EventArgs) Handles btnAnexar.Click
        gbDatos.Enabled = True
        cargarMarcados()
    End Sub

    Private Sub cargarMarcados()
        If dgvPersonal.Rows.Count > 0 Then
            Dim codCentro As Integer = 0
            codCentro = cboCentroCosto.SelectedValue.ToString
            Dim dt As New DataTable
            dt = obj.nCrudListarBD("select * from centro_costo_personal where id_centro='" & codCentro & "'", CadenaConexion)
            For Each row As DataGridViewRow In dgvPersonal.Rows
                row.Cells(0).Value = False
            Next
            For Each fila As DataRow In dt.Rows
                For Each row As DataGridViewRow In dgvPersonal.Rows
                    'MsgBox(fila.Item("id_personal").ToString & "-" & row.Cells("id").Value.ToString)
                    If fila.Item("id_personal").ToString = row.Cells("id").Value.ToString Then
                        row.Cells(0).Value = True
                        Exit For
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub cboCentroCosto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCentroCosto.SelectedIndexChanged
        If iCarga = 1 Then
            cargarMarcados()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class