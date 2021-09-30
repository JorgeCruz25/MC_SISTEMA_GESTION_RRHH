Imports MC.Data
Public Class EnvioCorreoFirma
    Dim RenovacionContratoBE As New RenovacionContratoBE
    Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
    End Sub
    Private Function Validar() As Boolean
        Dim Result As Boolean = True

        DxErrorProvider1.ClearErrors()

        If dtFechaDesde.EditValue Is Nothing Then
            DxErrorProvider1.SetError(dtFechaDesde, "Dato obligatorio")
            Result = False
        End If
        If dtFechaHasta.EditValue Is Nothing Then
            DxErrorProvider1.SetError(dtFechaHasta, "Dato obligatorio")
            Result = False
        End If
        If teHoraDesde.Text = "" Or teHoraDesde.Text = "00:00:00" Then
            DxErrorProvider1.SetError(teHoraDesde, "Dato obligatorio")
            Result = False
        End If
        If teHoraHasta.Text = "" Or teHoraHasta.Text = "00:00:00" Then
            DxErrorProvider1.SetError(teHoraDesde, "Campo obligatorio")
            Result = False
        End If
        If dtFechaDesde.EditValue Is Nothing Then
            DxErrorProvider1.SetError(teHoraDesde, "Campo obligatorio")
            Result = False
        End If
        If dtFechaHasta.Text Is Nothing Then
            DxErrorProvider1.SetError(teHoraDesde, "Campo obligatorio")
            Result = False
        End If

        If Result Then
            With RenovacionContratoBE
                .FechaEnvioCorreoFirmaDesde = dtFechaDesde.EditValue
                .FechaEnvioCorreoFirmaHasta = dtFechaHasta.EditValue
                .HoraEnvioCorreoFirmaDesde = teHoraDesde.Text
                .HoraEnvioCorreoFirmaHasta = teHoraHasta.Text
            End With
        End If
        Return Result
    End Function
    Private Sub btnEnviarCorreo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEnviarCorreo.ItemClick
        If Validar() Then

            If Convert.ToDateTime(dtFechaDesde.Text) > Convert.ToDateTime(dtFechaHasta.Text) Then
                MessageBox.Show("La fecha desde no puede ser mayor a la fecha hasta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub

            End If
            If teHoraDesde.Value > teHoraHasta.Value Then
                MessageBox.Show("La hora de inicio no puede ser mayor a la hora final", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If MessageBox.Show("Esta seguro de generar envio de correos, fecha inicio" & dtFechaDesde.EditValue & " " & RenovacionContratoBE.HoraEnvioCorreoFirmaDesde & "Fecha Hasta " & RenovacionContratoBE.FechaEnvioCorreoFirmaHasta & " " & RenovacionContratoBE.HoraEnvioCorreoFirmaHasta, "Generación de correos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Close()
            End If
        End If

    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub
    Private Sub dtFechaDesde_Click(sender As Object, e As EventArgs) Handles dtFechaDesde.Click
        dtFechaDesde.Properties.MinValue = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub dtFechaHasta_Click(sender As Object, e As EventArgs) Handles dtFechaHasta.Click
        dtFechaHasta.Properties.MinValue = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub
End Class