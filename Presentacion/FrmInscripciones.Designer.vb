<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInscripciones
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
        dgvInscripciones = New DataGridView()
        cmbEstudiante = New ComboBox()
        cmbCurso = New ComboBox()
        dtpFechaInscripcion = New DateTimePicker()
        txtMonto = New TextBox()
        txtDescuento = New TextBox()
        cmbEstado = New ComboBox()
        txtObservacion = New TextBox()
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
        CType(dgvInscripciones, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvInscripciones
        ' 
        dgvInscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInscripciones.Location = New Point(19, 376)
        dgvInscripciones.Name = "dgvInscripciones"
        dgvInscripciones.Size = New Size(701, 71)
        dgvInscripciones.TabIndex = 0
        ' 
        ' cmbEstudiante
        ' 
        cmbEstudiante.FormattingEnabled = True
        cmbEstudiante.Location = New Point(141, 37)
        cmbEstudiante.Name = "cmbEstudiante"
        cmbEstudiante.Size = New Size(83, 23)
        cmbEstudiante.TabIndex = 1
        ' 
        ' cmbCurso
        ' 
        cmbCurso.FormattingEnabled = True
        cmbCurso.Location = New Point(141, 84)
        cmbCurso.Name = "cmbCurso"
        cmbCurso.Size = New Size(83, 23)
        cmbCurso.TabIndex = 2
        ' 
        ' dtpFechaInscripcion
        ' 
        dtpFechaInscripcion.Location = New Point(141, 337)
        dtpFechaInscripcion.Name = "dtpFechaInscripcion"
        dtpFechaInscripcion.Size = New Size(155, 23)
        dtpFechaInscripcion.TabIndex = 3
        ' 
        ' txtMonto
        ' 
        txtMonto.Location = New Point(141, 132)
        txtMonto.Name = "txtMonto"
        txtMonto.Size = New Size(83, 23)
        txtMonto.TabIndex = 4
        ' 
        ' txtDescuento
        ' 
        txtDescuento.Location = New Point(141, 184)
        txtDescuento.Name = "txtDescuento"
        txtDescuento.Size = New Size(83, 23)
        txtDescuento.TabIndex = 5
        ' 
        ' cmbEstado
        ' 
        cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList
        cmbEstado.FormattingEnabled = True
        cmbEstado.Location = New Point(141, 281)
        cmbEstado.Name = "cmbEstado"
        cmbEstado.Size = New Size(90, 23)
        cmbEstado.TabIndex = 6
        ' 
        ' txtObservacion
        ' 
        txtObservacion.Location = New Point(141, 233)
        txtObservacion.Multiline = True
        txtObservacion.Name = "txtObservacion"
        txtObservacion.Size = New Size(95, 22)
        txtObservacion.TabIndex = 7
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(384, 314)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(81, 33)
        btnNuevo.TabIndex = 8
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(488, 314)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(81, 33)
        btnGuardar.TabIndex = 9
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(594, 314)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(81, 33)
        btnEditar.TabIndex = 10
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(696, 314)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(81, 33)
        btnEliminar.TabIndex = 11
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(60, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 15)
        Label1.TabIndex = 12
        Label1.Text = "Estudiante"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(60, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 15)
        Label2.TabIndex = 13
        Label2.Text = "Curso"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(60, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 15)
        Label3.TabIndex = 14
        Label3.Text = "Monto"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(60, 187)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 15)
        Label4.TabIndex = 15
        Label4.Text = "Descuento"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(50, 236)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 15)
        Label5.TabIndex = 16
        Label5.Text = "Observacion"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(57, 284)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 15)
        Label6.TabIndex = 17
        Label6.Text = "Estado"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(24, 343)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 15)
        Label7.TabIndex = 18
        Label7.Text = "Fecha Inscripcion"
        ' 
        ' FrmInscripciones
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
        Controls.Add(txtObservacion)
        Controls.Add(cmbEstado)
        Controls.Add(txtDescuento)
        Controls.Add(txtMonto)
        Controls.Add(dtpFechaInscripcion)
        Controls.Add(cmbCurso)
        Controls.Add(cmbEstudiante)
        Controls.Add(dgvInscripciones)
        Name = "FrmInscripciones"
        Text = "FrmInscripciones"
        CType(dgvInscripciones, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvInscripciones As DataGridView
    Friend WithEvents cmbEstudiante As ComboBox
    Friend WithEvents cmbCurso As ComboBox
    Friend WithEvents dtpFechaInscripcion As DateTimePicker
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents txtObservacion As TextBox
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
End Class
