Imports MC.Data
Imports MC.Framework

Public Class ConclusionEditDetalle

    Dim ConclusionDetalleBE As New ConclusionDetalleBE


    Private Sub ConclusionEditDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdConclusionDetalle.Text = "0"
        ControlesDevExpress.InitGridViewColumn(GridView1, "ID", "IDCONCLUSIONDETALLE", 40, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DESCRIPCION", "DESCRIPCION", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        Me.GridControl1.DataSource = BDCentralDAO.GetConclusionDetalleListXIdConclusion(BDCentralDAO.IdConclusion)

    End Sub

    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        txtIdConclusionDetalle.Text = GridView1.GetFocusedRowCellValue("IDCONCLUSIONDETALLE")
        txtDescripcionDetalle.Text = GridView1.GetFocusedRowCellValue("DESCRIPCION")
    End Sub

    Private Sub limpiar()
        txtIdConclusionDetalle.Text = "0"
        txtDescripcionDetalle.Text = ""
    End Sub

    Private Sub btnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick
        limpiar()
    End Sub

    Private Sub btnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick
        If txtDescripcionDetalle.Text = "" Then
            Exit Sub
        End If

        With ConclusionDetalleBE
            .IDCONCLUSIONDETALLE = txtIdConclusionDetalle.Text
            .IDCONCLUSION = BDCentralDAO.IdConclusion
            .DESCRIPCION = txtDescripcionDetalle.Text
        End With

        BDCentralDAO.SaveConclusionDetalle(ConclusionDetalleBE)
        limpiar()
        Me.GridControl1.DataSource = BDCentralDAO.GetConclusionDetalleListXIdConclusion(BDCentralDAO.IdConclusion)
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub
End Class