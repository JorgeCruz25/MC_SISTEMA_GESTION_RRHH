Imports MC.Data
Imports MC.Framework
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraBars
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraCharts

Public Class EmisionCanalesReclutamiento

    Private Sub EmisionCanalReclutamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtYear.Text = Year(Date.Now).ToString
    End Sub

    Private Sub btnMas_Click(sender As Object, e As EventArgs) Handles btnMas.Click
        txtYear.Text = txtYear.Text + 1
    End Sub

    Private Sub btnMenos_Click(sender As Object, e As EventArgs) Handles btnMenos.Click
        txtYear.Text = txtYear.Text - 1
    End Sub

    Private Sub btnEmitir_Click(sender As Object, e As EventArgs) Handles btnEmitir.Click
        Dim RPT As New CanalesReclutamientoRPT
        RPT.DataSource = BDCentralDAO.ReporteCanalesReclutamiento(txtYear.Text)

        Dim dtChart As New DataTable
        dtChart = BDCentralDAO.ReporteCanalesReclutamientoChart(txtYear.Text)
        RPT.XrChart1.Series(0).Points.Clear()
        If dtChart.Rows.Count() > 0 Then
            RPT.XrChart1.Series(0).DataSource = dtChart
            For i = 0 To dtChart.Rows.Count() - 1
                RPT.XrChart1.Series(0).Points.Add(New SeriesPoint(dtChart.Rows(i)("FUENTE").ToString(), dtChart.Rows(i)("CANTIDAD")))
            Next
        End If

        RPT.DataMember = "Reporte"
        RPT.XrLabelFecha.Text = "Año :  " + txtYear.Text
        ReporteView.DocumentViewer1.DocumentSource = RPT

        ReporteView.DocumentViewer1.Refresh()
        ReporteView.Show()
    End Sub
End Class
