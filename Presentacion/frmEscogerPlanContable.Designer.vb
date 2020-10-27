<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEscogerPlanContable
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
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.btnElegir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nivel_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenta_debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenta_haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToOrderColumns = True
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nombre, Me.sub_id, Me.nivel_cuenta, Me.tipo_cuenta, Me.c1, Me.cuenta_debe, Me.cuenta_haber, Me.estado})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLista.Location = New System.Drawing.Point(12, 12)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLista.Size = New System.Drawing.Size(445, 346)
        Me.dgvLista.TabIndex = 197
        '
        'btnElegir
        '
        Me.btnElegir.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnElegir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnElegir.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnElegir.ForeColor = System.Drawing.Color.White
        Me.btnElegir.Location = New System.Drawing.Point(322, 364)
        Me.btnElegir.Name = "btnElegir"
        Me.btnElegir.Size = New System.Drawing.Size(135, 35)
        Me.btnElegir.TabIndex = 203
        Me.btnElegir.Text = "Elegir cuenta"
        Me.btnElegir.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Black
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Location = New System.Drawing.Point(12, 364)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(144, 35)
        Me.btnEditar.TabIndex = 204
        Me.btnEditar.Text = "Modificar Cuenta"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'id
        '
        Me.id.DataPropertyName = "num_cuenta"
        Me.id.HeaderText = "N°"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 55
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nom_cuenta"
        Me.nombre.HeaderText = "Descripción"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 155
        '
        'sub_id
        '
        Me.sub_id.DataPropertyName = "sub_id"
        Me.sub_id.HeaderText = "sub_id"
        Me.sub_id.Name = "sub_id"
        Me.sub_id.ReadOnly = True
        Me.sub_id.Visible = False
        Me.sub_id.Width = 50
        '
        'nivel_cuenta
        '
        Me.nivel_cuenta.DataPropertyName = "nivel_cuenta"
        Me.nivel_cuenta.HeaderText = "Nivel Cuenta"
        Me.nivel_cuenta.Name = "nivel_cuenta"
        Me.nivel_cuenta.ReadOnly = True
        Me.nivel_cuenta.Visible = False
        Me.nivel_cuenta.Width = 150
        '
        'tipo_cuenta
        '
        Me.tipo_cuenta.DataPropertyName = "tipo_cuenta"
        Me.tipo_cuenta.HeaderText = "Tipo Cuenta"
        Me.tipo_cuenta.Name = "tipo_cuenta"
        Me.tipo_cuenta.ReadOnly = True
        '
        'c1
        '
        Me.c1.DataPropertyName = "c1"
        Me.c1.HeaderText = "C. Costo"
        Me.c1.Name = "c1"
        Me.c1.ReadOnly = True
        Me.c1.Width = 72
        '
        'cuenta_debe
        '
        Me.cuenta_debe.DataPropertyName = "cuenta_debe"
        Me.cuenta_debe.HeaderText = "Debe"
        Me.cuenta_debe.Name = "cuenta_debe"
        Me.cuenta_debe.ReadOnly = True
        Me.cuenta_debe.Visible = False
        Me.cuenta_debe.Width = 88
        '
        'cuenta_haber
        '
        Me.cuenta_haber.DataPropertyName = "cuenta_haber"
        Me.cuenta_haber.HeaderText = "Haber"
        Me.cuenta_haber.Name = "cuenta_haber"
        Me.cuenta_haber.ReadOnly = True
        Me.cuenta_haber.Visible = False
        Me.cuenta_haber.Width = 88
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "estado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        Me.estado.Visible = False
        '
        'frmEscogerPlanContable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 411)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnElegir)
        Me.Controls.Add(Me.dgvLista)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmEscogerPlanContable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anexar N° de Cuenta Contable"
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents btnElegir As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sub_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nivel_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuenta_debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuenta_haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
