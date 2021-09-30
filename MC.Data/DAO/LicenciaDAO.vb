Imports System.Data.SqlClient
Public Class LicenciaDAO
    Dim LicenciasBE As New LicenciasBE
    Public IdEmpleado As Integer
    Public IdLicencia As Integer
    Public IdTipoLicencia As Integer
#Region "LICENCIAS CON GOCE"
    Public Function LicenciasConGoceListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_LICENCIACONGOCE_LIST_PREVIEW_ALL"
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
    Public Function LicenciasConGoceMotevoLeyList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_LICENCIACONGOCE_MOTIVOLEY_LIST"
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


    Public Function LicenciasConGoceDescansoMedicoListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_LICENCIA_DESCANSOSMEDICOS_LIST_PREVIEW_ALL"
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
    Public Function LicenciasConGoceValidadasListAll(ByVal FECHAINICIO As Date, ByVal FECHAFINAL As Date, ByVal TIPOFILTRO As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_LICENCIACONGOCE_VALIDADO_LIST_PREVIEW_ALL"
            With .Parameters
                .Add("@FECHAINICIO", SqlDbType.Date).Value = FECHAINICIO
                .Add("@FECHAFINAL", SqlDbType.Date).Value = FECHAFINAL
                .Add("@TIPOFILTRO", SqlDbType.Int).Value = TIPOFILTRO
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
    Public Function GetLicenciaByID(ByVal IDLICENCIA As Int32) As LicenciasBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_LICENCIA_GET_BY_ID"
            With .Parameters
                .Add("@IDLICENCIA", SqlDbType.Int).Value = IDLICENCIA
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With LicenciasBE
                        .IdLicencia = dr.ReadNullAsNumeric("IDLICENCIA")
                        .NumeroSolicitud = dr.ReadNullAsEmptyString("NUMEROSOLICITUD")
                        .LicenciaTipo = dr.ReadNullAsEmptyString("TIPOLICENCIA")
                        .IdSolicitante = dr.ReadNullAsNumeric("IDSOLICITANTE")
                        .NombreEmpleado = dr.ReadNullAsEmptyString("EMPLEADONOMBRE")
                        .IdLocal = dr.ReadNullAsNumeric("IDLOCAL")
                        .RazonSocial = dr.ReadNullAsEmptyString("RAZONSOCIAL")
                        .RazonComercial = dr.ReadNullAsEmptyString("RAZONCOMERCIAL")
                        .Cargo = dr.ReadNullAsEmptyString("EMPLEADOCARGO")
                        .DNI = dr.ReadNullAsEmptyString("EMPLEADODNI")
                        .Fecha = dr.ReadNullAsEmptyDate("FECHA")
                        .FechaIngreso = dr.ReadNullAsEmptyDate("FECHAINGRESO")
                        .FechaPeriodoInicio = dr.ReadNullAsEmptyDate("FECHAPERIODOINICIO")
                        .FechaPeriodoFin = dr.ReadNullAsEmptyDate("FECHAPERIODOFIN")
                        .CandidadDias = dr.ReadNullAsNumeric("CANTIDADDIAS")
                        .Descripcion = dr.ReadNullAsEmptyString("DESCRIPCION")
                        .GrupoEnfermedad = dr.ReadNullAsEmptyString("GRUPOENFERMEDAD")
                        .SubGrupoEnfermedad = dr.ReadNullAsEmptyString("SUBGRUPOENFERMEDAD")
                        .IdLicenciaTipo = dr.ReadNullAsNumeric("IDLICENCIATIPO")
                        .IdGrupoEnfermedad = dr.ReadNullAsNumeric("IDGRUPOFAMILIAENFERMEDAD")
                        .IdSubGrupoEnfermedad = dr.ReadNullAsNumeric("IDSUBGRUPOFAMILIAENFERMEDAD")
                        .Telefon = dr.ReadNullAsEmptyString("TELEFONO")

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
        Return LicenciasBE

    End Function
    Public Function ListaLicenciaArchivos(ByVal IDLICENCIA As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_LICENCIA_LISTA_ARCHIVO"
            With .Parameters
                .Add("@IDLICENCIA", SqlDbType.Int).Value = IDLICENCIA
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
    Public Function ValidadoLicenciasGetId(ByVal IDLICENCIA As Integer, ByVal IDEMPLEADO As Integer, ByVal FECHAINICIAL As Date, ByVal FECHAFINAL As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_VALIDADO_LICENCIA_CONGOCE"
            With .Parameters
                .Add("@IDSOLICITUD", SqlDbType.Int).Value = IDLICENCIA
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IDEMPLEADO
                .Add("@FECHAINCIAL", SqlDbType.Date).Value = FECHAINICIAL
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
    End Function
    Public Function GetAllLicenciasConGoceHistorial(ByVal FechaInicial As Date, ByVal FechaFinal As Date, ByVal TipoReporte As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_LICENCIA_CONGOCE_LIST_PREVIEW_ALL_HISTORIAL"
            With .Parameters
                .Add("@FECHAINICIAL", SqlDbType.Date).Value = FechaInicial
                .Add("@FECHAFINAL", SqlDbType.Date).Value = FechaFinal
                .Add("@TIPOREPORTE", SqlDbType.Int).Value = TipoReporte
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
    Public Function RegistradoLicenciaByID(ByVal IDLICENCIA As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_LICENCIA_RESGISTRO_ADRYAN"
            With .Parameters
                .Add("@IDLICENCIA", SqlDbType.Int).Value = IDLICENCIA
                '.Add("@IDTIPOLICENCIA", SqlDbType.Int).Value = TIPOLICENCIA
                '.Add("@IDGRUPOFAMILIAENFERMEDAD", SqlDbType.Int).Value = GRUPOENFERMEDAD
                '.Add("@IDSUBGRUPOFAMILIAENFERMEDAD", SqlDbType.Int).Value = SUBGRUPOENFERMEDAD
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
    Public Function UpdateLicenciaConGoceDatosById(BE As LicenciasBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "MCRH_UPDATE_DATOS_LICENCIACONGOCE_ID"
            With .Parameters
                .Add("@IDLICENCIA", SqlDbType.Int).Value = BE.IdLicencia
                .Add("@IDLICENCIATIPO", SqlDbType.Int).Value = BE.IdLicenciaTipo
                .Add("@IDMOTIVODERECHOLEY", SqlDbType.Int).Value = BE.IdMotivoDerechoLey
                .Add("@FECHAPERIODOINICIO", SqlDbType.Date).Value = BE.FechaPeriodoInicio
                .Add("@FECHAPERIODOFIN", SqlDbType.Date).Value = BE.FechaPeriodoFin
                .Add("@IDMESEVALUACION", SqlDbType.Int).Value = BE.IdMesEvaluacion
                .Add("@ESTADOPAGO", SqlDbType.Bit, 500).Value = BE.EstadoPago
                .Add("@OBSERVACIONLICENCIAOTROS", SqlDbType.NVarChar, 500).Value = BE.ObservacionLicenciaOtros
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
    End Function
    Public Function DesprocesarValidadoSolicitudLicencia(ByVal IDLICENCIA As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "MCRH_LICENCIA_DESPROCESARVALIDADO_SOLICITUD"
            With .Parameters
                .Add("@IDLICENCIA", SqlDbType.Int).Value = IDLICENCIA
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
    End Function
    Public Function LicenciaEnvioCorreo(ByVal IDLICENCIA As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_LICENCIA_DESPROCESAR_VALIDADO_CORREO"
            With .Parameters
                .Add("@IDLICENCIA", SqlDbType.Int).Value = IDLICENCIA
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
    Public Function AccionLicenciaByID(ByVal IDLICENCIA As Integer, ByVal IDUSUARIO As Integer) As Boolean
        'ACCION ==>( 1=GUARDAR,2=VALIDAR,3=APROBAR) 
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_LICENCIA_ACCION_RRHH"
            With .Parameters
                .Add("@IDLICENCIA", SqlDbType.Int).Value = IDLICENCIA ''BE.IdLicencia
                .Add("@IDUSUARIO", SqlDbType.Int).Value = IDUSUARIO



                '.Add("@IDTIPOLICENCIA", SqlDbType.Int).Value = BE.IdLicenciaTipo
                '.Add("@IDGRUPOFAMILIAENFERMEDAD", SqlDbType.Int).Value = BE.IdGrupoEnfermedad
                '.Add("@IDSUBGRUPOFAMILIAENFERMEDAD", SqlDbType.Int).Value = BE.IdSubGrupoEnfermedad
                '.Add("@FECHAINICIAL", SqlDbType.Date).Value = BE.FechaPeriodoInicio
                '.Add("@FECHAFINAL", SqlDbType.Date).Value = BE.FechaPeriodoFin
                '.Add("@ACCION", SqlDbType.Int).Value = ACCION
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
    Public Function AprobarLicenciaSinGoceByID(ByVal IDLICENCIA As Integer, ByVal IDUSUARIO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_LICENCIASINGOCE_APROBAR"
            With .Parameters
                .Add("@IDLICENCIA", SqlDbType.Int).Value = IDLICENCIA
                .Add("@IDUSUARIO", SqlDbType.Int).Value = IDUSUARIO
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
    'Public Function AccionLicenciaByID1(ByVal IDLICENCIA As Integer, ByVal ACCION As Integer, ByVal IDUSUARIO As Integer) As Boolean
    '    'ACCION ==>( 1=GUARDAR,2=VALIDAR,3=APROBAR) 
    '    Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
    '    Dim cmd As New SqlCommand
    '    Dim Result As Boolean
    '    With cmd
    '        .Connection = cnx
    '        .CommandType = CommandType.StoredProcedure
    '        .CommandText = "MCRH_LICENCIA_ACCION_RRHH"
    '        With .Parameters
    '            .Add("@IDLICENCIA", SqlDbType.Int).Value = IDLICENCIA
    '            .Add("@IDUSUARIO", SqlDbType.Int).Value = IDUSUARIO



    '            '.Add("@IDTIPOLICENCIA", SqlDbType.Int).Value = BE.IdLicenciaTipo
    '            '.Add("@IDGRUPOFAMILIAENFERMEDAD", SqlDbType.Int).Value = BE.IdGrupoEnfermedad
    '            '.Add("@IDSUBGRUPOFAMILIAENFERMEDAD", SqlDbType.Int).Value = BE.IdSubGrupoEnfermedad
    '            '.Add("@FECHAINICIAL", SqlDbType.Date).Value = BE.FechaPeriodoInicio
    '            '.Add("@FECHAFINAL", SqlDbType.Date).Value = BE.FechaPeriodoFin
    '            .Add("@ACCION", SqlDbType.Int).Value = ACCION
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


    Public Function GetListarLicenciaEmpleado(ByVal IDEMPLEADO As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_HISTORIAL_LICENCIAS_GET_IDEMPLEADO"
            .CommandTimeout = 0
            With .Parameters
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IDEMPLEADO
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
    Public Function AnularLicenciaRRHH(ByVal IDLICENCIA As Integer, ByVal IDUSUARIO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_LICENCIA_ANULAR_RRHH"
            With .Parameters
                .Add("@IDLICENCIA", SqlDbType.Int).Value = IDLICENCIA
                .Add("@IDUSUARIO", SqlDbType.Int).Value = IDUSUARIO
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
    Public Function GetListarGrupoEnfermedades() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_LICENCIA_GRUPOENFERMEDADES_LIST"
            .CommandTimeout = 0
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
    Public Function GetListarMesEnfermedades() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MES_LIST"
            .CommandTimeout = 0
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
    Public Function GetListarObservacionEnfermedades() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_ENFERMEDAD_OBSERVACION_LIST"
            .CommandTimeout = 0
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
    Public Function ListarBancoEnfermedades() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_LIST_BANCO"
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
    End Function 'ok
    Public Function ListarDatosEnfermedades(ByVal IDLICENCIA As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_LIST_DATOS_ENFERMEDADES_ID"
            With .Parameters
                .Add("@IDLICENCIA", SqlDbType.Int).Value = IDLICENCIA
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
    End Function 'ok

    Public Function UpdateDatosEnfermedades(ByVal BE As LicenciasBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "MCRH_UPDATE_DATOS_ENFERMEDADES_ID"
            With .Parameters
                .Add("@IDLICENCIA", SqlDbType.Int).Value = BE.IdLicencia
                .Add("@IDSUBGRUPOFAMILIAENFERMEDAD", SqlDbType.Int).Value = BE.IdSubGrupoEnfermedad
                .Add("@PERIODOINICIO", SqlDbType.Date).Value = BE.FechaPeriodoInicio
                .Add("@PERIODOFIN", SqlDbType.Date).Value = BE.FechaPeriodoFin
                .Add("@IDPROCEDENCIA", SqlDbType.Int).Value = BE.IdProcedencia
                .Add("@IDMOTIVOENFERMEDAD", SqlDbType.Int).Value = BE.IdMotivoEnfermedad
                .Add("@NUMERODESCANSOMEDICO", SqlDbType.NVarChar, 50).Value = BE.NumeroDescansoMedico
                .Add("@IDMESEVALUACION", SqlDbType.Int).Value = BE.IdMesEvaluacion
                .Add("@ESTADOPAGO", SqlDbType.Bit).Value = BE.EstadoPago
                .Add("@DECLARACION", SqlDbType.Bit).Value = BE.Declaracion
                .Add("@DIASSUBSIDIO", SqlDbType.Int).Value = BE.DiasSubSidio
                .Add("@DIASRECUPERADOS", SqlDbType.Int).Value = BE.DiasRecuperados
                .Add("@DIASANULADO", SqlDbType.Int).Value = BE.DiasAnulados
                .Add("@NITESSALUD", SqlDbType.NVarChar, 50).Value = BE.NitEssalud
                .Add("@FECHARECEPCION", SqlDbType.Date).Value = BE.FechaRecepcion
                .Add("@IDTIPOOBSERVACIONENFERMEDAD", SqlDbType.Int).Value = BE.IdTipoObservacionEnfermedad
                .Add("@DETALLEDESCANSOMEDICO", SqlDbType.NVarChar, 500).Value = BE.DetalleDescansoMedico
                .Add("@IDBANCO", SqlDbType.Int, 500).Value = BE.IdBanco
                .Add("@NUMEROCHEQUE", SqlDbType.NVarChar, 50).Value = BE.NumeroCheque
                .Add("@MONTOSUBSIDIADO", SqlDbType.Float).Value = BE.MontoSubSidiado
                .Add("@IDLICENCIATIPO", SqlDbType.Int).Value = BE.IdLicenciaTipo
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
    End Function

    Public Function GetListarSubGrupoEnfermedades() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            '.CommandText = "MCRH_LICENCIA_SUBGRUPOENFERMEDADES_LIST"
            .CommandText = "MCRH_LICENCIA_FAMILIA_ENFERMEDADES_LIST"
            .CommandTimeout = 0
            'With .Parameters
            '    .Add("@IDGRUPOENFERMEDAD", SqlDbType.Int).Value = IDGRUPOENFERMEDAD
            'End With
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
    Public Function GetListarTipoLicencia() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_LICENCIATIPO_LIST"
            .CommandTimeout = 0
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
#Region "DESCANSO MEDICO"
    Public Function DescansoMedicoListHistorialAll(ByVal fechainicio As Date, ByVal fechafinal As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_LICENCIA_DESCANSOSMEDICOS_LIST_HISTORIAL_ALL"
            With .Parameters
                .Add("@FECHAINICIAL", SqlDbType.Date).Value = fechainicio
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
    End Function 'OK

    Public Function AprobarLicenciaDescansoMedicoRRHH(ByVal IDLICENCIA As Integer, ByVal IDUSUARIO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_LICENCIA_DESCANSO_MEDICO_APROBAR"
            With .Parameters
                .Add("@IDLICENCIA", SqlDbType.Int).Value = IDLICENCIA
                .Add("@IDUSUARIO", SqlDbType.Int).Value = IDUSUARIO
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
    Public Function LicenciasEnfermedadProcedenciaListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_ENFERMEDAD_PROCEDENCIA_LIST"
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
    Public Function LicenciasEnfermedadMotivoListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_ENFERMEDAD_MOTIVO_LIST"
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
#Region "LICENCIAS SIN GOCE"
    Public Function LicenciasSinGoceListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_LICENCIASINGOCE_LIST_PREVIEW_ALL"
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
    Public Function ListaLicenciaAcuerdoArchivos(ByVal IDLICENCIA As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_LICENCIASGDH_LISTA_ARCHIVO"
            With .Parameters
                .Add("@IDLICENCIA", SqlDbType.Int).Value = IDLICENCIA
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
    Public Function GetAllLicenciasSinGoceHistorial(ByVal FechaInicial As Date, ByVal FechaFinal As Date, ByVal TipoReporte As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_LICENCIA_SINGOCE_LIST_PREVIEW_ALL_HISTORIAL"
            With .Parameters
                .Add("@FECHAINICIAL", SqlDbType.Date).Value = FechaInicial
                .Add("@FECHAFINAL", SqlDbType.Date).Value = FechaFinal
                .Add("@TIPOREPORTE", SqlDbType.Int).Value = TipoReporte
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
#End Region

End Class
