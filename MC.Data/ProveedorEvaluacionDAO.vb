Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel.DataAnnotations

Public Class ProveedorEvaluacionDAO
    Property CodEvaluacion As Int32
    Property CodProveedor As Int32

    Dim ProveedorEvaluacionBE As New ProveedorEvaluacionBE

    Public Function Save(ByVal BE As ProveedorEvaluacionBE) As Boolean
        Dim Result As Boolean = False

        If BE.codevaluacion = 0 Then
            If Insert(BE) Then
                Result = True
            End If
        Else
            If Update(BE) Then
                Result = True
            End If
        End If
        Return Result
    End Function

    Public Function Insert(ByVal BE As ProveedorEvaluacionBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_proveedor_evaluacion_insert"
            With .Parameters
                .Clear()
                .Add("@codevaluacion", SqlDbType.Int).Direction = ParameterDirection.Output
                .Add("@codproveedor", SqlDbType.Int).Value = BE.codproveedor
                .Add("@idmotivo", SqlDbType.Int).Value = BE.idmotivo
                .Add("@motivo", SqlDbType.VarChar, -1).Value = BE.motivo
                .Add("@fechamotivo", SqlDbType.Date).Value = BE.fechamotivo
                .Add("@idcorrecion", SqlDbType.Int).Value = BE.idcorrecion
                .Add("@accion", SqlDbType.VarChar, -1).Value = BE.accion
                .Add("@fechaaccion", SqlDbType.Date).Value = BE.fechaaccion
                .Add("@idusuario", SqlDbType.Int).Value = BE.idusuario
                .Add("@fecharegistro", SqlDbType.DateTime).Value = BE.fecharegistro
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
                CodEvaluacion = cmd.Parameters("@codevaluacion").Value
                CodProveedor = cmd.Parameters("@codproveedor").Value
            End If
        Catch ex As Exception
            Throw New Exception("ProveedorEvaluacionDAO.Insert - log_proveedor_evaluacion_insert" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Update(ByVal BE As ProveedorEvaluacionBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_proveedor_evaluacion_update"

            With .Parameters
                .Clear()
                .Add("@codevaluacion", SqlDbType.Int).Value = BE.codevaluacion
                .Add("@codproveedor", SqlDbType.Int).Value = BE.codproveedor
                .Add("@idmotivo", SqlDbType.Int).Value = BE.idmotivo
                .Add("@motivo", SqlDbType.VarChar, -1).Value = BE.motivo
                .Add("@fechamotivo", SqlDbType.Date).Value = BE.fechamotivo
                .Add("@idcorrecion", SqlDbType.Int).Value = BE.idcorrecion
                .Add("@accion", SqlDbType.VarChar, -1).Value = BE.accion
                .Add("@fechaaccion", SqlDbType.Date).Value = BE.fechaaccion
                .Add("@idusuario", SqlDbType.Int).Value = BE.idusuario
                .Add("@fecharegistro", SqlDbType.DateTime).Value = BE.fecharegistro
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
                CodEvaluacion = BE.codevaluacion
                CodProveedor = BE.codproveedor
            End If
        Catch ex As Exception
            Throw New Exception("ProveedorEvaluacionDAO.Update - log_proveedor_evaluacion_update" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Delete(ByVal CodEvaluacion As Int32) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_proveedor_evaluacion_delete"
            With .Parameters
                .Clear()
                .Add("@codevaluacion", SqlDbType.Int).Value = CodEvaluacion
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("ProveedorEvaluacionDAO.Delete - log_proveedor_evaluacion_delete" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Validar(ByVal BE As ProveedorEvaluacionBE) As List(Of ValidationResult)
        Dim Lista As New List(Of ValidationResult)
        Dim vc As New ValidationContext(BE, Nothing, Nothing)
        Try
            Validator.TryValidateObject(BE, vc, Lista, True)
        Catch ex As Exception
            Throw New Exception("ProveedorEvaluacionDAO.Validar" & vbCrLf & ex.Message)
        End Try
        Return Lista
    End Function

    Public Function GetByIDProveedorEvaluacion(ByVal CodEvaluacion As Int32) As ProveedorEvaluacionBE
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_proveedor_evaluacion_get_id"

            With .Parameters
                .Clear()
                .Add("@codevaluacion", SqlDbType.Int).Value = CodEvaluacion
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With ProveedorEvaluacionBE
                        .codevaluacion = dr.ReadNullAsEmptyString("codevaluacion")
                        .codproveedor = dr.ReadNullAsEmptyString("codproveedor")
                        .idmotivo = dr.ReadNullAsEmptyString("idmotivo")
                        .motivo = dr.ReadNullAsEmptyString("motivo")
                        .fechamotivo = dr.ReadNullAsEmptyDate("fechamotivo")
                        .idcorrecion = dr.ReadNullAsEmptyString("idcorrecion")
                        .accion = dr.ReadNullAsEmptyString("accion")
                        .fechaaccion = dr.ReadNullAsEmptyDate("fechaaccion")
                        .idusuario = dr.ReadNullAsEmptyString("idusuario")
                        .fecharegistro = dr.ReadNullAsEmptyString("fecharegistro")
                    End With

                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw New Exception("ProveedorEvaluacionDAO.GetByIDProveedorEvaluacion - log_proveedor_evaluacion_get_id" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return ProveedorEvaluacionBE
    End Function

    Public Function GetByProveedorEvaluacionALL(ByVal CodProveedor As Int32) As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_proveedor_evaluacion_get_all"
            With .Parameters
                .Add("@codproveedor", SqlDbType.Int).Value = CodProveedor
            End With
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("ProveedorEvaluacionDAO.GetByProveedorEvaluacionALL - log_proveedor_evaluacion_get_all" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
End Class
