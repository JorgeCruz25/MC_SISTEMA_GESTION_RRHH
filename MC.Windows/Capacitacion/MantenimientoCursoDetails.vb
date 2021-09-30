Imports MC.Framework
Imports MC.Data
Public Class MantenimientoCursoDetails
    Private Sub MantenimientoCursoDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtIdCurso.Enabled = False
        If CapacitacionDAO.IdCurso = 0 Then
            txtIdCurso.Text = 0
            chkEstado.Checked = False
        Else
            CargarDatos()
        End If
    End Sub
    Private Sub CargarDatos()
        Try
            Dim dt As DataTable
            dt = CapacitacionDAO.CursosGetId(CapacitacionDAO.IdCurso)
            txtIdCurso.Text = dt.Rows(0)("IDCURSO")
            txtCurso.Text = dt.Rows(0)("DESCRIPCION")
            txtNotaAprobatoria.Text = dt.Rows(0)("NOTAAPROBATORIA")
            chkEstado.EditValue = dt.Rows(0)("ESTADO")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGrabar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGrabar.ItemClick
        If Validar() Then
            Try
                If MessageBox.Show("Estas seguro de grabar el registro", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    If CapacitacionDAO.CursoIns(CapacitacionDAO.IdCurso, txtCurso.Text, txtNotaAprobatoria.Text, chkEstado.EditValue, BDCentralDAO.UsuarioBE.IDUsuario) Then
                        Me.Close()
                    End If
                End If

            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub
    Private Function Validar() As Boolean
        Dim Result As Boolean = True

        DxErrorProvider1.ClearErrors()

        If LTrim(txtCurso.Text) = "" Then
            DxErrorProvider1.SetError(txtCurso, "Dato obligatorio")
            Result = False
        End If
        If LTrim(txtNotaAprobatoria.Text) = "" Then
            DxErrorProvider1.SetError(txtNotaAprobatoria, "Dato obligatorio")
            Result = False
        End If

        Return Result
    End Function


End Class