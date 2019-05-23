Public Class settinguser
    Dim tabel As DataTable
    Dim item As ListViewItem
    Dim foto As String
    Dim edit As Boolean
    Private Sub settinguser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call display()
        PictureBox1.ImageLocation = ""
        ComboBox1.SelectedIndex = 0
    End Sub

    Sub insert()
            eksekusinonquery("insert into pegawai values('" & tbNip.Text & "','" & tbnama.Text & "','" & ComboBox1.Text & "','" & tbPass.Text & "','" & tbalamat.Text & "','" & tbNoHp.Text & "')")
            Dim a() As String = foto.Split("\")
            Dim b() As String = a(a.Length - 1).Split(".")
            Try
                My.Computer.FileSystem.CopyFile(foto, pathaplikasi & "temp\" & a(a.Length - 1))
                My.Computer.FileSystem.RenameFile(pathaplikasi & "temp\" & a(a.Length - 1), tbNip.Text & "." & b(b.Length - 1))
                My.Computer.FileSystem.MoveFile(pathaplikasi & "temp\" & tbNip.Text & "." & b(b.Length - 1), pathaplikasi & "fotopegawai\" & tbNip.Text & "." & b(b.Length - 1))
            Catch ex As Exception
            End Try
        If eror = False Then
            Call clear()
            Call display()
        End If

    End Sub

    Sub delete()
        With DataGridView1
            eksekusiNonQuery("delete from pegawai where nip =" & .Item(0, DataGridView1.CurrentRow.Index).Value.ToString)
            Try
                My.Computer.FileSystem.DeleteFile(pathaplikasi & "fotopegawai\" & .Item(0, DataGridView1.CurrentRow.Index).Value.ToString & ".jpg")
            Catch ex As Exception

            End Try

            Call display()
        End With
    End Sub

    Sub clear()
        tbalamat.Text = ""
        tbnama.Text = ""
        tbNoHp.Text = ""
        tbPass.Text = ""
        ComboBox1.SelectedIndex = 0
        tbNip.Text = ""
        PictureBox1.ImageLocation = ""
        tbNip.Enabled = True
        edit = False
        BtTambah.Text = "TAMBAH"
        BtHapus.Enabled = True
        BtClear.Enabled = True
        BtEdit.Text = "EDIT"
        DataGridView1.Enabled = True
    End Sub
    Sub updatetabel()
        Dim a() As String = foto.Split("\")
        If a(a.Length - 2) = "fotopegawai" Then
        Else
            Dim b() As String = a(a.Length - 1).Split(".")
            Try
                My.Computer.FileSystem.CopyFile(foto, pathaplikasi & "fotopegawai\" & a(a.Length - 1))
            Catch ex As Exception
                My.Computer.FileSystem.DeleteFile(pathaplikasi & "fotopegawai\" & a(a.Length - 1))
                My.Computer.FileSystem.CopyFile(foto, pathaplikasi & "fotopegawai\" & a(a.Length - 1))
            End Try
            Try
                My.Computer.FileSystem.RenameFile(pathaplikasi & "fotopegawai\" & a(a.Length - 1), tbNip.Text & "." & b(b.Length - 1))
            Catch ex As Exception
                My.Computer.FileSystem.RenameFile(pathaplikasi & "fotopegawai\" & a(a.Length - 1), tbNip.Text & "asd." & b(b.Length - 1))
                My.Computer.FileSystem.RenameFile(pathaplikasi & "fotopegawai\" & tbNip.Text & "asd." & b(b.Length - 1), tbNip.Text & "." & b(b.Length - 1))
            End Try
        End If
        eksekusinonquery("update pegawai set nama='" & tbnama.Text & "',gender='" & ComboBox1.Text & "',pass='" & tbPass.Text & "',alamat='" & tbalamat.Text & "',no_hp='" & tbNoHp.Text & "' where nip=" & tbNip.Text)
        Call clear()
        Call display()
    End Sub

    Sub display()
        tampil("select * from pegawai", DataGridView1)
    End Sub
    Function validasi() As Boolean
        Dim a As Boolean = True
        If tbalamat.Text = "" Or tbnama.Text = "" Or tbNip.Text = "" Or tbNoHp.Text = "" Or tbPass.Text = "" Or ComboBox1.SelectedIndex = 0 Or PictureBox1.ImageLocation = "" Then
            a = False
        End If
        Return a
    End Function
    Sub tampilkanFoto(ByVal url As String)
        PictureBox1.ImageLocation() = url
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim fd As OpenFileDialog = New OpenFileDialog
        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True
        If fd.ShowDialog() = DialogResult.OK Then
            tampilkanFoto(fd.FileName)
            foto = fd.FileName
        End If
    End Sub

    
    Sub getrecord()
        With DataGridView1
                tbalamat.Text = .Item(4, .CurrentRow.Index).Value.ToString
                tbnama.Text = .Item(1, .CurrentRow.Index).Value.ToString
                tbNoHp.Text = .Item(5, .CurrentRow.Index).Value.ToString
                tbPass.Text = .Item(3, .CurrentRow.Index).Value.ToString
            ComboBox1.SelectedItem = .Item(2, DataGridView1.CurrentRow.Index).Value.ToString
                tbNip.Text = .Item(0, DataGridView1.CurrentRow.Index).Value.ToString
                edit = True
                BtTambah.Text = "SIMPAN"
                BtHapus.Enabled = False
                BtClear.Enabled = False
                BtEdit.Text = "BATAL"
                tampilkanFoto(pathaplikasi & "fotopegawai\" & .Item(0, DataGridView1.CurrentRow.Index).Value.ToString & ".jpg")
                foto = PictureBox1.ImageLocation
            DataGridView1.Enabled = False
            tbNip.Enabled = False
        End With
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtHapus.Click
        Call delete()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtEdit.Click
        If BtEdit.Text = "BATAL" Then
            clear()
        Else
            getrecord()
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtClear.Click
        clear()
    End Sub

    Private Sub BtTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtTambah.Click
        If tbalamat.Text = "" Or tbnama.Text = "" Or tbNoHp.Text = "" Or tbPass.Text = "" Or ComboBox1.SelectedIndex = 0 Or tbNip.Text = "" Or PictureBox1.ImageLocation = "" Then
            MsgBox("data kurang lengkap")
        Else
            If edit = False Then
                Call insert()
            Else
                Call updatetabel()
            End If
        End If
    End Sub

    Private Sub tbNip_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbNip.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
End Class