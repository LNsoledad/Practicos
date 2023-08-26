<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario1
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
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(27, 45)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(44, 13)
        Me.LNombre.TabIndex = 0
        Me.LNombre.Text = "Nombre"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(27, 89)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(44, 13)
        Me.LApellido.TabIndex = 1
        Me.LApellido.Text = "Apellido"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(101, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(101, 89)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(125, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(257, 45)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(206, 167)
        Me.TextBox3.TabIndex = 4
        '
        'BGuardar
        '
        Me.BGuardar.Location = New System.Drawing.Point(30, 173)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BGuardar.TabIndex = 5
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'BEliminar
        '
        Me.BEliminar.Location = New System.Drawing.Point(151, 173)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BEliminar.TabIndex = 6
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = True
        '
        'Formulario1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 273)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LApellido)
        Me.Controls.Add(Me.LNombre)
        Me.Name = "Formulario1"
        Me.Text = "Mi Primer Forms"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LNombre As System.Windows.Forms.Label
    Friend WithEvents LApellido As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents BGuardar As System.Windows.Forms.Button
    Friend WithEvents BEliminar As System.Windows.Forms.Button

End Class
