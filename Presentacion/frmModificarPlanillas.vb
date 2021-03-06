﻿Imports Negocio
Imports Entidades

Public Class frmModificarPlanillas
    Dim objCrud As New nCrud
    Dim iCarga As Integer = 0
    Dim objPla As New nPlanillas
    Public codPlanilla As String

    Private Sub cargarPeriodos()
        Dim data As New DataTable
        With data.Columns
            .Add("valor")
            .Add("descripcion")
        End With
        data.Rows.Add("1", "ENERO")
        data.Rows.Add("2", "FEBRERO")
        data.Rows.Add("3", "MARZO")
        data.Rows.Add("4", "ABRIL")
        data.Rows.Add("5", "MAYO")
        data.Rows.Add("6", "JUNIO")
        data.Rows.Add("7", "JULIO")
        data.Rows.Add("8", "AGOSTO")
        data.Rows.Add("9", "SEPTIEMBRE")
        data.Rows.Add("10", "OCTUBRE")
        data.Rows.Add("11", "NOVIEMBRE")
        data.Rows.Add("12", "DICIEMBRE")
        With cboPeriodo
            .DataSource = data
            .ValueMember = "valor"
            .DisplayMember = "descripcion"
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
    Public Sub habilitarCentroCostoCompra()
        Dim cuentaCC As New DataTable
        cuentaCC = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & txtCuenta.Text.Trim & "'", CadenaConexion)
        If cuentaCC.Rows.Count > 0 Then
            If Integer.Parse(cuentaCC.Rows(0)("c1").ToString) > 0 Then
                'btnCentro.Enabled = True
                'txtCentro.Enabled = True
                MessageBox.Show("Elija un Centro de Costo para esta cuenta.", "Registro de Planillas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                frmListaCentroCostos.formInicio = "editPlanilla"
                frmListaCentroCostos.ShowDialog()
            Else
                'btnCentro.Enabled = False
                'txtCentro.Enabled = False
            End If
        End If
    End Sub
    Private Sub cargarDatosPlanilla()
        Dim data As New DataTable
        data = objCrud.nCrudListarBD("select * from planillas where id='" & codPlanilla & "'", CadenaConexion)
        With data
            txtNumPlanilla.Text = .Rows(0)("id").ToString
            txtGlosaPlanilla.Text = .Rows(0)("glosa").ToString
            cboPeriodo.Text = .Rows(0)("periodo").ToString
            cboMoneda.SelectedValue = .Rows(0)("id_moneda").ToString
            txtTotal.Text = .Rows(0)("total").ToString
            dtFecha.Value = .Rows(0)("fec_emision").ToString
        End With
        Dim data2 As New DataTable
        data2 = objCrud.nCrudListarBD("select * from vista_modificacionPlanilla where id_planilla='" & codPlanilla & "' order by id asc", CadenaConexion)
        dgvOperaciones.DataSource = data2
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

    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cargarCuentaContable()
            habilitarCentroCostoCompra()
            txtMonto.Focus()
        End If
    End Sub
    Private Sub cargarCuentaContable()
        If txtCuenta.Text.Trim.Length >= 2 Then
            With frmEscogerPlanContable
                .formInicio = "frmModificarPlanillas"
                .cuentaInicio = txtCuenta.Text.Trim
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub frmModificarPlanillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvOperaciones.RowTemplate.Height = 30
        cebrasDatagrid(dgvOperaciones, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        cargarDatosPlanilla()
        cargarPeriodos()
        cargarMonedas()
        movimientoDH()
        realizarSumasTotales()
        iCarga = 1
        txtGlosaPlanilla.Focus()
        txtGlosaPlanilla.Select()

    End Sub

    Private Sub realizarSumasTotales()
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


    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim dato, dato2 As String
        dato = objPla.actualizarCabeceraPlanillaBD(txtNumPlanilla.Text.Trim, txtGlosaPlanilla.Text.Trim, cboPeriodo.Text.ToString, cboMoneda.SelectedValue.ToString, Decimal.Parse(txtTotal.Text.Trim), Date.Parse(dtFecha.Value), "GRABADO", "1", CadenaConexion)
        'MsgBox("REGISTRO PLANILLA: " & dato)
        If dato = "ok" Then
            Dim data As New DataTable
            data = objCrud.nCrudListarBD("select * from planillas where id='" & txtNumPlanilla.Text.Trim & "'", CadenaConexion)

            'Borrar registro de cuentas de planilla
            objCrud.nEjecutarQueryBD("delete from detalle_planilla where id_planilla='" & txtNumPlanilla.Text.Trim & "'", CadenaConexion)
            'REGISTRO DETALLE PLANILLAS
            Dim campos, valores As String
            campos = "id_planilla@cuenta@debe@haber@glosa@id_centro"

            Dim eLD As New ALDiarioEntity
            Dim objLD As New nAsientoLibroDiario
            For Each row As DataGridViewRow In dgvOperaciones.Rows
                valores = txtNumPlanilla.Text.Trim & "@" & row.Cells("num_cuenta").Value & "@" & row.Cells("debe").Value & "@" & row.Cells("haber").Value & "@" & row.Cells("glosa").Value & "@" & row.Cells("id_centro").Value
                dato2 = objCrud.nCrudInsertarBD("@", "detalle_planilla", campos, valores, CadenaConexion)
            Next
            MsgBox("Registro de Asientos para la Planilla GRABADO con éxito")
            frmListaPlanillas.cargarPlanillas()
            Me.Dispose()
            'limpiarEntradas()
        End If
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        If dgvOperaciones.RowCount > 0 And Decimal.Parse(txtDiferenciaS.Text.Trim) <> 0 Or Decimal.Parse(txtTDebeS.Text.Trim) = 0 Then
            MsgBox("No hay partida doble en la operación, verifique los montos para poder finalizar.")
        Else
            Dim dato, dato2 As String
            dato = objPla.actualizarCabeceraPlanillaBD(txtNumPlanilla.Text.Trim, txtGlosaPlanilla.Text.Trim, cboPeriodo.Text.ToString, cboMoneda.SelectedValue.ToString, txtTDebeS.Text.Trim, Date.Parse(dtFecha.Value), "FINALIZADO", "1", CadenaConexion)
            'MsgBox("REGISTRO PLANILLA: " & dato)
            If dato = "ok" Then
                Dim data As New DataTable
                data = objCrud.nCrudListarBD("select * from planillas where id='" & txtNumPlanilla.Text.Trim & "'", CadenaConexion)

                'Borrar registro de cuentas de planilla
                objCrud.nEjecutarQueryBD("delete from detalle_planilla where id_planilla='" & txtNumPlanilla.Text.Trim & "'", CadenaConexion)

                'REGISTRO DETALLE PLANILLAS
                Dim campos, valores As String
                campos = "id_planilla@cuenta@debe@haber@glosa@id_centro"

                Dim eLD As New ALDiarioEntity
                Dim objLD As New nAsientoLibroDiario
                For Each row As DataGridViewRow In dgvOperaciones.Rows
                    valores = txtNumPlanilla.Text.Trim & "@" & row.Cells("num_cuenta").Value & "@" & row.Cells("debe").Value & "@" & row.Cells("haber").Value & "@" & row.Cells("glosa").Value & "@" & row.Cells("id_centro").Value
                    dato2 = objCrud.nCrudInsertarBD("@", "detalle_planilla", campos, valores, CadenaConexion)
                    'MsgBox("REGISTRO DETALLE PLANILLA: " & dato2)
                    With eLD
                        .id_comprobante = "PL" & txtNumPlanilla.Text.Trim
                        .cuo = "0"
                        .fecha_operacion = Date.Parse(dtFecha.Value)
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
                For Each row As DataGridViewRow In dgvOperaciones.Rows
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
                                    calculo = (Decimal.Parse(row.Cells("debe").Value) + Decimal.Parse(row.Cells("haber").Value)) * Decimal.Parse(dtCC.Rows(i)("porcentaje").ToString) / 100
                                    campos = "id_planilla@cuenta@debe@haber@glosa@id_centro"
                                    'valores = txtNumPlanilla.Text.Trim & "@" & row.Cells("num_cuenta").Value & "@" & row.Cells("debe").Value & "@" & row.Cells("haber").Value & "@" & txtGlosaPlanilla.Text.Trim & "@" & row.Cells("id_centro").Value
                                    valores = txtNumPlanilla.Text.Trim & "@" & dtCC.Rows(i)("cuenta").ToString & "@" & IIf(dtCC.Rows(i)("debe").ToString = "X", calculo, "0.00") & "@" & IIf(dtCC.Rows(i)("haber").ToString = "X", calculo, "0.00") & "@" & txtGlosaPlanilla.Text.Trim & "@" & row.Cells("id_centro").Value
                                    Dim rptaCmdA As String = ""
                                    rptaCmdA = objCrud.nCrudInsertarBD("@", "detalle_planilla", campos, valores, CadenaConexion)
                                    If rptaCmdA <> "ok" Then
                                        MsgBox("Error al registrar Asiento Planilla: " & rptaCmdA)
                                    Else
                                        With entidad
                                            .id_comprobante = "PL" & txtNumPlanilla.Text.Trim
                                            .cuo = "0"
                                            .fecha_operacion = Date.Parse(dtFecha.Value)
                                            .glosa = txtGlosaPlanilla.Text.Trim
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
                frmListaPlanillas.cargarPlanillas()
                Me.Dispose()
            End If
        End If
        
    End Sub

    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        frmPagoPlanilla.tipo = "modificar"
        frmPagoPlanilla.Show()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim dt As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
        Dim row As DataRow = dt.NewRow()
        row.Item(0) = txtCuenta.Text.Trim
        row.Item(1) = lblCuenta.Text
        row.Item(2) = IIf(cboDH.SelectedValue.ToString = "D", txtMonto.Text, "0.00")
        row.Item(3) = IIf(cboDH.SelectedValue.ToString = "H", txtMonto.Text, "0.00")
        row.Item(4) = txtGlosaPlanilla.Text.Trim
        row.Item(5) = txtIdCentro.Text.Trim
        dt.Rows.Add(row)

        'cboPeriodo.SelectedValue = 0
        txtCuenta.Text = ""
        lblCuenta.Text = "[Nombre Cuenta]"
        txtMonto.Text = "0.00"
        txtCuenta.Text = ""
        realizarSumasTotales()
        txtIdCentro.Text = "0"
        txtCentro.Text = "-"
    End Sub

    Private Sub btnCentro_Click(sender As Object, e As EventArgs) Handles btnCentro.Click
        frmListaCentroCostos.formInicio = "editPlanilla"
        frmListaCentroCostos.Show()
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
    Private Sub dgvOperaciones_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvOperaciones.SelectionChanged
        On Error Resume Next
        Dim f As Integer
        f = dgvOperaciones.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        Dim dtCC As New DataTable
        dtCC = objCrud.nCrudListarBD("select * from centro_costos where id='" & dgvOperaciones.Rows(f).Cells("id_centro").Value.ToString & "'", CadenaConexion)
        If dtCC.Rows.Count > 0 Then
            txtIdCentro.Text = dgvOperaciones.Rows(f).Cells("id_centro").Value.ToString
            txtCentro.Text = dtCC.Rows(0)("descripcion").ToString
        Else
            txtIdCentro.Text = "0"
            txtCentro.Text = "-"
        End If
    End Sub

    Private Sub txtMonto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.Leave
        txtMonto.Text = Format(CType(txtMonto.Text, Decimal), "###0.00")
    End Sub

    Private Sub txtTotal_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal.Leave
        txtTotal.Text = txtTotal.Text.ToString.PadLeft(4, "0")
    End Sub
End Class