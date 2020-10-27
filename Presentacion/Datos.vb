Imports System.Data
Imports System.Data.SqlClient

Public Class Datos
    Inherits Conexion

    Public Function dRegNuevaEmpresa(nombre As String) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim miTran As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = miTran
                .CommandType = CommandType.StoredProcedure
                .CommandText = "spi_empresa"
                .Parameters.Add("@nombreEmpresa", SqlDbType.VarChar).Value = nombre
                .ExecuteNonQuery()
            End With
            miTran.Commit()
            Return "1"
        Catch ex As Exception
            miTran.Rollback()
            Return "2"
        Finally
            desconectar()
        End Try
    End Function

    Public Function dEjecutarConsulta(ByVal sql As String) As String
        If cn.State = ConnectionState.Closed Then conectar()
        cmd = New SqlCommand

        Try
            With cmd
                .Connection = cn
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_ejecutarQuery"
                .Parameters.Add("@query", SqlDbType.Text).Value = sql
                .ExecuteNonQuery()
            End With

            Return "1"
        Catch ex As Exception
            Return "2"
        Finally
            desconectar()
        End Try
    End Function

    Public Function dEjecutarConsultaEnBD(ByVal nombreBD As String, ByVal sql As String) As String
        If cn.State = ConnectionState.Closed Then conectar()
        cn.ChangeDatabase(nombreBD)

        cmd = New SqlCommand

        Try
            With cmd
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = sql
                .ExecuteNonQuery()
            End With

            Return "1"
        Catch ex As Exception
            Return "2"
        Finally
            desconectar()
        End Try
    End Function
End Class
