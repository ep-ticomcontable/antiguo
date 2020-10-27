Imports Negocio

Public Class frmListaPlanillas
    Dim objCrud As New nCrud
    Dim iCarga As Integer = 0
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
    Public Sub cargarPlanillas()
        Dim data As New DataTable
        data = objCrud.nCrudListarBD("select * from vista_cabeceraPlanillas order by fec_emision asc", CadenaConexion)
        dgvLista.DataSource = data
        formatoGrilla()
    End Sub
    Private Sub formatoGrilla()
        For Each row As DataGridViewRow In dgvLista.Rows
            If row.Cells("tipo_estado").Value.ToString.StartsWith("PAGA") Then
                row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(113, 192, 61)
                row.DefaultCellStyle.ForeColor = Drawing.Color.FromArgb(0, 0, 0)
            ElseIf row.Cells("tipo_estado").Value.ToString.StartsWith("GRABA") Then
                row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(231, 217, 140)
                'row.DefaultCellStyle.ForeColor = Drawing.Color.FromArgb(255, 255, 255)
            End If
        Next
    End Sub
    Private Sub frmListaPlanillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLista.RowTemplate.Height = 30
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        dgvOperaciones.RowTemplate.Height = 25
        cebrasDatagrid(dgvOperaciones, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))

        cargarPlanillas()
        iCarga = 1
        If iCarga = 1 Then
            cargarDetallePlanilla()
        End If
    End Sub
    Private Sub frmListaPlanillas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F3 Then
            cargarPlanillas()
        ElseIf e.KeyCode = Keys.Insert Then
            btnRegistrar.PerformClick()
        End If
    End Sub
    Private Sub dgvLista_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLista.SelectionChanged
        On Error Resume Next
        cargarDetallePlanilla()
    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function
    Private Sub cargarDetallePlanilla()
        If dgvLista.RowCount > 0 Then
            Dim sql As String
            sql = "select * from vista_detallePlanilla where id_pla='" & codigoCeldaSeleccionada() & "' order by id_dp asc"
            Dim data As New DataTable
            data = objCrud.nCrudListarBD(sql, CadenaConexion)

            'buscar si existen pagos en planillas
            Dim dt As New DataTable
            dt = objCrud.nCrudListarBD("select * from asientos_libro_diario where id_comprobante='ABPLA" & codigoCeldaSeleccionada() & "'", CadenaConexion)
            If dt.Rows.Count > 0 Then
                data.Rows.Add("0", "0", "-", "ASIENTOS DE PAGOS", 0, 0, "-")
                For Each row As DataRow In dt.Rows
                    data.Rows.Add(row.Item("id").ToString, codigoCeldaSeleccionada, row.Item("cuenta").ToString, obtenerDatosCuenta(row.Item("cuenta").ToString), row.Item("debe").ToString, row.Item("haber").ToString, row.Item("glosa").ToString)
                Next

            End If
            dgvOperaciones.DataSource = data

            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            If dgvLista.Rows(f).Cells("tipo_estado").Value.ToString.StartsWith("GRAB") Then
                btnModificar.Enabled = True
            Else
                btnModificar.Enabled = False
            End If

            If dgvLista.Rows(f).Cells("tipo_estado").Value.ToString.StartsWith("FINAL") Then
                btnPagar.Enabled = True
            Else
                btnPagar.Enabled = False
            End If

            realizarSumasTotales()
            If dgvOperaciones.RowCount > 0 Then
                For NumeroFila As Integer = 0 To dgvOperaciones.Rows.Count - 1
                    If dgvOperaciones.Item("num_cuenta", NumeroFila).Value.ToString = "-" Then
                        dgvOperaciones.Item("id_dp", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)
                        dgvOperaciones.Item("id_pla", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)
                        dgvOperaciones.Item("num_cuenta", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)
                        dgvOperaciones.Item("desc_cuenta", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)
                        dgvOperaciones.Item("debe", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)
                        dgvOperaciones.Item("haber", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)
                        dgvOperaciones.Item("glosaD", NumeroFila).Style.BackColor = Drawing.Color.FromArgb(160, 160, 160)

                        dgvOperaciones.Item("id_dp", NumeroFila).Style.ForeColor = Drawing.Color.FromArgb(160, 160, 160)
                        dgvOperaciones.Item("id_pla", NumeroFila).Style.ForeColor = Drawing.Color.FromArgb(160, 160, 160)
                        dgvOperaciones.Item("num_cuenta", NumeroFila).Style.ForeColor = Drawing.Color.FromArgb(160, 160, 160)
                        dgvOperaciones.Item("desc_cuenta", NumeroFila).Style.Font = New Font(dgvOperaciones.Font, FontStyle.Italic)
                        dgvOperaciones.Item("desc_cuenta", NumeroFila).Style.Font = New Font(dgvOperaciones.Font, FontStyle.Bold)
                        dgvOperaciones.Item("debe", NumeroFila).Style.ForeColor = Drawing.Color.FromArgb(160, 160, 160)
                        dgvOperaciones.Item("haber", NumeroFila).Style.ForeColor = Drawing.Color.FromArgb(160, 160, 160)
                        dgvOperaciones.Item("glosaD", NumeroFila).Style.ForeColor = Drawing.Color.FromArgb(160, 160, 160)
                    End If
                Next
            End If


        End If
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        frmPlanillas.Show()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        cargarPlanillas()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgvLista.RowCount > 0 Then
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            'MsgBox(dgvLista.Rows(f).Cells("id").Value.ToString)

            frmModificarPlanillas.codPlanilla = dgvLista.Rows(f).Cells("id").Value.ToString
            frmModificarPlanillas.Show()
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

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        If dgvLista.RowCount > 0 Then
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            'MsgBox(dgvLista.Rows(f).Cells("id").Value.ToString)
            If dgvLista.Rows(f).Cells("tipo_estado").Value.ToString = "FINALIZADO" Then
                frmPagoPlanilla.COD_PLANILLA = dgvLista.Rows(f).Cells("id").Value.ToString
                frmPagoPlanilla.tipo = "nuevo"
                frmPagoPlanilla.Show()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        generarExcel()
    End Sub

    Private Sub generarExcel()
        Me.Enabled = False
        Try
            Dim tbDatos As New DataTable

            If dgvLista.Rows.Count > 0 Then
                Dim f As Integer
                f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
                tbDatos = objCrud.nCrudListarBD("select p.id,p.cod_dni,p.cuspp,p.nombres,p.ape_pat,p.ape_mat,p.fec_ingreso,p.cargo,p.moneda,p.sueldo_basico,p.asignacion,p.valor_asignacion,p.seguro,p.aportaciones, p.descuentos , p.total from vista_listaPersonal p inner join centro_costo_personal c on p.id=c.id_personal inner join planilla_centro_costo pc on c.id_centro=pc.id_centro_costo where pc.id='" & dgvLista.Rows(f).Cells("id").Value & "'", CadenaConexion)
            End If

            Dim fila As Integer = 9

            Dim Archivo As String
            Dim a As Object
            Dim APrueba As Object
            a = CreateObject("Excel.Application")
            a.Visible = True
            Archivo = CARPETA_EXCELS & "planilla.remuneraciones.xlsx" 'Pon aqui el nombre de archivo que quieras
            APrueba = a.Workbooks.Open(Archivo)
            With APrueba.WorkSheets("formato")
                '.Cells(3, "F") = cboMes.Text
                '.Cells(4, "F") = data.Rows(0)("ruc").ToString
                '.Cells(5, "F") = data.Rows(0)("nombre").ToString
                Dim trKardex As Integer = tbDatos.Rows.Count
                Dim e_pu As Decimal = 0
                Dim s_pu As Decimal = 0
                Dim sf_can As Decimal = 0
                Dim sf_pu As Decimal = 0
                Dim sf_pt As Decimal = 0
                For i As Integer = 0 To trKardex - 1
                    APrueba.Worksheets("formato").Rows(fila + i).Insert(Shift:=(fila + i))
                    .Cells((fila + i), "A") = (i + 1)
                    .Cells((fila + i), "B") = tbDatos.Rows(i)("cod_dni").ToString
                    .Cells((fila + i), "C") = tbDatos.Rows(i)("cuspp").ToString
                    .Cells((fila + i), "D") = tbDatos.Rows(i)("ape_pat").ToString & " " & tbDatos.Rows(i)("ape_mat").ToString & " " & tbDatos.Rows(i)("nombres").ToString
                    .Cells((fila + i), "E") = Date.Parse(tbDatos.Rows(i)("fec_ingreso")).ToString("dd/MM/yyyy")
                    .Cells((fila + i), "F") = tbDatos.Rows(i)("cargo").ToString
                    .Cells((fila + i), "G") = tbDatos.Rows(i)("asignacion").ToString
                    .Cells((fila + i), "H") = tbDatos.Rows(i)("sueldo_basico").ToString
                    .Cells((fila + i), "I") = tbDatos.Rows(i)("valor_asignacion").ToString
                    .Cells((fila + i), "K") = (Decimal.Parse(tbDatos.Rows(i)("sueldo_basico").ToString) + Decimal.Parse(tbDatos.Rows(i)("valor_asignacion").ToString)).ToString
                    .Cells((fila + i), "L") = tbDatos.Rows(i)("seguro").ToString
                    .Cells((fila + i), "M") = tbDatos.Rows(i)("aportaciones").ToString
                    .Cells((fila + i), "S") = tbDatos.Rows(i)("aportaciones").ToString
                    .Cells((fila + i), "T") = tbDatos.Rows(i)("total").ToString
                    Dim dtAporte As New DataTable
                    dtAporte = objCrud.nCrudListarBD("select * from sistema_pensiones where tipo='EMPRESA'", CadenaConexion)
                    Dim aporteEmpresa As Decimal = 0
                    aporteEmpresa = (Decimal.Parse(tbDatos.Rows(i)("sueldo_basico").ToString) + Decimal.Parse(tbDatos.Rows(i)("valor_asignacion").ToString)) * Decimal.Parse(dtAporte.Rows(0)("porcentaje").ToString) / 100
                    .Cells((fila + i), "U") = aporteEmpresa
                    .Cells((fila + i), "V") = aporteEmpresa
                Next
                Dim filaRest As Integer = (fila + trKardex)
                'MsgBox(.Cells((17 + trKardex), "A").Value)

                If .Cells(filaRest, "A").Value = "" Then
                    '.Rows(10).Delete()
                    .Rows(filaRest).Delete()
                End If

                'SUMA DE TOTALES
                '.Cells(filaRest, "L").Formula = "=SUM(L" & fila & ":L" & filaRest - 1 & ")"
                '.Cells(filaRest, "M").Formula = "=SUM(M" & fila & ":M" & filaRest - 1 & ")"
                '.Cells(filaRest, "U").Formula = "=SUM(U" & fila & ":U" & filaRest - 1 & ")"
                '.Cells(filaRest, "I") = "=(G" & filaRest & "-H" & filaRest & ")"
                .Rows(8).Delete()
            End With

            'MsgBox("No cierres esto hasta ver el resultado")
            'APrueba.Close(SaveChanges:=False) 'O True, como prefieras
            a.Quit()
            Me.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Enabled = True
    End Sub
End Class