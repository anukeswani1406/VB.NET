Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim c As String
        Dim asc1 As Integer

        c = TextBox1.Text
        asc1 = Asc(c)

        If c = "a" Or c = "A" Or c = "e" Or c = "E" Or c = "i" Or c = "I" Or c = "o" Or c = "O" Or c = "u" Or c = "U" Then
            If asc1 <= 122 And asc1 >= 97 Then
                MsgBox("vowel in Lowercase")
            Else
                MsgBox("vowel in Uppercase")
            End If
        ElseIf asc1 <= 122 And asc1 >= 97 Then
            MsgBox("Not Vowel in Lowercase")
        Else
            MsgBox("Not Vowel in Uppercase")
        End If
    End Sub
End Class
