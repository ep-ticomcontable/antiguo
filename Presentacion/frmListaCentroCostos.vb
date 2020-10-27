Imports Negocio
Imports Entidades
Public Class frmListaCentroCostos

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
        If formInicio = "agregarCuentaNuevo" Then
            btnElegir.Visible = True
        ElseIf formInicio = "frmPlanillas" Then
            btnElegir.Visible = True
        ElseIf formInicio = "editPlanilla" Then
            btnElegir.Visible = True
        ElseIf formInicio = "general" Then
            btnElegir.Visible = True
        ElseIf formInicio = "modificargeneral" Then
            btnElegir.Visible = True
        End If
    End Sub
    Private Sub frmListaCentroCostos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLista.RowTemplate.Height = 30
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        dgvCentralizacion.RowTemplate.Height = 30
        cebrasDatagrid(dgvCentralizacion, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        iCarga = 1
        If iCarga = 1 Then
            cargarDataCentroCostos()
        End If
        btnElegir.Focus()
        btnElegir.Select()
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
        data = obj.nCrudListarBD("usp_datosParametrosPorCentroCosto '" & dgvLista.Rows(f).Cells("id").Value & "'", CadenaConexion)
        dgvCentralizacion.DataSource = data
    End Sub

    Private Sub btnElegir_Click(sender As Object, e As EventArgs) Handles btnElegir.Click
        elegirCentroDeCosto()
    End Sub
    Private Sub elegirCentroDeCosto()
        If formInicio = "agregarCuentaNuevo" Then
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            With frmAgregarCuentasNuevo
                .txtIdCentro.Text = dgvLista.Rows(f).Cells("id").Value
                .txtCentro.Text = dgvLista.Rows(f).Cells("descripcion").Value
            End With
        ElseIf formInicio = "general" Then
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            With frmIngresosGenericos
                .txtIdCentro.Text = dgvLista.Rows(f).Cells("id").Value
                .txtCentro.Text = dgvLista.Rows(f).Cells("descripcion").Value
            End With
        ElseIf formInicio = "modificargeneral" Then
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            With frmModificarIngresosGenericos
                .txtIdCentro.Text = dgvLista.Rows(f).Cells("id").Value
                .txtCentro.Text = dgvLista.Rows(f).Cells("descripcion").Value
            End With
        ElseIf formInicio = "frmPlanillas" Then
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            With frmPlanillas
                .txtIdCentro.Text = dgvLista.Rows(f).Cells("id").Value
                .txtCentro.Text = dgvLista.Rows(f).Cells("descripcion").Value
            End With
        ElseIf formInicio = "editPlanilla" Then
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            With frmModificarPlanillas
                .txtIdCentro.Text = dgvLista.Rows(f).Cells("id").Value
                .txtCentro.Text = dgvLista.Rows(f).Cells("descripcion").Value
            End With
        End If
        Me.Close()
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        frmParametrosCentroCosto.ShowDialog()
    End Sub

    Private Sub dgvLista_SelectionChanged(sender As Object, e As EventArgs) Handles dgvLista.SelectionChanged
        On Error Resume Next
        cargarCuentasCentroCostos()
    End Sub
End Class