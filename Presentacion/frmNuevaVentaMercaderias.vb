Imports Negocio
Imports Entidades

Public Class frmNuevaVentaMercaderias
    Dim objCrud As New nCrud
    Dim objCA As New nCuentaAsiento
    Dim objMon As New nMonedas
    Dim iCarga As Integer = 0
    Dim dtPagos As New DataTable
    Dim objTDA As New nTipoDocumentoAsiento
    Dim idTipoOperacion As Integer = 1
    'Dim CodigoLocalSession As Integer = 1
    'Dim CodigoEmpresaSession As Integer = 1
    Dim dataAsientos As New DataTable
    Dim mIgv As Decimal = 0
    Dim mTotal As Decimal = 0
    Dim montoDetraccion As Decimal = 0
    Public idCentroCosto As String = 0

    Private Sub cargarTipoVenta()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add("CREDITO", "CRÉDITO")
        data.Rows.Add("CONTADO", "CONTADO")
        With cboTipoVenta
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub
    Private Sub cargarImpuestosSunatCredito()
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
            With cboImpuesto
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Impuestos")
        End Try
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
                data.Rows.Add(row.Item(0).ToString, row.Item(2).ToString.ToUpper)
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
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListarBD("select * from gravaciones where estado=1 order by id asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboOperacion
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Impuestos")
        End Try
    End Sub
    Private Sub cargarTipoDeCambio()
        If iCarga = 1 Then
            Dim data As New DataTable
            data = objMon.nTipoDeCambioPorMoneda(cboMoneda.SelectedValue.ToString)
            'lblTipoDeCambio.Text = "Tipo de cambio: S/. " & data.Rows(0)("valor").ToString
            If data.Rows.Count > 0 Then
                txtTipoCambio.Text = data.Rows(0)("venta").ToString
            Else
                txtTipoCambio.Text = "1.00"
            End If
        End If
    End Sub
    Private Sub cargarMonedas()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListarBD("select id,codigo,descripcion from tipo_moneda where estado=1 order by codigo asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
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
    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtCuenta.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "ventaMercaderia"
                    .cuentaInicio = txtCuenta.Text.Trim
                    .ShowDialog()
                End With
            End If
        End If
        If Asc(e.KeyChar) = 13 Then
            txtTotalVenta.Focus()
        End If
    End Sub
    Private Sub cargarSerieNumero()
        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select isnull(max(numero_comprobante)+1,1) as numero from comprobante_venta", CadenaConexion)
        txtNumero.Text = dt.Rows(0)("numero").ToString
        txtNumero.Text = txtNumero.Text.ToString.PadLeft(4, "0")
    End Sub
    Private Sub frmNuevaVentaMercaderias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvOperaciones.RowTemplate.Height = 25
        cebrasDatagrid(dgvOperaciones, Drawing.Color.White, Drawing.Color.FromArgb(182, 205, 226))
        cargarImpuestosSunatCredito()
        CargarTipoDocumento()
        cargarTipoOperacion()
        cargarTipoVenta()
        cargarMonedas()
        iCarga = 1
        cargarTipoDeCambio()
        realizarSumasTotales()
        With dtPagos.Columns
            .Add("num_cuenta")
            .Add("desc_cuenta")
            .Add("costo")
            .Add("base_imponible")
            .Add("igv")
            .Add("total")
        End With
        cargarSerieNumero()
    End Sub
    Private Sub btnAgregarCuenta_Click(sender As Object, e As EventArgs) Handles btnAgregarCuenta.Click
        agregarCuentaContable()
    End Sub
    Private Sub dgvOperaciones_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvOperaciones.RowsRemoved
        On Error Resume Next
        If iCarga = 1 Then
            realizarSumasTotales()
        End If
    End Sub
    Private Sub dgvProductos_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOperaciones.CellValueChanged
        On Error Resume Next
        If iCarga = 1 Then
            realizarSumasTotales()
        End If
    End Sub

    Private Sub cboMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMoneda.SelectedIndexChanged
        cargarTipoDeCambio()
    End Sub

    Public Sub adicionarCuentas(cuenta As String, monto As Decimal, orden As String)
        Dim dtData As New DataTable

        With dtData.Columns
            .Add("num_cuenta")
            .Add("desc_cuenta")
            .Add("debe")
            .Add("haber")
            .Add("descripcion")
        End With

        If dgvOperaciones.RowCount = 0 Then
            If orden = "D" Then
                dtData.Rows.Add(cuenta, obtenerDatosCuenta(cuenta), monto, "0.00", "-")
            End If

            If orden = "H" Then
                dtData.Rows.Add(cuenta, obtenerDatosCuenta(cuenta), "0.00", monto, "-")
            End If
        Else
            Dim dtI As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
            Dim row As DataRow = dtI.NewRow()
            row.Item(0) = cuenta
            row.Item(1) = obtenerDatosCuenta(cuenta)
            row.Item(2) = IIf(orden = "D", monto, "0.00")
            row.Item(3) = IIf(orden = "H", monto, "0.00")
            row.Item(4) = "-"
            dtI.Rows.Add(row)
        End If

        dataAsientos.Merge(dtData)
        dgvOperaciones.DataSource = dataAsientos
        realizarSumasTotales()
    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function
    Private Sub guardarDatos(estadoComprobante As String)
        Dim dataIgv As New DataTable
        dataIgv = objCrud.nCrudListarBD("select * from  igv where estado=1", CadenaConexion)
        Dim preIGV As Decimal = 0
        Dim valIGV As Decimal = 0
        If cboOperacion.SelectedValue = "1" Or cboOperacion.SelectedValue = "2" Then
            preIGV = txtTotalVenta.Text / (1 + (Decimal.Parse(dataIgv.Rows(0)("valor").ToString) / 100))
            valIGV = txtTotalVenta.Text - preIGV
        Else
            valIGV = 0
        End If

        'REGISTRAR PERCEPCION, DETRACCION, RETENCION
        'If cboPercepcion.Text = "PERCEPCIÓN" Then
        '    Dim dataPorc As New DataTable
        '    dataPorc = objCrud.nCrudListarBD("select * from impuestos_sunat where tipo_comprobante='VENTA' and id='" & cboPercepcion.SelectedValue.ToString & "'")
        '    Dim entiImpuesto As New ImpuestosSunatEntity
        '    For Each row As DataGridViewRow In dgvOperaciones.Rows
        '        If dataPorc.Rows(0)("cuenta").ToString = row.Cells("num_cuenta").Value.ToString Then
        '            With entiImpuesto
        '                .operacion = "VENTA"
        '                .id_impuesto = "0"
        '                .serie = "0"
        '                .numero = "0"
        '                .id_tipo_comprobante = cboTipoDocumento.SelectedValue
        '                .tipo_comprobante = "0"
        '                .total_comprobante = txtTotalVenta.Text.Trim
        '                .porcentaje = "0"
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
        Dim objAC As New nAsientosContables
        With entiCabVent
            .numero_cuo = objAC.nObtenerNumeroCUOBD(CadenaConexion)
            .numero_maquina = "-"
            .id_tipo_comprobante = cboTipoDocumento.SelectedValue.ToString
            .fec_emision = dtFechaEmision.Value
            .fec_pago = dtFechaPago.Value
            .tipo_venta = cboTipoVenta.SelectedValue.ToString
            .id_gravado = cboOperacion.SelectedValue
            .marca = IIf(cboTipoVenta.SelectedValue = "CREDITO", cboImpuesto.SelectedValue & "@" & IIf(cboImpuesto.Text = "SIN AFECTO", "0", "0"), "0" & "@I")
            .centro = idCentroCosto
            .serie_comprobante = txtSerie.Text
            .numero_comprobante = txtNumero.Text
            .cod_dni = "6"
            .num_dni = txtRuc.Text.Trim
            .razon_social = txtRazonSocial.Text.Trim
            .glosa = txtGlosa.Text.Trim
            .id_impuesto = cboImpuesto.SelectedValue.ToString
            .valor_facturado = Decimal.Parse(txtTotalVenta.Text.Trim) - valIGV
            .base_imponible = Decimal.Parse(txtTotalVenta.Text.Trim) - valIGV
            .valor_exonerado = 0
            .valor_inafecto = 0
            .valor_isc = 0
            .valor_igv = valIGV
            .otros_base_imponible = 0
            .valor_descuento = "0.00"
            .total = Decimal.Parse(txtTotalVenta.Text.Trim)
            .id_moneda = cboMoneda.SelectedValue.ToString
            .tipo_cambio = txtTipoCambio.Text.Trim
            .fec_comp_origen = dtFechaEmision.Value
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

        Dim dataCV As New DataTable
        dataCV = objCV.obtenerIdComprobanteVentaBD(CadenaConexion)
        With entiCVenta
            .id_asiento_venta = dataCV.Rows("0")("id").ToString
            .id_moneda = cboMoneda.SelectedValue
            .tipo_cambio = txtTipoCambio.Text.Trim
            .fec_emision = Date.Parse(dtFechaEmision.Value)
            .id_tipo_comprobante = cboTipoDocumento.SelectedValue.ToString
            .numero_comprobante = txtNumero.Text
            .tipo_tasa_detraccion = cboImpuesto.SelectedValue.ToString
            .tasa_detraccion = txtPorcPercep.Text.Trim
            .fecha_detraccion = Date.Parse(dtFechaEmision.Value)
            .numero_detraccion = txtSerieI.Text.Trim & "-" & txtNumeroI.Text.Trim
            .valor_detraccion = Decimal.Parse(txtTotalVenta.Text.Trim) * Decimal.Parse(txtPorcPercep.Text.Trim) / 100
        End With

        For Each row As DataGridViewRow In dgvOperaciones.Rows
            entiCVenta.cuenta = row.Cells("num_cuenta").Value
            entiCVenta.debe = row.Cells("debe").Value
            entiCVenta.haber = row.Cells("haber").Value
            entiCVenta.glosa = txtGlosa.Text.Trim

            Dim rptaRAV As String = objCV.nRegistrarDetalleAsientoVentaBD(entiCVenta, CadenaConexion)
            If rptaRAV <> "ok" Then
                MsgBox("Error en el registro del comprobante: " & rptaRCC)
            End If
        Next

        'REGISTRAR DETRACCION
        If cboImpuesto.Text.StartsWith("DETRACCI") Then
            'REGISTRANDO DETRACCION POR PAGAR
            Dim calculoI As Decimal = 0
            Dim TOTAL As Decimal = txtTotalVenta.Text.Trim
            'monto percepcion
            calculoI = Decimal.Parse(TOTAL * (Decimal.Parse(txtPorcPercep.Text.Trim) / 100))
            'calculoI = Decimal.Round((Decimal.Parse(txtPorcPercep.Text.Trim) * TOTAL / 100), 2)
            Dim entiRet As New RetencionEntity
            With entiRet
                .operacion = "VENTA"
                .serie = txtSerieI.Text.Trim
                .numero = txtNumeroI.Text.Trim
                .glosa = "DETRACCIÓN POR PAGAR"
                .fec_reg = Date.Parse(dtFechaEmision.Value)
                .id_comprobante = dataCV.Rows(0)("id").ToString
                .total = txtTotalVenta.Text.Trim
                .monto = Decimal.Parse(calculoI)
                .tipo = "PENDIENTE"
                .estado = "1"
            End With
            Dim objDet As New nDetraccion
            Dim rptaDet As String = ""
            rptaDet = objDet.registrarDetracciones(entiRet, CadenaConexion)
            If rptaDet <> "ok" Then
                MsgBox("Error al registrar Detracción: " & vbCrLf & rptaDet)
            End If
        End If

        'REGISTRAR PERCEPCION
        If cboImpuesto.Text.Trim.StartsWith("PERCEPCI") Then
            Dim calculoI As Decimal = 0
            Dim TOTAL As Decimal = 0
            TOTAL = IIf(txtTotalVenta.Text.Trim.Length = 0, 0, txtTotalVenta.Text.Trim)
            'monto percepcion
            If cboImpuesto.Text.Trim.StartsWith("PERCEPCI") Then
                TOTAL = Decimal.Parse(TOTAL * 100 / (100 + txtPorcPercep.Text.Trim))
            End If
            calculoI = Decimal.Round((Decimal.Parse(txtPorcPercep.Text.Trim) * TOTAL / 100), 2)
            Dim entiPer As New RetencionEntity
            With entiPer
                .operacion = "VENTA"
                .serie = txtSerieI.Text.Trim
                .numero = txtNumeroI.Text.Trim
                .glosa = cboImpuesto.Text.Trim & " REGISTRADA"
                .fec_reg = Date.Parse(dtFechaEmision.Value)
                .id_comprobante = dataCV.Rows("0")("id").ToString
                .total = txtTotalVenta.Text.Trim
                .monto = calculoI
                .tipo = "INTERNO"
                .estado = "1"
            End With
            Dim objPer As New nRetenciones
            Dim rptaPer As String = ""
            rptaPer = objPer.registrarPercepciones(entiPer, CadenaConexion)
            If rptaPer <> "ok" Then
                MsgBox("Error al registrar Percepción: " & vbCrLf & rptaPer)
            End If
        End If

        MsgBox("VENTA GRABADA CON EXITO")
        frmListaComprobanteVentas.realizarConsulta()
        Me.Dispose()
    End Sub
    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        guardarDatos("P")
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
    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        'verificar serie a registrar
        If verificarPartidaDoble() = True Then
            Dim dtSer As New DataTable
            dtSer = objCrud.nCrudListarBD("select * from comprobante_venta where serie_comprobante='" & txtSerie.Text.Trim & "' and numero_comprobante='" & txtNumero.Text.Trim & "'", CadenaConexion)
            If dtSer.Rows.Count = 0 Then
                procesarBoton()
            Else
                MsgBox("Ingrese otro número y serie para el comprobante")
            End If
        End If
    End Sub

    Private Sub procesarBoton()
        If validarEntradas() = True Then
            If btnFinalizar.Text = "FINALIZAR" Then
                guardarDatos("F")
            ElseIf btnFinalizar.Text = "PAGAR" Then
                frmNuevaVentaMercaderiaPago.Show()
            End If
        End If
    End Sub

    Private Function validarEntradas() As Boolean
        Dim rpta As Boolean = False
        If cboTipoDocumento.SelectedValue.ToString = "0" Then
            rpta = False
            MsgBox("Seleccione un tipo de documento")
            cboTipoDocumento.Focus()
        ElseIf txtSerie.Text.Trim.Length = 0 Then
            rpta = False
            MsgBox("Ingrese la Serie del comprobante")
            txtSerie.Focus()
        ElseIf txtNumero.Text.Trim.Length = 0 Then
            rpta = False
            MsgBox("Ingrese el Número del comprobante")
            txtNumero.Focus()
        ElseIf txtRuc.Text.Trim.Length = 0 Then
            rpta = False
            MsgBox("Ingrese el RUC/DNI del Cliente")
            txtRuc.Focus()
        ElseIf txtRazonSocial.Text.Trim.Length = 0 Then
            rpta = False
            MsgBox("Ingrese la Datos del Cliente")
            txtRazonSocial.Focus()
        ElseIf txtGlosa.Text.Trim.Length = 0 Then
            rpta = False
            MsgBox("Ingrese la Glosa para el registro del comprobante")
            txtGlosa.Focus()
        ElseIf Decimal.Parse(txtTotalVenta.Text.Trim) = 0 Then
            rpta = False
            MsgBox("Ingrese el Total de la Venta")
            txtTotalVenta.Focus()
        ElseIf dgvOperaciones.RowCount = 0 Then
            rpta = False
            MsgBox("Ingrese cuentas contables")
            agregarCuentaContable()
        Else
            rpta = True
        End If
        Return rpta
    End Function
    Private Sub cboTipoCompra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoVenta.SelectedIndexChanged
        If iCarga = 1 Then
            If cboTipoVenta.SelectedValue = "CONTADO" Then
                btnFinalizar.Text = "PAGAR"
                btnFinalizar.BackColor = Color.Green
            Else
                btnFinalizar.Text = "FINALIZAR"
                btnFinalizar.BackColor = Drawing.Color.FromArgb(6, 63, 114)
            End If
        End If
    End Sub

    Private Sub txtRuc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRuc.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtRuc.Text.Trim.Length >= 2 Then
                With frmEscogerCliente
                    .formInicio = "ventaRapidaP"
                    .datoCliente = txtRuc.Text.Trim
                    .txtDescripcion.Text = .datoCliente
                    .realizarBusqueda()
                    .ShowDialog()
                End With
            End If
        End If
    End Sub

    Private Sub txtRazonSocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRazonSocial.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            buscarProveedor()
        End If
    End Sub

    Private Sub buscarProveedor()
        If txtRuc.Focused = True Then
            With frmEscogerCliente
                .formInicio = "ventaM"
                .datoCliente = txtRuc.Text.Trim
                .txtDescripcion.Text = .datoCliente
                .realizarBusqueda()
                .ShowDialog()
            End With
        ElseIf txtRazonSocial.Focused = True Then
            With frmEscogerCliente
                .formInicio = "ventaM"
                .datoCliente = txtRazonSocial.Text.Trim
                .txtDescripcion.Text = .datoCliente
                .realizarBusqueda()
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    'Private Sub cboPercepcion_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    If iCarga = 1 Then
    '        Dim dataPorc As New DataTable
    '        dataPorc = objCrud.nCrudListarBD("select * from impuestos_sunat where tipo_comprobante='VENTA' and  id='" & cboPercepcion.SelectedValue.ToString & "'")
    '        If dataPorc.Rows.Count > 0 Then
    '            txtPorcPercep.Text = dataPorc.Rows(0)("porcentaje").ToString
    '            If cboPercepcion.Text = "PERCEPCIÓN" Then
    '                cboTipoPercepcion.Enabled = True
    '                Dim data As New DataTable
    '                data.Columns.Add("Codigo")
    '                data.Columns.Add("Descripcion")
    '                data.Rows.Add("I", "INTERNA")
    '                data.Rows.Add("E", "EXTERNA")
    '                With cboTipoPercepcion
    '                    .DataSource = data
    '                    .ValueMember = "Codigo"
    '                    .DisplayMember = "Descripcion"
    '                End With
    '            Else
    '                cboTipoPercepcion.Enabled = False
    '            End If
    '        Else
    '            txtPorcPercep.Text = "0"
    '        End If
    '    End If
    'End Sub

    Private Sub frmNuevaCompraP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Insert Then
            If txtRuc.Focused = True Or txtRazonSocial.Focused = True Then
                buscarProveedor()
            Else
                agregarCuentaContable()
            End If
        ElseIf e.KeyCode = Keys.End Then
            procesarBoton()
        End If
    End Sub

    Private Sub agregarCuentaContable()
        Dim data As New DataTable
        data = objCrud.nCrudListarBD("select * from cuentas_tipo_operacion where id_tipo_operacion='" & idTipoOperacion & "'", CadenaConexion)
        Dim total As Decimal = 0
        Dim igv As Decimal = 0
        Dim monto As Decimal = 0
        Dim calculoI As Decimal = 0
        total = IIf(txtTotalVenta.Text.Trim.Length = 0, 0, txtTotalVenta.Text.Trim)
        Dim dataIgv As New DataTable
        dataIgv = objCrud.nCrudListarBD("select * from igv where estado=1", CadenaConexion)

        Dim cuentas As New DataTable
        With cuentas.Columns
            .Add("num_cuenta")
            .Add("desc_cuenta")
            .Add("debe")
            .Add("haber")
            .Add("descripcion")
        End With
        Dim preTotal As Decimal = 0
        'AGREGANDO CUENTA 12
        Dim mIgv As Decimal = 0
        Dim dataIC As New DataTable
        If cboImpuesto.SelectedValue <> "0" Then
            'recalculando TOTAL
            If cboImpuesto.Text.Trim.StartsWith("PERCEP") Then
                preTotal = Decimal.Parse(total * 100 / (100 + txtPorcPercep.Text.Trim))
            Else
                preTotal = total
            End If
            monto = IIf(cboOperacion.SelectedValue.ToString = "1", (Format(preTotal / (1 + ((dataIgv.Rows(0)("valor").ToString) / 100)), "#,##0.00")), "0.00")
            mIgv = Decimal.Round(Decimal.Parse(preTotal - monto), 2)
            dataIC = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & cboImpuesto.SelectedValue.ToString & "'", CadenaConexion)
            calculoI = Decimal.Round((Decimal.Parse(txtPorcPercep.Text.Trim) * preTotal / 100), 2)
            'cuentas.Rows.Add(dataIC.Rows(0)("cuenta").ToString, obtenerDatosCuenta(dataIC.Rows(0)("cuenta").ToString), calculoI, "0.00", IIf(txtNumeroImpuesto.Enabled = True, "N°: " & txtNumeroImpuesto.Text, "SUJETO A DETRACCIÓN"))
            'recalculando IGV
            If cboImpuesto.Text.Trim.StartsWith("RETENCI") Then
                mIgv = mIgv - calculoI
            End If
        Else
            preTotal = total
            monto = IIf(cboOperacion.SelectedValue.ToString = "1", (Format(preTotal / (1 + ((dataIgv.Rows(0)("valor").ToString) / 100)), "#,##0.00")), "0.00")
            mIgv = Decimal.Round(Decimal.Parse(preTotal - monto), 2)
        End If
        'If cboImpuesto.Text.Trim.StartsWith("DETRACC") And cboImpuesto.SelectedValue > 0 Then
        '    Dim totSDet As Decimal = 0
        '    totSDet = total - calculoI
        '    cuentas.Rows.Add(data.Rows(0)("num_cuenta").ToString, obtenerDatosCuenta(data.Rows(0)("num_cuenta").ToString), totSDet, "0.00", txtGlosa.Text.Trim)
        '    cuentas.Rows.Add(dataIC.Rows(0)("cuenta").ToString, obtenerDatosCuenta(dataIC.Rows(0)("cuenta").ToString), calculoI, "0.00", IIf(txtSerieI.Enabled = True, cboImpuesto.Text.Trim & ": " & txtSerieI.Text & "-" & txtNumeroI.Text, "SUJETO A " & cboImpuesto.Text.Trim))
        'Else
        cuentas.Rows.Add(data.Rows(0)("num_cuenta").ToString, obtenerDatosCuenta(data.Rows(0)("num_cuenta").ToString), total, "0.00", txtGlosa.Text.Trim)
        'End If
        cuentas.Rows.Add(dataIgv.Rows(0)("cuenta").ToString, obtenerDatosCuenta(dataIgv.Rows(0)("cuenta").ToString), "0.00", mIgv, txtGlosa.Text.Trim)
        If Not cboImpuesto.Text.Trim.StartsWith("DETRACC") And cboImpuesto.SelectedValue > 0 Then
            cuentas.Rows.Add(dataIC.Rows(0)("cuenta").ToString, obtenerDatosCuenta(dataIC.Rows(0)("cuenta").ToString), "0.00", calculoI, IIf(txtSerieI.Enabled = True, cboImpuesto.Text.Trim, "SUJETO A " & cboImpuesto.Text.Trim))
        End If
        cuentas.Rows.Add(txtCuenta.Text.Trim, obtenerDatosCuenta(txtCuenta.Text.Trim), "0.00", monto, txtGlosa.Text.Trim)

        ''para los impuestos'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'cuentas.Rows.Add("691", obtenerDatosCuenta("691"), (monto - (monto * 0.3)), "0.00", txtGlosa.Text.Trim)
        'cuentas.Rows.Add("201", obtenerDatosCuenta("201"), "0.00", (monto - (monto * 0.3)), txtGlosa.Text.Trim)


        dgvOperaciones.DataSource = cuentas
        realizarSumasTotales()
    End Sub

    'Private Sub cboTipoPercepcion_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    If iCarga = 1 Then
    '        If cboPercepcion.Text = "PERCEPCIÓN" Then
    '            If cboTipoPercepcion.SelectedValue.ToString = "E" Then
    '                cboSerieImpuesto.Enabled = True
    '                txtNumeroImpuesto.Enabled = True
    '                Dim data As New DataTable
    '                data.Columns.Add("Codigo")
    '                data.Columns.Add("Descripcion")
    '                Dim data2 As DataTable
    '                Try
    '                    data2 = objCrud.nCrudListarBD("select * from empresa_agente where id_empresa='" & CodigoEmpresaSession & "' and id_impuesto_sunat='" & cboPercepcion.SelectedValue.ToString & "' and estado=1", CadenaConexion)
    '                    For Each row As DataRow In data2.Rows
    '                        data.Rows.Add(row.Item("id").ToString, row.Item("serie").ToString)
    '                    Next
    '                    With cboSerieImpuesto
    '                        .DataSource = data
    '                        .ValueMember = "Codigo"
    '                        .DisplayMember = "Descripcion"
    '                    End With
    '                    data2.Dispose()
    '                Catch ex As Exception
    '                    MsgBox("No se pudo cargar la lista de Impuestos")
    '                End Try
    '            Else
    '                cboSerieImpuesto.Enabled = False
    '                txtNumeroImpuesto.Enabled = False
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub cboImpuesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboImpuesto.SelectedIndexChanged
        If iCarga = 1 Then
            Dim dataPorc As New DataTable
            dataPorc = objCrud.nCrudListarBD("select * from impuestos_sunat where tipo_comprobante='VENTA' and  id='" & cboImpuesto.SelectedValue.ToString & "'", CadenaConexion)
            If dataPorc.Rows.Count > 0 Then
                txtPorcPercep.Text = dataPorc.Rows(0)("porcentaje").ToString
                txtSerieI.Enabled = True
                txtNumeroI.Enabled = True
                cboTipoVenta.SelectedValue = "CREDITO"
            Else
                txtSerieI.Enabled = False
                txtNumeroI.Enabled = False
                txtPorcPercep.Text = "0"
            End If
        End If
    End Sub
    Private Sub txtTotalVenta_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalVenta.Leave
        txtTotalVenta.Text = Format(CType(txtTotalVenta.Text, Decimal), "###0.00")
    End Sub

    Private Sub txtSerie_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.Leave
        txtSerie.Text = txtSerie.Text.ToString.PadLeft(4, "0")
    End Sub
    Private Sub txtNumero_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.Leave
        txtNumero.Text = txtNumero.Text.ToString.PadLeft(4, "0")
    End Sub

    Private Sub txtSerieI_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerieI.Leave
        txtSerieI.Text = txtSerieI.Text.ToString.PadLeft(4, "0")
    End Sub
    Private Sub txtNumeroI_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroI.Leave
        txtNumeroI.Text = txtNumeroI.Text.ToString.PadLeft(4, "0")
    End Sub
End Class