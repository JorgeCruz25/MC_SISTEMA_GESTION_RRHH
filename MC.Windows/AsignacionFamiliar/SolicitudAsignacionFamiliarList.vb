Imports System.IO
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraTab
Imports DevExpress.XtraWaitForm
Imports MC.Data
Imports MC.Framework

Public Class SolicitudAsignacionFamiliarList

    Dim bsEmpleadoAsignacion As New BindingSource
    Dim LISTADOHIJOS As String

    Sub New()

        InitializeComponent()
        'AddHandler Me.GridView1.DoubleClick, AddressOf btnEvaluarSolicitud.PerformClick
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True
        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDASIGNACIONFAMILIAR", "IDASIGNACIONFAMILIAR", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDEMPLEADO", "IDEMPLEADO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO SOLICITUD", "NUMEROSOLICITUD", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 170, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 170, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA REGISTRO", "FECHA", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MATRICULA", "MATRICULA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DOCUMENTO", "NUMERODOCUMENTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBRE EMPLEADO", "NOMBRES", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA INGRESO CORPORACIÓN", "FECHAINGRESOCORPORACION", 170, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA INGRESO LOCAL", "FECHAINGRESO", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO", "CARGO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridView1
            .Columns("NUMEROSOLICITUD").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOMBRES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CARGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        Me.GridControl1.DataSource = bsEmpleadoAsignacion
        Refrescar()

    End Sub
    Private Sub inabilitarbotones()
        btnIngresoDerechoHabiente.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnEvaluarSolicitud.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnHistorialEmpleado.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnExportarDetalleHijos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnExportarSolicitantes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        GridView1.Columns.Item("ADJUNTO").Visible = False
    End Sub

    Public Sub Refrescar()
        inabilitarbotones()
        Try
            Dim dtAccionesbutton As DataTable
            dtAccionesbutton = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(Ribbon, dtAccionesbutton)


            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioGrid(GridView1, dtAccionesUsuario)

            bsEmpleadoAsignacion.DataSource = BDAccionPersonalDAO.GetAsignacionFamiliarList()

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

    Private Sub EmpleadoDerechoHabientesList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub btnEvaluarSolicitud_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEvaluarSolicitud.ItemClick
        BDAccionPersonalDAO.IdAsignacionFamiliar = GridView1.GetFocusedRowCellValue("IDASIGNACIONFAMILIAR")
        Dim MiForm As New AsignacionFamiliarDetalle
        MiForm.ShowDialog()
        Refrescar()
    End Sub

    Private Sub btnIngresoDerechoHabiente_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnIngresoDerechoHabiente.ItemClick
        BDAccionPersonalDAO.IdEmpleado = 0
        Dim MiForm As New EmpleadoDerechoHabientes
        MiForm.ShowDialog()
    End Sub

    Private Sub btnExportarDetalleHijos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportarDetalleHijos.ItemClick
        For i As Integer = 0 To GridView1.RowCount - 1
            Dim IDASIGNACIONFAMILIAR As Integer = GridView1.GetRowCellValue(i, "IDASIGNACIONFAMILIAR")

            LISTADOHIJOS = String.Concat(LISTADOHIJOS, ", ", IDASIGNACIONFAMILIAR)
            LISTADOHIJOS = Replace(LISTADOHIJOS, " ", "")

        Next
        If LISTADOHIJOS <> "" Or LISTADOHIJOS IsNot Nothing Then
            SplashScreenManager.ShowForm(GetType(WaitForm))
            Dim dt As New DataTable
            Dim Ruta As String = Path.GetTempPath + "AsignacionFamiliarHijos" + ".xlsx"
            dt = BDAccionPersonalDAO.AsignacionFamiliarHijosList(LISTADOHIJOS)
            Tools.ExportToExcel(dt, Ruta, "Hoja")
            Process.Start(Ruta)
            SplashScreenManager.CloseForm()
        End If
    End Sub

    Private Sub btnExportarSolicitantes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportarSolicitantes.ItemClick
        If GridView1.RowCount > 0 Then
            Try
                Dim ruta As String
                ruta = My.Application.Info.DirectoryPath() + "\AsignacionFAmiliar.xlsx"
                GridControl1.ExportToXlsx(ruta)
                Process.Start(ruta)
            Catch ex As Exception
                MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
            End Try
        End If
    End Sub

    Private Sub RepositoryItemAsignacionFamiliarArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemAsignacionFamiliarArchivo.Click

        Dim idasignacionfamiliar As Integer
        idasignacionfamiliar = GridView1.GetFocusedRowCellValue("IDASIGNACIONFAMILIAR")
        If idasignacionfamiliar <> 0 Then
            Dim MiForm As New MemorandumArchivos
            MiForm.btnEliminarFormatos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnFirmaDocumento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Dim dt As DataTable = BDAccionPersonalDAO.ListaAsignacionFamiliarArchivos(idasignacionfamiliar)
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

    Private Sub btnHistorialEmpleado_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHistorialEmpleado.ItemClick
        Dim idempleado = GridView1.GetFocusedRowCellValue("IDEMPLEADO")
        BDAccionPersonalDAO.IdEmpleado = idempleado
        If BDAccionPersonalDAO.IdEmpleado <> 0 Then
            Dim MiForm As New EmpleadoHistorial

            Nombre = GridView1.GetFocusedRowCellValue("NOMBRES")
            NumeroDocumento = GridView1.GetFocusedRowCellValue("NUMERODOCUMENTO")

            NombreLog = Me.Text ' formulario , reporte,
            DetalleLog = "HISTORIAL EMPLEADO " & Nombre & " CON NUMERO DE DOC. " & NumeroDocumento ' acción: impresión, exportar, tb poner filtros , lo que se
            BDCentralDAO.AccesoLogIns(IDSistema, BDCentralDAO.UsuarioBE.IDUsuario, DetalleLog, NombreLog)

            MiForm.ShowDialog()
        End If

    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        If btnEvaluarSolicitud.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
            btnEvaluarSolicitud.PerformClick()
        End If
    End Sub
End Class