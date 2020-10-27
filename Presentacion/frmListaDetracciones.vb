Imports Negocio
Imports Entidades

Public Class frmListaDetracciones
    Dim obj As New nCrud
    Dim objMon As New nMonedas
    Dim iCarga As Integer = 0
    Dim cuentas As New DataTable
    Dim objRet As New nRetenciones
    Public tipo As String
    Public COD_COMPROBANTE As Integer = 0

    Private Function codigoCeldaSeleccionadaCompra() As Integer
        Dim c As String
        Try
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            c = dgvLista.Rows(f).Cells("id_comprobante").Value.ToString
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = obj.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function

    Public Sub cargarListaDetracciones()
        Dim data As New DataTable
        If tipo = "COMPRA" Then
            data = obj.nCrudListarBD("select * from vista_listaDeDetraccionesPorPagar order by id_det asc", CadenaConexion)
            lblTituloForm.Text = "DETRACCIONES POR PAGAR"
            btnPagarDetraccion.Text = "PAGAR DETRACCIÓN"
        Else
            data = obj.nCrudListarBD("select * from vista_listaDeDetraccionesPorCobrar order by id_det asc", CadenaConexion)
            lblTituloForm.Text = "DETRACCIONES POR COBRAR"
            btnPagarDetraccion.Text = "COBRAR DETRACCIÓN"
        End If
        dgvLista.DataSource = data
        formatoGrillaCompras()
    End Sub

    Private Sub frmListaDetracciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLista.RowTemplate.Height = 35
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        cargarListaDetracciones()
        If cuentas.Columns.Count <= 1 Then
            With cuentas.Columns
                .Add("num_cuenta")
                .Add("desc_cuenta")
                .Add("debe")
                .Add("haber")
            End With
        End If
        iCarga = 1
        formatoGrillaCompras()
    End Sub
    Private Sub formatoGrillaCompras()
        For Each row As DataGridViewRow In dgvLista.Rows
            If row.Cells("estado").Value.ToString.StartsWith("CANCELA") Then
                row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(245, 230, 108)
            End If
        Next
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnPagarDetraccion_Click(sender As Object, e As EventArgs) Handles btnPagarDetraccion.Click
        If dgvLista.RowCount > 0 Then
            If tipo = "COMPRA" Then
                With frmAbonoComprobanteCompras
                    .codCompra = codigoCeldaSeleccionadaCompra()
                    .Show()
                End With
            Else
                With frmAbonoComprobanteVentas
                    .bloqueo = True
                    .codVenta = codigoCeldaSeleccionadaCompra()
                    .Show()
                End With
            End If
        End If
    End Sub
    Public Sub seleccionarCodigoDeVenta(codigo As Integer)
        For i As Integer = 0 To dgvLista.Rows.Count - 1
            For x As Integer = 0 To dgvLista.ColumnCount - 1
                If dgvLista.Rows(i).Cells("id_comprobante").Value.ToString = codigo Then
                    dgvLista.CurrentCell = dgvLista.Rows(i).Cells("id_comprobante")
                End If
            Next
        Next
        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        If dgvLista.Rows(f).Cells("estado").Value.ToString = "CANCELADO" Then
            btnPagarDetraccion.Visible = False
        Else
            btnPagarDetraccion.Visible = True
        End If
    End Sub
    Private Sub dgvLista_SelectionChanged(sender As Object, e As EventArgs) Handles dgvLista.SelectionChanged
        If dgvLista.RowCount > 0 Then
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            If dgvLista.Rows(f).Cells("estado").Value.ToString = "CANCELADO" Then
                btnPagarDetraccion.Visible = False
            Else
                btnPagarDetraccion.Visible = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmDepositoDetracciones.Show()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        cargarListaDetracciones()
    End Sub
End Class