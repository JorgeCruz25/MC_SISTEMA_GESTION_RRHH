Imports System.Configuration

Public Class ConexionDAO

    Shared Function GetConexionDBLogistica() As String
        'Dim strCnx As String = "Server=XEON;DataBase=logistica;User ID=roelogin;Password=L@br0e1950;"
        Dim strCnx As String = "Server=XEON;DataBase=logistica;User ID=roesistemas;Password=MCML!!!L#br0e;"

        Return strCnx
    End Function

    Shared Function GetConexionDBlabroe() As String
        'Dim strCnxLabRoe As String = "Server=XEON;DataBase=labroe;User ID=roelogin;Password=ML@br0e1950;"
        Dim strCnxLabRoe As String = "Server=XEON;DataBase=labroe;User ID=roesistemas;Password=MCML!!!L#br0e;"

        Return strCnxLabRoe
    End Function

End Class
