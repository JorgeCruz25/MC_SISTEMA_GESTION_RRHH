<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RQMasivosPostulantes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RQMasivosPostulantes))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRefrescar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEnviarCorreo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnProcesar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAsignarPostulante = New DevExpress.XtraBars.BarButtonItem()
        Me.txtLocalSolicitante = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtCargoRequerido = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtRazonComercial = New DevExpress.XtraBars.BarStaticItem()
        Me.txtPuestoRequerido = New DevExpress.XtraBars.BarStaticItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn63 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEditAsignar = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEditTipoIdentidad = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewTipoIdentidad = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn42 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn43 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEditDistrito = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewDistrito = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn41 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn56 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn57 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn58 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn59 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn60 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn61 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEditSexo = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewSexo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEditCargo = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewCargo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEditCargo2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewCargo2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEditFuenteDetalle = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewFuenteDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn39 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn40 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEditFuente = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewFuente = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn38 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEditConclusionDetalle = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewConclusionDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEditConclusion = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewConclusion = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEditTienda = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewTienda = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn44 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn45 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEditTurno = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewTurno = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn51 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn53 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn49 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn47 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn46 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEditAsignacion = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemGridLookUpEditCondicionActual = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewCondicionActual = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn54 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn55 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEditAsignar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditTipoIdentidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewTipoIdentidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditDistrito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewDistrito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditSexo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSexo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditCargo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCargo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditFuenteDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewFuenteDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditFuente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewFuente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditConclusionDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewConclusionDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditConclusion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewConclusion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditTienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewTienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditTurno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewTurno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEditAsignacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditCondicionActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCondicionActual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnNuevo, Me.btnRefrescar, Me.btnEnviarCorreo, Me.btnProcesar, Me.btnCerrar, Me.btnAsignarPostulante, Me.txtLocalSolicitante, Me.txtCargoRequerido, Me.txtRazonComercial, Me.txtPuestoRequerido})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 13
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.RibbonControl.Size = New System.Drawing.Size(1145, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnNuevo
        '
        Me.btnNuevo.Caption = "Nuevo"
        Me.btnNuevo.Glyph = CType(resources.GetObject("btnNuevo.Glyph"), System.Drawing.Image)
        Me.btnNuevo.Id = 1
        Me.btnNuevo.LargeGlyph = CType(resources.GetObject("btnNuevo.LargeGlyph"), System.Drawing.Image)
        Me.btnNuevo.Name = "btnNuevo"
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Caption = "Refrescar"
        Me.btnRefrescar.Glyph = CType(resources.GetObject("btnRefrescar.Glyph"), System.Drawing.Image)
        Me.btnRefrescar.Id = 2
        Me.btnRefrescar.LargeGlyph = CType(resources.GetObject("btnRefrescar.LargeGlyph"), System.Drawing.Image)
        Me.btnRefrescar.Name = "btnRefrescar"
        '
        'btnEnviarCorreo
        '
        Me.btnEnviarCorreo.Caption = "Enviar Correo"
        Me.btnEnviarCorreo.Glyph = CType(resources.GetObject("btnEnviarCorreo.Glyph"), System.Drawing.Image)
        Me.btnEnviarCorreo.Id = 3
        Me.btnEnviarCorreo.LargeGlyph = CType(resources.GetObject("btnEnviarCorreo.LargeGlyph"), System.Drawing.Image)
        Me.btnEnviarCorreo.Name = "btnEnviarCorreo"
        '
        'btnProcesar
        '
        Me.btnProcesar.Caption = "Procesar"
        Me.btnProcesar.Glyph = CType(resources.GetObject("btnProcesar.Glyph"), System.Drawing.Image)
        Me.btnProcesar.Id = 4
        Me.btnProcesar.LargeGlyph = CType(resources.GetObject("btnProcesar.LargeGlyph"), System.Drawing.Image)
        Me.btnProcesar.Name = "btnProcesar"
        '
        'btnCerrar
        '
        Me.btnCerrar.Caption = "Cerrar"
        Me.btnCerrar.Glyph = CType(resources.GetObject("btnCerrar.Glyph"), System.Drawing.Image)
        Me.btnCerrar.Id = 5
        Me.btnCerrar.LargeGlyph = CType(resources.GetObject("btnCerrar.LargeGlyph"), System.Drawing.Image)
        Me.btnCerrar.Name = "btnCerrar"
        '
        'btnAsignarPostulante
        '
        Me.btnAsignarPostulante.Caption = "Reingreso Postulante"
        Me.btnAsignarPostulante.Glyph = CType(resources.GetObject("btnAsignarPostulante.Glyph"), System.Drawing.Image)
        Me.btnAsignarPostulante.Id = 6
        Me.btnAsignarPostulante.LargeGlyph = CType(resources.GetObject("btnAsignarPostulante.LargeGlyph"), System.Drawing.Image)
        Me.btnAsignarPostulante.Name = "btnAsignarPostulante"
        Me.btnAsignarPostulante.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'txtLocalSolicitante
        '
        Me.txtLocalSolicitante.Caption = "Local Solicitante  "
        Me.txtLocalSolicitante.Edit = Me.RepositoryItemTextEdit1
        Me.txtLocalSolicitante.EditWidth = 250
        Me.txtLocalSolicitante.Enabled = False
        Me.txtLocalSolicitante.Id = 8
        Me.txtLocalSolicitante.Name = "txtLocalSolicitante"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'txtCargoRequerido
        '
        Me.txtCargoRequerido.Caption = "Cargo Requerido"
        Me.txtCargoRequerido.Edit = Me.RepositoryItemTextEdit2
        Me.txtCargoRequerido.EditWidth = 250
        Me.txtCargoRequerido.Enabled = False
        Me.txtCargoRequerido.Id = 9
        Me.txtCargoRequerido.Name = "txtCargoRequerido"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'txtRazonComercial
        '
        Me.txtRazonComercial.Caption = "BarStaticItem1"
        Me.txtRazonComercial.Id = 11
        Me.txtRazonComercial.Name = "txtRazonComercial"
        Me.txtRazonComercial.TextAlignment = System.Drawing.StringAlignment.Near
        Me.txtRazonComercial.Width = 400
        '
        'txtPuestoRequerido
        '
        Me.txtPuestoRequerido.Caption = "BarStaticItem1"
        Me.txtPuestoRequerido.Id = 12
        Me.txtPuestoRequerido.Name = "txtPuestoRequerido"
        Me.txtPuestoRequerido.TextAlignment = System.Drawing.StringAlignment.Near
        Me.txtPuestoRequerido.Width = 400
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Postulantes Masivos"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnNuevo)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnRefrescar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnEnviarCorreo)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnProcesar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.txtRazonComercial)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.txtPuestoRequerido)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Datos de Requerimiento"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 489)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1145, 31)
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GridControl1.EmbeddedNavigator.CustomButtons.AddRange(New DevExpress.XtraEditors.NavigatorCustomButton() {New DevExpress.XtraEditors.NavigatorCustomButton()})
        Me.GridControl1.Location = New System.Drawing.Point(0, 143)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEditDistrito, Me.RepositoryItemGridLookUpEditCargo, Me.RepositoryItemGridLookUpEditSexo, Me.RepositoryItemGridLookUpEditCargo2, Me.RepositoryItemGridLookUpEditTienda, Me.RepositoryItemGridLookUpEditConclusion, Me.RepositoryItemGridLookUpEditConclusionDetalle, Me.RepositoryItemGridLookUpEditFuente, Me.RepositoryItemGridLookUpEditFuenteDetalle, Me.RepositoryItemGridLookUpEditTipoIdentidad, Me.RepositoryItemCheckEditAsignacion, Me.RepositoryItemGridLookUpEditTurno, Me.RepositoryItemGridLookUpEditCondicionActual, Me.RepositoryItemDateEdit1, Me.RepositoryItemCheckEditAsignar})
        Me.GridControl1.Size = New System.Drawing.Size(1145, 346)
        Me.GridControl1.TabIndex = 8
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn11, Me.GridColumn63, Me.GridColumn8, Me.GridColumn1, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn9, Me.GridColumn10, Me.GridColumn2, Me.GridColumn60, Me.GridColumn61, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn20, Me.GridColumn28, Me.GridColumn27, Me.GridColumn24, Me.GridColumn25, Me.GridColumn22, Me.GridColumn21, Me.GridColumn26, Me.GridColumn23, Me.GridColumn50, Me.GridColumn49, Me.GridColumn47, Me.GridColumn46})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "ID"
        Me.GridColumn11.FieldName = "IDPOSTULANTEMASIVO"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn63
        '
        Me.GridColumn63.Caption = "ASIGNAR"
        Me.GridColumn63.ColumnEdit = Me.RepositoryItemCheckEditAsignar
        Me.GridColumn63.FieldName = "ESTADOASIGNACION"
        Me.GridColumn63.Name = "GridColumn63"
        Me.GridColumn63.Visible = True
        Me.GridColumn63.VisibleIndex = 0
        '
        'RepositoryItemCheckEditAsignar
        '
        Me.RepositoryItemCheckEditAsignar.AutoHeight = False
        Me.RepositoryItemCheckEditAsignar.Name = "RepositoryItemCheckEditAsignar"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "TIPO IDENTIDAD"
        Me.GridColumn8.ColumnEdit = Me.RepositoryItemGridLookUpEditTipoIdentidad
        Me.GridColumn8.FieldName = "IDTIPODOCUMENTOIDENTIDAD"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        Me.GridColumn8.Width = 120
        '
        'RepositoryItemGridLookUpEditTipoIdentidad
        '
        Me.RepositoryItemGridLookUpEditTipoIdentidad.AutoHeight = False
        Me.RepositoryItemGridLookUpEditTipoIdentidad.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEditTipoIdentidad.Name = "RepositoryItemGridLookUpEditTipoIdentidad"
        Me.RepositoryItemGridLookUpEditTipoIdentidad.View = Me.GridViewTipoIdentidad
        '
        'GridViewTipoIdentidad
        '
        Me.GridViewTipoIdentidad.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn42, Me.GridColumn43})
        Me.GridViewTipoIdentidad.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewTipoIdentidad.Name = "GridViewTipoIdentidad"
        Me.GridViewTipoIdentidad.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewTipoIdentidad.OptionsView.ShowGroupPanel = False
        '
        'GridColumn42
        '
        Me.GridColumn42.Caption = "IDTIPOIDENTIDAD"
        Me.GridColumn42.FieldName = "IDTIPOIDENTIDAD"
        Me.GridColumn42.Name = "GridColumn42"
        '
        'GridColumn43
        '
        Me.GridColumn43.Caption = "TIPO IDENTIDAD"
        Me.GridColumn43.FieldName = "DESCRIPCION"
        Me.GridColumn43.Name = "GridColumn43"
        Me.GridColumn43.Visible = True
        Me.GridColumn43.VisibleIndex = 0
        Me.GridColumn43.Width = 120
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "NRO IDENTIDAD"
        Me.GridColumn1.FieldName = "NUMERODOCUMENTO"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 100
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "NOMBRES"
        Me.GridColumn5.FieldName = "NOMBRES"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 80
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "APELLIDO PATERNO"
        Me.GridColumn6.FieldName = "APELLIDOPATERNO"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        Me.GridColumn6.Width = 120
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "APELLIDO MATERNO"
        Me.GridColumn7.FieldName = "APELLIDOMATERNO"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        Me.GridColumn7.Width = 120
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "TELEFONO"
        Me.GridColumn9.FieldName = "TELEFONO"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 6
        Me.GridColumn9.Width = 90
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "CORREO"
        Me.GridColumn10.FieldName = "CORREO"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 7
        Me.GridColumn10.Width = 120
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "DISTRITO"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemGridLookUpEditDistrito
        Me.GridColumn2.FieldName = "IDUBIGEO"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 8
        Me.GridColumn2.Width = 100
        '
        'RepositoryItemGridLookUpEditDistrito
        '
        Me.RepositoryItemGridLookUpEditDistrito.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEditDistrito.Name = "RepositoryItemGridLookUpEditDistrito"
        Me.RepositoryItemGridLookUpEditDistrito.View = Me.GridViewDistrito
        '
        'GridViewDistrito
        '
        Me.GridViewDistrito.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn41, Me.GridColumn3, Me.GridColumn4, Me.GridColumn56, Me.GridColumn57, Me.GridColumn58, Me.GridColumn59})
        Me.GridViewDistrito.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewDistrito.Name = "GridViewDistrito"
        Me.GridViewDistrito.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewDistrito.OptionsView.ShowAutoFilterRow = True
        Me.GridViewDistrito.OptionsView.ShowGroupPanel = False
        '
        'GridColumn41
        '
        Me.GridColumn41.Caption = "ID"
        Me.GridColumn41.FieldName = "ID"
        Me.GridColumn41.Name = "GridColumn41"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "IDDISTRITO"
        Me.GridColumn3.FieldName = "IDDISTRITO"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "DISTRITO"
        Me.GridColumn4.FieldName = "DISTRITO"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 182
        '
        'GridColumn56
        '
        Me.GridColumn56.Caption = "IDPROVINCIA"
        Me.GridColumn56.FieldName = "IDPROVINCIA"
        Me.GridColumn56.Name = "GridColumn56"
        '
        'GridColumn57
        '
        Me.GridColumn57.Caption = "PROVINCIA"
        Me.GridColumn57.FieldName = "PROVINCIA"
        Me.GridColumn57.Name = "GridColumn57"
        Me.GridColumn57.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn57.Visible = True
        Me.GridColumn57.VisibleIndex = 1
        Me.GridColumn57.Width = 182
        '
        'GridColumn58
        '
        Me.GridColumn58.Caption = "IDDEPARTAMENTO"
        Me.GridColumn58.FieldName = "IDDEPARTAMENTO"
        Me.GridColumn58.Name = "GridColumn58"
        '
        'GridColumn59
        '
        Me.GridColumn59.Caption = "DEPARTAMENTO"
        Me.GridColumn59.FieldName = "DEPARTAMENTO"
        Me.GridColumn59.Name = "GridColumn59"
        Me.GridColumn59.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn59.Visible = True
        Me.GridColumn59.VisibleIndex = 2
        Me.GridColumn59.Width = 200
        '
        'GridColumn60
        '
        Me.GridColumn60.Caption = "PROVINCIA"
        Me.GridColumn60.FieldName = "PROVINCIA"
        Me.GridColumn60.Name = "GridColumn60"
        Me.GridColumn60.OptionsColumn.AllowEdit = False
        Me.GridColumn60.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn60.Visible = True
        Me.GridColumn60.VisibleIndex = 9
        Me.GridColumn60.Width = 100
        '
        'GridColumn61
        '
        Me.GridColumn61.Caption = "DEPARTAMENTO"
        Me.GridColumn61.FieldName = "DEPARTAMENTO"
        Me.GridColumn61.Name = "GridColumn61"
        Me.GridColumn61.OptionsColumn.AllowEdit = False
        Me.GridColumn61.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn61.Visible = True
        Me.GridColumn61.VisibleIndex = 10
        Me.GridColumn61.Width = 100
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "FECHA DE NAC."
        Me.GridColumn12.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.GridColumn12.FieldName = "FECHANACIMIENTO"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 11
        Me.GridColumn12.Width = 120
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "EDAD"
        Me.GridColumn13.FieldName = "EDAD"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 12
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "SEXO"
        Me.GridColumn14.ColumnEdit = Me.RepositoryItemGridLookUpEditSexo
        Me.GridColumn14.FieldName = "IDSEXO"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 13
        '
        'RepositoryItemGridLookUpEditSexo
        '
        Me.RepositoryItemGridLookUpEditSexo.AutoHeight = False
        Me.RepositoryItemGridLookUpEditSexo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEditSexo.Name = "RepositoryItemGridLookUpEditSexo"
        Me.RepositoryItemGridLookUpEditSexo.View = Me.GridViewSexo
        '
        'GridViewSexo
        '
        Me.GridViewSexo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn18, Me.GridColumn19})
        Me.GridViewSexo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewSexo.Name = "GridViewSexo"
        Me.GridViewSexo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewSexo.OptionsView.ShowGroupPanel = False
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "IDSEXO"
        Me.GridColumn18.FieldName = "IDSEXO"
        Me.GridColumn18.Name = "GridColumn18"
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "SEXO"
        Me.GridColumn19.FieldName = "DESCRIPCION"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 0
        Me.GridColumn19.Width = 80
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "CARGO"
        Me.GridColumn15.ColumnEdit = Me.RepositoryItemGridLookUpEditCargo
        Me.GridColumn15.FieldName = "IDCARGO"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 14
        Me.GridColumn15.Width = 90
        '
        'RepositoryItemGridLookUpEditCargo
        '
        Me.RepositoryItemGridLookUpEditCargo.AutoHeight = False
        Me.RepositoryItemGridLookUpEditCargo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEditCargo.Name = "RepositoryItemGridLookUpEditCargo"
        Me.RepositoryItemGridLookUpEditCargo.View = Me.GridViewCargo
        '
        'GridViewCargo
        '
        Me.GridViewCargo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn16, Me.GridColumn17})
        Me.GridViewCargo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewCargo.Name = "GridViewCargo"
        Me.GridViewCargo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewCargo.OptionsView.ShowAutoFilterRow = True
        Me.GridViewCargo.OptionsView.ShowGroupPanel = False
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "IDCARGO"
        Me.GridColumn16.FieldName = "IDCARGO"
        Me.GridColumn16.Name = "GridColumn16"
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "CARGO"
        Me.GridColumn17.FieldName = "DESCRIPCION"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 0
        Me.GridColumn17.Width = 120
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "CARGO 2"
        Me.GridColumn20.ColumnEdit = Me.RepositoryItemGridLookUpEditCargo2
        Me.GridColumn20.FieldName = "IDCARGO2"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 15
        Me.GridColumn20.Width = 90
        '
        'RepositoryItemGridLookUpEditCargo2
        '
        Me.RepositoryItemGridLookUpEditCargo2.AutoHeight = False
        Me.RepositoryItemGridLookUpEditCargo2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEditCargo2.Name = "RepositoryItemGridLookUpEditCargo2"
        Me.RepositoryItemGridLookUpEditCargo2.View = Me.GridViewCargo2
        '
        'GridViewCargo2
        '
        Me.GridViewCargo2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn29, Me.GridColumn30})
        Me.GridViewCargo2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewCargo2.Name = "GridViewCargo2"
        Me.GridViewCargo2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewCargo2.OptionsView.ShowAutoFilterRow = True
        Me.GridViewCargo2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn29
        '
        Me.GridColumn29.Caption = "IDCARGO"
        Me.GridColumn29.FieldName = "IDCARGO"
        Me.GridColumn29.Name = "GridColumn29"
        Me.GridColumn29.Width = 192
        '
        'GridColumn30
        '
        Me.GridColumn30.Caption = "CARGO"
        Me.GridColumn30.FieldName = "DESCRIPCION"
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn30.Visible = True
        Me.GridColumn30.VisibleIndex = 0
        Me.GridColumn30.Width = 120
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "FTE. RECLUTAMIENTO DET."
        Me.GridColumn28.ColumnEdit = Me.RepositoryItemGridLookUpEditFuenteDetalle
        Me.GridColumn28.FieldName = "IDFUENTEDETALLE"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn28.Visible = True
        Me.GridColumn28.VisibleIndex = 16
        Me.GridColumn28.Width = 150
        '
        'RepositoryItemGridLookUpEditFuenteDetalle
        '
        Me.RepositoryItemGridLookUpEditFuenteDetalle.AutoHeight = False
        Me.RepositoryItemGridLookUpEditFuenteDetalle.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEditFuenteDetalle.Name = "RepositoryItemGridLookUpEditFuenteDetalle"
        Me.RepositoryItemGridLookUpEditFuenteDetalle.View = Me.GridViewFuenteDetalle
        '
        'GridViewFuenteDetalle
        '
        Me.GridViewFuenteDetalle.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn39, Me.GridColumn40})
        Me.GridViewFuenteDetalle.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewFuenteDetalle.Name = "GridViewFuenteDetalle"
        Me.GridViewFuenteDetalle.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewFuenteDetalle.OptionsView.ShowAutoFilterRow = True
        Me.GridViewFuenteDetalle.OptionsView.ShowGroupPanel = False
        '
        'GridColumn39
        '
        Me.GridColumn39.Caption = "IDFUENTEDETALLE"
        Me.GridColumn39.FieldName = "IDFUENTEDETALLE"
        Me.GridColumn39.Name = "GridColumn39"
        '
        'GridColumn40
        '
        Me.GridColumn40.Caption = "FTE. RECLUTAMIENTO"
        Me.GridColumn40.FieldName = "DESCRIPCION"
        Me.GridColumn40.Name = "GridColumn40"
        Me.GridColumn40.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn40.Visible = True
        Me.GridColumn40.VisibleIndex = 0
        Me.GridColumn40.Width = 150
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "FTE. RECLUTAMIENTO"
        Me.GridColumn27.ColumnEdit = Me.RepositoryItemGridLookUpEditFuente
        Me.GridColumn27.FieldName = "IDFUENTE"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.OptionsColumn.AllowEdit = False
        Me.GridColumn27.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn27.Visible = True
        Me.GridColumn27.VisibleIndex = 17
        Me.GridColumn27.Width = 120
        '
        'RepositoryItemGridLookUpEditFuente
        '
        Me.RepositoryItemGridLookUpEditFuente.AutoHeight = False
        Me.RepositoryItemGridLookUpEditFuente.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEditFuente.Name = "RepositoryItemGridLookUpEditFuente"
        Me.RepositoryItemGridLookUpEditFuente.View = Me.GridViewFuente
        '
        'GridViewFuente
        '
        Me.GridViewFuente.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn37, Me.GridColumn38})
        Me.GridViewFuente.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewFuente.Name = "GridViewFuente"
        Me.GridViewFuente.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewFuente.OptionsView.ShowAutoFilterRow = True
        Me.GridViewFuente.OptionsView.ShowGroupPanel = False
        '
        'GridColumn37
        '
        Me.GridColumn37.Caption = "IDFUENTE"
        Me.GridColumn37.FieldName = "IDFUENTE"
        Me.GridColumn37.Name = "GridColumn37"
        '
        'GridColumn38
        '
        Me.GridColumn38.Caption = "FTE. RECLUTAMIENTO"
        Me.GridColumn38.FieldName = "DESCRIPCION"
        Me.GridColumn38.Name = "GridColumn38"
        Me.GridColumn38.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn38.Visible = True
        Me.GridColumn38.VisibleIndex = 0
        Me.GridColumn38.Width = 120
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "FEC. CONVOCATORIA"
        Me.GridColumn24.FieldName = "FECHACONVOCATORIA"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 18
        Me.GridColumn24.Width = 120
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "FEC. EVALUACION"
        Me.GridColumn25.FieldName = "FECHAEVALUACION"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 19
        Me.GridColumn25.Width = 120
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "CONCLUSION DET."
        Me.GridColumn22.ColumnEdit = Me.RepositoryItemGridLookUpEditConclusionDetalle
        Me.GridColumn22.FieldName = "IDCONCLUSIONDETALLE"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 20
        Me.GridColumn22.Width = 120
        '
        'RepositoryItemGridLookUpEditConclusionDetalle
        '
        Me.RepositoryItemGridLookUpEditConclusionDetalle.AutoHeight = False
        Me.RepositoryItemGridLookUpEditConclusionDetalle.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEditConclusionDetalle.Name = "RepositoryItemGridLookUpEditConclusionDetalle"
        Me.RepositoryItemGridLookUpEditConclusionDetalle.View = Me.GridViewConclusionDetalle
        '
        'GridViewConclusionDetalle
        '
        Me.GridViewConclusionDetalle.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn35, Me.GridColumn36})
        Me.GridViewConclusionDetalle.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewConclusionDetalle.Name = "GridViewConclusionDetalle"
        Me.GridViewConclusionDetalle.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewConclusionDetalle.OptionsView.ShowAutoFilterRow = True
        Me.GridViewConclusionDetalle.OptionsView.ShowGroupPanel = False
        '
        'GridColumn35
        '
        Me.GridColumn35.Caption = "IDCONCLUSIONDETALLE"
        Me.GridColumn35.FieldName = "IDCONCLUSIONDETALLE"
        Me.GridColumn35.Name = "GridColumn35"
        '
        'GridColumn36
        '
        Me.GridColumn36.Caption = "CONCLUSION DETALLE"
        Me.GridColumn36.FieldName = "DESCRIPCION"
        Me.GridColumn36.Name = "GridColumn36"
        Me.GridColumn36.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn36.Visible = True
        Me.GridColumn36.VisibleIndex = 0
        Me.GridColumn36.Width = 150
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "CONCLUSION"
        Me.GridColumn21.ColumnEdit = Me.RepositoryItemGridLookUpEditConclusion
        Me.GridColumn21.FieldName = "IDCONCLUSION"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.AllowEdit = False
        Me.GridColumn21.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 21
        Me.GridColumn21.Width = 120
        '
        'RepositoryItemGridLookUpEditConclusion
        '
        Me.RepositoryItemGridLookUpEditConclusion.AutoHeight = False
        Me.RepositoryItemGridLookUpEditConclusion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEditConclusion.Name = "RepositoryItemGridLookUpEditConclusion"
        Me.RepositoryItemGridLookUpEditConclusion.View = Me.GridViewConclusion
        '
        'GridViewConclusion
        '
        Me.GridViewConclusion.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn33, Me.GridColumn34})
        Me.GridViewConclusion.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewConclusion.Name = "GridViewConclusion"
        Me.GridViewConclusion.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewConclusion.OptionsView.ShowAutoFilterRow = True
        Me.GridViewConclusion.OptionsView.ShowGroupPanel = False
        '
        'GridColumn33
        '
        Me.GridColumn33.Caption = "IDCONCLUSION"
        Me.GridColumn33.FieldName = "IDCONCLUSION"
        Me.GridColumn33.Name = "GridColumn33"
        '
        'GridColumn34
        '
        Me.GridColumn34.Caption = "CONCLUSION"
        Me.GridColumn34.FieldName = "DESCRIPCION"
        Me.GridColumn34.Name = "GridColumn34"
        Me.GridColumn34.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn34.Visible = True
        Me.GridColumn34.VisibleIndex = 0
        Me.GridColumn34.Width = 120
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "OBSERVACION"
        Me.GridColumn26.FieldName = "OBSERVACION"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 22
        Me.GridColumn26.Width = 150
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "TIENDA"
        Me.GridColumn23.ColumnEdit = Me.RepositoryItemGridLookUpEditTienda
        Me.GridColumn23.FieldName = "IDTIENDA"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 23
        Me.GridColumn23.Width = 160
        '
        'RepositoryItemGridLookUpEditTienda
        '
        Me.RepositoryItemGridLookUpEditTienda.AutoHeight = False
        Me.RepositoryItemGridLookUpEditTienda.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEditTienda.Name = "RepositoryItemGridLookUpEditTienda"
        Me.RepositoryItemGridLookUpEditTienda.View = Me.GridViewTienda
        '
        'GridViewTienda
        '
        Me.GridViewTienda.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn31, Me.GridColumn32, Me.GridColumn44, Me.GridColumn45})
        Me.GridViewTienda.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewTienda.Name = "GridViewTienda"
        Me.GridViewTienda.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewTienda.OptionsView.ShowAutoFilterRow = True
        Me.GridViewTienda.OptionsView.ShowGroupPanel = False
        '
        'GridColumn31
        '
        Me.GridColumn31.Caption = "IDLOCAL"
        Me.GridColumn31.FieldName = "IDLOCAL"
        Me.GridColumn31.Name = "GridColumn31"
        '
        'GridColumn32
        '
        Me.GridColumn32.Caption = "LOCAL"
        Me.GridColumn32.FieldName = "LOCAL"
        Me.GridColumn32.Name = "GridColumn32"
        Me.GridColumn32.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn32.Visible = True
        Me.GridColumn32.VisibleIndex = 0
        Me.GridColumn32.Width = 192
        '
        'GridColumn44
        '
        Me.GridColumn44.Caption = "RAZON SOCIAL"
        Me.GridColumn44.FieldName = "RAZONSOCIAL"
        Me.GridColumn44.Name = "GridColumn44"
        Me.GridColumn44.Visible = True
        Me.GridColumn44.VisibleIndex = 1
        Me.GridColumn44.Width = 150
        '
        'GridColumn45
        '
        Me.GridColumn45.Caption = "CORREO"
        Me.GridColumn45.FieldName = "CORREOELECTRONICO"
        Me.GridColumn45.Name = "GridColumn45"
        Me.GridColumn45.Visible = True
        Me.GridColumn45.VisibleIndex = 2
        Me.GridColumn45.Width = 150
        '
        'GridColumn50
        '
        Me.GridColumn50.Caption = "TURNO"
        Me.GridColumn50.ColumnEdit = Me.RepositoryItemGridLookUpEditTurno
        Me.GridColumn50.FieldName = "IDTURNO"
        Me.GridColumn50.Name = "GridColumn50"
        Me.GridColumn50.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn50.Visible = True
        Me.GridColumn50.VisibleIndex = 24
        Me.GridColumn50.Width = 100
        '
        'RepositoryItemGridLookUpEditTurno
        '
        Me.RepositoryItemGridLookUpEditTurno.AutoHeight = False
        Me.RepositoryItemGridLookUpEditTurno.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEditTurno.Name = "RepositoryItemGridLookUpEditTurno"
        Me.RepositoryItemGridLookUpEditTurno.View = Me.GridViewTurno
        '
        'GridViewTurno
        '
        Me.GridViewTurno.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn51, Me.GridColumn53})
        Me.GridViewTurno.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewTurno.Name = "GridViewTurno"
        Me.GridViewTurno.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewTurno.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridViewTurno.OptionsView.ShowGroupPanel = False
        '
        'GridColumn51
        '
        Me.GridColumn51.Caption = "IDTURNO"
        Me.GridColumn51.FieldName = "IDTURNO"
        Me.GridColumn51.Name = "GridColumn51"
        '
        'GridColumn53
        '
        Me.GridColumn53.Caption = "TURNO"
        Me.GridColumn53.FieldName = "DESCRIPCION"
        Me.GridColumn53.Name = "GridColumn53"
        Me.GridColumn53.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn53.Visible = True
        Me.GridColumn53.VisibleIndex = 0
        Me.GridColumn53.Width = 120
        '
        'GridColumn49
        '
        Me.GridColumn49.Caption = "FEC. FIRMA CONTRATO"
        Me.GridColumn49.FieldName = "FECHAFIRMACONTRATO"
        Me.GridColumn49.Name = "GridColumn49"
        Me.GridColumn49.Visible = True
        Me.GridColumn49.VisibleIndex = 25
        Me.GridColumn49.Width = 160
        '
        'GridColumn47
        '
        Me.GridColumn47.Caption = "FEC. ING. TIENDA PROGRAMADO"
        Me.GridColumn47.FieldName = "FECHAINGRESOTIENDAPROGRAMADO"
        Me.GridColumn47.Name = "GridColumn47"
        Me.GridColumn47.Visible = True
        Me.GridColumn47.VisibleIndex = 26
        Me.GridColumn47.Width = 180
        '
        'GridColumn46
        '
        Me.GridColumn46.Caption = "FEC. RESPUESTA CORREO"
        Me.GridColumn46.FieldName = "FECHARESPUESTACORREO"
        Me.GridColumn46.Name = "GridColumn46"
        Me.GridColumn46.Visible = True
        Me.GridColumn46.VisibleIndex = 27
        Me.GridColumn46.Width = 160
        '
        'RepositoryItemCheckEditAsignacion
        '
        Me.RepositoryItemCheckEditAsignacion.AutoHeight = False
        Me.RepositoryItemCheckEditAsignacion.Name = "RepositoryItemCheckEditAsignacion"
        '
        'RepositoryItemGridLookUpEditCondicionActual
        '
        Me.RepositoryItemGridLookUpEditCondicionActual.AutoHeight = False
        Me.RepositoryItemGridLookUpEditCondicionActual.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEditCondicionActual.Name = "RepositoryItemGridLookUpEditCondicionActual"
        Me.RepositoryItemGridLookUpEditCondicionActual.View = Me.GridViewCondicionActual
        '
        'GridViewCondicionActual
        '
        Me.GridViewCondicionActual.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn54, Me.GridColumn55})
        Me.GridViewCondicionActual.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewCondicionActual.Name = "GridViewCondicionActual"
        Me.GridViewCondicionActual.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewCondicionActual.OptionsView.ShowAutoFilterRow = True
        Me.GridViewCondicionActual.OptionsView.ShowGroupPanel = False
        '
        'GridColumn54
        '
        Me.GridColumn54.Caption = "IDCONDICIONACTUAL"
        Me.GridColumn54.FieldName = "IDCONDICIONACTUAL"
        Me.GridColumn54.Name = "GridColumn54"
        '
        'GridColumn55
        '
        Me.GridColumn55.Caption = "CONDICION ACTUAL"
        Me.GridColumn55.FieldName = "DESCRIPCION"
        Me.GridColumn55.Name = "GridColumn55"
        Me.GridColumn55.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn55.Visible = True
        Me.GridColumn55.VisibleIndex = 0
        Me.GridColumn55.Width = 120
        '
        'RQMasivosPostulantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 520)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "RQMasivosPostulantes"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "POSTULANTES MASIVOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEditAsignar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditTipoIdentidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewTipoIdentidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditDistrito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewDistrito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditSexo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSexo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditCargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditCargo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCargo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditFuenteDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewFuenteDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditFuente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewFuente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditConclusionDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewConclusionDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditConclusion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewConclusion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditTienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewTienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditTurno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewTurno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEditAsignacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditCondicionActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCondicionActual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn63 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEditAsignar As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEditTipoIdentidad As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewTipoIdentidad As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn42 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn43 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEditDistrito As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewDistrito As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn41 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn56 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn57 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn58 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn59 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn60 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn61 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEditSexo As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewSexo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEditCargo As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewCargo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEditCargo2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewCargo2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEditFuenteDetalle As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewFuenteDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn39 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn40 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEditFuente As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewFuente As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn38 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEditConclusionDetalle As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewConclusionDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEditConclusion As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewConclusion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEditTienda As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewTienda As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn44 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn45 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEditTurno As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewTurno As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn51 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn53 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn49 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn47 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn46 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEditAsignacion As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemGridLookUpEditCondicionActual As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewCondicionActual As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn54 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn55 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRefrescar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEnviarCorreo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnProcesar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAsignarPostulante As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtLocalSolicitante As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtCargoRequerido As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtRazonComercial As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents txtPuestoRequerido As DevExpress.XtraBars.BarStaticItem
End Class
