Imports System.Data.SqlClient

Public Class BEPOSTULANTESMASIVOS
    Public Property ID As Integer
End Class

Public Class BDCentralDAO
    Public Property UsuarioBE As UsuarioBE

    Property IdRequerimiento As Integer = 0
    Property IdRequerimientoCargoMasivo As Integer = 0
    Property IdRequerimientoCargo As Integer = 0
    Property NroVacantesNoMasivos As Integer = 0
    Property IdCargoSolicitante As Int32 = 0
    Property IdTiendaRequerimiento As Integer = 0
    Property IdTurnoRequerimiento As Integer = 0
    Property CargoRequerido As String
    Property RazonComercial As String


    Dim RequerimientoPersonalBE As New RequerimientoPersonalBE

    '-----MANTENIMIENTO
    Dim FuenteReclutamientoBE As New FuenteReclutamientoBE
    Dim FuenteReclutamientoDetalleBE As New FuenteReclutamientoDetalleBE

    Property IdFuente As Int32 = 0

    Dim ConclusionBE As New ConclusionBE
    Dim ConclusionDetalleBE As New ConclusionDetalleBE
    Property IdConclusion As Int32 = 0

    Dim EstadoPostulanteBE As New EstadoPostulanteBE
    Property IdEstadoPostulante As Int32 = 0

    Dim EstadoCondicionActualBE As New EstadoCondicionActualBE
    Property IdEstadoCondicionActual As Int32 = 0

    'Public Function GetVersion(ByVal IDSISTEMA As Integer) As DataTable
    '    Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
    '    Dim cmd As New SqlCommand
    '    Dim dt As New DataTable

    '    With cmd
    '        .Connection = cnx
    '        .CommandType = CommandType.StoredProcedure
    '        .CommandText = "MC_VERSION_SISTEMA_IDSISTEMA"
    '        With .Parameters
    '            .Add("@IDSISTEMA", SqlDbType.Int).Value = IDSISTEMA
    '        End With
    '    End With
    '    Try
    '        cnx.Open()
    '        dt.Load(cmd.ExecuteReader)
    '    Catch ex As Exception
    '        Throw New Exception("BDCentralDAO.GetVersion " & vbCrLf & ex.Message)
    '    Finally
    '        If cnx.State = ConnectionState.Open Then
    '            cnx.Close()
    '        End If
    '    End Try
    '    Return dt

    'End Function


