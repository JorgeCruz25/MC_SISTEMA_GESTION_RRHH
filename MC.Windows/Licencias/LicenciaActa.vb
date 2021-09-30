Public Class LicenciaActa
    Sub New()
        InitializeComponent()
        Me.WindowState = FormWindowState.Maximized

    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub
End Class