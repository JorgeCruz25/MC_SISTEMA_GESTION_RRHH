Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework
Public Class SuspensionPerfectaHistorialList
    Dim bsSuspencionPerfectaHistorial As New BindingSource
    Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ID", "IDSUSPENSIONPERFECTA", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NÚMERO SOLICITUD", "NUMEROSUSPENSIONPERFECTA", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO SOLICITUD", "TIPOSOLICITUDSOLICITADA", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "F. PERIODO INICIO", "FECHAPERIODOINICIO", 180, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "F. PERIODO FIN", "FECHAPERIODOFIN", 180, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MATRICULA", "MATRICULA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DOCUMENTO", "NUMERODOCUMENTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBRE", "NOMBRES", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "APELLIDO PATERNO", "APELLIDOPATERNO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False) '''NO BORRAR ESTO SI SE VA A USAR
        ControlesDevExpress.InitGridViewColumn(GridView1, "APELLIDO MATERNO", "APELLIDOMATERNO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO ACTUAL EMPLEADO", "ESTADOACTUALEMPLEADO", 190, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO", "CARGO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO SOLICITUD", "ESTADOSOLICITUD", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "USUARIO REGISTRO", "USUARIOREGISTRO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA REGISTRO", "FECHAREGISTRO", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        ControlesDevExpress.InitGridViewColumn(GridView1, "USUARIO PROCESO", "USUARIOPROCESORRHH", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA PROCESO", "FECHAAPROCESADORRHH", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "USUARIO ANULADO", "USUARIOANULADO", 130, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA ANULADO", "FECHAANULADORRHH", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHAACTUAL", "FECHAACTUAL", 80, False, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADOPROCESADO", "ESTADOPROCESADO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADOTERMINOSOLICITUD", "ESTADOTERMINOSOLICITUD", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDSITUACIONLABORALSOLICITUD", "IDSITUACIONLABORALSOLICITUD", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHAINICIOLICENCIA", "FECHAINICIOLICENCIA", 80, False, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDEMPLEADO", "IDEMPLEADO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDLICENCIA", "IDLICENCIA", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridView1
            .Columns("FECHAREGISTRO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOMBRES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOPATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOMATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("ESTADOACTUALEMPLEADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CARGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("USUARIOREGISTRO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With


        btnFechaInicio.EditValue = DateTime.Now.Date.AddDays(-30)
        btnFechaFin.EditValue = DateTime.Now.Date

        AddHandler btnFechaFin.EditValueChanged, AddressOf Refrescar
        AddHandler btnFechaInicio.EditValueChanged, AddressOf Refrescar
        AddHandler btnRefrescar.ItemClick, AddressOf Refrescar

        Refrescar()
    End Sub
    Public Sub Refrescar()
        Try
            GridView1.Columns.Item("FORMATO").Visible = False
            btnRevertirProceso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            btnExportar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioGrid(GridView1, dtAccionesUsuario)
            Dim dtAccionesBotones As DataTable
            dtAccionesBotones = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(Ribbon, dtAccionesBotones)
            Me.GridControl1.DataSource = bsSuspencionPerfectaHistorial
            btnRevertirProceso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            bsSuspencionPerfectaHistorial.DataSource = SuspencionPerfectaDAO.GetSuspensionPerfectaHistorialList(btnFechaInicio.EditValue, btnFechaFin.EditValue)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub

    Private Sub SuspensionPerfectaHistorialList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub btnExportar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportar.ItemClick
        If GridView1.RowCount > 0 Then
            Try
                Dim ruta As String
                ruta = My.Application.Info.DirectoryPath() + "\Historial_Suspencion_Perfecta.xlsx"
                GridControl1.ExportToXlsx(ruta)
                Process.Start(ruta)
            Catch ex As Exception
                MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
            End Try
        End If
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnRevertirProceso_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRevertirProceso.ItemClick
        Dim IDSUAPENSIONPERFECTA As Integer = GridView1.GetFocusedRowCellValue("IDSUSPENSIONPERFECTA")
        Dim NUMEROSOLICITUD As String = GridView1.GetFocusedRowCellValue("NUMEROSUSPENSIONPERFECTA")
        Dim TIPOSOLICITUD As String = GridView1.GetFocusedRowCellValue("TIPOSOLICITUDSOLICITADA")
        Dim NOMBREEMPLEADO As String = GridView1.GetFocusedRowCellValue("NOMBRES") + " " + GridView1.GetFocusedRowCellValue("APELLIDOPATERNO") + " " + GridView1.GetFocusedRowCellValue("APELLIDOMATERNO")
        Dim NUMERODOCUMENTOEMPLEADO As String = GridView1.GetFocusedRowCellValue("NUMERODOCUMENTO")
        Dim FECHAPERIODOINICIO As Date = GridView1.GetFocusedRowCellValue("FECHAPERIODOINICIO")
        Dim FECHAPERIDOFIN As Date = GridView1.GetFocusedRowCellValue("FECHAPERIODOFIN")
        Dim FECHAACTUAL As Date = GridView1.GetFocusedRowCellValue("FECHAACTUAL")
        Dim FECHAINICIOLICENCIA As Date = GridView1.GetFocusedRowCellValue("FECHAINICIOLICENCIA")
        Dim IDEMPLEADO As Integer = GridView1.GetFocusedRowCellValue("IDEMPLEADO")

        Dim IDSITUACIONLABORALSOLICITUD As Int32 = GridView1.GetFocusedRowCellValue("IDSITUACIONLABORALSOLICITUD")

        If (IDSITUACIONLABORALSOLICITUD = 4 Or IDSITUACIONLABORALSOLICITUD = 2) Then
            If GridView1.GetFocusedRowCellValue("ESTADOPROCESADO") Then
                If GridView1.GetFocusedRowCellValue("ESTADOTERMINOSOLICITUD") Then
                    If FECHAACTUAL <= FECHAPERIDOFIN And GridView1.GetFocusedRowCellValue("ESTADOPROCESADO") Then
                        Dim MiForm As New SuspensionPerfectaRevertir
                        MiForm.txtNumeroSolicitud.Text = NUMEROSOLICITUD
                        MiForm.txtNombreEmpleado.Text = NOMBREEMPLEADO
                        MiForm.txtNumeroDocumento.Text = NUMERODOCUMENTOEMPLEADO
                        MiForm.txtTipoSolicitud.Text = TIPOSOLICITUD
                        MiForm.dtFechaFin.EditValue = FECHAPERIDOFIN
                        MiForm.FechaPeriodoFin = FECHAPERIDOFIN
                        MiForm.FechaActual = FECHAACTUAL
                        MiForm.IdSuspension = IDSUAPENSIONPERFECTA
                        MiForm.IdSituacionLaboral = IDSITUACIONLABORALSOLICITUD
                        MiForm.FechaInicioLicencia = FECHAINICIOLICENCIA
                        MiForm.IdEmpleado = IDEMPLEADO
                        MiForm.StartPosition = FormStartPosition.CenterScreen
                        MiForm.ShowDialog()
                    Else
                        MessageBox.Show("EL PERIODO DE LA FECHA FIN YA CULMINO")
                    End If
                Else
                    MessageBox.Show("ESTA SOLICITUD YA SE ENCUENTRA CERRADA")
                End If
            Else
                MessageBox.Show("ESTA OPCION SOLO PROCEDE CUANDO LA SOLICITUD ES ENCUENTRA PROCESADA")
            End If
        Else
            MessageBox.Show("ESTA OPCION SOLO PROCEDE CUANDO LA SOLICITUD ES POR LICENCIA SIN GOCE(SP) O POR SUSPENSION PERFECTA")
        End If


        Refrescar()
    End Sub

    Private Sub RepositoryItemLicenciaArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemLicenciaArchivo.Click
        Dim IDSITUACIONLABORALSOLICITUD As Integer
        Dim IDLICENCIA As Integer
        IDSITUACIONLABORALSOLICITUD = GridView1.GetFocusedRowCellValue("IDSITUACIONLABORALSOLICITUD")
        IDLICENCIA = GridView1.GetFocusedRowCellValue("IDLICENCIA")
        If IDSITUACIONLABORALSOLICITUD = 4 Then
            If IDLICENCIA <> 0 Then
                Dim MiForm As New LicenciaArchivo
                Dim dt As DataTable = LicenciaDAO.ListaLicenciaAcuerdoArchivos(IDLICENCIA)
                If dt.Rows.Count <> 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim ruta As String = dt.Rows(i).Table(i)("linkdescarga").ToString
                        Dim tab As String
                        tab = "Archivo" + Convert.ToString(i + 1)
                        Dim NewTab As New XtraTabPage
                        NewTab.Name = tab
                        NewTab.Text = tab
                        MiForm.XtraTabControl1.TabPages.Add(NewTab)

                        Dim uccontrol1 As New XtraUserControlWebBrowser()
                        NewTab.Controls.Add(uccontrol1)
                        uccontrol1.Dock = DockStyle.Fill

                        uccontrol1.WebBrowser1.Show()
                        uccontrol1.WebBrowser1.Navigate(String.Format(ruta, Application.StartupPath))
                    Next
                    MiForm.ShowDialog()
                Else
                    MessageBox.Show("La solicitud no cuenta con adjunto", "Archivo de Acuerdo")
                End If
            End If
        Else
            MessageBox.Show("Para mostrar el adjunto, el tipo de solictud tiene que ser Licencia sin Goce por Suspensión Perfecta")
        End If

    End Sub

    Private Sub btnExtenderFechaFinMasiva_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExtenderFechaFinMasiva.ItemClick
        Dim MiForm As New SuspensionPerfectaMasivo
        MiForm.ShowDialog()
        Refrescar()
    End Sub
End Class