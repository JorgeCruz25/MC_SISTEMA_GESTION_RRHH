Imports MC.Data
Imports MC.Framework
Public Class MemorandumArchivos
    Dim idmemorandum As Integer
    Dim dt As DataTable
    Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True
    End Sub
    Private Sub MemorandumArchivos_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Private Sub btnFirmaDocumento_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFirmaDocumento.ItemClick
        If MemorandumDAO.EstadoEnvioLegal Then
            MessageBox.Show("El memorandum ya fue enviado a legal", "Archivo Memorandum", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If MessageBox.Show("¿El documento se encuentra firmado?", "Firma Memorandum", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                MemorandumDAO.FirmaDocumentoMemorandum(MemorandumDAO.IdMemorandum, 1)
            Else
                MemorandumDAO.FirmaDocumentoMemorandum(MemorandumDAO.IdMemorandum, 0)
            End If
            Me.Close()
        End If
    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnEliminarFormatos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEliminarFormatos.ItemClick
        Dim MiForm As New MemorandumEliminarFormato
        MiForm.ShowDialog()
        Me.Close()
    End Sub
End Class