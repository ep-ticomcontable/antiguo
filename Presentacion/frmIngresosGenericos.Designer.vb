<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresosGenericos
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkPagar = New System.Windows.Forms.CheckBox()
        Me.lblComprobante = New System.Windows.Forms.Label()
        Me.cboAjuste = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAnexar = New System.Windows.Forms.Button()
        Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGlosa = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTipoDeCambio = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.dtFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.txtTipoCambio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTipoOperacion = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboBancos = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cboDH = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.lblNomCuenta = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTituloForm = New System.Windows.Forms.Label()
        Me.dgvOperaciones = New System.Windows.Forms.DataGridView()
        Me.num_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_centro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_caja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtTHaberS = New System.Windows.Forms.TextBox()
        Me.txtTDebeS = New System.Windows.Forms.TextBox()
        Me.txtDiferenciaS = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCentro = New System.Windows.Forms.Button()
        Me.txtIdCentro = New System.Windows.Forms.TextBox()
        Me.txtCentro = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNumOperacion = New System.Windows.Forms.TextBox()
        Me.txtIdComprobante = New System.Windows.Forms.TextBox()
        Me.panelComprobante = New System.Windows.Forms.Panel()
        Me.txtTotalC = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtMoneda = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtNC = New System.Windows.Forms.TextBox()
        Me.txtSC = New System.Windows.Forms.TextBox()
        Me.txtGlosaC = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtFechaC = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnCerrarComprobante = New System.Windows.Forms.Button()
        Me.lblTitComprobante = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.panelComprobante.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkPagar)
        Me.GroupBox2.Controls.Add(Me.lblComprobante)
        Me.GroupBox2.Controls.Add(Me.cboAjuste)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnAnexar)
        Me.GroupBox2.Controls.Add(Me.cboTipoDocumento)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtSerie)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtNumero)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtGlosa)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblTipoDeCambio)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.dtFechaEmision)
        Me.GroupBox2.Controls.Add(Me.cboMoneda)
        Me.GroupBox2.Controls.Add(Me.txtTipoCambio)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cboTipoOperacion)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(660, 108)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS PRINCIPALES"
        '
        'chkPagar
        '
        Me.chkPagar.AutoSize = True
        Me.chkPagar.Location = New System.Drawing.Point(589, 82)
        Me.chkPagar.Name = "chkPagar"
        Me.chkPagar.Size = New System.Drawing.Size(65, 20)
        Me.chkPagar.TabIndex = 336
        Me.chkPagar.Text = "PAGAR"
        Me.chkPagar.UseVisualStyleBackColor = True
        '
        'lblComprobante
        '
        Me.lblComprobante.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblComprobante.Font = New System.Drawing.Font("Century Gothic", 7.0!)
        Me.lblComprobante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblComprobante.Location = New System.Drawing.Point(396, 36)
        Me.lblComprobante.Name = "lblComprobante"
        Me.lblComprobante.Size = New System.Drawing.Size(73, 21)
        Me.lblComprobante.TabIndex = 335
        Me.lblComprobante.Text = "Comprob..."
        Me.lblComprobante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboAjuste
        '
        Me.cboAjuste.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAjuste.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAjuste.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAjuste.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboAjuste.FormattingEnabled = True
        Me.cboAjuste.Location = New System.Drawing.Point(6, 35)
        Me.cboAjuste.Name = "cboAjuste"
        Me.cboAjuste.Size = New System.Drawing.Size(223, 24)
        Me.cboAjuste.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 16)
        Me.Label3.TabIndex = 333
        Me.Label3.Text = "Motivo Ajuste:"
        '
        'btnAnexar
        '
        Me.btnAnexar.BackColor = System.Drawing.Color.Gray
        Me.btnAnexar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnexar.Font = New System.Drawing.Font("Century Gothic", 6.0!, System.Drawing.FontStyle.Bold)
        Me.btnAnexar.ForeColor = System.Drawing.Color.White
        Me.btnAnexar.Location = New System.Drawing.Point(368, 35)
        Me.btnAnexar.Name = "btnAnexar"
        Me.btnAnexar.Size = New System.Drawing.Size(32, 23)
        Me.btnAnexar.TabIndex = 334
        Me.btnAnexar.Text = "[+]"
        Me.btnAnexar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAnexar.UseVisualStyleBackColor = False
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTipoDocumento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoDocumento.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocumento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboTipoDocumento.FormattingEnabled = True
        Me.cboTipoDocumento.Location = New System.Drawing.Point(475, 35)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(97, 24)
        Me.cboTipoDocumento.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(472, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 16)
        Me.Label9.TabIndex = 331
        Me.Label9.Text = "Tipo Documento:"
        '
        'txtSerie
        '
        Me.txtSerie.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtSerie.Location = New System.Drawing.Point(578, 38)
        Me.txtSerie.MaxLength = 4
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(35, 21)
        Me.txtSerie.TabIndex = 10
        Me.txtSerie.Text = "0"
        Me.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(575, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 318
        Me.Label4.Text = "Serie:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(617, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(23, 16)
        Me.Label12.TabIndex = 317
        Me.Label12.Text = "N°:"
        '
        'txtNumero
        '
        Me.txtNumero.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtNumero.Location = New System.Drawing.Point(619, 38)
        Me.txtNumero.MaxLength = 4
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(35, 21)
        Me.txtNumero.TabIndex = 10
        Me.txtNumero.Text = "0"
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(365, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 315
        Me.Label5.Text = "Anexar Doc:"
        '
        'txtGlosa
        '
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtGlosa.Location = New System.Drawing.Point(226, 80)
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(346, 21)
        Me.txtGlosa.TabIndex = 9
        Me.txtGlosa.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(223, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 16)
        Me.Label7.TabIndex = 310
        Me.Label7.Text = "Glosa / Motivo:"
        '
        'lblTipoDeCambio
        '
        Me.lblTipoDeCambio.AutoSize = True
        Me.lblTipoDeCambio.Location = New System.Drawing.Point(173, 62)
        Me.lblTipoDeCambio.Name = "lblTipoDeCambio"
        Me.lblTipoDeCambio.Size = New System.Drawing.Size(30, 16)
        Me.lblTipoDeCambio.TabIndex = 284
        Me.lblTipoDeCambio.Text = "T/C:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(114, 63)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(59, 16)
        Me.Label29.TabIndex = 285
        Me.Label29.Text = "Moneda:"
        '
        'dtFechaEmision
        '
        Me.dtFechaEmision.CalendarFont = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaEmision.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaEmision.Location = New System.Drawing.Point(6, 79)
        Me.dtFechaEmision.Name = "dtFechaEmision"
        Me.dtFechaEmision.Size = New System.Drawing.Size(105, 22)
        Me.dtFechaEmision.TabIndex = 6
        '
        'cboMoneda
        '
        Me.cboMoneda.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Items.AddRange(New Object() {"soles", "dolares"})
        Me.cboMoneda.Location = New System.Drawing.Point(117, 79)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(53, 24)
        Me.cboMoneda.TabIndex = 7
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCambio.ForeColor = System.Drawing.Color.Black
        Me.txtTipoCambio.Location = New System.Drawing.Point(176, 80)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Size = New System.Drawing.Size(44, 21)
        Me.txtTipoCambio.TabIndex = 8
        Me.txtTipoCambio.Text = "0.00"
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Fecha emisión:"
        '
        'cboTipoOperacion
        '
        Me.cboTipoOperacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTipoOperacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoOperacion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoOperacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboTipoOperacion.FormattingEnabled = True
        Me.cboTipoOperacion.Location = New System.Drawing.Point(235, 35)
        Me.cboTipoOperacion.Name = "cboTipoOperacion"
        Me.cboTipoOperacion.Size = New System.Drawing.Size(128, 24)
        Me.cboTipoOperacion.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(232, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 16)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "Tipo Operación:"
        '
        'cboBancos
        '
        Me.cboBancos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBancos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboBancos.FormattingEnabled = True
        Me.cboBancos.Items.AddRange(New Object() {"soles", "dolares"})
        Me.cboBancos.Location = New System.Drawing.Point(495, 29)
        Me.cboBancos.Name = "cboBancos"
        Me.cboBancos.Size = New System.Drawing.Size(63, 24)
        Me.cboBancos.TabIndex = 100
        Me.cboBancos.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(492, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 334
        Me.Label2.Text = "Banco:"
        Me.Label2.Visible = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Green
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(537, 31)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(117, 29)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "AGREGAR CUENTA"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'cboDH
        '
        Me.cboDH.BackColor = System.Drawing.Color.White
        Me.cboDH.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.cboDH.FormattingEnabled = True
        Me.cboDH.Location = New System.Drawing.Point(461, 34)
        Me.cboDH.Name = "cboDH"
        Me.cboDH.Size = New System.Drawing.Size(59, 24)
        Me.cboDH.TabIndex = 4
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(458, 19)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(31, 15)
        Me.Label24.TabIndex = 100
        Me.Label24.Text = "D/H:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(377, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 100
        Me.Label8.Text = "Monto:"
        '
        'txtMonto
        '
        Me.txtMonto.BackColor = System.Drawing.Color.White
        Me.txtMonto.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtMonto.Location = New System.Drawing.Point(380, 35)
        Me.txtMonto.MaxLength = 11
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(75, 21)
        Me.txtMonto.TabIndex = 3
        Me.txtMonto.Text = "0.00"
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCuenta
        '
        Me.txtCuenta.BackColor = System.Drawing.Color.White
        Me.txtCuenta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtCuenta.Location = New System.Drawing.Point(6, 35)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(50, 21)
        Me.txtCuenta.TabIndex = 1
        Me.txtCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNomCuenta
        '
        Me.lblNomCuenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNomCuenta.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.lblNomCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblNomCuenta.Location = New System.Drawing.Point(56, 35)
        Me.lblNomCuenta.Name = "lblNomCuenta"
        Me.lblNomCuenta.Size = New System.Drawing.Size(175, 21)
        Me.lblNomCuenta.TabIndex = 100
        Me.lblNomCuenta.Text = "[Nombre Cuenta]"
        Me.lblNomCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 16)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Cuenta:"
        '
        'lblTituloForm
        '
        Me.lblTituloForm.AutoSize = True
        Me.lblTituloForm.BackColor = System.Drawing.Color.Transparent
        Me.lblTituloForm.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblTituloForm.Location = New System.Drawing.Point(-8, 1)
        Me.lblTituloForm.Name = "lblTituloForm"
        Me.lblTituloForm.Padding = New System.Windows.Forms.Padding(10)
        Me.lblTituloForm.Size = New System.Drawing.Size(393, 59)
        Me.lblTituloForm.TabIndex = 0
        Me.lblTituloForm.Text = "REGISTROS GENÉRICOS"
        '
        'dgvOperaciones
        '
        Me.dgvOperaciones.AllowUserToAddRows = False
        Me.dgvOperaciones.BackgroundColor = System.Drawing.Color.White
        Me.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOperaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num_cuenta, Me.desc_cuenta, Me.debe, Me.haber, Me.id_centro, Me.id_caja})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOperaciones.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvOperaciones.Location = New System.Drawing.Point(12, 250)
        Me.dgvOperaciones.Name = "dgvOperaciones"
        Me.dgvOperaciones.Size = New System.Drawing.Size(660, 158)
        Me.dgvOperaciones.TabIndex = 100
        '
        'num_cuenta
        '
        Me.num_cuenta.DataPropertyName = "num_cuenta"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.num_cuenta.DefaultCellStyle = DataGridViewCellStyle1
        Me.num_cuenta.HeaderText = "Cta."
        Me.num_cuenta.Name = "num_cuenta"
        Me.num_cuenta.Width = 70
        '
        'desc_cuenta
        '
        Me.desc_cuenta.DataPropertyName = "desc_cuenta"
        Me.desc_cuenta.HeaderText = "Desc."
        Me.desc_cuenta.Name = "desc_cuenta"
        Me.desc_cuenta.Width = 288
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
        '
        'id_centro
        '
        Me.id_centro.DataPropertyName = "id_centro"
        Me.id_centro.HeaderText = "C.C"
        Me.id_centro.Name = "id_centro"
        Me.id_centro.Width = 40
        '
        'id_caja
        '
        Me.id_caja.DataPropertyName = "id_caja"
        Me.id_caja.HeaderText = "id_caja"
        Me.id_caja.Name = "id_caja"
        Me.id_caja.Visible = False
        '
        'btnFinalizar
        '
        Me.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnFinalizar.ForeColor = System.Drawing.Color.White
        Me.btnFinalizar.Location = New System.Drawing.Point(577, 414)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(95, 35)
        Me.btnFinalizar.TabIndex = 7
        Me.btnFinalizar.Text = "FINALIZAR"
        Me.btnFinalizar.UseVisualStyleBackColor = False
        '
        'btnGrabar
        '
        Me.btnGrabar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrabar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnGrabar.ForeColor = System.Drawing.Color.White
        Me.btnGrabar.Location = New System.Drawing.Point(487, 414)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(84, 35)
        Me.btnGrabar.TabIndex = 6
        Me.btnGrabar.Text = "GRABAR"
        Me.btnGrabar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(12, 414)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(93, 35)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(352, 411)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(65, 16)
        Me.Label25.TabIndex = 286
        Me.Label25.Text = "Diferencia:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(166, 411)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(70, 16)
        Me.Label27.TabIndex = 284
        Me.Label27.Text = "Total Debe:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(259, 411)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(74, 16)
        Me.Label26.TabIndex = 285
        Me.Label26.Text = "Total Haber:"
        '
        'txtTHaberS
        '
        Me.txtTHaberS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTHaberS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTHaberS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTHaberS.Location = New System.Drawing.Point(262, 428)
        Me.txtTHaberS.Name = "txtTHaberS"
        Me.txtTHaberS.Size = New System.Drawing.Size(87, 21)
        Me.txtTHaberS.TabIndex = 282
        Me.txtTHaberS.TabStop = False
        Me.txtTHaberS.Text = "0.00"
        Me.txtTHaberS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTDebeS
        '
        Me.txtTDebeS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTDebeS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTDebeS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTDebeS.Location = New System.Drawing.Point(169, 428)
        Me.txtTDebeS.Name = "txtTDebeS"
        Me.txtTDebeS.Size = New System.Drawing.Size(87, 21)
        Me.txtTDebeS.TabIndex = 281
        Me.txtTDebeS.TabStop = False
        Me.txtTDebeS.Text = "0.00"
        Me.txtTDebeS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiferenciaS
        '
        Me.txtDiferenciaS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDiferenciaS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferenciaS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDiferenciaS.Location = New System.Drawing.Point(355, 428)
        Me.txtDiferenciaS.Name = "txtDiferenciaS"
        Me.txtDiferenciaS.Size = New System.Drawing.Size(87, 21)
        Me.txtDiferenciaS.TabIndex = 283
        Me.txtDiferenciaS.TabStop = False
        Me.txtDiferenciaS.Text = "0.00"
        Me.txtDiferenciaS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnCentro)
        Me.GroupBox1.Controls.Add(Me.txtIdCentro)
        Me.GroupBox1.Controls.Add(Me.txtCentro)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.cboDH)
        Me.GroupBox1.Controls.Add(Me.txtCuenta)
        Me.GroupBox1.Controls.Add(Me.lblNomCuenta)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 173)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(660, 71)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESO DE CUENTAS CONTABLES"
        '
        'btnCentro
        '
        Me.btnCentro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCentro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCentro.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.btnCentro.ForeColor = System.Drawing.Color.White
        Me.btnCentro.Location = New System.Drawing.Point(341, 30)
        Me.btnCentro.Name = "btnCentro"
        Me.btnCentro.Size = New System.Drawing.Size(33, 29)
        Me.btnCentro.TabIndex = 2
        Me.btnCentro.Text = "[+]"
        Me.btnCentro.UseVisualStyleBackColor = False
        '
        'txtIdCentro
        '
        Me.txtIdCentro.BackColor = System.Drawing.Color.White
        Me.txtIdCentro.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCentro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtIdCentro.Location = New System.Drawing.Point(341, 10)
        Me.txtIdCentro.Name = "txtIdCentro"
        Me.txtIdCentro.Size = New System.Drawing.Size(22, 21)
        Me.txtIdCentro.TabIndex = 100
        Me.txtIdCentro.Text = "0"
        Me.txtIdCentro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtIdCentro.Visible = False
        '
        'txtCentro
        '
        Me.txtCentro.Location = New System.Drawing.Point(237, 34)
        Me.txtCentro.Name = "txtCentro"
        Me.txtCentro.Size = New System.Drawing.Size(111, 22)
        Me.txtCentro.TabIndex = 100
        Me.txtCentro.Text = "-"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(234, 20)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(95, 15)
        Me.Label22.TabIndex = 100
        Me.Label22.Text = "Centro de costo:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(561, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 17)
        Me.Label10.TabIndex = 336
        Me.Label10.Text = "N° Operación:"
        Me.Label10.Visible = False
        '
        'txtNumOperacion
        '
        Me.txtNumOperacion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumOperacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtNumOperacion.Location = New System.Drawing.Point(564, 29)
        Me.txtNumOperacion.MaxLength = 11
        Me.txtNumOperacion.Name = "txtNumOperacion"
        Me.txtNumOperacion.Size = New System.Drawing.Size(88, 21)
        Me.txtNumOperacion.TabIndex = 335
        Me.txtNumOperacion.Text = "0"
        Me.txtNumOperacion.Visible = False
        '
        'txtIdComprobante
        '
        Me.txtIdComprobante.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdComprobante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtIdComprobante.Location = New System.Drawing.Point(463, 29)
        Me.txtIdComprobante.MaxLength = 11
        Me.txtIdComprobante.Name = "txtIdComprobante"
        Me.txtIdComprobante.Size = New System.Drawing.Size(26, 21)
        Me.txtIdComprobante.TabIndex = 337
        Me.txtIdComprobante.Text = "0"
        Me.txtIdComprobante.Visible = False
        '
        'panelComprobante
        '
        Me.panelComprobante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelComprobante.Controls.Add(Me.txtTotalC)
        Me.panelComprobante.Controls.Add(Me.Label35)
        Me.panelComprobante.Controls.Add(Me.txtMoneda)
        Me.panelComprobante.Controls.Add(Me.Label39)
        Me.panelComprobante.Controls.Add(Me.txtNC)
        Me.panelComprobante.Controls.Add(Me.txtSC)
        Me.panelComprobante.Controls.Add(Me.txtGlosaC)
        Me.panelComprobante.Controls.Add(Me.Label33)
        Me.panelComprobante.Controls.Add(Me.txtFechaC)
        Me.panelComprobante.Controls.Add(Me.Label37)
        Me.panelComprobante.Controls.Add(Me.Label14)
        Me.panelComprobante.Controls.Add(Me.Label15)
        Me.panelComprobante.Controls.Add(Me.btnCerrarComprobante)
        Me.panelComprobante.Controls.Add(Me.lblTitComprobante)
        Me.panelComprobante.Location = New System.Drawing.Point(380, 1)
        Me.panelComprobante.Name = "panelComprobante"
        Me.panelComprobante.Size = New System.Drawing.Size(303, 90)
        Me.panelComprobante.TabIndex = 338
        Me.panelComprobante.Visible = False
        '
        'txtTotalC
        '
        Me.txtTotalC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalC.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.txtTotalC.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtTotalC.Location = New System.Drawing.Point(123, 37)
        Me.txtTotalC.Name = "txtTotalC"
        Me.txtTotalC.Size = New System.Drawing.Size(82, 14)
        Me.txtTotalC.TabIndex = 353
        Me.txtTotalC.Text = "0.00"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(117, 23)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(37, 16)
        Me.Label35.TabIndex = 352
        Me.Label35.Text = "Total:"
        '
        'txtMoneda
        '
        Me.txtMoneda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMoneda.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.txtMoneda.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtMoneda.Location = New System.Drawing.Point(82, 37)
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.Size = New System.Drawing.Size(31, 14)
        Me.txtMoneda.TabIndex = 351
        Me.txtMoneda.Text = "PEN"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(79, 23)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(38, 16)
        Me.Label39.TabIndex = 350
        Me.Label39.Text = "MND:"
        '
        'txtNC
        '
        Me.txtNC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNC.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.txtNC.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtNC.Location = New System.Drawing.Point(50, 37)
        Me.txtNC.Name = "txtNC"
        Me.txtNC.Size = New System.Drawing.Size(26, 14)
        Me.txtNC.TabIndex = 349
        Me.txtNC.Text = "0001"
        '
        'txtSC
        '
        Me.txtSC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSC.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.txtSC.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtSC.Location = New System.Drawing.Point(11, 37)
        Me.txtSC.Name = "txtSC"
        Me.txtSC.Size = New System.Drawing.Size(33, 14)
        Me.txtSC.TabIndex = 348
        Me.txtSC.Text = "0001"
        '
        'txtGlosaC
        '
        Me.txtGlosaC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGlosaC.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.txtGlosaC.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtGlosaC.Location = New System.Drawing.Point(11, 69)
        Me.txtGlosaC.Name = "txtGlosaC"
        Me.txtGlosaC.Size = New System.Drawing.Size(256, 14)
        Me.txtGlosaC.TabIndex = 347
        Me.txtGlosaC.Text = "[DATO CAMPO]"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(8, 54)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(42, 16)
        Me.Label33.TabIndex = 346
        Me.Label33.Text = "Glosa:"
        '
        'txtFechaC
        '
        Me.txtFechaC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFechaC.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.txtFechaC.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtFechaC.Location = New System.Drawing.Point(207, 37)
        Me.txtFechaC.Name = "txtFechaC"
        Me.txtFechaC.Size = New System.Drawing.Size(65, 14)
        Me.txtFechaC.TabIndex = 345
        Me.txtFechaC.Text = "13/12/2017"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(205, 22)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(45, 16)
        Me.Label37.TabIndex = 344
        Me.Label37.Text = "Fecha:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(8, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 16)
        Me.Label14.TabIndex = 336
        Me.Label14.Text = "Serie:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(47, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(23, 16)
        Me.Label15.TabIndex = 335
        Me.Label15.Text = "N°:"
        '
        'btnCerrarComprobante
        '
        Me.btnCerrarComprobante.BackColor = System.Drawing.Color.Red
        Me.btnCerrarComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarComprobante.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnCerrarComprobante.ForeColor = System.Drawing.Color.White
        Me.btnCerrarComprobante.Location = New System.Drawing.Point(273, 60)
        Me.btnCerrarComprobante.Name = "btnCerrarComprobante"
        Me.btnCerrarComprobante.Size = New System.Drawing.Size(29, 29)
        Me.btnCerrarComprobante.TabIndex = 3
        Me.btnCerrarComprobante.Text = "X"
        Me.btnCerrarComprobante.UseVisualStyleBackColor = False
        '
        'lblTitComprobante
        '
        Me.lblTitComprobante.AutoSize = True
        Me.lblTitComprobante.BackColor = System.Drawing.Color.Transparent
        Me.lblTitComprobante.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitComprobante.ForeColor = System.Drawing.Color.Black
        Me.lblTitComprobante.Location = New System.Drawing.Point(3, 3)
        Me.lblTitComprobante.Name = "lblTitComprobante"
        Me.lblTitComprobante.Size = New System.Drawing.Size(138, 17)
        Me.lblTitComprobante.TabIndex = 1
        Me.lblTitComprobante.Text = "COMPROBANTE DE "
        '
        'frmIngresosGenericos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.panelComprobante)
        Me.Controls.Add(Me.txtIdComprobante)
        Me.Controls.Add(Me.txtNumOperacion)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboBancos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txtTHaberS)
        Me.Controls.Add(Me.txtTDebeS)
        Me.Controls.Add(Me.txtDiferenciaS)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.dgvOperaciones)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblTituloForm)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmIngresosGenericos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTROS GENÉRICOS"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panelComprobante.ResumeLayout(False)
        Me.panelComprobante.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTipoDeCambio As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents dtFechaEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents txtTipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboTipoOperacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblTituloForm As System.Windows.Forms.Label
    Friend WithEvents dgvOperaciones As System.Windows.Forms.DataGridView
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblNomCuenta As System.Windows.Forms.Label
    Friend WithEvents txtGlosa As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents cboDH As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cboTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnFinalizar As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtTHaberS As System.Windows.Forms.TextBox
    Friend WithEvents txtTDebeS As System.Windows.Forms.TextBox
    Friend WithEvents txtDiferenciaS As System.Windows.Forms.TextBox
    Friend WithEvents cboBancos As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIdCentro As System.Windows.Forms.TextBox
    Friend WithEvents btnCentro As System.Windows.Forms.Button
    Friend WithEvents txtCentro As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents num_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_centro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_caja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboAjuste As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNumOperacion As System.Windows.Forms.TextBox
    Friend WithEvents lblComprobante As System.Windows.Forms.Label
    Friend WithEvents btnAnexar As System.Windows.Forms.Button
    Friend WithEvents txtIdComprobante As System.Windows.Forms.TextBox
    Friend WithEvents panelComprobante As System.Windows.Forms.Panel
    Friend WithEvents lblTitComprobante As System.Windows.Forms.Label
    Friend WithEvents btnCerrarComprobante As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtNC As System.Windows.Forms.TextBox
    Friend WithEvents txtSC As System.Windows.Forms.TextBox
    Friend WithEvents txtGlosaC As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtFechaC As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtTotalC As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtMoneda As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents chkPagar As System.Windows.Forms.CheckBox
End Class
