<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LicenciaEnfermedadList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LicenciaEnfermedadList))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnRefrescar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExportarSolicitantes = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.IDLICENCIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.APROBAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemAprobar = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ANULAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemAnular = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.SUSTENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSustentoArchivo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.VERDETALLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemVista = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.NUMERODOCUMENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.APELLIDOPATERNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.APELLIDOMATERNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NOMBRES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TELEFONO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NUMEROSOLICITUD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PUESTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RAZONCOMERCIAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RAZONSOCIAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDLICENCIATIPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEditTipoLicencia = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewTipoLicencia = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.IDPROCEDENCIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEditProcedencia = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewProcedencia = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NUMERODESCANSOMEDICO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDMOTIVOENFERMEDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEditMotivo = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewMotivo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.IDSUBGRUPOFAMILIAENFERMEDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEditDiagnosticoGrupo = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewDiagnosticoGrupo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SUBGRUPOFAMILIAENFERMEDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHAPERIODOINICIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEditFechaInicio = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.FECHAPERIODOFIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEditFechaFin = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.CANTIDADDIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDMESEVALUACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEditMesEvaluacion = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewMesEvaluacion = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ESTADOPAGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEditEstadoEnfermedad = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.DESCRIPCIONESTADOPAGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DECLARACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEditDeclaracion = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.DIASSUBSIDIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DIASRECUPERADOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DIASANULADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DESCRIPCIONDECLARACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NITESSALUD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHARECEPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEditFechaRecepcion = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.IDTIPOOBSERVACIONENFERMEDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEditObservacion = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewObservacion = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DETALLEDESCANSOMEDICO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDBANCO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEditBanco = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewBanco = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NUMEROCHEQUE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MONTOSUBSIDIADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CONTABILIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDEMPLEADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemAcuerdoArchivo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemGridLookUpEditDiagnosticoSubGrupo = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewDiagnosticoSubGrupo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEditAsignar = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.MATRICULA = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemAprobar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemAnular, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSustentoArchivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemVista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditTipoLicencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewTipoLicencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditProcedencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewProcedencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditMotivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewMotivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditDiagnosticoGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewDiagnosticoGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEditFechaInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEditFechaInicio.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEditFechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEditFechaFin.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditMesEvaluacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewMesEvaluacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEditEstadoEnfermedad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEditDeclaracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEditFechaRecepcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEditFechaRecepcion.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditObservacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewObservacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemAcuerdoArchivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditDiagnosticoSubGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewDiagnosticoSubGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEditAsignar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnRefrescar, Me.btnCerrar, Me.btnExportarSolicitantes})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 6
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(983, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Caption = "Refrescar"
        Me.btnRefrescar.Glyph = CType(resources.GetObject("btnRefrescar.Glyph"), System.Drawing.Image)
        Me.btnRefrescar.Id = 2
        Me.btnRefrescar.LargeGlyph = CType(resources.GetObject("btnRefrescar.LargeGlyph"), System.Drawing.Image)
        Me.btnRefrescar.Name = "btnRefrescar"
        '
        'btnCerrar
        '
        Me.btnCerrar.Caption = "Cerrar"
        Me.btnCerrar.Glyph = CType(resources.GetObject("btnCerrar.Glyph"), System.Drawing.Image)
        Me.btnCerrar.Id = 3
        Me.btnCerrar.LargeGlyph = CType(resources.GetObject("btnCerrar.LargeGlyph"), System.Drawing.Image)
        Me.btnCerrar.Name = "btnCerrar"
        '
        'btnExportarSolicitantes
        '
        Me.btnExportarSolicitantes.Caption = "Exportar Solicitudes"
        Me.btnExportarSolicitantes.Glyph = CType(resources.GetObject("btnExportarSolicitantes.Glyph"), System.Drawing.Image)
        Me.btnExportarSolicitantes.Id = 5
        Me.btnExportarSolicitantes.LargeGlyph = CType(resources.GetObject("btnExportarSolicitantes.LargeGlyph"), System.Drawing.Image)
        Me.btnExportarSolicitantes.Name = "btnExportarSolicitantes"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Licencia Enferemedad Accidente"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnRefrescar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnExportarSolicitantes)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 418)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(983, 31)
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
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemAcuerdoArchivo, Me.RepositoryItemSustentoArchivo, Me.RepositoryItemGridLookUpEditProcedencia, Me.RepositoryItemGridLookUpEditMotivo, Me.RepositoryItemGridLookUpEditDiagnosticoGrupo, Me.RepositoryItemGridLookUpEditDiagnosticoSubGrupo, Me.RepositoryItemDateEditFechaInicio, Me.RepositoryItemDateEditFechaFin, Me.RepositoryItemGridLookUpEditMesEvaluacion, Me.RepositoryItemCheckEditEstadoEnfermedad, Me.RepositoryItemCheckEditDeclaracion, Me.RepositoryItemDateEditFechaRecepcion, Me.RepositoryItemGridLookUpEditObservacion, Me.RepositoryItemGridLookUpEditBanco, Me.RepositoryItemCheckEditAsignar, Me.RepositoryItemAprobar, Me.RepositoryItemAnular, Me.RepositoryItemGridLookUpEditTipoLicencia, Me.RepositoryItemVista})
        Me.GridControl1.Size = New System.Drawing.Size(983, 275)
        Me.GridControl1.TabIndex = 14
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.APROBAR, Me.ANULAR, Me.SUSTENTO, Me.VERDETALLE, Me.MATRICULA, Me.NUMERODOCUMENTO, Me.APELLIDOPATERNO, Me.APELLIDOMATERNO, Me.NOMBRES, Me.TELEFONO, Me.NUMEROSOLICITUD, Me.FECHA, Me.PUESTO, Me.RAZONCOMERCIAL, Me.RAZONSOCIAL, Me.IDLICENCIATIPO, Me.IDPROCEDENCIA, Me.NUMERODESCANSOMEDICO, Me.IDMOTIVOENFERMEDAD, Me.IDSUBGRUPOFAMILIAENFERMEDAD, Me.SUBGRUPOFAMILIAENFERMEDAD, Me.FECHAPERIODOINICIO, Me.FECHAPERIODOFIN, Me.CANTIDADDIAS, Me.IDMESEVALUACION, Me.ESTADOPAGO, Me.DESCRIPCIONESTADOPAGO, Me.DECLARACION, Me.DIASSUBSIDIO, Me.DIASRECUPERADOS, Me.DIASANULADO, Me.DESCRIPCIONDECLARACION, Me.NITESSALUD, Me.FECHARECEPCION, Me.IDTIPOOBSERVACIONENFERMEDAD, Me.DETALLEDESCANSOMEDICO, Me.IDBANCO, Me.NUMEROCHEQUE, Me.MONTOSUBSIDIADO, Me.CONTABILIDAD, Me.IDLICENCIA, Me.IDEMPLEADO})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: [#image] {1} {2}"
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", Nothing, "(Count={0})")})
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        '
        'IDLICENCIA
        '
        Me.IDLICENCIA.Caption = "ID"
        Me.IDLICENCIA.FieldName = "IDLICENCIA"
        Me.IDLICENCIA.Name = "IDLICENCIA"
        Me.IDLICENCIA.OptionsColumn.AllowEdit = False
        '
        'APROBAR
        '
        Me.APROBAR.Caption = "APROBAR"
        Me.APROBAR.ColumnEdit = Me.RepositoryItemAprobar
        Me.APROBAR.FieldName = "APROBAR"
        Me.APROBAR.MinWidth = 15
        Me.APROBAR.Name = "APROBAR"
        Me.APROBAR.Visible = True
        Me.APROBAR.VisibleIndex = 0
        Me.APROBAR.Width = 60
        '
        'RepositoryItemAprobar
        '
        Me.RepositoryItemAprobar.AutoHeight = False
        Me.RepositoryItemAprobar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemAprobar.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.RepositoryItemAprobar.Name = "RepositoryItemAprobar"
        Me.RepositoryItemAprobar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
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
        Me.RepositoryItemAnular.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemAnular.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.RepositoryItemAnular.Name = "RepositoryItemAnular"
        Me.RepositoryItemAnular.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'SUSTENTO
        '
        Me.SUSTENTO.Caption = "SUSTENTO"
        Me.SUSTENTO.ColumnEdit = Me.RepositoryItemSustentoArchivo
        Me.SUSTENTO.FieldName = "SUSTENTO"
        Me.SUSTENTO.MinWidth = 15
        Me.SUSTENTO.Name = "SUSTENTO"
        Me.SUSTENTO.Visible = True
        Me.SUSTENTO.VisibleIndex = 2
        Me.SUSTENTO.Width = 60
        '
        'RepositoryItemSustentoArchivo
        '
        Me.RepositoryItemSustentoArchivo.AutoHeight = False
        Me.RepositoryItemSustentoArchivo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemSustentoArchivo.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.RepositoryItemSustentoArchivo.Name = "RepositoryItemSustentoArchivo"
        Me.RepositoryItemSustentoArchivo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'VERDETALLE
        '
        Me.VERDETALLE.Caption = "VER DETALLE"
        Me.VERDETALLE.ColumnEdit = Me.RepositoryItemVista
        Me.VERDETALLE.FieldName = "VERDETALLE"
        Me.VERDETALLE.Name = "VERDETALLE"
        Me.VERDETALLE.Visible = True
        Me.VERDETALLE.VisibleIndex = 3
        '
        'RepositoryItemVista
        '
        Me.RepositoryItemVista.AutoHeight = False
        Me.RepositoryItemVista.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemVista.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.RepositoryItemVista.Name = "RepositoryItemVista"
        Me.RepositoryItemVista.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'NUMERODOCUMENTO
        '
        Me.NUMERODOCUMENTO.Caption = "N°DOCUMENTO"
        Me.NUMERODOCUMENTO.FieldName = "NUMERODOCUMENTO"
        Me.NUMERODOCUMENTO.Name = "NUMERODOCUMENTO"
        Me.NUMERODOCUMENTO.OptionsColumn.AllowEdit = False
        Me.NUMERODOCUMENTO.Visible = True
        Me.NUMERODOCUMENTO.VisibleIndex = 5
        '
        'APELLIDOPATERNO
        '
        Me.APELLIDOPATERNO.Caption = "APE. PATERNO"
        Me.APELLIDOPATERNO.FieldName = "APELLIDOPATERNO"
        Me.APELLIDOPATERNO.Name = "APELLIDOPATERNO"
        Me.APELLIDOPATERNO.OptionsColumn.AllowEdit = False
        Me.APELLIDOPATERNO.Visible = True
        Me.APELLIDOPATERNO.VisibleIndex = 6
        '
        'APELLIDOMATERNO
        '
        Me.APELLIDOMATERNO.Caption = "APE. MATERNO"
        Me.APELLIDOMATERNO.FieldName = "APELLIDOMATERNO"
        Me.APELLIDOMATERNO.Name = "APELLIDOMATERNO"
        Me.APELLIDOMATERNO.OptionsColumn.AllowEdit = False
        Me.APELLIDOMATERNO.Visible = True
        Me.APELLIDOMATERNO.VisibleIndex = 7
        '
        'NOMBRES
        '
        Me.NOMBRES.Caption = "NOMBRES"
        Me.NOMBRES.FieldName = "NOMBRES"
        Me.NOMBRES.Name = "NOMBRES"
        Me.NOMBRES.OptionsColumn.AllowEdit = False
        Me.NOMBRES.Visible = True
        Me.NOMBRES.VisibleIndex = 8
        Me.NOMBRES.Width = 100
        '
        'TELEFONO
        '
        Me.TELEFONO.Caption = "N° TELÉFONO"
        Me.TELEFONO.FieldName = "TELEFONO"
        Me.TELEFONO.Name = "TELEFONO"
        Me.TELEFONO.OptionsColumn.AllowEdit = False
        Me.TELEFONO.Visible = True
        Me.TELEFONO.VisibleIndex = 9
        Me.TELEFONO.Width = 90
        '
        'NUMEROSOLICITUD
        '
        Me.NUMEROSOLICITUD.Caption = "NÚMERO SOLICITUD"
        Me.NUMEROSOLICITUD.FieldName = "NUMEROSOLICITUD"
        Me.NUMEROSOLICITUD.Name = "NUMEROSOLICITUD"
        Me.NUMEROSOLICITUD.OptionsColumn.AllowEdit = False
        Me.NUMEROSOLICITUD.Visible = True
        Me.NUMEROSOLICITUD.VisibleIndex = 10
        Me.NUMEROSOLICITUD.Width = 120
        '
        'FECHA
        '
        Me.FECHA.Caption = "FECHA SOLICITUD"
        Me.FECHA.FieldName = "FECHA"
        Me.FECHA.Name = "FECHA"
        Me.FECHA.OptionsColumn.AllowEdit = False
        Me.FECHA.Visible = True
        Me.FECHA.VisibleIndex = 11
        Me.FECHA.Width = 110
        '
        'PUESTO
        '
        Me.PUESTO.Caption = "PUESTO"
        Me.PUESTO.FieldName = "PUESTO"
        Me.PUESTO.Name = "PUESTO"
        Me.PUESTO.OptionsColumn.AllowEdit = False
        Me.PUESTO.Visible = True
        Me.PUESTO.VisibleIndex = 12
        Me.PUESTO.Width = 120
        '
        'RAZONCOMERCIAL
        '
        Me.RAZONCOMERCIAL.Caption = "TIENDA"
        Me.RAZONCOMERCIAL.FieldName = "RAZONCOMERCIAL"
        Me.RAZONCOMERCIAL.Name = "RAZONCOMERCIAL"
        Me.RAZONCOMERCIAL.OptionsColumn.AllowEdit = False
        Me.RAZONCOMERCIAL.Visible = True
        Me.RAZONCOMERCIAL.VisibleIndex = 13
        Me.RAZONCOMERCIAL.Width = 120
        '
        'RAZONSOCIAL
        '
        Me.RAZONSOCIAL.Caption = "RAZÓN SOCIAL"
        Me.RAZONSOCIAL.FieldName = "RAZONSOCIAL"
        Me.RAZONSOCIAL.Name = "RAZONSOCIAL"
        Me.RAZONSOCIAL.OptionsColumn.AllowEdit = False
        Me.RAZONSOCIAL.Visible = True
        Me.RAZONSOCIAL.VisibleIndex = 14
        Me.RAZONSOCIAL.Width = 120
        '
        'IDLICENCIATIPO
        '
        Me.IDLICENCIATIPO.Caption = "IIPO DE LICENCIA"
        Me.IDLICENCIATIPO.ColumnEdit = Me.RepositoryItemGridLookUpEditTipoLicencia
        Me.IDLICENCIATIPO.FieldName = "IDLICENCIATIPO"
        Me.IDLICENCIATIPO.Name = "IDLICENCIATIPO"
        Me.IDLICENCIATIPO.Visible = True
        Me.IDLICENCIATIPO.VisibleIndex = 15
        Me.IDLICENCIATIPO.Width = 320
        '
        'RepositoryItemGridLookUpEditTipoLicencia
        '
        Me.RepositoryItemGridLookUpEditTipoLicencia.AutoHeight = False
        Me.RepositoryItemGridLookUpEditTipoLicencia.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEditTipoLicencia.Name = "RepositoryItemGridLookUpEditTipoLicencia"
        Me.RepositoryItemGridLookUpEditTipoLicencia.View = Me.GridViewTipoLicencia
        '
        'GridViewTipoLicencia
        '
        Me.GridViewTipoLicencia.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewTipoLicencia.Name = "GridViewTipoLicencia"
        Me.GridViewTipoLicencia.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewTipoLicencia.OptionsView.ShowGroupPanel = False
        '
        'IDPROCEDENCIA
        '
        Me.IDPROCEDENCIA.Caption = "PROCEDENCIA"
        Me.IDPROCEDENCIA.ColumnEdit = Me.RepositoryItemGridLookUpEditProcedencia
        Me.IDPROCEDENCIA.FieldName = "IDPROCEDENCIA"
        Me.IDPROCEDENCIA.Name = "IDPROCEDENCIA"
        Me.IDPROCEDENCIA.Visible = True
        Me.IDPROCEDENCIA.VisibleIndex = 16
        Me.IDPROCEDENCIA.Width = 100
        '
        'RepositoryItemGridLookUpEditProcedencia
        '
        Me.RepositoryItemGridLookUpEditProcedencia.AutoHeight = False
        Me.RepositoryItemGridLookUpEditProcedencia.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEditProcedencia.Name = "RepositoryItemGridLookUpEditProcedencia"
        Me.RepositoryItemGridLookUpEditProcedencia.View = Me.GridViewProcedencia
        '
        'GridViewProcedencia
        '
        Me.GridViewProcedencia.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewProcedencia.Name = "GridViewProcedencia"
        Me.GridViewProcedencia.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewProcedencia.OptionsView.ShowGroupPanel = False
        '
        'NUMERODESCANSOMEDICO
        '
        Me.NUMERODESCANSOMEDICO.Caption = "N°"
        Me.NUMERODESCANSOMEDICO.FieldName = "NUMERODESCANSOMEDICO"
        Me.NUMERODESCANSOMEDICO.Name = "NUMERODESCANSOMEDICO"
        Me.NUMERODESCANSOMEDICO.Visible = True
        Me.NUMERODESCANSOMEDICO.VisibleIndex = 17
        Me.NUMERODESCANSOMEDICO.Width = 120
        '
        'IDMOTIVOENFERMEDAD
        '
        Me.IDMOTIVOENFERMEDAD.Caption = "MOTIVO"
        Me.IDMOTIVOENFERMEDAD.ColumnEdit = Me.RepositoryItemGridLookUpEditMotivo
        Me.IDMOTIVOENFERMEDAD.FieldName = "IDMOTIVOENFERMEDAD"
        Me.IDMOTIVOENFERMEDAD.Name = "IDMOTIVOENFERMEDAD"
        Me.IDMOTIVOENFERMEDAD.Visible = True
        Me.IDMOTIVOENFERMEDAD.VisibleIndex = 18
        Me.IDMOTIVOENFERMEDAD.Width = 150
        '
        'RepositoryItemGridLookUpEditMotivo
        '
        Me.RepositoryItemGridLookUpEditMotivo.AutoHeight = False
        Me.RepositoryItemGridLookUpEditMotivo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEditMotivo.Name = "RepositoryItemGridLookUpEditMotivo"
        Me.RepositoryItemGridLookUpEditMotivo.View = Me.GridViewMotivo
        '
        'GridViewMotivo
        '
        Me.GridViewMotivo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewMotivo.Name = "GridViewMotivo"
        Me.GridViewMotivo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewMotivo.OptionsView.ShowAutoFilterRow = True
        Me.GridViewMotivo.OptionsView.ShowGroupPanel = False
        '
        'IDSUBGRUPOFAMILIAENFERMEDAD
        '
        Me.IDSUBGRUPOFAMILIAENFERMEDAD.Caption = "DIAGNÓSTICO"
        Me.IDSUBGRUPOFAMILIAENFERMEDAD.ColumnEdit = Me.RepositoryItemGridLookUpEditDiagnosticoGrupo
        Me.IDSUBGRUPOFAMILIAENFERMEDAD.FieldName = "IDSUBGRUPOFAMILIAENFERMEDAD"
        Me.IDSUBGRUPOFAMILIAENFERMEDAD.Name = "IDSUBGRUPOFAMILIAENFERMEDAD"
        Me.IDSUBGRUPOFAMILIAENFERMEDAD.Visible = True
        Me.IDSUBGRUPOFAMILIAENFERMEDAD.VisibleIndex = 19
        Me.IDSUBGRUPOFAMILIAENFERMEDAD.Width = 250
        '
        'RepositoryItemGridLookUpEditDiagnosticoGrupo
        '
        Me.RepositoryItemGridLookUpEditDiagnosticoGrupo.AutoHeight = False
        Me.RepositoryItemGridLookUpEditDiagnosticoGrupo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEditDiagnosticoGrupo.Name = "RepositoryItemGridLookUpEditDiagnosticoGrupo"
        Me.RepositoryItemGridLookUpEditDiagnosticoGrupo.View = Me.GridViewDiagnosticoGrupo
        '
        'GridViewDiagnosticoGrupo
        '
        Me.GridViewDiagnosticoGrupo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewDiagnosticoGrupo.Name = "GridViewDiagnosticoGrupo"
        Me.GridViewDiagnosticoGrupo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewDiagnosticoGrupo.OptionsView.ShowAutoFilterRow = True
        Me.GridViewDiagnosticoGrupo.OptionsView.ShowGroupPanel = False
        '
        'SUBGRUPOFAMILIAENFERMEDAD
        '
        Me.SUBGRUPOFAMILIAENFERMEDAD.Caption = "SUB GRUPO ENFERMEDAD"
        Me.SUBGRUPOFAMILIAENFERMEDAD.FieldName = "SUBGRUPOFAMILIAENFERMEDAD"
        Me.SUBGRUPOFAMILIAENFERMEDAD.Name = "SUBGRUPOFAMILIAENFERMEDAD"
        Me.SUBGRUPOFAMILIAENFERMEDAD.OptionsColumn.AllowEdit = False
        Me.SUBGRUPOFAMILIAENFERMEDAD.Visible = True
        Me.SUBGRUPOFAMILIAENFERMEDAD.VisibleIndex = 20
        Me.SUBGRUPOFAMILIAENFERMEDAD.Width = 250
        '
        'FECHAPERIODOINICIO
        '
        Me.FECHAPERIODOINICIO.Caption = "F. INICIAL"
        Me.FECHAPERIODOINICIO.ColumnEdit = Me.RepositoryItemDateEditFechaInicio
        Me.FECHAPERIODOINICIO.FieldName = "FECHAPERIODOINICIO"
        Me.FECHAPERIODOINICIO.Name = "FECHAPERIODOINICIO"
        Me.FECHAPERIODOINICIO.Visible = True
        Me.FECHAPERIODOINICIO.VisibleIndex = 21
        Me.FECHAPERIODOINICIO.Width = 90
        '
        'RepositoryItemDateEditFechaInicio
        '
        Me.RepositoryItemDateEditFechaInicio.AutoHeight = False
        Me.RepositoryItemDateEditFechaInicio.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEditFechaInicio.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEditFechaInicio.Name = "RepositoryItemDateEditFechaInicio"
        '
        'FECHAPERIODOFIN
        '
        Me.FECHAPERIODOFIN.Caption = "F. FINAL"
        Me.FECHAPERIODOFIN.ColumnEdit = Me.RepositoryItemDateEditFechaFin
        Me.FECHAPERIODOFIN.FieldName = "FECHAPERIODOFIN"
        Me.FECHAPERIODOFIN.Name = "FECHAPERIODOFIN"
        Me.FECHAPERIODOFIN.Visible = True
        Me.FECHAPERIODOFIN.VisibleIndex = 22
        Me.FECHAPERIODOFIN.Width = 90
        '
        'RepositoryItemDateEditFechaFin
        '
        Me.RepositoryItemDateEditFechaFin.AutoHeight = False
        Me.RepositoryItemDateEditFechaFin.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEditFechaFin.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEditFechaFin.Name = "RepositoryItemDateEditFechaFin"
        '
        'CANTIDADDIAS
        '
        Me.CANTIDADDIAS.Caption = "DÍAS DM"
        Me.CANTIDADDIAS.FieldName = "CANTIDADDIAS"
        Me.CANTIDADDIAS.Name = "CANTIDADDIAS"
        Me.CANTIDADDIAS.OptionsColumn.AllowEdit = False
        Me.CANTIDADDIAS.Visible = True
        Me.CANTIDADDIAS.VisibleIndex = 23
        '
        'IDMESEVALUACION
        '
        Me.IDMESEVALUACION.Caption = "MES"
        Me.IDMESEVALUACION.ColumnEdit = Me.RepositoryItemGridLookUpEditMesEvaluacion
        Me.IDMESEVALUACION.FieldName = "IDMESEVALUACION"
        Me.IDMESEVALUACION.Name = "IDMESEVALUACION"
        Me.IDMESEVALUACION.Visible = True
        Me.IDMESEVALUACION.VisibleIndex = 24
        '
        'RepositoryItemGridLookUpEditMesEvaluacion
        '
        Me.RepositoryItemGridLookUpEditMesEvaluacion.AutoHeight = False
        Me.RepositoryItemGridLookUpEditMesEvaluacion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEditMesEvaluacion.Name = "RepositoryItemGridLookUpEditMesEvaluacion"
        Me.RepositoryItemGridLookUpEditMesEvaluacion.View = Me.GridViewMesEvaluacion
        '
        'GridViewMesEvaluacion
        '
        Me.GridViewMesEvaluacion.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewMesEvaluacion.Name = "GridViewMesEvaluacion"
        Me.GridViewMesEvaluacion.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewMesEvaluacion.OptionsView.ShowAutoFilterRow = True
        Me.GridViewMesEvaluacion.OptionsView.ShowGroupPanel = False
        '
        'ESTADOPAGO
        '
        Me.ESTADOPAGO.Caption = "ESTADO"
        Me.ESTADOPAGO.ColumnEdit = Me.RepositoryItemCheckEditEstadoEnfermedad
        Me.ESTADOPAGO.FieldName = "ESTADOPAGO"
        Me.ESTADOPAGO.Name = "ESTADOPAGO"
        Me.ESTADOPAGO.Visible = True
        Me.ESTADOPAGO.VisibleIndex = 25
        '
        'RepositoryItemCheckEditEstadoEnfermedad
        '
        Me.RepositoryItemCheckEditEstadoEnfermedad.AutoHeight = False
        Me.RepositoryItemCheckEditEstadoEnfermedad.Name = "RepositoryItemCheckEditEstadoEnfermedad"
        '
        'DESCRIPCIONESTADOPAGO
        '
        Me.DESCRIPCIONESTADOPAGO.Caption = "ESTADO"
        Me.DESCRIPCIONESTADOPAGO.FieldName = "DESCRIPCIONESTADOPAGO"
        Me.DESCRIPCIONESTADOPAGO.Name = "DESCRIPCIONESTADOPAGO"
        Me.DESCRIPCIONESTADOPAGO.Visible = True
        Me.DESCRIPCIONESTADOPAGO.VisibleIndex = 26
        '
        'DECLARACION
        '
        Me.DECLARACION.Caption = "DECLARACIÓN"
        Me.DECLARACION.ColumnEdit = Me.RepositoryItemCheckEditDeclaracion
        Me.DECLARACION.FieldName = "DECLARACION"
        Me.DECLARACION.Name = "DECLARACION"
        Me.DECLARACION.Visible = True
        Me.DECLARACION.VisibleIndex = 27
        '
        'RepositoryItemCheckEditDeclaracion
        '
        Me.RepositoryItemCheckEditDeclaracion.AutoHeight = False
        Me.RepositoryItemCheckEditDeclaracion.Name = "RepositoryItemCheckEditDeclaracion"
        '
        'DIASSUBSIDIO
        '
        Me.DIASSUBSIDIO.Caption = "DÍAS SUB."
        Me.DIASSUBSIDIO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DIASSUBSIDIO.FieldName = "DIASSUBSIDIO"
        Me.DIASSUBSIDIO.Name = "DIASSUBSIDIO"
        Me.DIASSUBSIDIO.Visible = True
        Me.DIASSUBSIDIO.VisibleIndex = 29
        '
        'DIASRECUPERADOS
        '
        Me.DIASRECUPERADOS.Caption = "DÍAS REC."
        Me.DIASRECUPERADOS.FieldName = "DIASRECUPERADOS"
        Me.DIASRECUPERADOS.Name = "DIASRECUPERADOS"
        Me.DIASRECUPERADOS.Visible = True
        Me.DIASRECUPERADOS.VisibleIndex = 30
        '
        'DIASANULADO
        '
        Me.DIASANULADO.Caption = "DÍAS ANU."
        Me.DIASANULADO.FieldName = "DIASANULADO"
        Me.DIASANULADO.Name = "DIASANULADO"
        Me.DIASANULADO.Visible = True
        Me.DIASANULADO.VisibleIndex = 31
        '
        'DESCRIPCIONDECLARACION
        '
        Me.DESCRIPCIONDECLARACION.Caption = "DECLARACIÓN"
        Me.DESCRIPCIONDECLARACION.FieldName = "DESCRIPCIONDECLARACION"
        Me.DESCRIPCIONDECLARACION.Name = "DESCRIPCIONDECLARACION"
        Me.DESCRIPCIONDECLARACION.Visible = True
        Me.DESCRIPCIONDECLARACION.VisibleIndex = 28
        '
        'NITESSALUD
        '
        Me.NITESSALUD.Caption = "NIT ESSALUD"
        Me.NITESSALUD.FieldName = "NITESSALUD"
        Me.NITESSALUD.Name = "NITESSALUD"
        Me.NITESSALUD.Visible = True
        Me.NITESSALUD.VisibleIndex = 32
        Me.NITESSALUD.Width = 120
        '
        'FECHARECEPCION
        '
        Me.FECHARECEPCION.Caption = "FECHA DE RECEPCIÓN"
        Me.FECHARECEPCION.ColumnEdit = Me.RepositoryItemDateEditFechaRecepcion
        Me.FECHARECEPCION.FieldName = "FECHARECEPCION"
        Me.FECHARECEPCION.Name = "FECHARECEPCION"
        Me.FECHARECEPCION.Visible = True
        Me.FECHARECEPCION.VisibleIndex = 33
        Me.FECHARECEPCION.Width = 120
        '
        'RepositoryItemDateEditFechaRecepcion
        '
        Me.RepositoryItemDateEditFechaRecepcion.AutoHeight = False
        Me.RepositoryItemDateEditFechaRecepcion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEditFechaRecepcion.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEditFechaRecepcion.Name = "RepositoryItemDateEditFechaRecepcion"
        '
        'IDTIPOOBSERVACIONENFERMEDAD
        '
        Me.IDTIPOOBSERVACIONENFERMEDAD.Caption = "OBSERVACIÓN"
        Me.IDTIPOOBSERVACIONENFERMEDAD.ColumnEdit = Me.RepositoryItemGridLookUpEditObservacion
        Me.IDTIPOOBSERVACIONENFERMEDAD.FieldName = "IDTIPOOBSERVACIONENFERMEDAD"
        Me.IDTIPOOBSERVACIONENFERMEDAD.Name = "IDTIPOOBSERVACIONENFERMEDAD"
        Me.IDTIPOOBSERVACIONENFERMEDAD.Visible = True
        Me.IDTIPOOBSERVACIONENFERMEDAD.VisibleIndex = 34
        Me.IDTIPOOBSERVACIONENFERMEDAD.Width = 150
        '
        'RepositoryItemGridLookUpEditObservacion
        '
        Me.RepositoryItemGridLookUpEditObservacion.AutoHeight = False
        Me.RepositoryItemGridLookUpEditObservacion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEditObservacion.Name = "RepositoryItemGridLookUpEditObservacion"
        Me.RepositoryItemGridLookUpEditObservacion.View = Me.GridViewObservacion
        '
        'GridViewObservacion
        '
        Me.GridViewObservacion.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewObservacion.Name = "GridViewObservacion"
        Me.GridViewObservacion.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewObservacion.OptionsView.ShowAutoFilterRow = True
        Me.GridViewObservacion.OptionsView.ShowGroupPanel = False
        '
        'DETALLEDESCANSOMEDICO
        '
        Me.DETALLEDESCANSOMEDICO.Caption = "DETALLE"
        Me.DETALLEDESCANSOMEDICO.FieldName = "DETALLEDESCANSOMEDICO"
        Me.DETALLEDESCANSOMEDICO.Name = "DETALLEDESCANSOMEDICO"
        Me.DETALLEDESCANSOMEDICO.Visible = True
        Me.DETALLEDESCANSOMEDICO.VisibleIndex = 35
        Me.DETALLEDESCANSOMEDICO.Width = 300
        '
        'IDBANCO
        '
        Me.IDBANCO.Caption = "BANCO"
        Me.IDBANCO.ColumnEdit = Me.RepositoryItemGridLookUpEditBanco
        Me.IDBANCO.FieldName = "IDBANCO"
        Me.IDBANCO.Name = "IDBANCO"
        Me.IDBANCO.Visible = True
        Me.IDBANCO.VisibleIndex = 36
        Me.IDBANCO.Width = 180
        '
        'RepositoryItemGridLookUpEditBanco
        '
        Me.RepositoryItemGridLookUpEditBanco.AutoHeight = False
        Me.RepositoryItemGridLookUpEditBanco.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEditBanco.Name = "RepositoryItemGridLookUpEditBanco"
        Me.RepositoryItemGridLookUpEditBanco.View = Me.GridViewBanco
        '
        'GridViewBanco
        '
        Me.GridViewBanco.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewBanco.Name = "GridViewBanco"
        Me.GridViewBanco.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewBanco.OptionsView.ShowAutoFilterRow = True
        Me.GridViewBanco.OptionsView.ShowGroupPanel = False
        '
        'NUMEROCHEQUE
        '
        Me.NUMEROCHEQUE.Caption = "N° DE CHEQUE"
        Me.NUMEROCHEQUE.FieldName = "NUMEROCHEQUE"
        Me.NUMEROCHEQUE.Name = "NUMEROCHEQUE"
        Me.NUMEROCHEQUE.Visible = True
        Me.NUMEROCHEQUE.VisibleIndex = 37
        Me.NUMEROCHEQUE.Width = 120
        '
        'MONTOSUBSIDIADO
        '
        Me.MONTOSUBSIDIADO.Caption = "MONTO SUBSIDIADO"
        Me.MONTOSUBSIDIADO.FieldName = "MONTOSUBSIDIADO"
        Me.MONTOSUBSIDIADO.Name = "MONTOSUBSIDIADO"
        Me.MONTOSUBSIDIADO.Visible = True
        Me.MONTOSUBSIDIADO.VisibleIndex = 38
        Me.MONTOSUBSIDIADO.Width = 120
        '
        'CONTABILIDAD
        '
        Me.CONTABILIDAD.Caption = "CONTABILIDAD"
        Me.CONTABILIDAD.FieldName = "CONTABILIDAD"
        Me.CONTABILIDAD.Name = "CONTABILIDAD"
        Me.CONTABILIDAD.OptionsColumn.AllowEdit = False
        Me.CONTABILIDAD.Visible = True
        Me.CONTABILIDAD.VisibleIndex = 39
        Me.CONTABILIDAD.Width = 120
        '
        'IDEMPLEADO
        '
        Me.IDEMPLEADO.Caption = "IDEMPLEADO"
        Me.IDEMPLEADO.FieldName = "IDEMPLEADO"
        Me.IDEMPLEADO.Name = "IDEMPLEADO"
        '
        'RepositoryItemAcuerdoArchivo
        '
        Me.RepositoryItemAcuerdoArchivo.AutoHeight = False
        Me.RepositoryItemAcuerdoArchivo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemAcuerdoArchivo.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, "", Nothing, Nothing, True)})
        Me.RepositoryItemAcuerdoArchivo.Name = "RepositoryItemAcuerdoArchivo"
        Me.RepositoryItemAcuerdoArchivo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'RepositoryItemGridLookUpEditDiagnosticoSubGrupo
        '
        Me.RepositoryItemGridLookUpEditDiagnosticoSubGrupo.AutoHeight = False
        Me.RepositoryItemGridLookUpEditDiagnosticoSubGrupo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEditDiagnosticoSubGrupo.Name = "RepositoryItemGridLookUpEditDiagnosticoSubGrupo"
        Me.RepositoryItemGridLookUpEditDiagnosticoSubGrupo.View = Me.GridViewDiagnosticoSubGrupo
        '
        'GridViewDiagnosticoSubGrupo
        '
        Me.GridViewDiagnosticoSubGrupo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewDiagnosticoSubGrupo.Name = "GridViewDiagnosticoSubGrupo"
        Me.GridViewDiagnosticoSubGrupo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewDiagnosticoSubGrupo.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEditAsignar
        '
        Me.RepositoryItemCheckEditAsignar.AutoHeight = False
        Me.RepositoryItemCheckEditAsignar.Name = "RepositoryItemCheckEditAsignar"
        '
        'MATRICULA
        '
        Me.MATRICULA.Caption = "MATRICULA"
        Me.MATRICULA.FieldName = "MATRICULA"
        Me.MATRICULA.Name = "MATRICULA"
        Me.MATRICULA.Visible = True
        Me.MATRICULA.VisibleIndex = 4
        '
        'LicenciaEnfermedadList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 449)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "LicenciaEnfermedadList"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "LICENCIAS POR ENFERMEDAD-ACCIDENTE"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemAprobar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemAnular, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSustentoArchivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemVista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditTipoLicencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewTipoLicencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditProcedencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewProcedencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditMotivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewMotivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditDiagnosticoGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewDiagnosticoGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEditFechaInicio.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEditFechaInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEditFechaFin.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEditFechaFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditMesEvaluacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewMesEvaluacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEditEstadoEnfermedad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEditDeclaracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEditFechaRecepcion.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEditFechaRecepcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditObservacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewObservacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemAcuerdoArchivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditDiagnosticoSubGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewDiagnosticoSubGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEditAsignar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnRefrescar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IDLICENCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NUMERODOCUMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents APELLIDOPATERNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents APELLIDOMATERNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NOMBRES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PUESTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RAZONCOMERCIAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RAZONSOCIAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDPROCEDENCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEditProcedencia As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewProcedencia As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemAcuerdoArchivo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemSustentoArchivo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents NUMERODESCANSOMEDICO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDMOTIVOENFERMEDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEditMotivo As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewMotivo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IDSUBGRUPOFAMILIAENFERMEDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEditDiagnosticoGrupo As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewDiagnosticoGrupo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SUBGRUPOFAMILIAENFERMEDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEditDiagnosticoSubGrupo As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewDiagnosticoSubGrupo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FECHAPERIODOINICIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEditFechaInicio As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents FECHAPERIODOFIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEditFechaFin As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents CANTIDADDIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDMESEVALUACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEditMesEvaluacion As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewMesEvaluacion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ESTADOPAGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEditEstadoEnfermedad As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents DECLARACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEditDeclaracion As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents DIASSUBSIDIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIASRECUPERADOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIASANULADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NITESSALUD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHARECEPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEditFechaRecepcion As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents IDTIPOOBSERVACIONENFERMEDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEditObservacion As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewObservacion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DETALLEDESCANSOMEDICO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDBANCO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEditBanco As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewBanco As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NUMEROCHEQUE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MONTOSUBSIDIADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CONTABILIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEditAsignar As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents SUSTENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NUMEROSOLICITUD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents APROBAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemAprobar As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ANULAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemAnular As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents IDLICENCIATIPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEditTipoLicencia As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewTipoLicencia As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TELEFONO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnExportarSolicitantes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DESCRIPCIONESTADOPAGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DESCRIPCIONDECLARACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VERDETALLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemVista As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents FECHA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDEMPLEADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MATRICULA As DevExpress.XtraGrid.Columns.GridColumn
End Class
