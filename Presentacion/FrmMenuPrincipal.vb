Public Class FrmMenuPrincipal
    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click


        Dim respuesta = MessageBox.Show(
        "¿Desea cerrar la sesión?",
        "Cerrar sesión",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If respuesta = DialogResult.Yes Then

            Dim login As New FrmLogin()

            login.Show()

            Me.Close()

        End If


    End Sub

    Private Sub EstudiantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstudiantesToolStripMenuItem.Click

        Using formulario As New FrmEstudiantes()
            formulario.ShowDialog(Me)
        End Using

    End Sub

    Private Sub ProfesoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfesoresToolStripMenuItem.Click

        Using formulario As New FrmProfesores()
            formulario.ShowDialog(Me)
        End Using

    End Sub

    Private Sub IdiomasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IdiomasToolStripMenuItem.Click
        Using formulario As New FrmIdiomas()
            formulario.ShowDialog(Me)
        End Using
    End Sub

    Private Sub AulasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AulasToolStripMenuItem.Click
        Using formulario As New FrmAulas()
            formulario.ShowDialog(Me)
        End Using
    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        Using formulario As New FrmUsuarios()
            formulario.ShowDialog(Me)
        End Using
    End Sub

    Private Sub CursosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CursosToolStripMenuItem.Click

        Using formulario As New FrmCursos()
            formulario.ShowDialog(Me)
        End Using

    End Sub

    Private Sub InscripcionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InscripcionesToolStripMenuItem.Click
        Using formulario As New FrmInscripciones()
            formulario.ShowDialog(Me)
        End Using
    End Sub

    Private Sub PagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosToolStripMenuItem.Click
        Using formulario As New FrmPagos()
            formulario.ShowDialog(Me)
        End Using
    End Sub

    Private Sub EstadísticasToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        Using formulario As New FrmDashboard()
            formulario.ShowDialog(Me)
        End Using
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click


        Dim respuesta = MessageBox.Show(
        "¿Está seguro de que desea salir del sistema?",
        "Salir",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If respuesta = DialogResult.Yes Then

            Application.Exit()

        End If

    End Sub

End Class