Imports MC.Data
Imports MC.Framework

Public Class AsignarDerechoHabiente
    Public flat As Int32 = 0
    Public Aprobacion As Int32 = 0
    Public AsignacionFamiliar As Int32
    Sub New()

        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        rboAsignacionNo.Checked = True
        rboAsignacionSi.Checked = False
    End Sub
    'Private Sub ListadoHijos()
    '    Try

    '        bsHijos.DataSource = BDAccionPersonalDAO.ListadoHijosxEmpleado(BDAccionPersonalDAO.IdEmpleado)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Function validar() As Boolean
        Dim Result As Boolean = True
        DxErrorProvider1.ClearErrors()

        'If AsignacionFamiliar = 1 And rboAsignacionSi.Checked Then
        '    MessageBox.Show("El empleado ya cuenta con beneficio de asignación familiar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Result = False
        'End If
        If rboAsignacionSi.Checked = False And rboAsignacionNo.Checked = False Then
            MessageBox.Show("Seleccione si contara o no contara con asignación familiar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Result = False
        End If
        Return Result
    End Function

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnAporbarDerechoHabiente_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGrabar.ItemClick
        If validar() Then
            Dim mensaje As String = ""
            If rboAsignacionSi.Checked And rboAsignacionNo.Checked = False Then
                mensaje = "Estas seguro(a) de aprobar la solicitud con la asignación del beneficio"
                'flat = 1
            ElseIf rboAsignacionSi.Checked = False And rboAsignacionNo.Checked Then
                mensaje = "Estas seguro(a) de aprobar la solicitud sin el beneficio de asignación familiar"
            End If
            If MessageBox.Show(mensaje, "Asignación Familiar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Aprobacion = 1
                Me.Close()
            End If
        End If






        'Aprobacion = 1
        '        If AsignacionFamiliar = 0 And rboAsignacionSi.Checked Then
        '            flat = 1 ' ASIGNA ASIGNACIÓN FAMILIAR
        '        Else
        '            flat = 2 ' NO ASIGNA ASIGNACIÓN FAMILIAR
        '        End If
        '        Me.Close()
        '    End If
        'End If
    End Sub
End Class