Imports Negocio
Imports Entidades

Public Class frmNuevaCompraMercaderias
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
            data = objMon.nTipoDeCambioPorMonedaBD(cboMoneda.SelectedValue.ToString, CadenaConexion)
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
                    .formInicio = "compraMercaderia"
                    .cuentaInicio = txtCuenta.Text.Trim
                    .ShowDialog()
                End With
            End If
        End If
        If Asc(e.KeyChar) = 13 Then
            txtTotalCompra.Focus()
        End If
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
        realizarSumasTotales()
        With dtPagos.Columns
            .Add("num_cuenta")
            .Add("desc_cuenta")
            .Add("costo")
            .Add("base_imponible")
            .Add("igv")
            .Add("total")
        End With
        cboTipoDocumento.Focus()
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
                dtData.Rows.Add(cuenta, obtenerDatosCuenta(cuenta), monto, "0.00", txtGlosa.Text.Trim)
            End If
            If orden = "H" Then
                dtData.Rows.Add(cuenta, obtenerDatosCuenta(cuenta), "0.00", monto, txtGlosa.Text.Trim)
            End If
        Else
            Dim dtI As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
            Dim row As DataRow = dtI.NewRow()
            row.Item(0) = cuenta
            row.Item(1) = obtenerDatosCuenta(cuenta)
            row.Item(2) = IIf(orden = "D", monto, "0.00")
            row.Item(3) = IIf(orden = "H", monto, "0.00")
            row.Item(4) = txtGlosa.Text.Trim
            dtI.Rows.Add(row)
        End If

        dataAsientos.Merge(dtData)
        dgvOperaciones.DataSource = dataAsientos
        realizarSumasTotales()
    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString()
    End Function
    Private Sub guardarDatos(estadoComprobante As String)
        Dim dtTabla As New DataTable
        dtTabla = objCrud.nCrudListarBD("select * from cierre_procesos where proceso='COMPRA' and anio='" & dtFechaEmision.Value.Year & "' and mes='" & dtFechaEmision.Value.Month & "'", CadenaConexion)

        If dtTabla.Rows.Count > 0 Then
            MessageBox.Show("No se puede registrar el Comprobante de Compra con la fecha: '" & dtFechaEmision.Value.ToString("dd/MM/yyyy") & "', ya que incluye un mes el cual ya se ha realizado el Asiento de Centralización o Cierre." & vbCrLf & "Escoja una fecha distinta...", "Registro de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            dtFechaEmision.Focus()
        Else
            Dim objCC As New nComprobanteCompra
            Dim entiCCompraAsiento, entiCCompra As New ComprobanteCompraEntity
            Dim entiCostoCompra As New CostoComprasEntity
            Dim dataIgv As New DataTable
            dataIgv = objCrud.nCrudListarBD("select * from  igv where estado=1", CadenaConexion)
            Dim preIGV As Decimal = 0
            Dim valIGV As Decimal = 0
            If cboOperacion.SelectedValue = "1" Or cboOperacion.SelectedValue = "2" Then
                preIGV = txtTotalCompra.Text / (1 + (Decimal.Parse(dataIgv.Rows(0)("valor").ToString) / 100))
                valIGV = txtTotalCompra.Text - preIGV
            Else
                valIGV = 0
            End If

            With entiCCompra
                .tipo_compra = cboTipoCompra.SelectedValue.ToString
                .id_gravado = cboOperacion.SelectedValue.ToString
                .id_tipo_comprobante = cboTipoDocumento.SelectedValue.ToString
                .marca = IIf(cboTipoCompra.SelectedValue = "CREDITO", cboImpuesto.SelectedValue & "@" & IIf(cboImpuesto.Text = "0", "0", "0"), "0" & "@I")
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
                .detraccion = cboImpuesto.SelectedValue
                .fec_comp_origen = dtFechaEmision.Value.ToString("yyyy-MM-dd")
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

            ''REGISTRAR PERCEPCION, DETRACCION, RETENCION
            'If cboImpuesto.Text = "PERCEPCIÓN" Then
            '    Dim dataPorc As New DataTable
            '    dataPorc = objCrud.nCrudListarBD("select * from impuestos_sunat where tipo_comprobante='COMPRA' and id='" & cboImpuesto.SelectedValue.ToString & "'", CadenaConexion)
            '    Dim entiImpuesto As New ImpuestosSunatEntity
            '    For Each row As DataGridViewRow In dgvOperaciones.Rows
            '        If dataPorc.Rows(0)("cuenta").ToString = row.Cells("num_cuenta").Value.ToString Then
            '            With entiImpuesto
            '                .operacion = "COMPRA"
            '                .id_impuesto = cboImpuesto.SelectedValue
            '                .serie = txtSerieI.Text.Trim
            '                .numero = txtNumeroI.Text.Trim
            '                .id_tipo_comprobante = cboTipoDocumento.SelectedValue
            '                .tipo_comprobante = "0" 'cboTipoPercepcion.Text
            '                .total_comprobante = txtTotalCompra.Text.Trim
            '                .porcentaje = txtPorcPercep.Text.Trim
            '                .monto = Decimal.Parse(row.Cells("debe").Value.ToString) + Decimal.Parse(row.Cells("haber").Value.ToString)
            '                .estado = "1"
            '            End With
            '            Dim objImp As New nImpuestosSunat
            '            Dim rptaImp As String
            '            rptaImp = objImp.nRegistrarImpuestosBD(entiImpuesto, CadenaConexion)
            '        End If
            '    Next
            'End If

            Dim entiAbono As New AbonoComprasEntity
            Dim objAbono As New nAbonosPagos
            Dim dataCC As New DataTable
            dataCC = objCrud.nCrudListarBD("select * from comprobante_compra order by id desc", CadenaConexion)
            With entiCCompraAsiento
                .id_comprobante = dataCC.Rows(0)("id").ToString
                .numero_cuo = objCC.nObtenerCUO_CompraBD(CadenaConexion)
                .tipo_compra = cboTipoCompra.SelectedValue.ToString
                .numero_maquina = "-"
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
                .numero_detraccion = txtSerieI.Text.Trim & "-" & txtNumeroI.Text.Trim
                .tipo_tasa_detraccion = cboImpuesto.SelectedValue.ToString
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
                entiCCompraAsiento.serie = txtSerieI.Text.Trim
                entiCCompraAsiento.numero = txtNumeroI.Text.Trim
                entiCCompraAsiento.operacion = "0"

                'MsgBox("REGISTRANDO ASIENTO COMPROBANTE DE COMPRA: " & objCC.nRegistrarAsientoComprobanteCompra(entiCCompraAsiento))
                Dim rptaRACC As String = objCC.nRegistrarAsientoComprobanteCompraBD(entiCCompraAsiento, CadenaConexion)
                If rptaRACC <> "ok" Then
                    MsgBox("Error en el registro en el asiento del comprobante: " & rptaRACC)
                End If
            Next

            'REGISTRAR PERCEPCION
            If cboImpuesto.Text.Trim.StartsWith("PERCEPCI") Then
                Dim calculoI As Decimal = 0
                Dim TOTAL As Decimal = 0
                TOTAL = IIf(txtTotalCompra.Text.Trim.Length = 0, 0, txtTotalCompra.Text.Trim)
                'monto percepcion
                If cboImpuesto.Text.Trim.StartsWith("PERCEPCI") Then
                    TOTAL = Decimal.Parse(TOTAL * 100 / (100 + txtPorcPercep.Text.Trim))
                End If
                calculoI = Decimal.Round((Decimal.Parse(txtPorcPercep.Text.Trim) * TOTAL / 100), 2)
                Dim entiPer As New RetencionEntity
                With entiPer
                    .operacion = "COMPRA"
                    .serie = txtSerieI.Text.Trim
                    .numero = txtNumeroI.Text.Trim
                    .glosa = cboImpuesto.Text.Trim & " REGISTRADA"
                    .fec_reg = Date.Parse(dtFechaEmision.Value)
                    .id_comprobante = dataCC.Rows(0)("id").ToString
                    .total = txtTotalCompra.Text.Trim
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
            If cboImpuesto.Text.StartsWith("DETRACCI") Then
                'REGISTRANDO DETRACCION POR PAGAR
                Dim calculoI As Decimal = 0
                Dim TOTAL As Decimal = 0
                'monto percepcion
                TOTAL = Decimal.Parse(TOTAL * 100 / (100 + txtPorcPercep.Text.Trim))
                calculoI = Decimal.Round((Decimal.Parse(txtPorcPercep.Text.Trim) * TOTAL / 100), 2)
                Dim entiRet As New RetencionEntity
                With entiRet
                    .operacion = "COMPRA"
                    .serie = txtSerieI.Text.Trim
                    .numero = txtNumeroI.Text.Trim
                    .glosa = "DETRACCIÓN POR PAGAR"
                    .fec_reg = Date.Parse(dtFechaEmision.Value)
                    .id_comprobante = dataCC.Rows(0)("id").ToString
                    .total = txtTotalCompra.Text.Trim
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
            frmListaComprobanteCompras.Refresh()
            Me.Dispose()
        Else
            MsgBox("Ingrese RUC/Razón Social del Proveedor")
            txtRuc.Focus()
        End If
        End If
    End Sub
    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        'frmNuevaCompraP.Show()
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
        If verificarPartidaDoble() = True Then
            'verificar serie a registrar
            Dim dtSer As New DataTable
            dtSer = objCrud.nCrudListarBD("select * from comprobante_compra where serie_comprobante='" & txtSerie.Text.Trim & "' and numero_comprobante='" & txtNumero.Text.Trim & "'", CadenaConexion)
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
                frmNuevaCompraPagoMercaderia.Show()
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
                txtSerieI.Enabled = True
            Else
                btnFinalizar.Text = "FINALIZAR"
                btnFinalizar.BackColor = Drawing.Color.FromArgb(6, 63, 114)
                txtSerieI.Enabled = False
            End If
        End If
    End Sub
    Private Sub buscarProveedor()
        If txtRuc.Focused = True Then
            With frmEscogerProveedor
                .formInicio = "compraM"
                .datoProveedor = txtRuc.Text.Trim
                .txtDescripcion.Text = .datoProveedor
                .realizarBusqueda()
                .ShowDialog()
            End With
        ElseIf txtRazonSocial.Focused = True Then
            With frmEscogerProveedor
                .formInicio = "compraM"
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
        If Asc(e.KeyChar) = 13 Then
            txtRazonSocial.Focus()
        End If
    End Sub
    Private Sub txtRazonSocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRazonSocial.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            buscarProveedor()
        End If
        If Asc(e.KeyChar) = 13 Then
            cboTipoCompra.Focus()
        End If
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        'MsgBox()
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
        Dim data As New DataTable
        data = objCrud.nCrudListarBD("select * from cuentas_tipo_operacion where id_tipo_operacion='" & idTipoOperacion & "'", CadenaConexion)
        Dim total As Decimal = 0
        Dim igv As Decimal = 0
        Dim monto As Decimal = 0
        Dim calculoI As Decimal = 0
        total = IIf(txtTotalCompra.Text.Trim.Length = 0, 0, txtTotalCompra.Text.Trim)
        'monto percepcion
        If cboImpuesto.Text.Trim.StartsWith("PERCEPCI") Then
            total = Decimal.Parse(total * 100 / (100 + txtPorcPercep.Text.Trim))
        End If

        Dim dataIgv As New DataTable
        dataIgv = objCrud.nCrudListarBD("select * from igv where estado=1", CadenaConexion)
        monto = IIf(cboOperacion.SelectedValue.ToString = "1", (total / (1 + ((dataIgv.Rows(0)("valor").ToString) / 100))), "0.00")
        monto = Decimal.Round(Decimal.Parse(Format(monto, "###0.00")), 2)
        Dim valIgv As Decimal = 0
        Dim cuentas As New DataTable
        With cuentas.Columns
            .Add("num_cuenta")
            .Add("desc_cuenta")
            .Add("debe")
            .Add("haber")
            .Add("descripcion")
        End With

        'AGREGANDO CUENTA 60
        valIgv = Decimal.Round(Decimal.Parse(total - monto), 2)
        cuentas.Rows.Add(txtCuenta.Text.Trim, obtenerDatosCuenta(txtCuenta.Text.Trim), monto, "0.00", txtGlosa.Text.Trim)
        cuentas.Rows.Add(dataIgv.Rows(0)("cuenta").ToString, obtenerDatosCuenta(dataIgv.Rows(0)("cuenta").ToString), valIgv, "0.00", txtGlosa.Text.Trim)

        'para los impuestos'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim dataIC As New DataTable
        If cboImpuesto.SelectedValue <> "0" Then
            If cboImpuesto.Text.Trim.StartsWith("PERCEPCI") Then
                dataIC = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & cboImpuesto.SelectedValue.ToString & "'", CadenaConexion)
                calculoI = Decimal.Round((Decimal.Parse(txtPorcPercep.Text.Trim) * total / 100), 2)
                cuentas.Rows.Add(dataIC.Rows(0)("cuenta").ToString, obtenerDatosCuenta(dataIC.Rows(0)("cuenta").ToString), calculoI, "0.00", IIf(txtSerieI.Enabled = True, cboImpuesto.Text.Trim & ": " & txtSerieI.Text & "-" & txtNumeroI.Text, "SUJETO A " & cboImpuesto.Text.Trim))
                'total = total - calculoI
                Dim totalMP As Decimal = 0
                totalMP = Decimal.Parse(txtTotalCompra.Text.Trim)
                cuentas.Rows.Add(data.Rows(0)("num_cuenta").ToString, obtenerDatosCuenta(data.Rows(0)("num_cuenta").ToString), "0.00", totalMP, txtGlosa.Text.Trim)
            Else
                dataIC = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & cboImpuesto.SelectedValue.ToString & "'", CadenaConexion)
                calculoI = Decimal.Round((Decimal.Parse(txtPorcPercep.Text.Trim) * total / 100), 2)
                cuentas.Rows.Add(dataIC.Rows(0)("cuenta").ToString, obtenerDatosCuenta(dataIC.Rows(0)("cuenta").ToString), "0.00", calculoI, IIf(txtSerieI.Enabled = True, cboImpuesto.Text.Trim & ": " & txtSerieI.Text & "-" & txtNumeroI.Text, "SUJETO A " & cboImpuesto.Text.Trim))
                total = total - calculoI

                cuentas.Rows.Add(data.Rows(0)("num_cuenta").ToString, obtenerDatosCuenta(data.Rows(0)("num_cuenta").ToString), "0.00", total, txtGlosa.Text.Trim)
            End If
        Else
            cuentas.Rows.Add(data.Rows(0)("num_cuenta").ToString, obtenerDatosCuenta(data.Rows(0)("num_cuenta").ToString), "0.00", total, txtGlosa.Text.Trim)
        End If

        'AGREGANDO CUENTAS DE TRANSFERENCIA
        Dim dtTra As New DataTable
        dtTra = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & txtCuenta.Text.Trim & "'", CadenaConexion)
        If dtTra.Rows.Count > 0 Then
            cuentas.Rows.Add(dtTra.Rows(0)("cuenta_debe").ToString, obtenerDatosCuenta(dtTra.Rows(0)("cuenta_debe").ToString), monto, "0.00", "VARIACIÓN DE EXISTENCIAS")
            cuentas.Rows.Add(dtTra.Rows(0)("cuenta_haber").ToString, obtenerDatosCuenta(dtTra.Rows(0)("cuenta_haber").ToString), "0.00", monto, "VARIACIÓN DE EXISTENCIAS")
        End If
        '''''''''''''''''''''''''''''''''''

        dgvOperaciones.DataSource = cuentas
        realizarSumasTotales()
    End Sub
    Private Sub cboImpuesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboImpuesto.SelectedIndexChanged
        If iCarga = 1 Then
            Dim dataPorc As New DataTable
            dataPorc = objCrud.nCrudListarBD("select * from impuestos_sunat where tipo_comprobante='COMPRA' and  id='" & cboImpuesto.SelectedValue.ToString & "'", CadenaConexion)
            If dataPorc.Rows.Count > 0 Then
                txtPorcPercep.Text = dataPorc.Rows(0)("porcentaje").ToString
            Else
                txtPorcPercep.Text = "0"
            End If
            txtSerieI.Enabled = True
            txtNumeroI.Enabled = True
        End If
    End Sub
    Private Sub cboTipoDocumento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboTipoDocumento.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtSerie.Focus()
        End If
    End Sub
    Private Sub txtSerie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerie.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtNumero.Focus()
        End If
    End Sub
    Private Sub txtNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtRuc.Focus()
        End If
    End Sub
    Private Sub cboTipoCompra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboTipoCompra.KeyPress
        If Asc(e.KeyChar) = 13 Then
            dtFechaEmision.Focus()
        End If
    End Sub
    Private Sub dtFechaEmision_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtFechaEmision.KeyPress
        If Asc(e.KeyChar) = 13 Then
            dtFechaPago.Focus()
        End If
    End Sub
    Private Sub dtFechaPago_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtFechaPago.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cboMoneda.Focus()
        End If
    End Sub
    Private Sub cboMoneda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboMoneda.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtTipoCambio.Focus()
        End If
    End Sub
    Private Sub txtTipoCambio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTipoCambio.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cboOperacion.Focus()
        End If
    End Sub
    Private Sub cboOperacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboOperacion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtGlosa.Focus()
        End If
    End Sub
    Private Sub txtGlosa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGlosa.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtCuenta.Focus()
        End If
    End Sub
    Private Sub txtTotalCompra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotalCompra.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cboImpuesto.Focus()
        End If
    End Sub
    Private Sub cboImpuesto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboImpuesto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtPorcPercep.Focus()
        End If
    End Sub
    Private Sub txtPorcPercep_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPorcPercep.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtSerieI.Focus()
        End If
    End Sub
    Private Sub txtNumeroImpuesto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerieI.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnAgregarCuenta.Focus()
        End If
    End Sub

    Private Sub txtTotalCompra_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalCompra.Leave
        txtTotalCompra.Text = Format(CType(txtTotalCompra.Text, Decimal), "###0.00")
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