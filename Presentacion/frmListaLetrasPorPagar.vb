Imports Negocio

Public Class frmListaLetrasPorPagar
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
        data = obj.nCrudListarBD("select * from vista_listaLetrasCompras order by fec_emision asc", CadenaConexion)
        dgvLista.DataSource = data
        formatoGrillas()
    End Sub
    Public Sub seleccionarCodigoDeVenta(codigo As Integer)
        For i As Integer = 0 To dgvLista.Rows.Count - 1
            For x As Integer = 0 To dgvLista.ColumnCount - 1
                If dgvLista.Rows(i).Cells("id").Value.ToString = codigo Then
                    dgvLista.CurrentCell = dgvLista.Rows(i).Cells("id")

                End If
            Next
        Next
    End Sub
    Private Sub frmListaComprobanteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLista.RowTemplate.Height = 30
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        cargarTipo()
        dtDesde.Value = DateTime.Today.AddMonths("-3")
        cargarComprobantes()
        iCarga = 1
    End Sub
    Private Sub formatoGrillas()
        For Each row As DataGridViewRow In dgvLista.Rows
            If row.Cells("estado_deuda").Value.ToString.StartsWith("DEBE") Then
                row.DefaultCellStyle.ForeColor = Drawing.Color.FromArgb(252, 0, 0)
            End If
        Next
    End Sub
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        cargarComprobantes()
        'realizarConsulta()
    End Sub
    Public Sub realizarConsulta()
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

    Private Sub btnPagarConLetra_Click(sender As Object, e As EventArgs) Handles btnPagarLetra.Click
        If iCarga = 1 Then
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            Dim idComprobante As Integer = 0
            idComprobante = dgvLista.Rows(f).Cells("id").Value

            Dim dataComp As New DataTable
            With dataComp
                .Columns.Add("id")
                .Columns.Add("fecha")
                .Columns.Add("serie")
                .Columns.Add("numero")
                .Columns.Add("librador")
                .Columns.Add("moneda")
                .Columns.Add("total")
                .Columns.Add("pagado")
                .Columns.Add("resta")
                .Columns.Add("abono")
            End With

            Dim diferencia As Decimal = 0
            With dgvLista.Rows(f)
                Dim data As New DataTable
                'MsgBox(.Cells("id_comprobante").Value)
                data = obj.nCrudListarBD("select IsNull(sum(monto), 0)  as 'abono' from abono_pagos_compras where id_letra='" & .Cells("id").Value & "'", CadenaConexion)

                Dim pagado As Decimal = 0
                'If Decimal.Parse(data.Rows(0)("abono").ToString) > 0 Then
                diferencia = (Decimal.Parse(.Cells("total").Value) - Decimal.Parse(data.Rows(0)("abono").ToString))
                pagado = Decimal.Parse(data.Rows(0)("abono").ToString)
                'End If
                Dim dt As New DataTable
                dt = obj.nCrudListarBD("select c.id,m.id,m.codigo as 'moneda' from comprobante_compra c inner join tipo_moneda m on c.id_moneda=m.id where c.id='" & .Cells("id_comprobante").Value & "'", CadenaConexion)
                dataComp.Rows.Add(.Cells("id").Value, Date.Parse(.Cells("fec_vencimiento").Value).ToString("dd/MM/yyyy"), .Cells("serie").Value, .Cells("numero").Value, .Cells("librado").Value, dt.Rows(0)("moneda"), .Cells("total").Value, pagado, diferencia, diferencia)
            End With

            With frmAbonoLetras
                .tipoProceso = "COMPRA"
                .codComprobante = dgvLista.Rows(f).Cells("id_comprobante").Value
                .Show()
                .dataComprobante = dataComp
                .cargarDatosComprobante()
            End With
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgvLista.Rows.Count > 0 Then
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            frmModificarLetraPorPagar.COD_LETRA = dgvLista.Rows(f).Cells("id").Value
            frmModificarLetraPorPagar.codComprobante = dgvLista.Rows(f).Cells("id_comprobante").Value
            frmModificarLetraPorPagar.tipo = "COMPRA"
            frmModificarLetraPorPagar.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        frmListaCajaBancos.Show()
    End Sub

    Private Sub dgvLista_SelectionChanged(sender As Object, e As EventArgs) Handles dgvLista.SelectionChanged
        On Error Resume Next
        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        If dgvLista.Rows(f).Cells("estado_deuda").Value.ToString.StartsWith("DEBE") Then
            btnPagarLetra.Enabled = True
            'BUSCAR SI NO SE HIZO ABONO A LA LETRA
            Dim dt As New DataTable
            dt = obj.nCrudListarBD("select IsNull(sum(monto), 0)  as 'abono' from abono_pagos_compras where id_compra='" & dgvLista.Rows(f).Cells("id_comprobante").Value & "'", CadenaConexion)
            If Decimal.Parse(dt.Rows(0)("abono").ToString) > 0 Then
                btnModificar.Enabled = False
            Else
                btnModificar.Enabled = True
            End If
        Else
            btnModificar.Enabled = False
            btnPagarLetra.Enabled = False
        End If
    End Sub
End Class