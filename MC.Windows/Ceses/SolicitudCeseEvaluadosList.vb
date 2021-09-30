Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework
Public Class SolicitudCeseEvaluadosList
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
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO PRE-AVISO", "ESTADOVALIDADOLEGALPREAVISO", 120, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO DESPIDO", "ESTADOENVIOLEGALDESPIDO", 130, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO CESE", "NUMEROSOLICITUDCESE", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 170, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 170, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "SOLICITANTE", "SOLICITANTE", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA REGISTRO", "FECHA", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EMPLEADO", "EMPLEADO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DE IDENTIDAD", "DNI", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO", "CARGO", 160, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MOTIVO GENERAL", "MOTIVOGENERAL", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA FINAL CONTRATO", "FECHAFINALCONTRATO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "PERMANENCIA", "PERMANENCIA", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "AMPLIACION", "MESAMPLIACION", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridView1
            .Columns("NUMEROSOLICITUDCESE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("SOLICITANTE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("EMPLEADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("DNI").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CARGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("MOTIVOGENERAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAFINALCONTRATO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        Me.GridControl1.DataSource = bsEmpleadoCese
        Refrescar()

    End Sub

    Public Sub Refrescar()
        Try
            btnEvaluarCese.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            GridView1.Columns.Item("DESCARGO").Visible = False
            Dim dtAccionesbutton As DataTable
            dtAccionesbutton = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(Ribbon, dtAccionesbutton)

            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioGrid(GridView1, dtAccionesUsuario)


            bsEmpleadoCese.DataSource = CeseDAO.GetSolicitudCeseEvaluadosList()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub

    Private Sub SolicitudCeseEvaluadosList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnEvaluarCese_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEvaluarCese.ItemClick
        CeseDAO.IdSolicitudCese = GridView1.GetFocusedRowCellValue("IDSOLICITUDCESE")
        CeseDAO.IdEmpleado = GridView1.GetFocusedRowCellValue("IDEMPLEADO")

        Dim MiForm As New EmpleadoCeseDetails
        MiForm.btnGuardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        MiForm.btnValidarRrhh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        MiForm.btnValidarSolicitud.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        MiForm.btnEnviarLegalDespido.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        MiForm.btnAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        MiForm.btnAnular.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        MiForm.btnDesprocesarValidado.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        MiForm.dtCartaNotariaPreAviso.Enabled = False
        MiForm.dtCartaNotariaDespido.Enabled = False

        If GridView1.GetFocusedRowCellValue("ESTADOVALIDADOLEGALPREAVISO") Then
            MiForm.btnAdjuntarCartaPreAviso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnValidarCartaPreAviso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        If GridView1.GetFocusedRowCellValue("ESTADOAPROBADODESPIDO") Then
            MiForm.btnValidarCartaPreAviso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnAdjuntarCartaPreAviso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Else
            MiForm.btnAdjuntarCartaDespido.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnValidarCartaDespido.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'MiForm.dtCartaNotariaDespido.Visible = False
        End If
        If GridView1.GetFocusedRowCellValue("ESTADOENVIOLEGALDESPIDO") Then
            MiForm.btnAdjuntarCartaDespido.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            MiForm.btnValidarCartaDespido.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If
        MiForm.ShowDialog()
        Refrescar()
    End Sub
    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        If btnEvaluarCese.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
            btnEvaluarCese.PerformClick()
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
    'Private Sub RepositoryItemDescargoArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemDescargoArchivo.Click
    '    CeseDAO.IdSolicitudCese = GridView1.GetFocusedRowCellValue("IDSOLICITUDCESE")
    '    If CeseDAO.IdSolicitudCese <> 0 Then
    '        Dim MiForm As New SolicitudCeseDescargoArchivos
    '        Dim dt As DataTable = CeseDAO.ListSolicitudCeseDescargoArchivo(CeseDAO.IdSolicitudCese)
    '        If dt.Rows.Count <> 0 Then
    '            For i As Integer = 0 To dt.Rows.Count - 1
    '                Dim ruta As String = dt.Rows(i).Table(i)("LINKDESCARGA").ToString
    '                Dim tab As String
    '                tab = "Archivo" + Convert.ToString(i + 1)
    '                Dim NewTab As New XtraTabPage
    '                NewTab.Name = tab
    '                NewTab.Text = tab
    '                MiForm.XtraTabControl1.TabPages.Add(NewTab)

    '                Dim uccontrol1 As New XtraUserControlWebBrowser()
    '                NewTab.Controls.Add(uccontrol1)
    '                uccontrol1.Dock = DockStyle.Fill

    '                uccontrol1.WebBrowser1.Show()
    '                uccontrol1.WebBrowser1.Navigate(String.Format(ruta, Application.StartupPath))
    '            Next
    '            MiForm.ShowDialog()
    '        Else
    '            If GridView1.GetFocusedRowCellValue("ESTADOVALIDADORRHH") Then
    '                MessageBox.Show("Descargo no adjuntado", "Archivo de descargo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Else
    '                MessageBox.Show("En proceso de evaluación", "Archivo de descargo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            End If

    '        End If
    '    End If
    'End Sub


End Class