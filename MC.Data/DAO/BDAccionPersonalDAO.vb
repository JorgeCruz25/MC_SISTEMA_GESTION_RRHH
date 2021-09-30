Imports System.Data.SqlClient
Imports System.Text

Public Class BDAccionPersonalDAO

    Dim EmpleadoBE As New EmpleadoBE
    Dim EmpleadoDerechoHabienteBE As New EmpleadoDerechoHabienteBE
    Dim EmpleadoCeseBE As New EmpleadoCeseBE
    Dim RenovacionContratoBE As New RenovacionContratoBE

    Property IdEmpleado As Integer
    Property Empleado_CodigoUnico As String
    Property IdSolicitudCese As Integer
    Property IdAsignacionFamiliar As Integer
    Property IdDerechoHabiente As Integer
    Property flatCargaTipoEmpleado As Integer
    Property IdLocal As Integer
    'Property FechaDesde As Date
    'Property FechaHasta As Date
    Property IdPeriodoRenovacion As Integer

    Property Accion As Integer

#Region "LISTADO MAESTROS"

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
            Throw
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
            Throw
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
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetTipoContratoList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_TIPO_CONTRATO_LIST"
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
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

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
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetEstadoCivilList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_ESTADO_CIVIL_LIST"
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

    Public Function GetNacionalidadList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_NACIONALIDAD_LIST"
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

    Public Function GetMonedaList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_MONEDA_LIST"
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

    Public Function GetRegimenSalarialList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_REGIMEN_SALARIAL_LIST"
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

    Public Function GetTipoEmpleadoList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_EMPLEADO_TIPO_LIST"
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

    Public Function GetCategoriaEmpleadoList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_EMPLEADO_CATEGORIA_LIST"
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

    Public Function GetUbicacionFisicaEmpleadoList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_EMPLEADO_UBICACION_FISICA_LIST"
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
    Public Function GetFiscalizableEmpleadoList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_EMPLEADO_FINANCIABLE_LIST"
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
    Public Function GetTipoRemuneracionEmpleadoList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_EMPLEADO_TIPO_REMUNERACION_LIST"
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
    Public Function GetEsquemaVacacionalEmpleadoList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_EMPLEADO_ESQUEMA_VACACIONAL_LIST"
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
    Public Function GetDireccionConfianzaEmpleadoList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_EMPLEADO_DIRECCIONCONFIANZA_LIST"
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
    Public Function GetTipoFondoPensionesAfpEmpleadoList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_EMPLEADO_TIPOFONDO_AFP_LIST"
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
    Public Function GetTipoAfpEmpleadoList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_EMPLEADO_TIPO_AFP_LIST"
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
    Public Function GetTipoTrabajadorSunatEmpleadoList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_EMPLEADO_TIPO_REGISTRO_SUNAT"
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
    Public Function GetBancoCtsList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_EMPLEADO_BANCO_CTS"
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
    Public Function GetTipoCuentaAbonoList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_TIPO_CUENTA_ABONO_LIST"
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
    Public Function GetFormaPagoList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_FORMA_PAGO_LIST"
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


    Public Function GetMotivoCeseList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MOTIVO_CESE_LIST"
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

    Public Function GetMotivoAumentoList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_EMPLEADO_MOTIVO_AUMENTO_LIST"
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


    Public Function GetTipoDerechoHabienteList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_EMPLEADO_TIPO_DERECHO_HABIENTE_LIST"
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

    Public Function GetTipoMovimientoEmpleadoList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_EMPLEADO_TIPO_MOVIMIENTO_LIST"
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


