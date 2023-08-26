Public Class Formulario1
    Private Sub LNya_Click(sender As Object, e As EventArgs) Handles LNya.Click

    End Sub

    Private Sub LModificar_Click(sender As Object, e As EventArgs) Handles LModificar.Click

    End Sub

    Private Sub LDni_Click(sender As Object, e As EventArgs) Handles LDni.Click

    End Sub

    Private Sub LApellido_Click(sender As Object, e As EventArgs) Handles LApellido.Click

    End Sub

    Private Sub LNombre_Click(sender As Object, e As EventArgs) Handles LNombre.Click

    End Sub


    'Funcion para que solo permite el ingreso de caracteres tipo numerico
    Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Ingresar Números", MsgBoxStyle.Critical, "Ingreso de Número")
        End If
    End Sub

    Private Sub TDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDni.KeyPress
        SoloNumeros(e)
    End Sub

    'Funcion para que solo permite el ingreso de caracteres tipo letra
    Sub SoloLetras(ByRef u As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(u.KeyChar) Then
            u.Handled = True
            MsgBox("Ingresar Letras", MsgBoxStyle.Critical, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            u.Handled = False
        Else
            u.Handled = False
        End If
    End Sub

    Private Sub TApellido_KeyPress(sender As Object, u As KeyPressEventArgs) Handles TApellido.KeyPress
        SoloLetras(u)

    End Sub

    Private Sub TNombre_TextChanged(sender As Object, u As KeyPressEventArgs) Handles TNombre.KeyPress
        SoloLetras(u)
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Dim Pregunta As String
        Pregunta = MsgBox("Seguro que desea insertar un nuevo Cliente?", vbYesNo + vbQuestion, "Confirmar Insercion")
        LModificar.Text = (TApellido.Text & " " & TNombre.Text)
        If TDni.Text = "" Or TApellido.Text = "" Or TNombre.Text = "" Or TTelefono.Text = "" Then
            '''''''''''''''''''SOLO AQUI PUEDE EXISTIR UN ESPACION ENTRE LA LINEA ANTERIOR Y LA POSTERIOR And OptionButton1 = False _ Or OptionButton2 = False And OptionButton3 = False Then
            MsgBox("Debe Completar Todos los campos", MsgBoxStyle.Critical, "Error")
        ElseIf Pregunta = vbYes Then
            MsgBox("El Cliente " & TApellido.Text & " " & TNombre.Text & " se inserto correctamente.", MsgBoxStyle.Information, "Guardar")
        Else
            Stop
        End If

    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Dim Pregunta As String
        Dim Apellido As String
        Dim Nombre As String
        Apellido = TApellido.Text
        Nombre = TNombre.Text
        Pregunta = MsgBox("Esta a punto de eliminar al Cliente " & TApellido.Text & " " & TNombre.Text & ".", vbYesNo + vbExclamation, "Confirmar eliminacion")
        If Pregunta = vbYes Then
            TApellido.Clear()
            TDni.Clear()
            TNombre.Clear()
            TTelefono.Clear()
            LModificar.Text = " "
            MsgBox("El Cliente " & Apellido & " " & Nombre & " se Elimino correctamente.", MsgBoxStyle.Information, "Eliminar")
        End If
    End Sub

    Private Sub TDni_TextChanged(sender As Object, e As EventArgs) Handles TDni.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub RMujer_CheckedChanged(sender As Object, e As EventArgs) Handles RBMujer.CheckedChanged
        PictureBox1.BackgroundImage = My.Resources.AvatarMujer1
    End Sub

    Private Sub RBVaron_CheckedChanged(sender As Object, e As EventArgs) Handles RBVaron.CheckedChanged
        PictureBox1.BackgroundImage = My.Resources.AvatarVaron
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub

    Private Sub LTelefono_Click(sender As Object, e As EventArgs) Handles LTelefono.Click

    End Sub

    Private Sub TTelefono_TextChanged(sender As Object, e As EventArgs) Handles TTelefono.TextChanged

    End Sub

    Private Sub Formulario1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
