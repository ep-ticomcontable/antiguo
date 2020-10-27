Imports Negocio
Imports Entidades
Public Class frmNuevaCompraPagoMercaderia
    Dim objCrud As New nCrud
    Public procesoCompra As String = ""
    Dim glosaPrincipal As String = ""
    Dim glosaImpuesto As String = ""

    Private Sub frmNuevaCompraPagoMercaderia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMonto.Text = frmNuevaCompraMercaderias.txtTotalCompra.Text.Trim
        glosaPrincipal = "POR EL PAGO DE LA " & frmNuevaCompraMercaderias.cboTipoDocumento.Text & " " & frmNuevaCompraMercaderias.txtSerie.Text.Trim & "-" & frmNuevaCompraMercaderias.txtNumero.Text.Trim
    End Sub

    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            txtMonto.Focus()
        End If
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        If txtIdCaja.Text.Trim = "0" Then
            MsgBox("Seleccione una Caja para poder realizar el pago del comprobante.")
        Else
            Dim cuenta As String = ""
            Dim data As New DataTable
            data = objCrud.nCrudListarBD("select * from caja_configuracion where id='" & txtIdCaja.Text.Trim & "'", CadenaConexion)
            If data.Rows.Count > 0 Then
                cuenta = data.Rows(0)("cuenta").ToString
                Dim monto As Decimal = 0
                monto = Decimal.Parse(txtMonto.Text.Trim)
                Dim dtData As New DataTable
                With dtData.Columns
                    .Add("num_cuenta")
                    .Add("desc_cuenta")
                    .Add("debe")
                    .Add("haber")
                    .Add("glosa")
                End With
                'detectar si se cancela con caja chica
                Dim idCaja As String = "1"
                idCaja = txtIdCaja.Text.Trim
                glosaImpuesto = "DETRACCIÓN N°: " & frmNuevaCompraMercaderias.txtSerieI.Text.Trim
                If idCaja <> "1" Then

                    Dim dtDet As New DataTable
                    Dim montoDet As Decimal = 0
                    If frmNuevaCompraMercaderias.cboImpuesto.Text = "DETRACCIÓN" Then
                        dtDet = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & frmNuevaCompraMercaderias.cboImpuesto.SelectedValue & "'", CadenaConexion)
                        montoDet = Decimal.Round((Decimal.Parse(txtMonto.Text.Trim) * dtDet.Rows(0)("porcentaje") / 100), 2)
                        monto = monto - montoDet
                    End If


                    'AGREGAR CUENTA DE COMPRA
                    Dim dataCaja As New DataTable
                    If frmNuevaCompraMercaderias.cboImpuesto.Text = "DETRACCIÓN" Then
                        dataCaja = objCrud.nCrudListarBD("select * from caja_configuracion where id='" & idCaja & "'", CadenaConexion)
                        For Each fila As DataGridViewRow In frmNuevaCompraMercaderias.dgvOperaciones.Rows
                            If fila.Cells("num_cuenta").Value.ToString.StartsWith("4") And Not fila.Cells("num_cuenta").Value.ToString.StartsWith("40") And Not fila.Cells("num_cuenta").Value.ToString.StartsWith(dtDet.Rows(0)("cuenta")) Then
                                dtData.Rows.Add(fila.Cells("num_cuenta").Value, obtenerDatosCuenta(fila.Cells("num_cuenta").Value), monto, "0.00", "POR TRANSFERENCIA")
                            End If
                        Next
                    Else
                        dataCaja = objCrud.nCrudListarBD("select * from caja_configuracion where id='" & idCaja & "'", CadenaConexion)
                        For Each fila As DataGridViewRow In frmNuevaCompraMercaderias.dgvOperaciones.Rows
                            If fila.Cells("num_cuenta").Value.ToString.StartsWith("4") And Not fila.Cells("num_cuenta").Value.ToString.StartsWith("40") Then
                                dtData.Rows.Add(fila.Cells("num_cuenta").Value, obtenerDatosCuenta(fila.Cells("num_cuenta").Value), monto, "0.00", "POR TRANSFERENCIA")
                            End If
                        Next
                    End If
                    dtData.Rows.Add(dataCaja.Rows(0)("contra_cuenta").ToString, obtenerDatosCuenta(dataCaja.Rows(0)("contra_cuenta").ToString), "0.00", monto, "POR TRANSFERENCIA")
                    dtData.Rows.Add(dataCaja.Rows(0)("contra_cuenta").ToString, obtenerDatosCuenta(dataCaja.Rows(0)("contra_cuenta").ToString), monto, "0.00", glosaPrincipal)
                    dtData.Rows.Add(dataCaja.Rows(0)("cuenta").ToString, obtenerDatosCuenta(dataCaja.Rows(0)("cuenta").ToString), "0.00", monto, glosaPrincipal)

                    If frmNuevaCompraMercaderias.cboImpuesto.SelectedValue <> 0 Then
                        dataCaja = objCrud.nCrudListarBD("select * from caja_configuracion where id='" & idCaja & "'", CadenaConexion)
                        dtData.Rows.Add(dtDet.Rows(0)("cuenta").ToString, obtenerDatosCuenta(dtDet.Rows(0)("cuenta").ToString), montoDet, "0.00", "POR TRANSFERENCIA")
                        dtData.Rows.Add(dataCaja.Rows(0)("contra_cuenta").ToString, obtenerDatosCuenta(dataCaja.Rows(0)("contra_cuenta").ToString), "0.00", montoDet, "POR TRANSFERENCIA")
                        dtData.Rows.Add(dataCaja.Rows(0)("contra_cuenta").ToString, obtenerDatosCuenta(dataCaja.Rows(0)("contra_cuenta").ToString), montoDet, "0.00", glosaImpuesto)
                        dtData.Rows.Add(dataCaja.Rows(0)("cuenta").ToString, obtenerDatosCuenta(dataCaja.Rows(0)("cuenta").ToString), "0.00", montoDet, glosaImpuesto)
                    End If

                    dgvOperaciones.DataSource = dtData
                Else
                    Dim dtDet As New DataTable
                    Dim montoDet As Decimal = 0
                    If frmNuevaCompraMercaderias.cboImpuesto.Text = "DETRACCIÓN" Then
                        dtDet = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & frmNuevaCompraMercaderias.cboImpuesto.SelectedValue & "'", CadenaConexion)
                        montoDet = Decimal.Round((Decimal.Parse(txtMonto.Text.Trim) * dtDet.Rows(0)("porcentaje") / 100), 2)
                        monto = monto - montoDet
                    End If
                    'AGREGAR CUENTA DE COMPRA
                    If frmNuevaCompraMercaderias.cboImpuesto.Text = "DETRACCIÓN" Then
                        For Each row As DataGridViewRow In frmNuevaCompraMercaderias.dgvOperaciones.Rows
                            If row.Cells("num_cuenta").Value.ToString.StartsWith("4") And Not row.Cells("num_cuenta").Value.ToString.StartsWith("40") And Not row.Cells("num_cuenta").Value.ToString.StartsWith(dtDet.Rows(0)("cuenta").ToString) Then
                                dtData.Rows.Add(row.Cells("num_cuenta").Value, obtenerDatosCuenta(row.Cells("num_cuenta").Value), monto, "0.00", glosaPrincipal)
                            End If
                        Next
                    Else
                        For Each row As DataGridViewRow In frmNuevaCompraMercaderias.dgvOperaciones.Rows
                            If row.Cells("num_cuenta").Value.ToString.StartsWith("4") And Not row.Cells("num_cuenta").Value.ToString.StartsWith("40") Then
                                dtData.Rows.Add(row.Cells("num_cuenta").Value, obtenerDatosCuenta(row.Cells("num_cuenta").Value), monto, "0.00", glosaPrincipal)
                            End If
                        Next
                    End If

                    'FIN''''''''''''''''''''''''''''
                    'AGREGAR CUENTA 10
                    dtData.Rows.Add(cuenta, obtenerDatosCuenta(cuenta), "0.00", monto, glosaPrincipal)
                    'FIN''''''''''''''''''''''''''''

                    If frmNuevaCompraMercaderias.cboImpuesto.SelectedValue <> 0 Then
                        dtData.Rows.Add(dtDet.Rows(0)("cuenta").ToString, obtenerDatosCuenta(dtDet.Rows(0)("cuenta").ToString), montoDet, "0.00", glosaImpuesto)
                        dtData.Rows.Add(cuenta, obtenerDatosCuenta(cuenta), "0.00", montoDet, glosaImpuesto)
                    End If
                End If
                dgvOperaciones.DataSource = dtData
            Else
                MsgBox("La cuenta seleccionada no tiene una caja asignada")
            End If
        End If
        realizarSumasTotales()
    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)("nombre").ToString
        Else
            MsgBox("La cuenta de la caja seleccionada, no se encuentra registrada.")
        End If
        Return "NO ASIGNADA"
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
    Private Sub btnFinalizar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnFinalizar.KeyPress
        If Asc(e.KeyChar) = 13 Then
            guardarPagos()
        End If
    End Sub
    Private Sub frmNuevaCompraMercaderias_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        If dgvOperaciones.RowCount > 0 Then
            guardarPagos()
        Else
            MsgBox("No se han cargado los asientos contables para poder registrar el pago.")
        End If
    End Sub
    Private Sub guardarDatos(estadoComprobante As String)
        If procesoCompra = "modificacion" Then
            Dim objCC As New nComprobanteCompra
            Dim entiCCompraAsiento, entiCCompra As New ComprobanteCompraEntity
            Dim entiCostoCompra As New CostoComprasEntity
            Dim dataIgv As New DataTable
            dataIgv = objCrud.nCrudListarBD("select * from  igv where estado=1", CadenaConexion)
            Dim preIGV As Decimal = 0
            Dim valIGV As Decimal = 0
            If frmModificarCompraP.cboOperacion.SelectedValue.ToString = "1" Or frmModificarCompraP.cboOperacion.SelectedValue.ToString = "2" Then
                preIGV = frmModificarCompraP.txtTotalCompra.Text / (1 + (Decimal.Parse(dataIgv.Rows(0)("valor").ToString) / 100))
                valIGV = frmModificarCompraP.txtTotalCompra.Text - preIGV
            Else
                valIGV = 0
            End If

            With entiCCompra
                .id = frmModificarCompraP.idCompra
                .tipo_compra = frmModificarCompraP.cboTipoCompra.SelectedValue.ToString
                .id_gravado = frmModificarCompraP.cboOperacion.SelectedValue.ToString
                .id_tipo_comprobante = frmModificarCompraP.cboTipoDocumento.SelectedValue.ToString
                .marca = IIf(frmModificarCompraP.cboTipoCompra.SelectedValue = "CREDITO", frmModificarCompraP.cboPercepcion.Text & "@" & IIf(frmModificarCompraP.cboPercepcion.Text = "SIN AFECTO", "0", frmModificarCompraP.cboTipoPercepcion.SelectedValue), frmModificarCompraP.cboTipoPercepcion.Text & "@I")
                .centro = frmModificarCompraP.idCentroCosto
                .estado_comprobante = estadoComprobante
                .fec_emision = frmModificarCompraP.dtFechaEmision.Value.ToString("yyyy-MM-dd")
                .fec_pago = frmModificarCompraP.dtFechaPago.Value.ToString("yyyy-MM-dd")
                .serie_comprobante = frmModificarCompraP.txtSerie.Text
                .numero_comprobante = frmModificarCompraP.txtNumero.Text
                .cod_dni = "6"
                .num_dni = frmModificarCompraP.txtRuc.Text.Trim
                .razon_social = frmModificarCompraP.txtRazonSocial.Text.Trim
                .valor_facturado = Decimal.Parse(frmModificarCompraP.txtTotalCompra.Text.Trim) - valIGV
                .glosa = frmModificarCompraP.txtGlosa.Text
                .id_moneda = frmModificarCompraP.cboMoneda.SelectedValue.ToString
                .valor_igv = valIGV
                .total = frmModificarCompraP.txtTotalCompra.Text.Trim
                .tipo_cambio = frmModificarCompraP.txtTipoCambio.Text.Trim
                .detraccion = frmModificarCompraP.cboPercepcion.SelectedValue
                .fec_comp_origen = frmModificarCompraP.dtFechaEmision.Value.ToString("yyyy-MM-dd")
                .tip_comp_origen = ""
                .serie_comp_origen = ""
                .numero_comp_origen = ""
                .estado = 1
                .id_usuario = CodigoUsuarioSession
            End With
            Dim rptaRCC As String = objCC.nActualizarComprobanteCompraBD(entiCCompra, CadenaConexion)
            If rptaRCC <> "ok" Then
                MsgBox("Error en la actualización del comprobante: " & rptaRCC)
            End If
        Else
            Dim objCC As New nComprobanteCompra
            Dim entiCCompraAsiento, entiCCompra As New ComprobanteCompraEntity
            Dim entiCostoCompra As New CostoComprasEntity
            Dim dataIgv As New DataTable
            dataIgv = objCrud.nCrudListarBD("select * from  igv where estado=1", CadenaConexion)
            Dim preIGV As Decimal = 0
            Dim valIGV As Decimal = 0
            If frmNuevaCompraMercaderias.cboOperacion.SelectedValue = "1" Then
                preIGV = frmNuevaCompraMercaderias.txtTotalCompra.Text / (1 + (Decimal.Parse(dataIgv.Rows(0)("valor").ToString) / 100))
                valIGV = frmNuevaCompraMercaderias.txtTotalCompra.Text - preIGV
            Else
                valIGV = 0
            End If

            With entiCCompra
                .id_gravado = frmNuevaCompraMercaderias.cboOperacion.SelectedValue.ToString
                .tipo_compra = frmNuevaCompraMercaderias.cboTipoCompra.SelectedValue.ToString
                .id_tipo_comprobante = frmNuevaCompraMercaderias.cboTipoDocumento.SelectedValue.ToString
                .marca = IIf(frmNuevaCompraMercaderias.cboTipoCompra.SelectedValue = "CREDITO", frmNuevaCompraMercaderias.cboImpuesto.SelectedValue & "@" & IIf(frmNuevaCompraMercaderias.cboImpuesto.Text = "SIN AFECTO", "0", "0"), "0" & "@I")
                .centro = frmNuevaCompraMercaderias.idCentroCosto
                .estado_comprobante = estadoComprobante
                .fec_emision = frmNuevaCompraMercaderias.dtFechaEmision.Value.ToString("yyyy-MM-dd")
                .fec_pago = frmNuevaCompraMercaderias.dtFechaPago.Value.ToString("yyyy-MM-dd")
                .serie_comprobante = frmNuevaCompraMercaderias.txtSerie.Text
                .numero_comprobante = frmNuevaCompraMercaderias.txtNumero.Text
                .cod_dni = "6"
                .num_dni = frmNuevaCompraMercaderias.txtRuc.Text.Trim
                .razon_social = frmNuevaCompraMercaderias.txtRazonSocial.Text.Trim
                .valor_facturado = Decimal.Parse(frmNuevaCompraMercaderias.txtTotalCompra.Text.Trim) - valIGV
                .glosa = frmNuevaCompraMercaderias.txtGlosa.Text
                .id_moneda = frmNuevaCompraMercaderias.cboMoneda.SelectedValue.ToString
                .valor_igv = valIGV
                .total = frmNuevaCompraMercaderias.txtTotalCompra.Text.Trim
                .tipo_cambio = frmNuevaCompraMercaderias.txtTipoCambio.Text.Trim
                .detraccion = frmNuevaCompraMercaderias.cboImpuesto.SelectedValue
                .fec_comp_origen = frmNuevaCompraMercaderias.dtFechaEmision.Value.ToString("yyyy-MM-dd")
                .tip_comp_origen = ""
                .serie_comp_origen = ""
                .numero_comp_origen = ""
                .estado = 1
                .id_usuario = CodigoUsuarioSession
            End With
            Dim rptaRCC As String = objCC.nRegistrarComprobanteCompraBD(entiCCompra, CadenaConexion)
            If rptaRCC <> "ok" Then
                MsgBox("Error en el registro del comprobante: " & rptaRCC)
            End If

            'REGISTRAR PERCEPCION, DETRACCION, RETENCION
            If frmNuevaCompraMercaderias.cboImpuesto.SelectedValue <> 0 Then
                Dim dataPorc As New DataTable
                dataPorc = objCrud.nCrudListarBD("select * from impuestos_sunat where tipo_comprobante='COMPRA' and id='" & frmNuevaCompraMercaderias.cboImpuesto.SelectedValue.ToString & "'", CadenaConexion)
                Dim entiImpuesto As New ImpuestosSunatEntity
                For Each row As DataGridViewRow In frmNuevaCompraMercaderias.dgvOperaciones.Rows
                    If dataPorc.Rows(0)("cuenta").ToString = row.Cells("num_cuenta").Value.ToString Then
                        With entiImpuesto
                            .operacion = "COMPRA"
                            .id_impuesto = frmNuevaCompraMercaderias.cboImpuesto.SelectedValue
                            .serie = "0" 'frmNuevaCompraMercaderias.cboSerieImpuesto.Text.Trim
                            .numero = frmNuevaCompraMercaderias.txtSerieI.Text.Trim
                            .id_tipo_comprobante = frmNuevaCompraMercaderias.cboTipoDocumento.SelectedValue
                            .tipo_comprobante = "0" 'frmNuevaCompraMercaderias.cboTipoPercepcion.Text
                            .total_comprobante = frmNuevaCompraMercaderias.txtTotalCompra.Text.Trim
                            .porcentaje = frmNuevaCompraMercaderias.txtPorcPercep.Text.Trim
                            .monto = Decimal.Parse(row.Cells("debe").Value.ToString) + Decimal.Parse(row.Cells("haber").Value.ToString)
                            .estado = "1"
                        End With
                        Dim objImp As New nImpuestosSunat
                        Dim rptaImp As String
                        rptaImp = objImp.nRegistrarImpuestosBD(entiImpuesto, CadenaConexion)
                    End If
                Next
            End If


            Dim objAbono As New nAbonosPagos
            Dim dataCC As New DataTable
            dataCC = objCrud.nCrudListarBD("select * from comprobante_compra order by id desc", CadenaConexion)
            With entiCCompraAsiento
                .id_comprobante = dataCC.Rows(0)("id").ToString
                .numero_cuo = objCC.nObtenerCUO_CompraBD(CadenaConexion)
                .tipo_compra = frmNuevaCompraMercaderias.cboTipoCompra.SelectedValue.ToString
                .numero_maquina = "-"
                .id_tipo_comprobante = frmNuevaCompraMercaderias.cboTipoDocumento.SelectedValue.ToString
                .fec_emision = Date.Parse(frmNuevaCompraMercaderias.dtFechaEmision.Value())
                .fec_pago = frmNuevaCompraMercaderias.dtFechaPago.Value.ToString("yyyy-MM-dd")
                .serie_comprobante = frmNuevaCompraMercaderias.txtSerie.Text
                .numero_comprobante = frmNuevaCompraMercaderias.txtNumero.Text
                .cod_dni = "6"
                .num_dni = frmNuevaCompraMercaderias.txtRuc.Text.Trim
                .razon_social = frmNuevaCompraMercaderias.txtRazonSocial.Text.Trim
                .valor_facturado = Decimal.Parse(frmNuevaCompraMercaderias.txtTotalCompra.Text.Trim) - valIGV
                .base_imponible = Decimal.Parse(frmNuevaCompraMercaderias.txtTotalCompra.Text.Trim) - valIGV
                .valor_exonerado = 0
                .valor_inafecto = 0
                .valor_isc = 0
                .valor_igv = valIGV
                .otros_base_imponible = 0
                .total = frmNuevaCompraMercaderias.txtTotalCompra.Text.Trim
                .tipo_cambio = frmNuevaCompraMercaderias.txtTipoCambio.Text.Trim
                .fec_comp_origen = Date.Parse(frmNuevaCompraMercaderias.dtFechaEmision.Value.ToString("yyyy-MM-dd"))
                .serie_dua = "0"
                .numero_dua = "0"
                .anio_dua = frmNuevaCompraMercaderias.dtFechaEmision.Value.ToString("yyyy-MM-dd")
                .numero_detraccion = frmNuevaCompraMercaderias.txtSerieI.Text.Trim
                .tipo_tasa_detraccion = frmNuevaCompraMercaderias.cboImpuesto.SelectedValue
                .tasa_detraccion = frmNuevaCompraMercaderias.txtPorcPercep.Text.Trim
                .valor_detraccion = Decimal.Round((Decimal.Parse(frmNuevaCompraMercaderias.txtTotalCompra.Text.Trim) * Decimal.Parse(frmNuevaCompraMercaderias.txtPorcPercep.Text.Trim) / 100), 2)
                .fecha_detraccion = frmNuevaCompraMercaderias.dtFechaEmision.Value.ToString("yyyy-MM-dd")
                .estado = 1
            End With

            For Each row As DataGridViewRow In frmNuevaCompraMercaderias.dgvOperaciones.Rows
                entiCCompraAsiento.tip_comp_origen = "-"
                entiCCompraAsiento.serie_comp_origen = frmNuevaCompraMercaderias.txtSerie.Text.Trim
                entiCCompraAsiento.numero_comp_origen = frmNuevaCompraMercaderias.txtNumero.Text.Trim
                entiCCompraAsiento.cuenta = row.Cells("num_cuenta").Value
                entiCCompraAsiento.glosa = frmNuevaCompraMercaderias.txtGlosa.Text.Trim
                entiCCompraAsiento.debe = row.Cells("debe").Value
                entiCCompraAsiento.haber = row.Cells("haber").Value
                'entiCCompraAsiento.impuesto = IIf(row.Cells("impuesto").Value = Nothing, "0", row.Cells("impuesto").Value)
                'entiCCompraAsiento.serie = IIf(row.Cells("serie").Value = Nothing, "0", row.Cells("serie").Value)
                'entiCCompraAsiento.numero = IIf(row.Cells("numero").Value = Nothing, "0", row.Cells("numero").Value)
                'entiCCompraAsiento.operacion = IIf(row.Cells("operacion").Value = Nothing, "0", row.Cells("operacion").Value)
                entiCCompraAsiento.impuesto = "0"
                entiCCompraAsiento.serie = "0"
                entiCCompraAsiento.numero = "0"
                entiCCompraAsiento.operacion = "0"

                'MsgBox("REGISTRANDO ASIENTO COMPROBANTE DE COMPRA: " & objCC.nRegistrarAsientoComprobanteCompra(entiCCompraAsiento))
                Dim rptaRACC As String = objCC.nRegistrarAsientoComprobanteCompraBD(entiCCompraAsiento, CadenaConexion)
                If rptaRACC <> "ok" Then
                    MsgBox("Error en el registro en el asiento del comprobante: " & rptaRACC)
                End If
            Next
        End If

        If frmNuevaCompraMercaderias.txtRazonSocial.Text.Trim.Length > 0 And frmNuevaCompraMercaderias.txtRuc.Text.Trim.Length >= 8 Then
            'VERIFICAR DATOS DEL PROVEEDOR
            Dim campos As String
            Dim valores As String
            campos = "dni_ruc@nombre@direccion@estado"
            Dim ruc As String = frmNuevaCompraMercaderias.txtRuc.Text.Trim
            valores = ruc & "@" & frmNuevaCompraMercaderias.txtRazonSocial.Text.ToString & "@" & frmNuevaCompraMercaderias.txtDireccion.Text.ToString & "@1"
            'Verificar si existe el proveedor
            Dim dtProv As New DataTable
            dtProv = objCrud.nCrudListarBD("select * from proveedores where dni_ruc='" & ruc & "'", CadenaConexion)
            'MsgBox(dtProv.Rows.Count)
            Dim rpta As String = ""
            Dim tabla As String = "proveedores"
            Dim condicion As String
            If dtProv.Rows.Count > 0 Then
                condicion = "dni_ruc=" & ruc
                rpta = objCrud.nCrudActualizarBD("@", tabla, campos, valores, condicion, CadenaConexion)
            Else
                rpta = objCrud.nCrudInsertarBD("@", tabla, campos, valores, CadenaConexion)
            End If
        Else
            MsgBox("Ingrese RUC/Razón Social del Proveedor")
            frmNuevaCompraMercaderias.txtRuc.Focus()
        End If
    End Sub
    Private Sub guardarPagos()
        guardarDatos("F")
        Dim dataCompra As New DataTable
        Dim objCom As New nComprobanteCompra
        dataCompra = objCrud.nCrudListarBD("select top 1 * from comprobante_compra order by id desc", CadenaConexion)
        Dim codCompra As String
        codCompra = dataCompra.Rows(0)("id").ToString
        Dim EntiAboCom, EntiAsientoAboCom As New AbonoComprasEntity
        Dim objAbono As New nAbonosPagos
        If frmNuevaCompraMercaderias.cboImpuesto.SelectedValue = 0 Then
            With EntiAboCom
                .id_compra = codCompra
                .id_impuesto = frmNuevaCompraMercaderias.cboImpuesto.SelectedValue.ToString
                .id_letra = 0
                .id_caja = txtIdCaja.Text.Trim
                .tipo_comprobante = dataCompra.Rows(0)("id_tipo_comprobante").ToString
                .monto = txtMonto.Text.Trim
                .id_banco = 0
                .tipo = "8"
                .numero = "0"
                .descripcion = glosaPrincipal
                .fecha = DateTime.Now.ToString("yyyy/MM/dd") & " " & Now.ToString("HH:mm:ss")
                .estado = "1"
                .tipo_abono = "NORMAL"
            End With
            objAbono.nRegistrarAbonoComprasBD(EntiAboCom, CadenaConexion)
            For Each row As DataGridViewRow In dgvOperaciones.Rows
                With EntiAsientoAboCom
                    .id = objAbono.nObtenerUltimoAbonoCompraBD(CadenaConexion)
                    .id_cliente = dataCompra.Rows(0)("num_dni").ToString
                    .id_compra = codCompra
                    .cuenta = row.Cells("num_cuenta").Value
                    .base_imponible = txtMonto.Text.Trim
                    .nro_detraccion = frmNuevaCompraMercaderias.txtSerieI.Text.Trim
                    .tipo_tasa_detraccion = frmNuevaCompraMercaderias.cboImpuesto.SelectedValue.ToString
                    .valor_tasa = frmNuevaCompraMercaderias.txtPorcPercep.Text.Trim
                    .valor_detraccion = Decimal.Round((Decimal.Parse(frmNuevaCompraMercaderias.txtTotalCompra.Text.Trim) * Decimal.Parse(frmNuevaCompraMercaderias.txtPorcPercep.Text.Trim) / 100), 2)
                    .fecha_detraccion = frmNuevaCompraMercaderias.dtFechaPago.Value.ToString("yyyy/MM/dd")
                    .monto = txtMonto.Text.Trim
                    .tipo = "8"
                    .descripcion = row.Cells("glosa").Value
                    .debe = row.Cells("debe").Value
                    .haber = row.Cells("haber").Value
                    .fecha = frmNuevaCompraMercaderias.dtFechaPago.Value.ToString("yyyy/MM/dd")
                End With
                objAbono.nRegistrarAsientoAbonoComprasBD(EntiAsientoAboCom, CadenaConexion)
                'MsgBox("ASIENTOS ABONOS: " & objAbono.nRegistrarAsientoAbonoComprasBD(EntiAsientoAboCom, CadenaConexion))
            Next
        End If
        Dim data As New DataTable
        'data = objCrud.nCrudListarBD()

        If frmNuevaCompraMercaderias.cboImpuesto.Text.ToString = "DETRACCIÓN" Then
            Dim ctaCaja As New DataTable
            ctaCaja = objCrud.nCrudListarBD("select * from caja_configuracion where id='" & txtIdCaja.Text.Trim & "'", CadenaConexion)
            Dim dtDet As New DataTable
            dtDet = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & frmNuevaCompraMercaderias.cboImpuesto.SelectedValue.ToString & "'", CadenaConexion)
            Dim cuentaCompra As String = ""
            'DISTRIBUCION DE MONTOS
            Dim montoCompra As Decimal = 0
            Dim montoDetraccion As Decimal = 0
            montoDetraccion = Decimal.Parse(txtMonto.Text.Trim) * Decimal.Parse(dtDet.Rows(0)("porcentaje").ToString) / 100
            montoCompra = Decimal.Parse(txtMonto.Text.Trim) - montoDetraccion
            'REGISTRO DE PAGO SIN DETRACCION
            With EntiAboCom
                .id_compra = codCompra
                .id_impuesto = frmNuevaCompraMercaderias.cboImpuesto.SelectedValue.ToString
                .id_letra = 0
                .id_caja = txtIdCaja.Text.Trim
                .tipo_comprobante = dataCompra.Rows(0)("id_tipo_comprobante").ToString
                .monto = montoCompra
                .id_banco = 0
                .tipo = "8"
                .numero = "0"
                .descripcion = glosaPrincipal
                .fecha = DateTime.Now.ToString("yyyy/MM/dd") & " " & Now.ToString("HH:mm:ss")
                .estado = "1"
                .tipo_abono = "NORMAL"
            End With
            objAbono.nRegistrarAbonoComprasBD(EntiAboCom, CadenaConexion)
            Dim idAbono As String = "0"
            idAbono = objAbono.nObtenerUltimoAbonoCompraBD(CadenaConexion)

            'REGISTRO DE ASIENTOS DEL PAGO SIN DETRACCION
            For Each row As DataGridViewRow In frmNuevaCompraMercaderias.dgvOperaciones.Rows
                If row.Cells("num_cuenta").Value.ToString.StartsWith("4") And Not row.Cells("num_cuenta").Value.ToString.StartsWith("40") And Not row.Cells("num_cuenta").Value.ToString.StartsWith(dtDet.Rows(0)("cuenta").ToString) Then
                    cuentaCompra = row.Cells("num_cuenta").Value.ToString
                End If
            Next
            With EntiAsientoAboCom
                .id = idAbono
                .id_cliente = dataCompra.Rows(0)("num_dni").ToString
                .id_compra = codCompra
                .cuenta = cuentaCompra
                .base_imponible = montoCompra
                .nro_detraccion = frmNuevaCompraMercaderias.txtSerieI.Text.Trim
                .tipo_tasa_detraccion = frmNuevaCompraMercaderias.cboImpuesto.SelectedValue.ToString
                .valor_tasa = frmNuevaCompraMercaderias.txtPorcPercep.Text.Trim
                .valor_detraccion = Decimal.Round((Decimal.Parse(frmNuevaCompraMercaderias.txtTotalCompra.Text.Trim) * Decimal.Parse(frmNuevaCompraMercaderias.txtPorcPercep.Text.Trim) / 100), 2)
                .fecha_detraccion = frmNuevaCompraMercaderias.dtFechaPago.Value.ToString("yyyy/MM/dd")
                .monto = montoCompra
                .tipo = "8"
                .descripcion = glosaPrincipal
                .debe = montoCompra
                .haber = "0.00"
                .fecha = frmNuevaCompraMercaderias.dtFechaPago.Value.ToString("yyyy/MM/dd")
            End With
            objAbono.nRegistrarAsientoAbonoComprasBD(EntiAsientoAboCom, CadenaConexion)
            With EntiAsientoAboCom
                .id = idAbono
                .id_cliente = dataCompra.Rows(0)("num_dni").ToString
                .id_compra = codCompra
                .cuenta = ctaCaja.Rows(0)("cuenta").ToString
                .base_imponible = montoCompra
                .nro_detraccion = frmNuevaCompraMercaderias.txtSerieI.Text.Trim
                .tipo_tasa_detraccion = frmNuevaCompraMercaderias.cboImpuesto.SelectedValue.ToString
                .valor_tasa = frmNuevaCompraMercaderias.txtPorcPercep.Text.Trim
                .valor_detraccion = Decimal.Round((Decimal.Parse(frmNuevaCompraMercaderias.txtTotalCompra.Text.Trim) * Decimal.Parse(frmNuevaCompraMercaderias.txtPorcPercep.Text.Trim) / 100), 2)
                .fecha_detraccion = frmNuevaCompraMercaderias.dtFechaPago.Value.ToString("yyyy/MM/dd")
                .monto = montoCompra
                .tipo = "8"
                .descripcion = glosaPrincipal
                .debe = "0.00"
                .haber = montoCompra
                .fecha = frmNuevaCompraMercaderias.dtFechaPago.Value.ToString("yyyy/MM/dd")
            End With
            objAbono.nRegistrarAsientoAbonoComprasBD(EntiAsientoAboCom, CadenaConexion)
            ''''''''''''''''''''''''''''''''''''''''''''FIN DEL PAGO SIN DETRACCION''''''''''''''''''''''''''''''''''''''''''''''''''

            'REGISTRO DE PAGO CON DETRACCION'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            With EntiAboCom
                .id_compra = codCompra
                .id_impuesto = frmNuevaCompraMercaderias.cboImpuesto.SelectedValue.ToString
                .id_letra = 0
                .id_caja = txtIdCaja.Text.Trim
                .tipo_comprobante = dataCompra.Rows(0)("id_tipo_comprobante").ToString
                .monto = montoDetraccion
                .id_banco = 0
                .tipo = "8"
                .numero = frmNuevaCompraMercaderias.txtSerieI.Text.Trim
                .descripcion = glosaImpuesto
                .fecha = DateTime.Now.ToString("yyyy/MM/dd") & " " & Now.ToString("HH:mm:ss")
                .estado = "1"
                .tipo_abono = "NORMAL"
            End With
            objAbono.nRegistrarAbonoComprasBD(EntiAboCom, CadenaConexion)
            Dim idAbono2 As String = "0"
            idAbono2 = objAbono.nObtenerUltimoAbonoCompraBD(CadenaConexion)
            'REGISTRO DE ASIENTOS DEL PAGO SIN DETRACCION
            With EntiAsientoAboCom
                .id = idAbono2
                .id_cliente = dataCompra.Rows(0)("num_dni").ToString
                .id_compra = codCompra
                .cuenta = dtDet.Rows(0)("cuenta").ToString
                .base_imponible = montoDetraccion
                .nro_detraccion = frmNuevaCompraMercaderias.txtSerieI.Text.Trim
                .tipo_tasa_detraccion = frmNuevaCompraMercaderias.cboImpuesto.SelectedValue.ToString
                .valor_tasa = frmNuevaCompraMercaderias.txtPorcPercep.Text.Trim
                .valor_detraccion = Decimal.Round((Decimal.Parse(frmNuevaCompraMercaderias.txtTotalCompra.Text.Trim) * Decimal.Parse(frmNuevaCompraMercaderias.txtPorcPercep.Text.Trim) / 100), 2)
                .fecha_detraccion = frmNuevaCompraMercaderias.dtFechaPago.Value.ToString("yyyy/MM/dd")
                .monto = montoDetraccion
                .tipo = "8"
                .descripcion = glosaImpuesto
                .debe = montoDetraccion
                .haber = "0.00"
                .fecha = frmNuevaCompraMercaderias.dtFechaPago.Value.ToString("yyyy/MM/dd")
            End With
            objAbono.nRegistrarAsientoAbonoComprasBD(EntiAsientoAboCom, CadenaConexion)
            With EntiAsientoAboCom
                .id = idAbono2
                .id_cliente = dataCompra.Rows(0)("num_dni").ToString
                .id_compra = codCompra
                .cuenta = ctaCaja.Rows(0)("cuenta").ToString
                .base_imponible = montoDetraccion
                .nro_detraccion = frmNuevaCompraMercaderias.txtSerieI.Text.Trim
                .tipo_tasa_detraccion = frmNuevaCompraMercaderias.cboImpuesto.SelectedValue.ToString
                .valor_tasa = frmNuevaCompraMercaderias.txtPorcPercep.Text.Trim
                .valor_detraccion = Decimal.Round((Decimal.Parse(frmNuevaCompraMercaderias.txtTotalCompra.Text.Trim) * Decimal.Parse(frmNuevaCompraMercaderias.txtPorcPercep.Text.Trim) / 100), 2)
                .fecha_detraccion = frmNuevaCompraMercaderias.dtFechaPago.Value.ToString("yyyy/MM/dd")
                .monto = montoDetraccion
                .tipo = "8"
                .descripcion = glosaImpuesto
                .debe = "0.00"
                .haber = montoDetraccion
                .fecha = frmNuevaCompraMercaderias.dtFechaPago.Value.ToString("yyyy/MM/dd")
            End With
            objAbono.nRegistrarAsientoAbonoComprasBD(EntiAsientoAboCom, CadenaConexion)
            ''''''''''''''''''''''''''''''''''''''''''''FIN DEL PAGO SIN DETRACCION''''''''''''''''''''''''''''''''''''''''''''''''''
        End If

        MsgBox("COMPROBANTE DE COMPRA REGISTRADO CON ÉXITO")
        'frmListaComprobanteCompras.realizarConsulta()
        frmNuevaCompraMercaderias.Dispose()
        Me.Dispose()
    End Sub

    Private Sub btnCaja_Click(sender As Object, e As EventArgs) Handles btnCaja.Click
        frmEscogerCaja.formInicio = "compraMercaderia"
        frmEscogerCaja.Show()
    End Sub

    Private Sub txtMonto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.Leave
        txtMonto.Text = Format(CType(txtMonto.Text, Decimal), "###0.00")
    End Sub
End Class