Imports Negocio
Imports Entidades
Public Class frmNuevaCompraPago
    Dim objCrud As New nCrud
    Public procesoCompra As String = ""

    Private Sub frmNuevaCompraPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCuenta.Select()
        txtMonto.Text = frmNuevaCompraP.txtTotalCompra.Text.Trim
        txtGlosa.Text = "POR EL PAGO DE LA " & frmNuevaCompraP.cboTipoDocumento.Text & " " & frmNuevaCompraP.txtSerie.Text.Trim & "-" & frmNuevaCompraP.txtNumero.Text.Trim
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
                .formInicio = "cuentaPago"
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

        'detectar si se cancela con caja chica
        Dim idCaja As String = "1"
        idCaja = txtIdCaja.Text.Trim
        If idCaja = "0" Then
            Dim dataCaja As New DataTable
            dataCaja = objCrud.nCrudListarBD("select * from caja_configuracion where id='" & idCaja & "'", CadenaConexion)
            For Each fila As DataGridViewRow In frmNuevaCompraP.dgvOperaciones.Rows
                If fila.Cells("num_cuenta").Value.ToString.StartsWith("4") And Not fila.Cells("num_cuenta").Value.ToString.StartsWith("40") Then
                    dtData.Rows.Add(fila.Cells("num_cuenta").Value, obtenerDatosCuenta(fila.Cells("num_cuenta").Value), monto, "0.00")
                End If
            Next
            dtData.Rows.Add(dataCaja.Rows(0)("contra_cuenta").ToString, obtenerDatosCuenta(dataCaja.Rows(0)("contra_cuenta").ToString), "0.00", monto)
            dtData.Rows.Add(dataCaja.Rows(0)("contra_cuenta").ToString, obtenerDatosCuenta(dataCaja.Rows(0)("contra_cuenta").ToString), monto, "0.00")
            dtData.Rows.Add(dataCaja.Rows(0)("cuenta").ToString, obtenerDatosCuenta(dataCaja.Rows(0)("cuenta").ToString), "0.00", monto)
            dgvOperaciones.DataSource = dtData
        Else
            'AGREGAR CUENTA DE COMPRA
            For Each row As DataGridViewRow In frmNuevaCompraP.dgvOperaciones.Rows
                If row.Cells("num_cuenta").Value.ToString.StartsWith("4") And Not row.Cells("num_cuenta").Value.ToString.StartsWith("40") Then
                    dtData.Rows.Add(row.Cells("num_cuenta").Value, obtenerDatosCuenta(row.Cells("num_cuenta").Value), monto, "0.00")
                End If
            Next
            'FIN''''''''''''''''''''''''''''
            'AGREGAR CUENTA 10
            dtData.Rows.Add(cuenta, obtenerDatosCuenta(cuenta), "0.00", monto)
            'FIN''''''''''''''''''''''''''''
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
    Private Sub frmNuevaCompraP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        guardarPagos()
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
            If frmNuevaCompraP.cboOperacion.SelectedValue = "1" Then
                preIGV = frmNuevaCompraP.txtTotalCompra.Text / (1 + (Decimal.Parse(dataIgv.Rows(0)("valor").ToString) / 100))
                valIGV = frmNuevaCompraP.txtTotalCompra.Text - preIGV
            Else
                valIGV = 0
            End If



            With entiCCompra
                .id_gravado = frmNuevaCompraP.cboOperacion.SelectedValue.ToString
                .tipo_compra = frmNuevaCompraP.cboTipoCompra.SelectedValue.ToString
                .id_tipo_comprobante = frmNuevaCompraP.cboTipoDocumento.SelectedValue.ToString
                .marca = IIf(frmNuevaCompraP.cboTipoCompra.SelectedValue = "CREDITO", frmNuevaCompraP.cboPercepcion.SelectedValue & "@" & IIf(frmNuevaCompraP.cboPercepcion.Text = "SIN AFECTO", "0", frmNuevaCompraP.cboTipoPercepcion.SelectedValue), "0" & "@I")
                .centro = frmNuevaCompraP.idCentroCosto
                .estado_comprobante = estadoComprobante
                .fec_emision = frmNuevaCompraP.dtFechaEmision.Value.ToString("yyyy-MM-dd")
                .fec_pago = frmNuevaCompraP.dtFechaPago.Value.ToString("yyyy-MM-dd")
                .serie_comprobante = frmNuevaCompraP.txtSerie.Text
                .numero_comprobante = frmNuevaCompraP.txtNumero.Text
                .cod_dni = "6"
                .num_dni = frmNuevaCompraP.txtRuc.Text.Trim
                .razon_social = frmNuevaCompraP.txtRazonSocial.Text.Trim
                .valor_facturado = Decimal.Parse(frmNuevaCompraP.txtTotalCompra.Text.Trim) - valIGV
                .glosa = frmNuevaCompraP.txtGlosa.Text
                .id_moneda = frmNuevaCompraP.cboMoneda.SelectedValue.ToString
                .valor_igv = valIGV
                .total = frmNuevaCompraP.txtTotalCompra.Text.Trim
                .tipo_cambio = frmNuevaCompraP.txtTipoCambio.Text.Trim
                .detraccion = frmNuevaCompraP.cboPercepcion.SelectedValue
                .fec_comp_origen = frmNuevaCompraP.dtFechaEmision.Value.ToString("yyyy-MM-dd")
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
            If frmNuevaCompraP.cboPercepcion.Text = "PERCEPCIÓN" Then
                Dim dataPorc As New DataTable
                dataPorc = objCrud.nCrudListarBD("select * from impuestos_sunat where tipo_comprobante='COMPRA' and id='" & frmNuevaCompraP.cboPercepcion.SelectedValue.ToString & "'", CadenaConexion)
                Dim entiImpuesto As New ImpuestosSunatEntity
                For Each row As DataGridViewRow In frmNuevaCompraP.dgvOperaciones.Rows
                    If dataPorc.Rows(0)("cuenta").ToString = row.Cells("num_cuenta").Value.ToString Then
                        With entiImpuesto
                            .operacion = "COMPRA"
                            .id_impuesto = frmNuevaCompraP.cboPercepcion.SelectedValue
                            .serie = frmNuevaCompraP.cboSerieImpuesto.Text.Trim
                            .numero = frmNuevaCompraP.txtNumeroImpuesto.Text.Trim
                            .id_tipo_comprobante = frmNuevaCompraP.cboTipoDocumento.SelectedValue
                            .tipo_comprobante = frmNuevaCompraP.cboTipoPercepcion.Text
                            .total_comprobante = frmNuevaCompraP.txtTotalCompra.Text.Trim
                            .porcentaje = frmNuevaCompraP.txtPorcPercep.Text.Trim
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
                .tipo_compra = frmNuevaCompraP.cboTipoCompra.SelectedValue.ToString
                .numero_maquina = "-"
                .id_tipo_comprobante = frmNuevaCompraP.cboTipoDocumento.SelectedValue.ToString
                .fec_emision = Date.Parse(frmNuevaCompraP.dtFechaEmision.Value())
                .fec_pago = frmNuevaCompraP.dtFechaPago.Value.ToString("yyyy-MM-dd")
                .serie_comprobante = frmNuevaCompraP.txtSerie.Text
                .numero_comprobante = frmNuevaCompraP.txtNumero.Text
                .cod_dni = "6"
                .num_dni = frmNuevaCompraP.txtRuc.Text.Trim
                .razon_social = frmNuevaCompraP.txtRazonSocial.Text.Trim
                .valor_facturado = Decimal.Parse(frmNuevaCompraP.txtTotalCompra.Text.Trim) - valIGV
                .base_imponible = Decimal.Parse(frmNuevaCompraP.txtTotalCompra.Text.Trim) - valIGV
                .valor_exonerado = 0
                .valor_inafecto = 0
                .valor_isc = 0
                .valor_igv = valIGV
                .otros_base_imponible = 0
                .total = frmNuevaCompraP.txtTotalCompra.Text.Trim
                .tipo_cambio = frmNuevaCompraP.txtTipoCambio.Text.Trim
                .fec_comp_origen = Date.Parse(frmNuevaCompraP.dtFechaEmision.Value.ToString("yyyy-MM-dd"))
                .serie_dua = "0"
                .numero_dua = "0"
                .anio_dua = frmNuevaCompraP.dtFechaEmision.Value.ToString("yyyy-MM-dd")
                '.numero_detraccion = IIf(cboImpuestos.Text = "DETRACCIÓN", txtNumeroImpuesto.Text.Trim, "0")
                .numero_detraccion = "0"
                .tipo_tasa_detraccion = "0"
                '.tasa_detraccion = IIf(cboImpuestos.Text = "DETRACCIÓN", txtPorcentaje.Text.Trim, "0")
                .tasa_detraccion = "0"
                '.valor_detraccion = IIf(cboImpuestos.Text = "DETRACCIÓN", montoDetraccion, "0")
                .valor_detraccion = "0"
                '.fecha_detraccion = dtFecImpuesto.Value.ToString("yyyy-MM-dd")
                .fecha_detraccion = frmNuevaCompraP.dtFechaEmision.Value.ToString("yyyy-MM-dd")
                .estado = 1
            End With

            For Each row As DataGridViewRow In frmNuevaCompraP.dgvOperaciones.Rows
                entiCCompraAsiento.tip_comp_origen = "-"
                entiCCompraAsiento.serie_comp_origen = frmNuevaCompraP.txtSerie.Text.Trim
                entiCCompraAsiento.numero_comp_origen = frmNuevaCompraP.txtNumero.Text.Trim
                entiCCompraAsiento.cuenta = row.Cells("num_cuenta").Value
                entiCCompraAsiento.glosa = frmNuevaCompraP.txtGlosa.Text.Trim
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

            'Se registran estos asientos cuando solo es tipo F=Finalizado
            If estadoComprobante = "F" Then
                'registrando asiento de transferencias
                Dim dtTra As New DataTable
                dtTra = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & frmNuevaCompraP.dgvOperaciones.Rows(0).Cells("num_cuenta").Value & "'", CadenaConexion)
                If dtTra.Rows.Count > 0 And dtTra.Rows(0)("cuenta_debe").ToString.Trim.Length > 1 And dtTra.Rows(0)("cuenta_haber").ToString.Trim.Length > 1 Then
                    entiCCompraAsiento.tip_comp_origen = "-"
                    entiCCompraAsiento.serie_comp_origen = frmNuevaCompraP.txtSerie.Text.Trim
                    entiCCompraAsiento.numero_comp_origen = frmNuevaCompraP.txtNumero.Text.Trim
                    entiCCompraAsiento.impuesto = "0"
                    entiCCompraAsiento.serie = "0"
                    entiCCompraAsiento.numero = "0"
                    entiCCompraAsiento.operacion = "0"
                    'CUENTA DEBE
                    entiCCompraAsiento.cuenta = dtTra.Rows(0)("cuenta_debe").ToString
                    entiCCompraAsiento.glosa = "EXISTENCIAS - " & obtenerDatosCuenta(dtTra.Rows(0)("cuenta_debe").ToString)
                    entiCCompraAsiento.debe = frmNuevaCompraP.dgvOperaciones.Rows(0).Cells("debe").Value
                    entiCCompraAsiento.haber = "0.00"
                    Dim rptaD As String = objCC.nRegistrarAsientoComprobanteCompraBD(entiCCompraAsiento, CadenaConexion)
                    If rptaD <> "ok" Then
                        MsgBox("Error en el registro en el asiento del comprobante: " & rptaD)
                    End If
                    'CUENTA HABER
                    entiCCompraAsiento.cuenta = dtTra.Rows(0)("cuenta_haber").ToString
                    entiCCompraAsiento.glosa = "EXISTENCIAS - " & obtenerDatosCuenta(dtTra.Rows(0)("cuenta_haber").ToString)
                    entiCCompraAsiento.debe = "0.00"
                    entiCCompraAsiento.haber = frmNuevaCompraP.dgvOperaciones.Rows(0).Cells("debe").Value
                    Dim rptaH As String = objCC.nRegistrarAsientoComprobanteCompraBD(entiCCompraAsiento, CadenaConexion)
                    If rptaH <> "ok" Then
                        MsgBox("Error en el registro en el asiento del comprobante: " & rptaH)
                    End If
                End If

                'Registrar asientos del Centro de Costos
                'Capturar Id Centro - Buscado en la grilla
                Dim idCentroCosto2 As Integer = 0
                Dim entidad As New ALDiarioEntity
                For Each row As DataGridViewRow In frmNuevaCompraP.dgvOperaciones.Rows
                    'Integer.Parse(row.Cells("id_centro").Value.ToString) > 0 Or 
                    If Not IsDBNull(row.Cells("id_centro").Value) Then
                        If Integer.Parse(row.Cells("id_centro").Value) > 0 Then
                            idCentroCosto2 = IIf(IsDBNull(row.Cells("id_centro").Value), 0, Integer.Parse(row.Cells("id_centro").Value.ToString))
                            'Registrar asientos del Centro de Costos
                            If idCentroCosto2 > 0 Then
                                Dim dtCC As New DataTable
                                dtCC = objCrud.nCrudListarBD("select * from parametro_centro_costo where id_centro=" & idCentroCosto2, CadenaConexion)
                                Dim calculo As Decimal = 0
                                For i As Integer = 0 To dtCC.Rows.Count - 1
                                    entiCCompraAsiento.cuenta = dtCC.Rows(i)("cuenta").ToString
                                    entiCCompraAsiento.glosa = obtenerDatosCuenta(dtCC.Rows(i)("cuenta").ToString)

                                    calculo = Decimal.Parse(row.Cells("debe").Value) * Decimal.Parse(dtCC.Rows(i)("porcentaje").ToString) / 100

                                    entiCCompraAsiento.debe = IIf(dtCC.Rows(i)("debe").ToString = "X", calculo, "0.00")
                                    entiCCompraAsiento.haber = IIf(dtCC.Rows(i)("haber").ToString = "X", calculo, "0.00")
                                    Dim rptaCC As String = objCC.nRegistrarAsientoComprobanteCompraBD(entiCCompraAsiento, CadenaConexion)
                                    If rptaCC <> "ok" Then
                                        MsgBox("Error en el registro en el asiento del comprobante: " & rptaCC)
                                    End If
                                Next
                            End If
                        End If
                    End If
                Next


            End If

        End If



        
        If frmNuevaCompraP.txtRazonSocial.Text.Trim.Length > 0 And frmNuevaCompraP.txtRuc.Text.Trim.Length >= 8 Then
            'VERIFICAR DATOS DEL PROVEEDOR
            Dim campos As String
            Dim valores As String
            campos = "dni_ruc@nombre@direccion@estado"
            Dim ruc As String = frmNuevaCompraP.txtRuc.Text.Trim
            valores = ruc & "@" & frmNuevaCompraP.txtRazonSocial.Text.ToString & "@" & frmNuevaCompraP.txtDireccion.Text.ToString & "@1"
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
            frmNuevaCompraP.txtRuc.Focus()
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
        With EntiAboCom
            .id_compra = codCompra
            .id_impuesto = frmNuevaCompraP.cboPercepcion.SelectedValue.ToString
            .id_letra = 0
            .id_caja = txtIdCaja.Text.Trim
            .tipo_comprobante = dataCompra.Rows(0)("id_tipo_comprobante").ToString
            .monto = txtMonto.Text.Trim
            .id_banco = 0
            .tipo = "8"
            .numero = "0"
            .descripcion = txtGlosa.Text.Trim
            .fecha = DateTime.Now.ToString("yyyy/MM/dd") & " " & Now.ToString("HH:mm:ss")
            .estado = "1"
            .tipo_abono = "NORMAL"
        End With
        Dim objAbono As New nAbonosPagos
        objAbono.nRegistrarAbonoComprasBD(EntiAboCom, CadenaConexion)

        For Each row As DataGridViewRow In dgvOperaciones.Rows
            With EntiAsientoAboCom
                .id = objAbono.nObtenerUltimoAbonoCompraBD(CadenaConexion)
                .id_cliente = dataCompra.Rows(0)("num_dni").ToString
                .id_compra = codCompra
                .cuenta = row.Cells("num_cuenta").Value
                .base_imponible = txtMonto.Text.Trim
                .nro_detraccion = "0"
                .tipo_tasa_detraccion = "0"
                .valor_tasa = "0"
                .valor_detraccion = "0"
                .fecha_detraccion = frmNuevaCompraP.dtFechaPago.Value.ToString("yyyy/MM/dd")
                .monto = txtMonto.Text.Trim
                .tipo = "8"
                .descripcion = txtGlosa.Text.Trim
                .debe = row.Cells("debe").Value
                .haber = row.Cells("haber").Value
                .fecha = frmNuevaCompraP.dtFechaPago.Value.ToString("yyyy/MM/dd")
            End With
            objAbono.nRegistrarAsientoAbonoComprasBD(EntiAsientoAboCom, CadenaConexion)
            'MsgBox("ASIENTOS ABONOS: " & objAbono.nRegistrarAsientoAbonoComprasBD(EntiAsientoAboCom, CadenaConexion))
        Next
        MsgBox("COMPROBANTE DE COMPRA REGISTRADO CON ÉXITO")
        'frmListaComprobanteCompras.realizarConsulta()
        frmNuevaCompraP.Dispose()
        Me.Dispose()
    End Sub

    Private Sub btnCaja_Click(sender As Object, e As EventArgs) Handles btnCaja.Click
        frmEscogerCaja.formInicio = "compra"
        frmEscogerCaja.Show()
    End Sub
    Private Sub txtMonto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.Leave
        txtMonto.Text = Format(CType(txtMonto.Text, Decimal), "###0.00")
    End Sub

End Class