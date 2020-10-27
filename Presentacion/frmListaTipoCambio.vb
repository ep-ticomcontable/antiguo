Imports System.Text.RegularExpressions

Public Class frmListaTipoCambio

    Private Sub BtnCargar_Click(sender As Object, e As EventArgs) Handles BtnCargar.Click
        ObtenerDatos()
    End Sub

    Private Sub ObtenerDatos()
        'Me.Refresh()
        Dim objWebClient As System.Net.WebClient
        Dim strHTML As String = ""
        Dim strURL As String

        Dim intAño As Integer
        Dim intMes As Integer

        Dim dtDateAux As Date
        objWebClient = New System.Net.WebClient()

        dtDateAux = DateSerial(Year(Now), Month(Now), 1).AddDays(-1)

        ' Primero: Obtener el TC del mes anterior
        intAño = Year(dtDateAux)
        intMes = Month(dtDateAux)

        strURL = "http://www.sunat.gob.pe/cl-at-ittipcam/tcS01Alias?mes=" & intMes & "&anho=" & intAño

        If CargarDocHTML(objWebClient, strURL, strHTML) Then
            ProcesarDocHTML(strHTML, intAño, intMes)
        End If

        intAño = Integer.Parse(txtAnio.Text.Trim) 'Year(Now())
        intMes = Integer.Parse(txtMes.Text.Trim) 'Month(Now())

        strURL = "http://www.sunat.gob.pe/cl-at-ittipcam/tcS01Alias?mes=" & intMes & "&anho=" & intAño

        If CargarDocHTML(objWebClient, strURL, strHTML) Then
            ProcesarDocHTML(strHTML, intAño, intMes)
        End If

        objWebClient.Dispose()
    End Sub

    Private Function CargarDocHTML(ByRef objWebClient As System.Net.WebClient, ByVal strURL As String, ByRef strHTML As String) As Boolean
        Dim bAux As Boolean = False

        Try
            strHTML = objWebClient.DownloadString(strURL)
            bAux = Not (InStr(strHTML, "No existe Informacion") > 0)
        Catch ex As Exception
            ' Si hay una excepción no se hace nada
        End Try

        Return bAux
    End Function

    Private Sub ProcesarDocHTML(strHTML As String, intAño As Integer, intMes As Integer)
        Dim strTable As String
        Dim strFilas As String()
        Dim strCeldas As String()
        Dim intFirstPosition As Integer
        Dim intLastPosition As Integer
        Dim i As Integer
        Dim j As Integer

        Dim dtFecha As Date
        Dim dblCompra As Double
        Dim dblVenta As Double

        intFirstPosition = InStr(strHTML, "form-table")
        intFirstPosition = InStr(intFirstPosition, strHTML, "<tr>") - 1
        intLastPosition = InStr(intFirstPosition, strHTML, "</table>") - 7

        strTable = strHTML.Substring(intFirstPosition, intLastPosition - intFirstPosition)

        strFilas = Regex.Split(strTable, "</tr>")

        Dim data As New DataTable
        data.Columns.Add("fecha")
        data.Columns.Add("compra")
        data.Columns.Add("venta")

        For i = 1 To strFilas.GetUpperBound(0)
            strCeldas = Regex.Split(strFilas(i).Trim, "/td>")
            For j = 0 To strCeldas.GetUpperBound(0) Step 3
                If strCeldas(j) <> "" Then
                    ObtenerTriplete(strCeldas, j, intAño, intMes, dtFecha, dblCompra, dblVenta)
                    data.Rows.Add(Date.Parse(dtFecha).ToString("dd/MM/yyyy"), dblCompra, dblVenta)
                End If
            Next
        Next

        dgvLista.DataSource = data
        data = Nothing
    End Sub

    Private Sub ObtenerTriplete(strCeldas As String(), intIndice As Integer, intAño As Integer, intMes As Integer, ByRef dtFecha As Date, ByRef dblCompra As Double, ByRef dblVenta As Double)
        Dim intDia As Integer

        intDia = CInt(ObtenerValorCelda(strCeldas(intIndice)))
        dtFecha = DateSerial(intAño, intMes, intDia)

        dblCompra = CDbl(ObtenerValorCelda(strCeldas(intIndice + 1)))
        dblVenta = CDbl(ObtenerValorCelda(strCeldas(intIndice + 2)))
    End Sub

    Private Function ObtenerValorCelda(strCelda As String) As String
        Dim strValorCelda As String
        Dim intFirstPosition As Integer
        Dim intLastPosition As Integer

        intFirstPosition = InStr(strCelda, "<strong>")
        If intFirstPosition > 0 Then
            intLastPosition = InStr(strCelda, "</strong>")
            intFirstPosition = intFirstPosition + 7
        Else
            intFirstPosition = InStr(strCelda, "tne10")
            intFirstPosition = intFirstPosition + 7
            intLastPosition = InStr(intFirstPosition, strCelda, "<")
        End If

        strValorCelda = strCelda.Substring(intFirstPosition, intLastPosition - intFirstPosition - 1).Trim

        Return strValorCelda
    End Function

    Private Sub frmListaTipoCambio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAnio.Text = DateTime.Now.ToString("yyyy")
        txtMes.Text = DateTime.Now.ToString("MM")
    End Sub
End Class