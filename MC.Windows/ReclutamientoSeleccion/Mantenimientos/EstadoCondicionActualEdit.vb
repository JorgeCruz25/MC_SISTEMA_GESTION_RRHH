Imports MC.Data
Imports MC.Framework

Public Class EstadoCondicionActualEdit

    Dim EstadoCondicionActualBE As New EstadoCondicionActualBE

    Private Sub EstadoCondicionActualEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEntidad()
    End Sub

    Private Sub LoadEntidad()
        If BDCentralDAO.IdEstadoCondicionActual = 0 Then
            txtId.Text = 0
        Else
            EstadoCondicionActualBE = BDCentralDAO.GetEstadoCondicionActualID(BDCentralDAO.IdEstadoCondicionActual)
            With EstadoCondicionActualBE
                txtId.Text = .IDESTADOCONDICIONACTUAL
                txtDescripcion.Text = .DESCRIPCION
                chkActivo.EditValue = .ACTIVO
            End With
        End If
    End Sub

    Private Sub btnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick
        If txtDescripcion.Text = "" Then
            Exit Sub
        End If

        With EstadoCondicionActualBE
            .IDESTADOCONDICIONACTUAL = txtId.Text
            .DESCRIPCION = txtDescripcion.Text
            .ACTIVO = chkActivo.EditValue
        End With

        BDCentralDAO.SaveEstadoCondicionActual(EstadoCondicionActualBE)
        Me.Close()
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

End Class