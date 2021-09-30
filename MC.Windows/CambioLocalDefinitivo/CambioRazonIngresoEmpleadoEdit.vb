Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Imports MC.Data
Imports MC.Framework
Public Class CambioRazonIngresoEmpleadoEdit
    Dim datosGrida As Int32 = 0

    Dim EmpleadoBE As New EmpleadoBE
    Dim CODIGOUNICOEMPLEADO As String
    Dim EMPLEADONOMBRE As String = ""

    Sub New()
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        CargarTipoDocumento()
        CargarCargos()
        CargarLocales()
        CargarTipoContrato()
        CargarSexo()
        CargarDistrito()
        CargarEstadoCivil()
        CargarNacionalidad()
        CargarPais()
        CargarMoneda()
        CargarRegimenSalarial()
        CargarCategoriaEmpleado()
        CargarTipoEmpleado()
        CargarUbicacionFisica()
        CargarRegimenFiscalizable()
        CargarTipoRemuneracion()
        CargarEsquemaVacacional()
        CargarDireccionConfianza()
        CargarInscritoPorcentajeFondosPencionesAfp()
        CargarTipoAfp()
        CargarTipoTrabajadorSunat()
        CargarBancoProCts()
        CargarBancoEnvioCts()
        CargarMonedaCts()
        CargarBancoPlanilla()
        CargarTipoCuentaAbono()
        CargarFormaPago()
        txtFlat.Visible = False

        XtraTabPageHijos.PageVisible = False
        If CambioLocalDefinitivoDAO.IdEmpleado = 0 Then
            btnRegistrarEmpleado.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Else
            btnRegistrarEmpleado.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            LoadEntidad()
        End If
    End Sub
    Private Sub CargarTipoDocumento()

        ControlesDevExpress.InitGridViewColumn(GridViewTipoIdentidad, "ID", "IDTIPODOCUMENTOIDENTIDAD", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewTipoIdentidad, "TIPO DE DOCUMENTO", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewTipoIdentidad
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleTipoIdentidad.Properties.DataSource = BDAccionPersonalDAO.GetTipoIdentidadList
        sleTipoIdentidad.Properties.DisplayMember = "DESCRIPCION"
        sleTipoIdentidad.Properties.ValueMember = "IDTIPODOCUMENTOIDENTIDAD"
        sleTipoIdentidad.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarCargos()
        ControlesDevExpress.InitGridViewColumn(GridViewCargo, "ID", "IDCARGO", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewCargo, "CARGO", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewCargo
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleCargo.Properties.DataSource = BDAccionPersonalDAO.GetCargoList
        sleCargo.Properties.DisplayMember = "DESCRIPCION"
        sleCargo.Properties.ValueMember = "IDCARGO"
        sleCargo.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarLocales()
        ControlesDevExpress.InitGridLookUpEditSearch(sleLocal, BDAccionPersonalDAO.GetLocalList, "IDORGANIGRAMA", "NOMBRE")
        ControlesDevExpress.InitGridLookUpEditSearchColumns(sleLocal, "ID", "IDORGANIGRAMA", 100, False)
        ControlesDevExpress.InitGridLookUpEditSearchColumns(sleLocal, "RAZON COMERCIAL", "RAZONCOMERCIAL", 200, True)
        ControlesDevExpress.InitGridLookUpEditSearchColumns(sleLocal, "NOMBRE", "NOMBRE", 220, True)
        With GridViewLocal
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOMBRE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
    End Sub
    Private Sub CargarTipoContrato()
        ControlesDevExpress.InitGridViewColumn(GridViewTipoContrato, "ID", "tipocontrato", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewTipoContrato, "DESCRIPCION", "descripcion", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewTipoContrato
            .Columns("descripcion").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleTipoContrato.Properties.DataSource = BDAccionPersonalDAO.GetTipoContratoList
        sleTipoContrato.Properties.DisplayMember = "descripcion"
        sleTipoContrato.Properties.ValueMember = "tipocontrato"
        sleTipoContrato.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarSexo()
        ControlesDevExpress.InitGridViewColumn(GridViewSexo, "ID", "IDSEXO", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewSexo, "DESCRIPCION", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewSexo
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleSexo.Properties.DataSource = BDAccionPersonalDAO.GetSexoList
        sleSexo.Properties.DisplayMember = "DESCRIPCION"
        sleSexo.Properties.ValueMember = "IDSEXO"
        sleSexo.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarDistrito()
        ControlesDevExpress.InitGridViewColumn(GridViewDistrito, "ID", "IDUBIGEO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDistrito, "DEPARTAMENTO", "DEPARTAMENTO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDistrito, "PROVINCIA", "PROVINCIA", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDistrito, "DISTRITO", "DISTRITO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDistrito, "UBIGEO", "UBIGEO", 180, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewDistrito
            .Columns("DEPARTAMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("PROVINCIA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("DISTRITO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleDistrito.Properties.DataSource = BDAccionPersonalDAO.GetDistritoList
        sleDistrito.Properties.DisplayMember = "UBIGEO"
        sleDistrito.Properties.ValueMember = "IDUBIGEO"
        sleDistrito.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarEstadoCivil()
        ControlesDevExpress.InitGridViewColumn(GridViewEstadoCivil, "ID", "IDESTADOCIVIL", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewEstadoCivil, "ESTADO CIVIL", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewEstadoCivil
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleEstadoCivil.Properties.DataSource = BDAccionPersonalDAO.GetEstadoCivilList
        sleEstadoCivil.Properties.DisplayMember = "DESCRIPCION"
        sleEstadoCivil.Properties.ValueMember = "IDESTADOCIVIL"
        sleEstadoCivil.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarPais()
        ControlesDevExpress.InitGridViewColumn(GridViewPais, "ID", "CODIGOPAIS", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewPais, "DESCRIPCION", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewPais
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        slePais.Properties.DataSource = BDAccionPersonalDAO.GetNacionalidadList
        slePais.Properties.DisplayMember = "DESCRIPCION"
        slePais.Properties.ValueMember = "CODIGOPAIS"
        slePais.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarNacionalidad()
        ControlesDevExpress.InitGridViewColumn(GridViewOriginario, "ID", "CODIGOPAIS", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewOriginario, "DESCRIPCION", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewOriginario
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleNacionalidad.Properties.DataSource = BDAccionPersonalDAO.GetNacionalidadList
        sleNacionalidad.Properties.DisplayMember = "DESCRIPCION"
        sleNacionalidad.Properties.ValueMember = "CODIGOPAIS"
        sleNacionalidad.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarMoneda()
        ControlesDevExpress.InitGridViewColumn(GridViewMoneda, "ID", "CODIGO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewMoneda, "DESCRIPCION", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewMoneda
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleMoneda.Properties.DataSource = BDAccionPersonalDAO.GetMonedaList
        sleMoneda.Properties.DisplayMember = "DESCRIPCION"
        sleMoneda.Properties.ValueMember = "CODIGO"
        sleMoneda.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarRegimenSalarial()
        ControlesDevExpress.InitGridViewColumn(GridViewRegimenSalarial, "ID", "IDREGIMEN", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewRegimenSalarial, "DESCRIPCION", "DESCRIPCION", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewRegimenSalarial
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleRegimenSalarial.Properties.DataSource = BDAccionPersonalDAO.GetRegimenSalarialList
        sleRegimenSalarial.Properties.DisplayMember = "DESCRIPCION"
        sleRegimenSalarial.Properties.ValueMember = "IDREGIMEN"
        sleRegimenSalarial.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarTipoEmpleado()
        ControlesDevExpress.InitGridViewColumn(GridViewTipoEmpleado, "ID", "CODIGOTIPOEMPLEADO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewTipoEmpleado, "TIPO EMPLEADO", "TIPOEMPLEADO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewTipoEmpleado
            .Columns("TIPOEMPLEADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleTipoEmpleado.Properties.DataSource = BDAccionPersonalDAO.GetTipoEmpleadoList
        sleTipoEmpleado.Properties.DisplayMember = "TIPOEMPLEADO"
        sleTipoEmpleado.Properties.ValueMember = "CODIGOTIPOEMPLEADO"
        sleTipoEmpleado.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarCategoriaEmpleado()
        ControlesDevExpress.InitGridViewColumn(GridViewCategoriaEmpleado, "ID", "CODIGOCATEGORIA", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewCategoriaEmpleado, "CATEGORIA", "CATEGORIA", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewCategoriaEmpleado
            .Columns("CATEGORIA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleCategoriaEmpleado.Properties.DataSource = BDAccionPersonalDAO.GetCategoriaEmpleadoList
        sleCategoriaEmpleado.Properties.DisplayMember = "CATEGORIA"
        sleCategoriaEmpleado.Properties.ValueMember = "CODIGOCATEGORIA"
        sleCategoriaEmpleado.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarUbicacionFisica()
        ControlesDevExpress.InitGridViewColumn(GridViewUbicacionFisica, "ID", "CODIGOUBICACIONFISICA", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewUbicacionFisica, "UBICACION FISICA", "UBICACIONFISICA", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewUbicacionFisica
            .Columns("UBICACIONFISICA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleUbicacionFisica.Properties.DataSource = BDAccionPersonalDAO.GetUbicacionFisicaEmpleadoList
        sleUbicacionFisica.Properties.DisplayMember = "UBICACIONFISICA"
        sleUbicacionFisica.Properties.ValueMember = "CODIGOUBICACIONFISICA"
        sleUbicacionFisica.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarRegimenFiscalizable()
        ControlesDevExpress.InitGridViewColumn(GridViewRegimenFiscalizable, "ID", "CODIGOFISCALIZABLEADRYAN", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewRegimenFiscalizable, "Ind. Fiscalizable/no Fiscalizable", "DESCRIPCION", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewRegimenFiscalizable
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        sleRegimenFiscalizable.Properties.DataSource = BDAccionPersonalDAO.GetFiscalizableEmpleadoList
        sleRegimenFiscalizable.Properties.DisplayMember = "DESCRIPCION"
        sleRegimenFiscalizable.Properties.ValueMember = "CODIGOFISCALIZABLEADRYAN"
        sleRegimenFiscalizable.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarTipoRemuneracion()
        ControlesDevExpress.InitGridViewColumn(GridViewTipoRemuneracion, "ID", "CODIGOREMUNERACIONADRYAN", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewTipoRemuneracion, "TIPO REMUNERACION", "DESCRIPCION", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewTipoRemuneracion
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        sleRegimenTipoRemuneracion.Properties.DataSource = BDAccionPersonalDAO.GetTipoRemuneracionEmpleadoList
        sleRegimenTipoRemuneracion.Properties.DisplayMember = "DESCRIPCION"
        sleRegimenTipoRemuneracion.Properties.ValueMember = "CODIGOREMUNERACIONADRYAN"
        sleRegimenTipoRemuneracion.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarEsquemaVacacional()
        ControlesDevExpress.InitGridViewColumn(GridViewEsquemaVacacional, "ID", "CODIGOESQUEMAVACACIONALADRYAN", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewEsquemaVacacional, "ESQUEMA VACACIONAL", "DESCRIPCION", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewEsquemaVacacional
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        sleEsquemaVacacional.Properties.DataSource = BDAccionPersonalDAO.GetEsquemaVacacionalEmpleadoList
        sleEsquemaVacacional.Properties.DisplayMember = "DESCRIPCION"
        sleEsquemaVacacional.Properties.ValueMember = "CODIGOESQUEMAVACACIONALADRYAN"
        sleEsquemaVacacional.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarDireccionConfianza()
        ControlesDevExpress.InitGridViewColumn(GridViewDireccionConfianza, "ID", "CODIGODIRECCIONCONFIANZAADRYAN", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewDireccionConfianza, "DIRECCIÓN CONFIANZA", "DESCRIPCION", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewDireccionConfianza
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        sleDireccionConfianza.Properties.DataSource = BDAccionPersonalDAO.GetDireccionConfianzaEmpleadoList
        sleDireccionConfianza.Properties.DisplayMember = "DESCRIPCION"
        sleDireccionConfianza.Properties.ValueMember = "CODIGODIRECCIONCONFIANZAADRYAN"
        sleDireccionConfianza.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarInscritoPorcentajeFondosPencionesAfp()
        ControlesDevExpress.InitGridViewColumn(GridViewIncritoAfp, "ID", "CODIGOFONDOPENSIONESADRYAN", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewIncritoAfp, "FONDOS PENSIONES", "DESCRIPCION", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewIncritoAfp
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        sleIncritoAfp.Properties.DataSource = BDAccionPersonalDAO.GetTipoFondoPensionesAfpEmpleadoList
        sleIncritoAfp.Properties.DisplayMember = "DESCRIPCION"
        sleIncritoAfp.Properties.ValueMember = "CODIGOFONDOPENSIONESADRYAN"
        sleIncritoAfp.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarTipoAfp()
        ControlesDevExpress.InitGridViewColumn(GridViewTipoAfp, "ID", "CODIGOAFPADRYAN", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewTipoAfp, "TIPO AFP", "DESCRIPCION", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewTipoAfp
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        sleTipoAfp.Properties.DataSource = BDAccionPersonalDAO.GetTipoAfpEmpleadoList
        sleTipoAfp.Properties.DisplayMember = "DESCRIPCION"
        sleTipoAfp.Properties.ValueMember = "CODIGOAFPADRYAN"
        sleTipoAfp.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarTipoTrabajadorSunat()
        ControlesDevExpress.InitGridViewColumn(GridViewTipoTrabajadorSunat, "ID", "CODIGOTRABAJADORSUNATADRYAN", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewTipoTrabajadorSunat, "TIPO AFP", "DESCRIPCION", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewTipoTrabajadorSunat
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        sleTipoTrabajadorSunat.Properties.DataSource = BDAccionPersonalDAO.GetTipoTrabajadorSunatEmpleadoList
        sleTipoTrabajadorSunat.Properties.DisplayMember = "DESCRIPCION"
        sleTipoTrabajadorSunat.Properties.ValueMember = "CODIGOTRABAJADORSUNATADRYAN"
        sleTipoTrabajadorSunat.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarBancoProCts()
        ControlesDevExpress.InitGridViewColumn(GridViewBancoPro, "ID", "CODIGO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewBancoPro, "BANCO", "NOMBRE", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewBancoPro
            .Columns("NOMBRE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        sleBancoPro.Properties.DataSource = BDAccionPersonalDAO.GetBancoCtsList
        sleBancoPro.Properties.DisplayMember = "NOMBRE"
        sleBancoPro.Properties.ValueMember = "CODIGO"
        sleBancoPro.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarBancoEnvioCts()
        ControlesDevExpress.InitGridViewColumn(GridViewBancoEnvio, "ID", "CODIGO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewBancoEnvio, "BANCO", "NOMBRE", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewBancoEnvio
            .Columns("NOMBRE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        sleBancoEnvio.Properties.DataSource = BDAccionPersonalDAO.GetBancoCtsList
        sleBancoEnvio.Properties.DisplayMember = "NOMBRE"
        sleBancoEnvio.Properties.ValueMember = "CODIGO"
        sleBancoEnvio.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarMonedaCts()
        ControlesDevExpress.InitGridViewColumn(GridViewMonedaCts, "ID", "CODIGO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewMonedaCts, "MONEDA", "DESCRIPCION", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewMonedaCts
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        sleMonedaCts.Properties.DataSource = BDAccionPersonalDAO.GetMonedaList
        sleMonedaCts.Properties.DisplayMember = "DESCRIPCION"
        sleMonedaCts.Properties.ValueMember = "CODIGO"
        sleMonedaCts.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    '---------------------
    Private Sub CargarBancoPlanilla()
        ControlesDevExpress.InitGridViewColumn(GridViewBancoPlanilla, "ID", "IDBANCO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewBancoPlanilla, "BANCO", "NOMBRE", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewBancoPlanilla
            .Columns("NOMBRE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        sleBancoPlanilla.Properties.DataSource = BDAccionPersonalDAO.GetBancoCtsList
        sleBancoPlanilla.Properties.DisplayMember = "NOMBRE"
        sleBancoPlanilla.Properties.ValueMember = "IDBANCO"
        sleBancoPlanilla.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarTipoCuentaAbono()
        ControlesDevExpress.InitGridViewColumn(GridViewTipoCuentaAbono, "ID", "IDTIPOCUENTAABONO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewTipoCuentaAbono, "TIPO CUENTA", "DESCRIPCION", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewTipoCuentaAbono
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        sleTipoCuenta.Properties.DataSource = BDAccionPersonalDAO.GetTipoCuentaAbonoList
        sleTipoCuenta.Properties.DisplayMember = "DESCRIPCION"
        sleTipoCuenta.Properties.ValueMember = "IDTIPOCUENTAABONO"
        sleTipoCuenta.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub CargarFormaPago()
        ControlesDevExpress.InitGridViewColumn(GridViewFormaPago, "ID", "IDFORMAPAGO", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewFormaPago, "FORMA PAGO", "DESCRIPCION", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        With GridViewFormaPago
            .Columns("DESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        sleFormaPago.Properties.DataSource = BDAccionPersonalDAO.GetFormaPagoList
        sleFormaPago.Properties.DisplayMember = "DESCRIPCION"
        sleFormaPago.Properties.ValueMember = "IDFORMAPAGO"
        sleFormaPago.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub LoadEntidad()
        If CambioLocalDefinitivoDAO.IdEmpleado <> 0 Then
            EmpleadoBE = BDAccionPersonalDAO.GetByEmpleadoID(CambioLocalDefinitivoDAO.IdEmpleado)

            With EmpleadoBE
                txtCodigoUnico.Text = .CODIGOUNICO
                txtIdEmpleado.Text = .IDEMPLEADO
                txtNombres.Text = .NOMBRES
                txtApellidoPaterno.Text = .APELLIDOPATERNO
                txtApellidoMaterno.Text = .APELLIDOMATERNO
                sleTipoIdentidad.EditValue = .IDTIPOIDENTIDAD
                txtNumeroIdentidad.Text = .DNI
                deFechaNacimiento.EditValue = .FECHANACIMIENTO
                sleDistrito.EditValue = .IDUBIGEO
                sleSexo.EditValue = .IDSEXO
                sleEstadoCivil.EditValue = .IDESTADOCIVIL
                sleNacionalidad.EditValue = .NACIONALIDAD
                slePais.EditValue = .PAIS
                txtTelefonoPersonal.Text = .TELEFONOPERSONAL
                txtCorreoPersonal.Text = .CORREOPERSONAL
                txtDireccion.Text = .DIRECCION

                sleCargo.EditValue = .IDCARGO
                sleLocal.EditValue = .IDORGANIGRAMA
                sleTipoContrato.EditValue = .TIPOCONTRATO
                deFechaIngresoCompania.Text = .FECHAINGRESOCOMPANIA
                deFechaIngresoCoorporacion.Text = .FECHAINGRESOCORPORACION
                deFechaFinContrato.Text = .FECHAFINALCONTRATO
                txtSueldo.Text = .SUELDO
                sleMoneda.EditValue = .SUELDOMONEDA
                sleRegimenSalarial.EditValue = .IDREGIMENSALARIAL
                sleTipoEmpleado.EditValue = .CODIGOTIPOEMPLEADO
                sleCategoriaEmpleado.EditValue = .CODIGOCATEGORIA
                sleUbicacionFisica.EditValue = .CODIGOUBICACIONFISICA
                txtEstado.Text = .ESTADO
                txtNumeroCuentaAbono.Text = .NUMEROCUENTAABONO
                sleTipoCuenta.EditValue = .IDTIPOCUENTAABONO
                sleFormaPago.EditValue = .IDFORMAPAGO
                sleBancoPlanilla.EditValue = .IDBANCOABONO
                If datosGrida = 1 Then
                    txtTipoEmpleado.Text = .TIPOEMPLEADO
                Else
                    txtTipoEmpleado.Text = "NUEVO"
                End If

                sleRegimenFiscalizable.EditValue = .ADRYAN_FISCALIZABLE
                sleRegimenTipoRemuneracion.EditValue = .ADRYAN_TIPOREMUNERACION
                sleEsquemaVacacional.EditValue = .ADRYAN_ESQUEMAVACACIONAL
                sleDireccionConfianza.EditValue = .ADRYAN_DIRECCIONCONFIANZA
                sleIncritoAfp.EditValue = .ADRYAN_TIPOFONDOPENSIONES
                sleTipoAfp.EditValue = .ADRYAN_TIPOAFP
                txtCodigoSpp.Text = .ADRYAN_CODIGOSPP
                dtFechaIngresoAfp.EditValue = .ADRYAN_FECHAINGRESOAFP
                If .ADRYAN_COMISIONMIXTA = "1" Then
                    RboComisionMixtaSi.Checked = True
                    RboComisionMixtaNo.Checked = False
                Else
                    RboComisionMixtaSi.Checked = False
                    RboComisionMixtaNo.Checked = True
                End If

                sleTipoTrabajadorSunat.EditValue = .ADRYAN_TIPOTRABAJADORSUNAT
                sleBancoPro.EditValue = .ADRYAN_INSTITUCIONFINANCIERACTS
                sleBancoEnvio.EditValue = .ADRYAN_INSTITUCIONFINANCIERAENVIOCTS
                txtNumeroCuentaCts.Text = .ADRYAN_NUMEROCUENTACTS
                sleMonedaCts.EditValue = .ADRYAN_TIPO_CUENTACTS

                'Cargar datos en Datos Reingreso-Contrato
                sleLocalReingreso.EditValue = .IDORGANIGRAMA
                sleCargoReingreso.EditValue = .IDCARGO
                sleRegimenSalarialReingreso.EditValue = .IDREGIMENSALARIAL
                sleTipoEmpleadoReingreso.EditValue = .CODIGOTIPOEMPLEADO
                txtSueldoReingreso.Text = .SUELDO
                sleMonedaReingreso.EditValue = .SUELDOMONEDA
                sleTipoContratoReingreso.EditValue = .TIPOCONTRATO
                If .ADRYAN_COMISIONMIXTA = "1" Then
                    RboComisionMixtaSi.Checked = True
                    RboComisionMixtaNo.Checked = False
                Else
                    RboComisionMixtaSi.Checked = False
                    RboComisionMixtaNo.Checked = True
                End If
                deFechaReingreso.Text = .FECHAINGRESOCOMPANIA
                deFechaFinContratoReingreso.Text = .FECHAFINALCONTRATO
                If txtTipoEmpleado.Text = "NUEVO" Then
                    XtraTabControl1.Visible = True
                    XtraTabDatosReingreso.PageVisible = False
                    XtraTabPageDatosLaborales.PageVisible = True
                    XtraTabPageAfpCtsEssalud.PageVisible = True
                Else
                    XtraTabControl1.Visible = True
                    XtraTabPageDatosLaborales.PageVisible = False
                    XtraTabDatosReingreso.PageVisible = True
                    XtraTabPageAfpCtsEssalud.PageVisible = False
                    txtSueldoReingreso.Text = 0
                End If
            End With

            'If datosGrida = 1 Then
            'If EmpleadoBE.TIPOEMPLEADO = "NUEVO" Then
            '    XtraTabControl1.Visible = True
            '    XtraTabDatosReingreso.PageVisible = False
            '    XtraTabPageDatosLaborales.PageVisible = True
            '    XtraTabPageAfpCtsEssalud.PageVisible = True
            'Else
            '    XtraTabControl1.Visible = True
            '    XtraTabPageDatosLaborales.PageVisible = False
            '    XtraTabDatosReingreso.PageVisible = True
            '    XtraTabPageAfpCtsEssalud.PageVisible = False
            'End If
            'End If

            If BDAccionPersonalDAO.flatCargaTipoEmpleado = 1 Then
                sleBancoPro.Enabled = True
                sleBancoEnvio.Enabled = True
                txtNumeroCuentaCts.Enabled = True
                sleMonedaCts.Enabled = True
            End If
            If BDAccionPersonalDAO.flatCargaTipoEmpleado = 2 Then

            End If
        End If
    End Sub
    Private Function Validar() As Boolean
        Dim Result As Boolean = True

        DxErrorProvider1.ClearErrors()

        If Convert.ToDateTime(deFechaIngresoCompania.EditValue) >= Convert.ToDateTime(deFechaFinContrato.EditValue) Then
            MessageBox.Show("La fecha final de contrato no debe ser menor o igual a la fecha de ingreso a la compañia", "ADvertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Result = False
        End If
        If Convert.ToDateTime(deFechaIngresoCoorporacion.EditValue) > Convert.ToDateTime(deFechaIngresoCompania.EditValue) Then
            MessageBox.Show("La fecha de ingreso corporativo no debe ser mayor al de la fecha ingreso compañia", "ADvertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Result = False
        End If
        If txtNombres.Text = "" Then
            DxErrorProvider1.SetError(txtNombres, "Dato obligatorio")
            Result = False
        End If
        If txtApellidoPaterno.Text = "" Then
            DxErrorProvider1.SetError(txtApellidoPaterno, "Dato obligatorio")
            Result = False
        End If
        If txtApellidoMaterno.Text = "" Then
            DxErrorProvider1.SetError(txtApellidoMaterno, "Dato obligatorio")
            Result = False
        End If
        If sleTipoIdentidad.EditValue Is Nothing Then
            DxErrorProvider1.SetError(sleTipoIdentidad, "Dato obligatorio")
            Result = False
        End If
        If sleRegimenTipoRemuneracion.EditValue Is Nothing Then
            DxErrorProvider1.SetError(sleRegimenTipoRemuneracion, "Dato obligatorio")
            Result = False
        End If
        If sleDistrito.EditValue Is Nothing Or sleDistrito.EditValue = 0 Then
            DxErrorProvider1.SetError(sleDistrito, "Dato obligatorio")
            Result = False
        End If
        If txtDireccion.Text = "" Then
            DxErrorProvider1.SetError(txtDireccion, "Dato obligatorio")
            Result = False
        End If
        If txtNumeroIdentidad.Text = "" Then
            DxErrorProvider1.SetError(txtNumeroIdentidad, "Dato obligatorio")
            Result = False
        End If
        If deFechaNacimiento.EditValue Is Nothing Or deFechaNacimiento.Text = "01/01/1900" Then
            DxErrorProvider1.SetError(deFechaNacimiento, "Dato obligatorio")
            Result = False
        End If
        If sleSexo.EditValue Is Nothing Or sleSexo.EditValue = 0 Then
            DxErrorProvider1.SetError(sleSexo, "Dato obligatorio")
            Result = False
        End If
        If sleEstadoCivil.EditValue Is Nothing Or sleEstadoCivil.EditValue = 0 Then
            DxErrorProvider1.SetError(sleEstadoCivil, "Dato obligatorio")
            Result = False
        End If
        If slePais.EditValue Is Nothing Or slePais.EditValue = "" Then
            DxErrorProvider1.SetError(slePais, "Dato obligatorio")
            Result = False
        End If
        If sleNacionalidad.EditValue Is Nothing Or sleNacionalidad.EditValue = "" Then
            DxErrorProvider1.SetError(sleNacionalidad, "Dato obligatorio")
            Result = False
        End If

        If sleLocal.EditValue Is Nothing Or sleLocal.EditValue = 0 Then
            DxErrorProvider1.SetError(sleLocal, "Dato obligatorio")
            Result = False
        End If
        If sleCargo.EditValue Is Nothing Then
            DxErrorProvider1.SetError(sleCargo, "Dato obligatorio")
            Result = False
        End If
        If sleUbicacionFisica.EditValue Is Nothing Or sleUbicacionFisica.EditValue = "" Then
            DxErrorProvider1.SetError(sleUbicacionFisica, "Dato obligatorio")
            Result = False
        End If
        If sleTipoEmpleado.EditValue Is Nothing Or sleTipoEmpleado.EditValue = "" Then
            DxErrorProvider1.SetError(sleTipoEmpleado, "Dato obligatorio")
            Result = False
        End If
        If sleCategoriaEmpleado.EditValue Is Nothing Or sleCategoriaEmpleado.EditValue = "" Then
            DxErrorProvider1.SetError(sleCategoriaEmpleado, "Dato obligatorio")
            Result = False
        End If
        If sleTipoContrato.EditValue Is Nothing Then
            DxErrorProvider1.SetError(sleTipoContrato, "Dato obligatorio")
            Result = False
        End If
        If deFechaIngresoCompania.EditValue Is Nothing Or deFechaIngresoCompania.Text = "01/01/1900" Then
            DxErrorProvider1.SetError(deFechaIngresoCompania, "Dato obligatorio")
            Result = False
        End If
        If deFechaIngresoCoorporacion.EditValue Is Nothing Or deFechaIngresoCoorporacion.Text = "01/01/1900" Then
            DxErrorProvider1.SetError(deFechaIngresoCoorporacion, "Dato obligatorio")
            Result = False
        End If
        If deFechaFinContrato.EditValue Is Nothing Or deFechaFinContrato.Text = "01/01/1900" Then
            DxErrorProvider1.SetError(deFechaFinContrato, "Dato obligatorio")
            Result = False
        End If
        If txtSueldo.Text = "0.00" Or txtSueldo.Text = "" Then
            DxErrorProvider1.SetError(txtSueldo, "Dato obligatorio")
            Result = False
        End If
        If sleMoneda.EditValue Is Nothing Or sleMoneda.EditValue = "" Then
            DxErrorProvider1.SetError(sleMoneda, "Dato obligatorio")
            Result = False
        End If
        If sleRegimenSalarial.EditValue Is Nothing Or sleRegimenSalarial.EditValue = 0 Then
            DxErrorProvider1.SetError(sleRegimenSalarial, "Dato obligatorio")
            Result = False
        End If
        If sleRegimenFiscalizable.EditValue Is Nothing Or sleRegimenFiscalizable.EditValue = "" Then
            DxErrorProvider1.SetError(sleRegimenFiscalizable, "Dato obligatorio")
            Result = False
        End If
        If sleRegimenTipoRemuneracion.EditValue Is Nothing Or sleRegimenTipoRemuneracion.EditValue = "" Then
            DxErrorProvider1.SetError(sleRegimenTipoRemuneracion, "Dato obligatorio")
            Result = False
        End If
        If sleDireccionConfianza.EditValue Is Nothing Or sleDireccionConfianza.EditValue = "" Then
            DxErrorProvider1.SetError(sleDireccionConfianza, "Dato obligatorio")
            Result = False
        End If
        If sleIncritoAfp.EditValue Is Nothing Or sleIncritoAfp.EditValue = "" Then
            DxErrorProvider1.SetError(sleIncritoAfp, "Dato obligatorio")
            Result = False
        End If
        If RboComisionMixtaSi.Checked = False And RboComisionMixtaNo.Checked = False Then
            MessageBox.Show("Debe seleccionar la comisión mixta")
            Return False
        End If
        If sleTipoTrabajadorSunat.EditValue Is Nothing Or sleTipoTrabajadorSunat.EditValue = "" Then
            DxErrorProvider1.SetError(sleTipoTrabajadorSunat, "Dato obligatorio")
            Result = False
        End If

        If sleRegimenFiscalizable.EditValue Is Nothing Or sleRegimenFiscalizable.EditValue = "" Then
            DxErrorProvider1.SetError(sleRegimenFiscalizable, "Dato obligatorio")
            Result = False
        End If
        If sleTipoContrato.EditValue Is Nothing Or sleTipoContrato.EditValue = "" Then
            DxErrorProvider1.SetError(sleTipoContrato, "Dato obligatorio")
            Result = False
        End If
        If sleEsquemaVacacional.EditValue Is Nothing Or sleEsquemaVacacional.EditValue = "" Then
            DxErrorProvider1.SetError(sleEsquemaVacacional, "Dato obligatorio")
            Result = False
        End If
        Dim dtrenovacion As DataTable
        dtrenovacion = BDAccionPersonalDAO.GetEmpleadoAsignadoEnRenovacion(txtIdEmpleado.Text)
        If dtrenovacion.Rows.Count > 0 Then
            MessageBox.Show("El colaborador " & dtrenovacion.Rows(0).Item("EMPLEADONOMBRE") & " se encuentra en el listado de renovaciòn de contrado con fecha" & dtrenovacion.Rows(0).Item("FECHAFINALCONTRATO") & ", por favor eliminar su renovaciòn para poder proceder con el Cambio Definitivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Result = False
        End If

        If Result Then
            Dim dtEmpleadoAdryan As New DataTable
            dtEmpleadoAdryan = BDAccionPersonalDAO.GetEmpleadoCargarDatosAdicionales(sleTipoIdentidad.EditValue, sleCargo.EditValue, sleLocal.EditValue, sleDistrito.EditValue)

            Dim dtEmpleadoAdryanIns As New DataTable
            dtEmpleadoAdryanIns = BDAccionPersonalDAO.GetEmpleadoCargarDatosAdicionalesParaInsert(sleRegimenTipoRemuneracion.EditValue, sleRegimenFiscalizable.EditValue, sleDireccionConfianza.EditValue, sleEsquemaVacacional.EditValue, sleIncritoAfp.EditValue, sleTipoAfp.EditValue, sleTipoTrabajadorSunat.EditValue, sleMonedaCts.EditValue, sleBancoPro.EditValue, sleBancoEnvio.EditValue, sleBancoPlanilla.EditValue, sleTipoCuenta.EditValue)

            With EmpleadoBE
                .IDEMPLEADO = txtIdEmpleado.Text
                .NOMBRES = txtNombres.Text
                .APELLIDOPATERNO = txtApellidoPaterno.Text
                .APELLIDOMATERNO = txtApellidoMaterno.Text
                .IDTIPOIDENTIDAD = sleTipoIdentidad.EditValue
                .DNI = txtNumeroIdentidad.Text
                .FECHANACIMIENTO = deFechaNacimiento.Text
                .IDUBIGEO = sleDistrito.EditValue
                .DIRECCION = txtDireccion.Text
                .IDSEXO = sleSexo.EditValue
                .IDORGANIGRAMA = sleLocal.EditValue
                .IDCARGO = sleCargo.EditValue
                .CODIGOUBICACIONFISICA = sleUbicacionFisica.EditValue
                .TIPOCONTRATO = sleTipoContrato.EditValue
                .FECHAINGRESOCOMPANIA = deFechaIngresoCompania.Text
                .FECHAINGRESOCORPORACION = deFechaIngresoCoorporacion.Text
                .SUELDO = Convert.ToDouble(txtSueldo.Text)
                .IDESTADOCIVIL = sleEstadoCivil.EditValue
                .TELEFONOPERSONAL = txtTelefonoPersonal.Text
                .CORREOPERSONAL = txtCorreoPersonal.Text
                .PAIS = slePais.EditValue
                .NACIONALIDAD = sleNacionalidad.EditValue
                .FECHAFINALCONTRATO = deFechaFinContrato.Text
                .SUELDOMONEDA = sleMoneda.EditValue
                .IDREGIMENSALARIAL = sleRegimenSalarial.EditValue
                .NUMEROCUENTAABONO = txtNumeroCuentaAbono.Text


                If sleBancoPlanilla.EditValue Is Nothing Then
                    .IDBANCOABONO = 0
                Else
                    .IDBANCOABONO = sleBancoPlanilla.EditValue
                End If
                If sleFormaPago.EditValue Is Nothing Then
                    .IDFORMAPAGO = 0
                Else
                    .IDFORMAPAGO = sleFormaPago.EditValue
                End If

                If sleTipoCuenta.EditValue Is Nothing Then
                    .IDTIPOCUENTAABONO = ""
                Else
                    .IDTIPOCUENTAABONO = sleTipoCuenta.EditValue
                End If

                If txtNumeroCuentaAbono.Text <> "" Then
                    .NUMEROCUENTAABONO = txtNumeroCuentaAbono.Text
                Else
                    .NUMEROCUENTAABONO = ""
                End If
                .CODIGOTIPOEMPLEADO = sleTipoEmpleado.EditValue
                .CODIGOCATEGORIA = sleCategoriaEmpleado.EditValue

                If txtCodigoSpp.Text <> "" Then
                    .ADRYAN_CODIGOSPP = txtCodigoSpp.Text
                Else
                    .ADRYAN_CODIGOSPP = ""
                End If
                Dim FECHAIGRESOAFP As DateTime

                FECHAIGRESOAFP = dtFechaIngresoAfp.EditValue

                If dtFechaIngresoAfp.EditValue = Nothing Or FECHAIGRESOAFP = "1900-01-01" Then
                    .ADRYAN_FECHAINGRESOAFP = "1900-01-01"
                Else
                    .ADRYAN_FECHAINGRESOAFP = dtFechaIngresoAfp.EditValue
                End If

                .ADRYAN_NUMEROCUENTACTS = txtNumeroCuentaCts.Text

                If RboComisionMixtaSi.Checked Then
                    .ADRYAN_COMISIONMIXTA = "1"
                End If
                If RboComisionMixtaNo.Checked Then
                    .ADRYAN_COMISIONMIXTA = "0"
                End If

                .ADRYAN_TIPOIDENTIDAD = dtEmpleadoAdryan.Rows(0)("TIPODOCUMENTO")
                .ADRYAN_PUESTO_ORGANICA = dtEmpleadoAdryan.Rows(0)("PUESTOORGANICA")
                .ADRYAN_UNIDAD_FUNCIONAL = dtEmpleadoAdryan.Rows(0)("UNIDADFUNCIONAL")
                .ADRYAN_DISTRITO = dtEmpleadoAdryan.Rows(0)("DISTRITO")
                .ADRYAN_PROVINCIA = dtEmpleadoAdryan.Rows(0)("PROVINCIA")
                .ADRYAN_DEPARTAMENTO = dtEmpleadoAdryan.Rows(0)("DEPARTAMENTO")
                .ADRYAN_GRADOSALARIAL = dtEmpleadoAdryan.Rows(0)("GRADOSALARIAL")

                .ADRYAN_TIPOREMUNERACION = dtEmpleadoAdryanIns.Rows(0)("TIPOREMUNERACION")
                .ADRYAN_FISCALIZABLE = dtEmpleadoAdryanIns.Rows(0)("FISCALIZABLE")
                .ADRYAN_DIRECCIONCONFIANZA = dtEmpleadoAdryanIns.Rows(0)("DIRECCIONCONFIANZA")
                .ADRYAN_ESQUEMAVACACIONAL = dtEmpleadoAdryanIns.Rows(0)("ESQUEMAVACACIONAL")
                .ADRYAN_TIPOFONDOPENSIONES = dtEmpleadoAdryanIns.Rows(0)("TIPOFONDOPENSIONES")
                .ADRYAN_TIPOTRABAJADORSUNAT = dtEmpleadoAdryanIns.Rows(0)("TIPOTRABAJADORSUNAT")


                .ADRYAN_BANCOABONO = dtEmpleadoAdryanIns.Rows(0)("BANCOABONOADRYAN")
                .ADRYAN_TIPOCUENTAABONO = dtEmpleadoAdryanIns.Rows(0)("TIPOCUENTAABONOADRYAN")

                If dtEmpleadoAdryanIns.Rows(0)("TIPOCUENTACTS") <> "" Then
                    .ADRYAN_TIPO_CUENTACTS = dtEmpleadoAdryanIns.Rows(0)("TIPOCUENTACTS")
                Else
                    .ADRYAN_TIPO_CUENTACTS = ""
                End If
                If dtEmpleadoAdryanIns.Rows(0)("INSTITUCIONFINANCIERACTS") <> "" Then
                    .ADRYAN_INSTITUCIONFINANCIERACTS = dtEmpleadoAdryanIns.Rows(0)("INSTITUCIONFINANCIERACTS")
                Else
                    .ADRYAN_INSTITUCIONFINANCIERACTS = ""
                End If
                If dtEmpleadoAdryanIns.Rows(0)("INSTITUCIONFINANCIERAENVIOCTS") <> "" Then
                    .ADRYAN_INSTITUCIONFINANCIERAENVIOCTS = dtEmpleadoAdryanIns.Rows(0)("INSTITUCIONFINANCIERAENVIOCTS")
                Else
                    .ADRYAN_INSTITUCIONFINANCIERAENVIOCTS = ""
                End If


                If dtEmpleadoAdryanIns.Rows(0)("TIPOAFP") <> "" Then
                    .ADRYAN_TIPOAFP = dtEmpleadoAdryanIns.Rows(0)("TIPOAFP")
                Else
                    .ADRYAN_TIPOAFP = ""
                End If

                .IDUSUARIOREGISTRO = BDCentralDAO.UsuarioBE.IDUsuario
                .USUARIOREGISTRO = BDCentralDAO.UsuarioBE.Usuario
                'Dim dt As DataTable
                'dt = BDAccionPersonalDAO.GetGradoSalarialList(sleCargo.EditValue)
                '.ADRYAN_GRADOSALARIAL = dt.Rows(0)(0)

            End With

        End If
        Return Result
    End Function
    Private Sub btnSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub
    Private Sub txtSueldo_Click(sender As Object, e As EventArgs) Handles txtSueldo.Click
        txtSueldo.SelectAll()
    End Sub
    Private Sub btnRegistrarIngreso_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRegistrarIngreso.ItemClick
        Dim xUltimoNumeroContrato As String = ""
        If CambioLocalDefinitivoDAO.IdEmpleado = 0 Then
            Exit Sub
        End If
        If Me.Validar Then
            Dim ResulCentral As DataTable
            Dim ResulAdryan As DataTable
            Dim activosCentral As Int32
            Dim activosAdryan As Int32
            Dim localantiguo As Integer
            ResulCentral = BDAccionPersonalDAO.GetEmpleadoActivoMccentral(txtNumeroIdentidad.Text)
            ResulAdryan = BDAccionPersonalDAO.GetEmpleadoActivoAdryan(txtNumeroIdentidad.Text)
            activosCentral = ResulCentral.Rows(0)(0)
            localantiguo = ResulCentral.Rows(0)(1)
            activosAdryan = ResulAdryan.Rows(0)(0)
            If txtFlat.Text = 0 Then  '0=Cambio de Razon Social
                If localantiguo <> sleLocal.EditValue Then

                    If activosCentral = 0 And activosAdryan = 0 Then

                        Dim ValidacionDni As String = BDAccionPersonalDAO.ObternerExistenciaDni(Convert.ToString(EmpleadoBE.IDEMPLEADO), Trim(txtNumeroIdentidad.Text))
                        If ValidacionDni = 0 Then


                            If MessageBox.Show("Desea registrar al personal?", "Registrar Personal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                xUltimoNumeroContrato = RenovacionContratoDAO.GetObtenerUltimoContrato()
                                If xUltimoNumeroContrato = "" Then
                                    MessageBox.Show("Problemas de Conexión", "Error de Conexión")
                                    Cursor = Cursors.Default
                                    Exit Sub
                                End If
                                'INSERTA EMPLEADO ADRYAN
                                If BDAccionPersonalDAO.InsertaEmpleadoAdryan(EmpleadoBE, xUltimoNumeroContrato) Then
                                    '   INSERTA MC_CENTRAL
                                    If Not BDAccionPersonalDAO.InsertaIngresoPersonalcambioRazon(EmpleadoBE, xUltimoNumeroContrato, BDCentralDAO.UsuarioBE.IDUsuario, CambioLocalDefinitivoDAO.IdCambioDefinitivo) Then
                                        'If Not BDAccionPersonalDAO.InsertaIngresoPersonalcambioRazon(EmpleadoBE, "0000021330", BDCentralDAO.UsuarioBE.IDUsuario, CambioLocalDefinitivoDAO.IdCambioDefinitivo) Then
                                        MessageBox.Show("Error al registrar al personal", "Error de Registro")
                                        Cursor = Cursors.Default
                                        Exit Sub
                                    Else
                                        'MCRH_CAMBIODEFINITIVO_APROBAR
                                        If CambioLocalDefinitivoDAO.AprobarCambioDefinitivoID(CambioLocalDefinitivoDAO.IdCambioDefinitivo, BDCentralDAO.UsuarioBE.IDUsuario, sleLocal.EditValue, deFechaIngresoCompania.EditValue) Then
                                            EMPLEADONOMBRE = EmpleadoBE.NOMBRES + " " + EmpleadoBE.APELLIDOPATERNO + " " + EmpleadoBE.APELLIDOMATERNO
                                            MessageBox.Show("El Ingreso del empleado " & EMPLEADONOMBRE & " fue exitoso", "Ingreso Empleado")
                                            Me.Close()
                                        End If

                                    End If
                                Else
                                    MessageBox.Show("Problemas de Conexión con el sistema Adryan", "Error de Conexión")
                                    Cursor = Cursors.Default
                                    Exit Sub
                                End If
                            End If
                        Else

                            MessageBox.Show("El número de documento ya se encuentra asignado a otro trabajador", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        MessageBox.Show("Para poder proceder con el cambio definitivo, el colaborador tiene que estar cesado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("Para poder proceder con el cambio definitivo,la razon social tiene que ser distintita a la actual", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else '1 =Cambio de tipo de contrato
                If activosCentral = 0 And activosAdryan = 0 Then
                    Dim ValidacionDni As String = BDAccionPersonalDAO.ObternerExistenciaDni(Convert.ToString(EmpleadoBE.IDEMPLEADO), Trim(txtNumeroIdentidad.Text))
                    If ValidacionDni = 0 Then
                        If MessageBox.Show("Desea registrar al personal?", "Registrar Personal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            xUltimoNumeroContrato = RenovacionContratoDAO.GetObtenerUltimoContrato()
                            If xUltimoNumeroContrato = "" Then
                                MessageBox.Show("Problemas de Conexión", "Error de Conexión")
                                Cursor = Cursors.Default
                                Exit Sub
                            End If
                            'INSERTA EMPLEADO ADRYAN
                            If BDAccionPersonalDAO.InsertaEmpleadoAdryan(EmpleadoBE, xUltimoNumeroContrato) Then
                                '   INSERTA MC_CENTRAL
                                If Not BDAccionPersonalDAO.InsertaIngresoPersonalcambioRazon(EmpleadoBE, xUltimoNumeroContrato, BDCentralDAO.UsuarioBE.IDUsuario, CambioLocalDefinitivoDAO.IdCambioDefinitivo) Then
                                    MessageBox.Show("Error al registrar al personal", "Error de Registro")
                                    Cursor = Cursors.Default
                                    Exit Sub
                                Else
                                    'MCRH_CAMBIODEFINITIVO_APROBAR
                                    If CambioLocalDefinitivoDAO.AprobarCambioDefinitivoID(CambioLocalDefinitivoDAO.IdCambioDefinitivo, BDCentralDAO.UsuarioBE.IDUsuario, sleLocal.EditValue, deFechaIngresoCompania.EditValue) Then
                                        EMPLEADONOMBRE = EmpleadoBE.NOMBRES + " " + EmpleadoBE.APELLIDOPATERNO + " " + EmpleadoBE.APELLIDOMATERNO
                                        MessageBox.Show("El Ingreso del empleado " & EMPLEADONOMBRE & " fue exitoso", "Ingreso Empleado")
                                        Me.Close()
                                    End If
                                End If
                            Else
                                MessageBox.Show("Problemas de Conexión con el sistema Adryan", "Error de Conexión")
                                Cursor = Cursors.Default
                                Exit Sub
                            End If
                        End If
                    Else
                        MessageBox.Show("l número de documento ya se encuentra asignado a otro trabajador", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                        MessageBox.Show("Para poder proceder con el cambio definitivo, el colaborador tiene que estar cesado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If

        End If
    End Sub

    Private Sub btnAnularSolicitud_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnularSolicitud.ItemClick
        If MessageBox.Show("¿Esta seguro de anular el cambio definitivo?", "Anular cambio definitivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            If CambioLocalDefinitivoDAO.AnularCambioDefinitivo(CambioLocalDefinitivoDAO.IdCambioDefinitivo, BDCentralDAO.UsuarioBE.IDUsuario) Then
                Me.Close()
            Else
                MessageBox.Show("Error al anular")
            End If
        End If
    End Sub
End Class