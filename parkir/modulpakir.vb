Imports MySql.Data.MySqlClient
Imports System.IO
Module modulpakir
    Public command As MySqlCommand
    Public reader As MySqlDataReader
    Public adapter As MySqlDataAdapter
    Public koneksi As MySqlConnection
    Public dts As DataSet
    Public nama As String = ""
    Public nip As Integer = 0
    Public cekmobil As Boolean = False
    Public pathaplikasi As String = My.Application.Info.DirectoryPath & "\"
    Dim c As DateTime
    Dim d As DateTime
    Dim e As TimeSpan
    Public tarifMotor As Double = 0
    Public tariftambahanMotor As Double = 0
    Public tarifMobil As Double = 0
    Public tariftambahanMobil As Double = 0
    Public logiState As Boolean = False
    Public eror As Boolean = False
    Public parameterbayar As String = ""
    Public parameterparkir As String = ""
    Sub konek()
        Try
            Dim query As String = "server=127.0.0.1;Uid=root;Pwd=;Database=parkir;Port=3306"
            koneksi = New MySqlConnection(query)
            If koneksi.State = ConnectionState.Closed Then
                koneksi.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub tampil(ByVal query As String, ByVal dgv As DataGridView)
        Try
            adapter = New MySqlDataAdapter(query, koneksi)
            dts = New DataSet
            dts.Clear()
            adapter.Fill(dts, query)
            dgv.DataSource = (dts.Tables(query))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Sub eksekusinonquery(ByVal query As String)
        Try
            command = New MySqlCommand(query, koneksi)
            command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
            eror = True
        End Try
        command.Dispose()
    End Sub
    Sub loginuser(ByVal p As String, ByVal pass As String)
        Try
            command = New MySqlCommand("select * from pegawai where nip='" & p & "' and pass='" & pass & "'", koneksi)
            reader = command.ExecuteReader

            If reader.HasRows Then
                While reader.Read()
                    nama = reader("nama")
                    nip = reader("nip")
                End While
                logiState = True
                menuUtama.Show()
                menuUtama.Lbuser.Text = nama
                menuUtama.Btlogin.Text = "LOG OUT"
                menuUtama.Btin.Visible = True
                menuUtama.Btout.Visible = True
                menuUtama.MenuItemTarif.Visible = True
                menuUtama.itemMenuData.Visible = True
                menuUtama.Label1.Visible = True
                menuUtama.Label2.Visible = True
                login.Dispose()
            Else
                MsgBox("username dan password salah", MsgBoxStyle.Critical, "Error")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        reader.Close()
        command.Dispose()
    End Sub

    Sub cek(ByVal a As Integer)
        Try
            command = New MySqlCommand("select * from kendaraan where nomor_polisi ='" & a & "'", koneksi)
            reader = command.ExecuteReader
            reader.Read()
            If reader.HasRows = True Then
                cekmobil = True
            Else
                cekmobil = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        reader.Close()
        command.Dispose()
    End Sub
    Sub caritransaksi(ByVal a As String)
        Dim tarif As Double
        Dim tariftambahan As Double
        Try
            command = New MySqlCommand("select * from transaksi_masuk WHERE transaksi_masuk.kodeparkir='" & a & "' and transaksi_masuk.status='masuk'", koneksi)
            reader = command.ExecuteReader
            If reader.HasRows = True Then
                reader.Read()
                kendaraanKeluar.LBKDP.Text = reader("kodeparkir")
                kendaraanKeluar.LbNP.Text = reader("nomor polisi")
                kendaraanKeluar.Lbtgl.Text = reader("taggal masuk")
                d = reader("taggal masuk")
                kendaraanKeluar.LBJK.Text = reader("jenis kedaraan")
                kendaraanKeluar.LBMer.Text = reader("merek")
                kendaraanKeluar.Tbket.Text = reader("keterangan")
                c = New DateTime(Now.Ticks)
                kendaraanKeluar.LBWK.Text = c
                If kendaraanKeluar.LBJK.Text = "mobil" Then
                    tarif = tarifMobil
                    tariftambahan = tariftambahanMobil
                ElseIf kendaraanKeluar.LBJK.Text = "motor" Then
                    tarif = tarifMotor
                    tariftambahan = tariftambahanMotor
                End If
                kendaraanKeluar.LBTARIF.Text = tarif
                kendaraanKeluar.LBTAMBAHAN.Text = tariftambahan
                e = c - d

                Dim totaltambahan As Double = 0
                Dim totalwaktu As Double = 0
                totalwaktu = (e.Days * 24) + e.Hours
                If totalwaktu > 2 Then
                    totaltambahan = tariftambahan * (totalwaktu - 2)
                End If
                kendaraanKeluar.LBTOTTAMBAHAN.Text = totaltambahan
                kendaraanKeluar.Lbjum.Text = (totaltambahan + tarif)
                If totalwaktu < 1 Then
                    kendaraanKeluar.LTotWaktu.Text = e.Minutes
                    kendaraanKeluar.Lsatjam.Text = "menit"
                Else
                    kendaraanKeluar.LTotWaktu.Text = totalwaktu
                    kendaraanKeluar.Lsatjam.Text = "jam"
                End If

            Else
                MsgBox("data tidak ditemukan")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        reader.Close()
        command.Dispose()
    End Sub
    Function cariparkiran(ByVal kode As String) As Boolean
        Dim a As Boolean = False
        Try
            command = New MySqlCommand("select * from parkiran WHERE parkiran.nomorpolisi='" & kode & "' and parkiran.status='masuk'", koneksi)
            reader = command.ExecuteReader
            If reader.HasRows = True Then
                a = True
            Else
                a = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        reader.Close()
        command.Dispose()
        Return a
    End Function

    Function cariparkirtrasaksi(ByVal kode As String) As Boolean
        Dim a As Boolean = False
        Try
            command = New MySqlCommand("select * from transaksi_keluar WHERE transaksi_keluar.kodebayar='" & kode & "'", koneksi)
            reader = command.ExecuteReader
            If reader.HasRows = True Then
                a = True
            Else
                a = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        reader.Close()
        command.Dispose()
        Return a
    End Function
    Sub writeconfig()



    End Sub

    Sub loadconfig()
        Dim isi() As String = System.IO.File.ReadAllText(pathaplikasi & "config.opk").Split(";")
        tarifMotor = isi(0)
        tariftambahanMotor = isi(1)
        tarifMobil = isi(2)
        tariftambahanMobil = isi(3)
    End Sub

    Sub settingtarif(ByVal isi As String)

        Try
            System.IO.File.Delete(pathaplikasi & "config.opk")
            System.IO.File.WriteAllText(pathaplikasi + "config.opk", isi)
            loadconfig()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
