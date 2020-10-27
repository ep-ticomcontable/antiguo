Imports Negocio
Imports System.IO
Public Class frmPlanContable2
    Dim tituloForm As String = "Plan contable"
    Dim obj As New nCrud
    Dim ind_carga As Integer = 0
    Dim tipoAccion As String
    Dim filaTable As New DataTable
    Dim mesPeriodo As String
    Dim lista As New DataTable
    Dim codigoLibro As String = "050300"
    Public formulario As String = ""
    Public cuenta As String = ""
    Public cuentaInicial As String = ""

    Private Function codigoCeldaSeleccionada() As Integer
        Dim c As String
        Try
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex()
            c = dgvLista.Rows(f).Cells("id").Value.ToString
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function
    Public Sub cargarCuentaAModificar()
        txtDato.Text = cuenta
        'dgvLista.DataSource = obj.nCrudListarBD("select * from vista_CuentaContableGrilla where nom_cuenta like '" & txtDato.Text.Trim & "%' or  num_cuenta like '" & txtDato.Text.Trim & "%'", CadenaConexion)
        'btnModificar.PerformClick()
    End Sub



    Private Sub frmPlanContable2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class