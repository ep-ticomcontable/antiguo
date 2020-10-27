Imports Negocio
Imports Entidades

Public Class frmSalidaBanco

    Dim objCrud As New nCrud
    Dim ctaCaja As String = "101"

    Private Sub movimientoDH()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add("D", "INGRESO")
        data.Rows.Add("H", "SALIDA")
        With cboDH
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub

    Private Sub cargarCaja()
        Dim dataAnio As New DataTable
        dataAnio.Columns.Add("codigo")
        dataAnio.Columns.Add("descripcion")
        dataAnio.Rows.Add(0, "SELECCIONE")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListarBD("select * from caja_configuracion where estado=1 order by id asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                dataAnio.Rows.Add(row.Item(0).ToString, row.Item("descripcion").ToString)
            Next
            With cboCaja
                .DataSource = dataAnio
                .ValueMember = "codigo"
                .DisplayMember = "descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar las cajas")
        End Try
    End Sub
    Private Sub frmCajaChicaRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCaja()
        movimientoDH()
    End Sub

    Private Sub btnCuenta_Click(sender As Object, e As EventArgs)
        frmEscogerPlanContable.Show()
    End Sub

    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtCuenta.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "cajabanco"
                    .cuentaInicio = txtCuenta.Text.Trim
                    .ShowDialog()
                End With
            End If
            txtMonto.Focus()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'If dgvLista.RowCount = 0 Then
        Dim dt1 As New DataTable
        With dt1
            .Columns.Add("num_cuenta")
            .Columns.Add("desc_cuenta")
            .Columns.Add("debe")
            .Columns.Add("haber")
        End With
        Dim dataCuenta As New DataTable
        dataCuenta = objCrud.nCrudListarBD("select * from caja_configuracion where id='" & cboCaja.SelectedValue.ToString & "'", CadenaConexion)

        dt1.Rows.Add(dataCuenta.Rows(0)("cuenta").ToString, obtenerDatosCuenta(dataCuenta.Rows(0)("cuenta").ToString), IIf((cboDH.SelectedValue.ToString = "D"), txtMonto.Text.Trim, "0.00"), IIf((cboDH.SelectedValue.ToString = "H"), txtMonto.Text.Trim, "0.00"))
        dt1.Rows.Add(txtCuenta.Text.Trim, obtenerDatosCuenta(txtCuenta.Text.Trim), IIf((cboDH.SelectedValue.ToString = "H"), txtMonto.Text.Trim, "0.00"), IIf((cboDH.SelectedValue.ToString = "D"), txtMonto.Text.Trim, "0.00"))
        dgvLista.DataSource = dt1

        'Else
        'Dim dtI As DataTable = DirectCast(dgvLista.DataSource, DataTable)
        'Dim row4 As DataRow = dtI.NewRow()
        'row4.Item(0) = txtCuenta.Text.Trim
        'row4.Item(1) = obtenerDatosCuenta(txtCuenta.Text.Trim)
        'row4.Item(2) = IIf((cboDH.SelectedValue.ToString = "D"), txtMonto.Text.Trim, "0.00")
        'row4.Item(3) = IIf((cboDH.SelectedValue.ToString = "H"), txtMonto.Text.Trim, "0.00")
        'dtI.Rows.Add(row4)
        'End If
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        realizarSumas()
    End Sub

    Private Sub realizarSumas()
        Dim debe As Decimal = 0
        Dim haber As Decimal = 0
        For Each row As DataGridViewRow In dgvLista.Rows
            debe += row.Cells("debe").Value
            haber += row.Cells("haber").Value
        Next
        lblDebe.Text = Format(debe, "#,##0.00")
        lblHaber.Text = Format(haber, "#,##0.00")
        lblDiferencia.Text = Format((debe - haber), "#,##0.00")
    End Sub

    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function

    Private Sub cboTipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txtCuenta.Focus()
        End If
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
            btnAgregar.Focus()
        End If
    End Sub
    Private Sub btnFinalizar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnFinalizar.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'guardarPagos()
        End If
    End Sub
    Private Sub frmNuevaCompraP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Insert Then
            'txtCuenta.Focus()
            txtCuenta.Select()
        End If
    End Sub
    Private Sub realizarProceso()
        Dim entiCaja As New CajaEntity
        With entiCaja
            .id_tipo_caja = cboCaja.SelectedValue.ToString
            .id_tipo_salida = "10"
            .id_documento = "1"
            .serie = "0"
            .numero = "0"
            .dni_ruc = "-"
            .cliente = "-"
            .monto = txtMonto.Text.Trim
            .glosa = txtGlosa.Text.Trim
            .estado = "1"
        End With
        Dim rpta As String = ""
        rpta = objCrud.registrarDetalleCajaBD(entiCaja, CadenaConexion)

        Dim data As New DataTable
        data = objCrud.nCrudListarBD("select id from cajas order by id desc", CadenaConexion)
        Dim id As Integer = 0
        If data.Rows.Count = 0 Then
            id = 1
        Else
            id = Integer.Parse(data.Rows(0)("id").ToString)
        End If

        For Each row As DataGridViewRow In dgvLista.Rows
            'Registrando asientos de la caja
            With entiCaja
                .estado = "1"
                .id_caja = id
                .glosa = txtGlosa.Text.Trim
                .cuenta = row.Cells("num_cuenta").Value.ToString
                .debe = row.Cells("debe").Value.ToString
                .haber = row.Cells("haber").Value.ToString
            End With
            objCrud.registrarAsientosCajaBD(entiCaja, CadenaConexion)
        Next
        'REGISTRAR EN LIBRO DIARIO
        Dim dtCajaC As New DataTable
        dtCajaC = objCrud.nCrudListarBD("select * from caja_configuracion where id='" & cboCaja.SelectedValue.ToString & "'", CadenaConexion)
        With entiCaja
            .estado = "1"
            .id_caja = id
            .glosa = txtGlosa.Text.Trim
            .cuenta = dtCajaC.Rows(0)("cuenta").ToString
            .debe = IIf(cboDH.SelectedValue.ToString = "D", txtMonto.Text.Trim, "0.00")
            .haber = IIf(cboDH.SelectedValue.ToString = "H", txtMonto.Text.Trim, "0.00")
        End With
        objCrud.registrarAsientosCajaLDBD(entiCaja, CadenaConexion)

        'Ubicar caja de la cuenta contable
        Dim dtCaja As New DataTable
        dtCaja = objCrud.nCrudListarBD("select * from caja_configuracion where cuenta='" & txtCuenta.Text.Trim & "'", CadenaConexion)
        If dtCaja.Rows.Count > 0 Then
            With entiCaja
                .id_tipo_caja = dtCaja.Rows(0)("id").ToString
                .id_tipo_salida = "10"
                .id_documento = "1"
                .serie = "0"
                .numero = "0"
                .dni_ruc = "-"
                .cliente = "-"
                .monto = txtMonto.Text.Trim
                .glosa = txtGlosa.Text.Trim
                .estado = "1"
            End With
            objCrud.registrarDetalleCajaBD(entiCaja, CadenaConexion)

            Dim data2 As New DataTable
            data2 = objCrud.nCrudListarBD("select id from cajas order by id desc", CadenaConexion)
            Dim id2 As Integer = 0
            If data.Rows.Count = 0 Then
                id2 = 1
            Else
                id2 = Integer.Parse(data2.Rows(0)("id").ToString)
            End If

            For Each row As DataGridViewRow In dgvLista.Rows
                'Registrando asientos de la caja
                With entiCaja
                    .estado = "1"
                    .id_caja = id2
                    .glosa = txtGlosa.Text.Trim
                    .cuenta = row.Cells("num_cuenta").Value.ToString
                    .debe = row.Cells("debe").Value.ToString
                    .haber = row.Cells("haber").Value.ToString
                End With
                objCrud.registrarAsientosCajaBD(entiCaja, CadenaConexion)
            Next
            'REGISTRAR EN LIBRO DIARIO
            Dim dtCajaC2 As New DataTable
            dtCajaC2 = objCrud.nCrudListarBD("select * from caja_configuracion where id='" & cboCaja.SelectedValue.ToString & "'", CadenaConexion)
            With entiCaja
                .id_caja = id2
                .glosa = txtGlosa.Text.Trim
                .cuenta = txtCuenta.Text.Trim
                .debe = IIf(cboDH.SelectedValue.ToString = "H", txtMonto.Text.Trim, "0.00")
                .haber = IIf(cboDH.SelectedValue.ToString = "D", txtMonto.Text.Trim, "0.00")
            End With
            objCrud.registrarAsientosCajaLDBD(entiCaja, CadenaConexion)
        End If

        MsgBox("¡Asientos registrados con éxito!")
        Me.Dispose()
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        realizarProceso()
    End Sub
End Class