Public Class Form1
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'compile time ---> timer property ---> enabled = true
        'compile time ---> timer property ---> interval = 500

        If PictureBox1.Visible = True Then
            PictureBox1.Visible = False
        Else
            PictureBox1.Visible = True
        End If
    End Sub
End Class
