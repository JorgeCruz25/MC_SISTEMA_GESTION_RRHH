Public Class SuspensionPerfectaRevertir
    Public IdSuspension As Integer
    Public FechaPeriodoFin As Date
    Public FechaActual As Date
    Public IdSituacionLaboral As Int32
    Public IdEmpleado As Integer
    Public FechaInicioLicencia As Date
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub btnProcesar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnProcesar.ItemClick
        Dim Result As Boolean = True
        If FechaPeriodoFin = dtFechaFin.EditValue Then
            MessageBox.Show("La fecha fin ingresada, no puede ser igual a la actual")
            Result = False
        ElseIf dtFechaFin.EditValue < FechaActual Then
            MessageBox.Show("La fecha fin tiene que ser posterior a la fecha actual")
            Result = False
        End If
        If IdSituacionLaboral = 2 Then 'SUSPENSION PERFECTA
            Dim dtvalidarlaborando As DataTable = SuspencionPerfectaDAO.ValidacionSuspensionPerfecta(IdSuspension, IdEmpleado, dtFechaFin.EditValue)
            If dtvalidarlaborando.Rows(0)("RESULT") <> 13 Then
                MessageBox.Show(dtvalidarlaborando.Rows(0)("MENSAJE"))
                Result = False
            End If
        End If
        If IdSituacionLaboral = 4 Then 'SOLICITUD LICENCIA SIN GOCE DE HABER POR SUSPENSION PERFECTA
            If FechaInicioLicencia <= dtFechaFin.EditValue Then
                Dim dtvalorlsgsp As DataTable = SuspencionPerfectaDAO.ValidacionAprobadoLicenciaSinGoceSP(IdSuspension, IdEmpleado, FechaActual, dtFechaFin.EditValue)
                If dtvalorlsgsp.Rows.Count > 0 Then
                    If dtvalorlsgsp.Rows(0)("RESULT") <> 13 Then
                        MessageBox.Show(dtvalorlsgsp.Rows(0)("MENSAJE"))
                        Result = False
                    End If
                End If
            Else
                MessageBox.Show("La fecha Final tiene que ser mayor o igual a la inicial de la licencia, fecha inicio licencia " & FechaInicioLicencia)
                Result = False
            End If

        End If

        If Result Then
            If MessageBox.Show("¿Esta Seguro de realizar la modificación de la fecha fin?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                If SuspencionPerfectaDAO.ActualizarNuevaFechaFin(IdSuspension, BDCentralDAO.UsuarioBE.IDUsuario, dtFechaFin.EditValue) Then
                    Me.Close()
                Else
                    MessageBox.Show("Problemas de conexión con el servidor")
                End If
            End If
        End If
    End Sub

    Private Sub btnAnular_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnular.ItemClick
        If MessageBox.Show("¿Esta Seguro de realizar la modificación de la fecha fin?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            If SuspencionPerfectaDAO.AnularSuspensionPerfectaProcesada(IdSuspension, BDCentralDAO.UsuarioBE.IDUsuario) Then
                Me.Close()
            Else
                MessageBox.Show("Problemas de conexión con el servidor")
            End If
        End If
    End Sub
End Class
'AnularSuspensionPerfectaProcesada