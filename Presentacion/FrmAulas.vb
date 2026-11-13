Imports Negocio
Imports Entidad

Public Class FrmAulas
    Private ReadOnly servicio As New AulaService()
    Private aulaSeleccionada As Aula

    Private Sub FrmAulas_Load(sender As Object, e As EventArgs) Handles Me.Load
        dgvAulas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAulas.MultiSelect = False
        dgvAulas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        chkEstado.Checked = True

        CargarAulas()

    End Sub

    Private Sub CargarAulas()

        Try
            dgvAulas.DataSource = Nothing
            dgvAulas.DataSource = servicio.ObtenerTodos()
        Catch ex As Exception
            MessageBox.Show("Error al cargar aulas: " & ex.GetBaseException().Message)
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
                ElseIf propiedad.PropertyType Is GetType(Integer) Then
                    propiedad.SetValue(entidad, Convert.ToInt32(valor))
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

    Private Function EstadoAula(entidad As Object) As Boolean
        Dim valor = LeerPropiedad(entidad, "Estado", "Activo")
        If valor Is Nothing Then Return True

        Dim textoEstado = valor.ToString().ToLower().Trim()
        Return textoEstado = "true" OrElse textoEstado = "1" OrElse textoEstado = "activo" OrElse textoEstado = "si"
    End Function

    Private Sub dgvAulas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAulas.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        aulaSeleccionada = TryCast(dgvAulas.Rows(e.RowIndex).DataBoundItem, Aula)
        If aulaSeleccionada Is Nothing Then Exit Sub

        txtNombreAula.Text = Texto(aulaSeleccionada, "NombreAula", "Nombre", "Aula", "Numero")
        txtCapacidad.Text = Texto(aulaSeleccionada, "Capacidad")
        txtUbicacion.Text = Texto(aulaSeleccionada, "Ubicacion", "Ubicación")
        txtTipo.Text = Texto(aulaSeleccionada, "Tipo")
        txtEquipamiento.Text = Texto(aulaSeleccionada, "Equipamiento")
        txtDescripcion.Text = Texto(aulaSeleccionada, "Descripcion", "Descripción")
        chkEstado.Checked = EstadoAula(aulaSeleccionada)


    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombreAula.Text.Trim() = "" Then
            MessageBox.Show("Escriba el nombre del aula.")
            Exit Sub
        End If

        Dim capacidad As Integer
        If Not Integer.TryParse(txtCapacidad.Text, capacidad) Then
            MessageBox.Show("La capacidad debe ser numérica.")
            Exit Sub
        End If

        Try
            Dim aula As New Aula()

            AsignarPropiedad(aula, txtNombreAula.Text.Trim(), "NombreAula", "Nombre", "Aula", "Numero")
            AsignarPropiedad(aula, capacidad, "Capacidad")
            AsignarPropiedad(aula, txtUbicacion.Text.Trim(), "Ubicacion", "Ubicación")
            AsignarPropiedad(aula, txtTipo.Text.Trim(), "Tipo")
            AsignarPropiedad(aula, txtEquipamiento.Text.Trim(), "Equipamiento")
            AsignarPropiedad(aula, txtDescripcion.Text.Trim(), "Descripcion", "Descripción")
            AsignarPropiedad(aula, chkEstado.Checked, "Estado", "Activo")

            servicio.Guardar(aula)

            MessageBox.Show("Aula guardada correctamente.")
            CargarAulas()
            LimpiarCampos()

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.GetBaseException().Message)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If aulaSeleccionada Is Nothing Then
            MessageBox.Show("Seleccione un aula.")
            Exit Sub
        End If

        Dim capacidad As Integer
        If Not Integer.TryParse(txtCapacidad.Text, capacidad) Then
            MessageBox.Show("La capacidad debe ser numérica.")
            Exit Sub
        End If

        Try
            AsignarPropiedad(aulaSeleccionada, txtNombreAula.Text.Trim(), "NombreAula", "Nombre", "Aula", "Numero")
            AsignarPropiedad(aulaSeleccionada, capacidad, "Capacidad")
            AsignarPropiedad(aulaSeleccionada, txtUbicacion.Text.Trim(), "Ubicacion", "Ubicación")
            AsignarPropiedad(aulaSeleccionada, txtTipo.Text.Trim(), "Tipo")
            AsignarPropiedad(aulaSeleccionada, txtEquipamiento.Text.Trim(), "Equipamiento")
            AsignarPropiedad(aulaSeleccionada, txtDescripcion.Text.Trim(), "Descripcion", "Descripción")
            AsignarPropiedad(aulaSeleccionada, chkEstado.Checked, "Estado", "Activo")

            servicio.Actualizar(aulaSeleccionada)

            MessageBox.Show("Aula actualizada correctamente.")
            CargarAulas()
            LimpiarCampos()

        Catch ex As Exception
            MessageBox.Show("Error al actualizar: " & ex.GetBaseException().Message)
        End Try

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If aulaSeleccionada Is Nothing Then
            MessageBox.Show("Seleccione un aula.")
            Exit Sub
        End If

        If MessageBox.Show("¿Desea eliminar esta aula?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                servicio.Eliminar(aulaSeleccionada)
                MessageBox.Show("Aula eliminada correctamente.")
                CargarAulas()
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

        aulaSeleccionada = Nothing

        txtNombreAula.Clear()
        txtCapacidad.Clear()
        txtUbicacion.Clear()
        txtTipo.Clear()
        txtEquipamiento.Clear()
        txtDescripcion.Clear()

        chkEstado.Checked = True
        txtNombreAula.Focus()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
