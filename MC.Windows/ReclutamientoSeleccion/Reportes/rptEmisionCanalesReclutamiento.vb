Imports MC.Data
Imports DevExpress.XtraCharts
Imports MC.Framework

Public Class rptEmisionCanalesReclutamiento
    Private Sub rptEmisionCanalesReclutamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inabilitarbotones()
        Dim dtAccionesUsuario As DataTable
        dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
        Tools.AccionesUsuarioRibbon(RibbonControl, dtAccionesUsuario)
        txtYear.Text = Year(Date.Now).ToString
    End Sub
    Private Sub inabilitarbotones()
        btnEmitir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub

    Private Sub btnMas_Click(sender As Object, e As EventArgs) Handles btnMas.Click
        txtYear.Text = txtYear.Text + 1
    End Sub

    Private Sub btnMenos_Click(sender As Object, e As EventArgs) Handles btnMenos.Click
        txtYear.Text = txtYear.Text - 1
    End Sub

    Private Sub btnEmitir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEmitir.ItemClick
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

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub rptEmisionCanalesReclutamiento_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

End Class