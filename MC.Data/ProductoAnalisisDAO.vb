Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel.DataAnnotations

Public Class ProductoAnalisisDAO
    Property IDProductoAnalisis As Int32
    Dim ProductoAnalisisBE As New ProductoAnalisisBE

    Public Function Save(BE As ProductoAnalisisBE) As Boolean
        Dim Result As Boolean = False
        Try
            If BE.idproductoanalisis = 0 Then
                If Insert(BE) Then
                    Result = True
                End If
            Else
                If Update(BE) Then
                    Result = True
                End If
            End If
        Catch ex As Exception
            Throw New Exception("ProductoAnlisisDAO.Save" & vbCrLf & ex.Message)
        End Try
        Return Result
    End Function

    Public Function Insert(ByVal BE As ProductoAnalisisBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_producto_analisis_insert"
            With .Parameters
                .Clear()
                .Add("@idproductoanalisis", SqlDbType.Int).Direction = ParameterDirection.Output
                .Add("@idproducto", SqlDbType.Int).Value = BE.idproducto
                .Add("@codanalisis", SqlDbType.Char, 8).Value = BE.codanalisis
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                IDProductoAnalisis = cmd.Parameters("@idproductoanalisis").Value
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("ProductoAnlisisDAO.Insert - log_producto_analisis_insert" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Update(ByVal BE As ProductoAnalisisBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_producto_analisis_update"

            With .Parameters
                .Clear()
                .Add("@idproductoanalisis", SqlDbType.Int).Value = BE.idproductoanalisis
                .Add("@idproducto", SqlDbType.Int).Value = BE.idproducto
                .Add("@codanalisis", SqlDbType.Char, 8).Value = BE.codanalisis
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("ProductoAnlisisDAO.Update - log_producto_analisis_update" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Delete(ByVal IdProductoAnalisis As Int32) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_producto_analisis_delete"
            With .Parameters
                .Clear()
                .Add("@idproductoanalisis", SqlDbType.Int).Value = IdProductoAnalisis
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("ProductoAnlisisDAO.Delete - log_producto_analisis_delete" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Validar(ByVal BE As ProductoAnalisisBE) As IList(Of ValidationResult)
        Dim Lista As New List(Of ValidationResult)
        Dim vc As New ValidationContext(BE, Nothing, Nothing)

        Try
            Validator.TryValidateObject(BE, vc, Lista, True)
        Catch ex As Exception
            Throw New Exception("ProductoAnlisisDAO.Validar" & vbCrLf & ex.Message)
        End Try
        Return Lista
    End Function

    Public Function GetByIDProductoAnalisis(ByVal IDProductoAnalisis As Int32) As ProductoAnalisisBE
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_producto_analisis_get_id"
            With .Parameters
                .Clear()
                .Add("@idproductoanalisis", SqlDbType.Int).Value = IDProductoAnalisis
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With ProductoAnalisisBE
                        .idproductoanalisis = dr.ReadNullAsEmptyString("idproductoanalisis")
                        .idproducto = dr.ReadNullAsEmptyString("idproducto")
                        .codanalisis = dr.ReadNullAsEmptyString("codanalisis")
                    End With
                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw New Exception("ProductoAnlisisDAO.GetByIDProductoAnalisis - log_producto_analisis_get_id" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return ProductoAnalisisBE
    End Function

    Public Function GetByProductoAnalisisALL(ByVal IDProducto As Int32) As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_producto_analisis_get_all"
            With .Parameters
                .Clear()
                .Add("@idproducto", SqlDbType.Int).Value = IDProducto
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

    Public Function GetByProductoAnalisisValidar(ByVal idproducto As Int32, ByVal CodAnalisis As String) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing
        Dim Result As Boolean = True

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_producto_analisis_get_validar"
            With .Parameters
                .Add("@idproducto", SqlDbType.Int).Value = idproducto
                .Add("@codana", SqlDbType.VarChar, 8).Value = CodAnalisis
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    Result = False
                End While
            End If
        Catch ex As Exception
            Throw New Exception("ProductoAnlisisDAO.GetByProductoAnalisisValidar - log_producto_analisis_get_validar" & vbCrLf & vbCrLf)
        End Try
        Return Result
    End Function

End Class
