Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework
Public Class LicenciasSinGoceList
    Dim bsSolicitudLicencias As New BindingSource
    Dim LicenciasBE As New LicenciasBE
    Private Sub ListarLicenciasSinGoce()
        Refrescar()
    End Sub
    Private Sub ListarModificaciones()

        bsSolicitudLicencias.DataSource = LicenciaDAO.LicenciasSinGoceListAll()
        Me.GridControl1.DataSource = bsSolicitudLicencias
    End Sub

    Private Sub Refrescar()
        btnExportarSolicitudes.Visibility = BarItemVisibility.Never

        GridView1.Columns.Item("OBSERVACIONLICENCIAOTROS").Visible = False
        'GridView1.Columns.Item("ESTADOPAGO").Visible = False
        GridView1.Columns.Item("IDMESEVALUACION").Visible = False
        GridView1.Columns.Item("CANTIDADDIAS").Visible = False
        GridView1.Columns.Item("IDLICENCIA").Visible = False
        'GridView1.Columns.Item("ESTADOVALIDADOSGHRRHH").Visible = False
        GridView1.Columns.Item("APROBAR").Visible = False
        GridView1.Columns.Item("ANULAR").Visible = False
        GridView1.Columns.Item("VERDETALLELICENCIA").Visible = False
        GridView1.Columns.Item("ADJUNTO").Visible = False
        GridView1.Columns.Item("ACTAACUERDO").Visible = False
        GridView1.Columns.Item("FECHAPERIODOFIN").Visible = False
        GridView1.Columns.Item("FECHAPERIODOINICIO").Visible = False
        GridView1.Columns.Item("IDMOTIVODERECHOLEY").Visible = False
        GridView1.Columns.Item("IDLICENCIATIPO").Visible = False

        GridView1.Columns.Item("ADJUNTO").VisibleIndex = 0
        GridView1.Columns.Item("APROBAR").VisibleIndex = 1
        GridView1.Columns.Item("ANULAR").VisibleIndex = 2
        GridView1.Columns.Item("ACTAACUERDO").VisibleIndex = 3
        GridView1.Columns.Item("VERDETALLELICENCIA").VisibleIndex = 4
        GridView1.Columns.Item("MATRICULA").VisibleIndex = 5
        GridView1.Columns.Item("APELLIDOPATERNO").VisibleIndex = 6
        GridView1.Columns.Item("APELLIDOMATERNO").VisibleIndex = 7
        GridView1.Columns.Item("NOMBRES").VisibleIndex = 8
        GridView1.Columns.Item("NUMERODOCUMENTO").VisibleIndex = 9
        GridView1.Columns.Item("NUMEROSOLICITUD").VisibleIndex = 10
        GridView1.Columns.Item("FECHA").VisibleIndex = 11
        GridView1.Columns.Item("TELEFONO").VisibleIndex = 12
        GridView1.Columns.Item("CARGO").VisibleIndex = 13
        GridView1.Columns.Item("RAZONCOMERCIAL").VisibleIndex = 14
        GridView1.Columns.Item("RAZONSOCIAL").VisibleIndex = 15
        GridView1.Columns.Item("FECHAINGRESOCORPORACION").VisibleIndex = 16
        GridView1.Columns.Item("FECHAINGRESO").VisibleIndex = 17
        GridView1.Columns.Item("DESCRIPCION").VisibleIndex = 18
        GridView1.Columns.Item("IDLICENCIATIPO").VisibleIndex = 19
        GridView1.Columns.Item("IDMOTIVODERECHOLEY").VisibleIndex = 20
        GridView1.Columns.Item("FECHAPERIODOINICIO").VisibleIndex = 21
        GridView1.Columns.Item("FECHAPERIODOFIN").VisibleIndex = 22
        GridView1.Columns.Item("CANTIDADDIAS").VisibleIndex = 23
        GridView1.Columns.Item("IDMESEVALUACION").VisibleIndex = 24
        GridView1.Columns.Item("OBSERVACIONLICENCIAOTROS").VisibleIndex = 25


        Dim dtAccionesUsuario As DataTable
        dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
        Tools.AccionesUsuarioGrid(GridView1, dtAccionesUsuario)


        Dim dtAccionesBotones As DataTable
        dtAccionesBotones = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
        Tools.AccionesUsuarioRibbon(Ribbon, dtAccionesBotones)
        bsSolicitudLicencias.DataSource = LicenciaDAO.LicenciasSinGoceListAll()
        Me.GridControl1.DataSource = bsSolicitudLicencias
    End Sub

    Private Sub RepositoryItemAcuerdoArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemAcuerdoArchivo.Click
        LicenciaDAO.IdLicencia = GridView1.GetFocusedRowCellValue("IDLICENCIA")
        Dim MiForm As New LicenciaArchivo
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
    Private Sub LicenciasSinGoceList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    'Private Sub btnEvaluar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEvaluar.ItemClick
    '    LicenciaDAO.IdLicencia = GridView1.GetFocusedRowCellValue("IDLICENCIA")
    '    LicenciaDAO.IdEmpleado = GridView1.GetFocusedRowCellValue("IDEMPLEADO")
    '    LicenciaDAO.IdTipoLicencia = GridView1.GetFocusedRowCellValue("IDLICENCIATIPO")
    '    Dim MiForm As New LicenciasDetails
    '    If GridView1.GetFocusedRowCellValue("ESTADOVALIDADOSGHRRHH") Then

    '        MiForm.btnValidar.Visibility = BarItemVisibility.Never
    '        MiForm.dtFechaInicio.Enabled = False
    '        MiForm.dtFechaFin.Enabled = False
    '    Else
    '        MiForm.btnAprobar.Visibility = BarItemVisibility.Never
    '    End If

    '    MiForm.lblTipoLicencia.Visible = False
    '    MiForm.sleTipoLicencia.Visible = False
    '    If LicenciaDAO.IdLicencia <> 0 Then
    '        MiForm.ShowDialog()
    '        Refrescar()
    '    End If
    'End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub LicenciasSinGoceList_Load(sender As Object, e As EventArgs) Handles Me.Load
        GridView1.Columns(0).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(1).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(2).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(3).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(4).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(5).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(6).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(7).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(8).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        ListarLicenciasSinGoce()
        CargarTipoLicencia()
        CargarMotivo()
        CargarMes()
    End Sub
    Private Sub CargarMotivo()
        ControlesDevExpress.InitGridViewColumn(GridViewMotivo, "ID", "IDMOTIVODERECHOLEY", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewMotivo, "DESCRIPCION", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewMotivo
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        RepositoryItemGridMotivo.DataSource = LicenciaDAO.LicenciasConGoceMotevoLeyList
        RepositoryItemGridMotivo.ValueMember = "IDMOTIVODERECHOLEY"
        RepositoryItemGridMotivo.DisplayMember = "DESCRIPCION"
        RepositoryItemGridMotivo.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarTipoLicencia()
        ControlesDevExpress.InitGridViewColumn(GridViewLicenciaTipo, "ID", "IDLICENCIATIPO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewLicenciaTipo, "DESCRIPCION", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewLicenciaTipo
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        RepositoryItemGridTipoLicencia.DataSource = LicenciaDAO.GetListarTipoLicencia()
        RepositoryItemGridTipoLicencia.ValueMember = "IDLICENCIATIPO"
        RepositoryItemGridTipoLicencia.DisplayMember = "DESCRIPCION"
        RepositoryItemGridTipoLicencia.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarMes()
        ControlesDevExpress.InitGridViewColumn(GridViewMesEvaluacion, "ID", "IDMESEVALUACION", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewMesEvaluacion, "DESCRIPCION", "MES", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewMesEvaluacion
            .Columns("MES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        RepositoryItemGridMesEvaluacion.DataSource = LicenciaDAO.GetListarMesEnfermedades
        RepositoryItemGridMesEvaluacion.ValueMember = "IDMESEVALUACION"
        RepositoryItemGridMesEvaluacion.DisplayMember = "MES"
        RepositoryItemGridMesEvaluacion.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub RepositoryItemVerDetalle_Click(sender As Object, e As EventArgs) Handles RepositoryItemVerDetalle.Click

        LicenciaDAO.IdLicencia = GridView1.GetFocusedRowCellValue("IDLICENCIA")
        LicenciaDAO.IdEmpleado = GridView1.GetFocusedRowCellValue("IDEMPLEADO")
        LicenciaDAO.IdTipoLicencia = GridView1.GetFocusedRowCellValue("IDLICENCIATIPO")
        Dim MiForm As New LicenciasDetails
        MiForm.btnAnular.Visibility = BarItemVisibility.Never
        MiForm.btnAprobar.Visibility = BarItemVisibility.Never
        MiForm.lblTipoLicencia.Visible = False
        MiForm.sleTipoLicencia.Visible = False

        'If GridView1.GetFocusedRowCellValue("ESTADOVALIDADOSGHRRHH") Then
        '    MiForm.btnValidar.Visibility = BarItemVisibility.Never
        'End If
        MiForm.ShowDialog()
        Refrescar()

    End Sub

    Private Sub RepositoryItemAprobar_Click(sender As Object, e As EventArgs) Handles RepositoryItemAprobar.Click

        Dim IdLicencia As Integer = GridView1.GetFocusedRowCellValue("IDLICENCIA")
        Dim IdEmpleado As Integer = GridView1.GetFocusedRowCellValue("IDEMPLEADO")
        Dim Nombres As String = GridView1.GetFocusedRowCellValue("NOMBRES")
        Dim ApellidoPaterno As String = GridView1.GetFocusedRowCellValue("APELLIDOPATERNO")
        Dim ApellidoMaterno As String = GridView1.GetFocusedRowCellValue("APELLIDOMATERNO")
        Dim Empleado As String = ApellidoPaterno & " " & ApellidoMaterno & " " & Nombres
        Dim FechaPeriodoInicio As Date = GridView1.GetFocusedRowCellValue("FECHAPERIODOINICIO")
        Dim FechaPeriodoFin As Date = GridView1.GetFocusedRowCellValue("FECHAPERIODOFIN")
        Dim IdMesEvaluacion As Integer = GridView1.GetFocusedRowCellValue("IDMESEVALUACION")

        Dim IdMotivoDerechoLey As Integer = GridView1.GetFocusedRowCellValue("IDMOTIVODERECHOLEY")
        If IdMesEvaluacion = 0 Then
            Cursor = Cursors.Default
            MessageBox.Show("Información incompleta, ingrese el Mes de evaluación.")
            Exit Sub
        End If

        If FechaPeriodoInicio > FechaPeriodoFin Then
            Cursor = Cursors.Default
            MessageBox.Show("Información erronea, El periodo de inicio no puede se mayor al periodo final.")
            Exit Sub
        End If

        If IdMotivoDerechoLey = 0 Then
            Cursor = Cursors.Default
            MessageBox.Show("Información incompleta, ingrese los Motivo")
            Exit Sub
        End If

        Dim dt As DataTable
        dt = LicenciaDAO.ListaLicenciaAcuerdoArchivos(IdLicencia)
        If dt.Rows.Count <> 0 Then
            Dim dtvalidado As DataTable
            dtvalidado = LicenciaDAO.ValidadoLicenciasGetId(IdLicencia, IdEmpleado, FechaPeriodoInicio, FechaPeriodoFin)
            If dtvalidado.Rows(0)("RESULT") = 15 Then
                If MessageBox.Show("¿Está seguro de aprobar licencia al empleado " & Empleado & " ?", "Aprobar Licencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                    If Not LicenciaDAO.AprobarLicenciaSinGoceByID(IdLicencia, BDCentralDAO.UsuarioBE.IDUsuario) Then
                        MessageBox.Show("Error al aprobar Licencia")
                    End If
                End If
            Else
                MessageBox.Show(dtvalidado.Rows(0)("MENSAJE"))
            End If

        Else
            MessageBox.Show("Para poder ser validado tiene que estar adjuntado el acuerdo.")
        End If
        ListarLicenciasSinGoce()
    End Sub

    Private Sub RepositoryItemAnular_Click(sender As Object, e As EventArgs) Handles RepositoryItemAnular.Click
        Dim IdLicencia As Integer = GridView1.GetFocusedRowCellValue("IDLICENCIA")
        Dim Nombres As String = GridView1.GetFocusedRowCellValue("NOMBRES")
        Dim ApellidoPaterno As String = GridView1.GetFocusedRowCellValue("APELLIDOPATERNO")
        Dim ApellidoMaterno As String = GridView1.GetFocusedRowCellValue("APELLIDOMATERNO")
        Dim Empleado As String = ApellidoPaterno & " " & ApellidoMaterno & " " & Nombres
        If MessageBox.Show("¿Está seguro de anular la licencia al empleado " & Empleado & " ?", "Anular licencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            If Not LicenciaDAO.AnularLicenciaRRHH(IdLicencia, BDCentralDAO.UsuarioBE.IDUsuario) Then
                MessageBox.Show("Error al anular")
            End If
            ListarLicenciasSinGoce()
        End If
    End Sub

    Private Sub GridView1_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView1.RowUpdated
        Cursor = Cursors.WaitCursor
        With LicenciasBE
            .IdLicencia = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDLICENCIA")
            .IdLicenciaTipo = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDLICENCIATIPO")
            .IdMotivoEnfermedad = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDMOTIVOENFERMEDAD")
            .FechaPeriodoInicio = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAPERIODOINICIO")
            .FechaPeriodoFin = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAPERIODOFIN")
            .IdMesEvaluacion = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDMESEVALUACION")
            .EstadoPago = 0
            .IdMotivoDerechoLey = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDMOTIVODERECHOLEY")
            .ObservacionLicenciaOtros = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "OBSERVACIONLICENCIAOTROS")
            LicenciaDAO.UpdateLicenciaConGoceDatosById(LicenciasBE)

            'Refrescar()
            ListarModificaciones()
        End With
    End Sub

    Private Sub btnExportarSolicitudes_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnExportarSolicitudes.ItemClick
        If GridView1.RowCount > 0 Then
            Try
                'GridView1.Columns("DESCRIPCIONESTADOPAGO").Visible = True
                GridView1.Columns("FECHAINGRESOCORPORACION").Visible = False
                GridView1.Columns("DESCRIPCION").Visible = False
                'GridView1.Columns("ESTADOPAGO").Visible = False

                GridView1.Columns(1).Visible = False
                GridView1.Columns(2).Visible = False
                GridView1.Columns(3).Visible = False
                GridView1.Columns(4).Visible = False
                GridView1.Columns(5).Visible = False
                GridView1.Columns(6).Visible = False
                GridView1.Columns(11).Visible = False
                GridView1.Columns(12).Visible = False

                Dim ruta As String
                ruta = My.Application.Info.DirectoryPath() + "\LicenciaSinGoce.xlsx"
                GridControl1.ExportToXlsx(ruta)
                Process.Start(ruta)

            Catch ex As Exception
                MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
            End Try
            GridView1.Columns(1).VisibleIndex = 1
            GridView1.Columns(2).VisibleIndex = 2
            GridView1.Columns(3).VisibleIndex = 3
            GridView1.Columns(4).VisibleIndex = 4
            GridView1.Columns(5).VisibleIndex = 5
            GridView1.Columns(6).VisibleIndex = 6
            GridView1.Columns(7).VisibleIndex = 7
            GridView1.Columns(8).VisibleIndex = 8
            GridView1.Columns(9).VisibleIndex = 9
            GridView1.Columns(10).VisibleIndex = 10
            GridView1.Columns(11).VisibleIndex = 11
            GridView1.Columns(12).VisibleIndex = 12
            GridView1.Columns(13).VisibleIndex = 13
            GridView1.Columns(14).VisibleIndex = 14
            GridView1.Columns(15).VisibleIndex = 15

            GridView1.Columns(1).Visible = True
            GridView1.Columns(2).Visible = True
            GridView1.Columns(3).Visible = True
            GridView1.Columns(4).Visible = True
            GridView1.Columns(5).Visible = True
            GridView1.Columns(6).Visible = True
            GridView1.Columns(11).Visible = True
            GridView1.Columns(12).Visible = True
            GridView1.Columns("FECHAINGRESOCORPORACION").Visible = True
            GridView1.Columns("DESCRIPCION").Visible = True
            'GridView1.Columns("ESTADOPAGO").Visible = True
            'GridView1.Columns("DESCRIPCIONESTADOPAGO").Visible = False
        End If
    End Sub

    Private Sub RepositoryItemGridMotivo_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemGridMotivo.EditValueChanged
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()
    End Sub

    Private Sub RepositoryItemGridMesEvaluacion_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemGridMesEvaluacion.EditValueChanged
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()
    End Sub

    Private Sub RepositoryItemDateFechaInicio_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemDateFechaInicio.EditValueChanged
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()
    End Sub

    Private Sub RepositoryItemDateFechaFinal_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemDateFechaFinal.EditValueChanged
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()
    End Sub

End Class