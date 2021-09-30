Imports MC.Framework
Imports MC.Data
Public Class ClaseDetails
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterParent

        CargarCede()
        Dim dtdatos As DataTable = CapacitacionDAO.ClaseCapacitacionDetalleGetId(CapacitacionDAO.IdCapacitacionDetalle)
            If dtdatos.Rows.Count > 0 Then
            sleCede.EditValue = dtdatos.Rows(0)("IDCAPACITACIONCEDE")
            txtNumeroAula.Text = dtdatos.Rows(0)("NUMEROAULA")
                dtFechaCapacitacion.EditValue = dtdatos.Rows(0)("FECHACAPACITACION")
                teHoraInicio.EditValue = dtdatos.Rows(0)("HORAINCIO")
                teHoraFin.EditValue = dtdatos.Rows(0)("HORAFINAL")
            'If dtdatos.Rows(0)("IDCAPACITACIONESTADO") = 1 Then
            '    CargarCede() 'Lista solo los locales activos
            'Else
            '    CargarCede(2) 'Lista todos los locales activos
            'End If
            'Else
            '        Me.Close()
        End If


        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub CargarCede()
        ControlesDevExpress.InitGridViewColumn(GridViewCedeCapacitacion, "ID", "IDCAPACITACIONCEDE", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewCedeCapacitacion, "CEDE", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewCedeCapacitacion
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleCede.Properties.DataSource = CapacitacionDAO.ProgramacionCapacitacionCedeList()
        sleCede.Properties.DisplayMember = "DESCRIPCION"
        sleCede.Properties.ValueMember = "IDCAPACITACIONCEDE"
        sleCede.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnGrabar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGrabar.ItemClick
        If Validar() Then

            Try
                If MessageBox.Show("Estas seguro de realizar el registro", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    If CapacitacionDAO.ProgramacionCapacitacionDetalleIns(CapacitacionDAO.IdCapacitacionDetalle, CapacitacionDAO.IdCapacitacion, sleCede.EditValue, txtNumeroAula.Text, dtFechaCapacitacion.EditValue, teHoraInicio.Text, teHoraFin.Text, BDCentralDAO.UsuarioBE.IDUsuario) Then
                        Me.Close()
                    End If
                End If

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub sleCede_TextChanged(sender As Object, e As EventArgs) Handles sleCede.TextChanged
        If sleCede.EditValue IsNot Nothing Then
            If sleCede.EditValue = 1 Then
                txtNumeroAula.Visible = True
                lblNumeroAula.Visible = True
            Else
                txtNumeroAula.Visible = False
                lblNumeroAula.Visible = False
            End If
        End If
    End Sub

    Private Function Validar() As Boolean
        Dim Result As Boolean = True

        DxErrorProvider1.ClearErrors()

        If LTrim(sleCede.EditValue) Is Nothing Then
            DxErrorProvider1.SetError(sleCede, "Dato obligatorio")
            Result = False
        End If
        If LTrim(dtFechaCapacitacion.EditValue) Is Nothing Then
            DxErrorProvider1.SetError(dtFechaCapacitacion, "Dato obligatorio")
            Result = False
        End If
        If LTrim(teHoraInicio.EditValue) Is Nothing Then
            DxErrorProvider1.SetError(teHoraInicio, "Dato obligatorio")
            Result = False
        End If
        If LTrim(teHoraFin.EditValue) Is Nothing Then
            DxErrorProvider1.SetError(teHoraFin, "Dato obligatorio")
            Result = False
        End If
        If teHoraInicio.Text >= teHoraFin.Text Then
            MessageBox.Show("La Hora de Inicio no puede se mayor o igual a la Hora Final ", "Mensaje Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Result = False
        End If

        Return Result
    End Function
End Class