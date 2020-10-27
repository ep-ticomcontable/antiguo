Imports Negocio
Imports Entidades

Public Class frmListaPersonal
    Dim objCrud As New nCrud
    Dim iCarga As Integer = 0
    Dim tipo As String = ""

    Private Sub cargarAsignacionFamiliar()
        Dim data As New DataTable
        With data.Columns
            .Add("valor")
            .Add("descripcion")
        End With
        data.Rows.Add("NO", "NO")
        data.Rows.Add("SI", "SI")
        With cboAsignacion
            .DataSource = data
            .ValueMember = "valor"
            .DisplayMember = "descripcion"
        End With
    End Sub
    Private Sub cargarSistemaPensiones()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListarBD("select * from sistema_pensiones where estado=1 and tipo<>'EMPRESA' order by id asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(2).ToString)
            Next
            With cboPension
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Sistema de Pensiones")
        End Try
    End Sub
    Private Sub cargarCargosOcupacion()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListarBD("select * from cargos_ocupacion where estado=1 order by descripcion asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboCargo
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Cargos/Ocupaciones")
        End Try
    End Sub
    Private Sub cargarMonedas()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListarBD("select id,codigo,descripcion from tipo_moneda where estado=1 order by codigo asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboMoneda
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
                .SelectedValue = 115
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Monedas")
        End Try
    End Sub
    Private Sub frmListaPersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLista.RowTemplate.Height = 30
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        cargarAsignacionFamiliar()
        cargarSistemaPensiones()
        cargarCargosOcupacion()
        cargarMonedas()
        iCarga = 1
        cargarPersonal()
    End Sub

    Private Sub cargarPersonal()
        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from vista_listaPersonal", CadenaConexion)
        dgvLista.DataSource = dt
    End Sub

    Private Sub limpiarEntradas()
        txtCuspp.Text = ""
        txtNombres.Text = ""
        txtApePat.Text = ""
        txtApeMat.Text = ""
        txtFecha.Text = ""
        txtSueldoBasico.Text = "0.00"
        cboAsignacion.Text = "NO"
        txtValorAsignacion.Text = "0.00"
        cboPension.SelectedValue = 1
        txtPorcentajePension.Text = "0.00"
        txtTotalRemuneracion.Text = "0.00"
        txtDni.Text = ""
        txtDni.Select()
        txtDni.Focus()
    End Sub

    Private Sub dgvLista_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLista.SelectionChanged
        On Error Resume Next
        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from personal where cod_dni='" & dgvLista.Rows(f).Cells("cod_dni").Value.ToString & "'", CadenaConexion)
        With dt
            txtCuspp.Text = .Rows(0)("cuspp").ToString
            txtDni.Text = .Rows(0)("cod_dni").ToString
            txtNombres.Text = .Rows(0)("nombres").ToString
            txtApePat.Text = .Rows(0)("ape_pat").ToString
            txtApeMat.Text = .Rows(0)("ape_mat").ToString
            txtFecha.Text = .Rows(0)("fec_ingreso").ToString
            cboCargo.SelectedValue = .Rows(0)("id_cargo").ToString
            cboMoneda.SelectedValue = .Rows(0)("id_moneda").ToString
            txtSueldoBasico.Text = .Rows(0)("sueldo_basico").ToString
            cboAsignacion.SelectedValue = .Rows(0)("asignacion").ToString
            txtValorAsignacion.Text = .Rows(0)("valor_asignacion").ToString
            txtHijos.Value = .Rows(0)("num_hijos").ToString
            cboPension.SelectedValue = .Rows(0)("id_pension").ToString
            txtPorcentajePension.Text = .Rows(0)("porc_pension").ToString
            txtDescuentos.Text = .Rows(0)("descuentos").ToString
            txtTotalRemuneracion.Text = .Rows(0)("total_remuneracion").ToString
        End With
    End Sub

    Private Sub txtSueldoBasico_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSueldoBasico.Leave
        txtSueldoBasico.Text = Format(CType(txtSueldoBasico.Text, Decimal), "###0.00")
    End Sub
    Private Sub txtPorcentajeAsignacion_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValorAsignacion.Leave
        txtValorAsignacion.Text = Format(CType(txtValorAsignacion.Text, Decimal), "###0.00")
    End Sub
    Private Sub txtPorcentajePension_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPorcentajePension.Leave
        txtPorcentajePension.Text = Format(CType(txtPorcentajePension.Text, Decimal), "###0.00")
    End Sub
    Private Sub txtDescuentos_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescuentos.Leave
        txtDescuentos.Text = Format(CType(txtDescuentos.Text, Decimal), "###0.00")
    End Sub
    Private Sub txtTotalRemuneracion_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalRemuneracion.Leave
        txtTotalRemuneracion.Text = Format(CType(txtTotalRemuneracion.Text, Decimal), "###0.00")
    End Sub
    Private Sub cboAsignacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAsignacion.SelectedIndexChanged
        If iCarga = 1 Then
            If cboAsignacion.SelectedValue.ToString = "SI" Then
                txtValorAsignacion.Enabled = True
                txtHijos.Value = 1
                txtHijos.Enabled = True
                txtValorAsignacion.Focus()
            Else
                txtValorAsignacion.Enabled = False
                txtHijos.Value = 0
                txtHijos.Enabled = False
                txtValorAsignacion.Text = "0.00"
            End If
        End If
    End Sub

    Private Sub cboPension_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPension.SelectedIndexChanged
        If iCarga = 1 Then
            If cboPension.SelectedValue <> 0 Then
                Dim dt As New DataTable
                dt = objCrud.nCrudListarBD("select * from sistema_pensiones where estado=1 and id='" & cboPension.SelectedValue.ToString & "'", CadenaConexion)
                txtValorAsignacion.Enabled = True
                txtPorcentajePension.Text = dt.Rows(0)("porcentaje").ToString
            Else
                txtValorAsignacion.Enabled = False
                txtPorcentajePension.Text = "0.00"
            End If
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        tipo = "nuevo"
        limpiarEntradas()
        gbDatos.Enabled = True
        btnModificar.Enabled = False
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        tipo = "modificar"
        gbDatos.Enabled = True
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        Dim objPer As New nPersonal
        Dim entiPer As New PersonalEntity
        With entiPer
            If dgvLista.Rows.Count > 0 Then
                Dim f As Integer
                f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
                .id = dgvLista.Rows(f).Cells("id").Value.ToString
            End If
            .cuspp = txtCuspp.Text.Trim
            .cod_dni = txtDni.Text.Trim
            .nombres = txtNombres.Text.Trim
            .ape_pat = txtApePat.Text.Trim
            .ape_mat = txtApeMat.Text.Trim
            .fec_ingreso = Date.Parse(txtFecha.Text.Trim)
            .id_cargo = cboCargo.SelectedValue.ToString
            .id_moneda = cboMoneda.SelectedValue.ToString
            .sueldo_basico = txtSueldoBasico.Text.Trim
            .asignacion = cboAsignacion.SelectedValue.ToString
            .valor_asignacion = txtValorAsignacion.Text.Trim
            .num_hijos = txtHijos.Value
            .id_pension = cboPension.SelectedValue.ToString
            .porc_pension = txtPorcentajePension.Text.Trim
            .descuentos = txtDescuentos.Text.Trim
            .total_remuneracion = txtTotalRemuneracion.Text.Trim
            .fec_registro = DateTime.Now.ToString("dd/MM/yyyy")
            .estado = "1"
        End With
        Dim rpta As String = ""
        If tipo = "nuevo" Then
            rpta = objPer.registrarPersonal(entiPer, CadenaConexion)
            If rpta = "ok" Then
                MsgBox("REGISTRO DE PERSONAL REALIZADO CON ÉXITO")
                limpiarEntradas()
                gbDatos.Enabled = False
                btnModificar.Enabled = True
            Else
                MsgBox("ERROR REGISTRO: " & rpta)
            End If

        ElseIf tipo = "modificar" Then
            rpta = objPer.actualizarPersonal(entiPer, CadenaConexion)
            If rpta = "ok" Then
                MsgBox("ACTUALIZACIÓN DE PERSONAL REALIZADA CON ÉXITO")
                gbDatos.Enabled = False
            Else
                MsgBox("ERROR ACTUALIZACIÓN: " & rpta)
            End If
        End If
        cargarPersonal()
    End Sub

    Private Sub txtSueldoBasico_TextChanged(sender As Object, e As EventArgs) Handles txtSueldoBasico.TextChanged
        If iCarga = 1 Then
            If txtSueldoBasico.Text.Trim.Length > 0 Then
                calcularPagos()
            Else
                txtSueldoBasico.Text = 0
            End If
        End If
    End Sub

    Private Sub txtValorAsignacion_TextChanged(sender As Object, e As EventArgs) Handles txtValorAsignacion.TextChanged
        If iCarga = 1 Then
            If txtValorAsignacion.Text.Trim.Length > 0 Then
                calcularPagos()
            Else
                txtValorAsignacion.Text = 0
            End If
        End If
    End Sub

    Private Sub txtDescuentos_TextChanged(sender As Object, e As EventArgs) Handles txtDescuentos.TextChanged
        If iCarga = 1 Then
            If txtDescuentos.Text.Trim.Length > 0 Then
                calcularPagos()
            Else
                txtDescuentos.Text = 0
            End If
        End If
    End Sub

    Private Sub txtPorcentajePension_TextChanged(sender As Object, e As EventArgs) Handles txtPorcentajePension.TextChanged
        If iCarga = 1 Then
            If txtPorcentajePension.Text.Trim.Length > 0 Then
                calcularPagos()
            Else
                txtPorcentajePension.Text = 0
            End If
        End If
    End Sub

    Private Sub txtHijos_ValueChanged(sender As Object, e As EventArgs) Handles txtHijos.ValueChanged
        If iCarga = 1 Then
            If txtHijos.Text.Trim.Length > 0 Then
                calcularPagos()
            Else
                txtHijos.Value = 0
            End If
        End If
    End Sub
    Private Sub calcularPagos()
        If txtSueldoBasico.Text.Trim.Length > 0 And Decimal.Parse(txtSueldoBasico.Text) > 0 And Decimal.Parse(txtValorAsignacion.Text) >= 0 And Decimal.Parse(txtPorcentajePension.Text) >= 0 And Decimal.Parse(txtDescuentos.Text) >= 0 Then
            '(Decimal.Parse(txtSueldoBasico.Text.Trim) * Decimal.Parse(txtPorcentajeAsignacion.Text.Trim) / 100) + (Decimal.Parse(txtSueldoBasico.Text.Trim) * Decimal.Parse(txtPorcentajePension.Text.Trim) / 100) - Decimal.Parse(txtDescuentos.Text.Trim)
            Dim total1, total2 As Decimal
            total1 = Decimal.Parse(txtSueldoBasico.Text) + (Decimal.Parse(txtValorAsignacion.Text) * Integer.Parse(txtHijos.Value.ToString))
            total2 = total1 - (total1 * Decimal.Parse(txtPorcentajePension.Text.Trim) / 100)
            txtTotalRemuneracion.Text = Decimal.Round(total2, 2) - Decimal.Parse(txtDescuentos.Text)
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnModificar.Enabled = True
        gbDatos.Enabled = False
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If iCarga = 1 Then
            cargarPersonal()
        End If
    End Sub

End Class