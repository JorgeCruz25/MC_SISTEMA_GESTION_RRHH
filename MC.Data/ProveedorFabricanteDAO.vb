Imports System.Data.SqlClient
Imports System.ComponentModel.DataAnnotations

Public Class ProveedorFabricanteDAO
    'propiedades
    Property IDProveedorFabricante As Int32 = 0
    'variables
    Dim ProveedorFabricanteBE As New ProveedorFabricanteBE

    Public Function Save(ByVal BE As ProveedorFabricanteBE) As Boolean
        Dim Result As Boolean = False
        If BE.idproveedorfabricante = 0 Then
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

    Private Function Insert(ByVal BE As ProveedorFabricanteBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_proveedor_fabricante_insert"
            With .Parameters
                .Clear()
                .Add("@idproveedorfabricante", SqlDbType.Int).Direction = ParameterDirection.Output
                .Add("@codproveedor", SqlDbType.Int).Value = BE.codproveedor
                .Add("@idfabricante", SqlDbType.Int).Value = BE.idfabricante
                .Add("@idusuario", SqlDbType.Int).Value = BE.idusuario
                .Add("@fecharegistro", SqlDbType.DateTime).Value = BE.fecharegistro
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
                IDProveedorFabricante = cmd.Parameters("@idproveedorfabricante").Value
            End If
        Catch ex As Exception
            Throw New Exception("ProveedorFabricanteDAO.Insert - log_proveedor_fabricante_insert" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Private Function Update(ByVal BE As ProveedorFabricanteBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_proveedor_fabricante_update"
            With .Parameters
                .Clear()
                .Add("@idproveedorfabricante", SqlDbType.Int).Value = BE.idproveedorfabricante
                .Add("@codproveedor", SqlDbType.Int).Value = BE.codproveedor
                .Add("@idfabricante", SqlDbType.Int).Value = BE.idfabricante
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
            Throw New Exception("ProveedorFabricanteDAO.Update - log_proveedor_fabricante_update" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Delete(ByVal IDProveedorFabricante As Int32) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_proveedor_fabricante_delete"
            With .Parameters
                .Clear()
                .Add("@idproveedorfabricante", SqlDbType.Int).Value = IDProveedorFabricante
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("ProveedorFabricanteDAO.Delete - log_proveedor_fabricante_delete" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Validad(ByVal BE As ProveedorFabricanteBE) As IList(Of ValidationResult)
        Dim Lista As New List(Of ValidationResult)
        Dim vc As New ValidationContext(BE, Nothing, Nothing)
        Try
            Validator.TryValidateObject(BE, vc, Lista, True)
        Catch ex As Exception
            Throw New Exception("ProveedorFabricanteDAO.Validar" & vbCrLf & ex.Message)
        End Try
        Return Lista
    End Function

    Public Function GetByProveedorFabricanteID(ByVal IDProveedorFabricante As Int32) As ProveedorFabricanteBE
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_proveedor_fabricante_get_id"
            With .Parameters
                .Clear()
                .Add("@idproveedorfabricante", SqlDbType.Int).Value = IDProveedorFabricante
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With ProveedorFabricanteBE
                        .idproveedorfabricante = dr.ReadNullAsEmptyString("idproveedorfabricante")
                        .codproveedor = dr.ReadNullAsEmptyString("codproveedor")
                        .idfabricante = dr.ReadNullAsEmptyString("idfabricante")
                    End With

                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw New Exception("ProveedorFabricanteDAO.GetByProveedorFabricanteID - log_proveedor_fabricante_insert" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return ProveedorFabricanteBE
    End Function

    Public Function GetByProveedorFabricanteALL(ByVal CodProveedor As Int32) As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_proveedor_fabricante_get_all"
            With .Parameters
                .Add("@codproveedor", SqlDbType.Int).Value = CodProveedor
            End With
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("ProveedorFabricanteDAO.GetByProveedorFabricanteALL - log_proveedor_fabricante_get_all" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetByProveedorFabricanteIDFabricante(ByVal CodProveedor As Int32) As IList
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing
        Dim Lista As New List(Of Int32)

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_proveedor_fabricante_idfabricante"
            With .Parameters
                .Add("@codproveedor", SqlDbType.Int).Value = CodProveedor
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    Lista.Add(dr.ReadNullAsNumeric("idfabricante"))
                End While
            End If
        Catch ex As Exception
            Throw New Exception("ProveedorFabricanteDAO.GetByProveedorFabricanteIDFabricante - log_proveedor_fabricante_idfabricante" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Lista
    End Function
End Class
