<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaDetracciones
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
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTituloForm = New System.Windows.Forms.Label()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.chek = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.id_det = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.resta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fec_reg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPagarDetraccion = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.lblTituloForm.Size = New System.Drawing.Size(474, 59)
        Me.lblTituloForm.TabIndex = 5
        Me.lblTituloForm.Text = "DETRACCIONES POR PAGAR"
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToOrderColumns = True
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chek, Me.id_det, Me.serie, Me.numero, Me.proveedor, Me.ruc, Me.id_comprobante, Me.factura, Me.glosa, Me.moneda, Me.total, Me.retenido, Me.resta, Me.fec_reg, Me.estado})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvLista.Location = New System.Drawing.Point(12, 63)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.Size = New System.Drawing.Size(760, 286)
        Me.dgvLista.TabIndex = 334
        '
        'chek
        '
        Me.chek.HeaderText = "[X]"
        Me.chek.Name = "chek"
        Me.chek.Visible = False
        Me.chek.Width = 30
        '
        'id_det
        '
        Me.id_det.DataPropertyName = "id_det"
        Me.id_det.HeaderText = "id_det"
        Me.id_det.Name = "id_det"
        Me.id_det.Visible = False
        '
        'serie
        '
        Me.serie.DataPropertyName = "serie"
        Me.serie.HeaderText = "SERIE"
        Me.serie.Name = "serie"
        Me.serie.Visible = False
        Me.serie.Width = 50
        '
        'numero
        '
        Me.numero.DataPropertyName = "numero"
        Me.numero.HeaderText = "NUM"
        Me.numero.Name = "numero"
        Me.numero.Width = 80
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
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.total.DefaultCellStyle = DataGridViewCellStyle9
        Me.total.HeaderText = "TOTAL"
        Me.total.Name = "total"
        Me.total.Visible = False
        Me.total.Width = 80
        '
        'retenido
        '
        Me.retenido.DataPropertyName = "retenido"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.retenido.DefaultCellStyle = DataGridViewCellStyle10
        Me.retenido.HeaderText = "MONTO"
        Me.retenido.Name = "retenido"
        Me.retenido.Width = 80
        '
        'resta
        '
        Me.resta.DataPropertyName = "resta"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.resta.DefaultCellStyle = DataGridViewCellStyle11
        Me.resta.HeaderText = "PENDIENTE"
        Me.resta.Name = "resta"
        Me.resta.Width = 80
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
        'btnPagarDetraccion
        '
        Me.btnPagarDetraccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnPagarDetraccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPagarDetraccion.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnPagarDetraccion.ForeColor = System.Drawing.Color.White
        Me.btnPagarDetraccion.Location = New System.Drawing.Point(12, 354)
        Me.btnPagarDetraccion.Name = "btnPagarDetraccion"
        Me.btnPagarDetraccion.Size = New System.Drawing.Size(159, 35)
        Me.btnPagarDetraccion.TabIndex = 336
        Me.btnPagarDetraccion.Text = "PAGAR DETRACCIÓN"
        Me.btnPagarDetraccion.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel5.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Panel5.Location = New System.Drawing.Point(677, 43)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(22, 17)
        Me.Panel5.TabIndex = 390
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label52.Location = New System.Drawing.Point(698, 44)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(74, 16)
        Me.Label52.TabIndex = 391
        Me.Label52.Text = "CANCELADA"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(575, 354)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(197, 35)
        Me.Button1.TabIndex = 392
        Me.Button1.Text = "DEPÓSITO DE DETRACCIONES"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.Green
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Location = New System.Drawing.Point(564, 33)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(107, 27)
        Me.btnActualizar.TabIndex = 393
        Me.btnActualizar.Text = "ACTUALIZAR"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'frmListaDetracciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 401)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.btnPagarDetraccion)
        Me.Controls.Add(Me.lblTituloForm)
        Me.Controls.Add(Me.dgvLista)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmListaDetracciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DETRACCIONES"
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTituloForm As System.Windows.Forms.Label
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents btnPagarDetraccion As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents chek As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents id_det As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents resta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fec_reg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
End Class
