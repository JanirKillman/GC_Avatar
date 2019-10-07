Public Class VAPrint
    Private Sub VAPrint_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(FVV)
        Dim oCRT As CRvantage = New CRvantage
        oCRT.SetDataSource(VArec)
        crView.Visible = True
        crView.ReportSource = oCRT
    End Sub
End Class