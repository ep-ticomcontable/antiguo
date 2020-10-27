<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaSunat
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
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.txtRazSoc = New System.Windows.Forms.TextBox()
        Me.txtNumDni = New System.Windows.Forms.TextBox()
        Me.RbRazSoc = New System.Windows.Forms.RadioButton()
        Me.rbDni = New System.Windows.Forms.RadioButton()
        Me.rbRuc = New System.Windows.Forms.RadioButton()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtNumRuc = New System.Windows.Forms.TextBox()
        Me.txtRazon = New System.Windows.Forms.TextBox()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtCapcha = New System.Windows.Forms.TextBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnElegirCuenta = New System.Windows.Forms.Button()
        Me.pictureCapcha = New System.Windows.Forms.PictureBox()
        Me.ruc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.razon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ubicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureCapcha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToOrderColumns = True
        Me.dgvLista.AllowUserToResizeColumns = False
        Me.dgvLista.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.dgvLista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ruc, Me.razon, Me.ubicacion, Me.direccion, Me.estado})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLista.Location = New System.Drawing.Point(15, 129)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.RowHeadersWidth = 24
        Me.dgvLista.Size = New System.Drawing.Size(743, 253)
        Me.dgvLista.TabIndex = 50
        '
        'txtRazSoc
        '
        Me.txtRazSoc.AccessibleDescription = ""
        Me.txtRazSoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRazSoc.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazSoc.Location = New System.Drawing.Point(142, 58)
        Me.txtRazSoc.MaxLength = 255
        Me.txtRazSoc.Name = "txtRazSoc"
        Me.txtRazSoc.Size = New System.Drawing.Size(393, 22)
        Me.txtRazSoc.TabIndex = 4
        '
        'txtNumDni
        '
        Me.txtNumDni.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumDni.Location = New System.Drawing.Point(142, 35)
        Me.txtNumDni.MaxLength = 8
        Me.txtNumDni.Name = "txtNumDni"
        Me.txtNumDni.Size = New System.Drawing.Size(166, 22)
        Me.txtNumDni.TabIndex = 3
        '
        'RbRazSoc
        '
        Me.RbRazSoc.AutoSize = True
        Me.RbRazSoc.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbRazSoc.Location = New System.Drawing.Point(12, 61)
        Me.RbRazSoc.Name = "RbRazSoc"
        Me.RbRazSoc.Size = New System.Drawing.Size(126, 21)
        Me.RbRazSoc.TabIndex = 47
        Me.RbRazSoc.TabStop = True
        Me.RbRazSoc.Text = "Por Razón Social:"
        Me.RbRazSoc.UseVisualStyleBackColor = True
        '
        'rbDni
        '
        Me.rbDni.AutoSize = True
        Me.rbDni.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDni.Location = New System.Drawing.Point(12, 38)
        Me.rbDni.Name = "rbDni"
        Me.rbDni.Size = New System.Drawing.Size(72, 21)
        Me.rbDni.TabIndex = 46
        Me.rbDni.TabStop = True
        Me.rbDni.Text = "Por DNI:"
        Me.rbDni.UseVisualStyleBackColor = True
        '
        'rbRuc
        '
        Me.rbRuc.AutoSize = True
        Me.rbRuc.Checked = True
        Me.rbRuc.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRuc.Location = New System.Drawing.Point(12, 15)
        Me.rbRuc.Name = "rbRuc"
        Me.rbRuc.Size = New System.Drawing.Size(99, 21)
        Me.rbRuc.TabIndex = 45
        Me.rbRuc.TabStop = True
        Me.rbRuc.Text = "Por Nro RUC:"
        Me.rbRuc.UseVisualStyleBackColor = True
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtTelefono.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.ForeColor = System.Drawing.Color.Black
        Me.txtTelefono.Location = New System.Drawing.Point(15, 352)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.ReadOnly = True
        Me.txtTelefono.Size = New System.Drawing.Size(743, 22)
        Me.txtTelefono.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Gold
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(0, 392)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(771, 17)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Telefonos"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 332)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 17)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Telefonos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 287)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 17)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Estado"
        '
        'txtEstado
        '
        Me.txtEstado.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtEstado.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.ForeColor = System.Drawing.Color.Black
        Me.txtEstado.Location = New System.Drawing.Point(15, 307)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(743, 22)
        Me.txtEstado.TabIndex = 40
        '
        'txtNumRuc
        '
        Me.txtNumRuc.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumRuc.Location = New System.Drawing.Point(142, 12)
        Me.txtNumRuc.MaxLength = 11
        Me.txtNumRuc.Name = "txtNumRuc"
        Me.txtNumRuc.Size = New System.Drawing.Size(166, 22)
        Me.txtNumRuc.TabIndex = 1
        '
        'txtRazon
        '
        Me.txtRazon.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtRazon.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazon.ForeColor = System.Drawing.Color.Black
        Me.txtRazon.Location = New System.Drawing.Point(15, 154)
        Me.txtRazon.Name = "txtRazon"
        Me.txtRazon.ReadOnly = True
        Me.txtRazon.Size = New System.Drawing.Size(743, 22)
        Me.txtRazon.TabIndex = 35
        '
        'txtRuc
        '
        Me.txtRuc.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtRuc.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.ForeColor = System.Drawing.Color.Black
        Me.txtRuc.Location = New System.Drawing.Point(15, 199)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.ReadOnly = True
        Me.txtRuc.Size = New System.Drawing.Size(743, 22)
        Me.txtRuc.TabIndex = 36
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.txtDireccion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.Color.Black
        Me.txtDireccion.Location = New System.Drawing.Point(15, 244)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(743, 40)
        Me.txtDireccion.TabIndex = 37
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(12, 134)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(83, 17)
        Me.label5.TabIndex = 32
        Me.label5.Text = "Razon Social"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(12, 179)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(32, 17)
        Me.label4.TabIndex = 33
        Me.label4.Text = "RUC"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(12, 224)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(66, 17)
        Me.label1.TabIndex = 34
        Me.label1.Text = "Direccion"
        '
        'txtCapcha
        '
        Me.txtCapcha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCapcha.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapcha.Location = New System.Drawing.Point(682, 47)
        Me.txtCapcha.MaxLength = 4
        Me.txtCapcha.Name = "txtCapcha"
        Me.txtCapcha.Size = New System.Drawing.Size(75, 22)
        Me.txtCapcha.TabIndex = 2
        Me.txtCapcha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnConsultar.ForeColor = System.Drawing.Color.White
        Me.btnConsultar.Location = New System.Drawing.Point(12, 88)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(165, 35)
        Me.btnConsultar.TabIndex = 5
        Me.btnConsultar.Text = "REALIZAR CONSULTA"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Location = New System.Drawing.Point(541, 88)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(217, 35)
        Me.btnActualizar.TabIndex = 6
        Me.btnActualizar.Text = "ACTUALIZAR CAPTCHA"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label2.Location = New System.Drawing.Point(676, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Ingrese código:"
        '
        'btnElegirCuenta
        '
        Me.btnElegirCuenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnElegirCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnElegirCuenta.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnElegirCuenta.ForeColor = System.Drawing.Color.White
        Me.btnElegirCuenta.Location = New System.Drawing.Point(183, 88)
        Me.btnElegirCuenta.Name = "btnElegirCuenta"
        Me.btnElegirCuenta.Size = New System.Drawing.Size(165, 35)
        Me.btnElegirCuenta.TabIndex = 54
        Me.btnElegirCuenta.Text = "ELEGIR CUENTA"
        Me.btnElegirCuenta.UseVisualStyleBackColor = False
        '
        'pictureCapcha
        '
        Me.pictureCapcha.BackColor = System.Drawing.Color.White
        Me.pictureCapcha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureCapcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureCapcha.Location = New System.Drawing.Point(541, 12)
        Me.pictureCapcha.Name = "pictureCapcha"
        Me.pictureCapcha.Padding = New System.Windows.Forms.Padding(18, 10, 0, 0)
        Me.pictureCapcha.Size = New System.Drawing.Size(134, 68)
        Me.pictureCapcha.TabIndex = 29
        Me.pictureCapcha.TabStop = False
        '
        'ruc
        '
        Me.ruc.DataPropertyName = "Ruc"
        Me.ruc.HeaderText = "Nro Ruc"
        Me.ruc.Name = "ruc"
        Me.ruc.ReadOnly = True
        '
        'razon
        '
        Me.razon.DataPropertyName = "Razon_Social"
        Me.razon.HeaderText = "Nombre o Razón Social"
        Me.razon.Name = "razon"
        Me.razon.ReadOnly = True
        Me.razon.Width = 320
        '
        'ubicacion
        '
        Me.ubicacion.DataPropertyName = "Ubicacion"
        Me.ubicacion.HeaderText = "Ubicación"
        Me.ubicacion.Name = "ubicacion"
        Me.ubicacion.ReadOnly = True
        Me.ubicacion.Width = 150
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "Direccion"
        Me.direccion.HeaderText = "Dirección"
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        Me.direccion.Visible = False
        Me.direccion.Width = 150
        '
        'estado
        '
        Me.estado.DataPropertyName = "Estado"
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        Me.estado.Width = 128
        '
        'frmConsultaSunat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 409)
        Me.Controls.Add(Me.btnElegirCuenta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.dgvLista)
        Me.Controls.Add(Me.txtRazSoc)
        Me.Controls.Add(Me.txtNumDni)
        Me.Controls.Add(Me.RbRazSoc)
        Me.Controls.Add(Me.rbDni)
        Me.Controls.Add(Me.rbRuc)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.txtNumRuc)
        Me.Controls.Add(Me.txtRazon)
        Me.Controls.Add(Me.txtRuc)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pictureCapcha)
        Me.Controls.Add(Me.txtCapcha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmConsultaSunat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta RUC - SUNAT"
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureCapcha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Private WithEvents txtRazSoc As System.Windows.Forms.TextBox
    Private WithEvents txtNumDni As System.Windows.Forms.TextBox
    Friend WithEvents RbRazSoc As System.Windows.Forms.RadioButton
    Friend WithEvents rbDni As System.Windows.Forms.RadioButton
    Friend WithEvents rbRuc As System.Windows.Forms.RadioButton
    Private WithEvents txtTelefono As System.Windows.Forms.TextBox
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents txtEstado As System.Windows.Forms.TextBox
    Private WithEvents txtNumRuc As System.Windows.Forms.TextBox
    Private WithEvents txtRazon As System.Windows.Forms.TextBox
    Private WithEvents txtRuc As System.Windows.Forms.TextBox
    Private WithEvents txtDireccion As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents pictureCapcha As System.Windows.Forms.PictureBox
    Private WithEvents txtCapcha As System.Windows.Forms.TextBox
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnElegirCuenta As System.Windows.Forms.Button
    Friend WithEvents ruc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents razon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ubicacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
