Imports Negocio
Imports Entidades

Public Class frmListaNotasDebitoCompra
    Dim obj As New nCrud
    Dim iCarga As Integer = 0
    Public rucCliente As String '= "20447393302"
    Public codComprobante As String = ""
    Public formulario As String = ""

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

    Private Sub cargarNotas()
        Dim data As New DataTable
        If formulario.Length > 3 Then
            If rucCliente <> "" Then
                data = obj.nCrudListarBD("select nc.id,nc.serie,nc.numero,nc.motivo,(cv.serie_comprobante + '-' + cv.numero_comprobante) as 'comprobante',cv.total as 'total_comp',nc.comentario as 'glosa',nc.razon_social as 'cliente',mn.codigo as 'moneda',nc.total,nc.fec_emision as 'fec_reg',CASE When nc.estado>0 THEN 'DISPONIBLE' Else 'COBRADO' End estado  from comprobante_nota_debito nc inner join comprobante_compra cv on cv.id=nc.id_comprobante inner join tipo_moneda mn on cv.id_moneda=mn.id where nc.ruc='" & rucCliente & "' and nc.tipo='COMPRA' and nc.motivo NOT LIKE 'Devoluc%' order by nc.fec_emision desc", CadenaConexion)
            Else
                data = obj.nCrudListarBD("select nc.id,nc.serie,nc.numero,nc.motivo,(cv.serie_comprobante + '-' + cv.numero_comprobante) as 'comprobante',cv.total as 'total_comp',nc.comentario as 'glosa',nc.razon_social as 'cliente',mn.codigo as 'moneda',nc.total,nc.fec_emision as 'fec_reg',CASE When nc.estado>0 THEN 'DISPONIBLE' Else 'COBRADO' End estado  from comprobante_nota_debito nc inner join comprobante_compra cv on cv.id=nc.id_comprobante inner join tipo_moneda mn on cv.id_moneda=mn.id and nc.tipo='COMPRA' and nc.motivo NOT LIKE 'Devoluc%' order by nc.fec_emision desc", CadenaConexion)
            End If
        Else
            If rucCliente <> "" Then
                data = obj.nCrudListarBD("select nc.id,nc.serie,nc.numero,nc.motivo,(cv.serie_comprobante + '-' + cv.numero_comprobante) as 'comprobante',cv.total as 'total_comp',nc.comentario as 'glosa',nc.razon_social as 'cliente',mn.codigo as 'moneda',nc.total,nc.fec_emision as 'fec_reg',CASE When nc.estado>0 THEN 'DISPONIBLE' Else 'COBRADO' End estado  from comprobante_nota_debito nc inner join comprobante_compra cv on cv.id=nc.id_comprobante inner join tipo_moneda mn on cv.id_moneda=mn.id where nc.ruc='" & rucCliente & "' and nc.tipo='COMPRA' order by nc.fec_emision desc", CadenaConexion)
            Else
                data = obj.nCrudListarBD("select nc.id,nc.serie,nc.numero,nc.motivo,(cv.serie_comprobante + '-' + cv.numero_comprobante) as 'comprobante',cv.total as 'total_comp',nc.comentario as 'glosa',nc.razon_social as 'cliente',mn.codigo as 'moneda',nc.total,nc.fec_emision as 'fec_reg',CASE When nc.estado>0 THEN 'DISPONIBLE' Else 'COBRADO' End estado  from comprobante_nota_debito nc inner join comprobante_compra cv on cv.id=nc.id_comprobante inner join tipo_moneda mn on cv.id_moneda=mn.id and nc.tipo='COMPRA' order by nc.fec_emision desc", CadenaConexion)
            End If
        End If
        dgvLista.DataSource = data
        If iCarga = 1 Then
            'cargarDetalleComprobante()
        End If
    End Sub

    Private Sub frmListaRetenciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLista.RowTemplate.Height = 35
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        cargarNotas()
        iCarga = 1
        'cargarDetalleComprobante()
        formatoGrillaVentas()
        If formulario = "compra" Then
            btnSeleccionar.Visible = True
        End If
    End Sub
    Private Sub formatoGrillaVentas()
        For Each row As DataGridViewRow In dgvLista.Rows
            If row.Cells("estado").Value.ToString <> "DISPONIBLE" Then
                row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(245, 230, 108)
            End If
        Next
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub dgvLista_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLista.SelectionChanged
        On Error Resume Next
        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        If dgvLista.Rows(f).Cells("estado").Value.ToString = "DISPONIBLE" Then
            btnSeleccionar.Enabled = True
        Else
            btnSeleccionar.Enabled = False
        End If
    End Sub

    'Private Sub cargarDetalleComprobante()
    '    If dgvLista.RowCount > 0 Then
    '        Dim dataCompra As New DataTable
    '        Dim objCom As New nComprobanteVenta
    '        Dim f As Integer
    '        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid

    '        dataCompra = objCom.nDataComprobanteVentaPorId(dgvLista.Rows(f).Cells("id_comprobante").Value.ToString, CadenaConexion)
    '        lblDniRuc.Text = dataCompra.Rows(0)("num_dni")
    '        lblRazonNombre.Text = dataCompra.Rows(0)("razon_social")
    '        lblDocumento.Text = dataCompra.Rows(0)("documento")
    '        lblSerieNumero.Text = dataCompra.Rows(0)("serie") & "-" & dataCompra.Rows(0)("numero")
    '        LblMoneda.Text = dataCompra.Rows(0)("moneda")
    '        lblTipoCambio.Text = dataCompra.Rows(0)("tipo_cambio")
    '        lblDescripcionCompra.Text = dataCompra.Rows(0)("glosa")
    '        lblFechaEmision.Text = dataCompra.Rows(0)("fec_emision")
    '        lblMontoCompra.Text = (dataCompra.Rows(0)("total"))
    '        Dim dtAbono As New DataTable
    '        dtAbono = obj.nCrudListarBD("select isnull(sum(monto),0) as 'abono' from abono_pagos_ventas where id_venta='" & dgvLista.Rows(f).Cells("id_comprobante").Value.ToString & "'", CadenaConexion)
    '        If Decimal.Parse(dtAbono.Rows(0)("abono").ToString) > 0 Then
    '            ' lblDeuda.Text = (dataCompra.Rows(0)("total") - Decimal.Parse(dtAbono.Rows(0)("abono")))
    '        Else
    '            'lblDeuda.Text = (dataCompra.Rows(0)("total"))
    '        End If
    '    End If
    'End Sub


    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If dgvLista.RowCount > 0 Then
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            frmAbonoComprobanteCompras.txtIdCaja.Text = "1"
            frmAbonoComprobanteCompras.txtIdNC.Text = dgvLista.Rows(f).Cells("id").Value.ToString
            frmAbonoComprobanteCompras.txtDescripcion.Text = "CON NOTA DE DÉBITO N°: " & dgvLista.Rows(f).Cells("serie").Value.ToString & "-" & dgvLista.Rows(f).Cells("numero").Value.ToString
            frmAbonoComprobanteCompras.txtMonto.Text = Decimal.Parse(frmAbonoComprobanteCompras.txtMonto.Text.Trim) - Decimal.Parse(dgvLista.Rows(f).Cells("total").Value.ToString)
            frmAbonoComprobanteCompras.txtENC.Text = dgvLista.Rows(f).Cells("id").Value.ToString
            frmAbonoComprobanteCompras.txtBE.Text = "0"
            frmAbonoComprobanteCompras.btnAgregar.PerformClick()
            Me.Close()
            frmEscogerCaja.Close()
        Else
            MsgBox("NOTA DE CRÉDITO NO VÁLIDA")
        End If

    End Sub
End Class