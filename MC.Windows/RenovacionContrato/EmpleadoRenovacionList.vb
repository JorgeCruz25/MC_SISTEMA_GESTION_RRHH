
Imports MC.Data
Imports MC.Framework
Public Class EmpleadoRenovacionList

    Dim fechaDesde As Date
    Dim fechaHasta As Date
    Dim bsRenovaciones As New BindingSource
    Dim LISTADOLOCALES As String
    Dim dtdatosEnvioCorreo As DataTable
    Dim drRowOrganigrama As DataRow


    Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = False

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDEMPLEADO", "IDEMPLEADO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO SOLICITUD", "ESTADORENOVACION", 80, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA FINAL CONTRATO", "FECHAFINALCONTRATO", 140, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBRES", "NOMBRES", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "APELLIDO PATERNO", "APELLIDOPATERNO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "APELLIDO MATERNO", "APELLIDOMATERNO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DOCUMENTO", "NUMERODOCUMENTO", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO EMPLEADO", "CARGOEMPLEADO", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO DE CONTRATO", "TIPOCONTRATO", 160, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MATRICULA", "MATRICULA", 160, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CODIGOUNICO", "CODIGOUNICO", 160, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDSUPERVISOR", "IDSUPERVISOR", 160, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDLOCAL", "IDLOCAL", 160, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDORGANIGRAMA", "IDORGANIGRAMA", 160, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridView1
            .Columns("NOMBRES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOPATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOMATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("TIPOCONTRATO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        btnFechaInicial.EditValue = DateTime.Now.Date
        btnFechaFinal.EditValue = DateTime.Now.Date.AddDays(+30)

        AddHandler btnFechaFinal.EditValueChanged, AddressOf Buscar
        AddHandler btnFechaInicial.EditValueChanged, AddressOf Buscar
        AddHandler btnBuscar.ItemClick, AddressOf Buscar

        Me.GridControl1.DataSource = bsRenovaciones
        Buscar()
    End Sub

    Public Sub Buscar()
        Try

            btnGenerarRenovacion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)

            Tools.AccionesUsuarioRibbon(RibbonControl, dtAccionesUsuario)
            bsRenovaciones.DataSource = RenovacionContratoDAO.GetEmpleadoRenovacionList(btnFechaInicial.EditValue, btnFechaFinal.EditValue)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnGenerarRenovacion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGenerarRenovacion.ItemClick
        If GridView1.RowCount > 0 Then
            Dim dtOrganigrama As New DataTable
            Dim dtEmpleado As New DataTable

            dtOrganigrama.Columns.Add("IDORGANIGRAMA")
            dtEmpleado.Columns.Add("IDORGANIGRAMA")
            dtEmpleado.Columns.Add("IDEMPLEADO")

            If MessageBox.Show("ESTA SEGURO DE GENERAR SOLICITUDES DE RENOVACIÓN DE CONTRATOS DESDE " & btnFechaInicial.EditValue & " HASTA" & btnFechaFinal.EditValue, "GENERACIÓN DE SOLICITUDES", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Cursor = Cursors.Default
                fechaDesde = btnFechaInicial.EditValue
                fechaHasta = btnFechaFinal.EditValue

                Dim FlatOrganigrama As Int32 = 0
                Dim FlatEmpleado As Int32 = 0
                Dim idorgaanigrainsert As Int32
                Dim empleado As Int32
                Dim organigrama As Int32
                Dim IdOrganigramaCorreo As Int32

                For i As Integer = 0 To GridView1.RowCount - 1
                    Dim estadorenovacion As Boolean = GridView1.GetRowCellValue(i, "ESTADORENOVACION")

                    If estadorenovacion = False Then
                        empleado = GridView1.GetRowCellValue(i, "IDEMPLEADO")
                        organigrama = GridView1.GetRowCellValue(i, "IDORGANIGRAMA")

                        If dtOrganigrama.Rows.Count = 0 Then
                            idorgaanigrainsert = GridView1.GetRowCellValue(i, "IDORGANIGRAMA")
                            drRowOrganigrama = dtOrganigrama.NewRow
                            drRowOrganigrama("IDORGANIGRAMA") = idorgaanigrainsert
                            dtOrganigrama.Rows.Add(drRowOrganigrama)

                        Else

                            For j As Integer = 0 To dtOrganigrama.Rows.Count - 1
                                idorgaanigrainsert = GridView1.GetRowCellValue(i, "IDORGANIGRAMA")
                                IdOrganigramaCorreo = dtOrganigrama.Rows(j).Item("IDORGANIGRAMA")

                                If IdOrganigramaCorreo = idorgaanigrainsert Then            'SOLO IDORGANIGRAMA DISTINTINTO
                                    FlatOrganigrama = 1 ' SI EXISTE ORGANIGRAMA
                                    Exit For
                                Else
                                    FlatOrganigrama = 2 ' NO EXISTE ORGANIGRAMA
                                End If
                            Next
                        End If
                        If FlatOrganigrama = 2 Then
                            drRowOrganigrama = dtOrganigrama.NewRow
                            drRowOrganigrama("IDORGANIGRAMA") = idorgaanigrainsert
                            dtOrganigrama.Rows.Add(drRowOrganigrama)
                        End If
                        dtEmpleado.Rows.Add(organigrama, empleado)
                    End If
                Next

                For i As Integer = 0 To dtOrganigrama.Rows.Count - 1
                    Dim datoorganigrama As Int32 = dtOrganigrama.Rows(i).Item("IDORGANIGRAMA")
                    If RenovacionContratoDAO.RegistrarSolicitudesRenovacion(datoorganigrama, btnFechaInicial.EditValue, btnFechaFinal.EditValue, BDCentralDAO.UsuarioBE.IDUsuario) Then
                        For j As Integer = 0 To dtEmpleado.Rows.Count - 1
                            If datoorganigrama = dtEmpleado.Rows(j).Item("IDORGANIGRAMA") Then
                                RenovacionContratoDAO.AsignarRenovacionContratoDetalle(dtEmpleado.Rows(j).Item("IDEMPLEADO"))
                                '------- GENERA SOLICITUD DE RENOVACION ----OBTENIENDO IDRENOVACIÓN
                                '--------GENERA SOLICITUD DE DETALLE RENOVACIÓN
                                '--------INSERTA LOS EMPLEADOS PARA RENOVAR PCA
                            End If
                        Next
                    End If


                Next
                If dtOrganigrama.Rows.Count > 0 Then
                    For i As Integer = 0 To dtOrganigrama.Rows.Count - 1
                        dtdatosEnvioCorreo = RenovacionContratoDAO.ObtenerInformacionEnvioCorreo(dtOrganigrama.Rows(i).Item("IDORGANIGRAMA"))
                        Dim nombreColaborador As String = ""
                        Dim correoSolicitud As String = ""
                        Dim IdLocal As Integer = 0
                        Dim IdOrganirama As Integer = 0
                        Dim OrganigramaLocal As String = ""
                        If dtdatosEnvioCorreo.Rows.Count > 0 Then
                            correoSolicitud = dtdatosEnvioCorreo.Rows(0)("CORREO")
                            IdLocal = dtdatosEnvioCorreo.Rows(0)("IDLOCAL")
                            IdOrganirama = dtdatosEnvioCorreo.Rows(0)("IDORGANIGRAMA")
                            nombreColaborador = dtdatosEnvioCorreo.Rows(0)("PERSONAENVIOCORREO")
                            OrganigramaLocal = dtdatosEnvioCorreo.Rows(0)("ORGANIGRAMA")


                            'If RenovacionContratoDAO.RegistrarSolicitudesRenovacion(IdLocal, fechaDesde, fechaHasta, BDCentralDAO.UsuarioBE.IDUsuario) Then
                            Dim emailTo As String
                            emailTo = correoSolicitud
                            Dim Mensaje As String

                            Mensaje = "<font face=Calibri size=3> Estimado " & nombreColaborador & "<br>" &
                                        "Se comunica que tiene colaboradores por renovar contrato" & " , por favor cumplir con los siguientes pasos" & "<br>" & "<br>" &
                                         "1. Ingresar a la Plataforma de Control de Atenciones mediante el siguiente link: http://controlatenciones.azurewebsites.net/Account/Login.aspx?ReturnUrl=%2f " & "<br>" &
                                         "2. Acceder con su usuario respectivo" & "<br>" &
                                         "3. Ingresar en el modulo de RRHH y seleccionar la opción de Renovación de Contratos" & "<br>"
                            BDCentralDAO.InsertEnvioCorreo(emailTo, "Renovación de contratos", Mensaje)
                        Else
                            'MessageBox.Show("Falta asignar el destinatario del correo n° " & dtOrganigrama.Rows(i).Item("IDORGANIGRAMA"), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning) SI VA
                        End If
                        '"Se comunica que tiene colaboradores por renovar contrato en el local " & OrganigramaLocal & " , por favor cumplir con los siguientes pasos" & "<br>" & "<br>" &
                        'Dim IdCabeceraRenovacionContrato As Integer = RenovacionContratoDAO.ObtenerCabeceraRenovacioContrato(IdLocal, fechaDesde, fechaHasta)
                        'For j As Integer = 0 To GridView1.RowCount - 1
                        '    Dim localempleado As Integer
                        '    Dim estadoRenovacion As Boolean
                        '    estadoRenovacion = GridView1.GetRowCellValue(j, "ESTADORENOVACION")
                        '    localempleado = GridView1.GetRowCellValue(j, "IDLOCAL")
                        '    If estadoRenovacion = False And localempleado = IdLocal Then
                        '        Dim IdEmpleado As Integer = GridView1.GetRowCellValue(j, "IDEMPLEADO")
                        '        Dim fechafinal As Date = GridView1.GetRowCellValue(j, "FECHAFINALCONTRATO")
                        'If RenovacionContratoDAO.AsignarRenovacionContratoDetalle(IdCabeceraRenovacionContrato, IdEmpleado, fechafinal) Then
                        '            RenovacionContratoDAO.UpdateRenovacionContratoEmpleado(IdEmpleado)
                        '        End If
                        '    End If
                        'Next
                        'Else
                        '    MessageBox.Show("Error al registrar solicitud")
                        'End If
                    Next
                End If


                'Else
                '    MessageBox.Show("En el periodo de fecha de " & fechaDesde & " hasta " & fechaDesde & "no existen empleados por renovar", "Renovacion de contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'End If
            End If
            dtOrganigrama.Columns.RemoveAt(0)
            Buscar()

        Else
            MessageBox.Show("No existe listado de empleados")
        End If
    End Sub
    Private Sub GenerarSolicitudCorreo()
        'Dim nombreColaborador As String
        'Dim correoSolicitud As String
        'Dim IdLocal As Integer
        'Dim RazonComercial As String
        'Dim CorreoCopia As String


        'ObtenerInformacionEnvioCorreo
        'For i = 0 To dtdatoslocal.Rows.Count - 1
        '    correoSolicitud = dtdatoslocal.Rows(i)("CORREOELECTRONICO")
        '    IdLocal = dtdatoslocal.Rows(i)("IDLOCAL")
        '    nombreColaborador = dtdatoslocal.Rows(i)("COLABORADOR")
        '    RazonComercial = dtdatoslocal.Rows(i)("RAZONCOMERCIAL")
        '    CorreoCopia = dtdatoslocal.Rows(i)("CORREOCOPIA")

        '    If RenovacionContratoDAO.RegistrarSolicitudesRenovacion(IdLocal, fechaDesde, fechaHasta, BDCentralDAO.UsuarioBE.IDUsuario) Then
        '        Dim emailTo As String
        '        emailTo = correoSolicitud + "," + CorreoCopia
        '        Dim Mensaje As String

        '        Mensaje = "<font face=Calibri size=3> Estimado " & nombreColaborador & "<br>" &
        '            "Se comunica que tiene colaboradores por renovar contrato en el local " & RazonComercial & " , por favor cumplir con los siguientes pasos" & "<br>" & "<br>" &
        '             "1. Ingresar a la Plataforma de Control de Atenciones mediante el siguiente link: http://controlatenciones.azurewebsites.net/Account/Login.aspx?ReturnUrl=%2f " & "<br>" &
        '             "2. Acceder con su usuario respectivo" & "<br>" &
        '             "3. Ingresar en el modulo de RRHH y seleccionar la opción de Renovación de Contratos" & "<br>"
        '        BDCentralDAO.InsertEnvioCorreo(emailTo, "Renovación de contratos", Mensaje)
        '        Dim IdCabeceraRenovacionContrato As Integer = RenovacionContratoDAO.ObtenerCabeceraRenovacioContrato(IdLocal, fechaDesde, fechaHasta)
        '        For j As Integer = 0 To GridView1.RowCount - 1
        '            Dim localempleado As Integer
        '            Dim estadoRenovacion As Boolean
        '            estadoRenovacion = GridView1.GetRowCellValue(j, "ESTADORENOVACION")
        '            localempleado = GridView1.GetRowCellValue(j, "IDLOCAL")
        '            If estadoRenovacion = False And localempleado = IdLocal Then
        '                Dim IdEmpleado As Integer = GridView1.GetRowCellValue(j, "IDEMPLEADO")
        '                Dim fechafinal As Date = GridView1.GetRowCellValue(j, "FECHAFINALCONTRATO")
        '                If RenovacionContratoDAO.AsignarRenovacionContratoDetalle(IdCabeceraRenovacionContrato, IdEmpleado, fechafinal) Then
        '                    RenovacionContratoDAO.UpdateRenovacionContratoEmpleado(IdEmpleado)
        '                End If
        '            End If
        '        Next
        '    Else
        '        MessageBox.Show("Error al registrar solicitud")
        '    End If
        'Next
        'dtdatoslocal.Clear()
        'dtdatoslocal.Constraints.Clear()
        'dtdatoslocal.Columns.Clear()
    End Sub

    Private Sub EmpleadoRenovacionList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    'Private Sub RepositoryItemButtonEditDesprocesar_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEditDesprocesar.Click
    '    If GridView1.GetFocusedRowCellValue("ESTADORENOVACION") Then
    '        Dim result As Int32 = RenovacionContratoDAO.ValidarDesprocesarAsignacionRenovacionEmpleado(GridView1.GetFocusedRowCellValue("IDEMPLEADO"))
    '        If result = 0 Then
    '            Dim nombreempleado As String = GridView1.GetFocusedRowCellValue("APELLIDOPATERNO") & " " & GridView1.GetFocusedRowCellValue("APELLIDOMATERNO") & " " & GridView1.GetFocusedRowCellValue("NOMBRES")
    '            Dim numerodocumento As String = GridView1.GetFocusedRowCellValue("NUMERODOCUMENTO")
    '            If MessageBox.Show("Esta seguro de desprocesar al empleado " & nombreempleado & " con n° Documento" & numerodocumento, "Desprocesar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
    '                If RenovacionContratoDAO.DesprocesarAsignacionRenovacionEmpleado(GridView1.GetFocusedRowCellValue("IDEMPLEADO")) Then
    '                    'messa---continua validacion
    '                    MessageBox.Show("Desproceso exitoso", "Desproceso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                End If
    '            End If
    '        ElseIf result = 1 Then
    '            MessageBox.Show("La renovacion de contrato del empleado ya ha sido validado", "Advertecian Renovación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        ElseIf result = 2 Then
    '            MessageBox.Show("La renovacion de contrato del empleado ya a sido validado para cese", "Advertecian Renovación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        End If
    '    Else
    '        MessageBox.Show("Para poder desprocesar tiene que estar asignado a renovación", "Advertecian Renovación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    End If

    'End Sub
End Class