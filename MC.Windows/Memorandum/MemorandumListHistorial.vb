Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework

Public Class MemorandumListHistorial

    Dim bsMemorandums As New BindingSource

    Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDMEMORANDUM", "IDMEMORANDUM", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO MEMORANDUM", "NUMEROINFORME", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)


        ControlesDevExpress.InitGridViewColumn(GridView1, "EST.VALIDADO", "ESTADOVALIDADORRHH", 83, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ENV.REDACCIÓN", "ESTADOENVIOLEGALREDACCION", 100, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EST.REDACCIÓN", "ESTADOVALIDADOLEGALREDACCION", 100, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DOC.FIRMA", "FIRMADOCUMENTO", 75, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ENV.LEGAL", "ESTADOENVIOLEGAL", 75, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EST. LEGAL", "ESTADOVALIDADOLEGAL", 75, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EST. NOTIFICADO", "ESTADONOTIFICADO", 100, True, ControlesDevExpress.eGridViewFormato.Checked, False)


        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA SOLICITUD", "FECHA", 120, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EMPLEADO", "EMPLEADO", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DNI EMPLEADO", "EMPLEADODNI", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO", "EMPLEADOCARGO", 280, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FALTA", "FALTA", 280, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "PESO SANCION", "PESOSANCION", 280, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO MEMORANDUN", "ESTADOMEMORANDUM", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "USUARIO ANULADO", "USUARIOANULADO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)


        With GridView1
            .Columns("NUMEROINFORME").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("EMPLEADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("EMPLEADODNI").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("EMPLEADOCARGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("USUARIOANULADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        btnFechaInicial.EditValue = DateTime.Now.Date.AddDays(-30)
        btnFechaFinal.EditValue = DateTime.Now.Date

        AddHandler btnFechaFinal.EditValueChanged, AddressOf Refrescar

        Me.GridControl1.DataSource = bsMemorandums
        Refrescar()

    End Sub

    Public Sub Refrescar()
        Try
            btnExportar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            GridView1.Columns.Item("FORMATOINFORME").Visible = False
            GridView1.Columns.Item("FORMATOMEMORANDUM").Visible = False
            GridView1.Columns.Item("MEMORANDUM").Visible = False
            GridView1.Columns.Item("DESCARGO").Visible = False
            GridView1.Columns.Item("NOTARIA").Visible = False
            Dim dtAccionesbutton As DataTable
            dtAccionesbutton = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(Ribbon, dtAccionesbutton)

            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioGrid(GridView1, dtAccionesUsuario)
            bsMemorandums.DataSource = MemorandumDAO.GetAllMemorandumsHistorial(btnFechaInicial.EditValue, btnFechaFinal.EditValue)
            If GridView1.Columns.Item("FORMATOINFORME").Visible Then
                GridView1.Columns.Item("FORMATOINFORME").VisibleIndex = 0
            End If
            If GridView1.Columns.Item("FORMATOMEMORANDUM").Visible Then
                GridView1.Columns.Item("FORMATOMEMORANDUM").VisibleIndex = 1
            End If
            If GridView1.Columns.Item("MEMORANDUM").Visible Then
                GridView1.Columns.Item("MEMORANDUM").VisibleIndex = 2
            End If
            If GridView1.Columns.Item("DESCARGO").Visible Then
                GridView1.Columns.Item("DESCARGO").VisibleIndex = 3
            End If
            If GridView1.Columns.Item("NOTARIA").Visible Then
                GridView1.Columns.Item("NOTARIA").VisibleIndex = 4
            End If
            'GridView1.Columns.Item("NUMEROINFORME").VisibleIndex = 14
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

    Private Sub MemorandumListHistorial_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub
    Private Sub RepositoryItemMemorandumArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemMemorandumArchivo.Click
        MemorandumDAO.IdMemorandum = GridView1.GetFocusedRowCellValue("IDMEMORANDUM")
        If MemorandumDAO.IdMemorandum <> 0 Then
            Dim MiForm As New MemorandumArchivos
            MiForm.btnFirmaDocumento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnEliminarFormatos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
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
            Else
                MessageBox.Show("El memorandum no contiene archivo", "Archivo de Memorandum")
            End If
        End If
    End Sub

    Private Sub RepositoryItemDescargoArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemDescargoArchivo.Click
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

    Private Sub btnExportar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportar.ItemClick
        If GridView1.RowCount > 0 Then
            GridView1.Columns(0).Visible = False
            GridView1.Columns(1).Visible = False

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
            GridView1.Columns(0).Visible = True
            GridView1.Columns(1).Visible = True
        End If
    End Sub

    Private Sub RepositoryItemFormatoInforme_Click(sender As Object, e As EventArgs) Handles RepositoryItemFormatoInforme.Click
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

    Private Sub RepositoryItemFormatoMemorandum_Click(sender As Object, e As EventArgs) Handles RepositoryItemFormatoMemorandum.Click
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

        reportinforme.XrDescripcionLegal.Text = dtcabecera.Rows(0).Item("DESCRIPCIONLEGAL")
        reportinforme.XrMontoDescuento.Text = dtcabecera.Rows(0).Item("MONTODESCUENTO")

        reportinforme.XrSancion.Text = dtcabecera.Rows(0).Item("SANCION")
        reportinforme.XrFalta.Text = dtcabecera.Rows(0).Item("FALTA")

        If dtcabecera.Rows(0).Item("DESCRIPCIONHECHOS") = "" Then
            reportinforme.XrDescripcionHechos.Visible = False
            reportinforme.XrLabel25.Visible = False
        Else
            reportinforme.XrDescripcionHechos.Text = dtcabecera.Rows(0).Item("DESCRIPCIONHECHOS")
        End If

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

    Private Sub RepositoryItemNotarialArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemNotarialArchivo.Click
        MemorandumDAO.IdMemorandum = GridView1.GetFocusedRowCellValue("IDMEMORANDUM")
        Dim dt As New DataTable
        dt = MemorandumDAO.ListMemorandumFormatoLegalID(MemorandumDAO.IdMemorandum)
        If dt.Rows.Count > 0 Then
            If MessageBox.Show("¿Está seguro de descargar el archivo?", "Descargar Archvivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                If MemorandumDAO.IdMemorandum <> 0 Then
                    Dim ruta As String = dt.Rows(0).Table(0)("linkdescarga").ToString()
                    Dim uccontrol1 As New XtraUserControlWebBrowser()
                    uccontrol1.WebBrowser1.Show()
                    uccontrol1.WebBrowser1.Navigate(String.Format(ruta, Application.StartupPath))
                End If
            End If
        Else
            MessageBox.Show("El memorandum no contiene archivo notarial", "Archivo de Memorandum Descargo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class