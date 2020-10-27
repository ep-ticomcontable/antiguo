<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaLetrasPorCobrar
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_comprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_comprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fec_emision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fec_vencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado_deuda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.librado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.aval = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lugar_giro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.Cliente = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.dtHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.dtDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPagarLetra = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToOrderColumns = True
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.tipo_comprobante, Me.id_comprobante, Me.serie, Me.numero, Me.total, Me.fec_emision, Me.fec_vencimiento, Me.estado_deuda, Me.librado, Me.aval, Me.direccion, Me.lugar_giro})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvLista.Location = New System.Drawing.Point(12, 100)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.Size = New System.Drawing.Size(860, 308)
        Me.dgvLista.TabIndex = 0
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.Width = 40
        '
        'tipo_comprobante
        '
        Me.tipo_comprobante.DataPropertyName = "tipo_comprobante"
        Me.tipo_comprobante.HeaderText = "tipo_comprobante"
        Me.tipo_comprobante.Name = "tipo_comprobante"
        Me.tipo_comprobante.Visible = False
        '
        'id_comprobante
        '
        Me.id_comprobante.DataPropertyName = "id_comprobante"
        Me.id_comprobante.HeaderText = "id_comprobante"
        Me.id_comprobante.Name = "id_comprobante"
        Me.id_comprobante.Visible = False
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
        Me.numero.HeaderText = "N°"
        Me.numero.Name = "numero"
        Me.numero.Width = 50
        '
        'total
        '
        Me.total.DataPropertyName = "total"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.total.DefaultCellStyle = DataGridViewCellStyle5
        Me.total.HeaderText = "TOTAL"
        Me.total.Name = "total"
        Me.total.Width = 80
        '
        'fec_emision
        '
        Me.fec_emision.DataPropertyName = "fec_emision"
        Me.fec_emision.HeaderText = "EMISION"
        Me.fec_emision.Name = "fec_emision"
        Me.fec_emision.Width = 80
        '
        'fec_vencimiento
        '
        Me.fec_vencimiento.DataPropertyName = "fec_vencimiento"
        Me.fec_vencimiento.HeaderText = "VENC."
        Me.fec_vencimiento.Name = "fec_vencimiento"
        Me.fec_vencimiento.Width = 70
        '
        'estado_deuda
        '
        Me.estado_deuda.DataPropertyName = "estado_deuda"
        Me.estado_deuda.HeaderText = "ESTADO"
        Me.estado_deuda.Name = "estado_deuda"
        Me.estado_deuda.Width = 70
        '
        'librado
        '
        Me.librado.DataPropertyName = "librado"
        Me.librado.HeaderText = "LIBRADOR"
        Me.librado.Name = "librado"
        Me.librado.Width = 90
        '
        'aval
        '
        Me.aval.DataPropertyName = "aval"
        Me.aval.HeaderText = "AVAL"
        Me.aval.Name = "aval"
        Me.aval.Width = 90
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.HeaderText = "DIRECCION"
        Me.direccion.Name = "direccion"
        Me.direccion.Width = 90
        '
        'lugar_giro
        '
        Me.lugar_giro.DataPropertyName = "lugar_giro"
        Me.lugar_giro.HeaderText = "LUGAR"
        Me.lugar_giro.Name = "lugar_giro"
        Me.lugar_giro.Width = 90
        '
        'txtDato
        '
        Me.txtDato.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtDato.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDato.Location = New System.Drawing.Point(272, 65)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(158, 22)
        Me.txtDato.TabIndex = 103
        '
        'Cliente
        '
        Me.Cliente.AutoSize = True
        Me.Cliente.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Cliente.Location = New System.Drawing.Point(12, 68)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(67, 16)
        Me.Cliente.TabIndex = 102
        Me.Cliente.Text = "Buscar por:"
        '
        'cboTipo
        '
        Me.cboTipo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"soles", "dolares"})
        Me.cboTipo.Location = New System.Drawing.Point(85, 65)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(137, 23)
        Me.cboTipo.TabIndex = 106
        '
        'dtHasta
        '
        Me.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtHasta.Location = New System.Drawing.Point(634, 66)
        Me.dtHasta.Name = "dtHasta"
        Me.dtHasta.Size = New System.Drawing.Size(96, 20)
        Me.dtHasta.TabIndex = 110
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label1.Location = New System.Drawing.Point(583, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Hasta:"
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnConsultar.ForeColor = System.Drawing.Color.White
        Me.btnConsultar.Location = New System.Drawing.Point(773, 59)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(99, 35)
        Me.btnConsultar.TabIndex = 109
        Me.btnConsultar.Text = "CONSULTAR"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'dtDesde
        '
        Me.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDesde.Location = New System.Drawing.Point(484, 66)
        Me.dtDesde.Name = "dtDesde"
        Me.dtDesde.Size = New System.Drawing.Size(96, 20)
        Me.dtDesde.TabIndex = 107
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label2.Location = New System.Drawing.Point(430, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Desde:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label3.Location = New System.Drawing.Point(228, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 16)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Dato:"
        '
        'btnPagarLetra
        '
        Me.btnPagarLetra.BackColor = System.Drawing.Color.Green
        Me.btnPagarLetra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPagarLetra.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnPagarLetra.ForeColor = System.Drawing.Color.White
        Me.btnPagarLetra.Location = New System.Drawing.Point(739, 414)
        Me.btnPagarLetra.Name = "btnPagarLetra"
        Me.btnPagarLetra.Size = New System.Drawing.Size(133, 35)
        Me.btnPagarLetra.TabIndex = 113
        Me.btnPagarLetra.Text = "PAGAR LETRA"
        Me.btnPagarLetra.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Red
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(12, 414)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(116, 35)
        Me.btnEliminar.TabIndex = 116
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = False
        Me.btnEliminar.Visible = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(272, 414)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(97, 35)
        Me.btnModificar.TabIndex = 117
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.UseVisualStyleBackColor = False
        Me.btnModificar.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 25.0!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(5, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(357, 40)
        Me.lblTitulo.TabIndex = 118
        Me.lblTitulo.Text = "LETRAS POR COBRAR"
        '
        'frmListaLetrasPorCobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(884, 461)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnPagarLetra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtHasta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.dtDesde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.txtDato)
        Me.Controls.Add(Me.Cliente)
        Me.Controls.Add(Me.dgvLista)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmListaLetrasPorCobrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LISTA DE LETRAS - VENTAS"
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents txtDato As System.Windows.Forms.TextBox
    Friend WithEvents Cliente As System.Windows.Forms.Label
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents dtHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents dtDesde As System.Windows.Forms.DateTimePicker
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnPagarLetra As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_comprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_comprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fec_emision As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fec_vencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado_deuda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents librado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents aval As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lugar_giro As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
