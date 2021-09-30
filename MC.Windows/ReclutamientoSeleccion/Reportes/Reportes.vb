Public Class Reportes

    Private Sub Emisiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub CargarControl(ByVal usrCtrl As Control)
        Dim con As Control
        For controlIndex As Integer = pnlMain.Controls.Count - 1 To 0 Step -1
            con = pnlMain.Controls(controlIndex)
            pnlMain.Controls.Remove(con)
        Next
        pnlMain.Controls.Add(usrCtrl)
        usrCtrl.Dock = DockStyle.Fill
    End Sub

    Private Sub itemCanalReclutamiento_Click(sender As Object, e As EventArgs) Handles itemCanalReclutamiento.Click
        Dim usrCtrl As New EmisionCanalesReclutamiento
        CargarControl(usrCtrl)
    End Sub

    Private Sub itemRequerimientosMasivos_Click(sender As Object, e As EventArgs) Handles itemRequerimientosMasivos.Click
        Dim usrCtrl As New EmisionRequerimientosMasivos
        CargarControl(usrCtrl)
    End Sub

    Private Sub itemPuestoPorCanalReclutamiento_Click(sender As Object, e As EventArgs) Handles itemPuestoPorCanalReclutamiento.Click
        Dim usrCtrl As New EmisionPuestosPorCanalReclutamiento
        CargarControl(usrCtrl)
    End Sub

    Private Sub itemConclusionPostulanteCanalReclutamiento_Click(sender As Object, e As EventArgs) Handles itemConclusionPostulanteCanalReclutamiento.Click
        Dim usrCtrl As New EmisionConclusionPostulanteCanalReclutamiento
        CargarControl(usrCtrl)
    End Sub

End Class