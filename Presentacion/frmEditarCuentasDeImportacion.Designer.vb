<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarCuentasDeImportacion
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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtDiferencia = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtTotalHaber = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtTotalDebe = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.dgvAsientos = New System.Windows.Forms.DataGridView()
        Me.num_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvAsientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtDiferencia)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.txtTotalHaber)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.txtTotalDebe)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.dgvAsientos)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(629, 298)
        Me.GroupBox5.TabIndex = 216
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "ASIENTOS DEL COMPROBANTE"
        '
        'txtDiferencia
        '
        Me.txtDiferencia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDiferencia.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferencia.ForeColor = System.Drawing.Color.Black
        Me.txtDiferencia.Location = New System.Drawing.Point(540, 143)
        Me.txtDiferencia.Multiline = True
        Me.txtDiferencia.Name = "txtDiferencia"
        Me.txtDiferencia.Size = New System.Drawing.Size(82, 20)
        Me.txtDiferencia.TabIndex = 349
        Me.txtDiferencia.Text = "0.00"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(537, 124)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(65, 16)
        Me.Label26.TabIndex = 348
        Me.Label26.Text = "Diferencia:"
        '
        'txtTotalHaber
        '
        Me.txtTotalHaber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalHaber.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalHaber.ForeColor = System.Drawing.Color.Black
        Me.txtTotalHaber.Location = New System.Drawing.Point(540, 101)
        Me.txtTotalHaber.Multiline = True
        Me.txtTotalHaber.Name = "txtTotalHaber"
        Me.txtTotalHaber.Size = New System.Drawing.Size(82, 20)
        Me.txtTotalHaber.TabIndex = 347
        Me.txtTotalHaber.Text = "0.00"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(537, 82)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(74, 16)
        Me.Label25.TabIndex = 346
        Me.Label25.Text = "Total Haber:"
        '
        'txtTotalDebe
        '
        Me.txtTotalDebe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalDebe.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDebe.ForeColor = System.Drawing.Color.Black
        Me.txtTotalDebe.Location = New System.Drawing.Point(540, 59)
        Me.txtTotalDebe.Multiline = True
        Me.txtTotalDebe.Name = "txtTotalDebe"
        Me.txtTotalDebe.Size = New System.Drawing.Size(82, 20)
        Me.txtTotalDebe.TabIndex = 345
        Me.txtTotalDebe.Text = "0.00"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(537, 40)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(70, 16)
        Me.Label24.TabIndex = 344
        Me.Label24.Text = "Total Debe:"
        '
        'dgvAsientos
        '
        Me.dgvAsientos.AllowUserToAddRows = False
        Me.dgvAsientos.BackgroundColor = System.Drawing.Color.White
        Me.dgvAsientos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAsientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAsientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAsientos.ColumnHeadersHeight = 30
        Me.dgvAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAsientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num_cuenta, Me.desc_cuenta, Me.debe, Me.haber})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAsientos.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvAsientos.Location = New System.Drawing.Point(5, 20)
        Me.dgvAsientos.Name = "dgvAsientos"
        Me.dgvAsientos.RowHeadersVisible = False
        Me.dgvAsientos.Size = New System.Drawing.Size(529, 272)
        Me.dgvAsientos.TabIndex = 274
        '
        'num_cuenta
        '
        Me.num_cuenta.DataPropertyName = "num_cuenta"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.num_cuenta.DefaultCellStyle = DataGridViewCellStyle2
        Me.num_cuenta.HeaderText = "N° CTA."
        Me.num_cuenta.Name = "num_cuenta"
        Me.num_cuenta.Width = 65
        '
        'desc_cuenta
        '
        Me.desc_cuenta.DataPropertyName = "desc_cuenta"
        Me.desc_cuenta.HeaderText = "DESCRIPCIÓN"
        Me.desc_cuenta.Name = "desc_cuenta"
        Me.desc_cuenta.Width = 286
        '
        'debe
        '
        Me.debe.DataPropertyName = "debe"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.debe.DefaultCellStyle = DataGridViewCellStyle3
        Me.debe.HeaderText = "DEBE"
        Me.debe.Name = "debe"
        Me.debe.Width = 80
        '
        'haber
        '
        Me.haber.DataPropertyName = "haber"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.haber.DefaultCellStyle = DataGridViewCellStyle4
        Me.haber.HeaderText = "HABER"
        Me.haber.Name = "haber"
        Me.haber.Width = 80
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 25.0!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(5, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(233, 40)
        Me.lblTitulo.TabIndex = 235
        Me.lblTitulo.Text = "VER CUENTAS"
        '
        'frmEditarCuentasDeImportacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(654, 361)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.GroupBox5)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmEditarCuentasDeImportacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DISTRIBUCION"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgvAsientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDiferencia As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtTotalHaber As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtTotalDebe As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents dgvAsientos As System.Windows.Forms.DataGridView
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents num_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents haber As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
