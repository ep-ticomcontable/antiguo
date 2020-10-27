Public Class frmInicioVentas

    Private Sub btnComprasGeneral_Click(sender As Object, e As EventArgs) Handles btnComprasGeneral.Click
        frmNuevaVentaP.Show()
        'frmNuevaVenta.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmListaComprobanteVentas.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pbImportar.Click
        frmImportarVentas.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)
        frmDepositoDetracciones.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        frmNuevaVentaMercaderias.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        frmListaPercepcionesPorCobrar.Show()
    End Sub

    Private Sub frmInicioVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        frmListaNotasCreditoVenta.Show()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frmListaLetrasPorCobrar.Show()
    End Sub

    Private Sub pbPercepcion_Click(sender As Object, e As EventArgs) Handles pbPercepcion.Click
        frmListaPercepcionesPorCobrar.Show()
    End Sub

    Private Sub pbRetencion_Click(sender As Object, e As EventArgs) Handles pbRetencion.Click
        frmListaRetencionesPorCobrar.Show()
    End Sub

    Private Sub pbDetraccion_Click(sender As Object, e As EventArgs) Handles pbDetraccion.Click
        frmListaDetracciones.tipo = "VENTA"
        frmListaDetracciones.Show()
    End Sub

    Private Sub PictureBox8_Click_1(sender As Object, e As EventArgs) Handles PictureBox8.Click
        frmListaNotasCreditoCompra.Show()
    End Sub
End Class