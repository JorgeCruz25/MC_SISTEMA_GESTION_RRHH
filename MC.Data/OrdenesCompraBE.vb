Imports System.ComponentModel.DataAnnotations

Public Class OrdenesCompraBE
    Public Property idnumeroorden() As Int32

    Public Property numeroorden() As String

    <Required(ErrorMessage:="Campo obligatorio")>
    <Range(1, Int32.MaxValue, ErrorMessage:="Campo obligatorio")>
    Public Property codproveedor() As Int32

    Public Property razonsocial As String

    <Required(ErrorMessage:="Campo obligatorio")>
    <Range(1, Int32.MaxValue, ErrorMessage:="Campo obligatorio")>
    Public Property idalmacen() As Int32

    <Required(ErrorMessage:="Campo obligatorio")>
    <Range(1, Int32.MaxValue, ErrorMessage:="Campo obligatorio")>
    Public Property idtipopago() As Int32

    Public Property diascredito() As Int32

    <Required(ErrorMessage:="Campo obligatorio")>
    <Range(1, Int32.MaxValue, ErrorMessage:="Campo obligatorio")>
    Public Property idmoneda() As Int32

    Public Property prioridad() As String

    Public Property situacion() As String

    Public Property fechaemision() As Nullable(Of DateTime)

    Public Property fechaprogramacion() As Nullable(Of DateTime)

    Public Property fecharecepcion() As Nullable(Of DateTime)

    Public Property fechaanulacion() As Nullable(Of DateTime)

    Public Property importeneto() As Decimal

    Public Property importeigv() As Decimal

    Public Property importetotal() As Decimal

    Public Property porcentajeimpuesto() As Decimal

    Public Property observaciones() As String

    Public Property estado As Int32

    Public Property idusuario() As Int32

    Public Property fecharegistro() As DateTime

End Class
