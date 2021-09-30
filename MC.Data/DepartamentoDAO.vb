Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel.DataAnnotations


Public Class DepartamenteBE
    Public Property iddepartamento() As Int32

    <Required(ErrorMessage:="Campo es obligatorio")>
    <StringLength(150, MinimumLength:=1, ErrorMessage:="Nombre debe tener al menos un caracter")>
    Public Property nombre() As String

    Public Property activo() As Boolean
    Public Property idusuario() As Int32
    Public Property fecharegistro() As DateTime
End Class


Public Class DepartamentoDAO
    Property IDDepartamento As Int32
    Dim DepartamentoBE As New DepartamenteBE

    Public Function Save(BE As DepartamenteBE) As Boolean
        Dim Result As Boolean = False
        Try
            If BE.iddepartamento = 0 Then
                If Insert(BE) Then
                    Result = True
                End If
            Else
                If Update(BE) Then
                    Result = True
                End If
            End If
        Catch ex As Exception
            Throw New Exception("DepartamentoDAO.Insert - roe_departamento_insert" & vbCrLf & ex.Message)
        End Try
        Return Result
    End Function

    Public Function Insert(ByVal BE As DepartamenteBE) As Boolean
        Dim cnx As New SqlConnection(strCnxLabRoe)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "roe_departamento_insert"

            With .Parameters
                .Clear()
                .Add("@iddepartamento", SqlDbType.Int).Direction = ParameterDirection.Output
                .Add("@nombre", SqlDbType.VarChar, 100).Value = BE.nombre
                .Add("@activo", SqlDbType.Bit).Value = BE.activo
                .Add("@idusuario", SqlDbType.Int).Value = BE.idusuario
                .Add("@fecharegistro", SqlDbType.DateTime).Value = BE.fecharegistro
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                IDDepartamento = cmd.Parameters("@iddepartamento").Value
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("DepartamentoDAO.Insert - roe_departamento_insert" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Update(ByVal BE As DepartamenteBE) As Boolean
        Dim cnx As New SqlConnection(strCnxLabRoe)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "roe_departamento_update"
            With .Parameters
                .Clear()
                .Add("@iddepartamento", SqlDbType.Int).Value = BE.iddepartamento
                .Add("@nombre", SqlDbType.VarChar, 100).Value = BE.nombre
                .Add("@activo", SqlDbType.Bit).Value = BE.activo
                .Add("@idusuario", SqlDbType.Int).Value = BE.idusuario
                .Add("@fecharegistro", SqlDbType.DateTime).Value = BE.fecharegistro
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                IDDepartamento = BE.iddepartamento
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("DepartamentoDAO.Update - roe_departamento_update" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Delete(ByVal IDDepartamento As Int32) As Boolean
        Dim cnx As New SqlConnection(strCnxLabRoe)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "roe_departamento_delete"

            With .Parameters
                .Clear()
                .Add("@iddepartamento", SqlDbType.Int).Value = IDDepartamento
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("DepartamentoDAO.Delete - roe_departamento_delete" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result

    End Function

    Public Function Validar(ByVal BE As DepartamenteBE) As IList(Of ValidationResult)
        Dim Lista As New List(Of ValidationResult)
        Dim vc As New ValidationContext(BE, Nothing, Nothing)
        Try
            Validator.TryValidateObject(BE, vc, Lista, True)
        Catch ex As Exception
            Throw New Exception("")
        End Try
        Return Lista
    End Function

    Public Function GetByIDDepartamento(ByVal IDDepartamento As Int32) As DepartamenteBE
        Dim cnx As New SqlConnection(strCnxLabRoe)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "roe_departamento_get_id"
            With .Parameters
                .Clear()
                .Add("@iddepartamento", SqlDbType.Int).Value = IDDepartamento
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read()
                    With DepartamentoBE
                        .iddepartamento = dr.ReadNullAsEmptyString("iddepartamento")
                        .nombre = dr.ReadNullAsEmptyString("nombre")
                        .activo = dr.ReadNullAsEmptyString("activo")
                        .idusuario = dr.ReadNullAsEmptyString("idusuario")
                        .fecharegistro = dr.ReadNullAsEmptyString("fecharegistro")
                    End With
                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw New Exception("DepartamentoDAO.GetByIDDepartamento - roe_departamento_get_id" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return DepartamentoBE
    End Function

    Public Function GetByDepartamentoALL(ByVal Tipo As String, ByVal Valor As String, ByVal NumeroPagina As Int32) As DataTable
        Dim cnx As New SqlConnection(strCnxLabRoe)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "roe_departamento_get_all"
            With .Parameters
                .Add("@tipo", SqlDbType.Char, 3).Value = Tipo
                .Add("@valor", SqlDbType.VarChar, 30).Value = Valor
                .Add("@numeropagina", SqlDbType.Int).Value = NumeroPagina
            End With
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
            Return dt
        Catch ex As Exception
            Throw New Exception("DepartamentoDAO.Insert - roe_departamento_get_all" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
    End Function

    Public Function GetByDepartamentoList() As DataTable
        Dim cnx As New SqlConnection(strCnxLabRoe)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "roe_departamento_list"
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("DepartamentoDAO.GetByDepartamentoList - roe_departamento_list" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetByIDDepartamentoComparar() As IList
        Dim cnx As New SqlConnection(strCnxLabRoe)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Dim Lista As New List(Of Object)

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "roe_departamento_get_id_comparar"
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
            Throw New Exception("DepartamentoDAO.GetByIDDepartamentoComparar - roe_departamento_get_id_comparar" & vbCrLf & ex.Message)
        End Try
        Return Lista
    End Function

End Class
