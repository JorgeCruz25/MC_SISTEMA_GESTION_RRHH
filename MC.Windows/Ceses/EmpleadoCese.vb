Imports DevExpress.XtraEditors
Imports MC.Data
Imports MC.Framework

Public Class EmpleadoCese

    Dim bsEmpleados As New BindingSource
    Dim CeseBE As New CeseBE
    Dim EmpleadoBE As New EmpleadoBE

    Sub New()

        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        'ControlesDevExpress.InitRibbonControl(RibbonControl)

        'ControlesDevExpress.InitGridViewColumn(RepositoryItemGridLookUpEditEmpleadoView, "IDEMPLEADO", "IDEMPLEADO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(RepositoryItemGridLookUpEditEmpleadoView, "NOMBRES", "NOMBRES", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(RepositoryItemGridLookUpEditEmpleadoView, "APELLIDO PATERNO", "APELLIDOPATERNO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(RepositoryItemGridLookUpEditEmpleadoView, "APELLIDO MATERNO", "APELLIDOMATERNO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(RepositoryItemGridLookUpEditEmpleadoView, "N° DE IDENTIDAD", "DNI", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        'With RepositoryItemGridLookUpEditEmpleadoView
        '    .Columns("NOMBRES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '    .Columns("APELLIDOPATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '    .Columns("APELLIDOMATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '    .Columns("DNI").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        'End With

        'RepositoryItemGridLookUpEditEmpleado.DataSource = BDAccionPersonalDAO.GetEmpleadosAccionPersonalActivosList()

        'RepositoryItemGridLookUpEditEmpleado.ValueMember = "IDEMPLEADO"
        'RepositoryItemGridLookUpEditEmpleado.DisplayMember = "EMPLEADO"

        'RepositoryItemGridLookUpEditEmpleado.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

        CargarMotivoCese()
        LoadEntidad()

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

    Private Sub LoadEntidad()

        If CeseDAO.IdEmpleado <> 0 Then
            EmpleadoBE = BDAccionPersonalDAO.GetByEmpleadoID(CeseDAO.IdEmpleado)

            With EmpleadoBE
                txtIdEmpleado.Text = .IDEMPLEADO
                txtEmpleado.Text = .NOMBRES + " " + .APELLIDOPATERNO + " " + .APELLIDOMATERNO
                txtCodigoUnico.Text = .CODIGOUNICO
            End With
        End If
        If CeseDAO.IdSolicitudCese <> 0 Then
            CeseBE = CeseDAO.GetEmpleadoCeseID(CeseDAO.IdSolicitudCese)
            With CeseBE
                txtIdEmpleado.Text = .IDEMPLEADO
                txtCodigoUnico.Text = .CODIGOUNICO
                deFechaCese.EditValue = .FECHACESE
                txtEmpleado.Text = .EMPLEADONOMBRE

                If CeseBE.FECHARECOJODOCUMENTO = "01/01/1900" Then
                    dtFechaRecojoDocumento.EditValue = Date.Now.Date
                Else
                    dtFechaRecojoDocumento.EditValue = CeseBE.FECHARECOJODOCUMENTO
                End If
            End With
        End If
    End Sub

    'Private Sub RepositoryItemGridLookUpEditEmpleado_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemGridLookUpEditEmpleado.EditValueChanged
    '    Dim editor As GridLookUpEdit = TryCast(sender, GridLookUpEdit)
    '    Dim id As Object = editor.Properties.View.GetFocusedRowCellValue("IDEMPLEADO")

    '    BDAccionPersonalDAO.IdEmpleado = id
    '    LoadEntidad()
    'End Sub
    Private Function Validar() As Boolean
        Dim Result As Boolean = True

        DxErrorProvider1.ClearErrors()

        If sleMotivoCese.EditValue Is Nothing Or sleMotivoCese.EditValue = 0 Then
            DxErrorProvider1.SetError(sleMotivoCese, "Dato obligatorio")
            Result = False
        End If
        If deFechaCese.EditValue Is Nothing Or deFechaCese.Text = "" Then
            DxErrorProvider1.SetError(deFechaCese, "Dato obligatorio")
            Result = False
        End If
        If txtCodigoUnico.Text = "" Then
            DxErrorProvider1.SetError(txtCodigoUnico, "Dato obligatorio")
            Result = False
        End If
        If CeseDAO.Renovacion = 0 Then
            Dim dtrenovacion As DataTable
            dtrenovacion = RenunciaDAO.GetEmpleadoAsignadoEnRenovacion(CeseBE.IDEMPLEADO)
            If dtrenovacion.Rows.Count > 0 Then
                MessageBox.Show("El colaborador " & dtrenovacion.Rows(0).Item("EMPLEADONOMBRE") & " se encuentra en el listado de renovaciòn de contrado con fecha" & dtrenovacion.Rows(0).Item("FECHAFINALCONTRATO") & ", por favor eliminar su renovaciòn para poder proceder con el Cese", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Result = False
            End If
        End If


        If Result Then
            With CeseBE
                .IDEMPLEADO = CeseBE.IDEMPLEADO
                .CODIGOUNICO = txtCodigoUnico.Text
                .IDSOLICITUDCESE = CeseDAO.IdSolicitudCese
                .CODIGOCESE = sleMotivoCese.EditValue
                .OBSERVACION = txtObservacion.Text
                .FECHACESE = deFechaCese.Text
                .PAGODIASBOLETA = chkPagoDiasBoleta.EditValue
                .IDUSUARIOREGISTRO = BDCentralDAO.UsuarioBE.IDUsuario
                .USUARIOREGISTRO = BDCentralDAO.UsuarioBE.Usuario
            End With
            '-----------------
            'NO BORRAR ESTO SI VA ----- VALIDA SI HAY SOLICITUDES PENDIENTES O RENUNCIAS PENDIENTES
            'Dim dt1 As DataTable = RenunciaDAO.ValidarCartaRenunciasPendientes(CeseBE.IDEMPLEADO) 'si el empleado tiene una solicitud de cese pendiente       
            'If dt1.Rows(0)("RESULT") = 1 Then ' 1 = EXISTE UNA SOLICITUD DE CESE 
            '    MessageBox.Show("El empleado " & txtEmpleado.Text & " tiene una solicitud de renuncia pendiente " & dt1.Rows(0)("NUMEROCARTA"), "Advertencia Renuncia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Result = False
            'End If

            'Dim dt2 As DataTable = RenunciaDAO.ValidarSolicitudesRenunciaPorProcesar(CeseBE.IDEMPLEADO) 'si el empleado tiene una solicitud de cese pendiente de procesar
            'If dt2.Rows(0)("RESULT") = 1 Then ' 1 = EXISTE UNA SOLICITUD DE CESE POR PROCESAR 
            '    MessageBox.Show("El empleado " & txtEmpleado.Text & " tiene una solicitud de renuncia en espera de ser procesado " & dt2.Rows(0)("NUMEROCARTA"), "Advertencia Renuncia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Result = False
            'End If

            'Dim estadoempleado As String = BDAccionPersonalDAO.GetObtenerEstadoActualEmpleado(CeseBE.IDEMPLEADO) 'obtiene el estado actual del empleado cesado o activo  
            'If estadoempleado = 0 Then ' 0 = SE ENCUENTRA CESADO
            '    MessageBox.Show("El empleado" & txtEmpleado.Text & " se encuentra cesado", "Advertencia Renuncia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Result = False
            'End If
        End If
        Return Result

    End Function

    Private Sub btnRegistrarCese_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRegistrarCese.ItemClick

        If Me.Validar() Then
            If MessageBox.Show("Desea registrar el cese del personal?", "Registrar Cese", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Cursor = Cursors.WaitCursor

                'INSERTA CESE ADRYAN
                If BDAccionPersonalDAO.RegistrarCeseAdryan(CeseBE) Then
                    'REGISTRA CESE MC_CENTRAL               
                    If Not CeseDAO.RegistrarCesePersonal(CeseBE) Then
                        MessageBox.Show("Error al registrar el cese del personal", "Error de Registro")
                        Cursor = Cursors.Default
                        Exit Sub
                    Else
                        MessageBox.Show("Registro de renuncia Exitoso", "Registro Renuncia")
                        Me.Close()
                    End If
                Else
                    MessageBox.Show("Problemas de Conexión con el sistema Adryan", "Error de Conexión")
                    Cursor = Cursors.Default
                    Exit Sub
                End If
            End If
            End If
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub
    Private Function ValidarEnvioDocumento() As Boolean
        Dim Result As Boolean = True

        DxErrorProvider1.ClearErrors()

        If dtFechaRecojoDocumento.EditValue Is Nothing Or deFechaCese.Text = "" Then
            DxErrorProvider1.SetError(dtFechaRecojoDocumento, "Dato obligatorio")
            Result = False
        End If

        If Result Then
            With CeseBE
                .FechaRecojoDocumento = dtFechaRecojoDocumento.EditValue
            End With
        End If
        Return Result
    End Function

    Private Sub btnValidar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnValidar.ItemClick
        If ValidarEnvioDocumento() Then
            If MessageBox.Show("¿Está seguro de validar la solicitud de cese?", "Validar Solicitud", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                If CeseDAO.ValidarSolicitudCeseNoLegal(CeseDAO.IdSolicitudCese, dtFechaRecojoDocumento.EditValue) Then
                    Me.Close()
                Else
                    MessageBox.Show("Error al validar el cese del personal", "Validación Cese")
                End If
            End If
        End If
    End Sub

    Private Sub btnAnular_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnular.ItemClick
        If MessageBox.Show("¿Está seguro de anular la solicitud de cese?", "Anular Solicitud", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
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
    End Sub

    Private Sub btnHistorialEmpleado_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHistorialEmpleado.ItemClick
        BDAccionPersonalDAO.IdEmpleado = CeseDAO.IdEmpleado
        Dim MiForm As New EmpleadoHistorial

        MiForm.ShowDialog()
    End Sub
End Class