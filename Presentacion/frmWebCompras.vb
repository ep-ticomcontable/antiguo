Public Class frmWebCompras

    Private Sub frmWebCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("http://localhost:8080/webticom/admin/webCompras.php")
        'WebBrowser1.Navigate("https://www.google.com.pe/")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Refresh()
    End Sub
End Class