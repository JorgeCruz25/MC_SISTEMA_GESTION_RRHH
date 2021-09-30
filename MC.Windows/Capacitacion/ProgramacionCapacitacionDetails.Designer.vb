<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgramacionCapacitacionDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProgramacionCapacitacionDetails))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnGrabar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNuevaClase = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAsignar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAnular = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCerrarCapacitacion = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTrabajador = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.sleCurso = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridViewCurso = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtIdCapacitacion = New DevExpress.XtraEditors.TextEdit()
        Me.sleResponsable = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridViewResponsable = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.sleModalidad = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridViewModalidad = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEstadoCapacitacion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.GroupBoxNumeroClases = New System.Windows.Forms.GroupBox()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.EDITAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemEditar = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.PROCESARCLASE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemProcesarClase = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ANULAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemAnular = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ASISTENCIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemVerAsistencia = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemValidado = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemAdjunto = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemGridTipoLicencia = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewLicenciaTipo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemGridMotivo = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewMotivo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemDateFechaInicio = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemDateFechaFinal = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemGridMesEvaluacion = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewMesEvaluacion = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemEstadoPago = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemDateFechaFinSuspension = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sleCurso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCurso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdCapacitacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sleResponsable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewResponsable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sleModalidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewModalidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtEstadoCapacitacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        Me.GroupBoxNumeroClases.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProcesarClase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemAnular, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemVerAsistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemValidado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemAdjunto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridTipoLicencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewLicenciaTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridMotivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewMotivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateFechaInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateFechaInicio.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateFechaFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateFechaFinal.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridMesEvaluacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewMesEvaluacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemEstadoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateFechaFinSuspension, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateFechaFinSuspension.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnGrabar, Me.btnCerrar, Me.btnNuevaClase, Me.btnAsignar, Me.btnAnular, Me.btnCerrarCapacitacion, Me.btnTrabajador})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 8
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(503, 143)
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
        'btnNuevaClase
        '
        Me.btnNuevaClase.Caption = "Nueva Clase"
        Me.btnNuevaClase.Glyph = CType(resources.GetObject("btnNuevaClase.Glyph"), System.Drawing.Image)
        Me.btnNuevaClase.Id = 3
        Me.btnNuevaClase.LargeGlyph = CType(resources.GetObject("btnNuevaClase.LargeGlyph"), System.Drawing.Image)
        Me.btnNuevaClase.Name = "btnNuevaClase"
        '
        'btnAsignar
        '
        Me.btnAsignar.Caption = "Asignar Capacitacion"
        Me.btnAsignar.Glyph = CType(resources.GetObject("btnAsignar.Glyph"), System.Drawing.Image)
        Me.btnAsignar.Id = 4
        Me.btnAsignar.LargeGlyph = CType(resources.GetObject("btnAsignar.LargeGlyph"), System.Drawing.Image)
        Me.btnAsignar.Name = "btnAsignar"
        '
        'btnAnular
        '
        Me.btnAnular.Caption = "Anular Capacitacion"
        Me.btnAnular.Glyph = CType(resources.GetObject("btnAnular.Glyph"), System.Drawing.Image)
        Me.btnAnular.Id = 5
        Me.btnAnular.LargeGlyph = CType(resources.GetObject("btnAnular.LargeGlyph"), System.Drawing.Image)
        Me.btnAnular.Name = "btnAnular"
        '
        'btnCerrarCapacitacion
        '
        Me.btnCerrarCapacitacion.Caption = "Cerrar Capacitación"
        Me.btnCerrarCapacitacion.Glyph = CType(resources.GetObject("btnCerrarCapacitacion.Glyph"), System.Drawing.Image)
        Me.btnCerrarCapacitacion.Id = 6
        Me.btnCerrarCapacitacion.LargeGlyph = CType(resources.GetObject("btnCerrarCapacitacion.LargeGlyph"), System.Drawing.Image)
        Me.btnCerrarCapacitacion.Name = "btnCerrarCapacitacion"
        '
        'btnTrabajador
        '
        Me.btnTrabajador.Caption = "Asignar Trabajador"
        Me.btnTrabajador.Glyph = CType(resources.GetObject("btnTrabajador.Glyph"), System.Drawing.Image)
        Me.btnTrabajador.Id = 7
        Me.btnTrabajador.LargeGlyph = CType(resources.GetObject("btnTrabajador.LargeGlyph"), System.Drawing.Image)
        Me.btnTrabajador.Name = "btnTrabajador"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Programación Capacitación"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnGrabar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnNuevaClase)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAsignar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrarCapacitacion)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAnular)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 504)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(503, 31)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(8, 29)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(14, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Id:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(8, 54)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Curso:"
        '
        'sleCurso
        '
        Me.sleCurso.Location = New System.Drawing.Point(114, 48)
        Me.sleCurso.Name = "sleCurso"
        Me.sleCurso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sleCurso.Properties.NullText = "[Seleccione]"
        Me.sleCurso.Properties.View = Me.GridViewCurso
        Me.sleCurso.Size = New System.Drawing.Size(347, 20)
        Me.sleCurso.TabIndex = 7
        '
        'GridViewCurso
        '
        Me.GridViewCurso.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewCurso.Name = "GridViewCurso"
        Me.GridViewCurso.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewCurso.OptionsView.ShowGroupPanel = False
        '
        'txtIdCapacitacion
        '
        Me.txtIdCapacitacion.CausesValidation = False
        Me.txtIdCapacitacion.Location = New System.Drawing.Point(114, 22)
        Me.txtIdCapacitacion.Name = "txtIdCapacitacion"
        Me.txtIdCapacitacion.Properties.Mask.EditMask = "d"
        Me.txtIdCapacitacion.Properties.MaxLength = 30
        Me.txtIdCapacitacion.Size = New System.Drawing.Size(68, 20)
        Me.txtIdCapacitacion.TabIndex = 11
        '
        'sleResponsable
        '
        Me.sleResponsable.Location = New System.Drawing.Point(114, 77)
        Me.sleResponsable.Name = "sleResponsable"
        Me.sleResponsable.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sleResponsable.Properties.NullText = "[Seleccione]"
        Me.sleResponsable.Properties.View = Me.GridViewResponsable
        Me.sleResponsable.Size = New System.Drawing.Size(347, 20)
        Me.sleResponsable.TabIndex = 12
        '
        'GridViewResponsable
        '
        Me.GridViewResponsable.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewResponsable.Name = "GridViewResponsable"
        Me.GridViewResponsable.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewResponsable.OptionsView.ShowGroupPanel = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(8, 80)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl3.TabIndex = 13
        Me.LabelControl3.Text = "Responsable:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(8, 106)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl4.TabIndex = 15
        Me.LabelControl4.Text = "Modalidad:"
        '
        'sleModalidad
        '
        Me.sleModalidad.Location = New System.Drawing.Point(114, 103)
        Me.sleModalidad.Name = "sleModalidad"
        Me.sleModalidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sleModalidad.Properties.NullText = "[Seleccione]"
        Me.sleModalidad.Properties.View = Me.GridViewModalidad
        Me.sleModalidad.Size = New System.Drawing.Size(172, 20)
        Me.sleModalidad.TabIndex = 14
        '
        'GridViewModalidad
        '
        Me.GridViewModalidad.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewModalidad.Name = "GridViewModalidad"
        Me.GridViewModalidad.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewModalidad.OptionsView.ShowGroupPanel = False
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GroupBox1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 143)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(756, 182, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(503, 168)
        Me.LayoutControl1.TabIndex = 18
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEstadoCapacitacion)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.txtIdCapacitacion)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.sleModalidad)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.sleCurso)
        Me.GroupBox1.Controls.Add(Me.sleResponsable)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 144)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Capacitación"
        '
        'txtEstadoCapacitacion
        '
        Me.txtEstadoCapacitacion.CausesValidation = False
        Me.txtEstadoCapacitacion.Location = New System.Drawing.Point(325, 22)
        Me.txtEstadoCapacitacion.Name = "txtEstadoCapacitacion"
        Me.txtEstadoCapacitacion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstadoCapacitacion.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEstadoCapacitacion.Properties.Appearance.Options.UseFont = True
        Me.txtEstadoCapacitacion.Properties.Appearance.Options.UseForeColor = True
        Me.txtEstadoCapacitacion.Properties.Mask.EditMask = "d"
        Me.txtEstadoCapacitacion.Properties.MaxLength = 30
        Me.txtEstadoCapacitacion.Size = New System.Drawing.Size(136, 22)
        Me.txtEstadoCapacitacion.TabIndex = 17
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(218, 25)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(101, 13)
        Me.LabelControl5.TabIndex = 16
        Me.LabelControl5.Text = "Estado Capacitación:"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(503, 168)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GroupBox1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(483, 148)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.GroupBoxNumeroClases)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 311)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(503, 193)
        Me.LayoutControl2.TabIndex = 19
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'GroupBoxNumeroClases
        '
        Me.GroupBoxNumeroClases.Controls.Add(Me.GridControl1)
        Me.GroupBoxNumeroClases.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxNumeroClases.Name = "GroupBoxNumeroClases"
        Me.GroupBoxNumeroClases.Size = New System.Drawing.Size(479, 169)
        Me.GroupBoxNumeroClases.TabIndex = 4
        Me.GroupBoxNumeroClases.TabStop = False
        Me.GroupBoxNumeroClases.Text = "Número de Clases"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GridControl1.Location = New System.Drawing.Point(3, 17)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemProcesarClase, Me.RepositoryItemEditar, Me.RepositoryItemValidado, Me.RepositoryItemAnular, Me.RepositoryItemVerAsistencia, Me.RepositoryItemAdjunto, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemGridTipoLicencia, Me.RepositoryItemGridMotivo, Me.RepositoryItemDateFechaInicio, Me.RepositoryItemDateFechaFinal, Me.RepositoryItemGridMesEvaluacion, Me.RepositoryItemEstadoPago, Me.RepositoryItemDateFechaFinSuspension})
        Me.GridControl1.Size = New System.Drawing.Size(473, 149)
        Me.GridControl1.TabIndex = 19
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.EDITAR, Me.PROCESARCLASE, Me.ANULAR, Me.ASISTENCIA})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: [#image] {1} {2}"
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", Nothing, "(Count={0})")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        '
        'EDITAR
        '
        Me.EDITAR.Caption = "EDITAR"
        Me.EDITAR.ColumnEdit = Me.RepositoryItemEditar
        Me.EDITAR.FieldName = "EDITAR"
        Me.EDITAR.MinWidth = 15
        Me.EDITAR.Name = "EDITAR"
        Me.EDITAR.Visible = True
        Me.EDITAR.VisibleIndex = 0
        Me.EDITAR.Width = 60
        '
        'RepositoryItemEditar
        '
        Me.RepositoryItemEditar.AutoHeight = False
        Me.RepositoryItemEditar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemEditar.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.RepositoryItemEditar.Name = "RepositoryItemEditar"
        Me.RepositoryItemEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'PROCESARCLASE
        '
        Me.PROCESARCLASE.Caption = "CERRAR CLASE"
        Me.PROCESARCLASE.ColumnEdit = Me.RepositoryItemProcesarClase
        Me.PROCESARCLASE.FieldName = "PROCESARCLASE"
        Me.PROCESARCLASE.Name = "PROCESARCLASE"
        Me.PROCESARCLASE.Visible = True
        Me.PROCESARCLASE.VisibleIndex = 3
        Me.PROCESARCLASE.Width = 110
        '
        'RepositoryItemProcesarClase
        '
        Me.RepositoryItemProcesarClase.AutoHeight = False
        Me.RepositoryItemProcesarClase.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemProcesarClase.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.RepositoryItemProcesarClase.Name = "RepositoryItemProcesarClase"
        Me.RepositoryItemProcesarClase.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ANULAR
        '
        Me.ANULAR.Caption = "ANULAR"
        Me.ANULAR.ColumnEdit = Me.RepositoryItemAnular
        Me.ANULAR.FieldName = "ANULAR"
        Me.ANULAR.MinWidth = 15
        Me.ANULAR.Name = "ANULAR"
        Me.ANULAR.Visible = True
        Me.ANULAR.VisibleIndex = 1
        Me.ANULAR.Width = 55
        '
        'RepositoryItemAnular
        '
        Me.RepositoryItemAnular.AutoHeight = False
        Me.RepositoryItemAnular.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemAnular.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.RepositoryItemAnular.Name = "RepositoryItemAnular"
        Me.RepositoryItemAnular.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ASISTENCIA
        '
        Me.ASISTENCIA.Caption = "ASISTENCIA"
        Me.ASISTENCIA.ColumnEdit = Me.RepositoryItemVerAsistencia
        Me.ASISTENCIA.FieldName = "ASISTENCIA"
        Me.ASISTENCIA.Name = "ASISTENCIA"
        Me.ASISTENCIA.Visible = True
        Me.ASISTENCIA.VisibleIndex = 2
        '
        'RepositoryItemVerAsistencia
        '
        Me.RepositoryItemVerAsistencia.AutoHeight = False
        Me.RepositoryItemVerAsistencia.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemVerAsistencia.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.RepositoryItemVerAsistencia.Name = "RepositoryItemVerAsistencia"
        Me.RepositoryItemVerAsistencia.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'RepositoryItemValidado
        '
        Me.RepositoryItemValidado.AutoHeight = False
        Me.RepositoryItemValidado.Name = "RepositoryItemValidado"
        '
        'RepositoryItemAdjunto
        '
        Me.RepositoryItemAdjunto.AutoHeight = False
        Me.RepositoryItemAdjunto.Name = "RepositoryItemAdjunto"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'RepositoryItemGridTipoLicencia
        '
        Me.RepositoryItemGridTipoLicencia.AutoHeight = False
        Me.RepositoryItemGridTipoLicencia.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridTipoLicencia.Name = "RepositoryItemGridTipoLicencia"
        Me.RepositoryItemGridTipoLicencia.View = Me.GridViewLicenciaTipo
        '
        'GridViewLicenciaTipo
        '
        Me.GridViewLicenciaTipo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewLicenciaTipo.Name = "GridViewLicenciaTipo"
        Me.GridViewLicenciaTipo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewLicenciaTipo.OptionsView.ShowAutoFilterRow = True
        Me.GridViewLicenciaTipo.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemGridMotivo
        '
        Me.RepositoryItemGridMotivo.AutoHeight = False
        Me.RepositoryItemGridMotivo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridMotivo.Name = "RepositoryItemGridMotivo"
        Me.RepositoryItemGridMotivo.View = Me.GridViewMotivo
        '
        'GridViewMotivo
        '
        Me.GridViewMotivo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewMotivo.Name = "GridViewMotivo"
        Me.GridViewMotivo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewMotivo.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemDateFechaInicio
        '
        Me.RepositoryItemDateFechaInicio.AutoHeight = False
        Me.RepositoryItemDateFechaInicio.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateFechaInicio.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateFechaInicio.Name = "RepositoryItemDateFechaInicio"
        '
        'RepositoryItemDateFechaFinal
        '
        Me.RepositoryItemDateFechaFinal.AutoHeight = False
        Me.RepositoryItemDateFechaFinal.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateFechaFinal.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateFechaFinal.Name = "RepositoryItemDateFechaFinal"
        '
        'RepositoryItemGridMesEvaluacion
        '
        Me.RepositoryItemGridMesEvaluacion.AutoHeight = False
        Me.RepositoryItemGridMesEvaluacion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridMesEvaluacion.Name = "RepositoryItemGridMesEvaluacion"
        Me.RepositoryItemGridMesEvaluacion.View = Me.GridViewMesEvaluacion
        '
        'GridViewMesEvaluacion
        '
        Me.GridViewMesEvaluacion.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewMesEvaluacion.Name = "GridViewMesEvaluacion"
        Me.GridViewMesEvaluacion.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewMesEvaluacion.OptionsView.ShowAutoFilterRow = True
        Me.GridViewMesEvaluacion.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemEstadoPago
        '
        Me.RepositoryItemEstadoPago.AutoHeight = False
        Me.RepositoryItemEstadoPago.Name = "RepositoryItemEstadoPago"
        '
        'RepositoryItemDateFechaFinSuspension
        '
        Me.RepositoryItemDateFechaFinSuspension.AutoHeight = False
        Me.RepositoryItemDateFechaFinSuspension.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateFechaFinSuspension.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateFechaFinSuspension.Name = "RepositoryItemDateFechaFinSuspension"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(503, 193)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.GroupBoxNumeroClases
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(483, 173)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'ProgramacionCapacitacionDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 535)
        Me.Controls.Add(Me.LayoutControl2)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "ProgramacionCapacitacionDetails"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "PROGRAMACIÓN CAPACITACIÓN"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sleCurso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCurso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdCapacitacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sleResponsable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewResponsable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sleModalidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewModalidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtEstadoCapacitacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        Me.GroupBoxNumeroClases.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProcesarClase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemAnular, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemVerAsistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemValidado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemAdjunto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridTipoLicencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewLicenciaTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridMotivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewMotivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateFechaInicio.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateFechaInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateFechaFinal.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateFechaFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridMesEvaluacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewMesEvaluacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemEstadoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateFechaFinSuspension.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateFechaFinSuspension, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents sleCurso As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridViewCurso As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtIdCapacitacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sleResponsable As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridViewResponsable As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sleModalidad As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridViewModalidad As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents GroupBoxNumeroClases As GroupBox
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemAdjunto As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemProcesarClase As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents EDITAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemEditar As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ANULAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemAnular As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemDateFechaInicio As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateFechaFinal As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateFechaFinSuspension As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemValidado As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemVerAsistencia As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemGridTipoLicencia As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewLicenciaTipo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridMotivo As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewMotivo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridMesEvaluacion As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewMesEvaluacion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemEstadoPago As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnNuevaClase As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ASISTENCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PROCESARCLASE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAsignar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAnular As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCerrarCapacitacion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtEstadoCapacitacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnTrabajador As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
End Class
