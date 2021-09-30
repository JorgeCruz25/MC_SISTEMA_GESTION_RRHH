Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel.DataAnnotations


Public Class NumeradorBE
    <Required(ErrorMessage:="Campo es obligatorio")>
    Property CodNumerador As String

    <Required(ErrorMessage:="Campo es obligatorio")>
    Property Nombre As String

    <Required(ErrorMessage:="Campo es obligatorio")>
    <StringLength(3, MinimumLength:=1, ErrorMessage:="Longitud maxima es 3")>
    Property Serie As String

    <Required(ErrorMessage:="Campo es obligatorio")>
    <StringLength(12, MinimumLength:=1, ErrorMessage:="Longitud maxima es 12")>
    Property Numero As String

    <Required(ErrorMessage:="Campo es obligatorio")>
    <StringLength(100, MinimumLength:=1, ErrorMessage:="Longitud maxima es 100")>
    Property Impresora As String

    Property IDUsuario As Int32
    Property FechaRegistro As DateTime

End Class


Public Class NumeradorDAO

    Public Function Update(ByVal BE As NumeradorBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_numerador_update"
            With .Parameters
                .Add("@codnumerador", SqlDbType.Char, 5).Value = BE.CodNumerador
                .Add("@nombre", SqlDbType.VarChar, 100).Value = BE.nombre
                .Add("@serie", SqlDbType.Char, 3).Value = BE.Serie
                .Add("@numero", SqlDbType.VarChar, 12).Value = BE.Numero
                .Add("@impresora", SqlDbType.VarChar, 100).Value = BE.Impresora
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
            Throw New Exception("NumeradorDAO.Update " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function
    Public Function UpdateNumero(CodNumerador As String) As String
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As String = String.Empty

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_numerador_update_numero"

            With .Parameters
                .Clear()
                .Add("@numero", SqlDbType.VarChar, 12).Direction = ParameterDirection.Output
                .Add("@codigo", SqlDbType.Char, 5).Value = CodNumerador
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = cmd.Parameters("@numero").Value
            End If
        Catch ex As Exception
            Throw New Exception("NumeradorDAO.UpdateNumero " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function
    Public Function Validar(BE As NumeradorBE) As List(Of ValidationResult)
        Dim Lista As New List(Of ValidationResult)
        Dim vc As New ValidationContext(BE, Nothing, Nothing)

        Try
            Validator.TryValidateObject(BE, vc, Lista, True)
        Catch ex As Exception
            Throw New Exception("NumeradorDAO.Validar" & vbCrLf & ex.Message)
        Finally

        End Try
        Return Lista
    End Function

    Public Function GetByCodigo(CodNumerador As String) As NumeradorBE
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing
        Dim BE As New NumeradorBE

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_numerador_get_codigo"

            With .Parameters
                .Add("@codigo", SqlDbType.Char, 5).Value = CodNumerador
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read()
                    With BE
                        .CodNumerador = dr.ReadNullAsEmptyString("codnumerador")
                        .Nombre = dr.ReadNullAsEmptyString("nombre")
                        .Serie = dr.ReadNullAsEmptyString("serie")
                        .Numero = dr.ReadNullAsEmptyString("numero")
                        .Impresora = dr.ReadNullAsEmptyString("impresora")
                        .IDUsuario = dr.ReadNullAsNumeric("idusuario")
                        .FechaRegistro = dr.ReadNullAsEmptyString("fecharegistro")
                    End With
                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw New Exception("NumeradorDAO.GetByCodigo " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return BE
    End Function

    Public Function GetByNumero(CodNumerador As String) As String
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As String = String.Empty

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_numerador_get_numero"

            With .Parameters
                .Add("@codigo", SqlDbType.Char, 5).Value = CodNumerador
                .Add("@numero", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output
            End With
        End With

        Try
            cnx.Open()
            cmd.ExecuteNonQuery()
            Result = cmd.Parameters("@numero").Value

        Catch ex As Exception
            Throw New Exception("NumeradorDAO.GetByNumero " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function
    Public Function GetByNumeradores() As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_numerador_get_list"
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("NumeradorDAO.GetByNumeradores " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

End Class
