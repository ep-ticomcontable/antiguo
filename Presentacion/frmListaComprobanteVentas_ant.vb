Imports Negocio
Imports System.IO

Public Class frmListaComprobanteVentas_ant
    Dim obj As New nCrud
    Dim iCarga As Integer = 0
    Dim filaTable As New DataTable
    Dim codPLEVenta As String = "140100"
    Dim anioPeriodo As String = ""
    Dim mesPeriodo As String = ""
    Dim lista As New DataTable
    Public anexo As Boolean = False

    Private Function codigoComprobante() As String
        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        Dim idComprobante As String = ""
        idComprobante = dgvLista.Rows(f).Cells("id").Value
        Return idComprobante
    End Function
    Private Function codigoTipoComprobante() As String
        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        Dim idComprobante As String = ""
        idComprobante = dgvLista.Rows(f).Cells("id_tipo_comprobante").Value
        Return idComprobante
    End Function
    Private Sub cargarComprobantes()
        Dim data As New DataTable
        data = obj.nCrudListarBD(querysPorCombinacion(), CadenaConexion)
        dgvLista.DataSource = data
        formatoGrillaVentas()
    End Sub
    Private Sub cargarPeriodos()
        Dim dataAnio As New DataTable
        dataAnio.Columns.Add("codigo")
        dataAnio.Columns.Add("descripcion")
        dataAnio.Rows.Add(0, "SELECCIONE")
        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select year(fec_emision) as anio from comprobante_venta group by year(fec_emision)", CadenaConexion)
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
            data3 = obj.nCrudListarBD("select month(fec_emision) as mes from comprobante_venta group by month(fec_emision) order by month(fec_emision)", CadenaConexion)
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
        query = "select * from vista_ventas_con_abonos where tipo_venta not like 'NOTA%' and 1=1 "
        'COMBINACION DE "BUSCAR POR"
        'If cboTipo.SelectedValue.ToString = "1" And txtDato.Text.Trim.Length > 1 Then
        '    query += "and num_dni like '" & txtDato.Text.Trim & "%' "
        'ElseIf cboTipo.SelectedValue.ToString = "2" And txtDato.Text.Trim.Length > 1 Then
        '    query += "and razon_social like '" & txtDato.Text.Trim & "%' "
        'ElseIf cboTipo.SelectedValue.ToString = "3" And txtDato.Text.Trim.Length > 1 Then
        '    query += "and numero like '" & txtDato.Text.Trim & "%' "
        'ElseIf cboTipo.SelectedValue.ToString = "4" Then
        '    query += "and tipo_venta='CREDITO' "
        'ElseIf cboTipo.SelectedValue.ToString = "5" Then
        '    query += "and tipo_venta='CONTADO' "
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
        Dim data As New DataTable
        data = obj.nCrudListarBD("select year(fec_emision) as anio from comprobante_venta group by year(fec_emision)", CadenaConexion)
        If data.Rows.Count > 0 Then
            cboAnio.SelectedIndex = 1
            cboMes.SelectedIndex = 1
        End If

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
    Private Sub formatoGrillaVentas()
        For Each row As DataGridViewRow In dgvLista.Rows
            If row.Cells("estado_comprobante").Value.ToString = "P" Then
                row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(184, 184, 184)
            ElseIf row.Cells("estado_comprobante").Value.ToString = "E" Then
                row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(245, 142, 149)
                'row.DefaultCellStyle.ForeColor = Drawing.Color.FromArgb(255, 255, 255)
            ElseIf row.Cells("estadoVenta").Value.ToString = "POR COBRAR" Then
                'row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(254, 198, 119)
                row.DefaultCellStyle.ForeColor = Drawing.Color.FromArgb(252, 0, 0)
            Else
                Dim dt As New DataTable
                dt = obj.nCrudListarBD("select * from comprobante_nota_credito  where id_comprobante='" & row.Cells("id").Value.ToString & "' and tipo='VENTA' ", CadenaConexion)
                If dt.Rows.Count > 0 Then
                    row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(231, 217, 140)
                End If
                dt = Nothing
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
    Public Sub realizarConsulta()
        If txtDato.Text.Trim.Length > 0 Then
            Dim data As New DataTable
            Dim query As String
            If cboTipo.SelectedValue = 1 Then
                query = "select * from vista_ventas_con_abonos where num_dni like '" & txtDato.Text.Trim & "%' and DATEADD(dd, 0, DATEDIFF(dd, 0, fec_emision))>='" & dtDesde.Value().ToString("yyyy-MM-dd") & "' and DATEADD(dd, 0, DATEDIFF(dd, 0, fec_emision))<='" & dtHasta.Value().ToString("yyyy-MM-dd") & "' order by fec_emision asc"
            Else
                query = "select * from vista_ventas_con_abonos where razon_social like '" & txtDato.Text.Trim & "%' AND DATEADD(dd, 0, DATEDIFF(dd, 0, fec_emision))>='" & dtDesde.Value().ToString("yyyy-MM-dd") & "' and DATEADD(dd, 0, DATEDIFF(dd, 0, fec_emision))<='" & dtHasta.Value().ToString("yyyy-MM-dd") & "' order by fec_emision asc"
            End If
            'MsgBox(query)
            data = obj.nCrudListarBD(query, CadenaConexion)
            dgvLista.DataSource = data
            formatoGrillaVentas()
        Else
            cargarComprobantes()
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        'generarExcelCompras()
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
                .Cells(3, "F") = "JULIO"
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
                    .Cells((fila + i), "N") = tbDatos.Rows(i)("valor_facturado").ToString * tbDatos.Rows(i)("tipo_cambio").ToString
                    .Cells((fila + i), "O") = tbDatos.Rows(i)("valor_igv").ToString * tbDatos.Rows(i)("tipo_cambio").ToString
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
        'generarExcelComprasPle()
        'generarTxt()
    End Sub
    Private Sub generarExcelVentasPle()
        Me.Enabled = False
        Try
            anioPeriodo = cboAnio.SelectedValue.ToString
            mesPeriodo = cboMes.SelectedValue.ToString.PadLeft(2, "0"c)

            Dim data As New DataTable
            data = obj.nCrudListarBD("select * from empresas where id='" & CodigoEmpresaSession & "'", CadenaConexion)

            Dim tbDatos As New DataTable
            tbDatos = obj.nCrudListarBD("select * from comprobante_venta", CadenaConexion)

            filaTable = New DataTable
            filaTable.Columns.Add("fila")

            'MsgBox("TOTAL REGISTROS: " & tbDatos.Rows.Count)
            Dim fila As Integer = 3

            Dim Archivo As String
            Dim a As Object
            Dim APrueba As Object
            a = CreateObject("Excel.Application")
            a.Visible = True
            Archivo = CARPETA_EXCELS & "registro.ventas.xlsx" 'Pon aqui el nombre de archivo que quieras
            APrueba = a.Workbooks.Open(Archivo)
            With APrueba.WorkSheets("Hoja1")
                '.Cells(3, "F") = cboMes.Text
                '.Cells(4, "F") = data.Rows(0)("ruc").ToString
                '.Cells(5, "F") = data.Rows(0)("nombre").ToString
                Dim trKardex As Integer = tbDatos.Rows.Count
                Dim e_pu As Decimal = 0
                Dim s_pu As Decimal = 0
                Dim sf_can As Decimal = 0
                Dim sf_pu As Decimal = 0
                Dim sf_pt As Decimal = 0
                Dim acumulador As String
                For i As Integer = 0 To trKardex - 1
                    'APrueba.Worksheets("Hoja1").Rows(fila + i).Insert(Shift:=(fila + i))
                    acumulador = i + 1
                    .Cells((fila + i), "A") = acumulador
                    .Cells((fila + i), "B") = anioPeriodo & mesPeriodo & "00"
                    .Cells((fila + i), "C").Value = "C" & tbDatos.Rows(i)("numero_cuo").ToString
                    .Cells((fila + i), "D").Value = "M00" & tbDatos.Rows(i)("numero_cuo").ToString
                    .Cells((fila + i), "E") = Date.Parse(tbDatos.Rows(i)("fec_emision")).ToString("dd/MM/yyyy")
                    .Cells((fila + i), "F") = Date.Parse(tbDatos.Rows(i)("fec_pago")).ToString("dd/MM/yyyy")
                    Dim tc As DataTable = obj.nCrudListarBD("select * from tipo_documento where id='" & tbDatos.Rows(i)("id_tipo_comprobante").ToString & "'", CadenaConexion)

                    .Cells((fila + i), "G") = tc.Rows(0)("codigo").ToString
                    .Cells((fila + i), "H") = tbDatos.Rows(i)("serie_comprobante").ToString
                    .Cells((fila + i), "I") = tbDatos.Rows(i)("numero_comprobante").ToString
                    .Cells((fila + i), "K") = tbDatos.Rows(i)("cod_dni").ToString
                    .Cells((fila + i), "L") = tbDatos.Rows(i)("num_dni").ToString
                    .Cells((fila + i), "M") = tbDatos.Rows(i)("razon_social").ToString

                    Dim valFac, base, valIgv, valTot As String
                    valFac = Format(Decimal.Round(Decimal.Parse(tbDatos.Rows(i)("valor_facturado").ToString * tbDatos.Rows(i)("tipo_cambio").ToString), 2), "###0.00")
                    base = Format(Decimal.Round(Decimal.Parse(tbDatos.Rows(i)("base_imponible").ToString * tbDatos.Rows(i)("tipo_cambio").ToString), 2), "###0.00")
                    valIgv = Format(Decimal.Round(Decimal.Parse(tbDatos.Rows(i)("valor_igv").ToString * tbDatos.Rows(i)("tipo_cambio").ToString), 2), "###0.00")
                    valTot = Format(Decimal.Round(Decimal.Parse(tbDatos.Rows(i)("total").ToString * tbDatos.Rows(i)("tipo_cambio").ToString), 2), "###0.00")
                    .Cells((fila + i), "N") = valFac
                    .Cells((fila + i), "O") = base
                    .Cells((fila + i), "Q") = valIgv
                    .Cells((fila + i), "Y") = valTot
                    Dim lista As New DataTable
                    lista = obj.nCrudListarBD("select * from tipo_moneda where id='" & tbDatos.Rows(i)("id_moneda").ToString & "'", CadenaConexion)
                    .Cells((fila + i), "Z") = lista.Rows(0)("codigo").ToString
                    .Cells((fila + i), "AA") = tbDatos.Rows(i)("tipo_cambio").ToString
                    If tbDatos.Rows(i)("tip_comp_origen").ToString <> "-" And tbDatos.Rows(i)("serie_comp_origen").ToString <> "-" And tbDatos.Rows(i)("numero_comp_origen").ToString <> "-" Then
                        .Cells((fila + i), "AB") = Date.Parse(tbDatos.Rows(i)("fec_comp_origen")).ToString("dd/MM/yyyy")
                        Dim tc2 As DataTable = obj.nCrudListarBD("select * from tipo_documento where id='" & tbDatos.Rows(i)("tip_comp_origen").ToString & "'", CadenaConexion)
                        .Cells((fila + i), "AC") = tc2.Rows(0)("codigo").ToString
                        .Cells((fila + i), "AD") = tbDatos.Rows(i)("serie_comp_origen").ToString
                        .Cells((fila + i), "AE") = tbDatos.Rows(i)("numero_comp_origen").ToString
                    End If
                    .Cells((fila + i), "AH") = "1"
                    .Cells((fila + i), "AI") = "1"
                    filaTable.Rows.Add(.Cells((fila + i), "AJ").Value)
                Next
                Dim filaRest As Integer = (fila + trKardex)
                'MsgBox(.Cells((17 + trKardex), "A").Value)
                If .Cells(filaRest, "A").Value = "" Then
                    .Rows(filaRest).Delete()
                End If
                '.Rows(8).Delete()
            End With

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
        nomArchivo = "LE" & data.Rows(0)("ruc").ToString & data.Rows(0)("periodo").ToString & mesPeriodo & "00" & codPLEVenta & "001111"

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
            MsgBox("¡Archivo creado con éxito en la ruta D:/excel/PLE/!")
        Catch ex As Exception
            MsgBox("Error al Guardar la ingormacion en el archivo. " & ex.ToString, MsgBoxStyle.Critical, Application.ProductName)
            strStreamWriter.Close() ' cerramos
        End Try
    End Sub
    Private Sub btnAcciones_Click(sender As Object, e As EventArgs)
        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        frmAccionesVentas.idComprobante = dgvLista.Rows(f).Cells("id").Value
        frmAccionesVentas.idTipoComprobante = dgvLista.Rows(f).Cells("id_tipo_comprobante").Value
        frmAccionesVentas.montoAbono = dgvLista.Rows(f).Cells("abono").Value
        frmAccionesVentas.ShowDialog()
    End Sub
    Private Sub dgvLista_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        frmAccionesVentas.idComprobante = codigoComprobante()
        frmAccionesVentas.idTipoComprobante = dgvLista.Rows(f).Cells("id_tipo_comprobante").Value
        frmAccionesVentas.ShowDialog()
        formatoGrillaVentas()
    End Sub
    Private Sub dgvLista_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLista.SelectionChanged
        'MsgBox(codigoCeldaGrid)
        On Error Resume Next
        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        If dgvLista.Rows(f).Cells("tipo_venta").Value.ToString.StartsWith("LETRA") And Decimal.Parse(dgvLista.Rows(f).Cells("abono").Value.ToString) <= Decimal.Parse(dgvLista.Rows(f).Cells("total").Value.ToString) Then
            btnCanje.Text = "ESTADO LETRA"
        ElseIf Not dgvLista.Rows(f).Cells("tipo_venta").Value.ToString.StartsWith("LETRA") And Decimal.Parse(dgvLista.Rows(f).Cells("abono").Value.ToString) <= Decimal.Parse(dgvLista.Rows(f).Cells("total").Value.ToString) Then
            btnCanje.Text = "CANJE A LETRA"
        End If
        If dgvLista.Rows(f).Cells("tipo_venta").Value.ToString.StartsWith("CONTADO") Then
            btnCanje.Enabled = False
        Else
            btnCanje.Enabled = True
        End If

        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from comprobante_venta where id='" & codigoComprobante() & "'", CadenaConexion)
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
                btnEliminar.Enabled = True
                btnModificar.Enabled = True
            Else
                If Decimal.Parse(dgvLista.Rows(f).Cells("abono").Value) = 0 Then
                    btnEliminar.Enabled = True
                ElseIf Decimal.Parse(dgvLista.Rows(f).Cells("abono").Value) > 0 Then
                    btnEliminar.Enabled = False
                End If
                If Decimal.Parse(dgvLista.Rows(f).Cells("abono").Value) <= Decimal.Parse(dgvLista.Rows(f).Cells("total").Value) Then
                    btnPagos.Enabled = True
                Else
                    btnPagos.Enabled = False
                End If

                btnCredito.Enabled = True
                btnDebito.Enabled = True
                btnModificar.Enabled = False
            End If
        End With
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'frmNuevaVentaP.Show()
        frmNuevaVentaMercaderias.Show()
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
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        realizarConsulta()
    End Sub
    Private Sub btnDetalle_Click(sender As Object, e As EventArgs) Handles btnDetalle.Click

        lblTitulo.Text = "VENTAS"
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
        data = obj.nCrudListarBD("select * from vista_ventas_con_abonos where id='" & codigoComprobante() & "'", CadenaConexion)
        With data
            txtTipoDocumento.Text = .Rows(0)("comprobante").ToString
            txtSerie.Text = .Rows(0)("serie").ToString
            txtNumero.Text = .Rows(0)("numero").ToString
            txtRuc.Text = .Rows(0)("num_dni").ToString
            txtRazon.Text = .Rows(0)("razon_social").ToString
            txtFechaEmision.Text = Date.Parse(.Rows(0)("fec_emision").ToString)
            txtFechaPago.Text = Date.Parse(.Rows(0)("fec_pago").ToString)
            txtFormaPago.Text = .Rows(0)("tipo_venta").ToString
            txtMoneda.Text = .Rows(0)("moneda").ToString
            txtTc.Text = .Rows(0)("tc").ToString
            txtTotal.Text = .Rows(0)("total").ToString
            txtDeuda.Text = Decimal.Parse(.Rows(0)("total").ToString) - Decimal.Parse(.Rows(0)("abono").ToString)
            txtGlosa.Text = .Rows(0)("glosa").ToString
            txtTipoOperacion.Text = .Rows(0)("gravado").ToString
        End With

        'Cargar asientos contables
        Dim asientos As New DataTable
        asientos = obj.nCrudListarBD("select a.cuenta as 'num_cuenta', c.nombre as 'desc_cuenta',a.debe, a.haber from detalle_asiento_venta a inner join cuenta_contable c on a.cuenta=c.id where a.id_asiento_venta='" & codigoComprobante() & "' order by a.id asc", CadenaConexion)
        cuentas.Rows.Add("-", "ASIENTOS DE VENTA", 0, 0)
        For Each row As DataRow In asientos.Rows
            cuentas.Rows.Add(row.Item("num_cuenta").ToString, row.Item("desc_cuenta").ToString, row.Item("debe").ToString, row.Item("haber").ToString)
        Next
        'cuentas = (asientos)

        'Cargar los abonos
        Dim abonos As New DataTable
        abonos = obj.nCrudListarBD("select fecha as 'fecha_abono',descripcion as 'glosa_abono', '" & txtMoneda.Text & "' as 'moneda_abono', monto as 'monto_abono' from abono_pagos_ventas where id_venta='" & codigoComprobante() & "'", CadenaConexion)
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
            dataAbono = obj.nCrudListarBD("select a.cuenta as 'num_cuenta',c.nombre as 'desc_cuenta',a.debe,a.haber from asientos_abono_ventas a inner join cuenta_contable c on a.cuenta=c.id where a.id_venta='" & codigoComprobante() & "' order by a.id asc", CadenaConexion)
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
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        habilitarBusquedas()
    End Sub
    Private Sub habilitarBusquedas()
        panelDetalle.Visible = False
        lblTitulo.Text = "LISTA DE VENTAS"
        grupoBusqueda.Enabled = True
    End Sub
    Private Sub btnPagos_Click(sender As Object, e As EventArgs) Handles btnPagos.Click
        frmAccionCobrosVentas.idComprobante = "0"
        frmAccionCobrosVentas.idComprobante = codigoComprobante()
        frmAccionCobrosVentas.Show()
    End Sub
    Private Sub btnFormatoCompra_Click(sender As Object, e As EventArgs) Handles btnFormatoCompra.Click
        generarExcelVentas()
    End Sub
    Private Sub generarExcelVentas()
        Me.Enabled = False
        Try
            Dim data As New DataTable
            data = obj.nCrudListarBD("select * from empresas where id='" & CodigoEmpresaSession & "'", CadenaConexion)

            Dim tbDatos As New DataTable
            tbDatos = obj.nCrudListarBD("select * from comprobante_venta", CadenaConexion)

            'MsgBox("TOTAL REGISTROS: " & tbDatos.Rows.Count)
            Dim fila As Integer = 9

            Dim Archivo As String
            Dim a As Object
            Dim APrueba As Object
            a = CreateObject("Excel.Application")
            a.Visible = True
            Archivo = CARPETA_EXCELS & "formato.14.1 - copia.xlsx" 'Pon aqui el nombre de archivo que quieras
            APrueba = a.Workbooks.Open(Archivo)
            With APrueba.WorkSheets("Hoja1")
                .Cells(3, "F") = cboMes.Text
                .Cells(4, "F") = data.Rows(0)("ruc").ToString
                .Cells(5, "F") = data.Rows(0)("nombre").ToString
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
                    .Cells((fila + i), "B") = "2016" & mesPeriodo & "00"
                    .Cells((fila + i), "C").Value = "00000" & tbDatos.Rows(i)("numero_cuo").ToString
                    .Cells((fila + i), "D").Value = "M00" & tbDatos.Rows(i)("numero_cuo").ToString
                    .Cells((fila + i), "E") = Date.Parse(tbDatos.Rows(i)("fec_emision")).ToString("dd/MM/yyyy")
                    .Cells((fila + i), "F") = Date.Parse(tbDatos.Rows(i)("fec_pago")).ToString("dd/MM/yyyy")
                    Dim tc As DataTable = obj.nCrudListarBD("select * from tipo_documento where id='" & tbDatos.Rows(i)("id_tipo_comprobante").ToString & "'", CadenaConexion)

                    .Cells((fila + i), "G") = tc.Rows(0)("codigo").ToString
                    .Cells((fila + i), "H") = tbDatos.Rows(i)("serie_comprobante").ToString
                    .Cells((fila + i), "I") = tbDatos.Rows(i)("numero_comprobante").ToString
                    .Cells((fila + i), "K") = tbDatos.Rows(i)("cod_dni").ToString
                    .Cells((fila + i), "L") = tbDatos.Rows(i)("num_dni").ToString
                    .Cells((fila + i), "M") = tbDatos.Rows(i)("razon_social").ToString
                    .Cells((fila + i), "N") = tbDatos.Rows(i)("valor_facturado").ToString * tbDatos.Rows(i)("tipo_cambio").ToString
                    .Cells((fila + i), "O") = tbDatos.Rows(i)("base_imponible").ToString * tbDatos.Rows(i)("tipo_cambio").ToString
                    .Cells((fila + i), "Q") = tbDatos.Rows(i)("valor_igv").ToString * tbDatos.Rows(i)("tipo_cambio").ToString
                    .Cells((fila + i), "Y") = tbDatos.Rows(i)("total").ToString * tbDatos.Rows(i)("tipo_cambio").ToString
                    Dim lista As New DataTable
                    lista = obj.nCrudListarBD("select * from tipo_moneda where id='" & tbDatos.Rows(i)("id_moneda").ToString & "'", CadenaConexion)
                    .Cells((fila + i), "Z") = lista.Rows(0)("codigo").ToString
                    .Cells((fila + i), "AA") = tbDatos.Rows(i)("tipo_cambio").ToString
                    If tbDatos.Rows(i)("tip_comp_origen").ToString <> "-" And tbDatos.Rows(i)("serie_comp_origen").ToString <> "-" And tbDatos.Rows(i)("numero_comp_origen").ToString <> "-" Then
                        .Cells((fila + i), "AB") = Date.Parse(tbDatos.Rows(i)("fec_comp_origen")).ToString("dd/MM/yyyy")
                        .Cells((fila + i), "AC") = tbDatos.Rows(i)("tip_comp_origen").ToString
                        .Cells((fila + i), "AD") = tbDatos.Rows(i)("serie_comp_origen").ToString
                        .Cells((fila + i), "AE") = tbDatos.Rows(i)("numero_comp_origen").ToString
                    End If

                    .Cells((fila + i), "AH") = "1"
                    'filaTable.Rows.Add(.Cells((fila + i), "AF").Value)
                Next
                Dim filaRest As Integer = (fila + trKardex)
                'MsgBox(.Cells((17 + trKardex), "A").Value)
                If .Cells(filaRest, "A").Value = "" Then
                    .Rows(filaRest).Delete()
                End If
                .Rows(8).Delete()
            End With

            a.Quit()
            Me.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Enabled = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmNuevaVentaMercaderias.Show()
    End Sub
    Private Sub btnGenerarPle_Click_1(sender As Object, e As EventArgs) Handles btnGenerarPle.Click
        generarExcelVentasPle()
        generarTxt()
        'frmListaLetrasPorCobrar.Show()
    End Sub
    Private Sub btnCanje_Click(sender As Object, e As EventArgs) Handles btnCanje.Click
        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        If dgvLista.Rows(f).Cells("tipo_venta").Value.ToString.StartsWith("LETRA") And Decimal.Parse(dgvLista.Rows(f).Cells("abono").Value.ToString) < Decimal.Parse(dgvLista.Rows(f).Cells("total").Value.ToString) Then
            lblTitulo.Text = "VENTAS"
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
            data = obj.nCrudListarBD("select * from vista_ventas_con_abonos where id='" & codigoComprobante() & "'", CadenaConexion)
            With data
                txtTipoDocumento2.Text = .Rows(0)("comprobante").ToString
                txtSerie2.Text = .Rows(0)("serie").ToString
                txtNumero2.Text = .Rows(0)("numero").ToString
                txtRuc2.Text = .Rows(0)("num_dni").ToString
                txtRazon2.Text = .Rows(0)("razon_social").ToString
                txtFechaEmision2.Text = Date.Parse(.Rows(0)("fec_emision").ToString)
                txtFechaPago2.Text = Date.Parse(.Rows(0)("fec_pago").ToString)
                txtFormaPago2.Text = .Rows(0)("tipo_venta").ToString
                txtMoneda2.Text = .Rows(0)("moneda").ToString
                txtTc2.Text = .Rows(0)("tc").ToString
                txtTotal2.Text = .Rows(0)("total").ToString
                txtDeuda2.Text = Decimal.Parse(.Rows(0)("total").ToString) - Decimal.Parse(.Rows(0)("abono").ToString)
                txtGlosa2.Text = .Rows(0)("glosa").ToString
                txtTipoOperacion2.Text = .Rows(0)("gravado").ToString
            End With

            'Cargar los abonos
            Dim abonos As New DataTable
            abonos = obj.nCrudListarBD("select id as 'idL', fec_emision as 'fec_emisionL',fec_vencimiento as 'fec_vencimientoL',monto as 'montoL',serie as 'serieL',numero as 'numeroL',librado,lugar_giro, aval,direccion from canje_letra where id_comprobante='" & codigoComprobante() & "'", CadenaConexion)
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

            Dim dtLetras As New DataTable
            dtLetras = obj.nCrudListarBD("SELECT cuenta as 'cuentaL',glosa as 'glosaL',debe as 'debeL',haber as 'haberL' FROM asientos_libro_diario where id_comprobante='LC" & dgvLetras.Rows(f1).Cells("idL").Value & "' order by id asc", CadenaConexion)
            dgvCuentasLetras.DataSource = dtLetras

            Dim debe, haber As Decimal
            For Each row As DataGridViewRow In dgvCuentasLetras.Rows
                debe += Decimal.Parse(row.Cells("debeL").Value)
                haber += Decimal.Parse(row.Cells("haberL").Value)
            Next
            txtTotalDebeL.Text = debe
            txtTotalHaberL.Text = haber
            txtDiferenciaL.Text = debe - haber

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
        ElseIf Not dgvLista.Rows(f).Cells("tipo_venta").Value.ToString.StartsWith("LETRA") And Decimal.Parse(dgvLista.Rows(f).Cells("abono").Value.ToString) < Decimal.Parse(dgvLista.Rows(f).Cells("total").Value.ToString) Then
            realizarCanje()
        Else
            MsgBox("No se puede realizar el canje a letra de este comprobante")
        End If

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
        dtComp = obj.nCrudListarBD("select * from comprobante_venta where id='" & codigoComprobante() & "'", CadenaConexion)

        Dim data As New DataTable
        data = obj.nCrudListarBD("select  IsNull(sum(monto), 0) as 'abono' from abono_pagos_ventas where id_venta='" & codigoComprobante() & "'", CadenaConexion)
        Dim abono As Decimal = 0
        If data.Rows.Count > 0 Then
            abono = Decimal.Parse(data.Rows(0)("abono").ToString)
        End If
        Dim diferencia As Decimal = 0
        Dim pagado As Decimal = 0
        diferencia = (Decimal.Parse(dtComp.Rows(0)("total").ToString) - abono)
        pagado = abono
        dataComp.Rows.Add(codigoComprobante, dtComp.Rows(0)("serie_comprobante").ToString, dtComp.Rows(0)("numero_comprobante").ToString, dtComp.Rows(0)("glosa").ToString, dtComp.Rows(0)("total").ToString, pagado, diferencia, diferencia, Date.Parse(dtComp.Rows(0)("fec_pago").ToString).ToString("dd/MM/yyyy"))
        Dim f1 As Integer
        f1 = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid

        With frmCanjeLetraComprobantes
            .Text = "CANJE DE " & dgvLista.Rows(f1).Cells("comprobante").Value.ToString & " DE VENTA POR LETRA"
            .lblTitulo.Text = "CANJE " & dgvLista.Rows(f1).Cells("comprobante").Value.ToString & " VENTA POR LETRA"
            .tipo = "VENTA"
            .codComprobante = codigoComprobante()
            .dataComprobante = dataComp
            .cargarDatosComprobante()
            .Show()
        End With
    End Sub
    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        'If dgvLista.RowCount > 0 Then
        '    Dim f As Integer
        '    f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        '    frmDepositoDetracciones.txtIdComprobante.Text = dgvLista.Rows(f).Cells("id").Value
        '    frmDepositoDetracciones.txtSerie.Text = dgvLista.Rows(f).Cells("serie").Value
        '    frmDepositoDetracciones.txtNumero.Text = dgvLista.Rows(f).Cells("numero").Value
        '    Me.Close()
        'End If
        frmListaLetrasPorPagar.Show()
    End Sub
    Private Sub btnCredito_Click(sender As Object, e As EventArgs) Handles btnCredito.Click
        frmNuevaNotaCreditoVenta.codComprobante = codigoComprobante()
        frmNuevaNotaCreditoVenta.Show()
        frmNuevaNotaCreditoVenta.cargarDatosComprobante()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim verif As Boolean = False
        For Each row As DataGridViewRow In dgvLista.Rows
            If row.Cells(0).Value = True Then
                verif = True
            End If
        Next
        If verif = True Then
            If MessageBox.Show("Está apunto de ELIMINAR el/los comprobante(s) seleccionado(s)." & vbCrLf & "¿Desea realizar este proceso?", "ELIMINACIÓN DE COMPROBANTE DE VENTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                For Each row As DataGridViewRow In dgvLista.Rows
                    If row.Cells(0).Value = True Then
                        'ELIMINAR EN COMPROBANTE DE COMPRA
                        obj.nEjecutarQueryBD("delete from comprobante_venta where id='" & row.Cells("id").Value.ToString & "'", CadenaConexion)
                        'ELIMINAR ASIENTOS DE COMPROBANTE DE COMPRA
                        obj.nEjecutarQueryBD("delete from detalle_asiento_venta where id_asiento_venta='" & row.Cells("id").Value.ToString & "'", CadenaConexion)
                        'ELIMINAR ASIENTOS DE COMPROBANTE DE COMPRA EN LIBRO DIARIO
                        obj.nEjecutarQueryBD("delete from asientos_libro_diario where id_comprobante='V" & row.Cells("id").Value.ToString & "'", CadenaConexion)
                    End If
                Next
                MsgBox("Comprobante(s) ELIMINADO(S) del Sistema correctamente")
                Me.realizarConsulta()
            End If
        End If
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        frmModificarVentaP.idVenta = codigoComprobante()
        frmModificarVentaP.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        habilitarBusquedas()
        PanelLetra.Visible = False
    End Sub
End Class