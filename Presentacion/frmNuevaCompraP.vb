Imports Negocio
Imports Entidades

Public Class frmNuevaCompraP
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
            data2 = objCrud.nCrudListarBD("select id, descripcion, codigo from tipo_moneda where estado=1 order by descripcion asc", CadenaConexion)
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
    Private Sub dgvOperaciones_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvOperaciones.RowsRemoved
        On Error Resume Next
        If iCarga = 1 Then
            realizarSumasTotales()
            calcularTotalComprobante()
        End If
    End Sub
    Private Sub dgvProductos_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOperaciones.CellValueChanged
        On Error Resume Next
        If iCarga = 1 Then
            realizarSumasTotales()
            calcularTotalComprobante()
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
            .Add("id_centro")
        End With
        If dgvOperaciones.RowCount = 0 Then
            If orden = "D" Then
                dtData.Rows.Add(cuenta, obtenerDatosCuenta(cuenta), monto, "0.00", txtGlosa.Text.Trim, txtCentro.Text.Trim)
            End If
            If orden = "H" Then
                dtData.Rows.Add(cuenta, obtenerDatosCuenta(cuenta), "0.00", monto, txtGlosa.Text.Trim, txtCentro.Text.Trim)
            End If
        Else
            Dim dtI As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
            Dim row As DataRow = dtI.NewRow()
            row.Item(0) = cuenta
            row.Item(1) = obtenerDatosCuenta(cuenta)
            row.Item(2) = IIf(orden = "D", monto, "0.00")
            row.Item(3) = IIf(orden = "H", monto, "0.00")
            row.Item(4) = txtGlosa.Text.Trim
            row.Item(5) = txtCentro.Text.Trim
            dtI.Rows.Add(row)
        End If

        dataAsientos.Merge(dtData)
        dgvOperaciones.DataSource = dataAsientos
        realizarSumasTotales()
        calcularTotalComprobante()

    End Sub
    Private Sub calcularTotalComprobante()
        If dgvOperaciones.RowCount > 0 Then
            Dim total As Decimal = 0
            For Each row As DataGridViewRow In dgvOperaciones.Rows
                If Not row.Cells("num_cuenta").Value.ToString.StartsWith("60") And Not row.Cells("num_cuenta").Value.ToString.StartsWith("40") And Not row.Cells("num_cuenta").Value.ToString.StartsWith("20") And Not row.Cells("num_cuenta").Value.ToString.StartsWith("61") And Not row.Cells("num_cuenta").Value.ToString.StartsWith("94") And Not row.Cells("num_cuenta").Value.ToString.StartsWith("79") Then
                    total = total + Decimal.Parse(row.Cells("haber").Value.ToString)
                End If
            Next
            txtTotal2.Text = total
        End If
    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
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

            'Capturar Id Centro - Buscado en la grilla
            For Each row As DataGridViewRow In dgvOperaciones.Rows
                If Integer.Parse(row.Cells("id_centro").Value.ToString) > 0 Then
                    idCentroCosto = Integer.Parse(row.Cells("id_centro").Value.ToString)
                    Exit For
                End If
            Next


            With entiCCompra
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
                .detraccion = cboPercepcion.SelectedValue
                .fec_comp_origen = dtFechaEmision.Value.ToString("yyyy-MM-dd")
                .tip_comp_origen = ""
                .serie_comp_origen = ""
                .numero_comp_origen = ""
                .estado = 1
                .id_usuario = CodigoUsuarioSession
                .codEmpresa = CodigoEmpresaSession
            End With
            Dim rptaRCC As String = objCC.nRegistrarComprobanteCompraBD(entiCCompra, CadenaConexion)
            If rptaRCC <> "ok" Then
                MsgBox("Error en el registro del comprobante: " & rptaRCC)
            End If

            'REGISTRAR PERCEPCION, DETRACCION, RETENCION
            If cboPercepcion.Text = "PERCEPCIÓN" Then
                Dim dataPorc As New DataTable
                dataPorc = objCrud.nCrudListarBD("select * from impuestos_sunat where tipo_comprobante='COMPRA' and id='" & cboPercepcion.SelectedValue.ToString & "'", CadenaConexion)
                Dim entiImpuesto As New ImpuestosSunatEntity
                For Each row As DataGridViewRow In dgvOperaciones.Rows
                    If dataPorc.Rows(0)("cuenta").ToString = row.Cells("num_cuenta").Value.ToString Then
                        With entiImpuesto
                            .operacion = "COMPRA"
                            .id_impuesto = cboPercepcion.SelectedValue
                            .serie = cboSerieImpuesto.Text.Trim
                            .numero = txtNumeroImpuesto.Text.Trim
                            .id_tipo_comprobante = cboTipoDocumento.SelectedValue
                            .tipo_comprobante = cboTipoPercepcion.Text
                            .total_comprobante = txtTotalCompra.Text.Trim
                            .porcentaje = txtPorcPercep.Text.Trim
                            .monto = Decimal.Parse(row.Cells("debe").Value.ToString) + Decimal.Parse(row.Cells("haber").Value.ToString)
                            .estado = "1"
                        End With
                        Dim objImp As New nImpuestosSunat
                        Dim rptaImp As String
                        rptaImp = objImp.nRegistrarImpuestosBD(entiImpuesto, CadenaConexion)
                    End If
                Next
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
                .tasa_detraccion = Decimal.Parse(txtPorcPercep.Text.Trim)
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

            'Se registran estos asientos cuando solo es tipo F=Finalizado
            If estadoComprobante = "F" Then
                'registrando asiento de transferencias
                Dim dtTra As New DataTable
                dtTra = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & dgvOperaciones.Rows(0).Cells("num_cuenta").Value & "'", CadenaConexion)
                If dtTra.Rows.Count > 0 And dtTra.Rows(0)("cuenta_debe").ToString.Trim.Length > 1 And dtTra.Rows(0)("cuenta_haber").ToString.Trim.Length > 1 Then
                    entiCCompraAsiento.tip_comp_origen = "-"
                    entiCCompraAsiento.serie_comp_origen = txtSerie.Text.Trim
                    entiCCompraAsiento.numero_comp_origen = txtNumero.Text.Trim
                    entiCCompraAsiento.impuesto = "0"
                    entiCCompraAsiento.serie = "0"
                    entiCCompraAsiento.numero = "0"
                    entiCCompraAsiento.operacion = "0"
                    'CUENTA DEBE
                    entiCCompraAsiento.cuenta = dtTra.Rows(0)("cuenta_debe").ToString
                    entiCCompraAsiento.glosa = "EXISTENCIAS - " & obtenerDatosCuenta(dtTra.Rows(0)("cuenta_debe").ToString)
                    entiCCompraAsiento.debe = dgvOperaciones.Rows(0).Cells("debe").Value
                    entiCCompraAsiento.haber = "0.00"
                    Dim rptaD As String = objCC.nRegistrarAsientoComprobanteCompraBD(entiCCompraAsiento, CadenaConexion)
                    If rptaD <> "ok" Then
                        MsgBox("Error en el registro en el asiento del comprobante: " & rptaD)
                    End If
                    'CUENTA HABER
                    entiCCompraAsiento.cuenta = dtTra.Rows(0)("cuenta_haber").ToString
                    entiCCompraAsiento.glosa = "EXISTENCIAS - " & obtenerDatosCuenta(dtTra.Rows(0)("cuenta_haber").ToString)
                    entiCCompraAsiento.debe = "0.00"
                    entiCCompraAsiento.haber = dgvOperaciones.Rows(0).Cells("debe").Value
                    Dim rptaH As String = objCC.nRegistrarAsientoComprobanteCompraBD(entiCCompraAsiento, CadenaConexion)
                    If rptaH <> "ok" Then
                        MsgBox("Error en el registro en el asiento del comprobante: " & rptaH)
                    End If
                End If

                'Capturar Id Centro - Buscado en la grilla
                Dim idCentroCosto2 As Integer = 0
                Dim entidad As New ALDiarioEntity
                For Each row As DataGridViewRow In dgvOperaciones.Rows
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
                'frmListaComprobanteCompras.realizarConsulta()
                Me.Dispose()
            Else
                MsgBox("Ingrese RUC/Razón Social del Proveedor")
                txtRuc.Focus()
            End If
        End If
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
        'VERIFICAR QUE EXISTA CUENTA DE IMPUESTO, SI ES QUE EXISTE
        'verificar serie a registrar
        Dim dtSer As New DataTable
        dtSer = objCrud.nCrudListarBD("select * from comprobante_compra where serie_comprobante='" & txtSerie.Text.Trim & "' and numero_comprobante='" & txtNumero.Text.Trim & "'", CadenaConexion)
        If dtSer.Rows.Count = 0 Then
            If cboPercepcion.SelectedValue.ToString <> "0" Then
                Dim dtImp As New DataTable
                dtImp = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & cboPercepcion.SelectedValue.ToString & "'", CadenaConexion)
                If dtImp.Rows.Count > 0 Then
                    If buscarCuentaEnGrilla(dtImp.Rows(0)("cuenta").ToString) = False Then
                        MsgBox("La cuenta de " & cboPercepcion.Text & ", no ha sido adicionada")
                        Exit Sub
                    End If
                End If
            End If

            If verificarPartidaDoble() = True Then
                If Decimal.Parse(txtTotal2.Text.Trim) = Decimal.Parse(txtTotalCompra.Text.Trim) Then
                    procesarBoton()
                Else
                    MsgBox("El total del comprobante no es igual al monto de la cuenta de compra")
                End If
            End If
        Else
            MsgBox("Ingrese otro número y serie para el comprobante")
        End If
    End Sub
    Private Function buscarCuentaEnGrilla(dato As String) As Boolean
        Dim rpta As Boolean = False
        For i As Integer = 0 To dgvOperaciones.Rows.Count - 1
            For x As Integer = 0 To dgvOperaciones.ColumnCount - 1
                If dgvOperaciones.Rows(i).Cells("num_cuenta").Value.ToString = dato Then
                    dgvOperaciones.CurrentCell = dgvOperaciones.Rows(i).Cells("num_cuenta")
                    rpta = True
                End If
            Next
        Next
        Return rpta
    End Function
    Private Sub procesarBoton()
        If validarEntradas() = True Then
            If btnFinalizar.Text = "FINALIZAR" Then
                guardarDatos("F")
            ElseIf btnFinalizar.Text = "PAGAR" Then
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
                .formInicio = "compraP"
                .datoProveedor = txtRuc.Text.Trim
                .txtDescripcion.Text = .datoProveedor
                .realizarBusqueda()
                .ShowDialog()
            End With
        ElseIf txtRazonSocial.Focused = True Then
            With frmEscogerProveedor
                .formInicio = "compraP"
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
        'MsgBox()
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
                btnAgregarCuenta.PerformClick()
            End If
        ElseIf e.KeyCode = Keys.End Then
            btnFinalizar.PerformClick()
        End If
    End Sub
    Private Sub agregarCuentaContable()
        frmAgregarCuentasNuevo.formIni = "nuevaCompraP"
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

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        If dgvOperaciones.RowCount > 0 Then
            Dim monto As Decimal = 0
            For Each row As DataGridViewRow In dgvOperaciones.Rows
                If row.Cells("num_cuenta").Value.ToString.StartsWith("63") Then
                    monto = row.Cells("debe").Value.ToString
                    Exit For
                End If
            Next

            'Buscar si tiene anexado centro de costos
            Dim data As New DataTable
            data = objCrud.nCrudListarBD("select * from parametro_centro_costo where id_centro='" & txtCentro.Text.Trim & "'", CadenaConexion)
            For Each fila As DataRow In data.Rows
                'fila.Item("cuenta")
                Dim dtI As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
                Dim row As DataRow = dtI.NewRow()
                row.Item(0) = fila.Item("cuenta").ToString
                row.Item(1) = obtenerDatosCuenta(fila.Item("cuenta").ToString)
                row.Item(2) = IIf(fila.Item("debe").ToString = "X", monto, "0.00")
                row.Item(3) = IIf(fila.Item("haber").ToString = "X", monto, "0.00")
                row.Item(4) = "CUENTA DEL CENTRO DE COSTO"
                dtI.Rows.Add(row)
            Next
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
    Private Sub txtNumeroImpuesto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroImpuesto.Leave
        txtNumeroImpuesto.Text = txtNumeroImpuesto.Text.ToString.PadLeft(4, "0")
    End Sub

    Private Sub cboTipoDocumento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoDocumento.SelectedIndexChanged

    End Sub

    Private Sub cboOperacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOperacion.SelectedIndexChanged

    End Sub
End Class