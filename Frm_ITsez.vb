Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing

Public Class Frm_ITsez
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
    Friend WithEvents Lv_IT As System.Windows.Forms.ListView
    Friend WithEvents clITN As System.Windows.Forms.ColumnHeader
    Friend WithEvents clITM As System.Windows.Forms.ColumnHeader
    Friend WithEvents clITZ As System.Windows.Forms.ColumnHeader
    Friend WithEvents clITS As System.Windows.Forms.ColumnHeader
    Friend WithEvents clITD As System.Windows.Forms.ColumnHeader
    Friend WithEvents clITNa As System.Windows.Forms.ColumnHeader
    Friend WithEvents clITT As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_ITsez))
        Me.Lv_IT = New System.Windows.Forms.ListView
        Me.clITN = New System.Windows.Forms.ColumnHeader
        Me.clITM = New System.Windows.Forms.ColumnHeader
        Me.clITZ = New System.Windows.Forms.ColumnHeader
        Me.clITS = New System.Windows.Forms.ColumnHeader
        Me.clITD = New System.Windows.Forms.ColumnHeader
        Me.clITNa = New System.Windows.Forms.ColumnHeader
        Me.clITT = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Lv_IT
        '
        Me.Lv_IT.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(255, Byte), CType(128, Byte))
        Me.Lv_IT.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clITN, Me.clITM, Me.clITZ, Me.clITS, Me.clITD, Me.clITNa, Me.clITT})
        Me.Lv_IT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lv_IT.ForeColor = System.Drawing.Color.Black
        Me.Lv_IT.FullRowSelect = True
        Me.Lv_IT.GridLines = True
        Me.Lv_IT.Location = New System.Drawing.Point(0, 0)
        Me.Lv_IT.Name = "Lv_IT"
        Me.Lv_IT.Size = New System.Drawing.Size(880, 368)
        Me.Lv_IT.TabIndex = 1
        Me.Lv_IT.View = System.Windows.Forms.View.Details
        '
        'clITN
        '
        Me.clITN.Text = "ITEM"
        Me.clITN.Width = 275
        '
        'clITM
        '
        Me.clITM.Text = "TYP"
        Me.clITM.Width = 90
        '
        'clITZ
        '
        Me.clITZ.Text = "ZAŘAZENÍ"
        Me.clITZ.Width = 80
        '
        'clITS
        '
        Me.clITS.Text = "SÍLY"
        Me.clITS.Width = 180
        '
        'clITD
        '
        Me.clITD.Text = "MG/DEN"
        Me.clITD.Width = 70
        '
        'clITNa
        '
        Me.clITNa.Text = "RARITA"
        Me.clITNa.Width = 80
        '
        'clITT
        '
        Me.clITT.Text = "CENA"
        Me.clITT.Width = 80
        '
        'Frm_ITsez
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(255, Byte), CType(128, Byte))
        Me.ClientSize = New System.Drawing.Size(880, 366)
        Me.Controls.Add(Me.Lv_IT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_ITsez"
        Me.Text = "GC AVATAR - Odria Items seznam"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private lvi As ListViewItem
    Private b As Integer


    Private Sub Frm_ITsez_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        napln_lv()
        Titem = ""
    End Sub

    Private Sub napln_lv()
        Lv_IT.Items.Clear()
        For b = 0 To ITcount - 1
            lvi = Lv_IT.Items.Add(CType(ITrec.Tables("I").Rows(b)("Item_name"), String))
            If IsDBNull(ITrec.Tables("I").Rows(b)("Type")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(ITrec.Tables("I").Rows(b)("Type"), String))
            End If
            If IsDBNull(ITrec.Tables("I").Rows(b)("Alch")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(ITrec.Tables("I").Rows(b)("Alch"), String))
            End If
            If IsDBNull(ITrec.Tables("I").Rows(b)("Special_powers")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(Mid(ITrec.Tables("I").Rows(b)("Special_powers"), 1, 15), String))
            End If
            If IsDBNull(ITrec.Tables("I").Rows(b)("Daily_MG")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(ITrec.Tables("I").Rows(b)("Daily_MG"), String))
            End If
            If IsDBNull(ITrec.Tables("I").Rows(b)("Rarity")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(ITrec.Tables("I").Rows(b)("Rarity"), String))
            End If
            If IsDBNull(ITrec.Tables("I").Rows(b)("App_price")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(ITrec.Tables("I").Rows(b)("App_price"), String))
            End If

        Next
    End Sub


    Private Sub Lv_IT_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Lv_IT.ColumnClick
        Lv_IT.ListViewItemSorter = New SortRoutines.CompareListViewItems(e.Column, Lv_IT)
    End Sub

    Private Sub Lv_IT_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lv_IT.SelectedIndexChanged
        Titem = Lv_IT.SelectedItems(0).Text
        Me.Close()
    End Sub
End Class