#Region "EMPLEADOS"

    Public Function GetEmpleadoAccionPersonalList(ByVal IDUSUARIO As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_EMPLEADO_LIST_ALL"
            With .Parameters
                .Add("@IDUSUARIO", SqlDbType.Int).Value = IDUSUARIO
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

    Public Function GetByEmpleadoID(ByVal IDEMPLEADO As Int32) As EmpleadoBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_EMPLEADO_GET_ID"
            With .Parameters
                .Clear()
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IDEMPLEADO
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With EmpleadoBE
                        .CODIGOUNICO = dr.ReadNullAsEmptyString("CODIGOUNICO")
                        .IDEMPLEADO = dr.ReadNullAsNumeric("IDEMPLEADO")
                        .NOMBRES = dr.ReadNullAsEmptyString("NOMBRES")
                        .APELLIDOPATERNO = dr.ReadNullAsEmptyString("APELLIDOPATERNO")
                        .APELLIDOMATERNO = dr.ReadNullAsEmptyString("APELLIDOMATERNO")
                        .IDTIPOIDENTIDAD = dr.ReadNullAsNumeric("IDTIPODOCUMENTOIDENTIDAD")
                        .DNI = dr.ReadNullAsEmptyString("NUMERODOCUMENTO")
                        .IDLOCAL = dr.ReadNullAsNumeric("IDLOCAL")
                        .IDCARGO = dr.ReadNullAsNumeric("IDCARGO")
                        .FECHANACIMIENTO = dr.ReadNullAsEmptyDate("FECHANACIMIENTO")
                        .IDUBIGEO = dr.ReadNullAsNumeric("IDUBIGEO")
                        .IDSEXO = dr.ReadNullAsNumeric("IDSEXO")
                        .IDESTADOCIVIL = dr.ReadNullAsNumeric("IDESTADOCIVIL")
                        .PAIS = dr.ReadNullAsEmptyString("PAIS")
                        .NACIONALIDAD = dr.ReadNullAsEmptyString("NACIONALIDAD")
                        .CORREOPERSONAL = dr.ReadNullAsEmptyString("CORREOPERSONAL")
                        .TELEFONOPERSONAL = dr.ReadNullAsEmptyString("TELEFONO")
                        .DIRECCION = dr.ReadNullAsEmptyString("DIRECCION")
                        .TIPOCONTRATO = dr.ReadNullAsEmptyString("TIPOCONTRATO")
                        .FECHAINGRESOCORPORACION = dr.ReadNullAsEmptyDate("FECHAINGRESOCORPORACION")
                        .FECHAINGRESOCOMPANIA = dr.ReadNullAsEmptyDate("FECHAINGRESO")
                        .FECHAFINALCONTRATO = dr.ReadNullAsEmptyDate("FECHAFINALCONTRATO")
                        .SUELDO = dr.ReadNullAsNumeric("SUELDOBASICO")
                        .SUELDOMONEDA = dr.ReadNullAsEmptyString("SUELDOMONEDA")
                        .IDREGIMENSALARIAL = dr.ReadNullAsNumeric("REGIMENSALARIAL")
                        .CODIGOCATEGORIA = dr.ReadNullAsEmptyString("CODIGOCATEGORIA")
                        .CATEGORIA = dr.ReadNullAsEmptyString("CATEGORIA")
                        .CODIGOTIPOEMPLEADO = dr.ReadNullAsEmptyString("CODIGOTIPOEMPLEADO")
                        .CODIGOUBICACIONFISICA = dr.ReadNullAsEmptyString("CODIGOUBICACIONFISICA")
                        .ESTADO = dr.ReadNullAsEmptyString("ESTADO")
                        .TIPOEMPLEADO = dr.ReadNullAsEmptyString("TIPOEMPLEADO")
                        .NUMEROCUENTAABONO = dr.ReadNullAsEmptyString("CUENTAABONO")
                        .IDTIPOCUENTAABONO = dr.ReadNullAsEmptyString("IDTIPOCUENTAABONO")
                        .IDFORMAPAGO = dr.ReadNullAsEmptyString("IDFORMAPAGO")
                        .IDBANCOABONO = dr.ReadNullAsEmptyString("IDBANCO")
                        .ADRYAN_FISCALIZABLE = dr.ReadNullAsEmptyString("CODIGOFISCALIZABLE")
                        .ADRYAN_TIPOREMUNERACION = dr.ReadNullAsEmptyString("CODIGOTIPOREMUNERACION")
                        .ADRYAN_ESQUEMAVACACIONAL = dr.ReadNullAsEmptyString("CODIGOESQUEMAVACACIONAL")
                        .ADRYAN_DIRECCIONCONFIANZA = dr.ReadNullAsEmptyString("CODIGODIRECCIONCONFIANZA")
                        .DIRECCIONCONFIANZA = dr.ReadNullAsEmptyString("DIRECCIONCONFIANZA")
                        .ADRYAN_TIPOFONDOPENSIONES = dr.ReadNullAsEmptyString("CODIGOFONDOPENSIONES")
                        .ADRYAN_TIPOAFP = dr.ReadNullAsEmptyString("CODIGOAFP")
                        .ADRYAN_CODIGOSPP = dr.ReadNullAsEmptyString("CODIGOSPP")
                        .ADRYAN_FECHAINGRESOAFP = dr.ReadNullAsEmptyString("FECHAINGRESOAFP")
                        .ADRYAN_COMISIONMIXTA = dr.ReadNullAsEmptyString("COMISIONMIXTA")
                        .ADRYAN_TIPOTRABAJADORSUNAT = dr.ReadNullAsEmptyString("CODIGOTIPOTRABAJADORSUNAT")
                        '.ADRYAN_CONTROLINMEDIATO = dr.ReadNullAsEmptyString("SUJETOCONTROLINMEDIATO")
                        '.ADRYAN_JORNADAMAXIMA = dr.ReadNullAsEmptyString("JORNADAMAXIMA")
                        .ADRYAN_INSTITUCIONFINANCIERACTS = dr.ReadNullAsEmptyString("INSTITUCIONFINANCIERACTS")
                        .ADRYAN_INSTITUCIONFINANCIERAENVIOCTS = dr.ReadNullAsEmptyString("INSTITUCIONFINANCIERAENVIOCTS")
                        .ADRYAN_NUMEROCUENTACTS = dr.ReadNullAsEmptyString("NUMEROCUENTACTS")
                        .ADRYAN_TIPO_CUENTACTS = dr.ReadNullAsEmptyString("TIPOCUENTACTS")
                        .MATRICULA = dr.ReadNullAsEmptyString("MATRICULA")
                        .SEXO = dr.ReadNullAsEmptyString("SEXO")
                        .TIPODOCUMENTO = dr.ReadNullAsEmptyString("TIPODOCUMENTO")
                        .CARGO = dr.ReadNullAsEmptyString("CARGO")
                        .TIPOCONTRATODESCRIPCION = dr.ReadNullAsEmptyString("TIPOCONTRATODESCRIPCION")
                        .RAZONCOMERCIAL = dr.ReadNullAsEmptyString("RAZONCOMERCIAL")
                        .RAZONSOCIAL = dr.ReadNullAsEmptyString("RAZONSOCIAL")
                        .EDAD = dr.ReadNullAsNumeric("EDAD")
                        .ESTADOCIVIL = dr.ReadNullAsEmptyString("ESTADOCIVIL")
                        .TIPOREMUNERACION = dr.ReadNullAsEmptyString("TIPOREMUNERACION")
                        .ESQUEMAVACACIONAL = dr.ReadNullAsEmptyString("ESQUEMAVACACIONAL")
                        .REGIMENSALARIALDESCRIPCION = dr.ReadNullAsEmptyString("REGIMENSALARIALDESCRIPCION")
                        .CODIGOAFPDESCRIPCION = dr.ReadNullAsEmptyString("CODIGOAFPDESCRIPCION")
                        .FONDODEPENCIONES = dr.ReadNullAsEmptyString("FONDODEPENCIONES")
                        .TIPOEMPLEADODESCRIPCION = dr.ReadNullAsEmptyString("TIPOEMPLEADODESCRIPCION")
                        .IDORGANIGRAMA = dr.ReadNullAsNumeric("IDORGANIGRAMA")
                        .UBIGEO = dr.ReadNullAsNumeric("UBIGEO")
                        .TRABAJADORSUNAT = dr.ReadNullAsEmptyString("TRABAJADORSUNAT")
                        .INSTITUCION_FINANCIERA_CTS = dr.ReadNullAsEmptyString("DESCRIPCIONINSTITUCIONFINANCIERACTS")
                        .INSTITUCION_FINANCIERA_ENVIO_CTS = dr.ReadNullAsEmptyString("DESCRIPCIONINSTITUCIONFINANCIERAENVIOCTS")
                        .MONEDA_CTS = dr.ReadNullAsEmptyString("MONEDACTS")
                        .BANCOABONO = dr.ReadNullAsEmptyString("BANCOABONO")
                        .TIPOCUENTAABONO = dr.ReadNullAsEmptyString("TIPOCUENTAABONO")
                        .FORMAPAGOEMPLEADO = dr.ReadNullAsEmptyString("FORMAPAGOEMPLEADO")
                        .BANCOABONOPROPIETARIO = dr.ReadNullAsEmptyString("BANCOABONOPROPIETARIO")
                        .CODIGOBANCOABONOPROPIETARIO = dr.ReadNullAsEmptyString("CODIGOBANCOABONOPROPIETARIO")


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
        Return EmpleadoBE
    End Function

    Public Function GetEmpleadoCargarDatosAdicionales(ByVal IDTIPODOCUMENTO As Integer, ByVal IDCARGO As Integer, ByVal IDORGANIGRAMA As Integer, IDUBIGEO As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_EMPLEADO_CARGAR_DATOS_ADICIONALES"
            With .Parameters
                .Clear()
                .Add("@IDTIPODOCUMENTO", SqlDbType.Int).Value = IDTIPODOCUMENTO
                .Add("@IDCARGO", SqlDbType.Int).Value = IDCARGO
                .Add("@IDORGANIGRAMA", SqlDbType.Int).Value = IDORGANIGRAMA
                .Add("@IDUBIGEO", SqlDbType.Int).Value = IDUBIGEO
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
    Public Function GetEmpleadoCargarDatosAdicionalesParaInsert(ByVal IDTIPOREMUNERACION As String, ByVal IDFISCALIZABLE As String, ByVal IDDIRECCIONCONFIANZA As String, ByVal IDESQUEMAVACACIONAL As String, ByVal IDTIPOFONDOPENSIONES As String, ByVal IDTIPOAFP As String, ByVal IDTIPOTRABAJADORSUNAT As String, ByVal MONEDATIPOCUENTACTS As String, ByVal BANCOPRO As String, ByVal BANCOENVIO As String, ByVal BANCOABONO As String, ByVal TIPOCUENTAABONO As String) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_EMPLEADO_CARGAR_DATOS_ADRYAN"
            With .Parameters
                .Clear()
                .Add("@CODIGOREMUNERACIONADRYAN", SqlDbType.NVarChar).Value = IDTIPOREMUNERACION
                .Add("@CODIGOFISCALIZABLEADRYAN", SqlDbType.NVarChar).Value = IDFISCALIZABLE
                .Add("@CODIGODIRECCIONCONFIANZAADRYAN", SqlDbType.NVarChar).Value = IDDIRECCIONCONFIANZA
                .Add("@CODIGOESQUEMAVACACIONALADRYAN", SqlDbType.NVarChar).Value = IDESQUEMAVACACIONAL
                .Add("@CODIGOFONDOPENSIONESADRYAN", SqlDbType.NVarChar).Value = IDTIPOFONDOPENSIONES
                .Add("@CODIGOAFPADRYAN", SqlDbType.NVarChar).Value = IDTIPOAFP
                .Add("@CODIGOTRABAJADORSUNATADRYAN", SqlDbType.NVarChar).Value = IDTIPOTRABAJADORSUNAT


                If TIPOCUENTAABONO Is Nothing Then
                    .Add("@TIPOCUENTAABONO", SqlDbType.Char, 1).Value = ""
                Else
                    .Add("@TIPOCUENTAABONO", SqlDbType.Char, 1).Value = TIPOCUENTAABONO
                End If
                If BANCOABONO Is Nothing Then
                    .Add("@BANCOENVIOABONO", SqlDbType.NVarChar).Value = ""
                Else
                    .Add("@BANCOENVIOABONO", SqlDbType.NVarChar).Value = BANCOABONO
                End If
                If MONEDATIPOCUENTACTS Is Nothing Then
                    .Add("@CODIGOTIPOCUENTACTSADRYAN", SqlDbType.NVarChar).Value = ""
                Else
                    .Add("@CODIGOTIPOCUENTACTSADRYAN", SqlDbType.NVarChar).Value = MONEDATIPOCUENTACTS
                End If
                If BANCOPRO Is Nothing Then
                    .Add("@CODIGOINSTITUCIONFINANCIERACTSADRYAN", SqlDbType.NVarChar).Value = ""
                Else
                    .Add("@CODIGOINSTITUCIONFINANCIERACTSADRYAN", SqlDbType.NVarChar).Value = BANCOPRO
                End If
                If BANCOENVIO Is Nothing Then
                    .Add("@CODIGOINSTITUCIONFINANCIERAENVIOCTSADRYAN", SqlDbType.NVarChar).Value = ""
                Else
                    .Add("@CODIGOINSTITUCIONFINANCIERAENVIOCTSADRYAN", SqlDbType.NVarChar).Value = BANCOENVIO
                End If
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

    Public Function GetEmpleadoAsignadoEnRenovacion(ByVal IdEmpleado As Integer) As DataTable
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

    Public Function GetEmpleadoPendientesAccionPersonalList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_EMPLEADO_PENDIENTES_LIST_ALL"
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

    Public Function GetEmpleadosAccionPersonalCesadosList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_EMPLEADO_CESADOS_LIST_ALL"
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

    Public Function GetEmpleadosAccionPersonalActivosList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_EMPLEADO_ACTIVOS_LIST_ALL"
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



#Region "INGRESO DE PERSONAL"

    Public Function GetEmpleadoIngresoList(ByVal FechaInicial As Date, ByVal FechaFinal As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_INGRESO_EMPLEADO_LIST"
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
    End Function 'OK

    Public Function GetEmpleadoCargarDatosGetId(ByVal FechaInicial As Date, ByVal FechaFinal As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_INGRESO_EMPLEADO_LIST"
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
    End Function 'OK
    'Public Function GetGradoSalarialList(ByVal IdPuesto As Integer) As DataTable
    '    Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
    '    Dim cmd As New SqlCommand
    '    Dim dt As New DataTable

    '    With cmd
    '        .Connection = cnx
    '        .CommandType = CommandType.StoredProcedure
    '        .CommandTimeout = 0
    '        .CommandText = "MC_GRADO_SALARIAL_LIST"
    '        With .Parameters
    '            .Add("@IDPUESTO", SqlDbType.VarChar, 50).Value = IdPuesto
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
    Public Function ObternerExistenciaDni(ByVal IdEmpleado As String, ByVal NumeroDocumento As String) As String
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim Valor As String = ""
        Try
            Dim reader As SqlDataReader
            Dim cmd = New SqlCommand
            With cmd
                cnx.Open()

                .Connection = cnx
                .CommandType = CommandType.Text
                .CommandText = "select count(*) from MC_EMPLEADO where  numerodocumento = '" + NumeroDocumento + "'" + " and idempleado <> '" + IdEmpleado + "'"
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

    Public Function InsertaEmpleadoAdryan(BE As EmpleadoBE, ByVal NumeroContrato As String) As Boolean


        Dim cnx As New SqlConnection(ConexionDAO.GetConexionADRYAN)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_INSERTA_EMPLEADO_ADRYAN"
            With .Parameters
                .Add("@CODIGOUNICO", SqlDbType.NVarChar, 9).Direction = ParameterDirection.Output
                .Add("@NUMEROIDENTIDAD", SqlDbType.NVarChar, 20).Value = BE.DNI
                .Add("@TIPO_DOCUMENTO", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_TIPOIDENTIDAD
                .Add("@PUESTO_ORGANICA", SqlDbType.NVarChar, 8).Value = BE.ADRYAN_PUESTO_ORGANICA
                .Add("@UNIDAD_FUNCIONAL", SqlDbType.NVarChar, 8).Value = BE.ADRYAN_UNIDAD_FUNCIONAL
                .Add("@NOMBRES", SqlDbType.VarChar, 50).Value = BE.NOMBRES
                .Add("@APELLIDOPATERNO", SqlDbType.VarChar, 30).Value = BE.APELLIDOPATERNO
                .Add("@APELLIDOMATERNO", SqlDbType.VarChar, 30).Value = BE.APELLIDOMATERNO
                .Add("@FECHANACIMIENTO", SqlDbType.Date).Value = BE.FECHANACIMIENTO
                .Add("@SEXO", SqlDbType.NVarChar, 1).Value = BE.IDSEXO
                .Add("@DIRECCION", SqlDbType.NVarChar, 100).Value = BE.DIRECCION
                .Add("@DISTRITO", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_DISTRITO
                .Add("@PROVINCIA", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_PROVINCIA
                .Add("@DEPARTAMENTO", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_DEPARTAMENTO
                .Add("@TIPOCONTRATO", SqlDbType.NVarChar, 1).Value = BE.TIPOCONTRATO
                .Add("@FECHAINGRESOCORPORACION", SqlDbType.Date).Value = BE.FECHAINGRESOCORPORACION
                .Add("@FECHAINGRESOCOMPANIA", SqlDbType.Date).Value = BE.FECHAINGRESOCOMPANIA
                .Add("@SUELDO", SqlDbType.Float).Value = BE.SUELDO
                .Add("@CORREO", SqlDbType.NVarChar, 100).Value = BE.CORREOPERSONAL
                .Add("@TELEFONO", SqlDbType.NVarChar, 20).Value = BE.TELEFONOPERSONAL
                .Add("@ESTADOCIVIL", SqlDbType.NVarChar, 1).Value = BE.IDESTADOCIVIL
                .Add("@PAIS", SqlDbType.NVarChar, 2).Value = BE.PAIS
                .Add("@NACIONALIDAD", SqlDbType.NVarChar, 2).Value = BE.NACIONALIDAD
                .Add("@FECHAFINALCONTRATO", SqlDbType.Date).Value = BE.FECHAFINALCONTRATO
                .Add("@TIPOMONEDA", SqlDbType.NVarChar, 1).Value = BE.SUELDOMONEDA
                .Add("@REGIMENSALARIAL", SqlDbType.NVarChar, 2).Value = BE.IDREGIMENSALARIAL
                .Add("@CODIGOTIPOEMPLEADO", SqlDbType.NVarChar, 1).Value = BE.CODIGOTIPOEMPLEADO
                .Add("@CODIGOCATEGORIA", SqlDbType.NVarChar, 3).Value = BE.CODIGOCATEGORIA
                .Add("@CODIGOUBICACIONFISICA", SqlDbType.NVarChar, 7).Value = BE.CODIGOUBICACIONFISICA
                .Add("@USUARIOREGISTRO", SqlDbType.NVarChar, 10).Value = BE.USUARIOREGISTRO

                .Add("@CODIGOSPP", SqlDbType.NVarChar, 15).Value = BE.ADRYAN_CODIGOSPP
                .Add("@FECHAINGRESOAFP", SqlDbType.DateTime).Value = BE.ADRYAN_FECHAINGRESOAFP
                .Add("@INDICADORINSCRITOAFP", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_TIPOFONDOPENSIONES
                .Add("@CODIGOAFP", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_TIPOAFP
                .Add("@TIPOREMUNERACION", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_TIPOREMUNERACION
                .Add("@ESQUEMAVACACIONAL", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_ESQUEMAVACACIONAL

                .Add("@DIRECCIONCONFIANZA", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_DIRECCIONCONFIANZA
                .Add("@FISCALIZABLE", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_FISCALIZABLE
                .Add("@INDICADORCOMISIONMIXTA", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_COMISIONMIXTA
                .Add("@TRABAJADOSUNAT", SqlDbType.NVarChar, 6).Value = BE.ADRYAN_TIPOTRABAJADORSUNAT
                '.Add("@CONTROLINMEDIATO", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_CONTROLINMEDIATO
                '.Add("@INDICADORJORNADAMAXIMA", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_JORNADAMAXIMA

                .Add("@TIPOCUENTACTS", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_TIPO_CUENTACTS
                .Add("@INSTITUCIONFINANCIERACTS", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_INSTITUCIONFINANCIERACTS
                .Add("@INSTITUCIONFINANCIERAENVIOCTS", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_INSTITUCIONFINANCIERAENVIOCTS
                .Add("@NUMEROCUENTACTS", SqlDbType.NVarChar, 20).Value = BE.ADRYAN_NUMEROCUENTACTS
                .Add("@GRADOSALARIAL", SqlDbType.NVarChar, 3).Value = BE.ADRYAN_GRADOSALARIAL
                .Add("@NUMEROCUENTAABONO", SqlDbType.Char, 20).Value = BE.NUMEROCUENTAABONO
                .Add("@CODIGOBANCOABONO", SqlDbType.Char, 2).Value = BE.ADRYAN_BANCOABONO
                .Add("@TIPOCUENTAABONO", SqlDbType.Char, 1).Value = BE.ADRYAN_TIPOCUENTAABONO
                .Add("@NUMEROCONTRATO", SqlDbType.Char, 10).Value = NumeroContrato
                Try
                    cnx.Open()
                    If cmd.ExecuteNonQuery() > 0 Then
                        Empleado_CodigoUnico = cmd.Parameters("@CODIGOUNICO").Value
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
    End Function

    Public Function UpdateEmpleadoAdryan(BE As EmpleadoBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionADRYAN)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd

            'ADRYAN_TIPOFONDOPENSIONES
            'ADRYAN_CODIGOSPP
            'ADRYAN_TIPOAFP
            'ADRYAN_FECHAINGRESOAFP
            'ADRYAN_COMISIONMIXTA

            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_UPDATE_EMPLEADO_ADRYAN"
            With .Parameters
                .Add("@CODIGOUNICO", SqlDbType.NVarChar, 9).Value = BE.CODIGOUNICO
                .Add("@NUMEROIDENTIDAD", SqlDbType.NVarChar, 20).Value = BE.DNI
                .Add("@TIPO_DOCUMENTO", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_TIPOIDENTIDAD
                .Add("@PUESTO_ORGANICA", SqlDbType.NVarChar, 8).Value = BE.ADRYAN_PUESTO_ORGANICA
                .Add("@UNIDAD_FUNCIONAL", SqlDbType.NVarChar, 8).Value = BE.ADRYAN_UNIDAD_FUNCIONAL
                .Add("@NOMBRES", SqlDbType.VarChar, 50).Value = BE.NOMBRES
                .Add("@APELLIDOPATERNO", SqlDbType.VarChar, 30).Value = BE.APELLIDOPATERNO
                .Add("@APELLIDOMATERNO", SqlDbType.VarChar, 30).Value = BE.APELLIDOMATERNO
                .Add("@FECHANACIMIENTO", SqlDbType.Date).Value = BE.FECHANACIMIENTO
                .Add("@SEXO", SqlDbType.NVarChar, 1).Value = BE.IDSEXO
                .Add("@DIRECCION", SqlDbType.NVarChar, 100).Value = BE.DIRECCION
                .Add("@DISTRITO", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_DISTRITO
                .Add("@PROVINCIA", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_PROVINCIA
                .Add("@DEPARTAMENTO", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_DEPARTAMENTO
                .Add("@TIPOCONTRATO", SqlDbType.NVarChar, 1).Value = BE.TIPOCONTRATO
                .Add("@FECHAINGRESOCORPORACION", SqlDbType.Date).Value = BE.FECHAINGRESOCORPORACION
                .Add("@FECHAINGRESOCOMPANIA", SqlDbType.Date).Value = BE.FECHAINGRESOCOMPANIA
                .Add("@SUELDO", SqlDbType.Float).Value = BE.SUELDO
                .Add("@CORREO", SqlDbType.NVarChar, 100).Value = BE.CORREOPERSONAL
                .Add("@TELEFONO", SqlDbType.NVarChar, 20).Value = BE.TELEFONOPERSONAL
                .Add("@ESTADOCIVIL", SqlDbType.NVarChar, 1).Value = BE.IDESTADOCIVIL
                .Add("@PAIS", SqlDbType.NVarChar, 2).Value = BE.PAIS
                .Add("@NACIONALIDAD", SqlDbType.NVarChar, 2).Value = BE.NACIONALIDAD
                .Add("@FECHAFINALCONTRATO", SqlDbType.Date).Value = BE.FECHAFINALCONTRATO
                .Add("@TIPOMONEDA", SqlDbType.NVarChar, 1).Value = BE.SUELDOMONEDA
                .Add("@REGIMENSALARIAL", SqlDbType.NVarChar, 2).Value = BE.IDREGIMENSALARIAL
                .Add("@CODIGOTIPOEMPLEADO", SqlDbType.NVarChar, 1).Value = BE.CODIGOTIPOEMPLEADO
                .Add("@CODIGOCATEGORIA", SqlDbType.NVarChar, 3).Value = BE.CODIGOCATEGORIA
                .Add("@CODIGOUBICACIONFISICA", SqlDbType.NVarChar, 7).Value = BE.CODIGOUBICACIONFISICA

                .Add("@CODIGOSPP", SqlDbType.NVarChar, 15).Value = BE.ADRYAN_CODIGOSPP
                .Add("@FECHAINGRESOAFP", SqlDbType.DateTime).Value = BE.ADRYAN_FECHAINGRESOAFP
                .Add("@INDICADORINSCRITOAFP", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_TIPOFONDOPENSIONES
                .Add("@CODIGOAFP", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_TIPOAFP
                .Add("@TIPOREMUNERACION", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_TIPOREMUNERACION
                .Add("@ESQUEMAVACACIONAL", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_ESQUEMAVACACIONAL
                .Add("@DIRECCIONCONFIANZA", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_DIRECCIONCONFIANZA


                .Add("@FISCALIZABLE", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_FISCALIZABLE
                .Add("@INDICADORCOMISIONMIXTA", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_COMISIONMIXTA
                .Add("@TRABAJADOSUNAT", SqlDbType.NVarChar, 6).Value = BE.ADRYAN_TIPOTRABAJADORSUNAT
                '.Add("@CONTROLINMEDIATO", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_CONTROLINMEDIATO
                '.Add("@INDICADORJORNADAMAXIMA", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_JORNADAMAXIMA
                .Add("@TIPOCUENTACTS", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_TIPO_CUENTACTS
                .Add("@INSTITUCIONFINANCIERACTS", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_INSTITUCIONFINANCIERACTS
                .Add("@INSTITUCIONFINANCIERAENVIOCTS", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_INSTITUCIONFINANCIERAENVIOCTS
                .Add("@NUMEROCUENTACTS", SqlDbType.NVarChar, 20).Value = BE.ADRYAN_NUMEROCUENTACTS
                .Add("@NUMEROCUENTAABONO", SqlDbType.Char, 20).Value = BE.NUMEROCUENTAABONO
                .Add("@CODIGOBANCOABONO", SqlDbType.Char, 2).Value = BE.ADRYAN_BANCOABONO
                .Add("@TIPOCUENTAABONO", SqlDbType.Char, 1).Value = BE.ADRYAN_TIPOCUENTAABONO
                .Add("@CODIGOBANCOABONOPROPIETARIO", SqlDbType.Char, 2).Value = BE.CODIGOBANCOABONOPROPIETARIO
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

    Public Function InsertaIngresoPersonal(BE As EmpleadoBE, ByVal NumeroContrato As String, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_INGRESO_EMPLEADO_INS"
            With .Parameters
                .Add("@CODIGOUNICO", SqlDbType.NVarChar, 9).Value = Empleado_CodigoUnico
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = BE.IDEMPLEADO
                .Add("@APELLIDOPATERNO", SqlDbType.VarChar, 100).Value = BE.APELLIDOPATERNO
                .Add("@APELLIDOMATERNO", SqlDbType.VarChar, 100).Value = BE.APELLIDOMATERNO
                .Add("@NOMBRES", SqlDbType.VarChar, 100).Value = BE.NOMBRES
                .Add("@IDTIPODOCUMENTOIDENTIDAD", SqlDbType.Int).Value = BE.IDTIPOIDENTIDAD
                .Add("@NUMERODOCUMENTO", SqlDbType.VarChar, 50).Value = BE.DNI
                .Add("@FECHANACIMIENTO", SqlDbType.Date).Value = BE.FECHANACIMIENTO
                .Add("@IDUBIGEO", SqlDbType.Int).Value = BE.IDUBIGEO
                .Add("@DIRECCION", SqlDbType.NVarChar, 500).Value = BE.DIRECCION
                .Add("@IDSEXO", SqlDbType.Int).Value = BE.IDSEXO
                .Add("@IDORGANIGRAMA", SqlDbType.Int).Value = BE.IDORGANIGRAMA
                .Add("@IDCARGO", SqlDbType.Int).Value = BE.IDCARGO
                .Add("@TIPOCONTRATO", SqlDbType.VarChar, 2).Value = BE.TIPOCONTRATO
                .Add("@FECHAINGRESOCORPORACION", SqlDbType.Date).Value = BE.FECHAINGRESOCORPORACION
                .Add("@FECHAINGRESOCOMPANIA", SqlDbType.Date).Value = BE.FECHAINGRESOCOMPANIA
                .Add("@SUELDO", SqlDbType.Float).Value = BE.SUELDO
                .Add("@CORREO", SqlDbType.NVarChar, 100).Value = BE.CORREOPERSONAL
                .Add("@TELEFONO", SqlDbType.NVarChar, 20).Value = BE.TELEFONOPERSONAL
                .Add("@IDESTADOCIVIL", SqlDbType.Int).Value = BE.IDESTADOCIVIL
                .Add("@PAIS", SqlDbType.NVarChar, 2).Value = BE.PAIS
                .Add("@NACIONALIDAD", SqlDbType.NVarChar, 2).Value = BE.NACIONALIDAD
                .Add("@FECHAFINALCONTRATO", SqlDbType.Date).Value = BE.FECHAFINALCONTRATO
                .Add("@TIPOMONEDA", SqlDbType.NVarChar, 1).Value = BE.SUELDOMONEDA
                .Add("@REGIMENSALARIAL", SqlDbType.Int).Value = BE.IDREGIMENSALARIAL
                .Add("@CODIGOTIPOEMPLEADO", SqlDbType.NVarChar, 1).Value = BE.CODIGOTIPOEMPLEADO
                .Add("@CODIGOCATEGORIA", SqlDbType.NVarChar, 3).Value = BE.CODIGOCATEGORIA
                .Add("@CODIGOUBICACIONFISICA", SqlDbType.NVarChar, 7).Value = BE.CODIGOUBICACIONFISICA
                .Add("@IDUSUARIOREGISTRO", SqlDbType.Int).Value = BE.IDUSUARIOREGISTRO

                .Add("@CODIGOFISCALIZABLE", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_FISCALIZABLE
                .Add("@CODIGOTIPOREMUNERACION", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_TIPOREMUNERACION
                .Add("@CODIGODIRECCIONCONFIANZA", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_DIRECCIONCONFIANZA
                .Add("@ESQUEMAVACACIONAL", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_ESQUEMAVACACIONAL
                .Add("@CODIGOFONDOPENSIONES", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_TIPOFONDOPENSIONES
                .Add("@CODIGOAFP", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_TIPOAFP
                .Add("@CODIGOSPP", SqlDbType.NVarChar, 15).Value = BE.ADRYAN_CODIGOSPP
                .Add("@FECHAINGRESOAFP", SqlDbType.DateTime).Value = BE.ADRYAN_FECHAINGRESOAFP
                .Add("@CODIGOCOMISIONMIXTA", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_COMISIONMIXTA
                .Add("@CODIGOTRABAJADORSUNAT", SqlDbType.NVarChar, 6).Value = BE.ADRYAN_TIPOTRABAJADORSUNAT
                '.Add("@SUJETOCONTROLINMEDIATO", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_CONTROLINMEDIATO
                '.Add("@JORNADAMAXIMA", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_JORNADAMAXIMA
                .Add("@TIPOCUENTACTS", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_TIPO_CUENTACTS
                .Add("@INSTITUCIONFINANCIERACTS", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_INSTITUCIONFINANCIERACTS
                .Add("@INSTITUCIONFINANCIERAENVIOCTS", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_INSTITUCIONFINANCIERAENVIOCTS
                .Add("@NUMEROCUENTACTS", SqlDbType.NVarChar, 20).Value = BE.ADRYAN_NUMEROCUENTACTS
                .Add("@NUMEROCUENTAABONO", SqlDbType.NVarChar, 100).Value = BE.NUMEROCUENTAABONO
                .Add("@IDTIPOCUENTAABONO", SqlDbType.NVarChar, 1).Value = BE.IDTIPOCUENTAABONO
                .Add("@IDFORMAPAGO", SqlDbType.Int).Value = BE.IDFORMAPAGO
                .Add("@IDBANCO", SqlDbType.Int).Value = BE.IDBANCOABONO
                .Add("@NUMEROCONTRATO", SqlDbType.Char, 10).Value = NumeroContrato
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

    Public Function InsertaIngresoPersonalcambioRazon(BE As EmpleadoBE, ByVal NumeroContrato As String, ByVal IdUsuario As Integer, ByVal idcambiodefinitivo As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_HISTORICO_EMPLEADO_INS"
            With .Parameters
                .Add("@CODIGOUNICO", SqlDbType.NVarChar, 9).Value = Empleado_CodigoUnico
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = BE.IDEMPLEADO
                .Add("@APELLIDOPATERNO", SqlDbType.VarChar, 100).Value = BE.APELLIDOPATERNO
                .Add("@APELLIDOMATERNO", SqlDbType.VarChar, 100).Value = BE.APELLIDOMATERNO
                .Add("@NOMBRES", SqlDbType.VarChar, 100).Value = BE.NOMBRES
                .Add("@IDTIPODOCUMENTOIDENTIDAD", SqlDbType.Int).Value = BE.IDTIPOIDENTIDAD
                .Add("@NUMERODOCUMENTO", SqlDbType.VarChar, 50).Value = BE.DNI
                .Add("@FECHANACIMIENTO", SqlDbType.Date).Value = BE.FECHANACIMIENTO
                .Add("@IDUBIGEO", SqlDbType.Int).Value = BE.IDUBIGEO
                .Add("@DIRECCION", SqlDbType.NVarChar, 500).Value = BE.DIRECCION
                .Add("@IDSEXO", SqlDbType.Int).Value = BE.IDSEXO
                .Add("@IDORGANIGRAMA", SqlDbType.Int).Value = BE.IDORGANIGRAMA
                .Add("@IDCARGO", SqlDbType.Int).Value = BE.IDCARGO
                .Add("@TIPOCONTRATO", SqlDbType.VarChar, 2).Value = BE.TIPOCONTRATO
                .Add("@FECHAINGRESOCORPORACION", SqlDbType.Date).Value = BE.FECHAINGRESOCORPORACION
                .Add("@FECHAINGRESOCOMPANIA", SqlDbType.Date).Value = BE.FECHAINGRESOCOMPANIA
                .Add("@SUELDO", SqlDbType.Float).Value = BE.SUELDO
                .Add("@CORREO", SqlDbType.NVarChar, 100).Value = BE.CORREOPERSONAL
                .Add("@TELEFONO", SqlDbType.NVarChar, 20).Value = BE.TELEFONOPERSONAL
                .Add("@IDESTADOCIVIL", SqlDbType.Int).Value = BE.IDESTADOCIVIL
                .Add("@PAIS", SqlDbType.NVarChar, 2).Value = BE.PAIS
                .Add("@NACIONALIDAD", SqlDbType.NVarChar, 2).Value = BE.NACIONALIDAD
                .Add("@FECHAFINALCONTRATO", SqlDbType.Date).Value = BE.FECHAFINALCONTRATO
                .Add("@TIPOMONEDA", SqlDbType.NVarChar, 1).Value = BE.SUELDOMONEDA
                .Add("@REGIMENSALARIAL", SqlDbType.Int).Value = BE.IDREGIMENSALARIAL
                .Add("@CODIGOTIPOEMPLEADO", SqlDbType.NVarChar, 1).Value = BE.CODIGOTIPOEMPLEADO
                .Add("@CODIGOCATEGORIA", SqlDbType.NVarChar, 3).Value = BE.CODIGOCATEGORIA
                .Add("@CODIGOUBICACIONFISICA", SqlDbType.NVarChar, 7).Value = BE.CODIGOUBICACIONFISICA
                .Add("@IDUSUARIOREGISTRO", SqlDbType.Int).Value = BE.IDUSUARIOREGISTRO

                .Add("@CODIGOFISCALIZABLE", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_FISCALIZABLE
                .Add("@CODIGOTIPOREMUNERACION", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_TIPOREMUNERACION
                .Add("@CODIGODIRECCIONCONFIANZA", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_DIRECCIONCONFIANZA
                .Add("@ESQUEMAVACACIONAL", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_ESQUEMAVACACIONAL
                .Add("@CODIGOFONDOPENSIONES", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_TIPOFONDOPENSIONES
                .Add("@CODIGOAFP", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_TIPOAFP
                .Add("@CODIGOSPP", SqlDbType.NVarChar, 15).Value = BE.ADRYAN_CODIGOSPP
                .Add("@FECHAINGRESOAFP", SqlDbType.DateTime).Value = BE.ADRYAN_FECHAINGRESOAFP
                .Add("@CODIGOCOMISIONMIXTA", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_COMISIONMIXTA
                .Add("@CODIGOTRABAJADORSUNAT", SqlDbType.NVarChar, 6).Value = BE.ADRYAN_TIPOTRABAJADORSUNAT
                '.Add("@SUJETOCONTROLINMEDIATO", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_CONTROLINMEDIATO
                '.Add("@JORNADAMAXIMA", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_JORNADAMAXIMA
                .Add("@TIPOCUENTACTS", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_TIPO_CUENTACTS
                .Add("@INSTITUCIONFINANCIERACTS", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_INSTITUCIONFINANCIERACTS
                .Add("@INSTITUCIONFINANCIERAENVIOCTS", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_INSTITUCIONFINANCIERAENVIOCTS
                .Add("@NUMEROCUENTACTS", SqlDbType.NVarChar, 20).Value = BE.ADRYAN_NUMEROCUENTACTS
                .Add("@NUMEROCUENTAABONO", SqlDbType.NVarChar, 100).Value = BE.NUMEROCUENTAABONO
                .Add("@IDTIPOCUENTAABONO", SqlDbType.NVarChar, 1).Value = BE.IDTIPOCUENTAABONO
                .Add("@IDFORMAPAGO", SqlDbType.Int).Value = BE.IDFORMAPAGO
                .Add("@IDBANCO", SqlDbType.Int).Value = BE.IDBANCOABONO
                .Add("@NUMEROCONTRATO", SqlDbType.Char, 10).Value = NumeroContrato
                .Add("@IDUSUARIO", SqlDbType.Int).Value = IdUsuario
                .Add("@IDCAMBIODEFINITIVO", SqlDbType.Int).Value = idcambiodefinitivo
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


    Public Function UpdateEmpleado(BE As EmpleadoBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            'ADRYAN_TIPOFONDOPENSIONES
            'ADRYAN_CODIGOSPP
            'IDTIPOAFP
            'ADRYAN_TIPOAFP
            'dtFechaIngresoAfp
            'ADRYAN_FECHAINGRESOAFP
            'ADRYAN_COMISIONMIXTA
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_EMPLEADO_UPDATE_EMPLEADO"
            With .Parameters
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = BE.IDEMPLEADO
                .Add("@APELLIDOPATERNO", SqlDbType.VarChar, 100).Value = BE.APELLIDOPATERNO
                .Add("@APELLIDOMATERNO", SqlDbType.VarChar, 100).Value = BE.APELLIDOMATERNO
                .Add("@NOMBRES", SqlDbType.VarChar, 100).Value = BE.NOMBRES
                .Add("@IDTIPODOCUMENTOIDENTIDAD", SqlDbType.Int).Value = BE.IDTIPOIDENTIDAD
                .Add("@NUMERODOCUMENTO", SqlDbType.VarChar, 50).Value = BE.DNI
                .Add("@FECHANACIMIENTO", SqlDbType.Date).Value = BE.FECHANACIMIENTO
                .Add("@IDUBIGEO", SqlDbType.Int).Value = BE.IDUBIGEO
                .Add("@DIRECCION", SqlDbType.NVarChar, 500).Value = BE.DIRECCION
                .Add("@IDSEXO", SqlDbType.Int).Value = BE.IDSEXO
                .Add("@IDORGANIGRAMA", SqlDbType.Int).Value = BE.IDORGANIGRAMA
                .Add("@IDCARGO", SqlDbType.Int).Value = BE.IDCARGO
                .Add("@TIPOCONTRATO", SqlDbType.VarChar, 2).Value = BE.TIPOCONTRATO
                .Add("@FECHAINGRESOCORPORACION", SqlDbType.Date).Value = BE.FECHAINGRESOCORPORACION
                .Add("@FECHAINGRESOCOMPANIA", SqlDbType.Date).Value = BE.FECHAINGRESOCOMPANIA
                .Add("@SUELDO", SqlDbType.Float).Value = BE.SUELDO
                .Add("@CORREO", SqlDbType.NVarChar, 100).Value = BE.CORREOPERSONAL
                .Add("@TELEFONO", SqlDbType.NVarChar, 20).Value = BE.TELEFONOPERSONAL
                .Add("@IDESTADOCIVIL", SqlDbType.Int).Value = BE.IDESTADOCIVIL
                .Add("@PAIS", SqlDbType.NVarChar, 2).Value = BE.PAIS
                .Add("@NACIONALIDAD", SqlDbType.NVarChar, 2).Value = BE.NACIONALIDAD
                .Add("@FECHAFINALCONTRATO", SqlDbType.Date).Value = BE.FECHAFINALCONTRATO
                .Add("@TIPOMONEDA", SqlDbType.NVarChar, 1).Value = BE.SUELDOMONEDA
                .Add("@REGIMENSALARIAL", SqlDbType.Int).Value = BE.IDREGIMENSALARIAL
                .Add("@CODIGOTIPOEMPLEADO", SqlDbType.NVarChar, 1).Value = BE.CODIGOTIPOEMPLEADO
                .Add("@CODIGOCATEGORIA", SqlDbType.NVarChar, 3).Value = BE.CODIGOCATEGORIA
                .Add("@CODIGOUBICACIONFISICA", SqlDbType.NVarChar, 7).Value = BE.CODIGOUBICACIONFISICA
                .Add("@IDUSUARIOREGISTRO", SqlDbType.Int).Value = BE.IDUSUARIOREGISTRO

                .Add("@CODIGOSPP", SqlDbType.NVarChar, 15).Value = BE.ADRYAN_CODIGOSPP
                .Add("@FECHAINGRESOAFP", SqlDbType.DateTime).Value = BE.ADRYAN_FECHAINGRESOAFP
                .Add("@INDICADORINSCRITOAFP", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_TIPOFONDOPENSIONES
                .Add("@CODIGOAFP", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_TIPOAFP
                .Add("@TIPOREMUNERACION", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_TIPOREMUNERACION
                .Add("@ESQUEMAVACACIONAL", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_ESQUEMAVACACIONAL
                .Add("@DIRECCIONCONFIANZA", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_DIRECCIONCONFIANZA

                .Add("@FISCALIZABLE", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_FISCALIZABLE
                .Add("@INDICADORCOMISIONMIXTA", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_COMISIONMIXTA
                .Add("@TRABAJADOSUNAT", SqlDbType.NVarChar, 6).Value = BE.ADRYAN_TIPOTRABAJADORSUNAT
                '.Add("@CONTROLINMEDIATO", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_CONTROLINMEDIATO
                '.Add("@INDICADORJORNADAMAXIMA", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_JORNADAMAXIMA
                .Add("@TIPOCUENTACTS", SqlDbType.NVarChar, 1).Value = BE.ADRYAN_TIPO_CUENTACTS
                .Add("@INSTITUCIONFINANCIERACTS", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_INSTITUCIONFINANCIERACTS
                .Add("@INSTITUCIONFINANCIERAENVIOCTS", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_INSTITUCIONFINANCIERAENVIOCTS
                .Add("@NUMEROCUENTACTS", SqlDbType.NVarChar, 20).Value = BE.ADRYAN_NUMEROCUENTACTS

                .Add("@IDBANCO", SqlDbType.NVarChar, 20).Value = BE.IDBANCOABONO
                .Add("@IDFORMAPAGO", SqlDbType.NVarChar, 20).Value = BE.IDFORMAPAGO
                .Add("@IDTIPOCUENTAABONO", SqlDbType.NVarChar, 20).Value = BE.IDTIPOCUENTAABONO
                .Add("@NUMEROCUENTAABONO", SqlDbType.NVarChar, 20).Value = BE.NUMEROCUENTAABONO
                .Add("@CODIGOBANCOPROPIETARIO", SqlDbType.NVarChar, 20).Value = BE.CODIGOBANCOABONOPROPIETARIO
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





    Public Function GetEmpleadoActivoAdryan(ByVal numerodocumento As String) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionADRYAN)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_VERIFICAR_TRABAJADOR_ACTIVO"
            With .Parameters
                .Clear()
                .Add("@NUMERODOCUMENTO", SqlDbType.VarChar, 20).Value = numerodocumento
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
    Public Function GetEmpleadoActivoMccentral(ByVal numerodocumento As String) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_VERIFICAR_EMPLEADO_ACTIVO"
            With .Parameters
                .Clear()
                .Add("@NUMERODOCUMENTO", SqlDbType.VarChar, 20).Value = numerodocumento
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



#End Region


#Region "RENOVACION"
#End Region


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

    Public Function RegistrarCeseAdryan(BE As CeseBE) As Boolean
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
                .Add("@REINGRESO", SqlDbType.Bit).Value = BE.ESTADOREINGRESO
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

    Public Function RegistrarCesePersonal(BE As EmpleadoCeseBE) As Boolean
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
    Public Function GetEmpleadoCeseID(ByVal IDSOLICITUDCESE As Integer) As EmpleadoCeseBE
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
                    With EmpleadoCeseBE

                        .IDSOLICITUDCESE = dr.ReadNullAsNumeric("IDSOLICITUDCESE")
                        .NUMEROSOLICITUD = dr.ReadNullAsEmptyString("NUMEROSOLICITUDCESE")
                        .IDEMPLEADO = dr.ReadNullAsNumeric("IDEMPLEADO")
                        .SOLICITANTE = dr.ReadNullAsEmptyString("SOLICITANTENOMBRE")
                        .MOTIVO = dr.ReadNullAsEmptyString("MOTIVOGENERAL")
                        .LOCAL = dr.ReadNullAsNumeric("RAZONCOMERCIAL")
                        .EMPLEADO = dr.ReadNullAsEmptyString("EMPLEADONOMBRE")
                        .CARGOEMPLEADO = dr.ReadNullAsEmptyString("CARGOEMPLEADO")
                        .PERMANENCIA = dr.ReadNullAsEmptyString("PERMANENCIA")
                        .AMPLIACION = dr.ReadNullAsEmptyString("AMPLIACION")
                        .FECHACESE = dr.ReadNullAsEmptyDate("FECHAFINALCONTRATO")
                        .FECHAENVIOCARTAPREAVISONOTARIA = dr.ReadNullAsEmptyDate("FECHAENVIOCARTAPREAVISONOTARIA")
                        .FECHAENVIOCARTADESPIDONOTARIA = dr.ReadNullAsEmptyDate("FECHAENVIOCARTADESPIDONOTARIA")
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
        Return EmpleadoCeseBE
    End Function

    Public Function GetObtenerEstadoActualEmpleado(ByVal idempleado As Integer) As Integer
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        'Dim Resultado As Integer
        Dim Result As Integer = 0

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_VALIDAR_ESTADOACTUAL_PERSONAL"
            With .Parameters
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = idempleado
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
            Result = dt.Rows(0)("ACTIVO")
            'If Resultado = 1 Then ' 1 NO DEJA SEGIR -- 0 DEJA GUARDAR
            '    Result = 1
            'End If
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function 'OK

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
    Public Function AprobarSolicitudCeseRrhh(ByVal IDSOLICITUDCESE As Int32) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESCE_VALIDAR_RRHH"
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
    Public Function EnvioSolicitudCeseRegistroBaja(ByVal IDSOLICITUDCESE As Int32) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_ENVIO_REGISTRO_BAJA"
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
    Public Function EnvioSolicitudCeseRegistroAdryan(ByVal IDSOLICITUDCESE As Int32) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SOLICITUDCESE_REGISTRO_ADRYAN"
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

    End Function

#End Region


#Region "REINGRESO"

    Public Function GetEmpleadoReingresoList(ByVal FechaInicial As Date, ByVal FechaFinal As Date) As DataTable

        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_REINGRESO_EMPLEADO_LIST"
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
    Public Function InsertaCambioCargoEmpleadoAdryan(BE As EmpleadoBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionADRYAN)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_INSERTA_CAMBIO_CARGO_EMPLEADO"
            With .Parameters
                .Add("@CODIGOUNICO", SqlDbType.NVarChar, 9).Value = BE.CODIGOUNICO
                .Add("@PUESTO_ORGANICA", SqlDbType.NVarChar, 8).Value = BE.ADRYAN_PUESTO_ORGANICA
                .Add("@GRADOSALARIAL", SqlDbType.NVarChar, 3).Value = BE.ADRYAN_GRADOSALARIAL
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
    Public Function InsertaReingresoEmpleadoAdryan(BE As EmpleadoBE, ByVal NumeroContrato As String, ByVal TipoReingreso As Int32) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionADRYAN)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_INSERTA_REINGRESO_EMPLEADO"
            With .Parameters
                .Add("@CODIGOUNICO", SqlDbType.NVarChar, 9).Value = BE.CODIGOUNICO
                .Add("@SUELDO", SqlDbType.Float).Value = BE.SUELDO
                .Add("@PUESTO_ORGANICA", SqlDbType.NVarChar, 8).Value = BE.ADRYAN_PUESTO_ORGANICA
                .Add("@UNIDAD_FUNCIONAL", SqlDbType.NVarChar, 8).Value = BE.ADRYAN_UNIDAD_FUNCIONAL
                .Add("@CODIGOTIPOEMPLEADO", SqlDbType.NVarChar, 1).Value = BE.CODIGOTIPOEMPLEADO
                .Add("@TIPOCONTRATO", SqlDbType.NVarChar, 1).Value = BE.TIPOCONTRATO
                .Add("@REGIMENSALARIAL", SqlDbType.NVarChar, 2).Value = BE.IDREGIMENSALARIAL
                .Add("@FECHAINGRESOCOMPANIA", SqlDbType.Date).Value = BE.FECHAINGRESOCOMPANIA

                .Add("@GRADOSALARIAL", SqlDbType.NVarChar, 3).Value = BE.ADRYAN_GRADOSALARIAL
                .Add("@FECHAFINALCONTRATO", SqlDbType.Date).Value = BE.FECHAFINALCONTRATO
                .Add("@NUMEROCONTRATO", SqlDbType.Char, 10).Value = NumeroContrato
                .Add("@TIPOREINFRESO", SqlDbType.Int).Value = TipoReingreso
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
    Public Function InsertaReingresoEmpleadoCambioRazonSocialAdryan(BE As EmpleadoBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionADRYAN)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "SP_REINGRESO_MES_SIGUIENTE"
            With .Parameters
                .Add("@COMPANIA", SqlDbType.Char, 2).Value = "01"
                .Add("@codigo_unico", SqlDbType.Char, 9).Value = BE.CODIGOUNICO
                .Add("@puesto_organica", SqlDbType.Char, 8).Value = BE.ADRYAN_PUESTO_ORGANICA
                .Add("@unidad_funcional", SqlDbType.Char, 8).Value = BE.ADRYAN_UNIDAD_FUNCIONAL
                .Add("@fecha_reingreso", SqlDbType.DateTime).Value = BE.FECHAINGRESOCOMPANIA
                .Add("@fecha_fin_contrato", SqlDbType.DateTime).Value = BE.FECHAFINALCONTRATO
                .Add("@indicador_indeterminado", SqlDbType.Char, 2).Value = BE.INDICADORINDETERMINADO
                .Add("@sueldo_basico", SqlDbType.Float).Value = BE.SUELDO
                .Add("@regimen_salarial", SqlDbType.Char, 2).Value = BE.IDREGIMENSALARIAL
                .Add("@tipo_contrato", SqlDbType.Char, 1).Value = BE.TIPOCONTRATO
                .Add("@moneda", SqlDbType.Char, 1).Value = BE.SUELDOMONEDA
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

    Public Function InsertaReIngresoPersonal(BE As EmpleadoBE, ByVal NumeroContrato As String, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_REINGRESO_EMPLEADO_INS"
            With .Parameters
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = BE.IDEMPLEADO
                .Add("@SUELDOMONEDA", SqlDbType.NVarChar, 1).Value = BE.SUELDOMONEDA
                .Add("@SUELDO", SqlDbType.Float).Value = BE.SUELDO
                .Add("@IDCARGO", SqlDbType.Int).Value = BE.IDCARGO
                .Add("@IDORGANIGRAMA", SqlDbType.Int).Value = BE.IDORGANIGRAMA
                .Add("@CODIGOTIPOEMPLEADO", SqlDbType.NVarChar, 1).Value = BE.CODIGOTIPOEMPLEADO
                .Add("@TIPOCONTRATO", SqlDbType.VarChar, 2).Value = BE.TIPOCONTRATO
                .Add("@REGIMENSALARIAL", SqlDbType.Int).Value = BE.IDREGIMENSALARIAL
                .Add("@FECHAINGRESOCOMPANIA", SqlDbType.Date).Value = BE.FECHAINGRESOCOMPANIA
                .Add("@FECHAFINALCONTRATO", SqlDbType.Date).Value = BE.FECHAFINALCONTRATO
                .Add("@IDUSUARIOREGISTRO", SqlDbType.Int).Value = BE.IDUSUARIOREGISTRO
                .Add("@CORREO", SqlDbType.NVarChar).Value = BE.CORREOPERSONAL
                .Add("@NUMEROCONTRATO", SqlDbType.Char, 10).Value = NumeroContrato
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


#End Region


#Region "AUMENTO SUELDO"

    Public Function AumentoSueldoEmpleadoAdryan(BE As EmpleadoAumentoSueldoBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionADRYAN)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_AUMENTO_SUELDO_EMPLEADO"
            With .Parameters
                .Add("@CODIGOUNICO", SqlDbType.NVarChar, 9).Value = BE.CODIGOUNICO
                .Add("@CODIGOMOTIVOAUMENTO", SqlDbType.NVarChar, 2).Value = BE.CODIGOAUMENTOSUELDO
                .Add("@FECHAAUMENTO", SqlDbType.Date).Value = BE.FECHAAUMENTO
                .Add("@MONTOAUMENTO", SqlDbType.Float).Value = BE.MONTOAUMENTO
                .Add("@PORCENTAJEAUMENTO", SqlDbType.Float).Value = BE.PORCENTAJEAUMENTO
                .Add("@SUELDONUEVO", SqlDbType.Float).Value = BE.SUELDONUEVO
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

    Public Function InsertaAumentoSueldoPersonal(BE As EmpleadoAumentoSueldoBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_EMPLEADO_INSERTA_AUMENTO_SUELDO"
            With .Parameters
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = BE.IDEMPLEADO
                .Add("@CODIGOMOTIVOAUMENTO", SqlDbType.NVarChar, 2).Value = BE.CODIGOAUMENTOSUELDO
                .Add("@FECHAAUMENTO", SqlDbType.Date).Value = BE.FECHAAUMENTO
                .Add("@SUELDOANTERIOR", SqlDbType.Float).Value = BE.SUELDOANTERIOR
                .Add("@MONTOAUMENTO", SqlDbType.Float).Value = BE.MONTOAUMENTO
                .Add("@PORCENTAJEAUMENTO", SqlDbType.Float).Value = BE.PORCENTAJEAUMENTO
                .Add("@SUELDONUEVO", SqlDbType.Float).Value = BE.SUELDONUEVO
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

#End Region


#Region "DERECHO HABIENTES"


    Public Function ListaAsignacionFamiliarArchivos(ByVal idasignacionfamiliar As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_ASIGNACIONFAMILIAR_LISTA_ARCHIVO"
            With .Parameters
                .Add("@IDASIGNACIONFAMILIAR", SqlDbType.Int).Value = idasignacionfamiliar
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

    Public Function GetAsignacionFamiliarList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_ASIGNACIONFAMILIAR_LIST_PREVIEW_ALL"
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

    Public Function GetAsignacionFamiliarListHistorial(ByVal FechaInicial As Date, ByVal FechaFinal As Date, ByVal TipoReporte As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_ASIGNACIONFAMILIAR_LIST_PREVIEW_ALL_HISTORIAL"
            With .Parameters
                .Clear()
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
    Public Function ListEmpleadosDesprocesadosAsignacionFamiliar(ByVal FechaInicial As Date, ByVal FechaFinal As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_ASIGNACION_FAMILIAL_QUITAR_LIST"
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


    Public Function AsignacionFamiliarHijosList(ByVal LISTIDASIGNACIONFAMILIAR As String) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_ASIGNACIONFAMILIAR_LIST_HIJOS"
            With .Parameters
                .Add("@IDASIGNACIONFAMILIAR", SqlDbType.VarChar).Value = LISTIDASIGNACIONFAMILIAR
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
    Public Function EmpleadosHijosList(ByVal IDEMPLEADOLIST As String) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_HIJOS_EMPLEADO_LISTADO"
            With .Parameters
                .Add("@IDEMPLEADO", SqlDbType.VarChar).Value = IDEMPLEADOLIST
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

    Public Function AsignacionFamiliarHijosHistorialList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_ASIGNACIONFAMILIAR_LIST_HISTORIAL_HIJOS"
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
    Public Function GetAsignacionFamiliarArchivosList(ByVal IDASIGNACIONFAMILIAR As Int32) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_ASIGNACIONFAMILIAR_ARCHIVOS_LIST"
            With .Parameters
                .Add("@IDASIGNACIONFAMILIAR", SqlDbType.Int).Value = IDASIGNACIONFAMILIAR
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
    Public Function AsignacionFamiliarEnvioCorreo(ByVal IDASIGNACIONFAMILIAR As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_ASIGNACION_FAMILIAR_DESPROCESAR_VALIDADO_CORREO"
            With .Parameters
                .Add("@IDASIGNACIONFAMILIAR", SqlDbType.Int).Value = IDASIGNACIONFAMILIAR
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

    Public Function GetAsignacionFamiliarHijosList(ByVal IDASIGNACIONFAMILIAR As Int32) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_ASIGNACIONFAMILIAR_HIJOS_LIST"
            With .Parameters
                .Add("@IDASIGNACIONFAMILIAR", SqlDbType.Int).Value = IDASIGNACIONFAMILIAR
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


    Public Function AsignacionFamiliarHijosUpdate(ByVal BE As EmpleadoDerechoHabienteBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "MCRH_ASIGNACIONFAMILIAR_HIJOS_UPDATE"
            With .Parameters
                .Add("@IDASIGNACIONHIJO", SqlDbType.Int).Value = BE.IDASIGNACIONHIJO
                .Add("@NUMERODOCUMENTO", SqlDbType.NVarChar, 20).Value = BE.DNI
                .Add("@NOMBRES", SqlDbType.NVarChar, 50).Value = BE.NOMBRES
                .Add("@APELLIDOPATERNO", SqlDbType.NVarChar, 30).Value = BE.APELLIDOPATERNO
                .Add("@APELLIDOMATERNO", SqlDbType.NVarChar, 30).Value = BE.APELLIDOMATERNO
                .Add("@FECHANACIMIENTO", SqlDbType.Date).Value = BE.FECHANACIMIENTO
                .Add("@IDSEXO", SqlDbType.Int).Value = BE.IDSEXO
                .Add("@IDTIPOIDENTIDAD", SqlDbType.Int).Value = BE.IDTIPOIDENTIDAD
                '.Add("@TIPODERECHOHABIENTE", SqlDbType.NVarChar, 1).Value = BE.TIPODERECHOHABIENTE
                .Add("@NACIONALIDAD", SqlDbType.NVarChar, 2).Value = BE.NACIONALIDAD
                .Add("@IDUBIGEO", SqlDbType.Int).Value = BE.IDUBIGEO
                .Add("@DIRECCION", SqlDbType.NVarChar, 500).Value = BE.DIRECCION
                .Add("@TREGISTRO", SqlDbType.Bit).Value = BE.TREGISTRO
                .Add("@ESSALUD", SqlDbType.Int).Value = BE.ESSALUD
                .Add("@IDMESEVALUACION", SqlDbType.Int).Value = BE.IDMESEVALUACION
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

    Public Function GetEmpleadoDerechoHabientesList(ByVal IDEMPLEADO As Int32) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_EMPLEADO_DERECHO_HABIENTE_LIST_IDEMPLEADO"
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

    Public Function AsignacionFamiliarRevisado(ByVal IDASIGNACIONFAMILIAR As Int32, ByVal ESTADOASIGNACIONBENEFICIO As String, ByVal IDUSUARIO As Int32) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_ASIGNACIONFAMILIAR_REV"
            With .Parameters
                .Add("@IDASIGNACIONFAMILIAR", SqlDbType.Int).Value = IDASIGNACIONFAMILIAR
                .Add("@ESTADOASIGNACIONBENEFICIO", SqlDbType.Char, 1).Value = ESTADOASIGNACIONBENEFICIO
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
    Public Function ListadoHijosxEmpleado(ByVal IDEMPLEADO As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_LISTADO_HIJOSXEMPLEADO"
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
    Public Function AsignacionFamiliarAdryan(EmpleadoDerechoHabienteBE As EmpleadoDerechoHabienteBE, ByVal USUARIO As String) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionADRYAN)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_ASIGNAR_DERECHO_HABIENTE"
            With .Parameters
                .Add("@CODIGOUNICO", SqlDbType.Char, 9).Value = EmpleadoDerechoHabienteBE.CODIGOUNICO
                .Add("@USUARIO", SqlDbType.VarChar, 20).Value = USUARIO
                .Add("@ESTADOASIGNACION", SqlDbType.Char, 1).Value = EmpleadoDerechoHabienteBE.ESTADOASIGNACIONBENEFICIO
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
    Public Function QuitarAsignacionFamiliarEmpleadoId(ByVal IdEmpleado As Integer, ByVal EstadoAsignacion As String, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_ASIGNACIONFAMILIAR_QUITARBENEFICIOEMPLEADO_ID"
            With .Parameters
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IdEmpleado
                .Add("@ESTADOASIGNACION", SqlDbType.VarChar, 1).Value = EstadoAsignacion
                .Add("@IDUSUARIOREGISTRO", SqlDbType.Int).Value = IdUsuario
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
    Public Function AnulacionFamiliarRevisado(ByVal IDASIGNACIONFAMILIAR As Int32, ByVal IDUSUARIO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_ASIGNACIONFAMILIAR_ANULADORRHH"
            With .Parameters
                .Add("@IDASIGNACIONFAMILIAR", SqlDbType.Int).Value = IDASIGNACIONFAMILIAR
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
    Public Function DesprocesarValidadoFamiliarRevisado(ByVal IDASIGNACIONFAMILIAR As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_DESPROCESAR_VALIDADORRHH"
            With .Parameters
                .Add("@IDASIGNACIONFAMILIAR", SqlDbType.Int).Value = IDASIGNACIONFAMILIAR
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

    Public Function InsertaHijosFamilia(BE As EmpleadoDerechoHabienteBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_EMPLEADO_INSERTA_HIJO"
            With .Parameters
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = BE.IDEMPLEADO
                .Add("@CODIGOUNICO", SqlDbType.Char, 9).Value = BE.CODIGOUNICO
                .Add("@IDASIGNACIONHIJO", SqlDbType.Int).Value = BE.IDASIGNACIONHIJO
                '.Add("@TIPODERECHOHABIENTE", SqlDbType.NVarChar, 1).Value = BE.TIPODERECHOHABIENTE
                .Add("@IDTIPODOCUMENTOIDENTIDAD", SqlDbType.Int).Value = BE.IDTIPOIDENTIDAD
                .Add("@NUMEROIDENTIDAD", SqlDbType.VarChar, 20).Value = BE.DNI
                .Add("@NACIONALIDAD", SqlDbType.NVarChar, 2).Value = BE.NACIONALIDAD
                .Add("@NOMBRES", SqlDbType.VarChar, 100).Value = BE.NOMBRES
                .Add("@APELLIDOPATERNO", SqlDbType.VarChar, 100).Value = BE.APELLIDOPATERNO
                .Add("@APELLIDOMATERNO", SqlDbType.VarChar, 100).Value = BE.APELLIDOMATERNO
                .Add("@FECHANACIMIENTO", SqlDbType.Date).Value = BE.FECHANACIMIENTO
                .Add("@IDSEXO", SqlDbType.Int).Value = BE.IDSEXO
                .Add("@DIRECCION", SqlDbType.NVarChar, 500).Value = BE.DIRECCION
                .Add("@IDUBIGEO", SqlDbType.Int).Value = BE.IDUBIGEO
                .Add("@TREGISTRO", SqlDbType.Int).Value = BE.TREGISTRO
                .Add("@ESSALUD", SqlDbType.Int).Value = BE.ESSALUD
                '  .Add("@RECIBEASIGNACIONFAMILIAR", SqlDbType.Char, 1).Value = BE.ESTADOASIGNACIONBENEFICIO
                .Add("@IDMESEVALUACION", SqlDbType.Int).Value = BE.IDMESEVALUACION
                .Add("@IDUSUARIOREGISTRO", SqlDbType.Int).Value = BE.IDUSUARIOREGISTRO
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

    Public Function InsertaDerechoHabientePersonalAdryan(BE As EmpleadoDerechoHabienteBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionADRYAN)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_INSERTA_DERECHO_HABIENTE_EMPLEADO"
            With .Parameters
                .Add("@CODIGOUNICO", SqlDbType.NVarChar, 9).Value = BE.CODIGOUNICO
                .Add("@TIPODERECHOHABIENTE", SqlDbType.NVarChar, 1).Value = BE.TIPODERECHOHABIENTE
                .Add("@APELLIDOPATERNO", SqlDbType.NVarChar, 30).Value = BE.APELLIDOPATERNO
                .Add("@APELLIDOMATERNO", SqlDbType.NVarChar, 30).Value = BE.APELLIDOMATERNO
                .Add("@NOMBRES", SqlDbType.NVarChar, 50).Value = BE.NOMBRES
                .Add("@SEXO", SqlDbType.NVarChar, 1).Value = BE.IDSEXO
                .Add("@TIPO_DOCUMENTO", SqlDbType.NVarChar, 2).Value = BE.ADRYAN_TIPOIDENTIDAD
                .Add("@NUMEROIDENTIDAD", SqlDbType.VarChar, 20).Value = BE.DNI
                .Add("@FECHANACIMIENTO", SqlDbType.Date).Value = BE.FECHANACIMIENTO
                .Add("@NACIONALIDAD", SqlDbType.NVarChar, 2).Value = BE.NACIONALIDAD
                .Add("@USUARIOREGISTRO", SqlDbType.NVarChar, 10).Value = BE.USUARIOREGISTRO
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


    Public Function InsertAsignacionFamiliar(ByVal IDEMPLEADO As Int32, ByVal IDUSUARIOREGISTRO As Int32, ByVal dt As DataTable, ByVal IDORGANIGRAMA As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .CommandText = "MCRH_ASIGNACIONFAMILIAR_INS"
            .CommandTimeout = 0
            .CommandType = CommandType.StoredProcedure
            .Connection = cnx
            .Parameters.Add("@IDASIGNACIONFAMILIAR", SqlDbType.Int).Value = 0
            .Parameters.Add("@NUMEROSOLICITUD", SqlDbType.NVarChar, 18).Value = ""
            .Parameters.Add("@IDORGANIGRAMA", SqlDbType.Int).Value = IDORGANIGRAMA
            .Parameters.Add("@FECHA", SqlDbType.Date).Value = Date.Now
            .Parameters.Add("@IDSOLICITANTE", SqlDbType.Int).Value = IDEMPLEADO
            .Parameters.Add("@FECHAINGRESO", SqlDbType.Date).Value = Date.Now
            .Parameters.Add("@NUMEROHIJOS", SqlDbType.Int).Value = dt.Rows.Count
            .Parameters.Add("@OTROSANEXOS", SqlDbType.NVarChar).Value = ""
            .Parameters.Add("@USUREGISTRO", SqlDbType.Int).Value = IDUSUARIOREGISTRO
            .Parameters.Add("@FECHAREGISTRO", SqlDbType.DateTime).Value = Date.Now
            .Parameters.Add("@NOMBREARCHIVO", SqlDbType.NVarChar).Value = ""
            .Parameters.Add("@RUTAARCHIVO", SqlDbType.NVarChar).Value = ""
            .Parameters.Add("@ESTADOBLOQUEO", SqlDbType.Int).Value = 1
            .Parameters.Add("@ESTADOREVISADO", SqlDbType.Int).Value = 0
            .Parameters.Add("@LINKDESCARGA", SqlDbType.NVarChar).Value = ""
            .Parameters.Add("@RETORNAIDASIGNACIONFAMILIAR", SqlDbType.Int).Value = 0
            '.Parameters.Add("@FUENTEREGISTRO", SqlDbType.Int).Value = 2 ' 1= FUE REGISTRADO DESDE LA PCA, 2= FUE REGISTRADO DESDE EL SGRH
        End With
        cmd.Parameters("@RETORNAIDASIGNACIONFAMILIAR").Direction = ParameterDirection.Output

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim cmdd As New SqlCommand
                    With cmdd
                        .Connection = cnx
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "[MCRH_ASIGNACIONFAMILIAR_NUEVOEMPLEADO_INS_DETALLEHIJOS]"

                        With .Parameters
                            .Add("@IDASIGNACIONFAMILIAR", SqlDbType.Int).Value = cmd.Parameters("@RETORNAIDASIGNACIONFAMILIAR").Value.ToString()
                            .Add("IDTIPODOCUMENTOIDENTIDAD", SqlDbType.Int).Value = dt.Rows(i).Item("IDTIPOIDENTIDAD")
                            .Add("@IDEMPLEADO", SqlDbType.Int).Value = IDEMPLEADO
                            .Add("@NUMERODOCUMENTO", SqlDbType.NVarChar, 50).Value = dt.Rows(i).Item("DNI")
                            .Add("@NOMBRES", SqlDbType.NVarChar, 50).Value = dt.Rows(i).Item("NOMBRES")
                            .Add("@APELLIDOPATERNO", SqlDbType.NVarChar, 50).Value = dt.Rows(i).Item("APELLIDOPATERNO")
                            .Add("@APELLIDOMATERNO", SqlDbType.NVarChar, 50).Value = dt.Rows(i).Item("APELLIDOMATERNO")
                            .Add("@FECHANACIMIENTO", SqlDbType.Date).Value = dt.Rows(i).Item("FECHANACIMIENTO")
                            .Add("@IDSEXO", SqlDbType.Int).Value = dt.Rows(i).Item("IDSEXO")
                            '--------
                            .Add("@IDUSUARIOREGISTRO", SqlDbType.NVarChar).Value = IDUSUARIOREGISTRO
                            .Add("@NACIONALIDAD", SqlDbType.NVarChar).Value = dt.Rows(i).Item("NACIONALIDAD")
                            .Add("@IDUBIGEO", SqlDbType.Int).Value = dt.Rows(i).Item("IDUBIGEO")
                            .Add("@DIRECCION", SqlDbType.NVarChar).Value = dt.Rows(i).Item("DIRECCION")
                            .Add("@TREGISTRO", SqlDbType.Bit).Value = dt.Rows(i).Item("TREGISTRO")
                            .Add("@ESSALUD", SqlDbType.Bit).Value = dt.Rows(i).Item("ESSALUD")
                            '.Add("@IDMESEVALUACION", SqlDbType.Int).Value = dt.Rows(i).Item("IDMESEVALUACION")
                            '--------
                        End With
                        If cmdd.ExecuteNonQuery() > 0 Then
                            Result = True
                        End If

                    End With
                Next

                Result = True
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return Result
    End Function

    Public Function GetByAsignacionFamiliarID(ByVal IDASIGNACIONFAMILIAR As Int32) As EmpleadoDerechoHabienteBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_EMPLEADO_DERECHO_HABIENTE_GET_ID"
            With .Parameters
                .Clear()
                .Add("@IDDERECHOHABIENTE", SqlDbType.Int).Value = IDASIGNACIONFAMILIAR
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With EmpleadoDerechoHabienteBE
                        .IDDERECHOHABIENTE = dr.ReadNullAsNumeric("IDDERECHOHABIENTE")
                        .TIPODERECHOHABIENTE = dr.ReadNullAsNumeric("TIPODERECHOHABIENTE")
                        .IDEMPLEADO = dr.ReadNullAsNumeric("IDEMPLEADO")
                        .NOMBRES = dr.ReadNullAsEmptyString("NOMBRES")
                        .APELLIDOPATERNO = dr.ReadNullAsEmptyString("APELLIDOPATERNO")
                        .APELLIDOMATERNO = dr.ReadNullAsEmptyString("APELLIDOMATERNO")
                        .IDTIPOIDENTIDAD = dr.ReadNullAsNumeric("IDTIPOIDENTIDAD")
                        .DNI = dr.ReadNullAsEmptyString("DNI")
                        .FECHANACIMIENTO = dr.ReadNullAsEmptyDate("FECHANACIMIENTO")
                        .IDUBIGEO = dr.ReadNullAsNumeric("IDUBIGEO")
                        .IDSEXO = dr.ReadNullAsNumeric("IDSEXO")
                        .NACIONALIDAD = dr.ReadNullAsEmptyString("NACIONALIDAD")
                        .DIRECCION = dr.ReadNullAsEmptyString("DIRECCION")
                        .TREGISTRO = dr.ReadNullAsBoolean("TREGISTRO")
                        .ESSALUD = dr.ReadNullAsBoolean("ESSALUD")
                        .CODIGOUNICO = dr.ReadNullAsEmptyString("CODIGOUNICO")
                        .NOMBREEMPLEADO = dr.ReadNullAsEmptyString("NOMBREEMPLEADO")
                        .APELLIDOPATERNOEMPLEADO = dr.ReadNullAsEmptyString("APELLIDOPATERNOEMPLEADO")
                        .APELLIDOMATERNOEMPLEADO = dr.ReadNullAsEmptyString("APELLIDOMATERNOEMPLEADO")
                        .NUMERODOCUMENTOEMPLEADO = dr.ReadNullAsEmptyString("NUMERODOCUMENTOEMPLEADO")
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
        Return EmpleadoDerechoHabienteBE
    End Function

    Public Function UpdateDerechoHabientePersonal(BE As EmpleadoDerechoHabienteBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_EMPLEADO_UPDATE_DERECHO_HABIENTE"
            With .Parameters
                .Add("@IDDERECHOHABIENTE", SqlDbType.Int).Value = BE.IDDERECHOHABIENTE
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = BE.IDEMPLEADO
                .Add("@TIPODERECHOHABIENTE", SqlDbType.NVarChar, 1).Value = BE.TIPODERECHOHABIENTE
                .Add("@IDTIPOIDENTIDAD", SqlDbType.Int).Value = BE.IDTIPOIDENTIDAD
                .Add("@NUMEROIDENTIDAD", SqlDbType.VarChar, 20).Value = BE.DNI
                .Add("@NACIONALIDAD", SqlDbType.NVarChar, 2).Value = BE.NACIONALIDAD
                .Add("@NOMBRES", SqlDbType.VarChar, 100).Value = BE.NOMBRES
                .Add("@APELLIDOPATERNO", SqlDbType.VarChar, 100).Value = BE.APELLIDOPATERNO
                .Add("@APELLIDOMATERNO", SqlDbType.VarChar, 100).Value = BE.APELLIDOMATERNO
                .Add("@FECHANACIMIENTO", SqlDbType.Date).Value = BE.FECHANACIMIENTO
                .Add("@IDSEXO", SqlDbType.Int).Value = BE.IDSEXO
                .Add("@DIRECCION", SqlDbType.NVarChar, 500).Value = BE.DIRECCION
                .Add("@IDUBIGEO", SqlDbType.Int).Value = BE.IDUBIGEO
                .Add("@TREGISTRO", SqlDbType.Int).Value = BE.TREGISTRO
                .Add("@ESSALUD", SqlDbType.Int).Value = BE.ESSALUD
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

#End Region


#Region "MOVIMIENTO EMPLEADO"
    Public Function GetObtenerVacanteAdryan(BE As EmpleadoMovimientoBE) As Integer
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionADRYAN)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim Resultado As Integer
        Dim Result As Integer = 0

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_MOVIMIENTO_VERIFICAR_VACANTE"
            With .Parameters
                .Add("@PUESTO_ORGANICA", SqlDbType.NVarChar, 8).Value = BE.ADRYAN_PUESTO_ORGANICA
                .Add("@UNIDAD_FUNCIONAL", SqlDbType.NVarChar, 8).Value = BE.ADRYAN_UNIDAD_FUNCIONAL
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
            Resultado = dt.Rows(0)("RESULTADO")

            If Resultado = 1 Then ' 1 NO DEJA SEGIR -- 0 DEJA GUARDAR
                Result = 1
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

    Public Function InsertaMovimientoEmpleadoAdryan(BE As EmpleadoMovimientoBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionADRYAN)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_MOVIMIENTO_EMPLEADO"
            With .Parameters
                .Add("@CODIGOUNICO", SqlDbType.NVarChar, 9).Value = BE.CODIGOUNICO
                .Add("@CODIGOCATEGORIA", SqlDbType.NVarChar, 3).Value = BE.CODIGOCATEGORIA
                .Add("@PUESTO_ORGANICA", SqlDbType.NVarChar, 8).Value = BE.ADRYAN_PUESTO_ORGANICA
                .Add("@UNIDAD_FUNCIONAL", SqlDbType.NVarChar, 8).Value = BE.ADRYAN_UNIDAD_FUNCIONAL
                '.Add("@CODIGOUBICACIONFISICA", SqlDbType.NVarChar, 7).Value = BE.CODIGOUBICACIONFISICA
                '.Add("@FECHAINICIOCAMBIO", SqlDbType.Date).Value = BE.FECHAINICIOCAMBIO
                .Add("@FECHAEFECTIVAMOVIMIENTO", SqlDbType.Date).Value = BE.FECHAEFECTIVAMOVIMIENTO
                .Add("@TIPOMOVIMIENTO", SqlDbType.NVarChar, 1).Value = BE.CODIGOTIPOMOVIMIENTO
                .Add("@OBSERVACION", SqlDbType.NVarChar, 80).Value = BE.OBSERVACION
                .Add("@GRADOSALARIAL", SqlDbType.NVarChar, 8).Value = BE.ADRYAN_GRADO_SALARIAL
                Try
                    cnx.Open()
                    If cmd.ExecuteNonQuery() > 0 Then
                        Empleado_CodigoUnico = cmd.Parameters("@CODIGOUNICO").Value
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
    End Function

    Public Function InsertaMovimientoPersonal(BE As EmpleadoMovimientoBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_EMPLEADO_INSERTA_MOVIMIENTO"
            With .Parameters
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = BE.IDEMPLEADO
                .Add("@TIPOMOVIMIENTO", SqlDbType.VarChar, 1).Value = BE.CODIGOTIPOMOVIMIENTO
                .Add("@IDLOCALANTES", SqlDbType.Int).Value = BE.IDLOCALANTES
                .Add("@IDCARGOANTES", SqlDbType.Int).Value = BE.IDCARGOANTES
                .Add("@CODIGOCATEGORIAANTES", SqlDbType.NVarChar, 3).Value = BE.CODIGOCATEGORIAANTES
                .Add("@CODIGOUBICACIONFISICAANTES", SqlDbType.NVarChar, 7).Value = BE.CODIGOUBICACIONFISICAANTES
                .Add("@FECHAINICIOCAMBIO", SqlDbType.Date).Value = BE.FECHAINICIOCAMBIO
                .Add("@FECHAEFECTIVAMOVIMIENTO", SqlDbType.Date).Value = BE.FECHAEFECTIVAMOVIMIENTO
                .Add("@IDLOCAL", SqlDbType.Int).Value = BE.IDLOCAL
                .Add("@IDCARGO", SqlDbType.Int).Value = BE.IDCARGO
                .Add("@CODIGOCATEGORIA", SqlDbType.NVarChar, 3).Value = BE.CODIGOCATEGORIA
                .Add("@CODIGOUBICACIONFISICA", SqlDbType.NVarChar, 7).Value = BE.CODIGOUBICACIONFISICA
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
    Public Function GetCargarMotivoCambioList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MOTIVO_CAMBIOCARGO_LIST"
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


#Region "Historial de Empleado"
    Public Function GetEmpleadoHistorialFamilia(ByVal IdEmpleado As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_EMPLEADO_FAMILIA"
            With .Parameters
                .Clear()
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IdEmpleado
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            'Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
    Public Function GetEmpleadoHistorialList(ByVal IdEmpleado As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_HISTORIALLICENCIA_GENERAL_EMPLEADO"
            With .Parameters
                .Clear()
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IdEmpleado
            End With
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            'Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
    Public Function GetEmpleadoHistorialContratosList(ByVal IdEmpleado As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_HISTORIALCONTRATOS_GENERAL_EMPLEADO"
            With .Parameters
                .Clear()
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IdEmpleado
            End With
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            'Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetEmpleadoHistorialRenuncia(ByVal IdEmpleado As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_HISTORIALRENUNCIA_GENERAL_EMPLEADO"
            With .Parameters
                .Clear()
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IdEmpleado
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            'Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
    Public Function GetEmpleadoHistorialCese(ByVal IdEmpleado As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_HISTORIALCESE_GENERAL_EMPLEADO"
            With .Parameters
                .Clear()
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IdEmpleado
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            'Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
    Public Function GetEmpleadoHistorialCambioDefinitivo(ByVal IdEmpleado As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_HISTORIALCAMBIODEFINITIVO_GENERAL_EMPLEADO"
            With .Parameters
                .Clear()
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IdEmpleado
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            'Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetEmpleadoHistorialCambioTemporal(ByVal IdEmpleado As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_HISTORIALCAMBIOTEMPORAL_GENERAL_EMPLEADO"
            With .Parameters
                .Clear()
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IdEmpleado
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            'Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetEmpleadoHistorialMemorandum(ByVal IdEmpleado As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_HISTORIALMEMORANDUM_GENERAL_EMPLEADO"
            With .Parameters
                .Clear()
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IdEmpleado
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            'Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
    Public Function GetEmpleadoHistorialPrestamos(ByVal IdEmpleado As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_HISTORIALPRESTAMOS_GENERAL_EMPLEADO"
            With .Parameters
                .Clear()
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IdEmpleado
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            'Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
    Public Function GetEmpleadoHistorialVacaciones(ByVal IdEmpleado As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_HISTORIALVACACIONES_GENERAL_EMPLEADO"
            With .Parameters
                .Clear()
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IdEmpleado
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            'Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
    Public Function GetEmpleadoHistorialLactancia(ByVal IdEmpleado As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_HISTORIALLACTANCIA_GENERAL_EMPLEADO"
            With .Parameters
                .Clear()
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IdEmpleado
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            'Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetEmpleadoHistorialAsignacionFamiliar(ByVal IdEmpleado As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_HISTORIALASIGNACIONFAMILIAR_GENRAL_EMPLEADO"
            With .Parameters
                .Clear()
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IdEmpleado
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            'Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetEmpleadoHistorialIncidenteAccidente(ByVal IdEmpleado As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_HISTORIALINCIDENTEACCIDENTE_GENRAL_EMPLEADO"
            With .Parameters
                .Clear()
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IdEmpleado
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            'Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
    Public Function GetEmpleadoHistorialMarcacion(ByVal CodigoUnico As String, ByVal FechaInicial As Date, ByVal FechaFinal As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionADRYAN)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRM_REPORTERRHH1"
            With .Parameters
                .Clear()
                .Add("@Lista", SqlDbType.NVarChar).Value = CodigoUnico
                .Add("@FECHAINICIAL", SqlDbType.Date).Value = FechaInicial
                .Add("@FECHAFINAL", SqlDbType.Date).Value = FechaFinal
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            'Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
    Public Function GetEmpleadoHistorialCartaCorrectiva(ByVal IdEmpleado As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CARTA_INFORMATIVA_HISTORICO_GETIDEMPLEADO"
            With .Parameters
                .Clear()
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IdEmpleado
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            'Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function HistoricoEscuelaGetIdEmpleado(ByVal IdEmpleado As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_ESCUELA_GET_IDEMPLEADO"
            With .Parameters
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IdEmpleado
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




    Public Function CargaMasivaCampos(ByVal idformato As Int32) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_FORMATO_EXP_CAMPOS_LIST"
            With .Parameters
                .Add("@IDFORMATO", SqlDbType.Int).Value = idformato
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


    Public Function UpdataNumeroCuentasAdryan(ByVal queryupd As String) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionADRYAN)
        Dim Result As Integer
        Dim Script As New StringBuilder
        Dim Query As String = String.Format(queryupd)
        Dim Valor As Boolean

        Script.Clear()
        Script.AppendLine(String.Format(Query))

        Try
            Dim cmd = New SqlCommand
            With cmd
                cnx.Open()

                .Connection = cnx
                .CommandType = CommandType.Text
                .CommandText = Script.ToString()
                Result = .ExecuteNonQuery()
                If (Result > 0) Then
                    Valor = True
                Else 'SI ES ERROR
                    Valor = False
                End If

                cnx.Close()
            End With
        Catch ex As Exception
            'Throw (ex.Message.ToString)
        End Try

        Return Valor
    End Function
    Public Function UpdataNumeroCuentasCentral(ByVal queryupd As String) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim Result As Integer
        Dim Script As New StringBuilder
        Dim Query As String = String.Format(queryupd)
        Dim Valor As Boolean

        Script.Clear()
        Script.AppendLine(String.Format(Query))

        Try
            Dim cmd = New SqlCommand
            With cmd
                cnx.Open()

                .Connection = cnx
                .CommandType = CommandType.Text
                .CommandText = Script.ToString()
                Result = .ExecuteNonQuery()
                If (Result > 0) Then
                    Valor = True
                Else 'SI ES ERROR
                    Valor = False
                End If

                cnx.Close()
            End With
        Catch ex As Exception

        End Try

        Return Valor
    End Function

    Public Function DameIDBancoCemtral(ByVal IdBancoAdryan As String) As Integer
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim Valor As String = 0
        Try
            Dim reader As SqlDataReader
            Dim cmd = New SqlCommand
            With cmd
                cnx.Open()

                .Connection = cnx
                .CommandType = CommandType.Text
                .CommandText = "select idbanco from mc_banco where codigo = '" + IdBancoAdryan + "'"
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
    Public Function DameIDTipoCuenta(ByVal tipocuenta As String) As String
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim Valor As String = ""
        Try
            Dim reader As SqlDataReader
            Dim cmd = New SqlCommand
            With cmd
                cnx.Open()

                .Connection = cnx
                .CommandType = CommandType.Text
                .CommandText = "select idtipocuentaabono from MC_TIPO_CUENTA_ABONO where codigoadryan = '" + tipocuenta + "'"
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
    Public Function ConsultaMatriculaEmpleadoExistente(ByVal matricula As String) As String
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim Valor As String = ""
        Try
            Dim reader As SqlDataReader
            Dim cmd = New SqlCommand
            With cmd
                cnx.Open()

                .Connection = cnx
                .CommandType = CommandType.Text
                .CommandText = "select matricula from mc_empleado where matricula= '" + matricula + "'"
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





End Class
