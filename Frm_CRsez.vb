Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing
Public Class Frm_CRsez
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
    Friend WithEvents clSPN As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSPM As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSPZ As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSPS As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSPD As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSPNa As System.Windows.Forms.ColumnHeader
    Friend WithEvents Lv_CR As System.Windows.Forms.ListView
    Friend WithEvents clID As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_CRsez))
        Me.Lv_CR = New System.Windows.Forms.ListView
        Me.clSPN = New System.Windows.Forms.ColumnHeader
        Me.clSPM = New System.Windows.Forms.ColumnHeader
        Me.clSPZ = New System.Windows.Forms.ColumnHeader
        Me.clSPS = New System.Windows.Forms.ColumnHeader
        Me.clSPD = New System.Windows.Forms.ColumnHeader
        Me.clSPNa = New System.Windows.Forms.ColumnHeader
        Me.clID = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Lv_CR
        '
        Me.Lv_CR.BackColor = System.Drawing.Color.Green
        Me.Lv_CR.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clSPN, Me.clSPM, Me.clSPZ, Me.clSPS, Me.clSPD, Me.clSPNa, Me.clID})
        Me.Lv_CR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lv_CR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Lv_CR.FullRowSelect = True
        Me.Lv_CR.GridLines = True
        Me.Lv_CR.Location = New System.Drawing.Point(0, 0)
        Me.Lv_CR.Name = "Lv_CR"
        Me.Lv_CR.Size = New System.Drawing.Size(888, 368)
        Me.Lv_CR.TabIndex = 1
        Me.Lv_CR.View = System.Windows.Forms.View.Details
        '
        'clSPN
        '
        Me.clSPN.Text = "POVOLÁNÍ"
        Me.clSPN.Width = 100
        '
        'clSPM
        '
        Me.clSPM.Text = "SKILL"
        Me.clSPM.Width = 300
        '
        'clSPZ
        '
        Me.clSPZ.Text = "OZN."
        Me.clSPZ.Width = 50
        '
        'clSPS
        '
        Me.clSPS.Text = "CENA"
        Me.clSPS.Width = 170
        '
        'clSPD
        '
        Me.clSPD.Text = "MAXIMUM"
        Me.clSPD.Width = 170
        '
        'clSPNa
        '
        Me.clSPNa.Text = "DATUM"
        Me.clSPNa.Width = 80
        '
        'clID
        '
        Me.clID.Text = ""
        Me.clID.Width = 0
        '
        'Frm_CRsez
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(888, 366)
        Me.Controls.Add(Me.Lv_CR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_CRsez"
        Me.Text = "GC AVATAR - Odria Class Rules seznam"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private lvi As ListViewItem
    Private b As Integer


    Private Sub Frm_CRsez_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        napln_lv()
        Tcr = ""
    End Sub

    Private Sub napln_lv()
        Lv_CR.Items.Clear()
        For b = 0 To CRcount - 1
            lvi = Lv_CR.Items.Add(CType(CRrec.Tables("cr").Rows(b)("Classx"), String))
            If IsDBNull(CRrec.Tables("cr").Rows(b)("Namex")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(CRrec.Tables("cr").Rows(b)("Namex"), String))
            End If
            If IsDBNull(CRrec.Tables("cr").Rows(b)("Signx")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(CRrec.Tables("cr").Rows(b)("Signx"), String))
            End If
            If IsDBNull(CRrec.Tables("cr").Rows(b)("Cost")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(CRrec.Tables("cr").Rows(b)("Cost"), String))
            End If
            If IsDBNull(CRrec.Tables("cr").Rows(b)("Maxx")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(CRrec.Tables("cr").Rows(b)("Maxx"), String))
            End If
            If IsDBNull(CRrec.Tables("cr").Rows(b)("Date_cre")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(CRrec.Tables("cr").Rows(b)("Date_cre"), Date))
            End If
            lvi.SubItems.Add(CType(CRrec.Tables("cr").Rows(b)("ID"), String))
        Next
    End Sub


    Private Sub Lv_CR_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Lv_CR.ColumnClick
        Lv_CR.ListViewItemSorter = New SortRoutines.CompareListViewItems(e.Column, Lv_CR)
    End Sub

    Private Sub Lv_AT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv_CR.SelectedIndexChanged
        Tcr = Lv_CR.SelectedItems(0).SubItems(6).Text
        Me.Close()
    End Sub
End Class
