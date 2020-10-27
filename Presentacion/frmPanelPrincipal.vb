Imports Negocio
Public Class frmPanelPrincipal
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

    Private Sub frmPanelPrincipal_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        dimensionMenuCompras()
        dimensionMenuVentas()
    End Sub
    Private Sub dimensionMenuCompras()
        If panelMenuCompras.Visible = True Then
            panelMenuCompras.Height = 160
            pbCerrarMenu.Location = New Point((Me.Width - pbCerrarMenu.Width - 16), (Me.Height - panelMenuCompras.Height - pbCerrarMenu.Width - 13))
            panelMenuCompras.Location = New Point(0, (Me.Height - panelMenuCompras.Height - 38))
            panelMenuCompras.Width = Me.Width - 16
        End If
    End Sub
    Private Sub dimensionMenuVentas()
        If panelMenuVentas.Visible = True Then
            panelMenuVentas.Height = 160
            pbCerrarMenu.Location = New Point((Me.Width - pbCerrarMenu.Width - 16), (Me.Height - panelMenuVentas.Height - pbCerrarMenu.Width - 13))
            panelMenuVentas.Location = New Point(0, (Me.Height - panelMenuVentas.Height - 38))
            panelMenuVentas.Width = Me.Width - 16
        End If
    End Sub
    Private Sub pbCerrarMenuCompras_Click(sender As Object, e As EventArgs) Handles pbCerrarMenu.Click
        pbCerrarMenu.Visible = False
        gbTipoCambio.Visible = True

        panelMenuCompras.Visible = False
        mCompras.BackColor = Color.White
        panelMenuVentas.Visible = False
        mVentas.BackColor = Color.White

    End Sub

    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        mCompras.BackColor = Color.FromArgb(6, 63, 114)

        mVentas.BackColor = Color.White
        mPlanillas.BackColor = Color.White
        mCajas.BackColor = Color.White
        mLibros.BackColor = Color.White
        mBancos.BackColor = Color.White

        pbCerrarMenu.Visible = True
        panelMenuCompras.Visible = True
        gbTipoCambio.Visible = False
        dimensionMenuCompras()
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        mVentas.BackColor = Color.FromArgb(6, 63, 114)

        mCompras.BackColor = Color.White
        mPlanillas.BackColor = Color.White
        mCajas.BackColor = Color.White
        mLibros.BackColor = Color.White
        mBancos.BackColor = Color.White

        pbCerrarMenu.Visible = True
        panelMenuVentas.Visible = True
        gbTipoCambio.Visible = False
        dimensionMenuVentas()
    End Sub

    Private Sub btnPlanillas_Click(sender As Object, e As EventArgs) Handles btnPlanillas.Click
        'mPlanillas.BackColor = Color.FromArgb(6, 63, 114)

        'mCompras.BackColor = Color.White
        'mVentas.BackColor = Color.White
        'mCajas.BackColor = Color.White
        'mLibros.BackColor = Color.White
        'mBancos.BackColor = Color.White
        frmInicioPlanilla.Show()
    End Sub

    Private Sub btnBancos_Click(sender As Object, e As EventArgs) Handles btnBancos.Click
        'mBancos.BackColor = Color.FromArgb(6, 63, 114)

        'mCompras.BackColor = Color.White
        'mVentas.BackColor = Color.White
        'mPlanillas.BackColor = Color.White
        'mLibros.BackColor = Color.White
        'mCajas.BackColor = Color.White
        frmInicioBancos.Show()
    End Sub

    Private Sub btnCajas_Click(sender As Object, e As EventArgs) Handles btnCajas.Click
        'mCajas.BackColor = Color.FromArgb(6, 63, 114)

        'mCompras.BackColor = Color.White
        'mVentas.BackColor = Color.White
        'mPlanillas.BackColor = Color.White
        'mLibros.BackColor = Color.White
        'mBancos.BackColor = Color.White
        frmInicioCaja.Show()
    End Sub

    Private Sub btnLibrosContables_Click(sender As Object, e As EventArgs) Handles btnLibrosContables.Click
        mLibros.BackColor = Color.FromArgb(6, 63, 114)

        mCompras.BackColor = Color.White
        mVentas.BackColor = Color.White
        mPlanillas.BackColor = Color.White
        mCajas.BackColor = Color.White
        mBancos.BackColor = Color.White
    End Sub

    Private Sub frmPanelPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarMenu()
        cargarMonedas()
        cboMoneda.SelectedValue = "151"
        iCarga = 1
        If iCarga = 1 Then
            cargarTipoDeCambio()
        End If

        'VERIFICAR ACTUALIZACION DE TIPO DE CAMBIO
        'verificarActualizacionTipoDeCambio()
    End Sub

    Private Sub verificarActualizacionTipoDeCambio()
        Dim dt As New DataTable
        dt = obj.nCrudListarBD("select * from tipo_cambio where fec_reg='" & DateTime.Now.ToString("yyyy-MM-dd") & "'", CadenaConexion)
        If dt.Rows.Count > 0 Then

        Else
            MessageBox.Show("Debe actualizar el Tipo de Cambio al día para continuar.", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            txtCompra.Focus()
        End If
    End Sub

    Private Sub cargarMenu()
        pbMenu.Location = New Point(1065, 32)
        panelMenu.Visible = False
    End Sub

    Private Sub pbMenu_Click(sender As Object, e As EventArgs) Handles pbMenu.Click
        If panelMenu.Visible = True Then
            pbMenu.Location = New Point((Me.Width - pbMenu.Width - 15), 32)
            panelMenu.Visible = False
        Else
            panelMenu.Size = New Size(220, 368)
            pbMenu.Location = New Point((Me.Width - pbMenu.Width - panelMenu.Width - 15), 32)
            panelMenu.Visible = True
            panelMenu.Location = New Point((Me.Width - panelMenu.Width - 15), 32)
        End If
    End Sub

    Private Sub lblEmpresa_MouseHover(sender As Object, e As EventArgs) Handles lblEmpresa.MouseHover
        On Error Resume Next
        lineaEmpresa.BackColor = Color.FromArgb(6, 63, 114)

        lineaUsuario.BackColor = Color.White
        lineaPlanContable.BackColor = Color.White
        lineaCliente.BackColor = Color.White
        lineaProveedor.BackColor = Color.White
        lineaTipoMoneda.BackColor = Color.White
        lineaTipoOperacion.BackColor = Color.White
        lineaParametrizacion.BackColor = Color.White
    End Sub

    Private Sub lblUsuarios_MouseHover(sender As Object, e As EventArgs) Handles lblUsuarios.MouseHover
        On Error Resume Next
        lineaUsuario.BackColor = Color.FromArgb(6, 63, 114)

        lineaEmpresa.BackColor = Color.White
        lineaPlanContable.BackColor = Color.White
        lineaCliente.BackColor = Color.White
        lineaProveedor.BackColor = Color.White
        lineaTipoMoneda.BackColor = Color.White
        lineaTipoOperacion.BackColor = Color.White
        lineaParametrizacion.BackColor = Color.White
    End Sub

    Private Sub lblPlanContable_MouseHover(sender As Object, e As EventArgs) Handles lblPlanContable.MouseHover
        On Error Resume Next
        lineaPlanContable.BackColor = Color.FromArgb(6, 63, 114)

        lineaUsuario.BackColor = Color.White
        lineaEmpresa.BackColor = Color.White
        lineaCliente.BackColor = Color.White
        lineaProveedor.BackColor = Color.White
        lineaTipoMoneda.BackColor = Color.White
        lineaTipoOperacion.BackColor = Color.White
        lineaParametrizacion.BackColor = Color.White
    End Sub

    Private Sub lblClientes_MouseHover(sender As Object, e As EventArgs) Handles lblClientes.MouseHover
        On Error Resume Next
        lineaCliente.BackColor = Color.FromArgb(6, 63, 114)

        lineaUsuario.BackColor = Color.White
        lineaPlanContable.BackColor = Color.White
        lineaEmpresa.BackColor = Color.White
        lineaProveedor.BackColor = Color.White
        lineaTipoMoneda.BackColor = Color.White
        lineaTipoOperacion.BackColor = Color.White
        lineaParametrizacion.BackColor = Color.White
    End Sub

    Private Sub lblProveedores_MouseHover(sender As Object, e As EventArgs) Handles lblProveedores.MouseHover
        On Error Resume Next
        lineaProveedor.BackColor = Color.FromArgb(6, 63, 114)

        lineaUsuario.BackColor = Color.White
        lineaPlanContable.BackColor = Color.White
        lineaCliente.BackColor = Color.White
        lineaEmpresa.BackColor = Color.White
        lineaTipoMoneda.BackColor = Color.White
        lineaTipoOperacion.BackColor = Color.White
        lineaParametrizacion.BackColor = Color.White
    End Sub

    Private Sub lblTipoMoneda_MouseHover(sender As Object, e As EventArgs) Handles lblTipoMoneda.MouseHover
        On Error Resume Next
        lineaTipoMoneda.BackColor = Color.FromArgb(6, 63, 114)

        lineaUsuario.BackColor = Color.White
        lineaPlanContable.BackColor = Color.White
        lineaCliente.BackColor = Color.White
        lineaEmpresa.BackColor = Color.White
        lineaProveedor.BackColor = Color.White
        lineaTipoOperacion.BackColor = Color.White
        lineaParametrizacion.BackColor = Color.White
    End Sub

    Private Sub lblTipoOperacion_MouseHover(sender As Object, e As EventArgs) Handles lblTipoOperacion.MouseHover
        On Error Resume Next
        lineaTipoOperacion.BackColor = Color.FromArgb(6, 63, 114)

        lineaUsuario.BackColor = Color.White
        lineaPlanContable.BackColor = Color.White
        lineaCliente.BackColor = Color.White
        lineaEmpresa.BackColor = Color.White
        lineaProveedor.BackColor = Color.White
        lineaTipoMoneda.BackColor = Color.White
    End Sub

    Private Sub lblParametrizacion_MouseHover(sender As Object, e As EventArgs) Handles lblParametrizacion.MouseHover
        On Error Resume Next
        lineaParametrizacion.BackColor = Color.FromArgb(6, 63, 114)

        lineaUsuario.BackColor = Color.White
        lineaPlanContable.BackColor = Color.White
        lineaCliente.BackColor = Color.White
        lineaEmpresa.BackColor = Color.White
        lineaProveedor.BackColor = Color.White
        lineaTipoMoneda.BackColor = Color.White
        lineaTipoOperacion.BackColor = Color.White
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
        End If
    End Sub

    Private Sub btnMisCompras_Click(sender As Object, e As EventArgs) Handles btnMisCompras.Click
        frmListaComprobanteCompras.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        frmListaComprobanteVentas.Show()
    End Sub

    Private Sub lblEmpresa_Click(sender As Object, e As EventArgs) Handles lblEmpresa.Click
        frmEmpresas.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'frmPrincipal.Dispose()
        frmPrincipal.Text = "TICOM CONTABLE" ' - EJERCICIO DE LA EMPRESA: (" & Data.Rows(0)("nombre").ToString.ToUpper & ") - USUARIO: " & NombreUsuarioSession & " - PERIODO: (" & cboPeriodo.SelectedValue & ")"
        'frmPrincipal.Label1.Text = Data.Rows(0)("nombre").ToString.ToUpper & " - " & cboPeriodo.SelectedValue
        'frmPrincipal.BackColor = Color.FromArgb(Data.Rows(0)("color_fondo").ToString)
        frmPrincipal.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmListaAperturas.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmInicioLibroDiario.Show()
    End Sub

    Private Sub lblPlanContable_Click(sender As Object, e As EventArgs) Handles lblPlanContable.Click
        frmPlanContable.Show()
    End Sub

    Private Sub lblClientes_Click(sender As Object, e As EventArgs) Handles lblClientes.Click
        frmTsClientes.Show()
    End Sub

    Private Sub lblProveedores_Click(sender As Object, e As EventArgs) Handles lblProveedores.Click
        frmTsProveedores.Show()
    End Sub

    Private Sub lblTipoMoneda_Click(sender As Object, e As EventArgs) Handles lblTipoMoneda.Click
        frmTsTipoMoneda.Show()
    End Sub

    Private Sub lblTipoOperacion_Click(sender As Object, e As EventArgs) Handles lblTipoOperacion.Click
        frmTsTipoOperacion.Show()
    End Sub

    Private Sub lblParametrizacion_Click(sender As Object, e As EventArgs) Handles lblParametrizacion.Click
        frmTsImpuestosSunat.Show()
    End Sub

    Private Sub lblUsuarios_Click(sender As Object, e As EventArgs) Handles lblUsuarios.Click
        frmTsUsuarios.Show()
    End Sub
End Class