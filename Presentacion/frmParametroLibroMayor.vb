Imports Negocio
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmParametroLibroMayor
    Dim obj As New nCrud
    Dim numDig As Integer

    Private Sub cargarDatos()
        Dim data As New DataTable
        data = obj.nCrudListarBD("usp_registrosLibroMayor '" & numDig & "'", CadenaConexion)
        dgvLista.DataSource = data

        Dim sd, sh As Decimal

        For Each row As DataGridViewRow In dgvLista.Rows
            sd += row.Cells("suma_debe").Value
            sh += row.Cells("suma_haber").Value
        Next
        lblSD.Text = sd
        lblSH.Text = sh
    End Sub

    Private Function codigoCeldaGrid() As Integer
        Dim c As String
        Try
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            c = dgvLista.Rows(f).Cells("cuenta_padre").Value.ToString
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function

    Private Sub frmParametroLibroMayor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLista.RowTemplate.Height = 30
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        numDig = txtDigitos.Text.Trim
        cargarDatos()
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Me.Enabled = False
        numDig = txtDigitos.Text.Trim
        cargarDatos()
        Me.Enabled = True
    End Sub

    Private Sub btnHojaTrabajo_Click(sender As Object, e As EventArgs) Handles btnHojaTrabajo.Click
        generarExcel()
    End Sub

    Private Sub generarExcel()
        Me.Enabled = False
        obj.nEjecutarQueryBD("truncate table temp_asientos_saldo", CadenaConexion)
        obj.nEjecutarQueryBD("delete from asientos_libro_diario where id_comprobante like 'CIERRE%'", CadenaConexion)
        Try
            Dim tbDatos As New DataTable
            tbDatos = obj.nCrudListarBD("usp_registrosLibroMayor '" & txtDigitos.Text.Trim & "'", CadenaConexion)
            Dim indicador As Integer = 3

            Dim Archivo As String
            Dim a As Object
            Dim APrueba As Object
            a = CreateObject("Excel.Application")
            a.Visible = True
            Archivo = CARPETA_EXCELS & "formato.hoja.trabajo.xlsx" 'Pon aqui el nombre de archivo que quieras
            APrueba = a.Workbooks.Open(Archivo)
            Dim totalVentas, costosOperacionales, costoVenta, total94, total95 As Decimal

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
                        .Cells((indicador + i), "H") = monto691
                        .Cells(indicador611, "G") = monto691
                        .Cells(indicador611, "K") = ""
                        .Cells(indicador611, "L") = ""
                        Dim valor1, valor2 As Decimal
                        If .Cells(indicador611, "F").Value = Nothing Then
                            valor1 = 0
                        Else
                            valor1 = Decimal.Parse(.Cells(indicador611, "F").Value)
                        End If
                        If .Cells(indicador611, "G").Value = Nothing Then
                            valor2 = 0
                        Else
                            valor2 = Decimal.Parse(.Cells(indicador611, "G").Value)
                        End If


                        If (valor1 - valor2) < 0 Then
                            .Cells(indicador611, "K") = Math.Abs(valor1 - valor2).ToString
                        Else
                            .Cells(indicador611, "L") = (valor1 - valor2).ToString
                        End If

                    End If


                    'Para la cuenta: Ventas
                    If ctaPadre = "70" Then
                        .Cells((indicador + i), "M") = .Cells((indicador + i), "E").Value
                        .Cells((indicador + i), "N") = .Cells((indicador + i), "F").Value

                    End If

                    If ctaHijo = "701" Then
                        If .Cells((indicador + i), "M").Value = Nothing Then
                            totalVentas = .Cells((indicador + i), "N").Value
                        ElseIf .Cells((indicador + i), "N").Value = Nothing Then
                            totalVentas = .Cells((indicador + i), "M").Value
                        End If
                    End If
                    If ctaHijo.ToString.StartsWith("709") Then
                        If .Cells((indicador + i), "M").Value = Nothing Then
                            costosOperacionales = .Cells((indicador + i), "N").Value
                        ElseIf .Cells((indicador + i), "N").Value = Nothing Then
                            costosOperacionales = .Cells((indicador + i), "M").Value
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
                        If .Cells((indicador + i), "C").Value = Nothing Then
                            total94 += Decimal.Parse(.Cells((indicador + i), "D").Value)
                        ElseIf .Cells((indicador + i), "D").Value = Nothing Then
                            total94 += Decimal.Parse(.Cells((indicador + i), "C").Value)
                        End If
                    End If

                    If ctaPadre = "95" Then
                        If .Cells((indicador + i), "C").Value = Nothing Then
                            total95 += Decimal.Parse(.Cells((indicador + i), "D").Value)
                        ElseIf .Cells((indicador + i), "D").Value = Nothing Then
                            total95 += Decimal.Parse(.Cells((indicador + i), "C").Value)
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
                    obj.nCrudInsertarBD("@", "valor_ganancia_perdida", "valor@fec_reg", (.Cells(filaRest, "I").Value - .Cells(filaRest, "J").Value) & "@" & DateTime.Now.ToString("dd/MM/yyyy"), CadenaConexion)
                Else
                    .Cells(filaRest + 1, "I").Formula = .Cells(filaRest, "J").Value - .Cells(filaRest, "I").Value
                    obj.nCrudInsertarBD("@", "valor_ganancia_perdida", "valor@fec_reg", "-" & (.Cells(filaRest, "J").Value - .Cells(filaRest, "I").Value) & "@" & DateTime.Now.ToString("dd/MM/yyyy"), CadenaConexion)
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
            Dim dt As New DataTable
            dt = obj.nCrudListarBD("select * from renta where estado='1'", CadenaConexion)
            With APrueba.WorkSheets("estado_de_resultados")
                .Cells(11, "B") = totalVentas
                .Cells(12, "B") = "-" & costosOperacionales
                .Cells(15, "B") = "-" & costoVenta
                .Cells(19, "B") = "-" & total94
                .Cells(20, "B") = "-" & total95
                .Cells(33, "B") = "-" & Decimal.Parse(.Cells(30, "B").Value) * Decimal.Parse(dt.Rows(0)("valor").ToString) / 100
                .Cells(42, "B") = Decimal.Parse(.Cells(30, "B").Value) + Decimal.Parse(.Cells(33, "B").Value)
            End With

            'objE.Quit()
            a.Quit()

            Me.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Me.Enabled = True
    End Sub

    Private Sub btnVerLibroMayor_Click(sender As Object, e As EventArgs) Handles btnVerLibroMayor.Click
        Me.Enabled = False
        Dim Archivo As String
        Dim a As Object
        Dim APrueba As Object
        a = CreateObject("Excel.Application")
        a.Visible = True
        Archivo = CARPETA_EXCELS & "formato.6.1.xlsx" 'Pon aqui el nombre de archivo que quieras
        APrueba = a.Workbooks.Open(Archivo)


        With APrueba.WorkSheets("formato")
            Dim celdas As Integer = 9
            Dim espacio As Integer = 4
            Dim masEspacios As Integer = 3

            Dim data As New DataTable
            data = obj.nCrudListarBD("usp_registrosLibroMayor '" & txtDigitos.Text.Trim & "'", CadenaConexion)
            .Cells(1, "C") = "2015"
            .Cells(2, "C") = "20447393302"
            .Cells(3, "C") = "TICOM SRL"
            .Cells(4, "C") = data.Rows(0)("cuenta_padre").ToString & " " & data.Rows(0)("nombre").ToString
            .Cells(5, "E") = "Folio: " & 1

            Dim indicador1 As Integer = 8
            Dim tbDatos1 As New DataTable
            tbDatos1 = obj.nCrudListarBD("usp_datosDetalleLibroDiario '" & txtDigitos.Text.Trim & "','" & data.Rows(0)("cuenta_padre").ToString & "'", CadenaConexion)

            For i As Integer = 0 To tbDatos1.Rows.Count - 1
                APrueba.Worksheets("formato").Rows(indicador1 + i).Insert(Shift:=(indicador1 + i))
                .Cells((indicador1 + i), "A") = Date.Parse(tbDatos1.Rows(i)("fecha")).ToString("yyyy/MM/dd")
                .Cells((indicador1 + i), "B") = tbDatos1.Rows(i)("id").ToString
                .Cells((indicador1 + i), "C") = tbDatos1.Rows(i)("cuenta").ToString & " - " & tbDatos1.Rows(i)("denominacion").ToString
                ' .Range(.Cells((indicador1 + i), "C"), .Cells((indicador1 + i), "C")).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                .Cells((indicador1 + i), "D") = tbDatos1.Rows(i)("debe").ToString
                .Cells((indicador1 + i), "E") = tbDatos1.Rows(i)("haber").ToString
                .Range(.Cells((indicador1 + i), "A"), .Cells((indicador1 + i), "E")).Font.Bold = False
                .Range(.Cells((indicador1 + i), "A"), .Cells((indicador1 + i), "E")).Font.Size = 9
                .Range(.Cells((indicador1 + i), "A"), .Cells((indicador1 + i), "E")).Interior.Color = RGB(255, 255, 255) 'Para el color de fondo de celda
            Next
            Dim filaRest1 As Integer = (indicador1 + (tbDatos1.Rows.Count - 1))
            'MsgBox(.Cells((17 + trKardex), "A").Value)
            If .Cells(filaRest1 + 1, "A").Value = "" Then
                .Rows(filaRest1 + 1).Delete()
            End If

            'SUMA DE TOTALES
            .Cells(filaRest1 + 1, "D").Formula = "=SUM(D" & indicador1 & ":D" & filaRest1 & ")"
            .Cells(filaRest1 + 1, "E").Formula = "=SUM(E" & indicador1 & ":E" & filaRest1 & ")"

            Dim numRegistros As Integer = tbDatos1.Rows.Count
            For i As Integer = 0 To data.Rows.Count - 2
                Dim numCeldas As Integer = (celdas + espacio) + (i * celdas) + (masEspacios * i)
                APrueba.Worksheets("Hoja1").Range("A1:E9").Copy()
                .Cells(numRegistros + numCeldas, "A").Select()
                .Paste()

                'Llenar los datos
                .Cells(numRegistros + numCeldas + 0, "C") = "2015"
                .Cells(numRegistros + numCeldas + 1, "C") = "20447393302"
                .Cells(numRegistros + numCeldas + 2, "C") = "TICOM SRL"
                .Cells(numRegistros + numCeldas + 3, "C") = data.Rows(i + 1)("cuenta_padre").ToString & " " & data.Rows(i + 1)("nombre").ToString
                .Cells(numRegistros + numCeldas + 4, "E") = "Folio: " & i + 2

                Dim tbDatos As New DataTable
                tbDatos = obj.nCrudListarBD("usp_datosDetalleLibroDiario '" & txtDigitos.Text.Trim & "','" & data.Rows(i + 1)("cuenta_padre").ToString & "'", CadenaConexion)

                Dim indicador As Integer = 7
                Dim filaRest = tbDatos.Rows.Count
                Dim inicioFila As Integer = 0
                For j As Integer = 0 To tbDatos.Rows.Count - 1
                    inicioFila = numRegistros + numCeldas + j + indicador
                    .Rows(inicioFila).Insert(Shift:=(inicioFila))
                    .Cells(inicioFila, "A") = Date.Parse(tbDatos.Rows(j)("fecha")).ToString("yyyy/MM/dd")
                    .Cells(inicioFila, "B") = tbDatos.Rows(j)("id").ToString
                    .Cells(inicioFila, "C") = tbDatos.Rows(j)("cuenta").ToString & " - " & tbDatos.Rows(j)("denominacion").ToString
                    '.Range(.Cells(inicioFila, "C"), .Cells(inicioFila, "C")).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    .Cells(inicioFila, "D") = tbDatos.Rows(j)("debe").ToString
                    .Cells(inicioFila, "E") = tbDatos.Rows(j)("haber").ToString
                    .Range(.Cells(inicioFila, "A"), .Cells(inicioFila, "E")).Font.Bold = False
                    .Range(.Cells(inicioFila, "A"), .Cells(inicioFila, "E")).Font.Size = 9
                    .Range(.Cells(inicioFila, "A"), .Cells(inicioFila, "E")).Interior.Color = RGB(255, 255, 255) 'Para el color de fondo de celda
                    'Range(.Cells(1, 1), .Cells(1, 2)).Font.ColorIndex = 3 Para el color de letra
                Next
                If .Cells(inicioFila + 1, "A").Value = "" Then
                    .Rows(inicioFila + 1).Delete()
                End If
                'SUMA DE TOTALES
                .Cells(inicioFila + 1, "D").Formula = "=SUM(D" & inicioFila - filaRest & ":D" & inicioFila & ")"
                .Cells(inicioFila + 1, "E").Formula = "=SUM(E" & inicioFila - filaRest & ":E" & inicioFila & ")"
                numRegistros = numRegistros + (tbDatos.Rows.Count - 1)
            Next
        End With
        'APrueba.Close(SaveChanges:=False) 'O True, como prefieras
        a.Quit()
        Me.Enabled = True
    End Sub

    Private Sub btnGenerarPLE_Click(sender As Object, e As EventArgs) Handles btnGenerarPLE.Click
        Dim dataExcel As New DataTable
        dataExcel = obj.nCrudListarBD("usp_registrosLibroMayor '" & numDig & "'", CadenaConexion)
        For i As Integer = 0 To dataExcel.Rows.Count - 1
            MsgBox("DEBE: " & dataExcel.Rows(i)("suma_debe") & " - HABER: " & dataExcel.Rows(i)("suma_haber"))
        Next
    End Sub

    Private Sub btnGeneral_Click(sender As Object, e As EventArgs) Handles btnGeneral.Click
        Me.Enabled = False
        Dim cuenta As String = ""
        Dim Archivo As String
        Dim a As Object
        Dim APrueba As Object
        a = CreateObject("Excel.Application")
        a.Visible = True
        Archivo = CARPETA_EXCELS & "balance.general.xlsx" 'Pon aqui el nombre de archivo que quieras
        APrueba = a.Workbooks.Open(Archivo)
        Dim fila As Integer = 0
        Dim dataActivo As New DataTable
        With APrueba.WorkSheets("Hoja1")
            'ACTIVO CORRIENTE
            fila = 12
            dataActivo = obj.nCrudListarBD("select * from balance_general where grupo LIKE 'ACTIVO CORRIENTE%' and estado='1'", CadenaConexion)
            For i As Integer = 0 To dataActivo.Rows.Count - 1
                'MsgBox(dataActivo.Rows(i)("id").ToString & "-" & dataActivo.Rows(i)("item").ToString)
                Dim dataDet As New DataTable
                dataDet = obj.nCrudListarBD("select * from detalle_balance_general where id_bg='" & dataActivo.Rows(i)("id").ToString & "'", CadenaConexion)
                Dim monto As Decimal = 0
                For j As Integer = 0 To dataDet.Rows.Count - 1
                    cuenta = dataDet.Rows(j)("cuenta").ToString
                    Dim data As New DataTable
                    data = obj.nCrudListarBD("select cuenta, sum(debe) as 't_debe',sum(haber) as 't_haber', (sum(debe)-sum(haber)) as 'diferencia' from asientos_libro_diario where cuenta like '" & cuenta & "%' group by cuenta", CadenaConexion)
                    If data.Rows.Count > 0 Then
                        For x As Integer = 0 To data.Rows.Count - 1
                            monto = monto + data.Rows(x)("diferencia").ToString
                        Next
                        'MsgBox(cuenta & "-" & data.Rows(0)("diferencia").ToString)
                    Else
                        monto = monto + 0
                    End If
                    'MsgBox(dataActivo.Rows(i)("id").ToString & "-" & dataActivo.Rows(i)("item").ToString & "-" & dataDet.Rows(j)("cuenta").ToString & "-" & monto2)
                Next
                'MsgBox(dataActivo.Rows(i)("id").ToString & "-" & dataActivo.Rows(i)("item").ToString & "-Suma:" & monto2)
                .Cells(fila, "C") = monto
                fila = fila + 1
            Next

            'ACTIVO NO CORRIENTE
            fila = 22
            dataActivo = obj.nCrudListarBD("select * from balance_general where grupo LIKE 'ACTIVO NO CORRIENTE%' and estado='1'", CadenaConexion)
            For i As Integer = 0 To dataActivo.Rows.Count - 1
                'MsgBox(dataActivo.Rows(i)("id").ToString & "-" & dataActivo.Rows(i)("item").ToString)
                Dim dataDet As New DataTable
                dataDet = obj.nCrudListarBD("select * from detalle_balance_general where id_bg='" & dataActivo.Rows(i)("id").ToString & "'", CadenaConexion)
                Dim monto As Decimal = 0
                For j As Integer = 0 To dataDet.Rows.Count - 1
                    cuenta = dataDet.Rows(j)("cuenta").ToString
                    Dim data As New DataTable
                    data = obj.nCrudListarBD("select cuenta, sum(debe) as 't_debe',sum(haber) as 't_haber', (sum(debe)-sum(haber)) as 'diferencia' from asientos_libro_diario where cuenta like '" & cuenta & "%' group by cuenta", CadenaConexion)
                    If data.Rows.Count > 0 Then
                        'MsgBox(cuenta & "-" & data.Rows(0)("diferencia").ToString)
                        For x As Integer = 0 To data.Rows.Count - 1
                            monto = monto + data.Rows(x)("diferencia").ToString
                        Next
                    Else
                        monto = monto + 0
                    End If
                    'MsgBox(dataActivo.Rows(i)("id").ToString & "-" & dataActivo.Rows(i)("item").ToString & "-" & dataDet.Rows(j)("cuenta").ToString & "-" & monto)
                Next
                'MsgBox(dataActivo.Rows(i)("id").ToString & "-" & dataActivo.Rows(i)("item").ToString & "-Suma:" & monto)
                .Cells(fila, "C") = monto
                fila = fila + 1
            Next

            'PASIVO CORRIENTE
            fila = 12
            dataActivo = obj.nCrudListarBD("select * from balance_general where grupo LIKE 'PASIVO CORRIENTE%' and estado='1'", CadenaConexion)
            For i As Integer = 0 To dataActivo.Rows.Count - 1
                'MsgBox(dataActivo.Rows(i)("id").ToString & "-" & dataActivo.Rows(i)("item").ToString)
                Dim dataDet As New DataTable
                dataDet = obj.nCrudListarBD("select * from detalle_balance_general where id_bg='" & dataActivo.Rows(i)("id").ToString & "' order by id asc", CadenaConexion)
                Dim monto As Decimal = 0
                For j As Integer = 0 To dataDet.Rows.Count - 1
                    cuenta = dataDet.Rows(j)("cuenta").ToString
                    Dim data As New DataTable
                    data = obj.nCrudListarBD("select cuenta, sum(debe) as 't_debe',sum(haber) as 't_haber', (sum(debe)-sum(haber)) as 'diferencia' from asientos_libro_diario where cuenta like '" & cuenta & "%' group by cuenta", CadenaConexion)
                    If cuenta.StartsWith("40") Then
                        If data.Rows.Count > 0 Then
                            'MsgBox(cuenta & "-" & data.Rows(0)("diferencia").ToString)
                            'obtener valor de ganancia_perdida
                            Dim dtGP As New DataTable
                            dtGP = obj.nCrudListarBD("select valor from valor_ganancia_perdida order by fec_reg desc", CadenaConexion)
                            Dim val As Decimal = 0
                            If dtGP.Rows.Count > 0 Then
                                val = dtGP.Rows(0)("valor").ToString
                            Else
                                val = 0
                            End If

                            For x As Integer = 0 To data.Rows.Count - 1
                                monto = monto + Math.Abs(Decimal.Parse(data.Rows(x)("diferencia").ToString))
                            Next
                            Dim dtR As New DataTable
                            dtR = obj.nCrudListarBD("select * from renta where estado='1'", CadenaConexion)
                            monto = monto + (val * Decimal.Parse(dtR.Rows(0)("valor")) / 100)
                        Else
                            monto = monto + 0
                        End If
                    Else
                        If data.Rows.Count > 0 Then
                            'MsgBox(cuenta & "-" & data.Rows(0)("diferencia").ToString)
                            For x As Integer = 0 To data.Rows.Count - 1
                                monto = monto + Math.Abs(Decimal.Parse(data.Rows(0)("diferencia").ToString))
                            Next
                        Else
                            monto = monto + 0
                        End If
                    End If
                    'MsgBox(dataActivo.Rows(i)("id").ToString & "-" & dataActivo.Rows(i)("item").ToString & "-" & dataDet.Rows(j)("cuenta").ToString & "-" & monto)
                Next
                'MsgBox(dataActivo.Rows(i)("id").ToString & "-" & dataActivo.Rows(i)("item").ToString & "-Suma:" & monto)
                .Cells(fila, "F") = monto
                fila = fila + 1
            Next

            'PASIVO NO CORRIENTE
            fila = 20
            dataActivo = obj.nCrudListarBD("select * from balance_general where grupo LIKE 'PASIVO NO CORRIENTE%' and estado='1'", CadenaConexion)
            For i As Integer = 0 To dataActivo.Rows.Count - 1
                'MsgBox(dataActivo.Rows(i)("id").ToString & "-" & dataActivo.Rows(i)("item").ToString)
                Dim dataDet As New DataTable
                dataDet = obj.nCrudListarBD("select * from detalle_balance_general where id_bg='" & dataActivo.Rows(i)("id").ToString & "' order by id asc", CadenaConexion)
                Dim monto As Decimal = 0
                For j As Integer = 0 To dataDet.Rows.Count - 1
                    cuenta = dataDet.Rows(j)("cuenta").ToString
                    Dim data As New DataTable
                    data = obj.nCrudListarBD("select cuenta, sum(debe) as 't_debe',sum(haber) as 't_haber', (sum(debe)-sum(haber)) as 'diferencia' from asientos_libro_diario where cuenta like '" & cuenta & "%' group by cuenta", CadenaConexion)
                    If data.Rows.Count > 0 Then
                        'MsgBox(cuenta & "-" & data.Rows(0)("diferencia").ToString)
                        monto = monto + Math.Abs(Decimal.Parse(data.Rows(0)("diferencia").ToString))
                    Else
                        monto = monto + 0
                    End If
                    'MsgBox(dataActivo.Rows(i)("id").ToString & "-" & dataActivo.Rows(i)("item").ToString & "-" & dataDet.Rows(j)("cuenta").ToString & "-" & monto)
                Next
                'MsgBox(dataActivo.Rows(i)("id").ToString & "-" & dataActivo.Rows(i)("item").ToString & "-Suma:" & monto)
                .Cells(fila, "F") = monto
                fila = fila + 1
            Next

            'LIBRE
            fila = 28
            dataActivo = obj.nCrudListarBD("select * from balance_general where grupo LIKE 'LIBRE%' and estado='1'", CadenaConexion)
            For i As Integer = 0 To dataActivo.Rows.Count - 1
                'MsgBox(dataActivo.Rows(i)("id").ToString & "-" & dataActivo.Rows(i)("item").ToString)
                Dim dataDet As New DataTable
                dataDet = obj.nCrudListarBD("select * from detalle_balance_general where id_bg='" & dataActivo.Rows(i)("id").ToString & "' order by id asc", CadenaConexion)
                Dim monto As Decimal = 0
                For j As Integer = 0 To dataDet.Rows.Count - 1
                    cuenta = dataDet.Rows(j)("cuenta").ToString
                    Dim data As New DataTable
                    data = obj.nCrudListarBD("select cuenta, sum(debe) as 't_debe',sum(haber) as 't_haber', (sum(debe)-sum(haber)) as 'diferencia' from asientos_libro_diario where cuenta like '" & cuenta & "%' group by cuenta", CadenaConexion)
                    If data.Rows.Count > 0 Then
                        'MsgBox(cuenta & "-" & data.Rows(0)("diferencia").ToString)
                        monto = monto + data.Rows(0)("diferencia").ToString
                    Else
                        monto = monto + 0
                    End If
                    'MsgBox(dataActivo.Rows(i)("id").ToString & "-" & dataActivo.Rows(i)("item").ToString & "-" & dataDet.Rows(j)("cuenta").ToString & "-" & monto)
                Next
                'MsgBox(dataActivo.Rows(i)("id").ToString & "-" & dataActivo.Rows(i)("item").ToString & "-Suma:" & monto)
                .Cells(fila, "F") = monto
                fila = fila + 1
            Next

            'PATRIMONIO NETO
            fila = 33
            dataActivo = obj.nCrudListarBD("select * from balance_general where grupo LIKE 'PATRIMONIO NETO%' and estado='1'", CadenaConexion)
            For i As Integer = 0 To dataActivo.Rows.Count - 1
                'MsgBox(dataActivo.Rows(i)("id").ToString & "-" & dataActivo.Rows(i)("item").ToString)
                Dim dataDet As New DataTable
                dataDet = obj.nCrudListarBD("select * from detalle_balance_general where id_bg='" & dataActivo.Rows(i)("id").ToString & "' order by id asc", CadenaConexion)
                Dim monto As Decimal = 0
                For j As Integer = 0 To dataDet.Rows.Count - 1
                    cuenta = dataDet.Rows(j)("cuenta").ToString
                    Dim data As New DataTable
                    data = obj.nCrudListarBD("select cuenta, sum(debe) as 't_debe',sum(haber) as 't_haber', (sum(debe)-sum(haber)) as 'diferencia' from asientos_libro_diario where cuenta like '" & cuenta & "%' group by cuenta", CadenaConexion)
                    If data.Rows.Count > 0 Then
                        'MsgBox(cuenta & "-" & data.Rows(0)("diferencia").ToString)
                        monto = monto + Math.Abs(Decimal.Parse(data.Rows(0)("diferencia").ToString))
                    Else
                        monto = monto + 0
                    End If
                    'MsgBox(dataActivo.Rows(i)("id").ToString & "-" & dataActivo.Rows(i)("item").ToString & "-" & dataDet.Rows(j)("cuenta").ToString & "-" & monto)
                Next
                'MsgBox(dataActivo.Rows(i)("id").ToString & "-" & dataActivo.Rows(i)("item").ToString & "-Suma:" & monto)
                .Cells(fila, "F") = monto
                fila = fila + 1
            Next
        End With
        a.Quit()
        Me.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Enabled = False
        Try
            Dim tbDatos As New DataTable
            tbDatos = obj.nCrudListarBD("select cuenta as 'cuenta_padre',desc_cuenta as 'nombre',debe as 'suma_debe',haber as 'suma_haber' from temp_asiento_cierre order by cuenta asc", CadenaConexion)
            Dim indicador As Integer = 3

            Dim Archivo As String
            Dim a As Object
            Dim APrueba As Object
            a = CreateObject("Excel.Application")
            a.Visible = True
            Archivo = CARPETA_EXCELS & "formato.hoja.trabajo.xlsx" 'Pon aqui el nombre de archivo que quieras
            APrueba = a.Workbooks.Open(Archivo)
            Dim totalVentas, costoVenta, total94, total95 As Decimal

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

            Me.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Me.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmProcesosAsientoCierre.Show()
        'On Error Resume Next
        ''vaciar temporal cuentas de cierre
        'obj.nEjecutarQueryBD("truncate table temp_asiento_cierre", CadenaConexion)

        'Dim tbDatos As New DataTable
        'tbDatos = obj.nCrudListarBD("usp_registrosLibroMayor '" & txtDigitos.Text.Trim & "'", CadenaConexion)

        'Dim debe, haber As Decimal
        'For i As Integer = 0 To tbDatos.Rows.Count - 1
        '    Dim tbLAC As New DataTable
        '    tbLAC = obj.nCrudListarBD("select * from vista_parametrosCuentasAsientoCierre where operacion like 'TRANSFERENCIA%'", CadenaConexion)
        '    For j As Integer = 0 To tbLAC.Rows.Count - 1
        '        If tbDatos.Rows(i)("cuenta_padre").ToString.StartsWith(tbLAC.Rows(j)("cuenta").ToString) Then
        '            'MsgBox(tbDatos.Rows(i)("cuenta_padre").ToString & "-" & tbDatos.Rows(i)("suma_debe").ToString & "-" & tbDatos.Rows(i)("suma_haber").ToString)
        '            debe += Decimal.Parse(tbDatos.Rows(i)("suma_haber").ToString)
        '            haber += Decimal.Parse(tbDatos.Rows(i)("suma_debe").ToString)
        '        End If
        '    Next
        'Next


        ''registrar cuentas asiento de cierre
        'Dim rptaInsert, rptaUpdate, campos, valores, ctaPadre As String
        'campos = "cuenta@desc_cuenta@debe@haber"

        'For i As Integer = 0 To tbDatos.Rows.Count - 1
        '    valores = tbDatos.Rows(i)("cuenta_padre").ToString & "@" & tbDatos.Rows(i)("nombre").ToString & "@" & tbDatos.Rows(i)("suma_debe").ToString & "@" & tbDatos.Rows(i)("suma_haber").ToString
        '    rptaInsert = obj.nCrudInsertarBD("@", "temp_asiento_cierre", campos, valores, CadenaConexion)
        'Next

        'For i As Integer = 0 To tbDatos.Rows.Count - 1
        '    ctaPadre = tbDatos.Rows(i)("cuenta_padre").ToString
        '    'igualar cuentas asiento de cierre - ACTUALIZACION
        '    Dim dt As New DataTable
        '    dt = obj.nCrudListarBD("select * from vista_parametrosCuentasAsientoCierre where cuenta like '" & ctaPadre & "%'", CadenaConexion)
        '    If dt.Rows.Count > 0 Then
        '        If Not dt.Rows(0)("operacion").ToString.StartsWith("OMI") Then
        '            Dim valor As Decimal = 0
        '            valor = Decimal.Parse(tbDatos.Rows(i)("suma_debe").ToString) - Decimal.Parse(tbDatos.Rows(i)("suma_haber").ToString)
        '            campos = "debe@haber"
        '            If valor > 0 Then
        '                valores = tbDatos.Rows(i)("suma_debe").ToString & "@" & (Decimal.Parse(tbDatos.Rows(i)("suma_haber").ToString) + Math.Abs(valor)).ToString
        '                rptaUpdate = obj.nCrudActualizarBD("@", "temp_asiento_cierre", campos, valores, "cuenta='" & tbDatos.Rows(i)("cuenta_padre").ToString & "'", CadenaConexion)
        '            Else
        '                valores = (Decimal.Parse(tbDatos.Rows(i)("suma_debe").ToString) + Math.Abs(valor)).ToString & "@" & tbDatos.Rows(i)("suma_haber").ToString
        '                rptaUpdate = obj.nCrudActualizarBD("@", "temp_asiento_cierre", campos, valores, "cuenta='" & tbDatos.Rows(i)("cuenta_padre").ToString & "'", CadenaConexion)
        '            End If
        '        End If
        '    End If
        'Next

        ''igualar cuentas asiento de cierre
        'Dim dtPac As New DataTable
        'dtPac = obj.nCrudListarBD("select * from vista_parametrosCuentasAsientoCierre where operacion like 'TRANSFERENCIA%'", CadenaConexion)
        'Dim camposT As String = "cuenta@desc_cuenta@debe@haber"
        'Dim valoresT As String = ""
        'Dim tbLista As New DataTable
        'Dim valorT As Decimal = 0
        'If dtPac.Rows.Count > 0 Then
        '    Dim okTrans As Boolean = False
        '    For i As Integer = 0 To dtPac.Rows.Count - 1
        '        tbLista = obj.nCrudListarBD("select * from temp_asiento_cierre order by cuenta asc", CadenaConexion)
        '        'Dim debe, haber As Decimal
        '        For j As Integer = 0 To tbLista.Rows.Count - 1
        '            ctaPadre = tbLista.Rows(j)("cuenta").ToString
        '            'Dim ctaExc As New DataTable
        '            'ctaExc = obj.nCrudListarBD("select * from vista_parametrosCuentasAsientoCierre where operacion like 'OMI%'", CadenaConexion)
        '            'If ctaExc.Rows.Count > 0 Then
        '            '    For k As Integer = 0 To ctaExc.Rows.Count - 1
        '            '        If ctaPadre.StartsWith(dtPac.Rows(i)("cuenta").ToString.Substring(0, 1)) And Not ctaPadre.StartsWith(ctaExc.Rows(k)("cuenta").ToString) Then
        '            '            debe += Decimal.Parse(tbLista.Rows(j)("haber").ToString)
        '            '            haber += Decimal.Parse(tbLista.Rows(j)("debe").ToString)
        '            '            okTrans = True
        '            '        End If
        '            '    Next
        '            'Else
        '            If ctaPadre.StartsWith(dtPac.Rows(i)("cuenta").ToString.Substring(0, 1)) Then
        '                'MsgBox(tbLista.Rows(j)("cuenta").ToString & "-" & tbLista.Rows(j)("debe").ToString & "-" & tbLista.Rows(j)("haber").ToString)
        '                'debe += Decimal.Parse(tbLista.Rows(j)("haber").ToString)
        '                'haber += Decimal.Parse(tbLista.Rows(j)("debe").ToString)
        '                okTrans = True
        '            End If
        '            'End If
        '        Next
        '        If okTrans = True Then
        '            Dim vDt As New DataTable
        '            vDt = obj.nCrudListarBD("select * from temp_asiento_cierre where cuenta='" & dtPac.Rows(i)("contra_cuenta").ToString & "'", CadenaConexion)
        '            Dim data89 As New DataTable
        '            data89 = obj.nCrudListarBD("select * from asientos_libro_diario where cuenta like '" & dtPac.Rows(i)("contra_cuenta").ToString & "%'", CadenaConexion)
        '            Dim vDebe As Decimal = 0
        '            Dim vHaber As Decimal = 0
        '            'MsgBox(vDt.Rows.Count & "-" & data89.Rows.Count)
        '            If vDt.Rows.Count > 0 Or data89.Rows.Count > 0 Then
        '                Dim camposUPD As String = "debe@haber"
        '                Dim valoresUPD As String = ""
        '                If data89.Rows.Count > 0 Then
        '                    vDebe = Decimal.Parse(data89.Rows(0)("debe").ToString)
        '                    vHaber = Decimal.Parse(data89.Rows(0)("haber").ToString)
        '                Else
        '                    vDebe = 0
        '                    vHaber = 0
        '                End If
        '                'vHaber = IIf(data89.Rows.Count > 0, Decimal.Parse(data89.Rows(0)("haber").ToString), 0)
        '                valoresUPD = Decimal.Parse(debe + vDebe) & "@" & Decimal.Parse(haber + vHaber)
        '                rptaUpdate = obj.nCrudActualizarBD("@", "temp_asiento_cierre", camposUPD, valoresUPD, "cuenta='" & dtPac.Rows(i)("contra_cuenta").ToString & "'", CadenaConexion)
        '            ElseIf vDt.Rows.Count = 0 And data89.Rows.Count = 0 Then
        '                valoresT = dtPac.Rows(i)("contra_cuenta").ToString & "@" & obtenerDatosCuenta(dtPac.Rows(i)("contra_cuenta").ToString) & "@" & debe & "@" & haber
        '                rptaInsert = obj.nCrudInsertarBD("@", "temp_asiento_cierre", camposT, valoresT, CadenaConexion)
        '            End If

        '        End If
        '        okTrans = False
        '        'debe = 0
        '        'haber = 0
        '    Next
        'End If

        'MsgBox("¡Asientos guardados con éxito!")
    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = obj.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function

    Private Sub lblSH_Click(sender As Object, e As EventArgs) Handles lblSH.Click
        frmParametrosAsientoCierre.Show()
    End Sub

    Private Sub btnParametrizacion_Click(sender As Object, e As EventArgs) Handles btnParametrizacion.Click
        frmParametrosAsientoCierre.Show()
    End Sub
End Class