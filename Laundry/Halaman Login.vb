Imports System.Data.SqlClient
Public Class Login
    Sub first_condition()
        TextBox1.Text = "Admin"
        TextBox2.Text = "Admin"
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_close.Click
        Me.Close()
    End Sub

    Private Sub Button_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Login.Click
        Call koneksi()
        Cmd = New SqlCommand("select * from Table_User where IdUser = '" & TextBox1.Text & "' and PasswordUser = '" & TextBox2.Text & "' ", conn)
        read = Cmd.ExecuteReader
        read.Read()
        If read.HasRows Then
            MsgBox(" Berhasil Login ")
            Me.Close()
            unlocked()
        Else
            MsgBox("Username Tidak Terdaftar")

        End If
    End Sub

    Sub unlocked()
        HalamanUtama.TransaksiToolStripMenuItem.Visible = True
        HalamanUtama.AdminToolStripMenuItem.Visible = True
        HalamanUtama.LaporanToolStripMenuItem.Visible = True
        HalamanUtama.OptionsToolStripMenuItem.Visible = True
        HalamanUtama.LogoutToolStripMenuItem.Visible = True
        HalamanUtama.LoginToolStripMenuItem.Visible = False
    End Sub
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        first_condition()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class