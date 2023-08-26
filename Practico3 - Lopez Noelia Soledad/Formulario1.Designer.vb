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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formulario1))
        Me.LDni = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.LNya = New System.Windows.Forms.Label()
        Me.LModificar = New System.Windows.Forms.Label()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CMastercard = New System.Windows.Forms.CheckBox()
        Me.CVisa = New System.Windows.Forms.CheckBox()
        Me.CNaranja = New System.Windows.Forms.CheckBox()
        Me.LTarjetaCredito = New System.Windows.Forms.Label()
        Me.TTelefono = New System.Windows.Forms.TextBox()
        Me.LTelefono = New System.Windows.Forms.Label()
        Me.LNuevoCliente = New System.Windows.Forms.Label()
        Me.RBMujer = New System.Windows.Forms.RadioButton()
        Me.RBVaron = New System.Windows.Forms.RadioButton()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.ForeColor = System.Drawing.Color.Red
        Me.LDni.Location = New System.Drawing.Point(15, 64)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(26, 13)
        Me.LDni.TabIndex = 0
        Me.LDni.Text = "DNI"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(15, 143)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(44, 13)
        Me.LNombre.TabIndex = 1
        Me.LNombre.Text = "Nombre"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(15, 104)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(44, 13)
        Me.LApellido.TabIndex = 4
        Me.LApellido.Text = "Apellido"
        '
        'LNya
        '
        Me.LNya.AutoSize = True
        Me.LNya.Location = New System.Drawing.Point(15, 23)
        Me.LNya.Name = "LNya"
        Me.LNya.Size = New System.Drawing.Size(92, 13)
        Me.LNya.TabIndex = 5
        Me.LNya.Text = "Nombre y Apellido"
        '
        'LModificar
        '
        Me.LModificar.AutoSize = True
        Me.LModificar.Location = New System.Drawing.Point(151, 23)
        Me.LModificar.Name = "LModificar"
        Me.LModificar.Size = New System.Drawing.Size(50, 13)
        Me.LModificar.TabIndex = 6
        Me.LModificar.Text = "Modificar"
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(65, 143)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(267, 20)
        Me.TNombre.TabIndex = 7
        '
        'TApellido
        '
        Me.TApellido.Location = New System.Drawing.Point(65, 104)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(267, 20)
        Me.TApellido.TabIndex = 8
        '
        'TDni
        '
        Me.TDni.Location = New System.Drawing.Point(65, 64)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(267, 20)
        Me.TDni.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.CMastercard)
        Me.Panel1.Controls.Add(Me.CVisa)
        Me.Panel1.Controls.Add(Me.CNaranja)
        Me.Panel1.Controls.Add(Me.LTarjetaCredito)
        Me.Panel1.Controls.Add(Me.TTelefono)
        Me.Panel1.Controls.Add(Me.LTelefono)
        Me.Panel1.Controls.Add(Me.LNya)
        Me.Panel1.Controls.Add(Me.TNombre)
        Me.Panel1.Controls.Add(Me.TApellido)
        Me.Panel1.Controls.Add(Me.TDni)
        Me.Panel1.Controls.Add(Me.LModificar)
        Me.Panel1.Controls.Add(Me.LNombre)
        Me.Panel1.Controls.Add(Me.LApellido)
        Me.Panel1.Controls.Add(Me.LDni)
        Me.Panel1.Location = New System.Drawing.Point(12, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(353, 355)
        Me.Panel1.TabIndex = 10
        '
        'CMastercard
        '
        Me.CMastercard.AutoSize = True
        Me.CMastercard.Location = New System.Drawing.Point(136, 296)
        Me.CMastercard.Name = "CMastercard"
        Me.CMastercard.Size = New System.Drawing.Size(79, 17)
        Me.CMastercard.TabIndex = 15
        Me.CMastercard.Text = "Mastercard"
        Me.CMastercard.UseVisualStyleBackColor = True
        '
        'CVisa
        '
        Me.CVisa.AutoSize = True
        Me.CVisa.Location = New System.Drawing.Point(136, 263)
        Me.CVisa.Name = "CVisa"
        Me.CVisa.Size = New System.Drawing.Size(46, 17)
        Me.CVisa.TabIndex = 14
        Me.CVisa.Text = "Visa"
        Me.CVisa.UseVisualStyleBackColor = True
        '
        'CNaranja
        '
        Me.CNaranja.AutoSize = True
        Me.CNaranja.Location = New System.Drawing.Point(136, 229)
        Me.CNaranja.Name = "CNaranja"
        Me.CNaranja.Size = New System.Drawing.Size(63, 17)
        Me.CNaranja.TabIndex = 13
        Me.CNaranja.Text = "Naranja"
        Me.CNaranja.UseVisualStyleBackColor = True
        '
        'LTarjetaCredito
        '
        Me.LTarjetaCredito.AutoSize = True
        Me.LTarjetaCredito.Location = New System.Drawing.Point(15, 229)
        Me.LTarjetaCredito.Name = "LTarjetaCredito"
        Me.LTarjetaCredito.Size = New System.Drawing.Size(95, 13)
        Me.LTarjetaCredito.TabIndex = 12
        Me.LTarjetaCredito.Text = "Tarjeta de creditos"
        '
        'TTelefono
        '
        Me.TTelefono.Location = New System.Drawing.Point(65, 185)
        Me.TTelefono.Name = "TTelefono"
        Me.TTelefono.Size = New System.Drawing.Size(267, 20)
        Me.TTelefono.TabIndex = 11
        '
        'LTelefono
        '
        Me.LTelefono.AutoSize = True
        Me.LTelefono.Location = New System.Drawing.Point(15, 185)
        Me.LTelefono.Name = "LTelefono"
        Me.LTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LTelefono.TabIndex = 10
        Me.LTelefono.Text = "Telefono"
        '
        'LNuevoCliente
        '
        Me.LNuevoCliente.AutoSize = True
        Me.LNuevoCliente.Font = New System.Drawing.Font("Montserrat", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNuevoCliente.Location = New System.Drawing.Point(259, 3)
        Me.LNuevoCliente.Name = "LNuevoCliente"
        Me.LNuevoCliente.Size = New System.Drawing.Size(208, 33)
        Me.LNuevoCliente.TabIndex = 16
        Me.LNuevoCliente.Text = "Nuevo Cliente"
        '
        'RBMujer
        '
        Me.RBMujer.AutoSize = True
        Me.RBMujer.Location = New System.Drawing.Point(422, 302)
        Me.RBMujer.Name = "RBMujer"
        Me.RBMujer.Size = New System.Drawing.Size(51, 17)
        Me.RBMujer.TabIndex = 18
        Me.RBMujer.Text = "Mujer"
        Me.RBMujer.UseVisualStyleBackColor = True
        '
        'RBVaron
        '
        Me.RBVaron.AutoSize = True
        Me.RBVaron.Location = New System.Drawing.Point(491, 302)
        Me.RBVaron.Name = "RBVaron"
        Me.RBVaron.Size = New System.Drawing.Size(53, 17)
        Me.RBVaron.TabIndex = 19
        Me.RBVaron.TabStop = True
        Me.RBVaron.Text = "Varon"
        Me.RBVaron.UseVisualStyleBackColor = True
        '
        'BSalir
        '
        Me.BSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSalir.Image = CType(resources.GetObject("BSalir.Image"), System.Drawing.Image)
        Me.BSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSalir.Location = New System.Drawing.Point(415, 400)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(169, 75)
        Me.BSalir.TabIndex = 20
        Me.BSalir.Text = "Salir"
        Me.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(398, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 246)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'BEliminar
        '
        Me.BEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminar.Image = CType(resources.GetObject("BEliminar.Image"), System.Drawing.Image)
        Me.BEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BEliminar.Location = New System.Drawing.Point(191, 400)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(174, 75)
        Me.BEliminar.TabIndex = 3
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BEliminar.UseVisualStyleBackColor = True
        '
        'BGuardar
        '
        Me.BGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BGuardar.Image = CType(resources.GetObject("BGuardar.Image"), System.Drawing.Image)
        Me.BGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BGuardar.Location = New System.Drawing.Point(12, 400)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(155, 75)
        Me.BGuardar.TabIndex = 2
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'Formulario1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 494)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.RBVaron)
        Me.Controls.Add(Me.RBMujer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LNuevoCliente)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BGuardar)
        Me.Name = "Formulario1"
        Me.Text = "Pequeño Formulario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LDni As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents BGuardar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents LApellido As Label
    Friend WithEvents LNya As Label
    Friend WithEvents LModificar As Label
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents TDni As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LTelefono As Label
    Friend WithEvents TTelefono As TextBox
    Friend WithEvents CMastercard As CheckBox
    Friend WithEvents CVisa As CheckBox
    Friend WithEvents CNaranja As CheckBox
    Friend WithEvents LTarjetaCredito As Label
    Friend WithEvents LNuevoCliente As Label
    Friend WithEvents RBMujer As RadioButton
    Friend WithEvents RBVaron As RadioButton
    Friend WithEvents BSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
