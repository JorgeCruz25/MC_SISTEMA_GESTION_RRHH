Imports MC.Data
Imports MC.Framework
Public Class CartaConocimientoDetails
    Dim CartaConocimientoBE As New CartaConocimientoBE
    Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterParent
    End Sub
    Private Sub CartaConocimientoDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        If CartaConocimientoDAO.IdExamenMedico <> 0 Then
            CartaConocimientoBE = CartaConocimientoDAO.GetCartaConocimientoByID(CartaConocimientoDAO.IdExamenMedico)
            With CartaConocimientoBE
                txtLocal.Text = CartaConocimientoBE.RAZONCOMERCIAL
                txtSolicitante.Text = CartaConocimientoBE.NOMBRESOLICITANTE
                txtEmpleado.Text = CartaConocimientoBE.EMPLEADONOMBRE
                txtCargo.Text = CartaConocimientoBE.EMPLEADODNI
                txtCentroUbicacion.Text = CartaConocimientoBE.INSTALACION
                dtFechaInicio.EditValue = CartaConocimientoBE.FECHAINICIO
                dtFechaFin.Text = CartaConocimientoBE.FECHAFIN
                txtHora.Text = CartaConocimientoBE.HORA
                .IDUSUARIO = BDCentralDAO.UsuarioBE.IDUsuario
            End With
            txtLocal.Enabled = False
            txtEmpleado.Enabled = False
            txtCargo.Enabled = False
            txtCentroUbicacion.Enabled = False
            dtFechaInicio.Enabled = False
            dtFechaFin.Enabled = False
            txtHora.Enabled = False
        End If
    End Sub

    Private Sub btnAprobar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAprobar.ItemClick
        If MessageBox.Show("¿Esta seguro de aprobar la carta de conocimiento?", "Aprobar carta conocimiento", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            If CartaConocimientoDAO.AprobarCartaConocimiento(CartaConocimientoBE) Then
                Me.Close()
            Else
                MessageBox.Show("Error al aprobar")
            End If
        End If
    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnAnular_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnular.ItemClick
        If MessageBox.Show("¿Esta seguro de anular la carta de conocimiento?", "Anular carta conocimiento", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            If CartaConocimientoDAO.AnularCartaConocimiento(CartaConocimientoBE) Then
                Me.Close()
            Else
                MessageBox.Show("Error al anular")
            End If
        End If
    End Sub
End Class