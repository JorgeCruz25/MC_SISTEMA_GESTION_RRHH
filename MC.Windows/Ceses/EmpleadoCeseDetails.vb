Imports System.Configuration
Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework
Imports Microsoft.WindowsAzure.Storage
Imports Microsoft.WindowsAzure.Storage.Blob

Public Class EmpleadoCeseDetails
    Dim bsHistorialMemoranums As New BindingSource
    Dim bsCartaPreAviso As New BindingSource
    Dim bsCartaDespido As New BindingSource
    Dim EmpleadoBE As New EmpleadoBE
    Dim CeseBE As New CeseBE
    Dim IdSolicitudCese As Integer
    Dim NombreArchivo As String
    Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDMEMORANDUM", "IDMEMORANDUM", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 190, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NIVEL FALTA", "NIVELFALTA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FALTA", "FALTA", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA", "FECHAREVISADO", 70, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridView1
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NIVELFALTA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FALTA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAREVISADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        Refrescar()
        ControlesDevExpress.InitGridControl(GridControl2)
        ControlesDevExpress.InitGridViewColumn(GridView2, "IDARCHIVOCARTAPREAVISO", "IDARCHIVOCARTAPREAVISO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "NOMBRE ARCHIVO", "NOMBREARCHIVO", 270, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "LINK", "LINKDESCARGA", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        RefrescarArchivo()
        ControlesDevExpress.InitGridControl(GridControl3)
        ControlesDevExpress.InitGridViewColumn(GridView3, "IDARCHIVODESPIDO", "IDARCHIVODESPIDO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView3, "IDSOLICITUDCESE", "IDSOLICITUDCESE", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView3, "NOMBRE ARCHIVO", "NOMBREARCHIVO", 270, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView3, "LINK", "LINKDESCARGA", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        RefrescarDespidoArchivo()

    End Sub
    Private Sub Refrescar()
        bsHistorialMemoranums.DataSource = MemorandumDAO.GetListarMemorandumEmpleado(CeseDAO.IdEmpleado)
        Me.GridControl1.DataSource = bsHistorialMemoranums
    End Sub
    Private Sub RefrescarArchivo()
        bsCartaPreAviso.DataSource = CeseDAO.ListSolicitudCeseCartaPreAvisoID(CeseDAO.IdSolicitudCese)
        Me.GridControl2.DataSource = bsCartaPreAviso
    End Sub
    Private Sub RefrescarDespidoArchivo()
        bsCartaDespido.DataSource = CeseDAO.ListSolicitudCeseCartaDespidoFormatoID(CeseDAO.IdSolicitudCese)
        Me.GridControl3.DataSource = bsCartaDespido
    End Sub
    Private Sub EmpleadoCeseDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        If CeseDAO.IdSolicitudCese <> 0 Then
            CeseBE = CeseDAO.GetEmpleadoCeseID(CeseDAO.IdSolicitudCese)
            With CeseBE
                txtSolicitante.Text = CeseBE.SOLICITANTENOMBRE
                txtNumeroSolicitud.Text = CeseBE.NUMEROSOLICITUD
                txtMotivo.Text = CeseBE.MOTIVO
                txtRazonComercial.Text = CeseBE.RAZONCOMERCIAL
                txtEmpleado.Text = CeseBE.EMPLEADONOMBRE
                txtCargo.Text = CeseBE.CARGO
                txtFechaCese.Text = CeseBE.FECHACESE
                txtAmpliacion.Text = CeseBE.AMPLIACION
                txtDescripcionAnulacion.Text = .DESCRIPCIONRETORNO

                If CeseBE.FECHAENVIOCARTAPREAVISONOTARIA = "01/01/1900" Then
                    dtCartaNotariaPreAviso.EditValue = Date.Now.Date
                Else
                    dtCartaNotariaPreAviso.EditValue = CeseBE.FECHAENVIOCARTAPREAVISONOTARIA
                End If
                If CeseBE.FECHAENVIOCARTADESPIDONOTARIA = "01/01/1900" Then
                    dtCartaNotariaDespido.EditValue = Date.Now.Date
                Else
                    dtCartaNotariaDespido.EditValue = CeseBE.FECHAENVIOCARTADESPIDONOTARIA
                End If

                'dtCartaNotariaPreAviso.EditValue = IIf(CeseBE.FECHAENVIOCARTAPREAVISONOTARIA = "01/01/1900", dtCartaNotariaDespido.EditValue = Date.Now.Date, CeseBE.FECHAENVIOCARTAPREAVISONOTARIA)


            End With
        End If
        If GridView2.RowCount = 0 Then
            dtCartaNotariaPreAviso.Enabled = False
            Me.btnGuardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If GridView3.RowCount = 0 Then
            dtCartaNotariaDespido.Enabled = False
        End If

    End Sub
    'Private Sub btnEnviarLegal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEnviarLegal.ItemClick
    '    If MessageBox.Show("¿Está seguro de enviar la solicitud de cese a legal?", "Envío a Legal", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
    '        CeseDAO.EnvioSolicitudCeseLegal(CeseDAO.IdSolicitudCese)
    '        Me.Close()
    '    End If
    'End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub
    Private Sub btnAdjuntarCartaPreAviso_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdjuntarCartaPreAviso.ItemClick
        If GridView2.RowCount <> 0 Then
            MessageBox.Show("Ya existe un archivo, por favor elimine el archivo para poder adjuntar", "Adjuntar Archivo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            OpenFileDialog1.InitialDirectory = "c:\"
            OpenFileDialog1.Filter = "docx |*.docx"
            OpenFileDialog1.FilterIndex = 2
            OpenFileDialog1.RestoreDirectory = True

            Dim ruta As String
            Dim link As String

            '''''ojo: crear una carpeta nueva para el cartapreavisolegalcese''''''''''''''''
            ruta = "https://controlatenciones.blob.core.windows.net/cartapreavisocese/"

            Dim nameArchivo As String = ""

            Try
                If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Cursor = Cursors.WaitCursor

                    Dim fechaArchivo As Date = Date.Now.Date

                    nameArchivo = CeseDAO.IdSolicitudCese.ToString & "_" & "RH-CAP" & "_" & 0 & "_" & Format(fechaArchivo, "dd-MM-yyyy") & "_" & System.IO.Path.GetFileName(OpenFileDialog1.FileName)

                    Dim storageAccount As CloudStorageAccount
                    storageAccount = CloudStorageAccount.Parse(ConfigurationManager.AppSettings("StorageConnectionString"))

                    'Se recupera el blob
                    Dim blobClient As CloudBlobClient = storageAccount.CreateCloudBlobClient()

                    'Se recupera el contenedor previamente creado en Azure
                    Dim container As CloudBlobContainer = blobClient.GetContainerReference("cartapreavisocese")

                    'Se recupera una referencia a un blob donde se guardara el archivo
                    Dim blockBlob As CloudBlockBlob = container.GetBlockBlobReference(nameArchivo)

                    link = ruta + nameArchivo

                    'Se guarda el archivo en el blob
                    blockBlob.UploadFromStream(OpenFileDialog1.OpenFile)

                    If CeseDAO.InsertaSolicitudCeseCartaPreAviso(CeseDAO.IdSolicitudCese, nameArchivo, ruta, link) Then
                        MessageBox.Show("El Archivo se ha adjuntado correctamente.", "Adjuntar Archivo")
                        RefrescarArchivo()
                        Cursor = Cursors.Default
                    End If

                End If

            Catch ex As Exception
                MessageBox.Show("Ocurrio un error al adjuntar el archivo.", "Error de Conexión")
                Cursor = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub RepositoryItemFormatoCartaPreAviso_Click(sender As Object, e As EventArgs) Handles RepositoryItemFormatoCartaPreAviso.Click
        If MessageBox.Show("¿Está seguro de descargar el archivo?", "Eliminar Archvivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then

            IdSolicitudCese = GridView2.GetFocusedRowCellValue("IDSOLICITUDCESE")
            If IdSolicitudCese <> 0 Then
                Dim dt As New DataTable
                dt = CeseDAO.ListSolicitudCeseCartaPreAvisoFormatoID(IdSolicitudCese)
                Dim ruta As String = dt.Rows(0).Table(0)("linkdescarga").ToString()
                Dim uccontrol1 As New XtraUserControlWebBrowser()
                uccontrol1.WebBrowser1.Show()
                uccontrol1.WebBrowser1.Navigate(String.Format(ruta, Application.StartupPath))
                'System.Diagnostics.Process.Start(ruta)
                'MiForm.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btnAdjuntarCartaDespido_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdjuntarCartaDespido.ItemClick
        If GridView3.RowCount <> 0 Then
            MessageBox.Show("Ya existe un archivo, por favor elimine el archivo para poder adjuntar", "Adjuntar Archivo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            OpenFileDialog1.InitialDirectory = "c:\"
            OpenFileDialog1.Filter = "docx |*.docx"
            OpenFileDialog1.FilterIndex = 2
            OpenFileDialog1.RestoreDirectory = True

            Dim ruta As String
            Dim link As String

            '''''ojo: crear una carpeta nueva para el cartadedespido''''''''''''''''
            ruta = "https://controlatenciones.blob.core.windows.net/cartadespidocese/"

            Dim nameArchivo As String = ""

            Try
                If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Cursor = Cursors.WaitCursor

                    Dim fechaArchivo As Date = Date.Now.Date

                    nameArchivo = CeseDAO.IdSolicitudCese.ToString & "_" & "RH-CAD" & "_" & 0 & "_" & Format(fechaArchivo, "dd-MM-yyyy") & "_" & System.IO.Path.GetFileName(OpenFileDialog1.FileName)

                    Dim storageAccount As CloudStorageAccount
                    storageAccount = CloudStorageAccount.Parse(ConfigurationManager.AppSettings("StorageConnectionString"))

                    'Se recupera el blob
                    Dim blobClient As CloudBlobClient = storageAccount.CreateCloudBlobClient()

                    'Se recupera el contenedor previamente creado en Azure
                    Dim container As CloudBlobContainer = blobClient.GetContainerReference("cartadespidocese")

                    'Se recupera una referencia a un blob donde se guardara el archivo
                    Dim blockBlob As CloudBlockBlob = container.GetBlockBlobReference(nameArchivo)

                    link = ruta + nameArchivo

                    'Se guarda el archivo en el blob
                    blockBlob.UploadFromStream(OpenFileDialog1.OpenFile)

                    If CeseDAO.InsertaSolicitudCeseCartaDespido(CeseDAO.IdSolicitudCese, nameArchivo, ruta, link) Then
                        MessageBox.Show("El Archivo se ha adjuntado correctamente.", "Adjuntar Archivo")
                        RefrescarArchivo()
                        Cursor = Cursors.Default
                    End If

                End If
            Catch ex As Exception
                MessageBox.Show("Ocurrio un error al adjuntar el archivo.", "Error de Conexión")
                Cursor = Cursors.Default
            End Try
            RefrescarDespidoArchivo()
        End If
    End Sub

    Private Sub RepositoryItemFormatoCartaDespido_Click(sender As Object, e As EventArgs) Handles RepositoryItemFormatoCartaDespido.Click
        If MessageBox.Show("¿Está seguro de descargar el archivo?", "Eliminar Archvivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then

            IdSolicitudCese = GridView3.GetFocusedRowCellValue("IDSOLICITUDCESE")
            If IdSolicitudCese <> 0 Then
                Dim dt As New DataTable
                dt = CeseDAO.ListSolicitudCeseCartaDespidoFormatoID(IdSolicitudCese)
                Dim ruta As String = dt.Rows(0).Table(0)("LINKDESCARGA").ToString()
                Dim uccontrol1 As New XtraUserControlWebBrowser()
                uccontrol1.WebBrowser1.Show()
                uccontrol1.WebBrowser1.Navigate(String.Format(ruta, Application.StartupPath))
                'System.Diagnostics.Process.Start(ruta)
                'MiForm.ShowDialog()
            End If
        End If
    End Sub

    Private Sub RepositoryItemEliminarFormatoDespido_Click(sender As Object, e As EventArgs) Handles RepositoryItemEliminarFormatoDespido.Click
        If MessageBox.Show("¿Está seguro de eliminar el archivo?", "Eliminar Archvivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            IdSolicitudCese = GridView3.GetFocusedRowCellValue("IDSOLICITUDCESE")
            NombreArchivo = GridView3.GetFocusedRowCellValue("NOMBREARCHIVO")
            If IdSolicitudCese <> 0 Then
                Try
                    Dim ArchivoEliminar As String
                    ArchivoEliminar = GridView3.GetFocusedRowCellValue("NOMBREARCHIVO")
                    Dim storageAccount As CloudStorageAccount
                    storageAccount = CloudStorageAccount.Parse(ConfigurationManager.AppSettings("StorageConnectionString"))
                    'Se recupera el blob
                    Dim blobClient As CloudBlobClient = storageAccount.CreateCloudBlobClient()
                    'Se recupera el contenedor previamente creado en Azure
                    Dim container As CloudBlobContainer = blobClient.GetContainerReference("cartadespidocese")
                    'Dim container As CloudBlobContainer = blobClient.GetContainerReference("pruebasarchivos")
                    Dim blockBlob As CloudBlockBlob = container.GetBlockBlobReference(ArchivoEliminar)
                    blockBlob.Delete()
                Catch ex As Exception
                    MessageBox.Show("Ocurrio un error al eliminar el archivo.", "Error de Conexión")
                    Cursor = Cursors.Default
                End Try
            End If
            If CeseDAO.EliminarSolicitudCeseCartaDespidoArchivo(IdSolicitudCese, NombreArchivo) Then
                MessageBox.Show("Archivo Eliminado.", "Eliminación de Archivo")
            End If
            RefrescarDespidoArchivo()
        End If
    End Sub

    Private Sub btnEnviarCartaDespido_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnValidarCartaDespido.ItemClick
        If GridView3.RowCount <> 0 Then
            If MessageBox.Show("¿Está seguro enviar la carta de despido a RRHH?", "Envío a RRHH", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                If CeseDAO.EnvioSolicitudCeseCartaDespidoRrhh(CeseDAO.IdSolicitudCese) Then
                    Dim dtEmail As New DataTable
                    dtEmail = CeseDAO.GetCeseIDCorreo(CeseDAO.IdSolicitudCese)

                    Dim numerosolicitud As String = dtEmail.Rows(0)("NUMEROSOLICITUDCESE")
                    Dim correocopia As String = dtEmail.Rows(0)("CORREOCOPIA")

                    Dim dni As String = dtEmail.Rows(0)("NUMERODOCUMENTO")
                    Dim apellidopaterno As String = dtEmail.Rows(0)("APELLIDOPATERNO")
                    Dim apellidomaterno As String = dtEmail.Rows(0)("APELLIDOMATERNO")
                    Dim nombres As String = dtEmail.Rows(0)("NOMBRES")
                    Dim empleado As String = apellidopaterno + " " + apellidomaterno + " " + nombres
                    Dim razoncomercial As String = dtEmail.Rows(0)("RAZONCOMERCIAL")
                    Dim razonsocial As String = dtEmail.Rows(0)("RAZONSOCIAL")

                    Dim emailTo As String
                    emailTo = correocopia

                    Dim Mensaje As String
                    Mensaje =
                "<font face=Calibri size=3>" & "Se comunica que legal a adjuntado la carta de despido de la solicitud de cese numero" & numerosolicitud & "en referencia para el Señor(a)  " & empleado &
                " con DNI:  " & dni & " Por favor ingresar al Sistema Gestion de RRHH para continuar con el proceso de cese de dicho empleado."
                    BDCentralDAO.InsertEnvioCorreo(emailTo, " SolicitudCese: " + numerosolicitud, Mensaje)
                End If
                Me.Close()
            End If
        Else
            MessageBox.Show("Falta adjuntar la carta de Carta Despido.", "Envío a RRHH", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick
        If MessageBox.Show("¿Está seguro de guardar las moficicaiones?", "Registro de Cese", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            CeseDAO.EnvioSolicitudCeseRegistroGuardar(CeseDAO.IdSolicitudCese, dtCartaNotariaPreAviso.EditValue, dtCartaNotariaDespido.EditValue)
            Me.Close()
        End If
    End Sub

    Private Sub btnValidarCartaPreAviso_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnValidarCartaPreAviso.ItemClick
        If GridView2.RowCount <> 0 Then
            If MessageBox.Show("¿Está seguro enviar el formato solicitud de cese a RRHH?", "Envío a RRHH", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                If CeseDAO.ValidarSolicitudCeseCartaPreAvisoLegal(CeseDAO.IdSolicitudCese) Then
                    Dim dtEmail As New DataTable
                    dtEmail = CeseDAO.GetCeseIDCorreo(CeseDAO.IdSolicitudCese)

                    Dim numerosolicitud As String = dtEmail.Rows(0)("NUMEROSOLICITUDCESE")
                    Dim correocopia As String = dtEmail.Rows(0)("CORREOCOPIA")

                    Dim dni As String = dtEmail.Rows(0)("NUMERODOCUMENTO")
                    Dim apellidopaterno As String = dtEmail.Rows(0)("APELLIDOPATERNO")
                    Dim apellidomaterno As String = dtEmail.Rows(0)("APELLIDOMATERNO")
                    Dim nombres As String = dtEmail.Rows(0)("NOMBRES")
                    Dim empleado As String = apellidopaterno + " " + apellidomaterno + " " + nombres
                    Dim razoncomercial As String = dtEmail.Rows(0)("RAZONCOMERCIAL")
                    Dim razonsocial As String = dtEmail.Rows(0)("RAZONSOCIAL")

                    Dim emailTo As String
                    emailTo = correocopia

                    Dim Mensaje As String
                    Mensaje =
                "<font face=Calibri size=3>" & "Se comunica que legal a adjuntado la carta de pre-aviso de la solicitud de cese numero" & numerosolicitud & "en referencia para el Señor(a)  " & empleado &
                " con DNI:  " & dni & " Por favor ingresar al sistema gestion de rrhh para continuar con el proceso de cese de dicho empleado."

                    BDCentralDAO.InsertEnvioCorreo(emailTo, " SolicitudCese: " + numerosolicitud, Mensaje)
                End If
                Me.Close()
            End If
        Else
            MessageBox.Show("Falta adjuntar la carta de Pre-Aviso.", "Envío a RRHH", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnValidarRrhh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnValidarRrhh.ItemClick
        If GridView2.RowCount <> 0 Then
            If MessageBox.Show("¿Está seguro de proceder con el despido del personal?", "Despido Personal", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                CeseDAO.ValidarSolicitudCeseRrhh(CeseDAO.IdSolicitudCese, dtCartaNotariaPreAviso.EditValue)
                Me.Close()
            End If
        Else
            MessageBox.Show("Falta adjuntar la carta de Pre-Aviso.", "Envío a RRHH", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnValidarSolicitud_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnValidarSolicitud.ItemClick
        'PROCESOEVALUACIONLEGAL = 1 NO PROCEDE DE MANERA LEGAL
        'PROCESOEVALUACIONLEGAL = 2 PROCEDE DE MANERA LEGAL
        Dim dialog As DialogResult = MessageBox.Show("¿La solicitud de cese procede de manera legal?", "Evaluación cese", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If dialog = DialogResult.Yes Then
            If CeseDAO.ValidarSolicitudCese(CeseDAO.IdSolicitudCese, 2) Then
                Dim dtEmail As New DataTable
                dtEmail = CeseDAO.GetCeseIDCorreo(CeseDAO.IdSolicitudCese)

                Dim numerosolicitud As String = dtEmail.Rows(0)("NUMEROSOLICITUDCESE")
                Dim correolegal As String = dtEmail.Rows(0)("CORREOLEGAL")

                Dim dni As String = dtEmail.Rows(0)("NUMERODOCUMENTO")
                Dim apellidopaterno As String = dtEmail.Rows(0)("APELLIDOPATERNO")
                Dim apellidomaterno As String = dtEmail.Rows(0)("APELLIDOMATERNO")
                Dim nombres As String = dtEmail.Rows(0)("NOMBRES")
                Dim empleado As String = apellidopaterno + " " + apellidomaterno + " " + nombres
                Dim razoncomercial As String = dtEmail.Rows(0)("RAZONCOMERCIAL")
                Dim razonsocial As String = dtEmail.Rows(0)("RAZONSOCIAL")

                Dim emailTo As String
                emailTo = correolegal

                Dim Mensaje As String
                Mensaje =
            "<font face=Calibri size=3>" & "Se comunica que tiene una solicitud de cese pendiente, solicitud de cese numero " & numerosolicitud & " en referencia para el Señor(a)  " & empleado &
            " con DNI:  " & dni & " Por favor ingresar al Sistema de Gestión de RRHH para poder adjuntar la carta de pre-aviso de dicho empleado."

                BDCentralDAO.InsertEnvioCorreo(emailTo, " SolicitudCese: " + numerosolicitud, Mensaje)
            End If
        ElseIf dialog = DialogResult.No Then
            CeseDAO.ValidarSolicitudCese(CeseDAO.IdSolicitudCese, 1)
        End If
        Me.Close()
    End Sub

    Private Sub btnEnviarLegalDespido_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEnviarLegalDespido.ItemClick
        If MessageBox.Show("¿Está seguro de enviar la solicitud de cese a legal?", "Envío a Legal", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            If CeseDAO.EnvioSolicitudCeseDespido(CeseDAO.IdSolicitudCese) Then
                Dim dtEmail As New DataTable
                dtEmail = CeseDAO.GetCeseIDCorreo(CeseDAO.IdSolicitudCese)

                Dim numerosolicitud As String = dtEmail.Rows(0)("NUMEROSOLICITUDCESE")
                Dim correolegal As String = dtEmail.Rows(0)("CORREOLEGAL")

                Dim dni As String = dtEmail.Rows(0)("NUMERODOCUMENTO")
                Dim apellidopaterno As String = dtEmail.Rows(0)("APELLIDOPATERNO")
                Dim apellidomaterno As String = dtEmail.Rows(0)("APELLIDOMATERNO")
                Dim nombres As String = dtEmail.Rows(0)("NOMBRES")
                Dim empleado As String = apellidopaterno + " " + apellidomaterno + " " + nombres
                Dim razoncomercial As String = dtEmail.Rows(0)("RAZONCOMERCIAL")
                Dim razonsocial As String = dtEmail.Rows(0)("RAZONSOCIAL")

                Dim emailTo As String
                emailTo = correolegal

                Dim Mensaje As String
                Mensaje =
            "<font face=Calibri size=3>" & "Se comunica que rrhh autoriza para que proceda con la carta de despido de la solicitud de cese numero" & numerosolicitud & "en referencia para el Señor(a)  " & empleado &
            " con DNI:  " & dni & " Por favor ingresar al sistema de gestión de rrhh para poder adjuntar la carta de despido de dicho empleado."

                BDCentralDAO.InsertEnvioCorreo(emailTo, " SolicitudCese: " + numerosolicitud, Mensaje)
            End If
            Me.Close()
        End If
    End Sub

    Private Sub RepositoryItemEliminarFormato_Click(sender As Object, e As EventArgs) Handles RepositoryItemEliminarFormato.Click
        If MessageBox.Show("¿Está seguro de eliminar el archivo?", "Eliminar Archvivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            IdSolicitudCese = GridView2.GetFocusedRowCellValue("IDSOLICITUDCESE")
            NombreArchivo = GridView2.GetFocusedRowCellValue("NOMBREARCHIVO")
            If IdSolicitudCese <> 0 Then
                Try
                    Dim ArchivoEliminar As String
                    ArchivoEliminar = GridView2.GetFocusedRowCellValue("NOMBREARCHIVO")
                    Dim storageAccount As CloudStorageAccount
                    storageAccount = CloudStorageAccount.Parse(ConfigurationManager.AppSettings("StorageConnectionString"))
                    'Se recupera el blob
                    Dim blobClient As CloudBlobClient = storageAccount.CreateCloudBlobClient()
                    'Se recupera el contenedor previamente creado en Azure
                    Dim container As CloudBlobContainer = blobClient.GetContainerReference("cartapreavisocese")
                    'Dim container As CloudBlobContainer = blobClient.GetContainerReference("pruebasarchivos")
                    Dim blockBlob As CloudBlockBlob = container.GetBlockBlobReference(ArchivoEliminar)
                    blockBlob.Delete()
                Catch ex As Exception
                    MessageBox.Show("Ocurrio un error al eliminar el archivo.", "Error de Conexión")
                    Cursor = Cursors.Default
                End Try
            End If
            If CeseDAO.EliminarSolicitudCeseCartaPreAvisoArchivo(IdSolicitudCese, NombreArchivo) Then
                MessageBox.Show("Archivo Eliminado.", "Eliminación de Archivo")
            End If
            RefrescarArchivo()
        End If
    End Sub

    Private Sub btnAprobar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAprobar.ItemClick
        If MessageBox.Show("¿Está seguro de proceder con el despido del personal?", "Despido Personal", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            CeseDAO.AprobarSolicitudCeseRrhh(CeseDAO.IdSolicitudCese, dtCartaNotariaDespido.EditValue)
            Me.Close()
        End If
    End Sub

    Private Sub btnAnular_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnular.ItemClick
        If MessageBox.Show("¿Esta seguro de anular la solicitud de cese?", "Anular cese", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            'If PrestamoDAO.UpdatePrestamoDepositoEstado(PrestamosBE) Then
            If CeseDAO.GetCeseAnularRrhh(CeseDAO.IdSolicitudCese, BDCentralDAO.UsuarioBE.IDUsuario) Then
                'ENVIO CORREO
                Dim dtEmail As New DataTable
                dtEmail = CeseDAO.GetCeseIDCorreo(CeseDAO.IdSolicitudCese)

                Dim numerosolicitud As String = dtEmail.Rows(0)("NUMEROSOLICITUDCESE")
                Dim correosolicitante As String = dtEmail.Rows(0)("CORREOSUPERVISOR")
                Dim correocopia As String = dtEmail.Rows(0)("CORREOCOPIA")

                Dim dni As String = dtEmail.Rows(0)("DNI")
                Dim apellidopaterno As String = dtEmail.Rows(0)("APELLIDOPATERNO")
                Dim apellidomaterno As String = dtEmail.Rows(0)("APELLIDOMATERNO")
                Dim nombres As String = dtEmail.Rows(0)("NOMBRES")
                Dim empleado As String = apellidopaterno + " " + apellidomaterno + " " + nombres
                Dim razoncomercial As String = dtEmail.Rows(0)("RAZONCOMERCIAL")
                Dim razonsocial As String = dtEmail.Rows(0)("RAZONSOCIAL")

                Dim emailTo As String
                emailTo = correocopia + correosolicitante

                Dim Mensaje As String
                Mensaje =
                "<font face=Calibri size=3> Estimado Señores de:  " & razoncomercial & "<br>" & "<br>" &
                    "Se comunica que se anulo la solicitud de cese numero" & numerosolicitud & "en referencia para el Señor(a)  " & empleado &
                " con DNI:  " & dni & "."

                BDCentralDAO.InsertEnvioCorreo(emailTo, " SolicitudCese: " + numerosolicitud, Mensaje)

                Me.Close()
            Else
                MessageBox.Show("Error al registrar depósito")
            End If
        End If
        'End If
    End Sub

    Private Sub btnRetornarCese_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRetornarCese.ItemClick

        If (CeseBE.ESTADOVALIDADOLEGALPREAVISO = False And CeseBE.ESTADOENVIOLEGALDESPIDO = False) Then
            If MessageBox.Show("¿Esta seguro de retornar la solicitud de cese?", "Retornar cese", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                If CeseDAO.GetRetornarSolicitudCeseRrhh(CeseDAO.IdSolicitudCese, "") Then
                    MessageBox.Show("Solicitud retornada con exito", "Renorno de Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("Error al retornar Solicitud", "Renorno de Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        ElseIf (CeseBE.ESTADOVALIDADOLEGALPREAVISO And CeseBE.ESTADOENVIOLEGALDESPIDO = False) Then
            Dim DESCRIPCIONRETORNO As String = txtDescripcionAnulacion.Text
            If DESCRIPCIONRETORNO <> "" Then
                If MessageBox.Show("¿Esta seguro de desporcesar el validado, Carta Pre-Aviso?", "Desprocesar Validado Carta Pre-Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                    If CeseDAO.GetRetornarSolicitudCeseRrhh(CeseDAO.IdSolicitudCese, DESCRIPCIONRETORNO) Then
                        MessageBox.Show("validación desprocesada con éxito, Carta Pre-Aviso", "Desprocesar Validado Carta Pre-Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Else
                        MessageBox.Show("Error al desprocesar validado, Carta Pre-Aviso", "Desprocesar Validado Carta Pre-Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MessageBox.Show("Para poder retornar la solicud de cese a RRHH debe ingresar la descripcion de la anulación", "Retornar Solicitud Cese", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        ElseIf (CeseBE.ESTADOVALIDADOLEGALPREAVISO And CeseBE.ESTADOENVIOLEGALDESPIDO) Then
            Dim DESCRIPCIONRETORNO As String = txtDescripcionAnulacion.Text
            If DESCRIPCIONRETORNO <> "" Then
                If MessageBox.Show("¿Esta seguro de retornar la solicitud de cese, Carta Despido?", "Retornar cese Carta Despido", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                    If CeseDAO.GetRetornarSolicitudCeseRrhh(CeseDAO.IdSolicitudCese, DESCRIPCIONRETORNO) Then
                        MessageBox.Show("Solicitud retornada con exito Carta Despido", "Renorno de Solicitud Despido", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Else
                        MessageBox.Show("Error al retornar Solicitud Carta Despido", "Renorno de Solicitud Despido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MessageBox.Show("Para poder retornar la solicud de cese a RRHH debe ingresar la descripcion de la anulación", "Retornar Solicitud Cese", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub btnHistorialEmpleado_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHistorialEmpleado.ItemClick
        Dim idempleado = CeseDAO.IdEmpleado
        BDAccionPersonalDAO.IdEmpleado = idempleado
        If BDAccionPersonalDAO.IdEmpleado <> 0 Then
            Dim MiForm As New EmpleadoHistorial

            Nombre = txtEmpleado.Text
            NombreLog = Me.Text ' formulario , reporte,
            DetalleLog = "HISTORIAL EMPLEADO " & Nombre ' acción: impresión, exportar, tb poner filtros , lo que se
            BDCentralDAO.AccesoLogIns(IDSistema, BDCentralDAO.UsuarioBE.IDUsuario, DetalleLog, NombreLog)

            MiForm.ShowDialog()
        End If
    End Sub

    Private Sub btnDesprocesarValidado_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDesprocesarValidado.ItemClick
        If MessageBox.Show("Esta seguro de desprocesar el validado de solicitud", "Desprocesar Validado", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            If CeseDAO.RetornarSolicitudCese(CeseDAO.IdSolicitudCese) Then
                MessageBox.Show("Retorno de solicitud Exitoso")
                Me.Close()
            End If
        End If
    End Sub
End Class