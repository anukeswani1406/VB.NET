Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Question 1" Then
            RichTextBox1.Text = "Which is capital of India?"
            RadioButton1.Text = "Delhi"
            RadioButton2.Text = "Mumbai"
            RadioButton3.Text = "Pune"
            RadioButton4.Text = "Chennai"
        ElseIf ComboBox1.Text = "Question 2" Then
            RichTextBox1.Text = "Which is capital of Maharashtra?"
            RadioButton1.Text = "Delhi"
            RadioButton2.Text = "Mumbai"
            RadioButton3.Text = "Nagpur"
            RadioButton4.Text = "Chennai"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox(ComboBox1.SelectedItem)
        If ComboBox1.Text = "Question 1" And RadioButton1.Checked Then
            TextBox1.Text = "Answer is correct"
        ElseIf ComboBox1.Text = "Question 2" And RadioButton3.Checked Then
            TextBox1.Text = "Answer is correct"
        Else
            TextBox1.Text = "Answer is Wrong"
        End If
    End Sub
End Class
