Imports Negocio
Imports Entidades
Public Class frmAbonoDeudasLetrasACobrar

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
    Private Sub frmAbonoDeudasLetrasACobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvComprobante.RowTemplate.Height = 30
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
            End With
        End If
    End Sub

    Private Sub realizarSumasTotales()
        Dim tDebe, tHaber, tDiferencia, tTotal As Decimal
        For Each row As DataGridViewRow In dgvComprobante.Rows
            tTotal += row.Cells("total").Value
        Next
        txtTotalComprobante.Text = Format(Decimal.Round(Decimal.Parse(tTotal), 2), "#,##0.00")
        'txtTotal.Text = Decimal.Parse(tTotal)
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

        data2 = obj.nCrudListarBD("select * from cajas_tipo_pago where id_caja='" & codCaja & "'", CadenaConexion)
        For Each row As DataRow In data2.Rows
            data3 = obj.nCrudListarBD("select * from tipo_pago where id='" & row.Item("id_tipo_pago") & "'", CadenaConexion)
            data.Rows.Add(data3.Rows(0)("id").ToString, data3.Rows(0)("descripcion").ToString)
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
        If dgvLista.Rows.Count > 0 Then
            txtMonto.Text = "0.00"
        Else
            Dim i As Integer
            i = dgvComprobante.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            txtMonto.Text = dgvComprobante.Rows(i).Cells("resta").Value
        End If
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
            dt = obj.nCrudListarBD("select * from asiento_letras where id_letra='" & idLetra & "' and cuenta like '123%'", CadenaConexion)
            Dim ctaLetra As String = ""
            ctaLetra = dt.Rows(0)("cuenta").ToString
            'AGREGANDO ASIENTOS CONTABLES
            dtDataAdd.Rows.Add(idLetra, txtCuentaCaja.Text.Trim, obtenerDatosCuenta(txtCuentaCaja.Text.Trim), txtMonto.Text.Trim, "0.00", dgvComprobante.Rows(i).Cells("serie").Value.ToString, dgvComprobante.Rows(i).Cells("numero").Value.ToString, cboTipo.SelectedValue.ToString, cboTipo.Text.Trim, txtNumero.Text.Trim, txtGlosa.Text.Trim)
            dtDataAdd.Rows.Add(idLetra, ctaLetra, obtenerDatosCuenta(ctaLetra), "0.00", txtMonto.Text.Trim, dgvComprobante.Rows(i).Cells("serie").Value.ToString, dgvComprobante.Rows(i).Cells("numero").Value.ToString, cboTipo.SelectedValue.ToString, cboTipo.Text.Trim, txtNumero.Text.Trim, txtGlosa.Text.Trim)
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
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim objAbono As New nAbonosPagos
        Dim entiAbono As New AbonoVentasEntity
        Dim entiConciliacion As New ConciliacionEntity
        Dim objLD As New nAsientoLibroDiario
        Dim entiLD As New ALDiarioEntity
        Dim i As Integer
        i = dgvComprobante.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        Dim idLetra As String = ""
        idLetra = dgvComprobante.Rows(i).Cells("id").Value

        For Each row As DataGridViewRow In dgvLista.Rows
            If Decimal.Parse(row.Cells("debe").Value) > 0 Then
                With entiAbono
                    .tipo_comprobante = "999"
                    .id_venta = idLetra
                    .id_caja = txtIdCaja.Text.Trim
                    .monto = Decimal.Parse(row.Cells("debe").Value)
                    .id_banco = txtIdBanco.Text.Trim
                    .tipo = row.Cells("id_tipo_pago").Value
                    .numero = row.Cells("operacion").Value
                    .descripcion = row.Cells("glosa").Value
                    .fecha = dtPago.Value
                    .estado = "1"
                    .tipo_abono = "NORMAL"
                End With
                MsgBox("COBRO DE LETRA: " & objAbono.nRegistrarAbonoVentasBD(entiAbono, CadenaConexion))
                'If cboTipo.SelectedValue.ToString <> "EF" Then
                '    Dim data As New DataTable
                '    data = obj.nCrudListarBD("select * from abono_pagos_ventas where id_venta='" & row.Cells("id_venta").Value.ToString & "' order by id desc")
                '    With entiConciliacion
                '        .id_abono = data.Rows(0)("id").ToString
                '        .concepto = txtGlosa.Text.Trim
                '        .tipo = cboTipo.SelectedValue.ToString
                '        .numero = txtNumero.Text.Trim
                '        .monto = Decimal.Parse(row.Cells("debe").Value)
                '        .verificador = "false"
                '        .fecha = dtPago.Value.ToString()
                '        .estado = "1"
                '    End With
                '    MsgBox("REGISTRO CONCILIACION: " & objCon.registrarConciliacion(entiConciliacion))
                'End If
            End If
            Dim idVenta As String = objAbono.nObtenerUltimoAbonoVenta(CadenaConexion)
            Dim dt As New DataTable
            dt = obj.nCrudListarBD("select c.id,c.num_dni from comprobante_venta c inner join canje_letra l on c.id=l.id_comprobante where l.id='" & dgvComprobante.Rows(i).Cells("id").Value & "'", CadenaConexion)
            Dim EntiAsientoAboVenta As New AbonoComprasEntity
            With EntiAsientoAboVenta
                .id = idVenta
                .id_cliente = dt.Rows(0)("num_dni").ToString
                .id_compra = idLetra
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
            objAbono.nRegistrarAsientoAbonoVentas(EntiAsientoAboVenta, CadenaConexion)

            'With entiLD
            '    .id_comprobante = row.Cells("id_venta").Value.ToString
            '    .cuo = "CUO"
            '    .fecha_operacion = dtPago.Value
            '    .glosa = "PAGO - " & txtGlosa.Text.Trim
            '    .cod_libro = row.Cells("num_cuenta").Value.ToString
            '    .numero_correlativo = "NUM. CORRELATIVO"
            '    .numero_documento = "NUM. DOC."
            '    .cuenta = row.Cells("num_cuenta").Value.ToString
            '    .denominacion = .glosa
            '    .debe = row.Cells("debe").Value.ToString
            '    .haber = row.Cells("haber").Value.ToString
            'End With
            'MsgBox("REGISTRO LIBRO DIARIO: " & objLD.registrarAsientoLibroDiario(entiLD))
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmListaEntradasSalidasBancos.Show()
    End Sub

    Private Sub btnCaja_Click(sender As Object, e As EventArgs) Handles btnCaja.Click
        frmEscogerCaja.formInicio = "abonoLetraVenta"
        frmEscogerCaja.Show()
    End Sub
    Private Sub txtMonto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.Leave
        txtMonto.Text = Format(CType(txtMonto.Text, Decimal), "###0.00")
    End Sub
End Class