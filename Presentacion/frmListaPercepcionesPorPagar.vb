Imports Negocio
Imports Entidades

Public Class frmListaPercepcionesPorPagar
    Dim obj As New nCrud
    Dim iCarga As Integer = 0

    Private Function codigoCeldaSeleccionada() As Integer
        Dim c As String
        Try
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            c = dgvLista.Rows(f).Cells("id").Value.ToString
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function

    Private Sub cargarListaPercepciones()
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from vista_listaDePercepcionesPorPagar order by id asc", CadenaConexion)
        dgvLista.DataSource = data
        If iCarga = 1 Then
            cargarDetalleComprobante()
        End If
    End Sub
    Private Sub frmListaRetenciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLista.RowTemplate.Height = 35
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        cargarListaPercepciones()
        iCarga = 1
        cargarDetalleComprobante()
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub dgvLista_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLista.SelectionChanged
        On Error Resume Next
        cargarDetalleComprobante()
    End Sub

    Private Sub cargarDetalleComprobante()
        If dgvLista.RowCount > 0 Then
            Dim dataCompra As New DataTable
            Dim objCom As New nComprobanteCompra
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid

            dataCompra = objCom.nDataComprobanteCompraPorIdBD(dgvLista.Rows(f).Cells("id_comprobante").Value.ToString, CadenaConexion)
            lblDniRuc.Text = dataCompra.Rows(0)("num_dni")
            lblRazonNombre.Text = dataCompra.Rows(0)("razon_social")
            lblDocumento.Text = dataCompra.Rows(0)("documento")
            lblSerieNumero.Text = dataCompra.Rows(0)("serie") & "-" & dataCompra.Rows(0)("numero")
            LblMoneda.Text = dataCompra.Rows(0)("moneda")
            lblTipoCambio.Text = dataCompra.Rows(0)("tipo_cambio")
            lblDescripcionCompra.Text = dataCompra.Rows(0)("glosa")
            lblFechaEmision.Text = dataCompra.Rows(0)("fec_emision")
            lblMontoCompra.Text = (dataCompra.Rows(0)("total"))
            Dim dtAbono As New DataTable
            dtAbono = obj.nCrudListarBD("select isnull(sum(monto),0) as 'abono' from abono_pagos_compras where id_compra='" & dgvLista.Rows(f).Cells("id_comprobante").Value.ToString & "'", CadenaConexion)
            If Decimal.Parse(dtAbono.Rows(0)("abono").ToString) > 0 Then
                lblDeuda.Text = (dataCompra.Rows(0)("total") - Decimal.Parse(dtAbono.Rows(0)("abono")))
            Else
                lblDeuda.Text = (dataCompra.Rows(0)("total"))
            End If
        End If
    End Sub


End Class