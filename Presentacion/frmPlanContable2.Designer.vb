<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlanContable2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGenerarTxt = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.BtnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.gbParametros = New System.Windows.Forms.GroupBox()
        Me.rbSi = New System.Windows.Forms.RadioButton()
        Me.chkCC = New System.Windows.Forms.CheckBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.gbCuenta10 = New System.Windows.Forms.GroupBox()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboBanco = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCorriente = New System.Windows.Forms.TextBox()
        Me.txtNroCuenta = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtHaber = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDebe = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboAnalisis = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboTipoCuenta = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboNivelCuenta = New System.Windows.Forms.ComboBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEqSunat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nivel_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenta_debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenta_haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTituloForm = New System.Windows.Forms.Label()
        Me.gbParametros.SuspendLayout()
        Me.gbCuenta10.SuspendLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(465, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 229
        Me.Button1.Text = "Generar Diario"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnGenerarTxt
        '
        Me.btnGenerarTxt.Location = New System.Drawing.Point(669, 48)
        Me.btnGenerarTxt.Name = "btnGenerarTxt"
        Me.btnGenerarTxt.Size = New System.Drawing.Size(96, 23)
        Me.btnGenerarTxt.TabIndex = 228
        Me.btnGenerarTxt.Text = "Generar TXT"
        Me.btnGenerarTxt.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(567, 48)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(96, 23)
        Me.btnExcel.TabIndex = 227
        Me.btnExcel.Text = "Generar Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BtnMinimizar.FlatAppearance.BorderSize = 0
        Me.BtnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.BtnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMinimizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.BtnMinimizar.Location = New System.Drawing.Point(889, 9)
        Me.BtnMinimizar.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.BtnMinimizar.TabIndex = 225
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
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCerrar.Location = New System.Drawing.Point(929, 9)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 226
        Me.btnCerrar.Tag = ""
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(661, 91)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnNuevo.Size = New System.Drawing.Size(140, 35)
        Me.btnNuevo.TabIndex = 224
        Me.btnNuevo.Text = "Nueva cuenta"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(807, 91)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnModificar.Size = New System.Drawing.Size(161, 35)
        Me.btnModificar.TabIndex = 223
        Me.btnModificar.Text = "Modificar cuenta"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'gbParametros
        '
        Me.gbParametros.BackColor = System.Drawing.Color.Transparent
        Me.gbParametros.Controls.Add(Me.rbSi)
        Me.gbParametros.Controls.Add(Me.chkCC)
        Me.gbParametros.Controls.Add(Me.btnCancelar)
        Me.gbParametros.Controls.Add(Me.rbNo)
        Me.gbParametros.Controls.Add(Me.btnGuardar)
        Me.gbParametros.Controls.Add(Me.gbCuenta10)
        Me.gbParametros.Controls.Add(Me.txtNroCuenta)
        Me.gbParametros.Controls.Add(Me.Label12)
        Me.gbParametros.Controls.Add(Me.txtHaber)
        Me.gbParametros.Controls.Add(Me.Label8)
        Me.gbParametros.Controls.Add(Me.txtDebe)
        Me.gbParametros.Controls.Add(Me.Label7)
        Me.gbParametros.Controls.Add(Me.cboAnalisis)
        Me.gbParametros.Controls.Add(Me.Label4)
        Me.gbParametros.Controls.Add(Me.cboTipoCuenta)
        Me.gbParametros.Controls.Add(Me.Label3)
        Me.gbParametros.Controls.Add(Me.cboNivelCuenta)
        Me.gbParametros.Controls.Add(Me.txtNombre)
        Me.gbParametros.Controls.Add(Me.Label1)
        Me.gbParametros.Controls.Add(Me.Label17)
        Me.gbParametros.Controls.Add(Me.Label6)
        Me.gbParametros.Controls.Add(Me.txtEqSunat)
        Me.gbParametros.Controls.Add(Me.Label2)
        Me.gbParametros.Enabled = False
        Me.gbParametros.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.gbParametros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.gbParametros.Location = New System.Drawing.Point(29, 370)
        Me.gbParametros.Name = "gbParametros"
        Me.gbParametros.Size = New System.Drawing.Size(940, 255)
        Me.gbParametros.TabIndex = 222
        Me.gbParametros.TabStop = False
        Me.gbParametros.Text = "Parametros de relación"
        '
        'rbSi
        '
        Me.rbSi.AutoSize = True
        Me.rbSi.Location = New System.Drawing.Point(64, 173)
        Me.rbSi.Name = "rbSi"
        Me.rbSi.Size = New System.Drawing.Size(39, 25)
        Me.rbSi.TabIndex = 193
        Me.rbSi.Text = "Si"
        Me.rbSi.UseVisualStyleBackColor = True
        '
        'chkCC
        '
        Me.chkCC.AutoSize = True
        Me.chkCC.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.chkCC.Location = New System.Drawing.Point(120, 176)
        Me.chkCC.Name = "chkCC"
        Me.chkCC.Size = New System.Drawing.Size(141, 23)
        Me.chkCC.TabIndex = 197
        Me.chkCC.Text = "Centro de Costo"
        Me.chkCC.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(512, 214)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnCancelar.Size = New System.Drawing.Size(104, 35)
        Me.btnCancelar.TabIndex = 195
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Checked = True
        Me.rbNo.Location = New System.Drawing.Point(17, 173)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(50, 25)
        Me.rbNo.TabIndex = 194
        Me.rbNo.TabStop = True
        Me.rbNo.Text = "No"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(345, 214)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnGuardar.Size = New System.Drawing.Size(161, 35)
        Me.btnGuardar.TabIndex = 192
        Me.btnGuardar.Text = "Guardar cambios"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'gbCuenta10
        '
        Me.gbCuenta10.Controls.Add(Me.cboMoneda)
        Me.gbCuenta10.Controls.Add(Me.Label11)
        Me.gbCuenta10.Controls.Add(Me.Label10)
        Me.gbCuenta10.Controls.Add(Me.cboBanco)
        Me.gbCuenta10.Controls.Add(Me.Label9)
        Me.gbCuenta10.Controls.Add(Me.txtCorriente)
        Me.gbCuenta10.Enabled = False
        Me.gbCuenta10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.gbCuenta10.Location = New System.Drawing.Point(632, 26)
        Me.gbCuenta10.Name = "gbCuenta10"
        Me.gbCuenta10.Size = New System.Drawing.Size(290, 187)
        Me.gbCuenta10.TabIndex = 175
        Me.gbCuenta10.TabStop = False
        Me.gbCuenta10.Text = "Sólo para la cuenta 10"
        '
        'cboMoneda
        '
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(19, 154)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(252, 25)
        Me.cboMoneda.TabIndex = 171
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label11.Location = New System.Drawing.Point(19, 134)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 17)
        Me.Label11.TabIndex = 170
        Me.Label11.Text = "Moneda:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(19, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 17)
        Me.Label10.TabIndex = 169
        Me.Label10.Text = "Cuenta corriente:"
        '
        'cboBanco
        '
        Me.cboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBanco.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBanco.FormattingEnabled = True
        Me.cboBanco.Location = New System.Drawing.Point(19, 48)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Size = New System.Drawing.Size(252, 25)
        Me.cboBanco.TabIndex = 167
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label9.Location = New System.Drawing.Point(19, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 17)
        Me.Label9.TabIndex = 166
        Me.Label9.Text = "Banco:"
        '
        'txtCorriente
        '
        Me.txtCorriente.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtCorriente.Location = New System.Drawing.Point(19, 103)
        Me.txtCorriente.MaxLength = 1000
        Me.txtCorriente.Name = "txtCorriente"
        Me.txtCorriente.Size = New System.Drawing.Size(252, 25)
        Me.txtCorriente.TabIndex = 168
        Me.txtCorriente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNroCuenta
        '
        Me.txtNroCuenta.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtNroCuenta.Location = New System.Drawing.Point(17, 53)
        Me.txtNroCuenta.MaxLength = 10
        Me.txtNroCuenta.Name = "txtNroCuenta"
        Me.txtNroCuenta.Size = New System.Drawing.Size(137, 25)
        Me.txtNroCuenta.TabIndex = 172
        Me.txtNroCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label12.Location = New System.Drawing.Point(13, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 17)
        Me.Label12.TabIndex = 173
        Me.Label12.Text = "N° de Cuenta:"
        '
        'txtHaber
        '
        Me.txtHaber.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtHaber.Location = New System.Drawing.Point(517, 172)
        Me.txtHaber.MaxLength = 10
        Me.txtHaber.Name = "txtHaber"
        Me.txtHaber.Size = New System.Drawing.Size(99, 25)
        Me.txtHaber.TabIndex = 164
        Me.txtHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(514, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 17)
        Me.Label8.TabIndex = 165
        Me.Label8.Text = "Amarre Haber:"
        '
        'txtDebe
        '
        Me.txtDebe.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtDebe.Location = New System.Drawing.Point(416, 172)
        Me.txtDebe.MaxLength = 10
        Me.txtDebe.Name = "txtDebe"
        Me.txtDebe.Size = New System.Drawing.Size(95, 25)
        Me.txtDebe.TabIndex = 162
        Me.txtDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(413, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 17)
        Me.Label7.TabIndex = 163
        Me.Label7.Text = "Amarre Debe:"
        '
        'cboAnalisis
        '
        Me.cboAnalisis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAnalisis.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnalisis.FormattingEnabled = True
        Me.cboAnalisis.Location = New System.Drawing.Point(267, 172)
        Me.cboAnalisis.Name = "cboAnalisis"
        Me.cboAnalisis.Size = New System.Drawing.Size(143, 25)
        Me.cboAnalisis.TabIndex = 161
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(264, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 17)
        Me.Label4.TabIndex = 160
        Me.Label4.Text = "Tipo de análisis:"
        '
        'cboTipoCuenta
        '
        Me.cboTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoCuenta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoCuenta.FormattingEnabled = True
        Me.cboTipoCuenta.Location = New System.Drawing.Point(393, 112)
        Me.cboTipoCuenta.Name = "cboTipoCuenta"
        Me.cboTipoCuenta.Size = New System.Drawing.Size(223, 25)
        Me.cboTipoCuenta.TabIndex = 159
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(390, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 17)
        Me.Label3.TabIndex = 158
        Me.Label3.Text = "Tipo de cuenta:"
        '
        'cboNivelCuenta
        '
        Me.cboNivelCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNivelCuenta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNivelCuenta.FormattingEnabled = True
        Me.cboNivelCuenta.Location = New System.Drawing.Point(169, 112)
        Me.cboNivelCuenta.Name = "cboNivelCuenta"
        Me.cboNivelCuenta.Size = New System.Drawing.Size(205, 25)
        Me.cboNivelCuenta.TabIndex = 157
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtNombre.Location = New System.Drawing.Point(169, 53)
        Me.txtNombre.MaxLength = 1000
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(447, 25)
        Me.txtNombre.TabIndex = 156
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(14, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "Balances"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label17.Location = New System.Drawing.Point(166, 92)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(115, 17)
        Me.Label17.TabIndex = 129
        Me.Label17.Text = "Nivel de cuenta:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(166, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 17)
        Me.Label6.TabIndex = 126
        Me.Label6.Text = "Descripción:"
        '
        'txtEqSunat
        '
        Me.txtEqSunat.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtEqSunat.Location = New System.Drawing.Point(17, 112)
        Me.txtEqSunat.MaxLength = 10
        Me.txtEqSunat.Name = "txtEqSunat"
        Me.txtEqSunat.Size = New System.Drawing.Size(137, 25)
        Me.txtEqSunat.TabIndex = 2
        Me.txtEqSunat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(13, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 17)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Cta. equiv. en Sunat"
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Location = New System.Drawing.Point(364, 91)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(150, 35)
        Me.btnActualizar.TabIndex = 221
        Me.btnActualizar.Text = "Actualizar cuentas"
        Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'txtDato
        '
        Me.txtDato.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtDato.Location = New System.Drawing.Point(29, 96)
        Me.txtDato.MaxLength = 7
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(240, 25)
        Me.txtDato.TabIndex = 220
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarProducto.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnBuscarProducto.ForeColor = System.Drawing.Color.White
        Me.btnBuscarProducto.Location = New System.Drawing.Point(275, 91)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnBuscarProducto.Size = New System.Drawing.Size(83, 35)
        Me.btnBuscarProducto.TabIndex = 219
        Me.btnBuscarProducto.Text = "Buscar"
        Me.btnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarProducto.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(26, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 17)
        Me.Label5.TabIndex = 218
        Me.Label5.Text = "N° de Cuenta:"
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToOrderColumns = True
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.sub_id, Me.nombre, Me.nivel_cuenta, Me.tipo_cuenta, Me.cuenta_debe, Me.cuenta_haber, Me.estado})
        Me.dgvLista.Location = New System.Drawing.Point(29, 134)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.Size = New System.Drawing.Size(939, 230)
        Me.dgvLista.TabIndex = 217
        '
        'id
        '
        Me.id.DataPropertyName = "num_cuenta"
        Me.id.HeaderText = "N° Cuenta"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'sub_id
        '
        Me.sub_id.DataPropertyName = "sub_id"
        Me.sub_id.HeaderText = "sub_id"
        Me.sub_id.Name = "sub_id"
        Me.sub_id.ReadOnly = True
        Me.sub_id.Visible = False
        Me.sub_id.Width = 50
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nom_cuenta"
        Me.nombre.HeaderText = "Descripción"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 300
        '
        'nivel_cuenta
        '
        Me.nivel_cuenta.DataPropertyName = "nivel_cuenta"
        Me.nivel_cuenta.HeaderText = "Nivel Cuenta"
        Me.nivel_cuenta.Name = "nivel_cuenta"
        Me.nivel_cuenta.ReadOnly = True
        Me.nivel_cuenta.Width = 150
        '
        'tipo_cuenta
        '
        Me.tipo_cuenta.DataPropertyName = "tipo_cuenta"
        Me.tipo_cuenta.HeaderText = "Tipo Cuenta"
        Me.tipo_cuenta.Name = "tipo_cuenta"
        Me.tipo_cuenta.ReadOnly = True
        Me.tipo_cuenta.Width = 150
        '
        'cuenta_debe
        '
        Me.cuenta_debe.DataPropertyName = "cuenta_debe"
        Me.cuenta_debe.HeaderText = "Debe"
        Me.cuenta_debe.Name = "cuenta_debe"
        Me.cuenta_debe.ReadOnly = True
        Me.cuenta_debe.Width = 88
        '
        'cuenta_haber
        '
        Me.cuenta_haber.DataPropertyName = "cuenta_haber"
        Me.cuenta_haber.HeaderText = "Haber"
        Me.cuenta_haber.Name = "cuenta_haber"
        Me.cuenta_haber.ReadOnly = True
        Me.cuenta_haber.Width = 88
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "estado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        Me.estado.Visible = False
        '
        'lblTituloForm
        '
        Me.lblTituloForm.AutoSize = True
        Me.lblTituloForm.BackColor = System.Drawing.Color.Transparent
        Me.lblTituloForm.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblTituloForm.Location = New System.Drawing.Point(12, 9)
        Me.lblTituloForm.Name = "lblTituloForm"
        Me.lblTituloForm.Padding = New System.Windows.Forms.Padding(10)
        Me.lblTituloForm.Size = New System.Drawing.Size(315, 62)
        Me.lblTituloForm.TabIndex = 216
        Me.lblTituloForm.Text = "PLAN CONTABLE"
        '
        'frmPlanContable2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 639)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnGenerarTxt)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.BtnMinimizar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.gbParametros)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.txtDato)
        Me.Controls.Add(Me.btnBuscarProducto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvLista)
        Me.Controls.Add(Me.lblTituloForm)
        Me.Name = "frmPlanContable2"
        Me.Text = "frmPlanContable2"
        Me.gbParametros.ResumeLayout(False)
        Me.gbParametros.PerformLayout()
        Me.gbCuenta10.ResumeLayout(False)
        Me.gbCuenta10.PerformLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnGenerarTxt As System.Windows.Forms.Button
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents BtnMinimizar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents gbParametros As System.Windows.Forms.GroupBox
    Friend WithEvents rbSi As System.Windows.Forms.RadioButton
    Friend WithEvents chkCC As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents rbNo As System.Windows.Forms.RadioButton
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents gbCuenta10 As System.Windows.Forms.GroupBox
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboBanco As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCorriente As System.Windows.Forms.TextBox
    Friend WithEvents txtNroCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtHaber As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDebe As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboAnalisis As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboTipoCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboNivelCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEqSunat As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents txtDato As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarProducto As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sub_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nivel_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuenta_debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuenta_haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblTituloForm As System.Windows.Forms.Label
End Class
