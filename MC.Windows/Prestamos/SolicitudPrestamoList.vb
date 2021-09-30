Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework
Public Class SolicitudPrestamoList
    Dim bsSolicitudPrestamos As New BindingSource

    Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDPRESTAMO", "IDPRESTAMO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO REVISADO", "ESTADOEVALUACIONRRHH", 120, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO VALIDADO", "ESTADOVALIDADORRHH", 115, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO SOLICITUD", "NUMEROSOLICITUD", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA SOLICITUD", "FECHA", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MATRICULA", "MATRICULA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N°DOCUMENTO", "NUMERODOCUMENTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EMPLEADO", "NOMBRES", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO", "CARGO", 280, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA INGRESO CORPORACIÓN", "FECHAINGRESOCORPORACION", 170, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA INGRESO LOCAL", "FECHAINGRESO", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MOTIVO", "MOTIVO", 160, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MONTO SOLICITADO", "MONTO", 120, True, ControlesDevExpress.eGridViewFormato.Numero, False)

        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADOEVALUACIONRRHH", "ESTADOEVALUACIONRRHH", 120, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)


        GridView1.Columns("MONTO").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far

        With GridView1
            .Columns("NUMEROSOLICITUD").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOMBRES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CARGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("MOTIVO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("MONTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        Me.GridControl1.DataSource = bsSolicitudPrestamos
        Refrescar()

    End Sub

    Private Sub Refrescar()
        Try

            btnExportarSolicitudes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            btnEvaluar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            GridView1.Columns.Item("SUSTENTO").Visible = False
            GridView1.Columns.Item("ACTACOMPROMISO").Visible = False
            Dim dtAccionesbutton As DataTable
            dtAccionesbutton = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(Ribbon, dtAccionesbutton)
            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioGrid(GridView1, dtAccionesUsuario)

            bsSolicitudPrestamos.DataSource = PrestamoDAO.GetByAllPrestamos

            If GridView1.Columns.Item("SUSTENTO").Visible Then
                GridView1.Columns.Item("SUSTENTO").VisibleIndex = 0
            End If

            If GridView1.Columns.Item("ACTACOMPROMISO").Visible Then
                GridView1.Columns.Item("SUSTENTO").VisibleIndex = 1
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub

    Private Sub btnEValuar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEvaluar.ItemClick
        PrestamoDAO.IdPrestamo = GridView1.GetFocusedRowCellValue("IDPRESTAMO")
        If PrestamoDAO.IdPrestamo <> 0 Then
            Dim MiForm As New SolicitudPrestamoDetails

            MiForm.btnGuardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnRevisar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            MiForm.btnAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnAnular.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnHistorialEmpleado.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            Dim dtAccionesUsuarioDetalle As DataTable
            dtAccionesUsuarioDetalle = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, MiForm.Name)
            Tools.AccionesUsuarioRibbon(MiForm.RibbonControl, dtAccionesUsuarioDetalle)
            MiForm.btnValidar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            If GridView1.GetFocusedRowCellValue("ESTADOVALIDADORRHH") Then
                MiForm.btnRevisar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                MiForm.btnGuardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Else
                MiForm.btnAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If GridView1.GetFocusedRowCellValue("ESTADOEVALUACIONRRHH") Then

                MiForm.sleTipoPago.Enabled = False
                MiForm.sleMedioPago.Enabled = False
                MiForm.txtDescuentoGratificacion.Enabled = False
                MiForm.txtMontoAprobado.Enabled = False
                MiForm.txtMontoDescuento.Enabled = False
                MiForm.sleMotivo.Enabled = False
                MiForm.txtMontoLiquidacion.Enabled = False
                MiForm.txtMontoVacaciones.Enabled = False
                MiForm.txtDescripcionRrhh.Enabled = False
                MiForm.btnRevisar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                MiForm.btnGuardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            MiForm.ShowDialog()

            Refrescar()
        End If
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        If btnEvaluar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
            btnEvaluar.PerformClick()
        End If
    End Sub

    Private Sub RepositoryItemButtonEditArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEditArchivo.Click
        PrestamoDAO.IdPrestamo = GridView1.GetFocusedRowCellValue("IDPRESTAMO")
        If PrestamoDAO.IdPrestamo <> 0 Then
            Dim MiForm As New SolicitudPrestamoArchivos
            Dim dt As DataTable = PrestamoDAO.GetPrestamosArchivo(PrestamoDAO.IdPrestamo)
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
                MessageBox.Show("La solicitud no contiene archivo", "Archivo de préstamo")
            End If
        End If
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub SolictudPrestamoList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub RepositoryItemActaCompromiso_Click(sender As Object, e As EventArgs) Handles RepositoryItemActaCompromiso.Click
        PrestamoDAO.IdPrestamo = GridView1.GetFocusedRowCellValue("IDPRESTAMO")
        If PrestamoDAO.IdPrestamo <> 0 Then
            Dim MiForm As New SolicitudPrestamoArchivos
            Dim dt As DataTable = PrestamoDAO.GetPrestamosCompromisoArchivo(PrestamoDAO.IdPrestamo)
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
                MessageBox.Show("La solicitud no contiene archivo", "Archivo de préstamo")
            End If
        End If
    End Sub

    Private Sub btnExportarSolicitudes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportarSolicitudes.ItemClick
        If GridView1.RowCount > 0 Then

            GridView1.Columns(0).Visible = False
            GridView1.Columns(1).Visible = False
            GridView1.Columns(2).Visible = False
            GridView1.Columns(3).Visible = False
            GridView1.Columns(4).Visible = False
            Try
                Dim ruta As String
                ruta = My.Application.Info.DirectoryPath() + "\SolicitudesPrestamos.xlsx"
                GridControl1.ExportToXlsx(ruta)
                Process.Start(ruta)

            Catch ex As Exception
                MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
            End Try
            GridView1.Columns(0).VisibleIndex = 0
            GridView1.Columns(1).VisibleIndex = 1
            GridView1.Columns(2).VisibleIndex = 2
            GridView1.Columns(3).VisibleIndex = 3
            GridView1.Columns(4).VisibleIndex = 4
            GridView1.Columns(0).Visible = True
            GridView1.Columns(1).Visible = True
            GridView1.Columns(2).Visible = True
            GridView1.Columns(3).Visible = True
            GridView1.Columns(4).Visible = True
            GridView1.Columns("IDPRESTAMO").Visible = False
        End If
    End Sub
End Class