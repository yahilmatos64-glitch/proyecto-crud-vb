Imports DatosCS.Repositorios
Imports Entidad
Imports System.Linq

Public Class InscripcionService

    Private ReadOnly repositorio As New RepositorioGenerico(Of Inscripcion)

    Public Function ObtenerTodos() As List(Of Inscripcion)
        Return repositorio.ObtenerTodos().ToList()
    End Function

    Public Sub Guardar(inscripcion As Inscripcion)
        repositorio.Agregar(inscripcion)
    End Sub

    Public Sub Actualizar(inscripcion As Inscripcion)
        repositorio.Actualizar(inscripcion)
    End Sub

    Public Sub Eliminar(inscripcion As Inscripcion)
        repositorio.Eliminar(inscripcion)
    End Sub

End Class