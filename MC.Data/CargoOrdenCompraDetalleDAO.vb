Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel.DataAnnotations

Public Class CargoOrdenCompraDetalleDAO
    Dim CargoOrdenCompraDetalleBE As New CargoOrdenCompraDetalleBE

    Public Function Save(ByVal BE As CargoOrdenCompraDetalleBE) As Boolean
        Dim Result As Boolean = False
        If BE.IDCargoOrdenCompraDetalle = 0 Then
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

    Public Function Insert(ByVal BE As CargoOrdenCompraDetalleBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_cargo_orden_compra_detalle_insert"
            With .Parameters
                .Clear()
                .Add("@idcargoordencompradetalle", SqlDbType.Int).Value = BE.IDCargoOrdenCompraDetalle
                .Add("@idcargoordencompra", SqlDbType.Int).Value = BE.IDCargoOrdenCompra
                .Add("@idproducto", SqlDbType.Int).Value = BE.IDProducto
                .Add("@lote", SqlDbType.VarChar, 20).Value = BE.Lote
                .Add("@fechavencimiento", SqlDbType.DateTime).Value = BE.FechaVencimiento
                .Add("@cantidadingreso", SqlDbType.Decimal).Value = BE.CantidadIngreso
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("CargoOrdenCompraDetalleDAO.Insert - log_cargo_orden_compra_detalle_insert" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Update(ByVal BE As CargoOrdenCompraDetalleBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_cargo_orden_compra_detalle_update"
            With .Parameters
                .Clear()
                .Add("@idcargoordencompradetalle", SqlDbType.Int).Value = BE.IDCargoOrdenCompraDetalle
                .Add("@idcargoordencompra", SqlDbType.Int).Value = BE.IDCargoOrdenCompra
                .Add("@idproducto", SqlDbType.Int).Value = BE.IDProducto
                .Add("@lote", SqlDbType.VarChar, 20).Value = BE.Lote
                .Add("@fechavencimiento", SqlDbType.DateTime).Value = BE.FechaVencimiento
                .Add("@cantidadingreso", SqlDbType.Decimal).Value = BE.CantidadIngreso
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("CargoOrdenCompraDetalleDAO.Update - log_cargo_orden_compra_detalle_update" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Delete(ByVal IDCargoOrdenCompraDetalle As Int32) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_cargo_orden_compra_detalle_delete"
            With .Parameters
                .Clear()
                .Add("@idcargoordencompradetalle", SqlDbType.Int).Value = IDCargoOrdenCompraDetalle
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("CargoOrdenCompraDetalleDAO.Delete - log_cargo_orden_compra_detalle_delete" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Validar(ByVal BE As CargoOrdenCompraDetalleBE) As List(Of ValidationResult)
        Dim Lista As New List(Of ValidationResult)
        Dim vc As New ValidationContext(BE, Nothing, Nothing)
        Try
            Validator.TryValidateObject(BE, vc, Lista, True)
        Catch ex As Exception
            Throw New Exception("CargoOrdenCompraDetalleDAO.Validar" & vbCrLf & ex.Message)
        End Try
        Return Lista
    End Function

    Public Function GetByCargoOrdenCompraDetalleID(ByVal IDCargoOrdenCompraDetalle As String) As CargoOrdenCompraDetalleBE
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_cargo_orden_compra_detalle_get_id"
            With .Parameters
                .Clear()
                .Add("@idcargoordencompradetalle", SqlDbType.Int).Value = IDCargoOrdenCompraDetalle
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read()
                    With CargoOrdenCompraDetalleBE
                        .IDCargoOrdenCompraDetalle = dr.ReadNullAsEmptyString("idcargoordencompradetalle")
                        .IDCargoOrdenCompra = dr.ReadNullAsEmptyString("idcargoordencompra")
                        .IDProducto = dr.ReadNullAsEmptyString("idproducto")
                        .Lote = dr.ReadNullAsEmptyString("lote")
                        .FechaVencimiento = dr.ReadNullAsEmptyString("fechavencimiento")
                        .CantidadIngreso = dr.ReadNullAsEmptyString("cantidadingreso")
                    End With
                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw New Exception("CargoOrdenCompraDetalleDAO.GetByCargoOrdenCompraDetalleID - log_cargo_orden_compra_detalle_get_id" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return CargoOrdenCompraDetalleBE
    End Function

    Public Function GetByCargoOrdenCompraDetalleALL(ByVal IDNumeroOrden As Int32) As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_cargo_orden_compra_detalle_get_all"
            With .Parameters
                .Add("@idnumeroorden", SqlDbType.Int).Value = IDNumeroOrden
            End With
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("CargoOrdenCompraDetalleDAO.GetByCargoOrdenCompraDetalleALL - log_cargo_orden_compra_detalle_get_all" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetByCargoOrdenCompraDetalleIDCargoOrdenCompraDetalle(ByVal IDCargoOrdenCompra As Int32) As IList(Of Object)
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing
        Dim lista As New List(Of Object)

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_cargo_orden_compra_detalle_get_idcargoordencompradetalle"
            With .Parameters
                .Add("@idcargoordencompra", SqlDbType.Int).Value = IDCargoOrdenCompra
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    lista.Add(dr.ReadNullAsNumeric("idcargoordencompradetalle"))
                End While
            End If

        Catch ex As Exception
            Throw New Exception("CargoOrdenCompraDetalleDAO.GetByCargoOrdenCompraDetalleIDCargoOrdenCompraDetalle - log_cargo_orden_compra_detalle_get_idcargoordencompradetalle" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return lista
    End Function
End Class
