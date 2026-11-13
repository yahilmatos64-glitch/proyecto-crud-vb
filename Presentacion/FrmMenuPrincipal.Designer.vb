<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuPrincipal
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
        MenuStrip1 = New MenuStrip()
        SisToolStripMenuItem = New ToolStripMenuItem()
        CerrarSesionToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        MantenimientoToolStripMenuItem = New ToolStripMenuItem()
        UsuarioToolStripMenuItem = New ToolStripMenuItem()
        EstudiantesToolStripMenuItem = New ToolStripMenuItem()
        ProfesoresToolStripMenuItem = New ToolStripMenuItem()
        IdiomasToolStripMenuItem = New ToolStripMenuItem()
        CursosToolStripMenuItem = New ToolStripMenuItem()
        AulasToolStripMenuItem = New ToolStripMenuItem()
        ProcesosToolStripMenuItem = New ToolStripMenuItem()
        InscripcionesToolStripMenuItem = New ToolStripMenuItem()
        PagosToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {SisToolStripMenuItem, MantenimientoToolStripMenuItem, ProcesosToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SisToolStripMenuItem
        ' 
        SisToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CerrarSesionToolStripMenuItem, SalirToolStripMenuItem})
        SisToolStripMenuItem.Name = "SisToolStripMenuItem"
        SisToolStripMenuItem.Size = New Size(60, 20)
        SisToolStripMenuItem.Text = "Sistema"
        ' 
        ' CerrarSesionToolStripMenuItem
        ' 
        CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        CerrarSesionToolStripMenuItem.Size = New Size(143, 22)
        CerrarSesionToolStripMenuItem.Text = "Cerrar Sesion"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(143, 22)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' MantenimientoToolStripMenuItem
        ' 
        MantenimientoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {UsuarioToolStripMenuItem, EstudiantesToolStripMenuItem, ProfesoresToolStripMenuItem, IdiomasToolStripMenuItem, CursosToolStripMenuItem, AulasToolStripMenuItem})
        MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        MantenimientoToolStripMenuItem.Size = New Size(101, 20)
        MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        ' 
        ' UsuarioToolStripMenuItem
        ' 
        UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        UsuarioToolStripMenuItem.Size = New Size(180, 22)
        UsuarioToolStripMenuItem.Text = "Usuario"
        ' 
        ' EstudiantesToolStripMenuItem
        ' 
        EstudiantesToolStripMenuItem.Name = "EstudiantesToolStripMenuItem"
        EstudiantesToolStripMenuItem.Size = New Size(180, 22)
        EstudiantesToolStripMenuItem.Text = "Estudiantes"
        ' 
        ' ProfesoresToolStripMenuItem
        ' 
        ProfesoresToolStripMenuItem.Name = "ProfesoresToolStripMenuItem"
        ProfesoresToolStripMenuItem.Size = New Size(180, 22)
        ProfesoresToolStripMenuItem.Text = "Profesores"
        ' 
        ' IdiomasToolStripMenuItem
        ' 
        IdiomasToolStripMenuItem.Name = "IdiomasToolStripMenuItem"
        IdiomasToolStripMenuItem.Size = New Size(180, 22)
        IdiomasToolStripMenuItem.Text = "Idiomas"
        ' 
        ' CursosToolStripMenuItem
        ' 
        CursosToolStripMenuItem.Name = "CursosToolStripMenuItem"
        CursosToolStripMenuItem.Size = New Size(180, 22)
        CursosToolStripMenuItem.Text = "Cursos"
        ' 
        ' AulasToolStripMenuItem
        ' 
        AulasToolStripMenuItem.Name = "AulasToolStripMenuItem"
        AulasToolStripMenuItem.Size = New Size(180, 22)
        AulasToolStripMenuItem.Text = "Aulas"
        ' 
        ' ProcesosToolStripMenuItem
        ' 
        ProcesosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {InscripcionesToolStripMenuItem, PagosToolStripMenuItem})
        ProcesosToolStripMenuItem.Name = "ProcesosToolStripMenuItem"
        ProcesosToolStripMenuItem.Size = New Size(66, 20)
        ProcesosToolStripMenuItem.Text = "Procesos"
        ' 
        ' InscripcionesToolStripMenuItem
        ' 
        InscripcionesToolStripMenuItem.Name = "InscripcionesToolStripMenuItem"
        InscripcionesToolStripMenuItem.Size = New Size(143, 22)
        InscripcionesToolStripMenuItem.Text = "Inscripciones"
        ' 
        ' PagosToolStripMenuItem
        ' 
        PagosToolStripMenuItem.Name = "PagosToolStripMenuItem"
        PagosToolStripMenuItem.Size = New Size(143, 22)
        PagosToolStripMenuItem.Text = "Pagos"
        ' 
        ' FrmMenuPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "FrmMenuPrincipal"
        Text = "FrmMenuPrincipal"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstudiantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfesoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IdiomasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CursosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AulasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProcesosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InscripcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagosToolStripMenuItem As ToolStripMenuItem
End Class
