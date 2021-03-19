Imports System.IO

Public Class Form1
    Dim f As New FontDialog
    Dim c As New ColorDialog
    Dim s As New SaveFileDialog
    Dim op As New OpenFileDialog
    Dim filename As String
    Dim searh As String
    Dim sw As StreamWriter
    Dim sr As StreamReader

    'Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    '    RichTextBox1.Size = Me.Size
    'End Sub


    Private Sub FontStyleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontStyleToolStripMenuItem.Click
        If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
            RichTextBox1.Font = f.Font
        End If
    End Sub

    Private Sub FontColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontColorToolStripMenuItem.Click
        If c.ShowDialog() = Windows.Forms.DialogResult.OK Then
            RichTextBox1.ForeColor = c.Color
        End If
    End Sub

    Private Sub SaveToolToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolToolStripMenuItem.Click
        If s.ShowDialog = Windows.Forms.DialogResult.OK Then
            filename = s.FileName
            sw = New StreamWriter(filename)
            sw.Write(RichTextBox1.Text)
            sw.Close()
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        If op.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Process.Start(op.FileName)
            sr = New StreamReader(op.OpenFile)
            RichTextBox1.Text = sr.ReadToEnd()
            sr.Close()
        End If
    End Sub
End Class
