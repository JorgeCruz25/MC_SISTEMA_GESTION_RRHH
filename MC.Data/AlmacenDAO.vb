Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel.DataAnnotations

Public Class AlmacenBE
    Property idalmacen() As Int32

    <Required(ErrorMessage:="El campo obligatorio")>
    <StringLength(150, MinimumLength:=1, ErrorMessage:="El nombre del almacén debe tener mínimo un carácter")>
    Property nombrealmacen() As String

    <Required(ErrorMessage:="El campo obligatorio")>
    <Range(1, Int32.MaxValue, ErrorMessage:="El campo es obligatorio")>
    Property codloc() As String

    Property tipoalmacen As Int32
    Property activo() As Boolean
    Property almacencentral As Int32
    Property idusuario() As String
    Property fecregistro() As DateTime
End Class

Public Class AlmacenMovimientoBE
    Public Property idmovimiento As Int32
    Public Property idoperacion() As Int32
    Public Property fechamovimiento() As Nullable(Of DateTime)
    Public Property idnumeroorden() As Int32
    Public Property idproducto() As Int32
    Public Property cantidad() As Double
    Public Property precio() As Double
    Public Property iddocumento() As Double
    Public Property lote() As String
    Public Property fechavencimiento() As Nullable(Of DateTime)
    Public Property idalmacen() As Int32
    Public Property idusuario() As Int32
    Public Property fecharegistro() As DateTime
End Class
Public Class AlmacenCierreBE
    Public Property IDCierreInventario As Int32
    Public Property IDProducto As Int32
    Public Property Stock As Single
    Public Property FechaInventario As DateTime
    Public Property IDUsuario As Int32
    Public Property FechaRegistro As DateTime
End Class
Public Class AlmacenStockBE
    Public Property IDAlmacenStock As Int32
    Public Property IDAlmacen As Int32
    Public Property IDProducto As Int32
    Public Property StockActual As Single
    Public Property IDUsuario As Int32
    Public Property FechaRegistro As DateTime
End Class

