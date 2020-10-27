Imports Negocio

Public Class frmPrincipal
    Dim obj As New nCrud
    Dim iCarga As Integer = 0
    Private Sub cargarMonedas()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select * from tipo_moneda where estado=1 order by id asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, "(" & row.Item("codigo").ToString & ") " & row.Item("descripcion").ToString)
            Next
            With cboMoneda
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Monedas")
        End Try
    End Sub
    Private Sub cargarTipoDeCambio()
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from tipo_cambio where id_moneda='" & cboMoneda.SelectedValue & "' and estado='1' order by fec_reg desc", CadenaConexion)
        With data
            'cboMoneda.SelectedValue = .Rows(0)("id_moneda").ToString
            txtCompra.Text = .Rows(0)("compra").ToString
            txtVenta.Text = .Rows(0)("venta").ToString
            dtFecha.Value = DateTime.Now.ToString("dd/MM/yyyy")
        End With
    End Sub
    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        'frmInicioLibroDiario.MdiParent = Me
        frmInicioLibroDiario.Show()

        'frmInicioLibroDiario.Show()
    End Sub

    Private Sub pbProductos_Click(sender As Object, e As EventArgs)
        'frmEmpresa.MdiParent = Me
        frmEmpresa.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        'frmAsientoApertura.MdiParent = Me
        'frmNuevoRegistroApertura.MdiParent = Me
        frmListaAperturas.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles pbCompras.Click
        'frmInicioCompras.MdiParent = Me
        frmInicioCompras.Show()
    End Sub

    Private Sub pbConfiguracion_Click(sender As Object, e As EventArgs) Handles pbConfiguracion.Click
        'frmInicioVentas.MdiParent = Me
        frmInicioVentas.Show()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarMonedas()
        cboMoneda.SelectedValue = "151"
        iCarga = 1
        If iCarga = 1 Then
            cargarTipoDeCambio()
        End If

        'VERIFICAR ACTUALIZACION DE TIPO DE CAMBIO
        verificarActualizacionTipoDeCambio()

        'form1.MdiParent = Me
        'form1.Width = Me.Width - 10
        'form1.Height = Me.Height - 10
        'form1.Show()
        'pbCompras.SendToBack()
        'frmInicioVentas.Show()
    End Sub
    Private Sub frmPrincipal_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            If MsgBox("¿Está seguro que desea salir del Sistema?.", MsgBoxStyle.YesNo, "Cerrar Sistema") = MsgBoxResult.Yes Then
                Application.Exit()
            Else
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub frmPrincipal_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        panelTC.Location = New Point(0, (Me.Height / 2) - (panelTC.Height / 2))
        panelTC.Width = Me.Width - 16
    End Sub
    Private Sub verificarActualizacionTipoDeCambio()
        Dim dt As New DataTable
        dt = obj.nCrudListarBD("select * from tipo_cambio where fec_reg='" & DateTime.Now.ToString("yyyy-MM-dd") & "'", CadenaConexion)
        If dt.Rows.Count > 0 Then
            panelForm.Enabled = True
            MenuStrip.Enabled = True
            panelTC.Visible = False
            pbOcultarTC.Visible = True
        Else
            MessageBox.Show("Debe actualizar el Tipo de Cambio al día para continuar.", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            panelTC.Visible = True
            pbOcultarTC.Visible = False
            panelForm.Enabled = False
            MenuStrip.Enabled = False
            txtCompra.Focus()
        End If
    End Sub

    Private Sub txtCompra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCompra.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtVenta.Focus()
        End If
    End Sub

    Private Sub txtVenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVenta.KeyPress
        If Asc(e.KeyChar) = 13 Then
            dtFecha.Focus()
        End If
    End Sub

    Private Sub dtFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtFecha.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnProcesar.Focus()
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Está seguro que desea salir del Sistema?.", MsgBoxStyle.YesNo, "Cerrar Sistema") = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub AperturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AperturaToolStripMenuItem.Click
        'frmAsientoApertura.MdiParent = Me
        frmListaAperturas.Show()
    End Sub

    Private Sub RegistroDeComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeComprasToolStripMenuItem.Click
        'frmListaCompras.MdiParent = Me
        frmListaCompras.Show()
    End Sub

    Private Sub RegistroDeVentasToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RegistroDeVentasToolStripMenuItem2.Click
        'frmListaVentas.MdiParent = Me
        frmListaVentas.Show()
    End Sub

    Private Sub PlanContableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanContableToolStripMenuItem.Click
        'frmPlanContable.MdiParent = Me
        frmPlanContable.Show()
    End Sub

    Private Sub TipoDeCambioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeCambioToolStripMenuItem.Click
        'frmTsTipoCambio.MdiParent = Me
        frmTsTipoCambio.Show()
    End Sub

    Private Sub OrigenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrigenesToolStripMenuItem.Click
        'frmTsTipoOperacion.MdiParent = Me
        frmTsTipoOperacion.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        'frmTsProveedores.MdiParent = Me
        frmTsProveedores.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        'frmTsClientes.MdiParent = Me
        frmTsClientes.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem1.Click
        frmTsUsuarios.Show()
    End Sub

    Private Sub EmpresasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpresasToolStripMenuItem1.Click
        'frmTsEmpresa.MdiParent = Me
        frmTsEmpresa.Show()
    End Sub

    Private Sub UsuariosEmpresaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UsuariosEmpresaToolStripMenuItem1.Click
        'frmTsUsuarios.MdiParent = Me
        frmTsUsuarios.Show()
    End Sub

    Private Sub LibroDiarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibroDiarioToolStripMenuItem.Click
        'frmListaLibroDiario.MdiParent = Me
        frmListaLibroDiario.Show()
    End Sub

    Private Sub TipoDeMonedaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeMonedaToolStripMenuItem.Click
        'frmTsTipoMoneda.MdiParent = Me
        frmTsTipoMoneda.Show()
    End Sub

    Private Sub TipoDeExistenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeExistenciaToolStripMenuItem.Click
        'frmTsTipoExistencia.MdiParent = Me
        frmTsTipoExistencia.Show()
    End Sub

    Private Sub MétodoDeEvaluaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MétodoDeEvaluaciónToolStripMenuItem.Click
        'frmTsMetodoEvaluacion.MdiParent = Me
        frmTsMetodoEvaluacion.Show()
    End Sub

    Private Sub TipoDeComprobanteDePagoODocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeComprobanteDePagoODocumentoToolStripMenuItem.Click
        'frmTsTipoDocumento.MdiParent = Me
        frmTsTipoDocumento.Show()
    End Sub

    Private Sub CodigoDeLaAduanaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CodigoDeLaAduanaToolStripMenuItem.Click
        'frmTsAduana.MdiParent = Me
        frmTsAduana.Show()
    End Sub

    Private Sub CuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentasToolStripMenuItem.Click
        'frmTsCuentasTipoOperacion.MdiParent = Me
        frmTsCuentasTipoOperacion.Show()
    End Sub

    Private Sub RegistroDePlanillasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDePlanillasToolStripMenuItem.Click
        'frmListaPlanillas.MdiParent = Me
        frmListaPlanillas.Show()
    End Sub

    Private Sub ToolStripMenuItem16_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem16.Click
        'frmNuevaCompra.MdiParent = Me
        frmNuevaCompra.Show()
    End Sub

    Private Sub CentroDeCostosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CentroDeCostosToolStripMenuItem.Click
        'frmCrearCentroCosto.MdiParent = Me
        frmCrearCentroCosto.Show()
    End Sub

    Private Sub AsignacionACentroDeCostosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignacionACentroDeCostosToolStripMenuItem.Click
        'frmParametrosCentroCosto.MdiParent = Me
        frmParametrosCentroCosto.Show()
    End Sub

    Private Sub NotasDeCreditoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotasDeCreditoToolStripMenuItem.Click
        'frmListaCompras.MdiParent = Me
        frmListaCompras.Show()
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        'frmNuevaVenta.MdiParent = Me
        frmNuevaVenta.Show()
    End Sub

    Private Sub ToolStripMenuItem21_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem21.Click
        'frmListaVentas.MdiParent = Me
        frmListaVentas.Show()
    End Sub

    Private Sub CobranzaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CobranzaToolStripMenuItem.Click
        'frmCobranzas.MdiParent = Me
        frmCobranzas.Show()
    End Sub

    Private Sub ConciliaciónBancariaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConciliaciónBancariaToolStripMenuItem.Click
        'frmListaEntradasSalidasBancos.MdiParent = Me
        frmListaEntradasSalidasBancos.Show()
    End Sub

    Private Sub LibroMayorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibroMayorToolStripMenuItem.Click
        'frmParametroLibroMayor.MdiParent = Me
        frmParametroLibroMayor.Show()
    End Sub

    Private Sub EntidadFinancieraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntidadFinancieraToolStripMenuItem.Click
        'frmTsEntidadFinanciera.MdiParent = Me
        frmTsEntidadFinanciera.Show()
    End Sub

    Private Sub TipoDeOperaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeOperaciónToolStripMenuItem.Click
        'frmTsTipoOperacion.MdiParent = Me
        frmTsTipoOperacion.Show()
    End Sub

    Private Sub UsuariosRolesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UsuariosRolesToolStripMenuItem1.Click
        'frmTareasModulo.MdiParent = Me
        frmTareasModulo.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        'frmLibrosPle.MdiParent = Me
        frmLibrosPle.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'frmInicioCajaChica.MdiParent = Me
        frmInicioPlanilla.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        'frmInicioCaja.MdiParent = Me
        'frmICajas.Show()
        frmInicioCaja.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        'frmInicioBancos.MdiParent = Me
        frmInicioBancos.Show()
    End Sub

    Private Sub cboMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMoneda.SelectedIndexChanged
        If iCarga = 1 Then
            cargarTipoDeCambio()
        End If
    End Sub



    Private Sub pbOcultarTC_Click(sender As Object, e As EventArgs) Handles pbOcultarTC.Click
        pbOcultarTC.Visible = False
        mostrarPanelTipoCambio()
    End Sub
    Private Sub mostrarPanelTipoCambio()
        panelForm.Enabled = False
        If panelTC.Visible = False Then
            'panelTC.Size = New Size(1380, 250)
            panelTC.Location = New Point(0, (Me.Height / 2) - (panelTC.Height / 2))
            panelTC.Width = Me.Width - 16
            panelTC.Visible = True
        Else
        panelTC.Visible = False
        End If
    End Sub


    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        frmEleccionEmpresa.ShowDialog()
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        frmEleccionEmpresa.ShowDialog()
    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim campos As String
        Dim valores As String
        campos = "id_moneda@compra@venta@fec_reg@estado"
        valores = cboMoneda.SelectedValue.ToString & "@" & txtCompra.Text.Trim & "@" & txtVenta.Text.ToString & "@" & dtFecha.Value.ToString("yyyy/MM/dd") & "@1"
        Dim rpta As String = ""
        Dim tabla As String = "tipo_cambio"
        rpta = obj.nCrudInsertarBD("@", tabla, campos, valores, CadenaConexion)
        If rpta = "ok" Then
            MessageBox.Show("Actualización del Tipo de Cambio, realizado con éxito.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            cargarTipoDeCambio()
            panelForm.Enabled = True
            MenuStrip.Enabled = True
            panelTC.Visible = False
            pbOcultarTC.Visible = True
        End If
    End Sub

    Private Sub btnNoProcesar_Click(sender As Object, e As EventArgs) Handles btnNoProcesar.Click
        panelTC.Visible = False
        panelForm.Enabled = True
        pbOcultarTC.Visible = True
    End Sub
    Private Sub txtCompra_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCompra.Leave
        txtCompra.Text = Format(CType(txtCompra.Text, Decimal), "###0.00")
    End Sub
    Private Sub txtVenta_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVenta.Leave
        txtVenta.Text = Format(CType(txtVenta.Text, Decimal), "###0.00")
    End Sub

    Private Sub CentralizaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CentralizaciónToolStripMenuItem.Click
        frmCentralizacion.Show()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        frmListaTipoCambio.Show()
    End Sub

    Private Sub ImpuestosSUNATToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImpuestosSUNATToolStripMenuItem.Click
        frmTsImpuestosSunat.Show()
    End Sub

    Private Sub ParametrosDeLasCuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParametrosDeLasCuentasToolStripMenuItem.Click

    End Sub
End Class