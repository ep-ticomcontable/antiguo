Imports Negocio
Public Class frmAgregarCuenta
    Public formIni As String
    Dim objCrud As New nCrud

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

    Private Sub cargarCentroDeCostos()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add("0", "SIN AFECTO")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListarBD("select * from centro_costos where id_local='" & CodigoLocalSession & "' and estado=1 order by descripcion asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(2).ToString)
            Next
            data.Rows.Add("XXX", "AGREGAR NUEVO CENTRO")
            With cboCentroCosto
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Centro de Costos")
        End Try
    End Sub

    Private Sub frmAgregarCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        movimientoDH()
        'CodigoLocalSession = 1
        cargarCentroDeCostos()
    End Sub
    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cargarCuentaContable()
            habilitarCentroCostoCompra()
        End If
    End Sub
    Private Sub btnCuenta_Click(sender As Object, e As EventArgs) Handles btnCuenta.Click
        cargarCuentaContable()
    End Sub
    Private Sub cargarCuentaContable()
        If txtCuenta.Text.Trim.Length >= 2 Then
            With frmEscogerPlanContable
                .formInicio = "agregarCuenta"
                .cuentaInicio = txtCuenta.Text.Trim
                .ShowDialog()
            End With
        End If
    End Sub
    Public Sub habilitarCentroCostoCompra()
        Dim cuentaCC As New DataTable
        cuentaCC = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & txtCuenta.Text.Trim & "'", CadenaConexion)
        If cuentaCC.Rows.Count > 0 Then
            If Integer.Parse(cuentaCC.Rows(0)("c1").ToString) > 0 Then
                cboCentroCosto.SelectedValue = 0
                cboCentroCosto.Enabled = True
                MessageBox.Show("Elija un Centro de Costo para esta cuenta.", "Registro de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                cboCentroCosto.Focus()
            Else
                cboCentroCosto.SelectedValue = 0
                cboCentroCosto.Enabled = False
            End If
        End If
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If formIni = "compra" Then
            frmNuevaCompra.cargarDatosVentana(txtCuenta.Text.Trim, lblCuenta.Text, txtDebe.Text.Trim, cboDH.SelectedValue.ToString, cboCentroCosto.SelectedValue.ToString)
        End If
        Me.Dispose()
    End Sub
    Private Sub txtDebe_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDebe.Leave
        txtDebe.Text = Format(CType(txtDebe.Text, Decimal), "###0.00")
    End Sub
    
End Class