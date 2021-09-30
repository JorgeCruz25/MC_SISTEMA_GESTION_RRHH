
Public Class ConceptoPlanillaDetails
    Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub btnGrabar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGrabar.ItemClick
        If Trim(txtConcepto.Text) = "" Then
            MessageBox.Show("El campo texto Concepto es un dato obligatorio", "Mensaje Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If MessageBox.Show("Estas seguro de grabar en nuevo concepto", "Mensaje de Confirmaciòn", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                PlanillaDAO.RegistrarConceptoPlanilla(txtConcepto.Text, BDCentralDAO.UsuarioBE.IDUsuario)
                Me.Close()
            End If
        End If
    End Sub
End Class