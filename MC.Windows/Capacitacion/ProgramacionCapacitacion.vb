Imports MC.Framework
Imports MC.Data
Public Class ProgramacionCapacitacion
    Dim bsCursos As New BindingSource
    Sub New()
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True
        Me.WindowState = FormWindowState.Maximized
        Me.txtNumeroCapacitacion.Enabled = False
        Me.txtTipoEscuela.Enabled = False
        Me.txtNumeroCapacitacion.Edit.Appearance.ForeColor = Color.Blue
        Me.txtTipoEscuela.Edit.Appearance.ForeColor = Color.Blue
        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDCAPACITACION", "IDCAPACITACION", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CURSO", "CURSO", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RESPONSABLE", "RESPONSABLE", 390, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MODALIDAD", "MODALIDAD", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO", "CAPACITACIONESTADO", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA REGISTRO", "FECHAREGISTRO", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "USUARIO REGISTRO", "USUARIOREGISTRO", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDCAPACITACIONESTADO", "IDCAPACITACIONESTADO", 150, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPOESCUELA", "TIPOESCUELA", 150, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMEROESCUELA", "NUMEROESCUELA", 150, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridView1
            .Columns("CURSO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RESPONSABLE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("MODALIDAD").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CAPACITACIONESTADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAREGISTRO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("USUARIOREGISTRO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        Refrescar()
    End Sub
    Private Sub Refrescar()
        Try
            inabilitarbotones()
            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(RibbonControl, dtAccionesUsuario)
            bsCursos.DataSource = CapacitacionDAO.ProgramacionCapacitacionListAll(CapacitacionDAO.IdProgramacionEscuela)
            Me.GridControl1.DataSource = bsCursos
        Catch ex As Exception

        End Try
    End Sub
    Private Sub inabilitarbotones()
        'btnNuevo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        'btnEditar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub
    'Private Sub ProgramacionCapacitacion_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    '    MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    'End Sub

    Private Sub btnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick
        CapacitacionDAO.IdCapacitacion = 0
        Dim MiForm As New ProgramacionCapacitacionDetails
        MiForm.btnTrabajador.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        MiForm.ShowDialog()
        Refrescar()
    End Sub

    Private Sub btnEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditar.ItemClick
        CapacitacionDAO.IdCapacitacion = GridView1.GetFocusedRowCellValue("IDCAPACITACION")
        If CapacitacionDAO.IdCapacitacion > 0 Then
            CapacitacionDAO.Flat = 1
            Dim MiForm As New ProgramacionCapacitacionDetails
            MiForm.btnCerrarCapacitacion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'MiForm.GridView1.Columns.Item("PROCESARCLASE").Visible = False

            If GridView1.GetFocusedRowCellValue("IDCAPACITACIONESTADO") <> 1 Then
                MiForm.btnGrabar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                MiForm.btnAsignar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                MiForm.sleCurso.Enabled = False
                MiForm.sleModalidad.Enabled = False
                MiForm.sleResponsable.Enabled = False
                MiForm.GridView1.Columns.Item("EDITAR").Visible = False
                If GridView1.GetFocusedRowCellValue("IDCAPACITACIONESTADO") = 3 Or GridView1.GetFocusedRowCellValue("IDCAPACITACIONESTADO") = 4 Then
                    MiForm.btnAnular.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    MiForm.btnNuevaClase.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    MiForm.btnTrabajador.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    MiForm.GridView1.Columns.Item("ANULAR").Visible = False
                End If
            End If
            MiForm.ShowDialog()
        End If
        Refrescar()
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        btnEditar.PerformClick()
    End Sub

    Private Sub RepositoryItemNotas_Click(sender As Object, e As EventArgs) Handles RepositoryItemNotas.Click
        If GridView1.GetFocusedRowCellValue("IDCAPACITACIONESTADO") <> 1 Then
            If GridView1.GetFocusedRowCellValue("IDCAPACITACION") > 0 Then
                CapacitacionDAO.IdCapacitacion = GridView1.GetFocusedRowCellValue("IDCAPACITACION")
                CapacitacionDAO.CapacitacionNotasIns(CapacitacionDAO.IdCapacitacion, BDCentralDAO.UsuarioBE.IDUsuario)
                Dim MiForm As New CapacitacionNota
                MiForm.txtTipoEscuela.Edit.Appearance.ForeColor = Color.Blue
                MiForm.txtNumeroEscuela.Edit.Appearance.ForeColor = Color.Blue
                MiForm.txtCurso.Edit.Appearance.ForeColor = Color.Blue
                MiForm.txtTipoEscuela.EditValue = GridView1.GetFocusedRowCellValue("TIPOESCUELA")
                MiForm.txtNumeroEscuela.EditValue = GridView1.GetFocusedRowCellValue("NUMEROESCUELA")
                MiForm.txtCurso.EditValue = GridView1.GetFocusedRowCellValue("CURSO")

                MiForm.btnImportar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                MiForm.ShowDialog()
            End If
        Else
            MessageBox.Show("No podra ingresar notas porque el curso aun esta en estado generado", "Mensaje Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Refrescar()
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub
End Class