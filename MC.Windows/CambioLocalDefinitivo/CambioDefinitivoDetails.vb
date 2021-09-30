Imports System.ComponentModel
Imports MC.Data
Imports MC.Framework
Public Class CambioDefinitivoDetails
    Dim fechaingreso As String
    Dim fechafinal As String
    Dim horaingreso As String
    Dim horafinal As String
    Dim codigounico As String
    Dim tiporeingreso As Int32
    Dim fechareingresocompania As Date
    Dim idlocal As Int32
    Dim CambioLocalDefinitivoBE As New CambioLocalDefinitivoBE
    Dim EmpleadoCeseBE As New EmpleadoCeseBE
    Dim CeseBE As New CeseBE
    Dim EmpleadoBE As New EmpleadoBE
    Dim EmpleadoMovimientoBE As New EmpleadoMovimientoBE

    Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterParent
        ListarNuevoCargo()
        ListarNuevoLocal()
        ListarNuevoContrato()
        CargarMoneda()
        CargarTipoEmpleado()
        CargarRegimenSalarial()

    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub
    Private Sub CambioDefinitivoDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        chkCambioRazonSocial.Enabled = False
        If CambioLocalDefinitivoDAO.IdCambioDefinitivo <> 0 Then

            CambioLocalDefinitivoBE = CambioLocalDefinitivoDAO.GetCambioDefinitivoByID(CambioLocalDefinitivoDAO.IdCambioDefinitivo)
            Dim dtSolicitudRenuncias As DataTable
            dtSolicitudRenuncias = CambioLocalDefinitivoDAO.ListarSolitudesRenunciasCambiosDefinitivos(CambioLocalDefinitivoBE.IDEMPLEADO)
            If dtSolicitudRenuncias.Rows.Count = 0 Then
                sleSolicitudRenuncia.Enabled = False
            Else
                CargarSolicitudesRenuncia()
            End If
            rboIndicadorSi.Checked = True
            If rboIndicadorSi.Checked Then
                deFechaFinContrato.Visible = False
                lblFechaFinalContrato.Visible = False
            Else
                deFechaFinContrato.Visible = True
                lblFechaFinalContrato.Visible = True
            End If
            With CambioLocalDefinitivoBE
                txtSolicitante.Text = .SOLICITANTENOMBRE
                txtEmpleado.Text = .EMPLEADONOMBRE
                txtLocalOrigen.Text = .RAZONCOMERCIAL
                txtDniEmpleado.Text = .EMPLEADODNI
                txtCargoActual.Text = .EMPLEADOCARGO
                dtFechaCambio.EditValue = .FECHACAMBIO
                teInicio.EditValue = .HORAINGRESO
                teFinal.EditValue = .HORAFIN
                txtActualTipoContrato.Text = .TIPOCONTRATOACTUAL
                If .FECHAINGRESO = "01/01/1900" Or .FECHAINGRESO = "" Then
                    dtFechaInicio.EditValue = Date.Now.Date
                Else
                    dtFechaInicio.EditValue = .FECHAINGRESO
                End If
                If .FECHAFIN = "01/01/1900" Or .FECHAFIN = "" Then
                    dtFechaFinal.EditValue = Date.Now.Date
                Else
                    dtFechaFinal.EditValue = .FECHAFIN
                End If
                sleNuevoCargo.EditValue = .IDNUEVOCARGO
                sleNuevoContrato.EditValue = .IDNUEVOTIPOCONTRATO
                sleOrganigramDestino.EditValue = .IDORGANIGRAMADESTINO
                txtNuevoContrato.Text = .NUEVOTIPOCONTRATO
                txtNuevoCargo.Text = .NUEVOCARGO
                txtLocalDestino.Text = .NUEVOLOCAL
                txtIdEmpleado.Text = .IDEMPLEADO
                txtCodigoUnico.Text = .CODIGOUNICO
                txtTipoCambio.Text = .TIPOCAMBIODEFINITIVO
            End With
            txtSolicitante.Enabled = False
            txtLocalOrigen.Enabled = False
            If CambioLocalDefinitivoDAO.FormatoEnvioCorreoSitio <> 1 Then
                gcEnvioCorreo.Visible = False
                btnGuardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
        End If
    End Sub
    Private Function ValidarReingrsoRazonSocial() As Boolean
        DxErrorProvider1.ClearErrors()
        Dim Result As Boolean = True
        tiporeingreso = 1
        Dim fechafinalcese As Date
        fechafinalcese = GridViewSolicitudRenuncia.GetFocusedRowCellValue("FECHAULTIMODIATRABAJO")
        fechareingresocompania = fechafinalcese.AddDays(1)
        If fechareingresocompania.Day <> 28 Then
            MessageBox.Show("La fecha de reingreso a la nueva razon social el dia 28", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        If rboIndicadorNo.Checked Then
            If deFechaFinContrato.EditValue Is Nothing Then
                DxErrorProvider1.SetError(deFechaFinContrato, "Dato obligatorio")
                Result = False
            End If
        End If
        If sleSolicitudRenuncia.EditValue Is Nothing Then
            DxErrorProvider1.SetError(sleSolicitudRenuncia, "Dato obligatorio")
            Result = False
        End If

        If sleRegimenSalarial.EditValue Is Nothing Then
            DxErrorProvider1.SetError(sleRegimenSalarial, "Dato obligatorio")
            Result = False
        End If
        If txtSueldo.Text = "" Then
            DxErrorProvider1.SetError(txtSueldo, "Dato obligatorio")
            Result = False
        End If
        If sleMoneda.Text = "" Then
            DxErrorProvider1.SetError(txtSueldo, "Dato obligatorio")
            Result = False
        End If
        If sleOrganigramDestino.EditValue Is Nothing Or sleOrganigramDestino.Text = "" Then
            DxErrorProvider1.SetError(sleOrganigramDestino, "Dato obligatorio")
            Result = False
        End If
        If sleNuevoCargo.EditValue Is Nothing Or sleNuevoCargo.Text = "" Then
            DxErrorProvider1.SetError(sleNuevoCargo, "Dato obligatorio")
            Result = False
        End If
        If sleMoneda.EditValue Is Nothing Then
            DxErrorProvider1.SetError(sleMoneda, "Dato obligatorio")
            Result = False
        End If
        If sleNuevoContrato.EditValue Is Nothing Or sleNuevoContrato.Text = "" Then
            DxErrorProvider1.SetError(sleNuevoContrato, "Dato obligatorio")
            Result = False
        End If
        If sleSolicitudRenuncia.EditValue Is Nothing Or sleSolicitudRenuncia.Text = "" Then
            MessageBox.Show("Seleccione la solicitud de renuncia vinculado")
            Result = False
        End If
        If Result Then
            ObtenerDatos()
        End If
        Return Result
    End Function
    Private Function ValidarReingreso() As Boolean

        DxErrorProvider1.ClearErrors()
        Dim Result As Boolean = True
        tiporeingreso = 2
        If sleTipoEmpleado.EditValue Is Nothing Then
            DxErrorProvider1.SetError(sleTipoEmpleado, "Dato obligatorio")
            Result = False
        End If
        If deFechaIngresoCompania.EditValue Is Nothing Then
            DxErrorProvider1.SetError(deFechaIngresoCompania, "Dato obligatorio")
            Result = False
        End If
        If rboIndicadorNo.Checked Then
            If deFechaFinContrato.EditValue Is Nothing Then
                DxErrorProvider1.SetError(deFechaFinContrato, "Dato obligatorio")
                Result = False
            End If
        End If
        If sleRegimenSalarial.EditValue Is Nothing Then
            DxErrorProvider1.SetError(sleRegimenSalarial, "Dato obligatorio")
            Result = False
        End If
        If txtSueldo.Text = "" Then
            DxErrorProvider1.SetError(txtSueldo, "Dato obligatorio")
            Result = False
        End If
        If sleMoneda.Text = "" Then
            DxErrorProvider1.SetError(txtSueldo, "Dato obligatorio")
            Result = False
        End If
        If sleOrganigramDestino.EditValue Is Nothing Or sleOrganigramDestino.Text = "" Then
            DxErrorProvider1.SetError(sleOrganigramDestino, "Dato obligatorio")
            Result = False
        End If
        If sleNuevoCargo.EditValue Is Nothing Or sleNuevoCargo.Text = "" Then
            DxErrorProvider1.SetError(sleNuevoCargo, "Dato obligatorio")
            Result = False
        End If
        If sleMoneda.EditValue Is Nothing Then
            DxErrorProvider1.SetError(sleMoneda, "Dato obligatorio")
            Result = False
        End If
        If sleNuevoContrato.EditValue Is Nothing Or sleNuevoContrato.Text = "" Then
            DxErrorProvider1.SetError(sleNuevoContrato, "Dato obligatorio")
            Result = False
        End If
        If deFechaIngresoCompania.EditValue > deFechaFinContrato.EditValue Then
            MessageBox.Show("La fecha de reingreso corporativo no puede ser mayor a la fecha fin de contrato")
            Result = False
        End If
        If sleSolicitudRenuncia.EditValue Is Nothing Or sleSolicitudRenuncia.Text = "" Then
            MessageBox.Show("Seleccione la solicitud de renuncia vinculado")
            Result = False
        End If
        If Result Then
            ObtenerDatos()
        End If
        Return Result
    End Function
    Private Sub ObtenerDatos()
        Dim dtEmpleadoAdryan As New DataTable
        dtEmpleadoAdryan = BDAccionPersonalDAO.GetEmpleadoCargarDatosAdicionales(CambioLocalDefinitivoBE.IDTIPODOCUMENTOIDENTIDAD, sleNuevoCargo.EditValue, sleOrganigramDestino.EditValue, CambioLocalDefinitivoBE.IDDISTRITO)
        With EmpleadoBE
            .IDEMPLEADO = txtIdEmpleado.Text
            .IDORGANIGRAMA = sleOrganigramDestino.EditValue
            .IDCARGO = sleNuevoCargo.EditValue
            .TIPOCONTRATO = sleNuevoContrato.EditValue
            If rboIndicadorSi.Checked Then
                .INDICADORINDETERMINADO = "1"
            Else
                .INDICADORINDETERMINADO = "0"
            End If
            If tiporeingreso = 1 Then 'Cambio de contrato (esto viene de la funcion ValidarReingreso)
                .FECHAINGRESOCOMPANIA = fechareingresocompania
            Else  'cambio de Razon Social (esto viene de la funcion ValidarReingrsoRazonSocial)2
                .FECHAINGRESOCOMPANIA = deFechaIngresoCompania.Text
            End If
            .SUELDO = Convert.ToDouble(txtSueldo.Text)
            .FECHAFINALCONTRATO = deFechaFinContrato.Text
            .SUELDOMONEDA = sleMoneda.EditValue
            .IDREGIMENSALARIAL = sleRegimenSalarial.EditValue
            .CODIGOUNICO = txtCodigoUnico.Text
            .CODIGOTIPOEMPLEADO = sleTipoEmpleado.EditValue
            .IDLOCAL = dtEmpleadoAdryan.Rows(0)("IDLOCAL")
            .ADRYAN_PUESTO_ORGANICA = dtEmpleadoAdryan.Rows(0)("PUESTOORGANICA")
            .ADRYAN_UNIDAD_FUNCIONAL = dtEmpleadoAdryan.Rows(0)("UNIDADFUNCIONAL")
            .ADRYAN_GRADOSALARIAL = dtEmpleadoAdryan.Rows(0)("GRADOSALARIAL")
            .IDUSUARIOREGISTRO = BDCentralDAO.UsuarioBE.IDUsuario
            .USUARIOREGISTRO = BDCentralDAO.UsuarioBE.Usuario
        End With
    End Sub
    Private Function Validar() As Boolean

        DxErrorProvider1.ClearErrors()
        Dim Result As Boolean = True

        If dtFechaInicio.EditValue Is Nothing Then
            DxErrorProvider1.SetError(dtFechaInicio, "Dato obligatorio")
            Result = False
        End If
        If dtFechaFinal.EditValue Is Nothing Then
            DxErrorProvider1.SetError(dtFechaFinal, "Dato obligatorio")
            Result = False
        End If
        If teInicio.Text = "" Then
            DxErrorProvider1.SetError(teInicio, "Dato obligatorio")
        End If
        If teFinal.Text = "" Then
            DxErrorProvider1.SetError(teFinal, "Dato obligatorio")
            Result = False
        End If
        If dtFechaInicio.EditValue > dtFechaFinal.EditValue Then
            DxErrorProvider1.SetError(dtFechaInicio, "la fecha de inicio no puede ser mayor a la fecha final")
            Result = False
        End If

        With CambioLocalDefinitivoBE
            teInicio.Text = TimeOfDay.UtcNow.ToString("h:mm:ss tt")
            'teInicio.Text = TimeOfDay.Now.Hour.ToString() + ":" + TimeOfDay.Now.Minute.ToString() + ":" + TimeOfDay.Now.Second.ToString() + " " + TimeOfDay.Now.Millisecond.ToString()
            teFinal.Text = TimeOfDay.UtcNow.ToString("h:mm:ss tt")
            'teFinal.Text = TimeOfDay.Now.Hour.ToString() + ":" + TimeOfDay.Now.Minute.ToString() + ":" + TimeOfDay.Now.Second.ToString() + " " + TimeOfDay.Now.Millisecond.ToString()
            .IDFORMATOCAMBIO = CambioLocalDefinitivoDAO.IdCambioDefinitivo
            fechaingreso = dtFechaInicio.EditValue
            fechafinal = dtFechaFinal.EditValue
            horaingreso = teInicio.Text
            horafinal = teFinal.Text
            '.IDNUEVOCARGO = sleNuevoCargo.EditValue
        End With
        Return Result
    End Function
    Private Sub ListarNuevoContrato()
        ControlesDevExpress.InitGridViewColumn(GridViewNuevoContrato, "ID", "TIPOCONTRATO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewNuevoContrato, "CONTRATO", "DESCRIPCION", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewNuevoContrato
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        sleNuevoContrato.Properties.DataSource = CambioLocalDefinitivoDAO.GetListarNuevoContrato()
        sleNuevoContrato.Properties.DisplayMember = "DESCRIPCION"
        sleNuevoContrato.Properties.ValueMember = "TIPOCONTRATO"
        sleNuevoContrato.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub ListarNuevoLocal()
        ControlesDevExpress.InitGridViewColumn(GridViewNuevoLocal, "IDORGANIGRAMA", "IDORGANIGRAMA", 100, False, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridViewNuevoLocal, "NOMBRE", "NOMBRE", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewNuevoLocal, "RAZON SOCIAL", "RAZONSOCIAL", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridViewNuevoLocal, "RAZON COMERCIAL", "RAZONCOMERCIAL", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewNuevoLocal
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOMBRE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            '.Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        sleOrganigramDestino.Properties.DataSource = CambioLocalDefinitivoDAO.GetListarNuevoLocal()
        sleOrganigramDestino.Properties.DisplayMember = "NOMBRE"
        sleOrganigramDestino.Properties.ValueMember = "IDORGANIGRAMA"
        sleOrganigramDestino.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub ListarNuevoCargo()
        ControlesDevExpress.InitGridViewColumn(GridViewNuevoCargo, "ID", "IDCARGO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewNuevoCargo, "CARGO", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewNuevoCargo
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        sleNuevoCargo.Properties.DataSource = CambioLocalDefinitivoDAO.GetListarCargosIDLocal(CambioLocalDefinitivoDAO.IdLocal)
        sleNuevoCargo.Properties.DisplayMember = "DESCRIPCION"
        sleNuevoCargo.Properties.ValueMember = "IDCARGO"
        sleNuevoCargo.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarMoneda()
        ControlesDevExpress.InitGridViewColumn(GridViewMoneda, "ID", "CODIGO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewMoneda, "DESCRIPCION", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewMoneda
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        sleMoneda.Properties.DataSource = BDAccionPersonalDAO.GetMonedaList
        sleMoneda.Properties.DisplayMember = "DESCRIPCION"
        sleMoneda.Properties.ValueMember = "CODIGO"
        sleMoneda.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarTipoEmpleado()
        ControlesDevExpress.InitGridViewColumn(GridViewTipoEmpleado, "ID", "CODIGOTIPOEMPLEADO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewTipoEmpleado, "TIPO EMPLEADO", "TIPOEMPLEADO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewTipoEmpleado
            .Columns("TIPOEMPLEADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleTipoEmpleado.Properties.DataSource = BDAccionPersonalDAO.GetTipoEmpleadoList
        sleTipoEmpleado.Properties.DisplayMember = "TIPOEMPLEADO"
        sleTipoEmpleado.Properties.ValueMember = "CODIGOTIPOEMPLEADO"
        sleTipoEmpleado.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarRegimenSalarial()
        ControlesDevExpress.InitGridViewColumn(GridViewRegimenSalarial, "ID", "IDREGIMEN", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewRegimenSalarial, "DESCRIPCION", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewRegimenSalarial
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        sleRegimenSalarial.Properties.DataSource = BDAccionPersonalDAO.GetRegimenSalarialList
        sleRegimenSalarial.Properties.DisplayMember = "DESCRIPCION"
        sleRegimenSalarial.Properties.ValueMember = "IDREGIMEN"
        sleRegimenSalarial.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarSolicitudesRenuncia()
        ControlesDevExpress.InitGridViewColumn(GridViewSolicitudRenuncia, "ID RENUNCIA", "IDRENUNCIA", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewSolicitudRenuncia, "NUMERO CARTA", "NUMEROCARTA", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewSolicitudRenuncia, "FECHA SOLICITUD", "FECHA", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewSolicitudRenuncia, "FECHA FINAL LABORAL", "FECHAULTIMODIATRABAJO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewSolicitudRenuncia, "REINGRESO", "REINGRESO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewSolicitudRenuncia, "ESTADOREINGRESO", "ESTADOREINGRESO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewSolicitudRenuncia
            .Columns("NUMEROCARTA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAULTIMODIATRABAJO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("ESTADOREINGRESO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        sleSolicitudRenuncia.Properties.DataSource = CambioLocalDefinitivoDAO.ListarSolitudesRenunciasCambiosDefinitivos(CambioLocalDefinitivoBE.IDEMPLEADO)
        sleSolicitudRenuncia.Properties.DisplayMember = "NUMEROCARTA"
        sleSolicitudRenuncia.Properties.ValueMember = "IDRENUNCIA"
        sleSolicitudRenuncia.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub btnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick
        If Me.Validar Then
            If MessageBox.Show("¿Esta seguro de guardar las modificaciones?", "Cambio definitivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                If CambioLocalDefinitivoDAO.UpdateCambioDefinitivo(CambioLocalDefinitivoBE, fechaingreso, fechafinal, horaingreso, horafinal) Then
                    Me.Close()
                Else
                    MessageBox.Show("Error al guardar")
                End If
            End If
        End If
    End Sub

    Private Sub btnAprobar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAprobar.ItemClick
        Dim xUltimoNumeroContrato As String
        ' If CambioLocalDefinitivoDAO.EstadoActualEmpleado = 0 Then
        'If CambioLocalDefinitivoBE.IDESTADOEMPLEADO = 0 Then

        If MessageBox.Show("¿Esta seguro de aprobar el cambio definitivo?", "Cambio definitivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            'REGISTRA CAMBIO LOCAL O TIPOCONTRATO ADRYAN
            If sleSolicitudRenuncia.EditValue IsNot Nothing Then
                Dim idrenuncia As Integer = GridViewSolicitudRenuncia.GetFocusedRowCellValue("IDRENUNCIA")
                If chkCambioRazonSocial.Checked Then 'Registra en Adryan cuando es cambio de Razon Social
                    If ValidarReingrsoRazonSocial() Then
                        If (CambioLocalDefinitivoBE.IDORGANIGRAMAORIGEN <> sleOrganigramDestino.EditValue) And CambioLocalDefinitivoBE.IDORGANIGRAMAORIGEN <> 0 And sleOrganigramDestino.EditValue <> 0 Then

                            If ValidarReingrsoRazonSocial() Then
                                xUltimoNumeroContrato = RenovacionContratoDAO.GetObtenerUltimoContrato()
                                If xUltimoNumeroContrato = "" Then
                                    MessageBox.Show("Problemas de Conexión", "Error de Conexión")
                                    Cursor = Cursors.Default
                                    Exit Sub
                                End If
                                If Not BDAccionPersonalDAO.InsertaReingresoEmpleadoCambioRazonSocialAdryan(EmpleadoBE) Then
                                    MessageBox.Show("Error al registrar Reingreso en Adryan")
                                Else
                                    'REGISTRA CAMBIO LOCAL O CONTRATO CENTRAL
                                    If CambioLocalDefinitivoDAO.AprobarCambioDefinitivo(CambioLocalDefinitivoDAO.IdCambioDefinitivo, xUltimoNumeroContrato, BDCentralDAO.UsuarioBE.IDUsuario, EmpleadoBE, idrenuncia) Then
                                        MessageBox.Show("Se realizo el cambio definitivo con éxito")
                                        Me.Close()
                                    Else
                                        MessageBox.Show("Error al aprobar")
                                    End If
                                End If
                            End If
                        Else
                            MessageBox.Show("El local de origen no debe ser igual al local del destino", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                Else 'Registra en Adryan cuando solo es cambio de contrato
                    If CambioLocalDefinitivoBE.IDESTADOEMPLEADO = 0 Then
                        If ValidarReingreso() Then
                            If (CambioLocalDefinitivoBE.IDORGANIGRAMAORIGEN = sleOrganigramDestino.EditValue) And CambioLocalDefinitivoBE.IDORGANIGRAMAORIGEN <> 0 And sleOrganigramDestino.EditValue <> 0 Then
                                If CambioLocalDefinitivoBE.IDEMPLEADOTIPOCONTRATO <> sleNuevoContrato.EditValue Then
                                    'If CambioLocalDefinitivoBE.IDEMPLEADOCARGO = sleNuevoCargo.EditValue Then
                                    xUltimoNumeroContrato = RenovacionContratoDAO.GetObtenerUltimoContrato()
                                        If xUltimoNumeroContrato = "" Then
                                            MessageBox.Show("Problemas de Conexión", "Error de Conexión")
                                            Cursor = Cursors.Default
                                            Exit Sub
                                        End If
                                        If Not BDAccionPersonalDAO.InsertaReingresoEmpleadoAdryan(EmpleadoBE, xUltimoNumeroContrato, 2) Then '1 = ES UN REINGRESO DESDE POSTULANTE, 2 = REINGRESO PERO DESDE CAMBIO DEFINITIVO
                                            MessageBox.Show("Error al registrar Reingreso en Adryan")
                                        Else
                                        'REGISTRA CAMBIO LOCAL O CONTRATO CENTRAL
                                        If CambioLocalDefinitivoDAO.AprobarCambioDefinitivo(CambioLocalDefinitivoDAO.IdCambioDefinitivo, xUltimoNumeroContrato, BDCentralDAO.UsuarioBE.IDUsuario, EmpleadoBE, idrenuncia) Then
                                            'Byal IDCAMBIODEFINITITO, NUMEROCONTRATO A, IDUSUARIO, BE As EmpleadoBE, ByVal IDRENUNCIA As Integer, ByVal idorganigramadestino As Integer
                                            MessageBox.Show("Se realizo el cambio definitivo con éxito")
                                            Me.Close()
                                        Else
                                            MessageBox.Show("Error al aprobar")
                                            End If
                                        End If
                                        'Else
                                        '    MessageBox.Show("El Cargo del colaborador debe ser igual al nuevo cargo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        'End If
                                    Else
                                    MessageBox.Show("El Nuevo Tipo de contrato no debe ser igual al contrato actual", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                End If
                            Else
                                MessageBox.Show("El local de origen debe ser igual al local del destino", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        End If
                    Else
                        MessageBox.Show("Para poder proceder con el cambio definifivo el empleado tiene que estar cesado.")
                    End If
                End If
            Else
                MessageBox.Show("Seleccione el N° solicitud de renuncia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub btnAnular_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnular.ItemClick
        If MessageBox.Show("¿Esta seguro de anular el cambio definitivo?", "Anular cambio definitivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            If CambioLocalDefinitivoDAO.AnularCambioDefinitivo(CambioLocalDefinitivoDAO.IdCambioDefinitivo, BDCentralDAO.UsuarioBE.IDUsuario) Then
                Me.Close()
            Else
                MessageBox.Show("Error al anular")
            End If
        End If
    End Sub

    Private Sub btnValidar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnValidar.ItemClick
        If CambioLocalDefinitivoDAO.FormatoEnvioCorreoSitio = 1 Then
            If Me.Validar Then
                If MessageBox.Show("¿Esta seguro de validar el cambio definitivo?", "Validar cambio definitivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                    If CambioLocalDefinitivoDAO.ValidarCambioDefinitivo(CambioLocalDefinitivoBE, fechaingreso, fechafinal, horaingreso, horafinal) Then
                        Dim dtEmail As New DataTable
                        dtEmail = CambioLocalDefinitivoDAO.GetFormatoEnvioCOrreo(CambioLocalDefinitivoDAO.IdCambioDefinitivo)

                        Dim nroformato As String = dtEmail.Rows(0)("NUMEROFORMATOCAMBIO")
                        Dim correolocal As String = dtEmail.Rows(0)("CORREOLOCAL")
                        Dim correosolicitante As String = dtEmail.Rows(0)("CORREOSOLICITANTE")
                        Dim correocopia As String = dtEmail.Rows(0)("CORREOCOPIA")
                        Dim correolocaldestino As String = dtEmail.Rows(0)("CORREOLOCALDESTINO")

                        Dim emailTo As String
                        If correolocal = "" Then
                            emailTo = correosolicitante
                        ElseIf correosolicitante = "" Then
                            emailTo = correolocal
                        Else
                            emailTo = correosolicitante + "," + correolocal
                        End If
                        If (correolocaldestino = "") Or (correolocal = correolocaldestino) Then
                            emailTo = emailTo + "," + correocopia
                        Else
                            emailTo = emailTo + "," + correocopia + "," + correolocaldestino
                        End If

                        Dim fechaininicio As String = dtEmail.Rows(0)("FECHAINICIO")
                        Dim fechafin As String = dtEmail.Rows(0)("FECHAFIN")
                        Dim horainicio As String = dtEmail.Rows(0)("HORAINICIO")
                        Dim horafin As String = dtEmail.Rows(0)("HORAFIN")
                        Dim razonsocial As String = dtEmail.Rows(0)("RAZONSOCIAL")
                        Dim razoncomercial As String = dtEmail.Rows(0)("RAZONCOMERCIAL")
                        Dim ruc As String = dtEmail.Rows(0)("IDTRIBUTARIO")
                        Dim direccion As String = dtEmail.Rows(0)("DIRECCION")
                        Dim fecha As String = dtEmail.Rows(0)("FECHA")
                        Dim solicitante As String = dtEmail.Rows(0)("SOLICITANTENOMBRE")
                        Dim cargo As String = dtEmail.Rows(0)("SOLICITANTECARGO")
                        Dim dni As String = dtEmail.Rows(0)("SOLICITANTEDNI")
                        Dim empleado As String = dtEmail.Rows(0)("EMPLEADONOMBRE")
                        Dim empleadodni As String = dtEmail.Rows(0)("EMPLEADODNI")

                        If BDCentralDAO.InsertEnvioCorreo(emailTo, "Solicitud de Cambio Nro.: " + nroformato,
                                    "Estimados Sres: " & razonsocial &
                                    " Razón Comercial: " & razoncomercial &
                                    " con n° de RUC: " & ruc & "<br><br>" &
                                    "Se informa que el  colaborador(a): " & empleado & "<br>" &
                                    "DNI: " & empleadodni & "<br>" &
                                    "Debe asistir en la siguiente Fecha, Hora y Lugar para la firma de documentos." & "<br>" &
                                    "Fecha Atención: " & " desde " & fechaininicio + " hasta el " & fechafin & "<br>" &
                                    "Hora Atención: " & " desde " & horainicio & " hasta " & horafin & "<br>" &
                                    "Dirección: Jr. Puno 491 - Cercado de Lima" & "<br>" &
                                    "AREA DE RRHH" & "<br>") Then
                            MessageBox.Show("Envío de correo exitoso.", "Correo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()
                        Else
                            MessageBox.Show("Error al enviar correo.", "Correo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                End If
            End If
        Else
            CambioLocalDefinitivoDAO.ValidarCambioDefinitivoIdSitio2(CambioLocalDefinitivoBE)
            Me.Close()
        End If
    End Sub

    Private Sub btnHistorialEmpleado_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHistorialEmpleado.ItemClick
        Dim idempleado As Integer = CambioLocalDefinitivoBE.IDEMPLEADO
        BDAccionPersonalDAO.IdEmpleado = idempleado
        If BDAccionPersonalDAO.IdEmpleado <> 0 Then
            Dim MiForm As New EmpleadoHistorial

            Nombre = txtEmpleado.Text
            NumeroDocumento = txtDniEmpleado.Text
            NombreLog = Me.Text ' formulario , reporte,
            DetalleLog = "HISTORIAL EMPLEADO " & Nombre & " CON NUMERO DE DOC. " & NumeroDocumento ' acción: impresión, exportar, tb poner filtros , lo que se
            BDCentralDAO.AccesoLogIns(IDSistema, BDCentralDAO.UsuarioBE.IDUsuario, DetalleLog, NombreLog)


            MiForm.ShowDialog()
        End If

    End Sub

    Private Sub sleSolicitudRenuncia_TextChanged(sender As Object, e As EventArgs) Handles sleSolicitudRenuncia.TextChanged
        If GridViewSolicitudRenuncia.GetFocusedRowCellValue("ESTADOREINGRESO") Then
            chkCambioRazonSocial.Checked = True
            sleTipoEmpleado.Visible = False
            deFechaIngresoCompania.Visible = False
            lblFechaReingreso.Visible = False
            lblTipoEmpleado.Visible = False
        Else
            chkCambioRazonSocial.Checked = False
        End If
        deFechaCese.EditValue = GridViewSolicitudRenuncia.GetFocusedRowCellValue("FECHAULTIMODIATRABAJO")
    End Sub

    Private Sub rboIndicadorSi_Click(sender As Object, e As EventArgs) Handles rboIndicadorSi.Click
        lblFechaFinalContrato.Visible = False
        deFechaFinContrato.Visible = False
    End Sub

    Private Sub rboIndicadorNo_Click(sender As Object, e As EventArgs) Handles rboIndicadorNo.Click
        lblFechaFinalContrato.Visible = True
        deFechaFinContrato.Visible = True
    End Sub

End Class