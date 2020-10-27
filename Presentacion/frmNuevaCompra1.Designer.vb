<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevaCompra1
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTipoDeCambio = New System.Windows.Forms.Label()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtCuentaP = New System.Windows.Forms.TextBox()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.txtTipoCambio = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboTipoCompra = New System.Windows.Forms.ComboBox()
        Me.dtFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboOperacion = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGlosa = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.btnBuscarRuc = New System.Windows.Forms.Button()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTipoDeCambio)
        Me.GroupBox2.Controls.Add(Me.lblCuenta)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.txtCuentaP)
        Me.GroupBox2.Controls.Add(Me.cboMoneda)
        Me.GroupBox2.Controls.Add(Me.txtTipoCambio)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.cboTipoCompra)
        Me.GroupBox2.Controls.Add(Me.dtFechaPago)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.txtSerie)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.dtFechaEmision)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cboOperacion)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtGlosa)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtRazonSocial)
        Me.GroupBox2.Controls.Add(Me.btnBuscarRuc)
        Me.GroupBox2.Controls.Add(Me.txtNumero)
        Me.GroupBox2.Controls.Add(Me.txtRuc)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cboTipoDocumento)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(481, 314)
        Me.GroupBox2.TabIndex = 110
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS DEL COMPROBANTE COMPRA"
        '
        'lblTipoDeCambio
        '
        Me.lblTipoDeCambio.AutoSize = True
        Me.lblTipoDeCambio.Location = New System.Drawing.Point(248, 215)
        Me.lblTipoDeCambio.Name = "lblTipoDeCambio"
        Me.lblTipoDeCambio.Size = New System.Drawing.Size(96, 16)
        Me.lblTipoDeCambio.TabIndex = 284
        Me.lblTipoDeCambio.Text = "Tipo de cambio:"
        '
        'lblCuenta
        '
        Me.lblCuenta.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCuenta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblCuenta.Location = New System.Drawing.Point(95, 40)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(377, 18)
        Me.lblCuenta.TabIndex = 119
        Me.lblCuenta.Text = "[Nombre Cuenta]"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(144, 216)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(59, 16)
        Me.Label29.TabIndex = 285
        Me.Label29.Text = "Moneda:"
        '
        'txtCuentaP
        '
        Me.txtCuentaP.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtCuentaP.Location = New System.Drawing.Point(9, 37)
        Me.txtCuentaP.Name = "txtCuentaP"
        Me.txtCuentaP.Size = New System.Drawing.Size(80, 21)
        Me.txtCuentaP.TabIndex = 118
        Me.txtCuentaP.Text = "42"
        Me.txtCuentaP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboMoneda
        '
        Me.cboMoneda.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Items.AddRange(New Object() {"soles", "dolares"})
        Me.cboMoneda.Location = New System.Drawing.Point(147, 234)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(98, 23)
        Me.cboMoneda.TabIndex = 282
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCambio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtTipoCambio.Location = New System.Drawing.Point(251, 234)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Size = New System.Drawing.Size(120, 21)
        Me.txtTipoCambio.TabIndex = 283
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(135, 16)
        Me.Label15.TabIndex = 117
        Me.Label15.Text = "N° Cuenta - Proveedor:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 261)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 16)
        Me.Label19.TabIndex = 106
        Me.Label19.Text = "Tipo de pago"
        '
        'cboTipoCompra
        '
        Me.cboTipoCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoCompra.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboTipoCompra.FormattingEnabled = True
        Me.cboTipoCompra.Items.AddRange(New Object() {"soles", "dolares"})
        Me.cboTipoCompra.Location = New System.Drawing.Point(9, 279)
        Me.cboTipoCompra.Name = "cboTipoCompra"
        Me.cboTipoCompra.Size = New System.Drawing.Size(120, 23)
        Me.cboTipoCompra.TabIndex = 105
        '
        'dtFechaPago
        '
        Me.dtFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaPago.Location = New System.Drawing.Point(251, 279)
        Me.dtFechaPago.Name = "dtFechaPago"
        Me.dtFechaPago.Size = New System.Drawing.Size(94, 21)
        Me.dtFechaPago.TabIndex = 102
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(248, 260)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(78, 16)
        Me.Label28.TabIndex = 103
        Me.Label28.Text = "Fecha pago:"
        '
        'txtSerie
        '
        Me.txtSerie.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtSerie.Location = New System.Drawing.Point(288, 79)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(89, 21)
        Me.txtSerie.TabIndex = 4
        Me.txtSerie.Text = "0152"
        Me.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(285, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Serie:"
        '
        'dtFechaEmision
        '
        Me.dtFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaEmision.Location = New System.Drawing.Point(151, 279)
        Me.dtFechaEmision.Name = "dtFechaEmision"
        Me.dtFechaEmision.Size = New System.Drawing.Size(94, 21)
        Me.dtFechaEmision.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(148, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Fecha emisión:"
        '
        'cboOperacion
        '
        Me.cboOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOperacion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOperacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboOperacion.FormattingEnabled = True
        Me.cboOperacion.Location = New System.Drawing.Point(9, 235)
        Me.cboOperacion.Name = "cboOperacion"
        Me.cboOperacion.Size = New System.Drawing.Size(132, 23)
        Me.cboOperacion.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 218)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 16)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Operación"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 16)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "RUC:"
        '
        'txtGlosa
        '
        Me.txtGlosa.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtGlosa.Location = New System.Drawing.Point(9, 194)
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(463, 21)
        Me.txtGlosa.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 175)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 16)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "Glosa:"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtRazonSocial.Location = New System.Drawing.Point(9, 151)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(463, 21)
        Me.txtRazonSocial.TabIndex = 10
        Me.txtRazonSocial.Text = "TICOM TICOM TICOM"
        '
        'btnBuscarRuc
        '
        Me.btnBuscarRuc.Location = New System.Drawing.Point(45, 106)
        Me.btnBuscarRuc.Name = "btnBuscarRuc"
        Me.btnBuscarRuc.Size = New System.Drawing.Size(29, 23)
        Me.btnBuscarRuc.TabIndex = 8
        Me.btnBuscarRuc.Text = "..."
        Me.btnBuscarRuc.UseVisualStyleBackColor = True
        '
        'txtNumero
        '
        Me.txtNumero.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtNumero.Location = New System.Drawing.Point(383, 79)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(89, 21)
        Me.txtNumero.TabIndex = 5
        Me.txtNumero.Text = "5151"
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRuc
        '
        Me.txtRuc.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtRuc.Location = New System.Drawing.Point(80, 108)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(86, 21)
        Me.txtRuc.TabIndex = 9
        Me.txtRuc.Text = "10447301500"
        Me.txtRuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Razón Social:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(380, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 16)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "Número:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 16)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "Tipo Documento:"
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTipoDocumento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDocumento.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocumento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboTipoDocumento.FormattingEnabled = True
        Me.cboTipoDocumento.Location = New System.Drawing.Point(9, 79)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(273, 23)
        Me.cboTipoDocumento.TabIndex = 3
        '
        'frmNuevaCompra1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 336)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmNuevaCompra1"
        Me.Text = "frmNuevaCompra1"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTipoDeCambio As System.Windows.Forms.Label
    Friend WithEvents lblCuenta As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaP As System.Windows.Forms.TextBox
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents txtTipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cboTipoCompra As System.Windows.Forms.ComboBox
    Friend WithEvents dtFechaPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtFechaEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboOperacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtGlosa As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarRuc As System.Windows.Forms.Button
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboTipoDocumento As System.Windows.Forms.ComboBox
End Class
