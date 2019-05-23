Public Class buktibayar

    Private Sub buktibayar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pembayaran1.SetParameterValue("kodebayar", parameterbayar)
        CrystalReportViewer1.ReportSource = pembayaran1
        CrystalReportViewer1.Refresh()
    End Sub
End Class