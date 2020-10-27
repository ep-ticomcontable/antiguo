Imports Negocio
Imports Entidades

Public Class frmDepositoDetracciones

    Dim objCrud As New nCrud
    Dim ctaCaja As String = "101"
    Dim iCarga As Integer = 0

    Private Sub cargarCajaS()
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
            With cboCajaS
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
        cargarCajaS()
        dgvLista.RowTemplate.Height = 30
        iCarga = 1
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
        dataCuenta = objCrud.nCrudListarBD("select * from caja_configuracion where id='" & cboCajaS.SelectedValue.ToString & "'", CadenaConexion)

        dt1.Rows.Add(lblCuentaE.Text, obtenerDatosCuenta(lblCuentaE.Text), txtMonto.Text.Trim, "0.00")
        dt1.Rows.Add(lblCuentaS.Text, obtenerDatosCuenta(lblCuentaS.Text), "0.00", txtMonto.Text.Trim)
        dgvLista.DataSource = dt1
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
    Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'cboDH.Focus()
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
    Private Sub realizarProceso()
        Dim entiDetrac As New CajaEntity

        With entiDetrac
            .id_tipo_caja = cboCajaS.SelectedValue.ToString
            .id_tipo_salida = cboCajaE.SelectedValue.ToString
            .cliente = txtOperacion.Text.Trim
            .id_documento = txtIdComprobante.Text.Trim
            .serie = txtSerie.Text.Trim
            .numero = txtNumero.Text.Trim
            .monto = txtMonto.Text.Trim
            .glosa = txtGlosa.Text.Trim
        End With
        Dim rptaD As String = ""
        rptaD = objCrud.registrarDetraccionVenta(entiDetrac)





        Dim entiCaja As New CajaEntity
        With entiCaja
            .id_tipo_caja = cboCajaS.SelectedValue.ToString
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
                .id_caja = id
                .glosa = txtGlosa.Text.Trim
                .cuenta = row.Cells("num_cuenta").Value.ToString
                .debe = row.Cells("debe").Value.ToString
                .haber = row.Cells("haber").Value.ToString
            End With
            objCrud.registrarAsientosCajaBD(entiCaja, CadenaConexion)
        Next


        'Ubicar caja de la cuenta contable
        With entiCaja
            .id_tipo_caja = cboCajaE.SelectedValue.ToString
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
                .id_caja = id2
                .glosa = txtGlosa.Text.Trim
                .cuenta = row.Cells("num_cuenta").Value.ToString
                .debe = row.Cells("debe").Value.ToString
                .haber = row.Cells("haber").Value.ToString
            End With
            objCrud.registrarAsientosCajaBD(entiCaja, CadenaConexion)
        Next

        MsgBox("¡Asientos registrados con éxito!")
        Me.Dispose()
    End Sub
    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        If dgvLista.RowCount > 0 Then
            realizarProceso()
        Else
            MsgBox("No se han agregado los asientos contables para realizar la operación.")
        End If

    End Sub

    Private Sub cboCajaS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCajaS.SelectedIndexChanged
        If iCarga = 1 Then
            Dim dataAnio As New DataTable
            dataAnio.Columns.Add("codigo")
            dataAnio.Columns.Add("descripcion")
            dataAnio.Rows.Add(0, "SELECCIONE")
            Dim data2 As DataTable
            Try
                data2 = objCrud.nCrudListarBD("select * from caja_configuracion where id<>'" & cboCajaS.SelectedValue.ToString & "' and estado=1 order by id asc", CadenaConexion)
                For Each row As DataRow In data2.Rows
                    dataAnio.Rows.Add(row.Item(0).ToString, row.Item("descripcion").ToString)
                Next
                With cboCajaE
                    .DataSource = dataAnio
                    .ValueMember = "codigo"
                    .DisplayMember = "descripcion"
                End With
                data2.Dispose()
            Catch ex As Exception
                MsgBox("No se pudo cargar las cajas")
            End Try

            'cargar cuenta contable de la caja
            Dim data As New DataTable
            data = objCrud.nCrudListarBD("select * from caja_configuracion where id='" & cboCajaS.SelectedValue.ToString & "'", CadenaConexion)
            lblCuentaS.Text = data.Rows(0)("cuenta").ToString
        End If
    End Sub

    Private Sub cboCajaE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCajaE.SelectedIndexChanged
        If iCarga = 1 And cboCajaS.SelectedValue <> 0 Then
            'cargar cuenta contable de la caja
            Dim data As New DataTable
            data = objCrud.nCrudListarBD("select * from caja_configuracion where id='" & cboCajaE.SelectedValue.ToString & "'", CadenaConexion)
            If data.Rows.Count > 0 Then
                lblCuentaE.Text = data.Rows(0)("cuenta").ToString
            Else
                lblCuentaE.Text = "[Cuenta]"
            End If
        End If
    End Sub

    Private Sub btnBuscarComprobante_Click(sender As Object, e As EventArgs) Handles btnBuscarComprobante.Click
        frmListaComprobanteVentas.ShowDialog()
    End Sub

    Private Sub txtMonto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.Leave
        txtMonto.Text = Format(CType(txtMonto.Text, Decimal), "###0.00")
    End Sub
    Private Sub txtSerie_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.Leave
        txtSerie.Text = txtSerie.Text.ToString.PadLeft(4, "0")
    End Sub
    Private Sub txtNumero_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.Leave
        txtNumero.Text = txtNumero.Text.ToString.PadLeft(4, "0")
    End Sub
    
End Class