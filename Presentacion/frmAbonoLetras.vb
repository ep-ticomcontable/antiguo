Imports Negocio
Imports Entidades
Public Class frmAbonoLetras

    Dim obj As New nCrud
    Dim objTDA As New nTipoDocumentoAsiento
    Dim objAC As New nAsientosContables
    Public codComprobante As Integer = 0
    Public codTipoComprobante As Integer = 0
    Public dataComprobante As New DataTable
    Dim tipoOperacion As Integer = 5 'DEVOLUCIONES
    Dim objCV As New nComprobanteVenta
    Dim id_comprobante As String
    Dim objCon As New nConciliacion
    Dim dtDataAdd As New DataTable
    Dim iCarga As Integer = 0
    Public tipoProceso As String = ""

    Private Sub cargarTipoMovimientos()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add("CH", "Cheque")
        data.Rows.Add("TB", "Transferencia Bancaria")
        data.Rows.Add("DB", "Depósito Bancario")
        data.Rows.Add("EF", "Efectivo")

        With cboTipo
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub
    Public Sub cargarDatosComprobante()
        dgvComprobante.DataSource = dataComprobante
        realizarSumasTotales()
    End Sub
    Private Sub frmAbonoLetrasPorPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If tipoProceso = "COMPRA" Then
            Me.Text = "PAGO DE LETRA - COMPRAS"
            lblTitulo.Text = "PAGO DE LETRA"
        Else
            Me.Text = "COBRO DE LETRA - VENTAS"
            lblTitulo.Text = "COBRO DE LETRA"
        End If
        dgvComprobante.RowTemplate.Height = 40
        cebrasDatagrid(dgvComprobante, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        dgvLista.RowTemplate.Height = 27
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        cargarTipoPagos("1")
        cargarTipoMovimientos()
        realizarSumasTotales()
        iCarga = 1
        If iCarga = 1 Then

            With dtDataAdd.Columns
                .Add("id_letra")
                .Add("num_cuenta")
                .Add("desc_cuenta")
                .Add("debe")
                .Add("haber")
                .Add("serie")
                .Add("numero")
                .Add("id_tipo_pago")
                .Add("tipo_pago")
                .Add("operacion")
                .Add("glosa")
                .Add("id_caja")
                .Add("id_banco")
            End With
        End If
    End Sub

    Private Sub realizarSumasTotales()
        Dim tDebe, tHaber, tDiferencia, tTotal As Decimal
        For Each row As DataGridViewRow In dgvComprobante.Rows
            tTotal += row.Cells("total").Value
        Next
        txtTotalComprobante.Text = Format(Decimal.Round(Decimal.Parse(tTotal), 2), "#,##0.00")
        txtMonto.Text = txtTotalComprobante.Text
        For Each row As DataGridViewRow In dgvLista.Rows
            tDebe += row.Cells("debe").Value
            tHaber += row.Cells("haber").Value
        Next
        tDiferencia = tDebe - tHaber

        txtTDebeS.Text = Format(tDebe, "#,##0.00")
        txtTHaberS.Text = Format(tHaber, "#,##0.00")
        txtDiferenciaS.Text = Format(tDiferencia, "#,##0.00")
        lblTotalReg.Text = dgvComprobante.Rows.Count
    End Sub

    Public Sub cargarTipoPagos(codCaja As String)
        Dim data, data2, data3 As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        'data.Rows.Add(0, "SIN AFECTO")

        Dim dt As New DataTable
        dt = obj.nCrudListarBD("select * from caja_configuracion where id='" & codCaja & "'", CadenaConexion)
        If dt.Rows(0)("tipo").ToString.StartsWith("PRIN") Then
            data2 = obj.nCrudListarBD("select * from tipo_pago where estado='2'", CadenaConexion)
        Else
            data2 = obj.nCrudListarBD("select * from tipo_pago where estado='3'", CadenaConexion)
        End If
        For Each row As DataRow In data2.Rows
            data.Rows.Add(row.Item("id").ToString, row.Item("descripcion").ToString)
        Next
        With cboTipo
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub
    Private Sub dgvComprobante_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvComprobante.SelectionChanged
        On Error Resume Next
        'reseteando datos
        lblCaja.Text = "[Nombre de la caja]"
        'If dgvLista.Rows.Count > 0 Then
        '    txtMonto.Text = "0.00"
        'Else
        Dim i As Integer
        i = dgvComprobante.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        txtMonto.Text = dgvComprobante.Rows(i).Cells("resta").Value
        'End If
        txtNumero.Text = "0"
        txtGlosa.Text = "-"
        txtIdCaja.Text = "0"
        txtCuentaCaja.Text = "0"
        txtIdBanco.Text = "0"
        cargarTipoPagos(1)
    End Sub
    Private Sub dgvLista_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLista.CellValueChanged
        On Error Resume Next
        If iCarga = 1 Then
            realizarSumasTotales()
        End If
    End Sub
    Private Sub dgvLista_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvLista.RowsRemoved
        On Error Resume Next
        If iCarga = 1 Then
            realizarSumasTotales()
        End If
    End Sub
    Private Sub btnAbonar_Click(sender As Object, e As EventArgs) Handles btnAbonar.Click
        Dim i As Integer
        i = dgvComprobante.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        Dim idLetra As String = ""
        idLetra = dgvComprobante.Rows(i).Cells("id").Value
        If idLetra <> "0" Then
            'Detectar que cuenta de letra es
            Dim dt As New DataTable
            If tipoProceso = "COMPRA" Then
                dt = obj.nCrudListarBD("select * from asiento_letras where id_letra='" & idLetra & "' and cuenta like '423%'", CadenaConexion)
            Else
                dt = obj.nCrudListarBD("select * from asiento_letras where id_letra='" & idLetra & "' and cuenta like '123%'", CadenaConexion)
            End If
            Dim ctaLetra As String = ""
            ctaLetra = dt.Rows(0)("cuenta").ToString
            'AGREGANDO ASIENTOS CONTABLES
            dtDataAdd.Rows.Add(idLetra, ctaLetra, obtenerDatosCuenta(ctaLetra), txtMonto.Text.Trim, "0.00", dgvComprobante.Rows(i).Cells("serie").Value.ToString, dgvComprobante.Rows(i).Cells("numero").Value.ToString, cboTipo.SelectedValue.ToString, cboTipo.Text.Trim, txtNumero.Text.Trim, txtGlosa.Text.Trim, txtIdCaja.Text, txtIdBanco.Text)
            dtDataAdd.Rows.Add(idLetra, txtCuentaCaja.Text.Trim, obtenerDatosCuenta(txtCuentaCaja.Text.Trim), "0.00", txtMonto.Text.Trim, dgvComprobante.Rows(i).Cells("serie").Value.ToString, dgvComprobante.Rows(i).Cells("numero").Value.ToString, cboTipo.SelectedValue.ToString, cboTipo.Text.Trim, txtNumero.Text.Trim, txtGlosa.Text.Trim, txtIdCaja.Text, txtIdBanco.Text)
            dgvLista.DataSource = dtDataAdd
            seleccionarCodigoDeVenta(ctaLetra)
        End If
        realizarSumasTotales()
    End Sub
    Private Sub seleccionarCodigoDeVenta(cuenta As String)
        For i As Integer = 0 To dgvLista.Rows.Count - 1
            For x As Integer = 0 To dgvLista.ColumnCount - 1
                If dgvLista.Rows(i).Cells("num_cuenta").Value.ToString = cuenta Then
                    dgvLista.CurrentCell = dgvLista.Rows(i).Cells("num_cuenta")
                End If
            Next
        Next
    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = obj.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function
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
        If verificarPartidaDoble() = True Then
            Dim objAbono As New nAbonosPagos
            Dim entiAbono As New AbonoComprasEntity
            Dim entiAbonoVenta As New AbonoVentasEntity
            Dim entiConciliacion As New ConciliacionEntity
            Dim objLD As New nAsientoLibroDiario
            Dim entiLD As New ALDiarioEntity
            Dim i As Integer
            i = dgvComprobante.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            Dim idLetra As String = ""
            idLetra = dgvComprobante.Rows(i).Cells("id").Value
            If tipoProceso = "COMPRA" Then
                For Each row As DataGridViewRow In dgvLista.Rows
                    'If Decimal.Parse(row.Cells("debe").Value) > 0 Then
                    '    With entiAbono
                    '        .tipo_comprobante = "COMPRA"
                    '        .id_compra = codComprobante
                    '        .id_caja = row.Cells("id_caja").Value.ToString
                    '        .monto = Decimal.Parse(row.Cells("debe").Value)
                    '        .id_banco = row.Cells("id_banco").Value.ToString
                    '        .tipo = row.Cells("id_tipo_pago").Value
                    '        .numero = row.Cells("operacion").Value
                    '        .descripcion = row.Cells("glosa").Value
                    '        .fecha = dtPago.Value
                    '        .estado = "1"
                    '    End With
                    '    objAbono.nRegistrarAbonoComprasBD(entiAbono, CadenaConexion)
                    'End If
                    Dim idVenta As String = objAbono.nObtenerUltimoAbonoCompraBD(CadenaConexion)
                    Dim dt As New DataTable
                    dt = obj.nCrudListarBD("select c.id,c.num_dni from comprobante_compra c inner join canje_letra l on c.id=l.id_comprobante where l.id='" & dgvComprobante.Rows(i).Cells("id").Value & "'", CadenaConexion)
                    Dim EntiAsientoAboVenta As New AbonoComprasEntity
                    With EntiAsientoAboVenta
                        .id = idVenta
                        .id_cliente = dt.Rows(0)("num_dni").ToString
                        .id_compra = codComprobante
                        .cuenta = row.Cells("num_cuenta").Value.ToString
                        .base_imponible = Decimal.Parse(row.Cells("debe").Value.ToString) + Decimal.Parse(row.Cells("haber").Value.ToString)
                        .nro_detraccion = "0"
                        .tipo_tasa_detraccion = "LETRA"
                        .valor_tasa = "0"
                        .valor_detraccion = "0"
                        .fecha_detraccion = dtPago.Value.ToString("yyyy/MM/dd")
                        .monto = txtMonto.Text.Trim
                        .tipo = row.Cells("id_tipo_pago").Value.ToString
                        .descripcion = row.Cells("glosa").Value.ToString
                        .debe = row.Cells("debe").Value.ToString
                        .haber = row.Cells("haber").Value.ToString
                        .fecha = dtPago.Value.ToString("yyyy/MM/dd")
                    End With
                    objAbono.nRegistrarAsientoAbonoComprasBD(EntiAsientoAboVenta, CadenaConexion)
                Next
            Else
                For Each row As DataGridViewRow In dgvLista.Rows
                    If Decimal.Parse(row.Cells("debe").Value) > 0 Then
                        With entiAbonoVenta
                            .tipo_comprobante = "999"
                            .id_venta = codComprobante
                            .id_caja = row.Cells("id_caja").Value.ToString
                            .monto = Decimal.Parse(row.Cells("debe").Value)
                            .id_banco = row.Cells("id_banco").Value.ToString
                            .tipo = row.Cells("id_tipo_pago").Value
                            .numero = row.Cells("operacion").Value
                            .descripcion = row.Cells("glosa").Value
                            .fecha = dtPago.Value
                            .estado = "1"
                            .tipo_abono = "NORMAL"
                        End With
                        objAbono.nRegistrarAbonoVentasBD(entiAbonoVenta, CadenaConexion)
                    End If
                    Dim idVenta As String = objAbono.nObtenerUltimoAbonoVentaBD(CadenaConexion)
                    Dim dt As New DataTable
                    dt = obj.nCrudListarBD("select c.id,c.num_dni from comprobante_venta c inner join canje_letra l on c.id=l.id_comprobante where l.id='" & dgvComprobante.Rows(i).Cells("id").Value & "'", CadenaConexion)
                    Dim EntiAsientoAboVenta As New AbonoComprasEntity
                    With EntiAsientoAboVenta
                        .id = idVenta
                        .id_cliente = dt.Rows(0)("num_dni").ToString
                        .id_compra = codComprobante
                        .cuenta = row.Cells("num_cuenta").Value.ToString
                        .base_imponible = Decimal.Parse(row.Cells("debe").Value.ToString) + Decimal.Parse(row.Cells("haber").Value.ToString)
                        .nro_detraccion = "0"
                        .tipo_tasa_detraccion = "LETRA"
                        .valor_tasa = "0"
                        .valor_detraccion = "0"
                        .fecha_detraccion = dtPago.Value.ToString("yyyy/MM/dd")
                        .monto = txtMonto.Text.Trim
                        .tipo = row.Cells("id_tipo_pago").Value.ToString
                        .descripcion = row.Cells("glosa").Value.ToString
                        .debe = row.Cells("debe").Value.ToString
                        .haber = row.Cells("haber").Value.ToString
                        .fecha = dtPago.Value.ToString("yyyy/MM/dd")
                        .estado = 1
                    End With
                    objAbono.nRegistrarAsientoAbonoVentasBD(EntiAsientoAboVenta, CadenaConexion)
                Next
            End If

            'ACTUALIZAR ESTADO DE LETRA
            'If entiAbonoVenta.monto = Decimal.Parse(dgvComprobante.Rows(i).Cells("resta").Value) Then
            obj.nCrudActualizarBD("@", "canje_letra", "estado_deuda", "CANCELADO", "id='" & idLetra & "'", CadenaConexion)
            'End If
            If tipoProceso = "COMPRA" Then
                frmListaLetrasPorPagar.realizarConsulta()
                frmListaLetrasPorPagar.Refresh()
                frmListaLetrasPorPagar.seleccionarCodigoDeVenta(idLetra)
            Else
                frmListaLetrasPorCobrar.realizarConsulta()
                frmListaLetrasPorCobrar.Refresh()
            End If
            MsgBox("ABONO REALIZADO CON ÉXITO")
            Me.Close()
        End If
    End Sub


    Private Sub btnCaja_Click(sender As Object, e As EventArgs) Handles btnCaja.Click
        Me.Enabled = False
        frmEscogerCaja.formInicio = "abonoLetraCompra"
        frmEscogerCaja.Show()
        Me.Enabled = True
    End Sub
    Private Sub txtMonto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.Leave
        txtMonto.Text = Format(CType(txtMonto.Text, Decimal), "###0.00")
    End Sub
    Private Sub dgvOperaciones_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLista.CellValueChanged
        On Error Resume Next
        realizarSumasTotales()
    End Sub

    Private Sub dgvOperaciones_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvLista.RowsRemoved
        On Error Resume Next
        realizarSumasTotales()
    End Sub
End Class