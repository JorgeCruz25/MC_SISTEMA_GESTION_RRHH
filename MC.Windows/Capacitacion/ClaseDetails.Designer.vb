<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClaseDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClaseDetails))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnGrabar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lblNumeroAula = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.sleCede = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridViewCedeCapacitacion = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dtFechaCapacitacion = New DevExpress.XtraEditors.DateEdit()
        Me.teHoraFin = New DevExpress.XtraEditors.TimeEdit()
        Me.txtNumeroAula = New DevExpress.XtraEditors.TextEdit()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.teHoraInicio = New DevExpress.XtraEditors.TimeEdit()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sleCede.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCedeCapacitacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaCapacitacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaCapacitacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teHoraFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroAula.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teHoraInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibbonControl.Size = New System.Drawing.Size(457, 143)
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
        Me.RibbonPage1.Text = "Clase"
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
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 285)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(457, 31)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 193)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Fecha Capacitación"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 223)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Hora Inicio"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 252)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Hora Fin"
        '
        'lblNumeroAula
        '
        Me.lblNumeroAula.Location = New System.Drawing.Point(280, 193)
        Me.lblNumeroAula.Name = "lblNumeroAula"
        Me.lblNumeroAula.Size = New System.Drawing.Size(61, 13)
        Me.lblNumeroAula.TabIndex = 5
        Me.lblNumeroAula.Text = "Numero Aula"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 165)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl5.TabIndex = 6
        Me.LabelControl5.Text = "Cede Capacitación"
        '
        'sleCede
        '
        Me.sleCede.Location = New System.Drawing.Point(118, 162)
        Me.sleCede.Name = "sleCede"
        Me.sleCede.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sleCede.Properties.NullText = "[Seleccione]"
        Me.sleCede.Properties.View = Me.GridViewCedeCapacitacion
        Me.sleCede.Size = New System.Drawing.Size(331, 20)
        Me.sleCede.TabIndex = 8
        '
        'GridViewCedeCapacitacion
        '
        Me.GridViewCedeCapacitacion.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewCedeCapacitacion.Name = "GridViewCedeCapacitacion"
        Me.GridViewCedeCapacitacion.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewCedeCapacitacion.OptionsView.ShowGroupPanel = False
        '
        'dtFechaCapacitacion
        '
        Me.dtFechaCapacitacion.EditValue = Nothing
        Me.dtFechaCapacitacion.Location = New System.Drawing.Point(118, 188)
        Me.dtFechaCapacitacion.MenuManager = Me.RibbonControl
        Me.dtFechaCapacitacion.Name = "dtFechaCapacitacion"
        Me.dtFechaCapacitacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaCapacitacion.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaCapacitacion.Size = New System.Drawing.Size(120, 20)
        Me.dtFechaCapacitacion.TabIndex = 9
        '
        'teHoraFin
        '
        Me.teHoraFin.EditValue = New Date(2021, 3, 27, 0, 0, 0, 0)
        Me.teHoraFin.Location = New System.Drawing.Point(118, 249)
        Me.teHoraFin.MenuManager = Me.RibbonControl
        Me.teHoraFin.Name = "teHoraFin"
        Me.teHoraFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.teHoraFin.Properties.Mask.EditMask = "t"
        Me.teHoraFin.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI
        Me.teHoraFin.Size = New System.Drawing.Size(55, 20)
        Me.teHoraFin.TabIndex = 11
        '
        'txtNumeroAula
        '
        Me.txtNumeroAula.Location = New System.Drawing.Point(349, 190)
        Me.txtNumeroAula.MenuManager = Me.RibbonControl
        Me.txtNumeroAula.Name = "txtNumeroAula"
        Me.txtNumeroAula.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroAula.TabIndex = 12
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'teHoraInicio
        '
        Me.teHoraInicio.EditValue = New Date(2021, 3, 27, 0, 0, 0, 0)
        Me.teHoraInicio.Location = New System.Drawing.Point(118, 216)
        Me.teHoraInicio.MenuManager = Me.RibbonControl
        Me.teHoraInicio.Name = "teHoraInicio"
        Me.teHoraInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.teHoraInicio.Properties.Mask.EditMask = "t"
        Me.teHoraInicio.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI
        Me.teHoraInicio.Size = New System.Drawing.Size(55, 20)
        Me.teHoraInicio.TabIndex = 15
        '
        'ClaseDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 316)
        Me.Controls.Add(Me.teHoraInicio)
        Me.Controls.Add(Me.txtNumeroAula)
        Me.Controls.Add(Me.teHoraFin)
        Me.Controls.Add(Me.dtFechaCapacitacion)
        Me.Controls.Add(Me.sleCede)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.lblNumeroAula)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "ClaseDetails"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "ClaseDetails"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sleCede.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCedeCapacitacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaCapacitacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaCapacitacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teHoraFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroAula.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teHoraInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblNumeroAula As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sleCede As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridViewCedeCapacitacion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dtFechaCapacitacion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents teHoraFin As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents txtNumeroAula As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents teHoraInicio As DevExpress.XtraEditors.TimeEdit
End Class
