Imports MC.Data
Imports MC.Framework
Public Class SuspensionPerfectaEmpleadoList
    Dim bsSituacionLaboralEmpleado As New BindingSource
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ID", "IDEMPLEADO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MATRICULA", "MATRICULA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DOCUMENTO", "NUMERODOCUMENTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBRE", "NOMBRES", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "APELLIDO PATERNO", "APELLIDOPATERNO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False) '''NO BORRAR ESTO SI SE VA A USAR
        ControlesDevExpress.InitGridViewColumn(GridView1, "APELLIDO MATERNO", "APELLIDOMATERNO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO ACTUAL EMPLEADO", "ESTADOEMPLEADO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "SITUACION ACTUAL", "SITUACIONLABORAL", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "PERIODO FECHA", "PERIODOFECHASITUACIONLABORAL", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO", "CARGO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridView1
            .Columns("NOMBRES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOPATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOMATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("ESTADOEMPLEADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("SITUACIONLABORAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CARGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        Refrescar()

    End Sub
    Public Sub Refrescar()
        Try
            btnExportar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(RibbonControl, dtAccionesUsuario)

            Me.GridControl1.DataSource = bsSituacionLaboralEmpleado
            bsSituacionLaboralEmpleado.DataSource = SuspencionPerfectaDAO.GetSituacionLaboralEmpleadoList()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub

    Private Sub SuspensionPefectaEmpleadoList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnExportar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportar.ItemClick
        If GridView1.RowCount > 0 Then
            Try
                Dim ruta As String
                ruta = My.Application.Info.DirectoryPath() + "\Historial_Suspencion_Perfecta.xlsx"
                GridControl1.ExportToXlsx(ruta)
                Process.Start(ruta)
            Catch ex As Exception
                MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
            End Try
        End If
    End Sub
End Class