Imports System.ComponentModel.DataAnnotations
Imports Entidad.Entidad

Public Class Curso

    Public Sub New()

        Inscripciones = New HashSet(Of Inscripcion)

    End Sub


    <Key>
    Public Property IdCurso As Integer

    Public Property NombreCurso As String

    Public Property IdIdioma As Integer

    Public Property IdProfesor As Integer

    Public Property Horario As String

    Public Property Duracion As String

    Public Property Costo As Decimal

    Public Property Nivel As String

    Public Property Estado As Boolean


    Public Overridable Property Idioma As Idioma

    Public Overridable Property Profesor As Profesor

    Public Overridable Property Inscripciones As ICollection(Of Inscripcion)

End Class