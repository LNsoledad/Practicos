Public Class Form1
	Dim RB As String

	Private Sub BFoto_Click(sender As Object, e As EventArgs) Handles BFoto.Click
		Dim OpenFileDialog1 As New OpenFileDialog

		OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
		OpenFileDialog1.Filter = "Archivos Imagenes|*.jpg|Archivos Imagenes|*.bmp|Archivos
Imagenes|*.png"
		If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

			PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
			Tfoto.Text = OpenFileDialog1.FileName
			MsgBox(OpenFileDialog1.FileName)

		End If
	End Sub

	Private Sub TNombre_TextChanged(sender As Object, e As EventArgs) Handles TNombre.TextChanged
		Dim i As Integer
		TNombre.Text = StrConv(TNombre.Text, VbStrConv.ProperCase)
		i = Len(TNombre.Text)
		TNombre.SelectionStart = i
	End Sub

	Private Sub TApellido_TextChanged(sender As Object, e As EventArgs) Handles TApellido.TextChanged
		Dim i As Integer
		TApellido.Text = StrConv(TApellido.Text, VbStrConv.ProperCase)
		i = Len(TApellido.Text)
		TApellido.SelectionStart = i
	End Sub

	Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

		If RadioButton1.Checked = True Then

			RB = "Hombre"

		Else

			RB = "Mujer"

		End If

	End Sub

	Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
		If RadioButton2.Checked = True Then

			RB = "Mujer"

		Else

			RB = "Hombre"

		End If
	End Sub



	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Dim resultado As MsgBoxResult

		If (TNombre.Text.Length = 0 Or TApellido.Text.Length = 0 Or TSaldo.Text.Length = 0 Or TFoto.Text.Length = 0) Then

			MsgBox("Debe Completar todos los campos", vbCritical, "ERROR")

		Else
			resultado = MessageBox.Show("Seguro que desea guardar?", "Confirmar Inserción",
									 MessageBoxButtons.YesNo, MessageBoxIcon.Question)
			If resultado = vbYes Then

				DataGridView1.RowTemplate.Height = 50
				DataGridView1.Rows.Add(TApellido.Text, TNombre.Text, DateTimePicker1.Text, RB, "Eliminar", TSaldo.Text, PictureBox1.Image, TFoto.Text)
				Column1.DefaultCellStyle.Font = New Font("Monotype Corsiva", 15, FontStyle.Italic)
				Column2.DefaultCellStyle.Font = New Font("Monotype Corsiva", 15, FontStyle.Italic)
				For Each r As DataGridViewRow In DataGridView1.Rows

					If r.Cells("Column6").Value < 50 Then

						r.DefaultCellStyle.BackColor = Color.Red

					End If

				Next
				Column7.ImageLayout = DataGridViewImageCellLayout.Stretch
			End If
		End If

	End Sub

	Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
		Dim senderGrid = DirectCast(sender, DataGridView)
		If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
			Dim ask As MsgBoxResult = MsgBox("Desea elminar este registro?", MsgBoxStyle.YesNo)
			If ask = MsgBoxResult.Yes Then
				DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
				MsgBox("se elimino correctamente", MsgBoxStyle.OkOnly, "Eliminar")
			End If
		End If
	End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class
