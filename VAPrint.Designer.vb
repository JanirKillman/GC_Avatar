<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VAPrint
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.crView = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crView
        '
        Me.crView.ActiveViewIndex = -1
        Me.crView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crView.Location = New System.Drawing.Point(0, -1)
        Me.crView.Name = "crView"
        Me.crView.SelectionFormula = ""
        Me.crView.Size = New System.Drawing.Size(648, 448)
        Me.crView.TabIndex = 2
        Me.crView.ViewTimeSelectionFormula = ""
        '
        'VAPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 446)
        Me.Controls.Add(Me.crView)
        Me.Name = "VAPrint"
        Me.Text = "VAPrint"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crView As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
