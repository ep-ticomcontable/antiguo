Imports Negocio

Public Class frmTsClientes
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

    Private Sub comboDepartamentos()
        Dim tbDepartamento As New DataTable
        tbDepartamento.Columns.Add("Codigo")
        tbDepartamento.Columns.Add("Nombre")
        tbDepartamento.Rows.Add(0, "Seleccione")
        Dim tbDepartamento2 As DataTable
        Try
            tbDepartamento2 = obj.nCrudListarBD("select * from departamento", CadenaConexion)
            For Each row As DataRow In tbDepartamento2.Rows
                tbDepartamento.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboDepartamento
                .DataSource = tbDepartamento
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With
            tbDepartamento2.Dispose()
        Catch ex As Exception
            MsgBox("Error en la carga de Departamentos")
            Exit Sub
        End Try
    End Sub
    Private Sub comboProvincia(ByVal codDepa As Integer)
        If codDepa <> 0 And cboDepartamento.SelectedValue IsNot Nothing Then
            Dim tbProvincia As New DataTable
            tbProvincia.Columns.Add("Codigo")
            tbProvincia.Columns.Add("Nombre")
            tbProvincia.Rows.Add(0, "Seleccione")
            Dim tbProvincia2 As DataTable
            Try
                tbProvincia2 = obj.nCrudListarBD("select * from provincia where coddepartamento='" & codDepa & "'", CadenaConexion)
                For Each row As DataRow In tbProvincia2.Rows
                    tbProvincia.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
                Next
                With cboProvincia
                    .DataSource = tbProvincia
                    .ValueMember = "Codigo"
                    .DisplayMember = "Nombre"
                End With
                cboProvincia.Focus()
                tbProvincia2.Dispose()
            Catch ex As Exception
                MsgBox("Error en la carga de Provincias")
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub comboDistrito(ByVal codDist As Integer)
        If codDist <> 0 And cboDepartamento.SelectedValue IsNot Nothing And cboProvincia.SelectedValue IsNot Nothing Then
            Dim tbDistritos As New DataTable
            tbDistritos.Columns.Add("Codigo")
            tbDistritos.Columns.Add("Nombre")
            tbDistritos.Rows.Add(0, "Seleccione")
            Dim tbDistritos2 As DataTable
            Try
                tbDistritos2 = obj.nCrudListarBD("select * from distrito where codprovincia='" & codDist & "'", CadenaConexion)
                For Each row As DataRow In tbDistritos2.Rows
                    tbDistritos.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
                Next
                With cboDistrito
                    .DataSource = tbDistritos
                    .ValueMember = "Codigo"
                    .DisplayMember = "Nombre"
                End With
                cboProvincia.Focus()
                tbDistritos2.Dispose()
            Catch ex As Exception
                MsgBox("Error en la carga de Distritos")
                Exit Sub
            End Try
        End If
    End Sub

#End Region

    Private Sub cargarDatos()
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from vista_clientes order by nombre asc", CadenaConexion)
        dgvLista.DataSource = data
        data = Nothing
        cargaInicialEstados()
    End Sub

    Private Sub frmTsClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
        comboDepartamentos()
        cboDepartamento.SelectedValue = 15
        ind_carga = 1

        If ind_carga = 1 Then
            comboProvincia(15)
            cboProvincia.SelectedValue = 128
            ind_carga = 2
        End If
        If ind_carga = 2 Then
            comboDistrito(128)
            cboDistrito.SelectedValue = 1248
        End If
        txtDato.Focus()
        txtDato.Select()
    End Sub

    Private Sub dgvLista_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLista.SelectionChanged
        cargarDatosCuenta()
    End Sub


    Private Sub cboDepartamento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepartamento.SelectedIndexChanged
        Try
            'If ind_carga = 1 Then
            'MsgBox(Integer.Parse(cboDepartamento.SelectedValue.ToString))
            comboProvincia(Integer.Parse(cboDepartamento.SelectedValue.ToString))
            ind_carga = 2
            'End If
        Catch ex As Exception
            comboProvincia(15)
            ind_carga = 2
        End Try
    End Sub

    Private Sub cboProvincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProvincia.SelectedIndexChanged
        If ind_carga = 2 Then
            comboDistrito(Integer.Parse(cboProvincia.SelectedValue.ToString))
        End If
    End Sub

    Private Sub cargarDatosCuenta()
        If tipo <> "new" Or tipo = "" Then
            Me.Enabled = False
            On Error Resume Next
            Dim sql As String
            sql = "select * from clientes where id=" & codigoCeldaSeleccionada()
            Dim data As New DataTable
            data = obj.nCrudListarBD(sql, CadenaConexion)
            With data
                txtNombre.Text = .Rows(0)("nombre").ToString
                txtApePaterno.Text = .Rows(0)("ape_paterno").ToString
                txtApeMaterno.Text = .Rows(0)("ape_materno").ToString
                txtTelefono.Text = .Rows(0)("telefonos").ToString
                txtCelular.Text = .Rows(0)("celulares").ToString
                dtpFechaNacimento.Value = .Rows(0)("fec_nacimiento").ToString
                txtRuc.Text = .Rows(0)("ruc").ToString
                txtRazonSocial.Text = .Rows(0)("razon_social").ToString
                txtDni.Text = .Rows(0)("dni").ToString
                txtNomComercial.Text = .Rows(0)("nom_comercial").ToString
                txtDireccion.Text = .Rows(0)("direccion").ToString
                txtCorreos.Text = .Rows(0)("correos").ToString
                cboDepartamento.SelectedValue = .Rows(0)("departamento").ToString
                cboProvincia.SelectedValue = .Rows(0)("provincia").ToString
                cboDistrito.SelectedValue = .Rows(0)("distrito").ToString

                If .Rows(0)("estado") = "0" Then
                    rbNo.Checked = True
                ElseIf .Rows(0)("estado") = "1" Then
                    rbSi.Checked = True
                End If
            End With
            data = Nothing
            Me.Enabled = True
        ElseIf tipo = "new" Then
            txtDni.Focus()
        End If
        cargaInicialEstados()
    End Sub

    Private Sub frmTsTipoPago_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            cargarDatos()
        End If
    End Sub

    Private Sub txtDato_TextChanged(sender As Object, e As EventArgs) Handles txtDato.TextChanged
        'If txtDato.Text.Length > 2 Then

        'End If
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
        txtDni.Text = ""
        txtNombre.Text = ""
        txtDireccion.Text = ""
        rbSi.Checked = True
        txtDni.Focus()
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

        campos = "dni_ruc@nombre@direccion@estado"
        valores = txtDni.Text.ToString & "@" & txtNombre.Text.ToString & "@" & txtDireccion.Text.ToString & "@" & estado

        Dim rpta As String = ""
        Dim tabla As String = "proveedores"
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
                If row.Cells("estado").Value.ToString = "INACTIVO" Then
                    row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(255, 87, 87) '(245, 230, 108)
                ElseIf row.Cells("estado").Value.ToString = "ACTIVO" Then
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
        data = obj.nCrudListarBD("select * from vista_clientes where nombre like '%" & dato & "%' or dni like '%" & dato & "%'  or ruc like '%" & dato & "%' order by nombre asc", CadenaConexion)
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
