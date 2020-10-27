<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pbCompras = New System.Windows.Forms.PictureBox()
        CType(Me.pbCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(369, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 30)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Compras"
        '
        'pbCompras
        '
        Me.pbCompras.BackColor = System.Drawing.Color.Transparent
        Me.pbCompras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbCompras.Image = Global.Presentacion.My.Resources.Resources.busqueda
        Me.pbCompras.Location = New System.Drawing.Point(350, 82)
        Me.pbCompras.Name = "pbCompras"
        Me.pbCompras.Size = New System.Drawing.Size(160, 159)
        Me.pbCompras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCompras.TabIndex = 87
        Me.pbCompras.TabStop = False
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.Presentacion.My.Resources.Resources.fonod_inicio_sesion
        Me.ClientSize = New System.Drawing.Size(861, 357)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pbCompras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pbCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pbCompras As System.Windows.Forms.PictureBox
End Class
