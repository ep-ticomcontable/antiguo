Imports Negocio
Imports Entidades

Public Class frmAccionesVentas
    Public idComprobante As String
    Public idTipoComprobante As String
    Public montoAbono As String
    Dim obj As New nCrud

    Private Sub btnDetalle_Click(sender As Object, e As EventArgs) Handles btnDetalle.Click
        frmDetalleVenta.idVenta = idComprobante
        frmDetalleVenta.Show()
    End Sub

    Private Sub btnPagos_Click(sender As Object, e As EventArgs) Handles btnPagos.Click
        frmAccionPagosCompras.idComprobante = "0"
        frmAccionPagosCompras.idComprobante = idComprobante
        frmAccionPagosCompras.ShowDialog()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        frmModificarCompra.idCompra = idComprobante
        frmModificarCompra.Show()
    End Sub

    Private Sub frmAccionesCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from comprobante_compra where id='" & idComprobante & "'", CadenaConexion)
        With data
            lblComprobante.Text = .Rows(0)("serie_comprobante").ToString & "-" & .Rows(0)("numero_comprobante").ToString
            If .Rows(0)("estado_comprobante").ToString = "E" Then
                btnPagos.Enabled = False
                btnCredito.Enabled = False
                btnDebito.Enabled = False
                btnEliminar.Enabled = False
                btnModificar.Enabled = False
            ElseIf .Rows(0)("estado_comprobante").ToString = "P" Then
                btnPagos.Enabled = False
                btnCredito.Enabled = False

                btnDebito.Enabled = False
                btnEliminar.Enabled = True
                btnModificar.Enabled = True
            Else
                If Decimal.Parse(montoAbono) = 0 Then
                    btnEliminar.Enabled = True
                ElseIf Decimal.Parse(montoAbono) > 0 Then
                    btnEliminar.Enabled = False
                End If
                btnPagos.Enabled = True
                btnCredito.Enabled = True
                btnDebito.Enabled = True
                btnModificar.Enabled = False
            End If
        End With
    End Sub

    Private Sub btnDebito_Click(sender As Object, e As EventArgs) Handles btnDebito.Click
        With frmNuevaNotaDebito
            .Text = "Nueva Nota de Débito Compra - N° registro: " & idComprobante
            .codComprobante = idComprobante
            .codTipoComprobante = idTipoComprobante
            .cargarDatosComprobante()
            .Show()
        End With
    End Sub

    Private Sub btnCredito_Click(sender As Object, e As EventArgs) Handles btnCredito.Click
        With frmNuevaNotaCredito
            .Text = "Nueva Nota de Crédito - COMPRA- N° registro: " & idComprobante
            .codComprobante = idComprobante
            .codTipoComprobante = idTipoComprobante
            .cargarDatosComprobante()
            .Show()
        End With
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim dtComp As New DataTable
        dtComp = obj.nCrudListarBD("select * from comprobante_compra where id='" & idComprobante & "'", CadenaConexion)

        If dtComp.Rows(0)("estado_comprobante") <> "E" Then
            If MessageBox.Show("Está apunto de ANULAR/ELIMINAR el comprobante seleccionado." & vbCrLf & "¿Desea realizar este proceso?", "Estado del comprobante de compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Dim data As New DataTable
                data = obj.nCrudListarBD("select * from asientos_comprobante_compra where id_comprobante_compra='" & idComprobante & "'", CadenaConexion)
                Dim objCC As New nComprobanteCompra
                Dim entiCCompraAsiento As New ComprobanteCompraEntity
                With entiCCompraAsiento
                    .id_comprobante = idComprobante
                    .numero_cuo = objCC.nObtenerCUO_CompraBD(CadenaConexion)
                    .tipo_compra = "CONTADO"
                    .numero_maquina = "-"
                    .id_tipo_comprobante = data.Rows(0)("id_tipo_comprobante").ToString
                    .fec_emision = Date.Parse(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))
                    .fec_pago = Date.Parse(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))
                    .serie_comprobante = data.Rows(0)("serie_comprobante").ToString
                    .numero_comprobante = data.Rows(0)("numero_comprobante").ToString
                    .cod_dni = "6"
                    .num_dni = data.Rows(0)("num_dni").ToString
                    .razon_social = data.Rows(0)("razon_social").ToString
                    .valor_facturado = data.Rows(0)("valor_facturado").ToString
                    .base_imponible = data.Rows(0)("base_imponible").ToString
                    .valor_exonerado = 0
                    .valor_inafecto = 0
                    .valor_isc = 0
                    .valor_igv = data.Rows(0)("valor_igv").ToString
                    .otros_base_imponible = 0
                    .total = data.Rows(0)("total").ToString
                    .tipo_cambio = data.Rows(0)("tipo_cambio").ToString
                    .serie_comp_origen = data.Rows(0)("serie_comp_origen").ToString
                    .numero_comp_origen = data.Rows(0)("numero_comp_origen").ToString
                    .fec_comp_origen = data.Rows(0)("fec_comp_origen").ToString
                    .serie_dua = "0"
                    .numero_dua = "0"
                    .anio_dua = data.Rows(0)("anio_dua").ToString
                    .numero_detraccion = data.Rows(0)("numero_detraccion").ToString
                    .tipo_tasa_detraccion = "0"
                    .tasa_detraccion = data.Rows(0)("tasa_detraccion").ToString
                    .valor_detraccion = data.Rows(0)("valor_detraccion").ToString
                    .fecha_detraccion = data.Rows(0)("fecha_detraccion").ToString
                    .estado = 1
                End With

                For Each row As DataRow In data.Rows
                    With row
                        entiCCompraAsiento.tip_comp_origen = "-"
                        entiCCompraAsiento.cuenta = .Item("cuenta").ToString
                        entiCCompraAsiento.glosa = "ANULACION DEL COMPROBANTE DE COMPRA"
                        entiCCompraAsiento.debe = .Item("haber").ToString
                        entiCCompraAsiento.haber = .Item("debe").ToString
                        entiCCompraAsiento.impuesto = .Item("impuesto").ToString
                        entiCCompraAsiento.serie = .Item("serie").ToString
                        entiCCompraAsiento.numero = .Item("numero").ToString
                        entiCCompraAsiento.operacion = .Item("operacion").ToString
                        Dim rptaRACC As String = objCC.nRegistrarAsientoComprobanteCompraBD(entiCCompraAsiento, CadenaConexion)
                        If rptaRACC <> "ok" Then
                            MsgBox("Error en el registro en el asiento del comprobante: " & rptaRACC)
                        End If
                    End With
                Next
                'CAMBIO DE ESTADO DE COMPROBANTE DE COMPRA
                MsgBox("ACTUALIZACION DE COMPROBANTE: " & obj.nCrudActualizarBD("@", "comprobante_compra", "estado_comprobante", "E", "id='" & idComprobante & "'", CadenaConexion))
                frmListaComprobanteCompras.realizarConsulta()
            End If
        Else
            MessageBox.Show("No se puede ANULAR/ELIMINAR un comprobante ya anulado.", "Estado del comprobante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub btnCanje_Click(sender As Object, e As EventArgs) Handles btnCanje.Click
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
        Dim dtComp As New DataTable
        dtComp = obj.nCrudListarBD("select * from comprobante_compra where id='" & idComprobante & "'", CadenaConexion)

        Dim data As New DataTable
        data = obj.nCrudListarBD("select  IsNull(sum(monto), 0) as 'abono' from abono_pagos_compras where id_compra='" & idComprobante & "'", CadenaConexion)
        Dim abono As Decimal = 0
        If data.Rows.Count > 0 Then
            abono = Decimal.Parse(data.Rows(0)("abono").ToString)
        End If
        Dim diferencia As Decimal = 0
        Dim pagado As Decimal = 0
        diferencia = (Decimal.Parse(dtComp.Rows(0)("total").ToString) - abono)
        pagado = abono
        dataComp.Rows.Add(idComprobante, dtComp.Rows(0)("serie_comprobante").ToString, dtComp.Rows(0)("numero_comprobante").ToString, dtComp.Rows(0)("glosa").ToString, dtComp.Rows(0)("total").ToString, pagado, diferencia, diferencia, Date.Parse(dtComp.Rows(0)("fec_pago").ToString).ToString("dd/MM/yyyy"))

        With frmCanjeLetraComprobantes
            .Text = "Canje de Comprobante Compra por Letra"
            .codComprobante = idComprobante
            .dataComprobante = dataComp
            .cargarDatosComprobante()
            .Show()
        End With
    End Sub
End Class