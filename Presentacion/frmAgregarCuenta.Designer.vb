<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarCuenta
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
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.btnCuenta = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.txtDebe = New System.Windows.Forms.TextBox()
        Me.cboCentroCosto = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboDH = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCuenta
        '
        Me.lblCuenta.BackColor = System.Drawing.Color.NavajoWhite
        Me.lblCuenta.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.lblCuenta.Location = New System.Drawing.Point(124, 24)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblCuenta.Size = New System.Drawing.Size(419, 30)
        Me.lblCuenta.TabIndex = 243
        Me.lblCuenta.Text = "[Cuenta]"
        Me.lblCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCuenta
        '
        Me.btnCuenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCuenta.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnCuenta.ForeColor = System.Drawing.Color.White
        Me.btnCuenta.Location = New System.Drawing.Point(79, 24)
        Me.btnCuenta.Name = "btnCuenta"
        Me.btnCuenta.Size = New System.Drawing.Size(39, 30)
        Me.btnCuenta.TabIndex = 237
        Me.btnCuenta.Text = "..."
        Me.btnCuenta.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(11, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 19)
        Me.Label2.TabIndex = 242
        Me.Label2.Text = "Monto:"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(413, 112)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(130, 30)
        Me.btnAgregar.TabIndex = 239
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(277, 112)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(130, 30)
        Me.btnCancelar.TabIndex = 240
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 241
        Me.Label1.Text = "Cuenta:"
        '
        'txtCuenta
        '
        Me.txtCuenta.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.Location = New System.Drawing.Point(15, 29)
        Me.txtCuenta.MaxLength = 1000
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(58, 22)
        Me.txtCuenta.TabIndex = 236
        '
        'txtDebe
        '
        Me.txtDebe.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebe.Location = New System.Drawing.Point(15, 84)
        Me.txtDebe.MaxLength = 1000
        Me.txtDebe.Name = "txtDebe"
        Me.txtDebe.Size = New System.Drawing.Size(103, 22)
        Me.txtDebe.TabIndex = 244
        Me.txtDebe.Text = "0.00"
        Me.txtDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboCentroCosto
        '
        Me.cboCentroCosto.Enabled = False
        Me.cboCentroCosto.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.cboCentroCosto.FormattingEnabled = True
        Me.cboCentroCosto.Location = New System.Drawing.Point(235, 81)
        Me.cboCentroCosto.Name = "cboCentroCosto"
        Me.cboCentroCosto.Size = New System.Drawing.Size(308, 25)
        Me.cboCentroCosto.TabIndex = 277
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(232, 65)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(98, 16)
        Me.Label22.TabIndex = 278
        Me.Label22.Text = "Centro de costo:"
        '
        'cboDH
        '
        Me.cboDH.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.cboDH.FormattingEnabled = True
        Me.cboDH.Location = New System.Drawing.Point(126, 81)
        Me.cboDH.Name = "cboDH"
        Me.cboDH.Size = New System.Drawing.Size(103, 25)
        Me.cboDH.TabIndex = 296
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(123, 65)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(32, 16)
        Me.Label24.TabIndex = 297
        Me.Label24.Text = "D/H:"
        '
        'frmAgregarCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 154)
        Me.Controls.Add(Me.cboDH)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.cboCentroCosto)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtDebe)
        Me.Controls.Add(Me.lblCuenta)
        Me.Controls.Add(Me.btnCuenta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCuenta)
        Me.Name = "frmAgregarCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Cuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCuenta As System.Windows.Forms.Label
    Friend WithEvents btnCuenta As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtDebe As System.Windows.Forms.TextBox
    Friend WithEvents cboCentroCosto As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cboDH As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
End Class
