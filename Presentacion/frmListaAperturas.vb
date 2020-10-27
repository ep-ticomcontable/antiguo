Imports Negocio
Imports Entidades

Public Class frmListaAperturas
    Dim objCrud As New nCrud
    Dim iCarga As Integer = 0
    Dim dataAsientos As New DataTable
    Public idAsiento As String

    Public Sub cabeceraApertura()
        Dim data As New DataTable
        data = objCrud.nCrudListarBD("select id as 'numero',glosa as 'descripcion',total_debe_s as 't_debe',total_haber_s as 't_haber',total_debe_d ,total_haber_d,fecha,estado from asiento_apertura order by fecha desc", CadenaConexion)
        dgvCabecera.DataSource = data
        formatoGrilla()
    End Sub

    Private Sub formatoGrilla()
        For Each row As DataGridViewRow In dgvCabecera.Rows
            If row.Cells("estado").Value.ToString = "0" Then
                row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(184, 184, 184)
                'ElseIf row.Cells("estadoCompra").Value.ToString = "POR PAGAR" Then
                ''row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(254, 198, 119)
                'row.DefaultCellStyle.ForeColor = Drawing.Color.FromArgb(252, 0, 0)
            End If
        Next
    End Sub

    Private Sub frmListaAperturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCabecera.RowTemplate.Height = 25
        cebrasDatagrid(dgvCabecera, Drawing.Color.White, Drawing.Color.FromArgb(182, 205, 226))
        dgvDetalle.RowTemplate.Height = 25
        cebrasDatagrid(dgvDetalle, Drawing.Color.White, Drawing.Color.FromArgb(182, 205, 226))
        cabeceraApertura()
        iCarga = 1
        If dgvCabecera.RowCount > 0 Then
            cargarDetalle()
        End If
    End Sub

    Private Sub cargarDetalle()
        Dim f As Integer
        f = dgvCabecera.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        Dim idComprobante As String = ""
        idComprobante = dgvCabecera.Rows(f).Cells("numero").Value.ToString
        If dgvCabecera.Rows(f).Cells("estado").Value.ToString = "1" Then
            'btnModificar.Enabled = False
        Else
            'btnModificar.Enabled = True
        End If
        Dim data As New DataTable
        data = objCrud.nCrudListarBD("select d.cuenta as 'num_cuenta',c.nombre as 'desc_cuenta',d.debe,d.haber,d.debeD,d.haberD,d.glosa from detalle_asiento_apertura d inner join cuenta_contable c on d.cuenta=c.id  where d.id_asiento_apertura='" & idComprobante & "' order by d.cuenta asc", CadenaConexion)
        dgvDetalle.DataSource = data
    End Sub

    Private Sub dgvCabecera_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvCabecera.SelectionChanged
        If iCarga = 1 Then
            cargarDetalle()
        End If
    End Sub

    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgvCabecera.Rows.Count > 0 Then
            Dim f As Integer
            f = dgvCabecera.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            Dim idComprobante As String = ""
            idComprobante = dgvCabecera.Rows(f).Cells("numero").Value.ToString

            frmModificarApertura.idApertura = idComprobante
            frmModificarApertura.Show()
        End If
    End Sub

    Private Sub btnApertura_Click(sender As Object, e As EventArgs) Handles btnApertura.Click
        frmNuevoRegistroApertura.Show()
    End Sub

    Private Sub btnReapertura_Click(sender As Object, e As EventArgs) Handles btnReapertura.Click
        cabeceraApertura()
    End Sub
End Class