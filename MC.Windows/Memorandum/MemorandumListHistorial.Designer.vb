<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemorandumListHistorial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MemorandumListHistorial))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnFechaInicial = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.btnFechaFinal = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.btnRefrescar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExportar = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.FORMATOINFORME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemFormatoInforme = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.FORMATOMEMORANDUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemFormatoMemorandum = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.MEMORANDUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemorandumArchivo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.DESCARGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDescargoArchivo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.NOTARIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemNotarialArchivo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemFormatoInforme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemFormatoMemorandum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemorandumArchivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDescargoArchivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemNotarialArchivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnFechaInicial, Me.btnFechaFinal, Me.btnRefrescar, Me.btnCerrar, Me.btnExportar})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 6
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2})
        Me.RibbonControl.Size = New System.Drawing.Size(887, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnFechaInicial
        '
        Me.btnFechaInicial.Caption = "Desde "
        Me.btnFechaInicial.Edit = Me.RepositoryItemDateEdit1
        Me.btnFechaInicial.Id = 1
        Me.btnFechaInicial.Name = "btnFechaInicial"
        Me.btnFechaInicial.Width = 120
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'btnFechaFinal
        '
        Me.btnFechaFinal.Caption = "Hasta  "
        Me.btnFechaFinal.Edit = Me.RepositoryItemDateEdit2
        Me.btnFechaFinal.Id = 2
        Me.btnFechaFinal.Name = "btnFechaFinal"
        Me.btnFechaFinal.Width = 120
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Caption = "Refrescar"
        Me.btnRefrescar.Glyph = CType(resources.GetObject("btnRefrescar.Glyph"), System.Drawing.Image)
        Me.btnRefrescar.Id = 3
        Me.btnRefrescar.LargeGlyph = CType(resources.GetObject("btnRefrescar.LargeGlyph"), System.Drawing.Image)
        Me.btnRefrescar.Name = "btnRefrescar"
        '
        'btnCerrar
        '
        Me.btnCerrar.Caption = "Cerrar"
        Me.btnCerrar.Glyph = CType(resources.GetObject("btnCerrar.Glyph"), System.Drawing.Image)
        Me.btnCerrar.Id = 4
        Me.btnCerrar.LargeGlyph = CType(resources.GetObject("btnCerrar.LargeGlyph"), System.Drawing.Image)
        Me.btnCerrar.Name = "btnCerrar"
        '
        'btnExportar
        '
        Me.btnExportar.Caption = "Exportar"
        Me.btnExportar.Glyph = CType(resources.GetObject("btnExportar.Glyph"), System.Drawing.Image)
        Me.btnExportar.Id = 5
        Me.btnExportar.LargeGlyph = CType(resources.GetObject("btnExportar.LargeGlyph"), System.Drawing.Image)
        Me.btnExportar.Name = "btnExportar"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Memorandums"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnFechaInicial)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnFechaFinal)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Filtro x Fechas de Solicitud"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnRefrescar)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnExportar)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnCerrar, True)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Formulario"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 462)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(887, 31)
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
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemorandumArchivo, Me.RepositoryItemDescargoArchivo, Me.RepositoryItemFormatoMemorandum, Me.RepositoryItemFormatoInforme, Me.RepositoryItemNotarialArchivo})
        Me.GridControl1.Size = New System.Drawing.Size(887, 319)
        Me.GridControl1.TabIndex = 11
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.FORMATOINFORME, Me.FORMATOMEMORANDUM, Me.MEMORANDUM, Me.DESCARGO, Me.NOTARIA})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: [#image] {1} {2}"
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", Nothing, "(Count={0})")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        '
        'FORMATOINFORME
        '
        Me.FORMATOINFORME.Caption = "FORMATO INFORME"
        Me.FORMATOINFORME.ColumnEdit = Me.RepositoryItemFormatoInforme
        Me.FORMATOINFORME.FieldName = "FORMATOINFORME"
        Me.FORMATOINFORME.Name = "FORMATOINFORME"
        Me.FORMATOINFORME.Visible = True
        Me.FORMATOINFORME.VisibleIndex = 0
        Me.FORMATOINFORME.Width = 111
        '
        'RepositoryItemFormatoInforme
        '
        Me.RepositoryItemFormatoInforme.AutoHeight = False
        Me.RepositoryItemFormatoInforme.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemFormatoInforme.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.RepositoryItemFormatoInforme.Name = "RepositoryItemFormatoInforme"
        Me.RepositoryItemFormatoInforme.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'FORMATOMEMORANDUM
        '
        Me.FORMATOMEMORANDUM.Caption = "FORMATO MEMORANDUM"
        Me.FORMATOMEMORANDUM.ColumnEdit = Me.RepositoryItemFormatoMemorandum
        Me.FORMATOMEMORANDUM.FieldName = "FORMATOMEMORANDUM"
        Me.FORMATOMEMORANDUM.Name = "FORMATOMEMORANDUM"
        Me.FORMATOMEMORANDUM.Visible = True
        Me.FORMATOMEMORANDUM.VisibleIndex = 1
        Me.FORMATOMEMORANDUM.Width = 136
        '
        'RepositoryItemFormatoMemorandum
        '
        Me.RepositoryItemFormatoMemorandum.AutoHeight = False
        Me.RepositoryItemFormatoMemorandum.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemFormatoMemorandum.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.RepositoryItemFormatoMemorandum.Name = "RepositoryItemFormatoMemorandum"
        Me.RepositoryItemFormatoMemorandum.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'MEMORANDUM
        '
        Me.MEMORANDUM.Caption = "ADJUNTO MEMORANDUM"
        Me.MEMORANDUM.ColumnEdit = Me.RepositoryItemMemorandumArchivo
        Me.MEMORANDUM.FieldName = "MEMORANDUM"
        Me.MEMORANDUM.MinWidth = 15
        Me.MEMORANDUM.Name = "MEMORANDUM"
        Me.MEMORANDUM.Visible = True
        Me.MEMORANDUM.VisibleIndex = 2
        Me.MEMORANDUM.Width = 147
        '
        'RepositoryItemMemorandumArchivo
        '
        Me.RepositoryItemMemorandumArchivo.AutoHeight = False
        Me.RepositoryItemMemorandumArchivo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemMemorandumArchivo.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.RepositoryItemMemorandumArchivo.Name = "RepositoryItemMemorandumArchivo"
        Me.RepositoryItemMemorandumArchivo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'DESCARGO
        '
        Me.DESCARGO.Caption = "ADJUNTO DESCARGO"
        Me.DESCARGO.ColumnEdit = Me.RepositoryItemDescargoArchivo
        Me.DESCARGO.FieldName = "DESCARGO"
        Me.DESCARGO.Name = "DESCARGO"
        Me.DESCARGO.Visible = True
        Me.DESCARGO.VisibleIndex = 3
        Me.DESCARGO.Width = 118
        '
        'RepositoryItemDescargoArchivo
        '
        Me.RepositoryItemDescargoArchivo.AutoHeight = False
        Me.RepositoryItemDescargoArchivo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemDescargoArchivo.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.RepositoryItemDescargoArchivo.Name = "RepositoryItemDescargoArchivo"
        Me.RepositoryItemDescargoArchivo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'NOTARIA
        '
        Me.NOTARIA.Caption = "ADJUNTO NOTARIA"
        Me.NOTARIA.ColumnEdit = Me.RepositoryItemNotarialArchivo
        Me.NOTARIA.FieldName = "NOTARIA"
        Me.NOTARIA.Name = "NOTARIA"
        Me.NOTARIA.Visible = True
        Me.NOTARIA.VisibleIndex = 4
        Me.NOTARIA.Width = 108
        '
        'RepositoryItemNotarialArchivo
        '
        Me.RepositoryItemNotarialArchivo.AutoHeight = False
        Me.RepositoryItemNotarialArchivo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemNotarialArchivo.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, "", Nothing, Nothing, True)})
        Me.RepositoryItemNotarialArchivo.Name = "RepositoryItemNotarialArchivo"
        Me.RepositoryItemNotarialArchivo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'MemorandumListHistorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 493)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "MemorandumListHistorial"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "HISTORIAL DE MEMORANDUMS"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemFormatoInforme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemFormatoMemorandum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemorandumArchivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDescargoArchivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemNotarialArchivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnFechaInicial As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnFechaFinal As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnRefrescar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MEMORANDUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemorandumArchivo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents DESCARGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDescargoArchivo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btnExportar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents FORMATOINFORME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemFormatoInforme As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents FORMATOMEMORANDUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemFormatoMemorandum As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents NOTARIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemNotarialArchivo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
