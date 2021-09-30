Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraTab
Imports MC.Data
Imports MC.Framework

Public Class EmpleadoHistorial

    Dim bsLicenciaConGoce As New BindingSource
    Dim bsFamilia As New BindingSource
    Dim bsCese As New BindingSource
    Dim bsRenuncia As New BindingSource
    Dim bsCambioDefinitivo As New BindingSource
    Dim bsCambioTemporal As New BindingSource
    Dim bsMemorandum As New BindingSource
    Dim bsMarcaciones As New BindingSource
    Dim bsPrestamos As New BindingSource
    Dim bsVacaciones As New BindingSource
    Dim bsLacatancia As New BindingSource
    Dim bsAsignaciónFamiliar As New BindingSource
    Dim bsIncidenteAccidente As New BindingSource
    Dim bsContratos As New BindingSource
    Dim bsCartaCorrectiva As New BindingSource
    Dim bsCapacitaciones As New BindingSource

    Dim EmpleadoBE As New EmpleadoBE


    Sub New()

        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = MEDesktop.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ' lICENCIAS
        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ID", "IDLICENCIA", 130, False, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° SOLICITUD", "NUMEROSOLICITUD", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO LICENCIA", "LICENCIATIPO", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON COMERCIAL", "RAZONCOMERCIAL", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° RUC", "IDTRIBUTARIO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA PERIODO INICIO", "FECHAPERIODOINICIO", 140, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA PERIODO FIN", "FECHAPERIODOFIN", 140, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DIAS", "CANTIDADDIAS", 100, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA INCORPORACIÓN", "FECHAINCORPORACION", 130, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DESCRIPCION LICENCIA", "LICENCIADESCRIPCION", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDLICENCIATIPO", "IDLICENCIATIPO", 300, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        ' FAMILIA
        ControlesDevExpress.InitGridControl(GridControl2)
        ControlesDevExpress.InitGridViewColumn(GridView2, "PARENTESCO", "TIPO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "NOMBRE", "NOMBRES", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "APELLIDO PATERNO", "APELLIDOPATERNO", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "APELLIDO MATERNO", "APELLIDOMATERNO", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "NACIMIENTO", "FECHANACIMIENTO", 80, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "EDAD", "EDAD", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "SEXO", "SEXO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)


        'CESE
        ControlesDevExpress.InitGridControl(GridControl3)
        ControlesDevExpress.InitGridViewColumn(GridView3, "ID", "IDSOLICITUDCESE", 100, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView3, "N° SOLICITUD", "NUMEROSOLICITUDCESE", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView3, "RAZON SOCIAL", "RAZONSOCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView3, "RAZON COMERCIAL", "RAZONCOMERCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView3, "N° RUC", "IDTRIBUTARIO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView3, "MOTIVO CESE", "MOTIVOCESE", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView3, "FECHA CESE", "FECHACESE", 150, True, ControlesDevExpress.eGridViewFormato.Fecha, False)

        ' RENUNCIAS
        ControlesDevExpress.InitGridControl(GridControl5)
        ControlesDevExpress.InitGridViewColumn(GridView5, "ID", "IDRENUNCIA", 100, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView5, "N° RENUNCIA", "NUMEROCARTA", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView5, "RAZON SOCIAL", "RAZONSOCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView5, "RAZON COMERCIAL", "RAZONCOMERCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView5, "N° RUC", "IDTRIBUTARIO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView5, "FECHA ULTIMA TRABAJO", "FECHAULTIMODIATRABAJO", 150, True, ControlesDevExpress.eGridViewFormato.Fecha, False)

        'CAMBIO DEFINITIVO
        ControlesDevExpress.InitGridControl(GridControl6)
        ControlesDevExpress.InitGridViewColumn(GridView6, "ID", "IDFORMATOCAMBIO", 100, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView6, "N° SOLICITUD", "NUMEROFORMATOCAMBIO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView6, "RAZON SOCIAL", "RAZONSOCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView6, "RAZON COMERCIAL", "RAZONCOMERCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView6, "N° RUC", "IDTRIBUTARIO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView6, "CARGO ANTIGUO", "CARGOANTIGUO", 280, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView6, "TIPO CONTRATO ANTIGUO", "TIPOCONTRATOANTIGUO", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView6, "RAZON SOCIAL NUEVA", "NUEVORAZONSOCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView6, "RAZON COMERCIAL NUEVA", "NUEVORAZONCOMERCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView6, "N° RUC LOCAL NUEVO", "NUEVOIDTRIBUTARIO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView6, "CARGO NUEVO", "CARGONUEVO", 280, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView6, "TIPO CONTRATO NUEVO", "TIPOCONTRATONUEVO", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        'CAMBIO TEMPORAL
        ControlesDevExpress.InitGridControl(GridControl7)
        ControlesDevExpress.InitGridViewColumn(GridView7, "ID", "IDEMPLEADOCAMBIOTEMPORAL", 100, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView7, "N° SOLICITUD", "NUMEROEMPLEADOCAMBIOTEMPORAL", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView7, "RAZON SOCIAL ORIGEN", "RAZONSOCIALORIGEN", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView7, "RAZON COMERCIAL ORIGEN", "RAZONCOMERCIALORIGEN", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView7, "N° RUC ORIGEN", "NUMERORUCORIGEN", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView7, "CARGO EMPLEADO", "CARGOEMPLEADO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView7, "RAZON SOCIAL DESTINO", "RAZONSOCIALDESTINO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView7, "RAZON COMERCIAL DESTINO", "RAZONCOMERCIALDESTINO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView7, "N° RUC DESTINO", "NUMERORUCDESTINO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView7, "FECHA DESDE", "FECHAINICIOCAMBIO", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView7, "FECHA HASTA", "FECHAFINCAMBIO", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView7, "MOTIVO", "MOTIVO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        'MEMORANDUM
        ControlesDevExpress.InitGridControl(GridControl8)
        ControlesDevExpress.InitGridViewColumn(GridView8, "ID", "IDMEMORANDUM", 100, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView8, "N° INFORME", "NUMEROINFORME", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView8, "RAZON SOCIAL", "RAZONSOCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView8, "RAZON COMERCIAL", "RAZONCOMERCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView8, "N° RUC", "IDTRIBUTARIO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView8, "FALTA COMETIDA", "FALTA", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView8, "SANCIÓN ASIGNADA", "SANCION", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView8, "DESCRIPCION MEMORANDUM", "DESCRIPCIONMEMORANDUMLOCAL", 350, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)


        'PRESTAMOS
        ControlesDevExpress.InitGridControl(GridControl9)
        ControlesDevExpress.InitGridViewColumn(GridView9, "ID", "IDPRESTAMO", 100, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView9, "N° SOLICITUD", "NUMEROSOLICITUD", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView9, "RAZON SOCIAL", "RAZONSOCIAL", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView9, "RAZON COMERCIAL", "RAZONCOMERCIAL", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView9, "N° RUC", "IDTRIBUTARIO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView9, "CARGO EMPLEADO", "CARGOEMPLEADO", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView9, "MOTIVO PRÉSTAMO", "MOTIVOPRESTAMO", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView9, "MONTO APROBADO", "MONTOAPROBADO", 115, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView9, "TIPO PAGO", "TIPOPAGO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView9, "MEDIO PAGO", "MEDIOPAGO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView9, "ESTADO DEPÓSITO", "ESTADODEPOSITO", 110, True, ControlesDevExpress.eGridViewFormato.Checked, False)
        ControlesDevExpress.InitGridViewColumn(GridView9, "BANCO", "BANCO", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView9, "FECHA DEPÓSITO", "FECHADEPOSITO", 110, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView9, "CÓDIGO DEPOSITO", "CODIGODEPOSITO", 115, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)


        'VACACIONES
        ControlesDevExpress.InitGridControl(GridControl10)
        ControlesDevExpress.InitGridViewColumn(GridView10, "ID", "IDVACACIONES", 100, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView10, "N° SOLICITUD", "NUMEROFORMATOVACACIONES", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView10, "RAZON SOCIAL", "RAZONSOCIAL", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView10, "RAZON COMERCIAL", "RAZONCOMERCIAL", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView10, "N° RUC", "IDTRIBUTARIO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView10, "CARGO EMPLEADO", "CARGOEMPLEADO", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView10, "FECHA DESDE", "FECHAINICIO", 180, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView10, "FECHA HASTA", "FECHAFIN", 110, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView10, "CANTIDAD DIAS", "TOTALDIAS", 110, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView10, "FECHA INCORPORACION", "FECHAINCORPORACION", 110, True, ControlesDevExpress.eGridViewFormato.Fecha, False)


        'LACTANCIA
        ControlesDevExpress.InitGridControl(GridControl11)
        ControlesDevExpress.InitGridViewColumn(GridView11, "ID. LACTANCIA", "IDLACTANCIA", 100, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView11, "N° SOLICITUD", "NUMEROSOLICITUD", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView11, "RAZON SOCIAL", "RAZONSOCIAL", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView11, "RAZON COMERCIAL", "RAZONCOMERCIAL", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView11, "N° RUC", "IDTRIBUTARIO", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView11, "FECHA DESDE", "FECHAINICIO", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView11, "FECHA HASTA", "FECHAFIN", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView11, "FECHA NACIMIENTO HIJO(A)", "FECHANACIMIENTOHIJO", 170, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView11, "CARGO EMPLEADO", "CARGOEMPLEADO", 170, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView11, "HORA BENEFICIO", "TURNO", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        'ASIGNACIÓN FAMILIAR
        ControlesDevExpress.InitGridControl(GridControl12)
        ControlesDevExpress.InitGridViewColumn(GridView12, "ID", "IDASIGNACIONFAMILIAR", 140, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView12, "N° SOLICITUD", "NUMEROSOLICITUD", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView12, "RAZON SOCIAL", "RAZONSOCIAL", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView12, "RAZON COMERCIAL", "RAZONCOMERCIAL", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView12, "N° RUC", "IDTRIBUTARIO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView12, "CARGO EMPLEADO", "CARGOEMPLEADO", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView12, "N° HIJOS", "NUMEROHIJOS", 100, True, ControlesDevExpress.eGridViewFormato.Numero, False)



        'INCIDENTE ACCIDENTE
        ControlesDevExpress.InitGridControl(GridControl13)
        ControlesDevExpress.InitGridViewColumn(GridView13, "ID. INCIDENTE ACCIDENTE", "IDINCIDENTEACCIDENTE", 140, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView13, "N° SOLICITUD", "NUMEROINCIDENTEACCIDENTE", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView13, "RAZON SOCIAL", "RAZONSOCIAL", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView13, "RAZON COMERCIAL", "RAZONCOMERCIAL", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView13, "FECHA INCIDENTE", "FECHAINCIDENTEACCIDENTE", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView13, "AREA OCRRENCIA", "AREAOCURRENCIA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView13, "HORA OCURRENCIA", "HORAOCURRENCIA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView13, "DESCRIPCIÓN SUCESO", "DECRIPCIONSUCESO", 400, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView13, "CARGO EMPLEADO", "CARGOEMPLEADO", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        'CONTRATOS
        ControlesDevExpress.InitGridControl(GridControl16)
        ControlesDevExpress.InitGridViewColumn(GridView16, "SECUENCIA CONTRATO", "SECUENCIACONTRATO", 140, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView16, "TIPO CONTRATO", "TIPOCONTRATO", 450, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView16, "FECHA INICIO", "FECHAINICIO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView16, "FECHA TERMINO", "FECHATERMINO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        'MARCACIONES
        ControlesDevExpress.InitGridControl(GridControl17)
        ControlesDevExpress.InitGridViewColumn(GridView17, "DIA DE SEMANA", "DIASEMANA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView17, "FECHA MARCACION", "FECHA", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView17, "INGRESO", "INGRESO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView17, "SALIDA", "SALIDA", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView17, "RAZON SOCIAL", "RAZONSOCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView17, "RAZON COMERCIAL", "RAZONCOMERCIAL", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView17, "PUESTO", "PUESTO", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        'CARTA CORRECTIVAS
        ControlesDevExpress.InitGridControl(GridControl4)
        ControlesDevExpress.InitGridViewColumn(GridView4, "ID", "IDCARTAINFORMATIVA", 100, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView4, "N° SOLICITUD", "NUMEROSOLICITUD", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView4, "TIPO CARTA", "TIPOCARTAINFORMATIVA", 220, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView4, "RAZON SOCIAL", "RAZONSOCIAL", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView4, "RAZON COMERCIAL", "RAZONCOMERCIAL", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView4, "CARGO EMPLEADO", "CARGOEMPLEADO", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView4, "FECHA REGISTRO", "FECHAREGISTRO", 180, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView4, "FECHA APROBADO", "FEHCAREVISADO", 110, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView4, "USUARIO APROBADO", "NOMBREUSUARIO", 110, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView4, "ADJUNTO", "ADJUNTO", 110, False, ControlesDevExpress.eGridViewFormato.Numero, False)

        'CAPACITACIONES
        ControlesDevExpress.InitGridControl(GridControl14)

        ControlesDevExpress.InitGridViewColumn(GridView14, "IDCAPACITACIONESCUELA", "IDCAPACITACIONESCUELA", 300, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView14, "NUMERO ESCUELA", "NUMEROESCUELA", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView14, "TIPO ESCUELA", "TIPOESCUELA", 400, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)


        EmpleadoBE = BDAccionPersonalDAO.GetByEmpleadoID(BDAccionPersonalDAO.IdEmpleado)

        With EmpleadoBE
            BarStaticItemEmpleado.Caption = "COLABORADOR: " + .NOMBRES + " " + .APELLIDOPATERNO + " " + .APELLIDOMATERNO
            txtIdEmpleado.Text = .CODIGOUNICO
            txtNombres.Text = .NOMBRES
            txtApellidoPaterno.Text = .APELLIDOPATERNO
            txtApellidoMaterno.Text = .APELLIDOMATERNO
            txtNumeroDocumento.Text = .DNI
            txtMatricula.Text = .MATRICULA
            txtCargo.Text = .CARGO
            txtSexo.Text = .SEXO
            txtTipoDocumento.Text = .TIPODOCUMENTO
            txtTipoContrato.Text = .TIPOCONTRATODESCRIPCION
            txtDireccion.Text = .DIRECCION
            txtRazonSocial.Text = .RAZONSOCIAL
            txtRazonComercial.Text = .RAZONCOMERCIAL
            txtFechaNacimiento.Text = .FECHANACIMIENTO
            txtFechaIngresoCorporativo.Text = .FECHAINGRESOCORPORACION
            txtfechaingresoCompania.Text = .FECHAINGRESOCOMPANIA
            txtEdad.Text = .EDAD
            txtEstadoCivil.Text = .ESTADOCIVIL
            txtFechaFinalContrato.Text = .FECHAFINALCONTRATO
            txtEsquemaVacacional.Text = .ESQUEMAVACACIONAL
            txtRegimenSalarial.Text = .REGIMENSALARIALDESCRIPCION
            txtCodigoAfp.Text = .CODIGOAFPDESCRIPCION
            txtCodigoSpp.Text = .ADRYAN_CODIGOSPP
            txtInscritoAfp.Text = .FONDODEPENCIONES
            txtTipoEmpleado.Text = .TIPOEMPLEADODESCRIPCION
            txtEstadoEmpleado.Text = .ESTADO
            txtMoneda.Text = .SUELDOMONEDA
            txtSueldo.Text = .SUELDO
            txtUbigeo.Text = .UBIGEO
            txtCategoria.Text = .CATEGORIA
            txtTipoRemuneracion.Text = .TIPOREMUNERACION
            txtDireccionConfianza.Text = .DIRECCIONCONFIANZA
            txtTrabajadorSunat.Text = .TRABAJADORSUNAT
            txtCodigoSpp.Text = .ADRYAN_CODIGOSPP
            txtFechaInscripcion.Text = .ADRYAN_FECHAINGRESOAFP
            txtInstitucionFinanciera.Text = .INSTITUCION_FINANCIERA_CTS
            txtBancoEnvio.Text = .INSTITUCION_FINANCIERA_ENVIO_CTS
            txtMonedaEnvio.Text = .MONEDA_CTS
            txtNumeroCuentaCts.Text = .ADRYAN_NUMEROCUENTACTS
            txtNumeroCuentaAbono.Text = .NUMEROCUENTAABONO
            txtBancoAbono.Text = .BANCOABONO
            txtTipoCuentaAbono.Text = .TIPOCUENTAABONO
            txtFormaPago.Text = .FORMAPAGOEMPLEADO
            txtTelefono.Text = .TELEFONOPERSONAL
            txtCorreo.Text = .CORREOPERSONAL
            Me.txtEstadoEmpleado.ForeColor = Color.Red
            If .ADRYAN_COMISIONMIXTA = 1 Then
                rbComisionMixtaSi.Checked = True
                rbComisionMixtaNo.Checked = False
            Else
                rbComisionMixtaNo.Checked = True
                rbComisionMixtaSi.Checked = False
            End If
        End With

        ListarLicencias()
        ListarRenuncia()
        ListarCese()
        ListarCambioDefinitivo()
        ListarCambioTemporal()
        ListarMemorandum()
        ListarPrestamos()
        ListarLactancia()
        ListarVacaciones()
        ListarAsignacionFamiliar()
        ListarIncidenteAccidente()
        ListarContratos()
        ListarFamilia()
        ListarCartaCorrectiva()
        ListarCapacitaciones()
        'ListarAsistencias()

    End Sub

    Private Sub ListarCapacitaciones()
        Try
            bsCapacitaciones.DataSource = BDAccionPersonalDAO.HistoricoEscuelaGetIdEmpleado(BDAccionPersonalDAO.IdEmpleado)
            Me.GridControl14.DataSource = bsCapacitaciones
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ListarFamilia()
        Try
            bsFamilia.DataSource = BDAccionPersonalDAO.GetEmpleadoHistorialFamilia(BDAccionPersonalDAO.IdEmpleado)
            Me.GridControl2.DataSource = bsFamilia
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ListarLicencias()
        Try
            'Licencia con Goce
            bsLicenciaConGoce.DataSource = BDAccionPersonalDAO.GetEmpleadoHistorialList(BDAccionPersonalDAO.IdEmpleado)
            Me.GridControl1.DataSource = bsLicenciaConGoce
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ListarContratos()
        Try
            'Licencia con Goce
            bsContratos.DataSource = BDAccionPersonalDAO.GetEmpleadoHistorialContratosList(BDAccionPersonalDAO.IdEmpleado)
            Me.GridControl16.DataSource = bsContratos
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ListarCese()
        Try
            bsCese.DataSource = BDAccionPersonalDAO.GetEmpleadoHistorialCese(BDAccionPersonalDAO.IdEmpleado)
            Me.GridControl3.DataSource = bsCese
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ListarRenuncia()
        Try
            bsRenuncia.DataSource = BDAccionPersonalDAO.GetEmpleadoHistorialRenuncia(BDAccionPersonalDAO.IdEmpleado)
            Me.GridControl5.DataSource = bsRenuncia
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertenca", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ListarCambioDefinitivo()
        Try
            bsCambioDefinitivo.DataSource = BDAccionPersonalDAO.GetEmpleadoHistorialCambioDefinitivo(BDAccionPersonalDAO.IdEmpleado)
            Me.GridControl6.DataSource = bsCambioDefinitivo
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ListarCambioTemporal()
        Try
            bsCambioTemporal.DataSource = BDAccionPersonalDAO.GetEmpleadoHistorialCambioTemporal(BDAccionPersonalDAO.IdEmpleado)
            Me.GridControl7.DataSource = bsCambioTemporal
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ListarMemorandum()
        Try
            bsMemorandum.DataSource = BDAccionPersonalDAO.GetEmpleadoHistorialMemorandum(BDAccionPersonalDAO.IdEmpleado)
            Me.GridControl8.DataSource = bsMemorandum
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ListarPrestamos()
        Try
            bsPrestamos.DataSource = BDAccionPersonalDAO.GetEmpleadoHistorialPrestamos(BDAccionPersonalDAO.IdEmpleado)
            Me.GridControl9.DataSource = bsPrestamos
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ListarVacaciones()
        Try
            bsVacaciones.DataSource = BDAccionPersonalDAO.GetEmpleadoHistorialVacaciones(BDAccionPersonalDAO.IdEmpleado)
            Me.GridControl10.DataSource = bsVacaciones
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ListarLactancia()
        Try
            bsLacatancia.DataSource = BDAccionPersonalDAO.GetEmpleadoHistorialLactancia(BDAccionPersonalDAO.IdEmpleado)
            Me.GridControl11.DataSource = bsLacatancia
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Adertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ListarAsignacionFamiliar()
        Try
            ' 1 => lista las solicitude de asignaciones familiares
            bsAsignaciónFamiliar.DataSource = BDAccionPersonalDAO.GetEmpleadoHistorialAsignacionFamiliar(BDAccionPersonalDAO.IdEmpleado)
            Me.GridControl12.DataSource = bsAsignaciónFamiliar
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ListarIncidenteAccidente()
        Try
            bsIncidenteAccidente.DataSource = BDAccionPersonalDAO.GetEmpleadoHistorialIncidenteAccidente(BDAccionPersonalDAO.IdEmpleado)
            Me.GridControl13.DataSource = bsIncidenteAccidente
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ListarAsistencias()
        Try
            bsMarcaciones.DataSource = BDAccionPersonalDAO.GetEmpleadoHistorialMarcacion(EmpleadoBE.CODIGOUNICO, "2019-08-11", "2019-09-11")
            Me.GridControl17.DataSource = bsMarcaciones
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ListarCartaCorrectiva()
        Try
            bsCartaCorrectiva.DataSource = BDAccionPersonalDAO.GetEmpleadoHistorialCartaCorrectiva(BDAccionPersonalDAO.IdEmpleado)
            Me.GridControl4.DataSource = bsCartaCorrectiva
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub RepositoryItemButtonFormatoConGoce_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonFormatoConGoce.Click
        Dim IdTipoLicencia As Int32
        LicenciaDAO.IdLicencia = GridView1.GetFocusedRowCellValue("IDLICENCIA")
        IdTipoLicencia = GridView1.GetFocusedRowCellValue("IDLICENCIATIPO")
        If LicenciaDAO.IdLicencia <> 0 Then
            Dim MiForm As New LicenciaArchivo

            If IdTipoLicencia = 1 Then
                Dim dt As DataTable = LicenciaDAO.ListaLicenciaAcuerdoArchivos(LicenciaDAO.IdLicencia)

                If dt.Rows.Count <> 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim ruta As String = dt.Rows(i).Table(i)("linkdescarga").ToString
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
                    MessageBox.Show("Archivo de acuerdo no adjuntado", "Archivo de Acuerdo")
                End If


            Else

                Dim dt1 As DataTable = LicenciaDAO.ListaLicenciaArchivos(LicenciaDAO.IdLicencia)
                If dt1.Rows.Count <> 0 Then
                    For i As Integer = 0 To dt1.Rows.Count - 1
                        Dim ruta As String = dt1.Rows(i).Table(i)("linkdescarga").ToString
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
                    MessageBox.Show("Archivo de compromiso no adjuntado", "Archivo de Licencia")
                End If
            End If
        End If
    End Sub
    Private Sub RepositoryItemButtonFormatoRenuncia_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonFormatoRenuncia.Click
        RenunciaDAO.IdRenuncia = GridView5.GetFocusedRowCellValue("IDRENUNCIA")
        If RenunciaDAO.IdRenuncia <> 0 Then
            Dim MiForm As New RenunciaArchivo
            Dim dt1 As DataTable = RenunciaDAO.SolicitudRenunciasListArchivo(RenunciaDAO.IdRenuncia)
            If dt1.Rows.Count <> 0 Then
                For i As Integer = 0 To dt1.Rows.Count - 1
                    Dim ruta As String = dt1.Rows(i).Table(i)("linkdescarga").ToString
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
                MessageBox.Show("Archivo de renuncia no adjuntado", "Archivo de Licencia")
            End If
        End If
    End Sub

    Private Sub RepositoryItemFormatoInforme_Click(sender As Object, e As EventArgs) Handles RepositoryItemFormatoInforme.Click
        MemorandumDAO.IdMemorandum = GridView8.GetFocusedRowCellValue("IDMEMORANDUM")
        Dim reportinforme As New RptInformeDisciplinario
        Dim dtcabecera As New DataTable
        dtcabecera = MemorandumDAO.ListaMemorandumGetBy(MemorandumDAO.IdMemorandum)
        reportinforme.XrNumeroInforme.Text = dtcabecera.Rows(0).Item("NUMEROINFORME")
        'reportinforme.XrArea.Text = dtcabecera.Rows(0).Item("AREA")
        reportinforme.XrRazonSocial.Text = dtcabecera.Rows(0).Item("RAZONSOCIAL")
        reportinforme.XrNombreComercial.Text = dtcabecera.Rows(0).Item("RAZONCOMERCIAL")
        reportinforme.XrRucLocal.Text = dtcabecera.Rows(0).Item("IDTRIBUTARIO")
        reportinforme.XrDireccionLocal.Text = dtcabecera.Rows(0).Item("DIRECCION")
        reportinforme.XrFecha.Text = dtcabecera.Rows(0).Item("FECHA")
        reportinforme.XrSolicitante.Text = dtcabecera.Rows(0).Item("SOLICITANTE")
        reportinforme.XrSolicitanteDni.Text = dtcabecera.Rows(0).Item("SOLICITANTEDNI")
        reportinforme.XrSolicitantePuesto.Text = dtcabecera.Rows(0).Item("SOLICITANTECARGO")
        reportinforme.XrRepresentante.Text = dtcabecera.Rows(0).Item("REPRESENTANTENOMBRE")
        reportinforme.XrRepresentanteDni.Text = dtcabecera.Rows(0).Item("REPRESENTANTEDNI")
        reportinforme.XrRepresentantePuesto.Text = dtcabecera.Rows(0).Item("REPRESENTANTECARGO")
        reportinforme.XrEmpleadoMemorandum.Text = dtcabecera.Rows(0).Item("EMPLEADO")
        reportinforme.XrEmpleadoDni.Text = dtcabecera.Rows(0).Item("EMPLEADODNI")
        reportinforme.XrEmpleadoPuesto.Text = dtcabecera.Rows(0).Item("EMPLEADOCARGO")
        reportinforme.XrDescripcionMemorandum.Text = dtcabecera.Rows(0).Item("DESCRIPCION")
        ReportView.DocumentViewer.DocumentSource = reportinforme
        ReportView.DocumentViewer.Refresh()
        ReportView.Show()
    End Sub

    Private Sub RepositoryItemFormatoMemorandum_Click(sender As Object, e As EventArgs) Handles RepositoryItemFormatoMemorandum.Click
        MemorandumDAO.IdMemorandum = GridView8.GetFocusedRowCellValue("IDMEMORANDUM")
        Dim reportinforme As New RptMemorandum()
        Dim dtcabecera As New DataTable
        dtcabecera = MemorandumDAO.ListaMemorandumGetBy(MemorandumDAO.IdMemorandum)
        Dim dtantecedentes As New DataTable
        dtantecedentes = MemorandumDAO.GetMemorandunAntecedentesTipoList(MemorandumDAO.IdMemorandum)

        reportinforme.XrNroInforme.Text = dtcabecera.Rows(0).Item("NUMEROINFORME")
        reportinforme.XrRazonsocial.Text = dtcabecera.Rows(0).Item("RAZONSOCIAL")
        reportinforme.XrNombreComercial.Text = dtcabecera.Rows(0).Item("RAZONCOMERCIAL")
        reportinforme.XrRUC.Text = dtcabecera.Rows(0).Item("IDTRIBUTARIO")
        reportinforme.XrDireccion.Text = dtcabecera.Rows(0).Item("DIRECCION")

        reportinforme.XrFecha.Text = dtcabecera.Rows(0).Item("FECHA")

        reportinforme.XrSolicitante.Text = dtcabecera.Rows(0).Item("EMPLEADO")
        reportinforme.XrSolicitanteCargo.Text = dtcabecera.Rows(0).Item("EMPLEADOCARGO")
        reportinforme.XrSolicitanteDNI.Text = dtcabecera.Rows(0).Item("EMPLEADODNI")

        reportinforme.XrDestinatario.Text = dtcabecera.Rows(0).Item("REPRESENTANTENOMBRE")
        reportinforme.XrDestinatarioCargo.Text = dtcabecera.Rows(0).Item("REPRESENTANTECARGO")
        reportinforme.XrDestinatarioDNI.Text = dtcabecera.Rows(0).Item("REPRESENTANTEDNI")

        reportinforme.XrFirmaDestinatario.Text = dtcabecera.Rows(0).Item("REPRESENTANTENOMBRE")
        reportinforme.XrFirmaSolicitante.Text = dtcabecera.Rows(0).Item("EMPLEADO")

        reportinforme.XrDescripcionLegal.Text = dtcabecera.Rows(0).Item("DESCRIPCIONLEGAL")
        reportinforme.XrMontoDescuento.Text = dtcabecera.Rows(0).Item("MONTODESCUENTO")

        reportinforme.XrSancion.Text = dtcabecera.Rows(0).Item("SANCION")
        reportinforme.XrFalta.Text = dtcabecera.Rows(0).Item("FALTA")

        If dtcabecera.Rows(0).Item("DESCRIPCIONHECHOS") = "" Then
            reportinforme.XrDescripcionHechos.Visible = False
            reportinforme.XrLabel25.Visible = False
        Else
            reportinforme.XrDescripcionHechos.Text = dtcabecera.Rows(0).Item("DESCRIPCIONHECHOS")
        End If


        Dim xDiasSancion As String
        xDiasSancion = dtcabecera.Rows(0).Item("DIASANCION")
        If xDiasSancion <> "" Then
            reportinforme.XrDiaSancion.Text = dtcabecera.Rows(0).Item("DIASANCION")
        Else
            reportinforme.XrDiaSancion.Visible = False
            reportinforme.lblDiasSancion.Visible = False
        End If

        Dim xDescuento As Boolean
        xDescuento = dtcabecera.Rows(0).Item("DESCUENTOREMUNERATIVO")
        If xDescuento Then
            reportinforme.XrDescuentoRemunerativo.Visible = True
            reportinforme.XrMontoDescuento.Visible = True
            reportinforme.XrMoneda.Visible = True
        Else
            reportinforme.XrDescuentoRemunerativo.Visible = False
            reportinforme.XrMontoDescuento.Visible = False
            reportinforme.XrMoneda.Visible = False
        End If
        If dtantecedentes.Rows.Count > 0 Then
            For i As Integer = 0 To dtantecedentes.Rows.Count - 1
                Dim row As New XRTableRow
                For j As Integer = 0 To 3
                    Dim cell As New XRTableCell
                    cell.Text = dtantecedentes.Rows(i).Item(j)
                    row.Cells.Add(cell)

                Next j
                row.Cells.Item(0).WidthF = 52
                row.Cells.Item(1).WidthF = 52
                row.Cells.Item(2).WidthF = 208
                row.Cells.Item(3).WidthF = 99

                reportinforme.XrTable2.Rows.Add(row)
            Next
            reportinforme.XrTableCell1.WidthF = 80
            reportinforme.XrTableCell2.WidthF = 79
            reportinforme.XrTableCell3.WidthF = 322
            reportinforme.XrTableCell4.WidthF = 152
        Else
            reportinforme.XrTable1.Visible = False
            reportinforme.XrTable2.Visible = False
            reportinforme.XrAntecedentes.Text = "NINGUNO"
        End If

        ReportView.DocumentViewer.DocumentSource = reportinforme
        ReportView.DocumentViewer.Refresh()
        ReportView.Show()
    End Sub

    Private Sub RepositoryItemNotariaArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemNotariaArchivo.Click
        MemorandumDAO.IdMemorandum = GridView8.GetFocusedRowCellValue("IDMEMORANDUM")
        Dim dt As New DataTable
        dt = MemorandumDAO.ListMemorandumFormatoLegalID(MemorandumDAO.IdMemorandum)
        If dt.Rows.Count > 0 Then
            If MessageBox.Show("¿Está seguro de descargar el archivo?", "Descargar Archvivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                If MemorandumDAO.IdMemorandum <> 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim ruta As String = dt.Rows(i).Table(i)("linkdescarga").ToString()
                        Dim uccontrol1 As New XtraUserControlWebBrowser()
                        uccontrol1.WebBrowser1.Show()
                        uccontrol1.WebBrowser1.Navigate(String.Format(ruta, Application.StartupPath))
                    Next
                End If
            End If
        Else
            MessageBox.Show("El memorandum no contiene archivo notarial", "Archivo de Memorandum Descargo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub RepositoryItemSustentoArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemSustentoArchivo.Click
        MemorandumDAO.IdMemorandum = GridView8.GetFocusedRowCellValue("IDMEMORANDUM")
        If MemorandumDAO.IdMemorandum <> 0 Then
            Dim MiForm As New MemorandumDescargo
            Dim dt As DataTable = MemorandumDAO.GetMemorandumDescargoAll(MemorandumDAO.IdMemorandum)
            If dt.Rows.Count <> 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim ruta As String = dt.Rows(i).Table(i)("linkdescarga").ToString
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
                MessageBox.Show("El memorandum no contiene archivo", "Archivo de Memorandum")
            End If
        Else
            MessageBox.Show("El memorandum no contiene archivo ", "Archivo de Memorandum Descargo")
        End If
    End Sub

    Private Sub RepositoryItemMemorandumArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemMemorandumArchivo.Click
        MemorandumDAO.IdMemorandum = GridView8.GetFocusedRowCellValue("IDMEMORANDUM")
        If MemorandumDAO.IdMemorandum <> 0 Then
            Dim MiForm As New MemorandumArchivos
            MiForm.btnEliminarFormatos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnFirmaDocumento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Dim dt As DataTable = MemorandumDAO.ListaMemorandumArchivos(MemorandumDAO.IdMemorandum)
            If dt.Rows.Count <> 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim ruta As String = dt.Rows(i).Table(i)("linkdescarga").ToString
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
                MessageBox.Show("El memorandum no contiene archivo", "Archivo de Memorandum")
            End If
        End If
    End Sub

    Private Sub RepositoryItemPrestamoSustentoArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemPrestamoSustentoArchivo.Click
        PrestamoDAO.IdPrestamo = GridView9.GetFocusedRowCellValue("IDPRESTAMO")
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

    Private Sub RepositoryItemPrestamoCompromiso_Click(sender As Object, e As EventArgs) Handles RepositoryItemPrestamoCompromiso.Click
        PrestamoDAO.IdPrestamo = GridView9.GetFocusedRowCellValue("IDPRESTAMO")
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

    Private Sub RepositoryItemLactaciaArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemLactaciaArchivo.Click
        LactanciaDAO.IdLactancia = GridView11.GetFocusedRowCellValue("IDLACTANCIA")
        If LactanciaDAO.IdLactancia <> 0 Then
            Dim MiForm As New LactanciaArchivo
            Dim dt1 As DataTable = LactanciaDAO.LactanciaArchivoList(LactanciaDAO.IdLactancia)
            If dt1.Rows.Count <> 0 Then
                For i As Integer = 0 To dt1.Rows.Count - 1
                    Dim ruta As String = dt1.Rows(i).Table(i)("linkdescarga").ToString
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
                MessageBox.Show("Archivo de lactancia no adjuntado", "Archivo de Lactancia")
            End If
        End If
    End Sub

    Private Sub RepositoryItemAsignacionFamiliarArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemAsignacionFamiliarArchivo.Click
        Dim idasignacionfamiliar As Integer
        idasignacionfamiliar = GridView12.GetFocusedRowCellValue("IDASIGNACIONFAMILIAR")
        If idasignacionfamiliar <> 0 Then
            Dim MiForm As New MemorandumArchivos
            MiForm.btnEliminarFormatos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            MiForm.btnFirmaDocumento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Dim dt As DataTable = BDAccionPersonalDAO.ListaAsignacionFamiliarArchivos(idasignacionfamiliar)
            If dt.Rows.Count <> 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim ruta As String = dt.Rows(i).Table(i)("linkdescarga").ToString
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
                MessageBox.Show("El memorandum no contiene archivo", "Archivo de Memorandum")
            End If
        End If
    End Sub

    Private Sub RepositoryItemIncidenteAccidenteArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemIncidenteAccidenteArchivo.Click
        IncidenteAccidenteDAO.IdIncidenteAccidente = GridView13.GetFocusedRowCellValue("IDINCIDENTEACCIDENTE")
        If IncidenteAccidenteDAO.IdIncidenteAccidente <> 0 Then
            Dim MiForm As New IncidenteAccidenteArchivos
            Dim dt As DataTable = IncidenteAccidenteDAO.IncidenteAccidenteArchivoList(IncidenteAccidenteDAO.IdIncidenteAccidente)
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
                MessageBox.Show("El informe de Incidente Accidente no contiene archivo", "Archivo de Incidente Accidente")
            End If
        End If

    End Sub
    Private Sub RepositoryItemDescargoArchivo_Click(sender As Object, e As EventArgs) Handles RepositoryItemDescargoArchivo.Click
        CeseDAO.IdSolicitudCese = GridView1.GetFocusedRowCellValue("IDSOLICITUDCESE")
        If CeseDAO.IdSolicitudCese <> 0 Then
            Dim MiForm As New SolicitudCeseDescargoArchivos
            Dim dt As DataTable = CeseDAO.ListSolicitudCeseDescargoArchivo(CeseDAO.IdSolicitudCese)
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
            End If
        Else
            MessageBox.Show("El cese no contiene archivo de descargo", "Cese - Descarrgo")
        End If
    End Sub

    Private Sub RepositoryItemArchivoCese_Click(sender As Object, e As EventArgs) Handles RepositoryItemArchivoCese.Click
        CeseDAO.IdSolicitudCese = GridView1.GetFocusedRowCellValue("IDSOLICITUDCESE")
        If CeseDAO.IdSolicitudCese <> 0 Then
            Dim MiForm As New SolicitudCeseDescargoArchivos
            Dim dt As DataTable = CeseDAO.ListSolicitudCeseArchivo(CeseDAO.IdSolicitudCese)
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


            End If
        Else
            MessageBox.Show("El cese no contiene archivo", "Cese")
        End If
    End Sub

    Private Sub RepositoryItemButtonCartaCorrectiva_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonCartaCorrectiva.Click
        Dim Adjunto As Boolean = GridView4.GetFocusedRowCellValue("ADJUNTO")
        Dim IdCartaCorrectivo As Integer = GridView4.GetFocusedRowCellValue("IDCARTAINFORMATIVA")
        If Adjunto Then
            Dim MiForm As New CartaCorrectivaArchivo
            Dim dt As DataTable = CartaCorrectivaDAO.ListarAdjuntosCartaCorrectiva(IdCartaCorrectivo)
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


            End If
        Else
            MessageBox.Show("El cese no contiene archivo", "Cese")
        End If
    End Sub
    Private Sub RepositoryItemVerFormatoNotas_Click(sender As Object, e As EventArgs) Handles RepositoryItemVerFormatoNotas.Click
        Dim IdCapacitacionEscuela As Integer = GridView14.GetFocusedRowCellValue("IDCAPACITACIONESCUELA")
        If IdCapacitacionEscuela > 0 Then
            CapacitacionDAO.IdProgramacionEscuela = IdCapacitacionEscuela
            Dim formatonotas As New NotasCursoEscuelaEmpleado()
            Dim dtcabecera As New DataTable
            dtcabecera = CapacitacionDAO.CapacitacionNotasDatosFormato(IdCapacitacionEscuela, BDAccionPersonalDAO.IdEmpleado)
            Dim dtCursos As New DataTable
            dtCursos = CapacitacionDAO.CapacitacionNotasGetIdEmpleado(IdCapacitacionEscuela, BDAccionPersonalDAO.IdEmpleado)

            formatonotas.XrParticpante.Text = dtcabecera.Rows(0).Item("PARTICIPANTE")
            formatonotas.XrEscuela.Text = dtcabecera.Rows(0).Item("ESCUELA")
            formatonotas.XrNumeroEscuela.Text = dtcabecera.Rows(0).Item("NUMEROESCUELA")
            formatonotas.XrFechas.Text = dtcabecera.Rows(0).Item("FECHAESCUELA")
            formatonotas.XrDuracion.Text = dtcabecera.Rows(0).Item("DURACIONTIEMPO")
            formatonotas.XrCursosPendientes.Text = dtcabecera.Rows(0).Item("RESULTNOTASPENDIENTES")
            formatonotas.XrCondicion.Text = dtcabecera.Rows(0).Item("RESULTADOESCUELA")
            formatonotas.XrPromedioFinal.Text = dtcabecera.Rows(0).Item("PROMEDIONOTATOTAL")
            formatonotas.XrCursosPendientes.Text = dtcabecera.Rows(0).Item("RESULTADOFINALAPROBACION")
            formatonotas.XrResultadoFinal.Text = dtcabecera.Rows(0).Item("RESULTADOFINAL")
            formatonotas.XrNotaAprobatoriaMinima.Text = dtcabecera.Rows(0).Item("NOTAAPROBATORIAMINIMA")
            formatonotas.XrDatosFirma.Text = dtcabecera.Rows(0).Item("DATOSFIRMAFORMATO")


            If dtCursos.Rows.Count > 0 Then
                For i As Integer = 0 To dtCursos.Rows.Count - 1
                    Dim row As New XRTableRow
                    For j As Integer = 0 To 3
                        Dim cell As New XRTableCell
                        cell.Text = dtCursos.Rows(i).Item(j)
                        row.Cells.Add(cell)

                    Next j
                    row.Cells.Item(0).WidthF = 32
                    row.Cells.Item(1).WidthF = 370
                    row.Cells.Item(2).WidthF = 70
                    row.Cells.Item(3).WidthF = 99

                    formatonotas.XrTableRow.Rows.Add(row)
                Next

            Else
                formatonotas.XrTable1.Visible = False
                formatonotas.XrTableRow.Visible = False
            End If

            ReportView.DocumentViewer.DocumentSource = formatonotas
            ReportView.DocumentViewer.Refresh()
            ReportView.Show()
        End If


    End Sub
    'GridControl3.DataSource = PrestamoDAO.GetHistorialLicenciasByID(IDEMPLEADO)
End Class