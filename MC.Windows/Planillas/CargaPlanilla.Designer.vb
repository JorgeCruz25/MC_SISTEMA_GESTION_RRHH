﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CargaPlanilla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CargaPlanilla))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNueva = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCargaMasiva = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemButtonEditArchivo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemActaCompromiso = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.btnConcepto = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRefrescar = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEditArchivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemActaCompromiso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnCerrar, Me.btnNueva, Me.btnCargaMasiva, Me.btnConcepto, Me.btnRefrescar})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 6
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(707, 143)
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
        'btnNueva
        '
        Me.btnNueva.Caption = "Nueva"
        Me.btnNueva.Glyph = CType(resources.GetObject("btnNueva.Glyph"), System.Drawing.Image)
        Me.btnNueva.Id = 2
        Me.btnNueva.LargeGlyph = CType(resources.GetObject("btnNueva.LargeGlyph"), System.Drawing.Image)
        Me.btnNueva.Name = "btnNueva"
        '
        'btnCargaMasiva
        '
        Me.btnCargaMasiva.Caption = "Carga Masiva"
        Me.btnCargaMasiva.Glyph = CType(resources.GetObject("btnCargaMasiva.Glyph"), System.Drawing.Image)
        Me.btnCargaMasiva.Id = 3
        Me.btnCargaMasiva.LargeGlyph = CType(resources.GetObject("btnCargaMasiva.LargeGlyph"), System.Drawing.Image)
        Me.btnCargaMasiva.Name = "btnCargaMasiva"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Planillas"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnNueva)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnConcepto)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCargaMasiva)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnRefrescar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 418)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(707, 31)
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 143)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEditArchivo, Me.RepositoryItemActaCompromiso})
        Me.GridControl1.Size = New System.Drawing.Size(707, 275)
        Me.GridControl1.TabIndex = 10
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(629, 365, 210, 172)
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        '
        'RepositoryItemButtonEditArchivo
        '
        Me.RepositoryItemButtonEditArchivo.AutoHeight = False
        Me.RepositoryItemButtonEditArchivo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemButtonEditArchivo.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.RepositoryItemButtonEditArchivo.Name = "RepositoryItemButtonEditArchivo"
        Me.RepositoryItemButtonEditArchivo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'RepositoryItemActaCompromiso
        '
        Me.RepositoryItemActaCompromiso.AutoHeight = False
        Me.RepositoryItemActaCompromiso.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemActaCompromiso.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.RepositoryItemActaCompromiso.Name = "RepositoryItemActaCompromiso"
        Me.RepositoryItemActaCompromiso.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'btnConcepto
        '
        Me.btnConcepto.Caption = "Concepto"
        Me.btnConcepto.Glyph = CType(resources.GetObject("btnConcepto.Glyph"), System.Drawing.Image)
        Me.btnConcepto.Id = 4
        Me.btnConcepto.LargeGlyph = CType(resources.GetObject("btnConcepto.LargeGlyph"), System.Drawing.Image)
        Me.btnConcepto.Name = "btnConcepto"
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Caption = "Refrescar"
        Me.btnRefrescar.Glyph = CType(resources.GetObject("btnRefrescar.Glyph"), System.Drawing.Image)
        Me.btnRefrescar.Id = 5
        Me.btnRefrescar.LargeGlyph = CType(resources.GetObject("btnRefrescar.LargeGlyph"), System.Drawing.Image)
        Me.btnRefrescar.Name = "btnRefrescar"
        '
        'CargaPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 449)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "CargaPlanilla"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "CargaPlanilla"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEditArchivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemActaCompromiso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNueva As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemButtonEditArchivo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemActaCompromiso As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btnCargaMasiva As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnConcepto As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRefrescar As DevExpress.XtraBars.BarButtonItem
End Class
