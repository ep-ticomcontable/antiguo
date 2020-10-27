<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
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
        Me.dgvListaEmpresa = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ruc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGuardarEmpresa = New System.Windows.Forms.Button()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvListaUsuario = New System.Windows.Forms.DataGridView()
        Me.id_user = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGuardarUsuario = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPlanContable = New System.Windows.Forms.Button()
        Me.tvEmpresas = New System.Windows.Forms.TreeView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboUsuarios = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAsignar = New System.Windows.Forms.Button()
        CType(Me.dgvListaEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListaUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListaEmpresa
        '
        Me.dgvListaEmpresa.AllowUserToAddRows = False
        Me.dgvListaEmpresa.AllowUserToDeleteRows = False
        Me.dgvListaEmpresa.AllowUserToOrderColumns = True
        Me.dgvListaEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaEmpresa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nombre, Me.direccion, Me.ruc})
        Me.dgvListaEmpresa.Location = New System.Drawing.Point(405, 45)
        Me.dgvListaEmpresa.Name = "dgvListaEmpresa"
        Me.dgvListaEmpresa.ReadOnly = True
        Me.dgvListaEmpresa.Size = New System.Drawing.Size(385, 169)
        Me.dgvListaEmpresa.TabIndex = 7
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 60
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.HeaderText = "direccion"
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        '
        'ruc
        '
        Me.ruc.DataPropertyName = "ruc"
        Me.ruc.HeaderText = "ruc"
        Me.ruc.Name = "ruc"
        Me.ruc.ReadOnly = True
        Me.ruc.Width = 60
        '
        'btnGuardarEmpresa
        '
        Me.btnGuardarEmpresa.Location = New System.Drawing.Point(705, 16)
        Me.btnGuardarEmpresa.Name = "btnGuardarEmpresa"
        Me.btnGuardarEmpresa.Size = New System.Drawing.Size(85, 23)
        Me.btnGuardarEmpresa.TabIndex = 6
        Me.btnGuardarEmpresa.Text = "GUARDAR"
        Me.btnGuardarEmpresa.UseVisualStyleBackColor = True
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Location = New System.Drawing.Point(558, 18)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(132, 20)
        Me.txtEmpresa.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(406, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "NOMBRE DE LA EMPRESA:"
        '
        'dgvListaUsuario
        '
        Me.dgvListaUsuario.AllowUserToAddRows = False
        Me.dgvListaUsuario.AllowUserToDeleteRows = False
        Me.dgvListaUsuario.AllowUserToOrderColumns = True
        Me.dgvListaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_user, Me.usuario, Me.clave, Me.tipo})
        Me.dgvListaUsuario.Location = New System.Drawing.Point(12, 45)
        Me.dgvListaUsuario.Name = "dgvListaUsuario"
        Me.dgvListaUsuario.ReadOnly = True
        Me.dgvListaUsuario.Size = New System.Drawing.Size(376, 169)
        Me.dgvListaUsuario.TabIndex = 11
        '
        'id_user
        '
        Me.id_user.DataPropertyName = "id"
        Me.id_user.HeaderText = "id"
        Me.id_user.Name = "id_user"
        Me.id_user.ReadOnly = True
        Me.id_user.Width = 50
        '
        'usuario
        '
        Me.usuario.DataPropertyName = "usuario"
        Me.usuario.HeaderText = "usuario"
        Me.usuario.Name = "usuario"
        Me.usuario.ReadOnly = True
        '
        'clave
        '
        Me.clave.DataPropertyName = "clave"
        Me.clave.HeaderText = "clave"
        Me.clave.Name = "clave"
        Me.clave.ReadOnly = True
        '
        'tipo
        '
        Me.tipo.DataPropertyName = "tipo"
        Me.tipo.HeaderText = "tipo"
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        Me.tipo.Width = 60
        '
        'btnGuardarUsuario
        '
        Me.btnGuardarUsuario.Location = New System.Drawing.Point(303, 16)
        Me.btnGuardarUsuario.Name = "btnGuardarUsuario"
        Me.btnGuardarUsuario.Size = New System.Drawing.Size(85, 23)
        Me.btnGuardarUsuario.TabIndex = 10
        Me.btnGuardarUsuario.Text = "GUARDAR"
        Me.btnGuardarUsuario.UseVisualStyleBackColor = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(78, 18)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(219, 20)
        Me.txtUsuario.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "USUARIO:"
        '
        'btnPlanContable
        '
        Me.btnPlanContable.Location = New System.Drawing.Point(695, 220)
        Me.btnPlanContable.Name = "btnPlanContable"
        Me.btnPlanContable.Size = New System.Drawing.Size(95, 23)
        Me.btnPlanContable.TabIndex = 12
        Me.btnPlanContable.Text = "Plan contable"
        Me.btnPlanContable.UseVisualStyleBackColor = True
        '
        'tvEmpresas
        '
        Me.tvEmpresas.CheckBoxes = True
        Me.tvEmpresas.Location = New System.Drawing.Point(405, 246)
        Me.tvEmpresas.Name = "tvEmpresas"
        Me.tvEmpresas.Size = New System.Drawing.Size(284, 192)
        Me.tvEmpresas.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(402, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Empresas asignadas:"
        '
        'cboUsuarios
        '
        Me.cboUsuarios.FormattingEnabled = True
        Me.cboUsuarios.Location = New System.Drawing.Point(221, 246)
        Me.cboUsuarios.Name = "cboUsuarios"
        Me.cboUsuarios.Size = New System.Drawing.Size(167, 21)
        Me.cboUsuarios.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(218, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Usuarios:"
        '
        'btnAsignar
        '
        Me.btnAsignar.Location = New System.Drawing.Point(695, 415)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(113, 23)
        Me.btnAsignar.TabIndex = 17
        Me.btnAsignar.Text = "Asignar empresas"
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 450)
        Me.Controls.Add(Me.btnAsignar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboUsuarios)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tvEmpresas)
        Me.Controls.Add(Me.btnPlanContable)
        Me.Controls.Add(Me.dgvListaUsuario)
        Me.Controls.Add(Me.btnGuardarUsuario)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvListaEmpresa)
        Me.Controls.Add(Me.btnGuardarEmpresa)
        Me.Controls.Add(Me.txtEmpresa)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[Datos Empresa]"
        CType(Me.dgvListaEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListaUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListaEmpresa As System.Windows.Forms.DataGridView
    Friend WithEvents btnGuardarEmpresa As System.Windows.Forms.Button
    Friend WithEvents txtEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvListaUsuario As System.Windows.Forms.DataGridView
    Friend WithEvents btnGuardarUsuario As System.Windows.Forms.Button
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ruc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_user As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clave As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPlanContable As System.Windows.Forms.Button
    Friend WithEvents tvEmpresas As System.Windows.Forms.TreeView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboUsuarios As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAsignar As System.Windows.Forms.Button
End Class
