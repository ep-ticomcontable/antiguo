Imports Negocio

Public Class frmTsUbigeo
    Dim obj As New nCrud
    Dim tipo As String = ""
    Dim iCarga As Integer = 0

    Private Function codigoCeldaSeleccionada() As Integer
        Dim c As String
        Try
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            c = dgvLista.Rows(f).Cells("id_dis").Value.ToString
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function

    Private Sub cargarDepartamentos()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select * from departamento order by nomdepartamento", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboDepartamento
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar Monedas")
        End Try
    End Sub

    Private Sub cargarProvincias()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select * from provincia order by nom_provincia", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboProvincia
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar Monedas")
        End Try
    End Sub

    Private Sub cargarDistritos()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select * from distrito order by nom_distrito", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboDistrito
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar Monedas")
        End Try
    End Sub

    Private Sub cargarDatos()
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from vista_ubigeo order by n_dep asc", CadenaConexion)
        dgvLista.DataSource = data
        data = Nothing
        cargaInicialEstados()
    End Sub

    Private Sub frmTsTipoPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDepartamentos()
        cargarProvincias()
        cargarDistritos()
        cargarDatos()
        txtDato.Focus()
        txtDato.Select()
        iCarga = 1
    End Sub

    Private Sub dgvLista_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLista.SelectionChanged
        cargarDatosCuenta()
    End Sub

    Private Sub cargarDatosCuenta()
        If tipo <> "new" Or tipo = "" Then
            Me.Enabled = False
            On Error Resume Next
            Dim sql As String
            sql = "select * from vista_ubigeo where id_dis=" & codigoCeldaSeleccionada()
            Dim data As New DataTable
            data = obj.nCrudListarBD(sql, CadenaConexion)
            With data
                cboDepartamento.SelectedValue = .Rows(0)("id_dep")
                cboProvincia.SelectedValue = .Rows(0)("id_pro")
                cboDistrito.SelectedValue = .Rows(0)("id_dis")
                'txtDescripcion.Text = .Rows(0)("valor")

                If .Rows(0)("estado") = "INACTIVO" Then
                    rbNo.Checked = True
                ElseIf .Rows(0)("estado") = "ACTIVO" Then
                    rbSi.Checked = True
                End If
            End With
            data = Nothing
            Me.Enabled = True
        ElseIf tipo = "new" Then
            'txtDescripcion.Focus()
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
        Dim data As New DataTable
        Dim dato As String = ""
        dato = txtDato.Text.ToString.Trim()
        data = obj.nCrudListarBD("select * from vista_moneda_tipo_cambio where moneda like '%" & dato & "%'", CadenaConexion)
        dgvLista.DataSource = data
        cargaInicialEstados()
        'End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        gbGrupo.Enabled = True
        tipo = "update"
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        gbGrupo.Enabled = True
        tipo = "new"
        'limpiarEntradas()
    End Sub

    Private Sub limpiarEntradas()
        cboDepartamento.SelectedValue = 0
        cboProvincia.SelectedValue = 0
        cboDistrito.SelectedValue = 0
        rbSi.Checked = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        gbGrupo.Enabled = False
        cargarDatosCuenta()
    End Sub

    'Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    '    Dim campos As String
    '    Dim valores As String
    '    Dim condicion As String
    '    Dim estado As String

    '    If rbNo.Checked = True Then
    '        estado = "0"
    '    Else
    '        estado = "1"
    '    End If

    '    campos = "id_moneda@valor@estado"
    '    valores = cboMoneda.SelectedValue.ToString & "@" & txtDescripcion.Text.ToString & "@" & estado
    '    Dim rpta As String = ""
    '    Dim tabla As String = "tipo_cambio"
    '    If tipo = "update" Then
    '        condicion = "id=" & codigoCeldaSeleccionada()
    '        rpta = obj.nCrudActualizar("@", tabla, campos, valores, condicion)
    '    ElseIf tipo = "new" Then
    '        rpta = obj.nCrudInsertar("@", tabla, campos, valores)
    '    End If

    '    If rpta = "ok" Then
    '        MessageBox.Show("El proceso se ha realizado con éxito.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    '        gbGrupo.Enabled = False
    '        limpiarEntradas()
    '        cargarDatos()
    '        txtDato.Focus()
    '    Else
    '        MessageBox.Show(rpta, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
    '    End If
    'End Sub

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

    Private Sub cboDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepartamento.SelectedIndexChanged
        If iCarga = 1 Then
            Dim data As New DataTable
            data.Columns.Add("Codigo")
            data.Columns.Add("Descripcion")
            data.Rows.Add(0, "Seleccione")
            Dim data2 As DataTable
            Try
                data2 = obj.nCrudListarBD("select * from provincia where coddepartamento='" & cboDepartamento.SelectedValue.ToString & "'", CadenaConexion)
                For Each row As DataRow In data2.Rows
                    data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
                Next
                With cboProvincia
                    .DataSource = data
                    .ValueMember = "Codigo"
                    .DisplayMember = "Descripcion"
                End With
                data2.Dispose()
            Catch ex As Exception
                MsgBox("No se pudo cargar Provincia")
            End Try
        End If
    End Sub

    Private Sub cboProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProvincia.SelectedIndexChanged
        If iCarga = 1 Then
            Dim data As New DataTable
            data.Columns.Add("Codigo")
            data.Columns.Add("Descripcion")
            data.Rows.Add(0, "Seleccione")
            Dim data2 As DataTable
            Try
                data2 = obj.nCrudListarBD("select * from distrito where codprovincia='" & cboProvincia.SelectedValue.ToString & "' order by nom_distrito", CadenaConexion)
                For Each row As DataRow In data2.Rows
                    data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
                Next
                With cboDistrito
                    .DataSource = data
                    .ValueMember = "Codigo"
                    .DisplayMember = "Descripcion"
                End With
                data2.Dispose()
            Catch ex As Exception
                MsgBox("No se pudo cargar Distritos")
            End Try
        End If
    End Sub
End Class