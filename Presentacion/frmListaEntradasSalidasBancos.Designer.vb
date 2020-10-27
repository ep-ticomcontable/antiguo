<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaEntradasSalidasBancos
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNomCuenta = New System.Windows.Forms.Label()
        Me.dgvContable = New System.Windows.Forms.DataGridView()
        Me.dgvExtracto = New System.Windows.Forms.DataGridView()
        Me.verficadorE = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.fechaE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.conceptoE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numeroE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtArchivo = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtSC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPE = New System.Windows.Forms.TextBox()
        Me.txtMC = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.dtDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboBanco = New System.Windows.Forms.ComboBox()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.Cliente = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblImportar = New System.Windows.Forms.Label()
        Me.pbImportar = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSE = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPC = New System.Windows.Forms.TextBox()
        Me.txtME = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPC2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPE2 = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_comprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.verificador = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.fecha_operacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_caja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.glosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.movimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvContable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvExtracto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbImportar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnProcesar
        '
        Me.btnProcesar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcesar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnProcesar.ForeColor = System.Drawing.Color.White
        Me.btnProcesar.Location = New System.Drawing.Point(577, 515)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(105, 35)
        Me.btnProcesar.TabIndex = 110
        Me.btnProcesar.Text = "PROCESAR"
        Me.btnProcesar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblNomCuenta)
        Me.GroupBox2.Controls.Add(Me.dgvContable)
        Me.GroupBox2.Controls.Add(Me.dgvExtracto)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1162, 315)
        Me.GroupBox2.TabIndex = 118
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Panel de Comparación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(638, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 15)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Datos del Extracto Bancario"
        '
        'lblNomCuenta
        '
        Me.lblNomCuenta.AutoSize = True
        Me.lblNomCuenta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblNomCuenta.Location = New System.Drawing.Point(3, 23)
        Me.lblNomCuenta.Name = "lblNomCuenta"
        Me.lblNomCuenta.Size = New System.Drawing.Size(94, 15)
        Me.lblNomCuenta.TabIndex = 118
        Me.lblNomCuenta.Text = "Datos Contables"
        '
        'dgvContable
        '
        Me.dgvContable.AllowUserToAddRows = False
        Me.dgvContable.BackgroundColor = System.Drawing.Color.White
        Me.dgvContable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.id_comprobante, Me.verificador, Me.fecha_operacion, Me.id_caja, Me.glosa, Me.movimiento, Me.numero, Me.cuenta, Me.monto})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvContable.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvContable.Location = New System.Drawing.Point(6, 41)
        Me.dgvContable.Name = "dgvContable"
        Me.dgvContable.RowTemplate.Height = 25
        Me.dgvContable.Size = New System.Drawing.Size(525, 260)
        Me.dgvContable.TabIndex = 117
        '
        'dgvExtracto
        '
        Me.dgvExtracto.AllowUserToAddRows = False
        Me.dgvExtracto.BackgroundColor = System.Drawing.Color.White
        Me.dgvExtracto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExtracto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.verficadorE, Me.fechaE, Me.conceptoE, Me.tipoE, Me.numeroE, Me.montoE})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvExtracto.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvExtracto.Location = New System.Drawing.Point(631, 41)
        Me.dgvExtracto.Name = "dgvExtracto"
        Me.dgvExtracto.RowTemplate.Height = 25
        Me.dgvExtracto.Size = New System.Drawing.Size(525, 260)
        Me.dgvExtracto.TabIndex = 116
        '
        'verficadorE
        '
        Me.verficadorE.DataPropertyName = "verificador"
        Me.verficadorE.FalseValue = "false"
        Me.verficadorE.HeaderText = "✔"
        Me.verficadorE.Name = "verficadorE"
        Me.verficadorE.TrueValue = "true"
        Me.verficadorE.Width = 25
        '
        'fechaE
        '
        Me.fechaE.DataPropertyName = "fecha"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.fechaE.DefaultCellStyle = DataGridViewCellStyle4
        Me.fechaE.HeaderText = "FECHA"
        Me.fechaE.Name = "fechaE"
        Me.fechaE.Width = 98
        '
        'conceptoE
        '
        Me.conceptoE.DataPropertyName = "concepto"
        Me.conceptoE.HeaderText = "CONCEPTO"
        Me.conceptoE.Name = "conceptoE"
        Me.conceptoE.Width = 132
        '
        'tipoE
        '
        Me.tipoE.DataPropertyName = "tipo"
        Me.tipoE.HeaderText = "TIPO"
        Me.tipoE.Name = "tipoE"
        Me.tipoE.Width = 50
        '
        'numeroE
        '
        Me.numeroE.DataPropertyName = "numero"
        Me.numeroE.HeaderText = "N°/OPER."
        Me.numeroE.Name = "numeroE"
        Me.numeroE.Width = 80
        '
        'montoE
        '
        Me.montoE.DataPropertyName = "monto"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.montoE.DefaultCellStyle = DataGridViewCellStyle5
        Me.montoE.HeaderText = "MONTO"
        Me.montoE.Name = "montoE"
        Me.montoE.Width = 80
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.PictureBox3)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.PictureBox2)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(537, 32)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(88, 269)
        Me.GroupBox4.TabIndex = 115
        Me.GroupBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(1, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 33)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "Desmarcar Registros"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.Presentacion.My.Resources.Resources.desmarcarcheck1
        Me.PictureBox3.Location = New System.Drawing.Point(34, 205)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 122
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(1, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 33)
        Me.Label4.TabIndex = 121
        Me.Label4.Text = "Marcar Registros"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Presentacion.My.Resources.Resources.marcarcheck
        Me.PictureBox2.Location = New System.Drawing.Point(34, 139)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 120
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(1, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 33)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "Realizar Comparación"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Presentacion.My.Resources.Resources.comparacion
        Me.PictureBox1.Location = New System.Drawing.Point(25, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtArchivo
        '
        Me.txtArchivo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArchivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtArchivo.Location = New System.Drawing.Point(263, 46)
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.Size = New System.Drawing.Size(252, 21)
        Me.txtArchivo.TabIndex = 121
        Me.txtArchivo.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(190, 503)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(164, 16)
        Me.Label22.TabIndex = 162
        Me.Label22.Text = "Saldo Contable Ajustado S/.:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(218, 443)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(136, 16)
        Me.Label17.TabIndex = 161
        Me.Label17.Text = "Pendientes Extracto S/.:"
        '
        'txtSC
        '
        Me.txtSC.BackColor = System.Drawing.Color.Aqua
        Me.txtSC.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtSC.Location = New System.Drawing.Point(360, 499)
        Me.txtSC.Name = "txtSC"
        Me.txtSC.Size = New System.Drawing.Size(181, 24)
        Me.txtSC.TabIndex = 159
        Me.txtSC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 413)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 160
        Me.Label1.Text = "Monto Total S/.:"
        '
        'txtPE
        '
        Me.txtPE.BackColor = System.Drawing.Color.LimeGreen
        Me.txtPE.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtPE.Location = New System.Drawing.Point(360, 439)
        Me.txtPE.Name = "txtPE"
        Me.txtPE.Size = New System.Drawing.Size(181, 24)
        Me.txtPE.TabIndex = 158
        Me.txtPE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMC
        '
        Me.txtMC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtMC.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtMC.Location = New System.Drawing.Point(360, 409)
        Me.txtMC.Name = "txtMC"
        Me.txtMC.Size = New System.Drawing.Size(181, 24)
        Me.txtMC.TabIndex = 157
        Me.txtMC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label7.Location = New System.Drawing.Point(43, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 16)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "Dato:"
        '
        'dtHasta
        '
        Me.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtHasta.Location = New System.Drawing.Point(325, 56)
        Me.dtHasta.Name = "dtHasta"
        Me.dtHasta.Size = New System.Drawing.Size(96, 20)
        Me.dtHasta.TabIndex = 125
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label8.Location = New System.Drawing.Point(271, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 17)
        Me.Label8.TabIndex = 126
        Me.Label8.Text = "Hasta:"
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnConsultar.ForeColor = System.Drawing.Color.White
        Me.btnConsultar.Location = New System.Drawing.Point(442, 40)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(99, 35)
        Me.btnConsultar.TabIndex = 124
        Me.btnConsultar.Text = "CONSULTAR"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'dtDesde
        '
        Me.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDesde.Location = New System.Drawing.Point(325, 24)
        Me.dtDesde.Name = "dtDesde"
        Me.dtDesde.Size = New System.Drawing.Size(96, 20)
        Me.dtDesde.TabIndex = 122
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label9.Location = New System.Drawing.Point(271, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 17)
        Me.Label9.TabIndex = 123
        Me.Label9.Text = "Desde:"
        '
        'cboBanco
        '
        Me.cboBanco.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboBanco.FormattingEnabled = True
        Me.cboBanco.Items.AddRange(New Object() {"soles", "dolares"})
        Me.cboBanco.Location = New System.Drawing.Point(87, 27)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Size = New System.Drawing.Size(178, 23)
        Me.cboBanco.TabIndex = 121
        '
        'txtDato
        '
        Me.txtDato.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDato.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDato.Location = New System.Drawing.Point(87, 56)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(178, 21)
        Me.txtDato.TabIndex = 120
        '
        'Cliente
        '
        Me.Cliente.AutoSize = True
        Me.Cliente.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Cliente.Location = New System.Drawing.Point(35, 29)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(46, 16)
        Me.Cliente.TabIndex = 119
        Me.Cliente.Text = "Banco:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtArchivo)
        Me.GroupBox1.Controls.Add(Me.lblImportar)
        Me.GroupBox1.Controls.Add(Me.pbImportar)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(651, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(521, 73)
        Me.GroupBox1.TabIndex = 163
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operaciones para el Extracto Bancario"
        '
        'lblImportar
        '
        Me.lblImportar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImportar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblImportar.Location = New System.Drawing.Point(53, 23)
        Me.lblImportar.Name = "lblImportar"
        Me.lblImportar.Size = New System.Drawing.Size(54, 33)
        Me.lblImportar.TabIndex = 119
        Me.lblImportar.Text = "Cargar Archivo"
        Me.lblImportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbImportar
        '
        Me.pbImportar.BackColor = System.Drawing.Color.White
        Me.pbImportar.Image = Global.Presentacion.My.Resources.Resources.importar_excel2
        Me.pbImportar.Location = New System.Drawing.Point(9, 20)
        Me.pbImportar.Name = "pbImportar"
        Me.pbImportar.Size = New System.Drawing.Size(39, 39)
        Me.pbImportar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImportar.TabIndex = 0
        Me.pbImportar.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(828, 503)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 16)
        Me.Label6.TabIndex = 169
        Me.Label6.Text = "Saldo Extracto Ajustado S/.:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(842, 443)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(143, 16)
        Me.Label10.TabIndex = 168
        Me.Label10.Text = "Pendientes Contable S/.:"
        '
        'txtSE
        '
        Me.txtSE.BackColor = System.Drawing.Color.Aqua
        Me.txtSE.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtSE.Location = New System.Drawing.Point(991, 499)
        Me.txtSE.Name = "txtSE"
        Me.txtSE.Size = New System.Drawing.Size(181, 24)
        Me.txtSE.TabIndex = 166
        Me.txtSE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(892, 413)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 16)
        Me.Label11.TabIndex = 167
        Me.Label11.Text = "Monto Total S/.:"
        '
        'txtPC
        '
        Me.txtPC.BackColor = System.Drawing.Color.LimeGreen
        Me.txtPC.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtPC.Location = New System.Drawing.Point(991, 439)
        Me.txtPC.Name = "txtPC"
        Me.txtPC.Size = New System.Drawing.Size(181, 24)
        Me.txtPC.TabIndex = 165
        Me.txtPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtME
        '
        Me.txtME.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtME.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtME.Location = New System.Drawing.Point(991, 409)
        Me.txtME.Name = "txtME"
        Me.txtME.Size = New System.Drawing.Size(181, 24)
        Me.txtME.TabIndex = 164
        Me.txtME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(218, 473)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 16)
        Me.Label12.TabIndex = 171
        Me.Label12.Text = "Pendientes Extracto S/.:"
        '
        'txtPC2
        '
        Me.txtPC2.BackColor = System.Drawing.Color.LimeGreen
        Me.txtPC2.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPC2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtPC2.Location = New System.Drawing.Point(360, 469)
        Me.txtPC2.Name = "txtPC2"
        Me.txtPC2.Size = New System.Drawing.Size(181, 24)
        Me.txtPC2.TabIndex = 170
        Me.txtPC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(842, 473)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(143, 16)
        Me.Label13.TabIndex = 173
        Me.Label13.Text = "Pendientes Contable S/.:"
        '
        'txtPE2
        '
        Me.txtPE2.BackColor = System.Drawing.Color.LimeGreen
        Me.txtPE2.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPE2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtPE2.Location = New System.Drawing.Point(991, 469)
        Me.txtPE2.Name = "txtPE2"
        Me.txtPE2.Size = New System.Drawing.Size(181, 24)
        Me.txtPE2.TabIndex = 172
        Me.txtPE2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'id_comprobante
        '
        Me.id_comprobante.DataPropertyName = "id_comprobante"
        Me.id_comprobante.HeaderText = "id_comprobante"
        Me.id_comprobante.Name = "id_comprobante"
        Me.id_comprobante.Visible = False
        '
        'verificador
        '
        Me.verificador.DataPropertyName = "verificador"
        Me.verificador.HeaderText = "✔"
        Me.verificador.Name = "verificador"
        Me.verificador.Width = 25
        '
        'fecha_operacion
        '
        Me.fecha_operacion.DataPropertyName = "fecha_operacion"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.fecha_operacion.DefaultCellStyle = DataGridViewCellStyle1
        Me.fecha_operacion.HeaderText = "FECHA"
        Me.fecha_operacion.Name = "fecha_operacion"
        Me.fecha_operacion.Width = 70
        '
        'id_caja
        '
        Me.id_caja.DataPropertyName = "id_caja"
        Me.id_caja.HeaderText = "Caja"
        Me.id_caja.Name = "id_caja"
        Me.id_caja.Visible = False
        '
        'glosa
        '
        Me.glosa.DataPropertyName = "glosa"
        Me.glosa.HeaderText = "CONCEPTO"
        Me.glosa.Name = "glosa"
        Me.glosa.Width = 132
        '
        'movimiento
        '
        Me.movimiento.DataPropertyName = "movimiento"
        Me.movimiento.HeaderText = "TIPO"
        Me.movimiento.Name = "movimiento"
        '
        'numero
        '
        Me.numero.DataPropertyName = "numero"
        Me.numero.HeaderText = "N°/OPER."
        Me.numero.Name = "numero"
        Me.numero.Width = 80
        '
        'cuenta
        '
        Me.cuenta.DataPropertyName = "cuenta"
        Me.cuenta.HeaderText = "cuenta"
        Me.cuenta.Name = "cuenta"
        Me.cuenta.Visible = False
        '
        'monto
        '
        Me.monto.DataPropertyName = "monto"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.monto.DefaultCellStyle = DataGridViewCellStyle2
        Me.monto.HeaderText = "MONTO"
        Me.monto.Name = "monto"
        Me.monto.Width = 70
        '
        'frmListaEntradasSalidasBancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtPE2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPC2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSE)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPC)
        Me.Controls.Add(Me.txtME)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.dtHasta)
        Me.Controls.Add(Me.txtSC)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.txtPE)
        Me.Controls.Add(Me.dtDesde)
        Me.Controls.Add(Me.txtMC)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboBanco)
        Me.Controls.Add(Me.txtDato)
        Me.Controls.Add(Me.Cliente)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmListaEntradasSalidasBancos"
        Me.Text = "CONCILIACIÓN BANCARIA"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvContable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvExtracto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbImportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtSC As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPE As System.Windows.Forms.TextBox
    Friend WithEvents txtMC As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents dtDesde As System.Windows.Forms.DateTimePicker
    Private WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboBanco As System.Windows.Forms.ComboBox
    Friend WithEvents txtDato As System.Windows.Forms.TextBox
    Friend WithEvents Cliente As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgvContable As System.Windows.Forms.DataGridView
    Friend WithEvents dgvExtracto As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblNomCuenta As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblImportar As System.Windows.Forms.Label
    Friend WithEvents pbImportar As System.Windows.Forms.PictureBox
    Friend WithEvents txtArchivo As System.Windows.Forms.TextBox
    Friend WithEvents verficadorE As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents fechaE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents conceptoE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipoE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numeroE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents montoE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSE As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPC As System.Windows.Forms.TextBox
    Friend WithEvents txtME As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPC2 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPE2 As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_comprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents verificador As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents fecha_operacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_caja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents glosa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents movimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents monto As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
