<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTsClientes
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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ruc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.gbGrupo = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cboDistrito = New System.Windows.Forms.ComboBox()
        Me.cboProvincia = New System.Windows.Forms.ComboBox()
        Me.dtpFechaNacimento = New System.Windows.Forms.DateTimePicker()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cboDepartamento = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.rbSi = New System.Windows.Forms.RadioButton()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtApePaterno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtNomComercial = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtApeMaterno = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.lblTituloForm = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCorreos = New System.Windows.Forms.TextBox()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGrupo.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToOrderColumns = True
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.dgvLista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.dni, Me.nombre, Me.ruc, Me.direccion, Me.estado})
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvLista.Location = New System.Drawing.Point(12, 99)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.Size = New System.Drawing.Size(833, 213)
        Me.dgvLista.TabIndex = 204
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'dni
        '
        Me.dni.DataPropertyName = "dni"
        Me.dni.HeaderText = "DNI"
        Me.dni.Name = "dni"
        Me.dni.ReadOnly = True
        Me.dni.Width = 85
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombres"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 230
        '
        'ruc
        '
        Me.ruc.DataPropertyName = "ruc"
        Me.ruc.HeaderText = "RUC"
        Me.ruc.Name = "ruc"
        Me.ruc.ReadOnly = True
        Me.ruc.Width = 85
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.HeaderText = "Direccion"
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        Me.direccion.Width = 270
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(344, 63)
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
        Me.Label10.Location = New System.Drawing.Point(9, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 16)
        Me.Label10.TabIndex = 208
        Me.Label10.Text = "Dato a buscar:"
        '
        'txtDato
        '
        Me.txtDato.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtDato.Location = New System.Drawing.Point(104, 66)
        Me.txtDato.MaxLength = 1000
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(234, 25)
        Me.txtDato.TabIndex = 207
        '
        'gbGrupo
        '
        Me.gbGrupo.Controls.Add(Me.Label1)
        Me.gbGrupo.Controls.Add(Me.txtCorreos)
        Me.gbGrupo.Controls.Add(Me.Label26)
        Me.gbGrupo.Controls.Add(Me.cboDistrito)
        Me.gbGrupo.Controls.Add(Me.cboProvincia)
        Me.gbGrupo.Controls.Add(Me.dtpFechaNacimento)
        Me.gbGrupo.Controls.Add(Me.Label24)
        Me.gbGrupo.Controls.Add(Me.cboDepartamento)
        Me.gbGrupo.Controls.Add(Me.Label12)
        Me.gbGrupo.Controls.Add(Me.Label2)
        Me.gbGrupo.Controls.Add(Me.Label38)
        Me.gbGrupo.Controls.Add(Me.Label7)
        Me.gbGrupo.Controls.Add(Me.Label11)
        Me.gbGrupo.Controls.Add(Me.txtCelular)
        Me.gbGrupo.Controls.Add(Me.rbSi)
        Me.gbGrupo.Controls.Add(Me.rbNo)
        Me.gbGrupo.Controls.Add(Me.Label6)
        Me.gbGrupo.Controls.Add(Me.txtDireccion)
        Me.gbGrupo.Controls.Add(Me.txtTelefono)
        Me.gbGrupo.Controls.Add(Me.Label41)
        Me.gbGrupo.Controls.Add(Me.txtApePaterno)
        Me.gbGrupo.Controls.Add(Me.Label3)
        Me.gbGrupo.Controls.Add(Me.Label39)
        Me.gbGrupo.Controls.Add(Me.txtNomComercial)
        Me.gbGrupo.Controls.Add(Me.Label37)
        Me.gbGrupo.Controls.Add(Me.Label4)
        Me.gbGrupo.Controls.Add(Me.Label32)
        Me.gbGrupo.Controls.Add(Me.txtRuc)
        Me.gbGrupo.Controls.Add(Me.txtDni)
        Me.gbGrupo.Controls.Add(Me.Label5)
        Me.gbGrupo.Controls.Add(Me.Label42)
        Me.gbGrupo.Controls.Add(Me.Label8)
        Me.gbGrupo.Controls.Add(Me.txtApeMaterno)
        Me.gbGrupo.Controls.Add(Me.txtNombre)
        Me.gbGrupo.Controls.Add(Me.txtRazonSocial)
        Me.gbGrupo.Controls.Add(Me.btnGuardar)
        Me.gbGrupo.Controls.Add(Me.btnCancelar)
        Me.gbGrupo.Enabled = False
        Me.gbGrupo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGrupo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.gbGrupo.Location = New System.Drawing.Point(1, 318)
        Me.gbGrupo.Name = "gbGrupo"
        Me.gbGrupo.Size = New System.Drawing.Size(844, 331)
        Me.gbGrupo.TabIndex = 209
        Me.gbGrupo.TabStop = False
        Me.gbGrupo.Text = "Datos de registros"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(556, 164)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(53, 19)
        Me.Label26.TabIndex = 238
        Me.Label26.Text = "Distrito"
        '
        'cboDistrito
        '
        Me.cboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDistrito.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.cboDistrito.FormattingEnabled = True
        Me.cboDistrito.Location = New System.Drawing.Point(560, 186)
        Me.cboDistrito.Name = "cboDistrito"
        Me.cboDistrito.Size = New System.Drawing.Size(267, 25)
        Me.cboDistrito.TabIndex = 225
        '
        'cboProvincia
        '
        Me.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProvincia.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.cboProvincia.FormattingEnabled = True
        Me.cboProvincia.Location = New System.Drawing.Point(257, 186)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(297, 25)
        Me.cboProvincia.TabIndex = 224
        '
        'dtpFechaNacimento
        '
        Me.dtpFechaNacimento.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.dtpFechaNacimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimento.Location = New System.Drawing.Point(612, 88)
        Me.dtpFechaNacimento.Name = "dtpFechaNacimento"
        Me.dtpFechaNacimento.Size = New System.Drawing.Size(105, 24)
        Me.dtpFechaNacimento.TabIndex = 219
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(252, 164)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 19)
        Me.Label24.TabIndex = 234
        Me.Label24.Text = "Provincia"
        '
        'cboDepartamento
        '
        Me.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartamento.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.cboDepartamento.FormattingEnabled = True
        Me.cboDepartamento.Location = New System.Drawing.Point(10, 186)
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.Size = New System.Drawing.Size(241, 25)
        Me.cboDepartamento.TabIndex = 223
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(38, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 19)
        Me.Label12.TabIndex = 242
        Me.Label12.Text = "(*)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 19)
        Me.Label2.TabIndex = 230
        Me.Label2.Text = "Departamento"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label38.Location = New System.Drawing.Point(608, 66)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(160, 19)
        Me.Label38.TabIndex = 227
        Me.Label38.Text = "Fecha de Nacimiento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(6, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 19)
        Me.Label7.TabIndex = 235
        Me.Label7.Text = "Dirección"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(557, 216)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 17)
        Me.Label11.TabIndex = 170
        Me.Label11.Text = "Estado del registro:"
        '
        'txtCelular
        '
        Me.txtCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCelular.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtCelular.Location = New System.Drawing.Point(256, 88)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(350, 24)
        Me.txtCelular.TabIndex = 218
        '
        'rbSi
        '
        Me.rbSi.AutoSize = True
        Me.rbSi.Checked = True
        Me.rbSi.Location = New System.Drawing.Point(560, 236)
        Me.rbSi.Name = "rbSi"
        Me.rbSi.Size = New System.Drawing.Size(61, 20)
        Me.rbSi.TabIndex = 208
        Me.rbSi.TabStop = True
        Me.rbSi.Text = "Activo"
        Me.rbSi.UseVisualStyleBackColor = True
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Location = New System.Drawing.Point(683, 236)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(72, 20)
        Me.rbNo.TabIndex = 209
        Me.rbNo.Text = "Inactivo"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(221, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 19)
        Me.Label6.TabIndex = 241
        Me.Label6.Text = "(*)"
        '
        'txtDireccion
        '
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtDireccion.Location = New System.Drawing.Point(10, 236)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(544, 87)
        Me.txtDireccion.TabIndex = 226
        '
        'txtTelefono
        '
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefono.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtTelefono.Location = New System.Drawing.Point(10, 88)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(240, 24)
        Me.txtTelefono.TabIndex = 217
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label41.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label41.Location = New System.Drawing.Point(252, 66)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(72, 19)
        Me.Label41.TabIndex = 233
        Me.Label41.Text = "Celulares"
        '
        'txtApePaterno
        '
        Me.txtApePaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApePaterno.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtApePaterno.Location = New System.Drawing.Point(391, 39)
        Me.txtApePaterno.Name = "txtApePaterno"
        Me.txtApePaterno.Size = New System.Drawing.Size(215, 24)
        Me.txtApePaterno.TabIndex = 214
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(6, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 19)
        Me.Label3.TabIndex = 228
        Me.Label3.Text = "Razon Social"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label39.Location = New System.Drawing.Point(6, 66)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(71, 19)
        Me.Label39.TabIndex = 229
        Me.Label39.Text = "Telefonos"
        '
        'txtNomComercial
        '
        Me.txtNomComercial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomComercial.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtNomComercial.Location = New System.Drawing.Point(235, 137)
        Me.txtNomComercial.Name = "txtNomComercial"
        Me.txtNomComercial.Size = New System.Drawing.Size(224, 24)
        Me.txtNomComercial.TabIndex = 221
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label37.Location = New System.Drawing.Point(461, 115)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(38, 19)
        Me.Label37.TabIndex = 236
        Me.Label37.Text = "RUC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(160, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 19)
        Me.Label4.TabIndex = 231
        Me.Label4.Text = "Nombres"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(231, 115)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(139, 19)
        Me.Label32.TabIndex = 240
        Me.Label32.Text = "Nombre Comercial"
        '
        'txtRuc
        '
        Me.txtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRuc.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtRuc.Location = New System.Drawing.Point(465, 137)
        Me.txtRuc.MaxLength = 11
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(141, 24)
        Me.txtRuc.TabIndex = 222
        Me.txtRuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDni
        '
        Me.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDni.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtDni.Location = New System.Drawing.Point(10, 39)
        Me.txtDni.MaxLength = 8
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(148, 24)
        Me.txtDni.TabIndex = 216
        Me.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(387, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 19)
        Me.Label5.TabIndex = 232
        Me.Label5.Text = "Apellido Paterno"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label42.Location = New System.Drawing.Point(6, 17)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(32, 19)
        Me.Label42.TabIndex = 239
        Me.Label42.Text = "DNI"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(608, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 19)
        Me.Label8.TabIndex = 237
        Me.Label8.Text = "Apellido Materno"
        '
        'txtApeMaterno
        '
        Me.txtApeMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApeMaterno.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtApeMaterno.Location = New System.Drawing.Point(612, 39)
        Me.txtApeMaterno.Name = "txtApeMaterno"
        Me.txtApeMaterno.Size = New System.Drawing.Size(215, 24)
        Me.txtApeMaterno.TabIndex = 215
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtNombre.Location = New System.Drawing.Point(164, 39)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(221, 24)
        Me.txtNombre.TabIndex = 213
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRazonSocial.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtRazonSocial.Location = New System.Drawing.Point(10, 137)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(219, 24)
        Me.txtRazonSocial.TabIndex = 220
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(681, 293)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(146, 30)
        Me.btnGuardar.TabIndex = 211
        Me.btnGuardar.Text = "Guardar cambios"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(569, 293)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(106, 30)
        Me.btnCancelar.TabIndex = 212
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(767, 63)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(78, 30)
        Me.btnNuevo.TabIndex = 210
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(666, 63)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(95, 30)
        Me.btnModificar.TabIndex = 211
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
        Me.lblTituloForm.Size = New System.Drawing.Size(141, 53)
        Me.lblTituloForm.TabIndex = 212
        Me.lblTituloForm.Text = "Clientes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(608, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 19)
        Me.Label1.TabIndex = 244
        Me.Label1.Text = "Correos"
        '
        'txtCorreos
        '
        Me.txtCorreos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCorreos.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtCorreos.Location = New System.Drawing.Point(612, 137)
        Me.txtCorreos.Name = "txtCorreos"
        Me.txtCorreos.Size = New System.Drawing.Size(215, 24)
        Me.txtCorreos.TabIndex = 243
        '
        'frmTsClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(857, 661)
        Me.Controls.Add(Me.lblTituloForm)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.gbGrupo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDato)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dgvLista)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmTsClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGrupo.ResumeLayout(False)
        Me.gbGrupo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDato As System.Windows.Forms.TextBox
    Friend WithEvents gbGrupo As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents rbNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbSi As System.Windows.Forms.RadioButton
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents lblTituloForm As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cboDistrito As System.Windows.Forms.ComboBox
    Friend WithEvents cboProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFechaNacimento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cboDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtApePaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtNomComercial As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtApeMaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ruc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCorreos As System.Windows.Forms.TextBox
End Class
