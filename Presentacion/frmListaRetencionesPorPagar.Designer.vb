<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaRetencionesPorPagar
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.lblNomCuenta = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTituloForm = New System.Windows.Forms.Label()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtTHaberS = New System.Windows.Forms.TextBox()
        Me.txtTDebeS = New System.Windows.Forms.TextBox()
        Me.txtDiferenciaS = New System.Windows.Forms.TextBox()
        Me.dgvOperaciones = New System.Windows.Forms.DataGridView()
        Me.num_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.chek = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.id_ret = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ruc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_comprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.glosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.retenido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fec_reg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtGlosa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabRetencion = New System.Windows.Forms.TabControl()
        Me.tbLista = New System.Windows.Forms.TabPage()
        Me.dgvAsientoAbono = New System.Windows.Forms.DataGridView()
        Me.anum_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adesc_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adebe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ahaber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.lblAbonos = New System.Windows.Forms.Label()
        Me.tbPago = New System.Windows.Forms.TabPage()
        Me.txtIdCaja = New System.Windows.Forms.TextBox()
        Me.cboDH = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.dgvOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRetencion.SuspendLayout()
        Me.tbLista.SuspendLayout()
        CType(Me.dgvAsientoAbono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbPago.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Green
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(674, 21)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(72, 29)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(281, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 17)
        Me.Label8.TabIndex = 320
        Me.Label8.Text = "Monto:"
        '
        'txtMonto
        '
        Me.txtMonto.BackColor = System.Drawing.Color.White
        Me.txtMonto.Enabled = False
        Me.txtMonto.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtMonto.Location = New System.Drawing.Point(284, 24)
        Me.txtMonto.MaxLength = 11
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(75, 21)
        Me.txtMonto.TabIndex = 1
        Me.txtMonto.Text = "0.00"
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCuenta
        '
        Me.txtCuenta.BackColor = System.Drawing.Color.White
        Me.txtCuenta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtCuenta.Location = New System.Drawing.Point(6, 25)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(50, 21)
        Me.txtCuenta.TabIndex = 0
        Me.txtCuenta.Text = "101"
        Me.txtCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNomCuenta
        '
        Me.lblNomCuenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNomCuenta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblNomCuenta.Location = New System.Drawing.Point(56, 25)
        Me.lblNomCuenta.Name = "lblNomCuenta"
        Me.lblNomCuenta.Size = New System.Drawing.Size(222, 21)
        Me.lblNomCuenta.TabIndex = 308
        Me.lblNomCuenta.Text = "[Nombre Cuenta]"
        Me.lblNomCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 17)
        Me.Label6.TabIndex = 307
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
        Me.lblTituloForm.Size = New System.Drawing.Size(442, 59)
        Me.lblTituloForm.TabIndex = 5
        Me.lblTituloForm.Text = "RETENCIONES POR PAGAR"
        '
        'btnFinalizar
        '
        Me.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnFinalizar.ForeColor = System.Drawing.Color.White
        Me.btnFinalizar.Location = New System.Drawing.Point(651, 142)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(95, 35)
        Me.btnFinalizar.TabIndex = 2
        Me.btnFinalizar.Text = "FINALIZAR"
        Me.btnFinalizar.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(189, 139)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(65, 16)
        Me.Label25.TabIndex = 286
        Me.Label25.Text = "Diferencia:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(3, 139)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(70, 16)
        Me.Label27.TabIndex = 284
        Me.Label27.Text = "Total Debe:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(96, 139)
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
        Me.txtTHaberS.Location = New System.Drawing.Point(99, 156)
        Me.txtTHaberS.Name = "txtTHaberS"
        Me.txtTHaberS.ReadOnly = True
        Me.txtTHaberS.Size = New System.Drawing.Size(87, 21)
        Me.txtTHaberS.TabIndex = 282
        Me.txtTHaberS.TabStop = False
        Me.txtTHaberS.Text = "0"
        Me.txtTHaberS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTDebeS
        '
        Me.txtTDebeS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTDebeS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTDebeS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTDebeS.Location = New System.Drawing.Point(6, 156)
        Me.txtTDebeS.Name = "txtTDebeS"
        Me.txtTDebeS.ReadOnly = True
        Me.txtTDebeS.Size = New System.Drawing.Size(87, 21)
        Me.txtTDebeS.TabIndex = 281
        Me.txtTDebeS.TabStop = False
        Me.txtTDebeS.Text = "0"
        Me.txtTDebeS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiferenciaS
        '
        Me.txtDiferenciaS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDiferenciaS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferenciaS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDiferenciaS.Location = New System.Drawing.Point(192, 156)
        Me.txtDiferenciaS.Name = "txtDiferenciaS"
        Me.txtDiferenciaS.ReadOnly = True
        Me.txtDiferenciaS.Size = New System.Drawing.Size(87, 21)
        Me.txtDiferenciaS.TabIndex = 283
        Me.txtDiferenciaS.TabStop = False
        Me.txtDiferenciaS.Text = "0"
        Me.txtDiferenciaS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvOperaciones
        '
        Me.dgvOperaciones.AllowUserToAddRows = False
        Me.dgvOperaciones.BackgroundColor = System.Drawing.Color.White
        Me.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOperaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num_cuenta, Me.desc_cuenta, Me.debe, Me.haber})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOperaciones.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvOperaciones.Location = New System.Drawing.Point(6, 52)
        Me.dgvOperaciones.Name = "dgvOperaciones"
        Me.dgvOperaciones.Size = New System.Drawing.Size(740, 82)
        Me.dgvOperaciones.TabIndex = 335
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
        Me.desc_cuenta.Width = 408
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
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToOrderColumns = True
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chek, Me.id_ret, Me.serie, Me.numero, Me.proveedor, Me.ruc, Me.id_comprobante, Me.factura, Me.glosa, Me.moneda, Me.total, Me.retenido, Me.fec_reg, Me.estado})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvLista.Location = New System.Drawing.Point(12, 63)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.Size = New System.Drawing.Size(760, 217)
        Me.dgvLista.TabIndex = 334
        '
        'chek
        '
        Me.chek.HeaderText = "[X]"
        Me.chek.Name = "chek"
        Me.chek.Visible = False
        Me.chek.Width = 30
        '
        'id_ret
        '
        Me.id_ret.DataPropertyName = "id_ret"
        Me.id_ret.HeaderText = "id_ret"
        Me.id_ret.Name = "id_ret"
        Me.id_ret.Visible = False
        '
        'serie
        '
        Me.serie.DataPropertyName = "serie"
        Me.serie.HeaderText = "SERIE"
        Me.serie.Name = "serie"
        Me.serie.Width = 50
        '
        'numero
        '
        Me.numero.DataPropertyName = "numero"
        Me.numero.HeaderText = "NUM"
        Me.numero.Name = "numero"
        Me.numero.Width = 50
        '
        'proveedor
        '
        Me.proveedor.DataPropertyName = "proveedor"
        Me.proveedor.HeaderText = "PROVEEDOR"
        Me.proveedor.Name = "proveedor"
        Me.proveedor.Width = 150
        '
        'ruc
        '
        Me.ruc.DataPropertyName = "ruc"
        Me.ruc.HeaderText = "RUC"
        Me.ruc.Name = "ruc"
        '
        'id_comprobante
        '
        Me.id_comprobante.DataPropertyName = "id_comprobante"
        Me.id_comprobante.HeaderText = "COD"
        Me.id_comprobante.Name = "id_comprobante"
        Me.id_comprobante.Width = 50
        '
        'factura
        '
        Me.factura.DataPropertyName = "factura"
        Me.factura.HeaderText = "FACTURA"
        Me.factura.Name = "factura"
        Me.factura.Width = 80
        '
        'glosa
        '
        Me.glosa.DataPropertyName = "glosa"
        Me.glosa.HeaderText = "GLOSA"
        Me.glosa.Name = "glosa"
        Me.glosa.Width = 150
        '
        'moneda
        '
        Me.moneda.DataPropertyName = "moneda"
        Me.moneda.HeaderText = "MND"
        Me.moneda.Name = "moneda"
        Me.moneda.Width = 50
        '
        'total
        '
        Me.total.DataPropertyName = "total"
        Me.total.HeaderText = "TOTAL"
        Me.total.Name = "total"
        Me.total.Width = 80
        '
        'retenido
        '
        Me.retenido.DataPropertyName = "retenido"
        Me.retenido.HeaderText = "RETENIDO"
        Me.retenido.Name = "retenido"
        Me.retenido.Width = 80
        '
        'fec_reg
        '
        Me.fec_reg.DataPropertyName = "fec_reg"
        Me.fec_reg.HeaderText = "FECHA"
        Me.fec_reg.Name = "fec_reg"
        Me.fec_reg.Width = 80
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "ESTADO"
        Me.estado.Name = "estado"
        '
        'txtGlosa
        '
        Me.txtGlosa.BackColor = System.Drawing.Color.White
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.Black
        Me.txtGlosa.Location = New System.Drawing.Point(430, 25)
        Me.txtGlosa.MaxLength = 9999
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(238, 21)
        Me.txtGlosa.TabIndex = 336
        Me.txtGlosa.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(427, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 337
        Me.Label1.Text = "Glosa:"
        '
        'tabRetencion
        '
        Me.tabRetencion.Controls.Add(Me.tbLista)
        Me.tabRetencion.Controls.Add(Me.tbPago)
        Me.tabRetencion.Location = New System.Drawing.Point(12, 286)
        Me.tabRetencion.Name = "tabRetencion"
        Me.tabRetencion.SelectedIndex = 0
        Me.tabRetencion.Size = New System.Drawing.Size(760, 213)
        Me.tabRetencion.TabIndex = 335
        '
        'tbLista
        '
        Me.tbLista.Controls.Add(Me.dgvAsientoAbono)
        Me.tbLista.Controls.Add(Me.btnPagar)
        Me.tbLista.Controls.Add(Me.lblAbonos)
        Me.tbLista.Location = New System.Drawing.Point(4, 26)
        Me.tbLista.Name = "tbLista"
        Me.tbLista.Padding = New System.Windows.Forms.Padding(3)
        Me.tbLista.Size = New System.Drawing.Size(752, 183)
        Me.tbLista.TabIndex = 1
        Me.tbLista.Text = "ASIENTOS ABONO RETENCIONES"
        Me.tbLista.UseVisualStyleBackColor = True
        '
        'dgvAsientoAbono
        '
        Me.dgvAsientoAbono.AllowUserToAddRows = False
        Me.dgvAsientoAbono.BackgroundColor = System.Drawing.Color.White
        Me.dgvAsientoAbono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAsientoAbono.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.anum_cuenta, Me.adesc_cuenta, Me.adebe, Me.ahaber})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAsientoAbono.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvAsientoAbono.Location = New System.Drawing.Point(6, 6)
        Me.dgvAsientoAbono.Name = "dgvAsientoAbono"
        Me.dgvAsientoAbono.Size = New System.Drawing.Size(740, 171)
        Me.dgvAsientoAbono.TabIndex = 336
        '
        'anum_cuenta
        '
        Me.anum_cuenta.DataPropertyName = "num_cuenta"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.anum_cuenta.DefaultCellStyle = DataGridViewCellStyle6
        Me.anum_cuenta.HeaderText = "Cta."
        Me.anum_cuenta.Name = "anum_cuenta"
        Me.anum_cuenta.Width = 70
        '
        'adesc_cuenta
        '
        Me.adesc_cuenta.DataPropertyName = "desc_cuenta"
        Me.adesc_cuenta.HeaderText = "Desc."
        Me.adesc_cuenta.Name = "adesc_cuenta"
        Me.adesc_cuenta.Width = 408
        '
        'adebe
        '
        Me.adebe.DataPropertyName = "debe"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.adebe.DefaultCellStyle = DataGridViewCellStyle7
        Me.adebe.HeaderText = "Debe"
        Me.adebe.Name = "adebe"
        '
        'ahaber
        '
        Me.ahaber.DataPropertyName = "haber"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.ahaber.DefaultCellStyle = DataGridViewCellStyle8
        Me.ahaber.HeaderText = "Haber"
        Me.ahaber.Name = "ahaber"
        '
        'btnPagar
        '
        Me.btnPagar.BackColor = System.Drawing.Color.Green
        Me.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPagar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnPagar.ForeColor = System.Drawing.Color.White
        Me.btnPagar.Location = New System.Drawing.Point(285, 103)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(182, 35)
        Me.btnPagar.TabIndex = 338
        Me.btnPagar.Text = "REALIZAR PAGO"
        Me.btnPagar.UseVisualStyleBackColor = False
        '
        'lblAbonos
        '
        Me.lblAbonos.AutoSize = True
        Me.lblAbonos.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbonos.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblAbonos.Location = New System.Drawing.Point(83, 45)
        Me.lblAbonos.Name = "lblAbonos"
        Me.lblAbonos.Size = New System.Drawing.Size(586, 42)
        Me.lblAbonos.TabIndex = 337
        Me.lblAbonos.Text = "NO SE HAN REGISTRADO ABONOS"
        '
        'tbPago
        '
        Me.tbPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbPago.Controls.Add(Me.txtIdCaja)
        Me.tbPago.Controls.Add(Me.cboDH)
        Me.tbPago.Controls.Add(Me.txtCuenta)
        Me.tbPago.Controls.Add(Me.txtMonto)
        Me.tbPago.Controls.Add(Me.txtGlosa)
        Me.tbPago.Controls.Add(Me.Label1)
        Me.tbPago.Controls.Add(Me.Label6)
        Me.tbPago.Controls.Add(Me.dgvOperaciones)
        Me.tbPago.Controls.Add(Me.Label24)
        Me.tbPago.Controls.Add(Me.Label25)
        Me.tbPago.Controls.Add(Me.btnAgregar)
        Me.tbPago.Controls.Add(Me.Label27)
        Me.tbPago.Controls.Add(Me.Label8)
        Me.tbPago.Controls.Add(Me.Label26)
        Me.tbPago.Controls.Add(Me.txtTHaberS)
        Me.tbPago.Controls.Add(Me.btnFinalizar)
        Me.tbPago.Controls.Add(Me.txtTDebeS)
        Me.tbPago.Controls.Add(Me.lblNomCuenta)
        Me.tbPago.Controls.Add(Me.txtDiferenciaS)
        Me.tbPago.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPago.Location = New System.Drawing.Point(4, 26)
        Me.tbPago.Name = "tbPago"
        Me.tbPago.Padding = New System.Windows.Forms.Padding(3)
        Me.tbPago.Size = New System.Drawing.Size(752, 183)
        Me.tbPago.TabIndex = 0
        Me.tbPago.Text = "PAGO DE RETENCION"
        '
        'txtIdCaja
        '
        Me.txtIdCaja.BackColor = System.Drawing.Color.White
        Me.txtIdCaja.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCaja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtIdCaja.Location = New System.Drawing.Point(334, 156)
        Me.txtIdCaja.Name = "txtIdCaja"
        Me.txtIdCaja.Size = New System.Drawing.Size(50, 21)
        Me.txtIdCaja.TabIndex = 338
        Me.txtIdCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtIdCaja.Visible = False
        '
        'cboDH
        '
        Me.cboDH.BackColor = System.Drawing.Color.White
        Me.cboDH.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDH.FormattingEnabled = True
        Me.cboDH.Location = New System.Drawing.Point(365, 23)
        Me.cboDH.Name = "cboDH"
        Me.cboDH.Size = New System.Drawing.Size(59, 23)
        Me.cboDH.TabIndex = 2
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(362, 8)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(32, 16)
        Me.Label24.TabIndex = 328
        Me.Label24.Text = "D/H:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(478, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 23)
        Me.Button1.TabIndex = 336
        Me.Button1.Text = "COMPRAS"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(378, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 23)
        Me.Button2.TabIndex = 337
        Me.Button2.Text = "ACTUALIZAR"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(567, 24)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 23)
        Me.Button3.TabIndex = 338
        Me.Button3.Text = "CAJAS"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(678, 24)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 23)
        Me.Button4.TabIndex = 339
        Me.Button4.Text = "PERCEPCION"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'frmListaRetencionesPorPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 511)
        Me.Controls.Add(Me.lblTituloForm)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tabRetencion)
        Me.Controls.Add(Me.dgvLista)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmListaRetencionesPorPagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RETENCIONES - COMPRAS"
        CType(Me.dgvOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRetencion.ResumeLayout(False)
        Me.tbLista.ResumeLayout(False)
        Me.tbLista.PerformLayout()
        CType(Me.dgvAsientoAbono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbPago.ResumeLayout(False)
        Me.tbPago.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTituloForm As System.Windows.Forms.Label
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblNomCuenta As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnFinalizar As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtTHaberS As System.Windows.Forms.TextBox
    Friend WithEvents txtTDebeS As System.Windows.Forms.TextBox
    Friend WithEvents txtDiferenciaS As System.Windows.Forms.TextBox
    Friend WithEvents dgvOperaciones As System.Windows.Forms.DataGridView
    Friend WithEvents txtGlosa As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents tabRetencion As System.Windows.Forms.TabControl
    Friend WithEvents tbPago As System.Windows.Forms.TabPage
    Friend WithEvents tbLista As System.Windows.Forms.TabPage
    Friend WithEvents dgvAsientoAbono As System.Windows.Forms.DataGridView
    Friend WithEvents anum_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents adesc_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents adebe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ahaber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents num_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtIdCaja As System.Windows.Forms.TextBox
    Friend WithEvents lblAbonos As System.Windows.Forms.Label
    Friend WithEvents cboDH As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents btnPagar As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents chek As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents id_ret As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ruc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_comprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents glosa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents moneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents retenido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fec_reg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
