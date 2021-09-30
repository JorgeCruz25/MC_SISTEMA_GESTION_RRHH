Imports MC.Data
Imports MC.Framework
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Data.Filtering
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid

Public Class RQNoMasivosPostulantesBuscar

    Private Sub PostulantesNoMasivosBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridView1.Columns(0).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(1).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(2).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(3).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(4).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(5).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(6).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(7).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left

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

        GridControl1.DataSource = BDCentralDAO.GetPostulantesNoMasivosListBuscar(BDCentralDAO.IdRequerimiento, BDCentralDAO.IdRequerimientoCargo)
    End Sub

    Private Sub btnAsignar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAsignar.ItemClick
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()

        GridView1.ClearColumnsFilter()
        GridView1.FindFilterText = ""

        For j As Integer = 0 To GridView1.RowCount - 1
            Dim ESTADOTEMP As Boolean
            Dim IDPOSTULANTENOMASIVO As Integer
            IDPOSTULANTENOMASIVO = GridView1.GetRowCellValue(j, "IDPOSTULANTENOMASIVO")
            ESTADOTEMP = If(GridView1.GetRowCellValue(j, "ESTADOASIGNACIONTEMP").ToString = "False", 0, 1)

            If ESTADOTEMP Then
                BDCentralDAO.PostulanteNoMasivoUpdateRequerimiento(IDPOSTULANTENOMASIVO, BDCentralDAO.IdRequerimiento, BDCentralDAO.IdRequerimientoCargo)
            End If
        Next

        Me.Close()
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

End Class