Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing
Public Class Frm_PRsez
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
    Friend WithEvents Lv_PR As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_PRsez))
        Me.Lv_PR = New System.Windows.Forms.ListView
        Me.clSKN = New System.Windows.Forms.ColumnHeader
        Me.clSKO = New System.Windows.Forms.ColumnHeader
        Me.clSKA = New System.Windows.Forms.ColumnHeader
        Me.clSKP = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Lv_PR
        '
        Me.Lv_PR.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(0, Byte))
        Me.Lv_PR.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clSKN, Me.clSKO, Me.clSKA, Me.clSKP})
        Me.Lv_PR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lv_PR.ForeColor = System.Drawing.Color.Black
        Me.Lv_PR.FullRowSelect = True
        Me.Lv_PR.GridLines = True
        Me.Lv_PR.Location = New System.Drawing.Point(0, 0)
        Me.Lv_PR.Name = "Lv_PR"
        Me.Lv_PR.Size = New System.Drawing.Size(744, 400)
        Me.Lv_PR.TabIndex = 2
        Me.Lv_PR.View = System.Windows.Forms.View.Details
        '
        'clSKN
        '
        Me.clSKN.Text = "NÁZEV"
        Me.clSKN.Width = 360
        '
        'clSKO
        '
        Me.clSKO.Text = "TYP"
        Me.clSKO.Width = 120
        '
        'clSKA
        '
        Me.clSKA.Text = "PODTYP"
        Me.clSKA.Width = 120
        '
        'clSKP
        '
        Me.clSKP.Text = "CENA"
        Me.clSKP.Width = 120
        '
        'Frm_PRsez
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(744, 398)
        Me.Controls.Add(Me.Lv_PR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_PRsez"
        Me.Text = "GC AVATAR - Odria Pricelist seznam"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private lvi As ListViewItem
    Private b As Integer


    Private Sub Frm_PRsez_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        napln_lv()
        Tpri = ""
    End Sub

    Private Sub napln_lv()
        Lv_PR.Items.Clear()
        For b = 0 To PRcount - 1
            lvi = Lv_PR.Items.Add(CType(PRrec.Tables("pr").Rows(b)("Nazev"), String))
            If IsDBNull(PRrec.Tables("pr").Rows(b)("Typ")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(PRrec.Tables("pr").Rows(b)("Typ"), String))
            End If
            If IsDBNull(PRrec.Tables("pr").Rows(b)("Podtyp")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(PRrec.Tables("pr").Rows(b)("Podtyp"), String))
            End If
            If IsDBNull(PRrec.Tables("pr").Rows(b)("Cena")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(PRrec.Tables("pr").Rows(b)("Cena"), String))
            End If
        Next
    End Sub


    Private Sub Lv_PR_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Lv_PR.ColumnClick
        Lv_PR.ListViewItemSorter = New SortRoutines.CompareListViewItems(e.Column, Lv_PR)
    End Sub

    Private Sub Lv_PR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv_PR.SelectedIndexChanged
        Tpri = Lv_PR.SelectedItems(0).Text
        Me.Close()
    End Sub
End Class
