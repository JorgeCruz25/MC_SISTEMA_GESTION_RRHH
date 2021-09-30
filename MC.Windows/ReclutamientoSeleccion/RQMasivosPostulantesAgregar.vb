Imports MC.Data
Imports MC.Framework

Public Class RQMasivosPostulantesAgregar

    Dim PostulanteMasivoBE As New PostulanteMasivoBE
    Dim IdFuente As Integer = 0
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridViewColumn(RepositoryItemGridLookUpEditTipoIdentidadView, "IDTIPOIDENTIDAD", "IDTIPOIDENTIDAD", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
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

    Private Sub PostulantesMasivosAgregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarFuenteReclutamientoDetalle()
    End Sub
    Private Sub HistorialMemorandum(ByVal IDEMPLEADO As Int32)
        GridControl1.DataSource = PrestamoDAO.GetHistorialMemorandumByID(IDEMPLEADO)
    End Sub
    Private Sub inabilitartext()
        txtApellidoMaterno.Enabled = False
        txtApellidoPaterno.Enabled = False
        txtNombres.Enabled = False
        gluFuenteReclutamientoDetalle.Enabled = False
        txtTelefono.Enabled = False
    End Sub

    Private Sub ListarFuenteReclutamientoDetalle()
        gluFuenteReclutamientoDetalle.Properties.DataSource = BDCentralDAO.GetFuenteReclutamientoDetalleList
        gluFuenteReclutamientoDetalle.Properties.ValueMember = "IDFUENTEDETALLE"
        gluFuenteReclutamientoDetalle.Properties.DisplayMember = "DESCRIPCION"
    End Sub

    Private Sub gluFuenteReclutamientoDetalle_EditValueChanged(sender As Object, e As EventArgs) Handles gluFuenteReclutamientoDetalle.EditValueChanged
        Dim idfuentedetalle As Integer
        idfuentedetalle = gluFuenteReclutamientoDetalle.EditValue
        IdFuente = BDCentralDAO.GetObtenerIDFuente(idfuentedetalle)
    End Sub

    Private Sub btnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick

        If txtApellidoPaterno.Text = "" Then
            DxErrorProvider1.SetError(txtApellidoPaterno, "Información Requerida")
            Exit Sub
        End If

        If txtApellidoMaterno.Text = "" Then
            DxErrorProvider1.SetError(txtApellidoMaterno, "Información Requerida")
            Exit Sub
        End If

        If txtNombres.Text = "" Then
            DxErrorProvider1.SetError(txtNombres, "Información Requerida")
            Exit Sub
        End If
        If gluFuenteReclutamientoDetalle.EditValue Is Nothing Or gluFuenteReclutamientoDetalle.EditValue = 0 Then
            DxErrorProvider1.SetError(gluFuenteReclutamientoDetalle, "Información Requerida")
            Exit Sub
        End If


        With PostulanteMasivoBE


            If txtIdPostulante.Text = "" Then
                    .IDPOSTULANTEMASIVO = 0
                Else
                    .IDPOSTULANTEMASIVO = txtIdPostulante.Text
                End If

                .IDREQUERIMIENTO = 0

                If gluTipoIdentidad.EditValue Is Nothing Then
                .IDTIPODOCUMENTOIDENTIDAD = 0
            Else
                .IDTIPODOCUMENTOIDENTIDAD = gluTipoIdentidad.EditValue
            End If

            .NUMERODOCUMENTO = txtNumeroIdentidad.EditValue
            .NOMBRES = txtNombres.Text
                .APELLIDOPATERNO = txtApellidoPaterno.Text
                .APELLIDOMATERNO = txtApellidoMaterno.Text
                .TELEFONO = txtTelefono.Text
                .CORREO = ""


            .IDUBIGEO = "0"
            .FECHANACIMIENTO = "1900-01-01"
                .EDAD = "0"
                .IDSEXO = "0"
                .IDCARGO = BDCentralDAO.IdRequerimientoCargo
                .IDCARGO2 = "0"

                .IDFUENTE = IdFuente

                If gluFuenteReclutamientoDetalle.EditValue Is Nothing Then
                    .IDFUENTEDETALLE = "0"
                Else
                    .IDFUENTEDETALLE = gluFuenteReclutamientoDetalle.EditValue
                End If

                .IDCONCLUSION = "0"
                .IDCONCLUSIONDETALLE = "0"
                .IDTIENDA = "0"
                .FECHACONVOCATORIA = "1900-01-01"
                .FECHAEVALUACION = "1900-01-01"
                .OBSERVACION = ""
                .IDTURNO = "0"
                .FECHAFIRMACONTRATO = "1900-01-01"
                .FECHAENVIOCORREO = "1900-01-01"
                .FECHAINGRESOTIENDAPROGRAMADO = "1900-01-01"
                .FECHARESPUESTACORREO = "1900-01-01"
                .FECHAINGRESOTIENDAREAL = "1900-01-01"
                .SEGUIMIENTOQUINCENALFECHA = "1900-01-01"
                .IDCONDICIONACTUAL = "0"
                .SEGUIMIENTOQUINCENALOBSERVACION = ""
                .ESTADOASIGNACION = False

        End With

        'If txtNroIdentidad.Text = "" Then
        '    BDCentralDAO.PostulanteMasivoInsert(PostulanteMasivoBE)
        '    limpiar()
        '    MessageBox.Show("Registro Guardado.")
        'Else
        Dim Result As String = BDCentralDAO.ValidarDNIMasivos(PostulanteMasivoBE.IDTIPODOCUMENTOIDENTIDAD, PostulanteMasivoBE.NUMERODOCUMENTO)
        If Result = 0 Then
            '         BDCentralDAO
            If BDCentralDAO.PostulanteMasivoInsert(PostulanteMasivoBE) Then

                limpiar()
                GridControl1.Visible = False
                inabilitartext()
                gluTipoIdentidad.Enabled = True
                txtNumeroIdentidad.Enabled = True
                MessageBox.Show("Registro Guardado.")
            End If
            ''UpdatePostulanteMasivoEstadoAsignacion

        ElseIf Result = 1 Then
            If BDCentralDAO.PostulanteMasivoInsert(PostulanteMasivoBE) Then
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
            BDCentralDAO.UpdatePostulanteMasivoEstadoAsignacion(PostulanteMasivoBE.IDPOSTULANTEMASIVO)
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
        txtNumeroIdentidad.EditValue = ""
        gluFuenteReclutamientoDetalle.EditValue = Nothing
        txtTelefono.Text = ""
        'gluTipoIdentidad.EditValue.Focus()
        IdFuente = 0
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim NUMEROIDENTIDAD As String = txtNumeroIdentidad.EditValue
        Dim TIPOIDENTIDAD As Integer = gluTipoIdentidad.EditValue

        If NUMEROIDENTIDAD Is Nothing Or NUMEROIDENTIDAD = "" Then
            MessageBox.Show("INGRESE EL NUMERO DE IDENTIDAD")
            Exit Sub
        End If
        If gluTipoIdentidad.EditValue Is Nothing Then
            MessageBox.Show("SELECCIONE EL TIPO DE IDENTIDAD")
            Exit Sub
        End If

        Dim Result As String = BDCentralDAO.ValidarDNIMasivos(TIPOIDENTIDAD, NUMEROIDENTIDAD)
        If Result = 0 Then
            If MessageBox.Show("Este postulante ya ha laborado en la empresa y se encuentra cesado,pero no como un postulante. ¿Desea cargar sus datos?", "Registro de Postulante", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                '         BDCentralDAO
                Dim dt As DataTable = BDCentralDAO.GetCargarDatosEmpleadoMasivoGetId(TIPOIDENTIDAD, NUMEROIDENTIDAD)
                If dt.Rows.Count > 0 Then
                    Dim idempleado As Integer = dt.Rows(0).Item("IDEMPLEADO")
                    txtIdPostulante.EditValue = dt.Rows(0).Item("IDPOSTULANTEMASIVO")
                    txtApellidoMaterno.EditValue = dt.Rows(0).Item("APELLIDOMATERNO")
                    txtApellidoPaterno.EditValue = dt.Rows(0).Item("APELLIDOPATERNO")
                    txtNombres.EditValue = dt.Rows(0).Item("NOMBRES")
                    txtTelefono.EditValue = dt.Rows(0).Item("TELEFONO")
                    txtNumeroIdentidad.EditValue = dt.Rows(0).Item("NUMERODOCUMENTO")
                    gluFuenteReclutamientoDetalle.Enabled = True
                    txtTelefono.Enabled = True
                    txtApellidoMaterno.Enabled = True
                    txtApellidoPaterno.Enabled = True
                    txtNombres.Enabled = True
                    txtNumeroIdentidad.Enabled = False
                    gluTipoIdentidad.Enabled = False
                    GroupControl1.Visible = True
                    HistorialMemorandum(idempleado)
                End If
            End If

        ElseIf Result = 1 Then
            txtTelefono.Enabled = True
            txtApellidoMaterno.Enabled = True
            txtApellidoPaterno.Enabled = True
            txtNombres.Enabled = True
            gluFuenteReclutamientoDetalle.Enabled = True
            txtNumeroIdentidad.Enabled = False
            gluTipoIdentidad.Enabled = False
        ElseIf Result = 2 Then
            MessageBox.Show("Postulante ya existe")
        ElseIf Result = 3 Or Result = 4 Then
            MessageBox.Show("el postulante se encuentra laborando")
        ElseIf Result = 5 Then
            ' MessageBox.Show("El postulante actualmente se encuentra cesado")
            If MessageBox.Show("El postulante actualmente se encuentra cesado. ¿Desea cargar sus datos?", "Registro de Postulante", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                '         BDCentralDAO
                Dim dt As DataTable = BDCentralDAO.GetCargarDatosEmpleadoMasivoGetId(TIPOIDENTIDAD, NUMEROIDENTIDAD)
                If dt.Rows.Count > 0 Then
                    Dim idempleado As Integer = dt.Rows(0).Item("IDEMPLEADO")
                    txtIdPostulante.EditValue = dt.Rows(0).Item("IDPOSTULANTEMASIVO")
                    txtApellidoMaterno.EditValue = dt.Rows(0).Item("APELLIDOMATERNO")
                    txtApellidoPaterno.EditValue = dt.Rows(0).Item("APELLIDOPATERNO")
                    txtNombres.EditValue = dt.Rows(0).Item("NOMBRES")
                    txtTelefono.EditValue = dt.Rows(0).Item("TELEFONO")
                    txtNumeroIdentidad.EditValue = dt.Rows(0).Item("NUMERODOCUMENTO")
                    gluFuenteReclutamientoDetalle.Enabled = True
                    txtTelefono.Enabled = True
                    txtApellidoMaterno.Enabled = True
                    txtApellidoPaterno.Enabled = True
                    txtNombres.Enabled = True
                    txtNumeroIdentidad.Enabled = False
                    gluTipoIdentidad.Enabled = False
                    GroupControl1.Visible = True
                    HistorialMemorandum(idempleado)
                End If
            End If
        End If


    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
        gluTipoIdentidad.Enabled = True
        txtNumeroIdentidad.Enabled = True
        txtTelefono.Enabled = False
        txtApellidoMaterno.Enabled = False
        txtApellidoPaterno.Enabled = False
        txtNombres.Enabled = False
        gluFuenteReclutamientoDetalle.Enabled = False
        GroupControl1.Visible = False
    End Sub
End Class