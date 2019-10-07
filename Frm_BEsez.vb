Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing
Public Class Frm_BEsez
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
    Friend WithEvents clSPT As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSPF As System.Windows.Forms.ColumnHeader
    Friend WithEvents Lv_BE As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_BEsez))
        Me.Lv_BE = New System.Windows.Forms.ListView
        Me.clSPN = New System.Windows.Forms.ColumnHeader
        Me.clSPM = New System.Windows.Forms.ColumnHeader
        Me.clSPZ = New System.Windows.Forms.ColumnHeader
        Me.clSPS = New System.Windows.Forms.ColumnHeader
        Me.clSPD = New System.Windows.Forms.ColumnHeader
        Me.clSPNa = New System.Windows.Forms.ColumnHeader
        Me.clSPT = New System.Windows.Forms.ColumnHeader
        Me.clSPF = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Lv_BE
        '
        Me.Lv_BE.BackColor = System.Drawing.Color.Green
        Me.Lv_BE.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clSPN, Me.clSPM, Me.clSPZ, Me.clSPS, Me.clSPD, Me.clSPNa, Me.clSPT, Me.clSPF})
        Me.Lv_BE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lv_BE.ForeColor = System.Drawing.Color.Yellow
        Me.Lv_BE.FullRowSelect = True
        Me.Lv_BE.GridLines = True
        Me.Lv_BE.Location = New System.Drawing.Point(0, 0)
        Me.Lv_BE.Name = "Lv_BE"
        Me.Lv_BE.Size = New System.Drawing.Size(888, 400)
        Me.Lv_BE.TabIndex = 2
        Me.Lv_BE.UseCompatibleStateImageBehavior = False
        Me.Lv_BE.View = System.Windows.Forms.View.Details
        '
        'clSPN
        '
        Me.clSPN.Text = "BESTIE"
        Me.clSPN.Width = 270
        '
        'clSPM
        '
        Me.clSPM.Text = "TYP"
        Me.clSPM.Width = 150
        '
        'clSPZ
        '
        Me.clSPZ.Text = "LEVEL"
        Me.clSPZ.Width = 100
        '
        'clSPS
        '
        Me.clSPS.Text = "SÍLA"
        Me.clSPS.Width = 50
        '
        'clSPD
        '
        Me.clSPD.Text = "HBI"
        Me.clSPD.Width = 50
        '
        'clSPNa
        '
        Me.clSPNa.Text = "IQ"
        Me.clSPNa.Width = 50
        '
        'clSPT
        '
        Me.clSPT.Text = "VELIKOST"
        Me.clSPT.Width = 80
        '
        'clSPF
        '
        Me.clSPF.Text = "MAGIE"
        Me.clSPF.Width = 120
        '
        'Frm_BEsez
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(888, 398)
        Me.Controls.Add(Me.Lv_BE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_BEsez"
        Me.Text = "GC AVATAR - Odria Beasts seznam"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private lvi As ListViewItem
    Private b As Integer


    Private Sub Frm_BEsez_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        napln_lv()
        Tbe = ""
    End Sub

    Private Sub napln_lv()
        Lv_BE.Items.Clear()
        For b = 0 To BEcount - 1
            lvi = Lv_BE.Items.Add(CType(BErec.Tables("be").Rows(b)("B_name"), String))
            If IsDBNull(BErec.Tables("be").Rows(b)("B_type")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(BErec.Tables("be").Rows(b)("B_type"), String))
            End If
            If IsDBNull(BErec.Tables("be").Rows(b)("B_level")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(BErec.Tables("be").Rows(b)("B_level"), String))
            End If
            If IsDBNull(BErec.Tables("be").Rows(b)("B_strength")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(BErec.Tables("be").Rows(b)("B_strength"), String))
            End If

            If IsDBNull(BErec.Tables("be").Rows(b)("B_dexterity")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(BErec.Tables("be").Rows(b)("B_dexterity"), String))
            End If
            If IsDBNull(BErec.Tables("be").Rows(b)("B_IQ")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(BErec.Tables("be").Rows(b)("B_IQ"), String))
            End If
            If IsDBNull(BErec.Tables("be").Rows(b)("B_size")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(BErec.Tables("be").Rows(b)("B_size"), String))
            End If
            If IsDBNull(BErec.Tables("be").Rows(b)("B_maxspelltype")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(BErec.Tables("be").Rows(b)("B_maxspelltype"), String))
            End If
        Next
    End Sub


    Private Sub Lv_BE_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Lv_BE.ColumnClick
        Lv_BE.ListViewItemSorter = New SortRoutines.CompareListViewItems(e.Column, Lv_BE)
    End Sub

    Private Sub Lv_BE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv_BE.SelectedIndexChanged
        Tbe = Lv_BE.SelectedItems(0).Text
        Me.Close()
    End Sub
End Class
