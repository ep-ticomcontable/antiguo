<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbonoDeudasBanco
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
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGlosa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboBanco = New System.Windows.Forms.ComboBox()
        Me.lblNomCuenta = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtPago = New System.Windows.Forms.DateTimePicker()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
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
        Me.txtTotalComprobante = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtDiferenciaS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTHaberS = New System.Windows.Forms.TextBox()
        Me.txtTDebeS = New System.Windows.Forms.TextBox()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.id_venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serieventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numeroventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.glosaV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvComprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboTipo)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtGlosa)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtNumero)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.cboBanco)
        Me.GroupBox3.Controls.Add(Me.lblNomCuenta)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.dtPago)
        Me.GroupBox3.Controls.Add(Me.txtCuenta)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 208)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(768, 116)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(478, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 17)
        Me.Label5.TabIndex = 228
        Me.Label5.Text = "Comentarios / Glosa:"
        '
        'txtGlosa
        '
        Me.txtGlosa.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtGlosa.Location = New System.Drawing.Point(481, 85)
        Me.txtGlosa.MaxLength = 1000
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(183, 25)
        Me.txtGlosa.TabIndex = 227
        Me.txtGlosa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(216, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 17)
        Me.Label6.TabIndex = 226
        Me.Label6.Text = "Tipo Movimiento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(394, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 224
        Me.Label4.Text = "N°/Oper.:"
        '
        'txtNumero
        '
        Me.txtNumero.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtNumero.Location = New System.Drawing.Point(397, 85)
        Me.txtNumero.MaxLength = 1000
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(78, 25)
        Me.txtNumero.TabIndex = 223
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 222
        Me.Label3.Text = "Banco:"
        '
        'cboBanco
        '
        Me.cboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBanco.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.cboBanco.FormattingEnabled = True
        Me.cboBanco.Location = New System.Drawing.Point(6, 85)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Size = New System.Drawing.Size(207, 25)
        Me.cboBanco.TabIndex = 221
        '
        'lblNomCuenta
        '
        Me.lblNomCuenta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblNomCuenta.Location = New System.Drawing.Point(209, 35)
        Me.lblNomCuenta.Name = "lblNomCuenta"
        Me.lblNomCuenta.Size = New System.Drawing.Size(553, 19)
        Me.lblNomCuenta.TabIndex = 116
        Me.lblNomCuenta.Text = "[Nombre Cuenta]"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(670, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 49)
        Me.Button1.TabIndex = 113
        Me.Button1.Text = "AGREGAR CUENTA"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dtPago
        '
        Me.dtPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPago.Location = New System.Drawing.Point(6, 33)
        Me.dtPago.Name = "dtPago"
        Me.dtPago.Size = New System.Drawing.Size(111, 21)
        Me.dtPago.TabIndex = 115
        '
        'txtCuenta
        '
        Me.txtCuenta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtCuenta.Location = New System.Drawing.Point(123, 33)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(80, 21)
        Me.txtCuenta.TabIndex = 114
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "FECHA ABONO"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(120, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 16)
        Me.Label16.TabIndex = 115
        Me.Label16.Text = "CUENTA CONTABLE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvComprobante)
        Me.GroupBox1.Controls.Add(Me.txtTotalComprobante)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 190)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Referencia del Documento de Venta"
        '
        'dgvComprobante
        '
        Me.dgvComprobante.AllowUserToAddRows = False
        Me.dgvComprobante.BackgroundColor = System.Drawing.Color.White
        Me.dgvComprobante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComprobante.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.fecha, Me.serie, Me.numero, Me.glosa, Me.total, Me.pagado, Me.resta, Me.abono})
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvComprobante.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvComprobante.Location = New System.Drawing.Point(6, 20)
        Me.dgvComprobante.Name = "dgvComprobante"
        Me.dgvComprobante.Size = New System.Drawing.Size(756, 136)
        Me.dgvComprobante.TabIndex = 111
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.id.DefaultCellStyle = DataGridViewCellStyle12
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.Visible = False
        Me.id.Width = 50
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "fecha"
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.Width = 80
        '
        'serie
        '
        Me.serie.DataPropertyName = "serie"
        Me.serie.HeaderText = "Serie"
        Me.serie.Name = "serie"
        Me.serie.Width = 55
        '
        'numero
        '
        Me.numero.DataPropertyName = "numero"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.numero.DefaultCellStyle = DataGridViewCellStyle13
        Me.numero.HeaderText = "Numero"
        Me.numero.Name = "numero"
        Me.numero.Width = 55
        '
        'glosa
        '
        Me.glosa.DataPropertyName = "glosa"
        Me.glosa.HeaderText = "Glosa"
        Me.glosa.Name = "glosa"
        Me.glosa.Width = 200
        '
        'total
        '
        Me.total.DataPropertyName = "total"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.total.DefaultCellStyle = DataGridViewCellStyle14
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.Width = 75
        '
        'pagado
        '
        Me.pagado.DataPropertyName = "pagado"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Green
        Me.pagado.DefaultCellStyle = DataGridViewCellStyle15
        Me.pagado.HeaderText = "Pagado"
        Me.pagado.Name = "pagado"
        Me.pagado.Width = 75
        '
        'resta
        '
        Me.resta.DataPropertyName = "resta"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.Red
        Me.resta.DefaultCellStyle = DataGridViewCellStyle16
        Me.resta.HeaderText = "Resta"
        Me.resta.Name = "resta"
        Me.resta.Width = 75
        '
        'abono
        '
        Me.abono.DataPropertyName = "abono"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.Blue
        Me.abono.DefaultCellStyle = DataGridViewCellStyle17
        Me.abono.HeaderText = "Abono"
        Me.abono.Name = "abono"
        Me.abono.Width = 75
        '
        'txtTotalComprobante
        '
        Me.txtTotalComprobante.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTotalComprobante.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalComprobante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTotalComprobante.Location = New System.Drawing.Point(641, 162)
        Me.txtTotalComprobante.Name = "txtTotalComprobante"
        Me.txtTotalComprobante.Size = New System.Drawing.Size(121, 21)
        Me.txtTotalComprobante.TabIndex = 175
        Me.txtTotalComprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(581, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 16)
        Me.Label9.TabIndex = 178
        Me.Label9.Text = "Total S/. "
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnConsultar.ForeColor = System.Drawing.Color.White
        Me.btnConsultar.Location = New System.Drawing.Point(657, 178)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(105, 35)
        Me.btnConsultar.TabIndex = 110
        Me.btnConsultar.Text = "PROCESAR"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtDiferenciaS)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtTHaberS)
        Me.GroupBox2.Controls.Add(Me.txtTDebeS)
        Me.GroupBox2.Controls.Add(Me.dgvLista)
        Me.GroupBox2.Controls.Add(Me.btnConsultar)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 330)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(768, 219)
        Me.GroupBox2.TabIndex = 115
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Referencia del Documento de Venta"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(257, 173)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(79, 16)
        Me.Label22.TabIndex = 162
        Me.Label22.Text = "Diferencia S/."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(130, 173)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 16)
        Me.Label17.TabIndex = 161
        Me.Label17.Text = "Total Haber S/."
        '
        'txtDiferenciaS
        '
        Me.txtDiferenciaS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDiferenciaS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferenciaS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDiferenciaS.Location = New System.Drawing.Point(260, 192)
        Me.txtDiferenciaS.Name = "txtDiferenciaS"
        Me.txtDiferenciaS.Size = New System.Drawing.Size(121, 21)
        Me.txtDiferenciaS.TabIndex = 159
        Me.txtDiferenciaS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 160
        Me.Label1.Text = "Total Debe S/. "
        '
        'txtTHaberS
        '
        Me.txtTHaberS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTHaberS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTHaberS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTHaberS.Location = New System.Drawing.Point(133, 192)
        Me.txtTHaberS.Name = "txtTHaberS"
        Me.txtTHaberS.Size = New System.Drawing.Size(121, 21)
        Me.txtTHaberS.TabIndex = 158
        Me.txtTHaberS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTDebeS
        '
        Me.txtTDebeS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTDebeS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTDebeS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTDebeS.Location = New System.Drawing.Point(6, 192)
        Me.txtTDebeS.Name = "txtTDebeS"
        Me.txtTDebeS.Size = New System.Drawing.Size(121, 21)
        Me.txtTDebeS.TabIndex = 157
        Me.txtTDebeS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_venta, Me.num_cuenta, Me.desc_cuenta, Me.serieventa, Me.numeroventa, Me.glosaV, Me.debe, Me.haber})
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle22
        Me.dgvLista.Location = New System.Drawing.Point(6, 20)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.Size = New System.Drawing.Size(756, 150)
        Me.dgvLista.TabIndex = 111
        '
        'id_venta
        '
        Me.id_venta.DataPropertyName = "id_venta"
        Me.id_venta.HeaderText = "id_venta"
        Me.id_venta.Name = "id_venta"
        Me.id_venta.ReadOnly = True
        Me.id_venta.Visible = False
        '
        'num_cuenta
        '
        Me.num_cuenta.DataPropertyName = "num_cuenta"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.num_cuenta.DefaultCellStyle = DataGridViewCellStyle19
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
        Me.desc_cuenta.Width = 318
        '
        'serieventa
        '
        Me.serieventa.DataPropertyName = "serie"
        Me.serieventa.HeaderText = "Serie"
        Me.serieventa.Name = "serieventa"
        Me.serieventa.ReadOnly = True
        Me.serieventa.Width = 70
        '
        'numeroventa
        '
        Me.numeroventa.DataPropertyName = "numero"
        Me.numeroventa.HeaderText = "Número"
        Me.numeroventa.Name = "numeroventa"
        Me.numeroventa.ReadOnly = True
        Me.numeroventa.Width = 70
        '
        'glosaV
        '
        Me.glosaV.DataPropertyName = "glosa"
        Me.glosaV.HeaderText = "Glosa"
        Me.glosaV.Name = "glosaV"
        Me.glosaV.ReadOnly = True
        Me.glosaV.Visible = False
        Me.glosaV.Width = 110
        '
        'debe
        '
        Me.debe.DataPropertyName = "debe"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.debe.DefaultCellStyle = DataGridViewCellStyle20
        Me.debe.HeaderText = "Debe"
        Me.debe.Name = "debe"
        Me.debe.ReadOnly = True
        Me.debe.Width = 80
        '
        'haber
        '
        Me.haber.DataPropertyName = "haber"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.haber.DefaultCellStyle = DataGridViewCellStyle21
        Me.haber.HeaderText = "Haber"
        Me.haber.Name = "haber"
        Me.haber.ReadOnly = True
        Me.haber.Width = 80
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(219, 85)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(172, 25)
        Me.cboTipo.TabIndex = 229
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(522, 178)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 35)
        Me.Button2.TabIndex = 163
        Me.Button2.Text = "CONCILIACION"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmAbonoDeudasBanco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 561)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAbonoDeudasBanco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago de Deuda - Comprobante Venta"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvComprobante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents dgvComprobante As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTotalComprobante As System.Windows.Forms.TextBox
    Friend WithEvents dtPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblNomCuenta As System.Windows.Forms.Label
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtDiferenciaS As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTHaberS As System.Windows.Forms.TextBox
    Friend WithEvents txtTDebeS As System.Windows.Forms.TextBox
    Friend WithEvents id_venta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents num_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serieventa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numeroventa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents glosaV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents glosa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pagado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents resta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents abono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboBanco As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtGlosa As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
