Imports MC.Data
Imports MC.Framework

Public Class PrestamosDepositoDetails

    Private PrestamosBE As New PrestamosBE

    Sub New()
        InitializeComponent()

        'txtFecha.Enabled = False
        'txtMontoAprobado.Enabled = False
        dtFechaDeposito.Enabled = False
        dtFechaDeposito.Text = DateTime.Now.Date

        ListarBanco()
    End Sub

    Private Sub DepositoPrestamoDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        If PrestamoDAO.IdPrestamo <> 0 Then
            PrestamosBE = PrestamoDAO.GetPrestamoByID(PrestamoDAO.IdPrestamo)
            With PrestamosBE
                txtDni.Text = PrestamosBE.DNI
                txtFecha.Text = PrestamosBE.Fecha
                txtRazonSocial.Text = PrestamosBE.RazonSocial
                txtRazonComercial.Text = PrestamosBE.RazonComercial
                txtCargo.Text = PrestamosBE.Cargo
                txtEmpleado.Text = PrestamosBE.Nombres + " " + PrestamosBE.ApellidoPaterno + " " + PrestamosBE.ApellidoMaterno
                txtMotivo.Text = PrestamosBE.MotivoPrestamo
                txtMontoAprobado.Text = PrestamosBE.MontoAprobado
                txtMontoDeposito.Text = PrestamosBE.MontoAprobado

                txtMontoDeposito.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                txtMontoAprobado.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            End With
        End If
    End Sub
    Private Sub ListarBanco()
        ControlesDevExpress.InitGridViewColumn(GridViewBanco, "ID", "IDBANCO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewBanco, "BANCO", "NOMBRE", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewBanco
            .Columns("NOMBRE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        sleBanco.Properties.DataSource = PrestamoDAO.ListarBanco
        sleBanco.Properties.DisplayMember = "NOMBRE"
        sleBanco.Properties.ValueMember = "IDBANCO"
        sleBanco.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Function validar() As Boolean
        DxErrorProvider1.ClearErrors()
        Dim Result As Boolean = True

        If sleBanco.EditValue Is Nothing Or sleBanco.Text = "" Then
            DxErrorProvider1.SetError(sleBanco, "Dato obligatorio")
            Result = False
        End If

        If txtCodigo.Text = "" Then
            DxErrorProvider1.SetError(txtCodigo, "Dato obligatorio")
            Result = False
        End If
        If Result Then
            With PrestamosBE
                .IdPrestamos = PrestamoDAO.IdPrestamo
                .CodigoDeposito = txtCodigo.Text
                .IdBanco = sleBanco.EditValue
                .FechaDeposito = dtFechaDeposito.Text
            End With
        End If
        Return Result
    End Function

    Private Sub btnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick
        If Me.validar Then
            If MessageBox.Show("¿Esta seguro de guardar el depósito?", "Guardar información", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                If PrestamoDAO.UpdatePrestamoDeposito(PrestamosBE) Then
                    Me.Close()
                Else
                    MessageBox.Show("Problema al registrar")
                End If
            End If
        End If
    End Sub

    Private Sub btnRegistrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRegistrar.ItemClick
        If Me.validar Then
            If MessageBox.Show("¿Esta seguro de registrar el depósito?", "Registrar depósito", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                'If PrestamoDAO.UpdatePrestamoDepositoEstado(PrestamosBE, BDCentralDAO.UsuarioBE.IDUsuario) Then
                'ENVIO CORREO
                Dim dtEmail As New DataTable
                    dtEmail = PrestamoDAO.GetPrestamoIDCorreo(PrestamoDAO.IdPrestamo)
                If dtEmail.Rows.Count > 0 Then

                    Dim numerosolicitud As String = dtEmail.Rows(0)("NUMEROSOLICITUD")
                    Dim correosolicitante As String = dtEmail.Rows(0)("CORREOSOLICITANTE")
                    Dim correosupervisor As String = dtEmail.Rows(0)("CORREOSUPERVISOR")

                    Dim dni As String = dtEmail.Rows(0)("NUMERODOCUMENTO")
                    Dim apellidopaterno As String = dtEmail.Rows(0)("APELLIDOPATERNO")
                    Dim apellidomaterno As String = dtEmail.Rows(0)("APELLIDOMATERNO")
                    Dim nombres As String = dtEmail.Rows(0)("NOMBRES")
                    Dim cargo As String = dtEmail.Rows(0)("CARGO")
                    Dim fechaingreso As String = dtEmail.Rows(0)("FECHAINGRESO")
                    Dim razoncomercial As String = dtEmail.Rows(0)("RAZONCOMERCIAL")
                    Dim razonsocial As String = dtEmail.Rows(0)("RAZONSOCIAL")
                    Dim montoaprobado As String = dtEmail.Rows(0)("MONTOAPROBADO")
                    Dim mediopago As String = dtEmail.Rows(0)("MEDIOPAGO")
                    Dim montodescuento As String = dtEmail.Rows(0)("MONTODESCUENTO")
                    Dim codigodeposito As String = dtEmail.Rows(0)("CODIGODEPOSITO")
                    Dim fechadeposito As String = dtEmail.Rows(0)("FECHADEPOSITO")
                    Dim banco As String = dtEmail.Rows(0)("BANCO")
                    Dim tipopago As String = dtEmail.Rows(0)("TIPOPAGO")
                    Dim idlocal As String = dtEmail.Rows(0)("IDLOCAL")
                    Dim nombresolicitante = dtEmail.Rows(0)("SOLICITANTE")

                    Dim emailTo As String = ""
                    If idlocal = 94 Or idlocal = 200 Then
                        If correosolicitante = "" Then
                            If MessageBox.Show("El solicitante " & nombresolicitante & " no cuenta con un correo asignado, por lo cual no se enviará correo ¿desea continuar?", "Advetencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                PrestamoDAO.UpdatePrestamoDepositoEstado(PrestamosBE, BDCentralDAO.UsuarioBE.IDUsuario)
                            End If
                        Else
                            emailTo = correosolicitante
                            If EnivoCorreo(emailTo, numerosolicitud, razoncomercial, banco, tipopago, dni, apellidopaterno, apellidomaterno, nombres, cargo, fechaingreso, razonsocial, montoaprobado, mediopago, montodescuento, codigodeposito, fechadeposito) Then
                                PrestamoDAO.UpdatePrestamoDepositoEstado(PrestamosBE, BDCentralDAO.UsuarioBE.IDUsuario)
                            End If
                        End If
                    Else
                        If correosolicitante = "" And correosupervisor <> "" Then ' el supervisor cuenta con correo peros el local no cuenta
                            If MessageBox.Show("El Local " & razoncomercial & " no cuenta con un correo asignado, por lo cual no se enviará correo, solo se enviará correo al supervirsor ¿desea continuar?", "Advetencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                emailTo = correosupervisor
                                If EnivoCorreo(emailTo, numerosolicitud, razoncomercial, banco, tipopago, dni, apellidopaterno, apellidomaterno, nombres, cargo, fechaingreso, razonsocial, montoaprobado, mediopago, montodescuento, codigodeposito, fechadeposito) Then
                                    If PrestamoDAO.UpdatePrestamoDepositoEstado(PrestamosBE, BDCentralDAO.UsuarioBE.IDUsuario) Then
                                        MessageBox.Show("Registro de Depósito Exitoso")
                                        Me.Close()
                                    Else
                                        MessageBox.Show("Error al registrar depósito")
                                    End If
                                End If
                            End If
                        ElseIf correosolicitante <> "" And correosupervisor = "" Then 'la tienda cuenta con correo pero el supervisor no cuenta
                            If MessageBox.Show("El supervisor del local" & razoncomercial & " no cuenta con un correo asignado, por lo cual no se enviará correo, solo se enviará correo a la tienda ¿desea continuar?", "Advetencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                emailTo = correosolicitante
                                If EnivoCorreo(emailTo, numerosolicitud, razoncomercial, banco, tipopago, dni, apellidopaterno, apellidomaterno, nombres, cargo, fechaingreso, razonsocial, montoaprobado, mediopago, montodescuento, codigodeposito, fechadeposito) Then
                                    If PrestamoDAO.UpdatePrestamoDepositoEstado(PrestamosBE, BDCentralDAO.UsuarioBE.IDUsuario) Then
                                        MessageBox.Show("Registro de Depósito Exitoso")
                                        Me.Close()
                                    Else
                                        MessageBox.Show("Error al registrar depósito")
                                    End If
                                End If
                            End If
                        ElseIf correosolicitante <> "" And correosupervisor <> "" Then 'supervisor y local cuentan con correo
                            emailTo = correosolicitante + "," + correosupervisor
                            If EnivoCorreo(emailTo, numerosolicitud, razoncomercial, banco, tipopago, dni, apellidopaterno, apellidomaterno, nombres, cargo, fechaingreso, razonsocial, montoaprobado, mediopago, montodescuento, codigodeposito, fechadeposito) Then
                                If PrestamoDAO.UpdatePrestamoDepositoEstado(PrestamosBE, BDCentralDAO.UsuarioBE.IDUsuario) Then
                                    MessageBox.Show("Registro de Depósito Exitoso")
                                    Me.Close()
                                Else
                                    MessageBox.Show("Error al registrar depósito")
                                End If
                            End If
                        Else  'No cuentan con correo tanto el supervisor como el local
                            If MessageBox.Show("El local y el supervisor de la tienda" & razoncomercial & " no cuenta con un correo asignado, por lo cual no se enviará correo ¿desea continuar?", "Advetencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                If PrestamoDAO.UpdatePrestamoDepositoEstado(PrestamosBE, BDCentralDAO.UsuarioBE.IDUsuario) Then
                                    MessageBox.Show("Registro de Depósito Exitoso")
                                    Me.Close()
                                Else
                                    MessageBox.Show("Error al registrar depósito")
                                End If
                            End If
                        End If
                    End If

                End If
            End If
        End If
    End Sub
    Private Function EnivoCorreo(emailTo, numerosolicitud, razoncomercial, banco, tipopago, dni, ApellidoPaterno, ApellidoMaterno, nombres, cargo, fechaingreso, razonsocial, montoaprobado, mediopago, montodescuento, codigodeposito, fechadeposito) As Boolean
        Dim Mensaje As String = ""
        Mensaje = "<font face=Calibri size=3> Estimado Señores de:  " & razoncomercial & "<br>" & "<br>" &
                                 "Por favor informarle al colaborador que se acerque al Banco: " & banco & "con su DNI, depósito a su nombre." & "<br>" &
                                 "Nota: Es importante hacerle de conocimiento al colaborador la información sobre el descuento de su préstamo" & "<br>" &
                                 "<table border=1 cellspacing=0 cellpadding=2>" &
                                 "<tr bgcolor='#E59866' align='center'> " &
                                 "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>DNI</td>" &
                                 "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>APELLIDO PATERNO</td>" &
                                 "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>APELLIDO MATERNO</td>" &
                                 "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>NOMBRES</td>" &
                                 "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>PUESTO</td>" &
                                 "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>FECHA DE INGRESO</td>" &
                                 "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>TIENDA</td>" &
                                 "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>RAZON SOCIAL</td>" &
                                 "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>MONTO APROBADO</td>" &
                                 "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>MEDIO DE PAGO</td>" &
                                 "<td style=text-align:center;font-weight:bold;font-family:Calibri;font-size:15px>" & tipopago & "</td>" &
                                 "</tr>" &
                                 "<tr>" &
                                 "<td style=font-family:Calibri;font-size:15px>" & dni & "</td>" &
                                 "<td style=font-family:Calibri;font-size:15px>" & ApellidoPaterno & "</td>" &
                                 "<td style=font-family:Calibri;font-size:15px>" & ApellidoMaterno & "</td>" &
                                 "<td style=font-family:Calibri;font-size:15px>" & nombres & "</td>" &
                                 "<td style=font-family:Calibri;font-size:15px>" & cargo & "</td>" &
                                 "<td style=font-family:Calibri;font-size:15px>" & fechaingreso & "</td>" &
                                 "<td style=font-family:Calibri;font-size:15px>" & razoncomercial & "</td>" &
                                 "<td style=font-family:Calibri;font-size:15px>" & razonsocial & "</td>" &
                                 "<td style=font-family:Calibri;font-size:15px>" & "S/. " & montoaprobado & "</td>" &
                                 "<td style=font-family:Calibri;font-size:15px>" & mediopago & "</td>" &
                                 "<td style=font-family:Calibri;font-size:15px>" & "S/. " & montodescuento & "</td>" &
                                 "</table>" &
                                 "<br>" &
                                 "Orden telebanking procesada - " & razonsocial & "<br>" &
                                 "Pagos Varios - S/. - Orden Nro. " & codigodeposito & " del " & fechadeposito & "<br>" & "<br>" &
                                 "<font face=Calibri size=3> <b> AREA DE RRHH </b> </font>" & "<br>"

        Return (BDCentralDAO.InsertEnvioCorreo(emailTo, " Prestamo: " + numerosolicitud, Mensaje))
    End Function

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

End Class