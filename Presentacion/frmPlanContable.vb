Imports Negocio
Imports System.IO

Public Class frmPlanContable
    Dim tituloForm As String = "Plan contable"
    Dim obj As New nCrud
    Dim ind_carga As Integer = 0
    Dim tipoAccion As String
    Dim filaTable As New DataTable
    Dim mesPeriodo As String
    Dim lista As New DataTable
    Dim codigoLibro As String = "050300"
    Public formulario As String = ""
    Public cuenta As String = ""
    Public cuentaInicial As String = ""

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

    Public Sub cargarCuentaAModificar()
        txtDato.Text = cuenta
        'dgvLista.DataSource = obj.nCrudListarBD("select * from vista_CuentaContableGrilla where nom_cuenta like '" & txtDato.Text.Trim & "%' or  num_cuenta like '" & txtDato.Text.Trim & "%'", CadenaConexion)
        'btnModificar.PerformClick()
    End Sub

    Private Sub cargarPlanDeCuentas()
        dgvLista.DataSource = obj.nCrudListarBD("select * from vista_CuentaContableGrilla where codEmpresa='" & CodigoEmpresaSession & "' order by num_cuenta asc", CadenaConexion)
        lista = obj.nCrudListarBD("select * from vista_CuentaContableGrilla where codEmpresa='" & CodigoEmpresaSession & "' and nivel_cuenta<>'BALANCE' order by num_cuenta asc", CadenaConexion)
    End Sub

    Private Sub cargarNivelCuenta()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select * from nivel_cta_cont where estado=1 order by nombre asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboNivelCuenta
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar Nivel Cuenta")
        End Try
    End Sub

    Private Sub cargarTipoCuenta()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable

        Try
            data2 = obj.nCrudListarBD("select * from tipo_cta_cont where estado=1 order by nombre asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboTipoCuenta
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar Tipo Cuenta")
        End Try
    End Sub

    Private Sub cargarAnalisisCuenta()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select * from analisis_cta_cont where estado=1 order by nombre asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboAnalisis
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar Analisis Cuenta")
        End Try
    End Sub

    Private Sub cargarBancos()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select id,nombre,abreviatura from bancos where estado=1 order by nombre asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, "(" & row.Item(2).ToString & ") " & row.Item(1).ToString)
            Next
            With cboBanco
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Bancos")
        End Try
    End Sub

    Private Sub cargarMonedas()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select * from tipo_moneda where estado=1 order by id asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, "(" & row.Item("codigo").ToString & ") " & row.Item("descripcion").ToString)
            Next
            With cboMoneda
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Bancos")
        End Try
    End Sub

    Private Sub pbAtras_Click(sender As Object, e As EventArgs)
        frmInicio.Show()
        frmInicio.Enabled = True
        While (frmInicio.Enabled <> True)
        End While
        Me.Hide()
    End Sub

    Private Sub frmPlanContable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = fondoPantalla
        Me.BackgroundImageLayout = ImageLayout.Stretch

        lblTituloForm.Text = tituloForm
        Me.Text = tituloForm.ToUpper & " " & Me.Text

        Me.MaximumSize = New Size(wForm, 1052)

        'Cargar métodos
        cargarBancos()
        cargarMonedas()
        cargarPlanDeCuentas()
        cargarDatosCuenta()
        cargarNivelCuenta()
        cargarTipoCuenta()
        cargarAnalisisCuenta()
        mesPeriodo = 11

    End Sub
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If MsgBox("¿Está seguro que desea salir del módulo de " & tituloForm & "?.", MsgBoxStyle.YesNo, "Cerrar Módulo") = MsgBoxResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub dgvLista_Click(sender As Object, e As EventArgs) Handles dgvLista.Click

    End Sub

    Private Sub dgvLista_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLista.SelectionChanged
        cargarDatosCuenta()
    End Sub

    Private Sub cargarDatosCuenta()
        On Error Resume Next
        Dim sql As String
        sql = "select * from cuenta_contable where id=" & codigoCeldaSeleccionada()
        Dim data As New DataTable
        data = obj.nCrudListarBD(sql, CadenaConexion)
        With data
            txtNroCuenta.Text = .Rows(0)("id")
            txtNombre.Text = .Rows(0)("nombre")
            txtEqSunat.Text = .Rows(0)("equi_sunat")
            cboNivelCuenta.SelectedValue = IIf(.Rows(0)("id_nivel_cta_cont") Is DBNull.Value, "0", .Rows(0)("id_nivel_cta_cont"))
            cboTipoCuenta.SelectedValue = IIf(.Rows(0)("id_nivel_cta_cont") Is DBNull.Value, "0", .Rows(0)("id_nivel_cta_cont"))
            If .Rows(0)("bal_comprobacion") = "NO" Then
                rbNo.Checked = True
                rbSi.Checked = False
            ElseIf .Rows(0)("bal_comprobacion") = "SI" Then
                rbSi.Checked = True
                rbNo.Checked = False
            End If
            cboAnalisis.SelectedValue = IIf(.Rows(0)("id_analisis_cta_cont") Is DBNull.Value, "0", .Rows(0)("id_analisis_cta_cont"))
            txtDebe.Text = .Rows(0)("cuenta_debe")
            txtHaber.Text = .Rows(0)("cuenta_haber")

            cboBanco.SelectedValue = 0
            txtCorriente.Text = ""
            cboMoneda.SelectedValue = IIf(.Rows(0)("id_moneda") Is DBNull.Value, "0", .Rows(0)("id_moneda"))
            chkCC.Checked = IIf(.Rows(0)("c1") = "1", True, False)

            If .Rows(0)("id").ToString.StartsWith("10") Then
                gbCuenta10.Enabled = True
                cboBanco.SelectedValue = IIf(.Rows(0)("id_banco") Is DBNull.Value, "0", .Rows(0)("id_banco"))
                txtCorriente.Text = .Rows(0)("cuenta_corriente")
                cboMoneda.SelectedValue = IIf(.Rows(0)("id_moneda") Is DBNull.Value, "0", .Rows(0)("id_moneda"))
            Else
                cboBanco.SelectedValue = 0
                txtCorriente.Text = ""
                cboMoneda.SelectedValue = 0
            End If
        End With
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        tipoAccion = "nuevo"
        gbParametros.Enabled = True
        txtNroCuenta.Text = ""
        txtEqSunat.Text = ""
        txtNombre.Text = ""
        cboNivelCuenta.SelectedIndex = 0
        cboTipoCuenta.SelectedIndex = 0
        cboAnalisis.SelectedIndex = 0
        txtDebe.Text = ""
        txtHaber.Text = ""
        cboBanco.SelectedIndex = 0
        txtCorriente.Text = ""
        cboMoneda.SelectedIndex = 0
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        tipoAccion = "modificar"
        gbParametros.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        realizarProceso(tipoAccion)
    End Sub

    Private Sub realizarProceso(accion As String)
        gbParametros.Enabled = True
        Dim campos, valores, condicion, numCuenta, nomCuenta, ctaEquiv, nivelCuenta, tipoCuenta, balance, tipoAnalisis, ctaDebe, ctaHaber, banco, ctaCorriente, moneda, estadoCC As String
        numCuenta = txtNroCuenta.Text.Trim
        nomCuenta = txtNombre.Text.Trim
        ctaEquiv = txtEqSunat.Text.Trim
        nivelCuenta = cboNivelCuenta.SelectedValue.ToString
        tipoCuenta = cboTipoCuenta.SelectedValue.ToString
        balance = IIf(rbSi.Checked = True, "SI", "NO")
        tipoAnalisis = cboAnalisis.SelectedValue.ToString
        ctaDebe = txtDebe.Text.Trim
        ctaHaber = txtHaber.Text.Trim
        banco = cboBanco.SelectedValue.ToString
        ctaCorriente = txtCorriente.Text.Trim
        moneda = cboMoneda.SelectedValue.ToString
        estadoCC = IIf(chkCC.Checked = True, "1", "0")
        If accion = "nuevo" Then
            'Verificando cuenta
            Dim existeCuenta As New DataTable
            existeCuenta = obj.nCrudListarBD("select * from cuenta_contable where id='" & numCuenta & "'", CadenaConexion)
            If existeCuenta.Rows.Count > 0 Then
                MsgBox("El número de cuenta ingresada ya se encuentra registrado en el sistema")
            Else
                Dim cuentaPadre As String
                cuentaPadre = numCuenta.Substring(0, (numCuenta.Length - 1))

                Dim existeCuentaPadre As New DataTable
                existeCuentaPadre = obj.nCrudListarBD("select * from cuenta_contable where id='" & cuentaPadre & "'", CadenaConexion)

                'If existeCuentaPadre.Rows.Count > 0 Then
                campos = "id@sub_id@nombre@equi_sunat@bal_comprobacion@id_nivel_cta_cont@id_tipo_cta_cont@id_analisis_cta_cont@cuenta_debe@cuenta_haber@c1@id_banco@cuenta_corriente@id_moneda@estado@c2"
                valores = numCuenta & "@" & cuentaPadre & "@" & nomCuenta & "@" & ctaEquiv & "@" & balance & "@" & nivelCuenta & "@" & tipoCuenta & "@" & tipoAnalisis & "@" & ctaDebe & "@" & ctaHaber & "@" & estadoCC & "@" & banco & "@" & ctaCorriente & "@" & moneda & "@1@" & CodigoEmpresaSession
                Dim dato As String
                dato = obj.nCrudInsertarBD("@", "cuenta_contable", campos, valores, CadenaConexion)

                If dato = "ok" Then
                    MsgBox("¡Cuenta registrada correctamente!")
                    cargarPlanDeCuentas()
                    cargarDatosCuenta()
                Else
                    MsgBox("Error: " & dato)
                End If
                'Else
                'MsgBox("No se ha encontrado un número de origen para este registro")
                'End If
            End If
        ElseIf accion = "modificar" Then
            campos = "nombre@equi_sunat@bal_comprobacion@id_nivel_cta_cont@id_tipo_cta_cont@id_analisis_cta_cont@cuenta_debe@cuenta_haber@c1@id_banco@cuenta_corriente@id_moneda"
            valores = nomCuenta & "@" & ctaEquiv & "@" & balance & "@" & nivelCuenta & "@" & tipoCuenta & "@" & tipoAnalisis & "@" & ctaDebe & "@" & ctaHaber & "@" & estadoCC & "@" & banco & "@" & ctaCorriente & "@" & moneda
            condicion = "id='" & numCuenta & "'"
            Dim dato As String
            dato = obj.nCrudActualizarBD("@", "cuenta_contable", campos, valores, condicion, CadenaConexion)

            If dato = "ok" Then
                MsgBox("¡Cuenta actualizada correctamente!")
                cargarPlanDeCuentas()
                cargarDatosCuenta()
            Else
                MsgBox("Error: " & dato)
                txtDato.Text = dato
            End If
        End If
        If formulario = "escoger" Then
            frmEscogerPlanContable.Show()
            frmEscogerPlanContable.cuentaInicio = cuentaInicial
            frmEscogerPlanContable.cuenta = cuenta
            frmEscogerPlanContable.cargarDatosCuentaContable()
            frmEscogerPlanContable.seleccionarCodigoDeCuenta()
            frmEscogerPlanContable.formatoGrilla()
            Me.Close()
        End If
        gbParametros.Enabled = False
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        gbParametros.Enabled = False
        cargarPlanDeCuentas()
        cargarDatosCuenta()
    End Sub

    Private Sub txtDato_TextChanged(sender As Object, e As EventArgs) Handles txtDato.TextChanged
        'Me.Enabled = False
        dgvLista.DataSource = obj.nCrudListarBD("select * from vista_CuentaContableGrilla where nom_cuenta like '" & txtDato.Text.Trim & "%' or  num_cuenta like '" & txtDato.Text.Trim & "%' order by num_cuenta asc", CadenaConexion)
        'Me.Enabled = True
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        generarExcel()
    End Sub
    Private Sub generarExcel()
        Me.Enabled = False
        Try

            Dim tbDatos As New DataTable
            tbDatos = lista
            filaTable = New DataTable

            filaTable.Columns.Add("fila")

            'MsgBox("TOTAL REGISTROS: " & tbDatos.Rows.Count)
            Dim fila As Integer = 3

            Dim Archivo As String
            Dim a As Object
            Dim APrueba As Object
            a = CreateObject("Excel.Application")
            a.Visible = True
            Archivo = CARPETA_EXCELS & "registro.plan.contable.xlsx" 'Pon aqui el nombre de archivo que quieras
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
                    .Cells((fila + i), "B") = "2015" & mesPeriodo & "30"
                    .Cells((fila + i), "C").Value = tbDatos.Rows(i)("num_cuenta").ToString
                    .Cells((fila + i), "D").Value = tbDatos.Rows(i)("nom_cuenta").ToString
                    .Cells((fila + i), "E") = "01"
                    .Cells((fila + i), "F") = "-"
                    .Cells((fila + i), "G") = "1"
                    filaTable.Rows.Add(.Cells((fila + i), "I").Value)
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
        nomArchivo = "LE204473933022015" & mesPeriodo & "00" & codigoLibro & "001111"

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
            MsgBox("¡Archivo creado con éxito en la ruta D:/excel/PLE/!")
        Catch ex As Exception
            MsgBox("Error al Guardar la ingormacion en el archivo. " & ex.ToString, MsgBoxStyle.Critical, Application.ProductName)
            strStreamWriter.Close() ' cerramos
        End Try
    End Sub

    Private Sub btnGenerarTxt_Click(sender As Object, e As EventArgs) Handles btnGenerarTxt.Click
        generarTxt()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmListaLibroDiario.Show()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        cargarPlanDeCuentas()
        cargarDatosCuenta()
        gbParametros.Enabled = False
    End Sub

    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        dgvLista.DataSource = obj.nCrudListarBD("select * from vista_CuentaContableGrilla where nom_cuenta like '" & txtDato.Text.Trim & "%' or  num_cuenta like '" & txtDato.Text.Trim & "%' order by num_cuenta asc", CadenaConexion)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub dgvLista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLista.CellContentClick

    End Sub

    Private Sub cboMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMoneda.SelectedIndexChanged

    End Sub

    Private Sub txtNroCuenta_TextChanged(sender As Object, e As EventArgs) Handles txtNroCuenta.TextChanged

    End Sub
End Class