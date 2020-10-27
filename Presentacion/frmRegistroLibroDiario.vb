Imports Negocio
Imports Entidades
Public Class frmRegistroLibroDiario
    Dim objCrud As New nCrud
    Private Sub movimientoDH()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add("D", "DEBE")
        data.Rows.Add("H", "HABER")
        With cboDH
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub
    Private Sub frmRegistroLibroDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        movimientoDH()
    End Sub

    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cargarCuentaContable()
            txtMonto.Focus()
        End If
    End Sub
    Private Sub cargarCuentaContable()
        If txtCuenta.Text.Trim.Length >= 2 Then
            With frmEscogerPlanContable
                .formInicio = "diario"
                .cuentaInicio = txtCuenta.Text.Trim
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim cuenta As String = ""
        cuenta = txtCuenta.Text.Trim
        Dim monto As Decimal = 0
        monto = Decimal.Parse(txtMonto.Text.Trim)
        Dim dtData As New DataTable
        With dtData.Columns
            .Add("num_cuenta")
            .Add("desc_cuenta")
            .Add("debe")
            .Add("haber")
            .Add("glosa")
        End With

        If dgvOperaciones.Rows.Count = 0 Then
            dtData.Rows.Add(cuenta, obtenerDatosCuenta(cuenta), IIf(cboDH.SelectedValue = "D", monto, "0.00"), IIf(cboDH.SelectedValue = "H", monto, "0.00"), txtGlosa.Text.Trim.ToUpper)
            dgvOperaciones.DataSource = dtData
        Else
            Dim dtI As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
            Dim row4 As DataRow = dtI.NewRow()
            row4.Item(0) = txtCuenta.Text.Trim
            row4.Item(1) = obtenerDatosCuenta(txtCuenta.Text.Trim)
            row4.Item(2) = IIf((cboDH.SelectedValue.ToString = "D"), txtMonto.Text.Trim, "0.00")
            row4.Item(3) = IIf((cboDH.SelectedValue.ToString = "H"), txtMonto.Text.Trim, "0.00")
            row4.Item(4) = txtGlosa.Text.Trim.ToUpper
            dtI.Rows.Add(row4)
        End If
        realizarSumasTotales()
    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function
    Private Sub realizarSumasTotales()
        Dim tDebe, tHaber, tDiferencia As Decimal
        For Each row As DataGridViewRow In dgvOperaciones.Rows
            tDebe += Decimal.Parse(row.Cells("debe").Value)
            tHaber += Decimal.Parse(row.Cells("haber").Value)
        Next
        tDiferencia = tDebe - tHaber

        txtTDebeS.Text = Format(tDebe, "#,##0.00")
        txtTHaberS.Text = Format(tHaber, "#,##0.00")
        txtDiferenciaS.Text = Format(tDiferencia, "#,##0.00")
    End Sub
    Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cboDH.Focus()
        End If
    End Sub
    Private Sub cboDH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboDH.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtGlosa.Focus()
        End If
    End Sub
    Private Sub txtGlosa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGlosa.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnCargar.Focus()
        End If
    End Sub
    Private Sub btnFinalizar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnFinalizar.KeyPress
        If Asc(e.KeyChar) = 13 Then
            guardarPagos()
        End If
    End Sub
    Private Sub frmNuevaVentaP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        guardarPagos()
    End Sub
    Private Sub guardarPagos()
        Dim objLD As New nAsientoLibroDiario
        Dim entidad As New ALDiarioEntity
        Dim correlativoLD As Integer = 0
        Dim data As New DataTable
        data = objCrud.nCrudListarBD("select id_comprobante from asientos_libro_diario where id_comprobante like 'RLD%' group by id_comprobante", CadenaConexion)
        correlativoLD = IIf(data.Rows.Count = 0, "1", (data.Rows.Count + 1))
        For Each row As DataGridViewRow In dgvOperaciones.Rows
            With entidad
                .id_comprobante = "RLD" & correlativoLD
                .cuo = "0"
                .fecha_operacion = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                .glosa = row.Cells("glosa").Value
                .cod_libro = row.Cells("num_cuenta").Value
                .numero_correlativo = "-"
                .numero_documento = "-"
                .cuenta = row.Cells("num_cuenta").Value
                .denominacion = row.Cells("desc_cuenta").Value
                .debe = row.Cells("debe").Value
                .haber = row.Cells("haber").Value
            End With
            objLD.registrarAsientoLibroDiarioBD(entidad, CadenaConexion)
        Next
        MsgBox("¡Asientos registrados correctamente!")
        Me.Dispose()
    End Sub
End Class