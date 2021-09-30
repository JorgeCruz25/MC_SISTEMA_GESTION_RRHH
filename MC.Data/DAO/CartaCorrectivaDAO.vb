Imports System.Data.SqlClient
Public Class CartaCorrectivaDAO
    Dim PrestamosBE As New PrestamosBE

    Public IdPrestamo As Integer
    Public Function GetByAllCartaCorrectiva() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CARTA_INFORMATIVA_VALIDADOS_ALL"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
    Public Function GetByAllHistoriaLCartaCorrectiva(ByVal FechaInicial As Date, ByVal FechaFinal As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CARTA_INFORMATIVA_HISTORICO_ALL"
            With .Parameters
                .Add("@FECHAINICIAL", SqlDbType.Date).Value = FechaInicial
                .Add("@FECHAFINAL", SqlDbType.Date).Value = FechaFinal
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
    Public Function ObtenerCantidadArchivosGetId(ByVal IdCartaInformativa As String) As String
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim Valor As String = ""
        Try
            Dim reader As SqlDataReader
            Dim cmd = New SqlCommand
            With cmd
                cnx.Open()

                .Connection = cnx
                .CommandType = CommandType.Text
                .CommandText = "SELECT COUNT(*) AS CANTIDADARCHIVO FROM MCRH_CARTA_INFORMATIVA_ARCHIVOS WHERE IDCARTAINFORMATIVA= '" + IdCartaInformativa + "'"
                reader = cmd.ExecuteReader()
                While reader.Read()
                    Valor = (reader.Item(0))
                End While
                cnx.Close()
            End With
        Catch ex As Exception

        End Try

        Return Valor
    End Function
    Public Function AprobarCartaCorrectiva(ByVal IdCartaInformativa As Integer, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CARTA_INFORMATIVA_APROBAR"
            With .Parameters
                .Add("@IDCARTAINFORMATIVA", SqlDbType.Int).Value = IdCartaInformativa
                .Add("@IDUSUARIO", SqlDbType.Int).Value = IdUsuario
            End With
        End With

        Try
            cnx.Open()
            cmd.ExecuteNonQuery()
            Result = True
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function
    Public Function AnularCartaCorrectiva(ByVal IdCartaInformativa As Integer, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CARTA_INFORMATIVA_ANULAR"
            With .Parameters
                .Add("@IDCARTAINFORMATIVA", SqlDbType.Int).Value = IdCartaInformativa
                .Add("@IDUSUARIO", SqlDbType.Int).Value = IdUsuario
            End With
        End With

        Try
            cnx.Open()
            cmd.ExecuteNonQuery()
            Result = True
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function
    Public Function ListarAdjuntosCartaCorrectiva(ByVal IdCartaInformativa As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CARTA_INFORMATIVA_ARCHIVO_GETID"
            With .Parameters
                .Add("@IDCARTAINFORMATIVA", SqlDbType.Int).Value = IdCartaInformativa
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

End Class
