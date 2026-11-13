<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAulas
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
        dgvAulas = New DataGridView()
        txtNombreAula = New TextBox()
        txtCapacidad = New TextBox()
        txtUbicacion = New TextBox()
        txtTipo = New TextBox()
        txtEquipamiento = New TextBox()
        txtDescripcion = New TextBox()
        chkEstado = New CheckBox()
        btnNuevo = New Button()
        btnGuardar = New Button()
        btnEditar = New Button()
        btnEliminar = New Button()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        CType(dgvAulas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvAulas
        ' 
        dgvAulas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAulas.Location = New Point(36, 373)
        dgvAulas.Name = "dgvAulas"
        dgvAulas.Size = New Size(717, 75)
        dgvAulas.TabIndex = 0
        ' 
        ' txtNombreAula
        ' 
        txtNombreAula.Location = New Point(201, 43)
        txtNombreAula.Name = "txtNombreAula"
        txtNombreAula.Size = New Size(100, 23)
        txtNombreAula.TabIndex = 1
        ' 
        ' txtCapacidad
        ' 
        txtCapacidad.Location = New Point(201, 90)
        txtCapacidad.Name = "txtCapacidad"
        txtCapacidad.Size = New Size(100, 23)
        txtCapacidad.TabIndex = 2
        ' 
        ' txtUbicacion
        ' 
        txtUbicacion.Location = New Point(201, 139)
        txtUbicacion.Name = "txtUbicacion"
        txtUbicacion.Size = New Size(100, 23)
        txtUbicacion.TabIndex = 3
        ' 
        ' txtTipo
        ' 
        txtTipo.Location = New Point(201, 183)
        txtTipo.Name = "txtTipo"
        txtTipo.Size = New Size(100, 23)
        txtTipo.TabIndex = 4
        ' 
        ' txtEquipamiento
        ' 
        txtEquipamiento.Location = New Point(201, 229)
        txtEquipamiento.Name = "txtEquipamiento"
        txtEquipamiento.Size = New Size(100, 23)
        txtEquipamiento.TabIndex = 5
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(201, 279)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(100, 23)
        txtDescripcion.TabIndex = 6
        ' 
        ' chkEstado
        ' 
        chkEstado.AutoSize = True
        chkEstado.Location = New Point(201, 325)
        chkEstado.Name = "chkEstado"
        chkEstado.Size = New Size(59, 19)
        chkEstado.TabIndex = 7
        chkEstado.Text = "Check"
        chkEstado.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(478, 191)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(95, 47)
        btnNuevo.TabIndex = 8
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(626, 191)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(95, 47)
        btnGuardar.TabIndex = 9
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(478, 271)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(95, 47)
        btnEditar.TabIndex = 10
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(626, 271)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(95, 47)
        btnEliminar.TabIndex = 11
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(102, 329)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 15)
        Label7.TabIndex = 25
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(102, 287)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 15)
        Label6.TabIndex = 24
        Label6.Text = "Descripcion"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(102, 237)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 15)
        Label5.TabIndex = 23
        Label5.Text = "Equipamiento"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(102, 191)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 15)
        Label4.TabIndex = 22
        Label4.Text = "Tipo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(102, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 21
        Label3.Text = "Ubicacion"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(102, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 20
        Label2.Text = "Capacidad"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(102, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 19
        Label1.Text = "Nombre"
        ' 
        ' FrmAulas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
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
        Controls.Add(txtDescripcion)
        Controls.Add(txtEquipamiento)
        Controls.Add(txtTipo)
        Controls.Add(txtUbicacion)
        Controls.Add(txtCapacidad)
        Controls.Add(txtNombreAula)
        Controls.Add(dgvAulas)
        Name = "FrmAulas"
        Text = "FrmAulas"
        CType(dgvAulas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvAulas As DataGridView
    Friend WithEvents txtNombreAula As TextBox
    Friend WithEvents txtCapacidad As TextBox
    Friend WithEvents txtUbicacion As TextBox
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents txtEquipamiento As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
