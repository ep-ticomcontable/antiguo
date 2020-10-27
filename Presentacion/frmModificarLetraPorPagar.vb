Imports Negocio
Imports Entidades
Public Class frmModificarLetraPorPagar

    Dim obj As New nCrud
    Dim objTDA As New nTipoDocumentoAsiento
    Dim objAC As New nAsientosContables
    Public codComprobante As Integer = 0
    Public COD_LETRA As Integer = 0
    Public dataComprobante As New DataTable
    Dim objNCD As New nNotaCreditoDebito
    Dim tipoOperacion As Integer = 5 'DEVOLUCIONES
    Dim objCV As New nComprobanteVenta
    Dim id_comprobante As String
    Dim objCanje As New nCanjeLetra
    Dim entiCanje As New CanjeLetraEntity
    Public tipo As String = ""
    Dim data As New DataTable

    Dim estadoLetra As String = ""

    Public Sub cargarDatosComprobante()
        Dim dataComp As New DataTable
        With dataComp
            .Columns.Add("id")
            .Columns.Add("serie")
            .Columns.Add("numero")
            .Columns.Add("glosa")
            .Columns.Add("total")
            .Columns.Add("pagado")
            .Columns.Add("resta")
            .Columns.Add("abono")
            .Columns.Add("fecha")
        End With

        Dim data As New DataTable
        Dim dtComp As New DataTable
        If tipo = "COMPRA" Then
            txtCuenta.Text = "423"
            dtComp = obj.nCrudListarBD("select * from comprobante_compra where id='" & codComprobante & "'", CadenaConexion)
            data = obj.nCrudListarBD("select  IsNull(sum(monto), 0) as 'abono' from abono_pagos_compras where id_compra='" & codComprobante & "'", CadenaConexion)
        Else
            dtComp = obj.nCrudListarBD("select * from comprobante_venta where id='" & codComprobante & "'", CadenaConexion)
            data = obj.nCrudListarBD("select  IsNull(sum(monto), 0) as 'abono' from abono_pagos_ventas where id_venta='" & codComprobante & "'", CadenaConexion)
            txtCuenta.Text = "123"
        End If

        Dim abono As Decimal = 0
        If data.Rows.Count > 0 Then
            abono = Decimal.Parse(data.Rows(0)("abono").ToString)
        End If

        Dim diferencia As Decimal = 0
        Dim pagado As Decimal = 0
        diferencia = (Decimal.Parse(dtComp.Rows(0)("total").ToString) - abono)
        pagado = abono

        dataComp.Rows.Add(codComprobante, dtComp.Rows(0)("serie_comprobante").ToString, dtComp.Rows(0)("numero_comprobante").ToString, dtComp.Rows(0)("glosa").ToString, dtComp.Rows(0)("total").ToString, pagado, diferencia, diferencia, Date.Parse(dtComp.Rows(0)("fec_pago").ToString).ToString("dd/MM/yyyy"))
        With data
            dgvComprobante.DataSource = dataComp
        End With

        'CARGAR DATOS DE LA LETRA
        Dim lista As New DataTable
        lista = obj.nCrudListarBD("select * from canje_letra where id_comprobante='" & codComprobante & "'", CadenaConexion)
        With lista
            dtFechaEmision.Value = Date.Parse(.Rows(0)("fec_emision").ToString)
            dtFechaVencimiento.Value = Date.Parse(.Rows(0)("fec_vencimiento").ToString)
            txtSerie.Text = .Rows(0)("serie").ToString
            txtNumero.Text = .Rows(0)("numero").ToString
            txtLibrado.Text = .Rows(0)("librado").ToString
            txtAval.Text = .Rows(0)("aval").ToString
            txtDireccion.Text = .Rows(0)("direccion").ToString
            txtGiro.Text = .Rows(0)("lugar_giro").ToString
            txtMonto.Text = .Rows(0)("monto").ToString
            txtInteres.Text = .Rows(0)("porcentaje").ToString
            txtValInteres.Text = .Rows(0)("interes").ToString
            txtTotal.Text = .Rows(0)("total").ToString
            txtDescripcion.Text = .Rows(0)("glosa").ToString
            estadoLetra = .Rows(0)("estado_deuda").ToString
        End With

        'CARGAR CUENTAS VINCULADAS A LA LETRA
        Dim dt As New DataTable
        dt = obj.nCrudListarBD("select * from asiento_letras where id_comprobante='" & codComprobante & "'", CadenaConexion)

        Dim cuentas As New DataTable
        cuentas.Columns.Add("num_cuenta")
        cuentas.Columns.Add("desc_cuenta")
        cuentas.Columns.Add("debe")
        cuentas.Columns.Add("haber")

        Dim dtAsiento As New DataTable
        Dim cuentaComp As String = ""

        For Each row As DataRow In dt.Rows
            cuentas.Rows.Add(row.Item("cuenta").ToString, obtenerDatosCuenta(row.Item("cuenta").ToString), row.Item("debe").ToString, row.Item("haber").ToString)
        Next
        dgvOperaciones.DataSource = cuentas
        realizarSumasTotales()
    End Sub

    Private Sub frmPagoConLetras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtFechaVencimiento.Value = DateTime.Today.AddMonths("+1")
        dgvOperaciones.RowTemplate.Height = 33
        cebrasDatagrid(dgvOperaciones, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        cargarDatosComprobante()
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
                .id = COD_LETRA
                .id_comprobante = dgvComprobante.Rows(0).Cells("id").Value.ToString
                .tipo_comprobante = tipo
                .estado_deuda = estadoLetra
                .serie = txtSerie.Text.Trim
                .numero = txtNumero.Text.Trim
                .librado = txtLibrado.Text.Trim
                .aval = txtAval.Text.Trim
                .direccion = txtDireccion.Text.Trim
                .lugar_giro = txtGiro.Text.Trim
                .glosa = txtDescripcion.Text.Trim
                .monto = txtMonto.Text.Trim
                .porcentaje = txtInteres.Text.Trim
                .interes = txtValInteres.Text.Trim
                .total = txtTotal.Text.Trim
                .fecha_emision = dtFechaEmision.Value
                .fecha_vencimiento = dtFechaVencimiento.Value
                .estado = "1"
            End With
            Dim rpta As String = ""
            rpta = objCanje.nActualizarCanjeLetraBD(entiCanje, CadenaConexion)

            'Limpiar los registros anteriores de letras
            obj.nEjecutarQueryBD("delete from asiento_letras where id_comprobante='" & codComprobante & "'", CadenaConexion)
            obj.nEjecutarQueryBD("delete from asientos_libro_diario where id_comprobante='LTC" & codComprobante & "'", CadenaConexion)

            'registrar asiento
            For Each row As DataGridViewRow In dgvOperaciones.Rows
                objCanje.nRegistrarAsientosLetrasBD(codComprobante, COD_LETRA, tipo, txtDescripcion.Text.Trim, row.Cells("num_cuenta").Value, row.Cells("debe").Value, row.Cells("haber").Value, dtFechaEmision.Value, 1, CadenaConexion)
            Next

            frmListaLetrasPorCobrar.realizarConsulta()
            frmListaLetrasPorCobrar.Refresh()
            frmListaLetrasPorPagar.realizarConsulta()
            frmListaLetrasPorPagar.Refresh()

            MsgBox("ACTUALIZACION DE LETRA")
            Me.Close()
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
        If txtCuenta.Text.Trim.Length > 2 Then
            Dim dtAsiento As New DataTable
            Dim cuentaComp As String = ""

            Dim cuentas As New DataTable
            cuentas.Columns.Add("num_cuenta")
            cuentas.Columns.Add("desc_cuenta")
            cuentas.Columns.Add("debe")
            cuentas.Columns.Add("haber")

            cuentas.Rows.Clear()
            dgvOperaciones.DataSource = cuentas

            If tipo = "COMPRA" Then
                dtAsiento = obj.nCrudListarBD("select * from asientos_comprobante_compra where id_comprobante_compra='" & codComprobante & "' order by id desc", CadenaConexion)
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
                dtAsiento = obj.nCrudListarBD("select * from detalle_asiento_venta where id_asiento_venta='" & codComprobante & "' order by id desc", CadenaConexion)
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
                frmAgregarCuentasNuevo.formIni = "letraMod"
                frmAgregarCuentasNuevo.Show()
                frmAgregarCuentasNuevo.txtDebe.Text = interes
            End If
        Else
            MsgBox("Ingrese una cuenta correspondiente al canje de letra.")
            txtCuenta.Focus()
        End If
        realizarSumasTotales()
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
                    .formInicio = "letraMod"
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
        If Decimal.Parse(txtInteres.Text.Trim) > 0 Then
            'cálculos para el interés
            Dim interes, total As Decimal
            interes = Decimal.Round(Decimal.Parse(txtMonto.Text.Trim) * Decimal.Parse(txtInteres.Text.Trim) / 100, 2)
            total = Decimal.Parse(txtMonto.Text.Trim) + interes
            frmAgregarCuentasNuevo.txtDebe.Text = interes
            txtTotal.Text = total
            txtValInteres.Text = interes
        End If
        frmAgregarCuentasNuevo.formIni = "letraMod"
        frmAgregarCuentasNuevo.Show()
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
        txtMonto.Text = Format(CType(txtMonto.Text, Decimal), "###0.00")
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