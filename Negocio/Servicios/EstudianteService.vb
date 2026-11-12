Imports DatosCS.Repositorios
Imports Entidad

Public Class EstudianteService

    Private repositorio As RepositorioGenerico(Of Estudiante)


    Public Sub New()

        repositorio = New RepositorioGenerico(Of Estudiante)()

    End Sub



    Public Function ObtenerTodos() As IEnumerable(Of Estudiante)

        Return repositorio.ObtenerTodos()

    End Function



    Public Sub Guardar(estudiante As Estudiante)

        repositorio.Agregar(estudiante)

    End Sub



    Public Sub Actualizar(estudiante As Estudiante)

        repositorio.Actualizar(estudiante)

    End Sub



    Public Sub Eliminar(estudiante As Estudiante)

        repositorio.Eliminar(estudiante)

    End Sub


End Class