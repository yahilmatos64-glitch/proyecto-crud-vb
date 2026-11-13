<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPagos
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
        dgvPagos = New DataGridView()
        cmbInscripcion = New ComboBox()
        dtpFechaPago = New DateTimePicker()
        txtMonto = New TextBox()
        cmbMetodoPago = New ComboBox()
        txtReferencia = New TextBox()
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
        CType(dgvPagos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvPagos
        ' 
        dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPagos.Location = New Point(15, 372)
        dgvPagos.Name = "dgvPagos"
        dgvPagos.Size = New Size(702, 75)
        dgvPagos.TabIndex = 0
        ' 
        ' cmbInscripcion
        ' 
        cmbInscripcion.DropDownStyle = ComboBoxStyle.DropDownList
        cmbInscripcion.FormattingEnabled = True
        cmbInscripcion.Location = New Point(141, 21)
        cmbInscripcion.Name = "cmbInscripcion"
        cmbInscripcion.Size = New Size(91, 23)
        cmbInscripcion.TabIndex = 1
        ' 
        ' dtpFechaPago
        ' 
        dtpFechaPago.Location = New Point(131, 343)
        dtpFechaPago.Name = "dtpFechaPago"
        dtpFechaPago.Size = New Size(199, 23)
        dtpFechaPago.TabIndex = 2
        ' 
        ' txtMonto
        ' 
        txtMonto.Location = New Point(140, 76)
        txtMonto.Name = "txtMonto"
        txtMonto.Size = New Size(92, 23)
        txtMonto.TabIndex = 3
        ' 
        ' cmbMetodoPago
        ' 
        cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMetodoPago.FormattingEnabled = True
        cmbMetodoPago.Location = New Point(140, 135)
        cmbMetodoPago.Name = "cmbMetodoPago"
        cmbMetodoPago.Size = New Size(106, 23)
        cmbMetodoPago.TabIndex = 4
        ' 
        ' txtReferencia
        ' 
        txtReferencia.Location = New Point(140, 181)
        txtReferencia.Name = "txtReferencia"
        txtReferencia.Size = New Size(112, 23)
        txtReferencia.TabIndex = 5
        ' 
        ' cmbEstado
        ' 
        cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList
        cmbEstado.FormattingEnabled = True
        cmbEstado.Location = New Point(141, 236)
        cmbEstado.Name = "cmbEstado"
        cmbEstado.Size = New Size(114, 23)
        cmbEstado.TabIndex = 6
        ' 
        ' txtObservacion
        ' 
        txtObservacion.Location = New Point(141, 285)
        txtObservacion.Multiline = True
        txtObservacion.Name = "txtObservacion"
        txtObservacion.Size = New Size(118, 33)
        txtObservacion.TabIndex = 7
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(366, 307)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(83, 39)
        btnNuevo.TabIndex = 8
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(455, 307)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(83, 39)
        btnGuardar.TabIndex = 9
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(545, 307)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(83, 39)
        btnEditar.TabIndex = 10
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(634, 307)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(83, 39)
        btnEliminar.TabIndex = 11
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(43, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 15)
        Label1.TabIndex = 12
        Label1.Text = "Inscripcion"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(43, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 13
        Label2.Text = "Monto"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(43, 143)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 15)
        Label3.TabIndex = 14
        Label3.Text = "Metodo Pago"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(43, 189)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 15)
        Label4.TabIndex = 15
        Label4.Text = "Referencia"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(43, 244)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 15)
        Label5.TabIndex = 16
        Label5.Text = "Estado"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(43, 303)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 15)
        Label6.TabIndex = 17
        Label6.Text = "Observacion"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(43, 351)
        Label7.Name = "Label7"
        Label7.Size = New Size(65, 15)
        Label7.TabIndex = 18
        Label7.Text = "FechaPago"
        ' 
        ' FrmPagos
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
        Controls.Add(txtReferencia)
        Controls.Add(cmbMetodoPago)
        Controls.Add(txtMonto)
        Controls.Add(dtpFechaPago)
        Controls.Add(cmbInscripcion)
        Controls.Add(dgvPagos)
        Name = "FrmPagos"
        Text = "FrmPagos"
        CType(dgvPagos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvPagos As DataGridView
    Friend WithEvents cmbInscripcion As ComboBox
    Friend WithEvents dtpFechaPago As DateTimePicker
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents cmbMetodoPago As ComboBox
    Friend WithEvents txtReferencia As TextBox
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
