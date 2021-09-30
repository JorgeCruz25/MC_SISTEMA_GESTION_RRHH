Imports DevExpress.XtraEditors
Imports MC.Data
Imports MC.Framework

Public Class EmpleadoAumentoSalarial
    Dim bsEmpleados As New BindingSource
    Dim EmpleadoBE As New EmpleadoBE

    Dim EmpleadoAumentoSueldoBE As New EmpleadoAumentoSueldoBE

    Sub New()
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridViewColumn(RepositoryItemGridLookUpEditEmpleadoView, "IDEMPLEADO", "IDEMPLEADO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(RepositoryItemGridLookUpEditEmpleadoView, "NOMBRES", "NOMBRES", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(RepositoryItemGridLookUpEditEmpleadoView, "APELLIDO PATERNO", "APELLIDOPATERNO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(RepositoryItemGridLookUpEditEmpleadoView, "APELLIDO MATERNO", "APELLIDOMATERNO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(RepositoryItemGridLookUpEditEmpleadoView, "N° DE IDENTIDAD", "DNI", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With RepositoryItemGridLookUpEditEmpleadoView
            .Columns("NOMBRES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOPATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOMATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("DNI").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        RepositoryItemGridLookUpEditEmpleado.DataSource = BDAccionPersonalDAO.GetEmpleadosAccionPersonalActivosList()

        RepositoryItemGridLookUpEditEmpleado.ValueMember = "IDEMPLEADO"
        RepositoryItemGridLookUpEditEmpleado.DisplayMember = "EMPLEADO"

        RepositoryItemGridLookUpEditEmpleado.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

        CargarMotivoAumento()

    End Sub

    Private Sub CargarMotivoAumento()
        ControlesDevExpress.InitGridViewColumn(GridViewMotivoAumento, "ID", "CODIGOMOTIVOAUMENTO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewMotivoAumento, "MOTIVO AUMENTO", "MOTIVOAUMENTO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewMotivoAumento
            .Columns("MOTIVOAUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleMotivoAumento.Properties.DataSource = BDAccionPersonalDAO.GetMotivoAumentoList
        sleMotivoAumento.Properties.DisplayMember = "MOTIVOAUMENTO"
        sleMotivoAumento.Properties.ValueMember = "CODIGOMOTIVOAUMENTO"
        sleMotivoAumento.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub LoadEntidad()

        If BDAccionPersonalDAO.IdEmpleado <> 0 Then
            EmpleadoBE = BDAccionPersonalDAO.GetByEmpleadoID(BDAccionPersonalDAO.IdEmpleado)
            With EmpleadoBE
                txtIdEmpleado.Text = .IDEMPLEADO
                txtNombres.Text = .NOMBRES
                txtApellidoPaterno.Text = .APELLIDOPATERNO
                txtApellidoMaterno.Text = .APELLIDOMATERNO
                txtCodigoUnico.Text = .CODIGOUNICO
                txtSueldo.Text = .SUELDO
            End With
        End If


        'Tools.AccionesUsuario(Me.Controls, dtAccionesUsuario, gvDocumentos)

        'ListarPlanillas()

        'If Not Page.IsPostBack Then
        '    Session("PlanillaMovilidadBE") = PlanillaMovilidadBE
        'End If
    End Sub

    Private Sub RepositoryItemGridLookUpEditEmpleado_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemGridLookUpEditEmpleado.EditValueChanged
        Dim editor As GridLookUpEdit = TryCast(sender, GridLookUpEdit)
        Dim id As Object = editor.Properties.View.GetFocusedRowCellValue("IDEMPLEADO")

        BDAccionPersonalDAO.IdEmpleado = id
        LoadEntidad()
    End Sub

    Private Function Validar() As Boolean
        Dim Result As Boolean = True

        DxErrorProvider1.ClearErrors()

        If sleMotivoAumento.EditValue Is Nothing Then
            DxErrorProvider1.SetError(sleMotivoAumento, "Dato obligatorio")
            Result = False
        End If
        If deFechaAumento.EditValue Is Nothing Then
            DxErrorProvider1.SetError(deFechaAumento, "Dato obligatorio")
            Result = False
        End If
        If txtMontoAumento.Text = "0" Or txtMontoAumento.Text = "" Then
            DxErrorProvider1.SetError(txtMontoAumento, "Dato obligatorio")
            Result = False
        End If
        If txtSueldoNuevo.Text = "0" Or txtSueldoNuevo.Text = "" Then
            DxErrorProvider1.SetError(txtSueldoNuevo, "Dato obligatorio")
            Result = False
        End If


        If Result Then
            With EmpleadoAumentoSueldoBE
                .IDEMPLEADO = txtIdEmpleado.Text
                .CODIGOUNICO = EmpleadoBE.CODIGOUNICO

                .CODIGOAUMENTOSUELDO = sleMotivoAumento.EditValue
                .FECHAAUMENTO = deFechaAumento.Text
                .SUELDOANTERIOR = EmpleadoBE.SUELDO
                .MONTOAUMENTO = Convert.ToDouble(txtMontoAumento.Text)
                .PORCENTAJEAUMENTO = Convert.ToDouble(txtPorcentajeAumento.Text)
                .SUELDONUEVO = Convert.ToDouble(txtSueldoNuevo.Text)

                .IDUSUARIOREGISTRO = BDCentralDAO.UsuarioBE.IDUsuario
                .USUARIOREGISTRO = BDCentralDAO.UsuarioBE.Usuario
            End With
        End If

        Return Result

    End Function

    Private Sub txtMontoAumento_EditValueChanged(sender As Object, e As EventArgs) Handles txtMontoAumento.EditValueChanged
        Dim porcentajeAumento As Double
        Dim sueldoNuevo As Double

        porcentajeAumento = (Convert.ToDouble(txtMontoAumento.Text) * 100) / Convert.ToDouble(txtSueldo.Text)
        sueldoNuevo = Convert.ToDouble(txtSueldo.Text) + Convert.ToDouble(txtMontoAumento.Text)

        txtPorcentajeAumento.Text = porcentajeAumento
        txtSueldoNuevo.Text = sueldoNuevo
    End Sub

    Private Sub btnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick
        If BDAccionPersonalDAO.IdEmpleado = 0 Then
            Exit Sub
        End If

        If Me.Validar() Then
            Cursor = Cursors.WaitCursor
            'CREA AUMENTO SUELDO EMPLEADO ADRYAN
            If BDAccionPersonalDAO.AumentoSueldoEmpleadoAdryan(EmpleadoAumentoSueldoBE) Then
                'INSERTA REGISTRO AUMENTO SUELDO
                'ACTUALIZA SUELDO AZURE
                If Not BDAccionPersonalDAO.InsertaAumentoSueldoPersonal(EmpleadoAumentoSueldoBE) Then
                    MessageBox.Show("Error al registrar el aumento de sueldo", "Error de Registro")
                    Cursor = Cursors.Default
                    Exit Sub
                End If

            Else
                MessageBox.Show("Problemas de Conexión con el sistema Adryan", "Error de Conexión")
                Cursor = Cursors.Default
                Exit Sub

            End If
            Cursor = Cursors.Default
            Me.Close()

        End If

    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub txtMontoAumento_Click(sender As Object, e As EventArgs) Handles txtMontoAumento.Click
        txtMontoAumento.SelectAll()
    End Sub

End Class