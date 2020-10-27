Imports System.Configuration

Module Configuracion
    Public wForm As Integer = 1050
    Public hForm As Integer = 716
    Public rutaServer As String = "ftp://ftp.ticomsoftware.com/"
    Public usuarioFtp As String = "ticom@ticomsoftware.com"
    Public passwordFtp As String = "12ticom34"
    Public rutaEnvio As String = "D:\replicacion\enviar\"
    Public rutaRecepcion As String = "D:\replicacion\recibir\"
    Public CodigoLocalSession As Integer
    Public CodigoUsuarioSession As Integer
    Public NombreUsuarioSession As String
    Public TipoUsuarioSession As String
    Public CodigoEmpleadoSession As Integer
    Public CodigoEmpresaSession As Integer
    Public AnioEjercicio As Integer
    Public fondoPantalla As Object
    Public PROCESOS As String = ""
    Public Sub cebrasDatagrid(ByVal grilla As DataGridView, ByVal col1 As Color, ByVal col2 As Color)
        With grilla
            .RowsDefaultCellStyle.BackColor = col1
            .AlternatingRowsDefaultCellStyle.BackColor = col2
        End With
    End Sub
    Public SERVER As String = System.Configuration.ConfigurationManager.AppSettings("SERVER")
    Public CARPETA_BDS As String = System.Configuration.ConfigurationManager.AppSettings("CARPETA_BDS")
    Public CARPETA_EXCELS As String = System.Configuration.ConfigurationManager.AppSettings("CARPETA_EXCELS")
    Public BD_MASTER As String = System.Configuration.ConfigurationManager.AppSettings("BD_MASTER")
    Public CadenaConexion As String = "Server=" & SERVER & ";DataBase=" & BD_MASTER & ";Uid=sa;Password=123456;"
    'Public CadenaConexion As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\bd\bdTicomContable.mdf;Integrated Security=True"
End Module
