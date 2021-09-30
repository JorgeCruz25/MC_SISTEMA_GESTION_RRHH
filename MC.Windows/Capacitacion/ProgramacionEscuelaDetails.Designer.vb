<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgramacionEscuelaDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProgramacionEscuelaDetails))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnGrabar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIdEscuela = New DevExpress.XtraEditors.TextEdit()
        Me.sleTipoEscuela = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridViewTipoEscuela = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtNumeroEscuela = New DevExpress.XtraEditors.TextEdit()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNota = New DevExpress.XtraEditors.TextEdit()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdEscuela.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sleTipoEscuela.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewTipoEscuela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroEscuela.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnGrabar, Me.btnCerrar})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 3
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(429, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnGrabar
        '
        Me.btnGrabar.Caption = "Grabar"
        Me.btnGrabar.Glyph = CType(resources.GetObject("btnGrabar.Glyph"), System.Drawing.Image)
        Me.btnGrabar.Id = 1
        Me.btnGrabar.LargeGlyph = CType(resources.GetObject("btnGrabar.LargeGlyph"), System.Drawing.Image)
        Me.btnGrabar.Name = "btnGrabar"
        '
        'btnCerrar
        '
        Me.btnCerrar.Caption = "Cerrar"
        Me.btnCerrar.Glyph = CType(resources.GetObject("btnCerrar.Glyph"), System.Drawing.Image)
        Me.btnCerrar.Id = 2
        Me.btnCerrar.LargeGlyph = CType(resources.GetObject("btnCerrar.LargeGlyph"), System.Drawing.Image)
        Me.btnCerrar.Name = "btnCerrar"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Programación Escuela"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnGrabar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 259)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(429, 31)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 165)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Id. Escuela"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 196)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Tipo Escuela"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 226)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Número Escuela"
        '
        'txtIdEscuela
        '
        Me.txtIdEscuela.Location = New System.Drawing.Point(100, 162)
        Me.txtIdEscuela.MenuManager = Me.RibbonControl
        Me.txtIdEscuela.Name = "txtIdEscuela"
        Me.txtIdEscuela.Size = New System.Drawing.Size(134, 20)
        Me.txtIdEscuela.TabIndex = 5
        '
        'sleTipoEscuela
        '
        Me.sleTipoEscuela.Location = New System.Drawing.Point(100, 193)
        Me.sleTipoEscuela.Name = "sleTipoEscuela"
        Me.sleTipoEscuela.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sleTipoEscuela.Properties.NullText = "[Seleccione]"
        Me.sleTipoEscuela.Properties.View = Me.GridViewTipoEscuela
        Me.sleTipoEscuela.Size = New System.Drawing.Size(319, 20)
        Me.sleTipoEscuela.TabIndex = 15
        '
        'GridViewTipoEscuela
        '
        Me.GridViewTipoEscuela.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewTipoEscuela.Name = "GridViewTipoEscuela"
        Me.GridViewTipoEscuela.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewTipoEscuela.OptionsView.ShowGroupPanel = False
        '
        'txtNumeroEscuela
        '
        Me.txtNumeroEscuela.Location = New System.Drawing.Point(100, 223)
        Me.txtNumeroEscuela.MenuManager = Me.RibbonControl
        Me.txtNumeroEscuela.Name = "txtNumeroEscuela"
        Me.txtNumeroEscuela.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtNumeroEscuela.Properties.Appearance.Options.UseForeColor = True
        Me.txtNumeroEscuela.Size = New System.Drawing.Size(134, 20)
        Me.txtNumeroEscuela.TabIndex = 16
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(251, 226)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl4.TabIndex = 19
        Me.LabelControl4.Text = "Nota Aprobatoria"
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(340, 223)
        Me.txtNota.MenuManager = Me.RibbonControl
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Properties.Mask.EditMask = "n"
        Me.txtNota.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNota.Size = New System.Drawing.Size(79, 20)
        Me.txtNota.TabIndex = 20
        '
        'ProgramacionEscuelaDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 290)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtNumeroEscuela)
        Me.Controls.Add(Me.sleTipoEscuela)
        Me.Controls.Add(Me.txtIdEscuela)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "ProgramacionEscuelaDetails"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "ProgramacionEscuelaDetails"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdEscuela.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sleTipoEscuela.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewTipoEscuela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroEscuela.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnGrabar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIdEscuela As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sleTipoEscuela As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridViewTipoEscuela As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtNumeroEscuela As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents txtNota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
End Class