#Region "POSTULANTES MASIVOS"

    Public Function GetPostulantesMasivosList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_POSTULATES_MASIVOS_LIST"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetPostulantesMasivosList " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
    Public Function GetEmpleadosCesadosMasivosList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_EMPLEADOS_CESADOS_MASIVOS"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetEmpleadosCesadosList " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
    Public Function CargarDatosPostulantesCesadosMasivosList(ByVal IDPOSTULANTEMASIVO As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_DATOS_REINGRESO_POSTULANTEMASIVO_GET_ID"
            With .Parameters
                .Add("@IDPOSTULANTEMASIVO", SqlDbType.Int).Value = IDPOSTULANTEMASIVO
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.CargarDatosPostulantesCesadosMasivosList " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function PostulanteMasivoUpdate(ByVal BE As PostulanteMasivoBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_POSTULANTES_MASIVOS_UPDATE"
            With .Parameters
                .Add("@IDPOSTULANTEMASIVO", SqlDbType.Int).Value = BE.IDPOSTULANTEMASIVO
                .Add("@IDTIPODOCUMENTOIDENTIDAD", SqlDbType.Int).Value = BE.IDTIPODOCUMENTOIDENTIDAD
                .Add("@NUMERODOCUMENTO", SqlDbType.VarChar, 50).Value = BE.NUMERODOCUMENTO
                .Add("@NOMBRES", SqlDbType.VarChar, 50).Value = BE.NOMBRES
                .Add("@APELLIDOPATERNO", SqlDbType.VarChar, 50).Value = BE.APELLIDOPATERNO
                .Add("@APELLIDOMATERNO", SqlDbType.VarChar, 50).Value = BE.APELLIDOMATERNO
                .Add("@TELEFONO", SqlDbType.VarChar, 50).Value = BE.TELEFONO
                .Add("@CORREO", SqlDbType.VarChar, 100).Value = BE.CORREO
                .Add("@IDUBIGEO", SqlDbType.Int).Value = BE.IDUBIGEO
                .Add("@FECHANACIMIENTO", SqlDbType.Date).Value = BE.FECHANACIMIENTO
                .Add("@EDAD", SqlDbType.Int).Value = BE.EDAD
                .Add("@IDSEXO", SqlDbType.Int).Value = BE.IDSEXO
                .Add("@IDCARGO", SqlDbType.Int).Value = BE.IDCARGO
                .Add("@IDCARGO2", SqlDbType.Int).Value = BE.IDCARGO2
                .Add("@IDFUENTE", SqlDbType.Int).Value = BE.IDFUENTE
                .Add("@IDFUENTEDETALLE", SqlDbType.Int).Value = BE.IDFUENTEDETALLE
                .Add("@IDCONCLUSION", SqlDbType.Int).Value = BE.IDCONCLUSION
                .Add("@IDCONCLUSIONDETALLE", SqlDbType.Int).Value = BE.IDCONCLUSIONDETALLE
                .Add("@IDTIENDA", SqlDbType.Int).Value = BE.IDTIENDA
                .Add("@FECHACONVOCATORIA", SqlDbType.Date).Value = BE.FECHACONVOCATORIA
                .Add("@FECHAEVALUACION", SqlDbType.Date).Value = BE.FECHAEVALUACION
                .Add("@OBSERVACION", SqlDbType.VarChar, 500).Value = BE.OBSERVACION
                .Add("@IDTURNO", SqlDbType.Int).Value = BE.IDTURNO
                .Add("@FECHAFIRMACONTRATO", SqlDbType.Date).Value = BE.FECHAFIRMACONTRATO
                .Add("@FECHAENVIACORREO", SqlDbType.Date).Value = BE.FECHAENVIOCORREO
                .Add("@FECHAINGRESOTIENDAPROGRAMADO", SqlDbType.Date).Value = BE.FECHAINGRESOTIENDAPROGRAMADO
                .Add("@FECHARESPUESTACORREO", SqlDbType.Date).Value = BE.FECHARESPUESTACORREO
                .Add("@FECHAINGRESOTIENDAREAL", SqlDbType.Date).Value = BE.FECHAINGRESOTIENDAREAL
                .Add("@SEGUIMIENTOQUINCENALFECHA", SqlDbType.Date).Value = BE.SEGUIMIENTOQUINCENALFECHA
                .Add("@IDCONDICIONACTUAL", SqlDbType.Int).Value = BE.IDCONDICIONACTUAL
                .Add("@SEGUIMIENTOQUINCENALOBSERVACION", SqlDbType.NVarChar, 500).Value = BE.SEGUIMIENTOQUINCENALOBSERVACION
                .Add("@ESTADOASIGNACION", SqlDbType.Bit).Value = BE.ESTADOASIGNACION
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

    Public Function GetCargarDatosEmpleadoMasivoGetId(ByVal IDTIPOIDENTIDAD As String, ByVal NUMEROIDENTIDAD As String) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_CARGAR_DATOS_EMPLEADO_MASIVO"
            With .Parameters
                .Add("@IDTIPODOCUMENTOIDENTIDAD", SqlDbType.Int).Value = IDTIPOIDENTIDAD
                .Add("@NUMERODOCUMENTO", SqlDbType.NVarChar).Value = NUMEROIDENTIDAD
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetCargarDatosEmpleadoGetId " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
    Public Function PostulanteMasivoInsert(ByVal BE As PostulanteMasivoBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_POSTULANTES_MASIVOS_INSERT"
            With .Parameters
                .Add("@IDPOSTULANTEMASIVO", SqlDbType.Int).Value = BE.IDPOSTULANTEMASIVO
                '.Add("@IDREQUERIMIENTO", SqlDbType.Int).Value = BE.IDREQUERIMIENTO
                .Add("@IDTIPODOCUMENTOIDENTIDAD", SqlDbType.Int).Value = BE.IDTIPODOCUMENTOIDENTIDAD
                .Add("@NUMERODOCUMENTO", SqlDbType.VarChar, 50).Value = BE.NUMERODOCUMENTO
                .Add("@NOMBRES", SqlDbType.VarChar, 50).Value = BE.NOMBRES
                .Add("@APELLIDOPATERNO", SqlDbType.VarChar, 50).Value = BE.APELLIDOPATERNO
                .Add("@APELLIDOMATERNO", SqlDbType.VarChar, 50).Value = BE.APELLIDOMATERNO
                .Add("@TELEFONO", SqlDbType.VarChar, 50).Value = BE.TELEFONO
                .Add("@CORREO", SqlDbType.VarChar, 100).Value = BE.CORREO
                .Add("@IDUBIGEO", SqlDbType.Int).Value = BE.IDUBIGEO
                .Add("@FECHANACIMIENTO", SqlDbType.Date).Value = BE.FECHANACIMIENTO
                .Add("@EDAD", SqlDbType.Int).Value = BE.EDAD
                .Add("@IDSEXO", SqlDbType.Int).Value = BE.IDSEXO
                .Add("@IDCARGO", SqlDbType.Int).Value = BE.IDCARGO
                .Add("@IDCARGO2", SqlDbType.Int).Value = BE.IDCARGO2
                .Add("@IDFUENTE", SqlDbType.Int).Value = BE.IDFUENTE
                .Add("@IDFUENTEDETALLE", SqlDbType.Int).Value = BE.IDFUENTEDETALLE
                .Add("@IDCONCLUSION", SqlDbType.Int).Value = BE.IDCONCLUSION
                .Add("@IDCONCLUSIONDETALLE", SqlDbType.Int).Value = BE.IDCONCLUSIONDETALLE
                .Add("@IDTIENDA", SqlDbType.Int).Value = BE.IDTIENDA
                .Add("@FECHACONVOCATORIA", SqlDbType.Date).Value = BE.FECHACONVOCATORIA
                .Add("@FECHAEVALUACION", SqlDbType.Date).Value = BE.FECHAEVALUACION
                .Add("@OBSERVACION", SqlDbType.VarChar, 500).Value = BE.OBSERVACION
                .Add("@IDTURNO", SqlDbType.Int).Value = BE.IDTURNO
                .Add("@FECHAFIRMACONTRATO", SqlDbType.Date).Value = BE.FECHAFIRMACONTRATO
                .Add("@FECHAENVIACORREO", SqlDbType.Date).Value = BE.FECHAENVIOCORREO
                .Add("@FECHAINGRESOTIENDAPROGRAMADO", SqlDbType.Date).Value = BE.FECHAINGRESOTIENDAPROGRAMADO
                .Add("@FECHARESPUESTACORREO", SqlDbType.Date).Value = BE.FECHARESPUESTACORREO
                .Add("@FECHAINGRESOTIENDAREAL", SqlDbType.Date).Value = BE.FECHAINGRESOTIENDAREAL
                .Add("@SEGUIMIENTOQUINCENALFECHA", SqlDbType.Date).Value = BE.SEGUIMIENTOQUINCENALFECHA
                .Add("@IDCONDICIONACTUAL", SqlDbType.Int).Value = BE.IDCONDICIONACTUAL
                .Add("@SEGUIMIENTOQUINCENALOBSERVACION", SqlDbType.NVarChar, 50).Value = BE.SEGUIMIENTOQUINCENALOBSERVACION
                .Add("@ESTADOASIGNACION", SqlDbType.Bit).Value = BE.ESTADOASIGNACION
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

    Public Function ValidarDNIMasivos(ByVal idtipodocumentoidentidad As Integer, ByVal numerodocumento As String) As String
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        ' Dim Result As Boolean = False
        Dim Result As String = ""
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_VALIDAR_NUMERODOCUMENTO_MASIVOS"
            With .Parameters
                .Add("@IDTIPODOCUMENTOIDENTIDAD", SqlDbType.Int).Value = idtipodocumentoidentidad
                .Add("@NUMERODOCUMENTO", SqlDbType.VarChar, 50).Value = numerodocumento
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
            'If dt.Rows(0)(0) = "0" Then

            Result = dt.Rows(0)(0)
            ' Result = True
            '    Result = "Postulante se encuentra registrado como empleado, pero no como postulante. ¿Desea registrarlo?"
            'ElseIf dt.Rows(0)(0) = "1" Then
            '    Result = "Registro Exitoso"
            'ElseIf dt.Rows(0)(0) = "2" Then
            '    Result = "Postulante ya existe"
            'ElseIf dt.Rows(0)(0) = "3" Then
            '    Result = "Postulante ya existe"
            'End If
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function UpdatePostulanteMasivoEstadoAsignacion(ByVal IDPOSTULANTEMASIVO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_POSTULANTES_MASIVOS_UPDATE_ASIGNACION"
            With .Parameters
                .Add("@IDPOSTULANTEMASIVO", SqlDbType.Int).Value = IDPOSTULANTEMASIVO

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

    Public Function RequerimientoPersonalValidarProcesarMasivo(ByVal IDREQUERIMIENTO As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_REQUERIMIENTO_PERSONAL_VALIDAR_PROCESAR_MASIVO"
            With .Parameters
                .Add("@IDREQUERIMIENTO", SqlDbType.Int).Value = IDREQUERIMIENTO
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

    Public Function RequerimientoPersonalUpdateEstadoProcesarMasivo(ByVal IDPOSTULANTEMASIVO As Integer, ByVal IDREQUERIMIENTO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_REQUERIMIENTO_PERSONAL_UPDATE_PROCESAR_MASIVO"
            With .Parameters
                .Add("@IDREQUERIMIENTO", SqlDbType.Int).Value = IDREQUERIMIENTO
                .Add("@IDPOSTULANTEMASIVO", SqlDbType.Int).Value = IDPOSTULANTEMASIVO
                .Add("@IDUSUARIO", SqlDbType.Int).Value = UsuarioBE.IDUsuario
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

    Public Function PostulanteMasivoUpdateEnvioCorreo(ByVal IDPOSTULANTEMASIVO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_POSTULANTES_MASIVOS_UPDATE_ENVIOCORREO"
            With .Parameters
                .Add("@IDPOSTULANTEMASIVO", SqlDbType.Int).Value = IDPOSTULANTEMASIVO
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

    Public Function ValidarRequerimientoProcesado(ByVal idrequerimiento As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_VALIDAR_REQUERIMIENTO_PROCESADO"
            With .Parameters
                .Add("@IDREQUERIMIENTO", SqlDbType.Int).Value = idrequerimiento
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
            If dt.Rows(0)(0) = "1" Then
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

    Public Function GetPostulantesMasivosAsignados(ByVal fechainicial As Date, ByVal fechafinal As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_POSTULANTES_MASIVOS_ASIGNADOS"
            With .Parameters
                .Add("@FECHAINICIO", SqlDbType.Date).Value = fechainicial
                .Add("@FECHAFINAL", SqlDbType.Date).Value = fechafinal
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetPostulantesMasivosAsignados " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
    Public Function RetornarEmpleadoCesadoAPostulante(ByVal IDPOSTULANTEMASIVO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_RETORNAR_EMPLEADO_CESADOAPOSTULANTE"
            With .Parameters
                .Add("@IDPOSTULANTEMASIVO", SqlDbType.Int).Value = IDPOSTULANTEMASIVO
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
    Public Function LiberarPostulanteMasivo(ByVal IDPOSTULANTEMASIVO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_LIBERAR_POSTULANTE_MASIVO"
            With .Parameters
                .Add("@IDPOSTULANTEMASIVO", SqlDbType.Int).Value = IDPOSTULANTEMASIVO
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

#End Region



#Region "POSTULANTES NO MASIVOS"
    Public Function GetCargarDatosEmpleadoNOMasivoGetId(ByVal IDTIPODOCUMENTOIDENTIDAD As String, ByVal NUMERODOCUMENTO As String) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_CARGAR_DATOS_EMPLEADO_NOMASIVO"
            With .Parameters
                .Add("@IDTIPODOCUMENTOIDENTIDAD", SqlDbType.Int).Value = IDTIPODOCUMENTOIDENTIDAD
                .Add("@NUMERODOCUMENTO", SqlDbType.NVarChar).Value = NUMERODOCUMENTO
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetCargarDatosEmpleadoGetId " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
    Public Function UpdatePostulanteNoMasivoEstadoAsignacion(ByVal BE As PostulanteNoMasivoBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_POSTULANTES_NOMASIVOS_UPDATE_ASIGNACION"
            With .Parameters
                .Add("@IDPOSTULANTENOMASIVO", SqlDbType.Int).Value = BE.IDPOSTULANTENOMASIVO
                .Add("@IDREQUERIMIENTO", SqlDbType.Int).Value = BE.IDREQUERIMIENTO

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

    Public Function GetPostulantesNoMasivosList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_POSTULATES_NOMASIVOS_LIST"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetPostulantesNoMasivosList " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetPostulantesNoMasivosListxRequerimiento(ByVal IDREQUERIMIENTO As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_POSTULATES_NOMASIVOS_LIST_IDREQUERIMIENTOPERSONAL"
            With .Parameters
                .Add("@IDREQUERIMIENTO", SqlDbType.Int).Value = IDREQUERIMIENTO
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetPostulantesNoMasivosListxRequerimiento " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetPostulantesNoMasivosListBuscar(ByVal IDREQUERIMIENTO As Integer, ByVal IDCARGO As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_POSTULATES_NOMASIVOS_BUSCAR"
            With .Parameters
                .Add("@IDREQUERIMIENTO", SqlDbType.Int).Value = IDREQUERIMIENTO
                .Add("@IDCARGO", SqlDbType.Int).Value = IDCARGO
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetPostulantesNoMasivosListBuscar " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function PostulanteNoMasivoUpdate(ByVal BE As PostulanteNoMasivoBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_POSTULANTES_NOMASIVOS_UPDATE"
            With .Parameters
                .Add("@IDPOSTULANTENOMASIVO", SqlDbType.Int).Value = BE.IDPOSTULANTENOMASIVO
                .Add("@IDTIPODOCUMENTOIDENTIDAD", SqlDbType.Int).Value = BE.IDTIPODOCUMENTOIDENTIDAD
                .Add("@NUMERODOCUMENTO", SqlDbType.VarChar, 50).Value = BE.NUMERODOCUMENTO
                .Add("@NOMBRES", SqlDbType.VarChar, 50).Value = BE.NOMBRES
                .Add("@APELLIDOPATERNO", SqlDbType.VarChar, 50).Value = BE.APELLIDOPATERNO
                .Add("@APELLIDOMATERNO", SqlDbType.VarChar, 50).Value = BE.APELLIDOMATERNO
                .Add("@TELEFONOFIJO", SqlDbType.VarChar, 50).Value = BE.TELEFONOFIJO
                .Add("@TELEFONOCELULAR", SqlDbType.VarChar, 50).Value = BE.TELEFONOCELULAR
                .Add("@TELEFONOCELULAR2", SqlDbType.VarChar, 50).Value = BE.TELEFONOCELULAR2
                .Add("@CORREO", SqlDbType.VarChar, 100).Value = BE.CORREO
                .Add("@FECHANACIMIENTO", SqlDbType.Date).Value = BE.FECHANACIMIENTO
                .Add("@IDFUENTE", SqlDbType.Int).Value = BE.IDFUENTE
                .Add("@SALARIO", SqlDbType.NVarChar, 50).Value = BE.SALARIO
                .Add("@OBSERVACION", SqlDbType.VarChar, 500).Value = BE.OBSERVACION
                .Add("@IDESTADO", SqlDbType.Int).Value = BE.IDESTADO
                .Add("@HORA", SqlDbType.NVarChar, 50).Value = BE.HORA
                .Add("@FECHACONVOCATORIA1", SqlDbType.Date).Value = BE.FECHACONVOCATORIA1
                .Add("@FECHACONVOCATORIA2", SqlDbType.Date).Value = BE.FECHACONVOCATORIA2
                .Add("@FECHACONVOCATORIA3", SqlDbType.Date).Value = BE.FECHACONVOCATORIA3
                .Add("@IDESTADOCREDITICIO", SqlDbType.Int).Value = BE.IDESTADOCREDITICIO
                .Add("@MONTOADEUDADO", SqlDbType.NVarChar, 200).Value = BE.MONTOADEUDADO
                .Add("@DIAVENCIMIENTO", SqlDbType.Int).Value = BE.DIAVENCIMIENTO
                .Add("@ENTIDAD", SqlDbType.NVarChar, 200).Value = BE.ENTIDAD
                .Add("@IDESTADOPSICOLOGICO", SqlDbType.Int).Value = BE.IDESTADOPSICOLOGICO
                .Add("@IDESTADOASSESMENT", SqlDbType.Int).Value = BE.IDESTADOASSESMENT
                .Add("@IDENTREVISTASELECCION", SqlDbType.Int).Value = BE.IDENTREVISTASELECCION
                .Add("@OBSERVACION2", SqlDbType.NVarChar, 500).Value = BE.OBSERVACION2
                .Add("@IDENTREVISTAPREVIA", SqlDbType.Int).Value = BE.IDENTREVISTAPREVIA
                .Add("@IDENTREVISTAAREAFINAL", SqlDbType.Int).Value = BE.IDENTREVISTAAREAFINAL
                .Add("@OBSERVACION3", SqlDbType.NVarChar, 500).Value = BE.OBSERVACION3
                .Add("@ESTADOASIGNACION", SqlDbType.Bit).Value = BE.ESTADOASIGNACION
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

    Public Function PostulanteNoMasivoInsert(ByVal BE As PostulanteNoMasivoBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_POSTULANTES_NOMASIVOS_INSERT"
            With .Parameters
                .Add("@IDPOSTULANTENOMASIVO", SqlDbType.Int).Value = BE.IDPOSTULANTENOMASIVO
                .Add("@IDREQUERIMIENTO", SqlDbType.Int).Value = BE.IDREQUERIMIENTO
                .Add("@IDTIPODOCUMENTOIDENTIDAD", SqlDbType.Int).Value = BE.IDTIPODOCUMENTOIDENTIDAD
                .Add("@IDCARGO", SqlDbType.Int).Value = BE.IDCARGO
                .Add("@NUMERODOCUMENTO", SqlDbType.VarChar, 50).Value = BE.NUMERODOCUMENTO
                .Add("@NOMBRES", SqlDbType.VarChar, 50).Value = BE.NOMBRES
                .Add("@APELLIDOPATERNO", SqlDbType.VarChar, 50).Value = BE.APELLIDOPATERNO
                .Add("@APELLIDOMATERNO", SqlDbType.VarChar, 50).Value = BE.APELLIDOMATERNO
                .Add("@TELEFONOFIJO", SqlDbType.VarChar, 50).Value = BE.TELEFONOFIJO
                .Add("@TELEFONOCELULAR", SqlDbType.VarChar, 50).Value = BE.TELEFONOCELULAR
                .Add("@TELEFONOCELULAR2", SqlDbType.VarChar, 50).Value = BE.TELEFONOCELULAR2
                .Add("@CORREO", SqlDbType.VarChar, 100).Value = BE.CORREO
                .Add("@FECHANACIMIENTO", SqlDbType.Date).Value = BE.FECHANACIMIENTO
                .Add("@IDFUENTE", SqlDbType.Int).Value = BE.IDFUENTE
                .Add("@SALARIO", SqlDbType.NVarChar, 50).Value = BE.SALARIO
                .Add("@OBSERVACION", SqlDbType.VarChar, 500).Value = BE.OBSERVACION
                .Add("@IDESTADO", SqlDbType.Int).Value = BE.IDESTADO
                .Add("@HORA", SqlDbType.NVarChar, 50).Value = BE.HORA
                .Add("@FECHACONVOCATORIA1", SqlDbType.Date).Value = BE.FECHACONVOCATORIA1
                .Add("@FECHACONVOCATORIA2", SqlDbType.Date).Value = BE.FECHACONVOCATORIA2
                .Add("@FECHACONVOCATORIA3", SqlDbType.Date).Value = BE.FECHACONVOCATORIA3
                .Add("@IDESTADOCREDITICIO", SqlDbType.Int).Value = BE.IDESTADOCREDITICIO
                .Add("@MONTOADEUDADO", SqlDbType.NVarChar, 200).Value = BE.MONTOADEUDADO
                .Add("@DIAVENCIMIENTO", SqlDbType.Int).Value = BE.DIAVENCIMIENTO
                .Add("@ENTIDAD", SqlDbType.NVarChar, 200).Value = BE.ENTIDAD
                .Add("@IDESTADOPSICOLOGICO", SqlDbType.Int).Value = BE.IDESTADOPSICOLOGICO
                .Add("@IDESTADOASSESMENT", SqlDbType.Int).Value = BE.IDESTADOASSESMENT
                .Add("@IDENTREVISTASELECCION", SqlDbType.Int).Value = BE.IDENTREVISTASELECCION
                .Add("@OBSERVACION2", SqlDbType.NVarChar, 500).Value = BE.OBSERVACION2
                .Add("@IDENTREVISTAPREVIA", SqlDbType.Int).Value = BE.IDENTREVISTAPREVIA
                .Add("@IDENTREVISTAAREAFINAL", SqlDbType.Int).Value = BE.IDENTREVISTAAREAFINAL
                .Add("@OBSERVACION3", SqlDbType.NVarChar, 500).Value = BE.OBSERVACION3
                .Add("@ESTADOASIGNACION", SqlDbType.Bit).Value = BE.ESTADOASIGNACION
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

    Public Function ValidarDNINoMasivos(ByVal idtipodocumentoidentidad As Integer, ByVal numerodocumento As String) As String
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        ' Dim Result As Boolean = False
        Dim Result As String = ""
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_VALIDAR_NUMERODOCUMENTO_NOMASIVOS"
            With .Parameters
                .Add("@IDTIPODOCUMENTOIDENTIDAD", SqlDbType.Int).Value = idtipodocumentoidentidad
                .Add("@NUMERODOCUMENTO", SqlDbType.VarChar, 50).Value = numerodocumento
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
            'If dt.Rows(0)(0) = "0" Then

            Result = dt.Rows(0)(0)
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function PostulanteNoMasivoUpdateRequerimiento(ByVal IDPOSTULANTENOMASIVO As Integer, ByVal IDREQUERIMIENTO As Integer, ByVal IDCARGO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_POSTULANTES_NOMASIVOS_UPDATE_REQUERIMIENTO"
            With .Parameters
                .Add("@IDPOSTULANTENOMASIVO", SqlDbType.Int).Value = IDPOSTULANTENOMASIVO
                .Add("@IDREQUERIMIENTO", SqlDbType.Int).Value = IDREQUERIMIENTO
                .Add("@IDCARGO", SqlDbType.Int).Value = IDCARGO
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

    Public Function RequerimientoPersonalValidarNoMasivo(ByVal IDREQUERIMIENTO As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand

        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_REQUERIMIENTO_PERSONAL_VALIDAR_NOMASIVO"
            With .Parameters
                .Add("@IDREQUERIMIENTO", SqlDbType.Int).Value = IDREQUERIMIENTO
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

    Public Function RequerimientoPersonalUpdateEstadoProcesarNoMasivo(ByVal IDREQUERIMIENTO As Integer, ByVal VACANTESATENDIDAS As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_REQUERIMIENTO_PERSONAL_UPDATE_PROCESAR_NOMASIVO"
            With .Parameters
                .Add("@IDREQUERIMIENTO", SqlDbType.Int).Value = IDREQUERIMIENTO
                .Add("@VACANTESATENDIDAS", SqlDbType.Int).Value = VACANTESATENDIDAS
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

    Public Function PostulanteNoMasivoUpdateEstadoAsignacion(ByVal IDPOSTULANTENOMASIVO As Integer, ByVal IDREQUERIMIENTO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_POSTULANTES_NOMASIVOS_UPDATE_ESTADO_ASIGNACION"
            With .Parameters
                .Add("@IDPOSTULANTENOMASIVO", SqlDbType.Int).Value = IDPOSTULANTENOMASIVO
                .Add("@IDREQUERIMIENTO", SqlDbType.Int).Value = IDREQUERIMIENTO
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


#End Region



#Region "REQUERIMIENTOS LIST Y PROCESOS"

    Public Function GetRequerimientosMasivosAprobadosList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_REQUERIMIENTOPERSONAL_MASIVO_LIST"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetRequerimientosMasivosAprobadosList " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetRequerimientosNoMasivosAprobadosList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_REQUERIMIENTOPERSONAL_NOMASIVO_LIST"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetRequerimientosNoMasivosAprobadosList " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function RequerimientoPersonalUpdateEstadoAsignacion(ByVal IDREQUERIMIENTO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_REQUERIMIENTO_PERSONAL_UPDATE_ESTADO_ASIGNACION"
            With .Parameters
                .Add("@IDREQUERIMIENTO", SqlDbType.Int).Value = IDREQUERIMIENTO
                .Add("@IDUSUARIO", SqlDbType.Int).Value = UsuarioBE.IDUsuario
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
    Public Function RequerimientoPersonalUpdateVacantesAtendidas(ByVal IDREQUERIMIENTOPERSONAL As Integer, ByVal VACANTESATENDIDAS As Integer, ByVal CIERRE As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "MCRH_REQUERIMIENTOPERSONAL_UPDATE_ASIGNACION_POSTULANTE"
            With .Parameters
                .Add("@IDREQUERIMIENTOPERSONAL", SqlDbType.Int).Value = IDREQUERIMIENTOPERSONAL
                .Add("@VACANTESATENDIDAS", SqlDbType.Int).Value = VACANTESATENDIDAS
                .Add("@CIERRE", SqlDbType.Int).Value = CIERRE
            End With

        End With
        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            'Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function


    Public Function LiberarRequerimientoNoMasivo(ByVal IDREQUERIMIENTO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_LIBERAR_REQUERIMIENTO_NOMASIVO"
            With .Parameters
                .Add("@IDREQUERIMIENTO", SqlDbType.Int).Value = IDREQUERIMIENTO
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

    Public Function LiberarRequerimientoMasivo(ByVal IDREQUERIMIENTO As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_LIBERAR_REQUERIMIENTO_MASIVO"
            With .Parameters
                .Add("@IDREQUERIMIENTO", SqlDbType.Int).Value = IDREQUERIMIENTO
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

    'MASIVOS
    Public Function GetRequerimientosMasivosHistorial(ByVal fechainicio As Date, ByVal fechafinal As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_REQUERIMIENTOPERSONAL_MASIVO_HISTORIAL"
            With .Parameters
                .Add("@FECHAINICIO", SqlDbType.Date).Value = fechainicio
                .Add("@FECHAFINAL", SqlDbType.Date).Value = fechafinal
            End With

        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetRequerimientosMasivosHistorial " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetRequerimientoMasivosPostulantes(ByVal IDREQUERIMIENTO As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_POSTULATES_MASIVOS_REQUERIMIENTO"
            With .Parameters
                .Add("@IDREQUERIMIENTO", SqlDbType.Int).Value = IDREQUERIMIENTO
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetRequerimientoMasivosPostulantes " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetRequerimientosMasivosProcesados(ByVal fechainicial As Date, ByVal fechafinal As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_REQUERIMIENTOS_MASIVOS_PROCESADOS"
            With .Parameters
                .Add("@FECHAINICIO", SqlDbType.Date).Value = fechainicial
                .Add("@FECHAFINAL", SqlDbType.Date).Value = fechafinal
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetRequerimientosMasivosProcesados " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    'NO MASIVOS
    Public Function GetRequerimientosNoMasivosProcesados(ByVal fechainicio As Date, ByVal fechafinal As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_REQUERIMIENTOS_NOMASIVO_PROCESADOS"
            With .Parameters
                .Add("@FECHAINICIO", SqlDbType.Date).Value = fechainicio
                .Add("@FECHAFINAL", SqlDbType.Date).Value = fechafinal
            End With

        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetRequerimientosNoMasivosProcesados " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
    'Public Function PostulantesNoMasivosProcesadosList(ByVal LISTIDASIGNACIONFAMILIAR As String) As DataTable
    '    Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
    '    Dim cmd As New SqlCommand
    '    Dim dt As New DataTable

    '    With cmd
    '        .Connection = cnx
    '        .CommandType = CommandType.StoredProcedure
    '        .CommandText = "RS_POSTULANTES_NOMASIVOS_LIST_REPORTE"
    '        With .Parameters
    '            .Add("@IDREQUERIMIENTO", SqlDbType.VarChar).Value = LISTIDASIGNACIONFAMILIAR
    '        End With
    '    End With

    '    Try
    '        cnx.Open()
    '        dt.Load(cmd.ExecuteReader)
    '    Catch ex As Exception
    '        Throw
    '    Finally
    '        If cnx.State = ConnectionState.Open Then
    '            cnx.Close()
    '        End If
    '    End Try
    '    Return dt
    'End Function


    Public Function GetRequerimientoNoMasivosPostulantes(ByVal IDREQUERIMIENTO As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_POSTULATES_NOMASIVOS_REQUERIMIENTO"
            With .Parameters
                .Add("@IDREQUERIMIENTO", SqlDbType.Int).Value = IDREQUERIMIENTO
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetRequerimientoNoMasivosPostulantes " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt

    End Function


#End Region



#Region "LIST"

    Public Function GetDistritoList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_UBIGEO_LIST"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetDistritoList " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetDistritoListID(ByVal IDUBIGEO As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_DISTRITO_LIST_ID"
            With .Parameters
                .Add("@IDUBIGEO", SqlDbType.Int).Value = IDUBIGEO
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetDistritoList " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetCargoList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_CARGO_LIST"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetCargoList " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetSexoList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_SEXO_LIST"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetSexoList " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
    Public Function GetMesList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MES_LIST"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetMesList " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetLocalList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_LOCAL_LIST"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetLocalList " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
    Public Function GetLocalListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_LOCAL_LIST_ALL"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetLocalList " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetTipoIdentidadList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_TIPO_IDENTIDAD_LIST"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetTipoIdentidadList " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetTunoPersonalList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_TURNO_PERSONAL_LIST"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetTunoPersonalList " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetEstadoCondicionActualList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_ESTADO_CONDICION_ACTUAL_LIST"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetEstadoCondicionActualList " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetEstadoPostulanteList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_ESTADO_POSTULANTE_LIST"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetEstadoPostulanteList " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

#End Region



#Region "MANTENIMIENTOS"

    Public Function GetFuenteReclutamientoList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_FUENTE_RECLUTAMIENTO_LIST"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetFuenteReclutamientoList " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetObtenerIDFuente(ByVal IDFUENTEDETALLE As Integer) As Integer
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim IdFuente As Integer

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_FUENTE_RECLUTAMIENTO_LIST_IDFUENTEDETALLE"
            With .Parameters
                .Clear()
                .Add("@IDFUENTEDETALLE", SqlDbType.Int).Value = IDFUENTEDETALLE
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
            If dt.Rows.Count > 0 Then
                IdFuente = dt.Rows(0)(0)
            Else
                IdFuente = 0
            End If

        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetObtenerIDFuente " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return IdFuente
    End Function

    Public Function GetObtenerIDConlusion(ByVal IDCONCLUSION As Integer) As Integer
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim IdFuente As Integer

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_CONCLUSION_LIST_IDCONCLUSIONDETALLE"
            With .Parameters
                .Clear()
                .Add("@IDCONCLUSIONDETALLE", SqlDbType.Int).Value = IDCONCLUSION
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
            IdFuente = dt.Rows(0)(0)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetObtenerIDFuente " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return IdFuente
    End Function

    Public Function GetFuenteReclutamientoID(ByVal IDFUENTE As String) As FuenteReclutamientoBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_FUENTE_RECLUTAMIENTO_GETID"
            With .Parameters
                .Clear()
                .Add("@IDFUENTE", SqlDbType.Int).Value = IDFUENTE
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With FuenteReclutamientoBE
                        .IDFUENTE = dr.ReadNullAsNumeric("IDFUENTE")
                        .DESCRIPCION = dr.ReadNullAsEmptyString("DESCRIPCION")
                    End With
                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw New Exception("GetFuenteReclutamientoID" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return FuenteReclutamientoBE
    End Function

    Public Function GetFuenteReclutamientoDetalleListXIdFuente(ByVal IDFUENTE As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_FUENTE_RECLUTAMIENTO_DETALLE_LIST_IDFUENTE"
            With .Parameters
                .Add("@IDFUENTE", SqlDbType.Int).Value = IDFUENTE
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetFuenteReclutamientoDetalleListXIdFuente " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetFuenteReclutamientoDetalleList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_FUENTE_RECLUTAMIENTO_DETALLE_LIST"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetFuenteReclutamientoDetalleList " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetFuenteReclutamientoDetalleID(ByVal IDFUENTEDETALLE As String) As FuenteReclutamientoDetalleBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_FUENTE_RECLUTAMIENTO_DETALLE_GETID"
            With .Parameters
                .Clear()
                .Add("@IDFUENTEDETALLE", SqlDbType.Int).Value = IDFUENTEDETALLE
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With FuenteReclutamientoDetalleBE
                        .IDFUENTEDETALLE = dr.ReadNullAsNumeric("IDFUENTEDETALLE")
                        .DESCRIPCION = dr.ReadNullAsEmptyString("DESCRIPCION")
                    End With
                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw New Exception("GetFuenteReclutamientoDetalleID" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return FuenteReclutamientoDetalleBE
    End Function

    Public Function SaveFuenteReclutamiento(ByVal BE As FuenteReclutamientoBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_FUENTE_RECLUTAMIENTO_GUARDAR"
            With .Parameters
                .Add("@IDFUENTE", SqlDbType.Int).Value = BE.IDFUENTE
                .Add("@DESCRIPCION", SqlDbType.VarChar, 50).Value = BE.DESCRIPCION
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

    Public Function SaveFuenteReclutamientoDetalle(ByVal BE As FuenteReclutamientoDetalleBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_FUENTE_RECLUTAMIENTO_DETALLE_GUARDAR"
            With .Parameters
                .Add("@IDFUENTEDETALLE", SqlDbType.Int).Value = BE.IDFUENTEDETALLE
                .Add("@IDFUENTE", SqlDbType.Int).Value = BE.IDFUENTE
                .Add("@DESCRIPCION", SqlDbType.VarChar, 50).Value = BE.DESCRIPCION
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



    Public Function GetConclusionList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_CONCLUSION_LIST"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetConclusionList " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetConclusionID(ByVal IDCONCLUSION As String) As ConclusionBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_CONCLUSION_GETID"
            With .Parameters
                .Clear()
                .Add("@IDCONCLUSION", SqlDbType.Int).Value = IDCONCLUSION
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With ConclusionBE
                        .IDCONCLUSION = dr.ReadNullAsNumeric("IDCONCLUSION")
                        .DESCRIPCION = dr.ReadNullAsEmptyString("DESCRIPCION")
                    End With
                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw New Exception("GetConclusionID" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return ConclusionBE
    End Function

    Public Function GetConclusionDetalleListXIdConclusion(ByVal IDCONCLUSION As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_CONCLUSION_DETALLE_LIST_IDCONCLUSION"
            With .Parameters
                .Add("@IDCONCLUSION", SqlDbType.Int).Value = IDCONCLUSION
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetConclusionDetalleListXIdConclusion " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetConclusionDetalleList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_CONCLUSION_DETALLE_LIST"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetConclusionDetalleList " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetConclusionDetalleID(ByVal IDCONCLUSIONDETALLE As String) As ConclusionDetalleBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_CONCLUSION_DETALLE_GETID"
            With .Parameters
                .Clear()
                .Add("@IDCONCLUSIONDETALLE", SqlDbType.Int).Value = IDCONCLUSIONDETALLE
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With ConclusionDetalleBE
                        .IDCONCLUSIONDETALLE = dr.ReadNullAsNumeric("IDCONCLUSIONDETALLE")
                        .DESCRIPCION = dr.ReadNullAsEmptyString("DESCRIPCION")
                    End With
                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw New Exception("GetConclusionDetalleID" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return ConclusionDetalleBE
    End Function

    Public Function SaveConclusion(ByVal BE As ConclusionBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_CONCLUSION_GUARDAR"
            With .Parameters
                .Add("@IDCONCLUSION", SqlDbType.Int).Value = BE.IDCONCLUSION
                .Add("@DESCRIPCION", SqlDbType.VarChar, 50).Value = BE.DESCRIPCION
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

    Public Function SaveConclusionDetalle(ByVal BE As ConclusionDetalleBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_CONCLUSION_DETALLE_GUARDAR"
            With .Parameters
                .Add("@IDCONCLUSIONDETALLE", SqlDbType.Int).Value = BE.IDCONCLUSIONDETALLE
                .Add("@IDCONCLUSION", SqlDbType.Int).Value = BE.IDCONCLUSION
                .Add("@DESCRIPCION", SqlDbType.VarChar, 50).Value = BE.DESCRIPCION
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



    Public Function GetListadoEstadoPostulante() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_LISTADO_ESTADO_POSTULANTE"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetListadoEstadoPostulante " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetEstadoPostulanteID(ByVal IDESTADO As String) As EstadoPostulanteBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_ESTADO_POSTULANTE_GETID"
            With .Parameters
                .Clear()
                .Add("@IDESTADO", SqlDbType.Int).Value = IDESTADO
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With EstadoPostulanteBE
                        .IDESTADO = dr.ReadNullAsNumeric("IDESTADO")
                        .DESCRIPCION = dr.ReadNullAsEmptyString("DESCRIPCION")
                        .ACTIVO = dr.ReadNullAsBoolean("ACTIVO")
                    End With
                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw New Exception("GetEstadoPostulanteID" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return EstadoPostulanteBE
    End Function

    Public Function SaveEstadoPostulante(ByVal BE As EstadoPostulanteBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_ESTADO_POSTULANTE_GUARDAR"
            With .Parameters
                .Add("@IDESTADO", SqlDbType.Int).Value = BE.IDESTADO
                .Add("@DESCRIPCION", SqlDbType.VarChar, 50).Value = BE.DESCRIPCION
                .Add("@ACTIVO", SqlDbType.Bit).Value = BE.ACTIVO
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



    Public Function GetEstadoCrediticioList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_ESTADO_CREDITICIO_LIST"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetEstadoCrediticioList " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetEstadoPsicologicoList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_ESTADO_PSICOLOGICO_LIST"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetEstadoPsicologicoList " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetEstadoAssesmentList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_ESTADO_ASSESMENT_LIST"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetEstadoAssesmentList " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetEntrevistaSelecciontList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_ESTADO_ENTREVISTA_SELECCION_LIST"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetEntrevistaSelecciontList " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetEntrevistaPreviaList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_ESTADO_ENTREVISTA_PREVIA_LIST"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetEntrevistaPreviaList " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetEntrevistaAreaFinalList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_ESTADO_ENTREVISTA_AREA_LIST"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetEntrevistaAreaFinalList " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function


    Public Function GetListadoEstadoCondicionActual() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_LISTADO_ESTADO_CONDICION_ACTUAL"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetListadoEstadoCondicionActual " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetEstadoCondicionActualID(ByVal IDCONDICIONACTUAL As String) As EstadoCondicionActualBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_ESTADO_CONDICION_ACTUAL_GETID"
            With .Parameters
                .Clear()
                .Add("@IDCONDICIONACTUAL", SqlDbType.Int).Value = IDCONDICIONACTUAL
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With EstadoCondicionActualBE
                        .IDESTADOCONDICIONACTUAL = dr.ReadNullAsNumeric("IDCONDICIONACTUAL")
                        .DESCRIPCION = dr.ReadNullAsEmptyString("DESCRIPCION")
                        .ACTIVO = dr.ReadNullAsBoolean("ACTIVO")
                    End With
                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw New Exception("GetEstadoCondicionActualID" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return EstadoCondicionActualBE
    End Function

    Public Function SaveEstadoCondicionActual(ByVal BE As EstadoCondicionActualBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_ESTADO_CONDICION_ACTUAL_GUARDAR"
            With .Parameters
                .Add("@IDCONDICIONACUAL", SqlDbType.Int).Value = BE.IDESTADOCONDICIONACTUAL
                .Add("@DESCRIPCION", SqlDbType.VarChar, 50).Value = BE.DESCRIPCION
                .Add("@ACTIVO", SqlDbType.Bit).Value = BE.ACTIVO
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


#End Region



#Region "CORREO"

    Public Function GetDatosCorreoEnvio() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_DATOS_CORREO_ENVIO"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetDatosCorreoEnvio " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt

    End Function

    Public Function GetDatosCorreo(ByVal IDPOSTULANTEMASIVO As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_DATOS_CORREO_POSTULANTES_MASIVOS"
            With .Parameters
                .Add("@IDPOSTULANTEMASIVO", SqlDbType.Int).Value = IDPOSTULANTEMASIVO
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetDatosCorreo " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt

    End Function

    Public Function GetDatosCorreoSupervisor(ByVal IDLOCAL As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_DATOS_CORREO_SUPERVISOR"
            With .Parameters
                .Add("@IDLOCAL", SqlDbType.Int).Value = IDLOCAL
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetDatosCorreoSupervisor " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt

    End Function

    Public Function GetDatosCorreoJefeZonal(ByVal IDLOCAL As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_DATOS_CORREO_JEFEZONAL"
            With .Parameters
                .Add("@IDLOCAL", SqlDbType.Int).Value = IDLOCAL
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.GetDatosCorreoJefeZonal " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt

    End Function

#End Region



#Region "REPORTES"

    Public Function ReporteCanalesReclutamiento(ByVal year As String) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_REPORTE_CANALES_RECLUTAMIENTO"
            With .Parameters
                .Add("@year", SqlDbType.NVarChar, 4).Value = year
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.Reporte " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function ReporteCanalesReclutamientoChart(ByVal year As String) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_REPORTE_CANALES_RECLUTAMIENTO_CHART"
            With .Parameters
                .Add("@year", SqlDbType.NVarChar, 4).Value = year
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.Reporte " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function ReporteRequerimientosMasivos(ByVal fechainicial As Date, ByVal fechafinal As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_REPORTE_REQUERIMIENTOS_MASIVOS"
            With .Parameters
                .Add("@fechainicial", SqlDbType.DateTime).Value = fechainicial
                .Add("@fechafinal", SqlDbType.DateTime).Value = fechafinal
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.Reporte " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
    Public Function ReporteRequerimientosPersonal(ByVal fechainicial As Date, ByVal fechafinal As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_REPORTE_REQUERIMIENTOS_MASIVO_NOMASIVOS"
            With .Parameters
                .Add("@FECHAINICIO", SqlDbType.DateTime).Value = fechainicial
                .Add("@FECHAFIN", SqlDbType.DateTime).Value = fechafinal
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.Reporte " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function ReportePuestosCanalReclutamiento(ByVal fechainicial As DateTime, ByVal fechafinal As DateTime) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_REPORTE_PUESTOS_CANAL_RECLUTAMIENTO"
            With .Parameters
                .Add("@fechainicial", SqlDbType.DateTime).Value = fechainicial
                .Add("@fechafinal", SqlDbType.DateTime).Value = fechafinal
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.Reporte " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function ReportePuestosCanalReclutamientoChart(ByVal fechainicial As DateTime, ByVal fechafinal As DateTime) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_REPORTE_PUESTOS_CANAL_RECLUTAMIENTO_CHART"
            With .Parameters
                .Add("@fechainicial", SqlDbType.DateTime).Value = fechainicial
                .Add("@fechafinal", SqlDbType.DateTime).Value = fechafinal
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.Reporte " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function ReporteConclusionPostulanteCanalReclutamiento(ByVal fechainicial As DateTime, ByVal fechafinal As DateTime) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_REPORTE_CONCLUSION_POSTULANTE_CANAL_RECLUTAMIENTO"
            With .Parameters
                .Add("@fechainicial", SqlDbType.DateTime).Value = fechainicial
                .Add("@fechafinal", SqlDbType.DateTime).Value = fechafinal
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.Reporte " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function ReporteConclusionPostulanteCanalReclutamientoChart(ByVal fechainicial As DateTime, ByVal fechafinal As DateTime) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_REPORTE_CONCLUSION_POSTULANTE_CANAL_RECLUTAMIENTO_CHART"
            With .Parameters
                .Add("@fechainicial", SqlDbType.DateTime).Value = fechainicial
                .Add("@fechafinal", SqlDbType.DateTime).Value = fechafinal
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.Reporte " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function ReporteListadoPostulantesMasivos(ByVal fechainicio As DateTime, ByVal fechafinal As DateTime) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_LISTADO_REQUERIMIENTO_PERSONAL_MASIVO"
            With .Parameters
                .Add("@FECHAINICIO", SqlDbType.Date).Value = fechainicio
                .Add("@FECHAFINAL", SqlDbType.Date).Value = fechafinal
            End With

        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.ReporteListadoPostulantesMasivos " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function ReporteListadoPostulantesNoMasivos(ByVal fechainicio As DateTime, ByVal fechafinal As DateTime) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_LISTADO_REQUERIMIENTO_PERSONAL_NOMASIVO"
            With .Parameters
                .Add("@FECHAINICIO", SqlDbType.Date).Value = fechainicio
                .Add("@FECHAFINAL", SqlDbType.Date).Value = fechafinal
            End With

        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("BDCentralDAO.ReporteListadoPostulantesNoMasivos " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

#End Region



#Region "REGISTRO EMPLEADO"
    Public Function ConsultaExistenciEmpleado(ByVal IDPOSTULANTEMASIVO As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_CONSULTA_EMPLEADO_EXISTE"
            With .Parameters
                .Add("@IDPOSTULANTE", SqlDbType.Int).Value = IDPOSTULANTEMASIVO
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

    Public Function InsertEmpleadoPostulanteMasivo(ByVal IDPOSTULANTEMASIVO As Integer, ByVal IDREQUERIMIENTO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "MC_INSERT_EMPLEADO_MASIVO"
            With .Parameters
                .Add("@IDPOSTULANTE", SqlDbType.Int).Value = IDPOSTULANTEMASIVO
                .Add("@IDREQUERIMIENTO", SqlDbType.Int).Value = IDREQUERIMIENTO
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
    Public Function UpdateEmpleadoPostulanteReingresoMasivo(ByVal IDPOSTULANTEMASIVO As Integer, ByVal IDREQUERIMIENTO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "RS_REINGRESO_POSTULANTEAEMPLEADO"
            With .Parameters
                .Add("@IDPOSTULANTE", SqlDbType.Int).Value = IDPOSTULANTEMASIVO
                .Add("@IDREQUERIMIENTO", SqlDbType.Int).Value = IDREQUERIMIENTO
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

    Public Function InsertEmpleadoPostulanteNoMasivo(ByVal IDPOSTULANTEMASIVO As Integer, ByVal IDREQUERIMIENTO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "MC_INSERT_EMPLEADO_NO_MASIVO"
            With .Parameters
                .Add("@IDPOSTULANTE", SqlDbType.Int).Value = IDPOSTULANTEMASIVO
                .Add("@IDREQUERIMIENTO", SqlDbType.Int).Value = IDREQUERIMIENTO
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

#End Region
    Shared Function AccesoLogIns(IDSistema As Int32, IDUsuario As Int32, DetalleLog As String, NombreLog As String) As Int32
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Int32 = 0
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_ACCESO_LOG_INS"
            With .Parameters
                .Add("@IDSistema", SqlDbType.Int).Value = IDSistema ' id del sistema al que se ha ingresado
                .Add("@IDUsuario", SqlDbType.Int).Value = IDUsuario ' id del usuario que accedió
                .Add("@Detalle", SqlDbType.NVarChar, 4000).Value = DetalleLog.ToUpper ' detalles  de la acción: impresión,exportación,  rango de fechas, filtros, etc.
                .Add("@Accion", SqlDbType.NVarChar, 4000).Value = NombreLog.ToUpper 'formulario o reporte al que se esta ingresando
            End With
        End With
        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
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

#Region "CORREOS"

    Public Function InsertEnvioCorreo(ByVal Email As String, ByVal Asunto As String, ByVal Mensaje As String) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_ENVIO_CORREO_INSERT"

            With .Parameters
                .Add("@EMAIL", SqlDbType.NVarChar, 4000).Value = Email
                .Add("@ASUNTO", SqlDbType.NVarChar, 800).Value = Asunto
                .Add("@MENSAJE", SqlDbType.NVarChar, 4000).Value = Mensaje
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
    End Function ''OK

#End Region

End Class
