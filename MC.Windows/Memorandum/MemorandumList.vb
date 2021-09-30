Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework

Public Class MemorandumList
    Dim bsMemorandums As New BindingSource
    Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDMEMORANDUM", "IDMEMORANDUM", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ADJUNTO", "ADJUNTO", 65, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EST.VALIDADO", "ESTADOVALIDADORRHH", 83, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ENV.REDACCIÓN", "ESTADOENVIOLEGALREDACCION", 100, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EST.REDACCIÓN", "ESTADOVALIDADOLEGALREDACCION", 100, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DOC.FIRMA", "FIRMADOCUMENTO", 75, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ENV.LEGAL", "ESTADOENVIOLEGAL", 75, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EST. LEGAL", "ESTADOVALIDADOLEGAL", 75, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EST. NOTIFICADO", "ESTADONOTIFICADO", 100, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO MEMORANDUM", "NUMEROINFORME", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA SOLICITUD", "FECHA", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EMPLEADO", "EMPLEADO", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DNI EMPLEADO", "EMPLEADODNI", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO", "EMPLEADOCARGO", 280, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDEMPLEADO", "IDEMPLEADO", 120, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)

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

        Me.GridControl1.DataSource = bsMemorandums
        Refrescar()

    End Sub

    Private Sub Refrescar()
        Try
            btnEvaluar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            GridView1.Columns.Item("ARCHIVO").Visible = False
            GridView1.Columns.Item("FORMATO").Visible = False
            GridView1.Columns.Item("DESCARGO").Visible = False
            Dim dtAccionesbutton As DataTable
            dtAccionesbutton = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(Ribbon, dtAccionesbutton)

            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioGrid(GridView1, dtAccionesUsuario)
            bsMemorandums.DataSource = MemorandumDAO.GetAllMemorandums

            If GridView1.Columns.Item("ARCHIVO").Visible Then
                GridView1.Columns.Item("ARCHIVO").VisibleIndex = 0
            End If
            If GridView1.Columns.Item("FORMATO").Visible Then
                GridView1.Columns.Item("FORMATO").VisibleIndex = 1
            End If
            If GridView1.Columns.Item("DESCARGO").Visible Then
                GridView1.Columns.Item("DESCARGO").VisibleIndex = 2
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnEvaluar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEvaluar.ItemClick
        MemorandumDAO.IdMemorandum = GridView1.GetFocusedRowCellValue("IDMEMORANDUM")
        MemorandumDAO.IdEmpleado = GridView1.GetFocusedRowCellValue("IDEMPLEADO")
        MemorandumDAO.FirmaDocumento = GridView1.GetFocusedRowCellValue("FIRMADOCUMENTO")
        MemorandumDAO.EstadoEnvioLegal = GridView1.GetFocusedRowCellValue("ESTADOENVIOLEGAL")
        MemorandumDAO.EstadoNotificado = GridView1.GetFocusedRowCellValue("ESTADONOTIFICADO")
        MemorandumDAO.EstadoValidadoRrhh = GridView1.GetFocusedRowCellValue("ESTADOVALIDADORRHH")
        MemorandumDAO.EstadoEnvioLegalRedaccion = GridView1.GetFocusedRowCellValue("ESTADOENVIOLEGALREDACCION")
        MemorandumDAO.EstadoValidadoLegalRedaccion = GridView1.GetFocusedRowCellValue("ESTADOVALIDADOLEGALREDACCION")
        MemorandumDAO.EstadoValidadoLegal = GridView1.GetFocusedRowCellValue("ESTADOVALIDADOLEGALREDACCION")
        Dim adjunto As Boolean = GridView1.GetFocusedRowCellValue("ADJUNTO")

        If MemorandumDAO.IdMemorandum <> 0 Then
            Dim MiForm As New MemorandumDetails
            MiForm.btnValidarRRHH.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnExonerar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnEnviarCorreo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnAdjuntar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnCartaNotarial.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnAnular.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnHistorialEmpleado.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnEnviarLegalRedaccion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnEnviarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnGuardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            Dim dtAccionesUsuarioDetalle As DataTable
            dtAccionesUsuarioDetalle = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, MiForm.Name)
            Tools.AccionesUsuarioRibbon(MiForm.RibbonControl, dtAccionesUsuarioDetalle)

            MiForm.btnFormatoLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnCartaNotarial.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnNotificar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnValidarRedaccion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnValidarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnRetornarMemorandum.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnGuardarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            'MiForm.btnGuardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'MiForm.btnGuardarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'MiForm.btnValidarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'MiForm.btnCartaNotarial.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'MiForm.btnNotificar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'MiForm.btnFormatoLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'MiForm.btnValidarRedaccion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'MiForm.btnRetornarMemorandum.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.DtFechaIngresoNotaria.Visible = False
            MiForm.lblFechaEnvioNotaria.Visible = False

            If MemorandumDAO.EstadoValidadoRrhh And adjunto = False Then
                MiForm.btnAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If




            If MemorandumDAO.EstadoValidadoRrhh = False And MemorandumDAO.EstadoEnvioLegalRedaccion = False Then
                MiForm.btnAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                MiForm.btnAdjuntar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                MiForm.btnEnviarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            ElseIf MemorandumDAO.EstadoValidadoRrhh And MemorandumDAO.EstadoEnvioLegalRedaccion = False And MemorandumDAO.FirmaDocumento Then
                MiForm.btnValidarRRHH.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                MiForm.btnAdjuntar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                MiForm.btnEnviarLegalRedaccion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                MiForm.btnEnviarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            ElseIf MemorandumDAO.EstadoValidadoRrhh And MemorandumDAO.EstadoEnvioLegalRedaccion = False Then ' And MemorandumDAO.FirmaDocumento = False Then
                MiForm.btnValidarRRHH.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                'MiForm.btnAdjuntar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                MiForm.btnEnviarLegalRedaccion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                'MiForm.btnAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            ElseIf MemorandumDAO.EstadoEnvioLegalRedaccion And MemorandumDAO.EstadoValidadoLegalRedaccion = False Then
                MiForm.RibbonPageGroup1.Visible = False
                MiForm.btnEnviarLegalRedaccion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                MiForm.btnEnviarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            ElseIf MemorandumDAO.EstadoEnvioLegalRedaccion And MemorandumDAO.EstadoValidadoLegalRedaccion And MemorandumDAO.EstadoValidadoRrhh = False Then
                MiForm.btnAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                MiForm.btnAdjuntar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                MiForm.btnEnviarLegalRedaccion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                MiForm.btnEnviarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            ElseIf MemorandumDAO.EstadoEnvioLegalRedaccion And MemorandumDAO.EstadoValidadoLegalRedaccion And MemorandumDAO.EstadoValidadoRrhh Then
                'MiForm.btnAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                MiForm.btnValidarRRHH.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                MiForm.btnEnviarLegalRedaccion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            End If
            If MemorandumDAO.EstadoEnvioLegalRedaccion And MemorandumDAO.EstadoValidadoLegalRedaccion And MemorandumDAO.EstadoValidadoRrhh And MemorandumDAO.EstadoNotificado Then
                MiForm.btnAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                MiForm.btnValidarRRHH.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                MiForm.btnEnviarLegalRedaccion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                MiForm.btnAdjuntar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If

            If (MemorandumDAO.EstadoEnvioLegal And MemorandumDAO.EstadoNotificado = False) Then
                MiForm.RibbonPageGroup1.Visible = False
                MiForm.btnEnviarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            End If
            If MemorandumDAO.EstadoValidadoRrhh And MemorandumDAO.EstadoNotificado Then
                MiForm.btnEnviarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                MiForm.btnAnular.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                MiForm.btnAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            End If
            If MemorandumDAO.EstadoValidadoRrhh And MemorandumDAO.EstadoValidadoLegalRedaccion = False Then
                MiForm.sleFalta.Enabled = False
                MiForm.sleSancion.Enabled = False
                MiForm.chkDescuento.Enabled = False
                MiForm.txtMontoDescuento.Enabled = False
                MiForm.txtDescripcionLegal.Enabled = False
            ElseIf MemorandumDAO.EstadoValidadoRrhh And MemorandumDAO.EstadoValidadoLegalRedaccion Then
                MiForm.sleFalta.Enabled = False
                MiForm.sleSancion.Enabled = False
                MiForm.chkDescuento.Enabled = False
            End If
            If MemorandumDAO.EstadoValidadoLegalRedaccion Then
                MiForm.sleFalta.Enabled = False
                MiForm.sleSancion.Enabled = False
            End If
            'If MemorandumDAO.EstadoValidadoRrhh And MemorandumDAO.FirmaDocumento Then
            '    MiForm.btnAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            'End If

            'If MemorandumDAO.EstadoValidadoRrhh Then
            '    MiForm.btnExonerar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'Else
            If MemorandumDAO.EstadoValidadoRrhh = False Then
                MiForm.btnEnviarCorreo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MemorandumDAO.FirmaDocumento Then
                MiForm.btnEnviarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            MiForm.ShowDialog()
            Refrescar()
        End If

        'End If



        'If MemorandumDAO.IdMemorandum <> 0 Then
        '    Dim MiForm As New MemorandumDetails
        '    MiForm.btnValidarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '    MiForm.btnCartaNotarial.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '    MiForm.btnNotificar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '    MiForm.btnGuardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '    MiForm.btnFormatoLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '    MiForm.DtFechaIngresoNotaria.Visible = False
        '    MiForm.lblFechaEnvioNotaria.Visible = False
        '    If GridView1.GetFocusedRowCellValue("ESTADOVALIDADORRHH") Then
        '        MiForm.btnValidarRRHH.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '        MiForm.btnEnviarLegalRedaccion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '        MiForm.btnValidarRedaccion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '        MiForm.btnEnviarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '    Else
        '        MiForm.btnAdjuntar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '        'MiForm.btnEnviarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '        MiForm.btnAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '        MiForm.XtraTabPageAdjuntoDocumentoLegal.PageVisible = False
        '        MiForm.btnEnviarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '        MiForm.btnValidarRedaccion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '    End If
        '    If GridView1.GetFocusedRowCellValue("ESTADOENVIOLEGALREDACCION") And GridView1.GetFocusedRowCellValue("ESTADOVALIDADOLEGALREDACCION") = False Then
        '        MiForm.RibbonPageGroup1.Visible = False
        '        MiForm.btnEnviarLegalRedaccion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '    ElseIf GridView1.GetFocusedRowCellValue("ESTADOENVIOLEGALREDACCION") And GridView1.GetFocusedRowCellValue("ESTADOVALIDADOLEGALREDACCION") Then
        '        MiForm.btnEnviarLegalRedaccion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '    End If
        '    If GridView1.GetFocusedRowCellValue("ESTADOENVIOLEGAL") Then
        '       ' MiForm.btnEnviarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '        MiForm.btnAdjuntar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '        MiForm.btnAnular.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '    End If

        '    If GridView1.GetFocusedRowCellValue("FIRMADOCUMENTO") Or GridView1.GetFocusedRowCellValue("ESTADOVALIDADOLEGAL") Then
        '        MiForm.btnEnviarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '    ElseIf GridView1.GetFocusedRowCellValue("ESTADOVALIDADORRHH") And GridView1.GetFocusedRowCellValue("ESTADOENVIOLEGALREDACCION") And GridView1.GetFocusedRowCellValue("ESTADOVALIDADOLEGALREDACCION") And MemorandumDAO.FirmaDocumento = False Then
        '        MiForm.RibbonPageGroup2.Visible = True
        '        MiForm.btnEnviarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '        MiForm.btnValidarRedaccion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

        '    End If
        '    If GridView1.GetFocusedRowCellValue("FIRMADOCUMENTO") Or GridView1.GetFocusedRowCellValue("ESTADONOTIFICADO") Then
        '        MiForm.btnAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '        MiForm.btnAdjuntar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '    ElseIf GridView1.GetFocusedRowCellValue("FIRMADOCUMENTO") = False Then
        '        MiForm.btnAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '        'Else
        '        '    MiForm.btnAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '    End If



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
        MemorandumDAO.IdMemorandum = GridView1.GetFocusedRowCellValue("IDMEMORANDUM")
        MemorandumDAO.EstadoEnvioLegal = GridView1.GetFocusedRowCellValue("ESTADOENVIOLEGAL")
        If MemorandumDAO.IdMemorandum <> 0 Then
            Dim MiForm As New MemorandumArchivos
            Dim dt As DataTable = MemorandumDAO.ListaMemorandumArchivos(MemorandumDAO.IdMemorandum)
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
                Refrescar()
            Else
                MessageBox.Show("El memorandum no contiene archivo", "Archivo de Memorandum")
            End If
        End If
    End Sub

    'Private Sub btnEnviarLegal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEnviarLegal.ItemClick
    '    MemorandumDAO.IdMemorandum = GridView1.GetFocusedRowCellValue("IDMEMORANDUM")
    '    If MemorandumDAO.IdMemorandum <> 0 And GridView1.GetFocusedRowCellValue("FIRMADOCUMENTO") = 0 Then
    '        If MessageBox.Show("¿Está seguro de enviar el memorandum a legal?", "Envío a Legal", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
    '            MemorandumDAO.EnvioMemorandumLegal(MemorandumDAO.IdMemorandum)
    '        End If
    '    Else
    '        MessageBox.Show("El memorandum se encuentra firmado, no procedera a legal", "Envío a Legal", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
    '    End If
    '    Refrescar()
    'End Sub
    'Private Sub btnRevisar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRevisadoLegal.ItemClick
    '    MemorandumDAO.IdMemorandum = GridView1.GetFocusedRowCellValue("IDMEMORANDUM")
    '    If MemorandumDAO.IdMemorandum <> 0 And GridView1.GetFocusedRowCellValue("ESTADOAPROBADORRHH") Then
    '        If MessageBox.Show("¿Está seguro de revisar el memorandum?", "Revisar Memorandum", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
    '            MemorandumDAO.AprobarMemorandumRRHH(MemorandumDAO.IdMemorandum)
    '        End If
    '    Else
    '        MessageBox.Show("El memorandum tiene debe ser aprobado para proceder con el revisado", "Revisar Memorandum", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
    '    End If

    '    Refrescar()
    'End Sub
    'Private Sub btnAnular_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnular.ItemClick
    '    MemorandumDAO.IdMemorandum = GridView1.GetFocusedRowCellValue("IDMEMORANDUM")

    '    'MemorandumDAO.IdDescargoArchivo = GridView1.GetFocusedRowCellValue("IDSUSTENTOARCHIVO")
    '    Dim MiForm As New MemorandumAnular
    '    MiForm.ShowDialog()
    '    Refrescar()
    'End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub MemorandumList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub RepositoryItemButtonEditFormatoMemo_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEditFormatoMemo.Click
        MemorandumDAO.IdMemorandum = GridView1.GetFocusedRowCellValue("IDMEMORANDUM")
        Dim reportinforme As New RptMemorandum()
        Dim dtcabecera As New DataTable
        dtcabecera = MemorandumDAO.ListaMemorandumGetBy(MemorandumDAO.IdMemorandum)
        Dim dtantecedentes As New DataTable
        dtantecedentes = MemorandumDAO.GetMemorandunAntecedentesTipoList(MemorandumDAO.IdMemorandum)

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
        If dtcabecera.Rows(0).Item("DESCRIPCIONHECHOS") = "" Then
            reportinforme.XrDescripcionHechos.Visible = False
            reportinforme.XrLabel25.Visible = False
        Else
            reportinforme.XrDescripcionHechos.Text = dtcabecera.Rows(0).Item("DESCRIPCIONHECHOS")
        End If


        reportinforme.XrDescripcionLegal.Text = dtcabecera.Rows(0).Item("DESCRIPCIONLEGAL")
        reportinforme.XrMontoDescuento.Text = dtcabecera.Rows(0).Item("MONTODESCUENTO")

        reportinforme.XrSancion.Text = dtcabecera.Rows(0).Item("SANCION")
        reportinforme.XrFalta.Text = dtcabecera.Rows(0).Item("FALTA")

        Dim xDiasSancion As String
        xDiasSancion = dtcabecera.Rows(0).Item("DIASANCION")
        If xDiasSancion <> "" Then
            reportinforme.XrDiaSancion.Text = dtcabecera.Rows(0).Item("DIASANCION")
        Else
            reportinforme.XrDiaSancion.Visible = False
            reportinforme.lblDiasSancion.Visible = False
        End If

        Dim xDescuento As Boolean
        xDescuento = dtcabecera.Rows(0).Item("DESCUENTOREMUNERATIVO")
        If xDescuento Then
            reportinforme.XrDescuentoRemunerativo.Visible = True
            reportinforme.XrMontoDescuento.Visible = True
            reportinforme.XrMoneda.Visible = True
        Else
            reportinforme.XrDescuentoRemunerativo.Visible = False
            reportinforme.XrMontoDescuento.Visible = False
            reportinforme.XrMoneda.Visible = False
        End If
        If dtantecedentes.Rows.Count > 0 Then
            For i As Integer = 0 To dtantecedentes.Rows.Count - 1
                Dim row As New XRTableRow
                For j As Integer = 0 To 3
                    Dim cell As New XRTableCell
                    cell.Text = dtantecedentes.Rows(i).Item(j)
                    row.Cells.Add(cell)

                Next j
                row.Cells.Item(0).WidthF = 52
                row.Cells.Item(1).WidthF = 52
                row.Cells.Item(2).WidthF = 208
                row.Cells.Item(3).WidthF = 99

                reportinforme.XrTable2.Rows.Add(row)
            Next
            reportinforme.XrTableCell1.WidthF = 80
            reportinforme.XrTableCell2.WidthF = 79
            reportinforme.XrTableCell3.WidthF = 322
            reportinforme.XrTableCell4.WidthF = 152
        Else
            reportinforme.XrTable1.Visible = False
            reportinforme.XrTable2.Visible = False
            reportinforme.XrAntecedentes.Text = "NINGUNO"
        End If

        ReportView.DocumentViewer.DocumentSource = reportinforme
        ReportView.DocumentViewer.Refresh()
        ReportView.Show()

    End Sub

    Private Sub RepositoryItemButtonDescargo_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonDescargo.Click
        MemorandumDAO.IdMemorandum = GridView1.GetFocusedRowCellValue("IDMEMORANDUM")
        If MemorandumDAO.IdMemorandum <> 0 Then
            Dim MiForm As New MemorandumDescargo
            Dim dt As DataTable = MemorandumDAO.GetMemorandumDescargoAll(MemorandumDAO.IdMemorandum)
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
                MessageBox.Show("El memorandum no contiene archivo", "Archivo de Memorandum")
            End If
        Else
            MessageBox.Show("El memorandum no contiene archivo ", "Archivo de Memorandum Descargo")
        End If

    End Sub
End Class