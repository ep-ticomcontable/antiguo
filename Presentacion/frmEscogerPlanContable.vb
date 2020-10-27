Imports Negocio

Public Class frmEscogerPlanContable
    Dim obj As New nCrud
    Public cuentaInicio As String = ""
    Public cuenta As String = ""
    Public formInicio As String = ""
    Public input As String = ""

    Private Sub frmEscogerPlanContable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLista.RowTemplate.Height = 30
        'cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        cargarDatosCuentaContable()
        formatoGrilla()
    End Sub

    Public Sub cargarDatosCuentaContable()
        Dim cuentaInicio2digitos As String
        cuentaInicio2digitos = cuentaInicio '.Substring(0, 2)
        ' and nivel_cuenta='REGISTRO'
        dgvLista.DataSource = obj.nCrudListarBD("select * from vista_CuentaContableGrilla where num_cuenta like '" & cuentaInicio2digitos & "%'  order by num_cuenta asc", CadenaConexion)
    End Sub

    Public Sub seleccionarCodigoDeCuenta()
        For i As Integer = 0 To dgvLista.Rows.Count - 1
            For x As Integer = 0 To dgvLista.ColumnCount - 1
                If dgvLista.Rows(i).Cells("id").Value.ToString = cuenta Then
                    dgvLista.CurrentCell = dgvLista.Rows(i).Cells("id")
                End If
            Next
        Next
    End Sub
    Public Sub formatoGrilla()
        'For Each row As DataGridViewRow In dgvLista.Rows
        '    If row.Cells("c1").Value.ToString = "ACTIVO" Then
        '        row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(227, 242, 247)
        '    End If
        'Next
    End Sub
    Private Sub dgvLista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvLista.KeyDown
        If e.KeyCode = Keys.Enter Then
            cargarDatosAAdicionAsientoApertura()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnElegir_Click(sender As Object, e As EventArgs) Handles btnElegir.Click
        cargarDatosAAdicionAsientoApertura()
    End Sub

    Private Sub cargarDatosAAdicionAsientoApertura()
        If dgvLista.Rows.Count > 0 Then
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            'MsgBox(dgvLista.Rows(f).Cells("id").Value.ToString)
            If formInicio = "frmPagoComprobanteVenta" Then
                frmPagoComprobanteVenta.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmPagoComprobanteVenta.lblNomCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "frmPagoComprobanteCompra" Then
                frmPagoComprobanteCompra.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmPagoComprobanteCompra.lblNomCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "frmAbonoComprobanteCompras" Then
                frmAbonoComprobanteCompras.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                'frmAbonoComprobanteCompras.lblNomCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "compraMercaderia" Then
                frmNuevaCompraMercaderias.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmNuevaCompraMercaderias.lblNomCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "pagoComprobante" Then
                frmPagoComprobante.txtCuentaC.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmPagoComprobante.lblNomCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "ventaMercaderia" Then
                frmNuevaVentaMercaderias.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmNuevaVentaMercaderias.lblNomCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "general" Then
                frmIngresosGenericos.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmIngresosGenericos.lblNomCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "retencionP" Then
                frmListaRetencionesPorPagar.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmListaRetencionesPorPagar.lblNomCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "retencionC" Then
                frmListaRetencionesPorCobrar.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmListaRetencionesPorCobrar.lblNomCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "modificargeneral" Then
                frmModificarIngresosGenericos.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmModificarIngresosGenericos.lblNomCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "frmAbonoComprobanteCompras2" Then
                frmAbonoComprobanteCompras.txtCuentaP.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmAbonoComprobanteCompras.lblCuentaP.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "frmAbonoComprobanteVentas" Then
                frmAbonoComprobanteVentas.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
            ElseIf formInicio = "frmAbonoComprobanteVentas2" Then
                frmAbonoComprobanteVentas.txtCuentaP.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmAbonoComprobanteVentas.lblCuentaP.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "frmNuevaCompra" Then
                frmNuevaCompra.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmNuevaCompra.lblNomCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "frmNuevaVentaP" Then
                frmNuevaVenta.txtCuentaP.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmNuevaVenta.lblCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "frmNuevaVentaD" Then
                frmNuevaVenta.txtCuentaD.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmNuevaVenta.lblNomCuentaD.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "frmNuevaCompraP" Then
                frmNuevaCompra.txtCuentaP.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmNuevaCompra.lblCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "frmNuevaCompraPago" Then
                frmNuevaCompra.txtCuentaPago.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmNuevaCompra.lblCuentaPago.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "frmNuevaCompraDetraccion" Then
                frmNuevaCompra.txtCDetraccion.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmNuevaCompra.lblDetraccion.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "frmAbonoCompra" Then
                frmAbonoComprobanteCompras.txtCDetraccion.Text = dgvLista.Rows(f).Cells("id").Value.ToString
            ElseIf formInicio = "frmAbonoVenta" Then
                frmAbonoComprobanteVentas.txtCDetraccion.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                'frmAbonoComprobanteCompras.lblDetraccion.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "frmTsCuentasTipoOperacion" Then
                frmTsCuentasTipoOperacion.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmTsCuentasTipoOperacion.lblCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "frmPlanillas" Then
                frmPlanillas.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmPlanillas.lblCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "frmModificarPlanillas" Then
                frmModificarPlanillas.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmModificarPlanillas.lblCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "ImpuestosSunat" Then
                frmTsImpuestosSunat.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmTsImpuestosSunat.lblNomCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "frmAbonoDeudasLetras" Then
                'frmAbonoDeudasLetrasACobrar.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                'frmAbonoDeudasLetrasACobrar.lblCaja.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "agregarCuenta" Then
                frmAgregarCuenta.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmAgregarCuenta.lblCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "agregarCuentaNuevo" Then
                frmAgregarCuentasNuevo.verificarTipoOperacion(dgvLista.Rows(f).Cells("id").Value.ToString)
                frmAgregarCuentasNuevo.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmAgregarCuentasNuevo.lblCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
                frmAgregarCuentasNuevo.txtGlosa.Text = "REGISTRO " & dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
                frmAgregarCuentasNuevo.txtDebe.Select()
            ElseIf formInicio = "agregarCuentaNota" Then
                frmAgregarCuentaNotas.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmAgregarCuentaNotas.lblCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "agregarCuentaRapida" Then
                frmAgregarCuentasRapidas.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmAgregarCuentasRapidas.lblCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "frmAbonoDeudasBanco" Then
                frmAbonoDeudasBanco.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmAbonoDeudasBanco.lblNomCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "frmAsientoCierre" Then
                frmAgregarAsientoCierre.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmAgregarAsientoCierre.lblNomCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "cobranzas" Then
                frmCobranzas.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmCobranzas.lblCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
                'frmCobranzas.txtDebe.setfocus()
            ElseIf formInicio = "cuentaPago" Then
                frmNuevaCompraPago.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                'frmNuevaCompraPago.lblNomCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
                frmNuevaCompraPago.txtMonto.Select()
            ElseIf formInicio = "cajachica" Then
                frmSalidaCaja.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmSalidaCaja.lblCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
                frmSalidaCaja.txtMonto.Select()
            ElseIf formInicio = "cajabanco" Then
                frmSalidaBanco.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmSalidaBanco.lblCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
                frmSalidaBanco.txtMonto.Select()
            ElseIf formInicio = "cajabanco" Then
                frmSalidaBanco.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmSalidaBanco.lblCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
                frmSalidaBanco.txtMonto.Select()
            ElseIf formInicio = "cajaConf1" Then
                frmCajaConfiguracion.txtCuenta1.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmCajaConfiguracion.lblCuenta1.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "AC1" Then
                frmParametrosAsientoCierre.txtCuenta1.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmParametrosAsientoCierre.lblCuenta1.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "AC2" Then
                frmParametrosAsientoCierre.txtCuenta2.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmParametrosAsientoCierre.lblCuenta2.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "bancoConf" Then
                frmBancosConfiguracion.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmBancosConfiguracion.lblCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "cajaConf2" Then
                frmCajaConfiguracion.txtCuenta2.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmCajaConfiguracion.lblCuenta2.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "tipoSalida" Then
                frmTipoSalidas.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmTipoSalidas.lblCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            ElseIf formInicio = "cuentaPagoVenta" Then
                frmNuevaVentaPago.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmNuevaVentaPago.lblNomCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
                frmNuevaVentaPago.txtMonto.Select()
            ElseIf formInicio = "cuentaPagoVentaRapida" Then
                frmNuevaVentaMercaderiaPago.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmNuevaVentaMercaderiaPago.lblNomCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
                frmNuevaVentaMercaderiaPago.txtMonto.Select()
            ElseIf formInicio = "canje" Then
                frmCanjeLetraComprobantes.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmCanjeLetraComprobantes.lblCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
                frmCanjeLetraComprobantes.txtMonto.Select()
            ElseIf formInicio = "letraMod" Then
                frmModificarLetraPorPagar.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmModificarLetraPorPagar.lblCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
                frmModificarLetraPorPagar.txtMonto.Select()
            ElseIf formInicio = "diario" Then
                frmRegistroLibroDiario.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmRegistroLibroDiario.lblNomCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
                frmRegistroLibroDiario.txtMonto.Select()
            ElseIf formInicio = "frmCentroCosto" Then
                If input = "debe" Then
                    frmParametrosCentroCosto.txtDebe.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                    frmParametrosCentroCosto.lblDebe.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
                Else
                    frmParametrosCentroCosto.txtHaber.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                    frmParametrosCentroCosto.lblHaber.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
                End If
            ElseIf formInicio = "apertura" Then
                frmAgregarAsiento.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmAgregarAsiento.lblNomCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            Else
                frmAgregarAsiento.txtCuenta.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmAgregarAsiento.lblNomCuenta.Text = dgvLista.Rows(f).Cells("nombre").Value.ToString.ToUpper
            End If
        End If
        Me.Close()
    End Sub
    Private Sub dgvLista_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLista.CellContentDoubleClick
        cargarDatosAAdicionAsientoApertura()
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvLista.Rows.Count > 0 Then
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            frmPlanContable.cuentaInicial = cuentaInicio
            frmPlanContable.cuenta = dgvLista.Rows(f).Cells("id").Value.ToString
            frmPlanContable.cargarCuentaAModificar()
            frmPlanContable.btnBuscarProducto.PerformClick()
            frmPlanContable.btnModificar.PerformClick()
        End If
        frmPlanContable.formulario = "escoger"
        frmPlanContable.Show()
    End Sub
End Class