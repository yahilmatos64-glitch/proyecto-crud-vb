Imports Entidad
Imports Negocio

Public Class FrmIdiomas

    Private ReadOnly servicio As New IdiomaService()
    Private idiomaSeleccionado As Idioma

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarCampos()


    End Sub

    Private Sub FrmIdiomas_Load(sender As Object, e As EventArgs) Handles Me.Load
        dgvIdiomas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvIdiomas.MultiSelect = False
        dgvIdiomas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        chkEstado.Checked = True

        CargarIdiomas()


    End Sub

    Private Sub CargarIdiomas()

        Try
            dgvIdiomas.DataSource = Nothing
            dgvIdiomas.DataSource = servicio.ObtenerTodos()
        Catch ex As Exception
            MessageBox.Show("Error al cargar idiomas: " & ex.GetBaseException().Message)
        End Try

    End Sub

    Private Sub dgvIdiomas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvIdiomas.CellContentClick

        If e.RowIndex < 0 Then Exit Sub

        idiomaSeleccionado = TryCast(dgvIdiomas.Rows(e.RowIndex).DataBoundItem, Idioma)
        If idiomaSeleccionado Is Nothing Then Exit Sub

        txtNombreIdioma.Text = idiomaSeleccionado.NombreIdioma
        txtNivel.Text = idiomaSeleccionado.Nivel
        txtDescripcion.Text = idiomaSeleccionado.Descripcion
        txtCosto.Text = idiomaSeleccionado.Costo.ToString()
        txtDuracion.Text = idiomaSeleccionado.Duracion
        txtModalidad.Text = idiomaSeleccionado.Modalidad
        chkEstado.Checked = idiomaSeleccionado.Estado

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombreIdioma.Text.Trim() = "" Then
            MessageBox.Show("Escriba el nombre del idioma.")
            Exit Sub
        End If

        Dim costo As Decimal
        If Not Decimal.TryParse(txtCosto.Text, costo) Then
            MessageBox.Show("El costo debe ser numérico.")
            Exit Sub
        End If

        Try
            Dim idioma As New Idioma With {
                .NombreIdioma = txtNombreIdioma.Text.Trim(),
                .Nivel = txtNivel.Text.Trim(),
                .Descripcion = txtDescripcion.Text.Trim(),
                .Costo = costo,
                .Duracion = txtDuracion.Text.Trim(),
                .Modalidad = txtModalidad.Text.Trim(),
                .Estado = chkEstado.Checked
            }

            servicio.Guardar(idioma)

            MessageBox.Show("Idioma guardado correctamente.")
            CargarIdiomas()
            LimpiarCampos()

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.GetBaseException().Message)
        End Try

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If idiomaSeleccionado Is Nothing Then
            MessageBox.Show("Seleccione un idioma.")
            Exit Sub
        End If

        Dim costo As Decimal
        If Not Decimal.TryParse(txtCosto.Text, costo) Then
            MessageBox.Show("El costo debe ser numérico.")
            Exit Sub
        End If

        Try
            idiomaSeleccionado.NombreIdioma = txtNombreIdioma.Text.Trim()
            idiomaSeleccionado.Nivel = txtNivel.Text.Trim()
            idiomaSeleccionado.Descripcion = txtDescripcion.Text.Trim()
            idiomaSeleccionado.Costo = costo
            idiomaSeleccionado.Duracion = txtDuracion.Text.Trim()
            idiomaSeleccionado.Modalidad = txtModalidad.Text.Trim()
            idiomaSeleccionado.Estado = chkEstado.Checked

            servicio.Actualizar(idiomaSeleccionado)

            MessageBox.Show("Idioma actualizado correctamente.")
            CargarIdiomas()
            LimpiarCampos()

        Catch ex As Exception
            MessageBox.Show("Error al actualizar: " & ex.GetBaseException().Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If idiomaSeleccionado Is Nothing Then
            MessageBox.Show("Seleccione un idioma.")
            Exit Sub
        End If

        If MessageBox.Show("¿Desea eliminar este idioma?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Try
                servicio.Eliminar(idiomaSeleccionado)
                MessageBox.Show("Idioma eliminado correctamente.")
                CargarIdiomas()
                LimpiarCampos()

            Catch ex As Exception
                MessageBox.Show("Error al eliminar: " & ex.GetBaseException().Message)
            End Try

        End If
    End Sub

    Private Sub LimpiarCampos()

        idiomaSeleccionado = Nothing

        txtNombreIdioma.Clear()
        txtNivel.Clear()
        txtDescripcion.Clear()
        txtCosto.Clear()
        txtDuracion.Clear()
        txtModalidad.Clear()

        chkEstado.Checked = True
        txtNombreIdioma.Focus()

    End Sub


End Class