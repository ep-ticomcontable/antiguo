Imports Negocio
Imports System.IO
Imports Entidades

Public Class frmListaRegistroLibroDiario
    Dim obj As New nCrud
    Dim iCarga As Integer = 0
    Dim filaTable As New DataTable
    Dim codPLECompra As String = "080100"
    Dim anioPeriodo As String = ""
    Dim mesPeriodo As String = ""
    Dim lista As New DataTable
    Dim listaArray As New List(Of String)

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
    Private Sub cargarCaja()
        Dim dataAnio As New DataTable
        dataAnio.Columns.Add("codigo")
        dataAnio.Columns.Add("descripcion")
        'dataAnio.Rows.Add(0, "SELECCIONE")
        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select * from caja_configuracion where tipo='BANCOS' and estado=1 order by id asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                dataAnio.Rows.Add(row.Item(0).ToString, row.Item("descripcion").ToString)
            Next
            With cboCaja
                .DataSource = dataAnio
                .ValueMember = "codigo"
                .DisplayMember = "descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar las cajas")
        End Try
    End Sub

    Private Function querysPorCombinacion() As String
        Dim query As String = ""
        Dim queryRangoFechas As String = ""
        Dim dCaja As New DataTable
        dCaja = obj.nCrudListarBD("select * from caja_configuracion where id='" & cboCaja.SelectedValue.ToString & "'", CadenaConexion)
        query = "select * from vista_listaRegistrosCajaBancos where 1=1 "
        If dCaja.Rows.Count > 0 Then
            query += "and (cuenta<>'" & dCaja.Rows(0)("cuenta").ToString & "' or id_comprobante like 'A%')"
        End If

        'COMBINACION DE "BUSCAR POR"
        If cboCaja.SelectedValue.ToString <> "0" Then
            query += "and id_caja='" & cboCaja.SelectedValue.ToString & "' "
            'ElseIf cboTipo.SelectedValue.ToString = "2" And txtDato.Text.Trim.Length > 1 Then
            '    query += "and razon_social like '" & txtDato.Text.Trim & "%' "
            'ElseIf cboTipo.SelectedValue.ToString = "3" And txtDato.Text.Trim.Length > 1 Then
            '    query += "and numero like '" & txtDato.Text.Trim & "%' "
            'ElseIf cboTipo.SelectedValue.ToString = "4" Then
            '    query += "and tipo_compra='CREDITO' "
            'ElseIf cboTipo.SelectedValue.ToString = "5" Then
            '    query += "and tipo_compra='CONTADO' "
            'ElseIf cboTipo.SelectedValue.ToString = "6" Then
            '    query += "and estado='FINALIZADO' "
            'ElseIf cboTipo.SelectedValue.ToString = "7" Then
            '    query += "and estado='PENDIENTE' "
        Else
            query += ""
        End If
        'FIN COMBINACION DE "BUSCAR POR"
        'MsgBox(query)

        'FIN COMBINACION DE "MONEDAS"
        'If iCarga = 1 Then
        '    queryRangoFechas = " and DATEADD(dd, 0, DATEDIFF(dd, 0, fec_emision))>='" & dtDesde.Value().ToString("yyyy-MM-dd") & "' and DATEADD(dd, 0, DATEDIFF(dd, 0, fec_emision))<='" & dtHasta.Value().ToString("yyyy-MM-dd") & "' "
        '    'COMBINACION DE "AÑO & MES"
        '    If cboAnio.SelectedValue.ToString <> "0" Then
        '        queryRangoFechas = ""
        '        query += "and year(fec_emision)='" & cboAnio.SelectedValue.ToString & "' "
        '    End If
        '    If cboMes.SelectedValue.ToString <> "0" Then
        '        queryRangoFechas = ""
        '        query += "and month(fec_emision)='" & cboMes.SelectedValue.ToString & "' "
        '    End If
        '    'FIN COMBINACION DE "AÑO & MES"
        'End If

        query += queryRangoFechas & "  order by id asc"
        'MsgBox(query)
        Return query
    End Function

    Private Sub cargarDatos()

        Dim data As New DataTable
        Dim query As String

        Dim cuentas As New DataTable
        With cuentas
            .Columns.Add("id")
            .Columns.Add("id_comprobante")
            .Columns.Add("asiento")
            .Columns.Add("fecha_operacion")
            .Columns.Add("glosa")
            .Columns.Add("cuenta")
            .Columns.Add("denominacion")
            .Columns.Add("debe")
            .Columns.Add("haber")
        End With

        query = "select id,id_comprobante,'' as 'asiento',fecha_operacion,glosa,cuenta,denominacion,debe,haber from asientos_libro_diario  where 1=1 order by id asc"
        'query = "select * from asientos_libro_diario  where fecha_operacion>='" & dtDesde.Value().ToString("yyyy-MM-dd") & "' and fecha_operacion<='" & dtHasta.Value().ToString("yyyy-MM-dd") & "' order by cuenta asc"
        data = obj.nCrudListarBD(query, CadenaConexion)
        Dim contador As Integer = 0
        For Each row As DataRow In data.Rows
            With row
                'cuentas.Rows.Add(.Item("id").ToString, .Item("id_comprobante").ToString, Date.Parse(.Item("fecha_operacion")).ToString("dd/MM/yyyy"), .Item("glosa").ToString, .Item("cuenta").ToString, obtenerDatosCuenta(.Item("cuenta").ToString), .Item("debe").ToString, .Item("haber").ToString)
                If .Item("id_comprobante").ToString.StartsWith("A") And Not .Item("id_comprobante").ToString.StartsWith("ABC") And Not .Item("id_comprobante").ToString.StartsWith("ABV") And Not .Item("id_comprobante").ToString.StartsWith("ABPLA") Then
                    'cuentas.Rows.Add(.Item("id_comprobante").ToString & "#" & .Item("id").ToString, "-", "-", "ASIENTO DE APERTURA", "-", "-", "0", "0")
                    cuentas.Rows.Add(.Item("id").ToString, .Item("id_comprobante").ToString, "APERTURA", Date.Parse(.Item("fecha_operacion")).ToString("dd/MM/yyyy"), .Item("glosa").ToString, .Item("cuenta").ToString, obtenerDatosCuenta(.Item("cuenta").ToString), .Item("debe").ToString, .Item("haber").ToString)
                ElseIf .Item("id_comprobante").ToString.StartsWith("C") And Not .Item("id_comprobante").ToString.StartsWith("CAJA") And Not .Item("id_comprobante").ToString.StartsWith("CMD") Then
                    'cuentas.Rows.Add(.Item("id_comprobante").ToString, "-", "-", "ASIENTO DE COMPRAS", .Item("id").ToString, "-", "0", "0")
                    cuentas.Rows.Add(.Item("id").ToString, .Item("id_comprobante").ToString, "COMPRAS", Date.Parse(.Item("fecha_operacion")).ToString("dd/MM/yyyy"), .Item("glosa").ToString, .Item("cuenta").ToString, obtenerDatosCuenta(.Item("cuenta").ToString), .Item("debe").ToString, .Item("haber").ToString)
                ElseIf .Item("id_comprobante").ToString.StartsWith("V") Then
                    'cuentas.Rows.Add(.Item("id_comprobante").ToString, "-", "-", "ASIENTO DE VENTAS", .Item("id").ToString, "-", "0", "0")
                    cuentas.Rows.Add(.Item("id").ToString, .Item("id_comprobante").ToString, "VENTAS", Date.Parse(.Item("fecha_operacion")).ToString("dd/MM/yyyy"), .Item("glosa").ToString, .Item("cuenta").ToString, obtenerDatosCuenta(.Item("cuenta").ToString), .Item("debe").ToString, .Item("haber").ToString)
                ElseIf .Item("id_comprobante").ToString.StartsWith("CAJA") Then
                    'cuentas.Rows.Add(.Item("id_comprobante").ToString, "-", "-", "ASIENTO DE CAJAS", .Item("id").ToString, "-", "0", "0")
                    cuentas.Rows.Add(.Item("id").ToString, .Item("id_comprobante").ToString, "CAJAS", Date.Parse(.Item("fecha_operacion")).ToString("dd/MM/yyyy"), .Item("glosa").ToString, .Item("cuenta").ToString, obtenerDatosCuenta(.Item("cuenta").ToString), .Item("debe").ToString, .Item("haber").ToString)
                ElseIf .Item("id_comprobante").ToString.StartsWith("ABC") Then
                    'cuentas.Rows.Add(.Item("id_comprobante").ToString, "-", "-", "ASIENTO DE ABONO COMPRAS", .Item("id").ToString, "-", "0", "0")
                    cuentas.Rows.Add(.Item("id").ToString, .Item("id_comprobante").ToString, "ABONO COMPRAS", Date.Parse(.Item("fecha_operacion")).ToString("dd/MM/yyyy"), .Item("glosa").ToString, .Item("cuenta").ToString, obtenerDatosCuenta(.Item("cuenta").ToString), .Item("debe").ToString, .Item("haber").ToString)
                ElseIf .Item("id_comprobante").ToString.StartsWith("ABV") Then
                    'cuentas.Rows.Add(.Item("id_comprobante").ToString, "-", "-", "ASIENTO DE ABONO VENTAS", .Item("id").ToString, "-", "0", "0")
                    cuentas.Rows.Add(.Item("id").ToString, .Item("id_comprobante").ToString, "ABONO VENTAS", Date.Parse(.Item("fecha_operacion")).ToString("dd/MM/yyyy"), .Item("glosa").ToString, .Item("cuenta").ToString, obtenerDatosCuenta(.Item("cuenta").ToString), .Item("debe").ToString, .Item("haber").ToString)
                ElseIf .Item("id_comprobante").ToString.StartsWith("RLD") Then
                    'cuentas.Rows.Add(.Item("id_comprobante").ToString, "-", "-", "REGISTRO DE LIBRO DIARIO", .Item("id").ToString, "-", "0", "0")
                    cuentas.Rows.Add(.Item("id").ToString, .Item("id_comprobante").ToString, "REGISTRO DE LIBRO DIARIO", Date.Parse(.Item("fecha_operacion")).ToString("dd/MM/yyyy"), .Item("glosa").ToString, .Item("cuenta").ToString, obtenerDatosCuenta(.Item("cuenta").ToString), .Item("debe").ToString, .Item("haber").ToString)
                ElseIf .Item("id_comprobante").ToString.StartsWith("LTC") Then
                    'cuentas.Rows.Add(.Item("id_comprobante").ToString, "-", "-", "CANJE LETRA COMPRA", .Item("id").ToString, "-", "0", "0")
                    cuentas.Rows.Add(.Item("id").ToString, .Item("id_comprobante").ToString, "CANJE LETRA COMPRA", Date.Parse(.Item("fecha_operacion")).ToString("dd/MM/yyyy"), .Item("glosa").ToString, .Item("cuenta").ToString, obtenerDatosCuenta(.Item("cuenta").ToString), .Item("debe").ToString, .Item("haber").ToString)
                ElseIf .Item("id_comprobante").ToString.StartsWith("LTV") Then
                    'cuentas.Rows.Add(.Item("id_comprobante").ToString, "-", "-", "CANJE LETRA VENTA", .Item("id").ToString, "-", "0", "0")
                    cuentas.Rows.Add(.Item("id").ToString, .Item("id_comprobante").ToString, "CANJE LETRA VENTA", Date.Parse(.Item("fecha_operacion")).ToString("dd/MM/yyyy"), .Item("glosa").ToString, .Item("cuenta").ToString, obtenerDatosCuenta(.Item("cuenta").ToString), .Item("debe").ToString, .Item("haber").ToString)
                ElseIf .Item("id_comprobante").ToString.StartsWith("CMD") Then
                    'cuentas.Rows.Add(.Item("id_comprobante").ToString, "-", "-", "ASIENTO COMODIN", .Item("id").ToString, "-", "0", "0")
                    cuentas.Rows.Add(.Item("id").ToString, .Item("id_comprobante").ToString, "COMODIN", Date.Parse(.Item("fecha_operacion")).ToString("dd/MM/yyyy"), .Item("glosa").ToString, .Item("cuenta").ToString, obtenerDatosCuenta(.Item("cuenta").ToString), .Item("debe").ToString, .Item("haber").ToString)
                ElseIf .Item("id_comprobante").ToString.StartsWith("NCC") Then
                    'cuentas.Rows.Add(.Item("id_comprobante").ToString, "-", "-", "ASIENTO COMODIN", .Item("id").ToString, "-", "0", "0")
                    cuentas.Rows.Add(.Item("id").ToString, .Item("id_comprobante").ToString, "NOTA CRÉDITO COMPRA", Date.Parse(.Item("fecha_operacion")).ToString("dd/MM/yyyy"), .Item("glosa").ToString, .Item("cuenta").ToString, obtenerDatosCuenta(.Item("cuenta").ToString), .Item("debe").ToString, .Item("haber").ToString)
                ElseIf .Item("id_comprobante").ToString.StartsWith("NCV") Then
                    'cuentas.Rows.Add(.Item("id_comprobante").ToString, "-", "-", "ASIENTO COMODIN", .Item("id").ToString, "-", "0", "0")
                    cuentas.Rows.Add(.Item("id").ToString, .Item("id_comprobante").ToString, "NOTA CRÉDITO VENTA", Date.Parse(.Item("fecha_operacion")).ToString("dd/MM/yyyy"), .Item("glosa").ToString, .Item("cuenta").ToString, obtenerDatosCuenta(.Item("cuenta").ToString), .Item("debe").ToString, .Item("haber").ToString)
                ElseIf .Item("id_comprobante").ToString.StartsWith("PL") Then
                    'cuentas.Rows.Add(.Item("id_comprobante").ToString, "-", "-", "ASIENTO COMODIN", .Item("id").ToString, "-", "0", "0")
                    cuentas.Rows.Add(.Item("id").ToString, .Item("id_comprobante").ToString, "PLANILLA", Date.Parse(.Item("fecha_operacion")).ToString("dd/MM/yyyy"), .Item("glosa").ToString, .Item("cuenta").ToString, obtenerDatosCuenta(.Item("cuenta").ToString), .Item("debe").ToString, .Item("haber").ToString)
                ElseIf .Item("id_comprobante").ToString.StartsWith("ABPLA") Then
                    'cuentas.Rows.Add(.Item("id_comprobante").ToString, "-", "-", "ASIENTO COMODIN", .Item("id").ToString, "-", "0", "0")
                    cuentas.Rows.Add(.Item("id").ToString, .Item("id_comprobante").ToString, "PAGO PLANILLA", Date.Parse(.Item("fecha_operacion")).ToString("dd/MM/yyyy"), .Item("glosa").ToString, .Item("cuenta").ToString, obtenerDatosCuenta(.Item("cuenta").ToString), .Item("debe").ToString, .Item("haber").ToString)
                End If
            End With
        Next
        'MsgBox(contador)

        dgvLista.DataSource = cuentas

        'For Each row As DataGridViewRow In dgvLista.Rows
        '    With row
        '        MsgBox(.Cells("id").Value.ToString.Substring(0, 1))
        '        If .Cells("id").Value.ToString.Substring(0, 1) Like "[A-Z]" Then
        '            MsgBox(.Cells("id").Value.ToString)
        '            listaArray.Add(.Cells("id").Value.ToString)
        '        End If
        '    End With
        'Next

        'Dim contador As Integer = 0
        'For i As Integer = 0 To dgvLista.Rows.Count - 1
        '    With dgvLista
        '        MsgBox(.Rows(i).Cells("id_comprobante").Value.ToString)
        '        If .Rows(i).Cells("id_comprobante").Value.ToString.StartsWith("A") Then
        '            contador = contador + 1
        '            MsgBox("Interno: " & contador)
        '            '.Rows.RemoveAt(DataGridView1.Rows.Count - 1)
        '        End If
        '        MsgBox("Total: " & contador)
        '    End With
        'Next
        'lista = data
        'data = Nothing
        ''formatoGrillaCompras()




        ''Cargar asientos contables
        'cuentas.Rows.Add("0", "-", "-", "ASIENTO DE APERTURA", "-", "-", "0", "0")
        'dgvLista.DataSource = cuentas

        For NumeroFila As Integer = 0 To dgvLista.Rows.Count - 1
            If dgvLista.Item("id_comprobante", NumeroFila).Value.ToString = "-" Then
                dgvLista.RowTemplate.Height = 30
                'dgvLista.Item("id", NumeroFila). = Drawing.Color.FromArgb(160, 160, 160)
                dgvLista.Item("id", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)
                'dgvLista.Item("id", NumeroFila).Style.ForeColor = Drawing.Color.FromArgb(160, 160, 160)
                dgvLista.Item("id_comprobante", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)
                dgvLista.Item("id_comprobante", NumeroFila).Style.ForeColor = Drawing.Color.FromArgb(160, 160, 160)
                dgvLista.Item("fecha_operacion", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)
                dgvLista.Item("fecha_operacion", NumeroFila).Style.ForeColor = Drawing.Color.FromArgb(160, 160, 160)
                dgvLista.Item("glosa", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)
                dgvLista.Item("cuenta", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)
                'dgvLista.Item("cuenta", NumeroFila).Style.ForeColor = Drawing.Color.FromArgb(160, 160, 160)
                dgvLista.Item("denominacion", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)
                dgvLista.Item("denominacion", NumeroFila).Style.ForeColor = Drawing.Color.FromArgb(160, 160, 160)
                dgvLista.Item("debe", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)
                dgvLista.Item("debe", NumeroFila).Style.ForeColor = Drawing.Color.FromArgb(160, 160, 160)
                dgvLista.Item("haber", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)
                dgvLista.Item("haber", NumeroFila).Style.ForeColor = Drawing.Color.FromArgb(160, 160, 160)
                dgvLista.Item("glosa", NumeroFila).Style.Font = New Font(dgvLista.Font, FontStyle.Italic)
                dgvLista.Item("glosa", NumeroFila).Style.Font = New Font(dgvLista.Font, FontStyle.Bold)
            End If
        Next
        realizarSumas()
    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = obj.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function
    Private Sub frmListaComprobanteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cargarCaja()
        dgvLista.RowTemplate.Height = 35
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        cargarDatos()
        'cargarPeriodos()
        iCarga = 1
        cboAnio.SelectedValue = DateTime.Now.ToString("yyyy")
        cboMes.SelectedValue = DateTime.Now.Month
    End Sub
    Private Sub formatoGrillaCompras()
        Dim data, nData As New DataTable
        data = obj.nCrudListarBD(querysPorCombinacion(), CadenaConexion)
        dgvLista.DataSource = data
        Dim saldoInicial As Decimal = 0
        Dim saldo As Decimal = 0
        Dim i As Integer = 0
        For Each row As DataGridViewRow In dgvLista.Rows
            If i = 0 Then
                saldoInicial = Decimal.Parse(row.Cells("debe").Value) - Decimal.Parse(row.Cells("haber").Value)
                row.Cells("saldo").Value = saldoInicial
            Else
                saldo = Decimal.Parse(row.Cells("debe").Value) - Decimal.Parse(row.Cells("haber").Value)
                row.Cells("saldo").Value = saldoInicial + saldo
                saldoInicial = row.Cells("saldo").Value
            End If
            i = +1
        Next
        realizarSumas()
    End Sub
    Private Sub realizarSumas()
        lblNumRegistros.Text = dgvLista.Rows.Count
        Dim ingresos As Decimal = 0
        Dim egresos As Decimal = 0

        For Each row As DataGridViewRow In dgvLista.Rows
            ingresos += row.Cells("debe").Value
            egresos += row.Cells("haber").Value
        Next
        lblIngresos.Text = ingresos
        lblEgresos.Text = egresos
        lblDiferencia.Text = ingresos - egresos
        lblSaldo1.Text = ingresos
        lblSaldo2.Text = egresos + Decimal.Parse(lblDiferencia.Text.Trim)
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        realizarConsulta()
    End Sub

    Private Sub txtDato_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            realizarConsulta()
        End If
    End Sub
    Public Sub realizarConsulta()
        cargarDatos()
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        frmSalidaCaja.Show()
    End Sub
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs)
        realizarConsulta()
    End Sub

    Private Sub dgvLista_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        formatoGrillaCompras()
    End Sub

    Private Sub btnAuxiliar_Click(sender As Object, e As EventArgs) Handles btnAuxiliar.Click
        frmRegistroLibroDiario.show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmListaComprobanteCompras.Show()
    End Sub

    Private Sub lblTitulo_Click(sender As Object, e As EventArgs) Handles lblTitulo.Click

        Dim dt As New DataTable ''Creas un datatable 
        dt = dgvLista.DataSource ''Almacenamos las tablas en el datatable
        Dim idd As String
        ''Recorremos los datos que estan en el datatable
        For i As Integer = 0 To dgvLista.RowCount - 1
            idd = dt.Rows(i).Item("id")
            'MsgBox(idd)
            For j As Integer = 1 To listaArray.Count - 1
                If idd = listaArray.Item(j) Then ''Si se encuentra el registro indicado
                    dt.Rows.RemoveAt(i) ''Pasamos a eliminarlo del datatable
                    Exit For
                End If
            Next

        Next
        'Cargamos nuevamente los datos al datagridview mostrando los cambios
        dgvLista.DataSource = dt

    End Sub
End Class