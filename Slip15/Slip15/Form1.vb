Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TreeView1.Nodes.Add("Computer Science")
        TreeView1.Nodes(0).Nodes.Add("BCA")
        TreeView1.Nodes(0).Nodes.Add("BCS")
        TreeView1.Nodes(0).Nodes.Add("MCA")
        TreeView1.Nodes(0).Nodes(0).Nodes.Add("FYBCA")
        TreeView1.Nodes(0).Nodes(0).Nodes.Add("SYBCA")
        TreeView1.Nodes(0).Nodes(0).Nodes.Add("TYBCA")
        TreeView1.Nodes(0).Nodes(1).Nodes.Add("FYBCS")
        TreeView1.Nodes(0).Nodes(1).Nodes.Add("SYBCS")
        TreeView1.Nodes(0).Nodes(1).Nodes.Add("TYBCS")
        TreeView1.Nodes(0).Nodes(2).Nodes.Add("MCA(I)")
        TreeView1.Nodes(0).Nodes(2).Nodes.Add("MCA(II)")
        TreeView1.Nodes(0).Nodes(2).Nodes.Add("MCA(III)")
    End Sub
End Class
