<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagoComprobanteCompra
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIgv = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtDiferenciaS = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTHaberS = New System.Windows.Forms.TextBox()
        Me.txtTDebeS = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNomCuenta = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblTipoDeCambio = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtGlosa = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTipoCambio = New System.Windows.Forms.TextBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvOperaciones = New System.Windows.Forms.DataGridView()
        Me.num_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.txtCuentaP = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.dtFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboTipoCompra = New System.Windows.Forms.ComboBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.panelImpuestos = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtNumeroI = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.lblImpuesto = New System.Windows.Forms.Label()
        Me.txtCalculo = New System.Windows.Forms.TextBox()
        Me.cboImpuestos = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.dgvOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.panelImpuestos.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSerie
        '
        Me.txtSerie.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtSerie.Location = New System.Drawing.Point(304, 83)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(89, 21)
        Me.txtSerie.TabIndex = 4
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(390, 480)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(31, 16)
        Me.Label20.TabIndex = 186
        Me.Label20.Text = "IGV:"
        Me.Label20.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(302, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Serie:"
        '
        'txtIgv
        '
        Me.txtIgv.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtIgv.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIgv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtIgv.Location = New System.Drawing.Point(393, 499)
        Me.txtIgv.Name = "txtIgv"
        Me.txtIgv.Size = New System.Drawing.Size(121, 21)
        Me.txtIgv.TabIndex = 175
        Me.txtIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIgv.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(263, 480)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(79, 16)
        Me.Label22.TabIndex = 182
        Me.Label22.Text = "Diferencia S/."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(136, 480)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 16)
        Me.Label17.TabIndex = 181
        Me.Label17.Text = "Total Haber S/."
        '
        'txtDiferenciaS
        '
        Me.txtDiferenciaS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDiferenciaS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferenciaS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDiferenciaS.Location = New System.Drawing.Point(266, 499)
        Me.txtDiferenciaS.Name = "txtDiferenciaS"
        Me.txtDiferenciaS.Size = New System.Drawing.Size(121, 21)
        Me.txtDiferenciaS.TabIndex = 171
        Me.txtDiferenciaS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 480)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 16)
        Me.Label14.TabIndex = 180
        Me.Label14.Text = "Total Debe S/. "
        '
        'txtTHaberS
        '
        Me.txtTHaberS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTHaberS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTHaberS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTHaberS.Location = New System.Drawing.Point(139, 499)
        Me.txtTHaberS.Name = "txtTHaberS"
        Me.txtTHaberS.Size = New System.Drawing.Size(121, 21)
        Me.txtTHaberS.TabIndex = 170
        Me.txtTHaberS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTDebeS
        '
        Me.txtTDebeS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTDebeS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTDebeS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTDebeS.Location = New System.Drawing.Point(12, 499)
        Me.txtTDebeS.Name = "txtTDebeS"
        Me.txtTDebeS.Size = New System.Drawing.Size(121, 21)
        Me.txtTDebeS.TabIndex = 169
        Me.txtTDebeS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 16)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "RUC:"
        '
        'lblNomCuenta
        '
        Me.lblNomCuenta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblNomCuenta.Location = New System.Drawing.Point(297, 48)
        Me.lblNomCuenta.Name = "lblNomCuenta"
        Me.lblNomCuenta.Size = New System.Drawing.Size(379, 13)
        Me.lblNomCuenta.TabIndex = 93
        Me.lblNomCuenta.Text = "[Nombre Cuenta]"
        '
        'txtCuenta
        '
        Me.txtCuenta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtCuenta.Location = New System.Drawing.Point(211, 45)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(80, 21)
        Me.txtCuenta.TabIndex = 12
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(208, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(114, 17)
        Me.Label16.TabIndex = 91
        Me.Label16.Text = "Cuenta Contable:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(117, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 17)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Monto:"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(703, 81)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(94, 35)
        Me.btnAgregar.TabIndex = 15
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'lblTipoDeCambio
        '
        Me.lblTipoDeCambio.AutoSize = True
        Me.lblTipoDeCambio.Location = New System.Drawing.Point(659, 63)
        Me.lblTipoDeCambio.Name = "lblTipoDeCambio"
        Me.lblTipoDeCambio.Size = New System.Drawing.Size(96, 16)
        Me.lblTipoDeCambio.TabIndex = 67
        Me.lblTipoDeCambio.Text = "Tipo de cambio:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(491, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 16)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Moneda:"
        '
        'txtGlosa
        '
        Me.txtGlosa.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtGlosa.Location = New System.Drawing.Point(54, 138)
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(743, 21)
        Me.txtGlosa.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 141)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 16)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "Glosa:"
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCambio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTipoCambio.Location = New System.Drawing.Point(662, 82)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Size = New System.Drawing.Size(135, 21)
        Me.txtTipoCambio.TabIndex = 7
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtRazonSocial.Location = New System.Drawing.Point(260, 111)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(537, 21)
        Me.txtRazonSocial.TabIndex = 9
        '
        'txtNumero
        '
        Me.txtNumero.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtNumero.Location = New System.Drawing.Point(399, 83)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(89, 21)
        Me.txtNumero.TabIndex = 5
        '
        'txtRuc
        '
        Me.txtRuc.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtRuc.Location = New System.Drawing.Point(47, 111)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(121, 21)
        Me.txtRuc.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(174, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Razón Social:"
        '
        'dgvOperaciones
        '
        Me.dgvOperaciones.AllowUserToAddRows = False
        Me.dgvOperaciones.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOperaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOperaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num_cuenta, Me.desc_cuenta, Me.debe, Me.haber, Me.descripcion})
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOperaciones.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvOperaciones.Location = New System.Drawing.Point(12, 314)
        Me.dgvOperaciones.Name = "dgvOperaciones"
        Me.dgvOperaciones.ReadOnly = True
        Me.dgvOperaciones.Size = New System.Drawing.Size(803, 163)
        Me.dgvOperaciones.TabIndex = 177
        '
        'num_cuenta
        '
        Me.num_cuenta.DataPropertyName = "num_cuenta"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.num_cuenta.DefaultCellStyle = DataGridViewCellStyle14
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
        Me.desc_cuenta.Width = 300
        '
        'debe
        '
        Me.debe.DataPropertyName = "debe"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.debe.DefaultCellStyle = DataGridViewCellStyle15
        Me.debe.HeaderText = "Debe"
        Me.debe.Name = "debe"
        Me.debe.ReadOnly = True
        Me.debe.Width = 90
        '
        'haber
        '
        Me.haber.DataPropertyName = "haber"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.haber.DefaultCellStyle = DataGridViewCellStyle16
        Me.haber.HeaderText = "Haber"
        Me.haber.Name = "haber"
        Me.haber.ReadOnly = True
        Me.haber.Width = 90
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.descripcion.DefaultCellStyle = DataGridViewCellStyle17
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 185
        '
        'cboMoneda
        '
        Me.cboMoneda.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Items.AddRange(New Object() {"soles", "dolares"})
        Me.cboMoneda.Location = New System.Drawing.Point(494, 82)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(162, 23)
        Me.cboMoneda.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(396, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 16)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "Número:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Tipo Documento:"
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblCuenta)
        Me.GroupBox2.Controls.Add(Me.txtCuentaP)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.dtFechaPago)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.dtFechaEmision)
        Me.GroupBox2.Controls.Add(Me.Label29)
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
        Me.GroupBox2.Controls.Add(Me.txtNumero)
        Me.GroupBox2.Controls.Add(Me.txtRuc)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cboTipoDocumento)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(803, 167)
        Me.GroupBox2.TabIndex = 179
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cabecera del Comprobante de Compra"
        '
        'lblCuenta
        '
        Me.lblCuenta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblCuenta.Location = New System.Drawing.Point(95, 42)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(455, 13)
        Me.lblCuenta.TabIndex = 122
        Me.lblCuenta.Text = "[Nombre Cuenta]"
        '
        'txtCuentaP
        '
        Me.txtCuentaP.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtCuentaP.Location = New System.Drawing.Point(9, 39)
        Me.txtCuentaP.Name = "txtCuentaP"
        Me.txtCuentaP.Size = New System.Drawing.Size(80, 21)
        Me.txtCuentaP.TabIndex = 121
        Me.txtCuentaP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 16)
        Me.Label11.TabIndex = 120
        Me.Label11.Text = "N° Cuenta - Proveedor:"
        '
        'dtFechaPago
        '
        Me.dtFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaPago.Location = New System.Drawing.Point(703, 38)
        Me.dtFechaPago.Name = "dtFechaPago"
        Me.dtFechaPago.Size = New System.Drawing.Size(94, 21)
        Me.dtFechaPago.TabIndex = 109
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(700, 19)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(78, 16)
        Me.Label28.TabIndex = 110
        Me.Label28.Text = "Fecha pago:"
        '
        'dtFechaEmision
        '
        Me.dtFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaEmision.Location = New System.Drawing.Point(603, 38)
        Me.dtFechaEmision.Name = "dtFechaEmision"
        Me.dtFechaEmision.Size = New System.Drawing.Size(94, 21)
        Me.dtFechaEmision.TabIndex = 107
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(600, 19)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(87, 16)
        Me.Label29.TabIndex = 108
        Me.Label29.Text = "Fecha emisión:"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(700, 487)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(115, 35)
        Me.btnCancelar.TabIndex = 168
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(579, 487)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(115, 35)
        Me.btnAceptar.TabIndex = 167
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'txtMonto
        '
        Me.txtMonto.Font = New System.Drawing.Font("Century Gothic", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtMonto.Location = New System.Drawing.Point(120, 44)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(78, 23)
        Me.txtMonto.TabIndex = 36
        Me.txtMonto.Text = "00.00"
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Tipo Compra"
        '
        'cboTipoCompra
        '
        Me.cboTipoCompra.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboTipoCompra.FormattingEnabled = True
        Me.cboTipoCompra.Items.AddRange(New Object() {"soles", "dolares"})
        Me.cboTipoCompra.Location = New System.Drawing.Point(9, 44)
        Me.cboTipoCompra.Name = "cboTipoCompra"
        Me.cboTipoCompra.Size = New System.Drawing.Size(105, 23)
        Me.cboTipoCompra.TabIndex = 111
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDescripcion.Location = New System.Drawing.Point(9, 88)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(189, 21)
        Me.txtDescripcion.TabIndex = 188
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 189
        Me.Label1.Text = "Descripción:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.cboTipoCompra)
        Me.GroupBox1.Controls.Add(Me.txtCuenta)
        Me.GroupBox1.Controls.Add(Me.lblNomCuenta)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.panelImpuestos)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 185)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(803, 123)
        Me.GroupBox1.TabIndex = 190
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pago del Comprobante"
        '
        'panelImpuestos
        '
        Me.panelImpuestos.Controls.Add(Me.Label23)
        Me.panelImpuestos.Controls.Add(Me.txtNumeroI)
        Me.panelImpuestos.Controls.Add(Me.Label21)
        Me.panelImpuestos.Controls.Add(Me.txtSaldo)
        Me.panelImpuestos.Controls.Add(Me.lblImpuesto)
        Me.panelImpuestos.Controls.Add(Me.txtCalculo)
        Me.panelImpuestos.Controls.Add(Me.cboImpuestos)
        Me.panelImpuestos.Controls.Add(Me.Label13)
        Me.panelImpuestos.Enabled = False
        Me.panelImpuestos.Location = New System.Drawing.Point(204, 64)
        Me.panelImpuestos.Name = "panelImpuestos"
        Me.panelImpuestos.Size = New System.Drawing.Size(493, 52)
        Me.panelImpuestos.TabIndex = 198
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(165, 7)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(25, 17)
        Me.Label23.TabIndex = 204
        Me.Label23.Text = "N°:"
        '
        'txtNumeroI
        '
        Me.txtNumeroI.Font = New System.Drawing.Font("Century Gothic", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtNumeroI.Location = New System.Drawing.Point(168, 25)
        Me.txtNumeroI.Name = "txtNumeroI"
        Me.txtNumeroI.Size = New System.Drawing.Size(100, 23)
        Me.txtNumeroI.TabIndex = 205
        Me.txtNumeroI.Text = "0"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(395, 5)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(40, 17)
        Me.Label21.TabIndex = 202
        Me.Label21.Text = "Total:"
        '
        'txtSaldo
        '
        Me.txtSaldo.Font = New System.Drawing.Font("Century Gothic", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtSaldo.Location = New System.Drawing.Point(398, 25)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(90, 23)
        Me.txtSaldo.TabIndex = 203
        Me.txtSaldo.Tag = "90,23"
        Me.txtSaldo.Text = "00.00"
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblImpuesto
        '
        Me.lblImpuesto.AutoSize = True
        Me.lblImpuesto.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpuesto.Location = New System.Drawing.Point(271, 5)
        Me.lblImpuesto.Name = "lblImpuesto"
        Me.lblImpuesto.Size = New System.Drawing.Size(57, 17)
        Me.lblImpuesto.TabIndex = 200
        Me.lblImpuesto.Text = "Cálculo:"
        '
        'txtCalculo
        '
        Me.txtCalculo.Font = New System.Drawing.Font("Century Gothic", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalculo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtCalculo.Location = New System.Drawing.Point(274, 25)
        Me.txtCalculo.Name = "txtCalculo"
        Me.txtCalculo.Size = New System.Drawing.Size(118, 23)
        Me.txtCalculo.TabIndex = 201
        Me.txtCalculo.Tag = "90,23"
        Me.txtCalculo.Text = "00.00"
        Me.txtCalculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboImpuestos
        '
        Me.cboImpuestos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboImpuestos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboImpuestos.FormattingEnabled = True
        Me.cboImpuestos.Location = New System.Drawing.Point(8, 25)
        Me.cboImpuestos.Name = "cboImpuestos"
        Me.cboImpuestos.Size = New System.Drawing.Size(154, 23)
        Me.cboImpuestos.TabIndex = 199
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(5, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 17)
        Me.Label13.TabIndex = 198
        Me.Label13.Text = "Sujeto a:"
        '
        'frmPagoComprobanteCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 534)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtIgv)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtDiferenciaS)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtTHaberS)
        Me.Controls.Add(Me.txtTDebeS)
        Me.Controls.Add(Me.dgvOperaciones)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "frmPagoComprobanteCompra"
        Me.Text = "Pago Comprobante Compra"
        CType(Me.dgvOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panelImpuestos.ResumeLayout(False)
        Me.panelImpuestos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtIgv As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtDiferenciaS As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtTHaberS As System.Windows.Forms.TextBox
    Friend WithEvents txtTDebeS As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents lblNomCuenta As System.Windows.Forms.Label
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblTipoDeCambio As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtGlosa As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgvOperaciones As System.Windows.Forms.DataGridView
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents dtFechaPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents dtFechaEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboTipoCompra As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents num_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCuenta As System.Windows.Forms.Label
    Friend WithEvents txtCuentaP As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents panelImpuestos As System.Windows.Forms.Panel
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroI As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents lblImpuesto As System.Windows.Forms.Label
    Friend WithEvents txtCalculo As System.Windows.Forms.TextBox
    Friend WithEvents cboImpuestos As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
