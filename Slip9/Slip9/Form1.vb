Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = Format(DateTimePicker1.Value, "dd")
        TextBox2.Text = datetimepicker1.value.month
        TextBox3.Text = datetimepicker1.value.year
    End Sub
End Class
