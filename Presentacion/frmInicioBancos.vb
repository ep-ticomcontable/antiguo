Public Class frmInicioBancos
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmListaCajaBancos.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        frmChequeTalonario.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        frmListaComprobanteCompras.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frmSalidaBanco.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        frmListaComprobanteVentas.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        frmBancosConfiguracion.Show()
    End Sub

    Private Sub btnComprasGeneral_Click(sender As Object, e As EventArgs) Handles btnComprasGeneral.Click
        frmGirarCheque.Show()
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        frmListaEntradasSalidasBancos.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        frmListaComprobanteVentas.Show()
    End Sub
End Class