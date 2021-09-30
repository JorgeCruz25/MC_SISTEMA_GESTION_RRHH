Imports System.Data.SqlClient
Public Class BonoExtraDAO
    Dim BonoExtraBE As New BonoExtraBE
    Public IdBonoExtraSolicitud As Integer
    Public IdBonoExtraTipo As Integer
    Public IdEmpleado As Integer
#Region "SOLICITUDES FM Y TITULARIDAD"
    Public Function BonoExtraListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_BONOS_EXTRA_LIST_ALL]"
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
    Public Function BonoExtraHistorialListAll(ByVal FECHAINICIO As Date, ByVal FECHAFINAL As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_BONOS_EXTRA_LIST_ALL_HISTORIAL]"
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
    Public Function GetBonoExtraByID(ByVal IDBONOEXTRASOLICITUD As Int32) As BonoExtraBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_BONOEXTRASOLICITUD_GET_BY_ID]"
            With .Parameters
                .Add("@IDBONOEXTRASOLICITUD", SqlDbType.Int).Value = IDBONOEXTRASOLICITUD
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With BonoExtraBE
                        .IdBonoExtraSolicitud = dr.ReadNullAsNumeric("IDBONOEXTRASOLICITUD")
                        .RazonSocial = dr.ReadNullAsEmptyString("RAZONSOCIAL")
                        .RazonComercial = dr.ReadNullAsEmptyString("RAZONCOMERCIAL")
                        .Fecha = dr.ReadNullAsEmptyString("FECHA")
                        .DniEmpleado = dr.ReadNullAsEmptyString("DNIEMPLEADO")
                        .NombreSolicitante = dr.ReadNullAsEmptyString("NOMBRESOLICITANTE")
                        .NombreEmpleado = dr.ReadNullAsNumeric("NOMBREEMPLEADO")
                        .CargoEmpleado = dr.ReadNullAsEmptyString("CARGOEMPLEADO")
                        .BonoExtraTipo = dr.ReadNullAsEmptyString("BONOEXTRATIPO")
                        .MontoSolicitado = dr.ReadNullAsNumeric("MONTOSOLICITADO")
                        .FechaIngresoCorporativo = dr.ReadNullAsEmptyString("FECHAINGRESOCORPORACION")
                        .FechaIngresoLocal = dr.ReadNullAsEmptyString("FECHAINGRESO")
                        .MontoAprobado = dr.ReadNullAsNumeric("MONTOAPROBADO")
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
        Return BonoExtraBE
    End Function 'OK
    Public Function BonoExtraListAllById(ByVal IDEMPLEADO As Integer, ByVal IDBONOEXTRATIPO As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_SOLICITUDBONOEXTRA_FM_TITULAR_ID]"
            With .Parameters
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IDEMPLEADO
                .Add("@IDBONOEXTRATIPO", SqlDbType.Int).Value = IDBONOEXTRATIPO
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
    Public Function BonoExtraAprobar(BE As BonoExtraBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_SOLICITUDBONOEXTRA_APROBAR]"
            With .Parameters
                .Add("@IDBONOEXTRA", SqlDbType.Int).Value = BE.IdBonoExtraSolicitud
                .Add("@MONTOAPROBADO", SqlDbType.Int).Value = BE.MontoAprobado
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
    Public Function BonoExtraAnular(ByVal IDBONOEXTRASOLICITUD As Integer, ByVal IDUSUARIO As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_SOLICITUDBONOEXTRA_ANULAR]"
            With .Parameters
                .Add("@IDBONOEXTRA", SqlDbType.Int).Value = IDBONOEXTRASOLICITUD
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
#End Region
#Region "BONO POR ANTIGUEDAD"
    Public Function BonoExtraBonoAntiguedadListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_BONOS_EXTRA_BONOANTIGUEDAD_LIST_ALL]"
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
    Public Function BonoExtraBonoAntiguedadIns(BE As BonoExtraAntiguedadBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_BONOS_EXTRA_BONOANTIGUEDAD_INS]"
            With .Parameters
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = BE.IdEmpleado
                .Add("@IDLOCAL", SqlDbType.Int).Value = BE.IdLocal
                .Add("@IDAREA", SqlDbType.Int).Value = BE.IdArea
                .Add("@FECHAINGRESOCORPORATIVO", SqlDbType.Date).Value = BE.FechaIngresoCorporativo
                .Add("@MONTOBENEFICIO", SqlDbType.Float).Value = BE.MontoBeneficio
                .Add("@MONTOEXTRA", SqlDbType.Float).Value = BE.MontoExtra
                .Add("@MONTOTOTAL", SqlDbType.Float).Value = BE.MontoTotal
                .Add("@ESTADOBENEFICIO", SqlDbType.Int).Value = BE.EstadoBeneficio
                '.Add("@ESTADOAPROBADO", SqlDbType.Int).Value = BE.EstadoAprobado
                '.Add("@TIEMPOSERVICIO", SqlDbType.Int).Value = BE.TiempoServicio
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

#End Region
#Region "TODOS LOS BEFENICIOS DETALLADOS DE CADA EMPLEADO"
    Public Function BonoExtraEmpleadoDetailsListAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "[MCRH_BONOS_EXTRA_EMPLEADO_LIS_ALL]"
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

End Class
