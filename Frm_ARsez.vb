Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing
Public Class Frm_ARsez
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
    Friend WithEvents cid As System.Windows.Forms.ColumnHeader
    Friend WithEvents Lv_AR As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_ARsez))
        Me.Lv_AR = New System.Windows.Forms.ListView
        Me.clSKN = New System.Windows.Forms.ColumnHeader
        Me.clSKO = New System.Windows.Forms.ColumnHeader
        Me.clSKA = New System.Windows.Forms.ColumnHeader
        Me.clSKP = New System.Windows.Forms.ColumnHeader
        Me.cid = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Lv_AR
        '
        Me.Lv_AR.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.Lv_AR.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clSKN, Me.clSKO, Me.clSKA, Me.clSKP, Me.cid})
        Me.Lv_AR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lv_AR.ForeColor = System.Drawing.Color.Black
        Me.Lv_AR.FullRowSelect = True
        Me.Lv_AR.GridLines = True
        Me.Lv_AR.Location = New System.Drawing.Point(0, 0)
        Me.Lv_AR.Name = "Lv_AR"
        Me.Lv_AR.Size = New System.Drawing.Size(864, 400)
        Me.Lv_AR.TabIndex = 5
        Me.Lv_AR.View = System.Windows.Forms.View.Details
        '
        'clSKN
        '
        Me.clSKN.Text = "ARTEFAKT"
        Me.clSKN.Width = 260
        '
        'clSKO
        '
        Me.clSKO.Text = "ZNÁM JAKO"
        Me.clSKO.Width = 240
        '
        'clSKA
        '
        Me.clSKA.Text = "NALÉZÁ SE"
        Me.clSKA.Width = 170
        '
        'clSKP
        '
        Me.clSKP.Text = "VLASTNICTVÍ"
        Me.clSKP.Width = 170
        '
        'cid
        '
        Me.cid.Width = 0
        '
        'Frm_ARsez
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(864, 398)
        Me.Controls.Add(Me.Lv_AR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_ARsez"
        Me.Text = "GC AVATAR - Odria Artifacts seznam"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private lvi As ListViewItem
    Private b As Integer


    Private Sub Frm_ARsez_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        napln_lv()
        Tartif = ""
    End Sub

    Private Sub napln_lv()
        Lv_AR.Items.Clear()
        For b = 0 To ARcount - 1
            lvi = Lv_AR.Items.Add(CType(ARrec.Tables("ar").Rows(b)("Artifact"), String))
            If IsDBNull(ARrec.Tables("ar").Rows(b)("Also_known")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(ARrec.Tables("ar").Rows(b)("Also_known"), String))
            End If
            If IsDBNull(ARrec.Tables("ar").Rows(b)("Site")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(ARrec.Tables("ar").Rows(b)("Site"), String))
            End If
            If IsDBNull(ARrec.Tables("ar").Rows(b)("Property_of")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(ARrec.Tables("ar").Rows(b)("Property_of"), String))
            End If
            lvi.SubItems.Add(CType(ARrec.Tables("ar").Rows(b)("ID"), String))
        Next
    End Sub


    Private Sub Lv_AR_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Lv_AR.ColumnClick
        Lv_AR.ListViewItemSorter = New SortRoutines.CompareListViewItems(e.Column, Lv_AR)
    End Sub

    Private Sub Lv_AR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv_AR.SelectedIndexChanged
        Tartif = Lv_AR.SelectedItems(0).SubItems(4).Text
        Me.Close()
    End Sub
End Class
