Imports System.Data
Imports System.Data.SqlClient

Public Class ConfiguracionBE
    Property RutaArchivo As String
End Class


Public Class ConfiguracionDAO
    Property RutaArchivo As String
    Dim ConfiguracionBE As New ConfiguracionBE



    Public Function GetByProductoArchivoID(ByVal IDConfiguracion As Int32) As ConfiguracionBE
        Dim cnx As New SqlConnection(strCnx)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_configuracion_get_id"
            With .Parameters
                .Add("@idconfiguracion", SqlDbType.Int).Value = IDConfiguracion
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    With ConfiguracionBE
                        .RutaArchivo = dr.ReadNullAsEmptyString("rutaarchivo")
                        RutaArchivo = dr.ReadNullAsEmptyString("rutaarchivo")
                    End With
                End While
            End If
        Catch ex As Exception
            Throw New Exception("ConfiguracionDAO.GetByProductoArchivoID - log_configuracion_get_id" & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return ConfiguracionBE
    End Function
End Class
