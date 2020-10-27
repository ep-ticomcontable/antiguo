Imports Negocio
Imports Entidades
Public Class frmNuevaVentaMercaderiaPago
    Dim objCrud As New nCrud
    Public procesoVenta As String = ""

    Private Sub frmNuevaVentaMercaderiaPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCuenta.Select()
        txtMonto.Text = frmNuevaVentaMercaderias.txtTotalVenta.Text.Trim
        txtGlosa.Text = "POR EL COBRO DE LA " & frmNuevaVentaMercaderias.cboTipoDocumento.Text & " " & frmNuevaVentaMercaderias.txtSerie.Text.Trim & "-" & frmNuevaVentaMercaderias.txtNumero.Text.Trim
    End Sub
    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cargarCuentaContable()
            txtMonto.Focus()
        End If
    End Sub
    Private Sub cargarCuentaContable()
        If txtCuenta.Text.Trim.Length >= 2 Then
            With frmEscogerPlanContable
                .formInicio = "cuentaPagoVentaRapida"
                .cuentaInicio = txtCuenta.Text.Trim
                .ShowDialog()
            End With
        End If
    End Sub
    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim cuenta As String = ""
        cuenta = txtCuenta.Text.Trim
        Dim monto As Decimal = 0
        monto = Decimal.Parse(txtMonto.Text.Trim)
        Dim dtData As New DataTable
        With dtData.Columns
            .Add("num_cuenta")
            .Add("desc_cuenta")
            .Add("debe")
            .Add("haber")
        End With
        'AGREGAR CUENTA DE Venta
        'FIN''''''''''''''''''''''''''''
        'AGREGAR CUENTA 10
        dtData.Rows.Add(cuenta, obtenerDatosCuenta(cuenta), monto, "0.00")
        'FIN''''''''''''''''''''''''''''

        For Each row As DataGridViewRow In frmNuevaVentaMercaderias.dgvOperaciones.Rows
            If row.Cells("num_cuenta").Value.ToString.StartsWith("12") Then
                dtData.Rows.Add(row.Cells("num_cuenta").Value, obtenerDatosCuenta(row.Cells("num_cuenta").Value), "0.00", row.Cells("debe").Value)
            End If
        Next

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
            tDebe += Decimal.Parse(row.Cells("debe").Value)
            tHaber += Decimal.Parse(row.Cells("haber").Value)
        Next
        tDiferencia = tDebe - tHaber

        txtTDebeS.Text = Format(tDebe, "#,##0.00")
        txtTHaberS.Text = Format(tHaber, "#,##0.00")
        txtDiferenciaS.Text = Format(tDiferencia, "#,##0.00")
    End Sub
    Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtGlosa.Focus()
        End If
    End Sub
    Private Sub txtGlosa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGlosa.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnCargar.Focus()
        End If
    End Sub
    Private Sub btnFinalizar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnFinalizar.KeyPress
        If Asc(e.KeyChar) = 13 Then
            guardarPagos()
        End If
    End Sub
    Private Sub frmNuevaVentaP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        guardarPagos()
    End Sub
    Private Sub guardarDatos(estadoComprobante As String)
        If procesoVenta = "modificacion" Then
            'Dim objCC As New nComprobanteVenta
            'Dim entiCVentaAsiento, entiCVenta As New ComprobanteVentaEntity
            'Dim entiCostoVenta As New CostoVentasEntity
            'Dim dataIgv As New DataTable
            'dataIgv = objCrud.nCrudListarBD("select * from  igv where estado=1", CadenaConexion)
            'Dim preIGV As Decimal = 0
            'Dim valIGV As Decimal = 0
            'If frmModificarVentaP.cboOperacion.SelectedValue.ToString = "1" Or frmModificarVentaP.cboOperacion.SelectedValue.ToString = "2" Then
            '    preIGV = frmModificarVentaP.txtTotalVenta.Text / (1 + (Decimal.Parse(dataIgv.Rows(0)("valor").ToString) / 100))
            '    valIGV = frmModificarVentaP.txtTotalVenta.Text - preIGV
            'Else
            '    valIGV = 0
            'End If

            'With entiCVenta
            '    .id = frmModificarVentaP.idVenta
            '    .tipo_venta = frmModificarVentaP.cboTipoVenta.SelectedValue.ToString
            '    .id_gravado = frmModificarVentaP.cboOperacion.SelectedValue.ToString
            '    .id_tipo_comprobante = frmModificarVentaP.cboTipoDocumento.SelectedValue.ToString
            '    .marca = IIf(frmModificarVentaP.cboTipoVenta.SelectedValue = "CREDITO", frmModificarVentaP.cboPercepcion.Text & "@" & IIf(frmModificarVentaP.cboPercepcion.Text = "SIN AFECTO", "0", frmModificarVentaP.cboTipoPercepcion.SelectedValue), frmModificarVentaP.cboTipoPercepcion.Text & "@I")
            '    .centro = frmModificarVentaP.idCentroCosto
            '    .estado_comprobante = estadoComprobante
            '    .fec_emision = frmModificarVentaP.dtFechaEmision.Value.ToString("yyyy-MM-dd")
            '    .fec_pago = frmModificarVentaP.dtFechaPago.Value.ToString("yyyy-MM-dd")
            '    .serie_comprobante = frmModificarVentaP.txtSerie.Text
            '    .numero_comprobante = frmModificarVentaP.txtNumero.Text
            '    .cod_dni = "6"
            '    .num_dni = frmModificarVentaP.txtRuc.Text.Trim
            '    .razon_social = frmModificarVentaP.txtRazonSocial.Text.Trim
            '    .valor_facturado = Decimal.Parse(frmModificarVentaP.txtTotalVenta.Text.Trim) - valIGV
            '    .glosa = frmModificarVentaP.txtGlosa.Text
            '    .id_moneda = frmModificarVentaP.cboMoneda.SelectedValue.ToString
            '    .valor_igv = valIGV
            '    .total = frmModificarVentaP.txtTotalVenta.Text.Trim
            '    .tipo_cambio = frmModificarVentaP.txtTipoCambio.Text.Trim
            '    .detraccion = 1
            '    .fec_comp_origen = frmModificarVentaP.dtFechaEmision.Value.ToString("yyyy-MM-dd")
            '    .tip_comp_origen = ""
            '    .serie_comp_origen = ""
            '    .numero_comp_origen = ""
            '    .estado = 1
            '    .id_usuario = CodigoUsuarioSession
            'End With
            'Dim rptaRCC As String = objCC.nActualizarComprobanteVentaBD(entiCVenta, CadenaConexion)
            'If rptaRCC <> "ok" Then
            '    MsgBox("Error en la actualización del comprobante: " & rptaRCC)
            'End If
        Else
            Dim dataIgv As New DataTable
            dataIgv = objCrud.nCrudListarBD("select * from  igv where estado=1", CadenaConexion)
            Dim preIGV As Decimal = 0
            Dim valIGV As Decimal = 0
            If frmNuevaVentaMercaderias.cboOperacion.SelectedValue = "1" Or frmNuevaVentaMercaderias.cboOperacion.SelectedValue = "2" Then
                preIGV = frmNuevaVentaMercaderias.txtTotalVenta.Text / (1 + (Decimal.Parse(dataIgv.Rows(0)("valor").ToString) / 100))
                valIGV = frmNuevaVentaMercaderias.txtTotalVenta.Text - preIGV
            Else
                valIGV = 0
            End If

            ''REGISTRAR PERCEPCION, DETRACCION, RETENCION
            'If frmNuevaVentaMercaderias.cboPercepcion.Text = "PERCEPCIÓN" Then
            '    Dim dataPorc As New DataTable
            '    dataPorc = objCrud.nCrudListarBD("select * from impuestos_sunat where tipo_comprobante='VENTA' and id='" & frmNuevaVentaMercaderias.cboPercepcion.SelectedValue.ToString & "'")
            '    Dim entiImpuesto As New ImpuestosSunatEntity
            '    For Each row As DataGridViewRow In dgvOperaciones.Rows
            '        If dataPorc.Rows(0)("cuenta").ToString = row.Cells("num_cuenta").Value.ToString Then
            '            With entiImpuesto
            '                .operacion = "VENTA"
            '                .id_impuesto = frmNuevaVentaMercaderias.cboPercepcion.SelectedValue
            '                .serie = frmNuevaVentaMercaderias.cboSerieImpuesto.Text.Trim
            '                .numero = frmNuevaVentaMercaderias.txtNumeroImpuesto.Text.Trim
            '                .id_tipo_comprobante = frmNuevaVentaMercaderias.cboTipoDocumento.SelectedValue
            '                .tipo_comprobante = frmNuevaVentaMercaderias.cboTipoPercepcion.Text
            '                .total_comprobante = frmNuevaVentaMercaderias.txtTotalVenta.Text.Trim
            '                .porcentaje = frmNuevaVentaMercaderias.txtPorcPercep.Text.Trim
            '                .monto = Decimal.Parse(row.Cells("debe").Value.ToString) + Decimal.Parse(row.Cells("haber").Value.ToString)
            '                .estado = "1"
            '            End With
            '            Dim objImp As New nImpuestosSunat
            '            Dim rptaImp As String
            '            rptaImp = objImp.nRegistrarImpuestosBD(entiImpuesto, CadenaConexion)
            '        End If
            '    Next
            'End If

            Dim entiCVenta, entiCabVent As New ComprobanteVentaEntity
            Dim entiCostoVenta As New CostoVentasEntity
            Dim objAC As New nAsientosContables
            With entiCabVent
                .numero_cuo = objAC.nObtenerNumeroCUOBD(CadenaConexion)
                .numero_maquina = "-"
                .id_tipo_comprobante = frmNuevaVentaMercaderias.cboTipoDocumento.SelectedValue.ToString
                .fec_emision = frmNuevaVentaMercaderias.dtFechaEmision.Value
                .fec_pago = frmNuevaVentaMercaderias.dtFechaPago.Value
                .tipo_venta = frmNuevaVentaMercaderias.cboTipoVenta.SelectedValue.ToString
                .id_gravado = frmNuevaVentaMercaderias.cboOperacion.SelectedValue
                .marca = "0" 'IIf(frmNuevaVentaMercaderias.cboTipoVenta.SelectedValue = "CREDITO", frmNuevaVentaMercaderias.cboPercepcion.SelectedValue & "@" & IIf(frmNuevaVentaMercaderias.cboPercepcion.Text = "SIN AFECTO", "0", frmNuevaVentaMercaderias.cboTipoPercepcion.SelectedValue), "0" & "@I")
                .centro = frmNuevaVentaMercaderias.idCentroCosto
                .serie_comprobante = frmNuevaVentaMercaderias.txtSerie.Text
                .numero_comprobante = frmNuevaVentaMercaderias.txtNumero.Text
                .cod_dni = "6"
                .num_dni = frmNuevaVentaMercaderias.txtRuc.Text.Trim
                .razon_social = frmNuevaVentaMercaderias.txtRazonSocial.Text.Trim
                .glosa = txtGlosa.Text.Trim
                .valor_facturado = Decimal.Parse(frmNuevaVentaMercaderias.txtTotalVenta.Text.Trim) - valIGV
                .base_imponible = Decimal.Parse(frmNuevaVentaMercaderias.txtTotalVenta.Text.Trim) - valIGV
                .valor_exonerado = 0
                .valor_inafecto = 0
                .valor_isc = 0
                .valor_igv = valIGV
                .otros_base_imponible = 0
                .valor_descuento = 0
                .total = Decimal.Parse(frmNuevaVentaMercaderias.txtTotalVenta.Text.Trim)
                .id_moneda = frmNuevaVentaMercaderias.cboMoneda.SelectedValue.ToString
                .tipo_cambio = frmNuevaVentaMercaderias.txtTipoCambio.Text.Trim
                .fec_comp_origen = frmNuevaVentaMercaderias.dtFechaEmision.Value
                .tip_comp_origen = "-"
                .serie_comp_origen = "-"
                .numero_comp_origen = "-"
                .estado = 1
                .cuenta = ""
                .debe = 0
                .haber = 0
                .estado_comprobante = estadoComprobante
            End With
            Dim objCV As New nComprobanteVenta
            Dim rptaRCC As String = objCV.nRegistrarComprobanteVentaBD(entiCabVent, CadenaConexion)
            If rptaRCC <> "ok" Then
                MsgBox("Error en el registro del comprobante: " & rptaRCC)
            End If

            Dim dataComVenta As New DataTable
            Dim dataCV As New DataTable
            dataCV = objCV.obtenerIdComprobanteVentaBD(CadenaConexion)
            With entiCVenta
                .id_asiento_venta = dataCV.Rows("0")("id").ToString
                .id_moneda = frmNuevaVentaMercaderias.cboMoneda.SelectedValue
                .tipo_cambio = frmNuevaVentaMercaderias.txtTipoCambio.Text.Trim
                .fec_emision = Date.Parse(frmNuevaVentaMercaderias.dtFechaEmision.Value)
                .id_tipo_comprobante = frmNuevaVentaMercaderias.cboTipoDocumento.SelectedValue.ToString
                .tipo_tasa_detraccion = frmNuevaVentaMercaderias.cboImpuesto.SelectedValue.ToString
                .numero_detraccion = "0"
                .numero_comprobante = frmNuevaVentaMercaderias.txtSerie.Text & "-" & frmNuevaVentaMercaderias.txtNumero.Text
            End With

            For Each row As DataGridViewRow In frmNuevaVentaMercaderias.dgvOperaciones.Rows
                entiCVenta.cuenta = row.Cells("num_cuenta").Value
                entiCVenta.debe = row.Cells("debe").Value
                entiCVenta.haber = row.Cells("haber").Value
                entiCVenta.glosa = txtGlosa.Text.Trim
                Dim rptaRAV As String = objCV.nRegistrarDetalleAsientoVentaBD(entiCVenta, CadenaConexion)
                If rptaRAV <> "ok" Then
                    MsgBox("Error en el registro del comprobante: " & rptaRCC)
                End If
            Next
        End If

        If frmNuevaVentaMercaderias.txtRazonSocial.Text.Trim.Length > 0 And frmNuevaVentaMercaderias.txtRuc.Text.Trim.Length >= 8 Then
            'VERIFICAR DATOS DEL PROVEEDOR
            Dim campos As String
            Dim valores As String
            campos = "dni_ruc@nombres@direccion@estado"
            Dim ruc As String = frmNuevaVentaMercaderias.txtRuc.Text.Trim
            valores = ruc & "@" & frmNuevaVentaMercaderias.txtRazonSocial.Text.ToString & "@" & frmNuevaVentaMercaderias.txtDireccion.Text.ToString & "@1"
            'Verificar si existe el proveedor
            Dim dtProv As New DataTable
            dtProv = objCrud.nCrudListarBD("select * from clientes where dni_ruc='" & ruc & "'", CadenaConexion)
            'MsgBox(dtProv.Rows.Count)
            Dim rpta As String = ""
            Dim tabla As String = "clientes"
            Dim condicion As String
            If dtProv.Rows.Count > 0 Then
                condicion = "dni_ruc=" & ruc
                rpta = objCrud.nCrudActualizarBD("@", tabla, campos, valores, condicion, CadenaConexion)
            Else
                rpta = objCrud.nCrudInsertarBD("@", tabla, campos, valores, CadenaConexion)
            End If
        Else
            MsgBox("Ingrese RUC/Razón Social del Cliente")
            frmNuevaVentaMercaderias.txtRuc.Focus()
        End If
    End Sub
    Private Sub guardarPagos()

        guardarDatos("F")

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
                .fecha_detraccion = frmNuevaVentaMercaderias.dtFechaPago.Value.ToString("yyyy/MM/dd")
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
        MsgBox("COMPROBANTE DE VENTA REGISTRADO CON ÉXITO")
        frmListaComprobanteVentas.realizarConsulta()
        frmNuevaVentaMercaderias.Dispose()
        Me.Dispose()

    End Sub
    Private Sub txtMonto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.Leave
        txtMonto.Text = Format(CType(txtMonto.Text, Decimal), "###0.00")
    End Sub

End Class