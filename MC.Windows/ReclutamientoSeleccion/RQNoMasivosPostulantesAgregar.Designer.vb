<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RQNoMasivosPostulantesAgregar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RQNoMasivosPostulantesAgregar))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.gluTipoIdentidad = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemGridLookUpEditTipoIdentidad = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEditTipoIdentidadView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtNumeroIdentidad = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtApellidoMaterno = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombres = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTelefonoFijo = New DevExpress.XtraEditors.TextEdit()
        Me.txtTelefonoCelular = New DevExpress.XtraEditors.TextEdit()
        Me.txtTelefonoCelular2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.gluFuenteReclutamiento = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtIdPostulante = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtApellidoPaterno = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditTipoIdentidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditTipoIdentidadView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidoMaterno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefonoFijo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefonoCelular.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefonoCelular2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gluFuenteReclutamiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdPostulante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidoPaterno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnGuardar, Me.btnCerrar, Me.gluTipoIdentidad, Me.txtNumeroIdentidad})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 6
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEditTipoIdentidad, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemTextEdit1})
        Me.RibbonControl.Size = New System.Drawing.Size(449, 143)
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
        'btnCerrar
        '
        Me.btnCerrar.Caption = "Cerrar"
        Me.btnCerrar.Glyph = CType(resources.GetObject("btnCerrar.Glyph"), System.Drawing.Image)
        Me.btnCerrar.Id = 2
        Me.btnCerrar.LargeGlyph = CType(resources.GetObject("btnCerrar.LargeGlyph"), System.Drawing.Image)
        Me.btnCerrar.Name = "btnCerrar"
        '
        'gluTipoIdentidad
        '
        Me.gluTipoIdentidad.Caption = "Tipo de Identidad"
        Me.gluTipoIdentidad.Edit = Me.RepositoryItemGridLookUpEditTipoIdentidad
        Me.gluTipoIdentidad.EditWidth = 160
        Me.gluTipoIdentidad.Id = 3
        Me.gluTipoIdentidad.Name = "gluTipoIdentidad"
        '
        'RepositoryItemGridLookUpEditTipoIdentidad
        '
        Me.RepositoryItemGridLookUpEditTipoIdentidad.AutoHeight = False
        Me.RepositoryItemGridLookUpEditTipoIdentidad.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEditTipoIdentidad.Name = "RepositoryItemGridLookUpEditTipoIdentidad"
        Me.RepositoryItemGridLookUpEditTipoIdentidad.View = Me.RepositoryItemGridLookUpEditTipoIdentidadView
        '
        'RepositoryItemGridLookUpEditTipoIdentidadView
        '
        Me.RepositoryItemGridLookUpEditTipoIdentidadView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEditTipoIdentidadView.Name = "RepositoryItemGridLookUpEditTipoIdentidadView"
        Me.RepositoryItemGridLookUpEditTipoIdentidadView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEditTipoIdentidadView.OptionsView.ShowGroupPanel = False
        '
        'txtNumeroIdentidad
        '
        Me.txtNumeroIdentidad.Caption = " Nro de Identidad"
        Me.txtNumeroIdentidad.Edit = Me.RepositoryItemTextEdit1
        Me.txtNumeroIdentidad.EditWidth = 160
        Me.txtNumeroIdentidad.Id = 5
        Me.txtNumeroIdentidad.Name = "txtNumeroIdentidad"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Opciones"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnGuardar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.gluTipoIdentidad)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.txtNumeroIdentidad)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Buscar Postulante"
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.View = Me.RepositoryItemGridLookUpEdit2View
        '
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 533)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(449, 31)
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(37, 208)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl3.TabIndex = 21
        Me.LabelControl3.Text = "Apellido Materno"
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(123, 205)
        Me.txtApellidoMaterno.MenuManager = Me.RibbonControl
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoMaterno.Properties.MaxLength = 100
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(255, 20)
        Me.txtApellidoMaterno.TabIndex = 4
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(123, 231)
        Me.txtNombres.MenuManager = Me.RibbonControl
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombres.Properties.MaxLength = 100
        Me.txtNombres.Size = New System.Drawing.Size(255, 20)
        Me.txtNombres.TabIndex = 5
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(75, 234)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl4.TabIndex = 24
        Me.LabelControl4.Text = "Nombres"
        '
        'txtTelefonoFijo
        '
        Me.txtTelefonoFijo.Location = New System.Drawing.Point(123, 283)
        Me.txtTelefonoFijo.MenuManager = Me.RibbonControl
        Me.txtTelefonoFijo.Name = "txtTelefonoFijo"
        Me.txtTelefonoFijo.Properties.MaxLength = 100
        Me.txtTelefonoFijo.Size = New System.Drawing.Size(255, 20)
        Me.txtTelefonoFijo.TabIndex = 7
        '
        'txtTelefonoCelular
        '
        Me.txtTelefonoCelular.Location = New System.Drawing.Point(123, 309)
        Me.txtTelefonoCelular.MenuManager = Me.RibbonControl
        Me.txtTelefonoCelular.Name = "txtTelefonoCelular"
        Me.txtTelefonoCelular.Properties.MaxLength = 100
        Me.txtTelefonoCelular.Size = New System.Drawing.Size(255, 20)
        Me.txtTelefonoCelular.TabIndex = 8
        '
        'txtTelefonoCelular2
        '
        Me.txtTelefonoCelular2.Location = New System.Drawing.Point(123, 335)
        Me.txtTelefonoCelular2.MenuManager = Me.RibbonControl
        Me.txtTelefonoCelular2.Name = "txtTelefonoCelular2"
        Me.txtTelefonoCelular2.Properties.MaxLength = 100
        Me.txtTelefonoCelular2.Size = New System.Drawing.Size(255, 20)
        Me.txtTelefonoCelular2.TabIndex = 9
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(55, 286)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl5.TabIndex = 28
        Me.LabelControl5.Text = "Teléfono Fijo"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(39, 312)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl6.TabIndex = 29
        Me.LabelControl6.Text = "Teléfono Célular"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(30, 338)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl7.TabIndex = 30
        Me.LabelControl7.Text = "Teléfono Célular 2"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(83, 260)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl8.TabIndex = 31
        Me.LabelControl8.Text = "Fuente"
        '
        'gluFuenteReclutamiento
        '
        Me.gluFuenteReclutamiento.Location = New System.Drawing.Point(123, 257)
        Me.gluFuenteReclutamiento.MenuManager = Me.RibbonControl
        Me.gluFuenteReclutamiento.Name = "gluFuenteReclutamiento"
        Me.gluFuenteReclutamiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gluFuenteReclutamiento.Properties.View = Me.GridLookUpEdit1View
        Me.gluFuenteReclutamiento.Size = New System.Drawing.Size(255, 20)
        Me.gluFuenteReclutamiento.TabIndex = 6
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "IDFUENTE"
        Me.GridColumn3.FieldName = "IDFUENTE"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "DESCRIPCION"
        Me.GridColumn4.FieldName = "DESCRIPCION"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 120
        '
        'txtIdPostulante
        '
        Me.txtIdPostulante.Enabled = False
        Me.txtIdPostulante.Location = New System.Drawing.Point(123, 153)
        Me.txtIdPostulante.MenuManager = Me.RibbonControl
        Me.txtIdPostulante.Name = "txtIdPostulante"
        Me.txtIdPostulante.Size = New System.Drawing.Size(100, 20)
        Me.txtIdPostulante.TabIndex = 0
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(53, 156)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl9.TabIndex = 41
        Me.LabelControl9.Text = "Id Postulante"
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(123, 179)
        Me.txtApellidoPaterno.MenuManager = Me.RibbonControl
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoPaterno.Properties.MaxLength = 100
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(255, 20)
        Me.txtApellidoPaterno.TabIndex = 3
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(39, 182)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl10.TabIndex = 50
        Me.LabelControl10.Text = "Apellido Paterno"
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "Tipo de Identidad"
        Me.BarEditItem1.Edit = Nothing
        Me.BarEditItem1.EditWidth = 160
        Me.BarEditItem1.Id = 12
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(370, 50)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(79, 40)
        Me.btnBuscar.TabIndex = 78
        Me.btnBuscar.Text = "Buscar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.Location = New System.Drawing.Point(370, 96)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(79, 37)
        Me.btnLimpiar.TabIndex = 81
        Me.btnLimpiar.Text = "Limpiar"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 357)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(452, 181)
        Me.GroupControl1.TabIndex = 84
        Me.GroupControl1.Text = "Historial de Memorandum"
        Me.GroupControl1.Visible = False
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GridControl1.Location = New System.Drawing.Point(2, 20)
        Me.GridControl1.MainView = Me.GridView3
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(448, 159)
        Me.GridControl1.TabIndex = 9
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.GridControl1
        Me.GridView3.GroupFormat = "{0}: [#image] {1} {2}"
        Me.GridView3.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", Nothing, "(Count={0})")})
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        '
        'RQNoMasivosPostulantesAgregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 564)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.txtApellidoPaterno)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtIdPostulante)
        Me.Controls.Add(Me.gluFuenteReclutamiento)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtTelefonoCelular2)
        Me.Controls.Add(Me.txtTelefonoCelular)
        Me.Controls.Add(Me.txtTelefonoFijo)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.txtApellidoMaterno)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "RQNoMasivosPostulantesAgregar"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "AGREGAR POSTULANTE"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditTipoIdentidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditTipoIdentidadView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidoMaterno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefonoFijo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefonoCelular.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefonoCelular2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gluFuenteReclutamiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdPostulante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidoPaterno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtApellidoMaterno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTelefonoFijo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTelefonoCelular As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTelefonoCelular2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gluFuenteReclutamiento As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtIdPostulante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtApellidoPaterno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents gluTipoIdentidad As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemGridLookUpEditTipoIdentidad As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEditTipoIdentidadView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNumeroIdentidad As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
