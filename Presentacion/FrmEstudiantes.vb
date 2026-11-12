Imports Negocio
Imports Entidad
Public Class FrmEstudiantes
    Private servicio As New EstudianteService()

    Private estudianteSeleccionado As Estudiante

    Private Sub FrmEstudiantes_Load(sender As Object, e As EventArgs) Handles Me.Load

        CargarEstudiantes()

    End Sub

    Private Sub CargarEstudiantes()

        dgvEstudiantes.DataSource = servicio.ObtenerTodos()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim estudiante As New Estudiante()

        estudiante.Nombre = txtNombre.Text
        estudiante.Apellido = txtApellido.Text
        estudiante.Cedula = txtCedula.Text
        estudiante.Telefono = txtTelefono.Text
        estudiante.Correo = txtCorreo.Text
        estudiante.Direccion = txtDireccion.Text
        estudiante.FechaNacimiento = dtpNacimiento.Value
        estudiante.Estado = True


        servicio.Guardar(estudiante)


        MessageBox.Show("Estudiante guardado correctamente")


        CargarEstudiantes()
    End Sub

    Private Sub dgvEstudiantes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEstudiantes.CellContentClick

        If e.RowIndex < 0 Then Exit Sub

        estudianteSeleccionado = CType(dgvEstudiantes.Rows(e.RowIndex).DataBoundItem, Estudiante)

        txtNombre.Text = estudianteSeleccionado.Nombre
        txtApellido.Text = estudianteSeleccionado.Apellido
        txtCedula.Text = estudianteSeleccionado.Cedula
        txtTelefono.Text = estudianteSeleccionado.Telefono
        txtCorreo.Text = estudianteSeleccionado.Correo
        txtDireccion.Text = estudianteSeleccionado.Direccion
        dtpNacimiento.Value = estudianteSeleccionado.FechaNacimiento

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If estudianteSeleccionado Is Nothing Then

            MessageBox.Show("Seleccione un estudiante.")

            Exit Sub

        End If

        estudianteSeleccionado.Nombre = txtNombre.Text
        estudianteSeleccionado.Apellido = txtApellido.Text
        estudianteSeleccionado.Cedula = txtCedula.Text
        estudianteSeleccionado.Telefono = txtTelefono.Text
        estudianteSeleccionado.Correo = txtCorreo.Text
        estudianteSeleccionado.Direccion = txtDireccion.Text
        estudianteSeleccionado.FechaNacimiento = dtpNacimiento.Value

        servicio.Actualizar(estudianteSeleccionado)

        MessageBox.Show("Estudiante actualizado correctamente.")

        CargarEstudiantes()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If estudianteSeleccionado Is Nothing Then

            MessageBox.Show("Seleccione un estudiante.")

            Exit Sub

        End If

        If MessageBox.Show("¿Desea eliminar este estudiante?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            servicio.Eliminar(estudianteSeleccionado)

            MessageBox.Show("Estudiante eliminado correctamente.")

            CargarEstudiantes()

        End If

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        estudianteSeleccionado = Nothing

        txtNombre.Clear()
        txtApellido.Clear()
        txtCedula.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()
        txtDireccion.Clear()

        dtpNacimiento.Value = Date.Today

        txtNombre.Focus()

    End Sub
End Class