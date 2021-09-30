Imports DevExpress.XtraBars
Imports MC.Data
Imports MC.Framework
Public Class RespuestaPlanillaDetails
    Dim bsPlanillaConsultaGenerada As New BindingSource
    Dim bsPlanillaConsultaEnRevision As New BindingSource
    Dim bsPlanillaConsultaRevisado As New BindingSource
    Sub New()

        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.WindowState = FormWindowState.Maximized
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True
        Me.GridControl4.Visible = False
        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDPLANILLADETALLECONCEPTO", "IDPLANILLADETALLECONCEPTO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDPLANILLADETALLE", "IDPLANILLADETALLE", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MATRICULA", "MATRICULA", 90, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDSOLICITUDPLANILLA", "IDSOLICITUDPLANILLA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBRESAPELLIDOS", "NOMBRESAPELLIDOS", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "SEDE", "RAZONCOMERCIAL", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHAINGRESO", "FECHAINGRESO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CONCEPTO", "CONCEPTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IMPORTE_PAGADO", "SUELDOBASICO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DESCRIPCIONSOLICITUD", "DESCRIPCIONSOLICITUD", 500, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO_RESPUESTA", "RESPUESTA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IMPORTE_INTEGRAR", "IMPORTEINTEGRO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IMPORTE_DESCONTAR", "IMPORTEDESCUENTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RESPUESTA_SOLICITUD", "RESPUESTASOLICITUD", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO_SOLICITUD", "ESTADOSOLICITUD", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)


        ControlesDevExpress.InitGridControl(GridControl2)
        ControlesDevExpress.InitGridViewColumn(GridView2, "IDPLANILLADETALLECONCEPTO", "IDPLANILLADETALLECONCEPTO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "IDPLANILLADETALLE", "IDPLANILLADETALLE", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "MATRICULA", "MATRICULA", 90, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "IDSOLICITUDPLANILLA", "IDSOLICITUDPLANILLA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "NOMBRESAPELLIDOS", "NOMBRESAPELLIDOS", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "SEDE", "RAZONCOMERCIAL", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "FECHAINGRESO", "FECHAINGRESO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "IMPORTE_PAGADO", "SUELDOBASICO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "CONCEPTO", "CONCEPTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "DESCRIPCIONSOLICITUD", "DESCRIPCIONSOLICITUD", 500, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "ESTADO_RESPUESTA", "RESPUESTA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "IMPORTE_INTEGRAR", "IMPORTEINTEGRO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "IMPORTE_DESCONTAR", "IMPORTEDESCUENTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "RESPUESTA_SOLICITUD", "RESPUESTASOLICITUD", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "ESTADO_SOLICITUD", "ESTADOSOLICITUD", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)


        'ControlesDevExpress.InitGridControl(GridControl3)
        'ControlesDevExpress.InitGridViewColumn(GridView3, "IDPLANILLADETALLECONCEPTO", "IDPLANILLADETALLECONCEPTO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView3, "IDPLANILLADETALLE", "IDPLANILLADETALLE", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView3, "MATRICULA", "MATRICULA", 90, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView3, "NOMBRESAPELLIDOS", "NOMBRESAPELLIDOS", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView3, "SEDE", "RAZONCOMERCIAL", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView3, "FECHAINGRESO", "FECHAINGRESO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView3, "IMPORTE_PAGADO", "SUELDOBASICO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView3, "CONCEPTO", "CONCEPTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView3, "DESCRIPCIONSOLICITUD", "DESCRIPCIONSOLICITUD", 500, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView3, "ESTADO_RESPUESTA", "RESPUESTA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView3, "IMPORTE_INTEGRAR", "IMPORTEINTEGRO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView3, "IMPORTE_DESCONTAR", "IMPORTEDESCUENTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView3, "RESPUESTA_SOLICITUD", "RESPUESTASOLICITUD", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO_SOLICITUD", "ESTADOSOLICITUD", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView3, "IDSOLICITUDPLANILLA", "IDSOLICITUDPLANILLA", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridView1
            .Columns("MATRICULA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOMBRESAPELLIDOS").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAINGRESO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("SUELDOBASICO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CONCEPTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("DESCRIPCIONSOLICITUD").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains


        End With
        With GridView2
            .Columns("MATRICULA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOMBRESAPELLIDOS").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAINGRESO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("SUELDOBASICO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CONCEPTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RESPUESTA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("DESCRIPCIONSOLICITUD").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RESPUESTA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("IMPORTEINTEGRO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        Me.GridControl1.DataSource = bsPlanillaConsultaGenerada
        Me.GridControl2.DataSource = bsPlanillaConsultaEnRevision
        'Me.GridControl3.DataSource = bsPlanillaConsultaRevisado
        RefrescarConsultasGenerdas()
        RefrescarConsultasEnRevision()
        'RefrescarConsultasRevisadas()

    End Sub
    Private Sub RefrescarConsultasGenerdas()
        Try
            bsPlanillaConsultaGenerada.DataSource = PlanillaDAO.PlanillaConsultasGeneradasGetIdPlanilla(PlanillaDAO.IdPlanilla)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub RefrescarConsultasEnRevision()
        Try
            bsPlanillaConsultaEnRevision.DataSource = PlanillaDAO.PlanillaConsultasEnRevisionGetIdPlanilla(PlanillaDAO.IdPlanilla)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Private Sub RefrescarConsultasRevisadas()
    '    Try
    '        bsPlanillaConsultaRevisado.DataSource = PlanillaDAO.PlanillaConsultasRevisadasGetIdPlanilla(PlanillaDAO.IdPlanilla)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnExportar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnExportar.ItemClick
        RefrescarConsultasGenerdas()
        RefrescarConsultasEnRevision()
        If GridView1.RowCount = 0 And GridView2.RowCount = 0 Then
            MessageBox.Show("No existe impormación para exportar", "Mensaje Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'RefrescarConsultasRevisadas()


        If GridView2.RowCount = 0 Then
                For i As Integer = 0 To GridView1.RowCount - 1
                    PlanillaDAO.AsignarRevisionConceptoPlanilla(GridView1.GetRowCellValue(i, "IDPLANILLADETALLECONCEPTO"), BDCentralDAO.UsuarioBE.IDUsuario)
                Next
                Try
                    Dim ruta As String
                    ruta = My.Application.Info.DirectoryPath() + "\ConsultaPlanillaSueldo.xlsx"
                    GridControl1.ExportToXlsx(ruta)
                Process.Start(ruta)
            Catch ex As Exception
                    MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
                End Try
            Else
                Try
                    Dim ruta As String
                    ruta = My.Application.Info.DirectoryPath() + "\ConsultaPlanillaSueldo.xlsx"
                GridControl2.ExportToXlsx(ruta)
                Process.Start(ruta)

            Catch ex As Exception
                    MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
                End Try
            End If
            RefrescarConsultasGenerdas()
            RefrescarConsultasEnRevision()
        'RefrescarConsultasRevisadas()

    End Sub

    Private Sub btnImportar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnImportar.ItemClick
        If GridView2.RowCount = 0 Then
            MessageBox.Show("no existen registros para importar.")
        Else


            OpenFileDialog1.Filter = "Excel |*.xlsx"
            Dim result As DialogResult = OpenFileDialog1.ShowDialog()
            If result = Windows.Forms.DialogResult.OK Then
                Dim path As String = OpenFileDialog1.FileName
                Try
                    Dim workbook As Spire.Xls.Workbook = New Spire.Xls.Workbook
                    workbook.LoadFromFile(path)
                    Dim sheet As Spire.Xls.Worksheet = workbook.Worksheets(0)
                    Me.GridControl4.DataSource = sheet.ExportDataTable
                    Me.btnImportar.Enabled = False
                Catch ex As Exception
                    MessageBox.Show("Error al importar Data", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End If
            If GridView4.RowCount > 0 Then
                Dim ResultMatricula As Int32 = 0
                Dim ResultRespuesta As Int32 = 0
                Dim ResultImporteIntegrar As Int32 = 0
                Dim ResultImporteDescuento As Int32 = 0
                Dim ResultRespuestaDescripcion As Int32 = 0
                Dim ResultConcepto As Int32 = 0
                Dim ResultSolicitud As Int32 = 0
                For i As Integer = 0 To GridView4.Columns.Count - 1
                    Dim nameColum As String = Replace(GridView4.Columns.Item(i).Name, "col", "").Trim
                    If nameColum = "MATRICULA" Then
                        ResultMatricula = 1
                    ElseIf nameColum = "CONCEPTO" Then
                        ResultConcepto = 1
                    ElseIf nameColum = "ESTADO_RESPUESTA" Then
                        ResultRespuesta = 1
                    ElseIf nameColum = "IMPORTE_INTEGRAR" Then
                        ResultImporteIntegrar = 1
                    ElseIf nameColum = "IMPORTE_DESCONTAR" Then
                        ResultImporteDescuento = 1
                    ElseIf nameColum = "RESPUESTA_SOLICITUD" Then
                        ResultRespuestaDescripcion = 1
                    ElseIf nameColum = "ESTADO_SOLICITUD" Then
                        ResultSolicitud = 1
                    End If
                Next
                If ResultMatricula = 1 And ResultRespuesta = 1 And ResultImporteIntegrar = 1 And ResultImporteDescuento = 1 And ResultRespuestaDescripcion = 1 And ResultConcepto = 1 And ResultSolicitud = 1 Then
                    If GridView2.RowCount > 0 Then
                        Dim IDSOLICITUDPLANILLA As Integer

                        Dim importeinte As Double
                            Dim importedes As Double
                            For i As Integer = 0 To GridView4.RowCount - 1
                            IDSOLICITUDPLANILLA = GridView4.GetRowCellValue(i, "IDSOLICITUDPLANILLA")
                            importeinte = GridView4.GetRowCellValue(i, "IMPORTE_INTEGRAR")
                                importedes = GridView4.GetRowCellValue(i, "IMPORTE_DESCONTAR")
                                If IsNumeric(importeinte) And IsNumeric(importedes) Then
                                    PlanillaDAO.RevisarConceptoPlanilla(IDSOLICITUDPLANILLA, GridView4.GetRowCellValue(i, "MATRICULA"), GridView4.GetRowCellValue(i, "CONCEPTO"), GridView4.GetRowCellValue(i, "ESTADO_RESPUESTA"), GridView4.GetRowCellValue(i, "RESPUESTA_SOLICITUD"), importeinte, importedes, GridView4.GetRowCellValue(i, "ESTADO_SOLICITUD"), BDCentralDAO.UsuarioBE.IDUsuario)
                                End If
                            Next

                        btnRefrescar.PerformClick()
                    Else
                        MessageBox.Show("No existen consultas por revisar", "Mensaje de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                Else
                    MessageBox.Show("La importación debe tener las siguientes columnas: MATRICULA,ESTADO_RESPUESTA,IMPORTE_INTEGRAR,IMPORTE_DESCONTAR,ESTADO_SOLICITUD", "Mensaje de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnRefrescar.ItemClick
        RefrescarConsultasGenerdas()
        RefrescarConsultasEnRevision()
        'RefrescarConsultasRevisadas()
    End Sub

    Private Sub Historico_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Historico.ItemClick
        Dim MiForm As New RespuestaPlanillaHistorial
        MiForm.BbiAnio.Caption = BbiAnio.Caption
        MiForm.BbiAnio.Caption = BbiMes.Caption
        MiForm.ShowDialog()
    End Sub
End Class