Public Class kartuparkiran

    Private Sub kartuparkiran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kartuparkir1.SetParameterValue("kodeparkir", parameterparkir)
        CrystalReportViewer1.ReportSource = kartuparkir1
        CrystalReportViewer1.Refresh()
    End Sub
End Class