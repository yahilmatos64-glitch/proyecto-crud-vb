Imports System.ComponentModel.DataAnnotations
Imports Entidad.Entidad

Public Class Profesor

    Public Sub New()

        Cursos = New HashSet(Of Curso)

    End Sub


    <Key>
    Public Property IdProfesor As Integer

    Public Property Nombre As String

    Public Property Apellido As String

    Public Property Especialidad As String

    Public Property Telefono As String

    Public Property Correo As String

    Public Property Direccion As String

    Public Property Estado As Boolean


    Public Overridable Property Cursos As ICollection(Of Curso)

End Class