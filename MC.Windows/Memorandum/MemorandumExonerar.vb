Imports MC.Data
Imports MC.Framework
Public Class MemorandumExonerar
    Dim MemorandumBE As MemorandumBE
    Private UsuarioBE As New UsuarioBE
    Public valorexonerado As Integer
    Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True
    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub
    Private Function Validar()
        DxErrorProvider1.ClearErrors()
        Dim Result As Boolean = True
        If txtDescripcion.Text = "" Then
            DxErrorProvider1.SetError(txtDescripcion, "Dato obligatorio")
            Result = False
        End If
        With MemorandumBE
            .IdMemorandum = MemorandumDAO.IdMemorandum
            .Descripcion = txtDescripcion.Text
        End With
        Return Result
    End Function

    Private Sub MemorandumExonerar_Load(sender As Object, e As EventArgs) Handles Me.Load
        MemorandumBE = MemorandumDAO.GetMemorandumByID(MemorandumDAO.IdMemorandum)
    End Sub

    Private Sub btnExonerarMemorandum_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExonerarMemorandum.ItemClick
        If Validar() Then
            If MessageBox.Show("¿Esta seguro de exonerar el memorandum?", "Exonerar memorandum", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                Dim descripcion As String = txtDescripcion.Text
                If MemorandumDAO.ExonerarMemorandumRRHH(MemorandumBE.IdMemorandum, descripcion, BDCentralDAO.UsuarioBE.IDUsuario) Then
                    valorexonerado = 1
                End If
                Me.Close()
            End If
        End If
    End Sub
End Class