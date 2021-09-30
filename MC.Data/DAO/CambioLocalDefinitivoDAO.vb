
Imports System.Data.SqlClient

Public Class CambioLocalDefinitivoDAO
    Dim CambioLocalDefinitivoBE As New CambioLocalDefinitivoBE
    Public IdCambioDefinitivo As Integer
    Public IdLocal As Integer
    Public IdEmpleado As Integer
    Public FormatoEnvioCorreoSitio As Integer
    'Public EstadoActualEmpleado As Integer 'activo o cesado
    Public Function CambioDefinitivoLocalListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_FORMATOCAMBIO_LIST_PREVIEW_ALL]"
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
    Public Function GetCambioDefinitivoByID(ByVal IDCAMBIODEFINITIVO As Int32) As CambioLocalDefinitivoBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_FORMATOCAMBIO_GET_BY_ID]"
            With .Parameters
                .Add("@IDFORMATOCAMBIO", SqlDbType.Int).Value = IDCAMBIODEFINITIVO
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With CambioLocalDefinitivoBE
                        .IDFORMATOCAMBIO = dr.ReadNullAsNumeric("IDFORMATOCAMBIO")
                        .NUMEROFORMATOCAMBIO = dr.ReadNullAsEmptyString("NUMEROFORMATOCAMBIO")
                        .RAZONCOMERCIAL = dr.ReadNullAsEmptyString("RAZONCOMERCIAL")
                        .SOLICITANTENOMBRE = dr.ReadNullAsEmptyString("SOLICITANTENOMBRE")
                        .EMPLEADONOMBRE = dr.ReadNullAsEmptyString("EMPLEADONOMBRE")
                        .IDEMPLEADOCARGO = dr.ReadNullAsNumeric("IDEMPLEADOCARGO")
                        .EMPLEADOCARGO = dr.ReadNullAsEmptyString("EMPLEADOCARGO")
                        .EMPLEADODNI = dr.ReadNullAsEmptyString("EMPLEADODNI")
                        .RAZONCOMERCIAL = dr.ReadNullAsEmptyString("RAZONCOMERCIAL")
                        .IDNUEVOLOCAL = dr.ReadNullAsNumeric("IDNUEVOLOCAL")
                        .NUEVOLOCAL = dr.ReadNullAsEmptyString("NUEVOLOCAL")
                        .NUEVOTIPOCONTRATO = dr.ReadNullAsEmptyString("NUEVOTIPOCONTRATO")
                        .FECHACAMBIO = dr.ReadNullAsEmptyDate("FECHACAMBIO")
                        .FECHAFIN = dr.ReadNullAsEmptyString("FECHAFIN")
                        .FECHAINGRESO = dr.ReadNullAsEmptyString("FECHAINGRESO")
                        .HORAINGRESO = dr.ReadNullAsEmptyString("HORAINGRESO")
                        .HORAFIN = dr.ReadNullAsEmptyString("HORAFIN")
                        .IDNUEVOCARGO = dr.ReadNullAsNumeric("IDNUEVOCARGO")
                        .IDNUEVOTIPOCONTRATO = dr.ReadNullAsEmptyString("IDNUEVOTIPOCONTRATO")
                        .TIPOCONTRATOACTUAL = dr.ReadNullAsEmptyString("EMPLEADOTIPOCONTRATO")
                        .NUEVOCARGO = dr.ReadNullAsEmptyString("NUEVOCARGO")
                        .IDEMPLEADO = dr.ReadNullAsNumeric("IDEMPLEADO")
                        .CODIGOUNICO = dr.ReadNullAsEmptyString("CODIGOUNICO")
                        .IDLOCAL = dr.ReadNullAsNumeric("IDLOCAL")
                        .IDORGANIGRAMAORIGEN = dr.ReadNullAsNumeric("IDORGANIGRAMA")
                        .IDORGANIGRAMADESTINO = dr.ReadNullAsNumeric("IDORGANIGRAMADESTINO")
                        .IDTIPODOCUMENTOIDENTIDAD = dr.ReadNullAsNumeric("IDTIPODOCUMENTOIDENTIDAD")
                        .IDDISTRITO = dr.ReadNullAsNumeric("IDUBIGEO")
                        .IDESTADOEMPLEADO = dr.ReadNullAsNumeric("IDESTADO")
                        .TIPOCAMBIODEFINITIVO = dr.ReadNullAsEmptyString("TIPOCAMBIODEFINITIVO")
                        .IDEMPLEADOTIPOCONTRATO = dr.ReadNullAsEmptyString("IDEMPLEADOTIPOCONTRATO")
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
        Return CambioLocalDefinitivoBE

    End Function 'OK
    Public Function ListarSolitudesRenunciasCambiosDefinitivos(ByVal IDEMPLEADO As Integer) As DataTable

        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_RENUNCIA_LIST_PROCESAR_CAMBIODEFINITIVO]"
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


    Public Function GetListarCargosIDLocal(ByVal IDLOCAL As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_LIST_ALL_CARGOS_IDLOCAL]"
            With .Parameters
                .Add("@IDLOCAL", SqlDbType.Int).Value = IDLOCAL
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

    Public Function UpdateCambioDefinitivo(BE As CambioLocalDefinitivoBE, ByVal FECHAINGRESO As String, ByVal FECHAFINAL As String, ByVal HORAINGRESO As String, ByVal HORAFIN As String) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_FORMATOCAMBIO_FECHAINGRESO]"
            With .Parameters
                .Add("@IDFORMATOCAMBIO", SqlDbType.Int).Value = BE.IDFORMATOCAMBIO
                .Add("@FECHAINGRESO", SqlDbType.VarChar).Value = FECHAINGRESO
                .Add("@FECHAFINAL", SqlDbType.VarChar).Value = FECHAFINAL
                .Add("@HORAINGRESO", SqlDbType.VarChar).Value = HORAINGRESO
                .Add("@HORAFINAL", SqlDbType.VarChar).Value = HORAFIN
                .Add("@IDNUEVOCARGO", SqlDbType.Int).Value = BE.IDNUEVOCARGO
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
    Public Function AprobarCambioCargoDefinitivo(ByVal IDCAMBIODEFINITITO As Integer, ByVal IDUSUARIO As Integer, BE As EmpleadoMovimientoBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAMBIO_CARGO_DEFINITIVO"
            With .Parameters
                .Add("@IDFORMATOCAMBIO", SqlDbType.Int).Value = IDCAMBIODEFINITITO
                .Add("@IDUSUARIO", SqlDbType.Int).Value = IDUSUARIO
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = BE.IDEMPLEADO
                .Add("@IDORGANIGRAMA", SqlDbType.Int).Value = BE.IDORGANIGRAMA
                .Add("@IDNUEVOCARGO", SqlDbType.Int).Value = BE.IDCARGO
                .Add("@FECHAEFECTIVAMOVIMIENTO", SqlDbType.Date).Value = BE.FECHAEFECTIVAMOVIMIENTO
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
    Public Function AprobarCambioDefinitivo(ByVal IDCAMBIODEFINITITO As Integer, ByVal NUMEROCONTRATO As String, ByVal IDUSUARIO As Integer, BE As EmpleadoBE, ByVal IDRENUNCIA As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_FORMATOCAMBIO_REV]"
            With .Parameters
                .Add("@IDFORMATOCAMBIO", SqlDbType.Int).Value = IDCAMBIODEFINITITO
                .Add("@IDUSUARIO", SqlDbType.Int).Value = IDUSUARIO
                .Add("@IDNUEVOORGANIGRAMA", SqlDbType.Int).Value = BE.IDORGANIGRAMA
                .Add("@IDNUEVOCARGO", SqlDbType.Int).Value = BE.IDCARGO
                .Add("@IDNUEVOTIPOCONTRATO", SqlDbType.VarChar, 2).Value = BE.TIPOCONTRATO
                .Add("@FECHAINGRESO", SqlDbType.Date).Value = BE.FECHAINGRESOCOMPANIA
                .Add("@FECHAFINCONTRATO", SqlDbType.Date).Value = BE.FECHAFINALCONTRATO
                .Add("@NUMEROCONTRATO", SqlDbType.Char, 10).Value = NUMEROCONTRATO
                .Add("@INDICADORINDETERMINADO", SqlDbType.Int).Value = BE.INDICADORINDETERMINADO
                .Add("@IDRENUNCIA", SqlDbType.Int).Value = IDRENUNCIA
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
    Public Function AnularCambioDefinitivo(ByVal IDFORMATOCAMBIO As Integer, ByVal IDUSUARIO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_FORMATOCAMBIO_ANULAR_RRHH]"
            With .Parameters
                .Add("@IDFORMATOCAMBIO", SqlDbType.Int).Value = IDFORMATOCAMBIO
                .Add("@IDUSUARIO", SqlDbType.VarChar).Value = IDUSUARIO
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
    Public Function ValidarCambioDefinitivo(BE As CambioLocalDefinitivoBE, ByVal FECHAINGRESO As String, ByVal FECHAFINAL As String, ByVal HORAINGRESO As String, ByVal HORAFIN As String) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_UPDATE_FORMATOCAMBIO_FECHAS]"
            With .Parameters
                .Add("@IDFORMATOCAMBIO", SqlDbType.Int).Value = BE.IDFORMATOCAMBIO
                .Add("@FECHAINGRESO", SqlDbType.NVarChar).Value = FECHAINGRESO
                .Add("@FECHAFINAL", SqlDbType.NVarChar).Value = FECHAFINAL
                .Add("@HORAINGRESO", SqlDbType.NVarChar).Value = HORAINGRESO
                .Add("@HORAFINAL", SqlDbType.NVarChar).Value = HORAFIN
                '.Add("@IDNUEVOCARGO", SqlDbType.Int).Value = BE.IDNUEVOCARGO
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
    Public Function ValidarCambioDefinitivoIdSitio2(BE As CambioLocalDefinitivoBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_VALIDAR_CAMBIODEFINITIVO]"
            With .Parameters
                .Add("@IDFORMATOCAMBIO", SqlDbType.Int).Value = BE.IDFORMATOCAMBIO
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

    Public Function GetFormatoEnvioCOrreo(ByVal IDFORMATOCAMBIO As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_INFO_FORMATOCAMBIO_GET_BY_ID]"
            With .Parameters
                .Add("@IDFORMATOCAMBIO", SqlDbType.Int).Value = IDFORMATOCAMBIO
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
    Public Function CambioDefinitivoLocalHistorialListAll(ByVal FECHAINICIO As Date, ByVal FECHAFINAL As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_CAMBIODEFINITIVO_LIST_PREVIEW_ALL_HISTORIAL]"
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
    Public Function AsignacionFamiliarEmpleadoList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_ASIGNACIONFAMILIAR_EMPLEADO_LIST]"
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

    Public Function GetListarNuevoLocal() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_CAMBIODEFINITIVO_NUEVOLOCAL_LIST_ALL]"
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
    Public Function GetListarNuevoContrato() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_LIST_ALL_TIPOCONTRATOS]"
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

    Public Function AprobarCambioDefinitivoID(ByVal idformatocambio As Integer, ByVal idusuario As Integer, ByVal idnuevoorganigrama As Integer, ByVal fechaingreso As Date) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_CAMBIODEFINITIVO_APROBAR]"
            With .Parameters
                .Add("@IDFORMATOCAMBIO", SqlDbType.Int).Value = idformatocambio
                .Add("@IDUSUARIO", SqlDbType.Int).Value = idusuario
                .Add("@IDNUEVOORGANIGRAMA", SqlDbType.Int).Value = idnuevoorganigrama
                .Add("@FECHAINGRESO", SqlDbType.Date).Value = fechaingreso
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



End Class
