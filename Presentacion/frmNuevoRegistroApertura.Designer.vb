<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoRegistroApertura
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTituloForm = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.panelAsientos = New System.Windows.Forms.GroupBox()
        Me.dgvOperaciones = New System.Windows.Forms.DataGridView()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtTDebeS = New System.Windows.Forms.TextBox()
        Me.txtDiferenciaS = New System.Windows.Forms.TextBox()
        Me.txtTHaberS = New System.Windows.Forms.TextBox()
        Me.btnAgregarCuenta = New System.Windows.Forms.Button()
        Me.txtGlosa = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.chkReaperturar = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTHaberD = New System.Windows.Forms.TextBox()
        Me.txtTDebeD = New System.Windows.Forms.TextBox()
        Me.txtDiferenciaD = New System.Windows.Forms.TextBox()
        Me.num_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debe_d = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haber_d = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.glosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelAsientos.SuspendLayout()
        CType(Me.dgvOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTituloForm
        '
        Me.lblTituloForm.AutoSize = True
        Me.lblTituloForm.BackColor = System.Drawing.Color.Transparent
        Me.lblTituloForm.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblTituloForm.Location = New System.Drawing.Point(-8, -8)
        Me.lblTituloForm.Name = "lblTituloForm"
        Me.lblTituloForm.Padding = New System.Windows.Forms.Padding(10)
        Me.lblTituloForm.Size = New System.Drawing.Size(398, 59)
        Me.lblTituloForm.TabIndex = 3
        Me.lblTituloForm.Text = "REGISTRO DE APERTURA"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel2.Location = New System.Drawing.Point(0, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(12, 426)
        Me.Panel2.TabIndex = 279
        Me.Panel2.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Location = New System.Drawing.Point(12, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(773, 12)
        Me.Panel1.TabIndex = 12
        Me.Panel1.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel3.Location = New System.Drawing.Point(-43, 416)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(785, 12)
        Me.Panel3.TabIndex = 281
        Me.Panel3.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel4.Location = New System.Drawing.Point(687, -5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(12, 433)
        Me.Panel4.TabIndex = 4
        Me.Panel4.Visible = False
        '
        'panelAsientos
        '
        Me.panelAsientos.Controls.Add(Me.dgvOperaciones)
        Me.panelAsientos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelAsientos.Location = New System.Drawing.Point(12, 130)
        Me.panelAsientos.Name = "panelAsientos"
        Me.panelAsientos.Size = New System.Drawing.Size(675, 195)
        Me.panelAsientos.TabIndex = 304
        Me.panelAsientos.TabStop = False
        Me.panelAsientos.Text = "ASIENTOS CONTABLES"
        '
        'dgvOperaciones
        '
        Me.dgvOperaciones.AllowUserToAddRows = False
        Me.dgvOperaciones.BackgroundColor = System.Drawing.Color.White
        Me.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOperaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num_cuenta, Me.desc_cuenta, Me.debe, Me.haber, Me.debe_d, Me.haber_d, Me.moneda, Me.tc, Me.glosa})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOperaciones.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvOperaciones.Location = New System.Drawing.Point(6, 20)
        Me.dgvOperaciones.Name = "dgvOperaciones"
        Me.dgvOperaciones.Size = New System.Drawing.Size(663, 169)
        Me.dgvOperaciones.TabIndex = 0
        '
        'btnFinalizar
        '
        Me.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnFinalizar.ForeColor = System.Drawing.Color.White
        Me.btnFinalizar.Location = New System.Drawing.Point(592, 381)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(95, 35)
        Me.btnFinalizar.TabIndex = 5
        Me.btnFinalizar.Text = "FINALIZAR"
        Me.btnFinalizar.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(397, 328)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(82, 16)
        Me.Label25.TabIndex = 280
        Me.Label25.Text = "Diferencia  S/:"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(12, 381)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(93, 35)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(211, 328)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(87, 16)
        Me.Label27.TabIndex = 278
        Me.Label27.Text = "Total Debe  S/:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(304, 328)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(91, 16)
        Me.Label26.TabIndex = 279
        Me.Label26.Text = "Total Haber  S/:"
        '
        'txtTDebeS
        '
        Me.txtTDebeS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTDebeS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTDebeS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTDebeS.Location = New System.Drawing.Point(214, 345)
        Me.txtTDebeS.Name = "txtTDebeS"
        Me.txtTDebeS.ReadOnly = True
        Me.txtTDebeS.Size = New System.Drawing.Size(87, 21)
        Me.txtTDebeS.TabIndex = 9
        Me.txtTDebeS.TabStop = False
        Me.txtTDebeS.Text = "0.00"
        Me.txtTDebeS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiferenciaS
        '
        Me.txtDiferenciaS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDiferenciaS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferenciaS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDiferenciaS.Location = New System.Drawing.Point(400, 345)
        Me.txtDiferenciaS.Name = "txtDiferenciaS"
        Me.txtDiferenciaS.ReadOnly = True
        Me.txtDiferenciaS.Size = New System.Drawing.Size(87, 21)
        Me.txtDiferenciaS.TabIndex = 11
        Me.txtDiferenciaS.TabStop = False
        Me.txtDiferenciaS.Text = "0.00"
        Me.txtDiferenciaS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTHaberS
        '
        Me.txtTHaberS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTHaberS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTHaberS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTHaberS.Location = New System.Drawing.Point(307, 345)
        Me.txtTHaberS.Name = "txtTHaberS"
        Me.txtTHaberS.ReadOnly = True
        Me.txtTHaberS.Size = New System.Drawing.Size(87, 21)
        Me.txtTHaberS.TabIndex = 10
        Me.txtTHaberS.TabStop = False
        Me.txtTHaberS.Text = "0.00"
        Me.txtTHaberS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAgregarCuenta
        '
        Me.btnAgregarCuenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnAgregarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarCuenta.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregarCuenta.ForeColor = System.Drawing.Color.White
        Me.btnAgregarCuenta.Location = New System.Drawing.Point(520, 32)
        Me.btnAgregarCuenta.Name = "btnAgregarCuenta"
        Me.btnAgregarCuenta.Size = New System.Drawing.Size(147, 35)
        Me.btnAgregarCuenta.TabIndex = 3
        Me.btnAgregarCuenta.Text = "AGREGAR"
        Me.btnAgregarCuenta.UseVisualStyleBackColor = False
        '
        'txtGlosa
        '
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtGlosa.Location = New System.Drawing.Point(9, 38)
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(391, 22)
        Me.txtGlosa.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 17)
        Me.Label9.TabIndex = 307
        Me.Label9.Text = "Glosa:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(406, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Fecha emisión:"
        '
        'dtFechaEmision
        '
        Me.dtFechaEmision.CalendarFont = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaEmision.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaEmision.Location = New System.Drawing.Point(409, 38)
        Me.dtFechaEmision.Name = "dtFechaEmision"
        Me.dtFechaEmision.Size = New System.Drawing.Size(105, 22)
        Me.dtFechaEmision.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAgregarCuenta)
        Me.GroupBox2.Controls.Add(Me.dtFechaEmision)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtGlosa)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(675, 74)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS COMPROBANTE DE COMPRA"
        '
        'btnGrabar
        '
        Me.btnGrabar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrabar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnGrabar.ForeColor = System.Drawing.Color.White
        Me.btnGrabar.Location = New System.Drawing.Point(592, 331)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(95, 35)
        Me.btnGrabar.TabIndex = 305
        Me.btnGrabar.Text = "GRABAR"
        Me.btnGrabar.UseVisualStyleBackColor = False
        Me.btnGrabar.Visible = False
        '
        'chkReaperturar
        '
        Me.chkReaperturar.Font = New System.Drawing.Font("Century Gothic", 7.0!)
        Me.chkReaperturar.Location = New System.Drawing.Point(535, 15)
        Me.chkReaperturar.Name = "chkReaperturar"
        Me.chkReaperturar.Size = New System.Drawing.Size(149, 39)
        Me.chkReaperturar.TabIndex = 306
        Me.chkReaperturar.Text = "RE-APERTURAR SALDOS DEL ÚLTIMO EJERCICIO"
        Me.chkReaperturar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(397, 372)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 312
        Me.Label2.Text = "Diferencia $/:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(211, 372)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 16)
        Me.Label3.TabIndex = 310
        Me.Label3.Text = "Total Debe $/:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(304, 372)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 311
        Me.Label4.Text = "Total Haber $/:"
        '
        'txtTHaberD
        '
        Me.txtTHaberD.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTHaberD.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTHaberD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTHaberD.Location = New System.Drawing.Point(307, 389)
        Me.txtTHaberD.Name = "txtTHaberD"
        Me.txtTHaberD.ReadOnly = True
        Me.txtTHaberD.Size = New System.Drawing.Size(87, 21)
        Me.txtTHaberD.TabIndex = 308
        Me.txtTHaberD.TabStop = False
        Me.txtTHaberD.Text = "0.00"
        Me.txtTHaberD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTDebeD
        '
        Me.txtTDebeD.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTDebeD.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTDebeD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTDebeD.Location = New System.Drawing.Point(214, 389)
        Me.txtTDebeD.Name = "txtTDebeD"
        Me.txtTDebeD.ReadOnly = True
        Me.txtTDebeD.Size = New System.Drawing.Size(87, 21)
        Me.txtTDebeD.TabIndex = 307
        Me.txtTDebeD.TabStop = False
        Me.txtTDebeD.Text = "0.00"
        Me.txtTDebeD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiferenciaD
        '
        Me.txtDiferenciaD.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDiferenciaD.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferenciaD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDiferenciaD.Location = New System.Drawing.Point(400, 389)
        Me.txtDiferenciaD.Name = "txtDiferenciaD"
        Me.txtDiferenciaD.ReadOnly = True
        Me.txtDiferenciaD.Size = New System.Drawing.Size(87, 21)
        Me.txtDiferenciaD.TabIndex = 309
        Me.txtDiferenciaD.TabStop = False
        Me.txtDiferenciaD.Text = "0.00"
        Me.txtDiferenciaD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'num_cuenta
        '
        Me.num_cuenta.DataPropertyName = "num_cuenta"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.num_cuenta.DefaultCellStyle = DataGridViewCellStyle1
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
        Me.desc_cuenta.Width = 150
        '
        'debe
        '
        Me.debe.DataPropertyName = "debe"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.debe.DefaultCellStyle = DataGridViewCellStyle2
        Me.debe.HeaderText = "Debe S/"
        Me.debe.Name = "debe"
        Me.debe.Width = 80
        '
        'haber
        '
        Me.haber.DataPropertyName = "haber"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.haber.DefaultCellStyle = DataGridViewCellStyle3
        Me.haber.HeaderText = "Haber S/"
        Me.haber.Name = "haber"
        Me.haber.Width = 80
        '
        'debe_d
        '
        Me.debe_d.DataPropertyName = "debe_d"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.debe_d.DefaultCellStyle = DataGridViewCellStyle4
        Me.debe_d.HeaderText = "Debe $/"
        Me.debe_d.Name = "debe_d"
        Me.debe_d.Width = 80
        '
        'haber_d
        '
        Me.haber_d.DataPropertyName = "haber_d"
        Me.haber_d.HeaderText = "Haber $/"
        Me.haber_d.Name = "haber_d"
        Me.haber_d.Width = 80
        '
        'moneda
        '
        Me.moneda.DataPropertyName = "moneda"
        Me.moneda.HeaderText = "moneda"
        Me.moneda.Name = "moneda"
        Me.moneda.Visible = False
        '
        'tc
        '
        Me.tc.DataPropertyName = "tc"
        Me.tc.HeaderText = "tc"
        Me.tc.Name = "tc"
        Me.tc.Visible = False
        '
        'glosa
        '
        Me.glosa.DataPropertyName = "glosa"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.glosa.DefaultCellStyle = DataGridViewCellStyle5
        Me.glosa.HeaderText = "Glosa"
        Me.glosa.Name = "glosa"
        Me.glosa.Width = 180
        '
        'frmNuevoRegistroApertura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(699, 428)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTHaberD)
        Me.Controls.Add(Me.txtTDebeD)
        Me.Controls.Add(Me.txtDiferenciaD)
        Me.Controls.Add(Me.chkReaperturar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.panelAsientos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.lblTituloForm)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txtTHaberS)
        Me.Controls.Add(Me.txtTDebeS)
        Me.Controls.Add(Me.txtDiferenciaS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmNuevoRegistroApertura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Apertura"
        Me.panelAsientos.ResumeLayout(False)
        CType(Me.dgvOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTituloForm As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents panelAsientos As System.Windows.Forms.GroupBox
    Friend WithEvents dgvOperaciones As System.Windows.Forms.DataGridView
    Friend WithEvents btnFinalizar As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtTDebeS As System.Windows.Forms.TextBox
    Friend WithEvents txtDiferenciaS As System.Windows.Forms.TextBox
    Friend WithEvents txtTHaberS As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarCuenta As System.Windows.Forms.Button
    Friend WithEvents txtGlosa As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtFechaEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents chkReaperturar As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTHaberD As System.Windows.Forms.TextBox
    Friend WithEvents txtTDebeD As System.Windows.Forms.TextBox
    Friend WithEvents txtDiferenciaD As System.Windows.Forms.TextBox
    Friend WithEvents num_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debe_d As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents haber_d As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents moneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents glosa As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
