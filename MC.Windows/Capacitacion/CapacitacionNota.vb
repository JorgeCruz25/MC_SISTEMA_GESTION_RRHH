Imports System.IO
Imports System.Text
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Base
Imports MC.Data
Imports MC.Framework
Imports Microsoft.Office.Interop
Imports Spire.Xls
Public Class CapacitacionNota
    Dim bsNotas As New BindingSource
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterParent
        Me.WindowState = FormWindowState.Maximized
        Me.Text = "REGISTRO DE NOTAS"
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True
        btnGrabar.Visibility = BarItemVisibility.Never
        'CURSO



        Refrescar()

    End Sub
    Private Sub Refrescar()
        Try
            bsNotas.DataSource = CapacitacionDAO.CapacitacionNotasGetId(CapacitacionDAO.IdCapacitacion)
            GridControl1.DataSource = bsNotas

        Catch ex As Exception

        End Try
    End Sub



    Private Sub btnCerrar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Dim NOTA As Double = GridView1.GetFocusedRowCellValue("NOTAOBTENIDA")
        Dim Estado As Boolean = GridView1.GetFocusedRowCellValue("ESTADO")

        Dim estadocpacitacion As Integer = CapacitacionDAO.ObtenerEstadoCapacitacion(CapacitacionDAO.IdCapacitacion)
        If estadocpacitacion = 1 Then
            MessageBox.Show("Para poder registrar las notas la capacitacion tiene que estar en estado Asignado")
        ElseIf estadocpacitacion = 3 Then
            MessageBox.Show("No podra realizar el registro de las notas porque la capacitación ya se encuentra Cerrada")
        ElseIf estadocpacitacion = 4 Then
            MessageBox.Show("No podra realizar el registro de las notas porque la capacitación se encuentra Anulada")
        ElseIf estadocpacitacion = 2 Then
            If Estado Then
                If NOTA > 20 Or NOTA < 0 Then
                    MessageBox.Show("La nota ingresada no esta dentro del rango establecido")
                Else
                    CapacitacionDAO.UpdateAsistenciaNotaById(GridView1.GetFocusedRowCellValue("IDCAPACITACIONNOTA"), Estado, NOTA, BDCentralDAO.UsuarioBE.IDUsuario)
                End If
            Else
                CapacitacionDAO.UpdateAsistenciaNotaById(GridView1.GetFocusedRowCellValue("IDCAPACITACIONNOTA"), Estado, NOTA, BDCentralDAO.UsuarioBE.IDUsuario)
            End If
        End If
        Refrescar()
    End Sub
End Class