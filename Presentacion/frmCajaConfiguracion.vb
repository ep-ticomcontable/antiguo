Imports Negocio

Public Class frmCajaConfiguracion
    Dim obj As New nCrud
    Dim ind_carga As Integer = 0
    Dim tipo As String = ""

    Private Function codigoCeldaSeleccionada() As Integer
        Dim c As String
        Try
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            c = dgvLista.Rows(f).Cells("id").Value.ToString
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function

#Region "Carga de Combos"
    Private Sub cargarTipo()
        Dim data As New DataTable
        data.Columns.Add("valor")
        data.Rows.Add("PRINCIPAL")
        data.Rows.Add("CHICA")
        data.Rows.Add("BANCOS")
        With cboTipo
            .DataSource = data
            .ValueMember = "valor"
            .DisplayMember = "valor"
        End With
    End Sub
    Private Sub cargarUsuarios()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "SELECCIONE")
        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select * from usuarios order by id asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboUsuario
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar los usuarios")
        End Try
    End Sub
#End Region

    Private Sub cargarDatos()
        Dim data As New DataTable
        data = obj.nCrudListarBD("select cg.id,cg.tipo,cg.descripcion,cg.direccion,u.usuario,cg.cuenta,cg.contra_cuenta,cg.estado from caja_configuracion cg inner join usuarios u on cg.id_usuario=u.id order by cg.id asc", CadenaConexion)
        dgvLista.DataSource = data
        data = Nothing
        cargaInicialEstados()
    End Sub
    Private Sub frmTsClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLista.RowTemplate.Height = 30
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        cargarDatos()
        cargarTipo()
        cargarUsuarios()
        ind_carga = 1
        txtDato.Focus()
        txtDato.Select()
    End Sub
    Private Sub txtCuenta1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtCuenta1.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "cajaConf1"
                    .cuentaInicio = txtCuenta1.Text.Trim
                    .ShowDialog()
                End With
            End If
        End If
    End Sub
    Private Sub txtCuenta2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta2.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtCuenta2.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "cajaConf2"
                    .cuentaInicio = txtCuenta2.Text.Trim
                    .ShowDialog()
                End With
            End If
        End If
    End Sub
    Private Sub dgvLista_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLista.SelectionChanged
        cargarDatosCuenta()
    End Sub
    Private Sub cargarDatosCuenta()
        If tipo <> "new" Or tipo = "" Then
            Me.Enabled = False
            On Error Resume Next
            Dim sql As String
            sql = "select * from caja_configuracion where id=" & codigoCeldaSeleccionada()
            Dim data As New DataTable
            data = obj.nCrudListarBD(sql, CadenaConexion)
            With data
                txtDescripcion.Text = .Rows(0)("descripcion").ToString
                txtCuenta1.Text = .Rows(0)("cuenta").ToString
                lblCuenta1.Text = obtenerDatosCuenta(.Rows(0)("cuenta").ToString)
                txtCuenta2.Text = .Rows(0)("contra_cuenta").ToString
                lblCuenta2.Text = obtenerDatosCuenta(.Rows(0)("contra_cuenta").ToString)
                txtDireccion.Text = .Rows(0)("direccion").ToString
                cboTipo.SelectedValue = .Rows(0)("tipo").ToString
                cboUsuario.SelectedValue = .Rows(0)("id_usuario").ToString
                If .Rows(0)("estado") = "0" Then
                    rbNo.Checked = True
                ElseIf .Rows(0)("estado") = "1" Then
                    rbSi.Checked = True
                End If
            End With
            data = Nothing
            Me.Enabled = True
        ElseIf tipo = "new" Then
            txtDescripcion.Focus()
        End If
        cargaInicialEstados()
    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = obj.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function
    Private Sub frmTsTipoPago_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            cargarDatos()
        End If
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        gbGrupo.Enabled = True
        tipo = "update"
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        gbGrupo.Enabled = True
        tipo = "new"
        limpiarEntradas()
    End Sub
    Private Sub limpiarEntradas()
        txtDescripcion.Text = ""
        txtDireccion.Text = ""
        txtCuenta1.Text = ""
        lblCuenta1.Text = "CUENTA..."
        txtCuenta2.Text = ""
        lblCuenta2.Text = "CUENTA..."
        cboUsuario.SelectedValue = 0
        rbSi.Checked = True
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        gbGrupo.Enabled = False
        cargarDatosCuenta()
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim campos As String
        Dim valores As String
        Dim condicion As String
        Dim estado As String
        If rbNo.Checked = True Then
            estado = "0"
        Else
            estado = "1"
        End If
        campos = "tipo@descripcion@direccion@cuenta@contra_cuenta@id_usuario@estado"
        valores = cboTipo.SelectedValue.ToString & "@" & txtDescripcion.Text.ToString & "@" & txtDireccion.Text.ToString & "@" & txtCuenta1.Text.Trim & "@" & txtCuenta2.Text.Trim & "@" & cboUsuario.SelectedValue.ToString & "@" & estado

        Dim rpta As String = ""
        Dim tabla As String = "caja_configuracion"
        If tipo = "update" Then
            condicion = "id=" & codigoCeldaSeleccionada()
            rpta = obj.nCrudActualizarBD("@", tabla, campos, valores, condicion, CadenaConexion)
        ElseIf tipo = "new" Then
            rpta = obj.nCrudInsertarBD("@", tabla, campos, valores, CadenaConexion)
        End If

        If rpta = "ok" Then
            MessageBox.Show("El proceso se ha realizado con éxito.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            gbGrupo.Enabled = False
            limpiarEntradas()
            cargarDatos()
            txtDato.Focus()
        Else
            MessageBox.Show(rpta, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub cargaInicialEstados()
        Try
            For Each row As DataGridViewRow In dgvLista.Rows
                If row.Cells("estado").Value.ToString = "0" Then
                    row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(255, 87, 87) '(245, 230, 108)
                ElseIf row.Cells("estado").Value.ToString = "1" Then
                    row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(255, 255, 255)
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        realizarBusqueda()
    End Sub
    Private Sub realizarBusqueda()
        Dim data As New DataTable
        Dim dato As String = ""
        dato = txtDato.Text.ToString.Trim()
        data = obj.nCrudListarBD("select cg.id,cg.tipo,cg.descripcion,cg.direccion,u.usuario,cg.cuenta,cg.contra_cuenta,cg.estado from caja_configuracion cg inner join usuarios u on cg.id_usuario=u.id  where u.usuario like '%" & dato & "%' or cg.tipo like '%" & dato & "%'  or cg.descripcion like '%" & dato & "%' order by cg.id asc", CadenaConexion)
        dgvLista.DataSource = data
        cargaInicialEstados()
    End Sub

    Private Sub txtDato_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDato.KeyPress
        On Error Resume Next
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            realizarBusqueda()
        End If
    End Sub
End Class
