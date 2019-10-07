Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing
Public Class Frm_PAsez
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
    Friend WithEvents Lv_PA As System.Windows.Forms.ListView
    Friend WithEvents clID As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_PAsez))
        Me.Lv_PA = New System.Windows.Forms.ListView
        Me.clSKN = New System.Windows.Forms.ColumnHeader
        Me.clSKO = New System.Windows.Forms.ColumnHeader
        Me.clSKA = New System.Windows.Forms.ColumnHeader
        Me.clID = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Lv_PA
        '
        Me.Lv_PA.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(0, Byte))
        Me.Lv_PA.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clSKN, Me.clSKO, Me.clSKA, Me.clID})
        Me.Lv_PA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lv_PA.ForeColor = System.Drawing.Color.Black
        Me.Lv_PA.FullRowSelect = True
        Me.Lv_PA.GridLines = True
        Me.Lv_PA.Location = New System.Drawing.Point(0, 0)
        Me.Lv_PA.Name = "Lv_PA"
        Me.Lv_PA.Size = New System.Drawing.Size(648, 400)
        Me.Lv_PA.TabIndex = 3
        Me.Lv_PA.View = System.Windows.Forms.View.Details
        '
        'clSKN
        '
        Me.clSKN.Text = "HESLO"
        Me.clSKN.Width = 200
        '
        'clSKO
        '
        Me.clSKO.Text = "VÝZNAM"
        Me.clSKO.Width = 300
        '
        'clSKA
        '
        Me.clSKA.Text = "TABULKA"
        Me.clSKA.Width = 140
        '
        'clID
        '
        Me.clID.Width = 0
        '
        'Frm_PAsez
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(648, 398)
        Me.Controls.Add(Me.Lv_PA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_PAsez"
        Me.Text = "GC AVATAR - Odria Passwords seznam"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private lvi As ListViewItem
    Private b As Integer


    Private Sub Frm_PAsez_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        napln_lv()
        Tpa = ""
    End Sub

    Private Sub napln_lv()
        Lv_PA.Items.Clear()
        For b = 0 To PAcount - 1
            lvi = Lv_PA.Items.Add(CType(PArec.Tables("pa").Rows(b)("PasswordX"), String))
            If IsDBNull(PArec.Tables("pa").Rows(b)("Meaning")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(PArec.Tables("pa").Rows(b)("Meaning"), String))
            End If
            If IsDBNull(PArec.Tables("pa").Rows(b)("TableX")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(PArec.Tables("pa").Rows(b)("TableX"), String))
            End If
            lvi.SubItems.Add(CType(PArec.Tables("pa").Rows(b)("ID"), String))
        Next
    End Sub


    Private Sub Lv_PA_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Lv_PA.ColumnClick
        Lv_PA.ListViewItemSorter = New SortRoutines.CompareListViewItems(e.Column, Lv_PA)
    End Sub

    Private Sub Lv_PA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv_PA.SelectedIndexChanged
        Tpa = Lv_PA.SelectedItems(0).SubItems(3).Text
        Me.Close()
    End Sub
End Class
