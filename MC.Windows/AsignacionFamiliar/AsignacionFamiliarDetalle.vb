Imports MC.Data
Imports MC.Framework
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraTab

Public Class AsignacionFamiliarDetalle

    Dim EmpleadoDerechoHabienteBE As New EmpleadoDerechoHabienteBE
    Dim idorganigrama As Int32
    Dim idcargo As Int32
    Dim asignacionFamiliar As Int32



    Public Sub New()
        InitializeComponent()

        GridView1.Columns(0).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(1).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(2).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(3).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(4).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(5).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        CargarTipoDocumento()
        CargarSexo()
        CargarDistrito()
        'CargarTipoDerechoHabiente()
        CargarNacionalidad()
        CargarMes()

        Listar()


    End Sub
    Private Sub Listar()
        Try
            inabilitarbotones()
            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(RibbonControl, dtAccionesUsuario)

            Dim dtAsignacion As DataTable = BDAccionPersonalDAO.GetAsignacionFamiliarHijosList(BDAccionPersonalDAO.IdAsignacionFamiliar)
            GridControl1.DataSource = dtAsignacion
            asignacionFamiliar = If(dtAsignacion.Rows(0)("ASIGNACIONFAMILIAR") = False, 0, 1)

            bsiNombreEmpleado.Caption = "NOMBRE COLABORADOR: " & dtAsignacion.Rows(0)("NOMBREEMPLEADO")
            If asignacionFamiliar = 0 Then
                chkAsignacionFamiliarSi.Checked = False
                chkAsignacionFamiliarNo.Checked = True
            Else
                chkAsignacionFamiliarSi.Checked = True
                chkAsignacionFamiliarNo.Checked = False
            End If

            Dim dtArchivos As DataTable = BDAccionPersonalDAO.GetAsignacionFamiliarArchivosList(BDAccionPersonalDAO.IdAsignacionFamiliar)


            idorganigrama = dtAsignacion.Rows(0)("IDORGANIGRAMA")
            idcargo = dtAsignacion.Rows(0)("IDCARGO")

            If dtArchivos.Rows.Count > 0 Then
                For i As Integer = 0 To dtArchivos.Rows.Count - 1
                    Dim ruta As String = dtArchivos.Rows(i)("linkdescarga").ToString

                    Dim tab As String
                    tab = "Archivo" + Convert.ToString(i + 1)

                    Dim NewTab As New XtraTabPage
                    NewTab.Name = tab
                    NewTab.Text = tab
                    XtraTabControl1.TabPages.Add(NewTab)

                    Dim uccontrol1 As New XtraUserControlWebBrowser()
                    NewTab.Controls.Add(uccontrol1)
                    uccontrol1.Dock = DockStyle.Fill

                    uccontrol1.WebBrowser1.Show()
                    uccontrol1.WebBrowser1.Navigate(String.Format(ruta, Application.StartupPath))
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub inabilitarbotones()
        btnAnular.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnRegistrarAsignacion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnDesprocesarValidado.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub
    Private Sub CargarTipoDocumento()
        ControlesDevExpress.InitGridViewColumn(GridViewTipoIdentidad, "ID", "IDTIPODOCUMENTOIDENTIDAD", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewTipoIdentidad, "TIPO DE IDENTIDAD", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewTipoIdentidad
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        RepositoryItemGridLookUpEditTipoIdentidad.DataSource = BDCentralDAO.GetTipoIdentidadList
        RepositoryItemGridLookUpEditTipoIdentidad.ValueMember = "IDTIPODOCUMENTOIDENTIDAD"
        RepositoryItemGridLookUpEditTipoIdentidad.DisplayMember = "DESCRIPCION"
        RepositoryItemGridLookUpEditTipoIdentidad.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub CargarSexo()
        ControlesDevExpress.InitGridViewColumn(GridViewSexo, "ID", "IDSEXO", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewSexo, "DESCRIPCION", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewSexo
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        RepositoryItemGridLookUpEditSexo.DataSource = BDCentralDAO.GetSexoList
        RepositoryItemGridLookUpEditSexo.ValueMember = "IDSEXO"
        RepositoryItemGridLookUpEditSexo.DisplayMember = "DESCRIPCION"
        RepositoryItemGridLookUpEditSexo.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub CargarDistrito()
        ControlesDevExpress.InitGridViewColumn(GridViewDistrito, "ID", "IDUBIGEO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDistrito, "DEPARTAMENTO", "DEPARTAMENTO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDistrito, "PROVINCIA", "PROVINCIA", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDistrito, "DISTRITO", "DISTRITO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDistrito, "UBIGEO", "UBIGEO", 180, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewDistrito
            .Columns("DEPARTAMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("PROVINCIA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("DISTRITO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("UBIGEO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        RepositoryItemGridLookUpEditDistrito.DataSource = BDCentralDAO.GetDistritoList
        RepositoryItemGridLookUpEditDistrito.ValueMember = "IDUBIGEO"
        RepositoryItemGridLookUpEditDistrito.DisplayMember = "UBIGEO"
        RepositoryItemGridLookUpEditDistrito.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    'Private Sub CargarTipoDerechoHabiente()
    '    ControlesDevExpress.InitGridViewColumn(GridViewTipoDerechoHabiente, "ID", "TIPODERECHOHABIENTE", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
    '    ControlesDevExpress.InitGridViewColumn(GridViewTipoDerechoHabiente, "DERECHO HABIENTE", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

    '    With GridViewTipoDerechoHabiente
    '        .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
    '    End With

    '    RepositoryItemGridLookUpEditTipoDerechoHabiente.DataSource = BDAccionPersonalDAO.GetTipoDerechoHabienteList
    '    RepositoryItemGridLookUpEditTipoDerechoHabiente.ValueMember = "TIPODERECHOHABIENTE"
    '    RepositoryItemGridLookUpEditTipoDerechoHabiente.DisplayMember = "DESCRIPCION"
    '    RepositoryItemGridLookUpEditTipoDerechoHabiente.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    'End Sub

    Private Sub CargarNacionalidad()
        ControlesDevExpress.InitGridViewColumn(GridViewOriginario, "ID", "CODIGOPAIS", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewOriginario, "DESCRIPCION", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewOriginario
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        RepositoryItemGridLookUpEditNacionalidad.DataSource = BDAccionPersonalDAO.GetNacionalidadList
        RepositoryItemGridLookUpEditNacionalidad.ValueMember = "CODIGOPAIS"
        RepositoryItemGridLookUpEditNacionalidad.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditNacionalidad.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarMes()
        ControlesDevExpress.InitGridViewColumn(GridViewMesEvaluacion, "ID", "IDMESEVALUACION", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewMesEvaluacion, "MES", "MES", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewMesEvaluacion
            .Columns("MES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        RepositoryItemGridLookUpEditMesEvaluacion.DataSource = BDCentralDAO.GetMesList
        RepositoryItemGridLookUpEditMesEvaluacion.ValueMember = "IDMESEVALUACION"
        RepositoryItemGridLookUpEditMesEvaluacion.DisplayMember = "MES"
        RepositoryItemGridLookUpEditMesEvaluacion.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub GridView1_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView1.RowUpdated
        Cursor = Cursors.WaitCursor

        With EmpleadoDerechoHabienteBE
            .IDASIGNACIONHIJO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDASIGNACIONHIJO")
            .DNI = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "NUMERODOCUMENTO")
            .NOMBRES = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "NOMBRES")
            .APELLIDOPATERNO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "APELLIDOPATERNO")
            .APELLIDOMATERNO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "APELLIDOMATERNO")
            .FECHANACIMIENTO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHANACIMIENTO")
            .IDSEXO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDSEXO")
            .IDTIPOIDENTIDAD = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDTIPODOCUMENTOIDENTIDAD")
            '.TIPODERECHOHABIENTE = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "TIPODERECHOHABIENTE")
            .NACIONALIDAD = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "NACIONALIDAD")
            .IDUBIGEO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDUBIGEO")
            .DIRECCION = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DIRECCION")
            .TREGISTRO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "TREGISTRO")
            .ESSALUD = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ESSALUD")

            .IDMESEVALUACION = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDMESEVALUACION")

            If .DNI = "" Or .NOMBRES = "" Or .APELLIDOPATERNO = "" Or .APELLIDOMATERNO = "" Then
                Exit Sub
            End If
        End With

        BDAccionPersonalDAO.AsignacionFamiliarHijosUpdate(EmpleadoDerechoHabienteBE)
        Cursor = Cursors.Default
        GridControl1.DataSource = BDAccionPersonalDAO.GetAsignacionFamiliarHijosList(BDAccionPersonalDAO.IdAsignacionFamiliar)
    End Sub

    Private Sub btnRegistrarAsignacion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRegistrarAsignacion.ItemClick
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()

        Dim idtipoidentidad As Integer = 0
        Dim numeroidentidad As String = ""
        Dim nombres As String = ""
        Dim apellidopaterno As String = ""
        Dim apellidomaterno As String = ""
        Dim idsexo As String = 0
        Dim nacionalidad As String = ""
        Dim idempleado As Integer = 0
        Dim idubigeo As Integer = 0
        Dim direccion As String = ""
        Dim mesevaluacion As Integer = 0

        For j As Integer = 0 To GridView1.RowCount - 1

            idtipoidentidad = GridView1.GetRowCellValue(j, "IDTIPODOCUMENTOIDENTIDAD")
            numeroidentidad = GridView1.GetRowCellValue(j, "NUMERODOCUMENTO")
            nombres = GridView1.GetRowCellValue(j, "NOMBRES").ToString
            apellidopaterno = GridView1.GetRowCellValue(j, "APELLIDOPATERNO").ToString
            apellidomaterno = GridView1.GetRowCellValue(j, "APELLIDOMATERNO").ToString
            idsexo = GridView1.GetRowCellValue(j, "IDSEXO")
            nacionalidad = GridView1.GetRowCellValue(j, "NACIONALIDAD")
            idempleado = GridView1.GetRowCellValue(j, "IDEMPLEADO")
            idubigeo = GridView1.GetRowCellValue(j, "IDUBIGEO")
            direccion = GridView1.GetRowCellValue(j, "DIRECCION")
            mesevaluacion = GridView1.GetRowCellValue(j, "IDMESEVALUACION")

            If idtipoidentidad = 0 Or numeroidentidad = "" Then
                MessageBox.Show("Información incompleta, ingresar el tipo y número de identidad para registrar la solicitud.")
                Exit Sub
            End If
            If nombres = "" Or apellidopaterno = "" Or apellidomaterno = "" Then
                MessageBox.Show("Información incompleta, ingresar el nombre y apellidos para registrar la solicitud.")
                Exit Sub
            End If
            If idsexo = 0 Then
                MessageBox.Show("Información incompleta, ingresar el sexo registrar la solicitud.")
                Exit Sub
            End If
            If nacionalidad = "" Then
                MessageBox.Show("Información incompleta, ingresar la nacionalidad para registrar la solicitud.")
                Exit Sub
            End If
            If idubigeo = 0 Then
                MessageBox.Show("Información incompleta, ingresar el distrito para registrar la solicitud.")
                Exit Sub
            End If
            If direccion = "" Then
                MessageBox.Show("Información incompleta, ingresar la dirección para registrar la solicitud.")
                Exit Sub
            End If

            If mesevaluacion = 0 Then
                MessageBox.Show("Información incompleta, ingresar el mes de evaluacion para registrar la solicitud.")
                Exit Sub
            End If

        Next

        If idempleado <> 0 Then

            If MessageBox.Show("Esta seguro de procesar la asignación familiar", "Asignación familiar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then


                BDAccionPersonalDAO.IdEmpleado = idempleado
                'Dim Miform As New AsignarDerechoHabiente
                'Miform.AsignacionFamiliar = asignacionFamiliar
                'Miform.ShowDialog()

                'If Miform.Aprobacion = 1 Then
                For i As Integer = 0 To GridView1.RowCount - 1
                    With EmpleadoDerechoHabienteBE
                        .IDEMPLEADO = GridView1.GetRowCellValue(i, "IDEMPLEADO")
                        If GridView1.GetRowCellValue(i, "CODIGOUNICO") Is DBNull.Value Then
                            MessageBox.Show("El empleado aun no esta registrado en Adryan.")
                            Exit Sub
                        Else
                            .CODIGOUNICO = GridView1.GetRowCellValue(i, "CODIGOUNICO")
                        End If

                        .IDASIGNACIONHIJO = GridView1.GetRowCellValue(i, "IDASIGNACIONHIJO")
                        .DNI = GridView1.GetRowCellValue(i, "NUMERODOCUMENTO")
                        .NOMBRES = GridView1.GetRowCellValue(i, "NOMBRES")
                        .APELLIDOPATERNO = GridView1.GetRowCellValue(i, "APELLIDOPATERNO")
                        .APELLIDOMATERNO = GridView1.GetRowCellValue(i, "APELLIDOMATERNO")
                        .FECHANACIMIENTO = GridView1.GetRowCellValue(i, "FECHANACIMIENTO")
                        .IDSEXO = GridView1.GetRowCellValue(i, "IDSEXO")
                        .IDTIPOIDENTIDAD = GridView1.GetRowCellValue(i, "IDTIPODOCUMENTOIDENTIDAD")
                        '.TIPODERECHOHABIENTE = GridView1.GetRowCellValue(i, "TIPODERECHOHABIENTE")
                        .NACIONALIDAD = GridView1.GetRowCellValue(i, "NACIONALIDAD")
                        .IDUBIGEO = GridView1.GetRowCellValue(i, "IDUBIGEO")
                        .DIRECCION = GridView1.GetRowCellValue(i, "DIRECCION")
                        .TREGISTRO = GridView1.GetRowCellValue(i, "TREGISTRO")
                        .ESSALUD = GridView1.GetRowCellValue(i, "ESSALUD")
                        .IDMESEVALUACION = GridView1.GetRowCellValue(i, "IDMESEVALUACION")
                        .IDUSUARIOREGISTRO = BDCentralDAO.UsuarioBE.IDUsuario

                        'Dim dtEmpleadoAdryan As New DataTable
                        'dtEmpleadoAdryan = BDAccionPersonalDAO.GetEmpleadoCargarDatosAdicionales(.IDTIPOIDENTIDAD, idcargo, idarea, .IDDISTRITO)
                        '.ADRYAN_TIPOIDENTIDAD = dtEmpleadoAdryan.Rows(0)("TIPODOCUMENTO")
                        '.ADRYAN_DISTRITO = dtEmpleadoAdryan.Rows(0)("DISTRITO")
                        '.ADRYAN_PROVINCIA = dtEmpleadoAdryan.Rows(0)("PROVINCIA")
                        '.ADRYAN_DEPARTAMENTO = dtEmpleadoAdryan.Rows(0)("DEPARTAMENTO")
                        '.IDUSUARIOREGISTRO = BDCentralDAO.UsuarioBE.IDUsuario
                        '.USUARIOREGISTRO = BDCentralDAO.UsuarioBE.Usuario
                    End With

                    'REGISTRO ADRYAN
                    'If Not BDAccionPersonalDAO.InsertaDerechoHabientePersonalAdryan(EmpleadoDerechoHabienteBE) Then
                    '    MessageBox.Show("Problemas de Conexión con el sistema Adryan", "Error de Conexión")
                    '    Cursor = Cursors.Default
                    '    Exit Sub
                    'End If

                    'REGISTRO MC_CENTRAL

                    If Not BDAccionPersonalDAO.InsertaHijosFamilia(EmpleadoDerechoHabienteBE) Then
                        MessageBox.Show("Error en el registro de hijo(s)", "Error de Registro")
                        Cursor = Cursors.Default
                        Exit Sub
                    End If
                Next
                'If Miform.rboAsignacionSi.Checked And Miform.rboAsignacionNo.Checked = False Then
                EmpleadoDerechoHabienteBE.ESTADOASIGNACIONBENEFICIO = 1
                'ElseIf Miform.rboAsignacionSi.Checked = False And Miform.rboAsignacionNo.Checked Then
                'EmpleadoDerechoHabienteBE.ESTADOASIGNACIONBENEFICIO = 0
                'End If
                'REGISTRA EN ADRYAN LA ASIGNACION FAMILIAR
                If BDAccionPersonalDAO.AsignacionFamiliarAdryan(EmpleadoDerechoHabienteBE, BDCentralDAO.UsuarioBE.Usuario) Then
                    'REGISTRA EN MC_CENTRAL
                    BDAccionPersonalDAO.QuitarAsignacionFamiliarEmpleadoId(BDAccionPersonalDAO.IdEmpleado, EmpleadoDerechoHabienteBE.ESTADOASIGNACIONBENEFICIO, BDCentralDAO.UsuarioBE.IDUsuario)
                End If
                'MODIFICA LA SOLICITUD
                BDAccionPersonalDAO.AsignacionFamiliarRevisado(BDAccionPersonalDAO.IdAsignacionFamiliar, EmpleadoDerechoHabienteBE.ESTADOASIGNACIONBENEFICIO, EmpleadoDerechoHabienteBE.IDUSUARIOREGISTRO)
                Cursor = Cursors.Default
                Me.Close()
                'End If
            End If
        End If
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick

        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()

        Me.Close()
    End Sub

    Private Sub btnAnular_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnular.ItemClick
        If MessageBox.Show("Desea anular derecho habiente(s)?", "Anular derecho habiente(s)", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If Not BDAccionPersonalDAO.AnulacionFamiliarRevisado(BDAccionPersonalDAO.IdAsignacionFamiliar, BDCentralDAO.UsuarioBE.IDUsuario) Then
                MessageBox.Show("Error al anular el derecho habiente", "Error de Registro")
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnDesprocesarValidado_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDesprocesarValidado.ItemClick
        If MessageBox.Show("Esta seguro de desprocesar el validado de solicitud", "Desprocesar validado", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            If BDAccionPersonalDAO.DesprocesarValidadoFamiliarRevisado(BDAccionPersonalDAO.IdAsignacionFamiliar) Then
                Dim dtenviocorreo As DataTable
                dtenviocorreo = BDAccionPersonalDAO.AsignacionFamiliarEnvioCorreo(BDAccionPersonalDAO.IdAsignacionFamiliar)
                If dtenviocorreo.Rows.Count > 0 Then

                    Dim nroformato As String = dtenviocorreo.Rows(0)("NUMEROSOLICITUD")
                    Dim tienda As String = dtenviocorreo.Rows(0)("RAZONCOMERCIAL")
                    Dim empleado As String = dtenviocorreo.Rows(0)("EMPLEADOBENEFICIO")
                    Dim empleadonumerodocumento As String = dtenviocorreo.Rows(0)("NUMERODOCUMENTO")
                    Dim correodestinatario As String = dtenviocorreo.Rows(0)("CORREO")

                    Dim emailTo As String
                    emailTo = correodestinatario

                    Dim Mensaje As String
                    Mensaje = "<font face=Calibri size=3>" & "Estinado colaborador del local de: " & tienda & " Se comunica que se a des procesado el validado de la solicud de Asignación Familiar número " & nroformato & " en referencia al Señor(a)  " & empleado &
        " con número de documento:  " & empleadonumerodocumento
                    BDCentralDAO.InsertEnvioCorreo(emailTo, " Asignación Familiar: " + nroformato, Mensaje)
                End If

                MessageBox.Show("Desproceso de validado exitoso", "Desproceso Validado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Error al desprocesar validado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If
        End If
    End Sub
End Class