Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing
Public Class Frm_WOsez
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
    Friend WithEvents clSKN As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSKO As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSKA As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSKP As System.Windows.Forms.ColumnHeader
    Friend WithEvents Lv_WO As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_WOsez))
        Me.Lv_WO = New System.Windows.Forms.ListView
        Me.clSKN = New System.Windows.Forms.ColumnHeader
        Me.clSKO = New System.Windows.Forms.ColumnHeader
        Me.clSKA = New System.Windows.Forms.ColumnHeader
        Me.clSKP = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Lv_WO
        '
        Me.Lv_WO.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(192, Byte))
        Me.Lv_WO.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clSKN, Me.clSKO, Me.clSKA, Me.clSKP})
        Me.Lv_WO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lv_WO.ForeColor = System.Drawing.Color.Black
        Me.Lv_WO.FullRowSelect = True
        Me.Lv_WO.GridLines = True
        Me.Lv_WO.Location = New System.Drawing.Point(0, 0)
        Me.Lv_WO.Name = "Lv_WO"
        Me.Lv_WO.Size = New System.Drawing.Size(648, 400)
        Me.Lv_WO.TabIndex = 3
        Me.Lv_WO.View = System.Windows.Forms.View.Details
        '
        'clSKN
        '
        Me.clSKN.Text = "SLOVO"
        Me.clSKN.Width = 170
        '
        'clSKO
        '
        Me.clSKO.Text = "STARÁ ELFŠTINA"
        Me.clSKO.Width = 150
        '
        'clSKA
        '
        Me.clSKA.Text = "NOVÁ ELFŠTINA"
        Me.clSKA.Width = 150
        '
        'clSKP
        '
        Me.clSKP.Text = "SKřETŠTINA"
        Me.clSKP.Width = 150
        '
        'Frm_WOsez
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(648, 398)
        Me.Controls.Add(Me.Lv_WO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_WOsez"
        Me.Text = "GC AVATAR - Odria Wocabulary seznam"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private lvi As ListViewItem
    Private b As Integer


    Private Sub Frm_WOsez_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        napln_lv()
        Twoc = ""
    End Sub

    Private Sub napln_lv()
        Lv_WO.Items.Clear()
        For b = 0 To WOcount - 1
            lvi = Lv_WO.Items.Add(CType(WOrec.Tables("wo").Rows(b)("Word"), String))
            If IsDBNull(WOrec.Tables("wo").Rows(b)("Old_Elvish")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(WOrec.Tables("wo").Rows(b)("Old_Elvish"), String))
            End If
            If IsDBNull(WOrec.Tables("wo").Rows(b)("New_Elvish")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(WOrec.Tables("wo").Rows(b)("New_Elvish"), String))
            End If
            If IsDBNull(WOrec.Tables("wo").Rows(b)("Goblinish")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(WOrec.Tables("wo").Rows(b)("Goblinish"), String))
            End If
        Next
    End Sub


    Private Sub Lv_WO_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Lv_WO.ColumnClick
        Lv_WO.ListViewItemSorter = New SortRoutines.CompareListViewItems(e.Column, Lv_WO)
    End Sub

    Private Sub Lv_WO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv_WO.SelectedIndexChanged
        Twoc = Lv_WO.SelectedItems(0).Text
        Me.Close()
    End Sub
End Class
