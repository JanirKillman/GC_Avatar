Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing
Public Class Frm_OGsez
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
    Friend WithEvents clSK As System.Windows.Forms.ColumnHeader
    Friend WithEvents clOB As System.Windows.Forms.ColumnHeader
    Friend WithEvents clZA As System.Windows.Forms.ColumnHeader
    Friend WithEvents clPR As System.Windows.Forms.ColumnHeader
    Friend WithEvents clDC As System.Windows.Forms.ColumnHeader
    Friend WithEvents Lv_OG As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_OGsez))
        Me.Lv_OG = New System.Windows.Forms.ListView
        Me.clSK = New System.Windows.Forms.ColumnHeader
        Me.clOB = New System.Windows.Forms.ColumnHeader
        Me.clZA = New System.Windows.Forms.ColumnHeader
        Me.clPR = New System.Windows.Forms.ColumnHeader
        Me.clDC = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Lv_OG
        '
        Me.Lv_OG.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Me.Lv_OG.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clSK, Me.clOB, Me.clZA, Me.clPR, Me.clDC})
        Me.Lv_OG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lv_OG.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Lv_OG.FullRowSelect = True
        Me.Lv_OG.GridLines = True
        Me.Lv_OG.Location = New System.Drawing.Point(0, 0)
        Me.Lv_OG.Name = "Lv_OG"
        Me.Lv_OG.Size = New System.Drawing.Size(752, 272)
        Me.Lv_OG.TabIndex = 2
        Me.Lv_OG.View = System.Windows.Forms.View.Details
        '
        'clSK
        '
        Me.clSK.Text = "ORGANIZACE"
        Me.clSK.Width = 260
        '
        'clOB
        '
        Me.clOB.Text = "SÍDLO"
        Me.clOB.Width = 140
        '
        'clZA
        '
        Me.clZA.Text = "VŮDCE"
        Me.clZA.Width = 140
        '
        'clPR
        '
        Me.clPR.Text = "DŮLEŽITOST"
        Me.clPR.Width = 100
        '
        'clDC
        '
        Me.clDC.Text = "STRANA"
        Me.clDC.Width = 90
        '
        'Frm_OGsez
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(752, 270)
        Me.Controls.Add(Me.Lv_OG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "Frm_OGsez"
        Me.Text = "GC AVATAR - Odria Organizations seznam"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private lvi As ListViewItem
    Private b As Integer


    Private Sub Frm_OGsez_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        napln_lv()
        Torg = ""
    End Sub

    Private Sub napln_lv()
        Lv_OG.Items.Clear()
        For b = 0 To OGcount - 1
            lvi = Lv_OG.Items.Add(CType(OGrec.Tables("og").Rows(b)("Organization"), String))
            If IsDBNull(OGrec.Tables("og").Rows(b)("Home")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(OGrec.Tables("og").Rows(b)("Home"), String))
            End If
            If IsDBNull(OGrec.Tables("og").Rows(b)("Head")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(OGrec.Tables("og").Rows(b)("Head"), String))
            End If
            If IsDBNull(OGrec.Tables("og").Rows(b)("Importance")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(OGrec.Tables("og").Rows(b)("Importance"), String))
            End If
            If IsDBNull(OGrec.Tables("og").Rows(b)("Side")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(OGrec.Tables("og").Rows(b)("Side"), String))
            End If
        Next
    End Sub


    Private Sub Lv_OG_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Lv_OG.ColumnClick
        Lv_OG.ListViewItemSorter = New SortRoutines.CompareListViewItems(e.Column, Lv_OG)
    End Sub

    Private Sub Lv_OG_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv_OG.SelectedIndexChanged
        Torg = Lv_OG.SelectedItems(0).Text
        Me.Close()
    End Sub
End Class
