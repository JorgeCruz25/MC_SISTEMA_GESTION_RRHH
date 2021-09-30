Imports MC.Data
Imports MC.Framework

Public Class CapacitacionTrabajador
    Dim bsEmpleados As New BindingSource
    Dim bsEmpleadosAsignados As New BindingSource
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()


        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)

        ControlesDevExpress.InitGridViewColumn(GridView1, "ID", "IDEMPLEADO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO", "ESTADO", 60, True, ControlesDevExpress.eGridViewFormato.Checked, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBRES", "NOMBRES", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "APELLIDOPATERNO", "APELLIDOPATERNO", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "APELLIDOMATERNO", "APELLIDOMATERNO", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERODOCUMENTO", "NUMERODOCUMENTO", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MATRICULA", "MATRICULA", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO", "CARGO", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        ControlesDevExpress.InitGridControl(GridControl2)
        ControlesDevExpress.InitGridViewColumn(GridView2, "ID", "IDEMPLEADO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView2, "ESTADO", "ESTADO", 60, True, ControlesDevExpress.eGridViewFormato.Checked, True)
        ControlesDevExpress.InitGridViewColumn(GridView2, "NOMBRES", "NOMBRES", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "APELLIDOPATERNO", "APELLIDOPATERNO", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "APELLIDOMATERNO", "APELLIDOMATERNO", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "NUMERODOCUMENTO", "NUMERODOCUMENTO", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "MATRICULA", "MATRICULA", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "RAZON COMERCIAL", "RAZONCOMERCIAL", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "RAZON SOCIAL", "RAZONSOCIAL", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "CARGO", "CARGO", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridView1
            .Columns("NOMBRES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOPATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOMATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("MATRICULA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CARGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        With GridView2
            .Columns("NOMBRES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOPATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOMATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("MATRICULA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CARGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        Refrescar()
    End Sub
    Private Sub Refrescar()
        Try
            bsEmpleados.DataSource = CapacitacionDAO.CapacitacionEmpleadoList(CapacitacionDAO.IdProgramacionEscuela)
            Me.GridControl1.DataSource = bsEmpleados
            bsEmpleadosAsignados.DataSource = CapacitacionDAO.CapacitacionEmpleadoAsignadosList(CapacitacionDAO.IdProgramacionEscuela)
            Me.GridControl2.DataSource = bsEmpleadosAsignados
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        If GridView1.RowCount > 0 Then
            Dim estadocpacitacion As Integer = CapacitacionDAO.ObtenerEstadoCapacitacion(CapacitacionDAO.IdCapacitacion)
            If estadocpacitacion = 3 Then
                MessageBox.Show("La capacitación se encuentra cerrada por lo cual ya no podra realizar la Asignación")
            ElseIf estadocpacitacion = 4 Then
                MessageBox.Show("La capacitación se encuentra anulada por lo cual ya no podra realizar la Asignación")
            Else
                For i As Integer = 0 To GridView1.RowCount - 1
                    If GridView1.GetRowCellValue(i, "ESTADO") = True Then
                        CapacitacionDAO.ProgramacionCapacitacionEmpleadoIns(CapacitacionDAO.IdProgramacionEscuela, GridView1.GetRowCellValue(i, "IDEMPLEADO"), BDCentralDAO.UsuarioBE.IDUsuario)
                        'CapacitacionDAO.ProgramacionCapacitacionAsistenciaIns(CapacitacionDAO.IdCapacitacionDetalle, GridView1.GetRowCellValue(i, "IDEMPLEADO"), BDCentralDAO.UsuarioBE.IDUsuario)
                        'CapacitacionDAO.CapacitacionNotasIns(CapacitacionDAO.IdCapacitacion, Matricula, Math.Round(Nota, 2), BDCentralDAO.UsuarioBE.IDUsuario)
                    End If
                Next
            End If



        End If
        Refrescar()
    End Sub

    Private Sub btnDesasignar_Click(sender As Object, e As EventArgs) Handles btnDesasignar.Click
        If GridView2.RowCount > 0 Then
            Dim estadocpacitacion As Integer = CapacitacionDAO.ObtenerEstadoCapacitacion(CapacitacionDAO.IdCapacitacion)
            If estadocpacitacion = 3 Then
                MessageBox.Show("La capacitación se encuentra cerrada por lo cual ya no podra realizar la Desasignación")
            ElseIf estadocpacitacion = 4 Then
                MessageBox.Show("La capacitación se encuentra anulada por lo cual ya no podra realizar la Desasignación")
            Else
                For i As Integer = 0 To GridView2.RowCount - 1
                    If GridView2.GetRowCellValue(i, "ESTADO") = True Then
                        CapacitacionDAO.ProgramacionCapacitacionEmpleadoDesasignar(CapacitacionDAO.IdProgramacionEscuela, GridView2.GetRowCellValue(i, "IDEMPLEADO"))

                    End If
                Next
            End If



        End If
        Refrescar()
    End Sub
End Class