Public Class form1

    Private Sub pbCompras_Click(sender As Object, e As EventArgs) Handles pbCompras.Click
        frmInicioCompras.MdiParent = frmPrincipal
        frmInicioCompras.Show()
        frmInicioCompras.WindowState = FormWindowState.Normal
    End Sub

    Private Sub pbCompras_DoubleClick(sender As Object, e As EventArgs) Handles pbCompras.DoubleClick
        frmInicioCompras.MdiParent = frmPrincipal
        frmInicioCompras.Show()
        frmInicioCompras.WindowState = FormWindowState.Normal

    End Sub
End Class