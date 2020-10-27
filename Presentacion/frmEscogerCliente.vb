Imports Negocio
Public Class frmEscogerCliente

    Dim obj As New nPagosCompras
    Public datoCliente As String = ""
    Public formInicio As String = ""

    Private Sub frmEscogerProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub dgvOperaciones_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOperaciones.CellContentDoubleClick
        elegirRegistro()
    End Sub

    Private Sub dgvOperaciones_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvOperaciones.KeyDown
        If e.KeyCode = Keys.Enter Then
            elegirRegistro()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub elegirRegistro()
        Dim f As Integer
        f = dgvOperaciones.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        If formInicio = "ventaP" Then
            With frmNuevaVentaP
                .txtRuc.Text = IIf(dgvOperaciones.Rows(f).Cells("dni_ruc").Value.ToString.Length > 10, dgvOperaciones.Rows(f).Cells("dni_ruc").Value.ToString, dgvOperaciones.Rows(f).Cells("dni_ruc").Value.ToString)
                .txtRazonSocial.Text = IIf(dgvOperaciones.Rows(f).Cells("nombres").Value.ToString.Length > 5, dgvOperaciones.Rows(f).Cells("nombres").Value.ToString, dgvOperaciones.Rows(f).Cells("nombres").Value.ToString)
                .txtDireccion.Text = dgvOperaciones.Rows(f).Cells("direccion").Value.ToString()
            End With
        ElseIf formInicio = "ventaRapidaP" Then
            With frmNuevaVentaMercaderias
                .txtRuc.Text = IIf(dgvOperaciones.Rows(f).Cells("dni_ruc").Value.ToString.Length > 10, dgvOperaciones.Rows(f).Cells("dni_ruc").Value.ToString, dgvOperaciones.Rows(f).Cells("dni_ruc").Value.ToString)
                .txtRazonSocial.Text = IIf(dgvOperaciones.Rows(f).Cells("nombres").Value.ToString.Length > 5, dgvOperaciones.Rows(f).Cells("nombres").Value.ToString, dgvOperaciones.Rows(f).Cells("nombres").Value.ToString)
                .txtDireccion.Text = dgvOperaciones.Rows(f).Cells("direccion").Value.ToString()
            End With
        ElseIf formInicio = "cajaChica" Then
            With frmRegistrarSalidasCajaChica
                .txtRuc.Text = IIf(dgvOperaciones.Rows(f).Cells("dni_ruc").Value.ToString.Length > 10, dgvOperaciones.Rows(f).Cells("dni_ruc").Value.ToString, dgvOperaciones.Rows(f).Cells("dni_ruc").Value.ToString)
                .txtRazonSocial.Text = IIf(dgvOperaciones.Rows(f).Cells("nombres").Value.ToString.Length > 5, dgvOperaciones.Rows(f).Cells("nombres").Value.ToString, dgvOperaciones.Rows(f).Cells("nombres").Value.ToString)
            End With
        Else
            With frmPagos
                .txtDatoProveedor.Text = dgvOperaciones.Rows(f).Cells("dni_ruc").Value.ToString
                .lblDatoProveedor.Text = dgvOperaciones.Rows(f).Cells("nombres").Value.ToString
                .cargarComprasPorPagar()
            End With
        End If
        Me.Close()
    End Sub

    Private Sub btnEscoger_Click(sender As Object, e As EventArgs) Handles btnEscoger.Click
        elegirRegistro()
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        realizarBusqueda()
    End Sub

    Private Sub cargarTodosLosProveedores()
        dgvOperaciones.DataSource = obj.nBuscarClienteBD("", CadenaConexion)
    End Sub

    Private Sub frmEscogerProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F5 Then
            cargarTodosLosProveedores()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub txtRazonSocial_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        realizarBusqueda()
    End Sub
    Public Sub realizarBusqueda()
        Dim dato As String
        dato = txtDescripcion.Text.Trim
        dgvOperaciones.DataSource = obj.nBuscarClienteBD(dato, CadenaConexion)
    End Sub

    Private Sub btnSunat_Click(sender As Object, e As EventArgs) Handles btnSunat.Click
        frmConsultaSunat.formInicio = "escoger_cliente"
        frmConsultaSunat.ShowDialog()
    End Sub
End Class