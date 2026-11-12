Imports Entidad
Imports Negocio

Public Class FrmLogin


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private usuarioServicio As New UsuarioService()

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim usuario As Usuario = usuarioServicio.Login(
            txtUsuario.Text,
            txtContrasena.Text
        )


        If usuario IsNot Nothing Then


            MessageBox.Show(
                "Bienvenido " & usuario.Nombre
            )


            FrmMenuPrincipal.Show()

            Me.Hide()


        Else


            MessageBox.Show(
                "Usuario o contraseña incorrectos"
            )


        End If

    End Sub
End Class