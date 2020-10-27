Imports Negocio
Imports Entidades

Public Class frmNuevaNotaDebitoVenta

    Dim obj As New nCrud
    Dim objTDA As New nTipoDocumentoAsiento
    Public codComprobante As Integer = 0
    Public codTipoComprobante As Integer = 0
    Dim objNCD As New nNotaCreditoDebito
    Dim tipoOperacion As Integer = 3 'CONSIGNACIONES

    Public Sub cargarDatosComprobante()
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from comprobante_venta where id='" & codComprobante & "'", CadenaConexion)
        With data
            cboTipoDocumento.SelectedValue = .Rows(0)("id_tipo_comprobante").ToString
            txtSerie.Text = .Rows(0)("serie_comprobante").ToString
            txtNumero.Text = .Rows(0)("numero_comprobante").ToString
            dtFecha.Value = .Rows(0)("fec_emision").ToString
            txtRuc.Text = .Rows(0)("num_dni").ToString
            txtRazon.Text = .Rows(0)("razon_social").ToString
            txtMonto.Text = .Rows(0)("base_imponible").ToString
            txtIgv.Text = .Rows(0)("valor_igv").ToString
            txtTotal.Text = .Rows(0)("total").ToString
        End With

    End Sub

    Private Sub cargarTipoDocumento()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = objTDA.nListarCuentasSegunTipoAsiento(1)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, "(" & row.Item(1).ToString & ") " & row.Item(2).ToString.ToUpper)
            Next
            With cboTipoDocumento
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
                .SelectedValue = codTipoComprobante
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Documentos")
        End Try
    End Sub

    Private Sub cargarMotivos()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select * from motivo_credito_debito where estado=1 order by descripcion asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(1).ToString, row.Item(1).ToString)
            Next
            With cboMotivo
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Documentos")
        End Try
    End Sub

    Private Sub frmNuevaNotaDebitoVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTipoDocumento()
        cargarMotivos()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        frmTsCuentasTipoOperacion.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmAgregarCuentaNotas.formIni = "notadebitoventa"
        frmAgregarCuentaNotas.Show()
    End Sub

    Public Sub agregarCuenta(numcuenta, desccuenta, debe, haber)
        If dgvLista.RowCount = 0 Then
            Dim dtItem As New DataTable
            With dtItem.Columns
                .Add("id")
                .Add("id_asiento_venta")
                .Add("num_cuenta")
                .Add("desc_cuenta")
                .Add("debe")
                .Add("haber")
            End With
            dtItem.Rows.Add("0", codComprobante, _
                            numcuenta, _
                            desccuenta, _
                            debe, _
                            haber)
            dgvLista.DataSource = dtItem
            seleccionarCuentaAdicionada(numcuenta)
        Else

            Dim dt As DataTable = DirectCast(dgvLista.DataSource, DataTable)
            Dim row As DataRow = dt.NewRow()
            row.Item(0) = "0"
            row.Item(1) = codComprobante
            row.Item(2) = numcuenta
            row.Item(3) = desccuenta
            row.Item(4) = debe
            row.Item(5) = haber
            dt.Rows.Add(row)
            seleccionarCuentaAdicionada(numcuenta)
        End If
        realizarSumasTotales()
    End Sub

    Private Sub seleccionarCuentaAdicionada(numcuenta)
        For i As Integer = 0 To dgvLista.Rows.Count - 1
            For x As Integer = 0 To dgvLista.ColumnCount - 1
                If dgvLista.Rows(i).Cells("num_cuenta").Value.ToString = numcuenta Then
                    'dgvDetalle.MultiSelect = False
                    'dgvDetalle.Rows(i).Selected = True
                    'dgvDetalle.Rows(i).Cells("cantidad").Select = True

                    dgvLista.CurrentCell = dgvLista.Rows(i).Cells("num_cuenta")
                    'dgvDetalle.CurrentCell = dgvDetalle.Item("cantidad", i)

                    'dgvDetalle.SelectionMode = DataGridViewSelectionMode.CellSelect
                End If
            Next
        Next
    End Sub
    Private Function verificarPartidaDoble() As Boolean
        Dim rpta As Boolean = False
        Dim sDebe, sHaber As Decimal
        For Each row As DataGridViewRow In dgvLista.Rows
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
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If verificarPartidaDoble() = True Then
            Dim entiNCD As New ComprobanteNotaCreditoDebito
            With entiNCD
                .tipo = "VENTA"
                .numero_cuo = "0"
                .serie = txtSerieN.Text.Trim
                .numero = txtNumeroN.Text.Trim
                .fec_emision = dtFechaEmision.Value
                .serie_ref = txtSerie.Text.Trim
                .numero_ref = txtNumero.Text.Trim
                .num_dni = txtRuc.Text.Trim
                .razon_social = txtRazon.Text.Trim
                .glosa = txtGlosa.Text.Trim
                .monto = txtMonto.Text.Trim
                .valor_igv = txtIgv.Text.Trim
                .total = txtTotal.Text.Trim
                .motivo = cboMotivo.Text
                .comentario = txtComentarios.Text.Trim
                .estado = 1
            End With
            objNCD.registrarNotaDebito(entiNCD)

            Dim idNC As String
            idNC = objNCD.obtenerIdNotaDebito()

            For Each row As DataGridViewRow In dgvLista.Rows
                With entiNCD
                    .id_nota_credito = idNC
                    .glosa = txtComentarios.Text.Trim
                    .cuenta = row.Cells("num_cuenta").Value
                    .debe = row.Cells("debe").Value
                    .haber = row.Cells("haber").Value
                End With
                objNCD.registrarAsientoNotaDebito(entiNCD)
            Next
            MsgBox("LA NOTA DE DEBITO PARA VENTA HA SIDO GUARDADA CON ÉXITO")
            frmListaComprobanteVentas.realizarConsulta()
            Me.Close()
        End If
    End Sub


    Private Sub realizarSumasTotales()
        Dim tDebe, tHaber, tDiferencia As Decimal
        For Each row As DataGridViewRow In dgvLista.Rows
            tDebe += row.Cells("debe").Value
            tHaber += row.Cells("haber").Value
        Next
        tDiferencia = tDebe - tHaber

        txtTDebeS.Text = Format(tDebe, "#,##0.00")
        txtTHaberS.Text = Format(tHaber, "#,##0.00")
        txtDiferenciaS.Text = Format(tDiferencia, "#,##0.00")
    End Sub

    Private Sub btnBuscarComprobante_Click(sender As Object, e As EventArgs) Handles btnBuscarComprobante.Click
        cargarComprobante()
    End Sub

    Private Sub txtNumero_TextChanged(sender As Object, e As EventArgs) Handles txtNumero.TextChanged
        cargarComprobante()
    End Sub

    Private Sub cargarComprobante()
        Dim numero As String = txtNumero.Text.Trim
        Dim serie As String = txtSerie.Text.Trim
        Dim data As New DataTable
        data = objNCD.comprobanteVentaPorSerieNumero(serie, numero)

        If data.Rows.Count > 0 Then
            With data
                cboTipoDocumento.SelectedValue = .Rows(0)("id_tipo_comprobante").ToString
                dtFecha.Value = .Rows(0)("fec_emision").ToString
                txtRuc.Text = .Rows(0)("num_dni").ToString
                txtRazon.Text = .Rows(0)("razon_social").ToString
                txtMonto.Text = .Rows(0)("base_imponible").ToString
                txtIgv.Text = .Rows(0)("valor_igv").ToString
                txtTotal.Text = .Rows(0)("total").ToString
            End With
        Else
            MsgBox("No se han encontrado resultados con el comprobante de compra ingresado...")
        End If

    End Sub

End Class