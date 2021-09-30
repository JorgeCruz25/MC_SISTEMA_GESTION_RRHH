
Imports MC.Data
Imports MC.Framework
Public Class CargaPlanillaEmpleado
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.WindowState = FormWindowState.Maximized
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'Dim dt As DataTable
        'dt =
        'CargarListadoPlanilla()
    End Sub
    Private Sub CargarListadoPlanilla()

    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnImportar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImportar.ItemClick
        OpenFileDialog1.Filter = "Excel |*.xlsx"
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            Dim path As String = OpenFileDialog1.FileName
            Try
                Dim workbook As Spire.Xls.Workbook = New Spire.Xls.Workbook
                workbook.LoadFromFile(path)
                Dim sheet As Spire.Xls.Worksheet = workbook.Worksheets(0)
                Me.GridControl1.DataSource = sheet.ExportDataTable
                Me.btnImportar.Enabled = False
            Catch ex As Exception
                MessageBox.Show("Error al importar Data", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub



    Private Sub btnGrabar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGrabar.ItemClick
        Dim dt As DataTable = GridControl1.DataSource
        If dt.Rows.Count > 0 Then
            If PlanillaDAO.InsertarPlanillaMasivo(dt) Then
                If PlanillaDAO.RegistraNumeroPlanillaDetalleMasivo(PlanillaDAO.IdPlanilla, BDCentralDAO.UsuarioBE.IDUsuario) Then
                    Me.Close()
                End If
                'PlanillaDAO.
            End If
        End If
    End Sub
    'For i As Integer = 0 To GridView1.RowCount - 1
    '    PlanillaBE.idPlanillaDetalle = GridView1.GetRowCellValue(i, "MATRICULA")
    '    PlanillaBE.NombreApellido = GridView1.GetRowCellValue(i, "")
    '    PlanillaBE.Matricula = GridView1.GetRowCellValue(i, "")
    '    Lista.Add(PlanillaBE)
    'Next
    Private Sub Insertar(dt)

    End Sub
End Class