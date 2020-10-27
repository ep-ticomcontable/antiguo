Imports Negocio
Imports Entidades
Public Class frmNuevaNotaCredito

    Dim obj As New nCrud
    Dim objTDA As New nTipoDocumentoAsiento
    Public codComprobante As Integer = 0
    Public codTipoComprobante As Integer = 0
    Dim objCC As New nComprobanteCompra
    Dim objCV As New nComprobanteVenta
    Dim objNCD As New nNotaCreditoDebito
    Dim tipoOperacion As Integer = 6 'DEVOLUCIONES
    Dim codigoComprobante As Integer = 0
    Dim factor As Decimal = 0
    Dim iCarga As Integer = 0
    Public TIPO_PROCESO As String

    Public Sub cargarDatosComprobante()
        Dim data As New DataTable
        If TIPO_PROCESO = "COMPRA" Then
            data = obj.nCrudListarBD("select * from comprobante_compra where id='" & codComprobante & "'", CadenaConexion)
        Else
            data = obj.nCrudListarBD("select * from comprobante_venta where id='" & codComprobante & "'", CadenaConexion)
        End If
        With data
            cboTipoDocumento.SelectedValue = .Rows(0)("id_tipo_comprobante").ToString
            txtSerie.Text = .Rows(0)("serie_comprobante").ToString
            txtNumero.Text = .Rows(0)("numero_comprobante").ToString
            dtFecha.Value = .Rows(0)("fec_emision").ToString
            txtRuc.Text = .Rows(0)("num_dni").ToString
            txtRazon.Text = .Rows(0)("razon_social").ToString

            Dim dtVerNC, dtNC As New DataTable
            dtVerNC = obj.nCrudListarBD("select * from comprobante_nota_credito where tipo='" & TIPO_PROCESO & "' and id_comprobante='" & codComprobante & "'", CadenaConexion)
            If dtVerNC.Rows.Count > 0 Then
                dtNC = obj.nCrudListarBD("select sum(total) as 'total' from comprobante_nota_credito where tipo='" & TIPO_PROCESO & "' and id_comprobante='" & codComprobante & "'", CadenaConexion)
                If Decimal.Parse(dtNC.Rows(0)("total").ToString) < Decimal.Parse(.Rows(0)("total").ToString) Then
                    txtMonto.Text = 0
                    txtIgv.Text = 0
                    txtTotal.Text = Decimal.Parse(.Rows(0)("total").ToString) - Decimal.Parse(dtNC.Rows(0)("total").ToString)
                    txtTotalOc.Text = Decimal.Parse(.Rows(0)("total").ToString)
                End If
            Else
                txtMonto.Text = .Rows(0)("valor_facturado").ToString
                txtIgv.Text = .Rows(0)("valor_igv").ToString
                txtTotal.Text = .Rows(0)("total").ToString
                txtTotalOc.Text = .Rows(0)("total").ToString
            End If
        End With
        If TIPO_PROCESO = "COMPRA" Then
            lblTitulo.Text = "NOTA DE CRÉDITO - COMPRA"
        Else
            lblTitulo.Text = "NOTA DE CRÉDITO - VENTA"
        End If
    End Sub
    Private Sub cargarTipoDocumento()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = objTDA.nListarCuentasSegunTipoAsientoBD(1, CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, "(" & row.Item(1).ToString & ") " & row.Item(2).ToString.ToUpper)
            Next
            With cboTipoDocumento
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
                .SelectedValue = codTipoComprobante
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Documentos")
        End Try
    End Sub
    Private Sub cargarMotivos()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")

        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select * from motivo_credito_debito where estado=1 order by descripcion asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboMotivo
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Documentos")
        End Try
    End Sub
    Private Sub comboSinAnulacion()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")

        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select * from motivo_credito_debito where estado=1 and id>1 order by descripcion asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboMotivo
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Documentos")
        End Try
    End Sub

    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = obj.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function
    Private Sub cargarSerieNumero()
        Dim dt As New DataTable
        dt = obj.nCrudListarBD("select top 1 * from comprobante_nota_credito where tipo='" & TIPO_PROCESO & "' order by id desc", CadenaConexion)
        If dt.Rows.Count > 0 Then
            txtSerieN.Text = dt.Rows(0)("serie").ToString
            txtNumeroN.Text = (Integer.Parse(dt.Rows(0)("numero").ToString) + 1).ToString.PadLeft(4, "0")
        End If
    End Sub
    Private Sub frmNuevaNotaCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLista.RowTemplate.Height = 30
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        cargarTipoDocumento()
        cargarMotivos()
        cargarSerieNumero()
        iCarga = 1
        verificarAnulacion()
    End Sub
    Private Sub verificarAnulacion()
        Dim tabla As String = "abono_pagos_compras where id_compra"
        If TIPO_PROCESO = "VENTA" Then
            tabla = "abono_pagos_ventas where id_venta"
        End If
        Dim dt As New DataTable
        dt = obj.nCrudListarBD("select * from " & tabla & "='" & codComprobante & "'", CadenaConexion)
        If dt.Rows.Count > 0 Then
            comboSinAnulacion()
        End If
    End Sub
    Private Sub btnRuc_Click(sender As Object, e As EventArgs) Handles btnRuc.Click
        frmConsultaSunat.formInicio = "notacredito"
        frmConsultaSunat.ShowDialog()
    End Sub
    Private Function verificarPartidaDoble() As Boolean
        Dim rpta As Boolean = False
        Dim sDebe, sHaber As Decimal
        For Each row As DataGridViewRow In dgvLista.Rows
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
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If txtComentarios.Text.Trim.Length > 2 Then
            If verificarPartidaDoble() = True Then
                'MsgBox("Monto: " & mMonto & " - IGV: " & mIgv & " - Total: " & mTotal)

                If cboMotivo.Text.Trim.StartsWith("Devoluc") Then
                    Dim objAbono As New nAbonosPagos
                    Dim dt As New DataTable
                    dt = obj.nCrudListarBD("select * from motivo_credito_debito where id='" & cboMotivo.SelectedValue.ToString & "'", CadenaConexion)
                    If TIPO_PROCESO = "compra" Then
                        Dim dtCaja As New DataTable
                        dtCaja = obj.nCrudListarBD("select * from caja_configuracion where cuenta='" & dt.Rows(0)("cuenta_compra").ToString & "'", CadenaConexion)

                        Dim EntiAboCom, EntiAsientoAboCom As New AbonoComprasEntity
                        Dim dtCompra As New DataTable
                        dtCompra = obj.nCrudListarBD("select * from comprobante_compra where id='" & codComprobante & "'", CadenaConexion)
                        With EntiAboCom
                            .id_compra = dtCompra.Rows(0)("id").ToString
                            .id_impuesto = "0"
                            .id_letra = 0
                            .tipo_comprobante = dtCompra.Rows(0)("id_tipo_comprobante").ToString
                            .monto = "-" & txtTotal.Text.Trim
                            .id_banco = "0"
                            .id_caja = dtCaja.Rows(0)("id").ToString
                            .tipo = "8"
                            .numero = txtSerieN.Text.Trim & "-" & txtNumeroN.Text.Trim
                            .descripcion = txtComentarios.Text.Trim
                            .fecha = DateTime.Now.ToString("yyyy-MM-dd H:mm:s")
                            .estado = "1"
                            .tipo_abono = "CANJE"
                        End With
                        objAbono.nRegistrarAbonoComprasBD(EntiAboCom, CadenaConexion)
                    Else
                        Dim dtCaja As New DataTable
                        dtCaja = obj.nCrudListarBD("select * from caja_configuracion where cuenta='" & dt.Rows(0)("cuenta_venta").ToString & "'", CadenaConexion)

                        Dim EntiAboCom As New AbonoVentasEntity
                        Dim dtVenta As New DataTable
                        dtVenta = obj.nCrudListarBD("select * from comprobante_venta where id='" & codComprobante & "'", CadenaConexion)
                        With EntiAboCom
                            .id_venta = dtVenta.Rows(0)("id").ToString
                            .id_impuesto = "0"
                            .id_letra = 0
                            .tipo_comprobante = dtVenta.Rows(0)("id_tipo_comprobante").ToString
                            .monto = "-" & txtTotal.Text.Trim
                            .id_banco = "0"
                            .id_caja = dtCaja.Rows(0)("id").ToString
                            .tipo = "8"
                            .numero = txtSerieN.Text.Trim & "-" & txtNumeroN.Text.Trim
                            .descripcion = txtComentarios.Text.Trim
                            .fecha = DateTime.Now.ToString("yyyy-MM-dd H:mm:s")
                            .estado = "1"
                            .tipo_abono = "CANJE"
                        End With
                        objAbono.nRegistrarAbonoVentasBD(EntiAboCom, CadenaConexion)
                    End If

                End If

                Dim entiNCD As New ComprobanteNotaCreditoDebito
                With entiNCD
                    .id = codComprobante
                    .tipo = TIPO_PROCESO
                    .numero_cuo = "0"
                    .serie = txtSerieN.Text.Trim
                    .numero = txtNumeroN.Text.Trim
                    .fec_emision = dtFechaEmision.Value
                    .serie_ref = txtSerie.Text.Trim
                    .numero_ref = txtNumero.Text.Trim
                    .num_dni = txtRuc.Text.Trim
                    .razon_social = txtRazon.Text.Trim
                    .glosa = txtComentarios.Text.Trim
                    .monto = txtMonto.Text.Trim
                    .valor_igv = txtIgv.Text.Trim
                    .total = txtTotal.Text.Trim
                    .motivo = cboMotivo.Text
                    .comentario = txtComentarios.Text.Trim
                    .estado = 1
                End With
                objNCD.registrarNotaCreditoBD(entiNCD, CadenaConexion)

                Dim objAC As New nAsientosContables

                Dim entiCVenta As New ComprobanteVentaEntity
                With entiCVenta
                    .numero_cuo = objAC.nObtenerNumeroCUO()
                    .numero_maquina = "-"
                    .tipo_venta = "NOTA CREDITO"
                    .id_gravado = "1"
                    .marca = "0@0"
                    .centro = "0"
                    .estado_comprobante = "F"
                    .id_tipo_comprobante = "8"
                    .fec_emision = dtFechaEmision.Value
                    .fec_pago = dtFechaEmision.Value
                    .serie_comprobante = txtSerieN.Text
                    .numero_comprobante = txtNumeroN.Text
                    .cod_dni = "6"
                    .num_dni = txtRuc.Text.Trim
                    .razon_social = txtRazon.Text.Trim
                    .valor_facturado = "-" & txtMonto.Text.Trim
                    .glosa = txtComentarios.Text.Trim
                    .id_moneda = "115"
                    .valor_igv = "-" & txtIgv.Text.Trim
                    .total = "-" & txtTotal.Text.Trim
                    .tipo_cambio = "1.00"
                    .detraccion = 0
                    .fec_comp_origen = dtFecha.Value
                    .tip_comp_origen = cboTipoDocumento.SelectedValue.ToString
                    .serie_comp_origen = txtSerie.Text.Trim
                    .numero_comp_origen = txtNumero.Text.Trim
                    .estado = 1
                    .id_usuario = CodigoUsuarioSession
                End With
                'MsgBox("REGISTRANDO COMPROBANTE DE COMPRA: " & objCC.nRegistrarComprobanteCompraBD(entiCCompra, CadenaConexion))
                objCV.nRegistrarComprobanteVentaBD(entiCVenta, CadenaConexion)
                Dim idNC As String
                idNC = objNCD.obtenerIdNotaCreditoBD(CadenaConexion)

                For Each row As DataGridViewRow In dgvLista.Rows
                    With entiNCD
                        .id_nota_credito = idNC
                        .glosa = txtComentarios.Text.Trim
                        .cuenta = row.Cells("num_cuenta").Value
                        .debe = row.Cells("debe").Value
                        .haber = row.Cells("haber").Value
                    End With
                    'MsgBox(objNCD.registrarAsientoNotaCreditoBD(entiNCD, CadenaConexion))
                    objNCD.registrarAsientoNotaCreditoBD(entiNCD, CadenaConexion)
                Next
                MsgBox("LA NOTA DE CREDITO PARA " & TIPO_PROCESO & " HA SIDO GUARDADA CON ÉXITO")
                frmListaComprobanteVentas.realizarConsulta()
                Me.Close()
            End If
        Else
            MsgBox("Ingrese la glosa")
            txtComentarios.Focus()
        End If
    End Sub

    Public Sub agregarCuenta(numcuenta, desccuenta, debe, haber)
        If dgvLista.Rows.Count = 0 Then
            Dim dtItem As New DataTable
            With dtItem.Columns
                .Add("id")
                .Add("id_asiento_compra")
                .Add("num_cuenta")
                .Add("desc_cuenta")
                .Add("debe")
                .Add("haber")
            End With
            dtItem.Rows.Add("0", codComprobante, numcuenta, desccuenta, haber, debe)
            dgvLista.DataSource = dtItem
        Else
            Dim dt As DataTable = DirectCast(dgvLista.DataSource, DataTable)
            Dim row As DataRow = dt.NewRow()
            row.Item(0) = "0"
            row.Item(1) = codComprobante
            row.Item(2) = numcuenta
            row.Item(3) = desccuenta
            row.Item(4) = haber
            row.Item(5) = debe
            dt.Rows.Add(row)
        End If
        seleccionarCuentaAdicionada(numcuenta)
        realizarSumasTotales()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        frmTsCuentasTipoOperacion.Show()
    End Sub
    Private Sub btnBuscarComprobante_Click(sender As Object, e As EventArgs) Handles btnBuscarComprobante.Click
        cargarComprobante()
    End Sub
    Private Sub cargarComprobante()
        Dim numero As String = txtNumero.Text.Trim
        Dim serie As String = txtSerie.Text.Trim
        Dim data As New DataTable
        data = objNCD.comprobanteCompraPorSerieNumeroBD(serie, numero, CadenaConexion)
        'MsgBox(data.Rows(0)("num_dni").ToString)
        If data.Rows.Count > 0 Then
            With data
                cboTipoDocumento.SelectedValue = .Rows(0)("id_tipo_comprobante").ToString
                dtFecha.Value = .Rows(0)("fec_emision").ToString
                txtRuc.Text = .Rows(0)("num_dni").ToString
                txtRazon.Text = .Rows(0)("razon_social").ToString
                txtMonto.Text = .Rows(0)("valor_facturado").ToString
                txtIgv.Text = .Rows(0)("valor_igv").ToString
                txtTotal.Text = .Rows(0)("total").ToString
                codComprobante = .Rows(0)("id").ToString
                codigoComprobante = .Rows(0)("id").ToString
            End With
            'realizarSumasTotales()
        Else
            MsgBox("No se han encontrado resultados con el comprobante de compra ingresado...")
        End If

    End Sub
    Private Sub realizarSumasTotales()
        'MsgBox("suma total")
        Dim tDebe, tHaber, tDiferencia As Decimal
        For Each row As DataGridViewRow In dgvLista.Rows
            tDebe += row.Cells("debe").Value
            tHaber += row.Cells("haber").Value
        Next
        tDiferencia = tDebe - tHaber

        txtTDebeS.Text = Format(tDebe, "#,##0.00")
        txtTHaberS.Text = Format(tHaber, "#,##0.00")
        txtDiferenciaS.Text = Format(tDiferencia, "#,##0.00")
    End Sub

    Private Sub seleccionarCuentaAdicionada(numcuenta)
        For i As Integer = 0 To dgvLista.Rows.Count - 1
            For x As Integer = 0 To dgvLista.ColumnCount - 1
                If dgvLista.Rows(i).Cells("num_cuenta").Value.ToString = numcuenta Then
                    'dgvDetalle.MultiSelect = False
                    'dgvDetalle.Rows(i).Selected = True
                    'dgvDetalle.Rows(i).Cells("cantidad").Select = True

                    dgvLista.CurrentCell = dgvLista.Rows(i).Cells("num_cuenta")
                    'dgvDetalle.CurrentCell = dgvDetalle.Item("cantidad", i)
                    'dgvDetalle.SelectionMode = DataGridViewSelectionMode.CellSelect
                End If
            Next
        Next
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        On Error Resume Next
        If Decimal.Parse(txtTotal.Text.Trim) <= Decimal.Parse(txtTotalVOc.Text.Trim) Then
            If cboMotivo.SelectedValue <> 0 Then
                'verificar que el monto a canjear sea menor o igual a la diferencia del total con los canjes
                Dim dtVerNC, dtNC As New DataTable
                dtVerNC = obj.nCrudListarBD("select * from comprobante_nota_credito where tipo='" & TIPO_PROCESO & "' and id_comprobante='" & codComprobante & "'", CadenaConexion)
                If dtVerNC.Rows.Count > 0 Then
                    dtNC = obj.nCrudListarBD("select sum(total) as 'total' from comprobante_nota_credito where tipo='" & TIPO_PROCESO & "' and id_comprobante='" & codComprobante & "'", CadenaConexion)
                    Dim diferencia As Decimal = 0
                    diferencia = Decimal.Parse(txtTotalOc.Text.Trim) - Decimal.Parse(dtNC.Rows(0)("total").ToString)
                    If Decimal.Parse(txtTotal.Text.Trim) > diferencia Then
                        MsgBox("El monto sobrepasa a la diferencia permitida")
                    Else
                        'recalcular factor
                        txtFactor.Text = 1
                        If Decimal.Parse(txtTotal.Text.Trim) > 0 And txtTotal.Text.Trim.Length > 0 And txtTotal.Text.Trim <> "" Then
                            factor = Decimal.Parse(txtTotalOc.Text.Trim) / Decimal.Parse(txtTotal.Text.Trim)
                            'factor = Format(factor, "###0.00")
                            If factor = 0 Then
                                factor = 1
                            End If
                            txtFactor.Text = factor
                        End If

                        Dim dtItem As New DataTable
                        With dtItem.Columns
                            .Add("id")
                            .Add("id_asiento_venta")
                            .Add("num_cuenta")
                            .Add("desc_cuenta")
                            .Add("debe")
                            .Add("haber")
                        End With
                        dgvLista.DataSource = dtItem

                        Dim dataParam As New DataTable
                        dataParam = obj.nCrudListarBD("select * from motivo_credito_debito where id='" & cboMotivo.SelectedValue.ToString & "'", CadenaConexion)

                        If dgvLista.RowCount = 0 Then
                            Dim data As New DataTable
                            If TIPO_PROCESO = "COMPRA" Then
                                data = obj.nCrudListarBD("usp_cuentaComprobanteCompra '" & codComprobante & "','60'", CadenaConexion)
                            Else
                                data = obj.nCrudListarBD("usp_cuentaComprobanteVenta '" & codComprobante & "','70'", CadenaConexion)
                            End If
                            If dataParam.Rows(0)("cuenta_compra").ToString = "-" Then
                                Dim dtV As New DataTable
                                If TIPO_PROCESO = "COMPRA" Then
                                    dtV = obj.nCrudListarBD("usp_cuentasContablesComprobanteCompra '" & codComprobante & "'", CadenaConexion)
                                Else
                                    dtV = obj.nCrudListarBD("usp_cuentasContablesComprobanteVenta '" & codComprobante & "'", CadenaConexion)
                                End If
                                For Each fila As DataRow In dtV.Rows
                                    dtItem.Rows.Add(fila.Item("id").ToString, fila.Item("id_comprobante_compra").ToString, _
                                    fila.Item("num_cuenta").ToString, _
                                    obtenerDatosCuenta(fila.Item("num_cuenta").ToString), _
                                    Format(Decimal.Round(Decimal.Parse(fila.Item("debe").ToString / factor), 2), "###0.00"), _
                                    Format(Decimal.Round(Decimal.Parse(fila.Item("haber").ToString / factor), 2), "###0.00"))
                                Next
                            Else
                                If TIPO_PROCESO = "COMPRA" Then
                                    'dtItem.Rows.Add(data.Rows(0)("id").ToString, data.Rows(0)("id_comprobante_compra").ToString, _
                                    'dataParam.Rows(0)("cuenta_compra").ToString, _
                                    'obtenerDatosCuenta(dataParam.Rows(0)("cuenta_compra").ToString), _
                                    'txtMonto.Text.Trim, _
                                    'data.Rows(0)("haber").ToString)
                                    data = obj.nCrudListarBD("usp_cuentaComprobanteCompra '" & codComprobante & "','60'", CadenaConexion)
                                    If dataParam.Rows(0)("cuenta_compra").ToString = "-" Then
                                        Dim dtV As New DataTable
                                        dtV = obj.nCrudListarBD("usp_cuentasContablesComprobanteCompra '" & codComprobante & "'", CadenaConexion)
                                        For Each fila As DataRow In dtV.Rows
                                            dtItem.Rows.Add(fila.Item("id").ToString, fila.Item("id_comprobante_compra").ToString, _
                                            fila.Item("num_cuenta").ToString, _
                                            obtenerDatosCuenta(fila.Item("num_cuenta").ToString), _
                                            Format(Decimal.Round(Decimal.Parse(fila.Item("debe").ToString / factor), 2), "###0.00"), _
                                            Format(Decimal.Round(Decimal.Parse(fila.Item("haber").ToString / factor), 2), "###0.00"))
                                        Next
                                    Else
                                        dtItem.Rows.Add(data.Rows(0)("id").ToString, data.Rows(0)("id_comprobante_compra").ToString, _
                                        dataParam.Rows(0)("cuenta_compra").ToString, _
                                        obtenerDatosCuenta(dataParam.Rows(0)("cuenta_compra").ToString), _
                                        txtMonto.Text.Trim, _
                                        data.Rows(0)("haber").ToString)
                                        Dim dtV As New DataTable
                                        dtV = obj.nCrudListarBD("usp_cuentasContablesComprobanteCompra '" & codComprobante & "'", CadenaConexion)
                                        For Each fila As DataRow In dtV.Rows
                                            If Not fila.Item("num_cuenta").ToString.StartsWith("6") Or fila.Item("num_cuenta").ToString.StartsWith("61") Then
                                                dtItem.Rows.Add(fila.Item("id").ToString, fila.Item("id_comprobante_compra").ToString, _
                                                fila.Item("num_cuenta").ToString, _
                                                obtenerDatosCuenta(fila.Item("num_cuenta").ToString), _
                                                Format(Decimal.Round(Decimal.Parse(fila.Item("debe").ToString / factor), 2), "###0.00"), _
                                                Format(Decimal.Round(Decimal.Parse(fila.Item("haber").ToString / factor), 2), "###0.00"))
                                            End If
                                        Next
                                    End If
                                Else
                                    'dtItem.Rows.Add(data.Rows(0)("id").ToString, data.Rows(0)("id_comprobante_venta").ToString, _
                                    'dataParam.Rows(0)("cuenta_venta").ToString, _
                                    'obtenerDatosCuenta(dataParam.Rows(0)("cuenta_venta").ToString), _
                                    'txtMonto.Text.Trim, _
                                    'data.Rows(0)("haber").ToString)
                                    data = obj.nCrudListarBD("usp_cuentaComprobanteVenta '" & codComprobante & "','70'", CadenaConexion)
                                    If dataParam.Rows(0)("cuenta_venta").ToString = "-" Then
                                        Dim dtV As New DataTable
                                        dtV = obj.nCrudListarBD("usp_cuentasContablesComprobanteVenta '" & codComprobante & "'", CadenaConexion)
                                        For Each fila As DataRow In dtV.Rows
                                            dtItem.Rows.Add(fila.Item("id").ToString, fila.Item("id_comprobante_venta").ToString, _
                                            fila.Item("num_cuenta").ToString, _
                                            obtenerDatosCuenta(fila.Item("num_cuenta").ToString), _
                                            Format(Decimal.Round(Decimal.Parse(fila.Item("debe").ToString / factor), 2), "###0.00"), _
                                            Format(Decimal.Round(Decimal.Parse(fila.Item("haber").ToString / factor), 2), "###0.00"))
                                        Next
                                    Else
                                        dtItem.Rows.Add(data.Rows(0)("id").ToString, data.Rows(0)("id_comprobante_venta").ToString, _
                                        dataParam.Rows(0)("cuenta_venta").ToString, _
                                        obtenerDatosCuenta(dataParam.Rows(0)("cuenta_venta").ToString), _
                                        "0.00", _
                                        Format(Decimal.Round(Decimal.Parse(data.Rows(0)("haber").ToString / factor), 2), "###0.00"))
                                        Dim dtV As New DataTable
                                        dtV = obj.nCrudListarBD("usp_cuentasContablesComprobanteVenta '" & codComprobante & "'", CadenaConexion)
                                        For Each fila As DataRow In dtV.Rows
                                            If Not fila.Item("num_cuenta").ToString.StartsWith("7") Then
                                                dtItem.Rows.Add(fila.Item("id").ToString, fila.Item("id_comprobante_venta").ToString, _
                                                fila.Item("num_cuenta").ToString, _
                                                obtenerDatosCuenta(fila.Item("num_cuenta").ToString), _
                                                Format(Decimal.Round(Decimal.Parse(fila.Item("debe").ToString / factor), 2), "###0.00"), _
                                                Format(Decimal.Round(Decimal.Parse(fila.Item("haber").ToString / factor), 2), "###0.00"))
                                            End If
                                        Next
                                    End If
                                End If

                            End If
                            dgvLista.DataSource = dtItem
                        End If

                        'If dataParam.Rows(0)("cuenta_compra").ToString <> "-" Then
                        '    Dim dataParam1 As New DataTable
                        '    dataParam1 = obj.nCrudListarBD("usp_parametrosNotaCreditoDebito '" & tipoOperacion & "','40'", CadenaConexion)
                        '    Dim data2 As New DataTable
                        '    data2 = obj.nCrudListarBD("usp_cuentaComprobanteCompra '" & codComprobante & "','40'", CadenaConexion)
                        '    Dim dt As DataTable = DirectCast(dgvLista.DataSource, DataTable)
                        '    Dim row As DataRow = dt.NewRow()
                        '    row.Item(0) = data2.Rows(0)("id").ToString
                        '    row.Item(1) = data2.Rows(0)("id_comprobante_compra").ToString
                        '    row.Item(2) = dataParam1.Rows(0)("num_cuenta").ToString
                        '    row.Item(3) = dataParam1.Rows(0)("desc_cuenta").ToString
                        '    row.Item(4) = txtIgv.Text.Trim
                        '    row.Item(5) = data2.Rows(0)("haber").ToString
                        '    dt.Rows.Add(row)

                        '    Dim dataParam3 As New DataTable
                        '    dataParam3 = obj.nCrudListarBD("usp_parametrosNotaCreditoDebito '" & tipoOperacion & "','40'", CadenaConexion)
                        '    Dim data3 As New DataTable
                        '    data3 = obj.nCrudListarBD("usp_cuentaComprobanteCompra '" & codComprobante & "','42'", CadenaConexion)
                        '    Dim dt3 As DataTable = DirectCast(dgvLista.DataSource, DataTable)
                        '    Dim row3 As DataRow = dt3.NewRow()
                        '    row3.Item(0) = data3.Rows(0)("id").ToString
                        '    row3.Item(1) = data3.Rows(0)("id_comprobante_compra").ToString
                        '    row3.Item(2) = data3.Rows(0)("num_cuenta").ToString
                        '    row3.Item(3) = data3.Rows(0)("desc_cuenta").ToString
                        '    row3.Item(4) = data3.Rows(0)("debe").ToString
                        '    row3.Item(5) = txtTotal.Text.Trim
                        '    dt3.Rows.Add(row3)
                        'End If
                        realizarSumasTotales()
                    End If
                Else
                    'recalcular factor
                    txtFactor.Text = 1
                    If Decimal.Parse(txtTotal.Text.Trim) > 0 And txtTotal.Text.Trim.Length > 0 And txtTotal.Text.Trim <> "" Then
                        factor = Decimal.Parse(txtTotalOc.Text.Trim) / Decimal.Parse(txtTotal.Text.Trim)
                        'factor = Format(factor, "###0.00")
                        If factor = 0 Then
                            factor = 1
                        End If
                        txtFactor.Text = factor
                    End If

                    Dim dtItem As New DataTable
                    With dtItem.Columns
                        .Add("id")
                        .Add("id_asiento_venta")
                        .Add("num_cuenta")
                        .Add("desc_cuenta")
                        .Add("debe")
                        .Add("haber")
                    End With
                    dgvLista.DataSource = dtItem

                    Dim dataParam As New DataTable
                    dataParam = obj.nCrudListarBD("select * from motivo_credito_debito where id='" & cboMotivo.SelectedValue.ToString & "'", CadenaConexion)

                    If dgvLista.RowCount = 0 Then
                        Dim data As New DataTable
                        If TIPO_PROCESO = "COMPRA" Then
                            data = obj.nCrudListarBD("usp_cuentaComprobanteCompra '" & codComprobante & "','60'", CadenaConexion)
                            If dataParam.Rows(0)("cuenta_compra").ToString = "-" Then
                                Dim dtV As New DataTable
                                dtV = obj.nCrudListarBD("usp_cuentasContablesComprobanteCompra '" & codComprobante & "'", CadenaConexion)
                                For Each fila As DataRow In dtV.Rows
                                    dtItem.Rows.Add(fila.Item("id").ToString, fila.Item("id_comprobante_compra").ToString, _
                                    fila.Item("num_cuenta").ToString, _
                                    obtenerDatosCuenta(fila.Item("num_cuenta").ToString), _
                                    Format(Decimal.Round(Decimal.Parse(fila.Item("debe").ToString / factor), 2), "###0.00"), _
                                    Format(Decimal.Round(Decimal.Parse(fila.Item("haber").ToString / factor), 2), "###0.00"))
                                Next
                            Else
                                dtItem.Rows.Add(data.Rows(0)("id").ToString, data.Rows(0)("id_comprobante_compra").ToString, _
                                dataParam.Rows(0)("cuenta_compra").ToString, _
                                obtenerDatosCuenta(dataParam.Rows(0)("cuenta_compra").ToString), _
                                txtMonto.Text.Trim, _
                                data.Rows(0)("haber").ToString)
                                Dim dtV As New DataTable
                                dtV = obj.nCrudListarBD("usp_cuentasContablesComprobanteCompra '" & codComprobante & "'", CadenaConexion)
                                For Each fila As DataRow In dtV.Rows
                                    If Not fila.Item("num_cuenta").ToString.StartsWith("6") Or fila.Item("num_cuenta").ToString.StartsWith("61") Then
                                        dtItem.Rows.Add(fila.Item("id").ToString, fila.Item("id_comprobante_compra").ToString, _
                                        fila.Item("num_cuenta").ToString, _
                                        obtenerDatosCuenta(fila.Item("num_cuenta").ToString), _
                                        Format(Decimal.Round(Decimal.Parse(fila.Item("debe").ToString / factor), 2), "###0.00"), _
                                        Format(Decimal.Round(Decimal.Parse(fila.Item("haber").ToString / factor), 2), "###0.00"))
                                    End If
                                Next
                            End If
                        Else
                            data = obj.nCrudListarBD("usp_cuentaComprobanteVenta '" & codComprobante & "','70'", CadenaConexion)
                            If dataParam.Rows(0)("cuenta_venta").ToString = "-" Then
                                Dim dtV As New DataTable
                                dtV = obj.nCrudListarBD("usp_cuentasContablesComprobanteVenta '" & codComprobante & "'", CadenaConexion)
                                For Each fila As DataRow In dtV.Rows
                                    dtItem.Rows.Add(fila.Item("id").ToString, fila.Item("id_comprobante_venta").ToString, _
                                    fila.Item("num_cuenta").ToString, _
                                    obtenerDatosCuenta(fila.Item("num_cuenta").ToString), _
                                    Format(Decimal.Round(Decimal.Parse(fila.Item("debe").ToString / factor), 2), "###0.00"), _
                                    Format(Decimal.Round(Decimal.Parse(fila.Item("haber").ToString / factor), 2), "###0.00"))
                                Next
                            Else
                                'dtItem.Rows.Add(data.Rows(0)("id").ToString, data.Rows(0)("id_comprobante_venta").ToString, _
                                'dataParam.Rows(0)("cuenta_venta").ToString, _
                                'obtenerDatosCuenta(dataParam.Rows(0)("cuenta_venta").ToString), _
                                '"0.00", _
                                'Format(Decimal.Round(Decimal.Parse(data.Rows(0)("haber").ToString / factor), 2), "###0.00"))
                                Dim dtV As New DataTable
                                dtV = obj.nCrudListarBD("usp_cuentasContablesComprobanteVenta '" & codComprobante & "'", CadenaConexion)
                                For Each fila As DataRow In dtV.Rows
                                    'If fila.Item("num_cuenta").ToString.StartsWith("7") Then
                                    dtItem.Rows.Add(fila.Item("id").ToString, fila.Item("id_comprobante_venta").ToString, _
                                    fila.Item("num_cuenta").ToString, _
                                    obtenerDatosCuenta(fila.Item("num_cuenta").ToString), _
                                    Format(Decimal.Round(Decimal.Parse(fila.Item("debe").ToString / factor), 2), "###0.00"), _
                                    Format(Decimal.Round(Decimal.Parse(fila.Item("haber").ToString / factor), 2), "###0.00"))
                                    'End If
                                Next
                            End If
                        End If

                        dgvLista.DataSource = dtItem
                    End If

                    'If dataParam.Rows(0)("cuenta_compra").ToString <> "-" Then
                    '    Dim dataParam1 As New DataTable
                    '    dataParam1 = obj.nCrudListarBD("usp_parametrosNotaCreditoDebito '" & tipoOperacion & "','40'", CadenaConexion)
                    '    Dim data2 As New DataTable
                    '    data2 = obj.nCrudListarBD("usp_cuentaComprobanteCompra '" & codComprobante & "','40'", CadenaConexion)
                    '    Dim dt As DataTable = DirectCast(dgvLista.DataSource, DataTable)
                    '    Dim row As DataRow = dt.NewRow()
                    '    row.Item(0) = data2.Rows(0)("id").ToString
                    '    row.Item(1) = data2.Rows(0)("id_comprobante_compra").ToString
                    '    row.Item(2) = dataParam1.Rows(0)("num_cuenta").ToString
                    '    row.Item(3) = dataParam1.Rows(0)("desc_cuenta").ToString
                    '    row.Item(4) = txtIgv.Text.Trim
                    '    row.Item(5) = data2.Rows(0)("haber").ToString
                    '    dt.Rows.Add(row)

                    '    Dim dataParam3 As New DataTable
                    '    dataParam3 = obj.nCrudListarBD("usp_parametrosNotaCreditoDebito '" & tipoOperacion & "','40'", CadenaConexion)
                    '    Dim data3 As New DataTable
                    '    data3 = obj.nCrudListarBD("usp_cuentaComprobanteCompra '" & codComprobante & "','42'", CadenaConexion)
                    '    Dim dt3 As DataTable = DirectCast(dgvLista.DataSource, DataTable)
                    '    Dim row3 As DataRow = dt3.NewRow()
                    '    row3.Item(0) = data3.Rows(0)("id").ToString
                    '    row3.Item(1) = data3.Rows(0)("id_comprobante_compra").ToString
                    '    row3.Item(2) = data3.Rows(0)("num_cuenta").ToString
                    '    row3.Item(3) = data3.Rows(0)("desc_cuenta").ToString
                    '    row3.Item(4) = data3.Rows(0)("debe").ToString
                    '    row3.Item(5) = txtTotal.Text.Trim
                    '    dt3.Rows.Add(row3)
                    'End If
                    realizarSumasTotales()
                End If
            Else
                MsgBox("Elija un motivo para la Nota de Crédito")
            End If
        Else
            MsgBox("El monto sobrepasa a la diferencia permitida")

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        frmAgregarCuentaNotas.formIni = "notacreditocompra"
        frmAgregarCuentaNotas.Show()
    End Sub

    Private Sub dgvLista_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvLista.RowsRemoved
        On Error Resume Next
        realizarSumasTotales()
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        On Error Resume Next
        calcularFactor()
    End Sub
    Public Sub calcularFactor()
        Dim dataIgv As New DataTable
        dataIgv = obj.nCrudListarBD("select * from igv", CadenaConexion)
        Dim total As Decimal = 0
        total = IIf((txtTotal.Text.Trim.Length > 0), txtTotal.Text, 0)

        Dim subTotal As Decimal
        subTotal = Format(total / (1 + (dataIgv.Rows(0)("valor").ToString) / 100), "#,##0.00")
        txtIgv.Text = total - subTotal
        txtMonto.Text = subTotal
        txtFactor.Text = 1
        If Decimal.Parse(txtTotal.Text.Trim) > 0 And txtTotal.Text.Trim.Length > 0 And txtTotal.Text.Trim <> "" Then
            factor = Decimal.Parse(txtTotalOc.Text.Trim) / Decimal.Parse(txtTotal.Text.Trim)
            'factor = Format(factor, "###0.00")
            If factor = 0 Then
                factor = 1
            End If
            txtFactor.Text = factor
        End If
    End Sub
    Private Sub txtTotal_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal.Leave
        txtTotal.Text = Format(CType(txtTotal.Text, Decimal), "###0.00")
    End Sub

    Private Sub txtSerie_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.Leave
        txtSerie.Text = txtSerie.Text.ToString.PadLeft(4, "0")
    End Sub
    Private Sub txtNumero_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.Leave
        txtNumero.Text = txtNumero.Text.ToString.PadLeft(4, "0")
    End Sub

    Private Sub cboMotivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMotivo.SelectedIndexChanged
        If iCarga = 1 Then
            If cboMotivo.Text.StartsWith("Anulaci") Then
                txtTotal.Enabled = False
            Else
                txtTotal.Enabled = True
            End If
            calcularFactor()
        End If
    End Sub
End Class