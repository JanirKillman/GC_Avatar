Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data.OleDb
Public Class Frm_Chartab
    Inherits System.Windows.Forms.Form
    Public Kilc As New Killman
    Private WithEvents my_sez As Form

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
    Friend WithEvents Lv_CH As System.Windows.Forms.ListView
    Friend WithEvents clITN As System.Windows.Forms.ColumnHeader
    Friend WithEvents clITM As System.Windows.Forms.ColumnHeader
    Friend WithEvents clITZ As System.Windows.Forms.ColumnHeader
    Friend WithEvents clITS As System.Windows.Forms.ColumnHeader
    Friend WithEvents clITD As System.Windows.Forms.ColumnHeader
    Friend WithEvents clITNa As System.Windows.Forms.ColumnHeader
    Friend WithEvents clITT As System.Windows.Forms.ColumnHeader
    Public WithEvents Cmd_New As System.Windows.Forms.Button
    Public WithEvents Cmd_Order As System.Windows.Forms.Button
    Public WithEvents Cmd_Exit As System.Windows.Forms.Button
    Public WithEvents Txt_count As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Chartab))
        Me.Lv_CH = New System.Windows.Forms.ListView
        Me.clITN = New System.Windows.Forms.ColumnHeader
        Me.clITM = New System.Windows.Forms.ColumnHeader
        Me.clITZ = New System.Windows.Forms.ColumnHeader
        Me.clITS = New System.Windows.Forms.ColumnHeader
        Me.clITD = New System.Windows.Forms.ColumnHeader
        Me.clITNa = New System.Windows.Forms.ColumnHeader
        Me.clITT = New System.Windows.Forms.ColumnHeader
        Me.Cmd_New = New System.Windows.Forms.Button
        Me.Cmd_Order = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Txt_count = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Lv_CH
        '
        Me.Lv_CH.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lv_CH.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clITN, Me.clITM, Me.clITZ, Me.clITS, Me.clITD, Me.clITNa, Me.clITT})
        Me.Lv_CH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lv_CH.ForeColor = System.Drawing.Color.Black
        Me.Lv_CH.FullRowSelect = True
        Me.Lv_CH.GridLines = True
        Me.Lv_CH.Location = New System.Drawing.Point(0, 0)
        Me.Lv_CH.Name = "Lv_CH"
        Me.Lv_CH.Size = New System.Drawing.Size(960, 432)
        Me.Lv_CH.TabIndex = 2
        Me.Lv_CH.UseCompatibleStateImageBehavior = False
        Me.Lv_CH.View = System.Windows.Forms.View.Details
        '
        'clITN
        '
        Me.clITN.Text = "JMÉNO"
        Me.clITN.Width = 200
        '
        'clITM
        '
        Me.clITM.Text = "RASA"
        Me.clITM.Width = 90
        '
        'clITZ
        '
        Me.clITZ.Text = "POVOLÁNÍ A LEVEL"
        Me.clITZ.Width = 300
        '
        'clITS
        '
        Me.clITS.Text = "CELKLEVEL"
        Me.clITS.Width = 90
        '
        'clITD
        '
        Me.clITD.Text = "HP"
        Me.clITD.Width = 90
        '
        'clITNa
        '
        Me.clITNa.Text = "MG"
        Me.clITNa.Width = 90
        '
        'clITT
        '
        Me.clITT.Text = "PSP"
        Me.clITT.Width = 90
        '
        'Cmd_New
        '
        Me.Cmd_New.BackColor = System.Drawing.Color.White
        Me.Cmd_New.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_New.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_New.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_New.Location = New System.Drawing.Point(8, 448)
        Me.Cmd_New.Name = "Cmd_New"
        Me.Cmd_New.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_New.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_New.TabIndex = 18
        Me.Cmd_New.Text = "NOVÁ"
        Me.Cmd_New.UseVisualStyleBackColor = False
        '
        'Cmd_Order
        '
        Me.Cmd_Order.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Order.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Order.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Order.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Order.Location = New System.Drawing.Point(128, 448)
        Me.Cmd_Order.Name = "Cmd_Order"
        Me.Cmd_Order.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Order.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Order.TabIndex = 19
        Me.Cmd_Order.Text = "ŘAZENÍ"
        Me.Cmd_Order.UseVisualStyleBackColor = False
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_Exit.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Exit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(632, 440)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Exit.Size = New System.Drawing.Size(320, 57)
        Me.Cmd_Exit.TabIndex = 22
        Me.Cmd_Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_Exit.UseVisualStyleBackColor = False
        '
        'Txt_count
        '
        Me.Txt_count.AcceptsReturn = True
        Me.Txt_count.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_count.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_count.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_count.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Txt_count.Location = New System.Drawing.Point(480, 448)
        Me.Txt_count.MaxLength = 0
        Me.Txt_count.Name = "Txt_count"
        Me.Txt_count.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_count.Size = New System.Drawing.Size(88, 32)
        Me.Txt_count.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(288, 456)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(161, 24)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Počet záznamů:"
        '
        'Frm_Chartab
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(960, 502)
        Me.Controls.Add(Me.Txt_count)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cmd_Exit)
        Me.Controls.Add(Me.Cmd_Order)
        Me.Controls.Add(Me.Cmd_New)
        Me.Controls.Add(Me.Lv_CH)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Chartab"
        Me.Opacity = 0.9
        Me.Text = "GC AVATAR - Odria Characters seznam"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private lvi As ListViewItem
    Private b As Integer


    Private Sub Frm_Chartab_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CHrecopen()
        ApplyColor()
        Call FillForm()
        CH = True
    End Sub

    Private Sub CHrecopen()
        Dim isc As New OleDbCommand
        isc.Connection = Odrialink2
        Select Case CHorder
            Case Is = 1
                If CHdirect = 1 Then
                    isc.CommandText = "select * from Characters order by Name"
                Else
                    isc.CommandText = "select * from Characters order by Name desc"
                End If
            Case Is = 2
                If CHdirect = 1 Then
                    isc.CommandText = "select * from Characters order by Race"
                Else
                    isc.CommandText = "select * from Characters order by Race desc"
                End If
            Case Is = 3
                If CHdirect = 1 Then
                    isc.CommandText = "select * from Characters order by SP"
                Else
                    isc.CommandText = "select * from Characters order by SP desc"
                End If
        End Select
        CHdat.SelectCommand = isc
        CHrec.Clear()
        CHdat.Fill(CHrec, "ch")
        CHcount = CHrec.Tables("ch").Rows.Count
    End Sub

    Sub FillForm()
        Lv_CH.Items.Clear()
        For b = 0 To CHcount - 1
            lvi = Lv_CH.Items.Add(CType(CHrec.Tables("ch").Rows(b)("Name"), String))
            lvi.SubItems.Add(CType(CHrec.Tables("ch").Rows(b)("Race"), String))
            lvi.SubItems.Add(CType(Kilc.CLA(CHrec.Tables("ch").Rows(b)("Classes"), CHrec.Tables("ch").Rows(b)("Levels")), String))
            lvi.SubItems.Add(CType(Kilc.LC(CHrec.Tables("ch").Rows(b)("Levels")), Integer))
            If IsDBNull(CHrec.Tables("ch").Rows(b)("HP")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CInt(CHrec.Tables("ch").Rows(b)("HP")))
            End If
            If IsDBNull(CHrec.Tables("ch").Rows(b)("MG")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CInt(CHrec.Tables("ch").Rows(b)("MG")))
            End If
            If IsDBNull(CHrec.Tables("ch").Rows(b)("PSP")) Then
                lvi.SubItems.Add("")
            Else
                lvi.SubItems.Add(CInt(CHrec.Tables("ch").Rows(b)("PSP")))
            End If
        Next
        Txt_count.Text = CHcount
    End Sub

    Private Sub Cmd_Exit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Frm_Chartab_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        CH = False
    End Sub

    Private Sub Cmd_Order_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Order.Click
        OrderControl = "CH"
        FO = New Frm_Ordering
        FO.ShowDialog()
        FO = Nothing
        CHrec.Clear()
        Call CHrecopen()
        Call FillForm()
    End Sub

    Sub ApplyColor()
        Me.BackColor = Color.FromArgb(FCHB)
        Cmd_New.BackColor = Color.FromArgb(CON)
        Cmd_Order.BackColor = Color.FromArgb(COO)
        Cmd_Exit.BackColor = Color.FromArgb(COE)
        Cmd_New.ForeColor = Color.FromArgb(COFO)
        Cmd_Order.ForeColor = Color.FromArgb(COFO)
        Label1.ForeColor = Color.FromArgb(FCHF)
        Txt_count.ForeColor = Color.FromArgb(FCHF)
        Lv_CH.ForeColor = Color.FromArgb(FCHF)
    End Sub

    Private Sub Lv_CH_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Lv_CH.ColumnClick
        Lv_CH.ListViewItemSorter = New SortRoutines.CompareListViewItems(e.Column, Lv_CH)
    End Sub

    Private Sub Lv_CH_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv_CH.SelectedIndexChanged
        Tcha = Lv_CH.SelectedItems(0).Text
        If my_sez Is Nothing Then
            my_sez = New Frm_Characters
            my_sez.Show()
        Else
            If my_sez.WindowState = FormWindowState.Minimized Or my_sez.WindowState = FormWindowState.Maximized Then
                my_sez.WindowState = FormWindowState.Normal
            Else
                my_sez.Close()
                my_sez = Nothing
            End If
        End If
    End Sub

End Class
