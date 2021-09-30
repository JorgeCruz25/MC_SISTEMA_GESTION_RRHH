Imports MC.Data
Imports MC.Framework
Public Class IncidenteAccidenteDetails
    Dim IncidenteAccidenteBE As New IncidenteAccidenteBE
    Dim idempleado As Integer
    Sub New()

        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterParent
    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub IncidenteAccidenteDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        If IncidenteAccidenteDAO.IdIncidenteAccidente <> 0 Then
            IncidenteAccidenteBE = IncidenteAccidenteDAO.GetIncidenteAccidenteByID(IncidenteAccidenteDAO.IdIncidenteAccidente)
            With IncidenteAccidenteBE
                txtTipo.Text = IncidenteAccidenteBE.TIPOINCIDENTEACCIDENTE
                txtLocal.Text = IncidenteAccidenteBE.RAZONCOMERCIAL
                txtSolicitante.Text = IncidenteAccidenteBE.NOMBRESOLICITANTE
                txtEmpleado.Text = IncidenteAccidenteBE.EMPLEADONOMBRE
                txtDniEmpleado.Text = IncidenteAccidenteBE.EMPLEADODNI
                txtCliente.Text = IncidenteAccidenteBE.CLIENTENOMBRE
                txtDniCliente.Text = IncidenteAccidenteBE.CLIENTEDNI
                txtArea.Text = IncidenteAccidenteBE.AREAOCURRENCIA
                dtFechaIncidente.EditValue = IncidenteAccidenteBE.FECHAINCIDENTEACCIDENTE
                idempleado = IncidenteAccidenteBE.IDEMPLEADO
                .IDUSUARIO = BDCentralDAO.UsuarioBE.IDUsuario
            End With
            txtTipo.Enabled = False
            txtLocal.Enabled = False
            txtSolicitante.Enabled = False
            txtEmpleado.Enabled = False
            txtArea.Enabled = False
            txtDniEmpleado.Enabled = False
            dtFechaIncidente.Enabled = False
        End If
    End Sub

    Private Sub btnAprobar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAprobar.ItemClick
        If MessageBox.Show("¿Esta seguro de aprobar el incidente accidente?", "Aprobar incidente accidente", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            If IncidenteAccidenteDAO.AprobarIncidenteAccidente(IncidenteAccidenteBE) Then
                Me.Close()
            Else
                MessageBox.Show("Error al aprobar")
            End If
        End If
    End Sub

    Private Sub btnAnular_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnular.ItemClick
        If MessageBox.Show("¿Esta seguro de anular el incidente accidente?", "Anular incidente accidente", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            If IncidenteAccidenteDAO.AnularIncidenteAccidente(IncidenteAccidenteBE) Then
                Me.Close()
            Else
                MessageBox.Show("Error al anular")
            End If
        End If
    End Sub

    Private Sub btnHistorialEmpleado_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHistorialEmpleado.ItemClick

        BDAccionPersonalDAO.IdEmpleado = idempleado
        If BDAccionPersonalDAO.IdEmpleado <> 0 Then
            Dim MiForm As New EmpleadoHistorial
            Nombre = txtEmpleado.Text
            NumeroDocumento = txtDniEmpleado.Text
            NombreLog = Me.Text ' formulario , reporte,
            DetalleLog = "HISTORIAL EMPLEADO " & Nombre & " CON NUMERO DE DOC. " & NumeroDocumento ' acción: impresión, exportar, tb poner filtros , lo que se
            BDCentralDAO.AccesoLogIns(IDSistema, BDCentralDAO.UsuarioBE.IDUsuario, DetalleLog, NombreLog)
            MiForm.ShowDialog()
        Else
            MessageBox.Show("Este incidente accidente no fue de un colaborador, fue de una persona externa a la empresa", "Incidente Accidente", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If
    End Sub
End Class