Imports MC.Data
Imports MC.Framework
Imports Spire.Xls

Public Class EmpleadoIngresoList

    Dim bsEmpleadoIngreso As New BindingSource
    Dim bsEmpleadoReingreso As New BindingSource
    Dim FlatCargaDatos As Int32

    Sub New()

        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDINGRESOEMPLEADO", "IDINGRESOEMPLEADO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO INGRESO", "NUMEROINGRESO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA REGISTRO", "FECHA", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MATRICULA", "MATRICULA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EMPLEADO", "EMPLEADO", 240, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DE DOCUMENTO", "NUMERODOCUMENTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO", "CARGO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA INGRESO", "FECHAINGRESOCOMPANIA", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDEMPLEADO", "IDEMPLEADO", 100, False, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO REQUERIMIENTO", "NUMEROREQUERIMIENTOPERSONAL", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA PROCESO REQUERIMIENTO", "FECHACIERRE", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridView1
            .Columns("NUMEROINGRESO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("MATRICULA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("EMPLEADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CARGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMEROREQUERIMIENTOPERSONAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHACIERRE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        '------------------------------------------------------------------------------------------------------------------------------------
        ControlesDevExpress.InitGridControl(GridControl2)
        ControlesDevExpress.InitGridViewColumn(GridView2, "ID REINGRESO EMPLEADO", "IDREINGRESOEMPLEADO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "NUMERO REINGRESO", "NUMEROREINGRESO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "FECHA REGISTRO", "FECHA", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "MATRICULA", "MATRICULA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "EMPLEADO", "EMPLEADO", 240, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "N° DE DOCUMENTO", "NUMERODOCUMENTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "CARGO", "CARGO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "RAZON SOCIAL", "RAZONSOCIAL", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "RAZON COMERCIAL", "RAZONCOMERCIAL", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "FECHA INGRESO", "FECHAINGRESOCOMPANIA", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "IDEMPLEADO", "IDEMPLEADO", 100, False, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "NUMERO REQUERIMIENTO", "NUMEROREQUERIMIENTOPERSONAL", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "FECHA PROCESO REQUERIMIENTO", "FECHACIERRE", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridView2
            .Columns("NUMEROREINGRESO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("MATRICULA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("EMPLEADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CARGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMEROREQUERIMIENTOPERSONAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHACIERRE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        '------------------------------------------------------------------------------------------------------------------------------

        btnFechaInicial.EditValue = DateTime.Now.Date.AddDays(-30)
        btnFechaFinal.EditValue = DateTime.Now.Date

        AddHandler btnFechaFinal.EditValueChanged, AddressOf Refrescar

        Me.GridControl1.DataSource = bsEmpleadoIngreso
        Me.GridControl2.DataSource = bsEmpleadoReingreso
        Refrescar()
    End Sub

    Public Sub Refrescar()
        Try
            inabilitarbotones()
            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(RibbonControl, dtAccionesUsuario)
            bsEmpleadoIngreso.DataSource = BDAccionPersonalDAO.GetEmpleadoIngresoList(btnFechaInicial.EditValue, btnFechaFinal.EditValue)
            bsEmpleadoReingreso.DataSource = BDAccionPersonalDAO.GetEmpleadoReingresoList(btnFechaInicial.EditValue, btnFechaFinal.EditValue)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub inabilitarbotones()
        btnIngresoPersonal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnExportarIngresos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnExportarReingresos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub

    Private Sub btnIngresoPersonal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnIngresoPersonal.ItemClick
        BDAccionPersonalDAO.IdEmpleado = 0
        Dim MiForm As New IngresoPersonalEdit
        MiForm.XtraTabControl1.Visible = False
        MiForm.ShowDialog()

        Refrescar()
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub EmpleadoIngresoList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    'Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
    '    BDAccionPersonalDAO.IdEmpleado = GridView1.GetFocusedRowCellValue("IDEMPLEADO")
    '    BDAccionPersonalDAO.flatCargaTipoEmpleado = 1 'cargar datos desde el ingreso del empleado'
    '    If BDAccionPersonalDAO.IdEmpleado <> 0 Then
    '        Dim MiForm As New IngresoPersonalEdit
    '        MiForm.btnGuardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    '        Dim dtAccionesUsuarioDetallado As DataTable
    '        dtAccionesUsuarioDetallado = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, MiForm.Name)
    '        Tools.AccionesUsuarioRibbon(MiForm.RibbonControl, dtAccionesUsuarioDetallado)
    '        MiForm.btnRegistrarEmpleado.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    '        MiForm.RibbonPageGroupEmpleado.Visible = False
    '        MiForm.XtraTabPageHijos.PageVisible = False
    '        MiForm.ShowDialog()
    '    End If
    'End Sub
    'Private Sub GridControl2_DoubleClick(sender As Object, e As EventArgs) Handles GridControl2.DoubleClick
    '    BDAccionPersonalDAO.IdEmpleado = GridView2.GetFocusedRowCellValue("IDEMPLEADO")
    '    BDAccionPersonalDAO.flatCargaTipoEmpleado = 2 'cargar datos desde el ingreso del empleado'
    '    If BDAccionPersonalDAO.IdEmpleado <> 0 Then
    '        Dim MiForm As New IngresoPersonalEdit
    '        ' MiForm.RibbonPageGroupEmpleado.Visible = False
    '        MiForm.XtraTabPageHijos.PageVisible = False
    '        MiForm.ShowDialog()
    '    End If
    'End Sub

    Private Sub CargarDatosEmpleado()
        Dim dt As New DataTable
        'dt = BDAccionPersonalDAO
    End Sub

    Private Sub btnExportarIngresos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportarIngresos.ItemClick
        If GridView1.RowCount > 0 Then
            Try
                Dim rutaingreso As String
                rutaingreso = My.Application.Info.DirectoryPath() + "\ListadoEmpleadosIngresos.xlsx"
                GridControl1.ExportToXlsx(rutaingreso)
                Process.Start(rutaingreso)
            Catch ex As Exception
                MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
            End Try
        Else
            MessageBox.Show("En la bandeja no existe no existe ningun empleado para exporta.", "Exporta listad de empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnExportarReingresos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportarReingresos.ItemClick
        If GridView2.RowCount > 0 Then
            Try
                Dim rutareingreso As String
                rutareingreso = My.Application.Info.DirectoryPath() + "\ListadoEmpleadosRengresos.xlsx"
                GridControl2.ExportToXlsx(rutareingreso)
                Process.Start(rutareingreso)
            Catch ex As Exception
                MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
            End Try
        Else
            MessageBox.Show("En la bandeja no existe no existe ningun empleado para exporta.", "Exporta listad de empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class