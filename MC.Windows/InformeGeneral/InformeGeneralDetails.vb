Imports MC.Data
Imports MC.Framework
Public Class InformeGeneralDetails
    Dim InformeGeneralBE As New InformeGeneralBE
    Dim idempleado As Integer
    Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterParent
    End Sub

    Private Sub InformeGeneralDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        If InformeGeneralDAO.IdInformeGeneral <> 0 Then
            InformeGeneralBE = InformeGeneralDAO.GetInformeGeneralByID(InformeGeneralDAO.IdInformeGeneral)
            With InformeGeneralBE
                txtSolicitante.Text = InformeGeneralBE.NOMBRESOLICITANTE
                txtLocal.Text = InformeGeneralBE.RAZONCOMERCIAL
                txtEmpleado.Text = InformeGeneralBE.NOMBREEMPLEADO
                txtDni.Text = InformeGeneralBE.DNIEMPLEADO
                txtCargo.Text = InformeGeneralBE.CARGOEMPLEADO
                txtAsunto.Text = InformeGeneralBE.ASUNTO
                txtDescripcion.Text = InformeGeneralBE.DESCRIPCIÓN
                idempleado = InformeGeneralBE.IDEMPLEADO
                .IDUSUARIO = BDCentralDAO.UsuarioBE.IDUsuario
            End With
            txtLocal.Enabled = False
            txtEmpleado.Enabled = False
            txtDni.Enabled = False
            txtCargo.Enabled = False
            txtDescripcion.Enabled = False
        End If
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnAprobar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAprobar.ItemClick
        If MessageBox.Show("¿Esta seguro de aprobar el informe general?", "Aprobar Informe general", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            If InformeGeneralDAO.AprobarInformeGeneral(InformeGeneralBE) Then
                Me.Close()
            Else
                MessageBox.Show("Error al aprobar")
            End If
        End If
    End Sub

    Private Sub btnAnular_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnular.ItemClick
        If MessageBox.Show("¿Esta seguro de anular el informe general?", "Anular Informe general", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            If InformeGeneralDAO.AnularInformeGeneral(InformeGeneralBE) Then
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
            MiForm.ShowDialog()
        End If
    End Sub
End Class