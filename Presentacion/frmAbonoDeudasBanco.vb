Imports Negocio
Imports Entidades
Public Class frmAbonoDeudasBanco

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
    Dim objCon As New nConciliacion

    Private Sub cargarTipoMovimientos()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add("CH", "Cheque")
        data.Rows.Add("TB", "Transferencia Bancaria")
        data.Rows.Add("DB", "Depósito Bancario")

        With cboTipo
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub

    Private Sub cargarListaBancos()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select * from bancos where estado=1 order by nombre asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboBanco
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de bancos")
        End Try
    End Sub

    Public Sub cargarDatosComprobante()
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from comprobante_venta where id='" & codComprobante & "'", CadenaConexion)
        With data
            dgvComprobante.DataSource = dataComprobante
        End With
        realizarSumasTotales()
    End Sub

    Private Sub frmNuevaNotaCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarListaBancos()
        cargarTipoMovimientos()
        realizarSumasTotales()
    End Sub

    Private Sub realizarSumasTotales()
        Dim tDebe, tHaber, tDiferencia, tTotal As Decimal
        For Each row As DataGridViewRow In dgvComprobante.Rows
            tTotal += row.Cells("total").Value
        Next
        txtTotalComprobante.Text = Decimal.Parse(tTotal)
        'txtTotal.Text = Decimal.Parse(tTotal)
        For Each row As DataGridViewRow In dgvLista.Rows
            tDebe += row.Cells("debe").Value
            tHaber += row.Cells("haber").Value
        Next
        tDiferencia = tDebe - tHaber

        txtTDebeS.Text = Format(tDebe, "#,##0.00")
        txtTHaberS.Text = Format(tHaber, "#,##0.00")
        txtDiferenciaS.Text = Format(tDiferencia, "#,##0.00")
    End Sub

    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtCuenta.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "frmAbonoDeudasBanco"
                    .cuentaInicio = txtCuenta.Text.Trim
                    .ShowDialog()
                End With
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    Dim dtData As New DataTable
        With dtData.Columns
            .Add("id_venta")
            .Add("num_cuenta")
            .Add("desc_cuenta")
            .Add("serie")
            .Add("numero")
            .Add("glosa")
            .Add("debe")
            .Add("haber")
        End With
        For i As Integer = 0 To dgvComprobante.Rows.Count - 1
            dtData.Rows.Add(dgvComprobante.Rows(i).Cells("id").Value.ToString, "1213", "EN COBRANZA", dgvComprobante.Rows(i).Cells("serie").Value.ToString, dgvComprobante.Rows(i).Cells("numero").Value.ToString, dgvComprobante.Rows(i).Cells("glosa").Value.ToString, dgvComprobante.Rows(i).Cells("abono").Value.ToString, "00.00")
            dtData.Rows.Add(dgvComprobante.Rows(i).Cells("id").Value.ToString, txtCuenta.Text.Trim, lblNomCuenta.Text, dgvComprobante.Rows(i).Cells("serie").Value.ToString, dgvComprobante.Rows(i).Cells("numero").Value.ToString, dgvComprobante.Rows(i).Cells("glosa").Value.ToString, "00.00", dgvComprobante.Rows(i).Cells("abono").Value.ToString)
        Next
        dgvLista.DataSource = dtData
        realizarSumasTotales()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim objAbono As New nAbonosPagos
        Dim entiAbono As New AbonoVentasEntity
        Dim entiConciliacion As New ConciliacionEntity

        Dim objLD As New nAsientoLibroDiario
        Dim entiLD As New ALDiarioEntity
        For Each row As DataGridViewRow In dgvLista.Rows
            If Decimal.Parse(row.Cells("debe").Value) > 0 Then
                With entiAbono
                    .tipo_comprobante = "COMPROBANTE"
                    .id_venta = row.Cells("id_venta").Value.ToString
                    .monto = Decimal.Parse(row.Cells("debe").Value)
                    .id_banco = cboBanco.SelectedValue.ToString
                    .tipo = cboTipo.Text
                    .numero = txtNumero.Text.Trim
                    .descripcion = txtGlosa.Text.Trim
                    .fecha = dtPago.Value
                    .estado = "1"
                End With
                MsgBox("ABONO: " & objAbono.nRegistrarAbonoVentas(entiAbono))
                Dim data As New DataTable
                data = obj.nCrudListarBD("select * from abono_pagos_ventas where id_venta='" & row.Cells("id_venta").Value.ToString & "' order by id desc", CadenaConexion)
                With entiConciliacion
                    .id_abono = data.Rows(0)("id").ToString
                    .concepto = txtGlosa.Text.Trim
                    .tipo = cboTipo.SelectedValue.ToString
                    .numero = txtNumero.Text.Trim
                    .monto = Decimal.Parse(row.Cells("debe").Value)
                    .verificador = "false"
                    .fecha = dtPago.Value.ToString()
                    .estado = "1"
                End With
                MsgBox("REGISTRO CONCILIACION: " & objCon.registrarConciliacion(entiConciliacion))
            End If
            With entiLD
                .id_comprobante = row.Cells("id_venta").Value.ToString
                .cuo = "CUO"
                .fecha_operacion = dtPago.Value
                .glosa = "PAGO - " & txtGlosa.Text.Trim
                .cod_libro = row.Cells("num_cuenta").Value.ToString
                .numero_correlativo = "NUM. CORRELATIVO"
                .numero_documento = "NUM. DOC."
                .cuenta = row.Cells("num_cuenta").Value.ToString
                .denominacion = .glosa
                .debe = row.Cells("debe").Value.ToString
                .haber = row.Cells("haber").Value.ToString
            End With
            MsgBox("REGISTRO LIBRO DIARIO: " & objLD.registrarAsientoLibroDiario(entiLD))
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmListaEntradasSalidasBancos.Show()
    End Sub
End Class