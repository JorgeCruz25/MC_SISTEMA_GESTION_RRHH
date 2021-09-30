<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MemorandumAnular
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MemorandumAnular))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAdjuntar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.txtDescargo = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Eliminar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemEliminarArchivo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.Archivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEditArchivo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemEliminarArchivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEditArchivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnGuardar, Me.btnAdjuntar, Me.btnCerrar})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 5
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(600, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnGuardar
        '
        Me.btnGuardar.Caption = "Guardar"
        Me.btnGuardar.Glyph = CType(resources.GetObject("btnGuardar.Glyph"), System.Drawing.Image)
        Me.btnGuardar.Id = 1
        Me.btnGuardar.LargeGlyph = CType(resources.GetObject("btnGuardar.LargeGlyph"), System.Drawing.Image)
        Me.btnGuardar.Name = "btnGuardar"
        '
        'btnAdjuntar
        '
        Me.btnAdjuntar.Caption = "Adjuntar Descargo"
        Me.btnAdjuntar.Glyph = CType(resources.GetObject("btnAdjuntar.Glyph"), System.Drawing.Image)
        Me.btnAdjuntar.Id = 2
        Me.btnAdjuntar.LargeGlyph = CType(resources.GetObject("btnAdjuntar.LargeGlyph"), System.Drawing.Image)
        Me.btnAdjuntar.Name = "btnAdjuntar"
        '
        'btnCerrar
        '
        Me.btnCerrar.Caption = "Cerrar"
        Me.btnCerrar.Glyph = CType(resources.GetObject("btnCerrar.Glyph"), System.Drawing.Image)
        Me.btnCerrar.Id = 4
        Me.btnCerrar.LargeGlyph = CType(resources.GetObject("btnCerrar.LargeGlyph"), System.Drawing.Image)
        Me.btnCerrar.Name = "btnCerrar"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Detalle Memorandum"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnGuardar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAdjuntar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 326)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(600, 31)
        '
        'txtDescargo
        '
        Me.txtDescargo.Location = New System.Drawing.Point(131, 163)
        Me.txtDescargo.MenuManager = Me.RibbonControl
        Me.txtDescargo.Name = "txtDescargo"
        Me.txtDescargo.Size = New System.Drawing.Size(464, 56)
        Me.txtDescargo.TabIndex = 55
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(7, 175)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(103, 13)
        Me.LabelControl1.TabIndex = 54
        Me.LabelControl1.Text = "Descripción Anulación"
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(0, 225)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEditArchivo, Me.RepositoryItemEliminarArchivo})
        Me.GridControl1.Size = New System.Drawing.Size(595, 100)
        Me.GridControl1.TabIndex = 71
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Eliminar, Me.Archivo})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(629, 365, 210, 172)
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'Eliminar
        '
        Me.Eliminar.Caption = "Eliminar"
        Me.Eliminar.ColumnEdit = Me.RepositoryItemEliminarArchivo
        Me.Eliminar.ImageAlignment = System.Drawing.StringAlignment.Center
        Me.Eliminar.MinWidth = 15
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Visible = True
        Me.Eliminar.VisibleIndex = 1
        Me.Eliminar.Width = 80
        '
        'RepositoryItemEliminarArchivo
        '
        Me.RepositoryItemEliminarArchivo.AutoHeight = False
        Me.RepositoryItemEliminarArchivo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemEliminarArchivo.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.RepositoryItemEliminarArchivo.Name = "RepositoryItemEliminarArchivo"
        Me.RepositoryItemEliminarArchivo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'Archivo
        '
        Me.Archivo.Caption = "Archivo"
        Me.Archivo.ColumnEdit = Me.RepositoryItemButtonEditArchivo
        Me.Archivo.ImageAlignment = System.Drawing.StringAlignment.Center
        Me.Archivo.MinWidth = 15
        Me.Archivo.Name = "Archivo"
        Me.Archivo.Visible = True
        Me.Archivo.VisibleIndex = 0
        Me.Archivo.Width = 80
        '
        'RepositoryItemButtonEditArchivo
        '
        Me.RepositoryItemButtonEditArchivo.AutoHeight = False
        Me.RepositoryItemButtonEditArchivo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemButtonEditArchivo.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.RepositoryItemButtonEditArchivo.Name = "RepositoryItemButtonEditArchivo"
        Me.RepositoryItemButtonEditArchivo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'MemorandumAnular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 357)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.txtDescargo)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "MemorandumAnular"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "ANULAR MEMORANDUM"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemEliminarArchivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEditArchivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAdjuntar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtDescargo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Archivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEditArchivo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents Eliminar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemEliminarArchivo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
End Class
