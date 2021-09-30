Imports System.Data.SqlClient
Public Class IncidenteAccidenteDAO
    Dim IncidenteAccidenteBE As New IncidenteAccidenteBE
    Public IdIncidenteAccidente As Integer
    Public Empleado As String
    Public Function IncidenteAccidenteListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_INCIDENTEACCIDENTE_LIST_PREVIEW_ALL]"
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
    Public Function IncidenteAccidenteArchivoList(ByVal IDINCIDENTEACCIDENTE As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_INCIDENTEACCIDENTE_LISTA_ARCHIVO]"
            With .Parameters
                .Add("@IDINCIDENTEACCIDENTE", SqlDbType.Int).Value = IDINCIDENTEACCIDENTE
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

    Public Function IncidenteAccidenteHistorialListAll(ByVal FECHAINICIAL As Date, ByVal FECHAFINAL As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_INCIDENTEACCIDENTE_LIST_PREVIEW_ALL_HISTORIAL]"
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

    Public Function GetIncidenteAccidenteByID(ByVal IDINCIDENTEACCIDENTE As Int32) As IncidenteAccidenteBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_INCIDENTEACCIDENTE_GET_BY_ID]"
            With .Parameters
                .Add("@IDINCIDENTEACCIDENTE", SqlDbType.Int).Value = IDINCIDENTEACCIDENTE
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With IncidenteAccidenteBE
                        .IDINCIDENTEACCIDENTE = dr.ReadNullAsNumeric("IDINCIDENTEACCIDENTE")
                        .TIPOINCIDENTEACCIDENTE = dr.ReadNullAsEmptyString("TIPOINCIDENTEACCIDENTE")
                        .TIPOINCIDENTEACCIDENTE = dr.ReadNullAsEmptyString("TIPOINCIDENTEACCIDENTE")
                        .FECHA = dr.ReadNullAsEmptyDate("FECHA")
                        .RAZONSOCIAL = dr.ReadNullAsEmptyString("RAZONSOCIAL")
                        .RAZONCOMERCIAL = dr.ReadNullAsEmptyString("RAZONCOMERCIAL")
                        .NOMBRESOLICITANTE = dr.ReadNullAsEmptyString("NOMBRESOLICITANTE")
                        .CLIENTENOMBRE = dr.ReadNullAsEmptyString("CLIENTENOMBRE")
                        .CLIENTEDNI = dr.ReadNullAsEmptyString("CLIENTEDNI")
                        .FECHAINCIDENTEACCIDENTE = dr.ReadNullAsEmptyDate("FECHAINCIDENTEACCIDENTE")
                        .AREAOCURRENCIA = dr.ReadNullAsEmptyString("AREAOCURRENCIA")
                        .EMPLEADONOMBRE = dr.ReadNullAsEmptyString("EMPLEADONOMBRE1")
                        .EMPLEADODNI = dr.ReadNullAsEmptyString("EMPLEADODNI")
                        .IDEMPLEADO = dr.ReadNullAsNumeric("IDEMPLEADO")
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
        Return IncidenteAccidenteBE

    End Function

    Public Function AprobarIncidenteAccidente(BE As IncidenteAccidenteBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_INCIDENTEACCIDENTE_REV]"
            With .Parameters
                .Add("@IDINCIDENTEACCIDENTE", SqlDbType.Int).Value = BE.IDINCIDENTEACCIDENTE
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
    Public Function AnularIncidenteAccidente(BE As IncidenteAccidenteBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_INCIDENTEACCIDENTE_ANULAR_RRHH]"
            With .Parameters
                .Add("@IDINCIDENTEACCIDENTE", SqlDbType.Int).Value = BE.IDINCIDENTEACCIDENTE
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
