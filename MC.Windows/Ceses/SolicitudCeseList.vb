Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework
Public Class SolicitudCeseList
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
        ControlesDevExpress.InitGridViewColumn(GridView1, "MEDIO GENERADO", "MEDIOGENERADO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False) '''NO BORRAR ESTO SI SE VA A USAR
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO CESE", "NUMEROSOLICITUDCESE", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA SOLICITUD", "FECHA", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA VALIDADO", "FECHAVALIDADOBLOQUEO", 130, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "SOLICITANTE", "SOLICITANTE", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EMPLEADO", "EMPLEADO", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DE IDENTIDAD", "NUMERODOCUMENTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO", "CARGO", 160, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MOTIVO GENERAL", "MOTIVOGENERAL", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA FINAL CONTRATO", "FECHAFINALCONTRATO", 140, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "PERMANENCIA", "PERMANENCIA", 150, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "AMPLIACION", "MESAMPLIACION", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)

        With GridView1
            .Columns("MEDIOGENERADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMEROSOLICITUDCESE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("SOLICITANTE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("EMPLEADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CARGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("MOTIVOGENERAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAFINALCONTRATO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With


        Refrescar()

    End Sub
    Public Sub Refrescar()
        Try

            btnEvaluarCese.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            btnExportar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(RibbonControl, dtAccionesUsuario)
            Me.GridControl1.DataSource = bsEmpleadoCese
            bsEmpleadoCese.DataSource = CeseDAO.GetSolicitudCeseListAll()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub
    Private Sub SolicitudCeseList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub btnEvaluarCese_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEvaluarCese.ItemClick
        CeseDAO.IdSolicitudCese = GridView1.GetFocusedRowCellValue("IDSOLICITUDCESE")
        CeseDAO.IdEmpleado = GridView1.GetFocusedRowCellValue("IDEMPLEADO")
        Dim MiForm As New EmpleadoCeseDetails
        MiForm.btnValidarCartaPreAviso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        MiForm.btnAdjuntarCartaDespido.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        MiForm.btnValidarCartaDespido.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        MiForm.btnAdjuntarCartaPreAviso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        MiForm.btnValidarRrhh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        MiForm.btnEnviarLegalDespido.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        MiForm.btnGuardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        MiForm.btnAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        MiForm.btnRetornarCese.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        MiForm.lblCartaPreAviso.Visible = False
        MiForm.lblCartaDespido.Visible = False
        MiForm.dtCartaNotariaPreAviso.Visible = False
        MiForm.dtCartaNotariaDespido.Visible = False
        MiForm.XtraTabPageArchivoCartaPreAviso.PageVisible = False
        MiForm.XtraTabPageArchivoCartaDespido.PageVisible = False
        MiForm.ShowDialog()
        Refrescar()


        'Dim MiFom As New EmpleadoCeseDetails
        'MiFom.btnValidarCartaPreAviso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        'MiFom.btnAdjuntarCartaDespido.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        'MiFom.btnEnviarCartaDespido.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        'MiFom.btnEnvioRegistroBaja.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        'MiFom.btnRegistroEmpleadoBaja.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        'If GridView1.GetFocusedRowCellValue("ESTADOVALIDADORRHH") Or GridView1.GetFocusedRowCellValue("ESTADOVALIDADOLEGALPREAVISO") = False Then
        '    MiFom.btnValidarRrhh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '    MiFom.btnEnviarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        'End If
        'If GridView1.GetFocusedRowCellValue("ESTADOVALIDADOLEGALPREAVISO") Then
        '    MiFom.btnValidarRrhh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '    MiFom.btnAdjuntarCartaPreAviso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '    MiFom.btnEnviarLegalDespido.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

        'End If

        'If GridView1.GetFocusedRowCellValue("ESTADOVALIDADOLEGAL") Then
        '    MiFom.btnEnviarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        'Else
        '    MiFom.btnAdjuntarCartaPreAviso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '    MiFom.btnProcedeDespido.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        'End If
        'If GridView1.GetFocusedRowCellValue("ESTADOENVIOCARTADESPIDO") Then
        '    MiFom.btnProcedeDespido.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '    MiFom.btnAdjuntarCartaPreAviso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '    MiFom.btnAdjuntarCartaDespido.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        'End If
        'If GridView1.GetFocusedRowCellValue("ESTADOENVIOCARTADESPIDO") And GridView1.GetFocusedRowCellValue("ESTADOVALIDADOLEGAL") Then
        '    MiFom.btnEnvioRegistroBaja.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        'End If
        'MiFom.ShowDialog()
        'Refrescar()
    End Sub
    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        If btnEvaluarCese.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
            btnEvaluarCese.PerformClick()
        End If
    End Sub

    'Private Sub RepositoryItemDescargoArchivo_Click(sender As Object, e As EventArgs)
    '    CeseDAO.IdSolicitudCese = GridView1.GetFocusedRowCellValue("IDSOLICITUDCESE")
    '    If CeseDAO.IdSolicitudCese <> 0 Then
    '        Dim MiForm As New SolicitudCeseDescargoArchivos
    '        Dim dt As DataTable = CeseDAO.ListSolicitudCeseDescargoArchivo(CeseDAO.IdSolicitudCese)
    '        For i As Integer = 0 To dt.Rows.Count - 1
    '            Dim ruta As String = dt.Rows(i).Table(i)("LINKDESCARGA").ToString
    '            Dim tab As String
    '            tab = "Archivo" + Convert.ToString(i + 1)
    '            Dim NewTab As New XtraTabPage
    '            NewTab.Name = tab
    '            NewTab.Text = tab
    '            MiForm.XtraTabControl1.TabPages.Add(NewTab)

    '            Dim uccontrol1 As New XtraUserControlWebBrowser()
    '            NewTab.Controls.Add(uccontrol1)
    '            uccontrol1.Dock = DockStyle.Fill

    '            uccontrol1.WebBrowser1.Show()
    '            uccontrol1.WebBrowser1.Navigate(String.Format(ruta, Application.StartupPath))
    '        Next
    '        MiForm.ShowDialog()
    '    Else
    '        If GridView1.GetFocusedRowCellValue("ESTADOVALIDADOLEGAL") Then
    '            MessageBox.Show("Descargo aun no adjuntado", "Archivo de descargo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Else
    '            MessageBox.Show("En proceso de evaluación", "Archivo de descargo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If

    '    End If
    'End Sub

    Private Sub btnExportar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportar.ItemClick
        If GridView1.RowCount > 0 Then
            Try
                Dim ruta As String
                ruta = My.Application.Info.DirectoryPath() + "\SolicitudesCeses.xlsx"
                GridControl1.ExportToXlsx(ruta)
                Process.Start(ruta)

            Catch ex As Exception
                MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
            End Try
        End If
    End Sub

    Private Sub RepositoryItemButtonCeseArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonCeseArchivo.Click
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