Imports System.Data.SqlClient

Public Class DescuentoReintegroDAO

    Public Function GetDescuentoReintegroPeriodoList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_DESCUENTOS_REINTEGROS_PERIDO_RRHH_LIST"
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

    Public Function GetDescuentoReintegroList(ByVal idperiodo As Integer, ByVal tipo As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_DESCUENTOS_REINTEGROS_RRHH_LIST"
            With .Parameters
                .Add("@IDPERIODO", SqlDbType.Int).Value = idperiodo
                .Add("@TIPO", SqlDbType.Int).Value = tipo
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
    Public Function GetDescuentoReintegroFechaEmisionList(ByVal fechainicio As Date, ByVal fechafin As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_DESCUENTOSREINTEGROS_FECHAEMISION_LIST"
            With .Parameters
                .Add("@FECHAINICIO", SqlDbType.Date).Value = fechainicio
                .Add("@FECHAFIN", SqlDbType.Date).Value = fechafin
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
    Public Function GetDescuentoReintegroReporteGeneralList(ByVal fechainicial As Date, ByVal fechafinal As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_DESCUENTOS_REINTEGROS_PRESTAMOS_LIST"
            With .Parameters
                .Add("@FECHAINICIAL", SqlDbType.Date).Value = fechainicial
                .Add("@FECHAFINAL", SqlDbType.Date).Value = fechafinal
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

    Public Function ProcesarDescuento(ByVal iddescuento As String, ByVal idusuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_GENERAR_DESCUENTO_COLABORADOR"
            With .Parameters
                .Add("@IDDESCUENTO", SqlDbType.Int).Value = iddescuento
                .Add("@IDUSUARIO", SqlDbType.Int).Value = idusuario
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
            End With
        End With
    End Function 'OK
End Class
