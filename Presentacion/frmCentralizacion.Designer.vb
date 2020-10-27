<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCentralizacion
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelAsientos = New System.Windows.Forms.GroupBox()
        Me.lblTReg1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtDebe1 = New System.Windows.Forms.TextBox()
        Me.txtDiferencia1 = New System.Windows.Forms.TextBox()
        Me.txtHaber1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbCentralizacion = New System.Windows.Forms.GroupBox()
        Me.lblTReg2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtComentarios = New System.Windows.Forms.TextBox()
        Me.dgvCentralizacion = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDebe2 = New System.Windows.Forms.TextBox()
        Me.txtDiferencia2 = New System.Windows.Forms.TextBox()
        Me.txtHaber2 = New System.Windows.Forms.TextBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.cboAnio = New System.Windows.Forms.ComboBox()
        Me.cboProceso = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenta2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc_cuenta2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debe2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haber2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelAsientos.SuspendLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCentralizacion.SuspendLayout()
        CType(Me.dgvCentralizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelAsientos
        '
        Me.panelAsientos.Controls.Add(Me.lblTReg1)
        Me.panelAsientos.Controls.Add(Me.Label9)
        Me.panelAsientos.Controls.Add(Me.dgvLista)
        Me.panelAsientos.Controls.Add(Me.btnFinalizar)
        Me.panelAsientos.Controls.Add(Me.Label25)
        Me.panelAsientos.Controls.Add(Me.Label27)
        Me.panelAsientos.Controls.Add(Me.Label26)
        Me.panelAsientos.Controls.Add(Me.txtDebe1)
        Me.panelAsientos.Controls.Add(Me.txtDiferencia1)
        Me.panelAsientos.Controls.Add(Me.txtHaber1)
        Me.panelAsientos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelAsientos.Location = New System.Drawing.Point(12, 117)
        Me.panelAsientos.Name = "panelAsientos"
        Me.panelAsientos.Size = New System.Drawing.Size(660, 222)
        Me.panelAsientos.TabIndex = 283
        Me.panelAsientos.TabStop = False
        Me.panelAsientos.Text = "ASIENTOS CONTABLES"
        '
        'lblTReg1
        '
        Me.lblTReg1.AutoSize = True
        Me.lblTReg1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTReg1.Location = New System.Drawing.Point(552, 1)
        Me.lblTReg1.Name = "lblTReg1"
        Me.lblTReg1.Size = New System.Drawing.Size(13, 15)
        Me.lblTReg1.TabIndex = 291
        Me.lblTReg1.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(474, 1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 16)
        Me.Label9.TabIndex = 290
        Me.Label9.Text = "Total registros:"
        '
        'txtNumero
        '
        Me.txtNumero.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtNumero.Location = New System.Drawing.Point(402, 87)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(42, 24)
        Me.txtNumero.TabIndex = 289
        Me.txtNumero.Text = "3"
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(399, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 16)
        Me.Label7.TabIndex = 288
        Me.Label7.Text = "Dígitos:"
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToOrderColumns = True
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cuenta, Me.desc_cuenta, Me.debe, Me.haber, Me.descripcion})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvLista.Location = New System.Drawing.Point(6, 20)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.Size = New System.Drawing.Size(648, 154)
        Me.dgvLista.TabIndex = 283
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
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(189, 177)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(65, 16)
        Me.Label25.TabIndex = 280
        Me.Label25.Text = "Diferencia:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(3, 177)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(70, 16)
        Me.Label27.TabIndex = 278
        Me.Label27.Text = "Total Debe:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(96, 177)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(74, 16)
        Me.Label26.TabIndex = 279
        Me.Label26.Text = "Total Haber:"
        '
        'txtDebe1
        '
        Me.txtDebe1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDebe1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebe1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDebe1.Location = New System.Drawing.Point(6, 194)
        Me.txtDebe1.Name = "txtDebe1"
        Me.txtDebe1.Size = New System.Drawing.Size(87, 21)
        Me.txtDebe1.TabIndex = 274
        Me.txtDebe1.Text = "0"
        Me.txtDebe1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiferencia1
        '
        Me.txtDiferencia1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDiferencia1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferencia1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDiferencia1.Location = New System.Drawing.Point(192, 194)
        Me.txtDiferencia1.Name = "txtDiferencia1"
        Me.txtDiferencia1.Size = New System.Drawing.Size(87, 21)
        Me.txtDiferencia1.TabIndex = 276
        Me.txtDiferencia1.Text = "0"
        Me.txtDiferencia1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHaber1
        '
        Me.txtHaber1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtHaber1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHaber1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtHaber1.Location = New System.Drawing.Point(99, 194)
        Me.txtHaber1.Name = "txtHaber1"
        Me.txtHaber1.Size = New System.Drawing.Size(87, 21)
        Me.txtHaber1.TabIndex = 275
        Me.txtHaber1.Text = "0"
        Me.txtHaber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(327, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 288
        Me.Label1.Text = "Año:"
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.Green
        Me.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnConsultar.ForeColor = System.Drawing.Color.White
        Me.btnConsultar.Location = New System.Drawing.Point(501, 81)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(171, 30)
        Me.btnConsultar.TabIndex = 286
        Me.btnConsultar.Text = "PROCESAR PERIODO"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(191, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 16)
        Me.Label2.TabIndex = 285
        Me.Label2.Text = "Mes:"
        '
        'gbCentralizacion
        '
        Me.gbCentralizacion.Controls.Add(Me.lblTReg2)
        Me.gbCentralizacion.Controls.Add(Me.Label11)
        Me.gbCentralizacion.Controls.Add(Me.dtFecha)
        Me.gbCentralizacion.Controls.Add(Me.Label13)
        Me.gbCentralizacion.Controls.Add(Me.btnGuardar)
        Me.gbCentralizacion.Controls.Add(Me.Label6)
        Me.gbCentralizacion.Controls.Add(Me.txtComentarios)
        Me.gbCentralizacion.Controls.Add(Me.dgvCentralizacion)
        Me.gbCentralizacion.Controls.Add(Me.Button1)
        Me.gbCentralizacion.Controls.Add(Me.Label3)
        Me.gbCentralizacion.Controls.Add(Me.Label4)
        Me.gbCentralizacion.Controls.Add(Me.Label5)
        Me.gbCentralizacion.Controls.Add(Me.txtDebe2)
        Me.gbCentralizacion.Controls.Add(Me.txtDiferencia2)
        Me.gbCentralizacion.Controls.Add(Me.txtHaber2)
        Me.gbCentralizacion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCentralizacion.Location = New System.Drawing.Point(12, 345)
        Me.gbCentralizacion.Name = "gbCentralizacion"
        Me.gbCentralizacion.Size = New System.Drawing.Size(660, 204)
        Me.gbCentralizacion.TabIndex = 289
        Me.gbCentralizacion.TabStop = False
        Me.gbCentralizacion.Text = "CENTRALIZACIÓN"
        '
        'lblTReg2
        '
        Me.lblTReg2.AutoSize = True
        Me.lblTReg2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTReg2.Location = New System.Drawing.Point(413, 0)
        Me.lblTReg2.Name = "lblTReg2"
        Me.lblTReg2.Size = New System.Drawing.Size(13, 15)
        Me.lblTReg2.TabIndex = 306
        Me.lblTReg2.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(335, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 16)
        Me.Label11.TabIndex = 305
        Me.Label11.Text = "Total registros:"
        '
        'dtFecha
        '
        Me.dtFecha.CalendarFont = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecha.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(459, 131)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(103, 22)
        Me.dtFecha.TabIndex = 303
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(459, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 16)
        Me.Label13.TabIndex = 304
        Me.Label13.Text = "Fecha registro:"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(555, 168)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(99, 30)
        Me.btnGuardar.TabIndex = 288
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(459, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 285
        Me.Label6.Text = "Glosa:"
        '
        'txtComentarios
        '
        Me.txtComentarios.Location = New System.Drawing.Point(459, 39)
        Me.txtComentarios.Multiline = True
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.Size = New System.Drawing.Size(195, 62)
        Me.txtComentarios.TabIndex = 284
        '
        'dgvCentralizacion
        '
        Me.dgvCentralizacion.AllowUserToAddRows = False
        Me.dgvCentralizacion.AllowUserToDeleteRows = False
        Me.dgvCentralizacion.AllowUserToOrderColumns = True
        Me.dgvCentralizacion.BackgroundColor = System.Drawing.Color.White
        Me.dgvCentralizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCentralizacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cuenta2, Me.desc_cuenta2, Me.debe2, Me.haber2})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCentralizacion.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvCentralizacion.Location = New System.Drawing.Point(6, 20)
        Me.dgvCentralizacion.Name = "dgvCentralizacion"
        Me.dgvCentralizacion.ReadOnly = True
        Me.dgvCentralizacion.Size = New System.Drawing.Size(447, 133)
        Me.dgvCentralizacion.TabIndex = 283
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(658, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 35)
        Me.Button1.TabIndex = 282
        Me.Button1.Text = "FINALIZAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(189, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 280
        Me.Label3.Text = "Diferencia:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 278
        Me.Label4.Text = "Total Debe:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(96, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 279
        Me.Label5.Text = "Total Haber:"
        '
        'txtDebe2
        '
        Me.txtDebe2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDebe2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebe2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDebe2.Location = New System.Drawing.Point(6, 175)
        Me.txtDebe2.Name = "txtDebe2"
        Me.txtDebe2.Size = New System.Drawing.Size(87, 21)
        Me.txtDebe2.TabIndex = 274
        Me.txtDebe2.Text = "0"
        Me.txtDebe2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiferencia2
        '
        Me.txtDiferencia2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDiferencia2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferencia2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDiferencia2.Location = New System.Drawing.Point(192, 175)
        Me.txtDiferencia2.Name = "txtDiferencia2"
        Me.txtDiferencia2.Size = New System.Drawing.Size(87, 21)
        Me.txtDiferencia2.TabIndex = 276
        Me.txtDiferencia2.Text = "0"
        Me.txtDiferencia2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHaber2
        '
        Me.txtHaber2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtHaber2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHaber2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtHaber2.Location = New System.Drawing.Point(99, 175)
        Me.txtHaber2.Name = "txtHaber2"
        Me.txtHaber2.Size = New System.Drawing.Size(87, 21)
        Me.txtHaber2.TabIndex = 275
        Me.txtHaber2.Text = "0"
        Me.txtHaber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboMes
        '
        Me.cboMes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboMes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMes.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.Location = New System.Drawing.Point(194, 87)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(130, 24)
        Me.cboMes.TabIndex = 290
        '
        'cboAnio
        '
        Me.cboAnio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAnio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAnio.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboAnio.FormattingEnabled = True
        Me.cboAnio.Location = New System.Drawing.Point(330, 87)
        Me.cboAnio.Name = "cboAnio"
        Me.cboAnio.Size = New System.Drawing.Size(62, 24)
        Me.cboAnio.TabIndex = 291
        '
        'cboProceso
        '
        Me.cboProceso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboProceso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProceso.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProceso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboProceso.FormattingEnabled = True
        Me.cboProceso.Location = New System.Drawing.Point(18, 87)
        Me.cboProceso.Name = "cboProceso"
        Me.cboProceso.Size = New System.Drawing.Size(154, 24)
        Me.cboProceso.TabIndex = 293
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(15, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 16)
        Me.Label8.TabIndex = 292
        Me.Label8.Text = "Proceso:"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 25.0!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(5, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(334, 40)
        Me.lblTitulo.TabIndex = 294
        Me.lblTitulo.Text = "CENTRALIZACIONES"
        '
        'cuenta
        '
        Me.cuenta.DataPropertyName = "cuenta"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cuenta.DefaultCellStyle = DataGridViewCellStyle1
        Me.cuenta.HeaderText = "Cta."
        Me.cuenta.Name = "cuenta"
        Me.cuenta.ReadOnly = True
        Me.cuenta.Width = 60
        '
        'desc_cuenta
        '
        Me.desc_cuenta.DataPropertyName = "desc_cuenta"
        Me.desc_cuenta.HeaderText = "Descripción"
        Me.desc_cuenta.Name = "desc_cuenta"
        Me.desc_cuenta.ReadOnly = True
        Me.desc_cuenta.Width = 145
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
        Me.debe.ReadOnly = True
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
        Me.haber.ReadOnly = True
        Me.haber.Width = 90
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.descripcion.DefaultCellStyle = DataGridViewCellStyle4
        Me.descripcion.HeaderText = "Glosa"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 203
        '
        'cuenta2
        '
        Me.cuenta2.DataPropertyName = "cuenta2"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cuenta2.DefaultCellStyle = DataGridViewCellStyle6
        Me.cuenta2.HeaderText = "Cta."
        Me.cuenta2.Name = "cuenta2"
        Me.cuenta2.ReadOnly = True
        Me.cuenta2.Width = 60
        '
        'desc_cuenta2
        '
        Me.desc_cuenta2.DataPropertyName = "desc_cuenta2"
        Me.desc_cuenta2.HeaderText = "Descripción"
        Me.desc_cuenta2.Name = "desc_cuenta2"
        Me.desc_cuenta2.ReadOnly = True
        Me.desc_cuenta2.Width = 147
        '
        'debe2
        '
        Me.debe2.DataPropertyName = "debe2"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.debe2.DefaultCellStyle = DataGridViewCellStyle7
        Me.debe2.HeaderText = "Debe"
        Me.debe2.Name = "debe2"
        Me.debe2.ReadOnly = True
        Me.debe2.Width = 90
        '
        'haber2
        '
        Me.haber2.DataPropertyName = "haber2"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.haber2.DefaultCellStyle = DataGridViewCellStyle8
        Me.haber2.HeaderText = "Haber"
        Me.haber2.Name = "haber2"
        Me.haber2.ReadOnly = True
        Me.haber2.Width = 90
        '
        'frmCentralizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.cboProceso)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.cboAnio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboMes)
        Me.Controls.Add(Me.gbCentralizacion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.panelAsientos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmCentralizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PROCESO DE CENTRALIZACIONES"
        Me.panelAsientos.ResumeLayout(False)
        Me.panelAsientos.PerformLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCentralizacion.ResumeLayout(False)
        Me.gbCentralizacion.PerformLayout()
        CType(Me.dgvCentralizacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelAsientos As System.Windows.Forms.GroupBox
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents btnFinalizar As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtDebe1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDiferencia1 As System.Windows.Forms.TextBox
    Friend WithEvents txtHaber1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbCentralizacion As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCentralizacion As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDebe2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDiferencia2 As System.Windows.Forms.TextBox
    Friend WithEvents txtHaber2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtComentarios As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents cboAnio As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboProceso As System.Windows.Forms.ComboBox
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblTReg1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblTReg2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuenta2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc_cuenta2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debe2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents haber2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
