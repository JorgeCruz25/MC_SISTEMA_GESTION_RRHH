Imports System.Data.SqlClient

Public Class CartaConocimientoDAO
    Dim CartaConocimientoBE As New CartaConocimientoBE
    Public IdExamenMedico As Integer
    Public Function CartaConocimientoListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_EXAMENMEDICO_LIST_PREVIEW_ALL]"
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
    Public Function CartaConocimientoArchivoList(ByVal IDEXAMENMEDICO As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_EXAMEN_MEDICO_LISTA_ARCHIVO]"
            With .Parameters
                .Add("@IDEXAMENMEDICO", SqlDbType.Int).Value = IDEXAMENMEDICO
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
    Public Function GetCartaConocimientoByID(ByVal IDEXAMENMEDICO As Int32) As CartaConocimientoBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_EXAMENMEDICO_GET_BY_ID]"
            With .Parameters
                .Add("@IDEXAMENMEDICO", SqlDbType.Int).Value = IDEXAMENMEDICO
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read()
                    With CartaConocimientoBE
                        .IDEXAMENMEDICO = dr.ReadNullAsNumeric("IDEXAMENMEDICO")
                        .NUMEROEXAMENMEDICO = dr.ReadNullAsEmptyString("NUMEROEXAMENMEDICO")
                        .RAZONSOCIAL = dr.ReadNullAsEmptyString("RAZONSOCIAL")
                        .RAZONCOMERCIAL = dr.ReadNullAsEmptyString("RAZONCOMERCIAL")
                        .NOMBRESOLICITANTE = dr.ReadNullAsEmptyString("NOMBRESOLICITANTE")
                        .FECHASOLICITUD = dr.ReadNullAsEmptyString("FECHA")
                        .EMPLEADONOMBRE = dr.ReadNullAsEmptyString("EMPLEADONOMBRE")
                        .EMPLEADODNI = dr.ReadNullAsEmptyString("NUMERODOCUMENTO")
                        .EMPLEADOCARGO = dr.ReadNullAsEmptyString("EMPLEADOCARGO")
                        .INSTALACION = dr.ReadNullAsEmptyString("INSTALACION")
                        .FECHAINICIO = dr.ReadNullAsEmptyDate("FECHAINICIO")
                        .FECHAFIN = dr.ReadNullAsEmptyDate("FECHAFIN")
                        .HORA = dr.ReadNullAsEmptyString("HORA")

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
        Return CartaConocimientoBE
    End Function 'OK
    Public Function CartaConocimientoHistorialListAll(ByVal FECHAINICIAL As Date, ByVal FECHAFINAL As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_CARTACONOCIMIENTO_LIST_PREVIEW_ALL_HISTORIAL]"
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
    Public Function AprobarCartaConocimiento(BE As CartaConocimientoBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_EXAMENMEDICO_REV]"
            With .Parameters
                .Add("@IDEXAMENMEDICO", SqlDbType.Int).Value = BE.IDEXAMENMEDICO
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
    Public Function AnularCartaConocimiento(BE As CartaConocimientoBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_EXAMENMEDICO_ANULAR_RRHH]"
            With .Parameters
                .Add("@IDEXAMENMEDICO", SqlDbType.Int).Value = BE.IDEXAMENMEDICO
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
