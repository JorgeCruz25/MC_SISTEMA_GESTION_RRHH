Imports MC.Data
Imports System.Net.Mail
Imports System.Net
Imports System.Security.Cryptography.X509Certificates
Imports System.Net.Security
Imports MC.Framework
Imports DevExpress.XtraGrid.Views.Base
Imports System.Net.Mime

Public Class RQMasivosPostulantes

    Dim PostulanteMasivoBE As New PostulanteMasivoBE
    Dim EmpleadoReingresoBE As New EmpleadoReingresoBE
    Private Sub ListarPostulantesMasivos()
        inabilitarbotones()
        Dim dtAccionesUsuario As DataTable
        dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
        Tools.AccionesUsuarioRibbon(RibbonControl, dtAccionesUsuario)
        GridControl1.DataSource = BDCentralDAO.GetPostulantesMasivosList
    End Sub
    Private Sub inabilitarbotones()
        btnNuevo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnEnviarCorreo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnProcesar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub
    Private Sub ActualizarEdicionGrilla()
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()

        'GridView1.ClearColumnsFilter()
        'GridView1.FindFilterText = ""
    End Sub

    Private Sub RQMasivosPostulantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtRazonComercial.Caption = "RAZON COMERCIAR: " + BDCentralDAO.RazonComercial
        txtPuestoRequerido.Caption = "CARGO REQUERIDO: " + BDCentralDAO.CargoRequerido

        GridView1.Columns(0).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(1).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(2).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(3).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(4).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(5).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(6).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left

        RepositoryItemGridLookUpEditTipoIdentidad.DataSource = BDCentralDAO.GetTipoIdentidadList
        RepositoryItemGridLookUpEditTipoIdentidad.ValueMember = "IDTIPODOCUMENTOIDENTIDAD"
        RepositoryItemGridLookUpEditTipoIdentidad.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditDistrito.DataSource = BDCentralDAO.GetDistritoList
        RepositoryItemGridLookUpEditDistrito.ValueMember = "IDUBIGEO"
        RepositoryItemGridLookUpEditDistrito.DisplayMember = "DISTRITO"

        RepositoryItemGridLookUpEditSexo.DataSource = BDCentralDAO.GetSexoList
        RepositoryItemGridLookUpEditSexo.ValueMember = "IDSEXO"
        RepositoryItemGridLookUpEditSexo.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditCargo.DataSource = BDCentralDAO.GetCargoList
        RepositoryItemGridLookUpEditCargo.ValueMember = "IDCARGO"
        RepositoryItemGridLookUpEditCargo.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditCargo2.DataSource = BDCentralDAO.GetCargoList
        RepositoryItemGridLookUpEditCargo2.ValueMember = "IDCARGO"
        RepositoryItemGridLookUpEditCargo2.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditFuente.DataSource = BDCentralDAO.GetFuenteReclutamientoList
        RepositoryItemGridLookUpEditFuente.ValueMember = "IDFUENTE"
        RepositoryItemGridLookUpEditFuente.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditFuenteDetalle.DataSource = BDCentralDAO.GetFuenteReclutamientoDetalleList
        RepositoryItemGridLookUpEditFuenteDetalle.ValueMember = "IDFUENTEDETALLE"
        RepositoryItemGridLookUpEditFuenteDetalle.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditConclusion.DataSource = BDCentralDAO.GetConclusionList
        RepositoryItemGridLookUpEditConclusion.ValueMember = "IDCONCLUSION"
        RepositoryItemGridLookUpEditConclusion.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditConclusionDetalle.DataSource = BDCentralDAO.GetConclusionDetalleList
        RepositoryItemGridLookUpEditConclusionDetalle.ValueMember = "IDCONCLUSIONDETALLE"
        RepositoryItemGridLookUpEditConclusionDetalle.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditTienda.DataSource = BDCentralDAO.GetLocalListAll

        RepositoryItemGridLookUpEditTienda.ValueMember = "IDLOCAL"
        RepositoryItemGridLookUpEditTienda.DisplayMember = "LOCAL"




        'ControlesDevExpress.InitGridViewColumn(GridViewCargo, "ID", "IDCARGO", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridViewCargo, "CARGO", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        'With GridViewCargo
        '    .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        'End With

        'sleCargo.Properties.DataSource = BDAccionPersonalDAO.GetCargoList
        'sleCargo.Properties.DisplayMember = "DESCRIPCION"
        'sleCargo.Properties.ValueMember = "IDCARGO"
        'sleCargo.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup



        RepositoryItemGridLookUpEditTurno.DataSource = BDCentralDAO.GetTunoPersonalList
        RepositoryItemGridLookUpEditTurno.ValueMember = "IDTURNO"
        RepositoryItemGridLookUpEditTurno.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditCondicionActual.DataSource = BDCentralDAO.GetEstadoCondicionActualList
        RepositoryItemGridLookUpEditCondicionActual.ValueMember = "IDCONDICIONACTUAL"
        RepositoryItemGridLookUpEditCondicionActual.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditTipoIdentidad.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        RepositoryItemGridLookUpEditDistrito.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        RepositoryItemGridLookUpEditSexo.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        RepositoryItemGridLookUpEditCargo.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        RepositoryItemGridLookUpEditCargo2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        RepositoryItemGridLookUpEditFuente.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        RepositoryItemGridLookUpEditFuenteDetalle.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        RepositoryItemGridLookUpEditConclusion.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        RepositoryItemGridLookUpEditConclusionDetalle.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        RepositoryItemGridLookUpEditTienda.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        RepositoryItemGridLookUpEditTurno.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        RepositoryItemGridLookUpEditCondicionActual.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

        ListarPostulantesMasivos()


    End Sub
    Private Sub GridView1_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView1.RowUpdated
        Cursor = Cursors.WaitCursor

        With PostulanteMasivoBE
            .IDPOSTULANTEMASIVO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDPOSTULANTEMASIVO")
            .IDTIPODOCUMENTOIDENTIDAD = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDTIPODOCUMENTOIDENTIDAD").ToString
            .NUMERODOCUMENTO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "NUMERODOCUMENTO").ToString
            .NOMBRES = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "NOMBRES").ToString
            .APELLIDOPATERNO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "APELLIDOPATERNO").ToString
            .APELLIDOMATERNO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "APELLIDOMATERNO").ToString
            .TELEFONO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "TELEFONO").ToString
            .CORREO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CORREO").ToString

            .IDUBIGEO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDUBIGEO")

            Dim xUBIGEO As Integer
            Dim xProvincia As String
            Dim xDepartamento As String
            Dim dtDistrito As New DataTable

            If .IDUBIGEO = 0 Then
                xProvincia = ""
                xDepartamento = ""
            Else
                xUBIGEO = .IDUBIGEO
                dtDistrito = BDCentralDAO.GetDistritoListID(xUBIGEO)
                xProvincia = dtDistrito.Rows(0)("PROVINCIA").ToString
                xDepartamento = dtDistrito.Rows(0)("DEPARTAMENTO").ToString
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "PROVINCIA", xProvincia)
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "DEPARTAMENTO", xDepartamento)
            End If
            .PROVINCIA = xProvincia
            .DEPARTAMENTO = xDepartamento

            .FECHANACIMIENTO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHANACIMIENTO").ToString

            Dim xdate As Date
            Dim xYearNacimiento As Integer
            Dim xYearActual As Integer
            Dim xEdad As Integer

            If .FECHANACIMIENTO = "1900-01-01" Then
                xEdad = 0
            Else
                xdate = .FECHANACIMIENTO
                xYearNacimiento = Year(xdate)
                xYearActual = Year(Now)
                xEdad = xYearActual - xYearNacimiento
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "EDAD", xEdad)
            End If

            .EDAD = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "EDAD").ToString
            .IDSEXO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDSEXO")
            .IDCARGO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDCARGO")
            .IDCARGO2 = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDCARGO2")

            .IDFUENTEDETALLE = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDFUENTEDETALLE")

            If .IDFUENTEDETALLE = 0 Then
                .IDFUENTE = 0
            Else
                Dim xIDFUENTE As Integer
                xIDFUENTE = BDCentralDAO.GetObtenerIDFuente(.IDFUENTEDETALLE)
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "IDFUENTE", xIDFUENTE)
            End If
            .IDFUENTE = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDFUENTE")

            .IDCONCLUSIONDETALLE = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDCONCLUSIONDETALLE")

            If .IDCONCLUSIONDETALLE = 0 Then
                .IDCONCLUSION = 0
            Else
                Dim xIDCONCLUSION As Integer
                xIDCONCLUSION = BDCentralDAO.GetObtenerIDConlusion(.IDCONCLUSIONDETALLE)
                GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "IDCONCLUSION", xIDCONCLUSION)
            End If
            .IDCONCLUSION = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDCONCLUSION")

            .IDTIENDA = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDTIENDA")
            .FECHACONVOCATORIA = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHACONVOCATORIA")
            .FECHAEVALUACION = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAEVALUACION")
            .OBSERVACION = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "OBSERVACION").ToString
            .IDTURNO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDTURNO")
            .FECHAFIRMACONTRATO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAFIRMACONTRATO")
            .FECHAENVIOCORREO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAENVIACORREO")
            .FECHAINGRESOTIENDAPROGRAMADO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAINGRESOTIENDAPROGRAMADO")
            .FECHARESPUESTACORREO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHARESPUESTACORREO")
            .FECHAINGRESOTIENDAREAL = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAINGRESOTIENDAREAL")
            .SEGUIMIENTOQUINCENALFECHA = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "SEGUIMIENTOQUINCENALFECHA")
            .IDCONDICIONACTUAL = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDCONDICIONACTUAL")
            .SEGUIMIENTOQUINCENALOBSERVACION = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "SEGUIMIENTOQUINCENALOBSERVACION").ToString
            .ESTADOASIGNACION = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ESTADOASIGNACION")
        End With

        BDCentralDAO.PostulanteMasivoUpdate(PostulanteMasivoBE)

        Cursor = Cursors.Default
    End Sub

    Private Sub btnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick
        Dim MiForm As New RQMasivosPostulantesAgregar
        MiForm.ShowDialog()
        ListarPostulantesMasivos()
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        ActualizarEdicionGrilla()
        ListarPostulantesMasivos()
    End Sub

    Private Sub btnEnviarCorreo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEnviarCorreo.ItemClick
        ActualizarEdicionGrilla()

        If MessageBox.Show("Desea enviar el Correo?", "Envio de Correo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Cursor = Cursors.WaitCursor

            Dim idtipoidentidad As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDTIPODOCUMENTOIDENTIDAD")
            Dim idtienda As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDTIENDA")
            Dim fechaingreso As Date = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAINGRESOTIENDAPROGRAMADO").ToString

            Dim fechafirmacontrato As Date = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHAFIRMACONTRATO").ToString
            Dim idcargo As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDCARGO")
            Dim numeroidentidad As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "NUMERODOCUMENTO").ToString
            Dim nombres As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "NOMBRES").ToString
            Dim apellidopaterno As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "APELLIDOPATERNO").ToString
            Dim apellidomaterno As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "APELLIDOMATERNO").ToString


            If idtipoidentidad = 0 Or numeroidentidad = "" Then
                Cursor = Cursors.Default
                MessageBox.Show("Información incompleta, ingresar el tipo y número de identidad para poder enviar el correo.")
                Exit Sub
            End If

            If nombres = "" Or apellidopaterno = "" Or apellidomaterno = "" Then
                Cursor = Cursors.Default
                MessageBox.Show("Información incompleta, ingresar el nombre y apellidos para poder enviar el correo.")
                Exit Sub
            End If

            If idcargo = 0 Then
                Cursor = Cursors.Default
                MessageBox.Show("Información incompleta, ingresar el cargo para poder enviar el correo.")
                Exit Sub
            End If

            If idtienda = 0 Then
                Cursor = Cursors.Default
                MessageBox.Show("Información incompleta, Ingresar la tienda para poder enviar el correo.")
                Exit Sub
            End If

            If fechaingreso = "1900-01-01" Or fechafirmacontrato = "1900-01-01" Then
                Cursor = Cursors.Default
                MessageBox.Show("Información incompleta, ingresar fecha de ingreso y firma de contrato para poder enviar el correo.")
                Exit Sub
            End If

            Dim dtEmail As New DataTable
            dtEmail = BDCentralDAO.GetDatosCorreo(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDPOSTULANTEMASIVO"))

            If dtEmail.Rows.Count > 0 Then
                If dtEmail.Rows(0)("FECHAENVIACORREO") = "01/01/1900" Then
                Else
                    If MessageBox.Show("El postulante ya tiene un correo enviado, desea enviar el correo?", "Envio de Correo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Else
                        Cursor = Cursors.Default
                        Exit Sub
                    End If
                End If
            Else
                Cursor = Cursors.Default
                Exit Sub
            End If

            Dim correolocal As String = dtEmail.Rows(0)("LOCALCORREO")
            Dim correosupervisor As String = ""
            Dim correojefezonal As String = ""

            Dim txLocal As String = dtEmail.Rows(0)("LOCAL")
            Dim txPuesto As String = dtEmail.Rows(0)("CARGO")
            Dim txNumeroIdentidad As String = dtEmail.Rows(0)("NUMERODOCUMENTO")
            Dim txApellidoPaterno As String = dtEmail.Rows(0)("APELLIDOPATERNO")
            Dim txApellidoMaterno As String = dtEmail.Rows(0)("APELLIDOMATERNO")
            Dim txNombres As String = dtEmail.Rows(0)("NOMBRES")
            Dim txFechaIngreso As String = dtEmail.Rows(0)("FECHAINGRESO")
            Dim txHoraIngreso As String = dtEmail.Rows(0)("HORAINGRESO")

            Dim dtSupervisor As New DataTable
            dtSupervisor = BDCentralDAO.GetDatosCorreoSupervisor(idtienda)

            If dtSupervisor.Rows.Count > 0 Then
                For i As Integer = 0 To dtSupervisor.Rows.Count - 1
                    correosupervisor = correosupervisor + "," + dtSupervisor.Rows(i)("CORREO")
                Next
            End If

            Dim dtJefeZonal As New DataTable
            dtJefeZonal = BDCentralDAO.GetDatosCorreoJefeZonal(idtienda)

            If dtJefeZonal.Rows.Count > 0 Then
                For j As Integer = 0 To dtSupervisor.Rows.Count - 1
                    correojefezonal = correojefezonal + "," + dtJefeZonal.Rows(j)("CORREO")
                Next
            End If

            Try
                Dim emailTo As String
                emailTo = correolocal + correosupervisor + correojefezonal + "," + strCorreoCopia

                'Dim Mensaje As String
                'Mensaje = "<font face=Calibri size=3> Estimado Administrador, " & "<br>" & "<br>" &
                '          "Hacemos de su conocimiento la incorporación del nuevo colaborador a la tienda que tiene bajo su dirección: </font>" & "<br>" &
                '         "<table border=1 cellspacing=0 cellpadding=2>" &
                '         "<tr><td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px bgcolor=red>TIENDA</td> <td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px bgcolor=#edd23e>PUESTO</td> <td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px bgcolor=#edd23e>DNI</td> <td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px bgcolor=#edd23e>APELLIDO PATERNO</td> <td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px bgcolor=#edd23e>APELLIDO MATERNO</td> <td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px bgcolor=#edd23e>NOMBRES</td> <td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px bgcolor=#edd23e>FECHA INGRESO</td> <td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px bgcolor=#edd23e>HORA INGRESO</td></tr>" &
                '         "<tr><td style=font-family:Calibri;font-size:15px> " & txLocal & "</td> <td style=font-family:Calibri;font-size:15px>" & txPuesto & "</td> <td style=font-family:Calibri;font-size:15px>" & txNumeroIdentidad & "</td> <td style=font-family:Calibri;font-size:15px>" & txApellidoPaterno & "</td> <td style=font-family:Calibri;font-size:15px>" & txApellidoMaterno & "</td> <td style=font-family:Calibri;font-size:15px>" & txNombres & "</td> <td style=font-family:Calibri;font-size:15px>" & txFechaIngreso & "</td> <td style=font-family:Calibri;font-size:15px>" & txHoraIngreso & "</td></tr>" &
                '         "</table>" &
                '         "<br>" & "<br>" &
                '         "<font face=Calibri size=3> Los nuevos ingresantes deben presentarse de la siguiente manera: </font>" & "<br>" & "<br>" &
                '         "<table border=1 cellspacing=0 cellpadding=2>" &
                '         "<tr><td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px bgcolor=#b7b7b2>PRODUCCIÓN / LIMPIEZA</td> <td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px bgcolor=#b7b7b2>SALÓN / CAJA / BAR</td> <td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:13px bgcolor=#b7b7b2>MOTORIZADO</td></tr>" &
                '         "<tr><td style=font-family:Calibri;font-size:15px>Jean azul (simple)</td> <td style=font-family:Calibri;font-size:15px>Pantalón de vestir negro</td> <td style=font-family:Calibri;font-size:15px>Pantalón Jean (simple) y camisa blanca</td></tr>" &
                '         "<tr><td style=font-family:Calibri;font-size:15px>Polo blanco (simple)</td> <td style=font-family:Calibri;font-size:15px>Blusa / camisa blanca y corbata</td> <td style=font-family:Calibri;font-size:15px>Casaca oscura + Casco + Guantes</td></tr>" &
                '         "<tr><td style=font-family:Calibri;font-size:15px>Zapatillas oscuros</td> <td style=font-family:Calibri;font-size:15px>Zapatos negro (suela de goma)</td> <td style=font-family:Calibri;font-size:15px>Calzado negro cerrado</td></tr>" &
                '         "<tr><td colspan=3 style=font-family:Calibri;font-size:15px>Varones (cabello corto, uñas limpias)</td></tr>" &
                '         "<tr><td colspan=3 style=font-family:Calibri;font-size:15px>Damas (maquillaje suave o sin maquillaje y sin joyas, uñas limpias, cabello recogido)</td></tr>" &
                '         "</table>" &
                '         "<br>" & "<br>" &
                '         "<font face=Calibri size=3> Es <b>DEBER</b> del Administrador de la tienda:<br>" &
                '         " 1. Brindar la inducción a los nuevos colaboradores el mismo día de su ingreso." & "<br>" &
                '         " 2. Informar al nuevo colaborador de su incorporación y fecha de inicio a las escuelas de capacitación de acuerdo a su puesto de trabajo previamente coordinadas con el área respectiva." & "<br>" & "<br>" &
                '         "Se solicita <b>CONFIRMAR</b> (Obligatorio) la asistencia del nuevo colaborador, respondiendo a este mismo correo, para formalizar su incorporación a la empresa." & "<br>" & "<br>" &
                '         "<b>IMPORTANTE: </b> Queda prohibido realizar CAMBIOS DE PUESTOS Y/O RAZÓN SOCIAL del nuevo ingresante sin previa coordinación del área de R&S a través del correo electrónico o teléfono." & "<br>" & "<br>" & "<br>" &
                '         "Saludos cordiales, </font>" & "<br>"

                'BDCentralDAO.InsertEnvioCorreo(emailTo, "Incorporación a Tienda – Nuevo Colaborador", Mensaje)

                'emailTo = "jcruz@norkys.pe,pdiaz@macroscem.com"
                Send(emailTo, "Incorporación a Tienda – Nuevo Colaborador", " <font face=Calibri size=3> Estimado Administrador, " & "<br>" & "<br>" &
                                    "Hacemos de su conocimiento la incorporación del nuevo colaborador a la tienda que tiene bajo su dirección: </font>" & "<br>" &
                                    "<table border=1 cellspacing=0 cellpadding=2>" &
                                    "<tr><td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px bgcolor=red>TIENDA</td> <td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px bgcolor=#edd23e>PUESTO</td> <td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px bgcolor=#edd23e>DNI</td> <td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px bgcolor=#edd23e>APELLIDO PATERNO</td> <td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px bgcolor=#edd23e>APELLIDO MATERNO</td> <td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px bgcolor=#edd23e>NOMBRES</td> <td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px bgcolor=#edd23e>FECHA INGRESO</td> <td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px bgcolor=#edd23e>HORA INGRESO</td></tr>" &
                                    "<tr><td style=font-family:Calibri;font-size:15px> " & txLocal & "</td> <td style=font-family:Calibri;font-size:15px>" & txPuesto & "</td> <td style=font-family:Calibri;font-size:15px>" & txNumeroIdentidad & "</td> <td style=font-family:Calibri;font-size:15px>" & txApellidoPaterno & "</td> <td style=font-family:Calibri;font-size:15px>" & txApellidoMaterno & "</td> <td style=font-family:Calibri;font-size:15px>" & txNombres & "</td> <td style=font-family:Calibri;font-size:15px>" & txFechaIngreso & "</td> <td style=font-family:Calibri;font-size:15px>" & txHoraIngreso & "</td></tr>" &
                                    "</table>" &
                                    "<br>" & "<br>" &
                                    "<font face=Calibri size=3> Los nuevos ingresantes deben presentarse de la siguiente manera: </font>" & "<br>" & "<br>" &
                                    "<table border=1 cellspacing=0 cellpadding=2>" &
                                    "<tr><td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px bgcolor=#b7b7b2>PRODUCCIÓN / LIMPIEZA</td> <td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px bgcolor=#b7b7b2>SALÓN / CAJA / BAR</td> <td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:13px bgcolor=#b7b7b2>MOTORIZADO</td></tr>" &
                                    "<tr><td style=font-family:Calibri;font-size:15px>Jean azul (simple)</td> <td style=font-family:Calibri;font-size:15px>Pantalón de vestir negro</td> <td style=font-family:Calibri;font-size:15px>Pantalón Jean (simple) y camisa blanca</td></tr>" &
                                    "<tr><td style=font-family:Calibri;font-size:15px>Polo blanco (simple)</td> <td style=font-family:Calibri;font-size:15px>Blusa / camisa blanca y corbata</td> <td style=font-family:Calibri;font-size:15px>Casaca oscura + Casco + Guantes</td></tr>" &
                                    "<tr><td style=font-family:Calibri;font-size:15px>Zapatillas oscuros</td> <td style=font-family:Calibri;font-size:15px>Zapatos negro (suela de goma)</td> <td style=font-family:Calibri;font-size:15px>Calzado negro cerrado</td></tr>" &
                                    "<tr><td colspan=3 style=font-family:Calibri;font-size:15px>Varones (cabello corto, uñas limpias)</td></tr>" &
                                    "<tr><td colspan=3 style=font-family:Calibri;font-size:15px>Damas (maquillaje suave o sin maquillaje y sin joyas, uñas limpias, cabello recogido)</td></tr>" &
                                    "</table>" &
                                    "<br>" & "<br>" &
                                    "<font face=Calibri size=3> Es <b>DEBER</b> del Administrador de la tienda:<br>" &
                                    " 1. Brindar la inducción a los nuevos colaboradores el mismo día de su ingreso." & "<br>" &
                                    " 2. Informar al nuevo colaborador de su incorporación y fecha de inicio a las escuelas de capacitación de acuerdo a su puesto de trabajo previamente coordinadas con el área respectiva." & "<br>" & "<br>" &
                                    "Se solicita <b>CONFIRMAR</b> (Obligatorio) la asistencia del nuevo colaborador, respondiendo a este mismo correo, para formalizar su incorporación a la empresa." & "<br>" & "<br>" &
                                    "<b>IMPORTANTE: </b> Queda prohibido realizar CAMBIOS DE PUESTOS Y/O RAZÓN SOCIAL del nuevo ingresante sin previa coordinación del área de R&S a través del correo electrónico o teléfono." & "<br>" & "<br>" & "<br>" &
                                    "Saludos cordiales, </font>" & "<br>", True)
            Catch ex As Exception
                Cursor = Cursors.Default
                MessageBox.Show("Ocurrio un error al enviar el correo.")
                Exit Sub
            End Try

            BDCentralDAO.PostulanteMasivoUpdateEnvioCorreo(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDPOSTULANTEMASIVO"))
            Cursor = Cursors.Default
            MessageBox.Show("Correo enviado correctamente.")

        End If

    End Sub

    Public Sub Send(EmailTo As String, Subject As String, Mensaje As String, Optional Prioridad As Boolean = False)

        Dim avHtml As AlternateView = AlternateView.CreateAlternateViewFromString(Mensaje, Nothing, MediaTypeNames.Text.Html)



        Dim EmailMessage As New MailMessage
        With EmailMessage
            .From = New MailAddress(strCorreo)
            .To.Add(EmailTo)
            .Subject = Subject
            .Body = Mensaje
            .IsBodyHtml = True



            .SubjectEncoding = System.Text.Encoding.UTF8
            .IsBodyHtml = False
            .Body = Mensaje
            .AlternateViews.Add(avHtml)


        End With

        'Se crea la cuenta de envio
        Dim smtpClient As New SmtpClient()

        smtpClient.UseDefaultCredentials = False
        smtpClient.Credentials = New NetworkCredential(strCorreo, strClave)
        smtpClient.Port = strPuerto
        smtpClient.Host = strHost
        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network
        smtpClient.EnableSsl = True



        ServicePointManager.ServerCertificateValidationCallback = Function(s As Object, certificate As X509Certificate, chain As X509Chain, sslPolicyErrors As SslPolicyErrors) True

        Try
            If EmailMessage.To.Count > 0 Then
                smtpClient.Send(EmailMessage)
            End If
        Catch ex As Exception
            Throw
        End Try

    End Sub

    Private Sub btnProcesar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnProcesar.ItemClick
        ActualizarEdicionGrilla()

        Cursor = Cursors.WaitCursor

        Dim xVacante As Integer = 0
        Dim xAsignados As Integer = 0
        Dim xIdPostulanteMasivo As Integer = 0
        Dim idtipoidentidad As Integer = 0
        Dim idtienda As String = ""
        Dim fechaingreso As Date
        Dim fechafirmacontrato As Date
        Dim fechanacimiento As Date
        Dim idcargo As String = ""
        Dim numeroidentidad As String = ""
        Dim nombres As String = ""
        Dim apellidopaterno As String = ""
        Dim apellidomaterno As String = ""
        Dim idsexo As Integer = 0
        Dim idfuente As String = ""
        Dim idconclucion As String = ""
        Dim idubigeo As String = ""
        Dim idturno As String = ""

        For j As Integer = 0 To GridView1.RowCount - 1
            Dim ESTADOASIGNACION As Boolean
            ESTADOASIGNACION = If(GridView1.GetRowCellValue(j, "ESTADOASIGNACION").ToString = "False", 0, 1)
            If ESTADOASIGNACION Then
                xIdPostulanteMasivo = GridView1.GetRowCellValue(j, "IDPOSTULANTEMASIVO")
                idtipoidentidad = GridView1.GetRowCellValue(j, "IDTIPODOCUMENTOIDENTIDAD")
                idtienda = GridView1.GetRowCellValue(j, "IDTIENDA")
                fechaingreso = GridView1.GetRowCellValue(j, "FECHAINGRESOTIENDAPROGRAMADO").ToString
                fechafirmacontrato = GridView1.GetRowCellValue(j, "FECHAFIRMACONTRATO").ToString
                fechanacimiento = GridView1.GetRowCellValue(j, "FECHANACIMIENTO").ToString
                idcargo = GridView1.GetRowCellValue(j, "IDCARGO")
                numeroidentidad = GridView1.GetRowCellValue(j, "NUMERODOCUMENTO").ToString
                nombres = GridView1.GetRowCellValue(j, "NOMBRES").ToString
                apellidopaterno = GridView1.GetRowCellValue(j, "APELLIDOPATERNO").ToString
                apellidomaterno = GridView1.GetRowCellValue(j, "APELLIDOMATERNO").ToString
                idsexo = GridView1.GetRowCellValue(j, "IDSEXO")
                idfuente = GridView1.GetRowCellValue(j, "IDFUENTE")
                idconclucion = GridView1.GetRowCellValue(j, "IDCONCLUSION")
                idubigeo = GridView1.GetRowCellValue(j, "IDUBIGEO")
                idturno = GridView1.GetRowCellValue(j, "IDTURNO")
                xAsignados = xAsignados + 1
            End If
        Next

        If xAsignados = 1 Then

            If idtipoidentidad = 0 Or numeroidentidad = "" Then
                Cursor = Cursors.Default
                MessageBox.Show("Información incompleta, ingresar el tipo y número de identidad para procesar el requerimiento.")
                Exit Sub
            End If

            If nombres = "" Or apellidopaterno = "" Or apellidomaterno = "" Then
                Cursor = Cursors.Default
                MessageBox.Show("Información incompleta, ingresar el nombre y apellidos para procesar el requerimiento.")
                Exit Sub
            End If

            If idcargo = 0 Then
                Cursor = Cursors.Default
                MessageBox.Show("Información incompleta, ingresar el cargo para procesar el requerimiento.")
                Exit Sub
            End If

            If idcargo = BDCentralDAO.IdRequerimientoCargoMasivo Then
            Else
                MessageBox.Show("El postulante asignado no tienen el mismo cargo del Requerimiento.")
                Cursor = Cursors.Default
                Exit Sub
            End If

            If idsexo = 0 Then
                Cursor = Cursors.Default
                MessageBox.Show("Información incompleta, ingresar el sexo para procesar el requerimiento.")
                Exit Sub
            End If

            If idubigeo = 0 Then
                Cursor = Cursors.Default
                MessageBox.Show("Información incompleta, ingresar el distrito para procesar el requerimiento.")
                Exit Sub
            End If

            If idfuente = 0 Then
                Cursor = Cursors.Default
                MessageBox.Show("Información incompleta, ingresar la fuente de reclutamiento para procesar el requerimiento.")
                Exit Sub
            End If

            If idconclucion = 0 Then
                Cursor = Cursors.Default
                MessageBox.Show("Información incompleta, ingresar la conclusion para procesar el requerimiento.")
                Exit Sub
            End If

            If idtienda = 0 Then
                Cursor = Cursors.Default
                MessageBox.Show("Información incompleta, Ingresar la tienda para procesar el requerimiento.")
                Exit Sub
            End If
            If idtienda = BDCentralDAO.IdTiendaRequerimiento Then
            Else
                MessageBox.Show("El postulante asignado no tienen el mismo local del Requerimiento.")
                Cursor = Cursors.Default
                Exit Sub
            End If

            If idturno = 0 Then
                Cursor = Cursors.Default
                MessageBox.Show("Información incompleta, ingresar el turno para procesar el requerimiento.")
                Exit Sub
            End If
            'If idturno = BDCentralDAO.IdTurnoRequerimiento Then
            'Else
            '    MessageBox.Show("El postulante asignado no tienen el turno del Requerimiento.")
            '    Cursor = Cursors.Default
            '    Exit Sub
            'End If


            If fechaingreso = "1900-01-01" Or fechafirmacontrato = "1900-01-01" Then
                Cursor = Cursors.Default
                MessageBox.Show("Información incompleta, ingresar fecha de ingreso y firma de contrato para procesar el requerimiento.")
                Exit Sub
            End If

            If fechanacimiento = "1900-01-01" Then
                Cursor = Cursors.Default
                MessageBox.Show("Información incompleta, ingresar fecha de nacimiento para procesar el requerimiento.")
                Exit Sub
            End If

            'Verifica si el REQ. esta procesado por otro usuario
            If BDCentralDAO.ValidarRequerimientoProcesado(BDCentralDAO.IdRequerimiento) Then
                MessageBox.Show("El requerimiento seleccionado ya fue procesado por otro usuario, actualizar la información.")
                Cursor = Cursors.Default
                Exit Sub
            End If

            If MessageBox.Show("Desea procesar el requerimiento?", "Procesar Requerimiento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim dtrq As DataTable
                Dim xIdRequerimientoPersonal As Integer
                Dim xCierre As Integer

                dtrq = BDCentralDAO.RequerimientoPersonalValidarProcesarMasivo(BDCentralDAO.IdRequerimiento)
                xIdRequerimientoPersonal = dtrq.Rows(0)(0)
                xCierre = dtrq.Rows(0)(1)

                'ACTUALIZAR RQ EN CONTROL ATENCIONES
                If BDCentralDAO.RequerimientoPersonalUpdateVacantesAtendidas(xIdRequerimientoPersonal, 1, xCierre) Then
                    BDCentralDAO.RequerimientoPersonalUpdateEstadoProcesarMasivo(xIdPostulanteMasivo, BDCentralDAO.IdRequerimiento)
                Else
                    Cursor = Cursors.Default
                    MessageBox.Show("Problemas de conexión...", "Control de Atenciones")
                    Exit Sub
                End If

                'VALIDA SI EL EMPLEADO EXISTE PARA COLOCOCARLO CON REINGRESANTE CASO CONTRARIO COMO NUEVO EMPLEADO
                Dim dtempleado As DataTable
                Dim result As String
                dtempleado = BDCentralDAO.ConsultaExistenciEmpleado(xIdPostulanteMasivo)
                result = dtempleado.Rows(0)(0) 'SI EL RESULT ES 0 EL EMPLEADO NO EXISTE, SI ES 1 EL EMPLEADO YA EXISTE
                If result = 0 Then
                    'INSERTA MC_EMPLEADO
                    If BDCentralDAO.InsertEmpleadoPostulanteMasivo(xIdPostulanteMasivo, BDCentralDAO.IdRequerimiento) Then
                        MessageBox.Show("Postulante asignado como empleado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Error al asignar al postulante como empleado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    If BDCentralDAO.UpdateEmpleadoPostulanteReingresoMasivo(xIdPostulanteMasivo, BDCentralDAO.IdRequerimiento) Then
                        MessageBox.Show("Postulante asignado como empleado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Error al asignar al postulante como empleado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If

                Cursor = Cursors.Default
                Me.Close()
            End If
        Else
            MessageBox.Show("El Nro. de postulantes asignados es mayor al Nro. de vacantes solicitados")
            Cursor = Cursors.Default
        End If

    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        ActualizarEdicionGrilla()

        For j As Integer = 0 To GridView1.RowCount - 1
            Dim estado As Boolean
            estado = GridView1.GetRowCellValue(j, "ESTADOASIGNACION")
            If estado Then
                MessageBox.Show("Quitar la asignacón, existe personal con la opcion de asignado")
                Exit Sub
            End If
        Next

        Me.Close()
    End Sub
End Class