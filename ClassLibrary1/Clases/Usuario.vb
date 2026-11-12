Imports System.ComponentModel.DataAnnotations

Public Class Usuario

    <Key>
    Public Property IdUsuario As Integer

    Public Property Nombre As String

    Public Property Apellido As String

    Public Property Usuario As String

    Public Property Contrasena As String

    Public Property Rol As String

    Public Property Correo As String

    Public Property Estado As Boolean

End Class