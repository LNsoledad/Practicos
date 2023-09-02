Public Class Form1
	Private Sub BGenerarFuncion_Click(sender As Object, e As EventArgs) Handles BGenerarFuncion.Click
		Dim i As Integer
		lst1.Items.Clear()
		If Not (String.IsNullOrEmpty(TDesde.Text) Or String.IsNullOrEmpty(THasta.Text)) Then
			i = Val(TDesde.Text)
			While i <= Val(THasta.Text)
				lst1.Items.Add(i)
				i = i + 1
			End While

		End If
	End Sub

	Private Sub TDesde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDesde.KeyPress
		If Char.IsDigit(e.KeyChar) Then
			e.Handled = False
		ElseIf Char.IsControl(e.KeyChar) Then
			e.Handled = False
		Else
			e.Handled = True
			MsgBox("Solo se admiten numeros", MsgBoxStyle.Information, "Error")
		End If
	End Sub

	Private Sub THasta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles THasta.KeyPress
		If Char.IsDigit(e.KeyChar) Then
			e.Handled = False
		ElseIf Char.IsControl(e.KeyChar) Then
			e.Handled = False
		Else
			e.Handled = True
			MsgBox("Solo se admiten numeros", MsgBoxStyle.Information, "Error")
		End If
	End Sub

	Private Sub BNumerosPares_Click(sender As Object, e As EventArgs) Handles BNumerosPares.Click
		Dim i As Integer
		lst1.Items.Clear()
		Chart1.Series.Clear()
		If Not (String.IsNullOrEmpty(TDesde.Text) Or String.IsNullOrEmpty(THasta.Text)) Then
			i = Val(TDesde.Text)
			While i <= Val(THasta.Text)
				If (i Mod 2 = 0) Then
					lst1.Items.Add(i)
					Chart1.Series.Add("Pares" & i).Points.AddXY(i, i)
				End If
				i = i + 1
			End While
		End If
	End Sub

	Private Sub BNumerosImpares_Click(sender As Object, e As EventArgs) Handles BNumerosImpares.Click
		Dim i As Integer
		lst1.Items.Clear()
		Chart1.Series.Clear()
		If Not (String.IsNullOrEmpty(TDesde.Text) Or String.IsNullOrEmpty(THasta.Text)) Then
			i = Val(TDesde.Text)
			While i <= Val(THasta.Text)
				If (i Mod 2 <> 0) Then
					lst1.Items.Add(i)
					Chart1.Series.Add("Impares" & i).Points.AddXY(i, i)
				End If
				i = i + 1
			End While
		End If
	End Sub

	Private Sub BNumerosPrimos_Click(sender As Object, e As EventArgs) Handles BNumerosPrimos.Click
		Dim n As Integer
		lst1.Items.Clear()
		Chart1.Series.Clear()
		If Not (String.IsNullOrEmpty(TDesde.Text) Or String.IsNullOrEmpty(THasta.Text)) Then
			For i = Val(TDesde.Text) To Val(THasta.Text)
				n = 0
				For j = 1 To i
					If ((i Mod j) = 0) Then
						n = n + 1
					End If
				Next j
				If (n = 2) Then
					lst1.Items.Add(i)
					Chart1.Series.Add("Primos" & i).Points.AddXY(i, i)

				End If
			Next i
		End If
	End Sub

	Private Sub BMod_Click(sender As Object, e As EventArgs) Handles BMod.Click
		Dim valor As Integer
		valor = Val(TMod.Text)

		If (valor Mod 2 = 0) Then

			TMod.Text = "Es par"

		Else

			TMod.Text = "Es Impar"

		End If
	End Sub
End Class
