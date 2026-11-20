Imports System.Text.RegularExpressions

Friend NotInheritable Class Rejillas
    Private Sub New()
    End Sub

    Private Shared ReadOnly Titulos As New Dictionary(Of String, String) From {
        {"Cedula", "Cédula"},
        {"Telefono", "Teléfono"},
        {"Direccion", "Dirección"},
        {"Ubicacion", "Ubicación"},
        {"Duracion Horas", "Duración (horas)"},
        {"Inscripcion", "Inscripción"},
        {"Fecha Inscripcion", "Fecha de inscripción"},
        {"Metodo", "Método"},
        {"Num Recibo", "N.º de recibo"},
        {"Fecha Nacimiento", "Fecha de nacimiento"},
        {"Fecha Registro", "Fecha de registro"},
        {"Fecha Contratacion", "Fecha de contratación"},
        {"Nombre Persona", "Persona"},
        {"Cupo Maximo", "Cupo máximo"},
        {"Hora Inicio", "Hora de inicio"},
        {"Hora Fin", "Hora de fin"},
        {"Fecha Inicio", "Fecha de inicio"},
        {"Fecha Fin", "Fecha de fin"},
        {"Fecha Pago", "Fecha del pago"},
        {"Dias", "Días"},
        {"Ocupacion", "Ocupación"}
    }

    Public Shared Sub Preparar(rejilla As DataGridView)
        rejilla.Dock = DockStyle.Fill
        rejilla.ReadOnly = True
        rejilla.AllowUserToAddRows = False
        rejilla.AllowUserToDeleteRows = False
        rejilla.MultiSelect = False
        rejilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        rejilla.RowHeadersVisible = False
        rejilla.BackgroundColor = Color.White
        rejilla.BorderStyle = BorderStyle.None
        rejilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        rejilla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 78, 121)
        rejilla.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        rejilla.EnableHeadersVisualStyles = False
    End Sub

    Public Shared Sub AjustarColumnas(rejilla As DataGridView)
        For Each columna As DataGridViewColumn In rejilla.Columns
            Dim titulo As String = Regex.Replace(columna.Name, "(?<=[a-z])(?=[A-Z])", " ")
            columna.HeaderText = If(Titulos.ContainsKey(titulo), Titulos(titulo), titulo)
            If Regex.IsMatch(columna.Name, "^Id[A-Z]") OrElse columna.Name.StartsWith("Contrasena") OrElse columna.Name = "NombreCompleto" Then
                columna.Visible = False
            End If
            If columna.ValueType Is GetType(Date) Then
                columna.DefaultCellStyle.Format = "dd/MM/yyyy"
            ElseIf columna.ValueType Is GetType(Decimal) Then
                columna.DefaultCellStyle.Format = "N2"
                columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        Next
        rejilla.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
    End Sub
End Class
