Imports MC.Data
Imports MC.Framework
Public Class VistaEmpleadosxRenovar

    Dim bsListadoEmpleados As New BindingSource
    Sub New()

        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDEMPLEADO", "IDEMPLEADO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EMPLEADO", "NOMBRE", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DOCUMENTO", "DNI", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA FINAL CONTRATO", "FECHAFINALCONTRATO", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridView1
            .Columns("NOMBRE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("DNI").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAFINALCONTRATO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        'ListarEmpleadosxLocal()

    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub
    'Private Sub ListarEmpleadosxLocal()
    '    Try
    '        bsListadoEmpleados.DataSource = BDAccionPersonalDAO.GetEmpleadoxLocalRenovacionesList(BDAccionPersonalDAO.IdLocal, BDAccionPersonalDAO.FechaDesde, BDAccionPersonalDAO.FechaHasta)
    '        GridControl1.DataSource = bsListadoEmpleados
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

End Class