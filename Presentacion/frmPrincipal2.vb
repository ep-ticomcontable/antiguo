Public Class frmPrincipal2

    Private Sub PlanContableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanContableToolStripMenuItem.Click
        Dim form As New frmPlanContable()
        form.MdiParent = Me
        form.Show()
    End Sub


    Private Sub TipoDeMedioDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeMedioDePagoToolStripMenuItem.Click
        Dim form As New frmTsTipoPago()
        'form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub TipoDeDocumentoDeIdentidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeDocumentoDeIdentidadToolStripMenuItem.Click
        Dim form As New frmTsDocumentoIdentidad()
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub EntidadFinancieraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntidadFinancieraToolStripMenuItem.Click
        Dim form As New frmTsEntidadFinanciera()
        'form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub TipoDeMonedaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeMonedaToolStripMenuItem.Click
        Dim form As New frmTsTipoMoneda()
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub TipoDeExistenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeExistenciaToolStripMenuItem.Click
        Dim form As New frmTsTipoExistencia()
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub CodigoDeUnidadDeMedidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CodigoDeUnidadDeMedidaToolStripMenuItem.Click
        Dim form As New frmTsUnidadMedida()
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub TipoDeComprobanteDePagoODocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeComprobanteDePagoODocumentoToolStripMenuItem.Click
        Dim form As New frmTsTipoDocumento()
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub CodigoDeLaAduanaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CodigoDeLaAduanaToolStripMenuItem.Click
        Dim form As New frmTsAduana()
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub TipoDeOperaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeOperaciónToolStripMenuItem.Click
        Dim form As New frmTsTipoOperacion()
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub MétodoDeEvaluaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MétodoDeEvaluaciónToolStripMenuItem.Click
        Dim form As New frmTsMetodoEvaluacion()
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub DistritoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DistritoToolStripMenuItem.Click

    End Sub

    Private Sub UsuariosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem1.Click
        frmTsUsuarios.Show()
    End Sub

    Private Sub EmpresasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpresasToolStripMenuItem1.Click
        frmTsEmpresa.Show()
    End Sub

    Private Sub PlanillasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanillasToolStripMenuItem.Click
        frmParametroLibroMayor.Show()
    End Sub

    Private Sub KardexPepsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KardexPepsToolStripMenuItem.Click
        frmExcel.Show()
    End Sub
End Class