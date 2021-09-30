Imports MC.Data
Imports MC.Framework
Public Class RespuestaPlanillaHistorial
    Dim bsPlanillaConsultaRevisado As New BindingSource
    Sub New()

        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True
        Me.Text = "HISTORICO PLANILLA"
        Me.WindowState = FormWindowState.Maximized

        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDPLANILLADETALLECONCEPTO", "IDPLANILLADETALLECONCEPTO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDPLANILLADETALLE", "IDPLANILLADETALLE", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MATRICULA", "MATRICULA", 90, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBRESAPELLIDOS", "NOMBRESAPELLIDOS", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "SEDE", "RAZONCOMERCIAL", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHAINGRESO", "FECHAINGRESO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IMPORTE_PAGADO", "SUELDOBASICO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CONCEPTO", "CONCEPTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DESCRIPCIONSOLICITUD", "DESCRIPCIONSOLICITUD", 500, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO_RESPUESTA", "RESPUESTA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IMPORTE_INTEGRAR", "IMPORTEINTEGRO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IMPORTE_DESCONTAR", "IMPORTEDESCUENTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RESPUESTA_SOLICITUD", "RESPUESTASOLICITUD", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO_SOLICITUD", "ESTADOSOLICITUD", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDSOLICITUDPLANILLA", "IDSOLICITUDPLANILLA", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        Me.GridControl1.DataSource = bsPlanillaConsultaRevisado
        RefrescarConsultasRevisadas()

    End Sub
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub
    Private Sub RefrescarConsultasRevisadas()
        Try
            bsPlanillaConsultaRevisado.DataSource = PlanillaDAO.PlanillaConsultasRevisadasGetIdPlanilla(PlanillaDAO.IdPlanilla)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class