Imports MC.Data
Imports MC.Framework

Public Class FuenteReclutamientoEditDetalle

    Dim FuenteReclutamientoDetalleBE As New FuenteReclutamientoDetalleBE

    Private Sub FuenteReclutamientoEditDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdFuenteDetalle.Text = "0"
        ControlesDevExpress.InitGridViewColumn(GridView1, "ID", "IDFUENTEDETALLE", 40, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DESCRIPCION", "DESCRIPCION", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        Me.GridControl1.DataSource = BDCentralDAO.GetFuenteReclutamientoDetalleListXIdFuente(BDCentralDAO.IdFuente)

    End Sub

    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        txtIdFuenteDetalle.Text = GridView1.GetFocusedRowCellValue("IDFUENTEDETALLE")
        txtDescripcionDetalle.Text = GridView1.GetFocusedRowCellValue("DESCRIPCION")
    End Sub

    Private Sub limpiar()
        txtIdFuenteDetalle.Text = "0"
        txtDescripcionDetalle.Text = ""
    End Sub

    Private Sub btnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick
        limpiar()
    End Sub

    Private Sub btnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick
        If txtDescripcionDetalle.Text = "" Then
            Exit Sub
        End If

        With FuenteReclutamientoDetalleBE
            .IDFUENTEDETALLE = txtIdFuenteDetalle.Text
            .IDFUENTE = BDCentralDAO.IdFuente
            .DESCRIPCION = txtDescripcionDetalle.Text
        End With

        BDCentralDAO.SaveFuenteReclutamientoDetalle(FuenteReclutamientoDetalleBE)
        limpiar()
        Me.GridControl1.DataSource = BDCentralDAO.GetFuenteReclutamientoDetalleListXIdFuente(BDCentralDAO.IdFuente)
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

End Class