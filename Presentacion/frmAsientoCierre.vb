Imports Negocio
Imports Entidades
Public Class frmAsientoCierre
    Dim obj As New nAsientoApertura
    Dim objCrud As New nCrud
    Public idAsiento As String
    Dim iCarga As Integer = 0
    Dim entiAA As New AAperturaEntity
    Public formIni As String = ""

    Public Sub cargarAsientosContables()
        Dim data As New DataTable
        data = objCrud.nCrudListarBD("usp_registrosCuentasParaCierre", CadenaConexion)
        dgvLista.DataSource = data
        realizarCalculos()
    End Sub

    Private Sub frmAsientoApertura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLista.RowTemplate.Height = 30
        cargarAsientosContables()
        cargarNumeroDeAsientoApertura()
        iCarga = 1
        'realizarCalculos()
        limpiarCajas()
    End Sub

    Private Sub limpiarCajas()
        txtGlosa.Text = ""
        txtDebeSoles.Text = "0.00"
        txtHaberSoles.Text = "0.00"
        txtDiferenciaSoles.Text = "0.00"
    End Sub

    Public Sub cargarNumeroDeAsientoApertura()
        txtNumeroAsiento.Text = obj.nObtenerNumeroDeAsientoAperturaBD(CadenaConexion)
        idAsiento = obj.nObtenerNumeroDeAsientoAperturaBD(CadenaConexion)
    End Sub

    Public Sub realizarCalculos()
        Dim tDebe, tHaber, tDiferencia As Decimal

        For Each row As DataGridViewRow In dgvLista.Rows
            tDebe += Decimal.Parse(row.Cells("debe").Value.ToString)
            tHaber += Decimal.Parse(row.Cells("haber").Value.ToString)
        Next
        tDiferencia = tDebe - tHaber
        txtDebeSoles.Text = tDebe
        txtHaberSoles.Text = tHaber
        txtDiferenciaSoles.Text = tDiferencia
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        With frmAgregarAsientoCierre
            .idAsientoApertura = idAsiento
            .ShowDialog()
        End With
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        cargarAsientosContables()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmParametroLibroMayor.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmAsientoApertura.Show()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

    End Sub
End Class