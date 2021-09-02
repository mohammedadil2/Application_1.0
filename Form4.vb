Public Class Form4

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged, TextBox7.TextChanged, TextBox8.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        MsgBox("  تم تاكيد الحجز سوف تصلك رساله التاكيد في رقم الهاتف", MsgBoxStyle.OkOnly)
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox6.Text = Form2.DateTimePicker1.Value.ToString("yyyy/MM/dd")
        TextBox1.Text = Form3.TextBox1.Text
        TextBox2.Text = Form3.TextBox2.Text
        TextBox4.Text = Form3.TextBox4.Text
        TextBox3.Text = Form3.TextBox3.Text
        TextBox5.Text = Form2.ComboBox2.Text
        TextBox7.Text = Form2.ComboBox3.Text
        TextBox8.Text = Form2.ComboBox1.Text
        If TextBox8.Text = "الخاصه" Then
            Label8.Text = " 9000  $"
        Else
            Label8.Text = " 5000  $"
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click, Label11.Click

    End Sub
End Class