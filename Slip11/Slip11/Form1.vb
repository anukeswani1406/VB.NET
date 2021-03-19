Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sentence As String
        Dim i As Integer
        Dim wc As Integer
        sentence = TextBox1.Text

        Dim arr() As Char = sentence.ToCharArray()
        For i = 0 To arr.Length - 1
            If arr(i) = " " Then
                wc = wc + 1
            End If
        Next

        MsgBox("Total Words " & wc + 1)
    End Sub
End Class
