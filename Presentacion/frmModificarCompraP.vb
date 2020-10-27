Imports Negocio
Imports Entidades

Public Class frmModificarCompraP
    Dim objCrud As New nCrud
    Dim objCA As New nCuentaAsiento
    Dim objMon As New nMonedas
    Dim iCarga As Integer = 0
    Dim dtPagos As New DataTable
    Dim objTDA As New nTipoDocumentoAsiento
    Dim idTipoOperacion As Integer = 2
    'Dim CodigoLocalSession As Integer = 1
    'Dim CodigoEmpresaSession As Integer = 1
    Dim dataAsientos As New DataTable
    Dim mIgv As Decimal = 0
    Dim mTotal As Decimal = 0
    Dim montoDetraccion As Decimal = 0
    Public idCentroCosto As String = 0
    Public idCompra As Integer = 0

    Public Sub cargarDatosCompra()
        Dim data As New DataTable
        data = objCrud.nCrudListarBD("select * from comprobante_compra where id='" & idCompra & "'", CadenaConexion)

        With data
            'CARGAR DATOS
            cboTipoDocumento.SelectedValue = .Rows(0)("id_tipo_comprobante").ToString
            txtSerie.Text = .Rows(0)("serie_comprobante").ToString
            txtNumero.Text = .Rows(0)("numero_comprobante").ToString
            cboOperacion.SelectedValue = .Rows(0)("id_gravado").ToString
            cboTipoCompra.SelectedValue = .Rows(0)("tipo_compra").ToString
            txtRuc.Text = .Rows(0)("num_dni").ToString
            txtRazonSocial.Text = .Rows(0)("razon_social").ToString
            cboPercepcion.SelectedValue = "0"
            cboTipoPercepcion.SelectedValue = "0"
            txtPorcPercep.Text = "0"
            txtGlosa.Text = .Rows(0)("glosa").ToString
            txtTotalCompra.Text = .Rows(0)("total").ToString
            cboSerieImpuesto.SelectedValue = "0"
            txtNumeroImpuesto.Text = "0"
            dtFechaEmision.Value = Date.Parse(.Rows(0)("fec_emision").ToString)
            dtFechaPago.Value = Date.Parse(.Rows(0)("fec_pago").ToString)

            Dim asientos As New DataTable
            asientos = objCrud.nCrudListarBD("select * from asientos_comprobante_compra where id_comprobante_compra='" & idCompra & "'", CadenaConexion)

            Dim dtData As New DataTable
            With dtData.Columns
                .Add("num_cuenta")
                .Add("desc_cuenta")
                .Add("debe")
                .Add("haber")
                .Add("descripcion")
            End With

            For Each row As DataRow In asientos.Rows
                With row
                    dtData.Rows.Add(.Item("cuenta"), obtenerDatosCuenta(.Item("cuenta")), .Item("debe"), .Item("haber"), txtGlosa.Text.Trim)
                End With
            Next

            'cargar impuestos asignados
            Dim aMarca As String()
            aMarca = .Rows(0)("marca").ToString.Split("@")
            If Integer.Parse(aMarca(0).ToString) > 0 Then
                cboPercepcion.SelectedValue = aMarca(0).ToString
                Dim serNumImp As String()
                serNumImp = asientos.Rows(0)("numero_detraccion").ToString.Split("-")
                If serNumImp.Count > 1 Then
                    cboSerieImpuesto.Text = serNumImp(0)
                    txtNumeroImpuesto.Text = serNumImp(1)
                End If
            End If

            dgvOperaciones.DataSource = dtData
            realizarSumasTotales()
        End With
    End Sub
    Private Sub cargarTipoCompra()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add("CREDITO", "CRÉDITO")
        data.Rows.Add("CONTADO", "CONTADO")
        With cboTipoCompra
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
            data2 = objCrud.nCrudListarBD("select * from impuestos_sunat where tipo_comprobante='COMPRA' and estado=1", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(2).ToString)
            Next
            With cboPercepcion
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
    Private Sub frmNuevaCompraP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvOperaciones.RowTemplate.Height = 25
        cebrasDatagrid(dgvOperaciones, Drawing.Color.White, Drawing.Color.FromArgb(182, 205, 226))
        cargarImpuestosSunatCredito()
        CargarTipoDocumento()
        cargarTipoOperacion()
        cargarTipoCompra()
        cargarMonedas()
        iCarga = 1
        cargarTipoDeCambio()
        cargarDatosCompra()
        realizarSumasTotales()
        With dtPagos.Columns
            .Add("num_cuenta")
            .Add("desc_cuenta")
            .Add("costo")
            .Add("base_imponible")
            .Add("igv")
            '.Add("isc")
            '.Add("otros_impuestos")
            '.Add("descuento")
            .Add("total")
        End With
    End Sub
    Private Sub btnAgregarCuenta_Click(sender As Object, e As EventArgs) Handles btnAgregarCuenta.Click
        agregarCuentaContable()
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
        Dim dtI As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
        Dim row As DataRow = dtI.NewRow()
        row.Item(0) = cuenta
        row.Item(1) = obtenerDatosCuenta(cuenta)
        row.Item(2) = IIf(orden = "D", monto, "0.00")
        row.Item(3) = IIf(orden = "H", monto, "0.00")
        row.Item(4) = txtGlosa.Text.Trim
        dtI.Rows.Add(row)
        realizarSumasTotales()
    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function
    Private Sub guardarDatos(estadoComprobante As String)
        Dim objCC As New nComprobanteCompra
        Dim entiCCompraAsiento, entiCCompra As New ComprobanteCompraEntity
        Dim entiCostoCompra As New CostoComprasEntity
        Dim dataIgv As New DataTable
        dataIgv = objCrud.nCrudListarBD("select * from  igv where estado=1", CadenaConexion)
        Dim preIGV As Decimal = 0
        Dim valIGV As Decimal = 0
        If cboOperacion.SelectedValue.ToString = "1" Or cboOperacion.SelectedValue.ToString = "2" Then
            preIGV = txtTotalCompra.Text / (1 + (Decimal.Parse(dataIgv.Rows(0)("valor").ToString) / 100))
            valIGV = txtTotalCompra.Text - preIGV
        Else
            valIGV = 0
        End If

        With entiCCompra
            .id = idCompra
            .tipo_compra = cboTipoCompra.SelectedValue.ToString
            .id_gravado = cboOperacion.SelectedValue.ToString
            .id_tipo_comprobante = cboTipoDocumento.SelectedValue.ToString
            .marca = IIf(cboTipoCompra.SelectedValue = "CREDITO", cboPercepcion.SelectedValue & "@" & IIf(cboPercepcion.Text = "0", "0", "0"), "0" & "@I")
            .centro = idCentroCosto
            .estado_comprobante = estadoComprobante
            .fec_emision = dtFechaEmision.Value.ToString("yyyy-MM-dd")
            .fec_pago = dtFechaPago.Value.ToString("yyyy-MM-dd")
            .serie_comprobante = txtSerie.Text
            .numero_comprobante = txtNumero.Text
            .cod_dni = "6"
            .num_dni = txtRuc.Text.Trim
            .razon_social = txtRazonSocial.Text.Trim
            .valor_facturado = Decimal.Parse(txtTotalCompra.Text.Trim) - valIGV
            .glosa = txtGlosa.Text
            .id_moneda = cboMoneda.SelectedValue.ToString
            .valor_igv = valIGV
            .total = txtTotalCompra.Text.Trim
            .tipo_cambio = txtTipoCambio.Text.Trim
            .detraccion = cboPercepcion.SelectedValue.ToString
            .fec_comp_origen = dtFechaEmision.Value.ToString("yyyy-MM-dd")
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

        'Registrando asientos de compras
        Dim entiAbono As New AbonoComprasEntity
        Dim objAbono As New nAbonosPagos
        Dim dataCC As New DataTable
        dataCC = objCrud.nCrudListarBD("select * from comprobante_compra order by id desc", CadenaConexion)
        With entiCCompraAsiento
            .id_comprobante = dataCC.Rows(0)("id").ToString
            .numero_cuo = objCC.nObtenerCUO_CompraBD(CadenaConexion)
            .tipo_compra = cboTipoCompra.SelectedValue.ToString
            If estadoComprobante = "F" Then
                .numero_maquina = "-"
            Else
                .numero_maquina = "NO"
            End If
            .id_tipo_comprobante = cboTipoDocumento.SelectedValue.ToString
            .fec_emision = Date.Parse(dtFechaEmision.Value())
            .fec_pago = dtFechaPago.Value.ToString("yyyy-MM-dd")
            .serie_comprobante = txtSerie.Text
            .numero_comprobante = txtNumero.Text
            .cod_dni = "6"
            .num_dni = txtRuc.Text.Trim
            .razon_social = txtRazonSocial.Text.Trim
            .valor_facturado = Decimal.Parse(txtTotalCompra.Text.Trim) - valIGV
            .base_imponible = Decimal.Parse(txtTotalCompra.Text.Trim) - valIGV
            .valor_exonerado = 0
            .valor_inafecto = 0
            .valor_isc = 0
            .valor_igv = valIGV
            .otros_base_imponible = 0
            .total = txtTotalCompra.Text.Trim
            .tipo_cambio = txtTipoCambio.Text.Trim
            .fec_comp_origen = Date.Parse(dtFechaEmision.Value.ToString("yyyy-MM-dd"))
            .serie_dua = "0"
            .numero_dua = "0"
            .anio_dua = dtFechaEmision.Value.ToString("yyyy-MM-dd")
            '.numero_detraccion = IIf(cboImpuestos.Text = "DETRACCIÓN", txtNumeroImpuesto.Text.Trim, "0")
            .numero_detraccion = txtNumeroImpuesto.Text.Trim & "-" & txtNumeroImpuesto.Text.Trim
            .tipo_tasa_detraccion = cboPercepcion.SelectedValue.ToString
            '.tasa_detraccion = IIf(cboImpuestos.Text = "DETRACCIÓN", txtPorcentaje.Text.Trim, "0")
            .tasa_detraccion = txtPorcPercep.Text.Trim
            '.valor_detraccion = IIf(cboImpuestos.Text = "DETRACCIÓN", montoDetraccion, "0")
            .valor_detraccion = Decimal.Round((Decimal.Parse(txtTotalCompra.Text.Trim) * Decimal.Parse(txtPorcPercep.Text.Trim)), 2) / 100
            '.fecha_detraccion = dtFecImpuesto.Value.ToString("yyyy-MM-dd")
            .fecha_detraccion = dtFechaEmision.Value.ToString("yyyy-MM-dd")
            .estado = 1
        End With

        For Each row As DataGridViewRow In dgvOperaciones.Rows
            entiCCompraAsiento.tip_comp_origen = "-"
            entiCCompraAsiento.serie_comp_origen = txtSerie.Text.Trim
            entiCCompraAsiento.numero_comp_origen = txtNumero.Text.Trim
            entiCCompraAsiento.cuenta = row.Cells("num_cuenta").Value
            entiCCompraAsiento.glosa = txtGlosa.Text.Trim
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

        If txtRazonSocial.Text.Trim.Length > 0 And txtRuc.Text.Trim.Length >= 8 Then
            'VERIFICAR DATOS DEL PROVEEDOR
            Dim campos As String
            Dim valores As String
            campos = "dni_ruc@nombre@direccion@estado"
            Dim ruc As String = txtRuc.Text.Trim
            valores = ruc & "@" & txtRazonSocial.Text.ToString & "@" & txtDireccion.Text.ToString & "@1"
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
            MsgBox("COMPRA GRABADA CON EXITO")
            frmListaComprobanteCompras.realizarConsulta()
            Me.Close()
        Else
            MsgBox("Ingrese RUC/Razón Social del Proveedor")
            txtRuc.Focus()
        End If
    End Sub
    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        guardarDatos("P")
    End Sub
    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        procesarBoton()
    End Sub
    Private Sub procesarBoton()
        If validarEntradas() = True Then
            If btnFinalizar.Text = "FINALIZAR" Then
                guardarDatos("F")
            ElseIf btnFinalizar.Text = "PAGAR" Then
                frmNuevaCompraPago.procesoCompra = "modificacion"
                frmNuevaCompraPago.Show()
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
            MsgBox("Ingrese el RUC de la empresa")
            txtRuc.Focus()
        ElseIf txtRazonSocial.Text.Trim.Length = 0 Then
            rpta = False
            MsgBox("Ingrese la Razón Social de la empresa")
            txtRazonSocial.Focus()
        ElseIf txtGlosa.Text.Trim.Length = 0 Then
            rpta = False
            MsgBox("Ingrese la Glosa para el registro del comprobante")
            txtGlosa.Focus()
        ElseIf Decimal.Parse(txtTotalCompra.Text.Trim) = 0 Then
            rpta = False
            MsgBox("Ingrese el Total de la Compra")
            txtTotalCompra.Focus()
        ElseIf dgvOperaciones.RowCount = 0 Then
            rpta = False
            MsgBox("Ingrese cuentas contables")
            agregarCuentaContable()
        Else
            rpta = True
        End If
        Return rpta
    End Function
    Private Sub cboTipoCompra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoCompra.SelectedIndexChanged
        'If iCarga = 1 Then
        '    If cboTipoCompra.SelectedValue = "CONTADO" Then
        '        GroupBox1.Enabled = False
        '    Else
        '        GroupBox1.Enabled = True
        '    End If
        'End If

        If iCarga = 1 Then
            If cboTipoCompra.SelectedValue = "CONTADO" Then
                btnFinalizar.Text = "PAGAR"
                btnFinalizar.BackColor = Color.Green
            Else
                btnFinalizar.Text = "FINALIZAR"
                btnFinalizar.BackColor = Drawing.Color.FromArgb(6, 63, 114)
            End If
        End If
    End Sub
    Private Sub buscarProveedor()
        If txtRuc.Focused = True Then
            With frmEscogerProveedor
                .formInicio = "McompraP"
                .datoProveedor = txtRuc.Text.Trim
                .txtDescripcion.Text = .datoProveedor
                .realizarBusqueda()
                .ShowDialog()
            End With
        ElseIf txtRazonSocial.Focused = True Then
            With frmEscogerProveedor
                .formInicio = "McompraP"
                .datoProveedor = txtRazonSocial.Text.Trim
                .txtDescripcion.Text = .datoProveedor
                .realizarBusqueda()
                .ShowDialog()
            End With
        End If
    End Sub
    Private Sub txtRuc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRuc.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            buscarProveedor()
        End If
    End Sub

    Private Sub txtRazonSocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRazonSocial.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            buscarProveedor()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub cboPercepcion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPercepcion.SelectedIndexChanged
        If iCarga = 1 Then
            Dim dataPorc As New DataTable
            dataPorc = objCrud.nCrudListarBD("select * from impuestos_sunat where tipo_comprobante='COMPRA' and  id='" & cboPercepcion.SelectedValue.ToString & "'", CadenaConexion)
            If dataPorc.Rows.Count > 0 Then
                txtPorcPercep.Text = dataPorc.Rows(0)("porcentaje").ToString
                If cboPercepcion.Text = "PERCEPCIÓN" Then
                    cboTipoPercepcion.Enabled = True
                    Dim data As New DataTable
                    data.Columns.Add("Codigo")
                    data.Columns.Add("Descripcion")
                    data.Rows.Add("I", "INTERNA")
                    data.Rows.Add("E", "EXTERNA")
                    With cboTipoPercepcion
                        .DataSource = data
                        .ValueMember = "Codigo"
                        .DisplayMember = "Descripcion"
                    End With
                Else
                    cboTipoPercepcion.Enabled = False
                End If
            Else
                txtPorcPercep.Text = "0"
            End If
        End If
    End Sub

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
        frmAgregarCuentasNuevo.formIni = "modificarCompraP"
        frmAgregarCuentasNuevo.tipoOperacion = cboOperacion.SelectedValue.ToString
        frmAgregarCuentasNuevo.ShowDialog()
        frmAgregarCuentasNuevo.txtCuenta.Select()
    End Sub

    Private Sub cboTipoPercepcion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoPercepcion.SelectedIndexChanged
        If iCarga = 1 Then
            If cboPercepcion.Text = "PERCEPCIÓN" Then
                If cboTipoPercepcion.SelectedValue.ToString = "E" Then
                    cboSerieImpuesto.Enabled = True
                    txtNumeroImpuesto.Enabled = True
                    Dim data As New DataTable
                    data.Columns.Add("Codigo")
                    data.Columns.Add("Descripcion")
                    Dim data2 As DataTable
                    Try
                        data2 = objCrud.nCrudListarBD("select * from empresa_agente where id_empresa='" & CodigoEmpresaSession & "' and id_impuesto_sunat='" & cboPercepcion.SelectedValue.ToString & "' and estado=1", CadenaConexion)
                        For Each row As DataRow In data2.Rows
                            data.Rows.Add(row.Item("id").ToString, row.Item("serie").ToString)
                        Next
                        With cboSerieImpuesto
                            .DataSource = data
                            .ValueMember = "Codigo"
                            .DisplayMember = "Descripcion"
                        End With
                        data2.Dispose()
                    Catch ex As Exception
                        MsgBox("No se pudo cargar la lista de Impuestos")
                    End Try
                Else
                    cboSerieImpuesto.Enabled = False
                    txtNumeroImpuesto.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        cargarDatosCompra()
    End Sub

    Private Sub dgvOperaciones_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvOperaciones.RowsRemoved
        If iCarga = 1 Then
            realizarSumasTotales()
        End If
    End Sub
End Class