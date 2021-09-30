Imports System.Configuration
Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework
Imports Microsoft.WindowsAzure.Storage
Imports Microsoft.WindowsAzure.Storage.Blob
Imports System.Globalization


Public Class MemorandumAnular
    Dim bsMemorandumsArchivos As New BindingSource
    Dim idusuario As Integer

    Private MemorandumBE As New MemorandumBE
    Private UsuarioBE As New UsuarioBE
    Dim nameArchivo As String
    Public valoranulado As Integer


    Sub New()
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDSUSTENTOARCHIVO", "IDSUSTENTOARCHIVO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDMEMORANDUM", "IDMEMORANDUM", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBREARCHIVO", "NOMBREARCHIVO", 600, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "LINKDESCARGA", "LINKDESCARGA", 140, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        Me.GridControl1.DataSource = bsMemorandumsArchivos
        refrescar()
    End Sub
    Private Sub MemonrandumAnular_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MemorandumBE = MemorandumDAO.GetMemorandumByID(MemorandumDAO.IdMemorandum)
        If MemorandumDAO.IdMemorandum <> 0 Then
            idusuario = BDCentralDAO.UsuarioBE.IDUsuario
        End If
    End Sub
    Private Function validar() As Boolean
        DxErrorProvider1.ClearErrors()
        Dim Result As Boolean = True

        If txtDescargo.EditValue Is Nothing Then
            DxErrorProvider1.SetError(txtDescargo, "Dato obligatorio")
            Result = False
        End If
        With MemorandumBE
            .ObservacionAnulado = txtDescargo.Text
        End With
        Return Result
    End Function

    Private Sub btnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick
        If Me.validar Then
            If MessageBox.Show("¿Está seguro de anular el memorandum?", "Anular Memorandum", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                If MemorandumDAO.AnularMemorandumRRHH(BDCentralDAO.UsuarioBE.IDUsuario, MemorandumBE) Then
                    'ENVIO CORREO
                    valoranulado = 1
                    Dim dtEmail As New DataTable
                    dtEmail = MemorandumDAO.GetMemorandumIDCorreo(MemorandumBE.IdMemorandum)
                    Dim nroformato As String = dtEmail.Rows(0)("NUMEROINFORME")
                    Dim tienda As String = dtEmail.Rows(0)("RAZONCOMERCIAL")
                    Dim correosolicitante As String = dtEmail.Rows(0)("CORREOSOLICITANTE")
                    Dim correosupervisor As String = dtEmail.Rows(0)("CORREOSUPERVISOR")
                    Dim observacion As String = dtEmail.Rows(0)("OBSERVACIONANULADO")
                    Dim emailTo As String
                    emailTo = correosolicitante + correosupervisor

                    Dim empleado As String = dtEmail.Rows(0)("EMPLEADONOMBRE")
                    Dim empleadodni As String = dtEmail.Rows(0)("EMPLEADODNI")
                    Dim Mensaje As String

                    Mensaje = "<font face=Calibri size=3> Estimado Señores de:  " & tienda & "<br>" & "<br>" &
                              "Se comunica que se procedio con la anulación del memorandum en referencia para el Señor(a)  " & empleado & "  con DNI:  " & empleadodni & ". Por el siguiente motivo </font>" & "<br>" & "<br>" &
                              observacion & "<br>"

                    BDCentralDAO.InsertEnvioCorreo(emailTo, " Memorandum: " + nroformato, Mensaje)

                    Me.Close()
                Else
                    MessageBox.Show("Error al guardar")

                End If
            End If
        End If

    End Sub
    Private Sub refrescar()
        bsMemorandumsArchivos.DataSource = MemorandumDAO.GetMemorandumDescargoArchivo(MemorandumDAO.IdMemorandum)
        Me.GridControl1.DataSource = bsMemorandumsArchivos
    End Sub
    Private Sub btnAdjuntar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdjuntar.ItemClick
        OpenFileDialog1.InitialDirectory = "c:\"
        OpenFileDialog1.Filter = "Pdf |*.pdf"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True

        Dim ruta As String
        Dim link As String

        ruta = "https://controlatenciones.blob.core.windows.net/memorandumdescargo/"

        Dim nameArchivo As String = ""

        Try
            If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Cursor = Cursors.WaitCursor

                Dim fechaArchivo As Date = Date.Now.Date

                nameArchivo = MemorandumDAO.IdMemorandum.ToString & "_" & "RH-MN" & "_" & 0 & "_" & Format(fechaArchivo, "dd-MM-yyyy") & "_" & System.IO.Path.GetFileName(OpenFileDialog1.FileName)

                Dim storageAccount As CloudStorageAccount
                storageAccount = CloudStorageAccount.Parse(ConfigurationManager.AppSettings("StorageConnectionString"))

                'Se recupera el blob
                Dim blobClient As CloudBlobClient = storageAccount.CreateCloudBlobClient()

                'Se recupera el contenedor previamente creado en Azure
                Dim container As CloudBlobContainer = blobClient.GetContainerReference("memorandumdescargo")
                'Se recupera una referencia a un blob donde se guardara el archivo
                Dim blockBlob As CloudBlockBlob = container.GetBlockBlobReference(nameArchivo)

                link = ruta + nameArchivo

                'Se guarda el archivo en el blob
                blockBlob.UploadFromStream(OpenFileDialog1.OpenFile)

                If MemorandumDAO.InsertaMemorandumSustentoInsertarArchivo(MemorandumDAO.IdMemorandum, nameArchivo, ruta, link) Then

                    MessageBox.Show("El Archivo se ha adjuntado correctamente.", "Adjuntar Archivo")
                    Cursor = Cursors.Default
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al adjuntar el archivo.", "Error de Conexión")
            Cursor = Cursors.Default
        End Try

        refrescar()
    End Sub
    Private Sub RepositoryItemEliminarArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemEliminarArchivo.Click
        If MessageBox.Show("¿Está seguro de eliminar el archivo?", "Eliminar Archvivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            MemorandumDAO.IdDescargoArchivo = GridView1.GetFocusedRowCellValue("IDSUSTENTOARCHIVO")
            If MemorandumDAO.IdDescargoArchivo <> 0 Then
                Try
                    Dim ArchivoEliminar As String
                    ArchivoEliminar = GridView1.GetFocusedRowCellValue("NOMBREARCHIVO")
                    Dim storageAccount As CloudStorageAccount
                    storageAccount = CloudStorageAccount.Parse(ConfigurationManager.AppSettings("StorageConnectionString"))

                    'Se recupera el blob
                    Dim blobClient As CloudBlobClient = storageAccount.CreateCloudBlobClient()

                    'Se recupera el contenedor previamente creado en Azure
                    Dim container As CloudBlobContainer = blobClient.GetContainerReference("memorandumdescargo")

                    Dim blockBlob As CloudBlockBlob = container.GetBlockBlobReference(ArchivoEliminar)
                    blockBlob.Delete()
                Catch ex As Exception
                    MessageBox.Show("Ocurrio un error al eliminar el archivo.", "Error de Conexión")
                    Cursor = Cursors.Default
                End Try
            End If
            If MemorandumDAO.EliminarDescargoMemorandumArchivo(MemorandumDAO.IdDescargoArchivo) Then
                MessageBox.Show("Archivo Eliminado.", "Eliminación de Archivo")
            End If
            refrescar()
        End If
    End Sub
    Private Sub RepositoryItemButtonEditArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEditArchivo.Click
        MemorandumDAO.IdDescargoArchivo = GridView1.GetFocusedRowCellValue("IDSUSTENTOARCHIVO")
        If MemorandumDAO.IdDescargoArchivo <> 0 Then
            Dim MiForm As New MemorandumDescargo

            Dim dt As DataTable = MemorandumDAO.GetMemorandumDescargo(MemorandumDAO.IdDescargoArchivo)
            If dt.Rows.Count <> 0 Then
                Dim ruta As String = dt.Rows(0).Table(0)("linkdescarga").ToString
                Dim tab As String
                tab = "Archivo" + Convert.ToString(1)
                Dim NewTab As New XtraTabPage
                NewTab.Name = tab
                NewTab.Text = tab
                MiForm.XtraTabControl1.TabPages.Add(NewTab)

                Dim uccontrol1 As New XtraUserControlWebBrowser()
                NewTab.Controls.Add(uccontrol1)
                uccontrol1.Dock = DockStyle.Fill

                uccontrol1.WebBrowser1.Show()
                uccontrol1.WebBrowser1.Navigate(String.Format(ruta, Application.StartupPath))
                MiForm.ShowDialog()
            Else
                MessageBox.Show("El memorandum no contiene archivo", "Archivo de Memorandum")
            End If
        End If
    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub


End Class