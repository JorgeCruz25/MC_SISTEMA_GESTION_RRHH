#Region "Imports"
Imports System.Globalization
Imports DevExpress.XtraBars
Imports DevExpress.LookAndFeel
Imports MC.Data
Imports MC.Framework
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraBars.Ribbon

#End Region

Public Class MEDesktop
    Dim _BDCentralDAO As New BDCentralDAO

    Dim RequerimientoPersonalBE As New RequerimientoPersonalBE

    Sub New()
        InitSkins()
        InitializeComponent()
        btnUsuario.Caption = BDCentralDAO.UsuarioBE.Nombres & " " & BDCentralDAO.UsuarioBE.ApellidoPaterno & " (" & BDCentralDAO.UsuarioBE.NombreRol & ")"
        btnSistema.Caption = "HY ASESORES RRHH"

        'Se carga el skin por defecto

        DevExpress.Skins.SkinManager.EnableFormSkins()

        DevExpress.UserSkins.BonusSkins.Register()

        UserLookAndFeel.Default.SetSkinStyle(Tools.ReadAppSettings("Skin"))



        'Se actualiza la fuente de la aplicacion

        DevExpress.Utils.AppearanceObject.DefaultFont = New Font(Tools.ReadAppSettings("FuenteName"), Convert.ToSingle(Tools.ReadAppSettings("FuenteSize")), CType(Tools.ReadAppSettings("FuenteStyle"), System.Drawing.FontStyle))

        LookAndFeelHelper.ForceDefaultLookAndFeelChanged()


        ''VERSION
        'Dim dtSistemas As New DataTable
        'dtSistemas = BDCentralDAO.GetVersion(3)
        'If dtSistemas.Rows.Count > 0 Then
        '    btnVersion.Caption = "VERSIÓN: " + dtSistemas.Rows(0)("Version")
        'End If

        'CONTROL NAV BAR
        Dim ControlNavBar As New NavBarControl()
        Dim dtsubmodulos As DataTable
        dtsubmodulos = UsuarioDAO.GetSubModulos(BDCentralDAO.UsuarioBE.IdRol, 4)
        Me.Controls.Add(ControlNavBar)
        ControlNavBar.BeginUpdate()

        'ACCIONES DEL PERSONAL
        'Dim BarButtonItem As New BarButtonItem
        'Dim dtbutton As DataTable
        'dtbutton = UsuarioDAO.GetAcciones(1, 4)


        'For Each control In Me.Controls
        '    For i = 0 To dtbutton.Rows.Count - 1
        '        Dim button As Integer = dtbutton.Rows(i)(1)
        '        If button = control Then
        '            BarButtonItem.Visibility = BarItemVisibility.Never
        '        End If

        '    Next

        'Next
        'BarButtonItem.BeginUpdate()
        'For i = 0 To dtbutton.Rows.Count - 1
        '    Dim button As Integer = dtbutton.Rows(i)(1)
        '    If button = BarButtonItem.Tag Then
        '        BarButtonItem.Visibility = BarItemVisibility.Never
        '    End If

        'Next
        ', "Empleados por Renovar", "Renovación de Contratos", "Historial Renovación Contratos"----
        ControlesDevExpress.InitNavBar(ControlNavBar)
        ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"MANTENIMIENTO TABLAS", "Fuentes de Selección", "Conclusión de Selección", "Estados de Condición Actual", "Estados de Postulantes"}, My.Resources.Mantenimiento, dtsubmodulos)
        ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"SELECCIÓN DE PERSONAL", "Requerimientos Masivos", "Requerimientos No Masivos", "Postulantes Masivos Procesados", "Req. Procesados Masivos", "Req. Procesados No Masivos", "Listado de Postulantes Masivos", "Listado de Postulantes No Masivos", "Reporte: Canal de Reclutamiento", "Reporte: Conclusión de Postulantes", "Reporte: Puestos Por Canales de Reclutamiento", "Reporte: Requerimiento Masivos", "Reporte: Requerimiento del Personal"}, My.Resources.ReclutamientoSeleccion, dtsubmodulos)
        ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"ACCIONES DE PERSONAL", "Listado de Personal", "Ingreso de Personal"}, My.Resources.AccionPersonal, dtsubmodulos)
        ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"RENOVACIÓN DE CONTRATOS", "Empleados por renovar", "Renovación de Contratos", "Historial Renovacion de Contratos"}, My.Resources.AccionPersonal, dtsubmodulos)
        ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"MÓDULO DE PRÉSTAMOS", "Solicitud de préstamos", "Préstamos Revisados", "Préstamos Adryan", "Depósito de Prétamos", "Préstamos Abonados", "Historial de Préstamos"}, My.Resources.Prestamos, dtsubmodulos)
        ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"MÓDULO DE ASIGNACIÓN FAMILIAR", "Solicitud Asignación Familiar", "Historial Asignación Familiar", "Empleados Procesados Beneficio", "Listado Empleados Asignación Familiar", "Listado de Hijos"}, My.Resources.AsignacionFamiliar, dtsubmodulos)

        ' "Solicitudes de Requerimientos"
        ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"MÓDULO DE LACTANCIA", "Solicitud Lactancia", "Historial Lactancia"}, My.Resources.Lactancia, dtsubmodulos)
        ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"MÓDULO DE LICENCIAS", "Solicitud de licencias con goce", "Solicitud de licencias sin goce", "Solicitud de Descanso Médico", "Solicitudes de licencias: Registro Adryan", "Historial de Licencias Con Goce", "Historial de Licencias Sin Goce", "Historial de Descanso Médico"}, My.Resources.Licencias, dtsubmodulos)
        ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"MÓDULO DE MEMORANDUM", "Memorandums", "Memorandums Legal", "Memorandums Administración", "Historial de Memorandums"}, My.Resources.Memorandum, dtsubmodulos)
        ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"MÓDULO DE CESES", "Solicitud de Cese", "Solicitud de Cese: Legal", "Solicitud de Cese: no Legal", "Solicitud de Cese: Evaluación", "Historial de Cese"}, My.Resources.ReclutamientoSeleccion, dtsubmodulos)
        ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"MÓDULO DE RENUNCIAS", "Carta Renuncia", "Historial Carta de Renuncias"}, My.Resources.Renuncias, dtsubmodulos)
        ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"MÓDULO DE CAMBIO TEMPORAL", "Cambio Temporal", "Historial de cambios temporales"}, My.Resources.CambioTemporal, dtsubmodulos)
        ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"MÓDULO DE CAMBIO DEFINITIVO", "Cambio Definitivo", "Historial de cambios definitivos"}, My.Resources.CambioDefinitivo, dtsubmodulos)
        ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"MÓDULO DE INCIDENTE ACCIDENTE", "Informes de Incidente Accidente", "Historial de Incidente Accidente"}, My.Resources.IncidenteAccidente, dtsubmodulos)
        ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"MÓDULO DE CARTA CONOCIMIENTO", "Solicitud de CartaConocimiento", "Historial de Carta Conocimiento"}, My.Resources.CartaConocimiento, dtsubmodulos)
        ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"MÓDULO DE NEGACIÓN TRASLADO", "Solicitud de Negación Traslado", "Historial de Negación Traslado"}, My.Resources.NegacionTraslado, dtsubmodulos)
        ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"MÓDULO DE INFORMES GENERALES", "Informes Generales", "Historial de Informes Generales"}, My.Resources.InformesGenerales, dtsubmodulos)
        'ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"MÓDULO DE BONOS EXTRAS", "Solicitud Bonos Extras", "Historial Solicudes Bonos", "Bono por Antigüedad", "Beneficios Asignados Empleados"}, My.Resources.InformesGenerales, dtsubmodulos)
        ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"MÓDULO DE VACACIONES", "Solicitud de Vacaciones", "Historial de Vacaciones"}, My.Resources.InformesGenerales, dtsubmodulos)
        ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"MÓDULO DE SUSPENSIÓN PERFECTA", "Suspensión Perfecta", "Situación Laboral Empleado", "Historial Suspensión Perfecta"}, My.Resources.SuspensionPerfecta, dtsubmodulos)
        ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"MÓDULO CARTA CORRECTIVA", "Carta Correctiva", "Historial Carta Correctiva"}, My.Resources.SuspensionPerfecta, dtsubmodulos)
        'ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"MÓDULO DE CAPACITACIÓN", "Mantenimiento Tipo Escuela", "Mantenimiento Cursos", "Mantenimiento Sede Capacitaciones", "Programación Escuela", "Programación de Capacitaciones", "Capacitaciones Asignadas", "Listado Empleados"}, My.Resources.Capacitacion, dtsubmodulos)
        ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"MÓDULO DE CAPACITACIÓN", "Mantenimiento Tipo Escuela", "Mantenimiento Cursos", "Mantenimiento Sede Capacitaciones", "Programación Escuela"}, My.Resources.Capacitacion, dtsubmodulos)
        ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"MÓDULO DE PLANILLAS", "Fuente Consulta  de Planilla", "Respuesta Consulta de Planilla", "Concepto Planilla"}, My.Resources.Capacitacion, dtsubmodulos)
        'ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"MÓDULO DESCUENTOS REINTEGROS", "Consolidado", "Historial Consolidado", "Reporte Consolidado"}, My.Resources.InformesGenerales, dtsubmodulos)
        AddHandler ControlNavBar.LinkClicked, AddressOf DesktopMain_LinkClicked
        ControlNavBar.EndUpdate()

        'CORREO PARA ENVIO A TIENDA DE RECLUTAMIENTO Y SELECCION
        Dim dtEmailReclutamientoEnvio As New DataTable
        dtEmailReclutamientoEnvio = BDCentralDAO.GetDatosCorreoEnvio()
        If dtEmailReclutamientoEnvio.Rows.Count > 0 Then
            strCorreo = dtEmailReclutamientoEnvio.Rows(0)("CORREO")
            strClave = dtEmailReclutamientoEnvio.Rows(0)("CLAVE")
            strPuerto = dtEmailReclutamientoEnvio.Rows(0)("PUERTO")
            strHost = dtEmailReclutamientoEnvio.Rows(0)("HOST")
            strCorreoCopia = dtEmailReclutamientoEnvio.Rows(0)("CORREOCOPIA")
            'strCorreoCopia = "jcruz@norkys.pe" 'dtEmailReclutamientoEnvio.Rows(0)("jcruz@norkys.pe")
        End If

    End Sub

    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.SetSkinStyle(My.Settings.skin)
    End Sub

    Private Sub DesktopMain_LinkClicked(ByVal sender As Object, ByVal e As NavBarLinkEventArgs)
        Select Case e.Link.Caption.ToString
            'MANTENIMIENTO
            Case "Fuentes de Selección" : OpenFormulario("FuenteReclutamiento")
            Case "Conclusión de Selección" : OpenFormulario("Conclusion")
            Case "Estados de Condición Actual" : OpenFormulario("EstadoCondicionActual")
            Case "Estados de Postulantes" : OpenFormulario("EstadoPostulante")


            'REQUERIMIENTO DE PERSONAL
            'Case "Solicitudes de Requerimientos" : OpenFormulario("SolicitudesRequerimientosList")
            Case "Requerimientos Masivos" : OpenFormulario("RequerimientosMasivos")
            Case "Requerimientos No Masivos" : OpenFormulario("RequerimientosNoMasivos")
            Case "Postulantes Masivos Procesados" : OpenFormulario("PostulantesMasivosProcesados")
            Case "Req. Procesados Masivos" : OpenFormulario("RequerimientosProcesadosMasivos")
            Case "Req. Procesados No Masivos" : OpenFormulario("RequerimientosProcesadosNoMasivos")
            Case "Listado de Postulantes Masivos" : OpenFormulario("ListadoPostulantesMasivos")
            Case "Listado de Postulantes No Masivos" : OpenFormulario("ListadoPostulantesNoMasivos")
            Case "Reporte: Canal de Reclutamiento" : OpenFormulario("rptEmisionCanalesReclutamiento")
            Case "Reporte: Conclusión de Postulantes" : OpenFormulario("rptEmisionConclusionPostulanteCanalReclutamiento")
            Case "Reporte: Puestos Por Canales de Reclutamiento" : OpenFormulario("rptEmisionPuestosPorCanalReclutamiento")
            Case "Reporte: Requerimiento Masivos" : OpenFormulario("rptEmisionRequerimientosMasivos")
            Case "Reporte: Requerimiento del Personal" : OpenFormulario("rptEmisionRequerimientoPersonal")

            'ACCIONES DE PERSONAL
            Case "Listado de Personal" : OpenFormulario("EmpleadoList")
            Case "Ingreso de Personal" : OpenFormulario("EmpleadoIngresoList")
            Case "Renuncias" : OpenFormulario("EmpleadoCeseList")
            Case "Reingreso de Personal" : OpenFormulario("EmpleadoReingresoList")
            Case "Corrección de datos" : OpenFormulario("EmpleadoModificacionDatos")

            'RENOVACIÓN DE CONTRATO
            Case "Empleados por renovar" : OpenFormulario("EmpleadoRenovacionList")
            Case "Renovación de Contratos" : OpenFormulario("EmpleadoRenovacionContratoList")
            Case "Historial Renovacion de Contratos" : OpenFormulario("EmpleadoHistorialRenovacion")
            'Case "Listado de Empleados por Renovar" : OpenFormulario("EmpleadoRenovacionList")

            Case "Aumento de Sueldo"
                'BDAccionPersonalDAO.IdEmpleado = 0
                'Dim MiForm As New EmpleadoAumentoSalarial
                'MiForm.ShowDialog()
            Case "Movimiento de Personal"
                'BDAccionPersonalDAO.IdEmpleado = 0
                'Dim MiForm As New EmpleadoMovimiento
                'MiForm.ShowDialog()
            'PRESTAMOS
            Case "Solicitud de préstamos" : OpenFormulario("SolicitudPrestamoList")
            Case "Préstamos Revisados" : OpenFormulario("PrestamosRevisadosList")
            Case "Préstamos Adryan" : OpenFormulario("PrestamosAdryanList")
            Case "Depósito de Prétamos" : OpenFormulario("PrestamosDepositoList")
            Case "Historial de Préstamos" : OpenFormulario("SolicitudPrestamoListHistorial")
                'ASIGNACIÓN FAMILIAR    
            Case "Solicitud Asignación Familiar" : OpenFormulario("SolicitudAsignacionFamiliarList")
            Case "Historial Asignación Familiar" : OpenFormulario("SolicitudAsignacionFamiliarListHistorial")
            Case "Listado de Hijos" : OpenFormulario("ListadoHijos")
            Case "Listado Empleados Asignación Familiar" : OpenFormulario("ListadoEmpleadosAsignacionFamiliar")
            Case "Empleados Procesados Beneficio" : OpenFormulario("ListadoDesasignarAsignacionFamiliar")

                'LACTANCIA
            Case "Solicitud Lactancia" : OpenFormulario("LactanciaList")
            Case "Historial Lactancia" : OpenFormulario("LactanciaListHistorial")

                'LICENCIAS
            Case "Solicitud de licencias con goce" : OpenFormulario("LicenciasConGoceList")
            Case "Solicitud de licencias sin goce" : OpenFormulario("LicenciasSinGoceList")
            Case "Solicitud de Descanso Médico" : OpenFormulario("LicenciaEnfermedadList")
            Case "Solicitudes de licencias: Registro Adryan" : OpenFormulario("LicenciasValidadasList")
            Case "Historial de Licencias Con Goce" : OpenFormulario("LicenciaConGoceListHistorial")
            Case "Historial de Licencias Sin Goce" : OpenFormulario("LicenciaSinGoceListHistorial")
            Case "Historial de Descanso Médico" : OpenFormulario("LicenciaEnfermedadListHistorial")

            'MEMORANDUMS
            Case "Memorandums" : OpenFormulario("MemorandumList")
            Case "Memorandums Legal" : OpenFormulario("MemorandumLegalList")
            Case "Memorandums Administración" : OpenFormulario("MemorandumLegalEvaluadosList")
            Case "Historial de Memorandums" : OpenFormulario("MemorandumListHistorial")

           'CESES
            Case "Solicitud de Cese" : OpenFormulario("SolicitudCeseList")

            'Case "Cese de Personal" : OpenFormulario("EmpleadoCeseList")
            Case "Solicitud de Cese: Legal" : OpenFormulario("SolicitudCeseLegalList")
            Case "Solicitud de Cese: no Legal" : OpenFormulario("SolicitudCeseNoLegalList")
            Case "Solicitud de Cese: Evaluación" : OpenFormulario("SolicitudCeseEvaluadosList")
            Case "Historial de Cese" : OpenFormulario("EmpleadoCeseListHistorial")

                'RENUNCIAS
            Case "Carta Renuncia" : OpenFormulario("SolicitudCartaRenunciaList")
            Case "Historial Carta de Renuncias" : OpenFormulario("CartaRenunciaListHistorial")
                'CAMBIOLOCAL TEMPORAL
            Case "Cambio Temporal" : OpenFormulario("CambioTemporalList")
            Case "Historial de cambios temporales" : OpenFormulario("CambioTemporalListHistorial")
                'CAMBIO DEFINITIVO
            Case "Cambio Definitivo" : OpenFormulario("CambioDefinitivoList")
            Case "Historial de cambios definitivos" : OpenFormulario("CambioDefinitivoListHistorial")
                'INCIDENTE ACCIDENTE
            Case "Informes de Incidente Accidente" : OpenFormulario("IncidenteAccidenteList")
            Case "Historial de Incidente Accidente" : OpenFormulario("IncidenteAccidenteHistorialList")
                'CARTA CONOCIMIENTO
            Case "Solicitud de CartaConocimiento" : OpenFormulario("CartaConocimientoList")
            Case "Historial de Carta Conocimiento" : OpenFormulario("CartaConocimientoHistorialList")
                'NEGACIÓN TRASLADO
            Case "Solicitud de Negación Traslado" : OpenFormulario("NegacionTrasladoList")
            Case "Historial de Negación Traslado" : OpenFormulario("NegacionTrasladoHistorialList")
                'INFORME GENERAL
            Case "Informes Generales" : OpenFormulario("InformeGeneralList")
            Case "Historial de Informes Generales" : OpenFormulario("InformeGeneralHistorialList")
                'SOLICITUD DE VACACIONES
            Case "Solicitud de Vacaciones" : OpenFormulario("SolicitudVacacionesList")
            Case "Historial de Vacaciones" : OpenFormulario("VacacionesHistorialList")

             'SUSPENSIÓN PERFECTA'
            Case "Suspensión Perfecta" : OpenFormulario("SuspensionPerfectaList")
            Case "Situación Laboral Empleado" : OpenFormulario("SuspensionPerfectaEmpleadoList")
            Case "Historial Suspensión Perfecta" : OpenFormulario("SuspensionPerfectaHistorialList")

                'CARTA CORRECTIVA
            Case "Carta Correctiva" : OpenFormulario("SolicitudCartaCorrectivaList")
            Case "Historial Carta Correctiva" : OpenFormulario("SolicitudCartaCorrectivaListHistorial")

                'CAPACITACIÓN
            Case "Mantenimiento Tipo Escuela" : OpenFormulario("MantenimientoTipoEscuela")
            Case "Mantenimiento Cursos" : OpenFormulario("MantenimientoCurso")
            Case "Mantenimiento Sede Capacitaciones" : OpenFormulario("MantenimientoSede")
            Case "Programación de Capacitaciones" : OpenFormulario("ProgramacionCapacitacion")

                  'PLANILLAS
            Case "Fuente Consulta  de Planilla" : OpenFormulario("CargaPlanilla")
            Case "Respuesta Consulta de Planilla" : OpenFormulario("RespuestaPlanilla")
            Case "Concepto Planilla" : OpenFormulario("ConceptoPlanilla")


                'Case "Capacitaciones Asignadas" : OpenFormulario("CapacitacionesAsignadas")
                'Case "Programación Escuela" : OpenFormulario("ProgramacionEscuela")
                'Case "Listado Empleados" : OpenFormulario("ListadoEmpleado")

                'BONOS EXTRAS
                'Case "Solicitud Bonos Extras" : OpenFormulario("SolicitudBonoExtraList")
                'Case "Historial Solicudes Bonos" : OpenFormulario("SolicitudBonoExtraListHistorial")
                'Case "Bono por Antigüedad" : OpenFormulario("BonoAntiguedadList")
                'Case "Beneficios Asignados Empleados" : OpenFormulario("BonoExtraEmpleadoList")


                'DESCUENTOS RENOVACIONES
                'Case "Consolidado" : OpenFormulario("DescuentoReintegroList")
                'Case "Historial Consolidado" : OpenFormulario("DescuentoReintegroHistorialList")
                'Case "Reporte Consolidado" : OpenFormulario("ReporteDescuentoReintegroPrestamoList")

        End Select
    End Sub

    Public Sub OpenFormulario(NombreFormulario As String)
        Dim obj As Object
        Dim NombreAssembly As String = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name()

        'Se busca el formulario. Si no existe se crea la instancia, caso contrario solo se activa. 
        If Me.MdiChildren.ToList.Find(Function(Item) Item.Name = NombreFormulario) Is Nothing Then
            obj = Activator.CreateInstance(Type.GetType(NombreAssembly + "." + NombreFormulario))
            obj.MdiParent = Me
            obj.Name = NombreFormulario
            obj.WindowState = FormWindowState.Maximized
            obj.Show()
        Else
            For Each objForms In Me.MdiChildren
                If objForms.Name = NombreFormulario Then
                    objForms.WindowState = FormWindowState.Maximized
                    objForms.Show()
                End If
            Next
        End If

    End Sub



    Private Sub MEDesktop_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("es-PE")

            Me.Update()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub MEDesktop_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Public Function MinimizarFormularioActivo() As String
        Dim Result As String = String.Empty
        Dim MiForm As System.Windows.Forms.Form = CType(Me.ActiveMdiChild, System.Windows.Forms.Form)

        If Not MiForm Is Nothing Then
            MiForm.WindowState = FormWindowState.Minimized
            Result = MiForm.Name
        End If
        Return Result
    End Function


    '------- SISTEMA OPCIONES ----------
    Private Sub btnSalirSistema_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnSalirSistema.ItemClick
        If MessageBox.Show("¿Esta seguro de salir del programa?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnFuente_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnFuente.ItemClick
        Try
            If FontDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

                DevExpress.Utils.AppearanceObject.DefaultFont = New Font(FontDialog1.Font.Name, FontDialog1.Font.Size, FontDialog1.Font.Style)

                LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

                Tools.SaveAppSettings("FuenteName", FontDialog1.Font.Name)
                Tools.SaveAppSettings("FuenteSize", FontDialog1.Font.Size)
                Tools.SaveAppSettings("FuenteStyle", FontDialog1.Font.Style)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub rgbiSkins_GalleryItemClick(sender As Object, e As GalleryItemClickEventArgs) Handles rgbiSkins.GalleryItemClick
        Try
            Tools.SaveAppSettings("Skin", e.Item.Caption)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class



