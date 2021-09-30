Imports MC.Data
Imports MC.Framework

Public Class ConclusionEdit

    Dim ConclusionBE As New ConclusionBE

    Private Sub ConclusionEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEntidad()
    End Sub

    Private Sub LoadEntidad()
        If BDCentralDAO.IdConclusion = 0 Then
            txtIdConclusion.Text = 0
        Else
            ConclusionBE = BDCentralDAO.GetConclusionID(BDCentralDAO.IdConclusion)
            With ConclusionBE
                txtIdConclusion.Text = .IDCONCLUSION
                txtDescripcion.Text = .DESCRIPCION
            End With
        End If
    End Sub

    Private Sub btnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick

        If txtDescripcion.Text = "" Then
            Exit Sub
        End If

        With ConclusionBE
            .IDCONCLUSION = txtIdConclusion.Text
            .DESCRIPCION = txtDescripcion.Text
        End With

        BDCentralDAO.SaveConclusion(ConclusionBE)
        Me.Close()
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

End Class