Imports Negocio
Public Class frmNuevaCompraRapida

    Dim objCrud As New nCrud
    Dim objCA As New nCuentaAsiento
    Dim objMon As New nMonedas
    Dim iCarga As Integer = 0
    Dim dtPagos As New DataTable
    Dim objTDA As New nTipoDocumentoAsiento
    Dim idTipoOperacion As Integer = 2

    Private Sub cargarTipoCompra()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add("CONTADO", "CONTADO")
        data.Rows.Add("CREDITO", "CREDITO")
        With cboTipoCompra
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub
    Private Sub cargarCuentasVentaApertura()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = objCA.nListarCuentasSegunTipoAsientoBD("COMPRA_APERTURA", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(1).ToString, row.Item(1).ToString)
            Next
            With cboCuentaVentaApertura
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Cuentas")
        End Try
    End Sub

    Private Sub CargarTipoDocumento()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = objTDA.nListarCuentasSegunTipoAsientoBD(idTipoOperacion, CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, "(" & row.Item(1).ToString & ") " & row.Item(2).ToString.ToUpper)
            Next
            With cboTipoDocumento
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Documentos")
        End Try
    End Sub

    Private Sub cargarTipoOperacion()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(1, "GRAVADA")
        data.Rows.Add(2, "EXPORTACION")
        data.Rows.Add(3, "EXONERADO")
        data.Rows.Add(4, "INAFECTO")

        With cboOperacion
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub

    Private Sub cargarMonedas()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListarBD("select id,codigo,descripcion from tipo_moneda where estado=1 order by codigo asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, "(" & row.Item(1).ToString & ") " & row.Item(2).ToString)
            Next
            With cboMoneda
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
                .SelectedValue = 115
            End With

            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Monedas")
        End Try
    End Sub
    Private Sub cargarTipoDeCambio()
        If iCarga = 1 Then
            Dim data As New DataTable
            data = objMon.nTipoDeCambioPorMonedaBD(cboMoneda.SelectedValue.ToString, CadenaConexion)
            'lblTipoDeCambio.Text = "Tipo de cambio: S/. " & data.Rows(0)("valor").ToString
            If data.Rows.Count > 0 Then
                txtTipoCambio.Text = data.Rows(0)("venta").ToString
            Else
                txtTipoCambio.Text = "1.00"
            End If
        End If
    End Sub

    Private Sub btnBuscarRuc_Click(sender As Object, e As EventArgs) Handles btnBuscarRuc.Click
        frmConsultaSunat.formInicio = "frmNuevaCompraRapida"
        frmConsultaSunat.numRuc = txtRuc.Text
        frmConsultaSunat.ShowDialog()
    End Sub

    Private Sub frmNuevaCompraCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvOperaciones.RowTemplate.Height = 35
        cebrasDatagrid(dgvOperaciones, Drawing.Color.White, Drawing.Color.FromArgb(182, 205, 226))
        cargarMonedas()
        cargarCuentasVentaApertura()
        CargarTipoDocumento()
        cargarTipoOperacion()
        cargarTipoCompra()
        iCarga = 1
        cargarTipoDeCambio()
        With dtPagos.Columns
            .Add("num_cuenta")
            .Add("desc_cuenta")
            .Add("costo")
            .Add("base_imponible")
            .Add("igv")
            .Add("isc")
            .Add("otros_impuestos")
            .Add("descuento")
            .Add("total")
        End With
    End Sub

    Private Sub cboCuentaVentaApertura_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCuentaVentaApertura.SelectedIndexChanged
        If iCarga = 1 Then
            Dim data As New DataTable
            data = objCA.nObtenerCuentaSegunIdBD(cboCuentaVentaApertura.SelectedValue.ToString, CadenaConexion)
            lblCuentaVenta.Text = data.Rows(0)("nombre")
        End If
    End Sub

    Private Sub cboMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMoneda.SelectedIndexChanged
        cargarTipoDeCambio()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        frmAgregarCuentasRapidas.monto = txtMonto.Text.Trim
        frmAgregarCuentasRapidas.Show()
    End Sub

    Private Sub txtMonto_TextChanged(sender As Object, e As EventArgs) Handles txtMonto.TextChanged
        Dim dataIgv As New DataTable
        dataIgv = objCrud.nCrudListarBD("select * from igv", CadenaConexion)
        Dim totalConIgv As Decimal
        totalConIgv = Format(txtMonto.Text * (1 + (dataIgv.Rows(0)("valor").ToString) / 100), "#,##0.00")
        txtIgv.Text = Format(txtMonto.Text * ((dataIgv.Rows(0)("valor").ToString) / 100), "#,##0.00")
        txtTotal.Text = totalConIgv
    End Sub

    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            'cargarItemPagos()
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim dtVentaCab, dtAsientoCab As New DataTable
        With dtVentaCab.Columns
            .Add("cuenta_comp")
            .Add("tipo_documento_comp")
            .Add("serie_comp")
            .Add("numero_comp")
            .Add("moneda_id")
            .Add("tc_comp")
            .Add("ruc")
            .Add("razon")
            .Add("glosa")
        End With
        dtVentaCab.Rows.Add(cboCuentaVentaApertura.Text, _
               cboTipoDocumento.SelectedValue.ToString, _
               txtSerie.Text.Trim, _
               txtNumero.Text.Trim, _
               cboMoneda.SelectedValue.ToString, _
               txtTipoCambio.Text.Trim, _
               txtRuc.Text.Trim, _
               txtRazonSocial.Text.Trim, _
               txtGlosa.Text.Trim)
        Dim tMonto, tIgv As Decimal

        For Each row As DataGridViewRow In dgvOperaciones.Rows
            'dtAsientoCab.Rows.Add(row.Cells("num_cuenta").Value, _
            '    row.Cells("desc_cuenta").Value, _
            '    row.Cells("porcentaje").Value, _
            '    row.Cells("debe").Value, _
            '    row.Cells("haber").Value)
        Next

        With frmPagoComprobanteCompraRapida
            .tipoCompra = cboTipoCompra.SelectedValue
            .fechaPago = dtFechaPago.Value().ToString("yyyy-MM-dd")
            .totalMonto = Format(tMonto, "#,##0.00")
            .totalIgv = Format(tIgv, "#,##0.00")
            .totalCompra = txtTotal.Text
            .dtCabeceraVenta = dtVentaCab
            '.dtAsientoVenta = dtAsientoCab
            .Show()
        End With
        'MsgBox(chkDetraccion.Checked)

    End Sub

    Private Sub txtRazonSocial_TextChanged(sender As Object, e As EventArgs) Handles txtRazonSocial.TextChanged
        txtGlosa.Text = txtRuc.Text.Trim & ", " & txtRazonSocial.Text.Trim & " - COMPRA DE MERCADERIA"
    End Sub


    Public Sub cargarCuentasExterna(nCuenta As String, dCuenta As String, tabla As DataTable)
        Dim dtItem As New DataTable
        With dtItem.Columns
            .Add("num_cuenta")
            .Add("desc_cuenta")
            .Add("porcentaje")
            .Add("debe")
            .Add("haber")
        End With
        If dgvOperaciones.RowCount = 0 Then
            dtItem.Rows.Add(nCuenta, dCuenta, "100".ToString, txtMonto.Text.Trim, "00.00")
        End If

        'Obtener parametros cuenta compras
        Dim dCompras As New DataTable
        dCompras = objCrud.nCrudListarBD("select * from cuentas_tipo_operacion where id_tipo_operacion=2 order by id asc", CadenaConexion)
        For Each line As DataRow In dCompras.Rows
            Dim cuentaText As String
            Dim dataC As New DataTable
            dataC = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & line.Item("num_cuenta").ToString & "'", CadenaConexion)
            cuentaText = dataC.Rows(0)("nombre").ToString
            If line.Item("num_cuenta").ToString.StartsWith("60") Or line.Item("num_cuenta").ToString.StartsWith("20") Then
            Else
                dtItem.Rows.Add(line.Item("num_cuenta").ToString, cuentaText, "100.00", IIf((line.Item("debe").ToString = "X"), txtIgv.Text.Trim, "00.00"), IIf((line.Item("haber").ToString = "X"), txtTotal.Text.Trim, "00.00"))
            End If
        Next
        'dCompra
        dtItem.Merge(tabla)
        dgvOperaciones.DataSource = dtItem
        realizarSumasTotales()
    End Sub

    Private Sub realizarSumasTotales()
        'MsgBox("suma total")
        Dim tDebe, tHaber, tDiferencia As Decimal
        For Each row As DataGridViewRow In dgvOperaciones.Rows
            tDebe += row.Cells("debe").Value
            tHaber += row.Cells("haber").Value
        Next
        tDiferencia = tDebe - tHaber

        txtTDebeS.Text = Format(tDebe, "#,##0.00")
        txtTHaberS.Text = Format(tHaber, "#,##0.00")
        txtDiferenciaS.Text = Format(tDiferencia, "#,##0.00")
    End Sub
End Class