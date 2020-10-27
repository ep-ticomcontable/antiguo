Imports Negocio
Imports Entidades

Public Class frmAccionPagosCompras
    Public idComprobante As String
    Public idTipoComprobante As String
    Dim obj As New nCrud

    Private Sub btnDetalle_Click(sender As Object, e As EventArgs) Handles btnDetalle.Click
        frmListaAbonosCompras.idComprobante = "0"
        frmListaAbonosCompras.idComprobante = idComprobante
        frmListaAbonosCompras.ShowDialog()
    End Sub

    Private Sub btnPagos_Click(sender As Object, e As EventArgs) Handles btnAbonar.Click
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from comprobante_compra where id='" & idComprobante & "'", CadenaConexion)
        If data.Rows(0)("estado_comprobante").ToString = "F" Then
            frmAbonoComprobanteCompras.codCompra = idComprobante
            frmAbonoComprobanteCompras.Show()
        Else
            MessageBox.Show("Solo se puede realizar ABONO o PAGOS a un comprobante de compra FINALIZADO", "Módulo de Pagos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs)
        frmModificarCompra.idCompra = idComprobante
        frmModificarCompra.Show()
    End Sub

    Private Sub frmAccionesCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from vista_compras_con_abonos where id='" & idComprobante & "'", CadenaConexion)
        With data
            lblComprobante.Text = .Rows(0)("serie").ToString & "-" & .Rows(0)("numero").ToString
            lblTotal.Text = "(" & .Rows(0)("moneda").ToString & ")" & Format(Decimal.Parse(.Rows(0)("total").ToString), "#,##0.00")
            lblFP.Text = Date.Parse(.Rows(0)("fec_pago").ToString).ToString("yyyy-MM-dd")
            lblProv.Text = .Rows(0)("razon_social").ToString
            lblRuc.Text = .Rows(0)("num_dni").ToString
            Dim dt As New DataTable
            dt = obj.nCrudListarBD("select * from retenciones where operacion='COMPRA' and id_comprobante='" & idComprobante & "'", CadenaConexion)

            If .Rows(0)("estado_comprobante").ToString = "P" Or .Rows(0)("estado_comprobante").ToString = "E" Or Decimal.Parse(.Rows(0)("total").ToString) = Decimal.Parse(.Rows(0)("abono").ToString) Then
                btnAbonar.Enabled = False
            Else
                If dt.Rows.Count = 0 Then
                    btnAbonar.Enabled = True
                Else
                    If (Decimal.Parse(.Rows(0)("total").ToString) - Decimal.Parse(.Rows(0)("abono").ToString)) = Decimal.Parse(dt.Rows(0)("monto")) Then
                        btnAbonar.Enabled = False
                    End If
                End If
            End If
            Dim totalImpueso As Decimal = 0
            If data.Rows(0)("sujeto").ToString.StartsWith("RETENC") Then
                If dt.Rows.Count > 0 Then
                    If dt.Rows(0)("tipo").ToString = "CANCELADO" Then
                        btnPagarImpuesto.Enabled = False
                    Else
                        totalImpueso = Decimal.Parse(dt.Rows(0)("monto"))
                        btnPagarImpuesto.Enabled = True
                    End If
                End If
            End If
            lblDeuda.Text = "(" & .Rows(0)("moneda").ToString & ")" & vbCrLf & Format((Decimal.Parse(.Rows(0)("total").ToString) - Decimal.Parse(.Rows(0)("abono").ToString)), "#,##0.00")
        End With
    End Sub

    Private Sub pbCerrar_Click(sender As Object, e As EventArgs) Handles pbCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnPagarImpuesto_Click(sender As Object, e As EventArgs) Handles btnPagarImpuesto.Click
        frmListaRetencionesPorPagar.tipo = "compra"
        frmListaRetencionesPorPagar.COD_COMPROBANTE = idComprobante
        frmListaRetencionesPorPagar.Show()
        frmListaRetencionesPorPagar.cargarPagoDesdeCompra()
        Me.Close()
    End Sub
End Class