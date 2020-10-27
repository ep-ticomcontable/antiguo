Imports Negocio
Imports System.IO
Imports Entidades

Public Class frmListaCaja
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

    Private Sub cargarCaja()
        Dim dataAnio As New DataTable
        dataAnio.Columns.Add("codigo")
        dataAnio.Columns.Add("descripcion")
        'dataAnio.Rows.Add(0, "SELECCIONE")
        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select * from caja_configuracion where tipo='PRINCIPAL' and estado=1 order by id asc", CadenaConexion)
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
        query = "select * from vista_listaRegistrosCaja where 1=1 "
        Dim dt As New DataTable
        dt = obj.nCrudListarBD("select * from caja_configuracion where id='" & cboCaja.SelectedValue.ToString & "'", CadenaConexion)
        'COMBINACION DE "BUSCAR POR"
        If cboCaja.SelectedValue.ToString <> "0" Then
            query += "and id_caja='" & cboCaja.SelectedValue.ToString & "' and cuenta <> '" & dt.Rows(0)("cuenta").ToString & "'"
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
    Private Sub cargarComprobantes()
        Dim data As New DataTable
        Dim data2 As New DataTable
        data = obj.nCrudListarBD("select * from vista_datosApertura where id_caja='" & cboCaja.SelectedValue.ToString & "'", CadenaConexion)
        data2 = obj.nCrudListarBD(querysPorCombinacion(), CadenaConexion)
        data.Merge(data2)
        dgvLista.DataSource = data
        formatoGrillaCompras()
    End Sub
    Private Sub frmListaComprobanteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCaja()
        dgvLista.RowTemplate.Height = 35
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        cargarComprobantes()
        cargarPeriodos()
        iCarga = 1
        cboAnio.SelectedValue = DateTime.Now.ToString("yyyy")
        cboMes.SelectedValue = DateTime.Now.Month
    End Sub
    Private Sub formatoGrillaCompras()
        Dim data, nData As New DataTable
        'data = obj.nCrudListarBD(querysPorCombinacion(), CadenaConexion)
        'dgvLista.DataSource = data
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
        cargarComprobantes()
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

End Class