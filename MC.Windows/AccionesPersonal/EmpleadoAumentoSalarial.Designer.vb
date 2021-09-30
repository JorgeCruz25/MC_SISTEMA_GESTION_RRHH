<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpleadoAumentoSalarial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmpleadoAumentoSalarial))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemGridLookUpEditEmpleado = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEditEmpleadoView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPorcentajeAumento = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMontoAumento = New DevExpress.XtraEditors.TextEdit()
        Me.sleMotivoAumento = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridViewMotivoAumento = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.deFechaAumento = New DevExpress.XtraEditors.DateEdit()
        Me.txtSueldoNuevo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txtCodigoUnico = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSueldo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIdEmpleado = New DevExpress.XtraEditors.TextEdit()
        Me.txtApellidoMaterno = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtApellidoPaterno = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombres = New DevExpress.XtraEditors.TextEdit()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEditEmpleadoView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtPorcentajeAumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoAumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sleMotivoAumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewMotivoAumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaAumento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaAumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSueldoNuevo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtCodigoUnico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSueldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidoMaterno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidoPaterno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnGuardar, Me.btnCerrar, Me.BarEditItem1})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 4
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEditEmpleado})
        Me.RibbonControl.Size = New System.Drawing.Size(635, 143)
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
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "Empleado "
        Me.BarEditItem1.Edit = Me.RepositoryItemGridLookUpEditEmpleado
        Me.BarEditItem1.Id = 3
        Me.BarEditItem1.Name = "BarEditItem1"
        Me.BarEditItem1.Width = 280
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
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Aumento Salarial"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnGuardar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarEditItem1)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Empleado"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 455)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(635, 31)
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.txtPorcentajeAumento)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txtMontoAumento)
        Me.GroupControl1.Controls.Add(Me.sleMotivoAumento)
        Me.GroupControl1.Controls.Add(Me.LabelControl25)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.deFechaAumento)
        Me.GroupControl1.Controls.Add(Me.txtSueldoNuevo)
        Me.GroupControl1.Controls.Add(Me.LabelControl17)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl1.Location = New System.Drawing.Point(0, 285)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(635, 170)
        Me.GroupControl1.TabIndex = 53
        Me.GroupControl1.Text = "Datos de Aumento de Sueldo"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(12, 114)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl6.TabIndex = 57
        Me.LabelControl6.Text = "% Aumento"
        '
        'txtPorcentajeAumento
        '
        Me.txtPorcentajeAumento.CausesValidation = False
        Me.txtPorcentajeAumento.Enabled = False
        Me.txtPorcentajeAumento.Location = New System.Drawing.Point(114, 112)
        Me.txtPorcentajeAumento.Name = "txtPorcentajeAumento"
        Me.txtPorcentajeAumento.Properties.Mask.EditMask = "n"
        Me.txtPorcentajeAumento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPorcentajeAumento.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPorcentajeAumento.Properties.MaxLength = 11
        Me.txtPorcentajeAumento.Size = New System.Drawing.Size(120, 20)
        Me.txtPorcentajeAumento.TabIndex = 4
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 88)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl5.TabIndex = 55
        Me.LabelControl5.Text = "Sueldo Aumento"
        '
        'txtMontoAumento
        '
        Me.txtMontoAumento.CausesValidation = False
        Me.txtMontoAumento.Location = New System.Drawing.Point(114, 86)
        Me.txtMontoAumento.Name = "txtMontoAumento"
        Me.txtMontoAumento.Properties.Mask.EditMask = "n"
        Me.txtMontoAumento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMontoAumento.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMontoAumento.Properties.MaxLength = 11
        Me.txtMontoAumento.Size = New System.Drawing.Size(120, 20)
        Me.txtMontoAumento.TabIndex = 3
        '
        'sleMotivoAumento
        '
        Me.sleMotivoAumento.Location = New System.Drawing.Point(114, 34)
        Me.sleMotivoAumento.Name = "sleMotivoAumento"
        Me.sleMotivoAumento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sleMotivoAumento.Properties.NullText = "[Seleccione]"
        Me.sleMotivoAumento.Properties.View = Me.GridViewMotivoAumento
        Me.sleMotivoAumento.Size = New System.Drawing.Size(243, 20)
        Me.sleMotivoAumento.TabIndex = 1
        '
        'GridViewMotivoAumento
        '
        Me.GridViewMotivoAumento.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewMotivoAumento.Name = "GridViewMotivoAumento"
        Me.GridViewMotivoAumento.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewMotivoAumento.OptionsView.ShowGroupPanel = False
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(12, 36)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl25.TabIndex = 53
        Me.LabelControl25.Text = "Motivo de Aumento"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(12, 62)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl12.TabIndex = 50
        Me.LabelControl12.Text = "Fecha Aumento"
        '
        'deFechaAumento
        '
        Me.deFechaAumento.EditValue = Nothing
        Me.deFechaAumento.Location = New System.Drawing.Point(114, 60)
        Me.deFechaAumento.MenuManager = Me.RibbonControl
        Me.deFechaAumento.Name = "deFechaAumento"
        Me.deFechaAumento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaAumento.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaAumento.Size = New System.Drawing.Size(120, 20)
        Me.deFechaAumento.TabIndex = 2
        '
        'txtSueldoNuevo
        '
        Me.txtSueldoNuevo.CausesValidation = False
        Me.txtSueldoNuevo.Enabled = False
        Me.txtSueldoNuevo.Location = New System.Drawing.Point(114, 138)
        Me.txtSueldoNuevo.Name = "txtSueldoNuevo"
        Me.txtSueldoNuevo.Properties.Mask.EditMask = "n"
        Me.txtSueldoNuevo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSueldoNuevo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSueldoNuevo.Properties.MaxLength = 11
        Me.txtSueldoNuevo.Size = New System.Drawing.Size(120, 20)
        Me.txtSueldoNuevo.TabIndex = 5
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(12, 140)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl17.TabIndex = 42
        Me.LabelControl17.Text = "Nuevo Sueldo"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.txtCodigoUnico)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.txtSueldo)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.txtIdEmpleado)
        Me.GroupControl2.Controls.Add(Me.txtApellidoMaterno)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.txtApellidoPaterno)
        Me.GroupControl2.Controls.Add(Me.txtNombres)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 143)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(635, 136)
        Me.GroupControl2.TabIndex = 56
        Me.GroupControl2.Text = "Datos del Personal"
        '
        'txtCodigoUnico
        '
        Me.txtCodigoUnico.Enabled = False
        Me.txtCodigoUnico.Location = New System.Drawing.Point(297, 28)
        Me.txtCodigoUnico.MenuManager = Me.RibbonControl
        Me.txtCodigoUnico.Name = "txtCodigoUnico"
        Me.txtCodigoUnico.Size = New System.Drawing.Size(136, 20)
        Me.txtCodigoUnico.TabIndex = 45
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(229, 30)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl8.TabIndex = 44
        Me.LabelControl8.Text = "Código Unico"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(439, 108)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl7.TabIndex = 43
        Me.LabelControl7.Text = "Sueldo"
        '
        'txtSueldo
        '
        Me.txtSueldo.CausesValidation = False
        Me.txtSueldo.Enabled = False
        Me.txtSueldo.Location = New System.Drawing.Point(477, 105)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Properties.Mask.EditMask = "n"
        Me.txtSueldo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSueldo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSueldo.Properties.MaxLength = 11
        Me.txtSueldo.Size = New System.Drawing.Size(120, 20)
        Me.txtSueldo.TabIndex = 21
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 30)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl1.TabIndex = 17
        Me.LabelControl1.Text = "Id Empleado"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 108)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl4.TabIndex = 20
        Me.LabelControl4.Text = "Apellido Materno"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 82)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl3.TabIndex = 19
        Me.LabelControl3.Text = "Apellido Paterno"
        '
        'txtIdEmpleado
        '
        Me.txtIdEmpleado.Enabled = False
        Me.txtIdEmpleado.Location = New System.Drawing.Point(114, 28)
        Me.txtIdEmpleado.MenuManager = Me.RibbonControl
        Me.txtIdEmpleado.Name = "txtIdEmpleado"
        Me.txtIdEmpleado.Size = New System.Drawing.Size(108, 20)
        Me.txtIdEmpleado.TabIndex = 13
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.CausesValidation = False
        Me.txtApellidoMaterno.Enabled = False
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(114, 106)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Properties.Mask.EditMask = "d"
        Me.txtApellidoMaterno.Properties.MaxLength = 30
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(319, 20)
        Me.txtApellidoMaterno.TabIndex = 15
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 56)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl2.TabIndex = 18
        Me.LabelControl2.Text = "Nombres"
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.CausesValidation = False
        Me.txtApellidoPaterno.Enabled = False
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(114, 80)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Properties.Mask.EditMask = "d"
        Me.txtApellidoPaterno.Properties.MaxLength = 30
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(319, 20)
        Me.txtApellidoPaterno.TabIndex = 14
        '
        'txtNombres
        '
        Me.txtNombres.CausesValidation = False
        Me.txtNombres.Enabled = False
        Me.txtNombres.Location = New System.Drawing.Point(114, 54)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Properties.Mask.EditMask = "d"
        Me.txtNombres.Properties.MaxLength = 50
        Me.txtNombres.Size = New System.Drawing.Size(319, 20)
        Me.txtNombres.TabIndex = 16
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'EmpleadoAumentoSalarial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 486)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.MaximizeBox = False
        Me.Name = "EmpleadoAumentoSalarial"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "AUMENTO SALARIAL DE PERSONAL"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEditEmpleadoView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtPorcentajeAumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoAumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sleMotivoAumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewMotivoAumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaAumento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaAumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSueldoNuevo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtCodigoUnico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSueldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidoMaterno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidoPaterno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemGridLookUpEditEmpleado As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEditEmpleadoView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents sleMotivoAumento As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridViewMotivoAumento As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaAumento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtSueldoNuevo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMontoAumento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPorcentajeAumento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIdEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtApellidoMaterno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtApellidoPaterno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSueldo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoUnico As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
End Class
