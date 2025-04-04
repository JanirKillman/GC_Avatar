Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing
Public Class Frm_SIsez
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
    Friend WithEvents Lv_SI As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_SIsez))
        Me.Lv_SI = New System.Windows.Forms.ListView
        Me.clSKN = New System.Windows.Forms.ColumnHeader
        Me.clSKO = New System.Windows.Forms.ColumnHeader
        Me.clSKA = New System.Windows.Forms.ColumnHeader
        Me.clSKP = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Lv_SI
        '
        Me.Lv_SI.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        Me.Lv_SI.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clSKN, Me.clSKO, Me.clSKA, Me.clSKP})
        Me.Lv_SI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lv_SI.ForeColor = System.Drawing.Color.Black
        Me.Lv_SI.FullRowSelect = True
        Me.Lv_SI.GridLines = True
        Me.Lv_SI.Location = New System.Drawing.Point(0, 0)
        Me.Lv_SI.Name = "Lv_SI"
        Me.Lv_SI.Size = New System.Drawing.Size(648, 400)
        Me.Lv_SI.TabIndex = 2
        Me.Lv_SI.View = System.Windows.Forms.View.Details
        '
        'clSKN
        '
        Me.clSKN.Text = "MÍSTO"
        Me.clSKN.Width = 300
        '
        'clSKO
        '
        Me.clSKO.Text = "ZEMě"
        Me.clSKO.Width = 102
        '
        'clSKA
        '
        Me.clSKA.Text = "TYP"
        Me.clSKA.Width = 90
        '
        'clSKP
        '
        Me.clSKP.Text = "OBSAH"
        Me.clSKP.Width = 150
        '
        'Frm_SIsez
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(648, 398)
        Me.Controls.Add(Me.Lv_SI)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_SIsez"
        Me.Text = "GC AVATAR - Odria Sites seznam"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private lvi As ListViewItem
    Private b As Integer


    Private Sub Frm_SIsez_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        napln_lv()
        Tsit = ""
    End Sub

    Private Sub napln_lv()
        Lv_SI.Items.Clear()
        For b = 0 To SIcount - 1
            lvi = Lv_SI.Items.Add(CType(SIrec.Tables("si").Rows(b)("Site"), String))
            If IsDBNull(SIrec.Tables("si").Rows(b)("Country")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(SIrec.Tables("si").Rows(b)("Country"), String))
            End If
            If IsDBNull(SIrec.Tables("si").Rows(b)("Type")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(SIrec.Tables("si").Rows(b)("Type"), String))
            End If
            If IsDBNull(SIrec.Tables("si").Rows(b)("Whats_inside")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(SIrec.Tables("si").Rows(b)("Whats_inside"), String))
            End If
        Next
    End Sub


    Private Sub Lv_SI_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Lv_SI.ColumnClick
        Lv_SI.ListViewItemSorter = New SortRoutines.CompareListViewItems(e.Column, Lv_SI)
    End Sub

    Private Sub Lv_SI_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv_SI.SelectedIndexChanged
        Tsit = Lv_SI.SelectedItems(0).Text
        Me.Close()
    End Sub
End Class
