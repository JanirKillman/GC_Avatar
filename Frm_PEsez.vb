Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing
Public Class Frm_PEsez
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
    Friend WithEvents Lv_PE As System.Windows.Forms.ListView
    Friend WithEvents clSK As System.Windows.Forms.ColumnHeader
    Friend WithEvents clOB As System.Windows.Forms.ColumnHeader
    Friend WithEvents clZA As System.Windows.Forms.ColumnHeader
    Friend WithEvents clPR As System.Windows.Forms.ColumnHeader
    Friend WithEvents clDC As System.Windows.Forms.ColumnHeader
    Friend WithEvents clN As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_PEsez))
        Me.Lv_PE = New System.Windows.Forms.ListView
        Me.clSK = New System.Windows.Forms.ColumnHeader
        Me.clOB = New System.Windows.Forms.ColumnHeader
        Me.clZA = New System.Windows.Forms.ColumnHeader
        Me.clPR = New System.Windows.Forms.ColumnHeader
        Me.clDC = New System.Windows.Forms.ColumnHeader
        Me.clN = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Lv_PE
        '
        Me.Lv_PE.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Lv_PE.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clSK, Me.clOB, Me.clZA, Me.clPR, Me.clDC, Me.clN})
        Me.Lv_PE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lv_PE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Lv_PE.FullRowSelect = True
        Me.Lv_PE.GridLines = True
        Me.Lv_PE.Location = New System.Drawing.Point(0, 0)
        Me.Lv_PE.Name = "Lv_PE"
        Me.Lv_PE.Size = New System.Drawing.Size(808, 272)
        Me.Lv_PE.TabIndex = 3
        Me.Lv_PE.View = System.Windows.Forms.View.Details
        '
        'clSK
        '
        Me.clSK.Text = "OSOBA"
        Me.clSK.Width = 260
        '
        'clOB
        '
        Me.clOB.Text = "STATUS"
        Me.clOB.Width = 120
        '
        'clZA
        '
        Me.clZA.Text = "DOMOV"
        Me.clZA.Width = 190
        '
        'clPR
        '
        Me.clPR.Text = "SÍLA"
        Me.clPR.Width = 70
        '
        'clDC
        '
        Me.clDC.Text = "STRANA"
        Me.clDC.Width = 90
        '
        'clN
        '
        Me.clN.Text = "VěK"
        '
        'Frm_PEsez
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(808, 270)
        Me.Controls.Add(Me.Lv_PE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_PEsez"
        Me.Text = "GC AVATAR - Odria Personel seznam"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private lvi As ListViewItem
    Private b As Integer

    Private Sub Frm_PEsez_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        napln_lv()
        Tper = ""
    End Sub

    Private Sub napln_lv()
        Lv_PE.Items.Clear()
        For b = 0 To PEcount - 1
            lvi = Lv_PE.Items.Add(CType(PErec.Tables("pe").Rows(b)("Name"), String))
            If IsDBNull(PErec.Tables("pe").Rows(b)("Statusx")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(PErec.Tables("pe").Rows(b)("Statusx"), String))
            End If
            If IsDBNull(PErec.Tables("pe").Rows(b)("Home_site")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(PErec.Tables("pe").Rows(b)("Home_site"), String))
            End If
            If IsDBNull(PErec.Tables("pe").Rows(b)("Ap_power")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(PErec.Tables("pe").Rows(b)("Ap_power"), String))
            End If
            If IsDBNull(PErec.Tables("pe").Rows(b)("Known_alegiance")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(PErec.Tables("pe").Rows(b)("Known_alegiance"), String))
            End If
            If IsDBNull(PErec.Tables("pe").Rows(b)("Age")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(PErec.Tables("pe").Rows(b)("Age"), String))
            End If
        Next
    End Sub

    Private Sub Lv_PE_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Lv_PE.ColumnClick
        Lv_PE.ListViewItemSorter = New SortRoutines.CompareListViewItems(e.Column, Lv_PE)
    End Sub

    Private Sub Lv_PE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv_PE.SelectedIndexChanged
        Tper = Lv_PE.SelectedItems(0).Text
        Me.Close()
    End Sub
End Class
