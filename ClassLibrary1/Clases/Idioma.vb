Imports System.ComponentModel.DataAnnotations
Imports Entidad.Entidad

Public Class Idioma

    Public Sub New()

        Cursos = New HashSet(Of Curso)

    End Sub


    <Key>
    Public Property IdIdioma As Integer

    Public Property NombreIdioma As String

    Public Property Nivel As String

    Public Property Descripcion As String

    Public Property Costo As Decimal

    Public Property Duracion As String

    Public Property Modalidad As String

    Public Property Estado As Boolean


    Public Overridable Property Cursos As ICollection(Of Curso)

End Class