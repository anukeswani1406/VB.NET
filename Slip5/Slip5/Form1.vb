Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim no(10) As Integer
        Dim i As Integer
        Dim num As Integer
        Dim num2 As Integer
        Dim r As Integer
        Dim armno As Integer
        Dim perfct As Integer
        Dim cntarm As Integer
        Dim cntperfct As Integer
        Dim nm As Integer

        For i = 0 To 5 - 1
            no(i) = CInt(InputBox("Enter Number"))
        Next

        For i = 0 To 5 - 1
            num = no(i)
            armno = 0
            perfct = 0
            num2 = num

            While num
                r = num Mod 10
                armno = armno + r * r * r
                num = num \ 10
            End While

            If armno = num2 Then
                cntarm = cntarm + 1
            End If

            num = num2
            nm = 1

            While nm <= num2 \ 2
                If num2 Mod nm = 0 Then
                    perfct = perfct + nm
                End If
                nm = nm + 1
            End While

            If perfct = num Then
                cntperfct = cntperfct + 1
            End If
        Next

        MsgBox("Armstrong numbers " & cntarm)
        MsgBox("Perfect numbers " & cntperfct)
    End Sub
End Class
