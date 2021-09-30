Imports DevExpress.XtraBars
Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework
Public Class CartaConocimientoList
    Dim bsCartaConocimiento As New BindingSource
    Sub New()
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDEXAMENMEDICO", "IDEXAMENMEDICO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMEROEXAMENMEDICO", "NUMEROEXAMENMEDICO", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA SOLICITUD", "FECHA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EMPLEADO", "NOMBRES", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO EMPLEADO", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA INICIO", "FECHAINICIO", 150, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA FIN", "FECHAFIN", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "HORA", "HORA", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridView1
            .Columns("NUMEROEXAMENMEDICO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOMBRES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAINICIO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAFIN").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("HORA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        Me.GridControl1.DataSource = bsCartaConocimiento
        Refrescar()
    End Sub
    Private Sub Refrescar()
        Try

            btnEvaluar.Visibility = BarItemVisibility.Never
            GridView1.Columns.Item("ARCHIVO").Visible = False
            Dim dtAccionesbutton As DataTable
            dtAccionesbutton = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(Ribbon, dtAccionesbutton)

            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioGrid(GridView1, dtAccionesUsuario)

            bsCartaConocimiento.DataSource = CartaConocimientoDAO.CartaConocimientoListAll()
            If GridView1.Columns.Item("ARCHIVO").Visible Then
                GridView1.Columns.Item("ARCHIVO").VisibleIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEvaluar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnEvaluar.ItemClick
        CartaConocimientoDAO.IdExamenMedico = GridView1.GetFocusedRowCellValue("IDEXAMENMEDICO")
        Dim MiForm As New CartaConocimientoDetails
        MiForm.ShowDialog()
        Refrescar()
    End Sub

    Private Sub CartaConocimientoList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        If btnEvaluar.Visibility = BarItemVisibility.Always Then
            btnEvaluar.PerformClick()
        End If
    End Sub
    Private Sub RepositoryItemButtonCartaConocimientoArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonCartaConocimientoArchivo.Click
        CartaConocimientoDAO.IdExamenMedico = GridView1.GetFocusedRowCellValue("IDEXAMENMEDICO")
        If CartaConocimientoDAO.IdExamenMedico <> 0 Then
            Dim MiForm As New CartaConocimientoArchivos
            Dim dt As DataTable = CartaConocimientoDAO.CartaConocimientoArchivoList(CartaConocimientoDAO.IdExamenMedico)
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
                MessageBox.Show("La Solicitud carta de conocimiento no contiene archivo", "Archivo Carta de conocimiento")
            End If
        End If
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub
End Class