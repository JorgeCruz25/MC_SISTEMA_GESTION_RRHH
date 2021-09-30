Public Class PrestamosBE
    Public Property IdPrestamos As Integer
    Public Property NumeroSolicitud As String
    Public Property IdLocal As Integer
    Public Property IdEmpleado As Integer
    Public Property Nombres As String
    Public Property ApellidoPaterno As String
    Public Property ApellidoMaterno As String
    Public Property DNI As String
    Public Property Cargo As String
    Public Property Fecha As Date
    Public Property RazonSocial As String
    Public Property RazonComercial As String
    Public Property Monto As Double
    Public Property IdMotivoPrestamo As Integer
    Public Property MotivoPrestamo As String
    Public Property IdTipoPago As Integer
    Public Property IdMedioPago As Integer
    Public Property MontoAprobado As Double
    Public Property MontoDescuento As Double
    Public Property PorcentajeGratificacionDescuento As Double

    Public Property EstadoValidadoRrhh As Boolean

    Public Property IdBanco As Integer
    Public Property CodigoDeposito As String
    Public Property FechaDeposito As DateTime
    Public Property EstadoRevisado As Boolean
    Public Property EstadoAnulado As Boolean
    Public Property EstadoRegistroAdryan As Boolean

    Public Property Solicitante As String

    Public Property FechaIngresoCorporativo As String
    Public Property FechaIngresoLocal As String
    Public Property DescripcionPrestamoSolicitud As String
    Public Property DescripcionPrestamoRrhh As String
    Public Property MontoVacacionesDescuento As Double
    Public Property MontoLiquidacionDescuento As Double

End Class
