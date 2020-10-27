<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExcel
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
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(472, 27)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(157, 23)
        Me.btnGenerar.TabIndex = 0
        Me.btnGenerar.Text = "Generar Excel Libro Diario"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'dgvLista
        '
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Location = New System.Drawing.Point(12, 12)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.Size = New System.Drawing.Size(454, 326)
        Me.dgvLista.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(472, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(231, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Generar Excel Libro Comprobante Compras"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(472, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(231, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Generar Excel Libro Comprobante Ventas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 379)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvLista)
        Me.Controls.Add(Me.btnGenerar)
        Me.Name = "frmExcel"
        Me.Text = "Generar Excel"
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
