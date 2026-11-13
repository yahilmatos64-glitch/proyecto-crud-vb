Imports DatosCS.Repositorios
Imports Entidad
Imports System.Linq

Public Class CursoService

    Private ReadOnly repositorio As New RepositorioGenerico(Of Curso)

    Public Function ObtenerTodos() As List(Of Curso)
        Return repositorio.ObtenerTodos().ToList()
    End Function

    Public Sub Guardar(curso As Curso)
        repositorio.Agregar(curso)
    End Sub

    Public Sub Actualizar(curso As Curso)
        repositorio.Actualizar(curso)
    End Sub

    Public Sub Eliminar(curso As Curso)
        repositorio.Eliminar(curso)
    End Sub

End Class