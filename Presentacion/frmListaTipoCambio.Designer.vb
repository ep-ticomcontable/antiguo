<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaTipoCambio
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
        Me.BtnCargar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCargar
        '
        Me.BtnCargar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnCargar.Location = New System.Drawing.Point(257, 12)
        Me.BtnCargar.Name = "BtnCargar"
        Me.BtnCargar.Size = New System.Drawing.Size(117, 43)
        Me.BtnCargar.TabIndex = 1
        Me.BtnCargar.Text = "Cargar"
        Me.BtnCargar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Año:"
        '
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(47, 24)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(73, 20)
        Me.txtAnio.TabIndex = 4
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(172, 24)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(73, 20)
        Me.txtMes.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mes:"
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.Compra, Me.Venta})
        Me.dgvLista.Location = New System.Drawing.Point(12, 61)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.Size = New System.Drawing.Size(372, 402)
        Me.dgvLista.TabIndex = 7
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "fecha"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Compra
        '
        Me.Compra.DataPropertyName = "compra"
        Me.Compra.HeaderText = "Compra"
        Me.Compra.Name = "Compra"
        Me.Compra.ReadOnly = True
        '
        'Venta
        '
        Me.Venta.DataPropertyName = "venta"
        Me.Venta.HeaderText = "Venta"
        Me.Venta.Name = "Venta"
        Me.Venta.ReadOnly = True
        '
        'frmListaTipoCambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 481)
        Me.Controls.Add(Me.dgvLista)
        Me.Controls.Add(Me.txtMes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAnio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCargar)
        Me.Name = "frmListaTipoCambio"
        Me.Text = "LISTA DE TIPO DE CAMBIO "
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCargar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAnio As System.Windows.Forms.TextBox
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Compra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Venta As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
