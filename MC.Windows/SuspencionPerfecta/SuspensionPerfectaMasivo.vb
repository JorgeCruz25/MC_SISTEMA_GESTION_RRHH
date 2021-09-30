Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports MC.Framework

Public Class SuspensionPerfectaMasivo
    Dim bsSuspencion As New BindingSource
    Dim dtError As New DataTable

    Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "SUSPENSION PERFECTA MASIVO"
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True
        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl2)
        ControlesDevExpress.InitGridViewColumn(GridView2, "MATRICULA", "MATRICULA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "NOMBRE EMPLEADO", "NOMBREEMPLEADO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "MENSAJE", "MENSAJE", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

    End Sub

    Private Sub GridView1_RowCellStyle(sender As Object, e As RowCellStyleEventArgs)
        Dim view As GridView = TryCast(sender, GridView)

        If GridView1.RowCount > 0 Then
            For i As Integer = 0 To GridView1.RowCount - 1
                Dim IDSUSPENSIONPERFECTA As Integer = view.GetRowCellValue(i, "MATRICULA")

            Next
        End If

        'Dim IDSUSPENSIONPERFECTA As Integer = view.GetRowCellValue(e.RowHandle, "IDSUSPENSIONPERFECTA")
        Dim SOLICITUDPENDIENTE As Int32 = view.GetRowCellValue(e.RowHandle, "SOLICITUDPENDIENTE")

        If (SOLICITUDPENDIENTE = 1 Or SOLICITUDPENDIENTE = 2) Then

            e.Appearance.BackColor = Color.LightSalmon
        End If
    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub
    Private Function ValidarColumna() As Boolean
        Dim Result As Boolean = True
        Dim nameGrida As String
        Dim name As String = ""
        Dim resulColumna As Int32
        If GridView1.Columns.Count <> 4 Then
            MessageBox.Show("El numero de columnas no es el correcto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Result = False
        End If
        If Result Then
            Dim columnanombre As String = ""
            For i As Int32 = 0 To GridView1.Columns.Count - 1
                nameGrida = GridView1.Columns.Item(i).Name
                name = Replace(nameGrida, "col", "").Trim
                resulColumna = 0

                If i = 0 Then
                    columnanombre = "MATRICULA"
                ElseIf i = 1 Then
                    columnanombre = "IDSITUACIONLABORAL"
                ElseIf i = 2 Then
                    columnanombre = "FECHAPERIODOINICIO"
                ElseIf i = 3 Then
                    columnanombre = "FECHAPERIODOFIN"
                End If
                If name = columnanombre Then
                    resulColumna = 1
                Else
                    resulColumna = 0
                    Exit For
                End If
            Next
            If resulColumna = 0 Then
                MessageBox.Show("El nombre de la columna " & name & " es errada, el nombre correcto de la columna es " & columnanombre, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Result = False
            End If
        End If
        Return Result
    End Function

    Private Function ValidarMatricula() As Boolean
        Dim Result As Boolean = True
        Dim Valor As Int32 = 0
        If Result Then
            'Dim dtError As New DataTable
            'dtError.Columns.Add("MATRICULA")
            'dtError.Columns.Add("NOMBREEMPLEADO")
            'dtError.Columns.Add("MENSAJE")


            ''VALIDACION DE CANTIDAD DE COLUMNAS
            'If GridView1.Columns.Count <> 4 Then
            '    MessageBox.Show("El numero de columnas no es el correcto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Result = False
            '    Exit Function
            'End If

            ''VALIDADCION NOMBRE COLUMNAS
            'Dim columnanombre As String = ""
            'Dim nameGrida As String = ""
            'Dim resulColumna As Int32
            'For i As Int32 = 0 To GridView1.Columns.Count - 1
            '    nameGrida = GridView1.Columns.Item(i).Name
            '    Name = Replace(nameGrida, "col", "").Trim
            '    resulColumna = 0

            '    If i = 0 Then
            '        columnanombre = "MATRICULA"
            '    ElseIf i = 1 Then
            '        columnanombre = "IDSITUACIONLABORAL"
            '    ElseIf i = 2 Then
            '        columnanombre = "FECHAPERIODOINICIO"
            '    ElseIf i = 3 Then
            '        columnanombre = "FECHAPERIODOFIN"
            '    End If
            '    If Name = columnanombre Then
            '        resulColumna = 1
            '    Else
            '        resulColumna = 0
            '        Exit For
            '    End If
            'Next
            'If resulColumna = 0 Then
            '    MessageBox.Show("El nombre de la columna " & Name & " es errada, el nombre correcto de la columna es " & columnanombre, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Result = False
            'End If

            ''Matriculas existentes y activas
            'If resulColumna = 1 Then

            'End If
            For i As Int32 = 0 To GridView1.Columns.Count - 1
                Dim matricula As String
                matricula = GridView1.GetRowCellValue(i, "MATRICULA")
                Dim dt As DataTable = SuspencionPerfectaDAO.ObtenerValidacionMatricula(matricula)
                If dt.Rows(0)("RESULT") = 1 Then
                    dtError.Rows.Add(dt.Rows(0)("MATRICULA"), dt.Rows(0)("NOMBREEMPLEADO"), dt.Rows(0)("MENSAJE"))
                    Valor = 1
                End If
            Next

            If Valor = 1 Then
                'MessageBox.Show("Existen matriculas inexistentes o matriculas inactivas, por favor verificar la data importada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Result = False
                XtraTabPageListadoErrores.Visible = True
                GridControl2.DataSource = dtError
            Else
                XtraTabPageListadoErrores.Visible = False
            End If

        End If
        Return Result
    End Function


    'Private Sub RepositoryItemCheckEditSeleccionar_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEditSeleccionar.EditValueChanged

    '    Dim SolicitudPendiente As Int32 = GridView1.GetFocusedRowCellValue("SOLICITUDPENDIENTE")
    '    Dim Edit As CheckEdit = CType(sender, CheckEdit)
    '    Select Case Edit.Checked
    '        Case True
    '            If SolicitudPendiente = 1 Or SolicitudPendiente = 2 Then
    '                RepositoryItemCheckEditSeleccionar.ValueUnchecked = False
    '            End If
    '    End Select

    'End Sub

    Private Sub btnImportar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnImportar.ItemClick
        OpenFileDialog1.Filter = "Excel |*.xlsx"
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            Cursor = Cursors.WaitCursor
            Dim path As String = OpenFileDialog1.FileName
            Try
                Dim workbook As Spire.Xls.Workbook = New Spire.Xls.Workbook
                workbook.LoadFromFile(path)
                Dim sheet As Spire.Xls.Worksheet = workbook.Worksheets(0)
                Me.GridControl1.DataSource = sheet.ExportDataTable
                Me.btnImportar.Enabled = False

                'Me.GridView2.defaulc
                Cursor = Cursors.Default
            Catch ex As Exception
                MessageBox.Show("Error al importar Data", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub
    Private Function ValidaRowsRegistros() As Boolean

        Dim Resul As Boolean = True
        If GridView1.RowCount > 0 Then



            Dim nameGrida As String
            Dim numericomatricula As String
            Dim idsituacion As String
            Dim fechainicio As String
            Dim fechafin As String
            Dim FechaPeriodoInicio As Date
            Dim FechaPeriodoFin As Date
            Dim idsituacionlaboral As Int32
            For i As Int32 = 0 To GridView1.Columns.Count - 1
                nameGrida = GridView1.Columns.Item(i).Name
                Name = Replace(nameGrida, "col", "").Trim
                If Name = "MATRICULA" Then
                    For rowmatricula As Integer = 0 To GridView1.RowCount - 1
                        numericomatricula = (GridView1.GetRowCellValue(rowmatricula, Name)).ToString.Trim
                        idsituacionlaboral = (GridView1.GetRowCellValue(rowmatricula, "IDSITUACIONLABORAL")).ToString.Trim
                        FechaPeriodoInicio = (GridView1.GetRowCellValue(rowmatricula, "FECHAPERIODOINICIO")).ToString.Trim
                        FechaPeriodoFin = (GridView1.GetRowCellValue(rowmatricula, "FECHAPERIODOFIN")).ToString.Trim
                        If numericomatricula <> "" And numericomatricula IsNot Nothing Then
                            If Not IsNumeric(numericomatricula) Then
                                MessageBox.Show("la matricula nª " & numericomatricula & " tiene que ser numerico", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Resul = False
                                Exit Function
                            End If
                            If numericomatricula.Length <> 10 Then

                                MessageBox.Show("la matricula nª " & numericomatricula & " tiene que ser de 10 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Resul = False
                                Exit Function
                            End If
                            'Dim dt As DataTable = SuspencionPerfectaDAO.ObtenerValidacionMatricula(numericomatricula)
                            'If dt.Rows(0)("RESULT") = 1 Then
                            '    'MessageBox.Show("la matricula nª " & numericomatricula & " no existe, por favor volver a ingresar la matricula correcta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            '    'Resul = False
                            '    'Exit Function
                            '    dtError.Rows.Add(dt.Rows(0)("MATRICULA"), dt.Rows(0)("NOMBREEMPLEADO"), dt.Rows(0)("MENSAJE"))
                            'End If


                            If FechaPeriodoFin >= FechaPeriodoInicio Then
                                Dim dtvalidadolicenciaSP As DataTable = SuspencionPerfectaDAO.ValidacionAprobadoLicenciaSinGoceSP(numericomatricula, FechaPeriodoInicio, FechaPeriodoFin)
                                If dtvalidadolicenciaSP.Rows(0)("RESULT") = 1 Then
                                    dtError.Rows.Add(dtvalidadolicenciaSP.Rows(0)("MATRCIULA"), dtvalidadolicenciaSP.Rows(0)("NOMBREEMPLEADO"), dtvalidadolicenciaSP.Rows(0)("MENSAJE"))
                                    Resul = False
                                End If
                            Else
                                dtError.Rows.Add(numericomatricula, "", "La fecha del periodo de inicio no puede ser mayor a la fecha periodo fin")
                                Resul = False
                            End If
                        Else
                            MessageBox.Show("Existen registros en la columna MATRICULA que se encuentran vacios, por favor volver a carga la informacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Resul = False
                            Exit Function
                        End If
                    Next
                ElseIf Name = "IDSITUACIONLABORAL" Then
                    For rowid As Integer = 0 To GridView1.RowCount - 1
                        idsituacion = (GridView1.GetRowCellValue(rowid, Name)).ToString.Trim
                        If idsituacion <> "" And idsituacion IsNot Nothing Then
                            If Not IsNumeric(idsituacion) Then
                                MessageBox.Show("El IDSITUACIONLABORAL " & idsituacion & " tiene que ser numerico", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Resul = False
                                Exit Function

                            End If

                            If idsituacion <> "2" And idsituacion <> "4" Then
                                MessageBox.Show("El IDSITUACIONLABORAL " & idsituacion & " no existe, ingrese el IDSITUACIONLABORAL correto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Resul = False
                                Exit Function
                            End If
                        Else
                            MessageBox.Show("Existen registros en la columna IDSITUACIONLABORAL que se encuentran vacios, por favor volver a carga la informacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Resul = False
                            Exit Function
                        End If
                    Next
                ElseIf Name = "FECHAPERIODOINICIO" Then
                    For rowfechainicio As Integer = 0 To GridView1.RowCount - 1
                        fechainicio = (GridView1.GetRowCellValue(rowfechainicio, Name)).ToString.Trim
                        If fechainicio <> "" And fechainicio IsNot Nothing Then
                            If Not IsDate(fechainicio) Then
                                MessageBox.Show("La fecha de inicio " & fechainicio & " tiene que ser un dato fecha", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Resul = False
                                Exit Function
                            End If
                        Else
                            MessageBox.Show("Existen registros en la columna FECHAINICIO que se encuentran vacios, por favor volver a carga la informacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Resul = False
                            Exit Function
                        End If
                    Next
                ElseIf Name = "FECHAPERIODOFIN" Then
                    For rowfechafin As Integer = 0 To GridView1.RowCount - 1
                        fechafin = (GridView1.GetRowCellValue(rowfechafin, Name)).ToString.Trim
                        If fechafin <> "" And fechafin IsNot Nothing Then
                            If Not IsDate(fechafin) Then
                                MessageBox.Show("La fecha fin " & fechafin & " tiene que ser un dato fecha", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Resul = False
                                Exit Function
                            End If
                        Else
                            MessageBox.Show("Existen registros en la columna FECHAFIN que se encuentran vacios, por favor volver a carga la informacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Resul = False
                            Exit Function
                        End If
                    Next
                End If
            Next
        Else
            MessageBox.Show("No cuenta con registros de actualización", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Resul = False
        End If
        Return Resul

    End Function
    Private Sub btnGenerarSolicitudes_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnGenerarSolicitudes.ItemClick
        If GridView1.RowCount > 0 Then

            If MessageBox.Show("Estas seguro de generacion masiva", "Mensaje Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Cursor = Cursors.WaitCursor
                If dtError.Columns.Count = 0 Then
                    dtError.Columns.Add("MATRICULA")
                    dtError.Columns.Add("NOMBREEMPLEADO")
                    dtError.Columns.Add("MENSAJE")
                End If
                If GridView2.RowCount = 0 Then
                    GridControl2.DataSource = dtError
                    If ValidarColumna() Then
                        If ValidaRowsRegistros() Then
                            If dtError.Rows.Count = 0 Then
                                If GridView1.RowCount > 0 And GridView2.RowCount = 0 Then
                                    For i As Int64 = 0 To GridView1.RowCount - 1
                                        Dim Matricula As String = GridView1.GetRowCellValue(i, "MATRICULA")
                                        Dim FechaInicio As Date = GridView1.GetRowCellValue(i, "FECHAPERIODOINICIO")
                                        Dim FechaFin As Date = GridView1.GetRowCellValue(i, "FECHAPERIODOFIN")
                                        Dim IdSituacionLaboral As Int32 = GridView1.GetRowCellValue(i, "IDSITUACIONLABORAL")
                                        SuspencionPerfectaDAO.GenerarSuspensionPerfecta(Matricula, BDCentralDAO.UsuarioBE.IDUsuario, FechaInicio, FechaFin, IdSituacionLaboral)
                                    Next
                                    Me.Close()
                                Else
                                    MessageBox.Show("La información importarda tiene incosistencias, por favor corregir la informacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                End If
                            Else
                                XtraTabPageListadoErrores.Visible = True

                                Cursor = Cursors.Default
                            End If
                        Else
                            MessageBox.Show("La información importarda tiene incosistencias, por favor corregir la informacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                Else
                    btnGenerarSolicitudes.Enabled = False
                End If
            End If

        End If

    End Sub

    Private Sub btnExportar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnExportar.ItemClick
        If GridView2.RowCount > 0 Then
            Try
                Dim ruta As String
                ruta = My.Application.Info.DirectoryPath() + "\ListadoInconsistencias.xlsx"
                GridControl2.ExportToXlsx(ruta)
                Process.Start(ruta)
            Catch ex As Exception
                MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
            End Try
        End If
    End Sub
End Class