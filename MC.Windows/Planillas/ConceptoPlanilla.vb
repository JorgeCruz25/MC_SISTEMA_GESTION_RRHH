Imports MC.Framework
Imports MC.Data
Public Class ConceptoPlanilla
    Dim bsConcepto As New BindingSource
    Sub New()

        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitGridControl(GridControl1)

        ControlesDevExpress.InitGridViewColumn(GridView1, "IDPLANILLACONCEPTO", "IDPLANILLACONCEPTO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CONCEPTO", "DESCRIPCION", 400, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "USUARIO REGISTRO", "NOMBREUSUARIO", 400, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA REGISTRO", "FECHAREGISTRO", 200, True, ControlesDevExpress.eGridViewFormato.Fecha, False)

        With GridView1
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOMBREUSUARIO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAREGISTRO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        Me.GridControl1.DataSource = bsConcepto
        Refrescar()

    End Sub
    Private Sub Refrescar()
        Try
            bsConcepto.DataSource = PlanillaDAO.ConceptoPlanillaListAll()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick
        Dim MiForm As New ConceptoPlanillaDetails
        MiForm.ShowDialog()
        Refrescar()
    End Sub

    Private Sub ConceptoPlanilla_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub
End Class