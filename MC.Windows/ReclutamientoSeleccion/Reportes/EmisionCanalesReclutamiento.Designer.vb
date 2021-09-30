<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmisionCanalesReclutamiento
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnEmitir = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnMas = New DevExpress.XtraEditors.SimpleButton()
        Me.btnMenos = New DevExpress.XtraEditors.SimpleButton()
        Me.txtYear = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.txtYear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEmitir
        '
        Me.btnEmitir.Location = New System.Drawing.Point(230, 58)
        Me.btnEmitir.Name = "btnEmitir"
        Me.btnEmitir.Size = New System.Drawing.Size(102, 42)
        Me.btnEmitir.TabIndex = 1
        Me.btnEmitir.Text = "Emitir"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(7, 78)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "AÑO :"
        '
        'btnMas
        '
        Me.btnMas.Location = New System.Drawing.Point(148, 72)
        Me.btnMas.Name = "btnMas"
        Me.btnMas.Size = New System.Drawing.Size(35, 28)
        Me.btnMas.TabIndex = 5
        Me.btnMas.Text = "+"
        '
        'btnMenos
        '
        Me.btnMenos.Location = New System.Drawing.Point(189, 72)
        Me.btnMenos.Name = "btnMenos"
        Me.btnMenos.Size = New System.Drawing.Size(35, 28)
        Me.btnMenos.TabIndex = 6
        Me.btnMenos.Text = "-"
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(42, 75)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Properties.Appearance.Options.UseFont = True
        Me.txtYear.Properties.Appearance.Options.UseTextOptions = True
        Me.txtYear.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtYear.Properties.ReadOnly = True
        Me.txtYear.Size = New System.Drawing.Size(100, 20)
        Me.txtYear.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 22)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "CANALES DE RECLUTAMIENTO"
        '
        'EmisionCanalesReclutamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.btnMenos)
        Me.Controls.Add(Me.btnMas)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnEmitir)
        Me.Name = "EmisionCanalesReclutamiento"
        Me.Size = New System.Drawing.Size(468, 283)
        CType(Me.txtYear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEmitir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnMas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMenos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtYear As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
End Class
