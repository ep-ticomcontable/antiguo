Public Class frmInicioCajaChica

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmListaCajaChica.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frmRegistrarSalidasCajaChica.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        frmListaComprobanteCompras.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        frmCajaConfiguracion.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        frmTipoSalidas.show()
    End Sub

    Private Sub btnComprasGeneral_Click(sender As Object, e As EventArgs) Handles btnComprasGeneral.Click

    End Sub
End Class