<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProfesores
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
        dgvProfesores = New DataGridView()
        txtNombre = New TextBox()
        txtApellido = New TextBox()
        txtEspecialidad = New TextBox()
        txtTelefono = New TextBox()
        txtCorreo = New TextBox()
        txtDireccion = New TextBox()
        chkEstado = New CheckBox()
        btnNuevo = New Button()
        btnGuardar = New Button()
        btnEditar = New Button()
        btnEliminar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        CType(dgvProfesores, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvProfesores
        ' 
        dgvProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProfesores.Location = New Point(2, 288)
        dgvProfesores.Name = "dgvProfesores"
        dgvProfesores.Size = New Size(692, 150)
        dgvProfesores.TabIndex = 0
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(112, 12)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(100, 23)
        txtNombre.TabIndex = 1
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(112, 51)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(100, 23)
        txtApellido.TabIndex = 2
        ' 
        ' txtEspecialidad
        ' 
        txtEspecialidad.Location = New Point(112, 92)
        txtEspecialidad.Name = "txtEspecialidad"
        txtEspecialidad.Size = New Size(100, 23)
        txtEspecialidad.TabIndex = 3
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(112, 130)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(100, 23)
        txtTelefono.TabIndex = 4
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(112, 177)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(100, 23)
        txtCorreo.TabIndex = 5
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(112, 223)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(100, 23)
        txtDireccion.TabIndex = 6
        ' 
        ' chkEstado
        ' 
        chkEstado.AutoSize = True
        chkEstado.Location = New Point(112, 263)
        chkEstado.Name = "chkEstado"
        chkEstado.Size = New Size(59, 19)
        chkEstado.TabIndex = 7
        chkEstado.Text = "Check"
        chkEstado.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(354, 165)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(75, 23)
        btnNuevo.TabIndex = 8
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(457, 165)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 9
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(354, 222)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(75, 23)
        btnEditar.TabIndex = 10
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(457, 223)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 23)
        btnEliminar.TabIndex = 11
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(32, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 12
        Label1.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(32, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 13
        Label2.Text = "Apellido"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(32, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 15)
        Label3.TabIndex = 14
        Label3.Text = "Especialidad"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(32, 133)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 15)
        Label4.TabIndex = 15
        Label4.Text = "Telefono"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(32, 180)
        Label5.Name = "Label5"
        Label5.Size = New Size(43, 15)
        Label5.TabIndex = 16
        Label5.Text = "Correo"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(32, 226)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 15)
        Label6.TabIndex = 17
        Label6.Text = "Direccion"
        ' 
        ' FrmProfesores
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnGuardar)
        Controls.Add(btnNuevo)
        Controls.Add(chkEstado)
        Controls.Add(txtDireccion)
        Controls.Add(txtCorreo)
        Controls.Add(txtTelefono)
        Controls.Add(txtEspecialidad)
        Controls.Add(txtApellido)
        Controls.Add(txtNombre)
        Controls.Add(dgvProfesores)
        Name = "FrmProfesores"
        Text = "FrmProfesores"
        CType(dgvProfesores, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvProfesores As DataGridView
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtEspecialidad As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
