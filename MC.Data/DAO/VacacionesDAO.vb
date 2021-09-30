Imports System.Data.SqlClient
Public Class VacacionesDAO
    Public IdVacaciones As Integer
    Public IdEmpleado As Integer
    Dim VacacionesBE As New VacacionesBE

#Region "VACACIONES"
    Public Function GetByAllVacaciones() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_VACACIONES_LIST_PREVIEW_ALL"
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
    Public Function VacacionesHistorialListAll(ByVal FECHAINICIO As Date, ByVal FECHAFINAL As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_VACACIONES_LIST_PREVIEW_HISTORIAL_ALL]"
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
    Public Function GetVacacionesByID(ByVal IDVACACIONES As Int32) As VacacionesBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_VACACIONES_GET_BY_ID]"
            With .Parameters
                .Add("@IDVACACIONES", SqlDbType.Int).Value = IDVACACIONES
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read()
                    With VacacionesBE
                        .IDVACACIONES = dr.ReadNullAsNumeric("IDVACACIONES")
                        .NUMEROFORMATOVACACIONES = dr.ReadNullAsEmptyString("NUMEROFORMATOVACACIONES")
                        .IDLOCAL = dr.ReadNullAsNumeric("IDLOCAL")
                        .RAZONCOMERCIAL = dr.ReadNullAsEmptyString("RAZONCOMERCIAL")

                        .IDEMPLEADO = dr.ReadNullAsNumeric("IDEMPLEADO")
                        .NOMBREEMPLEADO = dr.ReadNullAsEmptyString("NOMBREEMPLEADO")
                        .IDSOLICITANTE = dr.ReadNullAsNumeric("IDSOLICITANTE")
                        .NOMBRESOLICITANTE = dr.ReadNullAsEmptyString("NOMBRESOLICITANTE")
                        .DNIEMPLEADO = dr.ReadNullAsEmptyString("NUMERODOCUMENTO")
                        .CARGOEMPLEADO = dr.ReadNullAsEmptyString("CARGOEMPLEADO")
                        .FECHADESDE = dr.ReadNullAsEmptyDate("FECHAINICIO")
                        .FECHAHASTA = dr.ReadNullAsEmptyDate("FECHAFIN")
                        .TOTALDIAS = dr.ReadNullAsNumeric("TOTALDIAS")
                        .FECHAINCORPORACION = dr.ReadNullAsEmptyDate("FECHAINCORPORACION")
                        .FECHAINGRESOCOMPANIA = dr.ReadNullAsEmptyString("FECHAINGRESO")
                        .FECHAINGRESOCORPORATIVO = dr.ReadNullAsEmptyString("FECHAINGRESOCORPORACION")
                        .FECHAFINCONTRATO = dr.ReadNullAsEmptyString("FECHAFINALCONTRATO")
                    End With
                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw ex

        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return VacacionesBE
    End Function 'OK

    Public Function AnularVacaciones(BE As VacacionesBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_VACACIONES_ANULAR_RRHH]"
            With .Parameters
                .Add("@IDVACACIONES", SqlDbType.Int).Value = BE.IDVACACIONES
                .Add("@IDUSUARIO", SqlDbType.Int).Value = BE.IDUSUARIO
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
    Public Function AprobarVacaciones(BE As VacacionesBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_VACACIONES_APROBAR]"
            With .Parameters
                .Add("@IDVACACIONES", SqlDbType.Int).Value = BE.IDVACACIONES
                .Add("@FECHAINICIO", SqlDbType.Date).Value = BE.FECHADESDE
                .Add("@FECHAFIN", SqlDbType.Date).Value = BE.FECHAHASTA
                .Add("@IDUSUARIO", SqlDbType.Int).Value = BE.IDUSUARIO
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
    Public Function ValidarVacacionesProceso(ByVal IdSolicitud As Integer, ByVal IdEmpleado As Integer, ByVal fechaInicio As Date, ByVal fechaFin As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_VALIDADO_VACACIONES_PORSOLICITUD"
            With .Parameters
                .Add("@IDSOLICITUD", SqlDbType.Int).Value = IdSolicitud
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IdEmpleado
                .Add("@FECHAINICIO", SqlDbType.Date).Value = fechaInicio
                .Add("@FECHAFIN", SqlDbType.Date).Value = fechaFin
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
#End Region
End Class
