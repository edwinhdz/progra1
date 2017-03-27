<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.lbcelular = New System.Windows.Forms.Label()
        Me.lbidtelefono = New System.Windows.Forms.Label()
        Me.lbiddireccion = New System.Windows.Forms.Label()
        Me.lbidapellido = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbidcliente = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(160, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Clientes"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.TextBox8)
        Me.GroupBox2.Location = New System.Drawing.Point(357, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(421, 253)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(6, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(133, 20)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(282, 20)
        Me.TextBox8.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnguardar)
        Me.GroupBox1.Controls.Add(Me.btneditar)
        Me.GroupBox1.Controls.Add(Me.btnnuevo)
        Me.GroupBox1.Controls.Add(Me.lbcelular)
        Me.GroupBox1.Controls.Add(Me.lbidtelefono)
        Me.GroupBox1.Controls.Add(Me.lbiddireccion)
        Me.GroupBox1.Controls.Add(Me.lbidapellido)
        Me.GroupBox1.Controls.Add(Me.lbNombre)
        Me.GroupBox1.Controls.Add(Me.lbidcliente)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 253)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro Clientes"
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(199, 219)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 14
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.Location = New System.Drawing.Point(118, 219)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(75, 23)
        Me.btneditar.TabIndex = 13
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(37, 219)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnnuevo.TabIndex = 12
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'lbcelular
        '
        Me.lbcelular.AutoSize = True
        Me.lbcelular.Location = New System.Drawing.Point(25, 179)
        Me.lbcelular.Name = "lbcelular"
        Me.lbcelular.Size = New System.Drawing.Size(39, 13)
        Me.lbcelular.TabIndex = 11
        Me.lbcelular.Text = "Celular"
        '
        'lbidtelefono
        '
        Me.lbidtelefono.AutoSize = True
        Me.lbidtelefono.Location = New System.Drawing.Point(25, 153)
        Me.lbidtelefono.Name = "lbidtelefono"
        Me.lbidtelefono.Size = New System.Drawing.Size(49, 13)
        Me.lbidtelefono.TabIndex = 10
        Me.lbidtelefono.Text = "Telefono"
        '
        'lbiddireccion
        '
        Me.lbiddireccion.AutoSize = True
        Me.lbiddireccion.Location = New System.Drawing.Point(25, 127)
        Me.lbiddireccion.Name = "lbiddireccion"
        Me.lbiddireccion.Size = New System.Drawing.Size(52, 13)
        Me.lbiddireccion.TabIndex = 9
        Me.lbiddireccion.Text = "Direccion"
        '
        'lbidapellido
        '
        Me.lbidapellido.AutoSize = True
        Me.lbidapellido.Location = New System.Drawing.Point(25, 101)
        Me.lbidapellido.Name = "lbidapellido"
        Me.lbidapellido.Size = New System.Drawing.Size(44, 13)
        Me.lbidapellido.TabIndex = 8
        Me.lbidapellido.Text = "Apellido"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(25, 77)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(44, 13)
        Me.lbNombre.TabIndex = 7
        Me.lbNombre.Text = "Nombre"
        '
        'lbidcliente
        '
        Me.lbidcliente.AutoSize = True
        Me.lbidcliente.Location = New System.Drawing.Point(25, 51)
        Me.lbidcliente.Name = "lbidcliente"
        Me.lbidcliente.Size = New System.Drawing.Size(51, 13)
        Me.lbidcliente.TabIndex = 6
        Me.lbidcliente.Text = "Id Cliente"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(96, 172)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(174, 20)
        Me.TextBox6.TabIndex = 5
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(96, 146)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(174, 20)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(96, 120)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(174, 20)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(96, 94)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(174, 20)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(96, 70)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(174, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(96, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(174, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 352)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents lbcelular As Label
    Friend WithEvents lbidtelefono As Label
    Friend WithEvents lbiddireccion As Label
    Friend WithEvents lbidapellido As Label
    Friend WithEvents lbNombre As Label
    Friend WithEvents lbidcliente As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
