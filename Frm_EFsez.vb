Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing
Public Class Frm_EFsez
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
    Friend WithEvents clDMC As System.Windows.Forms.ColumnHeader
    Friend WithEvents clEC As System.Windows.Forms.ColumnHeader
    Friend WithEvents clROF As System.Windows.Forms.ColumnHeader
    Friend WithEvents Lv_EF As System.Windows.Forms.ListView
    Friend WithEvents clID As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_EFsez))
        Me.Lv_EF = New System.Windows.Forms.ListView
        Me.clSKN = New System.Windows.Forms.ColumnHeader
        Me.clSKO = New System.Windows.Forms.ColumnHeader
        Me.clSKA = New System.Windows.Forms.ColumnHeader
        Me.clSKP = New System.Windows.Forms.ColumnHeader
        Me.clDMC = New System.Windows.Forms.ColumnHeader
        Me.clEC = New System.Windows.Forms.ColumnHeader
        Me.clROF = New System.Windows.Forms.ColumnHeader
        Me.clID = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Lv_EF
        '
        Me.Lv_EF.BackColor = System.Drawing.Color.Purple
        Me.Lv_EF.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clSKN, Me.clSKO, Me.clSKA, Me.clSKP, Me.clDMC, Me.clEC, Me.clROF, Me.clID})
        Me.Lv_EF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lv_EF.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(0, Byte))
        Me.Lv_EF.FullRowSelect = True
        Me.Lv_EF.GridLines = True
        Me.Lv_EF.Location = New System.Drawing.Point(0, 0)
        Me.Lv_EF.Name = "Lv_EF"
        Me.Lv_EF.Size = New System.Drawing.Size(920, 408)
        Me.Lv_EF.TabIndex = 4
        Me.Lv_EF.View = System.Windows.Forms.View.Details
        '
        'clSKN
        '
        Me.clSKN.Text = "FIRMA"
        Me.clSKN.Width = 180
        '
        'clSKO
        '
        Me.clSKO.Text = "DRUH ZBRANě"
        Me.clSKO.Width = 180
        '
        'clSKA
        '
        Me.clSKA.Text = "PODDRUH"
        Me.clSKA.Width = 180
        '
        'clSKP
        '
        Me.clSKP.Text = "VZOR"
        Me.clSKP.Width = 90
        '
        'clDMC
        '
        Me.clDMC.Text = "DMC"
        Me.clDMC.Width = 90
        '
        'clEC
        '
        Me.clEC.Text = "SPOTřEBA"
        Me.clEC.Width = 90
        '
        'clROF
        '
        Me.clROF.Text = "ROF"
        Me.clROF.Width = 90
        '
        'clID
        '
        Me.clID.Width = 0
        '
        'Frm_EFsez
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(920, 406)
        Me.Controls.Add(Me.Lv_EF)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_EFsez"
        Me.Text = "GC AVATAR - Odria Weapon efficiency seznam"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private lvi As ListViewItem
    Private b As Integer


    Private Sub Frm_EFsez_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        napln_lv()
        Tef = ""
    End Sub

    Private Sub napln_lv()
        Lv_EF.Items.Clear()
        For b = 0 To EFcount - 1
            lvi = Lv_EF.Items.Add(CType(EFrec.Tables("ef").Rows(b)("Firma"), String))
            lvi.SubItems.Add(CType(EFrec.Tables("ef").Rows(b)("Druh_Zbraně"), String))
            lvi.SubItems.Add(CType(EFrec.Tables("ef").Rows(b)("Poddruh"), String))
            lvi.SubItems.Add(CType(EFrec.Tables("ef").Rows(b)("Vzor"), String))
            If IsDBNull(EFrec.Tables("ef").Rows(b)("DMC")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(EFrec.Tables("ef").Rows(b)("DMC"), String))
            End If
            If IsDBNull(EFrec.Tables("ef").Rows(b)("EC")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(EFrec.Tables("ef").Rows(b)("EC"), String))
            End If
            If IsDBNull(EFrec.Tables("ef").Rows(b)("ROF")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(EFrec.Tables("ef").Rows(b)("ROF"), String))
            End If
            lvi.SubItems.Add(CType(EFrec.Tables("ef").Rows(b)("Kód"), String))
        Next
    End Sub


    Private Sub Lv_EF_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Lv_EF.ColumnClick
        Lv_EF.ListViewItemSorter = New SortRoutines.CompareListViewItems(e.Column, Lv_EF)
    End Sub

    Private Sub Lv_EF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv_EF.SelectedIndexChanged
        Tef = Lv_EF.SelectedItems(0).SubItems(7).Text
        Me.Close()
    End Sub
End Class
