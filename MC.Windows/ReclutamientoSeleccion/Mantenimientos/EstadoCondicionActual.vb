Imports MC.Data
Imports MC.Framework

Public Class EstadoCondicionActual

    Private Sub EstadoCondicionActual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlesDevExpress.InitGridViewColumn(GridView1, "ID", "IDCONDICIONACTUAL", 40, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DESCRIPCION", "DESCRIPCION", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ACTIVO", "ACTIVO", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        Me.GridControl1.DataSource = BDCentralDAO.GetListadoEstadoCondicionActual
    End Sub

    Private Sub btnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick
        BDCentralDAO.IdEstadoCondicionActual = 0
        Dim MiForm As New EstadoCondicionActualEdit
        MiForm.ShowDialog()
        Me.GridControl1.DataSource = BDCentralDAO.GetListadoEstadoCondicionActual
    End Sub

    Private Sub btnEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditar.ItemClick
        BDCentralDAO.IdEstadoCondicionActual = GridView1.GetFocusedRowCellValue("IDCONDICIONACTUAL")
        Dim MiForm As New EstadoCondicionActualEdit
        MiForm.ShowDialog()
        Me.GridControl1.DataSource = BDCentralDAO.GetListadoEstadoCondicionActual
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        BDCentralDAO.IdEstadoCondicionActual = GridView1.GetFocusedRowCellValue("IDCONDICIONACTUAL")
        Dim MiForm As New EstadoCondicionActualEdit
        MiForm.ShowDialog()
        Me.GridControl1.DataSource = BDCentralDAO.GetListadoEstadoCondicionActual
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub EstadoCondicionActual_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

End Class