Imports Negocio
Imports Entidades

Public Class frmCrearCentroCosto

    Dim objCrud As New nCrud
    Dim obj As New nCentroCostos

    Private Sub cargarDataCentroCostos()
        Dim data As New DataTable
        data = objCrud.nCrudListarBD("usp_dataCentroCosto", CadenaConexion)
        dgvLista.DataSource = data
    End Sub

    Private Sub cargarIdCentro()
        Dim data As New DataTable
        data = objCrud.nCrudListarBD("select MAX(id)+1 as 'id' from centro_costos", CadenaConexion)
        txtCodigo.Text = data.Rows(0)("id").ToString
    End Sub

    Private Sub cargarListaLocalesActivos()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListarBD("select cod_local,nombre from locales where estado=1", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboLocal
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Locales")
        End Try
    End Sub

    Private Sub cargarListaResponsables()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListarBD("select * from empleados where estado='1' order by nombres asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboResponsable
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Responsables")
        End Try
    End Sub

    Private Sub frmCrearCentroCosto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarListaLocalesActivos()
        cargarListaResponsables()
        cargarIdCentro()
        cargarDataCentroCostos()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        cargarDataCentroCostos()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If cboResponsable.SelectedValue.ToString <> "0" And cboLocal.SelectedValue.ToString <> "0" And txtDescripcion.Text.Trim.Length > 2 Then
            Dim rpta As String
            Dim subCentro As Integer
            subCentro = 1
            rpta = obj.registrarCentroCostoBD(cboLocal.SelectedValue.ToString, txtDescripcion.Text.Trim, cboResponsable.SelectedValue, subCentro, "1", CadenaConexion)
            If rpta = "ok" Then
                cargarDataCentroCostos()
                MessageBox.Show("Centro de Costo registrado con éxito.", "Centro de Costo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show("Error al registrar: " & vbCrLf & rpta, "Centro de Costo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
            frmListaCentroCostos.cargarDataCentroCostos()

            frmParametrosCentroCosto.idCentro = txtCodigo.Text.Trim
            frmParametrosCentroCosto.Show()

            'resetear entradas
            cargarIdCentro()
            cargarListaResponsables()
            cargarListaLocalesActivos()
            txtDescripcion.Text = ""
        ElseIf cboResponsable.SelectedValue = "0" Then
            MessageBox.Show("Escoja un Responsable", "Centro de Costo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            cboResponsable.Focus()
        ElseIf cboLocal.SelectedValue = "0" Then
            MessageBox.Show("Seleccione un Local", "Centro de Costo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            cboLocal.Focus()
        ElseIf txtDescripcion.Text.Trim.Length = "0" Then
            MessageBox.Show("Ingrese una descripción", "Centro de Costo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txtDescripcion.Focus()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        Dim idComprobante As String = ""
        idComprobante = dgvLista.Rows(f).Cells("id").Value
        frmParametrosCentroCosto.tipo = "vista"
        frmParametrosCentroCosto.idCentro = idComprobante
        frmParametrosCentroCosto.Show()
    End Sub
End Class