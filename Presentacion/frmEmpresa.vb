Imports System.IO

Public Class frmEmpresa

    Dim obj As New Negocios

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim nomEmpresa As String = txtNomEmpresa.Text.Trim
        Dim rpta As String

        Dim ruta_base, archivo_script As String
        Dim sqlBD, sqlTablas, sqlStores As String
        Dim stores() As String

        ruta_base = Directory.GetCurrentDirectory
        ruta_base = ruta_base.Substring(0, ruta_base.Length - 9)
        archivo_script = ruta_base & "plantilla\script_bd.sql"

        Dim objReader As StreamReader
        objReader = New StreamReader(archivo_script)

        sqlBD = objReader.ReadToEnd
        objReader.Close()

        sqlBD = sqlBD.Replace("XXX", nomEmpresa)
        sqlBD = sqlBD.Replace("GO", ";")

        archivo_script = ruta_base & "plantilla\script_tables.sql"
        objReader = New StreamReader(archivo_script)
        sqlTablas = objReader.ReadToEnd
        objReader.Close()

        sqlTablas = sqlTablas.Replace("XXX", nomEmpresa)
        sqlTablas = sqlTablas.Replace("GO", ";")

        archivo_script = ruta_base & "plantilla\script_stores.sql"
        objReader = New StreamReader(archivo_script)
        sqlStores = objReader.ReadToEnd
        objReader.Close()

        sqlStores = sqlStores.Replace("GO", ";")
        stores = sqlStores.Split(";")
        rpta = obj.nRegNuevaEmpresa(nomEmpresa, sqlBD, sqlTablas, stores)

        If rpta = "1" Then
            MessageBox.Show("Empresa registrada correctamente", "Confirmacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error. Revise el Log de Errores. " & rpta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub frmEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
