Imports System.Configuration
Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework
Imports Microsoft.WindowsAzure.Storage
Imports Microsoft.WindowsAzure.Storage.Blob

Public Class MemorandumDetails

    Private MemorandumBE As New MemorandumBE
    Dim bsFormatoLegal As New BindingSource
    Dim fechaenvionotaria As Date
    Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True
        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDMEMORANDUM", "IDMEMORANDUM", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 190, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NIVEL FALTA", "NIVELFALTA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FALTA", "FALTA", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "PESOSANCION", "PESOSANCION", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA", "FECHAREVISADO", 70, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO PROCESO", "ESTADOPROCESO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        ControlesDevExpress.InitGridViewColumn(GridView6, "ID", "IDPRESTAMO", 10, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView6, "NUMERO SOLICITUD", "NUMEROSOLICITUD", 30, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView6, "RAZON SOCIAL", "RAZONSOCIAL", 45, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView6, "FECHA", "FECHA", 20, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView6, "MON. SOLICITADO", "MONTO", 25, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView6, "MON. APROBADO", "MONTOAPROBADO", 25, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView6, "MEDIO PAGO", "MEDIOPAGO", 25, True, ControlesDevExpress.eGridViewFormato.Checked, True)

        ControlesDevExpress.InitGridViewColumn(GridView7, "IDLICENCIA", "IDLICENCIA", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO SOLICITUD", "NUMEROSOLICITUD", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView7, "FECHA SOLICITUD", "FECHA", 120, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView7, "TIPO LICENCIA", "LICENCIATIPO", 170, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView7, "RAZON SOCIAL", "RAZONSOCIAL", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView7, "DESDE", "FECHAPERIODOINICIO", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView7, "HASTA", "FECHAPERIODOFIN", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView7, "CANTIDAD DIAS", "CANTIDADDIAS", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "IDDESCARGO", "IDSUSTENTOARCHIVO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridView1
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NIVELFALTA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FALTA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAREVISADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        ControlesDevExpress.InitGridControl(GridControl2)
        ControlesDevExpress.InitGridViewColumn(GridView2, "IDMEMORANDUM", "IDMEMORANDUM", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "NOMBRE ARCHIVO", "nombrearchivo", 600, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "LINK", "linkdescarga", 250, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        RefrescarArchivo()
    End Sub
    Private Sub RefrescarArchivo()
        bsFormatoLegal.DataSource = MemorandumDAO.ListMemorandumFormatoLegalID(MemorandumDAO.IdMemorandum)
        Me.GridControl2.DataSource = bsFormatoLegal
    End Sub
    Private Sub MemorandumDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        If MemorandumDAO.IdMemorandum <> 0 Then
            ListarFaltas()
            ListarSancion()
            MemorandumBE = MemorandumDAO.GetMemorandumByID(MemorandumDAO.IdMemorandum)
            With MemorandumBE
                txtSolicitante.Text = MemorandumBE.Solicitante
                txtDni.Text = MemorandumBE.DNI
                txtFecha.Text = MemorandumBE.Fecha
                txtRazonSocial.Text = MemorandumBE.RazonSocial
                txtRazonComercial.Text = MemorandumBE.RazonComercial
                txtCargo.Text = MemorandumBE.Cargo
                txtEmpleado.Text = MemorandumBE.Nombres + " " + MemorandumBE.ApellidoPaterno + " " + MemorandumBE.ApellidoMaterno
                chkDescuento.EditValue = MemorandumBE.DescuentoRemunerativo
                txtMontoDescuento.Text = MemorandumBE.MontoDescuento
                txtDescripcionLegal.Text = MemorandumBE.DescripcionLegal
                txtDiasSancion.Text = MemorandumBE.DiasSancion
                txtCorreccionRedaccion.Text = MemorandumBE.CorreccionRedaccion
                .IdUsuario = BDCentralDAO.UsuarioBE.IDUsuario
                If chkDescuento.EditValue = 0 Then
                    txtMontoDescuento.Visible = False
                End If
                txtDescripcion.Text = MemorandumBE.Descripcion

                If MemorandumBE.FechaEnvioNotarial = "01/01/1900" Then
                    DtFechaIngresoNotaria.EditValue = Date.Now.Date
                Else
                    DtFechaIngresoNotaria.EditValue = MemorandumBE.FechaEnvioNotarial
                End If

                Dim dtFalta As New DataTable
                dtFalta = MemorandumDAO.GetAllFaltaSancionIDMemorandum(MemorandumDAO.IdMemorandum)
                If dtFalta.Rows.Count > 0 Then
                    sleFalta.EditValue = dtFalta.Rows(0)("IDFALTA")
                    sleSancion.EditValue = dtFalta.Rows(0)("IDFALTANIVEL")
                Else
                    lblDiasSancion.Visible = False
                    txtDiasSancion.Visible = False
                    sleFalta.EditValue = 0

                End If

                If MemorandumDAO.EstadoValidadoRrhh Then
                    sleFalta.Enabled = False
                    chkDescuento.Enabled = False
                    sleSancion.Enabled = False
                    txtMontoDescuento.Enabled = False
                End If

            End With
            If sleSancion.EditValue < 3 Then
                lblDiasSancion.Visible = False
                txtDiasSancion.Visible = False
            End If
            HistorialLicencia(MemorandumBE.IdEmpleado)
            HistorialMemorandum(MemorandumBE.IdEmpleado)
            HistorialPrestamos(MemorandumBE.IdEmpleado)

        End If
    End Sub
    Private Sub HistorialLicencia(ByVal IDEMPLEADO As Int32)
        GridControl4.DataSource = LicenciaDAO.GetListarLicenciaEmpleado(IDEMPLEADO)
    End Sub
    Private Sub HistorialMemorandum(ByVal IDEMPLEADO As Int32)
        GridControl1.DataSource = MemorandumDAO.GetListarMemorandumEmpleado(IDEMPLEADO)
    End Sub

    Private Sub HistorialPrestamos(ByVal IDEMPLEADO As Int32)
        GridControl3.DataSource = PrestamoDAO.GetHistorialPrestamosByID(IDEMPLEADO)
    End Sub
    Private Sub ListarFaltas()
        ControlesDevExpress.InitGridViewColumn(GridViewFalta, "ID", "IDFALTA", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewFalta, "ARTÍCULO", "ARTICULO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewFalta, "INCISO", "INCISO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewFalta, "DESCRIPCION", "DESCRIPCION", 160, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewFalta
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("ARTICULO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("INCISO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        'sleFalta.Properties.DataSource = MemorandumDAO.GetListarFaltasMemorandum
        sleFalta.Properties.DataSource = MemorandumDAO.GetListarFaltasMemorandum(MemorandumDAO.IdMemorandum) '(MemorandumDAO.EstadoValidadoRrhh)
        sleFalta.Properties.DisplayMember = "DESCRIPCION"
        sleFalta.Properties.ValueMember = "IDFALTA"
        sleFalta.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub ListarSancion()
        ControlesDevExpress.InitGridViewColumn(GridViewSancion, "ID", "PESOSANCION", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewSancion, "DESCRIPCION", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewSancion
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        sleSancion.Properties.DataSource = MemorandumDAO.GetListarSancionMemorandum(MemorandumDAO.IdMemorandum) '(MemorandumDAO.EstadoValidadoRrhh)
        sleSancion.Properties.DisplayMember = "DESCRIPCION"
        sleSancion.Properties.ValueMember = "PESOSANCION"
        sleSancion.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub sleFalta_EditValueChanged(sender As Object, e As EventArgs) Handles sleFalta.EditValueChanged
        Dim dtSancion As New DataTable
        dtSancion = MemorandumDAO.GetMemorandumSancionEmpleado(MemorandumBE.IdEmpleado, sleFalta.EditValue)

        With MemorandumBE
            .IdFalta = sleFalta.EditValue
        End With
        If dtSancion.Rows.Count > 0 Then
            sleSancion.EditValue = dtSancion.Rows(0)("PESOSANCION")
        End If

        If sleSancion.EditValue < 3 Then
            lblDiasSancion.Visible = False
            txtDiasSancion.Visible = False
        Else
            lblDiasSancion.Visible = True
            txtDiasSancion.Visible = True
        End If
    End Sub
    Private Function ValidarDescripcionLegal()
        DxErrorProvider1.ClearErrors()
        Dim Result As Boolean = True
        If txtDescripcionLegal.Text = "" Then
            DxErrorProvider1.SetError(txtDescripcionLegal, "Dato obligatorio")
            Result = False
        End If
        With MemorandumBE
            .DescripcionLegal = txtDescripcionLegal.Text
            .PesoSancion = sleSancion.EditValue
            .IdFalta = sleFalta.EditValue
            .CorreccionRedaccion = txtCorreccionRedaccion.Text
        End With
        Return Result
    End Function
    Private Function Validar() As Boolean
        DxErrorProvider1.ClearErrors()
        Dim Result As Boolean = True
        If sleFalta.Text = "" Or sleFalta.EditValue Is Nothing Then
            DxErrorProvider1.SetError(sleFalta, "Dato obligatorio")
            Result = False
        End If
        If chkDescuento.Checked = True And (txtMontoDescuento.Text = 0 Or txtMontoDescuento.Text = "") Then
            DxErrorProvider1.SetError(txtMontoDescuento, "el monto de descuento no puede ser 0, o quite en ckeck de descuento remunerativo")
            Result = False
        End If
        With MemorandumBE
            .IdMemorandum = MemorandumDAO.IdMemorandum
            .DescuentoRemunerativo = chkDescuento.EditValue
            .PesoSancion = sleSancion.EditValue
            .MontoDescuento = txtMontoDescuento.Text
            .DescripcionLegal = txtDescripcionLegal.Text
            .DiasSancion = txtDiasSancion.Text
            .IdFalta = sleFalta.EditValue
            .CorreccionRedaccion = txtCorreccionRedaccion.Text
        End With
        Return Result
    End Function
    Private Function ValidarLegal() As Boolean
        DxErrorProvider1.ClearErrors()
        Dim Result As Boolean = True
        If DtFechaIngresoNotaria.Text = "" Or DtFechaIngresoNotaria.Text = Nothing Then
            DxErrorProvider1.SetError(DtFechaIngresoNotaria, "Dato obligatorio")
            Result = False
        End If
        Return Result
    End Function
    Private Sub btnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick

        If MemorandumDAO.IdMemorandum <> 0 Then
            If ValidarLegal() Then
                If MessageBox.Show("¿Esta seguro de guardar las modificaciones?", "Modificación de memorandum", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                    fechaenvionotaria = DtFechaIngresoNotaria.Text
                    MemorandumDAO.MemorandumFechaEnvioNotaria(MemorandumDAO.IdMemorandum, fechaenvionotaria)
                    Me.Close()
                End If
            End If
        End If
    End Sub
    Private Sub btnValidarRRHH_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnValidarRRHH.ItemClick
        If Me.Validar Then
            If (MemorandumDAO.EstadoEnvioLegal = False) Or (MemorandumDAO.EstadoEnvioLegal And MemorandumDAO.EstadoNotificado) Then

                If MessageBox.Show("¿Está seguro de validar el memorandum?", "Validar Memorandum", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                    If MemorandumDAO.AccionMemorandumRRHH(MemorandumBE, 1) Then
                        If MessageBox.Show("Desea enviar correo", "Envío de mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            enviocorreo()
                        End If
                        Me.Close()
                    Else
                        MessageBox.Show("Error al guardar")
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub enviocorreo()
        'ENVIO CORREO
        Dim dtEmail As New DataTable
        dtEmail = MemorandumDAO.GetMemorandumIDCorreo(MemorandumDAO.IdMemorandum)

        Dim nroformato As String = dtEmail.Rows(0)("NUMEROINFORME")
        Dim tienda As String = dtEmail.Rows(0)("RAZONCOMERCIAL")
        Dim correosolicitante As String = dtEmail.Rows(0)("CORREOSOLICITANTE")
        Dim correosupervisor As String = dtEmail.Rows(0)("CORREOSUPERVISOR")

        Dim emailTo As String
        emailTo = correosolicitante + correosupervisor

        Dim empleado As String = dtEmail.Rows(0)("EMPLEADONOMBRE")
        Dim empleadodni As String = dtEmail.Rows(0)("EMPLEADODNI")

        Dim Mensaje As String
        Mensaje = "<font face=Calibri size=3> Estimado Señores de:  " & tienda & "<br>" & "<br>" &
      "Se comunica que se elaboró el documento en referencia para el Señor(a)  " & empleado & "  con DNI:  " & empleadodni & ". Por favor cumplir con los siguientes pasos: </font>" & "<br>" & "<br>" &
      "1. Ingresar a la Plataforma de Control de Atenciones mediante el siguiente link: http://controlatenciones.azurewebsites.net/Account/Login.aspx?ReturnUrl=%2f " & "<br>" &
      "2. Ingresar al documento en referencia." & "<br>" &
      "3. Imprimir el documento. " & "<br>" &
      "4. Hacer firmar el documento y registro de la huella dactilar." & "<br>" &
      "5. Escanear el documento. " & "<br>" &
      "6. Adjuntar el documento en la Plataforma de Control de Atenciones." & "<br>" &
      "7. Enviar el documento en físico al área de Recursos Humanos." & "<br>" & "<br>" &
      "<font face=Calibri size=3> <b> AREA DE RRHH </b> </font>" & "<br>"

        If BDCentralDAO.InsertEnvioCorreo(emailTo, " Memorandum: " + nroformato, Mensaje) Then
            MessageBox.Show("Envio de mensaje exito", "Envio de mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error al enviar mensaje", "Envio de mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnAdjuntar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdjuntar.ItemClick
        OpenFileDialog1.InitialDirectory = "c:\"
        OpenFileDialog1.Filter = "Pdf |*.pdf"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True

        Dim ruta As String
        Dim link As String

        ruta = "https://controlatenciones.blob.core.windows.net/memorandum/"

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
                Dim container As CloudBlobContainer = blobClient.GetContainerReference("memorandum")

                'Se recupera una referencia a un blob donde se guardara el archivo
                Dim blockBlob As CloudBlockBlob = container.GetBlockBlobReference(nameArchivo)

                link = ruta + nameArchivo

                'Se guarda el archivo en el blob
                blockBlob.UploadFromStream(OpenFileDialog1.OpenFile)

                If MemorandumDAO.InsertaMemorandumArchivo(MemorandumDAO.IdMemorandum, 0, nameArchivo, ruta, link) Then
                    MessageBox.Show("El Archivo se ha adjuntado correctamente.", "Adjuntar Archivo")

                    Cursor = Cursors.Default
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al adjuntar el archivo.", "Error de Conexión")
            Cursor = Cursors.Default
        End Try

    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub
    Private Sub RepositoryItemButtonMemorandumArchivo_Click(sender As Object, e As EventArgs)
        MemorandumDAO.IdMemorandum = GridView1.GetFocusedRowCellValue("IDMEMORANDUM")
        If MemorandumDAO.IdMemorandum <> 0 Then
            Dim MiForm As New MemorandumArchivos
            MiForm.btnFirmaDocumento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Dim dt As DataTable = MemorandumDAO.ListaMemorandumArchivos(MemorandumDAO.IdMemorandum)
            If dt.Rows.Count <> 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim ruta As String = dt.Rows(i).Table(i)("linkdescarga").ToString
                    Dim tab As String
                    tab = "Archivo" + Convert.ToString(i + 1)
                    Dim NewTab As New XtraTabPage
                    NewTab.Name = tab
                    NewTab.Text = tab
                    MiForm.XtraTabControl1.TabPages.Add(NewTab)

                    Dim uccontrol1 As New XtraUserControlWebBrowser()
                    NewTab.Controls.Add(uccontrol1)
                    uccontrol1.Dock = DockStyle.Fill

                    uccontrol1.WebBrowser1.Show()
                    uccontrol1.WebBrowser1.Navigate(String.Format(ruta, Application.StartupPath))
                Next
                MiForm.ShowDialog()
            Else
                MessageBox.Show("El memorandum no contiene archivo", "Archivo de Memorandum")
            End If
        End If

    End Sub
    Private Sub RepositoryItemInformeArchivo_Click(sender As Object, e As EventArgs)
        MemorandumDAO.IdMemorandum = GridView1.GetFocusedRowCellValue("IDMEMORANDUM")
        Dim reportinforme As New RptInformeDisciplinario
        Dim dtcabecera As New DataTable
        dtcabecera = MemorandumDAO.ListaMemorandumGetBy(MemorandumDAO.IdMemorandum)
        reportinforme.XrNumeroInforme.Text = dtcabecera.Rows(0).Item("NUMEROINFORME")
        'reportinforme.XrArea.Text = dtcabecera.Rows(0).Item("AREA")
        reportinforme.XrRazonSocial.Text = dtcabecera.Rows(0).Item("RAZONSOCIAL")
        reportinforme.XrNombreComercial.Text = dtcabecera.Rows(0).Item("RAZONCOMERCIAL")
        reportinforme.XrRucLocal.Text = dtcabecera.Rows(0).Item("IDTRIBUTARIO")
        reportinforme.XrDireccionLocal.Text = dtcabecera.Rows(0).Item("DIRECCION")
        reportinforme.XrFecha.Text = dtcabecera.Rows(0).Item("FECHA")
        reportinforme.XrSolicitante.Text = dtcabecera.Rows(0).Item("SOLICITANTE")
        reportinforme.XrSolicitanteDni.Text = dtcabecera.Rows(0).Item("SOLICITANTEDNI")
        reportinforme.XrSolicitantePuesto.Text = dtcabecera.Rows(0).Item("SOLICITANTECARGO")
        reportinforme.XrRepresentante.Text = dtcabecera.Rows(0).Item("REPRESENTANTENOMBRE")
        reportinforme.XrRepresentanteDni.Text = dtcabecera.Rows(0).Item("REPRESENTANTEDNI")
        reportinforme.XrRepresentantePuesto.Text = dtcabecera.Rows(0).Item("REPRESENTANTECARGO")
        reportinforme.XrEmpleadoMemorandum.Text = dtcabecera.Rows(0).Item("EMPLEADO")
        reportinforme.XrEmpleadoDni.Text = dtcabecera.Rows(0).Item("EMPLEADODNI")
        reportinforme.XrEmpleadoPuesto.Text = dtcabecera.Rows(0).Item("EMPLEADOCARGO")
        reportinforme.XrDescripcionMemorandum.Text = dtcabecera.Rows(0).Item("DESCRIPCION")
        ReportView.DocumentViewer.DocumentSource = reportinforme
        ReportView.DocumentViewer.Refresh()
        ReportView.Show()
    End Sub

    Private Sub btnCartaCompromiso_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCartaNotarial.ItemClick
        If GridView2.RowCount <> 0 Then
            MessageBox.Show("Existe un formato, elimilar formato para poder adjuntar el nuevo formato", "Adjunto de archivo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            OpenFileDialog1.InitialDirectory = "c:\"
            OpenFileDialog1.Filter = "docx |*.docx"
            OpenFileDialog1.FilterIndex = 2
            OpenFileDialog1.RestoreDirectory = True

            Dim ruta As String
            Dim link As String
            ' esto se va a crear en una bueva carpeta azure

            ruta = "https://controlatenciones.blob.core.windows.net/formatocartanotarialmemorandum/"


            Dim nameArchivo As String = ""

            Try
                If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Cursor = Cursors.WaitCursor

                    Dim fechaArchivo As Date = Date.Now.Date

                    nameArchivo = MemorandumDAO.IdMemorandum.ToString & "_" & "RH-MCN" & "_" & 0 & "_" & Format(fechaArchivo, "dd-MM-yyyy") & "_" & System.IO.Path.GetFileName(OpenFileDialog1.FileName)

                    Dim storageAccount As CloudStorageAccount
                    storageAccount = CloudStorageAccount.Parse(ConfigurationManager.AppSettings("StorageConnectionString"))

                    'Se recupera el blob
                    Dim blobClient As CloudBlobClient = storageAccount.CreateCloudBlobClient()

                    'Se recupera el contenedor previamente creado en Azure

                    Dim container As CloudBlobContainer = blobClient.GetContainerReference("formatocartanotarialmemorandum")

                    'Se recupera una referencia a un blob donde se guardara el archivo
                    Dim blockBlob As CloudBlockBlob = container.GetBlockBlobReference(nameArchivo)

                    link = ruta + nameArchivo

                    'Se guarda el archivo en el blob
                    blockBlob.UploadFromStream(OpenFileDialog1.OpenFile)

                    If MemorandumDAO.InsertaMemorandumFormatoLegal(MemorandumDAO.IdMemorandum, nameArchivo, ruta, link) Then
                        MessageBox.Show("El Archivo se ha adjuntado correctamente.", "Adjuntar Archivo")
                        Cursor = Cursors.Default
                        RefrescarArchivo()
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Ocurrio un error al adjuntar el archivo.", "Error de Conexión")
                Cursor = Cursors.Default
            End Try
        End If
    End Sub
    Private Sub btnEnviarLegal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEnviarLegal.ItemClick
        If Validar() Then
            ' If MemorandumDAO.IdMemorandum <> 0 And GridView1.GetFocusedRowCellValue("FIRMADOCUMENTO") = False Then
            If MemorandumDAO.IdMemorandum <> 0 Then
                If MessageBox.Show("¿Está seguro de enviar el memorandum a legal?", "Envío a Legal", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                    If MemorandumDAO.AccionMemorandumRRHH(MemorandumBE, 3) Then
                        Dim dtEmail As New DataTable
                        dtEmail = MemorandumDAO.GetMemorandumIDCorreo(MemorandumDAO.IdMemorandum)

                        Dim nroformato As String = dtEmail.Rows(0)("NUMEROINFORME")
                        Dim tienda As String = dtEmail.Rows(0)("RAZONCOMERCIAL")
                        Dim correolegal As String = dtEmail.Rows(0)("CORREOLEGAL")

                        Dim emailTo As String
                        emailTo = correolegal

                        Dim empleado As String = dtEmail.Rows(0)("EMPLEADONOMBRE")
                        Dim empleadodni As String = dtEmail.Rows(0)("EMPLEADODNI")

                        Dim Mensaje As String
                        Mensaje = "<font face=Calibri size=3>" & "Se comunica que tiene un memorandum por evaluar de la solicitud de memorandum numero" & nroformato & "en referencia para el Señor(a)  " & empleado &
        " con DNI:  " & empleadodni & " Por favor ingresar al Sistema de Gestión de RRHH para poder proceder con la evaluación del memorandum de dicho empleado."
                        BDCentralDAO.InsertEnvioCorreo(emailTo, " Memorandum: " + nroformato, Mensaje)
                    End If
                End If
                'Else
                '    MessageBox.Show("El memorandum se encuentra firmado, no procedera a legal", "Envío a Legal", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            End If
            Me.Close()
        End If

    End Sub
    Private Sub btnNoticar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNotificar.ItemClick
        If MemorandumDAO.IdMemorandum <> 0 Then
            If GridView2.RowCount <> 0 Then
                If ValidarLegal() Then
                    fechaenvionotaria = DtFechaIngresoNotaria.Text
                    If MessageBox.Show("¿Está seguro de haber notificado el memorandum?", "Memorandum Legal", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                        MemorandumDAO.NotificarMemorandumLegal(MemorandumDAO.IdMemorandum, fechaenvionotaria)
                    End If
                    Me.Close()
                End If
            Else
                MessageBox.Show("Falta adjuntar el formato para poder ser notificado", "Adjunto de archivo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub btnFormatoLegal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFormatoLegal.ItemClick
        Dim dt As New DataTable
        dt = MemorandumDAO.ListMemorandumFormatoLegalID(MemorandumDAO.IdMemorandum)

        If dt.Rows.Count = 0 Then
            OpenFileDialog1.InitialDirectory = "c:\"
            OpenFileDialog1.Filter = "docx |*.docx"
            OpenFileDialog1.FilterIndex = 2
            OpenFileDialog1.RestoreDirectory = True

            Dim ruta As String
            Dim link As String

            '''''ojo: crear una carpeta nueva para el formatolegal''''''''''''''''
            ruta = "https://controlatenciones.blob.core.windows.net/formatocartanotarialmemorandum/"

            Dim nameArchivo As String = ""

            Try
                If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Cursor = Cursors.WaitCursor

                    Dim fechaArchivo As Date = Date.Now.Date

                    nameArchivo = MemorandumDAO.IdMemorandum.ToString & "_" & "RH-MCN" & "_" & 0 & "_" & Format(fechaArchivo, "dd-MM-yyyy") & "_" & System.IO.Path.GetFileName(OpenFileDialog1.FileName)

                    Dim storageAccount As CloudStorageAccount
                    storageAccount = CloudStorageAccount.Parse(ConfigurationManager.AppSettings("StorageConnectionString"))

                    'Se recupera el blob
                    Dim blobClient As CloudBlobClient = storageAccount.CreateCloudBlobClient()

                    'Se recupera el contenedor previamente creado en Azure
                    Dim container As CloudBlobContainer = blobClient.GetContainerReference("formatocartanotarialmemorandum")
                    'Se recupera una referencia a un blob donde se guardara el archivo
                    Dim blockBlob As CloudBlockBlob = container.GetBlockBlobReference(nameArchivo)

                    link = ruta + nameArchivo

                    'Se guarda el archivo en el blob
                    blockBlob.UploadFromStream(OpenFileDialog1.OpenFile)

                    If MemorandumDAO.InsertaMemorandumFormatoLegal(MemorandumDAO.IdMemorandum, nameArchivo, ruta, link) Then
                        MessageBox.Show("El Archivo se ha adjuntado correctamente.", "Adjuntar Archivo")
                        RefrescarArchivo()
                        Cursor = Cursors.Default
                    End If

                End If

            Catch ex As Exception
                MessageBox.Show("Ocurrio un error al adjuntar el archivo.", "Error de Conexión")
                Cursor = Cursors.Default
            End Try
        Else
            MessageBox.Show("Ya exste un formato adjuntado", "Adjunto archivo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub RepositoryItemEliminarFormato_Click(sender As Object, e As EventArgs) Handles RepositoryItemEliminarFormato.Click
        If MessageBox.Show("¿Está seguro de eliminar el archivo?", "Eliminar Archvivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            If MemorandumDAO.IdMemorandum <> 0 Then
                Try
                    Dim ArchivoEliminar As String
                    ArchivoEliminar = GridView2.GetFocusedRowCellValue("nombrearchivo")
                    Dim storageAccount As CloudStorageAccount
                    storageAccount = CloudStorageAccount.Parse(ConfigurationManager.AppSettings("StorageConnectionString"))
                    'Se recupera el blob
                    Dim blobClient As CloudBlobClient = storageAccount.CreateCloudBlobClient()
                    'Se recupera el contenedor previamente creado en Azure
                    Dim container As CloudBlobContainer = blobClient.GetContainerReference("formatocartanotarialmemorandum")
                    Dim blockBlob As CloudBlockBlob = container.GetBlockBlobReference(ArchivoEliminar)
                    blockBlob.Delete()
                Catch ex As Exception
                    MessageBox.Show("Ocurrio un error al eliminar el archivo.", "Error de Conexión")
                    Cursor = Cursors.Default
                End Try
            End If
            If MemorandumDAO.EliminarFormatoMemorandumArchivo(MemorandumDAO.IdMemorandum) Then
                MessageBox.Show("Archivo Eliminado.", "Eliminación de Archivo")
            End If
            RefrescarArchivo()
        End If
    End Sub

    Private Sub RepositoryItemFormatoLegal_Click(sender As Object, e As EventArgs) Handles RepositoryItemFormatoLegal.Click
        MemorandumDAO.IdMemorandum = GridView2.GetFocusedRowCellValue("IDMEMORANDUM")
        If MessageBox.Show("¿Está seguro de descargar el archivo?", "Descargar Archvivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            If MemorandumDAO.IdMemorandum <> 0 Then
                Dim dt As New DataTable
                dt = MemorandumDAO.ListMemorandumFormatoLegalID(MemorandumDAO.IdMemorandum)
                Dim ruta As String = dt.Rows(0).Table(0)("linkdescarga").ToString()
                Dim uccontrol1 As New XtraUserControlWebBrowser()
                uccontrol1.WebBrowser1.Show()
                uccontrol1.WebBrowser1.Navigate(String.Format(ruta, Application.StartupPath))
            End If
        End If

    End Sub

    Private Sub btnAprobar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAprobar.ItemClick
        If Validar() Then
            If MessageBox.Show("¿Está seguro de Aprobar el memorandum?", "Revisar Memorandum", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                If Not MemorandumDAO.AprobarMemorandumRRHH(MemorandumBE) Then
                    MessageBox.Show("¿Error en aprobación del Memorandum?", "Aprobar Memorandum")
                Else
                    Me.Close()
                End If
            End If
        End If

    End Sub

    Private Sub btnAnular_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnular.ItemClick

        Dim MiForm As New MemorandumAnular
        MiForm.ShowDialog()
        If MiForm.valoranulado = 1 Then
            Me.Close()
        End If

    End Sub

    Private Sub btnValidarLegal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnValidarLegal.ItemClick
        If MemorandumDAO.IdMemorandum <> 0 Then
            Dim dt As New DataTable
            dt = MemorandumDAO.ListMemorandumFormatoLegalID(MemorandumDAO.IdMemorandum)
            'If dt.Rows.Count <> 0 Then
            If MessageBox.Show("¿Está seguro validar el memorandum?", "Evaluar Memorandum", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then

                    If MemorandumDAO.MemorandumLegalValidarLegal(MemorandumDAO.IdMemorandum) Then


                        Dim dtEmail As New DataTable
                        dtEmail = MemorandumDAO.GetMemorandumIDCorreo(MemorandumDAO.IdMemorandum)
                        Dim numerosolicitud As String = dtEmail.Rows(0)("NUMEROINFORME")
                        Dim correocopia As String = dtEmail.Rows(0)("CORREOCOPIA")

                        Dim dni As String = dtEmail.Rows(0)("EMPLEADODNI")
                        Dim empleado As String = dtEmail.Rows(0)("EMPLEADONOMBRE")
                        Dim razoncomercial As String = dtEmail.Rows(0)("RAZONCOMERCIAL")
                        Dim razonsocial As String = dtEmail.Rows(0)("RAZONSOCIAL")

                        Dim emailTo As String
                        emailTo = correocopia

                        Dim Mensaje As String
                        Mensaje =
                        "<font face=Calibri size=3> Se comunica que legal a adjunto una carta notarial de un memorandum, el numero de solicitud del memorandum es: " & numerosolicitud & " en referencia para el Señor(a)  " & empleado &
                        " con DNI:  " & dni & "."

                        BDCentralDAO.InsertEnvioCorreo(emailTo, " Memorandum: " + numerosolicitud, Mensaje)

                        Me.Close()
                    Else
                        MessageBox.Show("Error al registrar depósito")
                    End If

                    Me.Close()
                End If
                '    Else
                '    MessageBox.Show("Falta adjuntar el archivo", "Adjunto archivo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'End If

            End If
    End Sub

    Private Sub chkDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles chkDescuento.CheckedChanged
        If chkDescuento.Checked = True Then
            txtMontoDescuento.Visible = True
        Else
            txtMontoDescuento.Visible = False
            txtMontoDescuento.Text = 0
        End If
    End Sub

    Private Sub btnEnviarLegalRedaccion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEnviarLegalRedaccion.ItemClick
        If Validar() Then
            If MemorandumDAO.IdMemorandum <> 0 Then
                If MessageBox.Show("¿Está seguro de enviar el memorandum a legal para su redacción pertinente?", "Envío a Legal", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                    If MemorandumDAO.AccionMemorandumRRHH(MemorandumBE, 2) Then
                        Dim dtEmail As New DataTable
                        dtEmail = MemorandumDAO.GetMemorandumIDCorreo(MemorandumDAO.IdMemorandum)

                        Dim nroformato As String = dtEmail.Rows(0)("NUMEROINFORME")
                        Dim tienda As String = dtEmail.Rows(0)("RAZONCOMERCIAL")
                        Dim correolegal As String = dtEmail.Rows(0)("CORREOLEGAL")

                        Dim emailTo As String
                        emailTo = correolegal
                        Dim empleado As String = dtEmail.Rows(0)("EMPLEADONOMBRE")
                        Dim empleadodni As String = dtEmail.Rows(0)("EMPLEADODNI")

                        Dim Mensaje As String
                        Mensaje = "<font face=Calibri size=3>" & "Se comunica que tiene un memorandum por evaluar de la solicitud de memorandum numero " & nroformato & " en referencia para el Señor(a)  " & empleado &
        " con DNI:  " & empleadodni & " Por favor ingresar al Sistema de Gestión de RRHH para poder proceder con la evaluación del memorandum de dicho empleado."
                        BDCentralDAO.InsertEnvioCorreo(emailTo, " Memorandum: " + nroformato, Mensaje)
                    End If
                End If
            End If
            Me.Close()
        End If
    End Sub

    Private Sub btnValidarRedaccion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnValidarRedaccion.ItemClick
        If ValidarDescripcionLegal() Then
            If MemorandumDAO.IdMemorandum <> 0 Then
                If MessageBox.Show("Esta seguro de validar la redacción del memorandum n°" & MemorandumBE.NumeroInforme, "Validar Redacción", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    If Not MemorandumDAO.AccionRedaccionLegal(MemorandumBE, 2) Then
                        MessageBox.Show("Error en la validadción de Redacción")
                    Else
                        Me.Close()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub btnExonerar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExonerar.ItemClick
        Dim MiForm As New MemorandumExonerar
        MiForm.ShowDialog()
        If MiForm.valorexonerado = 1 Then
            Me.Close()
        End If
    End Sub

    Private Sub sleSancion_EditValueChanged(sender As Object, e As EventArgs) Handles sleSancion.EditValueChanged
        If sleSancion.EditValue < 3 Then
            lblDiasSancion.Visible = False
            txtDiasSancion.Visible = False
        Else
            lblDiasSancion.Visible = True
            txtDiasSancion.Visible = True
        End If
    End Sub

    Private Sub btnGuardarLegal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardarLegal.ItemClick
        If ValidarDescripcionLegal() Then
            If MemorandumDAO.IdMemorandum <> 0 Then
                If Not MemorandumDAO.AccionRedaccionLegal(MemorandumBE, 1) Then
                    MessageBox.Show("Error en la validadción de Redacción")
                Else
                    Me.Close()
                End If
            End If
        End If
    End Sub
    Private Sub btnEnviarCorreo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEnviarCorreo.ItemClick
        If MessageBox.Show("Esta seguro de enviar correo", "Enviar Correo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            enviocorreo()
        End If
    End Sub

    Private Sub btnRetornarMemorandum_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRetornarMemorandum.ItemClick
        If MessageBox.Show("Esta seguro de retornar el memorandum a RRHH", "Retornar Solicitud", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            If MemorandumDAO.RetornarMemorandunRRHH(MemorandumDAO.IdMemorandum) Then
                MessageBox.Show("El memorandum retorno a RRHH", "Retorno memorandum", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Error al retornar memorandum", "Retornar memorandum", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnHistorialEmpleado_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHistorialEmpleado.ItemClick

        BDAccionPersonalDAO.IdEmpleado = MemorandumBE.IdEmpleado
        If BDAccionPersonalDAO.IdEmpleado <> 0 Then
            Dim MiForm As New EmpleadoHistorial


            Nombre = txtEmpleado.Text
            NumeroDocumento = txtDni.Text
            NombreLog = Me.Text ' formulario , reporte,
            DetalleLog = "HISTORIAL EMPLEADO " & Nombre & " CON NUMERO DE DOC. " & NumeroDocumento ' acción: impresión, exportar, tb poner filtros , lo que se
            BDCentralDAO.AccesoLogIns(IDSistema, BDCentralDAO.UsuarioBE.IDUsuario, DetalleLog, NombreLog)


            MiForm.ShowDialog()
        End If
    End Sub
End Class
