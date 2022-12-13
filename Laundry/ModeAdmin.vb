Imports System.Data.SqlClient
Public Class ModeAdmin
    Sub FirstCondition()
        ID_User.Text = ""
        Nama.Text = ""
        Password.Text = ""
        Jenis_User.Text = ""
        Cari.Text = ""
        Tampil_Data_Grid()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Input.Click
        koneksi()
        Dim input As String = "insert into Table_User values ('" & ID_User.Text & "','" & Nama.Text & "','" & Password.Text & "', '" & Jenis_User.Text & "')"
        Cmd = New SqlCommand(input, conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Input Data Berhasil")
        FirstCondition()
    End Sub

    Private Sub ModeAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FirstCondition()
    End Sub

    Sub Tampil_Data_Grid()
        koneksi()
        data = New SqlDataAdapter("select * from Table_User", conn)
        datas = New DataSet
        data.Fill(datas, "Table_User")
        DataGridView1.DataSource = datas.Tables("Table_User")
    End Sub

    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
        koneksi()
        Dim edit As String = "update Table_User set IdUser = '" & ID_User.Text & "', NamaUser = '" & Nama.Text & "', PasswordUser = '" & Password.Text & "',LevelUser = '" & Jenis_User.Text & "' where IdUser = '" & ID_User.Text & "'"
        Cmd = New SqlCommand(edit, conn)
        Cmd.ExecuteNonQuery()
        MsgBox("edit Data Berhasil")
        FirstCondition()
    End Sub

    Private Sub ID_User_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ID_User.KeyPress
        If e.KeyChar = Chr(13) Then
            koneksi()
            Cmd = New SqlCommand("select * from Table_User where IdUser = '" & ID_User.Text & "'", conn)
            read = Cmd.ExecuteReader
            read.Read()
            If Not read.HasRows Then
                MsgBox("Id User Tidak Ada")
            Else
                ID_User.Text = read.Item("IdUser")
                Nama.Text = read.Item("NamaUser")
                Password.Text = read.Item("PasswordUser")
                Jenis_User.Text = read.Item("LevelUser")

            End If
        End If
    End Sub

    Private Sub Cari_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cari.KeyPress
        If e.KeyChar = Chr(13) Then
            koneksi()
            Cmd = New SqlCommand("select * from Table_User where IdUser = '" & Cari.Text & "'", conn)
            read = Cmd.ExecuteReader
            read.Read()
            If Not read.HasRows Then
                MsgBox("Id User Tidak Ada")
            Else
                ID_User.Text = read.Item("IdUser")
                Nama.Text = read.Item("NamaUser")
                Password.Text = read.Item("PasswordUser")
                Jenis_User.Text = read.Item("LevelUser")
            End If
        End If
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        koneksi()
        Dim hapus As String = "delete from Table_User where IdUser = '" & ID_User.Text & "'"
        Cmd = New SqlCommand(hapus, conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Hapus Data Berhasil")
        FirstCondition()
    End Sub
End Class