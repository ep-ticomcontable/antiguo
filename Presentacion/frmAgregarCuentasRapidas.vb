Imports Negocio

Public Class frmAgregarCuentasRapidas
    Public formIni As String
    Public monto As Decimal
    Dim iCarga As Integer = 0
    Dim objCrud As New nCrud
    Private Sub cargarListaLocalesActivos()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListarBD("select cod_local,nombre from locales where estado=1", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboLocal
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Locales")
        End Try
    End Sub
    Private Sub cargarParametrosCentro(idCentro As Integer)
        Dim data As New DataTable
        data = objCrud.nCrudListarBD("select * from parametro_centro_costo where id_centro='" & idCentro & "' and estado=1 order by id asc", CadenaConexion)
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
                .formInicio = "agregarCuentaRapida"
                .cuentaInicio = txtCuenta.Text.Trim
                .ShowDialog()
            End With
        End If
    End Sub

    'Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
    '    If formIni = "notacreditocompra" Then
    '        frmNuevaNotaCreditoCompra.agregarCuenta(txtCuenta.Text.Trim, lblCuenta.Text, txtValor.Text.Trim, txtTotal.Text.Trim)
    '    ElseIf formIni = "notacreditoventa" Then
    '        frmNuevaNotaCreditoVenta.agregarCuenta(txtCuenta.Text.Trim, lblCuenta.Text, txtValor.Text.Trim, txtTotal.Text.Trim)
    '    ElseIf formIni = "notadebitoventa" Then
    '        frmNuevaNotaDebitoVenta.agregarCuenta(txtCuenta.Text.Trim, lblCuenta.Text, txtValor.Text.Trim, txtTotal.Text.Trim)
    '    ElseIf formIni = "notadebitocompra" Then
    '        frmNuevaNotaDebitoCompra.agregarCuenta(txtCuenta.Text.Trim, lblCuenta.Text, txtValor.Text.Trim, txtTotal.Text.Trim)
    '    ElseIf formIni = "cobranza" Then
    '        frmPagoDeudas.agregarCuenta(txtCuenta.Text.Trim, lblCuenta.Text, txtValor.Text.Trim, txtTotal.Text.Trim)
    '    End If
    '    Me.Dispose()
    'End Sub

    Private Sub frmAgregarCuentasRapidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtValor.Text = monto
        cargarListaLocalesActivos()
        iCarga = 1
    End Sub
    Private Sub cboLocal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLocal.SelectedIndexChanged
        If iCarga = 1 Then
            Dim data As New DataTable
            data.Columns.Add("Codigo")
            data.Columns.Add("Descripcion")
            Dim data2 As DataTable
            Try
                data2 = objCrud.nCrudListarBD("select * from centro_costos where id_local='" & cboLocal.SelectedValue.ToString & "' and estado=1 order by descripcion asc", CadenaConexion)
                If data2.Rows.Count > 0 Then
                    cboCentro.Enabled = True
                    For Each row As DataRow In data2.Rows
                        data.Rows.Add(row.Item(0).ToString, row.Item(2).ToString)
                    Next
                    With cboCentro
                        .DataSource = data
                        .ValueMember = "Codigo"
                        .DisplayMember = "Descripcion"
                    End With
                    data2.Dispose()
                Else
                    cboCentro.Enabled = False
                End If

            Catch ex As Exception
                MsgBox("No se pudo cargar la lista de Centro de Costos")
            End Try

        End If
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim data As New DataTable
        data = objCrud.nCrudListarBD("select * from parametro_centro_costo where id_centro='" & cboCentro.SelectedValue.ToString & "' and estado=1 order by id asc", CadenaConexion)
        Dim nMonto As Decimal = 0
        For Each rowi As DataRow In data.Rows
            'MsgBox(rowi.Item("cuenta"))
            Dim cuentaText As String
            Dim dataC As New DataTable
            dataC = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & rowi.Item("cuenta").ToString & "'", CadenaConexion)
            cuentaText = dataC.Rows(0)("nombre").ToString

            nMonto = Format(Decimal.Parse((rowi.Item("porcentaje").ToString * monto) / 100), "#,##0.00")

            If dgvLista.RowCount = 0 Then
                Dim dtItem As New DataTable
                With dtItem.Columns
                    .Add("num_cuenta")
                    .Add("desc_cuenta")
                    .Add("porcentaje")
                    .Add("debe")
                    .Add("haber")
                End With
                dtItem.Rows.Add(rowi.Item("cuenta"), cuentaText, rowi.Item("porcentaje").ToString, nMonto, "00.00")
                dgvLista.DataSource = dtItem
            Else
                Dim dt As DataTable = DirectCast(dgvLista.DataSource, DataTable)
                Dim row As DataRow = dt.NewRow()
                row.Item(0) = rowi.Item("cuenta").ToString
                row.Item(1) = cuentaText
                row.Item(2) = rowi.Item("porcentaje").ToString
                row.Item(3) = IIf(rowi.Item("debe").ToString = "1", nMonto, "00.00")
                row.Item(4) = IIf(rowi.Item("haber").ToString = "1", nMonto, "00.00")
                dt.Rows.Add(row)
            End If
        Next
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim data As New DataTable
        With data
            .Columns.Add("num_cuenta")
            .Columns.Add("desc_cuenta")
            .Columns.Add("porcentaje")
            .Columns.Add("debe")
            .Columns.Add("haber")
        End With

        For Each row As DataGridViewRow In dgvLista.Rows
            data.Rows.Add(row.Cells("num_cuenta").Value, row.Cells("desc_cuenta").Value, row.Cells("porcentaje").Value, row.Cells("debe").Value, row.Cells("haber").Value)
        Next

        frmNuevaCompraRapida.cargarCuentasExterna(txtCuenta.Text.Trim, lblCuenta.Text, data)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmCrearCentroCosto.Show()
    End Sub
End Class