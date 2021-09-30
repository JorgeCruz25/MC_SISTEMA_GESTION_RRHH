Imports MC.Data
Imports MC.Framework

Public Class EmpleadoListEditHijos

    Dim EmpleadoDerechoHabienteBE As New EmpleadoDerechoHabienteBE
    Sub New()
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        CargarTipoDocumento()
        CargarSexo()
        CargarDistrito()
        CargarNacionalidad()
        CargarTipoDerechoHabiente()

        LoadEntidad()
    End Sub

    Private Sub CargarTipoDocumento()

        ControlesDevExpress.InitGridViewColumn(GridViewTipoIdentidad, "ID", "IDTIPOIDENTIDAD", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewTipoIdentidad, "TIPO DE IDENTIDAD", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewTipoIdentidad
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleTipoIdentidad.Properties.DataSource = BDAccionPersonalDAO.GetTipoIdentidadList
        sleTipoIdentidad.Properties.DisplayMember = "DESCRIPCION"
        sleTipoIdentidad.Properties.ValueMember = "IDTIPOIDENTIDAD"
        sleTipoIdentidad.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub CargarSexo()
        ControlesDevExpress.InitGridViewColumn(GridViewSexo, "ID", "IDSEXO", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewSexo, "DESCRIPCION", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewSexo
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleSexo.Properties.DataSource = BDAccionPersonalDAO.GetSexoList
        sleSexo.Properties.DisplayMember = "DESCRIPCION"
        sleSexo.Properties.ValueMember = "IDSEXO"
        sleSexo.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub CargarDistrito()
        ControlesDevExpress.InitGridViewColumn(GridViewDistrito, "ID", "ID", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDistrito, "DEPARTAMENTO", "DEPARTAMENTO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDistrito, "PROVINCIA", "PROVINCIA", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDistrito, "DISTRITO", "DISTRITO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewDistrito
            .Columns("DEPARTAMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("PROVINCIA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("DISTRITO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleDistrito.Properties.DataSource = BDAccionPersonalDAO.GetDistritoList
        sleDistrito.Properties.DisplayMember = "DIRECCION"
        sleDistrito.Properties.ValueMember = "ID"
        sleDistrito.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub CargarNacionalidad()
        ControlesDevExpress.InitGridViewColumn(GridViewOriginario, "ID", "CODIGOPAIS", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewOriginario, "DESCRIPCION", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewOriginario
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleNacionalidad.Properties.DataSource = BDAccionPersonalDAO.GetNacionalidadList
        sleNacionalidad.Properties.DisplayMember = "DESCRIPCION"
        sleNacionalidad.Properties.ValueMember = "CODIGOPAIS"
        sleNacionalidad.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub CargarTipoDerechoHabiente()
        ControlesDevExpress.InitGridViewColumn(GridViewTipoDerechoHabiente, "ID", "TIPODERECHOHABIENTE", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewTipoDerechoHabiente, "DERECHO HABIENTE", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewTipoDerechoHabiente
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleTipoDerechoHabiente.Properties.DataSource = BDAccionPersonalDAO.GetTipoDerechoHabienteList
        sleTipoDerechoHabiente.Properties.DisplayMember = "DESCRIPCION"
        sleTipoDerechoHabiente.Properties.ValueMember = "TIPODERECHOHABIENTE"
        sleTipoDerechoHabiente.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub LoadEntidad()
        EmpleadoDerechoHabienteBE = BDAccionPersonalDAO.GetByAsignacionFamiliarID(BDAccionPersonalDAO.IdDerechoHabiente)

        With EmpleadoDerechoHabienteBE
            txtIdDerechoHabiente.Text = .IDDERECHOHABIENTE
            txtNombre.Text = .NOMBRES
            txtApellidoPaterno.Text = .APELLIDOPATERNO
            txtApellidoMaterno.Text = .APELLIDOMATERNO
            txtDireccion.Text = .DIRECCION
            txtNumeroIdentidad.Text = .DNI
            deFechaNacimiento.EditValue = .FECHANACIMIENTO
            sleNacionalidad.EditValue = .NACIONALIDAD
            sleTipoDerechoHabiente.EditValue = .TIPODERECHOHABIENTE
            sleTipoIdentidad.EditValue = .IDTIPOIDENTIDAD
            sleDistrito.EditValue = .IDUBIGEO
            sleSexo.EditValue = .IDSEXO
            chkTregistro.EditValue = .TREGISTRO
            chkEssalud.EditValue = .ESSALUD
        End With
    End Sub

    Private Function Validar() As Boolean
        Dim Result As Boolean = True

        DxErrorProvider1.ClearErrors()
        If sleTipoDerechoHabiente.EditValue Is Nothing Or sleTipoDerechoHabiente.EditValue = "" Then
            DxErrorProvider1.SetError(sleTipoDerechoHabiente, "Dato obligatorio")
            Result = False
        End If
        If sleTipoIdentidad.EditValue Is Nothing Or sleTipoIdentidad.EditValue = 0 Then
            DxErrorProvider1.SetError(sleTipoIdentidad, "Dato obligatorio")
            Result = False
        End If
        If txtNumeroIdentidad.Text = "" Then
            DxErrorProvider1.SetError(txtNumeroIdentidad, "Dato obligatorio")
            Result = False
        End If
        If deFechaNacimiento.EditValue Is Nothing Or deFechaNacimiento.Text = "" Then
            DxErrorProvider1.SetError(deFechaNacimiento, "Dato obligatorio")
            Result = False
        End If
        If sleSexo.EditValue Is Nothing Or sleSexo.EditValue = 0 Then
            DxErrorProvider1.SetError(sleSexo, "Dato obligatorio")
            Result = False
        End If
        If sleNacionalidad.EditValue Is Nothing Or sleNacionalidad.EditValue = "" Then
            DxErrorProvider1.SetError(sleNacionalidad, "Dato obligatorio")
            Result = False
        End If

        'If sleDistrito.EditValue Is Nothing Or sleDistrito.EditValue = 0 Then
        '    DxErrorProvider1.SetError(sleDistrito, "Dato obligatorio")
        '    Result = False
        'End If
        'If txtDireccion.Text = "" Then
        '    DxErrorProvider1.SetError(txtDireccion, "Dato obligatorio")
        '    Result = False
        'End If

        If Result Then
            Dim dtEmpleadoAdryan As New DataTable
            dtEmpleadoAdryan = BDAccionPersonalDAO.GetEmpleadoCargarDatosAdicionales(sleTipoIdentidad.EditValue, 1, 1, sleDistrito.EditValue)

            With EmpleadoDerechoHabienteBE
                .IDDERECHOHABIENTE = txtIdDerechoHabiente.Text
                .IDEMPLEADO = BDAccionPersonalDAO.IdEmpleado

                .TIPODERECHOHABIENTE = sleTipoDerechoHabiente.EditValue
                .NOMBRES = txtNombre.Text
                .APELLIDOPATERNO = txtApellidoPaterno.Text
                .APELLIDOMATERNO = txtApellidoMaterno.Text
                .IDTIPOIDENTIDAD = sleTipoIdentidad.EditValue
                .DNI = txtNumeroIdentidad.Text
                .FECHANACIMIENTO = deFechaNacimiento.Text

                If sleDistrito.EditValue Is Nothing Then
                    .IDUBIGEO = 0
                Else
                    .IDUBIGEO = sleDistrito.EditValue
                End If

                .DIRECCION = txtDireccion.Text
                .IDSEXO = sleSexo.EditValue
                .NACIONALIDAD = sleNacionalidad.EditValue
                .TREGISTRO = chkTregistro.EditValue
                .ESSALUD = chkEssalud.EditValue

                .ADRYAN_TIPOIDENTIDAD = dtEmpleadoAdryan.Rows(0)("TIPODOCUMENTO")
                .ADRYAN_DISTRITO = dtEmpleadoAdryan.Rows(0)("DISTRITO")
                .ADRYAN_PROVINCIA = dtEmpleadoAdryan.Rows(0)("PROVINCIA")
                .ADRYAN_DEPARTAMENTO = dtEmpleadoAdryan.Rows(0)("DEPARTAMENTO")
                .IDUSUARIOREGISTRO = BDCentralDAO.UsuarioBE.IDUsuario
                .USUARIOREGISTRO = BDCentralDAO.UsuarioBE.Usuario
            End With
        End If

        Return Result

    End Function

    Private Sub btnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick
        If Me.Validar() Then

            If MessageBox.Show("Desea modificar el registro de derecho habiente?", "Modificar derecho habiente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Cursor = Cursors.WaitCursor

                'REGISTRO ADRYAN
                If Not BDAccionPersonalDAO.InsertaDerechoHabientePersonalAdryan(EmpleadoDerechoHabienteBE) Then
                    MessageBox.Show("Problemas de Conexión con el sistema Adryan", "Error de Conexión")
                    Cursor = Cursors.Default
                    Exit Sub
                End If

                'REGISTRO MC_CENTRAL
                If Not BDAccionPersonalDAO.UpdateDerechoHabientePersonal(EmpleadoDerechoHabienteBE) Then
                    MessageBox.Show("Error al modificar el derecho habiente", "Error de Registro")
                    Cursor = Cursors.Default
                    Exit Sub
                End If

                Cursor = Cursors.Default
                Me.Close()
            End If

        End If
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

End Class