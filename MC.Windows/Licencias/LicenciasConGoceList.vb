Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework
Public Class LicenciasConGoceList
    Dim bsSolicitudLicencias As New BindingSource
    Dim LicenciasBE As New LicenciasBE
    Private Sub ListarLicenciasConGoce()
        Refrescar()
    End Sub
    Private Sub ListarModificaciones()
        'Dim dtAccionesUsuario As DataTable
        'dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
        'Tools.AccionesUsuarioGrid(GridView1, dtAccionesUsuario)
        'Dim dtAccionesBotones As DataTable
        'dtAccionesBotones = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
        'Tools.AccionesUsuarioRibbon(Ribbon, dtAccionesBotones)

        bsSolicitudLicencias.DataSource = LicenciaDAO.LicenciasConGoceListAll()
        Me.GridControl1.DataSource = bsSolicitudLicencias
    End Sub
    Private Sub Refrescar()
        btnExportarSolicitudes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        GridView1.Columns.Item("APROBAR").Visible = False
        GridView1.Columns.Item("ANULAR").Visible = False
        GridView1.Columns.Item("SUSTENTO").Visible = False
        GridView1.Columns.Item("VERDETALLE").Visible = False
        GridView1.Columns.Item("IDLICENCIATIPO").Visible = False
        GridView1.Columns.Item("IDMOTIVODERECHOLEY").Visible = False
        GridView1.Columns.Item("FECHAPERIODOINICIO").Visible = False
        GridView1.Columns.Item("FECHAPERIODOFIN").Visible = False
        GridView1.Columns.Item("CANTIDADDIAS").Visible = False
        GridView1.Columns.Item("IDMESEVALUACION").Visible = False
        GridView1.Columns.Item("ESTADOPAGO").Visible = False
        GridView1.Columns.Item("DESCRIPCIONESTADOPAGO").Visible = False
        GridView1.Columns.Item("OBSERVACIONLICENCIAOTROS").Visible = False

        GridView1.Columns.Item("APROBAR").VisibleIndex = 0
        GridView1.Columns.Item("ANULAR").VisibleIndex = 1
        GridView1.Columns.Item("SUSTENTO").VisibleIndex = 2
        GridView1.Columns.Item("VERDETALLE").VisibleIndex = 3
        GridView1.Columns.Item("MATRICULA").VisibleIndex = 4
        GridView1.Columns.Item("APELLIDOPATERNO").VisibleIndex = 5
        GridView1.Columns.Item("APELLIDOMATERNO").VisibleIndex = 6
        GridView1.Columns.Item("NOMBRES").VisibleIndex = 7
        GridView1.Columns.Item("NUMERODOCUMENTO").VisibleIndex = 8
        GridView1.Columns.Item("NUMEROSOLICITUD").VisibleIndex = 9
        GridView1.Columns.Item("FECHA").VisibleIndex = 10
        GridView1.Columns.Item("TELEFONO").VisibleIndex = 11
        GridView1.Columns.Item("PUESTO").VisibleIndex = 12
        GridView1.Columns.Item("RAZONCOMERCIAL").VisibleIndex = 13
        GridView1.Columns.Item("RAZONSOCIAL").VisibleIndex = 14
        GridView1.Columns.Item("FECHAINGRESOCORPORACION").VisibleIndex = 15
        GridView1.Columns.Item("FECHAINGRESO").VisibleIndex = 16
        GridView1.Columns.Item("DESCRIPCION").VisibleIndex = 17
        GridView1.Columns.Item("IDLICENCIATIPO").VisibleIndex = 18
        GridView1.Columns.Item("IDMOTIVODERECHOLEY").VisibleIndex = 19
        GridView1.Columns.Item("FECHAPERIODOINICIO").VisibleIndex = 20
        GridView1.Columns.Item("FECHAPERIODOFIN").VisibleIndex = 21
        GridView1.Columns.Item("CANTIDADDIAS").VisibleIndex = 22
        GridView1.Columns.Item("IDMESEVALUACION").VisibleIndex = 23
        GridView1.Columns.Item("ESTADOPAGO").VisibleIndex = 24
        GridView1.Columns.Item("DESCRIPCIONESTADOPAGO").VisibleIndex = 25
        GridView1.Columns.Item("OBSERVACIONLICENCIAOTROS").VisibleIndex = 26
        '''GridView1.Columns.Item("IDLICENCIA").Visible = False

        Dim dtAccionesUsuario As DataTable
        dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
        Tools.AccionesUsuarioGrid(GridView1, dtAccionesUsuario)


        Dim dtAccionesBotones As DataTable
        dtAccionesBotones = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
        Tools.AccionesUsuarioRibbon(Ribbon, dtAccionesBotones)

        bsSolicitudLicencias.DataSource = LicenciaDAO.LicenciasConGoceListAll()
        Me.GridControl1.DataSource = bsSolicitudLicencias

    End Sub
    Private Sub LicenciasConGoceList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridView1.Columns(0).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(1).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(2).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(3).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(4).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(5).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(6).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(7).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        '''GridView1.Columns(8).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        ListarLicenciasConGoce()
        CargarTipoLicencia()
        CargarMotivo()
        CargarMes()
        GridView1.Columns("DESCRIPCIONESTADOPAGO").Visible = False
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
        ControlesDevExpress.InitGridViewColumn(GridViewTipoLicencia, "ID", "IDLICENCIATIPO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewTipoLicencia, "DESCRIPCION", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewTipoLicencia
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
    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub
    'Private Sub btnEValuar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEValuar.ItemClick
    '    LicenciaDAO.IdLicencia = GridView1.GetFocusedRowCellValue("IDLICENCIA")
    '    LicenciaDAO.IdEmpleado = GridView1.GetFocusedRowCellValue("IDEMPLEADO")
    '    LicenciaDAO.IdTipoLicencia = GridView1.GetFocusedRowCellValue("IDLICENCIATIPO")
    '    If LicenciaDAO.IdLicencia <> 0 Then
    '        Dim MiForm As New LicenciasDetails
    '        MiForm.btnValidar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

    '        MiForm.ShowDialog()
    '        Refrescar()
    '    End If
    'End Sub
    Private Sub SolicitudLicenciasList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub


    Private Sub RepositoryItemSustentoArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemSustentoArchivo.Click
        LicenciaDAO.IdLicencia = GridView1.GetFocusedRowCellValue("IDLICENCIA")
        If LicenciaDAO.IdLicencia <> 0 Then
            Dim MiForm As New LicenciaArchivo
            Dim dt1 As DataTable = LicenciaDAO.ListaLicenciaArchivos(LicenciaDAO.IdLicencia)
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
                MessageBox.Show("Archivo de compromiso no adjuntado", "Archivo de Licencia")
            End If
        End If
    End Sub

    Private Sub GridView1_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView1.RowUpdated
        Cursor = Cursors.WaitCursor
        'Me.GridView1.PostEditor()
        'Me.GridView1.CloseEditor()
        'Me.GridView1.CancelUpdateCurrentRow()

        With LicenciasBE

            .IdLicencia = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDLICENCIA")
            .IdLicenciaTipo = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDLICENCIATIPO")
            .IdMotivoEnfermedad = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDMOTIVOENFERMEDAD")
            .FechaPeriodoInicio = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAPERIODOINICIO")
            .FechaPeriodoFin = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAPERIODOFIN")
            .IdMesEvaluacion = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDMESEVALUACION")
            .EstadoPago = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ESTADOPAGO")
            .IdMotivoDerechoLey = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDMOTIVODERECHOLEY")
            .ObservacionLicenciaOtros = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "OBSERVACIONLICENCIAOTROS")
            LicenciaDAO.UpdateLicenciaConGoceDatosById(LicenciasBE)
            'Refrescar()
            ListarModificaciones()
        End With

    End Sub

    Private Sub RepositoryItemAnular_Click(sender As Object, e As EventArgs) Handles RepositoryItemAnular.Click
        Dim idlicencia As Integer = GridView1.GetFocusedRowCellValue("IDLICENCIA")
        Dim Nombres As String = GridView1.GetFocusedRowCellValue("NOMBRES")
        Dim ApellidoPaterno As String = GridView1.GetFocusedRowCellValue("APELLIDOPATERNO")
        Dim ApellidoMaterno As String = GridView1.GetFocusedRowCellValue("APELLIDOMATERNO")
        Dim Empleado As String = ApellidoPaterno & " " & ApellidoMaterno & " " & Nombres
        If MessageBox.Show("¿Está seguro de anular la licencia del empleado " & Empleado & " ?", "Anular licencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            If Not LicenciaDAO.AnularLicenciaRRHH(idlicencia, BDCentralDAO.UsuarioBE.IDUsuario) Then
                MessageBox.Show("Error al anular")
            End If
        End If
        ListarLicenciasConGoce()
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
            MessageBox.Show("Información incompleta, ingrese el motivo.")
            Exit Sub
        End If

        Dim dt As New DataTable
        dt = LicenciaDAO.ListaLicenciaArchivos(IdLicencia)
        If dt.Rows.Count > 0 Then
            Dim dtvalidado As DataTable
            dtvalidado = LicenciaDAO.ValidadoLicenciasGetId(IdLicencia, IdEmpleado, FechaPeriodoInicio, FechaPeriodoFin)
            If dtvalidado.Rows(0)("RESULT") = 15 Then
                If MessageBox.Show("¿Está seguro de aprobar la licencia al empleado " & Empleado & " ?", "Aprobar licencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                    If Not LicenciaDAO.AccionLicenciaByID(IdLicencia, BDCentralDAO.UsuarioBE.IDUsuario) Then
                        MessageBox.Show("Error al aprobar Licencia")
                    End If
                End If
            Else
                MessageBox.Show(dtvalidado.Rows(0)("MENSAJE"))
            End If
        Else
            MessageBox.Show("Para poder ser aprobado, tiene que haber adjuntado el sustento")
        End If
        ListarLicenciasConGoce()
    End Sub

    Private Sub RepositoryItemVerDetalle_Click(sender As Object, e As EventArgs) Handles RepositoryItemVerDetalle.Click
        LicenciaDAO.IdLicencia = GridView1.GetFocusedRowCellValue("IDLICENCIA")
        LicenciaDAO.IdEmpleado = GridView1.GetFocusedRowCellValue("IDEMPLEADO")
        LicenciaDAO.IdTipoLicencia = GridView1.GetFocusedRowCellValue("IDLICENCIATIPO")
        If LicenciaDAO.IdLicencia <> 0 Then

            Dim MiForm As New LicenciasDetails
            MiForm.btnValidar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnAprobar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnAnular.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.sleTipoLicencia.Enabled = False
            MiForm.dtFechaInicio.Enabled = False
            MiForm.dtFechaFin.Enabled = False
            MiForm.ShowDialog()
            Refrescar()
        End If
    End Sub

    Private Sub btnExportarSolicitudes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportarSolicitudes.ItemClick
        If GridView1.RowCount > 0 Then
            Try
                GridView1.Columns("DESCRIPCIONESTADOPAGO").Visible = True
                'GridView1.Columns("FECHAINGRESOCORPORACION").Visible = False
                GridView1.Columns("DESCRIPCION").Visible = False
                GridView1.Columns("ESTADOPAGO").Visible = False
                'GridView1.Columns("NUMEROSOLICITUD").Visible = False
                GridView1.Columns(0).Visible = False
                GridView1.Columns(1).Visible = False
                GridView1.Columns(2).Visible = False
                GridView1.Columns(3).Visible = False
                'GridView1.Columns(10).Visible = False

                Dim ruta As String
                ruta = My.Application.Info.DirectoryPath() + "\LicenciaConnGoce  .xlsx"
                GridControl1.ExportToXlsx(ruta)
                Process.Start(ruta)
            Catch ex As Exception
                MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
            End Try

            GridView1.Columns(0).Visible = True
            GridView1.Columns(1).Visible = True
            GridView1.Columns(2).Visible = True
            GridView1.Columns(3).Visible = True
            GridView1.Columns(0).VisibleIndex = 0
            GridView1.Columns(1).VisibleIndex = 1
            GridView1.Columns(2).VisibleIndex = 2
            GridView1.Columns(3).VisibleIndex = 3
            'GridView1.Columns(10).Visible = False
            'GridView1.Columns("FECHAINGRESOCORPORACION").Visible = True
            GridView1.Columns("DESCRIPCION").Visible = True
            GridView1.Columns("ESTADOPAGO").Visible = True
            GridView1.Columns("DESCRIPCIONESTADOPAGO").Visible = False
            'GridView1.Columns("NUMEROSOLICITUD").Visible = True

        End If
    End Sub

    Private Sub RepositoryItemGridMesEvaluacion_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemGridMesEvaluacion.EditValueChanged
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()
    End Sub

    Private Sub RepositoryItemGridMotivo_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemGridMotivo.EditValueChanged
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()
    End Sub

    Private Sub RepositoryItemGridTipoLicencia_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemGridTipoLicencia.EditValueChanged
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()
    End Sub

    Private Sub RepositoryItemDateFechaInicial_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemDateFechaInicial.EditValueChanged
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()
    End Sub

    Private Sub RepositoryItemDateFechaFinal_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemDateFechaFinal.EditValueChanged
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()
    End Sub

    Private Sub RepositoryItemCheckEditEstadoPago_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEditEstadoPago.EditValueChanged
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()
    End Sub
End Class