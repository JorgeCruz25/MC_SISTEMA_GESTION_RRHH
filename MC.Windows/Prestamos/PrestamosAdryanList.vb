Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Grid
Imports MC.Data
Imports MC.Framework
Public Class PrestamosAdryanList

    Dim PrestamosBE As New PrestamosBE

    Dim bsPrestamoAprobados As New BindingSource

    Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDPRESTAMO", "IDPRESTANO", 10, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO SOLICITUD", "NUMEROSOLICITUD", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA SOLICITUD", "FECHA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MATRICULA", "MATRICULA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DOCUMENTO", "NUMERODOCUMENTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EMPLEADO", "EMPLEADO", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        ControlesDevExpress.InitGridViewColumn(GridView1, "MONTO APROBADO", "MONTOAPROBADO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MEDIO DE PAGO", "MEDIOPAGO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO PAGO", "TIPOPAGO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MONTO DESCUENTO", "MONTODESCUENTO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DES. GRATIFICACIÓN", "PORCENTAJEGRATIFICACIONDESCUENTO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DES. VACACIONES", "MONTOVACACIONESDESCUENTO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DES. LIQUIDACIÓN", "MONTOLIQUIDACIONDESCUENTO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA DEPOSITO", "FECHADEPOSITO", 120, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO APROBADO RRHH", "ESTADOAPROBADORRHH", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO DEPÓSITO", "ESTADODEPOSITO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO APROBADO RRHH", "DESCRIPCIONESTADOAPROBADORRHH", 140, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO DEPOSITO", "DESCRIPCIONESTADODEPOSITO", 120, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO ADRYAN", "ESTADOREGISTROADRYAN", 120, True, ControlesDevExpress.eGridViewFormato.Checked, True)

        ControlesDevExpress.InitGridViewColumn(GridView1, "IDEMPLEADO", "IDEMPLEADO", 120, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        GridView1.Columns("MONTOAPROBADO").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        GridView1.Columns("PORCENTAJEGRATIFICACIONDESCUENTO").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        GridView1.Columns("MONTODESCUENTO").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridControl1.DataSource = bsPrestamoAprobados

        refrescar()
    End Sub

    Private Sub btnRegistrar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnRegistrar.ItemClick
        Dim view As GridView = TryCast(GridControl1.FocusedView, GridView)
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()

        If MessageBox.Show("¿Esta seguro de registrar el préstamo?", "Registro de préstamo adryan", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            For i As Integer = 0 To GridView1.RowCount - 1
                PrestamosBE.EstadoRegistroAdryan = view.GetRowCellValue(i, "ESTADOREGISTROADRYAN")
                PrestamosBE.IdPrestamos = view.GetRowCellValue(i, "IDPRESTAMO")

                If PrestamosBE.EstadoRegistroAdryan Then
                    PrestamoDAO.UpdateEstadoRegistroAdryan(PrestamosBE, BDCentralDAO.UsuarioBE.IDUsuario)
                End If
            Next
            refrescar()
        End If
    End Sub

    Private Sub refrescar()
        Try
            btnRegistrar.Visibility = BarItemVisibility.Never
            btnHistorialEmpleado.Visibility = BarItemVisibility.Never
            btnExportar.Visibility = BarItemVisibility.Never
            GridView1.Columns.Item("ESTADOREGISTROADRYAN").Visible = False
            Dim dtAccionesbutton As DataTable
            dtAccionesbutton = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(Ribbon, dtAccionesbutton)

            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioGrid(GridView1, dtAccionesUsuario)

            bsPrestamoAprobados.DataSource = PrestamoDAO.GetByAllPrestamosAprobados
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnRefrescar.ItemClick
        refrescar()
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub PrestamosAdryanList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub btnExportar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnExportar.ItemClick
        If GridView1.RowCount > 0 Then
            GridView1.Columns("DESCRIPCIONESTADOAPROBADORRHH").Visible = True
            GridView1.Columns("DESCRIPCIONESTADODEPOSITO").Visible = True
            GridView1.Columns("ESTADOAPROBADORRHH").Visible = False
            GridView1.Columns("ESTADODEPOSITO").Visible = False
            GridView1.Columns("ESTADOREGISTROADRYAN").Visible = False
            Try
                Dim ruta As String
                ruta = My.Application.Info.DirectoryPath() + "\SolicitudesPrestamos.xlsx"
                GridControl1.ExportToXlsx(ruta)
                Process.Start(ruta)

            Catch ex As Exception
                MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
            End Try
            GridView1.Columns("ESTADOREGISTROADRYAN").Visible = True
            GridView1.Columns("ESTADODEPOSITO").Visible = True
            GridView1.Columns("ESTADOAPROBADORRHH").Visible = True
            GridView1.Columns("DESCRIPCIONESTADODEPOSITO").Visible = False
            GridView1.Columns("ESTADODEPOSITO").Visible = True
            GridView1.Columns("DESCRIPCIONESTADOAPROBADORRHH").Visible = False
        End If
    End Sub
    Private Sub btnHistorialEmpleado_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnHistorialEmpleado.ItemClick
        Dim idempleado = GridView1.GetFocusedRowCellValue("IDEMPLEADO")
        BDAccionPersonalDAO.IdEmpleado = idempleado
        If BDAccionPersonalDAO.IdEmpleado <> 0 Then
            Dim MiForm As New EmpleadoHistorial

            Nombre = GridView1.GetFocusedRowCellValue("EMPLEADO")
            NumeroDocumento = GridView1.GetFocusedRowCellValue("NUMERODOCUMENTO")

            NombreLog = Me.Text ' formulario , reporte,
            DetalleLog = "HISTORIAL EMPLEADO " & Nombre & " CON NUMERO DE DOC. " & NumeroDocumento ' acción: impresión, exportar, tb poner filtros , lo que se
            BDCentralDAO.AccesoLogIns(IDSistema, BDCentralDAO.UsuarioBE.IDUsuario, DetalleLog, NombreLog)

            MiForm.ShowDialog()
        End If
    End Sub


End Class