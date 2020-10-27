<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaCajaChica
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_caja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_comprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.anio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_operacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.glosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.Label()
        Me.cboCaja = New System.Windows.Forms.ComboBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSaldo2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSaldo1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblDiferencia = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblEgresos = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblIngresos = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNumRegistros = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.grupoBusqueda = New System.Windows.Forms.GroupBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboAnio = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grupoBusqueda.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToOrderColumns = True
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.id_caja, Me.tipo, Me.comprobante, Me.serie, Me.numero, Me.id_comprobante, Me.anio, Me.mes, Me.fecha_operacion, Me.glosa, Me.cuenta, Me.debe, Me.haber, Me.saldo})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvLista.Location = New System.Drawing.Point(6, 20)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.Size = New System.Drawing.Size(948, 392)
        Me.dgvLista.TabIndex = 0
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.id.DefaultCellStyle = DataGridViewCellStyle1
        Me.id.HeaderText = "N°"
        Me.id.Name = "id"
        Me.id.Visible = False
        Me.id.Width = 50
        '
        'id_caja
        '
        Me.id_caja.DataPropertyName = "id_caja"
        Me.id_caja.HeaderText = "id_caja"
        Me.id_caja.Name = "id_caja"
        Me.id_caja.Visible = False
        '
        'tipo
        '
        Me.tipo.DataPropertyName = "tipo"
        Me.tipo.HeaderText = "TIPO"
        Me.tipo.Name = "tipo"
        Me.tipo.Visible = False
        Me.tipo.Width = 80
        '
        'comprobante
        '
        Me.comprobante.DataPropertyName = "comprobante"
        Me.comprobante.HeaderText = "DOC."
        Me.comprobante.Name = "comprobante"
        Me.comprobante.Width = 120
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
        'id_comprobante
        '
        Me.id_comprobante.DataPropertyName = "id_comprobante"
        Me.id_comprobante.HeaderText = "id_comprobante"
        Me.id_comprobante.Name = "id_comprobante"
        Me.id_comprobante.Visible = False
        '
        'anio
        '
        Me.anio.DataPropertyName = "anio"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.anio.DefaultCellStyle = DataGridViewCellStyle2
        Me.anio.HeaderText = "AÑO"
        Me.anio.Name = "anio"
        Me.anio.Width = 50
        '
        'mes
        '
        Me.mes.DataPropertyName = "mes"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.mes.DefaultCellStyle = DataGridViewCellStyle3
        Me.mes.HeaderText = "MES"
        Me.mes.Name = "mes"
        Me.mes.Width = 75
        '
        'fecha_operacion
        '
        Me.fecha_operacion.DataPropertyName = "fecha_operacion"
        Me.fecha_operacion.HeaderText = "FECHA"
        Me.fecha_operacion.Name = "fecha_operacion"
        Me.fecha_operacion.Width = 80
        '
        'glosa
        '
        Me.glosa.DataPropertyName = "glosa"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.glosa.DefaultCellStyle = DataGridViewCellStyle4
        Me.glosa.HeaderText = "GLOSA"
        Me.glosa.Name = "glosa"
        Me.glosa.Width = 235
        '
        'cuenta
        '
        Me.cuenta.DataPropertyName = "cuenta"
        Me.cuenta.HeaderText = "CUENTA"
        Me.cuenta.Name = "cuenta"
        Me.cuenta.Width = 70
        '
        'debe
        '
        Me.debe.DataPropertyName = "debe"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.debe.DefaultCellStyle = DataGridViewCellStyle5
        Me.debe.HeaderText = "INGRESO"
        Me.debe.Name = "debe"
        Me.debe.Width = 75
        '
        'haber
        '
        Me.haber.DataPropertyName = "haber"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.haber.DefaultCellStyle = DataGridViewCellStyle6
        Me.haber.HeaderText = "SALIDA"
        Me.haber.Name = "haber"
        Me.haber.Width = 75
        '
        'saldo
        '
        Me.saldo.DataPropertyName = "saldo"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Green
        Me.saldo.DefaultCellStyle = DataGridViewCellStyle7
        Me.saldo.HeaderText = "SALDO"
        Me.saldo.Name = "saldo"
        Me.saldo.Width = 75
        '
        'Cliente
        '
        Me.Cliente.AutoSize = True
        Me.Cliente.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Cliente.Location = New System.Drawing.Point(14, 14)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(67, 16)
        Me.Cliente.TabIndex = 102
        Me.Cliente.Text = "Buscar por:"
        '
        'cboCaja
        '
        Me.cboCaja.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCaja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboCaja.FormattingEnabled = True
        Me.cboCaja.Location = New System.Drawing.Point(17, 33)
        Me.cboCaja.Name = "cboCaja"
        Me.cboCaja.Size = New System.Drawing.Size(165, 23)
        Me.cboCaja.TabIndex = 106
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultar.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnConsultar.ForeColor = System.Drawing.Color.White
        Me.btnConsultar.Location = New System.Drawing.Point(359, 29)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(95, 27)
        Me.btnConsultar.TabIndex = 109
        Me.btnConsultar.Text = "CONSULTAR"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(6, 488)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 27)
        Me.Button2.TabIndex = 116
        Me.Button2.Text = "REGISTRO CAJA"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 25.0!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(5, 12)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(398, 40)
        Me.lblTitulo.TabIndex = 211
        Me.lblTitulo.Text = "LISTA DE CAJAS CHICAS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSaldo2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblSaldo1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblDiferencia)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblEgresos)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblIngresos)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblNumRegistros)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.dgvLista)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(960, 521)
        Me.GroupBox1.TabIndex = 212
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REGISTROS"
        '
        'lblSaldo2
        '
        Me.lblSaldo2.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSaldo2.ForeColor = System.Drawing.Color.Green
        Me.lblSaldo2.Location = New System.Drawing.Point(869, 498)
        Me.lblSaldo2.Name = "lblSaldo2"
        Me.lblSaldo2.Size = New System.Drawing.Size(85, 17)
        Me.lblSaldo2.TabIndex = 131
        Me.lblSaldo2.Text = "0.00"
        Me.lblSaldo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 7.5!)
        Me.Label2.Location = New System.Drawing.Point(866, 485)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "SALDO 2:"
        '
        'lblSaldo1
        '
        Me.lblSaldo1.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSaldo1.ForeColor = System.Drawing.Color.Green
        Me.lblSaldo1.Location = New System.Drawing.Point(748, 498)
        Me.lblSaldo1.Name = "lblSaldo1"
        Me.lblSaldo1.Size = New System.Drawing.Size(93, 17)
        Me.lblSaldo1.TabIndex = 129
        Me.lblSaldo1.Text = "0.00"
        Me.lblSaldo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 7.5!)
        Me.Label7.Location = New System.Drawing.Point(748, 484)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 15)
        Me.Label7.TabIndex = 128
        Me.Label7.Text = "SALDO 1:"
        '
        'lblDiferencia
        '
        Me.lblDiferencia.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblDiferencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDiferencia.Location = New System.Drawing.Point(869, 463)
        Me.lblDiferencia.Name = "lblDiferencia"
        Me.lblDiferencia.Size = New System.Drawing.Size(82, 17)
        Me.lblDiferencia.TabIndex = 127
        Me.lblDiferencia.Text = "0.00"
        Me.lblDiferencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 7.5!)
        Me.Label10.Location = New System.Drawing.Point(866, 448)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 15)
        Me.Label10.TabIndex = 126
        Me.Label10.Text = "DIFERENCIA:"
        '
        'lblEgresos
        '
        Me.lblEgresos.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblEgresos.Location = New System.Drawing.Point(869, 431)
        Me.lblEgresos.Name = "lblEgresos"
        Me.lblEgresos.Size = New System.Drawing.Size(85, 17)
        Me.lblEgresos.TabIndex = 125
        Me.lblEgresos.Text = "0.00"
        Me.lblEgresos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 7.5!)
        Me.Label8.Location = New System.Drawing.Point(866, 418)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 15)
        Me.Label8.TabIndex = 124
        Me.Label8.Text = "TOTAL EGRESOS:"
        '
        'lblIngresos
        '
        Me.lblIngresos.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblIngresos.Location = New System.Drawing.Point(748, 431)
        Me.lblIngresos.Name = "lblIngresos"
        Me.lblIngresos.Size = New System.Drawing.Size(93, 17)
        Me.lblIngresos.TabIndex = 123
        Me.lblIngresos.Text = "0.00"
        Me.lblIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 7.5!)
        Me.Label4.Location = New System.Drawing.Point(748, 417)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 15)
        Me.Label4.TabIndex = 122
        Me.Label4.Text = "TOTAL INGRESOS:"
        '
        'lblNumRegistros
        '
        Me.lblNumRegistros.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblNumRegistros.Location = New System.Drawing.Point(6, 433)
        Me.lblNumRegistros.Name = "lblNumRegistros"
        Me.lblNumRegistros.Size = New System.Drawing.Size(87, 17)
        Me.lblNumRegistros.TabIndex = 117
        Me.lblNumRegistros.Text = "0"
        Me.lblNumRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label13.Location = New System.Drawing.Point(6, 415)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 17)
        Me.Label13.TabIndex = 116
        Me.Label13.Text = "N° REGISTROS:"
        '
        'grupoBusqueda
        '
        Me.grupoBusqueda.Controls.Add(Me.cboMes)
        Me.grupoBusqueda.Controls.Add(Me.Label11)
        Me.grupoBusqueda.Controls.Add(Me.cboAnio)
        Me.grupoBusqueda.Controls.Add(Me.Label5)
        Me.grupoBusqueda.Controls.Add(Me.cboCaja)
        Me.grupoBusqueda.Controls.Add(Me.Cliente)
        Me.grupoBusqueda.Controls.Add(Me.btnConsultar)
        Me.grupoBusqueda.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoBusqueda.Location = New System.Drawing.Point(503, 12)
        Me.grupoBusqueda.Name = "grupoBusqueda"
        Me.grupoBusqueda.Size = New System.Drawing.Size(469, 70)
        Me.grupoBusqueda.TabIndex = 220
        Me.grupoBusqueda.TabStop = False
        Me.grupoBusqueda.Text = "PARAMETROS DE BUSQUEDA"
        '
        'cboMes
        '
        Me.cboMes.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.Location = New System.Drawing.Point(258, 33)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(95, 23)
        Me.cboMes.TabIndex = 127
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label11.Location = New System.Drawing.Point(255, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 16)
        Me.Label11.TabIndex = 126
        Me.Label11.Text = "Mes:"
        '
        'cboAnio
        '
        Me.cboAnio.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboAnio.FormattingEnabled = True
        Me.cboAnio.Location = New System.Drawing.Point(188, 33)
        Me.cboAnio.Name = "cboAnio"
        Me.cboAnio.Size = New System.Drawing.Size(64, 23)
        Me.cboAnio.TabIndex = 125
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label5.Location = New System.Drawing.Point(185, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 16)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "Año:"
        '
        'frmListaCajaChica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 611)
        Me.Controls.Add(Me.grupoBusqueda)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmListaCajaChica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CAJA"
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grupoBusqueda.ResumeLayout(False)
        Me.grupoBusqueda.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents Cliente As System.Windows.Forms.Label
    Friend WithEvents cboCaja As System.Windows.Forms.ComboBox
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grupoBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboAnio As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents lblNumRegistros As System.Windows.Forms.Label
    Private WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents lblSaldo2 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents lblSaldo1 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents lblDiferencia As System.Windows.Forms.Label
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents lblEgresos As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents lblIngresos As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_caja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_comprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents anio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_operacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents glosa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents saldo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
