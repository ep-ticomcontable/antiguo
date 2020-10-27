<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaPersonal
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cod_dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuspp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ape_paterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ape_materno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fec_ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sueldo_basico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor_asignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.asignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.seguro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.aportaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descuentos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.txtCuspp = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDescuentos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHijos = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalRemuneracion = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtValorAsignacion = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboAsignacion = New System.Windows.Forms.ComboBox()
        Me.cboPension = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboCargo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.MaskedTextBox()
        Me.txtApeMat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApePat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSueldoBasico = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPorcentajePension = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatos.SuspendLayout()
        CType(Me.txtHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(191, 18)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 16)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Nombres:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(449, 18)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 16)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Fec. Ingreso:"
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.cod_dni, Me.cuspp, Me.nombres, Me.ape_paterno, Me.ape_materno, Me.fec_ingreso, Me.cargo, Me.moneda, Me.sueldo_basico, Me.valor_asignacion, Me.asignacion, Me.seguro, Me.aportaciones, Me.descuentos, Me.total})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvLista.Location = New System.Drawing.Point(12, 94)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.Size = New System.Drawing.Size(680, 200)
        Me.dgvLista.TabIndex = 178
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'cod_dni
        '
        Me.cod_dni.DataPropertyName = "cod_dni"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cod_dni.DefaultCellStyle = DataGridViewCellStyle2
        Me.cod_dni.HeaderText = "COD/DNI"
        Me.cod_dni.Name = "cod_dni"
        Me.cod_dni.Width = 70
        '
        'cuspp
        '
        Me.cuspp.DataPropertyName = "cuspp"
        Me.cuspp.HeaderText = "cuspp"
        Me.cuspp.Name = "cuspp"
        Me.cuspp.Visible = False
        '
        'nombres
        '
        Me.nombres.DataPropertyName = "nombres"
        Me.nombres.HeaderText = "NOMBRES"
        Me.nombres.Name = "nombres"
        '
        'ape_paterno
        '
        Me.ape_paterno.DataPropertyName = "ape_pat"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.ape_paterno.DefaultCellStyle = DataGridViewCellStyle3
        Me.ape_paterno.HeaderText = "APE. PAT."
        Me.ape_paterno.Name = "ape_paterno"
        '
        'ape_materno
        '
        Me.ape_materno.DataPropertyName = "ape_mat"
        Me.ape_materno.HeaderText = "APE. MAT."
        Me.ape_materno.Name = "ape_materno"
        '
        'fec_ingreso
        '
        Me.fec_ingreso.DataPropertyName = "fec_ingreso"
        Me.fec_ingreso.HeaderText = "FEC. ING."
        Me.fec_ingreso.Name = "fec_ingreso"
        Me.fec_ingreso.Width = 85
        '
        'cargo
        '
        Me.cargo.DataPropertyName = "cargo"
        Me.cargo.HeaderText = "CARGO/OCUP."
        Me.cargo.Name = "cargo"
        Me.cargo.Width = 150
        '
        'moneda
        '
        Me.moneda.DataPropertyName = "moneda"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.moneda.DefaultCellStyle = DataGridViewCellStyle4
        Me.moneda.HeaderText = "MND"
        Me.moneda.Name = "moneda"
        Me.moneda.Width = 45
        '
        'sueldo_basico
        '
        Me.sueldo_basico.DataPropertyName = "sueldo_basico"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.sueldo_basico.DefaultCellStyle = DataGridViewCellStyle5
        Me.sueldo_basico.HeaderText = "SUELDO"
        Me.sueldo_basico.Name = "sueldo_basico"
        Me.sueldo_basico.Width = 90
        '
        'valor_asignacion
        '
        Me.valor_asignacion.DataPropertyName = "valor_asignacion"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.valor_asignacion.DefaultCellStyle = DataGridViewCellStyle6
        Me.valor_asignacion.HeaderText = "ASG. FAM"
        Me.valor_asignacion.Name = "valor_asignacion"
        Me.valor_asignacion.Width = 90
        '
        'asignacion
        '
        Me.asignacion.DataPropertyName = "asignacion"
        Me.asignacion.HeaderText = "asignacion"
        Me.asignacion.Name = "asignacion"
        Me.asignacion.Visible = False
        '
        'seguro
        '
        Me.seguro.DataPropertyName = "seguro"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.seguro.DefaultCellStyle = DataGridViewCellStyle7
        Me.seguro.HeaderText = "PENSION"
        Me.seguro.Name = "seguro"
        Me.seguro.Width = 70
        '
        'aportaciones
        '
        Me.aportaciones.DataPropertyName = "aportaciones"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = "0.00"
        Me.aportaciones.DefaultCellStyle = DataGridViewCellStyle8
        Me.aportaciones.HeaderText = "SEGURO"
        Me.aportaciones.Name = "aportaciones"
        Me.aportaciones.Width = 90
        '
        'descuentos
        '
        Me.descuentos.DataPropertyName = "descuentos"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.descuentos.DefaultCellStyle = DataGridViewCellStyle9
        Me.descuentos.HeaderText = "DSCTOS"
        Me.descuentos.Name = "descuentos"
        Me.descuentos.Width = 90
        '
        'total
        '
        Me.total.DataPropertyName = "total"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.total.DefaultCellStyle = DataGridViewCellStyle10
        Me.total.HeaderText = "TOTAL"
        Me.total.Name = "total"
        Me.total.Width = 90
        '
        'gbDatos
        '
        Me.gbDatos.Controls.Add(Me.txtCuspp)
        Me.gbDatos.Controls.Add(Me.Label17)
        Me.gbDatos.Controls.Add(Me.cboMoneda)
        Me.gbDatos.Controls.Add(Me.Label16)
        Me.gbDatos.Controls.Add(Me.txtDescuentos)
        Me.gbDatos.Controls.Add(Me.Label6)
        Me.gbDatos.Controls.Add(Me.txtHijos)
        Me.gbDatos.Controls.Add(Me.Label2)
        Me.gbDatos.Controls.Add(Me.txtTotalRemuneracion)
        Me.gbDatos.Controls.Add(Me.Label15)
        Me.gbDatos.Controls.Add(Me.txtValorAsignacion)
        Me.gbDatos.Controls.Add(Me.Label14)
        Me.gbDatos.Controls.Add(Me.cboAsignacion)
        Me.gbDatos.Controls.Add(Me.cboPension)
        Me.gbDatos.Controls.Add(Me.Label10)
        Me.gbDatos.Controls.Add(Me.Label9)
        Me.gbDatos.Controls.Add(Me.cboCargo)
        Me.gbDatos.Controls.Add(Me.Label8)
        Me.gbDatos.Controls.Add(Me.txtFecha)
        Me.gbDatos.Controls.Add(Me.txtApeMat)
        Me.gbDatos.Controls.Add(Me.Label4)
        Me.gbDatos.Controls.Add(Me.txtApePat)
        Me.gbDatos.Controls.Add(Me.Label3)
        Me.gbDatos.Controls.Add(Me.Label11)
        Me.gbDatos.Controls.Add(Me.txtSueldoBasico)
        Me.gbDatos.Controls.Add(Me.Label1)
        Me.gbDatos.Controls.Add(Me.txtNombres)
        Me.gbDatos.Controls.Add(Me.txtDni)
        Me.gbDatos.Controls.Add(Me.Label7)
        Me.gbDatos.Controls.Add(Me.Label13)
        Me.gbDatos.Controls.Add(Me.txtPorcentajePension)
        Me.gbDatos.Controls.Add(Me.Label12)
        Me.gbDatos.Enabled = False
        Me.gbDatos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatos.Location = New System.Drawing.Point(12, 300)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(680, 113)
        Me.gbDatos.TabIndex = 0
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Ingreso de Datos:"
        '
        'txtCuspp
        '
        Me.txtCuspp.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuspp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtCuspp.Location = New System.Drawing.Point(95, 35)
        Me.txtCuspp.MaxLength = 50
        Me.txtCuspp.Name = "txtCuspp"
        Me.txtCuspp.Size = New System.Drawing.Size(93, 21)
        Me.txtCuspp.TabIndex = 1
        Me.txtCuspp.Text = "-"
        Me.txtCuspp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label17.Location = New System.Drawing.Point(92, 18)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 16)
        Me.Label17.TabIndex = 349
        Me.Label17.Text = "CUSPP:"
        '
        'cboMoneda
        '
        Me.cboMoneda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboMoneda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMoneda.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(6, 78)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(51, 23)
        Me.cboMoneda.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(3, 62)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 16)
        Me.Label16.TabIndex = 347
        Me.Label16.Text = "MND:"
        '
        'txtDescuentos
        '
        Me.txtDescuentos.BackColor = System.Drawing.Color.White
        Me.txtDescuentos.Font = New System.Drawing.Font("Century Gothic", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuentos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDescuentos.Location = New System.Drawing.Point(490, 78)
        Me.txtDescuentos.Name = "txtDescuentos"
        Me.txtDescuentos.Size = New System.Drawing.Size(66, 23)
        Me.txtDescuentos.TabIndex = 14
        Me.txtDescuentos.Text = "0.00"
        Me.txtDescuentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(487, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 16)
        Me.Label6.TabIndex = 345
        Me.Label6.Text = "(-) Dsctos:"
        '
        'txtHijos
        '
        Me.txtHijos.Enabled = False
        Me.txtHijos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHijos.Location = New System.Drawing.Point(268, 79)
        Me.txtHijos.Maximum = New Decimal(New Integer() {19, 0, 0, 0})
        Me.txtHijos.Name = "txtHijos"
        Me.txtHijos.Size = New System.Drawing.Size(59, 21)
        Me.txtHijos.TabIndex = 11
        Me.txtHijos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(265, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 342
        Me.Label2.Text = "# de Hijos:"
        '
        'txtTotalRemuneracion
        '
        Me.txtTotalRemuneracion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtTotalRemuneracion.Font = New System.Drawing.Font("Century Gothic", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalRemuneracion.ForeColor = System.Drawing.Color.Black
        Me.txtTotalRemuneracion.Location = New System.Drawing.Point(574, 78)
        Me.txtTotalRemuneracion.Name = "txtTotalRemuneracion"
        Me.txtTotalRemuneracion.ReadOnly = True
        Me.txtTotalRemuneracion.Size = New System.Drawing.Size(100, 23)
        Me.txtTotalRemuneracion.TabIndex = 15
        Me.txtTotalRemuneracion.Text = "0.00"
        Me.txtTotalRemuneracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(571, 63)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 16)
        Me.Label15.TabIndex = 340
        Me.Label15.Text = "Pago Neto:"
        '
        'txtValorAsignacion
        '
        Me.txtValorAsignacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValorAsignacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValorAsignacion.Enabled = False
        Me.txtValorAsignacion.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtValorAsignacion.Location = New System.Drawing.Point(209, 79)
        Me.txtValorAsignacion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtValorAsignacion.Name = "txtValorAsignacion"
        Me.txtValorAsignacion.Size = New System.Drawing.Size(50, 21)
        Me.txtValorAsignacion.TabIndex = 10
        Me.txtValorAsignacion.Text = "1500.00"
        Me.txtValorAsignacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(217, 63)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(25, 16)
        Me.Label14.TabIndex = 338
        Me.Label14.Text = "(+):"
        '
        'cboAsignacion
        '
        Me.cboAsignacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAsignacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAsignacion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAsignacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboAsignacion.FormattingEnabled = True
        Me.cboAsignacion.Location = New System.Drawing.Point(150, 78)
        Me.cboAsignacion.Name = "cboAsignacion"
        Me.cboAsignacion.Size = New System.Drawing.Size(60, 23)
        Me.cboAsignacion.TabIndex = 9
        '
        'cboPension
        '
        Me.cboPension.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPension.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPension.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPension.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboPension.FormattingEnabled = True
        Me.cboPension.Location = New System.Drawing.Point(333, 78)
        Me.cboPension.Name = "cboPension"
        Me.cboPension.Size = New System.Drawing.Size(113, 23)
        Me.cboPension.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(330, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 16)
        Me.Label10.TabIndex = 333
        Me.Label10.Text = "Sistema de Pensión:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(147, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 16)
        Me.Label9.TabIndex = 331
        Me.Label9.Text = "Asig. Fam.:"
        '
        'cboCargo
        '
        Me.cboCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCargo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCargo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboCargo.FormattingEnabled = True
        Me.cboCargo.Location = New System.Drawing.Point(530, 33)
        Me.cboCargo.Name = "cboCargo"
        Me.cboCargo.Size = New System.Drawing.Size(144, 23)
        Me.cboCargo.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(527, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 16)
        Me.Label8.TabIndex = 329
        Me.Label8.Text = "Cargo/Ocupación:"
        '
        'txtFecha
        '
        Me.txtFecha.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtFecha.Location = New System.Drawing.Point(452, 35)
        Me.txtFecha.Mask = "00/00/0000"
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(71, 21)
        Me.txtFecha.TabIndex = 5
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFecha.ValidatingType = GetType(Date)
        '
        'txtApeMat
        '
        Me.txtApeMat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApeMat.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApeMat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtApeMat.Location = New System.Drawing.Point(366, 35)
        Me.txtApeMat.Name = "txtApeMat"
        Me.txtApeMat.Size = New System.Drawing.Size(80, 21)
        Me.txtApeMat.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(363, 18)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 326
        Me.Label4.Text = "Ape. Materno:"
        '
        'txtApePat
        '
        Me.txtApePat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApePat.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApePat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtApePat.Location = New System.Drawing.Point(280, 35)
        Me.txtApePat.Name = "txtApePat"
        Me.txtApePat.Size = New System.Drawing.Size(80, 21)
        Me.txtApePat.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(277, 18)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 324
        Me.Label3.Text = "Ape. Paterno:"
        '
        'txtSueldoBasico
        '
        Me.txtSueldoBasico.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSueldoBasico.Font = New System.Drawing.Font("Century Gothic", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSueldoBasico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtSueldoBasico.Location = New System.Drawing.Point(63, 78)
        Me.txtSueldoBasico.Name = "txtSueldoBasico"
        Me.txtSueldoBasico.Size = New System.Drawing.Size(81, 23)
        Me.txtSueldoBasico.TabIndex = 8
        Me.txtSueldoBasico.Text = "0.00"
        Me.txtSueldoBasico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Sueldo Básico:"
        '
        'txtNombres
        '
        Me.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombres.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtNombres.Location = New System.Drawing.Point(194, 35)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(80, 21)
        Me.txtNombres.TabIndex = 2
        '
        'txtDni
        '
        Me.txtDni.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDni.Location = New System.Drawing.Point(6, 35)
        Me.txtDni.MaxLength = 8
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(83, 21)
        Me.txtDni.TabIndex = 0
        Me.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(3, 18)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "DNI:"
        '
        'txtPorcentajePension
        '
        Me.txtPorcentajePension.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPorcentajePension.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPorcentajePension.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtPorcentajePension.Location = New System.Drawing.Point(445, 79)
        Me.txtPorcentajePension.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPorcentajePension.Name = "txtPorcentajePension"
        Me.txtPorcentajePension.Size = New System.Drawing.Size(40, 21)
        Me.txtPorcentajePension.TabIndex = 13
        Me.txtPorcentajePension.Text = "0.00"
        Me.txtPorcentajePension.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(444, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 16)
        Me.Label12.TabIndex = 336
        Me.Label12.Text = "(-) (%):"
        '
        'btnFinalizar
        '
        Me.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnFinalizar.ForeColor = System.Drawing.Color.White
        Me.btnFinalizar.Location = New System.Drawing.Point(602, 419)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(90, 30)
        Me.btnFinalizar.TabIndex = 4
        Me.btnFinalizar.Text = "FINALIZAR"
        Me.btnFinalizar.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 25.0!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(5, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(406, 40)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "REGISTRO DE PERSONAL"
        '
        'txtBuscar
        '
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(62, 66)
        Me.txtBuscar.MaxLength = 1000
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(278, 22)
        Me.txtBuscar.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(9, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 17)
        Me.Label5.TabIndex = 311
        Me.Label5.Text = "Buscar:"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(346, 63)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(82, 28)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Black
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(12, 419)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(99, 30)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Green
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(602, 62)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(90, 28)
        Me.btnNuevo.TabIndex = 3
        Me.btnNuevo.Text = "NUEVO"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(506, 62)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(90, 28)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'frmListaPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(704, 461)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.gbDatos)
        Me.Controls.Add(Me.dgvLista)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmListaPersonal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Módulo de Registro de Personal"
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        CType(Me.txtHijos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents btnFinalizar As System.Windows.Forms.Button
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSueldoBasico As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents txtApeMat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtApePat As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboCargo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboAsignacion As System.Windows.Forms.ComboBox
    Friend WithEvents cboPension As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPorcentajePension As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtValorAsignacion As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtTotalRemuneracion As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHijos As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtDescuentos As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCuspp As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cod_dni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuspp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ape_paterno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ape_materno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fec_ingreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents moneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sueldo_basico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents valor_asignacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents asignacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents seguro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents aportaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descuentos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
