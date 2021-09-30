
Imports MC.Data
Imports MC.Framework
Public Class EmpleadoRenovacionList

    Dim bsRenovaciones As New BindingSource

    Public Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = False

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDEMPLEADO", "IDEMPLEADO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA FINAL CONTRATO", "FECHAFINALCONTRATO", 140, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBRES", "NOMBRES", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "APELLIDO PATERNO", "APELLIDOPATERNO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "APELLIDO MATERNO", "APELLIDOMATERNO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DE IDENTIDAD", "DNI", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO DE CONTRATO", "TIPOCONTRATO", 160, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MATRICULA", "MATRICULA", 160, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CODIGOUNICO", "CODIGOUNICO", 160, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridView1
            .Columns("NOMBRES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOPATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOMATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("DNI").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONSOCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("TIPOCONTRATO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        btnFechaInicial.EditValue = DateTime.Now.Date
        btnFechaFinal.EditValue = DateTime.Now.Date.AddDays(+30)

        AddHandler btnFechaFinal.EditValueChanged, AddressOf Buscar
        AddHandler btnBuscar.ItemClick, AddressOf Buscar

        Me.GridControl1.DataSource = bsRenovaciones
        Buscar()
    End Sub

    Public Sub Buscar()
        Try
            bsRenovaciones.DataSource = BDAccionPersonalDAO.GetEmpleadoRenovacionList(btnFechaInicial.EditValue, btnFechaFinal.EditValue)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub EmpleadoRenovacionList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MEDesktop.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub btnGenerarRenovacion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGenerarRenovacion.ItemClick
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()

        GridView1.ClearColumnsFilter()
        GridView1.FindFilterText = ""

        Dim xIdEmpleado As Integer
        Dim xFechaFinalContrato As Date
        Dim xFechaFinalContratoNuevo As Date
        Dim xCodigoUnico As String

        Dim xUltimoNumeroContrato as string

        Cursor = Cursors.WaitCursor

        xUltimoNumeroContrato = BDAccionPersonalDAO.GetObtenerUltimoContrato()

        If xUltimoNumeroContrato = "" Then
            MessageBox.Show("Problemas de Conexión con el sistema Adryan", "Error de Conexión")
            Cursor = Cursors.Default
            Exit Sub
        End If

        For j As Integer = 0 To GridView1.RowCount - 1
            Dim ESTADOASIGNACION As Boolean

            ESTADOASIGNACION = If(GridView1.GetRowCellValue(j, "ESTADO").ToString = "False", 0, 1)

            If ESTADOASIGNACION Then
                xIdEmpleado = GridView1.GetRowCellValue(j, "IDEMPLEADO")
                xFechaFinalContrato = GridView1.GetRowCellValue(j, "FECHAFINALCONTRATO")
                xFechaFinalContratoNuevo = GridView1.GetRowCellValue(j, "FECHAFINALCONTRATONUEVO")
                xCodigoUnico = GridView1.GetRowCellValue(j, "CODIGOUNICO")

                'CREA RENOVACION EN ADRYAN
                If BDAccionPersonalDAO.InsertaEmpleadoContratoAdryan(xCodigoUnico, xUltimoNumeroContrato, xFechaFinalContrato, xFechaFinalContratoNuevo) Then

                    'CREA RENOVACION MC_CENTRAL
                    If Not BDAccionPersonalDAO.InsertaEmpleadoContrato(xIdEmpleado, xFechaFinalContratoNuevo, BDCentralDAO.UsuarioBE.IDUsuario) Then
                        MessageBox.Show("Error al registrar el empleado", "Error de Registro")
                        Cursor = Cursors.Default
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("Problemas de Conexión con el sistema Adryan", "Error de Conexión")
                    Cursor = Cursors.Default
                    Exit Sub
                End If

            End If
        Next

        Buscar()
        Cursor = Cursors.Default
    End Sub

End Class