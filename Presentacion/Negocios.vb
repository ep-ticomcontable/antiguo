Imports System.Data
Imports System.Data.SqlClient
Public Class Negocios

    Dim obj As New Datos

    Public Function nRegNuevaEmpresa(nomEmpresa As String, ByVal sqlBD As String, _
                                      ByVal sqlTables As String, _
                                      ByVal stores() As String) As String
        Try
            Dim rpta As String = ""
            rpta = obj.dRegNuevaEmpresa(nomEmpresa)
            If rpta = "1" Then

                rpta = obj.dEjecutarConsulta(sqlBD)
                If rpta = "1" Then
                    rpta = obj.dEjecutarConsulta(sqlTables)

                    If rpta = "1" Then
                        For Each strSQL As String In stores

                            If strSQL <> Nothing Then
                                rpta = obj.dEjecutarConsultaEnBD(nomEmpresa, strSQL)

                                If rpta <> "1" Then
                                    rpta = ("ERROR EN: " & rpta)
                                    Exit For
                                End If
                            End If
                        Next

                    End If

                End If
            End If

            Return rpta
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
End Class
