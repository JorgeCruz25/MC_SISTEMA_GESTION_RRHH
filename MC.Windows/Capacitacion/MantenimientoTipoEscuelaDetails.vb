Imports MC.Data
Imports MC.Framework
Public Class MantenimientoTipoEscuelaDetails
    Sub New()

        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterParent
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True
        Me.Text = "TIPO DE ESCUELA"
        txtIdEscuela.Enabled = False

        If CapacitacionDAO.IdCapacitacionTipoEscuela = 0 Then
            txtIdEscuela.Text = CapacitacionDAO.IdCapacitacionTipoEscuela
            chkEstado.Checked = False
        Else
            txtEscuela.Enabled = False
            Dim dt As DataTable = CapacitacionDAO.TipoEscuelaGetId(CapacitacionDAO.IdCapacitacionTipoEscuela)
            txtIdEscuela.Text = dt.Rows(0)("IDCAPACITACIONTIPOESCUELA")
            txtEscuela.Text = dt.Rows(0)("DESCRIPCION")
            chkEstado.Checked = dt.Rows(0)("ESTADO")
        End If

    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnGrabar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGrabar.ItemClick
        If Validar() Then
            If MessageBox.Show("Estas seguro de grabar el registro", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                If CapacitacionDAO.TipoEscuelaIns(txtIdEscuela.Text, txtEscuela.Text, chkEstado.EditValue, BDCentralDAO.UsuarioBE.IDUsuario) Then
                    Me.Close()
                Else
                    MessageBox.Show("Error de conexión con servidor")
                End If
            End If
        End If
    End Sub
    Private Function Validar()
        Dim Result As Boolean = True
        DxErrorProvider1.ClearErrors()
        If Trim(txtEscuela.Text) = "" Then
            DxErrorProvider1.SetError(txtEscuela, "Dato obligatorio")
            Result = False
        End If
        Return Result
    End Function

End Class