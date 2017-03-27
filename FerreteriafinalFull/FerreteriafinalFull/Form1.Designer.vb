<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCompras = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnProveedores = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsarchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlinventario = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCompras
        '
        Me.btnCompras.BackColor = System.Drawing.Color.Teal
        Me.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompras.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCompras.Location = New System.Drawing.Point(171, 150)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(143, 50)
        Me.btnCompras.TabIndex = 46
        Me.btnCompras.Tag = ""
        Me.btnCompras.Text = "Compras"
        Me.btnCompras.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.BackColor = System.Drawing.Color.Teal
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVentas.Location = New System.Drawing.Point(22, 150)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(143, 50)
        Me.btnVentas.TabIndex = 45
        Me.btnVentas.Tag = ""
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'btnProveedores
        '
        Me.btnProveedores.BackColor = System.Drawing.Color.Teal
        Me.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProveedores.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnProveedores.Location = New System.Drawing.Point(320, 72)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Size = New System.Drawing.Size(143, 50)
        Me.btnProveedores.TabIndex = 44
        Me.btnProveedores.Tag = ""
        Me.btnProveedores.Text = "Proveedores"
        Me.btnProveedores.UseVisualStyleBackColor = False
        '
        'btnProductos
        '
        Me.btnProductos.BackColor = System.Drawing.Color.Teal
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnProductos.Location = New System.Drawing.Point(171, 72)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(143, 50)
        Me.btnProductos.TabIndex = 43
        Me.btnProductos.Tag = ""
        Me.btnProductos.Text = "Productos"
        Me.btnProductos.UseVisualStyleBackColor = False
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.Teal
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClientes.Location = New System.Drawing.Point(22, 72)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(143, 50)
        Me.btnClientes.TabIndex = 42
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsarchivo, Me.tlinventario})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(519, 24)
        Me.MenuStrip1.TabIndex = 41
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsarchivo
        '
        Me.tsarchivo.Name = "tsarchivo"
        Me.tsarchivo.Size = New System.Drawing.Size(60, 20)
        Me.tsarchivo.Text = "Archivo"
        '
        'tlinventario
        '
        Me.tlinventario.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarToolStripMenuItem, Me.AToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.BorrarToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.tlinventario.Name = "tlinventario"
        Me.tlinventario.Size = New System.Drawing.Size(72, 20)
        Me.tlinventario.Text = "Inventario"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AToolStripMenuItem.Text = "Agregar..."
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar..."
        '
        'BorrarToolStripMenuItem
        '
        Me.BorrarToolStripMenuItem.Name = "BorrarToolStripMenuItem"
        Me.BorrarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BorrarToolStripMenuItem.Text = "Borrar..."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(149, 6)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 252)
        Me.Controls.Add(Me.btnCompras)
        Me.Controls.Add(Me.btnVentas)
        Me.Controls.Add(Me.btnProveedores)
        Me.Controls.Add(Me.btnProductos)
        Me.Controls.Add(Me.btnClientes)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCompras As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnProveedores As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsarchivo As ToolStripMenuItem
    Friend WithEvents tlinventario As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
End Class