Public Class AlmacenDAO
    Property FechaAnulación As DateTime
    Property IDAlmacen As Int32

    Dim MovimientoBE As New AlmacenMovimientoBE
    Dim AlmacenBE As New AlmacenBE

    Public Function Save(BE As AlmacenBE)
        Dim Result As Boolean = False
        If BE.idalmacen = 0 Then
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
    Public Function Insert(ByVal BE As AlmacenBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_almacen_insert"
            With .Parameters
                .Clear()
                .Add("@idalmacen", SqlDbType.Int).Direction = ParameterDirection.Output
                .Add("@nombrealmacen", SqlDbType.VarChar, 150).Value = BE.nombrealmacen
                .Add("@codloc", SqlDbType.Char, 2).Value = BE.codloc
                .Add("@tipoalmacen", SqlDbType.TinyInt).Value = BE.tipoalmacen
                .Add("@activo", SqlDbType.Bit).Value = BE.activo
                .Add("@almacencentral", SqlDbType.Int).Value = BE.almacencentral
                .Add("@idusuario", SqlDbType.Char, 4).Value = BE.idusuario
                .Add("@fecregistro", SqlDbType.DateTime).Value = BE.fecregistro
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
                IDAlmacen = cmd.Parameters("@idalmacen").Value
            End If
        Catch ex As Exception
            Throw New Exception("AlmacenDAO.Insert - log_almacen_insert" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function
    Public Function Update(ByVal BE As AlmacenBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_almacen_update"

            With .Parameters
                .Clear()
                .Add("@idalmacen", SqlDbType.Int).Value = BE.idalmacen
                .Add("@nombrealmacen", SqlDbType.VarChar, 150).Value = BE.nombrealmacen
                .Add("@codloc", SqlDbType.Char, 2).Value = BE.codloc
                .Add("@tipoalmacen", SqlDbType.TinyInt).Value = BE.tipoalmacen
                .Add("@activo", SqlDbType.Bit).Value = BE.activo
                .Add("@almacencentral", SqlDbType.Int).Value = BE.almacencentral
                .Add("@idusuario", SqlDbType.Char, 4).Value = BE.idusuario
                .Add("@fecregistro", SqlDbType.DateTime).Value = BE.fecregistro
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
                IDAlmacen = BE.idalmacen
            End If
        Catch ex As Exception
            Throw New Exception("AlmacenDAO.Update - log_almacen_update" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function
    Public Function Delete(ByVal IDAlmacen As Int32) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_almacen_delete"

            With .Parameters
                .Clear()
                .Add("@idalmacen", SqlDbType.Int).Value = IDAlmacen
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("AlmacenDAO.Delete - log_almacen_delete" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function
    Public Function Validar(ByVal AlmacenBE As AlmacenBE) As IList(Of ValidationResult)
        Dim Lista As New List(Of ValidationResult)
        Dim vc As New ValidationContext(AlmacenBE, Nothing, Nothing)

        Try
            Validator.TryValidateObject(AlmacenBE, vc, Lista, True)
        Catch ex As Exception

        End Try
        Return Lista
    End Function

    Public Function SaveAlmacenMovimiento(ByVal BE As AlmacenMovimientoBE) As Boolean
        Dim Result As Boolean = False

        If BE.idmovimiento = 0 Then
            If InsertAlmacenMovimiento(BE) Then
                Result = True
            End If
        End If
        Return Result
    End Function
    Public Function InsertAlmacenMovimiento(ByVal BE As AlmacenMovimientoBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_almacen_movimiento_insert"
            With .Parameters
                .Clear()
                .Add("@idmovimiento", SqlDbType.Int).Value = BE.idmovimiento
                .Add("@idoperacion", SqlDbType.Int).Value = BE.idoperacion
                .Add("@fechamovimiento", SqlDbType.DateTime).Value = BE.fechamovimiento
                .Add("@idproducto", SqlDbType.Int).Value = BE.idproducto
                .Add("@cantidad", SqlDbType.Float).Value = BE.cantidad
                .Add("@precio", SqlDbType.Float).Value = BE.precio
                .Add("@iddocumento", SqlDbType.Int).Value = BE.iddocumento
                .Add("@lote", SqlDbType.VarChar, 20).Value = BE.lote
                .Add("@fechavencimiento", SqlDbType.DateTime).Value = BE.fechavencimiento
                .Add("@idalmacen", SqlDbType.Int).Value = BE.idalmacen
                .Add("@idusuario", SqlDbType.Int).Value = BE.idusuario
                .Add("@fecharegistro", SqlDbType.DateTime).Value = BE.fecharegistro
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("AlmacenDAO.InsertAlmacenMovimiento - log_almacen_movimiento_insert" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function SaveAlmacenInventario(ByVal BE As AlmacenCierreBE) As Boolean
        Dim Result As Boolean = False
        If BE.IDCierreInventario = 0 Then
            If InsertAlmacenInventario(BE) Then
                Result = True
            End If
        End If
        Return Result
    End Function
    Public Function InsertAlmacenInventario(ByVal BE As AlmacenCierreBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_almacen_cierre_insert"
            With .Parameters
                .Add("@idcierreinventario", SqlDbType.Int).Value = BE.IDCierreInventario
                .Add("@idproducto", SqlDbType.Int).Value = BE.IDProducto
                .Add("@stock", SqlDbType.Float).Value = BE.Stock
                .Add("@fechainventario", SqlDbType.DateTime).Value = BE.FechaInventario
                .Add("@idusuario", SqlDbType.Int).Value = BE.IDUsuario
                .Add("@fecharegistro", SqlDbType.DateTime).Value = BE.FechaRegistro
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery > 0 Then
                result = True
            End If
        Catch ex As Exception
            Throw New Exception("AlmacenDAO.InsertAlmacenInventario - log_almacen_cierre_insert")
        End Try
        Return result
    End Function
    Public Function GenerarCierre(ByVal FechaFinal As DateTime, ByVal IDUsuario As Int32) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_almacen_cierre_generar"
            With .Parameters
                .Add("@fechafinal", SqlDbType.DateTime).Value = FechaFinal
                .Add("@idusuario", SqlDbType.Int).Value = IDUsuario
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery > 0 Then
                result = True
            End If
        Catch ex As Exception
            Throw New Exception("AlmacenDAO.GenerarCierre - log_almacen_cierre_generar")
        End Try
        Return result
    End Function

    Public Function GetByIDAlmacen(ByVal IDAlmacen As Int32) As AlmacenBE
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_almacen_get_id"

            With .Parameters
                .Clear()
                .Add("@idalmacen", SqlDbType.Int).Value = IDAlmacen
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With AlmacenBE
                        .idalmacen = dr.ReadNullAsNumeric("idalmacen")
                        .nombrealmacen = dr.ReadNullAsEmptyString("nombrealmacen")
                        .codloc = dr.ReadNullAsEmptyString("codloc")
                        .tipoalmacen = dr.ReadNullAsNumeric("tipoalmacen")
                        .activo = dr.ReadNullAsEmptyString("activo")
                        .almacencentral = dr.ReadNullAsNumeric("almacencentral")
                        .idusuario = dr.ReadNullAsEmptyString("idusuario")
                        .fecregistro = dr.ReadNullAsEmptyString("fecregistro")
                    End With

                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw New Exception("AlmacenDAO.GetByIDAlmacen - log_almacen_get_id" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return AlmacenBE
    End Function

    Public Function GetByAlmacenesALL(ByVal Tipo As String, ByVal Valor As String, ByVal NumeroPagina As Int32) As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_almacen_get_all"
            With .Parameters
                .Add("@tipo", SqlDbType.Char, 3).Value = Tipo
                .Add("@valor", SqlDbType.VarChar, 30).Value = Valor
                .Add("@numeropagina", SqlDbType.Int).Value = NumeroPagina
            End With
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("AlmacenDAO.GetByAlmacenesALL - log_almacen_get_all" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
    Public Function GetByAlmacenList() As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_almacen_get_predeterminado"
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("AlmacenDAO.GetByAlmacenList - log_almacen_get_list" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetByAlmacenListALL() As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_almacen_get_list"
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("AlmacenDAO.GetByAlmacenList - log_almacen_get_list" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetByAlmacenListCbo() As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_almacen_get_predeterminado_cbo"
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    IDAlmacen = dr.ReadNullAsNumeric("idalmacen")
                End While
            End If
        Catch ex As Exception
            Throw New Exception("AlmacenDAO.GetByAlmacenListCbo - log_almacen_get_predeterminado_cbo" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function SaveAlmacenStock(ByVal BE As AlmacenStockBE) As Boolean
        Dim Result As Boolean = False
        Dim AlmacenStockBE As New AlmacenStockBE
        AlmacenStockBE = GetByAlmacenStockValida(BE.IDAlmacen, BE.IDProducto)

        If AlmacenStockBE.IDAlmacenStock = 0 Then
            If BE.IDAlmacenStock = 0 Then
                If InsertAlmacenStock(BE) Then
                    Result = True
                End If
            End If
        Else
            With BE
                .IDAlmacenStock = AlmacenStockBE.IDAlmacenStock
            End With
            If UpdateAlmacenStock(BE) Then
                Result = True
            End If
        End If
        Return Result
    End Function

    Public Function InsertAlmacenStock(ByVal BE As AlmacenStockBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_almacen_stock_insert"
            With .Parameters
                .Add("@idalmacenstock", SqlDbType.Int).Value = BE.IDAlmacenStock
                .Add("@idalmacen", SqlDbType.Int).Value = BE.IDAlmacen
                .Add("@idproducto", SqlDbType.Int).Value = BE.IDProducto
                .Add("@stockactual", SqlDbType.Float).Value = BE.StockActual
                .Add("@idusuario", SqlDbType.Int).Value = BE.IDUsuario
                .Add("@fecharegistro", SqlDbType.DateTime).Value = BE.FechaRegistro
            End With

        End With
        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                result = True
            End If
        Catch ex As Exception
            Throw New Exception("AlmacenDAO.GetByAlmacenStockValida - log_almacen_movimiento_get_valida" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return result
    End Function

    Public Function UpdateAlmacenStock(ByVal BE As AlmacenStockBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_almacen_stock_update"
            With .Parameters
                .Add("@idalmacenstock", SqlDbType.Int).Value = BE.IDAlmacenStock
                .Add("@idalmacen", SqlDbType.Int).Value = BE.IDAlmacen
                .Add("@idproducto", SqlDbType.Int).Value = BE.IDProducto
                .Add("@stockactual", SqlDbType.Float).Value = BE.StockActual
                .Add("@idusuario", SqlDbType.Int).Value = BE.IDUsuario
                .Add("@fecharegistro", SqlDbType.DateTime).Value = BE.FechaRegistro
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery > 0 Then
                result = True
            End If
        Catch ex As Exception
            Throw New Exception("AlmacenDAO.UpdateAlmacenStock - log_almacen_stock_update" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return result
    End Function

    Public Function GetByAlmacenStockALL(ByVal IDProducto As Int32) As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_almacen_stock_get_all"
            With .Parameters
                .Add("@idproducto", SqlDbType.Int).Value = IDProducto
            End With
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("AlmacenDAO.GetByAlmacenStockALL - log_almacen_stock_get_all" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function


    Public Function AnularAlmacenStock(ByVal BE As AlmacenStockBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim result As Boolean = False
        Dim AlmacenStockBE As New AlmacenStockBE
        'se instancia la entidad     
        AlmacenStockBE = GetByAlmacenStockValida(BE.IDAlmacen, BE.IDProducto)
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_almacen_stock_anular"
            With .Parameters
                .Add("@idalmacenstock", SqlDbType.Int).Value = AlmacenStockBE.IDAlmacenStock
                .Add("@idalmacen", SqlDbType.Int).Value = BE.IDAlmacen
                .Add("@idproducto", SqlDbType.Int).Value = BE.IDProducto
                .Add("@stockactual", SqlDbType.Float).Value = BE.StockActual
                .Add("@idusuario", SqlDbType.Int).Value = BE.IDUsuario
                .Add("@fecharegistro", SqlDbType.DateTime).Value = BE.FechaRegistro
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery > 0 Then
                result = True
            End If
        Catch ex As Exception
            Throw New Exception("AlmacenDAO.UpdateAlmacenStock - log_almacen_stock_anular" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return result
    End Function

    Public Function GetByAlmacenStockValida(ByVal IDAlmacen As Int32, ByVal IDProducto As Int32) As AlmacenStockBE
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing
        Dim AlmacenStockBE As New AlmacenStockBE

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_almacen_stock_valida_almacen_producto"
            With .Parameters
                .Add("@idalmacen", SqlDbType.Int).Value = IDAlmacen
                .Add("@idproducto", SqlDbType.Int).Value = IDProducto
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    With AlmacenStockBE
                        .IDAlmacenStock = dr.ReadNullAsNumeric("idalmacenstock")
                        .IDAlmacen = dr.ReadNullAsNumeric("idalmacen")
                        .IDProducto = dr.ReadNullAsNumeric("idproducto")
                        .StockActual = dr.ReadNullAsNumeric("stockactual")
                        .IDUsuario = dr.ReadNullAsNumeric("idusuario")
                        .FechaRegistro = dr.ReadNullAsNumeric("fecharegistro")
                    End With
                End While
            End If
        Catch ex As Exception
            Throw New Exception("AlmacenDAO.GetByAlmacenStockValida - log_almacen_movimiento_get_valida" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return AlmacenStockBE
    End Function

    Public Function GetByAlmacenOperacionList() As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_almacen_operacion_get_list"
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("AlmacenDAO.GetByAlmacenOperacionList - log_almacen_operacion_get_list" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetByAlmacenOperacionListGuias() As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_almacen_operacion_get_list_guias"
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("AlmacenDAO.GetByAlmacenOperacionListGuias - log_almacen_operacion_get_list_guias" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

End Class
