Imports Negocio
Imports Entidades
Imports Utilitarios
Public Class frmGirarCheque
    Dim obj As New nCrud
    Dim ind_carga As Integer = 0
    Dim tipo As String = ""
    Public tipoAbono As String = ""
    Public valMoneda As String = ""

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

#Region "Carga de Combos"
    Private Sub cargarBancos()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "SELECCIONE")
        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select * from bancos where estado=1 order by nombre asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboBancos
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar los usuarios")
        End Try
    End Sub
    Private Sub cargarMonedas()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "SELECCIONE")
        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select * from tipo_moneda where estado=1 order by codigo asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, "(" & row.Item(1).ToString & ") " & row.Item(2).ToString)
            Next
            With cboMoneda
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar los usuarios")
        End Try
    End Sub
#End Region
    Public Sub redimensionar()
        gbGrupo.Visible = False
        gbGrupo.Location = New Point(12, 108)
        dgvLista.Height = 250
        btnModificar.Location = New Point(12, 352)
        btnNuevo.Location = New Point(113, 352)
        btnCancelar.Location = New Point(488, 352)
        btnGuardar.Location = New Point(601, 352)
        Me.Height = 430
    End Sub
    Public Sub redimensionarOrigen()
        gbGrupo.Visible = True
        gbGrupo.Location = New Point(12, 281)
        dgvLista.Height = 179
        btnModificar.Location = New Point(12, 513)
        btnNuevo.Location = New Point(113, 513)
        btnCancelar.Location = New Point(488, 513)
        btnGuardar.Location = New Point(601, 513)
        Me.Height = 590
    End Sub
    Public Sub cargarDatosAbono()
        If tipoAbono = "compra" Then
            gbGrupo.Enabled = True
            tipo = "new"
            limpiarEntradas()
            btnElegirCheque.Visible = True
            txtMonto.Text = frmAbonoComprobanteCompras.txtMonto.Text.Trim
            txtGlosa.Text = frmAbonoComprobanteCompras.lblRazonNombre.Text
            mostrarNomenclatura()
        End If
    End Sub
    Private Sub cargarDatos()
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from vista_chequesGirados order by id asc", CadenaConexion)
        dgvLista.DataSource = data
        data = Nothing
        cargaInicialEstados()
    End Sub
    Private Sub frmTsClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLista.RowTemplate.Height = 30
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        cargarDatos()
        cargarBancos()
        cargarMonedas()
        ind_carga = 1
        txtDato.Focus()
        txtDato.Select()
    End Sub
    Private Sub dgvLista_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLista.SelectionChanged
        cargarDatosCuenta()
    End Sub
    Private Sub cargarDatosCuenta()
        'If tipo <> "new" Or tipo = "" Then
        Me.Enabled = False
        On Error Resume Next
        Dim sql As String
        sql = "select * from vista_valoresChequeGirado where id=" & codigoCeldaSeleccionada()
        Dim data As New DataTable
        data = obj.nCrudListarBD(sql, CadenaConexion)
        With data
            cboBancos.SelectedValue = .Rows(0)("id_banco").ToString
            cboMoneda.SelectedValue = .Rows(0)("id_moneda").ToString
            txtCuenta.Text = .Rows(0)("cuenta").ToString
            txtMonto.Text = .Rows(0)("monto").ToString
            txtNumero.Text = .Rows(0)("numero").ToString
            txtGlosa.Text = .Rows(0)("glosa").ToString
            txtNomenclatura.Text = .Rows(0)("nomenclatura").ToString
            dtFecha.Value = .Rows(0)("fec_emision").ToString
            dtDesde.Value = .Rows(0)("fec_pago").ToString
            If .Rows(0)("estado") = "0" Then
                rbNo.Checked = True
            ElseIf .Rows(0)("estado") = "1" Then
                rbSi.Checked = True
            End If
        End With
        data = Nothing
        Me.Enabled = True
        'ElseIf tipo = "new" Then
        'txtCuentaCorriente.Focus()
        'End If
        cargaInicialEstados()
    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = obj.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function
    Private Sub frmTsTipoPago_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            cargarDatos()
        End If
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        redimensionarOrigen()
        gbGrupo.Enabled = True
        tipo = "update"
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        redimensionarOrigen()
        gbGrupo.Enabled = True
        tipo = "new"
        limpiarEntradas()
    End Sub
    Private Sub limpiarEntradas()
        cboBancos.SelectedValue = 0
        cboMoneda.SelectedValue = 0
        txtCuenta.Text = "-"
        txtNumero.Text = "0"
        txtGlosa.Text = "-"
        txtMonto.Text = "0.00"
        txtNomenclatura.Text = "-"
        rbSi.Checked = True
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        redimensionar()
        cargarDatosCuenta()
        gbGrupo.Enabled = False
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim objBC As New nBancosCheques
        Dim estado As String
        If rbNo.Checked = True Then
            estado = "0"
        Else
            estado = "1"
        End If
        Dim entidad As New BancoChequeEntity
        With entidad
            .id = codigoCeldaSeleccionada()
            .id_cheque = txtIdCheque.Text.Trim
            .numero = txtNumero.Text.Trim
            .fec_emision = dtFecha.Value
            .fec_pago = dtDesde.Value
            .glosa = txtGlosa.Text.Trim
            .monto = txtMonto.Text.Trim
            .nomenclatura = txtNomenclatura.Text.Trim
            .estado = estado
        End With
        Dim rpta As String = ""
        If tipo = "update" Then
            rpta = objBC.nActualizarGiroCheques(entidad, CadenaConexion)
        ElseIf tipo = "new" Then
            rpta = objBC.nRegistrarGiroCheques(entidad, CadenaConexion)
        End If

        If rpta = "ok" Then
            MessageBox.Show("El proceso se ha realizado con éxito.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            gbGrupo.Enabled = False
            limpiarEntradas()
            cargarDatos()
            txtDato.Focus()
            Dim data As New DataTable
            data = obj.nCrudListarBD("select * from cheque_giros order by id desc", CadenaConexion)
            If tipoAbono = "compra" And tipo = "new" Then
                frmAbonoComprobanteCompras.txtIdCheque.Text = Data.Rows(0)("id").ToString
                frmAbonoComprobanteCompras.txtNumero.Text = Data.Rows(0)("numero").ToString
            ElseIf tipoAbono = "pagoComprobante" And tipo = "new" Then
                frmPagoComprobante.txtIdCheque.Text = data.Rows(0)("id").ToString
                frmPagoComprobante.txtNumero.Text = data.Rows(0)("numero").ToString
            End If
            Me.Close()
        Else
            MessageBox.Show(rpta, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub cargaInicialEstados()
        Try
            For Each row As DataGridViewRow In dgvLista.Rows
                If row.Cells("estado").Value.ToString = "0" Then
                    row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(255, 87, 87) '(245, 230, 108)
                ElseIf row.Cells("estado").Value.ToString = "1" Then
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
        data = obj.nCrudListarBD("select * from vista_chequesGirados where glosa like '%" & dato & "%' or banco like '%" & dato & "%'  or cuenta like '%" & dato & "%' order by id asc", CadenaConexion)
        dgvLista.DataSource = data
        cargaInicialEstados()
    End Sub
    Private Sub txtDato_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDato.KeyPress
        On Error Resume Next
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            realizarBusqueda()
        End If
    End Sub
    Private Sub cboMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMoneda.SelectedIndexChanged
        If ind_carga = 1 Then
            If cboBancos.SelectedValue <> 0 Then
                Dim data As New DataTable
                data = obj.nCrudListarBD("select * from bancos_configuracion where id_banco='" & cboBancos.SelectedValue.ToString & "' and id_moneda='" & cboMoneda.SelectedValue.ToString & "' and estado=1", CadenaConexion)
                If data.Rows.Count > 0 Then
                    txtCuenta.Text = data.Rows(0)("cuenta_corriente").ToString
                    Dim dtTalon As New DataTable
                    'dtTalon = obj.nCrudListarBD("select * from cheque_talones where id_banco='" & cboBancos.SelectedValue.ToString & "' and id_moneda='" & cboMoneda.SelectedValue.ToString & "' and cuenta='" & txtCuenta.Text.Trim & "' and estado=1", CadenaConexion)
                    dtTalon = obj.nCrudListarBD("select * from cheque_talones where id_banco='" & cboBancos.SelectedValue.ToString & "' and id_moneda='" & cboMoneda.SelectedValue.ToString & "' and estado=1", CadenaConexion)
                    If dtTalon.Rows.Count > 0 Then
                        txtIdCheque.Text = data.Rows(0)("id").ToString

                        If tipo = "update" Then
                            'Cargar numero de cheque
                            Dim data1 As New DataTable
                            data1 = obj.nCrudListarBD("select * from cheque_giros where id='" & dtTalon.Rows(0)("id").ToString & "'", CadenaConexion)
                            'txtNumero.Text = data1.Rows(0)("numero").ToString
                        ElseIf tipo = "new" Then
                            Dim data2 As New DataTable
                            data2 = obj.nCrudListarBD("select * from cheque_giros where id_cheque='" & dtTalon.Rows(0)("id").ToString & "'", CadenaConexion)
                            'MsgBox(data2.Rows.Count)
                            If data2.Rows.Count > 0 Then
                                Dim data3 As New DataTable
                                'MsgBox(dtTalon.Rows(0)("id").ToString)
                                data3 = obj.nCrudListarBD("select max(numero) as 'numero' from cheque_giros where id_cheque='" & dtTalon.Rows(0)("id").ToString & "'", CadenaConexion)
                                txtNumero.Text = Integer.Parse(data3.Rows(0)("numero").ToString) + 1
                            Else
                                txtNumero.Text = dtTalon.Rows(0)("empieza").ToString
                            End If
                        Else
                            txtNumero.Text = dtTalon.Rows(0)("empieza").ToString
                        End If

                    Else
                        txtIdCheque.Text = "0"
                    End If
                    btnGuardar.Enabled = True
                    mostrarNomenclatura()
                Else
                    MsgBox("No se ha encontrado una cuenta corriente asignada al banco y moneda seleccionada")
                    txtNumero.Text = "0"
                    txtCuenta.Text = "-"
                    btnGuardar.Enabled = False
                End If
            End If
        End If
    End Sub
    Private Sub txtMonto_TextChanged(sender As Object, e As EventArgs) Handles txtMonto.TextChanged
        If ind_carga = 1 Then
            mostrarNomenclatura()
        End If
    End Sub
    Private Sub mostrarNomenclatura()
        Dim util As New Numeros
        Dim dMoneda As New DataTable
        If tipoAbono = "compra" And cboMoneda.SelectedValue = Nothing Then
            dMoneda = obj.nCrudListarBD("select * from tipo_moneda where codigo='" & valMoneda & "'", CadenaConexion)
            txtNomenclatura.Text = util.sesion_convertirNumerosToLetras(Decimal.Parse(txtMonto.Text.Trim), dMoneda.Rows(0)("descripcion").ToString)
        Else
            dMoneda = obj.nCrudListarBD("select * from tipo_moneda where id='" & cboMoneda.SelectedValue.ToString & "'", CadenaConexion)
            If dMoneda.Rows.Count > 0 Then
                If txtMonto.Text.Trim.Length > 0 Then
                    txtNomenclatura.Text = util.sesion_convertirNumerosToLetras(Decimal.Parse(txtMonto.Text.Trim), dMoneda.Rows(0)("descripcion").ToString)
                Else
                    txtNomenclatura.Text = util.sesion_convertirNumerosToLetras(0, " " & dMoneda.Rows(0)("descripcion").ToString)
                End If
            Else
                txtNomenclatura.Text = util.sesion_convertirNumerosToLetras(Decimal.Parse(txtMonto.Text.Trim), " SOLES")
            End If
        End If
    End Sub

    Private Sub btnElegirCheque_Click(sender As Object, e As EventArgs) Handles btnElegirCheque.Click
        If ind_carga = 1 Then
            If tipoAbono = "compra" Then
                Dim f As Integer
                f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
                frmAbonoComprobanteCompras.txtIdCheque.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmAbonoComprobanteCompras.txtNumero.Text = dgvLista.Rows(f).Cells("numero").Value.ToString
            ElseIf tipoAbono = "compraImp" Then
                Dim f As Integer
                f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
                frmAbonoComprobanteCompras.txtIdCheque.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmAbonoComprobanteCompras.txtNumImpuesto.Text = dgvLista.Rows(f).Cells("numero").Value.ToString
            ElseIf tipoAbono = "planilla" Then
                Dim f As Integer
                f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
                frmPagoPlanilla.txtNumero.Text = dgvLista.Rows(f).Cells("numero").Value.ToString
            ElseIf tipoAbono = "cajas" Then
                Dim f As Integer
                f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
                frmSalidaCaja.txtNumero.Text = dgvLista.Rows(f).Cells("numero").Value.ToString
            ElseIf tipoAbono = "pagoComprobante" Then
                Dim f As Integer
                f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
                frmPagoComprobante.txtIdCheque.Text = dgvLista.Rows(f).Cells("id").Value.ToString
                frmPagoComprobante.txtNumero.Text = dgvLista.Rows(f).Cells("numero").Value.ToString
            End If
            Me.Dispose()
        End If
    End Sub

    Private Sub btnCargarDatosAbono_Click(sender As Object, e As EventArgs) Handles btnCargarDatosAbono.Click
        If tipoAbono = "compra" Then
            valMoneda = frmAbonoComprobanteCompras.LblMoneda.Text
            cargarDatosAbono()
            redimensionarOrigen()
        End If
    End Sub
    Private Sub txtMonto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.Leave
        txtMonto.Text = Format(CType(txtMonto.Text, Decimal), "###0.00")
    End Sub

End Class
