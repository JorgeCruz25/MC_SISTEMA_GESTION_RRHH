Imports MC.Data
Imports MC.Framework
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraBars
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraCharts

Public Class EmisionRequerimientosMasivos

    Private Sub EmisionRequerimientosMasivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEmitir_Click(sender As Object, e As EventArgs) Handles btnEmitir.Click
        Dim RPT As New RequerimientosMasivosRPT
        RPT.DataSource = BDCentralDAO.ReporteRequerimientosMasivos(dtFechaInicial.Value.Date + " " + "00:00:00", dtFechaFinal.Value.Date + " " + "23:59:00")

        RPT.DataMember = "Reporte"
        RPT.XrLabelFecha.Text = "Rango de Fechas desde " + dtFechaInicial.Value.ToString("dd/MM/yyyy") + " hasta " + dtFechaFinal.Value.ToString("dd/MM/yyyy")
        ReporteView.DocumentViewer1.DocumentSource = RPT

        ReporteView.DocumentViewer1.Refresh()
        ReporteView.Show()
    End Sub

End Class
