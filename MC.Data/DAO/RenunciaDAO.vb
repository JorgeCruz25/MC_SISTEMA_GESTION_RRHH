Imports System.Data.SqlClient

Public Class RenunciaDAO
    Dim RenunciasBE As New RenunciasBE
    Public IdRenuncia As Integer
    Public Function SolicitudRenunciasListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_RENUNCIA_LIST_PREVIEW_ALL"
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
    Public Function SolicitudRenunciasListArchivo(ByVal IDRENUNCIA As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_RENUNCIA_LISTA_ARCHIVO"
            With .Parameters
                .Add("@IDRENUNCIA", SqlDbType.Int).Value = IDRENUNCIA
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
    Public Function SolicitudRenunciasLitIdEmpleado(ByVal IDEMPLEADO As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_RENUNCIA_LISTA_IDEMPLEADO"
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
    Public Function GetRenunciaByID(ByVal IDRENUNCIA As Integer) As RenunciasBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_RENUNCIA_GET_BY_ID"
            With .Parameters
                .Add("@IDRENUNCIA", SqlDbType.Int).Value = IDRENUNCIA
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With RenunciasBE

                        .IdRenuncia = dr.ReadNullAsNumeric("IDRENUNCIA")
                        .NumeroCarta = dr.ReadNullAsEmptyString("NUMEROCARTA")
                        .IdLocal = dr.ReadNullAsNumeric("IDLOCAL")
                        .RazonSocial = dr.ReadNullAsEmptyString("RAZONSOCIAL")
                        .RazonComercial = dr.ReadNullAsEmptyString("RAZONCOMERCIAL")
                        .Fecha = dr.ReadNullAsEmptyDate("FECHA")
                        .IdSolicitante = dr.ReadNullAsNumeric("IDSOLICITANTE")
                        .EmpleadoNombre = dr.ReadNullAsEmptyString("EMPLEADONOMBRE")
                        .FechaUltimoDiaTrabajo = dr.ReadNullAsEmptyDate("FECHAULTIMODIATRABAJO")
                        .CargoSolicitante = dr.ReadNullAsEmptyString("EMPLEADOCARGO")
                        .EmpleadoDni = dr.ReadNullAsEmptyString("EMPLEADODNI")
                        .CodigoUnico = dr.ReadNullAsEmptyString("CODIGOUNICO")
                        .CodigoCese = dr.ReadNullAsEmptyString("CODIGOCESE")
                        .Observacion = dr.ReadNullAsEmptyString("OBSERVACION")
                        .PagoDiasBoleta = dr.ReadNullAsBoolean("PAGODIASBOLETA")
                        .FechaFinalContrato = dr.ReadNullAsEmptyDate("FECHAFINALCONTRATO")
                        .EstadoReingreso = dr.ReadNullAsBoolean("ESTADOREINGRESO")

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
        Return RenunciasBE
    End Function
    'Public Function GuardarCartaRenunciaByID(ByVal IDRENUNCIA As Integer, ByVal FECHAFINLABORAR As Date) As Boolean
    Public Function GuardarCartaRenunciaByID(BE As RenunciasBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_UPDATE_FECHAFINLAGORAL"
            With .Parameters
                .Add("@IDRENUNCIA", SqlDbType.Int).Value = BE.IdRenuncia
                .Add("@CODIGOCESE", SqlDbType.NVarChar).Value = BE.CodigoCese
                .Add("@OBSERVACION", SqlDbType.NVarChar).Value = BE.Observacion
                .Add("@FECHAULTIMODIATRABAJO", SqlDbType.Date).Value = BE.FechaUltimoDiaTrabajo
                .Add("@PAGODIASBOLETA", SqlDbType.Bit).Value = BE.PagoDiasBoleta
                .Add("@ESTADOREINGESO", SqlDbType.Bit).Value = BE.EstadoReingreso
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
    Public Function InsertaCarataRenunciaFormato(ByVal id As Integer, ByVal idlocal As Integer, ByVal nombrearchivo As String, ByVal ruta As String, ByVal link As String) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_RENUNCIA_INSERTA_ARCHIVO"
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
    Public Function RegistrarCesePersonal(BE As RenunciasBE) As Boolean  'Registra en cese en tiempo real
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_RENUNCIA_UPDATE_RRHH"
            With .Parameters
                .Add("@IDRENUNCIA", SqlDbType.Int).Value = BE.IdRenuncia
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = BE.IdSolicitante
                .Add("@CODIGOCESE", SqlDbType.NVarChar, 3).Value = BE.CodigoCese
                .Add("@FECHACESE", SqlDbType.Date).Value = BE.FechaUltimoDiaTrabajo
                .Add("@PAGODIASBOLETA", SqlDbType.Bit).Value = BE.PagoDiasBoleta
                .Add("@OBSERVACION", SqlDbType.NVarChar, 80).Value = BE.Observacion
                .Add("@IDUSUARIOREGISTRO", SqlDbType.Int).Value = BE.IdUsuarioRegistro
                .Add("@ESTADOREINGESO", SqlDbType.Bit).Value = BE.EstadoReingreso
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

    Public Function SolicitudRenunciasListHistorialAll(ByVal FechaInicial As Date, ByVal FechaFinal As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_RENUNCIAS_LIST_PREVIEW_ALL_HISTORIAL"
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

    Public Function AnularCartaRenunciaByID(ByVal IDRENUNCIA As Integer, ByVal IDUSUARIO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_RENUNCIA_ANULAR_BY_ID"
            With .Parameters
                .Add("@IDRENUNCIA", SqlDbType.Int).Value = IDRENUNCIA
                .Add("@IDUSUARIOANULADO", SqlDbType.Int).Value = IDUSUARIO
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

    Public Function ValidarSolicitudesRenunciaPorProcesar(ByVal idempleado As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_VALIDAR_RENUNCIA_PORPROCESAR_INS"
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
    Public Function ValidarCartaRenunciasPendientes(ByVal idempleado As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_VALIDAR_RENUNCIAS_PENDIENTES_INS"
            With .Parameters
                .Clear()
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = idempleado
            End With
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
            'If dt.Rows(0)("") Then

            'End If


        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

End Class
