Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework

Public Class SolicitudPrestamoListHistorial

    Dim bsPrestamos As New BindingSource

    Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ID", "IDPRESTAMO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NÚMERO SOLICITUD", "NUMEROSOLICITUD", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA REGISTRO", "FECHA", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MATRICULA", "MATRICULA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DOCUMENTO", "NUMERODOCUMENTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EMPLEADO", "NOMBRES", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        ControlesDevExpress.InitGridViewColumn(GridView1, "PUESTO EMPLEADO", "CARGOEMPLEADO", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MOTIVO", "MOTIVO", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO PAGO", "TIPOPAGO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MEDIO DE PAGO", "MEDIOPAGO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MONTO APROBADO", "MONTOAPROBADO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MONTO DESCUENTO", "MONTODESCUENTO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "% DES. GRATIFICACIÓN", "PORCENTAJEGRATIFICACIONDESCUENTO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DES. VACACIONES", "MONTOVACACIONESDESCUENTO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DES. LIQUIDACIÓN", "MONTOLIQUIDACIONDESCUENTO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "BANCO DEPÓSITO", "BANCO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CÓDIGO DEPÓSITO", "CODIGODEPOSITO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "REGISTRO ADRYAN", "ESTADOREGISTROADRYAN", 100, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO DEPÓSITO", "ESTADODEPOSITO", 120, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO ANULADO", "ESTADOANULADORRHH", 100, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "REGISTRO ADRYAN", "DESCRIPCIONESTADOREGISTROADRYAN", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO DEPÓSITO", "DESCRIPCIONESTADODEPOSITO", 120, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO ANULADO", "DESCRIPCIONESTADOANULADORRHH", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "USUARIO ANULADO", "NOMBREUSUARIO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        GridView1.Columns("MONTOAPROBADO").AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far

        btnFechaInicial.EditValue = DateTime.Now.Date.AddDays(-30)
        btnFechaFinal.EditValue = DateTime.Now.Date
        AddHandler btnFechaFinal.EditValueChanged, AddressOf RefrescarxSolicitud

        Me.GridControl1.DataSource = bsPrestamos
        RefrescarxSolicitud()
        chkFechaSolicitud.Checked = True
        chkFechaRegistro.Checked = False
    End Sub

    Public Sub RefrescarxSolicitud()
        Try
            btnExportar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            btnRevertirAdryan.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            btnEnvioCorreo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            GridView1.Columns.Item("SUSTENTO").Visible = False
            GridView1.Columns.Item("ACTACOMPROMISO").Visible = False
            Dim dtAccionesbutton As DataTable
            dtAccionesbutton = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioRibbon(Ribbon, dtAccionesbutton)
            Dim dtAccionesUsuario As DataTable
            dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
            Tools.AccionesUsuarioGrid(GridView1, dtAccionesUsuario)
            bsPrestamos.DataSource = PrestamoDAO.GetPrestamosListHistorial(btnFechaInicial.EditValue, btnFechaFinal.EditValue, 1)
            If GridView1.Columns.Item("SUSTENTO").Visible Then
                GridView1.Columns.Item("SUSTENTO").VisibleIndex = 0
            End If

            If GridView1.Columns.Item("ACTACOMPROMISO").Visible Then
                GridView1.Columns.Item("SUSTENTO").VisibleIndex = 1
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub RefrescarxRegistro()
        Try
            bsPrestamos.DataSource = PrestamoDAO.GetPrestamosListHistorial(btnFechaInicial.EditValue, btnFechaFinal.EditValue, 2)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        If chkFechaSolicitud.Checked = True Then
            RefrescarxSolicitud()
        ElseIf chkFechaRegistro.Checked = True Then
            RefrescarxRegistro()
        Else
            MessageBox.Show("Para poder listar los registros tiene que seleccionar si es por fecha de solicitud o fecha de registro")
        End If
    End Sub

    Private Sub btnRevertirAdryan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRevertirAdryan.ItemClick
        PrestamoDAO.IdPrestamo = GridView1.GetFocusedRowCellValue("IDPRESTAMO")
        If PrestamoDAO.IdPrestamo <> 0 And GridView1.GetFocusedRowCellValue("ESTADOANULADORRHH") = False Then
            PrestamoDAO.UpdatePrestamoRemoverEstadoAdryan(PrestamoDAO.IdPrestamo)
        End If
        If chkFechaSolicitud.Checked = True Then
            RefrescarxSolicitud()
        ElseIf chkFechaRegistro.Checked = True Then
            RefrescarxRegistro()
        Else
            MessageBox.Show("Para poder listar los registros tiene que seleccionar si es por fecha de solicitud o fecha de registro")
        End If
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub SolicitudPrestamoListHistorial_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub btnEnvioCorreo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEnvioCorreo.ItemClick
        PrestamoDAO.IdPrestamo = GridView1.GetFocusedRowCellValue("IDPRESTAMO")
        'If Me.validar Then
        If GridView1.GetFocusedRowCellValue("ESTADOANULADORRHH") = False Then
            If MessageBox.Show("¿Esta seguro de enviar correo?", "Envio de correo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                Dim dtEmail As New DataTable
                dtEmail = PrestamoDAO.GetPrestamoIDCorreo(PrestamoDAO.IdPrestamo)

                If dtEmail.Rows(0)("ESTADOANULADORRHH") = 0 Then
                    Dim numerosolicitud As String = dtEmail.Rows(0)("NUMEROSOLICITUD")
                    Dim correosolicitante As String = dtEmail.Rows(0)("CORREOSOLICITANTE")
                    Dim correosupervisor As String = dtEmail.Rows(0)("CORREOSUPERVISOR")

                    Dim dni As String = dtEmail.Rows(0)("DNI")
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

                    Dim emailTo As String
                    emailTo = correosolicitante + correosupervisor

                    Dim Mensaje As String
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
                              "<td style=font-family:Calibri;font-size:15px>" & apellidopaterno & "</td>" &
                              "<td style=font-family:Calibri;font-size:15px>" & apellidomaterno & "</td>" &
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

                    BDCentralDAO.InsertEnvioCorreo(emailTo, " Prestamo: " + numerosolicitud, Mensaje)

                    MessageBox.Show("Envio de correo exitoso")
                Else
                    MessageBox.Show("El préstamo se encuentra anulado, no se enviará correo", "Envío Correo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
                End If


            End If
        Else
            MessageBox.Show("El documento se encuentra anulado, no se podra enviar correo")
        End If
    End Sub

    Private Sub RepositoryItemButtonEditArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEditArchivo.Click
        PrestamoDAO.IdPrestamo = GridView1.GetFocusedRowCellValue("IDPRESTAMO")
        If PrestamoDAO.IdPrestamo <> 0 Then
            Dim MiForm As New SolicitudPrestamoArchivos
            Dim dt As DataTable = PrestamoDAO.GetPrestamosArchivo(PrestamoDAO.IdPrestamo)
            If dt.Rows.Count <> 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim ruta As String = dt.Rows(i).Table(i)("LINKDESCARGA").ToString
                    Dim tab As String
                    tab = "Archivo" + Convert.ToString(i + 1)
                    Dim NewTab As New XtraTabPage
                    NewTab.Name = tab
                    NewTab.Text = tab
                    MiForm.XtraTabControl1.TabPages.Add(NewTab)

                    Dim uccontrol1 As New XtraUserControlWebBrowser()
                    NewTab.Controls.Add(uccontrol1)
                    uccontrol1.Dock = DockStyle.Fill

                    uccontrol1.WebBrowser1.Show()
                    uccontrol1.WebBrowser1.Navigate(String.Format(ruta, Application.StartupPath))
                Next
                MiForm.ShowDialog()
            Else
                MessageBox.Show("La solicitud no contiene archivo", "Archivo de préstamo")
            End If
        End If
    End Sub

    Private Sub RepositoryItemActaCompromiso_Click(sender As Object, e As EventArgs) Handles RepositoryItemActaCompromiso.Click
        PrestamoDAO.IdPrestamo = GridView1.GetFocusedRowCellValue("IDPRESTAMO")
        If PrestamoDAO.IdPrestamo <> 0 Then
            Dim MiForm As New SolicitudPrestamoArchivos
            Dim dt As DataTable = PrestamoDAO.GetPrestamosCompromisoArchivo(PrestamoDAO.IdPrestamo)
            If dt.Rows.Count <> 0 Then

                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim ruta As String = dt.Rows(i).Table(i)("LINKDESCARGA").ToString
                    Dim tab As String
                    tab = "Archivo" + Convert.ToString(i + 1)
                    Dim NewTab As New XtraTabPage
                    NewTab.Name = tab
                    NewTab.Text = tab
                    MiForm.XtraTabControl1.TabPages.Add(NewTab)

                    Dim uccontrol1 As New XtraUserControlWebBrowser()
                    NewTab.Controls.Add(uccontrol1)
                    uccontrol1.Dock = DockStyle.Fill

                    uccontrol1.WebBrowser1.Show()
                    uccontrol1.WebBrowser1.Navigate(String.Format(ruta, Application.StartupPath))

                Next
                MiForm.ShowDialog()
            Else
                MessageBox.Show("La solicitud no contiene archivo", "Archivo de préstamo")
            End If
        End If
    End Sub

    Private Sub btnExportar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportar.ItemClick
        If GridView1.RowCount > 0 Then
            GridView1.Columns(0).Visible = False
            GridView1.Columns(1).Visible = False
            GridView1.Columns(2).Visible = False

            GridView1.Columns("ESTADOREGISTROADRYAN").Visible = False
            GridView1.Columns("ESTADODEPOSITO").Visible = False
            GridView1.Columns("ESTADOANULADORRHH").Visible = False
            GridView1.Columns("DESCRIPCIONESTADOREGISTROADRYAN").Visible = True
            GridView1.Columns("DESCRIPCIONESTADODEPOSITO").Visible = True
            GridView1.Columns("DESCRIPCIONESTADOANULADORRHH").Visible = True
            Try
                Dim ruta As String
                ruta = My.Application.Info.DirectoryPath() + "\SolicitudesPrestamos.xlsx"
                GridControl1.ExportToXlsx(ruta)
                Process.Start(ruta)
            Catch ex As Exception
                MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
            End Try

            GridView1.Columns(0).VisibleIndex = 0
            GridView1.Columns(1).VisibleIndex = 1
            GridView1.Columns(2).VisibleIndex = 2
            GridView1.Columns(0).Visible = True
            GridView1.Columns(1).Visible = True
            GridView1.Columns(2).Visible = True

            GridView1.Columns("ESTADOREGISTROADRYAN").Visible = True
            GridView1.Columns("ESTADODEPOSITO").Visible = True
            GridView1.Columns("ESTADOANULADORRHH").Visible = True
            GridView1.Columns("DESCRIPCIONESTADOREGISTROADRYAN").Visible = False
            GridView1.Columns("DESCRIPCIONESTADODEPOSITO").Visible = False
            GridView1.Columns("DESCRIPCIONESTADOANULADORRHH").Visible = False
            GridView1.Columns("IDPRESTAMO").Visible = False
        End If
    End Sub

    Private Sub chkFechaSolicitud_CheckedChanged(sender As Object, e As ItemClickEventArgs) Handles chkFechaSolicitud.CheckedChanged
        If chkFechaSolicitud.Checked Then
            chkFechaRegistro.Checked = False
        End If
    End Sub

    Private Sub chkFechaRegistro_CheckedChanged(sender As Object, e As ItemClickEventArgs) Handles chkFechaRegistro.CheckedChanged
        If chkFechaRegistro.Checked Then
            chkFechaSolicitud.Checked = False
        End If
    End Sub
End Class