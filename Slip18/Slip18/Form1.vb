Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim name As String
        Dim post As String
        Dim qual As String = ""

        name = TextBox1.Text

        If RadioButton1.Checked = True Then
            post = "Manager"
        ElseIf RadioButton2.Checked = True Then
            post = "Engineer"
        ElseIf RadioButton3.Checked = True Then
            post = "Accountant"
        Else
            post = "Manager"
        End If

        If CheckBox1.Checked Then
            qual = qual & "BE "
        End If
        If CheckBox2.Checked Then
            qual = qual & "MBA "
        End If
        If CheckBox3.Checked Then
            qual = qual & "Graduate "
        End If
        If CheckBox4.Checked Then
            qual = qual & "CA "
        End If

        MessageBox.Show("Name: " & name & " Post: " & post & " Qualification: " & qual, "Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
