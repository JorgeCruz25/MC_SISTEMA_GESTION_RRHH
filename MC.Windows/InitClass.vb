Imports MC.Data
Imports DevExpress.XtraEditors

Public Enum eValidaControl
    TextEdit = 1
    SpinEdit = 2
    GridLoopUpEdit = 3
    SearchLookUpEdit = 4
    LookUpEdit = 5
    DateEdit = 6
End Enum

Module InitClass
    Public IDSistema As Integer = 4
    Public strCnx As String = ""
    Public strCorreo As String = ""
    Public strClave As String = ""
    Public strPuerto As String = ""
    Public strHost As String = ""
    Public strCorreoCopia As String = ""
    Public NombreLog As String = ""
    Public DetalleLog As String = ""

    '------------Es Para el log----------------
    Public Nombre As String = ""
    Public ApellidoPaterno As String = ""
    Public ApellidoMaterno As String = ""
    Public NumeroDocumento As String = ""


    Public BDCentralDAO As New BDCentralDAO
    Public BDAccionPersonalDAO As New BDAccionPersonalDAO
    Public UsuarioDAO As New UsuarioDAO
    Public PrestamoDAO As New PrestamoDAO
    Public MemorandumDAO As New MemorandumDAO
    Public LicenciaDAO As New LicenciaDAO
    Public RenunciaDAO As New RenunciaDAO
    Public CeseDAO As New CeseDAO
    Public CambioLocalTemporalDAO As New CambioLocalTemporalDAO
    Public CambioLocalDefinitivoDAO As New CambioLocalDefinitivoDAO
    Public IncidenteAccidenteDAO As New IncidenteAccidenteDAO
    Public CartaConocimientoDAO As New CartaConocimientoDAO
    Public NegacionTrasladoDAO As New NegacionTrasladoDAO
    Public InformeGeneralDAO As New InformeGeneralDAO
    Public LactanciaDAO As New LactanciaDAO
    Public VacacionesDAO As New VacacionesDAO
    Public BonoExtraDAO As New BonoExtraDAO
    Public RenovacionContratoDAO As New RenovacionContratoDAO
    Public SuspencionPerfectaDAO As New SuspencionPerfectaDAO
    Public CartaCorrectivaDAO As New CartaCorrectivaDAO
    Public CapacitacionDAO As New CapacitacionDAO
    Public PlanillaDAO As New PlanillaDAO


    Public Function GetUltimoCambio(ByRef objBarStatic As DevExpress.XtraBars.BarStaticItem, BE As Object) As String
        Dim UltimoCambio As String = "El último cambio fue registrado por {0} el {1} a las {2}:{3}:{4}"
        Dim Fecha As DateTime = BE.FechaRegistro

        UltimoCambio = String.Format(UltimoCambio, BE.NombreUsuario, Fecha.Date.ToString("d"), Fecha.Hour.ToString("00"), Fecha.Minute.ToString("00"), Fecha.ToString("00"))

        objBarStatic.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        objBarStatic.Caption = UltimoCambio

        Return UltimoCambio
    End Function

    Public Function CampoObligatorio(objControl As Object, Optional ByVal Tipo As eValidaControl = eValidaControl.TextEdit) As Boolean
        Dim Result As Boolean = True

        If Tipo = eValidaControl.TextEdit Then
            If objControl.Text = "" Then
                objControl.ErrorIconAlignment = ErrorIconAlignment.MiddleRight
                objControl.ErrorText = "*"
                Result = False
            End If
            If objControl.Text = "0.00" Then
                objControl.ErrorIconAlignment = ErrorIconAlignment.MiddleRight
                objControl.ErrorText = "*"
                Result = False
            End If
            If objControl.Text = "0" Then
                objControl.ErrorIconAlignment = ErrorIconAlignment.MiddleRight
                objControl.ErrorText = "*"
                Result = False
            End If
        End If

        If Tipo = eValidaControl.SpinEdit Then
            Dim Control As New SpinEdit

            Control = CType(objControl, SpinEdit)

            If Control.EditValue = 0 Then
                objControl.ErrorIconAlignment = ErrorIconAlignment.MiddleRight
                objControl.ErrorText = "*"
                Result = False
            End If
        End If

        If Tipo = eValidaControl.GridLoopUpEdit Then
            Dim Control As New GridLookUpEdit

            Control = CType(objControl, GridLookUpEdit)

            If Control.EditValue = 0 Then
                objControl.ErrorIconAlignment = ErrorIconAlignment.MiddleRight
                objControl.ErrorText = "*"
                Result = False
            End If
        End If

        If Tipo = eValidaControl.SearchLookUpEdit Then
            Dim Control As New SearchLookUpEdit

            Control = CType(objControl, SearchLookUpEdit)

            If Control.EditValue = 0 Then
                objControl.ErrorIconAlignment = ErrorIconAlignment.MiddleRight
                objControl.ErrorText = "*"
                Result = False
            End If
        End If
        If Tipo = eValidaControl.LookUpEdit Then
            Dim Control As New LookUpEdit

            Control = CType(objControl, LookUpEdit)
            If Control.EditValue = 0 Then
                objControl.ErrorIconAlignment = ErrorIconAlignment.MiddleRight
                objControl.ErrorText = "*"
                Result = False
            End If
        End If

        Return Result
    End Function

End Module
