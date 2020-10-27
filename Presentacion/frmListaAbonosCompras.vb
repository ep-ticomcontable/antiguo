Imports Negocio
Public Class frmListaAbonosCompras

    Dim obj As New nEmpresas
    Dim objCrud As New nCrud
    Public idComprobante As String

    Private Sub cargarPagos()
        Dim data As New DataTable
        data = objCrud.nCrudListarBD("select id,tipo,descripcion,monto,fecha from abono_pagos_compras where id_compra='" & idComprobante & "' order by fecha asc", CadenaConexion)
        dgvEmpresas.DataSource = data
        cebrasDatagrid(dgvEmpresas, Drawing.Color.White, Drawing.Color.FromArgb(197, 218, 242))
    End Sub

    Private Sub frmEleccionEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox(CodigoUsuarioSession)
        cargarPagos()
    End Sub
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        cargarPagos()
    End Sub

    Private Sub pbCerrar_Click(sender As Object, e As EventArgs) Handles pbCerrar.Click
        Me.Close()
    End Sub
End Class