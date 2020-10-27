Imports Negocio

Public Class frmTsCuentasTipoOperacion

    Dim obj As New nCrud
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

    Private Sub cargarTipoMovimiento()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(1, "DEBE")
        data.Rows.Add(2, "HABER")
        With cboTipo
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub
    Private Sub cargarTipoOperacion()
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from vista_tipo_operacion WHERE ESTADO='activo' order by codigo asc", CadenaConexion)
        dgvLista.DataSource = data
        data = Nothing
        cargaInicialEstados()
    End Sub

    Private Sub cargarCuentas()
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from vista_cuentaTipoOperacion where id_to='" & codigoCeldaSeleccionada() & "' order by id_pk asc", CadenaConexion)
        dgvCuentas.DataSource = data
        data = Nothing
    End Sub

    Private Sub frmTsTipoPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTipoOperacion()
        cargarCuentas()
        cargarTipoMovimiento()
        txtDato.Focus()
        txtDato.Select()
    End Sub

    Private Sub dgvLista_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLista.SelectionChanged
        cargarCuentas()
    End Sub


    Private Sub frmTsTipoPago_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            cargarTipoOperacion()
            cargarCuentas()
        End If
    End Sub

    Private Sub txtDato_TextChanged(sender As Object, e As EventArgs) Handles txtDato.TextChanged
        'If txtDato.Text.Length > 2 Then
        Dim data As New DataTable
        Dim dato As String = ""
        dato = txtDato.Text.ToString.Trim()
        data = obj.nCrudListarBD("select * from vista_tipo_operacion where descripcion like '%" & dato & "%' or codigo like '%" & dato & "%'  WHERE ESTADO='activo' order by descripcion asc", CadenaConexion)
        dgvLista.DataSource = data
        cargaInicialEstados()
        'End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        gbGrupo.Enabled = True
        tipo = "update"
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs)
        gbGrupo.Enabled = True
        tipo = "new"
        limpiarEntradas()
    End Sub

    Private Sub limpiarEntradas()
        txtCuenta.Text = ""
        'txtDescripcion.Text = ""
        txtCuenta.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        gbGrupo.Enabled = False
        cargarTipoOperacion()
        cargarCuentas()
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

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtCuenta.Text.Trim.Length > 2 Then
            If dgvCuentas.Rows.Count = 0 Then
                Dim dtItem As New DataTable
                With dtItem.Columns
                    .Add("id_pk")
                    .Add("id_to")
                    .Add("num_cuenta")
                    .Add("nom_cuenta")
                    .Add("debe")
                    .Add("haber")
                End With
                dtItem.Rows.Add(codigoCeldaSeleccionada, codigoCeldaSeleccionada, _
                                txtCuenta.Text.Trim, _
                                lblCuenta.Text.Trim, _
                                IIf((cboTipo.SelectedValue = "1"), "X", ""), _
                                IIf((cboTipo.SelectedValue = "2"), "X", ""))
                dgvCuentas.DataSource = dtItem
            Else
                Dim dt As DataTable = DirectCast(dgvCuentas.DataSource, DataTable)
                Dim row As DataRow = dt.NewRow()
                row.Item(0) = codigoCeldaSeleccionada()
                row.Item(1) = codigoCeldaSeleccionada()
                row.Item(2) = txtCuenta.Text.Trim
                row.Item(3) = lblCuenta.Text.Trim
                row.Item(4) = IIf((cboTipo.SelectedValue = "1"), "X", "")
                row.Item(5) = IIf((cboTipo.SelectedValue = "2"), "X", "")
                dt.Rows.Add(row)
            End If
        Else
            MsgBox("Ingrese el número de cuenta contable")
            txtCuenta.Focus()
        End If
        


    End Sub

    Private fromIndex As Integer
    Private dragIndex As Integer
    Private dragRect As Rectangle

    Private Sub dgvCuentas_DragDrop(sender As Object, e As DragEventArgs) Handles dgvCuentas.DragDrop

        Dim p As Point = dgvCuentas.PointToClient(New Point(e.X, e.Y))
        dragIndex = dgvCuentas.HitTest(p.X, p.Y).RowIndex
        If (e.Effect = DragDropEffects.Move) Then
            Dim dragRow As DataGridViewRow = e.Data.GetData(GetType(DataGridViewRow))
            dgvCuentas.Rows.RemoveAt(fromIndex)
            dgvCuentas.Rows.Insert(dragIndex, dragRow)
        End If
    End Sub

    Private Sub dgvCuentas_DragOver(ByVal sender As Object, _
                                   ByVal e As DragEventArgs) _
                                   Handles dgvCuentas.DragOver
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub dgvCuentas_MouseDown(ByVal sender As Object, _
                                    ByVal e As MouseEventArgs) _
                                    Handles dgvCuentas.MouseDown
        fromIndex = dgvCuentas.HitTest(e.X, e.Y).RowIndex
        If fromIndex > -1 Then
            Dim dragSize As Size = SystemInformation.DragSize
            dragRect = New Rectangle(New Point(e.X - (dragSize.Width / 2), _
                                               e.Y - (dragSize.Height / 2)), _
                                     dragSize)
        Else
            dragRect = Rectangle.Empty
        End If
    End Sub

    Private Sub dgvCuentas_MouseMove(ByVal sender As Object, _
                                        ByVal e As MouseEventArgs) _
                                        Handles dgvCuentas.MouseMove
        If (e.Button And MouseButtons.Left) = MouseButtons.Left Then
            If (dragRect <> Rectangle.Empty _
            AndAlso Not dragRect.Contains(e.X, e.Y)) Then
                dgvCuentas.DoDragDrop(dgvCuentas.Rows(fromIndex), _
                                         DragDropEffects.Move)
            End If
        End If
    End Sub

    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cargarCuentaContable()
        End If
    End Sub

    Private Sub btnCuenta_Click(sender As Object, e As EventArgs) Handles btnCuenta.Click
        cargarCuentaContable()
    End Sub

    Private Sub cargarCuentaContable()
        If txtCuenta.Text.Trim.Length >= 2 Then
            With frmEscogerPlanContable
                .formInicio = "frmTsCuentasTipoOperacion"
                .cuentaInicio = txtCuenta.Text.Trim
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim campos As String
        Dim valores As String


        campos = "id_tipo_operacion@num_cuenta@debe@haber"

        Dim rpta As String = ""
        Dim tabla As String = "cuentas_tipo_operacion"
        obj.nEjecutarQueryBD("delete from " & tabla & " where id_tipo_operacion='" & codigoCeldaSeleccionada() & "'", CadenaConexion)

        For Each row As DataGridViewRow In dgvCuentas.Rows
            valores = codigoCeldaSeleccionada() & "@" & row.Cells("num_cuenta").Value.ToString & "@" & row.Cells("debe").Value.ToString & "@" & row.Cells("haber").Value.ToString
            rpta = obj.nCrudInsertarBD("@", tabla, campos, valores, CadenaConexion)
        Next
        If rpta = "ok" Or rpta = "" Then
            MessageBox.Show("El proceso se ha realizado con éxito.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            gbGrupo.Enabled = False
            limpiarEntradas()
            cargarCuentas()
            txtDato.Focus()
        Else
            MessageBox.Show(rpta, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Sub
End Class