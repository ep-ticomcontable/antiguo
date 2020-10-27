Imports Negocio
Imports Entidades
Public Class frmCanjeLetraComprobantes

    Dim obj As New nCrud
    Dim objTDA As New nTipoDocumentoAsiento
    Dim objAC As New nAsientosContables
    Public codComprobante As Integer = 0
    Public codTipoComprobante As Integer = 0
    Public dataComprobante As New DataTable
    Dim objNCD As New nNotaCreditoDebito
    Dim tipoOperacion As Integer = 5 'DEVOLUCIONES
    Dim objCV As New nComprobanteVenta
    Dim id_comprobante As String
    Dim objCanje As New nCanjeLetra
    Dim entiCanje As New CanjeLetraEntity
    Public tipo As String = ""
    Dim data As New DataTable
    Public Sub cargarDatosComprobante()
        If tipo = "COMPRA" Then
            data = obj.nCrudListarBD("select * from comprobante_compra where id='" & codComprobante & "'", CadenaConexion)
            txtCuenta.Text = "423"
        Else
            data = obj.nCrudListarBD("select * from comprobante_venta where id='" & codComprobante & "'", CadenaConexion)
            txtCuenta.Text = "123"
        End If
        With data
            dgvComprobante.DataSource = dataComprobante
        End With
    End Sub

    Private Sub frmPagoConLetras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtFechaVencimiento.Value = DateTime.Today.AddMonths("+1")
        dgvOperaciones.RowTemplate.Height = 33
        cebrasDatagrid(dgvOperaciones, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
    End Sub
    Private Function verificarPartidaDoble() As Boolean
        Dim rpta As Boolean = False
        Dim sDebe, sHaber As Decimal
        For Each row As DataGridViewRow In dgvOperaciones.Rows
            sDebe = sDebe + Decimal.Parse(row.Cells("debe").Value.ToString)
            sHaber = sHaber + Decimal.Parse(row.Cells("haber").Value.ToString)
        Next
        If sDebe = sHaber And sDebe > 0 And sHaber > 0 Then
            rpta = True
        Else
            MsgBox("La suma de las cantidades en las columnas del DEBE & HABER no son iguales.")
        End If
        Return rpta
    End Function
    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        If verificarPartidaDoble() = True Then
            With entiCanje
                .id_comprobante = dgvComprobante.Rows(0).Cells("id").Value.ToString
                .tipo_comprobante = tipo
                .estado_deuda = "DEBE"
                .serie = txtSerie.Text.Trim
                .numero = txtNumero.Text.Trim
                .librado = txtLibrado.Text.Trim
                .aval = txtAval.Text.Trim
                .direccion = txtDireccion.Text.Trim
                .lugar_giro = txtGiro.Text.Trim
                .glosa = txtDescripcion.Text.Trim
                .monto = txtMonto.Text.Trim
                .interes = txtInteres.Text.Trim
                .total = txtTotal.Text.Trim
                .fecha_emision = dtFechaEmision.Value
                .fecha_vencimiento = dtFechaVencimiento.Value
                .estado = "1"
            End With
            Dim rptaL As String = ""
            rptaL = objCanje.nRegistrarCanjeLetraBD(entiCanje, CadenaConexion)

            'registrar asiento
            Dim dataL As New DataTable
            dataL = obj.nCrudListarBD("select * from canje_letra where estado=1 order by id desc", CadenaConexion)
            Dim idLetra As String
            idLetra = dataL.Rows(0)("id").ToString
            For Each row As DataGridViewRow In dgvOperaciones.Rows
                Dim rpta As String
                rpta = objCanje.nRegistrarAsientosLetrasBD(codComprobante, idLetra, tipo, txtDescripcion.Text.Trim, row.Cells("num_cuenta").Value, row.Cells("debe").Value, row.Cells("haber").Value, dtFechaEmision.Value, 1, CadenaConexion)
                'MsgBox("REGISTRO DE ASIENTO CONTABLE PARA LA LETRA: " & rpta)
            Next

            'registrar abono de compra en caja de letras por pagar
            Dim dt As New DataTable
            dt = obj.nCrudListarBD("select * from caja_configuracion where cuenta like '" & txtCuenta.Text.Trim & "%';", CadenaConexion)
            If tipo = "COMPRA" Then
                Dim EntiAboCom As New AbonoComprasEntity
                Dim objAbono As New nAbonosPagos
                With EntiAboCom
                    .id_compra = codComprobante
                    .id_impuesto = "0"
                    .id_letra = idLetra
                    .id_caja = dt.Rows(0)("id").ToString
                    .tipo_comprobante = data.Rows(0)("id_tipo_comprobante").ToString
                    .monto = txtMonto.Text.Trim
                    .id_banco = 0
                    .tipo = "8"
                    .numero = txtSerie.Text.Trim & "-" & txtNumero.Text.Trim
                    .descripcion = txtDescripcion.Text.Trim & " / " & txtSerie.Text.Trim & "-" & txtNumero.Text.Trim
                    .fecha = Date.Parse(dtFechaEmision.Value).ToString("yyyy/MM/dd HH:mm:ss")
                    .estado = "1"
                    .tipo_abono = "NORMAL"
                End With
                objAbono.nRegistrarAbonoComprasBD(EntiAboCom, CadenaConexion)

            Else
                Dim EntiAboCom As New AbonoVentasEntity
                Dim objAbono As New nAbonosPagos
                With EntiAboCom
                    .id_venta = codComprobante
                    .id_impuesto = "0"
                    .id_letra = idLetra
                    .id_caja = dt.Rows(0)("id").ToString
                    .tipo_comprobante = data.Rows(0)("id_tipo_comprobante").ToString
                    .monto = txtMonto.Text.Trim
                    .id_banco = 0
                    .tipo = "8"
                    .numero = txtSerie.Text.Trim & "-" & txtNumero.Text.Trim
                    .descripcion = txtDescripcion.Text.Trim & " / " & txtSerie.Text.Trim & "-" & txtNumero.Text.Trim
                    .fecha = Date.Parse(dtFechaEmision.Value).ToString("yyyy/MM/dd HH:mm:ss")
                    .estado = "1"
                    .tipo_abono = "NORMAL"
                End With
                objAbono.nRegistrarAbonoVentasBD(EntiAboCom, CadenaConexion)

            End If

            If rptaL = "ok" Then
                MsgBox("La letra se ha registrado correctamente")
            End If

            Me.Close()
            frmListaComprobanteCompras.realizarConsulta()
            frmListaComprobanteCompras.Refresh()
            frmListaComprobanteVentas.realizarConsulta()
            frmListaComprobanteVentas.Refresh()
        End If
    End Sub

    Public Sub agregarCuenta(numcuenta, desccuenta, debe, haber)
        If dgvOperaciones.Rows.Count = 0 Then
            Dim data As New DataTable
            data.Columns.Add("num_cuenta")
            data.Columns.Add("desc_cuenta")
            data.Columns.Add("debe")
            data.Columns.Add("haber")
            data.Rows.Add(numcuenta, desccuenta, debe, haber)
            dgvOperaciones.DataSource = data
        Else
            Dim dt As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
            Dim row As DataRow = dt.NewRow()
            row.Item(0) = numcuenta
            row.Item(1) = desccuenta
            row.Item(2) = debe
            row.Item(3) = haber
            dt.Rows.Add(row)
        End If
        realizarSumasTotales()
    End Sub
    Private Sub realizarSumasTotales()
        'MsgBox("suma total")
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
        'verificar que el monto está en el tope
        If Decimal.Parse(txtTotal.Text.Trim) > 0 Then
            Dim f As Integer
            f = dgvComprobante.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            If Decimal.Parse(txtMonto.Text.Trim) <= Decimal.Parse(dgvComprobante.Rows(f).Cells("resta").Value.ToString) Then
                If txtCuenta.Text.Trim.Length > 2 Then
                    Dim dtAsiento As New DataTable
                    Dim cuentaComp As String = ""

                    Dim cuentas As New DataTable
                    cuentas.Columns.Add("num_cuenta")
                    cuentas.Columns.Add("desc_cuenta")
                    cuentas.Columns.Add("debe")
                    cuentas.Columns.Add("haber")

                    If tipo = "COMPRA" Then
                        dtAsiento = obj.nCrudListarBD("select * from asientos_comprobante_compra where id_comprobante_compra='" & data.Rows(0)("id").ToString & "' order by id desc", CadenaConexion)
                        For Each fila As DataRow In dtAsiento.Rows
                            With fila
                                If .Item("cuenta").ToString.StartsWith("42") = True Then
                                    cuentaComp = .Item("cuenta").ToString
                                    Exit For
                                End If
                            End With
                        Next
                        cuentas.Rows.Add(cuentaComp, obtenerDatosCuenta(cuentaComp), txtMonto.Text.Trim, "0.00")
                        cuentas.Rows.Add(txtCuenta.Text.Trim, obtenerDatosCuenta(txtCuenta.Text.Trim), "0.00", txtMonto.Text.Trim)
                    ElseIf tipo = "VENTA" Then
                        dtAsiento = obj.nCrudListarBD("select * from detalle_asiento_venta where id_asiento_venta='" & data.Rows(0)("id").ToString & "' order by id desc", CadenaConexion)
                        For Each fila As DataRow In dtAsiento.Rows
                            With fila
                                If .Item("cuenta").ToString.StartsWith("12") = True Then
                                    cuentaComp = .Item("cuenta").ToString
                                    Exit For
                                End If
                            End With
                        Next
                        cuentas.Rows.Add(cuentaComp, obtenerDatosCuenta(cuentaComp), "0.00", txtMonto.Text.Trim)
                        cuentas.Rows.Add(txtCuenta.Text.Trim, obtenerDatosCuenta(txtCuenta.Text.Trim), txtMonto.Text.Trim, "0.00")
                    End If

                    dgvOperaciones.DataSource = cuentas
                    txtDescripcion.Focus()
                    'cálculos para el interés
                    Dim interes, total As Decimal
                    interes = Decimal.Round(Decimal.Parse(txtMonto.Text.Trim) * Decimal.Parse(txtInteres.Text.Trim) / 100, 2)
                    total = Decimal.Parse(txtMonto.Text.Trim) + interes
                    txtTotal.Text = total
                    If Decimal.Parse(txtInteres.Text.Trim) > 0 Then
                        txtValInteres.Text = interes
                        frmAgregarCuentasNuevo.formIni = "letra"
                        frmAgregarCuentasNuevo.Show()
                        frmAgregarCuentasNuevo.txtDebe.Text = interes
                    End If
                Else
                    MsgBox("Ingrese una cuenta correspondiente al canje de letra.")
                    txtCuenta.Focus()
                End If
                realizarSumasTotales()
            Else
                MsgBox("El monto excede a la diferencia permitida")
            End If
        Else
            MsgBox("Ingrese un monto de la Letra")
            txtMonto.Focus()
        End If
    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = obj.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function
    Private Sub btnCuenta_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtCuenta.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "canje"
                    .cuentaInicio = txtCuenta.Text.Trim
                    .ShowDialog()
                End With
            End If
        End If
        If Asc(e.KeyChar) = 13 Then
            txtMonto.Focus()
        End If
    End Sub

    Private Sub btnOtrasCuentas_Click(sender As Object, e As EventArgs) Handles btnOtrasCuentas.Click
        agregarCuentaContable()
    End Sub
    Private Sub agregarCuentaContable()
        frmAgregarCuentasNuevo.formIni = "letra"
        frmAgregarCuentasNuevo.Show()
        If Decimal.Parse(txtInteres.Text.Trim) > 0 Then
            'cálculos para el interés
            Dim interes, total As Decimal
            interes = Decimal.Round(Decimal.Parse(txtMonto.Text.Trim) * Decimal.Parse(txtInteres.Text.Trim) / 100, 2)
            total = Decimal.Parse(txtMonto.Text.Trim) + interes
            frmAgregarCuentasNuevo.txtDebe.Text = interes
            txtTotal.Text = total
            txtValInteres.Text = interes
        End If

    End Sub
    Public Sub adicionarCuentas(cuenta As String, monto As Decimal, orden As String)
        Dim dtI As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
        Dim row As DataRow = dtI.NewRow()
        row.Item(0) = cuenta
        row.Item(1) = obtenerDatosCuenta(cuenta)
        row.Item(2) = IIf(orden = "D", monto, "0.00")
        row.Item(3) = IIf(orden = "H", monto, "0.00")
        dtI.Rows.Add(row)
        realizarSumasTotales()
        btnOtrasCuentas.Focus()
    End Sub

    Private Sub txtMonto_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMonto.KeyUp
        On Error Resume Next
        'cálculos para el interés
        Dim interes, total As Decimal
        interes = Decimal.Round(Decimal.Parse(txtMonto.Text.Trim) * Decimal.Parse(txtInteres.Text.Trim) / 100, 2)
        total = Decimal.Parse(txtMonto.Text.Trim) + interes
        txtTotal.Text = total
        txtValInteres.Text = interes
    End Sub
    Private Sub txtMonto_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.Leave
        On Error Resume Next
        If txtMonto.Text.Trim.Length = 0 Then
            txtMonto.Text = "0.00"
        Else
            txtMonto.Text = Format(CType(txtMonto.Text, Decimal), "###0.00")
        End If
    End Sub

    Private Sub txtInteres_KeyUp(sender As Object, e As KeyEventArgs) Handles txtInteres.KeyUp
        On Error Resume Next
        'cálculos para el interés
        Dim interes, total As Decimal
        interes = Decimal.Round(Decimal.Parse(txtMonto.Text.Trim) * Decimal.Parse(txtInteres.Text.Trim) / 100, 2)
        total = Decimal.Parse(txtMonto.Text.Trim) + interes
        txtTotal.Text = total
        txtValInteres.Text = interes
    End Sub

    Private Sub dgvOperaciones_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOperaciones.CellValueChanged
        On Error Resume Next
        realizarSumasTotales()
    End Sub

    Private Sub dgvOperaciones_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvOperaciones.RowsRemoved
        On Error Resume Next
        realizarSumasTotales()
    End Sub
End Class