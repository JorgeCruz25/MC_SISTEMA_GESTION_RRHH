<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SolicitudAsignacionFamiliarList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SolicitudAsignacionFamiliarList))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnRefrescar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEvaluarSolicitud = New DevExpress.XtraBars.BarButtonItem()
        Me.btnIngresoDerechoHabiente = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExportarDetalleHijos = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExportarSolicitantes = New DevExpress.XtraBars.BarButtonItem()
        Me.btnHistorialEmpleado = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ADJUNTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemAsignacionFamiliarArchivo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemAsignacionFamiliarArchivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnRefrescar, Me.btnCerrar, Me.btnEvaluarSolicitud, Me.btnIngresoDerechoHabiente, Me.btnExportarDetalleHijos, Me.btnExportarSolicitantes, Me.btnHistorialEmpleado})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 8
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(701, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Caption = "Refrescar"
        Me.btnRefrescar.Glyph = CType(resources.GetObject("btnRefrescar.Glyph"), System.Drawing.Image)
        Me.btnRefrescar.Id = 1
        Me.btnRefrescar.LargeGlyph = CType(resources.GetObject("btnRefrescar.LargeGlyph"), System.Drawing.Image)
        Me.btnRefrescar.Name = "btnRefrescar"
        '
        'btnCerrar
        '
        Me.btnCerrar.Caption = "Cerrar"
        Me.btnCerrar.Glyph = CType(resources.GetObject("btnCerrar.Glyph"), System.Drawing.Image)
        Me.btnCerrar.Id = 2
        Me.btnCerrar.LargeGlyph = CType(resources.GetObject("btnCerrar.LargeGlyph"), System.Drawing.Image)
        Me.btnCerrar.Name = "btnCerrar"
        '
        'btnEvaluarSolicitud
        '
        Me.btnEvaluarSolicitud.Caption = "Evaluar Solicitud"
        Me.btnEvaluarSolicitud.Glyph = CType(resources.GetObject("btnEvaluarSolicitud.Glyph"), System.Drawing.Image)
        Me.btnEvaluarSolicitud.Id = 3
        Me.btnEvaluarSolicitud.LargeGlyph = CType(resources.GetObject("btnEvaluarSolicitud.LargeGlyph"), System.Drawing.Image)
        Me.btnEvaluarSolicitud.Name = "btnEvaluarSolicitud"
        '
        'btnIngresoDerechoHabiente
        '
        Me.btnIngresoDerechoHabiente.Caption = "Ingreso de Asignación Familiar"
        Me.btnIngresoDerechoHabiente.Glyph = CType(resources.GetObject("btnIngresoDerechoHabiente.Glyph"), System.Drawing.Image)
        Me.btnIngresoDerechoHabiente.Id = 4
        Me.btnIngresoDerechoHabiente.LargeGlyph = CType(resources.GetObject("btnIngresoDerechoHabiente.LargeGlyph"), System.Drawing.Image)
        Me.btnIngresoDerechoHabiente.Name = "btnIngresoDerechoHabiente"
        '
        'btnExportarDetalleHijos
        '
        Me.btnExportarDetalleHijos.Caption = "Exportar Detalle Hijos"
        Me.btnExportarDetalleHijos.Glyph = CType(resources.GetObject("btnExportarDetalleHijos.Glyph"), System.Drawing.Image)
        Me.btnExportarDetalleHijos.Id = 5
        Me.btnExportarDetalleHijos.LargeGlyph = CType(resources.GetObject("btnExportarDetalleHijos.LargeGlyph"), System.Drawing.Image)
        Me.btnExportarDetalleHijos.Name = "btnExportarDetalleHijos"
        '
        'btnExportarSolicitantes
        '
        Me.btnExportarSolicitantes.Caption = "Exportar Solicitantes"
        Me.btnExportarSolicitantes.Glyph = CType(resources.GetObject("btnExportarSolicitantes.Glyph"), System.Drawing.Image)
        Me.btnExportarSolicitantes.Id = 6
        Me.btnExportarSolicitantes.LargeGlyph = CType(resources.GetObject("btnExportarSolicitantes.LargeGlyph"), System.Drawing.Image)
        Me.btnExportarSolicitantes.Name = "btnExportarSolicitantes"
        '
        'btnHistorialEmpleado
        '
        Me.btnHistorialEmpleado.Caption = "Historial Empleado"
        Me.btnHistorialEmpleado.Glyph = CType(resources.GetObject("btnHistorialEmpleado.Glyph"), System.Drawing.Image)
        Me.btnHistorialEmpleado.Id = 7
        Me.btnHistorialEmpleado.LargeGlyph = CType(resources.GetObject("btnHistorialEmpleado.LargeGlyph"), System.Drawing.Image)
        Me.btnHistorialEmpleado.Name = "btnHistorialEmpleado"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Derecho Habientes"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnIngresoDerechoHabiente)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnEvaluarSolicitud)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnRefrescar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnHistorialEmpleado)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnExportarDetalleHijos)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnExportarSolicitantes)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 381)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(701, 31)
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
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemAsignacionFamiliarArchivo})
        Me.GridControl1.Size = New System.Drawing.Size(701, 238)
        Me.GridControl1.TabIndex = 9
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ADJUNTO})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: [#image] {1} {2}"
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", Nothing, "(Count={0})")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        '
        'ADJUNTO
        '
        Me.ADJUNTO.Caption = "ADJUNTO"
        Me.ADJUNTO.ColumnEdit = Me.RepositoryItemAsignacionFamiliarArchivo
        Me.ADJUNTO.FieldName = "ADJUNTO"
        Me.ADJUNTO.Name = "ADJUNTO"
        Me.ADJUNTO.Visible = True
        Me.ADJUNTO.VisibleIndex = 0
        Me.ADJUNTO.Width = 55
        '
        'RepositoryItemAsignacionFamiliarArchivo
        '
        Me.RepositoryItemAsignacionFamiliarArchivo.AutoHeight = False
        Me.RepositoryItemAsignacionFamiliarArchivo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemAsignacionFamiliarArchivo.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.RepositoryItemAsignacionFamiliarArchivo.Name = "RepositoryItemAsignacionFamiliarArchivo"
        Me.RepositoryItemAsignacionFamiliarArchivo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'SolicitudAsignacionFamiliarList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 412)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "SolicitudAsignacionFamiliarList"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "SOLICITUDES ASIGNACIÓN FAMILIAR"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemAsignacionFamiliarArchivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnRefrescar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEvaluarSolicitud As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnIngresoDerechoHabiente As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExportarDetalleHijos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExportarSolicitantes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ADJUNTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemAsignacionFamiliarArchivo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btnHistorialEmpleado As DevExpress.XtraBars.BarButtonItem
End Class
