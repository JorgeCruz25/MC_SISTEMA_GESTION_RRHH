<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reportes))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.pnlMain = New DevExpress.XtraEditors.PanelControl()
        Me.adMenu = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.groupMasivos = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.itemRequerimientosMasivos = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.groupElementControl = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.itemCanalReclutamiento = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.itemPuestoPorCanalReclutamiento = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.itemConclusionPostulanteCanalReclutamiento = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.groupConfiguracion = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.pnlPrincipal = New DevExpress.XtraEditors.PanelControl()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnCerrar})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 2
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(865, 143)
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
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Reportes"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 528)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(865, 31)
        '
        'pnlMain
        '
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(207, 2)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(656, 381)
        Me.pnlMain.TabIndex = 5
        '
        'adMenu
        '
        Me.adMenu.Appearance.AccordionControl.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adMenu.Appearance.AccordionControl.Options.UseFont = True
        Me.adMenu.Appearance.Group.Disabled.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adMenu.Appearance.Group.Disabled.Options.UseFont = True
        Me.adMenu.Appearance.Group.Hovered.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adMenu.Appearance.Group.Hovered.Options.UseFont = True
        Me.adMenu.Appearance.Group.Normal.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adMenu.Appearance.Group.Normal.Options.UseFont = True
        Me.adMenu.Appearance.Group.Pressed.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adMenu.Appearance.Group.Pressed.Options.UseFont = True
        Me.adMenu.Appearance.Hint.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adMenu.Appearance.Hint.Options.UseFont = True
        Me.adMenu.Appearance.Item.Disabled.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adMenu.Appearance.Item.Disabled.Options.UseFont = True
        Me.adMenu.Appearance.Item.Hovered.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adMenu.Appearance.Item.Hovered.Options.UseFont = True
        Me.adMenu.Appearance.Item.Normal.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adMenu.Appearance.Item.Normal.Options.UseFont = True
        Me.adMenu.Appearance.Item.Pressed.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adMenu.Appearance.Item.Pressed.Options.UseFont = True
        Me.adMenu.Appearance.ItemWithContainer.Disabled.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adMenu.Appearance.ItemWithContainer.Disabled.Options.UseFont = True
        Me.adMenu.Appearance.ItemWithContainer.Hovered.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adMenu.Appearance.ItemWithContainer.Hovered.Options.UseFont = True
        Me.adMenu.Appearance.ItemWithContainer.Normal.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adMenu.Appearance.ItemWithContainer.Normal.Options.UseFont = True
        Me.adMenu.Appearance.ItemWithContainer.Pressed.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adMenu.Appearance.ItemWithContainer.Pressed.Options.UseFont = True
        Me.adMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.adMenu.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.groupMasivos, Me.groupConfiguracion})
        Me.adMenu.Location = New System.Drawing.Point(2, 2)
        Me.adMenu.LookAndFeel.SkinName = "Office 2013"
        Me.adMenu.LookAndFeel.UseDefaultLookAndFeel = False
        Me.adMenu.Name = "adMenu"
        Me.adMenu.Size = New System.Drawing.Size(205, 381)
        Me.adMenu.TabIndex = 8
        Me.adMenu.Text = "AccordionControl1"
        '
        'groupMasivos
        '
        Me.groupMasivos.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.itemRequerimientosMasivos, Me.groupElementControl})
        Me.groupMasivos.Expanded = True
        Me.groupMasivos.Text = "REQUERIMIENTOS MASIVOS"
        '
        'itemRequerimientosMasivos
        '
        Me.itemRequerimientosMasivos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.itemRequerimientosMasivos.Text = "Requerimientos Masivos"
        '
        'groupElementControl
        '
        Me.groupElementControl.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.itemCanalReclutamiento, Me.itemPuestoPorCanalReclutamiento, Me.itemConclusionPostulanteCanalReclutamiento})
        Me.groupElementControl.Expanded = True
        Me.groupElementControl.Text = "INDICADORES POR CANAL DE RECLUTAMIENTO"
        '
        'itemCanalReclutamiento
        '
        Me.itemCanalReclutamiento.Expanded = True
        Me.itemCanalReclutamiento.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.itemCanalReclutamiento.Text = "Canales de Reclutamiento"
        '
        'itemPuestoPorCanalReclutamiento
        '
        Me.itemPuestoPorCanalReclutamiento.Expanded = True
        Me.itemPuestoPorCanalReclutamiento.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.itemPuestoPorCanalReclutamiento.Text = "Puestos por Canal de Reclutamiento"
        '
        'itemConclusionPostulanteCanalReclutamiento
        '
        Me.itemConclusionPostulanteCanalReclutamiento.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.itemConclusionPostulanteCanalReclutamiento.Text = "Conclusión por Postulante y Canal de Reclutamiento"
        '
        'groupConfiguracion
        '
        Me.groupConfiguracion.Expanded = True
        Me.groupConfiguracion.Text = "REQUERIMIENTOS NO MASIVOS"
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Controls.Add(Me.pnlMain)
        Me.pnlPrincipal.Controls.Add(Me.adMenu)
        Me.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPrincipal.Location = New System.Drawing.Point(0, 143)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(865, 385)
        Me.pnlPrincipal.TabIndex = 9
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 559)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "Reportes"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "REPORTES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPrincipal.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents pnlMain As DevExpress.XtraEditors.PanelControl
    Friend WithEvents adMenu As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents groupMasivos As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents groupElementControl As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents itemCanalReclutamiento As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents itemPuestoPorCanalReclutamiento As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents groupConfiguracion As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents pnlPrincipal As DevExpress.XtraEditors.PanelControl
    Friend WithEvents itemRequerimientosMasivos As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents itemConclusionPostulanteCanalReclutamiento As DevExpress.XtraBars.Navigation.AccordionControlElement


End Class
