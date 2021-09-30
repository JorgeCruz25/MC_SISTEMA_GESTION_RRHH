Imports DevExpress.XtraEditors.Controls
Imports MC.Data
Imports MC.Framework
Public Class PeriodoRenovacionList
    Dim bsPeriodoRenovaciones As New BindingSource
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True
        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ID. PERIODO", "IDPERIODORENOVACION", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO PERIODO", "TIPOPERIODO", 110, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA DESDE", "FECHADESDE", 110, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA HASTA", "FECHAHASTA", 110, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "USUARIO REGISTRO", "USUARIOREGISTRO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA REGISTRO", "FECHAREGISTRO", 120, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "USUARIO VALIDADO", "USUARIOVALIDADO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA VALIDADO", "FECHAVALIDADO", 120, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO VALIDADO", "ESTADOVALIDADO", 120, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        With GridView1
            .Columns("IDPERIODORENOVACION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHADESDE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAHASTA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("USUARIOREGISTRO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAREGISTRO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("USUARIOVALIDADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAVALIDADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("ESTADOVALIDADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        Refrescar()
    End Sub
    Private Sub Refrescar()
        Try
            bsPeriodoRenovaciones.DataSource = BDAccionPersonalDAO.GetPeriodoRenovacionList()

            Me.GridControl1.DataSource = bsPeriodoRenovaciones
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAsignarPeriodo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAsignarPeriodo.ItemClick
        'BDAccionPersonalDAO.IdPeriodoRenovacion = GridView1.GetFocusedRowCellValue("IDPERIODORENOVACION")
        BDAccionPersonalDAO.Accion = 1 ' Acción 1 es asignar un nuevo periodo
        BDAccionPersonalDAO.IdPeriodoRenovacion = 0
        Dim MiForm As New PeriodoRenovacionDetails
        MiForm.ShowDialog()
        Refrescar()
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub PeriodoRenovacionList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub

    Private Sub RepositoryItemEditar_Click(sender As Object, e As EventArgs) Handles RepositoryItemEditar.Click
        If GridView1.GetFocusedRowCellValue("ESTADOVALIDADO") Then
            MessageBox.Show("El periodo ya se encuentra validado, No podra realizar modificaciones")
        Else
            BDAccionPersonalDAO.IdPeriodoRenovacion = GridView1.GetFocusedRowCellValue("IDPERIODORENOVACION")
            Dim MiForm As New PeriodoRenovacionDetails
            MiForm.ShowDialog()
            Refrescar()
        End If
    End Sub

    Private Sub RepositoryItemValidar_Click(sender As Object, e As EventArgs) Handles RepositoryItemValidar.Click
        Dim IDPERIODORENOVACION As Integer = GridView1.GetFocusedRowCellValue("IDPERIODORENOVACION")
        BDAccionPersonalDAO.Accion = 2 ' Acción 2 es editar un periodo
        If GridView1.GetFocusedRowCellValue("ESTADOVALIDADO") Then
            MessageBox.Show("El periodo N° " & IDPERIODORENOVACION & " ya se encuentra validado")
        Else
            If MessageBox.Show("Esta seguro de validar el periodo N° " & IDPERIODORENOVACION, "vALIDACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                BDAccionPersonalDAO.validarPeriodoRenovacion(IDPERIODORENOVACION, BDCentralDAO.UsuarioBE.IDUsuario)
            End If
        End If
        Refrescar()
    End Sub
End Class