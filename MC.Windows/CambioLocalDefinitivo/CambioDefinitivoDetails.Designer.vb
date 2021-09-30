<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CambioDefinitivoDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CambioDefinitivoDetails))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAprobar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAnular = New DevExpress.XtraBars.BarButtonItem()
        Me.btnValidar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnHistorialEmpleado = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFechaInicio = New DevExpress.XtraEditors.DateEdit()
        Me.dtFechaCambio = New DevExpress.XtraEditors.DateEdit()
        Me.txtEmpleado = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtLocalOrigen = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSolicitante = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.gcDatosSolicitud = New System.Windows.Forms.GroupBox()
        Me.txtTipoCambio = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIdEmpleado = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodigoUnico = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNuevoCargo = New DevExpress.XtraEditors.TextEdit()
        Me.txtNuevoContrato = New DevExpress.XtraEditors.TextEdit()
        Me.txtLocalDestino = New DevExpress.XtraEditors.TextEdit()
        Me.txtCargoActual = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDniEmpleado = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtActualTipoContrato = New DevExpress.XtraEditors.TextEdit()
        Me.sleNuevoContrato = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridViewNuevoContrato = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.sleNuevoCargo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridViewNuevoCargo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.teFinal = New DevExpress.XtraEditors.TimeEdit()
        Me.teInicio = New DevExpress.XtraEditors.TimeEdit()
        Me.dtFechaFinal = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.gcEnvioCorreo = New DevExpress.XtraEditors.GroupControl()
        Me.gcDatosReingreso = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.deFechaCese = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.rboIndicadorNo = New System.Windows.Forms.RadioButton()
        Me.rboIndicadorSi = New System.Windows.Forms.RadioButton()
        Me.sleSolicitudRenuncia = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridViewSolicitudRenuncia = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.chkCambioRazonSocial = New DevExpress.XtraEditors.CheckEdit()
        Me.sleOrganigramDestino = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridViewNuevoLocal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.sleTipoEmpleado = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridViewTipoEmpleado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblTipoEmpleado = New DevExpress.XtraEditors.LabelControl()
        Me.lblFechaFinalContrato = New DevExpress.XtraEditors.LabelControl()
        Me.deFechaFinContrato = New DevExpress.XtraEditors.DateEdit()
        Me.lblFechaReingreso = New DevExpress.XtraEditors.LabelControl()
        Me.deFechaIngresoCompania = New DevExpress.XtraEditors.DateEdit()
        Me.sleRegimenSalarial = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridViewRegimenSalarial = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.sleMoneda = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridViewMoneda = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtSueldo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaCambio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaCambio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLocalOrigen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSolicitante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcDatosSolicitud.SuspendLayout()
        CType(Me.txtTipoCambio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoUnico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNuevoCargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNuevoContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLocalDestino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCargoActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDniEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActualTipoContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sleNuevoContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewNuevoContrato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sleNuevoCargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewNuevoCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaFinal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcEnvioCorreo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcEnvioCorreo.SuspendLayout()
        CType(Me.gcDatosReingreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcDatosReingreso.SuspendLayout()
        CType(Me.deFechaCese.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaCese.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sleSolicitudRenuncia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSolicitudRenuncia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCambioRazonSocial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sleOrganigramDestino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewNuevoLocal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sleTipoEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewTipoEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaFinContrato.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaFinContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaIngresoCompania.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaIngresoCompania.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sleRegimenSalarial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewRegimenSalarial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sleMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSueldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnCerrar, Me.btnAprobar, Me.btnGuardar, Me.btnAnular, Me.btnValidar, Me.btnHistorialEmpleado})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 10
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(813, 143)
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
        'btnAprobar
        '
        Me.btnAprobar.Caption = "Aprobar"
        Me.btnAprobar.Glyph = CType(resources.GetObject("btnAprobar.Glyph"), System.Drawing.Image)
        Me.btnAprobar.Id = 2
        Me.btnAprobar.LargeGlyph = CType(resources.GetObject("btnAprobar.LargeGlyph"), System.Drawing.Image)
        Me.btnAprobar.Name = "btnAprobar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Caption = "Guardar"
        Me.btnGuardar.Glyph = CType(resources.GetObject("btnGuardar.Glyph"), System.Drawing.Image)
        Me.btnGuardar.Id = 3
        Me.btnGuardar.LargeGlyph = CType(resources.GetObject("btnGuardar.LargeGlyph"), System.Drawing.Image)
        Me.btnGuardar.Name = "btnGuardar"
        '
        'btnAnular
        '
        Me.btnAnular.Caption = "Anular"
        Me.btnAnular.Glyph = CType(resources.GetObject("btnAnular.Glyph"), System.Drawing.Image)
        Me.btnAnular.Id = 4
        Me.btnAnular.LargeGlyph = CType(resources.GetObject("btnAnular.LargeGlyph"), System.Drawing.Image)
        Me.btnAnular.Name = "btnAnular"
        '
        'btnValidar
        '
        Me.btnValidar.Caption = "Validar"
        Me.btnValidar.Glyph = CType(resources.GetObject("btnValidar.Glyph"), System.Drawing.Image)
        Me.btnValidar.Id = 5
        Me.btnValidar.LargeGlyph = CType(resources.GetObject("btnValidar.LargeGlyph"), System.Drawing.Image)
        Me.btnValidar.Name = "btnValidar"
        '
        'btnHistorialEmpleado
        '
        Me.btnHistorialEmpleado.Caption = "Historial Empleado"
        Me.btnHistorialEmpleado.Glyph = CType(resources.GetObject("btnHistorialEmpleado.Glyph"), System.Drawing.Image)
        Me.btnHistorialEmpleado.Id = 9
        Me.btnHistorialEmpleado.LargeGlyph = CType(resources.GetObject("btnHistorialEmpleado.LargeGlyph"), System.Drawing.Image)
        Me.btnHistorialEmpleado.Name = "btnHistorialEmpleado"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Cambio definitivo"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnGuardar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnValidar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAprobar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnHistorialEmpleado)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAnular)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 595)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(813, 31)
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(19, 35)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl8.TabIndex = 100
        Me.LabelControl8.Text = "Periodo Fima Inicio"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(610, 22)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl7.TabIndex = 104
        Me.LabelControl7.Text = "Fecha Cambio"
        '
        'dtFechaInicio
        '
        Me.dtFechaInicio.EditValue = Nothing
        Me.dtFechaInicio.Location = New System.Drawing.Point(111, 32)
        Me.dtFechaInicio.MenuManager = Me.RibbonControl
        Me.dtFechaInicio.Name = "dtFechaInicio"
        Me.dtFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaInicio.Size = New System.Drawing.Size(99, 20)
        Me.dtFechaInicio.TabIndex = 108
        '
        'dtFechaCambio
        '
        Me.dtFechaCambio.EditValue = Nothing
        Me.dtFechaCambio.Enabled = False
        Me.dtFechaCambio.Location = New System.Drawing.Point(690, 18)
        Me.dtFechaCambio.MenuManager = Me.RibbonControl
        Me.dtFechaCambio.Name = "dtFechaCambio"
        Me.dtFechaCambio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaCambio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaCambio.Size = New System.Drawing.Size(99, 20)
        Me.dtFechaCambio.TabIndex = 102
        '
        'txtEmpleado
        '
        Me.txtEmpleado.Location = New System.Drawing.Point(89, 40)
        Me.txtEmpleado.MenuManager = Me.RibbonControl
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Size = New System.Drawing.Size(296, 20)
        Me.txtEmpleado.TabIndex = 99
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(6, 47)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl3.TabIndex = 98
        Me.LabelControl3.Text = "Empleado"
        '
        'txtLocalOrigen
        '
        Me.txtLocalOrigen.Enabled = False
        Me.txtLocalOrigen.Location = New System.Drawing.Point(89, 66)
        Me.txtLocalOrigen.MenuManager = Me.RibbonControl
        Me.txtLocalOrigen.Name = "txtLocalOrigen"
        Me.txtLocalOrigen.Size = New System.Drawing.Size(296, 20)
        Me.txtLocalOrigen.TabIndex = 96
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(428, 72)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl2.TabIndex = 95
        Me.LabelControl2.Text = "Local Destino"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(6, 69)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl1.TabIndex = 94
        Me.LabelControl1.Text = "Local Origen"
        '
        'txtSolicitante
        '
        Me.txtSolicitante.Enabled = False
        Me.txtSolicitante.Location = New System.Drawing.Point(89, 14)
        Me.txtSolicitante.MenuManager = Me.RibbonControl
        Me.txtSolicitante.Name = "txtSolicitante"
        Me.txtSolicitante.Size = New System.Drawing.Size(296, 20)
        Me.txtSolicitante.TabIndex = 93
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(6, 21)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl6.TabIndex = 92
        Me.LabelControl6.Text = "Solicitante"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(428, 125)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl5.TabIndex = 106
        Me.LabelControl5.Text = "Nuevo Cargo"
        '
        'gcDatosSolicitud
        '
        Me.gcDatosSolicitud.Controls.Add(Me.txtTipoCambio)
        Me.gcDatosSolicitud.Controls.Add(Me.LabelControl17)
        Me.gcDatosSolicitud.Controls.Add(Me.txtIdEmpleado)
        Me.gcDatosSolicitud.Controls.Add(Me.LabelControl22)
        Me.gcDatosSolicitud.Controls.Add(Me.txtCodigoUnico)
        Me.gcDatosSolicitud.Controls.Add(Me.LabelControl21)
        Me.gcDatosSolicitud.Controls.Add(Me.txtNuevoCargo)
        Me.gcDatosSolicitud.Controls.Add(Me.txtNuevoContrato)
        Me.gcDatosSolicitud.Controls.Add(Me.txtLocalDestino)
        Me.gcDatosSolicitud.Controls.Add(Me.txtCargoActual)
        Me.gcDatosSolicitud.Controls.Add(Me.LabelControl11)
        Me.gcDatosSolicitud.Controls.Add(Me.txtDniEmpleado)
        Me.gcDatosSolicitud.Controls.Add(Me.LabelControl4)
        Me.gcDatosSolicitud.Controls.Add(Me.LabelControl9)
        Me.gcDatosSolicitud.Controls.Add(Me.LabelControl12)
        Me.gcDatosSolicitud.Controls.Add(Me.LabelControl5)
        Me.gcDatosSolicitud.Controls.Add(Me.txtActualTipoContrato)
        Me.gcDatosSolicitud.Controls.Add(Me.LabelControl6)
        Me.gcDatosSolicitud.Controls.Add(Me.txtSolicitante)
        Me.gcDatosSolicitud.Controls.Add(Me.LabelControl7)
        Me.gcDatosSolicitud.Controls.Add(Me.LabelControl1)
        Me.gcDatosSolicitud.Controls.Add(Me.LabelControl2)
        Me.gcDatosSolicitud.Controls.Add(Me.dtFechaCambio)
        Me.gcDatosSolicitud.Controls.Add(Me.txtLocalOrigen)
        Me.gcDatosSolicitud.Controls.Add(Me.LabelControl3)
        Me.gcDatosSolicitud.Controls.Add(Me.txtEmpleado)
        Me.gcDatosSolicitud.Location = New System.Drawing.Point(0, 149)
        Me.gcDatosSolicitud.Name = "gcDatosSolicitud"
        Me.gcDatosSolicitud.Size = New System.Drawing.Size(811, 172)
        Me.gcDatosSolicitud.TabIndex = 107
        Me.gcDatosSolicitud.TabStop = False
        Me.gcDatosSolicitud.Text = "Datos Solicitud"
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.Enabled = False
        Me.txtTipoCambio.Location = New System.Drawing.Point(508, 147)
        Me.txtTipoCambio.MenuManager = Me.RibbonControl
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtTipoCambio.Properties.Appearance.Options.UseForeColor = True
        Me.txtTipoCambio.Size = New System.Drawing.Size(288, 20)
        Me.txtTipoCambio.TabIndex = 121
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(428, 150)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl17.TabIndex = 120
        Me.LabelControl17.Text = "Tipo de Cambio"
        '
        'txtIdEmpleado
        '
        Me.txtIdEmpleado.Enabled = False
        Me.txtIdEmpleado.Location = New System.Drawing.Point(508, 44)
        Me.txtIdEmpleado.MenuManager = Me.RibbonControl
        Me.txtIdEmpleado.Name = "txtIdEmpleado"
        Me.txtIdEmpleado.Size = New System.Drawing.Size(96, 20)
        Me.txtIdEmpleado.TabIndex = 119
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(428, 43)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl22.TabIndex = 118
        Me.LabelControl22.Text = "Id Empleado"
        '
        'txtCodigoUnico
        '
        Me.txtCodigoUnico.Enabled = False
        Me.txtCodigoUnico.Location = New System.Drawing.Point(690, 43)
        Me.txtCodigoUnico.MenuManager = Me.RibbonControl
        Me.txtCodigoUnico.Name = "txtCodigoUnico"
        Me.txtCodigoUnico.Size = New System.Drawing.Size(99, 20)
        Me.txtCodigoUnico.TabIndex = 117
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(610, 43)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl21.TabIndex = 116
        Me.LabelControl21.Text = "Codigo Unico"
        '
        'txtNuevoCargo
        '
        Me.txtNuevoCargo.Enabled = False
        Me.txtNuevoCargo.Location = New System.Drawing.Point(508, 121)
        Me.txtNuevoCargo.MenuManager = Me.RibbonControl
        Me.txtNuevoCargo.Name = "txtNuevoCargo"
        Me.txtNuevoCargo.Size = New System.Drawing.Size(288, 20)
        Me.txtNuevoCargo.TabIndex = 115
        '
        'txtNuevoContrato
        '
        Me.txtNuevoContrato.Enabled = False
        Me.txtNuevoContrato.Location = New System.Drawing.Point(508, 95)
        Me.txtNuevoContrato.MenuManager = Me.RibbonControl
        Me.txtNuevoContrato.Name = "txtNuevoContrato"
        Me.txtNuevoContrato.Size = New System.Drawing.Size(288, 20)
        Me.txtNuevoContrato.TabIndex = 114
        '
        'txtLocalDestino
        '
        Me.txtLocalDestino.Enabled = False
        Me.txtLocalDestino.Location = New System.Drawing.Point(508, 69)
        Me.txtLocalDestino.MenuManager = Me.RibbonControl
        Me.txtLocalDestino.Name = "txtLocalDestino"
        Me.txtLocalDestino.Size = New System.Drawing.Size(288, 20)
        Me.txtLocalDestino.TabIndex = 113
        '
        'txtCargoActual
        '
        Me.txtCargoActual.Enabled = False
        Me.txtCargoActual.Location = New System.Drawing.Point(89, 118)
        Me.txtCargoActual.MenuManager = Me.RibbonControl
        Me.txtCargoActual.Name = "txtCargoActual"
        Me.txtCargoActual.Size = New System.Drawing.Size(296, 20)
        Me.txtCargoActual.TabIndex = 112
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(6, 125)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl11.TabIndex = 111
        Me.LabelControl11.Text = "Cargo Actual"
        '
        'txtDniEmpleado
        '
        Me.txtDniEmpleado.Location = New System.Drawing.Point(508, 18)
        Me.txtDniEmpleado.MenuManager = Me.RibbonControl
        Me.txtDniEmpleado.Name = "txtDniEmpleado"
        Me.txtDniEmpleado.Size = New System.Drawing.Size(96, 20)
        Me.txtDniEmpleado.TabIndex = 110
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(428, 21)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl4.TabIndex = 109
        Me.LabelControl4.Text = "Dni Empleado"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(428, 98)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl9.TabIndex = 107
        Me.LabelControl9.Text = "Nuevo Contrato"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(6, 98)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl12.TabIndex = 107
        Me.LabelControl12.Text = "Actual Contrato"
        '
        'txtActualTipoContrato
        '
        Me.txtActualTipoContrato.Enabled = False
        Me.txtActualTipoContrato.Location = New System.Drawing.Point(89, 92)
        Me.txtActualTipoContrato.Name = "txtActualTipoContrato"
        Me.txtActualTipoContrato.Size = New System.Drawing.Size(296, 20)
        Me.txtActualTipoContrato.TabIndex = 108
        '
        'sleNuevoContrato
        '
        Me.sleNuevoContrato.EditValue = ""
        Me.sleNuevoContrato.Location = New System.Drawing.Point(114, 117)
        Me.sleNuevoContrato.MenuManager = Me.RibbonControl
        Me.sleNuevoContrato.Name = "sleNuevoContrato"
        Me.sleNuevoContrato.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sleNuevoContrato.Properties.View = Me.GridViewNuevoContrato
        Me.sleNuevoContrato.Size = New System.Drawing.Size(237, 20)
        Me.sleNuevoContrato.TabIndex = 113
        '
        'GridViewNuevoContrato
        '
        Me.GridViewNuevoContrato.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewNuevoContrato.Name = "GridViewNuevoContrato"
        Me.GridViewNuevoContrato.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewNuevoContrato.OptionsView.ShowAutoFilterRow = True
        Me.GridViewNuevoContrato.OptionsView.ShowGroupPanel = False
        '
        'sleNuevoCargo
        '
        Me.sleNuevoCargo.EditValue = ""
        Me.sleNuevoCargo.Location = New System.Drawing.Point(114, 90)
        Me.sleNuevoCargo.MenuManager = Me.RibbonControl
        Me.sleNuevoCargo.Name = "sleNuevoCargo"
        Me.sleNuevoCargo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sleNuevoCargo.Properties.View = Me.GridViewNuevoCargo
        Me.sleNuevoCargo.Size = New System.Drawing.Size(237, 20)
        Me.sleNuevoCargo.TabIndex = 102
        '
        'GridViewNuevoCargo
        '
        Me.GridViewNuevoCargo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewNuevoCargo.Name = "GridViewNuevoCargo"
        Me.GridViewNuevoCargo.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewNuevoCargo.OptionsView.ShowAutoFilterRow = True
        Me.GridViewNuevoCargo.OptionsView.ShowGroupPanel = False
        '
        'teFinal
        '
        Me.teFinal.EditValue = New Date(CType(0, Long))
        Me.teFinal.Location = New System.Drawing.Point(586, 32)
        Me.teFinal.MenuManager = Me.RibbonControl
        Me.teFinal.Name = "teFinal"
        Me.teFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.teFinal.Size = New System.Drawing.Size(100, 20)
        Me.teFinal.TabIndex = 113
        '
        'teInicio
        '
        Me.teInicio.EditValue = New Date(2019, 1, 25, 0, 0, 0, 0)
        Me.teInicio.Location = New System.Drawing.Point(216, 32)
        Me.teInicio.MenuManager = Me.RibbonControl
        Me.teInicio.Name = "teInicio"
        Me.teInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.teInicio.Size = New System.Drawing.Size(100, 20)
        Me.teInicio.TabIndex = 112
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.EditValue = Nothing
        Me.dtFechaFinal.Location = New System.Drawing.Point(481, 32)
        Me.dtFechaFinal.MenuManager = Me.RibbonControl
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaFinal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaFinal.Size = New System.Drawing.Size(99, 20)
        Me.dtFechaFinal.TabIndex = 107
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(389, 35)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl10.TabIndex = 108
        Me.LabelControl10.Text = "Periodo Fima Final"
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'gcEnvioCorreo
        '
        Me.gcEnvioCorreo.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcEnvioCorreo.AppearanceCaption.Options.UseFont = True
        Me.gcEnvioCorreo.Controls.Add(Me.teFinal)
        Me.gcEnvioCorreo.Controls.Add(Me.dtFechaInicio)
        Me.gcEnvioCorreo.Controls.Add(Me.teInicio)
        Me.gcEnvioCorreo.Controls.Add(Me.LabelControl8)
        Me.gcEnvioCorreo.Controls.Add(Me.dtFechaFinal)
        Me.gcEnvioCorreo.Controls.Add(Me.LabelControl10)
        Me.gcEnvioCorreo.Location = New System.Drawing.Point(0, 317)
        Me.gcEnvioCorreo.Name = "gcEnvioCorreo"
        Me.gcEnvioCorreo.Size = New System.Drawing.Size(808, 57)
        Me.gcEnvioCorreo.TabIndex = 112
        Me.gcEnvioCorreo.Text = "Envio de Correo"
        '
        'gcDatosReingreso
        '
        Me.gcDatosReingreso.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcDatosReingreso.AppearanceCaption.Options.UseFont = True
        Me.gcDatosReingreso.Controls.Add(Me.LabelControl15)
        Me.gcDatosReingreso.Controls.Add(Me.deFechaCese)
        Me.gcDatosReingreso.Controls.Add(Me.LabelControl14)
        Me.gcDatosReingreso.Controls.Add(Me.rboIndicadorNo)
        Me.gcDatosReingreso.Controls.Add(Me.rboIndicadorSi)
        Me.gcDatosReingreso.Controls.Add(Me.sleSolicitudRenuncia)
        Me.gcDatosReingreso.Controls.Add(Me.LabelControl13)
        Me.gcDatosReingreso.Controls.Add(Me.chkCambioRazonSocial)
        Me.gcDatosReingreso.Controls.Add(Me.sleOrganigramDestino)
        Me.gcDatosReingreso.Controls.Add(Me.sleNuevoContrato)
        Me.gcDatosReingreso.Controls.Add(Me.LabelControl19)
        Me.gcDatosReingreso.Controls.Add(Me.LabelControl18)
        Me.gcDatosReingreso.Controls.Add(Me.LabelControl16)
        Me.gcDatosReingreso.Controls.Add(Me.sleTipoEmpleado)
        Me.gcDatosReingreso.Controls.Add(Me.sleNuevoCargo)
        Me.gcDatosReingreso.Controls.Add(Me.lblTipoEmpleado)
        Me.gcDatosReingreso.Controls.Add(Me.lblFechaFinalContrato)
        Me.gcDatosReingreso.Controls.Add(Me.deFechaFinContrato)
        Me.gcDatosReingreso.Controls.Add(Me.lblFechaReingreso)
        Me.gcDatosReingreso.Controls.Add(Me.deFechaIngresoCompania)
        Me.gcDatosReingreso.Controls.Add(Me.sleRegimenSalarial)
        Me.gcDatosReingreso.Controls.Add(Me.sleMoneda)
        Me.gcDatosReingreso.Controls.Add(Me.txtSueldo)
        Me.gcDatosReingreso.Controls.Add(Me.LabelControl24)
        Me.gcDatosReingreso.Controls.Add(Me.LabelControl20)
        Me.gcDatosReingreso.Location = New System.Drawing.Point(0, 380)
        Me.gcDatosReingreso.Name = "gcDatosReingreso"
        Me.gcDatosReingreso.Size = New System.Drawing.Size(811, 209)
        Me.gcDatosReingreso.TabIndex = 113
        Me.gcDatosReingreso.Text = "Datos de Reingreso"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(584, 38)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl15.TabIndex = 125
        Me.LabelControl15.Text = "Fecha Cese"
        '
        'deFechaCese
        '
        Me.deFechaCese.EditValue = Nothing
        Me.deFechaCese.Enabled = False
        Me.deFechaCese.Location = New System.Drawing.Point(651, 35)
        Me.deFechaCese.MenuManager = Me.RibbonControl
        Me.deFechaCese.Name = "deFechaCese"
        Me.deFechaCese.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaCese.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaCese.Size = New System.Drawing.Size(120, 20)
        Me.deFechaCese.TabIndex = 124
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(386, 63)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(118, 13)
        Me.LabelControl14.TabIndex = 123
        Me.LabelControl14.Text = "Indicador Indeterminado"
        '
        'rboIndicadorNo
        '
        Me.rboIndicadorNo.AutoSize = True
        Me.rboIndicadorNo.Location = New System.Drawing.Point(566, 63)
        Me.rboIndicadorNo.Name = "rboIndicadorNo"
        Me.rboIndicadorNo.Size = New System.Drawing.Size(38, 17)
        Me.rboIndicadorNo.TabIndex = 122
        Me.rboIndicadorNo.TabStop = True
        Me.rboIndicadorNo.Text = "No"
        Me.rboIndicadorNo.UseVisualStyleBackColor = True
        '
        'rboIndicadorSi
        '
        Me.rboIndicadorSi.AutoSize = True
        Me.rboIndicadorSi.Location = New System.Drawing.Point(520, 61)
        Me.rboIndicadorSi.Name = "rboIndicadorSi"
        Me.rboIndicadorSi.Size = New System.Drawing.Size(33, 17)
        Me.rboIndicadorSi.TabIndex = 121
        Me.rboIndicadorSi.TabStop = True
        Me.rboIndicadorSi.Text = "Si"
        Me.rboIndicadorSi.UseVisualStyleBackColor = True
        '
        'sleSolicitudRenuncia
        '
        Me.sleSolicitudRenuncia.Location = New System.Drawing.Point(114, 34)
        Me.sleSolicitudRenuncia.Name = "sleSolicitudRenuncia"
        Me.sleSolicitudRenuncia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sleSolicitudRenuncia.Properties.NullText = "[Seleccione]"
        Me.sleSolicitudRenuncia.Properties.View = Me.GridViewSolicitudRenuncia
        Me.sleSolicitudRenuncia.Size = New System.Drawing.Size(237, 20)
        Me.sleSolicitudRenuncia.TabIndex = 120
        '
        'GridViewSolicitudRenuncia
        '
        Me.GridViewSolicitudRenuncia.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewSolicitudRenuncia.Name = "GridViewSolicitudRenuncia"
        Me.GridViewSolicitudRenuncia.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewSolicitudRenuncia.OptionsView.ShowAutoFilterRow = True
        Me.GridViewSolicitudRenuncia.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridViewSolicitudRenuncia.OptionsView.ShowGroupPanel = False
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(10, 34)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(101, 13)
        Me.LabelControl13.TabIndex = 119
        Me.LabelControl13.Text = "N° Solicitud Renuncia"
        '
        'chkCambioRazonSocial
        '
        Me.chkCambioRazonSocial.Location = New System.Drawing.Point(386, 35)
        Me.chkCambioRazonSocial.MenuManager = Me.RibbonControl
        Me.chkCambioRazonSocial.Name = "chkCambioRazonSocial"
        Me.chkCambioRazonSocial.Properties.Caption = "Cambio Razon Social"
        Me.chkCambioRazonSocial.Size = New System.Drawing.Size(119, 19)
        Me.chkCambioRazonSocial.TabIndex = 118
        '
        'sleOrganigramDestino
        '
        Me.sleOrganigramDestino.Location = New System.Drawing.Point(114, 60)
        Me.sleOrganigramDestino.Name = "sleOrganigramDestino"
        Me.sleOrganigramDestino.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sleOrganigramDestino.Properties.NullText = "[Seleccione]"
        Me.sleOrganigramDestino.Properties.View = Me.GridViewNuevoLocal
        Me.sleOrganigramDestino.Size = New System.Drawing.Size(237, 20)
        Me.sleOrganigramDestino.TabIndex = 115
        '
        'GridViewNuevoLocal
        '
        Me.GridViewNuevoLocal.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewNuevoLocal.Name = "GridViewNuevoLocal"
        Me.GridViewNuevoLocal.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewNuevoLocal.OptionsView.ShowAutoFilterRow = True
        Me.GridViewNuevoLocal.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridViewNuevoLocal.OptionsView.ShowGroupPanel = False
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(10, 120)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl19.TabIndex = 116
        Me.LabelControl19.Text = "Tipo de Contrato"
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(10, 93)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl18.TabIndex = 115
        Me.LabelControl18.Text = "Puesto Cargo"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(10, 67)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl16.TabIndex = 55
        Me.LabelControl16.Text = "Razón Comercial"
        '
        'sleTipoEmpleado
        '
        Me.sleTipoEmpleado.Location = New System.Drawing.Point(114, 169)
        Me.sleTipoEmpleado.Name = "sleTipoEmpleado"
        Me.sleTipoEmpleado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sleTipoEmpleado.Properties.NullText = "[Seleccione]"
        Me.sleTipoEmpleado.Properties.View = Me.GridViewTipoEmpleado
        Me.sleTipoEmpleado.Size = New System.Drawing.Size(237, 20)
        Me.sleTipoEmpleado.TabIndex = 3
        '
        'GridViewTipoEmpleado
        '
        Me.GridViewTipoEmpleado.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewTipoEmpleado.Name = "GridViewTipoEmpleado"
        Me.GridViewTipoEmpleado.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewTipoEmpleado.OptionsView.ShowGroupPanel = False
        '
        'lblTipoEmpleado
        '
        Me.lblTipoEmpleado.Location = New System.Drawing.Point(10, 172)
        Me.lblTipoEmpleado.Name = "lblTipoEmpleado"
        Me.lblTipoEmpleado.Size = New System.Drawing.Size(84, 13)
        Me.lblTipoEmpleado.TabIndex = 53
        Me.lblTipoEmpleado.Text = "Tipo de Empleado"
        '
        'lblFechaFinalContrato
        '
        Me.lblFechaFinalContrato.Location = New System.Drawing.Point(386, 121)
        Me.lblFechaFinalContrato.Name = "lblFechaFinalContrato"
        Me.lblFechaFinalContrato.Size = New System.Drawing.Size(92, 13)
        Me.lblFechaFinalContrato.TabIndex = 51
        Me.lblFechaFinalContrato.Text = "Fecha Fin Contrato"
        '
        'deFechaFinContrato
        '
        Me.deFechaFinContrato.EditValue = Nothing
        Me.deFechaFinContrato.Location = New System.Drawing.Point(520, 112)
        Me.deFechaFinContrato.MenuManager = Me.RibbonControl
        Me.deFechaFinContrato.Name = "deFechaFinContrato"
        Me.deFechaFinContrato.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaFinContrato.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaFinContrato.Size = New System.Drawing.Size(120, 20)
        Me.deFechaFinContrato.TabIndex = 5
        '
        'lblFechaReingreso
        '
        Me.lblFechaReingreso.Location = New System.Drawing.Point(386, 90)
        Me.lblFechaReingreso.Name = "lblFechaReingreso"
        Me.lblFechaReingreso.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaReingreso.TabIndex = 50
        Me.lblFechaReingreso.Text = "Fecha Reingreso"
        '
        'deFechaIngresoCompania
        '
        Me.deFechaIngresoCompania.EditValue = Nothing
        Me.deFechaIngresoCompania.Location = New System.Drawing.Point(520, 86)
        Me.deFechaIngresoCompania.MenuManager = Me.RibbonControl
        Me.deFechaIngresoCompania.Name = "deFechaIngresoCompania"
        Me.deFechaIngresoCompania.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaIngresoCompania.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaIngresoCompania.Size = New System.Drawing.Size(120, 20)
        Me.deFechaIngresoCompania.TabIndex = 4
        '
        'sleRegimenSalarial
        '
        Me.sleRegimenSalarial.Location = New System.Drawing.Point(114, 143)
        Me.sleRegimenSalarial.Name = "sleRegimenSalarial"
        Me.sleRegimenSalarial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sleRegimenSalarial.Properties.NullText = "[Seleccione]"
        Me.sleRegimenSalarial.Properties.View = Me.GridViewRegimenSalarial
        Me.sleRegimenSalarial.Size = New System.Drawing.Size(237, 20)
        Me.sleRegimenSalarial.TabIndex = 6
        '
        'GridViewRegimenSalarial
        '
        Me.GridViewRegimenSalarial.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewRegimenSalarial.Name = "GridViewRegimenSalarial"
        Me.GridViewRegimenSalarial.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewRegimenSalarial.OptionsView.ShowGroupPanel = False
        '
        'sleMoneda
        '
        Me.sleMoneda.Location = New System.Drawing.Point(651, 139)
        Me.sleMoneda.Name = "sleMoneda"
        Me.sleMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sleMoneda.Properties.NullText = "[Seleccione]"
        Me.sleMoneda.Properties.View = Me.GridViewMoneda
        Me.sleMoneda.Size = New System.Drawing.Size(106, 20)
        Me.sleMoneda.TabIndex = 8
        '
        'GridViewMoneda
        '
        Me.GridViewMoneda.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewMoneda.Name = "GridViewMoneda"
        Me.GridViewMoneda.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewMoneda.OptionsView.ShowGroupPanel = False
        '
        'txtSueldo
        '
        Me.txtSueldo.CausesValidation = False
        Me.txtSueldo.Location = New System.Drawing.Point(520, 139)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Properties.Mask.EditMask = "n"
        Me.txtSueldo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSueldo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSueldo.Properties.MaxLength = 11
        Me.txtSueldo.Size = New System.Drawing.Size(120, 20)
        Me.txtSueldo.TabIndex = 7
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(10, 146)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl24.TabIndex = 43
        Me.LabelControl24.Text = "Régimen Salarial"
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(386, 146)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl20.TabIndex = 42
        Me.LabelControl20.Text = "Sueldo"
        '
        'CambioDefinitivoDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 626)
        Me.Controls.Add(Me.gcDatosReingreso)
        Me.Controls.Add(Me.gcEnvioCorreo)
        Me.Controls.Add(Me.gcDatosSolicitud)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "CambioDefinitivoDetails"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "CAMBIO DEFINITIVO"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaCambio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaCambio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLocalOrigen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSolicitante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcDatosSolicitud.ResumeLayout(False)
        Me.gcDatosSolicitud.PerformLayout()
        CType(Me.txtTipoCambio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoUnico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNuevoCargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNuevoContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLocalDestino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCargoActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDniEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActualTipoContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sleNuevoContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewNuevoContrato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sleNuevoCargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewNuevoCargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaFinal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcEnvioCorreo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcEnvioCorreo.ResumeLayout(False)
        Me.gcEnvioCorreo.PerformLayout()
        CType(Me.gcDatosReingreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcDatosReingreso.ResumeLayout(False)
        Me.gcDatosReingreso.PerformLayout()
        CType(Me.deFechaCese.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaCese.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sleSolicitudRenuncia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSolicitudRenuncia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCambioRazonSocial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sleOrganigramDestino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewNuevoLocal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sleTipoEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewTipoEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaFinContrato.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaFinContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaIngresoCompania.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaIngresoCompania.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sleRegimenSalarial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewRegimenSalarial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sleMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSueldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAprobar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFechaInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtFechaCambio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLocalOrigen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSolicitante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcDatosSolicitud As GroupBox
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFechaFinal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sleNuevoCargo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridViewNuevoCargo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDniEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents teFinal As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents teInicio As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents btnAnular As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnValidar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtCargoActual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtActualTipoContrato As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sleNuevoContrato As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridViewNuevoContrato As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcEnvioCorreo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcDatosReingreso As DevExpress.XtraEditors.GroupControl
    Friend WithEvents sleTipoEmpleado As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridViewTipoEmpleado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblTipoEmpleado As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFechaFinalContrato As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaFinContrato As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblFechaReingreso As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaIngresoCompania As DevExpress.XtraEditors.DateEdit
    Friend WithEvents sleRegimenSalarial As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridViewRegimenSalarial As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents sleMoneda As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridViewMoneda As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtSueldo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNuevoCargo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNuevoContrato As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLocalDestino As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoUnico As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIdEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sleOrganigramDestino As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridViewNuevoLocal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnHistorialEmpleado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sleSolicitudRenuncia As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridViewSolicitudRenuncia As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkCambioRazonSocial As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rboIndicadorNo As RadioButton
    Friend WithEvents rboIndicadorSi As RadioButton
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaCese As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtTipoCambio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
End Class
