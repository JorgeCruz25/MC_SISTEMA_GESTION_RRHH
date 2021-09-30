Imports DevExpress.XtraBars
Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework
Public Class SolicitudCeseNoLegalList
    Dim bsEmpleadoCese As New BindingSource

    Sub New()

        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDSOLICITUDCESE", "IDSOLICITUDCESE", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDEMPLEADO", "IDEMPLEADO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO VALIDADO", "ESTADOVALIDADOSOLICITUDNOLEGAL", 130, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO PROCESO", "ESTADOPROCESO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False) '''NO BORRAR 
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO CESE", "NUMEROSOLICITUDCESE", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "GENERADO MEDIO", "MEDIOGENERADO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA SOLICITUD", "FECHA", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA VALIDADO SOLICITUD", "FECHAVALIDADOBLOQUEO", 160, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "SOLICITANTE", "SOLICITANTE", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EMPLEADO", "EMPLEADO", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DE IDENTIDAD", "DNI", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO", "CARGO", 160, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MOTIVO GENERAL", "MOTIVOGENERAL", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA FINAL CONTRATO", "FECHAFINALCONTRATO", 140, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "PERMANENCIA", "PERMANENCIA", 200, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "AMPLIACION", "MESAMPLIACION", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDSITIO", "IDSITIO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDESTADOPROCESO", "IDESTADOPROCESO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RENOVACION", "RENOVACION", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridView1
            .Columns("NUMEROSOLICITUDCESE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("SOLICITANTE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("EMPLEADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("DNI").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CARGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("MOTIVOGENERAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAFINALCONTRATO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        Me.GridControl1.DataSource = bsEmpleadoCese
        Refrescar()

    End Sub

    Public Sub Refrescar()
        Try
            btnEvaluarSolicitud.Visibility = BarItemVisibility.Never

            Dim dtAccionesbutton As DataTable
            dtAccionesbutton = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(Ribbon, dtAccionesbutton)

            bsEmpleadoCese.DataSource = CeseDAO.GetSolicitudCeseNoLegalListAll()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnEvaluarSolicitud_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnEvaluarSolicitud.ItemClick
        CeseDAO.IdSolicitudCese = GridView1.GetFocusedRowCellValue("IDSOLICITUDCESE")
        CeseDAO.IdEmpleado = GridView1.GetFocusedRowCellValue("IDEMPLEADO")
        CeseDAO.IdSitio = GridView1.GetFocusedRowCellValue("IDSITIO")
        CeseDAO.Renovacion = GridView1.GetFocusedRowCellValue("RENOVACION")
        If CeseDAO.IdSolicitudCese <> 0 Then
            Dim MiForm As New EmpleadoCese
            If CeseDAO.IdSitio = 1 Then
                If GridView1.GetFocusedRowCellValue("ESTADOVALIDADOSOLICITUDNOLEGAL") Then
                    MiForm.btnValidar.Visibility = BarItemVisibility.Never
                    MiForm.dtFechaRecojoDocumento.Enabled = False

                Else
                    MiForm.btnRegistrarCese.Visibility = BarItemVisibility.Never
                    MiForm.deFechaCese.Enabled = False
                    MiForm.sleMotivoCese.Enabled = False
                    MiForm.txtObservacion.Enabled = False
                    MiForm.chkPagoDiasBoleta.Enabled = False
                End If
            Else
                MiForm.lblFechaSupervisor.Visible = False
                MiForm.dtFechaRecojoDocumento.Visible = False
                MiForm.btnValidar.Visibility = BarItemVisibility.Never
            End If
            MiForm.ShowDialog()
            Refrescar()
        End If
    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        If btnEvaluarSolicitud.Visibility = BarItemVisibility.Always Then
            btnEvaluarSolicitud.PerformClick()
        End If
    End Sub

    Private Sub SolicitudCeseNoLegalList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub


    Private Sub RepositoryItemButtonCeseArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonCeseArchivo.Click
        CeseDAO.IdSolicitudCese = GridView1.GetFocusedRowCellValue("IDSOLICITUDCESE")
        If CeseDAO.IdSolicitudCese <> 0 Then
            Dim MiForm As New SolicitudCeseDescargoArchivos
            Dim dt As DataTable = CeseDAO.ListSolicitudCeseArchivo(CeseDAO.IdSolicitudCese)
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
                MessageBox.Show("La solicitud Nª " & GridView1.GetFocusedRowCellValue("NUMEROSOLICITUDCESE") & " no cuenta con adjunto", "Archivo de Cese", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class