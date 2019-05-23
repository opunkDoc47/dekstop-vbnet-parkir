Public Class kendaraanMasuk
    Dim kendaraan As String
    Private Sub kendaraanMasuk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Function noparkir() As String
        Static random As New Random()
        Return "parkir-" & random.Next(0, 9999)
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim ceked As Boolean
        If RbKenMobil.Checked = False And RbKenMotor.Checked = False Then
            ceked = False
        Else
            ceked = True
        End If
        If ceked = False Or TbKet.Text = "" Or TbMerek.Text = "" Or TbNomorPolisi.Text = "" Then
            MsgBox("data belum lengkap", MsgBoxStyle.Critical, "peringatan")
        Else
            cek(TbNomorPolisi.Text)
            If cekmobil = False Then
                If RbKenMobil.Checked = True Then
                    kendaraan = "mobil"
                ElseIf RbKenMotor.Checked = True Then
                    kendaraan = "motor"
                End If
                eksekusinonquery("insert into kendaraan values ('" & TbNomorPolisi.Text & "','" & kendaraan & "','" & TbMerek.Text & "','" & TbKet.Text & "')")

            End If
            Dim kdp As String = noparkir()
            eksekusinonquery("insert into parkir values('" & kdp & "','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','masuk','" & nip & "','" & TbNomorPolisi.Text & "')")
            parameterparkir = kdp
            MsgBox("data berhasil ditambahkan")
            kartuparkiran.ShowDialog()
            clear()
        End If

    End Sub
    Sub clear()
        RbKenMobil.Checked = False
        RbKenMotor.Checked = False
        TbKet.Clear()
        TbMerek.Clear()
        TbNomorPolisi.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub TbNomorPolisi_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbNomorPolisi.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
End Class