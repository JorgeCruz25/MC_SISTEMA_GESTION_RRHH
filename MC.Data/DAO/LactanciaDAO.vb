Imports System.Data.SqlClient
Public Class LactanciaDAO
    Dim LactanciaBE As New LactanciaBE
    Public IdLactancia As Integer
    Public Function LactanciaListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_LACTANCIA_LIST_PREVIEW_ALL]"
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
    Public Function GetLactanciaByID(ByVal IDLACTANCIA As Int32) As LactanciaBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_LACTANCIA_GET_BY_ID]"
            With .Parameters
                .Add("@IDLACTANCIA", SqlDbType.Int).Value = IDLACTANCIA
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With LactanciaBE
                        .IDLACTANCIA = dr.ReadNullAsNumeric("IDLACTANCIA")
                        .NUMEROSOLICITUD = dr.ReadNullAsEmptyString("NUMEROSOLICITUD")
                        .NOMBREEMPLEADO = dr.ReadNullAsEmptyString("NUMEROSOLICITUD")
                        .NOMBRESOLICITANTE = dr.ReadNullAsEmptyString("SOLICITANTENOMBRE")
                        .RAZONSOCIAL = dr.ReadNullAsNumeric("RAZONSOCIAL")
                        .RAZONCOMERCIAL = dr.ReadNullAsEmptyString("RAZONCOMERCIAL")
                        .NOMBREEMPLEADO = dr.ReadNullAsEmptyString("EMPLEADONOMBRE")
                        .CARGOEMPLEADO = dr.ReadNullAsEmptyString("EMPLEADOCARGO")
                        .NUMERODOCUMENTO = dr.ReadNullAsEmptyString("NUMERODOCUMENTO")
                        .FECHAINGRESO = dr.ReadNullAsEmptyDate("FECHAINGRESO")
                        .FECHANACIMIENTO = dr.ReadNullAsEmptyDate("FECHANACIMIENTOHIJO")
                        .TURNO = dr.ReadNullAsEmptyString("TURNO")
                        .FECHABENEFICIOINICIO = dr.ReadNullAsEmptyDate("FECHAINICIO")
                        .FECHABENEFICIOFINAL = dr.ReadNullAsEmptyDate("FECHAFIN")
                        .IDEMPLEADO = dr.ReadNullAsNumeric("IDSOLICITANTE")
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
        Return LactanciaBE
    End Function
    Public Function LactanciaArchivoList(ByVal IDLACTANCIA As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd

            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_LACTANCIA_LISTA_ARCHIVO]"
            With .Parameters
                .Add("@IDLACTANCIA", SqlDbType.Int).Value = IDLACTANCIA
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
    Public Function AprobarLactancia(BE As LactanciaBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_LACTANCIA_REV]"
            With .Parameters
                .Add("@IDLACTANCIA", SqlDbType.Int).Value = BE.IDLACTANCIA
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
    Public Function LactanciaListAllHistorial(ByVal FECHAINICIAL As Date, ByVal FECHAFINAL As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_LACTANCIA_LIST_HISTORIAL]"
            With .Parameters
                .Add("@FECHAINICIAL", SqlDbType.Date).Value = FECHAINICIAL
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

    Public Function AnularLactancia(BE As LactanciaBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_LACTANCIA_ANULAR_RRHH]"
            With .Parameters
                .Add("@IDLACTANCIA", SqlDbType.Int).Value = BE.IDLACTANCIA
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

End Class
