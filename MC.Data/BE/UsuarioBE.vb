Public Class UsuarioBE
    Public Property IDUsuario As Int32
    Public Property Nombres As String
    Public Property ApellidoPaterno As String
    Public Property ApellidoMaterno As String
    Public Property Usuario As String
    Public Property Contrasena As String
    Public Property CorreoELectronico As String
    Public Property Login As String
    Public Property Activo As Boolean
    Public Property NombreRol As String
    Public Property IdRol As Int32
    Public Property IdRolAccesos As Int32
    Public Property IdRolTemporal As Int32
    Public Property FechaInicioRol As Nullable(Of Date)
    Public Property FechaFinalRol As Nullable(Of Date)
    Public Property IDUsuarioRegistro As Int32
    Public Property FechaRegistro As DateTime
    Public Property NombreUsuario As String

    Public Property Permisos As List(Of String)

    Public Function Acceso(CodPermiso As String) As Boolean
        Dim Result As Int16 = False

        If Permisos.Where(Function(i) i = CodPermiso).Count = 1 Then
            Result = True
        End If
        Return Result

    End Function

End Class
