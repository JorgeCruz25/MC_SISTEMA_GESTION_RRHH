Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel.DataAnnotations


Public Class RolBE

    Property IDRol As Int32

    <Required(ErrorMessage:="El campo es obligatorio")>
    <StringLength(150, MinimumLength:=1, ErrorMessage:="Nombre debe tener al menos un caracter")>
    Property Nombre As String

    Property IdUsuario As Int32
    Property FechaRegistro As DateTime

End Class

Public Class RolDAO
    Property IDRol As Int32

    Public Enum eRol
        Todos = 1
        SinNinguno = 2
    End Enum


    Dim RolBE As New RolBE
    Dim strCnx As String = ConexionDAO.GetConexionDBlabroe

    Public Function Save(BE As RolBE, dt As DataTable) As Boolean
        Dim Result As Boolean = False
        Try
            If BE.IDRol = 0 Then
                If Insert(BE, dt) Then
                    Result = True
                End If
            Else
                If Update(BE, dt) Then
                    Result = True
                End If
            End If
        Catch ex As Exception
            Throw New Exception("RolDAO.Save" & vbCrLf & ex.Message)
        End Try
        Return Result
    End Function
    Private Function Insert(ByVal BE As RolBE, dt As DataTable) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "roe_rol_insert"
            With .Parameters
                .Add("@idrol", SqlDbType.Int).Direction = ParameterDirection.Output
                .Add("@nombre", SqlDbType.VarChar, 150).Value = BE.Nombre
                .Add("@idusuario", SqlDbType.Int).Value = BE.IdUsuario
                .Add("@fecharegistro", SqlDbType.DateTime).Value = BE.FechaRegistro
                .Add("@xmlpermisos", SqlDbType.Xml).Value = ConvertXMLPermisos(dt)
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                IDRol = cmd.Parameters("@idrol").Value
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("RolDAO.Insert " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function
    Private Function Update(ByVal BE As RolBE, dt As DataTable) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "roe_rol_update"
            With .Parameters
                .Clear()
                .Add("@idrol", SqlDbType.Int).Value = BE.IDRol
                .Add("@nombre", SqlDbType.VarChar, 150).Value = BE.Nombre
                .Add("@idusuario", SqlDbType.Int).Value = BE.IdUsuario
                .Add("@fecharegistro", SqlDbType.DateTime).Value = BE.FechaRegistro
                .Add("@xmlpermisos", SqlDbType.Xml).Value = ConvertXMLPermisos(dt)
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("RolDAO.Update " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function
    Public Function Delete(ByVal IDRol As Int32) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "roe_rol_delete"
            With .Parameters
                .Add("@idrol", SqlDbType.Int).Value = IDRol
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("RolDAO.Delete" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function
    Public Function Validar(ByVal BE As RolBE) As IList(Of ValidationResult)
        Dim Lista As New List(Of ValidationResult)
        Dim vc As New ValidationContext(BE, Nothing, Nothing)
        Try
            Validator.TryValidateObject(BE, vc, Lista, True)
        Catch ex As Exception
            Throw New Exception("RolDAO.Validar" & vbCrLf & ex.Message)
        End Try
        Return Lista
    End Function

    Public Function GetByID(ByVal IDRol As Int32) As RolBE
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "roe_rol_get_id"
            With .Parameters
                .Add("@idrol", SqlDbType.Int).Value = IDRol
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With RolBE
                        .IDRol = dr.ReadNullAsNumeric("idrol")
                        .Nombre = dr.ReadNullAsEmptyString("nombre")
                        .FechaRegistro = dr.ReadNullAsEmptyString("fecharegistro")
                        .IdUsuario = dr.ReadNullAsNumeric("idusuario")
                    End With
                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw New Exception("RolDAO.GetByID " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return RolBE
    End Function
    Public Function GetByALL(Optional Tipo As eRol = eRol.SinNinguno) As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "roe_rol_get_all"
            .Parameters.Add("@tipo", SqlDbType.Int).Value = Tipo
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("RolDAO.GetRolByALL" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
    Public Function GetByPermisos(IDRol As Int32) As DataTable
        Dim cnx As New SqlConnection(strCnxLabRoe)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "roe_permiso_get_idrol"
            .Parameters.Add("@idrol", SqlDbType.Int).Value = IDRol
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("RolDAO.GetByPermisos " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    ''' <summary>
    ''' Convierte la estructura DataTable de permisos en una estructura XML de permisos
    ''' </summary>
    ''' <param name="dt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function ConvertXMLPermisos(dt As DataTable) As String

        Dim xEle = New XElement("ITEMS",
                              From item In dt.Rows Where item("activo") = True
                              Select New XElement("ITEM", New XAttribute("idpermiso", item("idpermiso"))))

        Return xEle.ToString()
    End Function

End Class
