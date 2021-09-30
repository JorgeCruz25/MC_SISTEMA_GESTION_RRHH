Imports MC.Data
Imports MC.Framework

Public Class FuenteReclutamiento

    Private Sub FuenteReclutamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ControlesDevExpress.InitGridViewColumn(GridView1, "ID", "IDFUENTE", 40, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DESCRIPCION", "DESCRIPCION", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        Me.GridControl1.DataSource = BDCentralDAO.GetFuenteReclutamientoList
    End Sub

    Private Sub btnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick
        BDCentralDAO.IdFuente = 0
        Dim MiForm As New FuenteReclutamientoEdit
        MiForm.ShowDialog()
        Me.GridControl1.DataSource = BDCentralDAO.GetFuenteReclutamientoList
    End Sub

    Private Sub btnEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditar.ItemClick
        BDCentralDAO.IdFuente = GridView1.GetFocusedRowCellValue("IDFUENTE")
        Dim MiForm As New FuenteReclutamientoEdit
        MiForm.ShowDialog()
        Me.GridControl1.DataSource = BDCentralDAO.GetFuenteReclutamientoList
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        BDCentralDAO.IdFuente = GridView1.GetFocusedRowCellValue("IDFUENTE")
        Dim MiForm As New FuenteReclutamientoEdit
        MiForm.ShowDialog()
        Me.GridControl1.DataSource = BDCentralDAO.GetFuenteReclutamientoList
    End Sub

    Private Sub btnDetalle_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDetalle.ItemClick
        BDCentralDAO.IdFuente = GridView1.GetFocusedRowCellValue("IDFUENTE")
        Dim MiForm As New FuenteReclutamientoEditDetalle
        MiForm.ShowDialog()
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub FuenteReclutamiento_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

End Class