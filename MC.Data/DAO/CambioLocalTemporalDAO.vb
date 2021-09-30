Imports System.Data.SqlClient
Public Class CambioLocalTemporalDAO
    Dim CambioLocalTemporalBE As New CambioLocalTemporalBE
    Public IdCambioTemporal As Integer

    Public Function CambioTemporalLocalListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_EMPLEADOCAMBIOTEMPORAL_LIST_PREVIEW_ALL]"
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

    End Function 'OK
    Public Function GetCambioTemporalByID(ByVal IDCAMBIOTEMPORAL As Int32) As CambioLocalTemporalBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_EMPLEADOCAMBIOTEMPORAL_GET_BY_ID]"
            With .Parameters
                .Add("@IDEMPLEADOCAMBIOTEMPORAL", SqlDbType.Int).Value = IDCAMBIOTEMPORAL
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With CambioLocalTemporalBE
                        .IDEMPLEADOCAMBIOTEMPORAL = dr.ReadNullAsNumeric("IDEMPLEADOCAMBIOTEMPORAL")
                        '.NUMEROEMPLEADOCAMBIOTEMPORAL = dr.ReadNullAsEmptyString("NUMEROEMPLEADOCAMBIOTEMPORAL")
                        .FECHA = dr.ReadNullAsEmptyDate("FECHA")
                        .SOLICITANTENOMBRE = dr.ReadNullAsEmptyString("SOLICITANTENOMBRE")
                        .EMPLEADONOMBRE = dr.ReadNullAsEmptyString("EMPLEADONOMBRE")
                        .EMPLEADOCARGO = dr.ReadNullAsEmptyString("EMPLEADOCARGO")
                        .EMPLEADODNI = dr.ReadNullAsEmptyString("EMPLEADODNI")
                        .EMPLEADOLOCAL = dr.ReadNullAsEmptyString("EMPLEADOLOCAL")
                        .EMPLEADORAZONSOCIAL = dr.ReadNullAsEmptyString("EMPLEADORAZONSOCIAL")
                        .IDNUEVOLOCAL = dr.ReadNullAsNumeric("IDNUEVOLOCAL")
                        .NUEVOLOCAL = dr.ReadNullAsEmptyString("NUEVOLOCAL")
                        .NUEVORAZONSOCIAL = dr.ReadNullAsEmptyString("NUEVORAZONSOCIAL")
                        .FECHAINICIOCAMBIO = dr.ReadNullAsEmptyDate("FECHAINICIOCAMBIO")
                        .FECHAFINCAMBIO = dr.ReadNullAsEmptyDate("FECHAFINCAMBIO")
                        .IDCAMBIOTEMPORALMOTIVO = dr.ReadNullAsNumeric("IDCAMBIOTEMPORALMOTIVO")
                        .MOTIVO = dr.ReadNullAsEmptyString("MOTIVO")
                        .IDEMPLEADO = dr.ReadNullAsNumeric("IDEMPLEADO")
                    End With
                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return CambioLocalTemporalBE

    End Function 'OK
    Public Function AprobarCambioTemporal(ByVal IDCAMBIOTEMPORAL As Integer, ByVal IDUSUARIO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_EMPLEADOCAMBIOTEMPORAL_REV]"
            .CommandTimeout = 0
            With .Parameters
                .Add("@IDEMPLEADOCAMBIOTEMPORAL", SqlDbType.Int).Value = IDCAMBIOTEMPORAL
                .Add("@IDUSUARIO", SqlDbType.Int).Value = IDUSUARIO
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function 'OK
    Public Function AnularCambioTemporal(ByVal IDCAMBIOTEMPORAL As Integer, ByVal IDUSUARIO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_EMPLEADOCAMBIOTEMPORAL_ANULAR_RRHH]"
            .CommandTimeout = 0
            With .Parameters
                .Add("@IDEMPLEADOCAMBIOTEMPORAL", SqlDbType.Int).Value = IDCAMBIOTEMPORAL
                .Add("@IDUSUARIO", SqlDbType.Int).Value = IDUSUARIO
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function 'OK
    Public Function CambioTemporalLocalHistorialListAll(ByVal FECHAINICIO As Date, ByVal FECHAFINAL As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_CAMBIOTEMPORAL_LIST_PREVIEW_ALL_HISTORIAL]"
            With .Parameters
                .Add("@FECHAINICIO", SqlDbType.Date).Value = FECHAINICIO
                .Add("@FECHAFINAL", SqlDbType.Date).Value = FECHAFINAL
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

    End Function 'OK
End Class
