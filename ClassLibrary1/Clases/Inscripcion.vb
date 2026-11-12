Imports System.ComponentModel.DataAnnotations
Imports Entidad.Entidad

Public Class Inscripcion

    Public Sub New()

        Pagos = New HashSet(Of Pago)

    End Sub


    <Key>
    Public Property IdInscripcion As Integer

    Public Property IdEstudiante As Integer

    Public Property IdCurso As Integer

    Public Property FechaInscripcion As Date

    Public Property Monto As Decimal

    Public Property Descuento As Decimal

    Public Property Estado As String

    Public Property Observacion As String


    Public Overridable Property Estudiante As Estudiante

    Public Overridable Property Curso As Curso

    Public Overridable Property Pagos As ICollection(Of Pago)

End Class