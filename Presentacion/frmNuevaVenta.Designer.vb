<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevaVenta
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.txtCuentaP = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboTipoVenta = New System.Windows.Forms.ComboBox()
        Me.dtFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.dtFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTipoDeCambio = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtGlosa = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.txtTipoCambio = New System.Windows.Forms.TextBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.btnBuscarRuc = New System.Windows.Forms.Button()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.dgvOperaciones = New System.Windows.Forms.DataGridView()
        Me.num_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.base_imponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dIgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.isc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.otros_impuestos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnNuevaCompra = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboImpuestos = New System.Windows.Forms.ComboBox()
        Me.panelImpuesto = New System.Windows.Forms.Panel()
        Me.txtNumeroI = New System.Windows.Forms.TextBox()
        Me.lblNumeroI = New System.Windows.Forms.Label()
        Me.lblNomCuentaD = New System.Windows.Forms.Label()
        Me.txtCuentaD = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtIgv = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboOperacion = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.panelImpuesto.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.lblCuenta)
        Me.GroupBox2.Controls.Add(Me.txtCuentaP)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.cboTipoVenta)
        Me.GroupBox2.Controls.Add(Me.dtFechaPago)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.dtFechaEmision)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtSerie)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblTipoDeCambio)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtGlosa)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cboMoneda)
        Me.GroupBox2.Controls.Add(Me.txtTipoCambio)
        Me.GroupBox2.Controls.Add(Me.txtRazonSocial)
        Me.GroupBox2.Controls.Add(Me.btnBuscarRuc)
        Me.GroupBox2.Controls.Add(Me.txtNumero)
        Me.GroupBox2.Controls.Add(Me.txtRuc)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cboTipoDocumento)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(795, 192)
        Me.GroupBox2.TabIndex = 98
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cabecera del Comprobante de venta"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(135, 16)
        Me.Label15.TabIndex = 122
        Me.Label15.Text = "N° Cuenta - Proveedor:"
        '
        'lblCuenta
        '
        Me.lblCuenta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblCuenta.Location = New System.Drawing.Point(95, 41)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(377, 13)
        Me.lblCuenta.TabIndex = 121
        Me.lblCuenta.Text = "[Nombre Cuenta]"
        '
        'txtCuentaP
        '
        Me.txtCuentaP.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtCuentaP.Location = New System.Drawing.Point(9, 38)
        Me.txtCuentaP.Name = "txtCuentaP"
        Me.txtCuentaP.Size = New System.Drawing.Size(80, 21)
        Me.txtCuentaP.TabIndex = 120
        Me.txtCuentaP.Text = "121"
        Me.txtCuentaP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(575, 8)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 16)
        Me.Label19.TabIndex = 112
        Me.Label19.Text = "Tipo Venta"
        '
        'cboTipoVenta
        '
        Me.cboTipoVenta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboTipoVenta.FormattingEnabled = True
        Me.cboTipoVenta.Items.AddRange(New Object() {"soles", "dolares"})
        Me.cboTipoVenta.Location = New System.Drawing.Point(578, 27)
        Me.cboTipoVenta.Name = "cboTipoVenta"
        Me.cboTipoVenta.Size = New System.Drawing.Size(105, 23)
        Me.cboTipoVenta.TabIndex = 111
        '
        'dtFechaPago
        '
        Me.dtFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaPago.Location = New System.Drawing.Point(689, 161)
        Me.dtFechaPago.Name = "dtFechaPago"
        Me.dtFechaPago.Size = New System.Drawing.Size(94, 21)
        Me.dtFechaPago.TabIndex = 109
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(686, 142)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(78, 16)
        Me.Label28.TabIndex = 110
        Me.Label28.Text = "Fecha pago:"
        '
        'dtFechaEmision
        '
        Me.dtFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaEmision.Location = New System.Drawing.Point(689, 27)
        Me.dtFechaEmision.Name = "dtFechaEmision"
        Me.dtFechaEmision.Size = New System.Drawing.Size(94, 21)
        Me.dtFechaEmision.TabIndex = 107
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(686, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Fecha emisión:"
        '
        'txtSerie
        '
        Me.txtSerie.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtSerie.Location = New System.Drawing.Point(304, 82)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(89, 21)
        Me.txtSerie.TabIndex = 4
        Me.txtSerie.Text = "0999"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(301, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Serie:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 16)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "RUC:"
        '
        'lblTipoDeCambio
        '
        Me.lblTipoDeCambio.AutoSize = True
        Me.lblTipoDeCambio.Location = New System.Drawing.Point(660, 63)
        Me.lblTipoDeCambio.Name = "lblTipoDeCambio"
        Me.lblTipoDeCambio.Size = New System.Drawing.Size(96, 16)
        Me.lblTipoDeCambio.TabIndex = 67
        Me.lblTipoDeCambio.Text = "Tipo de cambio:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(491, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 16)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Moneda:"
        '
        'txtGlosa
        '
        Me.txtGlosa.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtGlosa.Location = New System.Drawing.Point(9, 162)
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(674, 21)
        Me.txtGlosa.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 16)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "Glosa:"
        '
        'cboMoneda
        '
        Me.cboMoneda.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Items.AddRange(New Object() {"soles", "dolares"})
        Me.cboMoneda.Location = New System.Drawing.Point(494, 82)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(163, 23)
        Me.cboMoneda.TabIndex = 6
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCambio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTipoCambio.Location = New System.Drawing.Point(663, 82)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Size = New System.Drawing.Size(120, 21)
        Me.txtTipoCambio.TabIndex = 7
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtRazonSocial.Location = New System.Drawing.Point(258, 113)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(525, 21)
        Me.txtRazonSocial.TabIndex = 10
        Me.txtRazonSocial.Text = "USUARIO DE PRUEBA"
        '
        'btnBuscarRuc
        '
        Me.btnBuscarRuc.Location = New System.Drawing.Point(45, 111)
        Me.btnBuscarRuc.Name = "btnBuscarRuc"
        Me.btnBuscarRuc.Size = New System.Drawing.Size(29, 23)
        Me.btnBuscarRuc.TabIndex = 8
        Me.btnBuscarRuc.Text = "..."
        Me.btnBuscarRuc.UseVisualStyleBackColor = True
        '
        'txtNumero
        '
        Me.txtNumero.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtNumero.Location = New System.Drawing.Point(399, 82)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(89, 21)
        Me.txtNumero.TabIndex = 5
        Me.txtNumero.Text = "9999"
        '
        'txtRuc
        '
        Me.txtRuc.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtRuc.Location = New System.Drawing.Point(80, 113)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(86, 21)
        Me.txtRuc.TabIndex = 9
        Me.txtRuc.Text = "10447301500"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(172, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Razón Social:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(396, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 16)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "Número:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 16)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "Tipo Documento:"
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTipoDocumento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoDocumento.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocumento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboTipoDocumento.FormattingEnabled = True
        Me.cboTipoDocumento.Location = New System.Drawing.Point(9, 82)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(289, 23)
        Me.cboTipoDocumento.TabIndex = 3
        '
        'dgvOperaciones
        '
        Me.dgvOperaciones.AllowUserToAddRows = False
        Me.dgvOperaciones.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOperaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOperaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num_cuenta, Me.desc_cuenta, Me.costo, Me.base_imponible, Me.dIgv, Me.isc, Me.otros_impuestos, Me.descuento, Me.total})
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOperaciones.DefaultCellStyle = DataGridViewCellStyle20
        Me.dgvOperaciones.Location = New System.Drawing.Point(11, 343)
        Me.dgvOperaciones.Name = "dgvOperaciones"
        Me.dgvOperaciones.ReadOnly = True
        Me.dgvOperaciones.Size = New System.Drawing.Size(797, 98)
        Me.dgvOperaciones.TabIndex = 100
        '
        'num_cuenta
        '
        Me.num_cuenta.DataPropertyName = "num_cuenta"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.num_cuenta.DefaultCellStyle = DataGridViewCellStyle12
        Me.num_cuenta.HeaderText = "N° Cta."
        Me.num_cuenta.Name = "num_cuenta"
        Me.num_cuenta.ReadOnly = True
        Me.num_cuenta.Width = 75
        '
        'desc_cuenta
        '
        Me.desc_cuenta.DataPropertyName = "desc_cuenta"
        Me.desc_cuenta.HeaderText = "Desc. Cuenta"
        Me.desc_cuenta.Name = "desc_cuenta"
        Me.desc_cuenta.ReadOnly = True
        Me.desc_cuenta.Width = 260
        '
        'costo
        '
        Me.costo.DataPropertyName = "costo"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.costo.DefaultCellStyle = DataGridViewCellStyle13
        Me.costo.HeaderText = "Costo"
        Me.costo.Name = "costo"
        Me.costo.ReadOnly = True
        '
        'base_imponible
        '
        Me.base_imponible.DataPropertyName = "base_imponible"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.base_imponible.DefaultCellStyle = DataGridViewCellStyle14
        Me.base_imponible.HeaderText = "Base Imp."
        Me.base_imponible.Name = "base_imponible"
        Me.base_imponible.ReadOnly = True
        '
        'dIgv
        '
        Me.dIgv.DataPropertyName = "igv"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.dIgv.DefaultCellStyle = DataGridViewCellStyle15
        Me.dIgv.HeaderText = "IGV"
        Me.dIgv.Name = "dIgv"
        Me.dIgv.ReadOnly = True
        '
        'isc
        '
        Me.isc.DataPropertyName = "isc"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.isc.DefaultCellStyle = DataGridViewCellStyle16
        Me.isc.HeaderText = "ISC"
        Me.isc.Name = "isc"
        Me.isc.ReadOnly = True
        Me.isc.Visible = False
        Me.isc.Width = 70
        '
        'otros_impuestos
        '
        Me.otros_impuestos.DataPropertyName = "otros_impuestos"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.otros_impuestos.DefaultCellStyle = DataGridViewCellStyle17
        Me.otros_impuestos.HeaderText = "Otros Imp."
        Me.otros_impuestos.Name = "otros_impuestos"
        Me.otros_impuestos.ReadOnly = True
        Me.otros_impuestos.Visible = False
        Me.otros_impuestos.Width = 90
        '
        'descuento
        '
        Me.descuento.DataPropertyName = "descuento"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.descuento.DefaultCellStyle = DataGridViewCellStyle18
        Me.descuento.HeaderText = "Descuento"
        Me.descuento.Name = "descuento"
        Me.descuento.ReadOnly = True
        Me.descuento.Visible = False
        Me.descuento.Width = 80
        '
        'total
        '
        Me.total.DataPropertyName = "total"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.total.DefaultCellStyle = DataGridViewCellStyle19
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(572, 447)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(115, 35)
        Me.btnAceptar.TabIndex = 101
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(693, 447)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(115, 35)
        Me.btnCancelar.TabIndex = 102
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnNuevaCompra
        '
        Me.btnNuevaCompra.Location = New System.Drawing.Point(442, 453)
        Me.btnNuevaCompra.Name = "btnNuevaCompra"
        Me.btnNuevaCompra.Size = New System.Drawing.Size(124, 23)
        Me.btnNuevaCompra.TabIndex = 112
        Me.btnNuevaCompra.Text = "Lista de Deudas"
        Me.btnNuevaCompra.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboImpuestos)
        Me.GroupBox1.Controls.Add(Me.panelImpuesto)
        Me.GroupBox1.Controls.Add(Me.lblNomCuentaD)
        Me.GroupBox1.Controls.Add(Me.txtCuentaD)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtCosto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.txtIgv)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboOperacion)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(795, 127)
        Me.GroupBox1.TabIndex = 113
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle del Comprobante de Venta"
        '
        'cboImpuestos
        '
        Me.cboImpuestos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboImpuestos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboImpuestos.FormattingEnabled = True
        Me.cboImpuestos.Location = New System.Drawing.Point(327, 94)
        Me.cboImpuestos.Name = "cboImpuestos"
        Me.cboImpuestos.Size = New System.Drawing.Size(161, 23)
        Me.cboImpuestos.TabIndex = 114
        '
        'panelImpuesto
        '
        Me.panelImpuesto.Controls.Add(Me.txtNumeroI)
        Me.panelImpuesto.Controls.Add(Me.lblNumeroI)
        Me.panelImpuesto.Enabled = False
        Me.panelImpuesto.Location = New System.Drawing.Point(478, 70)
        Me.panelImpuesto.Name = "panelImpuesto"
        Me.panelImpuesto.Size = New System.Drawing.Size(190, 50)
        Me.panelImpuesto.TabIndex = 119
        '
        'txtNumeroI
        '
        Me.txtNumeroI.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtNumeroI.Location = New System.Drawing.Point(16, 24)
        Me.txtNumeroI.Name = "txtNumeroI"
        Me.txtNumeroI.Size = New System.Drawing.Size(144, 21)
        Me.txtNumeroI.TabIndex = 120
        Me.txtNumeroI.Text = "0058-8188"
        Me.txtNumeroI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblNumeroI
        '
        Me.lblNumeroI.AutoSize = True
        Me.lblNumeroI.Location = New System.Drawing.Point(13, 5)
        Me.lblNumeroI.Name = "lblNumeroI"
        Me.lblNumeroI.Size = New System.Drawing.Size(23, 16)
        Me.lblNumeroI.TabIndex = 119
        Me.lblNumeroI.Text = "N°:"
        '
        'lblNomCuentaD
        '
        Me.lblNomCuentaD.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomCuentaD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblNomCuentaD.Location = New System.Drawing.Point(357, 46)
        Me.lblNomCuentaD.Name = "lblNomCuentaD"
        Me.lblNomCuentaD.Size = New System.Drawing.Size(311, 13)
        Me.lblNomCuentaD.TabIndex = 116
        Me.lblNomCuentaD.Text = "[Nombre Cuenta]"
        '
        'txtCuentaD
        '
        Me.txtCuentaD.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtCuentaD.Location = New System.Drawing.Point(271, 43)
        Me.txtCuentaD.Name = "txtCuentaD"
        Me.txtCuentaD.Size = New System.Drawing.Size(80, 21)
        Me.txtCuentaD.TabIndex = 115
        Me.txtCuentaD.Text = "701"
        Me.txtCuentaD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(324, 75)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(55, 16)
        Me.Label20.TabIndex = 113
        Me.Label20.Text = "Sujeto a:"
        '
        'txtCosto
        '
        Me.txtCosto.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCosto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtCosto.Location = New System.Drawing.Point(9, 94)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(100, 21)
        Me.txtCosto.TabIndex = 111
        Me.txtCosto.Text = "650.00"
        Me.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 110
        Me.Label6.Text = "Costo:"
        '
        'txtMonto
        '
        Me.txtMonto.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtMonto.Location = New System.Drawing.Point(165, 43)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(100, 21)
        Me.txtMonto.TabIndex = 14
        Me.txtMonto.Text = "250.00"
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(674, 86)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(115, 35)
        Me.btnAgregar.TabIndex = 20
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'txtIgv
        '
        Me.txtIgv.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIgv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtIgv.Location = New System.Drawing.Point(115, 94)
        Me.txtIgv.Name = "txtIgv"
        Me.txtIgv.Size = New System.Drawing.Size(100, 21)
        Me.txtIgv.TabIndex = 15
        Me.txtIgv.Text = "45.00"
        Me.txtIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(112, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 16)
        Me.Label8.TabIndex = 105
        Me.Label8.Text = "I.G.V:"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTotal.Location = New System.Drawing.Point(221, 94)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 21)
        Me.txtTotal.TabIndex = 19
        Me.txtTotal.Text = "295.00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Total:"
        '
        'cboOperacion
        '
        Me.cboOperacion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOperacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboOperacion.FormattingEnabled = True
        Me.cboOperacion.Location = New System.Drawing.Point(9, 43)
        Me.cboOperacion.Name = "cboOperacion"
        Me.cboOperacion.Size = New System.Drawing.Size(150, 23)
        Me.cboOperacion.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 16)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Operación"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(268, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 16)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "N° Cuenta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(162, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Base imponible:"
        '
        'frmNuevaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 494)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnNuevaCompra)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvOperaciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmNuevaVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Ventas al Contado"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panelImpuesto.ResumeLayout(False)
        Me.panelImpuesto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTipoDeCambio As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtGlosa As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents txtTipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarRuc As System.Windows.Forms.Button
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents dgvOperaciones As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnNuevaCompra As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cboTipoVenta As System.Windows.Forms.ComboBox
    Friend WithEvents dtFechaPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents dtFechaEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboImpuestos As System.Windows.Forms.ComboBox
    Friend WithEvents panelImpuesto As System.Windows.Forms.Panel
    Friend WithEvents txtNumeroI As System.Windows.Forms.TextBox
    Friend WithEvents lblNumeroI As System.Windows.Forms.Label
    Friend WithEvents lblNomCuentaD As System.Windows.Forms.Label
    Friend WithEvents txtCuentaD As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtCosto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtIgv As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboOperacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCuenta As System.Windows.Forms.Label
    Friend WithEvents txtCuentaP As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents num_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents base_imponible As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dIgv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents isc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents otros_impuestos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
