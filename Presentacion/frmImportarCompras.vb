Imports System.Data.OleDb
Imports Entidades
Imports Negocio

Public Class frmImportarCompras

    Dim dtImport As DataTable
    Dim objCrud As New nCrud

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
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
                    Dim Cmd As New OleDbCommand("Select * from [hoja1$]")
                    Dim Ds As New DataSet
                    Dim Da As New OleDbDataAdapter
                    Dim Dt As New DataTable

                    cnConex.Open()
                    Cmd.Connection = cnConex

                    Da.SelectCommand = Cmd
                    Da.Fill(Ds)
                    Dt = Ds.Tables(0)
                    dtImport = Dt
                    dgvLista.DataSource = Dt
                    realizarSumas()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub realizarSumas()
        lblNumRegistros.Text = dgvLista.Rows.Count
        Dim monto, igv, total As Decimal
        For Each row As DataGridViewRow In dgvLista.Rows
            monto = monto + Decimal.Parse(row.Cells("monto").Value.ToString)
            igv = igv + Decimal.Parse(row.Cells("igv").Value.ToString)
            total = total + Decimal.Parse(row.Cells("total").Value.ToString)
        Next
        lblMontos.Text = Decimal.Round(monto, 2)
        lblIgv.Text = Decimal.Round(igv, 2)
        lblTotal.Text = Decimal.Round(total, 2)
    End Sub
    Private Sub frmImportarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLista.RowTemplate.Height = 35
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvLista.Rows.Count > 0 Then
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            frmEditarCuentasDeImportacion.tipo = "COMPRA"
            frmEditarCuentasDeImportacion.Show()
        End If
    End Sub
    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        If dgvLista.Rows.Count > 0 Then
            If MessageBox.Show("¿Está seguro que desea realizar la importación de estos datos al sistema?.", "TICOM CONTABLE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Me.Enabled = False
                For Each row As DataGridViewRow In dgvLista.Rows
                    'VERIFICAR SI EXISTE DETRACCION
                    Dim varDet As Boolean = False
                    Dim dtImp As New DataTable
                    dtImp = objCrud.nCrudListarBD("select * from impuestos_sunat where tipo_comprobante='COMPRA' and '" & Decimal.Parse(row.Cells("total").Value) & "'>=tope", CadenaConexion)
                    If dtImport.Rows.Count > 0 Then
                        varDet = True
                    End If
                    'registrar comprobante compra
                    Dim dataComp As New DataTable
                    dataComp = objCrud.nCrudListarBD("select * from tipo_documento where descripcion like '" & row.Cells("comprobante").Value & "%'", CadenaConexion)
                    Dim objCC As New nComprobanteCompra
                    Dim entiCCompra As New ComprobanteCompraEntity
                    Dim entiCostoCompra As New CostoComprasEntity
                    With entiCCompra
                        .id_gravado = "1"
                        .tipo_compra = row.Cells("estado").Value
                        .id_tipo_comprobante = dataComp.Rows(0)("id").ToString
                        .marca = "SIN AFECTO@I"
                        .centro = "0"
                        .estado_comprobante = "F"
                        .fec_emision = Date.Parse(row.Cells("emision").Value)
                        .fec_pago = Date.Parse(row.Cells("emision").Value)
                        .serie_comprobante = row.Cells("serie").Value
                        .numero_comprobante = row.Cells("numero").Value
                        .cod_dni = "6"
                        .num_dni = row.Cells("dni_ruc").Value
                        .razon_social = row.Cells("nombre").Value
                        .valor_facturado = Decimal.Parse(row.Cells("monto").Value)
                        .glosa = row.Cells("glosa").Value
                        If row.Cells("moneda").Value.ToString = "PEN" Then
                            .id_moneda = "115"
                        Else
                            .id_moneda = "151"
                        End If
                        .valor_igv = Decimal.Parse(row.Cells("igv").Value)
                        .total = Decimal.Parse(row.Cells("total").Value)
                        .tipo_cambio = Decimal.Parse(row.Cells("tc").Value)
                        .base_imponible = Decimal.Parse(row.Cells("monto").Value)
                        .valor_exonerado = 0
                        .valor_inafecto = 0
                        .valor_isc = 0
                        .otros_base_imponible = 0
                        .fec_comp_origen = Date.Parse(row.Cells("emision").Value)
                        .serie_dua = "0"
                        .numero_dua = "0"
                        .anio_dua = Date.Parse(row.Cells("emision").Value)
                        .numero_detraccion = "0"
                        .tipo_tasa_detraccion = "0"
                        .tasa_detraccion = "0.00"
                        .valor_detraccion = "0.00"
                        .numero_maquina = "-"
                        .detraccion = "0"
                        .tip_comp_origen = ""
                        .serie_comp_origen = ""
                        .numero_comp_origen = ""
                        .fecha_detraccion = Date.Parse(row.Cells("emision").Value)
                        .estado = 1
                        .id_usuario = CodigoUsuarioSession
                    End With
                    Dim rptaRCC As String = objCC.nRegistrarComprobanteCompraBD(entiCCompra, CadenaConexion)
                    If rptaRCC <> "ok" Then
                        MsgBox("Error en el registro del comprobante: " & rptaRCC)
                    End If

                    Dim objAbono As New nAbonosPagos
                    Dim dataCC As New DataTable
                    dataCC = objCrud.nCrudListarBD("select top 1 * from comprobante_compra order by id desc", CadenaConexion)
                    With entiCCompra
                        .id_comprobante = dataCC.Rows(0)("id").ToString
                        .numero_cuo = objCC.nObtenerCUO_CompraBD(CadenaConexion)
                    End With

                    Dim debe, haber As Decimal
                    debe = "0.00"
                    haber = "0.00"
                    'REGISTRANDO ASIENTOS CONTABLES
                    Dim lista As New DataTable
                    Dim sql As String = ""
                    If chkAT.Checked = True Then
                        sql = "select * from plantilla_importacion where proceso='COMPRA' and (tipo='A' or tipo='T') order by id asc"
                    Else
                        sql = "select * from plantilla_importacion where proceso='COMPRA' and tipo='A' order by id asc"
                    End If
                    lista = objCrud.nCrudListarBD(sql, CadenaConexion)
                    For Each cuenta As DataRow In lista.Rows
                        If cuenta.Item("tipo").ToString = "A" Then
                            If cuenta.Item("debe").ToString = "X" Then
                                debe = row.Cells("monto").Value
                                haber = "0.00"
                            End If
                            If cuenta.Item("debe").ToString = "X" And cuenta.Item("cuenta").ToString.StartsWith("40") Then
                                debe = row.Cells("igv").Value
                                haber = "0.00"
                            End If
                            If cuenta.Item("haber").ToString = "X" Then
                                debe = "0.00"
                                haber = row.Cells("total").Value()
                            End If
                            entiCCompra.glosa = row.Cells("glosa").Value.ToString
                        End If
                        If cuenta.Item("tipo").ToString = "T" Then
                            If cuenta.Item("debe").ToString = "X" Then
                                debe = row.Cells("monto").Value
                                haber = "0.00"
                            End If
                            If cuenta.Item("haber").ToString = "X" Then
                                debe = "0.00"
                                haber = row.Cells("monto").Value
                            End If
                            entiCCompra.glosa = "POR LA TRANSFERENCIA DE ACTIVOS"
                        End If
                        entiCCompra.cuenta = cuenta.Item("cuenta").ToString
                        entiCCompra.debe = debe
                        entiCCompra.haber = haber
                        entiCCompra.impuesto = "0"
                        entiCCompra.serie = "0"
                        entiCCompra.numero = "0"
                        entiCCompra.operacion = "0"
                        Dim rptaRAC As String = objCC.nRegistrarAsientoComprobanteCompraBD(entiCCompra, CadenaConexion)
                        If rptaRAC <> "ok" Then
                            MsgBox("Error en el registro del comprobante: " & rptaRAC)
                        End If
                        debe = "0.00"
                        haber = "0.00"
                    Next

                    If row.Cells("estado").Value.ToString.StartsWith("CONTADO") Then
                        'REGISTRANDO PAGOS DE LOS COMPROBANTES
                        Dim glosaPago As String = "POR EL PAGO DE LA " & row.Cells("comprobante").Value.ToString & ": " & row.Cells("serie").Value.ToString & "-" & row.Cells("numero").Value.ToString
                        Dim dataCompra As New DataTable
                        dataCompra = objCrud.nCrudListarBD("select top 1 * from comprobante_compra order by id desc", CadenaConexion)
                        Dim codCompra As String
                        codCompra = dataCompra.Rows(0)("id").ToString
                        Dim EntiAboCom, EntiAsientoAboCom As New AbonoComprasEntity
                        With EntiAboCom
                            .id_compra = codCompra
                            .id_impuesto = "0"
                            .id_letra = 0
                            .tipo_comprobante = dataCompra.Rows(0)("id_tipo_comprobante").ToString
                            .monto = Decimal.Parse(row.Cells("total").Value.ToString)
                            .id_banco = "0"
                            .id_caja = "1"
                            .tipo = "8"
                            .numero = "0"
                            .descripcion = glosaPago
                            .fecha = Date.Parse(row.Cells("emision").Value.ToString)
                            .estado = "1"
                            .tipo_abono = "NORMAL"
                        End With
                        objAbono.nRegistrarAbonoComprasBD(EntiAboCom, CadenaConexion)

                        Dim sqlPago As String = ""
                        Dim listaPago As New DataTable
                        sqlPago = "select * from plantilla_importacion where proceso='COMPRA' and tipo='P' order by id asc"
                        listaPago = objCrud.nCrudListarBD(sqlPago, CadenaConexion)
                        debe = "0.00"
                        haber = "0.00"
                        For Each pago As DataRow In listaPago.Rows
                            With EntiAsientoAboCom
                                .id = objAbono.nObtenerUltimoAbonoCompraBD(CadenaConexion)
                                .id_cliente = dataCompra.Rows(0)("num_dni").ToString
                                .id_compra = codCompra
                                .cuenta = pago.Item("cuenta").ToString
                                .base_imponible = Decimal.Parse(row.Cells("total").Value.ToString)
                                .nro_detraccion = "0"
                                .tipo_tasa_detraccion = "0"
                                .valor_tasa = "0"
                                .valor_detraccion = "0"
                                .fecha_detraccion = Date.Parse(row.Cells("emision").Value.ToString)
                                .monto = Decimal.Parse(row.Cells("total").Value.ToString)
                                .tipo = "8"
                                If pago.Item("tipo").ToString = "P" Then
                                    If pago.Item("debe").ToString = "X" Then
                                        debe = row.Cells("total").Value
                                        haber = "0.00"
                                    End If
                                    If pago.Item("haber").ToString = "X" Then
                                        debe = "0.00"
                                        haber = row.Cells("total").Value
                                    End If
                                    .debe = debe
                                    .haber = haber
                                    .descripcion = glosaPago
                                End If
                                .fecha = Date.Parse(row.Cells("emision").Value.ToString)
                            End With
                            objAbono.nRegistrarAsientoAbonoComprasBD(EntiAsientoAboCom, CadenaConexion)
                            debe = "0.00"
                            haber = "0.00"
                        Next
                    End If
                Next
                Me.Enabled = True
                frmListaComprobanteCompras.Show()
                Me.Close()
                MsgBox("Importación finalizada con éxito")
            End If
        End If
    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function
End Class