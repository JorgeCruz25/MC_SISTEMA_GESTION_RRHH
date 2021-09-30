Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections

Public Class ProveedorDepartamentoDAO

    Public Function Save(ByVal BE As ProveedorDepartamentoBE) As Boolean
        Dim Result As Boolean = False
        If BE.idproveedordepartamento = 0 Then
            If Insert(BE) Then
                Result = True
            End If
        End If
        Return Result
    End Function

    Public Function Insert(ByVal BE As ProveedorDepartamentoBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_proveedor_departamento_insert"
            With .Parameters
                .Clear()
                .Add("@idproveedordepartamento", SqlDbType.Int).Direction = ParameterDirection.Output
                .Add("@iddepartamento", SqlDbType.Int).Value = BE.iddepartamento
                .Add("@codproveedor", SqlDbType.Int).Value = BE.codproveedor
                .Add("@idusuario", SqlDbType.VarChar, -1).Value = BE.idusuario
                .Add("@fecharegistro", SqlDbType.Date).Value = BE.fecharegistro
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("ProveedorDepartamentoDAO.Insert - log_proveedor_evaluacion_insert" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Delete(ByVal IDDepartamento As Int32, ByVal CodProveedor As Int32) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_proveedor_departamento_delete"
            With .Parameters
                .Clear()
                .Add("@iddepartamento", SqlDbType.Int).Value = IDDepartamento
                .Add("@codproveedor", SqlDbType.Int).Value = CodProveedor
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("ProveedorDepartamentoDAO.Delete - log_proveedor_departamento_delete" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function GetByProveedorDepartamentoRegistro(ByVal CodProveedor As Int32) As IList
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Dim Lista As New List(Of Object)


        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_proveedor_departamento_get_registro"
            With .Parameters
                .Add("@codproveedor", SqlDbType.Int).Value = CodProveedor
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    Lista.Add(dr.ReadNullAsNumeric("iddepartamento"))
                End While
            End If
        Catch ex As Exception
            Throw New Exception("ProveedorDepartamentoDAO.GetByProveedorDepartamento - log_proveedor_departamento_get_id" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Lista
    End Function

    Public Function GetByProveedorDepartamentoIDProveedorDepartamento(ByVal CodProveedor As Int32) As IList
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Dim Lista As New List(Of Object)

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_proveedor_departamento_get_idproveedordepartamento"
            With .Parameters
                .Add("@cod´proveedor", SqlDbType.Int).Value = CodProveedor
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    Lista.Add(dr.ReadNullAsNumeric("idproveedordepartamento"))
                End While
            End If
        Catch ex As Exception
            Throw New Exception("ProveedorDepartamentoDAO.GetByProveedorDepartamentoIDProveedorDepartamento - log_proveedor_departamento_get_idproveedordepartamento" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Lista
    End Function

    Public Function GetByProveedorDepartamentoValida(ByVal IDDepartamento As Int32, ByVal CodProveedor As Int32) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_proveedor_departamento_get_valida"
            With .Parameters
                .Add("@iddepartamento", SqlDbType.Int).Value = IDDepartamento
                .Add("@codproveedor", SqlDbType.Int).Value = CodProveedor
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
            If dt.Rows.Count = 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("ProveedorDepartamentoDAO.GetByProveedorDepartamentoValida - log_proveedor_departamento_get_valida" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function
End Class
