Imports Negocio
Imports Entidades

Public Class frmInicioSesion
    Private obj As New nUsuarios
    Private userE As New UsuariosE

    Private Sub frmInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPie.Text = "(MÓDULO CONTABLE - TICOM SOFTWARE V 2.0)          Todos los derechos reservados          © Ticom Perú - " & DateTime.Now.ToString("yyyy")
        txtUsuario.Focus()
        'panelLoad.Anchor = 1000
        'panelLoad.Width = 800
        panelLoad.Location = New Point(Me.Width, 0)
        Timer1.Enabled = False
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If MsgBox("¿Está seguro que desea salir del Sistema?.", MsgBoxStyle.YesNo, "Cerrar Sistema") = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub txtUsuario_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress, txtClave.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            enviarDatos()
        End If
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        enviarDatos()
    End Sub

    Private Sub enviarDatos()
        btnIngresar.Enabled = False
        panelLoad.Location = New Point(183, 530)
        userE.usuario = txtUsuario.Text.Trim
        userE.clave = txtClave.Text.Trim
        Dim tbUser As DataTable = obj.verificarSesionUsuario(userE)
        If tbUser.Rows.Count > 0 Then
            CodigoUsuarioSession = Integer.Parse(tbUser.Rows(0)("id").ToString)
            NombreUsuarioSession = tbUser.Rows(0)("usuario").ToString
            TipoUsuarioSession = tbUser.Rows(0)("tipo").ToString
            'CodigoLocalSession = Integer.Parse(tbUser.Rows(0)("id_local").ToString)
            'CodigoEmpleadoSession = Integer.Parse(tbUser.Rows(0)("id_empleado").ToString)
            'MsgBox("NOMBRES: " & tbUser.Rows(0)("nombres").ToString)
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
            MessageBox.Show("El Usuario o la Clave ingresada, no es la correcta." & vbCrLf & "Intente nuevamente...", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            txtUsuario.Focus()
            txtUsuario.SelectAll()
            panelLoad.Location = New Point(Me.Width, 0)
            btnIngresar.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'fondoPantalla = My.Resources.fondo_login
        frmEleccionEmpresa.Show()
        Me.Dispose()
    End Sub
End Class