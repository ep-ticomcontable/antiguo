<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaAsientoApertura
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvListaAsientos = New System.Windows.Forms.DataGridView()
        Me.dgvDetalleAsiento = New System.Windows.Forms.DataGridView()
        Me.id_a = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_asiento_a = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.glosa_a = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero_a = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_debe_s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_haber_s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diferencia_s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.periodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_a = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado_a = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_asiento_apertura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.glosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_cambio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNuevo = New System.Windows.Forms.Button()
        CType(Me.dgvListaAsientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalleAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListaAsientos
        '
        Me.dgvListaAsientos.AllowUserToAddRows = False
        Me.dgvListaAsientos.AllowUserToDeleteRows = False
        Me.dgvListaAsientos.AllowUserToOrderColumns = True
        Me.dgvListaAsientos.BackgroundColor = System.Drawing.Color.White
        Me.dgvListaAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaAsientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_a, Me.id_asiento_a, Me.glosa_a, Me.numero_a, Me.total_debe_s, Me.total_haber_s, Me.diferencia_s, Me.periodo, Me.fecha_a, Me.estado_a})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListaAsientos.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvListaAsientos.Location = New System.Drawing.Point(12, 60)
        Me.dgvListaAsientos.Name = "dgvListaAsientos"
        Me.dgvListaAsientos.ReadOnly = True
        Me.dgvListaAsientos.Size = New System.Drawing.Size(760, 176)
        Me.dgvListaAsientos.TabIndex = 0
        '
        'dgvDetalleAsiento
        '
        Me.dgvDetalleAsiento.AllowUserToAddRows = False
        Me.dgvDetalleAsiento.AllowUserToDeleteRows = False
        Me.dgvDetalleAsiento.AllowUserToOrderColumns = True
        Me.dgvDetalleAsiento.BackgroundColor = System.Drawing.Color.White
        Me.dgvDetalleAsiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleAsiento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.id_asiento_apertura, Me.cuenta, Me.debe, Me.haber, Me.glosa, Me.moneda, Me.tipo_cambio, Me.nom_doc, Me.num_doc})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetalleAsiento.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvDetalleAsiento.Location = New System.Drawing.Point(12, 242)
        Me.dgvDetalleAsiento.Name = "dgvDetalleAsiento"
        Me.dgvDetalleAsiento.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalleAsiento.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvDetalleAsiento.Size = New System.Drawing.Size(760, 205)
        Me.dgvDetalleAsiento.TabIndex = 29
        '
        'id_a
        '
        Me.id_a.DataPropertyName = "id_a"
        Me.id_a.HeaderText = "N°"
        Me.id_a.Name = "id_a"
        Me.id_a.ReadOnly = True
        Me.id_a.Width = 50
        '
        'id_asiento_a
        '
        Me.id_asiento_a.DataPropertyName = "id_asiento_a"
        Me.id_asiento_a.HeaderText = "id_asiento"
        Me.id_asiento_a.Name = "id_asiento_a"
        Me.id_asiento_a.ReadOnly = True
        Me.id_asiento_a.Visible = False
        '
        'glosa_a
        '
        Me.glosa_a.DataPropertyName = "glosa_a"
        Me.glosa_a.HeaderText = "Glosa"
        Me.glosa_a.Name = "glosa_a"
        Me.glosa_a.ReadOnly = True
        Me.glosa_a.Width = 220
        '
        'numero_a
        '
        Me.numero_a.DataPropertyName = "numero_a"
        Me.numero_a.HeaderText = "Número"
        Me.numero_a.Name = "numero_a"
        Me.numero_a.ReadOnly = True
        Me.numero_a.Width = 55
        '
        'total_debe_s
        '
        Me.total_debe_s.DataPropertyName = "total_debe_s"
        Me.total_debe_s.HeaderText = "T. Debe"
        Me.total_debe_s.Name = "total_debe_s"
        Me.total_debe_s.ReadOnly = True
        Me.total_debe_s.Width = 80
        '
        'total_haber_s
        '
        Me.total_haber_s.DataPropertyName = "total_haber_s"
        Me.total_haber_s.HeaderText = "T. Haber"
        Me.total_haber_s.Name = "total_haber_s"
        Me.total_haber_s.ReadOnly = True
        Me.total_haber_s.Width = 80
        '
        'diferencia_s
        '
        Me.diferencia_s.DataPropertyName = "diferencia_s"
        Me.diferencia_s.HeaderText = "Diferencia"
        Me.diferencia_s.Name = "diferencia_s"
        Me.diferencia_s.ReadOnly = True
        Me.diferencia_s.Width = 80
        '
        'periodo
        '
        Me.periodo.DataPropertyName = "periodo"
        Me.periodo.HeaderText = "Periodo"
        Me.periodo.Name = "periodo"
        Me.periodo.ReadOnly = True
        Me.periodo.Width = 60
        '
        'fecha_a
        '
        Me.fecha_a.DataPropertyName = "fecha_a"
        Me.fecha_a.HeaderText = "Fecha"
        Me.fecha_a.Name = "fecha_a"
        Me.fecha_a.ReadOnly = True
        Me.fecha_a.Width = 74
        '
        'estado_a
        '
        Me.estado_a.DataPropertyName = "estado_a"
        Me.estado_a.HeaderText = "estado"
        Me.estado_a.Name = "estado_a"
        Me.estado_a.ReadOnly = True
        Me.estado_a.Visible = False
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "N°"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 40
        '
        'id_asiento_apertura
        '
        Me.id_asiento_apertura.DataPropertyName = "id_asiento_apertura"
        Me.id_asiento_apertura.HeaderText = "id_asiento_apertura"
        Me.id_asiento_apertura.Name = "id_asiento_apertura"
        Me.id_asiento_apertura.ReadOnly = True
        Me.id_asiento_apertura.Visible = False
        '
        'cuenta
        '
        Me.cuenta.DataPropertyName = "cuenta"
        Me.cuenta.HeaderText = "Cuenta"
        Me.cuenta.Name = "cuenta"
        Me.cuenta.ReadOnly = True
        Me.cuenta.Width = 60
        '
        'debe
        '
        Me.debe.DataPropertyName = "debe"
        Me.debe.HeaderText = "Debe"
        Me.debe.Name = "debe"
        Me.debe.ReadOnly = True
        Me.debe.Width = 70
        '
        'haber
        '
        Me.haber.DataPropertyName = "haber"
        Me.haber.HeaderText = "Haber"
        Me.haber.Name = "haber"
        Me.haber.ReadOnly = True
        Me.haber.Width = 70
        '
        'glosa
        '
        Me.glosa.DataPropertyName = "glosa"
        Me.glosa.HeaderText = "Glosa"
        Me.glosa.Name = "glosa"
        Me.glosa.ReadOnly = True
        Me.glosa.Width = 178
        '
        'moneda
        '
        Me.moneda.DataPropertyName = "moneda"
        Me.moneda.HeaderText = "Moneda"
        Me.moneda.Name = "moneda"
        Me.moneda.ReadOnly = True
        Me.moneda.Width = 50
        '
        'tipo_cambio
        '
        Me.tipo_cambio.DataPropertyName = "tipo_cambio"
        Me.tipo_cambio.HeaderText = "T. C."
        Me.tipo_cambio.Name = "tipo_cambio"
        Me.tipo_cambio.ReadOnly = True
        Me.tipo_cambio.Width = 70
        '
        'nom_doc
        '
        Me.nom_doc.DataPropertyName = "nom_doc"
        Me.nom_doc.HeaderText = "Documento"
        Me.nom_doc.Name = "nom_doc"
        Me.nom_doc.ReadOnly = True
        Me.nom_doc.Width = 80
        '
        'num_doc
        '
        Me.num_doc.DataPropertyName = "num_doc"
        Me.num_doc.HeaderText = "N° Doc"
        Me.num_doc.Name = "num_doc"
        Me.num_doc.ReadOnly = True
        Me.num_doc.Width = 80
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(632, 12)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(140, 35)
        Me.btnNuevo.TabIndex = 204
        Me.btnNuevo.Text = "Nuevo asiento"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'frmListaAsientoApertura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 459)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgvDetalleAsiento)
        Me.Controls.Add(Me.dgvListaAsientos)
        Me.Name = "frmListaAsientoApertura"
        Me.Text = "Lista de Asientos de Apertura registrados"
        CType(Me.dgvListaAsientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalleAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvListaAsientos As System.Windows.Forms.DataGridView
    Friend WithEvents dgvDetalleAsiento As System.Windows.Forms.DataGridView
    Friend WithEvents id_a As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_asiento_a As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents glosa_a As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero_a As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_debe_s As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_haber_s As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents diferencia_s As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents periodo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_a As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado_a As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_asiento_apertura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents glosa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents moneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_cambio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nom_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents num_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
End Class
