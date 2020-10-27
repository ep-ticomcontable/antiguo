Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class Conexion
    Public cn As New SqlConnection
    Public cmd As SqlCommand
    Public da As SqlDataAdapter

    Public Function conectar() As SqlConnection
        cn.ConnectionString = ConfigurationManager.ConnectionStrings("cnx").ConnectionString()
        cn.Open()
        Return cn
    End Function

    Public Sub desconectar()
        cn.Close()
    End Sub
End Class
