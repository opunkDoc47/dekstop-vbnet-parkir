Public Class menuUtama

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        konek()
        loadconfig()

    End Sub
    Private Sub ParkiranToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParkiranToolStripMenuItem.Click
        parkiranaktiv.Show()
    End Sub

    Private Sub DataParkiranToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataParkiranToolStripMenuItem.Click
        trasaksi.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btin.Click
        kendaraanMasuk.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btout.Click
        kendaraanKeluar.ShowDialog()
    End Sub

    Private Sub TARIFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemTarif.Click
        settingaplikasi.Show()
    End Sub

    Private Sub PEGAWAIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PEGAWAIToolStripMenuItem.Click
        settinguser.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btlogin.Click
        If logiState = False Then
            login.Show()
            Me.Dispose()
        Else
            Btin.Visible = False
            Btout.Visible = False
            MenuItemTarif.Visible = False
            itemMenuData.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            nama = ""
            Lbuser.Text = ""
            Btlogin.Text = "LOG IN"
            logiState = False
        End If

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class
