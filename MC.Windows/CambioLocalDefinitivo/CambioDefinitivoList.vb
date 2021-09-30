Imports MC.Data
Imports MC.Framework
Public Class CambioDefinitivoList

    Dim bsCambioDefinitivo As New BindingSource
    Sub New()

        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDFORMATOCAMBIO", "IDFORMATOCAMBIO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO VALIDADO", "ESTADOVALIDADO", 120, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO CAMBIO", "NUMEROFORMATOCAMBIO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA SOLICITUD", "FECHA", 130, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA VALIDADO", "FECHABLOQUEO", 130, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "SOLICITANTE", "SOLICITANTE", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EMPLEADO", "EMPLEADO", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DOCUMENTO", "NUMERODOCUMENTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO ACTUAL", "ESTADOACTUALEMPLEADO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO ACTUAL", "CARGOACTUAL", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO NUEVO", "NUEVOCARGO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "LOCAL ORIGEN", "RAZONCOMERCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "LOCAL DESTINO", "NUEVOLOCAL", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUEVO CONTRATO", "NUEVOCONTRATO", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA CAMBIO", "FECHACAMBIO", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA FIRMA", "FECHAATENCION", 150, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "HORA ATENCIÓN", "HORAATENCION", 150, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDLOCAL", "IDLOCAL", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDSITIO", "IDSITIO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDESTADO", "IDESTADO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDEMPLEADO", "IDEMPLEADO", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridView1
            .Columns("NUMEROFORMATOCAMBIO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("SOLICITANTE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("EMPLEADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUEVOLOCAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHACAMBIO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAATENCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("HORAATENCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        Me.GridControl1.DataSource = bsCambioDefinitivo
        Refrescar()

    End Sub
    Private Sub Refrescar()
        Try
            btnExportar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            btnEvaluar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Dim dtAccionesbutton As DataTable
            dtAccionesbutton = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(Ribbon, dtAccionesbutton)

            bsCambioDefinitivo.DataSource = CambioLocalDefinitivoDAO.CambioDefinitivoLocalListAll()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEvaluar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEvaluar.ItemClick
        Dim estadovalidado As Boolean = GridView1.GetFocusedRowCellValue("ESTADOVALIDADO")
        CambioLocalDefinitivoDAO.FormatoEnvioCorreoSitio = GridView1.GetFocusedRowCellValue("IDSITIO")
        Dim nuevolocal As String = GridView1.GetFocusedRowCellValue("NUEVOLOCAL").ToString
        Dim nuevocontrato As String = GridView1.GetFocusedRowCellValue("NUEVOCONTRATO").ToString

        CambioLocalDefinitivoDAO.IdCambioDefinitivo = GridView1.GetFocusedRowCellValue("IDFORMATOCAMBIO")
        CambioLocalDefinitivoDAO.IdLocal = GridView1.GetFocusedRowCellValue("IDLOCAL")
        Dim ESTADOEMPLEADO = GridView1.GetFocusedRowCellValue("IDESTADO")
        CambioLocalDefinitivoDAO.IdEmpleado = GridView1.GetFocusedRowCellValue("IDEMPLEADO").ToString
        'Dim MiForm As New CambioDefinitivoDetails
        Dim MiForm As New CambioRazonIngresoEmpleadoEdit
        Dim mensaje As String = ""

        If nuevolocal <> "" Then
            mensaje = "cambio de razon social"
            MiForm.txtFlat.Text = 0
        ElseIf nuevocontrato <> "" Then
            mensaje = "cambio de tipo de contrato"
            MiForm.txtFlat.Text = 1
        Else
            mensaje = "cambio de puesto"
        End If
        If nuevolocal <> "" Or nuevocontrato <> "" Then ' razon social
            If ESTADOEMPLEADO = 1 Then
                'MiForm.btnRegistrarEmpleado.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                MessageBox.Show("Para poder proceder con el " & mensaje & " el colaborador tiene que estar cesado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MiForm.btnRegistrarEmpleado.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            If CambioLocalDefinitivoDAO.IdEmpleado <> 0 Then
                MiForm.ShowDialog()
            End If
            Refrescar()
        End If

        Else 'cargo
            Dim MiForm1 As New CambioCargoDetails
            MiForm1.Text = "CAMBIO DE PUESTO"
            MiForm1.ShowDialog()
            Refrescar()
        End If

    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        If btnEvaluar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
            btnEvaluar.PerformClick()
        End If
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Me.Refrescar()
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub CambioDefinitivoList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub btnExportar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportar.ItemClick
        If GridView1.RowCount > 0 Then
            GridView1.Columns(1).Visible = False
            Try
                Dim ruta As String
                ruta = My.Application.Info.DirectoryPath() + "\SolicitudesCambiosDefinitivos.xlsx"
                GridControl1.ExportToXlsx(ruta)
                Process.Start(ruta)

            Catch ex As Exception
                MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
            End Try
            GridView1.Columns(0).VisibleIndex = 1
            GridView1.Columns(1).Visible = 1
        End If
    End Sub
End Class