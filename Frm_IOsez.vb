Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing
Public Class Frm_IOsez
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
    Friend WithEvents Lv_IO As System.Windows.Forms.ListView
    Friend WithEvents clSKN As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSKO As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSKA As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_IOsez))
        Me.Lv_IO = New System.Windows.Forms.ListView
        Me.clSKN = New System.Windows.Forms.ColumnHeader
        Me.clSKO = New System.Windows.Forms.ColumnHeader
        Me.clSKA = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Lv_IO
        '
        Me.Lv_IO.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(128, Byte))
        Me.Lv_IO.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clSKN, Me.clSKO, Me.clSKA})
        Me.Lv_IO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lv_IO.ForeColor = System.Drawing.Color.Black
        Me.Lv_IO.FullRowSelect = True
        Me.Lv_IO.GridLines = True
        Me.Lv_IO.Location = New System.Drawing.Point(0, 0)
        Me.Lv_IO.Name = "Lv_IO"
        Me.Lv_IO.Size = New System.Drawing.Size(648, 400)
        Me.Lv_IO.TabIndex = 2
        Me.Lv_IO.View = System.Windows.Forms.View.Details
        '
        'clSKN
        '
        Me.clSKN.Text = "INFO"
        Me.clSKN.Width = 300
        '
        'clSKO
        '
        Me.clSKO.Text = "OBSAH"
        Me.clSKO.Width = 200
        '
        'clSKA
        '
        Me.clSKA.Text = "VÍ O TOM"
        Me.clSKA.Width = 140
        '
        'Frm_IOsez
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(648, 398)
        Me.Controls.Add(Me.Lv_IO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_IOsez"
        Me.Text = "GC AVATAR - Odria Info seznam"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private lvi As ListViewItem
    Private b As Integer


    Private Sub Frm_IOsez_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        napln_lv()
        Tinf = ""
    End Sub

    Private Sub napln_lv()
        Lv_IO.Items.Clear()
        For b = 0 To IOcount - 1
            lvi = Lv_IO.Items.Add(CType(IOrec.Tables("io").Rows(b)("Info_name"), String))
            If IsDBNull(IOrec.Tables("io").Rows(b)("Infoo")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(IOrec.Tables("io").Rows(b)("Infoo"), String))
            End If
            If IsDBNull(IOrec.Tables("io").Rows(b)("Known")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(IOrec.Tables("io").Rows(b)("Known"), String))
            End If
        Next
    End Sub


    Private Sub Lv_IO_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Lv_IO.ColumnClick
        Lv_IO.ListViewItemSorter = New SortRoutines.CompareListViewItems(e.Column, Lv_IO)
    End Sub

    Private Sub Lv_IO_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lv_IO.SelectedIndexChanged
        Tinf = Lv_IO.SelectedItems(0).Text
        Me.Close()
    End Sub
End Class
