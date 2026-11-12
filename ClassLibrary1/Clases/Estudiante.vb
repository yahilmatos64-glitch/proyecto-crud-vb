Imports System.ComponentModel.DataAnnotations
Imports Entidad.Entidad

Public Class Estudiante

    Public Sub New()

        Inscripciones = New HashSet(Of Inscripcion)

    End Sub


    <Key>
    Public Property IdEstudiante As Integer

    Public Property Nombre As String

    Public Property Apellido As String

    Public Property Cedula As String

    Public Property Telefono As String

    Public Property Correo As String

    Public Property Direccion As String

    Public Property FechaNacimiento As Date

    Public Property Estado As Boolean


    Public Overridable Property Inscripciones As ICollection(Of Inscripcion)

End Class