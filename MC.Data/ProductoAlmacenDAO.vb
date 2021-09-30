Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel.DataAnnotations

Public Class ProductoAlmacenDAO
    Property IDProductoAlmacen As Int32
    Dim ProductoAlmacenBE As New ProductoAlmacenBE


    Public Function Save(ByVal BE As ProductoAlmacenBE) As Boolean
        Dim Result As Boolean = False
        Try
            If BE.idproductoalmacen = 0 Then
                If Insert(BE) Then
                    Result = True
                End If
            Else
                If Update(BE) Then
                    Result = True
                End If
            End If
        Catch ex As Exception
            Throw New Exception("ProductoAlmacenDAO.Save" & vbCrLf & ex.Message)
        End Try
        Return Result
    End Function

    Public Function Insert(ByVal BE As ProductoAlmacenBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_producto_almacen_insert"
            With .Parameters
                .Clear()
                .Add("@idproductoalmacen", SqlDbType.Int).Direction = ParameterDirection.Output
                .Add("@idproducto", SqlDbType.Int).Value = BE.idproducto
                .Add("@idalmacen", SqlDbType.Int).Value = BE.idalmacen
                .Add("@entero", SqlDbType.Int).Value = BE.entero
                .Add("@fraccion", SqlDbType.Int).Value = BE.fraccion
                .Add("@codubicacion", SqlDbType.Char, 6).Value = BE.codubicacion
                .Add("@stockmaximo", SqlDbType.Int).Value = BE.stockmaximo
                .Add("@stockminimo", SqlDbType.Int).Value = BE.stockminimo
                .Add("@idusuario", SqlDbType.Int).Value = BE.idusuario
                .Add("@fecharegistro", SqlDbType.DateTime).Value = BE.fecharegistro
            End With
        End With
        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                IDProductoAlmacen = cmd.Parameters("@idproductoalmacen").Value
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("ProductoAlmacenDAO.Insert - log_producto_almacen_get_insert" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Update(ByVal BE As ProductoAlmacenBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_producto_almacen_get_update"
            With .Parameters
                .Clear()
                .Add("@idproductoalmacen", SqlDbType.Int).Value = BE.idproductoalmacen
                .Add("@idproducto", SqlDbType.Int).Value = BE.idproducto
                .Add("@idalmacen", SqlDbType.Int).Value = BE.idalmacen
                .Add("@entero", SqlDbType.Int).Value = BE.entero
                .Add("@fraccion", SqlDbType.Int).Value = BE.fraccion
                .Add("@codubicacion", SqlDbType.Char, 6).Value = BE.codubicacion
                .Add("@stockmaximo", SqlDbType.Int).Value = BE.stockmaximo
                .Add("@stockminimo", SqlDbType.Int).Value = BE.stockminimo
                .Add("@idusuario", SqlDbType.Int).Value = BE.idusuario
                .Add("@fecharegistro", SqlDbType.DateTime).Value = BE.fecharegistro
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                IDProductoAlmacen = BE.idproductoalmacen
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("ProductoAlmacenDAO.Update - log_producto_almacen_get_update" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Delete(ByVal IDProductoAlmacen As Int32) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_producto_almacen_delete"

            With .Parameters
                .Clear()
                .Add("@idproductoalmacen", SqlDbType.Int).Value = IDProductoAlmacen
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("ProductoAlmacenDAO.Delete - log_producto_almacen_delete" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Validar(ByVal BE As ProductoAlmacenBE) As IList(Of ValidationResult)
        Dim Lista As New List(Of ValidationResult)
        Dim vc As New ValidationContext(BE, Nothing, Nothing)
        Try
            Validator.TryValidateObject(BE, vc, Lista, True)
        Catch ex As Exception
            Throw New Exception("ProductoAlmacenDAO.Validar" & vbCrLf & ex.Message)
        End Try
        Return Lista
    End Function

    Public Function GetByIDProductoAlmacen(ByVal IDProductoAlmacen As Int32) As ProductoAlmacenBE
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing


        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_producto_almacen_get_id"

            With .Parameters
                .Clear()
                .Add("@idproductoalmacen", SqlDbType.Int).Value = IDProductoAlmacen
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read()
                    With ProductoAlmacenBE
                        .idproductoalmacen = dr.ReadNullAsEmptyString("idproductoalmacen")
                        .idproducto = dr.ReadNullAsEmptyString("idproducto")
                        .idalmacen = dr.ReadNullAsEmptyString("idalmacen")
                        .entero = dr.ReadNullAsEmptyString("entero")
                        .fraccion = dr.ReadNullAsEmptyString("fraccion")
                        .codubicacion = dr.ReadNullAsEmptyString("codubicacion")
                        .stockmaximo = dr.ReadNullAsEmptyString("stockmaximo")
                        .stockminimo = dr.ReadNullAsEmptyString("stockminimo")
                    End With
                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw New Exception("ProductoAlmacenDAO.GetByIDProductoAlmacen - log_producto_almacen_get_id" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return ProductoAlmacenBE
    End Function

    Public Function GetByProductoAlmacenALL(ByVal IDProducto) As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_producto_almacen_get_all"
            With .Parameters
                .Clear()
                .Add("idproducto", SqlDbType.Int).Value = IDProducto
            End With
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("ProductoAlmacenDAO.GetByProductoAlmacenALL - log_producto_almacen_get_all" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
End Class
