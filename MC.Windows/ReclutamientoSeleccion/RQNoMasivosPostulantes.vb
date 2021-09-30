Imports MC.Data
Imports MC.Framework

Public Class RQNoMasivosPostulantes

    Dim PostulanteNoMasivoBE As New PostulanteNoMasivoBE

    Private Sub PostulantesNoMasivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridView1.Columns(0).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(1).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(2).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(3).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(4).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(5).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(6).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        GridView1.Columns(7).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left

        RepositoryItemGridLookUpEditTipoIdentidad.DataSource = BDCentralDAO.GetTipoIdentidadList
        RepositoryItemGridLookUpEditTipoIdentidad.ValueMember = "IDTIPODOCUMENTOIDENTIDAD"
        RepositoryItemGridLookUpEditTipoIdentidad.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditCargo.DataSource = BDCentralDAO.GetCargoList
        RepositoryItemGridLookUpEditCargo.ValueMember = "IDCARGO"
        RepositoryItemGridLookUpEditCargo.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditFuente.DataSource = BDCentralDAO.GetFuenteReclutamientoList
        RepositoryItemGridLookUpEditFuente.ValueMember = "IDFUENTE"
        RepositoryItemGridLookUpEditFuente.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditEstado.DataSource = BDCentralDAO.GetEstadoPostulanteList
        RepositoryItemGridLookUpEditEstado.ValueMember = "IDESTADO"
        RepositoryItemGridLookUpEditEstado.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditEstadoCrediticio.DataSource = BDCentralDAO.GetEstadoCrediticioList
        RepositoryItemGridLookUpEditEstadoCrediticio.ValueMember = "IDESTADOCREDITICIO"
        RepositoryItemGridLookUpEditEstadoCrediticio.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditEstadoPsicologico.DataSource = BDCentralDAO.GetEstadoPsicologicoList
        RepositoryItemGridLookUpEditEstadoPsicologico.ValueMember = "IDESTADOPSICOLOGICO"
        RepositoryItemGridLookUpEditEstadoPsicologico.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditEstadoAssesment.DataSource = BDCentralDAO.GetEstadoAssesmentList
        RepositoryItemGridLookUpEditEstadoAssesment.ValueMember = "IDESTADOASSESMENT"
        RepositoryItemGridLookUpEditEstadoAssesment.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditEstadoEntrevistaSeleccion.DataSource = BDCentralDAO.GetEntrevistaSelecciontList
        RepositoryItemGridLookUpEditEstadoEntrevistaSeleccion.ValueMember = "IDENTREVISTASELECCION"
        RepositoryItemGridLookUpEditEstadoEntrevistaSeleccion.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditEstadoEntrevistaPrevia.DataSource = BDCentralDAO.GetEntrevistaPreviaList
        RepositoryItemGridLookUpEditEstadoEntrevistaPrevia.ValueMember = "IDENTREVISTAPREVIA"
        RepositoryItemGridLookUpEditEstadoEntrevistaPrevia.DisplayMember = "DESCRIPCION"

        RepositoryItemGridLookUpEditEstadoEntrevistaArea.DataSource = BDCentralDAO.GetEntrevistaAreaFinalList
        RepositoryItemGridLookUpEditEstadoEntrevistaArea.ValueMember = "IDENTREVISTAAREAFINAL"
        RepositoryItemGridLookUpEditEstadoEntrevistaArea.DisplayMember = "DESCRIPCION"

        Refrescar()
    End Sub

    Private Sub GridView1_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GridView1.RowUpdated

        Cursor = Cursors.WaitCursor

        With PostulanteNoMasivoBE
            .IDPOSTULANTENOMASIVO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDPOSTULANTENOMASIVO")
            .IDTIPODOCUMENTOIDENTIDAD = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDTIPODOCUMENTOIDENTIDAD")
            .NUMERODOCUMENTO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "NUMERODOCUMENTO").ToString
            .NOMBRES = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "NOMBRES").ToString
            .APELLIDOPATERNO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "APELLIDOPATERNO").ToString
            .APELLIDOMATERNO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "APELLIDOMATERNO").ToString
            .TELEFONOFIJO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "TELEFONOFIJO").ToString
            .TELEFONOCELULAR = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "TELEFONOCELULAR").ToString
            .TELEFONOCELULAR2 = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "TELEFONOCELULAR2").ToString
            .CORREO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "CORREO").ToString
            .FECHANACIMIENTO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHANACIMIENTO")
            .IDFUENTE = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDFUENTE")
            .SALARIO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "SALARIO").ToString
            .OBSERVACION = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "OBSERVACION").ToString
            .IDESTADO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDESTADO")
            .HORA = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "HORA").ToString
            .FECHACONVOCATORIA1 = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHACONVOCATORIA1")
            .FECHACONVOCATORIA2 = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHACONVOCATORIA2")
            .FECHACONVOCATORIA3 = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "FECHACONVOCATORIA3")
            .IDESTADOCREDITICIO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDESTADOCREDITICIO")
            .MONTOADEUDADO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "MONTOADEUDADO")
            .DIAVENCIMIENTO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DIAVENCIMIENTO")
            .ENTIDAD = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ENTIDAD")
            .IDESTADOPSICOLOGICO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDESTADOPSICOLOGICO")
            .IDESTADOASSESMENT = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDESTADOASSESMENT")
            .IDENTREVISTASELECCION = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDENTREVISTASELECCION")
            .OBSERVACION2 = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "OBSERVACION2").ToString
            .IDENTREVISTAPREVIA = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDENTREVISTAPREVIA")
            .IDENTREVISTAAREAFINAL = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDENTREVISTAAREAFINAL")
            .OBSERVACION3 = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "OBSERVACION3").ToString
            .ESTADOASIGNACION = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ESTADOASIGNACION")
        End With

        BDCentralDAO.PostulanteNoMasivoUpdate(PostulanteNoMasivoBE)

        Cursor = Cursors.Default
    End Sub
    Private Sub inabilitarbotones()
        btnNuevo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnBuscarPostulantes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnProcesar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub
    Private Sub Refrescar()
        inabilitarbotones()
        Dim dtAccionesUsuario As DataTable
        dtAccionesUsuario = UsuarioDAO.GetAccionesUsuario(BDCentralDAO.UsuarioBE.IDUsuario, IDSistema, Me.Name)
        Tools.AccionesUsuarioRibbon(RibbonControl, dtAccionesUsuario)
        GridControl1.DataSource = BDCentralDAO.GetPostulantesNoMasivosListxRequerimiento(BDCentralDAO.IdRequerimiento)
    End Sub

    Private Sub btnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick
        Dim MiForm As New RQNoMasivosPostulantesAgregar
        MiForm.ShowDialog()
        Refrescar()
    End Sub

    Private Sub btnBuscarPostulantes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBuscarPostulantes.ItemClick
        Dim MiForm As New RQNoMasivosPostulantesBuscar
        MiForm.ShowDialog()
        Refrescar()
    End Sub

    Private Sub btnProcesar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnProcesar.ItemClick

        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()

        GridView1.ClearColumnsFilter()
        GridView1.FindFilterText = ""

        Cursor = Cursors.WaitCursor

        Dim listAsignados As New List(Of Integer)

        Dim xVacante As Integer = 0
        Dim xAsignados As Integer = 0
        Dim xIdPostulanteNoMasivo As Integer

        Dim idtipoidentidad As Integer = 0
        Dim numeroidentidad As String = ""
        Dim nombres As String = ""
        Dim apellidopaterno As String = ""
        Dim apellidomaterno As String = ""
        Dim idfuente As String = ""
        Dim fechanacimiento As Date
        Dim idcargo As Integer = 0

        For j As Integer = 0 To GridView1.RowCount - 1
            Dim ESTADOASIGNACION As Boolean

            ESTADOASIGNACION = If(GridView1.GetRowCellValue(j, "ESTADOASIGNACION").ToString = "False", 0, 1)

            If ESTADOASIGNACION Then
                xIdPostulanteNoMasivo = GridView1.GetRowCellValue(j, "IDPOSTULANTENOMASIVO")
                idtipoidentidad = GridView1.GetRowCellValue(j, "IDTIPODOCUMENTOIDENTIDAD")
                numeroidentidad = GridView1.GetRowCellValue(j, "NUMERODOCUMENTO")
                idcargo = GridView1.GetRowCellValue(j, "IDCARGO")
                nombres = GridView1.GetRowCellValue(j, "NOMBRES").ToString
                apellidopaterno = GridView1.GetRowCellValue(j, "APELLIDOPATERNO").ToString
                apellidomaterno = GridView1.GetRowCellValue(j, "APELLIDOMATERNO").ToString
                idfuente = GridView1.GetRowCellValue(j, "IDFUENTE")
                fechanacimiento = GridView1.GetRowCellValue(j, "FECHANACIMIENTO").ToString

                If idtipoidentidad = 0 Or numeroidentidad = "" Then
                    Cursor = Cursors.Default
                    MessageBox.Show("El postulante asignado no tienen Tipo de Indetidad o Número de Identidad registrado.")
                    Exit Sub
                End If

                If nombres = "" Or apellidopaterno = "" Or apellidomaterno = "" Then
                    Cursor = Cursors.Default
                    MessageBox.Show("Información incompleta, ingresar el nombre y apellidos para procesar el requerimiento.")
                    Exit Sub
                End If

                If idcargo = BDCentralDAO.IdRequerimientoCargo Then
                Else
                    Cursor = Cursors.Default
                    MessageBox.Show("El postulante asignado no tienen el mismo cargo del Requerimiento.")
                    Exit Sub
                End If

                If idfuente = 0 Then
                    Cursor = Cursors.Default
                    MessageBox.Show("Información incompleta, ingresar la fuente de reclutamiento para procesar el requerimiento.")
                    Exit Sub
                End If

                If fechanacimiento = "1900-01-01" Then
                    Cursor = Cursors.Default
                    MessageBox.Show("Información incompleta, ingresar fecha de nacimiento para procesar el requerimiento.")
                    Exit Sub
                End If

                xAsignados = xAsignados + 1

                'INSERTA TEMPORAL LOS POSTULANTES ASIGNADOS               
                listAsignados.Add(xIdPostulanteNoMasivo)

            End If
        Next

        If BDCentralDAO.NroVacantesNoMasivos < xAsignados Or (xAsignados = 0) Then
            Cursor = Cursors.Default
            MessageBox.Show("El requerimiento no tiene postulante(s) asignado(s) o " & vbNewLine & "El nro. de asignados es mayor al nro. de vacantes")
            Exit Sub
        Else
            If MessageBox.Show("Desea procesar el requerimiento?", "Procesar Requerimiento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                'ACTUALIZAR PERSONAL ASGINADO - RECORRE LISTA TEMPORAL
                Dim i As Integer
                For i = 0 To listAsignados.Count - 1
                    Dim xIdPostulanteNoMasivoAsignado As Integer
                    xIdPostulanteNoMasivoAsignado = listAsignados.Item(i)

                    'UPDATE ASIGNADO
                    If BDCentralDAO.PostulanteNoMasivoUpdateEstadoAsignacion(xIdPostulanteNoMasivoAsignado, BDCentralDAO.IdRequerimiento) Then
                        'INSERTA MC_EMPLEADO
                        If Not BDCentralDAO.InsertEmpleadoPostulanteNoMasivo(xIdPostulanteNoMasivoAsignado, BDCentralDAO.IdRequerimiento) Then
                            MessageBox.Show("Error al asignarlo como empleado", "Asignar empleado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    Else
                        MessageBox.Show("Error al procesar solicitud", "Procesar solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If


                Next i

                Dim dtrq As DataTable
                Dim xidrequerimientopersonal As Integer
                Dim xvacantesatendidas As Integer
                Dim xcierre As Integer

                dtrq = BDCentralDAO.RequerimientoPersonalValidarNoMasivo(BDCentralDAO.IdRequerimiento)
                xidrequerimientopersonal = dtrq.Rows(0)(0)
                xvacantesatendidas = dtrq.Rows(0)(1)
                xcierre = dtrq.Rows(0)(2)

                'ACTUALIZAR RQ EN CONTROL ATENCIONES
                If BDCentralDAO.RequerimientoPersonalUpdateVacantesAtendidas(xidrequerimientopersonal, xvacantesatendidas, xcierre) Then
                    BDCentralDAO.RequerimientoPersonalUpdateEstadoProcesarNoMasivo(BDCentralDAO.IdRequerimiento, xvacantesatendidas)
                Else
                    Cursor = Cursors.Default
                    MessageBox.Show("Problemas de conexión...", "Control de Atenciones")
                    Exit Sub
                End If

                Me.Close()
            End If
        End If

    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()

        Me.Close()
    End Sub

End Class