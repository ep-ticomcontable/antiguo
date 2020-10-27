<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaNotasCreditoCompra
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTituloForm = New System.Windows.Forms.Label()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.chek = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.motivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_comp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.glosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fec_reg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label52 = New System.Windows.Forms.Label()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTituloForm
        '
        Me.lblTituloForm.AutoSize = True
        Me.lblTituloForm.BackColor = System.Drawing.Color.Transparent
        Me.lblTituloForm.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblTituloForm.Location = New System.Drawing.Point(5, 9)
        Me.lblTituloForm.Name = "lblTituloForm"
        Me.lblTituloForm.Padding = New System.Windows.Forms.Padding(10)
        Me.lblTituloForm.Size = New System.Drawing.Size(524, 59)
        Me.lblTituloForm.TabIndex = 5
        Me.lblTituloForm.Text = "COMPRAS - NOTAS DE CRÉDITO"
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToOrderColumns = True
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        Me.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvLista.ColumnHeadersHeight = 25
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chek, Me.id, Me.serie, Me.numero, Me.motivo, Me.comprobante, Me.total_comp, Me.glosa, Me.cliente, Me.moneda, Me.total, Me.fec_reg, Me.estado})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvLista.EnableHeadersVisualStyles = False
        Me.dgvLista.Location = New System.Drawing.Point(12, 71)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.Size = New System.Drawing.Size(760, 295)
        Me.dgvLista.TabIndex = 334
        '
        'chek
        '
        Me.chek.HeaderText = "[X]"
        Me.chek.Name = "chek"
        Me.chek.Visible = False
        Me.chek.Width = 30
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
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
        'motivo
        '
        Me.motivo.DataPropertyName = "motivo"
        Me.motivo.HeaderText = "MOTIVO"
        Me.motivo.Name = "motivo"
        Me.motivo.Width = 80
        '
        'comprobante
        '
        Me.comprobante.DataPropertyName = "comprobante"
        Me.comprobante.HeaderText = "COMP."
        Me.comprobante.Name = "comprobante"
        Me.comprobante.Width = 80
        '
        'total_comp
        '
        Me.total_comp.DataPropertyName = "total_comp"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.total_comp.DefaultCellStyle = DataGridViewCellStyle6
        Me.total_comp.HeaderText = "MONTO"
        Me.total_comp.Name = "total_comp"
        Me.total_comp.Width = 80
        '
        'glosa
        '
        Me.glosa.DataPropertyName = "glosa"
        Me.glosa.HeaderText = "GLOSA"
        Me.glosa.Name = "glosa"
        Me.glosa.Width = 150
        '
        'cliente
        '
        Me.cliente.DataPropertyName = "cliente"
        Me.cliente.HeaderText = "CLIENTE"
        Me.cliente.Name = "cliente"
        Me.cliente.Width = 160
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.total.DefaultCellStyle = DataGridViewCellStyle7
        Me.total.HeaderText = "VALOR"
        Me.total.Name = "total"
        Me.total.Width = 80
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
        Me.estado.Width = 80
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionar.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnSeleccionar.ForeColor = System.Drawing.Color.White
        Me.btnSeleccionar.Location = New System.Drawing.Point(661, 372)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(111, 27)
        Me.btnSeleccionar.TabIndex = 340
        Me.btnSeleccionar.Text = "SELECCIONAR"
        Me.btnSeleccionar.UseVisualStyleBackColor = False
        Me.btnSeleccionar.Visible = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel5.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Panel5.Location = New System.Drawing.Point(618, 52)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(22, 17)
        Me.Panel5.TabIndex = 388
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label52.Location = New System.Drawing.Point(646, 52)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(126, 16)
        Me.Label52.TabIndex = 389
        Me.Label52.Text = "Utilizadas como pago"
        '
        'frmListaNotasCreditoCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.dgvLista)
        Me.Controls.Add(Me.lblTituloForm)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmListaNotasCreditoCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LISTA DE NOTAS DE CRÉDITO - COMPRAS"
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTituloForm As System.Windows.Forms.Label
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents chek As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents motivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_comp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents glosa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents moneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fec_reg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label52 As System.Windows.Forms.Label
End Class
