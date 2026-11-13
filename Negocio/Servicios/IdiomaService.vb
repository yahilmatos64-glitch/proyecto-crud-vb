Imports DatosCS.Repositorios
Imports Entidad
Imports System.Linq

Public Class IdiomaService

    Private ReadOnly repositorio As New RepositorioGenerico(Of Idioma)

    Public Function ObtenerTodos() As List(Of Idioma)

        Return repositorio.ObtenerTodos().ToList()

    End Function

    Public Sub Guardar(idioma As Idioma)

        repositorio.Agregar(idioma)

    End Sub

    Public Sub Actualizar(idioma As Idioma)

        repositorio.Actualizar(idioma)

    End Sub

    Public Sub Eliminar(idioma As Idioma)

        repositorio.Eliminar(idioma)

    End Sub

End Class