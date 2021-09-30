Imports MC.Data
Imports MC.Framework

Public Class PrestamosDepositoList

    Dim bsPrestamoDepositos As New BindingSource

    Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDPRESTAMO", "IDPRESTANO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO SOLICITUD", "NUMEROSOLICITUD", 140, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 220, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 300, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° CONVENIO", "BANCOCONVENIO", 100, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MATRICULA", "MATRICULA", 100, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DOCUMENTO", "NUMERODOCUMENTO", 100, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EMPLEADO", "EMPLEADO", 220, True)

        ControlesDevExpress.InitGridViewColumn(GridView1, "MONTO APROBADO", "MONTOAPROBADO", 120, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO PAGO", "TIPOPAGO", 100, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DES. GRATIFICACIÓN", "PORCENTAJEGRATIFICACIONDESCUENTO", 120, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO APROBADO RRHH", "ESTADOAPROBADORRHH", 140, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO ADRYAN", "ESTADOREGISTROADRYAN", 120, True)

        GridView1.Columns("MONTOAPROBADO").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        GridView1.Columns("PORCENTAJEGRATIFICACIONDESCUENTO").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far

        Me.GridControl1.DataSource = bsPrestamoDepositos
        refrescar()
    End Sub
    Private Sub inabilitarbotones()
        btnDeposito.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub
    Private Sub refrescar()
        inabilitarbotones()
        Try
            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(RibbonControl, dtAccionesUsuario)
            bsPrestamoDepositos.DataSource = PrestamoDAO.GetByAllPrestamosDepositos
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        refrescar()
    End Sub

    Private Sub btnDeposito_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeposito.ItemClick
        PrestamoDAO.IdPrestamo = GridView1.GetFocusedRowCellValue("IDPRESTAMO")

        If PrestamoDAO.IdPrestamo <> 0 Then
            Dim MiForm As New PrestamosDepositoDetails
            MiForm.btnRegistrar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Dim dtAccionesUsuarioDetalle As DataTable
            dtAccionesUsuarioDetalle = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, MiForm.Name)
            Tools.AccionesUsuarioRibbon(MiForm.RibbonControl, dtAccionesUsuarioDetalle)
            MiForm.ShowDialog()

            refrescar()
        End If
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        If btnDeposito.Visibility = DevExpress.XtraBars.BarItemVisibility.Always Then
            btnDeposito.PerformClick()
        End If
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub PrestamosDepositoList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

End Class