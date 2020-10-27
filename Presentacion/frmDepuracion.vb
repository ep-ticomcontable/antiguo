Imports Negocio

Public Class frmDepuracion

    Dim obj As New nCrud

    Private Sub cargarClientes()
        Dim data As New DataTable
        data = obj.nCrudListarBD("select id,dni,nombre,ape_paterno,ape_materno,ruc,razon_social,nom_comercial,direccion from clientes order by nombre asc", CadenaConexion)
        dgvCab.DataSource = data
    End Sub

    Private Sub frmDepuracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarClientes()
    End Sub

    Private Sub dgvCab_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvCab.SelectionChanged
        cargarClientesRepetidos()
    End Sub

    Private Sub cargarClientesRepetidos()
        Dim f As Integer
        f = dgvCab.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid

        Dim data As New DataTable
        data = obj.nCrudListarBD("select id,dni,nombre,ape_paterno,ape_materno,ruc,razon_social,nom_comercial,direccion from clientes where (nombre like '" & dgvCab.Rows(f).Cells("nombre").Value.ToString.Trim & "%' or dni like '%" & dgvCab.Rows(f).Cells("id").Value.ToString.Trim & "%') and id<>'" & dgvCab.Rows(f).Cells("id").Value.ToString.Trim & "' order by nombre asc", CadenaConexion)
        dgvLista.DataSource = data

        For Each filaCol As DataGridViewRow In dgvLista.Rows
            filaCol.Cells(0).Value = False
        Next

    End Sub
End Class