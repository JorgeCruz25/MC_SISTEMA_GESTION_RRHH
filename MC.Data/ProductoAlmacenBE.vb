Imports System.ComponentModel.DataAnnotations

Public Class ProductoAlmacenBE

    Public Property idproductoalmacen() As Int32
    Public Property idproducto() As Int32

    <Required(ErrorMessage:="Campo obligatorio")>
    <Range(1, Int32.MaxValue, ErrorMessage:="Campo obligatorio")>
    Public Property idalmacen() As Int32

    <Required(ErrorMessage:="Campo obligatorio")>
    <Range(1, Int32.MaxValue, ErrorMessage:="Campo obligatorio")>
    Public Property entero() As Int32

    <Required(ErrorMessage:="Campo obligatorio")>
    <Range(1, Int32.MaxValue, ErrorMessage:="Campo obligatorio")>
    Public Property fraccion() As Int32

    Public Property codubicacion() As String

    <Required(ErrorMessage:="Campo obligatorio")>
    <Range(1, Int32.MaxValue, ErrorMessage:="Campo obligatorio")>
    Public Property stockminimo As Int32

    <Required(ErrorMessage:="Campo obligatorio")>
    <Range(1, Int32.MaxValue, ErrorMessage:="Campo obligatorio")>
    Public Property stockmaximo As Int32

    Public Property idusuario() As Int32
    Public Property fecharegistro() As DateTime

End Class
