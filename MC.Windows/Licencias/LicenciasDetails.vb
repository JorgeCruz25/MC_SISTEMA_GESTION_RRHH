Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Controls
Imports MC.Data
Imports MC.Framework
Public Class LicenciasDetails
    Private LicenciasBE As LicenciasBE

    Sub New()

        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDLICENCIA", "IDLICENCIA", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO SOLICITUD", "NUMEROSOLICITUD", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA SOLICITUD", "FECHA", 120, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO LICENCIA", "LICENCIATIPO", 170, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DESDE", "FECHAPERIODOINICIO", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "HASTA", "FECHAPERIODOFIN", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CANTIDAD DIAS", "CANTIDADDIAS", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "IDDESCARGO", "IDSUSTENTOARCHIVO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        ControlesDevExpress.InitGridViewColumn(GridView2, "ID", "IDMEMORANDUM", 10, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "NUMEROINFORME", "NUMEROINFORME", 20, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "RAZON SOCIAL", "RAZONSOCIAL", 30, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "FECHA", "FECHA", 20, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "NIVEL FALTA", "NIVELFALTA", 20, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "FALTA", "FALTA", 20, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "DECRIPCIÓN MEMORANDUM", "MEMORANDUMDESCRIPCION", 20, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)


        ControlesDevExpress.InitGridViewColumn(GridView3, "ID", "IDPRESTAMO", 10, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView3, "NUMERO SOLICITUD", "NUMEROSOLICITUD", 30, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView3, "RAZON SOCIAL", "RAZONSOCIAL", 45, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView3, "FECHA", "FECHA", 20, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView3, "MON. SOLICITADO", "MONTO", 25, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView3, "MON. APROBADO", "MONTOAPROBADO", 25, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView3, "MEDIO PAGO", "MEDIOPAGO", 25, True, ControlesDevExpress.eGridViewFormato.Checked, True)


        GridView3.Columns("MONTO").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        GridView3.Columns("MONTOAPROBADO").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far

        With GridView1
            .Columns("FECHA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("LICENCIATIPO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAPERIODOINICIO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAPERIODOFIN").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CANTIDADDIAS").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        ControlesDevExpress.InitGridViewColumn(GridViewTipoLicencia, "ID", "IDLICENCIATIPO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewTipoLicencia, "DESCRIPCION", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewTipoLicencia
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
    End Sub

    Private Sub HistorialLicencia(ByVal IDEMPLEADO As Int32)
        GridControl1.DataSource = LicenciaDAO.GetListarLicenciaEmpleado(IDEMPLEADO)
    End Sub
    Private Sub HistorialMemorandum(ByVal IDEMPLEADO As Int32)
        GridControl2.DataSource = PrestamoDAO.GetHistorialMemorandumByID(IDEMPLEADO)
    End Sub

    Private Sub HistorialPrestamos(ByVal IDEMPLEADO As Int32)
        GridControl3.DataSource = PrestamoDAO.GetHistorialPrestamosByID(IDEMPLEADO)
    End Sub
    Private Sub ListarTipoLicencia()
        sleTipoLicencia.Properties.DataSource = LicenciaDAO.GetListarTipoLicencia()
        sleTipoLicencia.Properties.DisplayMember = "DESCRIPCION"
        sleTipoLicencia.Properties.ValueMember = "IDLICENCIATIPO"
        sleTipoLicencia.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Function validar() As Boolean
        DxErrorProvider1.ClearErrors()
        Dim Result As Boolean = True

        If LicenciaDAO.IdTipoLicencia <> 1 Then
            With LicenciasBE
                .IdLicencia = LicenciaDAO.IdLicencia
                .FechaPeriodoInicio = dtFechaInicio.EditValue
                .FechaPeriodoFin = dtFechaFin.EditValue
                .IdLicenciaTipo = sleTipoLicencia.EditValue
                '.IdGrupoEnfermedad = sleGrupoEnfermedades.EditValue
                '.IdSubGrupoEnfermedad = sleSubGrupoEnfermedades.EditValue
            End With
        Else
            With LicenciasBE
                .IdLicencia = LicenciaDAO.IdLicencia
                .FechaPeriodoInicio = dtFechaInicio.EditValue
                .FechaPeriodoFin = dtFechaFin.EditValue
            End With
        End If
        Return Result
    End Function

    Private Sub SolicitudLicenciasDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LicenciaDAO.IdLicencia <> 0 Then
            ListarTipoLicencia()

            LicenciasBE = LicenciaDAO.GetLicenciaByID(LicenciaDAO.IdLicencia)
            With LicenciasBE
                txtFecha.Text = LicenciasBE.Fecha
                txtRazonComercial.Text = LicenciasBE.RazonComercial
                txtRazonSocial.Text = LicenciasBE.RazonSocial
                txtFechaIngreso.Text = LicenciasBE.FechaIngreso
                txtCantidadDias.Text = LicenciasBE.CandidadDias
                txtEmpleado.Text = LicenciasBE.NombreEmpleado
                txtDni.Text = LicenciasBE.Dni
                txtCargo.Text = LicenciasBE.Cargo
                txtDescripcion.Text = LicenciasBE.Descripcion
                dtFechaInicio.EditValue = LicenciasBE.FechaPeriodoInicio
                dtFechaFin.EditValue = LicenciasBE.FechaPeriodoFin
                'sleGrupoEnfermedades.EditValue = LicenciasBE.IdGrupoEnfermedad
                'sleSubGrupoEnfermedades.EditValue = LicenciasBE.IdSubGrupoEnfermedad
                txtNumeroTelefonico.Text = LicenciasBE.Telefon
                sleTipoLicencia.EditValue = LicenciasBE.IdLicenciaTipo
            End With
            HistorialLicencia(LicenciasBE.IdSolicitante)
            HistorialMemorandum(LicenciasBE.IdSolicitante)
            HistorialPrestamos(LicenciasBE.IdSolicitante)

        End If
    End Sub
    'Private Sub btnAprobar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAprobar.ItemClick
    '    If dtFechaInicio.EditValue <= dtFechaFin.EditValue Then
    '        Dim dt As New DataTable
    '        If LicenciaDAO.IdTipoLicencia <> 1 Then
    '            dt = LicenciaDAO.ListaLicenciaArchivos(LicenciaDAO.IdLicencia)
    '            If dt.Rows.Count <> 0 Then
    '                If validar() Then
    '                    If MessageBox.Show("¿Está seguro de aprobar licencia?", "Aprobar Licencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
    '                        If LicenciaDAO.AccionLicenciaByID(LicenciasBE, 3, BDCentralDAO.UsuarioBE.IDUsuario) Then
    '                            Me.Close()
    '                        Else
    '                            MessageBox.Show("Error al aprobar licencia")
    '                        End If
    '                    End If
    '                End If
    '            Else
    '                MessageBox.Show("Falta adjuntar el archivo de sustento", "Aprobar Licencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            End If
    '        Else

    '            dt = LicenciaDAO.ListaLicenciaAcuerdoArchivos(LicenciaDAO.IdLicencia)
    '            If dt.Rows.Count <> 0 Then
    '                If validar() Then
    '                    If MessageBox.Show("¿Está seguro de aprobar licencia?", "Aprobar Licencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
    '                        If LicenciaDAO.AccionLicenciaByID(LicenciasBE, 3, BDCentralDAO.UsuarioBE.IDUsuario) Then
    '                            Me.Close()
    '                        Else
    '                            MessageBox.Show("Error al aprobar licencia")
    '                        End If
    '                    End If
    '                End If
    '            Else
    '                MessageBox.Show("Falta adjuntar el acta de compromiso", "Aprobar Licencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            End If

    '        End If
    '    Else
    '        MessageBox.Show("La fecha de inicio no puede se mayor a la fecha de fin", "Advetencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    End If
    'End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    'Private Sub btnAnular_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAnular.ItemClick
    '    If MessageBox.Show("¿Está seguro de anular la licencia?", "Anular licencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
    '        If LicenciaDAO.AnularLicenciaRRHH(LicenciaDAO.IdLicencia, BDCentralDAO.UsuarioBE.IDUsuario) Then
    '            Me.Close()
    '        Else
    '            MessageBox.Show("Error al anular")
    '        End If
    '    End If
    'End Sub

    'Private Sub btnGuardar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnGuardar.ItemClick
    '    If dtFechaInicio.EditValue <= dtFechaFin.EditValue Then
    '        If validar() Then
    '            If MessageBox.Show("¿Está seguro de guardar las modificaciones?", "Guardar modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
    '                If LicenciaDAO.AccionLicenciaByID(LicenciasBE, 1, BDCentralDAO.UsuarioBE.IDUsuario) Then
    '                    Me.Close()
    '                Else
    '                    MessageBox.Show("Error al anular")
    '                End If
    '            End If
    '        End If
    '    Else
    '        MessageBox.Show("La fecha de inicio no puede se mayor a la fecha de fin", "Advetencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    End If
    'End Sub

    'Private Sub btnRevisado_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnRevisado.ItemClick
    '    If dtFechaInicio.EditValue <= dtFechaFin Then
    '        If validar() Then
    '            If MessageBox.Show("¿Está seguro de haber registrado licencia?", "registro Licencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
    '                If LicenciaDAO.RegistradoLicenciaByID(LicenciaDAO.IdLicencia) Then
    '                    Me.Close()
    '                Else
    '                    MessageBox.Show("Error al validar")
    '                End If
    '            End If
    '        End If
    '    Else
    '        MessageBox.Show("La fecha de inicio no puede se mayor a la fecha de fin", "Advetencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    End If
    'End Sub

    Private Sub btnValidar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnValidar.ItemClick
        If dtFechaInicio.EditValue <= dtFechaFin.EditValue Then
            If validar() Then
                If MessageBox.Show("¿Está seguro de guardar las modificaciones?", "Guardar modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                    If LicenciaDAO.AccionLicenciaByID(LicenciasBE.IdLicencia, BDCentralDAO.UsuarioBE.IDUsuario) Then
                        Me.Close()
                    Else
                        MessageBox.Show("Error al anular")
                    End If
                End If
            End If
        Else
            MessageBox.Show("La fecha de inicio no puede se mayor a la fecha de fin", "Advetencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHistorialEmpleado_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnHistorialEmpleado.ItemClick

        BDAccionPersonalDAO.IdEmpleado = LicenciasBE.IdSolicitante
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

    Private Sub btnDesprocesarValidado_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnDesprocesarValidado.ItemClick
        If MessageBox.Show("Esta seguro de deprocesar validado de la solicitud del " & LicenciasBE.NombreEmpleado, "Desprocesar Validado", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            If LicenciaDAO.DesprocesarValidadoSolicitudLicencia(LicenciaDAO.IdLicencia) Then
                Dim dtenviocorreo As DataTable
                dtenviocorreo = LicenciaDAO.LicenciaEnvioCorreo(LicenciaDAO.IdLicencia)
                If dtenviocorreo.Rows.Count > 0 Then
                    Dim nroformato As String = dtenviocorreo.Rows(0)("NUMEROSOLICITUD")
                    Dim tienda As String = dtenviocorreo.Rows(0)("RAZONCOMERCIAL")
                    Dim empleado As String = dtenviocorreo.Rows(0)("EMPLEADOBENEFICIO")
                    Dim empleadonumerodocumento As String = dtenviocorreo.Rows(0)("NUMERODOCUMENTO")
                    Dim correodestinatario As String = dtenviocorreo.Rows(0)("CORREO")

                    Dim emailTo As String
                    emailTo = correodestinatario

                    Dim Mensaje As String
                    Mensaje = "<font face=Calibri size=3>" & "Estinado colaborador del local de: " & tienda & " Se comunica que se a des procesado el validado de la solicud de Licencia número " & nroformato & " en referencia al Señor(a)  " & empleado &
        " con número de documento:  " & empleadonumerodocumento
                    BDCentralDAO.InsertEnvioCorreo(emailTo, " Licencia: " + nroformato, Mensaje)
                End If
                MessageBox.Show("Desproceso de validado existoso", "Desproceso Validado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Error al desprocesar validado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
End Class