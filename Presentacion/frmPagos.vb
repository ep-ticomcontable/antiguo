Imports Negocio

Public Class frmPagos

    Dim objPC As New nPagosCompras
    Dim iCarga As Integer = 0

    Public Sub cargarComprasPorPagar()
        dgvLista.DataSource = objPC.nListaComprasPorPagarBD(txtDatoProveedor.Text.Trim, "CREDITO", CadenaConexion)
    End Sub

    Private Sub buscarDatosProveedor()
        Dim data As New DataTable
        data = objPC.nBuscarProveedorBD(txtDatoProveedor.Text.Trim, CadenaConexion)
        txtDatoProveedor.Text = data.Rows(0)("num_dni")
        lblDatoProveedor.Text = data.Rows(0)("razon_social")
    End Sub

    Private Sub frmPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDatoProveedor.Focus()
        txtDatoProveedor.Select()
        iCarga = 1
    End Sub

    Private Sub txtDatoProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDatoProveedor.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If iCarga = 1 Then
                With frmEscogerProveedor
                    .datoProveedor = txtDatoProveedor.Text.Trim
                    .ShowDialog()
                End With
            End If

        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        With frmAbonoComprobanteCompras
            .codCompra = dgvLista.Rows(f).Cells("id").Value.ToString
            '.datoProveedor = txtDatoProveedor.Text.Trim
            .ShowDialog()
        End With

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        cargarComprasPorPagar()
    End Sub

    Private Sub btnHistorialPagos_Click(sender As Object, e As EventArgs) Handles btnHistorialPagos.Click
        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        With frmHistorialAbonoPagoCompras
            .codCompra = ""
            .codCompra = dgvLista.Rows(f).Cells("id").Value.ToString
            'MsgBox(.codCompra)
            .moneda = dgvLista.Rows(f).Cells("moneda").Value.ToString
            .total = dgvLista.Rows(f).Cells("total").Value.ToString
            .Show()
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmExcel.Show()
    End Sub
End Class