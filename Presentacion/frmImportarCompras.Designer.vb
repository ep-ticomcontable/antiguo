<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportarCompras
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
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.grupoBusqueda = New System.Windows.Forms.GroupBox()
        Me.txtArchivo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNumRegistros = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblIgv = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblMontos = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dni_ruc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.igv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sujeto_a = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.porcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.glosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.chkAT = New System.Windows.Forms.CheckBox()
        Me.grupoBusqueda.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 25.0!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(5, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(485, 40)
        Me.lblTitulo.TabIndex = 234
        Me.lblTitulo.Text = "IMPORTACIÓN DE COMPRAS"
        '
        'grupoBusqueda
        '
        Me.grupoBusqueda.Controls.Add(Me.txtArchivo)
        Me.grupoBusqueda.Controls.Add(Me.Label3)
        Me.grupoBusqueda.Controls.Add(Me.btnConsultar)
        Me.grupoBusqueda.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoBusqueda.Location = New System.Drawing.Point(12, 52)
        Me.grupoBusqueda.Name = "grupoBusqueda"
        Me.grupoBusqueda.Size = New System.Drawing.Size(427, 55)
        Me.grupoBusqueda.TabIndex = 235
        Me.grupoBusqueda.TabStop = False
        Me.grupoBusqueda.Text = "INGRESO DE DATOS"
        '
        'txtArchivo
        '
        Me.txtArchivo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArchivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtArchivo.Location = New System.Drawing.Point(220, 22)
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.Size = New System.Drawing.Size(200, 21)
        Me.txtArchivo.TabIndex = 103
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label3.Location = New System.Drawing.Point(11, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Archivo:"
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultar.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnConsultar.ForeColor = System.Drawing.Color.White
        Me.btnConsultar.Location = New System.Drawing.Point(64, 19)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(157, 27)
        Me.btnConsultar.TabIndex = 109
        Me.btnConsultar.Text = "SELECCIONAR ARCHIVO"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'btnFinalizar
        '
        Me.btnFinalizar.BackColor = System.Drawing.Color.Green
        Me.btnFinalizar.FlatAppearance.BorderSize = 0
        Me.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizar.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnFinalizar.ForeColor = System.Drawing.Color.White
        Me.btnFinalizar.Location = New System.Drawing.Point(828, 522)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(144, 27)
        Me.btnFinalizar.TabIndex = 116
        Me.btnFinalizar.Text = "&IMPORTAR DATOS"
        Me.btnFinalizar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNumRegistros)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblIgv)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblMontos)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dgvLista)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(960, 403)
        Me.GroupBox1.TabIndex = 236
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REGISTROS"
        '
        'lblNumRegistros
        '
        Me.lblNumRegistros.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblNumRegistros.Location = New System.Drawing.Point(4, 380)
        Me.lblNumRegistros.Name = "lblNumRegistros"
        Me.lblNumRegistros.Size = New System.Drawing.Size(87, 17)
        Me.lblNumRegistros.TabIndex = 117
        Me.lblNumRegistros.Text = "0"
        Me.lblNumRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label13.Location = New System.Drawing.Point(4, 362)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 17)
        Me.Label13.TabIndex = 116
        Me.Label13.Text = "N° REGISTROS:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.Location = New System.Drawing.Point(848, 380)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(36, 17)
        Me.lblTotal.TabIndex = 114
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label10.Location = New System.Drawing.Point(848, 362)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 17)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "TOTAL:"
        '
        'lblIgv
        '
        Me.lblIgv.AutoSize = True
        Me.lblIgv.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblIgv.Location = New System.Drawing.Point(780, 380)
        Me.lblIgv.Name = "lblIgv"
        Me.lblIgv.Size = New System.Drawing.Size(36, 17)
        Me.lblIgv.TabIndex = 112
        Me.lblIgv.Text = "0.00"
        Me.lblIgv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label8.Location = New System.Drawing.Point(780, 362)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 17)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "IGV:"
        '
        'lblMontos
        '
        Me.lblMontos.AutoSize = True
        Me.lblMontos.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblMontos.Location = New System.Drawing.Point(694, 380)
        Me.lblMontos.Name = "lblMontos"
        Me.lblMontos.Size = New System.Drawing.Size(36, 17)
        Me.lblMontos.TabIndex = 110
        Me.lblMontos.Text = "0.00"
        Me.lblMontos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label4.Location = New System.Drawing.Point(694, 362)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "MONTOS:"
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToOrderColumns = True
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.estado, Me.comprobante, Me.serie, Me.numero, Me.dni_ruc, Me.nombre, Me.moneda, Me.tc, Me.monto, Me.igv, Me.total, Me.sujeto_a, Me.porcentaje, Me.glosa, Me.emision})
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle20
        Me.dgvLista.Location = New System.Drawing.Point(5, 20)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.Size = New System.Drawing.Size(949, 339)
        Me.dgvLista.TabIndex = 0
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "ESTADO"
        Me.estado.Name = "estado"
        Me.estado.Width = 70
        '
        'comprobante
        '
        Me.comprobante.DataPropertyName = "COMPROBANTE"
        Me.comprobante.HeaderText = "COMP."
        Me.comprobante.Name = "comprobante"
        Me.comprobante.Width = 70
        '
        'serie
        '
        Me.serie.DataPropertyName = "SERIE"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.serie.DefaultCellStyle = DataGridViewCellStyle11
        Me.serie.HeaderText = "SERIE"
        Me.serie.Name = "serie"
        Me.serie.Width = 50
        '
        'numero
        '
        Me.numero.DataPropertyName = "NUMERO"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.numero.DefaultCellStyle = DataGridViewCellStyle12
        Me.numero.HeaderText = "NUM."
        Me.numero.Name = "numero"
        Me.numero.Width = 50
        '
        'dni_ruc
        '
        Me.dni_ruc.DataPropertyName = "DNI_RUC"
        Me.dni_ruc.HeaderText = "DNI/RUC"
        Me.dni_ruc.Name = "dni_ruc"
        Me.dni_ruc.Width = 80
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "NOMBRE_RAZON"
        Me.nombre.HeaderText = "CLIENTE"
        Me.nombre.Name = "nombre"
        Me.nombre.Width = 150
        '
        'moneda
        '
        Me.moneda.DataPropertyName = "MND"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.moneda.DefaultCellStyle = DataGridViewCellStyle13
        Me.moneda.HeaderText = "MND."
        Me.moneda.Name = "moneda"
        Me.moneda.Width = 50
        '
        'tc
        '
        Me.tc.DataPropertyName = "TC"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.tc.DefaultCellStyle = DataGridViewCellStyle14
        Me.tc.HeaderText = "T.C"
        Me.tc.Name = "tc"
        Me.tc.Width = 40
        '
        'monto
        '
        Me.monto.DataPropertyName = "MONTO"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "N2"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.monto.DefaultCellStyle = DataGridViewCellStyle15
        Me.monto.HeaderText = "MONTO"
        Me.monto.Name = "monto"
        Me.monto.Width = 70
        '
        'igv
        '
        Me.igv.DataPropertyName = "IGV"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "N2"
        DataGridViewCellStyle16.NullValue = Nothing
        Me.igv.DefaultCellStyle = DataGridViewCellStyle16
        Me.igv.HeaderText = "IGV"
        Me.igv.Name = "igv"
        Me.igv.Width = 70
        '
        'total
        '
        Me.total.DataPropertyName = "TOTAL"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.Format = "N2"
        DataGridViewCellStyle17.NullValue = Nothing
        Me.total.DefaultCellStyle = DataGridViewCellStyle17
        Me.total.HeaderText = "TOTAL"
        Me.total.Name = "total"
        Me.total.Width = 70
        '
        'sujeto_a
        '
        Me.sujeto_a.DataPropertyName = "sujeto_a"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.sujeto_a.DefaultCellStyle = DataGridViewCellStyle18
        Me.sujeto_a.HeaderText = "SUJETO A"
        Me.sujeto_a.Name = "sujeto_a"
        Me.sujeto_a.Width = 82
        '
        'porcentaje
        '
        Me.porcentaje.DataPropertyName = "porcentaje"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle19.Format = "N2"
        DataGridViewCellStyle19.NullValue = "0.00"
        Me.porcentaje.DefaultCellStyle = DataGridViewCellStyle19
        Me.porcentaje.HeaderText = "(%)"
        Me.porcentaje.Name = "porcentaje"
        Me.porcentaje.Width = 40
        '
        'glosa
        '
        Me.glosa.DataPropertyName = "GLOSA"
        Me.glosa.HeaderText = "GLOSA"
        Me.glosa.Name = "glosa"
        '
        'emision
        '
        Me.emision.DataPropertyName = "EMISION"
        Me.emision.HeaderText = "EMISION"
        Me.emision.Name = "emision"
        Me.emision.Width = 78
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Location = New System.Drawing.Point(854, 80)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(118, 27)
        Me.btnEditar.TabIndex = 237
        Me.btnEditar.Text = "VER CUENTAS"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'chkAT
        '
        Me.chkAT.AutoSize = True
        Me.chkAT.Location = New System.Drawing.Point(445, 74)
        Me.chkAT.Name = "chkAT"
        Me.chkAT.Size = New System.Drawing.Size(236, 20)
        Me.chkAT.TabIndex = 238
        Me.chkAT.Text = "HABILITAR ASIENTOS DE TRANSFERENCIA"
        Me.chkAT.UseVisualStyleBackColor = True
        '
        'frmImportarCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.chkAT)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.grupoBusqueda)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmImportarCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COMPRAS"
        Me.grupoBusqueda.ResumeLayout(False)
        Me.grupoBusqueda.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents grupoBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents txtArchivo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnFinalizar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents lblNumRegistros As System.Windows.Forms.Label
    Private WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents lblTotal As System.Windows.Forms.Label
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents lblIgv As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents lblMontos As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents chkAT As System.Windows.Forms.CheckBox
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dni_ruc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents moneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents igv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sujeto_a As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents porcentaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents glosa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents emision As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
