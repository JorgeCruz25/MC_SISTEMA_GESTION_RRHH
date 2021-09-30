<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsignarDerechoHabiente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AsignarDerechoHabiente))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnGrabar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.rboAsignacionNo = New System.Windows.Forms.RadioButton()
        Me.rboAsignacionSi = New System.Windows.Forms.RadioButton()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibbonControl.Size = New System.Drawing.Size(409, 143)
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
        Me.RibbonPage1.Text = "Derecho Habiente"
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
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 239)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(409, 31)
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(14, 158)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "Asignación Familiar"
        '
        'rboAsignacionNo
        '
        Me.rboAsignacionNo.AutoSize = True
        Me.rboAsignacionNo.Location = New System.Drawing.Point(177, 158)
        Me.rboAsignacionNo.Name = "rboAsignacionNo"
        Me.rboAsignacionNo.Size = New System.Drawing.Size(38, 17)
        Me.rboAsignacionNo.TabIndex = 6
        Me.rboAsignacionNo.TabStop = True
        Me.rboAsignacionNo.Text = "No"
        Me.rboAsignacionNo.UseVisualStyleBackColor = True
        '
        'rboAsignacionSi
        '
        Me.rboAsignacionSi.AutoSize = True
        Me.rboAsignacionSi.Location = New System.Drawing.Point(116, 156)
        Me.rboAsignacionSi.Name = "rboAsignacionSi"
        Me.rboAsignacionSi.Size = New System.Drawing.Size(33, 17)
        Me.rboAsignacionSi.TabIndex = 5
        Me.rboAsignacionSi.TabStop = True
        Me.rboAsignacionSi.Text = "Si"
        Me.rboAsignacionSi.UseVisualStyleBackColor = True
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'AsignarDerechoHabiente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 270)
        Me.Controls.Add(Me.rboAsignacionNo)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.rboAsignacionSi)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "AsignarDerechoHabiente"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Asignar Derecho Habiente"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnGrabar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rboAsignacionNo As RadioButton
    Friend WithEvents rboAsignacionSi As RadioButton
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
End Class
