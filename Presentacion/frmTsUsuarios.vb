Imports Negocio

Public Class frmTsUsuarios
    Dim obj As New nCrud
    Dim ind_carga As Integer = 0
    Dim tipo As String = ""

    Private Function codigoCeldaSeleccionada() As Integer
        Dim c As String
        Try
            Dim f As Integer
            f = dgvUsuarios.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            c = dgvUsuarios.Rows(f).Cells("id").Value.ToString
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function

    Private Sub cargarTipoUsuario()
        Dim tbData As New DataTable
        tbData.Columns.Add("Codigo")
        tbData.Columns.Add("Nombre")
        tbData.Rows.Add(0, "Seleccione")
        Dim tbData2 As DataTable
        Try
            tbData2 = obj.nCrudListarBD("select id ,nombre from perfiles where estado=1 order by nombre asc", CadenaConexion)
            For Each row As DataRow In tbData2.Rows
                tbData.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboTipo
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

    Private Sub cargarUsuarios()
        Dim data As New DataTable
        If CodigoUsuarioSession = 1 Then
            data = obj.nCrudListarBD("select * from [" & BD_MASTER & "].dbo.vista_usuarios order by id asc", CadenaConexion)
        Else
            data = obj.nCrudListarBD("select v.id,v.usuario,v.nombres,v.tipo_u,v.estado from vista_usuarios v " & _
                         "inner join usuarios_empresas u on v.id=u.id_usuario where u.id_empresa='" & CodigoEmpresaSession & "' " & _
                         "union " & _
                         "select v.id,v.usuario,v.nombres,v.tipo_u,v.estado from vista_usuarios v where v.cod_usuario='" & CodigoUsuarioSession & "'", CadenaConexion)
        End If
        dgvUsuarios.DataSource = data
        data = Nothing
        cargaInicialEstados()
    End Sub

    Private Sub cargarEmpresas()
        Dim data As New DataTable
        If CodigoUsuarioSession = 1 Then
            data = obj.nCrudListarBD("select * from vista_empresas order by id_empresa asc", CadenaConexion)
        Else
            data = obj.nCrudListarBD("select * from vista_empresas where id_empresa='" & CodigoEmpresaSession & "' order by id_empresa asc", CadenaConexion)
            ' where id_empresa<>1 
        End If
        dgvEmpresas.DataSource = data

        For Each filaCol As DataGridViewRow In dgvEmpresas.Rows
            ' filaCol.Cells(0).Value = True
        Next

        data = Nothing
        cargaInicialEstados()

    End Sub

    Private Sub frmTsClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTipoUsuario()
        cargarUsuarios()
        cargarEmpresas()
        ind_carga = 1
        cargarDatosUsuario()
        txtDato.Focus()
        txtDato.Select()
        bloquearEntradas()
    End Sub

    Private Sub dgvLista_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvUsuarios.SelectionChanged
        On Error Resume Next
        cargarDatosUsuario()
        'cargarEmpresas()
    End Sub

    Private Sub cargarDatosUsuario()
        If tipo <> "new" Or tipo = "" Then
            Me.Enabled = False
            On Error Resume Next
            Dim sql As String
            sql = "select * from usuarios where id=" & codigoCeldaSeleccionada()
            Dim data As New DataTable
            data = obj.nCrudListarBD(sql, CadenaConexion)
            With data
                txtUsuario.Text = .Rows(0)("usuario").ToString
                txtNombres.Text = .Rows(0)("nombres").ToString
                txtClave.Text = .Rows(0)("clave").ToString
                cboTipo.SelectedValue = .Rows(0)("tipo").ToString

                If .Rows(0)("estado") = "0" Then
                    rbNo.Checked = True
                ElseIf .Rows(0)("estado") = "1" Then
                    rbSi.Checked = True
                End If
            End With

            'cargar empresas asignadas a usuarios
            For Each filaCol As DataGridViewRow In dgvEmpresas.Rows
                filaCol.Cells(0).Value = False
            Next

            Dim dataEmp As New DataTable
            dataEmp = obj.nCrudListarBD("select * from usuarios_empresas where id_usuario='" & codigoCeldaSeleccionada() & "'", CadenaConexion)
            For Each fila As DataGridViewRow In dgvEmpresas.Rows
                For it As Integer = 0 To dataEmp.Rows.Count - 1
                    If fila.Cells("id_empresa").Value = dataEmp.Rows(it)("id_empresa") Then
                        fila.Cells(0).Value = True
                        'fila.Cells(0).ReadOnly = True
                        'Else
                        'fila.Cells(0).Value = False
                    End If
                Next
            Next

            data = Nothing
            Me.Enabled = True
        ElseIf tipo = "new" Then
            txtUsuario.Focus()
        End If
        cargaInicialEstados()
    End Sub

    Private Sub frmTsTipoPago_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            cargarUsuarios()
        End If
    End Sub

    Private Sub txtDato_TextChanged(sender As Object, e As EventArgs) Handles txtDato.TextChanged
        'If txtDato.Text.Length > 2 Then

        'End If
    End Sub

    Private Sub bloquearEntradas()
        txtNombres.Enabled = False
        txtUsuario.Enabled = False
        txtClave.Enabled = False
        cboTipo.Enabled = False
        rbNo.Enabled = False
        rbSi.Enabled = False
        dgvEmpresas.ReadOnly = True
    End Sub

    Private Sub habilitarEntradas()
        gbGrupo.Enabled = True
        txtNombres.Enabled = True
        txtUsuario.Enabled = True
        txtClave.Enabled = True
        cboTipo.Enabled = True
        rbNo.Enabled = True
        rbSi.Enabled = True
        dgvEmpresas.ReadOnly = False
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        gbGrupo.Enabled = True
        habilitarEntradas()
        tipo = "update"
        lblEmpresa.Visible = True
        dgvEmpresas.Visible = True
        dgvEmpresas.Enabled = True
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        habilitarEntradas()
        tipo = "new"
        limpiarEntradas()
        lblEmpresa.Visible = False
        dgvEmpresas.Visible = False
    End Sub

    Private Sub limpiarEntradas()
        txtUsuario.Text = ""
        txtNombres.Text = ""
        txtClave.Text = ""
        rbSi.Checked = True
        txtUsuario.Focus()
        For Each row As DataGridViewRow In dgvEmpresas.Rows
            'If row.Cells(1).Value.ToString = "1" Then
            '    row.Cells(0).Value = True
            'Else
            row.Cells(0).Value = False
            'End If
        Next
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        gbGrupo.Enabled = False
        tipo = ""
        lblEmpresa.Visible = True
        dgvEmpresas.Visible = True
        'cargarDatosCuenta()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim campos As String
        Dim valores As String
        Dim condicion As String
        Dim estado As String
        If rbNo.Checked = True Then
            estado = "0"
        Else
            estado = "1"
        End If

        campos = "usuario@nombres@clave@tipo@estado"
        valores = txtUsuario.Text.ToString & "@" & txtNombres.Text.ToString & "@" & txtClave.Text.ToString & "@" & cboTipo.SelectedValue.ToString & "@" & estado

        Dim rpta As String = ""
        Dim tabla As String = "usuarios"
        Dim tablaE As String = "usuarios_empresas"
        If tipo = "update" Then
            condicion = "id=" & codigoCeldaSeleccionada()
            rpta = obj.nCrudActualizarBD("@", tabla, campos, valores, condicion, CadenaConexion)

            'Eliminar las empresas asignadas al usuario para volver a cargar si hay modificaciones
            'MsgBox("ELIMINACION DE USUARIOS: " & codigoCeldaSeleccionada() & " - " & obj.nEjecutarQueryBD("delete from [" & BD_MASTER & "].dbo." & tablaE & " where id_usuario='" & codigoCeldaSeleccionada() & "'", CadenaConexion))
            'obj.nEjecutarQueryBD("delete from [" & BD_MASTER & "].dbo." & tablaE & " where id_usuario='" & codigoCeldaSeleccionada() & "'", CadenaConexion)

            'Insertamos las empresas seleccionadas al usuario
            For Each filaCol As DataGridViewRow In dgvEmpresas.Rows
                'MsgBox("EMPRESA: " & filaCol.Cells("empresa").Value & "- User: " & codigoCeldaSeleccionada())
                If filaCol.Cells(0).Value = True Then
                    'verificar si el usuario ya está asignado
                    Dim dt As New DataTable
                    dt = obj.nCrudListarBD("select * from [" & BD_MASTER & "].dbo.usuarios_empresas where id_usuario='" & codigoCeldaSeleccionada() & "' and  id_empresa='" & filaCol.Cells(1).Value & "'", CadenaConexion)
                    Dim rptaI As String
                    If dt.Rows.Count = 0 Then
                        rptaI = obj.nCrudInsertarBD("@", "[" & BD_MASTER & "].dbo." & tablaE, "id_empresa@id_usuario", filaCol.Cells(1).Value & "@" & codigoCeldaSeleccionada(), CadenaConexion)
                    End If
                    Dim dataEmp As New DataTable
                    dataEmp = obj.nCrudListarBD("select * from  [" & BD_MASTER & "].dbo.empresas where id='" & filaCol.Cells(1).Value & "'", CadenaConexion)
                    Dim dt2 As New DataTable
                    dt2 = obj.nCrudListarBD("select * from [" & dataEmp.Rows(0)("alias").ToString & "].dbo.usuarios_empresas where id_usuario='" & codigoCeldaSeleccionada() & "' and  id_empresa='" & filaCol.Cells(1).Value & "'", CadenaConexion)
                    Dim rptaI2 As String
                    If dt.Rows.Count = 0 Then
                        rptaI2 = obj.nCrudInsertarBD("@", "[" & dataEmp.Rows(0)("alias").ToString & "].dbo." & tablaE, "id_empresa@id_usuario", filaCol.Cells(1).Value & "@" & codigoCeldaSeleccionada(), CadenaConexion)
                    End If
                End If
            Next


            'AÑADIR EMPRESA-USUARIOS DE LA PLANTILLA A SUS RESPECTIVAS BD'S
            'Dim dataUE As New DataTable
            'dataUE = obj.nCrudListarBD("select * from [" & BD_MASTER & "].dbo.usuarios_empresas where id_usuario='" & codigoCeldaSeleccionada() & "' and id_empresa<>1", CadenaConexion)

            For Each row As DataGridViewRow In dgvEmpresas.Rows
                If row.Cells(0).Value = True Then
                    'MsgBox(dataEmp.Rows(0)("alias").ToString)
                    Dim dt As New DataTable
                    dt = obj.nCrudListarBD("select * from dbo.usuarios_empresas where id_empresa='" & row.Cells("id_empresa").Value.ToString & "' and id_usuario='" & codigoCeldaSeleccionada() & "'", CadenaConexion)
                    If dt.Rows.Count = 0 Then
                        obj.nCrudInsertarBD("@", "dbo.usuarios_empresas", "id_empresa@id_usuario", row.Cells("id_empresa").Value.ToString & "@" & codigoCeldaSeleccionada(), CadenaConexion)
                    End If
                Else
                    obj.nEjecutarQueryBD("delete from dbo.usuarios_empresas where id_usuario='" & codigoCeldaSeleccionada() & "' and id_empresa='" & row.Cells("id_empresa").Value.ToString & "'", CadenaConexion)
                End If
            Next

            'quitar usuarios no marcados
            For Each filaCol As DataGridViewRow In dgvEmpresas.Rows
                If filaCol.Cells(1).Value.ToString <> "1" Then
                    If filaCol.Cells(0).Value = False Then
                        Dim dataEmp As New DataTable
                        dataEmp = obj.nCrudListarBD("select * from  [" & BD_MASTER & "].dbo.empresas where id='" & filaCol.Cells(1).Value & "'", CadenaConexion)
                        obj.nEjecutarQueryBD("delete from [" & dataEmp.Rows(0)("alias").ToString & "].dbo.usuarios_empresas where id_usuario='" & codigoCeldaSeleccionada() & "' and id_empresa='" & filaCol.Cells(1).Value & "'", CadenaConexion)
                    End If
                End If
            Next

            'asignar usuarios a las demas empresas
            For Each row As DataGridViewRow In dgvEmpresas.Rows
                If row.Cells(0).Value = True Then
                    Dim dataEmpS As New DataTable
                    dataEmpS = obj.nCrudListarBD("select * from  [" & BD_MASTER & "].dbo.empresas", CadenaConexion)
                    For Each lista As DataRow In dataEmpS.Rows
                        Dim dataEmp As New DataTable
                        dataEmp = obj.nCrudListarBD("select * from  [" & BD_MASTER & "].dbo.empresas where id='" & lista.Item("id").ToString & "'", CadenaConexion)

                        Dim dtUser As New DataTable
                        dtUser = obj.nCrudListarBD("select * from [" & dataEmp.Rows(0)("alias").ToString & "].dbo.usuarios where id='" & codigoCeldaSeleccionada() & "'", CadenaConexion)
                        If dtUser.Rows.Count > 0 Then
                            Dim dt As New DataTable
                            dt = obj.nCrudListarBD("select * from [" & dataEmp.Rows(0)("alias").ToString & "].dbo.usuarios_empresas where id_empresa='" & row.Cells("id_empresa").Value.ToString & "' and  id_usuario='" & codigoCeldaSeleccionada() & "'", CadenaConexion)
                            If dt.Rows.Count = 0 Then
                                obj.nCrudInsertarBD("@", "[" & dataEmp.Rows(0)("alias").ToString & "].dbo.usuarios_empresas", "id_empresa@id_usuario", row.Cells("id_empresa").Value.ToString & "@" & codigoCeldaSeleccionada(), CadenaConexion)
                            End If
                        Else
                            Dim query As String
                            query = "usp_registrarUsuario '" & txtUsuario.Text.ToString & "','" & txtNombres.Text.ToString & "','" & txtClave.Text.ToString & "','" & cboTipo.SelectedValue.ToString & "','" & CodigoUsuarioSession & "';"
                            obj.nEjecutarConsultaEnBD(query, dataEmp.Rows(0)("alias").ToString)
                        End If
                    Next
                End If
            Next
            If CodigoUsuarioSession <> 1 Then
                Dim dt As New DataTable
                dt = obj.nCrudListarBD("select * from [" & BD_MASTER & "].dbo.usuarios where id='" & codigoCeldaSeleccionada() & "'", CadenaConexion)
                If dt.Rows.Count = 0 Then
                    Dim query As String
                    query = "usp_registrarUsuario '" & txtUsuario.Text.ToString & "','" & txtNombres.Text.ToString & "','" & txtClave.Text.ToString & "','" & cboTipo.SelectedValue.ToString & "','" & CodigoUsuarioSession & "';"
                    obj.nEjecutarConsultaEnBD(query, BD_MASTER)
                End If
            End If
        ElseIf tipo = "new" Then


            'If CodigoUsuarioSession <> 1 And CodigoEmpresaSession <> 1 Then
            '    Dim query As String
            '    query = "usp_registrarUsuario '" & txtUsuario.Text.ToString & "','" & txtNombres.Text.ToString & "','" & txtClave.Text.ToString & "','" & cboTipo.SelectedValue.ToString & "','" & CodigoUsuarioSession & "';"
            '    obj.nEjecutarConsultaEnBD(query, BD_MASTER)

            '    Dim dataUA1 As New DataTable
            '    dataUA1 = obj.nCrudListarBD("select * from [" & BD_MASTER & "].dbo.usuarios where estado=1 order by id asc", CadenaConexion)
            '    For Each row As DataRow In dataUA1.Rows
            '        Dim query1 As String
            '        query1 = "INSERT INTO [dbo].[usuarios] ([id],[usuario],[nombres],[clave],[tipo],[estado],[cod_usuario])"
            '        query1 += " VALUES ('" & row.Item("id").ToString & "','" & row.Item("usuario").ToString & "','" & row.Item("nombres").ToString & "','" & row.Item("clave").ToString & "','" & row.Item("tipo").ToString & "','" & row.Item("estado").ToString & "','" & row.Item("cod_usuario").ToString & "');"
            '        rpta = obj.nEjecutarQueryBD(query1, CadenaConexion)
            '    Next
            'Else
            Dim query1 As String
            query1 = "usp_registrarUsuario '" & txtUsuario.Text.ToString & "','" & txtNombres.Text.ToString & "','" & txtClave.Text.ToString & "','" & cboTipo.SelectedValue.ToString & "','" & CodigoUsuarioSession & "';"
            rpta = obj.nEjecutarConsultaEnBD(query1, BD_MASTER)
            If CodigoEmpresaSession <> 1 Then
                Dim data As New DataTable
                data = obj.nCrudListarBD("select top 1 * from [" & BD_MASTER & "].[dbo].usuarios order by id desc", CadenaConexion)
                Dim dataEmp As New DataTable
                dataEmp = obj.nCrudListarBD("select * from [" & BD_MASTER & "].dbo.empresas where id='" & CodigoEmpresaSession & "'", CadenaConexion)
                Dim dtUser As New DataTable
                dtUser = obj.nCrudListarBD("select * from [" & dataEmp.Rows(0)("alias").ToString & "].[dbo].usuarios where id='" & data.Rows(0)("id").ToString & "'", CadenaConexion)
                If dtUser.Rows.Count = 0 Then
                    query1 = "INSERT INTO [dbo].[usuarios] ([id],[usuario],[nombres],[clave],[tipo],[estado],[cod_usuario])"
                    query1 += " VALUES ('" & data.Rows(0)("id").ToString & "','" & data.Rows(0)("usuario").ToString & "','" & data.Rows(0)("nombres").ToString & "','" & data.Rows(0)("clave").ToString & "','" & data.Rows(0)("tipo").ToString & "','" & data.Rows(0)("estado").ToString & "','" & CodigoUsuarioSession & "');"
                    obj.nEjecutarConsultaEnBD(query1, dataEmp.Rows(0)("alias").ToString)
                End If
            End If

            ''If CodigoUsuarioSession = 1 Then
            Dim dtUs As New DataTable
            dtUs = obj.nCrudListarBD("select top 1 * from [" & BD_MASTER & "].dbo.usuarios where estado=1 order by id desc", CadenaConexion)
            For Each filaCol As DataGridViewRow In dgvEmpresas.Rows
                Dim dataEmp As New DataTable
                dataEmp = obj.nCrudListarBD("select * from [" & BD_MASTER & "].dbo.empresas where id='" & filaCol.Cells("id_empresa").Value & "'", CadenaConexion)
                Dim data As New DataTable
                data = obj.nCrudListarBD("select * from [" & dataEmp.Rows(0)("alias").ToString & "].[dbo].usuarios where id='" & dtUs.Rows(0)("id").ToString & "'", CadenaConexion)
                If data.Rows.Count = 0 Then
                    query1 = "INSERT INTO [dbo].[usuarios] ([id],[usuario],[nombres],[clave],[tipo],[estado],[cod_usuario])"
                    query1 += " VALUES ('" & dtUs.Rows(0)("id").ToString & "','" & dtUs.Rows(0)("usuario").ToString & "','" & dtUs.Rows(0)("nombres").ToString & "','" & dtUs.Rows(0)("clave").ToString & "','" & dtUs.Rows(0)("tipo").ToString & "','" & dtUs.Rows(0)("estado").ToString & "','" & dtUs.Rows(0)("cod_usuario").ToString & "');"
                    obj.nEjecutarConsultaEnBD(query1, dataEmp.Rows(0)("alias").ToString)
                End If
                ''registrar el usuario creado en todas las empresas pero solo a las bd's demo
                'Dim dataDemo As New DataTable
                'dataDemo = obj.nCrudListarBD("select * from [" & dataEmp.Rows(0)("alias").ToString & "].[dbo].usuarios_empresas where id_usuario='" & dtUs.Rows(0)("id").ToString & "' and id_empresa='1'", CadenaConexion)
                'If dataDemo.Rows.Count = 0 Then
                '    Dim queryUpd As String
                '    queryUpd = "insert usuarios_empresas (id_empresa,id_usuario) values ('1','" & dtUs.Rows(0)("id").ToString & "')"
                '    obj.nEjecutarConsultaEnBD(queryUpd, dataEmp.Rows(0)("alias").ToString)
                'End If
            Next
            ''End If
            ''End If

            'Dim dataUA As New DataTable
            'dataUA = obj.nCrudListarBD("select * from [" & BD_MASTER & "].dbo.usuarios where estado=1 order by id asc", CadenaConexion)
            'For Each row As DataRow In dataUA.Rows
            '    Dim query1 As String
            '    'VERIFICAR SI EXISTE LOS USUARIOS EN LA NUEVA BD
            '    Dim data As New DataTable
            '    data = obj.nCrudListarBD("select * from usuarios where id='" & row.Item("id").ToString & "'", CadenaConexion)
            '    If data.Rows.Count = 0 Then
            '        query1 = "INSERT INTO [dbo].[usuarios] ([id],[usuario],[nombres],[clave],[tipo],[estado],[cod_usuario])"
            '        query1 += " VALUES ('" & row.Item("id").ToString & "','" & row.Item("usuario").ToString & "','" & row.Item("nombres").ToString & "','" & row.Item("clave").ToString & "','" & row.Item("tipo").ToString & "','" & row.Item("estado").ToString & "','" & row.Item("cod_usuario").ToString & "');"
            '        rpta = obj.nEjecutarQueryBD(query1, CadenaConexion)
            '    End If

            '    query1 = ""

            '    'For Each fila As DataGridViewRow In dgvEmpresas.Rows
            '    '    'VERIFICAR SI EXISTE LOS USUARIOS
            '    '    Dim dtUs As New DataTable
            '    '    dtUs = obj.nCrudListarBD("select * from usuarios_empresas where id_usuario='" & row.Item("id").ToString & "' and id_empresa='" & fila.Cells("id_empresa").Value & "'", CadenaConexion)
            '    '    If dtUs.rows.count = 0 Then
            '    '        query1 = "INSERT INTO [dbo].[usuarios_empresas] ([id_empresa],[id_usuario])"
            '    '        query1 += " VALUES ('" & fila.Cells("id_empresa").Value & "','" & row.Item("id").ToString & "');"
            '    '        rpta = obj.nEjecutarQueryBD(query1, CadenaConexion)
            '    '    End If
            '    'Next
            'Next

            'Dim dataU As New DataTable
            'dataU = obj.nCrudListarBD("select * from usuarios where estado=1 order by id desc", CadenaConexion)

            ''Eliminar las empresas asignadas al usuario para volver a cargar si hay modificaciones
            ''obj.nEjecutarQueryBD("delete from " & tablaE & " where id_usuario='" & dataU.Rows(0)("id").ToString & "' and id_empresa<>'1'", CadenaConexion)
            'limpiarEntradas()
            ''Insertamos las empresas seleccionadas al usuario
            'For Each filaCol As DataGridViewRow In dgvEmpresas.Rows
            '    If filaCol.Cells(0).Value = True Then
            '        'MsgBox(filaCol.Cells(2).Value)
            '        'Dim rptaE As String
            '        'rptaE = obj.nCrudInsertarBD("@", tablaE, "id_empresa@id_usuario", filaCol.Cells(1).Value & "@" & dataU.Rows(0)("id").ToString, CadenaConexion)
            '        If filaCol.Cells(1).Value > 1 Then
            '            Dim dataEmp As New DataTable
            '            dataEmp = obj.nCrudListarBD("select * from empresas where id='" & filaCol.Cells(1).Value & "'", CadenaConexion)

            '            Dim dEmpresa As New DataTable
            '            dEmpresa = obj.nCrudListarBD("select * from [" & dataEmp.Rows(0)("alias").ToString & "].[dbo].[empresas] where ruc='" & dataEmp.Rows(0)("ruc").ToString & "'", CadenaConexion)

            '            'Dim queryLimpiar, queryInst As String
            '            'queryLimpiar = "truncate table [TICOM].[dbo].[cuenta_contable]"
            '            'queryInst = "insert into [" & dEmpresa.Rows(0)("alias") & "].[dbo].[cuenta_contable] select * from [" & dEmpresa.Rows(0)("alias").ToString & "].[dbo].[cuenta_contable]"

            '            Dim query As String
            '            query = "usp_registrarUsuario '" & txtUsuario.Text.ToString & "','" & txtNombres.Text.ToString & "','" & txtClave.Text.ToString & "','" & cboTipo.SelectedValue.ToString & "','" & CodigoUsuarioSession & "';"
            '            obj.nEjecutarConsultaEnBD(query, dataEmp.Rows(0)("alias").ToString)
            '            'MsgBox("REGISTRAR USUARIO: " & )

            '            Dim queryElim As String
            '            queryElim = "delete from usuarios_empresas where id_usuario='" & codigoCeldaSeleccionada() & "' and id_empresa<>'1'"
            '            'obj.nEjecutarConsultaEnBD(queryElim, dataEmp.Rows(0)("alias").ToString)
            '            'MsgBox("ELIMINACION DE EMPRESAS POR USUARIO: " & obj.nEjecutarConsultaEnBD(dataEmp.Rows(0)("alias").ToString, queryElim))

            '            Dim queryUpd As String
            '            queryUpd = "insert usuarios_empresas (id_empresa,id_usuario) values ('" & filaCol.Cells(1).Value & "','" & codigoCeldaSeleccionada() & "')"
            '            obj.nEjecutarConsultaEnBD(queryUpd, dataEmp.Rows(0)("alias").ToString)
            '            'MsgBox("INSERCION DE EMPRESAS POR USUARIO: " & obj.nEjecutarConsultaEnBD(dataEmp.Rows(0)("alias").ToString, queryUpd))
            '            'MsgBox(rptaE)
            '        End If
            '    End If
            'Next
        End If

        If rpta = "ok" Then
            cargarEmpresas()
            limpiarEntradas()
            tipo = ""
            gbGrupo.Enabled = False
            txtDato.Focus()
            lblEmpresa.Visible = True
            dgvEmpresas.Visible = True
            dgvEmpresas.Enabled = True
            btnBuscar.PerformClick()
            MessageBox.Show("El proceso se ha realizado con éxito.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            MessageBox.Show(rpta, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub cargaInicialEstados()
        Try
            For Each row As DataGridViewRow In dgvUsuarios.Rows
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
        limpiarEntradas()
        Dim data As New DataTable
        Dim dato As String = ""
        dato = txtDato.Text.ToString.Trim()
        If CodigoUsuarioSession = 1 Then
            data = obj.nCrudListarBD("select * from vista_usuarios order by id asc", CadenaConexion)
        Else
            'or v.id='" & CodigoUsuarioSession & "'
            'or u.cod_usuario='" & CodigoUsuarioSession & "'
            data = obj.nCrudListarBD("select v.id,v.usuario,v.nombres,v.tipo_u,v.estado from vista_usuarios v " & _
                                     "inner join usuarios_empresas u on v.id=u.id_usuario where u.id_empresa='" & CodigoEmpresaSession & "' " & _
                                     "union " & _
                                     "select v.id,v.usuario,v.nombres,v.tipo_u,v.estado from vista_usuarios v where v.cod_usuario='" & CodigoUsuarioSession & "'", CadenaConexion)
        End If
        dgvUsuarios.DataSource = data
        cargaInicialEstados()
    End Sub

    Private Sub txtDato_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtDato.TextChanged
        On Error Resume Next
        'If e.KeyChar = Convert.ToChar(Keys.Enter) Then
        realizarBusqueda()
        'End If
    End Sub
End Class

