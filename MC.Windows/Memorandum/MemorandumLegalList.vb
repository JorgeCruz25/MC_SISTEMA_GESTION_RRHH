Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework
Public Class MemorandumLegalList
    Dim bsMemorandums As New BindingSource
    Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDMEMORANDUM", "IDMEMORANDUM", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "REDACCIÓN", "ESTADOENVIOLEGALREDACCION", 80, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "VALIDADO REDACCIÓN", "ESTADOVALIDADOLEGALREDACCION", 80, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NEGACIÓN FIRMA", "ESTADOENVIOLEGAL", 110, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO MEMORANDUM", "NUMEROINFORME", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA SOLICITUD", "FECHA", 120, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EMPLEADO", "EMPLEADO", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DNI", "EMPLEADODNI", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO", "EMPLEADOCARGO", 280, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDEMPLEADO", "IDEMPLEADO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)

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
            btnEvaluarMemorandumLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            GridView1.Columns.Item("MEMORANDUM").Visible = False
            GridView1.Columns.Item("INFORME").Visible = False
            Dim dtAccionesbutton As DataTable
            dtAccionesbutton = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(Ribbon, dtAccionesbutton)

            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioGrid(GridView1, dtAccionesUsuario)
            bsMemorandums.DataSource = MemorandumDAO.GetAllMemorandumsLegal()

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

    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub
    Private Sub MemorandumLegalList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub
    Private Sub RepositoryItemMemorandumArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemMemorandumArchivo.Click
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
    Private Sub RepositoryItemAnular_Click(sender As Object, e As EventArgs) Handles RepositoryItemAnular.Click
        MemorandumDAO.IdMemorandum = GridView1.GetFocusedRowCellValue("IDMEMORANDUM")
        If MemorandumDAO.IdMemorandum <> 0 Then
            Dim MiForm As New MemorandumAnular
            MiForm.btnAdjuntar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.GridControl1.Visible = False
            MiForm.ShowDialog()
            Refrescar()
        End If
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
        If dtcabecera.Rows(0).Item("CORRECCIONREDACCIONRRHH") = "" Then
            reportinforme.XrDescripcionMemorandum.Text = dtcabecera.Rows(0).Item("DESCRIPCION")
        Else
            reportinforme.XrDescripcionMemorandum.Text = dtcabecera.Rows(0).Item("CORRECCIONREDACCIONRRHH")
        End If

        ReportView.DocumentViewer.DocumentSource = reportinforme
        ReportView.DocumentViewer.Refresh()
        ReportView.Show()
    End Sub
    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        If btnEvaluarMemorandumLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
            btnEvaluarMemorandumLegal.PerformClick()
        End If
    End Sub

    Private Sub btnEvaluarMemorandumLegal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEvaluarMemorandumLegal.ItemClick
        MemorandumDAO.IdMemorandum = GridView1.GetFocusedRowCellValue("IDMEMORANDUM")
        MemorandumDAO.IdEmpleado = GridView1.GetFocusedRowCellValue("IDEMPLEADO")
        Dim EnvioRedaccion As Boolean = GridView1.GetFocusedRowCellValue("ESTADOENVIOLEGALREDACCION")
        Dim EstadoEnvioLegal As Boolean = GridView1.GetFocusedRowCellValue("ESTADOENVIOLEGAL")
        If MemorandumDAO.IdMemorandum <> 0 Then
            Dim MiForm As New MemorandumDetails
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            MiForm.btnFormatoLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnNotificar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnValidarRedaccion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnValidarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnRetornarMemorandum.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnGuardarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            Dim dtAccionesUsuarioDetalle As DataTable
            dtAccionesUsuarioDetalle = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, MiForm.Name)
            Tools.AccionesUsuarioRibbon(MiForm.RibbonControl, dtAccionesUsuarioDetalle)


            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            MiForm.btnGuardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnValidarRRHH.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnAdjuntar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnCartaNotarial.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnHistorialEmpleado.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnNotificar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            MiForm.btnAnular.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnEnviarLegalRedaccion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnEnviarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnExonerar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnEnviarCorreo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'MiForm.btnRetornarMemorandum.Visibility = DevExpress.XtraBars.BarItemVisibility.Never



            MiForm.lblDiasSancion.Visible = False
            MiForm.txtDiasSancion.Visible = False
            MiForm.lblFechaEnvioNotaria.Visible = False
            MiForm.DtFechaIngresoNotaria.Visible = False

            If (EnvioRedaccion And EstadoEnvioLegal) Or (EnvioRedaccion = False And EstadoEnvioLegal) Then
                MiForm.btnValidarRedaccion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Else
                MiForm.btnValidarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                MiForm.RibbonPageGroup1.Visible = False
            End If
            MiForm.ShowDialog()
            Refrescar()
        End If
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub
End Class