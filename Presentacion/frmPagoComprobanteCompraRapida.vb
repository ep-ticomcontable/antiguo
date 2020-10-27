Imports Negocio
Imports Entidades

Public Class frmPagoComprobanteCompraRapida

    Public dtCabeceraVenta, dtAsientoVenta As New DataTable
    Public totalCompra, totalCosto, totalMonto, totalIsc, totalIgv As Decimal
    Dim iCarga As Integer = 0
    Public serieDua, numeroDua, tipoCompra As String
    Public anioDua As Date
    Public fechaPago As Date

    Public checkDetraccion As Boolean

    Dim objCrud As New nCrud
    Dim objMon As New nMonedas
    Dim objCA As New nCuentaAsiento
    Dim objTDA As New nTipoDocumentoAsiento
    Dim objCC As New nComprobanteCompra
    Dim objCoCom As New nCostoCompras
    Dim objAC As New nAsientosContables
    Dim objTP As New nTipoPagos
    Dim idTipoOperacion As Integer = 2


    Private Sub cargarCuentasVentaApertura()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = objCA.nListarCuentasSegunTipoAsiento("VENTA_APERTURA")
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(1).ToString, row.Item(1).ToString)
            Next
            With cboCuentaVenta
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Cuentas")
        End Try
    End Sub

    Private Sub cargarDatosDeDatatableVenta()
        With dtCabeceraVenta
            cboCuentaVenta.Text = .Rows(0)("cuenta_comp").ToString
            cboTipoDocumento.SelectedValue = .Rows(0)("tipo_documento_comp").ToString
            txtSerie.Text = .Rows(0)("serie_comp").ToString
            txtNumero.Text = .Rows(0)("numero_comp").ToString
            cboMoneda.SelectedValue = .Rows(0)("moneda_id").ToString
            txtTipoCambio.Text = .Rows(0)("tc_comp").ToString
            txtRuc.Text = .Rows(0)("ruc").ToString
            txtRazonSocial.Text = .Rows(0)("razon").ToString
            txtGlosa.Text = .Rows(0)("glosa").ToString
            txtMonto.Text = totalCompra
        End With

        'Dim dtData As New DataTable
        'With dtData.Columns
        '    .Add("num_cuenta")
        '    .Add("desc_cuenta")
        '    .Add("debe")
        '    .Add("haber")
        '    .Add("id_tipo_pago")
        '    .Add("documento_pago")
        '    .Add("descripcion_pago")
        'End With

        'Dim tIgv, tMonto, tTotal As Decimal
        'For i As Integer = 0 To dtAsientoVenta.Rows.Count - 1
        '    tMonto += dtAsientoVenta.Rows(i)("base_imponible")
        '    tIgv += dtAsientoVenta.Rows(i)("igv")
        '    tTotal += dtAsientoVenta.Rows(i)("total")
        'Next

        'tTotal = Format(tTotal, "#,##0.00")
        ''dtData.Rows.Add("1211", "CUENTAS POR COBRAR", tTotal, "00.00", "0", "-", "-")
        ''dtData.Rows.Add("401", "IGV", "00.00", totalIgv, "0", "-", "-")

        'For i As Integer = 0 To dtAsientoVenta.Rows.Count - 1
        '    dtData.Rows.Add(dtAsientoVenta.Rows(i)("num_cuenta"), dtAsientoVenta.Rows(i)("desc_cuenta"), dtAsientoVenta.Rows(i)("base_imponible"), "00.00", "0", "-", "-")
        'Next

        'Dim dataCab As New DataTable
        'dataCab = objCrud.nCrudListarBD("select * from asiento_cuentas_cabecera where asiento='COMPRA' order by orden asc")
        'For i As Integer = 0 To dataCab.Rows.Count - 1
        '    dtData.Rows.Add(dataCab.Rows(i)("cuenta").ToString, obtenerDatosCuenta(dataCab.Rows(i)("cuenta").ToString), (IIf((dataCab.Rows(i)("movimiento").ToString = "D"), (IIf((dataCab.Rows(i)("cuenta").ToString.StartsWith("40") And dataCab.Rows(i)("movimiento").ToString = "D"), totalIgv, tTotal)), "00.00")), (IIf((dataCab.Rows(i)("movimiento").ToString = "H"), (IIf((dataCab.Rows(i)("cuenta").ToString.StartsWith("42") And dataCab.Rows(i)("movimiento").ToString = "H"), tTotal, totalIgv)), "00.00")), 0, "-", "TRIBUTOS Y CUENTAS")
        'Next

        ''Agregar costos
        'If dtAsientoVenta.Rows(0)("num_cuenta").ToString.StartsWith(60) Then
        '    Dim dt As New DataTable
        '    dt = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & dtAsientoVenta.Rows(0)("num_cuenta").ToString & "'")
        '    'MsgBox(obtenerDatosCuenta(dt.Rows(0)("cuenta_debe").ToString) & "-" & obtenerDatosCuenta(dt.Rows(1)("cuenta_haber").ToString))
        '    dtData.Rows.Add(dt.Rows(0)("cuenta_debe").ToString, obtenerDatosCuenta(dt.Rows(0)("cuenta_debe").ToString), totalCosto, "00.00", "0", "-", "MOVIMIENTO DE EXISTENCIAS")
        '    dtData.Rows.Add(dt.Rows(0)("cuenta_haber").ToString, obtenerDatosCuenta(dt.Rows(0)("cuenta_haber").ToString), "00.00", totalCosto, "0", "-", "MOVIMIENTO DE EXISTENCIAS")
        'End If

        ''dtData.Rows.Add("401", "TRIBUTOS IGV", totalIgv, "00.00", "0", "-", "-")
        ''dtData.Rows.Add("42", "CUENTAS POR PAGAR", "00.00", tTotal, "0", "-", "-")

        ''dtData.Rows.Add("20", "MECADERIAS", totalCosto, "00.00", "0", "-", "-")
        ''dtData.Rows.Add("61", "VARIACION DE EXISTENCIAS", "00.00", totalCosto, "0", "-", "-")
        'dgvLista.DataSource = dtData
        'realizarSumasTotales()
    End Sub

    Private Function obtenerDatosCuenta(cuenta As String) As String

        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString

    End Function

    Private Sub realizarSumasTotales()
        Dim tDebe, tHaber, tDiferencia As Decimal
        For Each row As DataGridViewRow In dgvLista.Rows
            tDebe += row.Cells("debe").Value
            tHaber += row.Cells("haber").Value
        Next
        tDiferencia = tDebe - tHaber

        txtTDebeS.Text = Format(tDebe, "#,##0.00")
        txtTHaberS.Text = Format(tHaber, "#,##0.00")
        txtDiferenciaS.Text = Format(tDiferencia, "#,##0.00")
        txtTDebeD.Text = Format((tDebe * Decimal.Parse(txtTipoCambio.Text.Trim)), "#,##0.00")
        txtTHaberD.Text = Format((tHaber * Decimal.Parse(txtTipoCambio.Text.Trim)), "#,##0.00")
        txtDiferenciaD.Text = Format((tDiferencia * Decimal.Parse(txtTipoCambio.Text.Trim)), "#,##0.00")
    End Sub

    Private Sub cargarTipoPagos()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = objTP.nListaTipoPagos()
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboTipoPago
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Documentos")
        End Try
    End Sub

    Private Sub CargarTipoDocumento()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = objTDA.nListarCuentasSegunTipoAsiento(idTipoOperacion)
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


    Private Sub cargarMonedas()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListarBD("select id,codigo,descripcion from tipo_moneda where estado=1 order by codigo asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, "(" & row.Item(2).ToString & ") " & row.Item(1).ToString)
            Next
            With cboMoneda
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
                .SelectedValue = 115
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Monedas")
        End Try
    End Sub
    Private Sub cargarTipoCompra()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add("CREDITO", "CREDITO")
        data.Rows.Add("CONTADO", "CONTADO")
        With cboTipoCompra
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub
    Private Sub frmDetalleComprobanteCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLista.RowTemplate.Height = 28
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(182, 205, 226))
        cargarCuentasVentaApertura()
        CargarTipoDocumento()
        cargarTipoPagos()
        cargarMonedas()
        cargarTipoCompra()
        cboTipoCompra.SelectedValue = tipoCompra
        dtFechaPago.Value = fechaPago
        If tipoCompra = "CONTADO" Then
            gbPago.Enabled = True
        ElseIf tipoCompra = "CREDITO" Then
            gbPago.Enabled = False
        End If

        'MsgBox(totalCompra)
        iCarga = 1
        cargarDatosDeDatatableVenta()
        cargarTipoDeCambio()
    End Sub

    Private Sub cargarTipoDeCambio()
        If iCarga = 1 Then
            Dim data As New DataTable
            data = objMon.nTipoDeCambioPorMoneda(cboMoneda.SelectedValue.ToString)
            'lblTipoDeCambio.Text = "Tipo de cambio: S/. " & data.Rows(0)("venta").ToString
            txtTipoCambio.Text = data.Rows(0)("venta").ToString
        End If
    End Sub

    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtCuenta.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "frmPagoComprobanteCompra"
                    .cuentaInicio = txtCuenta.Text.Trim
                    .ShowDialog()
                End With
            End If

        End If
    End Sub

    Private Sub cboMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMoneda.SelectedIndexChanged
        cargarTipoDeCambio()
        If dgvLista.RowCount > 0 Then
            realizarSumasTotales()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        'Dim dataPie As New DataTable
        'dataPie = objCrud.nCrudListarBD("select * from asiento_cuentas_pie where asiento='COMPRA' order by orden asc")
        'For i As Integer = 0 To dataPie.Rows.Count - 1
        '    dtData.Rows.Add(dataPie.Rows(i)("cuenta").ToString, obtenerDatosCuenta(dataPie.Rows(i)("cuenta").ToString), (IIf((dataPie.Rows(i)("movimiento").ToString = "D"), totalCompra, "00.00")), (IIf((dataCab.Rows(i)("movimiento").ToString = "H"), totalCompra, "00.00")), 0, "-", "MOVIMIENTO DE EXISTENCIAS")
        'Next


        Dim dt As DataTable = DirectCast(dgvLista.DataSource, DataTable)

        Dim dt2 As DataTable = DirectCast(dgvLista.DataSource, DataTable)
        Dim row2 As DataRow = dt2.NewRow()
        row2.Item(0) = "421"
        row2.Item(1) = "FACTURAS, BOLETAS Y OTROS COMPROBANTES POR PAGAR"
        row2.Item(2) = totalCompra
        row2.Item(3) = "00.00"
        row2.Item(4) = cboTipoPago.SelectedValue
        row2.Item(5) = cboTipoPago.Text
        row2.Item(6) = txtDescripcion.Text
        dt2.Rows.Add(row2)

        Dim row As DataRow = dt.NewRow()
        row.Item(0) = txtCuenta.Text.Trim
        row.Item(1) = lblNomCuenta.Text
        row.Item(2) = "00.00"
        row.Item(3) = txtMonto.Text.Trim()
        row.Item(4) = cboTipoPago.SelectedValue
        row.Item(5) = cboTipoPago.Text
        row.Item(6) = txtDescripcion.Text
        dt.Rows.Add(row)

        If checkDetraccion = True Then
            Dim row3 As DataRow = dt.NewRow()
            row3.Item(0) = "1041"
            row3.Item(1) = "CUENTAS CORRIENTES OPERATIVAS"
            row3.Item(2) = "00.00"
            'row3.Item(3) = txtValorDetraccion.Text.Trim()
            'row3.Item(4) = cboTipoTasa.SelectedValue
            'row3.Item(5) = cboTipoTasa.Text
            'row3.Item(6) = "N° DET: " & txtNumDetraccion.Text & " / TASA: " & txtTasaDetraccion.Text & "% / " & txtValorDetraccion.Text & " / FEC: " & dtFechaDetraccion.Value
            dt.Rows.Add(row3)
        End If

        realizarSumasTotales()

    End Sub

    Private Sub cboCuentaVenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCuentaVenta.SelectedIndexChanged
        If iCarga = 1 Then
            Dim data As New DataTable
            data = objCA.nObtenerCuentaSegunId(cboCuentaVenta.SelectedValue.ToString)
            lblCuentaVenta.Text = data.Rows(0)("nombre")
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim entiCCompraAsiento, entiCCompra As New ComprobanteCompraEntity
        Dim entiCostoCompra As New CostoComprasEntity

        With entiCCompra
            .tipo_compra = tipoCompra
            .id_tipo_comprobante = cboTipoDocumento.SelectedValue.ToString
            .fec_emision = dtFechaEmision.Value.ToString("yyyy-MM-dd")
            .fec_pago = fechaPago
            .serie_comprobante = txtSerie.Text
            .numero_comprobante = txtNumero.Text
            .cod_dni = "6"
            .num_dni = txtRuc.Text.Trim
            .razon_social = txtRazonSocial.Text.Trim
            .valor_facturado = totalMonto
            .glosa = txtGlosa.Text
            .id_moneda = cboMoneda.SelectedValue.ToString
            .valor_igv = totalIgv
            .total = totalMonto + totalIgv + totalIsc
            .tipo_cambio = txtTipoCambio.Text.Trim
            .detraccion = 1 'IIf((checkDetraccion = True), "1", "0")
            .estado = 1
            .id_usuario = CodigoUsuarioSession
        End With
        MsgBox("REGISTRANDO COMPROBANTE DE COMPRA: " & objCC.nRegistrarComprobanteCompra(entiCCompra))

        With entiCCompraAsiento
            .numero_cuo = objCC.nObtenerCUO_Compra()
            .tipo_compra = tipoCompra
            .numero_maquina = "-"
            .id_tipo_comprobante = cboTipoDocumento.SelectedValue.ToString
            .fec_emision = dtFechaEmision.Value()
            .fec_pago = fechaPago
            .serie_comprobante = txtSerie.Text
            .numero_comprobante = txtNumero.Text
            .cod_dni = "6"
            .num_dni = txtRuc.Text.Trim
            .razon_social = txtRazonSocial.Text.Trim
            .valor_facturado = totalMonto
            .base_imponible = totalMonto
            .valor_exonerado = 0
            .valor_inafecto = 0
            .valor_isc = totalIsc
            .valor_igv = totalIgv
            .otros_base_imponible = 0
            .total = totalMonto + totalIgv + totalIsc
            .tipo_cambio = txtTipoCambio.Text.Trim
            .fec_comp_origen = dtFechaEmision.Value.ToString("yyyy-MM-dd")
            '.tip_comp_origen = cboTipoDocumento2.SelectedValue.ToString
            '.serie_comp_origen = txtSerieP.Text.Trim
            '.numero_comp_origen = txtSerieP.Text.Trim
            .serie_dua = serieDua
            .numero_dua = numeroDua
            .anio_dua = anioDua
            '.numero_detraccion = txtNumDetraccion.Text
            '.tipo_tasa_detraccion = cboTipoTasa.SelectedValue
            '.tasa_detraccion = txtTasaDetraccion.Text
            '.valor_detraccion = txtValorDetraccion.Text
            '.fecha_detraccion = dtFechaDetraccion.Value
            .estado = 1
        End With

        For Each row As DataGridViewRow In dgvLista.Rows
            entiCCompraAsiento.tip_comp_origen = row.Cells("id_tipo_pago").Value
            entiCCompraAsiento.serie_comp_origen = row.Cells("documento_pago").Value
            entiCCompraAsiento.numero_comp_origen = row.Cells("descripcion_pago").Value
            entiCCompraAsiento.cuenta = row.Cells("num_cuenta").Value
            entiCCompraAsiento.glosa = txtGlosa.Text
            entiCCompraAsiento.debe = row.Cells("debe").Value
            entiCCompraAsiento.haber = row.Cells("haber").Value
            'MsgBox("REGISTRANDO ASIENTO COMPROBANTE DE COMPRA: " & objCC.nRegistrarAsientoComprobanteCompra(entiCCompraAsiento))
            objCC.nRegistrarAsientoComprobanteCompra(entiCCompraAsiento)
            If row.Cells("num_cuenta").Value.ToString.StartsWith("61") Then
                With entiCostoCompra
                    .id_cuenta = row.Cells("num_cuenta").Value.ToString
                    .numero_cuo = entiCCompraAsiento.numero_cuo
                    .debe = "00.00"
                    .haber = row.Cells("haber").Value
                End With
                'MsgBox(objCoCom.nRegistrarCostoDeCompras(entiCostoCompra))
                objCoCom.nRegistrarCostoDeCompras(entiCostoCompra)
            ElseIf row.Cells("num_cuenta").Value.ToString.StartsWith("20") Then
                With entiCostoCompra
                    .id_cuenta = row.Cells("num_cuenta").Value.ToString
                    .numero_cuo = entiCCompraAsiento.numero_cuo
                    .debe = row.Cells("debe").Value
                    .haber = "00.00"
                End With
                'MsgBox(objCoCom.nRegistrarCostoDeCompras(entiCostoCompra))
                objCoCom.nRegistrarCostoDeCompras(entiCostoCompra)
            End If
        Next
        Me.Close()
        frmNuevaCompra.Close()
        frmListaCompras.Show()
        frmListaLibroDiario.Show()
    End Sub


End Class
