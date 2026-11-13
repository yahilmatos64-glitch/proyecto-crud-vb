<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIdiomas
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
        dgvIdiomas = New DataGridView()
        txtNombreIdioma = New TextBox()
        txtNivel = New TextBox()
        txtDescripcion = New TextBox()
        txtCosto = New TextBox()
        txtModalidad = New TextBox()
        txtDuracion = New TextBox()
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
        lavs = New Label()
        Label7 = New Label()
        CType(dgvIdiomas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvIdiomas
        ' 
        dgvIdiomas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvIdiomas.Location = New Point(8, 392)
        dgvIdiomas.Name = "dgvIdiomas"
        dgvIdiomas.Size = New Size(708, 51)
        dgvIdiomas.TabIndex = 0
        ' 
        ' txtNombreIdioma
        ' 
        txtNombreIdioma.Location = New Point(227, 12)
        txtNombreIdioma.Name = "txtNombreIdioma"
        txtNombreIdioma.Size = New Size(99, 23)
        txtNombreIdioma.TabIndex = 1
        ' 
        ' txtNivel
        ' 
        txtNivel.Location = New Point(227, 59)
        txtNivel.Name = "txtNivel"
        txtNivel.Size = New Size(99, 23)
        txtNivel.TabIndex = 2
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(227, 106)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(99, 23)
        txtDescripcion.TabIndex = 3
        ' 
        ' txtCosto
        ' 
        txtCosto.Location = New Point(227, 150)
        txtCosto.Name = "txtCosto"
        txtCosto.Size = New Size(99, 23)
        txtCosto.TabIndex = 4
        ' 
        ' txtModalidad
        ' 
        txtModalidad.Location = New Point(227, 249)
        txtModalidad.Name = "txtModalidad"
        txtModalidad.Size = New Size(99, 23)
        txtModalidad.TabIndex = 5
        ' 
        ' txtDuracion
        ' 
        txtDuracion.Location = New Point(227, 202)
        txtDuracion.Name = "txtDuracion"
        txtDuracion.Size = New Size(99, 23)
        txtDuracion.TabIndex = 6
        ' 
        ' chkEstado
        ' 
        chkEstado.AutoSize = True
        chkEstado.Location = New Point(227, 302)
        chkEstado.Name = "chkEstado"
        chkEstado.Size = New Size(59, 19)
        chkEstado.TabIndex = 7
        chkEstado.Text = "Check"
        chkEstado.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(363, 271)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(75, 23)
        btnNuevo.TabIndex = 8
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(493, 271)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 9
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(363, 326)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(75, 23)
        btnEditar.TabIndex = 10
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(493, 326)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 23)
        btnEliminar.TabIndex = 11
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(107, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 12
        Label1.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(107, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 15)
        Label2.TabIndex = 13
        Label2.Text = "Nivel"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(107, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 15)
        Label3.TabIndex = 14
        Label3.Text = "Descripcion"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(107, 158)
        Label4.Name = "Label4"
        Label4.Size = New Size(38, 15)
        Label4.TabIndex = 15
        Label4.Text = "Costo"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(107, 210)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 15)
        Label5.TabIndex = 16
        Label5.Text = "Duracion"
        ' 
        ' lavs
        ' 
        lavs.AutoSize = True
        lavs.Location = New Point(107, 257)
        lavs.Name = "lavs"
        lavs.Size = New Size(64, 15)
        lavs.TabIndex = 17
        lavs.Text = "Modalidad"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(107, 303)
        Label7.Name = "Label7"
        Label7.Size = New Size(42, 15)
        Label7.TabIndex = 18
        Label7.Text = "Estado"
        ' 
        ' FrmIdiomas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label7)
        Controls.Add(lavs)
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
        Controls.Add(txtDuracion)
        Controls.Add(txtModalidad)
        Controls.Add(txtCosto)
        Controls.Add(txtDescripcion)
        Controls.Add(txtNivel)
        Controls.Add(txtNombreIdioma)
        Controls.Add(dgvIdiomas)
        Name = "FrmIdiomas"
        Text = "FrmIdiomas"
        CType(dgvIdiomas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvIdiomas As DataGridView
    Friend WithEvents txtNombreIdioma As TextBox
    Friend WithEvents txtNivel As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents txtModalidad As TextBox
    Friend WithEvents txtDuracion As TextBox
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
    Friend WithEvents lavs As Label
    Friend WithEvents Label7 As Label
End Class
