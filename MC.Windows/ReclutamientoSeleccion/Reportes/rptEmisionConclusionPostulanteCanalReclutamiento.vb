Imports MC.Data
Imports DevExpress.XtraCharts
Imports MC.Framework

Public Class rptEmisionConclusionPostulanteCanalReclutamiento
    Private Sub rptEmisionConclusionPostulanteCanalReclutamiento_Load(sender As Object, e As EventArgs) Handles Me.Load
        inabilitarbotones()
        Dim dtAccionesUsuario As DataTable
        dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
        Tools.AccionesUsuarioRibbon(RibbonControl, dtAccionesUsuario)
    End Sub
    Private Sub inabilitarbotones()
        btnEmitir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub

    Private Sub btnEmitir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEmitir.ItemClick
        Dim RPT As New ConclusionPostulanteCanalReclutamientoRPT
        RPT.DataSource = BDCentralDAO.ReporteConclusionPostulanteCanalReclutamiento(dtFechaInicial.Value.Date + " " + "00:00:00", dtFechaFinal.Value.Date + " " + "23:59:00")

        Dim dtChart As New DataTable
        dtChart = BDCentralDAO.ReporteConclusionPostulanteCanalReclutamientoChart(dtFechaInicial.Value.Date + " " + "00:00:00", dtFechaFinal.Value.Date + " " + "23:59:00")
        RPT.XrChart1.Series(0).Points.Clear()
        If dtChart.Rows.Count() > 0 Then
            RPT.XrChart1.Series(0).DataSource = dtChart
            For i = 0 To dtChart.Rows.Count() - 1
                RPT.XrChart1.Series(0).Points.Add(New SeriesPoint(dtChart.Rows(i)("CONCLUSION").ToString(), dtChart.Rows(i)("CANTIDAD")))
            Next
        End If

        RPT.DataMember = "Reporte"
        RPT.XrLabelFecha.Text = "Rango de Fechas desde " + dtFechaInicial.Value.ToString("dd/MM/yyyy") + " hasta " + dtFechaFinal.Value.ToString("dd/MM/yyyy")
        ReporteView.DocumentViewer1.DocumentSource = RPT

        ReporteView.DocumentViewer1.Refresh()
        ReporteView.Show()
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub rptEmisionConclusionPostulanteCanalReclutamiento_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

End Class