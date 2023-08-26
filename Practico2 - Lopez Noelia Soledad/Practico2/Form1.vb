Public Class Formulario1
    Dim Dato1 As Double
    Dim Dato2 As Double
    Dim Resul As Double
    Dim Ope As Double
    Dim Punto As Double

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTCE.Click
        TextBox1.Clear()
        BTPunto.Enabled = True
    End Sub

    Private Sub Formulario1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BT0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT0.Click
        TextBox1.Text = TextBox1.Text & "0"
    End Sub

    Private Sub BT1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT1.Click
        TextBox1.Text = TextBox1.Text & "1"
    End Sub

    Private Sub BT2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT2.Click
        TextBox1.Text = TextBox1.Text & "2"
    End Sub

    Private Sub BT3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT3.Click
        TextBox1.Text = TextBox1.Text & "3"
    End Sub

    Private Sub BT4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT4.Click
        TextBox1.Text = TextBox1.Text & "4"
    End Sub

    Private Sub BT5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT5.Click
        TextBox1.Text = TextBox1.Text & "5"
    End Sub

    Private Sub BT6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT6.Click
        TextBox1.Text = TextBox1.Text & "6"
    End Sub

    Private Sub BT7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT7.Click
        TextBox1.Text = TextBox1.Text & "7"
    End Sub

    Private Sub BT8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT8.Click
        TextBox1.Text = TextBox1.Text & "8"
    End Sub

    Private Sub BT9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT9.Click
        TextBox1.Text = TextBox1.Text & "9"
    End Sub

    Private Sub BTPunto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTPunto.Click
        TextBox1.Text = TextBox1.Text & "."
        Punto = 1
        If Punto = 1 Then
            BTPunto.Enabled = False
        End If
    End Sub

    Private Sub BTMas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTMas.Click
        Ope = 1
        Dato1 = Val(TextBox1.Text)
        TextBox1.Clear()
        BTPunto.Enabled = True
    End Sub

    Private Sub BTIgual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTIgual.Click
        Dato2 = Val(TextBox1.Text)
        If Ope = 1 Then
            Resul = Dato1 + Dato2
            TextBox1.Text = Resul
        Else
            If Ope = 2 Then
                Resul = Dato1 - Dato2
                TextBox1.Text = Resul
            Else
                If Ope = 3 Then
                    Resul = Dato1 * Dato2
                    TextBox1.Text = Resul
                Else
                    If Ope = 4 Then
                        Resul = Dato1 / Dato2
                        TextBox1.Text = Resul
                    End If
                End If
            End If
        End If
        BTPunto.Enabled = True
    End Sub

    Private Sub BTMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTMenos.Click
        Ope = 2
        Dato1 = Val(TextBox1.Text)
        TextBox1.Clear()
        BTPunto.Enabled = True
    End Sub

    Private Sub BTPor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTPor.Click
        Ope = 3
        Dato1 = Val(TextBox1.Text)
        TextBox1.Clear()
        BTPunto.Enabled = True
    End Sub

    Private Sub BTDividido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTDividido.Click
        Ope = 4
        Dato1 = Val(TextBox1.Text)
        TextBox1.Clear()
        BTPunto.Enabled = True
    End Sub
    Public Sub soloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        soloNumeros(e)
    End Sub
End Class
