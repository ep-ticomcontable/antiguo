<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCanjeLetraComprobantes
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtInteres = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnOtrasCuentas = New System.Windows.Forms.Button()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAval = New System.Windows.Forms.TextBox()
        Me.dtFechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLibrado = New System.Windows.Forms.TextBox()
        Me.txtGiro = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.dtFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvComprobante = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.glosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.resta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.abono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelAsientos = New System.Windows.Forms.GroupBox()
        Me.txtValInteres = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.dgvOperaciones = New System.Windows.Forms.DataGridView()
        Me.num_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtTDebeS = New System.Windows.Forms.TextBox()
        Me.txtDiferenciaS = New System.Windows.Forms.TextBox()
        Me.txtTHaberS = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvComprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelAsientos.SuspendLayout()
        CType(Me.dgvOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtInteres)
        Me.GroupBox3.Controls.Add(Me.txtTotal)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.btnOtrasCuentas)
        Me.GroupBox3.Controls.Add(Me.txtMonto)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.lblCuenta)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtCuenta)
        Me.GroupBox3.Controls.Add(Me.btnAgregar)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtSerie)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtDireccion)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtAval)
        Me.GroupBox3.Controls.Add(Me.dtFechaVencimiento)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtLibrado)
        Me.GroupBox3.Controls.Add(Me.txtGiro)
        Me.GroupBox3.Controls.Add(Me.txtNumero)
        Me.GroupBox3.Controls.Add(Me.dtFechaEmision)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 160)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(768, 160)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DATOS DE LA LETRA"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(441, 113)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 16)
        Me.Label13.TabIndex = 284
        Me.Label13.Text = "Total:"
        '
        'txtInteres
        '
        Me.txtInteres.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtInteres.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInteres.Location = New System.Drawing.Point(380, 131)
        Me.txtInteres.MaxLength = 1000
        Me.txtInteres.Name = "txtInteres"
        Me.txtInteres.Size = New System.Drawing.Size(55, 22)
        Me.txtInteres.TabIndex = 10
        Me.txtInteres.Text = "0.00"
        Me.txtInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(441, 131)
        Me.txtTotal.MaxLength = 1000
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(81, 22)
        Me.txtTotal.TabIndex = 283
        Me.txtTotal.Text = "0.00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(377, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 16)
        Me.Label12.TabIndex = 281
        Me.Label12.Text = "% Interés:"
        '
        'btnOtrasCuentas
        '
        Me.btnOtrasCuentas.BackColor = System.Drawing.Color.Olive
        Me.btnOtrasCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOtrasCuentas.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnOtrasCuentas.ForeColor = System.Drawing.Color.White
        Me.btnOtrasCuentas.Location = New System.Drawing.Point(636, 127)
        Me.btnOtrasCuentas.Name = "btnOtrasCuentas"
        Me.btnOtrasCuentas.Size = New System.Drawing.Size(126, 27)
        Me.btnOtrasCuentas.TabIndex = 12
        Me.btnOtrasCuentas.Text = "AGREGAR CUENTAS"
        Me.btnOtrasCuentas.UseVisualStyleBackColor = False
        '
        'txtMonto
        '
        Me.txtMonto.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Location = New System.Drawing.Point(293, 131)
        Me.txtMonto.MaxLength = 1000
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(81, 22)
        Me.txtMonto.TabIndex = 9
        Me.txtMonto.Text = "0.00"
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(290, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 16)
        Me.Label9.TabIndex = 278
        Me.Label9.Text = "Monto:"
        '
        'lblCuenta
        '
        Me.lblCuenta.BackColor = System.Drawing.Color.NavajoWhite
        Me.lblCuenta.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.lblCuenta.Location = New System.Drawing.Point(66, 131)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblCuenta.Size = New System.Drawing.Size(194, 22)
        Me.lblCuenta.TabIndex = 277
        Me.lblCuenta.Text = "[Cuenta]"
        Me.lblCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(5, 113)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 16)
        Me.Label11.TabIndex = 276
        Me.Label11.Text = "Cuenta:"
        '
        'txtCuenta
        '
        Me.txtCuenta.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.Location = New System.Drawing.Point(8, 131)
        Me.txtCuenta.MaxLength = 1000
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(58, 22)
        Me.txtCuenta.TabIndex = 8
        Me.txtCuenta.Text = "123"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(554, 127)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(76, 27)
        Me.btnAgregar.TabIndex = 11
        Me.btnAgregar.Text = "CARGAR"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(261, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 16)
        Me.Label1.TabIndex = 241
        Me.Label1.Text = "Serie:"
        '
        'txtSerie
        '
        Me.txtSerie.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtSerie.Location = New System.Drawing.Point(264, 33)
        Me.txtSerie.MaxLength = 1000
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(50, 25)
        Me.txtSerie.TabIndex = 1
        Me.txtSerie.Text = "0000"
        Me.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(261, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 16)
        Me.Label8.TabIndex = 239
        Me.Label8.Text = "Dirección:"
        '
        'txtDireccion
        '
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtDireccion.Location = New System.Drawing.Point(264, 80)
        Me.txtDireccion.MaxLength = 1000
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(256, 25)
        Me.txtDireccion.TabIndex = 7
        Me.txtDireccion.Text = "DIRECCIÓN DE LA LETRA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 16)
        Me.Label7.TabIndex = 237
        Me.Label7.Text = "Aval:"
        '
        'txtAval
        '
        Me.txtAval.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAval.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtAval.Location = New System.Drawing.Point(6, 80)
        Me.txtAval.MaxLength = 1000
        Me.txtAval.Name = "txtAval"
        Me.txtAval.Size = New System.Drawing.Size(252, 25)
        Me.txtAval.TabIndex = 6
        Me.txtAval.Text = "AVAL"
        '
        'dtFechaVencimiento
        '
        Me.dtFechaVencimiento.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaVencimiento.Location = New System.Drawing.Point(135, 33)
        Me.dtFechaVencimiento.Name = "dtFechaVencimiento"
        Me.dtFechaVencimiento.Size = New System.Drawing.Size(123, 27)
        Me.dtFechaVencimiento.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(132, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 16)
        Me.Label5.TabIndex = 234
        Me.Label5.Text = "Fecha Vencimiento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(523, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 233
        Me.Label4.Text = "Lugar de Giro:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(373, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 232
        Me.Label3.Text = "Librador:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(317, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 16)
        Me.Label6.TabIndex = 231
        Me.Label6.Text = "Número:"
        '
        'txtLibrado
        '
        Me.txtLibrado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLibrado.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtLibrado.Location = New System.Drawing.Point(376, 33)
        Me.txtLibrado.MaxLength = 1000
        Me.txtLibrado.Name = "txtLibrado"
        Me.txtLibrado.Size = New System.Drawing.Size(386, 25)
        Me.txtLibrado.TabIndex = 3
        Me.txtLibrado.Text = "DATO LIBRADOR"
        '
        'txtGiro
        '
        Me.txtGiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGiro.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtGiro.Location = New System.Drawing.Point(526, 80)
        Me.txtGiro.MaxLength = 1000
        Me.txtGiro.Name = "txtGiro"
        Me.txtGiro.Size = New System.Drawing.Size(236, 25)
        Me.txtGiro.TabIndex = 5
        Me.txtGiro.Text = "LUGAR DE GIRO"
        '
        'txtNumero
        '
        Me.txtNumero.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtNumero.Location = New System.Drawing.Point(320, 33)
        Me.txtNumero.MaxLength = 1000
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(50, 25)
        Me.txtNumero.TabIndex = 2
        Me.txtNumero.Text = "0000"
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtFechaEmision
        '
        Me.dtFechaEmision.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaEmision.Location = New System.Drawing.Point(6, 33)
        Me.dtFechaEmision.Name = "dtFechaEmision"
        Me.dtFechaEmision.Size = New System.Drawing.Size(123, 27)
        Me.dtFechaEmision.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Fecha Emisión:"
        '
        'btnProcesar
        '
        Me.btnProcesar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcesar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnProcesar.ForeColor = System.Drawing.Color.White
        Me.btnProcesar.Location = New System.Drawing.Point(662, 184)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(100, 33)
        Me.btnProcesar.TabIndex = 1
        Me.btnProcesar.Text = "PROCESAR"
        Me.btnProcesar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvComprobante)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 90)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "COMPROBANTE DE REFERENCIA"
        '
        'dgvComprobante
        '
        Me.dgvComprobante.AllowUserToAddRows = False
        Me.dgvComprobante.AllowUserToDeleteRows = False
        Me.dgvComprobante.BackgroundColor = System.Drawing.Color.White
        Me.dgvComprobante.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvComprobante.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvComprobante.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvComprobante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvComprobante.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.fecha, Me.serie, Me.numero, Me.glosa, Me.total, Me.pagado, Me.resta, Me.abono})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvComprobante.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvComprobante.EnableHeadersVisualStyles = False
        Me.dgvComprobante.Location = New System.Drawing.Point(6, 20)
        Me.dgvComprobante.Name = "dgvComprobante"
        Me.dgvComprobante.RowHeadersVisible = False
        Me.dgvComprobante.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.dgvComprobante.RowTemplate.Height = 35
        Me.dgvComprobante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvComprobante.Size = New System.Drawing.Size(756, 62)
        Me.dgvComprobante.TabIndex = 111
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.id.DefaultCellStyle = DataGridViewCellStyle2
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.Visible = False
        Me.id.Width = 50
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "fecha"
        Me.fecha.HeaderText = "FECHA"
        Me.fecha.Name = "fecha"
        Me.fecha.Width = 90
        '
        'serie
        '
        Me.serie.DataPropertyName = "serie"
        Me.serie.HeaderText = "SERIE"
        Me.serie.Name = "serie"
        Me.serie.Width = 55
        '
        'numero
        '
        Me.numero.DataPropertyName = "numero"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.numero.DefaultCellStyle = DataGridViewCellStyle3
        Me.numero.HeaderText = "N°"
        Me.numero.Name = "numero"
        Me.numero.Width = 55
        '
        'glosa
        '
        Me.glosa.DataPropertyName = "glosa"
        Me.glosa.HeaderText = "GLOSA"
        Me.glosa.Name = "glosa"
        Me.glosa.Width = 315
        '
        'total
        '
        Me.total.DataPropertyName = "total"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.total.DefaultCellStyle = DataGridViewCellStyle4
        Me.total.HeaderText = "TOTAL"
        Me.total.Name = "total"
        Me.total.Width = 80
        '
        'pagado
        '
        Me.pagado.DataPropertyName = "pagado"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Green
        Me.pagado.DefaultCellStyle = DataGridViewCellStyle5
        Me.pagado.HeaderText = "ABONADO"
        Me.pagado.Name = "pagado"
        Me.pagado.Width = 80
        '
        'resta
        '
        Me.resta.DataPropertyName = "resta"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Red
        Me.resta.DefaultCellStyle = DataGridViewCellStyle6
        Me.resta.HeaderText = "RESTA"
        Me.resta.Name = "resta"
        Me.resta.Width = 80
        '
        'abono
        '
        Me.abono.DataPropertyName = "abono"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Blue
        Me.abono.DefaultCellStyle = DataGridViewCellStyle7
        Me.abono.HeaderText = "Abono"
        Me.abono.Name = "abono"
        Me.abono.Visible = False
        Me.abono.Width = 75
        '
        'panelAsientos
        '
        Me.panelAsientos.Controls.Add(Me.txtValInteres)
        Me.panelAsientos.Controls.Add(Me.Label10)
        Me.panelAsientos.Controls.Add(Me.txtDescripcion)
        Me.panelAsientos.Controls.Add(Me.dgvOperaciones)
        Me.panelAsientos.Controls.Add(Me.Label25)
        Me.panelAsientos.Controls.Add(Me.Label27)
        Me.panelAsientos.Controls.Add(Me.Label26)
        Me.panelAsientos.Controls.Add(Me.txtTDebeS)
        Me.panelAsientos.Controls.Add(Me.txtDiferenciaS)
        Me.panelAsientos.Controls.Add(Me.txtTHaberS)
        Me.panelAsientos.Controls.Add(Me.btnProcesar)
        Me.panelAsientos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelAsientos.Location = New System.Drawing.Point(12, 326)
        Me.panelAsientos.Name = "panelAsientos"
        Me.panelAsientos.Size = New System.Drawing.Size(768, 223)
        Me.panelAsientos.TabIndex = 1
        Me.panelAsientos.TabStop = False
        Me.panelAsientos.Text = "ASIENTOS CONTABLES"
        '
        'txtValInteres
        '
        Me.txtValInteres.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValInteres.Location = New System.Drawing.Point(681, 156)
        Me.txtValInteres.MaxLength = 1000
        Me.txtValInteres.Name = "txtValInteres"
        Me.txtValInteres.Size = New System.Drawing.Size(81, 22)
        Me.txtValInteres.TabIndex = 284
        Me.txtValInteres.Text = "0.00"
        Me.txtValInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtValInteres.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(555, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 16)
        Me.Label10.TabIndex = 282
        Me.Label10.Text = "Glosa / Comentarios:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtDescripcion.Location = New System.Drawing.Point(555, 39)
        Me.txtDescripcion.MaxLength = 1000
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(207, 101)
        Me.txtDescripcion.TabIndex = 0
        Me.txtDescripcion.Text = "POR CANJE A LETRA"
        '
        'dgvOperaciones
        '
        Me.dgvOperaciones.AllowUserToAddRows = False
        Me.dgvOperaciones.BackgroundColor = System.Drawing.Color.White
        Me.dgvOperaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOperaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvOperaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num_cuenta, Me.desc_cuenta, Me.debe, Me.haber})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOperaciones.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvOperaciones.EnableHeadersVisualStyles = False
        Me.dgvOperaciones.Location = New System.Drawing.Point(6, 20)
        Me.dgvOperaciones.Name = "dgvOperaciones"
        Me.dgvOperaciones.Size = New System.Drawing.Size(543, 158)
        Me.dgvOperaciones.TabIndex = 2
        '
        'num_cuenta
        '
        Me.num_cuenta.DataPropertyName = "num_cuenta"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.num_cuenta.DefaultCellStyle = DataGridViewCellStyle10
        Me.num_cuenta.HeaderText = "N° CTA."
        Me.num_cuenta.Name = "num_cuenta"
        Me.num_cuenta.Width = 75
        '
        'desc_cuenta
        '
        Me.desc_cuenta.DataPropertyName = "desc_cuenta"
        Me.desc_cuenta.HeaderText = "DESCRIPCIÓN"
        Me.desc_cuenta.Name = "desc_cuenta"
        Me.desc_cuenta.Width = 245
        '
        'debe
        '
        Me.debe.DataPropertyName = "debe"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.debe.DefaultCellStyle = DataGridViewCellStyle11
        Me.debe.HeaderText = "DEBE"
        Me.debe.Name = "debe"
        Me.debe.Width = 90
        '
        'haber
        '
        Me.haber.DataPropertyName = "haber"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.haber.DefaultCellStyle = DataGridViewCellStyle12
        Me.haber.HeaderText = "HABER"
        Me.haber.Name = "haber"
        Me.haber.Width = 90
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(189, 181)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(65, 16)
        Me.Label25.TabIndex = 280
        Me.Label25.Text = "Diferencia:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(3, 181)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(70, 16)
        Me.Label27.TabIndex = 278
        Me.Label27.Text = "Total Debe:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(96, 181)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(74, 16)
        Me.Label26.TabIndex = 279
        Me.Label26.Text = "Total Haber:"
        '
        'txtTDebeS
        '
        Me.txtTDebeS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTDebeS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTDebeS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTDebeS.Location = New System.Drawing.Point(6, 198)
        Me.txtTDebeS.Name = "txtTDebeS"
        Me.txtTDebeS.Size = New System.Drawing.Size(87, 21)
        Me.txtTDebeS.TabIndex = 274
        Me.txtTDebeS.Text = "0"
        Me.txtTDebeS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiferenciaS
        '
        Me.txtDiferenciaS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDiferenciaS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferenciaS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDiferenciaS.Location = New System.Drawing.Point(192, 198)
        Me.txtDiferenciaS.Name = "txtDiferenciaS"
        Me.txtDiferenciaS.Size = New System.Drawing.Size(87, 21)
        Me.txtDiferenciaS.TabIndex = 276
        Me.txtDiferenciaS.Text = "0"
        Me.txtDiferenciaS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTHaberS
        '
        Me.txtTHaberS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTHaberS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTHaberS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTHaberS.Location = New System.Drawing.Point(99, 198)
        Me.txtTHaberS.Name = "txtTHaberS"
        Me.txtTHaberS.Size = New System.Drawing.Size(87, 21)
        Me.txtTHaberS.TabIndex = 275
        Me.txtTHaberS.Text = "0"
        Me.txtTHaberS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 25.0!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(5, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(494, 40)
        Me.lblTitulo.TabIndex = 222
        Me.lblTitulo.Text = "CANJE COMP V.C POR LETRA"
        '
        'frmCanjeLetraComprobantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(792, 561)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.panelAsientos)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmCanjeLetraComprobantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Canje de Comprobante Compra con Letra"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvComprobante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelAsientos.ResumeLayout(False)
        Me.panelAsientos.PerformLayout()
        CType(Me.dgvOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvComprobante As System.Windows.Forms.DataGridView
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents dtFechaEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGiro As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLibrado As System.Windows.Forms.TextBox
    Friend WithEvents dtFechaVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAval As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents panelAsientos As System.Windows.Forms.GroupBox
    Friend WithEvents dgvOperaciones As System.Windows.Forms.DataGridView
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtTDebeS As System.Windows.Forms.TextBox
    Friend WithEvents txtDiferenciaS As System.Windows.Forms.TextBox
    Friend WithEvents txtTHaberS As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblCuenta As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents glosa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pagado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents resta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents abono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnOtrasCuentas As System.Windows.Forms.Button
    Friend WithEvents num_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtInteres As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtValInteres As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
