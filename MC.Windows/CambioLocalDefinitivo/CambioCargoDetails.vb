Imports DevExpress.XtraBars
Imports MC.Data
Imports MC.Framework
Public Class CambioCargoDetails
    Dim CambioLocalDefinitivoBE As New CambioLocalDefinitivoBE
    Dim EmpleadoMovimientoBE As New EmpleadoMovimientoBE
    Dim fechaingreso As String
    Dim fechafinal As String
    Dim horaingreso As String
    Dim horafinal As String
    Sub New()

        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterParent
        ListarNuevoCargo()
        ListarNuevoOrganigrama()
        CargarCategoriaEmpleado()
        CargarMotivo()
        '----------------------------------------
    End Sub
    Private Sub CambioCargoDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        If CambioLocalDefinitivoDAO.IdCambioDefinitivo <> 0 Then

            CambioLocalDefinitivoBE = CambioLocalDefinitivoDAO.GetCambioDefinitivoByID(CambioLocalDefinitivoDAO.IdCambioDefinitivo)
            With CambioLocalDefinitivoBE
                txtSolicitante.Text = .SOLICITANTENOMBRE
                txtEmpleado.Text = .EMPLEADONOMBRE
                txtLocalOrigen.Text = .RAZONCOMERCIAL
                txtDniEmpleado.Text = .EMPLEADODNI
                txtCargoActual.Text = .EMPLEADOCARGO
                dtFechaCambio.EditValue = .FECHACAMBIO
                txtActualTipoContrato.Text = .TIPOCONTRATOACTUAL
                sleNuevoCargo.EditValue = .IDNUEVOCARGO
                sleOrganigramDestino.EditValue = .IDORGANIGRAMAORIGEN
                txtNuevoContrato.Text = .NUEVOTIPOCONTRATO
                txtNuevoCargo.Text = .NUEVOCARGO
                txtLocalDestino.Text = .NUEVOLOCAL
                txtIdEmpleado.Text = .IDEMPLEADO
                txtCodigoUnico.Text = .CODIGOUNICO
            End With
            txtSolicitante.Enabled = False
            txtEmpleado.Enabled = False
            txtLocalOrigen.Enabled = False
            sleNuevoCargo.EditValue = CambioLocalDefinitivoBE.IDNUEVOCARGO
        End If
    End Sub
    Private Sub ListarNuevoOrganigrama()
        ControlesDevExpress.InitGridViewColumn(GridViewNuevoLocal, "IDORGANIGRAMA", "IDORGANIGRAMA", 100, False, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridViewNuevoLocal, "NOMBRE", "NOMBRE", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewNuevoLocal, "RAZON SOCIAL", "RAZONSOCIAL", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewNuevoLocal
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOMBRE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
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
    Private Sub CargarMotivo()
        ControlesDevExpress.InitGridViewColumn(GridViewTipoMotivo, "ID", "IDMOTIVOCAMBIO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewTipoMotivo, "MOTIVO", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewTipoMotivo
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleTipoMovimiento.Properties.DataSource = BDAccionPersonalDAO.GetCargarMotivoCambioList
        sleTipoMovimiento.Properties.DisplayMember = "DESCRIPCION"
        sleTipoMovimiento.Properties.ValueMember = "IDMOTIVOCAMBIO"
        sleTipoMovimiento.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarCategoriaEmpleado()
        ControlesDevExpress.InitGridViewColumn(GridViewCategoriaEmpleado, "ID", "CODIGOCATEGORIA", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewCategoriaEmpleado, "CATEGORIA", "CATEGORIA", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewCategoriaEmpleado
            .Columns("CATEGORIA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleCategoriaEmpleado.Properties.DataSource = BDAccionPersonalDAO.GetCategoriaEmpleadoList
        sleCategoriaEmpleado.Properties.DisplayMember = "CATEGORIA"
        sleCategoriaEmpleado.Properties.ValueMember = "CODIGOCATEGORIA"
        sleCategoriaEmpleado.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Function ValidarCambioPuesto() As Boolean
        DxErrorProvider1.ClearErrors()
        Dim Result As Boolean = True
        If sleOrganigramDestino.EditValue Is Nothing Then
            DxErrorProvider1.SetError(sleOrganigramDestino, "Dato obligatorio")
            Result = False
        End If
        If sleNuevoCargo.EditValue Is Nothing Then
            DxErrorProvider1.SetError(sleNuevoCargo, "Dato obligatorio")
            Result = False
        End If
        If sleTipoMovimiento.EditValue Is Nothing Then
            DxErrorProvider1.SetError(sleTipoMovimiento, "Dato obligatorio")
            Result = False
        End If
        If dtFechaMovimiento.EditValue Is Nothing Then
            DxErrorProvider1.SetError(dtFechaMovimiento, "Dato obligatorio")
            Result = False
        End If
        If sleCategoriaEmpleado.EditValue Is Nothing Or sleCategoriaEmpleado.Text = "" Then
            DxErrorProvider1.SetError(sleCategoriaEmpleado, "Dato obligatorio")
            Result = False
        End If

        If Result Then
            Dim dtEmpleadoAdryan As New DataTable
            dtEmpleadoAdryan = BDAccionPersonalDAO.GetEmpleadoCargarDatosAdicionales(CambioLocalDefinitivoBE.IDTIPODOCUMENTOIDENTIDAD, sleNuevoCargo.EditValue, sleOrganigramDestino.EditValue, CambioLocalDefinitivoBE.IDDISTRITO)
            With EmpleadoMovimientoBE
                .CODIGOUNICO = txtCodigoUnico.Text
                .IDEMPLEADO = txtIdEmpleado.Text
                .IDCARGO = sleNuevoCargo.EditValue
                .IDORGANIGRAMA = sleOrganigramDestino.EditValue
                .FECHAEFECTIVAMOVIMIENTO = dtFechaMovimiento.EditValue
                .CODIGOCATEGORIA = sleCategoriaEmpleado.EditValue
                .CODIGOTIPOMOVIMIENTO = sleTipoMovimiento.EditValue
                .OBSERVACION = txtObservacion.Text
                .IDLOCAL = dtEmpleadoAdryan.Rows(0)("IDLOCAL")
                .ADRYAN_PUESTO_ORGANICA = dtEmpleadoAdryan.Rows(0)("PUESTOORGANICA")
                .ADRYAN_UNIDAD_FUNCIONAL = dtEmpleadoAdryan.Rows(0)("UNIDADFUNCIONAL")
                .ADRYAN_GRADO_SALARIAL = dtEmpleadoAdryan.Rows(0)("GRADOSALARIAL")
            End With

        End If
        Return Result
    End Function
    Private Sub btnAprobar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAprobar.ItemClick

        If ValidarCambioPuesto() Then
            If MessageBox.Show("Esta seguro de registrar el nuevo cargo", "Cambio de Cargo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                'VERIFICA EN ADRYAN SI EXISTE CUPOS EN DICHO CARGO
                If BDAccionPersonalDAO.GetObtenerVacanteAdryan(EmpleadoMovimientoBE) = 0 Then
                    '    'REGISTRA EN CAMBIO DE PUESTO ADRYAN
                    If BDAccionPersonalDAO.InsertaMovimientoEmpleadoAdryan(EmpleadoMovimientoBE) Then
                        'REGISTRA EN CAMBIO DE PUESTO CENTRAL
                        If CambioLocalDefinitivoDAO.AprobarCambioCargoDefinitivo(CambioLocalDefinitivoDAO.IdCambioDefinitivo, BDCentralDAO.UsuarioBE.IDUsuario, EmpleadoMovimientoBE) Then
                            MessageBox.Show("Modificacion de cargo exitoso")
                            Me.Close()
                        End If
                    End If
                Else
                    MessageBox.Show("No hay vacantes disponibles en el orgánico para este puesto")
                End If
            End If
        End If
    End Sub

    Private Sub btnAnular_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAnular.ItemClick
        If MessageBox.Show("¿Esta seguro de anular el cambio definitivo?", "Anular cambio definitivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            If CambioLocalDefinitivoDAO.AnularCambioDefinitivo(CambioLocalDefinitivoDAO.IdCambioDefinitivo, BDCentralDAO.UsuarioBE.IDUsuario) Then
                Me.Close()
            Else
                MessageBox.Show("Error al anular")
            End If
        End If
    End Sub

    Private Sub btnHistorialEmpleado_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnHistorialEmpleado.ItemClick
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
End Class