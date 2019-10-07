Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing
Public Class Frm_RAsez
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
    Friend WithEvents Lv_RA As System.Windows.Forms.ListView
    Friend WithEvents clK As System.Windows.Forms.ColumnHeader
    Friend WithEvents clC As System.Windows.Forms.ColumnHeader
    Friend WithEvents clZ As System.Windows.Forms.ColumnHeader
    Friend WithEvents clR As System.Windows.Forms.ColumnHeader
    Friend WithEvents clD As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_RAsez))
        Me.Lv_RA = New System.Windows.Forms.ListView
        Me.clSPN = New System.Windows.Forms.ColumnHeader
        Me.clSPM = New System.Windows.Forms.ColumnHeader
        Me.clSPZ = New System.Windows.Forms.ColumnHeader
        Me.clSPS = New System.Windows.Forms.ColumnHeader
        Me.clSPD = New System.Windows.Forms.ColumnHeader
        Me.clSPNa = New System.Windows.Forms.ColumnHeader
        Me.clSPT = New System.Windows.Forms.ColumnHeader
        Me.clSPF = New System.Windows.Forms.ColumnHeader
        Me.clK = New System.Windows.Forms.ColumnHeader
        Me.clC = New System.Windows.Forms.ColumnHeader
        Me.clZ = New System.Windows.Forms.ColumnHeader
        Me.clR = New System.Windows.Forms.ColumnHeader
        Me.clD = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Lv_RA
        '
        Me.Lv_RA.BackColor = System.Drawing.Color.Maroon
        Me.Lv_RA.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clSPN, Me.clSPM, Me.clSPZ, Me.clSPS, Me.clSPD, Me.clSPNa, Me.clSPT, Me.clSPF, Me.clK, Me.clC, Me.clZ, Me.clR, Me.clD})
        Me.Lv_RA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lv_RA.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(0, Byte))
        Me.Lv_RA.FullRowSelect = True
        Me.Lv_RA.GridLines = True
        Me.Lv_RA.Location = New System.Drawing.Point(0, 0)
        Me.Lv_RA.Name = "Lv_RA"
        Me.Lv_RA.Size = New System.Drawing.Size(880, 368)
        Me.Lv_RA.TabIndex = 1
        Me.Lv_RA.View = System.Windows.Forms.View.Details
        '
        'clSPN
        '
        Me.clSPN.Text = "RASA"
        Me.clSPN.Width = 170
        '
        'clSPM
        '
        Me.clSPM.Text = "SIL"
        Me.clSPM.Width = 40
        '
        'clSPZ
        '
        Me.clSPZ.Text = "HBI"
        Me.clSPZ.Width = 40
        '
        'clSPS
        '
        Me.clSPS.Text = "ZRU"
        Me.clSPS.Width = 40
        '
        'clSPD
        '
        Me.clSPD.Text = "FOD"
        Me.clSPD.Width = 40
        '
        'clSPNa
        '
        Me.clSPNa.Text = "POD"
        Me.clSPNa.Width = 42
        '
        'clSPT
        '
        Me.clSPT.Text = "IQ"
        Me.clSPT.Width = 40
        '
        'clSPF
        '
        Me.clSPF.Text = "JED"
        Me.clSPF.Width = 40
        '
        'clK
        '
        Me.clK.Text = "KRA"
        Me.clK.Width = 40
        '
        'clC
        '
        Me.clC.Text = "CENA"
        Me.clC.Width = 80
        '
        'clZ
        '
        Me.clZ.Text = "ŽIVOT"
        Me.clZ.Width = 80
        '
        'clR
        '
        Me.clR.Text = "RARITA"
        Me.clR.Width = 120
        '
        'clD
        '
        Me.clD.Text = "DATUM"
        Me.clD.Width = 80
        '
        'Frm_RAsez
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(880, 366)
        Me.Controls.Add(Me.Lv_RA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_RAsez"
        Me.Text = "GC AVATAR - Odria Races seznam"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private lvi As ListViewItem
    Private b As Integer


    Private Sub Frm_RAsez_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        napln_lv()
        Trac = ""
    End Sub

    Private Sub napln_lv()
        Lv_RA.Items.Clear()
        For b = 0 To RAcount - 1
            lvi = Lv_RA.Items.Add(CType(RArec.Tables("ra").Rows(b)("Race_name"), String))
            If IsDBNull(RArec.Tables("ra").Rows(b)("Racial_str")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(RArec.Tables("ra").Rows(b)("Racial_str"), String))
            End If
            If IsDBNull(RArec.Tables("ra").Rows(b)("Racial_dex")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(RArec.Tables("ra").Rows(b)("Racial_dex"), String))
            End If
            If IsDBNull(RArec.Tables("ra").Rows(b)("Racial_skill")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(RArec.Tables("ra").Rows(b)("Racial_skill"), String))
            End If

            If IsDBNull(RArec.Tables("ra").Rows(b)("Racial_fodl")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(RArec.Tables("ra").Rows(b)("Racial_fodl"), String))
            End If
            If IsDBNull(RArec.Tables("ra").Rows(b)("Racial_podl")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(RArec.Tables("ra").Rows(b)("Racial_podl"), String))
            End If
            If IsDBNull(RArec.Tables("ra").Rows(b)("Racial_IQ")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(RArec.Tables("ra").Rows(b)("Racial_IQ"), String))
            End If
            If IsDBNull(RArec.Tables("ra").Rows(b)("Racial_beh")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(RArec.Tables("ra").Rows(b)("Racial_beh"), String))
            End If
            If IsDBNull(RArec.Tables("ra").Rows(b)("Racial_beau")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(RArec.Tables("ra").Rows(b)("Racial_beau"), String))
            End If
            If IsDBNull(RArec.Tables("ra").Rows(b)("Racial_cost")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(RArec.Tables("ra").Rows(b)("Racial_cost"), String))
            End If
            If IsDBNull(RArec.Tables("ra").Rows(b)("Racial_lifespan")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(RArec.Tables("ra").Rows(b)("Racial_lifespan"), String))
            End If
            If IsDBNull(RArec.Tables("ra").Rows(b)("Rarity")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(RArec.Tables("ra").Rows(b)("Rarity"), String))
            End If
            lvi.SubItems.Add(CType(RArec.Tables("ra").Rows(b)("Date_created"), Date))
        Next
    End Sub


    Private Sub Lv_RA_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Lv_RA.ColumnClick
        Lv_RA.ListViewItemSorter = New SortRoutines.CompareListViewItems(e.Column, Lv_RA)
    End Sub

    Private Sub Lv_RA_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lv_RA.SelectedIndexChanged
        Trac = Lv_RA.SelectedItems(0).Text
        Me.Close()
    End Sub
End Class
