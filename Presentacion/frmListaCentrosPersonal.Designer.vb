<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaCentrosPersonal
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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelAsientos = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnElegir = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.local = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.responsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvPersonal = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cod_dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuspp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ape_paterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ape_materno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fec_ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sueldo_basico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor_asignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.asignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.seguro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.aportaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descuentos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblTituloForm = New System.Windows.Forms.Label()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.panelAsientos.SuspendLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelAsientos
        '
        Me.panelAsientos.Controls.Add(Me.lblTotal)
        Me.panelAsientos.Controls.Add(Me.btnElegir)
        Me.panelAsientos.Controls.Add(Me.Label18)
        Me.panelAsientos.Controls.Add(Me.dgvLista)
        Me.panelAsientos.Controls.Add(Me.btnFinalizar)
        Me.panelAsientos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelAsientos.Location = New System.Drawing.Point(12, 49)
        Me.panelAsientos.Name = "panelAsientos"
        Me.panelAsientos.Size = New System.Drawing.Size(650, 205)
        Me.panelAsientos.TabIndex = 283
        Me.panelAsientos.TabStop = False
        Me.panelAsientos.Text = "LISTA DE REGISTROS"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(84, 169)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(19, 15)
        Me.lblTotal.TabIndex = 304
        Me.lblTotal.Text = "00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnElegir
        '
        Me.btnElegir.BackColor = System.Drawing.Color.Green
        Me.btnElegir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnElegir.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnElegir.ForeColor = System.Drawing.Color.White
        Me.btnElegir.Location = New System.Drawing.Point(465, 172)
        Me.btnElegir.Name = "btnElegir"
        Me.btnElegir.Size = New System.Drawing.Size(179, 27)
        Me.btnElegir.TabIndex = 303
        Me.btnElegir.Text = "CARGAR SELECCIONADOS"
        Me.btnElegir.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 169)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 16)
        Me.Label18.TabIndex = 302
        Me.Label18.Text = "Total registros:"
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToOrderColumns = True
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.check, Me.id, Me.local, Me.descripcion, Me.responsable, Me.estado})
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle16
        Me.dgvLista.Location = New System.Drawing.Point(6, 20)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLista.Size = New System.Drawing.Size(638, 146)
        Me.dgvLista.TabIndex = 283
        '
        'check
        '
        Me.check.HeaderText = "[X]"
        Me.check.Name = "check"
        Me.check.Width = 35
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.id.DefaultCellStyle = DataGridViewCellStyle14
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.Width = 46
        '
        'local
        '
        Me.local.DataPropertyName = "local"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "N2"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.local.DefaultCellStyle = DataGridViewCellStyle15
        Me.local.HeaderText = "Local"
        Me.local.Name = "local"
        Me.local.Visible = False
        Me.local.Width = 70
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Width = 495
        '
        'responsable
        '
        Me.responsable.DataPropertyName = "responsable"
        Me.responsable.HeaderText = "Responsable"
        Me.responsable.Name = "responsable"
        Me.responsable.Visible = False
        Me.responsable.Width = 106
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "estado"
        Me.estado.Name = "estado"
        Me.estado.Visible = False
        '
        'btnFinalizar
        '
        Me.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnFinalizar.ForeColor = System.Drawing.Color.White
        Me.btnFinalizar.Location = New System.Drawing.Point(658, 248)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(95, 35)
        Me.btnFinalizar.TabIndex = 282
        Me.btnFinalizar.Text = "FINALIZAR"
        Me.btnFinalizar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvPersonal)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 260)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(650, 189)
        Me.GroupBox1.TabIndex = 289
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PERSONAL"
        '
        'dgvPersonal
        '
        Me.dgvPersonal.AllowUserToAddRows = False
        Me.dgvPersonal.BackgroundColor = System.Drawing.Color.White
        Me.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPersonal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.cod_dni, Me.cuspp, Me.nombres, Me.ape_paterno, Me.ape_materno, Me.fec_ingreso, Me.cargo, Me.moneda, Me.sueldo_basico, Me.valor_asignacion, Me.asignacion, Me.seguro, Me.aportaciones, Me.descuentos, Me.total})
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPersonal.DefaultCellStyle = DataGridViewCellStyle26
        Me.dgvPersonal.Location = New System.Drawing.Point(6, 20)
        Me.dgvPersonal.Name = "dgvPersonal"
        Me.dgvPersonal.Size = New System.Drawing.Size(638, 163)
        Me.dgvPersonal.TabIndex = 283
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'cod_dni
        '
        Me.cod_dni.DataPropertyName = "cod_dni"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cod_dni.DefaultCellStyle = DataGridViewCellStyle17
        Me.cod_dni.HeaderText = "COD/DNI"
        Me.cod_dni.Name = "cod_dni"
        Me.cod_dni.Width = 70
        '
        'cuspp
        '
        Me.cuspp.DataPropertyName = "cuspp"
        Me.cuspp.HeaderText = "cuspp"
        Me.cuspp.Name = "cuspp"
        Me.cuspp.Visible = False
        '
        'nombres
        '
        Me.nombres.DataPropertyName = "nombres"
        Me.nombres.HeaderText = "NOMBRES"
        Me.nombres.Name = "nombres"
        '
        'ape_paterno
        '
        Me.ape_paterno.DataPropertyName = "ape_pat"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.ape_paterno.DefaultCellStyle = DataGridViewCellStyle18
        Me.ape_paterno.HeaderText = "APE. PAT."
        Me.ape_paterno.Name = "ape_paterno"
        '
        'ape_materno
        '
        Me.ape_materno.DataPropertyName = "ape_mat"
        Me.ape_materno.HeaderText = "APE. MAT."
        Me.ape_materno.Name = "ape_materno"
        '
        'fec_ingreso
        '
        Me.fec_ingreso.DataPropertyName = "fec_ingreso"
        Me.fec_ingreso.HeaderText = "FEC. ING."
        Me.fec_ingreso.Name = "fec_ingreso"
        Me.fec_ingreso.Width = 85
        '
        'cargo
        '
        Me.cargo.DataPropertyName = "cargo"
        Me.cargo.HeaderText = "CARGO/OCUP."
        Me.cargo.Name = "cargo"
        Me.cargo.Width = 150
        '
        'moneda
        '
        Me.moneda.DataPropertyName = "moneda"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.moneda.DefaultCellStyle = DataGridViewCellStyle19
        Me.moneda.HeaderText = "MND"
        Me.moneda.Name = "moneda"
        Me.moneda.Width = 45
        '
        'sueldo_basico
        '
        Me.sueldo_basico.DataPropertyName = "sueldo_basico"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.sueldo_basico.DefaultCellStyle = DataGridViewCellStyle20
        Me.sueldo_basico.HeaderText = "SUELDO"
        Me.sueldo_basico.Name = "sueldo_basico"
        Me.sueldo_basico.Width = 90
        '
        'valor_asignacion
        '
        Me.valor_asignacion.DataPropertyName = "valor_asignacion"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.valor_asignacion.DefaultCellStyle = DataGridViewCellStyle21
        Me.valor_asignacion.HeaderText = "ASG. FAM"
        Me.valor_asignacion.Name = "valor_asignacion"
        Me.valor_asignacion.Width = 90
        '
        'asignacion
        '
        Me.asignacion.DataPropertyName = "asignacion"
        Me.asignacion.HeaderText = "asignacion"
        Me.asignacion.Name = "asignacion"
        Me.asignacion.Visible = False
        '
        'seguro
        '
        Me.seguro.DataPropertyName = "seguro"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.seguro.DefaultCellStyle = DataGridViewCellStyle22
        Me.seguro.HeaderText = "PENSION"
        Me.seguro.Name = "seguro"
        Me.seguro.Width = 70
        '
        'aportaciones
        '
        Me.aportaciones.DataPropertyName = "aportaciones"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle23.Format = "N2"
        DataGridViewCellStyle23.NullValue = "0.00"
        Me.aportaciones.DefaultCellStyle = DataGridViewCellStyle23
        Me.aportaciones.HeaderText = "SEGURO"
        Me.aportaciones.Name = "aportaciones"
        Me.aportaciones.Width = 90
        '
        'descuentos
        '
        Me.descuentos.DataPropertyName = "descuentos"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.descuentos.DefaultCellStyle = DataGridViewCellStyle24
        Me.descuentos.HeaderText = "DSCTOS"
        Me.descuentos.Name = "descuentos"
        Me.descuentos.Width = 90
        '
        'total
        '
        Me.total.DataPropertyName = "total"
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.total.DefaultCellStyle = DataGridViewCellStyle25
        Me.total.HeaderText = "TOTAL"
        Me.total.Name = "total"
        Me.total.Width = 90
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(658, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 35)
        Me.Button1.TabIndex = 282
        Me.Button1.Text = "FINALIZAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblTituloForm
        '
        Me.lblTituloForm.AutoSize = True
        Me.lblTituloForm.BackColor = System.Drawing.Color.Transparent
        Me.lblTituloForm.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblTituloForm.Location = New System.Drawing.Point(-8, -8)
        Me.lblTituloForm.Name = "lblTituloForm"
        Me.lblTituloForm.Padding = New System.Windows.Forms.Padding(10)
        Me.lblTituloForm.Size = New System.Drawing.Size(400, 59)
        Me.lblTituloForm.TabIndex = 290
        Me.lblTituloForm.Text = "CENTROS DE PERSONAL"
        '
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnCrear.ForeColor = System.Drawing.Color.White
        Me.btnCrear.Location = New System.Drawing.Point(532, 24)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(130, 27)
        Me.btnCrear.TabIndex = 304
        Me.btnCrear.Text = "ANEXAR PERSONAL"
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'frmListaCentrosPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(674, 461)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.panelAsientos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTituloForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmListaCentrosPersonal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Centro de Personal"
        Me.panelAsientos.ResumeLayout(False)
        Me.panelAsientos.PerformLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelAsientos As System.Windows.Forms.GroupBox
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents btnFinalizar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblTituloForm As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnElegir As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnCrear As System.Windows.Forms.Button
    Friend WithEvents check As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents local As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents responsable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvPersonal As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cod_dni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuspp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ape_paterno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ape_materno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fec_ingreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents moneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sueldo_basico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents valor_asignacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents asignacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents seguro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents aportaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descuentos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
