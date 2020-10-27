<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametrosAsientoCierre
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.operacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.gbGrupo = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvCuentas = New System.Windows.Forms.DataGridView()
        Me.exclusion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contra_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblCuenta2 = New System.Windows.Forms.Label()
        Me.txtCuenta2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.rbSi = New System.Windows.Forms.RadioButton()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.lblCuenta1 = New System.Windows.Forms.Label()
        Me.cboExcluir = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboOperacion = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCuenta1 = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.lblTituloForm = New System.Windows.Forms.Label()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGrupo.SuspendLayout()
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.dgvLista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.descripcion, Me.operacion, Me.estado})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvLista.Location = New System.Drawing.Point(12, 85)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.Size = New System.Drawing.Size(660, 150)
        Me.dgvLista.TabIndex = 204
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 50
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "DESCRIPCION"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 350
        '
        'operacion
        '
        Me.operacion.DataPropertyName = "operacion"
        Me.operacion.HeaderText = "OPERACIÓN"
        Me.operacion.Name = "operacion"
        Me.operacion.ReadOnly = True
        Me.operacion.Width = 120
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "ESTADO"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        Me.estado.Width = 80
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(344, 51)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(78, 30)
        Me.btnBuscar.TabIndex = 206
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label10.Location = New System.Drawing.Point(9, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 16)
        Me.Label10.TabIndex = 208
        Me.Label10.Text = "Dato a buscar:"
        '
        'txtDato
        '
        Me.txtDato.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtDato.Location = New System.Drawing.Point(104, 54)
        Me.txtDato.MaxLength = 1000
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(234, 25)
        Me.txtDato.TabIndex = 0
        '
        'gbGrupo
        '
        Me.gbGrupo.Controls.Add(Me.Label3)
        Me.gbGrupo.Controls.Add(Me.btnAgregar)
        Me.gbGrupo.Controls.Add(Me.dgvCuentas)
        Me.gbGrupo.Controls.Add(Me.lblCuenta2)
        Me.gbGrupo.Controls.Add(Me.txtCuenta2)
        Me.gbGrupo.Controls.Add(Me.Label5)
        Me.gbGrupo.Controls.Add(Me.Label11)
        Me.gbGrupo.Controls.Add(Me.rbSi)
        Me.gbGrupo.Controls.Add(Me.rbNo)
        Me.gbGrupo.Controls.Add(Me.lblCuenta1)
        Me.gbGrupo.Controls.Add(Me.cboExcluir)
        Me.gbGrupo.Controls.Add(Me.Label1)
        Me.gbGrupo.Controls.Add(Me.cboOperacion)
        Me.gbGrupo.Controls.Add(Me.Label2)
        Me.gbGrupo.Controls.Add(Me.txtCuenta1)
        Me.gbGrupo.Controls.Add(Me.Label39)
        Me.gbGrupo.Controls.Add(Me.Label4)
        Me.gbGrupo.Controls.Add(Me.txtDescripcion)
        Me.gbGrupo.Enabled = False
        Me.gbGrupo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGrupo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.gbGrupo.Location = New System.Drawing.Point(12, 241)
        Me.gbGrupo.Name = "gbGrupo"
        Me.gbGrupo.Size = New System.Drawing.Size(660, 212)
        Me.gbGrupo.TabIndex = 3
        Me.gbGrupo.TabStop = False
        Me.gbGrupo.Text = "Datos de registros"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(370, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(218, 19)
        Me.Label3.TabIndex = 330
        Me.Label3.Text = "Cuentas contables anexadas:"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(285, 176)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(80, 30)
        Me.btnAgregar.TabIndex = 329
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'dgvCuentas
        '
        Me.dgvCuentas.AllowUserToAddRows = False
        Me.dgvCuentas.AllowUserToOrderColumns = True
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.dgvCuentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCuentas.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCuentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.exclusion, Me.cuenta, Me.contra_cuenta})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCuentas.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvCuentas.Location = New System.Drawing.Point(374, 86)
        Me.dgvCuentas.Name = "dgvCuentas"
        Me.dgvCuentas.Size = New System.Drawing.Size(280, 120)
        Me.dgvCuentas.TabIndex = 328
        '
        'exclusion
        '
        Me.exclusion.DataPropertyName = "exclusion"
        Me.exclusion.HeaderText = "EXCLUSIÓN"
        Me.exclusion.Name = "exclusion"
        Me.exclusion.Width = 80
        '
        'cuenta
        '
        Me.cuenta.DataPropertyName = "cuenta"
        Me.cuenta.HeaderText = "CTA 1"
        Me.cuenta.Name = "cuenta"
        Me.cuenta.Width = 70
        '
        'contra_cuenta
        '
        Me.contra_cuenta.DataPropertyName = "contra_cuenta"
        Me.contra_cuenta.HeaderText = "CTA 2"
        Me.contra_cuenta.Name = "contra_cuenta"
        Me.contra_cuenta.Width = 70
        '
        'lblCuenta2
        '
        Me.lblCuenta2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCuenta2.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblCuenta2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblCuenta2.Location = New System.Drawing.Point(92, 138)
        Me.lblCuenta2.Name = "lblCuenta2"
        Me.lblCuenta2.Size = New System.Drawing.Size(273, 18)
        Me.lblCuenta2.TabIndex = 327
        Me.lblCuenta2.Text = "CUENTA"
        '
        'txtCuenta2
        '
        Me.txtCuenta2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuenta2.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtCuenta2.Location = New System.Drawing.Point(6, 134)
        Me.txtCuenta2.Name = "txtCuenta2"
        Me.txtCuenta2.Size = New System.Drawing.Size(80, 24)
        Me.txtCuenta2.TabIndex = 325
        Me.txtCuenta2.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(2, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 19)
        Me.Label5.TabIndex = 326
        Me.Label5.Text = "Contra Cuenta:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(3, 166)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(154, 17)
        Me.Label11.TabIndex = 322
        Me.Label11.Text = "Estado del parametro:"
        '
        'rbSi
        '
        Me.rbSi.AutoSize = True
        Me.rbSi.Checked = True
        Me.rbSi.Location = New System.Drawing.Point(6, 186)
        Me.rbSi.Name = "rbSi"
        Me.rbSi.Size = New System.Drawing.Size(61, 20)
        Me.rbSi.TabIndex = 323
        Me.rbSi.TabStop = True
        Me.rbSi.Text = "Activo"
        Me.rbSi.UseVisualStyleBackColor = True
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Location = New System.Drawing.Point(73, 186)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(72, 20)
        Me.rbNo.TabIndex = 324
        Me.rbNo.Text = "Inactivo"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'lblCuenta1
        '
        Me.lblCuenta1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCuenta1.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblCuenta1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblCuenta1.Location = New System.Drawing.Point(94, 90)
        Me.lblCuenta1.Name = "lblCuenta1"
        Me.lblCuenta1.Size = New System.Drawing.Size(271, 18)
        Me.lblCuenta1.TabIndex = 318
        Me.lblCuenta1.Text = "CUENTA"
        '
        'cboExcluir
        '
        Me.cboExcluir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExcluir.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.cboExcluir.FormattingEnabled = True
        Me.cboExcluir.Location = New System.Drawing.Point(582, 36)
        Me.cboExcluir.Name = "cboExcluir"
        Me.cboExcluir.Size = New System.Drawing.Size(72, 25)
        Me.cboExcluir.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(578, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 19)
        Me.Label1.TabIndex = 237
        Me.Label1.Text = "Excluir:"
        '
        'cboOperacion
        '
        Me.cboOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOperacion.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.cboOperacion.FormattingEnabled = True
        Me.cboOperacion.Location = New System.Drawing.Point(374, 36)
        Me.cboOperacion.Name = "cboOperacion"
        Me.cboOperacion.Size = New System.Drawing.Size(202, 25)
        Me.cboOperacion.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(370, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 19)
        Me.Label2.TabIndex = 230
        Me.Label2.Text = "Operación:"
        '
        'txtCuenta1
        '
        Me.txtCuenta1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuenta1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtCuenta1.Location = New System.Drawing.Point(6, 86)
        Me.txtCuenta1.Name = "txtCuenta1"
        Me.txtCuenta1.Size = New System.Drawing.Size(80, 24)
        Me.txtCuenta1.TabIndex = 4
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label39.Location = New System.Drawing.Point(2, 65)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(66, 19)
        Me.Label39.TabIndex = 229
        Me.Label39.Text = "Cuenta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(2, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 19)
        Me.Label4.TabIndex = 231
        Me.Label4.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtDescripcion.Location = New System.Drawing.Point(6, 37)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(359, 24)
        Me.txtDescripcion.TabIndex = 2
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(526, 459)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(146, 30)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar cambios"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(414, 459)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(106, 30)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Green
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(594, 51)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(78, 30)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(493, 51)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(95, 30)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'lblTituloForm
        '
        Me.lblTituloForm.AutoSize = True
        Me.lblTituloForm.BackColor = System.Drawing.Color.Transparent
        Me.lblTituloForm.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.lblTituloForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblTituloForm.Location = New System.Drawing.Point(-5, -2)
        Me.lblTituloForm.Name = "lblTituloForm"
        Me.lblTituloForm.Padding = New System.Windows.Forms.Padding(10)
        Me.lblTituloForm.Size = New System.Drawing.Size(456, 53)
        Me.lblTituloForm.TabIndex = 212
        Me.lblTituloForm.Text = "PARAMETROS ASIENTO DE CIERRE"
        '
        'frmParametrosAsientoCierre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 501)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblTituloForm)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDato)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dgvLista)
        Me.Controls.Add(Me.gbGrupo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmParametrosAsientoCierre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ASIENTOS DE CIERRE"
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGrupo.ResumeLayout(False)
        Me.gbGrupo.PerformLayout()
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDato As System.Windows.Forms.TextBox
    Friend WithEvents gbGrupo As System.Windows.Forms.GroupBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents lblTituloForm As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents cboOperacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCuenta1 As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents cboExcluir As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCuenta1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents rbSi As System.Windows.Forms.RadioButton
    Friend WithEvents rbNo As System.Windows.Forms.RadioButton
    Friend WithEvents lblCuenta2 As System.Windows.Forms.Label
    Friend WithEvents txtCuenta2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvCuentas As System.Windows.Forms.DataGridView
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents operacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents exclusion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contra_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
