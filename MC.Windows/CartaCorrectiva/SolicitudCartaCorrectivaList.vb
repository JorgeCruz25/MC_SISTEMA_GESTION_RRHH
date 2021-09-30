Imports DevExpress.XtraBars
Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework
Public Class SolicitudCartaCorrectivaList
    Dim bsCartaCorrectiva As New BindingSource

    Sub New()


        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDCARTAINFORMATIVA", "IDCARTAINFORMATIVA", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMEROSOLICITUD", "NUMEROSOLICITUD", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO CARTA", "TIPOCARTAINFORMATIVA", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DOC.EMPLEADO", "NUMERODOCUMENTO", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBREEMPLEADO", "NOMBREEMPLEADO", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO", "CARGO", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        ControlesDevExpress.InitGridViewColumn(GridView1, "USUARIO REGISTRO", "USUARIOREGISTRO", 170, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA REGISTRO", "FECHAREGISTRO", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA VALIDADO", "FECHABLOQUEO", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)

        With GridView1
            .Columns("NUMEROSOLICITUD").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("TIPOCARTAINFORMATIVA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOMBREEMPLEADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CARGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains

            .Columns("USUARIOREGISTRO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAREGISTRO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHABLOQUEO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With


        Refrescar()
    End Sub
    Private Sub Refrescar()
        Try
            inabilitarbotones()

            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioGrid(GridView1, dtAccionesUsuario)

            Me.GridControl1.DataSource = bsCartaCorrectiva
            bsCartaCorrectiva.DataSource = CartaCorrectivaDAO.GetByAllCartaCorrectiva()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        GridView1.Columns.Item(0).VisibleIndex = 0
        GridView1.Columns.Item(1).VisibleIndex = 1
        GridView1.Columns.Item(2).VisibleIndex = 2
        GridView1.Columns.Item(3).VisibleIndex = 3
        GridView1.Columns.Item(4).VisibleIndex = 4
    End Sub
    Private Sub inabilitarbotones()
        GridView1.Columns.Item("APROBAR").Visible = False
        GridView1.Columns.Item("ANULAR").Visible = False
        GridView1.Columns.Item("ARCHIVO").Visible = False
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub SolicitudCartaCorrectivaList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub RepositoryItemAprobar_Click(sender As Object, e As EventArgs) Handles RepositoryItemAprobar.Click
        Dim CantidadAdjunto As Int32
        Dim IDCARTAINFORMATIVA As Integer = GridView1.GetFocusedRowCellValue("IDCARTAINFORMATIVA")
        Dim NUMEROSOLICITUD As String = GridView1.GetFocusedRowCellValue("NUMEROSOLICITUD")
        CantidadAdjunto = CartaCorrectivaDAO.ObtenerCantidadArchivosGetId(Convert.ToString(IDCARTAINFORMATIVA))
        If CantidadAdjunto = 0 Then
            MessageBox.Show("Para poder aprobar la solicitud n° " & NUMEROSOLICITUD & " tiene que tener un adjunto de por medio")
        Else
            If MessageBox.Show("Estas seguro de aprobar la solicitud n° " & NUMEROSOLICITUD, "Aprobar Solicitud", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

                CartaCorrectivaDAO.AprobarCartaCorrectiva(IDCARTAINFORMATIVA, BDCentralDAO.UsuarioBE.IDUsuario)

            End If
        End If
        Refrescar()
    End Sub

    Private Sub RepositoryItemAnular_Click(sender As Object, e As EventArgs) Handles RepositoryItemAnular.Click
        Dim IDCARTAINFORMATIVA As Integer = GridView1.GetFocusedRowCellValue("IDCARTAINFORMATIVA")
        Dim NUMEROSOLICITUD As String = GridView1.GetFocusedRowCellValue("NUMEROSOLICITUD")
        If MessageBox.Show("Estas seguro de aprobar la solicitud n° " & NUMEROSOLICITUD, "Aprobar Solicitud", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            CartaCorrectivaDAO.AnularCartaCorrectiva(IDCARTAINFORMATIVA, BDCentralDAO.UsuarioBE.IDUsuario)
        End If

    End Sub

    Private Sub RepositoryItemArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemArchivo.Click
        Dim IDCARTAINFORMATIVA As Integer = GridView1.GetFocusedRowCellValue("IDCARTAINFORMATIVA")
        Dim NumeroSolicitud As String = GridView1.GetFocusedRowCellValue("NUMEROSOLICITUD")
        If IDCARTAINFORMATIVA <> 0 Then
            Dim MiForm As New CartaConocimientoArchivos
            Dim dt1 As DataTable = CartaCorrectivaDAO.ListarAdjuntosCartaCorrectiva(IDCARTAINFORMATIVA)
            If dt1.Rows.Count <> 0 Then
                For i As Integer = 0 To dt1.Rows.Count - 1
                    Dim ruta As String = dt1.Rows(i).Table(i)("LINKDESCARGA").ToString
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
                MessageBox.Show("La solicutud n° " & NumeroSolicitud & " no tiene adjunto", "Archivo de Carta Correctiva")
            End If

        End If
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub
End Class