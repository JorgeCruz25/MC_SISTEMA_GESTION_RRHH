Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel.DataAnnotations

Public Class GuiaAlmacenBE
    Property IDGuiaAlmacen As Int32
    Property NumeroGuiaAlmacen As String

    <Required(ErrorMessage:="Campo obligatorio")>
    <Range(1, Int32.MaxValue, ErrorMessage:="Campo obligatorio")>
    Property IDOperacion As Int32

    Property FechaEmision As DateTime
    Property Estado As Int32
    Property FechaAnulacion As Nullable(Of DateTime)

    <Required(ErrorMessage:="Campo obligatorio")>
    <Range(1, Int32.MaxValue, ErrorMessage:="Campo obligatorio")>
    Property IDAlmacenOrigen As Int32

    <Required(ErrorMessage:="Campo obligatorio")>
    <Range(1, Int32.MaxValue, ErrorMessage:="Campo obligatorio")>
    Property IDAlmacenDestino As Int32

    Property IDUsuario As Int32
    Property FechaRegistro As Nullable(Of DateTime)
End Class

Public Class GuiaAlmacenDetalleBE
    Public Property IDGuiaAlmacenDetalle As Int32
    Public Property IDGuiaAlmacen As Int32

    <Required(ErrorMessage:="Campo obligatorio")>
    <Range(1, Int32.MaxValue, ErrorMessage:="Campo Obligatorio")>
    Public Property IDProducto As Int32

    <Required(ErrorMessage:="Campo obligatorio")>
    <Range(1, Single.MaxValue, ErrorMessage:="Campo Obligatorio")>
    Public Property Cantidad As Single

    Public Property FechaVencimiento As DateTime
    Public Property Lote As String
End Class

