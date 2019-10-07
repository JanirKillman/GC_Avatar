Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing
Public Class Frm_NOsez
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
    Friend WithEvents Lv_NO As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_NOsez))
        Me.Lv_NO = New System.Windows.Forms.ListView
        Me.clSKN = New System.Windows.Forms.ColumnHeader
        Me.clSKO = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Lv_NO
        '
        Me.Lv_NO.BackColor = System.Drawing.Color.Cyan
        Me.Lv_NO.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clSKN, Me.clSKO})
        Me.Lv_NO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lv_NO.ForeColor = System.Drawing.Color.Black
        Me.Lv_NO.FullRowSelect = True
        Me.Lv_NO.GridLines = True
        Me.Lv_NO.Location = New System.Drawing.Point(0, 0)
        Me.Lv_NO.Name = "Lv_NO"
        Me.Lv_NO.Size = New System.Drawing.Size(440, 368)
        Me.Lv_NO.TabIndex = 4
        Me.Lv_NO.View = System.Windows.Forms.View.Details
        '
        'clSKN
        '
        Me.clSKN.Text = "POZNÁMKA"
        Me.clSKN.Width = 320
        '
        'clSKO
        '
        Me.clSKO.Text = "ZE DNE"
        Me.clSKO.Width = 100
        '
        'Frm_NOsez
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 366)
        Me.Controls.Add(Me.Lv_NO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_NOsez"
        Me.Text = "GC AVATAR - Odria Notes seznam"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private lvi As ListViewItem
    Private b As Integer


    Private Sub Frm_NOsez_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        napln_lv()
        Tnote = ""
    End Sub

    Private Sub napln_lv()
        Lv_NO.Items.Clear()
        For b = 0 To NOcount - 1
            lvi = Lv_NO.Items.Add(CType(NOrec.Tables("no").Rows(b)("Note_name"), String))
            If IsDBNull(NOrec.Tables("no").Rows(b)("Date_of_Creation")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(NOrec.Tables("no").Rows(b)("Date_of_Creation"), String))
            End If

        Next
    End Sub


    Private Sub Lv_NO_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Lv_NO.ColumnClick
        Lv_NO.ListViewItemSorter = New SortRoutines.CompareListViewItems(e.Column, Lv_NO)
    End Sub

    Private Sub Lv_NO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv_NO.SelectedIndexChanged
        Tnote = Lv_NO.SelectedItems(0).Text
        Me.Close()
    End Sub
End Class
