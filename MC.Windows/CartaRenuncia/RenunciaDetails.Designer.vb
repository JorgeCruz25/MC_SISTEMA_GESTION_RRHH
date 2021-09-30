<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RenunciaDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RenunciaDetails))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAprobar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAnular = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAdjuntarDocumento = New DevExpress.XtraBars.BarButtonItem()
        Me.btnHistorialEmpleado = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.dtFechaFinalContrato = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodigoUnico = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIdEmpleado = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmpleado = New DevExpress.XtraEditors.TextEdit()
        Me.txtDni = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.chkCambioRazonSocial = New DevExpress.XtraEditors.CheckEdit()
        Me.deFechaCese = New DevExpress.XtraEditors.DateEdit()
        Me.chkPagoDiasBoleta = New DevExpress.XtraEditors.CheckEdit()
        Me.txtObservacion = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.sleMotivoCese = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridViewMotivoCese = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.dtFechaFinalContrato.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaFinalContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoUnico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDni.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.chkCambioRazonSocial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaCese.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaCese.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPagoDiasBoleta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sleMotivoCese.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewMotivoCese, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnCerrar, Me.btnGuardar, Me.btnAprobar, Me.btnAnular, Me.btnAdjuntarDocumento, Me.btnHistorialEmpleado})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 7
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(487, 143)
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
        'btnGuardar
        '
        Me.btnGuardar.Caption = "Guardar"
        Me.btnGuardar.Glyph = CType(resources.GetObject("btnGuardar.Glyph"), System.Drawing.Image)
        Me.btnGuardar.Id = 2
        Me.btnGuardar.LargeGlyph = CType(resources.GetObject("btnGuardar.LargeGlyph"), System.Drawing.Image)
        Me.btnGuardar.Name = "btnGuardar"
        '
        'btnAprobar
        '
        Me.btnAprobar.Caption = "Aprobar"
        Me.btnAprobar.Glyph = CType(resources.GetObject("btnAprobar.Glyph"), System.Drawing.Image)
        Me.btnAprobar.Id = 3
        Me.btnAprobar.LargeGlyph = CType(resources.GetObject("btnAprobar.LargeGlyph"), System.Drawing.Image)
        Me.btnAprobar.Name = "btnAprobar"
        '
        'btnAnular
        '
        Me.btnAnular.Caption = "Anular"
        Me.btnAnular.Glyph = CType(resources.GetObject("btnAnular.Glyph"), System.Drawing.Image)
        Me.btnAnular.Id = 4
        Me.btnAnular.LargeGlyph = CType(resources.GetObject("btnAnular.LargeGlyph"), System.Drawing.Image)
        Me.btnAnular.Name = "btnAnular"
        '
        'btnAdjuntarDocumento
        '
        Me.btnAdjuntarDocumento.Caption = "Adjuntar Documento"
        Me.btnAdjuntarDocumento.Glyph = CType(resources.GetObject("btnAdjuntarDocumento.Glyph"), System.Drawing.Image)
        Me.btnAdjuntarDocumento.Id = 5
        Me.btnAdjuntarDocumento.LargeGlyph = CType(resources.GetObject("btnAdjuntarDocumento.LargeGlyph"), System.Drawing.Image)
        Me.btnAdjuntarDocumento.Name = "btnAdjuntarDocumento"
        '
        'btnHistorialEmpleado
        '
        Me.btnHistorialEmpleado.Caption = "Historial Empleado"
        Me.btnHistorialEmpleado.Glyph = CType(resources.GetObject("btnHistorialEmpleado.Glyph"), System.Drawing.Image)
        Me.btnHistorialEmpleado.Id = 6
        Me.btnHistorialEmpleado.LargeGlyph = CType(resources.GetObject("btnHistorialEmpleado.LargeGlyph"), System.Drawing.Image)
        Me.btnHistorialEmpleado.Name = "btnHistorialEmpleado"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Renuncia"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnGuardar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAprobar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAdjuntarDocumento)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnHistorialEmpleado)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAnular)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 473)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(487, 31)
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.dtFechaFinalContrato)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txtCodigoUnico)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtIdEmpleado)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.txtEmpleado)
        Me.GroupControl1.Controls.Add(Me.txtDni)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 143)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(487, 125)
        Me.GroupControl1.TabIndex = 62
        Me.GroupControl1.Text = "Datos del Personal"
        '
        'dtFechaFinalContrato
        '
        Me.dtFechaFinalContrato.EditValue = Nothing
        Me.dtFechaFinalContrato.Enabled = False
        Me.dtFechaFinalContrato.Location = New System.Drawing.Point(339, 54)
        Me.dtFechaFinalContrato.Name = "dtFechaFinalContrato"
        Me.dtFechaFinalContrato.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaFinalContrato.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaFinalContrato.Size = New System.Drawing.Size(108, 20)
        Me.dtFechaFinalContrato.TabIndex = 72
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(252, 57)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl4.TabIndex = 71
        Me.LabelControl4.Text = "F. Final Contrato"
        '
        'txtCodigoUnico
        '
        Me.txtCodigoUnico.Enabled = False
        Me.txtCodigoUnico.Location = New System.Drawing.Point(339, 23)
        Me.txtCodigoUnico.MenuManager = Me.RibbonControl
        Me.txtCodigoUnico.Name = "txtCodigoUnico"
        Me.txtCodigoUnico.Size = New System.Drawing.Size(108, 20)
        Me.txtCodigoUnico.TabIndex = 70
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(15, 25)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl3.TabIndex = 68
        Me.LabelControl3.Text = "Id Empleado"
        '
        'txtIdEmpleado
        '
        Me.txtIdEmpleado.Enabled = False
        Me.txtIdEmpleado.Location = New System.Drawing.Point(102, 23)
        Me.txtIdEmpleado.MenuManager = Me.RibbonControl
        Me.txtIdEmpleado.Name = "txtIdEmpleado"
        Me.txtIdEmpleado.Size = New System.Drawing.Size(134, 20)
        Me.txtIdEmpleado.TabIndex = 66
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(15, 83)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl11.TabIndex = 69
        Me.LabelControl11.Text = "Empleado"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(252, 26)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl2.TabIndex = 65
        Me.LabelControl2.Text = "CodigoUnico"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(15, 57)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(18, 13)
        Me.LabelControl8.TabIndex = 44
        Me.LabelControl8.Text = "DNI"
        '
        'txtEmpleado
        '
        Me.txtEmpleado.Enabled = False
        Me.txtEmpleado.Location = New System.Drawing.Point(102, 81)
        Me.txtEmpleado.MenuManager = Me.RibbonControl
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Size = New System.Drawing.Size(345, 20)
        Me.txtEmpleado.TabIndex = 4
        '
        'txtDni
        '
        Me.txtDni.Enabled = False
        Me.txtDni.Location = New System.Drawing.Point(102, 55)
        Me.txtDni.MenuManager = Me.RibbonControl
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(134, 20)
        Me.txtDni.TabIndex = 8
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.chkCambioRazonSocial)
        Me.GroupControl2.Controls.Add(Me.deFechaCese)
        Me.GroupControl2.Controls.Add(Me.chkPagoDiasBoleta)
        Me.GroupControl2.Controls.Add(Me.txtObservacion)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Controls.Add(Me.sleMotivoCese)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl2.Location = New System.Drawing.Point(0, 252)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(487, 221)
        Me.GroupControl2.TabIndex = 66
        Me.GroupControl2.Text = "Datos de Cese"
        '
        'chkCambioRazonSocial
        '
        Me.chkCambioRazonSocial.Enabled = False
        Me.chkCambioRazonSocial.Location = New System.Drawing.Point(355, 35)
        Me.chkCambioRazonSocial.MenuManager = Me.RibbonControl
        Me.chkCambioRazonSocial.Name = "chkCambioRazonSocial"
        Me.chkCambioRazonSocial.Properties.Caption = "Cambio Razon Social"
        Me.chkCambioRazonSocial.Size = New System.Drawing.Size(121, 19)
        Me.chkCambioRazonSocial.TabIndex = 40
        Me.chkCambioRazonSocial.Visible = False
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
        'chkPagoDiasBoleta
        '
        Me.chkPagoDiasBoleta.Location = New System.Drawing.Point(215, 35)
        Me.chkPagoDiasBoleta.MenuManager = Me.RibbonControl
        Me.chkPagoDiasBoleta.Name = "chkPagoDiasBoleta"
        Me.chkPagoDiasBoleta.Properties.Caption = "Pago de Dias en Boleta"
        Me.chkPagoDiasBoleta.Size = New System.Drawing.Size(134, 19)
        Me.chkPagoDiasBoleta.TabIndex = 3
        '
        'txtObservacion
        '
        Me.txtObservacion.EditValue = ""
        Me.txtObservacion.Location = New System.Drawing.Point(88, 86)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Properties.MaxLength = 80
        Me.txtObservacion.Size = New System.Drawing.Size(359, 71)
        Me.txtObservacion.TabIndex = 5
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 37)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl1.TabIndex = 37
        Me.LabelControl1.Text = "Fecha"
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
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(14, 88)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl6.TabIndex = 38
        Me.LabelControl6.Text = "Observación"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(14, 63)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl7.TabIndex = 39
        Me.LabelControl7.Text = "Motivo"
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'RenunciaDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 504)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "RenunciaDetails"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "CARTA RENUNCIA"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.dtFechaFinalContrato.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaFinalContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoUnico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDni.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.chkCambioRazonSocial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaCese.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaCese.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPagoDiasBoleta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sleMotivoCese.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewMotivoCese, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDni As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAprobar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoUnico As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIdEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents deFechaCese As DevExpress.XtraEditors.DateEdit
    Friend WithEvents chkPagoDiasBoleta As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtObservacion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sleMotivoCese As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridViewMotivoCese As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents btnAnular As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAdjuntarDocumento As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFechaFinalContrato As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnHistorialEmpleado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents chkCambioRazonSocial As DevExpress.XtraEditors.CheckEdit
End Class
