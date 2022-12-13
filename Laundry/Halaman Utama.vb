Public Class HalamanUtama

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        Login.Show()
    End Sub

    Sub locked()
        TransaksiToolStripMenuItem.Visible = False
        AdminToolStripMenuItem.Visible = False
        LaporanToolStripMenuItem.Visible = False
        OptionsToolStripMenuItem.Visible = False
        LogoutToolStripMenuItem.Visible = False
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        locked()
    End Sub

    Private Sub AdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminToolStripMenuItem.Click
        ModeAdmin.Show()
    End Sub
End Class
