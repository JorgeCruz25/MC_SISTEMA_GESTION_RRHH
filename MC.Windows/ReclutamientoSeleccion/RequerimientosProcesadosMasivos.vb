Imports MC.Data
Imports MC.Framework

Public Class RequerimientosProcesadosMasivos

    Dim PostulanteMasivoBE As New PostulanteMasivoBE

    Private Sub RequerimientoMasivoPostulante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridView1.Columns(0).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(1).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(2).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(3).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(4).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(5).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(6).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(7).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(8).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left

        RepositoryItemGridLookUpEditTipoIdentidad.DataSource = BDCentralDAO.GetTipoIdentidadList
        RepositoryItemGridLookUpEditTipoIdentidad.ValueMember = "IDTIPODOCUMENTOIDENTIDAD"
        RepositoryItemGridLookUpEditTipoIdentidad.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditDistrito.DataSource = BDCentralDAO.GetDistritoList
        RepositoryItemGridLookUpEditDistrito.ValueMember = "IDUBIGEO"
        RepositoryItemGridLookUpEditDistrito.DisplayMember = "DISTRITO"

        RepositoryItemGridLookUpEditSexo.DataSource = BDCentralDAO.GetSexoList
        RepositoryItemGridLookUpEditSexo.ValueMember = "IDSEXO"
        RepositoryItemGridLookUpEditSexo.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditCargo.DataSource = BDCentralDAO.GetCargoList
        RepositoryItemGridLookUpEditCargo.ValueMember = "IDCARGO"
        RepositoryItemGridLookUpEditCargo.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditCargo2.DataSource = BDCentralDAO.GetCargoList
        RepositoryItemGridLookUpEditCargo2.ValueMember = "IDCARGO"
        RepositoryItemGridLookUpEditCargo2.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditFuente.DataSource = BDCentralDAO.GetFuenteReclutamientoList
        RepositoryItemGridLookUpEditFuente.ValueMember = "IDFUENTE"
        RepositoryItemGridLookUpEditFuente.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditFuenteDetalle.DataSource = BDCentralDAO.GetFuenteReclutamientoDetalleList
        RepositoryItemGridLookUpEditFuenteDetalle.ValueMember = "IDFUENTEDETALLE"
        RepositoryItemGridLookUpEditFuenteDetalle.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditConclusion.DataSource = BDCentralDAO.GetConclusionList
        RepositoryItemGridLookUpEditConclusion.ValueMember = "IDCONCLUSION"
        RepositoryItemGridLookUpEditConclusion.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditConclusionDetalle.DataSource = BDCentralDAO.GetConclusionDetalleList
        RepositoryItemGridLookUpEditConclusionDetalle.ValueMember = "IDCONCLUSIONDETALLE"
        RepositoryItemGridLookUpEditConclusionDetalle.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditTienda.DataSource = BDCentralDAO.GetLocalListAll
        RepositoryItemGridLookUpEditTienda.ValueMember = "IDLOCAL"
        RepositoryItemGridLookUpEditTienda.DisplayMember = "LOCAL"

        RepositoryItemGridLookUpEditTurno.DataSource = BDCentralDAO.GetTunoPersonalList
        RepositoryItemGridLookUpEditTurno.ValueMember = "IDTURNO"
        RepositoryItemGridLookUpEditTurno.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditCondicionActual.DataSource = BDCentralDAO.GetEstadoCondicionActualList
        RepositoryItemGridLookUpEditCondicionActual.ValueMember = "IDCONDICIONACTUAL"
        RepositoryItemGridLookUpEditCondicionActual.DisplayMember = "DESCRIPCION"

        btnFechaInicial.EditValue = DateTime.Now.Date.AddDays(-30)
        btnFechaFinal.EditValue = DateTime.Now.Date

        AddHandler btnFechaFinal.EditValueChanged, AddressOf Refrescar

        Refrescar()
    End Sub
    Private Sub inabilitarbotones()
        btnExportar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub
    Private Sub Refrescar()
        Try
            inabilitarbotones()
            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(RibbonControl, dtAccionesUsuario)
            GridControl1.DataSource = BDCentralDAO.GetRequerimientosMasivosProcesados(btnFechaInicial.EditValue, btnFechaFinal.EditValue)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBuscar.ItemClick
        ActualizarEdicionGrilla()
        Refrescar()
    End Sub

    Private Sub ActualizarEdicionGrilla()
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()
    End Sub

    Private Sub GridView1_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView1.RowUpdated
        Cursor = Cursors.WaitCursor

        With PostulanteMasivoBE
            .IDPOSTULANTEMASIVO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDPOSTULANTEMASIVO")
            .IDTIPODOCUMENTOIDENTIDAD = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDTIPODOCUMENTOIDENTIDAD").ToString
            .NUMERODOCUMENTO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "NUMERODOCUMENTO").ToString
            .NOMBRES = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "NOMBRES").ToString
            .APELLIDOPATERNO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "APELLIDOPATERNO").ToString
            .APELLIDOMATERNO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "APELLIDOMATERNO").ToString
            .TELEFONO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "TELEFONO").ToString
            .CORREO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CORREO").ToString

            .IDUBIGEO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDUBIGEO")

            Dim xUbigeo As Integer
            Dim xProvincia As String
            Dim xDepartamento As String
            Dim dtUbigeo As New DataTable
            If .IDUBIGEO = 0 Then
                xProvincia = ""
                xDepartamento = ""
            Else
                xUbigeo = .IDUBIGEO
                dtUbigeo = BDCentralDAO.GetDistritoListID(xUbigeo)
                xProvincia = dtUbigeo.Rows(0)("PROVINCIA").ToString
                xDepartamento = dtUbigeo.Rows(0)("DEPARTAMENTO").ToString
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "PROVINCIA", xProvincia)
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "DEPARTAMENTO", xDepartamento)
            End If
            .PROVINCIA = xProvincia
            .DEPARTAMENTO = xDepartamento

            .FECHANACIMIENTO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHANACIMIENTO").ToString

            Dim xdate As Date
            Dim xYearNacimiento As Integer
            Dim xYearActual As Integer
            Dim xEdad As Integer

            If .FECHANACIMIENTO = "1900-01-01" Then
                xEdad = 0
            Else
                xdate = .FECHANACIMIENTO
                xYearNacimiento = Year(xdate)
                xYearActual = Year(Now)
                xEdad = xYearActual - xYearNacimiento
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "EDAD", xEdad)
            End If

            .EDAD = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "EDAD").ToString
            .IDSEXO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDSEXO")
            .IDCARGO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDCARGO")
            .IDCARGO2 = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDCARGO2")

            .IDFUENTEDETALLE = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDFUENTEDETALLE")

            If .IDFUENTEDETALLE = 0 Then
                .IDFUENTE = 0
            Else
                Dim xIDFUENTE As Integer
                xIDFUENTE = BDCentralDAO.GetObtenerIDFuente(.IDFUENTEDETALLE)
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "IDFUENTE", xIDFUENTE)
            End If
            .IDFUENTE = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDFUENTE")

            .IDCONCLUSIONDETALLE = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDCONCLUSIONDETALLE")

            If .IDCONCLUSIONDETALLE = 0 Then
                .IDCONCLUSION = 0
            Else
                Dim xIDCONCLUSION As Integer
                xIDCONCLUSION = BDCentralDAO.GetObtenerIDConlusion(.IDCONCLUSIONDETALLE)
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "IDCONCLUSION", xIDCONCLUSION)
            End If
            .IDCONCLUSION = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDCONCLUSION")

            .IDTIENDA = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDTIENDA")
            .FECHACONVOCATORIA = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHACONVOCATORIA")
            .FECHAEVALUACION = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAEVALUACION")
            .OBSERVACION = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "OBSERVACION").ToString
            .IDTURNO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDTURNO")
            .FECHAFIRMACONTRATO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAFIRMACONTRATO")
            .FECHAENVIOCORREO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAENVIACORREO")
            .FECHAINGRESOTIENDAPROGRAMADO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAINGRESOTIENDAPROGRAMADO")
            .FECHARESPUESTACORREO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHARESPUESTACORREO")
            .FECHAINGRESOTIENDAREAL = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAINGRESOTIENDAREAL")
            .SEGUIMIENTOQUINCENALFECHA = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "SEGUIMIENTOQUINCENALFECHA")
            .IDCONDICIONACTUAL = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDCONDICIONACTUAL")
            .SEGUIMIENTOQUINCENALOBSERVACION = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "SEGUIMIENTOQUINCENALOBSERVACION").ToString
            .ESTADOASIGNACION = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ESTADOASIGNACION")
        End With

        BDCentralDAO.PostulanteMasivoUpdate(PostulanteMasivoBE)

        Cursor = Cursors.Default
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        ActualizarEdicionGrilla()
        Me.Close()
    End Sub

    Private Sub btnExportar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportar.ItemClick
        If GridView1.RowCount > 0 Then
            Try
                Dim ruta As String
                ruta = My.Application.Info.DirectoryPath() + "\listado.xlsx"
                GridControl1.ExportToXlsx(ruta)
                Process.Start(ruta)
            Catch ex As Exception
                MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
            End Try
        End If
    End Sub

    Private Sub RequerimientosProcesadosMasivos_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

End Class