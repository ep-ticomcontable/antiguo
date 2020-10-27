Imports Negocio
Imports Entidades

Public Class frmParametrosCentroCosto

    Dim objCrud As New nCrud
    Dim obj As New nCentroCostos
    Dim iCarga As Integer = 0
    Public idCentro As String = ""
    Public tipo As String = ""

    Private Sub cargarIdCentro()
        Dim data As New DataTable
        data = objCrud.nCrudListarBD("select isnull(((id)+1),1) as 'id' from centro_costos ORDER BY id desc", CadenaConexion)
        txtCodigo.Text = data.Rows(0)("id").ToString
    End Sub

    Private Sub frmCrearCentroCosto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarIdCentro()
        txtDescripcion.Select()
        txtDescripcion.Focus()
        iCarga = 1
    End Sub

    Private Sub txtDebe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDebe.KeyPress
        On Error Resume Next
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                If txtDebe.Text.Trim.Length >= 2 Then
                    With frmEscogerPlanContable
                        .formInicio = "frmCentroCosto"
                        .input = "debe"
                        .cuentaInicio = (txtDebe.Text.Trim)
                        .ShowDialog()
                    End With
                End If
            End If
            If Asc(e.KeyChar) = 13 Then
                txtHaber.Focus()
            End If
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                If txtDebe.Text.Trim.Length >= 2 Then
                    With frmEscogerPlanContable
                        .formInicio = "frmCentroCosto"
                        .input = "debe"
                        .cuentaInicio = (txtDebe.Text.Trim)
                        .ShowDialog()
                    End With
                End If
            End If
            If Asc(e.KeyChar) = 13 Then
                txtHaber.Focus()
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtHaber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHaber.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtHaber.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "frmCentroCosto"
                    .input = "haber"
                    .cuentaInicio = (txtHaber.Text.Trim)
                    .ShowDialog()
                End With
            End If
        End If
        If Asc(e.KeyChar) = 13 Then
            txtPorcentaje.Focus()
        End If
    End Sub

    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)("nombre").ToString
        Else
            MsgBox("El número de cuenta contable (" & cuenta & "), no es válido")
            Return "ERROR"
        End If
    End Function


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If obtenerDatosCuenta(txtDebe.Text.Trim) <> "ERROR" And obtenerDatosCuenta(txtHaber.Text.Trim) <> "ERROR" Then
            If txtDebe.Text.Trim.Length > 0 And txtDebe.Text.Trim.Length > 0 And Decimal.Parse(txtPorcentaje.Text.Trim) > 0 Then
                Dim data As New DataTable
                With data.Columns
                    .Add("cuenta")
                    .Add("desc_cuenta")
                    .Add("debe")
                    .Add("haber")
                    .Add("porcentaje")
                End With

                If dgvLista.RowCount = 0 Then
                    data.Rows.Add(txtDebe.Text.Trim, obtenerDatosCuenta(txtDebe.Text.Trim), "X", "", Decimal.Parse(txtPorcentaje.Text.Trim))
                    data.Rows.Add(txtHaber.Text.Trim, obtenerDatosCuenta(txtHaber.Text.Trim), "", "X", Decimal.Parse(txtPorcentaje.Text.Trim))
                    dgvLista.DataSource = data
                Else
                    Dim dt As DataTable = DirectCast(dgvLista.DataSource, DataTable)
                    Dim row As DataRow = dt.NewRow()
                    row.Item(0) = txtDebe.Text.Trim
                    row.Item(1) = obtenerDatosCuenta(txtDebe.Text.Trim)
                    row.Item(2) = "X"
                    row.Item(3) = ""
                    row.Item(4) = Decimal.Parse(txtPorcentaje.Text.Trim)
                    dt.Rows.Add(row)
                    Dim dt2 As DataTable = DirectCast(dgvLista.DataSource, DataTable)
                    Dim row2 As DataRow = dt2.NewRow()
                    row2.Item(0) = txtHaber.Text.Trim
                    row2.Item(1) = obtenerDatosCuenta(txtHaber.Text.Trim)
                    row2.Item(2) = ""
                    row2.Item(3) = "X"
                    row2.Item(4) = Decimal.Parse(txtPorcentaje.Text.Trim)
                    dt2.Rows.Add(row2)
                End If
                txtDebe.Text = ""
                lblDebe.Text = "[Nombre Cuenta]"
                txtHaber.Text = ""
                lblHaber.Text = "[Nombre Cuenta]"
                txtPorcentaje.Text = "0.00"
                txtDebe.Focus()
            Else
                MsgBox("Ingrese parametros para agregar la cuenta")
            End If
        Else
            MsgBox("Las cuentas ingresadas no son válidas")
        End If
    End Sub
    Private Function verificarPartidaDoble() As Boolean
        Dim rpta As Boolean = False
        Dim sDebe, sHaber As Decimal
        'For Each row As DataGridViewRow In dgvLista.Rows
        '    sDebe = sDebe + Decimal.Parse(row.Cells("debe").Value.ToString)
        '    sHaber = sHaber + Decimal.Parse(row.Cells("haber").Value.ToString)
        'Next
        'If sDebe = sHaber And sDebe > 0 And sHaber > 0 Then
        '    rpta = True
        'Else
        '    MsgBox("La suma de las cantidades en las columnas del DEBE & HABER no son iguales.")
        'End If
        Return True
    End Function
    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        If txtDescripcion.Text.Trim.Length > 2 And dgvLista.RowCount > 0 Then
            If verificarPartidaDoble() = True Then
                Dim rpta As String
                Dim subCentro As Integer
                subCentro = 1
                rpta = obj.registrarCentroCostoBD("1", txtDescripcion.Text.Trim, "1", subCentro, "1", CadenaConexion)
                If rpta = "ok" Then
                    Dim rpta1 As String
                    For Each row As DataGridViewRow In dgvLista.Rows
                        rpta1 = obj.registrarParametroCentroCostoBD(txtCodigo.Text.Trim, row.Cells("desc_cuenta").Value.ToString, row.Cells("porcentaje").Value.ToString, row.Cells("cuenta").Value.ToString, row.Cells("debe").Value.ToString, row.Cells("haber").Value.ToString, "1", CadenaConexion)
                    Next
                Else
                    MessageBox.Show("Error al registrar: " & vbCrLf & rpta, "Centro de Costo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
                frmListaCentroCostos.cargarDataCentroCostos()
                'resetear entradas
                cargarIdCentro()
                txtDescripcion.Text = ""
                Me.Close()
                limpiarEntradas()
                MessageBox.Show("Parámetros registrados con éxito", "Parámetros del Centro de Costo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
        ElseIf txtDescripcion.Text.Trim.Length = "0" Then
            MessageBox.Show("Ingrese una descripción", "Centro de Costo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txtDescripcion.Focus()
        End If
    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtDebe.Focus()
        End If
    End Sub
    Private Sub txtPorcentaje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPorcentaje.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnAgregar.PerformClick()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiarEntradas()
        Me.Close()
    End Sub
    Private Sub limpiarEntradas()
        txtDescripcion.Text = ""
        txtDebe.Text = ""
        txtHaber.Text = ""
        txtPorcentaje.Text = "0.00"
        Dim data As New DataTable
        With data.Columns
            .Add("cuenta")
            .Add("desc_cuenta")
            .Add("debe")
            .Add("haber")
            .Add("porcentaje")
        End With
        dgvLista.DataSource = data
    End Sub
End Class