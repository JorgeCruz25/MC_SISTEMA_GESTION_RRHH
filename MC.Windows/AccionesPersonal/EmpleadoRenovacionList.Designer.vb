<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpleadoRenovacionList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmpleadoRenovacionList))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnGenerarRenovacion = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFechaInicial = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEditFechaInicial = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.btnFechaFinal = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEditFechaFinal = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.btnBuscar = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEditEstado = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEditFechaInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEditFechaInicial.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEditFechaFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEditFechaFinal.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEditEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnGenerarRenovacion, Me.btnCerrar, Me.btnFechaInicial, Me.btnFechaFinal, Me.btnBuscar})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 6
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEditFechaInicial, Me.RepositoryItemDateEditFechaFinal})
        Me.RibbonControl.Size = New System.Drawing.Size(807, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnGenerarRenovacion
        '
        Me.btnGenerarRenovacion.Caption = "Generar Contrato(s)"
        Me.btnGenerarRenovacion.Glyph = CType(resources.GetObject("btnGenerarRenovacion.Glyph"), System.Drawing.Image)
        Me.btnGenerarRenovacion.Id = 1
        Me.btnGenerarRenovacion.LargeGlyph = CType(resources.GetObject("btnGenerarRenovacion.LargeGlyph"), System.Drawing.Image)
        Me.btnGenerarRenovacion.Name = "btnGenerarRenovacion"
        '
        'btnCerrar
        '
        Me.btnCerrar.Caption = "Cerrar"
        Me.btnCerrar.Glyph = CType(resources.GetObject("btnCerrar.Glyph"), System.Drawing.Image)
        Me.btnCerrar.Id = 2
        Me.btnCerrar.LargeGlyph = CType(resources.GetObject("btnCerrar.LargeGlyph"), System.Drawing.Image)
        Me.btnCerrar.Name = "btnCerrar"
        '
        'btnFechaInicial
        '
        Me.btnFechaInicial.Caption = "Fecha Incial : "
        Me.btnFechaInicial.Edit = Me.RepositoryItemDateEditFechaInicial
        Me.btnFechaInicial.Id = 3
        Me.btnFechaInicial.Name = "btnFechaInicial"
        Me.btnFechaInicial.Width = 120
        '
        'RepositoryItemDateEditFechaInicial
        '
        Me.RepositoryItemDateEditFechaInicial.AutoHeight = False
        Me.RepositoryItemDateEditFechaInicial.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEditFechaInicial.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEditFechaInicial.Name = "RepositoryItemDateEditFechaInicial"
        '
        'btnFechaFinal
        '
        Me.btnFechaFinal.Caption = "Fecha Final :  "
        Me.btnFechaFinal.Edit = Me.RepositoryItemDateEditFechaFinal
        Me.btnFechaFinal.Id = 4
        Me.btnFechaFinal.Name = "btnFechaFinal"
        Me.btnFechaFinal.Width = 120
        '
        'RepositoryItemDateEditFechaFinal
        '
        Me.RepositoryItemDateEditFechaFinal.AutoHeight = False
        Me.RepositoryItemDateEditFechaFinal.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEditFechaFinal.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEditFechaFinal.Name = "RepositoryItemDateEditFechaFinal"
        '
        'btnBuscar
        '
        Me.btnBuscar.Caption = "Buscar"
        Me.btnBuscar.Id = 5
        Me.btnBuscar.LargeGlyph = CType(resources.GetObject("btnBuscar.LargeGlyph"), System.Drawing.Image)
        Me.btnBuscar.Name = "btnBuscar"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Renovación de Personal"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnGenerarRenovacion)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnFechaInicial)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnFechaFinal)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnBuscar)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Buscar Contratos por Vencer"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 499)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(807, 31)
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
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEditEstado})
        Me.GridControl1.Size = New System.Drawing.Size(807, 356)
        Me.GridControl1.TabIndex = 6
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: [#image] {1} {2}"
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", Nothing, "(Count={0})")})
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "RENOVAR"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemCheckEditEstado
        Me.GridColumn1.FieldName = "ESTADO"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'RepositoryItemCheckEditEstado
        '
        Me.RepositoryItemCheckEditEstado.AutoHeight = False
        Me.RepositoryItemCheckEditEstado.Name = "RepositoryItemCheckEditEstado"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "FECHA FINAL NUEVA"
        Me.GridColumn2.FieldName = "FECHAFINALCONTRATONUEVO"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 120
        '
        'EmpleadoRenovacionList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 530)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "EmpleadoRenovacionList"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "RENOVACION DE PERSONAL"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEditFechaInicial.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEditFechaInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEditFechaFinal.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEditFechaFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEditEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnGenerarRenovacion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnFechaInicial As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEditFechaInicial As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnFechaFinal As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEditFechaFinal As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEditEstado As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
