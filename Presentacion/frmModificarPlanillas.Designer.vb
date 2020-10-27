<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarPlanillas
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtDiferenciaS = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTHaberS = New System.Windows.Forms.TextBox()
        Me.txtTDebeS = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.txtIdCentro = New System.Windows.Forms.TextBox()
        Me.cboDH = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gbPago = New System.Windows.Forms.GroupBox()
        Me.btnCentro = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCentro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGlosaPlanilla = New System.Windows.Forms.TextBox()
        Me.txtNumPlanilla = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.dgvOperaciones = New System.Windows.Forms.DataGridView()
        Me.num_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.glosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_centro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_planilla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.gbPago.SuspendLayout()
        CType(Me.dgvOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPagar
        '
        Me.btnPagar.BackColor = System.Drawing.Color.Green
        Me.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPagar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnPagar.ForeColor = System.Drawing.Color.White
        Me.btnPagar.Location = New System.Drawing.Point(506, 419)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(90, 30)
        Me.btnPagar.TabIndex = 2
        Me.btnPagar.Text = "Pagar"
        Me.btnPagar.UseVisualStyleBackColor = False
        '
        'btnGrabar
        '
        Me.btnGrabar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrabar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnGrabar.ForeColor = System.Drawing.Color.White
        Me.btnGrabar.Location = New System.Drawing.Point(410, 419)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(90, 30)
        Me.btnGrabar.TabIndex = 1
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(221, 409)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 16)
        Me.Label22.TabIndex = 297
        Me.Label22.Text = "Diferencia:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(115, 409)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 16)
        Me.Label17.TabIndex = 296
        Me.Label17.Text = "Total Haber:"
        '
        'txtDiferenciaS
        '
        Me.txtDiferenciaS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDiferenciaS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferenciaS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDiferenciaS.Location = New System.Drawing.Point(224, 428)
        Me.txtDiferenciaS.Name = "txtDiferenciaS"
        Me.txtDiferenciaS.Size = New System.Drawing.Size(100, 21)
        Me.txtDiferenciaS.TabIndex = 294
        Me.txtDiferenciaS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 409)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 295
        Me.Label5.Text = "Total Debe:"
        '
        'txtTHaberS
        '
        Me.txtTHaberS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTHaberS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTHaberS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTHaberS.Location = New System.Drawing.Point(118, 428)
        Me.txtTHaberS.Name = "txtTHaberS"
        Me.txtTHaberS.Size = New System.Drawing.Size(100, 21)
        Me.txtTHaberS.TabIndex = 293
        Me.txtTHaberS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTDebeS
        '
        Me.txtTDebeS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTDebeS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTDebeS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTDebeS.Location = New System.Drawing.Point(12, 428)
        Me.txtTDebeS.Name = "txtTDebeS"
        Me.txtTDebeS.Size = New System.Drawing.Size(100, 21)
        Me.txtTDebeS.TabIndex = 292
        Me.txtTDebeS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(391, 16)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(59, 16)
        Me.Label29.TabIndex = 287
        Me.Label29.Text = "Moneda:"
        '
        'cboMoneda
        '
        Me.cboMoneda.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(394, 32)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(56, 24)
        Me.cboMoneda.TabIndex = 7
        '
        'txtIdCentro
        '
        Me.txtIdCentro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdCentro.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCentro.Location = New System.Drawing.Point(329, 422)
        Me.txtIdCentro.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdCentro.Name = "txtIdCentro"
        Me.txtIdCentro.Size = New System.Drawing.Size(31, 22)
        Me.txtIdCentro.TabIndex = 300
        Me.txtIdCentro.Text = "0"
        Me.txtIdCentro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboDH
        '
        Me.cboDH.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.cboDH.FormattingEnabled = True
        Me.cboDH.Location = New System.Drawing.Point(508, 81)
        Me.cboDH.Name = "cboDH"
        Me.cboDH.Size = New System.Drawing.Size(69, 24)
        Me.cboDH.TabIndex = 13
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(505, 64)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(32, 16)
        Me.Label24.TabIndex = 322
        Me.Label24.Text = "D/H:"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Century Gothic", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTotal.Location = New System.Drawing.Point(456, 33)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(80, 23)
        Me.txtTotal.TabIndex = 8
        Me.txtTotal.Text = "0.00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(453, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 16)
        Me.Label6.TabIndex = 290
        Me.Label6.Text = "Total"
        '
        'cboPeriodo
        '
        Me.cboPeriodo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPeriodo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPeriodo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeriodo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.Location = New System.Drawing.Point(274, 33)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(114, 23)
        Me.cboPeriodo.TabIndex = 6
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
        Me.btnFinalizar.TabIndex = 3
        Me.btnFinalizar.Text = "Finalizar"
        Me.btnFinalizar.UseVisualStyleBackColor = False
        '
        'dtFecha
        '
        Me.dtFecha.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(541, 34)
        Me.dtFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(88, 22)
        Me.dtFecha.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(538, 18)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 16)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Fecha Emisión:"
        '
        'gbPago
        '
        Me.gbPago.Controls.Add(Me.btnCentro)
        Me.gbPago.Controls.Add(Me.cboDH)
        Me.gbPago.Controls.Add(Me.Label24)
        Me.gbPago.Controls.Add(Me.txtTotal)
        Me.gbPago.Controls.Add(Me.Label6)
        Me.gbPago.Controls.Add(Me.Label29)
        Me.gbPago.Controls.Add(Me.cboMoneda)
        Me.gbPago.Controls.Add(Me.cboPeriodo)
        Me.gbPago.Controls.Add(Me.Label4)
        Me.gbPago.Controls.Add(Me.txtCentro)
        Me.gbPago.Controls.Add(Me.Label2)
        Me.gbPago.Controls.Add(Me.dtFecha)
        Me.gbPago.Controls.Add(Me.Label11)
        Me.gbPago.Controls.Add(Me.btnAgregar)
        Me.gbPago.Controls.Add(Me.txtMonto)
        Me.gbPago.Controls.Add(Me.Label1)
        Me.gbPago.Controls.Add(Me.txtGlosaPlanilla)
        Me.gbPago.Controls.Add(Me.txtNumPlanilla)
        Me.gbPago.Controls.Add(Me.Label7)
        Me.gbPago.Controls.Add(Me.Label13)
        Me.gbPago.Controls.Add(Me.lblCuenta)
        Me.gbPago.Controls.Add(Me.Label21)
        Me.gbPago.Controls.Add(Me.txtCuenta)
        Me.gbPago.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPago.Location = New System.Drawing.Point(12, 50)
        Me.gbPago.Name = "gbPago"
        Me.gbPago.Size = New System.Drawing.Size(680, 113)
        Me.gbPago.TabIndex = 0
        Me.gbPago.TabStop = False
        Me.gbPago.Text = "Parametros"
        '
        'btnCentro
        '
        Me.btnCentro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCentro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCentro.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCentro.ForeColor = System.Drawing.Color.White
        Me.btnCentro.Location = New System.Drawing.Point(386, 78)
        Me.btnCentro.Name = "btnCentro"
        Me.btnCentro.Size = New System.Drawing.Size(33, 27)
        Me.btnCentro.TabIndex = 11
        Me.btnCentro.Text = "[+]"
        Me.btnCentro.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(270, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 191
        Me.Label4.Text = "Periodo:"
        '
        'txtCentro
        '
        Me.txtCentro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCentro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCentro.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtCentro.Location = New System.Drawing.Point(274, 81)
        Me.txtCentro.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCentro.Name = "txtCentro"
        Me.txtCentro.ReadOnly = True
        Me.txtCentro.Size = New System.Drawing.Size(114, 21)
        Me.txtCentro.TabIndex = 0
        Me.txtCentro.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(272, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "Centro de costo:"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(583, 76)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(91, 30)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'txtMonto
        '
        Me.txtMonto.Font = New System.Drawing.Font("Century Gothic", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtMonto.Location = New System.Drawing.Point(433, 81)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(69, 23)
        Me.txtMonto.TabIndex = 12
        Me.txtMonto.Text = "0.00"
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(430, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Monto:"
        '
        'txtGlosaPlanilla
        '
        Me.txtGlosaPlanilla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosaPlanilla.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosaPlanilla.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtGlosaPlanilla.Location = New System.Drawing.Point(74, 35)
        Me.txtGlosaPlanilla.Name = "txtGlosaPlanilla"
        Me.txtGlosaPlanilla.Size = New System.Drawing.Size(194, 21)
        Me.txtGlosaPlanilla.TabIndex = 5
        '
        'txtNumPlanilla
        '
        Me.txtNumPlanilla.Enabled = False
        Me.txtNumPlanilla.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumPlanilla.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtNumPlanilla.Location = New System.Drawing.Point(6, 35)
        Me.txtNumPlanilla.Name = "txtNumPlanilla"
        Me.txtNumPlanilla.Size = New System.Drawing.Size(62, 21)
        Me.txtNumPlanilla.TabIndex = 4
        Me.txtNumPlanilla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(3, 18)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "N° Planilla:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(71, 18)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 16)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "Glosa Principal:"
        '
        'lblCuenta
        '
        Me.lblCuenta.Font = New System.Drawing.Font("Century Gothic", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblCuenta.Location = New System.Drawing.Point(71, 85)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(197, 17)
        Me.lblCuenta.TabIndex = 106
        Me.lblCuenta.Text = "[Nombre Cuenta]"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(3, 63)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(68, 16)
        Me.Label21.TabIndex = 91
        Me.Label21.Text = "N° Cuenta:"
        '
        'txtCuenta
        '
        Me.txtCuenta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtCuenta.Location = New System.Drawing.Point(6, 82)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(62, 21)
        Me.txtCuenta.TabIndex = 10
        Me.txtCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvOperaciones
        '
        Me.dgvOperaciones.AllowUserToAddRows = False
        Me.dgvOperaciones.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOperaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOperaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num_cuenta, Me.desc_cuenta, Me.debe, Me.haber, Me.glosa, Me.id_centro, Me.id_planilla, Me.id})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOperaciones.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvOperaciones.Location = New System.Drawing.Point(12, 169)
        Me.dgvOperaciones.Name = "dgvOperaciones"
        Me.dgvOperaciones.Size = New System.Drawing.Size(680, 229)
        Me.dgvOperaciones.TabIndex = 291
        '
        'num_cuenta
        '
        Me.num_cuenta.DataPropertyName = "num_cuenta"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.num_cuenta.DefaultCellStyle = DataGridViewCellStyle2
        Me.num_cuenta.HeaderText = "Cta."
        Me.num_cuenta.Name = "num_cuenta"
        Me.num_cuenta.Width = 60
        '
        'desc_cuenta
        '
        Me.desc_cuenta.DataPropertyName = "desc_cuenta"
        Me.desc_cuenta.HeaderText = "Desc. Cuenta"
        Me.desc_cuenta.Name = "desc_cuenta"
        Me.desc_cuenta.Width = 358
        '
        'debe
        '
        Me.debe.DataPropertyName = "debe"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.debe.DefaultCellStyle = DataGridViewCellStyle3
        Me.debe.HeaderText = "Debe"
        Me.debe.Name = "debe"
        Me.debe.Width = 80
        '
        'haber
        '
        Me.haber.DataPropertyName = "haber"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.haber.DefaultCellStyle = DataGridViewCellStyle4
        Me.haber.HeaderText = "Haber"
        Me.haber.Name = "haber"
        Me.haber.Width = 80
        '
        'glosa
        '
        Me.glosa.DataPropertyName = "glosa"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.glosa.DefaultCellStyle = DataGridViewCellStyle5
        Me.glosa.HeaderText = "Glosa"
        Me.glosa.Name = "glosa"
        Me.glosa.Visible = False
        Me.glosa.Width = 150
        '
        'id_centro
        '
        Me.id_centro.DataPropertyName = "id_centro"
        Me.id_centro.HeaderText = "C.C"
        Me.id_centro.Name = "id_centro"
        Me.id_centro.Width = 40
        '
        'id_planilla
        '
        Me.id_planilla.DataPropertyName = "id_planilla"
        Me.id_planilla.HeaderText = "id_planilla"
        Me.id_planilla.Name = "id_planilla"
        Me.id_planilla.Visible = False
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 25.0!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(5, 7)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(363, 40)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "MODIFICAR PLANILLA"
        '
        'frmModificarPlanillas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(704, 461)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtDiferenciaS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTHaberS)
        Me.Controls.Add(Me.txtTDebeS)
        Me.Controls.Add(Me.txtIdCentro)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.gbPago)
        Me.Controls.Add(Me.dgvOperaciones)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmModificarPlanillas"
        Me.Text = "Modificación de Planillas"
        Me.gbPago.ResumeLayout(False)
        Me.gbPago.PerformLayout()
        CType(Me.dgvOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPagar As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtDiferenciaS As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTHaberS As System.Windows.Forms.TextBox
    Friend WithEvents txtTDebeS As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents txtIdCentro As System.Windows.Forms.TextBox
    Friend WithEvents cboDH As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents btnFinalizar As System.Windows.Forms.Button
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents gbPago As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCentro As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtGlosaPlanilla As System.Windows.Forms.TextBox
    Friend WithEvents txtNumPlanilla As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblCuenta As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents dgvOperaciones As System.Windows.Forms.DataGridView
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents num_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents glosa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_centro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_planilla As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCentro As System.Windows.Forms.Button
End Class
