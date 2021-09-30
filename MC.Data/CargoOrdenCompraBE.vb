Imports System.ComponentModel.DataAnnotations

Public Class CargoOrdenCompraBE
    Public Property IDCargoOrdenCompra() As Int32
    Public Property IDNumeroOrden() As Int32
    Public Property FechaIngreso() As DateTime

    '<Required(ErrorMessage:="Campo obligatorio")>
    '<StringLength(20, ErrorMessage:="Campo obligatorio")>
    Public Property NumeroFactura() As String

    '<Required(ErrorMessage:="Campo obligatorio")>
    '<StringLength(20, ErrorMessage:="Campo obligatorio")>
    Public Property NumeroGuiaRemision() As String

    Public Property Observaciones() As String
    Public Property Estado() As Int32
    Public Property IDUsuario() As Int32
    Public Property FechaRegistro() As DateTime
End Class
