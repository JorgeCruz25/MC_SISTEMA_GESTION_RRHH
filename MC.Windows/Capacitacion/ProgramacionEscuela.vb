Imports MC.Data
Imports MC.Framework
Public Class ProgramacionEscuela
    Dim bsCursos As New BindingSource
    Sub New()
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True
        Me.Text = "LISTADO DE ESCUELAS"
        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDCAPACITACIONESCUELA", "IDCAPACITACIONESCUELA", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO ESCUELA", "NUMEROESCUELA", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO ESCUELA", "TIPOESCUELA", 240, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOTA APROBATORIA", "NOTAAPROBATORIA", 170, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA REGISTRO", "FECHAREGISTRO", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBREUSUARIO", "NOMBREUSUARIO", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridView1
            .Columns("NUMEROESCUELA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("TIPOESCUELA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOTAAPROBATORIA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAREGISTRO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOMBREUSUARIO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        Refrescar()
    End Sub
    Private Sub Refrescar()
        Try
            'inabilitarbotones()
            'Dim dtAccionesUsuario As DataTable
            'dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            'Tools.AccionesUsuarioRibbon(RibbonControl, dtAccionesUsuario)
            bsCursos.DataSource = CapacitacionDAO.ProgramacionCapacitacionEscuelaList()
            Me.GridControl1.DataSource = bsCursos
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick
        CapacitacionDAO.IdProgramacionEscuela = 0
        Dim MiForm As New ProgramacionEscuelaDetails
        MiForm.ShowDialog()
        Refrescar()
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub

    Private Sub RepositoryItemCursos_Click(sender As Object, e As EventArgs) Handles RepositoryItemCursos.Click
        If GridView1.GetFocusedRowCellValue("IDCAPACITACIONESCUELA") > 0 Then
            CapacitacionDAO.IdProgramacionEscuela = GridView1.GetFocusedRowCellValue("IDCAPACITACIONESCUELA")
            Dim MiForm As New ProgramacionCapacitacion
            MiForm.txtNumeroCapacitacion.EditValue = GridView1.GetFocusedRowCellValue("NUMEROESCUELA")
            MiForm.txtTipoEscuela.EditValue = GridView1.GetFocusedRowCellValue("TIPOESCUELA")
            MiForm.ShowDialog()
            Refrescar()
        End If
    End Sub

    Private Sub ProgramacionEscuela_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub RepositoryItemTrabajadores_Click(sender As Object, e As EventArgs) Handles RepositoryItemTrabajadores.Click
        If GridView1.GetFocusedRowCellValue("IDCAPACITACIONESCUELA") > 0 Then
            CapacitacionDAO.IdProgramacionEscuela = GridView1.GetFocusedRowCellValue("IDCAPACITACIONESCUELA")
            Dim MiForm As New CapacitacionTrabajador
            MiForm.txtNumeroCapacitacion.EditValue = GridView1.GetFocusedRowCellValue("NUMEROESCUELA")
            MiForm.txtTipoEscuela.EditValue = GridView1.GetFocusedRowCellValue("TIPOESCUELA")
            MiForm.ShowDialog()
        End If
    End Sub
End Class