<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaVentas
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
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.dtDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNuevaVenta = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnGenerarTxt = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToOrderColumns = True
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Location = New System.Drawing.Point(12, 53)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.Size = New System.Drawing.Size(573, 246)
        Me.dgvLista.TabIndex = 0
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnConsultar.ForeColor = System.Drawing.Color.White
        Me.btnConsultar.Location = New System.Drawing.Point(324, 9)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(99, 35)
        Me.btnConsultar.TabIndex = 56
        Me.btnConsultar.Text = "CONSULTAR"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'dtDesde
        '
        Me.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDesde.Location = New System.Drawing.Point(66, 17)
        Me.dtDesde.Name = "dtDesde"
        Me.dtDesde.Size = New System.Drawing.Size(96, 20)
        Me.dtDesde.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label2.Location = New System.Drawing.Point(12, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Desde:"
        '
        'dtHasta
        '
        Me.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtHasta.Location = New System.Drawing.Point(222, 17)
        Me.dtHasta.Name = "dtHasta"
        Me.dtHasta.Size = New System.Drawing.Size(96, 20)
        Me.dtHasta.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label1.Location = New System.Drawing.Point(168, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Hasta:"
        '
        'btnNuevaVenta
        '
        Me.btnNuevaVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevaVenta.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnNuevaVenta.ForeColor = System.Drawing.Color.White
        Me.btnNuevaVenta.Location = New System.Drawing.Point(591, 146)
        Me.btnNuevaVenta.Name = "btnNuevaVenta"
        Me.btnNuevaVenta.Size = New System.Drawing.Size(219, 35)
        Me.btnNuevaVenta.TabIndex = 59
        Me.btnNuevaVenta.Text = "COMPROBANTE DE VENTA"
        Me.btnNuevaVenta.UseVisualStyleBackColor = False
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnGenerar.ForeColor = System.Drawing.Color.White
        Me.btnGenerar.Location = New System.Drawing.Point(591, 53)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(154, 35)
        Me.btnGenerar.TabIndex = 60
        Me.btnGenerar.Text = "EXCEL DE VENTAS"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'btnGenerarTxt
        '
        Me.btnGenerarTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnGenerarTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerarTxt.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnGenerarTxt.ForeColor = System.Drawing.Color.White
        Me.btnGenerarTxt.Location = New System.Drawing.Point(591, 94)
        Me.btnGenerarTxt.Name = "btnGenerarTxt"
        Me.btnGenerarTxt.Size = New System.Drawing.Size(154, 35)
        Me.btnGenerarTxt.TabIndex = 61
        Me.btnGenerarTxt.Text = "GENERAR TXT"
        Me.btnGenerarTxt.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(591, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(219, 35)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "COMPROBANTE DE COMPRA"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmListaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 311)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnGenerarTxt)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.btnNuevaVenta)
        Me.Controls.Add(Me.dtHasta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.dtDesde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvLista)
        Me.Name = "frmListaVentas"
        Me.Text = "REGISTRO DE VENTAS"
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents dtDesde As System.Windows.Forms.DateTimePicker
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnNuevaVenta As System.Windows.Forms.Button
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents btnGenerarTxt As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
