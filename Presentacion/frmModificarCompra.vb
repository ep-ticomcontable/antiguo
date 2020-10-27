Imports Negocio
Imports Entidades
Public Class frmModificarCompra

    Dim objCrud As New nCrud
    Dim objCA As New nCuentaAsiento
    Dim objMon As New nMonedas
    Dim iCarga As Integer = 0
    Dim dtPagos As New DataTable
    Dim objTDA As New nTipoDocumentoAsiento
    Dim idTipoOperacion As Integer = 2
    'Dim CodigoLocalSession As Integer = 1
    'Dim CodigoEmpresaSession As Integer = 1
    Dim dataAsientos As New DataTable
    Dim mIgv As Decimal = 0
    Dim mTotal As Decimal = 0
    Dim montoDetraccion As Decimal = 0
    Public idCompra As Integer
    Public Sub cargarDatosCompra()
        Dim data As New DataTable
        data = objCrud.nCrudListarBD("select * from comprobante_compra where id='" & idCompra & "'", CadenaConexion)

        With data
            'CARGAR DATOS
            cboTipoDocumento.SelectedValue = .Rows(0)("id_tipo_comprobante").ToString
            txtSerie.Text = .Rows(0)("serie_comprobante").ToString
            txtNumero.Text = .Rows(0)("numero_comprobante").ToString
            cboOperacion.SelectedValue = IIf(Decimal.Parse(.Rows(0)("valor_igv").ToString) > 0, 1, 3)
            cboTipoCompra.SelectedValue = .Rows(0)("tipo_compra").ToString
            txtRuc.Text = .Rows(0)("num_dni").ToString
            txtRazonSocial.Text = .Rows(0)("razon_social").ToString
            cboPercepcion.SelectedValue = "0"
            cboTipoPercepcion.SelectedValue = "0"
            txtPorcPercep.Text = "0"
            txtGlosa.Text = .Rows(0)("glosa").ToString
            chkAsiento.Checked = False
            txtTotalCompra.Text = .Rows(0)("total").ToString
            txtCuenta.Text = "601"
            lblNomCuenta.Text = ""
            txtMontoCuenta.Text = "0.00"
            cboDH.SelectedValue = "D"
            cboCentroCosto.SelectedValue = .Rows(0)("centro_costo").ToString
            txtCuentaPago.Text = "101"
            lblCuentaPago.Text = ""
            txtMontoPago.Text = "0.00"
            txtDescripcionPago.Text = ""
            cboImpuestos.SelectedValue = "0"
            txtPorcentaje.Text = "0"
            cboSerieImpuesto.SelectedValue = "0"
            txtNumeroImpuesto.Text = "0"
            txtCDetraccion.Text = "104"
            lblDetraccion.Text = ""
            dtFechaEmision.Value = Date.Parse(.Rows(0)("fec_emision").ToString)
            dtFechaPago.Value = Date.Parse(.Rows(0)("fec_pago").ToString)
            Dim asientos As New DataTable
            asientos = objCrud.nCrudListarBD("select * from asientos_comprobante_compra where id_comprobante_compra='" & idCompra & "'", CadenaConexion)

            Dim dtData As New DataTable
            With dtData.Columns
                .Add("num_cuenta")
                .Add("desc_cuenta")
                .Add("debe")
                .Add("haber")
                .Add("descripcion")
                .Add("impuesto")
                .Add("serie")
                .Add("numero")
            End With

            For Each row As DataRow In asientos.Rows
                With row
                    dtData.Rows.Add(.Item("cuenta"), obtenerDatosCuenta(.Item("cuenta")), .Item("debe"), .Item("haber"), .Item("impuesto"), .Item("serie"), .Item("numero"), .Item("operacion"))
                End With
            Next
            dgvOperaciones.DataSource = dtData
        End With

        ''CARGAR DATOS
        'cboTipoDocumento.SelectedValue = "0"
        'txtSerie.Text = "0"
        'txtNumero.Text = "0"
        'cboOperacion.SelectedValue = "1"
        'cboTipoCompra.SelectedValue = "CREDITO"
        'txtRuc.Text = ""
        'txtRazonSocial.Text = ""
        'cboPercepcion.SelectedValue = "0"
        'cboTipoPercepcion.SelectedValue = "0"
        'txtPorcPercep.Text = "0"
        'txtGlosa.Text = ""
        'chkAsiento.Checked = False
        'txtTotalCompra.Text = "0.00"
        'txtCuenta.Text = "601"
        'lblNomCuenta.Text = ""
        'txtMontoCuenta.Text = "0.00"
        'cboDH.SelectedValue = "D"
        'cboCentroCosto.SelectedValue = "0"
        'txtCuentaPago.Text = "101"
        'lblCuentaPago.Text = ""
        'txtMontoPago.Text = "0.00"
        'txtDescripcionPago.Text = ""
        'cboImpuestos.SelectedValue = "0"
        'txtPorcentaje.Text = "0"
        'cboSerieImpuesto.SelectedValue = "0"
        'txtNumeroImpuesto.Text = "0"
        'txtCDetraccion.Text = "104"
        'lblDetraccion.Text = ""
        'Dim dtData As New DataTable
        'With dtData.Columns
        '    .Add("num_cuenta")
        '    .Add("desc_cuenta")
        '    .Add("debe")
        '    .Add("haber")
        '    .Add("descripcion")
        '    .Add("impuesto")
        '    .Add("serie")
        '    .Add("numero")
        'End With
        'dgvOperaciones.DataSource = dtData

    End Sub
    Private Sub movimientoDH()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add("D", "D")
        data.Rows.Add("H", "H")
        With cboDH
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub
    Private Sub cargarCentroDeCostos()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add("0", "SIN AFECTO")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListarBD("select * from centro_costos where id_local='" & CodigoLocalSession & "' and estado=1 order by descripcion asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(2).ToString)
            Next
            data.Rows.Add("XXX", "AGREGAR NUEVO CENTRO")
            With cboCentroCosto
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Centro de Costos")
        End Try
    End Sub
    Private Sub cargarTipoCompra()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add("CREDITO", "CRÉDITO")
        data.Rows.Add("CONTADO", "CONTADO")
        With cboTipoCompra
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub
    Private Sub cargarImpuestosSunatCredito()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "SIN AFECTO")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListarBD("select * from impuestos_sunat where tipo_comprobante='COMPRA' and estado=1", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(2).ToString)
            Next
            With cboPercepcion
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Impuestos")
        End Try
    End Sub
    Private Sub cargarImpuestosSunat()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "SIN AFECTO")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListarBD("select * from impuestos_sunat where tipo_comprobante='COMPRA' and estado=1", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(2).ToString)
            Next
            With cboImpuestos
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Impuestos")
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
    Private Sub txtCuentaP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuentaP.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtCuentaP.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "frmNuevaCompraP"
                    .cuentaInicio = txtCuentaP.Text.Trim
                    .ShowDialog()
                End With
            End If
        End If
    End Sub
    Private Sub txtCDetraccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCDetraccion.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtCDetraccion.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "frmNuevaCompraDetraccion"
                    .cuentaInicio = txtCDetraccion.Text.Trim
                    .ShowDialog()
                End With
            End If
        End If
    End Sub
    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtCuenta.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "frmNuevaCompra"
                    .cuentaInicio = txtCuenta.Text.Trim
                    .ShowDialog()
                End With
            End If
        End If
    End Sub
    Private Sub lblNomCuenta_TextChanged(sender As Object, e As EventArgs) Handles lblNomCuenta.TextChanged
        habilitarCentroCostoCompra()
    End Sub
    Public Sub habilitarCentroCostoCompra()
        Dim cuentaCC As New DataTable
        'Dim data2 As DataTable
        cuentaCC = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & txtCuenta.Text.Trim & "'", CadenaConexion)
        If cuentaCC.Rows.Count > 0 Then
            If Integer.Parse(cuentaCC.Rows(0)("c1").ToString) > 0 Then
                cboCentroCosto.SelectedValue = 0
                cboCentroCosto.Enabled = True
                MessageBox.Show("Elija un Centro de Costo para esta cuenta.", "Registro de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                cboCentroCosto.Focus()
            Else
                cboCentroCosto.SelectedValue = 0
                cboCentroCosto.Enabled = False
            End If
        End If
    End Sub
    Private Sub txtCuentaPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuentaPago.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtCuentaPago.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "frmNuevaCompraPago"
                    .cuentaInicio = txtCuentaPago.Text.Trim
                    .ShowDialog()
                End With
            End If
        End If
    End Sub
    Private Sub btnBuscarRuc_Click(sender As Object, e As EventArgs) Handles btnBuscarRuc.Click
        frmConsultaSunat.formInicio = "frmNuevaCompraCredito"
        frmConsultaSunat.numRuc = txtRuc.Text
        frmConsultaSunat.ShowDialog()
    End Sub
    Private Sub cargarTipoDeCambio()
        If iCarga = 1 Then
            Dim data As New DataTable
            data = objMon.nTipoDeCambioPorMoneda(cboMoneda.SelectedValue.ToString)
            'lblTipoDeCambio.Text = "Tipo de cambio: S/. " & data.Rows(0)("valor").ToString
            If data.Rows.Count > 0 Then
                txtTipoCambio.Text = data.Rows(0)("venta").ToString
            Else
                txtTipoCambio.Text = "1.00"
            End If
        End If
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
    Private Sub frmNuevaCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelPercepcion.Visible = True
        txtGlosa.Width = 418
        dgvOperaciones.RowTemplate.Height = 25
        cebrasDatagrid(dgvOperaciones, Drawing.Color.White, Drawing.Color.FromArgb(182, 205, 226))
        cargarImpuestosSunat()
        cargarImpuestosSunatCredito()
        cargarCentroDeCostos()
        CargarTipoDocumento()
        cargarTipoOperacion()
        cargarTipoCompra()
        cargarMonedas()
        cboSerieImpuesto.Enabled = False
        txtNumeroImpuesto.Enabled = False
        movimientoDH()
        iCarga = 1
        cargarDatosCompra()
        cargarTipoDeCambio()
        realizarSumasTotales()
        With dtPagos.Columns
            .Add("num_cuenta")
            .Add("desc_cuenta")
            .Add("costo")
            .Add("base_imponible")
            .Add("igv")
            '.Add("isc")
            '.Add("otros_impuestos")
            '.Add("descuento")
            .Add("total")
        End With
        resetearFormulario()
    End Sub
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
    Private Sub cboTipoCompra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoCompra.SelectedIndexChanged
        If iCarga = 1 Then
            vistaModuloPagos()
        End If
    End Sub
    Private Sub resetearFormulario()
        panelPago.Visible = False
        panelAsientos.Location = New Point(12, 300)
        Me.Height = 640
    End Sub
    Private Sub vistaModuloPagos()
        If cboTipoCompra.SelectedValue = "CONTADO" Then
            panelPago.Visible = True
            panelAsientos.Location = New Point(12, 418)
            Me.Height = 765
            panelPercepcion.Visible = False
            txtGlosa.Width = 684
        ElseIf cboTipoCompra.SelectedValue = "CREDITO" Then
            panelPago.Visible = False
            panelAsientos.Location = New Point(12, 300)
            Me.Height = 647
            panelPercepcion.Visible = True
            txtGlosa.Width = 418
        End If
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs)
        cargarItemPagos()
    End Sub
    Private Sub cargarItemPagos()
        Dim dtItemPagos As New DataTable
        With dtItemPagos.Columns
            .Add("num_cuenta")
            .Add("desc_cuenta")
            .Add("costo")
            .Add("base_imponible")
            .Add("igv")
            '.Add("isc")
            '.Add("otros_impuestos")
            '.Add("descuento")
            .Add("total")
        End With
        dtItemPagos.Rows.Add(txtCuenta.Text.Trim, _
                        lblNomCuenta.Text, _
                        mTotal, _
                        txtMontoCuenta.Text.Trim, _
                        mIgv, _
                        mTotal)
        dtPagos.Merge(dtItemPagos)
        dgvOperaciones.DataSource = dtPagos
        'MsgBox(dtPagos.Rows.Count)
    End Sub
    Private Sub txtMonto_TextChanged(sender As Object, e As EventArgs) Handles txtMontoCuenta.TextChanged
    End Sub
    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMontoCuenta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            'cargarItemPagos()
        End If
    End Sub
    Private Sub txtRazonSocial_TextChanged(sender As Object, e As EventArgs) Handles txtRazonSocial.TextChanged
        txtGlosa.Text = txtRuc.Text.Trim & ", " & txtRazonSocial.Text.Trim & " - COMPRA DE MERCADERIA"
    End Sub
    Private Sub cboMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMoneda.SelectedIndexChanged
        cargarTipoDeCambio()
    End Sub
    Private Sub cboImpuestos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboImpuestos.SelectedIndexChanged
        If iCarga = 1 Then
            If cboImpuestos.SelectedValue.ToString <> "0" Then
                cboSerieImpuesto.Enabled = True
                txtNumeroImpuesto.Enabled = True

                Dim dataPorc As New DataTable
                dataPorc = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & cboImpuestos.SelectedValue.ToString & "'", CadenaConexion)
                If dataPorc.Rows.Count > 0 Then
                    txtPorcentaje.Text = dataPorc.Rows(0)("porcentaje").ToString
                Else
                    txtPorcentaje.Text = "0"
                End If

                If cboImpuestos.Text = "DETRACCIÓN" Then
                    panelDetraccion.Enabled = True
                Else
                    panelDetraccion.Enabled = False
                End If
                If cboImpuestos.SelectedValue = "0" Then
                    cboSerieImpuesto.Enabled = False
                    txtNumeroImpuesto.Enabled = False
                Else
                    cboSerieImpuesto.Enabled = True
                    txtNumeroImpuesto.Enabled = True
                    Dim data As New DataTable
                    data.Columns.Add("Codigo")
                    data.Columns.Add("Descripcion")
                    Dim data2 As DataTable
                    Try
                        data2 = objCrud.nCrudListarBD("select * from empresa_agente where id_empresa='" & CodigoEmpresaSession & "' and id_impuesto_sunat='" & cboImpuestos.SelectedValue.ToString & "' and estado=1", CadenaConexion)
                        For Each row As DataRow In data2.Rows
                            data.Rows.Add(row.Item("id").ToString, row.Item("serie").ToString)
                        Next
                        With cboSerieImpuesto
                            .DataSource = data
                            .ValueMember = "Codigo"
                            .DisplayMember = "Descripcion"
                        End With
                        data2.Dispose()
                    Catch ex As Exception
                        MsgBox("No se pudo cargar la lista de Impuestos")
                    End Try
                End If
            Else
                cboSerieImpuesto.Enabled = False
                txtNumeroImpuesto.Enabled = False
            End If

        End If
    End Sub
    Private Sub cboSerieImpuesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSerieImpuesto.SelectedIndexChanged
        If iCarga = 1 Then
            Dim data As New DataTable
            data = objCrud.nCrudListarBD("select * from empresa_agente where id='" & cboSerieImpuesto.SelectedValue.ToString & "' and estado=1", CadenaConexion)
            If data.Rows.Count > 0 Then
                txtNumeroImpuesto.Text = data.Rows(0)("numero").ToString
            Else
                txtNumeroImpuesto.Text = 0
            End If
        End If
    End Sub
    Private Sub btnAgregarCuenta_Click(sender As Object, e As EventArgs) Handles btnAgregarCuenta.Click
        Dim dtData As New DataTable
        With dtData.Columns
            .Add("num_cuenta")
            .Add("desc_cuenta")
            .Add("debe")
            .Add("haber")
            .Add("descripcion")
            .Add("impuesto")
            .Add("serie")
            .Add("numero")
        End With
        Dim montoCuenta As Decimal = 0
        If txtMontoCuenta.Text.Trim.Length = 0 Then
            montoCuenta = 0
        Else
            montoCuenta = txtMontoCuenta.Text.Trim
        End If

        Dim data40 As New DataTable
        data40 = objCrud.nCrudListarBD("select * from  igv where estado=1", CadenaConexion)

        'MsgBox(dgvOperaciones.RowCount)
        If dgvOperaciones.RowCount > 0 Then
            mIgv = 0
            mTotal = montoCuenta
        Else
            Dim dataIgv As New DataTable
            dataIgv = objCrud.nCrudListarBD("select * from igv", CadenaConexion)
            Dim totalConIgv As Decimal
            totalConIgv = IIf(cboOperacion.SelectedValue = "1", Format(montoCuenta * (1 + (dataIgv.Rows(0)("valor").ToString) / 100), "#,##0.00"), Format(montoCuenta, "#,##0.00"))
            mIgv = IIf(cboOperacion.SelectedValue = "1", (Format(montoCuenta * ((dataIgv.Rows(0)("valor").ToString) / 100), "#,##0.00")), "0.00")
            mTotal = totalConIgv
        End If

        If dgvOperaciones.RowCount = 0 Then
            'CUENTA 60
            If cboDH.SelectedValue.ToString = "D" Then
                dtData.Rows.Add(txtCuenta.Text.Trim, obtenerDatosCuenta(txtCuenta.Text.Trim), montoCuenta, "0.00", "-", "-", "-", "-")
            End If
            If cboDH.SelectedValue.ToString = "H" Then
                dtData.Rows.Add(txtCuenta.Text.Trim, obtenerDatosCuenta(txtCuenta.Text.Trim), "0.00", montoCuenta, "-", "-", "-", "-")
            End If
            'CUENTA 40
            If data40.Rows.Count Then
                dtData.Rows.Add(data40.Rows(0)("cuenta").ToString, obtenerDatosCuenta(data40.Rows(0)("cuenta").ToString), mIgv, "0.00", "-", "-", "-", "-")
            End If
            'CUENTA 42
            If cboPercepcion.Text <> "PERCEPCIÓN" Or cboTipoPercepcion.SelectedValue = "E" Then
                dtData.Rows.Add(txtCuentaP.Text.Trim, obtenerDatosCuenta(txtCuentaP.Text.Trim), "0.00", mTotal, "-", "-", "-", "-")
            End If


            Dim calculoIPercepcion As Decimal = 0
            If cboTipoPercepcion.SelectedValue = "I" And cboPercepcion.Visible = True Then
                Dim dataIC As New DataTable
                dataIC = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & cboPercepcion.SelectedValue.ToString & "'", CadenaConexion)
                Dim montoMasIgv As Decimal
                Dim dataIgv As New DataTable
                dataIgv = objCrud.nCrudListarBD("select * from igv", CadenaConexion)
                mIgv = Decimal.Parse(txtMontoCuenta.Text.Trim) * ((dataIgv.Rows(0)("valor").ToString) / 100)
                montoMasIgv = Decimal.Parse(txtMontoCuenta.Text.Trim) + mIgv
                calculoIPercepcion = Decimal.Round((Decimal.Parse(dataIC.Rows(0)("porcentaje").ToString) * montoMasIgv / 100), 2)

                dtData.Rows.Add(txtCuentaP.Text.Trim, obtenerDatosCuenta(txtCuentaP.Text.Trim), "0.00", (calculoIPercepcion + mTotal), "-", "-", "-", "-")
                dtData.Rows.Add(dataIC.Rows(0)("cuenta").ToString, obtenerDatosCuenta(dataIC.Rows(0)("cuenta").ToString), (calculoIPercepcion), "0.00", cboPercepcion.Text & ": " & txtPorcPercep.Text, "-", "-", "-")

                ''CUENTA DE PAGO DETRACCION
                'For Each fila As DataGridViewRow In dgvOperaciones.Rows
                '    If IIf(cboPercepcion.Text = "DETRACCIÓN", txtCDetraccion.Text.Trim, dataIC.Rows(0)("cuenta").ToString) = fila.Cells("num_cuenta").Value.ToString Then
                '        Dim suma As Decimal
                '        suma = Format(calculoIPercepcion, "0.00")
                '        fila.Cells("haber").Value += suma
                '    End If
                'Next
                ''SI ENCUENTRA UNA CUENTA REPETIDA
                'Dim estadoRepPag2 As Integer = 0

                'For Each fila As DataGridViewRow In dgvOperaciones.Rows
                '    If IIf(cboPercepcion.Text = "DETRACCIÓN", txtCDetraccion.Text.Trim, dataIC.Rows(0)("cuenta").ToString) = fila.Cells("num_cuenta").Value.ToString Then
                '        estadoRepPag2 = 1
                '        Exit For
                '    Else
                '        estadoRepPag2 = 0
                '    End If
                'Next
                'If estadoRepPag2 = 0 Then
                '    Dim dtI As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
                '    Dim row4 As DataRow = dtI.NewRow()
                '    row4.Item(0) = IIf(cboPercepcion.Text = "DETRACCIÓN", txtCDetraccion.Text.Trim, dataIC.Rows(0)("cuenta").ToString)
                '    row4.Item(1) = obtenerDatosCuenta(IIf(cboPercepcion.Text = "DETRACCIÓN", txtCDetraccion.Text.Trim, dataIC.Rows(0)("cuenta").ToString))
                '    row4.Item(2) = IIf(cboPercepcion.Text = "PERCEPCIÓN", calculoIPercepcion, "0.00")
                '    row4.Item(3) = IIf(cboPercepcion.Text <> "PERCEPCIÓN", calculoIPercepcion, "0.00")
                '    row4.Item(4) = cboImpuestos.Text & ": " & cboSerieImpuesto.Text & "-" & txtNumeroImpuesto.Text
                '    row4.Item(5) = "-"
                '    row4.Item(6) = "-"
                '    row4.Item(7) = "-"
                '    dtI.Rows.Add(row4)
                'End If
            End If


            'AGREGANDO ASIENTO DE TRANSFERENCIA
            If chkAsiento.Checked = True Then
                If txtCuenta.Text.Trim.StartsWith("60") Then
                    Dim dataCuenta As New DataTable
                    dataCuenta = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & txtCuenta.Text.Trim & "'", CadenaConexion)
                    'MsgBox(dataCuenta.Rows(0)("cuenta_debe").ToString)
                    If dataCuenta.Rows(0)("cuenta_debe").ToString.Trim <> "" And dataCuenta.Rows(0)("cuenta_haber").ToString.Trim <> "" Then
                        dtData.Rows.Add(dataCuenta.Rows(0)("cuenta_debe").ToString, obtenerDatosCuenta(dataCuenta.Rows(0)("cuenta_debe").ToString), txtMontoCuenta.Text.Trim, "0.00", "-", "-", "-", "-")
                        dtData.Rows.Add(dataCuenta.Rows(0)("cuenta_haber").ToString, obtenerDatosCuenta(dataCuenta.Rows(0)("cuenta_haber").ToString), "0.00", txtMontoCuenta.Text.Trim, "-", "-", "-", "-")
                    End If
                End If
            End If

        ElseIf dgvOperaciones.RowCount > 0 Then
            For Each row As DataGridViewRow In dgvOperaciones.Rows
                'If txtCuentaP.Text.Trim = row.Cells("num_cuenta").Value.ToString Then
                'row.Cells("haber").Value += Decimal.Round(mTotal, 2)
                'End If
                'If data40.Rows(0)("cuenta").ToString = row.Cells("num_cuenta").Value.ToString Then
                '    row.Cells("debe").Value += Decimal.Round(mIgv, 2)
                'End If
                If txtCuenta.Text.Trim = row.Cells("num_cuenta").Value.ToString Then
                    If cboDH.SelectedValue.ToString = "D" Then
                        row.Cells("debe").Value += Decimal.Round(Decimal.Parse(montoCuenta), 2)
                    Else
                        row.Cells("haber").Value += Decimal.Round(Decimal.Parse(montoCuenta), 2)
                    End If
                End If
            Next
            'SI ENCUENTRA UNA CUENTA REPETIDA
            Dim estadoRep As Integer = 0

            For Each row As DataGridViewRow In dgvOperaciones.Rows
                If txtCuenta.Text.Trim = row.Cells("num_cuenta").Value.ToString Then
                    estadoRep = 1
                    Exit For
                Else
                    estadoRep = 0
                End If
            Next
            If estadoRep = 0 Then
                dtData.Rows.Add(txtCuenta.Text.Trim, obtenerDatosCuenta(txtCuenta.Text.Trim), IIf(cboDH.SelectedValue.ToString = "D", montoCuenta, "0.00"), IIf(cboDH.SelectedValue.ToString = "H", montoCuenta, "0.00"), "-", "-", "-", "-")
            End If
        End If
        ''CUENTAS SI SELECCIONA UN CENTRO DE COSTO
        'If cboCentroCosto.SelectedValue.ToString <> "0" Then
        '    Dim valorCentro As String = cboCentroCosto.SelectedValue.ToString
        '    'MsgBox(valorCentro)
        '    Dim listaCC As New DataTable
        '    listaCC = objCrud.nCrudListarBD("select * from parametro_centro_costo where id_centro='" & valorCentro & "' and estado=1", CadenaConexion)
        '    'MsgBox(listaCC.Rows.Count)
        '    For Each item As DataRow In listaCC.Rows
        '        With item
        '            Dim calculoCC As Decimal
        '            Dim totalCuenta As Decimal = Decimal.Parse(montoCuenta)
        '            calculoCC = Decimal.Round((totalCuenta - (totalCuenta * Decimal.Parse(.Item("porcentaje").ToString) / 100)), 2)
        '            Dim descripcionCC As String = .Item("descripcion").ToString & "(" & .Item("porcentaje").ToString & "%)"
        '            dtData.Rows.Add(.Item("cuenta").ToString, obtenerDatosCuenta(.Item("cuenta").ToString), IIf((.Item("debe").ToString = "1"), calculoCC, "0.00"), IIf((.Item("haber").ToString = "1"), calculoCC, "0.00"), descripcionCC, "-", "-", "-", "-", "-", "-")
        '        End With
        '    Next
        'End If



        dataAsientos.Merge(dtData)
        dgvOperaciones.DataSource = dataAsientos
        realizarSumasTotales()
    End Sub
    Private Sub comentarios()
        'If txtCuenta.Text.Trim.StartsWith("60") Then
        '    Dim dataCab As New DataTable
        '    dataCab = objCrud.nCrudListarBD("select * from cuentas_tipo_operacion where id_tipo_operacion='2' and tipo_proceso=1", CadenaConexion)
        '    'txtCuenta.Text.Trim.Substring(1, 2).StartsWith("60")
        '    For Each line As DataRow In dataCab.Rows
        '        'dtData.Rows.Add(dataCab.Rows(i)("num_cuenta").ToString, obtenerDatosCuenta(dataCab.Rows(i)("num_cuenta").ToString), (IIf((dataCab.Rows(i)("movimiento").ToString = "D"), (IIf((dataCab.Rows(i)("cuenta").ToString.StartsWith("40") And dataCab.Rows(i)("movimiento").ToString = "D"), txtIgv.Text, txtTotal.Text)), "00.00")), (IIf((dataCab.Rows(i)("movimiento").ToString = "H"), (IIf((dataCab.Rows(i)("cuenta").ToString.StartsWith("42") And dataCab.Rows(i)("movimiento").ToString = "H"), tTotal, totalIgv)))
        '        dtData.Rows.Add(line.Item("num_cuenta").ToString, obtenerDatosCuenta(line.Item("num_cuenta").ToString), IIf((line.Item("debe").ToString = "X" And line.Item("num_cuenta").ToString.StartsWith("40")), txtIgv.Text.Trim, IIf((line.Item("num_cuenta").ToString.StartsWith("42") Or line.Item("num_cuenta").ToString.StartsWith("61")), "0.00", txtMontoCuenta.Text)), IIf((line.Item("haber").ToString = "X" And line.Item("num_cuenta").ToString.StartsWith("42")), txtTotal.Text.Trim, IIf(line.Item("num_cuenta").ToString.StartsWith("61"), txtMontoCuenta.Text, "0.00")), "-", "-", "-", "-", "-", "-", "-")
        '    Next
        'End If
        'If txtCuenta.Text.Trim.StartsWith("63") Then
        '    Dim dataCab As New DataTable
        '    dataCab = objCrud.nCrudListarBD("select * from cuentas_tipo_operacion where id_tipo_operacion='2' and tipo_proceso=2", CadenaConexion)
        '    For Each line As DataRow In dataCab.Rows
        '        'dtData.Rows.Add(dataCab.Rows(i)("num_cuenta").ToString, obtenerDatosCuenta(dataCab.Rows(i)("num_cuenta").ToString), (IIf((dataCab.Rows(i)("movimiento").ToString = "D"), (IIf((dataCab.Rows(i)("cuenta").ToString.StartsWith("40") And dataCab.Rows(i)("movimiento").ToString = "D"), txtIgv.Text, txtTotal.Text)), "00.00")), (IIf((dataCab.Rows(i)("movimiento").ToString = "H"), (IIf((dataCab.Rows(i)("cuenta").ToString.StartsWith("42") And dataCab.Rows(i)("movimiento").ToString = "H"), tTotal, totalIgv)))
        '        dtData.Rows.Add(line.Item("num_cuenta").ToString, obtenerDatosCuenta(line.Item("num_cuenta").ToString), IIf((line.Item("debe").ToString = "X" And line.Item("num_cuenta").ToString.StartsWith("40")), txtIgv.Text.Trim, IIf((line.Item("num_cuenta").ToString.StartsWith("42") Or line.Item("num_cuenta").ToString.StartsWith("64")), "0.00", txtMontoCuenta.Text)), IIf((line.Item("haber").ToString = "X" And line.Item("num_cuenta").ToString.StartsWith("42")), txtTotal.Text.Trim, IIf(line.Item("num_cuenta").ToString.StartsWith("64"), txtMontoCuenta.Text, "0.00")), "-", "-", "-", "-", "-", "-", "-")
        '    Next
        'End If
    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        frmPlanContable.Show()
    End Sub
    Private Sub btnCargarDatos_Click(sender As Object, e As EventArgs) Handles btnCargarDatos.Click
        If cboImpuestos.SelectedValue.ToString <> "0" Then
            Dim calculoI As Decimal
            Dim dataIC As New DataTable
            dataIC = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & cboImpuestos.SelectedValue.ToString & "'", CadenaConexion)

            calculoI = Decimal.Round((Decimal.Parse(dataIC.Rows(0)("porcentaje").ToString) * Decimal.Parse(txtTotalCompra.Text.Trim) / 100), 2)
            montoDetraccion = calculoI

            For Each fila As DataGridViewRow In dgvOperaciones.Rows
                If txtCuentaP.Text.Trim = fila.Cells("num_cuenta").Value.ToString Then
                    Dim suma As Decimal
                    suma = IIf(cboImpuestos.Text = "PERCEPCIÓN", Decimal.Parse(txtMontoPago.Text.Trim), Format(Decimal.Parse(txtMontoPago.Text) - calculoI, "0.00"))
                    fila.Cells("debe").Value += suma
                End If
            Next
            'SI ENCUENTRA UNA CUENTA REPETIDA
            Dim estadoRepCab As Integer = 0

            For Each fila As DataGridViewRow In dgvOperaciones.Rows
                If txtCuentaP.Text.Trim = fila.Cells("num_cuenta").Value.ToString Then
                    estadoRepCab = 1
                    Exit For
                Else
                    estadoRepCab = 0
                End If
            Next
            If estadoRepCab = 0 Then
                '''''CUENTA 42
                Dim dt2 As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
                Dim row2 As DataRow = dt2.NewRow()
                row2.Item(0) = txtCuentaP.Text.Trim
                row2.Item(1) = obtenerDatosCuenta(txtCuentaP.Text.Trim)
                row2.Item(2) = Decimal.Parse(txtMontoPago.Text) - calculoI
                row2.Item(3) = "0.00"
                row2.Item(4) = txtDescripcionPago.Text.Trim
                row2.Item(5) = "-"
                row2.Item(6) = "-"
                row2.Item(7) = "-"
                dt2.Rows.Add(row2)
                ''''''''''''''''''''''''FIN CUENTA 42''''''''''''''''''''''''''''''''''''''
            End If

            For Each fila As DataGridViewRow In dgvOperaciones.Rows
                If txtCuentaPago.Text.Trim = fila.Cells("num_cuenta").Value.ToString Then
                    Dim suma As Decimal
                    suma = Format(Decimal.Parse(txtMontoPago.Text) - calculoI, "0.00")
                    fila.Cells("haber").Value += suma
                End If
            Next
            'SI ENCUENTRA UNA CUENTA REPETIDA
            Dim estadoRepPag As Integer = 0

            For Each fila As DataGridViewRow In dgvOperaciones.Rows
                If txtCuentaPago.Text.Trim = fila.Cells("num_cuenta").Value.ToString Then
                    estadoRepPag = 1
                    Exit For
                Else
                    estadoRepPag = 0
                End If
            Next
            If estadoRepPag = 0 Then
                ''''''''''''''''''''''''CUENTA DE PAGO 10''''''''''''''''''''''''''''''''''''''
                Dim dt As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
                Dim row As DataRow = dt.NewRow()
                row.Item(0) = txtCuentaPago.Text.Trim
                row.Item(1) = obtenerDatosCuenta(txtCuentaPago.Text.Trim)
                row.Item(2) = "0.00"
                row.Item(3) = IIf(cboImpuestos.Text = "PERCEPCIÓN", Decimal.Parse(txtMontoPago.Text), Decimal.Parse(txtMontoPago.Text) - calculoI)
                row.Item(4) = txtDescripcionPago.Text.Trim
                row.Item(5) = "-"
                row.Item(6) = "-"
                row.Item(7) = "-"
                dt.Rows.Add(row)
            End If


            'INICIO cuenta 42
            For Each fila As DataGridViewRow In dgvOperaciones.Rows
                If IIf(cboImpuestos.Text = "DETRACCIÓN", dataIC.Rows(0)("cuenta").ToString, txtCuentaP.Text.Trim) = fila.Cells("num_cuenta").Value.ToString Then
                    Dim suma As Decimal
                    suma = Format(calculoI, "0.00")
                    If cboImpuestos.Text = "PERCEPCIÓN" Then
                        fila.Cells("haber").Value += suma
                    Else
                        fila.Cells("debe").Value += suma
                    End If
                End If
            Next
            'SI ENCUENTRA UNA CUENTA REPETIDA
            Dim estadoRepCab2 As Integer = 0

            For Each fila As DataGridViewRow In dgvOperaciones.Rows
                If IIf(cboImpuestos.Text = "DETRACCIÓN", dataIC.Rows(0)("cuenta").ToString, txtCuentaP.Text.Trim) = fila.Cells("num_cuenta").Value.ToString Then
                    estadoRepCab2 = 1
                    Exit For
                Else
                    estadoRepCab2 = 0
                End If
            Next
            If estadoRepCab2 = 0 Then
                '''''CUENTA 42 IMPUESTO
                Dim dt3 As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
                Dim row3 As DataRow = dt3.NewRow()
                row3.Item(0) = IIf(cboImpuestos.Text = "DETRACCIÓN", dataIC.Rows(0)("cuenta").ToString, txtCuentaP.Text.Trim)
                row3.Item(1) = obtenerDatosCuenta(IIf(cboImpuestos.Text = "DETRACCIÓN", dataIC.Rows(0)("cuenta").ToString, txtCuentaP.Text.Trim))
                row3.Item(2) = calculoI
                row3.Item(3) = "0.00"
                row3.Item(4) = cboImpuestos.Text & ": " & cboSerieImpuesto.Text & "-" & txtNumeroImpuesto.Text
                row3.Item(5) = "-"
                row3.Item(6) = "-"
                row3.Item(7) = "-"
                dt3.Rows.Add(row3)
            End If

            'CUENTA DE PAGO DETRACCION
            For Each fila As DataGridViewRow In dgvOperaciones.Rows
                If IIf(cboImpuestos.Text = "DETRACCIÓN", txtCDetraccion.Text.Trim, dataIC.Rows(0)("cuenta").ToString) = fila.Cells("num_cuenta").Value.ToString Then
                    Dim suma As Decimal
                    suma = Format(calculoI, "0.00")
                    fila.Cells("haber").Value += suma
                End If
            Next
            'SI ENCUENTRA UNA CUENTA REPETIDA
            Dim estadoRepPag2 As Integer = 0

            For Each fila As DataGridViewRow In dgvOperaciones.Rows
                If IIf(cboImpuestos.Text = "DETRACCIÓN", txtCDetraccion.Text.Trim, dataIC.Rows(0)("cuenta").ToString) = fila.Cells("num_cuenta").Value.ToString Then
                    estadoRepPag2 = 1
                    Exit For
                Else
                    estadoRepPag2 = 0
                End If
            Next
            If estadoRepPag2 = 0 Then
                Dim dtI As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
                Dim row4 As DataRow = dtI.NewRow()
                row4.Item(0) = IIf(cboImpuestos.Text = "DETRACCIÓN", txtCDetraccion.Text.Trim, dataIC.Rows(0)("cuenta").ToString)
                row4.Item(1) = obtenerDatosCuenta(IIf(cboImpuestos.Text = "DETRACCIÓN", txtCDetraccion.Text.Trim, dataIC.Rows(0)("cuenta").ToString))
                row4.Item(2) = IIf(cboImpuestos.Text = "PERCEPCIÓN", calculoI, "0.00")
                row4.Item(3) = IIf(cboImpuestos.Text <> "PERCEPCIÓN", calculoI, "0.00")
                row4.Item(4) = cboImpuestos.Text & ": " & cboSerieImpuesto.Text & "-" & txtNumeroImpuesto.Text
                row4.Item(5) = "-"
                row4.Item(6) = "-"
                row4.Item(7) = "-"
                dtI.Rows.Add(row4)
            End If
        Else
            For Each fila As DataGridViewRow In dgvOperaciones.Rows
                If txtCuentaP.Text.Trim = fila.Cells("num_cuenta").Value.ToString Then
                    Dim suma As Decimal
                    suma = Format(Decimal.Parse(txtMontoPago.Text.Trim), "0.00")
                    fila.Cells("debe").Value += suma
                End If
            Next
            'SI ENCUENTRA UNA CUENTA REPETIDA
            Dim estadoRepCab As Integer = 0

            For Each fila As DataGridViewRow In dgvOperaciones.Rows
                If txtCuentaP.Text.Trim = fila.Cells("num_cuenta").Value.ToString Then
                    estadoRepCab = 1
                    Exit For
                Else
                    estadoRepCab = 0
                End If
            Next
            If estadoRepCab = 0 Then
                '''''CUENTA CABECERA
                Dim dt2 As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
                Dim row2 As DataRow = dt2.NewRow()
                row2.Item(0) = txtCuentaP.Text.Trim
                row2.Item(1) = obtenerDatosCuenta(txtCuentaP.Text.Trim)
                row2.Item(2) = txtTotalCompra.Text.Trim
                row2.Item(3) = "0.00"
                row2.Item(4) = txtDescripcionPago.Text.Trim
                row2.Item(5) = "-"
                row2.Item(6) = "-"
                row2.Item(7) = "-"
                dt2.Rows.Add(row2)
                ''''''''''''''''''''''''FIN CUENTA CABECERA''''''''''''''''''''''''''''''''''''''
            End If

            For Each fila As DataGridViewRow In dgvOperaciones.Rows
                If txtCuentaPago.Text.Trim = fila.Cells("num_cuenta").Value.ToString Then
                    Dim suma As Decimal
                    suma = Format(Decimal.Parse(txtMontoPago.Text.Trim), "0.00")
                    fila.Cells("haber").Value += suma
                End If
            Next
            'SI ENCUENTRA UNA CUENTA REPETIDA
            Dim estadoRepPag As Integer = 0

            For Each fila As DataGridViewRow In dgvOperaciones.Rows
                If txtCuentaPago.Text.Trim = fila.Cells("num_cuenta").Value.ToString Then
                    estadoRepPag = 1
                    Exit For
                Else
                    estadoRepPag = 0
                End If
            Next
            If estadoRepPag = 0 Then
                ''''''''''''''''''''''''CUENTA DE PAGO 10''''''''''''''''''''''''''''''''''''''
                Dim dt As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
                Dim row As DataRow = dt.NewRow()
                row.Item(0) = txtCuentaPago.Text.Trim
                row.Item(1) = obtenerDatosCuenta(txtCuentaPago.Text.Trim)
                row.Item(2) = "0.00"
                row.Item(3) = txtTotalCompra.Text.Trim
                row.Item(4) = txtDescripcionPago.Text.Trim
                row.Item(5) = "-"
                row.Item(6) = "-"
                row.Item(7) = "-"
                dt.Rows.Add(row)
            End If
        End If
        realizarSumasTotales()
    End Sub
    Private Sub btnVentana_Click(sender As Object, e As EventArgs) Handles btnVentana.Click
        frmAgregarCuenta.formIni = "compra"
        frmAgregarCuenta.ShowDialog()
    End Sub
    Public Sub cargarDatosVentana(cuenta As String, textoCuenta As String, monto As Decimal, dh As String, centroCosto As Integer)
        txtCuenta.Text = cuenta
        lblNomCuenta.Text = textoCuenta
        txtMontoCuenta.Text = monto
        cboCentroCosto.SelectedValue = centroCosto
        cboDH.SelectedValue = dh
        btnAgregarCuenta.PerformClick()
    End Sub
    Private Sub dgvProductos_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOperaciones.CellValueChanged
        On Error Resume Next
        If iCarga = 1 Then
            realizarSumasTotales()
        End If

    End Sub
    Private Sub txtTotalCompra_TextChanged(sender As Object, e As EventArgs) Handles txtTotalCompra.TextChanged
        txtMontoPago.Text = txtTotalCompra.Text.Trim
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        frmListaComprasPorPagar.Show()
    End Sub
    Private Sub cboPercepcion_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboPercepcion.SelectedIndexChanged
        If iCarga = 1 Then
            Dim dataPorc As New DataTable
            dataPorc = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & cboPercepcion.SelectedValue.ToString & "'", CadenaConexion)
            If dataPorc.Rows.Count > 0 Then
                txtPorcPercep.Text = dataPorc.Rows(0)("porcentaje").ToString
            Else
                txtPorcPercep.Text = "0"
            End If

            If cboPercepcion.Text = "PERCEPCIÓN" Then
                cboTipoPercepcion.Enabled = True
                Dim data As New DataTable
                data.Columns.Add("Codigo")
                data.Columns.Add("Descripcion")
                data.Rows.Add("I", "INTERNA")
                data.Rows.Add("E", "EXTERNA")
                With cboTipoPercepcion
                    .DataSource = data
                    .ValueMember = "Codigo"
                    .DisplayMember = "Descripcion"
                End With
            Else
                cboTipoPercepcion.Enabled = False
            End If
        End If
    End Sub
    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        guardarDatos("F")
    End Sub
    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        guardarDatos("P")
    End Sub
    Private Sub guardarDatos(estadoComprobante As String)
        Dim objCC As New nComprobanteCompra
        Dim entiCCompraAsiento, entiCCompra As New ComprobanteCompraEntity
        Dim entiCostoCompra As New CostoComprasEntity
        Dim dataIgv As New DataTable
        dataIgv = objCrud.nCrudListarBD("select * from  igv where estado=1", CadenaConexion)
        Dim preIGV As Decimal = 0
        Dim valIGV As Decimal = 0
        If cboOperacion.SelectedValue = "1" Then
            preIGV = txtTotalCompra.Text / (1 + (Decimal.Parse(dataIgv.Rows(0)("valor").ToString) / 100))
            valIGV = txtTotalCompra.Text - preIGV
        Else
            valIGV = 0
        End If

        With entiCCompra
            .id = idCompra
            .tipo_compra = cboTipoCompra.SelectedValue.ToString
            .id_tipo_comprobante = cboTipoDocumento.SelectedValue.ToString
            .marca = IIf(cboTipoCompra.SelectedValue = "CREDITO", cboPercepcion.Text & "@" & IIf(cboPercepcion.Text = "SIN AFECTO", "0", cboTipoPercepcion.SelectedValue), cboImpuestos.Text & "@I")
            .centro = cboCentroCosto.SelectedValue
            .estado_comprobante = estadoComprobante
            .fec_emision = dtFechaEmision.Value.ToString("yyyy-MM-dd")
            .fec_pago = dtFechaPago.Value.ToString("yyyy-MM-dd")
            .serie_comprobante = txtSerie.Text
            .numero_comprobante = txtNumero.Text
            .cod_dni = "6"
            .num_dni = txtRuc.Text.Trim
            .razon_social = txtRazonSocial.Text.Trim
            .valor_facturado = Decimal.Parse(txtTotalCompra.Text.Trim) - valIGV
            .glosa = txtGlosa.Text
            .id_moneda = cboMoneda.SelectedValue.ToString
            .valor_igv = valIGV
            .total = txtTotalCompra.Text.Trim
            .tipo_cambio = txtTipoCambio.Text.Trim
            .detraccion = 1
            .fec_comp_origen = dtFecImpuesto.Value.ToString("yyyy-MM-dd")
            .tip_comp_origen = ""
            .serie_comp_origen = ""
            .numero_comp_origen = ""
            .estado = 1
            .id_usuario = CodigoUsuarioSession
        End With
        Dim rptaRCC As String = objCC.nActualizarComprobanteCompraBD(entiCCompra, CadenaConexion)
        If rptaRCC <> "ok" Then
            MsgBox("Error en la actualización del comprobante: " & rptaRCC)
        End If

        'Dim entiAbono As New AbonoComprasEntity
        'Dim objAbono As New nAbonosPagos
        'Dim dataCC As New DataTable
        'dataCC = objCrud.nCrudListarBD("select * from comprobante_compra order by id desc", CadenaConexion)
        'With entiCCompraAsiento
        '    .id_comprobante = dataCC.Rows(0)("id").ToString
        '    .numero_cuo = objCC.nObtenerCUO_CompraBD(CadenaConexion)
        '    .tipo_compra = cboTipoCompra.SelectedValue.ToString
        '    .numero_maquina = "-"
        '    .id_tipo_comprobante = cboTipoDocumento.SelectedValue.ToString
        '    .fec_emision = Date.Parse(dtFechaEmision.Value())
        '    .fec_pago = dtFechaPago.Value.ToString("yyyy-MM-dd")
        '    .serie_comprobante = txtSerie.Text
        '    .numero_comprobante = txtNumero.Text
        '    .cod_dni = "6"
        '    .num_dni = txtRuc.Text.Trim
        '    .razon_social = txtRazonSocial.Text.Trim
        '    .valor_facturado = Decimal.Parse(txtTotalCompra.Text.Trim) - valIGV
        '    .base_imponible = Decimal.Parse(txtTotalCompra.Text.Trim) - valIGV
        '    .valor_exonerado = 0
        '    .valor_inafecto = 0
        '    .valor_isc = 0
        '    .valor_igv = valIGV
        '    .otros_base_imponible = 0
        '    .total = txtTotalCompra.Text.Trim
        '    .tipo_cambio = txtTipoCambio.Text.Trim
        '    .fec_comp_origen = Date.Parse(dtFechaEmision.Value.ToString("yyyy-MM-dd"))
        '    .serie_dua = "0"
        '    .numero_dua = "0"
        '    .anio_dua = dtFechaEmision.Value.ToString("yyyy-MM-dd")
        '    .numero_detraccion = IIf(cboImpuestos.Text = "DETRACCIÓN", txtNumeroImpuesto.Text.Trim, "0")
        '    .tipo_tasa_detraccion = "0"
        '    .tasa_detraccion = IIf(cboImpuestos.Text = "DETRACCIÓN", txtPorcentaje.Text.Trim, "0")
        '    .valor_detraccion = IIf(cboImpuestos.Text = "DETRACCIÓN", montoDetraccion, "0")
        '    .fecha_detraccion = dtFecImpuesto.Value.ToString("yyyy-MM-dd")
        '    .estado = 1
        'End With

        'For Each row As DataGridViewRow In dgvOperaciones.Rows
        '    entiCCompraAsiento.tip_comp_origen = "-"
        '    entiCCompraAsiento.serie_comp_origen = txtSerie.Text.Trim
        '    entiCCompraAsiento.numero_comp_origen = txtNumero.Text.Trim
        '    entiCCompraAsiento.cuenta = row.Cells("num_cuenta").Value
        '    entiCCompraAsiento.glosa = row.Cells("descripcion").Value
        '    entiCCompraAsiento.debe = row.Cells("debe").Value
        '    entiCCompraAsiento.haber = row.Cells("haber").Value
        '    entiCCompraAsiento.impuesto = IIf(row.Cells("impuesto").Value = Nothing, "0", row.Cells("impuesto").Value)
        '    entiCCompraAsiento.serie = IIf(row.Cells("serie").Value = Nothing, "0", row.Cells("serie").Value)
        '    entiCCompraAsiento.numero = IIf(row.Cells("numero").Value = Nothing, "0", row.Cells("numero").Value)
        '    entiCCompraAsiento.operacion = IIf(row.Cells("operacion").Value = Nothing, "0", row.Cells("operacion").Value)
        '    'MsgBox("REGISTRANDO ASIENTO COMPROBANTE DE COMPRA: " & objCC.nRegistrarAsientoComprobanteCompra(entiCCompraAsiento))
        '    Dim rptaRACC As String = objCC.nRegistrarAsientoComprobanteCompraBD(entiCCompraAsiento, CadenaConexion)
        '    If rptaRACC <> "ok" Then
        '        MsgBox("Error en el registro en el asiento del comprobante: " & rptaRACC)
        '    End If
        'Next

        'Dim rpta As String = objCrud.nCrudActualizarBD("@", "comprobante_compra", "estado_comprobante", "F", "id='" & idCompra & "'", CadenaConexion)
        MsgBox("MODIFICACION DE COMPROBANTE DE COMPRA: " & rptaRCC)
        frmListaComprobanteCompras.realizarConsulta()
        Me.Dispose()
    End Sub
End Class