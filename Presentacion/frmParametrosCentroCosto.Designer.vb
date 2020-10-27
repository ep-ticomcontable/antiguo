<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametrosCentroCosto
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
        Me.gbPago = New System.Windows.Forms.GroupBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblHaber = New System.Windows.Forms.Label()
        Me.lblDebe = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPorcentaje = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHaber = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDebe = New System.Windows.Forms.TextBox()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.porcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbPago.SuspendLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbPago
        '
        Me.gbPago.Controls.Add(Me.txtDescripcion)
        Me.gbPago.Controls.Add(Me.Label15)
        Me.gbPago.Controls.Add(Me.txtCodigo)
        Me.gbPago.Controls.Add(Me.Label4)
        Me.gbPago.Controls.Add(Me.btnAgregar)
        Me.gbPago.Controls.Add(Me.lblHaber)
        Me.gbPago.Controls.Add(Me.lblDebe)
        Me.gbPago.Controls.Add(Me.Label3)
        Me.gbPago.Controls.Add(Me.txtPorcentaje)
        Me.gbPago.Controls.Add(Me.Label2)
        Me.gbPago.Controls.Add(Me.txtHaber)
        Me.gbPago.Controls.Add(Me.Label11)
        Me.gbPago.Controls.Add(Me.Label16)
        Me.gbPago.Controls.Add(Me.txtDebe)
        Me.gbPago.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPago.Location = New System.Drawing.Point(12, 12)
        Me.gbPago.Name = "gbPago"
        Me.gbPago.Size = New System.Drawing.Size(693, 152)
        Me.gbPago.TabIndex = 0
        Me.gbPago.TabStop = False
        Me.gbPago.Text = "Parametros"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDescripcion.Location = New System.Drawing.Point(259, 28)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(428, 21)
        Me.txtDescripcion.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 16)
        Me.Label15.TabIndex = 109
        Me.Label15.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtCodigo.Location = New System.Drawing.Point(68, 28)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(63, 21)
        Me.txtCodigo.TabIndex = 110
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(171, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 15)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "(%)"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(572, 111)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(115, 35)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'lblHaber
        '
        Me.lblHaber.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHaber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblHaber.Location = New System.Drawing.Point(171, 91)
        Me.lblHaber.Name = "lblHaber"
        Me.lblHaber.Size = New System.Drawing.Size(415, 23)
        Me.lblHaber.TabIndex = 107
        Me.lblHaber.Text = "[Nombre Cuenta]"
        '
        'lblDebe
        '
        Me.lblDebe.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblDebe.Location = New System.Drawing.Point(171, 65)
        Me.lblDebe.Name = "lblDebe"
        Me.lblDebe.Size = New System.Drawing.Size(415, 23)
        Me.lblDebe.TabIndex = 106
        Me.lblDebe.Text = "[Nombre Cuenta]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Porcentaje:"
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcentaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtPorcentaje.Location = New System.Drawing.Point(103, 115)
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.Size = New System.Drawing.Size(62, 21)
        Me.txtPorcentaje.TabIndex = 3
        Me.txtPorcentaje.Text = "0.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Amarre Haber:"
        '
        'txtHaber
        '
        Me.txtHaber.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHaber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtHaber.Location = New System.Drawing.Point(103, 88)
        Me.txtHaber.Name = "txtHaber"
        Me.txtHaber.Size = New System.Drawing.Size(62, 21)
        Me.txtHaber.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(171, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 16)
        Me.Label11.TabIndex = 96
        Me.Label11.Text = "Centro Costo:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(15, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 16)
        Me.Label16.TabIndex = 91
        Me.Label16.Text = "Amarre Debe:"
        '
        'txtDebe
        '
        Me.txtDebe.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDebe.Location = New System.Drawing.Point(103, 61)
        Me.txtDebe.Name = "txtDebe"
        Me.txtDebe.Size = New System.Drawing.Size(62, 21)
        Me.txtDebe.TabIndex = 1
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
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cuenta, Me.desc_cuenta, Me.debe, Me.haber, Me.porcentaje})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLista.Location = New System.Drawing.Point(12, 170)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.Size = New System.Drawing.Size(693, 198)
        Me.dgvLista.TabIndex = 150
        '
        'cuenta
        '
        Me.cuenta.DataPropertyName = "cuenta"
        Me.cuenta.HeaderText = "Cta."
        Me.cuenta.Name = "cuenta"
        Me.cuenta.ReadOnly = True
        Me.cuenta.Width = 80
        '
        'desc_cuenta
        '
        Me.desc_cuenta.DataPropertyName = "desc_cuenta"
        Me.desc_cuenta.HeaderText = "Descripción"
        Me.desc_cuenta.Name = "desc_cuenta"
        Me.desc_cuenta.ReadOnly = True
        Me.desc_cuenta.Width = 330
        '
        'debe
        '
        Me.debe.DataPropertyName = "debe"
        Me.debe.HeaderText = "Debe"
        Me.debe.Name = "debe"
        Me.debe.ReadOnly = True
        Me.debe.Width = 60
        '
        'haber
        '
        Me.haber.DataPropertyName = "haber"
        Me.haber.HeaderText = "Haber"
        Me.haber.Name = "haber"
        Me.haber.ReadOnly = True
        Me.haber.Width = 60
        '
        'porcentaje
        '
        Me.porcentaje.DataPropertyName = "porcentaje"
        Me.porcentaje.HeaderText = "(%)"
        Me.porcentaje.Name = "porcentaje"
        Me.porcentaje.ReadOnly = True
        '
        'btnFinalizar
        '
        Me.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnFinalizar.ForeColor = System.Drawing.Color.White
        Me.btnFinalizar.Location = New System.Drawing.Point(590, 374)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(115, 35)
        Me.btnFinalizar.TabIndex = 1
        Me.btnFinalizar.Text = "FINALIZAR"
        Me.btnFinalizar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Black
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(12, 374)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(115, 35)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'frmParametrosCentroCosto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(717, 421)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.dgvLista)
        Me.Controls.Add(Me.gbPago)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmParametrosCentroCosto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Creación - Parametrización - Centro de Costos"
        Me.gbPago.ResumeLayout(False)
        Me.gbPago.PerformLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbPago As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtDebe As System.Windows.Forms.TextBox
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHaber As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPorcentaje As System.Windows.Forms.TextBox
    Friend WithEvents lblHaber As System.Windows.Forms.Label
    Friend WithEvents lblDebe As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents btnFinalizar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents porcentaje As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
