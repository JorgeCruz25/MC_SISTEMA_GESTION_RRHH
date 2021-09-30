Imports System.Data.SqlClient

Public Class PrestamoDAO
    Dim PrestamosBE As New PrestamosBE

    Public IdPrestamo As Integer

#Region "LISTADOS"

    Public Function ListTipoPago() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PRESTAMO_TIPO_PAGO_LIST"

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
    End Function ''ok

    Public Function ListMedioPago() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PRESTAMO_MEDIO_PAGO_LIST"
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
    End Function ''ok

    Public Function ListarBanco() As DataTable
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
    Public Function ListarMotivo() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PRESTAMO_MOTIVO_LIST"
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
    Public Function GetHistorialMemorandumByID(ByVal IDEMPLEADO As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_HISTORIAL_MEMORANDUN_GET_IDEMPLEADO"
            With .Parameters
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IDEMPLEADO
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
        End With
        Return dt
    End Function '''''para correr esta funcion se necesita del memorandum

    Public Function GetHistorialPrestamosByID(ByVal IDEMPLEADO As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_HISTORIAL_PRESTAMOS_GET_IDEMPLEADO"
            With .Parameters
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IDEMPLEADO
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
        End With
        Return dt
    End Function ''ok

    Public Function GetHistorialLicenciasByID(ByVal IDEMPLEADO As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_HISTORIAL_LICENCIAS_GET_IDEMPLEADO"
            With .Parameters
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IDEMPLEADO
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
        End With
        Return dt
    End Function ''ok

#End Region


    Public Function GetByAllPrestamos() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PRESTAMO_LIST_PREVIEW_ALL"
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

    Public Function GetPrestamosArchivo(ByVal IDPRESTAMO As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PRESTAMO_LISTA_ARCHIVO"
            With .Parameters
                .Add("@IDPRESTAMO", SqlDbType.Int).Value = IDPRESTAMO
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

    Public Function GetPrestamoByID(ByVal IDPRESTAMO As Int32) As PrestamosBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PRESTAMO_GET_ID"
            With .Parameters
                .Add("@IDPRESTAMO", SqlDbType.Int).Value = IDPRESTAMO
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With PrestamosBE
                        .IdPrestamos = dr.ReadNullAsNumeric("IDPRESTAMO")
                        .NumeroSolicitud = dr.ReadNullAsEmptyString("NUMEROSOLICITUD")
                        .IdEmpleado = dr.ReadNullAsNumeric("IDEMPLEADO")
                        .Nombres = dr.ReadNullAsEmptyString("NOMBRES")
                        .ApellidoPaterno = dr.ReadNullAsEmptyString("APELLIDOPATERNO")
                        .ApellidoMaterno = dr.ReadNullAsEmptyString("APELLIDOMATERNO")
                        .IdLocal = dr.ReadNullAsNumeric("IDLOCAL")
                        .Cargo = dr.ReadNullAsEmptyString("CARGO")
                        .DNI = dr.ReadNullAsEmptyString("NUMERODOCUMENTO")

                        .Fecha = dr.ReadNullAsEmptyDate("FECHA")

                        .RazonSocial = dr.ReadNullAsEmptyString("RAZONSOCIAL")
                        .RazonComercial = dr.ReadNullAsEmptyString("RAZONCOMERCIAL")
                        .IdMotivoPrestamo = dr.ReadNullAsNumeric("IDMOTIVOPRESTAMO")
                        .MotivoPrestamo = dr.ReadNullAsEmptyString("MOTIVO")
                        .Monto = dr.ReadNullAsNumeric("MONTO")
                        .IdTipoPago = dr.ReadNullAsNumeric("IDTIPOPAGO")
                        .IdMedioPago = dr.ReadNullAsNumeric("IDMEDIOPAGO")
                        .MontoAprobado = dr.ReadNullAsNumeric("MONTOAPROBADO")
                        .MontoDescuento = dr.ReadNullAsNumeric("MONTODESCUENTO")
                        .PorcentajeGratificacionDescuento = dr.ReadNullAsNumeric("PORCENTAJEGRATIFICACIONDESCUENTO")
                        .EstadoValidadoRrhh = dr.ReadNullAsNumeric("ESTADOVALIDADORRHH")
                        .Solicitante = dr.ReadNullAsEmptyString("SOLICITANTE")
                        .FechaIngresoCorporativo = dr.ReadNullAsEmptyDate("FECHAINGRESOCORPORACION")
                        .FechaIngresoLocal = dr.ReadNullAsEmptyString("FECHAINGRESO")
                        .DescripcionPrestamoSolicitud = dr.ReadNullAsEmptyString("DESCRICIONPRESTAMOSOLICITUD")
                        .DescripcionPrestamoRrhh = dr.ReadNullAsEmptyString("DESCRIPCIONRRHH")
                        .MontoVacacionesDescuento = dr.ReadNullAsNumeric("MONTOVACACIONESDESCUENTO")
                        .MontoLiquidacionDescuento = dr.ReadNullAsNumeric("MONTOLIQUIDACIONDESCUENTO")
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
        Return PrestamosBE

    End Function 'ok

    Public Function UpdatePrestamoEvaluacionRRHH(BE As PrestamosBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_UPDATE_PRESTAMO_EVALUACION_RRHH"
            With .Parameters
                .Add("@IDPRESTAMO", SqlDbType.Int).Value = BE.IdPrestamos
                .Add("@IDTIPOPAGO", SqlDbType.Int).Value = BE.IdTipoPago
                .Add("@IDMEDIOPAGO", SqlDbType.Int).Value = BE.IdMedioPago
                .Add("@PORCENTAJEGRATIFICACIONDESCUENTO", SqlDbType.Float).Value = BE.PorcentajeGratificacionDescuento
                .Add("@MONTODESCUENTO", SqlDbType.Float).Value = BE.MontoDescuento
                .Add("@MONTOAPROBADO", SqlDbType.Float).Value = BE.MontoAprobado
                .Add("@IDMOTIVO", SqlDbType.Int).Value = BE.IdMotivoPrestamo
                .Add("@MONTOVACACIONESDESCUENTO", SqlDbType.Float).Value = BE.MontoVacacionesDescuento
                .Add("@MONTOLIQUIDACIONDESCUENTO", SqlDbType.Float).Value = BE.MontoLiquidacionDescuento
                .Add("@DESCRIPCIONRRHH", SqlDbType.NVarChar, 1000).Value = BE.DescripcionPrestamoRrhh
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

    Public Function UpdatePrestamoRevisionRRHH(BE As PrestamosBE, ByVal IDUSUARIO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_UPDATE_PRESTAMO_REVISION_RRHH"
            With .Parameters
                .Add("@IDPRESTAMO", SqlDbType.VarChar, 50).Value = BE.IdPrestamos
                .Add("@IDTIPOPAGO", SqlDbType.VarChar, 100).Value = BE.IdTipoPago
                .Add("@IDMEDIOPAGO", SqlDbType.VarChar, 50).Value = BE.IdMedioPago
                .Add("@GRATIFICACIONDESCUENTO", SqlDbType.Float).Value = BE.PorcentajeGratificacionDescuento
                .Add("@MONTODESCUENTO", SqlDbType.Float).Value = BE.MontoDescuento
                .Add("@MONTOAPROBADO", SqlDbType.Float).Value = BE.MontoAprobado
                .Add("@IDUSUARIO", SqlDbType.Int).Value = IDUSUARIO
                .Add("@IDMOTIVO", SqlDbType.Int).Value = BE.IdMotivoPrestamo
                .Add("@MONTOVACACIONESDESCUENTO", SqlDbType.Float).Value = BE.MontoVacacionesDescuento
                .Add("@MONTOLIQUIDACIONDESCUENTO", SqlDbType.Float).Value = BE.MontoLiquidacionDescuento
                .Add("@DESCRIPCIONRRHH", SqlDbType.NVarChar, 1000).Value = BE.DescripcionPrestamoRrhh
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

    Public Function UpdatePrestamoValidacionRRHH(BE As PrestamosBE, ByVal IDUSUARIO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_UPDATE_PRESTAMO_VALIDACION_RRHH"
            With .Parameters
                .Add("@IDPRESTAMO", SqlDbType.Int).Value = BE.IdPrestamos
                .Add("@IDTIPOPAGO", SqlDbType.Int).Value = BE.IdTipoPago
                .Add("@IDMEDIOPAGO", SqlDbType.Int).Value = BE.IdMedioPago
                .Add("@PORCENTAJEGRATIFICACIONDESCUENTO", SqlDbType.Float).Value = BE.PorcentajeGratificacionDescuento
                .Add("@MONTODESCUENTO", SqlDbType.Float).Value = BE.MontoDescuento
                .Add("@MONTOAPROBADO", SqlDbType.Float).Value = BE.MontoAprobado
                .Add("@IDMOTIVO", SqlDbType.Int).Value = BE.IdMotivoPrestamo
                .Add("@MONTOVACACIONESDESCUENTO", SqlDbType.Float).Value = BE.MontoVacacionesDescuento
                .Add("@MONTOLIQUIDACIONDESCUENTO", SqlDbType.Float).Value = BE.MontoLiquidacionDescuento
                .Add("@DESCRIPCIONRRHH", SqlDbType.NVarChar, 1000).Value = BE.DescripcionPrestamoRrhh
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

    Public Function UpdatePrestamoAprobacionRRHH(BE As PrestamosBE, ByVal IDUSUARIO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_UPDATE_PRESTAMO_APROBACION_RRHH"
            With .Parameters
                .Add("@IDPRESTAMO", SqlDbType.VarChar, 50).Value = BE.IdPrestamos
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

    Public Function UpdatePrestamoAnulacionRRHH(BE As PrestamosBE, ByVal IDUSUARIO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_UPDATE_PRESTAMO_ANULACION_RRHH"
            With .Parameters
                .Add("@IDPRESTAMO", SqlDbType.Int).Value = BE.IdPrestamos
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


    Public Function GetPrestamosCompromisoArchivo(ByVal IDPRESTAMO As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PRESTAMO_COMPROMISO_LISTA_ARCHIVO"
            With .Parameters
                .Add("@IDPRESTAMO", SqlDbType.Int).Value = IDPRESTAMO
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

    Public Function GetByAllPrestamosRevisados() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PRESTAMO_LIST_PREVIEW_ALL_REVISADOS"
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
    End Function ''ok

    Public Function GetByAllPrestamosAprobados() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PRESTAMO_LIST_PREVIEW_ALL_APROBADOS"
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

    Public Function UpdateEstadoRegistroAdryan(ByVal BE As PrestamosBE, ByVal IDUSUARIO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_UPDATE_PRESTAMO_ESTADO_ADRYAN"
            With .Parameters
                .Add("@IDPRESTAMO", SqlDbType.Int).Value = BE.IdPrestamos
                .Add("@ESTADOREGISTROADRYAN", SqlDbType.Bit).Value = BE.EstadoRegistroAdryan
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
    End Function 'ok

    Public Function GetByAllPrestamosDepositos() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PRESTAMO_LIST_PREVIEW_ALL_DEPOSITO"
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


    Public Function UpdatePrestamoDeposito(BE As PrestamosBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_UPDATE_PRESTAMO_DEPOSITO"
            With .Parameters
                .Add("@IDPRESTAMO", SqlDbType.Int).Value = BE.IdPrestamos
                .Add("@IDBANCO", SqlDbType.Int).Value = BE.IdBanco
                .Add("@CODIGODEPOSITO", SqlDbType.VarChar, 30).Value = BE.CodigoDeposito
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
    End Function ''ok

    Public Function UpdatePrestamoDepositoEstado(BE As PrestamosBE, ByVal IDUSUARIO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_UPDATE_PRESTAMO_DEPOSITO_ESTADO"
            With .Parameters
                .Add("@IDPRESTAMO", SqlDbType.Int).Value = BE.IdPrestamos
                .Add("@FECHADEPOSITO", SqlDbType.DateTime).Value = BE.FechaDeposito
                .Add("@IDBANCO", SqlDbType.Int).Value = BE.IdBanco
                .Add("@CODIGODEPOSITO", SqlDbType.NVarChar, 30).Value = BE.CodigoDeposito
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
    End Function 'ok

    Public Function GetPrestamosListHistorial(ByVal FechaInicial As Date, ByVal FechaFinal As Date, ByVal TipoReporte As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PRESTAMOS_LIST_PREVIEW_ALL_HISTORIAL"
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

    Public Function UpdatePrestamoRemoverEstadoAdryan(ByVal IDPRESTAMO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_UPDATE_PRESTAMO_REMOVE_ESTADO_ADRYAN"
            With .Parameters
                .Add("@IDPRESTAMO", SqlDbType.Int).Value = IDPRESTAMO
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

    Public Function GetPrestamoIDCorreo(ByVal IDPRESTAMOS As Int32) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PRESTAMO_ID_CORREO"
            With .Parameters
                .Add("@IDPRESTAMO", SqlDbType.Int).Value = IDPRESTAMOS
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
    End Function ''''ok


End Class
