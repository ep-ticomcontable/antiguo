Public Class frmInicioCompras

    Private Sub btnComprasGeneral_Click(sender As Object, e As EventArgs) Handles btnComprasGeneral.Click
        frmNuevaCompraMercaderias.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmListaComprobanteCompras.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        frmNuevaNotaCredito.Show()
    End Sub


    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)
        frmCentralizacion.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        frmListaNotasDebitoCompra.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        frmNuevaCompraP.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        frmListaCentroCostos.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        frmListaNotasCreditoCompra.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles pbPercepcion.Click
        frmListaPercepcionesPorPagar.Show()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles pbRetencion.Click
        frmListaRetencionesPorPagar.Show()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs)
        frmImportarCompras.Show()
    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs) Handles PictureBox6.Click
        frmListaLetrasPorPagar.Show()
    End Sub

    Private Sub pbDetraccion_Click(sender As Object, e As EventArgs) Handles pbDetraccion.Click
        frmListaDetracciones.tipo = "COMPRA"
        frmListaDetracciones.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        frmListaDetracciones.tipo = "COMPRA"
        frmListaDetracciones.Show()
    End Sub
End Class