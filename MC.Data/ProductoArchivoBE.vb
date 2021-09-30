Imports System.ComponentModel.DataAnnotations

Public Class ProductoArchivoBE

    Public Property idproductoarchivo As Int32
    Public Property idproducto As Int32
    Public Property rutaarchivo As String

    '<Required(ErrorMessage:="Campo obligatorio")>
    '<StringLength(300, MinimumLength:=1, ErrorMessage:="Campo obligatorio")>
    <Required(ErrorMessage:="Campo obligatorio")>
    <StringLength(300, MinimumLength:=1, ErrorMessage:="El campo debe tener un cáracter como mínimo")>
    Public Property nombrearchivo As String

    Public Property idusuario As Int32
    Public Property fecharegistro As DateTime
End Class
