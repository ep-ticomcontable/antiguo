<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepuracion
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
        Me.dgvCab = New System.Windows.Forms.DataGridView()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.marcar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.dgvCab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCab
        '
        Me.dgvCab.AllowUserToAddRows = False
        Me.dgvCab.AllowUserToDeleteRows = False
        Me.dgvCab.AllowUserToOrderColumns = True
        Me.dgvCab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCab.Location = New System.Drawing.Point(12, 12)
        Me.dgvCab.Name = "dgvCab"
        Me.dgvCab.ReadOnly = True
        Me.dgvCab.Size = New System.Drawing.Size(964, 226)
        Me.dgvCab.TabIndex = 0
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToOrderColumns = True
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.marcar})
        Me.dgvLista.Location = New System.Drawing.Point(12, 269)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.Size = New System.Drawing.Size(964, 303)
        Me.dgvLista.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Registros que se repiten..."
        '
        'marcar
        '
        Me.marcar.DataPropertyName = "0"
        Me.marcar.HeaderText = "Marcar"
        Me.marcar.Name = "marcar"
        Me.marcar.Width = 50
        '
        'frmDepuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 584)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvLista)
        Me.Controls.Add(Me.dgvCab)
        Me.Name = "frmDepuracion"
        Me.Text = "Lista de clientes para depurar"
        CType(Me.dgvCab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCab As System.Windows.Forms.DataGridView
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents marcar As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
