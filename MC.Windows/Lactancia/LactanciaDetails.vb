Imports DevExpress.XtraBars
Imports MC.Data
Imports MC.Framework
Public Class LactanciaDetails
    Dim IDEMPLEADO As Integer
    Dim LactanciaBE As New LactanciaBE
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterParent

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Me.Close()
    End Sub

    Private Sub LactanciaDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        If LactanciaDAO.IdLactancia <> 0 Then
            LactanciaBE = LactanciaDAO.GetLactanciaByID(LactanciaDAO.IdLactancia)
            With LactanciaBE
                txtSolicitante.Text = .NOMBRESOLICITANTE
                txtRazonSocial.Text = .RAZONSOCIAL
                txtRazonComercial.Text = .RAZONCOMERCIAL
                txtEmpleado.Text = .NOMBREEMPLEADO
                txtFechaIngreso.Text = .FECHAINGRESO
                txtFechaNacimiento.Text = .FECHANACIMIENTO
                txtBeneficioInicio.Text = .FECHABENEFICIOINICIO
                txtBeneficioFin.Text = .FECHABENEFICIOFINAL
                txtCargo.Text = .CARGOEMPLEADO
                txtTurno.Text = .TURNO
                txtDni.Text = .NUMERODOCUMENTO
                IDEMPLEADO = .IDEMPLEADO
                .IDUSUARIO = BDCentralDAO.UsuarioBE.IDUsuario
            End With
        End If
    End Sub

    Private Sub btnAprobar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAprobar.ItemClick
        If MessageBox.Show("¿Esta seguro de aprobar la solicitud de lactancia?", "Aprobar Lactancia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            If LactanciaDAO.AprobarLactancia(LactanciaBE) Then
                Me.Close()
            Else
                MessageBox.Show("Error al aprobar")
            End If
        End If
    End Sub

    Private Sub btnAnular_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAnular.ItemClick
        If MessageBox.Show("¿Esta seguro de anular la solicitud de lactancia?", "Anular Lactancia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            If LactanciaDAO.AnularLactancia(LactanciaBE) Then
                Me.Close()
            Else
                MessageBox.Show("Error al anular")
            End If
        End If
    End Sub

    Private Sub btnHistorialEmpleado_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnHistorialEmpleado.ItemClick

        BDAccionPersonalDAO.IdEmpleado = LactanciaBE.IDEMPLEADO
        If BDAccionPersonalDAO.IdEmpleado <> 0 Then
            Dim MiForm As New EmpleadoHistorial
            Nombre = txtEmpleado.Text
            NumeroDocumento = txtDni.Text
            NombreLog = Me.Text ' formulario , reporte,
            DetalleLog = "HISTORIAL EMPLEADO " & Nombre & " CON NUMERO DE DOC. " & NumeroDocumento ' acción: impresión, exportar, tb poner filtros , lo que se
            BDCentralDAO.AccesoLogIns(IDSistema, BDCentralDAO.UsuarioBE.IDUsuario, DetalleLog, NombreLog)

            MiForm.ShowDialog()
        End If

    End Sub
End Class