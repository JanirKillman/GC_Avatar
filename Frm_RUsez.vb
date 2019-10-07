Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing
Public Class Frm_RUsez
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
    Friend WithEvents Lv_RU As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_RUsez))
        Me.Lv_RU = New System.Windows.Forms.ListView
        Me.clSKN = New System.Windows.Forms.ColumnHeader
        Me.clSKO = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Lv_RU
        '
        Me.Lv_RU.BackColor = System.Drawing.Color.Green
        Me.Lv_RU.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clSKN, Me.clSKO})
        Me.Lv_RU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lv_RU.ForeColor = System.Drawing.Color.Black
        Me.Lv_RU.FullRowSelect = True
        Me.Lv_RU.GridLines = True
        Me.Lv_RU.Location = New System.Drawing.Point(0, 0)
        Me.Lv_RU.Name = "Lv_RU"
        Me.Lv_RU.Size = New System.Drawing.Size(440, 368)
        Me.Lv_RU.TabIndex = 3
        Me.Lv_RU.View = System.Windows.Forms.View.Details
        '
        'clSKN
        '
        Me.clSKN.Text = "PRAVIDLO"
        Me.clSKN.Width = 320
        '
        'clSKO
        '
        Me.clSKO.Text = "ZE DNE"
        Me.clSKO.Width = 100
        '
        'Frm_RUsez
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 366)
        Me.Controls.Add(Me.Lv_RU)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_RUsez"
        Me.Text = "GC AVATAR - Odria Rules seznam"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private lvi As ListViewItem
    Private b As Integer


    Private Sub Frm_RUsez_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        napln_lv()
        Trule = ""
    End Sub

    Private Sub napln_lv()
        Lv_RU.Items.Clear()
        For b = 0 To RUcount - 1
            lvi = Lv_RU.Items.Add(CType(RUrec.Tables("ru").Rows(b)("R_name"), String))
            If IsDBNull(RUrec.Tables("ru").Rows(b)("R_DTC")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(RUrec.Tables("ru").Rows(b)("R_DTC"), String))
            End If

        Next
    End Sub


    Private Sub Lv_RU_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Lv_RU.ColumnClick
        Lv_RU.ListViewItemSorter = New SortRoutines.CompareListViewItems(e.Column, Lv_RU)
    End Sub

    Private Sub Lv_RU_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv_RU.SelectedIndexChanged
        Trule = Lv_RU.SelectedItems(0).Text
        Me.Close()
    End Sub
End Class
