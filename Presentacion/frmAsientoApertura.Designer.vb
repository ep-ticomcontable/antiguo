<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsientoApertura
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
        Me.txtHaberD = New System.Windows.Forms.TextBox()
        Me.txtDiferenciaD = New System.Windows.Forms.TextBox()
        Me.txtDebeD = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGlosa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDebeSoles = New System.Windows.Forms.TextBox()
        Me.txtHaberSoles = New System.Windows.Forms.TextBox()
        Me.txtDiferenciaSoles = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTC = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNumeroAsiento = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_asiento_apertura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.glosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_cambio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtHaberD
        '
        Me.txtHaberD.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHaberD.Location = New System.Drawing.Point(6, 95)
        Me.txtHaberD.Name = "txtHaberD"
        Me.txtHaberD.Size = New System.Drawing.Size(114, 22)
        Me.txtHaberD.TabIndex = 42
        Me.txtHaberD.Text = "0.00"
        Me.txtHaberD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiferenciaD
        '
        Me.txtDiferenciaD.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferenciaD.Location = New System.Drawing.Point(6, 143)
        Me.txtDiferenciaD.Name = "txtDiferenciaD"
        Me.txtDiferenciaD.Size = New System.Drawing.Size(114, 22)
        Me.txtDiferenciaD.TabIndex = 40
        Me.txtDiferenciaD.Text = "0.00"
        Me.txtDiferenciaD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDebeD
        '
        Me.txtDebeD.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebeD.Location = New System.Drawing.Point(6, 48)
        Me.txtDebeD.Name = "txtDebeD"
        Me.txtDebeD.Size = New System.Drawing.Size(114, 22)
        Me.txtDebeD.TabIndex = 38
        Me.txtDebeD.Text = "0.00"
        Me.txtDebeD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label4.Location = New System.Drawing.Point(953, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Dolares"
        '
        'dtFecha
        '
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(544, 20)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtFecha.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label2.Location = New System.Drawing.Point(490, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Fecha:"
        '
        'txtGlosa
        '
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.Location = New System.Drawing.Point(63, 17)
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(268, 22)
        Me.txtGlosa.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Glosa:"
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToOrderColumns = True
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.id_asiento_apertura, Me.cuenta, Me.glosa, Me.debe, Me.haber, Me.moneda, Me.tipo_cambio, Me.nom_doc, Me.num_doc})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLista.Location = New System.Drawing.Point(12, 53)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLista.Size = New System.Drawing.Size(733, 279)
        Me.dgvLista.TabIndex = 28
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(860, 299)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(149, 35)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "GUARDAR ASIENTO"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(751, 299)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(92, 35)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtDebeSoles)
        Me.GroupBox1.Controls.Add(Me.txtHaberSoles)
        Me.GroupBox1.Controls.Add(Me.txtDiferenciaSoles)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(751, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(126, 183)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Soles"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label7.Location = New System.Drawing.Point(6, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 17)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Diferencia"
        '
        'txtDebeSoles
        '
        Me.txtDebeSoles.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebeSoles.Location = New System.Drawing.Point(6, 47)
        Me.txtDebeSoles.Name = "txtDebeSoles"
        Me.txtDebeSoles.Size = New System.Drawing.Size(114, 22)
        Me.txtDebeSoles.TabIndex = 49
        Me.txtDebeSoles.Text = "0.00"
        Me.txtDebeSoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHaberSoles
        '
        Me.txtHaberSoles.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHaberSoles.Location = New System.Drawing.Point(6, 95)
        Me.txtHaberSoles.Name = "txtHaberSoles"
        Me.txtHaberSoles.Size = New System.Drawing.Size(114, 22)
        Me.txtHaberSoles.TabIndex = 48
        Me.txtHaberSoles.Text = "0.00"
        Me.txtHaberSoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiferenciaSoles
        '
        Me.txtDiferenciaSoles.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferenciaSoles.Location = New System.Drawing.Point(6, 143)
        Me.txtDiferenciaSoles.Name = "txtDiferenciaSoles"
        Me.txtDiferenciaSoles.Size = New System.Drawing.Size(114, 22)
        Me.txtDiferenciaSoles.TabIndex = 47
        Me.txtDiferenciaSoles.Text = "0.00"
        Me.txtDiferenciaSoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label5.Location = New System.Drawing.Point(6, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Total Haber"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label3.Location = New System.Drawing.Point(6, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Total Debe"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtDebeD)
        Me.GroupBox2.Controls.Add(Me.txtDiferenciaD)
        Me.GroupBox2.Controls.Add(Me.txtHaberD)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(883, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(126, 183)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dólares"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label6.Location = New System.Drawing.Point(6, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 17)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Diferencia"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label11.Location = New System.Drawing.Point(6, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 17)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Total Haber"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label12.Location = New System.Drawing.Point(6, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 17)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Total Debe"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTC)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(751, 53)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(258, 45)
        Me.GroupBox3.TabIndex = 52
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo de cambio"
        '
        'lblTC
        '
        Me.lblTC.Font = New System.Drawing.Font("Century Gothic", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblTC.ForeColor = System.Drawing.Color.Black
        Me.lblTC.Location = New System.Drawing.Point(56, 19)
        Me.lblTC.Name = "lblTC"
        Me.lblTC.Size = New System.Drawing.Size(127, 17)
        Me.lblTC.TabIndex = 45
        Me.lblTC.Text = "0.00"
        Me.lblTC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Location = New System.Drawing.Point(646, 12)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(99, 35)
        Me.btnActualizar.TabIndex = 53
        Me.btnActualizar.Text = "ACTUALIZAR"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label8.Location = New System.Drawing.Point(337, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 17)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Número:"
        '
        'txtNumeroAsiento
        '
        Me.txtNumeroAsiento.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroAsiento.Location = New System.Drawing.Point(401, 16)
        Me.txtNumeroAsiento.Name = "txtNumeroAsiento"
        Me.txtNumeroAsiento.Size = New System.Drawing.Size(59, 24)
        Me.txtNumeroAsiento.TabIndex = 2
        Me.txtNumeroAsiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "N°"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 40
        '
        'id_asiento_apertura
        '
        Me.id_asiento_apertura.DataPropertyName = "id_asiento_apertura"
        Me.id_asiento_apertura.HeaderText = "id_asiento_apertura"
        Me.id_asiento_apertura.Name = "id_asiento_apertura"
        Me.id_asiento_apertura.ReadOnly = True
        Me.id_asiento_apertura.Visible = False
        '
        'cuenta
        '
        Me.cuenta.DataPropertyName = "cuenta"
        Me.cuenta.HeaderText = "Cuenta"
        Me.cuenta.Name = "cuenta"
        Me.cuenta.ReadOnly = True
        Me.cuenta.Width = 60
        '
        'glosa
        '
        Me.glosa.DataPropertyName = "glosa"
        Me.glosa.HeaderText = "Glosa"
        Me.glosa.Name = "glosa"
        Me.glosa.ReadOnly = True
        Me.glosa.Width = 150
        '
        'debe
        '
        Me.debe.DataPropertyName = "debe"
        Me.debe.HeaderText = "Debe"
        Me.debe.Name = "debe"
        Me.debe.ReadOnly = True
        Me.debe.Width = 70
        '
        'haber
        '
        Me.haber.DataPropertyName = "haber"
        Me.haber.HeaderText = "Haber"
        Me.haber.Name = "haber"
        Me.haber.ReadOnly = True
        Me.haber.Width = 70
        '
        'moneda
        '
        Me.moneda.DataPropertyName = "moneda"
        Me.moneda.HeaderText = "Moneda"
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
        'nom_doc
        '
        Me.nom_doc.DataPropertyName = "nom_doc"
        Me.nom_doc.HeaderText = "Documento"
        Me.nom_doc.Name = "nom_doc"
        Me.nom_doc.ReadOnly = True
        Me.nom_doc.Width = 80
        '
        'num_doc
        '
        Me.num_doc.DataPropertyName = "num_doc"
        Me.num_doc.HeaderText = "N° Doc"
        Me.num_doc.Name = "num_doc"
        Me.num_doc.ReadOnly = True
        Me.num_doc.Width = 80
        '
        'frmAsientoApertura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 346)
        Me.Controls.Add(Me.txtNumeroAsiento)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtGlosa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvLista)
        Me.Name = "frmAsientoApertura"
        Me.Text = "Asiento de Apertura"
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHaberD As System.Windows.Forms.TextBox
    Friend WithEvents txtDiferenciaD As System.Windows.Forms.TextBox
    Friend WithEvents txtDebeD As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGlosa As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDebeSoles As System.Windows.Forms.TextBox
    Friend WithEvents txtHaberSoles As System.Windows.Forms.TextBox
    Friend WithEvents txtDiferenciaSoles As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTC As System.Windows.Forms.Label
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroAsiento As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_asiento_apertura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents glosa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents moneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_cambio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nom_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents num_doc As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
