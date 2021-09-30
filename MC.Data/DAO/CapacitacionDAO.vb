Imports System.Data.SqlClient

Public Class CapacitacionDAO
    Public IdCurso As Integer
    Public IdCapacitacion As Integer
    Public IdCapacitacionDetalle As Integer
    Public IdCapacitacionTipoEscuela As Int32
    Public IdProgramacionEscuela As Integer
    Public IdEmpleado As Integer
    Public Flat As Int32
    Public Function CursosListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_MANTENIMIENTO_CURSO_LIST"
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
    Public Function CedeListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_MANTENIMIENTO_CEDE_LIST"
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
    Public Function TipoEscuelaListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_TIPO_ESCUELA_LIST"
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

    Public Function CursosGetId(ByVal IdCurso As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_MANTENIMIENTO_CURSO_GETID"
            With .Parameters
                .Add("@IDCURSO", SqlDbType.Int).Value = IdCurso
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
    Public Function TipoEscuelaGetId(ByVal IdCapacitacionTipoEscuela As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_TIPO_ESCUELA_GETID"
            With .Parameters
                .Add("@IDCAPACITACIONTIPOESCUELA", SqlDbType.Int).Value = IdCapacitacionTipoEscuela
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
    Public Function TipoEscuelaIns(ByVal IdCapacitacionTipoEscuela As Integer, ByVal Descripcion As String, ByVal Estado As Boolean, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_TIPO_ESCUELA_INS"
            With .Parameters
                .Add("@IDCAPACITACIONTIPOESCUELA", SqlDbType.Int).Value = IdCapacitacionTipoEscuela
                .Add("@DESCRIPCION", SqlDbType.VarChar, 100).Value = Descripcion
                .Add("@ESTADO", SqlDbType.Bit).Value = Estado
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
    Public Function CursoIns(ByVal IdCurso As Integer, ByVal Descripcion As String, ByVal NotaAprobatoria As Double, ByVal Estado As Boolean, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_MANTENIMIENTO_CURSO_INS"
            With .Parameters
                .Add("@IDCURSO", SqlDbType.Int).Value = IdCurso
                .Add("@DESCRIPCION", SqlDbType.VarChar, 100).Value = Descripcion
                .Add("@NOTAAPROBATORIA", SqlDbType.Float).Value = NotaAprobatoria
                .Add("@ESTADO", SqlDbType.Bit).Value = Estado
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
    Public Function ProgramacionCapacitacionListAll(ByVal IdCapacitacionEscuela As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PROGRAMACION_CAPACITACION_LIST"
            With .Parameters
                .Add("@IDCAPACITACIONESCUELA", SqlDbType.Int).Value = IdCapacitacionEscuela
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

    Public Function ProgramacionCapacitacionAsignar(ByVal IdCapacitacion As Integer, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_ASIGNAR"
            With .Parameters
                .Add("@IDCAPACITACION", SqlDbType.Int).Value = IdCapacitacion
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
    Public Function ProgramacionCapacitacionAnular(ByVal IdCapacitacion As Integer, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_ANULAR"
            With .Parameters
                .Add("@IDCAPACITACION", SqlDbType.Int).Value = IdCapacitacion
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
    Public Function ProgramacionCapacitacionCursoList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_CURSO_LIST"
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
    Public Function ProgramacionCapacitacionResponsableList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_RESPONSABLE_LIST"
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
    Public Function ProgramacionCapacitacionModalidadList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_MODALIDAD_LIST"
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
    Public Function ProgramacionCapacitacionGetId(ByVal IdCapacitacion As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PROGRAMACION_CAPACITACION_GETID"
            With .Parameters
                .Add("@IDCAPACITACION", SqlDbType.Int).Value = IdCapacitacion
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
    Public Function ClaseCapacitacionDetalleGetId(ByVal IdCapacitacionDetalle As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_DETALLE_GETID"
            With .Parameters
                .Add("@IDCAPACITACIONDETALLE", SqlDbType.Int).Value = IdCapacitacionDetalle
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
    Public Function ProgramacionCapacitacionDetalleGetId(ByVal IdCapacitacion As Integer, ByVal TipoListado As Int32) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_DETALLE_GET_IDCAPACITACION"
            With .Parameters
                .Add("@IDCAPACITACION", SqlDbType.Int).Value = IdCapacitacion
                .Add("@TIPOLISTADO", SqlDbType.Int).Value = TipoListado '1=lista todas las clases, 2=lista todas las clases execto las anuladas
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
    Public Function ProgramacionCapacitacionIns(ByVal IdCapacitacion As Integer, ByVal IdCapacitacionEscuela As Integer, ByVal IdCurso As Integer, ByVal IdResponsable As Integer, ByVal IdModalidad As Integer, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_PROGRAMACION_CAPACITACION_INS"
            With .Parameters
                .Add("@IDCAPACITACION", SqlDbType.Int).Value = IdCapacitacion
                .Add("@IDCAPACITACIONESCUELA", SqlDbType.Int).Value = IdCapacitacionEscuela
                .Add("@IDCURSO", SqlDbType.Int).Value = IdCurso
                .Add("@IDEMPLEADORESPONSABLE", SqlDbType.Int).Value = IdResponsable
                .Add("@IDCAPACITACIONMADALIDAD", SqlDbType.Int).Value = IdModalidad
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
    Public Function ProgramacionCapacitacionDetalleIns(ByVal IdCapacitacionDetalle As Integer, ByVal IdCapacitacion As Integer, ByVal IdCedeCapacitacion As Integer, ByVal NumeroAula As String, ByVal FechaCapacitacion As Date, ByVal HoraInicio As String, ByVal HoraFin As String, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_DETALLE_INS"
            With .Parameters
                .Add("@IDCAPACITACIONDETALLE", SqlDbType.Int).Value = IdCapacitacionDetalle
                .Add("@IDCAPACITACION", SqlDbType.Int).Value = IdCapacitacion
                .Add("@IDCAPACITACIONCEDE", SqlDbType.Int).Value = IdCedeCapacitacion
                .Add("@NUMEROAULA", SqlDbType.VarChar, 20).Value = NumeroAula
                .Add("@FECHACAPACITACION", SqlDbType.Date).Value = FechaCapacitacion
                .Add("@HORAINCIO", SqlDbType.VarChar, 10).Value = HoraInicio
                .Add("@HORAFINAL", SqlDbType.VarChar, 10).Value = HoraFin
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
    Public Function ProgramacionCapacitacionCedeList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_CEDE_LIST"

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

    Public Function ProgramacionCapacitacionAsistenciaList(ByVal IdCapacitacionDetalle As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_ASISTENCIA_GET_IDCAPACITACIONDETALLE"
            With .Parameters
                .Add("@IDCAPACITACIONDETALLE", SqlDbType.Int).Value = IdCapacitacionDetalle
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

    Public Function ObtenerExistenciaTrabajador(ByVal Matricula As String) As Integer
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim Valor As String = 0
        Try
            Dim reader As SqlDataReader
            Dim cmd = New SqlCommand
            With cmd
                cnx.Open()

                .Connection = cnx
                .CommandType = CommandType.Text
                .CommandText = "select count(MATRICULA) from MC_EMPLEADO where MATRICULA = '" + Matricula + "'"
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
    Public Function ObtenerEstadoTrabajador(ByVal Matricula As String) As Integer
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim Valor As String = 0
        Try
            Dim reader As SqlDataReader
            Dim cmd = New SqlCommand
            With cmd
                cnx.Open()

                .Connection = cnx
                .CommandType = CommandType.Text
                .CommandText = "select IDESTADO from MC_EMPLEADO where MATRICULA = '" + Matricula + "'"
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
    Public Function ProgramacionCapacitacionAsistenciaDelete(ByVal IdCapacitacionDetalle As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_ASISTENCIA_DELETE"
            With .Parameters
                .Add("@IDCAPACITACIONDETALLE", SqlDbType.Int).Value = IdCapacitacionDetalle
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
    Public Function ProgramacionCapacitacionAsistenciaIns(ByVal IdCapacitacionDetalle As Integer, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_ASISTENCIA_INS"
            With .Parameters
                .Add("@IDCAPACITACIONDETALLE", SqlDbType.Int).Value = IdCapacitacionDetalle
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
    Public Function ProgramacionCapacitacionDetalleAnular(ByVal IdCapacitacionDetalle As Integer, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_DETALLE_ANULAR"
            With .Parameters
                .Add("@IDCAPACITACIONDETALLE", SqlDbType.Int).Value = IdCapacitacionDetalle
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
    Public Function ProgramacionCapacitacionDetalleProcesar(ByVal IdCapacitacionDetalle As Integer, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_DETALLE_PROCESAR"
            With .Parameters
                .Add("@IDCAPACITACIONDETALLE", SqlDbType.Int).Value = IdCapacitacionDetalle
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

    Public Function CapacitacionNotasGetId(ByVal IdCapacitacion As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_NOTAS_GET_IDCAPACITACION"
            With .Parameters
                .Add("@IDCAPACITACION", SqlDbType.Int).Value = IdCapacitacion
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
    Public Function CapacitacionNotasIns(ByVal IdCapacitacion As Integer, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_NOTAS_INS"
            With .Parameters
                .Add("@IDCAPACITACION", SqlDbType.Int).Value = IdCapacitacion
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

    Public Function CapacitacionNotasDelete(ByVal IdCapacitacion As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_NOTAS_DELETE"
            With .Parameters
                .Add("@IDCAPACITACION", SqlDbType.Int).Value = IdCapacitacion
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
    Public Function ProgramacionCapacitacionCerrar(ByVal IdCapacitacion As Integer, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_CERRAR"
            With .Parameters
                .Add("@IDCAPACITACION", SqlDbType.Int).Value = IdCapacitacion
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
    Public Function ObtenerExistenciaNotasCapacitacion(ByVal IdCapacitacion As String) As Integer
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim Valor As String = 0
        Try
            Dim reader As SqlDataReader
            Dim cmd = New SqlCommand
            With cmd
                cnx.Open()

                .Connection = cnx
                .CommandType = CommandType.Text
                .CommandText = "select count(IDCAPACITACIONNOTA) from MCRH_CAPACITACION_NOTAS where IDCAPACITACION = '" + IdCapacitacion + "'"
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
    Public Function ProgramacionCapacitacionCedeRegistroList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_CEDE_REGISTRO_LIST"
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
    Public Function MantenimientoCedeIns(ByVal IdLocal As Integer, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_CEDE_INS"
            With .Parameters
                .Add("@IDLOCAL", SqlDbType.Int).Value = IdLocal
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
    Public Function CapacitacionEmpleadoList(ByVal IdCapacitacionEscuela As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_EMPLEADO_LIST"
            With .Parameters
                .Add("@IDCAPACITACIONESCUELA", SqlDbType.Int).Value = IdCapacitacionEscuela
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
    Public Function CapacitacionEmpleadoAsignadosList(ByVal IdCapacitacionEscuela As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_EMPLEADO_ASIGNADOS_GETID"
            With .Parameters
                .Add("@IDCAPACITACIONESCUELA", SqlDbType.Int).Value = IdCapacitacionEscuela
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

    Public Function ProgramacionCapacitacionEmpleadoIns(ByVal IdCapacitacionEscuela As Integer, ByVal IdEmpleado As String, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_EMPLEADO_INS"
            With .Parameters
                .Add("@IDCAPACITACIONESCUELA", SqlDbType.Int).Value = IdCapacitacionEscuela
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IdEmpleado
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
    Public Function ProgramacionCapacitacionEmpleadoDesasignar(ByVal IdCapacitacionEscuela As Integer, ByVal IdEmpleado As String) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_EMPLEADO_DESASIGNAR"
            With .Parameters
                .Add("@IDCAPACITACIONESCUELA", SqlDbType.Int).Value = IdCapacitacionEscuela
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
    Public Function CapacitacionAsistenciaEstadoList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_ASISTENCIA_LIST"

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
    Public Function UpdateAsistenciaEstadoById(ByVal IdCapacitacionAsistencia As Integer, ByVal IdAsistenciaEstado As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "MCRH_CAPACITACION_ASISTENCIA_UPDATE"
            With .Parameters
                .Add("@IDCAPACITACIONASISTENCIA", SqlDbType.Int).Value = IdCapacitacionAsistencia
                .Add("@IDASISTENCIAESTADO", SqlDbType.Int).Value = IdAsistenciaEstado

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
    Public Function UpdateAsistenciaNotaById(ByVal IdCapacitacionNota As Integer, ByVal Estado As Boolean, ByVal Nota As Double, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "MCRH_CAPACITACION_NOTAS_UPDATE"
            With .Parameters
                .Add("@IDCAPACITACIONNOTA", SqlDbType.Int).Value = IdCapacitacionNota
                .Add("@ESTADO", SqlDbType.Bit).Value = Estado
                .Add("@NOTA", SqlDbType.Int).Value = Nota
                .Add("@IDUSUARIO", SqlDbType.Int).Value = IdUsuario
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
    Public Function ObtenerCantidadMarcaciones(ByVal IdCapacitacionDetalle As String) As Integer
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim Valor As String = 0
        Try
            Dim reader As SqlDataReader
            Dim cmd = New SqlCommand
            With cmd
                cnx.Open()

                .Connection = cnx
                .CommandType = CommandType.Text
                .CommandText = "SELECT COUNT(*) FROM MCRH_CAPACITACION_ASISTENCIA WHERE IDCAPACITACIONDETALLE= '" + IdCapacitacionDetalle + "'"
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
    Public Function ObtenerCantidadMarcacionesPendientes(ByVal IdCapacitacionDetalle As String) As Integer
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim Valor As String = 0
        Try
            Dim reader As SqlDataReader
            Dim cmd = New SqlCommand
            With cmd
                cnx.Open()

                .Connection = cnx
                .CommandType = CommandType.Text
                .CommandText = "SELECT COUNT(*) FROM MCRH_CAPACITACION_ASISTENCIA WHERE IDCAPACITACIONDETALLE= '" + IdCapacitacionDetalle + "' and IDASISTENCIAESTADO=0"
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
    Public Function ObtenerCantidadNotas(ByVal IdCapacitacion As String) As Integer
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim Valor As String = 0
        Try
            Dim reader As SqlDataReader
            Dim cmd = New SqlCommand
            With cmd
                cnx.Open()

                .Connection = cnx
                .CommandType = CommandType.Text
                .CommandText = "SELECT COUNT(*) FROM MCRH_CAPACITACION_NOTAS WHERE IDCAPACITACION= '" + IdCapacitacion + "'"
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
    Public Function ObtenerCantidadNotasPendientes(ByVal IdCapacitacion As String) As Integer
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim Valor As String = 0
        Try
            Dim reader As SqlDataReader
            Dim cmd = New SqlCommand
            With cmd
                cnx.Open()

                .Connection = cnx
                .CommandType = CommandType.Text
                .CommandText = "SELECT COUNT(*) FROM MCRH_CAPACITACION_NOTAS WHERE IDCAPACITACION= '" + IdCapacitacion + "' and IDESTADONOTA=0"
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
    Public Function ObtenerEstadoCapacitacion(ByVal IdCapacitacion As String) As Integer
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim Valor As String = 0
        Try
            Dim reader As SqlDataReader
            Dim cmd = New SqlCommand
            With cmd
                cnx.Open()

                .Connection = cnx
                .CommandType = CommandType.Text
                .CommandText = "SELECT IDCAPACITACIONESTADO FROM MCRH_CAPACITACION WHERE IDCAPACITACION= '" + IdCapacitacion + "'"
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

    '--------------------------------------------------------
    Public Function ProgramacionCapacitacionEscuelaList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_ESCUELA_LIST"
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
    Public Function ProgramacionCapacitacionTipoEscuelaActivosList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_PROGRAMACION_TIPO_ESCUELA_LIST"
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
    Public Function ObtenerNumeroEscuelaxTipoEscuela(ByVal IdCapacitacionTipoEscuela As Int32) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_NUMERO_CORRELATIVO"
            With .Parameters
                .Add("@IDCAPACITACIONTIPOESCUELA", SqlDbType.Int).Value = IdCapacitacionTipoEscuela
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
    Public Function ProgamacionEsculaIns(ByVal IdCapacitacionEscula As Integer, ByVal IdCapacitacionTipoEscuela As Integer, ByVal Nota As Double, ByVal IdUsuario As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandTimeout = 0
            .CommandText = "MCRH_CAPACITACION_ESCUELA_INS"
            With .Parameters
                .Add("@IDCAPACITACIONESCUELA", SqlDbType.Int).Value = IdCapacitacionEscula
                .Add("@IDCAPACITACIONTIPOESCUELA", SqlDbType.Int).Value = IdCapacitacionTipoEscuela
                .Add("@NOTAAPROBATORIA", SqlDbType.Int).Value = Nota
                .Add("@IDUSUARIO", SqlDbType.Int).Value = IdUsuario
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

    Public Function CapacitacionNotasDatosFormato(ByVal IdCapacitacionEscuela As Integer, ByVal IdEmpleado As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_DATOS_FORMATO"
            With .Parameters
                .Add("@IDCAPACITACIONESCUELA", SqlDbType.Int).Value = IdCapacitacionEscuela
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
    Public Function CapacitacionNotasGetIdEmpleado(ByVal IdCapacitacionEscuela As Integer, ByVal IdEmpleado As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCRH_CAPACITACION_DATOS_NOTAS_IDEMPLEADO"
            With .Parameters
                .Add("@IDCAPACITACIONESCUELA", SqlDbType.Int).Value = IdCapacitacionEscuela
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
End Class
