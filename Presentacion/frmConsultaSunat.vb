Imports System.Drawing.Imaging
Imports System.IO
Imports System.Text
Imports Entidades
Public Class frmConsultaSunat
    Dim myInfo As SunatEntity
    Public numRuc As String = ""
    Public formInicio As String = ""
    Public Sub New()
        InitializeComponent()
        Try
            CargarImagen()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub CaptionResul()
        Try
            Select Case myInfo.GetResul
                Case SunatEntity.Resul.Ok
                    txtDireccion.Text = myInfo.ApeMaterno
                    txtRazon.Text = myInfo.Nombres
                    txtRuc.Text = myInfo.Ruc
                    txtEstado.Text = myInfo.Estado
                    txtTelefono.Text = myInfo.Telefono
                    'txtNumDni.Text = ""
                    txtCapcha.Text = ""
                    Exit Select
                Case SunatEntity.Resul.NoResul
                    Label8.Text = "No existe RUC"
                    txtDireccion.Text = ""
                    txtRazon.Text = ""
                    txtRuc.Text = ""
                    txtEstado.Text = ""
                    txtTelefono.Text = ""
                    txtRuc.Focus()
                    Exit Select
                Case SunatEntity.Resul.ErrorCapcha
                    CargarImagen()
                    Label8.Text = "Ingrese imagen correctamente"
                    txtCapcha.Focus()
                    Exit Select
                Case SunatEntity.Resul.[Error]
                    Label8.Text = "Error Desconocido"
                    Exit Select
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub CargarImagen()
        Try
            If myInfo Is Nothing Then
                myInfo = New SunatEntity
            End If
            pictureCapcha.Image = myInfo.GetCapcha
            pictureCapcha.Image.Save("d:/tempimage.jpeg")
            code = ""
            code = GetRandomText()
            'txtCapcha.Text = code
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub btnActualizar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnActualizar.Click
        Try
            CargarImagen()
            txtCapcha.Text = code
            txtCapcha.SelectAll()
            txtCapcha.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConsultar.Click
        Label8.Text = ""
        Try
            'If txtNumDni.Text.Length <> 11 Then
            '    Label8.Text = "Ingrese ruc Valido"
            '    txtNumDni.SelectAll()
            '    txtNumDni.Focus()
            '    Return
            'End If
            Dim criterioBusqueda As String = ""
            Dim tipoFiltro As String = ""
            If rbRuc.Checked Then
                tipoFiltro = "Ruc"
                criterioBusqueda = txtNumRuc.Text
                dgvLista.Visible = False
            End If
            If rbDni.Checked Then
                tipoFiltro = "Dni"
                criterioBusqueda = txtNumDni.Text
                dgvLista.Visible = False
            End If
            If RbRazSoc.Checked Then
                tipoFiltro = "RazSoc"
                criterioBusqueda = Replace(txtRazSoc.Text, " ", "%20")
            End If
            If rbRuc.Checked Then
                myInfo.GetInfo(criterioBusqueda, txtCapcha.Text)
                CaptionResul()
            End If
            If rbDni.Checked Then
                myInfo.GetInfo_Dni(criterioBusqueda, txtCapcha.Text)
                CaptionResul()
            End If
            If RbRazSoc.Checked Then
                If txtCapcha.Text.ToString.Length > 0 Then
                    dgvLista.DataSource = myInfo.GetInfo_RazonSocial(criterioBusqueda, txtCapcha.Text).Tables(0)
                Else
                    txtCapcha.Focus()
                End If
            End If
            CargarImagen()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private code As String
    Private Function GetRandomText() As String
        Dim randomText As New StringBuilder()
        If [String].IsNullOrEmpty(code) Then
            Dim alfabeto As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            Dim r As New Random()
            For j As Integer = 0 To 3
                randomText.Append(alfabeto(r.[Next](alfabeto.Length)))
            Next
            code = randomText.ToString()
        End If
        Return code
    End Function
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If numRuc.Length > 0 Then
            txtNumRuc.Text = numRuc
        End If
        Label8.Text = ""
        txtNumRuc.ReadOnly = False
        txtNumDni.ReadOnly = True
        txtRazSoc.ReadOnly = True
        dgvLista.RowTemplate.Height = 30
        txtNumRuc.Focus()
        'MsgBox(formInicio)
    End Sub

    Private Sub txtNumRuc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumRuc.KeyPress, txtNumDni.KeyPress, txtRazSoc.KeyPress, txtCapcha.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btnConsultar_Click(sender, e)
        End If
    End Sub

    Private Sub rbRuc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRuc.CheckedChanged
        If rbRuc.Checked Then
            dgvLista.Visible = False
            txtNumDni.Text = ""
            txtRazSoc.Text = ""
            txtNumRuc.ReadOnly = False
            txtNumDni.ReadOnly = True
            txtRazSoc.ReadOnly = True
            txtRuc.Focus()
        End If
    End Sub
    Private Sub rbDni_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDni.CheckedChanged
        If rbDni.Checked Then
            dgvLista.Visible = False
            txtNumRuc.Text = ""
            txtRazSoc.Text = ""
            txtNumRuc.ReadOnly = True
            txtNumDni.ReadOnly = False
            txtRazSoc.ReadOnly = True
            txtNumDni.Focus()
        End If
    End Sub
    Private Sub RbRazSoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbRazSoc.CheckedChanged
        If RbRazSoc.Checked Then
            dgvLista.Visible = True
            txtNumRuc.Text = ""
            txtNumDni.Text = ""
            txtNumRuc.ReadOnly = True
            txtNumDni.ReadOnly = True
            txtRazSoc.ReadOnly = False
            txtRazSoc.Focus()
        End If
    End Sub

    Private Sub btnElegirCuenta_Click(sender As Object, e As EventArgs) Handles btnElegirCuenta.Click
        elegirRegistro()
    End Sub

    Private Sub elegirRegistro()
        If formInicio = "frmNuevaCompraCredito" Then
            With frmNuevaCompra
                .txtRuc.Text = txtNumRuc.Text.ToString
                .txtRazonSocial.Text = txtRazon.Text.ToString
            End With
        ElseIf formInicio = "notacredito" Then
            With frmNuevaNotaCreditoVenta
                .txtRuc.Text = txtNumRuc.Text.ToString
                .txtRazon.Text = txtRazon.Text.ToString
            End With
        ElseIf formInicio = "frmNuevaCompraRapida" Then
            With frmNuevaCompraRapida
                .txtRuc.Text = txtNumRuc.Text.ToString
                .txtRazonSocial.Text = txtRazon.Text.ToString
            End With
        ElseIf formInicio = "compraM" Then
            With frmNuevaCompraMercaderias
                .txtRuc.Text = txtNumRuc.Text.ToString
                .txtRazonSocial.Text = txtRazon.Text.ToString
            End With
        ElseIf formInicio = "ventaM" Then
            With frmNuevaVentaMercaderias
                .txtRuc.Text = txtNumRuc.Text.ToString
                .txtRazonSocial.Text = txtRazon.Text.ToString
            End With
        ElseIf formInicio = "escoger_proveedor" Then
            With frmNuevaCompraP
                .txtRuc.Text = txtNumRuc.Text.Trim
                .txtRazonSocial.Text = txtRazon.Text.Trim
                .txtDireccion.Text = txtDireccion.Text.Trim
            End With
        ElseIf formInicio = "escoger_cliente" Then
            With frmNuevaVentaP
                .txtRuc.Text = txtNumRuc.Text.Trim
                .txtRazonSocial.Text = txtRazon.Text.Trim
                .txtDireccion.Text = txtDireccion.Text.Trim
            End With
        Else
            With frmNuevaVenta
                .txtRuc.Text = txtNumRuc.Text.ToString
                .txtRazonSocial.Text = txtRazon.Text.ToString
            End With
        End If
        Me.Close()
        frmEscogerProveedor.Close()
        frmEscogerCliente.Close()
        'frmNuevaCompra.Show()
    End Sub

    Private Sub dgvLista_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLista.CellDoubleClick
        elegirRegistroGrilla()
    End Sub

    Private Sub elegirRegistroGrilla()
        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid

        If formInicio = "frmNuevaCompraCredito" Then
            With frmNuevaCompra
                .txtRuc.Text = dgvLista.Rows(f).Cells("ruc").Value.ToString
                .txtRazonSocial.Text = dgvLista.Rows(f).Cells("razon").Value.ToString
                .txtDireccion.Text = dgvLista.Rows(f).Cells("ubicacion").Value.ToString()
            End With
        ElseIf formInicio = "notacredito" Then
            With frmNuevaNotaCreditoVenta
                .txtRuc.Text = dgvLista.Rows(f).Cells("ruc").Value.ToString
                .txtRazon.Text = dgvLista.Rows(f).Cells("ubicacion").Value.ToString
            End With
        ElseIf formInicio = "frmNuevaCompraRapida" Then
            With frmNuevaCompraRapida
                .txtRuc.Text = dgvLista.Rows(f).Cells("ruc").Value.ToString
                .txtRazonSocial.Text = dgvLista.Rows(f).Cells("ubicacion").Value.ToString
            End With
        ElseIf formInicio = "escoger_proveedor" Then
            With frmNuevaCompra
                .txtRuc.Text = dgvLista.Rows(f).Cells("ruc").Value.ToString
                .txtRazonSocial.Text = dgvLista.Rows(f).Cells("razon").Value.ToString
                .txtDireccion.Text = dgvLista.Rows(f).Cells("ubicacion").Value.ToString()
            End With
        Else
            With frmNuevaVenta
                .txtRuc.Text = dgvLista.Rows(f).Cells("ruc").Value.ToString
                .txtRazonSocial.Text = dgvLista.Rows(f).Cells("razon").Value.ToString
            End With
        End If
        Me.Dispose()
        frmEscogerProveedor.Dispose()
        frmNuevaCompra.Show()
    End Sub
End Class