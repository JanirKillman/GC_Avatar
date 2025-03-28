Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing

Public Class Frm_PSsez
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
    Friend WithEvents Lv_PS As System.Windows.Forms.ListView
    Friend WithEvents clSK As System.Windows.Forms.ColumnHeader
    Friend WithEvents clOB As System.Windows.Forms.ColumnHeader
    Friend WithEvents clZA As System.Windows.Forms.ColumnHeader
    Friend WithEvents clPR As System.Windows.Forms.ColumnHeader
    Friend WithEvents clDC As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_PSsez))
        Me.Lv_PS = New System.Windows.Forms.ListView
        Me.clSK = New System.Windows.Forms.ColumnHeader
        Me.clOB = New System.Windows.Forms.ColumnHeader
        Me.clZA = New System.Windows.Forms.ColumnHeader
        Me.clPR = New System.Windows.Forms.ColumnHeader
        Me.clDC = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Lv_PS
        '
        Me.Lv_PS.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.Lv_PS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clSK, Me.clOB, Me.clZA, Me.clPR, Me.clDC})
        Me.Lv_PS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lv_PS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Lv_PS.FullRowSelect = True
        Me.Lv_PS.GridLines = True
        Me.Lv_PS.Location = New System.Drawing.Point(0, 0)
        Me.Lv_PS.Name = "Lv_PS"
        Me.Lv_PS.Size = New System.Drawing.Size(752, 272)
        Me.Lv_PS.TabIndex = 1
        Me.Lv_PS.View = System.Windows.Forms.View.Details
        '
        'clSK
        '
        Me.clSK.Text = "SKILL"
        Me.clSK.Width = 240
        '
        'clOB
        '
        Me.clOB.Text = "OBOR"
        Me.clOB.Width = 120
        '
        'clZA
        '
        Me.clZA.Text = "ZAř."
        Me.clZA.Width = 44
        '
        'clPR
        '
        Me.clPR.Text = "PREREKVISITY"
        Me.clPR.Width = 250
        '
        'clDC
        '
        Me.clDC.Text = "DATUM"
        Me.clDC.Width = 75
        '
        'Frm_PSsez
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.ClientSize = New System.Drawing.Size(752, 270)
        Me.Controls.Add(Me.Lv_PS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_PSsez"
        Me.Text = "GC AVATAR - Odria Psionics seznam"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private lvi As ListViewItem
    Private b As Integer


    Private Sub Frm_PSsez_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        napln_lv()
        Tskill = ""
    End Sub

    Private Sub napln_lv()
        Lv_PS.Items.Clear()
        For b = 0 To PScount - 1
            lvi = Lv_PS.Items.Add(CType(PSrec.Tables("P").Rows(b)("PSI_skill"), String))
            lvi.SubItems.Add(CType(PSrec.Tables("P").Rows(b)("PSI_branch"), String))
            If IsDBNull(PSrec.Tables("P").Rows(b)("PSI_level")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(PSrec.Tables("P").Rows(b)("PSI_level"), String))
            End If
            If IsDBNull(PSrec.Tables("P").Rows(b)("PSI_prereq")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(PSrec.Tables("P").Rows(b)("PSI_prereq"), String))
            End If
            lvi.SubItems.Add(CType(PSrec.Tables("P").Rows(b)("PSI_datecre"), String))
        Next
    End Sub


    Private Sub Lv_PS_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Lv_PS.ColumnClick
        Lv_PS.ListViewItemSorter = New SortRoutines.CompareListViewItems(e.Column, Lv_PS)
    End Sub

    Private Sub Lv_PS_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lv_PS.SelectedIndexChanged
        Tskill = Lv_PS.SelectedItems(0).Text
        Me.Close()
    End Sub
End Class
