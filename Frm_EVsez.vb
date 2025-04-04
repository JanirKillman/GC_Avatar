Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing

Public Class Frm_EVsez
    Inherits System.Windows.Forms.Form
    Private lvi As ListViewItem
    Private b As Integer
    Private po As String
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
    Friend WithEvents Lv_EV As System.Windows.Forms.ListView
    Friend WithEvents EVd As System.Windows.Forms.ColumnHeader
    Friend WithEvents EVt As System.Windows.Forms.ColumnHeader
    Friend WithEvents EVp As System.Windows.Forms.ColumnHeader
    Friend WithEvents EVi As System.Windows.Forms.ColumnHeader
    Friend WithEvents EVk As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_EVsez))
        Me.Lv_EV = New System.Windows.Forms.ListView
        Me.EVd = New System.Windows.Forms.ColumnHeader
        Me.EVt = New System.Windows.Forms.ColumnHeader
        Me.EVp = New System.Windows.Forms.ColumnHeader
        Me.EVi = New System.Windows.Forms.ColumnHeader
        Me.EVk = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Lv_EV
        '
        Me.Lv_EV.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(255, Byte))
        Me.Lv_EV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.EVd, Me.EVt, Me.EVp, Me.EVi, Me.EVk})
        Me.Lv_EV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lv_EV.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Lv_EV.FullRowSelect = True
        Me.Lv_EV.GridLines = True
        Me.Lv_EV.Location = New System.Drawing.Point(0, 0)
        Me.Lv_EV.Name = "Lv_EV"
        Me.Lv_EV.Size = New System.Drawing.Size(840, 312)
        Me.Lv_EV.TabIndex = 0
        Me.Lv_EV.View = System.Windows.Forms.View.Details
        '
        'EVd
        '
        Me.EVd.Text = "DATUM"
        Me.EVd.Width = 150
        '
        'EVt
        '
        Me.EVt.Text = "TITULEK"
        Me.EVt.Width = 250
        '
        'EVp
        '
        Me.EVp.Text = "POPIS"
        Me.EVp.Width = 200
        '
        'EVi
        '
        Me.EVi.Text = "DŮLEŽITOST"
        Me.EVi.Width = 20
        '
        'EVk
        '
        Me.EVk.Text = "KLÍČOVÁ SLOVA"
        Me.EVk.Width = 200
        '
        'Frm_EVsez
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(255, Byte))
        Me.ClientSize = New System.Drawing.Size(840, 310)
        Me.Controls.Add(Me.Lv_EV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_EVsez"
        Me.Text = "GC AVATAR - Odria Events seznam"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Frm_EVsez_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        napln_lv()
        Tday = ""
        Tmonth = ""
        Ttit = ""
        Tyear = ""
        Tepoch = ""
    End Sub

    Private Sub napln_lv()
        Lv_EV.Items.Clear()
        For b = 0 To EVcount - 1
            Dim pom As String
            If IsDBNull(EVrec.Tables("E").Rows(b)("Day_E")) Then
                pom = ""
            Else
                pom = EVrec.Tables("E").Rows(b)("Day_E") & "."
            End If
            If IsDBNull(EVrec.Tables("E").Rows(b)("Month_E")) Then
                pom = ""
            Else
                If pom <> "" Then
                    pom = pom & EVrec.Tables("E").Rows(b)("Month_E") & "."
                Else
                    pom = EVrec.Tables("E").Rows(b)("Month_E") & "."
                End If
            End If
            pom = pom & EVrec.Tables("E").Rows(b)("E_Year")
            Select Case EVrec.Tables("E").Rows(b)("Epoch")
                Case Is = 500
                    pom = pom & " AC"
                Case Is = 490
                    pom = pom & " TC"
                Case Is = 480
                    pom = pom & " XC"
            End Select
            lvi = Lv_EV.Items.Add(pom)
            lvi.SubItems.Add(CType(EVrec.Tables("E").Rows(b)("Event_Title"), String))
            If IsDBNull(EVrec.Tables("E").Rows(b)("Event_Log")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(Mid(EVrec.Tables("E").Rows(b)("Event_Log"), 1, 30), String))
            End If
            If IsDBNull(EVrec.Tables("E").Rows(b)("E_Importance")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(EVrec.Tables("E").Rows(b)("E_Importance"), String))
            End If
            If IsDBNull(EVrec.Tables("E").Rows(b)("E_Keywords")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CType(EVrec.Tables("E").Rows(b)("E_Keywords"), String))
            End If

        Next
    End Sub

    Private Sub Lv_EV_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Lv_EV.ColumnClick
        Lv_EV.ListViewItemSorter = New SortRoutines.CompareListViewItems(e.Column, Lv_EV)
    End Sub

    Private Sub Lv_EV_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lv_EV.SelectedIndexChanged
        po = Lv_EV.SelectedItems(0).Text
        If InStr(po, ".") = 0 Then
            DetEra()
        Else
            If InStr(po, ".") = 2 Then
                Tmonth = Mid(po, 1, 1)
                po = Mid(po, 3, Len(po) - 2)
            Else
                Tmonth = Mid(po, 1, 2)
                po = Mid(po, 4, Len(po) - 3)
            End If
            If InStr(po, ".") <> 0 Then
                Tday = Tmonth
                If InStr(po, ".") = 2 Then
                    Tmonth = Mid(po, 1, 1)
                    po = Mid(po, 3, Len(po) - 2)
                Else
                    Tmonth = Mid(po, 1, 2)
                    po = Mid(po, 4, Len(po) - 3)
                End If
            End If
            DetEra()
        End If
        Ttit = Lv_EV.SelectedItems(0).SubItems(1).Text
        Me.Close()
    End Sub
    Private Sub DetEra()
        If Len(po) > 3 Then
            Tyear = Mid(po, 1, Len(po) - 3)
        Else
            Tyear = ""
        End If
        Select Case Mid(po, Len(po) - 1, 2)
            Case Is = "AC"
                Tepoch = 500
            Case Is = "TC"
                Tepoch = 490
            Case Is = "XC"
                Tepoch = 480
            Case Else
                Tepoch = ""
        End Select
    End Sub

End Class
