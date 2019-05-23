Public Class parkiranaktiv

    Private Sub parkiranaktiv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil("select * from parkiran where parkiran.status='masuk'", DataGridView1)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btcari.Click
        If cariparkiran(TextBox1.Text) = True Then
            tampil("select * from parkiran WHERE parkiran.nomorpolisi='" & TextBox1.Text & "' and parkiran.status='masuk'", DataGridView1)

        Else
            MsgBox("data tidak ada")
        End If
        TextBox1.Clear()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        tampil("select * from parkiran WHERE parkiran.status='masuk'", DataGridView1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If DataGridView1.RowCount >= 1 Then

            caritransaksi(DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value)
            kendaraanKeluar.ShowDialog()
        End If

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
End Class