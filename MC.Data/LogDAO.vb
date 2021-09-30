Imports System
Imports System.Diagnostics

Public Class LogDAO

    Shared Sub SaveLog(ByVal Mensaje As String, Tipo As EventLogEntryType)
        Dim Log As New EventLog()
        Log.Source = "ROE LOGISTICA"

        Try
            Log.WriteEntry(Mensaje, Tipo)

        Catch ex As Exception
            Log.WriteEntry(ex.Message, EventLogEntryType.Error)
        End Try
    End Sub

End Class
