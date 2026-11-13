Imports DatosCS.Repositorios
Imports Entidad

Public Class ProfesorService

    Private ReadOnly repositorio As New RepositorioGenerico(Of Profesor)

    Public Function ObtenerTodos() As IEnumerable(Of Profesor)
        Return repositorio.ObtenerTodos()
    End Function

    Public Sub Guardar(profesor As Profesor)
        repositorio.Agregar(profesor)
    End Sub

    Public Sub Actualizar(profesor As Profesor)
        repositorio.Actualizar(profesor)
    End Sub

    Public Sub Eliminar(profesor As Profesor)
        repositorio.Eliminar(profesor)
    End Sub

End Class