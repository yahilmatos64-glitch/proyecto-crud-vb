
Imports DatosCS.Repositorios
Imports Entidad
Imports System.Linq

Public Class UsuarioService

    Private ReadOnly repositorio As New RepositorioGenerico(Of Usuario)

    ' LOGIN
    Public Function Login(usuario As String, contraseña As String) As Usuario

        Return repositorio.Buscar(
            Function(x) x.Usuario = usuario AndAlso
                        x.Contrasena = contraseña
        ).FirstOrDefault()

    End Function

    ' OBTENER TODOS
    Public Function ObtenerTodos() As List(Of Usuario)

        Return repositorio.ObtenerTodos().ToList()

    End Function

    ' GUARDAR
    Public Sub Guardar(usuario As Usuario)

        repositorio.Agregar(usuario)

    End Sub

    ' ACTUALIZAR
    Public Sub Actualizar(usuario As Usuario)

        repositorio.Actualizar(usuario)

    End Sub

    ' ELIMINAR
    Public Sub Eliminar(usuario As Usuario)

        repositorio.Eliminar(usuario)

    End Sub

End Class
