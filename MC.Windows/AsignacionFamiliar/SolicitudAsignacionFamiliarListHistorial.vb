Imports System.IO
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraTab
Imports DevExpress.XtraWaitForm
Imports MC.Data
Imports MC.Framework
Public Class SolicitudAsignacionFamiliarListHistorial

    Dim bsEmpleadoAsignacion As New BindingSource
    Dim LISTADOHIJOS As String
    Sub New()

        InitializeComponent()

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
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DE IDENTIDAD", "NUMERODOCUMENTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBRE EMPLEADO", "NOMBRES", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO", "CARGO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        ControlesDevExpress.InitGridViewColumn(GridView1, "F. INGRESO COMPAÑIA", "FECHAINGRESO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "F. INGRESO CORPORACIÓN", "FECHAINGRESOCORPORACION", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DE HIJOS", "NUMEROHIJOS", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CONTABA CON BENEFICIO", "CONTABABENEFICIOASIGNACION", 150, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ASIGNAR BENEFICIO", "ASIGNARBENEFICIOASIGNACION", 150, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA PROCESADO", "FECHAEVALUACIONRRHH", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CONTABILIDAD", "CONTABILIDAD", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO", "ESTADO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "USUARIO ANULADO", "USUARIOANULADO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)


        With GridView1
            .Columns("NUMEROSOLICITUD").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOMBRES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CARGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CONTABILIDAD").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("ESTADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        btnFechaInicial.EditValue = DateTime.Now.Date.AddDays(-30)
        btnFechaFinal.EditValue = DateTime.Now.Date

        AddHandler btnFechaFinal.EditValueChanged, AddressOf RefrescarxSolicitud

        Me.GridControl1.DataSource = bsEmpleadoAsignacion
        RefrescarxSolicitud()
        chkFechaSolicitud.Checked = True
        chkFechaRegistro.Checked = False
    End Sub
    Private Sub inabilitarbotones()
        btnDetalleHijos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnExportarDetalleHijos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnExportarSolicitantes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        GridView1.Columns.Item("ADJUNTO").Visible = False
    End Sub
    Public Sub RefrescarxSolicitud()
        Try
            inabilitarbotones()
            Dim dtAccionesbutton As DataTable
            dtAccionesbutton = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(Ribbon, dtAccionesbutton)

            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioGrid(GridView1, dtAccionesUsuario)
            bsEmpleadoAsignacion.DataSource = BDAccionPersonalDAO.GetAsignacionFamiliarListHistorial(btnFechaInicial.EditValue, btnFechaFinal.EditValue, 1)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub RefrescarxRegistro()
        Try
            bsEmpleadoAsignacion.DataSource = BDAccionPersonalDAO.GetAsignacionFamiliarListHistorial(btnFechaInicial.EditValue, btnFechaFinal.EditValue, 2)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        If chkFechaSolicitud.Checked = True Then
            RefrescarxSolicitud()
        ElseIf chkFechaRegistro.Checked = True Then
            RefrescarxRegistro()
        Else
            MessageBox.Show("Para poder listar los registros tiene que seleccionar si es por fecha de solicitud o fecha de registro")
        End If
    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnDetalleHijos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDetalleHijos.ItemClick
        BDAccionPersonalDAO.IdAsignacionFamiliar = GridView1.GetFocusedRowCellValue("IDASIGNACIONFAMILIAR")
        Dim MiForm As New AsignacionFamiliarDetalle
        MiForm.btnDesprocesarValidado.Visibility = BarItemVisibility.Never
        MiForm.GridView1.Columns(0).OptionsColumn.AllowEdit = False
        MiForm.GridView1.Columns(1).OptionsColumn.AllowEdit = False
        MiForm.GridView1.Columns(2).OptionsColumn.AllowEdit = False
        MiForm.GridView1.Columns(3).OptionsColumn.AllowEdit = False
        MiForm.GridView1.Columns(4).OptionsColumn.AllowEdit = False
        MiForm.GridView1.Columns(5).OptionsColumn.AllowEdit = False
        MiForm.GridView1.Columns(6).OptionsColumn.AllowEdit = False
        MiForm.GridView1.Columns(7).OptionsColumn.AllowEdit = False
        MiForm.GridView1.Columns(8).OptionsColumn.AllowEdit = False
        MiForm.GridView1.Columns(9).OptionsColumn.AllowEdit = False
        MiForm.GridView1.Columns(10).OptionsColumn.AllowEdit = False
        MiForm.GridView1.Columns(11).OptionsColumn.AllowEdit = False
        MiForm.GridView1.Columns(12).OptionsColumn.AllowEdit = False
        MiForm.GridView1.Columns(13).OptionsColumn.AllowEdit = False
        MiForm.GridView1.Columns(14).OptionsColumn.AllowEdit = False

        MiForm.btnRegistrarAsignacion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        MiForm.btnAnular.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        MiForm.ShowDialog()
        RefrescarxSolicitud()

    End Sub
    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        If btnDetalleHijos.Visibility = BarItemVisibility.Always Then

            btnDetalleHijos.PerformClick()
        End If
    End Sub

    Private Sub btnExportarDetalleHijos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportarDetalleHijos.ItemClick
        Dim IDASIGNACIONFAMILIAR As Integer
        For i As Integer = 0 To GridView1.RowCount - 1
            IDASIGNACIONFAMILIAR = GridView1.GetRowCellValue(i, "IDASIGNACIONFAMILIAR")
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
            LISTADOHIJOS = ""
        End If
    End Sub

    Private Sub btnExportarSolicitantes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportarSolicitantes.ItemClick

        If GridView1.RowCount > 0 Then
            'GridView1.Columns("ESTADOTEXTO").Visible = True
            GridView1.Columns("USUARIOANULADO").Visible = False
            'GridView1.Columns("ESTADOANULADORRHH").Visible = False
            Try
                Dim ruta As String
                ruta = My.Application.Info.DirectoryPath() + "\AsignacionFamiliar.xlsx"
                GridControl1.ExportToXlsx(ruta)
                Process.Start(ruta)
            Catch ex As Exception
                MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
            End Try
            'GridView1.Columns("ESTADOTEXTO").Visible = False
            GridView1.Columns("USUARIOANULADO").Visible = True
            'GridView1.Columns("ESTADOANULADORRHH").Visible = True

        End If

        'Dim bs As New BindingSource
        'Dim dt As DataTable
        'bs = GridControl1.DataSource
        'dt = bs.DataSource
        'If dt.Rows.Count > 0 Then
        '    SplashScreenManager.ShowForm(GetType(WaitForm))
        '    Dim Ruta As String = Path.GetTempPath + "asignacionfamiliar" + ".xlsx"
        '    Tools.ExportToExcel(dt, Ruta, "Hoja")
        '    Process.Start(Ruta)
        '    SplashScreenManager.CloseForm()
        'End If
    End Sub


    Private Sub chkFechaSolicitud_CheckedChanged(sender As Object, e As ItemClickEventArgs) Handles chkFechaSolicitud.CheckedChanged
        If chkFechaSolicitud.Checked Then
            chkFechaRegistro.Checked = False
        End If
    End Sub

    Private Sub chkFechaRegistro_CheckedChanged(sender As Object, e As ItemClickEventArgs) Handles chkFechaRegistro.CheckedChanged
        If chkFechaRegistro.Checked Then
            chkFechaSolicitud.Checked = False
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

    Private Sub SolicitudAsignacionFamiliarListHistorial_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub
End Class