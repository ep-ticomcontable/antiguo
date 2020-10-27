Imports Negocio
Imports Entidades
Public Class frmAgregarAsientoCierre
    Dim objMon As New nMonedas
    Dim objCierre As New nAsientoCierre
    Dim entiDAA As New AsientoCierreEntity
    Dim objCrud As New nCrud
    Dim objTDA As New nTipoDocumentoAsiento
    Public idAsientoApertura As Integer
    Dim iCarga As Integer = 0
    Dim idTipoOperacion As Integer = 16

    Private Sub CargarTipoDocumento()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = objTDA.nListarCuentasSegunTipoAsientoBD(idTipoOperacion, CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, "(" & row.Item(1).ToString & ") " & row.Item(2).ToString.ToUpper)
            Next
            With cboTipoDocumento
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Documentos")
        End Try
    End Sub

    Private Sub frmAgregarAsiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTipoDocumento()
        iCarga = 1
        limpiarCajas()
    End Sub

    Private Sub limpiarCajas()
        txtCuenta.Text = ""
        lblNomCuenta.Text = "[Nombre Cuenta]"
        txtDebe.Text = "0.00"
        txtHaber.Text = "0.00"
        cboTipoDocumento.SelectedValue = "1"
        txtNumero.Text = "-"
        txtGlosa.Text = ""
    End Sub

    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtCuenta.Text.Trim.Length >= 2 Then
                frmEscogerPlanContable.formInicio = "frmAsientoCierre"
                frmEscogerPlanContable.cuentaInicio = txtCuenta.Text.Trim
                frmEscogerPlanContable.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        For Each row As DataGridViewRow In dgvLista.Rows
            With entiDAA
                .id_cierre = 0
                .cuenta = row.Cells("num_cuenta").Value.ToString
                .debe = row.Cells("debe").Value.ToString
                .haber = row.Cells("haber").Value.ToString
                .glosa = row.Cells("glosa").Value.ToString
                .id_doc = row.Cells("id_doc").Value.ToString
                .num_doc = row.Cells("num_doc").Value.ToString
                .fec_emision = row.Cells("fecha").Value.ToString
            End With
            MsgBox("Cuentas agregadas al Asiento de Cierre: " & vbCrLf & objCierre.registrarAjusteAsientoCierreBD(entiDAA, CadenaConexion))
        Next
        With frmAsientoCierre
            .cargarAsientosContables()
            .realizarCalculos()
        End With
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim data As New DataTable
        With data.Columns
            .Add("num_cuenta")
            .Add("desc_cuenta")
            .Add("debe")
            .Add("haber")
            .Add("glosa")
            .Add("id_doc")
            .Add("num_doc")
            .Add("fecha")
        End With

        If dgvLista.RowCount = 0 Then
            data.Rows.Add(txtCuenta.Text.Trim, lblNomCuenta.Text.Trim, txtDebe.Text.Trim, txtHaber.Text.Trim, txtGlosa.Text.Trim, cboTipoDocumento.SelectedValue.ToString, txtNumero.Text.Trim, dtFecha.Value)
            dgvLista.DataSource = data
        Else
            Dim dt As DataTable = DirectCast(dgvLista.DataSource, DataTable)
            Dim row As DataRow = dt.NewRow()
            row.Item(0) = txtCuenta.Text.Trim
            row.Item(1) = lblNomCuenta.Text.Trim
            row.Item(2) = txtDebe.Text.Trim
            row.Item(3) = txtHaber.Text.Trim
            row.Item(4) = txtGlosa.Text.Trim
            row.Item(5) = cboTipoDocumento.SelectedValue
            row.Item(6) = txtNumero.Text.Trim
            row.Item(7) = dtFecha.Value
            dt.Rows.Add(row)
        End If
    End Sub
End Class