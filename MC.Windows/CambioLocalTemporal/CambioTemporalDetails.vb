Imports MC.Data
Imports MC.Framework
Public Class CambioTemporalDetails
    Dim CambioLocalTemporalBE As New CambioLocalTemporalBE
    Dim IdEmpleado As Integer
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen

    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub CambioTemporalDetails_Load(sender As Object, e As EventArgs) Handles Me.Load

        If CambioLocalTemporalDAO.IdCambioTemporal <> 0 Then

            CambioLocalTemporalBE = CambioLocalTemporalDAO.GetCambioTemporalByID(CambioLocalTemporalDAO.IdCambioTemporal)
            With CambioLocalTemporalBE
                txtSolicitante.Text = CambioLocalTemporalBE.SOLICITANTENOMBRE
                txtEmpleado.Text = CambioLocalTemporalBE.EMPLEADONOMBRE
                txtLocalOrigen.Text = CambioLocalTemporalBE.EMPLEADOLOCAL
                txtLocalDestino.Text = CambioLocalTemporalBE.NUEVOLOCAL
                txtDniEmpleado.Text = CambioLocalTemporalBE.EMPLEADODNI
                txtMotivo.Text = CambioLocalTemporalBE.MOTIVO
                dtFechaInicio.EditValue = CambioLocalTemporalBE.FECHAINICIOCAMBIO
                dtFechaFinal.EditValue = CambioLocalTemporalBE.FECHAFINCAMBIO
                IdEmpleado = CambioLocalTemporalBE.IDEMPLEADO
            End With
            txtSolicitante.Enabled = False
            txtEmpleado.Enabled = False
            txtLocalOrigen.Enabled = False
            txtLocalDestino.Enabled = False
            txtDniEmpleado.Enabled = False
            txtMotivo.Enabled = False
            dtFechaInicio.Enabled = False
            dtFechaFinal.Enabled = False
        End If
    End Sub

    Private Sub btnAprobar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAprobar.ItemClick
        If MessageBox.Show("¿Esta seguro de aprobar el cambio temporal?", "Aprobar cambio temporal", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            If CambioLocalTemporalDAO.AprobarCambioTemporal(CambioLocalTemporalDAO.IdCambioTemporal, BDCentralDAO.UsuarioBE.IDUsuario) Then
                Me.Close()
            Else
                MessageBox.Show("Error al aprobar")
            End If
        End If
    End Sub

    Private Sub btnAnular_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnular.ItemClick
        If MessageBox.Show("¿Esta seguro de anular el cambio temporal?", "Anular cambio temporal", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then

            If CambioLocalTemporalDAO.AnularCambioTemporal(CambioLocalTemporalDAO.IdCambioTemporal, BDCentralDAO.UsuarioBE.IDUsuario) Then
                Me.Close()
            Else
                MessageBox.Show("Error al anular")
            End If
        End If
    End Sub

    Private Sub btnHistorialEmpleado_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHistorialEmpleado.ItemClick
        Dim idempleado = CambioLocalTemporalBE.IDEMPLEADO
        BDAccionPersonalDAO.IdEmpleado = idempleado
        If BDAccionPersonalDAO.IdEmpleado <> 0 Then
            Dim MiForm As New EmpleadoHistorial

            Nombre = txtEmpleado.Text
            NombreLog = Me.Text ' formulario , reporte,
            DetalleLog = "HISTORIAL EMPLEADO " & Nombre  ' acción: impresión, exportar, tb poner filtros , lo que se
            BDCentralDAO.AccesoLogIns(IDSistema, BDCentralDAO.UsuarioBE.IDUsuario, DetalleLog, NombreLog)


            MiForm.ShowDialog()
        End If
    End Sub
End Class