Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing
Public Class Frm_NAsez
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
    Friend WithEvents Lv_NA As System.Windows.Forms.ListView
    Friend WithEvents clSPN As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSPM As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSPZ As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSPS As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSPD As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSPNa As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSPT As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSPF As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSI As System.Windows.Forms.ColumnHeader
    Friend WithEvents clID As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_NAsez))
        Me.Lv_NA = New System.Windows.Forms.ListView
        Me.clSPN = New System.Windows.Forms.ColumnHeader
        Me.clSPM = New System.Windows.Forms.ColumnHeader
        Me.clSPZ = New System.Windows.Forms.ColumnHeader
        Me.clSPS = New System.Windows.Forms.ColumnHeader
        Me.clSPD = New System.Windows.Forms.ColumnHeader
        Me.clSPNa = New System.Windows.Forms.ColumnHeader
        Me.clSPT = New System.Windows.Forms.ColumnHeader
        Me.clSPF = New System.Windows.Forms.ColumnHeader
        Me.clSI = New System.Windows.Forms.ColumnHeader
        Me.clID = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Lv_NA
        '
        Me.Lv_NA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lv_NA.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clSPN, Me.clSPM, Me.clSPZ, Me.clSPS, Me.clSPD, Me.clSPNa, Me.clSPT, Me.clSPF, Me.clSI, Me.clID})
        Me.Lv_NA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lv_NA.ForeColor = System.Drawing.Color.Black
        Me.Lv_NA.FullRowSelect = True
        Me.Lv_NA.GridLines = True
        Me.Lv_NA.Location = New System.Drawing.Point(0, 0)
        Me.Lv_NA.Name = "Lv_NA"
        Me.Lv_NA.Size = New System.Drawing.Size(880, 368)
        Me.Lv_NA.TabIndex = 2
        Me.Lv_NA.UseCompatibleStateImageBehavior = False
        Me.Lv_NA.View = System.Windows.Forms.View.Details
        '
        'clSPN
        '
        Me.clSPN.Text = "ČÍSLO"
        Me.clSPN.Width = 50
        '
        'clSPM
        '
        Me.clSPM.Text = "JMÉNO"
        Me.clSPM.Width = 160
        '
        'clSPZ
        '
        Me.clSPZ.Text = "KONTINENT"
        Me.clSPZ.Width = 120
        '
        'clSPS
        '
        Me.clSPS.Text = "ZŘÍZENÍ"
        Me.clSPS.Width = 110
        '
        'clSPD
        '
        Me.clSPD.Text = "OBYVATEL"
        Me.clSPD.Width = 110
        '
        'clSPNa
        '
        Me.clSPNa.Text = "LORDŮ"
        Me.clSPNa.Width = 70
        '
        'clSPT
        '
        Me.clSPT.Text = "MAGLEVEL"
        Me.clSPT.Width = 90
        '
        'clSPF
        '
        Me.clSPF.Text = "VÝZNAM"
        Me.clSPF.Width = 70
        '
        'clSI
        '
        Me.clSI.Text = "STRANA"
        Me.clSI.Width = 80
        '
        'clID
        '
        Me.clID.Width = 0
        '
        'Frm_NAsez
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(880, 366)
        Me.Controls.Add(Me.Lv_NA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_NAsez"
        Me.Text = "GC AVATAR - Odria Nations seznam"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private lvi As ListViewItem
    Private b As Integer


    Private Sub Frm_NAsez_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        napln_lv()
        Tnar = ""
    End Sub

    Private Sub napln_lv()
        Lv_NA.Items.Clear()
        For b = 0 To NAcount - 1
            lvi = Lv_NA.Items.Add(CType(NArec.Tables("na").Rows(b)("Číslo"), String))
            lvi.SubItems.Add(CType(NArec.Tables("na").Rows(b)("Jméno"), String))
            lvi.SubItems.Add(CType(NArec.Tables("na").Rows(b)("Kontinent"), String))
            If IsDBNull(NArec.Tables("na").Rows(b)("Vláda")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(NArec.Tables("na").Rows(b)("Vláda"), String))
            End If
            If IsDBNull(NArec.Tables("na").Rows(b)("Pocobyvatel")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CStr(CDec(NArec.Tables("na").Rows(b)("Pocobyvatel"))))
            End If
            If IsDBNull(NArec.Tables("na").Rows(b)("Lords")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(NArec.Tables("na").Rows(b)("Lords"), String))
            End If
            If IsDBNull(NArec.Tables("na").Rows(b)("Maglevel")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(NArec.Tables("na").Rows(b)("Maglevel"), String))
            End If
            If IsDBNull(NArec.Tables("na").Rows(b)("Importance")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(NArec.Tables("na").Rows(b)("Importance"), String))
            End If
            If IsDBNull(NArec.Tables("na").Rows(b)("Side")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(NArec.Tables("na").Rows(b)("Side"), String))
            End If
            lvi.SubItems.Add(CType(NArec.Tables("na").Rows(b)("ID"), String))
        Next
    End Sub


    Private Sub Lv_NA_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Lv_NA.ColumnClick
        Lv_NA.ListViewItemSorter = New SortRoutines.CompareListViewItems(e.Column, Lv_NA)
    End Sub

    Private Sub Lv_NA_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lv_NA.SelectedIndexChanged
        Tnar = Lv_NA.SelectedItems(0).SubItems(9).Text
        Me.Close()
    End Sub
End Class
