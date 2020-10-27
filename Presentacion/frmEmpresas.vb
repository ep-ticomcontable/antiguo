Imports Negocio
Imports System.IO

Public Class frmEmpresas
    Dim obj As New nCrud
    Dim ind_carga As Integer = 0
    Dim tipo As String = ""

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

    Private Sub cargarMonedas()
        Dim tbData As New DataTable
        tbData.Columns.Add("Codigo")
        tbData.Columns.Add("Nombre")
        tbData.Rows.Add(0, "Seleccione")
        Dim tbData2 As DataTable
        Try
            tbData2 = obj.nCrudListarBD("select * from tipo_moneda where estado=1 order by descripcion asc", CadenaConexion)
            For Each row As DataRow In tbData2.Rows
                tbData.Rows.Add(row.Item(0).ToString, "(" & row.Item(1).ToString & ") " & row.Item(2).ToString)
            Next
            With cboMoneda
                .DataSource = tbData
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With
            tbData2.Dispose()
        Catch ex As Exception
            MsgBox("Error en la carga de Monedas")
            Exit Sub
        End Try
    End Sub

    Private Sub cargarPlanContable()
        Dim tbData As New DataTable
        tbData.Columns.Add("Codigo")
        tbData.Columns.Add("Nombre")
        tbData.Rows.Add(0, "Nuevo")
        Dim tbData2 As DataTable
        Try
            tbData2 = obj.nCrudListarBD("select * from empresas where estado=1 and id>1 order by nombre asc", CadenaConexion)
            For Each row As DataRow In tbData2.Rows
                tbData.Rows.Add(row.Item("ruc").ToString, row.Item("nombre").ToString)
            Next
            With cboPlan
                .DataSource = tbData
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With
            tbData2.Dispose()
        Catch ex As Exception
            MsgBox("Error en la carga de Monedas")
            Exit Sub
        End Try
    End Sub

    Private Sub cargarDatos()
        Dim data As New DataTable
        If CodigoUsuarioSession = "1" Then
            data = obj.nCrudListarBD("select * from [" & BD_MASTER & "].dbo.vista_listaEmpresas order by id asc", CadenaConexion)
        Else
            data = obj.nCrudListarBD("select v.id,v.nombre,v.ruc,v.direccion,v.periodo,v.estado from [" & BD_MASTER & "].dbo.vista_listaEmpresas v inner join [" & BD_MASTER & "].dbo.usuarios_empresas u on v.id=u.id_empresa where u.id_usuario='" & CodigoUsuarioSession & "' order by v.nombre asc", CadenaConexion)
            'and v.id<>'1'
        End If

        dgvLista.DataSource = data
        data = Nothing
        cargaInicialEstados()
    End Sub

    Private Sub frmTsEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
        cargarMonedas()
        cargarPlanContable()
        txtDato.Focus()
        txtDato.Select()
    End Sub

    Private Sub dgvLista_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLista.SelectionChanged
        cargarDatosCuenta()
    End Sub

    Private Sub cargarDatosCuenta()
        If tipo <> "new" Or tipo = "" Then
            Me.Enabled = False
            On Error Resume Next
            Dim sql As String
            sql = "select * from empresas where id=" & codigoCeldaSeleccionada()
            Dim data As New DataTable
            data = obj.nCrudListarBD(sql, CadenaConexion)
            With data
                txtNombre.Text = .Rows(0)("nombre").ToString
                txtAlias.Text = .Rows(0)("alias").ToString
                txtRuc.Text = .Rows(0)("ruc").ToString
                txtPeriodo.Text = .Rows(0)("periodo").ToString
                txtDireccion.Text = .Rows(0)("direccion").ToString
                cboMoneda.SelectedValue = .Rows(0)("id_moneda").ToString
                If .Rows(0)("agente_retencion").ToString = "1" Then
                    chkRetencion.Checked = True
                Else
                    chkRetencion.Checked = False
                End If
                If .Rows(0)("color_fondo").ToString.Trim.Length > 3 Then
                    txtColor.Text = .Rows(0)("color_fondo").ToString
                    btnColor.BackColor = Color.FromArgb(.Rows(0)("color_fondo").ToString)
                Else
                    btnColor.BackColor = Color.FromArgb(32, 82, 115)
                    txtColor.Text = Color.FromArgb(32, 82, 115).ToArgb
                End If

                If .Rows(0)("estado") = "0" Then
                    rbNo.Checked = True
                ElseIf .Rows(0)("estado") = "1" Then
                    rbSi.Checked = True
                End If
            End With
            data = Nothing
            Me.Enabled = True
        ElseIf tipo = "new" Then
            txtNombre.Focus()
        End If
        cargaInicialEstados()
    End Sub

    Private Sub frmTsTipoPago_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            cargarDatos()
        End If
    End Sub

    Private Sub txtDato_TextChanged(sender As Object, e As EventArgs) Handles txtDato.TextChanged
        'If txtDato.Text.Length > 2 Then

        'End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        gbGrupo.Enabled = True
        tipo = "update"
        txtAlias.Enabled = False
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        gbGrupo.Enabled = True
        tipo = "new"
        limpiarEntradas()
        txtAlias.Enabled = True
    End Sub

    Private Sub limpiarEntradas()
        txtNombre.Text = "BTEC PERU SCRL"
        txtAlias.Text = "BTECPERU"
        txtRuc.Text = "20447393302"
        txtPeriodo.Text = DateTime.Now.ToString("yyyy")
        txtDireccion.Text = "Av Petith Thouars 1255 Of. 302 Lima - Perú"
        cboMoneda.SelectedValue = 115
        rbSi.Checked = True
        txtNombre.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        gbGrupo.Enabled = False
        tipo = ""
        cargarDatosCuenta()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Me.Enabled = False
        'VERIFICAR EXISTENCIA DE CARPETAS
        If Directory.Exists(CARPETA_BDS & "empresas") And Directory.Exists(CARPETA_BDS & "plantilla") Then
            Dim campos As String
            Dim valores As String
            Dim condicion As String
            Dim estado As String
            If rbNo.Checked = True Then
                estado = "0"
            Else
                estado = "1"
            End If
            campos = "nombre@alias@ruc@direccion@periodo@id_moneda@agente_retencion@color_fondo@estado"
            valores = txtNombre.Text.ToString & "@" & txtAlias.Text.Trim & "@" & txtRuc.Text.ToString & "@" & txtDireccion.Text.ToString & "@" & txtPeriodo.Text.ToString & "@" & cboMoneda.SelectedValue.ToString & "@" & IIf(chkRetencion.Checked = True, 1, 0) & "@" & txtColor.Text.Trim & "@" & estado

            Dim rpta As String = ""
            Dim tabla As String = "empresas"
            If tipo = "update" Then
                txtAlias.Enabled = False
                condicion = "id=" & codigoCeldaSeleccionada()
                rpta = obj.nCrudActualizarBD("@", tabla, campos, valores, condicion, CadenaConexion)
                If codigoCeldaSeleccionada() > 1 Then
                    Dim query As String
                    query = "UPDATE empresas SET [nombre] = '" & txtNombre.Text.ToString & "',[alias] ='" & txtAlias.Text.Trim & "',[ruc] ='" & txtRuc.Text.ToString & "',[direccion] ='" & txtDireccion.Text.ToString & "',[periodo] ='" & txtPeriodo.Text.ToString & "',[id_moneda] ='" & cboMoneda.SelectedValue.ToString & "',[agente_retencion] ='" & IIf(chkRetencion.Checked = True, 1, 0) & "',[color_fondo] ='" & txtColor.Text.Trim & "',[estado] =  '" & estado & "' WHERE id='" & codigoCeldaSeleccionada() & "'"
                    obj.nEjecutarConsultaEnBD(query, txtAlias.Text.Trim)
                    'MsgBox("ACTUALIZACION DE EMPRESA: " & obj.nEjecutarConsultaEnBD(query, txtAlias.Text.Trim))
                End If

                'Insertamos las empresas seleccionadas al usuario
                Dim listaEmp As New DataTable
                listaEmp = obj.nCrudListarBD("select * from  [" & BD_MASTER & "].dbo.empresas", CadenaConexion)
                For Each rowEmp As DataRow In listaEmp.Rows
                    'MsgBox(rowEmp.Item("alias").ToString)
                    For Each filaCol As DataGridViewRow In dgvLista.Rows
                        Dim dataEmp As New DataTable
                        dataEmp = obj.nCrudListarBD("select * from  [" & rowEmp.Item("alias").ToString & "].dbo.empresas where id='" & filaCol.Cells("id").Value & "'", CadenaConexion)
                        'Dim dtEmp As New DataTable
                        'dtEmp = obj.nCrudListarBD("select * from [" & dataEmp.Rows(0)("alias").ToString & "].dbo.empresas where id='" & filaCol.Cells("id").Value & "'", CadenaConexion)
                        If dataEmp.Rows.Count = 0 Then
                            Dim row As New DataTable
                            row = obj.nCrudListarBD("select * from  [" & BD_MASTER & "].dbo.empresas where id='" & filaCol.Cells("id").Value & "'", CadenaConexion)
                            Dim query1 As String
                            query1 = "INSERT INTO [" & rowEmp.Item("alias").ToString & "].[dbo].[empresas] ([id],[nombre],[alias],[ruc],[direccion],[periodo],[id_moneda],[agente_retencion],[color_fondo],[estado])"
                            query1 += "VALUES ('" & row.Rows(0)("id").ToString & "','" & row.Rows(0)("nombre").ToString & "','" & row.Rows(0)("alias").ToString & "','" & row.Rows(0)("ruc").ToString & "','" & row.Rows(0)("direccion").ToString & "','" & row.Rows(0)("periodo").ToString & "','" & row.Rows(0)("id_moneda").ToString & "','" & row.Rows(0)("agente_retencion").ToString & "','" & row.Rows(0)("color_fondo").ToString & "','" & row.Rows(0)("estado").ToString & "');"
                            rpta = obj.nEjecutarQueryBD(query1, CadenaConexion)
                        End If
                    Next
                Next
            ElseIf tipo = "new" Then
                Dim data As New DataTable
                data = obj.nCrudListarBD("select * from empresas where alias like '%" & txtAlias.Text.Trim & "%'", CadenaConexion)
                If data.Rows.Count > 0 Then
                    rpta = "No se puedo completar el proceso"
                    MsgBox("El ALIAS de la Empresa a crear ya existe, ingrese otra descripción para continuar.")
                Else
                    Dim dataBD As New DataTable
                    dataBD = obj.nCrudListarBD("SELECT * FROM sys.databases where log_reuse_wait_desc='LOG_BACKUP' and name like '%" & txtAlias.Text.Trim & "%'", CadenaConexion)
                    If dataBD.Rows.Count > 0 Then
                        rpta = "No se puedo completar el proceso"
                        MsgBox("El nombre de la Base de Datos: " & txtAlias.Text.Trim & ", ya se encuentra registrada. Ingrese otro ALIAS para usar como nombre de la Base de Datos en el sistema.")
                    Else
                        Dim query As String
                        If CodigoUsuarioSession <> 1 Or CodigoEmpresaSession <> 1 Then
                            query = "usp_registrarEmpresa '" & txtNombre.Text.ToString & "','" & txtAlias.Text.Trim & "','" & txtRuc.Text.ToString & "','" & txtDireccion.Text.ToString & "','" & txtPeriodo.Text.ToString & "','" & cboMoneda.SelectedValue.ToString & "','" & IIf(chkRetencion.Checked = True, 1, 0) & "','" & txtColor.Text.Trim & "','" & estado & "';"
                            'MsgBox("ASIGNACION DE EMPRESA: " & obj.nEjecutarConsultaEnBD(txtAlias.Text.Trim, query))
                            obj.nEjecutarConsultaEnBD(query, BD_MASTER)
                        End If

                        Dim query1 As String
                        query1 = "usp_registrarEmpresa '" & txtNombre.Text.ToString & "','" & txtAlias.Text.Trim & "','" & txtRuc.Text.ToString & "','" & txtDireccion.Text.ToString & "','" & txtPeriodo.Text.ToString & "','" & cboMoneda.SelectedValue.ToString & "','" & IIf(chkRetencion.Checked = True, 1, 0) & "','" & txtColor.Text.Trim & "','" & estado & "'"
                        rpta = obj.nEjecutarQueryBD(query1, CadenaConexion)
                        copiarBD()
                        'asignar empresa de la BD principal a la BD de la empresa creada
                        Dim dt As New DataTable
                        dt = obj.nCrudListarBD("select * from [" & BD_MASTER & "].dbo.empresas where alias='" & txtAlias.Text.Trim & "'", CadenaConexion)

                        If CodigoUsuarioSession = 1 And CodigoEmpresaSession = 1 Then
                            'query = "usp_registrarEmpresa '" & txtNombre.Text.ToString & "','" & txtAlias.Text.Trim & "','" & txtRuc.Text.ToString & "','" & txtDireccion.Text.ToString & "','" & txtPeriodo.Text.ToString & "','" & cboMoneda.SelectedValue.ToString & "','" & IIf(chkRetencion.Checked = True, 1, 0) & "','" & txtColor.Text.Trim & "','" & estado & "'"
                            query = "INSERT INTO [dbo].[empresas] ([id],[nombre],[alias],[ruc],[direccion],[periodo],[id_moneda],[agente_retencion],[color_fondo],[estado])"
                            query += "VALUES ('" & dt.Rows(0)("id").ToString & "','" & txtNombre.Text.ToString & "','" & txtAlias.Text.Trim & "','" & txtRuc.Text.ToString & "','" & txtDireccion.Text.ToString & "','" & txtPeriodo.Text.ToString & "','" & cboMoneda.SelectedValue.ToString & "','" & IIf(chkRetencion.Checked = True, 1, 0) & "','" & txtColor.Text.Trim & "','" & estado & "');"
                            obj.nEjecutarConsultaEnBD(query, txtAlias.Text.Trim)
                        End If

                        'SI EL USUARIO QUE ACCEDIO ES TICOM, REGISTRAR ESE USUARIO EN LAS BDS QUE SE CREAN
                        If CodigoUsuarioSession = 1 Then
                            obj.nCrudInsertarBD("@", "dbo.usuarios_empresas", "id_empresa@id_usuario", dt.Rows(0)("id").ToString & "@" & CodigoUsuarioSession, CadenaConexion)
                            obj.nCrudInsertarBD("@", "[" & txtAlias.Text.Trim & "].dbo.usuarios_empresas", "id_empresa@id_usuario", dt.Rows(0)("id").ToString & "@" & CodigoUsuarioSession, CadenaConexion)
                        End If

                        'si se accede con ticom pero en otra bd, se tiene que replicar la tabla usuarios-empresa al master
                        If CodigoUsuarioSession = 1 And CodigoEmpresaSession <> 1 Then
                            obj.nCrudInsertarBD("@", "[" & BD_MASTER & "].dbo.usuarios_empresas", "id_empresa@id_usuario", dt.Rows(0)("id").ToString & "@" & CodigoUsuarioSession, CadenaConexion)
                        End If

                        'registrar los usuarios creados con ADMIN en todas las bd's creadas
                        Dim dtUser As New DataTable
                        dtUser = obj.nCrudListarBD("select * from [" & BD_MASTER & "].dbo.usuarios where cod_usuario='1' order by id asc", CadenaConexion)

                        Dim dtEmp As New DataTable
                        dtEmp = obj.nCrudListarBD("select * from [" & BD_MASTER & "].dbo.empresas order by id asc", CadenaConexion)
                        For Each fila As DataRow In dtUser.Rows
                            For Each row As DataRow In dtEmp.Rows
                                Dim dtVerif As New DataTable
                                dtVerif = obj.nCrudListarBD("select * from [" & row.Item("alias").ToString & "].dbo.usuarios where id='" & fila.Item("id").ToString & "'", CadenaConexion)
                                If dtVerif.Rows.Count = 0 Then
                                    Dim queryUs As String = ""
                                    queryUs = "INSERT INTO [dbo].[usuarios] ([id],[usuario],[nombres],[clave],[tipo],[estado],[cod_usuario])"
                                    queryUs += " VALUES ('" & fila.Item("id").ToString & "','" & fila.Item("usuario").ToString & "','" & fila.Item("nombres").ToString & "','" & fila.Item("clave").ToString & "','" & fila.Item("tipo").ToString & "','" & fila.Item("estado").ToString & "','" & fila.Item("cod_usuario").ToString & "');"
                                    obj.nEjecutarConsultaEnBD(queryUs, row.Item("alias").ToString)
                                    Exit For
                                End If
                            Next
                        Next

                        If cboPlan.SelectedValue.ToString <> "0" Then
                            Dim dEmpresa As New DataTable
                            dEmpresa = obj.nCrudListarBD("select * from [" & BD_MASTER & "].[dbo].[empresas] where ruc='" & cboPlan.SelectedValue.ToString & "'", CadenaConexion)

                            Dim queryLimpiar, queryInst As String
                            queryLimpiar = "truncate table [" & txtAlias.Text.Trim & "].[dbo].[cuenta_contable]"
                            'MsgBox("LIMPIEZA DE PLAN CONTABLE: " & obj.nEjecutarConsultaEnBD(txtAlias.Text.Trim, queryLimpiar))
                            obj.nEjecutarConsultaEnBD(queryLimpiar, txtAlias.Text.Trim)
                            queryInst = "insert into [" & txtAlias.Text.Trim & "].[dbo].[cuenta_contable] select * from [" & dEmpresa.Rows(0)("alias").ToString & "].[dbo].[cuenta_contable]"
                            'MsgBox("CARGAR DE PLAN CONTABLE: " & obj.nEjecutarConsultaEnBD(txtAlias.Text.Trim, queryInst))
                            obj.nEjecutarConsultaEnBD(queryInst, txtAlias.Text.Trim)
                        End If

                        cargarPlanContable()
                    End If

                End If

            End If

            If rpta = "ok" Then
                frmPrincipal.BackColor = Color.FromArgb(txtColor.Text.Trim)
                gbGrupo.Enabled = False
                limpiarEntradas()
                cargarDatos()
                txtDato.Focus()
                ''MIGRAR EMPRESAS A LAS DEMAS BDS
                ''Insertamos las empresas seleccionadas al usuario
                'Dim listaEmp As New DataTable
                'listaEmp = obj.nCrudListarBD("select * from  [" & BD_MASTER & "].dbo.empresas", CadenaConexion)
                'For Each rowEmp As DataRow In listaEmp.Rows
                '    'MsgBox(rowEmp.Item("alias").ToString)
                '    For Each filaCol As DataGridViewRow In dgvLista.Rows
                '        Dim dataEmp As New DataTable
                '        dataEmp = obj.nCrudListarBD("select * from  [" & rowEmp.Item("alias").ToString & "].dbo.empresas where id='" & filaCol.Cells("id").Value & "'", CadenaConexion)
                '        'Dim dtEmp As New DataTable
                '        'dtEmp = obj.nCrudListarBD("select * from [" & dataEmp.Rows(0)("alias").ToString & "].dbo.empresas where id='" & filaCol.Cells("id").Value & "'", CadenaConexion)
                '        If dataEmp.Rows.Count = 0 Then
                '            Dim row As New DataTable
                '            row = obj.nCrudListarBD("select * from  [" & BD_MASTER & "].dbo.empresas where id='" & filaCol.Cells("id").Value & "'", CadenaConexion)
                '            Dim query1 As String
                '            query1 = "INSERT INTO [" & rowEmp.Item("alias").ToString & "].[dbo].[empresas] ([id],[nombre],[alias],[ruc],[direccion],[periodo],[id_moneda],[agente_retencion],[color_fondo],[estado])"
                '            query1 += "VALUES ('" & filaCol.Cells("id").Value & "','" & row.Rows(0)("nombre").ToString & "','" & row.Rows(0)("alias").ToString & "','" & row.Rows(0)("ruc").ToString & "','" & row.Rows(0)("direccion").ToString & "','" & row.Rows(0)("periodo").ToString & "','" & row.Rows(0)("id_moneda").ToString & "','" & row.Rows(0)("agente_retencion").ToString & "','" & row.Rows(0)("color_fondo").ToString & "','" & row.Rows(0)("estado").ToString & "');"
                '            rpta = obj.nEjecutarQueryBD(query1, CadenaConexion)
                '        End If
                '    Next
                'Next

                ''VERIFICAR QUE LOS ACCESOS DEL USUARIO PRINCIPAL SE REPLIQUE A TODAS LAS EMPRESAS
                'Dim dataUsers As New DataTable
                'Dim dtUs As New DataTable
                'Dim queryUs As String = ""
                'Dim listaEmp2 As New DataTable
                'listaEmp2 = obj.nCrudListarBD("select * from  [" & BD_MASTER & "].dbo.empresas", CadenaConexion)
                'For Each fila As DataRow In listaEmp2.Rows
                '    'VERIFICAR SI EXISTE LOS USUARIOS
                '    dataUsers = obj.nCrudListarBD("select * from [" & BD_MASTER & "].dbo.usuarios_empresas where id_usuario='" & CodigoUsuarioSession & "'", CadenaConexion)
                '    For Each row As DataRow In dataUsers.Rows
                '        'MsgBox("select * from [" & fila.Item("alias").ToString & "].dbo.usuarios_empresas where id_usuario='" & row.Item("id_usuario").ToString & "' and id_empresa='" & row.Item("id_empresa").ToString & "'")
                '        dtUs = obj.nCrudListarBD("select * from [" & fila.Item("alias").ToString & "].dbo.usuarios_empresas where id_usuario='" & row.Item("id_usuario").ToString & "' and id_empresa='" & row.Item("id_empresa").ToString & "'", CadenaConexion)
                '        If dtUs.Rows.Count = 0 Then
                '            queryUs = "INSERT INTO [dbo].[usuarios_empresas] ([id_empresa],[id_usuario])"
                '            queryUs += " VALUES ('" & row.Item("id_empresa").ToString & "','" & row.Item("id_usuario").ToString & "');"
                '            rpta = obj.nEjecutarConsultaEnBD(queryUs, fila.Item("alias").ToString)
                '        End If
                '    Next
                'Next
                With frmPrincipal
                    .BringToFront()
                    .WindowState = System.Windows.Forms.FormWindowState.Maximized
                End With
                MessageBox.Show("El proceso se ha realizado con éxito.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(rpta, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
        ElseIf Directory.Exists(CARPETA_BDS & "empresas") And Not Directory.Exists(CARPETA_BDS & "plantilla") Then
            MsgBox("La ruta de acceso: '" & CARPETA_BDS & "plantilla' no se encuentra disponible. Verifique que se tenga acceso a la ruta mencionada.")
        ElseIf Directory.Exists(CARPETA_BDS & "plantilla") And Not Directory.Exists(CARPETA_BDS & "empresas") Then
            MsgBox("La ruta de acceso: '" & CARPETA_BDS & "empresas' no se encuentra disponible. Verifique que se tenga acceso a la ruta mencionada.")
        ElseIf Not Directory.Exists(CARPETA_BDS & "empresas") And Not Directory.Exists(CARPETA_BDS & "plantilla") Then
            MsgBox("La ruta de acceso: '" & CARPETA_BDS & " no se encuentra disponible. Verifique que se tenga acceso a la ruta mencionada.")
        End If
        With Me
            .BringToFront()
            .WindowState = System.Windows.Forms.FormWindowState.Normal
        End With
        Me.Enabled = True
    End Sub

    Private Sub controlarServicio(control As String, nombreServicio As String)
        Dim myProcess As New Process()
        myProcess.StartInfo.UseShellExecute = False

        myProcess.StartInfo.FileName = "cmd.exe" 'Aquí  le pasarías el nombre de tu programa
        myProcess.StartInfo.CreateNoWindow = True
        myProcess.StartInfo.Arguments = "/c net " & control & " " & nombreServicio 'Aquí le pasarías los argumentos
        myProcess.StartInfo.CreateNoWindow = False
        myProcess.Start()
        myProcess.WaitForExit()
    End Sub

    Private Sub copiarBD()

        'controlarServicio("stop", "MSSQL$PCPROG")
        Dim carpetaDestino As String = CARPETA_BDS & "empresas\"

        Dim nomBD As String = txtAlias.Text.Trim
        Dim fileMdf As String = CARPETA_BDS & "plantilla\" & BD_MASTER & ".mdf"
        My.Computer.FileSystem.CopyFile(
            fileMdf,
            carpetaDestino & nomBD & ".mdf",
            Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
            Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)

        Dim fileLdf As String = CARPETA_BDS & "plantilla\" & BD_MASTER & "_log.ldf"
        My.Computer.FileSystem.CopyFile(
            fileLdf,
            carpetaDestino & nomBD & "_log.ldf",
            Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
            Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)

        'controlarServicio("start", "MSSQL$PCPROG")
        'MsgBox("REGISTRO DE EMPRESA: " & obj.nCargarBD(nomBD, carpetaDestino))
        obj.nCargarBD(nomBD, carpetaDestino)

    End Sub

    Private Sub cargaInicialEstados()
        Try
            For Each row As DataGridViewRow In dgvLista.Rows
                If row.Cells("estado").Value.ToString = "INACTIVO" Then
                    row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(255, 87, 87) '(245, 230, 108)
                ElseIf row.Cells("estado").Value.ToString = "ACTIVO" Then
                    row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(255, 255, 255)
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        realizarBusqueda()
    End Sub

    Private Sub realizarBusqueda()
        Dim data As New DataTable
        Dim dato As String = ""
        dato = txtDato.Text.ToString.Trim()
        If CodigoUsuarioSession = "1" Then
            data = obj.nCrudListarBD("select * from vista_listaEmpresas where nombre like '%" & dato & "%' or ruc like '%" & dato & "%' order by id asc", CadenaConexion)
        Else
            data = obj.nCrudListarBD("select v.id,v.nombre,v.ruc,v.direccion,v.periodo,v.estado from vista_listaEmpresas v inner join usuarios_empresas u on v.id=u.id_empresa where u.id_usuario='" & CodigoUsuarioSession & "' and (v.nombre like '%" & dato & "%' or v.ruc like '%" & dato & "%') and v.id<>'1' order by v.id asc", CadenaConexion)
        End If

        dgvLista.DataSource = data
        cargaInicialEstados()
    End Sub

    Private Sub txtDato_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDato.KeyPress
        On Error Resume Next
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            realizarBusqueda()
        End If
    End Sub

    Private Sub btnAsignarUsuarios_Click(sender As Object, e As EventArgs) Handles btnAsignarUsuarios.Click
        frmTsUsuarios.Show()
    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            txtColor.Text = ColorDialog1.Color.ToArgb
            btnColor.BackColor = ColorDialog1.Color
        End If
    End Sub
End Class
