Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework
Public Class SuspensionPerfectaList
    Dim bsSuspencionPerfecta As New BindingSource

    Public Sub Refrescar()
        Try
            GridView1.Columns.Item("APROBAR").Visible = False
            GridView1.Columns.Item("ANULAR").Visible = False
            GridView1.Columns.Item("FORMATO").Visible = False
            btnExportar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Dim dtAccionesBotones As DataTable
            dtAccionesBotones = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(Ribbon, dtAccionesBotones)

            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioGrid(GridView1, dtAccionesUsuario)


            bsSuspencionPerfecta.DataSource = SuspencionPerfectaDAO.GetSuspensionPerfectaList()
            Me.GridControl1.DataSource = bsSuspencionPerfecta

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub SuspensionPerfectaList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub

    Private Sub btnExportar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportar.ItemClick
        If GridView1.RowCount > 0 Then
            Try
                Dim ruta As String
                ruta = My.Application.Info.DirectoryPath() + "\Suspencion_Perfecta.xlsx"
                GridControl1.ExportToXlsx(ruta)
                Process.Start(ruta)
            Catch ex As Exception
                MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
            End Try
        End If
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub
    Private Sub SuspensionPerfectaList_Load(sender As Object, e As EventArgs) Handles Me.Load
        GridView1.Columns(0).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(1).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(2).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(3).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(4).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(5).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(6).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Refrescar()
    End Sub
    Private Sub GridView1_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim view As GridView = TryCast(sender, GridView)
        Dim IDLICENCIA As Integer = view.GetRowCellValue(e.RowHandle, "IDLICENCIA")
        Dim IDSITUACIONLABORALSOLICITUD As Int32 = view.GetRowCellValue(e.RowHandle, "IDSITUACIONLABORALSOLICITUD")
        If e.Column.FieldName = "FECHAPERIODOINICIO" Or e.Column.FieldName = "FECHAPERIODOFIN" Then
            'e.Appearance.BackColor = If(IDSITUACIONLABORALSOLICITUD = 4, Color.LightGreen, Color.LightSalmon)
            If IDSITUACIONLABORALSOLICITUD = 4 Then
                e.Appearance.BackColor = Color.LightGreen
            Else
                e.Appearance.BackColor = Color.LightSalmon
            End If
        ElseIf e.Column.FieldName = "FECHAPERIODOFINSUSPENSIONPERFECTA" Then
            If IDSITUACIONLABORALSOLICITUD = 2 Then
                e.Appearance.BackColor = Color.LightGreen
            Else
                e.Appearance.BackColor = Color.LightSalmon
            End If
        ElseIf e.Column.FieldName = "FECHAPERIODOINICIO" Or e.Column.FieldName = "FECHAPERIODOFIN" Or e.Column.FieldName = "FECHAPERIODOFINSUSPENSIONPERFECTA" Then
            If IDSITUACIONLABORALSOLICITUD = 1 Then
                e.Appearance.BackColor = Color.LightSalmon
            End If
        End If
    End Sub

    Private Sub GridView1_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView1.RowUpdated
        Dim IDSUSPENSIONPERFECTA As Integer = GridView1.GetFocusedRowCellValue("IDSUSPENSIONPERFECTA")
        Dim IDSITUACIONLABORALSOLICITUD As Int32 = GridView1.GetFocusedRowCellValue("IDSITUACIONLABORALSOLICITUD")
        Dim IDLICENCIA As Integer = GridView1.GetFocusedRowCellValue("IDLICENCIA")

        Dim FECHAPERIODOINICIO As Date
        Dim FECHAPERIODOFIN As Date
        Dim IDMES As Int32 = 0
        Dim FECHAPERIODOFINSUPENSION As Date
        Cursor = Cursors.WaitCursor
        If IDSITUACIONLABORALSOLICITUD = 4 Then
            FECHAPERIODOINICIO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAPERIODOINICIO")
            FECHAPERIODOFIN = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAPERIODOFIN")
            If FECHAPERIODOINICIO <= FECHAPERIODOFIN Then
                SuspencionPerfectaDAO.ActualizarCamposLicencias(IDSUSPENSIONPERFECTA, IDLICENCIA, FECHAPERIODOINICIO, FECHAPERIODOFIN)
            Else
                MessageBox.Show("La fecha del periodo de inicio no puede ser mayor a la fecha final", "Advertencia")
            End If
        ElseIf IDSITUACIONLABORALSOLICITUD = 2 Then
            FECHAPERIODOFINSUPENSION = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAPERIODOFINSUSPENSIONPERFECTA")
            SuspencionPerfectaDAO.ActualizarCampoSupensionPerfecta(IDSUSPENSIONPERFECTA, FECHAPERIODOFINSUPENSION)
        End If
        Refrescar()

    End Sub

    Private Sub RepositoryItemAnular_Click(sender As Object, e As EventArgs) Handles RepositoryItemAnular.Click
        Dim IDSUSPENCIONPERFECTA As Integer
        Dim NOMBREEMPLEADO As String
        IDSUSPENCIONPERFECTA = GridView1.GetFocusedRowCellValue("IDSUSPENSIONPERFECTA")
        NOMBREEMPLEADO = GridView1.GetFocusedRowCellValue("NOMBRES") + " " + GridView1.GetFocusedRowCellValue("APELLIDOPATERNO") + " " + GridView1.GetFocusedRowCellValue("APELLIDOMATERNO")
        If IDSUSPENCIONPERFECTA <> 0 Then
            If MessageBox.Show("Esta seguro de anular la suspencion perfecta del colaborador " + NOMBREEMPLEADO, "ADVERTENCIA DEL PROCESO", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                If Not SuspencionPerfectaDAO.AnularSuspensionPerfecta(IDSUSPENCIONPERFECTA, BDCentralDAO.UsuarioBE.IDUsuario) Then
                    MessageBox.Show("Problemas de conexión con el servidor, fuelva a procesarlo")
                End If
                Refrescar()
            End If
        End If

    End Sub

    Private Sub RepositoryItemAprobar_Click(sender As Object, e As EventArgs) Handles RepositoryItemAprobar.Click
        Dim IDSUSPENCIONPERFECTA As Integer
        Dim NOMBREEMPLEADO As String
        Dim ESTADOEMPLEADO As Int32
        Dim IDLICENCIA As Integer
        Dim FECHAPERIODOINICIO As String
        Dim FECHAPERIODOFIN As String

        Dim IDEMPLEADO As Integer
        Dim MENSAJE As String = ""
        IDSUSPENCIONPERFECTA = GridView1.GetFocusedRowCellValue("IDSUSPENSIONPERFECTA")
        IDLICENCIA = GridView1.GetFocusedRowCellValue("IDLICENCIA")
        Dim IDSITUACIONLABORALSOLICITUD As Int32 = GridView1.GetFocusedRowCellValue("IDSITUACIONLABORALSOLICITUD")
        NOMBREEMPLEADO = GridView1.GetFocusedRowCellValue("NOMBRES") + " " + GridView1.GetFocusedRowCellValue("APELLIDOPATERNO") + " " + GridView1.GetFocusedRowCellValue("APELLIDOMATERNO")
        ESTADOEMPLEADO = GridView1.GetFocusedRowCellValue("IDESTADOEMPLEADO")
        IDEMPLEADO = GridView1.GetFocusedRowCellValue("IDEMPLEADO")
        If IDSITUACIONLABORALSOLICITUD = 4 Then
            FECHAPERIODOINICIO = GridView1.GetFocusedRowCellValue("FECHAPERIODOINICIO")
            FECHAPERIODOFIN = GridView1.GetFocusedRowCellValue("FECHAPERIODOFIN")
            If FECHAPERIODOINICIO = "" Then
                MENSAJE = "La fecha de inicio es un campo obligatorio"
            ElseIf FECHAPERIODOFIN = "" Then
                MENSAJE = "La fecha fin es un campo obligatorio"
            ElseIf (GridView1.GetFocusedRowCellValue("FECHAPERIODOFIN")) < (GridView1.GetFocusedRowCellValue("FECHAPERIODOFIN")) Then
                MENSAJE = "La fecha de inicio del periodo de licencia no puede ser mayor a la fecha final"
            End If
        ElseIf IDSITUACIONLABORALSOLICITUD = 2 Then
            If GridView1.GetFocusedRowCellValue("FECHAPERIODOFINSUSPENSIONPERFECTA") = "1900-01-01" Then
                MENSAJE = "La fecha de fin de la Suspension Pefecta es un dato obligatorio"
            End If
        End If
        If IDSUSPENCIONPERFECTA <> 0 Then
            If MENSAJE = "" Then
                If ESTADOEMPLEADO = 1 Then
                    If (IDSITUACIONLABORALSOLICITUD = 2) Then 'SOLICITUD POR SUSPENSION PERFECTA
                        Dim FECHAFINSUSPENSIONFERFECTA As Date = GridView1.GetFocusedRowCellValue("FECHAPERIODOFINSUSPENSIONPERFECTA")
                        If FECHAFINSUSPENSIONFERFECTA = "1900-01-01" Then
                            MessageBox.Show("La fecha fin de la suspensión perfecta es un campo obligatorio")
                        Else
                            Dim dtvalidarlaborando As DataTable = SuspencionPerfectaDAO.ValidacionSuspensionPerfecta(IDSUSPENCIONPERFECTA, IDEMPLEADO, FECHAFINSUSPENSIONFERFECTA)
                            If dtvalidarlaborando.Rows(0)("RESULT") = 13 Then
                                If MessageBox.Show("¿Esta seguro de aprobar la solicitud de tipo Suspension Perfecta al colaborador " + NOMBREEMPLEADO, "ADVERTENCIA DEL PROCESO", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                    If Not SuspencionPerfectaDAO.AprobarSuspensionPerfecta(IDSUSPENCIONPERFECTA, BDCentralDAO.UsuarioBE.IDUsuario) Then
                                        MessageBox.Show("Problemas de conexión con el servidor, fuelva a procesarlo")
                                    End If
                                    Refrescar()
                                End If
                            Else
                                MessageBox.Show(dtvalidarlaborando.Rows(0)("MENSAJE"))
                            End If
                        End If
                    ElseIf (IDSITUACIONLABORALSOLICITUD = 4) Then 'SOLICITUD LICENCIA SIN GOCE DE HABER POR SUSPENSION PERFECTA
                        Dim dtvalorlsgsp As DataTable = SuspencionPerfectaDAO.ValidacionAprobadoLicenciaSinGoceSP(IDSUSPENCIONPERFECTA, IDEMPLEADO, GridView1.GetFocusedRowCellValue("FECHAPERIODOINICIO"), GridView1.GetFocusedRowCellValue("FECHAPERIODOFIN"))
                        If dtvalorlsgsp.Rows.Count > 0 Then
                            Dim dtArchivo As DataTable
                            dtArchivo = LicenciaDAO.ListaLicenciaAcuerdoArchivos(IDLICENCIA)
                            If dtArchivo.Rows.Count <> 0 Then
                                If dtvalorlsgsp.Rows(0)("RESULT") = 13 Then
                                    If MessageBox.Show("¿Esta seguro de aprobar la solicitud de tipo Licencia sin Goge de Haber por Suspension Perfecta al colaborador " + NOMBREEMPLEADO, "ADVERTENCIA DEL PROCESO", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                        If Not SuspencionPerfectaDAO.AprobarSuspensionPerfectaLicenciaSinGoceSP(IDSUSPENCIONPERFECTA, BDCentralDAO.UsuarioBE.IDUsuario) Then
                                            MessageBox.Show("Problemas de conexión con el servidor, fuelva a procesarlo")
                                        End If
                                        Refrescar()
                                    End If
                                Else
                                    MessageBox.Show(dtvalorlsgsp.Rows(0)("MENSAJE"))
                                End If
                            Else
                                MessageBox.Show("Para poder aprobar la solicitud tiene que haber el adjunto de por medio")
                            End If
                        End If
                        ElseIf IDSITUACIONLABORALSOLICITUD = 1 Then 'SOLICTUD DE LABORANDO
                        Dim dtvalidarlaborando As DataTable = SuspencionPerfectaDAO.ValidacionAprobadoLaborando(IDSUSPENCIONPERFECTA, IDEMPLEADO)
                        If dtvalidarlaborando.Rows(0)("RESULT") = 11 Then
                            If MessageBox.Show("Esta seguro de aprobar la solicitud de tipo laborando al colaborador " + NOMBREEMPLEADO, "ADVERTENCIA DEL PROCESO", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                If Not SuspencionPerfectaDAO.AprobarSuspensionPerfectaLaborando(IDSUSPENCIONPERFECTA, BDCentralDAO.UsuarioBE.IDUsuario) Then ' APRUEBA SOLICITUD DE TIPO LABORANDO
                                    MessageBox.Show("Problemas de conexión con el servidor, fuelva a procesarlo")
                                End If
                                Refrescar()
                            End If
                        Else
                            MessageBox.Show(dtvalidarlaborando.Rows(0)("MENSAJE"))
                        End If
                    End If
                Else
                    MessageBox.Show("El colaborador ya se encuentra Cesado")
                End If
            Else
                MessageBox.Show(MENSAJE)
            End If
        End If
    End Sub
    Private Sub RepositoryItemDateFechaInicio_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemDateFechaInicio.EditValueChanged
        Dim IDSITUACIONLABORALSOLICITUD As Int32 = GridView1.GetFocusedRowCellValue("IDSITUACIONLABORALSOLICITUD")
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()
        If IDSITUACIONLABORALSOLICITUD <> 4 Then
            MessageBox.Show("Este campo solo es editable para las solicitudes con licencias", "Advertencia")
        End If
    End Sub

    Private Sub RepositoryItemDateFechaFinal_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemDateFechaFinal.EditValueChanged
        Dim IDSITUACIONLABORALSOLICITUD As Int32 = GridView1.GetFocusedRowCellValue("IDSITUACIONLABORALSOLICITUD")
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()
        If IDSITUACIONLABORALSOLICITUD <> 4 Then
            MessageBox.Show("Este campo solo es editable para las solicitudes con licencias", "Advertencia")
        End If
    End Sub


    Private Sub RepositoryItemDateFechaFinSuspension_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemDateFechaFinSuspension.EditValueChanged
        Dim IDSITUACIONLABORALSOLICITUD As Int32 = GridView1.GetFocusedRowCellValue("IDSITUACIONLABORALSOLICITUD")
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()
        If IDSITUACIONLABORALSOLICITUD <> 2 Then
            MessageBox.Show("Este campo solo es editable para las solicitudes de suspensión perfecta", "Advertencia")
        End If
    End Sub

    Private Sub RepositoryItemAcuerdoArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemAcuerdoArchivo.Click
        Dim IDSITUACIONLABORALSOLICITUD As Integer
        Dim IDLICENCIA As Integer
        IDSITUACIONLABORALSOLICITUD = GridView1.GetFocusedRowCellValue("IDSITUACIONLABORALSOLICITUD")
        IDLICENCIA = GridView1.GetFocusedRowCellValue("IDLICENCIA")
        If IDSITUACIONLABORALSOLICITUD = 4 Then
            If IDLICENCIA <> 0 Then
                Dim MiForm As New LicenciaArchivo
                Dim dt As DataTable = LicenciaDAO.ListaLicenciaAcuerdoArchivos(IDLICENCIA)
                If dt.Rows.Count <> 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim ruta As String = dt.Rows(i).Table(i)("linkdescarga").ToString
                        Dim tab As String
                        tab = "Archivo" + Convert.ToString(i + 1)
                        Dim NewTab As New XtraTabPage
                        NewTab.Name = tab
                        NewTab.Text = tab
                        MiForm.XtraTabControl1.TabPages.Add(NewTab)

                        Dim uccontrol1 As New XtraUserControlWebBrowser()
                        NewTab.Controls.Add(uccontrol1)
                        uccontrol1.Dock = DockStyle.Fill

                        uccontrol1.WebBrowser1.Show()
                        uccontrol1.WebBrowser1.Navigate(String.Format(ruta, Application.StartupPath))
                    Next
                    MiForm.ShowDialog()
                Else
                    MessageBox.Show("La solicitud no cuenta con adjunto", "Archivo de Acuerdo")
                End If
            End If
        Else
            MessageBox.Show("Para mostrar el adjunto, el tipo de solictud tiene que ser Licencia sin Goce por Suspensión Perfecta")
        End If
    End Sub
End Class