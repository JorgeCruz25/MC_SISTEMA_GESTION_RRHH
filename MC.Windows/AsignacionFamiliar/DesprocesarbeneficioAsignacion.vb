Imports MC.Framework
Imports MC.Data
Public Class DesprocesarbeneficioAsignacion
    Dim bsHijos As New BindingSource
    Dim EmpleadoDerechoHabienteBE As New EmpleadoDerechoHabienteBE
    Sub New()

        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitGridControl(GridControl1)

        ControlesDevExpress.InitGridViewColumn(GridView1, "ID.", "IDFAMILIAHIJO", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "SECUENCIA HIJO", "SECUENCIAHIJO", 120, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO DOCUMENTO", "TIPODOCUMENTO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DOCUMENTO", "NUMERODOCUMENTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "APELLIDO PATERNO", "APELLIDOPATERNO", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "APELLIDO MATERNO", "APELLIDOMATERNO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBRES", "NOMBRES", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA NACIMIENTO", "FECHANACIMIENTO", 130, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EDAD", "EDAD", 130, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDEMPLEADO", "IDEMPLEADO", 130, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CODIGOUNICO", "CODIGOUNICO", 130, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ASIGNACIONFAMILIAR", "ASIGNACIONFAMILIAR", 130, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridView1
            .Columns("IDFAMILIAHIJO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("SECUENCIAHIJO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("TIPODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOPATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOMATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOMBRES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHANACIMIENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("EDAD").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        Listado()
    End Sub
    Private Sub Listado()
        Try
            bsHijos.DataSource = BDAccionPersonalDAO.ListadoHijosxEmpleado(BDAccionPersonalDAO.IdEmpleado)
            Me.GridControl1.DataSource = bsHijos
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnDesprocesarAsignacion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDesprocesarAsignacion.ItemClick
        Dim AsignacionFamiliar As Int32 = If(GridView1.GetRowCellValue(0, "ASIGNACIONFAMILIAR") = False, 0, 1)
        If AsignacionFamiliar = 0 Then
            MessageBox.Show("El empleado no cuenta con beneficio de Asignación Familiar", "Quitar Beneficio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            If MessageBox.Show("Esta seguro de quitar el beneficio de Asignación Familiar", "Quitar Beneficio", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Try
                    'REGISTRA EN ADRYAN LA ASIGNACION FAMILIAR
                    EmpleadoDerechoHabienteBE.CODIGOUNICO = GridView1.GetRowCellValue(0, "CODIGOUNICO")
                    EmpleadoDerechoHabienteBE.ESTADOASIGNACIONBENEFICIO = 0
                    If BDAccionPersonalDAO.AsignacionFamiliarAdryan(EmpleadoDerechoHabienteBE, BDCentralDAO.UsuarioBE.Usuario) Then
                        If BDAccionPersonalDAO.QuitarAsignacionFamiliarEmpleadoId(BDAccionPersonalDAO.IdEmpleado, 0, BDCentralDAO.UsuarioBE.IDUsuario) Then
                            MessageBox.Show("Registro Exitoso", "Quitar Beneficio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()
                        Else
                            MessageBox.Show("Problemas con conexion MC_CENTRAL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    Else
                        MessageBox.Show("Problemas con conexion ADRYAN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub
End Class