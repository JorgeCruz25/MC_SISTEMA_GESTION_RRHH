Imports DevExpress.XtraBars
Imports MC.Data
Imports MC.Framework
Public Class NegacionTrasladoDetails
    Dim NegacionTrasladoBE As New NegacionTrasladoBE
    Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterParent
    End Sub


    Private Sub NegacionTrasladoDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        If NegacionTrasladoDAO.IdNegacionTraslado <> 0 Then
            NegacionTrasladoBE = NegacionTrasladoDAO.GetNegacionTrasladoByID(NegacionTrasladoDAO.IdNegacionTraslado)
            With NegacionTrasladoBE
                txtLocal.Text = NegacionTrasladoBE.RAZONCOMERCIAL
                txtSolicitante.Text = NegacionTrasladoBE.NOMBRESOLICITANTE
                txtEmpleado.Text = NegacionTrasladoBE.NOMBREREPRESENTANTE
                txtDni.Text = NegacionTrasladoBE.DNIREPRESENTANTE
                txtNacionalidad.Text = NegacionTrasladoBE.NACIONALIDADREPRESENTANTE
                .IDUSUARIO = BDCentralDAO.UsuarioBE.IDUsuario
            End With
            txtLocal.Enabled = False
            txtEmpleado.Enabled = False
            txtDni.Enabled = False
            txtNacionalidad.Enabled = False
        End If
    End Sub
    Private Sub btnAprobar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAprobar.ItemClick
        If MessageBox.Show("¿Esta seguro de aprobar la negación de traslado?", "Aprobar negación traslado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            If NegacionTrasladoDAO.AprobarNegacionTraslado(NegacionTrasladoBE) Then
                Me.Close()
            Else
                MessageBox.Show("Error al aprobar")
            End If
        End If
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnAnular_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAnular.ItemClick
        If MessageBox.Show("¿Esta seguro de anular la negación de traslado?", "Anular negación traslado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            If NegacionTrasladoDAO.AnularNegacionTraslado(NegacionTrasladoBE) Then
                Me.Close()
            Else
                MessageBox.Show("Error al anular")
            End If
        End If
    End Sub


End Class