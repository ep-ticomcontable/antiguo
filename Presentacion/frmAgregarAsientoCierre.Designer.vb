<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarAsientoCierre
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtGlosa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDebe = New System.Windows.Forms.TextBox()
        Me.txtHaber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNomCuenta = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.gbDocumento = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.num_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.glosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDocumento.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtGlosa
        '
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.Location = New System.Drawing.Point(12, 146)
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(437, 21)
        Me.txtGlosa.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Glosa"
        '
        'txtDebe
        '
        Me.txtDebe.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebe.Location = New System.Drawing.Point(12, 74)
        Me.txtDebe.Name = "txtDebe"
        Me.txtDebe.Size = New System.Drawing.Size(80, 21)
        Me.txtDebe.TabIndex = 2
        Me.txtDebe.Text = "0.00"
        Me.txtDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHaber
        '
        Me.txtHaber.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHaber.Location = New System.Drawing.Point(129, 74)
        Me.txtHaber.Name = "txtHaber"
        Me.txtHaber.Size = New System.Drawing.Size(80, 21)
        Me.txtHaber.TabIndex = 3
        Me.txtHaber.Text = "0.00"
        Me.txtHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 16)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Debe"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(126, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Haber"
        '
        'txtCuenta
        '
        Me.txtCuenta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.Location = New System.Drawing.Point(12, 25)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(73, 21)
        Me.txtCuenta.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Cuenta"
        '
        'lblNomCuenta
        '
        Me.lblNomCuenta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomCuenta.Location = New System.Drawing.Point(91, 28)
        Me.lblNomCuenta.Name = "lblNomCuenta"
        Me.lblNomCuenta.Size = New System.Drawing.Size(486, 16)
        Me.lblNomCuenta.TabIndex = 1
        Me.lblNomCuenta.Text = "[Nombre Cuenta]"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(455, 365)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(122, 35)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'dtFecha
        '
        Me.dtFecha.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(102, 101)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(107, 21)
        Me.dtFecha.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Fecha:"
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num_cuenta, Me.desc_cuenta, Me.debe, Me.haber, Me.glosa, Me.id_doc, Me.num_doc, Me.fecha})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvLista.Location = New System.Drawing.Point(12, 173)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.Size = New System.Drawing.Size(565, 186)
        Me.dgvLista.TabIndex = 201
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 16)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Tipo de documento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(188, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 16)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Número"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(190, 37)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(108, 21)
        Me.txtNumero.TabIndex = 7
        Me.txtNumero.Text = "-"
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTipoDocumento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoDocumento.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocumento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboTipoDocumento.FormattingEnabled = True
        Me.cboTipoDocumento.Location = New System.Drawing.Point(10, 36)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(175, 23)
        Me.cboTipoDocumento.TabIndex = 45
        '
        'gbDocumento
        '
        Me.gbDocumento.Controls.Add(Me.cboTipoDocumento)
        Me.gbDocumento.Controls.Add(Me.txtNumero)
        Me.gbDocumento.Controls.Add(Me.Label8)
        Me.gbDocumento.Controls.Add(Me.Label7)
        Me.gbDocumento.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDocumento.Location = New System.Drawing.Point(215, 64)
        Me.gbDocumento.Name = "gbDocumento"
        Me.gbDocumento.Size = New System.Drawing.Size(313, 74)
        Me.gbDocumento.TabIndex = 6
        Me.gbDocumento.TabStop = False
        Me.gbDocumento.Text = "Documentación"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(455, 144)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(122, 23)
        Me.btnAgregar.TabIndex = 202
        Me.btnAgregar.Text = "AGREGAR CUENTA"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'num_cuenta
        '
        Me.num_cuenta.DataPropertyName = "num_cuenta"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.num_cuenta.DefaultCellStyle = DataGridViewCellStyle2
        Me.num_cuenta.HeaderText = "Cuenta"
        Me.num_cuenta.Name = "num_cuenta"
        Me.num_cuenta.ReadOnly = True
        Me.num_cuenta.Width = 60
        '
        'desc_cuenta
        '
        Me.desc_cuenta.DataPropertyName = "desc_cuenta"
        Me.desc_cuenta.HeaderText = "Desc. Cuenta"
        Me.desc_cuenta.Name = "desc_cuenta"
        Me.desc_cuenta.ReadOnly = True
        Me.desc_cuenta.Width = 262
        '
        'debe
        '
        Me.debe.DataPropertyName = "debe"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.debe.DefaultCellStyle = DataGridViewCellStyle3
        Me.debe.HeaderText = "Debe"
        Me.debe.Name = "debe"
        Me.debe.ReadOnly = True
        Me.debe.Width = 90
        '
        'haber
        '
        Me.haber.DataPropertyName = "haber"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.haber.DefaultCellStyle = DataGridViewCellStyle4
        Me.haber.HeaderText = "Haber"
        Me.haber.Name = "haber"
        Me.haber.ReadOnly = True
        Me.haber.Width = 90
        '
        'glosa
        '
        Me.glosa.DataPropertyName = "glosa"
        Me.glosa.HeaderText = "glosa"
        Me.glosa.Name = "glosa"
        Me.glosa.ReadOnly = True
        Me.glosa.Visible = False
        '
        'id_doc
        '
        Me.id_doc.DataPropertyName = "id_doc"
        Me.id_doc.HeaderText = "id_doc"
        Me.id_doc.Name = "id_doc"
        Me.id_doc.ReadOnly = True
        Me.id_doc.Visible = False
        '
        'num_doc
        '
        Me.num_doc.DataPropertyName = "num_doc"
        Me.num_doc.HeaderText = "num_doc"
        Me.num_doc.Name = "num_doc"
        Me.num_doc.ReadOnly = True
        Me.num_doc.Visible = False
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "fecha"
        Me.fecha.HeaderText = "fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Visible = False
        '
        'frmAgregarAsientoCierre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 412)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvLista)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblNomCuenta)
        Me.Controls.Add(Me.gbDocumento)
        Me.Controls.Add(Me.txtGlosa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDebe)
        Me.Controls.Add(Me.txtHaber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAgregarAsientoCierre"
        Me.Text = "Agregar Asientos para Cierre de Periodo"
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDocumento.ResumeLayout(False)
        Me.gbDocumento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtGlosa As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDebe As System.Windows.Forms.TextBox
    Friend WithEvents txtHaber As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNomCuenta As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents cboTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents gbDocumento As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents num_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents glosa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents num_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
