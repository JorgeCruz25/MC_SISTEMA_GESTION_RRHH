Public Class PrioridadDAO
    Property PrioridadCod As String
    Property Prioridad As String

    Public Function GetByPrioridad() As DataTable
        Dim dt As New DataTable

        With dt
            .Columns.Add("CodPrioridad", Type.GetType("System.String"))
            .Columns.Add("Nombre", Type.GetType("System.String"))
        End With

        Dim dr1 As DataRow = Nothing

        dr1 = dt.NewRow
        dr1(0) = "N"
        dr1(1) = "NORMAL"


        Dim dr2 As DataRow = Nothing

        dr2 = dt.NewRow
        dr2(0) = "U"
        dr2(1) = "URGENTE"

        dt.Rows.Add(dr1)
        dt.Rows.Add(dr2)

        Return dt
    End Function
End Class
