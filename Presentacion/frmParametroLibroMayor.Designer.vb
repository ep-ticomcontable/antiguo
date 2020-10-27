<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametroLibroMayor
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.txtDigitos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHojaTrabajo = New System.Windows.Forms.Button()
        Me.btnVerLibroMayor = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSD = New System.Windows.Forms.Label()
        Me.lblSH = New System.Windows.Forms.Label()
        Me.btnGenerarPLE = New System.Windows.Forms.Button()
        Me.btnGeneral = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.cuenta_padre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.suma_debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.suma_haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnParametrizacion = New System.Windows.Forms.Button()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(169, 62)
        Me.btnEnviar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(118, 30)
        Me.btnEnviar.TabIndex = 0
        Me.btnEnviar.Text = "Mostrar registros"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'txtDigitos
        '
        Me.txtDigitos.Location = New System.Drawing.Point(98, 66)
        Me.txtDigitos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDigitos.MaxLength = 5
        Me.txtDigitos.Name = "txtDigitos"
        Me.txtDigitos.Size = New System.Drawing.Size(65, 22)
        Me.txtDigitos.TabIndex = 2
        Me.txtDigitos.Text = "3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "# de dígitos:"
        '
        'btnHojaTrabajo
        '
        Me.btnHojaTrabajo.Location = New System.Drawing.Point(323, 382)
        Me.btnHojaTrabajo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnHojaTrabajo.Name = "btnHojaTrabajo"
        Me.btnHojaTrabajo.Size = New System.Drawing.Size(113, 30)
        Me.btnHojaTrabajo.TabIndex = 4
        Me.btnHojaTrabajo.Text = "Hoja de Trabajo"
        Me.btnHojaTrabajo.UseVisualStyleBackColor = True
        '
        'btnVerLibroMayor
        '
        Me.btnVerLibroMayor.Location = New System.Drawing.Point(225, 382)
        Me.btnVerLibroMayor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnVerLibroMayor.Name = "btnVerLibroMayor"
        Me.btnVerLibroMayor.Size = New System.Drawing.Size(92, 30)
        Me.btnVerLibroMayor.TabIndex = 5
        Me.btnVerLibroMayor.Text = "Libro Mayor"
        Me.btnVerLibroMayor.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(606, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Suma Debe:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(606, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Suma Haber:"
        '
        'lblSD
        '
        Me.lblSD.AutoSize = True
        Me.lblSD.ForeColor = System.Drawing.Color.Blue
        Me.lblSD.Location = New System.Drawing.Point(606, 125)
        Me.lblSD.Name = "lblSD"
        Me.lblSD.Size = New System.Drawing.Size(80, 17)
        Me.lblSD.TabIndex = 10
        Me.lblSD.Text = "Suma Debe:"
        '
        'lblSH
        '
        Me.lblSH.AutoSize = True
        Me.lblSH.ForeColor = System.Drawing.Color.Blue
        Me.lblSH.Location = New System.Drawing.Point(606, 176)
        Me.lblSH.Name = "lblSH"
        Me.lblSH.Size = New System.Drawing.Size(80, 17)
        Me.lblSH.TabIndex = 11
        Me.lblSH.Text = "Suma Debe:"
        '
        'btnGenerarPLE
        '
        Me.btnGenerarPLE.Location = New System.Drawing.Point(146, 382)
        Me.btnGenerarPLE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGenerarPLE.Name = "btnGenerarPLE"
        Me.btnGenerarPLE.Size = New System.Drawing.Size(73, 30)
        Me.btnGenerarPLE.TabIndex = 7
        Me.btnGenerarPLE.Text = "Lista PLE"
        Me.btnGenerarPLE.UseVisualStyleBackColor = True
        '
        'btnGeneral
        '
        Me.btnGeneral.Location = New System.Drawing.Point(12, 382)
        Me.btnGeneral.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGeneral.Name = "btnGeneral"
        Me.btnGeneral.Size = New System.Drawing.Size(128, 30)
        Me.btnGeneral.TabIndex = 12
        Me.btnGeneral.Text = "BALANCE GENERAL"
        Me.btnGeneral.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(599, 327)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 47)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Resumen Cierre"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(599, 252)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 67)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "REALIZAR CIERRES"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 25.0!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(5, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(550, 40)
        Me.lblTitulo.TabIndex = 212
        Me.lblTitulo.Text = "RESUMEN CUENTAS LIBRO DIARIO"
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToOrderColumns = True
        Me.dgvLista.AllowUserToResizeRows = False
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        Me.dgvLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLista.ColumnHeadersHeight = 25
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cuenta_padre, Me.nombre, Me.suma_debe, Me.suma_haber})
        Me.dgvLista.EnableHeadersVisualStyles = False
        Me.dgvLista.Location = New System.Drawing.Point(15, 99)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.RowHeadersVisible = False
        Me.dgvLista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvLista.Size = New System.Drawing.Size(578, 276)
        Me.dgvLista.TabIndex = 213
        '
        'cuenta_padre
        '
        Me.cuenta_padre.DataPropertyName = "cuenta_padre"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.cuenta_padre.DefaultCellStyle = DataGridViewCellStyle2
        Me.cuenta_padre.HeaderText = "CTA"
        Me.cuenta_padre.Name = "cuenta_padre"
        Me.cuenta_padre.ReadOnly = True
        Me.cuenta_padre.Width = 70
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.nombre.DefaultCellStyle = DataGridViewCellStyle3
        Me.nombre.HeaderText = "DESCRIPCIÓN"
        Me.nombre.Name = "nombre"
        Me.nombre.Width = 286
        '
        'suma_debe
        '
        Me.suma_debe.DataPropertyName = "suma_debe"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.suma_debe.DefaultCellStyle = DataGridViewCellStyle4
        Me.suma_debe.HeaderText = "DEBE"
        Me.suma_debe.Name = "suma_debe"
        '
        'suma_haber
        '
        Me.suma_haber.DataPropertyName = "suma_haber"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.suma_haber.DefaultCellStyle = DataGridViewCellStyle5
        Me.suma_haber.HeaderText = "HABER"
        Me.suma_haber.Name = "suma_haber"
        '
        'btnParametrizacion
        '
        Me.btnParametrizacion.Location = New System.Drawing.Point(541, 383)
        Me.btnParametrizacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnParametrizacion.Name = "btnParametrizacion"
        Me.btnParametrizacion.Size = New System.Drawing.Size(146, 30)
        Me.btnParametrizacion.TabIndex = 214
        Me.btnParametrizacion.Text = "PARAMETRIZACIÓN"
        Me.btnParametrizacion.UseVisualStyleBackColor = True
        '
        'frmParametroLibroMayor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(699, 426)
        Me.Controls.Add(Me.btnParametrizacion)
        Me.Controls.Add(Me.dgvLista)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnGeneral)
        Me.Controls.Add(Me.lblSH)
        Me.Controls.Add(Me.lblSD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGenerarPLE)
        Me.Controls.Add(Me.btnVerLibroMayor)
        Me.Controls.Add(Me.btnHojaTrabajo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDigitos)
        Me.Controls.Add(Me.btnEnviar)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmParametroLibroMayor"
        Me.Text = "Parámetrización para el Libro Mayor"
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents txtDigitos As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnHojaTrabajo As System.Windows.Forms.Button
    Friend WithEvents btnVerLibroMayor As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSD As System.Windows.Forms.Label
    Friend WithEvents lblSH As System.Windows.Forms.Label
    Friend WithEvents btnGenerarPLE As System.Windows.Forms.Button
    Friend WithEvents btnGeneral As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents cuenta_padre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents suma_debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents suma_haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnParametrizacion As System.Windows.Forms.Button
End Class
