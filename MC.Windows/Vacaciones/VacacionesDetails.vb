Imports DevExpress.XtraBars
Imports MC.Data
Imports MC.Framework
Public Class VacacionesDetails
    Dim VacacionesBE As New VacacionesBE
    Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterParent
    End Sub

    Private Sub VacacionesDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        If VacacionesDAO.IdVacaciones <> 0 Then
            VacacionesBE = VacacionesDAO.GetVacacionesByID(VacacionesDAO.IdVacaciones)
            With VacacionesBE
                txtLocal.Text = .RAZONCOMERCIAL
                txtSolicitante.Text = .NOMBRESOLICITANTE
                txtEmpleado.Text = .NOMBREEMPLEADO
                txtDni.Text = .DNIEMPLEADO
                txtCargo.Text = .CARGOEMPLEADO
                dtFechaDesde.EditValue = .FECHADESDE
                dtFechaHasta.EditValue = .FECHAHASTA
                txtCantidadDias.Text = .TOTALDIAS
                dtFechaIncorporacion.EditValue = .FECHAINCORPORACION
                txtFechaIngreso.Text = .FECHAINGRESOCOMPANIA
                txtFechaIngresoCorporacion.Text = .FECHAINGRESOCORPORATIVO
                txtFechaFinContrato.Text = .FECHAFINCONTRATO
                .IDUSUARIO = BDCentralDAO.UsuarioBE.IDUsuario
            End With
        End If
    End Sub
    Private Function Validar() As Boolean

        DxErrorProvider1.ClearErrors()
        Dim Result As Boolean = True

        If dtFechaDesde.EditValue Is Nothing Or dtFechaDesde.EditValue Is "" Then
            DxErrorProvider1.SetError(dtFechaDesde, "Dato obligatorio")
            Result = False
        End If
        If dtFechaHasta.EditValue Is Nothing Or dtFechaHasta.EditValue Is "" Then
            DxErrorProvider1.SetError(dtFechaHasta, "Dato obligatorio")
            Result = False
        End If
        If dtFechaHasta.EditValue < dtFechaDesde.EditValue Then
            DxErrorProvider1.SetError(dtFechaHasta, "La Fecha de inicio no puede ser mayor a la fecha final")
            Result = False
        End If
        Dim dt As DataTable
        dt = VacacionesDAO.ValidarVacacionesProceso(VacacionesDAO.IdVacaciones, VacacionesDAO.IdEmpleado, dtFechaHasta.EditValue, dtFechaDesde.EditValue)
        If dt.Rows(0)("RESULT") <> 11 Then
            MessageBox.Show(dt.Rows(0)("MENSAJE"))
            Result = False
        End If
        If Result Then
            With VacacionesBE
                .IDVACACIONES = VacacionesDAO.IdVacaciones
                .FECHAHASTA = dtFechaHasta.EditValue
                .FECHADESDE = dtFechaDesde.EditValue
            End With
        End If

        Return Result

    End Function

    Private Sub btnCerrar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub
    Private Sub btnAprobar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAprobar.ItemClick
        If Validar() Then
            If MessageBox.Show("¿Esta seguro de Aprobar la solicitud de vacaciones?", "Aprobar Solicitud de Vacaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                If VacacionesDAO.AprobarVacaciones(VacacionesBE) Then
                    Me.Close()
                Else
                    MessageBox.Show("Error al aprobar")
                End If
            End If
        End If
    End Sub
    Private Sub btnAnular_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAnular.ItemClick

        If MessageBox.Show("¿Esta seguro de anular la solicitud de vacaciones?", "Anular Solicitud de Vacaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            If VacacionesDAO.AnularVacaciones(VacacionesBE) Then
                Me.Close()
            Else
                MessageBox.Show("Error al aprobar")
            End If
        End If
    End Sub




    Private Sub dtFechaDesde_TextChanged(sender As Object, e As EventArgs) Handles dtFechaDesde.TextChanged
        txtCantidadDias.Text = DateDiff(DateInterval.Day, dtFechaDesde.EditValue, dtFechaHasta.EditValue) + 1
        Dim currentDate As DateTime
        currentDate = dtFechaHasta.EditValue
        currentDate = currentDate.AddDays(1)
        dtFechaIncorporacion.EditValue = currentDate
    End Sub

    Private Sub dtFechaHasta_TextChanged(sender As Object, e As EventArgs) Handles dtFechaHasta.TextChanged
        txtCantidadDias.Text = DateDiff(DateInterval.Day, dtFechaDesde.EditValue, dtFechaHasta.EditValue) + 1

        Dim currentDate As DateTime
        currentDate = dtFechaHasta.EditValue
        currentDate = currentDate.AddDays(1)
        dtFechaIncorporacion.EditValue = currentDate
    End Sub

End Class