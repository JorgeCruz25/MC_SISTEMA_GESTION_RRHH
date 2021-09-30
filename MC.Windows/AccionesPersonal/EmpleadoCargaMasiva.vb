
'Imports System.IO
'Imports DevExpress.XtraTab
Imports System.IO
Imports System.Text
Imports DevExpress.XtraBars
Imports MC.Data
'Imports MC.Framework
Imports Microsoft.Office.Interop
'Imports System.Data.OleDb
'Imports System
'Imports Microsoft.VisualBasic
Imports Spire.Xls
'Imports Microsoft.Office.Interop.Excel

Public Class EmpleadoCargaMasiva
    Dim dta As DataTable
    Dim bsCamposList As New BindingSource
    'Dim dtExcel As New DataTable

    Dim drRowOrganigrama As DataRow

    Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        rboSueldo.Checked = True
        'CamposList()
    End Sub



    'Private Sub CargarCabecera()
    '    Dim dtExcel As New DataTable
    '    Dim rbo As Int32
    '    Dim tipo As String = ""
    '    If rboSueldo.Checked Then
    '        rbo = 1
    '        tipo = "Cuenta Sueldo"
    '    End If
    '    If rboCts.Checked Then
    '        rbo = 2
    '        tipo = "Cuenta Cts"
    '    End If

    '    dtExcel = BDAccionPersonalDAO.CargaMasivaCampos(rbo)


    '    Try
    '        Dim ruta As String
    '        'Dim myStream As Stream
    '        Dim saveFileDialog1 As New SaveFileDialog()

    '        saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.xlsx*)|*.xlsx*"
    '        saveFileDialog1.FilterIndex = 2
    '        saveFileDialog1.RestoreDirectory = True

    '        If saveFileDialog1.ShowDialog() = DialogResult.OK Then

    '            ruta = saveFileDialog1.FileName

    '            Dim strFile As String = ruta
    '            Dim excel As New Excel.Application
    '            Dim wBook As Microsoft.Office.Interop.Excel.Workbook
    '            Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

    '            wBook = excel.Workbooks.Add()
    '            wSheet = wBook.ActiveSheet()

    '            Dim dc As System.Data.DataColumn
    '            'Dim dr As System.Data.DataRow
    '            Dim colIndex As Integer = 0
    '            Dim rowIndex As Integer = 0

    '            For Each dc In dtExcel.Columns
    '                colIndex = colIndex + 1
    '                excel.Cells(1, colIndex) = dc.ColumnName
    '            Next


    '            wSheet.Columns.AutoFit()
    '            wBook.SaveAs(strFile)
    '            wBook.Close()
    '            Process.Start(ruta + ".xlsx")
    '            'myStream.Close()
    '            'End If
    '        End If
    '    Catch ex As Exception
    '        'MessageBox.Show("there was an issue Exporting to Excel" & ex.ToString)
    '    End Try


    'End Sub

    Private Sub btnImportar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImportar.ItemClick
        OpenFileDialog1.Filter = "Excel |*.xlsx"
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            Dim path As String = OpenFileDialog1.FileName
            Try
                Dim workbook As Spire.Xls.Workbook = New Spire.Xls.Workbook
                workbook.LoadFromFile(path)
                Dim sheet As Spire.Xls.Worksheet = workbook.Worksheets(0)
                Me.GridControl2.DataSource = sheet.ExportDataTable
                Me.btnImportar.Enabled = False
                'Me.GridView2.defaulc

            Catch ex As Exception
                MessageBox.Show("Error al importar Data", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub


    'Private Sub cargarExcel()

    '    Dim myFileDialog As New OpenFileDialog()
    '    Dim xSheet As String = ""

    '    With myFileDialog
    '        .Filter = "Excel Files |*.xlsx"
    '        .Title = "Open File"
    '        .ShowDialog()
    '    End With
    '    If myFileDialog.FileName.ToString <> "" Then
    '        Dim ExcelFile As String = myFileDialog.FileName.ToString

    '        Dim ds As New DataSet
    '        Dim da As OleDbDataAdapter
    '        Dim dt As DataTable
    '        Dim conn As OleDbConnection

    '        xSheet = "Hoja1" ''InputBox("Digite el nombre de la Hoja que desea importar", "Complete")
    '        conn = New OleDbConnection(
    '                          "Provider=Microsoft.ACE.OLEDB.12.0;" &
    '                          "data source=" & ExcelFile & "; " &
    '                         "Extended Properties='Excel 12.0 Xml;HDR=Yes'")

    '        Try
    '            da = New OleDbDataAdapter("SELECT * FROM  [" & xSheet & "$]", conn)

    '            conn.Open()
    '            da.Fill(ds, "MyData")
    '            dt = ds.Tables("MyData")
    '            GridControl2.DataSource = ds
    '            GridControl2.DataMember = "MyData"


    '            MsgBox("Se ha cargado la importacion correctamente", MsgBoxStyle.Information, "Importado con exito")
    '        Catch ex As Exception
    '            MsgBox("Inserte un nombre valido de la Hoja que desea importar", MsgBoxStyle.Information, "Informacion")
    '        Finally
    '            conn.Close()
    '        End Try
    '    End If

    'End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnActualizarInformacion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnActualizarInformacion.ItemClick
        If ValidarColumna() Then
            Cursor = Cursors.WaitCursor
            If ValidaRowsRegistros() Then
                Dim dtNoUpdate As New DataTable
                dtNoUpdate.Columns.Add("MATRICULA")
                dtNoUpdate.Columns.Add("BASEDATO")
                Dim queryadryan As String = ""
                Dim queryupd As String = ""
                Dim querycampo As String = ""
                Dim queryupdcentral As String = ""
                Dim querycampocentral As String = ""
                Dim nombrecampocentral As String = ""
                Dim valorcodigobancopropietario As String = ""
                Dim valor As String = ""
                For i As Integer = 0 To GridView2.RowCount - 1
                    queryupd = "UPDATE TRABAJADOR SET "
                    queryupdcentral = "UPDATE MC_EMPLEADO SET "
                    For J As Integer = 0 To GridView2.Columns.Count - 1
                        Dim nameColum As String = Replace(GridView2.Columns.Item(J).Name, "col", "").Trim
                        Dim campo As String = GridView2.GetRowCellValue(i, nameColum)
                        If campo.ToString.Length > 0 Then
                            If nameColum <> "MATRICULA" Then
                                querycampo = querycampo + GridView2.Columns(nameColum).GetTextCaption + "='" + GridView2.GetRowCellValue(i, nameColum).ToString() + "',"
                            End If
                            If nameColum <> "MATRICULA" And nameColum <> "COMPANIA" Then
                                '------------------CUENTA ABONO---------------------------------
                                If nameColum = "CODIGO_BANCO_ABONO" Then
                                    nombrecampocentral = "CODIGOBANCOPROPIETARIODEPOSITO"

                                ElseIf nameColum = "CODIGO_BANCO_ENVIO_ABONO" Then
                                    nombrecampocentral = "IDBANCO"
                                    If BDAccionPersonalDAO.DameIDBancoCemtral(GridView2.GetRowCellValue(i, nameColum)) > 0 Then
                                        valor = BDAccionPersonalDAO.DameIDBancoCemtral(GridView2.GetRowCellValue(i, nameColum))
                                    End If

                                ElseIf nameColum = "NUMERO_CUENTA_ABONO" Then
                                    nombrecampocentral = "CUENTAABONO"
                                ElseIf nameColum = "TIPO_CUENTA" Then
                                    nombrecampocentral = "IDTIPOCUENTAABONO"
                                    If BDAccionPersonalDAO.DameIDTipoCuenta(GridView2.GetRowCellValue(i, nameColum)) <> "" Then
                                        valor = BDAccionPersonalDAO.DameIDTipoCuenta(GridView2.GetRowCellValue(i, nameColum))
                                    End If
                                ElseIf nameColum = "TIPO_REMUNERACION" Then
                                    nombrecampocentral = "CODIGOTIPOREMUNERACION"
                                    '------------------CUENTA ABONO CTS---------------------------------
                                ElseIf nameColum = "INSTITUCION_FINANCIERA" Then
                                    nombrecampocentral = "INSTITUCIONFINANCIERACTS"
                                ElseIf nameColum = "TIPO_CUENTA_CTS" Then
                                    nombrecampocentral = "TIPOCUENTACTS"
                                ElseIf nameColum = "INSTITUCION_FINANCIERA_ENVIO" Then
                                    nombrecampocentral = "INSTITUCIONFINANCIERAENVIOCTS"
                                ElseIf nameColum = "NUMERO_CUENTA_CTS" Then
                                    nombrecampocentral = "NUMEROCUENTACTS"
                                End If
                                If nameColum = "CODIGO_BANCO_ENVIO_ABONO" Then
                                    querycampocentral = querycampocentral + nombrecampocentral + "=" + valor + ","
                                ElseIf nameColum = "TIPO_CUENTA" Then
                                    querycampocentral = querycampocentral + nombrecampocentral + "='" + valor + "',"
                                Else
                                    If nameColum <> "TIPO_MONEDA" Then
                                        querycampocentral = querycampocentral + nombrecampocentral + "='" + GridView2.GetRowCellValue(i, nameColum).ToString() + "',"
                                    End If
                                End If
                            End If
                        End If
                    Next
                    queryupd = queryupd + querycampo.Substring(0, Len(querycampo) - 1) + " where matricula = '" + GridView2.GetRowCellValue(i, "MATRICULA").ToString() + "'"
                    queryupdcentral = queryupdcentral + querycampocentral.Substring(0, Len(querycampocentral) - 1) + " where matricula = '" + GridView2.GetRowCellValue(i, "MATRICULA").ToString() + "'"

                    If BDAccionPersonalDAO.UpdataNumeroCuentasAdryan(queryupd) Then
                        If Not BDAccionPersonalDAO.UpdataNumeroCuentasCentral(queryupdcentral) Then
                            dtNoUpdate.Rows.Add(GridView2.GetRowCellValue(i, "MATRICULA"), "RRHH")
                        End If
                    Else
                        dtNoUpdate.Rows.Add(GridView2.GetRowCellValue(i, "MATRICULA"), "ADRYAN-RRHH")
                    End If
                    querycampo = ""
                    querycampocentral = ""
                Next
                If dtNoUpdate.Rows.Count > 0 Then
                    GridControl1.DataSource = dtNoUpdate
                End If
                'dtNoUpdate.Columns
            End If
            btnActualizarInformacion.Enabled = False
            Cursor = Cursors.Default
        End If
    End Sub
    Private Function ValidarColumna() As Boolean
        Dim Result As Boolean = True
        Dim rbo As Int32
        Dim nameGrida As String
        Dim name As String
        Dim resulColumna As Int32
        Dim dtColumna As DataTable
        If rboSueldo.Checked Then
            rbo = 1
        End If
        If rboCts.Checked Then
            rbo = 2
        End If

        dtColumna = BDAccionPersonalDAO.CargaMasivaCampos(rbo)
        If dtColumna.Rows.Count <> GridView2.Columns.Count Then
            MessageBox.Show("El numero de columnas no es el correcto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Result = False
        End If
        If Result Then
            For i As Int32 = 0 To GridView2.Columns.Count - 1
                nameGrida = GridView2.Columns.Item(i).Name
                name = Replace(nameGrida, "col", "").Trim
                resulColumna = 0
                For j As Int32 = 0 To dtColumna.Rows.Count - 1
                    Dim columnadb As String = dtColumna.Rows(j)("DESCRIPCION")
                    If name = columnadb Then
                        resulColumna = 1
                        Exit For
                    Else
                        resulColumna = 0
                    End If
                Next
                If resulColumna = 0 Then
                    MessageBox.Show("El nombre de la columna " & name & " es errada, por favor digitar el nombre de la columna correcta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Result = False
                End If
            Next
        End If
        Return Result
    End Function

    Private Function ValidaRowsRegistros() As Boolean
        Dim Resul As Boolean = True
        Dim rbo As Int32
        If rboSueldo.Checked Then
            rbo = 1
        End If
        If rboCts.Checked Then
            rbo = 2
        End If
        If GridView2.RowCount > 0 Then
            Dim dtCodigoBancoAbono As DataTable
            Dim dtTipoCuenta As DataTable
            Dim dtTipoMoneda As DataTable
            Dim dtColumna As DataTable
            Dim nameGrida As String
            Dim name As String
            dtCodigoBancoAbono = BDAccionPersonalDAO.GetBancoCtsList ''CODIGO_BANCO_ENVIO_ABONO es el mismo listado (misma tabla)
            dtTipoCuenta = BDAccionPersonalDAO.GetTipoCuentaAbonoList
            dtTipoMoneda = BDAccionPersonalDAO.GetMonedaList
            dtColumna = BDAccionPersonalDAO.CargaMasivaCampos(rbo)
            For i As Int32 = 0 To GridView2.Columns.Count - 1
                nameGrida = GridView2.Columns.Item(i).Name
                name = Replace(nameGrida, "col", "").Trim
                For j As Int32 = 0 To dtColumna.Rows.Count - 1
                    Dim columnadb As String = dtColumna.Rows(j)("DESCRIPCION")
                    Dim columnabdid As String = dtColumna.Rows(j)("IDCAMPOMASIVO")
                    If name = columnadb Then
                        If columnabdid = 1 Then ''MATRICULA
                            Dim numericomatricula As String
                            For matricula As Integer = 0 To GridView2.RowCount - 1
                                numericomatricula = (GridView2.GetRowCellValue(matricula, name)).ToString.Trim
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
                                    If BDAccionPersonalDAO.ConsultaMatriculaEmpleadoExistente(numericomatricula) = "" Then
                                        MessageBox.Show("la matricula nª " & numericomatricula & " no existe, por favor volver a ingresar la matricula correcta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Resul = False
                                        Exit Function
                                    End If

                                Else
                                        MessageBox.Show("Existen registros en la columna MATRICULA que se encuentran vacios, por favor volver a carga la informacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    Resul = False
                                    Exit Function
                                End If

                            Next
                        ElseIf columnabdid = 2 Then ''COMPANIA
                            Dim numerocompania As String
                            For compania As Integer = 0 To GridView2.RowCount - 1
                                numerocompania = (GridView2.GetRowCellValue(compania, name)).ToString.Trim
                                If numerocompania <> "" Or numerocompania IsNot Nothing Then
                                    If Not IsNumeric(numerocompania) Then
                                        MessageBox.Show("El nª de compañia " & numerocompania & " tiene que ser numerico", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Resul = False
                                        Exit Function
                                    End If
                                    If numerocompania.Length <> 2 Then
                                        MessageBox.Show("La compañia nª " & numerocompania & " tiene que ser de 2 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Resul = False
                                        Exit Function
                                    End If
                                    If numerocompania <> "01" Then
                                        MessageBox.Show("La compañia nª " & numerocompania & " no existe, ingrese el nª de compañia correto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Resul = False
                                        Exit Function
                                    End If
                                Else
                                    MessageBox.Show("Existen registros en la columna COMPANIA que se encuentran vacios, por favor volver a carga la informacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    Resul = False
                                    Exit Function
                                End If
                            Next

                        ElseIf columnabdid = 3 Then ''CODIGO_BANCO_ABONO
                            Dim numerocodigocuentaabono As String
                            Dim estadodata1 As Int32 = 0
                            For codigocuentaabono As Integer = 0 To GridView2.RowCount - 1
                                numerocodigocuentaabono = (GridView2.GetRowCellValue(codigocuentaabono, name)).ToString.Trim
                                If numerocodigocuentaabono <> "" Or numerocodigocuentaabono IsNot Nothing Then
                                    If Not IsNumeric(numerocodigocuentaabono) Then
                                        MessageBox.Show("El codigo banco abono " & numerocodigocuentaabono & " tiene que ser numerico", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Resul = False
                                        Exit Function
                                    End If
                                    If numerocodigocuentaabono.Length <> 2 Then
                                        MessageBox.Show("El codigo banco abono " & numerocodigocuentaabono & " tiene que ser de 2 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Resul = False
                                        Exit Function
                                    End If
                                    For data1 As Int32 = 0 To dtCodigoBancoAbono.Rows.Count - 1
                                        If dtCodigoBancoAbono.Rows(data1)("CODIGO").ToString() = numerocodigocuentaabono.Trim Then
                                            estadodata1 = 1
                                            Exit For
                                        Else
                                            estadodata1 = 0
                                        End If
                                    Next
                                    If estadodata1 = 0 Then
                                        MessageBox.Show("El codigo banco abono " & numerocodigocuentaabono & " es incorrecto, por favor ingrese el codigo correcto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Resul = False
                                        Exit Function
                                    End If
                                Else
                                    MessageBox.Show("Existen registros en la columna CODIGO_BANCO_ABONO que se encuentran vacios, por favor volver a carga la informacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    Resul = False
                                    Exit Function
                                End If
                            Next
                        ElseIf columnabdid = 4 Then ''CODIGO_BANCO_ENVIO_ABONO
                            Dim numerocodigocuentaabonoenvio As String
                            Dim estadodata2 As Int32 = 0
                            For codigocuentaabonoenvio As Integer = 0 To GridView2.RowCount - 1
                                numerocodigocuentaabonoenvio = (GridView2.GetRowCellValue(codigocuentaabonoenvio, name)).ToString.Trim
                                If numerocodigocuentaabonoenvio <> "" Or numerocodigocuentaabonoenvio IsNot Nothing Then
                                    If Not IsNumeric(numerocodigocuentaabonoenvio) Then
                                        MessageBox.Show("El CODIGO_BANCO_ENVIO_ABONO " & numerocodigocuentaabonoenvio & " tiene que ser numerico", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Resul = False
                                        Exit Function
                                    End If
                                    If numerocodigocuentaabonoenvio.Length <> 2 Then
                                        MessageBox.Show("El CODIGO_BANCO_ENVIO_ABONO " & numerocodigocuentaabonoenvio & " tiene que ser de 2 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Resul = False
                                        Exit Function
                                    End If
                                    For data2 As Int32 = 0 To dtCodigoBancoAbono.Rows.Count - 1
                                        If dtCodigoBancoAbono.Rows(data2)("CODIGO").ToString() = numerocodigocuentaabonoenvio.Trim Then
                                            estadodata2 = 1
                                            Exit For
                                        Else
                                            estadodata2 = 0
                                        End If
                                    Next
                                    If estadodata2 = 0 Then
                                        MessageBox.Show("El codigo banco abono " & numerocodigocuentaabonoenvio & " es incorrecto, por favor ingrese el codigo correcto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Resul = False
                                        Exit Function
                                    End If
                                Else
                                    MessageBox.Show("Existen registros en la columna CODIGO_BANCO_ENVIO_ABONO que se encuentran vacios, por favor volver a carga la informacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    Resul = False
                                    Exit Function
                                End If
                            Next
                        ElseIf columnabdid = 5 Then ''NUMERO_CUENTA_ABONO
                            Dim numerocuentaabono As String
                            For cuentaabono As Integer = 0 To GridView2.RowCount - 1
                                numerocuentaabono = (GridView2.GetRowCellValue(cuentaabono, name)).ToString.Trim
                                If numerocuentaabono <> "" Or numerocuentaabono IsNot Nothing Then
                                    If Not IsNumeric(numerocuentaabono) Then
                                        MessageBox.Show("el numero cuenta abono nª" & numerocuentaabono & " tiene que ser numerico", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Resul = False
                                        Exit Function
                                    End If
                                Else
                                    MessageBox.Show("Existen registros en la columna NUMERO_CUENTA_ABONO que se encuentran vacios, por favor volver a carga la informacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    Resul = False
                                    Exit Function
                                End If
                            Next

                        ElseIf columnabdid = 6 Then ''TIPO_CUENTA
                            Dim numerotipocuenta As String
                            Dim estadodata3 As Int32 = 0
                            For tipocuenta As Integer = 0 To GridView2.RowCount - 1
                                numerotipocuenta = (GridView2.GetRowCellValue(tipocuenta, name)).ToString.Trim
                                If numerotipocuenta <> "" Or numerotipocuenta IsNot Nothing Then
                                    If Not IsNumeric(numerotipocuenta) Then
                                        MessageBox.Show("el tipo de cuenta" & numerotipocuenta & " tiene que ser numerico", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Resul = False
                                        Exit Function
                                    End If
                                    For data3 As Int32 = 0 To dtTipoCuenta.Rows.Count - 1
                                        If dtTipoCuenta.Rows(data3)("CODIGOADRYAN").ToString() = numerotipocuenta.Trim Then
                                            estadodata3 = 1
                                            Exit For
                                        Else
                                            estadodata3 = 0
                                        End If
                                    Next
                                    If estadodata3 = 0 Then
                                        MessageBox.Show("El tipo de cuenta nª " & numerotipocuenta & " es incorrecto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Resul = False
                                        Exit Function
                                    End If

                                Else
                                    MessageBox.Show("Existen registros en la columna TIPO_CUENTA que se encuentran vacios, por favor volver a carga la informacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    Resul = False
                                    Exit Function
                                End If
                            Next
                        ElseIf columnabdid = 7 Then ''TIPO_MONEDA
                            Dim numerotipomoneda As String
                            For tipomoneda As Integer = 0 To GridView2.RowCount - 1
                                numerotipomoneda = (GridView2.GetRowCellValue(tipomoneda, name)).ToString.Trim
                                If numerotipomoneda <> "" Then
                                    If numerotipomoneda = "S" Or numerotipomoneda = "D" Then
                                    Else
                                        MessageBox.Show("El tipo de moneda " & numerotipomoneda & " es incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Resul = False
                                        Exit Function
                                    End If
                                Else
                                    MessageBox.Show("Existen registros en la columna TIPO_MONEDA que se encuentran vacios, por favor volver a carga la informacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    Resul = False
                                    Exit Function
                                End If
                            Next
                        ElseIf columnabdid = 8 Then ''TIPO_REMUNERACION
                            Dim numerotiporemuneracion As String

                            For tiporemuneracion As Integer = 0 To GridView2.RowCount - 1
                                numerotiporemuneracion = (GridView2.GetRowCellValue(tiporemuneracion, name)).ToString.Trim
                                If numerotiporemuneracion <> "" Or numerotiporemuneracion IsNot Nothing Then
                                    If Not numerotiporemuneracion = "0" Then
                                        MessageBox.Show("El tipo de remuneracion " & numerotiporemuneracion & " es incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Resul = False
                                        Exit Function
                                    End If
                                Else
                                    MessageBox.Show("Existen registros en la columna TIPO_REMUNERACION que se encuentran vacios, por favor volver a carga la informacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    Resul = False
                                    Exit Function
                                End If
                            Next
                        ElseIf columnabdid = 9 Then ''INSTITUCION_FINANCIERA
                            Dim numeroinstitucionfinanciera As String
                            Dim estadodata4 As Int32 = 0
                            For institucionfinanciera As Integer = 0 To GridView2.RowCount - 1
                                numeroinstitucionfinanciera = (GridView2.GetRowCellValue(institucionfinanciera, name)).ToString.Trim
                                If numeroinstitucionfinanciera <> "" Or numeroinstitucionfinanciera IsNot Nothing Then
                                    If Not IsNumeric(numeroinstitucionfinanciera) Then
                                        MessageBox.Show("La institucion financiera" & numeroinstitucionfinanciera & " tiene que ser numerico", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Resul = False
                                        Exit Function
                                    End If
                                    If numeroinstitucionfinanciera.Length <> 2 Then
                                        MessageBox.Show("La institucion financiera " & numeroinstitucionfinanciera & " tiene que ser de 2 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Resul = False
                                        Exit Function
                                    End If
                                    For data1 As Int32 = 0 To dtCodigoBancoAbono.Rows.Count - 1
                                        If dtCodigoBancoAbono.Rows(data1)("CODIGO").ToString() = numeroinstitucionfinanciera.Trim Then
                                            estadodata4 = 1
                                            Exit For
                                        Else
                                            estadodata4 = 0
                                        End If
                                    Next
                                    If estadodata4 = 0 Then
                                        MessageBox.Show("La institucion financiera " & numeroinstitucionfinanciera & " es incorrecto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Resul = False
                                        Exit Function
                                    End If

                                Else
                                    MessageBox.Show("Existen registros en la columna INSTITUCION_FINANCIERA que se encuentran vacios, por favor volver a carga la informacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    Resul = False
                                    Exit Function
                                End If
                            Next
                        ElseIf columnabdid = 10 Then ''TIPO_CUENTA_CTS
                            Dim numerotipocuentacts As String
                            For tipocuentacts As Integer = 0 To GridView2.RowCount - 1
                                numerotipocuentacts = (GridView2.GetRowCellValue(tipocuentacts, name)).ToString.Trim
                                If numerotipocuentacts <> "" Or numerotipocuentacts IsNot Nothing Then
                                    If numerotipocuentacts = "S" Or numerotipocuentacts = "D" Then
                                    Else
                                        MessageBox.Show("El tipo de cuenta cts " & numerotipocuentacts & " es incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Resul = False
                                        Exit Function
                                    End If
                                Else
                                    MessageBox.Show("Existen registros en la columna IPO_CUENTA_CTS que se encuentran vacios, por favor volver a carga la informacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    Resul = False
                                    Exit Function
                                End If
                            Next
                        ElseIf columnabdid = 11 Then ''INSTITUCION_FINANCIERA_ENVIO
                            Dim numeroinstitucionfinancieraenvio As String
                            Dim estadodata5 As Int32 = 0
                            For institucionfinancieraenvio As Integer = 0 To GridView2.RowCount - 1
                                numeroinstitucionfinancieraenvio = (GridView2.GetRowCellValue(institucionfinancieraenvio, name)).ToString.Trim
                                If numeroinstitucionfinancieraenvio <> "" Or numeroinstitucionfinancieraenvio IsNot Nothing Then
                                    If Not IsNumeric(institucionfinancieraenvio) Then
                                        MessageBox.Show("La Institución Financiera Envio " & institucionfinancieraenvio & " tiene que ser numerico", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Resul = False
                                        Exit Function
                                    End If
                                    If numeroinstitucionfinancieraenvio.Length <> 2 Then
                                        MessageBox.Show("La Institución Financiera Envio " & numeroinstitucionfinancieraenvio & " tiene que ser de 2 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Resul = False
                                        Exit Function
                                    End If
                                    For data1 As Int32 = 0 To dtCodigoBancoAbono.Rows.Count - 1
                                        If dtCodigoBancoAbono.Rows(data1)("CODIGO").ToString() = numeroinstitucionfinancieraenvio.Trim Then
                                            estadodata5 = 1
                                            Exit For
                                        Else
                                            estadodata5 = 0
                                        End If
                                    Next
                                    If estadodata5 = 0 Then
                                        MessageBox.Show("La institucion financiera " & numeroinstitucionfinancieraenvio & " es incorrecto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Resul = False
                                        Exit Function
                                    End If
                                Else
                                    MessageBox.Show("Existen registros en la columna INSTITUCION_FINANCIERA_ENVIO que se encuentran vacios, por favor volver a carga la informacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    Resul = False
                                    Exit Function
                                End If
                            Next
                        ElseIf columnabdid = 12 Then ''NUMERO_CUENTA_CTS
                            Dim numerocuentaacts As String
                            For cuentacts As Integer = 0 To GridView2.RowCount - 1
                                numerocuentaacts = (GridView2.GetRowCellValue(cuentacts, name)).ToString.Trim
                                If numerocuentaacts <> "" Or numerocuentaacts IsNot Nothing Then
                                    If Not IsNumeric(numerocuentaacts) Then
                                        MessageBox.Show("el numero cuenta CTS nª " & numerocuentaacts & " tiene que ser numerico", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Resul = False
                                        Exit Function
                                    End If
                                Else
                                    MessageBox.Show("Existen registros en la columna NUMERO_CUENTA_CTS que se encuentran vacios, por favor volver a carga la informacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    Resul = False
                                    Exit Function
                                End If
                            Next
                        End If
                    End If
                Next
            Next

        Else
            MessageBox.Show("No cuenta con registros de actualización", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Resul = False
        End If
        Return Resul
    End Function

    Private Sub rboSueldo_CheckedChanged(sender As Object, e As ItemClickEventArgs) Handles rboSueldo.CheckedChanged
        If rboSueldo.Checked Then
            rboCts.Checked = False
            rboSueldo.Checked = True
        End If

    End Sub

    Private Sub rboCts_CheckedChanged(sender As Object, e As ItemClickEventArgs) Handles rboCts.CheckedChanged
        If rboCts.Checked Then
            rboSueldo.Checked = False
            rboCts.Checked = True
        End If
    End Sub

    'Private Sub BarButtonItem1_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem1.ItemClick
    'Dim rbo As Int32
    'Dim tipo As String = ""
    'Dim dt As DataTable
    'If rboSueldo.Checked Then
    '    rbo = 1
    '    tipo = "Cuenta Sueldo"
    'End If
    'If rboCts.Checked Then
    '    rbo = 2
    '    tipo = "Cuenta Cts"
    'End If

    'dt = BDAccionPersonalDAO.CargaMasivaCampos(rbo)
    'For column As Int32 = 0 To dt.Rows.Count - 1
    '    dtNoUpdate.Columns.Add(dt.Rows(column)("DESCRIPCION"))
    'Next

    'Dim blook As Spire.Xls.Workbook = New Spire.Xls.Workbook
    'Dim sheet As Spire.Xls.Worksheet = blook.Worksheets(0)
    ''sheet.Workbook.Worksheets.Add(tipo)

    'sheet.InsertDataTable(dtNoUpdate, True, 1, 1)
    'Dim ruta As String
    'ruta = My.Application.Info.DirectoryPath() + "\" + tipo + ".xlsx"
    'Try
    '    blook.SaveToFile(ruta, ExcelVersion.Version2016)
    '    Process.Start(ruta)
    'Catch ex As Exception
    '    MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
    'End Try
    'End Sub

End Class