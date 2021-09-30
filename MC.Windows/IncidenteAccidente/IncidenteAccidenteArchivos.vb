Imports DevExpress.XtraBars
Public Class IncidenteAccidenteArchivos
    Sub New()
        InitializeComponent()
        Me.WindowState = FormWindowState.Maximized
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True
    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub
End Class