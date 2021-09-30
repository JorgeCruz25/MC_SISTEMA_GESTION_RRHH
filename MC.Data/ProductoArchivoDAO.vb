Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel.DataAnnotations

Public Class ProductoArchivoDAO
    Property IDProductoArchivo As Int32
    Dim ProductoArchivoBE As New ProductoArchivoBE

    Public Function Save(ByVal BE As ProductoArchivoBE) As Boolean
        Dim Result As Boolean = False
        If BE.idproductoarchivo = 0 Then
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

    Private Function Insert(ByVal BE As ProductoArchivoBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False


        Try
            'se valida si existe el directorio donde se grabaran las imagenes
            If Not Directory.Exists(BE.rutaarchivo & BE.idproducto) Then
                Directory.CreateDirectory(BE.rutaarchivo & BE.idproducto)
            End If
            'se concatena la carpeta del equipo
            BE.rutaarchivo = BE.rutaarchivo & BE.idproducto & "\"
            'se copia el archivo a la carpeta del producto
            File.Copy(BE.nombrearchivo, BE.rutaarchivo & Path.GetFileName(BE.nombrearchivo), False)
            'se valida si el nombre existe una vez copiado
            If File.Exists(BE.rutaarchivo & Path.GetFileName(BE.nombrearchivo)) Then
                'se cambia sólo el nombre de archivo
                BE.nombrearchivo = Path.GetFileName(BE.nombrearchivo)
            End If

            With cmd
                .Connection = cnx
                .CommandType = CommandType.StoredProcedure
                .CommandText = "log_producto_archivo_insert"
                With .Parameters
                    .Clear()
                    .Add("@idproductoarchivo", SqlDbType.Int).Value = BE.idproductoarchivo
                    .Add("@idproducto", SqlDbType.Int).Value = BE.idproducto
                    .Add("@rutaarchivo", SqlDbType.VarChar, -1).Value = BE.rutaarchivo
                    .Add("@nombrearchivo", SqlDbType.VarChar, 300).Value = BE.nombrearchivo
                    .Add("@fecharegistro", SqlDbType.DateTime).Value = BE.fecharegistro
                    .Add("@idusuario", SqlDbType.Int).Value = BE.idusuario
                End With
            End With

            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("ProductoArchivoDAO.Insert - log_producto_archivo_insert" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Private Function Update(ByVal BE As ProductoArchivoBE) As Boolean
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_producto_archivo_update"
            With .Parameters
                .Clear()
                .Add("@idproductoarchivo", SqlDbType.Int).Value = BE.idproductoarchivo
                .Add("@idproducto", SqlDbType.Int).Value = BE.idproducto
                .Add("@rutaarchivo", SqlDbType.VarChar, -1).Value = BE.rutaarchivo
                .Add("@nombrearchivo", SqlDbType.VarChar, 300).Value = BE.nombrearchivo
                .Add("@fecharegistro", SqlDbType.DateTime).Value = BE.fecharegistro
                .Add("@idusuario", SqlDbType.Int).Value = BE.idusuario
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("ProductoArchivoDAO.Update - log_producto_archivo_update" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Delete(ByVal IDProductoArchivo As Int32) As Boolean
        Dim ProductoArchivoDAO As New ProductoArchivoDAO
        Dim ProductoArchivosBE As New ProductoArchivoBE
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_producto_archivo_delete"
            With .Parameters
                .Clear()
                .Add("@idproductoarchivo", SqlDbType.Int).Value = IDProductoArchivo
            End With
        End With

        Try
            ProductoArchivosBE = ProductoArchivoDAO.GetByProductoArchivoID(IDProductoArchivo)
            'se elimina en archivo

            File.Delete(ProductoArchivosBE.rutaarchivo & ProductoArchivosBE.nombrearchivo)
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = True
            End If
        Catch ex As Exception
            Throw New Exception("ProductoArchivoDAO.Delete - log_producto_archivo_delete" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

    Public Function Validar(ByVal BE As ProductoArchivoBE) As List(Of ValidationResult)
        Dim Lista As New List(Of ValidationResult)
        Dim vc As New ValidationContext(BE, Nothing, Nothing)

        Try
            Validator.TryValidateObject(BE, vc, Lista, True)
        Catch ex As Exception
            Throw New Exception("ProductoArchivoDAO.Validar" & vbCrLf & ex.Message)
        End Try
        Return Lista
    End Function

    Public Function GetByProductoArchivoID(ByVal IDProductoArchivo As Int32) As ProductoArchivoBE
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_producto_archivo_get_id"
            With .Parameters
                .Clear()
                .Add("@idproductoarchivo", SqlDbType.Int).Value = IDProductoArchivo
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With ProductoArchivoBE
                        .idproductoarchivo = dr.ReadNullAsNumeric("idproductoarchivo")
                        .idproducto = dr.ReadNullAsNumeric("idproducto")
                        .rutaarchivo = dr.ReadNullAsEmptyString("rutaarchivo")
                        .nombrearchivo = dr.ReadNullAsEmptyString("nombrearchivo")
                        .fecharegistro = dr.ReadNullAsEmptyDate("fecharegistro")
                        .idusuario = dr.ReadNullAsNumeric("idusuario")
                    End With
                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw New Exception("ProductoArchivoDAO.GetByProductoArchivoID - log_producto_archivo_get_id" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return ProductoArchivoBE
    End Function

    Public Function GetProductoArchivoALL(ByVal IDProducto As Int32) As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_producto_archivo_get_all"
            With .Parameters
                .Add("@idproducto", SqlDbType.Int).Value = IDProducto
            End With
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("ProductoArchivoDAO.GetProductoArchivoALL - log_producto_archivo_get_all" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetByProductoArchivoImagen(ByVal IDProducto As Int32) As DataTable
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_producto_archivo_get_imagen"
            With .Parameters
                .Add("@idproducto", SqlDbType.Int).Value = IDProducto
            End With
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("ProductoArchivoDAO.GetByProductoArchivoImagen - log_producto_archivo_get_all" & vbCrLf & ex.Message)
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetByProductoArchivoValidar(ByVal NombreArchivo As String) As ProductoArchivoBE
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing
        Dim ProductoArchivoBE As New ProductoArchivoBE


        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_producto_archivo_validar"
            With .Parameters
                .Clear()
                .Add("@nombrearchivo", SqlDbType.VarChar, 30).Value = NombreArchivo.Trim
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read()
                    With ProductoArchivoBE
                        .idproductoarchivo = dr.ReadNullAsNumeric("idproductoarchivo")
                        .idproducto = dr.ReadNullAsNumeric("idproducto")
                        .rutaarchivo = dr.ReadNullAsEmptyString("rutaarchivo")
                        .nombrearchivo = dr.ReadNullAsEmptyString("nombrearchivo")
                        .fecharegistro = dr.ReadNullAsEmptyDate("fecharegistro")
                        .idusuario = dr.ReadNullAsNumeric("idusuario")
                    End With
                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw New Exception("ProductoArchivoDAO.GetByProductoArchivoValidar - log_producto_archivo_validar" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return ProductoArchivoBE
    End Function

End Class
