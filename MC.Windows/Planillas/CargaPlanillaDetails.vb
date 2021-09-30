Imports MC.Data
Imports MC.Framework
Public Class CargaPlanillaDetails
    Dim bsConcepto As New BindingSource
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDPLANILLACONCEPTO", "IDPLANILLACONCEPTO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO", "ESTADO", 100, True, ControlesDevExpress.eGridViewFormato.Checked, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CONCEPTO", "DESCRIPCION", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridView1
            .Columns("ESTADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        Me.GridControl1.DataSource = bsConcepto


        If PlanillaDAO.IdPlanilla = 0 Then
            GridControl1.Visible = False
        Else
            sleMes.Enabled = False
            txtAnio.Enabled = False
            Refrescar()
        End If

        CargarDatos()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub Refrescar()
        Try
            bsConcepto.DataSource = PlanillaDAO.ConceptoPlanillaGetId(PlanillaDAO.IdPlanilla)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub CargarDatos()
        Dim dt As DataTable
        dt = PlanillaDAO.MesPlanillaList
        txtAnio.Text = dt.Rows(0)("ANIO")
        ControlesDevExpress.InitGridViewColumn(GridViewMes, "ID", "IDMES", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewMes, "MES", "MES", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewMes
            .Columns("MES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleMes.Properties.DataSource = dt
        sleMes.Properties.DisplayMember = "MES"
        sleMes.Properties.ValueMember = "IDMES"
        sleMes.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnGrabar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGrabar.ItemClick
        If PlanillaDAO.IdPlanilla = 0 Then
            If Validar() Then
                Dim planilla As String = txtAnio.Text + " - " + sleMes.Text
                If MessageBox.Show("Estas seguro de generar la planilla " & planilla, "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    PlanillaDAO.RegistrarPlanilla(txtAnio.Text, sleMes.EditValue, BDCentralDAO.UsuarioBE.IDUsuario)
                    Me.Close()
                End If
            End If
        Else
            If GridView1.RowCount > 0 Then
                For i As Int32 = 0 To GridView1.RowCount - 1
                    PlanillaDAO.ActualizaConceptoPlanilla(PlanillaDAO.IdPlanilla, GridView1.GetRowCellValue(i, "IDPLANILLACONCEPTO"), GridView1.GetRowCellValue(i, "ESTADO"), BDCentralDAO.UsuarioBE.IDUsuario)
                Next
                Me.Close()
            End If
        End If


    End Sub


    Private Function Validar() As Boolean
        Dim Result As Boolean = True

        DxErrorProvider1.ClearErrors()

        If sleMes.EditValue Is Nothing Or sleMes.EditValue = 0 Then
            DxErrorProvider1.SetError(sleMes, "Dato obligatorio")
            Result = False
        End If

        If txtAnio.Text = "" Then
            DxErrorProvider1.SetError(txtAnio, "Dato obligatorio")
            Result = False
        End If

        Return Result

    End Function

End Class