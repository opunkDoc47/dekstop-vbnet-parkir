Public Class settingaplikasi

    Private Sub settingaplikasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBoxTm.Text = tarifMobil
        TextBoxTMR.Text = tarifMotor
        TextBoxBM.Text = tariftambahanMobil
        TextBoxBMR.Text = tariftambahanMotor
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBoxTMR.Text = "" Or TextBoxBMR.Text = "" Or TextBoxTm.Text = "" Or TextBoxBM.Text = "" Then
            MsgBox("data belum lengkap")
        Else
            settingtarif(TextBoxTMR.Text & ";" & TextBoxBMR.Text & ";" & TextBoxTm.Text & ";" & TextBoxBM.Text)
            Me.Close()
        End If

    End Sub

    Private Sub TextBoxTm_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxTm.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxTMR_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxTMR.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxBM_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxBM.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxBMR_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxBMR.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
End Class