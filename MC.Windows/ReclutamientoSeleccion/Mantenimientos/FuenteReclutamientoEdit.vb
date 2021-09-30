Imports MC.Data
Imports MC.Framework

Public Class FuenteReclutamientoEdit

    Dim FuenteReclutamientoBE As New FuenteReclutamientoBE

    Private Sub FuenteReclutamientoEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEntidad()
    End Sub

    Private Sub LoadEntidad()
        If BDCentralDAO.IdFuente = 0 Then
            txtIdFuente.Text = 0
        Else
            FuenteReclutamientoBE = BDCentralDAO.GetFuenteReclutamientoID(BDCentralDAO.IdFuente)
            With FuenteReclutamientoBE
                txtIdFuente.Text = .IDFUENTE
                txtDescripcion.Text = .DESCRIPCION
            End With
        End If
    End Sub

    Private Sub btnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick

        If txtDescripcion.Text = "" Then
            Exit Sub
        End If

        With FuenteReclutamientoBE
            .IDFUENTE = txtIdFuente.Text
            .DESCRIPCION = txtDescripcion.Text
        End With

        BDCentralDAO.SaveFuenteReclutamiento(FuenteReclutamientoBE)
        Me.Close()
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

End Class