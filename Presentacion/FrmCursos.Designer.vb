<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCursos
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        txtHorario = New TextBox()
        txtDuracion = New TextBox()
        txtCosto = New TextBox()
        txtNivel = New TextBox()
        txtNombreCurso = New TextBox()
        cmbProfesor = New ComboBox()
        cmbIdioma = New ComboBox()
        chkEstado = New CheckBox()
        btnNuevo = New Button()
        btnGuardar = New Button()
        btnEditar = New Button()
        btnEliminar = New Button()
        dgvCursos = New DataGridView()
        CType(dgvCursos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(62, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 15)
        Label1.TabIndex = 0
        Label1.Text = "Curso"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(62, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 15)
        Label2.TabIndex = 1
        Label2.Text = "Idioma"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(62, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 2
        Label3.Text = "Profesor"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(62, 150)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 15)
        Label4.TabIndex = 3
        Label4.Text = "Horario"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(62, 193)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 15)
        Label5.TabIndex = 4
        Label5.Text = "Duración"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(62, 238)
        Label6.Name = "Label6"
        Label6.Size = New Size(38, 15)
        Label6.TabIndex = 5
        Label6.Text = "Costo"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(62, 280)
        Label7.Name = "Label7"
        Label7.Size = New Size(34, 15)
        Label7.TabIndex = 6
        Label7.Text = "Nivel" & vbLf
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(62, 324)
        Label8.Name = "Label8"
        Label8.Size = New Size(42, 15)
        Label8.TabIndex = 7
        Label8.Text = "Estado"
        ' 
        ' txtHorario
        ' 
        txtHorario.Location = New Point(188, 150)
        txtHorario.Name = "txtHorario"
        txtHorario.Size = New Size(121, 23)
        txtHorario.TabIndex = 8
        ' 
        ' txtDuracion
        ' 
        txtDuracion.Location = New Point(188, 190)
        txtDuracion.Name = "txtDuracion"
        txtDuracion.Size = New Size(121, 23)
        txtDuracion.TabIndex = 9
        ' 
        ' txtCosto
        ' 
        txtCosto.Location = New Point(188, 230)
        txtCosto.Name = "txtCosto"
        txtCosto.Size = New Size(121, 23)
        txtCosto.TabIndex = 10
        ' 
        ' txtNivel
        ' 
        txtNivel.Location = New Point(188, 272)
        txtNivel.Name = "txtNivel"
        txtNivel.Size = New Size(121, 23)
        txtNivel.TabIndex = 11
        ' 
        ' txtNombreCurso
        ' 
        txtNombreCurso.Location = New Point(188, 27)
        txtNombreCurso.Name = "txtNombreCurso"
        txtNombreCurso.Size = New Size(121, 23)
        txtNombreCurso.TabIndex = 12
        ' 
        ' cmbProfesor
        ' 
        cmbProfesor.FormattingEnabled = True
        cmbProfesor.Location = New Point(188, 110)
        cmbProfesor.Name = "cmbProfesor"
        cmbProfesor.Size = New Size(121, 23)
        cmbProfesor.TabIndex = 13
        ' 
        ' cmbIdioma
        ' 
        cmbIdioma.FormattingEnabled = True
        cmbIdioma.Location = New Point(188, 70)
        cmbIdioma.Name = "cmbIdioma"
        cmbIdioma.Size = New Size(121, 23)
        cmbIdioma.TabIndex = 14
        ' 
        ' chkEstado
        ' 
        chkEstado.AutoSize = True
        chkEstado.Location = New Point(188, 320)
        chkEstado.Name = "chkEstado"
        chkEstado.Size = New Size(57, 19)
        chkEstado.TabIndex = 15
        chkEstado.Text = "check"
        chkEstado.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(347, 339)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(75, 23)
        btnNuevo.TabIndex = 16
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(438, 339)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 17
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(533, 339)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(75, 23)
        btnEditar.TabIndex = 18
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(637, 339)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 23)
        btnEliminar.TabIndex = 19
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' dgvCursos
        ' 
        dgvCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCursos.Location = New Point(16, 368)
        dgvCursos.Name = "dgvCursos"
        dgvCursos.Size = New Size(696, 77)
        dgvCursos.TabIndex = 20
        ' 
        ' FrmCursos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvCursos)
        Controls.Add(btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnGuardar)
        Controls.Add(btnNuevo)
        Controls.Add(chkEstado)
        Controls.Add(cmbIdioma)
        Controls.Add(cmbProfesor)
        Controls.Add(txtNombreCurso)
        Controls.Add(txtNivel)
        Controls.Add(txtCosto)
        Controls.Add(txtDuracion)
        Controls.Add(txtHorario)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FrmCursos"
        Text = "FrmCursos"
        CType(dgvCursos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents cmbProfesor As ComboBox
    Friend WithEvents cmbIdioma As ComboBox
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents dgvCursos As DataGridView
    Friend WithEvents txtHorario As TextBox
    Friend WithEvents txtDuracion As TextBox
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents txtNivel As TextBox
    Friend WithEvents txtNombreCurso As TextBox
End Class
