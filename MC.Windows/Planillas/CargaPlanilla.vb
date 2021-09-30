Imports DevExpress.XtraBars
Imports MC.Data
Imports MC.Framework
Public Class CargaPlanilla
    Dim bsPlanilla As New BindingSource

    Sub New()

        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitGridControl(GridControl1)

        ControlesDevExpress.InitGridViewColumn(GridView1, "IDPLANILLA", "IDPLANILLA", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ANIO", "ANIO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MES", "MES", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGA DE REGISTROS", "ESTADOCARGA", 220, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "USUARIO REGISTRO", "NOMBREUSUARIO", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA REGISTRO", "FECHAREGISTRO", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)

        With GridView1
            .Columns("ANIO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("MES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("ESTADOCARGA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOMBREUSUARIO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAREGISTRO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains

        End With

        Me.GridControl1.DataSource = bsPlanilla
        Refrescar()

    End Sub
    Private Sub Refrescar()
        Try
            bsPlanilla.DataSource = PlanillaDAO.PlanillaListAll()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargaPlanilla_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub btnNueva_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnNueva.ItemClick
        'PlanillaDAO.IdPlanilla = GridView1.GetFocusedRowCellValue("IDPLANILLA")
        'If PlanillaDAO.IdPlanilla > 0 Then
        PlanillaDAO.IdPlanilla = 0
        Dim MiForm As New CargaPlanillaDetails
            MiForm.ShowDialog()
        'End If
        Refrescar()
    End Sub

    Private Sub btnCargaMasiva_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCargaMasiva.ItemClick
        PlanillaDAO.IdPlanilla = GridView1.GetFocusedRowCellValue("IDPLANILLA")
        If PlanillaDAO.IdPlanilla > 0 Then
            Dim MiForm As New CargaPlanillaEmpleado
            If GridView1.GetFocusedRowCellValue("ESTADOCARGA") Then
                MiForm.btnImportar.Visibility = BarItemVisibility.Never
                MiForm.btnGrabar.Visibility = BarItemVisibility.Never
            End If
            MiForm.lblAnio.Caption = "Año: " & GridView1.GetFocusedRowCellValue("ANIO")
            MiForm.lblMes.Caption = "Mes: " & GridView1.GetFocusedRowCellValue("MES")
            MiForm.ShowDialog()
        End If
        Refrescar()
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        btnConcepto.PerformClick()
    End Sub

    Private Sub btnConcepto_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnConcepto.ItemClick
        PlanillaDAO.IdPlanilla = GridView1.GetFocusedRowCellValue("IDPLANILLA")
        If PlanillaDAO.IdPlanilla > 0 Then
            Dim MiForm As New CargaPlanillaDetails
            MiForm.ShowDialog()
            Refrescar()
        End If
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub
End Class