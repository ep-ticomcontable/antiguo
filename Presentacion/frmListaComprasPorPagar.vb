Imports Negocio

Public Class frmListaComprasPorPagar
    Dim obj As New nCrud
    Dim iCarga As Integer = 0

    Private Sub cargarTipo()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(1, "DNI/RUC")
        data.Rows.Add(2, "RAZON SOCIAL")
        With cboTipo
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub

    Private Sub cargarComprobantes()
        Dim data As New DataTable
        data = obj.nCrudListarBD("usp_listarDeudasPorPagar", CadenaConexion)
        dgvLista.DataSource = data
    End Sub


    Private Sub frmListaComprobanteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTipo()
        dtDesde.Value = DateTime.Today.AddMonths("-3")
        cargarComprobantes()
        iCarga = 1
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        realizarConsulta()
    End Sub
    Private Sub realizarConsulta()
        If txtDato.Text.Trim.Length > 0 Then
            Dim data As New DataTable
            Dim query As String
            If cboTipo.SelectedValue = 1 Then
                query = "select * from comprobante_venta where tipo_venta='CREDITO' and num_dni like '%" & txtDato.Text.Trim & "%' and DATEADD(dd, 0, DATEDIFF(dd, 0, fec_emision))>='" & dtDesde.Value().ToString("yyyy-MM-dd") & "' and DATEADD(dd, 0, DATEDIFF(dd, 0, fec_emision))<='" & dtHasta.Value().ToString("yyyy-MM-dd") & "' order by fec_emision asc"
            Else
                query = "select * from comprobante_venta where tipo_venta='CREDITO' and razon_social like '%" & txtDato.Text.Trim & "%' DATEADD(dd, 0, DATEDIFF(dd, 0, fec_emision))>='" & dtDesde.Value().ToString("yyyy-MM-dd") & "' and DATEADD(dd, 0, DATEDIFF(dd, 0, fec_emision))<='" & dtHasta.Value().ToString("yyyy-MM-dd") & "' order by fec_emision asc"
            End If
            'MsgBox(query)
            data = obj.nCrudListarBD(query, CadenaConexion)
            dgvLista.DataSource = data
        Else
            cargarComprobantes()
        End If
    End Sub

    Private Sub btnPagarConLetra_Click(sender As Object, e As EventArgs) Handles btnCanjeLetra.Click
        If iCarga = 1 Then
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            Dim idComprobante As Integer = 0
            idComprobante = dgvLista.Rows(f).Cells(0).Value

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

            Dim data As New DataTable
            data = obj.nCrudListarBD("select  IsNull(sum(monto), 0) as 'abono' from abono_pagos_ventas where id_venta='" & dgvLista.Rows(f).Cells("id").Value & "'", CadenaConexion)
            Dim abono As Decimal = 0
            If data.Rows.Count > 0 Then
                abono = Decimal.Parse(data.Rows(0)("abono").ToString)
            End If
            Dim diferencia As Decimal = 0
            Dim pagado As Decimal = 0
            diferencia = (Decimal.Parse(dgvLista.Rows(f).Cells("total").Value) - abono)
            pagado = abono
            dataComp.Rows.Add(dgvLista.Rows(f).Cells("id").Value, dgvLista.Rows(f).Cells("serie_comprobante").Value, dgvLista.Rows(f).Cells("numero_comprobante").Value, dgvLista.Rows(f).Cells("glosa").Value, dgvLista.Rows(f).Cells("total").Value, pagado, diferencia, diferencia, Date.Parse(dgvLista.Rows(f).Cells("fec_pago").Value).ToString("dd/MM/yyyy"))

            With frmCanjeLetraComprobantes
                .Text = "Canje de Comprobante Compra por Letra"
                .codComprobante = idComprobante
                .dataComprobante = dataComp
                .cargarDatosComprobante()
                .Show()
            End With
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If iCarga = 1 Then
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            Dim idComprobante As Integer = 0
            idComprobante = dgvLista.Rows(f).Cells(0).Value
            With frmNuevaNotaDebitoVenta
                .Text = "Nueva Nota de Débito Venta - N° registro: " & idComprobante
                .codComprobante = idComprobante
                .codTipoComprobante = dgvLista.Rows(f).Cells("id_tipo_comprobante").Value
                .cargarDatosComprobante()
                .Show()
            End With
        End If
    End Sub

    Private Sub btnPagarConLetras_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRealizarAbono_Click(sender As Object, e As EventArgs) Handles btnRealizarAbono.Click
        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        Dim idComprobante As Integer = 0
        idComprobante = dgvLista.Rows(f).Cells(0).Value
        frmAbonoComprobanteCompras.codCompra = idComprobante
        'frmAbonoComprobanteCompras.datoProveedor = dgvLista.Rows(f).Cells("num_dni").Value
        frmAbonoComprobanteCompras.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class