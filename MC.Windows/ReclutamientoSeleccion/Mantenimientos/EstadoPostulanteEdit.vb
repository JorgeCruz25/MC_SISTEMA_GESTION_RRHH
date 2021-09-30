Imports MC.Data
Imports MC.Framework

Public Class EstadoPostulanteEdit

    Dim EstadoPostulanteBE As New EstadoPostulanteBE

    Private Sub EstadoPostulanteEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEntidad()
    End Sub

    Private Sub LoadEntidad()
        If BDCentralDAO.IdEstadoPostulante = 0 Then
            txtIdEstado.Text = 0
        Else
            EstadoPostulanteBE = BDCentralDAO.GetEstadoPostulanteID(BDCentralDAO.IdEstadoPostulante)
            With EstadoPostulanteBE
                txtIdEstado.Text = .IDESTADO
                txtDescripcion.Text = .DESCRIPCION
                chkActivo.EditValue = .ACTIVO
            End With
        End If
    End Sub

    Private Sub btnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick
        If txtDescripcion.Text = "" Then
            Exit Sub
        End If

        With EstadoPostulanteBE
            .IDESTADO = txtIdEstado.Text
            .DESCRIPCION = txtDescripcion.Text
            .ACTIVO = chkActivo.EditValue
        End With

        BDCentralDAO.SaveEstadoPostulante(EstadoPostulanteBE)
        Me.Close()
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub
End Class