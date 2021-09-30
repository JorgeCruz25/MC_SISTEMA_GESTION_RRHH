<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncidenteAccidenteDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IncidenteAccidenteDetails))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAprobar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAnular = New DevExpress.XtraBars.BarButtonItem()
        Me.btnHistorialEmpleado = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSolicitante = New DevExpress.XtraEditors.TextEdit()
        Me.txtDniCliente = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCliente = New DevExpress.XtraEditors.TextEdit()
        Me.txtDniEmpleado = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmpleado = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFechaIncidente = New DevExpress.XtraEditors.DateEdit()
        Me.txtLocal = New DevExpress.XtraEditors.TextEdit()
        Me.txtArea = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTipo = New DevExpress.XtraEditors.TextEdit()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtSolicitante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDniCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDniEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaIncidente.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaIncidente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLocal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibbonControl.Size = New System.Drawing.Size(689, 143)
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
        Me.RibbonPage1.Text = "Incidente Accidente"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAprobar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnHistorialEmpleado)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAnular)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 322)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(689, 31)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelControl8)
        Me.GroupBox1.Controls.Add(Me.txtSolicitante)
        Me.GroupBox1.Controls.Add(Me.txtDniCliente)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Controls.Add(Me.txtDniEmpleado)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl9)
        Me.GroupBox1.Controls.Add(Me.txtEmpleado)
        Me.GroupBox1.Controls.Add(Me.LabelControl7)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.dtFechaIncidente)
        Me.GroupBox1.Controls.Add(Me.txtLocal)
        Me.GroupBox1.Controls.Add(Me.txtArea)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.txtTipo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 149)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(675, 167)
        Me.GroupBox1.TabIndex = 108
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Solicitud"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(8, 43)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl8.TabIndex = 115
        Me.LabelControl8.Text = "Solicitante"
        '
        'txtSolicitante
        '
        Me.txtSolicitante.Enabled = False
        Me.txtSolicitante.Location = New System.Drawing.Point(77, 42)
        Me.txtSolicitante.MenuManager = Me.RibbonControl
        Me.txtSolicitante.Name = "txtSolicitante"
        Me.txtSolicitante.Size = New System.Drawing.Size(296, 20)
        Me.txtSolicitante.TabIndex = 116
        '
        'txtDniCliente
        '
        Me.txtDniCliente.Enabled = False
        Me.txtDniCliente.Location = New System.Drawing.Point(467, 123)
        Me.txtDniCliente.MenuManager = Me.RibbonControl
        Me.txtDniCliente.Name = "txtDniCliente"
        Me.txtDniCliente.Size = New System.Drawing.Size(99, 20)
        Me.txtDniCliente.TabIndex = 114
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(384, 130)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl5.TabIndex = 113
        Me.LabelControl5.Text = "Dni Cliente"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(8, 126)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl6.TabIndex = 111
        Me.LabelControl6.Text = "Cliente"
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(77, 123)
        Me.txtCliente.MenuManager = Me.RibbonControl
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(296, 20)
        Me.txtCliente.TabIndex = 112
        '
        'txtDniEmpleado
        '
        Me.txtDniEmpleado.Enabled = False
        Me.txtDniEmpleado.Location = New System.Drawing.Point(467, 97)
        Me.txtDniEmpleado.MenuManager = Me.RibbonControl
        Me.txtDniEmpleado.Name = "txtDniEmpleado"
        Me.txtDniEmpleado.Size = New System.Drawing.Size(99, 20)
        Me.txtDniEmpleado.TabIndex = 110
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(384, 104)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl4.TabIndex = 109
        Me.LabelControl4.Text = "Dni Empleado"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(8, 100)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl9.TabIndex = 107
        Me.LabelControl9.Text = "Empleado"
        '
        'txtEmpleado
        '
        Me.txtEmpleado.Enabled = False
        Me.txtEmpleado.Location = New System.Drawing.Point(77, 97)
        Me.txtEmpleado.MenuManager = Me.RibbonControl
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Size = New System.Drawing.Size(296, 20)
        Me.txtEmpleado.TabIndex = 108
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(384, 43)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl7.TabIndex = 104
        Me.LabelControl7.Text = "Fecha Incidente"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(8, 70)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl1.TabIndex = 94
        Me.LabelControl1.Text = "Local"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(384, 74)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl2.TabIndex = 95
        Me.LabelControl2.Text = "Area Ocurrencia"
        '
        'dtFechaIncidente
        '
        Me.dtFechaIncidente.EditValue = Nothing
        Me.dtFechaIncidente.Location = New System.Drawing.Point(467, 40)
        Me.dtFechaIncidente.MenuManager = Me.RibbonControl
        Me.dtFechaIncidente.Name = "dtFechaIncidente"
        Me.dtFechaIncidente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaIncidente.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFechaIncidente.Size = New System.Drawing.Size(99, 20)
        Me.dtFechaIncidente.TabIndex = 102
        '
        'txtLocal
        '
        Me.txtLocal.Enabled = False
        Me.txtLocal.Location = New System.Drawing.Point(77, 67)
        Me.txtLocal.MenuManager = Me.RibbonControl
        Me.txtLocal.Name = "txtLocal"
        Me.txtLocal.Size = New System.Drawing.Size(296, 20)
        Me.txtLocal.TabIndex = 96
        '
        'txtArea
        '
        Me.txtArea.Enabled = False
        Me.txtArea.Location = New System.Drawing.Point(467, 71)
        Me.txtArea.MenuManager = Me.RibbonControl
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(198, 20)
        Me.txtArea.TabIndex = 97
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(8, 23)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl3.TabIndex = 98
        Me.LabelControl3.Text = "Tipo"
        '
        'txtTipo
        '
        Me.txtTipo.Enabled = False
        Me.txtTipo.Location = New System.Drawing.Point(77, 16)
        Me.txtTipo.MenuManager = Me.RibbonControl
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(296, 20)
        Me.txtTipo.TabIndex = 99
        '
        'IncidenteAccidenteDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 353)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "IncidenteAccidenteDetails"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "INCIDENTE ACCIDENTE"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtSolicitante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDniCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDniEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaIncidente.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaIncidente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLocal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAprobar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDniEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmpleado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFechaIncidente As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtLocal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtArea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTipo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDniCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSolicitante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAnular As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnHistorialEmpleado As DevExpress.XtraBars.BarButtonItem
End Class
