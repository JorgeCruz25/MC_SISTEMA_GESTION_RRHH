Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MEDesktop
    Inherits RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MEDesktop))
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnFuenteReclutamiento = New DevExpress.XtraBars.BarButtonItem()
        Me.btnConclusion = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEstadoPostulante = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUsuario = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMasivos = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNoMasivos = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEstadoCondicionActual = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEmisiones = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSalirSistema = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFuente = New DevExpress.XtraBars.BarButtonItem()
        Me.rgbiSkins = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.btnVersion = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSistema = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPostulantesMasivosAsignados = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage5 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.btnTipoCambio = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.btncentroscosto = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAdmision = New DevExpress.XtraBars.BarButtonItem()
        Me.btnVentas = New DevExpress.XtraBars.BarButtonItem()
        Me.btnHistoriaClinica = New DevExpress.XtraBars.BarButtonItem()
        Me.iHelp = New DevExpress.XtraBars.BarButtonItem()
        Me.formatRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl
        '
        Me.ribbonControl.ApplicationButtonText = Nothing
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.btnFuenteReclutamiento, Me.btnConclusion, Me.btnEstadoPostulante, Me.btnUsuario, Me.btnMasivos, Me.btnNoMasivos, Me.btnEstadoCondicionActual, Me.btnEmisiones, Me.btnSalirSistema, Me.btnFuente, Me.rgbiSkins, Me.btnVersion, Me.btnSistema, Me.btnPostulantesMasivosAsignados})
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 22
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage5})
        Me.ribbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemGridLookUpEdit3})
        Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show
        Me.ribbonControl.ShowToolbarCustomizeItem = False
        Me.ribbonControl.Size = New System.Drawing.Size(791, 143)
        Me.ribbonControl.StatusBar = Me.ribbonStatusBar
        Me.ribbonControl.Toolbar.ShowCustomizeItem = False
        '
        'btnFuenteReclutamiento
        '
        Me.btnFuenteReclutamiento.Caption = "Fuente de Reclutamiento"
        Me.btnFuenteReclutamiento.Glyph = CType(resources.GetObject("btnFuenteReclutamiento.Glyph"), System.Drawing.Image)
        Me.btnFuenteReclutamiento.Id = 2
        Me.btnFuenteReclutamiento.LargeGlyph = CType(resources.GetObject("btnFuenteReclutamiento.LargeGlyph"), System.Drawing.Image)
        Me.btnFuenteReclutamiento.Name = "btnFuenteReclutamiento"
        '
        'btnConclusion
        '
        Me.btnConclusion.Caption = "Conclusión"
        Me.btnConclusion.Glyph = CType(resources.GetObject("btnConclusion.Glyph"), System.Drawing.Image)
        Me.btnConclusion.Id = 3
        Me.btnConclusion.LargeGlyph = CType(resources.GetObject("btnConclusion.LargeGlyph"), System.Drawing.Image)
        Me.btnConclusion.Name = "btnConclusion"
        '
        'btnEstadoPostulante
        '
        Me.btnEstadoPostulante.Caption = "Estado de Postulante"
        Me.btnEstadoPostulante.Glyph = CType(resources.GetObject("btnEstadoPostulante.Glyph"), System.Drawing.Image)
        Me.btnEstadoPostulante.Id = 4
        Me.btnEstadoPostulante.LargeGlyph = CType(resources.GetObject("btnEstadoPostulante.LargeGlyph"), System.Drawing.Image)
        Me.btnEstadoPostulante.Name = "btnEstadoPostulante"
        '
        'btnUsuario
        '
        Me.btnUsuario.Caption = "Usuario"
        Me.btnUsuario.Glyph = CType(resources.GetObject("btnUsuario.Glyph"), System.Drawing.Image)
        Me.btnUsuario.Id = 6
        Me.btnUsuario.Name = "btnUsuario"
        '
        'btnMasivos
        '
        Me.btnMasivos.Caption = "Requerimientos Masivos"
        Me.btnMasivos.Glyph = CType(resources.GetObject("btnMasivos.Glyph"), System.Drawing.Image)
        Me.btnMasivos.Id = 8
        Me.btnMasivos.LargeGlyph = CType(resources.GetObject("btnMasivos.LargeGlyph"), System.Drawing.Image)
        Me.btnMasivos.Name = "btnMasivos"
        '
        'btnNoMasivos
        '
        Me.btnNoMasivos.Caption = "Requerimientos No Masivos"
        Me.btnNoMasivos.Glyph = CType(resources.GetObject("btnNoMasivos.Glyph"), System.Drawing.Image)
        Me.btnNoMasivos.Id = 9
        Me.btnNoMasivos.LargeGlyph = CType(resources.GetObject("btnNoMasivos.LargeGlyph"), System.Drawing.Image)
        Me.btnNoMasivos.Name = "btnNoMasivos"
        '
        'btnEstadoCondicionActual
        '
        Me.btnEstadoCondicionActual.Caption = "Estado Condición Actual"
        Me.btnEstadoCondicionActual.Glyph = CType(resources.GetObject("btnEstadoCondicionActual.Glyph"), System.Drawing.Image)
        Me.btnEstadoCondicionActual.Id = 10
        Me.btnEstadoCondicionActual.LargeGlyph = CType(resources.GetObject("btnEstadoCondicionActual.LargeGlyph"), System.Drawing.Image)
        Me.btnEstadoCondicionActual.Name = "btnEstadoCondicionActual"
        '
        'btnEmisiones
        '
        Me.btnEmisiones.Caption = "Emisiones"
        Me.btnEmisiones.Glyph = CType(resources.GetObject("btnEmisiones.Glyph"), System.Drawing.Image)
        Me.btnEmisiones.Id = 12
        Me.btnEmisiones.LargeGlyph = CType(resources.GetObject("btnEmisiones.LargeGlyph"), System.Drawing.Image)
        Me.btnEmisiones.Name = "btnEmisiones"
        '
        'btnSalirSistema
        '
        Me.btnSalirSistema.Caption = "Salir del Sistema"
        Me.btnSalirSistema.Glyph = CType(resources.GetObject("btnSalirSistema.Glyph"), System.Drawing.Image)
        Me.btnSalirSistema.Id = 14
        Me.btnSalirSistema.LargeGlyph = CType(resources.GetObject("btnSalirSistema.LargeGlyph"), System.Drawing.Image)
        Me.btnSalirSistema.Name = "btnSalirSistema"
        '
        'btnFuente
        '
        Me.btnFuente.Caption = "Fuente"
        Me.btnFuente.Glyph = CType(resources.GetObject("btnFuente.Glyph"), System.Drawing.Image)
        Me.btnFuente.Id = 16
        Me.btnFuente.LargeGlyph = CType(resources.GetObject("btnFuente.LargeGlyph"), System.Drawing.Image)
        Me.btnFuente.Name = "btnFuente"
        '
        'rgbiSkins
        '
        Me.rgbiSkins.Caption = "SkinRibbonGalleryBarItem1"
        Me.rgbiSkins.Id = 17
        Me.rgbiSkins.Name = "rgbiSkins"
        '
        'btnVersion
        '
        Me.btnVersion.Caption = "Version"
        Me.btnVersion.Glyph = CType(resources.GetObject("btnVersion.Glyph"), System.Drawing.Image)
        Me.btnVersion.Id = 19
        Me.btnVersion.LargeGlyph = CType(resources.GetObject("btnVersion.LargeGlyph"), System.Drawing.Image)
        Me.btnVersion.Name = "btnVersion"
        '
        'btnSistema
        '
        Me.btnSistema.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnSistema.Caption = "MACROSCEM"
        Me.btnSistema.Id = 20
        Me.btnSistema.Name = "btnSistema"
        '
        'btnPostulantesMasivosAsignados
        '
        Me.btnPostulantesMasivosAsignados.Caption = "Postulantes Masivos Asignados"
        Me.btnPostulantesMasivosAsignados.Glyph = CType(resources.GetObject("btnPostulantesMasivosAsignados.Glyph"), System.Drawing.Image)
        Me.btnPostulantesMasivosAsignados.Id = 21
        Me.btnPostulantesMasivosAsignados.LargeGlyph = CType(resources.GetObject("btnPostulantesMasivosAsignados.LargeGlyph"), System.Drawing.Image)
        Me.btnPostulantesMasivosAsignados.Name = "btnPostulantesMasivosAsignados"
        '
        'RibbonPage5
        '
        Me.RibbonPage5.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup6})
        Me.RibbonPage5.Name = "RibbonPage5"
        Me.RibbonPage5.Text = "Sistema"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btnSalirSistema)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.rgbiSkins)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btnFuente)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.Text = "Opciones"
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.NullText = "(All)"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "IDEMPLEADO"
        Me.GridColumn1.FieldName = "IDEMPLEADO"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "SUPERVISOR"
        Me.GridColumn2.FieldName = "SUPERVISOR"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'RepositoryItemGridLookUpEdit3
        '
        Me.RepositoryItemGridLookUpEdit3.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit3.Name = "RepositoryItemGridLookUpEdit3"
        Me.RepositoryItemGridLookUpEdit3.NullText = "(All)"
        Me.RepositoryItemGridLookUpEdit3.View = Me.RepositoryItemGridLookUpEdit3View
        '
        'RepositoryItemGridLookUpEdit3View
        '
        Me.RepositoryItemGridLookUpEdit3View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4})
        Me.RepositoryItemGridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit3View.Name = "RepositoryItemGridLookUpEdit3View"
        Me.RepositoryItemGridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit3View.OptionsView.ShowAutoFilterRow = True
        Me.RepositoryItemGridLookUpEdit3View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "IDPRODUCTO"
        Me.GridColumn3.FieldName = "IDPRODUCTO"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "PRODUCTO"
        Me.GridColumn4.FieldName = "PRODUCTO"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        '
        'ribbonStatusBar
        '
        Me.ribbonStatusBar.ItemLinks.Add(Me.btnVersion)
        Me.ribbonStatusBar.ItemLinks.Add(Me.btnUsuario)
        Me.ribbonStatusBar.ItemLinks.Add(Me.btnSistema)
        Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 494)
        Me.ribbonStatusBar.Name = "ribbonStatusBar"
        Me.ribbonStatusBar.Ribbon = Me.ribbonControl
        Me.ribbonStatusBar.Size = New System.Drawing.Size(791, 31)
        '
        'btnTipoCambio
        '
        Me.btnTipoCambio.Id = -1
        Me.btnTipoCambio.Name = "btnTipoCambio"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Skins"
        '
        'btncentroscosto
        '
        Me.btncentroscosto.Caption = "Centros de Costo"
        Me.btncentroscosto.Id = 67
        Me.btncentroscosto.Name = "btncentroscosto"
        '
        'btnAdmision
        '
        Me.btnAdmision.Caption = "Admisión"
        Me.btnAdmision.Description = "Panel Central de Información"
        Me.btnAdmision.Hint = "Creates a new, blank file"
        Me.btnAdmision.Id = 1
        Me.btnAdmision.ImageIndex = 0
        Me.btnAdmision.LargeImageIndex = 10
        Me.btnAdmision.Name = "btnAdmision"
        '
        'btnVentas
        '
        Me.btnVentas.Caption = "&Ventas"
        Me.btnVentas.Description = "Saves the active document."
        Me.btnVentas.Hint = "Saves the active document"
        Me.btnVentas.Id = 16
        Me.btnVentas.ImageIndex = 4
        Me.btnVentas.LargeImageIndex = 9
        Me.btnVentas.Name = "btnVentas"
        '
        'btnHistoriaClinica
        '
        Me.btnHistoriaClinica.Caption = "&Historia Clínica"
        Me.btnHistoriaClinica.Description = "Saves the active document in a different location."
        Me.btnHistoriaClinica.Hint = "Saves the active document in a different location"
        Me.btnHistoriaClinica.Id = 17
        Me.btnHistoriaClinica.ImageIndex = 5
        Me.btnHistoriaClinica.LargeImageIndex = 11
        Me.btnHistoriaClinica.Name = "btnHistoriaClinica"
        '
        'iHelp
        '
        Me.iHelp.Caption = "Help"
        Me.iHelp.Description = "Start the program help system."
        Me.iHelp.Hint = "Start the program help system"
        Me.iHelp.Id = 22
        Me.iHelp.ImageIndex = 7
        Me.iHelp.LargeImageIndex = 7
        Me.iHelp.Name = "iHelp"
        '
        'formatRibbonPageGroup
        '
        Me.formatRibbonPageGroup.Name = "formatRibbonPageGroup"
        Me.formatRibbonPageGroup.Text = "Opciones"
        '
        'MEDesktop
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 525)
        Me.Controls.Add(Me.ribbonStatusBar)
        Me.Controls.Add(Me.ribbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MEDesktop"
        Me.Ribbon = Me.ribbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.ribbonStatusBar
        Me.Text = "SISTEMA DE GESTIÓN DE RRHH"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Private WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btncentroscosto As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnAdmision As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnVentas As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnHistoriaClinica As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iHelp As DevExpress.XtraBars.BarButtonItem
    Private WithEvents formatRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnTipoCambio As DevExpress.XtraBars.BarButtonItem
    Private WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnFuenteReclutamiento As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnConclusion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEstadoPostulante As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUsuario As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMasivos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNoMasivos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEstadoCondicionActual As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEmisiones As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage5 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnSalirSistema As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFuente As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents rgbiSkins As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents btnVersion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSistema As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPostulantesMasivosAsignados As BarButtonItem
End Class
