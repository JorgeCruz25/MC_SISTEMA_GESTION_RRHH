Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework
Public Class LactanciaListHistorial
    Dim bsLactancia As New BindingSource

    Sub New()

        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDLACTANCIA", "IDLACTANCIA", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMEROSOLICITUD", "NUMEROSOLICITUD", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA REGISTRO", "FECHA", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MATRICULA", "MATRICULA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DOC.EMPLEADO", "NUMERODOCUMENTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBREEMPLEADO", "NOMBREEMPLEADO", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO EMPLEADO", "EMPLEADOCARGO", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA NAC.", "FECHANACIMIENTOHIJO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "PERIODO INICIO", "FECHAINICIO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "PERIODO FIN", "FECHAFIN", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO SOLICITUD", "ESTADOSOLICITUD", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "USUARIO ANULADO", "USUARIOANULADO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO", "ESTADOSOLICITUD", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridView1
            .Columns("NUMEROSOLICITUD").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOMBREEMPLEADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("EMPLEADOCARGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("ESTADOSOLICITUD").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("USUARIOANULADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        btnFechaInicio.EditValue = DateTime.Now.Date.AddDays(-30)
        btnFechaFinal.EditValue = DateTime.Now.Date

        AddHandler btnFechaFinal.EditValueChanged, AddressOf Refrescar

        Me.GridControl1.DataSource = bsLactancia
        Refrescar()

    End Sub
    Private Sub Refrescar()
        Try
            btnExportar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            GridView1.Columns.Item("ARCHIVO").Visible = False
            Dim dtAccionesbutton As DataTable
            dtAccionesbutton = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(Ribbon, dtAccionesbutton)

            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioGrid(GridView1, dtAccionesUsuario)


            bsLactancia.DataSource = LactanciaDAO.LactanciaListAllHistorial(btnFechaInicio.EditValue, btnFechaFinal.EditValue)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LactanciaListHistorial_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub
    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub
    Private Sub RepositoryItemArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemArchivo.Click
        LactanciaDAO.IdLactancia = GridView1.GetFocusedRowCellValue("IDLACTANCIA")
        If LactanciaDAO.IdLactancia <> 0 Then
            Dim MiForm As New LactanciaArchivo
            Dim dt1 As DataTable = LactanciaDAO.LactanciaArchivoList(LactanciaDAO.IdLactancia)
            If dt1.Rows.Count <> 0 Then
                For i As Integer = 0 To dt1.Rows.Count - 1
                    Dim ruta As String = dt1.Rows(i).Table(i)("linkdescarga").ToString
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
                MessageBox.Show("Archivo de lactancia no adjuntado", "Archivo de Lactancia")
            End If
        End If
    End Sub

    Private Sub btnExportar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportar.ItemClick
        If GridView1.RowCount > 0 Then
            GridView1.Columns(0).Visible = False
            GridView1.Columns("ESTADOSOLICITUD").Visible = True
            'GridView1.Columns("ESTADOANULADORRHH").Visible = False
            Try
                Dim ruta As String
                ruta = My.Application.Info.DirectoryPath() + "\Lactancia.xlsx"
                GridControl1.ExportToXlsx(ruta)
                Process.Start(ruta)
            Catch ex As Exception
                MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
            End Try
            GridView1.Columns(0).Visible = True
            GridView1.Columns("ESTADOSOLICITUD").Visible = False
            'GridView1.Columns("ESTADOANULADORRHH").Visible = True
        End If
    End Sub
End Class