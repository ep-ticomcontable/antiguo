Imports Negocio
Imports System.IO

Public Class frmListaCompras

    Dim obj As New nCrud
    Dim iCarga As Integer = 0
    Dim lista As New DataTable
    Dim filaTable As New DataTable
    Dim mesPeriodo As String
    Dim codCompra As String = "080100"
    Private Sub cargarCompras()
        Dim data As New DataTable
        Dim query As String
        query = "select * from comprobante_compra  where fec_emision>='" & dtDesde.Value().ToString("yyyy-MM-dd") & "' and fec_emision<='" & dtHasta.Value().ToString("yyyy-MM-dd") & "' order by fec_emision asc"
        data = obj.nCrudListarBD(query, CadenaConexion)
        dgvLista.DataSource = data
        lista = data
        data = Nothing
    End Sub

    Private Sub frmListaCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtDesde.Value = DateTime.Today.AddMonths("-3")
        mesPeriodo = "01"
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        cargarCompras()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        generarExcelCompras()
    End Sub
    Private Sub generarExcelCompras()
        Me.Enabled = False
        Try

            Dim tbDatos As New DataTable
            tbDatos = lista
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
                    .Cells((fila + i), "B") = "2016" & mesPeriodo & "00"
                    .Cells((fila + i), "C").Value = "00000" & acumulador
                    .Cells((fila + i), "D").Value = "M00" & acumulador
                    .Cells((fila + i), "E") = Date.Parse(tbDatos.Rows(i)("fec_emision")).ToString("dd/MM/yyyy")
                    .Cells((fila + i), "F") = Date.Parse(tbDatos.Rows(i)("fec_pago")).ToString("dd/MM/yyyy")
                    Dim tc As DataTable = obj.nCrudListarBD("select * from tipo_documento where id='" & tbDatos.Rows(i)("id_tipo_comprobante").ToString & "'", CadenaConexion)
                    .Cells((fila + i), "G") = tc.Rows(0)("codigo").ToString
                    .Cells((fila + i), "H") = tbDatos.Rows(i)("serie_comprobante").ToString
                    .Cells((fila + i), "J") = tbDatos.Rows(i)("numero_comprobante").ToString
                    .Cells((fila + i), "L") = tbDatos.Rows(i)("cod_dni").ToString
                    .Cells((fila + i), "M") = tbDatos.Rows(i)("num_dni").ToString
                    .Cells((fila + i), "N") = tbDatos.Rows(i)("razon_social").ToString
                    .Cells((fila + i), "O") = tbDatos.Rows(i)("valor_facturado").ToString
                    .Cells((fila + i), "P") = tbDatos.Rows(i)("valor_igv").ToString
                    .Cells((fila + i), "X") = tbDatos.Rows(i)("total").ToString
                    .Cells((fila + i), "Y") = IIf(Decimal.Parse(tbDatos.Rows(i)("tipo_cambio").ToString) > 1, tbDatos.Rows(i)("tipo_cambio").ToString, "")
                    If tbDatos.Rows(i)("fec_comp_origen").ToString <> "" Then
                        .Cells((fila + i), "Z") = Date.Parse(tbDatos.Rows(i)("fec_comp_origen")).ToString("dd/MM/yyyy")
                        Dim tc2 As DataTable = obj.nCrudListarBD("select * from tipo_documento where id='" & tbDatos.Rows(i)("tip_comp_origen").ToString & "'", CadenaConexion)
                        .Cells((fila + i), "AA") = tc2.Rows(0)("codigo").ToString
                        .Cells((fila + i), "AB") = tbDatos.Rows(i)("serie_comp_origen").ToString
                        .Cells((fila + i), "AD") = tbDatos.Rows(i)("numero_comp_origen").ToString
                    End If
                    .Cells((fila + i), "AI") = "1"
                    filaTable.Rows.Add(.Cells((fila + i), "AK").Value)
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

        Dim nomArchivo As String
        nomArchivo = "LE204473933022016" & mesPeriodo & "00" & codCompra & "001111"

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
            MsgBox("Error al Guardar la información en el archivo. " & ex.ToString, MsgBoxStyle.Critical, Application.ProductName)
            strStreamWriter.Close() ' cerramos
        End Try
    End Sub

    Private Sub btnGenerarTxt_Click(sender As Object, e As EventArgs) Handles btnGenerarTxt.Click
        generarTxt()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmListaComprobanteCompras.Show()
    End Sub

    Private Sub dtHasta_ValueChanged(sender As Object, e As EventArgs) Handles dtHasta.ValueChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub dtDesde_ValueChanged(sender As Object, e As EventArgs) Handles dtDesde.ValueChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class