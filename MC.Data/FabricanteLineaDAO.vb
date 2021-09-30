Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel.DataAnnotations

Public Class FabricanteLineaDAO
    Public Enum eFalimiaLinea
        Todos = 1
        SinNinguno = 2
    End Enum

    Property IdTipoLineaFabricante As Int32
    Dim FabricanteLineaBE As New FabricanteLineaBE

    Public Function Save(ByVal BE As FabricanteLineaBE) As Boolean
        Dim Result As Boolean = False

        Try
            If BE.idlineafabricante = 0 Then
                If Insert(BE) Then
                    Result = True
                End If
            Else
                If Update(BE) Then
                    Result = True
                End If
            End If
        Catch ex As Exception
            Throw New Exception("FabricanteLineaDAO.Save" & vbCrLf)
        End Try
        Return Result
    End Function

    Public Function Insert(ByVal BE As FabricanteLineaBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_tipo_fabricante_linea_insert"
            With .Parameters
                .Clear()
                .Add("@idlineafabricante", SqlDbType.Int).Value = BE.idlineafabricante
                .Add("@idfabricante", SqlDbType.Int).Value = BE.idfabricante
                .Add("@nombre", SqlDbType.VarChar, 150).Value = BE.nombre
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
            Throw New Exception("FabricanteLineaDAO.Insert - log_tipo_fabricante_linea_insert" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Update(ByVal BE As FabricanteLineaBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_tipo_fabricante_linea_update"
            With .Parameters
                .Clear()
                .Add("@idlineafabricante", SqlDbType.Int).Value = BE.idlineafabricante
                .Add("@idfabricante", SqlDbType.Int).Value = BE.idfabricante
                .Add("@nombre", SqlDbType.VarChar, 150).Value = BE.nombre
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
            Throw New Exception("FabricanteLineaDAO.Update - log_tipo_fabricante_linea_update" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Delete(ByVal IDTipoFabricanteLinea As Int32) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_tipo_fabricante_linea_delete"
            With .Parameters
                .Clear()
                .Add("@idlineafabricante", SqlDbType.Int).Value = IDTipoFabricanteLinea
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("FabricanteLineaDAO.Delete - log_tipo_fabricante_linea_delete" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Validar(ByVal BE As FabricanteLineaBE) As List(Of ValidationResult)
        Dim Lista As New List(Of ValidationResult)
        Dim vc As New ValidationContext(BE, Nothing, Nothing)
        Try
            Validator.TryValidateObject(BE, vc, Lista, True)
        Catch ex As Exception
            Throw New Exception("FabricanteLineaDAO.Validar" & vbCrLf & ex.Message)
        End Try
        Return Lista
    End Function

    Public Function GetByFabricanteLineaID(ByVal IDFabricanteLinea As Int32) As FabricanteLineaBE
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_tipo_fabricante_linea_get_id"
            With .Parameters
                .Clear()
                .Add("@idlineafabricante", SqlDbType.Int).Value = IDFabricanteLinea
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With FabricanteLineaBE
                        .idlineafabricante = dr.ReadNullAsNumeric("idlineafabricante")
                        .idfabricante = dr.ReadNullAsNumeric("idfabricante")
                        .nombre = dr.ReadNullAsEmptyString("nombre")
                        .idusuario = dr.ReadNullAsNumeric("idusuario")
                        .fecharegistro = dr.ReadNullAsEmptyDate("fecharegistro")
                    End With
                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw New Exception("FabricanteLineaDAO.GetByFabricanteLineaID - log_tipo_fabricante_linea_get_id" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return FabricanteLineaBE
    End Function

    Public Function GetByFabricanteLineaALL(ByVal IDFabricante As Int32) As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_tipo_fabricante_linea_get_all"
            With .Parameters
                .Add("@idfabricante", SqlDbType.Int).Value = IDFabricante
            End With
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("FabricanteLineaDAO.GetByFabricanteLineaALL - log_tipo_fabricante_linea_get_all" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetByFabricanteLineasList(ByVal IDFabricante As Int32, Optional ByVal Tipo As eFalimiaLinea = eFalimiaLinea.SinNinguno) As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_tipo_fabricante_linea_list"
            With .Parameters
                .Add("@idfabricante", SqlDbType.Int).Value = IDFabricante
                .Add("@tipo", SqlDbType.Int).Value = Tipo
            End With
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("FabricanteLineaDAO.GetByFabricanteLineaList - log_tipo_fabricante_linea_list" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetByFabricanteLineaIDFabricante(ByVal IDFabricante As Int32) As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_tipo_fabricante_linea_get_idfabricante"
            With .Parameters
                .Add("@idfabricante", SqlDbType.Int).Value = IDFabricante
            End With
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("FabricanteLineaDAO.GetByFabricanteLineaIDFabricante - log_tipo_fabricante_linea_get_idfabricante" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
End Class
