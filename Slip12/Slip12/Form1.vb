Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Add(CInt(TextBox1.Text))
        TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i As Integer
        Dim cnt As Integer
        Dim num As Integer
        Dim f As Integer
        Dim j As Integer
        cnt = ListBox1.Items.Count

        Try
            For i = 0 To cnt - 1
                num = ListBox1.Items(i)
                f = 0

                For j = 2 To num \ 2
                    If num Mod j = 0 Then
                        f = 1
                    End If
                Next

                If f = 0 Then
                    ListBox2.Items.Add(ListBox1.Items(i))
                    ListBox1.Items.RemoveAt(i)
                    cnt = cnt - 1
                    i = i - 1
                End If
            Next

        Catch ex As Exception
        End Try
    End Sub
End Class
