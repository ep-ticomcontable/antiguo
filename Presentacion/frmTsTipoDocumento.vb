Imports Negocio

Public Class frmTsTipoDocumento

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

    Private Sub cargarDatos()
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from vista_tipo_documento order by codigo asc", CadenaConexion)
        dgvLista.DataSource = data
        data = Nothing
        cargaInicialEstados()
    End Sub

    Private Sub frmTsTipoPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
        txtDato.Focus()
        txtDato.Select()
    End Sub

    Private Sub dgvLista_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLista.SelectionChanged
        cargarDatosCuenta()
    End Sub

    Private Sub cargarDatosCuenta()
        If tipo <> "new" Or tipo = "" Then
            Me.Enabled = False
            On Error Resume Next
            Dim sql As String
            sql = "select * from tipo_documento where id=" & codigoCeldaSeleccionada()
            Dim data As New DataTable
            data = obj.nCrudListarBD(sql, CadenaConexion)
            With data
                txtCodigo.Text = .Rows(0)("codigo")
                txtDescripcion.Text = .Rows(0)("descripcion")

                If .Rows(0)("estado") = "0" Then
                    rbNo.Checked = True
                ElseIf .Rows(0)("estado") = "1" Then
                    rbSi.Checked = True
                End If
            End With
            data = Nothing
            Me.Enabled = True
        ElseIf tipo = "new" Then
            txtCodigo.Focus()
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
        data = obj.nCrudListarBD("select * from vista_tipo_documento where descripcion like '%" & dato & "%' or codigo like '%" & dato & "%'", CadenaConexion)
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
        limpiarEntradas()
    End Sub

    Private Sub limpiarEntradas()
        txtCodigo.Text = ""
        txtDescripcion.Text = ""
        rbSi.Checked = True
        txtCodigo.Focus()
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
        campos = "codigo@descripcion@estado"
        valores = txtCodigo.Text.ToString & "@" & txtDescripcion.Text.ToString & "@" & estado
        Dim rpta As String = ""
        Dim tabla As String = "tipo_documento"
        If tipo = "update" Then
            condicion = "id=" & codigoCeldaSeleccionada()
            rpta = obj.nCrudActualizar("@", tabla, campos, valores, condicion)
        ElseIf tipo = "new" Then
            rpta = obj.nCrudInsertar("@", tabla, campos, valores)
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
End Class