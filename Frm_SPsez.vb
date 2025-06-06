Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing

Public Class Frm_SPsez
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
    Friend WithEvents Lv_SP As System.Windows.Forms.ListView
    Friend WithEvents clSPN As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSPZ As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSPS As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSPD As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSPM As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSPNa As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSPT As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSPF As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_SPsez))
        Me.Lv_SP = New System.Windows.Forms.ListView
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
        'Lv_SP
        '
        Me.Lv_SP.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Lv_SP.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clSPN, Me.clSPM, Me.clSPZ, Me.clSPS, Me.clSPD, Me.clSPNa, Me.clSPT, Me.clSPF})
        Me.Lv_SP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lv_SP.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(0, Byte))
        Me.Lv_SP.FullRowSelect = True
        Me.Lv_SP.GridLines = True
        Me.Lv_SP.Location = New System.Drawing.Point(0, 0)
        Me.Lv_SP.Name = "Lv_SP"
        Me.Lv_SP.Size = New System.Drawing.Size(880, 368)
        Me.Lv_SP.TabIndex = 0
        Me.Lv_SP.View = System.Windows.Forms.View.Details
        '
        'clSPN
        '
        Me.clSPN.Text = "KOUZLO"
        Me.clSPN.Width = 275
        '
        'clSPM
        '
        Me.clSPM.Text = "MAGENERGIE"
        Me.clSPM.Width = 102
        '
        'clSPZ
        '
        Me.clSPZ.Text = "ZAŘAZENÍ"
        Me.clSPZ.Width = 147
        '
        'clSPS
        '
        Me.clSPS.Text = "ÚROVEÒ"
        Me.clSPS.Width = 70
        '
        'clSPD
        '
        Me.clSPD.Text = "DATUM"
        Me.clSPD.Width = 62
        '
        'clSPNa
        '
        Me.clSPNa.Text = "NÁROČNOST"
        Me.clSPNa.Width = 98
        '
        'clSPT
        '
        Me.clSPT.Text = "ČAS"
        Me.clSPT.Width = 39
        '
        'clSPF
        '
        Me.clSPF.Text = "ÚNAVA"
        Me.clSPF.Width = 59
        '
        'Frm_SPsez
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.ClientSize = New System.Drawing.Size(880, 366)
        Me.Controls.Add(Me.Lv_SP)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_SPsez"
        Me.Text = "GC AVATAR - Odria Spells seznam"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private lvi As ListViewItem
    Private b As Integer


    Private Sub Frm_SPsez_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        napln_lv()
        Tspell = ""
    End Sub

    Private Sub napln_lv()
        Lv_SP.Items.Clear()
        For b = 0 To SPcount - 1
            lvi = Lv_SP.Items.Add(CType(SPrec.Tables("Sp").Rows(b)("Orig_name"), String))
            If IsDBNull(SPrec.Tables("Sp").Rows(b)("Magenergy")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(Mid(SPrec.Tables("Sp").Rows(b)("Magenergy"), 1, 13), String))
            End If
            If IsDBNull(SPrec.Tables("Sp").Rows(b)("Spell_type")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(SPrec.Tables("Sp").Rows(b)("Spell_type"), String))
            End If
            If IsDBNull(SPrec.Tables("Sp").Rows(b)("Spelling_cast")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(SPrec.Tables("Sp").Rows(b)("Spelling_cast"), String))
            End If
            lvi.SubItems.Add(CType(SPrec.Tables("Sp").Rows(b)("DateCre"), Date))
            If IsDBNull(SPrec.Tables("Sp").Rows(b)("Difficulty")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(SPrec.Tables("Sp").Rows(b)("Difficulty"), String))
            End If
            If IsDBNull(SPrec.Tables("Sp").Rows(b)("Cast_time")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(SPrec.Tables("Sp").Rows(b)("Cast_time"), String))
            End If
            If IsDBNull(SPrec.Tables("Sp").Rows(b)("Fatigue")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(SPrec.Tables("Sp").Rows(b)("Fatigue"), String))
            End If

        Next
    End Sub


    Private Sub Lv_SP_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Lv_SP.ColumnClick
        Lv_SP.ListViewItemSorter = New SortRoutines.CompareListViewItems(e.Column, Lv_SP)
    End Sub

    Private Sub Lv_SP_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lv_SP.SelectedIndexChanged
        Tspell = Lv_SP.SelectedItems(0).Text
        Me.Close()
    End Sub
End Class
