Imports Negocio

Public Class frmAgregarCuentasNuevo
    Public formIni As String
    Dim objCrud As New nCrud
    Public tipoOperacion As String = "1"
    Dim objMon As New nMonedas
    Dim iCarga As Integer = 0

    Private Sub movimientoDH()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add("D", "DEBE")
        data.Rows.Add("H", "HABER")
        With cboDH
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
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
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Monedas")
        End Try
    End Sub
    Private Sub frmAgregarCuentasCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiarEntradas()
        movimientoDH()
        txtCuenta.Select()
        If formIni = "apertura" Or formIni = "MODapertura" Then
            lblGlosa.Visible = True
            txtGlosa.Visible = True
            txtGlosa.Text = "REGISTRO " & lblCuenta.Text.Trim.ToUpper
        Else
            lblGlosa.Visible = False
            txtGlosa.Visible = False
            txtGlosa.Text = ""
        End If
        cargarMonedas()
        iCarga = 1
        cargarTipoDeCambio()
    End Sub
    Private Sub limpiarEntradas()
        txtCuenta.Text = ""
        lblCuenta.Text = "[Cuenta]"
        txtDebe.Text = "0.00"
        cboDH.SelectedValue = "D"
        txtIdCentro.Text = "0"
        txtCentro.Text = "-"
        txtGlosa.Text = ""
    End Sub
    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cargarCuentaContable()
            habilitarCentroCostoCompra()
            txtDebe.Focus()
        End If
    End Sub
    Private Sub btnCuenta_Click(sender As Object, e As EventArgs) Handles btnCuenta.Click
        cargarCuentaContable()
    End Sub
    Private Sub cargarCuentaContable()
        If txtCuenta.Text.Trim.Length >= 2 Then
            With frmEscogerPlanContable
                .formInicio = "agregarCuentaNuevo"
                .cuentaInicio = txtCuenta.Text.Trim
                .ShowDialog()
            End With
        End If
    End Sub
    Public Sub verificarTipoOperacion(cuenta As String)
        Dim data As New DataTable
        data = objCrud.nCrudListarBD("select * from igv where estado=1", CadenaConexion)
        If tipoOperacion = "3" Or tipoOperacion = "4" Then
            If cuenta = data.Rows(0)("cuenta").ToString Then
                MessageBox.Show("No se puede agregar esta cuenta contable cuando el tipo de operación es ''NO GRAVADA''", "Asignación de Cuenta Contable", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                btnAgregarCuenta.Enabled = False
            Else
                btnAgregarCuenta.Enabled = True
            End If
        End If
    End Sub
    Public Sub habilitarCentroCostoCompra()
        Dim cuentaCC As New DataTable
        cuentaCC = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & txtCuenta.Text.Trim & "'", CadenaConexion)
        If cuentaCC.Rows.Count > 0 Then
            If Integer.Parse(cuentaCC.Rows(0)("c1").ToString) > 0 Then
                btnCentro.Enabled = True
                txtCentro.Enabled = True
                MessageBox.Show("Elija un Centro de Costo para esta cuenta.", "Registro de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                frmListaCentroCostos.formInicio = "agregarCuentaNuevo"
                frmListaCentroCostos.ShowDialog()
            Else
                btnCentro.Enabled = False
                txtCentro.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnAgregarCuenta_Click(sender As Object, e As EventArgs) Handles btnAgregarCuenta.Click
        If formIni = "nuevaCompraP" Then
            If frmNuevaCompraP.idCentroCosto = "0" Then
                frmNuevaCompraP.idCentroCosto = IIf(txtIdCentro.Text.Trim = "", "0", txtIdCentro.Text.Trim)
                frmNuevaCompraP.txtCentro.Text = IIf(txtIdCentro.Text.Trim = "", "0", txtIdCentro.Text.Trim)
            End If
            frmNuevaCompraP.adicionarCuentas(txtCuenta.Text.Trim, txtDebe.Text.Trim, cboDH.SelectedValue.ToString)
        ElseIf formIni = "apertura" Then
            frmNuevoRegistroApertura.adicionarCuentas(txtCuenta.Text.Trim, txtDebe.Text.Trim, cboDH.SelectedValue.ToString, txtGlosa.Text.Trim, cboMoneda.SelectedValue, txtTipoCambio.Text)
        ElseIf formIni = "MODapertura" Then
            frmModificarApertura.adicionarCuentas(txtCuenta.Text.Trim, txtDebe.Text.Trim, cboDH.SelectedValue.ToString, txtGlosa.Text.Trim)
        ElseIf formIni = "nuevaVentaP" Then
            frmNuevaVentaP.idCentroCosto = IIf(txtIdCentro.Text.Trim = "", "0", txtIdCentro.Text.Trim)
            frmNuevaVentaP.adicionarCuentas(txtCuenta.Text.Trim, txtDebe.Text.Trim, cboDH.SelectedValue.ToString)
        ElseIf formIni = "modificarCompraP" Then
            frmModificarCompraP.idCentroCosto = IIf(txtIdCentro.Text.Trim = "", "0", txtIdCentro.Text.Trim)
            frmModificarCompraP.adicionarCuentas(txtCuenta.Text.Trim, txtDebe.Text.Trim, cboDH.SelectedValue.ToString)
        ElseIf formIni = "letra" Then
            frmCanjeLetraComprobantes.adicionarCuentas(txtCuenta.Text.Trim, txtDebe.Text.Trim, cboDH.SelectedValue.ToString)
        ElseIf formIni = "letraMod" Then
            frmModificarLetraPorPagar.adicionarCuentas(txtCuenta.Text.Trim, txtDebe.Text.Trim, cboDH.SelectedValue.ToString)
        ElseIf formIni = "notadebito" Then
            frmNuevaNotaDebito.agregarCuenta(txtCuenta.Text.Trim, txtDebe.Text.Trim, cboDH.SelectedValue.ToString)
        End If
        Me.Close()
    End Sub

    Private Sub btnCentro_Click(sender As Object, e As EventArgs) Handles btnCentro.Click
        frmListaCentroCostos.formInicio = "agregarCuentaNuevo"
        frmListaCentroCostos.Show()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub txtDebe_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDebe.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cboDH.Focus()
        End If
    End Sub
    Private Sub cboDH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboDH.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnAgregarCuenta.Focus()
        End If
    End Sub
    Private Sub frmNuevaCompraP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txtIdCentro_TextChanged(sender As Object, e As EventArgs) Handles txtIdCentro.TextChanged
        frmNuevaCompraP.txtCentro.Text = txtIdCentro.Text.Trim
    End Sub

    Private Sub txtDebe_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDebe.Leave
        txtDebe.Text = Format(CType(txtDebe.Text, Decimal), "###0.00")
    End Sub

    Private Sub cboMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMoneda.SelectedIndexChanged
        cargarTipoDeCambio()
    End Sub
    Private Sub cargarTipoDeCambio()
        If iCarga = 1 Then
            Dim data As New DataTable
            data = objMon.nTipoDeCambioPorMoneda(cboMoneda.SelectedValue.ToString)
            'lblTipoDeCambio.Text = "Tipo de cambio: S/. " & data.Rows(0)("valor").ToString
            If data.Rows.Count > 0 Then
                txtTipoCambio.Text = data.Rows(0)("venta").ToString
            Else
                txtTipoCambio.Text = "1.00"
            End If
        End If
    End Sub
End Class