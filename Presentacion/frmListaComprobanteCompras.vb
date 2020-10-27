Imports Negocio
Imports System.IO
Imports Entidades

Public Class frmListaComprobanteCompras
    Dim obj As New nCrud
    Dim iCarga As Integer = 0
    Dim filaTable As New DataTable
    Dim codPLECompra As String = "080100"
    Dim anioPeriodo As String = ""
    Dim mesPeriodo As String = ""
    Dim lista As New DataTable
    Public anexo As Boolean = False
    Private Function codigoComprobante() As String
        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        Dim idComprobante As String = ""
        idComprobante = dgvLista.Rows(f).Cells("id").Value.ToString
        Return idComprobante
    End Function
    Private Function codigoTipoComprobante() As String
        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        Dim idComprobante As String = ""
        idComprobante = dgvLista.Rows(f).Cells("id_tipo_comprobante").Value
        Return idComprobante
    End Function
    Private Sub cargarPeriodos()
        Dim dataAnio As New DataTable
        dataAnio.Columns.Add("codigo")
        dataAnio.Columns.Add("descripcion")
        dataAnio.Rows.Add(0, "SELECCIONE")
        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select year(fec_emision) as anio from comprobante_compra group by year(fec_emision)", CadenaConexion)
            For Each row As DataRow In data2.Rows
                dataAnio.Rows.Add(row.Item("anio").ToString, row.Item("anio").ToString)
            Next
            With cboAnio
                .DataSource = dataAnio
                .ValueMember = "codigo"
                .DisplayMember = "descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar los Años")
        End Try

        Dim dataMes As New DataTable
        dataMes.Columns.Add("codigo")
        dataMes.Columns.Add("descripcion")
        dataMes.Rows.Add(0, "SELECCIONE")
        Dim data3 As DataTable
        Try
            data3 = obj.nCrudListarBD("select month(fec_emision) as mes from comprobante_compra group by month(fec_emision) order by month(fec_emision)", CadenaConexion)
            For Each row As DataRow In data3.Rows
                Select Case row.Item("mes").ToString
                    Case "1"
                        dataMes.Rows.Add(row.Item("mes").ToString, "ENERO")
                    Case "2"
                        dataMes.Rows.Add(row.Item("mes").ToString, "FEBRERO")
                    Case "3"
                        dataMes.Rows.Add(row.Item("mes").ToString, "MARZO")
                    Case "4"
                        dataMes.Rows.Add(row.Item("mes").ToString, "ABRIL")
                    Case "5"
                        dataMes.Rows.Add(row.Item("mes").ToString, "MAYO")
                    Case "6"
                        dataMes.Rows.Add(row.Item("mes").ToString, "JUNIO")
                    Case "7"
                        dataMes.Rows.Add(row.Item("mes").ToString, "JULIO")
                    Case "8"
                        dataMes.Rows.Add(row.Item("mes").ToString, "AGOSTO")
                    Case "9"
                        dataMes.Rows.Add(row.Item("mes").ToString, "SEPTIEMBRE")
                    Case "10"
                        dataMes.Rows.Add(row.Item("mes").ToString, "OCTUBRE")
                    Case "11"
                        dataMes.Rows.Add(row.Item("mes").ToString, "NOVIEMBRE")
                    Case "12"
                        dataMes.Rows.Add(row.Item("mes").ToString, "DICIEMBRE")
                End Select
            Next
            With cboMes
                .DataSource = dataMes
                .ValueMember = "codigo"
                .DisplayMember = "descripcion"
            End With
            data3.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar los Meses")
        End Try
    End Sub
    Private Sub cargarTipo()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(1, "DNI/RUC")
        data.Rows.Add(2, "RAZÓN SOCIAL")
        data.Rows.Add(3, "N° COMPROBANTE")
        data.Rows.Add(4, "CRÉDITO")
        data.Rows.Add(5, "CONTADO")
        data.Rows.Add(6, "FINALIZADAS")
        data.Rows.Add(7, "PENDIENTES")
        data.Rows.Add(8, "LETRA POR PAGAR")

        With cboTipo
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub
    Private Function querysPorCombinacion() As String
        Dim query As String = ""
        Dim queryRangoFechas As String = ""
        query = "select * from vista_compras_con_abonos where tipo_compra not like 'NOTA%' and 1=1 "
        ''COMBINACION DE "BUSCAR POR"
        'If cboTipo.SelectedValue.ToString = "1" And txtDato.Text.Trim.Length > 1 Then
        '    query += "and num_dni like '" & txtDato.Text.Trim & "%' "
        'ElseIf cboTipo.SelectedValue.ToString = "2" And txtDato.Text.Trim.Length > 1 Then
        '    query += "and razon_social like '" & txtDato.Text.Trim & "%' "
        'ElseIf cboTipo.SelectedValue.ToString = "3" And txtDato.Text.Trim.Length > 1 Then
        '    query += "and numero like '" & txtDato.Text.Trim & "%' "
        'ElseIf cboTipo.SelectedValue.ToString = "4" Then
        '    query += "and tipo_compra='CREDITO' "
        'ElseIf cboTipo.SelectedValue.ToString = "5" Then
        '    query += "and tipo_compra='CONTADO' "
        'ElseIf cboTipo.SelectedValue.ToString = "8" Then
        '    query += "and tipo_compra='LETRA POR PAGAR' "
        'ElseIf cboTipo.SelectedValue.ToString = "6" Then
        '    query += "and estado='FINALIZADO' "
        'ElseIf cboTipo.SelectedValue.ToString = "7" Then
        '    query += "and estado='PENDIENTE' "
        'Else
        '    query += ""
        'End If
        'FIN COMBINACION DE "BUSCAR POR"

        'COMBINACION DE "MONEDAS"
        If chkSoles.Checked = True And chkDolares.Checked = False Then
            query += "and moneda='PEN' "
        ElseIf chkDolares.Checked = True And chkSoles.Checked = False Then
            query += "and moneda='USD' "
        Else
            query += ""
        End If
        'FIN COMBINACION DE "MONEDAS"
        If iCarga = 1 Then
            queryRangoFechas = " and DATEADD(dd, 0, DATEDIFF(dd, 0, fec_emision))>='" & dtDesde.Value().ToString("yyyy-MM-dd") & "' and DATEADD(dd, 0, DATEDIFF(dd, 0, fec_emision))<='" & dtHasta.Value().ToString("yyyy-MM-dd") & "' "
            'COMBINACION DE "AÑO & MES"
            If cboAnio.SelectedValue.ToString <> "0" Then
                queryRangoFechas = ""
                query += "and year(fec_emision)='" & cboAnio.SelectedValue.ToString & "' "
            End If
            If cboMes.SelectedValue.ToString <> "0" Then
                queryRangoFechas = ""
                query += "and month(fec_emision)='" & cboMes.SelectedValue.ToString & "' "
            End If
            'FIN COMBINACION DE "AÑO & MES"
        End If

        query += queryRangoFechas & "  order by fec_emision asc"
        'MsgBox(query)
        Return query
    End Function
    Private Sub cargarComprobantes()
        'Dim CODI As String = codigoComprobante()
        Dim data As New DataTable
        data = obj.nCrudListarBD(querysPorCombinacion(), CadenaConexion)
        dgvLista.DataSource = data
        formatoGrillaCompras()
        'seleccionarCodigoDeVenta(CODI)
    End Sub
    Private Sub frmListaComprobanteCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTipo()
        dgvLista.RowTemplate.Height = 35
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        dgvPagos.RowTemplate.Height = 25
        cebrasDatagrid(dgvPagos, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        dgvAsientos.RowTemplate.Height = 25
        cebrasDatagrid(dgvAsientos, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))

        dgvLetras.RowTemplate.Height = 25
        cebrasDatagrid(dgvLetras, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        dgvCuentasLetras.RowTemplate.Height = 25
        cebrasDatagrid(dgvCuentasLetras, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        dgvAbonoLetra.RowTemplate.Height = 25
        cebrasDatagrid(dgvAbonoLetra, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))

        cargarComprobantes()
        cargarPeriodos()
        dtDesde.Value = DateTime.Today.AddMonths("-4")
        iCarga = 1
        Dim data As New DataTable
        data = obj.nCrudListarBD("select year(fec_emision) as anio from comprobante_compra group by year(fec_emision)", CadenaConexion)
        If data.Rows.Count > 0 Then
            cboAnio.SelectedIndex = 1
            cboMes.SelectedIndex = 1
        End If
        formatoGrillaCompras()
    End Sub
    Public Sub seleccionarCodigoDeVenta(codigo As Integer)
        For i As Integer = 0 To dgvLista.Rows.Count - 1
            For x As Integer = 0 To dgvLista.ColumnCount - 1
                If dgvLista.Rows(i).Cells("id").Value.ToString = codigo Then
                    dgvLista.CurrentCell = dgvLista.Rows(i).Cells("id")

                End If
            Next
        Next
    End Sub
    Public Sub marcarComprobante(codigo As String)
        For i As Integer = 0 To dgvLista.Rows.Count - 1
            For x As Integer = 0 To dgvLista.ColumnCount - 1
                If dgvLista.Rows(i).Cells("id").Value.ToString = codigo Then
                    dgvLista.CurrentCell = dgvLista.Rows(i).Cells("id")
                End If
            Next
        Next
    End Sub
    Private Sub formatoGrillaCompras()
        For Each row As DataGridViewRow In dgvLista.Rows
            If row.Cells("estado_comprobante").Value.ToString = "P" Then
                row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(184, 184, 184)
            ElseIf row.Cells("estado_comprobante").Value.ToString = "E" Then
                row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(245, 142, 149)
                'row.DefaultCellStyle.ForeColor = Drawing.Color.FromArgb(255, 255, 255)
            ElseIf row.Cells("estadoCompra").Value.ToString = "POR PAGAR" Then
                'row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(254, 198, 119)
                row.DefaultCellStyle.ForeColor = Drawing.Color.FromArgb(200, 22, 22)
                Dim dt As New DataTable
                dt = obj.nCrudListarBD("select * from comprobante_nota_credito  where id_comprobante='" & row.Cells("id").Value.ToString & "' and tipo='COMPRA' ", CadenaConexion)
                If dt.Rows.Count > 0 Then
                    row.DefaultCellStyle.ForeColor = Drawing.Color.FromArgb(200, 22, 22)
                    row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(143, 210, 162)
                End If
                dt = Nothing
                Dim dt2 As New DataTable
                dt2 = obj.nCrudListarBD("select * from comprobante_nota_debito  where id_comprobante='" & row.Cells("id").Value.ToString & "' and tipo='COMPRA' ", CadenaConexion)
                If dt2.Rows.Count > 0 Then
                    row.DefaultCellStyle.ForeColor = Drawing.Color.FromArgb(200, 22, 22)
                    row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(192, 192, 255)
                End If
                dt2 = Nothing
            Else
                Dim dt As New DataTable
                dt = obj.nCrudListarBD("select * from comprobante_nota_credito  where id_comprobante='" & row.Cells("id").Value.ToString & "' and tipo='COMPRA' ", CadenaConexion)
                If dt.Rows.Count > 0 Then
                    row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(143, 210, 162)
                End If
                dt = Nothing
                Dim dt2 As New DataTable
                dt2 = obj.nCrudListarBD("select * from comprobante_nota_debito  where id_comprobante='" & row.Cells("id").Value.ToString & "' and tipo='COMPRA' ", CadenaConexion)
                If dt2.Rows.Count > 0 Then
                    row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(192, 192, 255)
                End If
                dt2 = Nothing
            End If
            If row.Cells("tipo_compra").Value.ToString.StartsWith("CRD/LET") Then
                row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(240, 199, 129)
            End If
            Dim dtDel As New DataTable
            dtDel = obj.nCrudListarBD("select * from comprobante_nota_credito  where id_comprobante='" & row.Cells("id").Value.ToString & "' and motivo like 'Anula%' ", CadenaConexion)
            If dtDel.Rows.Count > 0 Then
                row.DefaultCellStyle.ForeColor = Drawing.Color.FromArgb(89, 46, 51)
                row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(245, 142, 149)
            End If
        Next
        realizarSumas()
    End Sub
    Private Sub realizarSumas()
        lblNumRegistros.Text = dgvLista.Rows.Count
        Dim monto As Decimal = 0
        Dim igv As Decimal = 0
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In dgvLista.Rows
            monto += row.Cells("monto").Value
            igv += row.Cells("igv").Value
            total += row.Cells("total").Value
        Next
        'lblMontos.Text = monto
        'lblNumRegistros.Text = igv
        lblTotal.Text = total
    End Sub
    Private Sub btnDetalle_Click(sender As Object, e As EventArgs) Handles btnDetalle.Click
        If dgvLista.Rows.Count > 0 Then


            Dim dtNc As New DataTable
            dtNc = obj.nCrudListarBD("select * from comprobante_nota_credito where id_comprobante='" & codigoComprobante() & "' and motivo like 'Anulaci%'", CadenaConexion)
            If dtNc.Rows.Count > 0 Then
                panelAnulacion.Visible = True
                txtSerieNC.Text = dtNc.Rows(0)("serie").ToString
                txtNumeroNC.Text = dtNc.Rows(0)("numero").ToString
                txtComentariosNC.Text = dtNc.Rows(0)("comentario").ToString
            Else
                panelAnulacion.Visible = False
            End If

            lblTitulo.Text = "COMPRAS"
            grupoBusqueda.Enabled = False

            Dim cuentas As New DataTable
            With cuentas
                .Columns.Add("num_cuenta")
                .Columns.Add("desc_cuenta")
                .Columns.Add("debe")
                .Columns.Add("haber")
            End With

            'Cargar Datos al Panel de detalle
            Dim data As New DataTable
            data = obj.nCrudListarBD("select * from vista_compras_con_abonos where id='" & codigoComprobante() & "'", CadenaConexion)
            With data
                txtTipoDocumento.Text = .Rows(0)("comprobante").ToString
                txtSerie.Text = .Rows(0)("serie").ToString
                txtNumero.Text = .Rows(0)("numero").ToString
                txtRuc.Text = .Rows(0)("num_dni").ToString
                txtRazon.Text = .Rows(0)("razon_social").ToString
                txtFechaEmision.Text = Date.Parse(.Rows(0)("fec_emision").ToString)
                txtFechaPago.Text = Date.Parse(.Rows(0)("fec_pago").ToString)
                txtFormaPago.Text = .Rows(0)("tipo_compra").ToString
                txtMoneda.Text = .Rows(0)("moneda").ToString
                txtTc.Text = .Rows(0)("tc").ToString
                txtTotal.Text = .Rows(0)("total").ToString
                txtDeuda.Text = Decimal.Parse(.Rows(0)("total").ToString) - Decimal.Parse(.Rows(0)("abono").ToString)
                txtGlosa.Text = .Rows(0)("glosa").ToString
                txtTipoOperacion.Text = .Rows(0)("gravado").ToString
            End With

            'Cargar asientos contables
            Dim asientos As New DataTable
            asientos = obj.nCrudListarBD("select a.cuenta as 'num_cuenta', c.nombre as 'desc_cuenta',a.debe, a.haber from asientos_comprobante_compra a inner join cuenta_contable c on a.cuenta=c.id where a.id_comprobante_compra='" & codigoComprobante() & "' order by a.id asc", CadenaConexion)
            cuentas.Rows.Add("-", "ASIENTOS DE COMPRA", 0, 0)
            For Each row As DataRow In asientos.Rows
                cuentas.Rows.Add(row.Item("num_cuenta").ToString, row.Item("desc_cuenta").ToString, row.Item("debe").ToString, row.Item("haber").ToString)
            Next
            'cuentas = (asientos)

            'Cargar los abonos
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid

            Dim abonos As New DataTable
            abonos = obj.nCrudListarBD("select fecha as 'fecha_abono',descripcion as 'glosa_abono', '" & txtMoneda.Text & "' as 'moneda_abono', monto as 'monto_abono' from abono_pagos_compras where id_compra='" & codigoComprobante() & "'", CadenaConexion)
            If abonos.Rows.Count > 0 Then
                lblNoPagos.Visible = False
                dgvPagos.Visible = True
                lblTotalAbono.Visible = True
                txtTotalAbonos.Visible = True

                dgvPagos.DataSource = abonos
                txtTotalAbonos.Text = Decimal.Parse(data.Rows(0)("abono").ToString)
                'Cargar Asiento de abonos
                cuentas.Rows.Add("-", "ASIENTOS DE PAGO", "0", "0")
                Dim dataAbono As New DataTable
                dataAbono = obj.nCrudListarBD("select a.cuenta as 'num_cuenta',c.nombre as 'desc_cuenta',a.debe,a.haber from asientos_abono_compras a inner join cuenta_contable c on a.cuenta=c.id where a.id_compra='" & codigoComprobante() & "' order by a.id asc", CadenaConexion)
                For Each row As DataRow In dataAbono.Rows
                    cuentas.Rows.Add(row.Item("num_cuenta").ToString, row.Item("desc_cuenta").ToString, row.Item("debe").ToString, row.Item("haber").ToString)
                Next
            Else
                lblNoPagos.Visible = True
                dgvPagos.Visible = False
                lblTotalAbono.Visible = False
                txtTotalAbonos.Visible = False
            End If
            dgvAsientos.DataSource = cuentas

            Dim debe, haber As Decimal
            For Each row As DataGridViewRow In dgvAsientos.Rows
                If row.Cells("num_cuenta").Value.ToString <> "-" Then
                    debe += Decimal.Parse(row.Cells("debe").Value)
                    haber += Decimal.Parse(row.Cells("haber").Value)
                End If
            Next
            txtTotalDebe.Text = debe
            txtTotalHaber.Text = haber
            txtDiferencia.Text = debe - haber

            'Mostrar Panel de Datos
            With panelDetalle
                .Size = New Size(677, 587)
                .Visible = True
                .Location = New Point(195, 12)
            End With

            For NumeroFila As Integer = 0 To dgvAsientos.Rows.Count - 1
                If dgvAsientos.Item("num_cuenta", NumeroFila).Value.ToString = "-" Then
                    dgvAsientos.Item("num_cuenta", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)
                    dgvAsientos.Item("desc_cuenta", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)
                    dgvAsientos.Item("debe", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)
                    dgvAsientos.Item("haber", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)

                    dgvAsientos.Item("num_cuenta", NumeroFila).Style.ForeColor = Drawing.Color.FromArgb(160, 160, 160)
                    dgvAsientos.Item("desc_cuenta", NumeroFila).Style.Font = New Font(dgvAsientos.Font, FontStyle.Italic)
                    dgvAsientos.Item("desc_cuenta", NumeroFila).Style.Font = New Font(dgvAsientos.Font, FontStyle.Bold)
                    dgvAsientos.Item("debe", NumeroFila).Style.ForeColor = Drawing.Color.FromArgb(160, 160, 160)
                    dgvAsientos.Item("haber", NumeroFila).Style.ForeColor = Drawing.Color.FromArgb(160, 160, 160)
                End If
            Next
            'frmDetalleCompra.idCompra = codigoComprobante()
            'frmDetalleCompra.Show()
        End If
    End Sub
    Private Sub frmListaComprobanteCompras_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            If panelDetalle.Visible = True Then
                habilitarBusquedas()
            End If
        End If
    End Sub
    Private Sub habilitarBusquedas()
        panelDetalle.Visible = False
        PanelLetra.Visible = False
        lblTitulo.Text = "LISTA DE COMPRAS"
        grupoBusqueda.Enabled = True
    End Sub
    Private Sub btnPagos_Click(sender As Object, e As EventArgs) Handles btnPagos.Click
        If dgvLista.Rows.Count > 0 Then
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            Dim dtNca As New DataTable
            dtNca = obj.nCrudListarBD("select * from comprobante_nota_credito  where id_comprobante='" & codigoComprobante() & "' and tipo='COMPRA' ", CadenaConexion)
            If dtNca.Rows.Count > 0 Then
                If dtNca.Rows(0)("motivo").ToString.StartsWith("Anulaci") Then
                    MsgBox("No se puede realizar el pago a un comprobante anulado")
                    Exit Sub
                End If
            End If
            frmAccionPagosCompras.idComprobante = "0"
            frmAccionPagosCompras.idComprobante = codigoComprobante()
            frmAccionPagosCompras.Show()
        End If
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgvLista.Rows.Count > 0 Then
            frmModificarCompraP.idCompra = codigoComprobante()
            frmModificarCompraP.Show()
        End If
    End Sub
    Private Sub btnDebito_Click(sender As Object, e As EventArgs) Handles btnDebito.Click
        If dgvLista.Rows.Count > 0 Then
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            If dgvLista.Rows(f).Cells("estadoCompra").Value.ToString <> "CANCELADO" Then
                MsgBox("No se puede realizar Nota de débito de este comprobante")
                Exit Sub
            End If
            Dim dtVerNC, dtNC As New DataTable
            dtVerNC = obj.nCrudListarBD("select * from comprobante_nota_debito where tipo='COMPRA' and id_comprobante='" & codigoComprobante() & "'", CadenaConexion)
            Dim dtNca As New DataTable
            dtNca = obj.nCrudListarBD("select * from comprobante_nota_credito  where id_comprobante='" & codigoComprobante() & "' and tipo='COMPRA' ", CadenaConexion)
            If dtNca.Rows.Count > 0 Then
                If dtNca.Rows(0)("motivo").ToString.StartsWith("Anulaci") Then
                    MsgBox("No se puede realizar una nota de débito para este comprobante")
                    Exit Sub
                End If
            End If


            If dtVerNC.Rows.Count > 0 Then
                dtNC = obj.nCrudListarBD("select sum(total) as 'total' from comprobante_nota_debito where tipo='COMPRA' and id_comprobante='" & codigoComprobante() & "'", CadenaConexion)
                If Decimal.Parse(dtNC.Rows(0)("total").ToString) = Decimal.Parse(dgvLista.Rows(f).Cells("total").Value.ToString) Then
                    MsgBox("No se puede realizar Nota de Débito de este comprobante")
                    'Me.Close()
                Else
                    With frmNuevaNotaDebito
                        .TIPO_PROCESO = "COMPRA"
                        .Text = "Nueva Nota de Débito Compra - N° registro: " & codigoComprobante()
                        .codComprobante = codigoComprobante()
                        .codTipoComprobante = codigoTipoComprobante()
                        .cargarDatosComprobante()
                        .Show()
                    End With
                End If
            Else
                With frmNuevaNotaDebito
                    .TIPO_PROCESO = "COMPRA"
                    .Text = "Nueva Nota de Débito Compra - N° registro: " & codigoComprobante()
                    .codComprobante = codigoComprobante()
                    .codTipoComprobante = codigoTipoComprobante()
                    .cargarDatosComprobante()
                    .Show()
                End With
            End If
        End If
    End Sub
    Private Sub btnCredito_Click(sender As Object, e As EventArgs) Handles btnCredito.Click
        If dgvLista.Rows.Count > 0 Then
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            'If dgvLista.Rows(f).Cells("estadoCompra").Value.ToString <> "CANCELADO" Then
            '    MsgBox("No se puede realizar Nota de crédito de este comprobante")
            '    Exit Sub
            'End If
            Dim dtVerNC, dtNC As New DataTable
            dtVerNC = obj.nCrudListarBD("select * from comprobante_nota_credito where tipo='COMPRA' and id_comprobante='" & codigoComprobante() & "'", CadenaConexion)
            If dtVerNC.Rows.Count > 0 Then
                dtNC = obj.nCrudListarBD("select sum(total) as 'total' from comprobante_nota_credito where tipo='COMPRA' and id_comprobante='" & codigoComprobante() & "'", CadenaConexion)
                If Decimal.Parse(dtNC.Rows(0)("total").ToString) = Decimal.Parse(dgvLista.Rows(f).Cells("total").Value.ToString) Or Decimal.Parse(dgvLista.Rows(f).Cells("abono").Value.ToString) = 0 Then
                    MsgBox("No se puede realizar Nota de crédito de este comprobante")
                    Exit Sub
                Else
                    With frmNuevaNotaCredito
                        .Text = "Nueva Nota de Crédito - COMPRA- N° registro: " & codigoComprobante()
                        .codComprobante = codigoComprobante()
                        .codTipoComprobante = codigoTipoComprobante()
                        .TIPO_PROCESO = "COMPRA"
                        .cargarDatosComprobante()
                        .Show()
                        .txtTotal.Text = Decimal.Parse(dgvLista.Rows(f).Cells("abono").Value.ToString)
                        .txtTotalVOc.Text = Decimal.Parse(dgvLista.Rows(f).Cells("abono").Value.ToString)
                        .calcularFactor()
                    End With
                End If
            Else
                'If Decimal.Parse(dgvLista.Rows(f).Cells("abono").Value.ToString) > 0 Then
                With frmNuevaNotaCredito
                    .Text = "Nueva Nota de Crédito - COMPRA- N° registro: " & codigoComprobante()
                    .codComprobante = codigoComprobante()
                    .codTipoComprobante = codigoTipoComprobante()
                    .TIPO_PROCESO = "COMPRA"
                    .cargarDatosComprobante()
                    .Show()
                    If dgvLista.Rows(f).Cells("estadoCompra").Value.ToString <> "CANCELADO" And Decimal.Parse(dgvLista.Rows(f).Cells("abono").Value.ToString) = 0 Then
                        .cboMotivo.SelectedValue = 1
                        .cboMotivo.Enabled = False
                    End If
                    If Decimal.Parse(dgvLista.Rows(f).Cells("abono").Value.ToString) = 0 Then
                        .txtTotal.Text = Decimal.Parse(dgvLista.Rows(f).Cells("total").Value.ToString)
                        .txtTotalVOc.Text = Decimal.Parse(dgvLista.Rows(f).Cells("total").Value.ToString)
                    Else
                        .txtTotal.Text = Decimal.Parse(dgvLista.Rows(f).Cells("abono").Value.ToString)
                        .txtTotalVOc.Text = Decimal.Parse(dgvLista.Rows(f).Cells("abono").Value.ToString)
                    End If
                    .calcularFactor()
                End With
                'Else
                'MsgBox("No se puede realizar Nota de crédito de este comprobante")
                'Exit Sub
                'End If
            End If
        End If
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim verif As Boolean = False
        For Each row As DataGridViewRow In dgvLista.Rows
            If row.Cells(0).Value = True Then
                verif = True
            End If
        Next
        If verif = True Then

            For Each row As DataGridViewRow In dgvLista.Rows
                If row.Cells(0).Value = True Then
                    'verificar que no tengan abonos realizados
                    Dim dt As New DataTable
                    dt = obj.nCrudListarBD("select * from abono_pagos_compras where id_compra='" & row.Cells("id").Value.ToString & "'", CadenaConexion)
                    Dim dtC As New DataTable
                    dtC = obj.nCrudListarBD("select * from comprobante_nota_credito where id_comprobante='" & row.Cells("id").Value.ToString & "'", CadenaConexion)
                    Dim dtD As New DataTable
                    dtD = obj.nCrudListarBD("select * from comprobante_nota_debito where id_comprobante='" & row.Cells("id").Value.ToString & "'", CadenaConexion)
                    If dt.Rows.Count > 0 Or dtC.Rows.Count > 0 Or dtD.Rows.Count > 0 Then
                        MsgBox("No se puede eliminar un comprobante que tiene procesos anexados")
                        Exit Sub
                        Exit For
                    End If

                End If
            Next
            If MessageBox.Show("Está apunto de ELIMINAR el/los comprobante(s) seleccionado(s). Este procesos borrará los registros de la Base de datos" & vbCrLf & "¿Desea realizar este proceso?", "ELIMINACIÓN DE COMPROBANTE DE COMPRA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                For Each row As DataGridViewRow In dgvLista.Rows
                    If row.Cells(0).Value = True Then
                        'ELIMINAR EN COMPROBANTE DE COMPRA
                        obj.nEjecutarQueryBD("delete from comprobante_compra where id='" & row.Cells("id").Value.ToString & "'", CadenaConexion)
                        'ELIMINAR EN COMPROBANTE DE COMPRA
                        obj.nEjecutarQueryBD("delete from comprobante_nota_credito where id_comprobante='" & row.Cells("id").Value.ToString & "'", CadenaConexion)
                        'ELIMINAR EN COMPROBANTE DE COMPRA
                        obj.nEjecutarQueryBD("delete from abono_pagos_compras where id_compra='" & row.Cells("id").Value.ToString & "'", CadenaConexion)
                        'ELIMINAR EN COMPROBANTE DE COMPRA
                        obj.nEjecutarQueryBD("delete from asientos_abono_compras where id_compra='" & row.Cells("id").Value.ToString & "'", CadenaConexion)
                        'ELIMINAR ASIENTOS DE COMPROBANTE DE COMPRA
                        obj.nEjecutarQueryBD("delete from asientos_comprobante_compra where id_comprobante_compra='" & row.Cells("id").Value.ToString & "'", CadenaConexion)
                        'ELIMINAR ASIENTOS DE COMPROBANTE DE COMPRA EN LIBRO DIARIO
                        obj.nEjecutarQueryBD("delete from asientos_libro_diario where id_comprobante='C" & row.Cells("id").Value.ToString & "'", CadenaConexion)
                        MsgBox("Comprobante(s) ELIMINADO(S) del Sistema correctamente")
                    End If
                Next
            End If
            Me.realizarConsulta()
        End If

        'Dim dtComp As New DataTable
        'dtComp = obj.nCrudListarBD("select * from comprobante_compra where id='" & codigoComprobante() & "'", CadenaConexion)

        'If dtComp.Rows(0)("estado_comprobante") <> "E" Then
        '    If MessageBox.Show("Está apunto de ELIMINAR el comprobante seleccionado." & vbCrLf & "¿Desea realizar este proceso?", "Estado del comprobante de compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
        '        Dim data As New DataTable
        '        data = obj.nCrudListarBD("select * from asientos_comprobante_compra where id_comprobante_compra='" & codigoComprobante() & "'", CadenaConexion)
        '        Dim objCC As New nComprobanteCompra
        '        Dim entiCCompraAsiento As New ComprobanteCompraEntity
        '        With entiCCompraAsiento
        '            .id_comprobante = codigoComprobante()
        '            .numero_cuo = objCC.nObtenerCUO_CompraBD(CadenaConexion)
        '            .tipo_compra = "CONTADO"
        '            .numero_maquina = "-"
        '            .id_tipo_comprobante = data.Rows(0)("id_tipo_comprobante").ToString
        '            .fec_emision = Date.Parse(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))
        '            .fec_pago = Date.Parse(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))
        '            .serie_comprobante = data.Rows(0)("serie_comprobante").ToString
        '            .numero_comprobante = data.Rows(0)("numero_comprobante").ToString
        '            .cod_dni = "6"
        '            .num_dni = data.Rows(0)("num_dni").ToString
        '            .razon_social = data.Rows(0)("razon_social").ToString
        '            .valor_facturado = data.Rows(0)("valor_facturado").ToString
        '            .base_imponible = data.Rows(0)("base_imponible").ToString
        '            .valor_exonerado = 0
        '            .valor_inafecto = 0
        '            .valor_isc = 0
        '            .valor_igv = data.Rows(0)("valor_igv").ToString
        '            .otros_base_imponible = 0
        '            .total = data.Rows(0)("total").ToString
        '            .tipo_cambio = data.Rows(0)("tipo_cambio").ToString
        '            .serie_comp_origen = data.Rows(0)("serie_comp_origen").ToString
        '            .numero_comp_origen = data.Rows(0)("numero_comp_origen").ToString
        '            .fec_comp_origen = data.Rows(0)("fec_comp_origen").ToString
        '            .serie_dua = "0"
        '            .numero_dua = "0"
        '            .anio_dua = data.Rows(0)("anio_dua").ToString
        '            .numero_detraccion = data.Rows(0)("numero_detraccion").ToString
        '            .tipo_tasa_detraccion = "0"
        '            .tasa_detraccion = data.Rows(0)("tasa_detraccion").ToString
        '            .valor_detraccion = data.Rows(0)("valor_detraccion").ToString
        '            .fecha_detraccion = data.Rows(0)("fecha_detraccion").ToString
        '            .estado = 1
        '        End With

        '        For Each row As DataRow In data.Rows
        '            With row
        '                entiCCompraAsiento.tip_comp_origen = "-"
        '                entiCCompraAsiento.cuenta = .Item("cuenta").ToString
        '                entiCCompraAsiento.glosa = "ANULACION DEL COMPROBANTE DE COMPRA"
        '                entiCCompraAsiento.debe = .Item("haber").ToString
        '                entiCCompraAsiento.haber = .Item("debe").ToString
        '                entiCCompraAsiento.impuesto = .Item("impuesto").ToString
        '                entiCCompraAsiento.serie = .Item("serie").ToString
        '                entiCCompraAsiento.numero = .Item("numero").ToString
        '                entiCCompraAsiento.operacion = .Item("operacion").ToString
        '                Dim rptaRACC As String = objCC.nRegistrarAsientoComprobanteCompraBD(entiCCompraAsiento, CadenaConexion)
        '                If rptaRACC <> "ok" Then
        '                    MsgBox("Error en el registro en el asiento del comprobante: " & rptaRACC)
        '                End If
        '            End With
        '        Next
        '        'CAMBIO DE ESTADO DE COMPROBANTE DE COMPRA
        '        MsgBox("ACTUALIZACION DE COMPROBANTE: " & obj.nCrudActualizarBD("@", "comprobante_compra", "estado_comprobante", "E", "id='" & codigoComprobante() & "'", CadenaConexion))
        '        Me.realizarConsulta()
        '    End If
        'Else
        '    MessageBox.Show("No se puede ANULAR/ELIMINAR un comprobante ya anulado.", "Estado del comprobante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        'End If
    End Sub
    Private Sub btnCanje_Click(sender As Object, e As EventArgs) Handles btnCanje.Click
        If dgvLista.Rows.Count > 0 Then
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid

            Dim dtNc As New DataTable
            dtNc = obj.nCrudListarBD("select * from comprobante_nota_credito where id_comprobante='" & codigoComprobante() & "' and motivo like 'Anulaci%'", CadenaConexion)
            If dtNc.Rows.Count > 0 Then
                MsgBox("No se puede realizar el canje a letra de este comprobante.")
            Else
                If dgvLista.Rows(f).Cells("tipo_compra").Value.ToString.StartsWith("CRD/LET") And Decimal.Parse(dgvLista.Rows(f).Cells("abono").Value.ToString) <= Decimal.Parse(dgvLista.Rows(f).Cells("total").Value.ToString) Then
                    lblTitulo.Text = "COMPRAS"
                    grupoBusqueda.Enabled = False

                    Dim cuentas As New DataTable
                    With cuentas
                        .Columns.Add("num_cuenta")
                        .Columns.Add("desc_cuenta")
                        .Columns.Add("debe")
                        .Columns.Add("haber")
                    End With

                    'Cargar Datos al Panel de detalle
                    Dim data As New DataTable
                    data = obj.nCrudListarBD("select * from vista_compras_con_abonos where id='" & codigoComprobante() & "'", CadenaConexion)
                    With data
                        txtTipoDocumento2.Text = .Rows(0)("comprobante").ToString
                        txtSerie2.Text = .Rows(0)("serie").ToString
                        txtNumero2.Text = .Rows(0)("numero").ToString
                        txtRuc2.Text = .Rows(0)("num_dni").ToString
                        txtRazon2.Text = .Rows(0)("razon_social").ToString
                        txtFechaEmision2.Text = Date.Parse(.Rows(0)("fec_emision").ToString)
                        txtFechaPago2.Text = Date.Parse(.Rows(0)("fec_pago").ToString)
                        txtFormaPago2.Text = .Rows(0)("tipo_compra").ToString
                        txtMoneda2.Text = .Rows(0)("moneda").ToString
                        txtTc2.Text = .Rows(0)("tc").ToString
                        txtTotal2.Text = .Rows(0)("total").ToString
                        txtDeuda2.Text = Decimal.Parse(.Rows(0)("total").ToString) - Decimal.Parse(.Rows(0)("abono").ToString)
                        txtGlosa2.Text = .Rows(0)("glosa").ToString
                        txtTipoOperacion2.Text = .Rows(0)("gravado").ToString
                    End With

                    'Cargar los abonos
                    Dim abonos As New DataTable
                    abonos = obj.nCrudListarBD("select c.id as 'idL',c.id_comprobante, c.fec_emision as 'fec_emisionL',c.fec_vencimiento as 'fec_vencimientoL',c.monto as 'montoL',c.serie as 'serieL',c.numero as 'numeroL', c.glosa ,c.librado,c.lugar_giro, c.aval,c.direccion from canje_letra c  where c.id_comprobante='" & codigoComprobante() & "' and c.tipo_comprobante='COMPRA'", CadenaConexion)
                    If abonos.Rows.Count > 0 Then
                        lblNoPagos.Visible = False
                        dgvPagos.Visible = True
                        lblTotalAbono.Visible = True
                        txtTotalAbonos.Visible = True

                        dgvLetras.DataSource = abonos
                        Dim totalCanje As Decimal = 0
                        For Each row As DataGridViewRow In dgvLetras.Rows
                            totalCanje += Decimal.Parse(row.Cells("montoL").Value)
                        Next
                        txtTotalCanjes.Text = totalCanje
                    Else
                        lblNoPagos.Visible = True
                        dgvPagos.Visible = False
                        lblTotalAbono.Visible = False
                        txtTotalAbonos.Visible = False
                    End If
                    dgvAsientos.DataSource = cuentas

                    Dim f1 As Integer
                    f1 = dgvLetras.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid



                    'Mostrar Panel de Datos
                    With PanelLetra
                        .Size = New Size(677, 587)
                        .Visible = True
                        .Location = New Point(195, 12)
                    End With

                    For NumeroFila As Integer = 0 To dgvAsientos.Rows.Count - 1
                        If dgvAsientos.Item("num_cuenta", NumeroFila).Value.ToString = "-" Then
                            dgvAsientos.Item("num_cuenta", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)
                            dgvAsientos.Item("desc_cuenta", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)
                            dgvAsientos.Item("debe", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)
                            dgvAsientos.Item("haber", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)

                            dgvAsientos.Item("num_cuenta", NumeroFila).Style.ForeColor = Drawing.Color.FromArgb(160, 160, 160)
                            dgvAsientos.Item("desc_cuenta", NumeroFila).Style.Font = New Font(dgvAsientos.Font, FontStyle.Italic)
                            dgvAsientos.Item("desc_cuenta", NumeroFila).Style.Font = New Font(dgvAsientos.Font, FontStyle.Bold)
                            dgvAsientos.Item("debe", NumeroFila).Style.ForeColor = Drawing.Color.FromArgb(160, 160, 160)
                            dgvAsientos.Item("haber", NumeroFila).Style.ForeColor = Drawing.Color.FromArgb(160, 160, 160)
                        End If
                    Next
                    'frmDetalleCompra.idCompra = codigoComprobante()
                    'frmDetalleCompra.Show()

                ElseIf Not dgvLista.Rows(f).Cells("tipo_compra").Value.ToString.StartsWith("CRD/LET") And Decimal.Parse(dgvLista.Rows(f).Cells("abono").Value.ToString) <= Decimal.Parse(dgvLista.Rows(f).Cells("total").Value.ToString) Then
                    realizarCanje()
                Else
                    MsgBox("No se puede realizar el canje a letra de este comprobante")
                End If
            End If


        End If
    End Sub
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        realizarConsulta()
        mostrarMoneda()
    End Sub
    Private Sub mostrarMoneda()
        If chkSoles.Checked = True And chkDolares.Checked = False Then
            lblMoneda.Text = "(PEN)"
        ElseIf chkDolares.Checked = True And chkSoles.Checked = False Then
            lblMoneda.Text = "(USD)"
        ElseIf chkDolares.Checked = True And chkSoles.Checked = True Then
            lblMoneda.Text = "(PEN/USD)"
        Else
            lblMoneda.Text = "(PEN/USD)"
        End If
    End Sub
    Private Sub txtDato_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDato.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            realizarConsulta()
        End If
    End Sub
    Public Sub realizarConsulta()
        cargarComprobantes()
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        frmNuevaCompraP.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnFormatoCompra.Click
        If dgvLista.Rows.Count > 0 Then
            'frmNuevaCompraMercaderias.Show()
            generarExcelCompras()
        End If
    End Sub
    Private Sub generarExcelCompras()
        Me.Enabled = False
        Try
            Dim data As New DataTable
            data = obj.nCrudListarBD("select * from empresas where id='" & CodigoEmpresaSession & "'", CadenaConexion)

            Dim tbDatos As New DataTable
            tbDatos = obj.nCrudListarBD("select * from comprobante_compra", CadenaConexion)

            'MsgBox("TOTAL REGISTROS: " & tbDatos.Rows.Count)
            Dim fila As Integer = 9

            Dim Archivo As String
            Dim a As Object
            Dim APrueba As Object
            a = CreateObject("Excel.Application")
            a.Visible = True
            Archivo = CARPETA_EXCELS & "formato.8.1-copia.xlsx" 'Pon aqui el nombre de archivo que quieras
            APrueba = a.Workbooks.Open(Archivo)
            With APrueba.WorkSheets("formato")
                .Cells(3, "F") = cboMes.Text
                .Cells(4, "F") = data.Rows(0)("ruc").ToString
                .Cells(5, "F") = data.Rows(0)("nombre").ToString
                Dim trKardex As Integer = tbDatos.Rows.Count
                Dim e_pu As Decimal = 0
                Dim s_pu As Decimal = 0
                Dim sf_can As Decimal = 0
                Dim sf_pu As Decimal = 0
                Dim sf_pt As Decimal = 0
                For i As Integer = 0 To trKardex - 1
                    APrueba.Worksheets("formato").Rows(fila + i).Insert(Shift:=(fila + i))
                    .Cells((fila + i), "A") = Date.Parse(tbDatos.Rows(i)("fec_emision")).ToString("yyyyMM") & "00"
                    .Cells((fila + i), "B") = tbDatos.Rows(i)("id").ToString
                    .Cells((fila + i), "C") = "1"
                    .Cells((fila + i), "D") = Date.Parse(tbDatos.Rows(i)("fec_emision")).ToString("dd/MM/yyyy")
                    .Cells((fila + i), "E") = Date.Parse(tbDatos.Rows(i)("fec_pago")).ToString("dd/MM/yyyy")
                    Dim dtTC As New DataTable
                    dtTC = obj.nCrudListarBD("select * from tipo_documento where id='" & tbDatos.Rows(i)("id_tipo_comprobante").ToString & "'", CadenaConexion)
                    .Cells((fila + i), "F") = dtTC.Rows(0)("codigo")
                    .Cells((fila + i), "G") = tbDatos.Rows(i)("serie_comprobante").ToString
                    .Cells((fila + i), "I") = tbDatos.Rows(i)("numero_comprobante").ToString
                    .Cells((fila + i), "K") = tbDatos.Rows(i)("cod_dni").ToString
                    .Cells((fila + i), "L") = tbDatos.Rows(i)("num_dni").ToString
                    .Cells((fila + i), "M") = tbDatos.Rows(i)("razon_social").ToString

                    If tbDatos.Rows(i)("id_gravado").ToString = "1" Then
                        .Cells((fila + i), "N") = tbDatos.Rows(i)("valor_facturado").ToString * tbDatos.Rows(i)("tipo_cambio").ToString
                        .Cells((fila + i), "O") = tbDatos.Rows(i)("valor_igv").ToString * tbDatos.Rows(i)("tipo_cambio").ToString
                    ElseIf tbDatos.Rows(i)("id_gravado").ToString = "2" Then
                        .Cells((fila + i), "P") = tbDatos.Rows(i)("valor_facturado").ToString * tbDatos.Rows(i)("tipo_cambio").ToString
                        .Cells((fila + i), "Q") = tbDatos.Rows(i)("valor_igv").ToString * tbDatos.Rows(i)("tipo_cambio").ToString
                    ElseIf tbDatos.Rows(i)("id_gravado").ToString = "3" Then
                        .Cells((fila + i), "R") = tbDatos.Rows(i)("valor_facturado").ToString * tbDatos.Rows(i)("tipo_cambio").ToString
                        .Cells((fila + i), "S") = tbDatos.Rows(i)("valor_igv").ToString * tbDatos.Rows(i)("tipo_cambio").ToString
                    ElseIf tbDatos.Rows(i)("id_gravado").ToString = "4" Then
                        .Cells((fila + i), "T") = tbDatos.Rows(i)("valor_facturado").ToString * tbDatos.Rows(i)("tipo_cambio").ToString
                    End If

                    .Cells((fila + i), "W") = tbDatos.Rows(i)("total").ToString * tbDatos.Rows(i)("tipo_cambio").ToString
                    Dim lista As New DataTable
                    lista = obj.nCrudListarBD("select * from tipo_moneda where id='" & tbDatos.Rows(i)("id_moneda").ToString & "'", CadenaConexion)
                    .Cells((fila + i), "X") = lista.Rows(0)("codigo").ToString
                    .Cells((fila + i), "Y") = tbDatos.Rows(i)("tipo_cambio").ToString
                    .Cells((fila + i), "Z") = Date.Parse(tbDatos.Rows(i)("fec_comp_origen").ToString).ToString("dd/MM/yyyy")
                    .Cells((fila + i), "AA") = tbDatos.Rows(i)("tip_comp_origen").ToString
                    .Cells((fila + i), "AB") = tbDatos.Rows(i)("serie_comp_origen").ToString
                    .Cells((fila + i), "AD") = tbDatos.Rows(i)("numero_comp_origen").ToString
                    .Cells((fila + i), "AH") = "1"
                    .Cells((fila + i), "AN") = ""
                    .Cells((fila + i), "AO") = "1"
                Next
                Dim filaRest As Integer = (fila + trKardex)
                'MsgBox(.Cells((17 + trKardex), "A").Value)
                If .Cells(filaRest, "A").Value = "" Then
                    '.Rows(10).Delete()
                    .Rows(filaRest).Delete()
                End If

                'SUMA DE TOTALES
                '.Cells(filaRest, "L").Formula = "=SUM(L" & fila & ":L" & filaRest - 1 & ")"
                '.Cells(filaRest, "M").Formula = "=SUM(M" & fila & ":M" & filaRest - 1 & ")"
                '.Cells(filaRest, "U").Formula = "=SUM(U" & fila & ":U" & filaRest - 1 & ")"
                '.Cells(filaRest, "I") = "=(G" & filaRest & "-H" & filaRest & ")"
                .Rows(8).Delete()
            End With

            'MsgBox("No cierres esto hasta ver el resultado")
            'APrueba.Close(SaveChanges:=False) 'O True, como prefieras
            a.Quit()
            Me.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Enabled = True
    End Sub
    Private Sub btnGenerarPle_Click(sender As Object, e As EventArgs) Handles btnGenerarPle.Click
        If dgvLista.Rows.Count > 0 Then
            generarExcelComprasPle()
            generarTxt()
        End If
    End Sub
    Private Sub generarExcelComprasPle()
        Me.Enabled = False
        Try
            anioPeriodo = cboAnio.SelectedValue.ToString
            mesPeriodo = cboMes.SelectedValue.ToString.PadLeft(2, "0"c)

            Dim tbDatos As New DataTable
            Dim query As String
            query = "select * from comprobante_compra where fec_emision>='" & dtDesde.Value().ToString("yyyy-MM-dd") & "' and fec_emision<='" & dtHasta.Value().ToString("yyyy-MM-dd") & "' order by fec_emision asc"
            tbDatos = obj.nCrudListarBD(query, CadenaConexion)

            filaTable = New DataTable
            filaTable.Columns.Add("fila")

            'MsgBox("TOTAL REGISTROS: " & tbDatos.Rows.Count)
            Dim fila As Integer = 3

            Dim Archivo As String
            Dim a As Object
            Dim APrueba As Object
            a = CreateObject("Excel.Application")
            a.Visible = True
            Archivo = CARPETA_EXCELS & "registro.compras.xlsx" 'Pon aqui el nombre de archivo que quieras
            APrueba = a.Workbooks.Open(Archivo)

            With APrueba.WorkSheets("formato")

                Dim trKardex As Integer = tbDatos.Rows.Count
                Dim e_pu As Decimal = 0
                Dim s_pu As Decimal = 0
                Dim sf_can As Decimal = 0
                Dim sf_pu As Decimal = 0
                Dim sf_pt As Decimal = 0
                Dim acumulador As String
                For i As Integer = 0 To trKardex - 1
                    'APrueba.Worksheets("formato").Rows(fila + i).Insert(Shift:=(fila + i))
                    acumulador = i + 1
                    .Cells((fila + i), "A") = acumulador
                    .Cells((fila + i), "B") = anioPeriodo & mesPeriodo & "00"
                    .Cells((fila + i), "C").Value = "C" & acumulador
                    .Cells((fila + i), "D").Value = "M" & acumulador.PadLeft(4, "0"c)
                    .Cells((fila + i), "E") = Date.Parse(tbDatos.Rows(i)("fec_emision")).ToString("dd/MM/yyyy")
                    .Cells((fila + i), "F") = ""
                    Dim tc As DataTable = obj.nCrudListarBD("select * from tipo_documento where id='" & tbDatos.Rows(i)("id_tipo_comprobante").ToString & "'", CadenaConexion)
                    .Cells((fila + i), "G") = tc.Rows(0)("codigo").ToString
                    .Cells((fila + i), "H") = tbDatos.Rows(i)("serie_comprobante").ToString.PadLeft(4, "0"c)
                    .Cells((fila + i), "J") = tbDatos.Rows(i)("numero_comprobante").ToString.PadLeft(4, "0"c)
                    .Cells((fila + i), "L") = tbDatos.Rows(i)("cod_dni").ToString
                    .Cells((fila + i), "M") = tbDatos.Rows(i)("num_dni").ToString
                    .Cells((fila + i), "N") = tbDatos.Rows(i)("razon_social").ToString
                    .Cells((fila + i), "O") = tbDatos.Rows(i)("valor_facturado").ToString
                    .Cells((fila + i), "P") = tbDatos.Rows(i)("valor_igv").ToString
                    .Cells((fila + i), "X") = tbDatos.Rows(i)("total").ToString
                    Dim lista As New DataTable
                    lista = obj.nCrudListarBD("select * from tipo_moneda where id='" & tbDatos.Rows(i)("id_moneda").ToString & "'", CadenaConexion)
                    .Cells((fila + i), "Y") = lista.Rows(0)("codigo").ToString
                    .Cells((fila + i), "Z") = IIf(Decimal.Parse(tbDatos.Rows(i)("tipo_cambio").ToString) > 1, tbDatos.Rows(i)("tipo_cambio").ToString, "")
                    If tbDatos.Rows(i)("fec_comp_origen").ToString <> "" Then
                        .Cells((fila + i), "AA") = Date.Parse(tbDatos.Rows(i)("fec_comp_origen")).ToString("dd/MM/yyyy")
                        Dim tc2 As DataTable = obj.nCrudListarBD("select * from tipo_documento where id='" & tbDatos.Rows(i)("tip_comp_origen").ToString & "'", CadenaConexion)
                        If tc2.Rows.Count = 0 Then
                            .Cells((fila + i), "AB") = ""
                        Else
                            .Cells((fila + i), "AB") = tc2.Rows(0)("codigo").ToString
                        End If

                        .Cells((fila + i), "AC") = tbDatos.Rows(i)("serie_comp_origen").ToString
                        .Cells((fila + i), "AE") = tbDatos.Rows(i)("numero_comp_origen").ToString
                    End If
                    .Cells((fila + i), "AI") = "1"
                    If tc.Rows(0)("codigo").ToString = "03" Then
                        .Cells((fila + i), "AP") = "0"
                    Else
                        .Cells((fila + i), "AP") = "1"
                    End If
                    filaTable.Rows.Add(.Cells((fila + i), "AQ").Value)
                Next
                Dim filaRest As Integer = (fila + trKardex)

                'MsgBox(.Cells((17 + trKardex), "A").Value)
                If .Cells(filaRest, "A").Value = "" Then
                    .Rows(filaRest).Delete()
                End If
                'If .Cells(fila, "A").Value = "" Then
                '.Rows(fila).Delete()
                'End If


                '.Cells(filaRest, "I") = "=(G" & filaRest & "-H" & filaRest & ")"
            End With
            'MsgBox("No cierres esto hasta ver el resultado")
            'APrueba.Close(SaveChanges:=False) 'O True, como prefieras
            a.Quit()
            Me.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Enabled = True
    End Sub
    Private Sub generarTxt()
        Dim sRenglon As String = Nothing
        Dim strStreamW As Stream = Nothing
        Dim strStreamWriter As StreamWriter = Nothing
        Dim ContenidoArchivo As String = Nothing
        ' Donde guardamos los paths de los archivos que vamos a estar utilizando ..
        Dim PathArchivo As String
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from empresas where id='" & CodigoEmpresaSession & "'", CadenaConexion)
        Dim nomArchivo As String
        nomArchivo = "LE" & data.Rows(0)("ruc").ToString & data.Rows(0)("periodo").ToString & mesPeriodo & "00" & codPLECompra & "001111"

        Try

            If Directory.Exists(CARPETA_EXCELS & "PLE\") = False Then ' si no existe la carpeta se crea
                Directory.CreateDirectory(CARPETA_EXCELS & "PLE\")
            End If

            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            PathArchivo = CARPETA_EXCELS & "PLE\" & nomArchivo & ".txt" ' Se determina el nombre del archivo con la fecha actual

            If File.Exists(PathArchivo) Then
                My.Computer.FileSystem.DeleteFile(PathArchivo)
            End If

            'verificamos si existe el archivo
            If File.Exists(PathArchivo) Then
                strStreamW = File.Open(PathArchivo, FileMode.Open) 'Abrimos el archivo
            Else
                strStreamW = File.Create(PathArchivo) ' lo creamos
            End If

            strStreamWriter = New StreamWriter(strStreamW, System.Text.Encoding.Default) ' tipo de codificacion para escritura


            'escribimos en el archivo
            For i As Integer = 0 To filaTable.Rows.Count - 1
                strStreamWriter.WriteLine(filaTable.Rows(i)(0))
            Next
            strStreamWriter.Close() ' cerramos
            MsgBox("¡Archivo creado con éxito en la ruta " & CARPETA_EXCELS & "PLE!")
        Catch ex As Exception
            MsgBox("Error al Guardar la ingormacion en el archivo. " & ex.ToString, MsgBoxStyle.Critical, Application.ProductName)
            strStreamWriter.Close() ' cerramos
        End Try
    End Sub
    Private Sub btnAcciones_Click(sender As Object, e As EventArgs)
        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        frmAccionCompras.idComprobante = dgvLista.Rows(f).Cells("id").Value
        frmAccionCompras.idTipoComprobante = dgvLista.Rows(f).Cells("id_tipo_comprobante").Value
        frmAccionCompras.montoAbono = dgvLista.Rows(f).Cells("abono").Value
        frmAccionCompras.ShowDialog()
    End Sub
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        realizarConsulta()
    End Sub

    Private Sub dgvLista_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLista.SelectionChanged
        'MsgBox(codigoCeldaGrid)
        On Error Resume Next
        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        If dgvLista.Rows(f).Cells("tipo_compra").Value.ToString.StartsWith("CRD/LET") And Decimal.Parse(dgvLista.Rows(f).Cells("abono").Value.ToString) <= Decimal.Parse(dgvLista.Rows(f).Cells("total").Value.ToString) Then
            btnCanje.Text = "ESTADO LETRA"
        ElseIf Not dgvLista.Rows(f).Cells("tipo_compra").Value.ToString.StartsWith("CRD/LET") And Decimal.Parse(dgvLista.Rows(f).Cells("abono").Value.ToString) <= Decimal.Parse(dgvLista.Rows(f).Cells("total").Value.ToString) Then
            btnCanje.Text = "CANJE A LETRA"
        End If
        If dgvLista.Rows(f).Cells("estadoCompra").Value.ToString.StartsWith("CANCELADO") Then
            If dgvLista.Rows(f).Cells("tipo_compra").Value.ToString.StartsWith("CRD/LET") Then
                btnCanje.Enabled = True
            Else
                btnCanje.Enabled = False
            End If
        Else
            btnCanje.Enabled = True
        End If

        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from comprobante_compra where id='" & codigoComprobante() & "'", CadenaConexion)
        With data
            If .Rows(0)("estado_comprobante").ToString = "E" Then
                btnPagos.Enabled = False
                btnCredito.Enabled = False
                btnDebito.Enabled = False
                'btnEliminar.Enabled = False
                btnModificar.Enabled = False
            ElseIf .Rows(0)("estado_comprobante").ToString = "P" Then
                btnPagos.Enabled = False
                btnCredito.Enabled = False

                btnDebito.Enabled = False
                'btnEliminar.Enabled = True
                btnModificar.Enabled = True
            Else
                If Decimal.Parse(dgvLista.Rows(f).Cells("abono").Value) = 0 Then
                    'btnEliminar.Enabled = True
                ElseIf Decimal.Parse(dgvLista.Rows(f).Cells("abono").Value) > 0 Then
                    'btnEliminar.Enabled = False
                End If
                If Decimal.Parse(dgvLista.Rows(f).Cells("abono").Value) <= Decimal.Parse(dgvLista.Rows(f).Cells("total").Value) And Not .Rows(0)("tipo_compra").ToString.StartsWith("LETRA") Then
                    ''PARA EL CASO DE RETENCION
                    'If dgvLista.Rows(f).Cells("sujeto").Value.ToString.Trim.StartsWith("RETEN") Then
                    '    Dim dt As New DataTable
                    '    dt = obj.nCrudListarBD("select * from retenciones where operacion='COMPRA' and id_comprobante='" & codigoComprobante() & "'", CadenaConexion)
                    '    If dt.Rows.Count > 0 Then
                    '        If dt.Rows(0)("tipo").ToString.StartsWith("PENDIENTE") Then
                    '            btnPagos.Enabled = False
                    '        End If
                    '    Else
                    '        btnPagos.Enabled = True
                    '    End If
                    'Else
                    btnPagos.Enabled = True
                    'End If

                Else
                    btnPagos.Enabled = False
                End If

                btnCredito.Enabled = True
                btnDebito.Enabled = True
                btnModificar.Enabled = False
            End If
        End With
    End Sub
    Private Sub dgvLista_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvLista.ColumnHeaderMouseClick
        formatoGrillaCompras()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        habilitarBusquedas()
    End Sub
    Private Sub btnLDCompra_Click(sender As Object, e As EventArgs) Handles btnLDCompra.Click
        frmWebCompras.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim verif As Boolean = False
        For Each row As DataGridViewRow In dgvLista.Rows
            If row.Cells(0).Value = True Then
                verif = True
            End If
        Next
        If verif = True Then

            If MessageBox.Show("Está apunto de ELIMINAR el/los comprobante(s) seleccionado(s)." & vbCrLf & "¿Desea realizar este proceso?", "ELIMINACIÓN DE COMPROBANTE DE COMPRA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                For Each row As DataGridViewRow In dgvLista.Rows
                    If row.Cells(0).Value = True Then
                        'ELIMINAR EN COMPROBANTE DE COMPRA
                        obj.nEjecutarQueryBD("delete from comprobante_compra where id='" & row.Cells("id").Value.ToString & "'", CadenaConexion)
                        'ELIMINAR EN COMPROBANTE DE COMPRA
                        obj.nEjecutarQueryBD("delete from comprobante_nota_credito where id_comprobante='" & row.Cells("id").Value.ToString & "'", CadenaConexion)
                        'ELIMINAR EN COMPROBANTE DE COMPRA
                        obj.nEjecutarQueryBD("delete from abono_pagos_compras where id_compra='" & row.Cells("id").Value.ToString & "'", CadenaConexion)
                        'ELIMINAR EN COMPROBANTE DE COMPRA
                        obj.nEjecutarQueryBD("delete from asientos_abono_compras where id_compra='" & row.Cells("id").Value.ToString & "'", CadenaConexion)
                        'ELIMINAR ASIENTOS DE COMPROBANTE DE COMPRA
                        obj.nEjecutarQueryBD("delete from asientos_comprobante_compra where id_comprobante_compra='" & row.Cells("id").Value.ToString & "'", CadenaConexion)
                        'ELIMINAR ASIENTOS DE COMPROBANTE DE COMPRA EN LIBRO DIARIO
                        obj.nEjecutarQueryBD("delete from asientos_libro_diario where id_comprobante='C" & row.Cells("id").Value.ToString & "'", CadenaConexion)
                        MsgBox("Comprobante(s) ELIMINADO(S) del Sistema correctamente")
                    End If
                Next
            End If
            Me.realizarConsulta()
        End If
    End Sub
    Private Sub btnCanjear_Click(sender As Object, e As EventArgs) Handles btnCanjear.Click
        realizarCanje()
    End Sub
    Private Sub realizarCanje()
        Dim dataComp As New DataTable
        With dataComp
            .Columns.Add("id")
            .Columns.Add("serie")
            .Columns.Add("numero")
            .Columns.Add("glosa")
            .Columns.Add("total")
            .Columns.Add("pagado")
            .Columns.Add("resta")
            .Columns.Add("abono")
            .Columns.Add("fecha")
        End With
        Dim dtComp As New DataTable
        dtComp = obj.nCrudListarBD("select * from comprobante_compra where id='" & codigoComprobante() & "'", CadenaConexion)

        Dim data As New DataTable
        data = obj.nCrudListarBD("select  IsNull(sum(monto), 0) as 'abono' from abono_pagos_compras where id_compra='" & codigoComprobante() & "'", CadenaConexion)
        Dim abono As Decimal = 0
        If data.Rows.Count > 0 Then
            abono = Decimal.Parse(data.Rows(0)("abono").ToString)
        End If

        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid

        'Dim dtLetra As New DataTable
        'dtLetra = obj.nCrudListarBD("select * from canje_letra where id_comprobante='" & codigoComprobante() & "'", CadenaConexion)
        'Dim abonoLetra As Decimal = 0
        'If dtLetra.Rows.Count > 0 Then
        '    Dim dtLetraAbono As New DataTable
        '    dtLetraAbono = obj.nCrudListarBD("select sum(total) as 'total' from canje_letra where id_comprobante='" & codigoComprobante() & "'", CadenaConexion)
        '    abonoLetra = Decimal.Parse(dtLetraAbono.Rows(0)("total").ToString)
        'End If

        'buscar si hay detraccion, retencion o percepcion
        Dim dtImp As New DataTable
        dtImp = obj.nCrudListarBD("select * from asientos_comprobante_compra where id_comprobante_compra='" & codigoComprobante() & "'", CadenaConexion)
        If dtImp.Rows.Count > 0 Then
            abono = abono + Decimal.Parse(dtImp.Rows(0)("valor_detraccion").ToString)
        End If

        If Decimal.Parse(dgvLista.Rows(f).Cells("total").Value) > (abono) Then
            Dim diferencia As Decimal = 0
            Dim pagado As Decimal = 0
            diferencia = (Decimal.Parse(dtComp.Rows(0)("total").ToString) - abono)
            pagado = abono
            dataComp.Rows.Add(codigoComprobante, dtComp.Rows(0)("serie_comprobante").ToString, dtComp.Rows(0)("numero_comprobante").ToString, dtComp.Rows(0)("glosa").ToString, dtComp.Rows(0)("total").ToString, pagado, diferencia, diferencia, Date.Parse(dtComp.Rows(0)("fec_pago").ToString).ToString("dd/MM/yyyy"))

            'resetear sumas
            txtTotalCanjes.Text = "0.00"
            txtDeuda2.Text = "0.00"
            If txtTotalCanjes.Text.Trim <= txtDeuda2.Text.Trim Then
                Dim f1 As Integer
                f1 = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
                With frmCanjeLetraComprobantes
                    .Text = "CANJE DE " & dgvLista.Rows(f1).Cells("comprobante").Value.ToString & " DE COMPRA POR LETRA"
                    .lblTitulo.Text = "CANJE " & dgvLista.Rows(f1).Cells("comprobante").Value.ToString & " COMPRA POR LETRA"
                    .tipo = "COMPRA"
                    .codComprobante = codigoComprobante()
                    .dataComprobante = dataComp
                    .cargarDatosComprobante()
                    .Show()
                End With
            Else
                MsgBox("No se puede realizar canjes de letra para este comprobante.")
            End If
        Else
            MsgBox("No se puede realizar el canje a letra, ha llegado al tope del monto")
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        habilitarBusquedas()
    End Sub

    Private Sub btnPagarLetra_Click(sender As Object, e As EventArgs) Handles btnPagarLetra.Click
        If iCarga = 1 Then
            'VERIFICAR SI SE SELECCIONO UNA LETRA PARA PAGAR
            Dim verificar As Boolean = False
            For Each row As DataGridViewRow In dgvLetras.Rows
                If row.Cells(0).Value = True Then
                    verificar = True
                    Exit For
                End If
            Next
            If verificar = True Then
                Dim f As Integer
                f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
                'Dim idComprobante As Integer = 0
                'idComprobante = dgvLetras.Rows(f).Cells(0).Value

                Dim dataComp As New DataTable
                With dataComp
                    .Columns.Add("id")
                    .Columns.Add("serie")
                    .Columns.Add("numero")
                    .Columns.Add("librador")
                    .Columns.Add("moneda")
                    .Columns.Add("total")
                    .Columns.Add("pagado")
                    .Columns.Add("resta")
                    .Columns.Add("abono")
                    .Columns.Add("fecha")
                End With

                For Each fila As DataGridViewRow In dgvLetras.Rows
                    With fila
                        If .Cells(0).Value = True Then
                            Dim data As New DataTable
                            'MsgBox(.Cells("id_comprobante").Value)
                            data = obj.nCrudListarBD("select IsNull(sum(monto), 0)  as 'abono' from abono_pagos_compras where id_compra='" & .Cells("idL").Value & "'", CadenaConexion)

                            Dim diferencia As Decimal = 0
                            Dim pagado As Decimal = 0
                            If data.Rows.Count > 0 Then
                                If data.Rows(0)("abono").ToString.Length > 0 Then
                                    diferencia = (Decimal.Parse(.Cells("montoL").Value) - Decimal.Parse(data.Rows(0)("abono").ToString))
                                    pagado = Decimal.Parse(data.Rows(0)("abono").ToString)
                                End If
                            End If
                            Dim dt As New DataTable
                            dt = obj.nCrudListarBD("select c.id,m.id,m.codigo as 'moneda' from comprobante_compra c inner join tipo_moneda m on c.id_moneda=m.id where c.id='" & .Cells("id_comprobante").Value & "'", CadenaConexion)
                            dataComp.Rows.Add(.Cells("idL").Value, .Cells("serieL").Value, .Cells("numeroL").Value, .Cells("librado").Value, dt.Rows(0)("moneda"), .Cells("montoL").Value, pagado, diferencia, diferencia, Date.Parse(.Cells("fec_vencimientoL").Value).ToString("dd/MM/yyyy"))
                        End If
                    End With
                Next

                With frmAbonoLetras
                    .Show()
                    .dataComprobante = dataComp
                    .cargarDatosComprobante()
                End With
            Else
                MsgBox("No se ha seleccionado una Letra para pagar")
            End If
        End If
    End Sub

    Private Sub dgvLetras_SelectionChanged(sender As Object, e As EventArgs) Handles dgvLetras.SelectionChanged
        Dim f As Integer
        f = dgvLetras.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        'si se marcó un check al menos
        For Each fila As DataGridViewRow In dgvLetras.Rows
            With fila
                If .Cells(0).Value = True Then
                    btnPagarLetra.Enabled = True
                    Exit For
                End If
            End With
        Next

        Dim dtLetras As New DataTable
        dtLetras = obj.nCrudListarBD("SELECT cuenta as 'cuentaL',glosa as 'glosaL',debe as 'debeL',haber as 'haberL' FROM asientos_libro_diario where id_comprobante='LTC" & dgvLetras.Rows(f).Cells("idL").Value & "' order by id asc", CadenaConexion)
        dgvCuentasLetras.DataSource = dtLetras

        Dim debe, haber As Decimal
        For Each row As DataGridViewRow In dgvCuentasLetras.Rows
            debe += Decimal.Parse(row.Cells("debeL").Value)
            haber += Decimal.Parse(row.Cells("haberL").Value)
        Next
        txtTotalDebeL.Text = debe
        txtTotalHaberL.Text = haber
        'txtDiferenciaL.Text = debe - haber




        'abonos de letras
        'Dim dtAC As New DataTable
        'dtAC = obj.nCrudListarBD("select * from abono_pagos_compras where id_compra='" & dgvLetras.Rows(f).Cells("idL").Value & "'", CadenaConexion)
        Dim dtALetras As New DataTable
        dtALetras = obj.nCrudListarBD("SELECT cuenta as 'cuentaAL',descripcion_pago as 'glosaAL',debe as 'debeAL',haber as 'haberAL' FROM asientos_abono_compras where id_compra='" & dgvLetras.Rows(f).Cells("id_comprobante").Value & "' and tipo_tasa_detraccion='LETRA' order by id asc", CadenaConexion)
        If dtALetras.Rows.Count > 0 Then
            dgvAbonoLetra.Visible = True
            dgvAbonoLetra.DataSource = dtALetras

            Dim debeA, haberA As Decimal
            For Each row As DataGridViewRow In dgvAbonoLetra.Rows
                debeA += Decimal.Parse(row.Cells("debeAL").Value)
                haberA += Decimal.Parse(row.Cells("haberAL").Value)
            Next
            txtTotalDebeAL.Text = debeA
            txtTotalHaberAL.Text = haberA
            'txtDiferenciaL.Text = debe - haber
        Else
            dgvAbonoLetra.Visible = False
            txtTotalDebeAL.Text = "0.00"
            txtTotalHaberAL.Text = "0.00"
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If anexo = True And dgvLista.RowCount > 0 Then
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid

            With frmIngresosGenericos
                .txtIdComprobante.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                .lblComprobante.Text = "VER COMP."
                '.lblComprobante.BackColor = Color.Green
                '.lblComprobante.ForeColor = Color.White
                Me.Close()
            End With
        End If
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        frmImportarCompras.Show()
    End Sub

    Private Sub chkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodos.CheckedChanged
        If chkTodos.Checked = True Then
            For Each row As DataGridViewRow In dgvLista.Rows
                row.Cells(0).Value = True
            Next
        Else
            For Each row As DataGridViewRow In dgvLista.Rows
                row.Cells(0).Value = False
            Next
        End If
    End Sub

End Class