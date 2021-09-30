Imports System.IO
Imports System.Text
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Base
Imports MC.Data
Imports MC.Framework
Imports Microsoft.Office.Interop
Imports Spire.Xls
Public Class CapacitacionAsistencia
    Dim bsAsistencias As New BindingSource
    Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterParent
        Me.WindowState = FormWindowState.Maximized
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True
        'CURSO
        ControlesDevExpress.InitRibbonControl(RibbonControl)



        Refrescar()

    End Sub
    Private Sub Refrescar()
        Try
            bsAsistencias.DataSource = CapacitacionDAO.ProgramacionCapacitacionAsistenciaList(CapacitacionDAO.IdCapacitacionDetalle)
            GridControl1.DataSource = bsAsistencias
        Catch ex As Exception

        End Try
    End Sub


    Private Sub CargarEstadoAsistencia()
        ControlesDevExpress.InitGridViewColumn(GridViewAsistencia, "ID", "IDASISTENCIAESTADO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewAsistencia, "DESCRIPCION", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewAsistencia
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        RepositoryItemGridLookUpEditAsistencia.DataSource = CapacitacionDAO.CapacitacionAsistenciaEstadoList
        RepositoryItemGridLookUpEditAsistencia.ValueMember = "IDASISTENCIAESTADO"
        RepositoryItemGridLookUpEditAsistencia.DisplayMember = "DESCRIPCION"
        RepositoryItemGridLookUpEditAsistencia.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub CapacitacionAsistencia_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarEstadoAsistencia()
    End Sub

    Private Sub GridView1_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView1.RowUpdated
        Dim estadocpacitacion As Integer = CapacitacionDAO.ObtenerEstadoCapacitacion(CapacitacionDAO.IdCapacitacion)
        If estadocpacitacion = 1 Then
            MessageBox.Show("Para poder registrar las asistencias, la pacitación tiene que estar en estado Asignado")
        ElseIf estadocpacitacion = 3 Then
            MessageBox.Show("No podra realizar las asistencias porque la capacitación ya se encuentra Cerrada")
        ElseIf estadocpacitacion = 4 Then
            MessageBox.Show("No podra realizarlas asistencias porque la capacitación ya se encuentra Anulada")
        ElseIf estadocpacitacion = 2 Then
            Cursor = Cursors.WaitCursor

            CapacitacionDAO.UpdateAsistenciaEstadoById(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDCAPACITACIONASISTENCIA"), GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDASISTENCIAESTADO"))
        End If

        Refrescar()

    End Sub

    Private Sub RepositoryItemGridLookUpEditAsistencia_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemGridLookUpEditAsistencia.EditValueChanged
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()
    End Sub


End Class