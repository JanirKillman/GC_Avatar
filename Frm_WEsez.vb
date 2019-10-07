Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing
Public Class Frm_WEsez
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
    Friend WithEvents Lv_WE As System.Windows.Forms.ListView
    Friend WithEvents clSPN As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSPM As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSPZ As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSPS As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSPD As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSPNa As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSPT As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSPF As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_WEsez))
        Me.Lv_WE = New System.Windows.Forms.ListView
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
        'Lv_WE
        '
        Me.Lv_WE.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(64, Byte), CType(0, Byte))
        Me.Lv_WE.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clSPN, Me.clSPM, Me.clSPZ, Me.clSPS, Me.clSPD, Me.clSPNa, Me.clSPT, Me.clSPF})
        Me.Lv_WE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lv_WE.ForeColor = System.Drawing.Color.Black
        Me.Lv_WE.FullRowSelect = True
        Me.Lv_WE.GridLines = True
        Me.Lv_WE.Location = New System.Drawing.Point(0, 0)
        Me.Lv_WE.Name = "Lv_WE"
        Me.Lv_WE.Size = New System.Drawing.Size(880, 368)
        Me.Lv_WE.TabIndex = 1
        Me.Lv_WE.View = System.Windows.Forms.View.Details
        '
        'clSPN
        '
        Me.clSPN.Text = "NÁZEV"
        Me.clSPN.Width = 275
        '
        'clSPM
        '
        Me.clSPM.Text = "TYP"
        Me.clSPM.Width = 90
        '
        'clSPZ
        '
        Me.clSPZ.Text = "VZOR"
        Me.clSPZ.Width = 110
        '
        'clSPS
        '
        Me.clSPS.Text = "MATERIÁL"
        Me.clSPS.Width = 100
        '
        'clSPD
        '
        Me.clSPD.Text = "DÉMON"
        Me.clSPD.Width = 62
        '
        'clSPNa
        '
        Me.clSPNa.Text = "ENCHANT"
        Me.clSPNa.Width = 90
        '
        'clSPT
        '
        Me.clSPT.Text = "BLESS"
        Me.clSPT.Width = 70
        '
        'clSPF
        '
        Me.clSPF.Text = "CENA"
        Me.clSPF.Width = 70
        '
        'Frm_WEsez
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(64, Byte), CType(0, Byte))
        Me.ClientSize = New System.Drawing.Size(880, 366)
        Me.Controls.Add(Me.Lv_WE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_WEsez"
        Me.Text = "GC AVATAR - Odria Weapons seznam"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private lvi As ListViewItem
    Private b As Integer


    Private Sub Frm_WEsez_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        napln_lv()
        Tweap = ""
    End Sub

    Private Sub napln_lv()
        Lv_WE.Items.Clear()
        For b = 0 To WEcount - 1
            lvi = Lv_WE.Items.Add(CType(WErec.Tables("W").Rows(b)("Weap_name"), String))
            If IsDBNull(WErec.Tables("W").Rows(b)("Typeg")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(WErec.Tables("W").Rows(b)("Typeg"), String))
            End If
            If IsDBNull(WErec.Tables("W").Rows(b)("Templatex")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(WErec.Tables("W").Rows(b)("Templatex"), String))
            End If
            If IsDBNull(WErec.Tables("W").Rows(b)("Material")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(WErec.Tables("W").Rows(b)("Material"), String))
            End If
            If IsDBNull(WErec.Tables("W").Rows(b)("Demon")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(WErec.Tables("W").Rows(b)("DateCre"), Date))
            End If
            If IsDBNull(WErec.Tables("W").Rows(b)("Ench")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(WErec.Tables("W").Rows(b)("Ench"), String))
            End If
            If IsDBNull(WErec.Tables("W").Rows(b)("Bless")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(WErec.Tables("W").Rows(b)("Bless"), String))
            End If
            If IsDBNull(WErec.Tables("W").Rows(b)("App_price")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(WErec.Tables("W").Rows(b)("App_price"), String))
            End If

        Next
    End Sub


    Private Sub Lv_WE_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Lv_WE.ColumnClick
        Lv_WE.ListViewItemSorter = New SortRoutines.CompareListViewItems(e.Column, Lv_WE)
    End Sub

    Private Sub Lv_WE_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lv_WE.SelectedIndexChanged
        Tweap = Lv_WE.SelectedItems(0).Text
        Me.Close()
    End Sub
End Class
