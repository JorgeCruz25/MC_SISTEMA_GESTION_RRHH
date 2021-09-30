Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel.DataAnnotations


Public Class FabricanteBE
    Property IDFabricante As Int32

    <Required(ErrorMessage:="El campo es obligatorio")>
    <StringLength(150, MinimumLength:=1, ErrorMessage:="El campo nombre de laboratorio debe tener minímo un carácteres")>
    Property Nombre As String
    Property IDTipoFabricante As Int32
    Property Observacion As String

    Property Activo As Boolean
    Property IDUsuario As Int32
    Property FechaRegistro As DateTime

End Class

Public Class FabricanteDAO
    Property IDFabricante As Int32
    Property NumPagina As Int32

    Dim FabricanteBE As New FabricanteBE

    Public Function Save(BE As FabricanteBE) As Boolean
        Dim Result As Boolean = False

        Try
            If BE.IDFabricante = 0 Then
                If Insert(BE) Then
                    Result = True
                End If
            Else
                If Update(BE) Then
                    Result = True
                End If
            End If
        Catch ex As Exception
            Throw New Exception("FabricanteDAO.Save" & vbCrLf & ex.Message)
        End Try
        Return Result
    End Function
    Public Function Insert(BE As FabricanteBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_fabricante_insert"
            .Parameters.Add("@idfabricante", SqlDbType.Int).Direction = ParameterDirection.Output
            .Parameters.Add("@nombre", SqlDbType.VarChar, 200).Value = BE.Nombre
            .Parameters.Add("@idtipofabricante", SqlDbType.Int).Value = BE.IDTipoFabricante
            .Parameters.Add("@observacion", SqlDbType.VarChar, 8000).Value = BE.Observacion
            .Parameters.Add("@activo", SqlDbType.Bit).Value = BE.Activo
            .Parameters.Add("@idusuario", SqlDbType.Int).Value = BE.IDUsuario
            .Parameters.Add("@fecharegistro", SqlDbType.DateTime).Value = BE.FechaRegistro
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery > 0 Then
                Result = True
                IDFabricante = cmd.Parameters("@idfabricante").Value
            End If
        Catch ex As Exception
            Throw New Exception("FabricanteDAO.Insert - log_fabricante_insert " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function
    Public Function Update(BE As FabricanteBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_fabricante_update"
            .Parameters.Add("@idfabricante", SqlDbType.Int).Value = BE.IDFabricante
            .Parameters.Add("@nombre", SqlDbType.VarChar, 200).Value = BE.Nombre
            .Parameters.Add("@idtipofabricante", SqlDbType.Int).Value = BE.IDTipoFabricante
            .Parameters.Add("@observacion", SqlDbType.VarChar, 8000).Value = BE.Observacion
            .Parameters.Add("@activo", SqlDbType.Bit).Value = BE.Activo
            .Parameters.Add("@idusuario", SqlDbType.Int).Value = BE.IDUsuario
            .Parameters.Add("@fecharegistro", SqlDbType.DateTime).Value = BE.FechaRegistro
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery > 0 Then
                Result = True
                IDFabricante = BE.IDFabricante
            End If
        Catch ex As Exception
            Throw New Exception("FabricanteDAO.Update - log_fabricante_update " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Delete(IDFabricante As Int32) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_fabricante_delete"
            .Parameters.Add("@idfabricante", SqlDbType.Int).Value = IDFabricante
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("FabricanteDAO.Delete - log_fabricante_delete" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Validar(BE As FabricanteBE) As List(Of ValidationResult)
        Dim Lista As New List(Of ValidationResult)
        Dim vc As New ValidationContext(BE, Nothing, Nothing)


        Try
            Validator.TryValidateObject(BE, vc, Lista, True)
        Catch ex As Exception
            Throw New Exception("FabricanteDAO.Validar" & vbCrLf & ex.Message)
        Finally

        End Try
        Return Lista
    End Function

    Public Function GetByID(IDFabricante As Int32) As FabricanteBE
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_fabricante_get_id"
            .Parameters.Add("@idfabricante", SqlDbType.Int).Value = IDFabricante
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With FabricanteBE
                        .IDFabricante = dr.ReadNullAsEmptyString("idfabricante")
                        .Nombre = dr.ReadNullAsEmptyString("nombre")
                        .IDTipoFabricante = dr.ReadNullAsNumeric("idtipofabricante")
                        .Activo = dr.ReadNullAsEmptyString("activo")
                        .Observacion = dr.ReadNullAsEmptyString("observacion")
                    End With
                End While
            End If
        Catch ex As Exception
            Throw New Exception("FabricanteDAO.GetByID - log_fabricante_get_id " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return FabricanteBE
    End Function
    Public Function GetByALL(Optional Tipo As String = "ALL", Optional Valor As String = "", Optional NumeroPagina As Int32 = 1) As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_fabricante_get_all"
            .Parameters.Add("@tipo", SqlDbType.Char, 3).Value = Tipo
            .Parameters.Add("@valor", SqlDbType.VarChar, 30).Value = Valor
            .Parameters.Add("@numeropagina", SqlDbType.Int).Value = NumeroPagina
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("FabricanteDAO.GetByNombre - log_fabricante_get_all" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetReportListado() As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_fabricante_rpt_listado"
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("Clase: FabricanteDAO.GetReportListado SP:log_fabricante_rpt_listado" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function


    Public Function GetByFabricanteList() As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_fabricante_get_list"
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("FabricanteDAO.GetByFabricanteList - log_fabricante_get_list" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetByFabricanteProveedorList(ByVal CodProveedor As Int32) As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_fabricante_get_proveedor_list"
            With .Parameters
                .Add("@codproveedor", SqlDbType.Int).Value = CodProveedor
            End With
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("FabricanteDAO.GetByFabricanteProveedorList - log_fabricante_get_proveedor_list" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetByTipoFabricanteALL() As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_tipo_fabricante_get_all"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("FabricanteDAO.GetByTipoFabricanteALL - log_fabricante_get_list" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetByFabricanteBuscar(ByVal Tipo As Int16, ByVal Criterio As String) As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_fabricante_get_buscar"
            With .Parameters
                .Add("@tipo", SqlDbType.TinyInt).Value = Tipo
                .Add("@criterio", SqlDbType.VarChar, 30).Value = Criterio
            End With
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("FabricanteDAO.GetByFabricanteBuscar - log_fabricante_get_buscar" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetByNumeroPagina(ByVal IDFabricante As Int32) As Int32
        Dim Cantidad As Int32 = 0
        Dim RangoRegistro As Int32 = 100
        Dim RangoBase As Int32 = 100
        Dim NumeroRegistro As Int32 = 300
        Dim Cont As Int32 = 1
        Dim NumeroPagina As Int32 = 0
        NumPagina = 1

        NumeroPagina = 1

        While Cont <= NumeroRegistro

            If Cont = RangoRegistro Then
                RangoRegistro = RangoRegistro + RangoBase
                NumeroPagina = NumeroPagina + 1
                NumPagina = NumeroPagina
            End If

            If Cont = IDFabricante Then
                NumPagina = NumeroPagina
                Exit While
            End If
            Cont = Cont + 1
        End While

        Return NumPagina
    End Function
End Class
