Imports Negocio
Imports Entidades
Public Class frmAgregarAsiento
    Dim objMon As New nMonedas
    Dim objAs As New nAsientoApertura
    Dim entiDAA As New DetalleAAperturaEntity
    Dim objCrud As New nCrud
    Dim objTDA As New nTipoDocumentoAsiento
    Public idAsientoApertura As Integer
    Dim iCarga As Integer = 0
    Dim idTipoOperacion As Integer = 16


    Private Sub cargarMonedas()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListarBD("select id,codigo,descripcion from tipo_moneda where estado=1 order by codigo asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, "(" & row.Item(1).ToString & ") " & row.Item(2).ToString)
            Next
            With cboMoneda
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
                .SelectedValue = 115
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Monedas")
        End Try
    End Sub

    Private Sub cargarTipoDeCambio()
        If iCarga = 1 Then
            Dim data As New DataTable
            data = objMon.nTipoDeCambioPorMonedaBD(cboMoneda.SelectedValue.ToString, CadenaConexion)
            'lblTipoDeCambio.Text = "Tipo de cambio: S/. " & data.Rows(0)("valor").ToString
            If data.Rows.Count > 0 Then
                txtTC.Text = data.Rows(0)("venta").ToString
            Else
                txtTC.Text = "1.00"
            End If
        End If
    End Sub

    Private Sub CargarTipoDocumento()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = objTDA.nListarCuentasSegunTipoAsientoBD(idTipoOperacion, CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, "(" & row.Item(1).ToString & ") " & row.Item(2).ToString.ToUpper)
            Next
            With cboTipoDocumento
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Documentos")
        End Try
    End Sub

    Private Sub frmAgregarAsiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarMonedas()
        CargarTipoDocumento()
        iCarga = 1
        cargarTipoDeCambio()
        limpiarCajas()
    End Sub

    Private Sub limpiarCajas()
        txtCuenta.Text = ""
        lblNomCuenta.Text = "[Nombre Cuenta]"
        txtDebe.Text = "00.00"
        txtHaber.Text = "00.00"
        cboMoneda.SelectedValue = "115"
        cargarTipoDeCambio()
        cboTipoDocumento.SelectedValue = "1"
        txtNumero.Text = "-"
        txtGlosa.Text = ""
    End Sub

    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtCuenta.Text.Trim.Length >= 2 Then
                frmEscogerPlanContable.formInicio = "apertura"
                frmEscogerPlanContable.cuentaInicio = txtCuenta.Text.Trim
                frmEscogerPlanContable.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        With entiDAA
            .id_asiento_apertura = idAsientoApertura
            .cuenta = txtCuenta.Text.Trim
            .debe = txtDebe.Text.Trim
            .haber = txtHaber.Text.Trim
            .id_moneda = cboMoneda.SelectedValue.ToString
            .tipo_cambio = txtTC.Text.Trim
            .glosa = txtGlosa.Text.Trim
            .id_doc_cont = cboTipoDocumento.SelectedValue.ToString
            .num_doc = txtNumero.Text.Trim
            .fec_emision = dtFecha.Value
        End With
        MsgBox("Detalle de Asiento de Apertura agregado: " & vbCrLf & objAs.nRegistrarDetalleAsientoAperturaBD(entiDAA, CadenaConexion))
        With frmAsientoApertura
            .cargarDetalleAsientoApertura()
            .realizarCalculos()
            .cargarNumeroDeAsientoApertura()
        End With

        Me.Close()
    End Sub

    Private Sub cboMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMoneda.SelectedIndexChanged
        If iCarga = 1 Then
            cargarTipoDeCambio()
        End If
    End Sub
    Private Sub txtDebe_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDebe.Leave
        txtDebe.Text = Format(CType(txtDebe.Text, Decimal), "###0.00")
    End Sub
    Private Sub txtHaber_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHaber.Leave
        txtHaber.Text = Format(CType(txtHaber.Text, Decimal), "###0.00")
    End Sub
    Private Sub txtTC_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTC.Leave
        txtTC.Text = Format(CType(txtTC.Text, Decimal), "###0.00")
    End Sub
End Class