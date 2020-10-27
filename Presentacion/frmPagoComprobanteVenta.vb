Imports Negocio
Imports Entidades

Public Class frmPagoComprobanteVenta

    Public dtCabeceraVenta, dtAsientoVenta As New DataTable
    Public totalVenta, totalCosto, totalMonto, totalIsc, totalIgv As Decimal
    Dim iCarga As Integer = 0
    Public tipoVenta As String
    Public fechaPago As Date

    Dim objCrud As New nCrud
    Dim objMon As New nMonedas
    Dim objCA As New nCuentaAsiento
    Dim objTDA As New nTipoDocumentoAsiento
    Dim objCV As New nComprobanteVenta
    Dim objCoVe As New nCostoVentas
    Dim objAC As New nAsientosContables
    Dim objTP As New nTipoPagos
    Dim idTipoOperacion As Integer = 1

    Private Function obtenerDatosCuenta(cuenta As String) As String

        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function
    Private Sub cargarDatosDeDatatableVenta()
        With dtCabeceraVenta
            txtCuentaP.Text = .Rows(0)("cuenta_comp").ToString
            cboImpuestos.SelectedValue = .Rows(0)("impuesto").ToString
            txtNumeroI.Text = .Rows(0)("numero_impuesto").ToString

            If cboImpuestos.SelectedValue.ToString <> "0" Then
                panelImpuestos.Enabled = True
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
        tTotal = Format(tTotal, "#,##0.00")
        tMonto = Format(tTotal, "#,##0.00")

        If cboImpuestos.SelectedValue.ToString <> "0" Then
            'AGREGAR IMPUESTOS DE SUNAT
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim dtI As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
            Dim dataIC As New DataTable
            dataIC = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & cboImpuestos.SelectedValue.ToString & "'", CadenaConexion)

            For i As Integer = 0 To dtAsientoVenta.Rows.Count - 1
                dtData.Rows.Add(dtAsientoVenta.Rows(i)("num_cuenta"), dtAsientoVenta.Rows(i)("desc_cuenta"), IIf(dataIC.Rows(0)("descripcion").ToString.StartsWith("PER"), txtSaldo.Text.Trim, txtMonto.Text.Trim), "00.00", "-")
            Next

            If dataIC.Rows(0)("descripcion").ToString.StartsWith("PER") Then
                Dim dataCC As New DataTable
                dataCC = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & dataIC.Rows(0)("cuenta").ToString & "'", CadenaConexion)
                dtData.Rows.Add(dataIC.Rows(0)("cuenta").ToString, dataCC.Rows(0)("nombre").ToString, "00.00", txtCalculo.Text.Trim, "POR " & cboImpuestos.Text & ": N° " & txtNumeroI.Text.Trim)
            End If
        Else
            'CUENTA 12 CLIENTES
            Dim dataCC As New DataTable
            dataCC = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & txtCuentaP.Text.Trim & "'", CadenaConexion)
            dtData.Rows.Add(txtCuentaP.Text.Trim, dataCC.Rows(0)("nombre").ToString, totalVenta, "0.00", "-")
        End If


        Dim dataCab As New DataTable
        dataCab = objCrud.nCrudListarBD("select * from asiento_cuentas_cabecera where asiento='VENTA' order by orden asc", CadenaConexion)
        For i As Integer = 0 To dataCab.Rows.Count - 1
            dtData.Rows.Add(dataCab.Rows(i)("cuenta").ToString, obtenerDatosCuenta(dataCab.Rows(i)("cuenta").ToString), (IIf((dataCab.Rows(i)("movimiento").ToString = "D"), (IIf((dataCab.Rows(i)("cuenta").ToString.StartsWith("40") And dataCab.Rows(i)("movimiento").ToString = "H"), totalIgv, tTotal)), "00.00")), (IIf((dataCab.Rows(i)("movimiento").ToString = "H"), (IIf((dataCab.Rows(i)("cuenta").ToString.StartsWith("70") And dataCab.Rows(i)("movimiento").ToString = "H"), totalMonto, totalIgv)), "00.00")), "-")
        Next

        If cboTipoVenta.SelectedValue = "CONTADO" Then
            'Agregar costos
            dtData.Rows.Add("6911", "MERCADERÍAS MANUFACTURADAS", totalCosto, "00.00", "COSTOS")
            dtData.Rows.Add("2011", "MERCADERÍAS MANUFACTURADAS", "00.00", totalCosto, "COSTOS")
        End If
        dgvOperaciones.DataSource = dtData
        realizarSumasTotales()
    End Sub

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
    Private Sub cargarImpuestosSunat()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
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
        data.Rows.Add("CREDITO", "CREDITO")
        data.Rows.Add("CONTADO", "CONTADO")
        With cboTipoVenta
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub

    Private Sub frmDetalleComprobanteVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvOperaciones.RowTemplate.Height = 28
        cebrasDatagrid(dgvOperaciones, Drawing.Color.White, Drawing.Color.FromArgb(182, 205, 226))
        cargarImpuestosSunat()
        CargarTipoDocumento()
        cargarMonedas()
        cargarTipoVenta()
        cboTipoVenta.SelectedValue = tipoVenta
        dtFechaPago.Value = fechaPago
        iCarga = 1
        cargarDatosDeDatatableVenta()
        cargarTipoDeCambio()
        If tipoVenta = "CONTADO" Then
            gbPago.Enabled = True
        ElseIf tipoVenta = "CREDITO" Then
            gbPago.Enabled = False
        End If
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

    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtCuenta.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "frmPagoComprobanteVenta"
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
        If cboImpuestos.SelectedValue.ToString <> "0" Then
            Dim dataIC As New DataTable
            dataIC = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & cboImpuestos.SelectedValue.ToString & "'", CadenaConexion)
            Dim dtI As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)

            Dim dataCC As New DataTable
            dataCC = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & dataIC.Rows(0)("cuenta").ToString & "'", CadenaConexion)

            If Not cboImpuestos.Text.ToString.StartsWith("PER") Then

                '''''CUENTA
                Dim dt3 As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
                Dim row3 As DataRow = dt3.NewRow()
                row3.Item(0) = txtCuenta.Text.Trim
                row3.Item(1) = lblNomCuenta.Text.Trim
                row3.Item(2) = txtCalculo.Text.Trim
                row3.Item(3) = "00.00"
                row3.Item(4) = txtDescripcion.Text.Trim
                dt3.Rows.Add(row3)

                Dim row4 As DataRow = dtI.NewRow()
                row4.Item(0) = dataIC.Rows(0)("cuenta").ToString
                row4.Item(1) = dataCC.Rows(0)("nombre").ToString
                row4.Item(2) = "00.00"
                row4.Item(3) = txtCalculo.Text.Trim
                row4.Item(4) = "POR " & cboImpuestos.Text & ": N° " & txtNumeroI.Text.Trim
                dtI.Rows.Add(row4)

                '''''CUENTA 101 IMPUESTO
                Dim dt5 As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
                Dim row5 As DataRow = dt5.NewRow()
                row5.Item(0) = "101"
                row5.Item(1) = "CAJA"
                row5.Item(2) = txtSaldo.Text.Trim
                row5.Item(3) = "00.00"
                row5.Item(4) = txtDescripcion.Text.Trim
                dt5.Rows.Add(row5)

                Dim dt6 As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
                Dim row6 As DataRow = dtI.NewRow()
                row6.Item(0) = dataIC.Rows(0)("cuenta").ToString
                row6.Item(1) = dataCC.Rows(0)("nombre").ToString
                row6.Item(2) = "00.00"
                row6.Item(3) = txtSaldo.Text.Trim
                row6.Item(4) = txtDescripcion.Text.Trim
                dt6.Rows.Add(row6)

            Else
                Dim dt3 As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
                Dim row3 As DataRow = dt3.NewRow()
                row3.Item(0) = dtAsientoVenta.Rows(0)("num_cuenta").ToString
                row3.Item(1) = dtAsientoVenta.Rows(0)("desc_cuenta").ToString
                row3.Item(2) = txtSaldo.Text.Trim
                row3.Item(3) = "00.00"
                row3.Item(4) = txtDescripcion.Text.Trim
                dt3.Rows.Add(row3)

                Dim row4 As DataRow = dtI.NewRow()
                row4.Item(0) = dataIC.Rows(0)("cuenta").ToString
                row4.Item(1) = dataCC.Rows(0)("nombre").ToString
                row4.Item(2) = "00.00"
                row4.Item(3) = txtSaldo.Text.Trim
                row4.Item(4) = txtDescripcion.Text.Trim
                dtI.Rows.Add(row4)
            End If
        Else
            Dim dt3 As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
            Dim row3 As DataRow = dt3.NewRow()
            row3.Item(0) = dtAsientoVenta.Rows(0)("num_cuenta").ToString
            row3.Item(1) = dtAsientoVenta.Rows(0)("desc_cuenta").ToString
            row3.Item(2) = txtMonto.Text.Trim
            row3.Item(3) = "00.00"
            row3.Item(4) = txtDescripcion.Text.Trim
            dt3.Rows.Add(row3)

            Dim dtI As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
            Dim row4 As DataRow = dtI.NewRow()
            row4.Item(0) = txtCuenta.Text.Trim
            row4.Item(1) = lblNomCuenta.Text
            row4.Item(2) = "00.00"
            row4.Item(3) = txtMonto.Text.Trim
            row4.Item(4) = txtDescripcion.Text.Trim
            dtI.Rows.Add(row4)
        End If

        
        realizarSumasTotales()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim entiCVenta, entiCabVent As New ComprobanteVentaEntity
        Dim entiCostoVenta As New CostoVentasEntity

        With entiCabVent
            .numero_cuo = objAC.nObtenerNumeroCUOBD(CadenaConexion)
            .numero_maquina = "-"
            .id_gravado = 1
            .marca = "0"
            .centro = 0
            .id_moneda = cboMoneda.SelectedValue.ToString
            .estado_comprobante = "F"
            .id_tipo_comprobante = cboTipoDocumento.SelectedValue.ToString
            .fec_emision = dtFechaEmision.Value
            .fec_pago = dtFechaPago.Value
            .tipo_venta = tipoVenta
            .serie_comprobante = txtSerie.Text
            .numero_comprobante = txtNumero.Text
            .cod_dni = "6"
            .num_dni = txtRuc.Text.Trim
            .razon_social = txtRazonSocial.Text.Trim
            .glosa = txtGlosa.Text.Trim
            .valor_facturado = totalMonto
            .base_imponible = totalMonto
            .valor_exonerado = 0
            .valor_inafecto = 0
            .valor_isc = totalIsc
            .valor_igv = totalIgv
            .otros_base_imponible = 0
            .total = totalMonto + totalIgv + totalIsc
            .tipo_cambio = txtTipoCambio.Text.Trim
            .fec_comp_origen = dtFechaEmision.Value
            .tip_comp_origen = "-"
            .serie_comp_origen = "-"
            .numero_comp_origen = "-"
            .estado = 1
            .cuenta = ""
            .debe = 0
            .haber = 0
        End With

        MsgBox("REGISTRO DE COMPROBANTE DE VENTA: " & objCV.nRegistrarComprobanteVentaBD(entiCabVent, CadenaConexion))

        Dim dataComVenta As New DataTable
        Dim dataCV As New DataTable
        dataCV = objCV.obtenerIdComprobanteVentaBD(CadenaConexion)
        With entiCVenta
            .id_asiento_venta = dataCV.Rows("0")("id").ToString
            .id_moneda = cboMoneda.SelectedValue
            .tipo_tasa_detraccion = cboImpuestos.SelectedValue
            .tipo_cambio = txtTipoCambio.Text.Trim
            .tasa_detraccion = txtCalculo.Text.Trim
            .numero_detraccion = txtNumeroI.Text.Trim
            .valor_detraccion = txtCalculo.Text.Trim
            .fecha_detraccion = Date.Parse(dtFechaEmision.Value)
            .fec_emision = Date.Parse(dtFechaEmision.Value)
            .id_tipo_comprobante = cboTipoDocumento.SelectedValue.ToString
            .numero_comprobante = txtNumero.Text
        End With

        For Each row As DataGridViewRow In dgvOperaciones.Rows
            entiCVenta.cuenta = row.Cells("num_cuenta").Value
            entiCVenta.debe = row.Cells("debe").Value
            entiCVenta.haber = row.Cells("haber").Value
            entiCVenta.glosa = txtGlosa.Text.Trim
            MsgBox("REGISTRO ASIENTO COMPROBANTE DE VENTA: " & objCV.nRegistrarDetalleAsientoVentaBD(entiCVenta, CadenaConexion))


            If row.Cells("num_cuenta").Value.ToString.StartsWith("69") Then
                With entiCostoVenta
                    .id_comprobante = dataCV.Rows("0")("id").ToString
                    .id_cuenta = row.Cells("num_cuenta").Value.ToString
                    .numero_cuo = entiCVenta.numero_cuo
                    .debe = row.Cells("debe").Value
                    .haber = "00.00"
                End With
                MsgBox("COSTO REGISTRADO: " & objCoVe.nRegistrarCostoDeVentasBD(entiCostoVenta, CadenaConexion))
                ' objCoVe.nRegistrarCostoDeVentas(entiCostoVenta)
            ElseIf row.Cells("num_cuenta").Value.ToString.StartsWith("20") Then
                With entiCostoVenta
                    .id_comprobante = dataCV.Rows("0")("id").ToString
                    .id_cuenta = row.Cells("num_cuenta").Value.ToString
                    .numero_cuo = entiCVenta.numero_cuo
                    .debe = "00.00"
                    .haber = row.Cells("haber").Value
                End With
                MsgBox("COSTO REGISTRADO: " & objCoVe.nRegistrarCostoDeVentasBD(entiCostoVenta, CadenaConexion))
                'objCoVe.nRegistrarCostoDeVentas(entiCostoVenta)
            End If
        Next

        Dim dataVenta As New DataTable
        dataVenta = objCrud.nCrudListarBD("select top 1 * from comprobante_venta order by id desc", CadenaConexion)
        Dim codVenta As String
        codVenta = dataVenta.Rows(0)("id").ToString
        Dim EntiAboCom As New AbonoVentasEntity
        Dim EntiAsientoAboCom As New AbonoComprasEntity
        With EntiAboCom
            .id_venta = codVenta
            .tipo_comprobante = dataVenta.Rows(0)("id_tipo_comprobante").ToString
            .monto = txtMonto.Text.Trim
            .id_banco = "0"
            .id_caja = "1"
            .tipo = "8"
            .numero = "0"
            .descripcion = txtGlosa.Text.Trim
            .fecha = DateTime.Now.ToString("yyyy/MM/dd") & " " & Now.ToString("HH:mm:ss")
            .estado = "1"
            .tipo_abono = "NORMAL"
        End With
        Dim objAbono As New nAbonosPagos
        objAbono.nRegistrarAbonoVentasBD(EntiAboCom, CadenaConexion)

        For Each row As DataGridViewRow In dgvOperaciones.Rows
            With EntiAsientoAboCom
                .id = objAbono.nObtenerUltimoAbonoVenta(CadenaConexion)
                .id_cliente = dataVenta.Rows(0)("num_dni").ToString
                .id_compra = codVenta
                .cuenta = row.Cells("num_cuenta").Value
                .base_imponible = txtMonto.Text.Trim
                .nro_detraccion = "0"
                .tipo_tasa_detraccion = "0"
                .valor_tasa = "0"
                .valor_detraccion = "0"
                .fecha_detraccion = frmNuevaVenta.dtFechaPago.Value.ToString("yyyy/MM/dd")
                .monto = txtMonto.Text.Trim
                .tipo = "8"
                .descripcion = txtGlosa.Text.Trim
                .debe = row.Cells("debe").Value
                .haber = row.Cells("haber").Value
                .fecha = frmNuevaVentaMercaderias.dtFechaPago.Value.ToString("yyyy/MM/dd")
                .estado = 1
            End With
            objAbono.nRegistrarAsientoAbonoVentas(EntiAsientoAboCom, CadenaConexion)
            'MsgBox("ASIENTOS ABONOS: " & objAbono.nRegistrarAsientoAbonoVentasBD(EntiAsientoAboCom, CadenaConexion))
        Next

    End Sub

End Class

