Imports System.Data.OleDb
Imports Negocio
Imports Entidades

Public Class frmListaEntradasSalidasBancos
    Dim obj As New nCrud
    Dim dtImport As DataTable
    Dim objCon As New nConciliacion
    Dim iCarga As Integer = 0
    Dim periodo As String = "11"
    Private Sub pbImportar_Click(sender As Object, e As EventArgs) Handles pbImportar.Click, lblImportar.Click
        Dim openFileDialog1 As New OpenFileDialog()
        Dim dlg As New OpenFileDialog()
        Try
            openFileDialog1.InitialDirectory = "c:\"
            openFileDialog1.Filter = "Formatos Excel | *.xls;*.xlsx"
            openFileDialog1.Title = "Selección de archivo Excel a Importar"
            If openFileDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            Else
                txtArchivo.Text = openFileDialog1.FileName
                Try
                    Dim stConexion As String = ("Provider=Microsoft.ACE.OLEDB.12.0;" & ("Data Source=" & (txtArchivo.Text & ";Extended Properties=""Excel 12.0 Xml;HDR=YES;IMEX=2"";")))
                    Dim cnConex As New OleDbConnection(stConexion)
                    Dim Cmd As New OleDbCommand("Select * from [Hoja1$]")
                    Dim Ds As New DataSet
                    Dim Da As New OleDbDataAdapter
                    Dim Dt As New DataTable

                    cnConex.Open()
                    Cmd.Connection = cnConex

                    Da.SelectCommand = Cmd
                    Da.Fill(Ds)
                    Dt = Ds.Tables(0)
                    dtImport = Dt
                    dgvExtracto.DataSource = Dt
                    realizarSumasExtracto()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim dataConciliacion As New DataTable
        With dataConciliacion
            .Columns.Add("id")
            .Columns.Add("id_comprobante")
            .Columns.Add("verificador")
            .Columns.Add("fecha_operacion")
            .Columns.Add("id_caja")
            .Columns.Add("glosa")
            .Columns.Add("movimiento")
            .Columns.Add("numero")
            .Columns.Add("cuenta")
            .Columns.Add("monto")
        End With

        Dim dPendientes As New DataTable
        dPendientes = obj.nCrudListarBD("select * from conciliaciones_pendientes where estado=1", CadenaConexion)
        For Each fila As DataRow In dPendientes.Rows
            With fila
                dataConciliacion.Rows.Add(.Item("id").ToString, .Item("id_abono").ToString, False, .Item("fecha").ToString, "0", .Item("concepto").ToString, .Item("tipo").ToString, .Item("numero").ToString, "0", .Item("monto").ToString)
            End With
        Next
        'dgvContable.DataSource = dataConciliacion
        Dim data As New DataTable
        data = obj.nCrudListarBD(querysPorCombinacion(), CadenaConexion)
        For Each fila As DataRow In data.Rows
            With fila
                dataConciliacion.Rows.Add(.Item("id").ToString, .Item("id_comprobante").ToString, False, .Item("fecha_operacion").ToString, .Item("id_caja").ToString, .Item("glosa").ToString, .Item("movimiento").ToString, .Item("numero").ToString, .Item("cuenta").ToString, .Item("monto").ToString)
            End With
        Next
        'data.Merge(dataConciliacion)
        dgvContable.DataSource = dataConciliacion
        realizarSumasContable()
    End Sub

    Private Sub frmListaEntradasSalidasBancos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCuentasBancos()
        iCarga = 1
    End Sub


    Private Sub cargarCuentasBancos()
        Dim dataAnio As New DataTable
        dataAnio.Columns.Add("codigo")
        dataAnio.Columns.Add("descripcion")
        'dataAnio.Rows.Add(0, "SELECCIONE")
        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select * from caja_configuracion where tipo='BANCOS' and estado=1 order by id asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                dataAnio.Rows.Add(row.Item(0).ToString, row.Item("descripcion").ToString)
            Next
            With cboBanco
                .DataSource = dataAnio
                .ValueMember = "codigo"
                .DisplayMember = "descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar las cajas")
        End Try
    End Sub

    Private Function querysPorCombinacion() As String
        Dim query As String = ""
        Dim queryRangoFechas As String = ""
        Dim dCaja As New DataTable
        dCaja = obj.nCrudListarBD("select * from caja_configuracion where id='" & cboBanco.SelectedValue.ToString & "'", CadenaConexion)
        'query = "select * from vista_extractoBancosContable where 1=1 and month(fecha_operacion)='" & periodo & "' and year(fecha_operacion)='" & AnioEjercicio & "' "
        query = "select * from vista_extractoBancosContable where 1=1 and month(fecha_operacion)='" & Integer.Parse(Date.Parse(dtDesde.Value).ToString("MM")) & "' and year(fecha_operacion)='" & Date.Parse(dtDesde.Value).ToString("yyyy") & "' "
        If dCaja.Rows.Count > 0 Then
            'query += "and (cuenta<>'" & dCaja.Rows(0)("cuenta").ToString & "' or id_comprobante like 'A%')"
        End If

        'COMBINACION DE "BUSCAR POR"
        If cboBanco.SelectedValue.ToString <> "0" Then
            'query += "and id_caja='" & cboBanco.SelectedValue.ToString & "' "

            'ElseIf cboTipo.SelectedValue.ToString = "2" And txtDato.Text.Trim.Length > 1 Then
            '    query += "and razon_social like '" & txtDato.Text.Trim & "%' "
            'ElseIf cboTipo.SelectedValue.ToString = "3" And txtDato.Text.Trim.Length > 1 Then
            '    query += "and numero like '" & txtDato.Text.Trim & "%' "
            'ElseIf cboTipo.SelectedValue.ToString = "4" Then
            '    query += "and tipo_compra='CREDITO' "
            'ElseIf cboTipo.SelectedValue.ToString = "5" Then
            '    query += "and tipo_compra='CONTADO' "
            'ElseIf cboTipo.SelectedValue.ToString = "6" Then
            '    query += "and estado='FINALIZADO' "
            'ElseIf cboTipo.SelectedValue.ToString = "7" Then
            '    query += "and estado='PENDIENTE' "
        Else
            query += ""
        End If
        'FIN COMBINACION DE "BUSCAR POR"
        'MsgBox(query)

        'FIN COMBINACION DE "MONEDAS"
        'If iCarga = 1 Then
        '    queryRangoFechas = " and DATEADD(dd, 0, DATEDIFF(dd, 0, fec_emision))>='" & dtDesde.Value().ToString("yyyy-MM-dd") & "' and DATEADD(dd, 0, DATEDIFF(dd, 0, fec_emision))<='" & dtHasta.Value().ToString("yyyy-MM-dd") & "' "
        '    'COMBINACION DE "AÑO & MES"
        '    If cboAnio.SelectedValue.ToString <> "0" Then
        '        queryRangoFechas = ""
        '        query += "and year(fec_emision)='" & cboAnio.SelectedValue.ToString & "' "
        '    End If
        '    If cboMes.SelectedValue.ToString <> "0" Then
        '        queryRangoFechas = ""
        '        query += "and month(fec_emision)='" & cboMes.SelectedValue.ToString & "' "
        '    End If
        '    'FIN COMBINACION DE "AÑO & MES"
        'End If

        query += queryRangoFechas & "  order by id asc"
        'MsgBox(query)
        Return query
    End Function


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        For Each row As DataGridViewRow In dgvContable.Rows
            row.Cells("verificador").Value = True
        Next
        For Each row As DataGridViewRow In dgvExtracto.Rows
            row.Cells(0).Value = True
        Next
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        For Each row As DataGridViewRow In dgvContable.Rows
            row.Cells("verificador").Value = False
        Next
        For Each row As DataGridViewRow In dgvExtracto.Rows
            row.Cells(0).Value = False
        Next
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If dgvContable.Rows.Count > 0 And dgvExtracto.Rows.Count > 0 Then
            For Each rowOuter As DataGridViewRow In dgvContable.Rows
                For Each rowInner As DataGridViewRow In dgvExtracto.Rows
                    If rowOuter.Cells("movimiento").Value = rowInner.Cells("tipoE").Value And rowOuter.Cells("numero").Value = rowInner.Cells("numeroE").Value And rowOuter.Cells("monto").Value = rowInner.Cells("montoE").Value Then
                        'MsgBox("(IGUALES) Tipo 1: " & rowOuter.Cells("tipo").Value & " - Tipo 2: " & rowInner.Cells("tipoE").Value & vbCrLf & "Numero 1: " & rowOuter.Cells("numero").Value & " - Numero 2: " & rowInner.Cells("numeroE").Value)
                        rowOuter.DefaultCellStyle.BackColor = Color.Yellow
                        rowOuter.DefaultCellStyle.ForeColor = Color.Black
                        rowOuter.Cells("verificador").Value = True
                        Exit For
                    End If
                    If rowOuter.Cells("movimiento").Value <> rowInner.Cells("tipoE").Value And rowOuter.Cells("numero").Value <> rowInner.Cells("numeroE").Value And rowOuter.Cells("monto").Value <> rowInner.Cells("montoE").Value Then
                        'MsgBox("(IGUALES) Tipo 1: " & rowOuter.Cells("tipo").Value & " - Tipo 2: " & rowInner.Cells("tipoE").Value & vbCrLf & "Numero 1: " & rowOuter.Cells("numero").Value & " - Numero 2: " & rowInner.Cells("numeroE").Value)
                        rowOuter.DefaultCellStyle.BackColor = Color.Red
                        rowOuter.DefaultCellStyle.ForeColor = Color.White
                        rowOuter.Cells("verificador").Value = False
                    End If
                Next
            Next
            realizarSumasPendienteContable()

            For Each rowOuter As DataGridViewRow In dgvExtracto.Rows
                For Each rowInner As DataGridViewRow In dgvContable.Rows
                    If rowOuter.Cells("tipoE").Value = rowInner.Cells("movimiento").Value And rowOuter.Cells("numeroE").Value = rowInner.Cells("numero").Value And rowOuter.Cells("montoE").Value = rowInner.Cells("monto").Value Then
                        'MsgBox("(IGUALES 2) Tipo 1: " & rowOuter.Cells("tipoE").Value & " - Tipo 2: " & rowInner.Cells("tipo").Value & vbCrLf & "Numero 1: " & rowOuter.Cells("numeroE").Value & " - Numero 2: " & rowInner.Cells("numero").Value)
                        rowOuter.DefaultCellStyle.BackColor = Color.Yellow
                        rowOuter.DefaultCellStyle.ForeColor = Color.Black
                        rowOuter.Cells(0).Value = True
                        Exit For
                    End If
                    If rowOuter.Cells("tipoE").Value <> rowInner.Cells("movimiento").Value And rowOuter.Cells("numeroE").Value <> rowInner.Cells("numero").Value And rowOuter.Cells("montoE").Value <> rowInner.Cells("monto").Value Then
                        'MsgBox("(IGUALES) Tipo 1: " & rowOuter.Cells("tipo").Value & " - Tipo 2: " & rowInner.Cells("tipoE").Value & vbCrLf & "Numero 1: " & rowOuter.Cells("numero").Value & " - Numero 2: " & rowInner.Cells("numeroE").Value)
                        rowOuter.DefaultCellStyle.BackColor = Color.Green
                        rowOuter.DefaultCellStyle.ForeColor = Color.White
                        rowOuter.Cells(0).Value = False
                    End If
                Next
            Next
            realizarSumasPendienteExtracto()
            sumasTotales()
        Else
            MsgBox("No se han cargado datos para la comparación")
        End If
    End Sub

    Private Sub realizarSumasContable()
        Dim tMC As Decimal
        For Each row As DataGridViewRow In dgvContable.Rows
            tMC += row.Cells("monto").Value
        Next
        'txtMC.Text = tMC
        txtMC.Text = Format(tMC, "#,##0.00")
    End Sub

    Private Sub sumasTotales()
        Dim tSC, tSE As Decimal
        tSC = Decimal.Parse(txtMC.Text) + Decimal.Parse(txtPE.Text)
        txtSC.Text = Format(tSC, "#,##0.00")
        tSE = Decimal.Parse(txtME.Text) + Decimal.Parse(txtPC.Text)
        txtSE.Text = Format(tSE, "#,##0.00")
    End Sub

    Private Sub realizarSumasPendienteContable()
        Dim tPC As Decimal
        For Each row As DataGridViewRow In dgvContable.Rows
            If row.Cells("verificador").Value = False Then
                tPC += row.Cells("monto").Value
            End If
        Next
        txtPC.Text = Format(tPC, "#,##0.00")

        Dim tPC2 As Decimal
        For Each row As DataGridViewRow In dgvContable.Rows
            If row.Cells("verificador").Value = False Then
                tPC2 += row.Cells("monto").Value
            End If
        Next
        txtPC2.Text = Format(tPC2, "#,##0.00")
    End Sub
    Private Sub realizarSumasPendienteExtracto()
        Dim tPE As Decimal
        For Each row As DataGridViewRow In dgvExtracto.Rows
            If row.Cells(0).Value = False Then
                tPE += row.Cells("montoE").Value
            End If
        Next
        txtPE.Text = Format(tPE, "#,##0.00")

        Dim tPE2 As Decimal
        For Each row As DataGridViewRow In dgvExtracto.Rows
            If row.Cells(0).Value = False Then
                tPE2 += row.Cells("montoE").Value
            End If
        Next
        txtPE2.Text = Format(tPE2, "#,##0.00")
    End Sub

    Private Sub realizarSumasExtracto()
        Dim tME As Decimal
        For Each row As DataGridViewRow In dgvExtracto.Rows
            tME += row.Cells("montoE").Value
        Next
        'txtMC.Text = tMC
        txtME.Text = Format(tME, "#,##0.00")
    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim entiConCab, entiConciliacion As New ConciliacionEntity
        With entiConCab
            .id_abono = cboBanco.SelectedValue.ToString
            .periodo = periodo
            .fecha = dtDesde.Value
            .monto = Decimal.Parse(txtMC.Text.Trim)
            .r1 = Decimal.Parse(txtPE.Text.Trim)
            .r2 = Decimal.Parse(txtPC2.Text.Trim)
            .saldo = Decimal.Parse(txtSC.Text.Trim)
            .estado = "1"
        End With
        objCon.registrarConciliacionCabecera(entiConCab, CadenaConexion)
        'MsgBox("REGISTRO CONCILIACION CABECERA: " & objCon.registrarConciliacionCabecera(entiConCab, CadenaConexion))
        For Each row As DataGridViewRow In dgvContable.Rows
            Dim movimiento As String = "CONTABLE"
            'Dim data As New DataTable
            'data = obj.nCrudListarBD("select * from abono_pagos_ventas where id='" & row.Cells("id_abono").Value.ToString & "' order by id desc")
            If row.Cells("verificador").Value = False Then
                With entiConciliacion
                    .periodo = periodo
                    .id_abono = row.Cells("id_comprobante").Value.ToString
                    .concepto = row.Cells("glosa").Value.ToString
                    .tipo = row.Cells("movimiento").Value.ToString
                    .numero = row.Cells("numero").Value.ToString
                    .monto = Decimal.Parse(row.Cells("monto").Value)
                    .fecha = row.Cells("fecha_operacion").Value.ToString
                    .estado = "1"
                End With
                objCon.registrarConciliacionPendiente(movimiento, entiConciliacion, CadenaConexion)
                'MsgBox("REGISTRO CONCILIACION PENDIENTE: " & movimiento & " - " & objCon.registrarConciliacionPendiente(movimiento, entiConciliacion, CadenaConexion))
            ElseIf row.Cells("verificador").Value = True Then
                With entiConciliacion
                    .periodo = periodo
                    .id_abono = row.Cells("id_comprobante").Value.ToString
                    .concepto = row.Cells("glosa").Value.ToString
                    .tipo = row.Cells("movimiento").Value.ToString
                    .numero = row.Cells("numero").Value.ToString
                    .monto = Decimal.Parse(row.Cells("monto").Value)
                    .fecha = row.Cells("fecha_operacion").Value.ToString
                    .estado = "1"
                End With
                objCon.registrarConciliacionDetalle(movimiento, entiConciliacion, CadenaConexion)
                'MsgBox("REGISTRO CONCILIACION VERIFICADA: " & movimiento & " - " & objCon.registrarConciliacionDetalle(movimiento, entiConciliacion, CadenaConexion))
            End If
        Next
        MsgBox("¡Registro de Conciliación Bancaria con éxito!")
    End Sub

    Private Sub cboBanco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBanco.SelectedIndexChanged
        If iCarga = 1 Then
            Dim data As New DataTable
            data = obj.nCrudListarBD(querysPorCombinacion(), CadenaConexion)
            dgvContable.DataSource = data
            realizarSumasContable()
        End If
    End Sub
End Class