Public Class kendaraanKeluar

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        caritransaksi("parkir-" & Tbkd.Text)
        Tbkd.Text = ""
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim waktu As String
        If Tbayar.Text <> "" Then
            Dim kembalian As Double
            kembalian = Tbayar.Text - Lbjum.Text
            If kembalian < 0 Then
                MsgBox("uang anda kurang")
            Else

                waktu = LTotWaktu.Text & " " & Lsatjam.Text
                eksekusinonquery("INSERT INTO `parkir_keluar` (`no_parkir_keluar`, `tanggal`, `tarif`, `lama`, `biaya_tambahan`, `total_biaya`,`parkir_no_parkir`, `nip_user`) VALUES ('" & Lbkdtrasak.Text & "', '" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "', '" & LBTARIF.Text & "', '" & waktu & "', '" & LBTAMBAHAN.Text & "', '" & Lbjum.Text & "','" & LBKDP.Text & "', '" & nip & "');")
                MsgBox("kembalian Rp." & Tbayar.Text - Lbjum.Text)
                parameterbayar = Lbkdtrasak.Text
                buktibayar.ShowDialog()
                clear()
                
            End If
        Else
            MsgBox("inputan belum lengkap")

        End If

    End Sub

    Private Sub kendaraanKeluar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Lbkdtrasak.Text = notras()
    End Sub
    Function notras() As String
        Static random As New Random()
        Return "bayar-" & random.Next(0, 9999)
    End Function

    Sub clear()
        LBJK.Text = ""
        Lbjum.Text = ""
        LBKDP.Text = ""
        Lbkdtrasak.Text = ""
        LBMer.Text = ""
        LbNP.Text = ""
        LBTAMBAHAN.Text = ""
        LBTARIF.Text = ""
        Lbtgl.Text = ""
        LBTOTTAMBAHAN.Text = ""
        Tbayar.Text = ""
        Tbket.Text = ""
        Tbkd.Text = ""
        LTotWaktu.Text = ""
        Lsatjam.Text = ""
        LBWK.Text = ""
        Lbkdtrasak.Text = notras()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        clear()
    End Sub

    Private Sub Tbkd_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tbkd.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Tbayar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tbayar.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
End Class