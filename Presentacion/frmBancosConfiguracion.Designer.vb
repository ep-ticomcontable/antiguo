<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBancosConfiguracion
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.banco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.corriente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.gbGrupo = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.rbSi = New System.Windows.Forms.RadioButton()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboBancos = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCuentaCorriente = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.lblTituloForm = New System.Windows.Forms.Label()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGrupo.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.dgvLista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.banco, Me.moneda, Me.corriente, Me.cuenta, Me.estado})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvLista.Location = New System.Drawing.Point(12, 99)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.Size = New System.Drawing.Size(702, 213)
        Me.dgvLista.TabIndex = 204
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "N°"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 50
        '
        'banco
        '
        Me.banco.DataPropertyName = "banco"
        Me.banco.HeaderText = "BANCO"
        Me.banco.Name = "banco"
        Me.banco.ReadOnly = True
        Me.banco.Width = 200
        '
        'moneda
        '
        Me.moneda.DataPropertyName = "moneda"
        Me.moneda.HeaderText = "MONEDA"
        Me.moneda.Name = "moneda"
        Me.moneda.ReadOnly = True
        Me.moneda.Width = 150
        '
        'corriente
        '
        Me.corriente.DataPropertyName = "corriente"
        Me.corriente.HeaderText = "CUENTA CORRIENTE"
        Me.corriente.Name = "corriente"
        Me.corriente.ReadOnly = True
        Me.corriente.Width = 150
        '
        'cuenta
        '
        Me.cuenta.DataPropertyName = "cuenta"
        Me.cuenta.HeaderText = "CTA CONT"
        Me.cuenta.Name = "cuenta"
        Me.cuenta.ReadOnly = True
        Me.cuenta.Width = 90
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        Me.estado.Visible = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(344, 63)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(78, 30)
        Me.btnBuscar.TabIndex = 206
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
        Me.txtDato.Size = New System.Drawing.Size(234, 25)
        Me.txtDato.TabIndex = 0
        '
        'gbGrupo
        '
        Me.gbGrupo.Controls.Add(Me.Label11)
        Me.gbGrupo.Controls.Add(Me.rbSi)
        Me.gbGrupo.Controls.Add(Me.rbNo)
        Me.gbGrupo.Controls.Add(Me.lblCuenta)
        Me.gbGrupo.Controls.Add(Me.cboMoneda)
        Me.gbGrupo.Controls.Add(Me.Label1)
        Me.gbGrupo.Controls.Add(Me.cboBancos)
        Me.gbGrupo.Controls.Add(Me.Label2)
        Me.gbGrupo.Controls.Add(Me.txtCuenta)
        Me.gbGrupo.Controls.Add(Me.Label39)
        Me.gbGrupo.Controls.Add(Me.Label4)
        Me.gbGrupo.Controls.Add(Me.txtCuentaCorriente)
        Me.gbGrupo.Enabled = False
        Me.gbGrupo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGrupo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.gbGrupo.Location = New System.Drawing.Point(12, 318)
        Me.gbGrupo.Name = "gbGrupo"
        Me.gbGrupo.Size = New System.Drawing.Size(702, 119)
        Me.gbGrupo.TabIndex = 3
        Me.gbGrupo.TabStop = False
        Me.gbGrupo.Text = "Datos de registros"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(518, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 17)
        Me.Label11.TabIndex = 322
        Me.Label11.Text = "Estado del registro:"
        '
        'rbSi
        '
        Me.rbSi.AutoSize = True
        Me.rbSi.Checked = True
        Me.rbSi.Location = New System.Drawing.Point(521, 90)
        Me.rbSi.Name = "rbSi"
        Me.rbSi.Size = New System.Drawing.Size(61, 20)
        Me.rbSi.TabIndex = 323
        Me.rbSi.TabStop = True
        Me.rbSi.Text = "Activo"
        Me.rbSi.UseVisualStyleBackColor = True
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Location = New System.Drawing.Point(588, 90)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(72, 20)
        Me.rbNo.TabIndex = 324
        Me.rbNo.Text = "Inactivo"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'lblCuenta
        '
        Me.lblCuenta.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCuenta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblCuenta.Location = New System.Drawing.Point(86, 92)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(404, 18)
        Me.lblCuenta.TabIndex = 318
        Me.lblCuenta.Text = "CUENTA"
        '
        'cboMoneda
        '
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(247, 39)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(243, 25)
        Me.cboMoneda.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(243, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 237
        Me.Label1.Text = "Moneda"
        '
        'cboBancos
        '
        Me.cboBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBancos.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.cboBancos.FormattingEnabled = True
        Me.cboBancos.Location = New System.Drawing.Point(6, 39)
        Me.cboBancos.Name = "cboBancos"
        Me.cboBancos.Size = New System.Drawing.Size(235, 25)
        Me.cboBancos.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(2, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 19)
        Me.Label2.TabIndex = 230
        Me.Label2.Text = "Bancos"
        '
        'txtCuenta
        '
        Me.txtCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuenta.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtCuenta.Location = New System.Drawing.Point(6, 88)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(74, 24)
        Me.txtCuenta.TabIndex = 4
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label39.Location = New System.Drawing.Point(2, 67)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(132, 19)
        Me.Label39.TabIndex = 229
        Me.Label39.Text = "Cuenta Contable"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(492, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 19)
        Me.Label4.TabIndex = 231
        Me.Label4.Text = "Cuenta Corriente"
        '
        'txtCuentaCorriente
        '
        Me.txtCuentaCorriente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaCorriente.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtCuentaCorriente.Location = New System.Drawing.Point(496, 39)
        Me.txtCuentaCorriente.Name = "txtCuentaCorriente"
        Me.txtCuentaCorriente.Size = New System.Drawing.Size(200, 24)
        Me.txtCuentaCorriente.TabIndex = 2
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(568, 443)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(146, 30)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar cambios"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(456, 443)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(106, 30)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(636, 63)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(78, 30)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(533, 63)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(95, 30)
        Me.btnModificar.TabIndex = 1
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
        Me.lblTituloForm.Size = New System.Drawing.Size(402, 53)
        Me.lblTituloForm.TabIndex = 212
        Me.lblTituloForm.Text = "BANCOS - CONFIGURACIÓN"
        '
        'frmBancosConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(726, 483)
        Me.Controls.Add(Me.lblTituloForm)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.gbGrupo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDato)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dgvLista)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmBancosConfiguracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGrupo.ResumeLayout(False)
        Me.gbGrupo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDato As System.Windows.Forms.TextBox
    Friend WithEvents gbGrupo As System.Windows.Forms.GroupBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents lblTituloForm As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents cboBancos As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaCorriente As System.Windows.Forms.TextBox
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCuenta As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents rbSi As System.Windows.Forms.RadioButton
    Friend WithEvents rbNo As System.Windows.Forms.RadioButton
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents banco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents moneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents corriente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
