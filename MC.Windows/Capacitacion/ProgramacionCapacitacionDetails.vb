Imports MC.Framework
Imports MC.Data
Public Class ProgramacionCapacitacionDetails

    Dim bsCapacitacionDetalle As New BindingSource
    Dim EstadoCapacitacion As Integer
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        txtIdCapacitacion.Enabled = False
        CargarCurso()
        CargarResponsable()
        CargarModalidad()

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ID", "IDCAPACITACIONDETALLE", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA CAPACITACION", "FECHACAPACITACION", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "HORA INCIO", "HORAINCIO", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "HORA FINAL", "HORAFINAL", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO", "ESTADO", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDCAPACITACIONESTADO", "IDCAPACITACIONESTADO", 110, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridView1
            .Columns("FECHACAPACITACION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("HORAINCIO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("HORAFINAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("ESTADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains

        End With
        txtEstadoCapacitacion.Enabled = False
        If CapacitacionDAO.IdCapacitacion = 0 Then
            txtIdCapacitacion.Text = 0
            txtEstadoCapacitacion.Text = "Generado"
            btnAsignar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            btnAnular.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            btnCerrarCapacitacion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            GroupBoxNumeroClases.Visible = False
            btnNuevaClase.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            GridControl1.Visible = False
        Else
            Dim dtdatos As DataTable = CapacitacionDAO.ProgramacionCapacitacionGetId(CapacitacionDAO.IdCapacitacion)
            If dtdatos.Rows.Count > 0 Then
                sleCurso.EditValue = dtdatos.Rows(0)("IDCURSO")
                sleResponsable.EditValue = dtdatos.Rows(0)("IDEMPLEADORESPONSABLE")
                sleModalidad.EditValue = dtdatos.Rows(0)("IDCAPACITACIONMODALIDAD")
                txtIdCapacitacion.Text = dtdatos.Rows(0)("IDCAPACITACION")
                txtEstadoCapacitacion.Text = dtdatos.Rows(0)("ESTADOCAPACITACION")
                EstadoCapacitacion = dtdatos.Rows(0)("IDCAPACITACIONESTADO")
                If EstadoCapacitacion = 1 Then
                    btnCerrarCapacitacion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                ElseIf EstadoCapacitacion = 2 Then
                    btnAsignar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                ElseIf EstadoCapacitacion = 3 Then
                    btnGrabar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    btnAsignar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    btnCerrarCapacitacion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    btnAnular.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                ElseIf EstadoCapacitacion = 4 Then
                    btnGrabar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    btnAsignar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    btnCerrarCapacitacion.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    btnAnular.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    btnNuevaClase.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                End If
                Refrescar()
            Else
                Me.Close()
            End If
        End If


    End Sub
    Private Sub Refrescar()
        Try
            bsCapacitacionDetalle.DataSource = CapacitacionDAO.ProgramacionCapacitacionDetalleGetId(CapacitacionDAO.IdCapacitacion, CapacitacionDAO.Flat)
            Me.GridControl1.DataSource = bsCapacitacionDetalle
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CargarCurso()
        ControlesDevExpress.InitGridViewColumn(GridViewCurso, "ID", "IDCURSO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewCurso, "CURSO", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewCurso
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleCurso.Properties.DataSource = CapacitacionDAO.ProgramacionCapacitacionCursoList()
        sleCurso.Properties.DisplayMember = "DESCRIPCION"
        sleCurso.Properties.ValueMember = "IDCURSO"
        sleCurso.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarResponsable()
        ControlesDevExpress.InitGridViewColumn(GridViewResponsable, "ID", "IDEMPLEADO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewResponsable, "RESPONSABLE", "RESPONSABLE", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewResponsable
            .Columns("RESPONSABLE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleResponsable.Properties.DataSource = CapacitacionDAO.ProgramacionCapacitacionResponsableList()
        sleResponsable.Properties.DisplayMember = "RESPONSABLE"
        sleResponsable.Properties.ValueMember = "IDEMPLEADO"
        sleResponsable.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarModalidad()
        ControlesDevExpress.InitGridViewColumn(GridViewModalidad, "ID", "IDCAPACITACIONMODALIDAD", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewModalidad, "MODALIDAD", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewModalidad
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleModalidad.Properties.DataSource = CapacitacionDAO.ProgramacionCapacitacionModalidadList()
        sleModalidad.Properties.DisplayMember = "DESCRIPCION"
        sleModalidad.Properties.ValueMember = "IDCAPACITACIONMODALIDAD"
        sleModalidad.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

     Private Sub btnGrabar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGrabar.ItemClick
        If Validar() Then

            Try
                If MessageBox.Show("Estas seguro de grabar el registro", "Mensaje Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    If CapacitacionDAO.ProgramacionCapacitacionIns(CapacitacionDAO.IdCapacitacion, CapacitacionDAO.IdProgramacionEscuela, sleCurso.EditValue, sleResponsable.EditValue, sleModalidad.EditValue, BDCentralDAO.UsuarioBE.IDUsuario) Then
                        Me.Close()
                    End If
                End If

            Catch ex As Exception

            End Try
        End If

    End Sub
    Private Function Validar()
        Dim Result As Boolean = True

        DxErrorProvider1.ClearErrors()

        If sleCurso.EditValue Is Nothing Then
            DxErrorProvider1.SetError(sleCurso, "Dato obligatorio")
            Result = False
        End If
        If sleResponsable.Text = "" Then
            DxErrorProvider1.SetError(sleResponsable, "Dato obligatorio")
            Result = False
        End If
        If sleModalidad.EditValue Is Nothing Then
            DxErrorProvider1.SetError(sleModalidad, "Dato obligatorio")
            Result = False
        End If

        Return Result
    End Function


    Private Sub btnNuevaClase_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevaClase.ItemClick

        CapacitacionDAO.IdCapacitacionDetalle = 0
        Dim MiForm As New ClaseDetails
        MiForm.ShowDialog()
        Refrescar()
    End Sub

    Private Sub RepositoryItemEditar_Click(sender As Object, e As EventArgs) Handles RepositoryItemEditar.Click
        Dim EstadoClase As Int32 = GridView1.GetFocusedRowCellValue("IDCAPACITACIONESTADO")
        If (EstadoClase = 1 Or EstadoClase = 2) Then
            CapacitacionDAO.IdCapacitacionDetalle = GridView1.GetFocusedRowCellValue("IDCAPACITACIONDETALLE")
            Dim MiForm As New ClaseDetails
            MiForm.ShowDialog()
        Else
            If EstadoClase = 3 Then
                MessageBox.Show("La clase ya se encuentra Cerrada")
            Else
                MessageBox.Show("La clase se encuentra Anulada")
            End If
        End If

        Refrescar()
    End Sub

    Private Sub RepositoryItemVerAsistencia_Click(sender As Object, e As EventArgs) Handles RepositoryItemVerAsistencia.Click
        Dim EstadoClase As Int32 = GridView1.GetFocusedRowCellValue("IDCAPACITACIONESTADO")
        CapacitacionDAO.IdCapacitacionDetalle = GridView1.GetFocusedRowCellValue("IDCAPACITACIONDETALLE")
        If EstadoClase = 4 Then
            MessageBox.Show("El registro se encuentra anulado")
        Else

            If EstadoCapacitacion = 1 Then
                MessageBox.Show("Para poder ver las asistencias, la capacitación tiene que haber sido asignada")
            Else
                CapacitacionDAO.ProgramacionCapacitacionAsistenciaIns(CapacitacionDAO.IdCapacitacionDetalle, BDCentralDAO.UsuarioBE.IDUsuario)
                Dim MiForm As New CapacitacionAsistencia
                If CapacitacionDAO.Flat = 1 Then
                    MiForm.ShowDialog()
                Else
                    If (EstadoClase = 3 Or EstadoClase = 4) Then
                        If MessageBox.Show("El estado de esta clase se encuentra " & GridView1.GetFocusedRowCellValue("ESTADO") & ", por lo cual ya no podra realizar ninguna modificación, ¿Desea visualzar las asistencias?", "Mensaje Informativo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            MiForm.btnImportar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                            MiForm.btnGrabar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                            MiForm.ShowDialog()
                        End If
                    Else
                        MiForm.ShowDialog()
                    End If
                End If
                'If (EstadoClase <> 1 And EstadoClase <> 2) Then
                '    MiForm.btnImportar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                '    MiForm.btnGrabar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                '    MiForm.XtraTabPageAsistenciasPorRegistradas.Visible = False
                'End If

            End If
        End If



        Refrescar()
    End Sub

    Private Sub RepositoryItemAnular_Click(sender As Object, e As EventArgs) Handles RepositoryItemAnular.Click
        Dim EstadoClase As Int32 = GridView1.GetFocusedRowCellValue("IDCAPACITACIONESTADO")

        If (EstadoClase = 1 Or EstadoClase = 2) Then
            If MessageBox.Show("Estas seguro de anular el registro", "Mensaje Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                CapacitacionDAO.ProgramacionCapacitacionDetalleAnular(GridView1.GetFocusedRowCellValue("IDCAPACITACIONDETALLE"), BDCentralDAO.UsuarioBE.IDUsuario)
            End If
        Else
            If EstadoClase = 3 Then
                MessageBox.Show("La clase ya se encuentra Cerrada", "Mensaje Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("El Registro ya se encuentra Anulada", "Mensaje Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        Refrescar()
    End Sub

    Private Sub RepositoryItemProcesarClase_Click(sender As Object, e As EventArgs) Handles RepositoryItemProcesarClase.Click
        Dim EstadoClase As Int32 = GridView1.GetFocusedRowCellValue("IDCAPACITACIONESTADO")

        If (EstadoClase = 1 Or EstadoClase = 2) Then
            If CapacitacionDAO.ObtenerCantidadMarcaciones(GridView1.GetFocusedRowCellValue("IDCAPACITACIONDETALLE")) > 0 Then
                If CapacitacionDAO.ObtenerCantidadMarcacionesPendientes(GridView1.GetFocusedRowCellValue("IDCAPACITACIONDETALLE")) = 0 Then
                    If MessageBox.Show("Estas seguro de dar por culmidado el registro de la clase", "Mensaje Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        CapacitacionDAO.ProgramacionCapacitacionDetalleProcesar(GridView1.GetFocusedRowCellValue("IDCAPACITACIONDETALLE"), BDCentralDAO.UsuarioBE.IDUsuario)
                    End If
                Else
                    MessageBox.Show("La clase no cuenta con trabajadores sin asignar su asistencia", "Mensaje Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                MessageBox.Show("La clase no cuenta con ningún registro de asistencia", "Mensaje Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
            If EstadoClase = 3 Then
                MessageBox.Show("La clase ya se encuentra Cerrada", "Mensaje Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("El Registro ya se encuentra Anulada", "Mensaje Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        Refrescar()
    End Sub

    Private Sub btnAsignar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAsignar.ItemClick
        If EstadoCapacitacion = 2 Then
            MessageBox.Show("La Capacitacion ya se encuentra asignada", "Mensaje Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            If GridView1.RowCount = 0 Then
                MessageBox.Show("Para poder asignar la capacitación, tiene que tener la clase programada", "Mensaje Informativo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                Dim Estado As Int32
                Dim cantidadAnulados As Int32
                For i As Int32 = 0 To GridView1.RowCount - 1
                    Estado = GridView1.GetRowCellValue(i, "IDCAPACITACIONESTADO")
                    If Estado = 4 Then
                        cantidadAnulados = cantidadAnulados + 1
                    End If
                Next
                If cantidadAnulados = GridView1.RowCount Then
                    MessageBox.Show("No puede proceder con la asignación porque todas las clase asignadas se encuentran anuladas", "Mensaje Informativo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    If MessageBox.Show("Estas seguro de Asignar la capacitación, una vez asignado ya no podra editar la capacitación", "Mensaje Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        If CapacitacionDAO.ProgramacionCapacitacionAsignar(CapacitacionDAO.IdCapacitacion, BDCentralDAO.UsuarioBE.IDUsuario) Then
                            Me.Close()
                        End If
                    End If

                End If

            End If
        End If

    End Sub

    Private Sub btnAnular_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnular.ItemClick
        If MessageBox.Show("Se anulará todos los registro de esta capacitaciòn, estas seguro de anular la capacitaciòn?", "Mensaje Confirmaciòn", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            If CapacitacionDAO.ProgramacionCapacitacionAnular(CapacitacionDAO.IdCapacitacion, BDCentralDAO.UsuarioBE.IDUsuario) Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnCerrarCapacitacion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrarCapacitacion.ItemClick


        If GridView1.RowCount = 0 Then
            MessageBox.Show("No puede proceder con el cierre porque no cuenta con ninguna clase asignada", "Mensaje Informativo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Refresh()
        Else

            Dim Result As Int32 = 0
            For i As Int32 = 0 To GridView1.RowCount - 1
                Dim EstadoCapacitacion As Int32 = GridView1.GetRowCellValue(i, "IDCAPACITACIONESTADO")
                If EstadoCapacitacion = 1 Or EstadoCapacitacion = 2 Then
                    Result = 1
                    Exit For
                End If
            Next
            If Result = 1 Then
                MessageBox.Show("Existen clases en estado Generado, por favor cerrar las clases para poder proceder con el cierre de la capacitación", "Mensaje Informativo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Refresh()
            Else
                If CapacitacionDAO.ObtenerExistenciaNotasCapacitacion(CapacitacionDAO.IdCapacitacion) = 0 Then
                    MessageBox.Show("Para poder proceder con el cierre de la capacitacion tiene que haber registrado las notas", "Mensaje Informativo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    If CapacitacionDAO.ObtenerCantidadNotas(CapacitacionDAO.IdCapacitacion) > 0 Then
                        If CapacitacionDAO.ObtenerCantidadNotasPendientes(CapacitacionDAO.IdCapacitacion) = 0 Then
                            If MessageBox.Show("Estas seguro de cerrar la capacitaciòn?", "Mensaje Confirmaciòn", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                If CapacitacionDAO.ProgramacionCapacitacionCerrar(CapacitacionDAO.IdCapacitacion, BDCentralDAO.UsuarioBE.IDUsuario) Then
                                    Me.Close()
                                End If
                            End If
                        Else
                            MessageBox.Show("Existen notas pendientes de registro, por favor ingrese las notas", "Mensaje Informativo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        MessageBox.Show("No Existen notas registras, por favor ingrese las notas", "Mensaje Informativo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                End If
            End If
        End If
    End Sub
End Class