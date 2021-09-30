Imports System.ComponentModel.DataAnnotations

Public Class CargoOrdenCompraDetalleBE

    Public Property IDCargoOrdenCompraDetalle() As Int32
    Public Property IDCargoOrdenCompra() As Int32
    Public Property IDProducto() As Int32
    Public Property Lote() As String
    '<Required(ErrorMessage:="Campo obligatorio")>
    '<Range(GetType(DateTime), "01/01/2015", "01/01/2015", ErrorMessage:="Campo obligatorio")>
    Public Property FechaVencimiento() As DateTime
    '<Required(ErrorMessage:="Campo obligatorio")>
    '<Range(0.01, Decimal.MaxValue, ErrorMessage:="Cambio obligatorio")>
    Public Property CantidadIngreso() As Single
    Public Property PrecioOrden() As Single
End Class
