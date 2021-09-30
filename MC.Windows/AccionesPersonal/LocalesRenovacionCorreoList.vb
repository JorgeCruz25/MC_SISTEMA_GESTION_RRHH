Imports MC.Data
Imports MC.Framework

Public Class LocalesRenovacionCorreoList
    Dim bsRenovacionesLocales As New BindingSource
    Dim PERIODOTIPO As Integer
    Sub New()

        InitializeComponent()
        CargarTipoPeriodo()


        'Me.StartPosition = FormStartPosition.CenterScreen
        'Me.Icon = MEDesktop.Icon
        'Me.KeyPreview = True
        'CargarTipoPeriodo()
        'ControlesDevExpress.InitRibbonControl(RibbonControl)

        'ControlesDevExpress.InitGridControl(GridControl1)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "IDLOCAL", "IDLOCAL", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "N° RUC", "IDTRIBUTARIO", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "DIRECCIÓN", "DIRECCION", 280, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "SUPERVISOR", "SUPERVISOR", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        'With GridView1
        '    .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '    .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '    .Columns("IDTRIBUTARIO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '    .Columns("SUPERVISOR").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        'End With
        ''btnFechaInicial.EditValue = DateTime.Now.Date.AddDays(-30)
        ''btnFechaFinal.EditValue = DateTime.Now.Date

        ''AddHandler btnFechaFinal.EditValueChanged, AddressOf Refrescar
        ''Me.GridControl1.DataSource = bsRenovacionesLocales
        'Refrescar()
    End Sub
    Private Sub CargarTipoPeriodo()
        ControlesDevExpress.InitGridViewColumn(GridViewPeriodo, "ID", "IDTIPOPERIODO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewPeriodo, "DESCRIPCION", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewPeriodo
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        RepositoryItemGridLookUpEdit1.DataSource = BDAccionPersonalDAO.GetTipoPeriodoRenovacionList
        RepositoryItemGridLookUpEdit1.DisplayMember = "DESCRIPCION"
        RepositoryItemGridLookUpEdit1.ValueMember = "IDTIPOPERIODO"
        RepositoryItemGridLookUpEdit1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub LocalesRenovacionCorreoList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub Refrescar(PERIODOTIPO)
        'Try
        '    bsRenovacionesLocales.DataSource = BDAccionPersonalDAO.GetLocalesPorRenovarContratoList(btnFechaInicial.EditValue, btnFechaFinal.EditValue)
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        Try
            bsRenovacionesLocales.DataSource = BDAccionPersonalDAO.GetLocalesPorRenovarContratoList(PERIODOTIPO)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    'Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
    '    Refrescar()
    'End Sub

    Private Sub RepositoryItemVistaEmpleados_Click(sender As Object, e As EventArgs) Handles RepositoryItemVistaEmpleados.Click
        Dim razoncomercial As String = GridView1.GetFocusedRowCellValue("RAZONCOMERCIAL")
        BDAccionPersonalDAO.IdLocal = GridView1.GetFocusedRowCellValue("IDLOCAL")
        'BDAccionPersonalDAO.FechaDesde = btnFechaInicial.EditValue
        'BDAccionPersonalDAO.FechaHasta = btnFechaFinal.EditValue
        Dim MiForm As New VistaEmpleadosxRenovar
        MiForm.GroupControl1.Text = razoncomercial
        MiForm.ShowDialog()
    End Sub

    Private Sub RepositoryItemGridLookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemGridLookUpEdit1.EditValueChanged
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDLOCAL", "IDLOCAL", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° RUC", "IDTRIBUTARIO", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DIRECCIÓN", "DIRECCION", 280, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "SUPERVISOR", "SUPERVISOR", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridView1
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("IDTRIBUTARIO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("SUPERVISOR").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        'btnFechaInicial.EditValue = DateTime.Now.Date.AddDays(-30)
        'btnFechaFinal.EditValue = DateTime.Now.Date

        'AddHandler btnFechaFinal.EditValueChanged, AddressOf Refrescar
        'Me.GridControl1.DataSource = bsRenovacionesLocales
        Refrescar(slePeriodo.EditValue)
    End Sub
End Class