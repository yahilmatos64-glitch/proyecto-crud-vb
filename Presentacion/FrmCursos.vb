Imports Negocio
Imports Entidad

Public Class FrmCursos

    Private ReadOnly servicio As New CursoService()
    Private ReadOnly servicioIdiomas As New IdiomaService()
    Private ReadOnly servicioProfesores As New ProfesorService()

    Private cursoSeleccionado As Curso

    Private Sub FrmCursos_Load(sender As Object, e As EventArgs) Handles Me.Load
        dgvCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCursos.MultiSelect = False
        dgvCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        chkEstado.Checked = True

        CargarCombos()
        CargarCursos()

    End Sub

    Private Sub CargarCombos()

        Try
            cmbIdioma.DataSource = Nothing
            cmbIdioma.DisplayMember = "NombreIdioma"
            cmbIdioma.ValueMember = "IdIdioma"
            cmbIdioma.DataSource = servicioIdiomas.ObtenerTodos()

            cmbProfesor.DataSource = Nothing
            cmbProfesor.DisplayMember = "Nombre"
            cmbProfesor.ValueMember = "IdProfesor"
            cmbProfesor.DataSource = servicioProfesores.ObtenerTodos()

        Catch ex As Exception
            MessageBox.Show("Error al cargar combos: " & ex.GetBaseException().Message)
        End Try

    End Sub

    Private Sub CargarCursos()

        Try
            dgvCursos.DataSource = Nothing
            dgvCursos.DataSource = servicio.ObtenerTodos()
        Catch ex As Exception
            MessageBox.Show("Error al cargar cursos: " & ex.GetBaseException().Message)
        End Try

    End Sub
    Private Function Texto(entidad As Object, ParamArray nombres As String()) As String

        For Each nombre In nombres
            Dim propiedad = entidad.GetType().GetProperty(nombre)
            If propiedad IsNot Nothing AndAlso propiedad.CanRead Then
                Dim valor = propiedad.GetValue(entidad, Nothing)
                If valor IsNot Nothing Then Return Convert.ToString(valor)
            End If
        Next

        Return ""

    End Function

    Private Function LeerEntero(entidad As Object, ParamArray nombres As String()) As Integer

        For Each nombre In nombres
            Dim propiedad = entidad.GetType().GetProperty(nombre)
            If propiedad IsNot Nothing AndAlso propiedad.CanRead Then
                Dim valor = propiedad.GetValue(entidad, Nothing)
                If valor IsNot Nothing Then Return Convert.ToInt32(valor)
            End If
        Next

        Return 0

    End Function

    Private Sub AsignarValor(entidad As Object, valor As Object, ParamArray nombres As String())

        For Each nombre In nombres
            Dim propiedad = entidad.GetType().GetProperty(nombre)
            If propiedad IsNot Nothing AndAlso propiedad.CanWrite Then

                If propiedad.PropertyType Is GetType(String) Then
                    propiedad.SetValue(entidad, Convert.ToString(valor))
                ElseIf propiedad.PropertyType Is GetType(Integer) Then
                    propiedad.SetValue(entidad, Convert.ToInt32(valor))
                ElseIf propiedad.PropertyType Is GetType(Decimal) Then
                    propiedad.SetValue(entidad, Convert.ToDecimal(valor))
                ElseIf propiedad.PropertyType Is GetType(Boolean) Then
                    propiedad.SetValue(entidad, Convert.ToBoolean(valor))
                Else
                    propiedad.SetValue(entidad, Convert.ChangeType(valor, propiedad.PropertyType))
                End If

                Exit Sub
            End If
        Next

    End Sub
    Private Function EstadoCurso(entidad As Object) As Boolean

        Dim propiedad = entidad.GetType().GetProperty("Estado")
        If propiedad Is Nothing Then Return True

        Dim valor = propiedad.GetValue(entidad, Nothing)
        If valor Is Nothing Then Return True

        If TypeOf valor Is Boolean Then Return CBool(valor)

        Dim textoEstado = valor.ToString().ToLower().Trim()
        Return textoEstado = "true" OrElse textoEstado = "1" OrElse textoEstado = "activo" OrElse textoEstado = "si"

    End Function

    Private Sub dgvCursos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCursos.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        cursoSeleccionado = TryCast(dgvCursos.Rows(e.RowIndex).DataBoundItem, Curso)
        If cursoSeleccionado Is Nothing Then Exit Sub

        txtNombreCurso.Text = Texto(cursoSeleccionado, "NombreCurso")
        txtHorario.Text = Texto(cursoSeleccionado, "Horario")
        txtDuracion.Text = Texto(cursoSeleccionado, "Duracion")
        txtCosto.Text = Texto(cursoSeleccionado, "Costo")
        txtNivel.Text = Texto(cursoSeleccionado, "Nivel")
        chkEstado.Checked = EstadoCurso(cursoSeleccionado)

        Dim idIdioma As Integer = LeerEntero(cursoSeleccionado, "IdIdioma")
        If idIdioma > 0 Then cmbIdioma.SelectedValue = idIdioma

        Dim idProfesor As Integer = LeerEntero(cursoSeleccionado, "IdProfesor")
        If idProfesor > 0 Then cmbProfesor.SelectedValue = idProfesor

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombreCurso.Text.Trim() = "" Then
            MessageBox.Show("Escriba el nombre del curso.")
            Exit Sub
        End If

        Dim costo As Decimal
        If Not Decimal.TryParse(txtCosto.Text, costo) Then
            MessageBox.Show("El costo debe ser numérico.")
            Exit Sub
        End If

        If cmbIdioma.SelectedValue Is Nothing OrElse cmbProfesor.SelectedValue Is Nothing Then
            MessageBox.Show("Seleccione un idioma y un profesor.")
            Exit Sub
        End If

        Try
            Dim curso As New Curso()

            AsignarValor(curso, txtNombreCurso.Text.Trim(), "NombreCurso")
            AsignarValor(curso, CInt(cmbIdioma.SelectedValue), "IdIdioma")
            AsignarValor(curso, CInt(cmbProfesor.SelectedValue), "IdProfesor")
            AsignarValor(curso, txtHorario.Text.Trim(), "Horario")
            AsignarValor(curso, txtDuracion.Text.Trim(), "Duracion")
            AsignarValor(curso, costo, "Costo")
            AsignarValor(curso, txtNivel.Text.Trim(), "Nivel")
            AsignarValor(curso, chkEstado.Checked, "Estado")

            servicio.Guardar(curso)

            MessageBox.Show("Curso guardado correctamente.")
            CargarCursos()
            LimpiarCampos()

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.GetBaseException().Message)
        End Try

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If cursoSeleccionado Is Nothing Then
            MessageBox.Show("Seleccione un curso.")
            Exit Sub
        End If

        Dim costo As Decimal
        If Not Decimal.TryParse(txtCosto.Text, costo) Then
            MessageBox.Show("El costo debe ser numérico.")
            Exit Sub
        End If

        If cmbIdioma.SelectedValue Is Nothing OrElse cmbProfesor.SelectedValue Is Nothing Then
            MessageBox.Show("Seleccione un idioma y un profesor.")
            Exit Sub
        End If

        Try
            AsignarValor(cursoSeleccionado, txtNombreCurso.Text.Trim(), "NombreCurso")
            AsignarValor(cursoSeleccionado, CInt(cmbIdioma.SelectedValue), "IdIdioma")
            AsignarValor(cursoSeleccionado, CInt(cmbProfesor.SelectedValue), "IdProfesor")
            AsignarValor(cursoSeleccionado, txtHorario.Text.Trim(), "Horario")
            AsignarValor(cursoSeleccionado, txtDuracion.Text.Trim(), "Duracion")
            AsignarValor(cursoSeleccionado, costo, "Costo")
            AsignarValor(cursoSeleccionado, txtNivel.Text.Trim(), "Nivel")
            AsignarValor(cursoSeleccionado, chkEstado.Checked, "Estado")

            servicio.Actualizar(cursoSeleccionado)

            MessageBox.Show("Curso actualizado correctamente.")
            CargarCursos()
            LimpiarCampos()

        Catch ex As Exception
            MessageBox.Show("Error al actualizar: " & ex.GetBaseException().Message)
        End Try

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If cursoSeleccionado Is Nothing Then
            MessageBox.Show("Seleccione un curso.")
            Exit Sub
        End If

        If MessageBox.Show("¿Desea eliminar este curso?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                servicio.Eliminar(cursoSeleccionado)
                MessageBox.Show("Curso eliminado correctamente.")
                CargarCursos()
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

        cursoSeleccionado = Nothing

        txtNombreCurso.Clear()
        txtHorario.Clear()
        txtDuracion.Clear()
        txtCosto.Clear()
        txtNivel.Clear()

        chkEstado.Checked = True

        If cmbIdioma.Items.Count > 0 Then cmbIdioma.SelectedIndex = 0
        If cmbProfesor.Items.Count > 0 Then cmbProfesor.SelectedIndex = 0

        txtNombreCurso.Focus()

    End Sub

End Class