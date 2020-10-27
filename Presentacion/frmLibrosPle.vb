Imports Negocio

Public Class frmLibrosPle
    Dim obj As New nCrud

    Private Sub cargarLibros()
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from libros_ple where estado=1 order by id asc", CadenaConexion)
        dgvLibro.DataSource = data
    End Sub

    Private Sub frmLibrosPle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarLibros()
    End Sub

    Private Sub dgvLibro_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLibro.SelectionChanged
        'MsgBox(codigoCeldaGrid)
        cargarFormatos()
    End Sub

    Private Sub cargarFormatos()
        On Error Resume Next
        Dim f, codComp As Integer
        f = dgvLibro.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        Dim lista As DataGridViewRow = dgvLibro.Rows(f)
        codComp = Integer.Parse(lista.Cells(0).Value.ToString)
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from detalle_libros_ple where id_ple='" & codComp & "' and estado='1' order by id asc", CadenaConexion)
        dgvDetalleLibro.DataSource = data
        dgvDetalleLibro.Columns(1).Width = 40
        'dgvDetalleLibro.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Me.Enabled = False
        Try
            Dim data As New DataTable
            data = obj.nCrudListarBD("select * from empresas where id='" & CodigoEmpresaSession & "'", CadenaConexion)

            Dim tbDatos As New DataTable
            tbDatos = obj.nCrudListarBD("select * from vista_libroCaja order by id asc", CadenaConexion)

            'MsgBox("TOTAL REGISTROS: " & tbDatos.Rows.Count)
            Dim fila As Integer = 10

            Dim Archivo As String
            Dim a As Object
            Dim APrueba As Object
            a = CreateObject("Excel.Application")
            a.Visible = True
            Archivo = CARPETA_EXCELS & "234_formato11.xls" 'Pon aqui el nombre de archivo que quieras
            APrueba = a.Workbooks.Open(Archivo)
            With APrueba.WorkSheets("formato")
                .Cells(3, "A") = "PERÍODO: OCTUBRE" 'cboMes.Text
                .Cells(4, "A") = "RUC: " & data.Rows(0)("ruc").ToString
                .Cells(5, "A") = "APELLIDOS Y NOMBRES, DENOMINACIÓN O RAZÓN SOCIAL: " & data.Rows(0)("nombre").ToString
                Dim trKardex As Integer = tbDatos.Rows.Count
                Dim e_pu As Decimal = 0
                Dim s_pu As Decimal = 0
                Dim sf_can As Decimal = 0
                Dim sf_pu As Decimal = 0
                Dim sf_pt As Decimal = 0
                For i As Integer = 0 To trKardex - 1
                    APrueba.Worksheets("formato").Rows(fila + i).Insert(Shift:=(fila + i))
                    .Cells((fila + i), "A") = tbDatos.Rows(i)("id_comprobante").ToString
                    .Cells((fila + i), "B") = Date.Parse(tbDatos.Rows(i)("fecha_operacion")).ToString("dd/MM/yyyy")
                    .Cells((fila + i), "C") = tbDatos.Rows(i)("glosa").ToString
                    .Cells((fila + i), "D") = tbDatos.Rows(i)("cuenta").ToString
                    .Cells((fila + i), "E") = obtenerDatosCuenta(tbDatos.Rows(i)("cuenta").ToString).ToString
                    .Cells((fila + i), "F") = tbDatos.Rows(i)("haber").ToString
                    .Cells((fila + i), "G") = tbDatos.Rows(i)("debe").ToString
                Next

                Dim filaRest As Integer = (fila + trKardex)
                'MsgBox(.Cells((17 + trKardex), "A").Value)
                If .Cells(filaRest, "A").Value = "" Then
                    '.Rows(10).Delete()
                    .Rows(filaRest).Delete()
                End If

                'SUMA DE TOTALES
                .Cells(filaRest, "F").Formula = "=SUM(F" & fila & ":F" & filaRest - 1 & ")"
                .Cells(filaRest, "G").Formula = "=SUM(G" & fila & ":G" & filaRest - 1 & ")"
                '.Cells(filaRest, "U").Formula = "=SUM(U" & fila & ":U" & filaRest - 1 & ")"
                '.Cells(filaRest, "I") = "=(G" & filaRest & "-H" & filaRest & ")"
                .Rows(9).Delete()
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
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = obj.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function

    Private Sub btnBancos_Click(sender As Object, e As EventArgs) Handles btnBancos.Click
        Me.Enabled = False
        Try
            Dim data As New DataTable
            data = obj.nCrudListarBD("select * from empresas where id='" & CodigoEmpresaSession & "'", CadenaConexion)

            Dim tbDatos As New DataTable
            tbDatos = obj.nCrudListarBD("select * from vista_libroBancos order by id asc", CadenaConexion)

            Dim dtBanco As New DataTable
            dtBanco = obj.nCrudListarBD("select b.id,b.nombre,c.cuenta,c.cuenta_corriente from bancos_configuracion c inner join bancos b on c.id_banco=b.id where c.cuenta='10411'", CadenaConexion)

            'MsgBox("TOTAL REGISTROS: " & tbDatos.Rows.Count)
            Dim fila As Integer = 14

            Dim Archivo As String
            Dim a As Object
            Dim APrueba As Object
            a = CreateObject("Excel.Application")
            a.Visible = True
            Archivo = CARPETA_EXCELS & "234_formato12.xls" 'Pon aqui el nombre de archivo que quieras
            APrueba = a.Workbooks.Open(Archivo)
            With APrueba.WorkSheets("formato")
                Dim cad As String()
                cad = Date.Parse(tbDatos.Rows(0)("fecha_operacion").ToString).ToString("M").Split(" ")
                .Cells(3, "A") = "PERÍODO: " & cad(2).Trim.ToUpper
                .Cells(4, "A") = "RUC: " & data.Rows(0)("ruc").ToString
                .Cells(5, "A") = "APELLIDOS Y NOMBRES, DENOMINACIÓN O RAZÓN SOCIAL: " & data.Rows(0)("nombre").ToString
                .Cells(6, "A") = "ENTIDAD FINANCIERA: " & dtBanco.Rows(0)("nombre").ToString
                .Cells(7, "A") = "CÓDIGO DE LA CUENTA CORRIENTE: " & dtBanco.Rows(0)("cuenta_corriente").ToString
                Dim trKardex As Integer = tbDatos.Rows.Count
                Dim e_pu As Decimal = 0
                Dim s_pu As Decimal = 0
                Dim sf_can As Decimal = 0
                Dim sf_pu As Decimal = 0
                Dim sf_pt As Decimal = 0
                For i As Integer = 0 To trKardex - 1
                    APrueba.Worksheets("formato").Rows(fila + i).Insert(Shift:=(fila + i))
                    .Cells((fila + i), "A") = tbDatos.Rows(i)("id_comprobante").ToString
                    .Cells((fila + i), "B") = Date.Parse(tbDatos.Rows(i)("fecha_operacion")).ToString("dd/MM/yyyy")
                    .Cells((fila + i), "C") = tbDatos.Rows(i)("tipo").ToString
                    .Cells((fila + i), "D") = tbDatos.Rows(i)("glosa").ToString
                    .Cells((fila + i), "E") = tbDatos.Rows(i)("empresa").ToString
                    .Cells((fila + i), "F") = tbDatos.Rows(i)("numero").ToString
                    .Cells((fila + i), "G") = tbDatos.Rows(i)("cuenta").ToString
                    .Cells((fila + i), "H") = obtenerDatosCuenta(tbDatos.Rows(i)("cuenta").ToString).ToString
                    .Cells((fila + i), "I") = tbDatos.Rows(i)("haber").ToString
                    .Cells((fila + i), "J") = tbDatos.Rows(i)("debe").ToString
                Next

                Dim filaRest As Integer = (fila + trKardex)
                'MsgBox(.Cells((17 + trKardex), "A").Value)
                If .Cells(filaRest, "A").Value = "" Then
                    '.Rows(10).Delete()
                    .Rows(filaRest).Delete()
                End If

                'SUMA DE TOTALES
                .Cells(filaRest, "I").Formula = "=SUM(I" & fila & ":I" & filaRest - 1 & ")"
                .Cells(filaRest, "J").Formula = "=SUM(J" & fila & ":J" & filaRest - 1 & ")"
                '.Cells(filaRest, "U").Formula = "=SUM(U" & fila & ":U" & filaRest - 1 & ")"
                '.Cells(filaRest, "I") = "=(G" & filaRest & "-H" & filaRest & ")"
                .Rows(13).Delete()
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