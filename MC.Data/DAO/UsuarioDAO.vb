Imports System.Data.SqlClient

Public Class UsuarioDAO
    Public Property IDUsuario As Int32
    Public Property IDSistema As Int32

    Public Function Save(ByVal BE As UsuarioBE) As Int32
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Int32 = 0

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            If BE.IDUsuario = 0 Then
                .CommandText = "roe_usuario_insert"
                .Parameters.Add("@idusuario", SqlDbType.Int).Direction = ParameterDirection.Output
            Else
                .CommandText = "roe_usuario_update"
                .Parameters.Add("@idusuario", SqlDbType.Int).Value = BE.IDUsuario
            End If
            With .Parameters
                .Add("@nombres", SqlDbType.VarChar, 100).Value = BE.Nombres
                .Add("@apellidopaterno", SqlDbType.VarChar, 100).Value = BE.ApellidoPaterno
                .Add("@apellidomaterno", SqlDbType.VarChar, 100).Value = BE.ApellidoMaterno
                .Add("@correoelectronico", SqlDbType.VarChar, 150).Value = BE.CorreoELectronico
                .Add("@login", SqlDbType.VarChar, 15).Value = BE.Login
                .Add("@password", SqlDbType.VarChar, 15).Value = BE.Contrasena
                .Add("@activo", SqlDbType.Bit).Value = BE.Activo
                .Add("@idrol", SqlDbType.Int).Value = BE.IdRol
                .Add("@idroltemporal", SqlDbType.Int).Value = BE.IdRolTemporal
                .Add("@fechainiciorol", SqlDbType.Date).Value = BE.FechaInicioRol
                .Add("@fechafinalrol", SqlDbType.Date).Value = BE.FechaFinalRol
                .Add("@idusuarioregistro", SqlDbType.Int).Value = BE.IDUsuarioRegistro
                .Add("@fecharegistro", SqlDbType.DateTime).Value = BE.FechaRegistro
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Me.IDUsuario = cmd.Parameters("@idusuario").Value
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

    Public Function Delete() As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "roe_usuario_delete"
            .Parameters.Add("@idusuario", SqlDbType.Int).Value = IDUsuario
        End With

        Try
            'Se valida que el ID sea diferente de cero
            If Me.IDUsuario = 0 Then
                Throw New Exception("IDUsuario es cero.")
            End If

            cnx.Open()
            If cmd.ExecuteNonQuery > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("UsuarioDAO.Delete " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function GetByID() As UsuarioBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing
        Dim UsuarioBE As New UsuarioBE

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "roe_usuario_get_id"
            .Parameters.Add("@idusuario", SqlDbType.Int).Value = Me.IDUsuario
        End With

        Try
            'Se valida que el IDUsuario sea diferente de cero
            If Me.IDUsuario = 0 Then
                Throw New Exception("IDUsuario es cero.")
            End If

            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With UsuarioBE
                        .IDUsuario = dr.ReadNullAsEmptyString("idusuario")
                        .Nombres = dr.ReadNullAsEmptyString("nombres")
                        .ApellidoPaterno = dr.ReadNullAsEmptyString("apellidopaterno")
                        .ApellidoMaterno = dr.ReadNullAsEmptyString("apellidomaterno")
                        .CorreoELectronico = dr.ReadNullAsEmptyString("correoelectronico")
                        .Usuario = dr.ReadNullAsEmptyString("login")
                        .Contrasena = dr.ReadNullAsEmptyString("password")
                        .Activo = dr.ReadNullAsEmptyString("activo")
                        .IdRol = dr.ReadNullAsEmptyString("idrol")
                        .IdRolTemporal = dr.ReadNullAsEmptyString("idroltemporal")
                        .FechaInicioRol = dr.ReadNullAsEmptyDate("fechainiciorol")
                        .FechaFinalRol = dr.ReadNullAsEmptyDate("fechafinalrol")
                        .IDUsuarioRegistro = dr.ReadNullAsEmptyString("idusuarioregistro")
                        .FechaRegistro = dr.ReadNullAsEmptyString("fecharegistro")
                        .NombreUsuario = dr.ReadNullAsEmptyString("nombreusuario")
                    End With

                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return UsuarioBE
    End Function

    Public Function GetByLogin(ByVal Login As String) As UsuarioBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing
        Dim UsuarioBE As New UsuarioBE

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "roe_usuario_get_login"
            .Parameters.Add("@login", SqlDbType.VarChar, 15).Value = Login
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With UsuarioBE
                        .IDUsuario = dr.ReadNullAsEmptyString("idusuario")
                        .Nombres = dr.ReadNullAsEmptyString("nombres")
                        .ApellidoPaterno = dr.ReadNullAsEmptyString("apellidopaterno")
                        .ApellidoMaterno = dr.ReadNullAsEmptyString("apellidomaterno")
                        .CorreoELectronico = dr.ReadNullAsEmptyString("correoelectronico")
                        .Usuario = dr.ReadNullAsEmptyString("login")
                        .Contrasena = dr.ReadNullAsEmptyString("password")
                        .Activo = dr.ReadNullAsEmptyString("activo")
                        .IDUsuarioRegistro = dr.ReadNullAsEmptyString("idusuarioregistro")
                        .FechaRegistro = dr.ReadNullAsEmptyString("fecharegistro")
                    End With

                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return UsuarioBE
    End Function

    Public Function GetByLoginPassword(ByVal NombreUsuario As String, ByVal Contrasena As String) As UsuarioBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing
        Dim UsuarioBE As New UsuarioBE
        Dim Lista As New List(Of String)
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_USUARIO_GET_LOGIN"
            .Parameters.Add("@NombreUsuario", SqlDbType.VarChar, 20).Value = NombreUsuario
            .Parameters.Add("@Contrasena", SqlDbType.VarChar, 20).Value = Contrasena
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With UsuarioBE
                        .IDUsuario = dr.ReadNullAsEmptyString("idusuario")
                        .Nombres = dr.ReadNullAsEmptyString("nombres")
                        .ApellidoPaterno = dr.ReadNullAsEmptyString("apellidopaterno")
                        .ApellidoMaterno = dr.ReadNullAsEmptyString("apellidomaterno")
                        .Usuario = dr.ReadNullAsEmptyString("nombreusuario")
                        .IdRol = dr.ReadNullAsEmptyString("idrol")
                        .NombreRol = dr.ReadNullAsEmptyString("nombrerol")
                        .Activo = dr.ReadNullAsEmptyString("activo")
                        .IDUsuarioRegistro = dr.ReadNullAsEmptyString("idusuarioregistro")
                        .FechaRegistro = dr.ReadNullAsEmptyString("fecharegistro")
                    End With
                End While
                dr.Close()

            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return UsuarioBE
    End Function

    Public Function GetSubModulos(ByVal idrol As Integer, ByVal IDSistema As Integer) As DataTable

        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCR_ACCESOS_ROL_SUBMODULO"
            .Parameters.Add("@idrol", SqlDbType.Int).Value = idrol
            .Parameters.Add("@idsistema", SqlDbType.Int).Value = IDSistema
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw ex
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try

        Return dt

    End Function

    Public Function GetAcciones(ByVal idrolacciones As Integer, ByVal IDSistema As Integer) As DataTable

        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCR_ACCIONES_SISTEMAS"
            .Parameters.Add("@idrolacciones", SqlDbType.Int).Value = idrolacciones
            .Parameters.Add("@idsistema", SqlDbType.Int).Value = IDSistema
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw ex
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try

        Return dt

    End Function
    Public Function GetAccionesUsuario(ByVal IDUsuario As Int32, ByVal IDSistemas As Int32, ByVal Formulario As String) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionMC_CENTRAL)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_ACCIONES_USUARIO_SISTEMA"
            .Parameters.Add("@IDUSUARIO", SqlDbType.Int).Value = IDUsuario
            .Parameters.Add("@IDSISTEMA", SqlDbType.Int).Value = IDSistemas
            .Parameters.Add("@FORMULARIO", SqlDbType.VarChar, 200).Value = Formulario
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw ex
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

End Class
