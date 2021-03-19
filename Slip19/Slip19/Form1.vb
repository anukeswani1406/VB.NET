Imports System.IO

Public Class Form1
    Dim s As New SaveFileDialog
    Dim sw As StreamWriter
    Dim filename As String

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        End
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox2.Paste()
    End Sub

    Private Sub CoptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CoptToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        If s.ShowDialog = Windows.Forms.DialogResult.OK Then
            filename = s.FileName
            sw = New StreamWriter(filename)
            sw.Write(RichTextBox1.Text)
            sw.Close()
        End If
    End Sub
End Class
