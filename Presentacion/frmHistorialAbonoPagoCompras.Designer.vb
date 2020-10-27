<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistorialAbonoPagoCompras
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblLoad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblMoneda = New System.Windows.Forms.Label()
        Me.lblDeuda = New System.Windows.Forms.Label()
        Me.panel = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion_pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto_pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblVacio = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTotalAbono = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.panel.SuspendLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLoad
        '
        Me.lblLoad.AutoSize = True
        Me.lblLoad.BackColor = System.Drawing.Color.Transparent
        Me.lblLoad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblLoad.Location = New System.Drawing.Point(12, 70)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(343, 17)
        Me.lblLoad.TabIndex = 210
        Me.lblLoad.Text = "Elija la empresa con la que desea iniciar el sistema: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 19)
        Me.Label1.TabIndex = 214
        Me.Label1.Text = "DEUDA TOTAL:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(10, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 19)
        Me.Label5.TabIndex = 215
        Me.Label5.Text = "MONEDA:"
        '
        'lblMoneda
        '
        Me.lblMoneda.BackColor = System.Drawing.Color.Transparent
        Me.lblMoneda.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblMoneda.ForeColor = System.Drawing.Color.Black
        Me.lblMoneda.Location = New System.Drawing.Point(99, 18)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(256, 19)
        Me.lblMoneda.TabIndex = 216
        Me.lblMoneda.Text = "S/."
        Me.lblMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDeuda
        '
        Me.lblDeuda.BackColor = System.Drawing.Color.Transparent
        Me.lblDeuda.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblDeuda.ForeColor = System.Drawing.Color.Black
        Me.lblDeuda.Location = New System.Drawing.Point(131, 42)
        Me.lblDeuda.Name = "lblDeuda"
        Me.lblDeuda.Size = New System.Drawing.Size(139, 19)
        Me.lblDeuda.TabIndex = 217
        Me.lblDeuda.Text = "100,125.65"
        Me.lblDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panel
        '
        Me.panel.Controls.Add(Me.lblTotalAbono)
        Me.panel.Controls.Add(Me.Label9)
        Me.panel.Controls.Add(Me.Label7)
        Me.panel.Controls.Add(Me.Label6)
        Me.panel.Controls.Add(Me.Label3)
        Me.panel.Controls.Add(Me.Label2)
        Me.panel.Controls.Add(Me.dgvLista)
        Me.panel.Location = New System.Drawing.Point(3, 100)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(505, 314)
        Me.panel.TabIndex = 218
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(401, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 17)
        Me.Label7.TabIndex = 224
        Me.Label7.Text = "ABONO"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(199, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(212, 17)
        Me.Label6.TabIndex = 223
        Me.Label6.Text = "DESCRIPCION"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(41, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 17)
        Me.Label3.TabIndex = 222
        Me.Label3.Text = "FECHA"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(2, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 221
        Me.Label2.Text = "N°"
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToOrderColumns = True
        Me.dgvLista.AllowUserToResizeColumns = False
        Me.dgvLista.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.dgvLista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        Me.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.ColumnHeadersVisible = False
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.fecha_pago, Me.descripcion_pago, Me.monto_pago})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvLista.GridColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.dgvLista.Location = New System.Drawing.Point(3, 34)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvLista.RowHeadersVisible = False
        Me.dgvLista.RowTemplate.Height = 40
        Me.dgvLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvLista.Size = New System.Drawing.Size(500, 241)
        Me.dgvLista.TabIndex = 220
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.id.DefaultCellStyle = DataGridViewCellStyle3
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 40
        '
        'fecha_pago
        '
        Me.fecha_pago.DataPropertyName = "fecha_pago"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.fecha_pago.DefaultCellStyle = DataGridViewCellStyle4
        Me.fecha_pago.HeaderText = "Fecha Pago"
        Me.fecha_pago.Name = "fecha_pago"
        Me.fecha_pago.ReadOnly = True
        Me.fecha_pago.Width = 160
        '
        'descripcion_pago
        '
        Me.descripcion_pago.DataPropertyName = "descripcion_pago"
        Me.descripcion_pago.HeaderText = "Descripcion"
        Me.descripcion_pago.Name = "descripcion_pago"
        Me.descripcion_pago.ReadOnly = True
        Me.descripcion_pago.Width = 200
        '
        'monto_pago
        '
        Me.monto_pago.DataPropertyName = "monto_pago"
        Me.monto_pago.HeaderText = "Abono"
        Me.monto_pago.Name = "monto_pago"
        Me.monto_pago.ReadOnly = True
        Me.monto_pago.Width = 80
        '
        'lblVacio
        '
        Me.lblVacio.BackColor = System.Drawing.Color.Transparent
        Me.lblVacio.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lblVacio.ForeColor = System.Drawing.Color.Black
        Me.lblVacio.Location = New System.Drawing.Point(82, 100)
        Me.lblVacio.Name = "lblVacio"
        Me.lblVacio.Size = New System.Drawing.Size(348, 68)
        Me.lblVacio.TabIndex = 225
        Me.lblVacio.Text = "No se han encontrado abonos realizados..."
        Me.lblVacio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblVacio.Visible = False
        '
        'lblSaldo
        '
        Me.lblSaldo.BackColor = System.Drawing.Color.Transparent
        Me.lblSaldo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSaldo.ForeColor = System.Drawing.Color.Red
        Me.lblSaldo.Location = New System.Drawing.Point(361, 42)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(139, 19)
        Me.lblSaldo.TabIndex = 220
        Me.lblSaldo.Text = "100,125.65"
        Me.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(291, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 19)
        Me.Label8.TabIndex = 219
        Me.Label8.Text = "SALDO:"
        '
        'lblTotalAbono
        '
        Me.lblTotalAbono.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalAbono.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalAbono.ForeColor = System.Drawing.Color.Black
        Me.lblTotalAbono.Location = New System.Drawing.Point(341, 290)
        Me.lblTotalAbono.Name = "lblTotalAbono"
        Me.lblTotalAbono.Size = New System.Drawing.Size(156, 19)
        Me.lblTotalAbono.TabIndex = 226
        Me.lblTotalAbono.Text = "00.00"
        Me.lblTotalAbono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(225, 292)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 17)
        Me.Label9.TabIndex = 225
        Me.Label9.Text = "Total abonado:"
        '
        'frmHistorialAbonoPagoCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(512, 418)
        Me.Controls.Add(Me.lblVacio)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.panel)
        Me.Controls.Add(Me.lblDeuda)
        Me.Controls.Add(Me.lblMoneda)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLoad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmHistorialAbonoPagoCompras"
        Me.Text = "Historial Abono Pago Compras"
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLoad As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblMoneda As System.Windows.Forms.Label
    Friend WithEvents lblDeuda As System.Windows.Forms.Label
    Friend WithEvents panel As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_pago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion_pago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents monto_pago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblVacio As System.Windows.Forms.Label
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblTotalAbono As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
