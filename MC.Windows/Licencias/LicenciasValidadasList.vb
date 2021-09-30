Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework
Public Class LicenciasValidadasList
    Dim bsSolicitudLicencias As New BindingSource
    Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDLICENCIA", "IDLICENCIA", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMEROSOLICITUD", "NUMEROSOLICITUD", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA SOLICITUD", "FECHA", 120, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MATRICULA", "MATRICULA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DOCUMENTO", "NUMERODOCUMENTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EMPLEADO", "NOMBRES", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO", "CARGO", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDLICENCIATIPO", "IDLICENCIATIPO", 20, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO LICENCIA", "TIPOLICENCIA", 280, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA INICIO", "FECHAPERIODOINICIO", 120, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA FIN", "FECHAPERIODOFIN", 120, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CANDIDAD DIAS", "CANTIDADDIAS", 120, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDEMPLEADO", "IDEMPLEADO", 120, False, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADOEVALUACION", "ESTADOEVALUACION", 120, False, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO REGISTRO", "ESTADOREGISTRO", 100, True, ControlesDevExpress.eGridViewFormato.Checked, True)

        With GridView1
            .Columns("NUMEROSOLICITUD").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("MATRICULA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOMBRES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CARGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("TIPOLICENCIA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAPERIODOINICIO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAPERIODOFIN").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        btnFechaInicial.EditValue = DateTime.Now.Date.AddDays(-30)
        btnFechaFinal.EditValue = DateTime.Now.Date
        AddHandler btnFechaFinal.EditValueChanged, AddressOf RefrescarxSolicitud
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
    Private Sub RefrescarxSolicitud()
        Try
            btnExportar.Visibility = BarItemVisibility.Never
            GridView1.Columns.Item("ESTADOREGISTRO").Visible = False
            Dim dtAccionesbutton As DataTable
            dtAccionesbutton = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(Ribbon, dtAccionesbutton)

            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioGrid(GridView1, dtAccionesUsuario)

            bsSolicitudLicencias.DataSource = LicenciaDAO.LicenciasConGoceValidadasListAll(btnFechaInicial.EditValue, btnFechaFinal.EditValue, 1)
            Me.GridControl1.DataSource = bsSolicitudLicencias

            If GridView1.Columns.Item("ESTADOREGISTRO").Visible Then
                GridView1.Columns.Item("ESTADOREGISTRO").VisibleIndex = 15
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub RefrescarxRegistro()
        Try
            bsSolicitudLicencias.DataSource = LicenciaDAO.LicenciasConGoceValidadasListAll(btnFechaInicial.EditValue, btnFechaFinal.EditValue, 2)
            Me.GridControl1.DataSource = bsSolicitudLicencias
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LicenciasValidadasList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnExportar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnExportar.ItemClick
        Dim view As GridView = TryCast(GridControl1.FocusedView, GridView)
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()

        SaveFileDialog1.Filter = "Xls |*.xls"
        SaveFileDialog1.FilterIndex = 1
        SaveFileDialog1.RestoreDirectory = True
        If SaveFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

            Dim dt As New DataTable

            dt.Columns.Add("RAZONSOCIAL")
            dt.Columns.Add("RAZONCOMERCIAL")
            dt.Columns.Add("NOMBRES")
            dt.Columns.Add("NUMERODOCUMENTO")
            dt.Columns.Add("TIPOLICENCIA")
            dt.Columns.Add("FECHAPERIODOINICIO")
            dt.Columns.Add("FECHAPERIODOFIN")
            dt.Columns.Add("CANTIDADDIAS")

            For i As Integer = 0 To GridView1.RowCount - 1
                Dim row As DataRow = dt.NewRow()
                Dim IDLICENCIAREGISTROADRYAN As Integer = view.GetRowCellValue(i, "IDLICENCIA")
                Dim estadoregistro As Boolean = view.GetRowCellValue(i, "ESTADOREGISTRO")
                If estadoregistro Then
                    If LicenciaDAO.RegistradoLicenciaByID(IDLICENCIAREGISTROADRYAN) Then
                        Dim RAZONSOCIAL As String = view.GetRowCellValue(i, "RAZONSOCIAL")
                        Dim RAZONCOMERCIAL As String = view.GetRowCellValue(i, "RAZONCOMERCIAL")
                        Dim NOMBRES As String = view.GetRowCellValue(i, "NOMBRES")
                        Dim DNI As String = view.GetRowCellValue(i, "NUMERODOCUMENTO")
                        Dim TIPOLICENCIA As String = view.GetRowCellValue(i, "TIPOLICENCIA")
                        Dim FECHAPERIODOINICIO As Date = view.GetRowCellValue(i, "FECHAPERIODOINICIO")
                        Dim FECHAPERIODOFIN As Date = view.GetRowCellValue(i, "FECHAPERIODOFIN")
                        Dim CANTIDADDIAS As Integer = view.GetRowCellValue(i, "CANTIDADDIAS")

                        row("RAZONSOCIAL") = RAZONSOCIAL
                        row("RAZONCOMERCIAL") = RAZONCOMERCIAL
                        row("NOMBRES") = NOMBRES
                        row("NUMERODOCUMENTO") = DNI
                        row("TIPOLICENCIA") = TIPOLICENCIA
                        row("FECHAPERIODOINICIO") = FECHAPERIODOINICIO
                        row("FECHAPERIODOFIN") = FECHAPERIODOFIN
                        row("CANTIDADDIAS") = CANTIDADDIAS
                        dt.Rows.Add(row)
                    Else
                        MessageBox.Show("Error al Registrar")
                        Exit Sub
                    End If
                End If
            Next
            If chkFechaSolicitud.Checked Then
                chkFechaRegistro.Checked = False
                RefrescarxSolicitud()
            End If
            If chkFechaRegistro.Checked Then
                chkFechaSolicitud.Checked = False
                RefrescarxRegistro()
            End If
            GridControl2.DataSource = dt
            GridControl2.ExportToXls(SaveFileDialog1.FileName)
            GridView2.Columns.Clear()
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