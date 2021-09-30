Imports System.Configuration

Public Class ConexionDAO

    Public Shared Function GetConexionMC_CENTRAL() As String
        Dim strCnx As String = String.Empty
        strCnx = ConfigurationManager.ConnectionStrings("MC.SistemaGestionRRHH.My.MySettings.MC_CENTRALConnectionString").ConnectionString
        Return strCnx
    End Function

    Public Shared Function GetConexionMC_CONTROL_ATENCIONES() As String
        Dim strCnx1 As String = String.Empty
        strCnx1 = ConfigurationManager.ConnectionStrings("MC.SistemaGestionRRHH.My.MySettings.MC_CONTROLATENCIONESConnectionString").ConnectionString
        Return strCnx1
    End Function

    Public Shared Function GetConexionADRYAN() As String
        Dim strCnx As String = String.Empty
        strCnx = ConfigurationManager.ConnectionStrings("MC.SistemaGestionRRHH.My.MySettings.MC_ADRYANConnectionString").ConnectionString
        Return strCnx
    End Function
End Class
