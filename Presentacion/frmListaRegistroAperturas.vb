Imports Negocio
Imports System.IO
Imports Entidades

Public Class frmListaRegistroAperturas
    Dim obj As New nCrud
    Dim iCarga As Integer = 0
    Dim filaTable As New DataTable
    Dim codPLECompra As String = "080100"
    Dim anioPeriodo As String = ""
    Dim mesPeriodo As String = ""
    Dim lista As New DataTable

    Private Function codigoComprobante() As String
        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        Dim idComprobante As String = ""
        idComprobante = dgvLista.Rows(f).Cells(0).Value
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

        With cboTipo
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub
    Private Function querysPorCombinacion() As String
        Dim query As String = ""
        Dim queryRangoFechas As String = ""
        query = "select * from vista_compras_con_abonos where 1=1 "
        'COMBINACION DE "BUSCAR POR"
        If cboTipo.SelectedValue.ToString = "1" And txtDato.Text.Trim.Length > 1 Then
            query += "and num_dni like '" & txtDato.Text.Trim & "%' "
        ElseIf cboTipo.SelectedValue.ToString = "2" And txtDato.Text.Trim.Length > 1 Then
            query += "and razon_social like '" & txtDato.Text.Trim & "%' "
        ElseIf cboTipo.SelectedValue.ToString = "3" And txtDato.Text.Trim.Length > 1 Then
            query += "and numero like '" & txtDato.Text.Trim & "%' "
        ElseIf cboTipo.SelectedValue.ToString = "4" Then
            query += "and tipo_compra='CREDITO' "
        ElseIf cboTipo.SelectedValue.ToString = "5" Then
            query += "and tipo_compra='CONTADO' "
        ElseIf cboTipo.SelectedValue.ToString = "6" Then
            query += "and estado='FINALIZADO' "
        ElseIf cboTipo.SelectedValue.ToString = "7" Then
            query += "and estado='PENDIENTE' "
        Else
            query += ""
        End If
        'FIN COMBINACION DE "BUSCAR POR"

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
        Dim data As New DataTable
        data = obj.nCrudListarBD(querysPorCombinacion(), CadenaConexion)
        dgvLista.DataSource = data
        formatoGrillaCompras()
    End Sub
    Private Sub frmListaComprobanteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTipo()
        dgvLista.RowTemplate.Height = 35
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        dgvPagos.RowTemplate.Height = 25
        cebrasDatagrid(dgvPagos, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        dgvAsientos.RowTemplate.Height = 25
        cebrasDatagrid(dgvAsientos, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        cargarComprobantes()
        cargarPeriodos()
        dtDesde.Value = DateTime.Today.AddMonths("-4")
        iCarga = 1
        cboAnio.SelectedValue = DateTime.Now.ToString("yyyy")
        cboMes.SelectedValue = DateTime.Now.Month
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
                row.DefaultCellStyle.ForeColor = Drawing.Color.FromArgb(252, 0, 0)
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
        lblMontos.Text = monto
        lblIgv.Text = igv
        lblTotal.Text = total
    End Sub
    Private Sub btnDetalle_Click(sender As Object, e As EventArgs) Handles btnDetalle.Click

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
        lblTitulo.Text = "LISTA DE COMPRAS"
        grupoBusqueda.Enabled = True
    End Sub
    Private Sub btnPagos_Click(sender As Object, e As EventArgs)
        frmAccionPagosCompras.idComprobante = "0"
        frmAccionPagosCompras.idComprobante = codigoComprobante()
        frmAccionPagosCompras.ShowDialog()
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        frmModificarCompraP.idCompra = codigoComprobante()
        frmModificarCompraP.Show()
    End Sub
    Private Sub btnDebito_Click(sender As Object, e As EventArgs)
        With frmNuevaNotaDebito
            .Text = "Nueva Nota de Débito Compra - N° registro: " & codigoComprobante()
            .codComprobante = codigoComprobante()
            .codTipoComprobante = codigoTipoComprobante()
            .cargarDatosComprobante()
            .Show()
        End With
    End Sub
    Private Sub btnCredito_Click(sender As Object, e As EventArgs)
        With frmNuevaNotaCredito
            .Text = "Nueva Nota de Crédito - COMPRA- N° registro: " & codigoComprobante()
            .codComprobante = codigoComprobante()
            .codTipoComprobante = codigoTipoComprobante()
            .cargarDatosComprobante()
            .Show()
        End With
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)
        Dim dtComp As New DataTable
        dtComp = obj.nCrudListarBD("select * from comprobante_compra where id='" & codigoComprobante() & "'", CadenaConexion)

        If dtComp.Rows(0)("estado_comprobante") <> "E" Then
            If MessageBox.Show("Está apunto de ANULAR/ELIMINAR el comprobante seleccionado." & vbCrLf & "¿Desea realizar este proceso?", "Estado del comprobante de compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Dim data As New DataTable
                data = obj.nCrudListarBD("select * from asientos_comprobante_compra where id_comprobante_compra='" & codigoComprobante() & "'", CadenaConexion)
                Dim objCC As New nComprobanteCompra
                Dim entiCCompraAsiento As New ComprobanteCompraEntity
                With entiCCompraAsiento
                    .id_comprobante = codigoComprobante()
                    .numero_cuo = objCC.nObtenerCUO_CompraBD(CadenaConexion)
                    .tipo_compra = "CONTADO"
                    .numero_maquina = "-"
                    .id_tipo_comprobante = data.Rows(0)("id_tipo_comprobante").ToString
                    .fec_emision = Date.Parse(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))
                    .fec_pago = Date.Parse(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))
                    .serie_comprobante = data.Rows(0)("serie_comprobante").ToString
                    .numero_comprobante = data.Rows(0)("numero_comprobante").ToString
                    .cod_dni = "6"
                    .num_dni = data.Rows(0)("num_dni").ToString
                    .razon_social = data.Rows(0)("razon_social").ToString
                    .valor_facturado = data.Rows(0)("valor_facturado").ToString
                    .base_imponible = data.Rows(0)("base_imponible").ToString
                    .valor_exonerado = 0
                    .valor_inafecto = 0
                    .valor_isc = 0
                    .valor_igv = data.Rows(0)("valor_igv").ToString
                    .otros_base_imponible = 0
                    .total = data.Rows(0)("total").ToString
                    .tipo_cambio = data.Rows(0)("tipo_cambio").ToString
                    .serie_comp_origen = data.Rows(0)("serie_comp_origen").ToString
                    .numero_comp_origen = data.Rows(0)("numero_comp_origen").ToString
                    .fec_comp_origen = data.Rows(0)("fec_comp_origen").ToString
                    .serie_dua = "0"
                    .numero_dua = "0"
                    .anio_dua = data.Rows(0)("anio_dua").ToString
                    .numero_detraccion = data.Rows(0)("numero_detraccion").ToString
                    .tipo_tasa_detraccion = "0"
                    .tasa_detraccion = data.Rows(0)("tasa_detraccion").ToString
                    .valor_detraccion = data.Rows(0)("valor_detraccion").ToString
                    .fecha_detraccion = data.Rows(0)("fecha_detraccion").ToString
                    .estado = 1
                End With

                For Each row As DataRow In data.Rows
                    With row
                        entiCCompraAsiento.tip_comp_origen = "-"
                        entiCCompraAsiento.cuenta = .Item("cuenta").ToString
                        entiCCompraAsiento.glosa = "ANULACION DEL COMPROBANTE DE COMPRA"
                        entiCCompraAsiento.debe = .Item("haber").ToString
                        entiCCompraAsiento.haber = .Item("debe").ToString
                        entiCCompraAsiento.impuesto = .Item("impuesto").ToString
                        entiCCompraAsiento.serie = .Item("serie").ToString
                        entiCCompraAsiento.numero = .Item("numero").ToString
                        entiCCompraAsiento.operacion = .Item("operacion").ToString
                        Dim rptaRACC As String = objCC.nRegistrarAsientoComprobanteCompraBD(entiCCompraAsiento, CadenaConexion)
                        If rptaRACC <> "ok" Then
                            MsgBox("Error en el registro en el asiento del comprobante: " & rptaRACC)
                        End If
                    End With
                Next
                'CAMBIO DE ESTADO DE COMPROBANTE DE COMPRA
                MsgBox("ACTUALIZACION DE COMPROBANTE: " & obj.nCrudActualizarBD("@", "comprobante_compra", "estado_comprobante", "E", "id='" & codigoComprobante() & "'", CadenaConexion))
                Me.realizarConsulta()
            End If
        Else
            MessageBox.Show("No se puede ANULAR/ELIMINAR un comprobante ya anulado.", "Estado del comprobante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub btnCanje_Click(sender As Object, e As EventArgs)
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
        Dim diferencia As Decimal = 0
        Dim pagado As Decimal = 0
        diferencia = (Decimal.Parse(dtComp.Rows(0)("total").ToString) - abono)
        pagado = abono
        dataComp.Rows.Add(codigoComprobante, dtComp.Rows(0)("serie_comprobante").ToString, dtComp.Rows(0)("numero_comprobante").ToString, dtComp.Rows(0)("glosa").ToString, dtComp.Rows(0)("total").ToString, pagado, diferencia, diferencia, Date.Parse(dtComp.Rows(0)("fec_pago").ToString).ToString("dd/MM/yyyy"))

        With frmCanjeLetraComprobantes
            .Text = "Canje de Comprobante Compra por Letra"
            .codComprobante = codigoComprobante()
            .dataComprobante = dataComp
            .cargarDatosComprobante()
            .Show()
        End With
    End Sub
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        realizarConsulta()
    End Sub
    Private Sub txtDato_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDato.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            realizarConsulta()
        End If
    End Sub
    Public Sub realizarConsulta()
        cargarComprobantes()
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        frmNuevaCompraP.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        generarExcelCompras()
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
                    .Cells((fila + i), "F") = tbDatos.Rows(i)("id_tipo_comprobante")
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
    Private Sub btnGenerarPle_Click(sender As Object, e As EventArgs)
        generarExcelComprasPle()
        generarTxt()
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
                    .Cells((fila + i), "AP") = "1"
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
        nomArchivo = "LE" & data.Rows(0)("ruc").ToString & "2016" & mesPeriodo & "00" & codPLECompra & "001111"

        Try

            If Directory.Exists(CARPETA_EXCELS & "PLE\") = False Then ' si no existe la carpeta se crea
                Directory.CreateDirectory(CARPETA_EXCELS & "PLE\")
            End If

            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            PathArchivo = CARPETA_EXCELS & "PLE\" & nomArchivo & ".txt" ' Se determina el nombre del archivo con la fecha actual

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
            MsgBox("¡Archivo creado con éxito en la ruta D:/excel/PLE/!")
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
    'Private Sub dgvLista_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLista.CellContentDoubleClick
    '    Dim f As Integer
    '    f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
    '    frmAccionesCompras.idComprobante = codigoComprobante()
    '    frmAccionesCompras.idTipoComprobante = dgvLista.Rows(f).Cells("id_tipo_comprobante").Value
    '    frmAccionesCompras.ShowDialog()
    '    formatoGrillaCompras()
    'End Sub
    Private Sub dgvLista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLista.CellClick
        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from comprobante_compra where id='" & codigoComprobante() & "'", CadenaConexion)
        With data
            If .Rows(0)("estado_comprobante").ToString = "E" Then
                btnModificar.Enabled = False
            ElseIf .Rows(0)("estado_comprobante").ToString = "P" Then
                btnModificar.Enabled = True
            Else
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
End Class