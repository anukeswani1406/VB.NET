﻿Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str1 As String
        str1 = TextBox1.Text

        If str1 = StrReverse(str1) Then
            MsgBox("String is Palindrome")
        Else
            MsgBox("String is Not Palindrome")
        End If
    End Sub
End Class
