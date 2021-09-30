Imports MC.Framework
Imports MC.Data
Public Class MantenimientoCurso
    Dim bsCursos As New BindingSource
    Sub New()
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDCURSO", "IDCURSO", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DESCRIPCION", "DESCRIPCION", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOTA APROBATORIA", "NOTAAPROBATORIA", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO", "ESTADO", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridView1
            .Columns("IDCURSO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("ESTADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        Refrescar()
    End Sub
    Private Sub Refrescar()
        Try
            inabilitarbotones()
            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(RibbonControl, dtAccionesUsuario)
            bsCursos.DataSource = CapacitacionDAO.CursosListAll()
            Me.GridControl1.DataSource = bsCursos
        Catch ex As Exception

        End Try
    End Sub
    Private Sub inabilitarbotones()
        btnNuevo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnEditar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub
    Private Sub btnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick
        CapacitacionDAO.IdCurso = 0
        Dim MiForm As New MantenimientoCursoDetails
        MiForm.ShowDialog()
        Refrescar()
    End Sub
    Private Sub btnEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditar.ItemClick
        CapacitacionDAO.IdCurso = GridView1.GetFocusedRowCellValue("IDCURSO")
        Dim MiForm As New MantenimientoCursoDetails
        MiForm.ShowDialog()
        Refrescar()
    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub
    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        btnEditar.PerformClick()
    End Sub
    Private Sub MantenimientoProgramacion_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub


End Class