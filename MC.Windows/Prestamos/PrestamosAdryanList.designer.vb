<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrestamosAdryanList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrestamosAdryanList))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnRegistrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRefrescar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExportar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnHistorialEmpleado = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnRegistrar, Me.btnCerrar, Me.btnRefrescar, Me.btnExportar, Me.btnHistorialEmpleado})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 6
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(707, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Caption = "Registrar"
        Me.btnRegistrar.Glyph = CType(resources.GetObject("btnRegistrar.Glyph"), System.Drawing.Image)
        Me.btnRegistrar.Id = 1
        Me.btnRegistrar.LargeGlyph = CType(resources.GetObject("btnRegistrar.LargeGlyph"), System.Drawing.Image)
        Me.btnRegistrar.Name = "btnRegistrar"
        '
        'btnCerrar
        '
        Me.btnCerrar.Caption = "Cerrar"
        Me.btnCerrar.Glyph = CType(resources.GetObject("btnCerrar.Glyph"), System.Drawing.Image)
        Me.btnCerrar.Id = 2
        Me.btnCerrar.LargeGlyph = CType(resources.GetObject("btnCerrar.LargeGlyph"), System.Drawing.Image)
        Me.btnCerrar.Name = "btnCerrar"
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Caption = "Refescar"
        Me.btnRefrescar.Glyph = CType(resources.GetObject("btnRefrescar.Glyph"), System.Drawing.Image)
        Me.btnRefrescar.Id = 3
        Me.btnRefrescar.LargeGlyph = CType(resources.GetObject("btnRefrescar.LargeGlyph"), System.Drawing.Image)
        Me.btnRefrescar.Name = "btnRefrescar"
        '
        'btnExportar
        '
        Me.btnExportar.Caption = "Exportar"
        Me.btnExportar.Glyph = CType(resources.GetObject("btnExportar.Glyph"), System.Drawing.Image)
        Me.btnExportar.Id = 4
        Me.btnExportar.LargeGlyph = CType(resources.GetObject("btnExportar.LargeGlyph"), System.Drawing.Image)
        Me.btnExportar.Name = "btnExportar"
        '
        'btnHistorialEmpleado
        '
        Me.btnHistorialEmpleado.Caption = "Historial"
        Me.btnHistorialEmpleado.Glyph = CType(resources.GetObject("btnHistorialEmpleado.Glyph"), System.Drawing.Image)
        Me.btnHistorialEmpleado.Id = 5
        Me.btnHistorialEmpleado.LargeGlyph = CType(resources.GetObject("btnHistorialEmpleado.LargeGlyph"), System.Drawing.Image)
        Me.btnHistorialEmpleado.Name = "btnHistorialEmpleado"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Prestamos Aprobados"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnRegistrar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnRefrescar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnHistorialEmpleado)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnExportar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 376)
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
        Me.GridControl1.Size = New System.Drawing.Size(707, 233)
        Me.GridControl1.TabIndex = 5
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        '
        'PrestamosAdryanList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 407)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "PrestamosAdryanList"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "PRESTAMOS APROBADOS"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnRegistrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRefrescar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnExportar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnHistorialEmpleado As DevExpress.XtraBars.BarButtonItem
End Class
