<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTsCuentasTipoOperacion
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.gbGrupo = New System.Windows.Forms.GroupBox()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.btnCuenta = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvCuentas = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.lblTituloForm = New System.Windows.Forms.Label()
        Me.id_pk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_to = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGrupo.SuspendLayout()
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLista
        '
        Me.dgvLista.AllowDrop = True
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToOrderColumns = True
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.dgvLista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.codigo, Me.descripcion, Me.estado})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvLista.Location = New System.Drawing.Point(12, 99)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.Size = New System.Drawing.Size(531, 163)
        Me.dgvLista.TabIndex = 204
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 60
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 310
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(241, 63)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(78, 30)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label10.Location = New System.Drawing.Point(9, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 16)
        Me.Label10.TabIndex = 208
        Me.Label10.Text = "Dato a buscar:"
        '
        'txtDato
        '
        Me.txtDato.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtDato.Location = New System.Drawing.Point(104, 66)
        Me.txtDato.MaxLength = 1000
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(131, 25)
        Me.txtDato.TabIndex = 1
        Me.txtDato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbGrupo
        '
        Me.gbGrupo.Controls.Add(Me.lblCuenta)
        Me.gbGrupo.Controls.Add(Me.btnCuenta)
        Me.gbGrupo.Controls.Add(Me.Label3)
        Me.gbGrupo.Controls.Add(Me.cboTipo)
        Me.gbGrupo.Controls.Add(Me.Label2)
        Me.gbGrupo.Controls.Add(Me.btnAgregar)
        Me.gbGrupo.Controls.Add(Me.dgvCuentas)
        Me.gbGrupo.Controls.Add(Me.btnCancelar)
        Me.gbGrupo.Controls.Add(Me.btnGuardar)
        Me.gbGrupo.Controls.Add(Me.Label1)
        Me.gbGrupo.Controls.Add(Me.txtCuenta)
        Me.gbGrupo.Enabled = False
        Me.gbGrupo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGrupo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.gbGrupo.Location = New System.Drawing.Point(12, 268)
        Me.gbGrupo.Name = "gbGrupo"
        Me.gbGrupo.Size = New System.Drawing.Size(531, 331)
        Me.gbGrupo.TabIndex = 209
        Me.gbGrupo.TabStop = False
        Me.gbGrupo.Text = "Datos de registros"
        '
        'lblCuenta
        '
        Me.lblCuenta.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.lblCuenta.Location = New System.Drawing.Point(115, 39)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(231, 22)
        Me.lblCuenta.TabIndex = 235
        Me.lblCuenta.Text = "[Cuenta]"
        Me.lblCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCuenta
        '
        Me.btnCuenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCuenta.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnCuenta.ForeColor = System.Drawing.Color.White
        Me.btnCuenta.Location = New System.Drawing.Point(70, 35)
        Me.btnCuenta.Name = "btnCuenta"
        Me.btnCuenta.Size = New System.Drawing.Size(39, 30)
        Me.btnCuenta.TabIndex = 5
        Me.btnCuenta.Text = "..."
        Me.btnCuenta.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 17)
        Me.Label3.TabIndex = 233
        Me.Label3.Text = "Cuentas asignadas"
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(352, 39)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(88, 25)
        Me.cboTipo.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(348, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 19)
        Me.Label2.TabIndex = 232
        Me.Label2.Text = "Tipo:"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(446, 35)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(79, 30)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'dgvCuentas
        '
        Me.dgvCuentas.AllowUserToAddRows = False
        Me.dgvCuentas.AllowUserToOrderColumns = True
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.dgvCuentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvCuentas.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCuentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_pk, Me.id_to, Me.num_cuenta, Me.nom_cuenta, Me.debe, Me.haber})
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCuentas.DefaultCellStyle = DataGridViewCellStyle16
        Me.dgvCuentas.Location = New System.Drawing.Point(6, 87)
        Me.dgvCuentas.Name = "dgvCuentas"
        Me.dgvCuentas.ReadOnly = True
        Me.dgvCuentas.RowTemplate.Height = 25
        Me.dgvCuentas.Size = New System.Drawing.Size(519, 202)
        Me.dgvCuentas.TabIndex = 213
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(6, 295)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(128, 30)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(376, 295)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(149, 30)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar cambios"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 169
        Me.Label1.Text = "Cuenta:"
        '
        'txtCuenta
        '
        Me.txtCuenta.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.Location = New System.Drawing.Point(6, 39)
        Me.txtCuenta.MaxLength = 1000
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(58, 22)
        Me.txtCuenta.TabIndex = 4
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(448, 63)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(95, 30)
        Me.btnModificar.TabIndex = 3
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'lblTituloForm
        '
        Me.lblTituloForm.AutoSize = True
        Me.lblTituloForm.BackColor = System.Drawing.Color.Transparent
        Me.lblTituloForm.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.lblTituloForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblTituloForm.Location = New System.Drawing.Point(-5, -2)
        Me.lblTituloForm.Name = "lblTituloForm"
        Me.lblTituloForm.Padding = New System.Windows.Forms.Padding(10)
        Me.lblTituloForm.Size = New System.Drawing.Size(414, 53)
        Me.lblTituloForm.TabIndex = 212
        Me.lblTituloForm.Text = "Cuentas - Tipo de Operación"
        '
        'id_pk
        '
        Me.id_pk.DataPropertyName = "id_pk"
        Me.id_pk.HeaderText = "id_pk"
        Me.id_pk.Name = "id_pk"
        Me.id_pk.ReadOnly = True
        Me.id_pk.Visible = False
        '
        'id_to
        '
        Me.id_to.DataPropertyName = "id_to"
        Me.id_to.HeaderText = "id_to"
        Me.id_to.Name = "id_to"
        Me.id_to.ReadOnly = True
        Me.id_to.Visible = False
        '
        'num_cuenta
        '
        Me.num_cuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.num_cuenta.DataPropertyName = "num_cuenta"
        Me.num_cuenta.HeaderText = "N°"
        Me.num_cuenta.Name = "num_cuenta"
        Me.num_cuenta.ReadOnly = True
        Me.num_cuenta.Width = 50
        '
        'nom_cuenta
        '
        Me.nom_cuenta.DataPropertyName = "nom_cuenta"
        Me.nom_cuenta.HeaderText = "Nombre"
        Me.nom_cuenta.Name = "nom_cuenta"
        Me.nom_cuenta.ReadOnly = True
        Me.nom_cuenta.Width = 326
        '
        'debe
        '
        Me.debe.DataPropertyName = "debe"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.debe.DefaultCellStyle = DataGridViewCellStyle14
        Me.debe.HeaderText = "Debe"
        Me.debe.Name = "debe"
        Me.debe.ReadOnly = True
        Me.debe.Width = 50
        '
        'haber
        '
        Me.haber.DataPropertyName = "haber"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.haber.DefaultCellStyle = DataGridViewCellStyle15
        Me.haber.HeaderText = "Haber"
        Me.haber.Name = "haber"
        Me.haber.ReadOnly = True
        Me.haber.Width = 50
        '
        'frmTsCuentasTipoOperacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(555, 611)
        Me.Controls.Add(Me.lblTituloForm)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.gbGrupo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDato)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dgvLista)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmTsCuentasTipoOperacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGrupo.ResumeLayout(False)
        Me.gbGrupo.PerformLayout()
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDato As System.Windows.Forms.TextBox
    Friend WithEvents gbGrupo As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents lblTituloForm As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents dgvCuentas As System.Windows.Forms.DataGridView
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCuenta As System.Windows.Forms.Button
    Friend WithEvents lblCuenta As System.Windows.Forms.Label
    Friend WithEvents id_pk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_to As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents num_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nom_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents haber As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
