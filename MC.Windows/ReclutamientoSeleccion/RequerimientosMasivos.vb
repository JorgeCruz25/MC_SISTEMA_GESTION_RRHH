Imports MC.Data
Imports MC.Framework
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Data.Filtering
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid

Public Class RequerimientosMasivos

    Private Sub RequerimientosMasivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        ControlesDevExpress.InitGridViewColumn(GridView1, "ID", "IDREQUERIMIENTO", 60, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO REQUERIMIENTO", "NUMEROREQUERIMIENTOPERSONAL", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA SOLICITUD", "FECHA", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA APROBADO", "FECHAAPROBADO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 160, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "SUPERVISOR", "SUPERVISOR", 260, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "RUC", "IDTRIBUTARIO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "SOLICITANTE", "SOLICITANTENOMBRE", 260, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO REQUERIDO", "CARGOREQUERIDO", 170, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NRO VACANTES", "NUMEROVACANTES", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "HORAS", "HORAS", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MOTIVO", "MOTIVO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TURNO", "TURNO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "OBSERVACION", "OBSERVACION", 260, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDLOCAL", "IDLOCAL", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDTURNO", "IDTURNO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        Refrescar()
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub
    Private Sub inabilitarbotones()
        btnLiberar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnPostulantesMasivos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub
    Private Sub Refrescar()
        inabilitarbotones()
        Dim dtAccionesUsuario As DataTable
        dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
        Tools.AccionesUsuarioRibbon(RibbonControl, dtAccionesUsuario)
        GridControl1.DataSource = BDCentralDAO.GetRequerimientosMasivosAprobadosList
    End Sub

    Private Sub btnPostulantesMasivos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPostulantesMasivos.ItemClick
        BDCentralDAO.IdRequerimiento = GridView1.GetFocusedRowCellValue("IDREQUERIMIENTO")
        BDCentralDAO.IdRequerimientoCargoMasivo = GridView1.GetFocusedRowCellValue("IDCARGOREQUERIDO")
        BDCentralDAO.IdTiendaRequerimiento = GridView1.GetFocusedRowCellValue("IDLOCAL")
        BDCentralDAO.IdTurnoRequerimiento = GridView1.GetFocusedRowCellValue("IDTURNO")
        BDCentralDAO.RazonComercial = GridView1.GetFocusedRowCellValue("RAZONCOMERCIAL")
        BDCentralDAO.CargoRequerido = GridView1.GetFocusedRowCellValue("CARGOREQUERIDO")
        Dim MiForm As New RQMasivosPostulantes
        MiForm.ShowDialog()

        BDCentralDAO.IdRequerimiento = 0
        BDCentralDAO.IdRequerimientoCargoMasivo = 0
        GridControl1.DataSource = BDCentralDAO.GetRequerimientosMasivosAprobadosList
    End Sub

    Private Sub btnLiberar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLiberar.ItemClick

        If GridView1.RowCount > 0 Then

            If MessageBox.Show("Desea liberar el requerimiento?", "Liberar Requerimiento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Cursor = Cursors.WaitCursor

                Dim dtreq As DataTable
                Dim xIdRequerimientoPersonal As Integer
                Dim xCierre As Integer

                dtreq = BDCentralDAO.RequerimientoPersonalValidarProcesarMasivo(GridView1.GetFocusedRowCellValue("IDREQUERIMIENTO"))
                xIdRequerimientoPersonal = dtreq.Rows(0)(0)
                xCierre = dtreq.Rows(0)(1)

                'ACTUALIZAR RQ EN CONTROL ATENCIONES
                If BDCentralDAO.RequerimientoPersonalUpdateVacantesAtendidas(xIdRequerimientoPersonal, 0, xCierre) Then
                    BDCentralDAO.RequerimientoPersonalUpdateEstadoProcesarMasivo(0, GridView1.GetFocusedRowCellValue("IDREQUERIMIENTO"))
                Else
                    Cursor = Cursors.Default
                    MessageBox.Show("Problemas de conexión...", "Control de Atenciones")
                    Exit Sub
                End If

                GridControl1.DataSource = BDCentralDAO.GetRequerimientosMasivosAprobadosList

                Cursor = Cursors.Default
            End If
        End If

    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub RequerimientosMasivos_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub


End Class