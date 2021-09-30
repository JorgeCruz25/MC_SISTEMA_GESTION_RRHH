Imports MC.Data
Imports MC.Framework

Public Class rptEmisionRequerimientosMasivos

    Private Sub btnEmitir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEmitir.ItemClick
        Dim RPT As New RequerimientosMasivosRPT
        RPT.DataSource = BDCentralDAO.ReporteRequerimientosMasivos(dtFechaInicial.Value.Date + " " + "00:00:00", dtFechaFinal.Value.Date + " " + "23:59:00")

        RPT.DataMember = "Reporte"
        RPT.XrLabelFecha.Text = "Rango de Fechas desde " + dtFechaInicial.Value.ToString("dd/MM/yyyy") + " hasta " + dtFechaFinal.Value.ToString("dd/MM/yyyy")
        ReporteView.DocumentViewer1.DocumentSource = RPT

        ReporteView.DocumentViewer1.Refresh()
        ReporteView.Show()
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub rptEmisionRequerimientosMasivos_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub rptEmisionRequerimientosMasivos_Load(sender As Object, e As EventArgs) Handles Me.Load
        inabilitarbotones()
        Dim dtAccionesUsuario As DataTable
        dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
        Tools.AccionesUsuarioRibbon(RibbonControl, dtAccionesUsuario)
    End Sub
    Private Sub inabilitarbotones()
        btnEmitir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub

    Private Sub btnConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConsultar.ItemClick
        Dim MiForm As New rptEmisionRequerimientosMasivosGrid
        MiForm.bsRequerimientoMasivo.DataSource = BDCentralDAO.ReporteRequerimientosMasivos(dtFechaInicial.Value.Date + " " + "00:00:00", dtFechaFinal.Value.Date + " " + "23:59:00")
        MiForm.ShowDialog()
    End Sub
End Class