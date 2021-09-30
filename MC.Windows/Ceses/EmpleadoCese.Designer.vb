<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmpleadoCese
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmpleadoCese))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnRegistrarCese = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemGridLookUpEditEmpleado = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEditEmpleadoView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnValidar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAnular = New DevExpress.XtraBars.BarButtonItem()
        Me.btnHistorialEmpleado = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.sleMotivoCese = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridViewMotivoCese = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtObservacion = New DevExpress.XtraEditors.MemoEdit()
        Me.deFechaCese = New DevExpress.XtraEditors.DateEdit()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.chkPagoDiasBoleta = New DevExpress.XtraEditors.CheckEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.dtFechaRecojoDocumento = New DevExpress.XtraEditors.DateEdit()
        Me.lblFechaSupervisor = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodigoUnico = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIdEmpleado = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmpleado = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditEmpleadoView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sleMotivoCese.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewMotivoCese, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaCese.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaCese.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPagoDiasBoleta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.dtFechaRecojoDocumento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaRecojoDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoUnico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnRegistrarCese, Me.btnCerrar, Me.BarEditItem1, Me.btnValidar, Me.btnAnular, Me.btnHistorialEmpleado})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 8
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEditEmpleado})
        Me.RibbonControl.Size = New System.Drawing.Size(474, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnRegistrarCese
        '
        Me.btnRegistrarCese.Caption = "Registrar Cese"
        Me.btnRegistrarCese.Glyph = CType(resources.GetObject("btnRegistrarCese.Glyph"), System.Drawing.Image)
        Me.btnRegistrarCese.Id = 1
        Me.btnRegistrarCese.LargeGlyph = CType(resources.GetObject("btnRegistrarCese.LargeGlyph"), System.Drawing.Image)
        Me.btnRegistrarCese.Name = "btnRegistrarCese"
        '
        'btnCerrar
        '
        Me.btnCerrar.Caption = "Cerrar"
        Me.btnCerrar.Glyph = CType(resources.GetObject("btnCerrar.Glyph"), System.Drawing.Image)
        Me.btnCerrar.Id = 2
        Me.btnCerrar.LargeGlyph = CType(resources.GetObject("btnCerrar.LargeGlyph"), System.Drawing.Image)
        Me.btnCerrar.Name = "btnCerrar"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "Empleado "
        Me.BarEditItem1.Edit = Me.RepositoryItemGridLookUpEditEmpleado
        Me.BarEditItem1.EditWidth = 280
        Me.BarEditItem1.Id = 3
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'RepositoryItemGridLookUpEditEmpleado
        '
        Me.RepositoryItemGridLookUpEditEmpleado.AutoHeight = False
        Me.RepositoryItemGridLookUpEditEmpleado.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEditEmpleado.Name = "RepositoryItemGridLookUpEditEmpleado"
        Me.RepositoryItemGridLookUpEditEmpleado.View = Me.RepositoryItemGridLookUpEditEmpleadoView
        '
        'RepositoryItemGridLookUpEditEmpleadoView
        '
        Me.RepositoryItemGridLookUpEditEmpleadoView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEditEmpleadoView.Name = "RepositoryItemGridLookUpEditEmpleadoView"
        Me.RepositoryItemGridLookUpEditEmpleadoView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEditEmpleadoView.OptionsView.ShowAutoFilterRow = True
        Me.RepositoryItemGridLookUpEditEmpleadoView.OptionsView.ShowGroupPanel = False
        '
        'btnValidar
        '
        Me.btnValidar.Caption = "Validar"
        Me.btnValidar.Glyph = CType(resources.GetObject("btnValidar.Glyph"), System.Drawing.Image)
        Me.btnValidar.Id = 4
        Me.btnValidar.LargeGlyph = CType(resources.GetObject("btnValidar.LargeGlyph"), System.Drawing.Image)
        Me.btnValidar.Name = "btnValidar"
        '
        'btnAnular
        '
        Me.btnAnular.Caption = "Anular"
        Me.btnAnular.Glyph = CType(resources.GetObject("btnAnular.Glyph"), System.Drawing.Image)
        Me.btnAnular.Id = 5
        Me.btnAnular.LargeGlyph = CType(resources.GetObject("btnAnular.LargeGlyph"), System.Drawing.Image)
        Me.btnAnular.Name = "btnAnular"
        '
        'btnHistorialEmpleado
        '
        Me.btnHistorialEmpleado.Caption = "Historial Empleado"
        Me.btnHistorialEmpleado.Glyph = CType(resources.GetObject("btnHistorialEmpleado.Glyph"), System.Drawing.Image)
        Me.btnHistorialEmpleado.Id = 7
        Me.btnHistorialEmpleado.LargeGlyph = CType(resources.GetObject("btnHistorialEmpleado.LargeGlyph"), System.Drawing.Image)
        Me.btnHistorialEmpleado.Name = "btnHistorialEmpleado"
        Me.btnHistorialEmpleado.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Cese de Personal"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnValidar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnRegistrarCese)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnHistorialEmpleado)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAnular)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarEditItem1)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Empleado"
        Me.RibbonPageGroup2.Visible = False
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 429)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(474, 31)
        '
        'sleMotivoCese
        '
        Me.sleMotivoCese.Location = New System.Drawing.Point(88, 60)
        Me.sleMotivoCese.Name = "sleMotivoCese"
        Me.sleMotivoCese.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sleMotivoCese.Properties.NullText = "[Seleccione]"
        Me.sleMotivoCese.Properties.View = Me.GridViewMotivoCese
        Me.sleMotivoCese.Size = New System.Drawing.Size(359, 20)
        Me.sleMotivoCese.TabIndex = 4
        '
        'GridViewMotivoCese
        '
        Me.GridViewMotivoCese.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewMotivoCese.Name = "GridViewMotivoCese"
        Me.GridViewMotivoCese.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewMotivoCese.OptionsView.ShowAutoFilterRow = True
        Me.GridViewMotivoCese.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridViewMotivoCese.OptionsView.ShowGroupPanel = False
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(14, 63)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl7.TabIndex = 39
        Me.LabelControl7.Text = "Motivo"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(14, 88)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl6.TabIndex = 38
        Me.LabelControl6.Text = "Observación"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 37)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl5.TabIndex = 37
        Me.LabelControl5.Text = "Fecha"
        '
        'txtObservacion
        '
        Me.txtObservacion.EditValue = ""
        Me.txtObservacion.Location = New System.Drawing.Point(88, 86)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Properties.MaxLength = 80
        Me.txtObservacion.Size = New System.Drawing.Size(359, 71)
        Me.txtObservacion.TabIndex = 4
        '
        'deFechaCese
        '
        Me.deFechaCese.EditValue = Nothing
        Me.deFechaCese.Location = New System.Drawing.Point(88, 34)
        Me.deFechaCese.Name = "deFechaCese"
        Me.deFechaCese.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaCese.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaCese.Size = New System.Drawing.Size(108, 20)
        Me.deFechaCese.TabIndex = 2
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'chkPagoDiasBoleta
        '
        Me.chkPagoDiasBoleta.Location = New System.Drawing.Point(271, 31)
        Me.chkPagoDiasBoleta.MenuManager = Me.RibbonControl
        Me.chkPagoDiasBoleta.Name = "chkPagoDiasBoleta"
        Me.chkPagoDiasBoleta.Properties.Caption = "Pago de Dias en Boleta"
        Me.chkPagoDiasBoleta.Size = New System.Drawing.Size(176, 19)
        Me.chkPagoDiasBoleta.TabIndex = 3
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.dtFechaRecojoDocumento)
        Me.GroupControl2.Controls.Add(Me.lblFechaSupervisor)
        Me.GroupControl2.Controls.Add(Me.txtCodigoUnico)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.txtIdEmpleado)
        Me.GroupControl2.Controls.Add(Me.LabelControl11)
        Me.GroupControl2.Controls.Add(Me.txtEmpleado)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 143)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(474, 105)
        Me.GroupControl2.TabIndex = 57
        Me.GroupControl2.Text = "Datos del Personal"
        '
        'dtFechaRecojoDocumento
        '
        Me.dtFechaRecojoDocumento.EditValue = Nothing
        Me.dtFechaRecojoDocumento.Location = New System.Drawing.Point(111, 78)
        Me.dtFechaRecojoDocumento.MenuManager = Me.RibbonControl
        Me.dtFechaRecojoDocumento.Name = "dtFechaRecojoDocumento"
        Me.dtFechaRecojoDocumento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaRecojoDocumento.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaRecojoDocumento.Size = New System.Drawing.Size(108, 20)
        Me.dtFechaRecojoDocumento.TabIndex = 47
        '
        'lblFechaSupervisor
        '
        Me.lblFechaSupervisor.Location = New System.Drawing.Point(12, 81)
        Me.lblFechaSupervisor.Name = "lblFechaSupervisor"
        Me.lblFechaSupervisor.Size = New System.Drawing.Size(83, 13)
        Me.lblFechaSupervisor.TabIndex = 46
        Me.lblFechaSupervisor.Text = "Fecha Supervisor"
        '
        'txtCodigoUnico
        '
        Me.txtCodigoUnico.Enabled = False
        Me.txtCodigoUnico.Location = New System.Drawing.Point(339, 27)
        Me.txtCodigoUnico.MenuManager = Me.RibbonControl
        Me.txtCodigoUnico.Name = "txtCodigoUnico"
        Me.txtCodigoUnico.Size = New System.Drawing.Size(125, 20)
        Me.txtCodigoUnico.TabIndex = 45
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(252, 30)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl8.TabIndex = 44
        Me.LabelControl8.Text = "Código Unico"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 30)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl4.TabIndex = 17
        Me.LabelControl4.Text = "Id Empleado"
        '
        'txtIdEmpleado
        '
        Me.txtIdEmpleado.Enabled = False
        Me.txtIdEmpleado.Location = New System.Drawing.Point(111, 27)
        Me.txtIdEmpleado.MenuManager = Me.RibbonControl
        Me.txtIdEmpleado.Name = "txtIdEmpleado"
        Me.txtIdEmpleado.Size = New System.Drawing.Size(108, 20)
        Me.txtIdEmpleado.TabIndex = 13
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(12, 56)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl11.TabIndex = 18
        Me.LabelControl11.Text = "Empleado"
        '
        'txtEmpleado
        '
        Me.txtEmpleado.CausesValidation = False
        Me.txtEmpleado.Enabled = False
        Me.txtEmpleado.Location = New System.Drawing.Point(111, 53)
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Properties.Mask.EditMask = "d"
        Me.txtEmpleado.Properties.MaxLength = 50
        Me.txtEmpleado.Size = New System.Drawing.Size(353, 20)
        Me.txtEmpleado.TabIndex = 16
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.deFechaCese)
        Me.GroupControl1.Controls.Add(Me.chkPagoDiasBoleta)
        Me.GroupControl1.Controls.Add(Me.txtObservacion)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.sleMotivoCese)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl1.Location = New System.Drawing.Point(0, 254)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(474, 175)
        Me.GroupControl1.TabIndex = 58
        Me.GroupControl1.Text = "Datos de Cese"
        '
        'EmpleadoCese
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 460)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.MaximizeBox = False
        Me.Name = "EmpleadoCese"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "CESE DE PERSONAL"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditEmpleadoView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sleMotivoCese.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewMotivoCese, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaCese.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaCese.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPagoDiasBoleta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.dtFechaRecojoDocumento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaRecojoDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoUnico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnRegistrarCese As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sleMotivoCese As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridViewMotivoCese As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtObservacion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents deFechaCese As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents chkPagoDiasBoleta As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtCodigoUnico As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIdEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemGridLookUpEditEmpleado As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEditEmpleadoView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnValidar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dtFechaRecojoDocumento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblFechaSupervisor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAnular As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnHistorialEmpleado As DevExpress.XtraBars.BarButtonItem
End Class
