Imports System.ComponentModel
Imports System.Drawing.Printing
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports MC.Data
Imports MC.Framework
Public Class EmpleadoRenovacionContratoList
    Dim bsRenovacionContrato As New BindingSource
    Dim bsPorCesar As New BindingSource
    Dim RenovacionContratoBE As New RenovacionContratoBE

    Sub New()


        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDRENOVACIONCONTRATODETALLE", "IDRENOVACIONCONTRATODETALLE", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "RENOVAR", "ASIGNARRENOVACION", 80, True, ControlesDevExpress.eGridViewFormato.Checked, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ENVIO CORREO FIRMA", "ESTADOENVIOCORREOFIRMA", 130, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA FINAL CONTRATO", "FECHAFINALCONTRATO", 150, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° MES A RENOVAR", "NUMEROMESESRENOVAR", 120, True, ControlesDevExpress.eGridViewFormato.Numero, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA INICIO CONTRATO NUEVO", "FECHAINICIALCONTRATONUEVO", 170, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA FINAL CONTRATO NUEVO", "FECHAFINALCONTRATONUEVA", 170, True, ControlesDevExpress.eGridViewFormato.Fecha, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBRES", "NOMBRES", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "APELLIDO PATERNO", "APELLIDOPATERNO", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "APELLIODO MATERNO", "APELLIDOMATERNO", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DOCUMENTO", "NUMERODOCUMENTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO", "CARGO", 240, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 280, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 280, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RUC LOCAL", "IDTRIBUTARIO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO VALIDADO", "ESTADOVALIDADO", 120, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO VALIDADO GENERAL", "ESTADOVALIDADOGENERAL", 150, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDEMPLEADO", "IDEMPLEADO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CODIGOUNICO", "CODIGOUNICO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDLOCAL", "IDLOCAL", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDORGANIGRAMA", "IDORGANIGRAMA", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDSITIO", "IDSITIO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDRENOVACIONCONTRATO", "IDRENOVACIONCONTRATO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridView1
            .Columns("ESTADOENVIOCORREOFIRMA").OptionsFilter.AllowAutoFilter = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAFINALCONTRATONUEVA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAFINALCONTRATO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOMBRES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOPATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOMATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CARGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("IDTRIBUTARIO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("ESTADOVALIDADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        '----------------------
        ControlesDevExpress.InitGridControl(GridControl2)
        ControlesDevExpress.InitGridViewColumn(GridView2, "IDRENOVACIONCONTRATODETALLE", "IDRENOVACIONCONTRATODETALLE", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "NUMERO SOLICITUD", "NUMEROSOLICITUDCESE", 170, True, ControlesDevExpress.eGridViewFormato.Fecha, True)
        ControlesDevExpress.InitGridViewColumn(GridView2, "FECHAFINALCONTRATO", "FECHAFINALCONTRATO", 120, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "NOMBRES", "NOMBRES", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "APELLIDO PATERNO", "APELLIDOPATERNO", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "APELLIODO MATERNO", "APELLIDOMATERNO", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "N° DOCUMENTO", "NUMERODOCUMENTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "CARGO", "CARGO", 240, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "RAZON COMERCIAL", "RAZONCOMERCIAL", 280, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "RAZON SOCIAL", "RAZONSOCIAL", 280, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "RUC LOCAL", "IDTRIBUTARIO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "ESTADOVALIDADO", "ESTADOVALIDADO", 240, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "IDEMPLEADO", "IDEMPLEADO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "CODIGOUNICO", "CODIGOUNICO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridView2
            .Columns("FECHAFINALCONTRATO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOMBRES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOPATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOMATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CARGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("IDTRIBUTARIO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("ESTADOVALIDADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        '-------------------
        btnFechainicial.EditValue = DateTime.Now.Date
        btnFechaFinal.EditValue = DateTime.Now.Date.AddDays(+30)

        AddHandler btnFechaFinal.EditValueChanged, AddressOf Refrescar
        AddHandler btnRefrescar.ItemClick, AddressOf Refrescar

        Me.GridControl1.DataSource = bsRenovacionContrato
        Me.GridControl2.DataSource = bsPorCesar


        btnAsignarListadoRenovacion.Visibility = BarItemVisibility.Never
        Refrescar()
    End Sub
    Private Sub Refrescar()
        Try
            btnExportar.Visibility = BarItemVisibility.Never
            btnEnvioCorreoFirmaContrato.Visibility = BarItemVisibility.Never
            btnGenerarRenovacion.Visibility = BarItemVisibility.Never
            btnImprimirContrato.Visibility = BarItemVisibility.Never
            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(RibbonControl, dtAccionesUsuario)
            chkSeleccionar.Checked = False
            bsRenovacionContrato.DataSource = RenovacionContratoDAO.GetEmpleadoRenovacionxRenovarAsignadosList(btnFechainicial.EditValue, btnFechaFinal.EditValue, 0)
            bsPorCesar.DataSource = RenovacionContratoDAO.GetEmpleadoRenovacionxCesarList(btnFechainicial.EditValue, btnFechaFinal.EditValue)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub
    Private Sub EmpleadoRenovacionContratoList_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub
    Private Sub btnGenerarRenovacion_ItemClick_1(sender As Object, e As ItemClickEventArgs) Handles btnGenerarRenovacion.ItemClick
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()

        'GridView1.ClearColumnsFilter()
        'GridView1.FindFilterText = ""
        Dim row As Integer = GridView1.RowCount

        If MessageBox.Show("Esta seguro de procesar renovaciones de contrato", "Procesar renovación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Dim xIdEmpleado As Integer
            Dim xFechaFinalContrato As Date
            Dim xFechaFinalContratoNuevo As Date
            Dim xCodigoUnico As String
            Dim xNombre As String
            Dim xApellidoPaterno As String
            Dim xApellidoMaterno As String
            Dim xEmpleado As String
            Dim xUltimoNumeroContrato As String

            Cursor = Cursors.WaitCursor
            For j As Integer = 0 To GridView1.RowCount - 1

                Dim ESTADOASIGNACION As Boolean
                Dim IDRENOVACIONDETALLE As Integer
                'Dim ESTADOENVIOCORREO As Boolean
                Dim ESTADOVALIDADO As Boolean
                Dim ESTADOVALIDADOGENERAL As Boolean
                IDRENOVACIONDETALLE = (GridView1.GetRowCellValue(j, "IDRENOVACIONCONTRATODETALLE"))
                ESTADOASIGNACION = (GridView1.GetRowCellValue(j, "ASIGNARRENOVACION"))
                'ESTADOENVIOCORREO = GridView1.GetRowCellValue(j, "ESTADOENVIOCORREOFIRMA")
                ESTADOVALIDADO = (GridView1.GetRowCellValue(j, "ESTADOVALIDADO"))
                ESTADOVALIDADOGENERAL = (GridView1.GetRowCellValue(j, "ESTADOVALIDADOGENERAL"))


                'If ESTADOASIGNACION And ESTADOVALIDADO And ESTADOVALIDADOGENERAL Then
                If ESTADOASIGNACION And ESTADOVALIDADO Then
                    xUltimoNumeroContrato = RenovacionContratoDAO.GetObtenerUltimoContrato()
                    If xUltimoNumeroContrato = "" Then
                        MessageBox.Show("Problemas de Conexión con el sistema Adryan", "Error de Conexión")
                        Cursor = Cursors.Default
                        Exit Sub
                    End If
                    xIdEmpleado = GridView1.GetRowCellValue(j, "IDEMPLEADO")
                    xFechaFinalContrato = GridView1.GetRowCellValue(j, "FECHAFINALCONTRATO")
                    xFechaFinalContratoNuevo = GridView1.GetRowCellValue(j, "FECHAFINALCONTRATONUEVA") 'FECHAFINALCONTRATONUEVA
                    xCodigoUnico = GridView1.GetRowCellValue(j, "CODIGOUNICO")
                    xNombre = GridView1.GetRowCellValue(j, "NOMBRES")
                    xApellidoPaterno = GridView1.GetRowCellValue(j, "APELLIDOPATERNO")
                    xApellidoMaterno = GridView1.GetRowCellValue(j, "APELLIDOMATERNO")
                    xEmpleado = xNombre + " " + xApellidoPaterno + " " + xApellidoMaterno

                    Dim resutCentral As Int32 = RenovacionContratoDAO.GetIdEstadoEmpleadoCentral(xIdEmpleado)
                    Dim resutAdryan As String = RenovacionContratoDAO.GetIdEstadoEmpleadoAdryan(xCodigoUnico)
                    If resutCentral = 1 And resutAdryan = "A" Then
                        If Convert.ToDateTime(xFechaFinalContratoNuevo) > Convert.ToDateTime(xFechaFinalContrato) Then
                            'CREA RENOVACION EN ADRYAN
                            If RenovacionContratoDAO.InsertaEmpleadoContratoAdryan(xCodigoUnico, xUltimoNumeroContrato, xFechaFinalContrato, xFechaFinalContratoNuevo) Then
                                'CREA RENOVACION MC_CENTRAL
                                RenovacionContratoDAO.InsertaEmpleadoContratoCentral(xIdEmpleado, IDRENOVACIONDETALLE, xUltimoNumeroContrato, xFechaFinalContratoNuevo, BDCentralDAO.UsuarioBE.IDUsuario)
                            Else
                                MessageBox.Show("Problemas de Conexión con el sistema Adryan", "Error de Conexión")
                                Cursor = Cursors.Default
                                Exit Sub
                            End If
                        Else
                            MessageBox.Show("La fecha de renovación del empleado " & xEmpleado & " no puede ser menor a la fecha fin de contrato")
                            Exit Sub
                        End If
                    Else
                        MessageBox.Show("El colaborador " & xEmpleado & " se encuetra cesado")
                    End If
                End If
            Next
            Refrescar()
        End If

        Cursor = Cursors.Default

    End Sub

    'Private Sub GridView1_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanged
    '    Dim estadocorreo As Boolean = GridView1.GetRowCellValue(e.RowHandle, "ESTADOENVIOCORREOFIRMA")
    '    Dim idrenovaciondetalle As Integer = GridView1.GetRowCellValue(e.RowHandle, "IDRENOVACIONCONTRATODETALLE")
    '    Dim numeromeses As Integer = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "NUMEROMESESRENOVAR")

    '    Dim nuevafecha As Date = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAFINALCONTRATO")
    '    Dim nuevo As Date = DateSerial(Year(nuevafecha), Month(nuevafecha) + numeromeses, nuevafecha.Date.Day)
    '    Dim fechafincontratonueva As Date = nuevo.AddDays(-1)

    '    If numeromeses = 0 Then

    '    End If

    '    With RenovacionContratoBE
    '        .FechaPeriodoFin = fechafincontratonueva
    '        .NumeroMesesRenovar = numeromeses
    '        .IdRenovacionDetalle = idrenovaciondetalle
    '    End With
    '    RenovacionContratoDAO.UpdateFechaFinContratoNueva(RenovacionContratoBE)
    '    Refrescar()
    'End Sub
    'Private Sub GridView1_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanged
    '    Dim estadocorreo As Boolean = GridView1.GetRowCellValue(e.RowHandle, "ESTADOENVIOCORREOFIRMA")
    '    Dim idrenovaciondetalle As Integer = GridView1.GetRowCellValue(e.RowHandle, "IDRENOVACIONCONTRATODETALLE")
    '    Dim numeromeses As Integer = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "NUMEROMESESRENOVAR")
    '    Dim fechafinalcontrato As Date = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAFINALCONTRATO")
    '    Dim fechafinalcontratonueva As Date = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAFINALCONTRATONUEVA")
    '    Dim fechainiciocontratonuevo As Date = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAINICIALCONTRATONUEVO")

    '    Dim Renovacion = If(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ASIGNARRENOVACION").ToString = "False", 0, 1)



    '    If fechafinalcontratonueva <= fechafinalcontrato And numeromeses = 0 Then
    '        MessageBox.Show("La nueva fecha de renovación no puede ser menor a su fecha final de contrato", "Error Renovación Contrato", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Exit Sub
    '    Else

    '        With RenovacionContratoBE
    '            .IdRenovacionDetalle = idrenovaciondetalle
    '            .NumeroMesesRenovar = numeromeses
    '            .FechaPeriodoFin = fechafinalcontratonueva
    '        End With
    '    End If

    '    If numeromeses = 0 Then
    '        If RenovacionContratoDAO.UpdateFechaFinContratoNueva(RenovacionContratoBE, 1) Then ' 1 = ASIGNA FECHAS Y MESES A RENOVAR

    '        End If

    '    Else
    '        'If RenovacionContratoDAO.UpdateFechaFinContratoNueva(RenovacionContratoBE, 2) Then '2 = SOLO ASIGNA FECHAS MAS NO MESES A RENOVAR


    '        If fechainiciocontratonuevo.Day = "1" Then
    '            Dim nuevafecha As Date = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAFINALCONTRATO")
    '            Dim nuevo As Date = DateSerial(Year(nuevafecha), Month(nuevafecha) + numeromeses, nuevafecha.Date.Day)
    '            Dim fechafincontratonueva As Date = nuevo.AddDays(-1)
    '            Dim nombrecolumna = GridView1.Columns(5).Name
    '            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "FECHAFINALCONTRATONUEVA", fechafincontratonueva)
    '        End If

    '        'End If
    '    End If
    '    'If estadocorreo Then
    '    'RenovacionContratoDAO.AsignarRenovacionContratoEmpleado(idrenovaciondetalle, Renovacion)
    '    'End If
    '    'Refrescar()
    'End Sub

    'Private Sub btnEnvioCorreoTiempoRenovar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnEnvioCorreoTiempoRenovar.ItemClick

    '    If GridView1.RowCount > 0 Then
    '        If MessageBox.Show("¿Esta seguro de enviar correos?", "Envio Correo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then

    '            For i As Integer = 0 To GridView1.RowCount - 1
    '                Dim estadoenviocorreofima As Boolean
    '                estadoenviocorreofima = If(GridView1.GetRowCellValue(i, "ESTADOENVIOCORREOFIRMA").ToString = "False", 0, 1) ' agregar un campo mas en renovacióndetalle (estadoenvioperodorenovacion)
    '                If estadoenviocorreofima = 0 Then
    '                    Dim idlocal As Integer = GridView1.GetRowCellValue(i, "IDLOCAL")
    '                    Dim razoncomercial As String = GridView1.GetRowCellValue(i, "RAZONCOMERCIAL")
    '                    Dim idrenovacion As Integer = GridView1.GetRowCellValue(i, "IDRENOVACIONCONTRATO")

    '                    Dim dt As DataTable
    '                    dt = RenovacionContratoDAO.EmpleadosMismoLocalPorRenovarList(idlocal, idrenovacion) 'crear procedure para que ejecute solo (estadoenvioperodorenovacion) que esten en false(0)
    '                    Dim ListaEmpleados As String = ""
    '                    Dim ListaTodosEmpleados As String = ""
    '                    Dim Mensaje As String
    '                    'Dim nombresupervisor As String = dt.Rows(0).Item("")
    '                    'Dim corrreosupervisor As String = dt.Rows(0).Item("")
    '                    'Dim correocopia As String = dt.Rows(0).Item("")
    '                    'Dim emailTo As String = corrreosupervisor + "," + correocopia
    '                    For j As Integer = 0 To dt.Rows.Count - 1

    '                        ListaEmpleados = "<tr><td style=font-family:Calibri;font-size:15px>" & dt.Rows(j)("DNI") & "</td>" &
    '                                    "<td style=font-family:Calibri;font-size:15px>" & dt.Rows(j)("APELLIDOPATERNO") & "</td>" &
    '                                    "<td style=font-family:Calibri;font-size:15px>" & dt.Rows(j)("APELLIDOMATERNO") & "</td>" &
    '                                    "<td style=font-family:Calibri;font-size:15px>" & dt.Rows(j)("NOMBRES") & "</td>" &
    '                                    "<td style=font-family:Calibri;font-size:15px>" & dt.Rows(j)("CARGOEMPLEADO") & "</td>" &
    '                                    "<td style=font-family:Calibri;font-size:15px>" & dt.Rows(j)("RAZONSOCIAL") & "</td>" &
    '                                      "<td style=font-family:Calibri;font-size:15px>" & dt.Rows(j)("RAZONCOMERCIAL") & "</td></tr>"

    '                        ListaTodosEmpleados = ListaTodosEmpleados + ListaEmpleados
    '                    Next

    '                    Mensaje = "<font face=Calibri size=3> Estimado:  " & "Juan Perez" & "<br>" & "<br>" &
    '                                  "Por favor, indicar por cuánto tiempo se les va a renovar los contratos a los siguientes colaboradores." & "<br>" &
    '                                  "<table border=1 cellspacing=0 cellpadding=2>" &
    '                                  "<tr bgcolor='#E59866' align='center'> " &
    '                                  "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>DNI</td>" &
    '                                  "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>APELLIDO PATERNO</td>" &
    '                                  "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>APELLIDO MATERNO</td>" &
    '                                  "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>NOMBRES</td>" &
    '                                  "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>PUESTO</td>" &
    '                                  "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>RAZONCOMERCIAL</td>" &
    '                                   "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>RAZONCOMERCIAL</td>" &
    '                                  "</tr>" & ListaTodosEmpleados &
    '                                  "</table>" &
    '                                  "<br>" &
    '                                  "<font face=Calibri size=3> <b>SALUDOS - AREA DE RRHH </b> </font>" & "<br>"

    '                    BDCentralDAO.InsertEnvioCorreo("jcruz@norkys.pe", " Renovación Contrato: " + razoncomercial, Mensaje)
    '                End If
    '            Next
    '        End If
    '    End If
    'End Sub

    Private Sub btnEnvioCorreoFirmaContrato_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnEnvioCorreoFirmaContrato.ItemClick
        If GridView1.RowCount > 0 Then
            Dim MiForm As New EnvioCorreoFirma
            MiForm.ShowDialog()

            Dim fechadesde As Date = MiForm.dtFechaDesde.EditValue
            Dim fechahasta As Date = MiForm.dtFechaHasta.EditValue
            Dim horadesde As String = MiForm.teHoraDesde.Text
            Dim horahasta As String = MiForm.teHoraHasta.Text

            For i As Integer = 0 To GridView1.RowCount - 1
                Dim estadoenviocorreofima As Boolean
                Dim estadovalidadogeneral As Boolean
                estadovalidadogeneral = If(GridView1.GetRowCellValue(i, "ESTADOVALIDADOGENERAL").ToString = "False", 0, 1)
                estadoenviocorreofima = If(GridView1.GetRowCellValue(i, "ESTADOENVIOCORREOFIRMA").ToString = "False", 0, 1)
                If estadoenviocorreofima = False And estadovalidadogeneral Then
                    Dim idorganigrama As Integer = GridView1.GetRowCellValue(i, "IDORGANIGRAMA")
                    Dim razoncomercial As String = GridView1.GetRowCellValue(i, "RAZONCOMERCIAL")
                    Dim idsitio As Integer = GridView1.GetRowCellValue(i, "IDSITIO")
                    Dim idrenovacion As Integer = GridView1.GetRowCellValue(i, "IDRENOVACIONCONTRATO")

                    Dim dt1 As DataTable
                    dt1 = RenovacionContratoDAO.EmpleadosMismoLocalPorRenovarList(idorganigrama, idrenovacion) 'crear procedure para que ejecute solo (estadoenvioperodorenovacion) que esten en false(0)
                    Dim ListaEmpleados As String = ""
                    Dim ListaTodosEmpleados As String = ""
                    Dim Mensaje As String

                    'Dim nombresupervisor As String = dt.Rows(0).Item("")
                    'Dim corrreosupervisor As String = dt.Rows(0).Item("")
                    'Dim correocopia As String = dt.Rows(0).Item("")
                    'Dim emailTo As String = corrreosupervisor + "," + correocopia
                    If dt1.Rows.Count > 0 Then
                        For j As Integer = 0 To dt1.Rows.Count - 1

                            ListaEmpleados = "<tr><td style=font-family:Calibri;font-size:15px>" & dt1.Rows(j)("NUMERODOCUMENTO") & "</td>" &
                                        "<td style=font-family:Calibri;font-size:15px>" & dt1.Rows(j)("APELLIDOPATERNO") & "</td>" &
                                        "<td style=font-family:Calibri;font-size:15px>" & dt1.Rows(j)("APELLIDOMATERNO") & "</td>" &
                                        "<td style=font-family:Calibri;font-size:15px>" & dt1.Rows(j)("NOMBRES") & "</td>" &
                                        "<td style=font-family:Calibri;font-size:15px>" & dt1.Rows(j)("CARGOEMPLEADO") & "</td>" &
                                        "<td style=font-family:Calibri;font-size:15px>" & dt1.Rows(j)("RAZONSOCIAL") & "</td>" &
                                          "<td style=font-family:Calibri;font-size:15px>" & dt1.Rows(j)("RAZONCOMERCIAL") & "</td></tr>"

                            ListaTodosEmpleados = ListaTodosEmpleados + ListaEmpleados
                        Next


                        If idsitio = 1 Then 'mas de 1 empleado y el local es de lima

                            Mensaje = "<font face=Calibri size=3> Estimado colaborador:  " & "<br>" & "<br>" &
                                      "Por favor, indicar a los colaboradores que se acerquen para la firma de su renovación de contrato" & "<br>" & "<br>" &
                                      "Lugar: Jirón Puno N°489 Cercado – Lima" & "<br>" &
                                      "Los días " & fechadesde & " - " & fechahasta & "<br>" &
                                      "De " & horadesde & " a " & horahasta & "<br>" & "<br>" &
                                      "<table border=1 cellspacing=0 cellpadding=2>" &
                                      "<tr bgcolor='#E59866' align='center'> " &
                                      "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>DNI</td>" &
                                      "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>APELLIDO PATERNO</td>" &
                                      "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>APELLIDO MATERNO</td>" &
                                      "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>NOMBRES</td>" &
                                      "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>PUESTO</td>" &
                                      "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>RAZONCOMERCIAL</td>" &
                                       "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>RAZONCOMERCIAL</td>" &
                                      "</tr>" & ListaTodosEmpleados &
                                      "</table>" &
                                      "<br>" &
                                      "<font face=Calibri size=3> <b>SALUDOS - AREA DE RRHH </b> </font>" & "<br>"

                        Else  'El local es de provincia
                            Mensaje = "<font face=Calibri size=3> Estimado colaborador," & "<br>" & "<br>" &
                                      "Se está enviando a las tiendas por valija las renovaciones de contratos de los colaboradores mencionados líneas abajo, por favor tener en cuenta las siguientes indicaciones:" & "<br>" & "<br>" &
                                      "1.	Firmar al reverso del contrato donde dice Trabajador y colocar otra firma debajo del mismo." & "<br>" &
                                      "2.	Colocar huella digital al costado de la firma." & "<br>" &
                                      "3.	Enviar por valija al área de Administración de Personal." & "<br>" &
                                      "<table border=1 cellspacing=0 cellpadding=2>" &
                                      "<tr bgcolor='#E59866' align='center'> " &
                                      "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>DNI</td>" &
                                      "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>APELLIDO PATERNO</td>" &
                                      "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>APELLIDO MATERNO</td>" &
                                      "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>NOMBRES</td>" &
                                      "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>PUESTO</td>" &
                                       "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>RAZONSOCIAL</td>" &
                                       "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>RAZONCOMERCIAL</td>" &
                                      "</tr>" & ListaTodosEmpleados &
                                      "</table>" &
                                      "<br>" &
                                      "<font face=Calibri size=3> <b>SALUDOS - AREA DE RRHH </b> </font>" & "<br>"
                        End If
                        If RenovacionContratoDAO.UpdateEnvioCorreoFirma(idrenovacion) Then
                            Dim correodestinatario As String = dt1.Rows(0)("CORREODESTINATARIO")
                            BDCentralDAO.InsertEnvioCorreo(correodestinatario, " Renovación Contrato: " + razoncomercial, Mensaje)
                        End If
                        Refrescar()
                    End If
                End If
            Next
        Else
            MessageBox.Show("NO EXISTE UN LISTADO PARA EL ENVIO DE CORREO", "ENVIO CORREO ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    'Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
    '    Dim dtdatos As DataTable
    '    Dim idrenovacion As Integer = GridView1.GetFocusedRowCellValue("IDRENOVACIONCONTRATODETALLE")
    '    dtdatos = RenovacionContratoDAO.DatosRenovarContrato(idrenovacion)
    '    Dim rptContrato As New FormatoContratoNecesidadMercado
    '    rptContrato.XrTexto1.Text = dtdatos.Rows(0)("TEXTO1")
    '    rptContrato.XrTexto2.Text = dtdatos.Rows(0)("TEXTO2")
    '    rptContrato.XrTexto3.Text = dtdatos.Rows(0)("TEXTO3")
    '    rptContrato.XrTexto4.Text = dtdatos.Rows(0)("TEXTO4")
    '    rptContrato.XrTexto5.Text = dtdatos.Rows(0)("TEXTO5")

    '    Dim ruta As String
    '    ruta = My.Application.Info.DirectoryPath() + "\renovacion.pdf"
    '    rptContrato.ExportToPdf(ruta)
    '    Process.Start(ruta)
    'End Sub

    'Private Sub btnImprimirContrato_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnImprimirContrato.ItemClick
    'If MessageBox.Show("Esta Segura de imprimir el formato de renovaciones de contrato", "Impresion de Renovación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
    '    For i As Integer = 0 To GridView1.RowCount - 1
    '        Dim dtdatos As DataTable
    '        Dim idrenovacion As Integer = GridView1.GetRowCellValue(i, "IDRENOVACIONCONTRATODETALLE")
    '        dtdatos = RenovacionContratoDAO.DatosRenovarContrato(idrenovacion)
    '        Dim tipocontrato As String
    '        Dim cargo As String
    '        tipocontrato = GridView1.GetRowCellValue(i, "TIPOCONTRATO")
    '        cargo = GridView1.GetRowCellValue(i, "IDCARGO")

    '        Dim rptContrato As New FormatoContratoNecesidadMercado
    '        rptContrato.XrTexto1.Text = dtdatos.Rows(0)("TEXTO1")
    '        rptContrato.XrTexto2.Text = dtdatos.Rows(0)("TEXTO2")
    '        rptContrato.XrTexto3.Text = dtdatos.Rows(0)("TEXTO3")
    '        rptContrato.XrTexto4.Text = dtdatos.Rows(0)("TEXTO4")
    '        rptContrato.XrTexto5.Text = dtdatos.Rows(0)("TEXTO5")
    '        Try
    '            'Dim ruta As String
    '            'ruta = My.Application.Info.DirectoryPath() + "\renovacion_" + Convert.ToString(i + 1) + ".pdf"
    '            'rptContrato.ExportToPdf(ruta)
    '            'Process.Start(ruta)
    '            '-------------------------------------
    '            Dim printTool As New ReportPrintTool(rptContrato)
    '            printTool.Print()
    '            '-------------------------------------
    '        Catch ex As Exception
    '            MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
    '            Exit Sub
    '        End Try
    '    Next
    'End If
    'End Sub

    Private Sub btnAsignarListadoRenovacion_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnAsignarListadoRenovacion.ItemClick
        Dim nombre As String = GridView2.GetFocusedRowCellValue("NOMBRES")
        Dim appaterno As String = GridView2.GetFocusedRowCellValue("APELLIDOPATERNO")
        Dim apmaterno As String = GridView2.GetFocusedRowCellValue("APELLIDOMATERNO")
        Dim idrenovaciondetalle As String = GridView2.GetFocusedRowCellValue("IDRENOVACIONCONTRATODETALLE")
        If MessageBox.Show("Esta seguro de pasar al empleado " & nombre & " " & appaterno & " " & apmaterno & " Al listado de renovacion de contrato", "Asignar listado de renovaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            If RenovacionContratoDAO.AsignarEmpleadoListadoRenovacion(idrenovaciondetalle, BDCentralDAO.UsuarioBE.IDUsuario) Then
                MessageBox.Show("Retorno exitoso")
            End If
        End If
            Refrescar()
    End Sub





    Private Sub btnExportar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnExportar.ItemClick
        If GridView1.RowCount > 0 Then
            GridView1.Columns(0).Visible = False
            GridView1.Columns(1).Visible = False
            'GridView1.Columns("ASIGNARRENOVACION").Visible = False
            'GridView1.Columns("ESTADOENVIOCORREOFIRMA").Visible = False

            Try
                Dim ruta As String
                ruta = My.Application.Info.DirectoryPath() + "\RenovacionContratos.xlsx"
                GridControl1.ExportToXlsx(ruta)
                GridView1.Columns(0).Visible = True
                GridView1.Columns(1).Visible = True
                GridView1.Columns(0).VisibleIndex = 0
                GridView1.Columns(1).VisibleIndex = 1
                Process.Start(ruta)
            Catch ex As Exception
                MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
            End Try

            'GridView1.Columns(1).VisibleIndex = 1
            'GridView1.Columns(2).VisibleIndex = 2
            'GridView1.Columns(3).VisibleIndex = 3
            'GridView1.Columns(1).Visible = True
            'GridView1.Columns(2).Visible = True

            'GridView1.Columns("ASIGNARRENOVACION").Visible = True
            'GridView1.Columns("ESTADOENVIOCORREOFIRMA").Visible = True
        End If
    End Sub

    Private Sub GridView1_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView1.RowUpdated
        Dim estadocorreo As Boolean = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ESTADOENVIOCORREOFIRMA")
        Dim idrenovaciondetalle As Integer = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDRENOVACIONCONTRATODETALLE")
        Dim numeromeses As Integer = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "NUMEROMESESRENOVAR")
        Dim fechafinalcontrato As Date = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAFINALCONTRATO")
        Dim fechafinalcontratonueva As Date = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAFINALCONTRATONUEVA")
        Dim fechainiciocontratonuevo As Date = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAINICIALCONTRATONUEVO")

        If idrenovaciondetalle > 0 Then
            Dim Renovacion = If(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ASIGNARRENOVACION").ToString = "False", 0, 1)
            Dim ESTADOVALIDADO = If(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ESTADOVALIDADO").ToString = "False", 0, 1)
            If ESTADOVALIDADO = 1 Then
                If fechafinalcontratonueva <= fechafinalcontrato And numeromeses = 0 Then
                    MessageBox.Show("La nueva fecha de renovación no puede ser menor a su fecha final de contrato", "Error Renovación Contrato", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else

                    With RenovacionContratoBE
                        .IdRenovacionDetalle = idrenovaciondetalle
                        .NumeroMesesRenovar = numeromeses
                        .FechaPeriodoFin = fechafinalcontratonueva
                    End With
                End If
                '------------------------ jorge ricardo cruz martinez

                If numeromeses = 0 Then
                    RenovacionContratoDAO.UpdateFechaFinContratoNueva(RenovacionContratoBE, 1)  ' 1 = ASIGNA FECHAS Y MESES A RENOVAR
                Else
                    If RenovacionContratoDAO.UpdateFechaFinContratoNueva(RenovacionContratoBE, 2) Then '2 = SOLO ASIGNA FECHAS MAS NO MESES A RENOVAR
                        If fechainiciocontratonuevo.Day = "1" Then
                            Dim fechafincontratonueva As Date
                            fechafincontratonueva = fechainiciocontratonuevo.AddMonths(numeromeses).AddDays(-1)
                            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "FECHAFINALCONTRATONUEVA", fechafincontratonueva)
                        Else
                            Dim nuevo As Date = DateSerial(Year(fechafinalcontrato), Month(fechafinalcontrato) + numeromeses, fechafinalcontrato.Date.Day)
                            GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "FECHAFINALCONTRATONUEVA", nuevo)
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    'Private Sub RepositoryItemButtonEditDesprocesar_Click(sender As Object, e As EventArgs)

    'End Sub
    Private Sub RepositoryItemButtonEditDesprocesar_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEditDesprocesar.Click
        Dim result As Int32 = RenovacionContratoDAO.ValidarDesprocesarAsignacionRenovacionEmpleado(GridView1.GetFocusedRowCellValue("IDRENOVACIONCONTRATODETALLE"))

        If result = 0 Then
            Dim nombreempleado As String = GridView1.GetFocusedRowCellValue("APELLIDOPATERNO") & " " & GridView1.GetFocusedRowCellValue("APELLIDOMATERNO") & " " & GridView1.GetFocusedRowCellValue("NOMBRES")
            Dim numerodocumento As String = GridView1.GetFocusedRowCellValue("NUMERODOCUMENTO")
            If MessageBox.Show("Esta seguro de eliminar la solicitud de renovacion de contrato del colaborador " & nombreempleado & " con n° Documento " & numerodocumento, "Desprocesar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                If RenovacionContratoDAO.DesprocesarAsignacionRenovacionEmpleado(GridView1.GetFocusedRowCellValue("IDRENOVACIONCONTRATODETALLE"), BDCentralDAO.UsuarioBE.IDUsuario) Then
                    MessageBox.Show("Desproceso exitoso", "Desproceso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Refrescar()
                End If
            End If

        ElseIf result = 1 Then
            If MessageBox.Show("La renovacion de contrato del empleado ya ha sido validado", "Advertecian Renovación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                If RenovacionContratoDAO.DesprocesarAsignacionRenovacionEmpleado(GridView1.GetFocusedRowCellValue("IDRENOVACIONCONTRATODETALLE"), BDCentralDAO.UsuarioBE.IDUsuario) Then
                    MessageBox.Show("Desproceso exitoso", "Desproceso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Refrescar()
                End If
            End If
        ElseIf result = 2 Then
            If MessageBox.Show("La renovacion de contrato del empleado ya a sido validado para cese", "Advertecian Renovación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                If RenovacionContratoDAO.DesprocesarAsignacionRenovacionEmpleado(GridView1.GetFocusedRowCellValue("IDRENOVACIONCONTRATODETALLE"), BDCentralDAO.UsuarioBE.IDUsuario) Then
                    MessageBox.Show("Desproceso exitoso", "Desproceso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Refrescar()
                End If
            End If
        Else
            MessageBox.Show("Para poder desprocesar tiene que estar asignado a renovación", "Advertecian Renovación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub XtraTabPage1_Validated(sender As Object, e As EventArgs) Handles XtraTabPage1.Validated
        btnImprimirContrato.Visibility = BarItemVisibility.Never
        btnEnvioCorreoFirmaContrato.Visibility = BarItemVisibility.Never
        btnGenerarRenovacion.Visibility = BarItemVisibility.Never
        btnExportar.Visibility = BarItemVisibility.Never
        btnAsignarListadoRenovacion.Visibility = BarItemVisibility.Always
        chkSeleccionMasiva.Visibility = BarItemVisibility.Never

    End Sub
    Private Sub XtraTabPage2_Validated(sender As Object, e As EventArgs) Handles XtraTabPage2.Validated
        btnImprimirContrato.Visibility = BarItemVisibility.Always
        btnEnvioCorreoFirmaContrato.Visibility = BarItemVisibility.Always
        btnGenerarRenovacion.Visibility = BarItemVisibility.Always
        btnExportar.Visibility = BarItemVisibility.Always
        btnAsignarListadoRenovacion.Visibility = BarItemVisibility.Never
        chkSeleccionMasiva.Visibility = BarItemVisibility.Always
    End Sub

    Private Sub chkSeleccionar_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeleccionar.CheckedChanged
        If chkSeleccionar.Checked Then
            bsRenovacionContrato.DataSource = RenovacionContratoDAO.GetEmpleadoRenovacionxRenovarAsignadosList(btnFechainicial.EditValue, btnFechaFinal.EditValue, 1)
            bsPorCesar.DataSource = RenovacionContratoDAO.GetEmpleadoRenovacionxCesarList(btnFechainicial.EditValue, btnFechaFinal.EditValue)
        Else
            Refrescar()
        End If
    End Sub


End Class