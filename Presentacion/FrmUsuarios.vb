Imports Negocio
Imports Entidad

Public Class FrmUsuarios

    Private ReadOnly servicio As New UsuarioService()
    Private usuarioSeleccionado As Usuario








    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        usuarioSeleccionado = TryCast(dgvUsuarios.Rows(e.RowIndex).DataBoundItem, Usuario)
        If usuarioSeleccionado Is Nothing Then Exit Sub

        txtNombre.Text = Texto(usuarioSeleccionado, "Nombre", "Nombres")
        txtApellido.Text = Texto(usuarioSeleccionado, "Apellido", "Apellidos")
        txtUsuario.Text = Texto(usuarioSeleccionado, "Usuario", "UsuarioNombre", "NombreUsuario")
        txtContrasena.Text = Texto(usuarioSeleccionado, "Contrasena", "Contraseña")
        txtRol.Text = Texto(usuarioSeleccionado, "Rol")
        txtCorreo.Text = Texto(usuarioSeleccionado, "Correo", "Email")
        chkEstado.Checked = EstadoUsuario(usuarioSeleccionado)

    End Sub


    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUsuarios.MultiSelect = False
        dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        chkEstado.Checked = True

        CargarUsuarios()
    End Sub

    Private Sub CargarUsuarios()

        Try
            dgvUsuarios.DataSource = Nothing
            dgvUsuarios.DataSource = servicio.ObtenerTodos()
        Catch ex As Exception
            MessageBox.Show("Error al cargar usuarios: " & ex.GetBaseException().Message)
        End Try

    End Sub
    Private Function LeerPropiedad(entidad As Object, ParamArray nombres As String()) As Object

        For Each nombre In nombres
            Dim propiedad = entidad.GetType().GetProperty(nombre)
            If propiedad IsNot Nothing AndAlso propiedad.CanRead Then
                Return propiedad.GetValue(entidad, Nothing)
            End If
        Next

        Return Nothing

    End Function

    Private Sub AsignarPropiedad(entidad As Object, valor As Object, ParamArray nombres As String())

        For Each nombre In nombres
            Dim propiedad = entidad.GetType().GetProperty(nombre)
            If propiedad IsNot Nothing AndAlso propiedad.CanWrite Then

                If propiedad.PropertyType Is GetType(String) Then
                    propiedad.SetValue(entidad, Convert.ToString(valor))
                ElseIf propiedad.PropertyType Is GetType(Boolean) Then
                    propiedad.SetValue(entidad, Convert.ToBoolean(valor))
                Else
                    propiedad.SetValue(entidad, Convert.ChangeType(valor, propiedad.PropertyType))
                End If

                Exit Sub
            End If
        Next

    End Sub

    Private Function Texto(entidad As Object, ParamArray nombres As String()) As String
        Dim valor = LeerPropiedad(entidad, nombres)
        If valor Is Nothing Then Return ""
        Return Convert.ToString(valor)
    End Function

    Private Function EstadoUsuario(entidad As Object) As Boolean

        Dim valor = LeerPropiedad(entidad, "Estado", "Activo")
        If valor Is Nothing Then Return True

        If TypeOf valor Is Boolean Then Return CBool(valor)

        Dim textoEstado = valor.ToString().ToLower().Trim()
        Return textoEstado = "true" OrElse textoEstado = "1" OrElse textoEstado = "activo" OrElse textoEstado = "si"

    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombre.Text.Trim() = "" OrElse txtUsuario.Text.Trim() = "" Then
            MessageBox.Show("Complete al menos nombre y usuario.")
            Exit Sub
        End If

        Try
            Dim usuario As New Usuario()

            AsignarPropiedad(usuario, txtNombre.Text.Trim(), "Nombre", "Nombres")
            AsignarPropiedad(usuario, txtApellido.Text.Trim(), "Apellido", "Apellidos")
            AsignarPropiedad(usuario, txtUsuario.Text.Trim(), "Usuario", "UsuarioNombre", "NombreUsuario")
            AsignarPropiedad(usuario, txtContrasena.Text.Trim(), "Contrasena", "Contraseña")
            AsignarPropiedad(usuario, txtRol.Text.Trim(), "Rol")
            AsignarPropiedad(usuario, txtCorreo.Text.Trim(), "Correo", "Email")
            AsignarPropiedad(usuario, chkEstado.Checked, "Estado", "Activo")

            servicio.Guardar(usuario)

            MessageBox.Show("Usuario guardado correctamente.")
            CargarUsuarios()
            LimpiarCampos()

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.GetBaseException().Message)
        End Try

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If usuarioSeleccionado Is Nothing Then
            MessageBox.Show("Seleccione un usuario.")
            Exit Sub
        End If

        Try
            AsignarPropiedad(usuarioSeleccionado, txtNombre.Text.Trim(), "Nombre", "Nombres")
            AsignarPropiedad(usuarioSeleccionado, txtApellido.Text.Trim(), "Apellido", "Apellidos")
            AsignarPropiedad(usuarioSeleccionado, txtUsuario.Text.Trim(), "Usuario", "UsuarioNombre", "NombreUsuario")
            AsignarPropiedad(usuarioSeleccionado, txtContrasena.Text.Trim(), "Contrasena", "Contraseña")
            AsignarPropiedad(usuarioSeleccionado, txtRol.Text.Trim(), "Rol")
            AsignarPropiedad(usuarioSeleccionado, txtCorreo.Text.Trim(), "Correo", "Email")
            AsignarPropiedad(usuarioSeleccionado, chkEstado.Checked, "Estado", "Activo")

            servicio.Actualizar(usuarioSeleccionado)

            MessageBox.Show("Usuario actualizado correctamente.")
            CargarUsuarios()
            LimpiarCampos()

        Catch ex As Exception
            MessageBox.Show("Error al actualizar: " & ex.GetBaseException().Message)
        End Try

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If usuarioSeleccionado Is Nothing Then
            MessageBox.Show("Seleccione un usuario.")
            Exit Sub
        End If

        If MessageBox.Show("¿Desea eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                servicio.Eliminar(usuarioSeleccionado)
                MessageBox.Show("Usuario eliminado correctamente.")
                CargarUsuarios()
                LimpiarCampos()
            Catch ex As Exception
                MessageBox.Show("Error al eliminar: " & ex.GetBaseException().Message)
            End Try
        End If

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()

        usuarioSeleccionado = Nothing

        txtNombre.Clear()
        txtApellido.Clear()
        txtUsuario.Clear()
        txtContrasena.Clear()
        txtRol.Clear()
        txtCorreo.Clear()

        chkEstado.Checked = True
        txtNombre.Focus()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class

