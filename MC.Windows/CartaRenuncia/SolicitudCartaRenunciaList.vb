Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework
Public Class SolicitudCartaRenunciaList
    Dim bsCartaRenuncia As New BindingSource

    Sub New()

        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDRENUNCIA", "IDRENUNCIA", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO PROCESO", "ESTADOPROCESO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)' NO BORRAR SI VA
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO RENUNCIA", "NUMEROCARTA", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA SOLICITUD", "FECHA", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA VALIDADO", "FECHABLOQUEO", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EMPLEADO", "NOMBRES", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DOC. EMPLEADO", "NUMERODOCUMENTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO", "CARGO", 210, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ULTIMO DIA TRABAJO", "FECHAULTIMODIATRABAJO", 140, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "SOLICITANTE", "USUARIO", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "IDESTADOPROCESO", "IDESTADOPROCESO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False) ' NO BORRAR SI VA
        With GridView1
            .Columns("NUMEROCARTA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHABLOQUEO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOMBRES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CARGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAULTIMODIATRABAJO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("USUARIO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        Me.GridControl1.DataSource = bsCartaRenuncia
        Refrescar()

    End Sub
    Private Sub Refrescar()
        Try
            btnEvaluar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            btnExportar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            GridView1.Columns.Item("CARTARENUNCIA").Visible = False
            Dim dtAccionesbutton As DataTable
            dtAccionesbutton = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(Ribbon, dtAccionesbutton)

            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioGrid(GridView1, dtAccionesUsuario)

            bsCartaRenuncia.DataSource = RenunciaDAO.SolicitudRenunciasListAll
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        If btnEvaluar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
            btnEvaluar.PerformClick()
        End If
    End Sub

    Private Sub btnEvaluar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEvaluar.ItemClick
        Dim MiForm As New RenunciaDetails
        RenunciaDAO.IdRenuncia = GridView1.GetFocusedRowCellValue("IDRENUNCIA")
        MiForm.ShowDialog()
        Refrescar()
    End Sub

    Private Sub RepositoryItemCartaRenunciaArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemCartaRenunciaArchivo.Click
        RenunciaDAO.IdRenuncia = GridView1.GetFocusedRowCellValue("IDRENUNCIA")
        If RenunciaDAO.IdRenuncia <> 0 Then
            Dim MiForm As New RenunciaArchivo
            Dim dt1 As DataTable = RenunciaDAO.SolicitudRenunciasListArchivo(RenunciaDAO.IdRenuncia)
            If dt1.Rows.Count <> 0 Then
                For i As Integer = 0 To dt1.Rows.Count - 1
                    Dim ruta As String = dt1.Rows(i).Table(i)("linkdescarga").ToString
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
                MessageBox.Show("Archivo de renuncia no adjuntado", "Archivo de Licencia")
            End If
        End If
    End Sub

    Private Sub SolicitudCartaRenunciaList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub btnExportar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportar.ItemClick
        If GridView1.RowCount > 0 Then
            GridView1.Columns(0).Visible = False
            Try
                Dim ruta As String
                ruta = My.Application.Info.DirectoryPath() + "\SolicitudesRenuncias.xlsx"
                GridControl1.ExportToXlsx(ruta)
                Process.Start(ruta)
            Catch ex As Exception
                MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
            End Try
            GridView1.Columns(0).VisibleIndex = 1
        End If
    End Sub
End Class