Imports MC.Data
Imports MC.Framework
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraTab
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraBars

Public Class BonoAntiguedadList
    Dim BonoExtraAntiguedadBE As New BonoExtraAntiguedadBE
    Dim bsBonoExtraxAntiguedad As New BindingSource
    Sub New()

        InitializeComponent()


        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True
        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDEMPLEADO", "IDEMPLEADO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDLOCAL", "IDLOCAL", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDCARGO", "IDCARGO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBRE EMPLEADO", "NOMBRES", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "APELLIDO PATERNO", "APELLIDOPATERNO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "APELLIDO MATERNO", "APELLIDOMATERNO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DNI EMPLEADO", "DNI", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO EMPLEADO", "CARGOEMPLEADO", 130, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "INGRESO CORPORATIVO", "FECHAINGRESOCORPORATIVO", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIEMPO SERVICIO", "ANIOSLABARANDO", 140, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MONTO BENEFICIO", "MONTOBENEFICIOHASTA", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MONTO EXTRA", "MONTOEXTRA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MONTO TOTAL", "MONTOTOTAL", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO BENEFICIO", "ESTADOBENEFICIO", 130, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO APROBADO", "ESTADOAPROBADO", 130, True, ControlesDevExpress.eGridViewFormato.Checked, True)
        With GridView1
            '.Columns("NOMBREEMPLEADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            '.Columns("DNIEMPLEADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            '.Columns("CARGOEMPLEADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            '.Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            '.Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            '.Columns("FECHAINICIOLOCAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            '.Columns("FECHAINICIOCORPORATIVO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            '.Columns("MONTOCORRESPONDIENTE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            '.Columns("MONTOOTORDAGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            '.Columns("MONTOEXTRA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            '.Columns("MONTOFINAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            '.Columns("ESTADOBENEFICIO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        GridView1.Columns(0).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(1).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(2).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(3).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(4).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(5).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(6).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(7).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridControl1.DataSource = bsBonoExtraxAntiguedad
        Refrescar()
    End Sub
    Private Sub Refrescar()
        Try
            bsBonoExtraxAntiguedad.DataSource = BonoExtraDAO.BonoExtraBonoAntiguedadListAll()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub GridView1_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView1.RowUpdated
        Cursor = Cursors.WaitCursor

        With BonoExtraAntiguedadBE
            '.IdBonoExtraSolicitud = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDASIGNACIONHIJO")
            '.MontoAprobado = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "MONTOAPROBAD")
            'If .MontoAprobado = "" Then
            '    Exit Sub
            'End If
            'BonoExtraDAO.BonoExtraListAllById(BonoExtraBE)
        End With
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnAprobar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAprobar.ItemClick
        Dim view As GridView = TryCast(GridControl1.FocusedView, GridView)
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()
        If MessageBox.Show("¿Esta seguro de aprobar los Bonos por antiguedad?", "Aprobar Bonos por antiguedad", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            For i As Integer = 0 To GridView1.RowCount - 1
                Dim VALOR As String = view.GetRowCellValue(i, "ESTADOBENEFICIO")
                If view.GetRowCellValue(i, "ESTADOAPROBADO") IsNot DBNull.Value And (view.GetRowCellValue(i, "ESTADOBENEFICIO") = "No Asignado" Or view.GetRowCellValue(i, "ESTADOBENEFICIO") = "Por Actualiza") Then
                    Dim estadoaprobado As Boolean = view.GetRowCellValue(i, "ESTADOAPROBADO")
                    If estadoaprobado Then
                        With BonoExtraAntiguedadBE
                            .IdEmpleado = view.GetRowCellValue(i, "IDEMPLEADO")
                            .IdLocal = view.GetRowCellValue(i, "IDLOCAL")
                            .IdArea = view.GetRowCellValue(i, "IDCARGO")
                            .FechaIngresoCorporativo = view.GetRowCellValue(i, "FECHAINGRESOCORPORATIVO")
                            .MontoBeneficio = view.GetRowCellValue(i, "MONTOBENEFICIOHASTA")
                            If view.GetRowCellValue(i, "MONTOEXTRA") IsNot DBNull.Value Then
                                .MontoExtra = view.GetRowCellValue(i, "MONTOEXTRA")
                            Else
                                .MontoExtra = 0
                            End If
                            .MontoTotal = (.MontoBeneficio + .MontoExtra)
                        End With
                        BonoExtraDAO.BonoExtraBonoAntiguedadIns(BonoExtraAntiguedadBE)
                    End If
                End If
            Next
            Refrescar()
        End If
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub

    Private Sub BonoAntiguedadList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub
End Class