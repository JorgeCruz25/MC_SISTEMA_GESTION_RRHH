<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambioTemporalDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CambioTemporalDetails))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAprobar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAnular = New DevExpress.XtraBars.BarButtonItem()
        Me.btnHistorialEmpleado = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.txtSolicitante = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtLocalOrigen = New DevExpress.XtraEditors.TextEdit()
        Me.txtLocalDestino = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmpleado = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDniEmpleado = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMotivo = New DevExpress.XtraEditors.TextEdit()
        Me.dtFechaInicio = New DevExpress.XtraEditors.DateEdit()
        Me.dtFechaFinal = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSolicitante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLocalOrigen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLocalDestino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDniEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMotivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaFinal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnCerrar, Me.btnAprobar, Me.btnAnular, Me.btnHistorialEmpleado})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 5
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(659, 143)
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
        'btnAnular
        '
        Me.btnAnular.Caption = "Anular"
        Me.btnAnular.Glyph = CType(resources.GetObject("btnAnular.Glyph"), System.Drawing.Image)
        Me.btnAnular.Id = 3
        Me.btnAnular.LargeGlyph = CType(resources.GetObject("btnAnular.LargeGlyph"), System.Drawing.Image)
        Me.btnAnular.Name = "btnAnular"
        '
        'btnHistorialEmpleado
        '
        Me.btnHistorialEmpleado.Caption = "Historial Empleado"
        Me.btnHistorialEmpleado.Glyph = CType(resources.GetObject("btnHistorialEmpleado.Glyph"), System.Drawing.Image)
        Me.btnHistorialEmpleado.Id = 4
        Me.btnHistorialEmpleado.LargeGlyph = CType(resources.GetObject("btnHistorialEmpleado.LargeGlyph"), System.Drawing.Image)
        Me.btnHistorialEmpleado.Name = "btnHistorialEmpleado"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Cambio Temporal"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAprobar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAnular)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnHistorialEmpleado)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 258)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(659, 31)
        '
        'txtSolicitante
        '
        Me.txtSolicitante.Enabled = False
        Me.txtSolicitante.Location = New System.Drawing.Point(81, 149)
        Me.txtSolicitante.MenuManager = Me.RibbonControl
        Me.txtSolicitante.Name = "txtSolicitante"
        Me.txtSolicitante.Size = New System.Drawing.Size(387, 20)
        Me.txtSolicitante.TabIndex = 75
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(10, 156)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl6.TabIndex = 74
        Me.LabelControl6.Text = "Solicitante"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 208)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl1.TabIndex = 76
        Me.LabelControl1.Text = "Local Origen"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 234)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl2.TabIndex = 77
        Me.LabelControl2.Text = "Local Destino"
        '
        'txtLocalOrigen
        '
        Me.txtLocalOrigen.Enabled = False
        Me.txtLocalOrigen.Location = New System.Drawing.Point(81, 201)
        Me.txtLocalOrigen.MenuManager = Me.RibbonControl
        Me.txtLocalOrigen.Name = "txtLocalOrigen"
        Me.txtLocalOrigen.Size = New System.Drawing.Size(387, 20)
        Me.txtLocalOrigen.TabIndex = 78
        '
        'txtLocalDestino
        '
        Me.txtLocalDestino.Enabled = False
        Me.txtLocalDestino.Location = New System.Drawing.Point(81, 227)
        Me.txtLocalDestino.MenuManager = Me.RibbonControl
        Me.txtLocalDestino.Name = "txtLocalDestino"
        Me.txtLocalDestino.Size = New System.Drawing.Size(387, 20)
        Me.txtLocalDestino.TabIndex = 79
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 182)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl3.TabIndex = 80
        Me.LabelControl3.Text = "Empleado"
        '
        'txtEmpleado
        '
        Me.txtEmpleado.Enabled = False
        Me.txtEmpleado.Location = New System.Drawing.Point(81, 175)
        Me.txtEmpleado.MenuManager = Me.RibbonControl
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Size = New System.Drawing.Size(387, 20)
        Me.txtEmpleado.TabIndex = 81
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(484, 204)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl4.TabIndex = 84
        Me.LabelControl4.Text = "Dni Empleado"
        '
        'txtDniEmpleado
        '
        Me.txtDniEmpleado.Enabled = False
        Me.txtDniEmpleado.Location = New System.Drawing.Point(557, 201)
        Me.txtDniEmpleado.MenuManager = Me.RibbonControl
        Me.txtDniEmpleado.Name = "txtDniEmpleado"
        Me.txtDniEmpleado.Size = New System.Drawing.Size(99, 20)
        Me.txtDniEmpleado.TabIndex = 85
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(484, 227)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl5.TabIndex = 86
        Me.LabelControl5.Text = "Motivo"
        '
        'txtMotivo
        '
        Me.txtMotivo.Enabled = False
        Me.txtMotivo.Location = New System.Drawing.Point(557, 227)
        Me.txtMotivo.MenuManager = Me.RibbonControl
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(99, 20)
        Me.txtMotivo.TabIndex = 87
        '
        'dtFechaInicio
        '
        Me.dtFechaInicio.EditValue = Nothing
        Me.dtFechaInicio.Location = New System.Drawing.Point(557, 149)
        Me.dtFechaInicio.MenuManager = Me.RibbonControl
        Me.dtFechaInicio.Name = "dtFechaInicio"
        Me.dtFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaInicio.Size = New System.Drawing.Size(99, 20)
        Me.dtFechaInicio.TabIndex = 88
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.EditValue = Nothing
        Me.dtFechaFinal.Location = New System.Drawing.Point(557, 175)
        Me.dtFechaFinal.MenuManager = Me.RibbonControl
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaFinal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaFinal.Size = New System.Drawing.Size(99, 20)
        Me.dtFechaFinal.TabIndex = 89
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(484, 156)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl7.TabIndex = 90
        Me.LabelControl7.Text = "FechaDesde"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(484, 182)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl8.TabIndex = 91
        Me.LabelControl8.Text = "Fecha Hasta"
        '
        'CambioTemporalDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 289)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.dtFechaFinal)
        Me.Controls.Add(Me.dtFechaInicio)
        Me.Controls.Add(Me.txtMotivo)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtDniEmpleado)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtEmpleado)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtLocalDestino)
        Me.Controls.Add(Me.txtLocalOrigen)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtSolicitante)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "CambioTemporalDetails"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "CAMBIO TEMPORAL"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSolicitante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLocalOrigen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLocalDestino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDniEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMotivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaFinal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAprobar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtSolicitante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLocalOrigen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLocalDestino As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDniEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMotivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtFechaInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtFechaFinal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAnular As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnHistorialEmpleado As DevExpress.XtraBars.BarButtonItem
End Class
