Imports Negocio
Public Class frmTareasModulo

    Dim obj As New nCrud
    Dim iCarga As Integer = 0

    Private Sub cargarPerfiles()
        Dim data As New DataTable
        data = obj.nCrudListarBD("select id,nombre,CASE WHEN estado = '0' THEN 'INACTIVO' ELSE 'ACTIVO' END AS estado from perfiles order by nombre asc", CadenaConexion)
        dgvPerfiles.DataSource = data
        data = Nothing
    End Sub

    Private Sub cargarModulos()
        Dim data As New DataTable
        data = obj.nCrudListarBD("select id as 'id_modulo',nombre as 'nom_modulo' from modulos where estado=1 order by nombre asc", CadenaConexion)
        dgvModulos.DataSource = data
        data = Nothing
    End Sub

    Private Sub cargarTareas()
        Dim data As New DataTable
        data = obj.nCrudListarBD("select id as 'id_tarea',nombre as 'nom_tarea' from tareas where estado=1 order by nombre asc", CadenaConexion)
        dgvTareas.DataSource = data
        data = Nothing
    End Sub

    Private Sub frmTareasModulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarPerfiles()
        cargarTareas()
        cargarModulos()
        iCarga = 1
    End Sub

    Private Sub cboProcesos_SelectedIndexChanged(sender As Object, e As EventArgs)
        If iCarga = 1 Then
            Dim data As New DataTable
            'data = obj.nCrudListarBD("usp_obtenerTareasPorModulo '" & cboProcesos.SelectedValue.ToString & "'")
            'Desmarcar los checks

            For Each filaCol As DataGridViewRow In dgvTareas.Rows
                filaCol.Cells(0).Value = False
            Next

            For Each fila As DataGridViewRow In dgvTareas.Rows
                For i As Integer = 0 To data.Rows.Count - 1
                    If fila.Cells("id_tarea").Value = data.Rows(i)("id_tarea").ToString Then  'tiene el check marcado
                        fila.Cells(0).Value = True
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub dgvPerfiles_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPerfiles.SelectionChanged
        cargarChecksModulos()
    End Sub
    Private Sub cargarChecksModulos()
        If iCarga = 1 Then
            Dim f As Integer
            f = dgvPerfiles.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            Dim idPerfil As Integer
            idPerfil = dgvPerfiles.Rows(f).Cells("id").Value.ToString

            Dim data As New DataTable
            data = obj.nCrudListarBD("select id_modulo from perfil_modulos where id_perfil='" & idPerfil & "'", CadenaConexion)

            For Each filaCol As DataGridViewRow In dgvModulos.Rows
                filaCol.Cells(0).Value = False
            Next

            MsgBox(idPerfil)
            For Each fila As DataGridViewRow In dgvModulos.Rows
                For i As Integer = 0 To data.Rows.Count - 1
                    If fila.Cells("id_modulo").Value = data.Rows(i)("id_modulo").ToString Then  'tiene el check marcado
                        fila.Cells(0).Value = True
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub cargarChecksTareas()
        If iCarga = 1 Then
            Dim f As Integer
            f = dgvPerfiles.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            Dim idPerfil As Integer
            idPerfil = dgvModulos.Rows(f).Cells("id").Value.ToString

            Dim data As New DataTable
            data = obj.nCrudListarBD("select id_modulo from proceso_modulos where id_perfil_modulo='" & idPerfil & "'", CadenaConexion)

            For Each filaCol As DataGridViewRow In dgvModulos.Rows
                filaCol.Cells(0).Value = False
            Next

            MsgBox(idPerfil)
            For Each fila As DataGridViewRow In dgvModulos.Rows
                For i As Integer = 0 To data.Rows.Count - 1
                    If fila.Cells("id_modulo").Value = data.Rows(i)("id_modulo").ToString Then  'tiene el check marcado
                        fila.Cells(0).Value = True
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub dgvModulos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvModulos.SelectionChanged

    End Sub
End Class