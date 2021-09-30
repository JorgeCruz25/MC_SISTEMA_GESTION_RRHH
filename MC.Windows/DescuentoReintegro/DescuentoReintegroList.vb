Imports DevExpress.XtraBars
Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework
Public Class DescuentoReintegroList
    Dim bsDescuentoReintegro As New BindingSource
    Dim DescuentoReintegroDAO As New DescuentoReintegroDAO
    Dim idperiodo As Integer

    Sub New()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = False

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDDESCUENTOREINTEGRO", "IDDESCUENTO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DESCUENTO", "ESTADODESCUENTO", 80, True, ControlesDevExpress.eGridViewFormato.Checked, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DECUENTO-REINTEGRO", "DESCUENTOREINTEGRO", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
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
            .Columns("IDDESCUENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
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


        ControlesDevExpress.InitGridViewColumn(RepositoryItemGridLookUpEditPeriodoView, "IDDESCUENTOPERIODO", "IDDESCUENTOPERIODO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(RepositoryItemGridLookUpEditPeriodoView, "DECUENTO-RANGOFECHAS", "RANGOFECHAS", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With RepositoryItemGridLookUpEditPeriodoView
            .Columns("IDDESCUENTOPERIODO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RANGOFECHAS").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        RepositoryItemGridLookUpEditPeriodo.DataSource = DescuentoReintegroDAO.GetDescuentoReintegroPeriodoList
        RepositoryItemGridLookUpEditPeriodo.DisplayMember = "RANGOFECHAS"
        RepositoryItemGridLookUpEditPeriodo.ValueMember = "IDDESCUENTOPERIODO"
        Refrescar()
    End Sub
    Public Sub Refrescar()
        Try

            btnExportar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(RibbonControl, dtAccionesUsuario)
            Me.GridControl1.DataSource = bsDescuentoReintegro
            bsDescuentoReintegro.DataSource = DescuentoReintegroDAO.GetDescuentoReintegroList(idperiodo, 1) '1=Lista todos a los que aun no se les a asignado el descuento
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DescuentoReintegroList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub slePeriodo_EditValueChanged(sender As Object, e As EventArgs) Handles slePeriodo.EditValueChanged
        idperiodo = slePeriodo.EditValue
        Refrescar()
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnRefrescar.ItemClick
        idperiodo = slePeriodo.EditValue
        If idperiodo > 0 Then
            Refrescar()
        End If
    End Sub

    Private Sub btnProcesar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnProcesar.ItemClick
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()
        GridView1.ClearColumnsFilter()
        GridView1.FindFilterText = ""

        If GridView1.RowCount > 0 Then
            If MessageBox.Show("Esta seguro de procesar los descuentos", "Procesar descuento", MessageBoxButtons.YesNo, MessageBoxIcon.Information) Then
                For i As Integer = 0 To GridView1.RowCount - 1
                    Dim IDDESCUENTO As Integer
                    Dim ESTADO As Boolean
                    ESTADO = If(GridView1.GetRowCellValue(i, "ESTADODESCUENTO").ToString = "False", 0, 1)
                    IDDESCUENTO = (GridView1.GetRowCellValue(i, "IDDESCUENTO"))

                    If ESTADO Then
                        DescuentoReintegroDAO.ProcesarDescuento(IDDESCUENTO, BDCentralDAO.UsuarioBE.IDUsuario)
                    End If
                Next
                Refrescar()
            Else
                MessageBox.Show("No existe ningun listado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
End Class