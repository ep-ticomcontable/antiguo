<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccionesVentas
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
        Me.btnDetalle = New System.Windows.Forms.Button()
        Me.btnPagos = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnDebito = New System.Windows.Forms.Button()
        Me.btnCredito = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCanje = New System.Windows.Forms.Button()
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
        Me.Label7.Size = New System.Drawing.Size(256, 50)
        Me.Label7.TabIndex = 151
        Me.Label7.Text = "ELIJA UN PROCESO"
        '
        'lblComprobante
        '
        Me.lblComprobante.AutoSize = True
        Me.lblComprobante.BackColor = System.Drawing.Color.Transparent
        Me.lblComprobante.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComprobante.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblComprobante.Location = New System.Drawing.Point(165, 50)
        Me.lblComprobante.Name = "lblComprobante"
        Me.lblComprobante.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblComprobante.Size = New System.Drawing.Size(88, 19)
        Me.lblComprobante.TabIndex = 153
        Me.lblComprobante.Text = "0000-6666"
        '
        'Cliente
        '
        Me.Cliente.AutoSize = True
        Me.Cliente.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Cliente.Location = New System.Drawing.Point(12, 53)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(155, 16)
        Me.Cliente.TabIndex = 154
        Me.Cliente.Text = "Comprobante de Compra:"
        '
        'btnDetalle
        '
        Me.btnDetalle.BackColor = System.Drawing.Color.SteelBlue
        Me.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetalle.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalle.ForeColor = System.Drawing.Color.White
        Me.btnDetalle.Image = Global.Presentacion.My.Resources.Resources.ver_detalle
        Me.btnDetalle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDetalle.Location = New System.Drawing.Point(71, 80)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(110, 65)
        Me.btnDetalle.TabIndex = 126
        Me.btnDetalle.Text = "VER DETALLE"
        Me.btnDetalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDetalle.UseVisualStyleBackColor = False
        '
        'btnPagos
        '
        Me.btnPagos.BackColor = System.Drawing.Color.Green
        Me.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPagos.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagos.ForeColor = System.Drawing.Color.White
        Me.btnPagos.Image = Global.Presentacion.My.Resources.Resources.pago
        Me.btnPagos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPagos.Location = New System.Drawing.Point(303, 80)
        Me.btnPagos.Name = "btnPagos"
        Me.btnPagos.Size = New System.Drawing.Size(110, 65)
        Me.btnPagos.TabIndex = 125
        Me.btnPagos.Text = "ABONO/PAGO"
        Me.btnPagos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPagos.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Image = Global.Presentacion.My.Resources.Resources.editar
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(187, 80)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(110, 65)
        Me.btnModificar.TabIndex = 124
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnDebito
        '
        Me.btnDebito.BackColor = System.Drawing.Color.Gray
        Me.btnDebito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDebito.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDebito.ForeColor = System.Drawing.Color.White
        Me.btnDebito.Image = Global.Presentacion.My.Resources.Resources.nota_debito1
        Me.btnDebito.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDebito.Location = New System.Drawing.Point(244, 159)
        Me.btnDebito.Name = "btnDebito"
        Me.btnDebito.Size = New System.Drawing.Size(110, 80)
        Me.btnDebito.TabIndex = 123
        Me.btnDebito.Text = "NOTA DE DÉBITO"
        Me.btnDebito.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDebito.UseVisualStyleBackColor = False
        '
        'btnCredito
        '
        Me.btnCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCredito.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredito.ForeColor = System.Drawing.Color.White
        Me.btnCredito.Image = Global.Presentacion.My.Resources.Resources.nota_credito1
        Me.btnCredito.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCredito.Location = New System.Drawing.Point(128, 159)
        Me.btnCredito.Name = "btnCredito"
        Me.btnCredito.Size = New System.Drawing.Size(110, 80)
        Me.btnCredito.TabIndex = 122
        Me.btnCredito.Text = "NOTA DE CRÉDITO"
        Me.btnCredito.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCredito.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Red
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Image = Global.Presentacion.My.Resources.Resources.eliminar
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(362, 159)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(110, 80)
        Me.btnEliminar.TabIndex = 156
        Me.btnEliminar.Text = "ELIMINAR COMPROBANTE"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnCanje
        '
        Me.btnCanje.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCanje.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCanje.ForeColor = System.Drawing.Color.White
        Me.btnCanje.Image = Global.Presentacion.My.Resources.Resources.nota_credito1
        Me.btnCanje.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCanje.Location = New System.Drawing.Point(12, 159)
        Me.btnCanje.Name = "btnCanje"
        Me.btnCanje.Size = New System.Drawing.Size(110, 80)
        Me.btnCanje.TabIndex = 157
        Me.btnCanje.Text = "CANJEAR POR LETRA"
        Me.btnCanje.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCanje.UseVisualStyleBackColor = False
        '
        'frmAccionesCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(484, 251)
        Me.Controls.Add(Me.btnCanje)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Cliente)
        Me.Controls.Add(Me.lblComprobante)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnDetalle)
        Me.Controls.Add(Me.btnPagos)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnDebito)
        Me.Controls.Add(Me.btnCredito)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmAccionesCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ejecutar un proceso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDetalle As System.Windows.Forms.Button
    Friend WithEvents btnPagos As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnDebito As System.Windows.Forms.Button
    Friend WithEvents btnCredito As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblComprobante As System.Windows.Forms.Label
    Friend WithEvents Cliente As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnCanje As System.Windows.Forms.Button
End Class
