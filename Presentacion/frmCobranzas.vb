Imports Negocio
Imports Entidades
Public Class frmCobranzas

    Dim objCrud As New nCrud
    Public formIni As String
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
                .formInicio = "cobranzas"
                .cuentaInicio = txtCuenta.Text.Trim
                .ShowDialog()
            End With
        End If
    End Sub
    Private Sub txtDebe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDebe.KeyPress, txtHaber.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            agregarCuenta()
        End If
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        agregarCuenta()
    End Sub
    Private Sub agregarCuenta()
        If dgvLista.RowCount = 0 Then
            Dim dtItem As New DataTable
            With dtItem.Columns
                .Add("num_cuenta")
                .Add("desc_cuenta")
                .Add("debe")
                .Add("haber")
            End With

            dtItem.Rows.Add(txtCuenta.Text.Trim, lblCuenta.Text, txtDebe.Text.Trim, txtHaber.Text.Trim)
            dgvLista.DataSource = dtItem
        Else
            Dim dt As DataTable = DirectCast(dgvLista.DataSource, DataTable)
            Dim row As DataRow = dt.NewRow()
            row.Item(0) = txtCuenta.Text.Trim
            row.Item(1) = lblCuenta.Text
            row.Item(2) = txtDebe.Text.Trim
            row.Item(3) = txtHaber.Text.Trim
            dt.Rows.Add(row)
        End If
        seleccionarCuentaAdicionada(txtCuenta.Text.Trim)
        txtCuenta.Text = ""
        lblCuenta.Text = "[Cuenta]"
        txtDebe.Text = "0.00"
        txtHaber.Text = "0.00"
        realizarSumasTotales()
        txtCuenta.Select()
        txtCuenta.Focus()
    End Sub

    Private Sub frmCobranzas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        realizarSumasTotales()
    End Sub
    Private Sub realizarSumasTotales()
        ' MsgBox("suma total")
        Dim tDebe, tHaber, tDiferencia As Decimal
        For Each row As DataGridViewRow In dgvLista.Rows
            tDebe += row.Cells("debe").Value
            tHaber += row.Cells("haber").Value
        Next
        tDiferencia = tDebe - tHaber

        txtTDebeS.Text = Format(tDebe, "#,##0.00")
        txtTHaberS.Text = Format(tHaber, "#,##0.00")
        txtDiferenciaS.Text = Format(tDiferencia, "#,##0.00")
    End Sub
    Private Sub seleccionarCuentaAdicionada(numcuenta)
        For i As Integer = 0 To dgvLista.Rows.Count - 1
            For x As Integer = 0 To dgvLista.ColumnCount - 1
                If dgvLista.Rows(i).Cells("num_cuenta").Value.ToString = numcuenta Then
                    'dgvDetalle.MultiSelect = False
                    'dgvDetalle.Rows(i).Selected = True
                    'dgvDetalle.Rows(i).Cells("cantidad").Select = True

                    dgvLista.CurrentCell = dgvLista.Rows(i).Cells("num_cuenta")
                    'dgvDetalle.CurrentCell = dgvDetalle.Item("cantidad", i)
                    'dgvDetalle.SelectionMode = DataGridViewSelectionMode.CellSelect
                End If
            Next
        Next
    End Sub
End Class