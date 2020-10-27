<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnexoPersonalCentroCosto
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTituloForm = New System.Windows.Forms.Label()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvPersonal = New System.Windows.Forms.DataGridView()
        Me.check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboCentroCosto = New System.Windows.Forms.ComboBox()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAnexar = New System.Windows.Forms.Button()
        Me.gbDatos.SuspendLayout()
        CType(Me.dgvPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.lblTituloForm.Size = New System.Drawing.Size(408, 59)
        Me.lblTituloForm.TabIndex = 290
        Me.lblTituloForm.Text = "ANEXO C.C - PERSONAL"
        '
        'gbDatos
        '
        Me.gbDatos.Controls.Add(Me.txtBuscar)
        Me.gbDatos.Controls.Add(Me.Label1)
        Me.gbDatos.Controls.Add(Me.dgvPersonal)
        Me.gbDatos.Controls.Add(Me.Button1)
        Me.gbDatos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatos.Location = New System.Drawing.Point(12, 82)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(560, 234)
        Me.gbDatos.TabIndex = 291
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "PERSONAL"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtBuscar.Location = New System.Drawing.Point(218, 17)
        Me.txtBuscar.MaxLength = 11
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(159, 21)
        Me.txtBuscar.TabIndex = 284
        Me.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(165, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 285
        Me.Label1.Text = "BUSCAR:"
        '
        'dgvPersonal
        '
        Me.dgvPersonal.AllowUserToAddRows = False
        Me.dgvPersonal.BackgroundColor = System.Drawing.Color.White
        Me.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPersonal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.check, Me.id, Me.cod_dni, Me.cuspp, Me.nombres, Me.ape_paterno, Me.ape_materno, Me.fec_ingreso, Me.cargo, Me.moneda, Me.sueldo_basico, Me.valor_asignacion, Me.asignacion, Me.seguro, Me.aportaciones, Me.descuentos, Me.total})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPersonal.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvPersonal.Location = New System.Drawing.Point(6, 44)
        Me.dgvPersonal.Name = "dgvPersonal"
        Me.dgvPersonal.Size = New System.Drawing.Size(548, 184)
        Me.dgvPersonal.TabIndex = 283
        '
        'check
        '
        Me.check.HeaderText = "[X]"
        Me.check.Name = "check"
        Me.check.Width = 32
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'cod_dni
        '
        Me.cod_dni.DataPropertyName = "cod_dni"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cod_dni.DefaultCellStyle = DataGridViewCellStyle1
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.ape_paterno.DefaultCellStyle = DataGridViewCellStyle2
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.moneda.DefaultCellStyle = DataGridViewCellStyle3
        Me.moneda.HeaderText = "MND"
        Me.moneda.Name = "moneda"
        Me.moneda.Width = 45
        '
        'sueldo_basico
        '
        Me.sueldo_basico.DataPropertyName = "sueldo_basico"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.sueldo_basico.DefaultCellStyle = DataGridViewCellStyle4
        Me.sueldo_basico.HeaderText = "SUELDO"
        Me.sueldo_basico.Name = "sueldo_basico"
        Me.sueldo_basico.Width = 90
        '
        'valor_asignacion
        '
        Me.valor_asignacion.DataPropertyName = "valor_asignacion"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.valor_asignacion.DefaultCellStyle = DataGridViewCellStyle5
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
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.seguro.DefaultCellStyle = DataGridViewCellStyle6
        Me.seguro.HeaderText = "PENSION"
        Me.seguro.Name = "seguro"
        Me.seguro.Width = 70
        '
        'aportaciones
        '
        Me.aportaciones.DataPropertyName = "aportaciones"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = "0.00"
        Me.aportaciones.DefaultCellStyle = DataGridViewCellStyle7
        Me.aportaciones.HeaderText = "SEGURO"
        Me.aportaciones.Name = "aportaciones"
        Me.aportaciones.Width = 90
        '
        'descuentos
        '
        Me.descuentos.DataPropertyName = "descuentos"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.descuentos.DefaultCellStyle = DataGridViewCellStyle8
        Me.descuentos.HeaderText = "DSCTOS"
        Me.descuentos.Name = "descuentos"
        Me.descuentos.Width = 90
        '
        'total
        '
        Me.total.DataPropertyName = "total"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.total.DefaultCellStyle = DataGridViewCellStyle9
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(11, 56)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 16)
        Me.Label7.TabIndex = 293
        Me.Label7.Text = "CENTRO DE COSTO:"
        '
        'cboCentroCosto
        '
        Me.cboCentroCosto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCentroCosto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCentroCosto.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentroCosto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboCentroCosto.FormattingEnabled = True
        Me.cboCentroCosto.Location = New System.Drawing.Point(130, 53)
        Me.cboCentroCosto.Name = "cboCentroCosto"
        Me.cboCentroCosto.Size = New System.Drawing.Size(270, 23)
        Me.cboCentroCosto.TabIndex = 294
        '
        'btnProcesar
        '
        Me.btnProcesar.BackColor = System.Drawing.Color.Green
        Me.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcesar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnProcesar.ForeColor = System.Drawing.Color.White
        Me.btnProcesar.Location = New System.Drawing.Point(466, 320)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(106, 29)
        Me.btnProcesar.TabIndex = 304
        Me.btnProcesar.Text = "PROCESAR"
        Me.btnProcesar.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(93, 319)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(19, 15)
        Me.lblTotal.TabIndex = 306
        Me.lblTotal.Text = "00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(15, 319)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 16)
        Me.Label18.TabIndex = 305
        Me.Label18.Text = "Total registros:"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Black
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(361, 320)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(99, 30)
        Me.btnCancelar.TabIndex = 307
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAnexar
        '
        Me.btnAnexar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAnexar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnexar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnAnexar.ForeColor = System.Drawing.Color.White
        Me.btnAnexar.Location = New System.Drawing.Point(460, 49)
        Me.btnAnexar.Name = "btnAnexar"
        Me.btnAnexar.Size = New System.Drawing.Size(106, 29)
        Me.btnAnexar.TabIndex = 308
        Me.btnAnexar.Text = "ANEXAR"
        Me.btnAnexar.UseVisualStyleBackColor = False
        Me.btnAnexar.Visible = False
        '
        'frmAnexoPersonalCentroCosto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.btnAnexar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.cboCentroCosto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.gbDatos)
        Me.Controls.Add(Me.lblTituloForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmAnexoPersonalCentroCosto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ANEXO DE CENTRO DE COSTO CON PERSONAL"
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        CType(Me.dgvPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTituloForm As System.Windows.Forms.Label
    Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents dgvPersonal As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboCentroCosto As System.Windows.Forms.ComboBox
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAnexar As System.Windows.Forms.Button
    Friend WithEvents check As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
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
