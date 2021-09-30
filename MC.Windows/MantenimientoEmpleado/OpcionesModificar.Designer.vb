<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpcionesModificar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OpcionesModificar))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItemEmpleado = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItemNumeroDocumento = New DevExpress.XtraBars.BarStaticItem()
        Me.btnProcesar = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.btnGenerarContrato = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCambioFechaCese = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFechaFinalContrato = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnCambioTipoContrato = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCambioRazonSocial = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFechaIngresoCompania = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDesprocesarContrato = New DevExpress.XtraEditors.SimpleButton()
        Me.btnFechaIngresoCorporativo = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabDesprocesarContrato = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabCambioFechaCese = New DevExpress.XtraTab.XtraTabPage()
        Me.sleNumeroSolicitudCese = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridViewCese = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.rboRenuncia = New System.Windows.Forms.RadioButton()
        Me.rboCese = New System.Windows.Forms.RadioButton()
        Me.txtCodigoUnicoFechaCese = New System.Windows.Forms.TextBox()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIdEmpleadoFechaCese = New System.Windows.Forms.TextBox()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.deFechaCese = New DevExpress.XtraEditors.DateEdit()
        Me.XtraTabCambioFechaFinContrato = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabTipoContrato = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabRazonSocial = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabIngresoCorporativo = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabIngresoCompania = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPageGenerarContrato = New DevExpress.XtraTab.XtraTabPage()
        Me.txtCodigoUnicoRenovacionContrato = New System.Windows.Forms.TextBox()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIdEmpleadoRenovacionContrato = New System.Windows.Forms.TextBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.deNuevaFechaRenovacionContrato = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.deFechaFinContratoRenovacion = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabCambioFechaCese.SuspendLayout()
        CType(Me.sleNumeroSolicitudCese.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCese, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaCese.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaCese.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPageGenerarContrato.SuspendLayout()
        CType(Me.deNuevaFechaRenovacionContrato.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deNuevaFechaRenovacionContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaFinContratoRenovacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaFinContratoRenovacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnCerrar, Me.BarButtonItem1, Me.BarStaticItemEmpleado, Me.BarStaticItemNumeroDocumento, Me.btnProcesar})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 6
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(602, 143)
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
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 2
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarStaticItemEmpleado
        '
        Me.BarStaticItemEmpleado.Caption = "BarStaticItem1"
        Me.BarStaticItemEmpleado.Id = 3
        Me.BarStaticItemEmpleado.Name = "BarStaticItemEmpleado"
        Me.BarStaticItemEmpleado.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarStaticItemNumeroDocumento
        '
        Me.BarStaticItemNumeroDocumento.Caption = "BarStaticItem2"
        Me.BarStaticItemNumeroDocumento.Id = 4
        Me.BarStaticItemNumeroDocumento.Name = "BarStaticItemNumeroDocumento"
        Me.BarStaticItemNumeroDocumento.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'btnProcesar
        '
        Me.btnProcesar.Caption = "Procesar"
        Me.btnProcesar.Glyph = CType(resources.GetObject("btnProcesar.Glyph"), System.Drawing.Image)
        Me.btnProcesar.Id = 5
        Me.btnProcesar.LargeGlyph = CType(resources.GetObject("btnProcesar.LargeGlyph"), System.Drawing.Image)
        Me.btnProcesar.Name = "btnProcesar"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Opciones Modificación"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnProcesar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarStaticItemEmpleado)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarStaticItemNumeroDocumento)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Datos Empleado"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 540)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(602, 31)
        '
        'btnGenerarContrato
        '
        Me.btnGenerarContrato.Appearance.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnGenerarContrato.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarContrato.Appearance.Options.UseBackColor = True
        Me.btnGenerarContrato.Appearance.Options.UseFont = True
        Me.btnGenerarContrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGenerarContrato.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnGenerarContrato.Image = CType(resources.GetObject("btnGenerarContrato.Image"), System.Drawing.Image)
        Me.btnGenerarContrato.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnGenerarContrato.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnGenerarContrato.Location = New System.Drawing.Point(12, 149)
        Me.btnGenerarContrato.Name = "btnGenerarContrato"
        Me.btnGenerarContrato.Size = New System.Drawing.Size(180, 59)
        Me.btnGenerarContrato.TabIndex = 2
        Me.btnGenerarContrato.Text = "Generar Renovacion Contrato"
        '
        'btnCambioFechaCese
        '
        Me.btnCambioFechaCese.Appearance.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnCambioFechaCese.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambioFechaCese.Appearance.Options.UseBackColor = True
        Me.btnCambioFechaCese.Appearance.Options.UseFont = True
        Me.btnCambioFechaCese.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCambioFechaCese.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnCambioFechaCese.Image = CType(resources.GetObject("btnCambioFechaCese.Image"), System.Drawing.Image)
        Me.btnCambioFechaCese.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnCambioFechaCese.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnCambioFechaCese.Location = New System.Drawing.Point(198, 214)
        Me.btnCambioFechaCese.Name = "btnCambioFechaCese"
        Me.btnCambioFechaCese.Size = New System.Drawing.Size(192, 59)
        Me.btnCambioFechaCese.TabIndex = 3
        Me.btnCambioFechaCese.Text = "Cambio Fecha Cese"
        '
        'btnFechaFinalContrato
        '
        Me.btnFechaFinalContrato.Appearance.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnFechaFinalContrato.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechaFinalContrato.Appearance.Options.UseBackColor = True
        Me.btnFechaFinalContrato.Appearance.Options.UseFont = True
        Me.btnFechaFinalContrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFechaFinalContrato.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnFechaFinalContrato.Image = CType(resources.GetObject("btnFechaFinalContrato.Image"), System.Drawing.Image)
        Me.btnFechaFinalContrato.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnFechaFinalContrato.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnFechaFinalContrato.Location = New System.Drawing.Point(13, 279)
        Me.btnFechaFinalContrato.Name = "btnFechaFinalContrato"
        Me.btnFechaFinalContrato.Size = New System.Drawing.Size(179, 59)
        Me.btnFechaFinalContrato.TabIndex = 4
        Me.btnFechaFinalContrato.Text = "Cambio Fecha Fin Contrato"
        '
        'BtnCambioTipoContrato
        '
        Me.BtnCambioTipoContrato.Appearance.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnCambioTipoContrato.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCambioTipoContrato.Appearance.Options.UseBackColor = True
        Me.BtnCambioTipoContrato.Appearance.Options.UseFont = True
        Me.BtnCambioTipoContrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnCambioTipoContrato.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.BtnCambioTipoContrato.Image = CType(resources.GetObject("BtnCambioTipoContrato.Image"), System.Drawing.Image)
        Me.BtnCambioTipoContrato.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.BtnCambioTipoContrato.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.BtnCambioTipoContrato.Location = New System.Drawing.Point(397, 279)
        Me.BtnCambioTipoContrato.Name = "BtnCambioTipoContrato"
        Me.BtnCambioTipoContrato.Size = New System.Drawing.Size(201, 59)
        Me.BtnCambioTipoContrato.TabIndex = 5
        Me.BtnCambioTipoContrato.Text = "Cambio Tipo Contrato"
        '
        'btnCambioRazonSocial
        '
        Me.btnCambioRazonSocial.Appearance.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnCambioRazonSocial.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambioRazonSocial.Appearance.Options.UseBackColor = True
        Me.btnCambioRazonSocial.Appearance.Options.UseFont = True
        Me.btnCambioRazonSocial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCambioRazonSocial.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnCambioRazonSocial.Image = CType(resources.GetObject("btnCambioRazonSocial.Image"), System.Drawing.Image)
        Me.btnCambioRazonSocial.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnCambioRazonSocial.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnCambioRazonSocial.Location = New System.Drawing.Point(198, 279)
        Me.btnCambioRazonSocial.Name = "btnCambioRazonSocial"
        Me.btnCambioRazonSocial.Size = New System.Drawing.Size(192, 59)
        Me.btnCambioRazonSocial.TabIndex = 6
        Me.btnCambioRazonSocial.Text = "Cambio Razon Social"
        '
        'btnFechaIngresoCompania
        '
        Me.btnFechaIngresoCompania.Appearance.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnFechaIngresoCompania.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechaIngresoCompania.Appearance.Options.UseBackColor = True
        Me.btnFechaIngresoCompania.Appearance.Options.UseFont = True
        Me.btnFechaIngresoCompania.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFechaIngresoCompania.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnFechaIngresoCompania.Image = CType(resources.GetObject("btnFechaIngresoCompania.Image"), System.Drawing.Image)
        Me.btnFechaIngresoCompania.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnFechaIngresoCompania.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnFechaIngresoCompania.Location = New System.Drawing.Point(396, 214)
        Me.btnFechaIngresoCompania.Name = "btnFechaIngresoCompania"
        Me.btnFechaIngresoCompania.Size = New System.Drawing.Size(202, 59)
        Me.btnFechaIngresoCompania.TabIndex = 7
        Me.btnFechaIngresoCompania.Text = "Cambio Fecha Ingreso Compañia"
        '
        'btnDesprocesarContrato
        '
        Me.btnDesprocesarContrato.Appearance.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnDesprocesarContrato.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesprocesarContrato.Appearance.Options.UseBackColor = True
        Me.btnDesprocesarContrato.Appearance.Options.UseFont = True
        Me.btnDesprocesarContrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDesprocesarContrato.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnDesprocesarContrato.Image = CType(resources.GetObject("btnDesprocesarContrato.Image"), System.Drawing.Image)
        Me.btnDesprocesarContrato.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnDesprocesarContrato.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnDesprocesarContrato.Location = New System.Drawing.Point(198, 149)
        Me.btnDesprocesarContrato.Name = "btnDesprocesarContrato"
        Me.btnDesprocesarContrato.Size = New System.Drawing.Size(192, 59)
        Me.btnDesprocesarContrato.TabIndex = 8
        Me.btnDesprocesarContrato.Text = "Desprocesar Contrato"
        '
        'btnFechaIngresoCorporativo
        '
        Me.btnFechaIngresoCorporativo.Appearance.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnFechaIngresoCorporativo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechaIngresoCorporativo.Appearance.Options.UseBackColor = True
        Me.btnFechaIngresoCorporativo.Appearance.Options.UseFont = True
        Me.btnFechaIngresoCorporativo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFechaIngresoCorporativo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnFechaIngresoCorporativo.Image = CType(resources.GetObject("btnFechaIngresoCorporativo.Image"), System.Drawing.Image)
        Me.btnFechaIngresoCorporativo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnFechaIngresoCorporativo.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnFechaIngresoCorporativo.Location = New System.Drawing.Point(396, 149)
        Me.btnFechaIngresoCorporativo.Name = "btnFechaIngresoCorporativo"
        Me.btnFechaIngresoCorporativo.Size = New System.Drawing.Size(202, 59)
        Me.btnFechaIngresoCorporativo.TabIndex = 9
        Me.btnFechaIngresoCorporativo.Text = "Cambio Fecha Ingreso Corporativo"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 344)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabDesprocesarContrato
        Me.XtraTabControl1.Size = New System.Drawing.Size(586, 192)
        Me.XtraTabControl1.TabIndex = 10
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabDesprocesarContrato, Me.XtraTabCambioFechaCese, Me.XtraTabCambioFechaFinContrato, Me.XtraTabTipoContrato, Me.XtraTabRazonSocial, Me.XtraTabIngresoCorporativo, Me.XtraTabIngresoCompania, Me.XtraTabPageGenerarContrato})
        '
        'XtraTabDesprocesarContrato
        '
        Me.XtraTabDesprocesarContrato.Name = "XtraTabDesprocesarContrato"
        Me.XtraTabDesprocesarContrato.Size = New System.Drawing.Size(580, 164)
        Me.XtraTabDesprocesarContrato.Text = "Desprocesar Contrato"
        '
        'XtraTabCambioFechaCese
        '
        Me.XtraTabCambioFechaCese.Controls.Add(Me.sleNumeroSolicitudCese)
        Me.XtraTabCambioFechaCese.Controls.Add(Me.LabelControl9)
        Me.XtraTabCambioFechaCese.Controls.Add(Me.LabelControl8)
        Me.XtraTabCambioFechaCese.Controls.Add(Me.rboRenuncia)
        Me.XtraTabCambioFechaCese.Controls.Add(Me.rboCese)
        Me.XtraTabCambioFechaCese.Controls.Add(Me.txtCodigoUnicoFechaCese)
        Me.XtraTabCambioFechaCese.Controls.Add(Me.LabelControl5)
        Me.XtraTabCambioFechaCese.Controls.Add(Me.txtIdEmpleadoFechaCese)
        Me.XtraTabCambioFechaCese.Controls.Add(Me.LabelControl6)
        Me.XtraTabCambioFechaCese.Controls.Add(Me.LabelControl7)
        Me.XtraTabCambioFechaCese.Controls.Add(Me.deFechaCese)
        Me.XtraTabCambioFechaCese.Name = "XtraTabCambioFechaCese"
        Me.XtraTabCambioFechaCese.Size = New System.Drawing.Size(580, 164)
        Me.XtraTabCambioFechaCese.Text = "Cambio Fecha Cese"
        '
        'sleNumeroSolicitudCese
        '
        Me.sleNumeroSolicitudCese.Location = New System.Drawing.Point(121, 62)
        Me.sleNumeroSolicitudCese.Name = "sleNumeroSolicitudCese"
        Me.sleNumeroSolicitudCese.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sleNumeroSolicitudCese.Properties.NullText = "[Seleccione]"
        Me.sleNumeroSolicitudCese.Properties.View = Me.GridViewCese
        Me.sleNumeroSolicitudCese.Size = New System.Drawing.Size(154, 20)
        Me.sleNumeroSolicitudCese.TabIndex = 18
        '
        'GridViewCese
        '
        Me.GridViewCese.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewCese.Name = "GridViewCese"
        Me.GridViewCese.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewCese.OptionsView.ShowGroupPanel = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(55, 65)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl9.TabIndex = 17
        Me.LabelControl9.Text = "N° Solicitud:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(90, 41)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl8.TabIndex = 16
        Me.LabelControl8.Text = "Tipo:"
        '
        'rboRenuncia
        '
        Me.rboRenuncia.AutoSize = True
        Me.rboRenuncia.Location = New System.Drawing.Point(185, 39)
        Me.rboRenuncia.Name = "rboRenuncia"
        Me.rboRenuncia.Size = New System.Drawing.Size(69, 17)
        Me.rboRenuncia.TabIndex = 15
        Me.rboRenuncia.TabStop = True
        Me.rboRenuncia.Text = "Renuncia"
        Me.rboRenuncia.UseVisualStyleBackColor = True
        '
        'rboCese
        '
        Me.rboCese.AutoSize = True
        Me.rboCese.Location = New System.Drawing.Point(122, 39)
        Me.rboCese.Name = "rboCese"
        Me.rboCese.Size = New System.Drawing.Size(49, 17)
        Me.rboCese.TabIndex = 14
        Me.rboCese.TabStop = True
        Me.rboCese.Text = "Cese"
        Me.rboCese.UseVisualStyleBackColor = True
        '
        'txtCodigoUnicoFechaCese
        '
        Me.txtCodigoUnicoFechaCese.Location = New System.Drawing.Point(353, 14)
        Me.txtCodigoUnicoFechaCese.Name = "txtCodigoUnicoFechaCese"
        Me.txtCodigoUnicoFechaCese.Size = New System.Drawing.Size(142, 21)
        Me.txtCodigoUnicoFechaCese.TabIndex = 13
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(281, 14)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl5.TabIndex = 12
        Me.LabelControl5.Text = "Codigo Unico:"
        '
        'txtIdEmpleadoFechaCese
        '
        Me.txtIdEmpleadoFechaCese.Location = New System.Drawing.Point(121, 14)
        Me.txtIdEmpleadoFechaCese.Name = "txtIdEmpleadoFechaCese"
        Me.txtIdEmpleadoFechaCese.Size = New System.Drawing.Size(154, 21)
        Me.txtIdEmpleadoFechaCese.TabIndex = 11
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(45, 17)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl6.TabIndex = 10
        Me.LabelControl6.Text = "ID. Empleado:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(19, 91)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl7.TabIndex = 9
        Me.LabelControl7.Text = "Nueva Fecha Cese:"
        '
        'deFechaCese
        '
        Me.deFechaCese.EditValue = Nothing
        Me.deFechaCese.Location = New System.Drawing.Point(121, 88)
        Me.deFechaCese.MenuManager = Me.RibbonControl
        Me.deFechaCese.Name = "deFechaCese"
        Me.deFechaCese.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaCese.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaCese.Size = New System.Drawing.Size(154, 20)
        Me.deFechaCese.TabIndex = 8
        '
        'XtraTabCambioFechaFinContrato
        '
        Me.XtraTabCambioFechaFinContrato.Name = "XtraTabCambioFechaFinContrato"
        Me.XtraTabCambioFechaFinContrato.Size = New System.Drawing.Size(580, 164)
        Me.XtraTabCambioFechaFinContrato.Text = "Cambio Fecha Fin Contrato"
        '
        'XtraTabTipoContrato
        '
        Me.XtraTabTipoContrato.Name = "XtraTabTipoContrato"
        Me.XtraTabTipoContrato.Size = New System.Drawing.Size(580, 164)
        Me.XtraTabTipoContrato.Text = "Cambio Tipo Contrato"
        '
        'XtraTabRazonSocial
        '
        Me.XtraTabRazonSocial.Name = "XtraTabRazonSocial"
        Me.XtraTabRazonSocial.Size = New System.Drawing.Size(580, 164)
        Me.XtraTabRazonSocial.Text = "Cambio Razon Social"
        '
        'XtraTabIngresoCorporativo
        '
        Me.XtraTabIngresoCorporativo.Name = "XtraTabIngresoCorporativo"
        Me.XtraTabIngresoCorporativo.Size = New System.Drawing.Size(580, 164)
        Me.XtraTabIngresoCorporativo.Text = "Cambio Ingreso Corporativo"
        '
        'XtraTabIngresoCompania
        '
        Me.XtraTabIngresoCompania.Name = "XtraTabIngresoCompania"
        Me.XtraTabIngresoCompania.Size = New System.Drawing.Size(580, 164)
        Me.XtraTabIngresoCompania.Text = "Cambio Ingreso Compañia"
        '
        'XtraTabPageGenerarContrato
        '
        Me.XtraTabPageGenerarContrato.Controls.Add(Me.txtCodigoUnicoRenovacionContrato)
        Me.XtraTabPageGenerarContrato.Controls.Add(Me.LabelControl4)
        Me.XtraTabPageGenerarContrato.Controls.Add(Me.txtIdEmpleadoRenovacionContrato)
        Me.XtraTabPageGenerarContrato.Controls.Add(Me.LabelControl3)
        Me.XtraTabPageGenerarContrato.Controls.Add(Me.LabelControl2)
        Me.XtraTabPageGenerarContrato.Controls.Add(Me.deNuevaFechaRenovacionContrato)
        Me.XtraTabPageGenerarContrato.Controls.Add(Me.LabelControl1)
        Me.XtraTabPageGenerarContrato.Controls.Add(Me.deFechaFinContratoRenovacion)
        Me.XtraTabPageGenerarContrato.Name = "XtraTabPageGenerarContrato"
        Me.XtraTabPageGenerarContrato.Size = New System.Drawing.Size(580, 164)
        Me.XtraTabPageGenerarContrato.Text = "GenerarContrato"
        '
        'txtCodigoUnicoRenovacionContrato
        '
        Me.txtCodigoUnicoRenovacionContrato.Location = New System.Drawing.Point(378, 14)
        Me.txtCodigoUnicoRenovacionContrato.Name = "txtCodigoUnicoRenovacionContrato"
        Me.txtCodigoUnicoRenovacionContrato.Size = New System.Drawing.Size(100, 21)
        Me.txtCodigoUnicoRenovacionContrato.TabIndex = 7
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(304, 17)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Codigo Unico:"
        '
        'txtIdEmpleadoRenovacionContrato
        '
        Me.txtIdEmpleadoRenovacionContrato.Location = New System.Drawing.Point(117, 14)
        Me.txtIdEmpleadoRenovacionContrato.Name = "txtIdEmpleadoRenovacionContrato"
        Me.txtIdEmpleadoRenovacionContrato.Size = New System.Drawing.Size(100, 21)
        Me.txtIdEmpleadoRenovacionContrato.TabIndex = 5
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(15, 17)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "ID. Empleado:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(232, 44)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(138, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Nueva Fecha Final Contrato:"
        '
        'deNuevaFechaRenovacionContrato
        '
        Me.deNuevaFechaRenovacionContrato.EditValue = Nothing
        Me.deNuevaFechaRenovacionContrato.Location = New System.Drawing.Point(378, 45)
        Me.deNuevaFechaRenovacionContrato.MenuManager = Me.RibbonControl
        Me.deNuevaFechaRenovacionContrato.Name = "deNuevaFechaRenovacionContrato"
        Me.deNuevaFechaRenovacionContrato.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deNuevaFechaRenovacionContrato.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deNuevaFechaRenovacionContrato.Size = New System.Drawing.Size(100, 20)
        Me.deNuevaFechaRenovacionContrato.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(15, 44)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(96, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Fecha Fin Contrato:"
        '
        'deFechaFinContratoRenovacion
        '
        Me.deFechaFinContratoRenovacion.EditValue = Nothing
        Me.deFechaFinContratoRenovacion.Location = New System.Drawing.Point(117, 41)
        Me.deFechaFinContratoRenovacion.MenuManager = Me.RibbonControl
        Me.deFechaFinContratoRenovacion.Name = "deFechaFinContratoRenovacion"
        Me.deFechaFinContratoRenovacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaFinContratoRenovacion.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaFinContratoRenovacion.Size = New System.Drawing.Size(100, 20)
        Me.deFechaFinContratoRenovacion.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton1.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(13, 214)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(179, 59)
        Me.SimpleButton1.TabIndex = 13
        Me.SimpleButton1.Text = "Desprocesar Cese"
        '
        'OpcionesModificar
        '
        Me.ActiveGlowColor = System.Drawing.Color.Transparent
        Me.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Appearance.ForeColor = System.Drawing.Color.Transparent
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 571)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.btnFechaIngresoCorporativo)
        Me.Controls.Add(Me.btnDesprocesarContrato)
        Me.Controls.Add(Me.btnFechaIngresoCompania)
        Me.Controls.Add(Me.btnCambioRazonSocial)
        Me.Controls.Add(Me.BtnCambioTipoContrato)
        Me.Controls.Add(Me.btnFechaFinalContrato)
        Me.Controls.Add(Me.btnCambioFechaCese)
        Me.Controls.Add(Me.btnGenerarContrato)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "OpcionesModificar"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "OPCIONES DE MODIFICACIÓN"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabCambioFechaCese.ResumeLayout(False)
        Me.XtraTabCambioFechaCese.PerformLayout()
        CType(Me.sleNumeroSolicitudCese.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCese, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaCese.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaCese.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPageGenerarContrato.ResumeLayout(False)
        Me.XtraTabPageGenerarContrato.PerformLayout()
        CType(Me.deNuevaFechaRenovacionContrato.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deNuevaFechaRenovacionContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaFinContratoRenovacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaFinContratoRenovacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnGenerarContrato As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCambioFechaCese As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFechaFinalContrato As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnCambioTipoContrato As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCambioRazonSocial As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFechaIngresoCompania As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDesprocesarContrato As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFechaIngresoCorporativo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabDesprocesarContrato As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabCambioFechaCese As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabCambioFechaFinContrato As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabTipoContrato As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabRazonSocial As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabIngresoCorporativo As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabIngresoCompania As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItemEmpleado As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItemNumeroDocumento As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents XtraTabPageGenerarContrato As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnProcesar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deNuevaFechaRenovacionContrato As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaFinContratoRenovacion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIdEmpleadoRenovacionContrato As TextBox
    Friend WithEvents txtCodigoUnicoRenovacionContrato As TextBox
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCodigoUnicoFechaCese As TextBox
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIdEmpleadoFechaCese As TextBox
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaCese As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rboRenuncia As RadioButton
    Friend WithEvents rboCese As RadioButton
    Friend WithEvents sleNumeroSolicitudCese As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridViewCese As DevExpress.XtraGrid.Views.Grid.GridView
End Class
