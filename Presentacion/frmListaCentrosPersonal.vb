Imports Negocio
Imports Entidades
Public Class frmListaCentrosPersonal

    Dim obj As New nCrud
    Public formInicio As String = ""
    Dim iCarga As Integer = 0

    Private Sub cargarDatosListado()
        Dim grilla As New DataTable
        With grilla
            .Columns.Add("cuenta")
            .Columns.Add("desc_cuenta")
            .Columns.Add("debe")
            .Columns.Add("haber")
            .Columns.Add("descripcion")
        End With

        Dim data As New DataTable
        'data = obj.nCrudListarBD("select * from asientos_comprobante_compra where month(fec_emision)='" & cboMes.SelectedValue.ToString & "' and year(fec_emision)='" & cboAnio.SelectedValue.ToString & "' order by fec_emision asc", CadenaConexion)
        For Each row As DataRow In data.Rows
            With row
                grilla.Rows.Add(.Item("cuenta").ToString, obtenerDatosCuenta(.Item("cuenta").ToString), .Item("debe").ToString, .Item("haber").ToString, .Item("glosa").ToString)
            End With
        Next
        dgvLista.DataSource = grilla

        Dim sd, sh As Decimal
        For Each row As DataGridViewRow In dgvLista.Rows
            sd += row.Cells("debe").Value
            sh += row.Cells("haber").Value
        Next
    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = obj.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function
    Public Sub cargarDataCentroCostos()
        Dim data As New DataTable
        data = obj.nCrudListarBD("usp_dataCentroCosto", CadenaConexion)
        dgvLista.DataSource = data
        lblTotal.Text = dgvLista.RowCount
    End Sub
    Private Sub frmListaCentroCostos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLista.RowTemplate.Height = 30
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        dgvPersonal.RowTemplate.Height = 30
        cebrasDatagrid(dgvPersonal, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        If formInicio = "planilla" Then
            dgvLista.Columns(0).Visible = True
            dgvLista.Columns("descripcion").Width = 495
            btnElegir.Visible = True
        Else
            dgvLista.Columns(0).Visible = False
            dgvLista.Columns("descripcion").Width = 495 + 35
            btnElegir.Visible = False
        End If
        iCarga = 1
        If iCarga = 1 Then
            cargarDataCentroCostos()
            marcarExistentes()
        End If
        btnElegir.Focus()
        btnElegir.Select()
    End Sub
    Private Sub marcarExistentes()
        If frmPlanillas.txtArrayPersonal.Text.Trim <> "0" Then
            Dim array As String()
            array = frmPlanillas.txtArrayPersonal.Text.Trim.Split(",")
            For i As Integer = 0 To array.Count - 1
                For Each row As DataGridViewRow In dgvLista.Rows
                    If row.Cells("id").Value.ToString = array(i) Then
                        row.Cells(0).Value = True
                        Exit For
                    End If
                Next
            Next
        End If
    End Sub
    Private Sub dgvLista_CellStateChanged(sender As Object, e As DataGridViewCellStateChangedEventArgs) Handles dgvLista.CellStateChanged
        cargarCuentasCentroCostos()
    End Sub

    Private Sub dgvLista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvLista.KeyDown
        cargarCuentasCentroCostos()
        If e.KeyCode = Keys.Enter Then
            elegirCentroDeCosto()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub cargarCuentasCentroCostos()
        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid

        Dim data As New DataTable
        data = obj.nCrudListarBD("select p.id,p.cod_dni,p.cuspp,p.nombres,p.ape_pat,p.ape_mat,p.fec_ingreso,p.cargo,p.moneda,p.sueldo_basico,p.asignacion,p.valor_asignacion,p.seguro,p.aportaciones, p.descuentos , p.total from vista_listaPersonal p inner join centro_costo_personal c on p.id=c.id_personal where c.id_centro='" & dgvLista.Rows(f).Cells("id").Value & "'", CadenaConexion)
        dgvPersonal.DataSource = data
    End Sub

    Private Sub btnElegir_Click(sender As Object, e As EventArgs) Handles btnElegir.Click
        elegirCentroDeCosto()
    End Sub
    Private Sub elegirCentroDeCosto()
        If dgvLista.Rows.Count > 0 Then
            Dim totalMarcados As Integer = 0
            Dim marcados As String = ""
            For Each row As DataGridViewRow In dgvLista.Rows
                If row.Cells(0).Value = True Then
                    marcados &= row.Cells("id").Value.ToString & ","
                    totalMarcados += 1
                End If
            Next
            If totalMarcados > 0 Then
                Dim f As Integer
                f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
                With frmPlanillas
                    .txtPersonal.Text = "(" & totalMarcados & ") CENTRO(S)"
                    .txtArrayPersonal.Text = marcados.Substring(0, marcados.Length - 1)
                End With
            Else
                Dim f As Integer
                f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
                With frmPlanillas
                    .txtPersonal.Text = "-"
                    .txtArrayPersonal.Text = "0"
                End With
                'MsgBox("ELIJA UN CENTRO")
            End If
            Me.Close()
        End If
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        frmAnexoPersonalCentroCosto.Show()
    End Sub

    Private Sub dgvLista_SelectionChanged(sender As Object, e As EventArgs) Handles dgvLista.SelectionChanged
        On Error Resume Next
        cargarCuentasCentroCostos()
    End Sub
End Class