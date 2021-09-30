<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VacacionesDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VacacionesDetails))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnAprobar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAnular = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFechaIngreso = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFechaIngresoCorporacion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFechaFinContrato = New DevExpress.XtraEditors.TextEdit()
        Me.txtCargo = New DevExpress.XtraEditors.TextEdit()
        Me.dtFechaIncorporacion = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFechaHasta = New DevExpress.XtraEditors.DateEdit()
        Me.dtFechaDesde = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCantidadDias = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSolicitante = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmpleado = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtLocal = New DevExpress.XtraEditors.TextEdit()
        Me.txtDni = New DevExpress.XtraEditors.TextEdit()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaIngreso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaIngresoCorporacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaFinContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaIncorporacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaIncorporacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidadDias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSolicitante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLocal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDni.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnAprobar, Me.btnAnular, Me.btnCerrar})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 5
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(691, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnAprobar
        '
        Me.btnAprobar.Caption = "Aprobar"
        Me.btnAprobar.Glyph = CType(resources.GetObject("btnAprobar.Glyph"), System.Drawing.Image)
        Me.btnAprobar.Id = 1
        Me.btnAprobar.LargeGlyph = CType(resources.GetObject("btnAprobar.LargeGlyph"), System.Drawing.Image)
        Me.btnAprobar.Name = "btnAprobar"
        '
        'btnAnular
        '
        Me.btnAnular.Caption = "Anular"
        Me.btnAnular.Glyph = CType(resources.GetObject("btnAnular.Glyph"), System.Drawing.Image)
        Me.btnAnular.Id = 2
        Me.btnAnular.LargeGlyph = CType(resources.GetObject("btnAnular.LargeGlyph"), System.Drawing.Image)
        Me.btnAnular.Name = "btnAnular"
        '
        'btnCerrar
        '
        Me.btnCerrar.Caption = "Cerrar"
        Me.btnCerrar.Glyph = CType(resources.GetObject("btnCerrar.Glyph"), System.Drawing.Image)
        Me.btnCerrar.Id = 4
        Me.btnCerrar.LargeGlyph = CType(resources.GetObject("btnCerrar.LargeGlyph"), System.Drawing.Image)
        Me.btnCerrar.Name = "btnCerrar"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "VACACIONES"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAprobar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAnular)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 400)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(691, 31)
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Cerrar"
        Me.BarButtonItem3.Glyph = CType(resources.GetObject("BarButtonItem3.Glyph"), System.Drawing.Image)
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.LargeGlyph = CType(resources.GetObject("BarButtonItem3.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelControl13)
        Me.GroupBox1.Controls.Add(Me.TextEdit4)
        Me.GroupBox1.Controls.Add(Me.LabelControl12)
        Me.GroupBox1.Controls.Add(Me.txtFechaIngreso)
        Me.GroupBox1.Controls.Add(Me.LabelControl11)
        Me.GroupBox1.Controls.Add(Me.txtFechaIngresoCorporacion)
        Me.GroupBox1.Controls.Add(Me.LabelControl10)
        Me.GroupBox1.Controls.Add(Me.txtFechaFinContrato)
        Me.GroupBox1.Controls.Add(Me.txtCargo)
        Me.GroupBox1.Controls.Add(Me.dtFechaIncorporacion)
        Me.GroupBox1.Controls.Add(Me.LabelControl8)
        Me.GroupBox1.Controls.Add(Me.LabelControl7)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.dtFechaHasta)
        Me.GroupBox1.Controls.Add(Me.dtFechaDesde)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.txtCantidadDias)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.txtSolicitante)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl9)
        Me.GroupBox1.Controls.Add(Me.txtEmpleado)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.txtLocal)
        Me.GroupBox1.Controls.Add(Me.txtDni)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(691, 247)
        Me.GroupBox1.TabIndex = 111
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Solicitud"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(8, 71)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl13.TabIndex = 132
        Me.LabelControl13.Text = "Local"
        '
        'TextEdit4
        '
        Me.TextEdit4.Enabled = False
        Me.TextEdit4.Location = New System.Drawing.Point(77, 68)
        Me.TextEdit4.MenuManager = Me.RibbonControl
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Size = New System.Drawing.Size(381, 20)
        Me.TextEdit4.TabIndex = 133
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(473, 71)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl12.TabIndex = 130
        Me.LabelControl12.Text = "F. Ing. Compañia"
        '
        'txtFechaIngreso
        '
        Me.txtFechaIngreso.Enabled = False
        Me.txtFechaIngreso.Location = New System.Drawing.Point(569, 68)
        Me.txtFechaIngreso.MenuManager = Me.RibbonControl
        Me.txtFechaIngreso.Name = "txtFechaIngreso"
        Me.txtFechaIngreso.Properties.Mask.EditMask = "d"
        Me.txtFechaIngreso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.txtFechaIngreso.Size = New System.Drawing.Size(114, 20)
        Me.txtFechaIngreso.TabIndex = 131
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(473, 47)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl11.TabIndex = 128
        Me.LabelControl11.Text = "F.Ing. Corporativo"
        '
        'txtFechaIngresoCorporacion
        '
        Me.txtFechaIngresoCorporacion.Enabled = False
        Me.txtFechaIngresoCorporacion.Location = New System.Drawing.Point(569, 42)
        Me.txtFechaIngresoCorporacion.MenuManager = Me.RibbonControl
        Me.txtFechaIngresoCorporacion.Name = "txtFechaIngresoCorporacion"
        Me.txtFechaIngresoCorporacion.Properties.Mask.EditMask = "d"
        Me.txtFechaIngresoCorporacion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.txtFechaIngresoCorporacion.Size = New System.Drawing.Size(114, 20)
        Me.txtFechaIngresoCorporacion.TabIndex = 129
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(473, 95)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl10.TabIndex = 126
        Me.LabelControl10.Text = "F. Fin Contrato"
        '
        'txtFechaFinContrato
        '
        Me.txtFechaFinContrato.Enabled = False
        Me.txtFechaFinContrato.Location = New System.Drawing.Point(569, 96)
        Me.txtFechaFinContrato.MenuManager = Me.RibbonControl
        Me.txtFechaFinContrato.Name = "txtFechaFinContrato"
        Me.txtFechaFinContrato.Properties.Mask.EditMask = "d"
        Me.txtFechaFinContrato.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.txtFechaFinContrato.Size = New System.Drawing.Size(114, 20)
        Me.txtFechaFinContrato.TabIndex = 127
        '
        'txtCargo
        '
        Me.txtCargo.Enabled = False
        Me.txtCargo.Location = New System.Drawing.Point(77, 94)
        Me.txtCargo.MenuManager = Me.RibbonControl
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(381, 20)
        Me.txtCargo.TabIndex = 125
        '
        'dtFechaIncorporacion
        '
        Me.dtFechaIncorporacion.EditValue = Nothing
        Me.dtFechaIncorporacion.Enabled = False
        Me.dtFechaIncorporacion.Location = New System.Drawing.Point(334, 172)
        Me.dtFechaIncorporacion.MenuManager = Me.RibbonControl
        Me.dtFechaIncorporacion.Name = "dtFechaIncorporacion"
        Me.dtFechaIncorporacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaIncorporacion.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaIncorporacion.Size = New System.Drawing.Size(124, 20)
        Me.dtFechaIncorporacion.TabIndex = 123
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(8, 97)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl8.TabIndex = 124
        Me.LabelControl8.Text = "Cargo"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(230, 175)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(98, 13)
        Me.LabelControl7.TabIndex = 122
        Me.LabelControl7.Text = "Fecha Incorporación"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(230, 149)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl6.TabIndex = 121
        Me.LabelControl6.Text = "FechaHasta"
        '
        'dtFechaHasta
        '
        Me.dtFechaHasta.EditValue = Nothing
        Me.dtFechaHasta.Location = New System.Drawing.Point(334, 146)
        Me.dtFechaHasta.MenuManager = Me.RibbonControl
        Me.dtFechaHasta.Name = "dtFechaHasta"
        Me.dtFechaHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaHasta.Size = New System.Drawing.Size(124, 20)
        Me.dtFechaHasta.TabIndex = 120
        '
        'dtFechaDesde
        '
        Me.dtFechaDesde.EditValue = Nothing
        Me.dtFechaDesde.Location = New System.Drawing.Point(77, 146)
        Me.dtFechaDesde.MenuManager = Me.RibbonControl
        Me.dtFechaDesde.Name = "dtFechaDesde"
        Me.dtFechaDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaDesde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaDesde.Size = New System.Drawing.Size(146, 20)
        Me.dtFechaDesde.TabIndex = 119
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(8, 171)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl4.TabIndex = 117
        Me.LabelControl4.Text = "Cantidad Dias"
        '
        'txtCantidadDias
        '
        Me.txtCantidadDias.Enabled = False
        Me.txtCantidadDias.Location = New System.Drawing.Point(77, 172)
        Me.txtCantidadDias.MenuManager = Me.RibbonControl
        Me.txtCantidadDias.Name = "txtCantidadDias"
        Me.txtCantidadDias.Size = New System.Drawing.Size(146, 20)
        Me.txtCantidadDias.TabIndex = 118
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(8, 45)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl3.TabIndex = 115
        Me.LabelControl3.Text = "Solicitante"
        '
        'txtSolicitante
        '
        Me.txtSolicitante.Enabled = False
        Me.txtSolicitante.Location = New System.Drawing.Point(77, 42)
        Me.txtSolicitante.MenuManager = Me.RibbonControl
        Me.txtSolicitante.Name = "txtSolicitante"
        Me.txtSolicitante.Size = New System.Drawing.Size(381, 20)
        Me.txtSolicitante.TabIndex = 116
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(8, 145)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl5.TabIndex = 113
        Me.LabelControl5.Text = "Fecha Desde"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(8, 123)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl9.TabIndex = 107
        Me.LabelControl9.Text = "Empleado"
        '
        'txtEmpleado
        '
        Me.txtEmpleado.Enabled = False
        Me.txtEmpleado.Location = New System.Drawing.Point(77, 120)
        Me.txtEmpleado.MenuManager = Me.RibbonControl
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Size = New System.Drawing.Size(381, 20)
        Me.txtEmpleado.TabIndex = 108
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(8, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl1.TabIndex = 94
        Me.LabelControl1.Text = "Local"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(480, 123)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(15, 13)
        Me.LabelControl2.TabIndex = 95
        Me.LabelControl2.Text = "Dni"
        '
        'txtLocal
        '
        Me.txtLocal.Enabled = False
        Me.txtLocal.Location = New System.Drawing.Point(77, 16)
        Me.txtLocal.MenuManager = Me.RibbonControl
        Me.txtLocal.Name = "txtLocal"
        Me.txtLocal.Size = New System.Drawing.Size(381, 20)
        Me.txtLocal.TabIndex = 96
        '
        'txtDni
        '
        Me.txtDni.Enabled = False
        Me.txtDni.Location = New System.Drawing.Point(569, 120)
        Me.txtDni.MenuManager = Me.RibbonControl
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(114, 20)
        Me.txtDni.TabIndex = 97
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'VacacionesDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 431)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "VacacionesDetails"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "VACACIONES"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaIngreso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaIngresoCorporacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaFinContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaIncorporacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaIncorporacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidadDias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSolicitante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLocal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDni.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnAprobar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAnular As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSolicitante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLocal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDni As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtFechaIncorporacion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFechaHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtFechaDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCantidadDias As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCargo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFechaIngreso As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFechaIngresoCorporacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFechaFinContrato As DevExpress.XtraEditors.TextEdit
End Class
