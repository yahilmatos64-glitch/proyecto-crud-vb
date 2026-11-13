<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDashboard
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblTotalUsuarios = New Label()
        lblTotalEstudiantes = New Label()
        lblTotalProfesores = New Label()
        lblTotalIdiomas = New Label()
        lblTotalCursos = New Label()
        lblTotalInscripciones = New Label()
        lblTotalPagos = New Label()
        lblTotalAulas = New Label()
        btnActualizar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        SuspendLayout()
        ' 
        ' lblTotalUsuarios
        ' 
        lblTotalUsuarios.AutoSize = True
        lblTotalUsuarios.Location = New Point(446, 46)
        lblTotalUsuarios.Name = "lblTotalUsuarios"
        lblTotalUsuarios.Size = New Size(81, 15)
        lblTotalUsuarios.TabIndex = 0
        lblTotalUsuarios.Text = "Total Usuarios"
        ' 
        ' lblTotalEstudiantes
        ' 
        lblTotalEstudiantes.AutoSize = True
        lblTotalEstudiantes.Location = New Point(446, 87)
        lblTotalEstudiantes.Name = "lblTotalEstudiantes"
        lblTotalEstudiantes.Size = New Size(96, 15)
        lblTotalEstudiantes.TabIndex = 1
        lblTotalEstudiantes.Text = "Total Estudiantes"
        ' 
        ' lblTotalProfesores
        ' 
        lblTotalProfesores.AutoSize = True
        lblTotalProfesores.Location = New Point(446, 136)
        lblTotalProfesores.Name = "lblTotalProfesores"
        lblTotalProfesores.Size = New Size(91, 15)
        lblTotalProfesores.TabIndex = 2
        lblTotalProfesores.Text = "Total Profesores"
        ' 
        ' lblTotalIdiomas
        ' 
        lblTotalIdiomas.AutoSize = True
        lblTotalIdiomas.Location = New Point(446, 184)
        lblTotalIdiomas.Name = "lblTotalIdiomas"
        lblTotalIdiomas.Size = New Size(41, 15)
        lblTotalIdiomas.TabIndex = 3
        lblTotalIdiomas.Text = "Label4"
        ' 
        ' lblTotalCursos
        ' 
        lblTotalCursos.AutoSize = True
        lblTotalCursos.Location = New Point(446, 229)
        lblTotalCursos.Name = "lblTotalCursos"
        lblTotalCursos.Size = New Size(41, 15)
        lblTotalCursos.TabIndex = 4
        lblTotalCursos.Text = "Label5"
        ' 
        ' lblTotalInscripciones
        ' 
        lblTotalInscripciones.AutoSize = True
        lblTotalInscripciones.Location = New Point(446, 269)
        lblTotalInscripciones.Name = "lblTotalInscripciones"
        lblTotalInscripciones.Size = New Size(41, 15)
        lblTotalInscripciones.TabIndex = 5
        lblTotalInscripciones.Text = "Label6"
        ' 
        ' lblTotalPagos
        ' 
        lblTotalPagos.AutoSize = True
        lblTotalPagos.Location = New Point(446, 312)
        lblTotalPagos.Name = "lblTotalPagos"
        lblTotalPagos.Size = New Size(41, 15)
        lblTotalPagos.TabIndex = 6
        lblTotalPagos.Text = "Label7"
        ' 
        ' lblTotalAulas
        ' 
        lblTotalAulas.AutoSize = True
        lblTotalAulas.Location = New Point(446, 350)
        lblTotalAulas.Name = "lblTotalAulas"
        lblTotalAulas.Size = New Size(41, 15)
        lblTotalAulas.TabIndex = 7
        lblTotalAulas.Text = "Label8"
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(301, 389)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(136, 49)
        btnActualizar.TabIndex = 8
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(264, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(247, 15)
        Label1.TabIndex = 9
        Label1.Text = "Panel de estadísticas — Academia de Idiomas"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(264, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 15)
        Label2.TabIndex = 10
        Label2.Text = "Total Usuarios"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(264, 87)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 15)
        Label3.TabIndex = 11
        Label3.Text = "Total Estudiantes"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(264, 136)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 15)
        Label4.TabIndex = 12
        Label4.Text = "Total Profesores"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(264, 350)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 15)
        Label5.TabIndex = 13
        Label5.Text = "Total Aulas"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(264, 184)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 15)
        Label6.TabIndex = 14
        Label6.Text = "Total Idiomas"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(264, 269)
        Label7.Name = "Label7"
        Label7.Size = New Size(105, 15)
        Label7.TabIndex = 15
        Label7.Text = "Total Inscripciones"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(264, 312)
        Label8.Name = "Label8"
        Label8.Size = New Size(68, 15)
        Label8.TabIndex = 16
        Label8.Text = "Total Pagos"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(264, 229)
        Label9.Name = "Label9"
        Label9.Size = New Size(72, 15)
        Label9.TabIndex = 17
        Label9.Text = "Total Cursos"
        ' 
        ' FrmDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnActualizar)
        Controls.Add(lblTotalAulas)
        Controls.Add(lblTotalPagos)
        Controls.Add(lblTotalInscripciones)
        Controls.Add(lblTotalCursos)
        Controls.Add(lblTotalIdiomas)
        Controls.Add(lblTotalProfesores)
        Controls.Add(lblTotalEstudiantes)
        Controls.Add(lblTotalUsuarios)
        Name = "FrmDashboard"
        Text = "FrmDashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTotalUsuarios As Label
    Friend WithEvents lblTotalEstudiantes As Label
    Friend WithEvents lblTotalProfesores As Label
    Friend WithEvents lblTotalIdiomas As Label
    Friend WithEvents lblTotalCursos As Label
    Friend WithEvents lblTotalInscripciones As Label
    Friend WithEvents lblTotalPagos As Label
    Friend WithEvents lblTotalAulas As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
