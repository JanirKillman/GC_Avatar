<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_VAsez
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_VAsez))
        Me.Lv_VA = New System.Windows.Forms.ListView
        Me.clSKN = New System.Windows.Forms.ColumnHeader
        Me.clSKO = New System.Windows.Forms.ColumnHeader
        Me.clSKA = New System.Windows.Forms.ColumnHeader
        Me.clSKP = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Lv_VA
        '
        Me.Lv_VA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lv_VA.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clSKN, Me.clSKO, Me.clSKA, Me.clSKP})
        Me.Lv_VA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lv_VA.ForeColor = System.Drawing.Color.Black
        Me.Lv_VA.FullRowSelect = True
        Me.Lv_VA.GridLines = True
        Me.Lv_VA.Location = New System.Drawing.Point(-2, -1)
        Me.Lv_VA.Name = "Lv_VA"
        Me.Lv_VA.Size = New System.Drawing.Size(648, 400)
        Me.Lv_VA.TabIndex = 3
        Me.Lv_VA.UseCompatibleStateImageBehavior = False
        Me.Lv_VA.View = System.Windows.Forms.View.Details
        '
        'clSKN
        '
        Me.clSKN.Text = "VANTAGE"
        Me.clSKN.Width = 300
        '
        'clSKO
        '
        Me.clSKO.Text = "TYP"
        Me.clSKO.Width = 40
        '
        'clSKA
        '
        Me.clSKA.Text = "CENA"
        Me.clSKA.Width = 90
        '
        'clSKP
        '
        Me.clSKP.Text = "VLIV"
        Me.clSKP.Width = 212
        '
        'Frm_VAsez
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(646, 400)
        Me.Controls.Add(Me.Lv_VA)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_VAsez"
        Me.Text = "GC AVATAR Odria Vantages seznam"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lv_VA As System.Windows.Forms.ListView
    Friend WithEvents clSKN As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSKO As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSKA As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSKP As System.Windows.Forms.ColumnHeader
End Class
