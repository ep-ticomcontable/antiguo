Imports Negocio

Public Class frmBancosConfiguracion
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
    Private Sub cargarBancos()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "SELECCIONE")
        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select * from bancos where estado=1 order by nombre asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboBancos
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar los usuarios")
        End Try
    End Sub
    Private Sub cargarMonedas()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "SELECCIONE")
        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select * from tipo_moneda where estado=1 order by codigo asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, "(" & row.Item(1).ToString & ") " & row.Item(2).ToString)
            Next
            With cboMoneda
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
        data = obj.nCrudListarBD("select bc.id,b.nombre as 'banco', '(' + m.codigo + ') ' +  m.descripcion as 'moneda',bc.cuenta_corriente as 'corriente', bc.cuenta,bc.estado from bancos_configuracion bc inner join bancos b on bc.id_banco=b.id inner join tipo_moneda m on bc.id_moneda=m.id order by bc.id asc", CadenaConexion)
        dgvLista.DataSource = data
        data = Nothing
        cargaInicialEstados()
    End Sub
    Private Sub frmTsClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLista.RowTemplate.Height = 30
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        cargarDatos()
        cargarBancos()
        cargarMonedas()
        ind_carga = 1
        txtDato.Focus()
        txtDato.Select()
    End Sub
    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtCuenta.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "bancoConf"
                    .cuentaInicio = txtCuenta.Text.Trim
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
            sql = "select * from bancos_configuracion where id=" & codigoCeldaSeleccionada()
            Dim data As New DataTable
            data = obj.nCrudListarBD(sql, CadenaConexion)
            With data
                cboBancos.SelectedValue = .Rows(0)("id_banco").ToString
                cboMoneda.SelectedValue = .Rows(0)("id_moneda").ToString
                txtCuentaCorriente.Text = .Rows(0)("cuenta_corriente").ToString
                txtCuenta.Text = .Rows(0)("cuenta").ToString
                lblCuenta.Text = obtenerDatosCuenta(.Rows(0)("cuenta").ToString)
                If .Rows(0)("estado") = "0" Then
                    rbNo.Checked = True
                ElseIf .Rows(0)("estado") = "1" Then
                    rbSi.Checked = True
                End If
            End With
            data = Nothing
            Me.Enabled = True
        ElseIf tipo = "new" Then
            txtCuentaCorriente.Focus()
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
        cboBancos.SelectedValue = 0
        cboMoneda.SelectedValue = 0
        txtCuentaCorriente.Text = ""
        txtCuenta.Text = ""
        lblCuenta.Text = "CUENTA..."
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
        campos = "id_banco@id_moneda@cuenta_corriente@cuenta@estado"
        valores = cboBancos.SelectedValue.ToString & "@" & cboMoneda.SelectedValue.ToString & "@" & txtCuentaCorriente.Text.ToString & "@" & txtCuenta.Text.Trim & "@" & estado

        Dim rpta As String = ""
        Dim tabla As String = "bancos_configuracion"
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
        data = obj.nCrudListarBD("select bc.id,b.nombre as 'banco', '(' + m.codigo + ') ' + m.descripcion as 'moneda',bc.cuenta_corriente as 'corriente', bc.cuenta,bc.estado from bancos_configuracion bc inner join bancos b on bc.id_banco=b.id inner join tipo_moneda m on bc.id_moneda=m.id where b.nombre like '%" & dato & "%' or m.descripcion like '%" & dato & "%'  or bc.cuenta_corriente like '%" & dato & "%' order by bc.id asc", CadenaConexion)
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
