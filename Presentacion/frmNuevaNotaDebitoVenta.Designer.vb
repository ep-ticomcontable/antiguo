<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevaNotaDebitoVenta
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_asiento_venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNumeroN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSerieN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGlosa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnRuc = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRazon = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Comentarios = New System.Windows.Forms.Label()
        Me.txtComentarios = New System.Windows.Forms.TextBox()
        Me.cboMotivo = New System.Windows.Forms.ComboBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtIgv = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscarComprobante = New System.Windows.Forms.Button()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtDiferenciaS = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTHaberS = New System.Windows.Forms.TextBox()
        Me.txtTDebeS = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(600, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 35)
        Me.Button1.TabIndex = 119
        Me.Button1.Text = "AGREGAR CUENTA"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.id_asiento_venta, Me.num_cuenta, Me.desc_cuenta, Me.debe, Me.haber})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvLista.Location = New System.Drawing.Point(12, 295)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.Size = New System.Drawing.Size(761, 181)
        Me.dgvLista.TabIndex = 118
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'id_asiento_venta
        '
        Me.id_asiento_venta.DataPropertyName = "id_asiento_venta"
        Me.id_asiento_venta.HeaderText = "id_asiento_venta"
        Me.id_asiento_venta.Name = "id_asiento_venta"
        Me.id_asiento_venta.ReadOnly = True
        Me.id_asiento_venta.Visible = False
        '
        'num_cuenta
        '
        Me.num_cuenta.DataPropertyName = "num_cuenta"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.num_cuenta.DefaultCellStyle = DataGridViewCellStyle2
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
        Me.desc_cuenta.Width = 460
        '
        'debe
        '
        Me.debe.DataPropertyName = "debe"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.debe.DefaultCellStyle = DataGridViewCellStyle3
        Me.debe.HeaderText = "Debe"
        Me.debe.Name = "debe"
        Me.debe.ReadOnly = True
        Me.debe.Width = 80
        '
        'haber
        '
        Me.haber.DataPropertyName = "haber"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.haber.DefaultCellStyle = DataGridViewCellStyle4
        Me.haber.HeaderText = "Haber"
        Me.haber.Name = "haber"
        Me.haber.ReadOnly = True
        Me.haber.Width = 80
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnConsultar.ForeColor = System.Drawing.Color.White
        Me.btnConsultar.Location = New System.Drawing.Point(668, 484)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(105, 35)
        Me.btnConsultar.TabIndex = 117
        Me.btnConsultar.Text = "PROCESAR"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtFechaEmision)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtNumeroN)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtSerieN)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtGlosa)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnRuc)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtRazon)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtRuc)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(290, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(482, 116)
        Me.GroupBox2.TabIndex = 114
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nota de Débito"
        '
        'dtFechaEmision
        '
        Me.dtFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaEmision.Location = New System.Drawing.Point(361, 32)
        Me.dtFechaEmision.Name = "dtFechaEmision"
        Me.dtFechaEmision.Size = New System.Drawing.Size(115, 21)
        Me.dtFechaEmision.TabIndex = 110
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(310, 34)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 16)
        Me.Label15.TabIndex = 109
        Me.Label15.Text = "Fecha:"
        '
        'txtNumeroN
        '
        Me.txtNumeroN.Location = New System.Drawing.Point(151, 33)
        Me.txtNumeroN.Name = "txtNumeroN"
        Me.txtNumeroN.Size = New System.Drawing.Size(99, 21)
        Me.txtNumeroN.TabIndex = 35
        Me.txtNumeroN.Text = "0001"
        Me.txtNumeroN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(120, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 17)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "N°:"
        '
        'txtSerieN
        '
        Me.txtSerieN.Location = New System.Drawing.Point(54, 33)
        Me.txtSerieN.Name = "txtSerieN"
        Me.txtSerieN.Size = New System.Drawing.Size(60, 21)
        Me.txtSerieN.TabIndex = 37
        Me.txtSerieN.Text = "0001"
        Me.txtSerieN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 17)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Serie:"
        '
        'txtGlosa
        '
        Me.txtGlosa.Location = New System.Drawing.Point(54, 89)
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(422, 21)
        Me.txtGlosa.TabIndex = 32
        Me.txtGlosa.Text = "NOTA DE DEBITO PRE-GENERADA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(173, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Razón:"
        '
        'btnRuc
        '
        Me.btnRuc.Location = New System.Drawing.Point(54, 60)
        Me.btnRuc.Name = "btnRuc"
        Me.btnRuc.Size = New System.Drawing.Size(30, 23)
        Me.btnRuc.TabIndex = 33
        Me.btnRuc.Text = "..."
        Me.btnRuc.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Glosa:"
        '
        'txtRazon
        '
        Me.txtRazon.Location = New System.Drawing.Point(224, 60)
        Me.txtRazon.Name = "txtRazon"
        Me.txtRazon.Size = New System.Drawing.Size(252, 21)
        Me.txtRazon.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "RUC:"
        '
        'txtRuc
        '
        Me.txtRuc.Location = New System.Drawing.Point(90, 61)
        Me.txtRuc.MaxLength = 11
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(77, 21)
        Me.txtRuc.TabIndex = 28
        Me.txtRuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(111, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 17)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "N°"
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(53, 62)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(52, 21)
        Me.txtSerie.TabIndex = 34
        Me.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Serie:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 17)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Documento:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(217, 37)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(109, 16)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "Motivo de Emisión:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Comentarios)
        Me.GroupBox3.Controls.Add(Me.txtComentarios)
        Me.GroupBox3.Controls.Add(Me.cboMotivo)
        Me.GroupBox3.Controls.Add(Me.txtTotal)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.txtIgv)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txtMonto)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 184)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(760, 105)
        Me.GroupBox3.TabIndex = 116
        Me.GroupBox3.TabStop = False
        '
        'Comentarios
        '
        Me.Comentarios.AutoSize = True
        Me.Comentarios.Location = New System.Drawing.Point(247, 74)
        Me.Comentarios.Name = "Comentarios"
        Me.Comentarios.Size = New System.Drawing.Size(79, 16)
        Me.Comentarios.TabIndex = 110
        Me.Comentarios.Text = "Comentarios:"
        '
        'txtComentarios
        '
        Me.txtComentarios.Location = New System.Drawing.Point(332, 63)
        Me.txtComentarios.Multiline = True
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.Size = New System.Drawing.Size(247, 36)
        Me.txtComentarios.TabIndex = 109
        '
        'cboMotivo
        '
        Me.cboMotivo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMotivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboMotivo.FormattingEnabled = True
        Me.cboMotivo.Location = New System.Drawing.Point(332, 32)
        Me.cboMotivo.Name = "cboMotivo"
        Me.cboMotivo.Size = New System.Drawing.Size(164, 23)
        Me.cboMotivo.TabIndex = 108
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(15, 78)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(186, 21)
        Me.txtTotal.TabIndex = 40
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 16)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "TOTAL"
        '
        'txtIgv
        '
        Me.txtIgv.Location = New System.Drawing.Point(111, 34)
        Me.txtIgv.Name = "txtIgv"
        Me.txtIgv.Size = New System.Drawing.Size(90, 21)
        Me.txtIgv.TabIndex = 38
        Me.txtIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(108, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 16)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "IGV"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(15, 34)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(90, 21)
        Me.txtMonto.TabIndex = 35
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 16)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "MONTO"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(139, 61)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(65, 21)
        Me.txtNumero.TabIndex = 34
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscarComprobante)
        Me.GroupBox1.Controls.Add(Me.dtFecha)
        Me.GroupBox1.Controls.Add(Me.cboTipoDocumento)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtSerie)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 116)
        Me.GroupBox1.TabIndex = 115
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Referencia del Documento de Venta"
        '
        'btnBuscarComprobante
        '
        Me.btnBuscarComprobante.Location = New System.Drawing.Point(209, 60)
        Me.btnBuscarComprobante.Name = "btnBuscarComprobante"
        Me.btnBuscarComprobante.Size = New System.Drawing.Size(57, 23)
        Me.btnBuscarComprobante.TabIndex = 111
        Me.btnBuscarComprobante.Text = "Buscar"
        Me.btnBuscarComprobante.UseVisualStyleBackColor = True
        '
        'dtFecha
        '
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(53, 89)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(107, 21)
        Me.dtFecha.TabIndex = 108
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocumento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboTipoDocumento.FormattingEnabled = True
        Me.cboTipoDocumento.Items.AddRange(New Object() {"soles", "dolares"})
        Me.cboTipoDocumento.Location = New System.Drawing.Point(94, 32)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(172, 23)
        Me.cboTipoDocumento.TabIndex = 107
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(263, 479)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(79, 16)
        Me.Label22.TabIndex = 162
        Me.Label22.Text = "Diferencia S/."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(136, 479)
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
        Me.txtDiferenciaS.Location = New System.Drawing.Point(266, 498)
        Me.txtDiferenciaS.Name = "txtDiferenciaS"
        Me.txtDiferenciaS.Size = New System.Drawing.Size(121, 21)
        Me.txtDiferenciaS.TabIndex = 159
        Me.txtDiferenciaS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 479)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 16)
        Me.Label9.TabIndex = 160
        Me.Label9.Text = "Total Debe S/. "
        '
        'txtTHaberS
        '
        Me.txtTHaberS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTHaberS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTHaberS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTHaberS.Location = New System.Drawing.Point(139, 498)
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
        Me.txtTDebeS.Location = New System.Drawing.Point(12, 498)
        Me.txtTDebeS.Name = "txtTDebeS"
        Me.txtTDebeS.Size = New System.Drawing.Size(121, 21)
        Me.txtTDebeS.TabIndex = 157
        Me.txtTDebeS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 25.0!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(5, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(414, 40)
        Me.lblTitulo.TabIndex = 226
        Me.lblTitulo.Text = "NOTA DE DÉBITO - VENTA"
        '
        'frmNuevaNotaDebitoVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(785, 531)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtDiferenciaS)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTHaberS)
        Me.Controls.Add(Me.txtTDebeS)
        Me.Controls.Add(Me.dgvLista)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmNuevaNotaDebitoVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Nota de Débito Venta"
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtFechaEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroN As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSerieN As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGlosa As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnRuc As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRazon As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Comentarios As System.Windows.Forms.Label
    Friend WithEvents txtComentarios As System.Windows.Forms.TextBox
    Friend WithEvents cboMotivo As System.Windows.Forms.ComboBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtIgv As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_asiento_venta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents num_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtDiferenciaS As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTHaberS As System.Windows.Forms.TextBox
    Friend WithEvents txtTDebeS As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarComprobante As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
End Class
