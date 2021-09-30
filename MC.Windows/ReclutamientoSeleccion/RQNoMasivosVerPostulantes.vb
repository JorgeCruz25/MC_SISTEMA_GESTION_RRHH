Imports MC.Data
Imports MC.Framework
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Data.Filtering
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid

Public Class RQNoMasivosVerPostulantes

    Dim PostulanteNoMasivoBE As New PostulanteNoMasivoBE

    Private Sub RequerimientoNoMasivoPostulante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RepositoryItemGridLookUpEditTipoIdentidad.DataSource = BDCentralDAO.GetTipoIdentidadList
        RepositoryItemGridLookUpEditTipoIdentidad.ValueMember = "IDTIPODOCUMENTOIDENTIDAD"
        RepositoryItemGridLookUpEditTipoIdentidad.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditCargo.DataSource = BDCentralDAO.GetCargoList
        RepositoryItemGridLookUpEditCargo.ValueMember = "IDCARGO"
        RepositoryItemGridLookUpEditCargo.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditFuente.DataSource = BDCentralDAO.GetFuenteReclutamientoList
        RepositoryItemGridLookUpEditFuente.ValueMember = "IDFUENTE"
        RepositoryItemGridLookUpEditFuente.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditEstado.DataSource = BDCentralDAO.GetEstadoPostulanteList
        RepositoryItemGridLookUpEditEstado.ValueMember = "IDESTADO"
        RepositoryItemGridLookUpEditEstado.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditEstadoCrediticio.DataSource = BDCentralDAO.GetEstadoCrediticioList
        RepositoryItemGridLookUpEditEstadoCrediticio.ValueMember = "IDESTADOCREDITICIO"
        RepositoryItemGridLookUpEditEstadoCrediticio.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditEstadoPsicologico.DataSource = BDCentralDAO.GetEstadoPsicologicoList
        RepositoryItemGridLookUpEditEstadoPsicologico.ValueMember = "IDESTADOPSICOLOGICO"
        RepositoryItemGridLookUpEditEstadoPsicologico.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditEstadoAssesment.DataSource = BDCentralDAO.GetEstadoAssesmentList
        RepositoryItemGridLookUpEditEstadoAssesment.ValueMember = "IDESTADOASSESMENT"
        RepositoryItemGridLookUpEditEstadoAssesment.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditEstadoEntrevistaSeleccion.DataSource = BDCentralDAO.GetEntrevistaSelecciontList
        RepositoryItemGridLookUpEditEstadoEntrevistaSeleccion.ValueMember = "IDENTREVISTASELECCION"
        RepositoryItemGridLookUpEditEstadoEntrevistaSeleccion.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditEstadoEntrevistaPrevia.DataSource = BDCentralDAO.GetEntrevistaPreviaList
        RepositoryItemGridLookUpEditEstadoEntrevistaPrevia.ValueMember = "IDENTREVISTAPREVIA"
        RepositoryItemGridLookUpEditEstadoEntrevistaPrevia.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditEstadoEntrevistaArea.DataSource = BDCentralDAO.GetEntrevistaAreaFinalList
        RepositoryItemGridLookUpEditEstadoEntrevistaArea.ValueMember = "IDENTREVISTAAREAFINAL"
        RepositoryItemGridLookUpEditEstadoEntrevistaArea.DisplayMember = "DESCRIPCION"

        GridControl1.DataSource = BDCentralDAO.GetRequerimientoNoMasivosPostulantes(BDCentralDAO.IdRequerimiento)
    End Sub

    Private Sub GridView1_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView1.RowUpdated
        Cursor = Cursors.WaitCursor

        With PostulanteNoMasivoBE
            .IDPOSTULANTENOMASIVO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDPOSTULANTENOMASIVO")
            .IDTIPODOCUMENTOIDENTIDAD = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDTIPODOCUMENTOIDENTIDAD")
            .NUMERODOCUMENTO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "NUMERODOCUMENTO").ToString
            .NOMBRES = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "NOMBRES").ToString
            .APELLIDOPATERNO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "APELLIDOPATERNO").ToString
            .APELLIDOMATERNO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "APELLIDOMATERNO").ToString
            .TELEFONOFIJO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "TELEFONOFIJO").ToString
            .TELEFONOCELULAR = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "TELEFONOCELULAR").ToString
            .TELEFONOCELULAR2 = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "TELEFONOCELULAR2").ToString
            .CORREO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CORREO").ToString
            .FECHANACIMIENTO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHANACIMIENTO")
            .IDFUENTE = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDFUENTE")
            .SALARIO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "SALARIO").ToString
            .OBSERVACION = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "OBSERVACION").ToString
            .IDESTADO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDESTADO")
            .HORA = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "HORA").ToString
            .FECHACONVOCATORIA1 = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHACONVOCATORIA1")
            .FECHACONVOCATORIA2 = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHACONVOCATORIA2")
            .FECHACONVOCATORIA3 = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHACONVOCATORIA3")
            .IDESTADOCREDITICIO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDESTADOCREDITICIO")
            .MONTOADEUDADO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "MONTOADEUDADO")
            .DIAVENCIMIENTO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DIAVENCIMIENTO")
            .ENTIDAD = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ENTIDAD")
            .IDESTADOPSICOLOGICO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDESTADOPSICOLOGICO")
            .IDESTADOASSESMENT = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDESTADOASSESMENT")
            .IDENTREVISTASELECCION = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDENTREVISTASELECCION")
            .OBSERVACION2 = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "OBSERVACION2").ToString
            .IDENTREVISTAPREVIA = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDENTREVISTAPREVIA")
            .IDENTREVISTAAREAFINAL = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDENTREVISTAAREAFINAL")
            .OBSERVACION3 = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "OBSERVACION3").ToString
            .ESTADOASIGNACION = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ESTADOASIGNACION")
        End With

        BDCentralDAO.PostulanteNoMasivoUpdate(PostulanteNoMasivoBE)

        Cursor = Cursors.Default
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

End Class