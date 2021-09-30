Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel.DataAnnotations

Public Class CargoOrdenCompraDAO
    'propiedades
    Property IDCargoOrdenCompra As Int32
    Dim CargoOrdenCompraBE As New CargoOrdenCompraBE

    Public Function Save(ByVal BE As CargoOrdenCompraBE) As Boolean
        Dim Result As Boolean = False

        If BE.IDCargoOrdenCompra = 0 Then
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

    Public Function Insert(ByVal BE As CargoOrdenCompraBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_cargo_orden_compra_insert"
            With .Parameters
                .Clear()
                .Add("@idcargoordencompra", SqlDbType.Int).Direction = ParameterDirection.Output
                .Add("@idnumeroorden", SqlDbType.Int).Value = BE.IDNumeroOrden
                .Add("@fechaingreso", SqlDbType.DateTime).Value = BE.FechaIngreso
                .Add("@numerofactura", SqlDbType.VarChar, 20).Value = BE.NumeroFactura
                .Add("@numeroguiaremision", SqlDbType.VarChar, 20).Value = BE.NumeroGuiaRemision
                .Add("@observaciones", SqlDbType.VarChar, -1).Value = BE.Observaciones
                .Add("@estado", SqlDbType.Int).Value = BE.Estado
                .Add("@idusuario", SqlDbType.Int).Value = BE.IDUsuario
                .Add("@fecharegistro", SqlDbType.DateTime).Value = BE.FechaRegistro
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                IDCargoOrdenCompra = cmd.Parameters("@idcargoordencompra").Value
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("CargoOrdenCompraDAO.Insert - log_cargo_orden_compra_insert" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Update(ByVal BE As CargoOrdenCompraBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_cargo_orden_compra_update"
            With .Parameters
                .Clear()
                .Add("@idcargoordencompra", SqlDbType.Int).Value = BE.IDCargoOrdenCompra
                .Add("@idnumeroorden", SqlDbType.Int).Value = BE.IDNumeroOrden
                .Add("@fechaingreso", SqlDbType.DateTime).Value = BE.FechaIngreso
                .Add("@numerofactura", SqlDbType.VarChar, 20).Value = BE.NumeroFactura
                .Add("@numeroguiaremision", SqlDbType.VarChar, 20).Value = BE.NumeroGuiaRemision
                .Add("@observaciones", SqlDbType.VarChar, -1).Value = BE.Observaciones
                .Add("@estado", SqlDbType.Int).Value = BE.Estado
                .Add("@idusuario", SqlDbType.Int).Value = BE.IDUsuario
                .Add("@fecharegistro", SqlDbType.DateTime, 10).Value = BE.FechaRegistro
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("CargoOrdenCompraDAO.Update - log_cargo_orden_compra_update" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Delete(ByVal IDCargoOrdenCompra As Int32) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_cargo_orden_compra_delete"
            With .Parameters
                .Clear()
                .Add("@idcargoordencompra", SqlDbType.Int).Value = IDCargoOrdenCompra
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("CargoOrdenCompraDAO.Delete - log_cargo_orden_compra_delete" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Validar(ByVal BE As CargoOrdenCompraBE) As List(Of ValidationResult)
        Dim Lista As New List(Of ValidationResult)
        Dim vc As New ValidationContext(BE, Nothing, Nothing)
        Try
            Validator.TryValidateObject(BE, vc, Lista, True)
        Catch ex As Exception
            Throw New Exception("CargoOrdenCompraDAO.Delete - log_cargo_orden_compra_delete" & vbCrLf & ex.Message)
        End Try
        Return Lista
    End Function

    Public Function GetByCargoOrdenCompraID(ByVal IDCargoOrdenCompra As String) As CargoOrdenCompraBE
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_cargo_orden_compra_get_id"
            With .Parameters
                .Clear()
                .Add("@idcargoordencompra", SqlDbType.Int).Value = IDCargoOrdenCompra
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With CargoOrdenCompraBE
                        .IDCargoOrdenCompra = dr.ReadNullAsNumeric("idcargoordencompra")
                        .IDNumeroOrden = dr.ReadNullAsNumeric("idnumeroorden")
                        .FechaIngreso = dr.ReadNullAsEmptyDate("fechaingreso")
                        .NumeroFactura = dr.ReadNullAsEmptyString("numerofactura")
                        .NumeroGuiaRemision = dr.ReadNullAsEmptyString("numeroguiaremision")
                        .Observaciones = dr.ReadNullAsEmptyString("observaciones")
                        .Estado = dr.ReadNullAsNumeric("estado")
                        .IDUsuario = dr.ReadNullAsNumeric("idusuario")
                        .FechaRegistro = dr.ReadNullAsEmptyDate("fecharegistro")
                    End With
                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw New Exception("CargoOrdenCompraDAO.GetByCargoOrdenCompraID - log_cargo_orden_compra_get_id" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return CargoOrdenCompraBE
    End Function

    Public Function GetByCargoOrdenComprasALL(ByVal IDNumeroOrden As Int32) As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_cargo_orden_compra_get_all"
            With .Parameters
                .Add("@idnumeroorden", SqlDbType.Int).Value = IDNumeroOrden
            End With
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("CargoOrdenCompraDAO.GetByCargoOrdenCompras - log_cargo_orden_compra_get_all" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetByCargaOrdenCompras_OrdenCompraDetalle(ByVal IDNumeroOrden As Int32) As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_cargo_orden_compra_get_orden_compra_detalle"
            With .Parameters
                .Add("@idnumeroorden", SqlDbType.Int).Value = IDNumeroOrden
            End With
        End With

        Try
            cnx.Open()
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception("CargoOrdenCompraDAO.GetByCargaOrdenCompras_OrdenCompraDetalle - cargo_orden_compra_get_orden_compra_detalle" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
End Class
