<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BonoAntiguedadList
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BonoAntiguedadList))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRefrescar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAprobar = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemGridLookUpEditTipoIdentidad = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewTipoIdentidad = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemGridLookUpEditSexo = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewSexo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemGridLookUpEditTipoDerechoHabiente = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewTipoDerechoHabiente = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemGridLookUpEditNacionalidad = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewOriginario = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemGridLookUpEditDistrito = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewDistrito = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEditTregistro = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEditEssalud = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditTipoIdentidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewTipoIdentidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditSexo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSexo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditTipoDerechoHabiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewTipoDerechoHabiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditNacionalidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewOriginario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditDistrito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewDistrito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEditTregistro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEditEssalud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnCerrar, Me.btnRefrescar, Me.btnAprobar})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 4
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(778, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnCerrar
        '
        Me.btnCerrar.Caption = "Cerrar"
        Me.btnCerrar.Glyph = CType(resources.GetObject("btnCerrar.Glyph"), System.Drawing.Image)
        Me.btnCerrar.Id = 1
        Me.btnCerrar.LargeGlyph = CType(resources.GetObject("btnCerrar.LargeGlyph"), System.Drawing.Image)
        Me.btnCerrar.Name = "btnCerrar"
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Caption = "Refrescar"
        Me.btnRefrescar.Glyph = CType(resources.GetObject("btnRefrescar.Glyph"), System.Drawing.Image)
        Me.btnRefrescar.Id = 2
        Me.btnRefrescar.LargeGlyph = CType(resources.GetObject("btnRefrescar.LargeGlyph"), System.Drawing.Image)
        Me.btnRefrescar.Name = "btnRefrescar"
        '
        'btnAprobar
        '
        Me.btnAprobar.Caption = "Aprobar"
        Me.btnAprobar.Glyph = CType(resources.GetObject("btnAprobar.Glyph"), System.Drawing.Image)
        Me.btnAprobar.Id = 3
        Me.btnAprobar.LargeGlyph = CType(resources.GetObject("btnAprobar.LargeGlyph"), System.Drawing.Image)
        Me.btnAprobar.Name = "btnAprobar"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Bonos Antigüedad"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAprobar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnRefrescar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 418)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(778, 31)
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GridControl1.Location = New System.Drawing.Point(0, 143)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEditTipoIdentidad, Me.RepositoryItemGridLookUpEditSexo, Me.RepositoryItemGridLookUpEditTipoDerechoHabiente, Me.RepositoryItemGridLookUpEditNacionalidad, Me.RepositoryItemGridLookUpEditDistrito, Me.RepositoryItemCheckEditTregistro, Me.RepositoryItemCheckEditEssalud, Me.RepositoryItemCheckEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(778, 275)
        Me.GridControl1.TabIndex = 13
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: [#image] {1} {2}"
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", Nothing, "(Count={0})")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemGridLookUpEditTipoIdentidad
        '
        Me.RepositoryItemGridLookUpEditTipoIdentidad.AutoHeight = False
        Me.RepositoryItemGridLookUpEditTipoIdentidad.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEditTipoIdentidad.Name = "RepositoryItemGridLookUpEditTipoIdentidad"
        Me.RepositoryItemGridLookUpEditTipoIdentidad.View = Me.GridViewTipoIdentidad
        '
        'GridViewTipoIdentidad
        '
        Me.GridViewTipoIdentidad.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewTipoIdentidad.Name = "GridViewTipoIdentidad"
        Me.GridViewTipoIdentidad.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewTipoIdentidad.OptionsView.ShowAutoFilterRow = True
        Me.GridViewTipoIdentidad.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemGridLookUpEditSexo
        '
        Me.RepositoryItemGridLookUpEditSexo.AutoHeight = False
        Me.RepositoryItemGridLookUpEditSexo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEditSexo.Name = "RepositoryItemGridLookUpEditSexo"
        Me.RepositoryItemGridLookUpEditSexo.View = Me.GridViewSexo
        '
        'GridViewSexo
        '
        Me.GridViewSexo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewSexo.Name = "GridViewSexo"
        Me.GridViewSexo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewSexo.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemGridLookUpEditTipoDerechoHabiente
        '
        Me.RepositoryItemGridLookUpEditTipoDerechoHabiente.AutoHeight = False
        Me.RepositoryItemGridLookUpEditTipoDerechoHabiente.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEditTipoDerechoHabiente.Name = "RepositoryItemGridLookUpEditTipoDerechoHabiente"
        Me.RepositoryItemGridLookUpEditTipoDerechoHabiente.View = Me.GridViewTipoDerechoHabiente
        '
        'GridViewTipoDerechoHabiente
        '
        Me.GridViewTipoDerechoHabiente.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewTipoDerechoHabiente.Name = "GridViewTipoDerechoHabiente"
        Me.GridViewTipoDerechoHabiente.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewTipoDerechoHabiente.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemGridLookUpEditNacionalidad
        '
        Me.RepositoryItemGridLookUpEditNacionalidad.AutoHeight = False
        Me.RepositoryItemGridLookUpEditNacionalidad.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEditNacionalidad.Name = "RepositoryItemGridLookUpEditNacionalidad"
        Me.RepositoryItemGridLookUpEditNacionalidad.View = Me.GridViewOriginario
        '
        'GridViewOriginario
        '
        Me.GridViewOriginario.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewOriginario.Name = "GridViewOriginario"
        Me.GridViewOriginario.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewOriginario.OptionsView.ShowAutoFilterRow = True
        Me.GridViewOriginario.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemGridLookUpEditDistrito
        '
        Me.RepositoryItemGridLookUpEditDistrito.AutoHeight = False
        Me.RepositoryItemGridLookUpEditDistrito.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEditDistrito.Name = "RepositoryItemGridLookUpEditDistrito"
        Me.RepositoryItemGridLookUpEditDistrito.View = Me.GridViewDistrito
        '
        'GridViewDistrito
        '
        Me.GridViewDistrito.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewDistrito.Name = "GridViewDistrito"
        Me.GridViewDistrito.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewDistrito.OptionsView.ShowAutoFilterRow = True
        Me.GridViewDistrito.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEditTregistro
        '
        Me.RepositoryItemCheckEditTregistro.AutoHeight = False
        Me.RepositoryItemCheckEditTregistro.Name = "RepositoryItemCheckEditTregistro"
        '
        'RepositoryItemCheckEditEssalud
        '
        Me.RepositoryItemCheckEditEssalud.AutoHeight = False
        Me.RepositoryItemCheckEditEssalud.Name = "RepositoryItemCheckEditEssalud"
        '
        'BonoAntiguedadList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 449)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "BonoAntiguedadList"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "LISTADO DE BONOS POR ANTIGÜEDAD"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditTipoIdentidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewTipoIdentidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditSexo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSexo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditTipoDerechoHabiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewTipoDerechoHabiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditNacionalidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewOriginario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditDistrito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewDistrito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEditTregistro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEditEssalud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRefrescar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAprobar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEditTipoIdentidad As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewTipoIdentidad As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEditSexo As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewSexo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEditTipoDerechoHabiente As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewTipoDerechoHabiente As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEditNacionalidad As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewOriginario As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEditDistrito As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewDistrito As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEditTregistro As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEditEssalud As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
