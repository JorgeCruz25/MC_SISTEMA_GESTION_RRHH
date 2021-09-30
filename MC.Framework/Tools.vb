Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Tools

    Shared Function ValidaVersion(IdPrograma As Int32) As Boolean
        Dim query As String = "SELECT VERSION FROM MC_SISTEMA WHERE IDSISTEMA=" & IdPrograma
        Using cnx As New SqlConnection(ConfigurationManager.ConnectionStrings("MC.SistemaGestionRRHH.My.MySettings.MC_CENTRALConnectionString").ConnectionString)

            Dim cmd As New SqlCommand(query, cnx)
            cnx.Open()
            Try
                If My.Application.Info.Version.ToString = cmd.ExecuteScalar() Then
                    Return True
                End If
            Catch ex As Exception
                Return False
            End Try
            cnx.Close()
        End Using
        Return False
    End Function

    Public Enum eValidaControl
        TextEdit = 1
        SpinEdit = 2
        GridLoopUpEdit = 3
        SearchLookUpEdit = 4
        DateEdit = 5
    End Enum
    Public Enum eControlAcciones

        TextEdit = 1

        SpinEdit = 2

        GridLoopUpEdit = 3

        SearchLookUpEdit = 4

        DateEdit = 5

        SimpleButton = 6

        BarItemButton = 7

        GridControl = 8

        Column = 9

    End Enum
    Shared Function ReadAppSettings(Key As String) As String
        Dim Value As String = String.Empty
        Try
            Value = ConfigurationManager.AppSettings(Key)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return Value
    End Function

    Shared Function SaveAppSettings(Key As String, Value As String) As Boolean
        Dim Result As Boolean = False

        Try
            Dim configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            Dim settings = configFile.AppSettings.Settings

            If IsNothing(settings(Key)) Then
                settings.Add(Key, Value)
            Else
                settings(Key).Value = Value
            End If
            configFile.Save(ConfigurationSaveMode.Modified)

            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name)
        Catch ex As ConfigurationErrorsException
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return Result
    End Function

    Shared Function ReadNullAsEmptyString(ByVal reader As IDataReader, ByVal fieldName As String) As String
        If IsDBNull(reader(fieldName)) Then
            Return String.Empty
        Else
            Return reader(fieldName).ToString.Trim
        End If
    End Function

    Public Function ReadNullAsEmptyDate(ByVal reader As IDataReader, ByVal fieldName As String) As Nullable(Of Date)
        If IsDBNull(reader(fieldName)) Then
            Return Nothing
        Else
            Return reader(fieldName).ToString.Trim
        End If
    End Function

    Shared Function Teclado(Optional sender As Object = Nothing, Optional e As KeyEventArgs = Nothing) As KeyEventArgs

        Select Case e.KeyCode
            Case Keys.Escape
                sender.Close()

            Case Keys.F1
                MessageBox.Show("Ayuda no esta disponible", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Case Keys.F2
                sender.btnNuevo.PerformClick()

            Case Keys.Enter
                sender.btnEditar.PerformClick()

        End Select

        Return e
    End Function

    Shared Function CampoObligatorio(objControl As Object, Optional ByVal Tipo As eValidaControl = eValidaControl.TextEdit) As Boolean
        Dim Result As Boolean = True

        If Tipo = eValidaControl.TextEdit Then
            If objControl.Text = "" Then
                objControl.ErrorIconAlignment = ErrorIconAlignment.MiddleRight
                objControl.ErrorText = "El campo es obligatorio"
                Result = False
            End If
            If objControl.Text = "0.00" Then
                objControl.ErrorIconAlignment = ErrorIconAlignment.MiddleRight
                objControl.ErrorText = "El campo es obligatorio"
                Result = False
            End If
            If objControl.Text = "0" Then
                objControl.ErrorIconAlignment = ErrorIconAlignment.MiddleRight
                objControl.ErrorText = "El campo es obligatorio"
                Result = False
            End If
        End If

        If Tipo = eValidaControl.SpinEdit Then
            Dim Control As New SpinEdit

            Control = CType(objControl, SpinEdit)

            If Control.EditValue = 0 Then
                objControl.ErrorIconAlignment = ErrorIconAlignment.MiddleRight
                objControl.ErrorText = "El campo es obligatorio"
                Result = False
            End If
        End If

        If Tipo = eValidaControl.GridLoopUpEdit Then
            Dim Control As New GridLookUpEdit

            Control = CType(objControl, GridLookUpEdit)

            If Control.EditValue = 0 Then
                objControl.ErrorIconAlignment = ErrorIconAlignment.MiddleRight
                objControl.ErrorText = "El campo es obligatorio"
                Result = False
            End If
        End If

        If Tipo = eValidaControl.SearchLookUpEdit Then
            Dim Control As New SearchLookUpEdit

            Control = CType(objControl, SearchLookUpEdit)

            If Control.EditValue = 0 Then
                objControl.ErrorIconAlignment = ErrorIconAlignment.MiddleRight
                objControl.ErrorText = "El campo es obligatorio"
                Result = False
            End If
        End If
        If Tipo = eValidaControl.DateEdit Then
            Dim Control As New DateEdit
            Control = CType(objControl, DateEdit)

            If Control.EditValue Is Nothing Then
                objControl.ErrorIconAlignment = ErrorIconAlignment.MiddleRight
                objControl.ErrorText = "El campo es obligatorio"
                Result = False
            End If

        End If
        Return Result
    End Function
    Shared Sub ExportarDataGridViewADataTable(ByVal miDataGrid As DataGridView, ByRef Tabla As DataTable)
        Try
            Dim filaNueva As System.Data.DataRow
            Dim numCols As Integer

            numCols = miDataGrid.ColumnCount

            ' Rellenamos los valores del DataTable nuevo con los valores de las celdas del DataGridView
            For Each filaDatos As DataGridViewRow In miDataGrid.Rows
                filaNueva = Tabla.NewRow()
                For i As Integer = 0 To numCols - 1
                    filaNueva(i) = filaDatos.Cells(i).Value
                Next
                Tabla.Rows.Add(filaNueva)
            Next

        Catch ex As Exception
            Tabla = New DataTable
        End Try

    End Sub

    Shared Sub ExportarGridView(ByVal gv As DataGridView, ByVal fileName As String, ByVal sheetName As String)
        If File.Exists(fileName) Then
            File.Delete(fileName)
        End If
        Dim oExcel As Object
        oExcel = CreateObject("Excel.Application")
        Dim oBook As Excel.Workbook
        Dim oSheet As Excel.Worksheet

        oBook = oExcel.Workbooks.Add
        oSheet = oExcel.Worksheets(1)

        oSheet.Name = "Hoja"
        'oSheet.Range("A1").Value = "SOME VALUE"
        oBook.SaveAs(fileName)
        oBook.Close()
        oBook = Nothing
        oExcel.Quit()
        oExcel = Nothing

        ' Verificamos los parámetros pasados
        '
        If ((gv Is Nothing) OrElse
        (String.IsNullOrEmpty(fileName)) OrElse
        (String.IsNullOrEmpty(sheetName))) Then _
        Throw New ArgumentNullException()

        Dim app As Excel.Application = Nothing
        Dim book As Excel.Workbook = Nothing
        Dim sheet As Excel.Worksheet = Nothing

        Try
            ' Referenciamos la aplicación Excel.

            app = New Excel.Application()
            'Crear Libro y Hoja
            'book = app.Workbooks.Add("File")
            'sheet = book.Sheets("Hoja")

            ' Abrimos el libro de trabajo            '
            book = app.Workbooks.Open(fileName)
            ' Referenciamos la hoja de cálculo del libro.            '
            sheet = DirectCast(book.Sheets(sheetName), Excel.Worksheet)
            With sheet
                ' Limpiamos el contenido de toda la hoja.                '
                .Cells.Select()
                .Cells.ClearContents()

                ' Seleccionamos la primera celda de la hoja.                '
                .Range("A1").Select()
                ' Escribimos los nombres de las columnas en la primera
                ' celda de la primera fila de la hoja de cálculo                '
                Dim fila As Integer = 1
                Dim columna As Integer = 1

                For Each dc As DataColumn In gv.Columns
                    .Cells(fila, columna) = dc.ColumnName
                    columna += 1
                Next

                ' Establecemos los atributos de la fuente para las
                ' celdas de la primera fila.
                '
                With .Range(.Cells(1, 1), .Cells(1, gv.Columns.Count)).Font
                    .Name = "Calibri"
                    .Bold = True
                    .Size = 12
                End With

                ' Insertamos los datos en la hoja de cálculo, comenzando por la
                ' fila número 2, ya que la primera fila está ocupada
                ' por el nombre de las columnas.
                '
                fila = 2
                For Each row As DataRow In gv.Rows
                    ' Primera columna
                    columna = 1
                    For Each dc As DataColumn In gv.Columns
                        .Cells(fila, columna) = row(dc.ColumnName)
                        ' Siguiente columna
                        columna += 1
                    Next
                    ' Siguiente fila
                    fila += 1
                Next
                ' Autoajustamos el ancho de todas las columnas utilizadas.
                .Columns().AutoFit()
            End With
        Catch ex As Exception
            ' Se ha producido una excepción;
            ' indicamos que el libro ha sido guardado.
            '
            If (book IsNot Nothing) Then
                book.Saved = True
            End If
            ' Devolvemos la excepción al procedimiento llamador
            Throw
        Finally
            sheet = Nothing
            If (book IsNot Nothing) Then
                ' Si procede, guardamos el libro de trabajo.
                If (Not (book.Saved)) Then book.Save()
                ' Cerramos el libro de Excel.
                book.Close()
            End If
            book = Nothing

            If (app IsNot Nothing) Then
                ' Si procede, cerramos Excel y disminuimos el recuento
                ' de referencias al objeto Excel.Application.
                app.Quit()
                While (System.Runtime.InteropServices.Marshal.ReleaseComObject(app) > 0)
                    ' Sin implementación.
                End While
            End If
            app = Nothing
        End Try
    End Sub
    Shared Sub ExportToExcel(ByVal dt As DataTable, ByVal fileName As String, ByVal sheetName As String)
        If File.Exists(fileName) Then
            File.Delete(fileName)
        End If
        Dim oExcel As Object
        oExcel = CreateObject("Excel.Application")
        Dim oBook As Excel.Workbook
        Dim oSheet As Excel.Worksheet

        oBook = oExcel.Workbooks.Add
        oSheet = oExcel.Worksheets(1)

        oSheet.Name = "Hoja"
        'oSheet.Range("A1").Value = "SOME VALUE"
        oBook.SaveAs(fileName)
        oBook.Close()
        oBook = Nothing
        oExcel.Quit()
        oExcel = Nothing

        ' Verificamos los parámetros pasados
        '
        If ((dt Is Nothing) OrElse
        (String.IsNullOrEmpty(fileName)) OrElse
        (String.IsNullOrEmpty(sheetName))) Then _
        Throw New ArgumentNullException()

        Dim app As Excel.Application = Nothing
        Dim book As Excel.Workbook = Nothing
        Dim sheet As Excel.Worksheet = Nothing

        Try
            ' Referenciamos la aplicación Excel.

            app = New Excel.Application()
            'Crear Libro y Hoja
            'book = app.Workbooks.Add("File")
            'sheet = book.Sheets("Hoja")

            ' Abrimos el libro de trabajo            '
            book = app.Workbooks.Open(fileName)
            ' Referenciamos la hoja de cálculo del libro.            '
            sheet = DirectCast(book.Sheets(sheetName), Excel.Worksheet)
            With sheet
                ' Limpiamos el contenido de toda la hoja.                '
                .Cells.Select()
                .Cells.ClearContents()

                ' Seleccionamos la primera celda de la hoja.                '
                .Range("A1").Select()
                ' Escribimos los nombres de las columnas en la primera
                ' celda de la primera fila de la hoja de cálculo                '
                Dim fila As Integer = 1
                Dim columna As Integer = 1

                For Each dc As DataColumn In dt.Columns
                    .Cells(fila, columna) = dc.ColumnName
                    columna += 1
                Next

                ' Establecemos los atributos de la fuente para las
                ' celdas de la primera fila.
                '
                With .Range(.Cells(1, 1), .Cells(1, dt.Columns.Count)).Font
                    .Name = "Calibri"
                    .Bold = True
                    .Size = 12
                End With

                ' Insertamos los datos en la hoja de cálculo, comenzando por la
                ' fila número 2, ya que la primera fila está ocupada
                ' por el nombre de las columnas.
                '
                fila = 2
                For Each row As DataRow In dt.Rows
                    ' Primera columna
                    columna = 1
                    For Each dc As DataColumn In dt.Columns
                        .Cells(fila, columna) = row(dc.ColumnName)
                        ' Siguiente columna
                        columna += 1
                    Next
                    ' Siguiente fila
                    fila += 1
                Next
                ' Autoajustamos el ancho de todas las columnas utilizadas.
                .Columns().AutoFit()
            End With
        Catch ex As Exception
            ' Se ha producido una excepción;
            ' indicamos que el libro ha sido guardado.
            '
            If (book IsNot Nothing) Then
                book.Saved = True
            End If
            ' Devolvemos la excepción al procedimiento llamador
            Throw
        Finally
            sheet = Nothing
            If (book IsNot Nothing) Then
                ' Si procede, guardamos el libro de trabajo.
                If (Not (book.Saved)) Then book.Save()
                ' Cerramos el libro de Excel.
                book.Close()
            End If
            book = Nothing

            If (app IsNot Nothing) Then
                ' Si procede, cerramos Excel y disminuimos el recuento
                ' de referencias al objeto Excel.Application.
                app.Quit()
                While (System.Runtime.InteropServices.Marshal.ReleaseComObject(app) > 0)
                    ' Sin implementación.
                End While
            End If
            app = Nothing
        End Try
    End Sub

    Shared Function ControlAcciones(ByVal objControl As Object, ByVal Tipo As eControlAcciones) As Boolean

        Dim Result As Boolean = True

        If Tipo = eControlAcciones.TextEdit Then
            Dim Control As New TextEdit
            Control = CType(objControl, TextEdit)
            Control.Enabled = True
        End If

        If Tipo = eControlAcciones.SpinEdit Then
            Dim Control As New SpinEdit
            Control = CType(objControl, SpinEdit)
            Control.Enabled = True
        End If

        If Tipo = eControlAcciones.GridLoopUpEdit Then
            Dim Control As New GridLookUpEdit
            Control = CType(objControl, GridLookUpEdit)
            Control.Enabled = True
        End If

        If Tipo = eControlAcciones.SearchLookUpEdit Then
            Dim Control As New SearchLookUpEdit
            Control = CType(objControl, SearchLookUpEdit)
            Control.Enabled = True
        End If

        If Tipo = eControlAcciones.DateEdit Then
            Dim Control As New DateEdit
            Control = CType(objControl, DateEdit)
            Control.Enabled = True
        End If

        If Tipo = eControlAcciones.SimpleButton Then
            Dim Control As New SimpleButton
            Control = CType(objControl, SimpleButton)
            Control.Enabled = True
        End If

        If Tipo = eControlAcciones.BarItemButton Then
            Dim Control As New DevExpress.XtraBars.BarButtonItem
            Control = CType(objControl, DevExpress.XtraBars.BarButtonItem)
            Control.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If

        If Tipo = eControlAcciones.GridControl Then
            Dim Control As New DevExpress.XtraGrid.GridControl
            Control = CType(objControl, DevExpress.XtraGrid.GridControl)
            Control.Enabled = True

        End If

        If Tipo = eControlAcciones.Column Then
            Dim Control As New GridColumn
            Control = CType(objControl, GridColumn)
            Control.Visible = True
        End If

        Return Result

    End Function

    Shared Function AccionesUsuarioGrid(ByVal gvDocumentos As GridView, ByVal dtAccionesUsuario As DataTable)

        For j As Integer = 0 To dtAccionesUsuario.Rows.Count - 1
            If dtAccionesUsuario.Rows(j)("OPCIONFORMULARIO") = "Column" Then
                If gvDocumentos IsNot Nothing Then
                    For i As Integer = 0 To gvDocumentos.Columns.Count - 1
                        If gvDocumentos.Columns.Item(i).Name.ToString() = dtAccionesUsuario.Rows(j)("NOMBRECONTROL") Then
                            Tools.ControlAcciones(gvDocumentos.Columns(dtAccionesUsuario.Rows(j)("NOMBRECONTROL")), dtAccionesUsuario.Rows(j)("IDCONTROLFORMULARIO"))
                        End If
                    Next
                End If
            End If
        Next
        Return True
    End Function

    Shared Function AccionesUsuarioRibbon(ByVal RibbonControl As RibbonControl, ByVal dtAccionesUsuario As DataTable)
        For j As Integer = 0 To dtAccionesUsuario.Rows.Count - 1
            Dim CtlBarButtonItem As Object
            For x = RibbonControl.Items.Count - 1 To 0 Step -1
                CtlBarButtonItem = RibbonControl.Items.Item(x)
                If CtlBarButtonItem.Name = dtAccionesUsuario.Rows(j)("NOMBRECONTROL") Then
                    Tools.ControlAcciones(CtlBarButtonItem, dtAccionesUsuario.Rows(j)("IDCONTROLFORMULARIO"))
                End If
            Next
        Next
        Return True
    End Function

    Shared Function AccionesUsuario(ByVal Controls As Object, ByVal dtAccionesUsuario As DataTable)
        Dim Ctl As Control
        Dim x As Integer
        For j As Integer = 0 To dtAccionesUsuario.Rows.Count - 1
            For x = Controls.Count - 1 To 0 Step -1
                Ctl = Controls.Item(x)
                If Controls.Item(x).name = dtAccionesUsuario.Rows(j)("NOMBRECONTROL") Then
                    Tools.ControlAcciones(Ctl, dtAccionesUsuario.Rows(j)("IDCONTROLFORMULARIO"))
                End If
            Next
        Next
        Return True
    End Function
    'Shared Function AccesoLogIns(IDSistema As Int32, IDUsuario As Int32, DetalleLog As String, NombreLog As String) As Int32
    '    Dim cnx As New SqlConnection(ConfigurationManager.ConnectionStrings("MC_CENTRAL_ConnectionString").ConnectionString)
    '    Dim cmd As New SqlCommand
    '    Dim Result As Int32 = 0
    '    With cmd
    '        .Connection = cnx
    '        .CommandType = CommandType.StoredProcedure
    '        .CommandText = "MC_ACCESO_LOG_INS"
    '        With .Parameters
    '            .Add("@IDSistema", SqlDbType.Int).Value = IDSistema ' id del sistema al que se ha ingresado
    '            .Add("@IDUsuario", SqlDbType.Int).Value = IDUsuario ' id del usuario que accedió
    '            .Add("@Detalle", SqlDbType.NVarChar, 4000).Value = DetalleLog.ToUpper ' detalles  de la acción: impresión,exportación,  rango de fechas, filtros, etc.
    '            .Add("@Accion", SqlDbType.NVarChar, 4000).Value = NombreLog.ToUpper 'formulario o reporte al que se esta ingresando
    '        End With
    '    End With
    '    Try
    '        cnx.Open()
    '        If cmd.ExecuteNonQuery() > 0 Then
    '        End If
    '    Catch ex As Exception
    '        Throw
    '    Finally
    '        If cnx.State = ConnectionState.Open Then
    '            cnx.Close()
    '        End If
    '    End Try
    '    Return Result
    'End Function


End Class
