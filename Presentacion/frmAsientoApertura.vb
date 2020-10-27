Imports Negocio
Imports Entidades
Public Class frmAsientoApertura
    Dim objMon As New nMonedas
    Dim obj As New nAsientoApertura
    Public idAsiento As String
    Dim iCarga As Integer = 0
    Dim entiAA As New AAperturaEntity
    Public formIni As String = ""

    Private Sub cargarTipoDeCambio()
        If iCarga = 1 Then
            Dim data As New DataTable
            data = objMon.nTipoDeCambioPorMonedaBD(115, CadenaConexion)
            lblTC.Text = data.Rows(0)("venta").ToString
        Else
            lblTC.Text = "1.00"
        End If
    End Sub

    Public Sub cargarDetalleAsientoApertura()
        Dim data As New DataTable
        Dim codIdAsiento As String
        codIdAsiento = IIf((idAsiento = "0"), 1, IIf(idAsiento = Nothing, 1, idAsiento))
        'codIdAsiento = txtNumeroAsiento.Text.Trim
        data = obj.nListaDetalleAsientoAperturaPorIdAsientoBD(codIdAsiento, CadenaConexion)
        dgvLista.DataSource = data
        realizarCalculos()
    End Sub

    Private Sub frmAsientoApertura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLista.RowTemplate.Height = 30
        cargarDetalleAsientoApertura()
        cargarNumeroDeAsientoApertura()
        iCarga = 1
        cargarTipoDeCambio()
        realizarCalculos()
        limpiarCajas()
    End Sub

    Private Sub limpiarCajas()
        txtGlosa.Text = ""
        txtDebeSoles.Text = "0.00"
        txtDebeD.Text = "0.00"
        txtHaberSoles.Text = "0.00"
        txtHaberD.Text = "0.00"
        txtDiferenciaSoles.Text = "0.00"
        txtDiferenciaD.Text = "0.00"
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

        txtDebeD.Text = (Decimal.Parse(txtDebeSoles.Text) * Decimal.Parse(lblTC.Text))
        txtHaberD.Text = (Decimal.Parse(txtHaberSoles.Text) * Decimal.Parse(lblTC.Text))
        txtDiferenciaD.Text = (Decimal.Parse(txtDebeD.Text) - Decimal.Parse(txtHaberD.Text))
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        With entiAA
            .id = idAsiento
            .id_asiento = 1
            .glosa = txtGlosa.Text.Trim
            .numero = txtNumeroAsiento.Text.Trim
            .total_debe_s = txtDebeSoles.Text.Trim
            .total_haber_s = txtHaberSoles.Text.Trim
            .diferencia_s = txtDiferenciaSoles.Text.Trim
            .total_debe_d = txtDebeD.Text.Trim
            .total_haber_d = txtHaberD.Text.Trim
            .diferencia_d = txtDiferenciaD.Text.Trim
            .periodo = 1
            .fecha = dtFecha.Value
            .id_empresa = CodigoEmpresaSession
            .id_usuario = CodigoUsuarioSession
            .estado = 1
        End With
        MsgBox("Asiento de Apertura registrado: " & vbCrLf & obj.nRegistrarAsientoAperturaBD(entiAA, CadenaConexion))
        cargarNumeroDeAsientoApertura()
        cargarDetalleAsientoApertura()
        txtGlosa.Text = ""
        If formIni = "frmListaAsientoApertura" Then
            Me.Close()
            frmListaAsientoApertura.cargarListaDeAsientosDeApertura()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        With frmAgregarAsiento
            .idAsientoApertura = idAsiento
            .ShowDialog()
        End With
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        cargarDetalleAsientoApertura()
    End Sub
End Class