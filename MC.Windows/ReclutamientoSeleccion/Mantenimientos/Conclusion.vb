Imports MC.Data
Imports MC.Framework

Public Class Conclusion

    Private Sub Conclusion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlesDevExpress.InitGridViewColumn(GridView1, "ID", "IDCONCLUSION", 40, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DESCRIPCION", "DESCRIPCION", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        Me.GridControl1.DataSource = BDCentralDAO.GetConclusionList
    End Sub

    Private Sub btnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick
        BDCentralDAO.IdConclusion = 0
        Dim MiForm As New ConclusionEdit
        MiForm.ShowDialog()
        Me.GridControl1.DataSource = BDCentralDAO.GetConclusionList
    End Sub

    Private Sub btnEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditar.ItemClick
        BDCentralDAO.IdConclusion = GridView1.GetFocusedRowCellValue("IDCONCLUSION")
        Dim MiForm As New ConclusionEdit
        MiForm.ShowDialog()
        Me.GridControl1.DataSource = BDCentralDAO.GetConclusionList
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        BDCentralDAO.IdConclusion = GridView1.GetFocusedRowCellValue("IDCONCLUSION")
        Dim MiForm As New ConclusionEdit
        MiForm.ShowDialog()
        Me.GridControl1.DataSource = BDCentralDAO.GetConclusionList
    End Sub

    Private Sub btnDetalle_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDetalle.ItemClick
        BDCentralDAO.IdConclusion = GridView1.GetFocusedRowCellValue("IDCONCLUSION")
        Dim MiForm As New ConclusionEditDetalle
        MiForm.ShowDialog()
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub Conclusion_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

End Class