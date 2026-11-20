Public Class EstudianteBLL
    Private ReadOnly datos As New EstudianteDAL()

    Public Function Listar(filtro As String) As List(Of Estudiante)
        Return datos.Listar(filtro)
    End Function

    Public Sub Guardar(e As Estudiante)
        Validador.Exigir(Not String.IsNullOrWhiteSpace(e.Nombres) AndAlso Not String.IsNullOrWhiteSpace(e.Apellidos), "Los nombres y los apellidos son obligatorios.")
        e.Cedula = Validador.SoloDigitos(e.Cedula)
        Validador.Exigir(e.Cedula.Length = 11, "La cédula debe tener 11 dígitos.")
        Validador.Exigir(Not datos.ExisteCedula(e.Cedula, e.IdPersona), "Ya existe una persona con esa cédula.")
        Validador.Exigir(e.FechaNacimiento <= Date.Today.AddYears(-3) AndAlso e.FechaNacimiento >= Date.Today.AddYears(-100),
                         "La fecha de nacimiento no es válida: el estudiante debe tener entre 3 y 100 años.")
        Validador.Exigir(e.FechaRegistro = Date.MinValue OrElse (e.FechaRegistro <= Date.Today AndAlso e.FechaRegistro > e.FechaNacimiento),
                         "La fecha de registro no puede ser futura ni anterior al nacimiento.")
        Validador.Exigir(String.IsNullOrWhiteSpace(e.Correo) OrElse Validador.CorreoValido(e.Correo), "El correo no es válido.")
        Validador.Exigir(String.IsNullOrWhiteSpace(e.Correo) OrElse Not datos.ExisteCorreo(e.Correo.Trim(), e.IdPersona), "Ese correo ya está registrado.")
        Validador.Exigir({"activo", "inactivo", "retirado"}.Contains(e.Estado), "El estado no es válido.")
        If e.IdEstudiante = 0 Then
            If e.FechaRegistro = Date.MinValue Then e.FechaRegistro = Date.Today
            datos.Insertar(e)
        Else
            datos.Actualizar(e)
        End If
    End Sub

    Public Sub Eliminar(e As Estudiante)
        Validador.Exigir(Not datos.TieneInscripciones(e.IdEstudiante), "El estudiante tiene inscripciones. Cambia su estado a retirado en lugar de eliminarlo.")
        Validador.EjecutarProtegido(Sub() datos.Eliminar(e.IdEstudiante, e.IdPersona), "No se puede eliminar: tiene datos relacionados.")
    End Sub
End Class
