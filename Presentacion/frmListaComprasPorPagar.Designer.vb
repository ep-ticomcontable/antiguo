<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaComprasPorPagar
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
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.Cliente = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.dtHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.dtDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.btnCanjeLetra = New System.Windows.Forms.Button()
        Me.btnRealizarAbono = New System.Windows.Forms.Button()
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
        Me.dgvLista.Location = New System.Drawing.Point(12, 95)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.Size = New System.Drawing.Size(612, 258)
        Me.dgvLista.TabIndex = 0
        '
        'txtDato
        '
        Me.txtDato.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDato.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDato.Location = New System.Drawing.Point(82, 49)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(216, 21)
        Me.txtDato.TabIndex = 103
        '
        'Cliente
        '
        Me.Cliente.AutoSize = True
        Me.Cliente.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Cliente.Location = New System.Drawing.Point(9, 23)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(67, 16)
        Me.Cliente.TabIndex = 102
        Me.Cliente.Text = "Buscar por:"
        '
        'cboTipo
        '
        Me.cboTipo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"soles", "dolares"})
        Me.cboTipo.Location = New System.Drawing.Point(82, 20)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(137, 23)
        Me.cboTipo.TabIndex = 106
        '
        'dtHasta
        '
        Me.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtHasta.Location = New System.Drawing.Point(423, 50)
        Me.dtHasta.Name = "dtHasta"
        Me.dtHasta.Size = New System.Drawing.Size(96, 20)
        Me.dtHasta.TabIndex = 110
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label1.Location = New System.Drawing.Point(369, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Hasta:"
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnConsultar.ForeColor = System.Drawing.Color.White
        Me.btnConsultar.Location = New System.Drawing.Point(525, 26)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(99, 35)
        Me.btnConsultar.TabIndex = 109
        Me.btnConsultar.Text = "CONSULTAR"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'dtDesde
        '
        Me.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDesde.Location = New System.Drawing.Point(423, 18)
        Me.dtDesde.Name = "dtDesde"
        Me.dtDesde.Size = New System.Drawing.Size(96, 20)
        Me.dtDesde.TabIndex = 107
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label2.Location = New System.Drawing.Point(369, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Desde:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label3.Location = New System.Drawing.Point(38, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 16)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Dato:"
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(12, 359)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(83, 17)
        Me.chkTodos.TabIndex = 115
        Me.chkTodos.Text = "Marcar todo"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'btnCanjeLetra
        '
        Me.btnCanjeLetra.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCanjeLetra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCanjeLetra.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnCanjeLetra.ForeColor = System.Drawing.Color.White
        Me.btnCanjeLetra.Location = New System.Drawing.Point(271, 359)
        Me.btnCanjeLetra.Name = "btnCanjeLetra"
        Me.btnCanjeLetra.Size = New System.Drawing.Size(178, 35)
        Me.btnCanjeLetra.TabIndex = 113
        Me.btnCanjeLetra.Text = "CANJEAR CON LETRA"
        Me.btnCanjeLetra.UseVisualStyleBackColor = False
        '
        'btnRealizarAbono
        '
        Me.btnRealizarAbono.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnRealizarAbono.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRealizarAbono.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnRealizarAbono.ForeColor = System.Drawing.Color.White
        Me.btnRealizarAbono.Location = New System.Drawing.Point(466, 359)
        Me.btnRealizarAbono.Name = "btnRealizarAbono"
        Me.btnRealizarAbono.Size = New System.Drawing.Size(158, 35)
        Me.btnRealizarAbono.TabIndex = 116
        Me.btnRealizarAbono.Text = "REALIZAR ABONOS"
        Me.btnRealizarAbono.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(101, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 35)
        Me.Button1.TabIndex = 117
        Me.Button1.Text = "CANJEAR CON LETRA"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmListaComprasPorPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 407)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnRealizarAbono)
        Me.Controls.Add(Me.chkTodos)
        Me.Controls.Add(Me.btnCanjeLetra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtHasta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.dtDesde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.txtDato)
        Me.Controls.Add(Me.Cliente)
        Me.Controls.Add(Me.dgvLista)
        Me.Name = "frmListaComprasPorPagar"
        Me.Text = "Lista de Deudas de Compras por Pagar"
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents txtDato As System.Windows.Forms.TextBox
    Friend WithEvents Cliente As System.Windows.Forms.Label
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents dtHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents dtDesde As System.Windows.Forms.DateTimePicker
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents btnCanjeLetra As System.Windows.Forms.Button
    Friend WithEvents btnRealizarAbono As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
