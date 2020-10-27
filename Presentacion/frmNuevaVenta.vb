Imports Negocio

Public Class frmNuevaVenta

    Dim objCrud As New nCrud
    Dim objCA As New nCuentaAsiento
    Dim objMon As New nMonedas
    Dim iCarga As Integer = 0
    Dim dtPagos As New DataTable
    Dim objTDA As New nTipoDocumentoAsiento

    Private Sub cargarImpuestosSunat()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "SIN AFECTO")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListarBD("select * from impuestos_sunat where tipo_comprobante='VENTA'", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(2).ToString)
            Next
            With cboImpuestos
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Impuestos")
        End Try
    End Sub

    Private Sub cargarTipoVenta()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add("CONTADO", "CONTADO")
        data.Rows.Add("CREDITO", "CREDITO")
        With cboTipoVenta
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub
    Private Sub txtCuentaP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuentaP.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtCuentaP.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "frmNuevaVentaP"
                    .cuentaInicio = txtCuentaP.Text.Trim
                    .ShowDialog()
                End With
            End If
        End If
    End Sub

    Private Sub txtCuentaD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuentaD.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtCuentaD.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "frmNuevaVentaD"
                    .cuentaInicio = txtCuentaD.Text.Trim
                    .ShowDialog()
                End With
            End If
        End If
    End Sub

    Private Sub CargarTipoDocumento()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = objTDA.nListarCuentasSegunTipoAsientoBD(1, CadenaConexion)
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

    Private Sub cargarTipoOperacion()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(1, "GRAVADA")
        data.Rows.Add(2, "EXPORTACION")
        data.Rows.Add(3, "EXONERADO")
        data.Rows.Add(4, "INAFECTO")
        With cboOperacion
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub

    Private Sub cargarMonedas()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListarBD("select id,('('+codigo+') '+descripcion) as 'descripcion' from tipo_moneda where estado=1 order by codigo asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboMoneda
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
                .SelectedIndex = 2
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Monedas")
        End Try
    End Sub

    Private Sub frmNuevaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvOperaciones.RowTemplate.Height = 40
        cebrasDatagrid(dgvOperaciones, Drawing.Color.White, Drawing.Color.FromArgb(182, 205, 226))
        cargarMonedas()
        CargarTipoDocumento()
        cargarTipoOperacion()
        cargarTipoVenta()
        cargarImpuestosSunat()
        iCarga = 1
        cargarTipoDeCambio()
        With dtPagos.Columns
            .Add("num_cuenta")
            .Add("desc_cuenta")
            .Add("costo")
            .Add("base_imponible")
            .Add("igv")
            .Add("isc")
            .Add("otros_impuestos")
            .Add("descuento")
            .Add("total")
        End With
    End Sub

    'Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If e.KeyChar = Convert.ToChar(Keys.Enter) Then
    '        If txtCuenta.Text.Trim.Length >= 2 Then
    '            With frmEscogerPlanContable
    '                .formInicio = "frmNuevaVenta"
    '                .cuentaInicio = txtCuenta.Text.Trim
    '                .ShowDialog()
    '            End With
    '        End If

    '    End If
    'End Sub

    Private Sub btnBuscarRuc_Click(sender As Object, e As EventArgs) Handles btnBuscarRuc.Click
        frmConsultaSunat.numRuc = txtRuc.Text
        frmConsultaSunat.ShowDialog()
    End Sub

    Private Sub txtRazonSocial_TextChanged(sender As Object, e As EventArgs) Handles txtRazonSocial.TextChanged
        txtGlosa.Text = txtRuc.Text.Trim & ", " & txtRazonSocial.Text.Trim & " - VENTA DE MERCADERIA"
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub cboMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMoneda.SelectedIndexChanged
        cargarTipoDeCambio()
    End Sub
    Private Sub cargarTipoDeCambio()
        If iCarga = 1 Then
            Dim data As New DataTable
            data = objMon.nTipoDeCambioPorMonedaBD(cboMoneda.SelectedValue.ToString, CadenaConexion)
            If data.Rows.Count > 0 Then
                txtTipoCambio.Text = data.Rows(0)("venta").ToString
            Else
                txtTipoCambio.Text = "1.00"
            End If
        End If
    End Sub

    Private Sub cboOperacion_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cboOperacion.SelectedValue.ToString = "3" Or cboOperacion.SelectedValue.ToString = "4" Then
            txtIgv.Text = 0
        End If
    End Sub

    Private Sub txtMonto_TextChanged(sender As Object, e As EventArgs) Handles txtMonto.TextChanged
        Dim dataIgv As New DataTable
        dataIgv = objCrud.nCrudListarBD("select * from igv", CadenaConexion)
        Dim totalConIgv As Decimal
        totalConIgv = Format(txtMonto.Text * (1 + (dataIgv.Rows(0)("valor").ToString) / 100), "#,##0.00")
        txtIgv.Text = Format(txtMonto.Text * ((dataIgv.Rows(0)("valor").ToString) / 100), "#,##0.00")
        txtTotal.Text = totalConIgv
    End Sub
    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cargarItemPagos()
        End If
    End Sub

    Private Sub cargarItemPagos()
        Dim dtItemPagos As New DataTable
        With dtItemPagos.Columns
            .Add("num_cuenta")
            .Add("desc_cuenta")
            .Add("costo")
            .Add("base_imponible")
            .Add("igv")
            .Add("isc")
            .Add("otros_impuestos")
            .Add("descuento")
            .Add("total")
        End With
        dtItemPagos.Rows.Add(txtCuentaD.Text.Trim, _
                        lblNomCuentaD.Text, _
                        txtCosto.Text.Trim, _
                        txtMonto.Text.Trim, _
                        txtIgv.Text.Trim, _
                        "0.00", _
                        "0.00", _
                        "0.00", _
                        txtTotal.Text.Trim)
        dtPagos.Merge(dtItemPagos)
        dgvOperaciones.DataSource = dtPagos
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim dtVentaCab, dtAsientoCab As New DataTable
        With dtVentaCab.Columns
            .Add("impuesto")
            .Add("numero_impuesto")
            .Add("cuenta_comp")
            .Add("tipo_documento_comp")
            .Add("serie_comp")
            .Add("numero_comp")
            .Add("moneda_id")
            .Add("tc_comp")
            .Add("ruc")
            .Add("razon")
            .Add("glosa")
        End With

        With dtAsientoCab.Columns
            .Add("num_cuenta")
            .Add("desc_cuenta")
            .Add("base_imponible")
            .Add("igv")
            .Add("total")
        End With

        dtVentaCab.Rows.Add(cboImpuestos.SelectedValue.ToString, txtNumeroI.Text.Trim, txtCuentaP.Text.Trim, _
                       cboTipoDocumento.SelectedValue.ToString, _
                       txtSerie.Text.Trim, _
                       txtNumero.Text.Trim, _
                       cboMoneda.SelectedValue.ToString, _
                       txtTipoCambio.Text.Trim, _
                       txtRuc.Text.Trim, _
                       txtRazonSocial.Text.Trim, _
                       txtGlosa.Text.Trim)

        Dim tCosto, tMonto, tIgv, tVenta As Decimal

        For Each row As DataGridViewRow In dgvOperaciones.Rows
            tCosto += row.Cells("costo").Value
            tMonto += row.Cells("base_imponible").Value
            tIgv += row.Cells("digv").Value
            tVenta += row.Cells("total").Value
            dtAsientoCab.Rows.Add(txtCuentaP.Text.Trim, _
                lblCuenta.Text.Trim, _
                row.Cells("base_imponible").Value, _
                row.Cells("digv").Value,
                row.Cells("total").Value)
        Next

        With frmPagoComprobanteVenta
            .tipoVenta = cboTipoVenta.SelectedValue
            .fechaPago = dtFechaPago.Value().ToString("yyyy-MM-dd")
            .totalCosto = Format(tCosto, "#,##0.00")
            .totalMonto = Format(tMonto, "#,##0.00")
            .totalIgv = Format(tIgv, "#,##0.00")
            .totalVenta = Format(tVenta, "#,##0.00")
            .dtCabeceraVenta = dtVentaCab
            .dtAsientoVenta = dtAsientoCab
            .txtMonto.Text = .totalVenta
            .Show()
        End With
    End Sub

    Private Sub btnNuevaCompra_Click(sender As Object, e As EventArgs) Handles btnNuevaCompra.Click
        frmNuevaCompra.Show()
    End Sub

    Private Sub btnAgregar_Click_1(sender As Object, e As EventArgs) Handles btnAgregar.Click
        cargarItemPagos()
    End Sub

    Private Sub cboImpuestos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboImpuestos.SelectedIndexChanged
        If iCarga = 1 Then
            If cboImpuestos.SelectedValue.ToString <> "0" Then
                panelImpuesto.Enabled = True
            Else
                panelImpuesto.Enabled = False
            End If
        End If
    End Sub
End Class