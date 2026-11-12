<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEstudiantes
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
        dgvEstudiantes = New DataGridView()
        txtNombre = New TextBox()
        txtApellido = New TextBox()
        txtCedula = New TextBox()
        txtTelefono = New TextBox()
        txtCorreo = New TextBox()
        txtDireccion = New TextBox()
        dtpNacimiento = New DateTimePicker()
        btnNuevo = New Button()
        btnGuardar = New Button()
        btnEditar = New Button()
        btnEliminar = New Button()
        CType(dgvEstudiantes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvEstudiantes
        ' 
        dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEstudiantes.Location = New Point(54, 342)
        dgvEstudiantes.Name = "dgvEstudiantes"
        dgvEstudiantes.Size = New Size(621, 105)
        dgvEstudiantes.TabIndex = 0
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(236, 12)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(100, 23)
        txtNombre.TabIndex = 1
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(236, 59)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(100, 23)
        txtApellido.TabIndex = 2
        ' 
        ' txtCedula
        ' 
        txtCedula.Location = New Point(236, 99)
        txtCedula.Name = "txtCedula"
        txtCedula.Size = New Size(100, 23)
        txtCedula.TabIndex = 3
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(236, 148)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(100, 23)
        txtTelefono.TabIndex = 4
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(236, 206)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(100, 23)
        txtCorreo.TabIndex = 5
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(236, 258)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(100, 23)
        txtDireccion.TabIndex = 6
        ' 
        ' dtpNacimiento
        ' 
        dtpNacimiento.Location = New Point(236, 306)
        dtpNacimiento.Name = "dtpNacimiento"
        dtpNacimiento.Size = New Size(200, 23)
        dtpNacimiento.TabIndex = 7
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(542, 58)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(75, 23)
        btnNuevo.TabIndex = 8
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(542, 99)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 9
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(542, 147)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(75, 23)
        btnEditar.TabIndex = 10
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(542, 205)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 23)
        btnEliminar.TabIndex = 11
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' FrmEstudiantes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnGuardar)
        Controls.Add(btnNuevo)
        Controls.Add(dtpNacimiento)
        Controls.Add(txtDireccion)
        Controls.Add(txtCorreo)
        Controls.Add(txtTelefono)
        Controls.Add(txtCedula)
        Controls.Add(txtApellido)
        Controls.Add(txtNombre)
        Controls.Add(dgvEstudiantes)
        Name = "FrmEstudiantes"
        Text = "FrmEstudiantes"
        CType(dgvEstudiantes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvEstudiantes As DataGridView
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents dtpNacimiento As DateTimePicker
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
End Class
