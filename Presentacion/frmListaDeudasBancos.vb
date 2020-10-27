Imports Negocio

Public Class frmListaDeudasBancos
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
        data = obj.nCrudListarBD("usp_listarDeudasParaBancos", CadenaConexion)
        dgvLista.DataSource = data
    End Sub

    Private Sub limpiarChecks()
        For Each row As DataGridViewRow In dgvLista.Rows
            row.Cells(0).Value = False
        Next
    End Sub

    Private Sub frmListaComprobanteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTipo()
        dtDesde.Value = DateTime.Today.AddMonths("-3")
        cargarComprobantes()
        limpiarChecks()
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

    Private Sub btnGenerarNota_Click(sender As Object, e As EventArgs) Handles btnGenerarNota.Click
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

            For Each fila As DataGridViewRow In dgvLista.Rows
                With fila
                    If .Cells(0).Value = True Then
                        Dim data As New DataTable
                        data = obj.nCrudListarBD("select sum(monto) as 'abono' from abono_pagos_ventas where id_venta='" & .Cells("id").Value & "'", CadenaConexion)

                        Dim diferencia As Decimal = 0
                        Dim pagado As Decimal = 0
                        If data.Rows(0)("abono").ToString.Length > 0 Then
                            diferencia = (Decimal.Parse(.Cells("total").Value) - Decimal.Parse(data.Rows(0)("abono").ToString))
                            pagado = Decimal.Parse(data.Rows(0)("abono").ToString)
                        End If
                        dataComp.Rows.Add(.Cells("id").Value, .Cells("serie_comprobante").Value, .Cells("numero_comprobante").Value, .Cells("glosa").Value, .Cells("total").Value, pagado, diferencia, diferencia, Date.Parse(.Cells("fec_pago").Value).ToString("dd/MM/yyyy"))
                    End If
                End With
            Next

            With frmAbonoDeudasBanco
                .Text = "Pago de Comprobante - Múltiple"
                .dataComprobante = dataComp
                .cargarDatosComprobante()
                .Show()
            End With
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodos.CheckedChanged
        If chkTodos.Checked = True Then
            For Each row As DataGridViewRow In dgvLista.Rows
                row.Cells(0).Value = True
            Next
        Else
            For Each row As DataGridViewRow In dgvLista.Rows
                row.Cells(0).Value = False
            Next
        End If
    End Sub

End Class