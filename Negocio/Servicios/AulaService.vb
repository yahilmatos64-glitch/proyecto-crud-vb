Imports DatosCS.Repositorios
Imports Entidad
Imports System.Linq

Public Class AulaService

    Private ReadOnly repositorio As New RepositorioGenerico(Of Aula)

    Public Function ObtenerTodos() As List(Of Aula)
        Return repositorio.ObtenerTodos().ToList()
    End Function

    Public Sub Guardar(aula As Aula)
        repositorio.Agregar(aula)
    End Sub

    Public Sub Actualizar(aula As Aula)
        repositorio.Actualizar(aula)
    End Sub

    Public Sub Eliminar(aula As Aula)
        repositorio.Eliminar(aula)
    End Sub

End Class