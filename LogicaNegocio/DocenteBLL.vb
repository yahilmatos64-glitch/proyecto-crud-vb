Public Class DocenteBLL
    Private ReadOnly datos As New DocenteDAL()
    Private ReadOnly personas As New EstudianteDAL()

    Public Function Listar(filtro As String) As List(Of Docente)
        Return datos.Listar(filtro)
    End Function

    Public Sub Guardar(d As Docente)
        Validador.Exigir(Not String.IsNullOrWhiteSpace(d.Nombres) AndAlso Not String.IsNullOrWhiteSpace(d.Apellidos), "Los nombres y los apellidos son obligatorios.")
        d.Cedula = Validador.SoloDigitos(d.Cedula)
        Validador.Exigir(d.Cedula.Length = 11, "La cédula debe tener 11 dígitos.")
        Validador.Exigir(Not personas.ExisteCedula(d.Cedula, d.IdPersona), "Ya existe una persona con esa cédula.")
        Validador.Exigir(d.FechaNacimiento <= Date.Today.AddYears(-18) AndAlso d.FechaNacimiento >= Date.Today.AddYears(-100),
                         "La fecha de nacimiento no es válida: el docente debe tener entre 18 y 100 años.")
        Validador.Exigir(String.IsNullOrWhiteSpace(d.Correo) OrElse Validador.CorreoValido(d.Correo), "El correo no es válido.")
        Validador.Exigir(String.IsNullOrWhiteSpace(d.Correo) OrElse Not personas.ExisteCorreo(d.Correo.Trim(), d.IdPersona), "Ese correo ya está registrado.")
        Validador.Exigir(Not String.IsNullOrWhiteSpace(d.Especialidad), "La especialidad es obligatoria.")
        Validador.Exigir(d.FechaContratacion <= Date.Today, "La fecha de contratación no puede ser futura.")
        Validador.Exigir(d.FechaContratacion >= d.FechaNacimiento.AddYears(18), "La fecha de contratación no es válida: el docente tenía menos de 18 años.")
        If d.IdDocente = 0 Then
            datos.Insertar(d)
        Else
            datos.Actualizar(d)
        End If
    End Sub

    Public Sub Eliminar(d As Docente)
        Validador.Exigir(Not datos.TieneGrupos(d.IdDocente), "El docente tiene grupos asignados.")
        Validador.EjecutarProtegido(Sub() datos.Eliminar(d.IdDocente, d.IdPersona), "No se puede eliminar: tiene datos relacionados.")
    End Sub
End Class
