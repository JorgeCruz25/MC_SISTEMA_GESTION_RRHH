Imports System.Data.SqlClient

Public Class NegacionTrasladoDAO
    Dim NegacionTrasladoBE As New NegacionTrasladoBE
    Public IdNegacionTraslado As Integer
    Public Function NegacionTrasladoListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_NEGACIONTRASLADO_LIST_PREVIEW_ALL]"
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
    Public Function NegacionTrasladoArchivoList(ByVal IDNEGACIONTRASLADO As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_NEGACIONTRASLADO_LISTA_ARCHIVO]"
            With .Parameters
                .Add("@IDNEGACIONTRASLADO", SqlDbType.Int).Value = IDNEGACIONTRASLADO
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
    Public Function GetNegacionTrasladoByID(ByVal IDNEGACIONTRASLADO As Int32) As NegacionTrasladoBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_NEGACIONTRASLADO_GET_BY_ID]"
            With .Parameters
                .Add("@IDNEGACIONTRASLADO", SqlDbType.Int).Value = IDNEGACIONTRASLADO
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read()
                    With NegacionTrasladoBE
                        .IDNEGACIONTRASLADO = dr.ReadNullAsNumeric("IDNEGACIONTRASLADO")
                        .NUMERONEGACIONTRASLADO = dr.ReadNullAsEmptyString("NUMERONEGACIONTRASLADO")
                        .NOMBRESOLICITANTE = dr.ReadNullAsEmptyString("NOMBRESOLICITANTE")
                        .NOMBREREPRESENTANTE = dr.ReadNullAsEmptyString("NOMBREREPRESENTANTE")
                        .DNIREPRESENTANTE = dr.ReadNullAsEmptyString("DNIREPRESENTANTE")
                        .NACIONALIDADREPRESENTANTE = dr.ReadNullAsEmptyString("NACIONALIDADREPRESENTANTE")
                        .RAZONSOCIAL = dr.ReadNullAsEmptyString("RAZONSOCIAL")
                        .RAZONCOMERCIAL = dr.ReadNullAsEmptyString("RAZONCOMERCIAL")
                        .FECHASOLICITUD = dr.ReadNullAsEmptyString("FECHA")
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
        Return NegacionTrasladoBE
    End Function 'OK
    Public Function AprobarNegacionTraslado(BE As NegacionTrasladoBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_NEGACIONTRASLADO_REV]"
            With .Parameters
                .Add("@IDNEGACIONTRASLADO", SqlDbType.Int).Value = BE.IDNEGACIONTRASLADO
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
    Public Function AnularNegacionTraslado(BE As NegacionTrasladoBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_NEGACIONTRASLADO_ANULAR_RRHH]"
            With .Parameters
                .Add("@IDNEGACIONTRASLADO", SqlDbType.Int).Value = BE.IDNEGACIONTRASLADO
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
    Public Function NegacionTrasladoHistorialListAll(ByVal FECHAINICIO As Date, ByVal FECHAFINAL As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_NEGACIONTRASLADO_LIST_PREVIEW_ALL_HISTORIAL]"
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
