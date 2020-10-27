Imports Negocio
Imports Entidades

Public Class frmModificarIngresosGenericos
    Dim obj As New nCrud
    Dim objMon As New nMonedas
    Dim iCarga As Integer = 0
    Dim cuentas As New DataTable
    Public idComodin As Integer

    Private Sub cargarOperacion()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")

        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select * from tipo_operacion where estado=1", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(2).ToString)
            Next
            With cboTipoOperacion
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar Tipo de Operación")
        End Try
    End Sub
    Private Sub cargarTipoDocumento()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")

        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select * from tipo_documento where estado=1", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(2).ToString)
            Next
            With cboTipoDocumento
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar Tipo de Documento")
        End Try
    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = obj.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function
    Private Sub cargarMonedas()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select id,codigo,descripcion from tipo_moneda where estado=1 order by codigo asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
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
    Private Sub cargarBancos()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select * from bancos order by id asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboBancos
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Bancos")
        End Try
    End Sub

    Private Sub cargarMotivosAjuste()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add("0", "SELECCIONE")
        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select * from motivo_ajustes order by id asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboAjuste
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
                .SelectedValue = 0
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de motivos de ajuste")
        End Try
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
    Private Sub cargarDatosComodin()
        Dim data, detalle As New DataTable
        data = obj.nCrudListarBD("select * from comodin where id='" & idComodin & "'", CadenaConexion)
        With data
            cboAjuste.SelectedValue = .Rows(0)("id_tipo_ajuste").ToString
            cboTipoOperacion.SelectedValue = .Rows(0)("id_tipo_operacion").ToString
            cboTipoDocumento.SelectedValue = .Rows(0)("id_tipo_documento").ToString
            txtSerie.Text = .Rows(0)("serie").ToString
            txtNumero.Text = .Rows(0)("numero").ToString
            txtNumOperacion.Text = .Rows(0)("operacion").ToString
            cboBancos.SelectedValue = .Rows(0)("id_banco").ToString
            dtFechaEmision.Value = .Rows(0)("fec_reg").ToString
            cboMoneda.SelectedValue = .Rows(0)("id_moneda").ToString
            txtTipoCambio.Text = .Rows(0)("tipo_cambio").ToString
            txtGlosa.Text = .Rows(0)("glosa").ToString
        End With

        detalle = obj.nCrudListarBD("select * from asientos_comodin where id_comodin='" & idComodin & "' order by id asc", CadenaConexion)
        dgvOperaciones.DataSource = detalle
        realizarSumasTotales()
    End Sub
    Private Sub frmIngresosGenericos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvOperaciones.RowTemplate.Height = 30
        cebrasDatagrid(dgvOperaciones, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        cargarMotivosAjuste()
        cargarOperacion()
        cargarTipoDocumento()
        cargarMonedas()
        movimientoDH()
        cargarBancos()
        cargarDatosComodin()
        iCarga = 1
        cargarTipoDeCambio()
        'realizarSumasTotales()
    End Sub
    Private Sub cboMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMoneda.SelectedIndexChanged
        cargarTipoDeCambio()
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
        Dim dt As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
        Dim row As DataRow = dt.NewRow()
        row.Item(0) = "0"
        row.Item(1) = idComodin
        row.Item(2) = txtCuenta.Text.Trim
        row.Item(3) = lblNomCuenta.Text
        row.Item(4) = IIf(cboDH.SelectedValue.ToString = "D", txtMonto.Text, "0.00")
        row.Item(5) = IIf(cboDH.SelectedValue.ToString = "H", txtMonto.Text, "0.00")
        row.Item(6) = txtIdCentro.Text.Trim
        dt.Rows.Add(row)
        realizarSumasTotales()
        txtCuenta.Text = ""
        lblNomCuenta.Text = "[Nombre Cuenta]"
        txtCentro.Text = "-"
        txtIdCentro.Text = "0"
        txtMonto.Text = "0.00"
        txtCuenta.Focus()
        txtCuenta.Select()
    End Sub
    Private Sub frmIngresosGenericos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Insert Then
            btnAgregar.PerformClick()
        ElseIf e.KeyCode = Keys.End Then
            btnFinalizar.PerformClick()
        End If
    End Sub
    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        If dgvOperaciones.RowCount = 0 And Decimal.Parse(txtDiferenciaS.Text.Trim) <> 0 Or Decimal.Parse(txtTDebeS.Text.Trim) = 0 Then
            MsgBox("No hay partida doble en la operación, verifique los montos para poder finalizar.")
        Else
            Dim entiCmd, entiCmdALD As New ComodinEntity
            Dim entidad As New ALDiarioEntity
            Dim objLD As New nAsientoLibroDiario
            With entiCmd
                .id = idComodin
                .id_tipo_ajuste = cboAjuste.SelectedValue
                .id_tipo_operacion = cboTipoOperacion.SelectedValue
                .id_tipo_documento = cboTipoDocumento.SelectedValue
                .serie = txtSerie.Text.Trim
                .numero = txtNumero.Text.Trim
                .operacion = txtNumOperacion.Text.Trim
                .id_banco = cboBancos.SelectedValue
                .id_moneda = cboMoneda.SelectedValue
                .tipo_cambio = txtTipoCambio.Text.Trim
                .glosa = txtGlosa.Text.Trim
                .debe = txtTDebeS.Text.Trim
                .haber = txtTHaberS.Text.Trim
                .diferencia = txtDiferenciaS.Text.Trim
                .fec_reg = Date.Parse(dtFechaEmision.Value)
                .tipo = "FINALIZADO"
                .estado = "1"
            End With
            Dim rptaCmd As String = ""
            rptaCmd = objLD.actualizarComodinBD(entiCmd, CadenaConexion)
            If rptaCmd = "ok" Then
                'Limpieza de asientos
                obj.nEjecutarQueryBD("delete from asientos_comodin where id_comodin='" & idComodin & "'", CadenaConexion)

                Dim campos, valores As String
                campos = "id_comodin@cuenta@descripcion@debe@haber@id_centro@id_caja"

                For Each row As DataGridViewRow In dgvOperaciones.Rows
                    'BUSCAR SI LA CUENTA ES UNA CUENTA 10...
                    Dim dt As New DataTable
                    dt = obj.nCrudListarBD("select * from caja_configuracion where cuenta='" & row.Cells("cuenta").Value.ToString & "'", CadenaConexion)
                    Dim idCaja As Integer = 0
                    If dt.Rows.Count > 0 Then
                        idCaja = dt.Rows(0)("id").ToString
                    End If
                    valores = idComodin & "@" & row.Cells("cuenta").Value.ToString & "@" & row.Cells("descripcion").Value.ToString & "@" & row.Cells("debe").Value.ToString & "@" & row.Cells("haber").Value.ToString & "@" & row.Cells("id_centro").Value.ToString & "@" & idCaja
                    Dim rptaCmdA As String = ""
                    rptaCmdA = obj.nCrudInsertarBD("@", "asientos_comodin", campos, valores, CadenaConexion)
                    If rptaCmdA <> "ok" Then
                        MsgBox("Error al registrar Asiento Comodín: " & rptaCmdA)
                    Else
                        With entidad
                            .id_comprobante = "CMD" & idComodin
                            .cuo = "0"
                            .fecha_operacion = Date.Parse(dtFechaEmision.Value)
                            .glosa = txtGlosa.Text.Trim
                            .cod_libro = row.Cells("cuenta").Value
                            .numero_correlativo = "-"
                            .numero_documento = "-"
                            .cuenta = row.Cells("cuenta").Value
                            .denominacion = row.Cells("descripcion").Value
                            .debe = row.Cells("debe").Value
                            .haber = row.Cells("haber").Value
                        End With
                        objLD.registrarAsientoLibroDiarioBD(entidad, CadenaConexion)
                    End If
                Next

                'Capturar Id Centro - Buscado en la grilla
                Dim idCentroCosto As Integer = 0
                For Each row As DataGridViewRow In dgvOperaciones.Rows
                    'Integer.Parse(row.Cells("id_centro").Value.ToString) > 0 Or 
                    If Not IsDBNull(row.Cells("id_centro").Value) Then
                        If Integer.Parse(row.Cells("id_centro").Value) > 0 Then
                            idCentroCosto = IIf(IsDBNull(row.Cells("id_centro").Value), 0, Integer.Parse(row.Cells("id_centro").Value.ToString))
                            'Registrar asientos del Centro de Costos
                            If idCentroCosto > 0 Then
                                Dim dtCC As New DataTable
                                dtCC = obj.nCrudListarBD("select * from parametro_centro_costo where id_centro=" & idCentroCosto, CadenaConexion)
                                Dim calculo As Decimal = 0
                                For i As Integer = 0 To dtCC.Rows.Count - 1
                                    calculo = (Decimal.Parse(row.Cells("debe").Value) + Decimal.Parse(row.Cells("haber").Value)) * Decimal.Parse(dtCC.Rows(i)("porcentaje").ToString) / 100
                                    valores = idComodin & "@" & dtCC.Rows(i)("cuenta").ToString & "@" & obtenerDatosCuenta(dtCC.Rows(i)("cuenta").ToString) & "@" & IIf(dtCC.Rows(i)("debe").ToString = "X", calculo, "0.00") & "@" & IIf(dtCC.Rows(i)("haber").ToString = "X", calculo, "0.00") & "@0@0"
                                    Dim rptaCmdA As String = ""
                                    rptaCmdA = obj.nCrudInsertarBD("@", "asientos_comodin", campos, valores, CadenaConexion)
                                    If rptaCmdA <> "ok" Then
                                        MsgBox("Error al registrar Asiento Comodín: " & rptaCmdA)
                                    Else
                                        With entidad
                                            .id_comprobante = "CMD" & idComodin
                                            .cuo = "0"
                                            .fecha_operacion = Date.Parse(dtFechaEmision.Value)
                                            .glosa = txtGlosa.Text.Trim
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

                MsgBox("¡Asientos registrados correctamente!")
                frmListaComodin.cargarComodines()
                Me.Dispose()
            Else
                MsgBox("No se pudo registrar la cabecera del comodín: " & vbCrLf & rptaCmd)
            End If
        End If
        

    End Sub
    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim entiCmd, entiCmdALD As New ComodinEntity
        Dim entidad As New ALDiarioEntity
        Dim objLD As New nAsientoLibroDiario
        With entiCmd
            .id = idComodin
            .id_tipo_ajuste = cboAjuste.SelectedValue
            .id_tipo_operacion = cboTipoOperacion.SelectedValue
            .id_tipo_documento = cboTipoDocumento.SelectedValue
            .serie = txtSerie.Text.Trim
            .numero = txtNumero.Text.Trim
            .operacion = txtNumOperacion.Text.Trim
            .id_banco = cboBancos.SelectedValue
            .id_moneda = cboMoneda.SelectedValue
            .tipo_cambio = txtTipoCambio.Text.Trim
            .glosa = txtGlosa.Text.Trim
            .debe = txtTDebeS.Text.Trim
            .haber = txtTHaberS.Text.Trim
            .diferencia = txtDiferenciaS.Text.Trim
            .fec_reg = Date.Parse(dtFechaEmision.Value)
            .tipo = "GRABADO"
            .estado = "1"
        End With
        Dim rptaCmd As String = ""
        rptaCmd = objLD.actualizarComodinBD(entiCmd, CadenaConexion)
        If rptaCmd = "ok" Then
            'Limpieza de asientos
            obj.nEjecutarQueryBD("delete from asientos_comodin where id_comodin='" & idComodin & "'", CadenaConexion)

            Dim campos, valores As String
            campos = "id_comodin@cuenta@descripcion@debe@haber@id_centro@id_caja"
            For Each row As DataGridViewRow In dgvOperaciones.Rows
                'BUSCAR SI LA CUENTA ES UNA CUENTA 10...
                Dim dt As New DataTable
                dt = obj.nCrudListarBD("select * from caja_configuracion where cuenta='" & row.Cells("cuenta").Value.ToString & "'", CadenaConexion)
                Dim idCaja As Integer = 0
                If dt.Rows.Count > 0 Then
                    idCaja = dt.Rows(0)("id").ToString
                End If

                valores = idComodin & "@" & row.Cells("cuenta").Value.ToString & "@" & row.Cells("descripcion").Value.ToString & "@" & row.Cells("debe").Value.ToString & "@" & row.Cells("haber").Value.ToString & "@" & row.Cells("id_centro").Value.ToString & "@" & idCaja
                Dim rptaCmdA As String = ""
                rptaCmdA = obj.nCrudInsertarBD("@", "asientos_comodin", campos, valores, CadenaConexion)
                If rptaCmdA <> "ok" Then
                    MsgBox("Error al grabar Asiento Comodín: " & rptaCmdA)
                End If
            Next
            MsgBox("¡Asientos GRABADOS con éxito!")
            frmListaComodin.cargarComodines()
            Me.Close()
        Else
            MsgBox("No se pudo grabar la cabecera del comodín: " & vbCrLf & rptaCmd)
        End If
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub cboTipoOperacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboTipoOperacion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cboTipoDocumento.Focus()
        End If
    End Sub
    Private Sub cboTipoDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboTipoDocumento.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtSerie.Focus()
        End If
    End Sub
    Private Sub txtSerie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSerie.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtNumero.Focus()
        End If
    End Sub
    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtNumOperacion.Focus()
        End If
    End Sub
    Private Sub txtNumOperacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumOperacion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cboBancos.Focus()
        End If
    End Sub
    Private Sub cboBancos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboBancos.KeyPress
        If Asc(e.KeyChar) = 13 Then
            dtFechaEmision.Focus()
        End If
    End Sub
    Private Sub dtFechaEmision_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtFechaEmision.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cboMoneda.Focus()
        End If
    End Sub
    Private Sub cboMoneda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboMoneda.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtTipoCambio.Focus()
        End If
    End Sub
    Private Sub txtTipoCambio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipoCambio.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtGlosa.Focus()
        End If
    End Sub
    Private Sub txtGlosa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGlosa.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtCuenta.Focus()
        End If
    End Sub
    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtCuenta.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "modificargeneral"
                    .cuentaInicio = txtCuenta.Text.Trim
                    .ShowDialog()
                End With
            End If
            habilitarCentroCosto()
        End If
        If Asc(e.KeyChar) = 13 Then
            txtMonto.Focus()
        End If
    End Sub
    Public Sub habilitarCentroCosto()
        txtCentro.Text = "-"
        txtIdCentro.Text = "0"
        Dim cuentaCC As New DataTable
        cuentaCC = obj.nCrudListarBD("select * from cuenta_contable where id='" & txtCuenta.Text.Trim & "'", CadenaConexion)
        If cuentaCC.Rows.Count > 0 Then
            If Integer.Parse(cuentaCC.Rows(0)("c1").ToString) > 0 Then
                MessageBox.Show("Elija un Centro de Costo para esta cuenta.", "Registros Genéricos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                frmListaCentroCostos.formInicio = "modificargeneral"
                frmListaCentroCostos.ShowDialog()
            End If
        End If
    End Sub
    Private Sub dgvOperaciones_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvOperaciones.SelectionChanged
        On Error Resume Next
        If iCarga = 1 Then
            Dim f As Integer
            f = dgvOperaciones.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            Dim dtCC As New DataTable
            dtCC = obj.nCrudListarBD("select * from centro_costos where id='" & dgvOperaciones.Rows(f).Cells("id_centro").Value.ToString & "'", CadenaConexion)
            If dtCC.Rows.Count > 0 Then
                txtIdCentro.Text = dgvOperaciones.Rows(f).Cells("id_centro").Value.ToString
                txtCentro.Text = dtCC.Rows(0)("descripcion").ToString
            Else
                txtIdCentro.Text = "0"
                txtCentro.Text = "-"
            End If
        End If
    End Sub
    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cboDH.Focus()
        End If
    End Sub
    Private Sub cboDH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboDH.KeyPress
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
        If iCarga = 1 And dgvOperaciones.RowCount > 0 Then
            realizarSumasTotales()
        End If
    End Sub

    Private Sub btnCentro_Click(sender As Object, e As EventArgs) Handles btnCentro.Click
        frmListaCentroCostos.formInicio = "modificargeneral"
        frmListaCentroCostos.Show()
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