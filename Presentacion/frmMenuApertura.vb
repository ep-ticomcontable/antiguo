Public Class frmMenuApertura

    Private Sub frmMenuApertura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub l1_Click(sender As Object, e As EventArgs) Handles l1.Click
        frmPlanContable.Show()
    End Sub

    Private Sub l9_Click(sender As Object, e As EventArgs) Handles l9.Click
        frmListaVentas.Show()
    End Sub

    Private Sub l4_Click(sender As Object, e As EventArgs) Handles l4.Click
        frmTsTipoCambio.Show()
    End Sub

    Private Sub l5_Click(sender As Object, e As EventArgs) Handles l5.Click
        frmTsTipoOperacion.Show()
    End Sub

    Private Sub l6_Click(sender As Object, e As EventArgs) Handles l6.Click
        frmTsUbigeo.Show()
    End Sub

    Private Sub l7_Click(sender As Object, e As EventArgs) Handles l7.Click
        frmTsProveedores.Show()
    End Sub

    Private Sub l8_Click(sender As Object, e As EventArgs) Handles l8.Click
        frmListaCompras.Show()
    End Sub

    Private Sub l10_Click(sender As Object, e As EventArgs) Handles l10.Click
        frmListaLibroDiario.Show()
    End Sub

    Private Sub l11_Click(sender As Object, e As EventArgs) Handles l11.Click
        frmParametroLibroMayor.Show()
    End Sub

    Private Sub l12_Click(sender As Object, e As EventArgs) Handles l12.Click
        frmTareasModulo.Show()
    End Sub
End Class