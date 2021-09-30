Imports MC.Framework
Imports MC.Data
Imports DevExpress.XtraTab
Public Class OpcionesModificar
    Dim generarcontrato As Int32 = 0
    Dim desprocesarcontrato As Int32 = 0
    Dim fechacese As Int32 = 0
    Dim fechafincontrato As Int32 = 0
    Dim tipocontraro As Int32 = 0
    Dim razonsocial As Int32 = 0
    Dim ingresocorporativo As Int32 = 0
    Dim ingresocompania As Int32 = 0
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        XtraTabControl1.TabPages(0).PageVisible = False
        XtraTabControl1.TabPages(1).PageVisible = False
        XtraTabControl1.TabPages(2).PageVisible = False
        XtraTabControl1.TabPages(3).PageVisible = False
        XtraTabControl1.TabPages(4).PageVisible = False
        XtraTabControl1.TabPages(5).PageVisible = False
        XtraTabControl1.TabPages(6).PageVisible = False
        XtraTabControl1.TabPages(7).PageVisible = False
        txtCodigoUnicoRenovacionContrato.Enabled = False
        txtIdEmpleadoRenovacionContrato.Enabled = False

    End Sub

    Private Sub btnDesprocesarContrato_Click(sender As Object, e As EventArgs) Handles btnDesprocesarContrato.Click
        generarcontrato = 0
        desprocesarcontrato = 1
        fechacese = 0
        fechafincontrato = 0
        tipocontraro = 0
        razonsocial = 0
        ingresocorporativo = 0
        ingresocompania = 0
        XtraTabControl1.TabPages(0).PageVisible = True
        XtraTabControl1.TabPages(1).PageVisible = False
        XtraTabControl1.TabPages(2).PageVisible = False
        XtraTabControl1.TabPages(3).PageVisible = False
        XtraTabControl1.TabPages(4).PageVisible = False
        XtraTabControl1.TabPages(5).PageVisible = False
        XtraTabControl1.TabPages(6).PageVisible = False
        XtraTabControl1.TabPages(7).PageVisible = False

    End Sub

    Private Sub btnGenerarContrato_Click(sender As Object, e As EventArgs) Handles btnGenerarContrato.Click
        generarcontrato = 1
        desprocesarcontrato = 0
        fechacese = 0
        fechafincontrato = 0
        tipocontraro = 0
        razonsocial = 0
        ingresocorporativo = 0
        ingresocompania = 0
        XtraTabControl1.TabPages(0).PageVisible = False
        XtraTabControl1.TabPages(1).PageVisible = False
        XtraTabControl1.TabPages(2).PageVisible = False
        XtraTabControl1.TabPages(3).PageVisible = False
        XtraTabControl1.TabPages(4).PageVisible = False
        XtraTabControl1.TabPages(5).PageVisible = False
        XtraTabControl1.TabPages(6).PageVisible = False
        XtraTabControl1.TabPages(7).PageVisible = True
    End Sub

    Private Sub btnCambioFechaCese_Click(sender As Object, e As EventArgs) Handles btnCambioFechaCese.Click
        generarcontrato = 0
        desprocesarcontrato = 0
        fechacese = 1
        fechafincontrato = 0
        tipocontraro = 0
        razonsocial = 0
        ingresocorporativo = 0
        ingresocompania = 0
        XtraTabControl1.TabPages(0).PageVisible = False
        XtraTabControl1.TabPages(1).PageVisible = True
        XtraTabControl1.TabPages(2).PageVisible = False
        XtraTabControl1.TabPages(3).PageVisible = False
        XtraTabControl1.TabPages(4).PageVisible = False
        XtraTabControl1.TabPages(5).PageVisible = False
        XtraTabControl1.TabPages(6).PageVisible = False
        XtraTabControl1.TabPages(7).PageVisible = False
    End Sub

    Private Sub btnFechaFinalContrato_Click(sender As Object, e As EventArgs) Handles btnFechaFinalContrato.Click
        generarcontrato = 0
        desprocesarcontrato = 0
        fechacese = 0
        fechafincontrato = 1
        tipocontraro = 0
        razonsocial = 0
        ingresocorporativo = 0
        ingresocompania = 0
        XtraTabControl1.TabPages(0).PageVisible = False
        XtraTabControl1.TabPages(1).PageVisible = False
        XtraTabControl1.TabPages(2).PageVisible = True
        XtraTabControl1.TabPages(3).PageVisible = False
        XtraTabControl1.TabPages(4).PageVisible = False
        XtraTabControl1.TabPages(5).PageVisible = False
        XtraTabControl1.TabPages(6).PageVisible = False
        XtraTabControl1.TabPages(7).PageVisible = False
    End Sub

    Private Sub BtnCambioTipoContrato_Click(sender As Object, e As EventArgs) Handles BtnCambioTipoContrato.Click
        generarcontrato = 0
        desprocesarcontrato = 0
        fechacese = 0
        fechafincontrato = 0
        tipocontraro = 1
        razonsocial = 0
        ingresocorporativo = 0
        ingresocompania = 0
        XtraTabControl1.TabPages(0).PageVisible = False
        XtraTabControl1.TabPages(1).PageVisible = False
        XtraTabControl1.TabPages(2).PageVisible = False
        XtraTabControl1.TabPages(3).PageVisible = True
        XtraTabControl1.TabPages(4).PageVisible = False
        XtraTabControl1.TabPages(5).PageVisible = False
        XtraTabControl1.TabPages(6).PageVisible = False
        XtraTabControl1.TabPages(7).PageVisible = False
    End Sub

    Private Sub btnCambioRazonSocial_Click(sender As Object, e As EventArgs) Handles btnCambioRazonSocial.Click
        generarcontrato = 0
        desprocesarcontrato = 0
        fechacese = 0
        fechafincontrato = 0
        tipocontraro = 0
        razonsocial = 1
        ingresocorporativo = 0
        ingresocompania = 0

        XtraTabControl1.TabPages(0).PageVisible = False
        XtraTabControl1.TabPages(1).PageVisible = False
        XtraTabControl1.TabPages(2).PageVisible = False
        XtraTabControl1.TabPages(3).PageVisible = False
        XtraTabControl1.TabPages(4).PageVisible = True
        XtraTabControl1.TabPages(5).PageVisible = False
        XtraTabControl1.TabPages(6).PageVisible = False
        XtraTabControl1.TabPages(7).PageVisible = False
    End Sub

    Private Sub btnFechaIngresoCorporativo_Click(sender As Object, e As EventArgs) Handles btnFechaIngresoCorporativo.Click
        generarcontrato = 0
        desprocesarcontrato = 0
        fechacese = 0
        fechafincontrato = 0
        tipocontraro = 0
        razonsocial = 0
        ingresocorporativo = 1
        ingresocompania = 0
        XtraTabControl1.TabPages(0).PageVisible = False
        XtraTabControl1.TabPages(1).PageVisible = False
        XtraTabControl1.TabPages(2).PageVisible = False
        XtraTabControl1.TabPages(3).PageVisible = False
        XtraTabControl1.TabPages(4).PageVisible = False
        XtraTabControl1.TabPages(5).PageVisible = True
        XtraTabControl1.TabPages(6).PageVisible = False
        XtraTabControl1.TabPages(7).PageVisible = False
    End Sub

    Private Sub btnFechaIngresoCompania_Click(sender As Object, e As EventArgs) Handles btnFechaIngresoCompania.Click
        generarcontrato = 0
        desprocesarcontrato = 0
        fechacese = 0
        fechafincontrato = 0
        tipocontraro = 0
        razonsocial = 0
        ingresocorporativo = 0
        ingresocompania = 1
        XtraTabControl1.TabPages(0).PageVisible = False
        XtraTabControl1.TabPages(1).PageVisible = False
        XtraTabControl1.TabPages(2).PageVisible = False
        XtraTabControl1.TabPages(3).PageVisible = False
        XtraTabControl1.TabPages(4).PageVisible = False
        XtraTabControl1.TabPages(5).PageVisible = False
        XtraTabControl1.TabPages(6).PageVisible = True
        XtraTabControl1.TabPages(7).PageVisible = False
    End Sub
    Private Sub ListarSolicitudesCese()
        Dim idempleado As Integer
        idempleado = txtIdEmpleadoFechaCese.Text
        If rboCese.Checked = False And rboRenuncia.Checked Then
            ControlesDevExpress.InitGridViewColumn(GridViewCese, "ID", "IDRENUNCIA", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
            ControlesDevExpress.InitGridViewColumn(GridViewCese, "N° SOLICITUD", "NUMEROCARTA", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
            ControlesDevExpress.InitGridViewColumn(GridViewCese, "FECHA CESE", "FECHAULTIMODIATRABAJO", 180, True, ControlesDevExpress.eGridViewFormato.Fecha, False)

            With GridViewCese
                .Columns("NUMEROCARTA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
                .Columns("FECHAULTIMODIATRABAJO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            End With
            sleNumeroSolicitudCese.Properties.DataSource = RenunciaDAO.SolicitudRenunciasLitIdEmpleado(idempleado)
            sleNumeroSolicitudCese.Properties.DisplayMember = "NUMEROCARTA"
            sleNumeroSolicitudCese.Properties.ValueMember = "IDRENUNCIA"
            sleNumeroSolicitudCese.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Else

            ControlesDevExpress.InitGridViewColumn(GridViewCese, "ID", "IDSOLICITUDCESE", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
            ControlesDevExpress.InitGridViewColumn(GridViewCese, "N° SOLICITUD", "NUMEROSOLICITUDCESE", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
            ControlesDevExpress.InitGridViewColumn(GridViewCese, "FECHA CESE", "FECHACESE", 180, True, ControlesDevExpress.eGridViewFormato.Fecha, False)

            With GridViewCese
                .Columns("NUMEROSOLICITUDCESE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
                .Columns("FECHACESE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            End With
            sleNumeroSolicitudCese.Properties.DataSource = CeseDAO.SolicitudesCesesIdEmpleado(idempleado)
            sleNumeroSolicitudCese.Properties.DisplayMember = "NUMEROSOLICITUDCESE"
            sleNumeroSolicitudCese.Properties.ValueMember = "IDSOLICITUDCESE"
            sleNumeroSolicitudCese.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        End If
    End Sub
    Private Sub btnProcesar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnProcesar.ItemClick
        If generarcontrato = 1 Then
            Dim xUltimoNumeroContrato As String
            xUltimoNumeroContrato = RenovacionContratoDAO.GetObtenerUltimoContrato()
            If xUltimoNumeroContrato = "" Then
                MessageBox.Show("Problemas de Conexión con el sistema Adryan", "Error de Conexión")
                Cursor = Cursors.Default
                Exit Sub
            End If

            If txtIdEmpleadoRenovacionContrato.Text = "" Or txtCodigoUnicoRenovacionContrato.Text = "" Then
                MessageBox.Show("Empleado aun no registrado", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If Convert.ToDateTime(deNuevaFechaRenovacionContrato.EditValue) > Convert.ToDateTime(deFechaFinContratoRenovacion.EditValue) Then
                If MessageBox.Show("Esta seguro de generar renovaciones de contrato", "Renovar Contratos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    'CREA RENOVACION EN ADRYAN
                    If RenovacionContratoDAO.InsertaEmpleadoContratoAdryan(txtCodigoUnicoRenovacionContrato.Text, xUltimoNumeroContrato, deFechaFinContratoRenovacion.EditValue, deNuevaFechaRenovacionContrato.EditValue) Then
                        'CREA RENOVACION MC_CENTRAL
                        If RenovacionContratoDAO.InsertaEmpleadoContratoCentral(txtIdEmpleadoRenovacionContrato.Text, 0, xUltimoNumeroContrato, deNuevaFechaRenovacionContrato.EditValue, BDCentralDAO.UsuarioBE.IDUsuarioRegistro) Then
                            MessageBox.Show("Renovacion de contrato exitoso", "Renovación contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Problemas de conxión con central", "Renovación contrato", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Problemas de Conexión con el sistema Adryan", "Error de Conexión")
                        Cursor = Cursors.Default
                        Exit Sub
                    End If
                End If
            Else
                MessageBox.Show("La fecha de renovación del empleado  no puede ser menor a la fecha fin de contrato")
                Exit Sub
            End If
        End If

        'If fechacese = 1 Then
        '    Dim numerosolicitud As String = ""
        '    numerosolicitud = sleNumeroSolicitudCese.Text
        '    If MessageBox.Show("Esta seguro de cambiar la fecha de cese n° " & numerosolicitud, "Renovar Contratos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

        '    End If
        'End If

    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub rboCese_Click(sender As Object, e As EventArgs) Handles rboCese.Click
        GridViewCese.Columns.Clear()
        rboCese.Checked = True
        rboRenuncia.Checked = False
        ListarSolicitudesCese()
    End Sub

    Private Sub rboRenuncia_Click(sender As Object, e As EventArgs) Handles rboRenuncia.Click
        GridViewCese.Columns.Clear()
        rboCese.Checked = False
        rboRenuncia.Checked = True
        ListarSolicitudesCese()
    End Sub
End Class