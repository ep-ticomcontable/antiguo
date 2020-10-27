<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarCompra
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.cboOperacion = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMontoCuenta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGlosa = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnBuscarRuc = New System.Windows.Forms.Button()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.panelCuenta = New System.Windows.Forms.GroupBox()
        Me.btnVentana = New System.Windows.Forms.Button()
        Me.cboDH = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblNomCuenta = New System.Windows.Forms.TextBox()
        Me.cboCentroCosto = New System.Windows.Forms.ComboBox()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnAgregarCuenta = New System.Windows.Forms.Button()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.panelPercepcion = New System.Windows.Forms.Panel()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cboTipoPercepcion = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtPorcPercep = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cboPercepcion = New System.Windows.Forms.ComboBox()
        Me.lblCuenta = New System.Windows.Forms.TextBox()
        Me.txtTotalCompra = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cboTipoCompra = New System.Windows.Forms.ComboBox()
        Me.lblTipoDeCambio = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtCuentaP = New System.Windows.Forms.TextBox()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.txtTipoCambio = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkAsiento = New System.Windows.Forms.CheckBox()
        Me.panelPago = New System.Windows.Forms.GroupBox()
        Me.dtFecImpuesto = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNumeroImpuesto = New System.Windows.Forms.TextBox()
        Me.txtPorcentaje = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCuentaPago = New System.Windows.Forms.TextBox()
        Me.txtMontoPago = New System.Windows.Forms.TextBox()
        Me.btnCargarDatos = New System.Windows.Forms.Button()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtCuentaPago = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDescripcionPago = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboSerieImpuesto = New System.Windows.Forms.ComboBox()
        Me.cboImpuestos = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.panelDetraccion = New System.Windows.Forms.Panel()
        Me.lblDetraccion = New System.Windows.Forms.TextBox()
        Me.txtCDetraccion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvOperaciones = New System.Windows.Forms.DataGridView()
        Me.num_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.operacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtDiferenciaS = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtTHaberS = New System.Windows.Forms.TextBox()
        Me.txtTDebeS = New System.Windows.Forms.TextBox()
        Me.panelAsientos = New System.Windows.Forms.GroupBox()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.dtFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelCuenta.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.panelPercepcion.SuspendLayout()
        Me.panelPago.SuspendLayout()
        Me.panelDetraccion.SuspendLayout()
        CType(Me.dgvOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelAsientos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(6, 248)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(93, 35)
        Me.btnCancelar.TabIndex = 112
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'cboOperacion
        '
        Me.cboOperacion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOperacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboOperacion.FormattingEnabled = True
        Me.cboOperacion.Location = New System.Drawing.Point(2, 22)
        Me.cboOperacion.Name = "cboOperacion"
        Me.cboOperacion.Size = New System.Drawing.Size(110, 24)
        Me.cboOperacion.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(-1, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 16)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Operación"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 16)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "N° Cuenta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(204, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Monto:"
        '
        'txtMontoCuenta
        '
        Me.txtMontoCuenta.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtMontoCuenta.ForeColor = System.Drawing.Color.Black
        Me.txtMontoCuenta.Location = New System.Drawing.Point(207, 37)
        Me.txtMontoCuenta.Name = "txtMontoCuenta"
        Me.txtMontoCuenta.Size = New System.Drawing.Size(75, 22)
        Me.txtMontoCuenta.TabIndex = 14
        Me.txtMontoCuenta.Text = "0.00"
        Me.txtMontoCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(274, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 16)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "RUC:"
        '
        'txtGlosa
        '
        Me.txtGlosa.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtGlosa.Location = New System.Drawing.Point(69, 65)
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(419, 21)
        Me.txtGlosa.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 16)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "Glosa:"
        '
        'btnBuscarRuc
        '
        Me.btnBuscarRuc.Location = New System.Drawing.Point(277, 34)
        Me.btnBuscarRuc.Name = "btnBuscarRuc"
        Me.btnBuscarRuc.Size = New System.Drawing.Size(25, 23)
        Me.btnBuscarRuc.TabIndex = 8
        Me.btnBuscarRuc.Text = "..."
        Me.btnBuscarRuc.UseVisualStyleBackColor = True
        '
        'txtNumero
        '
        Me.txtNumero.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtNumero.Location = New System.Drawing.Point(221, 36)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(50, 21)
        Me.txtNumero.TabIndex = 5
        Me.txtNumero.Text = "0"
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRuc
        '
        Me.txtRuc.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtRuc.Location = New System.Drawing.Point(302, 35)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(89, 21)
        Me.txtRuc.TabIndex = 9
        Me.txtRuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(392, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Razón Social:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(218, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(20, 16)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "N°"
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTipoDocumento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoDocumento.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocumento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboTipoDocumento.FormattingEnabled = True
        Me.cboTipoDocumento.Location = New System.Drawing.Point(6, 34)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(154, 24)
        Me.cboTipoDocumento.TabIndex = 3
        '
        'panelCuenta
        '
        Me.panelCuenta.Controls.Add(Me.btnVentana)
        Me.panelCuenta.Controls.Add(Me.cboDH)
        Me.panelCuenta.Controls.Add(Me.Label24)
        Me.panelCuenta.Controls.Add(Me.lblNomCuenta)
        Me.panelCuenta.Controls.Add(Me.cboCentroCosto)
        Me.panelCuenta.Controls.Add(Me.txtCuenta)
        Me.panelCuenta.Controls.Add(Me.Label22)
        Me.panelCuenta.Controls.Add(Me.txtMontoCuenta)
        Me.panelCuenta.Controls.Add(Me.btnAgregarCuenta)
        Me.panelCuenta.Controls.Add(Me.Label16)
        Me.panelCuenta.Controls.Add(Me.Label3)
        Me.panelCuenta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelCuenta.Location = New System.Drawing.Point(12, 226)
        Me.panelCuenta.Name = "panelCuenta"
        Me.panelCuenta.Size = New System.Drawing.Size(760, 65)
        Me.panelCuenta.TabIndex = 108
        Me.panelCuenta.TabStop = False
        Me.panelCuenta.Text = "CUENTAS"
        '
        'btnVentana
        '
        Me.btnVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentana.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnVentana.ForeColor = System.Drawing.Color.White
        Me.btnVentana.Location = New System.Drawing.Point(658, 25)
        Me.btnVentana.Name = "btnVentana"
        Me.btnVentana.Size = New System.Drawing.Size(96, 35)
        Me.btnVentana.TabIndex = 296
        Me.btnVentana.Text = "VENTANA"
        Me.btnVentana.UseVisualStyleBackColor = False
        '
        'cboDH
        '
        Me.cboDH.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.cboDH.FormattingEnabled = True
        Me.cboDH.Location = New System.Drawing.Point(300, 34)
        Me.cboDH.Name = "cboDH"
        Me.cboDH.Size = New System.Drawing.Size(48, 25)
        Me.cboDH.TabIndex = 294
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(297, 18)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(32, 16)
        Me.Label24.TabIndex = 295
        Me.Label24.Text = "D/H:"
        '
        'lblNomCuenta
        '
        Me.lblNomCuenta.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblNomCuenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblNomCuenta.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblNomCuenta.Location = New System.Drawing.Point(69, 38)
        Me.lblNomCuenta.Multiline = True
        Me.lblNomCuenta.Name = "lblNomCuenta"
        Me.lblNomCuenta.Size = New System.Drawing.Size(132, 21)
        Me.lblNomCuenta.TabIndex = 293
        '
        'cboCentroCosto
        '
        Me.cboCentroCosto.Enabled = False
        Me.cboCentroCosto.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.cboCentroCosto.FormattingEnabled = True
        Me.cboCentroCosto.Location = New System.Drawing.Point(354, 34)
        Me.cboCentroCosto.Name = "cboCentroCosto"
        Me.cboCentroCosto.Size = New System.Drawing.Size(202, 25)
        Me.cboCentroCosto.TabIndex = 275
        '
        'txtCuenta
        '
        Me.txtCuenta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtCuenta.Location = New System.Drawing.Point(6, 38)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(60, 21)
        Me.txtCuenta.TabIndex = 115
        Me.txtCuenta.Text = "601"
        Me.txtCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(351, 18)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(98, 16)
        Me.Label22.TabIndex = 276
        Me.Label22.Text = "Centro de costo:"
        '
        'btnAgregarCuenta
        '
        Me.btnAgregarCuenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnAgregarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarCuenta.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregarCuenta.ForeColor = System.Drawing.Color.White
        Me.btnAgregarCuenta.Location = New System.Drawing.Point(568, 25)
        Me.btnAgregarCuenta.Name = "btnAgregarCuenta"
        Me.btnAgregarCuenta.Size = New System.Drawing.Size(82, 35)
        Me.btnAgregarCuenta.TabIndex = 258
        Me.btnAgregarCuenta.Text = "AGREGAR"
        Me.btnAgregarCuenta.UseVisualStyleBackColor = False
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtRazonSocial.Location = New System.Drawing.Point(395, 35)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(359, 21)
        Me.txtRazonSocial.TabIndex = 10
        '
        'btnGrabar
        '
        Me.btnGrabar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrabar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnGrabar.ForeColor = System.Drawing.Color.White
        Me.btnGrabar.Location = New System.Drawing.Point(568, 248)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(84, 35)
        Me.btnGrabar.TabIndex = 111
        Me.btnGrabar.Text = "GRABAR"
        Me.btnGrabar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtFechaPago)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.dtFechaEmision)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtRazonSocial)
        Me.GroupBox2.Controls.Add(Me.lblTipoDeCambio)
        Me.GroupBox2.Controls.Add(Me.cboTipoCompra)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txtSerie)
        Me.GroupBox2.Controls.Add(Me.cboMoneda)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtTipoCambio)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cboTipoDocumento)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.btnBuscarRuc)
        Me.GroupBox2.Controls.Add(Me.txtNumero)
        Me.GroupBox2.Controls.Add(Me.txtRuc)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.chkAsiento)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(760, 110)
        Me.GroupBox2.TabIndex = 109
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS COMPROBANTE COMPRA"
        '
        'panelPercepcion
        '
        Me.panelPercepcion.Controls.Add(Me.Label30)
        Me.panelPercepcion.Controls.Add(Me.cboTipoPercepcion)
        Me.panelPercepcion.Controls.Add(Me.Label18)
        Me.panelPercepcion.Controls.Add(Me.txtPorcPercep)
        Me.panelPercepcion.Controls.Add(Me.Label17)
        Me.panelPercepcion.Controls.Add(Me.cboOperacion)
        Me.panelPercepcion.Controls.Add(Me.Label14)
        Me.panelPercepcion.Controls.Add(Me.cboPercepcion)
        Me.panelPercepcion.Location = New System.Drawing.Point(494, 14)
        Me.panelPercepcion.Name = "panelPercepcion"
        Me.panelPercepcion.Size = New System.Drawing.Size(257, 78)
        Me.panelPercepcion.TabIndex = 301
        Me.panelPercepcion.Visible = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(25, 55)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(33, 16)
        Me.Label30.TabIndex = 305
        Me.Label30.Text = "Tipo:"
        '
        'cboTipoPercepcion
        '
        Me.cboTipoPercepcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTipoPercepcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoPercepcion.Enabled = False
        Me.cboTipoPercepcion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoPercepcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboTipoPercepcion.FormattingEnabled = True
        Me.cboTipoPercepcion.Location = New System.Drawing.Point(64, 51)
        Me.cboTipoPercepcion.Name = "cboTipoPercepcion"
        Me.cboTipoPercepcion.Size = New System.Drawing.Size(106, 24)
        Me.cboTipoPercepcion.TabIndex = 306
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(115, 6)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 16)
        Me.Label18.TabIndex = 301
        Me.Label18.Text = "Sujeto a:"
        '
        'txtPorcPercep
        '
        Me.txtPorcPercep.BackColor = System.Drawing.SystemColors.Info
        Me.txtPorcPercep.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPorcPercep.Enabled = False
        Me.txtPorcPercep.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtPorcPercep.ForeColor = System.Drawing.Color.Maroon
        Me.txtPorcPercep.Location = New System.Drawing.Point(210, 54)
        Me.txtPorcPercep.Multiline = True
        Me.txtPorcPercep.Name = "txtPorcPercep"
        Me.txtPorcPercep.Size = New System.Drawing.Size(41, 20)
        Me.txtPorcPercep.TabIndex = 304
        Me.txtPorcPercep.Text = "0"
        Me.txtPorcPercep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(176, 56)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 16)
        Me.Label17.TabIndex = 303
        Me.Label17.Text = "(%):"
        '
        'cboPercepcion
        '
        Me.cboPercepcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPercepcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPercepcion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPercepcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboPercepcion.FormattingEnabled = True
        Me.cboPercepcion.Location = New System.Drawing.Point(118, 22)
        Me.cboPercepcion.Name = "cboPercepcion"
        Me.cboPercepcion.Size = New System.Drawing.Size(133, 24)
        Me.cboPercepcion.TabIndex = 302
        '
        'lblCuenta
        '
        Me.lblCuenta.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblCuenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblCuenta.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblCuenta.Location = New System.Drawing.Point(69, 38)
        Me.lblCuenta.Multiline = True
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(322, 21)
        Me.lblCuenta.TabIndex = 292
        '
        'txtTotalCompra
        '
        Me.txtTotalCompra.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalCompra.ForeColor = System.Drawing.Color.Black
        Me.txtTotalCompra.Location = New System.Drawing.Point(397, 37)
        Me.txtTotalCompra.Name = "txtTotalCompra"
        Me.txtTotalCompra.Size = New System.Drawing.Size(91, 22)
        Me.txtTotalCompra.TabIndex = 290
        Me.txtTotalCompra.Text = "0.00"
        Me.txtTotalCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(394, 21)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(83, 16)
        Me.Label31.TabIndex = 289
        Me.Label31.Text = "Total compra:"
        '
        'cboTipoCompra
        '
        Me.cboTipoCompra.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboTipoCompra.FormattingEnabled = True
        Me.cboTipoCompra.Items.AddRange(New Object() {"soles", "dolares"})
        Me.cboTipoCompra.Location = New System.Drawing.Point(6, 79)
        Me.cboTipoCompra.Name = "cboTipoCompra"
        Me.cboTipoCompra.Size = New System.Drawing.Size(154, 24)
        Me.cboTipoCompra.TabIndex = 105
        '
        'lblTipoDeCambio
        '
        Me.lblTipoDeCambio.AutoSize = True
        Me.lblTipoDeCambio.Location = New System.Drawing.Point(526, 63)
        Me.lblTipoDeCambio.Name = "lblTipoDeCambio"
        Me.lblTipoDeCambio.Size = New System.Drawing.Size(28, 16)
        Me.lblTipoDeCambio.TabIndex = 284
        Me.lblTipoDeCambio.Text = "T.C:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(392, 63)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(59, 16)
        Me.Label29.TabIndex = 285
        Me.Label29.Text = "Moneda:"
        '
        'txtCuentaP
        '
        Me.txtCuentaP.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtCuentaP.Location = New System.Drawing.Point(6, 38)
        Me.txtCuentaP.Name = "txtCuentaP"
        Me.txtCuentaP.Size = New System.Drawing.Size(60, 21)
        Me.txtCuentaP.TabIndex = 118
        Me.txtCuentaP.Text = "421"
        Me.txtCuentaP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboMoneda
        '
        Me.cboMoneda.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Items.AddRange(New Object() {"soles", "dolares"})
        Me.cboMoneda.Location = New System.Drawing.Point(395, 79)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(128, 24)
        Me.cboMoneda.TabIndex = 282
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCambio.ForeColor = System.Drawing.Color.Black
        Me.txtTipoCambio.Location = New System.Drawing.Point(529, 81)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Size = New System.Drawing.Size(45, 21)
        Me.txtTipoCambio.TabIndex = 283
        Me.txtTipoCambio.Text = "0"
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(135, 16)
        Me.Label15.TabIndex = 117
        Me.Label15.Text = "N° Cuenta - Proveedor:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 64)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(77, 16)
        Me.Label19.TabIndex = 106
        Me.Label19.Text = "Forma pago:"
        '
        'txtSerie
        '
        Me.txtSerie.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtSerie.Location = New System.Drawing.Point(165, 36)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(50, 21)
        Me.txtSerie.TabIndex = 4
        Me.txtSerie.Text = "0"
        Me.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(162, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Serie:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 16)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "Tipo Documento:"
        '
        'chkAsiento
        '
        Me.chkAsiento.Location = New System.Drawing.Point(628, 67)
        Me.chkAsiento.Name = "chkAsiento"
        Me.chkAsiento.Size = New System.Drawing.Size(125, 36)
        Me.chkAsiento.TabIndex = 302
        Me.chkAsiento.Text = "Mostrar Asiento de Transferencia"
        Me.chkAsiento.UseVisualStyleBackColor = True
        '
        'panelPago
        '
        Me.panelPago.Controls.Add(Me.dtFecImpuesto)
        Me.panelPago.Controls.Add(Me.Label13)
        Me.panelPago.Controls.Add(Me.txtNumeroImpuesto)
        Me.panelPago.Controls.Add(Me.txtPorcentaje)
        Me.panelPago.Controls.Add(Me.Label2)
        Me.panelPago.Controls.Add(Me.lblCuentaPago)
        Me.panelPago.Controls.Add(Me.txtMontoPago)
        Me.panelPago.Controls.Add(Me.btnCargarDatos)
        Me.panelPago.Controls.Add(Me.Label33)
        Me.panelPago.Controls.Add(Me.txtCuentaPago)
        Me.panelPago.Controls.Add(Me.Label23)
        Me.panelPago.Controls.Add(Me.Label21)
        Me.panelPago.Controls.Add(Me.Label7)
        Me.panelPago.Controls.Add(Me.txtDescripcionPago)
        Me.panelPago.Controls.Add(Me.Label6)
        Me.panelPago.Controls.Add(Me.cboSerieImpuesto)
        Me.panelPago.Controls.Add(Me.cboImpuestos)
        Me.panelPago.Controls.Add(Me.Label20)
        Me.panelPago.Controls.Add(Me.panelDetraccion)
        Me.panelPago.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelPago.Location = New System.Drawing.Point(12, 297)
        Me.panelPago.Name = "panelPago"
        Me.panelPago.Size = New System.Drawing.Size(760, 112)
        Me.panelPago.TabIndex = 254
        Me.panelPago.TabStop = False
        Me.panelPago.Text = "PAGO DE COMPROBANTE"
        '
        'dtFecImpuesto
        '
        Me.dtFecImpuesto.CalendarFont = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecImpuesto.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecImpuesto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecImpuesto.Location = New System.Drawing.Point(399, 83)
        Me.dtFecImpuesto.Name = "dtFecImpuesto"
        Me.dtFecImpuesto.Size = New System.Drawing.Size(94, 22)
        Me.dtFecImpuesto.TabIndex = 301
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(396, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 16)
        Me.Label13.TabIndex = 302
        Me.Label13.Text = "Fecha emisión:"
        '
        'txtNumeroImpuesto
        '
        Me.txtNumeroImpuesto.Font = New System.Drawing.Font("Century Gothic", 9.25!, System.Drawing.FontStyle.Bold)
        Me.txtNumeroImpuesto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtNumeroImpuesto.Location = New System.Drawing.Point(303, 82)
        Me.txtNumeroImpuesto.Name = "txtNumeroImpuesto"
        Me.txtNumeroImpuesto.Size = New System.Drawing.Size(90, 23)
        Me.txtNumeroImpuesto.TabIndex = 260
        Me.txtNumeroImpuesto.Text = "0"
        Me.txtNumeroImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.BackColor = System.Drawing.SystemColors.Info
        Me.txtPorcentaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPorcentaje.Enabled = False
        Me.txtPorcentaje.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtPorcentaje.ForeColor = System.Drawing.Color.Maroon
        Me.txtPorcentaje.Location = New System.Drawing.Point(154, 84)
        Me.txtPorcentaje.Multiline = True
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.Size = New System.Drawing.Size(57, 20)
        Me.txtPorcentaje.TabIndex = 296
        Me.txtPorcentaje.Text = "0"
        Me.txtPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 16)
        Me.Label2.TabIndex = 295
        Me.Label2.Text = "(%):"
        '
        'lblCuentaPago
        '
        Me.lblCuentaPago.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblCuentaPago.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblCuentaPago.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentaPago.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblCuentaPago.Location = New System.Drawing.Point(69, 35)
        Me.lblCuentaPago.Multiline = True
        Me.lblCuentaPago.Name = "lblCuentaPago"
        Me.lblCuentaPago.Size = New System.Drawing.Size(160, 21)
        Me.lblCuentaPago.TabIndex = 294
        '
        'txtMontoPago
        '
        Me.txtMontoPago.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtMontoPago.ForeColor = System.Drawing.Color.Black
        Me.txtMontoPago.Location = New System.Drawing.Point(236, 34)
        Me.txtMontoPago.Name = "txtMontoPago"
        Me.txtMontoPago.Size = New System.Drawing.Size(75, 22)
        Me.txtMontoPago.TabIndex = 276
        Me.txtMontoPago.Text = "0.00"
        Me.txtMontoPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCargarDatos
        '
        Me.btnCargarDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCargarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargarDatos.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnCargarDatos.ForeColor = System.Drawing.Color.White
        Me.btnCargarDatos.Location = New System.Drawing.Point(672, 26)
        Me.btnCargarDatos.Name = "btnCargarDatos"
        Me.btnCargarDatos.Size = New System.Drawing.Size(82, 35)
        Me.btnCargarDatos.TabIndex = 272
        Me.btnCargarDatos.Text = "AGREGAR"
        Me.btnCargarDatos.UseVisualStyleBackColor = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(233, 16)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(47, 16)
        Me.Label33.TabIndex = 275
        Me.Label33.Text = "Monto:"
        '
        'txtCuentaPago
        '
        Me.txtCuentaPago.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaPago.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtCuentaPago.Location = New System.Drawing.Point(6, 35)
        Me.txtCuentaPago.Name = "txtCuentaPago"
        Me.txtCuentaPago.Size = New System.Drawing.Size(60, 21)
        Me.txtCuentaPago.TabIndex = 273
        Me.txtCuentaPago.Text = "101"
        Me.txtCuentaPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(3, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(68, 16)
        Me.Label23.TabIndex = 272
        Me.Label23.Text = "N° Cuenta:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(300, 64)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(93, 16)
        Me.Label21.TabIndex = 270
        Me.Label21.Text = "N° / Operación:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(317, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 16)
        Me.Label7.TabIndex = 268
        Me.Label7.Text = "Descripción:"
        '
        'txtDescripcionPago
        '
        Me.txtDescripcionPago.Font = New System.Drawing.Font("Century Gothic", 9.25!)
        Me.txtDescripcionPago.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDescripcionPago.Location = New System.Drawing.Point(317, 33)
        Me.txtDescripcionPago.MaxLength = 1000
        Me.txtDescripcionPago.Name = "txtDescripcionPago"
        Me.txtDescripcionPago.Size = New System.Drawing.Size(333, 23)
        Me.txtDescripcionPago.TabIndex = 267
        Me.txtDescripcionPago.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(214, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 16)
        Me.Label6.TabIndex = 261
        Me.Label6.Text = "Serie:"
        '
        'cboSerieImpuesto
        '
        Me.cboSerieImpuesto.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSerieImpuesto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboSerieImpuesto.FormattingEnabled = True
        Me.cboSerieImpuesto.Location = New System.Drawing.Point(217, 82)
        Me.cboSerieImpuesto.Name = "cboSerieImpuesto"
        Me.cboSerieImpuesto.Size = New System.Drawing.Size(80, 24)
        Me.cboSerieImpuesto.TabIndex = 259
        '
        'cboImpuestos
        '
        Me.cboImpuestos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboImpuestos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboImpuestos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboImpuestos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboImpuestos.FormattingEnabled = True
        Me.cboImpuestos.Location = New System.Drawing.Point(6, 82)
        Me.cboImpuestos.Name = "cboImpuestos"
        Me.cboImpuestos.Size = New System.Drawing.Size(142, 24)
        Me.cboImpuestos.TabIndex = 256
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 64)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(55, 16)
        Me.Label20.TabIndex = 255
        Me.Label20.Text = "Sujeto a:"
        '
        'panelDetraccion
        '
        Me.panelDetraccion.Controls.Add(Me.lblDetraccion)
        Me.panelDetraccion.Controls.Add(Me.txtCDetraccion)
        Me.panelDetraccion.Controls.Add(Me.Label8)
        Me.panelDetraccion.Enabled = False
        Me.panelDetraccion.Location = New System.Drawing.Point(495, 61)
        Me.panelDetraccion.Name = "panelDetraccion"
        Me.panelDetraccion.Size = New System.Drawing.Size(262, 47)
        Me.panelDetraccion.TabIndex = 300
        '
        'lblDetraccion
        '
        Me.lblDetraccion.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblDetraccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblDetraccion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetraccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblDetraccion.Location = New System.Drawing.Point(69, 22)
        Me.lblDetraccion.Multiline = True
        Me.lblDetraccion.Name = "lblDetraccion"
        Me.lblDetraccion.Size = New System.Drawing.Size(190, 21)
        Me.lblDetraccion.TabIndex = 302
        '
        'txtCDetraccion
        '
        Me.txtCDetraccion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCDetraccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtCDetraccion.Location = New System.Drawing.Point(6, 22)
        Me.txtCDetraccion.Name = "txtCDetraccion"
        Me.txtCDetraccion.Size = New System.Drawing.Size(60, 21)
        Me.txtCDetraccion.TabIndex = 301
        Me.txtCDetraccion.Text = "104"
        Me.txtCDetraccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 16)
        Me.Label8.TabIndex = 300
        Me.Label8.Text = "N° Cuenta:"
        '
        'dgvOperaciones
        '
        Me.dgvOperaciones.AllowUserToAddRows = False
        Me.dgvOperaciones.BackgroundColor = System.Drawing.Color.White
        Me.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOperaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num_cuenta, Me.desc_cuenta, Me.debe, Me.haber, Me.descripcion, Me.impuesto, Me.serie, Me.numero, Me.operacion})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOperaciones.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvOperaciones.Location = New System.Drawing.Point(6, 20)
        Me.dgvOperaciones.Name = "dgvOperaciones"
        Me.dgvOperaciones.Size = New System.Drawing.Size(747, 222)
        Me.dgvOperaciones.TabIndex = 273
        '
        'num_cuenta
        '
        Me.num_cuenta.DataPropertyName = "num_cuenta"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.num_cuenta.DefaultCellStyle = DataGridViewCellStyle1
        Me.num_cuenta.HeaderText = "N° Cta."
        Me.num_cuenta.Name = "num_cuenta"
        Me.num_cuenta.Width = 75
        '
        'desc_cuenta
        '
        Me.desc_cuenta.DataPropertyName = "desc_cuenta"
        Me.desc_cuenta.HeaderText = "Desc. Cuenta"
        Me.desc_cuenta.Name = "desc_cuenta"
        Me.desc_cuenta.Width = 245
        '
        'debe
        '
        Me.debe.DataPropertyName = "debe"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.debe.DefaultCellStyle = DataGridViewCellStyle2
        Me.debe.HeaderText = "Debe"
        Me.debe.Name = "debe"
        Me.debe.Width = 90
        '
        'haber
        '
        Me.haber.DataPropertyName = "haber"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.haber.DefaultCellStyle = DataGridViewCellStyle3
        Me.haber.HeaderText = "Haber"
        Me.haber.Name = "haber"
        Me.haber.Width = 90
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.descripcion.DefaultCellStyle = DataGridViewCellStyle4
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Width = 185
        '
        'impuesto
        '
        Me.impuesto.DataPropertyName = "impuesto"
        Me.impuesto.HeaderText = "impuesto"
        Me.impuesto.Name = "impuesto"
        Me.impuesto.Visible = False
        '
        'serie
        '
        Me.serie.DataPropertyName = "serie"
        Me.serie.HeaderText = "serie"
        Me.serie.Name = "serie"
        Me.serie.Visible = False
        '
        'numero
        '
        Me.numero.DataPropertyName = "numero"
        Me.numero.HeaderText = "numero"
        Me.numero.Name = "numero"
        Me.numero.Visible = False
        '
        'operacion
        '
        Me.operacion.DataPropertyName = "operacion"
        Me.operacion.HeaderText = "operacion"
        Me.operacion.Name = "operacion"
        Me.operacion.Visible = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(434, 245)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(65, 16)
        Me.Label25.TabIndex = 280
        Me.Label25.Text = "Diferencia:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(341, 245)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(74, 16)
        Me.Label26.TabIndex = 279
        Me.Label26.Text = "Total Haber:"
        '
        'txtDiferenciaS
        '
        Me.txtDiferenciaS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDiferenciaS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferenciaS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDiferenciaS.Location = New System.Drawing.Point(437, 262)
        Me.txtDiferenciaS.Name = "txtDiferenciaS"
        Me.txtDiferenciaS.Size = New System.Drawing.Size(87, 21)
        Me.txtDiferenciaS.TabIndex = 276
        Me.txtDiferenciaS.Text = "0"
        Me.txtDiferenciaS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(248, 245)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(70, 16)
        Me.Label27.TabIndex = 278
        Me.Label27.Text = "Total Debe:"
        '
        'txtTHaberS
        '
        Me.txtTHaberS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTHaberS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTHaberS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTHaberS.Location = New System.Drawing.Point(344, 262)
        Me.txtTHaberS.Name = "txtTHaberS"
        Me.txtTHaberS.Size = New System.Drawing.Size(87, 21)
        Me.txtTHaberS.TabIndex = 275
        Me.txtTHaberS.Text = "0"
        Me.txtTHaberS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTDebeS
        '
        Me.txtTDebeS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTDebeS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTDebeS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTDebeS.Location = New System.Drawing.Point(251, 262)
        Me.txtTDebeS.Name = "txtTDebeS"
        Me.txtTDebeS.Size = New System.Drawing.Size(87, 21)
        Me.txtTDebeS.TabIndex = 274
        Me.txtTDebeS.Text = "0"
        Me.txtTDebeS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'panelAsientos
        '
        Me.panelAsientos.Controls.Add(Me.btnFinalizar)
        Me.panelAsientos.Controls.Add(Me.Button1)
        Me.panelAsientos.Controls.Add(Me.Panel2)
        Me.panelAsientos.Controls.Add(Me.Panel1)
        Me.panelAsientos.Controls.Add(Me.dgvOperaciones)
        Me.panelAsientos.Controls.Add(Me.Label25)
        Me.panelAsientos.Controls.Add(Me.btnCancelar)
        Me.panelAsientos.Controls.Add(Me.btnGrabar)
        Me.panelAsientos.Controls.Add(Me.Label27)
        Me.panelAsientos.Controls.Add(Me.Label26)
        Me.panelAsientos.Controls.Add(Me.txtTDebeS)
        Me.panelAsientos.Controls.Add(Me.txtDiferenciaS)
        Me.panelAsientos.Controls.Add(Me.txtTHaberS)
        Me.panelAsientos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelAsientos.Location = New System.Drawing.Point(12, 415)
        Me.panelAsientos.Name = "panelAsientos"
        Me.panelAsientos.Size = New System.Drawing.Size(760, 289)
        Me.panelAsientos.TabIndex = 282
        Me.panelAsientos.TabStop = False
        Me.panelAsientos.Text = "ASIENTOS CONTABLES"
        '
        'btnFinalizar
        '
        Me.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnFinalizar.ForeColor = System.Drawing.Color.White
        Me.btnFinalizar.Location = New System.Drawing.Point(658, 248)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(95, 35)
        Me.btnFinalizar.TabIndex = 282
        Me.btnFinalizar.Text = "FINALIZAR"
        Me.btnFinalizar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(105, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 35)
        Me.Button1.TabIndex = 281
        Me.Button1.Text = "LISTA COMPRAS"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel2.Location = New System.Drawing.Point(461, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(36, 222)
        Me.Panel2.TabIndex = 278
        Me.Panel2.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Location = New System.Drawing.Point(331, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(34, 222)
        Me.Panel1.TabIndex = 277
        Me.Panel1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCuentaP)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.lblCuenta)
        Me.GroupBox1.Controls.Add(Me.txtTotalCompra)
        Me.GroupBox1.Controls.Add(Me.panelPercepcion)
        Me.GroupBox1.Controls.Add(Me.txtGlosa)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(760, 92)
        Me.GroupBox1.TabIndex = 283
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MONTO TOTAL DEL COMPROBANTE DE COMPRA"
        '
        'dtFechaPago
        '
        Me.dtFechaPago.CalendarFont = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaPago.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaPago.Location = New System.Drawing.Point(276, 81)
        Me.dtFechaPago.Name = "dtFechaPago"
        Me.dtFechaPago.Size = New System.Drawing.Size(105, 22)
        Me.dtFechaPago.TabIndex = 305
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(273, 65)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(78, 16)
        Me.Label28.TabIndex = 306
        Me.Label28.Text = "Fecha pago:"
        '
        'dtFechaEmision
        '
        Me.dtFechaEmision.CalendarFont = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaEmision.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaEmision.Location = New System.Drawing.Point(165, 81)
        Me.dtFechaEmision.Name = "dtFechaEmision"
        Me.dtFechaEmision.Size = New System.Drawing.Size(105, 22)
        Me.dtFechaEmision.TabIndex = 303
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(162, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 304
        Me.Label1.Text = "Fecha emisión:"
        '
        'frmModificarCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 716)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.panelCuenta)
        Me.Controls.Add(Me.panelAsientos)
        Me.Controls.Add(Me.panelPago)
        Me.Controls.Add(Me.GroupBox2)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmModificarCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificación del Comprobante de Compra"
        Me.panelCuenta.ResumeLayout(False)
        Me.panelCuenta.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.panelPercepcion.ResumeLayout(False)
        Me.panelPercepcion.PerformLayout()
        Me.panelPago.ResumeLayout(False)
        Me.panelPago.PerformLayout()
        Me.panelDetraccion.ResumeLayout(False)
        Me.panelDetraccion.PerformLayout()
        CType(Me.dgvOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelAsientos.ResumeLayout(False)
        Me.panelAsientos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents cboOperacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMontoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtGlosa As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarRuc As System.Windows.Forms.Button
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents panelCuenta As System.Windows.Forms.GroupBox
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cboTipoCompra As System.Windows.Forms.ComboBox
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaP As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents panelPago As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionPago As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnAgregarCuenta As System.Windows.Forms.Button
    Friend WithEvents cboSerieImpuesto As System.Windows.Forms.ComboBox
    Friend WithEvents txtNumeroImpuesto As System.Windows.Forms.TextBox
    Friend WithEvents cboImpuestos As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnCargarDatos As System.Windows.Forms.Button
    Friend WithEvents dgvOperaciones As System.Windows.Forms.DataGridView
    Friend WithEvents txtCuentaPago As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cboCentroCosto As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtDiferenciaS As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtTHaberS As System.Windows.Forms.TextBox
    Friend WithEvents txtTDebeS As System.Windows.Forms.TextBox
    Friend WithEvents lblTipoDeCambio As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents txtTipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtMontoPago As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents panelAsientos As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblCuenta As System.Windows.Forms.TextBox
    Friend WithEvents lblNomCuenta As System.Windows.Forms.TextBox
    Friend WithEvents lblCuentaPago As System.Windows.Forms.TextBox
    Friend WithEvents cboDH As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents btnVentana As System.Windows.Forms.Button
    Friend WithEvents num_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents impuesto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents operacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtPorcentaje As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents panelDetraccion As System.Windows.Forms.Panel
    Friend WithEvents lblDetraccion As System.Windows.Forms.TextBox
    Friend WithEvents txtCDetraccion As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtFecImpuesto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents panelPercepcion As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtPorcPercep As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cboPercepcion As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents cboTipoPercepcion As System.Windows.Forms.ComboBox
    Friend WithEvents btnFinalizar As System.Windows.Forms.Button
    Friend WithEvents chkAsiento As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtFechaPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents dtFechaEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
