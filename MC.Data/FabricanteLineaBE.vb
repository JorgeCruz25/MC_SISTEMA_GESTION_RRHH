Imports System.ComponentModel.DataAnnotations

Public Class FabricanteLineaBE
    Public Property idlineafabricante() As Int32

    Public Property idfabricante() As Int32

    <Required(ErrorMessage:="Campo obligatorio")>
    <StringLength(150, ErrorMessage:="Campo obligatorio")>
    Public Property nombre() As String

    Public Property idusuario() As Int32

    Public Property fecharegistro() As DateTime

End Class
