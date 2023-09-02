<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
		Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Me.THasta = New System.Windows.Forms.TextBox()
		Me.TDesde = New System.Windows.Forms.TextBox()
		Me.LHasta = New System.Windows.Forms.Label()
		Me.LDesde = New System.Windows.Forms.Label()
		Me.LListaNumeros = New System.Windows.Forms.Label()
		Me.BGenerarFuncion = New System.Windows.Forms.Button()
		Me.lst1 = New System.Windows.Forms.ListBox()
		Me.BNumerosPrimos = New System.Windows.Forms.Button()
		Me.BNumerosImpares = New System.Windows.Forms.Button()
		Me.BNumerosPares = New System.Windows.Forms.Button()
		Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.BMod = New System.Windows.Forms.Button()
		Me.TMod = New System.Windows.Forms.TextBox()
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'THasta
		'
		Me.THasta.Location = New System.Drawing.Point(59, 59)
		Me.THasta.Name = "THasta"
		Me.THasta.Size = New System.Drawing.Size(100, 20)
		Me.THasta.TabIndex = 8
		'
		'TDesde
		'
		Me.TDesde.Location = New System.Drawing.Point(59, 30)
		Me.TDesde.Name = "TDesde"
		Me.TDesde.Size = New System.Drawing.Size(100, 20)
		Me.TDesde.TabIndex = 7
		'
		'LHasta
		'
		Me.LHasta.AutoSize = True
		Me.LHasta.Location = New System.Drawing.Point(12, 62)
		Me.LHasta.Name = "LHasta"
		Me.LHasta.Size = New System.Drawing.Size(35, 13)
		Me.LHasta.TabIndex = 6
		Me.LHasta.Text = "Hasta"
		'
		'LDesde
		'
		Me.LDesde.AutoSize = True
		Me.LDesde.Location = New System.Drawing.Point(12, 33)
		Me.LDesde.Name = "LDesde"
		Me.LDesde.Size = New System.Drawing.Size(38, 13)
		Me.LDesde.TabIndex = 5
		Me.LDesde.Text = "Desde"
		'
		'LListaNumeros
		'
		Me.LListaNumeros.AutoSize = True
		Me.LListaNumeros.Location = New System.Drawing.Point(318, 4)
		Me.LListaNumeros.Name = "LListaNumeros"
		Me.LListaNumeros.Size = New System.Drawing.Size(89, 13)
		Me.LListaNumeros.TabIndex = 11
		Me.LListaNumeros.Text = "Lista de Numeros"
		'
		'BGenerarFuncion
		'
		Me.BGenerarFuncion.Location = New System.Drawing.Point(171, 33)
		Me.BGenerarFuncion.Name = "BGenerarFuncion"
		Me.BGenerarFuncion.Size = New System.Drawing.Size(110, 25)
		Me.BGenerarFuncion.TabIndex = 10
		Me.BGenerarFuncion.Text = "Generar Funcion"
		Me.BGenerarFuncion.UseVisualStyleBackColor = True
		'
		'lst1
		'
		Me.lst1.FormattingEnabled = True
		Me.lst1.Location = New System.Drawing.Point(297, 30)
		Me.lst1.Name = "lst1"
		Me.lst1.Size = New System.Drawing.Size(146, 186)
		Me.lst1.TabIndex = 9
		'
		'BNumerosPrimos
		'
		Me.BNumerosPrimos.Location = New System.Drawing.Point(171, 143)
		Me.BNumerosPrimos.Name = "BNumerosPrimos"
		Me.BNumerosPrimos.Size = New System.Drawing.Size(110, 21)
		Me.BNumerosPrimos.TabIndex = 14
		Me.BNumerosPrimos.Text = "Numeros Primos"
		Me.BNumerosPrimos.UseVisualStyleBackColor = True
		'
		'BNumerosImpares
		'
		Me.BNumerosImpares.Location = New System.Drawing.Point(171, 115)
		Me.BNumerosImpares.Name = "BNumerosImpares"
		Me.BNumerosImpares.Size = New System.Drawing.Size(110, 22)
		Me.BNumerosImpares.TabIndex = 13
		Me.BNumerosImpares.Text = "Numeros Impares"
		Me.BNumerosImpares.UseVisualStyleBackColor = True
		'
		'BNumerosPares
		'
		Me.BNumerosPares.Location = New System.Drawing.Point(171, 86)
		Me.BNumerosPares.Name = "BNumerosPares"
		Me.BNumerosPares.Size = New System.Drawing.Size(110, 23)
		Me.BNumerosPares.TabIndex = 12
		Me.BNumerosPares.Text = "Numeros Pares"
		Me.BNumerosPares.UseVisualStyleBackColor = True
		'
		'Chart1
		'
		ChartArea1.Name = "ChartArea1"
		Me.Chart1.ChartAreas.Add(ChartArea1)
		Legend1.Name = "Legend1"
		Me.Chart1.Legends.Add(Legend1)
		Me.Chart1.Location = New System.Drawing.Point(484, 12)
		Me.Chart1.Name = "Chart1"
		Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
		Series1.ChartArea = "ChartArea1"
		Series1.Legend = "Legend1"
		Series1.Name = "Series1"
		Me.Chart1.Series.Add(Series1)
		Me.Chart1.Size = New System.Drawing.Size(300, 300)
		Me.Chart1.TabIndex = 15
		Me.Chart1.Text = "Chart1"
		'
		'BMod
		'
		Me.BMod.Location = New System.Drawing.Point(38, 278)
		Me.BMod.Name = "BMod"
		Me.BMod.Size = New System.Drawing.Size(94, 34)
		Me.BMod.TabIndex = 16
		Me.BMod.Text = "Prueba funcion Mod"
		Me.BMod.UseVisualStyleBackColor = True
		'
		'TMod
		'
		Me.TMod.Location = New System.Drawing.Point(38, 241)
		Me.TMod.Name = "TMod"
		Me.TMod.Size = New System.Drawing.Size(100, 20)
		Me.TMod.TabIndex = 17
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(821, 353)
		Me.Controls.Add(Me.TMod)
		Me.Controls.Add(Me.BMod)
		Me.Controls.Add(Me.Chart1)
		Me.Controls.Add(Me.BNumerosPrimos)
		Me.Controls.Add(Me.BNumerosImpares)
		Me.Controls.Add(Me.BNumerosPares)
		Me.Controls.Add(Me.LListaNumeros)
		Me.Controls.Add(Me.BGenerarFuncion)
		Me.Controls.Add(Me.lst1)
		Me.Controls.Add(Me.THasta)
		Me.Controls.Add(Me.TDesde)
		Me.Controls.Add(Me.LHasta)
		Me.Controls.Add(Me.LDesde)
		Me.Name = "Form1"
		Me.Text = "Form1"
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents THasta As TextBox
	Friend WithEvents TDesde As TextBox
	Friend WithEvents LHasta As Label
	Friend WithEvents LDesde As Label
	Friend WithEvents LListaNumeros As Label
	Friend WithEvents BGenerarFuncion As Button
	Friend WithEvents lst1 As ListBox
	Friend WithEvents BNumerosPrimos As Button
	Friend WithEvents BNumerosImpares As Button
	Friend WithEvents BNumerosPares As Button
	Friend WithEvents Chart1 As DataVisualization.Charting.Chart
	Friend WithEvents BMod As Button
	Friend WithEvents TMod As TextBox
End Class
