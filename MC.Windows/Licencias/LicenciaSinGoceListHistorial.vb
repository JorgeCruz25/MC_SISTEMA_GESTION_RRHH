Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework
Public Class LicenciaSinGoceListHistorial
    Dim bsLicencias As New BindingSource

    Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDLICENCIA", "IDLICENCIA", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMEROSOLICITUD", "NUMEROSOLICITUD", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA SOLICITUD", "FECHA", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MATRICULA", "MATRICULA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DOCUMENTO", "NUMERODOCUMENTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "APE.PATERNO", "APELLIDOPATERNO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "APE. MATERNO", "APELLIDOMATERNO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBRES", "NOMBRES", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "PUESTO", "CARGOSOLICITANTE", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIENDA", "RAZONCOMERCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA DE INGRESO", "FECHAINGRESO", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO LICENCIA", "TIPOLICENCIA", 160, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MOTIVO", "MOTIVOLEY", 160, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "F. INICIAL", "FECHAPERIODOINICIO", 160, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "F. FINAL", "FECHAPERIODOFIN", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DIAS", "CANTIDADDIAS", 50, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MES", "MESEVALUACION", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO PAGO", "DESCRIPCIONESTADOPAGO", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "OBSERVACION", "OBSERVACIONLICENCIAOTROS", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "IDLICENCIATIPO", "IDLICENCIATIPO", 20, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO LICENCIA", "ESTADO", 120, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "USUARIO ANULADO", "USUARIOANULADO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridView1
            .Columns("NUMEROSOLICITUD").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOPATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOMATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOMBRES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CARGOSOLICITANTE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("TIPOLICENCIA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("MOTIVOLEY").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains

            .Columns("FECHAPERIODOINICIO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAPERIODOFIN").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CANTIDADDIAS").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("MESEVALUACION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains

            .Columns("DESCRIPCIONESTADOPAGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("OBSERVACIONLICENCIAOTROS").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("ESTADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("USUARIOANULADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        btnFechaInicial.EditValue = DateTime.Now.Date.AddDays(-30)
        btnFechaFinal.EditValue = DateTime.Now.Date
        AddHandler btnFechaFinal.EditValueChanged, AddressOf RefrescarxSolicitud
        Me.GridControl1.DataSource = bsLicencias
        RefrescarxSolicitud()
        chkFechaSolicitud.Checked = True
        chkFechaRegistro.Checked = False
    End Sub
    Private Sub btnRefrescar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnRefrescar.ItemClick
        If chkFechaSolicitud.Checked = True Then
            RefrescarxSolicitud()
        ElseIf chkFechaRegistro.Checked = True Then
            RefrescarxRegistro()
        Else
            MessageBox.Show("Para poder listar los registros tiene que seleccionar si es por fecha de solicitud o fecha de registro")
        End If
    End Sub
    Private Sub LicenciaSinGoceListHistorial_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub
    Private Sub RefrescarxSolicitud()
        Try
            btnExportar.Visibility = BarItemVisibility.Never
            GridView1.Columns.Item("ACTAACUERDO").Visible = False
            Dim dtAccionesBotones As DataTable
            dtAccionesBotones = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(Ribbon, dtAccionesBotones)

            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioGrid(GridView1, dtAccionesUsuario)
            bsLicencias.DataSource = LicenciaDAO.GetAllLicenciasSinGoceHistorial(btnFechaInicial.EditValue, btnFechaFinal.EditValue, 1)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub RefrescarxRegistro()
        Try
            bsLicencias.DataSource = LicenciaDAO.GetAllLicenciasSinGoceHistorial(btnFechaInicial.EditValue, btnFechaFinal.EditValue, 2)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub RepositoryItemAcuerdoArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemAcuerdoArchivo.Click
        Dim MiForm As New LicenciaArchivo
        LicenciaDAO.IdLicencia = GridView1.GetFocusedRowCellValue("IDLICENCIA")
        Dim dt As DataTable = LicenciaDAO.ListaLicenciaAcuerdoArchivos(LicenciaDAO.IdLicencia)

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
            MessageBox.Show("Archivo de acuerdo no adjuntado", "Archivo de Acuerdo")
        End If
    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnExportar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnExportar.ItemClick
        If GridView1.RowCount > 0 Then
            Try
                GridView1.Columns("FECHA").Visible = False
                GridView1.Columns("NUMEROSOLICITUD").Visible = False
                'GridView1.Columns("ESTADOREGISTRO").Visible = False
                'GridView1.Columns("ESTADOANULADORRHH").Visible = False
                GridView1.Columns("USUARIOANULADO").Visible = False
                GridView1.Columns(0).Visible = False

                Dim ruta As String
                ruta = My.Application.Info.DirectoryPath() + "\LicenciaSinGoce  .xlsx"
                GridControl1.ExportToXlsx(ruta)
                Process.Start(ruta)
                GridView1.Columns(0).Visible = True
            Catch ex As Exception
                MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
            End Try

            GridView1.Columns("NUMEROSOLICITUD").Visible = True
            GridView1.Columns("FECHA").Visible = True
            'GridView1.Columns("ESTADOREGISTRO").Visible = True
            'GridView1.Columns("ESTADOANULADORRHH").Visible = True
            GridView1.Columns("USUARIOANULADO").Visible = True
            GridView1.Columns(0).Visible = True
        End If
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
End Class