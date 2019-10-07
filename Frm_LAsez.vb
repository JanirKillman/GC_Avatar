Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing
Public Class Frm_LAsez
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
    Friend WithEvents Lv_LA As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_LAsez))
        Me.Lv_LA = New System.Windows.Forms.ListView
        Me.clSKN = New System.Windows.Forms.ColumnHeader
        Me.clSKO = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Lv_LA
        '
        Me.Lv_LA.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.Lv_LA.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clSKN, Me.clSKO})
        Me.Lv_LA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lv_LA.ForeColor = System.Drawing.Color.Black
        Me.Lv_LA.FullRowSelect = True
        Me.Lv_LA.GridLines = True
        Me.Lv_LA.Location = New System.Drawing.Point(0, 0)
        Me.Lv_LA.Name = "Lv_LA"
        Me.Lv_LA.Size = New System.Drawing.Size(440, 368)
        Me.Lv_LA.TabIndex = 2
        Me.Lv_LA.View = System.Windows.Forms.View.Details
        '
        'clSKN
        '
        Me.clSKN.Text = "JAZYK"
        Me.clSKN.Width = 220
        '
        'clSKO
        '
        Me.clSKO.Text = "SKUPINA"
        Me.clSKO.Width = 200
        '
        'Frm_LAsez
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 366)
        Me.Controls.Add(Me.Lv_LA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_LAsez"
        Me.Text = "GC AVATAR - Odria Languages seznam"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private lvi As ListViewItem
    Private b As Integer


    Private Sub Frm_LAsez_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        napln_lv()
        Tlan = ""
    End Sub

    Private Sub napln_lv()
        Lv_LA.Items.Clear()
        For b = 0 To LAcount - 1
            lvi = Lv_LA.Items.Add(CType(LArec.Tables("l").Rows(b)("Language"), String))
            If IsDBNull(LArec.Tables("l").Rows(b)("Lang_group")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(LArec.Tables("l").Rows(b)("Lang_group"), String))
            End If
            
        Next
    End Sub


    Private Sub Lv_LA_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Lv_LA.ColumnClick
        Lv_LA.ListViewItemSorter = New SortRoutines.CompareListViewItems(e.Column, Lv_LA)
    End Sub

    Private Sub Lv_LA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv_LA.SelectedIndexChanged
        Tlan = Lv_LA.SelectedItems(0).Text
        Me.Close()
    End Sub
End Class
