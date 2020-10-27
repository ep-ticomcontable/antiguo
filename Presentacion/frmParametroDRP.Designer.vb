<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametroDRP
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTituloForm = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbGrupo = New System.Windows.Forms.GroupBox()
        Me.txtVenta = New System.Windows.Forms.TextBox()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.rbSi = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCompra = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_comprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.porcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbGrupo.SuspendLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTituloForm
        '
        Me.lblTituloForm.AutoSize = True
        Me.lblTituloForm.BackColor = System.Drawing.Color.Transparent
        Me.lblTituloForm.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.lblTituloForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblTituloForm.Location = New System.Drawing.Point(-5, 10)
        Me.lblTituloForm.Name = "lblTituloForm"
        Me.lblTituloForm.Padding = New System.Windows.Forms.Padding(10)
        Me.lblTituloForm.Size = New System.Drawing.Size(571, 53)
        Me.lblTituloForm.TabIndex = 220
        Me.lblTituloForm.Text = "DETRACCIÓN, PERCEPCIÓN && RETENCIÓN"
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(445, 75)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(107, 30)
        Me.btnModificar.TabIndex = 219
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(308, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 216
        Me.Label3.Text = "Porc. (%):"
        '
        'gbGrupo
        '
        Me.gbGrupo.Controls.Add(Me.Label3)
        Me.gbGrupo.Controls.Add(Me.txtVenta)
        Me.gbGrupo.Controls.Add(Me.cboMoneda)
        Me.gbGrupo.Controls.Add(Me.btnCancelar)
        Me.gbGrupo.Controls.Add(Me.btnGuardar)
        Me.gbGrupo.Controls.Add(Me.rbNo)
        Me.gbGrupo.Controls.Add(Me.rbSi)
        Me.gbGrupo.Controls.Add(Me.Label2)
        Me.gbGrupo.Controls.Add(Me.txtCompra)
        Me.gbGrupo.Controls.Add(Me.Label11)
        Me.gbGrupo.Controls.Add(Me.Label1)
        Me.gbGrupo.Enabled = False
        Me.gbGrupo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGrupo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.gbGrupo.Location = New System.Drawing.Point(12, 294)
        Me.gbGrupo.Name = "gbGrupo"
        Me.gbGrupo.Size = New System.Drawing.Size(540, 155)
        Me.gbGrupo.TabIndex = 217
        Me.gbGrupo.TabStop = False
        Me.gbGrupo.Text = "Datos de registros"
        '
        'txtVenta
        '
        Me.txtVenta.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtVenta.Location = New System.Drawing.Point(311, 38)
        Me.txtVenta.MaxLength = 1000
        Me.txtVenta.Multiline = True
        Me.txtVenta.Name = "txtVenta"
        Me.txtVenta.Size = New System.Drawing.Size(64, 25)
        Me.txtVenta.TabIndex = 215
        Me.txtVenta.Text = "0.00"
        Me.txtVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboMoneda
        '
        Me.cboMoneda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboMoneda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMoneda.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(6, 38)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(117, 25)
        Me.cboMoneda.TabIndex = 213
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(276, 119)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(106, 30)
        Me.btnCancelar.TabIndex = 212
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(388, 119)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(146, 30)
        Me.btnGuardar.TabIndex = 211
        Me.btnGuardar.Text = "Guardar cambios"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Location = New System.Drawing.Point(132, 125)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(72, 20)
        Me.rbNo.TabIndex = 209
        Me.rbNo.Text = "Inactivo"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'rbSi
        '
        Me.rbSi.AutoSize = True
        Me.rbSi.Checked = True
        Me.rbSi.Location = New System.Drawing.Point(9, 125)
        Me.rbSi.Name = "rbSi"
        Me.rbSi.Size = New System.Drawing.Size(61, 20)
        Me.rbSi.TabIndex = 208
        Me.rbSi.TabStop = True
        Me.rbSi.Text = "Activo"
        Me.rbSi.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(129, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 207
        Me.Label2.Text = "Descripción:"
        '
        'txtCompra
        '
        Me.txtCompra.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.txtCompra.Location = New System.Drawing.Point(132, 38)
        Me.txtCompra.MaxLength = 1000
        Me.txtCompra.Multiline = True
        Me.txtCompra.Name = "txtCompra"
        Me.txtCompra.Size = New System.Drawing.Size(173, 25)
        Me.txtCompra.TabIndex = 206
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(6, 105)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 17)
        Me.Label11.TabIndex = 170
        Me.Label11.Text = "Estado del registro:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 169
        Me.Label1.Text = "Proceso:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label10.Location = New System.Drawing.Point(9, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 16)
        Me.Label10.TabIndex = 216
        Me.Label10.Text = "Dato a buscar:"
        '
        'txtDato
        '
        Me.txtDato.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtDato.Location = New System.Drawing.Point(104, 78)
        Me.txtDato.MaxLength = 1000
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(131, 25)
        Me.txtDato.TabIndex = 215
        Me.txtDato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToOrderColumns = True
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.dgvLista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.tipo_comprobante, Me.descripcion, Me.porcentaje, Me.cuenta})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvLista.Location = New System.Drawing.Point(12, 111)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.Size = New System.Drawing.Size(540, 177)
        Me.dgvLista.TabIndex = 213
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(241, 75)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(78, 30)
        Me.btnBuscar.TabIndex = 214
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "COD"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 58
        '
        'tipo_comprobante
        '
        Me.tipo_comprobante.DataPropertyName = "tipo_comprobante"
        Me.tipo_comprobante.HeaderText = "PROCESO"
        Me.tipo_comprobante.Name = "tipo_comprobante"
        Me.tipo_comprobante.ReadOnly = True
        Me.tipo_comprobante.Width = 120
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "IMPUESTO"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 170
        '
        'porcentaje
        '
        Me.porcentaje.DataPropertyName = "porcentaje"
        Me.porcentaje.HeaderText = "(%)"
        Me.porcentaje.Name = "porcentaje"
        Me.porcentaje.ReadOnly = True
        Me.porcentaje.Width = 60
        '
        'cuenta
        '
        Me.cuenta.DataPropertyName = "cuenta"
        Me.cuenta.HeaderText = "CUENTA"
        Me.cuenta.Name = "cuenta"
        Me.cuenta.ReadOnly = True
        Me.cuenta.Width = 70
        '
        'frmParametroDRP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(564, 461)
        Me.Controls.Add(Me.lblTituloForm)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.gbGrupo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDato)
        Me.Controls.Add(Me.dgvLista)
        Me.Controls.Add(Me.btnBuscar)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmParametroDRP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMPUESTOS SUNAT"
        Me.gbGrupo.ResumeLayout(False)
        Me.gbGrupo.PerformLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTituloForm As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbGrupo As System.Windows.Forms.GroupBox
    Friend WithEvents txtVenta As System.Windows.Forms.TextBox
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents rbNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbSi As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDato As System.Windows.Forms.TextBox
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_comprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents porcentaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
