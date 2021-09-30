Imports System.Data.SqlClient
Public Class CeseDAO
    Dim CeseBE As New CeseBE
    Dim EmpleadoCeseBE As New EmpleadoCeseBE
    Public IdSolicitudCese As Integer
    Property IdEmpleado As Integer
    Property IdSitio As Integer
    Property Renovacion As Int32
    Property EstadoValidoNoLegal As Boolean
#Region "EMPLEADO CESE"

    Public Function GetEmpleadoCeseList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_LIST_PREVIEW_PROCEDE_DESPIDO_ALL"
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
    Public Function SolicitudesCesesIdEmpleado(ByVal idempleado As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CESE_LISTA_IDEMPLEADO"
            With .Parameters
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = idempleado
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


    Public Function ValidarSolicitudesCesesPendientes(ByVal idempleado As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_VALIDAR_CESES_PENDIENTES_INS"
            With .Parameters
                .Clear()
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = idempleado
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

    Public Function ValidarSolicitudesCesesPorProcesar(ByVal idempleado As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_VALIDAR_CESE_PORPROCESAR_INS"
            With .Parameters
                .Clear()
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = idempleado
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
    Public Function GetEmpleadoCeseListHistorial(ByVal FechaInicial As Date, ByVal FechaFinal As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_LIST_PREVIEW_ALL_HISTORIAL"
            With .Parameters
                .Clear()
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
    Public Function GetEmpleadoAsignadoEnRenovacion(ByVal IdEmpleado As Integer, ByVal IdSolicitudCese As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_RENOVACIONCONTRATO_PENDIENTE_GETIDEMPLEADO"
            With .Parameters
                .Clear()
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IdEmpleado
                .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = IdSolicitudCese
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

    Public Function RegistrarCeseAdryan(BE As EmpleadoCeseBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionADRYAN)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_INSERTA_CESE_EMPLEADO"
            With .Parameters
                .Add("@CODIGOUNICO", SqlDbType.NVarChar, 9).Value = BE.CODIGOUNICO
                .Add("@FECHACESE", SqlDbType.Date).Value = BE.FECHACESE
                .Add("@CODIGOCESE", SqlDbType.NVarChar, 3).Value = BE.CODIGOCESE
                .Add("@OBSERVACION", SqlDbType.NVarChar, 80).Value = BE.OBSERVACION
                .Add("@PAGODIASBOLETA", SqlDbType.Bit).Value = BE.PAGODIASBOLETA
                .Add("@USUARIOREGISTRO", SqlDbType.NVarChar, 10).Value = BE.USUARIOREGISTRO
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
    End Function



    Public Function RegistrarCesePersonal(BE As CeseBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_UPDATE_RRHH"
            With .Parameters
                .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = BE.IDSOLICITUDCESE
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = BE.IDEMPLEADO
                .Add("@CODIGOCESE", SqlDbType.NVarChar, 3).Value = BE.CODIGOCESE
                .Add("@FECHACESE", SqlDbType.Date).Value = BE.FECHACESE
                .Add("@PAGODIASBOLETA", SqlDbType.Bit).Value = BE.PAGODIASBOLETA
                .Add("@OBSERVACION", SqlDbType.NVarChar, 80).Value = BE.OBSERVACION
                .Add("@IDUSUARIOREGISTRO", SqlDbType.Int).Value = BE.IDUSUARIOREGISTRO
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
    End Function

    Public Function GetEmpleadoCeseID(ByVal IDSOLICITUDCESE As Integer) As CeseBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_GET_BY_ID"
            With .Parameters
                .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = IDSOLICITUDCESE
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With CeseBE
                        .IDSOLICITUDCESE = dr.ReadNullAsNumeric("IDSOLICITUDCESE")
                        .IDEMPLEADO = dr.ReadNullAsNumeric("IDEMPLEADO")
                        .CODIGOUNICO = dr.ReadNullAsEmptyString("CODIGOUNICO")
                        .EMPLEADONOMBRE = dr.ReadNullAsEmptyString("EMPLEADONOMBRE")
                        .FECHACESE = dr.ReadNullAsEmptyDate("FECHAFINALCONTRATO")
                        .FECHARECOJODOCUMENTO = dr.ReadNullAsEmptyDate("FECHARECOJODOCUMENTO")
                        .SOLICITANTENOMBRE = dr.ReadNullAsEmptyString("SOLICITANTENOMBRE")
                        .NUMEROSOLICITUD = dr.ReadNullAsEmptyString("NUMEROSOLICITUDCESE")
                        .MOTIVO = dr.ReadNullAsEmptyString("MOTIVOGENERAL")
                        .RAZONCOMERCIAL = dr.ReadNullAsEmptyString("RAZONCOMERCIAL")
                        .CARGO = dr.ReadNullAsEmptyString("EMPLEADOCARGO")
                        .AMPLIACION = dr.ReadNullAsEmptyString("MESAMPLIACION")
                        .FECHAENVIOCARTAPREAVISONOTARIA = dr.ReadNullAsEmptyDate("FECHAENVIOCARTAPREAVISONOTARIA")
                        .FECHAENVIOCARTADESPIDONOTARIA = dr.ReadNullAsEmptyDate("FECHAENVIOCARTADESPIDONOTARIA")
                        .DESCRIPCIONRETORNO = dr.ReadNullAsEmptyString("DESRIPCIONRETORNO")
                        .ESTADOVALIDADOLEGALPREAVISO = dr.ReadNullAsBoolean("ESTADOVALIDADOLEGALPREAVISO")
                        .ESTADOENVIOLEGALDESPIDO = dr.ReadNullAsBoolean("ESTADOENVIOLEGALDESPIDO")
                        '.ESTADOSITUACIONPERFECTA = dr.ReadNullAsBoolean("ESTADOSUSPENSIONPERFECTA")
                        '.NUMEROSOLICITUD = dr.ReadNullAsEmptyString("NUMEROSOLICITUDCESE")
                        '.IDEMPLEADO = dr.ReadNullAsNumeric("IDEMPLEADO")
                        '.SOLICITANTE = dr.ReadNullAsEmptyString("SOLICITANTENOMBRE")
                        '.MOTIVO = dr.ReadNullAsEmptyString("MOTIVOGENERAL")
                        '.LOCAL = dr.ReadNullAsNumeric("RAZONCOMERCIAL")
                        '.EMPLEADO = dr.ReadNullAsEmptyString("EMPLEADONOMBRE")
                        '.CARGOEMPLEADO = dr.ReadNullAsEmptyString("CARGOEMPLEADO")
                        '.PERMANENCIA = dr.ReadNullAsEmptyString("PERMANENCIA")
                        '.AMPLIACION = dr.ReadNullAsEmptyString("AMPLIACION")
                        '.FECHACESE = dr.ReadNullAsEmptyDate("FECHAFINALCONTRATO")

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
        Return CeseBE
    End Function

    '-----------------
    Public Function GetSolicitudCeseListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_LIST_PREVIEW_ALL"
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
    Public Function GetSolicitudCeseLegalListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESELEGAL_LIST_PREVIEW_ALL"
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
    Public Function GetSolicitudCeseNoLegalListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESENOLEGAL_LIST_PREVIEW_ALL"
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
    Public Function EnvioSolicitudCeseLegal(ByVal IDSOLICITUDCESE As Int32) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_ENVIO_LEGAL"
            With .Parameters
                .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = IDSOLICITUDCESE
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
    Public Function GetSolicitudCeseEvaluadosList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_LIST_PREVIEW_EVALUADOS"
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
    Public Function ListSolicitudCeseCartaPreAvisoFormatoID(ByVal IDSOLICITUDCESE As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_CARTA_PREAVISO_LISTA_ARCHIVO"
            With .Parameters
                .Clear()
                .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = IDSOLICITUDCESE
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
    Public Function InsertaSolicitudCeseCartaPreAviso(ByVal id As Integer, ByVal nombrearchivo As String, ByVal ruta As String, ByVal link As String) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_CARTA_PREAVISO_INSERTA_ARCHIVO"
            With .Parameters
                .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = id
                .Add("@NOMBRE", SqlDbType.NVarChar).Value = nombrearchivo
                .Add("@RUTA", SqlDbType.NVarChar).Value = ruta
                .Add("@LINK", SqlDbType.NVarChar).Value = link
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return Result

    End Function
    Public Function EliminarSolicitudCeseCartaPreAvisoArchivo(ByVal IDSOLICITUDCESE As Int32, ByVal NOMBREARCHIVO As String) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_ELIMINAR_CARTA_PREAVISO_ARCHIVO"
            With .Parameters
                .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = IDSOLICITUDCESE
                .Add("@NOMBREARCHIVO", SqlDbType.NVarChar).Value = NOMBREARCHIVO
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
    Public Function ListSolicitudCeseCartaPreAvisoID(ByVal IDSOLICITUDCESE As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_LIST_CARTAPREAVISO_ARCHIVO_GET_ID"
            With .Parameters
                .Clear()
                .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = IDSOLICITUDCESE
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
    Public Function ValidarSolicitudCeseCartaPreAvisoLegal(ByVal IDSOLICITUDCESE As Int32) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_VALIDADO_PREAVISO_LEGAL"
            With .Parameters
                .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = IDSOLICITUDCESE
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
    Public Function ListSolicitudCeseDescargoArchivo(ByVal IDSOLICITUDCESE As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_LISTA_DESCARGO_ARCHIVO"
            With .Parameters
                .Clear()
                .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = IDSOLICITUDCESE
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

    Public Function ListSolicitudCeseArchivo(ByVal IDSOLICITUDCESE As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_LISTA_CESE_ARCHIVO"
            With .Parameters
                .Clear()
                .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = IDSOLICITUDCESE
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
    Public Function ValidarSolicitudCeseRrhh(ByVal IDSOLICITUDCESE As Int32, ByVal FECHAENVIONOTARIAPREAVISO As Date) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESCE_VALIDAR_RRHH"
            With .Parameters
                .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = IDSOLICITUDCESE
                .Add("@FECHAENVIOCARTAPREAVISONOTARIA", SqlDbType.Date).Value = FECHAENVIONOTARIAPREAVISO
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
    Public Function InsertaSolicitudCeseCartaDespido(ByVal id As Integer, ByVal nombrearchivo As String, ByVal ruta As String, ByVal link As String) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_CARTA_DESPIDO_INSERTA_ARCHIVO"
            With .Parameters
                .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = id
                .Add("@NOMBRE", SqlDbType.NVarChar).Value = nombrearchivo
                .Add("@RUTA", SqlDbType.NVarChar).Value = ruta
                .Add("@LINK", SqlDbType.NVarChar).Value = link
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return Result

    End Function
    Public Function ListSolicitudCeseCartaDespidoFormatoID(ByVal IDSOLICITUDCESE As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_CARTA_DESPIDO_LISTA_ARCHIVO"
            With .Parameters
                .Clear()
                .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = IDSOLICITUDCESE
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
    Public Function EliminarSolicitudCeseCartaDespidoArchivo(ByVal IDSOLICITUDCESE As Int32, ByVal NOMBREARCHIVO As String) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_ELIMINAR_CARTA_DESPIDO_ARCHIVO"
            With .Parameters
                .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = IDSOLICITUDCESE
                .Add("@NOMBREARCHIVO", SqlDbType.NVarChar).Value = NOMBREARCHIVO
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
    Public Function EnvioSolicitudCeseCartaDespidoRrhh(ByVal IDSOLICITUDCESE As Int32) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_ENVIO_CARTA_DESPIDO_RRHH"
            With .Parameters
                .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = IDSOLICITUDCESE
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
    'Public Function EnvioSolicitudCeseRegistroBaja(ByVal IDSOLICITUDCESE As Int32) As Boolean
    '    Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
    '    Dim cmd As New SqlCommand
    '    Dim Result As Boolean = False
    '    With cmd
    '        .Connection = cnx
    '        .CommandType = CommandType.StoredProcedure
    '        .CommandText = "MCRH_SOLICITUDCESE_ENVIO_REGISTRO_BAJA"
    '        With .Parameters
    '            .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = IDSOLICITUDCESE
    '        End With
    '    End With

    '    Try
    '        cnx.Open()
    '        cmd.ExecuteNonQuery()
    '        Result = True
    '    Catch ex As Exception
    '        Throw
    '    Finally
    '        If cnx.State = ConnectionState.Open Then
    '            cnx.Close()
    '        End If
    '    End Try
    '    Return Result
    'End Function
    'Public Function EnvioSolicitudCeseRegistroAdryan(ByVal IDSOLICITUDCESE As Int32) As Boolean
    '    Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
    '    Dim cmd As New SqlCommand
    '    Dim Result As Boolean = False
    '    With cmd
    '        .Connection = cnx
    '        .CommandType = CommandType.StoredProcedure
    '        .CommandText = "MCRH_SOLICITUDCESE_REGISTRO_ADRYAN"
    '        With .Parameters
    '            .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = IDSOLICITUDCESE
    '        End With
    '    End With
    '    Try
    '        cnx.Open()
    '        cmd.ExecuteNonQuery()
    '        Result = True
    '    Catch ex As Exception
    '        Throw
    '    Finally
    '        If cnx.State = ConnectionState.Open Then
    '            cnx.Close()
    '        End If
    '    End Try
    '    Return Result
    'End Function
    Public Function EnvioSolicitudCeseRegistroGuardar(ByVal IDSOLICITUDCESE As Int32, ByVal FECHAPREAVISONOTARIA As Date, ByVal FECHADESPIDONOTARIA As Date) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_GUARDAR"
            With .Parameters
                .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = IDSOLICITUDCESE
                .Add("@FECHAENVIOCARTAPREAVISONOTARIA", SqlDbType.Date).Value = FECHAPREAVISONOTARIA
                .Add("@FECHAENVIOCARTADESPIDONOTARIA", SqlDbType.Date).Value = FECHADESPIDONOTARIA
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
    Public Function ValidarSolicitudCese(ByVal IDSOLICITUDCESE As Int32, ByVal PROCESOEVALUACIONLEGAL As Int32) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_VALIDAR_SOLICITUD"
            With .Parameters
                'PROCESOEVALUACIONLEGAL = 1 NO PROCEDE DE MANERA LEGAL
                'PROCESOEVALUACIONLEGAL = 2 PROCEDE DE MANERA LEGAL
                .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = IDSOLICITUDCESE
                .Add("@PROCESOEVALUACIONLEGAL", SqlDbType.Int).Value = PROCESOEVALUACIONLEGAL
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
    Public Function ValidarSolicitudCeseNoLegal(ByVal IDSOLICITUDCESE As Int32, ByVal FECHARECOJODOCUMENTO As Date) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_VALIDAR_NOLEGAL_SOLICITUD"
            With .Parameters
                .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = IDSOLICITUDCESE
                .Add("@FECHARECOJODOCUMENTO", SqlDbType.Date).Value = FECHARECOJODOCUMENTO
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
    Public Function EnvioSolicitudCeseDespido(ByVal IDSOLICITUDCESE As Int32) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_ENVIO_DESPIDO"
            With .Parameters
                .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = IDSOLICITUDCESE
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
    Public Function AprobarSolicitudCeseRrhh(ByVal IDSOLICITUDCESE As Int32, ByVal FECHAENVIONOTARIADESPIDO As Date) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESCE_APROBAR_RRHH"
            With .Parameters
                .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = IDSOLICITUDCESE
                .Add("@FECHAENVIOCARTADESPIDONOTARIA", SqlDbType.Date).Value = FECHAENVIONOTARIADESPIDO
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
    Public Function GetCeseIDCorreo(ByVal IDSOLICITUDCESE As Int32) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CESE_ID_CORREO"
            With .Parameters
                .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = IDSOLICITUDCESE
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
    Public Function GetCeseAnularRrhh(ByVal IDSOLICITUDCESE As Int32, ByVal IDUSUARIOANULADO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_ANULAR_ID"
            With .Parameters
                .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = IDSOLICITUDCESE
                .Add("@IDUSUARIOANULADO", SqlDbType.Int).Value = IDUSUARIOANULADO
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
    Public Function GetRetornarSolicitudCeseRrhh(ByVal IDSOLICITUDCESE As Integer, ByVal DESCRIPCIONRETORNO As String) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_RETORNAR_ADMINISTRACION"
            With .Parameters
                .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = IDSOLICITUDCESE
                .Add("@DESCRIPCIONRETORNO", SqlDbType.NVarChar).Value = DESCRIPCIONRETORNO
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

    Public Function RetornarSolicitudCese(ByVal IDSOLICITUDCESE As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_RETORNAR_SOLICITUD"
            With .Parameters
                .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = IDSOLICITUDCESE
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
    Public Function GetCeseRetornarRrhh(ByVal IDSOLICITUDCESE As Integer, ByVal MENSAJERETORNO As String) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_RETORNO_LEGALARRHH_ID"
            With .Parameters
                .Add("@IDSOLICITUDCESE", SqlDbType.Int).Value = IDSOLICITUDCESE
                .Add("@MENSAJERETOTNOLEGALARRHH", SqlDbType.NVarChar).Value = MENSAJERETORNO
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

#End Region

End Class
