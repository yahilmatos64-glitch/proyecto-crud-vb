Imports DatosCS.Repositorios
Imports Entidad

Public Class UsuarioService


    Private repositorio As RepositorioGenerico(Of Usuario)


    Public Sub New()

        repositorio = New RepositorioGenerico(Of Usuario)()

    End Sub



    Public Function Login(usuario As String, contraseña As String) As Usuario

        Dim resultado = repositorio.Buscar(
            Function(x) x.Usuario = usuario AndAlso
                        x.Contrasena = contraseña
        ).FirstOrDefault()


        Return resultado

    End Function



    Public Function ObtenerUsuarios() As IEnumerable(Of Usuario)

        Return repositorio.ObtenerTodos()

    End Function



    Public Sub Guardar(usuario As Usuario)

        repositorio.Agregar(usuario)

    End Sub



    Public Sub Actualizar(usuario As Usuario)

        repositorio.Actualizar(usuario)

    End Sub



    Public Sub Eliminar(usuario As Usuario)

        repositorio.Eliminar(usuario)

    End Sub


End Class