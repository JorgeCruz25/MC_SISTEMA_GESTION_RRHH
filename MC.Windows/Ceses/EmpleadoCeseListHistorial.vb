Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework

Public Class EmpleadoCeseListHistorial

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
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO CESE", "NUMEROSOLICITUDCESE", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "SOLICITANTE", "SOLICITANTE", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA SOLICITUD", "FECHA", 130, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA VALIDADO", "FECHAVALIDADOBLOQUEO", 130, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EMPLEADO", "EMPLEADO", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DOC. EMPLEADO", "NUMERODOCUMENTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO", "CARGO", 160, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MOTIVO GENERAL", "MOTIVOGENERAL", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA FINAL CONTRATO", "FECHAFINALCONTRATO", 140, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "PERMANENCIA", "PERMANENCIA", 150, False, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "AMPLIACION", "MESAMPLIACION", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO", "ESTADO", 100, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA APROBACIÓN", "FECHARRHH", 100, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "USUARIO ANULADO", "NOMBREUSUARIOANULADO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
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
        End With

        btnFechaInicial.EditValue = DateTime.Now.Date.AddDays(-30)
        btnFechaFinal.EditValue = DateTime.Now.Date

        AddHandler btnFechaFinal.EditValueChanged, AddressOf Refrescar

        Me.GridControl1.DataSource = bsEmpleadoCese
        Refrescar()

    End Sub

    Public Sub Refrescar()
        Try
            btnExportar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            GridView1.Columns.Item("DESCARGO").Visible = False
            Dim dtAccionesbutton As DataTable
            dtAccionesbutton = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(Ribbon, dtAccionesbutton)

            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioGrid(GridView1, dtAccionesUsuario)

            bsEmpleadoCese.DataSource = BDAccionPersonalDAO.GetEmpleadoCeseListHistorial(btnFechaInicial.EditValue, btnFechaFinal.EditValue)

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

    Private Sub EmpleadoCeseListHistorial_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
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
                MessageBox.Show("La solicitud Nª " & GridView1.GetFocusedRowCellValue("NUMEROSOLICITUDCESE") & " no cuenta con adjunto", "Archivo de Descago de Cese", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnExportar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportar.ItemClick
        If GridView1.RowCount > 0 Then
            'GridView1.Columns(0).Visible = False
            'GridView1.Columns("DESCRIPCIONESTADOANULADORRHH").Visible = True
            'GridView1.Columns("ESTADOANULADORRHH").Visible = False

            Try
                Dim ruta As String
                ruta = My.Application.Info.DirectoryPath() + "\HistorialCeses.xlsx"
                GridControl1.ExportToXlsx(ruta)
                Process.Start(ruta)
            Catch ex As Exception
                MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
            End Try
            'GridView1.Columns(0).VisibleIndex = 1

            'GridView1.Columns("ESTADOANULADORRHH").Visible = True
            'GridView1.Columns("DESCRIPCIONESTADOANULADORRHH").Visible = False
        End If
    End Sub
End Class