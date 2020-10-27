Imports Negocio
Imports Entidades

Public Class frmNuevoRegistroApertura
    Dim objCrud As New nCrud
    Dim iCarga As Integer = 0
    Dim dataAsientos As New DataTable
    Public idAsiento As String

    Private Sub realizarSumasTotales()
        Dim tDebe, tHaber, tDiferencia, tDebeD, tHaberD, tDiferenciaD As Decimal
        For Each row As DataGridViewRow In dgvOperaciones.Rows
            tDebe += Decimal.Parse(row.Cells("debe").Value)
            tHaber += Decimal.Parse(row.Cells("haber").Value)
            tDebeD += Decimal.Parse(row.Cells("debe_d").Value)
            tHaberD += Decimal.Parse(row.Cells("haber_d").Value)
        Next
        tDiferencia = tDebe - tHaber
        txtTDebeS.Text = Format(tDebe, "#,##0.00")
        txtTHaberS.Text = Format(tHaber, "#,##0.00")
        txtDiferenciaS.Text = Format(tDiferencia, "#,##0.00")
        tDiferenciaD = tDebeD - tHaberD
        txtTDebeD.Text = Format(tDebeD, "#,##0.00")
        txtTHaberD.Text = Format(tHaberD, "#,##0.00")
        txtDiferenciaD.Text = Format(tDiferenciaD, "#,##0.00")
    End Sub
    Private Sub frmNuevaCompraP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvOperaciones.RowTemplate.Height = 25
        cebrasDatagrid(dgvOperaciones, Drawing.Color.White, Drawing.Color.FromArgb(182, 205, 226))
        iCarga = 1
        realizarSumasTotales()
    End Sub
    Private Sub btnAgregarCuenta_Click(sender As Object, e As EventArgs) Handles btnAgregarCuenta.Click
        agregarCuentaContable()
    End Sub
    Private Sub dgvProductos_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOperaciones.CellValueChanged
        On Error Resume Next
        If iCarga = 1 Then
            realizarSumasTotales()
        End If
    End Sub
    Private Sub agregarCuentaContable()
        frmAgregarCuentasNuevo.formIni = "apertura"
        frmAgregarCuentasNuevo.ShowDialog()
    End Sub
    Public Sub adicionarCuentas(cuenta As String, monto As Decimal, orden As String, glosa As String, mnd As Integer, tc As Decimal)
        Dim dtData As New DataTable
        With dtData.Columns
            .Add("num_cuenta")
            .Add("desc_cuenta")
            .Add("debe")
            .Add("haber")
            .Add("debe_d")
            .Add("haber_d")
            .Add("moneda")
            .Add("tc")
            .Add("glosa")
        End With
        Dim montoD As Decimal = 0

        If mnd <> 151 Then
            montoD = Format(Decimal.Parse(monto / tc), "##0.00")
            If dgvOperaciones.RowCount = 0 Then
                If orden = "D" Then
                    dtData.Rows.Add(cuenta, obtenerDatosCuenta(cuenta), monto, "0.00", montoD, "0.00", mnd, tc, glosa)
                End If
                If orden = "H" Then
                    dtData.Rows.Add(cuenta, obtenerDatosCuenta(cuenta), "0.00", monto, "0.00", montoD, mnd, tc, glosa)
                End If
            Else
                Dim dtI As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
                Dim row As DataRow = dtI.NewRow()
                row.Item(0) = cuenta
                row.Item(1) = obtenerDatosCuenta(cuenta)
                row.Item(2) = IIf(orden = "D", monto, "0.00")
                row.Item(3) = IIf(orden = "H", monto, "0.00")
                row.Item(4) = IIf(orden = "D", montoD, "0.00")
                row.Item(5) = IIf(orden = "H", montoD, "0.00")
                row.Item(6) = mnd
                row.Item(7) = tc
                row.Item(8) = glosa
                dtI.Rows.Add(row)
            End If
        Else
            montoD = Format(Decimal.Parse(monto * tc), "##0.00")
            If dgvOperaciones.RowCount = 0 Then
                If orden = "D" Then
                    dtData.Rows.Add(cuenta, obtenerDatosCuenta(cuenta), montoD, "0.00", monto, "0.00", mnd, tc, glosa)
                End If
                If orden = "H" Then
                    dtData.Rows.Add(cuenta, obtenerDatosCuenta(cuenta), "0.00", montoD, "0.00", monto, mnd, tc, glosa)
                End If
            Else
                Dim dtI As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
                Dim row As DataRow = dtI.NewRow()
                row.Item(0) = cuenta
                row.Item(1) = obtenerDatosCuenta(cuenta)
                row.Item(2) = IIf(orden = "D", montoD, "0.00")
                row.Item(3) = IIf(orden = "H", montoD, "0.00")
                row.Item(4) = IIf(orden = "D", monto, "0.00")
                row.Item(5) = IIf(orden = "H", monto, "0.00")
                row.Item(6) = mnd
                row.Item(7) = tc
                row.Item(8) = glosa
                dtI.Rows.Add(row)
            End If
        End If

        dataAsientos.Merge(dtData)
        dgvOperaciones.DataSource = dataAsientos
        realizarSumasTotales()
    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function
    Private Sub frmNuevaCompraP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        'If e.KeyCode = Keys.Insert Then
        '    If txtRuc.Focused = True Or txtRazonSocial.Focused = True Then
        '        buscarProveedor()
        '    Else
        '        agregarCuentaContable()
        '    End If
        'ElseIf e.KeyCode = Keys.End Then
        '    procesarBoton()
        'End If
    End Sub
    Private Sub txtGlosa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGlosa.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'txtCuenta.Focus()
        End If
    End Sub
    Private Sub dgvOperaciones_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOperaciones.CellValueChanged
        On Error Resume Next
        realizarSumasTotales()
    End Sub

    Private Sub dgvOperaciones_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvOperaciones.RowsRemoved
        On Error Resume Next
        realizarSumasTotales()
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
    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        If verificarPartidaDoble() = True Then
            Me.Enabled = False
            Dim obj As New nAsientoApertura
            idAsiento = obj.nObtenerNumeroDeAsientoAperturaBD(CadenaConexion)
            Dim entiAA As New AAperturaEntity
            With entiAA
                .id = idAsiento
                .id_asiento = idAsiento
                .glosa = txtGlosa.Text.Trim
                .numero = 1
                .total_debe_s = txtTDebeS.Text.Trim
                .total_haber_s = txtTHaberS.Text.Trim
                .diferencia_s = txtDiferenciaS.Text.Trim
                .total_debe_d = txtTDebeD.Text.Trim
                .total_haber_d = txtTHaberD.Text.Trim
                .diferencia_d = txtDiferenciaD.Text.Trim
                .periodo = AnioEjercicio
                .fecha = dtFechaEmision.Value
                .id_empresa = CodigoEmpresaSession
                .id_usuario = CodigoUsuarioSession
                .estado = 1
            End With

            'MsgBox("Asiento de Apertura registrado: " & vbCrLf & obj.nRegistrarAsientoAperturaBD(entiAA, CadenaConexion))
            obj.nRegistrarAsientoAperturaBD(entiAA, CadenaConexion)
            Dim entiDAA As New DetalleAAperturaEntity
            For Each row As DataGridViewRow In dgvOperaciones.Rows
                With entiDAA
                    .id_asiento_apertura = idAsiento
                    .cuenta = row.Cells("num_cuenta").Value.ToString
                    .debe = row.Cells("debe").Value.ToString
                    .haber = row.Cells("haber").Value.ToString
                    .debeD = row.Cells("debe_d").Value.ToString
                    .haberD = row.Cells("haber_d").Value.ToString
                    .id_moneda = row.Cells("moneda").Value.ToString
                    Dim dt As New DataTable
                    dt = objCrud.nCrudListarBD("select * from caja_configuracion where cuenta='" & row.Cells("num_cuenta").Value.ToString & "'", CadenaConexion)

                    If dt.Rows.Count > 0 Then
                        .id_caja = dt.Rows(0)("id").ToString
                    Else
                        .id_caja = "0"
                    End If
                    .tipo_cambio = row.Cells("tc").Value.ToString
                    .glosa = row.Cells("glosa").Value.ToString
                    .id_doc_cont = "1"
                    .num_doc = "-"
                    .fec_emision = dtFechaEmision.Value
                End With
                'MsgBox("Detalle de Asiento de Apertura agregado: " & vbCrLf & obj.nRegistrarDetalleAsientoAperturaBD(entiDAA, CadenaConexion))
                obj.nRegistrarDetalleAsientoAperturaBD(entiDAA, CadenaConexion)
            Next
            MsgBox("¡Asiento de Apertura FINALIZADO correctamente!")
            Me.Enabled = True
            frmListaAperturas.cabeceraApertura()
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Me.Enabled = False
        Dim obj As New nAsientoApertura
        idAsiento = obj.nObtenerNumeroDeAsientoAperturaBD(CadenaConexion)
        Dim entiAA As New AAperturaEntity
        With entiAA
            .id = idAsiento
            .id_asiento = 1
            .glosa = txtGlosa.Text.Trim
            .numero = idAsiento
            .total_debe_s = txtTDebeS.Text.Trim
            .total_haber_s = txtTHaberS.Text.Trim
            .diferencia_s = txtDiferenciaS.Text.Trim
            .total_debe_d = txtTDebeD.Text.Trim
            .total_haber_d = txtTHaberD.Text.Trim
            .diferencia_d = txtDiferenciaD.Text.Trim
            .periodo = AnioEjercicio
            .fecha = dtFechaEmision.Value
            .id_empresa = CodigoEmpresaSession
            .id_usuario = CodigoUsuarioSession
            .estado = 0
        End With

        'MsgBox("Asiento de Apertura registrado: " & vbCrLf & obj.nRegistrarAsientoAperturaBD(entiAA, CadenaConexion))
        obj.nRegistrarAsientoAperturaBD(entiAA, CadenaConexion)
        Dim entiDAA As New DetalleAAperturaEntity
        For Each row As DataGridViewRow In dgvOperaciones.Rows
            With entiDAA
                .id_asiento_apertura = idAsiento
                .cuenta = row.Cells("num_cuenta").Value.ToString
                .debe = row.Cells("debe").Value.ToString
                .haber = row.Cells("haber").Value.ToString
                .debeD = row.Cells("debe_d").Value.ToString
                .haberD = row.Cells("haber_d").Value.ToString
                .id_moneda = row.Cells("moneda").Value.ToString
                .tipo_cambio = row.Cells("tc").Value.ToString
                .glosa = row.Cells("glosa").Value.ToString
                .id_doc_cont = "0"
                .num_doc = "-"
                .fec_emision = dtFechaEmision.Value
            End With
            'MsgBox("Detalle de Asiento de Apertura agregado: " & vbCrLf & obj.nRegistrarDetalleAsientoAperturaBD(entiDAA, CadenaConexion))
            obj.nRegistrarDetalleAsientoAperturaBD(entiDAA, CadenaConexion)
        Next
        MsgBox("¡Asiento de Apertura GUARDADO correctamente!")
        Me.Enabled = True
        frmListaAperturas.cabeceraApertura()
        Me.Dispose()
    End Sub

    Private Sub chkReaperturar_CheckedChanged(sender As Object, e As EventArgs) Handles chkReaperturar.CheckedChanged
        If chkReaperturar.Checked = True Then
            Dim dtData As New DataTable
            dtData = objCrud.nCrudListarBD("select c.id as 'num_cuenta',c.nombre as 'desc_cuenta',t.haber as 'debe',t.debe as 'haber',c.nombre as 'glosa' from temp_asiento_cierre t inner join cuenta_contable c on t.cuenta=c.id where substring(t.cuenta,1,2)<=59 and (t.debe + t.haber)>0 ORDER BY substring(t.cuenta,1,2) asc;", CadenaConexion)
            If dtData.Rows.Count > 0 Then
                dgvOperaciones.DataSource = dtData
            End If
        Else
            Dim dtData As New DataTable
            With dtData.Columns
                .Add("num_cuenta")
                .Add("desc_cuenta")
                .Add("debe")
                .Add("haber")
                .Add("glosa")
            End With
            dgvOperaciones.DataSource = dtData
        End If
        realizarSumasTotales()
    End Sub
End Class