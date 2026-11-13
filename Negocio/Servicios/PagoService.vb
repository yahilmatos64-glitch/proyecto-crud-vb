
Imports DatosCS.Repositorios
Imports Entidad
Imports System.Linq

Public Class PagoService

    Private ReadOnly repositorio As New RepositorioGenerico(Of Pago)

    Public Function ObtenerTodos() As List(Of Pago)
        Return repositorio.ObtenerTodos().ToList()
    End Function

    Public Sub Guardar(pago As Pago)
        repositorio.Agregar(pago)
    End Sub

    Public Sub Actualizar(pago As Pago)
        repositorio.Actualizar(pago)
    End Sub

    Public Sub Eliminar(pago As Pago)
        repositorio.Eliminar(pago)
    End Sub

End Class
