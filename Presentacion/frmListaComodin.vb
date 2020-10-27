Imports Negocio

Public Class frmListaComodin
    Dim objCrud As New nCrud
    Dim iCarga As Integer = 0
    Private Function codigoCeldaSeleccionada() As Integer
        Dim c As String
        Try
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            c = dgvLista.Rows(f).Cells("id_c").Value.ToString
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function
    Public Sub cargarComodines()
        Dim data As New DataTable
        data = objCrud.nCrudListarBD("select * from vista_cabeceraComodin order by fec_reg asc", CadenaConexion)
        dgvLista.DataSource = data
        formatoGrilla()
    End Sub
    Private Sub formatoGrilla()
        For Each row As DataGridViewRow In dgvLista.Rows
            If row.Cells("tipo").Value.ToString.StartsWith("GRABAD") Then
                row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(231, 217, 140)
                row.DefaultCellStyle.ForeColor = Drawing.Color.FromArgb(0, 0, 0)
                'ElseIf row.Cells("tipo").Value.ToString.StartsWith("GRABA") Then
                '    row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(231, 217, 140)
                '    'row.DefaultCellStyle.ForeColor = Drawing.Color.FromArgb(255, 255, 255)
            End If
        Next
    End Sub
    Private Sub frmListaPlanillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLista.RowTemplate.Height = 30
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        dgvOperaciones.RowTemplate.Height = 25
        cebrasDatagrid(dgvOperaciones, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))

        cargarComodines()
        iCarga = 1
        If iCarga = 1 Then
            cargarDetalleComodin()
        End If
    End Sub

    Private Sub dgvLista_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLista.SelectionChanged
        On Error Resume Next
        cargarDetalleComodin()
    End Sub

    Private Sub cargarDetalleComodin()
        If dgvLista.RowCount > 0 Then
            Dim sql As String
            sql = "select * from asientos_comodin where id_comodin='" & codigoCeldaSeleccionada() & "' order by id asc"
            Dim data As New DataTable
            data = objCrud.nCrudListarBD(sql, CadenaConexion)
            'dgvOperaciones.DataSource = data

            'buscar si existen pagos en planillas
            Dim dtAC As New DataTable
            dtAC = objCrud.nCrudListarBD("select * from abono_pagos_comodin where id_comodin='" & codigoCeldaSeleccionada() & "'", CadenaConexion)
            If dtAC.Rows.Count > 0 Then
                Dim dt As New DataTable
                dt = objCrud.nCrudListarBD("select * from asientos_libro_diario where id_comprobante='ABCMD" & dtAC.Rows(0)("id").ToString & "'", CadenaConexion)

                data.Rows.Add("0", "0", "-", dtAC.Rows(0)("glosa").ToString, 0, 0, "0", "0")
                For Each row As DataRow In dt.Rows
                    data.Rows.Add("0", "0", row.Item("cuenta").ToString, obtenerDatosCuenta(row.Item("cuenta").ToString), row.Item("debe").ToString, row.Item("haber").ToString, "0", "0")
                Next

            End If
            dgvOperaciones.DataSource = data





            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            If dgvLista.Rows(f).Cells("tipo").Value.ToString.StartsWith("GRAB") Then
                btnModificar.Enabled = True
            Else
                btnModificar.Enabled = False
            End If

            If dgvLista.Rows(f).Cells("id_comprobante").Value.ToString.StartsWith("0") Then
                btnComprobanteAnexado.Enabled = False
            Else
                btnComprobanteAnexado.Enabled = True
            End If

            realizarSumasTotales()
            If dgvOperaciones.RowCount > 0 Then
                For NumeroFila As Integer = 0 To dgvOperaciones.Rows.Count - 1
                    If dgvOperaciones.Item("cuenta", NumeroFila).Value.ToString = "-" Then
                        dgvOperaciones.Item("id", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)
                        dgvOperaciones.Item("id_comodin", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)
                        dgvOperaciones.Item("cuenta", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)
                        dgvOperaciones.Item("descripcion", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)
                        dgvOperaciones.Item("debe", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)
                        dgvOperaciones.Item("haber", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)
                        dgvOperaciones.Item("id_centro", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)
                        dgvOperaciones.Item("id_caja", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)

                        dgvOperaciones.Item("id", NumeroFila).Style.ForeColor = Drawing.Color.FromArgb(160, 160, 160)
                        dgvOperaciones.Item("id_comodin", NumeroFila).Style.ForeColor = Drawing.Color.FromArgb(160, 160, 160)
                        dgvOperaciones.Item("cuenta", NumeroFila).Style.ForeColor = Drawing.Color.FromArgb(160, 160, 160)
                        dgvOperaciones.Item("descripcion", NumeroFila).Style.Font = New Font(dgvOperaciones.Font, FontStyle.Italic)
                        dgvOperaciones.Item("descripcion", NumeroFila).Style.Font = New Font(dgvOperaciones.Font, FontStyle.Bold)
                        dgvOperaciones.Item("debe", NumeroFila).Style.ForeColor = Drawing.Color.FromArgb(160, 160, 160)
                        dgvOperaciones.Item("haber", NumeroFila).Style.ForeColor = Drawing.Color.FromArgb(160, 160, 160)
                        dgvOperaciones.Item("id_centro", NumeroFila).Style.ForeColor = Drawing.Color.FromArgb(160, 160, 160)
                        dgvOperaciones.Item("id_caja", NumeroFila).Style.ForeColor = Drawing.Color.FromArgb(160, 160, 160)
                    End If
                Next
            End If
        End If
    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        frmIngresosGenericos.ShowDialog()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        cargarComodines()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        'MsgBox(dgvLista.Rows(f).Cells("id").Value.ToString)
        If dgvLista.Rows(f).Cells("tipo").Value.ToString.StartsWith("GRA") Then
            frmModificarIngresosGenericos.idComodin = dgvLista.Rows(f).Cells("id_c").Value.ToString
            frmModificarIngresosGenericos.lblNumero.Text = "N° " & dgvLista.Rows(f).Cells("id_c").Value.ToString
            frmModificarIngresosGenericos.ShowDialog()
        End If
        
    End Sub

    Private Sub realizarSumasTotales()
        Dim tDebe, tHaber, tDiferencia As Decimal
        For Each row As DataGridViewRow In dgvOperaciones.Rows
            tDebe += row.Cells("debe").Value
            tHaber += row.Cells("haber").Value
        Next
        tDiferencia = tDebe - tHaber

        txtTDebeS.Text = Format(tDebe, "#,##0.00")
        txtTHaberS.Text = Format(tHaber, "#,##0.00")
        txtDiferenciaS.Text = Format(tDiferencia, "#,##0.00")
    End Sub

    Private Sub btnComprobanteAnexado_Click(sender As Object, e As EventArgs) Handles btnComprobanteAnexado.Click
        If dgvLista.RowCount > 0 Then
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            'MsgBox(dgvLista.Rows(f).Cells("id").Value.ToString)
            If dgvLista.Rows(f).Cells("tipo_operacion").Value.ToString.StartsWith("COMPRA") Then
                frmListaComprobanteCompras.marcarComprobante(dgvLista.Rows(f).Cells("id_comprobante").Value.ToString)
                frmListaComprobanteCompras.Show()
                frmListaComprobanteCompras.btnDetalle.PerformClick()
            ElseIf dgvLista.Rows(f).Cells("tipo_operacion").Value.ToString.StartsWith("VENTA") Then
                frmListaComprobanteVentas.marcarComprobante(dgvLista.Rows(f).Cells("id_comprobante").Value.ToString)
                frmListaComprobanteVentas.Show()
                frmListaComprobanteVentas.btnDetalle.PerformClick()
            End If
        End If
    End Sub

End Class