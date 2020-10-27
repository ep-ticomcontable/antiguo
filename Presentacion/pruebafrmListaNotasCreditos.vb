Imports Negocio
Imports System.IO

Public Class pruebafrmListaNotasCreditos
    Dim obj As New nCrud
    Dim iCarga As Integer = 0
    Dim filaTable As New DataTable
    Dim codCompra As String = "080100"
    Dim mesPeriodo As String = "07"
    Dim lista As New DataTable

    Private Sub cargarTipo()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(1, "DNI/RUC")
        data.Rows.Add(2, "RAZON SOCIAL")
        With cboTipo
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub

    Private Sub cargarComprobantes()
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from comprobante_nota_credito where estado=1 order by fec_emision asc", CadenaConexion)
        dgvLista.DataSource = data
    End Sub

    Private Sub frmListaComprobanteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTipo()
        dtDesde.Value = DateTime.Today.AddMonths("-3")
        cargarComprobantes()
        iCarga = 1
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        realizarConsulta()
    End Sub
    Private Sub realizarConsulta()
        If txtDato.Text.Trim.Length > 0 Then
            Dim data As New DataTable
            Dim query As String
            If cboTipo.SelectedValue = 1 Then
                query = "select * from comprobante_nota_credito where estado=1 and num_dni like '%" & txtDato.Text.Trim & "%' and DATEADD(dd, 0, DATEDIFF(dd, 0, fec_emision))>='" & dtDesde.Value().ToString("yyyy-MM-dd") & "' and DATEADD(dd, 0, DATEDIFF(dd, 0, fec_emision))<='" & dtHasta.Value().ToString("yyyy-MM-dd") & "' order by fec_emision asc"
            Else
                query = "select * from comprobante_nota_credito where estado=1 and razon_social like '%" & txtDato.Text.Trim & "%' DATEADD(dd, 0, DATEDIFF(dd, 0, fec_emision))>='" & dtDesde.Value().ToString("yyyy-MM-dd") & "' and DATEADD(dd, 0, DATEDIFF(dd, 0, fec_emision))<='" & dtHasta.Value().ToString("yyyy-MM-dd") & "' order by fec_emision asc"
            End If
            'MsgBox(query)
            data = obj.nCrudListarBD(query, CadenaConexion)
            dgvLista.DataSource = data
        Else
            cargarComprobantes()
        End If
    End Sub

    Private Sub btnGenerarNota_Click(sender As Object, e As EventArgs)
        If iCarga = 1 Then
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            Dim idComprobante As Integer = 0
            idComprobante = dgvLista.Rows(f).Cells(0).Value
            With frmNuevaNotaCredito
                .Text = "Nueva Nota de Crédito - COMPRA- N° registro: " & idComprobante
                .codComprobante = idComprobante
                .codTipoComprobante = dgvLista.Rows(f).Cells("id_tipo_comprobante").Value
                .cargarDatosComprobante()
                .Show()
            End With
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        frmTsCuentasTipoOperacion.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If iCarga = 1 Then
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            Dim idComprobante As Integer = 0
            idComprobante = dgvLista.Rows(f).Cells(0).Value
            With frmNuevaNotaDebito
                .Text = "Nueva Nota de Débito Compra - N° registro: " & idComprobante
                .codComprobante = idComprobante
                .codTipoComprobante = dgvLista.Rows(f).Cells("id_tipo_comprobante").Value
                .cargarDatosComprobante()
                .Show()
            End With
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        frmNuevaCompra.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        Dim idComprobante As Integer = 0
        idComprobante = dgvLista.Rows(f).Cells(0).Value
        frmModificarCompra.idCompra = idComprobante
        'frmModificarCompra.cargarDatosCompra()
        frmModificarCompra.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        generarExcelCompras()
    End Sub
    Private Sub generarExcelCompras()
        Me.Enabled = False
        Try
            Dim data As New DataTable
            data = obj.nCrudListarBD("select * from empresas where id='" & CodigoEmpresaSession & "'", CadenaConexion)

            Dim tbDatos As New DataTable
            tbDatos = obj.nCrudListarBD("select * from comprobante_compra", CadenaConexion)

            'MsgBox("TOTAL REGISTROS: " & tbDatos.Rows.Count)
            Dim fila As Integer = 9

            Dim Archivo As String
            Dim a As Object
            Dim APrueba As Object
            a = CreateObject("Excel.Application")
            a.Visible = True
            Archivo = CARPETA_EXCELS & "formato.8.1-copia.xlsx" 'Pon aqui el nombre de archivo que quieras
            APrueba = a.Workbooks.Open(Archivo)
            With APrueba.WorkSheets("formato")
                .Cells(3, "F") = "JULIO"
                .Cells(4, "F") = data.Rows(0)("ruc").ToString
                .Cells(5, "F") = data.Rows(0)("nombre").ToString
                Dim trKardex As Integer = tbDatos.Rows.Count
                Dim e_pu As Decimal = 0
                Dim s_pu As Decimal = 0
                Dim sf_can As Decimal = 0
                Dim sf_pu As Decimal = 0
                Dim sf_pt As Decimal = 0
                For i As Integer = 0 To trKardex - 1
                    APrueba.Worksheets("formato").Rows(fila + i).Insert(Shift:=(fila + i))
                    .Cells((fila + i), "A") = Date.Parse(tbDatos.Rows(i)("fec_emision")).ToString("yyyyMM") & "00"
                    .Cells((fila + i), "B") = tbDatos.Rows(i)("id").ToString
                    .Cells((fila + i), "C") = "1"
                    .Cells((fila + i), "D") = Date.Parse(tbDatos.Rows(i)("fec_emision")).ToString("dd/MM/yyyy")
                    .Cells((fila + i), "E") = Date.Parse(tbDatos.Rows(i)("fec_pago")).ToString("dd/MM/yyyy")
                    .Cells((fila + i), "F") = tbDatos.Rows(i)("id_tipo_comprobante")
                    .Cells((fila + i), "G") = tbDatos.Rows(i)("serie_comprobante").ToString
                    .Cells((fila + i), "I") = tbDatos.Rows(i)("numero_comprobante").ToString
                    .Cells((fila + i), "K") = tbDatos.Rows(i)("cod_dni").ToString
                    .Cells((fila + i), "L") = tbDatos.Rows(i)("num_dni").ToString
                    .Cells((fila + i), "M") = tbDatos.Rows(i)("razon_social").ToString
                    .Cells((fila + i), "N") = tbDatos.Rows(i)("valor_facturado").ToString * tbDatos.Rows(i)("tipo_cambio").ToString
                    .Cells((fila + i), "O") = tbDatos.Rows(i)("valor_igv").ToString * tbDatos.Rows(i)("tipo_cambio").ToString
                    .Cells((fila + i), "W") = tbDatos.Rows(i)("total").ToString * tbDatos.Rows(i)("tipo_cambio").ToString
                    Dim lista As New DataTable
                    lista = obj.nCrudListarBD("select * from tipo_moneda where id='" & tbDatos.Rows(i)("id_moneda").ToString & "'", CadenaConexion)
                    .Cells((fila + i), "X") = lista.Rows(0)("codigo").ToString
                    .Cells((fila + i), "Y") = tbDatos.Rows(i)("tipo_cambio").ToString
                    .Cells((fila + i), "Z") = Date.Parse(tbDatos.Rows(i)("fec_comp_origen").ToString).ToString("dd/MM/yyyy")
                    .Cells((fila + i), "AA") = tbDatos.Rows(i)("tip_comp_origen").ToString
                    .Cells((fila + i), "AB") = tbDatos.Rows(i)("serie_comp_origen").ToString
                    .Cells((fila + i), "AD") = tbDatos.Rows(i)("numero_comp_origen").ToString
                    .Cells((fila + i), "AH") = "1"
                    .Cells((fila + i), "AN") = ""
                    .Cells((fila + i), "AO") = "1"
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

    Private Sub btnGenerarPle_Click(sender As Object, e As EventArgs)
        generarExcelComprasPle()
        generarTxt()
    End Sub

    Private Sub generarExcelComprasPle()
        Me.Enabled = False
        Try
            Dim tbDatos As New DataTable
            Dim query As String
            query = "select * from comprobante_compra  where fec_emision>='" & dtDesde.Value().ToString("yyyy-MM-dd") & "' and fec_emision<='" & dtHasta.Value().ToString("yyyy-MM-dd") & "' order by fec_emision asc"
            tbDatos = obj.nCrudListarBD(query, CadenaConexion)

            filaTable = New DataTable
            filaTable.Columns.Add("fila")

            'MsgBox("TOTAL REGISTROS: " & tbDatos.Rows.Count)
            Dim fila As Integer = 3

            Dim Archivo As String
            Dim a As Object
            Dim APrueba As Object
            a = CreateObject("Excel.Application")
            a.Visible = True
            Archivo = CARPETA_EXCELS & "registro.compras.xlsx" 'Pon aqui el nombre de archivo que quieras
            APrueba = a.Workbooks.Open(Archivo)

            With APrueba.WorkSheets("formato")

                Dim trKardex As Integer = tbDatos.Rows.Count
                Dim e_pu As Decimal = 0
                Dim s_pu As Decimal = 0
                Dim sf_can As Decimal = 0
                Dim sf_pu As Decimal = 0
                Dim sf_pt As Decimal = 0
                Dim acumulador As String
                For i As Integer = 0 To trKardex - 1
                    'APrueba.Worksheets("formato").Rows(fila + i).Insert(Shift:=(fila + i))
                    acumulador = i + 1
                    .Cells((fila + i), "A") = acumulador
                    .Cells((fila + i), "B") = "2016" & mesPeriodo & "00"
                    .Cells((fila + i), "C").Value = "C" & acumulador
                    .Cells((fila + i), "D").Value = "M" & acumulador.PadLeft(4, "0"c)
                    .Cells((fila + i), "E") = Date.Parse(tbDatos.Rows(i)("fec_emision")).ToString("dd/MM/yyyy")
                    .Cells((fila + i), "F") = ""
                    Dim tc As DataTable = obj.nCrudListarBD("select * from tipo_documento where id='" & tbDatos.Rows(i)("id_tipo_comprobante").ToString & "'", CadenaConexion)
                    .Cells((fila + i), "G") = tc.Rows(0)("codigo").ToString
                    .Cells((fila + i), "H") = tbDatos.Rows(i)("serie_comprobante").ToString.PadLeft(4, "0"c)
                    .Cells((fila + i), "J") = tbDatos.Rows(i)("numero_comprobante").ToString.PadLeft(4, "0"c)
                    .Cells((fila + i), "L") = tbDatos.Rows(i)("cod_dni").ToString
                    .Cells((fila + i), "M") = tbDatos.Rows(i)("num_dni").ToString
                    .Cells((fila + i), "N") = tbDatos.Rows(i)("razon_social").ToString
                    .Cells((fila + i), "O") = tbDatos.Rows(i)("valor_facturado").ToString
                    .Cells((fila + i), "P") = tbDatos.Rows(i)("valor_igv").ToString
                    .Cells((fila + i), "X") = tbDatos.Rows(i)("total").ToString
                    Dim lista As New DataTable
                    lista = obj.nCrudListarBD("select * from tipo_moneda where id='" & tbDatos.Rows(i)("id_moneda").ToString & "'", CadenaConexion)
                    .Cells((fila + i), "Y") = lista.Rows(0)("codigo").ToString
                    .Cells((fila + i), "Z") = IIf(Decimal.Parse(tbDatos.Rows(i)("tipo_cambio").ToString) > 1, tbDatos.Rows(i)("tipo_cambio").ToString, "")
                    If tbDatos.Rows(i)("fec_comp_origen").ToString <> "" Then
                        .Cells((fila + i), "AA") = Date.Parse(tbDatos.Rows(i)("fec_comp_origen")).ToString("dd/MM/yyyy")
                        Dim tc2 As DataTable = obj.nCrudListarBD("select * from tipo_documento where id='" & tbDatos.Rows(i)("tip_comp_origen").ToString & "'", CadenaConexion)
                        If tc2.Rows.Count = 0 Then
                            .Cells((fila + i), "AB") = ""
                        Else
                            .Cells((fila + i), "AB") = tc2.Rows(0)("codigo").ToString
                        End If

                        .Cells((fila + i), "AC") = tbDatos.Rows(i)("serie_comp_origen").ToString
                        .Cells((fila + i), "AE") = tbDatos.Rows(i)("numero_comp_origen").ToString
                    End If
                    .Cells((fila + i), "AI") = "1"
                    .Cells((fila + i), "AP") = "1"
                    filaTable.Rows.Add(.Cells((fila + i), "AQ").Value)
                Next
                Dim filaRest As Integer = (fila + trKardex)

                'MsgBox(.Cells((17 + trKardex), "A").Value)
                If .Cells(filaRest, "A").Value = "" Then
                    .Rows(filaRest).Delete()
                End If
                'If .Cells(fila, "A").Value = "" Then
                '.Rows(fila).Delete()
                'End If


                '.Cells(filaRest, "I") = "=(G" & filaRest & "-H" & filaRest & ")"
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

    Private Sub generarTxt()
        Dim sRenglon As String = Nothing
        Dim strStreamW As Stream = Nothing
        Dim strStreamWriter As StreamWriter = Nothing
        Dim ContenidoArchivo As String = Nothing
        ' Donde guardamos los paths de los archivos que vamos a estar utilizando ..
        Dim PathArchivo As String

        Dim nomArchivo As String
        nomArchivo = "LE204473933022016" & mesPeriodo & "00" & codCompra & "001111"

        Try

            If Directory.Exists(CARPETA_EXCELS & "PLE\") = False Then ' si no existe la carpeta se crea
                Directory.CreateDirectory(CARPETA_EXCELS & "PLE\")
            End If

            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            PathArchivo = CARPETA_EXCELS & "PLE\" & nomArchivo & ".txt" ' Se determina el nombre del archivo con la fecha actual

            'verificamos si existe el archivo

            If File.Exists(PathArchivo) Then
                strStreamW = File.Open(PathArchivo, FileMode.Open) 'Abrimos el archivo
            Else
                strStreamW = File.Create(PathArchivo) ' lo creamos
            End If

            strStreamWriter = New StreamWriter(strStreamW, System.Text.Encoding.Default) ' tipo de codificacion para escritura


            'escribimos en el archivo
            For i As Integer = 0 To filaTable.Rows.Count - 1
                strStreamWriter.WriteLine(filaTable.Rows(i)(0))
            Next
            strStreamWriter.Close() ' cerramos
            MsgBox("¡Archivo creado con éxito en la ruta " & CARPETA_EXCELS & "PLE!")
        Catch ex As Exception
            MsgBox("Error al Guardar la ingormacion en el archivo. " & ex.ToString, MsgBoxStyle.Critical, Application.ProductName)
            strStreamWriter.Close() ' cerramos
        End Try
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        frmListaComprasPorPagar.Show()
    End Sub
End Class