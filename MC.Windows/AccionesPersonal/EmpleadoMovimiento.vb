Imports DevExpress.XtraEditors
Imports MC.Data
Imports MC.Framework

Public Class EmpleadoMovimiento
    Dim bsEmpleados As New BindingSource

    Dim EmpleadoBE As New EmpleadoBE

    Dim EmpleadoMovimientoBE As New EmpleadoMovimientoBE

    Sub New()

        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridViewColumn(RepositoryItemGridLookUpEditEmpleadoView, "IDEMPLEADO", "IDEMPLEADO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(RepositoryItemGridLookUpEditEmpleadoView, "NOMBRES", "NOMBRES", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(RepositoryItemGridLookUpEditEmpleadoView, "APELLIDO PATERNO", "APELLIDOPATERNO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(RepositoryItemGridLookUpEditEmpleadoView, "APELLIDO MATERNO", "APELLIDOMATERNO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(RepositoryItemGridLookUpEditEmpleadoView, "N° DE IDENTIDAD", "DNI", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With RepositoryItemGridLookUpEditEmpleadoView
            .Columns("NOMBRES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOPATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOMATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("DNI").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        RepositoryItemGridLookUpEditEmpleado.DataSource = BDAccionPersonalDAO.GetEmpleadosAccionPersonalActivosList()

        RepositoryItemGridLookUpEditEmpleado.ValueMember = "IDEMPLEADO"
        RepositoryItemGridLookUpEditEmpleado.DisplayMember = "EMPLEADO"

        RepositoryItemGridLookUpEditEmpleado.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

        CargarTipoMovimiento()

        CargarCargosAntes()
        CargarLocalesAntes()
        CargarCategoriaEmpleadoAntes()
        CargarUbicacionFisicaAntes()

        CargarCargos()
        CargarLocales()
        CargarCategoriaEmpleado()
        CargarUbicacionFisica()

    End Sub

    Private Sub CargarTipoMovimiento()
        ControlesDevExpress.InitGridViewColumn(GridViewTipoMovimiento, "ID", "IDTIPOMOVIMIENTO", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewTipoMovimiento, "TIPO MOVIMIENTO", "TIPOMOVIMIENTO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewTipoMovimiento
            .Columns("TIPOMOVIMIENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleTipoMovimiento.Properties.DataSource = BDAccionPersonalDAO.GetTipoMovimientoEmpleadoList
        sleTipoMovimiento.Properties.DisplayMember = "TIPOMOVIMIENTO"
        sleTipoMovimiento.Properties.ValueMember = "IDTIPOMOVIMIENTO"
        sleTipoMovimiento.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub CargarCargosAntes()
        ControlesDevExpress.InitGridViewColumn(GridViewCargoAntes, "ID", "IDCARGO", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewCargoAntes, "CARGO", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewCargoAntes
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleCargoAntes.Properties.DataSource = BDAccionPersonalDAO.GetCargoList
        sleCargoAntes.Properties.DisplayMember = "DESCRIPCION"
        sleCargoAntes.Properties.ValueMember = "IDCARGO"
        sleCargoAntes.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub CargarLocalesAntes()
        ControlesDevExpress.InitGridViewColumn(GridViewLocalAntes, "ID", "IDLOCAL", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewLocalAntes, "RAZON SOCIAL", "RAZONSOCIAL", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewLocalAntes, "RAZON COMERCIAL", "RAZONCOMERCIAL", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewLocalAntes
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleLocalAntes.Properties.DataSource = BDAccionPersonalDAO.GetLocalList
        sleLocalAntes.Properties.DisplayMember = "DATOLOCAL"
        sleLocalAntes.Properties.ValueMember = "IDLOCAL"
        sleLocalAntes.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub CargarCategoriaEmpleadoAntes()
        ControlesDevExpress.InitGridViewColumn(GridViewCategoriaEmpleadoAntes, "ID", "CODIGOCATEGORIA", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewCategoriaEmpleadoAntes, "CATEGORIA", "CATEGORIA", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewCategoriaEmpleadoAntes
            .Columns("CATEGORIA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleCategoriaEmpleadoAntes.Properties.DataSource = BDAccionPersonalDAO.GetCategoriaEmpleadoList
        sleCategoriaEmpleadoAntes.Properties.DisplayMember = "CATEGORIA"
        sleCategoriaEmpleadoAntes.Properties.ValueMember = "CODIGOCATEGORIA"
        sleCategoriaEmpleadoAntes.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub CargarUbicacionFisicaAntes()
        ControlesDevExpress.InitGridViewColumn(GridViewUbicacionFisicaAntes, "ID", "CODIGOUBICACIONFISICA", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewUbicacionFisicaAntes, "UBICACION FISICA", "UBICACIONFISICA", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewUbicacionFisicaAntes
            .Columns("UBICACIONFISICA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleUbicacionFisicaAntes.Properties.DataSource = BDAccionPersonalDAO.GetUbicacionFisicaEmpleadoList
        sleUbicacionFisicaAntes.Properties.DisplayMember = "UBICACIONFISICA"
        sleUbicacionFisicaAntes.Properties.ValueMember = "CODIGOUBICACIONFISICA"
        sleUbicacionFisicaAntes.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub CargarCargos()
        ControlesDevExpress.InitGridViewColumn(GridViewCargo, "ID", "IDCARGO", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewCargo, "CARGO", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewCargo
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleCargo.Properties.DataSource = BDAccionPersonalDAO.GetCargoList
        sleCargo.Properties.DisplayMember = "DESCRIPCION"
        sleCargo.Properties.ValueMember = "IDCARGO"
        sleCargo.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub CargarLocales()
        ControlesDevExpress.InitGridViewColumn(GridViewLocal, "ID", "IDLOCAL", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewLocal, "RAZON SOCIAL", "RAZONSOCIAL", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewLocal, "RAZON COMERCIAL", "RAZONCOMERCIAL", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewLocal
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleLocal.Properties.DataSource = BDAccionPersonalDAO.GetLocalList
        sleLocal.Properties.DisplayMember = "DATOLOCAL"
        sleLocal.Properties.ValueMember = "IDLOCAL"
        sleLocal.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
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

    Private Sub CargarUbicacionFisica()
        ControlesDevExpress.InitGridViewColumn(GridViewUbicacionFisica, "ID", "CODIGOUBICACIONFISICA", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewUbicacionFisica, "UBICACION FISICA", "UBICACIONFISICA", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewUbicacionFisica
            .Columns("UBICACIONFISICA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleUbicacionFisica.Properties.DataSource = BDAccionPersonalDAO.GetUbicacionFisicaEmpleadoList
        sleUbicacionFisica.Properties.DisplayMember = "UBICACIONFISICA"
        sleUbicacionFisica.Properties.ValueMember = "CODIGOUBICACIONFISICA"
        sleUbicacionFisica.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub


    Private Sub LoadEntidad()

        If BDAccionPersonalDAO.IdEmpleado <> 0 Then
            EmpleadoBE = BDAccionPersonalDAO.GetByEmpleadoID(BDAccionPersonalDAO.IdEmpleado)
            With EmpleadoBE
                txtIdEmpleado.Text = .IDEMPLEADO
                txtNombres.Text = .NOMBRES
                txtApellidoPaterno.Text = .APELLIDOPATERNO
                txtApellidoMaterno.Text = .APELLIDOMATERNO
                txtCodigoUnico.Text = .CODIGOUNICO

                sleCargoAntes.EditValue = .IDCARGO
                sleLocalAntes.EditValue = .IDLOCAL
                sleCategoriaEmpleadoAntes.EditValue = .CODIGOCATEGORIA
                sleUbicacionFisicaAntes.EditValue = .CODIGOUBICACIONFISICA
            End With
        End If
    End Sub

    Private Sub RepositoryItemGridLookUpEditEmpleado_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemGridLookUpEditEmpleado.EditValueChanged
        Dim editor As GridLookUpEdit = TryCast(sender, GridLookUpEdit)
        Dim id As Object = editor.Properties.View.GetFocusedRowCellValue("IDEMPLEADO")

        BDAccionPersonalDAO.IdEmpleado = id
        LoadEntidad()
    End Sub
    Private Function Validar() As Boolean
        Dim Result As Boolean = True

        DxErrorProvider1.ClearErrors()

        If sleTipoMovimiento.EditValue Is Nothing Or sleTipoMovimiento.EditValue = 0 Then
            DxErrorProvider1.SetError(sleTipoMovimiento, "Dato obligatorio")
            Result = False
        End If
        If deFechaMovimiento.EditValue Is Nothing Or deFechaMovimiento.Text = "" Then
            DxErrorProvider1.SetError(deFechaMovimiento, "Dato obligatorio")
            Result = False
        End If
        If deFechaInicioCambio.EditValue Is Nothing Or deFechaInicioCambio.Text = "" Then
            DxErrorProvider1.SetError(deFechaInicioCambio, "Dato obligatorio")
            Result = False
        End If


        If sleLocal.EditValue Is Nothing Then
            DxErrorProvider1.SetError(sleLocal, "Dato obligatorio")
            Result = False
        End If
        If sleCargo.EditValue Is Nothing Then
            DxErrorProvider1.SetError(sleCargo, "Dato obligatorio")
            Result = False
        End If
        If sleUbicacionFisica.EditValue Is Nothing Or sleUbicacionFisica.EditValue = "" Then
            DxErrorProvider1.SetError(sleUbicacionFisica, "Dato obligatorio")
            Result = False
        End If
        If sleCategoriaEmpleado.EditValue Is Nothing Or sleCategoriaEmpleado.EditValue = "" Then
            DxErrorProvider1.SetError(sleCategoriaEmpleado, "Dato obligatorio")
            Result = False
        End If

        If Result Then
            Dim dtEmpleadoAdryan As New DataTable
            dtEmpleadoAdryan = BDAccionPersonalDAO.GetEmpleadoCargarDatosAdicionales(1, sleCargo.EditValue, sleLocal.EditValue, 1)

            With EmpleadoMovimientoBE
                .IDEMPLEADO = txtIdEmpleado.Text
                .CODIGOUNICO = EmpleadoBE.CODIGOUNICO

                .CODIGOTIPOMOVIMIENTO = sleTipoMovimiento.EditValue
                .IDLOCALANTES = sleLocalAntes.EditValue
                .IDCARGOANTES = sleCargoAntes.EditValue
                .CODIGOUBICACIONFISICAANTES = sleUbicacionFisicaAntes.EditValue
                .CODIGOCATEGORIAANTES = sleCategoriaEmpleadoAntes.EditValue
                .FECHAEFECTIVAMOVIMIENTO = deFechaMovimiento.Text
                .FECHAINICIOCAMBIO = deFechaInicioCambio.Text

                .IDLOCAL = sleLocal.EditValue
                .IDCARGO = sleCargo.EditValue
                .CODIGOUBICACIONFISICA = sleUbicacionFisica.EditValue
                .CODIGOCATEGORIA = sleCategoriaEmpleado.EditValue
                .OBSERVACION = txtObservacion.Text

                .ADRYAN_PUESTO_ORGANICA = dtEmpleadoAdryan.Rows(0)("PUESTOORGANICA")
                .ADRYAN_UNIDAD_FUNCIONAL = dtEmpleadoAdryan.Rows(0)("UNIDADFUNCIONAL")

                .IDUSUARIOREGISTRO = BDCentralDAO.UsuarioBE.IDUsuario
                .USUARIOREGISTRO = BDCentralDAO.UsuarioBE.Usuario
            End With
        End If

        Return Result

    End Function


    Private Sub btnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick
        If BDAccionPersonalDAO.IdEmpleado = 0 Then
            Exit Sub
        End If

        If Me.Validar() Then
            'VALIDA VACANTES POR PUESTO-LOCAL ADRYAN
            If BDAccionPersonalDAO.GetObtenerVacanteAdryan(EmpleadoMovimientoBE) Then
                MessageBox.Show("No hay vacante disponible en el Local para este puesto", "Aviso")
                Exit Sub
            End If

            Cursor = Cursors.WaitCursor
            'INSERTA MOVIMIENTO ADRYAN
            If BDAccionPersonalDAO.InsertaMovimientoEmpleadoAdryan(EmpleadoMovimientoBE) Then
                'INSERTA MOVIMIENTO EMPLEADO
                If Not BDAccionPersonalDAO.InsertaMovimientoPersonal(EmpleadoMovimientoBE) Then
                    MessageBox.Show("Error al registrar el movimiento", "Error de Registro")
                    Cursor = Cursors.Default
                    Exit Sub
                End If
            Else
                MessageBox.Show("Problemas de Conexión con el sistema Adryan", "Error de Conexión")
                Cursor = Cursors.Default
                Exit Sub
            End If

            Cursor = Cursors.Default
            Me.Close()
        End If

    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

End Class