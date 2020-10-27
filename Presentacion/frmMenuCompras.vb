Public Class frmMenuCompras

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        frmNuevaCompra.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        frmListaComprobanteCompras.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        frmNuevaNotaCredito.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        frmNuevaNotaDebito.Show()
    End Sub

End Class