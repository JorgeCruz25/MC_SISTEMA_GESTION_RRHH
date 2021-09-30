Imports System.Data.SqlClient

Public Class MemorandumDAO
    Dim MemorandumBE As New MemorandumBE
    Public IdMemorandum As Integer
    Public IdEmpleado As Integer
    Public FirmaDocumento As Boolean
    Public EstadoNotificado As Boolean
    Public EstadoEnvioLegal As Boolean
    Public IdDescargoArchivo As Integer
    Public EstadoValidadoRrhh As Boolean
    Public EstadoEnvioLegalRedaccion As Boolean
    Public EstadoValidadoLegalRedaccion As Boolean
    Public EstadoValidadoLegal As Boolean
    Public Function GetMemorandunAntecedentesTipoList(ByVal idmemorandum As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUM_ANTECEDENTES_TIPO"
            .CommandTimeout = 0
            With .Parameters
                .Add("@IDMEMORANDUM", SqlDbType.Int).Value = idmemorandum
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
    End Function ''OK

    Public Function GetListarFaltasMemorandum(ByVal idmemorandum As Integer) As DataTable 'As DataTable '(ByVal estadovalidadorrhh As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_FALTAS_LIST_ALL_MEMO"
            .CommandTimeout = 0

            'COMENTAR ESTO HASTA QUE SE EMPIECE EL NUEVO RIT 16/09/2019
            '--------------INICIO--------------
            With .Parameters
                '.Add("@IDMEMORANDUM", SqlDbType.Int).Value = estadovalidadorrhh
                .Add("@IDMEMORANDUM", SqlDbType.Int).Value = idmemorandum
            End With
            '--------------FIN-----------------

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
    Public Function GetListarSancionMemorandum(ByVal IDMEMORANDUM As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SANCIONTIPO_LIST"
            .CommandTimeout = 0
            With .Parameters
                .Add("@IDMEMORANDUM", SqlDbType.Int).Value = IDMEMORANDUM
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
    Public Function GetAllMemorandums() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUM_LIST_PREVIEW_ALL"
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
    Public Function GetAllMemorandumsHistorial(ByVal FechaInicial As Date, ByVal FechaFinal As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUM_LIST_PREVIEW_REVISADO_ALL"
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
    End Function 'ok
    Public Function GetMemorandumByID(ByVal IDMEMORANDUM As Int32) As MemorandumBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUM_GET_BY_ID"
            With .Parameters
                .Add("@IDMEMORANDUM", SqlDbType.Int).Value = IDMEMORANDUM
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With MemorandumBE
                        .IdMemorandum = dr.ReadNullAsNumeric("IDMEMORANDUM")
                        .NumeroInforme = dr.ReadNullAsEmptyString("NUMEROINFORME")
                        .IdEmpleado = dr.ReadNullAsNumeric("IDEMPLEADO")
                        .Nombres = dr.ReadNullAsEmptyString("NOMBRES")
                        .ApellidoPaterno = dr.ReadNullAsEmptyString("APELLIDOPATERNO")
                        .ApellidoMaterno = dr.ReadNullAsEmptyString("APELLIDOMATERNO")
                        .IdLocal = dr.ReadNullAsNumeric("IDLOCAL")
                        .Cargo = dr.ReadNullAsEmptyString("EMPLEADOCARGO")
                        .DNI = dr.ReadNullAsEmptyString("EMPLEADODNI")
                        .Fecha = dr.ReadNullAsEmptyDate("FECHA")
                        .RazonSocial = dr.ReadNullAsEmptyString("RAZONSOCIAL")
                        .RazonComercial = dr.ReadNullAsEmptyString("RAZONCOMERCIAL")
                        .IdEmpleado = dr.ReadNullAsNumeric("IDEMPLEADO")
                        .Solicitante = dr.ReadNullAsEmptyString("SOLICITANTE")
                        .DescuentoRemunerativo = dr.ReadNullAsBoolean("DESCUENTOREMUNERATIVO")
                        .Descripcion = dr.ReadNullAsEmptyString("DESCRIPCION")
                        .CodigoLocal = dr.ReadNullAsEmptyString("CODIGOLOCAL")
                        .FechaEnvioNotarial = dr.ReadNullAsEmptyDate("FECHAENVIONOTARIA")
                        .MontoDescuento = dr.ReadNullAsNumeric("MONTODESCUENTO")
                        .DescripcionLegal = dr.ReadNullAsEmptyString("DESCRIPCIONLEGAL")
                        .DiasSancion = dr.ReadNullAsEmptyString("DIASANCION")
                        .CorreccionRedaccion = dr.ReadNullAsEmptyString("CORRECCIONREDACCIONRRHH")
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
        Return MemorandumBE

    End Function 'OK
    Public Function GetMemorandumSancionEmpleado(ByVal IDEMPLEADO As Integer, ByVal IDFALTA As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SANCION_EMPLEADO_MEMO"
            .CommandTimeout = 0
            With .Parameters
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IDEMPLEADO
                .Add("@IDFALTA", SqlDbType.Int).Value = IDFALTA
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
    Public Function AccionMemorandumRRHH(BE As MemorandumBE, ByVal ACCION As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            ' .CommandText = "MCRH_MEMORANDUM_DETALLE_INS"
            .CommandText = "MCRH_ACCION_MEMORANDUM_EVALUACION"
            With .Parameters
                .Add("@IDMEMORANDUM", SqlDbType.Int).Value = BE.IdMemorandum
                .Add("@IDFALTA", SqlDbType.Int).Value = BE.IdFalta
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = BE.IdEmpleado
                .Add("@PESOSANCION", SqlDbType.Int).Value = BE.PesoSancion
                .Add("@IDLOCAL", SqlDbType.Float).Value = BE.IdLocal
                .Add("@DESCUENTOREMUNERATIVO", SqlDbType.Bit).Value = BE.DescuentoRemunerativo
                .Add("@MONTODESCUENTO", SqlDbType.Float).Value = BE.MontoDescuento
                .Add("@DESCRIPCIONLEGAL", SqlDbType.NVarChar).Value = BE.DescripcionLegal
                .Add("@DIASANCION", SqlDbType.NVarChar).Value = BE.DiasSancion
                .Add("@ACCION", SqlDbType.Int).Value = ACCION
                .Add("@CORRECCIONREDACCIONRRHH", SqlDbType.NVarChar).Value = BE.CorreccionRedaccion
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

    End Function 'ok
    Public Function GetAllFaltaSancionIDMemorandum(ByVal IDMEMORANDUM As Int32) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUM_GET_BY_FALTA_IDMEMORANDUM"
            With .Parameters
                .Add("@IDMEMORANDUM", SqlDbType.Int).Value = IDMEMORANDUM
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
    Public Function ListaMemorandumArchivos(ByVal IDMEMORANDUM As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUM_LISTA_ARCHIVO"
            .CommandTimeout = 0
            With .Parameters
                .Add("@IDMEMORANDUM", SqlDbType.Int).Value = IDMEMORANDUM
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
    Public Function EliminarMemorandumArchivo(ByVal IDARCHIVOMEMORANDUM As Integer, ByVal IDMEMORANDUN As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUM_ELIMINA_ARCHIVO"
            .CommandTimeout = 0
            With .Parameters
                .Add("@IDARCHIVOMEMORANDUM", SqlDbType.Int).Value = IDARCHIVOMEMORANDUM
                .Add("@IDMEMORANDUM", SqlDbType.Int).Value = IDMEMORANDUN
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
    Public Function AprobarMemorandumRRHH(BE As MemorandumBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUM_REV"
            With .Parameters
                .Add("@IDMEMORANDUM", SqlDbType.Int).Value = BE.IdMemorandum
                .Add("@PESOSANCION", SqlDbType.Int).Value = BE.PesoSancion
                .Add("@IDFALTA", SqlDbType.Int).Value = BE.IdFalta
                .Add("@IDUSUARIO", SqlDbType.Int).Value = BE.IdUsuario
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

    End Function 'ok

    Public Function GetMemorandumIDCorreo(ByVal IDMEMORANDUM As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUM_ID_CORREO"
            .CommandTimeout = 0
            With .Parameters
                .Add("@IDMEMORANDUM", SqlDbType.Int).Value = IDMEMORANDUM
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
    End Function ''OK
    Public Function InsertaMemorandumArchivo(ByVal id As Integer, ByVal idlocal As Integer, ByVal nombrearchivo As String, ByVal ruta As String, ByVal link As String) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUM_INSERTA_ARCHIVO"
            With .Parameters
                .Add("@IDMEMORANDUM", SqlDbType.Int).Value = id
                .Add("@IDLOCAL", SqlDbType.Int).Value = idlocal
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

    End Function 'ok
    Public Function InsertaMemorandumSustentoInsertarArchivo(ByVal id As Integer, ByVal nombrearchivo As String, ByVal ruta As String, ByVal link As String) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUM_DESCARGO_ARCHIVO_INS"
            With .Parameters
                .Add("@IDMEMORANDUM", SqlDbType.Int).Value = id
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

    End Function 'OK
    Public Function AnularMemorandumRRHH(ByVal IDUSUARIO As Int32, BE As MemorandumBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUM_ANULAR_RRHH"
            With .Parameters
                .Add("@IDMEMORANDUM", SqlDbType.Int).Value = BE.IdMemorandum
                .Add("@IDUSUARIO", SqlDbType.Int).Value = IDUSUARIO
                .Add("@OBSERVACIONANULADO", SqlDbType.NVarChar).Value = BE.ObservacionAnulado
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
    Public Function GetMemorandumDescargoArchivo(ByVal IDMEMORANDUM As Int32) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUM_DESCARGO_ARCHIVO_LIST"
            With .Parameters
                .Add("@IDMEMORANDUM", SqlDbType.Int).Value = IDMEMORANDUM
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
    Public Function GetMemorandumDescargo(ByVal IDDESCARGO As Int32) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUM_DESCARGO_ARCHIVO"
            With .Parameters
                .Add("@IDDESCARGOARCHIVO", SqlDbType.Int).Value = IDDESCARGO
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
    Public Function GetMemorandumDescargoAll(ByVal IDMEMORANDUM As Int32) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUM_DESCARGO_ARCHIVO_ALL"
            With .Parameters
                .Add("@IDMEMORANDUM", SqlDbType.Int).Value = IDMEMORANDUM
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
    Public Function EliminarDescargoMemorandumArchivo(ByVal IDDESCARGO As Int32) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUM_ELIMINAR_ARCHIVO_DESCARGO"
            With .Parameters
                .Add("@IDDESCARGOARCHIVO", SqlDbType.Int).Value = IDDESCARGO
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
    Public Function FirmaDocumentoMemorandum(ByVal IDMEMORANDUM As Int32, ByVal FIRMADOCUMENTO As Boolean) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUM_FIRMA_DOCUMENTO"
            With .Parameters
                .Add("@IDMEMORANDUM", SqlDbType.Int).Value = IDMEMORANDUM
                .Add("@FIRMADOCUMENTO", SqlDbType.Bit).Value = FIRMADOCUMENTO
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
    'Public Function GetListaMemorandum(ByVal IDMEMORANDUM As Integer) As DataTable
    '    Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
    '    Dim cmd As New SqlCommand
    '    Dim dt As New DataTable
    '    With cmd
    '        .Connection = cnx
    '        .CommandType = CommandType.StoredProcedure
    '        .CommandText = "MCRH_MEMORANDUM_ID"
    '        .CommandTimeout = 0
    '        With .Parameters
    '            .Add("@IDMEMORANDUM", SqlDbType.Int).Value = IDMEMORANDUM
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

    'PENDIENTE 070219
    Public Function GetListarMemorandumEmpleado(ByVal IDEMPLEADO As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_HISTORIAL_MEMORANDUN_GET_IDEMPLEADO"
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
    End Function 'ok

    'Public Function EnvioMemorandumLegal(BE As MemorandumBE, ByVal ACCION As Integer) As Boolean
    '    Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
    '    Dim cmd As New SqlCommand
    '    Dim Result As Boolean = False
    '    With cmd
    '        .Connection = cnx
    '        .CommandType = CommandType.StoredProcedure
    '        .CommandText = "MCRH_MEMORANDUM_ENVIO_LEGAL"
    '        With .Parameters
    '            .Add("@IDMEMORANDUM", SqlDbType.Int).Value = BE.IdMemorandum
    '            .Add("@IDFALTA", SqlDbType.Int).Value = BE.IdFalta
    '            .Add("@IDEMPLEADO", SqlDbType.Int).Value = BE.IdEmpleado
    '            .Add("@PESOSANCION", SqlDbType.Int).Value = BE.PesoSancion
    '            .Add("@IDLOCAL", SqlDbType.Float).Value = BE.IdLocal
    '            .Add("@DESCUENTOREMUNERATIVO", SqlDbType.Bit).Value = BE.DescuentoRemunerativo
    '            .Add("@MONTODESCUENTO", SqlDbType.Float).Value = BE.MontoDescuento
    '            .Add("@DESCRIPCIONLEGAL", SqlDbType.NVarChar).Value = BE.DescripcionLegal
    '            .Add("@DIASANCION", SqlDbType.NVarChar).Value = BE.DiasSancion
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
    'End Function 'OK
    Public Function GetAllMemorandumsLegal() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUM_LEGAL_LIST_ALL"
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
    Public Function ListaMemorandumGetBy(ByVal IDMEMORANDUM As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUM_GET_BY_ID"
            .CommandTimeout = 0
            With .Parameters
                .Add("@IDMEMORANDUM", SqlDbType.Int).Value = IDMEMORANDUM
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
    Public Function MemorandumlLegalEvalListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUNLEGAL_EVAL_LIST_ALL"
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
    End Function 'ok
    Public Function MemorandumLegalValidarLegal(ByVal IDMEMORANDUM As Int32) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUM_APROBACION_LEGAL"
            With .Parameters
                .Add("@IDMEMORANDUM", SqlDbType.Int).Value = IDMEMORANDUM
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
    End Function 'ok
    Public Function NotificarMemorandumLegal(ByVal IDMEMORANDUM As Int32, ByVal FECHAENVIONOTARIA As Date) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUM_NOTIFICAR"
            With .Parameters
                .Add("@IDMEMORANDUM", SqlDbType.Int).Value = IDMEMORANDUM
                .Add("@FECHAENVIONOTARIA", SqlDbType.Date).Value = FECHAENVIONOTARIA
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
    End Function 'ok
    Public Function GetAllMemorandumsLegalHistorial(ByVal FechaInicial As Date, ByVal FechaFinal As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUM_LIST_PREVIEW_REVISADO_LEGAL_ALL"
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
    End Function 'ok
    Public Function MemorandumFechaEnvioNotaria(ByVal IDMEMORANDUM As Int32, ByVal FECHAENVIONOTARIA As Date) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUM_FECHA_ENVIO_NOTARIA"
            With .Parameters
                .Add("@IDMEMORANDUM", SqlDbType.Int).Value = IDMEMORANDUM
                .Add("@FECHAENVIONOTARIA", SqlDbType.Date).Value = FECHAENVIONOTARIA
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
    End Function 'ok
    Public Function InsertaMemorandumFormatoLegal(ByVal id As Integer, ByVal nombrearchivo As String, ByVal ruta As String, ByVal link As String) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUM_INSERTA_FORMATO_LEGAL_ARCHIVO"
            With .Parameters
                .Add("@IDMEMORANDUM", SqlDbType.Int).Value = id
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

    End Function 'ok
    Public Function ListMemorandumFormatoLegalID(ByVal IDMEMORANDUM As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUM_LIST_FORMATO_LEGAL_ARCHIVO_GET_ID"
            With .Parameters
                .Clear()
                .Add("@IDMEMORANDUM", SqlDbType.Int).Value = IDMEMORANDUM
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
    Public Function EliminarFormatoMemorandumArchivo(ByVal IDMEMORANDUM As Int32) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUM_ELIMINAR_FORMATO_LEGAL_ARCHIVO"
            With .Parameters
                .Add("@IDMEMORANDUM", SqlDbType.Int).Value = IDMEMORANDUM
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
    End Function 'ok

    Public Function AccionRedaccionLegal(BE As MemorandumBE, ByVal ACCION As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            '  .CommandText = "MCRH_MEMORANDUM_VALIDA_REDACCION"
            .CommandText = "MCRH_MEMORANDUM_REDACCION_ACCION"
            With .Parameters
                .Add("@IDMEMORANDUM", SqlDbType.Int).Value = BE.IdMemorandum
                .Add("@DESCRIPCIONLEGAL", SqlDbType.NVarChar).Value = BE.DescripcionLegal
                .Add("@IDFALTA", SqlDbType.Int).Value = BE.IdFalta
                .Add("@IDSANCION", SqlDbType.Int).Value = BE.PesoSancion
                .Add("@CORRECCIONREDACCIONRRHH", SqlDbType.NVarChar).Value = BE.CorreccionRedaccion
                .Add("@ACCION", SqlDbType.Int).Value = ACCION
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
    End Function 'ok

    Public Function RetornarMemorandunRRHH(ByVal IDMEMORANDUM As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MEMORANDUM_RETORNAR_RRHH"
            With .Parameters
                .Add("@IDMEMORANDUM", SqlDbType.Int).Value = IDMEMORANDUM
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
    End Function 'ok
    Public Function ExonerarMemorandumRRHH(ByVal IDMEMORANDUM As Integer, ByVal DESCRIPCION As String, ByVal IDUSUARIO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_MEMORANDUM_EXONERAR_RRHH]"
            With .Parameters
                .Add("@IDMEMORANDUM", SqlDbType.Int).Value = IDMEMORANDUM
                .Add("@DESCRIPCION", SqlDbType.NVarChar).Value = DESCRIPCION
                .Add("@IDUSUARIO", SqlDbType.NVarChar).Value = IDUSUARIO
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
    End Function 'ok

End Class
