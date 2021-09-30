Imports MC.Data
Imports MC.Framework

Public Class RQNoMasivosPostulantesAgregar

    Dim PostulanteNoMasivoBE As New PostulanteNoMasivoBE

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridViewColumn(RepositoryItemGridLookUpEditTipoIdentidadView, "IDTIPODOCUMENTOIDENTIDAD", "IDTIPODOCUMENTOIDENTIDAD", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(RepositoryItemGridLookUpEditTipoIdentidadView, "DESCRIPCION", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With RepositoryItemGridLookUpEditTipoIdentidadView
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        RepositoryItemGridLookUpEditTipoIdentidad.DataSource = BDAccionPersonalDAO.GetTipoIdentidadList()

        RepositoryItemGridLookUpEditTipoIdentidad.ValueMember = "IDTIPODOCUMENTOIDENTIDAD"
        RepositoryItemGridLookUpEditTipoIdentidad.DisplayMember = "DESCRIPCION"

        ControlesDevExpress.InitGridViewColumn(GridView3, "ID", "IDMEMORANDUM", 10, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView3, "NUMEROINFORME", "NUMEROINFORME", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView3, "RAZON SOCIAL", "RAZONSOCIAL", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView3, "FECHA", "FECHA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView3, "NIVEL FALTA", "NIVELFALTA", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView3, "FALTA", "FALTA", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView3, "DECRIPCIÓN MEMORANDUM", "MEMORANDUMDESCRIPCION", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

    End Sub

    Private Sub PostulantesNoMasivosAgregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarFuenteReclutamiento()
        gluTipoIdentidad.Enabled = True
        txtNumeroIdentidad.Enabled = True
        txtTelefonoFijo.Enabled = False
        txtApellidoMaterno.Enabled = False
        txtApellidoPaterno.Enabled = False
        txtNombres.Enabled = False
        gluFuenteReclutamiento.Enabled = False
        txtTelefonoCelular.Enabled = False
        txtTelefonoCelular2.Enabled = False
    End Sub
    Private Sub HistorialMemorandum(ByVal IDEMPLEADO As Int32)
        GridControl1.DataSource = PrestamoDAO.GetHistorialMemorandumByID(IDEMPLEADO)
    End Sub

    Private Sub ListarFuenteReclutamiento()
        gluFuenteReclutamiento.Properties.DataSource = BDCentralDAO.GetFuenteReclutamientoList
        gluFuenteReclutamiento.Properties.ValueMember = "IDFUENTE"
        gluFuenteReclutamiento.Properties.DisplayMember = "DESCRIPCION"
    End Sub

    Private Sub inabilitartext()
        txtApellidoMaterno.Enabled = False
        txtApellidoPaterno.Enabled = False
        txtNombres.Enabled = False
        gluFuenteReclutamiento.Enabled = False
        txtTelefonoFijo.Enabled = False
        txtTelefonoCelular.Enabled = False
        txtTelefonoCelular2.Enabled = False
    End Sub
    Private Sub btnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick

        If txtApellidoPaterno.Text = "" Then
            DxErrorProvider1.SetError(txtApellidoPaterno, "Información Requerida")
            Exit Sub
        End If

        If txtNombres.Text = "" Then
            DxErrorProvider1.SetError(txtNombres, "Información Requerida")
            Exit Sub
        End If

        'If gluTipoIdentidad.EditValue IsNot Nothing Then
        '    If txtNumeroIdentidad.Text = "" Then
        '        DxErrorProvider1.SetError(txtNumeroIdentidad, "Información Requerida")
        '        Exit Sub
        '    End If
        'End If

        'If txtNumeroIdentidad.Text <> "" Then
        '    If gluTipoIdentidad.EditValue Is Nothing Then
        '        DxErrorProvider1.SetError(gluTipoIdentidad, "Información Requerida")
        '        Exit Sub
        '    End If
        'End If


        With PostulanteNoMasivoBE
            If txtIdPostulante.Text = "" Then
                .IDPOSTULANTENOMASIVO = 0
            Else
                .IDPOSTULANTENOMASIVO = txtIdPostulante.Text
            End If

            .IDREQUERIMIENTO = BDCentralDAO.IdRequerimiento
            .IDCARGO = BDCentralDAO.IdRequerimientoCargo

            If gluTipoIdentidad.EditValue Is Nothing Then
                .IDTIPODOCUMENTOIDENTIDAD = 0
            Else
                .IDTIPODOCUMENTOIDENTIDAD = gluTipoIdentidad.EditValue
            End If

            .NUMERODOCUMENTO = txtNumeroIdentidad.EditValue
            .NOMBRES = txtNombres.Text
            .APELLIDOPATERNO = txtApellidoPaterno.Text
            .APELLIDOMATERNO = txtApellidoMaterno.Text
            .TELEFONOFIJO = txtTelefonoFijo.Text
            .TELEFONOCELULAR = txtTelefonoCelular.Text
            .TELEFONOCELULAR2 = txtTelefonoCelular2.Text
            .CORREO = ""

            .FECHANACIMIENTO = "1900-01-01"

            If gluFuenteReclutamiento.EditValue Is Nothing Then
                .IDFUENTE = "0"
            Else
                .IDFUENTE = gluFuenteReclutamiento.EditValue
            End If

            .SALARIO = "0"
            .OBSERVACION = ""
            .IDESTADO = "0"
            .HORA = ""
            .FECHACONVOCATORIA1 = "1900-01-01"
            .FECHACONVOCATORIA2 = "1900-01-01"
            .FECHACONVOCATORIA3 = "1900-01-01"
            .IDESTADOCREDITICIO = "0"
            .MONTOADEUDADO = ""
            .DIAVENCIMIENTO = "0"
            .ENTIDAD = ""
            .IDESTADOPSICOLOGICO = "0"
            .IDESTADOASSESMENT = "0"
            .IDENTREVISTASELECCION = "0"
            .OBSERVACION2 = ""
            .IDENTREVISTAPREVIA = "0"

            .IDENTREVISTAAREAFINAL = "0"
            .OBSERVACION3 = ""
            .ESTADOASIGNACION = False
        End With

        'If txtNumeroIdentidad.EditValue = "" Then
        '    BDCentralDAO.PostulanteNoMasivoInsert(PostulanteNoMasivoBE)
        '    limpiar()
        '    MessageBox.Show("Registro Guardado.")
        'Else
        Dim Result As String = BDCentralDAO.ValidarDNINoMasivos(PostulanteNoMasivoBE.IDTIPODOCUMENTOIDENTIDAD, PostulanteNoMasivoBE.NUMERODOCUMENTO)

        If Result = 0 Then
            If BDCentralDAO.PostulanteNoMasivoInsert(PostulanteNoMasivoBE) Then
                limpiar()
                GridControl1.Visible = False
                inabilitartext()
                MessageBox.Show("Registro Guardado.")
            End If
        ElseIf Result = 1 Then
            If BDCentralDAO.PostulanteNoMasivoInsert(PostulanteNoMasivoBE) Then
                inabilitartext()
                limpiar()
                MessageBox.Show("Registro Guardado.")
            End If
        ElseIf Result = 2 Then
            MessageBox.Show("Postulante ya existe")
        ElseIf Result = 3 Then
            MessageBox.Show("Postulante ya existe")
        ElseIf Result = 4 Then
            MessageBox.Show("El postulante actualmente se encuentra laborando")
        ElseIf Result = 5 Then
            BDCentralDAO.UpdatePostulanteNoMasivoEstadoAsignacion(PostulanteNoMasivoBE)
            limpiar()
            GridControl1.Visible = False
            inabilitartext()
            gluTipoIdentidad.Enabled = True
            txtNumeroIdentidad.Enabled = True
            MessageBox.Show("Exito al traer postulante.")
        End If


        'End If



    End Sub

    Private Sub limpiar()
        DxErrorProvider1.ClearErrors()
        txtIdPostulante.Text = ""
        txtApellidoPaterno.Text = ""
        txtApellidoMaterno.Text = ""
        txtNombres.Text = ""
        gluTipoIdentidad.EditValue = Nothing

        gluFuenteReclutamiento.EditValue = Nothing
        txtTelefonoCelular.Text = ""
        txtTelefonoCelular2.Text = ""
        txtTelefonoFijo.Text = ""
        txtNumeroIdentidad.EditValue = ""

    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim NUMERODOCUMENTO As String = txtNumeroIdentidad.EditValue
        Dim IDTIPODOCUMENTOIDENTIDAD As Integer = gluTipoIdentidad.EditValue

        If NUMERODOCUMENTO Is Nothing Or NUMERODOCUMENTO = "" Then
            MessageBox.Show("INGRESE EL NUMERO DE IDENTIDAD")
            Exit Sub
        End If
        If gluTipoIdentidad.EditValue Is Nothing Then
            MessageBox.Show("SELECCIONE EL TIPO DE IDENTIDAD")
            Exit Sub
        End If

        Dim Result As String = BDCentralDAO.ValidarDNINoMasivos(IDTIPODOCUMENTOIDENTIDAD, NUMERODOCUMENTO)
        If Result = 0 Then
            If MessageBox.Show("Este postulante ya ha laborado en la empresa y se encuentra cesado,pero no como un postulante. ¿Desea cargar sus datos?", "Registro de Postulante", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                '         BDCentralDAO
                Dim dt As DataTable = BDCentralDAO.GetCargarDatosEmpleadoNOMasivoGetId(IDTIPODOCUMENTOIDENTIDAD, NUMERODOCUMENTO)
                If dt.Rows.Count > 0 Then
                    Dim idempleado As Integer = dt.Rows(0).Item("IDEMPLEADO")

                    txtApellidoMaterno.EditValue = dt.Rows(0).Item("APELLIDOMATERNO")
                    txtApellidoPaterno.EditValue = dt.Rows(0).Item("APELLIDOPATERNO")
                    txtNombres.EditValue = dt.Rows(0).Item("NOMBRES")
                    txtTelefonoFijo.EditValue = dt.Rows(0).Item("TELEFONO")
                    txtNumeroIdentidad.EditValue = dt.Rows(0).Item("NUMERODOCUMENTO")

                    gluFuenteReclutamiento.Enabled = True
                    txtTelefonoFijo.Enabled = True
                    txtTelefonoCelular.Enabled = True
                    txtTelefonoCelular2.Enabled = True
                    txtApellidoMaterno.Enabled = True
                    txtApellidoPaterno.Enabled = True
                    txtNombres.Enabled = True
                    gluFuenteReclutamiento.Enabled = True
                    txtTelefonoFijo.Enabled = True
                    txtTelefonoCelular.Enabled = True
                    txtTelefonoCelular2.Enabled = True

                    txtNumeroIdentidad.Enabled = False
                    gluTipoIdentidad.Enabled = False
                    GroupControl1.Visible = True
                    HistorialMemorandum(idempleado)
                End If
            End If

        ElseIf Result = 1 Then
            gluFuenteReclutamiento.Enabled = True
            txtTelefonoFijo.Enabled = True
            txtTelefonoCelular.Enabled = True
            txtTelefonoCelular2.Enabled = True
            txtApellidoMaterno.Enabled = True
            txtApellidoPaterno.Enabled = True
            txtNombres.Enabled = True
            txtNumeroIdentidad.Enabled = False
            gluTipoIdentidad.Enabled = False
        ElseIf Result = 2 Then
            MessageBox.Show("Postulante ya existe")
        ElseIf Result = 3 Or Result = 4 Then
            MessageBox.Show("el postulante se encuentra laborando")
        ElseIf Result = 5 Then
            If MessageBox.Show("El postulante actualmente se encuentra cesado. ¿Desea cargar sus datos?", "Registro de Postulante", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                'BDCentralDAO
                Dim dt As DataTable = BDCentralDAO.GetCargarDatosEmpleadoNOMasivoGetId(IDTIPODOCUMENTOIDENTIDAD, NUMERODOCUMENTO)
                If dt.Rows.Count > 0 Then
                    Dim idempleado As Integer = dt.Rows(0).Item("IDEMPLEADO")
                    txtIdPostulante.EditValue = dt.Rows(0).Item("IDPOSTULANTEMASIVO")
                    txtApellidoMaterno.EditValue = dt.Rows(0).Item("APELLIDOMATERNO")
                    txtApellidoPaterno.EditValue = dt.Rows(0).Item("APELLIDOPATERNO")
                    txtNombres.EditValue = dt.Rows(0).Item("NOMBRES")

                    txtTelefonoCelular.EditValue = dt.Rows(0).Item("TELEFONO")

                    txtNumeroIdentidad.EditValue = dt.Rows(0).Item("NUMERODOCUMENTO")

                    txtApellidoMaterno.Enabled = True
                    txtApellidoPaterno.Enabled = True
                    txtNombres.Enabled = True
                    gluFuenteReclutamiento.Enabled = True
                    txtTelefonoFijo.Enabled = True
                    txtTelefonoCelular.Enabled = True
                    txtTelefonoCelular2.Enabled = True

                    txtNumeroIdentidad.Enabled = False
                    gluTipoIdentidad.Enabled = False
                    GroupControl1.Visible = True
                    HistorialMemorandum(idempleado)
                End If
            End If
            'BDCentralDAO.UpdatePostulanteNoMasivoEstadoAsignacion(PostulanteNoMasivoBE)
            'limpiar()
            'GridControl1.Visible = False
            'inabilitartext()
            'gluTipoIdentidad.Enabled = True
            'txtNumeroIdentidad.Enabled = True
            'MessageBox.Show("Exito al traer postulante.")
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
        gluTipoIdentidad.Enabled = True
        txtNumeroIdentidad.Enabled = True
        txtTelefonoFijo.Enabled = False
        txtApellidoMaterno.Enabled = False
        txtApellidoPaterno.Enabled = False
        txtNombres.Enabled = False
        gluFuenteReclutamiento.Enabled = False
        txtTelefonoCelular.Enabled = False
        txtTelefonoCelular2.Enabled = False
        GroupControl1.Visible = False
    End Sub
End Class