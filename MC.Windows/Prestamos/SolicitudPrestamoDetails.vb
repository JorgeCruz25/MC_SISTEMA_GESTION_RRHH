Imports MC.Data
Imports MC.Framework
Public Class SolicitudPrestamoDetails
    Private PrestamosBE As New PrestamosBE
    Private UsuarioBE As New UsuarioBE

    Sub New()

        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ID", "IDPRESTAMO", 10, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO SOLICITUD", "NUMEROSOLICITUD", 30, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 45, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA", "FECHA", 20, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MON. SOLICITADO", "MONTO", 25, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MON. APROBADO", "MONTOAPROBADO", 25, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MEDIO PAGO", "MEDIOPAGO", 25, True, ControlesDevExpress.eGridViewFormato.Checked, True)


        ControlesDevExpress.InitGridViewColumn(GridView2, "ID", "IDMEMORANDUM", 10, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "NUMEROINFORME", "NUMEROINFORME", 20, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "RAZON SOCIAL", "RAZONSOCIAL", 30, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "FECHA", "FECHA", 20, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "NIVEL FALTA", "NIVELFALTA", 20, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "FALTA", "FALTA", 20, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "DECRIPCIÓN MEMORANDUM", "MEMORANDUMDESCRIPCION", 20, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)



        ControlesDevExpress.InitGridViewColumn(GridView3, "ID", "IDLICENCIA", 10, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView3, "NUMERO SOLICITUD", "NUMEROSOLICITUD", 25, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView3, "TIPO LICENCIA", "LICENCIATIPO", 45, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView3, "RAZON SOCIAL", "RAZONSOCIAL", 40, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView3, "FECHA", "FECHA", 20, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        GridView1.Columns("MONTO").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        GridView1.Columns("MONTOAPROBADO").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        ListarMotivo()
        ListarTipoPago()
        ListarMedioPago()
    End Sub

    Private Sub SolicitudPrestamoDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        If PrestamoDAO.IdPrestamo <> 0 Then

            PrestamosBE = PrestamoDAO.GetPrestamoByID(PrestamoDAO.IdPrestamo)
            With PrestamosBE
                txtSolicitante.Text = PrestamosBE.Solicitante
                txtDni.Text = PrestamosBE.DNI
                txtFecha.Text = PrestamosBE.Fecha
                txtRazonSocial.Text = PrestamosBE.RazonSocial
                txtRazonComercial.Text = PrestamosBE.RazonComercial
                txtCargo.Text = PrestamosBE.Cargo
                txtEmpleado.Text = PrestamosBE.Nombres + " " + PrestamosBE.ApellidoPaterno + " " + PrestamosBE.ApellidoMaterno
                txtMontoSolicitado.Text = PrestamosBE.Monto
                'txtMotivo.Text = PrestamosBE.MotivoPrestamo

                sleTipoPago.Text = PrestamosBE.IdTipoPago
                sleMedioPago.Text = PrestamosBE.IdMedioPago
                sleMotivo.Text = PrestamosBE.IdMotivoPrestamo
                txtDescuentoGratificacion.Text = PrestamosBE.PorcentajeGratificacionDescuento
                txtMontoDescuento.Text = PrestamosBE.MontoDescuento
                txtMontoAprobado.Text = PrestamosBE.MontoAprobado

                txtFechaIngresoCorporativo.Text = PrestamosBE.FechaIngresoCorporativo
                txtFechaIngresoLocal.Text = PrestamosBE.FechaIngresoLocal

                txtMontoSolicitado.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                txtDescuentoGratificacion.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                txtMontoDescuento.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                txtMontoAprobado.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                txtDescripcionSolicitud.Text = PrestamosBE.DescripcionPrestamoSolicitud
                txtDescripcionRrhh.Text = PrestamosBE.DescripcionPrestamoRrhh
                txtMontoLiquidacion.Text = PrestamosBE.MontoLiquidacionDescuento
                txtMontoVacaciones.Text = PrestamosBE.MontoVacacionesDescuento
            End With

            If PrestamosBE.EstadoValidadoRrhh Then
                sleTipoPago.Enabled = False
                sleMedioPago.Enabled = False
                txtDescuentoGratificacion.Enabled = False
                txtMontoDescuento.Enabled = False
                txtMontoAprobado.Enabled = False
            End If

            txtEmpleado.Enabled = False
            txtRazonComercial.Enabled = False
            txtRazonSocial.Enabled = False
            txtSolicitante.Enabled = False
            txtDni.Enabled = False
            txtCargo.Enabled = False
            txtFecha.Enabled = False
            txtMontoSolicitado.Enabled = False

            HistorialMemorandum(PrestamosBE.IdEmpleado)
            HistorialPrestamos(PrestamosBE.IdEmpleado)
            HistorialLicencias(PrestamosBE.IdEmpleado)
        End If
    End Sub
    Private Sub ListarMotivo()
        ControlesDevExpress.InitGridViewColumn(GridViewMotivo, "ID", "IDMOTIVO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewMotivo, "MOTIVO", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewMotivo
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        sleMotivo.Properties.DataSource = PrestamoDAO.ListarMotivo
        sleMotivo.Properties.DisplayMember = "DESCRIPCION"
        sleMotivo.Properties.ValueMember = "IDMOTIVOPRESTAMO"
        sleMotivo.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub ListarTipoPago()
        ControlesDevExpress.InitGridViewColumn(GridViewTipoPago, "ID", "IDTIPOPAGO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewTipoPago, "TIPOPAGO", "TIPOPAGO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewTipoPago
            .Columns("TIPOPAGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        sleTipoPago.Properties.DataSource = PrestamoDAO.ListTipoPago
        sleTipoPago.Properties.DisplayMember = "TIPOPAGO"
        sleTipoPago.Properties.ValueMember = "IDTIPOPAGO"
        sleTipoPago.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub ListarMedioPago()
        ControlesDevExpress.InitGridViewColumn(GridViewMedioPago, "ID", "IDMEDIOPAGO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewMedioPago, "MEDIOPAGO", "MEDIOPAGO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewMedioPago
            .Columns("MEDIOPAGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        sleMedioPago.Properties.DataSource = PrestamoDAO.ListMedioPago
        sleMedioPago.Properties.DisplayMember = "MEDIOPAGO"
        sleMedioPago.Properties.ValueMember = "IDMEDIOPAGO"
        sleMedioPago.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub HistorialMemorandum(ByVal IDEMPLEADO As Int32)
        GridControl2.DataSource = PrestamoDAO.GetHistorialMemorandumByID(IDEMPLEADO)
    End Sub

    Private Sub HistorialPrestamos(ByVal IDEMPLEADO As Int32)
        GridControl1.DataSource = PrestamoDAO.GetHistorialPrestamosByID(IDEMPLEADO)
    End Sub

    Private Sub HistorialLicencias(ByVal IDEMPLEADO As Int32)
        GridControl3.DataSource = PrestamoDAO.GetHistorialLicenciasByID(IDEMPLEADO)
    End Sub

    Private Function Validar() As Boolean

        DxErrorProvider1.ClearErrors()
        Dim Result As Boolean = True

        If sleTipoPago.EditValue Is Nothing Or sleTipoPago.EditValue = 0 Then
            DxErrorProvider1.SetError(sleTipoPago, "Dato obligatorio")
            Result = False
        End If
        If sleMedioPago.EditValue Is Nothing Or sleMedioPago.EditValue = 0 Then
            DxErrorProvider1.SetError(sleMedioPago, "Dato obligatorio")
            Result = False
        End If
        If txtMontoAprobado.Text = "" Or txtMontoAprobado.Text = "0" Then
            DxErrorProvider1.SetError(txtMontoAprobado, "Dato obligatorio")
        End If
        If txtMontoDescuento.Text = "" Or txtMontoDescuento.Text = "0" Then
            DxErrorProvider1.SetError(txtMontoDescuento, "Dato obligatorio")
            Result = False
        End If
        If txtDescuentoGratificacion.Text > 100 Or txtDescuentoGratificacion.Text < 0 Or txtMontoDescuento.Text = "" Or txtMontoDescuento.Text = "0" Then
            DxErrorProvider1.SetError(txtDescuentoGratificacion, "El dato debe estar entre 0.00% - 100.00%")
            Result = False
        End If

        If Convert.ToDouble(txtMontoAprobado.Text) = 0 Then
            DxErrorProvider1.SetError(txtMontoAprobado, "Dato obligatorio")
            Result = False
        End If
        If Convert.ToDouble(txtMontoDescuento.Text) = 0 Then
            DxErrorProvider1.SetError(txtMontoDescuento, "Dato obligatorio")
            Result = False
        End If

        With PrestamosBE
            .IdPrestamos = PrestamoDAO.IdPrestamo
            .IdTipoPago = sleTipoPago.EditValue
            .IdMedioPago = sleMedioPago.EditValue
            .IdMotivoPrestamo = sleMotivo.EditValue
            .PorcentajeGratificacionDescuento = Convert.ToDouble(txtDescuentoGratificacion.Text)
            .MontoDescuento = Convert.ToDouble(txtMontoDescuento.Text)
            .MontoAprobado = Convert.ToDouble(txtMontoAprobado.Text)
            .MontoVacacionesDescuento = Convert.ToDouble(txtMontoVacaciones.Text)
            .MontoLiquidacionDescuento = Convert.ToDouble(txtMontoLiquidacion.Text)
            .DescripcionPrestamoRrhh = txtDescripcionRrhh.Text
        End With

        Return Result

    End Function

    Private Sub btnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick
        If Me.Validar Then
            If MessageBox.Show("¿Esta seguro de guardar evaluación?", "Guardar evaluación de préstamo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                If PrestamoDAO.UpdatePrestamoEvaluacionRRHH(PrestamosBE) Then
                    Me.Close()
                Else
                    MessageBox.Show("Error al guardar")
                End If
            End If
        End If
    End Sub

    Private Sub btnRevisar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRevisar.ItemClick
        If Me.Validar Then
            If MessageBox.Show("¿Esta seguro de revisar el préstamo?", "Revisar préstamo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                If PrestamoDAO.UpdatePrestamoRevisionRRHH(PrestamosBE, BDCentralDAO.UsuarioBE.IDUsuario) Then
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub btnValidar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnValidar.ItemClick
        If Me.Validar Then
            If MessageBox.Show("¿Esta seguro de validar el préstamo?", "Validar préstamo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                If PrestamoDAO.UpdatePrestamoValidacionRRHH(PrestamosBE, BDCentralDAO.UsuarioBE.IDUsuario) Then
                    'ENVIO CORREO
                    Dim dtEmail As New DataTable
                    dtEmail = PrestamoDAO.GetPrestamoIDCorreo(PrestamoDAO.IdPrestamo)

                    If dtEmail.Rows.Count > 0 Then
                        Dim numerosolicitud As String = dtEmail.Rows(0)("NUMEROSOLICITUD")
                        Dim correosolicitante As String = dtEmail.Rows(0)("CORREOSOLICITANTE")
                        Dim correosupervisor As String = dtEmail.Rows(0)("CORREOSUPERVISOR")

                        Dim razoncomercial As String = dtEmail.Rows(0)("RAZONCOMERCIAL")
                        Dim apellidopaterno As String = dtEmail.Rows(0)("APELLIDOPATERNO")
                        Dim apellidomaterno As String = dtEmail.Rows(0)("APELLIDOMATERNO")
                        Dim nombres As String = dtEmail.Rows(0)("NOMBRES")
                        Dim empleado As String = apellidopaterno + " " + apellidomaterno + " " + nombres
                        Dim empleadodni As String = dtEmail.Rows(0)("NUMERODOCUMENTO")

                        Dim emailTo As String
                        emailTo = correosolicitante + correosupervisor

                        Dim Mensaje As String
                        Mensaje = "<font face=Calibri size=3> Estimado Señores de:  " & razoncomercial & "<br>" & "<br>" &
                    "Se comunica que se elaboró el documento en referencia para el Señor(a)  " & empleado &
                " con DNI:  " & empleadodni & ". Por favor cumplir con los siguientes pasos: <br><br>" &
                "1. Ingresar a la Plataforma de Control de Atenciones mediante el siguiente link: http://controlatenciones.azurewebsites.net/Account/Login.aspx?ReturnUrl=%2f <br>" &
                "2. Ingresar al documento en referencia. <br>" &
                "3. Imprimir el documento. <br>" &
                "4. Hacer firmar el documento y registro de la huella dactilar. <br>" &
                "5. Escanear el documento. <br>" &
                "6. Adjuntar el documento en la Plataforma de Control de Atenciones. <br>" &
                "7. Enviar el documento en físico al área de Recursos Humanos. <br>" & "<br>" & "AREA DE RRHH" & "<br>"

                        BDCentralDAO.InsertEnvioCorreo(emailTo, " Prestamo: " + numerosolicitud, Mensaje)
                    End If
                    Me.Close()

                Else
                    MessageBox.Show("Error al validar")
                End If
            End If
        End If
    End Sub

    Private Sub btnAprobar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAprobar.ItemClick
        Dim dt As New DataTable
        dt = PrestamoDAO.GetPrestamosCompromisoArchivo(PrestamoDAO.IdPrestamo)
        If dt.Rows.Count <> 0 Then
            If MessageBox.Show("¿Esta seguro de aprobar el préstamo?", "Anular préstamo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                If PrestamoDAO.UpdatePrestamoAprobacionRRHH(PrestamosBE, BDCentralDAO.UsuarioBE.IDUsuario) Then
                    Me.Close()
                Else
                    MessageBox.Show("Error al aprobar")
                End If
            End If
        Else
            MessageBox.Show("Falta adjuntar el acta de compromiso", "Aprobar Prestamo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnAnular_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnular.ItemClick
        If MessageBox.Show("¿Esta seguro de anular el préstamo?", "Anular préstamo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            If PrestamoDAO.UpdatePrestamoAnulacionRRHH(PrestamosBE, BDCentralDAO.UsuarioBE.IDUsuario) Then
                Me.Close()
            Else
                MessageBox.Show("Error al anular")
            End If
        End If
    End Sub

    Private Sub txtMontoAprobado_Click(sender As Object, e As EventArgs) Handles txtMontoAprobado.Click
        txtMontoAprobado.SelectAll()
    End Sub

    Private Sub txtMontoDescuento_Click(sender As Object, e As EventArgs) Handles txtMontoDescuento.Click
        txtMontoDescuento.SelectAll()
    End Sub

    Private Sub txtDescuentoGratificacion_Click(sender As Object, e As EventArgs) Handles txtDescuentoGratificacion.Click
        txtDescuentoGratificacion.SelectAll()
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnHistorialEmpleado_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnHistorialEmpleado.ItemClick
        BDAccionPersonalDAO.IdEmpleado = PrestamosBE.IdEmpleado
        If BDAccionPersonalDAO.IdEmpleado <> 0 Then
            Dim MiForm As New EmpleadoHistorial
            Nombre = txtEmpleado.Text
            NumeroDocumento = txtDni.Text
            NombreLog = Me.Text ' formulario , reporte,
            DetalleLog = "HISTORIAL EMPLEADO " & Nombre & " CON NUMERO DE DOC. " & NumeroDocumento ' acción: impresión, exportar, tb poner filtros , lo que se
            BDCentralDAO.AccesoLogIns(IDSistema, BDCentralDAO.UsuarioBE.IDUsuario, DetalleLog, NombreLog)
            MiForm.ShowDialog()
        End If
    End Sub
End Class