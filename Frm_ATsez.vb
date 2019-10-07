Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing
Public Class Frm_ATsez
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
    Friend WithEvents Lv_AT As System.Windows.Forms.ListView
    Friend WithEvents cid As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_ATsez))
        Me.Lv_AT = New System.Windows.Forms.ListView
        Me.clSKN = New System.Windows.Forms.ColumnHeader
        Me.clSKO = New System.Windows.Forms.ColumnHeader
        Me.clSKA = New System.Windows.Forms.ColumnHeader
        Me.clSKP = New System.Windows.Forms.ColumnHeader
        Me.cid = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Lv_AT
        '
        Me.Lv_AT.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(255, Byte))
        Me.Lv_AT.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clSKN, Me.clSKO, Me.clSKA, Me.clSKP, Me.cid})
        Me.Lv_AT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lv_AT.ForeColor = System.Drawing.Color.Black
        Me.Lv_AT.FullRowSelect = True
        Me.Lv_AT.GridLines = True
        Me.Lv_AT.Location = New System.Drawing.Point(0, 0)
        Me.Lv_AT.Name = "Lv_AT"
        Me.Lv_AT.Size = New System.Drawing.Size(864, 400)
        Me.Lv_AT.TabIndex = 4
        Me.Lv_AT.View = System.Windows.Forms.View.Details
        '
        'clSKN
        '
        Me.clSKN.Text = "AUTOR"
        Me.clSKN.Width = 260
        '
        'clSKO
        '
        Me.clSKO.Text = "NÁZEV"
        Me.clSKO.Width = 240
        '
        'clSKA
        '
        Me.clSKA.Text = "INSTANCE"
        Me.clSKA.Width = 240
        '
        'clSKP
        '
        Me.clSKP.Text = "TYP"
        Me.clSKP.Width = 100
        '
        'cid
        '
        Me.cid.Width = 0
        '
        'Frm_ATsez
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(864, 398)
        Me.Controls.Add(Me.Lv_AT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_ATsez"
        Me.Text = "GC AVATAR - Odria Art seznam"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private lvi As ListViewItem
    Private b As Integer


    Private Sub Frm_ATsez_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        napln_lv()
        Tart = ""
    End Sub

    Private Sub napln_lv()
        Lv_AT.Items.Clear()
        For b = 0 To ATcount - 1
            lvi = Lv_AT.Items.Add(CType(ATrec.Tables("at").Rows(b)("Author"), String))
            If IsDBNull(ATrec.Tables("at").Rows(b)("Name")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(ATrec.Tables("at").Rows(b)("Name"), String))
            End If
            If IsDBNull(ATrec.Tables("at").Rows(b)("Instance")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(ATrec.Tables("at").Rows(b)("Instance"), String))
            End If
            If IsDBNull(ATrec.Tables("at").Rows(b)("Type")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(ATrec.Tables("at").Rows(b)("Type"), String))
            End If
            lvi.SubItems.Add(CType(ATrec.Tables("at").Rows(b)("ID"), String))
        Next
    End Sub


    Private Sub Lv_AT_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Lv_AT.ColumnClick
        Lv_AT.ListViewItemSorter = New SortRoutines.CompareListViewItems(e.Column, Lv_AT)
    End Sub

    Private Sub Lv_AT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv_AT.SelectedIndexChanged
        Tart = Lv_AT.SelectedItems(0).SubItems(4).Text
        Me.Close()
    End Sub
End Class
