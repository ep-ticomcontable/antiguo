Imports Negocio
Imports Entidades

Public Class frmAbonoComprobanteVentas

    Dim objCom As New nComprobanteVenta
    Dim objPag As New nPagosCompras
    Dim objDet As New nDetraccion
    Dim objCrud As New nCrud
    Dim objCA As New nCuentaAsiento
    Dim objTP As New nTipoPagos
    Dim objAbono As New nAbonosPagos

    Dim dataVenta As New DataTable
    Public codVenta As String
    Dim iCarga As Integer = 0
    Dim idTipoOperacion As Integer = 2
    'Dim CodigoLocalSession As Integer = 1
    'Dim CodigoEmpresaSession As Integer = 1
    Dim montoDetraccion As Decimal = 0
    Dim calculoImpuesto As Decimal = 0
    Public bloqueo As Boolean

    Public Sub cargarTipoPagos(codCaja As String)
        Dim data, data2, data3 As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        'data.Rows.Add(0, "SIN AFECTO")
        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from caja_configuracion where id='" & codCaja & "'", CadenaConexion)
        If dt.Rows(0)("tipo").ToString.StartsWith("PRIN") Then
            data2 = objCrud.nCrudListarBD("select * from tipo_pago where estado='2'", CadenaConexion)
        Else
            data2 = objCrud.nCrudListarBD("select * from tipo_pago where estado='3'", CadenaConexion)
        End If
        For Each row As DataRow In data2.Rows
            data.Rows.Add(row.Item("id").ToString, row.Item("descripcion").ToString)
        Next
        With cboTipoPago
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub
    Public Sub cargarTipoPagos2(codCaja As String)
        Dim data, data2, data3 As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        'data.Rows.Add(0, "SIN AFECTO")

        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from caja_configuracion where id='" & codCaja & "'", CadenaConexion)
        If dt.Rows(0)("tipo").ToString.StartsWith("PRIN") Then
            data2 = objCrud.nCrudListarBD("select * from tipo_pago where estado='2'", CadenaConexion)
        Else
            data2 = objCrud.nCrudListarBD("select * from tipo_pago where estado='3'", CadenaConexion)
        End If
        For Each row As DataRow In data2.Rows
            data.Rows.Add(row.Item("id").ToString, row.Item("descripcion").ToString)
        Next
        With cboTipoPagoI
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub

    Private Sub cargarTipoMovimientos()
        cargarTipoPagos("1")
        'Dim data As New DataTable
        'data.Columns.Add("Codigo")
        'data.Columns.Add("Descripcion")
        'data.Rows.Add(0, "SIN AFECTO")
        'Dim data2 As DataTable
        'Try
        '    data2 = objCrud.nCrudListarBD("select * from tipo_pago where estado=1 order by codigo asc", CadenaConexion)
        '    For Each row As DataRow In data2.Rows
        '        data.Rows.Add(row.Item(0).ToString, row.Item(2).ToString)
        '    Next
        '    With cboTipoPago
        '        .DataSource = data
        '        .ValueMember = "Codigo"
        '        .DisplayMember = "Descripcion"
        '    End With
        '    data2.Dispose()
        'Catch ex As Exception
        '    MsgBox("No se pudo cargar los tipos de pago")
        'End Try
    End Sub
    Private Sub cargarTipoMovimientos2()
        cargarTipoPagos2("1")
        'Dim data As New DataTable
        'data.Columns.Add("Codigo")
        'data.Columns.Add("Descripcion")
        'data.Rows.Add(0, "SIN AFECTO")
        'Dim data2 As DataTable
        'Try
        '    data2 = objCrud.nCrudListarBD("select * from tipo_pago where estado=1 order by codigo asc", CadenaConexion)
        '    For Each row As DataRow In data2.Rows
        '        data.Rows.Add(row.Item(0).ToString, row.Item(2).ToString)
        '    Next
        '    With cboTipoPagoI
        '        .DataSource = data
        '        .ValueMember = "Codigo"
        '        .DisplayMember = "Descripcion"
        '    End With
        '    data2.Dispose()
        'Catch ex As Exception
        '    MsgBox("No se pudo cargar los tipos de pago")
        'End Try
    End Sub
    Private Sub cargarImpuestosSunat()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "SIN AFECTO")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListarBD("select * from impuestos_sunat where tipo_comprobante='VENTA' and estado=1", CadenaConexion)
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
    Private Sub txtCDetraccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCDetraccion.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtCDetraccion.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "frmAbonoVenta"
                    .cuentaInicio = txtCDetraccion.Text.Trim
                    .ShowDialog()
                End With
            End If
        End If
    End Sub

    Private Sub cargarDatosComprobanteVenta()
        dataVenta = objCom.nDataComprobanteVentaPorId(codVenta, CadenaConexion)

        Dim cadena As String()
        cadena = dataVenta.Rows(0)("marca").ToString.Split("@")
        If cadena.Count > 0 Then
            'MsgBox(cadena(0).ToString & "-" & cadena(1).ToString)
            cboImpuestos.SelectedValue = cadena(0).ToString
            cargarDatosImpuestos()
            If cadena(0).ToString = "0" Then
                gbImpuestos.Enabled = False
                btnBuscar2.Enabled = False
                btnAgregar2.Enabled = False
            End If
        End If

        lblDniRuc.Text = dataVenta.Rows(0)("num_dni")
        lblRazonNombre.Text = dataVenta.Rows(0)("razon_social")
        lblDocumento.Text = dataVenta.Rows(0)("documento")
        lblSerieNumero.Text = dataVenta.Rows(0)("serie") & "-" & dataVenta.Rows(0)("numero")
        LblMoneda.Text = dataVenta.Rows(0)("moneda")
        lblTipoCambio.Text = dataVenta.Rows(0)("tipo_cambio")
        lblDescripcionCompra.Text = dataVenta.Rows(0)("glosa")
        lblFechaEmision.Text = dataVenta.Rows(0)("fec_emision")
        lblFechaPago.Text = dataVenta.Rows(0)("fec_pago")
        'txtBaseDetraccion.Text = dataVenta.Rows(0)("total")
        lblMontoCompra.Text = (dataVenta.Rows(0)("total"))
        Dim dtAbono As New DataTable
        dtAbono = objCrud.nCrudListarBD("select isnull(sum(monto),0) as 'abono' from abono_pagos_ventas where id_venta='" & codVenta & "'", CadenaConexion)
        If Decimal.Parse(dtAbono.Rows(0)("abono").ToString) > 0 Then
            lblDeuda.Text = (dataVenta.Rows(0)("total") - Decimal.Parse(dtAbono.Rows(0)("abono")))
        Else
            lblDeuda.Text = (dataVenta.Rows(0)("total"))
        End If
        txtMonto.Text = lblDeuda.Text

        Dim dtVenta As New DataTable
        dtVenta = objCrud.nCrudListarBD("select * from detalle_asiento_venta where id_asiento_venta='" & codVenta & "'", CadenaConexion)

        cboImpuestos.SelectedValue = dtVenta.Rows(0)("tipo_tasa_detraccion").ToString
        txtPorcentaje.Text = dtVenta.Rows(0)("tasa_detraccion").ToString
        dtFecImpuesto.Value = Date.Parse(dtVenta.Rows(0)("fecha_detraccion").ToString)
        txtNumeroImpuesto.Text = dtVenta.Rows(0)("numero_detraccion").ToString
        txtGlosaDet.Text = "PAGO DE " & cboImpuestos.Text.Trim '& ": " & txtNumeroImpuesto.Text.Trim

        'Cargar montos
        Dim pretotal As Decimal = 0
        If cboImpuestos.Text.Trim.StartsWith("PERCEPCI") Then
            pretotal = lblMontoCompra.Text
        Else
            pretotal = Decimal.Parse(lblMontoCompra.Text.Trim) - Decimal.Round((Decimal.Parse(lblMontoCompra.Text.Trim) * Decimal.Parse(txtPorcentaje.Text) / 100), 2)
        End If

        If cboImpuestos.SelectedValue <> 0 And Not cboImpuestos.Text.Trim.StartsWith("DETRACCI") Then
            gbImpuestos.Enabled = False
        Else
            gbImpuestos.Enabled = True
        End If
        'gbImpuestos.Enabled = True
        If cadena(0).ToString <> "0" Then
            txtMontoDet.Text = Decimal.Round((Decimal.Parse(lblMontoCompra.Text.Trim) * Decimal.Parse(txtPorcentaje.Text) / 100), 2)
            txtMonto.Text = pretotal
        Else
            txtMonto.Text = lblDeuda.Text.Trim
            txtMontoDet.Text = "0.00"
        End If
        txtMontoImpuesto.Text = Decimal.Round((Decimal.Parse(lblMontoCompra.Text.Trim) * Decimal.Parse(txtPorcentaje.Text) / 100), 2)
        txtRestaImpuesto.Text = txtMontoImpuesto.Text
        txtDescripcion.Text = "POR EL COBRO DE LA FACTURA: " & lblSerieNumero.Text

        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from detracciones where operacion='VENTA' and id_comprobante='" & codVenta & "'", CadenaConexion)
        If dt.Rows.Count > 0 Then
            If dt.Rows(0)("numero").ToString.Length > 2 Then
                txtNumeroImpuesto.Text = dt.Rows(0)("numero").ToString
            End If
        End If
    End Sub
    Private Sub cargarAbonosPagoVenta()
        Dim data As New DataTable
        data = objAbono.nSumaAbonoPagoCompras(codVenta)

        If data.Rows.Count > 0 Then
            Dim dataVenta As New DataTable
            dataVenta = objCom.nDataComprobanteVentaPorId(codVenta, CadenaConexion)
            txtMonto.Text = (dataVenta.Rows(0)("total") - data.Rows(0)("abono"))
        End If

    End Sub
    Private Sub frmAbonoComprobanteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTipoMovimientos()
        cargarTipoMovimientos2()
        dgvOperaciones.RowTemplate.Height = 34
        cebrasDatagrid(dgvOperaciones, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        cargarImpuestosSunat()
        iCarga = 1
        cargarDatosComprobanteVenta()
        cargarAbonosPagoVenta()
        cargarCuentaInicial()
        cargarDeudaPendiente()
        cargarPagosPredeterminados()
        'INHABILITAR CUANDO ES PERCEPCION
        If cboImpuestos.Text.Trim.StartsWith("PERCEPCI") Then
            gbImpuestos.Enabled = False
            txtIdCaja2.Text = 0
        End If
        frmAccionCobrosVentas.Close()
        If bloqueo = True Then
            gbCaja.Enabled = False
        Else
            gbCaja.Enabled = True
        End If
    End Sub

    Private Sub cargarDeudaPendiente()
        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from asientos_abono_ventas where id_venta='" & codVenta & "'", CadenaConexion)
        If dt.Rows.Count > 0 Then

            Dim dtImp As New DataTable
            dtImp = objCrud.nCrudListarBD("select * from abono_pagos_ventas where id_venta='" & codVenta & "' and id_impuesto='" & cboImpuestos.SelectedValue.ToString & "'", CadenaConexion)

            Dim estadoDetraccion As Boolean = False
            Dim sumaAbonoImpuesto As Decimal = 0
            For Each row As DataRow In dtImp.Rows
                'If row.Item("cuenta").ToString = txtCuentaI.Text.Trim Then
                '    'estadoDetraccion = True
                '    Exit For
                'End If
                sumaAbonoImpuesto = sumaAbonoImpuesto + Decimal.Parse(row.Item("monto").ToString)
            Next

            If sumaAbonoImpuesto < Decimal.Parse(txtMontoImpuesto.Text.Trim) Then
                estadoDetraccion = False
                txtMontoDet.Text = Decimal.Parse(txtMontoImpuesto.Text.Trim) - sumaAbonoImpuesto
            Else
                estadoDetraccion = True
                txtMontoDet.Text = Decimal.Parse(txtMontoImpuesto.Text.Trim)
            End If

            txtRestaImpuesto.Text = txtMontoDet.Text

            If estadoDetraccion = False Then
                gbImpuestos.Enabled = True
                txtBI.Text = "0"

                Dim dtAbono As New DataTable
                dtAbono = objCrud.nCrudListarBD("select isnull(sum(monto),0) as 'abono' from abono_pagos_ventas where id_venta='" & codVenta & "' and id_impuesto<>'" & cboImpuestos.SelectedValue.ToString & "'", CadenaConexion)
                If Decimal.Parse(dtAbono.Rows(0)("abono").ToString) > 0 Then
                    If gbImpuestos.Enabled = True Then
                        txtMonto.Text = Decimal.Parse(lblDeuda.Text.Trim) - Decimal.Parse(txtMontoDet.Text.Trim)
                    Else
                        txtMonto.Text = lblDeuda.Text.Trim
                    End If
                Else
                    txtMonto.Text = (dataVenta.Rows(0)("total"))
                End If

            Else
                gbImpuestos.Enabled = False
                txtBI.Text = "0"
                Dim totalImpueso As Decimal = 0
                If gbImpuestos.Enabled = False Then
                    'txtMonto.Text = lblDeuda.Text.Trim
                    'Dim dtI As New DataTable
                    'dtI = objCrud.nCrudListarBD("select * from retenciones where operacion='COMPRA' and id_comprobante='" & codCompra & "'", CadenaConexion)
                    'If dtI.Rows.Count > 0 Then
                    '    If dtI.Rows(0)("tipo").ToString = "PENDIENTE" Then
                    '        totalImpueso = Decimal.Parse(dtI.Rows(0)("monto"))
                    '    End If
                    'End If
                    txtMonto.Text = (Decimal.Parse(lblDeuda.Text.Trim)) - totalImpueso
                End If
            End If
        Else
            gbImpuestos.Enabled = True
            txtBI.Text = "0"
        End If

        ''Deshabilitar pago de Impuestos
        'Dim dt As New DataTable
        'dt = objCrud.nCrudListarBD("select * from asientos_abono_ventas where id_venta='" & codVenta & "'", CadenaConexion)
        'If dt.Rows.Count > 0 Then
        '    Dim estadoDetraccion As Boolean = False
        '    For Each row As DataRow In dt.Rows
        '        If row.Item("cuenta").ToString = txtCuentaI.Text.Trim Then
        '            estadoDetraccion = True
        '            Exit For
        '        End If
        '    Next
        '    If estadoDetraccion = False Then
        '        'gbImpuestos.Enabled = True
        '        txtBI.Text = "0"

        '        Dim dtAbono As New DataTable
        '        dtAbono = objCrud.nCrudListarBD("select isnull(sum(monto),0) as 'abono' from abono_pagos_ventas where id_venta='" & codVenta & "'", CadenaConexion)
        '        If Decimal.Parse(dtAbono.Rows(0)("abono").ToString) > 0 Then
        '            If gbImpuestos.Enabled = True Then
        '                txtMonto.Text = (dataVenta.Rows(0)("total") - Decimal.Parse(dtAbono.Rows(0)("abono"))) - Decimal.Parse(txtMontoDet.Text.Trim)
        '            Else
        '                txtMonto.Text = lblDeuda.Text.Trim
        '            End If
        '        Else
        '            txtMonto.Text = (dataVenta.Rows(0)("total"))
        '        End If

        '    Else
        '        'gbImpuestos.Enabled = False
        '        txtBI.Text = "0"
        '        If gbImpuestos.Enabled = False Then
        '            txtMonto.Text = lblDeuda.Text.Trim
        '        End If
        '    End If
        'Else
        '    'gbImpuestos.Enabled = True
        '    txtBI.Text = "0"
        'End If
    End Sub

    Private Sub cargarCuentaInicial()
        If iCarga = 1 Then
            Dim data As New DataTable
            data = objCrud.nCrudListarBD("select * from detalle_asiento_venta where id_asiento_venta='" & codVenta & "'", CadenaConexion)
            If data.Rows(0)("tipo_tasa_detraccion").ToString <> "0" Then
                Dim dataImp As New DataTable
                dataImp = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & cboImpuestos.SelectedValue.ToString & "'", CadenaConexion)
                txtCuentaI.Text = dataImp.Rows(0)("cuenta").ToString

                For Each row As DataRow In data.Rows
                    If row.Item("cuenta").ToString.StartsWith("1") And row.Item("cuenta").ToString <> dataImp.Rows(0)("cuenta").ToString Then
                        txtCuentaP.Text = row.Item("cuenta").ToString
                        lblCuentaP.Text = obtenerDatosCuenta(row.Item("cuenta").ToString)
                        Exit For
                    End If
                Next
            Else
                For Each row As DataRow In data.Rows
                    If row.Item("cuenta").ToString.StartsWith("1") And row.Item("cuenta").ToString Then
                        txtCuentaP.Text = row.Item("cuenta").ToString
                        lblCuentaP.Text = obtenerDatosCuenta(row.Item("cuenta").ToString)
                        Exit For
                    End If
                Next
            End If
        End If

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

        lblDebe.Text = Format(tDebe, "#,##0.00")
        lblHaber.Text = Format(tHaber, "#,##0.00")
        lblDiferencia.Text = Format(tDiferencia, "#,##0.00")
    End Sub
    Private Function verificarPartidaDoble() As Boolean
        Dim rpta As Boolean = False
        Dim sDebe, sHaber As Decimal
        For Each row As DataGridViewRow In dgvOperaciones.Rows
            sDebe = sDebe + Decimal.Parse(row.Cells("debe").Value.ToString)
            sHaber = sHaber + Decimal.Parse(row.Cells("haber").Value.ToString)
        Next
        If sDebe = sHaber And sDebe > 0 And sHaber > 0 Then
            rpta = True
        Else
            MsgBox("La suma de las cantidades en las columnas del DEBE & HABER no son iguales.")
        End If
        Return rpta
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If verificarPartidaDoble() = True Then
            Dim EntiAboCom As New AbonoVentasEntity
            Dim EntiAsientoAboCom, EntiAsientoAboCom2 As New AbonoComprasEntity
            If Integer.Parse(txtENC.Text.Trim) > 0 Then
                Dim dtNC As New DataTable
                dtNC = objCrud.nCrudListarBD("select * from comprobante_nota_credito where id='" & txtENC.Text.Trim & "'", CadenaConexion)
                With EntiAboCom
                    .tipo_comprobante = "8" 'NOTA DE CREDITO
                    .id_venta = codVenta
                    .id_impuesto = 0
                    .id_letra = 0
                    .monto = dtNC.Rows(0)("total").ToString
                    .id_banco = "0"
                    .id_caja = "0"
                    .tipo = "0"
                    .numero = dtNC.Rows(0)("serie").ToString & "-" & dtNC.Rows(0)("numero").ToString
                    .descripcion = "CON NOTA DE CRÉDITO N°: " & dtNC.Rows(0)("serie").ToString & "-" & dtNC.Rows(0)("numero").ToString
                    .fecha = DateTime.Now.ToString("yyyy/MM/dd") & " " & Now.ToString("HH:mm:ss")
                    .estado = "1"
                    .tipo_abono = "NORMAL"
                    .codEmpresa = CodigoEmpresaSession
                End With
                objAbono.nRegistrarAbonoVentasBD(EntiAboCom, CadenaConexion)

                Dim idVenta As String = objAbono.nObtenerUltimoAbonoVenta(CadenaConexion)
                With EntiAsientoAboCom
                    .id = idVenta
                    .id_cliente = dataVenta.Rows(0)("num_dni").ToString
                    .id_compra = codVenta
                    .cuenta = txtCuentaP.Text.Trim
                    .base_imponible = dtNC.Rows(0)("total").ToString
                    .nro_detraccion = txtNumeroImpuesto.Text
                    If cboImpuestos.Text.Trim.StartsWith("RETENC") Then
                        .tipo_tasa_detraccion = "0"
                    Else
                        .tipo_tasa_detraccion = cboImpuestos.SelectedValue.ToString
                    End If
                    '.tipo_tasa_detraccion = cboImpuestos.SelectedValue.ToString
                    .valor_tasa = txtPorcentaje.Text.Trim
                    .valor_detraccion = txtMontoDet.Text.Trim
                    .fecha_detraccion = dtFecImpuesto.Value.ToString("yyyy/MM/dd")
                    .monto = txtMonto.Text.Trim
                    .tipo = cboTipoPago.SelectedValue
                    .descripcion = txtDescripcion.Text
                    .debe = dtNC.Rows(0)("total").ToString
                    .haber = "0.00"
                    .fecha = dtFechaAbono.Value.ToString("yyyy/MM/dd")
                    .estado = "1"
                End With
                objAbono.nRegistrarAsientoAbonoVentas(EntiAsientoAboCom, CadenaConexion)
                With EntiAsientoAboCom
                    .id = idVenta
                    .id_cliente = dataVenta.Rows(0)("num_dni").ToString
                    .id_compra = codVenta
                    .cuenta = txtCuentaP.Text.Trim
                    .base_imponible = dtNC.Rows(0)("total").ToString
                    .nro_detraccion = txtNumeroImpuesto.Text
                    If cboImpuestos.Text.Trim.StartsWith("RETENC") Then
                        .tipo_tasa_detraccion = "0"
                    Else
                        .tipo_tasa_detraccion = cboImpuestos.SelectedValue.ToString
                    End If
                    .valor_tasa = txtPorcentaje.Text.Trim
                    .valor_detraccion = txtMontoDet.Text.Trim
                    .fecha_detraccion = dtFecImpuesto.Value.ToString("yyyy/MM/dd")
                    .monto = txtMonto.Text.Trim
                    .tipo = cboTipoPago.SelectedValue
                    .descripcion = txtDescripcion.Text
                    .debe = "0.00"
                    .haber = dtNC.Rows(0)("total").ToString
                    .fecha = dtFechaAbono.Value.ToString("yyyy/MM/dd")
                    .estado = "1"
                End With
                objAbono.nRegistrarAsientoAbonoVentas(EntiAsientoAboCom, CadenaConexion)

                'cambiar de estado a la nota de crédito usada
                objCrud.nEjecutarQueryBD("update comprobante_nota_credito set estado='0' where id='" & txtENC.Text.Trim & "'", CadenaConexion)
            End If
            If txtBE.Text = "1" Then
                With EntiAboCom
                    .tipo_comprobante = dataVenta.Rows(0)("id_tipo_comprobante").ToString
                    .id_venta = codVenta
                    .id_impuesto = 0
                    .id_letra = 0
                    .monto = txtMonto.Text.Trim
                    .id_banco = "0"
                    .id_caja = txtIdCaja.Text.Trim
                    .tipo = cboTipoPago.SelectedValue.ToString
                    .numero = txtNumero.Text.Trim
                    .descripcion = txtDescripcion.Text.Trim
                    .fecha = DateTime.Now.ToString("yyyy/MM/dd") & " " & Now.ToString("HH:mm:ss")
                    .estado = "1"
                    .tipo_abono = "NORMAL"
                End With
                objAbono.nRegistrarAbonoVentasBD(EntiAboCom, CadenaConexion)

                Dim idVenta As String = objAbono.nObtenerUltimoAbonoVenta(CadenaConexion)
                With EntiAsientoAboCom
                    .id = idVenta
                    .id_cliente = dataVenta.Rows(0)("num_dni").ToString
                    .id_compra = codVenta
                    .cuenta = txtCuenta.Text.Trim
                    .base_imponible = txtMonto.Text.Trim
                    .nro_detraccion = txtNumeroImpuesto.Text
                    If cboImpuestos.Text.Trim.StartsWith("RETENC") Then
                        .tipo_tasa_detraccion = "0"
                    Else
                        .tipo_tasa_detraccion = cboImpuestos.SelectedValue.ToString
                    End If
                    '.tipo_tasa_detraccion = cboImpuestos.SelectedValue.ToString
                    .valor_tasa = txtPorcentaje.Text.Trim
                    .valor_detraccion = txtMontoDet.Text.Trim
                    .fecha_detraccion = dtFecImpuesto.Value.ToString("yyyy/MM/dd")
                    .monto = txtMonto.Text.Trim
                    .tipo = cboTipoPago.SelectedValue
                    .descripcion = txtDescripcion.Text
                    .debe = txtMonto.Text.Trim
                    .haber = "0.00"
                    .fecha = dtFechaAbono.Value.ToString("yyyy/MM/dd")
                    .estado = "1"
                End With
                objAbono.nRegistrarAsientoAbonoVentas(EntiAsientoAboCom, CadenaConexion)
                With EntiAsientoAboCom
                    .id = idVenta
                    .id_cliente = dataVenta.Rows(0)("num_dni").ToString
                    .id_compra = codVenta
                    .cuenta = txtCuentaP.Text.Trim
                    .base_imponible = txtMonto.Text.Trim
                    .nro_detraccion = txtNumeroImpuesto.Text
                    If cboImpuestos.Text.Trim.StartsWith("RETENC") Then
                        .tipo_tasa_detraccion = "0"
                    Else
                        .tipo_tasa_detraccion = cboImpuestos.SelectedValue.ToString
                    End If
                    .valor_tasa = txtPorcentaje.Text.Trim
                    .valor_detraccion = txtMontoDet.Text.Trim
                    .fecha_detraccion = dtFecImpuesto.Value.ToString("yyyy/MM/dd")
                    .monto = txtMonto.Text.Trim
                    .tipo = cboTipoPago.SelectedValue
                    .descripcion = txtDescripcion.Text
                    .debe = "0.00"
                    .haber = txtMonto.Text.Trim
                    .fecha = dtFechaAbono.Value.ToString("yyyy/MM/dd")
                    .estado = 1
                End With
                objAbono.nRegistrarAsientoAbonoVentas(EntiAsientoAboCom, CadenaConexion)

                If cboImpuestos.Text.Trim.StartsWith("RETENC") Then
                    Dim dtI As New DataTable
                    dtI = objCrud.nCrudListarBD("select * from retenciones where operacion='VENTA' and id_comprobante='" & codVenta & "'", CadenaConexion)
                    If dtI.Rows.Count = 0 Then

                        With EntiAsientoAboCom
                            .id = idVenta
                            .id_cliente = dataVenta.Rows(0)("num_dni").ToString
                            .id_compra = codVenta
                            .cuenta = txtCuentaP.Text.Trim
                            .base_imponible = txtMonto.Text.Trim
                            .nro_detraccion = txtNumeroImpuesto.Text
                            .tipo_tasa_detraccion = cboImpuestos.SelectedValue
                            .valor_tasa = txtPorcentaje.Text.Trim
                            .valor_detraccion = calculoImpuesto
                            .fecha_detraccion = dtFecImpuesto.Value.ToString("yyyy/MM/dd")
                            .monto = calculoImpuesto
                            .tipo = cboTipoPago.SelectedValue
                            .descripcion = txtDescripcion.Text
                            .debe = "0.00"
                            .haber = calculoImpuesto
                            .fecha = dtFechaAbono.Value.ToString("yyyy/MM/dd")
                            .estado = "NOLD"
                        End With
                        objAbono.nRegistrarAsientoAbonoVentas(EntiAsientoAboCom, CadenaConexion)


                        With EntiAsientoAboCom
                            .id = idVenta
                            .id_cliente = dataVenta.Rows(0)("num_dni").ToString
                            .id_compra = codVenta
                            .cuenta = txtCuentaI.Text.Trim
                            .base_imponible = calculoImpuesto
                            .nro_detraccion = txtNumeroImpuesto.Text
                            .tipo_tasa_detraccion = cboImpuestos.SelectedValue
                            .valor_tasa = txtPorcentaje.Text.Trim
                            .valor_detraccion = calculoImpuesto
                            .fecha_detraccion = dtFecImpuesto.Value.ToString("yyyy/MM/dd")
                            .monto = calculoImpuesto
                            .tipo = cboTipoPago.SelectedValue
                            .descripcion = txtDescripcion.Text
                            .debe = calculoImpuesto
                            .haber = "0.00"
                            .fecha = dtFechaAbono.Value.ToString("yyyy/MM/dd")
                            .estado = "NOLD"
                        End With
                        objAbono.nRegistrarAsientoAbonoVentas(EntiAsientoAboCom, CadenaConexion)



                        'REGISTRANDO RETENCION POR PAGAR
                        Dim entiRet As New RetencionEntity
                        With entiRet
                            .operacion = "VENTA"
                            .serie = "0"
                            .numero = txtNumeroImpuesto.Text.Trim
                            .glosa = txtGlosaDet.Text.Trim
                            .fec_reg = Date.Parse(dtFecImpuesto.Value)
                            .id_comprobante = codVenta
                            .total = lblMontoCompra.Text.Trim
                            .monto = Decimal.Parse(txtMontoDet.Text.Trim)
                            .tipo = "PENDIENTE"
                            .estado = "1"
                        End With
                        Dim objRet As New nRetenciones
                        Dim rptaRet As String = ""
                        rptaRet = objRet.registrarRetenciones(entiRet, CadenaConexion)
                        If rptaRet <> "ok" Then
                            MsgBox("Error al registrar Retención: " & vbCrLf & rptaRet)
                        End If
                        Dim dt As New DataTable
                        dt = objCrud.nCrudListarBD("select top 1 * from retenciones order by id desc", CadenaConexion)

                        Dim entidadLD As New ALDiarioEntity
                        Dim objLD As New nAsientoLibroDiario
                        Dim campos As String = ""
                        Dim valores As String = ""
                        Dim rpta As String = ""
                        campos = "tipo_comprobante@id_retencion@id_caja@monto@tipo@numero@descripcion@fecha@estado"
                        valores = codVenta & "@" & dt.Rows(0)("id").ToString & "@" & txtIdCaja2.Text.Trim & "@" & txtMontoDet.Text.Trim & "@-@-@" & txtGlosaDet.Text.Trim & "@" & Date.Parse(dtFechaAbono.Value).ToString("yyyy/MM/dd") & "@1"
                        rpta = objCrud.nCrudInsertarBD("@", "abono_pagos_retencion", campos, valores, CadenaConexion)

                        Dim dtAbo As New DataTable
                        dtAbo = objCrud.nCrudListarBD("select top 1 * from abono_pagos_retencion order by id desc", CadenaConexion)
                        rpta = ""
                        campos = ""
                        valores = ""
                        campos = "id_abono_retencion@id_retencion@cuenta@desc_cuenta@glosa@debe@haber"
                        valores = dtAbo.Rows(0)("id").ToString & "@" & dt.Rows(0)("id").ToString & "@" & txtCuentaP.Text.Trim & "@" & obtenerDatosCuenta(txtCuentaP.Text.Trim) & "@" & txtGlosaDet.Text.Trim & "@0.00@" & calculoImpuesto
                        rpta = objCrud.nCrudInsertarBD("@", "asientos_abono_retencion", campos, valores, CadenaConexion)

                        With entidadLD
                            .id_comprobante = "ABR" & dtAbo.Rows(0)("id").ToString
                            .cuo = "0"
                            .fecha_operacion = Date.Parse(dtFecImpuesto.Value)
                            .glosa = txtGlosaDet.Text.Trim
                            .cod_libro = txtCuentaP.Text.Trim
                            .numero_correlativo = "-"
                            .numero_documento = "-"
                            .cuenta = txtCuentaP.Text.Trim
                            .denominacion = obtenerDatosCuenta(txtCuentaP.Text.Trim)
                            .debe = "0.00"
                            .haber = calculoImpuesto
                        End With
                        objLD.registrarAsientoLibroDiarioBD(entidadLD, CadenaConexion)

                        rpta = ""
                        valores = ""
                        valores = dtAbo.Rows(0)("id").ToString & "@" & dt.Rows(0)("id").ToString & "@" & txtCuentaI.Text.Trim & "@" & obtenerDatosCuenta(txtCuentaI.Text.Trim) & "@" & txtGlosaDet.Text.Trim & "@" & calculoImpuesto & "@0.00"
                        rpta = objCrud.nCrudInsertarBD("@", "asientos_abono_retencion", campos, valores, CadenaConexion)
                        With entidadLD
                            .id_comprobante = "ABR" & dtAbo.Rows(0)("id").ToString
                            .cuo = "0"
                            .fecha_operacion = Date.Parse(dtFecImpuesto.Value)
                            .glosa = txtGlosaDet.Text.Trim
                            .cod_libro = txtCuentaI.Text.Trim
                            .numero_correlativo = "-"
                            .numero_documento = "-"
                            .cuenta = txtCuentaI.Text.Trim
                            .denominacion = obtenerDatosCuenta(txtCuentaI.Text.Trim)
                            .debe = calculoImpuesto
                            .haber = "0.00"
                        End With
                        objLD.registrarAsientoLibroDiarioBD(entidadLD, CadenaConexion)
                    End If
                End If
            End If

            If txtBI.Text = "1" Then
                If Decimal.Parse(txtMontoDet.Text.Trim) > 0 Then
                    'ACTUALIZAR SERIE Y NUMERO DE IMPUESTO
                    Dim serNum As String = ""
                    serNum = txtNumeroImpuesto.Text.Trim
                    If serNum.Length > 2 Then
                        If cboImpuestos.Text.StartsWith("DETRAC") Then
                            objCrud.nEjecutarQueryBD("update detracciones set numero='" & serNum & "' where operacion='VENTA' and id_comprobante='" & codVenta & "'", CadenaConexion)
                        ElseIf cboImpuestos.Text.StartsWith("PERCEP") Then
                            objCrud.nEjecutarQueryBD("update percepciones set numero='" & serNum & "' where operacion='VENTA' and id_comprobante='" & codVenta & "'", CadenaConexion)
                        ElseIf cboImpuestos.Text.StartsWith("RETEN") Then
                            objCrud.nEjecutarQueryBD("update retenciones set numero='" & serNum & "' where operacion='VENTA' and id_comprobante='" & codVenta & "'", CadenaConexion)
                        End If
                    End If
                    'REGISTRO DE DETRACCION
                    With EntiAboCom
                        .id_venta = codVenta
                        .tipo_comprobante = dataVenta.Rows(0)("id_tipo_comprobante").ToString
                        .id_impuesto = cboImpuestos.SelectedValue.ToString
                        .id_letra = 0
                        .monto = txtMontoDet.Text.Trim
                        .id_banco = "0"
                        .id_caja = txtIdCaja2.Text.Trim
                        .tipo = cboTipoPagoI.SelectedValue.ToString
                        .numero = txtNumeroImpuesto.Text.Trim
                        .descripcion = txtGlosaDet.Text.Trim
                        .fecha = DateTime.Now.ToString("yyyy/MM/dd") & " " & Now.ToString("HH:mm:ss")
                        .estado = "1"
                        .tipo_abono = "NORMAL"
                    End With
                    objAbono.nRegistrarAbonoVentasBD(EntiAboCom, CadenaConexion)
                    If Not cboImpuestos.Text.StartsWith("RETENC") Then
                        Dim idVenta2 As String = "0"
                        idVenta2 = objAbono.nObtenerUltimoAbonoVenta(CadenaConexion)
                        With EntiAsientoAboCom2
                            .id = idVenta2
                            .id_cliente = dataVenta.Rows(0)("num_dni").ToString
                            .id_compra = codVenta
                            .cuenta = txtCDetraccion.Text.Trim
                            .base_imponible = txtMontoDet.Text.Trim
                            .nro_detraccion = txtNumeroImpuesto.Text
                            .tipo_tasa_detraccion = cboImpuestos.SelectedValue.ToString
                            .valor_tasa = txtPorcentaje.Text.Trim
                            .valor_detraccion = txtMontoDet.Text.Trim
                            .fecha_detraccion = dtFecImpuesto.Value.ToString("yyyy/MM/dd")
                            .monto = txtMontoDet.Text.Trim
                            .tipo = cboTipoPagoI.SelectedValue
                            .descripcion = txtGlosaDet.Text
                            .debe = txtMontoDet.Text.Trim
                            .haber = "0.00"
                            .fecha = dtFechaAbono.Value.ToString("yyyy/MM/dd")
                            .estado = "1"
                        End With
                        objAbono.nRegistrarAsientoAbonoVentas(EntiAsientoAboCom2, CadenaConexion)

                        With EntiAsientoAboCom2
                            .id = idVenta2
                            .id_cliente = dataVenta.Rows(0)("num_dni").ToString
                            .id_compra = codVenta
                            .cuenta = txtCuentaI.Text.Trim
                            .base_imponible = txtMontoDet.Text.Trim
                            .nro_detraccion = txtNumeroImpuesto.Text
                            .tipo_tasa_detraccion = cboImpuestos.SelectedValue.ToString
                            .valor_tasa = txtPorcentaje.Text.Trim
                            .valor_detraccion = txtMontoDet.Text.Trim
                            .fecha_detraccion = dtFecImpuesto.Value.ToString("yyyy/MM/dd")
                            .monto = txtMontoDet.Text.Trim
                            .tipo = cboTipoPagoI.SelectedValue
                            .descripcion = txtGlosaDet.Text
                            .debe = "0.00"
                            .haber = txtMontoDet.Text.Trim
                            .fecha = dtFechaAbono.Value.ToString("yyyy/MM/dd")
                            .estado = "1"
                        End With
                        objAbono.nRegistrarAsientoAbonoVentas(EntiAsientoAboCom2, CadenaConexion)
                    End If
                    Dim dt As New DataTable
                    dt = objCrud.nCrudListarBD("select * from abono_pagos_ventas where id_impuesto='" & cboImpuestos.SelectedValue.ToString & "' and id_venta='" & codVenta & "'", CadenaConexion)
                    If dt.Rows.Count > 0 Then
                        Dim dtSum As New DataTable
                        dtSum = objCrud.nCrudListarBD("select sum(monto) as total from abono_pagos_ventas where id_impuesto='" & cboImpuestos.SelectedValue.ToString & "' and id_venta='" & codVenta & "'", CadenaConexion)
                        If Decimal.Parse(dtSum.Rows(0)("total").ToString) = Decimal.Parse(txtMontoImpuesto.Text.Trim) Then
                            Dim campoAct, valorAct, condAct As String
                            campoAct = "tipo"
                            valorAct = "CANCELADO"
                            condAct = "id_comprobante='" & codVenta & "'"
                            objCrud.nCrudActualizarBD("~", "detracciones", campoAct, valorAct, condAct, CadenaConexion)
                            frmListaDetracciones.cargarListaDetracciones()
                        End If
                    End If
                End If
            End If

            MsgBox("PAGO REGISTRADO CON ÉXITO")
            frmListaComprobanteVentas.realizarConsulta()
            frmListaComprobanteVentas.seleccionarCodigoDeVenta(codVenta)
            If bloqueo = True Then
                frmListaDetracciones.cargarListaDetracciones()
                frmListaDetracciones.seleccionarCodigoDeVenta(codVenta)
            End If
            Me.Dispose()
        End If
    End Sub
    Private Sub btnCaja_Click(sender As Object, e As EventArgs) Handles btnCaja.Click
        frmEscogerCaja.formInicio = "abonoVenta"
        txtIdNC.Text = 0
        txtNumero.Text = 0
        frmEscogerCaja.Text = "FORMAS DE COBRO"
        frmEscogerCaja.Show()
    End Sub
    Private Sub btnBuscar2_Click(sender As Object, e As EventArgs) Handles btnBuscar2.Click
        frmEscogerCaja.formInicio = "abonoVenta2"
        frmEscogerCaja.Text = "FORMAS DE COBRO"
        frmEscogerCaja.Show()
    End Sub
    Private Sub cboImpuestos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboImpuestos.SelectedIndexChanged
        If iCarga = 1 Then
            cargarDatosImpuestos()
        End If
    End Sub
    Private Sub cargarDatosImpuestos()
        If cboImpuestos.SelectedValue.ToString <> "0" Then
            'cboSerieImpuesto.Enabled = True
            txtNumeroImpuesto.Enabled = True

            Dim dataPorc As New DataTable
            dataPorc = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & cboImpuestos.SelectedValue.ToString & "'", CadenaConexion)
            txtCuentaI.Text = dataPorc.Rows(0)("cuenta").ToString
            If dataPorc.Rows.Count > 0 Then
                txtPorcentaje.Text = dataPorc.Rows(0)("porcentaje").ToString
            Else
                txtPorcentaje.Text = "0"
            End If

            If cboImpuestos.Text = "DETRACCIÓN" Then
                panelDetraccion.Enabled = True
            Else
                panelDetraccion.Enabled = False
            End If

            If cboImpuestos.SelectedValue = "0" Then
                'cboSerieImpuesto.Enabled = False
                txtNumeroImpuesto.Enabled = False
            Else
                '    cboSerieImpuesto.Enabled = True
                '    txtNumeroImpuesto.Enabled = True
                '    Dim data As New DataTable
                '    data.Columns.Add("Codigo")
                '    data.Columns.Add("Descripcion")
                '    Dim data2 As DataTable
                '    Try
                '        data2 = objCrud.nCrudListarBD("select * from empresa_agente where id_empresa='" & CodigoEmpresaSession & "' and id_impuesto_sunat='" & cboImpuestos.SelectedValue.ToString & "' and estado=1", CadenaConexion)
                '        For Each row As DataRow In data2.Rows
                '            data.Rows.Add(row.Item("id").ToString, row.Item("serie").ToString)
                '        Next
                '        With cboSerieImpuesto
                '            .DataSource = data
                '            .ValueMember = "Codigo"
                '            .DisplayMember = "Descripcion"
                '        End With
                '        data2.Dispose()
                '    Catch ex As Exception
                '        MsgBox("No se pudo cargar la lista de Impuestos")
                '    End Try
            End If
            Dim dataImp As New DataTable
            dataImp = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & cboImpuestos.SelectedValue.ToString & "'", CadenaConexion)
            txtCuentaI.Text = dataImp.Rows(0)("cuenta").ToString
        Else
            'cboSerieImpuesto.Enabled = False
            txtNumeroImpuesto.Enabled = False
        End If
    End Sub


    Private Sub cargarPagosPredeterminados()
        If iCarga = 1 Then
            Dim data As New DataTable
            data = objCrud.nCrudListarBD("select * from caja_configuracion where id='" & txtIdCaja.Text.Trim & "'", CadenaConexion)
            If data.Rows.Count > 0 Then
                If data.Rows(0)("tipo").ToString = "PRINCIPAL" Or data.Rows(0)("tipo").ToString = "CHICA" Then
                    cboTipoPago.SelectedValue = "8"
                ElseIf data.Rows(0)("tipo").ToString = "BANCOS" Then
                    cboTipoPago.SelectedValue = "1"
                End If
            End If

            Dim dataI As New DataTable
            dataI = objCrud.nCrudListarBD("select * from caja_configuracion where id='" & txtIdCaja2.Text.Trim & "'", CadenaConexion)
            If dataI.Rows.Count > 0 Then
                If dataI.Rows(0)("tipo").ToString = "PRINCIPAL" Or dataI.Rows(0)("tipo").ToString = "CHICA" Then
                    cboTipoPagoI.SelectedValue = "8"
                ElseIf dataI.Rows(0)("tipo").ToString = "BANCOS" Then
                    cboTipoPagoI.SelectedValue = "1"
                End If
            End If

        End If
    End Sub

    Private Sub txtIdCaja_TextChanged(sender As Object, e As EventArgs) Handles txtIdCaja.TextChanged, txtIdCaja2.TextChanged
        cargarPagosPredeterminados()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Decimal.Parse(lblDeuda.Text.Trim) > Decimal.Parse(lblDebe.Text.Trim) Then
            'verificar que el monto a canjear sea menor o igual a la diferencia del total con los canjes
            Dim dtVerNC, dtAC As New DataTable
            dtVerNC = objCrud.nCrudListarBD("select * from abono_pagos_ventas where id_venta='" & codVenta & "'", CadenaConexion)
            Dim diferencia As Decimal = 0
            If dtVerNC.Rows.Count > 0 Then
                dtAC = objCrud.nCrudListarBD("select sum(monto) as 'total' from abono_pagos_ventas where id_venta='" & codVenta & "'", CadenaConexion)
                diferencia = Decimal.Parse(lblMontoCompra.Text.Trim) - Decimal.Parse(dtAC.Rows(0)("total").ToString)
            Else
                diferencia = Decimal.Parse(lblMontoCompra.Text.Trim)
            End If
            If btnAgregar2.Enabled = True Then
                diferencia = diferencia - Decimal.Parse(txtMontoDet.Text.Trim)
            End If
            If Decimal.Parse(txtMonto.Text.Trim) > diferencia Then
                MsgBox("El monto sobrepasa a la diferencia permitida")
            Else
                agregarAbonos()
            End If
        End If
    End Sub
    Private Sub agregarAbonos()
        If cboTipoPago.Items.Count > 0 And txtIdCaja.Text.Trim <> "0" Then
            Dim dt1 As New DataTable
            With dt1
                .Columns.Add("num_cuenta")
                .Columns.Add("desc_cuenta")
                .Columns.Add("debe")
                .Columns.Add("haber")
                .Columns.Add("id_tipo_pago")
                .Columns.Add("documento_pago")
                .Columns.Add("descripcion_pago")
            End With
            Dim montoTotal As Decimal = 0
            montoTotal = IIf(txtMonto.Text.Trim.Length = 0, 0, txtMonto.Text.Trim)
            Dim calculoI As Decimal
            Dim dataIC As New DataTable

            'si se escogió nota de crédito
            If Integer.Parse(txtIdNC.Text.Trim) > 0 Then
                Dim dtNC As New DataTable
                dtNC = objCrud.nCrudListarBD("select * from asiento_nota_credito where tipo='VENTA' and id_nota_credito='" & txtIdNC.Text.Trim & "' order by id asc", CadenaConexion)
                Dim nc As New DataTable
                nc = objCrud.nCrudListarBD("select * from comprobante_nota_credito where id='" & txtIdNC.Text.Trim & "'", CadenaConexion)
                For n As Integer = 0 To dtNC.Rows.Count - 1
                    If dtNC.Rows(n)("cuenta").ToString.StartsWith("12") Then
                        dt1.Rows.Add(dtNC.Rows(n)("cuenta").ToString, obtenerDatosCuenta(dtNC.Rows(n)("cuenta").ToString), dtNC.Rows(n)("haber").ToString, dtNC.Rows(n)("debe").ToString, "0", "0", "N.C: " & nc.Rows(0)("serie").ToString & "-" & nc.Rows(0)("numero").ToString)
                        dt1.Rows.Add(txtCuentaP.Text.Trim, obtenerDatosCuenta(txtCuentaP.Text.Trim), "0.00", dtNC.Rows(n)("haber").ToString, "0", lblDocumento.Text, txtDescripcion.Text.Trim)
                        lblCaja.Text = "NOTA DE CRÉDITO"
                        txtCuenta.Text = dtNC.Rows(n)("cuenta").ToString
                        txtNumero.Text = nc.Rows(0)("serie").ToString & "-" & nc.Rows(0)("numero").ToString
                        dgvOperaciones.DataSource = dt1
                        'txtIdNC.Text = 0
                        Exit For
                    End If
                Next

            Else
                'para los tipos de impuestos
                If cboImpuestos.SelectedValue <> "0" Then
                    dataIC = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & cboImpuestos.SelectedValue.ToString & "'", CadenaConexion)
                    calculoI = Decimal.Round((Decimal.Parse(txtPorcentaje.Text.Trim) * Decimal.Parse(lblMontoCompra.Text.Trim) / 100), 2)
                    calculoImpuesto = calculoI
                End If
                If cboImpuestos.SelectedValue <> "0" And cboImpuestos.Text <> "PERCEPCIÓN" Then
                    montoDetraccion = calculoI
                    montoTotal = montoTotal - calculoI
                End If

                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                'detectar si se cancela con caja chica
                Dim idCaja As String = "1"
                idCaja = txtIdCaja.Text.Trim
                Dim dataCaja As New DataTable
                dataCaja = objCrud.nCrudListarBD("select * from caja_configuracion where id='" & idCaja & "'", CadenaConexion)

                If dataCaja.Rows(0)("tipo").ToString = "CHICA" Then
                    dt1.Rows.Add(txtCuentaP.Text.Trim, obtenerDatosCuenta(txtCuentaP.Text.Trim), "0.00", txtMonto.Text.Trim, "0", "0", "CANJE")
                    dt1.Rows.Add(dataCaja.Rows(0)("contra_cuenta").ToString, obtenerDatosCuenta(dataCaja.Rows(0)("contra_cuenta").ToString), txtMonto.Text.Trim, "0.00", "0", "0", "CANJE")

                    'cuentas de pago o abono
                    dt1.Rows.Add(dataCaja.Rows(0)("contra_cuenta").ToString, obtenerDatosCuenta(dataCaja.Rows(0)("contra_cuenta").ToString), "0.00", txtMonto.Text.Trim, "0", "0", "ABONO: " & dataCaja.Rows(0)("descripcion").ToString)
                    dt1.Rows.Add(dataCaja.Rows(0)("cuenta").ToString, obtenerDatosCuenta(dataCaja.Rows(0)("cuenta").ToString), txtMonto.Text.Trim, "0.00", "0", "0", "ABONO: " & dataCaja.Rows(0)("descripcion").ToString)
                    dgvOperaciones.DataSource = dt1
                ElseIf dataCaja.Rows(0)("tipo").ToString = "BANCOS" Then
                    dt1.Rows.Add(txtCuentaP.Text.Trim, obtenerDatosCuenta(txtCuentaP.Text.Trim), "0.00", txtMonto.Text.Trim, "0", lblDocumento.Text, txtDescripcion.Text.Trim)
                    dgvOperaciones.DataSource = dt1

                    Dim dt As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
                    Dim row As DataRow = dt.NewRow()
                    row.Item(0) = dataCaja.Rows(0)("cuenta").ToString
                    row.Item(1) = obtenerDatosCuenta(dataCaja.Rows(0)("cuenta").ToString)
                    row.Item(2) = txtMonto.Text.Trim
                    row.Item(3) = "0.00"
                    row.Item(4) = "0"
                    row.Item(5) = "0"
                    row.Item(6) = txtDescripcion.Text.Trim
                    dt.Rows.Add(row)
                Else
                    If dgvOperaciones.RowCount > 0 Then
                        Dim dt As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
                        Dim row As DataRow = dt.NewRow()
                        row.Item(0) = txtCuenta.Text.Trim
                        row.Item(1) = obtenerDatosCuenta(txtCuenta.Text.Trim)
                        row.Item(2) = txtMonto.Text.Trim
                        row.Item(3) = "0.00"
                        row.Item(4) = "0"
                        row.Item(5) = "0"
                        row.Item(6) = txtDescripcion.Text.Trim
                        dt.Rows.Add(row)
                    Else
                        dt1.Rows.Add(txtCuenta.Text.Trim, obtenerDatosCuenta(txtCuenta.Text.Trim), txtMonto.Text.Trim, "0.00", "0", lblDocumento.Text, txtDescripcion.Text.Trim)
                        dgvOperaciones.DataSource = dt1
                    End If

                    Dim dtA As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
                    Dim rowA As DataRow = dtA.NewRow()
                    rowA.Item(0) = txtCuentaP.Text.Trim
                    rowA.Item(1) = obtenerDatosCuenta(txtCuentaP.Text.Trim)
                    rowA.Item(2) = "0.00"
                    rowA.Item(3) = txtMonto.Text.Trim
                    rowA.Item(4) = "0"
                    rowA.Item(5) = lblDocumento.Text
                    rowA.Item(6) = txtDescripcion.Text.Trim
                    dtA.Rows.Add(rowA)
                End If
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


                'para los impuestos'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                If cboImpuestos.SelectedValue <> "0" And Not cboImpuestos.Text.Trim.StartsWith("PERCEPCI") Then
                    If dgvOperaciones.RowCount = 0 Then
                        'dt1.Rows.Add(IIf(cboImpuestos.Text = "DETRACCIÓN", dataIC.Rows(0)("cuenta").ToString, txtCuentaP.Text.Trim), obtenerDatosCuenta(IIf(cboImpuestos.Text = "DETRACCIÓN", dataIC.Rows(0)("cuenta").ToString, txtCuentaP.Text.Trim)), "0.00", IIf(cboImpuestos.Text <> "PERCEPCIÓN", calculoI, "0.00"), "0", "0", txtGlosaDet.Text.Trim)
                        'dt1.Rows.Add(IIf(cboImpuestos.Text = "DETRACCIÓN", txtCDetraccion.Text.Trim, dataIC.Rows(0)("cuenta").ToString), obtenerDatosCuenta(IIf(cboImpuestos.Text = "DETRACCIÓN", txtCDetraccion.Text.Trim, dataIC.Rows(0)("cuenta").ToString)), IIf(cboImpuestos.Text <> "PERCEPCIÓN", calculoI, "0.00"), "0.00", "0", "0", txtGlosaDet.Text.Trim)
                        dt1.Rows.Add(txtCuentaI.Text.Trim, obtenerDatosCuenta(txtCuentaI.Text.Trim), "0.00", calculoI, "0", "0", txtGlosaDet.Text.Trim)
                        dt1.Rows.Add(txtCDetraccion.Text.Trim, obtenerDatosCuenta(txtCDetraccion.Text.Trim), calculoI, "0", "0", txtGlosaDet.Text.Trim)

                        dgvOperaciones.DataSource = dt1
                    Else
                        ' '''''CUENTA 42 IMPUESTO
                        'Dim dt3 As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
                        'Dim row3 As DataRow = dt3.NewRow()
                        'row3.Item(0) = IIf(cboImpuestos.Text = "DETRACCIÓN", dataIC.Rows(0)("cuenta").ToString, txtCuentaP.Text.Trim)
                        'row3.Item(1) = obtenerDatosCuenta(IIf(cboImpuestos.Text = "DETRACCIÓN", dataIC.Rows(0)("cuenta").ToString, txtCuentaP.Text.Trim))
                        'row3.Item(2) = IIf(cboImpuestos.Text = "PERCEPCIÓN", calculoI, "0.00")
                        'row3.Item(3) = IIf(cboImpuestos.Text <> "PERCEPCIÓN", calculoI, "0.00")
                        'row3.Item(4) = "0"
                        'row3.Item(5) = "0"
                        'row3.Item(6) = txtGlosaDet.Text.Trim
                        'dt3.Rows.Add(row3)


                        'Dim dtI As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
                        'Dim row4 As DataRow = dtI.NewRow()
                        'row4.Item(0) = IIf(cboImpuestos.Text = "DETRACCIÓN", txtCDetraccion.Text.Trim, dataIC.Rows(0)("cuenta").ToString)
                        'row4.Item(1) = obtenerDatosCuenta(IIf(cboImpuestos.Text = "DETRACCIÓN", txtCDetraccion.Text.Trim, dataIC.Rows(0)("cuenta").ToString))
                        'row4.Item(2) = IIf(cboImpuestos.Text <> "PERCEPCIÓN", calculoI, "0.00")
                        'row4.Item(3) = IIf(cboImpuestos.Text = "PERCEPCIÓN", calculoI, "0.00")
                        'row4.Item(4) = "0"
                        'row4.Item(5) = "0"
                        'row4.Item(6) = txtGlosaDet.Text.Trim
                        'dtI.Rows.Add(row4)
                    End If
                End If

                If cboImpuestos.Text.Trim.StartsWith("RETEN") Then

                    Dim dtI As New DataTable
                    dtI = objCrud.nCrudListarBD("select * from retenciones where operacion='VENTA' and id_comprobante='" & codVenta & "'", CadenaConexion)
                    If dtI.Rows.Count = 0 Then
                        Dim dt As New DataTable
                        dt = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & cboImpuestos.SelectedValue.ToString & "'", CadenaConexion)
                        Dim dtCaja As New DataTable
                        dtCaja = objCrud.nCrudListarBD("select * from caja_configuracion where cuenta='" & dt.Rows(0)("cuenta").ToString & "'", CadenaConexion)
                        If dtCaja.Rows.Count > 0 Then
                            txtIdCaja2.Text = dtCaja.Rows(0)("id").ToString
                            txtBI.Text = 1
                        End If
                    End If
                End If

            End If
        Else
            MsgBox("Debe elegir una caja y un tipo de pago para agregar el abono")
        End If
        realizarSumasTotales()
        'txtBE.Text = "1"
    End Sub

    Private Sub btnAgregar2_Click(sender As Object, e As EventArgs) Handles btnAgregar2.Click
        If cboTipoPagoI.Items.Count > 0 And txtIdCaja2.Text.Trim <> "0" Then
            Dim dt1 As New DataTable
            With dt1
                .Columns.Add("num_cuenta")
                .Columns.Add("desc_cuenta")
                .Columns.Add("debe")
                .Columns.Add("haber")
                .Columns.Add("id_tipo_pago")
                .Columns.Add("documento_pago")
                .Columns.Add("descripcion_pago")
            End With
            'Dim montoTotal As Decimal = 0
            'montoTotal = IIf(txtMonto.Text.Trim.Length = 0, 0, txtMonto.Text.Trim)
            'Dim calculoI As Decimal
            Dim dataIC As New DataTable
            'para los tipos de impuestos
            If cboImpuestos.SelectedValue <> "0" Then
                dataIC = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & cboImpuestos.SelectedValue.ToString & "'", CadenaConexion)
                'calculoI = Decimal.Round((Decimal.Parse(dataIC.Rows(0)("porcentaje").ToString) * Decimal.Parse(lblMontoCompra.Text.Trim) / 100), 2)
                'calculoImpuesto = calculoI
            End If
            'If cboImpuestos.SelectedValue <> "0" And cboImpuestos.Text <> "PERCEPCIÓN" Then
            '    montoDetraccion = calculoI
            '    montoTotal = montoTotal - calculoI
            'End If

            Dim montoTotal As Decimal = 0
            montoTotal = IIf(txtMonto.Text.Trim.Length = 0, 0, txtMonto.Text.Trim)
            Dim calculoI As Decimal
            'para los tipos de impuestos
            If cboImpuestos.SelectedValue <> "0" Then
                calculoI = Decimal.Parse(txtMontoDet.Text.Trim) 'Decimal.Round((Decimal.Parse(dataIC.Rows(0)("porcentaje").ToString) * Decimal.Parse(lblMontoCompra.Text.Trim) / 100), 2)
                calculoImpuesto = calculoI
            End If
            If cboImpuestos.SelectedValue <> "0" And cboImpuestos.Text <> "PERCEPCIÓN" Then
                montoDetraccion = calculoI
                montoTotal = montoTotal - calculoI
            End If

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'detectar si se cancela con caja chica
            Dim idCaja As String = "1"
            idCaja = txtIdCaja.Text.Trim
            Dim dataCaja As New DataTable
            dataCaja = objCrud.nCrudListarBD("select * from caja_configuracion where id='" & idCaja & "'", CadenaConexion)


            'para los impuestos'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If cboImpuestos.SelectedValue <> "0" Then
                If dgvOperaciones.RowCount = 0 Then
                    'dt1.Rows.Add(IIf(cboImpuestos.Text = "DETRACCIÓN", dataIC.Rows(0)("cuenta").ToString, txtCuentaP.Text.Trim), obtenerDatosCuenta(IIf(cboImpuestos.Text = "DETRACCIÓN", dataIC.Rows(0)("cuenta").ToString, txtCuentaP.Text.Trim)), "0.00", IIf(cboImpuestos.Text <> "PERCEPCIÓN", calculoI, "0.00"), "0", "0", txtGlosaDet.Text.Trim)
                    'dt1.Rows.Add(IIf(cboImpuestos.Text = "DETRACCIÓN", txtCDetraccion.Text.Trim, dataIC.Rows(0)("cuenta").ToString), obtenerDatosCuenta(IIf(cboImpuestos.Text = "DETRACCIÓN", txtCDetraccion.Text.Trim, dataIC.Rows(0)("cuenta").ToString)), IIf(cboImpuestos.Text <> "PERCEPCIÓN", calculoI, "0.00"), "0.00", "0", "0", txtGlosaDet.Text.Trim)
                    dt1.Rows.Add(txtCuentaI.Text.Trim, obtenerDatosCuenta(txtCuentaI.Text.Trim), "0.00", calculoI, "0", "0", txtGlosaDet.Text.Trim)
                    dt1.Rows.Add(txtCDetraccion.Text.Trim, obtenerDatosCuenta(txtCDetraccion.Text.Trim), calculoI, "0.00", "0", "0", txtGlosaDet.Text.Trim)

                    dgvOperaciones.DataSource = dt1
                Else
                    '''''CUENTA 42 IMPUESTO
                    Dim dt3 As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
                    Dim row3 As DataRow = dt3.NewRow()
                    row3.Item(0) = IIf(cboImpuestos.Text = "DETRACCIÓN", dataIC.Rows(0)("cuenta").ToString, txtCuentaP.Text.Trim)
                    row3.Item(1) = obtenerDatosCuenta(IIf(cboImpuestos.Text = "DETRACCIÓN", dataIC.Rows(0)("cuenta").ToString, txtCuentaP.Text.Trim))
                    row3.Item(2) = IIf(cboImpuestos.Text = "PERCEPCIÓN", calculoI, "0.00")
                    row3.Item(3) = IIf(cboImpuestos.Text <> "PERCEPCIÓN", calculoI, "0.00")
                    row3.Item(4) = "0"
                    row3.Item(5) = "0"
                    row3.Item(6) = txtGlosaDet.Text.Trim
                    dt3.Rows.Add(row3)


                    Dim dtI As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
                    Dim row4 As DataRow = dtI.NewRow()
                    row4.Item(0) = IIf(cboImpuestos.Text = "DETRACCIÓN", txtCDetraccion.Text.Trim, dataIC.Rows(0)("cuenta").ToString)
                    row4.Item(1) = obtenerDatosCuenta(IIf(cboImpuestos.Text = "DETRACCIÓN", txtCDetraccion.Text.Trim, dataIC.Rows(0)("cuenta").ToString))
                    row4.Item(2) = IIf(cboImpuestos.Text <> "PERCEPCIÓN", calculoI, "0.00")
                    row4.Item(3) = IIf(cboImpuestos.Text = "PERCEPCIÓN", calculoI, "0.00")
                    row4.Item(4) = "0"
                    row4.Item(5) = "0"
                    row4.Item(6) = txtGlosaDet.Text.Trim
                    dtI.Rows.Add(row4)
                    'End If
                End If
        End If
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Else
            MsgBox("Debe elegir una caja y un tipo de pago para agregar el abono de la detracción")
        End If
        realizarSumasTotales()
        txtBI.Text = "1"
    End Sub

    Private Sub lblDebe_TextChanged(sender As Object, e As EventArgs) Handles lblDebe.TextChanged
        If dgvOperaciones.RowCount > 0 Then
            If Decimal.Parse(lblDebe.Text.Trim) = Decimal.Parse(lblDeuda.Text.Trim) Then
                'btnAgregar.Enabled = False
                'btnCaja.Enabled = False
            End If
        End If
    End Sub

    Private Sub txtMonto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.Leave
        txtMonto.Text = Format(CType(txtMonto.Text, Decimal), "###0.00")
    End Sub
    Private Sub txtMontoDet_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtMontoDet.Text = Format(CType(txtMontoDet.Text, Decimal), "###0.00")
    End Sub

    Private Sub dgvOperaciones_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvOperaciones.RowsRemoved
        On Error Resume Next
        realizarSumasTotales()
    End Sub
End Class