Public Class reportTransaksi
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        laporan1.SetParameterValue("awal", Format(DateTimePicker1.Value, "yyyy-MM-dd"))
        laporan1.SetParameterValue("akhir", Format(DateTimePicker2.Value, "yyyy-MM-dd"))
        CrystalReportViewer1.ReportSource = laporan1
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub reportTransaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        laporan1.SetParameterValue("awal", Format(DateTimePicker1.Value, "yyyy-MM-dd"))
        laporan1.SetParameterValue("akhir", Format(DateTimePicker2.Value, "yyyy-MM-dd"))
        CrystalReportViewer1.ReportSource = laporan1
        CrystalReportViewer1.Refresh()
    End Sub
End Class