Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework
Public Class DescuentoReintegroHistorialList
    Dim bsLicencias As New BindingSource
    Dim bsDescuentoReintegro As New BindingSource
    Dim DescuentoReintegroDAO As New DescuentoReintegroDAO
    Dim idperiodo As Integer

    Sub New()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDDESCUENTOREINTEGRO", "IDDESCUENTOREINTEGRO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DECUENTO-REINTEGRO", "DESCUENTOREINTEGRO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False) '''NO BORRAR ESTO SI SE VA A USAR
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA EMISION", "FECHAEMISION", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RESPONSABLE", "NOMBRECOLABORADOR", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO", "CARGOCOLABORADOR", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO DESCUENTO", "TIPODESCUENTO", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MOTIVO DESCUENTO", "DESCUENTOMOTIVO", 160, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DOCUMENTO", "NUMERODOCUMENTO", 130, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MONTO", "MONTO", 90, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "OBSERVACIONES", "OBSERVACION", 230, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "AREA REGISTRO", "AREAPERIODO", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "USUARIO REGISTRO", "NOMBREUSUARIO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA REGISTRO", "FECHAREGISTRO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridView1
            .Columns("IDDESCUENTOREINTEGRO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("DESCUENTOREINTEGRO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAEMISION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOMBRECOLABORADOR").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CARGOCOLABORADOR").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("DESCUENTOMOTIVO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("MONTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("OBSERVACION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("AREAPERIODO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOMBREUSUARIO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAREGISTRO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With


        ControlesDevExpress.InitGridViewColumn(RepositoryItemGridLookUpEdit1View, "IDDESCUENTOPERIODO", "IDDESCUENTOPERIODO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(RepositoryItemGridLookUpEdit1View, "DECUENTO-RANGOFECHAS", "RANGOFECHAS", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With RepositoryItemGridLookUpEdit1View
            .Columns("IDDESCUENTOPERIODO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RANGOFECHAS").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        RepositoryItemGridLookUpEdit1.DataSource = DescuentoReintegroDAO.GetDescuentoReintegroPeriodoList
        RepositoryItemGridLookUpEdit1.DisplayMember = "RANGOFECHAS"
        RepositoryItemGridLookUpEdit1.ValueMember = "IDDESCUENTOPERIODO"
        cboPeriodo.Enabled = False
        dteFechaFin.Enabled = False
        dteFechaInicio.Enabled = False
        rboFechaEmision.Checked = True
        dteFechaInicio.EditValue = DateTime.Now.Date.AddDays(-30)
        dteFechaFin.EditValue = DateTime.Now.Date
        RefrescarFechaEmision()

    End Sub
    Private Sub RefrescarPeriodo()
        Try
            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(RibbonControl, dtAccionesUsuario)
            Me.GridControl1.DataSource = bsDescuentoReintegro
            bsDescuentoReintegro.DataSource = DescuentoReintegroDAO.GetDescuentoReintegroList(idperiodo, 2) '2=Lista todos aquellos que ya se les registro el descuento
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub RefrescarFechaEmision()
        Try
            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(RibbonControl, dtAccionesUsuario)
            Me.GridControl1.DataSource = bsDescuentoReintegro
            bsDescuentoReintegro.DataSource = DescuentoReintegroDAO.GetDescuentoReintegroFechaEmisionList(dteFechaInicio.EditValue, dteFechaFin.EditValue) '2=Lista todos aquellos que ya se les registro el descuento
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub rboFechaEmision_CheckedChanged(sender As Object, e As ItemClickEventArgs) Handles rboFechaEmision.CheckedChanged
        If rboFechaEmision.Checked Then
            dteFechaInicio.Enabled = True
            dteFechaFin.Enabled = True
            SlePeriodo.Enabled = False
            rboPeriodo.Checked = False
        End If
    End Sub

    Private Sub rboPeriodo_CheckedChanged(sender As Object, e As ItemClickEventArgs) Handles rboPeriodo.CheckedChanged
        If rboPeriodo.Checked Then
            dteFechaInicio.Enabled = False
            dteFechaFin.Enabled = False
            SlePeriodo.Enabled = True
            rboFechaEmision.Checked = False
        End If
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub DescuentoReintegroHistorialList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub btnBuscar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnBuscar.ItemClick
        If rboFechaEmision.Checked Then
            RefrescarFechaEmision()
        End If
        If rboPeriodo.Checked Then
            idperiodo = SlePeriodo.EditValue
            RefrescarPeriodo()
        End If

    End Sub
End Class