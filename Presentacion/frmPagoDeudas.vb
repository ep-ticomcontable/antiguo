Imports Negocio
Imports Entidades
Public Class frmPagoDeudas

    Dim obj As New nCrud
    Dim objTDA As New nTipoDocumentoAsiento
    Dim objAC As New nAsientosContables
    Public codComprobante As Integer = 0
    Public codTipoComprobante As Integer = 0
    Dim objNCD As New nNotaCreditoDebito
    Dim tipoOperacion As Integer = 5 'DEVOLUCIONES
    Dim objCV As New nComprobanteVenta
    Dim id_comprobante As String

    Public Sub cargarDatosComprobante()
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from comprobante_venta where id='" & codComprobante & "'", CadenaConexion)
        With data
            cboTipoDocumento.SelectedValue = .Rows(0)("id_tipo_comprobante").ToString
            txtSerie.Text = .Rows(0)("serie_comprobante").ToString
            txtNumero.Text = .Rows(0)("numero_comprobante").ToString
            dtFechaEmision.Value = .Rows(0)("fec_emision").ToString
            txtMonto.Text = .Rows(0)("base_imponible").ToString
            txtIgv.Text = .Rows(0)("valor_igv").ToString
            txtTotal.Text = .Rows(0)("total").ToString
            txtGlosa.Text = .Rows(0)("glosa").ToString
        End With
        realizarSumasTotales()
    End Sub

    Private Sub cargarTipoDocumento()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = objTDA.nListarCuentasSegunTipoAsientoBD(1, CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, "(" & row.Item(1).ToString & ") " & row.Item(2).ToString.ToUpper)
            Next
            With cboTipoDocumento
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
                .SelectedValue = codTipoComprobante
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Documentos")
        End Try
    End Sub

    Private Sub cargarRegistroCuentas(codigoComprobante)
        If dgvLista.RowCount = 0 Then
            Dim dtItem As New DataTable
            With dtItem.Columns
                .Add("id")
                .Add("id_asiento_venta")
                .Add("num_cuenta")
                .Add("desc_cuenta")
                .Add("debe")
                .Add("haber")
            End With
            Dim data As New DataTable
            data = obj.nCrudListarBD("usp_cuentaComprobanteVenta '" & codigoComprobante & "','70'", CadenaConexion)

            Dim dataParam As New DataTable
            dataParam = obj.nCrudListarBD("usp_parametrosNotaCreditoDebito '" & tipoOperacion & "','70'", CadenaConexion)

            dtItem.Rows.Add(data.Rows(0)("id").ToString, data.Rows(0)("id_asiento_venta").ToString, _
                            dataParam.Rows(0)("num_cuenta").ToString, _
                            dataParam.Rows(0)("desc_cuenta").ToString, _
                            data.Rows(0)("debe").ToString, _
                            data.Rows(0)("haber").ToString)
            dgvLista.DataSource = dtItem
        End If

        Dim dataParam1 As New DataTable
        dataParam1 = obj.nCrudListarBD("usp_parametrosNotaCreditoDebito '" & tipoOperacion & "','40'", CadenaConexion)

        Dim data2 As New DataTable
        data2 = obj.nCrudListarBD("usp_cuentaComprobanteVenta '" & codigoComprobante & "','40'", CadenaConexion)
        Dim dt As DataTable = DirectCast(dgvLista.DataSource, DataTable)
        Dim row As DataRow = dt.NewRow()
        row.Item(0) = data2.Rows(0)("id").ToString
        row.Item(1) = data2.Rows(0)("id_asiento_venta").ToString
        row.Item(2) = dataParam1.Rows(0)("num_cuenta").ToString
        row.Item(3) = dataParam1.Rows(0)("desc_cuenta").ToString
        row.Item(4) = data2.Rows(0)("debe").ToString
        row.Item(5) = data2.Rows(0)("haber").ToString
        dt.Rows.Add(row)


        Dim dataParam2 As New DataTable
        dataParam2 = obj.nCrudListarBD("usp_parametrosNotaCreditoDebito '" & tipoOperacion & "','12'", CadenaConexion)
        Dim data3 As New DataTable
        data3 = obj.nCrudListarBD("usp_cuentaComprobanteVenta '" & codigoComprobante & "','12'", CadenaConexion)
        Dim dt2 As DataTable = DirectCast(dgvLista.DataSource, DataTable)
        Dim row2 As DataRow = dt2.NewRow()
        row2.Item(0) = data3.Rows(0)("id").ToString
        row2.Item(1) = data3.Rows(0)("id_asiento_venta").ToString
        row2.Item(2) = dataParam2.Rows(0)("num_cuenta").ToString
        row2.Item(3) = dataParam2.Rows(0)("desc_cuenta").ToString
        row2.Item(4) = data3.Rows(0)("debe").ToString
        row2.Item(5) = data3.Rows(0)("haber").ToString
        dt2.Rows.Add(row2)

        Dim data4 As New DataTable
        data4 = obj.nCrudListarBD("usp_cuentaComprobanteVenta '" & codigoComprobante & "','20'", CadenaConexion)
        Dim dt3 As DataTable = DirectCast(dgvLista.DataSource, DataTable)
        Dim row3 As DataRow = dt3.NewRow()
        row3.Item(0) = data4.Rows(0)("id").ToString
        row3.Item(1) = data4.Rows(0)("id_asiento_venta").ToString
        row3.Item(2) = data4.Rows(0)("num_cuenta").ToString
        row3.Item(3) = data4.Rows(0)("desc_cuenta").ToString
        row3.Item(4) = data4.Rows(0)("debe").ToString
        row3.Item(5) = data4.Rows(0)("haber").ToString
        dt3.Rows.Add(row3)

        Dim data5 As New DataTable
        data5 = obj.nCrudListarBD("usp_cuentaComprobanteVenta '" & codigoComprobante & "','69'", CadenaConexion)
        Dim dt4 As DataTable = DirectCast(dgvLista.DataSource, DataTable)
        Dim row4 As DataRow = dt4.NewRow()
        row4.Item(0) = data5.Rows(0)("id").ToString
        row4.Item(1) = data5.Rows(0)("id_asiento_venta").ToString
        row4.Item(2) = data5.Rows(0)("num_cuenta").ToString
        row4.Item(3) = data5.Rows(0)("desc_cuenta").ToString
        row4.Item(4) = data5.Rows(0)("debe").ToString
        row4.Item(5) = data5.Rows(0)("haber").ToString
        dt4.Rows.Add(row4)

    End Sub
    Private Sub frmNuevaNotaCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTipoDocumento()
        If codComprobante > 0 Then
            '    cargarRegistroCuentas(codComprobante)
        End If
    End Sub

    'Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If e.KeyChar = Convert.ToChar(Keys.Enter) Then
    '        If txtCuenta.Text.Trim.Length >= 2 Then
    '            With frmEscogerPlanContable
    '                .formInicio = "notacredito"
    '                .cuentaInicio = txtCuenta.Text.Trim
    '                .ShowDialog()
    '            End With
    '        End If
    '    End If
    'End Sub

    Private Sub btnRuc_Click(sender As Object, e As EventArgs)
        frmConsultaSunat.formInicio = "notacredito"
        frmConsultaSunat.ShowDialog()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim entiCVenta, entiCabVent As New ComprobanteVentaEntity
        With entiCabVent
            .numero_cuo = objAC.nObtenerNumeroCUOBD(CadenaConexion)
            .id_tipo_comprobante = id_comprobante
            .fec_emision = dtFechaEmision.Value
            .fec_pago = dtFechaEmision.Value
            .serie_comprobante = txtSerie.Text
            .numero_comprobante = txtNumero.Text
            .glosa = txtGlosa.Text.Trim
            .valor_facturado = "-" & txtMonto.Text.Trim
            .estado = 1
        End With

        MsgBox("REGISTRAR COMPROBANTE DE VENTA: " & objCV.nRegistrarComprobanteVentaBD(entiCabVent, CadenaConexion))

        Dim idNC As String
        idNC = objNCD.obtenerIdNotaCreditoBD(CadenaConexion)

        For Each row As DataGridViewRow In dgvLista.Rows
            'With entiNCD
            '    .id_nota_credito = idNC
            '    .cuenta = row.Cells("num_cuenta").Value
            '    .debe = row.Cells("debe").Value
            '    .haber = row.Cells("haber").Value
            'End With
            'MsgBox(objNCD.registrarAsientoNotaCredito(entiNCD))
        Next
        MsgBox("LA NOTA DE CREDITO PARA VENTA HA SIDO GUARDADA CON ÉXITO")

    End Sub

    Private Sub txtMonto_TextChanged(sender As Object, e As EventArgs) Handles txtMonto.TextChanged
        Dim dataIgv As New DataTable
        dataIgv = obj.nCrudListarBD("select * from igv", CadenaConexion)
        Dim monto As Decimal = 0
        monto = IIf((txtMonto.Text.Trim.Length > 0), txtMonto.Text, 0)

        Dim totalConIgv As Decimal
        totalConIgv = Format(monto * (1 + (dataIgv.Rows(0)("valor").ToString) / 100), "#,##0.00")
        txtIgv.Text = Format(monto * ((dataIgv.Rows(0)("valor").ToString) / 100), "#,##0.00")
        txtTotal.Text = totalConIgv
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmAgregarCuentaNotas.formIni = "cobranza"
        frmAgregarCuentaNotas.Show()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs)
        Dim dtItem As New DataTable
        With dtItem.Columns
            .Add("id")
            .Add("id_asiento_venta")
            .Add("num_cuenta")
            .Add("desc_cuenta")
            .Add("debe")
            .Add("haber")
        End With
        dgvLista.DataSource = dtItem

        If dgvLista.RowCount = 0 Then
            Dim data As New DataTable
            data = obj.nCrudListarBD("usp_cuentaComprobanteVenta '" & codComprobante & "','70'", CadenaConexion)
            Dim dataParam As New DataTable
            dataParam = obj.nCrudListarBD("usp_parametrosNotaCreditoDebito '" & tipoOperacion & "','70'", CadenaConexion)

            dtItem.Rows.Add(data.Rows(0)("id").ToString, data.Rows(0)("id_asiento_venta").ToString, _
                            dataParam.Rows(0)("num_cuenta").ToString, _
                            dataParam.Rows(0)("desc_cuenta").ToString, _
                            "0.00", _
                            txtMonto.Text.Trim)
            dgvLista.DataSource = dtItem
        End If


        Dim dataParam1 As New DataTable
        dataParam1 = obj.nCrudListarBD("usp_parametrosNotaCreditoDebito '" & tipoOperacion & "','40'", CadenaConexion)
        Dim data2 As New DataTable
        data2 = obj.nCrudListarBD("usp_cuentaComprobanteVenta '" & codComprobante & "','40'", CadenaConexion)
        Dim dt As DataTable = DirectCast(dgvLista.DataSource, DataTable)
        Dim row As DataRow = dt.NewRow()
        row.Item(0) = data2.Rows(0)("id").ToString
        row.Item(1) = data2.Rows(0)("id_asiento_venta").ToString
        row.Item(2) = dataParam1.Rows(0)("num_cuenta").ToString
        row.Item(3) = dataParam1.Rows(0)("desc_cuenta").ToString
        row.Item(4) = "0.00"
        row.Item(5) = txtIgv.Text.Trim
        dt.Rows.Add(row)

        Dim dataParam2 As New DataTable
        dataParam2 = obj.nCrudListarBD("usp_parametrosNotaCreditoDebito '" & tipoOperacion & "','12'", CadenaConexion)
        Dim data3 As New DataTable
        data3 = obj.nCrudListarBD("usp_cuentaComprobanteVenta '" & codComprobante & "','12'", CadenaConexion)
        Dim dt2 As DataTable = DirectCast(dgvLista.DataSource, DataTable)
        Dim row2 As DataRow = dt2.NewRow()
        row2.Item(0) = data3.Rows(0)("id").ToString
        row2.Item(1) = data3.Rows(0)("id_asiento_venta").ToString
        row2.Item(2) = dataParam2.Rows(0)("num_cuenta").ToString
        row2.Item(3) = dataParam2.Rows(0)("desc_cuenta").ToString
        row2.Item(4) = txtTotal.Text.Trim
        row2.Item(5) = "0.00"
        dt2.Rows.Add(row2)


        Dim data4 As New DataTable
        data4 = obj.nCrudListarBD("usp_cuentaComprobanteVenta '" & codComprobante & "','20'", CadenaConexion)
        Dim dt3 As DataTable = DirectCast(dgvLista.DataSource, DataTable)
        Dim row3 As DataRow = dt3.NewRow()
        row3.Item(0) = data4.Rows(0)("id").ToString
        row3.Item(1) = data4.Rows(0)("id_asiento_venta").ToString
        row3.Item(2) = data4.Rows(0)("num_cuenta").ToString
        row3.Item(3) = data4.Rows(0)("desc_cuenta").ToString
        row3.Item(4) = data4.Rows(0)("debe").ToString
        row3.Item(5) = data4.Rows(0)("haber").ToString
        dt3.Rows.Add(row3)

        Dim data5 As New DataTable
        data5 = obj.nCrudListarBD("usp_cuentaComprobanteVenta '" & codComprobante & "','69'", CadenaConexion)
        Dim dt4 As DataTable = DirectCast(dgvLista.DataSource, DataTable)
        Dim row4 As DataRow = dt4.NewRow()
        row4.Item(0) = data5.Rows(0)("id").ToString
        row4.Item(1) = data5.Rows(0)("id_asiento_venta").ToString
        row4.Item(2) = data5.Rows(0)("num_cuenta").ToString
        row4.Item(3) = data5.Rows(0)("desc_cuenta").ToString
        row4.Item(4) = data5.Rows(0)("debe").ToString
        row4.Item(5) = data5.Rows(0)("haber").ToString
        dt4.Rows.Add(row4)
        realizarSumasTotales()
    End Sub
    Public Sub agregarCuenta(numcuenta, desccuenta, debe, haber)
        Dim dt As DataTable = DirectCast(dgvLista.DataSource, DataTable)
        Dim row As DataRow = dt.NewRow()
        row.Item(0) = "0"
        row.Item(1) = codComprobante
        row.Item(2) = numcuenta
        row.Item(3) = desccuenta
        row.Item(4) = haber
        row.Item(5) = debe
        dt.Rows.Add(row)
        seleccionarCuentaAdicionada(numcuenta)
        realizarSumasTotales()
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


    Private Sub btnBuscarComprobante_Click(sender As Object, e As EventArgs) Handles btnBuscarComprobante.Click
        cargarComprobante()
    End Sub

    Private Sub cargarComprobante()
        Dim numero As String = txtNumero.Text.Trim
        Dim serie As String = txtSerie.Text.Trim
        Dim data As New DataTable
        data = objNCD.comprobanteVentaPorSerieNumeroBD(serie, numero, CadenaConexion)

        If data.Rows.Count > 0 Then
            With data
                cboTipoDocumento.SelectedValue = .Rows(0)("id_tipo_comprobante").ToString
                dtFechaEmision.Value = .Rows(0)("fec_emision").ToString
                txtMonto.Text = .Rows(0)("base_imponible").ToString
                txtIgv.Text = .Rows(0)("valor_igv").ToString
                txtTotal.Text = .Rows(0)("total").ToString
                codComprobante = .Rows(0)("id").ToString
            End With
            cargarRegistroCuentas(codComprobante)
            realizarSumasTotales()
        Else
            MsgBox("No se han encontrado resultados con el comprobante de compra ingresado...")
        End If

    End Sub

    Private Sub realizarSumasTotales()
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
End Class