Imports Negocio
Imports System.Linq

Public Class FrmDashboard
    Private ReadOnly usuarios As New UsuarioService()
    Private ReadOnly estudiantes As New EstudianteService()
    Private ReadOnly profesores As New ProfesorService()
    Private ReadOnly idiomas As New IdiomaService()
    Private ReadOnly cursos As New CursoService()
    Private ReadOnly inscripciones As New InscripcionService()
    Private ReadOnly pagos As New PagoService()
    Private ReadOnly aulas As New AulaService()

    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarEstadisticas()
    End Sub

    Private Sub CargarEstadisticas()

        Try

            lblTotalUsuarios.Text = usuarios.ObtenerTodos().Count().ToString()

            lblTotalEstudiantes.Text = estudiantes.ObtenerTodos().Count().ToString()

            lblTotalProfesores.Text = profesores.ObtenerTodos().Count().ToString()

            lblTotalIdiomas.Text = idiomas.ObtenerTodos().Count().ToString()

            lblTotalCursos.Text = cursos.ObtenerTodos().Count().ToString()

            lblTotalInscripciones.Text = inscripciones.ObtenerTodos().Count().ToString()

            lblTotalPagos.Text = pagos.ObtenerTodos().Count().ToString()

            lblTotalAulas.Text = aulas.ObtenerTodos().Count().ToString()

        Catch ex As Exception

            MessageBox.Show(
                "Error al cargar las estadísticas: " &
                ex.GetBaseException().Message
            )

        End Try

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        CargarEstadisticas()

        MessageBox.Show("Estadísticas actualizadas correctamente.")


    End Sub



End Class