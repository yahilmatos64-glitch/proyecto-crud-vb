Public Class FrmMenuPrincipal
    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EstudiantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstudiantesToolStripMenuItem.Click

        Dim form As New FrmEstudiantes()

        form.Show()

    End Sub
End Class