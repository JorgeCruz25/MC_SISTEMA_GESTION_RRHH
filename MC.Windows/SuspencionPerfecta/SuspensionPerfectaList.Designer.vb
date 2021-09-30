<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuspensionPerfectaList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SuspensionPerfectaList))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRefrescar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExportar = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.IDSUSPENSIONPERFECTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ADJUNTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemAdjunto = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.FORMATO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemAcuerdoArchivo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.APROBAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemAprobar = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ANULAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemAnular = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.NUMERODOCUMENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.APELLIDOPATERNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.APELLIDOMATERNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NOMBRES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NUMEROSUSPENSIONPERFECTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHAREGISTRO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RAZONCOMERCIAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RAZONSOCIAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CARGOEMPLEADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ESTADOACTUALEMPLEADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SITUACIONACTUAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SITUACIONSOLICITADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.USUARIOREGISTRO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHAPERIODOINICIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateFechaInicio = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.FECHAPERIODOFIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateFechaFinal = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.CANTIDADDIAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FECHAPERIODOFINSUSPENSIONPERFECTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateFechaFinSuspension = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.IDLICENCIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDSITUACIONLABORALSOLICITUD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDEMPLEADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemValidado = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemVerDetalle = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemGridTipoLicencia = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewLicenciaTipo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemGridMotivo = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewMotivo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemGridMesEvaluacion = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridViewMesEvaluacion = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemEstadoPago = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemAdjunto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemAcuerdoArchivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemAprobar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemAnular, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateFechaInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateFechaInicio.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateFechaFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateFechaFinal.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateFechaFinSuspension, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateFechaFinSuspension.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemValidado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemVerDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridTipoLicencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewLicenciaTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridMotivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewMotivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridMesEvaluacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewMesEvaluacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemEstadoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnCerrar, Me.btnRefrescar, Me.btnExportar})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 4
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(867, 143)
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
        'btnRefrescar
        '
        Me.btnRefrescar.Caption = "Refrescar"
        Me.btnRefrescar.Glyph = CType(resources.GetObject("btnRefrescar.Glyph"), System.Drawing.Image)
        Me.btnRefrescar.Id = 2
        Me.btnRefrescar.LargeGlyph = CType(resources.GetObject("btnRefrescar.LargeGlyph"), System.Drawing.Image)
        Me.btnRefrescar.Name = "btnRefrescar"
        '
        'btnExportar
        '
        Me.btnExportar.Caption = "Exportar"
        Me.btnExportar.Glyph = CType(resources.GetObject("btnExportar.Glyph"), System.Drawing.Image)
        Me.btnExportar.Id = 3
        Me.btnExportar.LargeGlyph = CType(resources.GetObject("btnExportar.LargeGlyph"), System.Drawing.Image)
        Me.btnExportar.Name = "btnExportar"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Suspención Perfecta"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnRefrescar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnExportar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 457)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(867, 31)
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
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemAcuerdoArchivo, Me.RepositoryItemAprobar, Me.RepositoryItemValidado, Me.RepositoryItemAnular, Me.RepositoryItemVerDetalle, Me.RepositoryItemAdjunto, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemGridTipoLicencia, Me.RepositoryItemGridMotivo, Me.RepositoryItemDateFechaInicio, Me.RepositoryItemDateFechaFinal, Me.RepositoryItemGridMesEvaluacion, Me.RepositoryItemEstadoPago, Me.RepositoryItemDateFechaFinSuspension})
        Me.GridControl1.Size = New System.Drawing.Size(867, 314)
        Me.GridControl1.TabIndex = 18
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.IDSUSPENSIONPERFECTA, Me.ADJUNTO, Me.FORMATO, Me.APROBAR, Me.ANULAR, Me.NUMERODOCUMENTO, Me.APELLIDOPATERNO, Me.APELLIDOMATERNO, Me.NOMBRES, Me.NUMEROSUSPENSIONPERFECTA, Me.FECHAREGISTRO, Me.RAZONCOMERCIAL, Me.RAZONSOCIAL, Me.CARGOEMPLEADO, Me.ESTADOACTUALEMPLEADO, Me.SITUACIONACTUAL, Me.SITUACIONSOLICITADO, Me.USUARIOREGISTRO, Me.FECHAPERIODOINICIO, Me.FECHAPERIODOFIN, Me.CANTIDADDIAS, Me.FECHAPERIODOFINSUSPENSIONPERFECTA, Me.IDLICENCIA, Me.IDSITUACIONLABORALSOLICITUD, Me.IDEMPLEADO})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: [#image] {1} {2}"
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", Nothing, "(Count={0})")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        '
        'IDSUSPENSIONPERFECTA
        '
        Me.IDSUSPENSIONPERFECTA.Caption = "ID"
        Me.IDSUSPENSIONPERFECTA.FieldName = "IDSUSPENSIONPERFECTA"
        Me.IDSUSPENSIONPERFECTA.Name = "IDSUSPENSIONPERFECTA"
        '
        'ADJUNTO
        '
        Me.ADJUNTO.Caption = "ADJUNTO"
        Me.ADJUNTO.ColumnEdit = Me.RepositoryItemAdjunto
        Me.ADJUNTO.FieldName = "ADJUNTO"
        Me.ADJUNTO.MinWidth = 15
        Me.ADJUNTO.Name = "ADJUNTO"
        Me.ADJUNTO.Visible = True
        Me.ADJUNTO.VisibleIndex = 0
        Me.ADJUNTO.Width = 57
        '
        'RepositoryItemAdjunto
        '
        Me.RepositoryItemAdjunto.AutoHeight = False
        Me.RepositoryItemAdjunto.Name = "RepositoryItemAdjunto"
        '
        'FORMATO
        '
        Me.FORMATO.Caption = "FORMATO"
        Me.FORMATO.ColumnEdit = Me.RepositoryItemAcuerdoArchivo
        Me.FORMATO.FieldName = "FORMATO"
        Me.FORMATO.Name = "FORMATO"
        Me.FORMATO.Visible = True
        Me.FORMATO.VisibleIndex = 1
        '
        'RepositoryItemAcuerdoArchivo
        '
        Me.RepositoryItemAcuerdoArchivo.AutoHeight = False
        Me.RepositoryItemAcuerdoArchivo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemAcuerdoArchivo.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.RepositoryItemAcuerdoArchivo.Name = "RepositoryItemAcuerdoArchivo"
        Me.RepositoryItemAcuerdoArchivo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'APROBAR
        '
        Me.APROBAR.Caption = "APROBAR"
        Me.APROBAR.ColumnEdit = Me.RepositoryItemAprobar
        Me.APROBAR.FieldName = "APROBAR"
        Me.APROBAR.MinWidth = 15
        Me.APROBAR.Name = "APROBAR"
        Me.APROBAR.Visible = True
        Me.APROBAR.VisibleIndex = 2
        Me.APROBAR.Width = 60
        '
        'RepositoryItemAprobar
        '
        Me.RepositoryItemAprobar.AutoHeight = False
        Me.RepositoryItemAprobar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemAprobar.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
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
        Me.ANULAR.VisibleIndex = 3
        Me.ANULAR.Width = 55
        '
        'RepositoryItemAnular
        '
        Me.RepositoryItemAnular.AutoHeight = False
        Me.RepositoryItemAnular.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemAnular.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.RepositoryItemAnular.Name = "RepositoryItemAnular"
        Me.RepositoryItemAnular.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'NUMERODOCUMENTO
        '
        Me.NUMERODOCUMENTO.Caption = "N°DOCUMENTO"
        Me.NUMERODOCUMENTO.FieldName = "NUMERODOCUMENTO"
        Me.NUMERODOCUMENTO.Name = "NUMERODOCUMENTO"
        Me.NUMERODOCUMENTO.OptionsColumn.AllowEdit = False
        Me.NUMERODOCUMENTO.Visible = True
        Me.NUMERODOCUMENTO.VisibleIndex = 4
        Me.NUMERODOCUMENTO.Width = 86
        '
        'APELLIDOPATERNO
        '
        Me.APELLIDOPATERNO.Caption = "APE. PATERNO"
        Me.APELLIDOPATERNO.FieldName = "APELLIDOPATERNO"
        Me.APELLIDOPATERNO.Name = "APELLIDOPATERNO"
        Me.APELLIDOPATERNO.OptionsColumn.AllowEdit = False
        Me.APELLIDOPATERNO.Visible = True
        Me.APELLIDOPATERNO.VisibleIndex = 5
        Me.APELLIDOPATERNO.Width = 90
        '
        'APELLIDOMATERNO
        '
        Me.APELLIDOMATERNO.Caption = "APE. MATERNO"
        Me.APELLIDOMATERNO.FieldName = "APELLIDOMATERNO"
        Me.APELLIDOMATERNO.Name = "APELLIDOMATERNO"
        Me.APELLIDOMATERNO.OptionsColumn.AllowEdit = False
        Me.APELLIDOMATERNO.Visible = True
        Me.APELLIDOMATERNO.VisibleIndex = 6
        Me.APELLIDOMATERNO.Width = 90
        '
        'NOMBRES
        '
        Me.NOMBRES.Caption = "NOMBRES"
        Me.NOMBRES.FieldName = "NOMBRES"
        Me.NOMBRES.Name = "NOMBRES"
        Me.NOMBRES.OptionsColumn.AllowEdit = False
        Me.NOMBRES.Visible = True
        Me.NOMBRES.VisibleIndex = 7
        Me.NOMBRES.Width = 120
        '
        'NUMEROSUSPENSIONPERFECTA
        '
        Me.NUMEROSUSPENSIONPERFECTA.Caption = "NÚMERO SOLICITUD"
        Me.NUMEROSUSPENSIONPERFECTA.FieldName = "NUMEROSUSPENSIONPERFECTA"
        Me.NUMEROSUSPENSIONPERFECTA.Name = "NUMEROSUSPENSIONPERFECTA"
        Me.NUMEROSUSPENSIONPERFECTA.OptionsColumn.AllowEdit = False
        Me.NUMEROSUSPENSIONPERFECTA.Visible = True
        Me.NUMEROSUSPENSIONPERFECTA.VisibleIndex = 8
        Me.NUMEROSUSPENSIONPERFECTA.Width = 120
        '
        'FECHAREGISTRO
        '
        Me.FECHAREGISTRO.Caption = "FECHA SOLICITUD"
        Me.FECHAREGISTRO.FieldName = "FECHAREGISTRO"
        Me.FECHAREGISTRO.Name = "FECHAREGISTRO"
        Me.FECHAREGISTRO.OptionsColumn.AllowEdit = False
        Me.FECHAREGISTRO.Visible = True
        Me.FECHAREGISTRO.VisibleIndex = 9
        Me.FECHAREGISTRO.Width = 110
        '
        'RAZONCOMERCIAL
        '
        Me.RAZONCOMERCIAL.Caption = "TIENDA"
        Me.RAZONCOMERCIAL.FieldName = "RAZONCOMERCIAL"
        Me.RAZONCOMERCIAL.Name = "RAZONCOMERCIAL"
        Me.RAZONCOMERCIAL.OptionsColumn.AllowEdit = False
        Me.RAZONCOMERCIAL.Visible = True
        Me.RAZONCOMERCIAL.VisibleIndex = 11
        Me.RAZONCOMERCIAL.Width = 230
        '
        'RAZONSOCIAL
        '
        Me.RAZONSOCIAL.Caption = "RAZÓN SOCIAL"
        Me.RAZONSOCIAL.FieldName = "RAZONSOCIAL"
        Me.RAZONSOCIAL.Name = "RAZONSOCIAL"
        Me.RAZONSOCIAL.OptionsColumn.AllowEdit = False
        Me.RAZONSOCIAL.Visible = True
        Me.RAZONSOCIAL.VisibleIndex = 12
        Me.RAZONSOCIAL.Width = 230
        '
        'CARGOEMPLEADO
        '
        Me.CARGOEMPLEADO.Caption = "PUESTO"
        Me.CARGOEMPLEADO.FieldName = "CARGOEMPLEADO"
        Me.CARGOEMPLEADO.Name = "CARGOEMPLEADO"
        Me.CARGOEMPLEADO.OptionsColumn.AllowEdit = False
        Me.CARGOEMPLEADO.Visible = True
        Me.CARGOEMPLEADO.VisibleIndex = 10
        Me.CARGOEMPLEADO.Width = 140
        '
        'ESTADOACTUALEMPLEADO
        '
        Me.ESTADOACTUALEMPLEADO.Caption = "ESTADO ACTUAL EMPLEADO"
        Me.ESTADOACTUALEMPLEADO.FieldName = "ESTADOACTUALEMPLEADO"
        Me.ESTADOACTUALEMPLEADO.Name = "ESTADOACTUALEMPLEADO"
        Me.ESTADOACTUALEMPLEADO.OptionsColumn.AllowEdit = False
        Me.ESTADOACTUALEMPLEADO.Visible = True
        Me.ESTADOACTUALEMPLEADO.VisibleIndex = 13
        Me.ESTADOACTUALEMPLEADO.Width = 170
        '
        'SITUACIONACTUAL
        '
        Me.SITUACIONACTUAL.Caption = "SITUACION ACTUAL"
        Me.SITUACIONACTUAL.FieldName = "SITUACIONACTUAL"
        Me.SITUACIONACTUAL.Name = "SITUACIONACTUAL"
        Me.SITUACIONACTUAL.OptionsColumn.AllowEdit = False
        Me.SITUACIONACTUAL.Visible = True
        Me.SITUACIONACTUAL.VisibleIndex = 14
        Me.SITUACIONACTUAL.Width = 140
        '
        'SITUACIONSOLICITADO
        '
        Me.SITUACIONSOLICITADO.Caption = "SITUACION SOLICITADO"
        Me.SITUACIONSOLICITADO.FieldName = "SITUACIONSOLICITADO"
        Me.SITUACIONSOLICITADO.Name = "SITUACIONSOLICITADO"
        Me.SITUACIONSOLICITADO.OptionsColumn.AllowEdit = False
        Me.SITUACIONSOLICITADO.Visible = True
        Me.SITUACIONSOLICITADO.VisibleIndex = 15
        Me.SITUACIONSOLICITADO.Width = 150
        '
        'USUARIOREGISTRO
        '
        Me.USUARIOREGISTRO.Caption = "USUARIO REGISTRO"
        Me.USUARIOREGISTRO.FieldName = "USUARIOREGISTRO"
        Me.USUARIOREGISTRO.Name = "USUARIOREGISTRO"
        Me.USUARIOREGISTRO.Visible = True
        Me.USUARIOREGISTRO.VisibleIndex = 19
        '
        'FECHAPERIODOINICIO
        '
        Me.FECHAPERIODOINICIO.Caption = "F. INICIAL"
        Me.FECHAPERIODOINICIO.ColumnEdit = Me.RepositoryItemDateFechaInicio
        Me.FECHAPERIODOINICIO.FieldName = "FECHAPERIODOINICIO"
        Me.FECHAPERIODOINICIO.Name = "FECHAPERIODOINICIO"
        Me.FECHAPERIODOINICIO.Visible = True
        Me.FECHAPERIODOINICIO.VisibleIndex = 16
        Me.FECHAPERIODOINICIO.Width = 80
        '
        'RepositoryItemDateFechaInicio
        '
        Me.RepositoryItemDateFechaInicio.AutoHeight = False
        Me.RepositoryItemDateFechaInicio.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateFechaInicio.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateFechaInicio.Name = "RepositoryItemDateFechaInicio"
        '
        'FECHAPERIODOFIN
        '
        Me.FECHAPERIODOFIN.Caption = "F. FINAL"
        Me.FECHAPERIODOFIN.ColumnEdit = Me.RepositoryItemDateFechaFinal
        Me.FECHAPERIODOFIN.FieldName = "FECHAPERIODOFIN"
        Me.FECHAPERIODOFIN.Name = "FECHAPERIODOFIN"
        Me.FECHAPERIODOFIN.Visible = True
        Me.FECHAPERIODOFIN.VisibleIndex = 17
        Me.FECHAPERIODOFIN.Width = 80
        '
        'RepositoryItemDateFechaFinal
        '
        Me.RepositoryItemDateFechaFinal.AutoHeight = False
        Me.RepositoryItemDateFechaFinal.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateFechaFinal.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateFechaFinal.Name = "RepositoryItemDateFechaFinal"
        '
        'CANTIDADDIAS
        '
        Me.CANTIDADDIAS.Caption = "DÍAS"
        Me.CANTIDADDIAS.FieldName = "CANTIDADDIAS"
        Me.CANTIDADDIAS.MinWidth = 15
        Me.CANTIDADDIAS.Name = "CANTIDADDIAS"
        Me.CANTIDADDIAS.OptionsColumn.AllowEdit = False
        Me.CANTIDADDIAS.Visible = True
        Me.CANTIDADDIAS.VisibleIndex = 18
        Me.CANTIDADDIAS.Width = 50
        '
        'FECHAPERIODOFINSUSPENSIONPERFECTA
        '
        Me.FECHAPERIODOFINSUSPENSIONPERFECTA.Caption = "F. FINAL SUSPENSION"
        Me.FECHAPERIODOFINSUSPENSIONPERFECTA.ColumnEdit = Me.RepositoryItemDateFechaFinSuspension
        Me.FECHAPERIODOFINSUSPENSIONPERFECTA.FieldName = "FECHAPERIODOFINSUSPENSIONPERFECTA"
        Me.FECHAPERIODOFINSUSPENSIONPERFECTA.Name = "FECHAPERIODOFINSUSPENSIONPERFECTA"
        Me.FECHAPERIODOFINSUSPENSIONPERFECTA.Visible = True
        Me.FECHAPERIODOFINSUSPENSIONPERFECTA.VisibleIndex = 20
        Me.FECHAPERIODOFINSUSPENSIONPERFECTA.Width = 120
        '
        'RepositoryItemDateFechaFinSuspension
        '
        Me.RepositoryItemDateFechaFinSuspension.AutoHeight = False
        Me.RepositoryItemDateFechaFinSuspension.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateFechaFinSuspension.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateFechaFinSuspension.Name = "RepositoryItemDateFechaFinSuspension"
        '
        'IDLICENCIA
        '
        Me.IDLICENCIA.Caption = "IDLICENCIA"
        Me.IDLICENCIA.FieldName = "IDLICENCIA"
        Me.IDLICENCIA.Name = "IDLICENCIA"
        '
        'IDSITUACIONLABORALSOLICITUD
        '
        Me.IDSITUACIONLABORALSOLICITUD.Caption = "IDSITUACIONLABORALSOLICITUD"
        Me.IDSITUACIONLABORALSOLICITUD.FieldName = "IDSITUACIONLABORALSOLICITUD"
        Me.IDSITUACIONLABORALSOLICITUD.Name = "IDSITUACIONLABORALSOLICITUD"
        '
        'IDEMPLEADO
        '
        Me.IDEMPLEADO.Caption = "IDEMPLEADO"
        Me.IDEMPLEADO.FieldName = "IDEMPLEADO"
        Me.IDEMPLEADO.Name = "IDEMPLEADO"
        '
        'RepositoryItemValidado
        '
        Me.RepositoryItemValidado.AutoHeight = False
        Me.RepositoryItemValidado.Name = "RepositoryItemValidado"
        '
        'RepositoryItemVerDetalle
        '
        Me.RepositoryItemVerDetalle.AutoHeight = False
        Me.RepositoryItemVerDetalle.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemVerDetalle.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.RepositoryItemVerDetalle.Name = "RepositoryItemVerDetalle"
        Me.RepositoryItemVerDetalle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
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
        'SuspensionPerfectaList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 488)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "SuspensionPerfectaList"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "SuspencionPerfectaList"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemAdjunto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemAcuerdoArchivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemAprobar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemAnular, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateFechaInicio.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateFechaInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateFechaFinal.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateFechaFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateFechaFinSuspension.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateFechaFinSuspension, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemValidado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemVerDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridTipoLicencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewLicenciaTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridMotivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewMotivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridMesEvaluacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewMesEvaluacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemEstadoPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRefrescar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExportar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IDSUSPENSIONPERFECTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ADJUNTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemAdjunto As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents APROBAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemAprobar As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ANULAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemAnular As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemAcuerdoArchivo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemVerDetalle As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents NUMERODOCUMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents APELLIDOPATERNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents APELLIDOMATERNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NOMBRES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NUMEROSUSPENSIONPERFECTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHAREGISTRO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CARGOEMPLEADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RAZONCOMERCIAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RAZONSOCIAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ESTADOACTUALEMPLEADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SITUACIONACTUAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SITUACIONSOLICITADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridTipoLicencia As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewLicenciaTipo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridMotivo As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewMotivo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FECHAPERIODOINICIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateFechaInicio As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents FECHAPERIODOFIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateFechaFinal As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents CANTIDADDIAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridMesEvaluacion As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridViewMesEvaluacion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemEstadoPago As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents USUARIOREGISTRO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemValidado As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents FORMATO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHAPERIODOFINSUSPENSIONPERFECTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDLICENCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDSITUACIONLABORALSOLICITUD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateFechaFinSuspension As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents IDEMPLEADO As DevExpress.XtraGrid.Columns.GridColumn
End Class
