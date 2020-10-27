Imports Negocio
Imports System.IO

Public Class frmListaLibroDiario

    Dim obj As New nCrud
    Dim iCarga As Integer = 0
    Dim lista As New DataTable
    Dim filaTable As New DataTable
    Dim mesPeriodo As Integer
    Dim codigoLibro As String = "050300"
    Private Sub cargarDatos()
        Dim data As New DataTable
        Dim query As String
        query = "select * from asientos_libro_diario  where fecha_operacion>='" & dtDesde.Value().ToString("yyyy-MM-dd") & "' and fecha_operacion<='" & dtHasta.Value().ToString("yyyy-MM-dd") & "' order by cuenta asc"
        data = obj.nCrudListarBD(query, CadenaConexion)
        dgvLista.DataSource = data
        lista = data
        data = Nothing
    End Sub

    Private Sub frmListaLibroDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtDesde.Value = DateTime.Today.AddMonths("-1")
        mesPeriodo = 11
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        cargarDatos()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        generarExcel()
    End Sub
    Private Sub generarExcel()
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
            Archivo = CARPETA_EXCELS & "registro.libro.diario.xlsx" 'Pon aqui el nombre de archivo que quieras
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
                    .Cells((fila + i), "B") = "2015" & mesPeriodo & "00"
                    .Cells((fila + i), "C").Value = "00000" & acumulador
                    .Cells((fila + i), "D").Value = "M00" & acumulador
                    .Cells((fila + i), "E") = "01"
                    .Cells((fila + i), "F") = tbDatos.Rows(i)("cuenta").ToString
                    .Cells((fila + i), "G") = Date.Parse(tbDatos.Rows(i)("fecha_operacion")).ToString("dd/MM/yyyy")
                    .Cells((fila + i), "H") = tbDatos.Rows(i)("glosa").ToString
                    .Cells((fila + i), "I") = tbDatos.Rows(i)("debe").ToString
                    .Cells((fila + i), "J") = tbDatos.Rows(i)("haber").ToString
                    .Cells((fila + i), "N") = "1"
                    filaTable.Rows.Add(.Cells((fila + i), "P").Value)
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
        nomArchivo = "LE204473933022015" & mesPeriodo & "00" & codigoLibro & "001111"

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

    Private Sub btnGenerarTxt_Click(sender As Object, e As EventArgs) Handles btnGenerarTxt.Click
        generarTxt()

    End Sub

End Class