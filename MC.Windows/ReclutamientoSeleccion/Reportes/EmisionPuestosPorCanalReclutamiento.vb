Imports MC.Data
Imports MC.Framework
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraBars
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraCharts

Public Class EmisionPuestosPorCanalReclutamiento

    Private Sub EmisionPuestosPorCanalReclutamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEmitir_Click(sender As Object, e As EventArgs) Handles btnEmitir.Click
        Dim RPT As New PuestosPorCanalReclutamientoRPT
        RPT.DataSource = BDCentralDAO.ReportePuestosCanalReclutamiento(dtFechaInicial.Value.Date + " " + "00:00:00", dtFechaFinal.Value.Date + " " + "23:59:00")

        Dim dtChart As New DataTable
        dtChart = BDCentralDAO.ReportePuestosCanalReclutamientoChart(dtFechaInicial.Value.Date + " " + "00:00:00", dtFechaFinal.Value.Date + " " + "23:59:00")
        RPT.XrChart1.Series(0).Points.Clear()
        If dtChart.Rows.Count() > 0 Then
            RPT.XrChart1.Series(0).DataSource = dtChart
            For i = 0 To dtChart.Rows.Count() - 1
                RPT.XrChart1.Series(0).Points.Add(New SeriesPoint(dtChart.Rows(i)("CARGO").ToString(), dtChart.Rows(i)("CANTIDAD")))
            Next
        End If

        RPT.DataMember = "Reporte"
        RPT.XrLabelFecha.Text = "Rango de Fechas desde " + dtFechaInicial.Value.ToString("dd/MM/yyyy") + " hasta " + dtFechaFinal.Value.ToString("dd/MM/yyyy")
        ReporteView.DocumentViewer1.DocumentSource = RPT

        ReporteView.DocumentViewer1.Refresh()
        ReporteView.Show()
    End Sub

End Class
