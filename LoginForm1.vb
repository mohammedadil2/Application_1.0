Public Class LoginForm1



    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If PasswordTextBox.Text = "" And UsernameTextBox.Text = "" Then

            MsgBox("الرجاء ادخال جميع البيانات", MsgBoxStyle.Exclamation)


        ElseIf UsernameTextBox.Text = "root" And PasswordTextBox.Text = "123456" Then
            Me.Hide()
            Form2.Show()

        Else
            MsgBox("خطأ  في اسم المستحدم او كلمه السر")


        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
