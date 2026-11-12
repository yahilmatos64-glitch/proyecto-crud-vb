Imports System.ComponentModel.DataAnnotations

Public Class Pago


    <Key>
    Public Property IdPago As Integer


    Public Property IdInscripcion As Integer

    Public Property FechaPago As Date

    Public Property Monto As Decimal

    Public Property MetodoPago As String

    Public Property Referencia As String

    Public Property Estado As String

    Public Property Observacion As String


    Public Overridable Property Inscripcion As Inscripcion


End Class