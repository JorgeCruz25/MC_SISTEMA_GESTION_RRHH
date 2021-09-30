Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel.DataAnnotations

Public Class PermisoDAO

    Public Function GetByALL() As DataTable
        Dim cnx As New SqlConnection(strCnxLabRoe)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "roe_permiso_get_all"
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("PermisoDAO.GetByALL - roe_permiso_get_all" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetByIDUsuario(IDUsuario As Int32) As DataTable
        Dim cnx As New SqlConnection(strCnxLabRoe)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "roe_permiso_get_idusuario"
            .Parameters.Add("@idusuario", SqlDbType.Int).Value = IDUsuario
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("PermisoDAO.GetByIDUsuario - roe_permiso_get_idusuario" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
End Class
