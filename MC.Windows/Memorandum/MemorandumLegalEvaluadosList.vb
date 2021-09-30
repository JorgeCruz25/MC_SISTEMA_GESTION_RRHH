Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework
Public Class MemorandumLegalEvaluadosList
    Dim bsMemorandumLegalEval As New BindingSource
    Sub New()

        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDMEMORANDUM", "IDMEMORANDUM", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO MEMORANDUM", "NUMEROINFORME", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA SOLICITUD", "FECHA", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EMPLEADO", "EMPLEADO", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DN EMPLEADO", "EMPLEADODNI", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO", "EMPLEADOCARGO", 280, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO", "ESTADODOCUMENTO", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDEMPLEADO", "IDEMPLEADO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "IDDESCARGO", "IDSUSTENTOARCHIVO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridView1
            .Columns("NUMEROINFORME").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("EMPLEADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("EMPLEADODNI").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("EMPLEADOCARGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        Me.GridControl1.DataSource = bsMemorandumLegalEval
        Refrescar()
    End Sub
    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        If btnEditar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
            btnEditar.PerformClick()
        End If
    End Sub
    Private Sub MemorandumLegalEvaluadosList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub
    Private Sub inabilitarbotones()

    End Sub

    Private Sub Refrescar()
        Try
            btnEditar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            GridView1.Columns.Item("MEMORANDUM").Visible = False
            GridView1.Columns.Item("INFORME").Visible = False
            Dim dtAccionesbutton As DataTable
            dtAccionesbutton = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(Ribbon, dtAccionesbutton)

            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioGrid(GridView1, dtAccionesUsuario)
            bsMemorandumLegalEval.DataSource = MemorandumDAO.MemorandumlLegalEvalListAll()

            If GridView1.Columns.Item("MEMORANDUM").Visible Then
                GridView1.Columns.Item("MEMORANDUM").VisibleIndex = 0
            End If
            If GridView1.Columns.Item("INFORME").Visible Then
                GridView1.Columns.Item("INFORME").VisibleIndex = 1
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub RepositoryItemInformeArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemInformeArchivo.Click
        MemorandumDAO.IdMemorandum = GridView1.GetFocusedRowCellValue("IDMEMORANDUM")
        Dim reportinforme As New RptInformeDisciplinario
        Dim dtcabecera As New DataTable
        dtcabecera = MemorandumDAO.ListaMemorandumGetBy(MemorandumDAO.IdMemorandum)
        reportinforme.XrNumeroInforme.Text = dtcabecera.Rows(0).Item("NUMEROINFORME")
        'reportinforme.XrArea.Text = dtcabecera.Rows(0).Item("AREA")
        reportinforme.XrRazonSocial.Text = dtcabecera.Rows(0).Item("RAZONSOCIAL")
        reportinforme.XrNombreComercial.Text = dtcabecera.Rows(0).Item("RAZONCOMERCIAL")
        reportinforme.XrRucLocal.Text = dtcabecera.Rows(0).Item("IDTRIBUTARIO")
        reportinforme.XrDireccionLocal.Text = dtcabecera.Rows(0).Item("DIRECCION")
        reportinforme.XrFecha.Text = dtcabecera.Rows(0).Item("FECHA")
        reportinforme.XrSolicitante.Text = dtcabecera.Rows(0).Item("SOLICITANTE")
        reportinforme.XrSolicitanteDni.Text = dtcabecera.Rows(0).Item("SOLICITANTEDNI")
        reportinforme.XrSolicitantePuesto.Text = dtcabecera.Rows(0).Item("SOLICITANTECARGO")
        reportinforme.XrRepresentante.Text = dtcabecera.Rows(0).Item("REPRESENTANTENOMBRE")
        reportinforme.XrRepresentanteDni.Text = dtcabecera.Rows(0).Item("REPRESENTANTEDNI")
        reportinforme.XrRepresentantePuesto.Text = dtcabecera.Rows(0).Item("REPRESENTANTECARGO")
        reportinforme.XrEmpleadoMemorandum.Text = dtcabecera.Rows(0).Item("EMPLEADO")
        reportinforme.XrEmpleadoDni.Text = dtcabecera.Rows(0).Item("EMPLEADODNI")
        reportinforme.XrEmpleadoPuesto.Text = dtcabecera.Rows(0).Item("EMPLEADOCARGO")
        reportinforme.XrDescripcionMemorandum.Text = dtcabecera.Rows(0).Item("DESCRIPCION")
        ReportView.DocumentViewer.DocumentSource = reportinforme
        ReportView.DocumentViewer.Refresh()
        ReportView.Show()
    End Sub
    Private Sub RepositoryItemMemorandumArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemMemorandumArchivo.Click

        MemorandumDAO.IdMemorandum = GridView1.GetFocusedRowCellValue("IDMEMORANDUM")
        Dim reportinforme As New RptMemorandum()
        Dim dtcabecera As New DataTable
        dtcabecera = MemorandumDAO.ListaMemorandumGetBy(MemorandumDAO.IdMemorandum)

        reportinforme.XrNroInforme.Text = dtcabecera.Rows(0).Item("NUMEROINFORME")
        reportinforme.XrRazonsocial.Text = dtcabecera.Rows(0).Item("RAZONSOCIAL")
        reportinforme.XrNombreComercial.Text = dtcabecera.Rows(0).Item("RAZONCOMERCIAL")
        reportinforme.XrRUC.Text = dtcabecera.Rows(0).Item("IDTRIBUTARIO")
        reportinforme.XrDireccion.Text = dtcabecera.Rows(0).Item("DIRECCION")

        reportinforme.XrFecha.Text = dtcabecera.Rows(0).Item("FECHA")

        reportinforme.XrSolicitante.Text = dtcabecera.Rows(0).Item("EMPLEADO")
        reportinforme.XrSolicitanteCargo.Text = dtcabecera.Rows(0).Item("EMPLEADOCARGO")
        reportinforme.XrSolicitanteDNI.Text = dtcabecera.Rows(0).Item("EMPLEADODNI")

        reportinforme.XrDestinatario.Text = dtcabecera.Rows(0).Item("REPRESENTANTENOMBRE")
        reportinforme.XrDestinatarioCargo.Text = dtcabecera.Rows(0).Item("REPRESENTANTECARGO")
        reportinforme.XrDestinatarioDNI.Text = dtcabecera.Rows(0).Item("REPRESENTANTEDNI")

        reportinforme.XrFirmaDestinatario.Text = dtcabecera.Rows(0).Item("REPRESENTANTENOMBRE")
        reportinforme.XrFirmaSolicitante.Text = dtcabecera.Rows(0).Item("EMPLEADO")

        'reportinforme.XrArea.Text = dtcabecera.Rows(0).Item("AREA")

        reportinforme.XrSancion.Text = dtcabecera.Rows(0).Item("SANCION")
        reportinforme.XrFalta.Text = dtcabecera.Rows(0).Item("FALTA")
        If dtcabecera.Rows(0).Item("DESCRIPCIONHECHOS") = "" Then
            reportinforme.XrDescripcionHechos.Visible = False
            reportinforme.XrLabel25.Visible = False
        Else
            reportinforme.XrDescripcionHechos.Text = dtcabecera.Rows(0).Item("DESCRIPCIONHECHOS")
        End If



        Dim xDescuento As Boolean
        xDescuento = dtcabecera.Rows(0).Item("DESCUENTOREMUNERATIVO")
        If xDescuento Then
            reportinforme.XrDescuentoRemunerativo.Visible = True
        Else
            reportinforme.XrDescuentoRemunerativo.Visible = False
        End If
        ReportView.DocumentViewer.DocumentSource = reportinforme
        ReportView.DocumentViewer.Refresh()
        ReportView.Show()
    End Sub
    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub
    Private Sub btnEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditar.ItemClick
        MemorandumDAO.IdMemorandum = GridView1.GetFocusedRowCellValue("IDMEMORANDUM")
        MemorandumDAO.IdEmpleado = GridView1.GetFocusedRowCellValue("IDEMPLEADO")
        If MemorandumDAO.IdMemorandum <> 0 Then

            Dim MiForm As New MemorandumDetails
            MiForm.btnValidarRRHH.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnExonerar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnEnviarCorreo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnAdjuntar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnFormatoLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnCartaNotarial.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnNotificar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnAnular.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnHistorialEmpleado.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnEnviarLegalRedaccion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnValidarRedaccion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnEnviarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnValidarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnRetornarMemorandum.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnGuardarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnGuardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            Dim dtAccionesUsuarioDetalle As DataTable
            dtAccionesUsuarioDetalle = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, MiForm.Name)
            Tools.AccionesUsuarioRibbon(MiForm.RibbonControl, dtAccionesUsuarioDetalle)


            MiForm.txtDescripcionLegal.Enabled = False
            MiForm.txtDiasSancion.Enabled = False
            MiForm.sleFalta.Enabled = False
            MiForm.sleSancion.Enabled = False
            MiForm.chkDescuento.Enabled = False
            MiForm.txtMontoDescuento.Enabled = False
            MiForm.txtCorreccionRedaccion.Enabled = False
            MiForm.ShowDialog()
            Refrescar()
        End If
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub
    'Private Sub RepositoryItemCartaNotarial_Click(sender As Object, e As EventArgs) Handles RepositoryItemCartaNotarial.Click
    '    MemorandumDAO.IdMemorandum = GridView1.GetFocusedRowCellValue("IDMEMORANDUM")
    '    If MemorandumDAO.IdMemorandum <> 0 Then
    '        Dim MiForm As New MemorandumCartaNotarialArchivo
    '        Dim dt As DataTable = MemorandumDAO.ListaMemorandumNotarialArchivos(MemorandumDAO.IdMemorandum)
    '        If dt.Rows.Count <> 0 Then
    '            For i As Integer = 0 To dt.Rows.Count - 1
    '                Dim ruta As String = dt.Rows(i).Table(i)("linkdescarga").ToString
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
    '            MessageBox.Show("El memorandum no contiene archivo", "Archivo de Memorandum")
    '        End If
    '    End If
    'End Sub
End Class