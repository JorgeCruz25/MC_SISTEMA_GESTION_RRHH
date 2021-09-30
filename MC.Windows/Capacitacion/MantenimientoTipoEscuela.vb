Imports DevExpress.XtraBars
Imports MC.Data
Imports MC.Framework
Public Class MantenimientoTipoEscuela
    Dim bsTipoEscuela As New BindingSource
    Sub New()

        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterParent
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True
        Me.Text = "LISTADO TIPO DE ESCUELA"

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDCAPACITACIONTIPOESCUELA", "IDCAPACITACIONTIPOESCUELA", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO ESCUELA", "DESCRIPCION", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO", "ESTADO", 200, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "USUARIO REGISTRO", "NOMBREUSUARIO", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA REGISTRO", "FECHAREGISTRO", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridView1
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("ESTADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOMBREUSUARIO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAREGISTRO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        Refrescar()

    End Sub
    Private Sub Refrescar()
        Try
            'Dim dtAccionesUsuario As DataTable
            'dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            'Tools.AccionesUsuarioRibbon(RibbonControl, dtAccionesUsuario)
            bsTipoEscuela.DataSource = CapacitacionDAO.TipoEscuelaListAll()
            Me.GridControl1.DataSource = bsTipoEscuela
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MantenimientoTipoEscuela_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub btnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick

        Dim MiForm As New MantenimientoTipoEscuelaDetails
        CapacitacionDAO.IdCapacitacionTipoEscuela = 0
        MiForm.ShowDialog()
        Refrescar()
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        btnEditar.PerformClick()
    End Sub

    Private Sub btnEditar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnEditar.ItemClick
        If GridView1.GetFocusedRowCellValue("IDCAPACITACIONTIPOESCUELA") > 0 Then
            CapacitacionDAO.IdCapacitacionTipoEscuela = GridView1.GetFocusedRowCellValue("IDCAPACITACIONTIPOESCUELA")
            Dim MiForm As New MantenimientoTipoEscuelaDetails
            MiForm.ShowDialog()
            Refrescar()
        End If
    End Sub
End Class