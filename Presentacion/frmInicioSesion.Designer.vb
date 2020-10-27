<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicioSesion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicioSesion))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblPie = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panelLoad = New System.Windows.Forms.Panel()
        Me.lblLoad = New System.Windows.Forms.Label()
        Me.pbLoad = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelLoad.SuspendLayout()
        CType(Me.pbLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Presentacion.My.Resources.Resources.logo_ticom
        Me.PictureBox2.Location = New System.Drawing.Point(693, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(180, 101)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BtnMinimizar.FlatAppearance.BorderSize = 0
        Me.BtnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BtnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMinimizar.ForeColor = System.Drawing.Color.White
        Me.BtnMinimizar.Location = New System.Drawing.Point(900, 20)
        Me.BtnMinimizar.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.BtnMinimizar.TabIndex = 14
        Me.BtnMinimizar.Tag = "Minimizar"
        Me.BtnMinimizar.Text = "-"
        Me.BtnMinimizar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(940, 20)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 15
        Me.btnCerrar.Tag = ""
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'txtClave
        '
        Me.txtClave.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClave.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.ForeColor = System.Drawing.Color.Black
        Me.txtClave.Location = New System.Drawing.Point(577, 483)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(124, 24)
        Me.txtClave.TabIndex = 11
        Me.txtClave.Text = "123456"
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.Transparent
        Me.btnIngresar.BackgroundImage = Global.Presentacion.My.Resources.Resources.btn_login
        Me.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngresar.FlatAppearance.BorderSize = 0
        Me.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.Location = New System.Drawing.Point(725, 464)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(91, 52)
        Me.btnIngresar.TabIndex = 13
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.Black
        Me.txtUsuario.Location = New System.Drawing.Point(287, 478)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(152, 24)
        Me.txtUsuario.TabIndex = 9
        Me.txtUsuario.Text = "ticom"
        '
        'lblPie
        '
        Me.lblPie.BackColor = System.Drawing.Color.Transparent
        Me.lblPie.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPie.ForeColor = System.Drawing.Color.White
        Me.lblPie.Location = New System.Drawing.Point(26, 672)
        Me.lblPie.Name = "lblPie"
        Me.lblPie.Size = New System.Drawing.Size(951, 18)
        Me.lblPie.TabIndex = 12
        Me.lblPie.Text = "(MODULO CONTABLE - TICOM SOFTWARE V 2.0)          Todos los derechos reservados  " & _
    "        © Ticom Perú - 2015"
        Me.lblPie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 33)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "TICOM CONTABLE"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(100, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 600)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'panelLoad
        '
        Me.panelLoad.BackColor = System.Drawing.Color.Transparent
        Me.panelLoad.Controls.Add(Me.lblLoad)
        Me.panelLoad.Controls.Add(Me.pbLoad)
        Me.panelLoad.Location = New System.Drawing.Point(183, 534)
        Me.panelLoad.Name = "panelLoad"
        Me.panelLoad.Size = New System.Drawing.Size(633, 63)
        Me.panelLoad.TabIndex = 20
        '
        'lblLoad
        '
        Me.lblLoad.AutoSize = True
        Me.lblLoad.BackColor = System.Drawing.Color.Transparent
        Me.lblLoad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoad.ForeColor = System.Drawing.Color.White
        Me.lblLoad.Location = New System.Drawing.Point(182, 24)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(325, 17)
        Me.lblLoad.TabIndex = 11
        Me.lblLoad.Text = "Verificando información. Espere unos momentos."
        '
        'pbLoad
        '
        Me.pbLoad.BackColor = System.Drawing.Color.Transparent
        Me.pbLoad.Image = Global.Presentacion.My.Resources.Resources.load
        Me.pbLoad.Location = New System.Drawing.Point(126, 7)
        Me.pbLoad.Name = "pbLoad"
        Me.pbLoad.Size = New System.Drawing.Size(50, 50)
        Me.pbLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLoad.TabIndex = 10
        Me.pbLoad.TabStop = False
        '
        'frmInicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Presentacion.My.Resources.Resources.fonod_inicio_sesion
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelLoad)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BtnMinimizar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblPie)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInicioSesion"
        Me.Padding = New System.Windows.Forms.Padding(20)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmInicioSesion"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelLoad.ResumeLayout(False)
        Me.panelLoad.PerformLayout()
        CType(Me.pbLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnMinimizar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblPie As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents panelLoad As System.Windows.Forms.Panel
    Friend WithEvents lblLoad As System.Windows.Forms.Label
    Friend WithEvents pbLoad As System.Windows.Forms.PictureBox
End Class
