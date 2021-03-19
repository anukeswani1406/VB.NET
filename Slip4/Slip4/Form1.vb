Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As Integer
        Dim i As Integer
        n = CInt(InputBox("Enter Number"))

        For i = 1 To 10
            ListBox1.Items.Add(n * i)
        Next
    End Sub
End Class
