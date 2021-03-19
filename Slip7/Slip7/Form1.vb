Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox9.Text = CInt(TextBox2.Text) + CInt(TextBox3.Text) + CInt(TextBox4.Text) + CInt(TextBox5.Text) + CInt(TextBox6.Text) - CInt(TextBox7.Text) - CInt(TextBox8.Text)

        MsgBox(TextBox1.Text & TextBox9.Text)
    End Sub
End Class
