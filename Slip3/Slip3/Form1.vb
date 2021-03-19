Public Class Form1
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Label1.Left > 400 Then
            Label1.Left = 10
        Else
            Label1.Left = Label1.Left + 15
        End If
    End Sub
End Class
