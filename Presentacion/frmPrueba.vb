'Option Strict Off
Imports Negocio
Imports System.Data.SqlClient

Public Class frmPrueba
    Dim carpetaDestino As String = "D:\BDS\empresas\"
    Dim objCrud As New nCrud
    Dim carga As Integer = 0

    Private Sub cargarBDs()
        Dim tbData As New DataTable
        tbData.Columns.Add("Codigo")
        tbData.Columns.Add("Nombre")
        tbData.Rows.Add("BTECPERU", "BTECPERU")
        tbData.Rows.Add("CARLOS", "CARLOS")
        tbData.Rows.Add("TICOM", "TICOM")
        With cboBd
            .DataSource = tbData
            .ValueMember = "Codigo"
            .DisplayMember = "Nombre"
        End With
    End Sub

    Private Sub frmPrueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarBDs()
        carga = 1
    End Sub
    Private Sub copiarBD()
        controlarServicio("stop", "MSSQL$" & SERVER)
        Dim nomBD As String = txtNombre.Text.Trim
        Dim fileMdf As String = CARPETA_BDS & BD_MASTER & ".mdf"
        My.Computer.FileSystem.CopyFile(
            fileMdf,
            carpetaDestino & nomBD & ".mdf",
            Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
            Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)

        Dim fileLdf As String = CARPETA_BDS & BD_MASTER & "_log.ldf"
        My.Computer.FileSystem.CopyFile(
            fileLdf,
            carpetaDestino & nomBD & "_log.ldf",
            Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
            Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)

        controlarServicio("start", "MSSQL$" & SERVER)
        MsgBox("Base de datos copiada")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        copiarBD()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nomBD As String = txtNombre.Text.Trim
        MsgBox(objCrud.nCargarBD(nomBD, carpetaDestino))
    End Sub

    Private Sub controlarServicio(control As String, nombreServicio As String)
        Dim myProcess As New Process()
        myProcess.StartInfo.UseShellExecute = False

        myProcess.StartInfo.FileName = "cmd.exe" 'Aquí  le pasarías el nombre de tu programa
        myProcess.StartInfo.CreateNoWindow = True
        myProcess.StartInfo.Arguments = "/c net " & control & " " & nombreServicio 'Aquí le pasarías los argumentos
        myProcess.StartInfo.CreateNoWindow = False
        myProcess.Start()
        myProcess.WaitForExit()
    End Sub

    Private Sub cboBd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBd.SelectedIndexChanged
        If carga = 1 Then
            Dim cadena As String
            cadena = "Server=" & SERVER & ";DataBase=" & cboBd.SelectedValue.ToString & ";Uid=sa;Password=123456;"
            'MsgBox(objCrud.nCambiarBD(cboBd.SelectedValue.ToString))
           
            Dim sSel As String = "SELECT * FROM cuenta_contable"

            Dim da As SqlDataAdapter
            Dim dt As New DataTable
            Try
                da = New SqlDataAdapter(sSel, cadena)
                da.Fill(dt)

                dgvLista.DataSource = Nothing
                dgvLista.DataSource = dt

            Catch ex As Exception
                MsgBox("Error: " & ex.Message)

            End Try

            'MsgBox(objCrud.nEstablecerBDInicio(cadena))
            'dgvLista.DataSource = Nothing
            'dgvLista.DataSource = objCrud.nCrudListarBD("select * from [" & cboBd.SelectedValue.ToString & "].dbo.cuenta_contable order by id asc")
        End If
    End Sub
End Class