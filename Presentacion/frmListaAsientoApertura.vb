Imports Negocio
Imports Entidades
Public Class frmListaAsientoApertura

    Dim obj As New nAsientoApertura
    Dim iCarga As Integer = 0
    Private Function codigoCeldaGrid() As Integer
        Dim c As String
        Try
            Dim f As Integer
            f = dgvListaAsientos.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            c = dgvListaAsientos.Rows(f).Cells("id_a").Value.ToString
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function
    Private Sub frmListaAsientoApertura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarListaDeAsientosDeApertura()
        iCarga = 1
        cargarDetalleListaAsientoApertura()
    End Sub

    Public Sub cargarListaDeAsientosDeApertura()
        dgvListaAsientos.DataSource = obj.nListaAsienteoAperturaBD(CadenaConexion)
    End Sub

    Private Sub cargarDetalleListaAsientoApertura()
        dgvDetalleAsiento.DataSource = obj.nListaDetalleAsientoAperturaPorIdAsientoBD(codigoCeldaGrid(), CadenaConexion)
    End Sub

    Private Sub dgvListaAsientos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListaAsientos.SelectionChanged
        If iCarga = 1 Then
            cargarDetalleListaAsientoApertura()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim idAsiento As String
        idAsiento = obj.nObtenerIdAsientoAperturaBD(CadenaConexion)
        With frmAsientoApertura
            .idAsiento = idAsiento
            .formIni = "frmListaAsientoApertura"
            .ShowDialog()
        End With
        
    End Sub
End Class