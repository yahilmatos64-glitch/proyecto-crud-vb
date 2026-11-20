Imports System.ComponentModel
Imports System.Data

<DesignerCategory("Code")>
Public Class FrmDashboard
    Inherits Form

    Private ReadOnly reportes As New ReporteBLL()
    Private ReadOnly tarjetas As New FlowLayoutPanel()
    Private ReadOnly pestanas As New TabControl()
    Private ReadOnly rejillaMorosos As New DataGridView()
    Private ReadOnly rejillaMetodos As New DataGridView()
    Private ReadOnly rejillaOcupacion As New DataGridView()
    Private ReadOnly rejillaBusqueda As New DataGridView()
    Private ReadOnly txtBusqueda As New TextBox()

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        ConstruirInterfaz()
        Cargar()
    End Sub

    Private Sub ConstruirInterfaz()
        Text = "Dashboard y reportes"
        Font = New Font("Segoe UI", 9.5F)
        Size = New Size(1100, 700)
        StartPosition = FormStartPosition.CenterParent
        BackColor = Color.FromArgb(245, 247, 250)

        tarjetas.Dock = DockStyle.Top
        tarjetas.Height = 110
        tarjetas.Padding = New Padding(12, 10, 12, 0)

        pestanas.Dock = DockStyle.Fill
        pestanas.TabPages.Add(CrearPestana("Morosos", rejillaMorosos))
        pestanas.TabPages.Add(CrearPestana("Ingresos por método", rejillaMetodos))
        pestanas.TabPages.Add(CrearPestana("Ocupación de grupos", rejillaOcupacion))

        Dim busqueda As New TabPage("Buscar estudiantes")
        txtBusqueda.Dock = DockStyle.Top
        AddHandler txtBusqueda.TextChanged, AddressOf Buscar
        Rejillas.Preparar(rejillaBusqueda)
        busqueda.Controls.Add(rejillaBusqueda)
        busqueda.Controls.Add(txtBusqueda)
        busqueda.Controls.Add(New Label With {.Text = "Escribe un nombre o una cédula:", .Dock = DockStyle.Top, .Height = 24})
        pestanas.TabPages.Add(busqueda)

        Dim actualizar As New Button With {.Text = "Actualizar", .Dock = DockStyle.Bottom, .Height = 36}
        AddHandler actualizar.Click, Sub(remitente, argumentos) Cargar()

        Controls.Add(pestanas)
        Controls.Add(actualizar)
        Controls.Add(tarjetas)
    End Sub

    Private Shared Function CrearPestana(titulo As String, rejilla As DataGridView) As TabPage
        Dim pagina As New TabPage(titulo)
        Rejillas.Preparar(rejilla)
        pagina.Controls.Add(rejilla)
        Return pagina
    End Function

    Private Sub AgregarTarjeta(valor As String, descripcion As String)
        Dim panel As New Panel With {.Size = New Size(190, 84), .BackColor = Color.White, .Margin = New Padding(6)}
        panel.Controls.Add(New Label With {.Text = valor, .Font = New Font("Segoe UI", 16.0F, FontStyle.Bold), .ForeColor = Color.FromArgb(31, 78, 121), .AutoSize = True, .Location = New Point(10, 10)})
        panel.Controls.Add(New Label With {.Text = descripcion, .ForeColor = Color.Gray, .AutoSize = True, .Location = New Point(12, 52)})
        tarjetas.Controls.Add(panel)
    End Sub

    Private Sub Cargar()
        Try
            Dim resumen As DataRow = reportes.Resumen()
            tarjetas.Controls.Clear()
            AgregarTarjeta(Convert.ToString(resumen("estudiantes_activos")), "Estudiantes activos")
            AgregarTarjeta(Convert.ToString(resumen("grupos_abiertos")), "Grupos abiertos")
            AgregarTarjeta(Convert.ToString(resumen("inscripciones_activas")), "Inscripciones activas")
            AgregarTarjeta("RD$ " & Convert.ToDecimal(resumen("ingresos_totales")).ToString("N2"), "Ingresos totales")
            AgregarTarjeta("RD$ " & Convert.ToDecimal(resumen("por_cobrar")).ToString("N2"), "Por cobrar")
            rejillaMorosos.DataSource = reportes.Morosos()
            rejillaMetodos.DataSource = reportes.IngresosPorMetodo()
            rejillaOcupacion.DataSource = reportes.OcupacionPorGrupo()
            For Each rejilla As DataGridView In {rejillaMorosos, rejillaMetodos, rejillaOcupacion}
                Rejillas.AjustarColumnas(rejilla)
            Next
            Buscar(Nothing, EventArgs.Empty)
        Catch ex As Exception
            MessageBox.Show("No se pudieron cargar las estadísticas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Buscar(remitente As Object, e As EventArgs)
        rejillaBusqueda.DataSource = reportes.BuscarEstudiantes(txtBusqueda.Text.Trim())
        Rejillas.AjustarColumnas(rejillaBusqueda)
    End Sub
End Class
