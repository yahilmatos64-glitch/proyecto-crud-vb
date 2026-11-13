Imports Negocio
Imports Entidad

Public Class FrmPagos
    Private ReadOnly servicio As New PagoService()
    Private ReadOnly servicioInscripciones As New InscripcionService()

    Private pagoSeleccionado As Pago

    Private Sub FrmPagos_Load(sender As Object, e As EventArgs) Handles Me.Load
        dgvPagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPagos.MultiSelect = False
        dgvPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        cmbInscripcion.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList
        cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList

        cmbMetodoPago.Items.Clear()
        cmbMetodoPago.Items.Add("Efectivo")
        cmbMetodoPago.Items.Add("Transferencia")
        cmbMetodoPago.Items.Add("Tarjeta")

        cmbEstado.Items.Clear()
        cmbEstado.Items.Add("Pagado")
        cmbEstado.Items.Add("Pendiente")
        cmbEstado.Items.Add("Anulado")

        CargarInscripciones()
        CargarPagos()

    End Sub


    Private Sub CargarInscripciones()

        Try

            cmbInscripcion.DataSource = Nothing

            cmbInscripcion.DisplayMember = "IdInscripcion"
            cmbInscripcion.ValueMember = "IdInscripcion"

            cmbInscripcion.DataSource = servicioInscripciones.ObtenerTodos()

        Catch ex As Exception

            MessageBox.Show("Error al cargar inscripciones: " &
                            ex.GetBaseException().Message)

        End Try

    End Sub


    Private Sub CargarPagos()

        Try

            dgvPagos.DataSource = Nothing
            dgvPagos.DataSource = servicio.ObtenerTodos()

            If dgvPagos.Columns.Contains("Inscripcion") Then
                dgvPagos.Columns("Inscripcion").Visible = False
            End If

        Catch ex As Exception

            MessageBox.Show("Error al cargar pagos: " &
                            ex.GetBaseException().Message)

        End Try

    End Sub


    Private Function ValidarDatos() As Boolean

        Dim monto As Decimal

        If cmbInscripcion.SelectedValue Is Nothing Then
            MessageBox.Show("Seleccione una inscripción.")
            Return False
        End If

        If Not Decimal.TryParse(txtMonto.Text, monto) Then
            MessageBox.Show("Introduzca un monto válido.")
            Return False
        End If

        If monto <= 0 Then
            MessageBox.Show("El monto debe ser mayor que cero.")
            Return False
        End If

        If cmbMetodoPago.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un método de pago.")
            Return False
        End If

        If cmbEstado.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el estado del pago.")
            Return False
        End If

        Return True

    End Function


    Private Sub LlenarPago(pago As Pago)

        pago.IdInscripcion = Convert.ToInt32(cmbInscripcion.SelectedValue)

        pago.FechaPago = dtpFechaPago.Value

        pago.Monto = Decimal.Parse(txtMonto.Text)

        pago.MetodoPago = cmbMetodoPago.Text

        pago.Referencia = txtReferencia.Text.Trim()

        pago.Estado = cmbEstado.Text

        pago.Observacion = txtObservacion.Text.Trim()

    End Sub

    Private Sub dgvPagos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPagos.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        pagoSeleccionado = TryCast(
            dgvPagos.Rows(e.RowIndex).DataBoundItem,
            Pago
        )

        If pagoSeleccionado Is Nothing Then Exit Sub

        cmbInscripcion.SelectedValue = pagoSeleccionado.IdInscripcion

        dtpFechaPago.Value = pagoSeleccionado.FechaPago

        txtMonto.Text = pagoSeleccionado.Monto.ToString()

        cmbMetodoPago.Text = pagoSeleccionado.MetodoPago

        txtReferencia.Text = pagoSeleccionado.Referencia

        cmbEstado.Text = pagoSeleccionado.Estado

        txtObservacion.Text = pagoSeleccionado.Observacion

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not ValidarDatos() Then Exit Sub

        Try

            Dim pago As New Pago()

            LlenarPago(pago)

            servicio.Guardar(pago)

            MessageBox.Show("Pago registrado correctamente.")

            CargarPagos()

            LimpiarCampos()

        Catch ex As Exception

            MessageBox.Show("Error al registrar pago: " &
                            ex.GetBaseException().Message)

        End Try

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If pagoSeleccionado Is Nothing Then

            MessageBox.Show("Seleccione un pago.")

            Exit Sub

        End If

        If Not ValidarDatos() Then Exit Sub

        Try

            LlenarPago(pagoSeleccionado)

            servicio.Actualizar(pagoSeleccionado)

            MessageBox.Show("Pago actualizado correctamente.")

            CargarPagos()

            LimpiarCampos()

        Catch ex As Exception

            MessageBox.Show("Error al actualizar pago: " &
                            ex.GetBaseException().Message)

        End Try

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If pagoSeleccionado Is Nothing Then

            MessageBox.Show("Seleccione un pago.")

            Exit Sub

        End If

        If MessageBox.Show(
            "¿Desea eliminar este pago?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        ) = DialogResult.Yes Then

            Try

                servicio.Eliminar(pagoSeleccionado)

                MessageBox.Show("Pago eliminado correctamente.")

                CargarPagos()

                LimpiarCampos()

            Catch ex As Exception

                MessageBox.Show("Error al eliminar pago: " &
                                ex.GetBaseException().Message)

            End Try

        End If

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarCampos()

    End Sub


    Private Sub LimpiarCampos()

        pagoSeleccionado = Nothing

        dtpFechaPago.Value = Date.Today

        txtMonto.Clear()

        txtReferencia.Clear()

        txtObservacion.Clear()

        If cmbInscripcion.Items.Count > 0 Then
            cmbInscripcion.SelectedIndex = 0
        End If

        cmbMetodoPago.SelectedIndex = -1

        cmbEstado.SelectedIndex = 0

        txtMonto.Focus()

    End Sub

    Private Sub txtObservacion_TextChanged(sender As Object, e As EventArgs) Handles txtObservacion.TextChanged

    End Sub
End Class
