Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing
Public Class Frm_SKsez
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
    Friend WithEvents Lv_SK As System.Windows.Forms.ListView
    Friend WithEvents clSKN As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSKO As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSKA As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSKP As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_SKsez))
        Me.Lv_SK = New System.Windows.Forms.ListView
        Me.clSKN = New System.Windows.Forms.ColumnHeader
        Me.clSKO = New System.Windows.Forms.ColumnHeader
        Me.clSKA = New System.Windows.Forms.ColumnHeader
        Me.clSKP = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Lv_SK
        '
        Me.Lv_SK.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(255, Byte), CType(255, Byte))
        Me.Lv_SK.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clSKN, Me.clSKO, Me.clSKA, Me.clSKP})
        Me.Lv_SK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lv_SK.ForeColor = System.Drawing.Color.Black
        Me.Lv_SK.FullRowSelect = True
        Me.Lv_SK.GridLines = True
        Me.Lv_SK.Location = New System.Drawing.Point(0, 0)
        Me.Lv_SK.Name = "Lv_SK"
        Me.Lv_SK.Size = New System.Drawing.Size(648, 400)
        Me.Lv_SK.TabIndex = 1
        Me.Lv_SK.View = System.Windows.Forms.View.Details
        '
        'clSKN
        '
        Me.clSKN.Text = "SKILL"
        Me.clSKN.Width = 300
        '
        'clSKO
        '
        Me.clSKO.Text = "OBT͎NOST"
        Me.clSKO.Width = 102
        '
        'clSKA
        '
        Me.clSKA.Text = "ATRIBUT"
        Me.clSKA.Width = 90
        '
        'clSKP
        '
        Me.clSKP.Text = "POPIS"
        Me.clSKP.Width = 150
        '
        'Frm_SKsez
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(648, 398)
        Me.Controls.Add(Me.Lv_SK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_SKsez"
        Me.Text = "GC AVATAR - Odria Skills seznam"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private lvi As ListViewItem
    Private b As Integer


    Private Sub Frm_SKsez_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        napln_lv()
        Tski = ""
    End Sub

    Private Sub napln_lv()
        Lv_SK.Items.Clear()
        For b = 0 To SKcount - 1
            lvi = Lv_SK.Items.Add(CType(SKrec.Tables("Sk").Rows(b)("Skill"), String))
            If IsDBNull(SKrec.Tables("Sk").Rows(b)("Difficulty")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(SKrec.Tables("Sk").Rows(b)("Difficulty"), String))
            End If
            If IsDBNull(SKrec.Tables("Sk").Rows(b)("Associated_atr")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(SKrec.Tables("Sk").Rows(b)("Associated_atr"), String))
            End If
            If IsDBNull(SKrec.Tables("Sk").Rows(b)("Susage")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(Mid(SKrec.Tables("Sk").Rows(b)("Susage"), 1, 30), String))
            End If
        Next
    End Sub


    Private Sub Lv_SK_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Lv_SK.ColumnClick
        Lv_SK.ListViewItemSorter = New SortRoutines.CompareListViewItems(e.Column, Lv_SK)
    End Sub

    Private Sub Lv_SK_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lv_SK.SelectedIndexChanged
        Tski = Lv_SK.SelectedItems(0).Text
        Me.Close()
    End Sub
End Class
