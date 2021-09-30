Imports System.Data
Imports System.Data.SqlClient

Public Class PlanillaDAO
    Public Property id As Integer
    Public Property description As String
    Public Property units As Integer
    Public Property amount As Single

    Property IdPlanilla As Integer
    Public Function PlanillaListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PLANILLA_LIST"
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
    Public Function MesPlanillaList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PLANILLA_MES_LIS"
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
    Public Function RegistrarPlanilla(ByVal Anio As String, ByVal IdMes As Int32, ByVal IdUsuario As Int32) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PLANILLA_INS"
            With .Parameters
                .Add("@ANIO", SqlDbType.VarChar, 4).Value = Anio
                .Add("@IDMES", SqlDbType.Int).Value = IdMes
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
    Public Function PlanillaEmpleadoListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PLANILLA_LIST"
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
    Public Function ConceptoPlanillaListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PLANILLA_CONCEPTO_LIST"
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
    Public Function RegistrarConceptoPlanilla(ByVal Concepto As String, ByVal IdUsuario As Int32) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PLANILLA_CONCEPTO_INS"
            With .Parameters
                .Add("@CONCEPTO", SqlDbType.VarChar, 200).Value = Concepto
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

    Public Function InsertarPlanillaMasivo(ByVal dt As DataTable) As Boolean
        Dim Result As Boolean = True
        Using Conn As SqlConnection = New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
            Conn.Open()

            Using s As SqlBulkCopy = New SqlBulkCopy(Conn)
                s.DestinationTableName = "dbo.MCRH_PLANILLA_DETALLE_MASIVO"
                s.WriteToServer(dt)
                s.Close()
            End Using

            Conn.Close()
        End Using
        Return Result

    End Function

    Public Function RegistraNumeroPlanillaDetalleMasivo(ByVal IdPlanilla As Integer, ByVal IdUsario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PLANILLA_DETALLE_INS"
            With .Parameters
                .Add("@IDPLANILLA", SqlDbType.Int).Value = IdPlanilla
                .Add("@IDUSUARIO", SqlDbType.Int).Value = IdUsario
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
    Public Function ConceptoPlanillaGetId(ByVal IdPlanilla) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PLANILLA_CONCEPTO_PERIODO_GET_IDPLANILLA"
            With .Parameters
                .Add("@IDPLANILLA", SqlDbType.Int).Value = IdPlanilla
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

    Public Function ActualizaConceptoPlanilla(ByVal IdPlanilla As Integer, ByVal IdPlanillaConcepto As Integer, ByVal EstadoAsignacion As Boolean, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PLANILLA_CONCEPTO_PERIODO_INS"
            With .Parameters
                .Add("@IDPLANILLA", SqlDbType.Int).Value = IdPlanilla
                .Add("@IDPLANILLACONCEPTO", SqlDbType.Int).Value = IdPlanillaConcepto
                .Add("@ESTADOASIGNACION", SqlDbType.Bit).Value = EstadoAsignacion
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

    Public Function ConceptoPlanillaRespuestaListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PLANILLA_RESPUESTA_LIST"
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

    Public Function PlanillaConsultasGeneradasGetIdPlanilla(ByVal IdPlanilla As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PLANILA_CONSULTA_GET_IDPLANILLA"
            With .Parameters
                .Add("@IDPLANILLA", SqlDbType.Int).Value = IdPlanilla
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
    Public Function PlanillaConsultasEnRevisionGetIdPlanilla(ByVal IdPlanilla As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PLANILA_ENREVISION_GET_IDPLANILLA"
            With .Parameters
                .Add("@IDPLANILLA", SqlDbType.Int).Value = IdPlanilla
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
    Public Function PlanillaConsultasRevisadasGetIdPlanilla(ByVal IdPlanilla As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PLANILA_REVISADAS_GET_IDPLANILLA"
            With .Parameters
                .Add("@IDPLANILLA", SqlDbType.Int).Value = IdPlanilla
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

    Public Function AsignarRevisionConceptoPlanilla(ByVal IdPlanillaDetalleConcepto As Integer, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PLANILLA_ASINAR_VERIFICACION"
            With .Parameters
                .Add("@IDPLANILLADETALLECONCEPTO", SqlDbType.Int).Value = IdPlanillaDetalleConcepto
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
    Public Function RevisarConceptoPlanilla(ByVal IdSolicitudPlanilla As Integer, ByVal Matricula As String, ByVal Concepto As String, ByVal EstadoRespuesta As String, ByVal RespuestaSolicitud As String, ByVal ImporteIntegrar As Double, ByVal ImporteDescontar As Double, ByVal EstadoSolicitud As String, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PLANILLA_REVISAR_CONSULTAS"
            With .Parameters
                .Add("@IDSOLICITUDPLANILLA", SqlDbType.Int).Value = IdSolicitudPlanilla
                .Add("@MATRICULA", SqlDbType.VarChar, 10).Value = Matricula
                .Add("@CONCEPTOPLANILLA", SqlDbType.VarChar, 50).Value = Concepto
                .Add("@ESTADORESPUESTA", SqlDbType.VarChar, 50).Value = EstadoRespuesta
                .Add("@DESCRIPCIONRESPUESTA", SqlDbType.VarChar, 500000).Value = RespuestaSolicitud
                .Add("@IMPORTEINTEGRAR", SqlDbType.Float).Value = ImporteIntegrar
                .Add("@IMPORTEDESCONTAR", SqlDbType.Float).Value = ImporteDescontar
                .Add("@ESTADOSOLICITUD", SqlDbType.VarChar, 50).Value = EstadoSolicitud
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
End Class
