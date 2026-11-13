Imports Entidad
Imports Negocio

Public Class FrmProfesores

    Private servicio As New ProfesorService()

    Private profesorSeleccionado As Profesor

    Private Sub CargarProfesores()

        dgvProfesores.DataSource = Nothing
        dgvProfesores.DataSource = servicio.ObtenerTodos().ToList()

    End Sub

    Private Sub FrmProfesores_ClientSizeChanged(sender As Object, e As EventArgs) Handles Me.ClientSizeChanged

    End Sub

    Private Sub FrmProfesores_Load(sender As Object, e As EventArgs) Handles Me.Load

        CargarProfesores()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim profesor As New Profesor()

        profesor.Nombre = txtNombre.Text
        profesor.Apellido = txtApellido.Text
        profesor.Especialidad = txtEspecialidad.Text
        profesor.Telefono = txtTelefono.Text
        profesor.Correo = txtCorreo.Text
        profesor.Direccion = txtDireccion.Text
        profesor.Estado = chkEstado.Checked

        servicio.Guardar(profesor)

        CargarProfesores()


    End Sub

    Private Sub dgvProfesores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProfesores.CellContentClick

        If e.RowIndex < 0 Then Exit Sub

        profesorSeleccionado = CType(dgvProfesores.Rows(e.RowIndex).DataBoundItem, Profesor)

        txtNombre.Text = profesorSeleccionado.Nombre
        txtApellido.Text = profesorSeleccionado.Apellido

        txtTelefono.Text = profesorSeleccionado.Telefono
        txtCorreo.Text = profesorSeleccionado.Correo
        txtDireccion.Text = profesorSeleccionado.Direccion

        txtEspecialidad.Text = profesorSeleccionado.Especialidad
        chkEstado.Checked = profesorSeleccionado.Estado

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If profesorSeleccionado Is Nothing Then

            MessageBox.Show("Seleccione un  profesor.")

            Exit Sub

        End If

        profesorSeleccionado.Nombre = txtNombre.Text
        profesorSeleccionado.Apellido = txtApellido.Text
        profesorSeleccionado.Telefono = txtTelefono.Text
        profesorSeleccionado.Correo = txtCorreo.Text
        profesorSeleccionado.Direccion = txtDireccion.Text
        profesorSeleccionado.Especialidad = txtEspecialidad.Text
        profesorSeleccionado.Estado = chkEstado.Checked


        servicio.Actualizar(profesorSeleccionado)

        MessageBox.Show(" profesor actualizado correctamente.")

        CargarProfesores()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If profesorSeleccionado Is Nothing Then

            MessageBox.Show("Seleccione un  profesor.")

            Exit Sub

        End If

        If MessageBox.Show("¿Desea eliminar este  profesor?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            servicio.Eliminar(profesorSeleccionado)

            MessageBox.Show(" profesor eliminado correctamente.")

            CargarProfesores()

        End If

    End Sub


End Class



