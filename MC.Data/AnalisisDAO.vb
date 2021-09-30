Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class AnalisisDAO
    Public Function GetByAnalisis() As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_analisis_get_all"
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)

        Catch ex As Exception
            Throw New Exception("AnalisisDAO.GetByAnalisis - log_analisis_get_all" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetByAnalisisBuscar(ByVal Criterio As String) As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_analisis_get_buscar"
            With .Parameters
                .Clear()
                .Add("@criterio", SqlDbType.VarChar, 50).Value = Criterio
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("AnalisisDAO.GetByAnalisis - log_analisis_get_all" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
End Class
