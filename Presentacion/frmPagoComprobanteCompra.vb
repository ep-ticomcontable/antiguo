Imports Negocio
Imports Entidades

Public Class frmPagoComprobanteCompra

    Public dtCabeceraVenta, dtAsientoVenta As New DataTable
    Public totalCompra, totalCosto, totalMonto, totalIsc, totalIgv As Decimal
    Dim iCarga As Integer = 0
    Public serieDua, numeroDua, tipoCompra As String
    Public anioDua As Date
    Public fechaPago As Date

    Public checkDetraccion As String

    Dim objCrud As New nCrud
    Dim objMon As New nMonedas
    Dim objCA As New nCuentaAsiento
    Dim objTDA As New nTipoDocumentoAsiento
    Dim objCC As New nComprobanteCompra
    Dim objCoCom As New nCostoCompras
    Dim objAC As New nAsientosContables
    Dim objTP As New nTipoPagos
    Dim objDet As New nDetraccion
    Dim idTipoOperacion As Integer = 2

    Private Sub cargarImpuestosSunat()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListarBD("select * from impuestos_sunat where tipo_comprobante='COMPRA'", CadenaConexion)
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

    Private Sub cargarDatosDeDatatableVenta()
        With dtCabeceraVenta
            txtCuentaP.Text = .Rows(0)("cuenta_comp").ToString
            cboImpuestos.SelectedValue = .Rows(0)("impuesto").ToString
            txtNumeroI.Text = .Rows(0)("numero_impuesto").ToString
            If .Rows(0)("impuesto").ToString <> "0" Then
                Dim dataI As New DataTable
                dataI = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & .Rows(0)("impuesto").ToString & "'", CadenaConexion)
                lblImpuesto.Text = "Cálculo " & dataI.Rows(0)("porcentaje").ToString & "%:"
                txtCalculo.Text = (txtMonto.Text.Trim * dataI.Rows(0)("porcentaje").ToString) / 100
                If dataI.Rows(0)("descripcion").ToString.StartsWith("PER") Then
                    txtSaldo.Text = Decimal.Parse(txtMonto.Text.Trim) + Decimal.Parse(txtCalculo.Text.Trim)
                Else
                    txtSaldo.Text = Decimal.Parse(txtMonto.Text.Trim) - Decimal.Parse(txtCalculo.Text.Trim)
                End If
            End If


            Dim dataC As New DataTable
            dataC = objCA.nObtenerCuentaSegunIdBD(txtCuentaP.Text.Trim, CadenaConexion)
            lblCuenta.Text = dataC.Rows(0)("nombre").ToString
            cboTipoDocumento.SelectedValue = .Rows(0)("tipo_documento_comp").ToString
            txtSerie.Text = .Rows(0)("serie_comp").ToString
            txtNumero.Text = .Rows(0)("numero_comp").ToString
            cboMoneda.SelectedValue = .Rows(0)("moneda_id").ToString
            txtTipoCambio.Text = .Rows(0)("tc_comp").ToString
            txtRuc.Text = .Rows(0)("ruc").ToString
            txtRazonSocial.Text = .Rows(0)("razon").ToString
            txtGlosa.Text = .Rows(0)("glosa").ToString
        End With
        Dim dtData As New DataTable
        With dtData.Columns
            .Add("num_cuenta")
            .Add("desc_cuenta")
            .Add("debe")
            .Add("haber")
            .Add("descripcion")
        End With

        Dim tIgv, tMonto, tTotal As Decimal
        For i As Integer = 0 To dtAsientoVenta.Rows.Count - 1
            tMonto += dtAsientoVenta.Rows(i)("base_imponible")
            tIgv += dtAsientoVenta.Rows(i)("igv")
            tTotal += dtAsientoVenta.Rows(i)("total")
        Next
        If cboImpuestos.SelectedValue.ToString <> "0" Then
            panelImpuestos.Enabled = True
            tTotal = txtSaldo.Text.Trim
        Else
            panelImpuestos.Enabled = False
            tTotal = txtMonto.Text.Trim
        End If
        For i As Integer = 0 To dtAsientoVenta.Rows.Count - 1
            dtData.Rows.Add(dtAsientoVenta.Rows(i)("num_cuenta"), dtAsientoVenta.Rows(i)("desc_cuenta"), dtAsientoVenta.Rows(i)("base_imponible"), "00.00", "-")
        Next

        If cboImpuestos.SelectedValue.ToString <> "0" Then
            'AGREGAR IMPUESTOS DE SUNAT
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim dtI As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
            Dim dataIC As New DataTable
            dataIC = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & cboImpuestos.SelectedValue.ToString & "'", CadenaConexion)
            If dataIC.Rows(0)("descripcion").ToString.StartsWith("PER") Then
                Dim dataCC As New DataTable
                dataCC = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & dataIC.Rows(0)("cuenta").ToString & "'", CadenaConexion)
                dtData.Rows.Add(dataIC.Rows(0)("cuenta").ToString, dataCC.Rows(0)("nombre").ToString, txtCalculo.Text.Trim, "00.00", "POR " & cboImpuestos.Text & ": N° " & txtNumeroI.Text.Trim)
            End If
        End If

        Dim dataCab As New DataTable
        dataCab = objCrud.nCrudListarBD("select * from asiento_cuentas_cabecera where asiento='COMPRA' order by orden asc", CadenaConexion)
        For i As Integer = 0 To dataCab.Rows.Count - 1
            dtData.Rows.Add(dataCab.Rows(i)("cuenta").ToString, obtenerDatosCuenta(dataCab.Rows(i)("cuenta").ToString), (IIf((dataCab.Rows(i)("movimiento").ToString = "D"), (IIf((dataCab.Rows(i)("cuenta").ToString.StartsWith("40") And dataCab.Rows(i)("movimiento").ToString = "D"), totalIgv, tTotal)), "00.00")), (IIf((dataCab.Rows(i)("movimiento").ToString = "H"), (IIf((dataCab.Rows(i)("cuenta").ToString.StartsWith("42") And dataCab.Rows(i)("movimiento").ToString = "H"), tTotal, totalIgv)), "00.00")), "-")
        Next

        'Agregar costos
        If dtAsientoVenta.Rows(0)("num_cuenta").ToString.StartsWith(60) Then
            Dim dt As New DataTable
            dt = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & dtAsientoVenta.Rows(0)("num_cuenta").ToString & "'", CadenaConexion)
            dtData.Rows.Add(dt.Rows(0)("cuenta_debe").ToString, obtenerDatosCuenta(dt.Rows(0)("cuenta_debe").ToString), totalCosto, "00.00", "-")
            dtData.Rows.Add(dt.Rows(0)("cuenta_haber").ToString, obtenerDatosCuenta(dt.Rows(0)("cuenta_haber").ToString), "00.00", totalCosto, "-")
        End If
        dgvOperaciones.DataSource = dtData
        realizarSumasTotales()
    End Sub

    Private Function obtenerDatosCuenta(cuenta As String) As String

        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function

    Private Sub realizarSumasTotales()
        Dim tDebe, tHaber, tDiferencia As Decimal
        For Each row As DataGridViewRow In dgvOperaciones.Rows
            tDebe += row.Cells("debe").Value
            tHaber += row.Cells("haber").Value
        Next
        tDiferencia = tDebe - tHaber

        txtTDebeS.Text = Format(tDebe, "#,##0.00")
        txtTHaberS.Text = Format(tHaber, "#,##0.00")
        txtDiferenciaS.Text = Format(tDiferencia, "#,##0.00")
    End Sub

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
        dgvOperaciones.RowTemplate.Height = 28
        cebrasDatagrid(dgvOperaciones, Drawing.Color.White, Drawing.Color.FromArgb(182, 205, 226))
        CargarTipoDocumento()
        cargarImpuestosSunat()
        cargarMonedas()
        cargarTipoCompra()
        cboTipoCompra.SelectedValue = tipoCompra
        dtFechaPago.Value = fechaPago
        iCarga = 1
        cargarDatosDeDatatableVenta()
        cargarTipoDeCambio()
    End Sub

    Private Sub cargarTipoDeCambio()
        If iCarga = 1 Then
            Dim data As New DataTable
            data = objMon.nTipoDeCambioPorMonedaBD(cboMoneda.SelectedValue.ToString, CadenaConexion)
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
        If dgvOperaciones.RowCount > 0 Then
            realizarSumasTotales()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        
        '''''CUENTA 42
        Dim dt2 As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
        Dim row2 As DataRow = dt2.NewRow()
        row2.Item(0) = "421"
        row2.Item(1) = "FACTURAS, BOLETAS Y OTROS COMPROBANTES POR PAGAR"
        row2.Item(2) = IIf(cboImpuestos.SelectedValue.ToString <> "0", txtSaldo.Text.Trim, txtMonto.Text.Trim)
        row2.Item(3) = "00.00"
        row2.Item(4) = txtDescripcion.Text.Trim
        dt2.Rows.Add(row2)
        ''''''''''''''''''''''''FIN CUENTA 42''''''''''''''''''''''''''''''''''''''
        Dim dt As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
        Dim row As DataRow = dt.NewRow()
        row.Item(0) = txtCuenta.Text.Trim
        row.Item(1) = lblNomCuenta.Text
        row.Item(2) = "00.00"
        row.Item(3) = IIf(cboImpuestos.SelectedValue.ToString <> "0", txtSaldo.Text.Trim, txtMonto.Text.Trim)
        row.Item(4) = txtDescripcion.Text.Trim
        dt.Rows.Add(row)

        If cboImpuestos.SelectedValue.ToString <> "0" Then
            Dim dataIC As New DataTable
            dataIC = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & cboImpuestos.SelectedValue.ToString & "'", CadenaConexion)
            If Not dataIC.Rows(0)("descripcion").ToString.StartsWith("PER") Then
                '''''CUENTA 42 IMPUESTO
                Dim dt3 As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
                Dim row3 As DataRow = dt2.NewRow()
                row3.Item(0) = "421"
                row3.Item(1) = "FACTURAS, BOLETAS Y OTROS COMPROBANTES POR PAGAR"
                row3.Item(2) = txtCalculo.Text.Trim
                row3.Item(3) = "00.00"
                row3.Item(4) = txtDescripcion.Text.Trim
                dt2.Rows.Add(row3)

                Dim dtI As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
                Dim dataCC As New DataTable
                dataCC = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & dataIC.Rows(0)("cuenta").ToString & "'", CadenaConexion)
                Dim row4 As DataRow = dtI.NewRow()
                row4.Item(0) = dataIC.Rows(0)("cuenta").ToString
                row4.Item(1) = dataCC.Rows(0)("nombre").ToString
                row4.Item(2) = "00.00"
                row4.Item(3) = txtCalculo.Text.Trim
                row4.Item(4) = "POR " & cboImpuestos.Text & ": N° " & txtNumeroI.Text.Trim
                dtI.Rows.Add(row4)
            End If
        Else
            ' '''''CUENTA 42 IMPUESTO
            'Dim dt3 As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
            'Dim row3 As DataRow = dt2.NewRow()
            'row3.Item(0) = "421"
            'row3.Item(1) = "FACTURAS, BOLETAS Y OTROS COMPROBANTES POR PAGAR"
            'row3.Item(2) = txtMonto.Text.Trim
            'row3.Item(3) = "00.00"
            'row3.Item(4) = txtDescripcion.Text.Trim
            'dt2.Rows.Add(row3)
        End If
        
        realizarSumasTotales()
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
            .detraccion = 1
            .fec_comp_origen = fechaPago
            .tip_comp_origen = ""
            .serie_comp_origen = ""
            .numero_comp_origen = ""
            .estado = 1
            .id_usuario = CodigoUsuarioSession
        End With
        MsgBox("REGISTRO DE COMPROBANTE DE COMPRA: " & objCC.nRegistrarComprobanteCompraBD(entiCCompra, CadenaConexion))

        Dim entiAbono As New AbonoComprasEntity
        Dim objAbono As New nAbonosPagos
        Dim dataCC As New DataTable
        dataCC = objCrud.nCrudListarBD("select * from comprobante_compra order by id desc", CadenaConexion)
        With entiAbono
            .tipo_comprobante = "-"
            .id_compra = dataCC.Rows(0)("id").ToString
            .monto = txtSaldo.Text.Trim
            .tipo = "EF"
            .numero = "0"
            .descripcion = txtDescripcion.Text.Trim
            .fecha = dtFechaPago.Value
            .estado = "1"
        End With
        'MsgBox("ABONO: " & objAbono.nRegistrarAbonoCompras(entiAbono))

        With entiCCompraAsiento
            .id_comprobante = dataCC.Rows(0)("id").ToString
            .numero_cuo = objCC.nObtenerCUO_CompraBD(CadenaConexion)
            .tipo_compra = tipoCompra
            .numero_maquina = "-"
            .id_tipo_comprobante = cboTipoDocumento.SelectedValue.ToString
            .fec_emision = Date.Parse(dtFechaEmision.Value())
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
            .fec_comp_origen = Date.Parse(dtFechaEmision.Value.ToString("yyyy-MM-dd"))
            .serie_dua = serieDua
            .numero_dua = numeroDua
            .anio_dua = anioDua
            .numero_detraccion = "0"
            .tipo_tasa_detraccion = "0"
            .tasa_detraccion = "0"
            .valor_detraccion = "0"
            .fecha_detraccion = fechaPago
            .estado = 1
        End With

        For Each row As DataGridViewRow In dgvOperaciones.Rows
            entiCCompraAsiento.tip_comp_origen = "-"
            entiCCompraAsiento.serie_comp_origen = txtSerie.Text.Trim
            entiCCompraAsiento.numero_comp_origen = txtNumero.Text.Trim
            entiCCompraAsiento.cuenta = row.Cells("num_cuenta").Value
            entiCCompraAsiento.glosa = txtGlosa.Text
            entiCCompraAsiento.debe = row.Cells("debe").Value
            entiCCompraAsiento.haber = row.Cells("haber").Value
            'MsgBox("REGISTRANDO ASIENTO COMPROBANTE DE COMPRA: " & objCC.nRegistrarAsientoComprobanteCompra(entiCCompraAsiento))
            objCC.nRegistrarAsientoComprobanteCompraBD(entiCCompraAsiento, CadenaConexion)
            If row.Cells("num_cuenta").Value.ToString.StartsWith("60") Then
                With entiCostoCompra
                    .id_comprobante = dataCC.Rows(0)("id").ToString
                    .id_cuenta = row.Cells("num_cuenta").Value.ToString
                    .numero_cuo = entiCCompraAsiento.numero_cuo
                    .debe = "00.00"
                    .haber = row.Cells("haber").Value
                End With
                'MsgBox(objCoCom.nRegistrarCostoDeCompras(entiCostoCompra))
                objCoCom.nRegistrarCostoDeComprasBD(entiCostoCompra, CadenaConexion)
            ElseIf row.Cells("num_cuenta").Value.ToString.StartsWith("20") Then
                With entiCostoCompra
                    .id_comprobante = dataCC.Rows(0)("id").ToString
                    .numero_cuo = entiCCompraAsiento.numero_cuo
                    .id_cuenta = row.Cells("num_cuenta").Value.ToString
                    .debe = row.Cells("debe").Value
                    .haber = "00.00"
                End With
                'MsgBox(objCoCom.nRegistrarCostoDeCompras(entiCostoCompra))
                objCoCom.nRegistrarCostoDeComprasBD(entiCostoCompra, CadenaConexion)
            End If
        Next
        'Me.Close()
        'frmNuevaCompra.Close()
        'frmListaCompras.Show()
        'frmListaLibroDiario.Show()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub cboImpuestos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboImpuestos.SelectedIndexChanged

    End Sub
End Class
