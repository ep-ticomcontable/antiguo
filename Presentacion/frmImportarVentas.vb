Imports System.Data.OleDb
Imports Entidades
Imports Negocio

Public Class frmImportarVentas

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
            frmEditarCuentasDeImportacion.tipo = "VENTA"
            frmEditarCuentasDeImportacion.Show()
        End If
    End Sub
    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        If dgvLista.Rows.Count > 0 Then
            If MessageBox.Show("¿Está seguro que desea realizar la importación de estos datos al sistema?.", "TICOM CONTABLE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Me.Enabled = False
                For Each row As DataGridViewRow In dgvLista.Rows
                    'registrar comprobante venta
                    Dim entiCVenta, entiCabVent As New ComprobanteVentaEntity
                    Dim objAC As New nAsientosContables
                    Dim dataComp As New DataTable
                    With entiCabVent
                        .numero_cuo = objAC.nObtenerNumeroCUOBD(CadenaConexion)
                        .numero_maquina = "-"
                        dataComp = objCrud.nCrudListarBD("select * from tipo_documento where descripcion like '" & row.Cells("comprobante").Value & "%'", CadenaConexion)
                        .id_tipo_comprobante = dataComp.Rows(0)("id").ToString
                        .fec_emision = Date.Parse(row.Cells("emision").Value)
                        .fec_pago = Date.Parse(row.Cells("emision").Value)
                        .tipo_venta = row.Cells("estado").Value.ToString
                        .id_gravado = "1"
                        .marca = "SIN AFECTO@I"
                        .centro = "0"
                        .serie_comprobante = row.Cells("serie").Value.ToString
                        .numero_comprobante = row.Cells("numero").Value.ToString
                        .cod_dni = "6"
                        .num_dni = row.Cells("dni_ruc").Value.ToString
                        .razon_social = row.Cells("nombre").Value.ToString
                        .glosa = row.Cells("glosa").Value.ToString
                        .valor_facturado = Decimal.Parse(row.Cells("monto").Value.ToString)
                        .base_imponible = Decimal.Parse(row.Cells("monto").Value.ToString)
                        .valor_exonerado = 0
                        .valor_inafecto = 0
                        .valor_isc = 0
                        .valor_igv = Decimal.Parse(row.Cells("igv").Value.ToString)
                        .otros_base_imponible = 0
                        .valor_descuento = "0.00"
                        .total = Decimal.Parse(row.Cells("total").Value.ToString)
                        If row.Cells("moneda").Value.ToString = "PEN" Then
                            .id_moneda = "115"
                        Else
                            .id_moneda = "151"
                        End If
                        .tipo_cambio = Decimal.Parse(row.Cells("tc").Value.ToString)
                        .fec_comp_origen = Date.Parse(row.Cells("emision").Value)
                        .tip_comp_origen = "-"
                        .serie_comp_origen = "-"
                        .numero_comp_origen = "-"
                        .estado = 1
                        .cuenta = ""
                        .debe = 0
                        .haber = 0
                        .estado_comprobante = "F"
                    End With
                    Dim objCV As New nComprobanteVenta
                    Dim rptaRCC As String = objCV.nRegistrarComprobanteVentaBD(entiCabVent, CadenaConexion)
                    If rptaRCC <> "ok" Then
                        MsgBox("Error en el registro del comprobante: " & rptaRCC)
                    End If

                    Dim dataCV As New DataTable
                    dataCV = objCV.obtenerIdComprobanteVentaBD(CadenaConexion)
                    With entiCVenta
                        .id_asiento_venta = dataCV.Rows("0")("id").ToString
                        If row.Cells("moneda").Value.ToString = "PEN" Then
                            .id_moneda = "115"
                        Else
                            .id_moneda = "151"
                        End If
                        .tipo_cambio = Decimal.Parse(row.Cells("tc").Value.ToString)
                        .fec_emision = Date.Parse(row.Cells("emision").Value.ToString)
                        .id_tipo_comprobante = dataComp.Rows(0)("id").ToString
                        .numero_comprobante = row.Cells("numero").Value.ToString
                        .tipo_tasa_detraccion = "0"
                        .tasa_detraccion = "0.00"
                        .fecha_detraccion = Date.Parse(row.Cells("emision").Value.ToString)
                        .numero_detraccion = "-"
                        .valor_detraccion = "0.00"
                    End With

                    Dim debe, haber As Decimal
                    debe = "0.00"
                    haber = "0.00"
                    'REGISTRANDO ASIENTOS CONTABLES
                    Dim lista As New DataTable
                    Dim sql As String = ""
                    If chkAT.Checked = True Then
                        sql = "select * from plantilla_importacion where proceso='VENTA' and (tipo='A' or tipo='T') order by id asc"
                    Else
                        sql = "select * from plantilla_importacion where proceso='VENTA' and tipo='A' order by id asc"
                    End If
                    lista = objCrud.nCrudListarBD(sql, CadenaConexion)
                    For Each cuenta As DataRow In lista.Rows
                        If cuenta.Item("tipo").ToString = "A" Then
                            If cuenta.Item("debe").ToString = "X" Then
                                debe = row.Cells("total").Value
                                haber = "0.00"
                            End If
                            If cuenta.Item("haber").ToString = "X" And cuenta.Item("cuenta").ToString.StartsWith("40") Then
                                debe = "0.00"
                                haber = row.Cells("igv").Value
                            End If
                            If cuenta.Item("haber").ToString = "X" And cuenta.Item("cuenta").ToString.StartsWith("70") Then
                                debe = "0.00"
                                haber = row.Cells("monto").Value()
                            End If
                            entiCVenta.glosa = row.Cells("glosa").Value.ToString
                        End If
                        If chkAT.Checked = True Then
                            If cuenta.Item("tipo").ToString = "T" Then
                                If cuenta.Item("debe").ToString = "X" Then
                                    debe = row.Cells("monto").Value
                                    haber = "0.00"
                                End If
                                If cuenta.Item("haber").ToString = "X" Then
                                    debe = "0.00"
                                    haber = row.Cells("monto").Value
                                End If
                                entiCVenta.glosa = "POR LA TRANSFERENCIA DE ACTIVOS"
                            End If
                        End If
                        entiCVenta.cuenta = cuenta.Item("cuenta").ToString
                        entiCVenta.debe = debe
                        entiCVenta.haber = haber
                        Dim rptaRAV As String = objCV.nRegistrarDetalleAsientoVentaBD(entiCVenta, CadenaConexion)
                        If rptaRAV <> "ok" Then
                            MsgBox("Error en el registro del comprobante: " & rptaRCC)
                        End If
                        debe = "0.00"
                        haber = "0.00"
                    Next
                    If row.Cells("estado").Value.ToString.StartsWith("CONTADO") Then
                        'REGISTRANDO PAGOS DE LOS COMPROBANTES
                        Dim glosaPago As String = "POR EL PAGO DE LA " & row.Cells("comprobante").Value.ToString & ": " & row.Cells("serie").Value.ToString & "-" & row.Cells("numero").Value.ToString
                        Dim dataVenta As New DataTable
                        dataVenta = objCrud.nCrudListarBD("select top 1 * from comprobante_venta order by id desc", CadenaConexion)
                        Dim codVenta As String
                        codVenta = dataVenta.Rows(0)("id").ToString
                        Dim EntiAboCom As New AbonoVentasEntity
                        Dim EntiAsientoAboCom As New AbonoComprasEntity
                        With EntiAboCom
                            .id_venta = codVenta
                            .tipo_comprobante = dataVenta.Rows(0)("id_tipo_comprobante").ToString
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
                        Dim objAbono As New nAbonosPagos
                        objAbono.nRegistrarAbonoVentasBD(EntiAboCom, CadenaConexion)

                        Dim sqlPago As String = ""
                        Dim listaPago As New DataTable
                        sqlPago = "select * from plantilla_importacion where proceso='VENTA' and tipo='P' order by id asc"
                        listaPago = objCrud.nCrudListarBD(sqlPago, CadenaConexion)
                        debe = "0.00"
                        haber = "0.00"
                        For Each pago As DataRow In listaPago.Rows
                            With EntiAsientoAboCom
                                .id = objAbono.nObtenerUltimoAbonoVenta(CadenaConexion)
                                .id_cliente = dataVenta.Rows(0)("num_dni").ToString
                                .id_compra = codVenta
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
                                .estado = 1
                            End With
                            objAbono.nRegistrarAsientoAbonoVentas(EntiAsientoAboCom, CadenaConexion)
                            debe = "0.00"
                            haber = "0.00"
                        Next
                    End If
                Next
                Me.Enabled = True
                frmListaComprobanteVentas.Show()
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