<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagos
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.lblDatoProveedor = New System.Windows.Forms.Label()
        Me.txtDatoProveedor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_cambio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detraccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fec_emision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fec_pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnHistorialPagos = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnActualizar)
        Me.GroupBox2.Controls.Add(Me.lblDatoProveedor)
        Me.GroupBox2.Controls.Add(Me.txtDatoProveedor)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(810, 75)
        Me.GroupBox2.TabIndex = 180
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cabecera del Comprobante de venta"
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Location = New System.Drawing.Point(707, 37)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(97, 32)
        Me.btnActualizar.TabIndex = 183
        Me.btnActualizar.Text = "ACTUALIZAR"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'lblDatoProveedor
        '
        Me.lblDatoProveedor.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatoProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblDatoProveedor.Location = New System.Drawing.Point(142, 51)
        Me.lblDatoProveedor.Name = "lblDatoProveedor"
        Me.lblDatoProveedor.Size = New System.Drawing.Size(548, 13)
        Me.lblDatoProveedor.TabIndex = 99
        Me.lblDatoProveedor.Text = "[Nombre Proveedor]"
        '
        'txtDatoProveedor
        '
        Me.txtDatoProveedor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatoProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDatoProveedor.Location = New System.Drawing.Point(9, 46)
        Me.txtDatoProveedor.Name = "txtDatoProveedor"
        Me.txtDatoProveedor.Size = New System.Drawing.Size(127, 23)
        Me.txtDatoProveedor.TabIndex = 97
        Me.txtDatoProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 16)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "Cliente/Proveedor:"
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.dgvLista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.serie, Me.numero, Me.documento, Me.descripcion, Me.moneda, Me.tipo_cambio, Me.detraccion, Me.total, Me.debe, Me.fec_emision, Me.fec_pago})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvLista.Location = New System.Drawing.Point(12, 93)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.RowTemplate.Height = 30
        Me.dgvLista.Size = New System.Drawing.Size(810, 236)
        Me.dgvLista.TabIndex = 181
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'serie
        '
        Me.serie.DataPropertyName = "serie"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.serie.DefaultCellStyle = DataGridViewCellStyle3
        Me.serie.HeaderText = "Serie"
        Me.serie.Name = "serie"
        Me.serie.ReadOnly = True
        Me.serie.Width = 50
        '
        'numero
        '
        Me.numero.DataPropertyName = "numero"
        Me.numero.HeaderText = "Número"
        Me.numero.Name = "numero"
        Me.numero.ReadOnly = True
        Me.numero.Width = 60
        '
        'documento
        '
        Me.documento.DataPropertyName = "documento"
        Me.documento.HeaderText = "Documento"
        Me.documento.Name = "documento"
        Me.documento.ReadOnly = True
        Me.documento.Width = 80
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "glosa"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.descripcion.DefaultCellStyle = DataGridViewCellStyle4
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 150
        '
        'moneda
        '
        Me.moneda.DataPropertyName = "moneda"
        Me.moneda.HeaderText = "Mon."
        Me.moneda.Name = "moneda"
        Me.moneda.ReadOnly = True
        Me.moneda.Width = 50
        '
        'tipo_cambio
        '
        Me.tipo_cambio.DataPropertyName = "tipo_cambio"
        Me.tipo_cambio.HeaderText = "T. C."
        Me.tipo_cambio.Name = "tipo_cambio"
        Me.tipo_cambio.ReadOnly = True
        Me.tipo_cambio.Width = 70
        '
        'detraccion
        '
        Me.detraccion.DataPropertyName = "detraccion"
        Me.detraccion.HeaderText = "detraccion"
        Me.detraccion.Name = "detraccion"
        Me.detraccion.ReadOnly = True
        Me.detraccion.Visible = False
        '
        'total
        '
        Me.total.DataPropertyName = "total"
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'debe
        '
        Me.debe.DataPropertyName = "debe"
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red
        Me.debe.DefaultCellStyle = DataGridViewCellStyle5
        Me.debe.HeaderText = "Debe"
        Me.debe.Name = "debe"
        Me.debe.ReadOnly = True
        '
        'fec_emision
        '
        Me.fec_emision.DataPropertyName = "fec_emision"
        Me.fec_emision.HeaderText = "F. Emi."
        Me.fec_emision.Name = "fec_emision"
        Me.fec_emision.ReadOnly = True
        Me.fec_emision.Width = 85
        '
        'fec_pago
        '
        Me.fec_pago.DataPropertyName = "fec_pago"
        Me.fec_pago.HeaderText = "F. Venc."
        Me.fec_pago.Name = "fec_pago"
        Me.fec_pago.ReadOnly = True
        Me.fec_pago.Width = 85
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(707, 335)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(115, 32)
        Me.btnAceptar.TabIndex = 182
        Me.btnAceptar.Text = "CONSULTAR"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnHistorialPagos
        '
        Me.btnHistorialPagos.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnHistorialPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistorialPagos.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnHistorialPagos.ForeColor = System.Drawing.Color.White
        Me.btnHistorialPagos.Location = New System.Drawing.Point(12, 335)
        Me.btnHistorialPagos.Name = "btnHistorialPagos"
        Me.btnHistorialPagos.Size = New System.Drawing.Size(196, 32)
        Me.btnHistorialPagos.TabIndex = 184
        Me.btnHistorialPagos.Text = "VER HISTORIAL DE PAGOS"
        Me.btnHistorialPagos.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(321, 335)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(192, 32)
        Me.Button1.TabIndex = 185
        Me.Button1.Text = "GENERAR EXCEL LIBRO DIARIO"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(834, 379)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnHistorialPagos)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dgvLista)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmPagos"
        Me.Text = "Pago de comprobantes"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDatoProveedor As System.Windows.Forms.Label
    Friend WithEvents txtDatoProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnHistorialPagos As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents moneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_cambio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents detraccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fec_emision As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fec_pago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
