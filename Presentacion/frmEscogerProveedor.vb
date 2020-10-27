Imports Negocio
Public Class frmEscogerProveedor

    Dim obj As New nPagosCompras
    Public datoProveedor As String = ""
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
        If formInicio = "compra" Then
            With frmNuevaCompra
                .txtRuc.Text = dgvOperaciones.Rows(f).Cells("dni_ruc").Value.ToString
                .txtRazonSocial.Text = dgvOperaciones.Rows(f).Cells("nombre").Value.ToString
                .txtDireccion.Text = dgvOperaciones.Rows(f).Cells("direccion").Value.ToString()
            End With
        ElseIf formInicio = "compraP" Then
            With frmNuevaCompraP
                .txtRuc.Text = dgvOperaciones.Rows(f).Cells("dni_ruc").Value.ToString
                .txtRazonSocial.Text = dgvOperaciones.Rows(f).Cells("nombre").Value.ToString
                .txtDireccion.Text = dgvOperaciones.Rows(f).Cells("direccion").Value.ToString()
            End With
        ElseIf formInicio = "McompraP" Then
            With frmModificarCompraP
                .txtRuc.Text = dgvOperaciones.Rows(f).Cells("dni_ruc").Value.ToString
                .txtRazonSocial.Text = dgvOperaciones.Rows(f).Cells("nombre").Value.ToString
                .txtDireccion.Text = dgvOperaciones.Rows(f).Cells("direccion").Value.ToString()
            End With
        ElseIf formInicio = "compraM" Then
            With frmNuevaCompraMercaderias
                .txtRuc.Text = dgvOperaciones.Rows(f).Cells("dni_ruc").Value.ToString
                .txtRazonSocial.Text = dgvOperaciones.Rows(f).Cells("nombre").Value.ToString
                .txtDireccion.Text = dgvOperaciones.Rows(f).Cells("direccion").Value.ToString()
            End With
        ElseIf formInicio = "ventaM" Then
            With frmNuevaVentaMercaderias
                .txtRuc.Text = dgvOperaciones.Rows(f).Cells("dni_ruc").Value.ToString
                .txtRazonSocial.Text = dgvOperaciones.Rows(f).Cells("nombre").Value.ToString
                .txtDireccion.Text = dgvOperaciones.Rows(f).Cells("direccion").Value.ToString()
            End With
        ElseIf formInicio = "ventaP" Then
            With frmNuevaVentaP
                .txtRuc.Text = dgvOperaciones.Rows(f).Cells("dni_ruc").Value.ToString
                .txtRazonSocial.Text = dgvOperaciones.Rows(f).Cells("nombre").Value.ToString
                .txtDireccion.Text = dgvOperaciones.Rows(f).Cells("direccion").Value.ToString()
            End With
        Else
            With frmPagos
                .txtDatoProveedor.Text = dgvOperaciones.Rows(f).Cells("dni_ruc").Value.ToString
                .lblDatoProveedor.Text = dgvOperaciones.Rows(f).Cells("nombre").Value.ToString
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
        dgvOperaciones.DataSource = obj.nBuscarProveedorBD("", CadenaConexion)
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
        dgvOperaciones.DataSource = obj.nBuscarProveedorBD(dato, CadenaConexion)
    End Sub

    Private Sub btnSunat_Click(sender As Object, e As EventArgs) Handles btnSunat.Click
        frmConsultaSunat.formInicio = formInicio
        frmConsultaSunat.ShowDialog()
    End Sub
End Class