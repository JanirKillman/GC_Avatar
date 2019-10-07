Public Class EVPrint
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
    Friend WithEvents crVieww As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.crVieww = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crVieww
        '
        Me.crVieww.ActiveViewIndex = -1
        Me.crVieww.Location = New System.Drawing.Point(0, 0)
        Me.crVieww.Name = "crVieww"
        Me.crVieww.ReportSource = Nothing
        Me.crVieww.Size = New System.Drawing.Size(728, 392)
        Me.crVieww.TabIndex = 0
        '
        'EVPrint
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(728, 390)
        Me.Controls.Add(Me.crVieww)
        Me.Name = "EVPrint"
        Me.Text = "EVPrint"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub EVPrint_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(FVB)
        Dim oCRT As CRevent = New CRevent
        oCRT.SetDataSource(EVrec)
        crVieww.Visible = True
        crVieww.ReportSource = oCRT
    End Sub
End Class
