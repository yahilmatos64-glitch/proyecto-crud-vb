<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        txtUsuario = New TextBox()
        Label2 = New Label()
        txtContrasena = New TextBox()
        btnIngresar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(361, 132)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 15)
        Label1.TabIndex = 0
        Label1.Text = "Usuario:"
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(436, 123)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(72, 23)
        txtUsuario.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(354, 170)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 15)
        Label2.TabIndex = 2
        Label2.Text = "Contraseña:"
        ' 
        ' txtContrasena
        ' 
        txtContrasena.Location = New Point(438, 165)
        txtContrasena.Name = "txtContrasena"
        txtContrasena.Size = New Size(70, 23)
        txtContrasena.TabIndex = 3
        txtContrasena.UseSystemPasswordChar = True
        ' 
        ' btnIngresar
        ' 
        btnIngresar.Location = New Point(357, 245)
        btnIngresar.Name = "btnIngresar"
        btnIngresar.Size = New Size(122, 40)
        btnIngresar.TabIndex = 4
        btnIngresar.Text = "Ingresar"
        btnIngresar.UseVisualStyleBackColor = True
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnIngresar)
        Controls.Add(txtContrasena)
        Controls.Add(Label2)
        Controls.Add(txtUsuario)
        Controls.Add(Label1)
        Name = "FrmLogin"
        Text = "FrmLogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents btnIngresar As Button
End Class
