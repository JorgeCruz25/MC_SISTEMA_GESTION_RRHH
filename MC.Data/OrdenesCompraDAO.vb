Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel.DataAnnotations

Public Class OrdenesCompraDAO
    'propiedades
    Property IdNumeroOrden As Int32
    Dim OrdenCompraBE As New OrdenesCompraBE

    Public Function Save(ByVal BE As OrdenesCompraBE) As Boolean
        Dim Result As Boolean = False
        If BE.idnumeroorden = 0 Then
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

    Public Function Insert(ByVal BE As OrdenesCompraBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_ordencompra_insert"
            With .Parameters
                .Clear()
                .Add("@idnumeroorden", SqlDbType.Int).Direction = ParameterDirection.Output
                .Add("@numeroorden", SqlDbType.Char, 11).Value = BE.numeroorden
                .Add("@codproveedor", SqlDbType.Int).Value = BE.codproveedor
                .Add("@idalmacen", SqlDbType.Int).Value = BE.idalmacen
                .Add("@idtipopago", SqlDbType.Int).Value = BE.idtipopago
                .Add("@diascredito", SqlDbType.Int).Value = BE.diascredito
                .Add("@idmoneda", SqlDbType.Int).Value = BE.idmoneda
                .Add("@prioridad", SqlDbType.Char, 1).Value = BE.prioridad
                .Add("@situacion", SqlDbType.Char, 1).Value = BE.situacion
                .Add("@fechaemision", SqlDbType.DateTime).Value = BE.fechaemision
                .Add("@fechaprogramacion", SqlDbType.DateTime).Value = BE.fechaprogramacion
                .Add("@fecharecepcion", SqlDbType.DateTime).Value = BE.fecharecepcion
                .Add("@fechaanulacion", SqlDbType.DateTime).Value = BE.fechaanulacion
                .Add("@importeneto", SqlDbType.Decimal).Value = BE.importeneto
                .Add("@importeigv", SqlDbType.Decimal).Value = BE.importeigv
                .Add("@importetotal", SqlDbType.Decimal).Value = BE.importetotal
                .Add("@porcentajeimpuesto", SqlDbType.Decimal).Value = BE.porcentajeimpuesto
                .Add("@observaciones", SqlDbType.VarChar, -1).Value = BE.observaciones
                .Add("@estado", SqlDbType.Int).Value = BE.estado
                .Add("@idusuario", SqlDbType.Int).Value = BE.idusuario
                .Add("@fecharegistro", SqlDbType.DateTime).Value = BE.fecharegistro
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
                IdNumeroOrden = cmd.Parameters("@idnumeroorden").Value
            End If
        Catch ex As Exception
            Throw New Exception("OrdenesCompraDAO.Insert - log_ordencompra_insert" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Update(ByVal BE As OrdenesCompraBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_ordencompra_update"
            With .Parameters
                .Clear()
                .Add("@idnumeroorden", SqlDbType.Int).Value = BE.idnumeroorden
                .Add("@numeroorden", SqlDbType.Char, 11).Value = BE.numeroorden
                .Add("@codproveedor", SqlDbType.Int).Value = BE.codproveedor
                .Add("@idalmacen", SqlDbType.Int).Value = BE.idalmacen
                .Add("@idtipopago", SqlDbType.Int).Value = BE.idtipopago
                .Add("@diascredito", SqlDbType.Int).Value = BE.diascredito
                .Add("@idmoneda", SqlDbType.Int).Value = BE.idmoneda
                .Add("@prioridad", SqlDbType.Char, 1).Value = BE.prioridad
                .Add("@situacion", SqlDbType.Char, 1).Value = BE.situacion
                .Add("@fechaemision", SqlDbType.DateTime).Value = BE.fechaemision
                .Add("@fechaprogramacion", SqlDbType.DateTime).Value = BE.fechaprogramacion
                .Add("@fecharecepcion", SqlDbType.DateTime).Value = BE.fecharecepcion
                .Add("@fechaanulacion", SqlDbType.DateTime).Value = BE.fechaanulacion
                .Add("@importeneto", SqlDbType.Decimal).Value = BE.importeneto
                .Add("@importeigv", SqlDbType.Decimal).Value = BE.importeigv
                .Add("@importetotal", SqlDbType.Decimal).Value = BE.importetotal
                .Add("@porcentajeimpuesto", SqlDbType.Decimal).Value = BE.porcentajeimpuesto
                .Add("@observaciones", SqlDbType.VarChar, -1).Value = BE.observaciones
                .Add("@estado", SqlDbType.Int).Value = BE.estado
                .Add("@idusuario", SqlDbType.Int).Value = BE.idusuario
                .Add("@fecharegistro", SqlDbType.DateTime).Value = BE.fecharegistro
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                IdNumeroOrden = BE.idnumeroorden
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("OrdenesCompraDAO.Update - log_ordencompra_update" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Delete(ByVal IdNumeroOrden As Int32) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_ordencompra_delete"

            With .Parameters
                .Clear()
                .Add("@idnumeroorden", SqlDbType.Int).Value = IdNumeroOrden
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("OrdenesCompraDAO.Delete - log_ordencompra_delete" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Validar(ByVal BE As OrdenesCompraBE) As List(Of ValidationResult)
        Dim Lista As New List(Of ValidationResult)
        Dim vc As New ValidationContext(BE, Nothing, Nothing)

        Try
            Validator.TryValidateObject(BE, vc, Lista, True)
        Catch ex As Exception
            Throw New Exception("OrdenesCompraDAO.Validar" & vbCrLf & ex.Message)
        End Try
        Return Lista

    End Function

    Public Function GetByOrdenCompraID(ByVal IdNumeroCompra As Int32) As OrdenesCompraBE
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_ordencompra_get_id"
            With .Parameters
                .Clear()
                .Add("@idnumeroorden", SqlDbType.Int).Value = IdNumeroCompra
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With OrdenCompraBE
                        .idnumeroorden = dr.ReadNullAsEmptyString("idnumeroorden")
                        .numeroorden = dr.ReadNullAsEmptyString("numeroorden")
                        .codproveedor = dr.ReadNullAsEmptyString("codproveedor")
                        .razonsocial = dr.ReadNullAsEmptyString("razonsocial")
                        .idalmacen = dr.ReadNullAsEmptyString("idalmacen")
                        .idtipopago = dr.ReadNullAsEmptyString("idtipopago")
                        .diascredito = dr.ReadNullAsEmptyString("diascredito")
                        .idmoneda = dr.ReadNullAsEmptyString("idmoneda")
                        .prioridad = dr.ReadNullAsEmptyString("prioridad")
                        .situacion = dr.ReadNullAsEmptyString("situacion")
                        .fechaemision = dr.ReadNullAsEmptyDate("fechaemision")
                        .fechaprogramacion = dr.ReadNullAsEmptyDate("fechaprogramacion")
                        .fecharecepcion = dr.ReadNullAsEmptyDate("fecharecepcion")
                        .fechaanulacion = dr.ReadNullAsEmptyDate("fechaanulacion")
                        .importeneto = dr.ReadNullAsEmptyString("importeneto")
                        .importeigv = dr.ReadNullAsEmptyString("importeigv")
                        .importetotal = dr.ReadNullAsEmptyString("importetotal")
                        .porcentajeimpuesto = dr.ReadNullAsEmptyString("porcentajeimpuesto")
                        .observaciones = dr.ReadNullAsEmptyString("observaciones")
                        .estado = dr.ReadNullAsNumeric("estado")
                        .idusuario = dr.ReadNullAsEmptyString("idusuario")
                        .fecharegistro = dr.ReadNullAsEmptyDate("fecharegistro")
                    End With
                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw New Exception("OrdenesCompraDAO.GetByOrdenCompraID - log_ordencompra_get_id" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return OrdenCompraBE
    End Function

    Public Function GetByOrdenCompraALL(ByVal Tipo As String, ByVal Valor As String, ByVal NumeroPagina As Int32) As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_ordencompra_get_all"
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
            Throw New Exception("OrdenesCompraDAO.GetByOrdenCompraALL - log_ordencompra_get_all" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
End Class
