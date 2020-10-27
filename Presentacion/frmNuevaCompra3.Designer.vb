<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevaCompra3
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
        Me.dgvOperaciones = New System.Windows.Forms.DataGridView()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtDiferenciaS = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtTHaberS = New System.Windows.Forms.TextBox()
        Me.txtTDebeS = New System.Windows.Forms.TextBox()
        Me.panelPago = New System.Windows.Forms.GroupBox()
        Me.dtFecImpuesto = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtPorcentaje = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txtMontoPago = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescripcionPago = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.panelDetraccion = New System.Windows.Forms.Panel()
        Me.lblDetraccion = New System.Windows.Forms.TextBox()
        Me.txtCDetraccion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.operacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.banco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.movimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.operacion_banco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelPago.SuspendLayout()
        Me.panelDetraccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvOperaciones
        '
        Me.dgvOperaciones.AllowUserToAddRows = False
        Me.dgvOperaciones.BackgroundColor = System.Drawing.Color.White
        Me.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOperaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.debe, Me.haber, Me.descripcion, Me.impuesto, Me.serie, Me.numero, Me.operacion, Me.banco, Me.movimiento, Me.operacion_banco})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOperaciones.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvOperaciones.Location = New System.Drawing.Point(12, 130)
        Me.dgvOperaciones.Name = "dgvOperaciones"
        Me.dgvOperaciones.ReadOnly = True
        Me.dgvOperaciones.Size = New System.Drawing.Size(760, 163)
        Me.dgvOperaciones.TabIndex = 277
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(263, 296)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(79, 16)
        Me.Label25.TabIndex = 288
        Me.Label25.Text = "Diferencia S/."
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(136, 296)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(88, 16)
        Me.Label26.TabIndex = 287
        Me.Label26.Text = "Total Haber S/."
        '
        'txtDiferenciaS
        '
        Me.txtDiferenciaS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDiferenciaS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferenciaS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDiferenciaS.Location = New System.Drawing.Point(266, 315)
        Me.txtDiferenciaS.Name = "txtDiferenciaS"
        Me.txtDiferenciaS.Size = New System.Drawing.Size(121, 21)
        Me.txtDiferenciaS.TabIndex = 284
        Me.txtDiferenciaS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(9, 296)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(87, 16)
        Me.Label27.TabIndex = 286
        Me.Label27.Text = "Total Debe S/. "
        '
        'txtTHaberS
        '
        Me.txtTHaberS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTHaberS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTHaberS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTHaberS.Location = New System.Drawing.Point(139, 315)
        Me.txtTHaberS.Name = "txtTHaberS"
        Me.txtTHaberS.Size = New System.Drawing.Size(121, 21)
        Me.txtTHaberS.TabIndex = 283
        Me.txtTHaberS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTDebeS
        '
        Me.txtTDebeS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTDebeS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTDebeS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTDebeS.Location = New System.Drawing.Point(12, 315)
        Me.txtTDebeS.Name = "txtTDebeS"
        Me.txtTDebeS.Size = New System.Drawing.Size(121, 21)
        Me.txtTDebeS.TabIndex = 282
        Me.txtTDebeS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'panelPago
        '
        Me.panelPago.Controls.Add(Me.dtFecImpuesto)
        Me.panelPago.Controls.Add(Me.Label1)
        Me.panelPago.Controls.Add(Me.TextBox2)
        Me.panelPago.Controls.Add(Me.txtPorcentaje)
        Me.panelPago.Controls.Add(Me.Label2)
        Me.panelPago.Controls.Add(Me.TextBox3)
        Me.panelPago.Controls.Add(Me.txtMontoPago)
        Me.panelPago.Controls.Add(Me.Button1)
        Me.panelPago.Controls.Add(Me.Label33)
        Me.panelPago.Controls.Add(Me.TextBox4)
        Me.panelPago.Controls.Add(Me.Label3)
        Me.panelPago.Controls.Add(Me.Label4)
        Me.panelPago.Controls.Add(Me.Label5)
        Me.panelPago.Controls.Add(Me.txtDescripcionPago)
        Me.panelPago.Controls.Add(Me.Label8)
        Me.panelPago.Controls.Add(Me.ComboBox1)
        Me.panelPago.Controls.Add(Me.ComboBox2)
        Me.panelPago.Controls.Add(Me.Label9)
        Me.panelPago.Controls.Add(Me.panelDetraccion)
        Me.panelPago.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelPago.Location = New System.Drawing.Point(12, 12)
        Me.panelPago.Name = "panelPago"
        Me.panelPago.Size = New System.Drawing.Size(760, 112)
        Me.panelPago.TabIndex = 290
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(396, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 302
        Me.Label1.Text = "Fecha emisión:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 9.25!, System.Drawing.FontStyle.Bold)
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(303, 82)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(90, 23)
        Me.TextBox2.TabIndex = 260
        Me.TextBox2.Text = "0"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.TextBox3.Location = New System.Drawing.Point(69, 35)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(160, 21)
        Me.TextBox3.TabIndex = 294
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(672, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 35)
        Me.Button1.TabIndex = 272
        Me.Button1.Text = "AGREGAR"
        Me.Button1.UseVisualStyleBackColor = False
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
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.TextBox4.Location = New System.Drawing.Point(6, 35)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(60, 21)
        Me.TextBox4.TabIndex = 273
        Me.TextBox4.Text = "101"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 272
        Me.Label3.Text = "N° Cuenta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(300, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 16)
        Me.Label4.TabIndex = 270
        Me.Label4.Text = "N° / Operación:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(317, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 268
        Me.Label5.Text = "Descripción:"
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(214, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 16)
        Me.Label8.TabIndex = 261
        Me.Label8.Text = "Serie:"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(217, 82)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(80, 24)
        Me.ComboBox1.TabIndex = 259
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(6, 82)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(142, 24)
        Me.ComboBox2.TabIndex = 256
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 16)
        Me.Label9.TabIndex = 255
        Me.Label9.Text = "Sujeto a:"
        '
        'panelDetraccion
        '
        Me.panelDetraccion.Controls.Add(Me.lblDetraccion)
        Me.panelDetraccion.Controls.Add(Me.txtCDetraccion)
        Me.panelDetraccion.Controls.Add(Me.Label10)
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 16)
        Me.Label10.TabIndex = 300
        Me.Label10.Text = "N° Cuenta:"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "num_cuenta"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "N° Cta."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 75
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "desc_cuenta"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Desc. Cuenta"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 260
        '
        'debe
        '
        Me.debe.DataPropertyName = "debe"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.debe.DefaultCellStyle = DataGridViewCellStyle2
        Me.debe.HeaderText = "Debe"
        Me.debe.Name = "debe"
        Me.debe.ReadOnly = True
        Me.debe.Width = 90
        '
        'haber
        '
        Me.haber.DataPropertyName = "haber"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.haber.DefaultCellStyle = DataGridViewCellStyle3
        Me.haber.HeaderText = "Haber"
        Me.haber.Name = "haber"
        Me.haber.ReadOnly = True
        Me.haber.Width = 90
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.descripcion.DefaultCellStyle = DataGridViewCellStyle4
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 185
        '
        'impuesto
        '
        Me.impuesto.HeaderText = "impuesto"
        Me.impuesto.Name = "impuesto"
        Me.impuesto.ReadOnly = True
        Me.impuesto.Visible = False
        '
        'serie
        '
        Me.serie.HeaderText = "serie"
        Me.serie.Name = "serie"
        Me.serie.ReadOnly = True
        Me.serie.Visible = False
        '
        'numero
        '
        Me.numero.HeaderText = "numero"
        Me.numero.Name = "numero"
        Me.numero.ReadOnly = True
        Me.numero.Visible = False
        '
        'operacion
        '
        Me.operacion.DataPropertyName = "operacion"
        Me.operacion.HeaderText = "operacion"
        Me.operacion.Name = "operacion"
        Me.operacion.ReadOnly = True
        Me.operacion.Visible = False
        '
        'banco
        '
        Me.banco.DataPropertyName = "banco"
        Me.banco.HeaderText = "banco"
        Me.banco.Name = "banco"
        Me.banco.ReadOnly = True
        Me.banco.Visible = False
        '
        'movimiento
        '
        Me.movimiento.DataPropertyName = "movimiento"
        Me.movimiento.HeaderText = "movimiento"
        Me.movimiento.Name = "movimiento"
        Me.movimiento.ReadOnly = True
        Me.movimiento.Visible = False
        '
        'operacion_banco
        '
        Me.operacion_banco.DataPropertyName = "operacion_banco"
        Me.operacion_banco.HeaderText = "operacion_banco"
        Me.operacion_banco.Name = "operacion_banco"
        Me.operacion_banco.ReadOnly = True
        Me.operacion_banco.Visible = False
        '
        'frmNuevaCompra3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 350)
        Me.Controls.Add(Me.panelPago)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txtDiferenciaS)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtTHaberS)
        Me.Controls.Add(Me.txtTDebeS)
        Me.Controls.Add(Me.dgvOperaciones)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmNuevaCompra3"
        Me.Text = "frmNuevaCompra3"
        CType(Me.dgvOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelPago.ResumeLayout(False)
        Me.panelPago.PerformLayout()
        Me.panelDetraccion.ResumeLayout(False)
        Me.panelDetraccion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvOperaciones As System.Windows.Forms.DataGridView
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtDiferenciaS As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtTHaberS As System.Windows.Forms.TextBox
    Friend WithEvents txtTDebeS As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents impuesto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents operacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents banco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents movimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents operacion_banco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents panelPago As System.Windows.Forms.GroupBox
    Friend WithEvents dtFecImpuesto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPorcentaje As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents txtMontoPago As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionPago As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents panelDetraccion As System.Windows.Forms.Panel
    Friend WithEvents lblDetraccion As System.Windows.Forms.TextBox
    Friend WithEvents txtCDetraccion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
