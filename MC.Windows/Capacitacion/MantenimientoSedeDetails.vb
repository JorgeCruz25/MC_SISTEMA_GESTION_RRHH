Imports MC.Framework
Imports MC.Data
Public Class MantenimientoSedeDetails
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = "CAPACITACIÓN SEDE"
        Me.txtIdCede.Text = 0
        Me.txtIdCede.Enabled = False
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CargarCede()
    End Sub
    Private Sub CargarCede()
        ControlesDevExpress.InitGridViewColumn(GridViewCede, "ID", "IDLOCAL", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewCede, "CEDE", "RAZONCOMERCIAL", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewCede
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleCede.Properties.DataSource = CapacitacionDAO.ProgramacionCapacitacionCedeRegistroList()
        sleCede.Properties.DisplayMember = "RAZONCOMERCIAL"
        sleCede.Properties.ValueMember = "IDLOCAL"
        sleCede.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnGrabar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGrabar.ItemClick
        If Validar() Then
            If CapacitacionDAO.MantenimientoCedeIns(sleCede.EditValue, BDCentralDAO.UsuarioBE.IDUsuario) Then
                Me.Close()
            Else
                MessageBox.Show("Error de conexion con el servidor")
            End If
        End If
    End Sub
    Private Function Validar()
        Dim Result As Boolean = True
        DxErrorProvider1.ClearErrors()
        If sleCede.EditValue Is Nothing Then
            DxErrorProvider1.SetError(sleCede, "Dato obligatorio")
            Result = False
        End If
        Return Result
    End Function
End Class