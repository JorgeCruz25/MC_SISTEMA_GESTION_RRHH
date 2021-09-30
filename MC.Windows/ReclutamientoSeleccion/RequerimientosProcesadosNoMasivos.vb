Imports System.IO
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports MC.Data
Imports MC.Framework

Public Class RequerimientosProcesadosNoMasivos
    Dim LISTADOPOSTULANTES As String
    Private Sub HistorialRequerimientosNoMasivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ControlesDevExpress.InitGridViewColumn(GridView1, "ID", "IDREQUERIMIENTO", 60, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO REQUERIMIENTO", "NUMEROREQUERIMIENTOPERSONAL", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MOTIVO", "MOTIVO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA CIERRE", "FECHACIERRE", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ''-----------------INICIO-----------------
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO IDENTIDAD", "TIPODOCUMENTOIDENTOIDENTIDAD", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NRO DOCUMENTO", "NUMERODOCUMENTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBRES", "NOMBRES", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "AP. PATERNO", "APELLIDOPATERNO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "AP. MATERNO", "APELLIDOMATERNO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 160, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RUC", "IDTRIBUTARIO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "SOLICITANTE", "SOLICITANTENOMBRE", 260, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TELEFONO", "TELEFONOFIJO", 160, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CELULAR 1", "TELEFONOCELULAR", 160, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CELULAR 2", "TELEFONOCELULAR2", 160, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CORREO", "CORREO", 160, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA DE NAC.", "FECHANACIMIENTO", 160, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO REQUERIDO", "CARGOREQUERIDO", 170, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "HORAS", "HORAS", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TURNO", "TURNO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "OBSERVACION", "OBSERVACION", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FTE. RECLUTAMIENTO", "FUENTERECLUTAMIENTO", 140, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EXP. SALARIAL", "SALARIO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO", "ESTADOPOSTULANTE", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "HORA", "HORA", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FEC. CONVOCATORIA 1", "FECHACONVOCATORIA1", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FEC. CONVOCATORIA 2", "FECHACONVOCATORIA2", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FEC. CONVOCATORIA 3", "FECHACONVOCATORIA3", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "INF. CREDITICIA", "ESTADOCREDITICIO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MONTO ADEUDADO", "MONTOADEUDADO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ENTIDAD", "ENTIDAD", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DIA VENCIMIENTO", "DIAVENCIMIENTO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EVAL. PSICOLOGICO ", "ESTADOPSICOLOGICO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        ControlesDevExpress.InitGridViewColumn(GridView1, "EVAL. ASSESMENT", "ESTADOASSESMENT", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EVAL. ENTREVISTA", "ESTADOENTREVISTASELECCION", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "OBSERVACIÓN 2", "OBSERVACION2", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ENTREVISTA PREVIA", "ESTADOENTREVISTAPREVIA", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ENTREVISTA FINAL", "ESTADOENTREVISTAAREAFINAL", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "OBSERVACIÓN 3", "OBSERVACION3", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        ControlesDevExpress.InitGridViewColumn(GridView1, "USUARIO ATENCION", "USUARIOATENCION", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO", "ESTADOREQUERIMIENTO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        ''-----------------FIN-----------------



        'ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA", "FECHA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 160, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "RUC", "IDTRIBUTARIO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "SOLICITANTE", "SOLICITANTENOMBRE", 260, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO REQUERIDO", "CARGOREQUERIDO", 170, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "NRO VACANTES", "NUMEROVACANTES", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "HORAS", "HORAS", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "MOTIVO", "MOTIVO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "TURNO", "TURNO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "OBSERVACION", "OBSERVACION", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA INICIO", "FECHAINICIO", 160, True, ControlesDevExpress.eGridViewFormato.FechaHora, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA CIERRE", "FECHACIERRE", 160, True, ControlesDevExpress.eGridViewFormato.FechaHora, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "USUARIO ATENCION", "USUARIOATENCION", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO", "ESTADOREQUERIMIENTO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        btnFechaInicial.EditValue = DateTime.Now.Date.AddDays(-30)
        btnFechaFinal.EditValue = DateTime.Now.Date

        AddHandler btnFechaFinal.EditValueChanged, AddressOf Refrescar

        Refrescar()

        GridView1.Columns(0).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(1).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(2).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(3).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(4).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(5).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(6).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(7).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(8).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
    End Sub

    Private Sub btnVerPostulante_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVerPostulante.ItemClick
        BDCentralDAO.IdRequerimiento = GridView1.GetFocusedRowCellValue("IDREQUERIMIENTO")

        Dim MiForm As New RQNoMasivosVerPostulantes
        MiForm.ShowDialog()

        Cursor = Cursors.WaitCursor
        BDCentralDAO.IdRequerimiento = 0
        Cursor = Cursors.Default
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
            GridControl1.DataSource = BDCentralDAO.GetRequerimientosNoMasivosProcesados(btnFechaInicial.EditValue, btnFechaFinal.EditValue)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBuscar.ItemClick
        Refrescar()
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub RequerimientosProcesadosNoMasivos_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub btnExportar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportar.ItemClick
        'Dim IDREQUERIMIENTO As Integer
        'For i As Integer = 0 To GridView1.RowCount - 1
        '    IDREQUERIMIENTO = GridView1.GetRowCellValue(i, "IDREQUERIMIENTO")
        '    LISTADOPOSTULANTES = String.Concat(LISTADOPOSTULANTES, ", ", IDREQUERIMIENTO)
        '    LISTADOPOSTULANTES = Replace(LISTADOPOSTULANTES, " ", "")
        'Next
        'If LISTADOPOSTULANTES <> "" Or LISTADOPOSTULANTES IsNot Nothing Then
        '    SplashScreenManager.ShowForm(GetType(WaitForm))
        '    Dim dt As New DataTable
        '    Dim Ruta As String = Path.GetTempPath + "PostulantesNoMasivosProcesados" + ".xlsx"
        '    dt = BDCentralDAO.PostulantesNoMasivosProcesadosList(LISTADOPOSTULANTES)
        '    Tools.ExportToExcel(dt, Ruta, "Hoja")
        '    Process.Start(Ruta)
        '    SplashScreenManager.CloseForm()
        '    LISTADOPOSTULANTES = ""
        'End If
        If GridView1.RowCount > 0 Then
            Try
                Dim ruta As String
                ruta = My.Application.Info.DirectoryPath() + "\PostulantesNoMasivoProcesados.xlsx"
                GridControl1.ExportToXlsx(ruta)
                Process.Start(ruta)
            Catch ex As Exception
                MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
            End Try
        End If
    End Sub
End Class