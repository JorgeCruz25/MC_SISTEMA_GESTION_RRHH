Imports System.Configuration
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework
Imports Microsoft.WindowsAzure.Storage
Imports Microsoft.WindowsAzure.Storage.Blob

Public Class RenunciaDetails
    Dim EmpleadoBE As New EmpleadoBE
    Dim RenunciasBE As New RenunciasBE
    Dim CeseBE As New CeseBE

    Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        CargarMotivoCese()

    End Sub
    Private Sub CargarMotivoCese()
        ControlesDevExpress.InitGridViewColumn(GridViewMotivoCese, "ID", "CODIGOCESE", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewMotivoCese, "DESCRIPCION", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewMotivoCese
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleMotivoCese.Properties.DataSource = BDAccionPersonalDAO.GetMotivoCeseList
        sleMotivoCese.Properties.DisplayMember = "DESCRIPCION"
        sleMotivoCese.Properties.ValueMember = "CODIGOCESE"
        sleMotivoCese.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Function Validar() As Boolean
        Dim Result As Boolean = True

        DxErrorProvider1.ClearErrors()

        If sleMotivoCese.EditValue Is Nothing Or sleMotivoCese.Text = "" Then
            DxErrorProvider1.SetError(sleMotivoCese, "Dato obligatorio")
            Result = False
        End If
        If deFechaCese.EditValue Is Nothing Or deFechaCese.Text = "" Then
            DxErrorProvider1.SetError(deFechaCese, "Dato obligatorio")
            Result = False
        End If
        If txtCodigoUnico.Text = "" Then
            DxErrorProvider1.SetError(txtCodigoUnico, "Campo obligatorio")
            Result = False
        End If
        'If deFechaCese.EditValue.DAY <> 27 And chkCambioRazonSocial.EditValue Then
        '    MessageBox.Show("El cese por cambio de Razon Social debe ser los 27 de cada mes", "Mensaje Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Result = False
        'End If
        Dim dtrenovacion As DataTable
        dtrenovacion = RenunciaDAO.GetEmpleadoAsignadoEnRenovacion(txtIdEmpleado.Text)
        If dtrenovacion.Rows.Count > 0 Then
            MessageBox.Show("El colaborador " & dtrenovacion.Rows(0).Item("EMPLEADONOMBRE") & " se encuentra en el listado de renovaciòn de contrado con fecha" & dtrenovacion.Rows(0).Item("FECHAFINALCONTRATO") & ", por favor eliminar su renovaciòn para poder proceder con el Cese", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Result = False
        End If

        If Result Then
            With RenunciasBE
                .IdRenuncia = RenunciaDAO.IdRenuncia
                .CodigoCese = Convert.ToString(sleMotivoCese.EditValue)
                .Observacion = txtObservacion.Text
                .FechaUltimoDiaTrabajo = deFechaCese.Text
                .PagoDiasBoleta = chkPagoDiasBoleta.EditValue
                .IdUsuarioRegistro = BDCentralDAO.UsuarioBE.IDUsuario

                .IdSolicitante = txtIdEmpleado.Text
                .UsuarioRegistro = BDCentralDAO.UsuarioBE.Usuario
                .CodigoUnico = txtCodigoUnico.Text
                .EstadoReingreso = chkCambioRazonSocial.EditValue
            End With
            With CeseBE
                .CODIGOUNICO = txtCodigoUnico.Text
                .FECHACESE = deFechaCese.Text
                .CODIGOCESE = sleMotivoCese.EditValue
                .OBSERVACION = txtObservacion.Text
                .PAGODIASBOLETA = chkPagoDiasBoleta.EditValue
                .USUARIOREGISTRO = BDCentralDAO.UsuarioBE.Usuario
                .ESTADOREINGRESO = chkCambioRazonSocial.EditValue
                '---------------------------
            End With
            'NO BORRAR ESTO SI VA ----- VALIDA SI HAY SOLICITUDES PENDIENTES O CESES PENDIENTES

            'Dim dt1 As DataTable = CeseDAO.ValidarSolicitudesCesesPendientes(RenunciasBE.IdSolicitante) 'si el empleado tiene una solicitud de cese pendiente       
            'If dt1.Rows(0)("RESULT") = 1 Then ' 1 = EXISTE UNA SOLICITUD DE CESE 
            '    MessageBox.Show("el empleado " & txtEmpleado.Text & " tiene una solicitud de cese pendiente " & dt1.Rows(0)("NUMEROSOLICITUDCESE"), "Advertencia Renuncia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Result = False
            'End If

            'Dim dt2 As DataTable = CeseDAO.ValidarSolicitudesCesesPorProcesar(RenunciasBE.IdSolicitante) 'si el empleado tiene una solicitud de cese pendiente de procesar
            'If dt2.Rows(0)("RESULT") = 1 Then ' 1 = EXISTE UNA SOLICITUD DE CESE POR PROCESAR 
            '    MessageBox.Show("el empleado " & txtEmpleado.Text & " tiene una solicitud de cese en espera de ser procesado " & dt2.Rows(0)("NUMEROSOLICITUDCESE"), "Advertencia Renuncia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Result = False
            'End If

            'Dim estadoempleado As String = BDAccionPersonalDAO.GetObtenerEstadoActualEmpleado(RenunciasBE.IdSolicitante) 'obtiene el estado actual del empleado cesado o activo  
            'If estadoempleado = 0 Then ' 0 = SE ENCUENTRA CESADO
            '    MessageBox.Show("el empleado" & txtEmpleado.Text & " se encuentra cesado", "Advertencia Renuncia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Result = False
            'End If
        End If
        Return Result
    End Function

    Private Sub RenunciaDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        If RenunciaDAO.IdRenuncia <> 0 Then
            RenunciasBE = RenunciaDAO.GetRenunciaByID(RenunciaDAO.IdRenuncia)
            With RenunciasBE
                'txtRazonComercial.Text = RenunciasBE.RazonComercial
                txtIdEmpleado.Text = .IdSolicitante
                txtEmpleado.Text = .EmpleadoNombre
                txtDni.Text = RenunciasBE.EmpleadoDni
                deFechaCese.EditValue = RenunciasBE.FechaUltimoDiaTrabajo
                txtCodigoUnico.Text = .CodigoUnico
                sleMotivoCese.EditValue = .CodigoCese
                txtObservacion.Text = .Observacion
                chkPagoDiasBoleta.EditValue = .PagoDiasBoleta
                dtFechaFinalContrato.EditValue = .FechaFinalContrato
                chkCambioRazonSocial.EditValue = .EstadoReingreso

                'dtFechaFinLaborar.EditValue = RenunciasBE.FechaUltimoDiaTrabajo
            End With
        End If

    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick
        If Validar() Then
            If MessageBox.Show("¿Está seguro de guardar las moficicaiones?", "Registro de Cese", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                RenunciaDAO.GuardarCartaRenunciaByID(RenunciasBE)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnAprobar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAprobar.ItemClick
        If Me.Validar() Then
            If RenunciaDAO.IdRenuncia <> 0 Then
                Dim mensajeCamboRazonSocial As String = ""
                Dim mensajerenuncia As String = ""
                'If CeseBE.ESTADOREINGRESO Then
                '    mensajerenuncia = "Esta seguro de procesar la renuncia por cambio de Razón Social?"
                'Else
                '    mensajerenuncia = "Desea registrar la renuncia del personal?"
                'End If
                If MessageBox.Show("Esta seguro de procesar la renuncia", "Registrar Renuncia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Cursor = Cursors.WaitCursor
                    'INSERTA RENUNCIA ADRYAN
                    If BDAccionPersonalDAO.RegistrarCeseAdryan(CeseBE) Then
                        'REGISTRA RENUNCIA CENTRAL
                        If Not RenunciaDAO.RegistrarCesePersonal(RenunciasBE) Then
                            MessageBox.Show("Error al registrar la renuncia del personal", "Error de Registro")
                            Cursor = Cursors.Default
                            Exit Sub
                        Else
                            MessageBox.Show("Registro de renuncia Exitoso", "Registro Renuncia")
                            Me.Close()
                        End If
                    Else
                        MessageBox.Show("Error en conexion con Adryan", "Error de Registro")
                    End If
                End If
                End If
        End If
    End Sub

    Private Sub btnAnular_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnular.ItemClick
        If MessageBox.Show("¿Está seguro de anular carta de renuncia?", "Anulación de Cese", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            RenunciaDAO.AnularCartaRenunciaByID(RenunciaDAO.IdRenuncia, BDCentralDAO.UsuarioBE.IDUsuario)
            Me.Close()
        End If
    End Sub

    Private Sub btnAdjuntarDocumento_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdjuntarDocumento.ItemClick

        OpenFileDialog1.InitialDirectory = "c:\"
        OpenFileDialog1.Filter = "Pdf |*.pdf"
        OpenFileDialog1.FilterIndex = 2
            OpenFileDialog1.RestoreDirectory = True

            Dim ruta As String
        Dim link As String

        ruta = "https://controlatenciones.blob.core.windows.net/renuncia/"

            Dim nameArchivo As String = ""

        Try
            If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Cursor = Cursors.WaitCursor

                Dim fechaArchivo As Date = Date.Now.Date
                Dim idlocal As Integer = 0

                nameArchivo = RenunciaDAO.IdRenuncia.ToString & "_" & "RH-R" & "_" & 0 & "_" & Format(fechaArchivo, "dd-MM-yyyy") & "_" & System.IO.Path.GetFileName(OpenFileDialog1.FileName)

                Dim storageAccount As CloudStorageAccount
                storageAccount = CloudStorageAccount.Parse(ConfigurationManager.AppSettings("StorageConnectionString"))

                'Se recupera el blob
                Dim blobClient As CloudBlobClient = storageAccount.CreateCloudBlobClient()

                'Se recupera el contenedor previamente creado en Azure
                Dim container As CloudBlobContainer = blobClient.GetContainerReference("renuncia")
                'Se recupera una referencia a un blob donde se guardara el archivo
                Dim blockBlob As CloudBlockBlob = container.GetBlockBlobReference(nameArchivo)

                link = ruta + nameArchivo

                'Se guarda el archivo en el blob
                blockBlob.UploadFromStream(OpenFileDialog1.OpenFile)

                If RenunciaDAO.InsertaCarataRenunciaFormato(RenunciaDAO.IdRenuncia, idlocal, nameArchivo, ruta, link) Then
                    MessageBox.Show("El Archivo se ha adjuntado correctamente.", "Adjuntar Archivo")
                    Cursor = Cursors.Default
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al adjuntar el archivo.", "Error de Conexión")
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnHistorialEmpleado_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHistorialEmpleado.ItemClick
        Dim idempleado = RenunciasBE.IdSolicitante
        BDAccionPersonalDAO.IdEmpleado = idempleado
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