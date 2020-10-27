Imports Negocio
Public Class frmHistorialAbonoPagoCompras

    Public codCompra As String
    Public moneda As String
    Public total As Decimal

    Dim obj As New nAbonosPagos



    Private Sub frmHistorialAbonoPagoCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarAbonos()
    End Sub

    Private Sub cargarAbonos()
        lblDeuda.Text = Format(total, "#,##0.00")
        lblMoneda.Text = moneda

        Dim dataAbono As New DataTable
        dataAbono = obj.nSumaAbonoPagoComprasBD(codCompra, CadenaConexion)
        Dim abono As Decimal = 0
        If dataAbono.Rows.Count > 0 Then
            abono = Decimal.Parse(dataAbono.Rows(0)("abono").ToString)
        Else
            abono = 0
        End If
        lblSaldo.Text = Format((total - abono), "#,##0.00")

        Dim data As New DataTable
        data = obj.nListaAbonosPagoComprasBD(codCompra, CadenaConexion)
        If data.Rows.Count > 0 Then
            panel.Visible = True
            lblVacio.Visible = False
            'dgvLista.DataSource = data
            Dim dataParam As New DataTable
            With dataParam.Columns
                .Add("id")
                .Add("fecha_pago")
                .Add("descripcion_pago")
                .Add("monto_pago")
            End With
            For i As Integer = 0 To data.Rows.Count - 1
                With data
                    'MsgBox(.Rows(i)("id").ToString & vbCrLf & .Rows(i)("fecha_pago").ToString & vbCrLf & .Rows(i)("descripcion_pago").ToString & vbCrLf & .Rows(i)("monto_pago").ToString & vbCrLf)
                    If .Rows(i)("nro_detraccion").ToString.Length > 2 And Decimal.Parse(.Rows(i)("monto_pago").ToString) > 0 Then
                        'MsgBox("DETRACCION: " & .Rows(i)("id").ToString & vbCrLf & .Rows(i)("fecha_pago").ToString & vbCrLf & "N°: " & .Rows(i)("nro_detraccion").ToString & " - F. " & .Rows(i)("fecha_detraccion").ToString & vbCrLf & .Rows(i)("valor_detraccion").ToString & vbCrLf)
                        dataParam.Rows.Add(.Rows(i)("id").ToString, .Rows(i)("fecha_pago").ToString, .Rows(i)("descripcion_pago").ToString, .Rows(i)("monto_pago").ToString)
                        dataParam.Rows.Add(.Rows(i)("id").ToString, .Rows(i)("fecha_pago").ToString, "DET. N°: " & .Rows(i)("nro_detraccion").ToString & " - F. " & Date.Parse(.Rows(i)("fecha_detraccion").ToString).ToString("dd/MM/yyyy"), .Rows(i)("valor_detraccion").ToString)
                    ElseIf Decimal.Parse(.Rows(i)("monto_pago").ToString) > 0 And .Rows(i)("nro_detraccion").ToString.Length < 2 Then
                        dataParam.Rows.Add(.Rows(i)("id").ToString, .Rows(i)("fecha_pago").ToString, .Rows(i)("descripcion_pago").ToString, .Rows(i)("monto_pago").ToString)
                    End If
                End With
                dgvLista.DataSource = dataParam
            Next
        Else
            panel.Visible = False
            lblVacio.Visible = True
        End If

        realizarSumas()
    End Sub

    Private Sub realizarSumas()
        Dim total As Decimal
        For Each row As DataGridViewRow In dgvLista.Rows
            total += row.Cells("monto_pago").Value
        Next
        lblTotalAbono.Text = Format(total, "#,##0.00")
    End Sub
End Class