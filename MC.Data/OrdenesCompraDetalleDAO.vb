Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel.DataAnnotations

Public Class OrdenesCompraDetalleDAO
    'variables
    Dim OrdenesCompraDetalleBE As New OrdenesCompraDetalleBE

    Public Function Save(ByVal BE As OrdenesCompraDetalleBE) As Boolean
        Dim Result As Boolean = False
        If BE.idnumerodetalleorden = 0 Then
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

    Public Function Insert(ByVal BE As OrdenesCompraDetalleBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_ordencompra_detalle_insert"
            With .Parameters
                .Clear()
                .Add("@idnumerodetalleorden", SqlDbType.Int).Value = BE.idnumerodetalleorden
                .Add("@idnumeroorden", SqlDbType.Int).Value = BE.idnumeroorden
                .Add("@idproducto", SqlDbType.Int).Value = BE.idproducto
                .Add("@cantidad", SqlDbType.Float).Value = BE.cantidad
                .Add("@vvf", SqlDbType.Float).Value = BE.vvf
                .Add("@precio", SqlDbType.Float).Value = BE.precio
                .Add("@dscto1", SqlDbType.Float).Value = BE.dscto1
                .Add("@total", SqlDbType.Float).Value = BE.total
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("OrdenesCompraDetalleDAO.Insert - log_ordencompra_detalle_insert" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Update(ByVal BE As OrdenesCompraDetalleBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_ordencompra_detalle_update"
            With .Parameters
                .Clear()
                .Add("@idnumerodetalleorden", SqlDbType.Int).Value = BE.idnumerodetalleorden
                .Add("@idnumeroorden", SqlDbType.Int).Value = BE.idnumeroorden
                .Add("@idproducto", SqlDbType.Int).Value = BE.idproducto
                .Add("@cantidad", SqlDbType.Float).Value = BE.cantidad
                .Add("@vvf", SqlDbType.Float).Value = BE.vvf
                .Add("@precio", SqlDbType.Float).Value = BE.precio
                .Add("@total", SqlDbType.Float).Value = BE.total
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception("OrdenesCompraDetalleDAO.Update - log_ordencompra_detalle_update" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
    End Function

    Public Function Delete(ByVal IDNumeroDetalleOrden As Int32) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_ordencompra_detalle_delete"
            With .Parameters
                .Clear()
                .Add("@idnumerodetalleorden", SqlDbType.Int).Value = IDNumeroDetalleOrden
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("OrdenesCompraDetalleDAO.Delete - log_ordencompra_detalle_delete" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Validar(ByVal BE As OrdenesCompraDetalleBE) As List(Of ValidationResult)
        Dim Lista As New List(Of ValidationResult)
        Dim vc As New ValidationContext(BE, Nothing, Nothing)

        Try
            Validator.TryValidateObject(BE, vc, Lista, True)
        Catch ex As Exception
            Throw New Exception("OrdenesCompraDetalleDAO.Validar" & vbCrLf & ex.Message)
        End Try
        Return Lista
    End Function

    Public Function GetByOrdenesCompraDetalleID(ByVal IDOrdeneCompraDetalle As Int32) As OrdenesCompraDetalleBE
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_ordencompra_detalle_get_id"

            With .Parameters
                .Clear()
                .Add("@idnumerodetalleorden", SqlDbType.Int).Value = IDOrdeneCompraDetalle
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With OrdenesCompraDetalleBE
                        .idnumerodetalleorden = dr.ReadNullAsEmptyString("idnumerodetalleorden")
                        .idnumeroorden = dr.ReadNullAsEmptyString("idnumeroorden")
                        .idproducto = dr.ReadNullAsEmptyString("idproducto")
                        .cantidad = dr.ReadNullAsEmptyString("cantidad")
                        .vvf = dr.ReadNullAsNumeric("vvf")
                        .precio = dr.ReadNullAsEmptyString("precio")
                        .total = dr.ReadNullAsEmptyString("total")
                    End With

                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw New Exception("OrdenesCompraDetalleDAO.GetByOrdenesCompraDetalle - log_ordencompra_detalle_get_id" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return OrdenesCompraDetalleBE
    End Function

    Public Function GetByOrdenesCompraDetalleALL(ByVal IDNumeroOrden As Int32) As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_ordencompra_detalle_get_all"
            With .Parameters
                .Add("@idnumeroorden", SqlDbType.Int).Value = IDNumeroOrden
            End With
        End With

        Try
            cnx.Open()
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("OrdenesCompraDetalleDAO.GetByOrdenesCompraDetalleALL - log_ordencompra_detalle_get_all" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetByOrdenesCompraPrecioOrden(ByVal IDNumeroOrden As Int32, ByVal IDProducto As Int32) As OrdenesCompraDetalleBE
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing
        Dim OrdenesCompraDetalleBE As New OrdenesCompraDetalleBE

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_orden_compra_detalle_get_precio_orden"
            With .Parameters
                .Add("@idordencompra", SqlDbType.Int).Value = IDNumeroOrden
                .Add("@idproducto", SqlDbType.Int).Value = IDProducto
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    With OrdenesCompraDetalleBE
                        .idnumerodetalleorden = dr.ReadNullAsNumeric("idnumerodetalleorden")
                        .idnumeroorden = dr.ReadNullAsNumeric("idnumeroorden")
                        .idproducto = dr.ReadNullAsNumeric("idproducto")
                        .cantidad = dr.ReadNullAsNumeric("cantidad")
                        .vvf = dr.ReadNullAsNumeric("vvf")
                        .precio = dr.ReadNullAsNumeric("precio")
                        .dscto1 = dr.ReadNullAsNumeric("dscto1")
                        .total = dr.ReadNullAsNumeric("total")
                    End With
                End While
            End If
        Catch ex As Exception
            Throw New Exception("OrdenesCompraDetalleDAO.GetByOrdenesCompraPrecioOrden - log_orden_compra_detalle_get_precio_orden" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return OrdenesCompraDetalleBE
    End Function
End Class