Public Class GuiaAlmacenDAO
    Property IDGuiaAlmacen As Int32
    Property IDGuiaAlmacenDetalle As Int32
    Dim GuiaAlmacenBE As New GuiaAlmacenBE
    Dim GuiaAlmacenDetalleBE As New GuiaAlmacenDetalleBE

    Public Function Save(ByVal BE As GuiaAlmacenBE) As Boolean
        Dim Result As Boolean = False
        If BE.IDGuiaAlmacen = 0 Then
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

    Public Function Insert(ByVal BE As GuiaAlmacenBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_guias_almacen_insert"
            With .Parameters
                .Add("@idguiaalmacen", SqlDbType.Int).Direction = ParameterDirection.Output
                .Add("@numeroguiaalmacen", SqlDbType.VarChar, 15).Value = BE.NumeroGuiaAlmacen
                .Add("@idoperacion", SqlDbType.Int).Value = BE.IDOperacion
                .Add("@fechaemision", SqlDbType.DateTime).Value = BE.FechaEmision
                .Add("@estado", SqlDbType.Int).Value = BE.Estado
                .Add("@fechaanulacion", SqlDbType.DateTime).Value = BE.FechaAnulacion
                .Add("@idalmacenorigen", SqlDbType.Int).Value = BE.IDAlmacenOrigen
                .Add("@idalmacendestino", SqlDbType.Int).Value = BE.IDAlmacenDestino
                .Add("@idusuario", SqlDbType.Int).Value = BE.IDUsuario
                .Add("@fecharegistro", SqlDbType.DateTime).Value = BE.FechaRegistro
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery > 0 Then
                IDGuiaAlmacen = cmd.Parameters("@idguiaalmacen").Value
                result = True
            End If
        Catch ex As Exception
            Throw New Exception("GuiaAlmacenDAO.Insert - log_guias_almacen_insert" & vbCrLf & ex.Message)
        End Try
        Return result
    End Function

    Public Function Update(ByVal BE As GuiaAlmacenBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_guias_almacen_update"
            With .Parameters
                .Add("@idguiaalmacen", SqlDbType.Int).Value = BE.IDGuiaAlmacen
                .Add("@numeroguiaalmacen", SqlDbType.VarChar, 15).Value = BE.NumeroGuiaAlmacen
                .Add("@idoperacion", SqlDbType.Int).Value = BE.IDOperacion
                .Add("@fechaemision", SqlDbType.DateTime).Value = BE.FechaEmision
                .Add("@estado", SqlDbType.Int).Value = BE.Estado
                .Add("@fechaanulacion", SqlDbType.DateTime).Value = BE.FechaAnulacion
                .Add("@idalmacenorigen", SqlDbType.Int).Value = BE.IDAlmacenOrigen
                .Add("@idalmacendestino", SqlDbType.Int).Value = BE.IDAlmacenDestino
                .Add("@idusuario", SqlDbType.Int).Value = BE.IDUsuario
                .Add("@fecharegistro", SqlDbType.DateTime).Value = BE.FechaRegistro
            End With
        End With
        Try
            cnx.Open()
            If cmd.ExecuteNonQuery > 0 Then
                IDGuiaAlmacen = BE.IDGuiaAlmacen
                result = True
            End If
        Catch ex As Exception
            Throw New Exception("GuiaAlmacenDAO.Update - log_guias_almacen_update" & vbCrLf & ex.Message)
        End Try
        Return result
    End Function

    Public Function Validar(ByVal BE As GuiaAlmacenBE) As List(Of ValidationResult)
        Dim lista As New List(Of ValidationResult)
        Dim vc As New ValidationContext(BE, Nothing, Nothing)
        Try
            Validator.TryValidateObject(BE, vc, lista, True)
        Catch ex As Exception
            Throw New Exception("GuiaAlmacenDAO.Validar")
        End Try
        Return lista
    End Function

    Public Function GetByGuiaAlmacenALL(ByVal IDNumeroPagina As Int32) As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_guias_almacen_get_all"
            With .Parameters
                .Add("@numeropagina", SqlDbType.Int).Value = IDNumeroPagina
            End With
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("GuiaAlmacenDAO.GuiaAlmacenALL - log_guias_almacen_get_all" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetByGuiaAlmacenID(ByVal IDGuiaAlmacen As Int32) As GuiaAlmacenBE
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing
        Dim GuiaAlmacenBE As New GuiaAlmacenBE

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_guias_almacen_get_id"
            With .Parameters
                .Add("@idguiaalmacen", SqlDbType.Int).Value = IDGuiaAlmacen
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    With GuiaAlmacenBE
                        .IDGuiaAlmacen = dr.ReadNullAsNumeric("idguiaalmacen")
                        .NumeroGuiaAlmacen = dr.ReadNullAsEmptyString("numeroguiaalmacen")
                        .IDOperacion = dr.ReadNullAsNumeric("idoperacion")
                        .FechaEmision = dr.ReadNullAsEmptyDate("fechaemision")
                        .Estado = dr.ReadNullAsNumeric("estado")
                        .FechaAnulacion = dr.ReadNullAsEmptyDate("fechaanulacion")
                        .IDAlmacenOrigen = dr.ReadNullAsNumeric("idalmacenorigen")
                        .IDAlmacenDestino = dr.ReadNullAsNumeric("idalmacendestino")
                        .FechaRegistro = dr.ReadNullAsEmptyDate("fecharegistro")
                        .IDUsuario = dr.ReadNullAsNumeric("idusuario")
                    End With
                End While
            End If
        Catch ex As Exception
            Throw New Exception("GuiaAlmacenDAO.GuiaAlmacenALL - log_guias_almacen_get_all" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return GuiaAlmacenBE
    End Function

    'guia almacén detalle

    Public Function SaveDetalle(ByVal BE As GuiaAlmacenDetalleBE) As Boolean
        Dim Result As Boolean = False
        If BE.IDGuiaAlmacenDetalle = 0 Then
            If InsertDetalle(BE) Then
                Result = True
            End If
        Else
            If UpdateDetalle(BE) Then
                Result = True
            End If
        End If
        Return Result
    End Function

    Public Function InsertDetalle(ByVal BE As GuiaAlmacenDetalleBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_guias_almacen_detalle_insert"
            With .Parameters
                .Add("@idguiaalmacendetalle", SqlDbType.Int).Value = BE.IDGuiaAlmacenDetalle
                .Add("@idguiaalmacen", SqlDbType.Int).Value = BE.IDGuiaAlmacen
                .Add("@idproducto", SqlDbType.Int).Value = BE.IDProducto
                .Add("@cantidad", SqlDbType.Float).Value = BE.Cantidad
                .Add("@fechavencimiento", SqlDbType.DateTime).Value = BE.FechaVencimiento
                .Add("@lote", SqlDbType.VarChar, 20).Value = BE.Lote
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery > 0 Then
                IDGuiaAlmacenDetalle = cmd.Parameters("@idguiaalmacendetalle").Value
                result = True
            End If
        Catch ex As Exception
            Throw New Exception("GuiaAlmacenDAO.InsertDetalle - log_guias_almacen_detalle_insert" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return result
    End Function

    Public Function UpdateDetalle(ByVal BE As GuiaAlmacenDetalleBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_guias_almacen_detalle_update"
            With .Parameters
                .Add("@idguiaalmacendetalle", SqlDbType.Int).Value = BE.IDGuiaAlmacenDetalle
                .Add("@idguiaalmacen", SqlDbType.Int).Value = BE.IDGuiaAlmacen
                .Add("@idproducto", SqlDbType.Int).Value = BE.IDProducto
                .Add("@cantidad", SqlDbType.Float).Value = BE.Cantidad
                .Add("@fechavencimiento", SqlDbType.DateTime).Value = BE.FechaVencimiento
                .Add("@lote", SqlDbType.VarChar, 20).Value = BE.Lote
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery > 0 Then
                IDGuiaAlmacenDetalle = BE.IDGuiaAlmacenDetalle
                result = True
            End If
        Catch ex As Exception
            Throw New Exception("GuiaAlmacenDAO.GuiaAlmacenALL - log_guias_almacen_get_all" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return result
    End Function

    Public Function DeleteDetalle(ByVal IDGuiaAlmacenDetalle As Int32) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_guias_almacen_detalle_delete"
            With .Parameters
                .Add("@idguiaalmacendetalle", SqlDbType.Int).Value = IDGuiaAlmacenDetalle
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery > 0 Then
                result = True
            End If
        Catch ex As Exception
            Throw New Exception("GuiaAlmacenDAO.DeleteDetalle - log_guias_almacen_detalle_delete" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return result
    End Function

    Public Function ValidarDetalle(ByVal BE As GuiaAlmacenDetalleBE) As List(Of ValidationResult)
        Dim lista As New List(Of ValidationResult)
        Dim vc As New ValidationContext(BE, Nothing, Nothing)
        Try
            Validator.TryValidateObject(BE, vc, lista, True)
        Catch ex As Exception
            Throw New Exception("GuiaAlmacenDAO.ValidarDetalle" & vbCrLf & ex.Message)
        End Try
        Return lista
    End Function

    Public Function GetByGuiaAlmacenDetalleALL(ByVal IDGuiaAlmacen As Int32) As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_guias_almacen_detalle_all"
            With .Parameters
                .Add("@idguiaalmacen", SqlDbType.Int).Value = IDGuiaAlmacen
            End With
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("GuiaAlmacenDAO.GuiaAlmacenDetalleALL - log_guias_almacen_detalle_all" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetByGuiaAlmacenDetalleID(ByVal IDGuiaAlmacenDetalle As Int32) As GuiaAlmacenDetalleBE
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing
        Dim GuiaAlmacenDetalleBE As New GuiaAlmacenDetalleBE

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_guias_almacen_detalle_id"
            With .Parameters
                .Add("@idguiaalmacendetalle", SqlDbType.Int).Value = IDGuiaAlmacenDetalle
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    With GuiaAlmacenDetalleBE
                        .IDGuiaAlmacenDetalle = dr.ReadNullAsNumeric("idguiaalmacendetalle")
                        .IDGuiaAlmacen = dr.ReadNullAsNumeric("idguiaalmacendetalle")
                        .IDProducto = dr.ReadNullAsNumeric("idproducto")
                        .Cantidad = dr.ReadNullAsNumeric("cantidad")
                        .FechaVencimiento = dr.ReadNullAsEmptyDate("fechavencimiento")
                        .Lote = dr.ReadNullAsEmptyString("lote")
                    End With
                End While
            End If
        Catch ex As Exception
            Throw New Exception("GuiaAlmacenDAO.GuiaAlmacenDetalleID - log_guias_almacen_detalle_id" & vbCrLf & ex.Message)
        End Try
        Return GuiaAlmacenDetalleBE
    End Function

    Public Function GetByGuiaAlmacenDetalleIDGuiaAlmacenDetalle(ByVal IDGuiaAlmacen As Int32) As List(Of Object)
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing
        Dim Lista As New List(Of Object)

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_guias_almacen_detalle_get_idguiaalmacendetalle"
            With .Parameters
                .Add("@idguiaalmacen", SqlDbType.Int).Value = IDGuiaAlmacen
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    With Lista
                        .Add(dr.ReadNullAsNumeric("idguiaalmacendetalle"))
                    End With
                End While
            End If
        Catch ex As Exception
            Throw New Exception("GuiaAlmacenDAO.GetByGuiaAlmacenDetalleIDGuiaAlmacenDetalle - log_guias_almacen_detalle_get_idguiaalmacendetalle" & vbCrLf & ex.Message)
        End Try
        Return Lista
    End Function
End Class