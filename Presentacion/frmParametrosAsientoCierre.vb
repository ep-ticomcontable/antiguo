Imports Negocio

Public Class frmParametrosAsientoCierre
    Dim obj As New nCrud
    Dim ind_carga As Integer = 0
    Dim tipo As String = ""
    Dim dataAsientos As New DataTable

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
    Private Sub cargarOperaciones()
        Dim data As New DataTable
        data.Columns.Add("valor")
        data.Rows.Add("SALDO")
        data.Rows.Add("TRANSFERENCIA")
        data.Rows.Add("OMITIR")
        With cboOperacion
            .DataSource = data
            .ValueMember = "valor"
            .DisplayMember = "valor"
        End With
    End Sub
    Private Sub cargarExclusiones()
        Dim data As New DataTable
        data.Columns.Add("valor")
        data.Columns.Add("descripcion")
        data.Rows.Add(0, "NO")
        data.Rows.Add(1, "SI")
        With cboExcluir
            .DataSource = data
            .ValueMember = "valor"
            .DisplayMember = "descripcion"
        End With
    End Sub
   
#End Region

    Private Sub cargarDatos()
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from cabecera_asiento_cierre order by id asc", CadenaConexion)
        dgvLista.DataSource = data
        data = Nothing
        cargaInicialEstados()
    End Sub
    Private Sub frmParametrosAsientoCierre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLista.RowTemplate.Height = 30
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        cargarDatos()
        cargarOperaciones()
        cargarExclusiones()
        ind_carga = 1
        cargarDatosCuenta()
        txtDato.Focus()
        txtDato.Select()
    End Sub
    Private Sub txtCuenta1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtCuenta1.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "AC1"
                    .cuentaInicio = txtCuenta1.Text.Trim
                    .ShowDialog()
                    txtCuenta2.Focus()
                    txtCuenta2.Select()
                End With
            End If
        End If
    End Sub
    Private Sub txtCuenta2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta2.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtCuenta2.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "AC2"
                    .cuentaInicio = txtCuenta2.Text.Trim
                    .ShowDialog()
                End With
            End If
            btnAgregar.Focus()
        End If
    End Sub
    Private Sub dgvLista_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLista.SelectionChanged
        cargarDatosCuenta()
    End Sub
    Private Sub cargarDatosCuenta()
        If tipo <> "new" Or tipo = "" Then
            Me.Enabled = False
            On Error Resume Next

            Dim sqlC As String
            sqlC = "select * from cabecera_asiento_cierre where id=" & codigoCeldaSeleccionada()
            Dim sql As String
            sql = "select  CASE WHEN exclusion = '0' THEN 'NO' ELSE 'SI' END AS exclusion,cuenta,contra_cuenta from parametros_asiento_cierre where id_cac=" & codigoCeldaSeleccionada()
            Dim dataC As New DataTable
            dataC = obj.nCrudListarBD(sqlC, CadenaConexion)
            With dataC
                txtDescripcion.Text = .Rows(0)("descripcion").ToString
                cboOperacion.Text = .Rows(0)("operacion").ToString
            End With

            Dim data As New DataTable
            data = obj.nCrudListarBD(sql, CadenaConexion)
            dgvCuentas.DataSource = data
            cboOperacion.SelectedValue = dataC.Rows(0)("opeacion").ToString
            If dataC.Rows(0)("estado") = "0" Then
                rbNo.Checked = True
            ElseIf dataC.Rows(0)("estado") = "1" Then
                rbSi.Checked = True
            End If
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
        txtCuenta1.Text = ""
        lblCuenta1.Text = "CUENTA..."
        txtCuenta2.Text = ""
        lblCuenta2.Text = "CUENTA..."
        cboExcluir.SelectedValue = 0
        rbSi.Checked = True
        Dim dtDataN As New DataTable
        With dtDataN.Columns
            .Add("exclusion")
            .Add("cuenta")
            .Add("contra_cuenta")
        End With
        dataAsientos.Rows.Clear()
        dgvCuentas.DataSource = dtDataN
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
        campos = "descripcion@operacion@estado"
        valores = txtDescripcion.Text.ToString & "@" & cboOperacion.SelectedValue.ToString & "@" & estado

        Dim rpta As String = ""
        Dim rpta2 As String = ""
        Dim tabla As String = "cabecera_asiento_cierre"
        If tipo = "update" Then
            condicion = "id=" & codigoCeldaSeleccionada()
            rpta = obj.nCrudActualizarBD("@", tabla, campos, valores, condicion, CadenaConexion)
            obj.nEjecutarQueryBD("delete from parametros_asiento_cierre where id_cac='" & codigoCeldaSeleccionada() & "'", CadenaConexion)
        ElseIf tipo = "new" Then
            rpta = obj.nCrudInsertarBD("@", tabla, campos, valores, CadenaConexion)
        End If

        If rpta = "ok" Then
            Dim dt As New DataTable
            dt = obj.nCrudListarBD("select top 1 * from cabecera_asiento_cierre order by id desc", CadenaConexion)
            campos = "id_cac@exclusion@cuenta@contra_cuenta"
            Dim ID As String = "0"
            If tipo = "update" Then
                ID = codigoCeldaSeleccionada()
            Else
                ID = dt.Rows(0)("id").ToString
            End If
            For Each row As DataGridViewRow In dgvCuentas.Rows
                valores = ID & "@" & cboExcluir.SelectedValue.ToString & "@" & row.Cells("cuenta").Value.ToString & "@" & row.Cells("contra_cuenta").Value.ToString
                rpta2 = obj.nCrudInsertarBD("@", "parametros_asiento_cierre", campos, valores, CadenaConexion)
                If rpta2 <> "ok" Then
                    MsgBox("Error al registrar las cuentas: " & rpta2)
                    Exit For
                End If
            Next
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
        data = obj.nCrudListarBD("select * from cabecera_asiento_cierre where operacion like '%" & dato & "%'  or descripcion like '%" & dato & "%' order by id asc", CadenaConexion)
        dgvLista.DataSource = data
        cargaInicialEstados()
    End Sub

    Private Sub txtDato_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDato.KeyPress
        On Error Resume Next
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            realizarBusqueda()
        End If
    End Sub

    Private Sub cboOperacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOperacion.SelectedIndexChanged
        If ind_carga = 1 Then
            If cboOperacion.SelectedValue.ToString.StartsWith("OMI") Then
                cboExcluir.SelectedValue = 1
                txtCuenta2.Text = "-"
                txtCuenta2.Enabled = False
            Else
                cboExcluir.SelectedValue = 0
                txtCuenta2.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim dtData2 As New DataTable
        With dtData2.Columns
            .Add("exclusion")
            .Add("cuenta")
            .Add("contra_cuenta")
        End With

        If dgvCuentas.RowCount = 0 Then
            dtData2.Rows.Add(IIf(cboExcluir.SelectedValue.ToString = "0", "NO", "SI"), txtCuenta1.Text.Trim, txtCuenta2.Text.Trim)
            dataAsientos.Merge(dtData2)
            dgvCuentas.DataSource = dataAsientos
        Else
            Dim dtI As DataTable = DirectCast(dgvCuentas.DataSource, DataTable)
            Dim row As DataRow = dtI.NewRow()
            row.Item(0) = IIf(cboExcluir.SelectedValue.ToString = "0", "NO", "SI")
            row.Item(1) = txtCuenta1.Text.Trim
            row.Item(2) = txtCuenta2.Text.Trim
            dtI.Rows.Add(row)
        End If
        For i As Integer = 0 To dgvCuentas.Rows.Count - 1
            For x As Integer = 0 To dgvCuentas.ColumnCount - 1
                If dgvCuentas.Rows(i).Cells("cuenta").Value.ToString = txtCuenta1.Text.Trim Then
                    dgvCuentas.CurrentCell = dgvCuentas.Rows(i).Cells("cuenta")
                End If
            Next
        Next
        txtCuenta1.Focus()
        txtCuenta2.SelectAll()
    End Sub

    Private Sub lblTituloForm_Click(sender As Object, e As EventArgs) Handles lblTituloForm.Click
        frmParametroLibroMayor.Show()
    End Sub

End Class
