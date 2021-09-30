Imports System.Configuration
Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework
Imports System.IO
Imports Microsoft.WindowsAzure.Storage
Imports Microsoft.WindowsAzure.Storage.Auth
Imports Microsoft.WindowsAzure.Storage.Blob

Public Class MemorandumEliminarFormato
    Dim bsMemorandumsAdjuntos As New BindingSource
    Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDMEMORANDUM", "idmemorandum", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO MEMORANDUM", "NUMEROINFORME", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "idarchivomemorandum", "idarchivomemorandum", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "nombrearchivo", "nombrearchivo", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        Me.GridControl1.DataSource = bsMemorandumsAdjuntos
        Refrescar()
    End Sub
    Private Sub Refrescar()
        bsMemorandumsAdjuntos.DataSource = MemorandumDAO.ListaMemorandumArchivos(MemorandumDAO.IdMemorandum)
    End Sub
    Private Sub RepositoryItemButtonEditEliminar_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEditEliminar.Click
        If MessageBox.Show("Esta seguro de emilinar el el adjunto", "Eliminar Adjunto", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then

            Dim idMemorandum As Integer = GridView1.GetFocusedRowCellValue("idmemorandum")
            Dim idArchivoMemorandum As Integer = GridView1.GetFocusedRowCellValue("idarchivomemorandum")
            Dim nombreArchivo As String = GridView1.GetFocusedRowCellValue("nombrearchivo")
            If MemorandumDAO.EliminarMemorandumArchivo(idArchivoMemorandum, idMemorandum) Then

                'Se quita archivo
                Dim storageAccount As CloudStorageAccount

                storageAccount = CloudStorageAccount.Parse(ConfigurationManager.AppSettings("StorageConnectionString"))

                'Se recupera el blob
                Dim blobClient As CloudBlobClient = storageAccount.CreateCloudBlobClient()

                'Se recupera el contenedor previamente creado en Azure
                Dim container As CloudBlobContainer = blobClient.GetContainerReference("memorandum")
                'Dim container As CloudBlobContainer = blobClient.GetContainerReference("pruebasjorge")

                'Se recupera una referencia a un blob donde se guardara el archivo
                Dim blockBlob As CloudBlockBlob = container.GetBlockBlobReference(nombreArchivo)
                'Se elimina el archivo
                blockBlob.Delete()

            End If
            Refrescar()
            If GridView1.RowCount = 0 Then
                Me.Close()
            End If
        End If
    End Sub
End Class