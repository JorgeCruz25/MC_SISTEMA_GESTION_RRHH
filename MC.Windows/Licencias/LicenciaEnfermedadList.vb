Imports MC.Data
Imports System.Net.Mail
Imports System.Net
Imports System.Security.Cryptography.X509Certificates
Imports System.Net.Security
Imports MC.Framework
Imports DevExpress.XtraGrid.Views.Base
Imports System.Net.Mime
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraTab

Public Class LicenciaEnfermedadList
    Dim LicenciasBE As New LicenciasBE
    Private Sub ListarDescansoMedico()

        GridControl1.DataSource = LicenciaDAO.LicenciasConGoceDescansoMedicoListAll

        'GridView1.Columns.Item("IDLICENCIA").VisibleIndex = 0
        btnExportarSolicitantes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

        Dim dtAccionesbutton As DataTable
        dtAccionesbutton = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
        Tools.AccionesUsuarioRibbon(Ribbon, dtAccionesbutton)

        GridView1.Columns.Item("APROBAR").VisibleIndex = 0
        GridView1.Columns.Item("ANULAR").VisibleIndex = 1
        GridView1.Columns.Item("SUSTENTO").VisibleIndex = 2
        GridView1.Columns.Item("VERDETALLE").VisibleIndex = 3

        GridView1.Columns.Item("APROBAR").Visible = False
        GridView1.Columns.Item("ANULAR").Visible = False
        GridView1.Columns.Item("SUSTENTO").Visible = False
        GridView1.Columns.Item("VERDETALLE").Visible = False
        GridView1.Columns.Item("IDLICENCIATIPO").Visible = False
        GridView1.Columns.Item("IDPROCEDENCIA").Visible = False
        GridView1.Columns.Item("NUMERODESCANSOMEDICO").Visible = False
        GridView1.Columns.Item("IDMOTIVOENFERMEDAD").Visible = False
        GridView1.Columns.Item("IDSUBGRUPOFAMILIAENFERMEDAD").Visible = False
        GridView1.Columns.Item("SUBGRUPOFAMILIAENFERMEDAD").Visible = False
        GridView1.Columns.Item("FECHAPERIODOINICIO").Visible = False
        GridView1.Columns.Item("FECHAPERIODOFIN").Visible = False
        GridView1.Columns.Item("CANTIDADDIAS").Visible = False
        GridView1.Columns.Item("IDMESEVALUACION").Visible = False
        GridView1.Columns.Item("ESTADOPAGO").Visible = False
        GridView1.Columns.Item("DESCRIPCIONESTADOPAGO").Visible = False
        GridView1.Columns.Item("DECLARACION").Visible = False
        GridView1.Columns.Item("DIASSUBSIDIO").Visible = False
        GridView1.Columns.Item("DIASRECUPERADOS").Visible = False
        GridView1.Columns.Item("DESCRIPCIONDECLARACION").Visible = False
        GridView1.Columns.Item("NITESSALUD").Visible = False
        GridView1.Columns.Item("FECHARECEPCION").Visible = False
        GridView1.Columns.Item("IDTIPOOBSERVACIONENFERMEDAD").Visible = False
        GridView1.Columns.Item("DETALLEDESCANSOMEDICO").Visible = False
        GridView1.Columns.Item("IDBANCO").Visible = False
        GridView1.Columns.Item("NUMEROCHEQUE").Visible = False
        GridView1.Columns.Item("MONTOSUBSIDIADO").Visible = False
        GridView1.Columns.Item("CONTABILIDAD").Visible = False
        GridView1.Columns.Item("DIASANULADO").Visible = False

        Dim dtAccionesUsuario As DataTable
        dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
        Tools.AccionesUsuarioGrid(GridView1, dtAccionesUsuario)

        GridView1.Columns.Item("TELEFONO").VisibleIndex = 9
        GridView1.Columns.Item("NUMEROSOLICITUD").VisibleIndex = 10
        GridView1.Columns.Item("FECHA").VisibleIndex = 11
        GridView1.Columns.Item("PUESTO").VisibleIndex = 12
        GridView1.Columns.Item("RAZONCOMERCIAL").VisibleIndex = 13
        GridView1.Columns.Item("RAZONSOCIAL").VisibleIndex = 14

        If GridView1.Columns.Item("IDLICENCIATIPO").Visible Then
            GridView1.Columns.Item("IDLICENCIATIPO").VisibleIndex = 15
        End If
        If GridView1.Columns.Item("IDPROCEDENCIA").Visible Then
            GridView1.Columns.Item("IDPROCEDENCIA").VisibleIndex = 16
        End If
        If GridView1.Columns.Item("NUMERODESCANSOMEDICO").Visible Then
            GridView1.Columns.Item("NUMERODESCANSOMEDICO").VisibleIndex = 17
        End If
        If GridView1.Columns.Item("IDMOTIVOENFERMEDAD").Visible Then
            GridView1.Columns.Item("IDMOTIVOENFERMEDAD").VisibleIndex = 18
        End If
        If GridView1.Columns.Item("IDSUBGRUPOFAMILIAENFERMEDAD").Visible Then
            GridView1.Columns.Item("IDSUBGRUPOFAMILIAENFERMEDAD").VisibleIndex = 19
        End If
        If GridView1.Columns.Item("SUBGRUPOFAMILIAENFERMEDAD").Visible Then
            GridView1.Columns.Item("SUBGRUPOFAMILIAENFERMEDAD").VisibleIndex = 20
        End If
        If GridView1.Columns.Item("FECHAPERIODOINICIO").Visible Then
            GridView1.Columns.Item("FECHAPERIODOINICIO").VisibleIndex = 21
        End If
        If GridView1.Columns.Item("FECHAPERIODOFIN").Visible Then
            GridView1.Columns.Item("FECHAPERIODOFIN").VisibleIndex = 22
        End If
        If GridView1.Columns.Item("CANTIDADDIAS").Visible Then
            GridView1.Columns.Item("CANTIDADDIAS").VisibleIndex = 23
        End If
        If GridView1.Columns.Item("IDMESEVALUACION").Visible Then
            GridView1.Columns.Item("IDMESEVALUACION").VisibleIndex = 24
        End If
        If GridView1.Columns.Item("ESTADOPAGO").Visible Then
            GridView1.Columns.Item("ESTADOPAGO").VisibleIndex = 25
        End If
        If GridView1.Columns.Item("DECLARACION").Visible Then
            GridView1.Columns.Item("DECLARACION").VisibleIndex = 27
        End If
        If GridView1.Columns.Item("DIASSUBSIDIO").Visible Then
            GridView1.Columns.Item("DIASSUBSIDIO").VisibleIndex = 28
        End If
        If GridView1.Columns.Item("DIASRECUPERADOS").Visible Then
            GridView1.Columns.Item("DIASRECUPERADOS").VisibleIndex = 29
        End If
        If GridView1.Columns.Item("DIASANULADO").Visible Then
            GridView1.Columns.Item("DIASANULADO").VisibleIndex = 30
        End If
        If GridView1.Columns.Item("NITESSALUD").Visible Then
            GridView1.Columns.Item("NITESSALUD").VisibleIndex = 32
        End If
        If GridView1.Columns.Item("FECHARECEPCION").Visible Then
            GridView1.Columns.Item("FECHARECEPCION").VisibleIndex = 33
        End If
        If GridView1.Columns.Item("IDTIPOOBSERVACIONENFERMEDAD").Visible Then
            GridView1.Columns.Item("IDTIPOOBSERVACIONENFERMEDAD").VisibleIndex = 34
        End If
        If GridView1.Columns.Item("DETALLEDESCANSOMEDICO").Visible Then
            GridView1.Columns.Item("DETALLEDESCANSOMEDICO").VisibleIndex = 35
        End If
        If GridView1.Columns.Item("IDBANCO").Visible Then
            GridView1.Columns.Item("IDBANCO").VisibleIndex = 36
        End If

        If GridView1.Columns.Item("NUMEROCHEQUE").Visible Then
            GridView1.Columns.Item("NUMEROCHEQUE").VisibleIndex = 37
        End If
        If GridView1.Columns.Item("MONTOSUBSIDIADO").Visible Then
            GridView1.Columns.Item("MONTOSUBSIDIADO").VisibleIndex = 38
        End If
        If GridView1.Columns.Item("CONTABILIDAD").Visible Then
            GridView1.Columns.Item("CONTABILIDAD").VisibleIndex = 39
        End If
        GridView1.Columns.Item("DESCRIPCIONDECLARACION").Visible = False
        GridView1.Columns.Item("DESCRIPCIONESTADOPAGO").Visible = False
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub LicenciaEnfermedadList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub LicenciaEnfermedadList_Load(sender As Object, e As EventArgs) Handles Me.Load
        GridView1.Columns(0).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(1).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(2).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(3).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(4).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(5).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(6).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(7).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(8).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left

        GridView1.Columns("DESCRIPCIONESTADOPAGO").Visible = False
        GridView1.Columns("DESCRIPCIONDECLARACION").Visible = False


        CargarTipoLicencia()
        CargarProcedencia()
        CargarMotivo()
        CargarFamiliaEnfermedades()
        CargarMes()
        CargarObservaciones()
        CargarBanco()

        ListarDescansoMedico()
    End Sub
    Private Sub CargarProcedencia()
        ControlesDevExpress.InitGridViewColumn(GridViewProcedencia, "ID", "IDPROCEDENCIA", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewProcedencia, "DESCRIPCION", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewProcedencia
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        RepositoryItemGridLookUpEditProcedencia.DataSource = LicenciaDAO.LicenciasEnfermedadProcedenciaListAll
        RepositoryItemGridLookUpEditProcedencia.ValueMember = "IDPROCEDENCIA"
        RepositoryItemGridLookUpEditProcedencia.DisplayMember = "DESCRIPCION"
        RepositoryItemGridLookUpEditProcedencia.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub CargarMotivo()
        ControlesDevExpress.InitGridViewColumn(GridViewMotivo, "ID", "IDMOTIVOENFERMEDAD", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewMotivo, "DESCRIPCION", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewMotivo
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        RepositoryItemGridLookUpEditMotivo.DataSource = LicenciaDAO.LicenciasEnfermedadMotivoListAll
        RepositoryItemGridLookUpEditMotivo.ValueMember = "IDMOTIVOENFERMEDAD"
        RepositoryItemGridLookUpEditMotivo.DisplayMember = "DESCRIPCION"
        RepositoryItemGridLookUpEditMotivo.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarTipoLicencia()
        ControlesDevExpress.InitGridViewColumn(GridViewTipoLicencia, "ID", "IDLICENCIATIPO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewTipoLicencia, "DESCRIPCION", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewTipoLicencia
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        RepositoryItemGridLookUpEditTipoLicencia.DataSource = LicenciaDAO.GetListarTipoLicencia()
        RepositoryItemGridLookUpEditTipoLicencia.ValueMember = "IDLICENCIATIPO"
        RepositoryItemGridLookUpEditTipoLicencia.DisplayMember = "DESCRIPCION"
        RepositoryItemGridLookUpEditTipoLicencia.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub


    Private Sub CargarFamiliaEnfermedades()
        ControlesDevExpress.InitGridViewColumn(GridViewDiagnosticoGrupo, "ID", "IDSUBGRUPOFAMILIAENFERMEDAD", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDiagnosticoGrupo, "GRUPO ENFERMEDAD", "GRUPOENFERMEDADES", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDiagnosticoGrupo, "SUB GRUPO ENFERMEDAD", "SUBGRUPOENFERMEDADES", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewDiagnosticoGrupo
            .Columns("GRUPOENFERMEDADES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("SUBGRUPOENFERMEDADES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        RepositoryItemGridLookUpEditDiagnosticoGrupo.DataSource = LicenciaDAO.GetListarSubGrupoEnfermedades
        RepositoryItemGridLookUpEditDiagnosticoGrupo.ValueMember = "IDSUBGRUPOFAMILIAENFERMEDAD"
        RepositoryItemGridLookUpEditDiagnosticoGrupo.DisplayMember = "GRUPOENFERMEDADES"
        RepositoryItemGridLookUpEditDiagnosticoGrupo.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub CargarMes()
        ControlesDevExpress.InitGridViewColumn(GridViewMesEvaluacion, "ID", "IDMESEVALUACION", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewMesEvaluacion, "DESCRIPCION", "MES", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewMesEvaluacion
            .Columns("MES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        RepositoryItemGridLookUpEditMesEvaluacion.DataSource = LicenciaDAO.GetListarMesEnfermedades
        RepositoryItemGridLookUpEditMesEvaluacion.ValueMember = "IDMESEVALUACION"
        RepositoryItemGridLookUpEditMesEvaluacion.DisplayMember = "MES"
        RepositoryItemGridLookUpEditMesEvaluacion.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub CargarObservaciones()
        ControlesDevExpress.InitGridViewColumn(GridViewObservacion, "ID", "IDOBSERVACIONENFERMEDAD", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewObservacion, "DESCRIPCION", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewObservacion
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        RepositoryItemGridLookUpEditObservacion.DataSource = LicenciaDAO.GetListarObservacionEnfermedades
        RepositoryItemGridLookUpEditObservacion.ValueMember = "IDOBSERVACIONENFERMEDAD"
        RepositoryItemGridLookUpEditObservacion.DisplayMember = "DESCRIPCION"
        RepositoryItemGridLookUpEditObservacion.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub CargarBanco()
        ControlesDevExpress.InitGridViewColumn(GridViewBanco, "ID", "IDBANCO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewBanco, "BANCO", "NOMBRE", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewBanco
            .Columns("NOMBRE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        RepositoryItemGridLookUpEditBanco.DataSource = LicenciaDAO.ListarBancoEnfermedades
        RepositoryItemGridLookUpEditBanco.ValueMember = "IDBANCO"
        RepositoryItemGridLookUpEditBanco.DisplayMember = "NOMBRE"
        RepositoryItemGridLookUpEditBanco.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub GridView1_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView1.RowUpdated
        Cursor = Cursors.WaitCursor

        With LicenciasBE
            .IdLicencia = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDLICENCIA")
            .IdSubGrupoEnfermedad = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDSUBGRUPOFAMILIAENFERMEDAD")
            .FechaPeriodoInicio = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAPERIODOINICIO")
            .FechaPeriodoFin = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAPERIODOFIN")
            .NumeroDescansoMedico = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "NUMERODESCANSOMEDICO")
            .IdProcedencia = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDPROCEDENCIA")
            .IdMotivoEnfermedad = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDMOTIVOENFERMEDAD")
            .IdMesEvaluacion = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDMESEVALUACION")
            .EstadoPago = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ESTADOPAGO")
            .Declaracion = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DECLARACION")
            .DiasSubSidio = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DIASSUBSIDIO")
            .DiasRecuperados = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DIASRECUPERADOS")
            .DiasAnulados = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DIASANULADO")
            .NitEssalud = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "NITESSALUD")
            .FechaRecepcion = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHARECEPCION")

            .IdTipoObservacionEnfermedad = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDTIPOOBSERVACIONENFERMEDAD")
            .DetalleDescansoMedico = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DETALLEDESCANSOMEDICO")
            .IdBanco = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDBANCO")
            .NumeroCheque = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "NUMEROCHEQUE")
            .MontoSubSidiado = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "MONTOSUBSIDIADO")
            .IdLicenciaTipo = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDLICENCIATIPO")
            LicenciaDAO.UpdateDatosEnfermedades(LicenciasBE)
        End With

        ListarDescansoMedico()
        Cursor = Cursors.Default

    End Sub
    Private Sub ActualizarEdicionGrilla()
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()
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

    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        ListarDescansoMedico()
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
        ListarDescansoMedico()
    End Sub

    Private Sub RepositoryItemAprobar_Click(sender As Object, e As EventArgs) Handles RepositoryItemAprobar.Click

        Dim IdLicencia As Integer = GridView1.GetFocusedRowCellValue("IDLICENCIA")
        Dim Nombres As String = GridView1.GetFocusedRowCellValue("NOMBRES")
        Dim ApellidoPaterno As String = GridView1.GetFocusedRowCellValue("APELLIDOPATERNO")
        Dim ApellidoMaterno As String = GridView1.GetFocusedRowCellValue("APELLIDOMATERNO")
        Dim Empleado As String = ApellidoPaterno & " " & ApellidoMaterno & " " & Nombres
        Dim IdProcedencia As Integer = GridView1.GetFocusedRowCellValue("IDPROCEDENCIA")
        Dim IdMotivoEnfermedad As Integer = GridView1.GetFocusedRowCellValue("IDMOTIVOENFERMEDAD")
        Dim NumeroDescansoMedico As String = GridView1.GetFocusedRowCellValue("NUMERODESCANSOMEDICO")
        Dim IdSubGrupoEnfermedad As Integer = GridView1.GetFocusedRowCellValue("IDSUBGRUPOFAMILIAENFERMEDAD")
        Dim FechaPeriodoInicio As Date = GridView1.GetFocusedRowCellValue("FECHAPERIODOINICIO")
        Dim FechaPeriodoFin As Date = GridView1.GetFocusedRowCellValue("FECHAPERIODOFIN")
        Dim IdMesEvaluacion As Integer = GridView1.GetFocusedRowCellValue("IDMESEVALUACION")
        Dim DiasSubSidio As Integer = GridView1.GetFocusedRowCellValue("DIASSUBSIDIO")
        Dim IdEmpleado As Integer = GridView1.GetFocusedRowCellValue("IDEMPLEADO")


        If IdProcedencia = 0 Then
            Cursor = Cursors.Default
            MessageBox.Show("Información incompleta, ingrese la procedencia.")
            Exit Sub
        End If
        If NumeroDescansoMedico = "" Then
            Cursor = Cursors.Default
            MessageBox.Show("Información incompleta, ingrese el número de descanso medico.")
            Exit Sub
        End If
        If IdMotivoEnfermedad = 0 Then
            Cursor = Cursors.Default
            MessageBox.Show("Información incompleta, ingrese en motivo.")
            Exit Sub
        End If

        If IdSubGrupoEnfermedad = 0 Then
            Cursor = Cursors.Default
            MessageBox.Show("Información incompleta, ingrese elgrupo y sub-grupo de enferdad.")
            Exit Sub
        End If

        If FechaPeriodoInicio > FechaPeriodoFin Then
            Cursor = Cursors.Default
            MessageBox.Show("Información erronea, El periodo de inicio no puede se mayor al periodo final.")
            Exit Sub
        End If


        If IdMesEvaluacion = 0 Then
            Cursor = Cursors.Default
            MessageBox.Show("Información incompleta, ingrese el mes de evaluación.")
            Exit Sub
        End If
        If DiasSubSidio < 0 Then
            Cursor = Cursors.Default
            MessageBox.Show("Los Dias de subsidio no puede ser menor a 0")
            Exit Sub
        End If
        Dim dtvalidado As DataTable
        dtvalidado = LicenciaDAO.ValidadoLicenciasGetId(IdLicencia, IdEmpleado, FechaPeriodoInicio, FechaPeriodoFin)
        If dtvalidado.Rows(0)("RESULT") = 15 Then
            If MessageBox.Show("¿Está seguro de aprobar licencia al empleado " & Empleado & " ?", "Aprobar Licencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                If Not LicenciaDAO.AprobarLicenciaDescansoMedicoRRHH(IdLicencia, BDCentralDAO.UsuarioBE.IDUsuario) Then
                    MessageBox.Show("Error al aprobar Licencia")
                End If
            End If
        Else
            MessageBox.Show(dtvalidado.Rows(0)("MENSAJE"))
        End If
        ListarDescansoMedico()
    End Sub

    Private Sub btnExportarSolicitantes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportarSolicitantes.ItemClick
        If GridView1.RowCount > 0 Then
            GridView1.Columns("DESCRIPCIONESTADOPAGO").Visible = True

            GridView1.Columns("DESCRIPCIONDECLARACION").Visible = True
            GridView1.Columns("ESTADOPAGO").Visible = False
            GridView1.Columns("DECLARACION").Visible = False
            GridView1.Columns(1).Visible = False
            GridView1.Columns(2).Visible = False
            GridView1.Columns(3).Visible = False
            GridView1.Columns(4).Visible = False
            GridView1.Columns("TELEFONO").Visible = False
            GridView1.Columns("NUMEROSOLICITUD").Visible = False
            GridView1.Columns("IDLICENCIATIPO").Visible = False
            GridView1.Columns("SUBGRUPOFAMILIAENFERMEDAD").Visible = False
            Try
                Dim ruta As String
                ruta = My.Application.Info.DirectoryPath() + "\DescansosMedicos.xlsx"
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
            GridView1.Columns(16).VisibleIndex = 16
            GridView1.Columns(17).VisibleIndex = 17
            GridView1.Columns(18).VisibleIndex = 18
            GridView1.Columns(19).VisibleIndex = 19
            GridView1.Columns(20).VisibleIndex = 20
            GridView1.Columns(21).VisibleIndex = 21
            GridView1.Columns(22).VisibleIndex = 22
            GridView1.Columns(23).VisibleIndex = 23
            GridView1.Columns(24).VisibleIndex = 24
            GridView1.Columns(25).VisibleIndex = 25
            GridView1.Columns(26).VisibleIndex = 26
            GridView1.Columns(27).VisibleIndex = 27

            GridView1.Columns(1).Visible = True
            GridView1.Columns(2).Visible = True
            GridView1.Columns(3).Visible = True
            GridView1.Columns(4).Visible = True

            GridView1.Columns("TELEFONO").Visible = True

            GridView1.Columns("NUMEROSOLICITUD").Visible = True
            GridView1.Columns("IDLICENCIATIPO").Visible = True
            GridView1.Columns("SUBGRUPOFAMILIAENFERMEDAD").Visible = True

            GridView1.Columns("ESTADOPAGO").Visible = True
            GridView1.Columns("DECLARACION").Visible = True

            GridView1.Columns("DESCRIPCIONESTADOPAGO").Visible = False
            GridView1.Columns("DESCRIPCIONDECLARACION").Visible = False
        End If
    End Sub

    Private Sub RepositoryItemVista_Click(sender As Object, e As EventArgs) Handles RepositoryItemVista.Click
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
            ListarDescansoMedico()
        End If
    End Sub
End Class