Imports System.Collections
Imports System.ComponentModel
Imports System.Reflection

<DesignerCategory("Code")>
Public MustInherit Class FormMantenimiento
    Inherits Form

    Private Shared ReadOnly NombresDias As String() = {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado"}

    Private ReadOnly controles As New Dictionary(Of String, Control)()
    Private ReadOnly rejilla As New DataGridView()
    Private ReadOnly txtBuscar As New TextBox()
    Private campos As List(Of CampoFormulario) = New List(Of CampoFormulario)()
    Private seleccionado As Object
    Private suspendido As Boolean

    Protected MustOverride ReadOnly Property Titulo As String
    Protected MustOverride ReadOnly Property TipoEntidad As Type
    Protected MustOverride Function DefinirCampos() As List(Of CampoFormulario)
    Protected MustOverride Function ListarEntidades(filtro As String) As IList
    Protected MustOverride Sub GuardarEntidad(entidad As Object)
    Protected MustOverride Sub EliminarEntidad(entidad As Object)

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        ConstruirInterfaz()
        Recargar()
    End Sub

    Private Sub ConstruirInterfaz()
        Text = Titulo
        Font = New Font("Segoe UI", 9.5F)
        Size = New Size(1180, 700)
        MinimumSize = New Size(960, 580)
        StartPosition = FormStartPosition.CenterParent
        BackColor = Color.FromArgb(245, 247, 250)
        campos = DefinirCampos()

        Dim panelDatos As New TableLayoutPanel With {
            .Dock = DockStyle.Fill, .AutoScroll = True, .ColumnCount = 2, .Padding = New Padding(4)
        }
        panelDatos.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 120))
        panelDatos.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100))
        For Each campo As CampoFormulario In campos
            Dim control As Control = CrearControl(campo)
            controles(campo.Propiedad) = control
            panelDatos.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            panelDatos.RowCount += 1
            panelDatos.Controls.Add(New Label With {.Text = campo.Etiqueta, .AutoSize = True, .Anchor = AnchorStyles.Left Or AnchorStyles.Top, .Margin = New Padding(3, 8, 3, 3)})
            panelDatos.Controls.Add(control)
        Next

        Dim botones As New FlowLayoutPanel With {.Dock = DockStyle.Bottom, .Height = 56, .Padding = New Padding(4, 10, 4, 4), .WrapContents = False}
        botones.Controls.Add(CrearBoton("Nuevo", AddressOf Nuevo))
        botones.Controls.Add(CrearBoton("Guardar", AddressOf Guardar, True))
        botones.Controls.Add(CrearBoton("Eliminar", AddressOf Eliminar))
        botones.Controls.Add(CrearBoton("Cerrar", AddressOf Close))

        Dim izquierda As New Panel With {.Dock = DockStyle.Left, .Width = 400, .Padding = New Padding(12)}
        izquierda.Controls.Add(panelDatos)
        izquierda.Controls.Add(botones)

        txtBuscar.Dock = DockStyle.Top
        AddHandler txtBuscar.TextChanged, AddressOf BuscarCambio
        Dim etiquetaBuscar As New Label With {.Text = "Buscar:", .Dock = DockStyle.Top, .Height = 22}

        Rejillas.Preparar(rejilla)
        AddHandler rejilla.SelectionChanged, AddressOf FilaSeleccionada

        Dim derecha As New Panel With {.Dock = DockStyle.Fill, .Padding = New Padding(12)}
        derecha.Controls.Add(rejilla)
        derecha.Controls.Add(txtBuscar)
        derecha.Controls.Add(etiquetaBuscar)

        Controls.Add(derecha)
        Controls.Add(izquierda)
    End Sub

    Private Function CrearBoton(texto As String, accion As Action, Optional principal As Boolean = False) As Button
        Dim boton As New Button With {.Text = texto, .Width = 82, .Height = 32, .FlatStyle = FlatStyle.Flat}
        If principal Then
            boton.BackColor = Color.FromArgb(31, 78, 121)
            boton.ForeColor = Color.White
        End If
        AddHandler boton.Click, Sub(remitente, argumentos) accion()
        Return boton
    End Function

    Private Function CrearControl(campo As CampoFormulario) As Control
        Select Case campo.Tipo
            Case TipoCampo.TextoLargo
                Return New TextBox With {.Multiline = True, .Height = 64, .Dock = DockStyle.Fill, .MaxLength = 150}
            Case TipoCampo.Contrasena
                Return New TextBox With {.UseSystemPasswordChar = True, .Dock = DockStyle.Fill}
            Case TipoCampo.Entero
                Return New NumericUpDown With {.Minimum = campo.Minimo, .Maximum = campo.Maximo, .DecimalPlaces = 0, .Dock = DockStyle.Fill}
            Case TipoCampo.Moneda
                Return New NumericUpDown With {.Minimum = campo.Minimo, .Maximum = campo.Maximo, .DecimalPlaces = 2, .ThousandsSeparator = True, .Dock = DockStyle.Fill}
            Case TipoCampo.Fecha
                Return New DateTimePicker With {.Format = DateTimePickerFormat.Short, .Dock = DockStyle.Fill}
            Case TipoCampo.Combo
                Return New ComboBox With {.DropDownStyle = ComboBoxStyle.DropDownList, .DisplayMember = "Texto", .ValueMember = "Valor", .DataSource = campo.Opciones, .Dock = DockStyle.Fill}
            Case TipoCampo.ComboTexto
                Dim combo As New ComboBox With {.DropDownStyle = ComboBoxStyle.DropDownList, .Dock = DockStyle.Fill}
                combo.Items.AddRange(campo.Textos)
                Return combo
            Case TipoCampo.Logico
                Return New CheckBox With {.Text = "Sí", .AutoSize = True}
            Case TipoCampo.Dias
                Dim lista As New CheckedListBox With {.CheckOnClick = True, .Height = 110, .Dock = DockStyle.Fill, .MultiColumn = True}
                lista.Items.AddRange(NombresDias)
                Return lista
            Case Else
                Return New TextBox With {.Dock = DockStyle.Fill, .MaxLength = 150}
        End Select
    End Function

    Private Function LeerValor(campo As CampoFormulario) As Object
        Dim control As Control = controles(campo.Propiedad)
        Select Case campo.Tipo
            Case TipoCampo.Entero
                Return Convert.ToInt32(DirectCast(control, NumericUpDown).Value)
            Case TipoCampo.Moneda
                Return DirectCast(control, NumericUpDown).Value
            Case TipoCampo.Fecha
                Return DirectCast(control, DateTimePicker).Value.Date
            Case TipoCampo.Combo
                Dim combo As ComboBox = DirectCast(control, ComboBox)
                Return If(combo.SelectedValue Is Nothing, 0, Convert.ToInt32(combo.SelectedValue))
            Case TipoCampo.ComboTexto
                Return Convert.ToString(DirectCast(control, ComboBox).SelectedItem)
            Case TipoCampo.Logico
                Return DirectCast(control, CheckBox).Checked
            Case TipoCampo.Dias
                Dim marcados As New List(Of String)()
                For Each item As Object In DirectCast(control, CheckedListBox).CheckedItems
                    marcados.Add(Convert.ToString(item))
                Next
                Return String.Join(",", marcados)
            Case TipoCampo.Contrasena
                Return control.Text
            Case Else
                Return control.Text.Trim()
        End Select
    End Function

    Private Sub EscribirValor(campo As CampoFormulario, valor As Object)
        Dim control As Control = controles(campo.Propiedad)
        Select Case campo.Tipo
            Case TipoCampo.Entero, TipoCampo.Moneda
                Dim numerico As NumericUpDown = DirectCast(control, NumericUpDown)
                numerico.Value = Math.Max(numerico.Minimum, Math.Min(numerico.Maximum, Convert.ToDecimal(valor)))
            Case TipoCampo.Fecha
                Dim fecha As Date = Convert.ToDateTime(valor)
                DirectCast(control, DateTimePicker).Value = If(fecha = Date.MinValue, Date.Today, fecha)
            Case TipoCampo.Combo
                Dim combo As ComboBox = DirectCast(control, ComboBox)
                Dim id As Integer = Convert.ToInt32(valor)
                If id = 0 Then
                    combo.SelectedIndex = If(combo.Items.Count > 0, 0, -1)
                Else
                    combo.SelectedValue = id
                End If
            Case TipoCampo.ComboTexto
                DirectCast(control, ComboBox).SelectedItem = Convert.ToString(valor)
            Case TipoCampo.Logico
                DirectCast(control, CheckBox).Checked = Convert.ToBoolean(valor)
            Case TipoCampo.Dias
                Dim lista As CheckedListBox = DirectCast(control, CheckedListBox)
                Dim activos As String() = Convert.ToString(valor).Split(","c)
                For indice As Integer = 0 To lista.Items.Count - 1
                    lista.SetItemChecked(indice, activos.Contains(Convert.ToString(lista.Items(indice))))
                Next
            Case TipoCampo.Contrasena
                control.Text = String.Empty
            Case Else
                control.Text = Convert.ToString(valor)
        End Select
    End Sub

    Private Sub LlenarCampos(entidad As Object)
        For Each campo As CampoFormulario In campos
            Dim propiedad As PropertyInfo = TipoEntidad.GetProperty(campo.Propiedad)
            EscribirValor(campo, propiedad.GetValue(entidad))
        Next
    End Sub

    Private Sub Nuevo()
        seleccionado = Nothing
        suspendido = True
        rejilla.ClearSelection()
        suspendido = False
        LlenarCampos(Activator.CreateInstance(TipoEntidad))
    End Sub

    Private Sub Recargar()
        Try
            rejilla.DataSource = ListarEntidades(txtBuscar.Text.Trim())
            Rejillas.AjustarColumnas(rejilla)
            If rejilla.Rows.Count = 0 Then Nuevo()
        Catch ex As Exception
            MessageBox.Show("No se pudieron cargar los datos: " & ex.Message, "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BuscarCambio(remitente As Object, e As EventArgs)
        Recargar()
    End Sub

    Private Sub FilaSeleccionada(remitente As Object, e As EventArgs)
        If suspendido OrElse rejilla.CurrentRow Is Nothing OrElse rejilla.CurrentRow.DataBoundItem Is Nothing Then Return
        If Not rejilla.CurrentRow.Selected Then Return
        seleccionado = rejilla.CurrentRow.DataBoundItem
        LlenarCampos(seleccionado)
    End Sub

    Private Sub Guardar()
        Dim entidad As Object = Activator.CreateInstance(TipoEntidad)
        If seleccionado IsNot Nothing Then
            For Each propiedad As PropertyInfo In TipoEntidad.GetProperties()
                If propiedad.CanWrite Then propiedad.SetValue(entidad, propiedad.GetValue(seleccionado))
            Next
        End If
        For Each campo As CampoFormulario In campos
            TipoEntidad.GetProperty(campo.Propiedad).SetValue(entidad, LeerValor(campo))
        Next
        Try
            GuardarEntidad(entidad)
        Catch ex As ReglaNegocioException
            MessageBox.Show(ex.Message, "Revisa los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
        MessageBox.Show("Los datos se guardaron correctamente.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Recargar()
        Nuevo()
    End Sub

    Private Sub Eliminar()
        If seleccionado Is Nothing Then
            MessageBox.Show("Selecciona un registro de la lista.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If MessageBox.Show("¿Seguro que quieres eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
        Try
            EliminarEntidad(seleccionado)
        Catch ex As ReglaNegocioException
            MessageBox.Show(ex.Message, "No se pudo eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
        Recargar()
        Nuevo()
    End Sub
End Class
