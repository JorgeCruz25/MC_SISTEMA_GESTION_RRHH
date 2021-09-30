Imports MC.Data
Imports MC.Framework
Public Class SolicitudBonoExtraDetails
    Dim BonoExtraBE As New BonoExtraBE
    Dim bsSolicitudesBonosExtras As New BindingSource


    Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO BENEFICIO", "BONOESTRATIPO", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO", "CARGOEMPLEADO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MONTOA PROBADO", "MONTOAPROBADO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHAA PROBACION", "FECHAAPROBACIONRRHH", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridView1
            .Columns("BONOESTRATIPO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CARGOEMPLEADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("MONTOAPROBADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAAPROBACIONRRHH").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
            Me.GridControl1.DataSource = bsSolicitudesBonosExtras
        ListarBonoBeneficioFinMes()
    End Sub
    Private Sub ListarBonoBeneficioFinMes()
        Try
            bsSolicitudesBonosExtras.DataSource = BonoExtraDAO.BonoExtraListAllById(BonoExtraDAO.IdEmpleado, BonoExtraDAO.IdBonoExtraTipo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub SolicitudBonoExtraDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        If BonoExtraDAO.IdBonoExtraSolicitud <> 0 Then
            BonoExtraBE = BonoExtraDAO.GetBonoExtraByID(BonoExtraDAO.IdBonoExtraSolicitud)
            With BonoExtraBE
                txtCargo.Text = .CargoEmpleado
                txtDni.Text = .DniEmpleado
                txtEmpleado.Text = .NombreEmpleado
                txtFechaSolicitud.Text = .Fecha
                txtIngresoCorporativo.Text = .FechaIngresoCorporativo
                txtIngresoLocal.Text = .FechaIngresoLocal
                txtLocal.Text = .RazonComercial
                txtMonto.Text = .MontoSolicitado
                txtMontoAprobado.Text = .MontoAprobado
                txtSolicitante.Text = .NombreSolicitante
                txtTipoBeneficio.Text = .BonoExtraTipo
                DesabilitarCampos()
            End With
        End If
    End Sub
    Private Sub DesabilitarCampos()
        txtCargo.Enabled = False
        txtDni.Enabled = False
        txtEmpleado.Enabled = False
        txtFechaSolicitud.Enabled = False
        txtIngresoCorporativo.Enabled = False
        txtIngresoLocal.Enabled = False
        txtLocal.Enabled = False
        txtMonto.Enabled = False
        txtSolicitante.Enabled = False
        txtTipoBeneficio.Enabled = False
    End Sub
    Private Function Validar() As Boolean

        DxErrorProvider1.ClearErrors()
        Dim Result As Boolean = True

        If txtMontoAprobado.Text = 0 Then
            DxErrorProvider1.SetError(txtMontoAprobado, "Dato obligatorio")
            Result = False
        End If
        With BonoExtraBE

            .IdBonoExtraSolicitud = BonoExtraDAO.IdBonoExtraSolicitud
            .MontoAprobado = txtMontoAprobado.Text
        End With
        Return Result
    End Function

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnAprobar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAprobar.ItemClick
        If Validar() Then
            If MessageBox.Show("¿Esta seguro de validar el Beneficio?", "Asignar Beneficio", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                If BonoExtraDAO.BonoExtraAprobar(BonoExtraBE) Then
                    Me.Close()
                Else
                    MessageBox.Show("Error al aprobar")
                End If
            End If
        End If
    End Sub

    Private Sub btnAnular_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnular.ItemClick
        If MessageBox.Show("¿Esta seguro de anular el Beneficio?", "Anular Beneficio", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            If BonoExtraDAO.BonoExtraAnular(BonoExtraDAO.IdBonoExtraSolicitud, BDCentralDAO.UsuarioBE.IDUsuario) Then
                Me.Close()
            Else
                MessageBox.Show("Error al anular")
            End If
        End If
    End Sub
End Class