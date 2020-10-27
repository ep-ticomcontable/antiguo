Public Class frmMenuVentas

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        frmNuevaVenta.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        frmListaComprobanteVentas_ant.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        frmNuevaNotaCreditoVenta.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        frmNuevaNotaDebitoVenta.Show()
    End Sub

End Class