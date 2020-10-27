Imports Negocio
Imports Entidades
Public Class frmNuevaNotaCreditoVenta

    Dim obj As New nCrud
    Dim objTDA As New nTipoDocumentoAsiento
    Dim objAC As New nAsientosContables
    Public codComprobante As Integer = 0
    Public codTipoComprobante As Integer = 0
    Dim objNCD As New nNotaCreditoDebito
    Dim tipoOperacion As Integer = 5 'DEVOLUCIONES
    Dim objCV As New nComprobanteVenta

    Public Sub cargarDatosComprobante()
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from comprobante_venta where id='" & codComprobante & "'", CadenaConexion)
        With data
            cboTipoDocumento.SelectedValue = .Rows(0)("id_tipo_comprobante").ToString
            txtSerie.Text = .Rows(0)("serie_comprobante").ToString
            txtNumero.Text = .Rows(0)("numero_comprobante").ToString
            dtFecha.Value = .Rows(0)("fec_emision").ToString
            txtRuc.Text = .Rows(0)("num_dni").ToString
            txtRazon.Text = .Rows(0)("razon_social").ToString
            txtMonto.Text = .Rows(0)("base_imponible").ToString
            txtIgv.Text = .Rows(0)("valor_igv").ToString
            txtTotal.Text = .Rows(0)("total").ToString
            'txtGlosa.Text = .Rows(0)("glosa").ToString
        End With
        realizarSumasTotales()
    End Sub
    Private Sub cargarTipoDocumento()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = objTDA.nListarCuentasSegunTipoAsiento(1)
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
    Private Sub cargarRegistroCuentas(codigoComprobante)
        If dgvLista.RowCount = 0 Then
            Dim dtItem As New DataTable
            With dtItem.Columns
                .Add("id")
                .Add("id_asiento_venta")
                .Add("num_cuenta")
                .Add("desc_cuenta")
                .Add("debe")
                .Add("haber")
            End With
            Dim data As New DataTable
            data = obj.nCrudListarBD("usp_cuentaComprobanteVenta '" & codigoComprobante & "','70'", CadenaConexion)

            Dim dataParam As New DataTable
            dataParam = obj.nCrudListarBD("usp_parametrosNotaCreditoDebito '" & tipoOperacion & "','70'", CadenaConexion)

            dtItem.Rows.Add(data.Rows(0)("id").ToString, data.Rows(0)("id_asiento_venta").ToString, _
                            dataParam.Rows(0)("num_cuenta").ToString, _
                            dataParam.Rows(0)("desc_cuenta").ToString, _
                            data.Rows(0)("debe").ToString, _
                            data.Rows(0)("haber").ToString)
            dgvLista.DataSource = dtItem
        End If

        Dim dataParam1 As New DataTable
        dataParam1 = obj.nCrudListarBD("usp_parametrosNotaCreditoDebito '" & tipoOperacion & "','40'", CadenaConexion)

        Dim data2 As New DataTable
        data2 = obj.nCrudListarBD("usp_cuentaComprobanteVenta '" & codigoComprobante & "','40'", CadenaConexion)
        Dim dt As DataTable = DirectCast(dgvLista.DataSource, DataTable)
        Dim row As DataRow = dt.NewRow()
        row.Item(0) = data2.Rows(0)("id").ToString
        row.Item(1) = data2.Rows(0)("id_asiento_venta").ToString
        row.Item(2) = dataParam1.Rows(0)("num_cuenta").ToString
        row.Item(3) = dataParam1.Rows(0)("desc_cuenta").ToString
        row.Item(4) = data2.Rows(0)("debe").ToString
        row.Item(5) = data2.Rows(0)("haber").ToString
        dt.Rows.Add(row)


        'Dim dataParam2 As New DataTable
        'dataParam2 = obj.nCrudListarBD("usp_parametrosNotaCreditoDebito '" & tipoOperacion & "','12'")
        'Dim data3 As New DataTable
        'data3 = obj.nCrudListarBD("usp_cuentaComprobanteVenta '" & codigoComprobante & "','12'")
        'Dim dt2 As DataTable = DirectCast(dgvLista.DataSource, DataTable)
        'Dim row2 As DataRow = dt2.NewRow()
        'row2.Item(0) = data3.Rows(0)("id").ToString
        'row2.Item(1) = data3.Rows(0)("id_asiento_venta").ToString
        'row2.Item(2) = dataParam2.Rows(0)("num_cuenta").ToString
        'row2.Item(3) = dataParam2.Rows(0)("desc_cuenta").ToString
        'row2.Item(4) = data3.Rows(0)("debe").ToString
        'row2.Item(5) = data3.Rows(0)("haber").ToString
        'dt2.Rows.Add(row2)

        'Dim data4 As New DataTable
        'data4 = obj.nCrudListarBD("usp_cuentaComprobanteVenta '" & codigoComprobante & "','20'")
        'Dim dt3 As DataTable = DirectCast(dgvLista.DataSource, DataTable)
        'Dim row3 As DataRow = dt3.NewRow()
        'row3.Item(0) = data4.Rows(0)("id").ToString
        'row3.Item(1) = data4.Rows(0)("id_asiento_venta").ToString
        'row3.Item(2) = data4.Rows(0)("num_cuenta").ToString
        'row3.Item(3) = data4.Rows(0)("desc_cuenta").ToString
        'row3.Item(4) = data4.Rows(0)("debe").ToString
        'row3.Item(5) = data4.Rows(0)("haber").ToString
        'dt3.Rows.Add(row3)

        'Dim data5 As New DataTable
        'data5 = obj.nCrudListarBD("usp_cuentaComprobanteVenta '" & codigoComprobante & "','69'")
        'Dim dt4 As DataTable = DirectCast(dgvLista.DataSource, DataTable)
        'Dim row4 As DataRow = dt4.NewRow()
        'row4.Item(0) = data5.Rows(0)("id").ToString
        'row4.Item(1) = data5.Rows(0)("id_asiento_venta").ToString
        'row4.Item(2) = data5.Rows(0)("num_cuenta").ToString
        'row4.Item(3) = data5.Rows(0)("desc_cuenta").ToString
        'row4.Item(4) = data5.Rows(0)("debe").ToString
        'row4.Item(5) = data5.Rows(0)("haber").ToString
        'dt4.Rows.Add(row4)
    End Sub
    Private Sub cargarSerieNumero()
        Dim dt As New DataTable
        dt = obj.nCrudListarBD("select * from comprobante_nota_credito where tipo='VENTA' order by fec_emision desc", CadenaConexion)
        If dt.Rows.Count > 0 Then
            txtSerieN.Text = dt.Rows(0)("serie").ToString
            txtNumeroN.Text = (Integer.Parse(dt.Rows(0)("numero").ToString) + 1).ToString.PadLeft(4, "0")
        End If
    End Sub
    Private Sub frmNuevaNotaCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTipoDocumento()
        cargarMotivos()
        cargarSerieNumero()
        If codComprobante > 0 Then
            'cargarRegistroCuentas(codComprobante)
        End If
        dgvLista.RowTemplate.Height = 30
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
    End Sub

    'Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If e.KeyChar = Convert.ToChar(Keys.Enter) Then
    '        If txtCuenta.Text.Trim.Length >= 2 Then
    '            With frmEscogerPlanContable
    '                .formInicio = "notacredito"
    '                .cuentaInicio = txtCuenta.Text.Trim
    '                .ShowDialog()
    '            End With
    '        End If
    '    End If
    'End Sub

    Private Sub btnRuc_Click(sender As Object, e As EventArgs) Handles btnRuc.Click
        frmConsultaSunat.formInicio = "notacredito"
        frmConsultaSunat.ShowDialog()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim entiNCD As New ComprobanteNotaCreditoDebito
        With entiNCD
            .id = codComprobante
            .tipo = "VENTA"
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
        'MsgBox(objNCD.registrarNotaCreditoBD(entiNCD, CadenaConexion))
        objNCD.registrarNotaCreditoBD(entiNCD, CadenaConexion)
        Dim entiCVenta, entiCabVent As New ComprobanteVentaEntity
        With entiCabVent
            .numero_cuo = objAC.nObtenerNumeroCUO()
            .numero_maquina = "-"
            .tipo_venta = "NOTA CREDITO"
            .id_gravado = "1"
            .marca = "0@0"
            .centro = "0"
            .id_tipo_comprobante = "8"
            .fec_emision = dtFechaEmision.Value
            .fec_pago = dtFechaEmision.Value
            .serie_comprobante = txtSerieN.Text
            .numero_comprobante = txtNumeroN.Text
            .cod_dni = "6"
            .num_dni = txtRuc.Text.Trim
            .razon_social = txtRazon.Text.Trim
            .glosa = txtComentarios.Text.Trim
            .valor_facturado = "-" & txtMonto.Text.Trim
            .base_imponible = "-" & txtMonto.Text.Trim
            .valor_exonerado = 0
            .valor_inafecto = 0
            .valor_isc = 0
            .valor_igv = "-" & txtIgv.Text.Trim
            .otros_base_imponible = 0
            .total = "-" & txtTotal.Text.Trim
            .id_moneda = "115"
            .tipo_cambio = "1.00"
            .fec_comp_origen = dtFecha.Value
            .tip_comp_origen = cboTipoDocumento.SelectedValue.ToString
            .serie_comp_origen = txtSerie.Text.Trim
            .numero_comp_origen = txtNumero.Text.Trim
            .estado = 1
            .estado_comprobante = "F"
        End With
        'MsgBox("REGISTRAR COMPROBANTE DE VENTA: " & objCV.nRegistrarComprobanteVentaBD(entiCabVent, CadenaConexion))
        objCV.nRegistrarComprobanteVentaBD(entiCabVent, CadenaConexion)

        Dim idNC As String
        idNC = objNCD.obtenerIdNotaCreditoBD(CadenaConexion)

        For Each row As DataGridViewRow In dgvLista.Rows
            With entiNCD
                .id_nota_credito = idNC
                .cuenta = row.Cells("num_cuenta").Value
                .debe = row.Cells("debe").Value
                .haber = row.Cells("haber").Value
            End With
            'MsgBox(objNCD.registrarAsientoNotaCreditoBD(entiNCD, CadenaConexion))
            objNCD.registrarAsientoNotaCreditoBD(entiNCD, CadenaConexion)
        Next
        MsgBox("LA NOTA DE CREDITO PARA VENTA HA SIDO GUARDADA CON ÉXITO")
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        frmAgregarCuentaNotas.formIni = "notacreditoventa"
        frmAgregarCuentaNotas.Show()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        If cboMotivo.SelectedValue <> 0 Then
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
                data = obj.nCrudListarBD("usp_cuentaComprobanteVenta '" & codComprobante & "','70'", CadenaConexion)

                If dataParam.Rows(0)("cuenta_venta").ToString = "-" Then
                    Dim dtV As New DataTable
                    dtV = obj.nCrudListarBD("usp_cuentasContablesComprobanteVenta '" & codComprobante & "'", CadenaConexion)
                    For Each fila As DataRow In dtV.Rows
                        dtItem.Rows.Add(fila.Item("id").ToString, fila.Item("id_asiento_venta").ToString, _
                fila.Item("num_cuenta").ToString, _
                obtenerDatosCuenta(fila.Item("num_cuenta").ToString), _
               fila.Item("debe").ToString, _
                 fila.Item("haber").ToString)
                    Next
                Else
                    dtItem.Rows.Add(data.Rows(0)("id").ToString, data.Rows(0)("id_asiento_venta").ToString, _
                dataParam.Rows(0)("cuenta_venta").ToString, _
                obtenerDatosCuenta(dataParam.Rows(0)("cuenta_venta").ToString), _
               data.Rows(0)("debe").ToString, _
                 txtMonto.Text.Trim)
                End If
                dgvLista.DataSource = dtItem
            End If

            If dataParam.Rows(0)("cuenta_venta").ToString <> "-" Then
                Dim dataParam1 As New DataTable
                dataParam1 = obj.nCrudListarBD("usp_parametrosNotaCreditoDebito '" & tipoOperacion & "','40'", CadenaConexion)
                Dim data2 As New DataTable
                data2 = obj.nCrudListarBD("usp_cuentaComprobanteVenta '" & codComprobante & "','40'", CadenaConexion)
                Dim dt As DataTable = DirectCast(dgvLista.DataSource, DataTable)
                Dim row As DataRow = dt.NewRow()
                row.Item(0) = data2.Rows(0)("id").ToString
                row.Item(1) = data2.Rows(0)("id_asiento_venta").ToString
                row.Item(2) = dataParam1.Rows(0)("num_cuenta").ToString
                row.Item(3) = dataParam1.Rows(0)("desc_cuenta").ToString
                row.Item(4) = "0.00"
                row.Item(5) = txtIgv.Text.Trim
                dt.Rows.Add(row)

                Dim dataParam3 As New DataTable
                dataParam3 = obj.nCrudListarBD("usp_parametrosNotaCreditoDebito '" & tipoOperacion & "','40'", CadenaConexion)
                Dim data3 As New DataTable
                data3 = obj.nCrudListarBD("usp_cuentaComprobanteVenta '" & codComprobante & "','12'", CadenaConexion)
                Dim dt3 As DataTable = DirectCast(dgvLista.DataSource, DataTable)
                Dim row3 As DataRow = dt3.NewRow()
                row3.Item(0) = data3.Rows(0)("id").ToString
                row3.Item(1) = data3.Rows(0)("id_asiento_venta").ToString
                row3.Item(2) = data3.Rows(0)("num_cuenta").ToString
                row3.Item(3) = data3.Rows(0)("desc_cuenta").ToString
                row3.Item(4) = txtTotal.Text.Trim
                row3.Item(5) = "0.00"
                dt3.Rows.Add(row3)
            End If
            realizarSumasTotales()
        Else
            MsgBox("Elija un motivo para la Nota de Crédito")
        End If

    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = obj.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function
    Public Sub agregarCuenta(numcuenta, desccuenta, debe, haber)
        Dim dt As DataTable = DirectCast(dgvLista.DataSource, DataTable)
        Dim row As DataRow = dt.NewRow()
        row.Item(0) = "0"
        row.Item(1) = codComprobante
        row.Item(2) = numcuenta
        row.Item(3) = desccuenta
        row.Item(4) = haber
        row.Item(5) = debe
        dt.Rows.Add(row)
        seleccionarCuentaAdicionada(numcuenta)
        realizarSumasTotales()
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


    Private Sub btnBuscarComprobante_Click(sender As Object, e As EventArgs) Handles btnBuscarComprobante.Click
        cargarComprobante()
    End Sub

    Private Sub cargarComprobante()
        Dim numero As String = txtNumero.Text.Trim
        Dim serie As String = txtSerie.Text.Trim
        Dim data As New DataTable
        data = objNCD.comprobanteVentaPorSerieNumero(serie, numero)

        If data.Rows.Count > 0 Then
            With data
                cboTipoDocumento.SelectedValue = .Rows(0)("id_tipo_comprobante").ToString
                dtFecha.Value = .Rows(0)("fec_emision").ToString
                txtRuc.Text = .Rows(0)("num_dni").ToString
                txtRazon.Text = .Rows(0)("razon_social").ToString
                txtMonto.Text = .Rows(0)("base_imponible").ToString
                txtIgv.Text = .Rows(0)("valor_igv").ToString
                txtTotal.Text = .Rows(0)("total").ToString
                codComprobante = .Rows(0)("id").ToString
            End With
            cargarRegistroCuentas(codComprobante)
            realizarSumasTotales()
        Else
            MsgBox("No se han encontrado resultados con el comprobante de compra ingresado...")
        End If

    End Sub

    Private Sub realizarSumasTotales()
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

    Private Sub dgvLista_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvLista.RowsRemoved
        On Error Resume Next
        realizarSumasTotales()
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        Dim dataIgv As New DataTable
        dataIgv = obj.nCrudListarBD("select * from igv", CadenaConexion)
        Dim total As Decimal = 0
        total = IIf((txtTotal.Text.Trim.Length > 0), txtTotal.Text, 0)

        Dim subTotal As Decimal
        subTotal = Format(total / (1 + (dataIgv.Rows(0)("valor").ToString) / 100), "#,##0.00")
        txtIgv.Text = total - subTotal
        txtMonto.Text = subTotal
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
End Class