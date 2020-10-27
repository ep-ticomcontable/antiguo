<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbonoLetras
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtTotalComprobante = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtDiferenciaS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTHaberS = New System.Windows.Forms.TextBox()
        Me.txtTDebeS = New System.Windows.Forms.TextBox()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.id_letra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serieLetra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numeroLetra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_tipo_pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.operacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.glosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_caja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_banco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnAbonar = New System.Windows.Forms.Button()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtGlosa = New System.Windows.Forms.TextBox()
        Me.btnCaja = New System.Windows.Forms.Button()
        Me.txtIdBanco = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCuentaCaja = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIdCaja = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCaja = New System.Windows.Forms.Label()
        Me.dtPago = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTotalReg = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvComprobante = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.librador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.resta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.abono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvComprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTotalComprobante
        '
        Me.txtTotalComprobante.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTotalComprobante.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalComprobante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTotalComprobante.Location = New System.Drawing.Point(641, 84)
        Me.txtTotalComprobante.Name = "txtTotalComprobante"
        Me.txtTotalComprobante.Size = New System.Drawing.Size(113, 24)
        Me.txtTotalComprobante.TabIndex = 175
        Me.txtTotalComprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(592, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 16)
        Me.Label9.TabIndex = 178
        Me.Label9.Text = "TOTAL:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtDiferenciaS)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtTHaberS)
        Me.GroupBox2.Controls.Add(Me.txtTDebeS)
        Me.GroupBox2.Controls.Add(Me.dgvLista)
        Me.GroupBox2.Controls.Add(Me.btnConsultar)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 283)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(760, 166)
        Me.GroupBox2.TabIndex = 228
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Asiento de Abonos a Pagar"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(257, 120)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(79, 16)
        Me.Label22.TabIndex = 162
        Me.Label22.Text = "Diferencia S/."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(130, 120)
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
        Me.txtDiferenciaS.Location = New System.Drawing.Point(260, 139)
        Me.txtDiferenciaS.Name = "txtDiferenciaS"
        Me.txtDiferenciaS.Size = New System.Drawing.Size(121, 21)
        Me.txtDiferenciaS.TabIndex = 159
        Me.txtDiferenciaS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 120)
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
        Me.txtTHaberS.Location = New System.Drawing.Point(133, 139)
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
        Me.txtTDebeS.Location = New System.Drawing.Point(6, 139)
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
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_letra, Me.num_cuenta, Me.desc_cuenta, Me.debe, Me.haber, Me.serieLetra, Me.numeroLetra, Me.id_tipo_pago, Me.tipo_pago, Me.operacion, Me.glosa, Me.id_caja, Me.id_banco})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvLista.Location = New System.Drawing.Point(6, 20)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.Size = New System.Drawing.Size(748, 97)
        Me.dgvLista.TabIndex = 111
        '
        'id_letra
        '
        Me.id_letra.DataPropertyName = "id_letra"
        Me.id_letra.HeaderText = "id_letra"
        Me.id_letra.Name = "id_letra"
        Me.id_letra.Visible = False
        '
        'num_cuenta
        '
        Me.num_cuenta.DataPropertyName = "num_cuenta"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.num_cuenta.DefaultCellStyle = DataGridViewCellStyle1
        Me.num_cuenta.HeaderText = "Cta."
        Me.num_cuenta.Name = "num_cuenta"
        Me.num_cuenta.Width = 50
        '
        'desc_cuenta
        '
        Me.desc_cuenta.DataPropertyName = "desc_cuenta"
        Me.desc_cuenta.HeaderText = "Desc. Cuenta"
        Me.desc_cuenta.Name = "desc_cuenta"
        Me.desc_cuenta.Width = 200
        '
        'debe
        '
        Me.debe.DataPropertyName = "debe"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.debe.DefaultCellStyle = DataGridViewCellStyle2
        Me.debe.HeaderText = "DEBE"
        Me.debe.Name = "debe"
        Me.debe.Width = 80
        '
        'haber
        '
        Me.haber.DataPropertyName = "haber"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.haber.DefaultCellStyle = DataGridViewCellStyle3
        Me.haber.HeaderText = "HABER"
        Me.haber.Name = "haber"
        Me.haber.Width = 80
        '
        'serieLetra
        '
        Me.serieLetra.DataPropertyName = "serie"
        Me.serieLetra.HeaderText = "SERIE"
        Me.serieLetra.Name = "serieLetra"
        Me.serieLetra.Width = 50
        '
        'numeroLetra
        '
        Me.numeroLetra.DataPropertyName = "numero"
        Me.numeroLetra.HeaderText = "N°"
        Me.numeroLetra.Name = "numeroLetra"
        Me.numeroLetra.Width = 50
        '
        'id_tipo_pago
        '
        Me.id_tipo_pago.DataPropertyName = "id_tipo_pago"
        Me.id_tipo_pago.HeaderText = "id_tipo_pago"
        Me.id_tipo_pago.Name = "id_tipo_pago"
        Me.id_tipo_pago.Visible = False
        '
        'tipo_pago
        '
        Me.tipo_pago.DataPropertyName = "tipo_pago"
        Me.tipo_pago.HeaderText = "TIPO PAGO"
        Me.tipo_pago.Name = "tipo_pago"
        '
        'operacion
        '
        Me.operacion.DataPropertyName = "operacion"
        Me.operacion.HeaderText = "N° OPER"
        Me.operacion.Name = "operacion"
        Me.operacion.Width = 80
        '
        'glosa
        '
        Me.glosa.DataPropertyName = "glosa"
        Me.glosa.HeaderText = "GLOSA"
        Me.glosa.Name = "glosa"
        Me.glosa.Width = 110
        '
        'id_caja
        '
        Me.id_caja.DataPropertyName = "id_caja"
        Me.id_caja.HeaderText = "id_caja"
        Me.id_caja.Name = "id_caja"
        Me.id_caja.Visible = False
        '
        'id_banco
        '
        Me.id_banco.DataPropertyName = "id_banco"
        Me.id_banco.HeaderText = "id_banco"
        Me.id_banco.Name = "id_banco"
        Me.id_banco.Visible = False
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnConsultar.ForeColor = System.Drawing.Color.White
        Me.btnConsultar.Location = New System.Drawing.Point(649, 125)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(105, 35)
        Me.btnConsultar.TabIndex = 110
        Me.btnConsultar.Text = "PAGAR"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 25.0!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(5, 10)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(289, 40)
        Me.lblTitulo.TabIndex = 229
        Me.lblTitulo.Text = "PAGO DE LETRAS"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnAbonar)
        Me.GroupBox3.Controls.Add(Me.txtMonto)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtNumero)
        Me.GroupBox3.Controls.Add(Me.txtGlosa)
        Me.GroupBox3.Controls.Add(Me.btnCaja)
        Me.GroupBox3.Controls.Add(Me.txtIdBanco)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtCuentaCaja)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtIdCaja)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.cboTipo)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.lblCaja)
        Me.GroupBox3.Controls.Add(Me.dtPago)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 171)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(760, 106)
        Me.GroupBox3.TabIndex = 227
        Me.GroupBox3.TabStop = False
        '
        'btnAbonar
        '
        Me.btnAbonar.BackColor = System.Drawing.Color.Green
        Me.btnAbonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbonar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnAbonar.ForeColor = System.Drawing.Color.White
        Me.btnAbonar.Location = New System.Drawing.Point(481, 73)
        Me.btnAbonar.Name = "btnAbonar"
        Me.btnAbonar.Size = New System.Drawing.Size(97, 30)
        Me.btnAbonar.TabIndex = 113
        Me.btnAbonar.Text = "AGREGAR"
        Me.btnAbonar.UseVisualStyleBackColor = False
        '
        'txtMonto
        '
        Me.txtMonto.Enabled = False
        Me.txtMonto.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtMonto.Location = New System.Drawing.Point(107, 28)
        Me.txtMonto.MaxLength = 1000
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(94, 25)
        Me.txtMonto.TabIndex = 239
        Me.txtMonto.Text = "0.00"
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(104, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 16)
        Me.Label12.TabIndex = 240
        Me.Label12.Text = "MONTO:"
        '
        'txtNumero
        '
        Me.txtNumero.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtNumero.Location = New System.Drawing.Point(6, 76)
        Me.txtNumero.MaxLength = 1000
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(154, 25)
        Me.txtNumero.TabIndex = 223
        Me.txtNumero.Text = "0"
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGlosa
        '
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtGlosa.Location = New System.Drawing.Point(166, 76)
        Me.txtGlosa.MaxLength = 1000
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(309, 25)
        Me.txtGlosa.TabIndex = 227
        '
        'btnCaja
        '
        Me.btnCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCaja.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.btnCaja.ForeColor = System.Drawing.Color.White
        Me.btnCaja.Location = New System.Drawing.Point(207, 24)
        Me.btnCaja.Name = "btnCaja"
        Me.btnCaja.Size = New System.Drawing.Size(89, 30)
        Me.btnCaja.TabIndex = 238
        Me.btnCaja.Text = "ELEGIR CAJA"
        Me.btnCaja.UseVisualStyleBackColor = False
        '
        'txtIdBanco
        '
        Me.txtIdBanco.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtIdBanco.Location = New System.Drawing.Point(695, 77)
        Me.txtIdBanco.MaxLength = 1000
        Me.txtIdBanco.Name = "txtIdBanco"
        Me.txtIdBanco.Size = New System.Drawing.Size(55, 24)
        Me.txtIdBanco.TabIndex = 236
        Me.txtIdBanco.Text = "0"
        Me.txtIdBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtIdBanco.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 7.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(692, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 15)
        Me.Label8.TabIndex = 237
        Me.Label8.Text = "Banco"
        Me.Label8.Visible = False
        '
        'txtCuentaCaja
        '
        Me.txtCuentaCaja.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtCuentaCaja.Location = New System.Drawing.Point(634, 77)
        Me.txtCuentaCaja.MaxLength = 1000
        Me.txtCuentaCaja.Name = "txtCuentaCaja"
        Me.txtCuentaCaja.Size = New System.Drawing.Size(55, 24)
        Me.txtCuentaCaja.TabIndex = 233
        Me.txtCuentaCaja.Text = "0"
        Me.txtCuentaCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCuentaCaja.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 7.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(631, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 15)
        Me.Label7.TabIndex = 235
        Me.Label7.Text = "Cuenta"
        Me.Label7.Visible = False
        '
        'txtIdCaja
        '
        Me.txtIdCaja.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtIdCaja.Location = New System.Drawing.Point(573, 77)
        Me.txtIdCaja.MaxLength = 1000
        Me.txtIdCaja.Name = "txtIdCaja"
        Me.txtIdCaja.Size = New System.Drawing.Size(55, 24)
        Me.txtIdCaja.TabIndex = 232
        Me.txtIdCaja.Text = "0"
        Me.txtIdCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtIdCaja.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 7.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(570, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 15)
        Me.Label3.TabIndex = 234
        Me.Label3.Text = "Caja"
        Me.Label3.Visible = False
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(481, 28)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(273, 24)
        Me.cboTipo.TabIndex = 229
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(163, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 16)
        Me.Label5.TabIndex = 228
        Me.Label5.Text = "GLOSA / COMENTARIOS:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(478, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 16)
        Me.Label6.TabIndex = 226
        Me.Label6.Text = "TIPO PAGO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(6, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 16)
        Me.Label4.TabIndex = 224
        Me.Label4.Text = "N°/OPERACIÓN:"
        '
        'lblCaja
        '
        Me.lblCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCaja.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaja.ForeColor = System.Drawing.Color.DimGray
        Me.lblCaja.Location = New System.Drawing.Point(296, 29)
        Me.lblCaja.Name = "lblCaja"
        Me.lblCaja.Size = New System.Drawing.Size(179, 20)
        Me.lblCaja.TabIndex = 116
        Me.lblCaja.Text = "[Nombre de la caja]"
        Me.lblCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtPago
        '
        Me.dtPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPago.Location = New System.Drawing.Point(6, 31)
        Me.dtPago.Name = "dtPago"
        Me.dtPago.Size = New System.Drawing.Size(95, 21)
        Me.dtPago.TabIndex = 115
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label2.Location = New System.Drawing.Point(3, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "FECHA ABONO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTotalReg)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.dgvComprobante)
        Me.GroupBox1.Controls.Add(Me.txtTotalComprobante)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(760, 112)
        Me.GroupBox1.TabIndex = 226
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LETRA(S) DE REFERENCIA"
        '
        'lblTotalReg
        '
        Me.lblTotalReg.AutoSize = True
        Me.lblTotalReg.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalReg.Location = New System.Drawing.Point(81, 84)
        Me.lblTotalReg.Name = "lblTotalReg"
        Me.lblTotalReg.Size = New System.Drawing.Size(16, 17)
        Me.lblTotalReg.TabIndex = 180
        Me.lblTotalReg.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 16)
        Me.Label10.TabIndex = 179
        Me.Label10.Text = "N° DE LETRAS:"
        '
        'dgvComprobante
        '
        Me.dgvComprobante.AllowUserToAddRows = False
        Me.dgvComprobante.AllowUserToDeleteRows = False
        Me.dgvComprobante.AllowUserToOrderColumns = True
        Me.dgvComprobante.BackgroundColor = System.Drawing.Color.White
        Me.dgvComprobante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvComprobante.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.fecha, Me.serie, Me.numero, Me.librador, Me.moneda, Me.total, Me.pagado, Me.resta, Me.abono})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvComprobante.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvComprobante.Location = New System.Drawing.Point(8, 18)
        Me.dgvComprobante.Name = "dgvComprobante"
        Me.dgvComprobante.ReadOnly = True
        Me.dgvComprobante.Size = New System.Drawing.Size(745, 60)
        Me.dgvComprobante.TabIndex = 111
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.id.DefaultCellStyle = DataGridViewCellStyle5
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        Me.id.Width = 50
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "fecha"
        Me.fecha.HeaderText = "FECHA"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 80
        '
        'serie
        '
        Me.serie.DataPropertyName = "serie"
        Me.serie.HeaderText = "SERIE"
        Me.serie.Name = "serie"
        Me.serie.ReadOnly = True
        Me.serie.Width = 50
        '
        'numero
        '
        Me.numero.DataPropertyName = "numero"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.numero.DefaultCellStyle = DataGridViewCellStyle6
        Me.numero.HeaderText = "N°"
        Me.numero.Name = "numero"
        Me.numero.ReadOnly = True
        Me.numero.Width = 45
        '
        'librador
        '
        Me.librador.DataPropertyName = "librador"
        Me.librador.HeaderText = "LIBRADOR"
        Me.librador.Name = "librador"
        Me.librador.ReadOnly = True
        Me.librador.Width = 242
        '
        'moneda
        '
        Me.moneda.DataPropertyName = "moneda"
        Me.moneda.HeaderText = "MND"
        Me.moneda.Name = "moneda"
        Me.moneda.ReadOnly = True
        Me.moneda.Width = 45
        '
        'total
        '
        Me.total.DataPropertyName = "total"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.total.DefaultCellStyle = DataGridViewCellStyle7
        Me.total.HeaderText = "TOTAL"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Width = 80
        '
        'pagado
        '
        Me.pagado.DataPropertyName = "pagado"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Green
        Me.pagado.DefaultCellStyle = DataGridViewCellStyle8
        Me.pagado.HeaderText = "PAGADO"
        Me.pagado.Name = "pagado"
        Me.pagado.ReadOnly = True
        Me.pagado.Width = 80
        '
        'resta
        '
        Me.resta.DataPropertyName = "resta"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Red
        Me.resta.DefaultCellStyle = DataGridViewCellStyle9
        Me.resta.HeaderText = "RESTA"
        Me.resta.Name = "resta"
        Me.resta.ReadOnly = True
        Me.resta.Width = 80
        '
        'abono
        '
        Me.abono.DataPropertyName = "abono"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Blue
        Me.abono.DefaultCellStyle = DataGridViewCellStyle10
        Me.abono.HeaderText = "ABONO"
        Me.abono.Name = "abono"
        Me.abono.ReadOnly = True
        Me.abono.Visible = False
        Me.abono.Width = 75
        '
        'frmAbonoLetras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmAbonoLetras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAGAR LETRAS"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvComprobante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTotalComprobante As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtDiferenciaS As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTHaberS As System.Windows.Forms.TextBox
    Friend WithEvents txtTDebeS As System.Windows.Forms.TextBox
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtGlosa As System.Windows.Forms.TextBox
    Friend WithEvents btnCaja As System.Windows.Forms.Button
    Friend WithEvents txtIdBanco As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaCaja As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtIdCaja As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCaja As System.Windows.Forms.Label
    Friend WithEvents btnAbonar As System.Windows.Forms.Button
    Friend WithEvents dtPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalReg As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgvComprobante As System.Windows.Forms.DataGridView
    Friend WithEvents id_letra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents num_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serieLetra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numeroLetra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_tipo_pago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_pago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents operacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents glosa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_caja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_banco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents librador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents moneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pagado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents resta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents abono As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
