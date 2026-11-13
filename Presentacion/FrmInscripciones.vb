Imports Negocio
Imports Entidad

Public Class FrmInscripciones
    Private ReadOnly servicio As New InscripcionService()
    Private ReadOnly servicioEstudiantes As New EstudianteService()
    Private ReadOnly servicioCursos As New CursoService()

    Private inscripcionSeleccionada As Inscripcion

    Private Sub FrmInscripciones_Load(sender As Object, e As EventArgs) Handles Me.Load
        dgvInscripciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvInscripciones.MultiSelect = False
        dgvInscripciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        cmbEstudiante.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCurso.DropDownStyle = ComboBoxStyle.DropDownList

        cmbEstado.Items.Clear()
        cmbEstado.Items.Add("Activa")
        cmbEstado.Items.Add("Pendiente")
        cmbEstado.Items.Add("Cancelada")

        cmbEstado.SelectedIndex = 0

        CargarCombos()
        CargarInscripciones()

    End Sub


    Private Sub CargarCombos()

        Try

            cmbEstudiante.DataSource = Nothing
            cmbEstudiante.DisplayMember = "Nombre"
            cmbEstudiante.ValueMember = "IdEstudiante"
            cmbEstudiante.DataSource = servicioEstudiantes.ObtenerTodos()

            cmbCurso.DataSource = Nothing
            cmbCurso.DisplayMember = "NombreCurso"
            cmbCurso.ValueMember = "IdCurso"
            cmbCurso.DataSource = servicioCursos.ObtenerTodos()

        Catch ex As Exception

            MessageBox.Show("Error al cargar estudiantes y cursos: " &
                            ex.GetBaseException().Message)

        End Try


    End Sub

    Private Sub CargarInscripciones()

        Try

            dgvInscripciones.DataSource = Nothing
            dgvInscripciones.DataSource = servicio.ObtenerTodos()

            ' Ocultar propiedades de navegación
            If dgvInscripciones.Columns.Contains("Estudiante") Then
                dgvInscripciones.Columns("Estudiante").Visible = False
            End If

            If dgvInscripciones.Columns.Contains("Curso") Then
                dgvInscripciones.Columns("Curso").Visible = False
            End If

            If dgvInscripciones.Columns.Contains("Pagos") Then
                dgvInscripciones.Columns("Pagos").Visible = False
            End If

        Catch ex As Exception

            MessageBox.Show("Error al cargar inscripciones: " &
                            ex.GetBaseException().Message)

        End Try

    End Sub


    Private Function ValidarDatos() As Boolean

        Dim monto As Decimal
        Dim descuento As Decimal

        If cmbEstudiante.SelectedValue Is Nothing Then
            MessageBox.Show("Seleccione un estudiante.")
            Return False
        End If

        If cmbCurso.SelectedValue Is Nothing Then
            MessageBox.Show("Seleccione un curso.")
            Return False
        End If

        If Not Decimal.TryParse(txtMonto.Text, monto) Then
            MessageBox.Show("Ingrese un monto válido.")
            Return False
        End If

        If Not Decimal.TryParse(txtDescuento.Text, descuento) Then
            MessageBox.Show("Ingrese un descuento válido. Escriba 0 si no aplica.")
            Return False
        End If

        If monto < 0 OrElse descuento < 0 OrElse descuento > monto Then
            MessageBox.Show("El monto o descuento no son válidos.")
            Return False
        End If

        If cmbEstado.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el estado de la inscripción.")
            Return False
        End If

        Return True

    End Function


    Private Sub LlenarInscripcion(inscripcion As Inscripcion)

        inscripcion.IdEstudiante = Convert.ToInt32(cmbEstudiante.SelectedValue)

        inscripcion.IdCurso = Convert.ToInt32(cmbCurso.SelectedValue)

        inscripcion.FechaInscripcion = dtpFechaInscripcion.Value

        inscripcion.Monto = Decimal.Parse(txtMonto.Text)

        inscripcion.Descuento = Decimal.Parse(txtDescuento.Text)

        inscripcion.Estado = cmbEstado.Text

        inscripcion.Observacion = txtObservacion.Text.Trim()

    End Sub

    Private Sub dgvInscripciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInscripciones.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        inscripcionSeleccionada = TryCast(
            dgvInscripciones.Rows(e.RowIndex).DataBoundItem,
            Inscripcion
        )

        If inscripcionSeleccionada Is Nothing Then Exit Sub

        cmbEstudiante.SelectedValue = inscripcionSeleccionada.IdEstudiante

        cmbCurso.SelectedValue = inscripcionSeleccionada.IdCurso

        If inscripcionSeleccionada.FechaInscripcion >= dtpFechaInscripcion.MinDate AndAlso
           inscripcionSeleccionada.FechaInscripcion <= dtpFechaInscripcion.MaxDate Then

            dtpFechaInscripcion.Value = inscripcionSeleccionada.FechaInscripcion

        End If

        txtMonto.Text = inscripcionSeleccionada.Monto.ToString()

        txtDescuento.Text = inscripcionSeleccionada.Descuento.ToString()

        cmbEstado.Text = inscripcionSeleccionada.Estado

        txtObservacion.Text = inscripcionSeleccionada.Observacion

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not ValidarDatos() Then Exit Sub

        Try

            Dim inscripcion As New Inscripcion()

            LlenarInscripcion(inscripcion)

            servicio.Guardar(inscripcion)

            MessageBox.Show("Inscripción guardada correctamente.")

            CargarInscripciones()

            LimpiarCampos()

        Catch ex As Exception

            MessageBox.Show("Error al guardar inscripción: " &
                            ex.GetBaseException().Message)

        End Try

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If inscripcionSeleccionada Is Nothing Then

            MessageBox.Show("Seleccione una inscripción.")

            Exit Sub

        End If

        If Not ValidarDatos() Then Exit Sub

        Try

            LlenarInscripcion(inscripcionSeleccionada)

            servicio.Actualizar(inscripcionSeleccionada)

            MessageBox.Show("Inscripción actualizada correctamente.")

            CargarInscripciones()

            LimpiarCampos()

        Catch ex As Exception

            MessageBox.Show("Error al actualizar inscripción: " &
                            ex.GetBaseException().Message)

        End Try

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If inscripcionSeleccionada Is Nothing Then

            MessageBox.Show("Seleccione una inscripción.")

            Exit Sub

        End If

        Dim respuesta = MessageBox.Show(
            "¿Desea eliminar esta inscripción?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If respuesta = DialogResult.Yes Then

            Try

                servicio.Eliminar(inscripcionSeleccionada)

                MessageBox.Show("Inscripción eliminada correctamente.")

                CargarInscripciones()

                LimpiarCampos()

            Catch ex As Exception

                MessageBox.Show("Error al eliminar inscripción: " &
                                ex.GetBaseException().Message)

            End Try

        End If

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarCampos()

    End Sub


    Private Sub LimpiarCampos()

        inscripcionSeleccionada = Nothing

        dtpFechaInscripcion.Value = Date.Today

        txtMonto.Clear()

        txtDescuento.Text = "0"

        txtObservacion.Clear()

        If cmbEstudiante.Items.Count > 0 Then
            cmbEstudiante.SelectedIndex = 0
        End If

        If cmbCurso.Items.Count > 0 Then
            cmbCurso.SelectedIndex = 0
        End If

        If cmbEstado.Items.Count > 0 Then
            cmbEstado.SelectedIndex = 0
        End If

    End Sub



End Class