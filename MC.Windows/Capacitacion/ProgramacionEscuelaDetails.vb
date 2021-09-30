Imports DevExpress.XtraBars
Imports MC.Data
Imports MC.Framework
Public Class ProgramacionEscuelaDetails
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = "PROGRAMACIÓN DE ESCUELA"
        Me.txtIdEscuela.Text = 0
        Me.txtNumeroEscuela.Enabled = False
        Me.txtIdEscuela.Enabled = False
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CargarTipoEscuela()

    End Sub
    Private Sub CargarTipoEscuela()
        ControlesDevExpress.InitGridViewColumn(GridViewTipoEscuela, "ID", "IDCAPACITACIONTIPOESCUELA", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewTipoEscuela, "ESCUELA", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewTipoEscuela
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleTipoEscuela.Properties.DataSource = CapacitacionDAO.ProgramacionCapacitacionTipoEscuelaActivosList()
        sleTipoEscuela.Properties.DisplayMember = "DESCRIPCION"
        sleTipoEscuela.Properties.ValueMember = "IDCAPACITACIONTIPOESCUELA"
        sleTipoEscuela.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub sleTipoEscuela_EditValueChanged(sender As Object, e As EventArgs) Handles sleTipoEscuela.EditValueChanged
        If sleTipoEscuela.EditValue > 0 Then
            Dim dt As DataTable = CapacitacionDAO.ObtenerNumeroEscuelaxTipoEscuela(sleTipoEscuela.EditValue)
            txtNumeroEscuela.Text = dt.Rows(0)("NUMEROCAPACITACION")
        End If
    End Sub

    Private Sub btnGrabar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnGrabar.ItemClick
        If Validar() Then
            If MessageBox.Show("Estas seguro de grabar el registro de escuela", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                If CapacitacionDAO.ProgamacionEsculaIns(txtIdEscuela.Text, sleTipoEscuela.EditValue, txtNota.Text, BDCentralDAO.UsuarioBE.IDUsuario) Then
                    Me.Close()
                Else
                    MessageBox.Show("Error de conexión con servidor")
                End If
            End If
        End If
    End Sub

    Private Function Validar()
        Dim Result As Boolean = True
        DxErrorProvider1.ClearErrors()
        If sleTipoEscuela.EditValue Is Nothing Then
            DxErrorProvider1.SetError(sleTipoEscuela, "Dato obligatorio")
            Result = False
        End If
        If txtNota.Text = "" Then
            DxErrorProvider1.SetError(txtNota, "Dato obligatorio")
            Result = False
        End If
        If (txtNota.Text < 0 Or txtNota.Text > 20) Then
            DxErrorProvider1.SetError(txtNota, "La nota no puede ser menor de 0 y mayor a 20")
            Result = False
        End If

        Return Result
    End Function
End Class