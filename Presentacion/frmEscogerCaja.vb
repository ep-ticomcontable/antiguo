Imports Negocio

Public Class frmEscogerCaja
    Dim obj As New nCrud
    Public cuentaInicio As String = ""
    Public formInicio As String = ""
    Public input As String = ""

    Private Sub frmEscogerPlanContable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLista.RowTemplate.Height = 30
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        Dim cuentaInicio2digitos As String

        cuentaInicio2digitos = cuentaInicio '.Substring(0, 2)
        If formInicio = "abonoVenta2" Then
            dgvLista.DataSource = obj.nCrudListarBD("select c.id,c.tipo,c.descripcion,'0.00' as 'saldo',u.usuario,c.cuenta from caja_configuracion c inner join usuarios u on c.id_usuario=u.id where c.estado=1 order by c.id asc", CadenaConexion)
        Else
            dgvLista.DataSource = obj.nCrudListarBD("select c.id,c.tipo,c.descripcion,'0.00' as 'saldo',u.usuario,c.cuenta from caja_configuracion c inner join usuarios u on c.id_usuario=u.id where c.descripcion not like 'DETRAC%' and c.estado=1 order by c.id asc", CadenaConexion)
        End If

        'For Each row As DataGridViewRow In dgvLista.Rows
        '    If row.Cells("id").Value.ToString.StartsWith(cuentaInicio) Then
        '        dgvLista.CurrentCell = row.Cells("id").Value
        '    End If
        'Next
        cargarSaldosCajas()
    End Sub
    Private Sub cargarSaldosCajas()
        Dim saldos As New DataTable
        Dim saldos2 As New DataTable
        For Each row As DataGridViewRow In dgvLista.Rows
            'MsgBox(row.Cells("id").Value)
            If row.Cells("tipo").Value = "PRINCIPAL" Then
                saldos = obj.nCrudListarBD("select isnull((sum(debe)-sum(haber)),'0.00') as 'saldo' from vista_listaRegistrosCaja where id_caja='" & row.Cells("id").Value & "' and cuenta<>'" & row.Cells("cuenta").Value & "'", CadenaConexion)
                saldos2 = obj.nCrudListarBD("select isnull((sum(debe)-sum(haber)),'0.00') as 'saldo' from vista_datosApertura where id_caja='" & row.Cells("id").Value & "'", CadenaConexion)
                'MsgBox(saldos.Rows(0)("saldo").ToString)
                row.Cells("saldo").Value = (Decimal.Parse(saldos.Rows(0)("saldo").ToString) + Decimal.Parse(saldos2.Rows(0)("saldo").ToString)).ToString
            ElseIf row.Cells("tipo").Value = "CHICA" Then
                saldos = obj.nCrudListarBD("select isnull((sum(debe)-sum(haber)),'0.00') as 'saldo' from vista_listaRegistrosCajaChica where id_caja='" & row.Cells("id").Value & "' and cuenta<>'" & row.Cells("cuenta").Value & "'", CadenaConexion)
                'MsgBox(saldos.Rows(0)("saldo").ToString)
                row.Cells("saldo").Value = saldos.Rows(0)("saldo").ToString
            ElseIf row.Cells("tipo").Value = "BANCOS" Then
                saldos = obj.nCrudListarBD("select isnull((sum(debe)-sum(haber)),'0.00') as 'saldo' from vista_listaRegistrosCajaBancos where id_caja='" & row.Cells("id").Value & "'  and (cuenta<>'" & row.Cells("cuenta").Value & "' or id_comprobante like 'A%')", CadenaConexion)
                'MsgBox(saldos.Rows(0)("saldo").ToString)
                row.Cells("saldo").Value = saldos.Rows(0)("saldo").ToString
            End If
        Next
    End Sub
    Private Sub dgvLista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvLista.KeyDown
        If e.KeyCode = Keys.Enter Then
            cargarDatosAAdicionAsientoApertura()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        cargarDatosAAdicionAsientoApertura()
    End Sub

    Private Sub cargarDatosAAdicionAsientoApertura()
        If dgvLista.Rows.Count > 0 Then
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            'MsgBox(dgvLista.Rows(f).Cells("id").Value.ToString)
            If formInicio = "compra" Then
                frmNuevaCompraPago.txtIdCaja.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmNuevaCompraPago.lblCaja.Text = dgvLista.Rows(f).Cells("descripcion").Value.ToString.ToUpper
                frmNuevaCompraPago.txtCuenta.Text = dgvLista.Rows(f).Cells("cuenta").Value.ToString
                'If dgvLista.Rows(f).Cells("id").Value.ToString <> "1" Then
                '    frmNuevaCompraPago.txtCuenta.Enabled = False
                'Else
                '    frmNuevaCompraPago.txtCuenta.Enabled = True
                'End If
            ElseIf formInicio = "planilla" Then
                frmPagoPlanilla.txtIdCaja.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmPagoPlanilla.lblCaja.Text = dgvLista.Rows(f).Cells("descripcion").Value.ToString.ToUpper
                frmPagoPlanilla.txtCuenta.Text = dgvLista.Rows(f).Cells("cuenta").Value.ToString
                frmPagoPlanilla.cargarCuentasDePago()
            ElseIf formInicio = "pagoComprobante" Then
                frmPagoComprobante.txtIdCaja.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmPagoComprobante.lblCaja.Text = dgvLista.Rows(f).Cells("descripcion").Value.ToString.ToUpper
                frmPagoComprobante.txtCuenta.Text = dgvLista.Rows(f).Cells("cuenta").Value.ToString
            ElseIf formInicio = "compraMercaderia" Then
                frmNuevaCompraPagoMercaderia.txtIdCaja.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmNuevaCompraPagoMercaderia.lblCaja.Text = dgvLista.Rows(f).Cells("descripcion").Value.ToString.ToUpper
                If dgvLista.Rows(f).Cells("id").Value.ToString <> "1" Then
                    'frmNuevaCompraPagoMercaderia.txtCuenta.Enabled = False
                Else
                    'frmNuevaCompraPagoMercaderia.txtCuenta.Enabled = True
                End If
            ElseIf formInicio = "abonoCompra" Then
                frmAbonoComprobanteCompras.cargarTipoPagos(dgvLista.Rows(f).Cells("id").Value.ToString)
                frmAbonoComprobanteCompras.txtIdCaja.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmAbonoComprobanteCompras.lblCaja.Text = dgvLista.Rows(f).Cells("descripcion").Value.ToString.ToUpper
                frmAbonoComprobanteCompras.txtCuenta.Text = dgvLista.Rows(f).Cells("cuenta").Value.ToString
                frmAbonoComprobanteCompras.txtDescripcion.Text = "PAGO CON " & dgvLista.Rows(f).Cells("descripcion").Value.ToString.ToUpper
                frmAbonoComprobanteCompras.txtCuenta.Enabled = False
                frmAbonoComprobanteCompras.txtBE.Text = "1"
                'frmAbonoComprobanteCompras.btnAgregar.PerformClick()
            ElseIf formInicio = "abonoLetraVenta" Then
                frmAbonoDeudasLetrasACobrar.cargarTipoPagos(dgvLista.Rows(f).Cells("id").Value.ToString)
                frmAbonoDeudasLetrasACobrar.txtIdCaja.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmAbonoDeudasLetrasACobrar.lblCaja.Text = dgvLista.Rows(f).Cells("descripcion").Value.ToString.ToUpper
                frmAbonoDeudasLetrasACobrar.txtCuentaCaja.Text = dgvLista.Rows(f).Cells("cuenta").Value.ToString
                'obtener id del banco
                Dim dt As New DataTable
                dt = obj.nCrudListarBD("select * from cuenta_contable where id='" & dgvLista.Rows(f).Cells("cuenta").Value.ToString & "'", CadenaConexion)
                If dt.Rows.Count > 0 Then
                    frmAbonoDeudasLetrasACobrar.txtIdBanco.Text = dt.Rows(0)("id_banco").ToString
                Else
                    frmAbonoDeudasLetrasACobrar.txtIdBanco.Text = "0"
                End If
            ElseIf formInicio = "abonoLetraCompra" Then
                frmAbonoLetras.cargarTipoPagos(dgvLista.Rows(f).Cells("id").Value.ToString)
                frmAbonoLetras.txtIdCaja.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmAbonoLetras.lblCaja.Text = dgvLista.Rows(f).Cells("descripcion").Value.ToString.ToUpper
                frmAbonoLetras.txtCuentaCaja.Text = dgvLista.Rows(f).Cells("cuenta").Value.ToString
                'obtener id del banco
                Dim dt As New DataTable
                dt = obj.nCrudListarBD("select * from cuenta_contable where id='" & dgvLista.Rows(f).Cells("cuenta").Value.ToString & "'", CadenaConexion)
                If dt.Rows.Count > 0 Then
                    frmAbonoLetras.txtIdBanco.Text = dt.Rows(0)("id_banco").ToString
                Else
                    frmAbonoLetras.txtIdBanco.Text = "0"
                End If
            ElseIf formInicio = "abonoCompra2" Then
                frmAbonoComprobanteCompras.cargarTipoPagos2(dgvLista.Rows(f).Cells("id").Value.ToString)
                frmAbonoComprobanteCompras.txtIdCaja2.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmAbonoComprobanteCompras.lblCaja2.Text = dgvLista.Rows(f).Cells("descripcion").Value.ToString.ToUpper
                frmAbonoComprobanteCompras.txtCDetraccion.Text = dgvLista.Rows(f).Cells("cuenta").Value.ToString
            ElseIf formInicio = "abonoVenta" Then
                frmAbonoComprobanteVentas.cargarTipoPagos(dgvLista.Rows(f).Cells("id").Value.ToString)
                frmAbonoComprobanteVentas.txtIdCaja.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmAbonoComprobanteVentas.lblCaja.Text = dgvLista.Rows(f).Cells("descripcion").Value.ToString.ToUpper
                frmAbonoComprobanteVentas.txtCuenta.Text = dgvLista.Rows(f).Cells("cuenta").Value.ToString
                frmAbonoComprobanteVentas.txtDescripcion.Text = "COBRO EN " & dgvLista.Rows(f).Cells("descripcion").Value.ToString.ToUpper
                frmAbonoComprobanteVentas.txtCuenta.Enabled = False
                frmAbonoComprobanteVentas.txtBE.Text = "1"
                'frmAbonoComprobanteVentas.btnAgregar.PerformClick()
            ElseIf formInicio = "abonoVenta2" Then
                frmAbonoComprobanteVentas.cargarTipoPagos2(dgvLista.Rows(f).Cells("id").Value.ToString)
                frmAbonoComprobanteVentas.txtIdCaja2.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmAbonoComprobanteVentas.lblCaja2.Text = dgvLista.Rows(f).Cells("descripcion").Value.ToString.ToUpper
                frmAbonoComprobanteVentas.txtCDetraccion.Text = dgvLista.Rows(f).Cells("cuenta").Value.ToString
                'frmAbonoComprobanteVentas.btnAgregar2.PerformClick()
            End If
        End If
        Me.Close()
    End Sub

    Private Sub dgvLista_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLista.CellContentDoubleClick
        cargarDatosAAdicionAsientoApertura()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cargarSaldosCajas()
    End Sub

    Private Sub btnPagarLetra_Click(sender As Object, e As EventArgs) Handles btnPagarLetra.Click
        If formInicio = "abonoCompra" Then
            frmListaNotasCreditoCompra.formulario = "compra"
            frmListaNotasCreditoCompra.rucCliente = frmAbonoComprobanteCompras.lblDniRuc.Text
            frmListaNotasCreditoCompra.codComprobante = frmAbonoComprobanteCompras.codCompra
            frmListaNotasCreditoCompra.Show()
        Else
            frmListaNotasCreditoVenta.rucCliente = frmAbonoComprobanteVentas.lblDniRuc.Text
            frmListaNotasCreditoVenta.codComprobante = frmAbonoComprobanteVentas.codVenta
            frmListaNotasCreditoVenta.Show()
        End If
    End Sub
End Class