Imports Negocio
Imports Entidades

Public Class frmRegistrarSalidasCajaChica

    Dim objCrud As New nCrud
    Dim objTDA As New nTipoDocumentoAsiento
    Dim idTipoOperacion As Integer = 1

    Private Sub cargarTipoDocumento()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = objTDA.nListarCuentasSegunTipoAsientoBD(idTipoOperacion, CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(2).ToString.ToUpper)
            Next
            With cboTipoDocumento
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Documentos")
        End Try
    End Sub
    Private Sub cargarTipoSalidas()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListarBD("select * from tipo_salidas where estado=1 order by id asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString.ToUpper)
            Next
            With cboTipoSalida
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista Tipo Salidas")
        End Try
    End Sub
    Private Sub cargarCaja()
        Dim dataAnio As New DataTable
        dataAnio.Columns.Add("codigo")
        dataAnio.Columns.Add("descripcion")
        dataAnio.Rows.Add(0, "SELECCIONE")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListarBD("select * from caja_configuracion where tipo='CHICA' and estado=1 order by id asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                dataAnio.Rows.Add(row.Item(0).ToString, row.Item("descripcion").ToString)
            Next
            With cboCaja
                .DataSource = dataAnio
                .ValueMember = "codigo"
                .DisplayMember = "descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar las cajas")
        End Try
    End Sub
    Private Sub frmCajaChicaRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCaja()
        cargarTipoDocumento()
        cargarTipoSalidas()

    End Sub

    Private Sub txtRuc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRuc.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            With frmEscogerCliente
                .formInicio = "cajaChica"
                .datoCliente = txtRuc.Text.Trim
                .txtDescripcion.Text = .datoCliente
                .realizarBusqueda()
                .ShowDialog()
            End With
        End If
    End Sub
    Private Sub txtRazonSocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRazonSocial.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            buscarProveedor()
        End If
    End Sub
    Private Sub buscarProveedor()
        If txtRuc.Focused = True Then
            With frmEscogerCliente
                .formInicio = "cajaChica"
                .datoCliente = txtRuc.Text.Trim
                .txtDescripcion.Text = .datoCliente
                .realizarBusqueda()
                .ShowDialog()
            End With
        ElseIf txtRazonSocial.Focused = True Then
            With frmEscogerCliente
                .formInicio = "cajaChica"
                .datoCliente = txtRazonSocial.Text.Trim
                .txtDescripcion.Text = .datoCliente
                .realizarBusqueda()
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cboTipoSalida.Focus()
        End If
    End Sub
    Private Sub cboDH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboTipoSalida.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtGlosa.Focus()
        End If
    End Sub
    Private Sub txtGlosa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGlosa.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtMonto.Focus()
        End If
    End Sub
    Private Sub btnFinalizar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnFinalizar.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'guardarPagos()
        End If
    End Sub

    Private Sub realizarProceso()
        Dim entiCaja As New CajaEntity
        With entiCaja
            .id_tipo_caja = cboCaja.SelectedValue.ToString
            .id_tipo_salida = cboTipoSalida.SelectedValue.ToString
            .id_documento = cboTipoDocumento.SelectedValue.ToString
            .serie = txtSerie.Text.Trim
            .numero = txtNumero.Text.Trim
            .dni_ruc = txtRuc.Text.Trim
            .cliente = txtRazonSocial.Text.Trim
            .monto = txtMonto.Text.Trim
            .glosa = txtGlosa.Text.Trim
            .estado = "1"
        End With
        Dim rpta As String = ""
        rpta = objCrud.registrarDetalleCajaBD(entiCaja, CadenaConexion)


        'Registrando asientos de la caja
        Dim dataSalida As New DataTable
        dataSalida = objCrud.nCrudListarBD("select * from tipo_salidas where id='" & cboTipoSalida.SelectedValue.ToString & "'", CadenaConexion)
        Dim data As New DataTable
        data = objCrud.nCrudListarBD("select id from cajas order by id desc", CadenaConexion)
        Dim dataCaja As New DataTable
        dataCaja = objCrud.nCrudListarBD("select * from caja_configuracion where id='" & cboCaja.SelectedValue.ToString & "'", CadenaConexion)
        With entiCaja
            .id_caja = Integer.Parse(data.Rows(0)("id").ToString)
            .glosa = txtGlosa.Text.Trim
            .cuenta = dataSalida.Rows(0)("cuenta").ToString
            .debe = txtMonto.Text.Trim
            .haber = "0.00"
        End With
        'MsgBox(dataSalida.Rows(0)("cuenta").ToString & "-" & objCrud.registrarAsientosCaja(entiCaja))
        objCrud.registrarAsientosCajaBD(entiCaja, CadenaConexion)
        With entiCaja
            .id_caja = Integer.Parse(data.Rows(0)("id").ToString)
            .glosa = txtGlosa.Text.Trim
            .cuenta = dataCaja.Rows(0)("contra_cuenta").ToString
            .debe = "0.00"
            .haber = txtMonto.Text.Trim
        End With
        'MsgBox(dataCaja.Rows(0)("contra_cuenta").ToString & "-" & objCrud.registrarAsientosCaja(entiCaja))
        objCrud.registrarAsientosCajaBD(entiCaja, CadenaConexion)
        With entiCaja
            .id_caja = Integer.Parse(data.Rows(0)("id").ToString)
            .glosa = txtGlosa.Text.Trim
            .cuenta = dataCaja.Rows(0)("contra_cuenta").ToString
            .debe = txtMonto.Text.Trim
            .haber = "0.00"
        End With
        'MsgBox(dataCaja.Rows(0)("contra_cuenta").ToString & "-" & objCrud.registrarAsientosCaja(entiCaja))
        objCrud.registrarAsientosCajaBD(entiCaja, CadenaConexion)
        With entiCaja
            .id_caja = Integer.Parse(data.Rows(0)("id").ToString)
            .glosa = txtGlosa.Text.Trim
            .cuenta = dataCaja.Rows(0)("cuenta").ToString
            .debe = "0.00"
            .haber = txtMonto.Text.Trim
        End With
        'MsgBox(dataCaja.Rows(0)("cuenta").ToString & "-" & objCrud.registrarAsientosCaja(entiCaja))
        objCrud.registrarAsientosCajaBD(entiCaja, CadenaConexion)

        If rpta = "ok" Then
            MsgBox("¡Asientos registrados con éxito!")
        Else
            MsgBox("Error al registrar: " & vbCrLf & rpta)
        End If
        frmListaCajaChica.realizarConsulta()
        Me.Dispose()
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        realizarProceso()
    End Sub

End Class