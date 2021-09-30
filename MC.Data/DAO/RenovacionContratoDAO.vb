Imports System.Data.SqlClient

Public Class RenovacionContratoDAO

    Dim RenovacionContratoBE As New RenovacionContratoBE

    Property IDRENOVACIONCONTRATO As Integer
    Property IDRENOVACIONCONTRATODETALLE As Integer
#Region "RENOVACIÓN CONTRATO"

    Public Function GetEmpleadoRenovacionList(ByVal FechaDesde As Date, ByVal FechaHasta As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RC_EMPLEADO_LISTADO_RENOVACION_ALL"
            With .Parameters
                .Clear()
                .Add("@FECHADESDE", SqlDbType.Date).Value = FechaDesde
                .Add("@FECHAHASTA", SqlDbType.Date).Value = FechaHasta
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
    Public Function ObtenerInformacionEnvioCorreo(ByVal IDORGANIGRAMA As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_ENVIO_CORREO_RENOVACION_CONTRATO"
            With .Parameters
                .Clear()
                .Add("@IDORGANIGRAMA", SqlDbType.Int).Value = IDORGANIGRAMA
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

    Public Function GetObtenerLocalRenovacionContratoList(ByVal IdLocalList As String) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_RENOVACION_CONTRATO_OBTENER_LOCALES"
            With .Parameters
                .Clear()
                .Add("@IDLOCALLIST", SqlDbType.NVarChar).Value = IdLocalList
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
    Public Function RegistrarSolicitudesRenovacion(ByVal IdOrganigrama As Integer, ByVal FechaPeriodoDesde As Date, ByVal FechaPeriodoHasta As Date, ByVal xIdUsuarioRegistro As Int32) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_RENOVACION_CONTRATO_SOLICITUD_INS"
            With .Parameters
                .Add("@IDRENOVACION", SqlDbType.Int).Direction = ParameterDirection.Output
                .Add("@IDORGANIGRAMA", SqlDbType.Int).Value = IdOrganigrama
                .Add("@FECHAPERIODODESDE", SqlDbType.Date).Value = FechaPeriodoDesde
                .Add("@FECHAPERIODOHASTA", SqlDbType.Date).Value = FechaPeriodoHasta
                .Add("@IDUSUARIO", SqlDbType.Int).Value = xIdUsuarioRegistro
                Try
                    cnx.Open()

                    If cmd.ExecuteNonQuery() > 0 Then
                        IDRENOVACIONCONTRATO = cmd.Parameters("@IDRENOVACION").Value
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
            End With
        End With
    End Function 'OK

    Public Function ValidarDesprocesarAsignacionRenovacionEmpleado(ByVal IDRENOVACIONCONTRATODETALLE As Integer) As Int32
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Int32
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "MCRH_VALIDADO_DESPROCESARASIGNACION_RENOVACION_EMPLEADO"
            With .Parameters
                .Add("@IDRENOVACIONCONTRATODETALLE", SqlDbType.Int).Value = IDRENOVACIONCONTRATODETALLE
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
            Result = dt.Rows(0)(0)
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function 'ok
    Public Function DesprocesarAsignacionRenovacionEmpleado(ByVal iDrENOVACIdRenovacionContratoDetalle As Integer, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_DESPROCESAR_ASIGNACION_RENOVACION_EMPLEADO"
            With .Parameters
                .Add("@IDRENOVACIONCONTRATODETALLE", SqlDbType.Int).Value = iDrENOVACIdRenovacionContratoDetalle
                .Add("@IDUSUARIO", SqlDbType.Int).Value = IdUsuario
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

    Public Function ObtenerCabeceraRenovacioContrato(ByVal IdLocal As Integer, ByVal FechaDesde As Date, ByVal FechaHasta As Date) As Integer
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Integer = 0
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "MCRH_RENOVACION_CONTRAR_OBTENER_CABECERA_ID"
            With .Parameters
                .Add("@IDLOCAL", SqlDbType.Int).Value = IdLocal
                .Add("@FECHADESDE", SqlDbType.Date).Value = FechaDesde
                .Add("@FECHAHASTA", SqlDbType.Date).Value = FechaHasta
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
            Result = dt.Rows(0)(0)
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function 'OK
    Public Function AsignarRenovacionContratoDetalle(ByVal xIdEmpleado As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_RENOVACION_CONTRATO_DETALLE_INS"
            With .Parameters
                .Add("@IDRENOVACIONCONTRATO", SqlDbType.Int).Value = IDRENOVACIONCONTRATO
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = xIdEmpleado
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
    Public Function UpdateRenovacionContratoEmpleado(ByVal IdEmpleado As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_RENOVACION_CONTRATO_UPDATE_EMPLEADO"
            With .Parameters
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IdEmpleado
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
    Public Function GetEmpleadoRenovacionxRenovarAsignadosList(ByVal FechaDesde As Date, ByVal FechaHasta As Date, ByVal TipoList As Int32) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RC_RENOVACION_CONTRATO_LIST"
            With .Parameters
                .Clear()
                .Add("@FECHADESDE", SqlDbType.Date).Value = FechaDesde
                .Add("@FECHAHASTA", SqlDbType.Date).Value = FechaHasta
                .Add("@TIPOLIST", SqlDbType.Int).Value = TipoList
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
    Public Function GetEmpleadoRenovacionxCesarList(ByVal FechaDesde As Date, ByVal FechaHasta As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RC_RENOVACION_CONTRATOXCESAR_LIST"
            With .Parameters
                .Clear()
                .Add("@FECHADESDE", SqlDbType.Date).Value = FechaDesde
                .Add("@FECHAHASTA", SqlDbType.Date).Value = FechaHasta
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
    Public Function GetObtenerUltimoContrato() As String
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim Result As String = ""

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_OBTENER_ULTIMO_NUMERO_CONTRATO"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
            Result = dt.Rows(0)("ULTIMONUMEROCONTRATO")
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function 'OK

    Public Function GetIdEstadoEmpleadoAdryan(ByVal codigounico As String) As String
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionADRYAN)
        Dim Valor As String = ""
        Try
            Dim reader As SqlDataReader
            Dim cmd = New SqlCommand
            With cmd
                cnx.Open()

                .Connection = cnx
                .CommandType = CommandType.Text
                .CommandText = "select situacion_trabajador from trabajador where codigo_unico = '" + codigounico + "'"
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
    Public Function GetIdEstadoEmpleadoCentral(ByVal IdEmpleado As String) As Int32
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim Valor As Int32 = 0
        Try
            Dim reader As SqlDataReader
            Dim cmd = New SqlCommand
            With cmd
                cnx.Open()

                .Connection = cnx
                .CommandType = CommandType.Text
                .CommandText = "select IDESTADO from MC_EMPLEADO where idempleado = '" + IdEmpleado + "'"
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

    Public Function InsertaEmpleadoContratoAdryan(ByVal CodigoUnico As String, ByVal NumeroContrato As String, ByVal FechaFinalContrato As Date, ByVal FechaFinalContratoNuevo As Date) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionADRYAN)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_INSERTA_EMPLEADO_CONTRATO"
            With .Parameters
                .Add("@CODIGOUNICO", SqlDbType.NVarChar, 9).Value = CodigoUnico
                .Add("@NUMEROCONTRATO", SqlDbType.NVarChar, 20).Value = NumeroContrato
                .Add("@FECHAFINALCONTRATO", SqlDbType.Date).Value = FechaFinalContrato
                .Add("@FECHAFINALCONTRATONUEVO", SqlDbType.Date).Value = FechaFinalContratoNuevo
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

    Public Function InsertaEmpleadoContratoCentral(ByVal IdEmpleado As String, ByVal IdRenovacionDetalle As Integer, ByVal NumeroContrato As String, ByVal FechaFinalContrato As Date, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_RENOVAR_CONTRATO_EMPLEADO_INS"
            With .Parameters
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IdEmpleado
                .Add("@IDRENOVACIONDETALLE", SqlDbType.Int).Value = IdRenovacionDetalle
                .Add("@NUMEROCONTRATO", SqlDbType.Char, 10).Value = NumeroContrato
                .Add("@FECHAFINALCONTRATO", SqlDbType.Date).Value = FechaFinalContrato
                .Add("@IDUSUARIO", SqlDbType.Int).Value = IdUsuario
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
    Public Function GetEmpleadoRenovacionHistorialList(ByVal FechaDesde As Date, ByVal FechaHasta As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_RENOVACION_CONTRATO_HISTORIAL_LIST"
            With .Parameters
                .Clear()
                .Add("@FECHADESDE", SqlDbType.Date).Value = FechaDesde
                .Add("@FECHAHASTA", SqlDbType.Date).Value = FechaHasta
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
    Public Function UpdateFechaFinContratoNueva(BE As RenovacionContratoBE, ByVal modorenovacion As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_UPDATE_RENOVACION_FECHAFINALNUEVA"
            With .Parameters
                .Add("@IDRENOVACIONDETALLE", SqlDbType.Int).Value = BE.IdRenovacionDetalle
                .Add("@NUMEROMESESRENOVAR", SqlDbType.Int).Value = BE.NumeroMesesRenovar
                .Add("@FECHAPERIODOHASTA", SqlDbType.Date).Value = BE.FechaPeriodoFin
                .Add("@MODORENOVACION", SqlDbType.Int).Value = modorenovacion
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
    Public Function AsignarRenovacionContratoEmpleado(ByVal IdRenovacionDetalle As Integer, ByVal EstadoRenovacion As Int32) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_ASIGNAR_RENOVACION_CONTRATO"
            With .Parameters
                .Add("@IDRENOVACIONDETALLE", SqlDbType.Int).Value = IdRenovacionDetalle
                .Add("@ESTADORENOVACION", SqlDbType.Int).Value = EstadoRenovacion
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
    Public Function UpdateEnvioCorreoFirma(idrenovacion) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_RENOVACIONCONTRATO_FIRMA"
            With .Parameters
                .Add("@IDRENOVACION", SqlDbType.Int).Value = idrenovacion
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
    Public Function EmpleadosMismoLocalPorRenovarList(ByVal IdOrganigrama As Integer, ByVal idrenovacioncontrato As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_OBTENER_EMPLEADOS_MISMOLOCAL_RENOVAR_LIST"
            With .Parameters
                .Clear()
                .Add("@IDORGANIGRAMA", SqlDbType.Int).Value = IdOrganigrama
                .Add("@IDRENOVACIONCONTRATO", SqlDbType.Int).Value = idrenovacioncontrato
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
    Public Function DatosRenovarContrato(ByVal IdRemovacionContrato As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_FORMATO_RENOVACION_CONTRATOS"
            With .Parameters
                .Clear()
                .Add("@IDRENOVACION", SqlDbType.Int).Value = IdRemovacionContrato
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

    Public Function AsignarEmpleadoListadoRenovacion(ByVal idrenovacion As Integer, ByVal idusuario As Int32) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_RETORNARCESEARENOVACION"
            With .Parameters
                .Add("@IDRENOVACIONCONTRATODETALLE", SqlDbType.Int).Value = idrenovacion
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
    'Public Function AsignarRenovacionContrato(ByVal xIdRenovacionContrato As Integer, ByVal xIdEmpleado As Int32, ByVal xFechaFinalContratoNuevo As Date, ByVal xIdUsuarioRegistro As Int32) As Boolean
    '    Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
    '    Dim cmd As New SqlCommand
    '    Dim Result As Boolean = False
    '    With cmd
    '        .Connection = cnx
    '        .CommandType = CommandType.StoredProcedure
    '        .CommandText = "RC_RENOVACION_CONTRATO_ASIGNAR"
    '        With .Parameters
    '            .Add("@IDRENOVACIONCONTRATO", SqlDbType.Int).Value = xIdRenovacionContrato
    '            .Add("@IDEMPLEADO", SqlDbType.Int).Value = xIdEmpleado
    '            .Add("@FECHAFINALCONTRATONUEVO", SqlDbType.Date).Value = xFechaFinalContratoNuevo
    '            .Add("@IDUSUARIO", SqlDbType.Int).Value = xIdUsuarioRegistro
    '            Try
    '                cnx.Open()
    '                cmd.ExecuteNonQuery()
    '                Result = True
    '            Catch ex As Exception
    '                Throw
    '            Finally
    '                If cnx.State = ConnectionState.Open Then
    '                    cnx.Close()
    '                End If
    '            End Try
    '            Return Result
    '        End With
    '    End With
    'End Function 'OK

#End Region



End Class
