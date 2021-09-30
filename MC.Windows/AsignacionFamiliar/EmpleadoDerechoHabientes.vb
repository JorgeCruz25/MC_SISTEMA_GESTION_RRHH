Imports DevExpress.XtraEditors
Imports MC.Data
Imports MC.Framework

Public Class EmpleadoDerechoHabientes
    Dim bsEmpleados As New BindingSource
    Dim EmpleadoBE As New EmpleadoBE
    Dim EmpleadoDerechoHabienteBE As New EmpleadoDerechoHabienteBE
    Dim TablaDerechoHabientes As New DataTable
    Sub New()
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        Limpiar()

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridViewColumn(RepositoryItemGridLookUpEditEmpleadoView, "IDEMPLEADO", "IDEMPLEADO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(RepositoryItemGridLookUpEditEmpleadoView, "NOMBRES", "NOMBRES", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(RepositoryItemGridLookUpEditEmpleadoView, "APELLIDO PATERNO", "APELLIDOPATERNO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(RepositoryItemGridLookUpEditEmpleadoView, "APELLIDO MATERNO", "APELLIDOMATERNO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(RepositoryItemGridLookUpEditEmpleadoView, "N° DE IDENTIDAD", "NUMERODOCUMENTO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With RepositoryItemGridLookUpEditEmpleadoView
            .Columns("NOMBRES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOPATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOMATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        'DERECHO HABIENTES                
        ControlesDevExpress.InitGridViewColumn(GridViewDerechoHabientes, "NOMBRES ", "NOMBRES", 160, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDerechoHabientes, "APELLIDO PATERNO ", "APELLIDOPATERNO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDerechoHabientes, "APELLIDO MATERNO ", "APELLIDOMATERNO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDerechoHabientes, "N° IDENTIDAD", "DNI", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDerechoHabientes, "FECHA NACIMIENTO", "FECHANACIMIENTO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDerechoHabientes, "EDAD", "EDAD", 70, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDerechoHabientes, "SEXO ", "SEXO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        'ControlesDevExpress.InitGridViewColumn(GridViewDerechoHabientes, "TIPODERECHOHABIENTE ", "TIPODERECHOHABIENTE", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDerechoHabientes, "NACIONALIDAD ", "NACIONALIDAD", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDerechoHabientes, "IDDISTRITO", "IDDISTRITO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDerechoHabientes, "DIRECCION ", "DIRECCION", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDerechoHabientes, "ESSALUD ", "ESSALUD", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDerechoHabientes, "TREGISTRO ", "TREGISTRO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewDerechoHabientes
            .Columns("NOMBRES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOPATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOMATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("DNI").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        RepositoryItemGridLookUpEditEmpleado.DataSource = BDAccionPersonalDAO.GetEmpleadosAccionPersonalActivosList()
        RepositoryItemGridLookUpEditEmpleado.ValueMember = "IDEMPLEADO"
        RepositoryItemGridLookUpEditEmpleado.DisplayMember = "EMPLEADO"
        RepositoryItemGridLookUpEditEmpleado.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

        CargarTipoDocumento()
        CargarSexo()
        CargarDistrito()
        CargarNacionalidad()
        'CargarTipoDerechoHabiente()

        CrearTableDerechoHabientes()
    End Sub

    Private Sub CargarTipoDocumento()
        ControlesDevExpress.InitGridViewColumn(GridViewTipoIdentidad, "ID", "IDTIPODOCUMENTOIDENTIDAD", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewTipoIdentidad, "TIPO DE IDENTIDAD", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewTipoIdentidad
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        sleTipoIdentidad.Properties.DataSource = BDAccionPersonalDAO.GetTipoIdentidadList
        sleTipoIdentidad.Properties.DisplayMember = "DESCRIPCION"
        sleTipoIdentidad.Properties.ValueMember = "IDTIPODOCUMENTOIDENTIDAD"
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
        ControlesDevExpress.InitGridViewColumn(GridViewDistrito, "ID", "IDUBIGEO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDistrito, "DEPARTAMENTO", "DEPARTAMENTO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDistrito, "PROVINCIA", "PROVINCIA", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDistrito, "DISTRITO", "DISTRITO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDistrito, "UBIGEO", "UBIGEO", 180, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewDistrito
            .Columns("DEPARTAMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("PROVINCIA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("DISTRITO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        sleDistrito.Properties.DataSource = BDAccionPersonalDAO.GetDistritoList
        sleDistrito.Properties.DisplayMember = "UBIGEO"
        sleDistrito.Properties.ValueMember = "IDUBIGEO"
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

    'Private Sub CargarTipoDerechoHabiente()
    '    ControlesDevExpress.InitGridViewColumn(GridViewTipoDerechoHabiente, "ID", "TIPODERECHOHABIENTE", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
    '    ControlesDevExpress.InitGridViewColumn(GridViewTipoDerechoHabiente, "DERECHO HABIENTE", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

    '    With GridViewTipoDerechoHabiente
    '        .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '    End With
    '    sleTipoDerechoHabiente.Properties.DataSource = BDAccionPersonalDAO.GetTipoDerechoHabienteList
    '    sleTipoDerechoHabiente.Properties.DisplayMember = "DESCRIPCION"
    '    sleTipoDerechoHabiente.Properties.ValueMember = "TIPODERECHOHABIENTE"
    '    sleTipoDerechoHabiente.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    'End Sub

    Private Sub CrearTableDerechoHabientes()
        TablaDerechoHabientes.Columns.Add("IDEMPLEADO", Type.GetType("System.Int32"))
        TablaDerechoHabientes.Columns.Add("DNI", Type.GetType("System.String"))
        TablaDerechoHabientes.Columns.Add("NOMBRES", Type.GetType("System.String"))
        TablaDerechoHabientes.Columns.Add("APELLIDOPATERNO", Type.GetType("System.String"))
        TablaDerechoHabientes.Columns.Add("APELLIDOMATERNO", Type.GetType("System.String"))
        TablaDerechoHabientes.Columns.Add("FECHANACIMIENTO", Type.GetType("System.DateTime"))
        TablaDerechoHabientes.Columns.Add("IDSEXO", Type.GetType("System.Int32"))
        TablaDerechoHabientes.Columns.Add("IDTIPOIDENTIDAD", Type.GetType("System.Int32"))
        'TablaDerechoHabientes.Columns.Add("TIPODERECHOHABIENTE", Type.GetType("System.String"))
        TablaDerechoHabientes.Columns.Add("NACIONALIDAD", Type.GetType("System.String"))
        TablaDerechoHabientes.Columns.Add("IDUBIGEO", Type.GetType("System.Int32"))
        TablaDerechoHabientes.Columns.Add("DIRECCION", Type.GetType("System.String"))
        TablaDerechoHabientes.Columns.Add("TREGISTRO", Type.GetType("System.Boolean"))
        TablaDerechoHabientes.Columns.Add("ESSALUD", Type.GetType("System.Boolean"))

        TablaDerechoHabientes.Columns.Add("EDAD", Type.GetType("System.Int32"))
        TablaDerechoHabientes.Columns.Add("SEXO", Type.GetType("System.String"))
    End Sub

    Private Sub LoadEntidad()

        If BDAccionPersonalDAO.IdEmpleado <> 0 Then
            EmpleadoBE = BDAccionPersonalDAO.GetByEmpleadoID(BDAccionPersonalDAO.IdEmpleado)
            With EmpleadoBE
                txtIdEmpleado.Text = .IDEMPLEADO
                txtEmpleado.Text = .NOMBRES + " " + .APELLIDOPATERNO + " " + .APELLIDOMATERNO
                txtCodigoUnico.Text = .CODIGOUNICO
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
        'If sleTipoDerechoHabiente.EditValue Is Nothing Or sleTipoDerechoHabiente.EditValue = "" Then
        '    DxErrorProvider1.SetError(sleTipoDerechoHabiente, "Dato obligatorio")
        '    Result = False
        'End If
        If txtEmpleado.Text = "" Then
            DxErrorProvider1.SetError(txtEmpleado, "Dato obligatorio")
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
        If txtNombre.Text = "" Then
            DxErrorProvider1.SetError(txtNombre, "Dato obligatorio")
            Result = False
        End If
        If txtApellidoPaterno.Text = "" Then
            DxErrorProvider1.SetError(txtApellidoPaterno, "Dato obligatorio")
            Result = False
        End If
        If txtApellidoMaterno.Text = "" Then
            DxErrorProvider1.SetError(txtApellidoMaterno, "Dato obligatorio")
            Result = False
        End If
        If sleDistrito.EditValue Is Nothing Or sleDistrito.Text = "" Then
            DxErrorProvider1.SetError(sleDistrito, "Dato obligatorio")
            Result = False
        End If
        If txtDireccion.Text = "" Then
            DxErrorProvider1.SetError(txtDireccion, "Dato obligatorio")
            Result = False
        End If

        If Result Then
            'Dim dtEmpleadoAdryan As New DataTable
            'dtEmpleadoAdryan = BDAccionPersonalDAO.GetEmpleadoCargarDatosAdicionales(sleTipoIdentidad.EditValue, 1, 1, sleDistrito.EditValue)

            With EmpleadoDerechoHabienteBE
                .IDDERECHOHABIENTE = txtIdDerechoHabiente.Text
                .IDEMPLEADO = BDAccionPersonalDAO.IdEmpleado
                .CODIGOUNICO = EmpleadoBE.CODIGOUNICO
                '.TIPODERECHOHABIENTE = sleTipoDerechoHabiente.EditValue
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

                '.ADRYAN_TIPOIDENTIDAD = dtEmpleadoAdryan.Rows(0)("TIPODOCUMENTO")
                '.ADRYAN_DISTRITO = dtEmpleadoAdryan.Rows(0)("DISTRITO")
                '.ADRYAN_PROVINCIA = dtEmpleadoAdryan.Rows(0)("PROVINCIA")
                '.ADRYAN_DEPARTAMENTO = dtEmpleadoAdryan.Rows(0)("DEPARTAMENTO")
                .IDUSUARIOREGISTRO = BDCentralDAO.UsuarioBE.IDUsuario
                .USUARIOREGISTRO = BDCentralDAO.UsuarioBE.Usuario
            End With
        End If

        Return Result

    End Function

    Private Sub Limpiar()
        txtIdDerechoHabiente.Text = "0"
        txtNombre.Text = ""
        txtApellidoPaterno.Text = ""
        txtApellidoMaterno.Text = ""
        txtDireccion.Text = ""
        txtNumeroIdentidad.Text = ""
        deFechaNacimiento.Text = ""
        sleNacionalidad.EditValue = ""
        'sleTipoDerechoHabiente.EditValue = ""
        sleTipoIdentidad.EditValue = 0
        sleDistrito.EditValue = 0
        sleSexo.EditValue = 0
        chkEssalud.EditValue = 0
        chkTregistro.EditValue = 0
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If BDAccionPersonalDAO.IdEmpleado = 0 Then
            Exit Sub
        End If

        If Me.Validar() Then
            Dim xEdad As Integer
            Dim xFechaNacimiento As Date
            Dim resta As Integer = 0

            xFechaNacimiento = deFechaNacimiento.EditValue
            If DateAdd(DateInterval.Year, DateDiff(DateInterval.Year, xFechaNacimiento, Date.Now), xFechaNacimiento) > Date.Now Then
                resta = 1
            End If
            xEdad = DateDiff(DateInterval.Year, xFechaNacimiento, DateTime.Now.Date) - resta


            TablaDerechoHabientes.Rows.Add(BDAccionPersonalDAO.IdEmpleado, EmpleadoDerechoHabienteBE.DNI, EmpleadoDerechoHabienteBE.NOMBRES, EmpleadoDerechoHabienteBE.APELLIDOPATERNO, EmpleadoDerechoHabienteBE.APELLIDOMATERNO, EmpleadoDerechoHabienteBE.FECHANACIMIENTO, EmpleadoDerechoHabienteBE.IDSEXO, EmpleadoDerechoHabienteBE.IDTIPOIDENTIDAD, EmpleadoDerechoHabienteBE.NACIONALIDAD, EmpleadoDerechoHabienteBE.IDUBIGEO, EmpleadoDerechoHabienteBE.DIRECCION, EmpleadoDerechoHabienteBE.TREGISTRO, EmpleadoDerechoHabienteBE.ESSALUD, xEdad, sleSexo.Text)
            GridControl1.DataSource = TablaDerechoHabientes
            Limpiar()
        End If
    End Sub

    Private Sub btnRegistrarDerechoHabiente_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRegistrarDerechoHabiente.ItemClick
        If BDAccionPersonalDAO.IdEmpleado = 0 Then
            Exit Sub
        End If

        If TablaDerechoHabientes.Rows.Count > 0 Then

            If MessageBox.Show("Desea registrar derecho habiente(s)?", "Registrar derecho habiente(s)", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Cursor = Cursors.WaitCursor

                'REGISTRA SOLICITUD
                If Not BDAccionPersonalDAO.InsertAsignacionFamiliar(BDAccionPersonalDAO.IdEmpleado, BDCentralDAO.UsuarioBE.IDUsuario, TablaDerechoHabientes, EmpleadoBE.IDORGANIGRAMA) Then
                    MessageBox.Show("Error al registrar la solicitud", "Error de Registro")
                    Cursor = Cursors.Default
                    Exit Sub
                End If

                'REGISTRA DERECHO HABIENTE
                For i As Integer = 0 To TablaDerechoHabientes.Rows.Count - 1
                    With EmpleadoDerechoHabienteBE
                        .IDEMPLEADO = BDAccionPersonalDAO.IdEmpleado
                        .CODIGOUNICO = EmpleadoBE.CODIGOUNICO
                        .DNI = TablaDerechoHabientes.Rows(i)("DNI")
                        .NOMBRES = TablaDerechoHabientes.Rows(i)("NOMBRES")
                        .APELLIDOPATERNO = TablaDerechoHabientes.Rows(i)("APELLIDOPATERNO")
                        .APELLIDOMATERNO = TablaDerechoHabientes.Rows(i)("APELLIDOMATERNO")
                        .FECHANACIMIENTO = TablaDerechoHabientes.Rows(i)("FECHANACIMIENTO")
                        .IDSEXO = TablaDerechoHabientes.Rows(i)("IDSEXO")
                        .IDTIPOIDENTIDAD = TablaDerechoHabientes.Rows(i)("IDTIPOIDENTIDAD")
                        '.TIPODERECHOHABIENTE = TablaDerechoHabientes.Rows(i)("TIPODERECHOHABIENTE")
                        .NACIONALIDAD = TablaDerechoHabientes.Rows(i)("NACIONALIDAD")
                        .IDUBIGEO = TablaDerechoHabientes.Rows(i)("IDUBIGEO")
                        .DIRECCION = TablaDerechoHabientes.Rows(i)("DIRECCION")
                        .TREGISTRO = TablaDerechoHabientes.Rows(i)("TREGISTRO")
                        .ESSALUD = TablaDerechoHabientes.Rows(i)("ESSALUD")

                        'Dim dtEmpleadoAdryan As New DataTable
                        'dtEmpleadoAdryan = BDAccionPersonalDAO.GetEmpleadoCargarDatosAdicionales(.IDTIPOIDENTIDAD, 1, 1, .IDDISTRITO)

                        '.ADRYAN_TIPOIDENTIDAD = dtEmpleadoAdryan.Rows(0)("TIPODOCUMENTO")
                        '.ADRYAN_DISTRITO = dtEmpleadoAdryan.Rows(0)("DISTRITO")
                        '.ADRYAN_PROVINCIA = dtEmpleadoAdryan.Rows(0)("PROVINCIA")
                        '.ADRYAN_DEPARTAMENTO = dtEmpleadoAdryan.Rows(0)("DEPARTAMENTO")
                        '.IDUSUARIOREGISTRO = BDCentralDAO.UsuarioBE.IDUsuario
                        '.USUARIOREGISTRO = BDCentralDAO.UsuarioBE.Usuario
                    End With

                    'REGISTRO ADRYAN
                    'If Not BDAccionPersonalDAO.InsertaDerechoHabientePersonalAdryan(EmpleadoDerechoHabienteBE) Then
                    '    MessageBox.Show("Problemas de Conexión con el sistema Adryan", "Error de Conexión")
                    '    Cursor = Cursors.Default
                    '    Exit Sub
                    'End If

                    'REGISTRO MC_CENTRAL
                    If Not BDAccionPersonalDAO.InsertaHijosFamilia(EmpleadoDerechoHabienteBE) Then
                        MessageBox.Show("Error al registrar el derecho habiente", "Error de Registro")
                        Cursor = Cursors.Default
                        Exit Sub
                    End If

                Next

                Me.Close()
                Cursor = Cursors.Default
            End If
        End If

    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub RepositoryItemButtonEditEliminar_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEditEliminar.Click
        If MessageBox.Show("Desea eliminar el registro?", "Eliminar derecho habiente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim DNI As String
            Dim IDTIPOIDENTIDAD As Integer
            DNI = GridViewDerechoHabientes.GetFocusedRowCellValue("DNI")
            IDTIPOIDENTIDAD = GridViewDerechoHabientes.GetFocusedRowCellValue("IDTIPOIDENTIDAD")

            Dim dtTemporal As New DataTable
            dtTemporal = TablaDerechoHabientes.Copy()

            For i As Integer = 0 To TablaDerechoHabientes.Rows.Count - 1
                If TablaDerechoHabientes.Rows(i)("DNI") = DNI And TablaDerechoHabientes.Rows(i)("IDTIPOIDENTIDAD") = IDTIPOIDENTIDAD Then
                    dtTemporal.Rows(i).Delete()
                End If
            Next

            TablaDerechoHabientes.Clear()
            TablaDerechoHabientes = dtTemporal
            GridControl1.DataSource = TablaDerechoHabientes
        End If
    End Sub

End Class