Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel.DataAnnotations


Public Class ServicioDAO
    Property IDServicio As Int32
    Dim ServicioBE As New ServicioBE

    Public Function Save(ByVal BE As ServicioBE) As Boolean
        Dim Result As Boolean = False
        Try
            If BE.idservicio = 0 Then
                If Insert(BE) Then
                    Result = True
                End If
            Else
                If Update(BE) Then
                    Result = True
                End If
            End If
        Catch ex As Exception
            Throw New Exception("ServicioDAO.Save" & vbCrLf & ex.Message)
        End Try
        Return Result
    End Function

    Public Function Insert(ByVal BE As ServicioBE) As Boolean
        Dim cnx As New SqlConnection(strCnxLabRoe)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "roe_servicio_insert"

            With .Parameters
                .Clear()
                .Add("@idservicio", SqlDbType.Int).Direction = ParameterDirection.Output
                .Add("@nombre", SqlDbType.VarChar, 100).Value = BE.nombre
                .Add("@observaciones", SqlDbType.VarChar, -1).Value = BE.observacion
                .Add("@activo", SqlDbType.Bit).Value = BE.activo
                .Add("@idusuario", SqlDbType.Int).Value = BE.idusuario
                .Add("@fecharegistro", SqlDbType.DateTime).Value = BE.fecharegistro
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
                IDServicio = cmd.Parameters("@idservicio").Value
            End If
        Catch ex As Exception
            Throw New Exception("ServicioDAO.Insert - roe_servicio_insert" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Update(ByVal BE As ServicioBE) As Boolean
        Dim cnx As New SqlConnection(strCnxLabRoe)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "roe_servicio_update"
            With .Parameters
                .Clear()
                .Add("@idservicio", SqlDbType.Int).Value = BE.idservicio
                .Add("@nombre", SqlDbType.VarChar, 100).Value = BE.nombre
                .Add("@observacion", SqlDbType.VarChar, -1).Value = BE.observacion
                .Add("@activo", SqlDbType.Bit).Value = BE.activo
                .Add("@idusuario", SqlDbType.Int).Value = BE.idusuario
                .Add("@fecharegistro", SqlDbType.DateTime).Value = BE.fecharegistro
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
                IDServicio = BE.idservicio
            End If
        Catch ex As Exception
            Throw New Exception("ServicioDAO.Update - roe_servicio_update" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Delete(ByVal IDDepartamento As Int32) As Boolean
        Dim cnx As New SqlConnection(strCnxLabRoe)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "roe_servicio_delete"
            With .Parameters
                .Clear()
                .Add("@idservicio", SqlDbType.Int).Value = IDDepartamento
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("ServicioDAO.Delete - roe_servicio_delete" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Validar(ByVal ServicioBE As ServicioBE) As IList(Of ValidationResult)
        Dim Lista As New List(Of ValidationResult)
        Dim vc As New ValidationContext(ServicioBE, Nothing, Nothing)
        Try
            Validator.TryValidateObject(ServicioBE, vc, Lista, True)
        Catch ex As Exception
            Throw New Exception("ServicioDAO.Validar" & vbCrLf & ex.Message)
        End Try
        Return Lista
    End Function

    Public Function GetByIDDServicio(ByVal IDServicio As Int32) As ServicioBE
        Dim cnx As New SqlConnection(strCnxLabRoe)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "roe_servicio_get_id"

            With .Parameters
                .Clear()
                .Add("@idservicio", SqlDbType.Int).Value = IDServicio
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With ServicioBE
                        .idservicio = dr.ReadNullAsEmptyString("idservicio")
                        .nombre = dr.ReadNullAsEmptyString("nombre")
                        .observacion = dr.ReadNullAsEmptyString("observacion")
                        .activo = dr.ReadNullAsEmptyString("activo")
                        .idusuario = dr.ReadNullAsEmptyString("idusuario")
                        .fecharegistro = dr.ReadNullAsEmptyString("fecharegistro")
                    End With
                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw New Exception("ServicioDAO.GetByIDDServicio - roe_servicio_get_id" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return ServicioBE
    End Function

    Public Function GetByServicioALL(ByVal Tipo As String, ByVal Valor As String, ByVal NumeroPagina As Int32) As DataTable
        Dim cnx As New SqlConnection(strCnxLabRoe)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "roe_servicio_get_all"
            With .Parameters
                .Add("@tipo", SqlDbType.Char, 3).Value = Tipo
                .Add("@valor", SqlDbType.VarChar, 30).Value = Valor
                .Add("@numeropagina", SqlDbType.Int).Value = NumeroPagina
            End With
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
            Return dt
        Catch ex As Exception
            Throw New Exception("ServicioDAO.GetByServicioALL - roe_servicio_get_all" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try

    End Function
End Class
