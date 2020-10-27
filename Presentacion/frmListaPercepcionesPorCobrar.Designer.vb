<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaPercepcionesPorCobrar
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
        Me.lblTituloForm = New System.Windows.Forms.Label()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.chek = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_comprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.glosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.percibido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fec_reg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblDeuda = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblMontoCompra = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblFechaEmision = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblDescripcionCompra = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTipoCambio = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LblMoneda = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblSerieNumero = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblRazonNombre = New System.Windows.Forms.Label()
        Me.lblDniRuc = New System.Windows.Forms.Label()
        Me.lblDocumento = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
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
        Me.lblTituloForm.Size = New System.Drawing.Size(407, 59)
        Me.lblTituloForm.TabIndex = 5
        Me.lblTituloForm.Text = "LISTA DE PERCEPCIONES"
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToOrderColumns = True
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chek, Me.id, Me.serie, Me.numero, Me.id_comprobante, Me.glosa, Me.moneda, Me.total, Me.percibido, Me.fec_reg, Me.estado})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLista.Location = New System.Drawing.Point(12, 63)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.Size = New System.Drawing.Size(760, 252)
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
        'id_comprobante
        '
        Me.id_comprobante.DataPropertyName = "id_comprobante"
        Me.id_comprobante.HeaderText = "id_comprobante"
        Me.id_comprobante.Name = "id_comprobante"
        Me.id_comprobante.Visible = False
        '
        'glosa
        '
        Me.glosa.DataPropertyName = "glosa"
        Me.glosa.HeaderText = "GLOSA"
        Me.glosa.Name = "glosa"
        Me.glosa.Width = 210
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
        'percibido
        '
        Me.percibido.DataPropertyName = "percibido"
        Me.percibido.HeaderText = "PERCIBIDO"
        Me.percibido.Name = "percibido"
        Me.percibido.Width = 80
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblDeuda)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.lblMontoCompra)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.lblFechaEmision)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.lblDescripcionCompra)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.lblTipoCambio)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.LblMoneda)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.lblSerieNumero)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.lblRazonNombre)
        Me.GroupBox4.Controls.Add(Me.lblDniRuc)
        Me.GroupBox4.Controls.Add(Me.lblDocumento)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 336)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(760, 163)
        Me.GroupBox4.TabIndex = 339
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DATOS COMPROBANTE - PROVEEDOR"
        '
        'lblDeuda
        '
        Me.lblDeuda.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeuda.ForeColor = System.Drawing.Color.Red
        Me.lblDeuda.Location = New System.Drawing.Point(607, 89)
        Me.lblDeuda.Name = "lblDeuda"
        Me.lblDeuda.Size = New System.Drawing.Size(107, 16)
        Me.lblDeuda.TabIndex = 307
        Me.lblDeuda.Text = "[Nombre Cuenta]"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(607, 70)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(49, 16)
        Me.Label28.TabIndex = 306
        Me.Label28.Text = "Deuda:"
        '
        'lblMontoCompra
        '
        Me.lblMontoCompra.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoCompra.ForeColor = System.Drawing.Color.Black
        Me.lblMontoCompra.Location = New System.Drawing.Point(499, 89)
        Me.lblMontoCompra.Name = "lblMontoCompra"
        Me.lblMontoCompra.Size = New System.Drawing.Size(107, 16)
        Me.lblMontoCompra.TabIndex = 115
        Me.lblMontoCompra.Text = "[Nombre Cuenta]"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(499, 70)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(83, 16)
        Me.Label20.TabIndex = 114
        Me.Label20.Text = "Monto Venta:"
        '
        'lblFechaEmision
        '
        Me.lblFechaEmision.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaEmision.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblFechaEmision.Location = New System.Drawing.Point(499, 134)
        Me.lblFechaEmision.Name = "lblFechaEmision"
        Me.lblFechaEmision.Size = New System.Drawing.Size(215, 16)
        Me.lblFechaEmision.TabIndex = 109
        Me.lblFechaEmision.Text = "[Nombre Cuenta]"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(499, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 16)
        Me.Label9.TabIndex = 108
        Me.Label9.Text = "Fecha Emisión:"
        '
        'lblDescripcionCompra
        '
        Me.lblDescripcionCompra.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblDescripcionCompra.Location = New System.Drawing.Point(9, 134)
        Me.lblDescripcionCompra.Name = "lblDescripcionCompra"
        Me.lblDescripcionCompra.Size = New System.Drawing.Size(479, 16)
        Me.lblDescripcionCompra.TabIndex = 107
        Me.lblDescripcionCompra.Text = "[Nombre Cuenta]"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 16)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "Descripción:"
        '
        'lblTipoCambio
        '
        Me.lblTipoCambio.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoCambio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblTipoCambio.Location = New System.Drawing.Point(390, 89)
        Me.lblTipoCambio.Name = "lblTipoCambio"
        Me.lblTipoCambio.Size = New System.Drawing.Size(103, 16)
        Me.lblTipoCambio.TabIndex = 105
        Me.lblTipoCambio.Text = "[Nombre Cuenta]"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(390, 70)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(98, 16)
        Me.Label17.TabIndex = 104
        Me.Label17.Text = "Tipo de Cambio:"
        '
        'LblMoneda
        '
        Me.LblMoneda.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMoneda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.LblMoneda.Location = New System.Drawing.Point(325, 89)
        Me.LblMoneda.Name = "LblMoneda"
        Me.LblMoneda.Size = New System.Drawing.Size(59, 16)
        Me.LblMoneda.TabIndex = 103
        Me.LblMoneda.Text = "[Nombre Cuenta]"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(325, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 16)
        Me.Label13.TabIndex = 102
        Me.Label13.Text = "Moneda:"
        '
        'lblSerieNumero
        '
        Me.lblSerieNumero.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerieNumero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblSerieNumero.Location = New System.Drawing.Point(151, 89)
        Me.lblSerieNumero.Name = "lblSerieNumero"
        Me.lblSerieNumero.Size = New System.Drawing.Size(151, 16)
        Me.lblSerieNumero.TabIndex = 101
        Me.lblSerieNumero.Text = "[Nombre Cuenta]"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(151, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 16)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "Serie - Número:"
        '
        'lblRazonNombre
        '
        Me.lblRazonNombre.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazonNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblRazonNombre.Location = New System.Drawing.Point(151, 43)
        Me.lblRazonNombre.Name = "lblRazonNombre"
        Me.lblRazonNombre.Size = New System.Drawing.Size(563, 16)
        Me.lblRazonNombre.TabIndex = 99
        Me.lblRazonNombre.Text = "[Nombre Cuenta]"
        '
        'lblDniRuc
        '
        Me.lblDniRuc.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDniRuc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblDniRuc.Location = New System.Drawing.Point(6, 43)
        Me.lblDniRuc.Name = "lblDniRuc"
        Me.lblDniRuc.Size = New System.Drawing.Size(133, 16)
        Me.lblDniRuc.TabIndex = 98
        Me.lblDniRuc.Text = "[Nombre Cuenta]"
        '
        'lblDocumento
        '
        Me.lblDocumento.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblDocumento.Location = New System.Drawing.Point(6, 89)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(133, 16)
        Me.lblDocumento.TabIndex = 97
        Me.lblDocumento.Text = "[Nombre Cuenta]"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 16)
        Me.Label11.TabIndex = 96
        Me.Label11.Text = "Tipo Documento:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(151, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(132, 16)
        Me.Label16.TabIndex = 91
        Me.Label16.Text = "Nombres/Razón Social:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 16)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "DNI/RUC:"
        '
        'frmListaPercepcionesPorCobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 511)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.dgvLista)
        Me.Controls.Add(Me.lblTituloForm)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmListaPercepcionesPorCobrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PERCEPCIONES REGISTRADAS"
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTituloForm As System.Windows.Forms.Label
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDeuda As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lblMontoCompra As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblFechaEmision As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblDescripcionCompra As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTipoCambio As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LblMoneda As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblSerieNumero As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblRazonNombre As System.Windows.Forms.Label
    Friend WithEvents lblDniRuc As System.Windows.Forms.Label
    Friend WithEvents lblDocumento As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents chek As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_comprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents glosa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents moneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents percibido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fec_reg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
