Imports DevExpress.XtraBars
Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework
Public Class NegacionTrasladoHistorialList
    Dim bsNegacionTrasladoHistorial As New BindingSource
    Sub New()
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDNEGACIONTRASLADO", "IDNEGACIONTRASLADO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO NEGACION", "NUMERONEGACIONTRASLADO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA SOLICITUD", "FECHA", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBREREPRESENTANTE", "NOMBREREPRESENTANTE", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DNI REPRESENTANTE", "DNIREPRESENTANTE", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBRE AFECTADO", "NOMBREAFECTADO", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DNI AFECTADO", "DNIAFECTADO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO SOLICITUD", "ESTADOSOLICITUD", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "USUARIO ANULADO", "USUARIOANULADO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridView1
            .Columns("NUMERONEGACIONTRASLADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOMBREREPRESENTANTE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("DNIREPRESENTANTE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOMBREAFECTADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("DNIAFECTADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("ESTADOSOLICITUD").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains

        End With
        btnFechaInicio.EditValue = DateTime.Now.Date.AddDays(-30)
        btnFechaFinal.EditValue = DateTime.Now.Date

        AddHandler btnFechaFinal.EditValueChanged, AddressOf Refrescar
        Me.GridControl1.DataSource = bsNegacionTrasladoHistorial
        Refrescar()
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub

    Private Sub NegacionTrasladoHistorialList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub Refrescar()
        Try
            GridView1.Columns.Item("ARCHIVO").Visible = False
            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioGrid(GridView1, dtAccionesUsuario)

            bsNegacionTrasladoHistorial.DataSource = NegacionTrasladoDAO.NegacionTrasladoHistorialListAll(btnFechaInicio.EditValue, btnFechaFinal.EditValue)
            If GridView1.Columns.Item("ARCHIVO").Visible Then
                GridView1.Columns.Item("ARCHIVO").VisibleIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RepositoryItemButtonNegacionTrasladoArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonNegacionTrasladoArchivo.Click
        NegacionTrasladoDAO.IdNegacionTraslado = GridView1.GetFocusedRowCellValue("IDNEGACIONTRASLADO")
        If NegacionTrasladoDAO.IdNegacionTraslado <> 0 Then
            Dim MiForm As New NegacionTrasladoArchivos
            Dim dt As DataTable = NegacionTrasladoDAO.NegacionTrasladoArchivoList(NegacionTrasladoDAO.IdNegacionTraslado)
            If dt.Rows.Count <> 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim ruta As String = dt.Rows(i).Table(i)("LINKDESCARGA").ToString
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
                MessageBox.Show("La Solicitud de negación de traslado no contiene archivo", "Archivo Negación de Traslado")
            End If
        End If
    End Sub
End Class