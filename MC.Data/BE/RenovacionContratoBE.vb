Public Class RenovacionContratoBE
    Public Property IdEmpleado As Integer
    Public Property Nombre As String
    Public Property ApellidoPaterno As String
    Public Property ApellidoMaterno As String
    Public Property Dni As String
    'Public Property FechaFinContrato As String
    Public Property FechaPeriodoInicio As Date
    Public Property FechaPeriodoFin As Date
    Public Property NumeroMesesRenovar As Integer
    Public Property IdRenovacionDetalle As Integer
    Public Property IdPeriodoRenovacion As Integer
    Public Property IdPeriodoTipo As Integer
    Public Property EstadoValidado As Boolean

    Public Property IdLocal As Integer
    Public Property RazonComercial As String
    Public Property IDCargo As Integer
    Public Property Cargo As String
    Public Property FechaEnvioCorreoFirmaDesde As Date
    Public Property FechaEnvioCorreoFirmaHasta As Date
    Public Property HoraEnvioCorreoFirmaDesde As String
    Public Property HoraEnvioCorreoFirmaHasta As String
    Public Property EnvioCorreoFirma As Boolean

End Class
