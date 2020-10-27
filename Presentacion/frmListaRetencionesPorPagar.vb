Imports Negocio
Imports Entidades

Public Class frmListaRetencionesPorPagar
    Dim obj As New nCrud
    Dim objMon As New nMonedas
    Dim iCarga As Integer = 0
    Dim cuentas As New DataTable
    Dim objRet As New nRetenciones
    Public tipo As String
    Public COD_COMPROBANTE As Integer = 0
    Public Sub cargarPagoDesdeCompra()
        seleccionarCodigoDeRetencion(COD_COMPROBANTE)
        btnPagar.PerformClick()
    End Sub
    Private Sub seleccionarCodigoDeRetencion(dato As String)
        For i As Integer = 0 To dgvLista.Rows.Count - 1
            For x As Integer = 0 To dgvLista.ColumnCount - 1
                If dgvLista.Rows(i).Cells("id_comprobante").Value.ToString = dato Then
                    dgvLista.CurrentCell = dgvLista.Rows(i).Cells("id_comprobante")
                End If
            Next
        Next
    End Sub
    Private Function codigoCeldaSeleccionada() As Integer
        Dim c As String
        Try
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            c = dgvLista.Rows(f).Cells("id_ret").Value.ToString
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = obj.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function

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
    Private Sub cargarListaRetenciones()
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from vista_listaDeRetencionesPorPagar order by id_ret asc", CadenaConexion)
        dgvLista.DataSource = data
        If iCarga = 1 Then
            cargarAsientoAbonoRetencion()
        End If
    End Sub
    Private Sub frmListaRetenciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLista.RowTemplate.Height = 35
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        dgvAsientoAbono.RowTemplate.Height = 35
        cebrasDatagrid(dgvAsientoAbono, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        dgvOperaciones.RowTemplate.Height = 27
        cebrasDatagrid(dgvOperaciones, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        cargarListaRetenciones()
        movimientoDH()
        If cuentas.Columns.Count <= 1 Then
            With cuentas.Columns
                .Add("num_cuenta")
                .Add("desc_cuenta")
                .Add("debe")
                .Add("haber")
            End With
        End If
        iCarga = 1
        cargarAsientoAbonoRetencion()
        formatoGrillaCompras()
    End Sub
    Private Sub formatoGrillaCompras()
        For Each row As DataGridViewRow In dgvLista.Rows
            If row.Cells("estado").Value.ToString.StartsWith("CANCELA") Then
                row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(240, 199, 129)
            End If
        Next
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

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'If txtCuenta.Text.Trim.StartsWith("10") Then

        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        If Decimal.Parse(txtMonto.Text.Trim) <= Decimal.Parse(dgvLista.Rows(f).Cells("retenido").Value.ToString) Then
            Dim dtCaja As New DataTable
            dtCaja = obj.nCrudListarBD("select * from caja_configuracion where cuenta='" & txtCuenta.Text.Trim & "'", CadenaConexion)
            If dtCaja.Rows.Count > 0 Then
                txtIdCaja.Text = dtCaja.Rows(0)("id").ToString
                'End If

                cuentas.Rows.Clear()
                dgvOperaciones.DataSource = cuentas
                Dim dt As New DataTable
                dt = obj.nCrudListarBD("select * from impuestos_sunat where tipo_comprobante='COMPRA' and descripcion like 'RET%'", CadenaConexion)

                If dgvOperaciones.Rows.Count = 0 Then
                    cuentas.Rows.Add(dt.Rows(0)("cuenta").ToString, obtenerDatosCuenta(dt.Rows(0)("cuenta").ToString), txtMonto.Text.Trim, "0.00")
                    cuentas.Rows.Add(txtCuenta.Text.Trim, obtenerDatosCuenta(txtCuenta.Text.Trim), IIf(cboDH.SelectedValue = "D", txtMonto.Text.Trim, "0.00"), IIf(cboDH.SelectedValue = "H", txtMonto.Text.Trim, "0.00"))
                Else
                    cuentas.Rows.Add(txtCuenta.Text.Trim, obtenerDatosCuenta(txtCuenta.Text.Trim), IIf(cboDH.SelectedValue = "D", txtMonto.Text.Trim, "0.00"), IIf(cboDH.SelectedValue = "H", txtMonto.Text.Trim, "0.00"))
                End If
                dgvOperaciones.DataSource = cuentas
                realizarSumasTotales()
                txtCuenta.Focus()
                cboDH.SelectedValue = "H"
                seleccionarCuentaIngresada()
            Else
                MsgBox("La cuenta seleccionada no tiene anexada una Caja")
            End If
        Else
            MsgBox("El monto sobrepasa a la diferencia permitida")
        End If
    End Sub
    Private Sub seleccionarCuentaIngresada()
        For i As Integer = 0 To dgvOperaciones.Rows.Count - 1
            For x As Integer = 0 To dgvOperaciones.ColumnCount - 1
                If dgvOperaciones.Rows(i).Cells("num_cuenta").Value.ToString = txtCuenta.Text Then
                    dgvOperaciones.CurrentCell = dgvOperaciones.Rows(i).Cells("num_cuenta")
                End If
            Next
        Next
    End Sub
    Private Sub frmIngresosGenericos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Insert Then
            btnAgregar.PerformClick()
        ElseIf e.KeyCode = Keys.End Then
            btnFinalizar.PerformClick()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub dgvLista_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLista.SelectionChanged
        On Error Resume Next
        cargarAsientoAbonoRetencion()
    End Sub

    Private Sub cargarAsientoAbonoRetencion()
        If dgvLista.RowCount > 0 Then
            Dim sql As String
            sql = "select cuenta as 'num_cuenta', desc_cuenta,debe,haber from asientos_abono_retencion where id_retencion='" & codigoCeldaSeleccionada() & "' order by id asc"
            Dim data As New DataTable
            data = obj.nCrudListarBD(sql, CadenaConexion)
            If data.Rows.Count > 0 Then
                dgvAsientoAbono.Visible = True
                dgvAsientoAbono.DataSource = data
            Else
                dgvAsientoAbono.Visible = False
            End If
            tbPago.Parent = Nothing
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            txtMonto.Text = dgvLista.Rows(f).Cells("retenido").Value
            'realizarSumasTotales()
        End If
    End Sub

    Private Sub limpiarEntradas()
        txtCuenta.Text = "101"
        lblNomCuenta.Text = "[Nombre Cuenta]"
        cuentas.Rows.Clear()
        dgvOperaciones.DataSource = cuentas
    End Sub

    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtCuenta.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "retencionP"
                    .cuentaInicio = txtCuenta.Text.Trim
                    .ShowDialog()
                End With
            End If
        End If
        If Asc(e.KeyChar) = 13 Then
            txtMonto.Focus()
        End If
    End Sub
    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cboDH.Focus()
        End If
    End Sub
    Private Sub cboDH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboDH.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtGlosa.Focus()
        End If
    End Sub
    Private Sub txtGlosa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGlosa.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnAgregar.Focus()
        End If
    End Sub
    Private Sub btnAgregar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnAgregar.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnAgregar.PerformClick()
            txtCuenta.Text = ""
            lblNomCuenta.Text = "[Nombre Cuenta]"
            txtMonto.Text = "0.00"
            txtCuenta.Focus()
        End If
    End Sub
    Private Sub dgvOperaciones_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOperaciones.CellValueChanged
        On Error Resume Next
        If iCarga = 1 Then
            realizarSumasTotales()
        End If
    End Sub

    Private Sub dgvOperaciones_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvOperaciones.RowsRemoved
        On Error Resume Next
        If iCarga = 1 Then
            realizarSumasTotales()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmListaComprobanteCompras.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cargarListaRetenciones()
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        If dgvOperaciones.Rows.Count > 0 And Decimal.Parse(txtDiferenciaS.Text.Trim) = 0 Then
            Dim objAbono As New nAbonosPagos
            Dim entidad As New AbonoRetencionEntity
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            With entidad
                .tipo_comprobante = dgvLista.Rows(f).Cells("id_comprobante").Value.ToString
                .id_retencion = dgvLista.Rows(f).Cells("id_ret").Value.ToString
                .id_caja = txtIdCaja.Text.Trim
                .monto = txtMonto.Text.Trim
                .tipo = "-"
                .numero = "-"
                .descripcion = txtGlosa.Text.Trim
                .fecha = DateTime.Now.ToString("yyyy-MM-dd H:mm:s")
                .estado = "1"
            End With
            Dim rptaAR As String = ""
            rptaAR = objRet.registrarAbonoRetenciones(entidad, CadenaConexion)
            If rptaAR = "ok" Then
                Dim dt As New DataTable
                dt = obj.nCrudListarBD("select top 1 id from abono_pagos_retencion order by id desc", CadenaConexion)
                Dim entidadLD As New ALDiarioEntity
                Dim objLD As New nAsientoLibroDiario
                Dim campos, valores As String
                campos = "id_abono_retencion@id_retencion@cuenta@desc_cuenta@glosa@debe@haber"

                Dim EntiAboCom, EntiAsientoAboCom As New AbonoComprasEntity
                Dim dtCompra As New DataTable
                dtCompra = obj.nCrudListarBD("select * from comprobante_compra where id='" & entidad.tipo_comprobante & "'", CadenaConexion)
                With EntiAboCom
                    .id_compra = dtCompra.Rows(0)("id").ToString
                    .id_impuesto = dgvLista.Rows(f).Cells("id_ret").Value.ToString 'cboImpuestos.SelectedValue.ToString
                    .id_letra = 0
                    .tipo_comprobante = dtCompra.Rows(0)("id_tipo_comprobante").ToString
                    .monto = txtMonto.Text.Trim
                    .id_banco = "0"
                    .id_caja = txtIdCaja.Text.Trim
                    .tipo = "8"
                    .numero = dgvLista.Rows(f).Cells("serie").Value.ToString & "-" & dgvLista.Rows(f).Cells("numero").Value.ToString
                    .descripcion = txtGlosa.Text.Trim
                    .fecha = DateTime.Now.ToString("yyyy-MM-dd H:mm:s")
                    .estado = "1"
                    .tipo_abono = "NORMAL"
                End With
                objAbono.nRegistrarAbonoComprasBD(EntiAboCom, CadenaConexion)
                Dim codAbono As Integer = objAbono.nObtenerUltimoAbonoCompraBD(CadenaConexion)

                For Each row As DataGridViewRow In dgvOperaciones.Rows
                    valores = dt.Rows(0)("id").ToString & "@" & dgvLista.Rows(f).Cells("id_ret").Value.ToString & "@" & row.Cells("num_cuenta").Value.ToString & "@" & row.Cells("desc_cuenta").Value.ToString & "@" & txtGlosa.Text.Trim & "@" & row.Cells("debe").Value.ToString & "@" & row.Cells("haber").Value.ToString
                    Dim rpta As String = ""
                    rpta = obj.nCrudInsertarBD("@", "asientos_abono_retencion", campos, valores, CadenaConexion)

                    With entidadLD
                        .id_comprobante = "ABR" & dt.Rows(0)("id").ToString
                        .cuo = "0"
                        .fecha_operacion = Date.Parse(entidad.fecha)
                        .glosa = txtGlosa.Text.Trim
                        .cod_libro = row.Cells("num_cuenta").Value
                        .numero_correlativo = "-"
                        .numero_documento = "-"
                        .cuenta = row.Cells("num_cuenta").Value
                        .denominacion = row.Cells("desc_cuenta").Value
                        .debe = row.Cells("debe").Value
                        .haber = row.Cells("haber").Value
                    End With
                    objLD.registrarAsientoLibroDiarioBD(entidadLD, CadenaConexion)
                    Dim dtCompraAbono As New DataTable
                    dtCompraAbono = obj.nCrudListarBD("select * from asientos_abono_compras where id_compra='" & entidad.tipo_comprobante & "'", CadenaConexion)
                    With EntiAsientoAboCom
                        .id = (codAbono)
                        .id_cliente = dtCompra.Rows(0)("num_dni").ToString
                        .id_compra = dtCompra.Rows(0)("id").ToString
                        .cuenta = row.Cells("num_cuenta").Value
                        .base_imponible = dtCompraAbono.Rows(0)("base_imponible").ToString
                        .nro_detraccion = dtCompraAbono.Rows(0)("nro_detraccion").ToString
                        .tipo_tasa_detraccion = dtCompraAbono.Rows(0)("tipo_tasa_detraccion").ToString
                        .valor_tasa = dtCompraAbono.Rows(0)("valor_tasa").ToString
                        .valor_detraccion = dtCompraAbono.Rows(0)("valor_detraccion").ToString
                        .fecha_detraccion = DateTime.Now.ToString("yyyy-MM-dd H:mm:s")
                        .monto = dtCompraAbono.Rows(0)("monto_pago").ToString
                        .tipo = "8"
                        .descripcion = txtGlosa.Text.Trim
                        .debe = row.Cells("debe").Value
                        .haber = row.Cells("haber").Value
                        .fecha = DateTime.Now.ToString("yyyy-MM-dd H:mm:s")
                    End With
                    objAbono.nRegistrarAsientoAbonoComprasBD(EntiAsientoAboCom, CadenaConexion)

                Next
                'Dim campos2,valores2 As 
                obj.nCrudActualizarBD("@", "retenciones", "tipo", "CANCELADO", "id='" & dgvLista.Rows(f).Cells("id_ret").Value.ToString & "'", CadenaConexion)

                MsgBox("PAGO REGISTRADO CON ÉXITO")
                cargarListaRetenciones()
                tbLista.Parent = tabRetencion
                tabRetencion.SelectedTab = tbLista
                formatoGrillaCompras()
                frmListaComprobanteCompras.realizarConsulta()
                seleccionarCodigoDeRetencion(dgvLista.Rows(f).Cells("id_comprobante").Value.ToString)
            Else
                MsgBox("Error al registrar el ABONO de retención:" & vbCrLf & rptaAR)
            End If
        ElseIf dgvOperaciones.Rows.Count = 0 Then
            MsgBox("NO SE HAN AGREGADO CUENTAS DE ABONOS")
            txtCuenta.Focus()
        ElseIf Decimal.Parse(txtDiferenciaS.Text.Trim) <> 0 Then
            MsgBox("HAY UN MONTO DE DIFERENCIA DE (" & txtDiferenciaS.Text.Trim & ") POR RECTIFICAR")
            txtCuenta.Focus()
        End If
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        tbPago.Parent = tabRetencion
        limpiarEntradas()
        tabRetencion.SelectedTab = tbPago
        tabRetencion.TabPages(1).Enabled = True
        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        txtMonto.Text = dgvLista.Rows(f).Cells("retenido").Value.ToString
        cboDH.SelectedValue = "H"
        txtGlosa.Text = "POR EL PAGO DE LA RETENCIÓN: " & dgvLista.Rows(f).Cells("serie").Value.ToString & "-" & dgvLista.Rows(f).Cells("numero").Value.ToString
        txtCuenta.SelectAll()
        txtCuenta.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmListaCaja.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmListaPercepcionesPorPagar.Show()
    End Sub
    Private Sub txtMonto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.Leave
        txtMonto.Text = Format(CType(txtMonto.Text, Decimal), "###0.00")
    End Sub
End Class