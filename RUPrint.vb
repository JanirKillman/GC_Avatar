Public Class RUPrint
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents crView As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.crView = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crView
        '
        Me.crView.ActiveViewIndex = -1
        Me.crView.Location = New System.Drawing.Point(0, 0)
        Me.crView.Name = "crView"
        Me.crView.ReportSource = Nothing
        Me.crView.Size = New System.Drawing.Size(648, 448)
        Me.crView.TabIndex = 2
        '
        'RUPrint
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(648, 446)
        Me.Controls.Add(Me.crView)
        Me.Name = "RUPrint"
        Me.Text = "RUPrint"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub RUPrint_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(FRUB)
        Dim oCRT As CRrule = New CRrule
        oCRT.SetDataSource(RUrec)
        crView.Visible = True
        crView.ReportSource = oCRT
    End Sub
End Class
