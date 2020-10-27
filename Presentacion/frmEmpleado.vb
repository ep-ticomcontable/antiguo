Imports Negocio
Imports Entidades

Public Class frmEmpleado

    Dim obj As New nCrud
    Public formInicio As String
    Public datoEmpleado As String
    Private Sub cargarEmpleados()
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from empleados where estado='1'", CadenaConexion)
        dgvListado.DataSource = data
    End Sub

    Public Sub cargarEmpleadosPorDato(datoEmp As String)
        txtNomEmpresa.Text = datoEmp
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from empleados where nombres like '" & datoEmp & "%' and estado='1'", CadenaConexion)
        dgvListado.DataSource = data
    End Sub

    Private Sub frmEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarEmpleados()
    End Sub

    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomEmpresa.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

        End If
    End Sub

    Private Sub txtNomEmpresa_TextChanged(sender As Object, e As EventArgs) Handles txtNomEmpresa.TextChanged
        If txtNomEmpresa.Text.Trim.Length >= 0 Then
            Dim data As New DataTable
            data = obj.nCrudListarBD("select * from empleados where nombres like '" & txtNomEmpresa.Text.Trim & "%' and estado='1'", CadenaConexion)
            dgvListado.DataSource = data
        End If
    End Sub

    'Private Sub dgvLista_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellContentDoubleClick
    '    If dgvListado.Rows.Count > 0 Then
    '        Dim f As Integer
    '        f = dgvListado.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
    '        'MsgBox(dgvLista.Rows(f).Cells("id").Value.ToString)

    '        frmCrearCentroCosto.txtIdEmp.Text = dgvListado.Rows(f).Cells("id").Value.ToString
    '        frmCrearCentroCosto.txtResponsable.Text = dgvListado.Rows(f).Cells("nombres").Value.ToString.ToUpper
    '    End If
    '    Me.Dispose()
    'End Sub
End Class
