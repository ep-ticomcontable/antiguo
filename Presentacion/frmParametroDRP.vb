Imports Negocio
Public Class frmParametroDRP
    Dim objCrud As New nCrud

    Private Sub cargarDatos()
        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from impuestos_sunat", CadenaConexion)
        dgvLista.DataSource = dt
    End Sub

    Private Sub frmParametroDRP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

End Class