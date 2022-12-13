<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModeAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ID_User = New System.Windows.Forms.TextBox()
        Me.Nama = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Jenis_User = New System.Windows.Forms.ComboBox()
        Me.Input = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Cari = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID_User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Jenis_User"
        '
        'ID_User
        '
        Me.ID_User.Location = New System.Drawing.Point(93, 26)
        Me.ID_User.Name = "ID_User"
        Me.ID_User.Size = New System.Drawing.Size(267, 20)
        Me.ID_User.TabIndex = 1
        '
        'Nama
        '
        Me.Nama.Location = New System.Drawing.Point(93, 51)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(267, 20)
        Me.Nama.TabIndex = 1
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(93, 78)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(267, 20)
        Me.Password.TabIndex = 1
        '
        'Jenis_User
        '
        Me.Jenis_User.FormattingEnabled = True
        Me.Jenis_User.Items.AddRange(New Object() {"Admin", "User"})
        Me.Jenis_User.Location = New System.Drawing.Point(93, 105)
        Me.Jenis_User.Name = "Jenis_User"
        Me.Jenis_User.Size = New System.Drawing.Size(121, 21)
        Me.Jenis_User.TabIndex = 2
        '
        'Input
        '
        Me.Input.Location = New System.Drawing.Point(13, 137)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(75, 23)
        Me.Input.TabIndex = 3
        Me.Input.Text = "Input"
        Me.Input.UseVisualStyleBackColor = True
        '
        'Edit
        '
        Me.Edit.Location = New System.Drawing.Point(111, 137)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(75, 23)
        Me.Edit.TabIndex = 3
        Me.Edit.Text = "Edit"
        Me.Edit.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(212, 137)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(75, 23)
        Me.Delete.TabIndex = 3
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 166)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(632, 150)
        Me.DataGridView1.TabIndex = 4
        '
        'Cari
        '
        Me.Cari.Location = New System.Drawing.Point(329, 105)
        Me.Cari.Name = "Cari"
        Me.Cari.Size = New System.Drawing.Size(267, 20)
        Me.Cari.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(275, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Cari"
        '
        'ModeAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 322)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.Input)
        Me.Controls.Add(Me.Jenis_User)
        Me.Controls.Add(Me.Cari)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.ID_User)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ModeAdmin"
        Me.Text = "ModeAdmin"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ID_User As System.Windows.Forms.TextBox
    Friend WithEvents Nama As System.Windows.Forms.TextBox
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents Jenis_User As System.Windows.Forms.ComboBox
    Friend WithEvents Input As System.Windows.Forms.Button
    Friend WithEvents Edit As System.Windows.Forms.Button
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Cari As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
