Imports Negocio
Public Class frmEditarCuentasDeImportacion
    Dim obj As New nCrud
    Dim data As New DataTable
    Public tipo As String = ""
    Dim estado As String = ""
    Dim sujeto As String = ""
    Dim porcentaje As Decimal

    Private Sub cargarCuentas()
        data.Rows.Clear()
        With data
            .Columns.Add("num_cuenta")
            .Columns.Add("desc_cuenta")
            .Columns.Add("debe")
            .Columns.Add("haber")
        End With
        Dim lista As New DataTable
        Dim sql As String = ""
        Dim debe, haber As Decimal

        Dim f As Integer
        If tipo = "VENTA" Then
            f = frmImportarVentas.dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            If frmImportarVentas.chkAT.Checked = True Then
                sql = "select * from plantilla_importacion where proceso='" & tipo & "' and tipo<>'D' order by id asc"
            Else
                sql = "select * from plantilla_importacion where proceso='" & tipo & "' and tipo<>'D' and  tipo<>'T' order by id asc"
            End If
        Else
            f = frmImportarCompras.dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            estado = frmImportarCompras.dgvLista.Rows(f).Cells("estado").Value.ToString.Trim
            sujeto = frmImportarCompras.dgvLista.Rows(f).Cells("sujeto_a").Value.ToString.Trim
            porcentaje = Decimal.Parse(frmImportarCompras.dgvLista.Rows(f).Cells("porcentaje").Value.ToString.Trim)
            'COMPRAS NORMALES
            If sujeto = "-" Then
                sql = "select * from plantilla_importacion where proceso='" & tipo & "' and (tipo='A' or tipo='T' or tipo='P') order by id asc"
                lista = obj.nCrudListarBD(sql, CadenaConexion)

                Dim monto, igv, total As Decimal
                For Each row As DataRow In lista.Rows
                    With frmImportarCompras
                        monto = Format(Decimal.Parse(.dgvLista.Rows(f).Cells("monto").Value), "###0.00")
                        igv = Format(Decimal.Parse(.dgvLista.Rows(f).Cells("igv").Value), "###0.00")
                        total = Format(Decimal.Parse(.dgvLista.Rows(f).Cells("total").Value), "###0.00")

                        If row.Item("tipo").ToString = "A" Then
                            If row.Item("debe").ToString = "X" Then
                                debe = monto
                                haber = "0.00"
                            End If
                            If row.Item("debe").ToString = "X" And row.Item("cuenta").ToString.StartsWith("40") Then
                                debe = igv
                                haber = "0.00"
                            End If
                            If row.Item("haber").ToString = "X" Then
                                debe = "0.00"
                                haber = total
                            End If
                        End If
                        If row.Item("tipo").ToString = "T" Then
                            If row.Item("debe").ToString = "X" Then
                                debe = monto
                                haber = "0.00"
                            End If
                            If row.Item("haber").ToString = "X" Then
                                debe = "0.00"
                                haber = monto
                            End If
                        End If
                        If row.Item("tipo").ToString = "P" Then
                            If row.Item("debe").ToString = "X" Then
                                debe = total
                                haber = "0.00"
                            End If
                            If row.Item("haber").ToString = "X" Then
                                debe = "0.00"
                                haber = total
                            End If
                        End If
                    End With
                    data.Rows.Add(row.Item("cuenta").ToString, obtenerDatosCuenta(row.Item("cuenta").ToString), debe, haber)
                    debe = "0.00"
                    haber = "0.00"
                Next
            ElseIf sujeto = "DETRACCION" Then
                sql = "select * from plantilla_importacion where proceso='" & tipo & "' and (tipo='A' or tipo='AD' or tipo='T' " & IIf(estado = "CONTADO", "or tipo='P' or tipo='PD'", "") & ") order by id asc"
                lista = obj.nCrudListarBD(sql, CadenaConexion)

                Dim monto, igv, totalImpuesto, impuesto, total As Decimal
                For Each row As DataRow In lista.Rows
                    With frmImportarCompras
                        monto = Format(Decimal.Parse(.dgvLista.Rows(f).Cells("monto").Value), "###0.00")
                        igv = Format(Decimal.Parse(.dgvLista.Rows(f).Cells("igv").Value), "###0.00")
                        total = Format(Decimal.Parse(.dgvLista.Rows(f).Cells("total").Value), "###0.00")
                        impuesto = Format((total * Decimal.Parse(.dgvLista.Rows(f).Cells("porcentaje").Value) / 100), "###0.00")
                        totalImpuesto = Format(total - impuesto, "###0.00")

                        If row.Item("tipo").ToString.StartsWith("A") Then
                            If row.Item("debe").ToString = "X" Then
                                debe = monto
                                haber = "0.00"
                            End If
                            If row.Item("debe").ToString = "X" And row.Item("cuenta").ToString.StartsWith("40") Then
                                debe = igv
                                haber = "0.00"
                            End If
                            If row.Item("haber").ToString = "X" And row.Item("cuenta").ToString.Length >= 4 Then
                                debe = "0.00"
                                haber = impuesto
                            End If
                            If row.Item("haber").ToString = "X" And row.Item("cuenta").ToString.Length < 4 Then
                                debe = "0.00"
                                haber = totalImpuesto
                            End If
                        End If
                        If row.Item("tipo").ToString = "T" Then
                            If row.Item("debe").ToString = "X" Then
                                debe = monto
                                haber = "0.00"
                            End If
                            If row.Item("haber").ToString = "X" Then
                                debe = "0.00"
                                haber = monto
                            End If
                        End If
                        If row.Item("tipo").ToString = "P" Then
                            If row.Item("debe").ToString = "X" Then
                                debe = totalImpuesto
                                haber = "0.00"
                            End If
                            If row.Item("haber").ToString = "X" Then
                                debe = "0.00"
                                haber = totalImpuesto
                            End If
                        End If
                        If row.Item("tipo").ToString = "PD" Then
                            If row.Item("debe").ToString = "X" Then
                                debe = impuesto
                                haber = "0.00"
                            End If
                            If row.Item("haber").ToString = "X" Then
                                debe = "0.00"
                                haber = impuesto
                            End If
                        End If
                    End With
                    data.Rows.Add(row.Item("cuenta").ToString, obtenerDatosCuenta(row.Item("cuenta").ToString), debe, haber)
                    debe = "0.00"
                    haber = "0.00"
                Next
            ElseIf sujeto = "RETENCION" Then
                sql = "select * from plantilla_importacion where proceso='" & tipo & "' and (tipo='A' or tipo='AR' or tipo='T' " & IIf(estado = "CONTADO", "or tipo='P' or tipo='PR'", "") & ") order by id asc"
                lista = obj.nCrudListarBD(sql, CadenaConexion)

                Dim monto, igv, totalImpuesto, impuesto, total As Decimal
                For Each row As DataRow In lista.Rows
                    With frmImportarCompras
                        monto = Format(Decimal.Parse(.dgvLista.Rows(f).Cells("monto").Value), "###0.00")
                        igv = Format(Decimal.Parse(.dgvLista.Rows(f).Cells("igv").Value), "###0.00")
                        total = Format(Decimal.Parse(.dgvLista.Rows(f).Cells("total").Value), "###0.00")
                        impuesto = Format((total * Decimal.Parse(.dgvLista.Rows(f).Cells("porcentaje").Value) / 100), "###0.00")
                        totalImpuesto = Format(total - impuesto, "###0.00")

                        If row.Item("tipo").ToString.StartsWith("A") Then
                            If row.Item("debe").ToString = "X" Then
                                debe = monto
                                haber = "0.00"
                            End If
                            If row.Item("debe").ToString = "X" And row.Item("cuenta").ToString.StartsWith("40") Then
                                debe = igv
                                haber = "0.00"
                            End If
                            If row.Item("haber").ToString = "X" And row.Item("cuenta").ToString.StartsWith("40") Then
                                debe = "0.00"
                                haber = impuesto
                            End If
                            If row.Item("haber").ToString = "X" And Not row.Item("cuenta").ToString.StartsWith("40") Then
                                debe = "0.00"
                                haber = totalImpuesto
                            End If
                        End If
                        If row.Item("tipo").ToString = "T" Then
                            If row.Item("debe").ToString = "X" Then
                                debe = monto
                                haber = "0.00"
                            End If
                            If row.Item("haber").ToString = "X" Then
                                debe = "0.00"
                                haber = monto
                            End If
                        End If
                        If row.Item("tipo").ToString = "P" Then
                            If row.Item("debe").ToString = "X" Then
                                debe = totalImpuesto
                                haber = "0.00"
                            End If
                            If row.Item("haber").ToString = "X" Then
                                debe = "0.00"
                                haber = totalImpuesto
                            End If
                        End If
                        If row.Item("tipo").ToString = "PR" Then
                            If row.Item("debe").ToString = "X" Then
                                debe = impuesto
                                haber = "0.00"
                            End If
                            If row.Item("haber").ToString = "X" Then
                                debe = "0.00"
                                haber = impuesto
                            End If
                        End If
                    End With
                    data.Rows.Add(row.Item("cuenta").ToString, obtenerDatosCuenta(row.Item("cuenta").ToString), debe, haber)
                    debe = "0.00"
                    haber = "0.00"
                Next
            ElseIf sujeto = "PERCEPCION" Then
                sql = "select * from plantilla_importacion where proceso='" & tipo & "' and (tipo='A' or tipo='AP' or tipo='T' " & IIf(estado = "CONTADO", "or tipo='P'", "") & ") order by id asc"
                lista = obj.nCrudListarBD(sql, CadenaConexion)

                Dim monto, igv, totalImpuesto, impuesto, total As Decimal
                For Each row As DataRow In lista.Rows
                    With frmImportarCompras
                        monto = Format(Decimal.Parse(.dgvLista.Rows(f).Cells("monto").Value), "###0.00")
                        igv = Format(Decimal.Parse(.dgvLista.Rows(f).Cells("igv").Value), "###0.00")
                        total = Format(Decimal.Parse(.dgvLista.Rows(f).Cells("total").Value), "###0.00")
                        impuesto = Format((total * Decimal.Parse(.dgvLista.Rows(f).Cells("porcentaje").Value) / 100), "###0.00")
                        totalImpuesto = Format(total - impuesto, "###0.00")

                        If row.Item("tipo").ToString.StartsWith("A") Then
                            If row.Item("debe").ToString = "X" Then
                                debe = monto
                                haber = "0.00"
                            End If
                            If row.Item("debe").ToString = "X" And row.Item("cuenta").ToString.StartsWith("40") Then
                                debe = igv
                                haber = "0.00"
                            End If
                            If row.Item("debe").ToString = "X" And row.Item("cuenta").ToString.StartsWith("40113") Then
                                debe = impuesto
                                haber = "0.00"
                            End If
                            If row.Item("haber").ToString = "X" Then
                                debe = "0.00"
                                haber = totalImpuesto
                            End If
                        End If
                        If row.Item("tipo").ToString = "T" Then
                            If row.Item("debe").ToString = "X" Then
                                debe = monto
                                haber = "0.00"
                            End If
                            If row.Item("haber").ToString = "X" Then
                                debe = "0.00"
                                haber = monto
                            End If
                        End If
                        If row.Item("tipo").ToString = "P" Then
                            If row.Item("debe").ToString = "X" Then
                                debe = totalImpuesto
                                haber = "0.00"
                            End If
                            If row.Item("haber").ToString = "X" Then
                                debe = "0.00"
                                haber = totalImpuesto
                            End If
                        End If
                    End With
                    data.Rows.Add(row.Item("cuenta").ToString, obtenerDatosCuenta(row.Item("cuenta").ToString), debe, haber)
                    debe = "0.00"
                    haber = "0.00"
                Next
            End If

        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


        dgvAsientos.DataSource = data
        Dim debe2, haber2 As Decimal
        For Each row As DataGridViewRow In dgvAsientos.Rows
            If row.Cells("num_cuenta").Value.ToString <> "-" Then
                debe2 += Decimal.Parse(row.Cells("debe").Value)
                haber2 += Decimal.Parse(row.Cells("haber").Value)
            End If
        Next
        txtTotalDebe.Text = debe2
        txtTotalHaber.Text = haber2
        txtDiferencia.Text = debe - haber
    End Sub
    ' With frmImportarVentas
    '    If row.Item("tipo").ToString = "A" Then
    '        If row.Item("debe").ToString = "X" Then
    '            debe = .dgvLista.Rows(f).Cells("total").Value
    '            haber = "0.00"
    '        End If
    '        If row.Item("haber").ToString = "X" And row.Item("cuenta").ToString.StartsWith("40") Then
    '            debe = "0.00"
    '            haber = .dgvLista.Rows(f).Cells("igv").Value
    '        End If
    '        If row.Item("haber").ToString = "X" And row.Item("cuenta").ToString.StartsWith("70") Then
    '            debe = "0.00"
    '            haber = .dgvLista.Rows(f).Cells("monto").Value
    '        End If
    '    End If
    '    If row.Item("tipo").ToString = "T" Then
    '        If row.Item("debe").ToString = "X" Then
    '            debe = .dgvLista.Rows(f).Cells("monto").Value
    '            haber = "0.00"
    '        End If
    '        If row.Item("haber").ToString = "X" Then
    '            debe = "0.00"
    '            haber = .dgvLista.Rows(f).Cells("monto").Value
    '        End If
    '    End If
    '    If row.Item("tipo").ToString = "P" Then
    '        If row.Item("debe").ToString = "X" Then
    '            debe = .dgvLista.Rows(f).Cells("total").Value
    '            haber = "0.00"
    '        End If
    '        If row.Item("haber").ToString = "X" Then
    '            debe = "0.00"
    '            haber = .dgvLista.Rows(f).Cells("total").Value
    '        End If
    '    End If
    'End With

    Private Sub frmEditarCuentasDeImportacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvAsientos.RowTemplate.Height = 25
        cebrasDatagrid(dgvAsientos, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))

        cargarCuentas()
    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = obj.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function
End Class