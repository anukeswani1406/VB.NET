Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim no As Integer
        Dim sqr As Double
        Dim rm As Integer
        Dim str1 As String

        no = CInt(TextBox1.Text)
        sqr = Math.Sqrt(no)

        While no
            rm = no Mod 2
            str1 = str1 & rm
            no = no \ 2
        End While

        MsgBox(sqr & " and " & StrReverse(str1))
    End Sub
End Class
