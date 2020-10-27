Imports Negocio

Public Class frmExcel

    Dim obj As New nCrud
    Private Sub frmExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLista.DataSource = obj.nCrudListarBD("select * from asientos_libro_diario order by id asc", CadenaConexion)
        CodigoEmpresaSession = 1
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        generarExcel()
    End Sub

    Private Sub generarExcel()
        Me.Enabled = False
        Try

            Dim tbDatos As New DataTable
            tbDatos = obj.nCrudListarBD("select * from asientos_libro_diario order by id asc", CadenaConexion)

            'MsgBox("TOTAL REGISTROS: " & tbDatos.Rows.Count)


            Dim Archivo As String
            Dim a As Object
            Dim APrueba As Object
            a = CreateObject("Excel.Application")
            a.Visible = True
            Archivo = CARPETA_EXCELS & "formato.5.1.xlsx" 'Pon aqui el nombre de archivo que quieras
            APrueba = a.Workbooks.Open(Archivo)
            With APrueba.WorkSheets("formato")
                .Cells(3, "F") = "SEPTIEMBRE"
                .Cells(4, "F") = "10447301500"
                .Cells(5, "F") = "JEAN CARLOS HEREDIA ESPINOZA"

                Dim trKardex As Integer = tbDatos.Rows.Count
                Dim e_pu As Decimal = 0
                Dim s_pu As Decimal = 0
                Dim sf_can As Decimal = 0
                Dim sf_pu As Decimal = 0
                Dim sf_pt As Decimal = 0

                For i As Integer = 0 To trKardex - 1
                    APrueba.Worksheets("formato").Rows(11 + i).Insert(Shift:=(11 + i))
                    .Cells((11 + i), "A") = tbDatos.Rows(i)("cuo").ToString
                    .Cells((11 + i), "B") = Date.Parse(tbDatos.Rows(i)("fecha_operacion")).ToString("yyyy/MM/dd")
                    .Cells((11 + i), "C") = tbDatos.Rows(i)("glosa").ToString
                    .Cells((11 + i), "D") = tbDatos.Rows(i)("cod_libro").ToString
                    .Cells((11 + i), "E") = tbDatos.Rows(i)("numero_correlativo").ToString
                    .Cells((11 + i), "F") = tbDatos.Rows(i)("numero_documento").ToString
                    .Cells((11 + i), "G") = tbDatos.Rows(i)("cuenta").ToString
                    .Cells((11 + i), "H") = tbDatos.Rows(i)("denominacion").ToString
                    .Cells((11 + i), "I") = tbDatos.Rows(i)("debe").ToString
                    .Cells((11 + i), "J") = tbDatos.Rows(i)("haber").ToString
                Next
                Dim filaRest As Integer = (11 + trKardex)
                'MsgBox(.Cells((17 + trKardex), "A").Value)
                If .Cells(filaRest, "A").Value = "" Then
                    .Rows(filaRest).Delete()
                End If

                'SUMA DE TOTALES
                .Cells(filaRest, "I").Formula = "=SUM(I11:I" & filaRest - 1 & ")"
                .Cells(filaRest, "J").Formula = "=SUM(J11:J" & filaRest - 1 & ")"
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
                .Cells(3, "F") = "SEPTIEMBRE"
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
                    .Cells((fila + i), "D") = Date.Parse(tbDatos.Rows(i)("fec_emision")).ToString("yyyy/MM/dd")
                    .Cells((fila + i), "E") = Date.Parse(tbDatos.Rows(i)("fec_pago")).ToString("yyyy/MM/dd")
                    .Cells((fila + i), "F") = tbDatos.Rows(i)("id_tipo_comprobante")
                    .Cells((fila + i), "G") = tbDatos.Rows(i)("serie_comprobante").ToString
                    .Cells((fila + i), "I") = tbDatos.Rows(i)("numero_comprobante").ToString
                    .Cells((fila + i), "K") = tbDatos.Rows(i)("cod_dni").ToString
                    .Cells((fila + i), "L") = tbDatos.Rows(i)("num_dni").ToString
                    .Cells((fila + i), "M") = tbDatos.Rows(i)("razon_social").ToString
                    .Cells((fila + i), "N") = tbDatos.Rows(i)("valor_facturado").ToString
                    .Cells((fila + i), "O") = tbDatos.Rows(i)("valor_igv").ToString
                    .Cells((fila + i), "W") = tbDatos.Rows(i)("total").ToString
                    Dim lista As New DataTable
                    lista = obj.nCrudListarBD("select * from tipo_moneda where id='" & tbDatos.Rows(i)("id_moneda").ToString & "'", CadenaConexion)
                    .Cells((fila + i), "X") = lista.Rows(0)("codigo").ToString
                    .Cells((fila + i), "Y") = tbDatos.Rows(i)("tipo_cambio").ToString
                    .Cells((fila + i), "Z") = Date.Parse(tbDatos.Rows(i)("fec_comp_origen").ToString).ToString("yyyy/MM/dd")
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

    Private Sub generarExcelVentas()
        Me.Enabled = False
        Try

            Dim tbDatos As New DataTable
            tbDatos = obj.nCrudListarBD("select * from comprobante_venta", CadenaConexion)

            'MsgBox("TOTAL REGISTROS: " & tbDatos.Rows.Count)
            Dim fila As Integer = 12

            Dim Archivo As String
            Dim a As Object
            Dim APrueba As Object
            a = CreateObject("Excel.Application")
            a.Visible = True
            Archivo = CARPETA_EXCELS & "formato.14.1.xlsx" 'Pon aqui el nombre de archivo que quieras
            APrueba = a.Workbooks.Open(Archivo)
            With APrueba.WorkSheets("formato")
                .Cells(3, "G") = "SEPTIEMBRE"
                .Cells(4, "G") = "10447301500"
                .Cells(5, "G") = "JEAN CARLOS HEREDIA ESPINOZA"

                Dim trKardex As Integer = tbDatos.Rows.Count
                Dim e_pu As Decimal = 0
                Dim s_pu As Decimal = 0
                Dim sf_can As Decimal = 0
                Dim sf_pu As Decimal = 0
                Dim sf_pt As Decimal = 0

                For i As Integer = 0 To trKardex - 1
                    APrueba.Worksheets("formato").Rows(fila + i).Insert(Shift:=(fila + i))
                    .Cells((fila + i), "A") = tbDatos.Rows(i)("cuo").ToString
                    .Cells((fila + i), "B") = Date.Parse(tbDatos.Rows(i)("fec_emision")).ToString("yyyy/MM/dd")
                    .Cells((fila + i), "C") = Date.Parse(tbDatos.Rows(i)("fec_pago")).ToString("yyyy/MM/dd")
                    .Cells((fila + i), "D") = tbDatos.Rows(i)("id_tipo_comprobante").ToString
                    .Cells((fila + i), "E") = tbDatos.Rows(i)("serie_comprobante").ToString
                    .Cells((fila + i), "F") = tbDatos.Rows(i)("numero_comprobante").ToString
                    .Cells((fila + i), "G") = tbDatos.Rows(i)("cod_dni").ToString
                    .Cells((fila + i), "H") = tbDatos.Rows(i)("num_dni").ToString
                    .Cells((fila + i), "I") = tbDatos.Rows(i)("razon_social").ToString
                    .Cells((fila + i), "J") = tbDatos.Rows(i)("valor_facturado").ToString
                    .Cells((fila + i), "O") = tbDatos.Rows(i)("valor_igv").ToString
                    .Cells((fila + i), "Q") = tbDatos.Rows(i)("total").ToString
                    .Cells((fila + i), "R") = tbDatos.Rows(i)("tipo_cambio").ToString
                Next
                Dim filaRest As Integer = (fila + trKardex)
                'MsgBox(.Cells((17 + trKardex), "A").Value)
                If .Cells(filaRest, "A").Value = "" Then
                    .Rows(filaRest).Delete()
                End If

                'SUMA DE TOTALES
                .Cells(filaRest, "K").Formula = "=SUM(K" & fila & ":K" & filaRest - 1 & ")"
                .Cells(filaRest, "O").Formula = "=SUM(O" & fila & ":O" & filaRest - 1 & ")"
                .Cells(filaRest, "Q").Formula = "=SUM(Q" & fila & ":Q" & filaRest - 1 & ")"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        generarExcelCompras()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        generarExcelVentas()
    End Sub
End Class