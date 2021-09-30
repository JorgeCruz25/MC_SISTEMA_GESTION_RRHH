Imports MC.Data
Imports MC.Framework
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Data.Filtering
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid

Public Class RequerimientosNoMasivos

    Private Sub RequerimientosNoMasivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlesDevExpress.InitGridViewColumn(GridView1, "ID", "IDREQUERIMIENTO", 60, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO REQUERIMIENTO", "NUMEROREQUERIMIENTOPERSONAL", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA SOLICITUD", "FECHA", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA APROBADO", "FECHAAPROBADO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 160, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RUC", "IDTRIBUTARIO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "SOLICITANTE", "SOLICITANTENOMBRE", 260, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO REQUERIDO", "CARGOREQUERIDO", 170, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NRO VACANTES", "NUMEROVACANTES", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "HORAS", "HORAS", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MOTIVO", "MOTIVO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TURNO", "TURNO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "OBSERVACION", "OBSERVACION", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA INICIO", "FECHAINICIO", 160, True, ControlesDevExpress.eGridViewFormato.FechaHora, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "USUARIO ATENCION", "USUARIOATENCION", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO", "ESTADOREQUERIMIENTO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        Refrescar()
    End Sub
    Private Sub Refrescar()
        inabilitarbotones()
        Dim dtAccionesUsuario As DataTable
        dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
        Tools.AccionesUsuarioRibbon(RibbonControl, dtAccionesUsuario)
        GridControl1.DataSource = BDCentralDAO.GetRequerimientosNoMasivosAprobadosList
    End Sub
    Private Sub inabilitarbotones()
        btnAsignarRequerimiento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnLiberar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnDesarrollarProceso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub
    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub

    Private Sub btnAsignarRequerimiento_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAsignarRequerimiento.ItemClick

        If GridView1.RowCount > 0 Then
            If GridView1.GetFocusedRowCellValue("IDESTADOREQUERIMIENTO") = 1 Then
                If MessageBox.Show("Desea asignarse el requerimiento?", "Asignar Requerimiento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    BDCentralDAO.IdRequerimiento = GridView1.GetFocusedRowCellValue("IDREQUERIMIENTO")
                    BDCentralDAO.IdRequerimientoCargo = GridView1.GetFocusedRowCellValue("IDCARGOREQUERIDO")

                    BDCentralDAO.RequerimientoPersonalUpdateEstadoAsignacion(BDCentralDAO.IdRequerimiento)
                    GridControl1.DataSource = BDCentralDAO.GetRequerimientosNoMasivosAprobadosList
                End If
            End If
        End If

    End Sub

    Private Sub btnDesarrollarProceso_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDesarrollarProceso.ItemClick

        If GridView1.RowCount > 0 Then
            If GridView1.GetFocusedRowCellValue("IDESTADOREQUERIMIENTO") = 2 Then
                BDCentralDAO.IdRequerimiento = GridView1.GetFocusedRowCellValue("IDREQUERIMIENTO")
                BDCentralDAO.IdRequerimientoCargo = GridView1.GetFocusedRowCellValue("IDCARGOREQUERIDO")
                BDCentralDAO.NroVacantesNoMasivos = GridView1.GetFocusedRowCellValue("NUMEROVACANTES")

                Dim MiForm As New RQNoMasivosPostulantes
                MiForm.ShowDialog()
                Cursor = Cursors.WaitCursor
                BDCentralDAO.IdRequerimiento = 0
                BDCentralDAO.IdRequerimientoCargo = 0
                BDCentralDAO.NroVacantesNoMasivos = 0
                GridControl1.DataSource = BDCentralDAO.GetRequerimientosNoMasivosAprobadosList
                Cursor = Cursors.Default
            Else
                MessageBox.Show("El requerimiento no se encuentra Asignado")
            End If
        End If

    End Sub

    Private Sub btnLiberar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLiberar.ItemClick

        If GridView1.RowCount > 0 Then
            If MessageBox.Show("Desea liberar el requerimiento?", "Liberar Requerimiento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Cursor = Cursors.WaitCursor

                Dim dtrq As DataTable
                Dim xIdRequerimientoPersonal As Integer
                dtrq = BDCentralDAO.RequerimientoPersonalValidarNoMasivo(GridView1.GetFocusedRowCellValue("IDREQUERIMIENTO"))
                xIdRequerimientoPersonal = dtrq.Rows(0)(0)

                'ACTUALIZAR RQ EN CONTROL ATENCIONES
                If BDCentralDAO.RequerimientoPersonalUpdateVacantesAtendidas(xIdRequerimientoPersonal, 0, 1) Then
                    BDCentralDAO.LiberarRequerimientoNoMasivo(GridView1.GetFocusedRowCellValue("IDREQUERIMIENTO"))
                Else
                    Cursor = Cursors.Default
                    MessageBox.Show("Problemas de conexión...", "Control de Atenciones")
                    Exit Sub
                End If

                GridControl1.DataSource = BDCentralDAO.GetRequerimientosNoMasivosAprobadosList

                Cursor = Cursors.Default
            End If
        End If

    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub RequerimientosNoMasivos_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

End Class