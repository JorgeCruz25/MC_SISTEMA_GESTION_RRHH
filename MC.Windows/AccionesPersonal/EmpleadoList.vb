Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports MC.Data
Imports MC.Framework

Public Class EmpleadoList
    Dim bsEmpleados As New BindingSource
    Sub New()

        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDEMPLEADO", "IDEMPLEADO", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MATRICULA", "MATRICULA", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBRES", "NOMBRES", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "APELLIDO PATERNO", "APELLIDOPATERNO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "APELLIDO MATERNO", "APELLIDOMATERNO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DE DOCUMENTO", "NUMERODOCUMENTO", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO", "CARGO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO", "ESTADOEMPLEADO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO REGISTRO", "ESTADOREGISTRO", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
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
            btnCargaMasiva.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(RibbonControl, dtAccionesUsuario)
            bsEmpleados.DataSource = BDAccionPersonalDAO.GetEmpleadoAccionPersonalList(BDCentralDAO.UsuarioBE.IDUsuario)
            Me.GridControl1.DataSource = bsEmpleados
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub inabilitarbotones()
        btnExportar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnEditar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnHistorial.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub
    Private Sub btnEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditar.ItemClick
        'BDAccionPersonalDAO.IdEmpleado = GridView1.GetFocusedRowCellValue("IDEMPLEADO")

        'If BDAccionPersonalDAO.IdEmpleado <> 0 And GridView1.GetFocusedRowCellValue("ESTADOREGISTRO") = "REGISTRADO" Then
        '    Dim MiForm As New IngresoPersonalEdit
        '    MiForm.ShowDialog()
        'End If

        BDAccionPersonalDAO.IdEmpleado = GridView1.GetFocusedRowCellValue("IDEMPLEADO")
        'BDAccionPersonalDAO.CargarDatos = 1 'cargar datos desde el listado de los empleados'
        If BDAccionPersonalDAO.IdEmpleado <> 0 And GridView1.GetFocusedRowCellValue("ESTADOREGISTRO") = "REGISTRADO" Then
            Dim MiForm As New IngresoPersonalEdit
            MiForm.btnGuardar.Visibility = BarItemVisibility.Never
            Dim dtAccionesUsuarioDetallado As DataTable
            dtAccionesUsuarioDetallado = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, MiForm.Name)
            Tools.AccionesUsuarioRibbon(MiForm.RibbonControl, dtAccionesUsuarioDetallado)
            MiForm.XtraTabPageHijos.PageVisible = False
            MiForm.btnRegistrarEmpleado.Visibility = BarItemVisibility.Never
            MiForm.ShowDialog()
            Refrescar()
        Else
            MessageBox.Show("El colaborador aun se encuentra pendiente de registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub

    'Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
    '    BDAccionPersonalDAO.IdEmpleado = GridView1.GetFocusedRowCellValue("IDEMPLEADO")
    '    'BDAccionPersonalDAO.CargarDatos = 1 'cargar datos desde el listado de los empleados'
    '    If BDAccionPersonalDAO.IdEmpleado <> 0 And GridView1.GetFocusedRowCellValue("ESTADOREGISTRO") = "REGISTRADO" Then
    '        Dim MiForm As New IngresoPersonalEdit
    '        MiForm.btnGuardar.Visibility = BarItemVisibility.Never
    '        Dim dtAccionesUsuarioDetallado As DataTable
    '        dtAccionesUsuarioDetallado = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, MiForm.Name)
    '        Tools.AccionesUsuarioRibbon(MiForm.RibbonControl, dtAccionesUsuarioDetallado)
    '        MiForm.XtraTabPageHijos.PageVisible = False
    '        MiForm.btnRegistrarEmpleado.Visibility = BarItemVisibility.Never
    '        MiForm.ShowDialog()
    '    End If
    'End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnHistorial_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHistorial.ItemClick



        BDAccionPersonalDAO.IdEmpleado = GridView1.GetFocusedRowCellValue("IDEMPLEADO")

        Nombre = GridView1.GetFocusedRowCellValue("NOMBRES")
        ApellidoPaterno = GridView1.GetFocusedRowCellValue("APELLIDOPATERNO")
        ApellidoMaterno = GridView1.GetFocusedRowCellValue("APELLIDOMATERNO")
        NumeroDocumento = GridView1.GetFocusedRowCellValue("NUMERODOCUMENTO")

        If BDAccionPersonalDAO.IdEmpleado <> 0 And GridView1.GetFocusedRowCellValue("ESTADOREGISTRO") = "REGISTRADO" Then
            Dim MiForm As New EmpleadoHistorial

            NombreLog = MiForm.Text ' formulario , reporte,
            DetalleLog = "HISTORIAL EMPLEADO " & Nombre & " " & ApellidoPaterno & " " & ApellidoMaterno & " CON NUMERO DE DOC. " & NumeroDocumento ' acción: impresión, exportar, tb poner filtros , lo que se
            BDCentralDAO.AccesoLogIns(IDSistema, BDCentralDAO.UsuarioBE.IDUsuario, DetalleLog, NombreLog)
            MiForm.ShowDialog()

        End If
    End Sub

    Private Sub EmpleadoList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub btnExportar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportar.ItemClick
        If GridView1.RowCount > 0 Then
            Try
                Dim ruta As String
                ruta = My.Application.Info.DirectoryPath() + "\ListadoEmpleados.xlsx"
                GridControl1.ExportToXlsx(ruta)
                Process.Start(ruta)
            Catch ex As Exception
                MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
            End Try
        Else
            MessageBox.Show("En la bandeja no existe no existe ningun empleado para exporta.", "Exporta listad de empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        'BDAccionPersonalDAO.IdEmpleado = GridView1.GetFocusedRowCellValue("IDEMPLEADO")
        'BDAccionPersonalDAO.flatCargaTipoEmpleado = 1 'cargar datos desde el ingreso del empleado'
        'If BDAccionPersonalDAO.IdEmpleado <> 0 Then
        '    Dim MiForm As New IngresoPersonalEdit
        '    MiForm.btnGuardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '    Dim dtAccionesUsuarioDetallado As DataTable
        '    dtAccionesUsuarioDetallado = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, MiForm.Name)
        '    Tools.AccionesUsuarioRibbon(MiForm.RibbonControl, dtAccionesUsuarioDetallado)
        '    MiForm.btnRegistrarEmpleado.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '    MiForm.RibbonPageGroupEmpleado.Visible = False
        '    MiForm.XtraTabPageHijos.PageVisible = False
        '    MiForm.ShowDialog()
        'End If
        If btnEditar.Visibility = BarItemVisibility.Always Then
            btnEditar.PerformClick()
        End If
    End Sub

    Private Sub btnCargaMasiva_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCargaMasiva.ItemClick
        Dim MiForm As New EmpleadoCargaMasiva
        MiForm.ShowDialog()

    End Sub
End Class