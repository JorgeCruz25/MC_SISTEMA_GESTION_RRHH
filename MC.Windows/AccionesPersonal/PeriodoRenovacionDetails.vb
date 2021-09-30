Imports MC.Data
Imports MC.Framework
Public Class PeriodoRenovacionDetails
    Dim RenovacionContratoBE As New RenovacionContratoBE

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        CargarTipoPeriodo()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub CargarTipoPeriodo()
        ControlesDevExpress.InitGridViewColumn(GridViewTipoPeriodo, "ID", "IDTIPOPERIODO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewTipoPeriodo, "DESCRIPCION", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewTipoPeriodo
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleTipoPeriodo.Properties.DataSource = BDAccionPersonalDAO.GetTipoPeriodoRenovacionList
        sleTipoPeriodo.Properties.DisplayMember = "DESCRIPCION"
        sleTipoPeriodo.Properties.ValueMember = "IDTIPOPERIODO"
        sleTipoPeriodo.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Function ValidarPeriodoRenovacion() As Boolean
        DxErrorProvider1.ClearErrors()
        Dim Result As Boolean = True
        If sleTipoPeriodo.EditValue Is Nothing Then
            DxErrorProvider1.SetError(sleTipoPeriodo, "Dato obligatorio")
            Result = False
        End If
        If deFechaDesde.EditValue Is Nothing Or deFechaDesde.Text = "" Then
            DxErrorProvider1.SetError(deFechaDesde, "Dato obligatorio")
            Result = False
        End If
        If deFechaHasta.EditValue Is Nothing Or deFechaHasta.Text = "" Then
            DxErrorProvider1.SetError(deFechaHasta, "Dato obligatorio")
            Result = False
        End If
        If deFechaDesde.EditValue > deFechaHasta.EditValue Then
            MessageBox.Show("La Fecha del periodo inicio no puede ser mayor a la fecha periodo final.")
            Result = False
        End If
        If BDAccionPersonalDAO.ValidacionPeriodoRenovacion(sleTipoPeriodo.EditValue) = 0 Then
            MessageBox.Show("Aun existe un periodo abierto")
            Result = False
        End If

        If Result Then
            With RenovacionContratoBE
                .IdPeriodoRenovacion = BDAccionPersonalDAO.IdPeriodoRenovacion
                .IdPeriodoTipo = sleTipoPeriodo.EditValue
                .FechaPeriodoInicio = deFechaDesde.EditValue
                .FechaPeriodoFin = deFechaHasta.EditValue
            End With
        End If
        Return Result
    End Function
    Private Sub btnAgregar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAgregar.ItemClick

        If ValidarPeriodoRenovacion() Then
            If BDAccionPersonalDAO.InsertaPeriodoRenovacionContrato(RenovacionContratoBE, BDCentralDAO.UsuarioBE.IDUsuario) Then
                MessageBox.Show("Periodo Creado.")
                Me.Close()
            End If
        End If
    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub PeriodoRenovacionDetails_Load(sender As Object, e As EventArgs) Handles Me.Load

        'BDAccionPersonalDAO.Accion = Accion 1 es nuevo periodo, Acción 2 es editar un periodo
        If BDAccionPersonalDAO.Accion = 2 Then

            If BDAccionPersonalDAO.IdPeriodoRenovacion > 0 Then
                RenovacionContratoBE = BDAccionPersonalDAO.GetByPeriodoRenovacionID(BDAccionPersonalDAO.IdPeriodoRenovacion, sleTipoPeriodo.EditValue, BDAccionPersonalDAO.Accion)

                If RenovacionContratoBE.EstadoValidado Then

                    deFechaDesde.Properties.MinValue = RenovacionContratoBE.FechaPeriodoFin

                    With RenovacionContratoBE
                        sleTipoPeriodo.EditValue = .IdPeriodoTipo
                        deFechaDesde.EditValue = .FechaPeriodoInicio
                        deFechaHasta.EditValue = .FechaPeriodoFin
                    End With
                Else

                End If
            End If

        End If

    End Sub

    Private Sub sleTipoPeriodo_TextChanged(sender As Object, e As EventArgs) Handles sleTipoPeriodo.TextChanged
        Dim dt As DataTable
        dt = BDAccionPersonalDAO.GetPeriodoRenovacionList
        If dt.Rows.Count > 0 Then
            Dim FECHAOPTENIDA As Date = BDAccionPersonalDAO.ValidacionFechaPeriodoRenovacion(sleTipoPeriodo.EditValue)
            deFechaDesde.Properties.MinValue = FECHAOPTENIDA
        End If
    End Sub
End Class