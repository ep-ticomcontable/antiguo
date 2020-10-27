Imports Negocio
Imports Entidades

Public Class frmNuevaVentaRapida
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
    Private Sub cargarTipoOperacion()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(1, "GRAVADA")
        data.Rows.Add(2, "NO GRAVADA")
        'data.Rows.Add(3, "EXONERADO")
        'data.Rows.Add(4, "INAFECTO")

        With cboOperacion
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
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
                data.Rows.Add(row.Item(0).ToString, "(" & row.Item(1).ToString & ") " & row.Item(2).ToString)
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
        CargarTipoDocumento()
        cargarTipoOperacion()
        cargarTipoCompra()
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

        Dim objCC As New nComprobanteCompra
        Dim entiCCompraAsiento, entiCCompra As New ComprobanteCompraEntity
        Dim entiCostoCompra As New CostoComprasEntity
        Dim dataIgv As New DataTable
        dataIgv = objCrud.nCrudListarBD("select * from  igv where estado=1", CadenaConexion)
        Dim preIGV As Decimal = 0
        Dim valIGV As Decimal = 0
        If cboOperacion.SelectedValue = "1" Then
            preIGV = txtTotalCompra.Text / (1 + (Decimal.Parse(dataIgv.Rows(0)("valor").ToString) / 100))
            valIGV = txtTotalCompra.Text - preIGV
        Else
            valIGV = 0
        End If


        Dim entiCVenta, entiCabVent As New ComprobanteVentaEntity
        Dim entiCostoVenta As New CostoVentasEntity
        Dim objAC As New nAsientosContables
        With entiCabVent
            .numero_cuo = objAC.nObtenerNumeroCUOBD(CadenaConexion)
            .numero_maquina = "-"
            .id_tipo_comprobante = cboTipoDocumento.SelectedValue.ToString
            .fec_emision = dtFechaEmision.Value
            .fec_pago = dtFechaPago.Value
            .tipo_venta = cboTipoCompra.SelectedValue.ToString
            .serie_comprobante = txtSerie.Text
            .numero_comprobante = txtNumero.Text
            .cod_dni = "6"
            .num_dni = txtRuc.Text.Trim
            .razon_social = txtRazonSocial.Text.Trim
            .glosa = txtGlosa.Text.Trim
            .valor_facturado = Decimal.Parse(txtTotalCompra.Text.Trim) - valIGV
            .base_imponible = Decimal.Parse(txtTotalCompra.Text.Trim) - valIGV
            .valor_exonerado = 0
            .valor_inafecto = 0
            .valor_isc = 0
            .valor_igv = valIGV
            .otros_base_imponible = 0
            .total = Decimal.Parse(txtTotalCompra.Text.Trim)
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

        Dim dataComVenta As New DataTable
        Dim dataCV As New DataTable
        dataCV = objCV.obtenerIdComprobanteVentaBD(CadenaConexion)
        With entiCVenta
            .id_asiento_venta = dataCV.Rows("0")("id").ToString
            .id_moneda = cboMoneda.SelectedValue
            .tipo_cambio = txtTipoCambio.Text.Trim
            .fec_emision = Date.Parse(dtFechaEmision.Value)
            .id_tipo_comprobante = cboTipoDocumento.SelectedValue.ToString
            .numero_comprobante = txtNumero.Text
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

            'If row.Cells("num_cuenta").Value.ToString.StartsWith("101") Then
            '    'REGISTRAR EN CAJA CHICA
            '    Dim entiCaja As New CajaEntity
            '    With entiCaja
            '        .id_comprobante = dataCV.Rows("0")("id")
            '        .comentarios = txtGlosa.Text.Trim
            '        .cuenta = row.Cells("num_cuenta").Value
            '        .glosa = txtGlosa.Text.Trim
            '        .monto = txtMonto.Text.Trim
            '        .debe = row.Cells("debe").Value
            '        .haber = row.Cells("haber").Value
            '        .fecha = dtFechaPago.Value
            '        .estado = "1"
            '        .id_usuario = CodigoUsuarioSession
            '    End With
            '    objCV.registrarCajaChica(entiCaja)
            '    If txtCuenta.Text.ToString.StartsWith("104") Then
            '        objCV.registrarCajaBancos(entiCaja)
            '    End If

            'End If
            'If row.Cells("num_cuenta").Value.ToString.StartsWith("1211") Then
            '    'REGISTRAR EN CAJA CHICA
            '    Dim entiCaja As New CajaEntity
            '    With entiCaja
            '        .id_comprobante = dataCV.Rows("0")("id").ToString
            '        .comentarios = txtGlosa.Text.Trim
            '        .cuenta = row.Cells("num_cuenta").Value.ToString
            '        .glosa = txtGlosa.Text.Trim
            '        .monto = txtMonto.Text.Trim
            '        .debe = row.Cells("debe").Value.ToString
            '        .haber = row.Cells("haber").Value.ToString
            '        .fecha = dtFechaPago.Value()
            '        .estado = "1"
            '        .id_usuario = CodigoUsuarioSession
            '    End With
            '    If txtCuenta.Text.ToString.StartsWith("104") Then
            '        objCV.registrarCajaBancos(entiCaja)
            '    Else
            '        objCV.registrarCajaChica(entiCaja)
            '    End If
            'End If
            'If row.Cells("num_cuenta").Value.ToString.StartsWith("104") Then
            '    'REGISTRAR EN CAJA BANCO
            '    Dim entiCaja As New CajaEntity
            '    With entiCaja
            '        .id_comprobante = dataCV.Rows("0")("id").ToString
            '        .comentarios = txtGlosa.Text.Trim
            '        .cuenta = row.Cells("num_cuenta").Value.ToString
            '        .glosa = txtGlosa.Text.Trim
            '        .monto = txtMonto.Text.Trim
            '        .debe = row.Cells("debe").Value.ToString
            '        .haber = row.Cells("haber").Value.ToString
            '        .fecha = dtFechaPago.Value()
            '        .estado = "1"
            '        .id_usuario = CodigoUsuarioSession
            '    End With
            '    objCV.registrarCajaBancos(entiCaja)
            'End If

            'If row.Cells("num_cuenta").Value.ToString.StartsWith("69") Then
            '    With entiCostoVenta
            '        .id_comprobante = dataCV.Rows("0")("id").ToString
            '        .id_cuenta = row.Cells("num_cuenta").Value.ToString
            '        .numero_cuo = entiCVenta.numero_cuo
            '        .debe = row.Cells("debe").Value
            '        .haber = "00.00"
            '    End With
            '    MsgBox("COSTO REGISTRADO: " & objCoVe.nRegistrarCostoDeVentasBD(entiCostoVenta, CadenaConexion))
            '    ' objCoVe.nRegistrarCostoDeVentas(entiCostoVenta)
            'ElseIf row.Cells("num_cuenta").Value.ToString.StartsWith("20") Then
            '    With entiCostoVenta
            '        .id_comprobante = dataCV.Rows("0")("id").ToString
            '        .id_cuenta = row.Cells("num_cuenta").Value.ToString
            '        .numero_cuo = entiCVenta.numero_cuo
            '        .debe = "00.00"
            '        .haber = row.Cells("haber").Value
            '    End With
            '    MsgBox("COSTO REGISTRADO: " & objCoVe.nRegistrarCostoDeVentasBD(entiCostoVenta, CadenaConexion))
            '    'objCoVe.nRegistrarCostoDeVentas(entiCostoVenta)
            'End If
        Next

        MsgBox("VENTA GRABADA CON EXITO")
        'frmListaComprobanteCompras.realizarConsulta()
        Me.Dispose()
    End Sub
    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        guardarDatos("P")
    End Sub
    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        guardarDatos("F")
    End Sub
    Private Sub cboTipoCompra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoCompra.SelectedIndexChanged
        If iCarga = 1 Then
            If cboTipoCompra.SelectedValue = "CONTADO" Then
                'GroupBox1.Enabled = False
            Else
                'GroupBox1.Enabled = True
            End If
        End If
        'If iCarga = 1 Then
        '    If cboTipoCompra.SelectedValue = "CONTADO" Then
        '        btnFinalizar.Text = "PAGAR"
        '        btnFinalizar.BackColor = Color.Green
        '    Else
        '        btnFinalizar.Text = "FINALIZAR"
        '        btnFinalizar.BackColor = Drawing.Color.FromArgb(6, 63, 114)
        '    End If
        '    'btnFinalizar.Text
        'End If
    End Sub

    Private Sub txtRuc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRuc.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtRuc.Text.Trim.Length >= 2 Then
                With frmEscogerCliente
                    .formInicio = "ventaP"
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
            If txtRazonSocial.Text.Trim.Length >= 2 Then
                With frmEscogerCliente
                    .formInicio = "ventaP"
                    .datoCliente = txtRazonSocial.Text.Trim
                    .txtDescripcion.Text = .datoCliente
                    .realizarBusqueda()
                    .ShowDialog()
                End With
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub frmNuevaCompraP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Insert Then
            agregarCuentaContable()
        End If
    End Sub
    Private Sub agregarCuentaContable()
        frmAgregarCuentasNuevo.formIni = "nuevaVentaP"
        frmAgregarCuentasNuevo.tipoOperacion = cboOperacion.SelectedValue.ToString
        frmAgregarCuentasNuevo.ShowDialog()
        frmAgregarCuentasNuevo.txtCuenta.Select()
    End Sub
   
End Class