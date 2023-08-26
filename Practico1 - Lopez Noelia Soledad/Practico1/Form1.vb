Public Class Formulario1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LNombre.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BGuardar.Click
        Dim concateno As String
        concateno = TextBox1.Text + " " + TextBox2.Text
        TextBox3.Text = concateno
    End Sub

    Private Sub BEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEliminar.Click
        TextBox3.Clear()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Formulario1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
