Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework
Public Class ReporteDescuentoReintegroPrestamoList
    Dim bsPrestamosDescuentos As New BindingSource
    Dim DescuentoReintegroDAO As New DescuentoReintegroDAO
    Sub New()

        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DESCUENTO REINTEGRO", "DESCUENTOREINTEGRO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DOCUMENTO", "NUMERODOCUMENTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "F. EMISIÓN-DEPÓSITO", "FECHAEMISION", 120, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MONTO", "MONTO", 80, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBRE COLABORADOR", "NOMBRECOLABORADOR", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DOCUMENTO COLABORADOR", "NUMERODOCUMENTOCOLABORADOR", 150, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO COLABORADOR", "CARGOCOLABORADOR", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO DESCUENTO", "TIPODESCUENTO", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DESCUENTO MOTIVO", "DESCUENTOMOTIVO", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)


        GridView1.Columns("MONTO").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        GridView1.Columns("NUMERODOCUMENTO").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        With GridView1
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAEMISION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("MONTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTOCOLABORADOR").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CARGOCOLABORADOR").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("DESCUENTOREINTEGRO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("TIPODESCUENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("DESCUENTOMOTIVO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        btnFechaInical.EditValue = DateTime.Now.Date
        btnFechaFinal.EditValue = DateTime.Now.Date.AddDays(+30)

        AddHandler btnFechaFinal.EditValueChanged, AddressOf Buscar
        AddHandler btnFechaInical.EditValueChanged, AddressOf Buscar
        AddHandler btnBuscar.ItemClick, AddressOf Buscar

        Me.GridControl1.DataSource = bsPrestamosDescuentos
        Buscar()

    End Sub


    Public Sub Buscar()
        Try

            'btnGenerarRenovacion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'Dim dtAccionesUsuario As DataTable
            'dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            'Tools.AccionesUsuarioRibbon(RibbonControl, dtAccionesUsuario)

            bsPrestamosDescuentos.DataSource = DescuentoReintegroDAO.GetDescuentoReintegroReporteGeneralList(btnFechaInical.EditValue, btnFechaFinal.EditValue)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBuscar.ItemClick
        Buscar()
    End Sub

    Private Sub ReporteDescuentoReintegroPrestamoList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub
End Class