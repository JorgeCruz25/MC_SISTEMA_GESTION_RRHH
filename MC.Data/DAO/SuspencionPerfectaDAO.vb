Imports System.Data.SqlClient
Public Class SuspencionPerfectaDAO
    Public Function GetSuspensionPerfectaList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SUSPENSIONPERFECTA_GENERADA_LIST"
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
    Public Function AprobarSuspensionPerfecta(ByVal IdSuspensionPerfecta As Integer, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SUSPENSIONPERFECTA_APROBAR"
            With .Parameters
                .Add("@IDSUSPENSIONPERFECTA", SqlDbType.Int).Value = IdSuspensionPerfecta
                .Add("@IDUSUARIO", SqlDbType.Int).Value = IdUsuario

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

        End With
    End Function
    Public Function AprobarSuspensionPerfectaLaborando(ByVal IdSuspensionPerfecta As Integer, ByVal IdUsuario As Integer) As Boolean 'BORRAR
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SITUACIONLABORAL_LABORANDO_APROBAR"
            With .Parameters
                .Add("@IDSUSPENSIONPERFECTA", SqlDbType.Int).Value = IdSuspensionPerfecta
                .Add("@IDUSUARIO", SqlDbType.Int).Value = IdUsuario

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

        End With
    End Function
    Public Function AprobarSuspensionPerfectaLicenciaSinGoceSP(ByVal IdSuspensionPerfecta As Integer, ByVal IdUsuario As Integer) As Boolean 'BORRAR
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SITUACIONLABORAL_LISENCIASINGOCESP_APROBAR"
            With .Parameters
                .Add("@IDSUSPENSIONPERFECTA", SqlDbType.Int).Value = IdSuspensionPerfecta
                .Add("@IDUSUARIO", SqlDbType.Int).Value = IdUsuario
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

        End With
    End Function


    Public Function ValidacionAprobadoLaborando(ByVal IdSuspensionPerfecta As Integer, ByVal IdEmpleado As Int32) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_VALIDADO_SITUACIONLABORAL_LABORANDO"
            With .Parameters
                .Add("@IDSOLICITUD", SqlDbType.Int).Value = IdSuspensionPerfecta
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IdEmpleado
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

    End Function
    Public Function ValidacionAprobadoLicenciaSinGoceSP(ByVal IdSuspensionPerfecta As Integer, ByVal IdEmpleado As Integer, ByVal fechaInicio As Date, ByVal fechaFin As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_VALIDADO_SITUACIONLABORAL_LICENCIASINGOCESSP" '"MCRH_VALIDADO_SUSPENSIONPERECTA"
            With .Parameters
                .Add("@IDSOLICITUD", SqlDbType.Int).Value = IdSuspensionPerfecta
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IdEmpleado
                .Add("@FECHAINICIO", SqlDbType.Date).Value = fechaInicio
                .Add("@FECHAFIN", SqlDbType.Date).Value = fechaFin

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

    End Function
    Public Function ValidacionSuspensionPerfecta(ByVal IdSuspensionPerfecta As Integer, ByVal IdEmpleado As Integer, ByVal fechaFin As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_VALIDADO_SITUACIONLABORAL_SUSPENSIONPERFECTA"
            With .Parameters
                .Add("@IDSOLICITUD", SqlDbType.Int).Value = IdSuspensionPerfecta
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IdEmpleado
                .Add("@FECHAFIN", SqlDbType.Date).Value = fechaFin

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

    End Function
    Public Function AnularSuspensionPerfecta(ByVal IdSuspensionPerfecta As Integer, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SUSPENSIONPERFECTA_ANULAR"
            With .Parameters
                .Add("@IDSUSPENSIONPERFECTA", SqlDbType.Int).Value = IdSuspensionPerfecta
                .Add("@IDUSUARIO", SqlDbType.Int).Value = IdUsuario
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

        End With
    End Function
    Public Function ActualizarCamposLicencias(ByVal IdSuspensionPerfecta As Integer, ByVal IdLicencia As Integer, ByVal FechaPeridoInicio As Date, ByVal FechaPeriodoFin As Date) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SUSPENSIONPERFECTA_LICENCIA_UPDATE"
            With .Parameters
                .Add("@IDLICENCIA", SqlDbType.Int).Value = IdLicencia
                .Add("@FECHAPERIODOINICIO", SqlDbType.Date).Value = FechaPeridoInicio
                .Add("@FECHAPERIODOFIN", SqlDbType.Date).Value = FechaPeriodoFin
                .Add("@IDSUSPENSIONPERFECTA", SqlDbType.Int).Value = IdSuspensionPerfecta
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

        End With
    End Function
    Public Function ActualizarCampoSupensionPerfecta(ByVal IdSuspensionPerfecta As Integer, ByVal FechaPeriodoFin As Date) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SUSPENSIONPERFECTA_UPDATE"
            With .Parameters
                .Add("@IDSUSPENSIONPERFECTA", SqlDbType.Int).Value = IdSuspensionPerfecta
                .Add("@FECHAFINSUSPENSION", SqlDbType.Date).Value = FechaPeriodoFin
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

        End With
    End Function
    Public Function ActualizarNuevaFechaFin(ByVal IdSuspensionPerfecta As Integer, ByVal IdUsuario As Integer, ByVal FechaPeriodoFin As Date) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_MODIFICACIONFECHA_SUSPENSIONPERFECTA"
            With .Parameters
                .Add("@IDSOLICITUD", SqlDbType.Int).Value = IdSuspensionPerfecta
                .Add("@IDUSUARIO", SqlDbType.Int).Value = IdUsuario
                .Add("@FECHAPERIODOFIN", SqlDbType.Date).Value = FechaPeriodoFin
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

        End With
    End Function
    Public Function AnularSuspensionPerfectaProcesada(ByVal IdSuspensionPerfecta As Integer, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SUSPENSIONPERFECTAHISTORICOPROCESADO_ANULAR"
            With .Parameters
                .Add("@IDSUSPENSIONPERFECTA", SqlDbType.Int).Value = IdSuspensionPerfecta
                .Add("@IDUSUARIO", SqlDbType.Int).Value = IdUsuario
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

        End With
    End Function
    Public Function GetSuspensionPerfectaHistorialList(ByVal FechaInicio As Date, ByVal FechaFin As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SUSPENSIONPERFECTA_HISTORIAL_LIST"
            With .Parameters
                .Add("@FECHAINICIO", SqlDbType.Date).Value = FechaInicio
                .Add("@FECHAFIN", SqlDbType.Date).Value = FechaFin
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
    End Function
    Public Function GetSituacionLaboralEmpleadoList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SUSPENSIONPERFECTA_SITUASIONLABORAL_EMPLEADO_LIST"
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
    Public Function ObtenerValidacionMatricula(ByVal matricula As String) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_SUSPENSION_PERFECTA_VALIDACION_MATRICULA"
            With .Parameters
                .Add("@MATRICULA", SqlDbType.VarChar, 10).Value = matricula
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

    Public Function ValidacionAprobadoLicenciaSinGoceSP(ByVal matricula As String, ByVal fechaInicio As Date, ByVal fechaFin As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_VALIDADO_SITUACIONLABORAL_MASIVO_POREMPLEADO"
            With .Parameters
                .Add("@MATRICULA", SqlDbType.VarChar, 10).Value = matricula
                .Add("@FECHAINICIO", SqlDbType.Date).Value = fechaInicio
                .Add("@FECHAFIN", SqlDbType.Date).Value = fechaFin
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
    Public Function GenerarSuspensionPerfecta(ByVal Matricula As String, ByVal IdUsuario As Integer, ByVal FechaInicio As Date, ByVal FechaFin As Date, ByVal IdSituacionLaboral As Int32) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_GENERACION_SUSPENSION_PERFECTA_MASIVA"
            With .Parameters
                .Add("@MATRICULA", SqlDbType.VarChar, 10).Value = Matricula
                .Add("@IDUSUARIO", SqlDbType.Int).Value = IdUsuario
                .Add("@FECHAINICIO", SqlDbType.Date).Value = FechaInicio
                .Add("@FECHAFIN", SqlDbType.Date).Value = FechaFin
                .Add("@IDSITUACIONLABORALSOLICITUD", SqlDbType.Int).Value = IdSituacionLaboral
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

        End With
    End Function


End Class
