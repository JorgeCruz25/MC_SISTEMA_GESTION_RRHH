Imports DevExpress.XtraBars
Imports DevExpress.XtraReports.UI
Imports MC.Data
Imports MC.Framework
Public Class EmpleadoModificacionDatos
    Dim bsEmpleados As New BindingSource
    Sub New()


        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDEMPLEADO", "IDEMPLEADO", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBRES", "NOMBRES", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "APELLIDO PATERNO", "APELLIDOPATERNO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "APELLIDO MATERNO", "APELLIDOMATERNO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DE DOCUMENTO", "NUMERODOCUMENTO", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO", "CARGO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO", "ESTADOEMPLEADO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO REGISTRO", "ESTADOREGISTRO", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CODIGO UNICO", "CODIGOUNICO", 110, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridView1
            .Columns("NOMBRES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOPATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOMATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CARGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        Refrescar()
    End Sub
    Private Sub Refrescar()
        Try
            inabilitarbotones()
            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(RibbonControl, dtAccionesUsuario)


            bsEmpleados.DataSource = BDAccionPersonalDAO.GetEmpleadoAccionPersonalList(BDCentralDAO.UsuarioBE.IDUsuario)
            Me.GridControl1.DataSource = bsEmpleados
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub inabilitarbotones()
        '--------------------------- falta colocar botones para inabilitar (modulo de segiridad)
    End Sub

    Private Sub EmpleadoModificacionDatos_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        btnEvaluar.PerformClick()
    End Sub

    Private Sub btnEvaluar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnEvaluar.ItemClick
        Dim nombre As String = GridView1.GetFocusedRowCellValue("NOMBRES")
        Dim apellidopaterno As String = GridView1.GetFocusedRowCellValue("APELLIDOPATERNO")
        Dim apellidomaterno As String = GridView1.GetFocusedRowCellValue("APELLIDOMATERNO")
        Dim numerodocumento As String = GridView1.GetFocusedRowCellValue("NUMERODOCUMENTO")
        Dim MiForm As New OpcionesModificar
        If GridView1.GetFocusedRowCellValue("CODIGOUNICO") <> "" Then
            MiForm.BarStaticItemEmpleado.Caption = "Nombre colaborado: " + nombre + " " + apellidopaterno + " " + apellidomaterno
            MiForm.BarStaticItemNumeroDocumento.Caption = "Numero documento: " + numerodocumento
            MiForm.txtIdEmpleadoRenovacionContrato.Text = GridView1.GetFocusedRowCellValue("IDEMPLEADO")
            MiForm.txtCodigoUnicoRenovacionContrato.Text = GridView1.GetFocusedRowCellValue("CODIGOUNICO")
            MiForm.txtIdEmpleadoFechaCese.Text = GridView1.GetFocusedRowCellValue("IDEMPLEADO")
            MiForm.txtCodigoUnicoFechaCese.Text = GridView1.GetFocusedRowCellValue("CODIGOUNICO")
            MiForm.ShowDialog()
        End If
    End Sub

    'Private Sub btnImprimir_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnImprimir.ItemClick
    '    If MessageBox.Show("Esta Segura de imprimir el formato de renovaciones de contrato", "Impresion de Renovación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
    '        'For i As Integer = 0 To GridView1.RowCount - 1
    '        '    Dim dtdatos As DataTable
    '        '    Dim idrenovacion As Integer = GridView1.GetRowCellValue(i, "IDRENOVACIONCONTRATODETALLE")
    '        '    dtdatos = RenovacionContratoDAO.DatosRenovarContrato(idrenovacion)
    '        '    Dim tipocontrato As String
    '        '    Dim cargo As String
    '        '    tipocontrato = GridView1.GetRowCellValue(i, "TIPOCONTRATO")
    '        '    cargo = GridView1.GetRowCellValue(i, "IDCARGO")

    '        Dim rptContrato As New NMRegGeneraBanOperativoRenovacion
    '        'rptContrato.XrTexto1.Text = dtdatos.Rows(0)("TEXTO1")
    '        'rptContrato.XrTexto2.Text = dtdatos.Rows(0)("TEXTO2")
    '        'rptContrato.XrTexto3.Text = dtdatos.Rows(0)("TEXTO3")
    '        'rptContrato.XrTexto4.Text = dtdatos.Rows(0)("TEXTO4")
    '        'rptContrato.XrTexto5.Text = dtdatos.Rows(0)("TEXTO5")
    '        Try
    '            'Dim ruta As String
    '            'ruta = My.Application.Info.DirectoryPath() + "\renovacion_" + Convert.ToString(i + 1) + ".pdf"
    '            'rptContrato.ExportToPdf(ruta)
    '            'Process.Start(ruta)
    '            '-------------------------------------
    '            Dim printTool As New ReportPrintTool(rptContrato)
    '            printTool.Print()
    '            '-------------------------------------
    '        Catch ex As Exception
    '            MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
    '            Exit Sub
    '        End Try
    '        'Next

    '    End If
    'End Sub
End Class