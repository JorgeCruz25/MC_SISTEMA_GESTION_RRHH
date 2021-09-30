<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PeriodoRenovacionDetails
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PeriodoRenovacionDetails))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAgregar = New DevExpress.XtraBars.BarButtonItem()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.sleTipoPeriodo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridViewTipoPeriodo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.deFechaDesde = New DevExpress.XtraEditors.DateEdit()
        Me.deFechaHasta = New DevExpress.XtraEditors.DateEdit()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sleTipoPeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewTipoPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnCerrar, Me.btnAgregar})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 3
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(375, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Asignar Periodo"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAgregar)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 255)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(375, 31)
        '
        'btnCerrar
        '
        Me.btnCerrar.Caption = "Cerrar"
        Me.btnCerrar.Glyph = CType(resources.GetObject("btnCerrar.Glyph"), System.Drawing.Image)
        Me.btnCerrar.Id = 1
        Me.btnCerrar.LargeGlyph = CType(resources.GetObject("btnCerrar.LargeGlyph"), System.Drawing.Image)
        Me.btnCerrar.Name = "btnCerrar"
        '
        'btnAgregar
        '
        Me.btnAgregar.Caption = "Agregar"
        Me.btnAgregar.Glyph = CType(resources.GetObject("btnAgregar.Glyph"), System.Drawing.Image)
        Me.btnAgregar.Id = 2
        Me.btnAgregar.LargeGlyph = CType(resources.GetObject("btnAgregar.LargeGlyph"), System.Drawing.Image)
        Me.btnAgregar.Name = "btnAgregar"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(27, 193)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Periodo Desde"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(27, 226)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Periodo Hasta"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(27, 162)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Tipo Periodo"
        '
        'sleTipoPeriodo
        '
        Me.sleTipoPeriodo.Location = New System.Drawing.Point(104, 159)
        Me.sleTipoPeriodo.MenuManager = Me.RibbonControl
        Me.sleTipoPeriodo.Name = "sleTipoPeriodo"
        Me.sleTipoPeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sleTipoPeriodo.Properties.View = Me.GridViewTipoPeriodo
        Me.sleTipoPeriodo.Size = New System.Drawing.Size(153, 20)
        Me.sleTipoPeriodo.TabIndex = 53
        '
        'GridViewTipoPeriodo
        '
        Me.GridViewTipoPeriodo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewTipoPeriodo.Name = "GridViewTipoPeriodo"
        Me.GridViewTipoPeriodo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewTipoPeriodo.OptionsView.ShowAutoFilterRow = True
        Me.GridViewTipoPeriodo.OptionsView.ShowGroupPanel = False
        '
        'deFechaDesde
        '
        Me.deFechaDesde.EditValue = Nothing
        Me.deFechaDesde.Location = New System.Drawing.Point(104, 190)
        Me.deFechaDesde.MenuManager = Me.RibbonControl
        Me.deFechaDesde.Name = "deFechaDesde"
        Me.deFechaDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaDesde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaDesde.Size = New System.Drawing.Size(153, 20)
        Me.deFechaDesde.TabIndex = 54
        '
        'deFechaHasta
        '
        Me.deFechaHasta.EditValue = Nothing
        Me.deFechaHasta.Location = New System.Drawing.Point(104, 219)
        Me.deFechaHasta.MenuManager = Me.RibbonControl
        Me.deFechaHasta.Name = "deFechaHasta"
        Me.deFechaHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaHasta.Size = New System.Drawing.Size(153, 20)
        Me.deFechaHasta.TabIndex = 55
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'PeriodoRenovacionDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 286)
        Me.Controls.Add(Me.deFechaHasta)
        Me.Controls.Add(Me.deFechaDesde)
        Me.Controls.Add(Me.sleTipoPeriodo)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "PeriodoRenovacionDetails"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "ASIGNACIÓN PERIODO RENOVACIÓN"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sleTipoPeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewTipoPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAgregar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sleTipoPeriodo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridViewTipoPeriodo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents deFechaDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents deFechaHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
End Class
