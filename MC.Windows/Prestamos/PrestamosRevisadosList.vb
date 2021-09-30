Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework

Public Class PrestamosRevisadosList
    Dim bsPrestamosRevisados As New BindingSource
    Dim PrestamosBE As New PrestamosBE

    Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDPRESTAMO", "IDPRESTAMO", 10, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO SOLICITUD", "NUMEROSOLICITUD", 140, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 220, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 300, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA SOLICITUD", "FECHA", 100, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MATRICULA", "MATRICULA", 120, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DOCUMENTO", "NUMERODOCUMENTO", 100, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EMPLEADO", "NOMBRES", 220, True)

        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO", "CARGO", 280, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MOTIVO", "MOTIVO", 160, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MONTO SOLICITADO", "MONTO", 120, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MONTO APROBADO", "MONTOAPROBADO", 120, True)


        GridView1.Columns("MONTO").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        GridView1.Columns("MONTOAPROBADO").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far

        Me.GridControl1.DataSource = bsPrestamosRevisados
        Refrescar()
    End Sub

    Private Sub Refrescar()
        btnEvaluar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

        GridView1.Columns.Item("SUSTENTO").Visible = False
        Dim dtAccionesbutton As DataTable
        dtAccionesbutton = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
        Tools.AccionesUsuarioRibbon(Ribbon, dtAccionesbutton)

        Dim dtAccionesUsuario As DataTable
        dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
        Tools.AccionesUsuarioGrid(GridView1, dtAccionesUsuario)
        bsPrestamosRevisados.DataSource = PrestamoDAO.GetByAllPrestamosRevisados
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        If btnEvaluar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
            btnEvaluar.PerformClick()
        End If
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick

        Refrescar()
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

    Private Sub btnEValuar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEvaluar.ItemClick

        PrestamoDAO.IdPrestamo = GridView1.GetFocusedRowCellValue("IDPRESTAMO")
        If PrestamoDAO.IdPrestamo <> 0 Then
            Dim MiForm As New SolicitudPrestamoDetails
            MiForm.btnGuardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnRevisar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnValidar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnAnular.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnHistorialEmpleado.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            Dim dtAccionesUsuarioDetalle As DataTable
            dtAccionesUsuarioDetalle = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, MiForm.Name)
            Tools.AccionesUsuarioRibbon(MiForm.RibbonControl, dtAccionesUsuarioDetalle)



            MiForm.sleMotivo.Enabled = False
            PrestamosBE = PrestamoDAO.GetPrestamoByID(PrestamoDAO.IdPrestamo)
            MiForm.btnGuardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnRevisar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'If PrestamosBE.EstadoValidadoRrhh Then
            '    MiForm.btnGuardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '    MiForm.btnValidar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'Else
            '    MiForm.btnGuardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            '    MiForm.btnValidar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            'End If

            MiForm.ShowDialog()
            Refrescar()
        End If
    End Sub

    Private Sub PrestamosRevisadosList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

End Class