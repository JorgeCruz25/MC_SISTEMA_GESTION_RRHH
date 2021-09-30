Imports DevExpress.XtraBars
Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework
Public Class SolicitudCeseLegalList
    Dim bsEmpleadoCese As New BindingSource

    Sub New()

        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDSOLICITUDCESE", "IDSOLICITUDCESE", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDEMPLEADO", "IDEMPLEADO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO VALIDADO", "ESTADOVALIDADORRHH", 130, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO PRE-AVISO", "ESTADOVALIDADOLEGALPREAVISO", 130, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO AUTORIZA DESPIDO", "ESTADOENVIOLEGALDESPIDO", 150, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO DESPIDO", "ESTADOVALIDADOCARTADESPIDO", 110, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO APROBADO", "ESTADOAPROBADORRHH", 110, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EXPIRACIÓN DESCARGO", "EXPIRACIONFECHA", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO CESE", "NUMEROSOLICITUDCESE", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA SOLICITUD", "FECHA", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA VALIDADO SOLICITUD", "FECHAVALIDADOBLOQUEO", 160, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "SOLICITANTE", "SOLICITANTE", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EMPLEADO", "EMPLEADO", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DOC. EMPLEADO", "NUMERODOCUMENTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO", "CARGO", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MOTIVO GENERAL", "MOTIVOGENERAL", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA FINAL CONTRATO", "FECHAFINALCONTRATO", 140, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "PERMANENCIA", "PERMANENCIA", 200, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "AMPLIACION", "MESAMPLIACION", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DESCRIPCIÓN RETORNO", "DESCRIPCIONRETORNO", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDSITIO", "IDSITIO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADOVALIDADOSOLICITUDNOLEGAL", "ESTADOVALIDADOSOLICITUDNOLEGAL", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridView1
            .Columns("NUMEROSOLICITUDCESE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("SOLICITANTE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("EMPLEADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CARGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("MOTIVOGENERAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAFINALCONTRATO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("PERMANENCIA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("MESAMPLIACION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("IDSITIO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("ESTADOVALIDADOSOLICITUDNOLEGAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("DESCRIPCIONRETORNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        Me.GridControl1.DataSource = bsEmpleadoCese
        Refrescar()
    End Sub

    Public Sub Refrescar()
        Try
            btnEvaluarSolicitud.Visibility = BarItemVisibility.Never
            GridView1.Columns.Item("DESCARGO").Visible = False
            Dim dtAccionesbutton As DataTable
            dtAccionesbutton = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(Ribbon, dtAccionesbutton)

            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioGrid(GridView1, dtAccionesUsuario)

            bsEmpleadoCese.DataSource = CeseDAO.GetSolicitudCeseLegalListAll()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnEvaluarSolicitud_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnEvaluarSolicitud.ItemClick
        CeseDAO.IdSolicitudCese = GridView1.GetFocusedRowCellValue("IDSOLICITUDCESE")
        CeseDAO.IdEmpleado = GridView1.GetFocusedRowCellValue("IDEMPLEADO")
        CeseDAO.IdSitio = GridView1.GetFocusedRowCellValue("IDSITIO")
        CeseDAO.EstadoValidoNoLegal = GridView1.GetFocusedRowCellValue("ESTADOVALIDADOSOLICITUDNOLEGAL")

        If GridView1.GetFocusedRowCellValue("ESTADOAPROBADORRHH") Then

            Dim MiForm As New EmpleadoCese

            If CeseDAO.IdSitio = 1 And CeseDAO.EstadoValidoNoLegal = False Then
                MiForm.deFechaCese.Enabled = False
                MiForm.chkPagoDiasBoleta.Enabled = False
                MiForm.sleMotivoCese.Enabled = False
                MiForm.txtObservacion.Enabled = False
                MiForm.btnRegistrarCese.Visibility = BarItemVisibility.Never
            ElseIf CeseDAO.IdSitio = 1 And CeseDAO.EstadoValidoNoLegal Then
                MiForm.dtFechaRecojoDocumento.Enabled = False
                MiForm.btnValidar.Visibility = BarItemVisibility.Never
            Else CeseDAO.IdSitio = 2
                MiForm.lblFechaSupervisor.Visible = False
                MiForm.dtFechaRecojoDocumento.Visible = False
                MiForm.btnValidar.Visibility = BarItemVisibility.Never
            End If
            MiForm.ShowDialog()
            Refrescar()
        Else
            Dim MiForm As New EmpleadoCeseDetails
            MiForm.btnValidarSolicitud.Visibility = BarItemVisibility.Never
            MiForm.btnValidarCartaPreAviso.Visibility = BarItemVisibility.Never
            MiForm.btnValidarCartaDespido.Visibility = BarItemVisibility.Never
            MiForm.btnAnular.Visibility = BarItemVisibility.Never
            MiForm.btnRetornarCese.Visibility = BarItemVisibility.Never
            MiForm.btnDesprocesarValidado.Visibility = BarItemVisibility.Never
            MiForm.txtDescripcionAnulacion.Enabled = False
            'If GridView1.GetFocusedRowCellValue("ESTADOENVIOLEGALPREAVISO") Then
            '    MiForm.btnEnviarLegal.Visibility = BarItemVisibility.Never
            'End If
            If GridView1.GetFocusedRowCellValue("ESTADOVALIDADOLEGALPREAVISO") = False Then
                MiForm.btnAdjuntarCartaPreAviso.Visibility = BarItemVisibility.Never
                MiForm.btnAdjuntarCartaDespido.Visibility = BarItemVisibility.Never
                MiForm.btnValidarRrhh.Visibility = BarItemVisibility.Never
            Else
                MiForm.btnAdjuntarCartaDespido.Visibility = BarItemVisibility.Never

            End If
            If GridView1.GetFocusedRowCellValue("ESTADOVALIDADORRHH") Then
                MiForm.btnValidarRrhh.Visibility = BarItemVisibility.Never
                MiForm.btnAdjuntarCartaPreAviso.Visibility = BarItemVisibility.Never
            Else
                MiForm.btnEnviarLegalDespido.Visibility = BarItemVisibility.Never
            End If
            If GridView1.GetFocusedRowCellValue("ESTADOENVIOLEGALDESPIDO") Then
                MiForm.btnEnviarLegalDespido.Visibility = BarItemVisibility.Never
                MiForm.dtCartaNotariaPreAviso.Enabled = False
            End If
            If GridView1.GetFocusedRowCellValue("ESTADOAPROBADORRHH") Then
                MiForm.btnAprobar.Visibility = BarItemVisibility.Never
            End If
            If GridView1.GetFocusedRowCellValue("ESTADOVALIDADOCARTADESPIDO") = False Then
                MiForm.btnAprobar.Visibility = BarItemVisibility.Never
            End If
            If GridView1.GetFocusedRowCellValue("ESTADOVALIDADORRHH") And GridView1.GetFocusedRowCellValue("ESTADOVALIDADOLEGALPREAVISO") And GridView1.GetFocusedRowCellValue("ESTADOENVIOLEGALDESPIDO") = False Then
                MiForm.btnAnular.Visibility = BarItemVisibility.Always
            End If
            If GridView1.GetFocusedRowCellValue("EXPIRACIONFECHA") = "EN ESPERA" Then
                MiForm.btnEnviarLegalDespido.Visibility = BarItemVisibility.Never
            End If

            MiForm.ShowDialog()
            Refrescar()
        End If
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        If btnEvaluarSolicitud.Visibility = BarItemVisibility.Always Then
            btnEvaluarSolicitud.PerformClick()
        End If
    End Sub
    Private Sub SolicitudCeseLegalList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub



    Private Sub RepositoryItemDescargoArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemDescargoArchivo.Click
        CeseDAO.IdSolicitudCese = GridView1.GetFocusedRowCellValue("IDSOLICITUDCESE")
        If CeseDAO.IdSolicitudCese <> 0 Then
            Dim MiForm As New SolicitudCeseDescargoArchivos
            Dim dt As DataTable = CeseDAO.ListSolicitudCeseDescargoArchivo(CeseDAO.IdSolicitudCese)
            If dt.Rows.Count <> 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim ruta As String = dt.Rows(i).Table(i)("LINKDESCARGA").ToString
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
                If GridView1.GetFocusedRowCellValue("ESTADOVALIDADORRHH") Then
                    MessageBox.Show("Descargo no adjuntado", "Archivo de descargo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("En proceso de evaluación", "Archivo de descargo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If
        End If
    End Sub

    Private Sub RepositoryItemArchivoCese_Click(sender As Object, e As EventArgs) Handles RepositoryItemArchivoCese.Click
        CeseDAO.IdSolicitudCese = GridView1.GetFocusedRowCellValue("IDSOLICITUDCESE")
        If CeseDAO.IdSolicitudCese <> 0 Then
            Dim MiForm As New SolicitudCeseDescargoArchivos
            Dim dt As DataTable = CeseDAO.ListSolicitudCeseArchivo(CeseDAO.IdSolicitudCese)
            If dt.Rows.Count <> 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim ruta As String = dt.Rows(i).Table(i)("LINKDESCARGA").ToString
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
                MessageBox.Show("La solicitud Nª " & GridView1.GetFocusedRowCellValue("NUMEROSOLICITUDCESE") & " no cuenta con adjunto", "Archivo de Cese", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class


