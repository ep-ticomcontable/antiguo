Imports Entidades
Imports Negocio
Imports System.Threading
Imports System.Collections
Imports System.ComponentModel

Public Class frmProcesosAsientoCierre
    Dim obj As New nCrud
    Dim ind_carga As Integer = 0
    Dim tipo As String = ""
    Dim dataAsientos As New DataTable
    Dim mensajeProgreso As String = ""
    Dim dtPreAC As New DataTable
    Private Function codigoCeldaSeleccionada() As Integer
        Dim c As String
        Try
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            c = dgvLista.Rows(f).Cells("id").Value.ToString
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function
    Private Sub cargarDatos()
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from cabecera_asiento_cierre order by id asc", CadenaConexion)
        dgvLista.DataSource = data
        data = Nothing
        cargaInicialEstados()
    End Sub
    Private Sub frmParametrosAsientoCierre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLista.RowTemplate.Height = 29
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        cargarDatos()
        ind_carga = 1
        dtPreAC.Columns.Add("cuenta")
        dtPreAC.Columns.Add("debe")
        dtPreAC.Columns.Add("haber")
    End Sub
    Private Sub frmTsTipoPago_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            cargarDatos()
        End If
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub cargaInicialEstados()
        Try
            For Each row As DataGridViewRow In dgvLista.Rows
                If row.Cells("estado").Value.ToString = "0" Then
                    row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(255, 87, 87) '(245, 230, 108)
                ElseIf row.Cells("estado").Value.ToString = "1" Then
                    row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(255, 255, 255)
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub hiloSegundoPlano_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles hiloSegundoPlano.DoWork
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

        Dim obj As New nCrud

        Dim rptaQ As String = ""

        Dim cont, porcentajeMasAlto As Integer
        cont = 0
        porcentajeMasAlto = 0
        Dim filas As Integer = 0

        'vaciar temporal cuentas de cierre
        obj.nEjecutarQueryBD("truncate table temp_asiento_cierre", CadenaConexion)
        obj.nEjecutarQueryBD("delete from asientos_libro_diario where id_comprobante like 'CIERRE%';", CadenaConexion)

        If dgvLista.Rows.Count > 0 Then
            For Each row As DataGridViewRow In dgvLista.Rows
                If row.Cells(0).Value = True And row.Cells("operacion").Value <> "OMITIR" Then
                    'Dim tbDatos As New DataTable
                    'tbDatos = obj.nCrudListarBD("select cuenta as 'cuenta_padre',debe as 'suma_debe',haber as 'suma_haber' from temp_asientos_saldo order by substring(cuenta,1,2) asc", CadenaConexion)
                    'For i As Integer = 0 To tbDatos.Rows.Count - 1
                    '    Dim tbLAC As New DataTable
                    '    tbLAC = obj.nCrudListarBD("select * from vista_parametrosCuentasAsientoCierre where id='" & row.Cells("id").Value.ToString & "'", CadenaConexion)
                    '    For j As Integer = 0 To tbLAC.Rows.Count - 1
                    '        If tbDatos.Rows(i)("cuenta_padre").ToString.StartsWith(tbLAC.Rows(j)("cuenta").ToString) Then
                    '            filas += 1
                    '        End If
                    '    Next
                    'Next
                    filas += 1
                End If
            Next


            Dim dt As New DataTable
            For Each row As DataGridViewRow In dgvLista.Rows
                If row.Cells(0).Value = True And row.Cells("operacion").Value <> "OMITIR" Then
                    Dim tbLAC As New DataTable
                    Dim preTbDatos, tbDatos As New DataTable

                    tbLAC = obj.nCrudListarBD("select * from vista_parametrosCuentasAsientoCierre where id='" & row.Cells("id").Value.ToString & "' order by id asc", CadenaConexion)

                    Dim debe, haber As Decimal

                    For i As Integer = 0 To tbLAC.Rows.Count - 1

                        preTbDatos = obj.nCrudListarBD("select cuenta as 'cuenta_padre',debe as 'suma_debe',haber as 'suma_haber' from temp_asientos_saldo order by substring(cuenta,1,2) asc", CadenaConexion)
                        Dim rptaInsert, rptaUpdate, campos, valores As String
                        Dim vDebe As Decimal = 0
                        Dim vHaber As Decimal = 0
                        If tbLAC.Rows(i)("operacion").ToString.StartsWith("TRANS") Then
                            Dim buscarfila() As DataRow
                            buscarfila = preTbDatos.Select("cuenta_padre=" & tbLAC.Rows(i)("cuenta").ToString)
                            'tbDatos.Rows(j)("cuenta_padre").ToString.StartsWith(tbLAC.Rows(i)("cuenta").ToString)
                            'MsgBox("BUSQUEDA: " & tbLAC.Rows(i)("cuenta").ToString & "-" & tbLAC.Rows(i)("contra_cuenta").ToString)

                            Dim valoresT As String = ""
                            Dim camposT As String = "id_proceso@cuenta@desc_cuenta@debe@haber"

                            If buscarfila.Length > 0 Then
                                tbDatos = obj.nCrudListarBD("select cuenta as 'cuenta_padre',debe as 'suma_debe',haber as 'suma_haber' from temp_asientos_saldo where cuenta='" & tbLAC.Rows(i)("cuenta").ToString & "'", CadenaConexion)
                                'MsgBox("registro")
                                'MsgBox(tbDatos.Rows(i)("cuenta_padre").ToString & "-" & tbDatos.Rows(i)("suma_debe").ToString & "-" & tbDatos.Rows(i)("suma_haber").ToString)
                                debe += Decimal.Parse(tbDatos.Rows(0)("suma_haber").ToString)
                                haber += Decimal.Parse(tbDatos.Rows(0)("suma_debe").ToString)

                                'MsgBox("REGISTRANDO: " & tbLAC.Rows(i)("cuenta").ToString & "-" & tbLAC.Rows(i)("contra_cuenta").ToString & " | " & tbDatos.Rows(0)("cuenta_padre").ToString)
                                Dim vDt As New DataTable
                                vDt = obj.nCrudListarBD("select * from temp_asiento_cierre where cuenta='" & tbLAC.Rows(i)("contra_cuenta").ToString & "'", CadenaConexion)
                                Dim data89 As New DataTable
                                data89 = obj.nCrudListarBD("select cuenta as 'cuenta_padre',debe as 'suma_debe',haber as 'suma_haber' from temp_asientos_saldo where cuenta like '" & tbLAC.Rows(i)("contra_cuenta").ToString & "%'", CadenaConexion)

                                'MsgBox("DATOS CIERRE: " & vDt.Rows.Count & " - DATOS SALDO: " & data89.Rows.Count)

                                If vDt.Rows.Count > 0 Or data89.Rows.Count > 0 Then
                                    If data89.Rows.Count > 0 Then
                                        vDebe = Decimal.Parse(data89.Rows(0)("suma_debe").ToString)
                                        vHaber = Decimal.Parse(data89.Rows(0)("suma_haber").ToString)
                                    Else
                                        vDebe = Decimal.Parse(tbDatos.Rows(0)("suma_haber").ToString)
                                        vHaber = Decimal.Parse(tbDatos.Rows(0)("suma_debe").ToString)
                                    End If

                                    rptaUpdate = obj.nEjecutarQueryBD("update temp_asiento_cierre set debe=debe+'" & vDebe & "', haber=haber+'" & vHaber & "' where cuenta='" & tbLAC.Rows(i)("contra_cuenta").ToString & "'", CadenaConexion)
                                End If
                                If data89.Rows.Count = 0 Then
                                    If vDt.Rows.Count = 0 Then
                                        valoresT = row.Cells("id").Value.ToString & "@" & tbLAC.Rows(i)("contra_cuenta").ToString & "@" & obtenerDatosCuenta(tbLAC.Rows(i)("contra_cuenta").ToString) & "@" & Decimal.Parse(tbDatos.Rows(0)("suma_haber").ToString) & "@" & Decimal.Parse(tbDatos.Rows(0)("suma_debe").ToString)
                                        rptaInsert = obj.nCrudInsertarBD("@", "temp_asiento_cierre", camposT, valoresT, CadenaConexion)
                                        dtPreAC.Rows.Add(tbLAC.Rows(i)("contra_cuenta").ToString, Decimal.Parse(tbDatos.Rows(0)("suma_haber").ToString), Decimal.Parse(tbDatos.Rows(0)("suma_debe").ToString))
                                    End If
                                End If
                            Else
                                If tbLAC.Rows(i)("cuenta").ToString.StartsWith("891") Then
                                    Dim vDt As New DataTable
                                    vDt = obj.nCrudListarBD("select * from temp_asiento_cierre where cuenta='" & tbLAC.Rows(i)("cuenta").ToString & "'", CadenaConexion)
                                    Dim diferencia As Decimal = 0
                                    vDebe = Decimal.Parse(vDt.Rows(0)("debe").ToString)
                                    vHaber = Decimal.Parse(vDt.Rows(0)("haber").ToString)
                                    diferencia = vDebe - vHaber
                                    If diferencia < 0 Then
                                        rptaUpdate = obj.nEjecutarQueryBD("update temp_asiento_cierre set debe=debe+'" & Math.Abs(diferencia) & "' where cuenta='" & tbLAC.Rows(i)("contra_cuenta").ToString & "'", CadenaConexion)
                                    Else
                                        rptaUpdate = obj.nEjecutarQueryBD("update temp_asiento_cierre set haber=haber+'" & diferencia & "' where cuenta='" & tbLAC.Rows(i)("contra_cuenta").ToString & "'", CadenaConexion)
                                    End If
                                Else
                                    Dim vDt As New DataTable
                                    vDt = obj.nCrudListarBD("select * from temp_asiento_cierre where cuenta='" & tbLAC.Rows(i)("contra_cuenta").ToString & "'", CadenaConexion)
                                    If vDt.Rows.Count > 0 Then
                                        Dim diferencia As Decimal = 0
                                        vDebe = Decimal.Parse(vDt.Rows(0)("debe").ToString)
                                        vHaber = Decimal.Parse(vDt.Rows(0)("haber").ToString)
                                        diferencia = vDebe - vHaber
                                        If diferencia < 0 Then
                                            rptaUpdate = obj.nEjecutarQueryBD("update temp_asiento_cierre set haber=haber+'" & Math.Abs(diferencia) & "' where cuenta='" & tbLAC.Rows(i)("contra_cuenta").ToString & "'", CadenaConexion)
                                        Else
                                            rptaUpdate = obj.nEjecutarQueryBD("update temp_asiento_cierre set debe=debe+'" & diferencia & "' where cuenta='" & tbLAC.Rows(i)("contra_cuenta").ToString & "'", CadenaConexion)
                                        End If
                                    Else
                                        vDt = obj.nCrudListarBD("select * from temp_asiento_cierre where cuenta='" & tbLAC.Rows(i)("cuenta").ToString & "'", CadenaConexion)
                                        Dim diferencia As Decimal = 0
                                        vDebe = Decimal.Parse(vDt.Rows(0)("debe").ToString)
                                        vHaber = Decimal.Parse(vDt.Rows(0)("haber").ToString)
                                        diferencia = vDebe - vHaber
                                        If diferencia < 0 Then
                                            valoresT = row.Cells("id").Value.ToString & "@" & tbLAC.Rows(i)("contra_cuenta").ToString & "@" & obtenerDatosCuenta(tbLAC.Rows(i)("contra_cuenta").ToString) & "@0.00@" & Math.Abs(diferencia)
                                            dtPreAC.Rows.Add(tbLAC.Rows(i)("contra_cuenta").ToString, "0.00", Math.Abs(diferencia))
                                        Else
                                            valoresT = row.Cells("id").Value.ToString & "@" & tbLAC.Rows(i)("contra_cuenta").ToString & "@" & obtenerDatosCuenta(tbLAC.Rows(i)("contra_cuenta").ToString) & "@" & Math.Abs(diferencia) & "0.00"
                                            dtPreAC.Rows.Add(tbLAC.Rows(i)("contra_cuenta").ToString, Math.Abs(diferencia), "0.00")
                                        End If
                                        rptaInsert = obj.nCrudInsertarBD("@", "temp_asiento_cierre", camposT, valoresT, CadenaConexion)
                                    End If
                                End If
                            End If
                        ElseIf tbLAC.Rows(i)("operacion").ToString.StartsWith("SALD") Then
                            Dim buscarfila() As DataRow
                            buscarfila = preTbDatos.Select("cuenta_padre=" & tbLAC.Rows(i)("cuenta").ToString)
                            If buscarfila.Length > 0 Then
                                tbDatos = obj.nCrudListarBD("select cuenta as 'cuenta_padre',debe as 'suma_debe',haber as 'suma_haber' from temp_asientos_saldo where cuenta='" & tbLAC.Rows(i)("cuenta").ToString & "'", CadenaConexion)
                                debe += Decimal.Parse(tbDatos.Rows(0)("suma_haber").ToString)
                                haber += Decimal.Parse(tbDatos.Rows(0)("suma_debe").ToString)

                                'registrar cuentas asiento de cierre
                                campos = "id_proceso@cuenta@desc_cuenta@debe@haber"
                                valores = row.Cells("id").Value.ToString & "@" & tbDatos.Rows(0)("cuenta_padre").ToString & "@" & obtenerDatosCuenta(tbDatos.Rows(0)("cuenta_padre").ToString) & "@" & tbDatos.Rows(0)("suma_debe").ToString & "@" & tbDatos.Rows(0)("suma_haber").ToString
                                rptaInsert = obj.nCrudInsertarBD("@", "temp_asiento_cierre", campos, valores, CadenaConexion)
                                dtPreAC.Rows.Add(tbDatos.Rows(0)("cuenta_padre").ToString, tbDatos.Rows(0)("suma_debe").ToString, tbDatos.Rows(0)("suma_haber").ToString)
                                Dim valor As Decimal = 0
                                valor = Decimal.Parse(tbDatos.Rows(0)("suma_debe").ToString) - Decimal.Parse(tbDatos.Rows(0)("suma_haber").ToString)
                                campos = "debe@haber"
                                If valor > 0 Then
                                    valores = tbDatos.Rows(0)("suma_debe").ToString & "@" & Decimal.Parse(tbDatos.Rows(0)("suma_haber").ToString)
                                    rptaUpdate = obj.nCrudActualizarBD("@", "temp_asiento_cierre", campos, valores, "cuenta='" & tbDatos.Rows(0)("cuenta_padre").ToString & "'", CadenaConexion)
                                Else
                                    valores = Decimal.Parse(tbDatos.Rows(0)("suma_debe").ToString) & "@" & tbDatos.Rows(0)("suma_haber").ToString
                                    rptaUpdate = obj.nCrudActualizarBD("@", "temp_asiento_cierre", campos, valores, "cuenta='" & tbDatos.Rows(0)("cuenta_padre").ToString & "'", CadenaConexion)
                                End If
                            End If
                        End If

                            'If tbDatos.Rows(i)("cuenta_padre").ToString.StartsWith("69") Then
                            '    Dim data As New DataTable
                            '    data = obj.nCrudListarBD("select * from temp_asiento_cierre where cuenta like '69%'", CadenaConexion)
                            '    If data.Rows.Count = 0 Then
                            '        'registrar cuentas asiento de cierre
                            '        Dim rptaInsert2, campos2, valores2 As String
                            '        campos2 = "id_proceso@cuenta@desc_cuenta@debe@haber"
                            '        valores2 = row.Cells("id").Value.ToString & "@" & tbDatos.Rows(i)("cuenta_padre").ToString & "@" & obtenerDatosCuenta(tbDatos.Rows(i)("cuenta_padre").ToString) & "@" & tbDatos.Rows(i)("suma_debe").ToString & "@" & tbDatos.Rows(i)("suma_haber").ToString
                            '        rptaInsert2 = obj.nCrudInsertarBD("@", "temp_asiento_cierre", campos2, valores2, CadenaConexion)
                            '    End If
                            'End If

                            'Dim tbLAC2 As New DataTable
                            'tbLAC2 = obj.nCrudListarBD("select * from vista_parametrosCuentasAsientoCierre where id='" & row.Cells("id").Value.ToString & "'", CadenaConexion)
                            'If tbLAC2.Rows(0)("cuenta").ToString.StartsWith("89") And tbLAC2.Rows(0)("contra_cuenta").ToString.StartsWith("59") Then
                            '    Dim data2 As New DataTable
                            '    data2 = obj.nCrudListarBD("select * from temp_asiento_cierre where cuenta like '89%'", CadenaConexion)
                            '    If data2.Rows.Count > 0 Then
                            '        Dim camposUPD2 As String = "debe@haber"
                            '        Dim valoresUPD2 As String = ""
                            '        Dim rptaUpdate As String
                            '        'actualizar cuentas del 89 al 59
                            '        Dim valorD As Decimal = 0
                            '        Dim valorH As Decimal = 0
                            '        If data2.Rows.Count > 0 Then
                            '            valorD = Decimal.Parse(data2.Rows(0)("debe").ToString) - Decimal.Parse(data2.Rows(0)("haber").ToString)
                            '            valorH = Decimal.Parse(data2.Rows(0)("haber").ToString) - Decimal.Parse(data2.Rows(0)("debe").ToString)
                            '            If valorD > 0 Then
                            '                rptaUpdate = obj.nEjecutarQueryBD("update temp_asiento_cierre set debe=debe+'" & valorD & "' where cuenta like '59%'", CadenaConexion)
                            '                rptaUpdate = obj.nEjecutarQueryBD("update temp_asiento_cierre set haber=haber+'" & valorD & "' where cuenta like '59%'", CadenaConexion)
                            '            Else
                            '                rptaUpdate = obj.nEjecutarQueryBD("update temp_asiento_cierre set haber=haber+'" & valorH & "' where cuenta like '59%'", CadenaConexion)
                            '                rptaUpdate = obj.nEjecutarQueryBD("update temp_asiento_cierre set debe=debe+'" & valorH & "' where cuenta like '59%'", CadenaConexion)
                            '            End If
                            '        End If
                            '    End If
                            'End If


                    Next

                    'Dim tbLAC3 As New DataTable
                    'tbLAC3 = obj.nCrudListarBD("select * from vista_parametrosCuentasAsientoCierre where id='" & row.Cells("id").Value.ToString & "'", CadenaConexion)
                    'If tbLAC3.Rows(0)("cuenta").ToString.StartsWith("89") And tbLAC3.Rows(0)("contra_cuenta").ToString.StartsWith("59") Then
                    '    'regularizar asiento 89
                    '    Dim dt89 As New DataTable
                    '    dt89 = obj.nCrudListarBD("select * from temp_asiento_cierre where cuenta like '89%'", CadenaConexion)
                    '    Dim vD, vH As Decimal
                    '    Dim rptaUpdate89 As String
                    '    vD = Decimal.Parse(dt89.Rows(0)("debe").ToString) - Decimal.Parse(dt89.Rows(0)("haber").ToString)
                    '    vH = Decimal.Parse(dt89.Rows(0)("haber").ToString) - Decimal.Parse(dt89.Rows(0)("debe").ToString)
                    '    If vD > 0 Then
                    '        rptaUpdate89 = obj.nEjecutarQueryBD("update temp_asiento_cierre set haber=haber+'" & vD & "' where cuenta like '89%'", CadenaConexion)
                    '    Else
                    '        rptaUpdate89 = obj.nEjecutarQueryBD("update temp_asiento_cierre set debe=debe+'" & vH & "' where cuenta like '89%'", CadenaConexion)
                    '    End If
                    'End If
                    mensajeProgreso = "Completando " & row.Cells("descripcion").Value.ToString '& " - " & tbLAC.Rows(j)("cuenta").ToString & " (" & obtenerDatosCuenta(tbLAC.Rows(j)("cuenta").ToString) & ")..."
                    cont += 1
                    Dim porcentajeCompletado As Integer
                    porcentajeCompletado = cont / filas * 100
                    If porcentajeCompletado > porcentajeMasAlto Then
                        porcentajeMasAlto = porcentajeCompletado
                        hiloSegundoPlano.ReportProgress(porcentajeCompletado)
                        'Threading.Thread.Sleep(300)
                    End If
                End If
            Next
        End If

        mensajeProgreso = "¡No hay Procesos pendientes para ejecutar... Proceso de cierre terminado!"
        e.Result = mensajeProgreso

    End Sub

    Private Sub hiloSegundoPlano_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles hiloSegundoPlano.ProgressChanged
        barraProgreso.Value = e.ProgressPercentage
        lInfo.Text = mensajeProgreso 'mensajeProgreso
        lblPorcentaje.Text = e.ProgressPercentage & "%"
        If lInfo.Text <> "¡No hay Procesos pendientes para ejecutar... Proceso de cierre terminado!" Then
            'Timer1.Enabled = False
        Else
            btnProcesar.Enabled = True
        End If
    End Sub
    Private Sub hiloSegundoPlano_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles hiloSegundoPlano.RunWorkerCompleted
        'Manejar el caso en que se produzca un error o excepción
        If (e.Error IsNot Nothing) Then
            MsgBox(e.Error.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
        Else
            If e.Cancelled Then
                'Manejar el caso en que el usuario haya cancelado la operación. 
                lInfo.Text = "Proceso cancelado"
            Else
                'Manejar el caso en que la operación haya finalizado con éxito

                lInfo.Text = ""
                lInfo.Text = e.Result.ToString()
                If lInfo.Text = "¡No hay Procesos pendientes para ejecutar... Proceso de cierre terminado!" Then
                    btnProcesar.Enabled = True
                    barraProgreso.Value = 0

                    Try
                        Dim preTbDatos, tbDatos2, tbDatos As New DataTable
                        'tbDatos.Columns.Add("cuenta_padre")
                        'tbDatos.Columns.Add("nombre")
                        'tbDatos.Columns.Add("suma_debe")
                        'tbDatos.Columns.Add("suma_haber")
                        tbDatos2 = obj.nCrudListarBD("select cuenta as 'cuenta_padre',desc_cuenta as 'nombre',debe as 'suma_debe',haber as 'suma_haber' from temp_asiento_cierre order by cuenta asc", CadenaConexion)

                        preTbDatos = obj.nCrudListarBD("SELECT * from temp_asientos_saldo order by substring(cuenta,1,2) asc;", CadenaConexion)
                        Dim buscarfila() As DataRow
                        Dim campos, valores, rptaInsert As String
                        For Each row As DataRow In preTbDatos.Rows
                            buscarfila = tbDatos2.Select("cuenta_padre=" & row.Item("cuenta").ToString)
                            If buscarfila.Length = 0 Then
                                'registrar cuentas asiento de cierre
                                campos = "id_proceso@cuenta@desc_cuenta@debe@haber"
                                valores = "7@" & row.Item("cuenta").ToString & "@" & obtenerDatosCuenta(row.Item("cuenta").ToString) & "@" & row.Item("debe").ToString & "@" & row.Item("haber").ToString
                                rptaInsert = obj.nCrudInsertarBD("@", "temp_asiento_cierre", campos, valores, CadenaConexion)
                            End If
                        Next




                        ''registrar en Libro Diario
                        registrarEnLibroDiario()

                        'Dim diferencia As Decimal = 0
                        'Dim campos, valores As String
                        'campos = "cuenta@debe@haber"
                        'obj.nEjecutarQueryBD("truncate table temp_asientos_saldo;", CadenaConexion)
                        'For Each row As DataRow In preTbDatos.Rows
                        '    diferencia = Decimal.Parse(row.Item("debe").ToString) - Decimal.Parse(row.Item("haber").ToString)
                        '    If diferencia > 0 Then
                        '        tbDatos.Rows.Add(row.Item("cuenta").ToString, row.Item("desc_cuenta").ToString, diferencia, diferencia)
                        '        valores = row.Item("cuenta").ToString & "@0.00@" & diferencia
                        '        obj.nCrudInsertarBD("@", "temp_asientos_saldo", campos, valores, CadenaConexion)
                        '    Else
                        '        tbDatos.Rows.Add(row.Item("cuenta").ToString, row.Item("desc_cuenta").ToString, Math.Abs(diferencia), Math.Abs(diferencia))
                        '        valores = row.Item("cuenta").ToString & "@" & diferencia & "@0.00"
                        '        obj.nCrudInsertarBD("@", "temp_asientos_saldo", campos, valores, CadenaConexion)
                        '    End If
                        'Next

                        Dim indicador As Integer = 3

                        Dim Archivo As String
                        Dim a As Object
                        Dim APrueba As Object
                        a = CreateObject("Excel.Application")
                        a.Visible = True
                        Archivo = CARPETA_EXCELS & "formato.hoja.trabajo.xlsx" 'Pon aqui el nombre de archivo que quieras
                        APrueba = a.Workbooks.Open(Archivo)
                        Dim totalVentas, costoVenta, total94, total95 As Decimal
                        tbDatos = obj.nCrudListarBD("select cuenta as 'cuenta_padre',desc_cuenta as 'nombre',debe as 'suma_debe',haber as 'suma_haber' from temp_asiento_cierre order by cuenta asc", CadenaConexion)
                        With APrueba.WorkSheets("hoja_de_trabajo")
                            Dim trKardex As Integer = tbDatos.Rows.Count
                            Dim sd, sh As Decimal
                            Dim indicador611 As Integer = 0
                            For i As Integer = 0 To trKardex - 1
                                APrueba.Worksheets("hoja_de_trabajo").Rows(indicador + i).Insert(Shift:=(indicador + i))
                                .Cells((indicador + i), "A") = tbDatos.Rows(i)("cuenta_padre").ToString
                                Dim ctaPadre, ctaHijo As Integer
                                ctaPadre = tbDatos.Rows(i)("cuenta_padre").ToString.Substring(0, 2)
                                ctaHijo = tbDatos.Rows(i)("cuenta_padre").ToString
                                .Cells((indicador + i), "B") = tbDatos.Rows(i)("nombre").ToString
                                '.Range(.Cells((indicador + i), "B"), .Cells((indicador + i), "B")).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                                .Cells((indicador + i), "C") = tbDatos.Rows(i)("suma_debe").ToString
                                sd = tbDatos.Rows(i)("suma_debe").ToString
                                .Cells((indicador + i), "D") = tbDatos.Rows(i)("suma_haber").ToString
                                sh = tbDatos.Rows(i)("suma_haber").ToString()
                                '=SI(C21>D21,C21-D21,0)
                                'ActiveCell.FormulaR1C1 = "=IF(RC[-2]>RC[-1],RC[-2]-RC[-1],0)"
                                .Cells((indicador + i), "E").Formula = "=IF(C" & (indicador + i) & ">D" & (indicador + i) & ",C" & (indicador + i) & "-D" & (indicador + i) & ",0)"
                                .Cells((indicador + i), "F").Formula = "=IF(D" & (indicador + i) & ">C" & (indicador + i) & ",D" & (indicador + i) & "-C" & (indicador + i) & ",0)"



                                Dim monto691 As Decimal = 0

                                If ctaHijo = "611" Then
                                    indicador611 = indicador + i
                                End If


                                If sd > sh Then
                                    .Cells((indicador + i), "E") = sd - sh
                                    If ctaHijo = 691 Then
                                        monto691 = sd - sh
                                    End If
                                End If


                                If sd < sh Then
                                    .Cells((indicador + i), "F") = sh - sd
                                End If
                                'MsgBox(ctaPadre)
                                If ctaPadre < 60 Then
                                    .Cells((indicador + i), "I") = .Cells((indicador + i), "E").Value
                                    .Cells((indicador + i), "J") = .Cells((indicador + i), "F").Value
                                Else
                                    .Cells((indicador + i), "K") = .Cells((indicador + i), "E").Value
                                    .Cells((indicador + i), "L") = .Cells((indicador + i), "F").Value
                                End If
                                'MsgBox(monto691)
                                'CUENTA DE AJUSTE
                                If ctaHijo = "691" Then
                                    .Cells((indicador + i), "H") = monto691.ToString
                                    .Cells(indicador611, "G") = monto691.ToString
                                    .Cells(indicador611, "K") = ""
                                    .Cells(indicador611, "L") = ""
                                    'MsgBox(Decimal.Parse(.Cells(indicador611, "F").Value))
                                    .Cells(indicador611, "L") = (Decimal.Parse(.Cells(indicador611, "F").Value) - Decimal.Parse(.Cells(indicador611, "G").Value)).ToString
                                End If

                                'Para la cuenta: Ventas
                                If ctaPadre = "70" Then
                                    .Cells((indicador + i), "M") = .Cells((indicador + i), "E").Value
                                    .Cells((indicador + i), "N") = .Cells((indicador + i), "F").Value
                                    If .Cells((indicador + i), "M").Value = Nothing Then
                                        totalVentas = .Cells((indicador + i), "N").Value
                                    ElseIf .Cells((indicador + i), "N").Value = Nothing Then
                                        totalVentas = .Cells((indicador + i), "M").Value
                                    End If
                                End If

                                If ctaPadre >= 79 Then
                                    .Cells((indicador + i), "H") = .Cells((indicador + i), "E").Value
                                    .Cells((indicador + i), "G") = .Cells((indicador + i), "F").Value
                                    .Cells((indicador + i), "K") = ""
                                    .Cells((indicador + i), "L") = ""
                                    .Cells((indicador + i), "M") = .Cells((indicador + i), "H").Value
                                    .Cells((indicador + i), "N") = .Cells((indicador + i), "G").Value
                                End If

                                If ctaHijo = "691" Then
                                    .Cells((indicador + i), "K") = ""
                                    .Cells((indicador + i), "L") = ""
                                    .Cells((indicador + i), "M") = .Cells((indicador + i), "H").Value
                                    .Cells((indicador + i), "N") = .Cells((indicador + i), "G").Value
                                End If


                                'Para la cuenta: costo de ventas
                                If ctaPadre = "69" Then
                                    If .Cells((indicador + i), "M").Value = Nothing Then
                                        costoVenta = .Cells((indicador + i), "N").Value
                                    ElseIf .Cells((indicador + i), "N").Value = Nothing Then
                                        costoVenta = .Cells((indicador + i), "M").Value
                                    End If
                                End If

                                If ctaHijo = "791" Then
                                    .Cells((indicador + i), "M") = ""
                                    .Cells((indicador + i), "N") = ""
                                End If


                                If ctaPadre = "75" Then
                                    .Cells((indicador + i), "M") = .Cells((indicador + i), "K").Value
                                    .Cells((indicador + i), "N") = .Cells((indicador + i), "L").Value
                                End If

                                'Para la cuenta: Ventas
                                If ctaPadre = "94" Then
                                    If .Cells((indicador + i), "M").Value = Nothing Then
                                        total94 = .Cells((indicador + i), "N").Value
                                    ElseIf .Cells((indicador + i), "N").Value = Nothing Then
                                        total94 = .Cells((indicador + i), "M").Value
                                    End If
                                End If
                                If ctaPadre = "95" Then
                                    If .Cells((indicador + i), "M").Value = Nothing Then
                                        total95 = .Cells((indicador + i), "N").Value
                                    ElseIf .Cells((indicador + i), "N").Value = Nothing Then
                                        total95 = .Cells((indicador + i), "M").Value
                                    End If
                                End If

                                .Range(.Cells((indicador + i), "A"), .Cells((indicador + i), "J")).Font.Bold = False
                                .Range(.Cells((indicador + i), "A"), .Cells((indicador + i), "J")).Font.Size = 9
                                .Range(.Cells((indicador + i), "A"), .Cells((indicador + i), "J")).Interior.Color = RGB(255, 255, 255) 'Para el color de fondo de celda
                            Next
                            Dim filaRest As Integer = (indicador + trKardex)
                            'MsgBox(.Cells((17 + trKardex), "A").Value)
                            If .Cells(filaRest, "A").Value = "" Then
                                .Rows(filaRest).Delete()
                            End If


                            'SUMA DE TOTALES
                            .Cells(filaRest, "C").Formula = "=SUM(C" & indicador & ":C" & filaRest - 1 & ")"
                            .Cells(filaRest, "D").Formula = "=SUM(D" & indicador & ":D" & filaRest - 1 & ")"
                            .Cells(filaRest, "E").Formula = "=SUM(E" & indicador & ":E" & filaRest - 1 & ")"
                            .Cells(filaRest, "F").Formula = "=SUM(F" & indicador & ":F" & filaRest - 1 & ")"
                            .Cells(filaRest, "G").Formula = "=SUM(G" & indicador & ":G" & filaRest - 1 & ")"
                            .Cells(filaRest, "H").Formula = "=SUM(H" & indicador & ":H" & filaRest - 1 & ")"
                            .Cells(filaRest, "I").Formula = "=SUM(I" & indicador & ":I" & filaRest - 1 & ")"
                            .Cells(filaRest, "J").Formula = "=SUM(J" & indicador & ":J" & filaRest - 1 & ")"
                            .Cells(filaRest, "K").Formula = "=SUM(K" & indicador & ":K" & filaRest - 1 & ")"
                            .Cells(filaRest, "L").Formula = "=SUM(L" & indicador & ":L" & filaRest - 1 & ")"
                            .Cells(filaRest, "M").Formula = "=SUM(M" & indicador & ":M" & filaRest - 1 & ")"
                            .Cells(filaRest, "N").Formula = "=SUM(N" & indicador & ":N" & filaRest - 1 & ")"

                            If (.Cells(filaRest, "I").Value - .Cells(filaRest, "J").Value) > 0 Then
                                .Cells(filaRest + 1, "J").Formula = .Cells(filaRest, "I").Value - .Cells(filaRest, "J").Value
                            Else
                                .Cells(filaRest + 1, "I").Formula = .Cells(filaRest, "J").Value - .Cells(filaRest, "I").Value
                            End If

                            If (.Cells(filaRest, "K").Value - .Cells(filaRest, "L").Value) > 0 Then
                                .Cells(filaRest + 1, "L").Formula = .Cells(filaRest, "K").Value - .Cells(filaRest, "L").Value
                            Else
                                .Cells(filaRest + 1, "K").Formula = .Cells(filaRest, "L").Value - .Cells(filaRest, "K").Value
                            End If

                            If (.Cells(filaRest, "M").Value - .Cells(filaRest, "N").Value) > 0 Then
                                .Cells(filaRest + 1, "N").Formula = .Cells(filaRest, "M").Value - .Cells(filaRest, "N").Value
                            Else
                                .Cells(filaRest + 1, "M").Formula = .Cells(filaRest, "N").Value - .Cells(filaRest, "M").Value
                            End If


                            .Cells(filaRest + 2, "I").Formula = "=SUM(I" & filaRest & ":I" & filaRest + 1 & ")"
                            .Cells(filaRest + 2, "J").Formula = "=SUM(J" & filaRest & ":J" & filaRest + 1 & ")"
                            .Cells(filaRest + 2, "K").Formula = "=SUM(K" & filaRest & ":K" & filaRest + 1 & ")"
                            .Cells(filaRest + 2, "L").Formula = "=SUM(L" & filaRest & ":L" & filaRest + 1 & ")"
                            .Cells(filaRest + 2, "M").Formula = "=SUM(M" & filaRest & ":M" & filaRest + 1 & ")"
                            .Cells(filaRest + 2, "N").Formula = "=SUM(N" & filaRest & ":N" & filaRest + 1 & ")"

                            '.Cells(filaRest + 1, "M").Value = .Cells(filaRest + 2, "M").Value - .Cells(filaRest, "M").Value
                        End With
                        'MsgBox("No cierres esto hasta ver el resultado")
                        'APrueba.Close(SaveChanges:=False) 'O True, como prefieras
                        'a.Quit()



                        'Dim ArchivoEstado As String
                        'Dim objE As Object
                        'Dim objExcel As Object
                        'objE = CreateObject("Excel.Application")
                        'objE.Visible = True
                        'ArchivoEstado = CARPETA_EXCELS & "formato.hoja.trabajo.xlsx" 'Pon aqui el nombre de archivo que quieras
                        'objExcel = objE.Workbooks.Open(ArchivoEstado)
                        With APrueba.WorkSheets("estado_de_resultados")
                            .Cells(11, "B") = totalVentas
                            .Cells(15, "B") = "-" & costoVenta
                            .Cells(19, "B") = "-" & total94
                            .Cells(20, "B") = "-" & total95
                        End With

                        'objE.Quit()
                        a.Quit()

                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try

                End If
            End If
        End If
    End Sub
    'Private Sub registrarEnLibroDiario()
    '    Dim tbDatos As New DataTable
    '    Dim sd, sh As Decimal
    '    tbDatos = obj.nCrudListarBD("usp_registrosLibroMayor '3'", CadenaConexion)

    '    Dim objLD As New nAsientoLibroDiario
    '    Dim entidadLD As New ALDiarioEntity
    '    Dim i As Integer = 1
    '    Dim rest As Decimal = 0
    '    For Each row As DataRow In tbDatos.Rows
    '        sd = row.Item("suma_debe").ToString
    '        sh = row.Item("suma_haber").ToString()
    '        rest = sh - sd
    '        Dim tabla As New DataTable
    '        tabla = obj.nCrudListarBD("select c.descripcion from cabecera_asiento_cierre c inner join parametros_asiento_cierre p on c.id=p.id_cac where p.cuenta like '" & row.Item("cuenta_padre").ToString & "%'", CadenaConexion)
    '        If tabla.Rows.Count > 0 Then
    '            With entidadLD
    '                .id_comprobante = "CIERRE" & i
    '                .cuo = "0"
    '                .fecha_operacion = DateTime.Now.ToString("dd/MM/yyyy")
    '                .glosa = tabla.Rows(0)("descripcion").ToString
    '                .cod_libro = row.Item("cuenta_padre").ToString
    '                .numero_correlativo = "-"
    '                .numero_documento = "-"
    '                .cuenta = row.Item("cuenta_padre").ToString
    '                .denominacion = obtenerDatosCuenta(row.Item("cuenta_padre").ToString)
    '                If rest < 0 Then
    '                    .debe = "0.00"
    '                    .haber = Math.Abs(rest)
    '                ElseIf rest > 0 Then
    '                    .debe = Math.Abs(rest)
    '                    .haber = "0.00"
    '                Else
    '                    .debe = "0.00"
    '                    .haber = "0.00"
    '                End If
    '            End With
    '            objLD.registrarAsientoLibroDiarioBD(entidadLD, CadenaConexion)
    '            i = i + 1
    '        End If
    '    Next
    'End Sub
    Private Sub registrarEnLibroDiario()
        Dim tbDatos, tbPlantilla As New DataTable
        Dim sd, sh As Decimal
        'SELECT * FROM temp_asiento_cierre order by substring(cuenta,1,2) asc
        tbPlantilla = obj.nCrudListarBD("select c.id,c.descripcion,p.cuenta,p.contra_cuenta from parametros_asiento_cierre p inner join cabecera_asiento_cierre c on p.id_cac=c.id where p.exclusion=0 order by p.id_cac asc", CadenaConexion)
        tbDatos = obj.nCrudListarBD("SELECT * FROM temp_asiento_cierre order by substring(cuenta,1,2) asc;", CadenaConexion)

        Dim objLD As New nAsientoLibroDiario
        Dim entidadLD As New ALDiarioEntity
        Dim i As Integer = 1
        Dim rest As Decimal = 0
        Dim tabla As New DataTable
        For Each row As DataRow In tbPlantilla.Rows
            Dim buscarfila() As DataRow
            'MsgBox(row.Item("cuenta").ToString)
            buscarfila = tbDatos.Select("cuenta=" & row.Item("cuenta").ToString)
            If buscarfila.Length > 0 Then
                tabla = obj.nCrudListarBD("select * from temp_asiento_cierre where cuenta like '" & row.Item("cuenta").ToString & "%'", CadenaConexion)
                sd = tabla.Rows(0)("debe").ToString
                sh = tabla.Rows(0)("haber").ToString()
                rest = sh - sd

                With entidadLD
                    .id_comprobante = "CIERRE" & i
                    .cuo = "0"
                    .fecha_operacion = DateTime.Now.ToString("dd/MM/yyyy")
                    .glosa = row.Item("descripcion").ToString
                    .cod_libro = row.Item("cuenta").ToString
                    .numero_correlativo = "-"
                    .numero_documento = "-"
                    .cuenta = row.Item("cuenta").ToString
                    .denominacion = obtenerDatosCuenta(row.Item("cuenta").ToString)
                    If rest < 0 Then
                        .debe = "0.00"
                        .haber = Math.Abs(rest)
                    ElseIf rest > 0 Then
                        .debe = Math.Abs(rest)
                        .haber = "0.00"
                    Else
                        .debe = "0.00"
                        .haber = "0.00"
                    End If
                End With
                objLD.registrarAsientoLibroDiarioBD(entidadLD, CadenaConexion)
                i = i + 1
            End If
        Next
    End Sub
    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        'borrar datos de tabla temporal de asiento de cierre
        'obj.nEjecutarConsultaEnBD("truncate table temp_asiento_cierre", CadenaConexion)
        generarSaldosParaCierre()

        lInfo.Text = "En proceso..."
        tipo = 0
        btnProcesar.Enabled = False
        hiloSegundoPlano.RunWorkerAsync()
    End Sub
    Private Sub generarSaldosParaCierre()
        obj.nEjecutarQueryBD("truncate table temp_asientos_saldo", CadenaConexion)
        obj.nEjecutarQueryBD("delete from asientos_libro_diario where id_comprobante like 'CIERRE%'", CadenaConexion)
        Dim tbDatos As New DataTable
        tbDatos = obj.nCrudListarBD("usp_registrosLibroMayor '" & frmParametroLibroMayor.txtDigitos.Text.Trim & "'", CadenaConexion)

        'obtener cuenta de margen de ganancia
        Dim dtGa As New DataTable
        dtGa = obj.nCrudListarBD("select * from parametros_asiento_cierre where substring(cuenta,1,2)='84' and substring(contra_cuenta,1,2)='85'", CadenaConexion)
        Dim trKardex As Integer = tbDatos.Rows.Count
        Dim debe, haber, sd, sh, diferencia As Decimal
        Dim indicador611 As Integer = 0
        Dim campos, valores As String
        campos = "cuenta@debe@haber"
        Dim debe8489, haber8489 As Decimal
        For i As Integer = 0 To trKardex - 1
            diferencia = 0
            Dim ctaPadre, ctaHijo As Integer
            ctaPadre = tbDatos.Rows(i)("cuenta_padre").ToString.Substring(0, 2)
            ctaHijo = tbDatos.Rows(i)("cuenta_padre").ToString
            sd = tbDatos.Rows(i)("suma_debe").ToString
            sh = tbDatos.Rows(i)("suma_haber").ToString()

            If sd > sh Then
                diferencia = sd - sh
            End If
            If sd < sh Then
                diferencia = sd - sh
            End If

            If diferencia < 0 Then
                debe = "0.00"
                haber = Math.Abs(diferencia)
            ElseIf diferencia > 0 Then
                debe = Math.Abs(diferencia)
                haber = "0.00"
            Else
                debe = Math.Abs(diferencia)
                haber = Math.Abs(diferencia)
            End If

            If ctaPadre < 60 Then
                debe8489 = debe8489 + debe
                haber8489 = haber8489 + haber
            End If

            valores = ctaHijo & "@" & haber & "@" & debe
            obj.nCrudInsertarBD("@", "temp_asientos_saldo", campos, valores, CadenaConexion)
        Next
        ''registrar cuenta del margen de ganancias
        'If (debe8489 - haber8489) < 0 Then
        '    valores = dtGa.Rows(0)("cuenta") & "@0.00@" & Math.Abs(debe8489 - haber8489)
        '    obj.nCrudInsertarBD("@", "temp_asientos_saldo", campos, valores, CadenaConexion)
        'ElseIf (debe8489 - haber8489) > 0 Then
        '    valores = dtGa.Rows(0)("cuenta") & "@" & Math.Abs(debe8489 - haber8489) & "@0.00"
        '    obj.nCrudInsertarBD("@", "temp_asientos_saldo", campos, valores, CadenaConexion)
        'Else
        '    valores = dtGa.Rows(0)("cuenta") & "@0.00@0.00"
        '    obj.nCrudInsertarBD("@", "temp_asientos_saldo", campos, valores, CadenaConexion)
        'End If

    End Sub
    Private Sub chkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodos.CheckedChanged
        If chkTodos.Checked = True Then
            For Each row As DataGridViewRow In dgvLista.Rows
                row.Cells(0).Value = True
            Next
        End If
    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = obj.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function
End Class
