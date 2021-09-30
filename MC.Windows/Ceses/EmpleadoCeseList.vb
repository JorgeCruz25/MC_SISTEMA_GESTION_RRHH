Imports MC.Data
Imports MC.Framework

Public Class EmpleadoCeseList

    Dim bsEmpleadoCese As New BindingSource

    Sub New()

        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDSOLICITUDCESE", "IDSOLICITUDCESE", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDEMPLEADO", "IDEMPLEADO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO CESE", "NUMEROSOLICITUDCESE", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA REGISTRO", "FECHA", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "SOLICITANTE", "SOLICITANTE", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EMPLEADO", "EMPLEADO", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DE IDENTIDAD", "DNI", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO", "CARGO", 160, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MOTIVO GENERAL", "MOTIVOGENERAL", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA FINAL CONTRATO", "FECHAFINALCONTRATO", 140, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "PERMANENCIA", "PERMANENCIA", 150, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "AMPLIACION", "MESAMPLIACION", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDESTADOPROCESO", "IDESTADOPROCESO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridView1
            .Columns("NUMEROSOLICITUDCESE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("SOLICITANTE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("EMPLEADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("DNI").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CARGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("MOTIVOGENERAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAFINALCONTRATO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("PERMANENCIA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("MESAMPLIACION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        Me.GridControl1.DataSource = bsEmpleadoCese
        Refrescar()
    End Sub

    Public Sub Refrescar()
        Try
            bsEmpleadoCese.DataSource = BDAccionPersonalDAO.GetEmpleadoCeseList()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEvaluarSolicitud_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEvaluarSolicitud.ItemClick
        BDAccionPersonalDAO.IdEmpleado = GridView1.GetFocusedRowCellValue("IDEMPLEADO")
        BDAccionPersonalDAO.IdSolicitudCese = GridView1.GetFocusedRowCellValue("IDSOLICITUDCESE")

        Dim MiForm As New EmpleadoCese
        MiForm.ShowDialog()

        Refrescar()

    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick

        BDAccionPersonalDAO.IdEmpleado = GridView1.GetFocusedRowCellValue("IDEMPLEADO")
        BDAccionPersonalDAO.IdSolicitudCese = GridView1.GetFocusedRowCellValue("IDSOLICITUDCESE")

        Dim MiForm As New EmpleadoCese
        MiForm.ShowDialog()

        Refrescar()
        'BDAccionPersonalDAO.IdSolicitudCese = GridView1.GetFocusedRowCellValue("IDSOLICITUDCESE")
        'BDAccionPersonalDAO.IdEmpleado = GridView1.GetFocusedRowCellValue("IDEMPLEADO")
        'Dim MiFom As New EmpleadoCeseDetails
        'MiFom.dtCartaNotariaPreAviso.Enabled = False
        'MiFom.dtCartaNotariaDespido.Enabled = False
        'MiFom.btnGuardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        'MiFom.btnAdjuntarCartaDespido.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        'MiFom.btnAdjuntarCartaPreAviso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        'MiFom.btnEnviarCartaDespido.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        'MiFom.btnEnviarLegal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        'MiFom.btnEnviarRrhh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        'MiFom.btnEnvioRegistroBaja.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        'MiFom.btnProcedeDespido.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        'MiFom.ShowDialog()
        'Refrescar()
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub EmpleadoCeseList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

End Class