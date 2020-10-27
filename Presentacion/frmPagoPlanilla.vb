Imports Negocio
Imports Entidades
Public Class frmPagoPlanilla
    Dim objCrud As New nCrud
    Public COD_PLANILLA As String
    Public procesoCompra As String = ""
    Dim iCarga As Integer = 0
    Public tipo As String = ""
    Private Sub frmPagoPlanilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvOperaciones.RowTemplate.Height = 30
        cebrasDatagrid(dgvOperaciones, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        txtCuenta.Select()
        If COD_PLANILLA <> "" Then
            Dim data As New DataTable
            data = objCrud.nCrudListarBD("select * from planillas where id='" & COD_PLANILLA & "'", CadenaConexion)
            txtMonto.Text = data.Rows(0)("total").ToString
            txtGlosa.Text = "POR EL PAGO DE PLANILLA - " & data.Rows(0)("glosa").ToString
        Else
            txtMonto.Text = IIf(tipo = "modificar", frmModificarPlanillas.txtTotal.Text.Trim, frmPlanillas.txtTotal.Text.Trim)
            txtGlosa.Text = "POR EL PAGO DE PLANILLA N° " & IIf(tipo = "modificar", frmModificarPlanillas.txtNumPlanilla.Text, frmPlanillas.txtNumPlanilla.Text)
        End If
        txtTDebeS.Text = "0.00"
        txtTHaberS.Text = "0.00"
        txtDiferenciaS.Text = "0.00"
        iCarga = 1
        cargarTipoPagos(txtIdCaja.Text.Trim)
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        cargarCuentasDePago()
    End Sub
    Public Sub cargarCuentasDePago()
        If txtIdCaja.Text.Trim <> "0" And txtCuenta.Text.Trim <> "0" Then
            Dim cuenta As String = ""
            cuenta = txtCuenta.Text.Trim
            Dim monto As Decimal = 0
            monto = Decimal.Parse(txtMonto.Text.Trim)
            Dim dtData As New DataTable
            With dtData.Columns
                .Add("num_cuenta")
                .Add("desc_cuenta")
                .Add("debe")
                .Add("haber")
            End With

            'detectar si se cancela con caja chica
            Dim idCaja As String = "1"
            idCaja = txtIdCaja.Text.Trim
            If COD_PLANILLA <> "" Then
                Dim dt As New DataTable
                dt = objCrud.nCrudListarBD("select * from detalle_planilla where id_planilla='" & COD_PLANILLA & "'", CadenaConexion)
                For Each row As DataRow In dt.Rows
                    If row.Item("cuenta").ToString.StartsWith("41") Then
                        dtData.Rows.Add(row.Item("cuenta").ToString, obtenerDatosCuenta(row.Item("cuenta").ToString), monto, "0.00")
                    End If
                Next
            Else
                For Each row As DataGridViewRow In IIf(tipo = "modificar", frmModificarPlanillas.dgvOperaciones.Rows, frmPlanillas.dgvOperaciones.Rows)
                    If row.Cells("num_cuenta").Value.ToString.StartsWith("41") Then
                        dtData.Rows.Add(row.Cells("num_cuenta").Value, obtenerDatosCuenta(row.Cells("num_cuenta").Value), monto, "0.00")
                    End If
                Next
            End If

            'FIN''''''''''''''''''''''''''''
            'AGREGAR CUENTA 10
            dtData.Rows.Add(cuenta, obtenerDatosCuenta(cuenta), "0.00", monto)
            'FIN''''''''''''''''''''''''''''

            dgvOperaciones.DataSource = dtData
            realizarSumasTotales()
        End If

    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function
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
    Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtGlosa.Focus()
        End If
    End Sub
    Private Sub txtGlosa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGlosa.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnCargar.Focus()
        End If
    End Sub
    Private Sub btnFinalizar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnFinalizar.KeyPress
        If Asc(e.KeyChar) = 13 Then
            guardarPagos()
        End If
    End Sub
    Private Sub frmNuevaCompraP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        If dgvOperaciones.RowCount = 0 And Decimal.Parse(txtDiferenciaS.Text.Trim) <> 0 Or Decimal.Parse(txtTDebeS.Text.Trim) = 0 Then
            MsgBox("No hay partida doble en la operación, verifique los montos para poder finalizar.")
        Else
            guardarPagos()
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
    Private Sub guardarDatos(estadoComprobante As String)
        Dim dato, dato2 As String
        Dim objPla As New nPlanillas

        If tipo = "modificar" Then
            With frmModificarPlanillas
                dato = objPla.actualizarCabeceraPlanillaBD(.txtNumPlanilla.Text.Trim, .txtGlosaPlanilla.Text.Trim, .cboPeriodo.Text.ToString, .cboMoneda.SelectedValue.ToString, txtTDebeS.Text.Trim, Date.Parse(.dtFecha.Value), "PAGADO", "1", CadenaConexion)
                'MsgBox("REGISTRO PLANILLA: " & dato)
                If dato = "ok" Then
                    Dim data As New DataTable
                    data = objCrud.nCrudListarBD("select * from planillas where id='" & .txtNumPlanilla.Text.Trim & "'", CadenaConexion)

                    'Borrar registro de cuentas de planilla
                    objCrud.nEjecutarQueryBD("delete from detalle_planilla where id_planilla='" & .txtNumPlanilla.Text.Trim & "'", CadenaConexion)

                    'REGISTRO DETALLE PLANILLAS
                    Dim campos, valores As String
                    campos = "id_planilla@cuenta@debe@haber@glosa@id_centro"

                    Dim eLD As New ALDiarioEntity
                    Dim objLD As New nAsientoLibroDiario
                    For Each row As DataGridViewRow In .dgvOperaciones.Rows
                        valores = .txtNumPlanilla.Text.Trim & "@" & row.Cells("num_cuenta").Value & "@" & row.Cells("debe").Value & "@" & row.Cells("haber").Value & "@" & row.Cells("glosa").Value & "@" & row.Cells("id_centro").Value
                        dato2 = objCrud.nCrudInsertarBD("@", "detalle_planilla", campos, valores, CadenaConexion)
                        'MsgBox("REGISTRO DETALLE PLANILLA: " & dato2)
                        With eLD
                            .id_comprobante = "PL" & IIf(tipo = "modificar", frmModificarPlanillas.txtNumPlanilla.Text.Trim, frmPlanillas.txtNumPlanilla.Text.Trim)
                            .cuo = "0"
                            .fecha_operacion = Date.Parse(IIf(tipo = "modificar", frmModificarPlanillas.dtFecha.Value, frmPlanillas.txtFecha.Text))
                            .glosa = row.Cells("glosa").Value.ToString
                            .cod_libro = row.Cells("num_cuenta").Value.ToString
                            .numero_correlativo = "-"
                            .numero_documento = "-"
                            .cuenta = row.Cells("num_cuenta").Value
                            .denominacion = row.Cells("glosa").Value
                            .debe = row.Cells("debe").Value
                            .haber = row.Cells("haber").Value
                        End With
                        objLD.registrarAsientoLibroDiarioBD(eLD, CadenaConexion)
                    Next

                    'Capturar Id Centro - Buscado en la grilla
                    Dim idCentroCosto As Integer = 0
                    Dim entidad As New ALDiarioEntity
                    For Each row As DataGridViewRow In IIf(tipo = "modificar", frmModificarPlanillas.dgvOperaciones.Rows, frmPlanillas.dgvOperaciones.Rows)
                        'Integer.Parse(row.Cells("id_centro").Value.ToString) > 0 Or 
                        If Not IsDBNull(row.Cells("id_centro").Value) Then
                            If Integer.Parse(row.Cells("id_centro").Value) > 0 Then
                                idCentroCosto = IIf(IsDBNull(row.Cells("id_centro").Value), 0, Integer.Parse(row.Cells("id_centro").Value.ToString))
                                'Registrar asientos del Centro de Costos
                                If idCentroCosto > 0 Then
                                    Dim dtCC As New DataTable
                                    dtCC = objCrud.nCrudListarBD("select * from parametro_centro_costo where id_centro=" & idCentroCosto, CadenaConexion)
                                    Dim calculo As Decimal = 0
                                    For i As Integer = 0 To dtCC.Rows.Count - 1
                                        calculo = Decimal.Parse(row.Cells("debe").Value) * Decimal.Parse(dtCC.Rows(i)("porcentaje").ToString) / 100
                                        campos = "id_planilla@cuenta@debe@haber@glosa@id_centro"
                                        valores = IIf(tipo = "modificar", frmModificarPlanillas.txtNumPlanilla.Text.Trim, frmPlanillas.txtNumPlanilla.Text.Trim) & "@" & dtCC.Rows(i)("cuenta").ToString & "@" & IIf(dtCC.Rows(i)("debe").ToString = "X", calculo, "0.00") & "@" & IIf(dtCC.Rows(i)("haber").ToString = "X", calculo, "0.00") & "@" & IIf(tipo = "modificar", frmModificarPlanillas.txtGlosaPlanilla.Text.Trim, frmPlanillas.txtGlosaPlanilla.Text.Trim) & "@" & row.Cells("id_centro").Value
                                        Dim rptaCmdA As String = ""
                                        rptaCmdA = objCrud.nCrudInsertarBD("@", "detalle_planilla", campos, valores, CadenaConexion)
                                        If rptaCmdA <> "ok" Then
                                            MsgBox("Error al registrar Asiento Planilla: " & rptaCmdA)
                                        Else
                                            With entidad
                                                .id_comprobante = "PL" & IIf(tipo = "modificar", frmModificarPlanillas.txtNumPlanilla.Text.Trim, frmPlanillas.txtNumPlanilla.Text.Trim)
                                                .cuo = "0"
                                                .fecha_operacion = Date.Parse(IIf(tipo = "modificar", frmModificarPlanillas.dtFecha.Value, frmPlanillas.txtFecha.Text))
                                                .glosa = IIf(tipo = "modificar", frmModificarPlanillas.txtGlosaPlanilla.Text.Trim, frmPlanillas.txtGlosaPlanilla.Text.Trim)
                                                .cod_libro = dtCC.Rows(i)("cuenta").ToString
                                                .numero_correlativo = "-"
                                                .numero_documento = "-"
                                                .cuenta = dtCC.Rows(i)("cuenta").ToString
                                                .denominacion = obtenerDatosCuenta(dtCC.Rows(i)("cuenta").ToString)
                                                .debe = IIf(dtCC.Rows(i)("debe").ToString = "X", calculo, "0.00")
                                                .haber = IIf(dtCC.Rows(i)("haber").ToString = "X", calculo, "0.00")
                                            End With
                                            objLD.registrarAsientoLibroDiarioBD(entidad, CadenaConexion)
                                        End If
                                    Next
                                End If
                            End If
                        End If
                    Next

                    'MsgBox("Registro de Asientos para la Planilla realizado con éxito")
                    'limpiarEntradas()
                End If
            End With
        Else
            With frmPlanillas

                dato = objPla.registrarCabeceraPlanillaBD(.txtNumPlanilla.Text.Trim, .txtGlosaPlanilla.Text.Trim, .cboPeriodo.Text.ToString, .cboMoneda.SelectedValue.ToString, txtTDebeS.Text.Trim, Date.Parse(.txtFecha.Text), "PAGADO", "1", CodigoEmpresaSession, CadenaConexion)
                'MsgBox("REGISTRO PLANILLA: " & dato)
                If dato = "ok" Then
                    Dim data As New DataTable
                    data = objCrud.nCrudListarBD("select * from planillas where id='" & .txtNumPlanilla.Text.Trim & "'", CadenaConexion)

                    'REGISTRO DETALLE PLANILLAS
                    Dim campos, valores As String
                    campos = "id_planilla@cuenta@debe@haber@glosa@id_centro"

                    Dim eLD As New ALDiarioEntity
                    Dim objLD As New nAsientoLibroDiario
                    For Each row As DataGridViewRow In .dgvOperaciones.Rows
                        valores = .txtNumPlanilla.Text.Trim & "@" & row.Cells("num_cuenta").Value & "@" & row.Cells("debe").Value & "@" & row.Cells("haber").Value & "@" & row.Cells("glosa").Value & "@" & row.Cells("id_centro").Value
                        dato2 = objCrud.nCrudInsertarBD("@", "detalle_planilla", campos, valores, CadenaConexion)
                        'MsgBox("REGISTRO DETALLE PLANILLA: " & dato2)
                        With eLD
                            .id_comprobante = "PLA" & IIf(tipo = "modificar", frmModificarPlanillas.txtNumPlanilla.Text.Trim, frmPlanillas.txtNumPlanilla.Text.Trim)
                            .cuo = "0"
                            .fecha_operacion = Date.Parse(IIf(tipo = "modificar", frmModificarPlanillas.dtFecha.Value, frmPlanillas.txtFecha.Text))
                            .glosa = row.Cells("glosa").Value.ToString
                            .cod_libro = row.Cells("num_cuenta").Value.ToString
                            .numero_correlativo = "-"
                            .numero_documento = "-"
                            .cuenta = row.Cells("num_cuenta").Value
                            .denominacion = row.Cells("glosa").Value
                            .debe = row.Cells("debe").Value
                            .haber = row.Cells("haber").Value
                        End With
                        objLD.registrarAsientoLibroDiarioBD(eLD, CadenaConexion)
                    Next

                    'Capturar Id Centro - Buscado en la grilla
                    Dim idCentroCosto As Integer = 0
                    Dim entidad As New ALDiarioEntity
                    For Each row As DataGridViewRow In IIf(tipo = "modificar", frmModificarPlanillas.dgvOperaciones.Rows, frmPlanillas.dgvOperaciones.Rows)
                        'Integer.Parse(row.Cells("id_centro").Value.ToString) > 0 Or 
                        If Not IsDBNull(row.Cells("id_centro").Value) Then
                            If Integer.Parse(row.Cells("id_centro").Value) > 0 Then
                                idCentroCosto = IIf(IsDBNull(row.Cells("id_centro").Value), 0, Integer.Parse(row.Cells("id_centro").Value.ToString))
                                'Registrar asientos del Centro de Costos
                                If idCentroCosto > 0 Then
                                    Dim dtCC As New DataTable
                                    dtCC = objCrud.nCrudListarBD("select * from parametro_centro_costo where id_centro=" & idCentroCosto, CadenaConexion)
                                    Dim calculo As Decimal = 0
                                    For i As Integer = 0 To dtCC.Rows.Count - 1
                                        calculo = Decimal.Parse(row.Cells("debe").Value) * Decimal.Parse(dtCC.Rows(i)("porcentaje").ToString) / 100
                                        campos = "id_planilla@cuenta@debe@haber@glosa@id_centro"
                                        valores = IIf(tipo = "modificar", frmModificarPlanillas.txtNumPlanilla.Text.Trim, frmPlanillas.txtNumPlanilla.Text.Trim) & "@" & dtCC.Rows(i)("cuenta").ToString & "@" & IIf(dtCC.Rows(i)("debe").ToString = "X", calculo, "0.00") & "@" & IIf(dtCC.Rows(i)("haber").ToString = "X", calculo, "0.00") & "@" & IIf(tipo = "modificar", frmModificarPlanillas.txtGlosaPlanilla.Text.Trim, frmPlanillas.txtGlosaPlanilla.Text.Trim) & "@" & row.Cells("id_centro").Value
                                        Dim rptaCmdA As String = ""
                                        rptaCmdA = objCrud.nCrudInsertarBD("@", "detalle_planilla", campos, valores, CadenaConexion)
                                        If rptaCmdA <> "ok" Then
                                            MsgBox("Error al registrar Asiento Planilla: " & rptaCmdA)
                                        Else
                                            With entidad
                                                .id_comprobante = "PLA" & IIf(tipo = "modificar", frmModificarPlanillas.txtNumPlanilla.Text.Trim, frmPlanillas.txtNumPlanilla.Text.Trim)
                                                .cuo = "0"
                                                .fecha_operacion = Date.Parse(IIf(tipo = "modificar", frmModificarPlanillas.dtFecha.Value, frmPlanillas.txtFecha.Text))
                                                .glosa = IIf(tipo = "modificar", frmModificarPlanillas.txtGlosaPlanilla.Text.Trim, frmPlanillas.txtGlosaPlanilla.Text.Trim)
                                                .cod_libro = dtCC.Rows(i)("cuenta").ToString
                                                .numero_correlativo = "-"
                                                .numero_documento = "-"
                                                .cuenta = dtCC.Rows(i)("cuenta").ToString
                                                .denominacion = obtenerDatosCuenta(dtCC.Rows(i)("cuenta").ToString)
                                                .debe = IIf(dtCC.Rows(i)("debe").ToString = "X", calculo, "0.00")
                                                .haber = IIf(dtCC.Rows(i)("haber").ToString = "X", calculo, "0.00")
                                            End With
                                            objLD.registrarAsientoLibroDiarioBD(entidad, CadenaConexion)
                                        End If
                                    Next
                                End If
                            End If
                        End If
                    Next

                    MsgBox("Registro de Asientos para la Planilla realizado con éxito")
                    'limpiarEntradas()
                End If
            End With
        End If
    End Sub
    Private Sub guardarPagos()
        Dim dataPlanilla As New DataTable
        Dim objCom As New nComprobanteCompra
        If COD_PLANILLA <> "" Then
            dataPlanilla = objCrud.nCrudListarBD("select top 1 * from planillas where id='" & COD_PLANILLA & "' order by id desc", CadenaConexion)
        Else
            guardarDatos("F")
            dataPlanilla = objCrud.nCrudListarBD("select top 1 * from planillas where id='" & IIf(tipo = "modificar", frmModificarPlanillas.txtNumPlanilla.Text.Trim, frmPlanillas.txtNumPlanilla.Text.Trim) & "' order by id desc", CadenaConexion)
        End If
        Dim codPlanilla As String
        If dataPlanilla.Rows.Count > 0 Then
            codPlanilla = dataPlanilla.Rows(0)("id").ToString
        Else
            codPlanilla = "1"
        End If
        Dim EntiAboPla, EntiAsientoAboPla As New AbonoPlanillasEntity
        'buscar cuenta en caja y obtener tipo de pago
        Dim dtP, dtP2 As New DataTable
        dtP = objCrud.nCrudListarBD("select * from caja_configuracion where cuenta='" & txtCuenta.Text.Trim & "' ", CadenaConexion)
        dtP2 = objCrud.nCrudListarBD("select * from cajas_tipo_pago where id_caja='" & dtP.Rows(0)("id").ToString & "' ", CadenaConexion)
        With EntiAboPla
            .id_planilla = codPlanilla
            .id_caja = txtIdCaja.Text.Trim
            .tipo_comprobante = dtP2.Rows(0)("id_tipo_pago").ToString 'dataPlanilla.Rows(0)("id_tipo_comprobante").ToString
            .monto = txtMonto.Text.Trim
            .tipo = cboTipoPago.SelectedValue.ToString
            .numero = txtNumero.Text.Trim
            .descripcion = txtGlosa.Text.Trim
            .fecha = DateTime.Now.ToString("yyyy/MM/dd") & " " & Now.ToString("HH:mm:ss")
            .estado = "1"
        End With
        Dim objAbono As New nPlanillas
        objAbono.nRegistrarAbonoPlanillasBD(EntiAboPla, CadenaConexion)

        For Each row As DataGridViewRow In dgvOperaciones.Rows
            With EntiAsientoAboPla
                .id = objAbono.nObtenerUltimoAbonoPlanillaBD(CadenaConexion)
                .id_personal = "8888" 'dataPlanilla.Rows(0)("num_dni").ToString
                .id_planilla = codPlanilla
                .cuenta = row.Cells("num_cuenta").Value
                .base_imponible = txtMonto.Text.Trim
                .monto = txtMonto.Text.Trim
                .tipo = cboTipoPago.SelectedValue.ToString
                .descripcion = txtGlosa.Text.Trim
                .debe = row.Cells("debe").Value
                .haber = row.Cells("haber").Value
                If COD_PLANILLA <> "" Then
                    .fecha = Date.Parse(dataPlanilla.Rows(0)("fec_emision")).ToString("yyyy/MM/dd")
                Else
                    .fecha = IIf(tipo = "modificar", frmModificarPlanillas.dtFecha.Value.ToString("yyyy/MM/dd"), frmPlanillas.txtFecha.Text)
                End If
            End With
            objAbono.nRegistrarAsientosAbonoPlanillasBD(EntiAsientoAboPla, CadenaConexion)
            'MsgBox("ASIENTOS ABONOS: " & objAbono.nRegistrarAsientoAbonoComprasBD(EntiAsientoAboCom, CadenaConexion))
        Next
        If COD_PLANILLA <> "" Then
            'ACTUALIZAR ESTADO DE PLANILLA A PAGADO
            objCrud.nCrudActualizarBD("@", "planillas", "tipo_estado", "PAGADO", "id='" & COD_PLANILLA & "'", CadenaConexion)
            frmListaPlanillas.cargarPlanillas()
        End If

        MsgBox("PAGO DE PLANILLA REGISTRADA CON ÉXITO")
        'frmListaComprobanteCompras.realizarConsulta()
        IIf(tipo = "modificar", frmModificarPlanillas, frmPlanillas).Dispose()
        frmListaPlanillas.cargarPlanillas()
        Me.Dispose()
    End Sub

    Private Sub btnCaja_Click(sender As Object, e As EventArgs) Handles btnCaja.Click
        Me.Enabled = False
        frmEscogerCaja.formInicio = "planilla"
        frmEscogerCaja.Show()
        Me.Enabled = True
    End Sub

    Private Sub txtIdCaja_TextChanged(sender As Object, e As EventArgs) Handles txtIdCaja.TextChanged
        cargarTipoPagos(txtIdCaja.Text.Trim)
    End Sub

    Public Sub cargarTipoPagos(codCaja As String)
        Dim data, data2, data3 As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        'data.Rows.Add(0, "SIN AFECTO")

        data2 = objCrud.nCrudListarBD("select * from cajas_tipo_pago where id_caja='" & codCaja & "'", CadenaConexion)
        For Each row As DataRow In data2.Rows
            data3 = objCrud.nCrudListarBD("select * from tipo_pago where id='" & row.Item("id_tipo_pago") & "'", CadenaConexion)
            data.Rows.Add(data3.Rows(0)("id").ToString, data3.Rows(0)("descripcion").ToString)
        Next
        With cboTipoPago
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub
    Private Sub txtMonto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.Leave
        txtMonto.Text = Format(CType(txtMonto.Text, Decimal), "###0.00")
    End Sub
    
    Private Sub cboTipoPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoPago.SelectedIndexChanged
        If iCarga = 1 Then
            If cboTipoPago.Text.ToString.StartsWith("CHEQ") Then
                frmGirarCheque.tipoAbono = "planilla"
                frmGirarCheque.valMoneda = frmPlanillas.cboMoneda.SelectedValue.ToString
                frmGirarCheque.btnCargarDatosAbono.Visible = True
                frmGirarCheque.btnElegirCheque.Visible = True
                frmGirarCheque.redimensionar()
                frmGirarCheque.Show()
            End If
        End If
    End Sub
End Class