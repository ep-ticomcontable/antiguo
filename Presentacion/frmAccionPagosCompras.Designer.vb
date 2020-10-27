<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccionPagosCompras
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblComprobante = New System.Windows.Forms.Label()
        Me.Cliente = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDeuda = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblFP = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRuc = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblProv = New System.Windows.Forms.TextBox()
        Me.pbCerrar = New System.Windows.Forms.PictureBox()
        Me.btnDetalle = New System.Windows.Forms.Button()
        Me.btnAbonar = New System.Windows.Forms.Button()
        Me.btnPagarImpuesto = New System.Windows.Forms.Button()
        CType(Me.pbCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Location = New System.Drawing.Point(-4, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(10)
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(262, 50)
        Me.Label7.TabIndex = 151
        Me.Label7.Text = "PAGOS - COMPRAS"
        '
        'lblComprobante
        '
        Me.lblComprobante.AutoSize = True
        Me.lblComprobante.BackColor = System.Drawing.Color.Transparent
        Me.lblComprobante.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblComprobante.ForeColor = System.Drawing.Color.Black
        Me.lblComprobante.Location = New System.Drawing.Point(12, 69)
        Me.lblComprobante.Name = "lblComprobante"
        Me.lblComprobante.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblComprobante.Size = New System.Drawing.Size(78, 17)
        Me.lblComprobante.TabIndex = 153
        Me.lblComprobante.Text = "0000-6666"
        '
        'Cliente
        '
        Me.Cliente.AutoSize = True
        Me.Cliente.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Cliente.Location = New System.Drawing.Point(9, 53)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(104, 16)
        Me.Cliente.TabIndex = 154
        Me.Cliente.Text = "N° Comprobante:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label1.Location = New System.Drawing.Point(345, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 155
        Me.Label1.Text = "Total Deuda:"
        '
        'lblDeuda
        '
        Me.lblDeuda.BackColor = System.Drawing.Color.Transparent
        Me.lblDeuda.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblDeuda.ForeColor = System.Drawing.Color.Black
        Me.lblDeuda.Location = New System.Drawing.Point(348, 152)
        Me.lblDeuda.Name = "lblDeuda"
        Me.lblDeuda.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblDeuda.Size = New System.Drawing.Size(104, 52)
        Me.lblDeuda.TabIndex = 156
        Me.lblDeuda.Text = "0.00"
        Me.lblDeuda.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(212, 108)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTotal.Size = New System.Drawing.Size(84, 17)
        Me.lblTotal.TabIndex = 158
        Me.lblTotal.Text = "20/11/2016"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label4.Location = New System.Drawing.Point(209, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 16)
        Me.Label4.TabIndex = 157
        Me.Label4.Text = "Importe Total:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label5.Location = New System.Drawing.Point(345, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 159
        Me.Label5.Text = "Fec. Pago:"
        '
        'lblFP
        '
        Me.lblFP.AutoSize = True
        Me.lblFP.BackColor = System.Drawing.Color.Transparent
        Me.lblFP.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFP.ForeColor = System.Drawing.Color.Red
        Me.lblFP.Location = New System.Drawing.Point(348, 108)
        Me.lblFP.Name = "lblFP"
        Me.lblFP.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblFP.Size = New System.Drawing.Size(84, 17)
        Me.lblFP.TabIndex = 160
        Me.lblFP.Text = "20/11/2016"
        Me.lblFP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label2.Location = New System.Drawing.Point(9, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 164
        Me.Label2.Text = "DNI/RUC:"
        '
        'lblRuc
        '
        Me.lblRuc.AutoSize = True
        Me.lblRuc.BackColor = System.Drawing.Color.Transparent
        Me.lblRuc.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblRuc.ForeColor = System.Drawing.Color.Black
        Me.lblRuc.Location = New System.Drawing.Point(12, 108)
        Me.lblRuc.Name = "lblRuc"
        Me.lblRuc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblRuc.Size = New System.Drawing.Size(96, 17)
        Me.lblRuc.TabIndex = 163
        Me.lblRuc.Text = "00000000000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label6.Location = New System.Drawing.Point(124, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 166
        Me.Label6.Text = "Proveedor:"
        '
        'lblProv
        '
        Me.lblProv.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.lblProv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblProv.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProv.Location = New System.Drawing.Point(127, 68)
        Me.lblProv.Multiline = True
        Me.lblProv.Name = "lblProv"
        Me.lblProv.ReadOnly = True
        Me.lblProv.Size = New System.Drawing.Size(321, 20)
        Me.lblProv.TabIndex = 167
        Me.lblProv.Text = "XXXXX"
        '
        'pbCerrar
        '
        Me.pbCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbCerrar.Image = Global.Presentacion.My.Resources.Resources.close_256
        Me.pbCerrar.Location = New System.Drawing.Point(417, 12)
        Me.pbCerrar.Name = "pbCerrar"
        Me.pbCerrar.Size = New System.Drawing.Size(35, 35)
        Me.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCerrar.TabIndex = 161
        Me.pbCerrar.TabStop = False
        '
        'btnDetalle
        '
        Me.btnDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnDetalle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetalle.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalle.ForeColor = System.Drawing.Color.White
        Me.btnDetalle.Image = Global.Presentacion.My.Resources.Resources.ver_detalle
        Me.btnDetalle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDetalle.Location = New System.Drawing.Point(12, 139)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(101, 65)
        Me.btnDetalle.TabIndex = 126
        Me.btnDetalle.Text = "VER ABONOS"
        Me.btnDetalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDetalle.UseVisualStyleBackColor = False
        '
        'btnAbonar
        '
        Me.btnAbonar.BackColor = System.Drawing.Color.Green
        Me.btnAbonar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbonar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbonar.ForeColor = System.Drawing.Color.White
        Me.btnAbonar.Image = Global.Presentacion.My.Resources.Resources.pago
        Me.btnAbonar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAbonar.Location = New System.Drawing.Point(119, 139)
        Me.btnAbonar.Name = "btnAbonar"
        Me.btnAbonar.Size = New System.Drawing.Size(87, 65)
        Me.btnAbonar.TabIndex = 125
        Me.btnAbonar.Text = "PAGAR"
        Me.btnAbonar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAbonar.UseVisualStyleBackColor = False
        '
        'btnPagarImpuesto
        '
        Me.btnPagarImpuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPagarImpuesto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPagarImpuesto.Enabled = False
        Me.btnPagarImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPagarImpuesto.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagarImpuesto.ForeColor = System.Drawing.Color.White
        Me.btnPagarImpuesto.Image = Global.Presentacion.My.Resources.Resources.pago
        Me.btnPagarImpuesto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPagarImpuesto.Location = New System.Drawing.Point(212, 139)
        Me.btnPagarImpuesto.Name = "btnPagarImpuesto"
        Me.btnPagarImpuesto.Size = New System.Drawing.Size(130, 65)
        Me.btnPagarImpuesto.TabIndex = 168
        Me.btnPagarImpuesto.Text = "PAGAR RETENCIÓN"
        Me.btnPagarImpuesto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPagarImpuesto.UseVisualStyleBackColor = False
        '
        'frmAccionPagosCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(464, 220)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPagarImpuesto)
        Me.Controls.Add(Me.lblProv)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblRuc)
        Me.Controls.Add(Me.pbCerrar)
        Me.Controls.Add(Me.lblFP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDeuda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cliente)
        Me.Controls.Add(Me.lblComprobante)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnDetalle)
        Me.Controls.Add(Me.btnAbonar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmAccionPagosCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagos"
        CType(Me.pbCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDetalle As System.Windows.Forms.Button
    Friend WithEvents btnAbonar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblComprobante As System.Windows.Forms.Label
    Friend WithEvents Cliente As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDeuda As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblFP As System.Windows.Forms.Label
    Friend WithEvents pbCerrar As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblRuc As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblProv As System.Windows.Forms.TextBox
    Friend WithEvents btnPagarImpuesto As System.Windows.Forms.Button
End Class
