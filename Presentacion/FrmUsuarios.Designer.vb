<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
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
        dgvUsuarios = New DataGridView()
        txtNombre = New TextBox()
        txtApellido = New TextBox()
        txtUsuario = New TextBox()
        txtContrasena = New TextBox()
        txtRol = New TextBox()
        txtCorreo = New TextBox()
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
        Label7 = New Label()
        Label8 = New Label()
        CType(dgvUsuarios, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvUsuarios
        ' 
        dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsuarios.Location = New Point(10, 363)
        dgvUsuarios.Name = "dgvUsuarios"
        dgvUsuarios.Size = New Size(778, 77)
        dgvUsuarios.TabIndex = 0
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(121, 38)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(72, 23)
        txtNombre.TabIndex = 1
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(121, 91)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(72, 23)
        txtApellido.TabIndex = 2
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(121, 152)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(72, 23)
        txtUsuario.TabIndex = 3
        ' 
        ' txtContrasena
        ' 
        txtContrasena.Location = New Point(121, 204)
        txtContrasena.Name = "txtContrasena"
        txtContrasena.Size = New Size(72, 23)
        txtContrasena.TabIndex = 4
        ' 
        ' txtRol
        ' 
        txtRol.Location = New Point(121, 257)
        txtRol.Name = "txtRol"
        txtRol.Size = New Size(72, 23)
        txtRol.TabIndex = 5
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(121, 315)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(72, 23)
        txtCorreo.TabIndex = 6
        ' 
        ' chkEstado
        ' 
        chkEstado.AutoSize = True
        chkEstado.Location = New Point(263, 320)
        chkEstado.Name = "chkEstado"
        chkEstado.Size = New Size(59, 19)
        chkEstado.TabIndex = 7
        chkEstado.Text = "Check"
        chkEstado.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(445, 246)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(75, 23)
        btnNuevo.TabIndex = 8
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(573, 246)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 9
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(445, 316)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(75, 23)
        btnEditar.TabIndex = 10
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(573, 317)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 23)
        btnEliminar.TabIndex = 11
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(41, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 12
        Label1.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(41, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 13
        Label2.Text = "Apellido"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(41, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 15)
        Label3.TabIndex = 14
        Label3.Text = "Usuario"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(41, 212)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 15)
        Label4.TabIndex = 15
        Label4.Text = "Contraseña"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(281, 254)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 15)
        Label5.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(41, 265)
        Label6.Name = "Label6"
        Label6.Size = New Size(24, 15)
        Label6.TabIndex = 16
        Label6.Text = "Rol"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(380, 218)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 15)
        Label7.TabIndex = 17
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(41, 323)
        Label8.Name = "Label8"
        Label8.Size = New Size(43, 15)
        Label8.TabIndex = 18
        Label8.Text = "Correo"
        ' 
        ' FrmUsuarios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label8)
        Controls.Add(Label7)
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
        Controls.Add(txtCorreo)
        Controls.Add(txtRol)
        Controls.Add(txtContrasena)
        Controls.Add(txtUsuario)
        Controls.Add(txtApellido)
        Controls.Add(txtNombre)
        Controls.Add(dgvUsuarios)
        Name = "FrmUsuarios"
        Text = "FrmUsuarios"
        CType(dgvUsuarios, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents txtRol As TextBox
    Friend WithEvents txtCorreo As TextBox
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
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
