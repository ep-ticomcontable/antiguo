<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaAperturas
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTituloForm = New System.Windows.Forms.Label()
        Me.panelAsientos = New System.Windows.Forms.GroupBox()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvCabecera = New System.Windows.Forms.DataGridView()
        Me.btnApertura = New System.Windows.Forms.Button()
        Me.btnReapertura = New System.Windows.Forms.Button()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.t_debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.t_haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_debe_d = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_haber_d = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debeD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haberD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.glosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelAsientos.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTituloForm
        '
        Me.lblTituloForm.AutoSize = True
        Me.lblTituloForm.BackColor = System.Drawing.Color.Transparent
        Me.lblTituloForm.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblTituloForm.Location = New System.Drawing.Point(-8, -8)
        Me.lblTituloForm.Name = "lblTituloForm"
        Me.lblTituloForm.Padding = New System.Windows.Forms.Padding(10)
        Me.lblTituloForm.Size = New System.Drawing.Size(341, 59)
        Me.lblTituloForm.TabIndex = 3
        Me.lblTituloForm.Text = "LISTA DE APERTURAS"
        '
        'panelAsientos
        '
        Me.panelAsientos.Controls.Add(Me.dgvDetalle)
        Me.panelAsientos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelAsientos.Location = New System.Drawing.Point(12, 183)
        Me.panelAsientos.Name = "panelAsientos"
        Me.panelAsientos.Size = New System.Drawing.Size(760, 366)
        Me.panelAsientos.TabIndex = 304
        Me.panelAsientos.TabStop = False
        Me.panelAsientos.Text = "ASIENTOS CONTABLES"
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.AllowUserToOrderColumns = True
        Me.dgvDetalle.BackgroundColor = System.Drawing.Color.White
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num_cuenta, Me.desc_cuenta, Me.debe, Me.haber, Me.debeD, Me.haberD, Me.glosa})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetalle.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvDetalle.Location = New System.Drawing.Point(6, 20)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.Size = New System.Drawing.Size(748, 340)
        Me.dgvDetalle.TabIndex = 1
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(668, 16)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(104, 35)
        Me.btnModificar.TabIndex = 5
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvCabecera)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(760, 128)
        Me.GroupBox1.TabIndex = 305
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ASIENTOS CONTABLES"
        '
        'dgvCabecera
        '
        Me.dgvCabecera.AllowUserToAddRows = False
        Me.dgvCabecera.AllowUserToDeleteRows = False
        Me.dgvCabecera.AllowUserToOrderColumns = True
        Me.dgvCabecera.BackgroundColor = System.Drawing.Color.White
        Me.dgvCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabecera.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero, Me.descripcion, Me.t_debe, Me.t_haber, Me.total_debe_d, Me.total_haber_d, Me.fecha, Me.estado})
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCabecera.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvCabecera.Location = New System.Drawing.Point(6, 20)
        Me.dgvCabecera.Name = "dgvCabecera"
        Me.dgvCabecera.ReadOnly = True
        Me.dgvCabecera.Size = New System.Drawing.Size(747, 103)
        Me.dgvCabecera.TabIndex = 0
        '
        'btnApertura
        '
        Me.btnApertura.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnApertura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApertura.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnApertura.ForeColor = System.Drawing.Color.White
        Me.btnApertura.Location = New System.Drawing.Point(428, 16)
        Me.btnApertura.Name = "btnApertura"
        Me.btnApertura.Size = New System.Drawing.Size(104, 35)
        Me.btnApertura.TabIndex = 306
        Me.btnApertura.Text = "APERTURAR"
        Me.btnApertura.UseVisualStyleBackColor = False
        '
        'btnReapertura
        '
        Me.btnReapertura.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnReapertura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReapertura.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnReapertura.ForeColor = System.Drawing.Color.White
        Me.btnReapertura.Location = New System.Drawing.Point(538, 16)
        Me.btnReapertura.Name = "btnReapertura"
        Me.btnReapertura.Size = New System.Drawing.Size(124, 35)
        Me.btnReapertura.TabIndex = 307
        Me.btnReapertura.Text = "ACTUALIZAR"
        Me.btnReapertura.UseVisualStyleBackColor = False
        '
        'numero
        '
        Me.numero.DataPropertyName = "numero"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.numero.DefaultCellStyle = DataGridViewCellStyle8
        Me.numero.HeaderText = "N°"
        Me.numero.Name = "numero"
        Me.numero.ReadOnly = True
        Me.numero.Width = 65
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "Glosa"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 200
        '
        't_debe
        '
        Me.t_debe.DataPropertyName = "t_debe"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.t_debe.DefaultCellStyle = DataGridViewCellStyle9
        Me.t_debe.HeaderText = "T. Debe S/"
        Me.t_debe.Name = "t_debe"
        Me.t_debe.ReadOnly = True
        Me.t_debe.Width = 90
        '
        't_haber
        '
        Me.t_haber.DataPropertyName = "t_haber"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.t_haber.DefaultCellStyle = DataGridViewCellStyle10
        Me.t_haber.HeaderText = "T. Haber S/"
        Me.t_haber.Name = "t_haber"
        Me.t_haber.ReadOnly = True
        Me.t_haber.Width = 90
        '
        'total_debe_d
        '
        Me.total_debe_d.DataPropertyName = "total_debe_d"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        Me.total_debe_d.DefaultCellStyle = DataGridViewCellStyle11
        Me.total_debe_d.HeaderText = "T. Debe $/"
        Me.total_debe_d.Name = "total_debe_d"
        Me.total_debe_d.ReadOnly = True
        Me.total_debe_d.Width = 90
        '
        'total_haber_d
        '
        Me.total_haber_d.DataPropertyName = "total_haber_d"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        Me.total_haber_d.DefaultCellStyle = DataGridViewCellStyle12
        Me.total_haber_d.HeaderText = "T. Haber $/"
        Me.total_haber_d.Name = "total_haber_d"
        Me.total_haber_d.ReadOnly = True
        Me.total_haber_d.Width = 90
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "fecha"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.fecha.DefaultCellStyle = DataGridViewCellStyle13
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 120
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.estado.DefaultCellStyle = DataGridViewCellStyle14
        Me.estado.HeaderText = "Est"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        Me.estado.Visible = False
        Me.estado.Width = 40
        '
        'num_cuenta
        '
        Me.num_cuenta.DataPropertyName = "num_cuenta"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.num_cuenta.DefaultCellStyle = DataGridViewCellStyle1
        Me.num_cuenta.HeaderText = "N° Cta."
        Me.num_cuenta.Name = "num_cuenta"
        Me.num_cuenta.ReadOnly = True
        Me.num_cuenta.Width = 75
        '
        'desc_cuenta
        '
        Me.desc_cuenta.DataPropertyName = "desc_cuenta"
        Me.desc_cuenta.HeaderText = "Descripcion"
        Me.desc_cuenta.Name = "desc_cuenta"
        Me.desc_cuenta.ReadOnly = True
        Me.desc_cuenta.Width = 200
        '
        'debe
        '
        Me.debe.DataPropertyName = "debe"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.debe.DefaultCellStyle = DataGridViewCellStyle2
        Me.debe.HeaderText = "Debe S/"
        Me.debe.Name = "debe"
        Me.debe.ReadOnly = True
        Me.debe.Width = 80
        '
        'haber
        '
        Me.haber.DataPropertyName = "haber"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.haber.DefaultCellStyle = DataGridViewCellStyle3
        Me.haber.HeaderText = "Haber S/"
        Me.haber.Name = "haber"
        Me.haber.ReadOnly = True
        Me.haber.Width = 80
        '
        'debeD
        '
        Me.debeD.DataPropertyName = "debeD"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.debeD.DefaultCellStyle = DataGridViewCellStyle4
        Me.debeD.HeaderText = "Debe $/"
        Me.debeD.Name = "debeD"
        Me.debeD.ReadOnly = True
        Me.debeD.Width = 80
        '
        'haberD
        '
        Me.haberD.DataPropertyName = "haberD"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.haberD.DefaultCellStyle = DataGridViewCellStyle5
        Me.haberD.HeaderText = "Haber $/"
        Me.haberD.Name = "haberD"
        Me.haberD.ReadOnly = True
        Me.haberD.Width = 80
        '
        'glosa
        '
        Me.glosa.DataPropertyName = "glosa"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.glosa.DefaultCellStyle = DataGridViewCellStyle6
        Me.glosa.HeaderText = "Glosa"
        Me.glosa.Name = "glosa"
        Me.glosa.ReadOnly = True
        Me.glosa.Width = 185
        '
        'frmListaAperturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.btnReapertura)
        Me.Controls.Add(Me.btnApertura)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.panelAsientos)
        Me.Controls.Add(Me.lblTituloForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmListaAperturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Registros de Apertura"
        Me.panelAsientos.ResumeLayout(False)
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTituloForm As System.Windows.Forms.Label
    Friend WithEvents panelAsientos As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCabecera As System.Windows.Forms.DataGridView
    Friend WithEvents btnApertura As System.Windows.Forms.Button
    Friend WithEvents btnReapertura As System.Windows.Forms.Button
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents t_debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents t_haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_debe_d As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_haber_d As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents num_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debeD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents haberD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents glosa As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
