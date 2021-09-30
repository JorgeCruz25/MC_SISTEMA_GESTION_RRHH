Imports System.Data.SqlClient

Public Class InformeGeneralDAO
    Dim InformeGeneralBE As New InformeGeneralBE
    Public IdInformeGeneral As Integer
    Public Function InformeGeneralListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_INFORME_GENERAL_LIST_PREVIEW_ALL]"
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

    Public Function InformeGeneralArchivoList(ByVal IDINFORMEGENERAL As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_INFORME_GENERAL_LISTA_ARCHIVO]"
            With .Parameters
                .Add("@IDINFORMEGENERAL", SqlDbType.Int).Value = IDINFORMEGENERAL
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
    Public Function GetInformeGeneralByID(ByVal IDINFORMEGENERAL As Int32) As InformeGeneralBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_INFORME_GENERAL_GET_BY_ID]"
            With .Parameters
                .Add("@IDINFORMEGENERAL", SqlDbType.Int).Value = IDINFORMEGENERAL
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read()
                    With InformeGeneralBE
                        .IDINFORMEGENERAL = dr.ReadNullAsNumeric("IDINFORMEGENERAL")
                        .NUMEROINFORME = dr.ReadNullAsEmptyString("NUMEROINFORME")
                        .FECHASOLICITUD = dr.ReadNullAsEmptyString("FECHA")
                        .RAZONSOCIAL = dr.ReadNullAsEmptyString("RAZONSOCIAL")
                        .RAZONCOMERCIAL = dr.ReadNullAsEmptyString("RAZONCOMERCIAL")
                        .NOMBRESOLICITANTE = dr.ReadNullAsEmptyString("INFORMESOLICITANTE")
                        .NOMBREEMPLEADO = dr.ReadNullAsEmptyString("INFORMEEMPLEADO")
                        .DNIEMPLEADO = dr.ReadNullAsEmptyString("INFORMEEMPLEADODNI")
                        .CARGOEMPLEADO = dr.ReadNullAsEmptyString("INFORMEEMPLEADOCARGO")
                        .AREA = dr.ReadNullAsEmptyString("AREA")
                        .ASUNTO = dr.ReadNullAsEmptyString("ASUNTO")
                        .DESCRIPCIÓN = dr.ReadNullAsEmptyString("DESCRIPCION")
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
        Return InformeGeneralBE
    End Function 'OK

    Public Function AprobarInformeGeneral(BE As InformeGeneralBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_INFORME_GENERAL_REV]"
            With .Parameters
                .Add("@IDINFORMEGENERAL", SqlDbType.Int).Value = BE.IDINFORMEGENERAL
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
    End Function 'OK
    Public Function AnularInformeGeneral(BE As InformeGeneralBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_INFORME_GENERAL_ANULAR_RRHH]"
            With .Parameters
                .Add("@IDINFORMEGENERAL", SqlDbType.Int).Value = BE.IDINFORMEGENERAL
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
    End Function 'OK
    Public Function InformeGeneralHistorialListAll(ByVal FECHAINICIO As Date, ByVal FECHAFINAL As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_INFORMEGENERAL_LIST_PREVIEW_ALL_HISTORIAL]"
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
