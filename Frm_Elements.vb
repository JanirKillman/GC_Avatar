Option Strict Off
Option Explicit On 
Imports System.Data.OleDb
Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing
Friend Class Frm_Elements
	Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try 
					'For the start-up form, the first instance created is the default instance.
					If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
						m_vb6FormDefInstance = Me
					End If
				Catch
				End Try
			End If
		End If
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Cmd_Add As System.Windows.Forms.Button
	Public WithEvents Txt_pop As System.Windows.Forms.TextBox
	Public WithEvents Txt_e As System.Windows.Forms.TextBox
	Public WithEvents Txt_count As System.Windows.Forms.TextBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents Lv_EL As System.Windows.Forms.ListView
    Friend WithEvents clSKN As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSKO As System.Windows.Forms.ColumnHeader
    Public WithEvents Cmd_Print As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Elements))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.Txt_pop = New System.Windows.Forms.TextBox
        Me.Txt_e = New System.Windows.Forms.TextBox
        Me.Txt_count = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Lv_EL = New System.Windows.Forms.ListView
        Me.clSKN = New System.Windows.Forms.ColumnHeader
        Me.clSKO = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.Cyan
        Me.Cmd_Print.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Print.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Print.Location = New System.Drawing.Point(248, 496)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Print.Size = New System.Drawing.Size(136, 24)
        Me.Cmd_Print.TabIndex = 7
        Me.Cmd_Print.Text = "VYTISKNOUT"
        Me.ToolTip1.SetToolTip(Me.Cmd_Print, "Tisk kouzla anebo sestavy")
        Me.Cmd_Print.UseVisualStyleBackColor = False
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.Green
        Me.Cmd_Add.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Add.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Add.Location = New System.Drawing.Point(8, 496)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Add.Size = New System.Drawing.Size(137, 25)
        Me.Cmd_Add.TabIndex = 4
        Me.Cmd_Add.Text = "PŘIDAT"
        Me.Cmd_Add.UseVisualStyleBackColor = False
        '
        'Txt_pop
        '
        Me.Txt_pop.AcceptsReturn = True
        Me.Txt_pop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Txt_pop.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_pop.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_pop.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_pop.Location = New System.Drawing.Point(168, 528)
        Me.Txt_pop.MaxLength = 0
        Me.Txt_pop.Multiline = True
        Me.Txt_pop.Name = "Txt_pop"
        Me.Txt_pop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_pop.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_pop.Size = New System.Drawing.Size(216, 33)
        Me.Txt_pop.TabIndex = 3
        '
        'Txt_e
        '
        Me.Txt_e.AcceptsReturn = True
        Me.Txt_e.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Txt_e.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_e.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_e.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_e.Location = New System.Drawing.Point(8, 528)
        Me.Txt_e.MaxLength = 0
        Me.Txt_e.Name = "Txt_e"
        Me.Txt_e.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_e.Size = New System.Drawing.Size(152, 20)
        Me.Txt_e.TabIndex = 2
        '
        'Txt_count
        '
        Me.Txt_count.AcceptsReturn = True
        Me.Txt_count.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Txt_count.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_count.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_count.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_count.Location = New System.Drawing.Point(176, 472)
        Me.Txt_count.MaxLength = 0
        Me.Txt_count.Name = "Txt_count"
        Me.Txt_count.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_count.Size = New System.Drawing.Size(65, 20)
        Me.Txt_count.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(8, 472)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(161, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Počet záznamů:"
        '
        'Lv_EL
        '
        Me.Lv_EL.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lv_EL.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clSKN, Me.clSKO})
        Me.Lv_EL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lv_EL.ForeColor = System.Drawing.Color.Yellow
        Me.Lv_EL.FullRowSelect = True
        Me.Lv_EL.GridLines = True
        Me.Lv_EL.Location = New System.Drawing.Point(0, 0)
        Me.Lv_EL.Name = "Lv_EL"
        Me.Lv_EL.Size = New System.Drawing.Size(648, 464)
        Me.Lv_EL.TabIndex = 5
        Me.Lv_EL.UseCompatibleStateImageBehavior = False
        Me.Lv_EL.View = System.Windows.Forms.View.Details
        '
        'clSKN
        '
        Me.clSKN.Text = "ELEMENT"
        Me.clSKN.Width = 120
        '
        'clSKO
        '
        Me.clSKO.Text = "POPIS"
        Me.clSKO.Width = 260
        '
        'Frm_Elements
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(392, 566)
        Me.Controls.Add(Me.Cmd_Print)
        Me.Controls.Add(Me.Lv_EL)
        Me.Controls.Add(Me.Cmd_Add)
        Me.Controls.Add(Me.Txt_pop)
        Me.Controls.Add(Me.Txt_e)
        Me.Controls.Add(Me.Txt_count)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Yellow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.Name = "Frm_Elements"
        Me.Opacity = 0.9
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "GC AVATAR - Odria Elements"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As Frm_Elements
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Frm_Elements
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Frm_Elements()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal value As Frm_Elements)
            m_vb6FormDefInstance = value
        End Set
    End Property
#End Region

    Private lvi As ListViewItem
    Private b As Integer

    Private Sub Cmd_Add_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Add.Click
        If Txt_e.Text = "" Then
            MsgBox("Element musí mít označení!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        If Len(Txt_e.Text) > 8 Then
            MsgBox("Element může mít označení na max. 8 znaků!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        If Txt_pop.Text = "" Then
            MsgBox("Element musí být nějak popsán!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        Dim ic As New OleDbCommand
        Dim s1 As String
        s1 = "INSERT INTO Elements (Element, What_it_is) VALUES (@el, @wii)"
        ic.Parameters.AddWithValue("@el", Txt_e)
        ic.Parameters.AddWithValue("@wii", Txt_pop)
        Try
            ic.Connection = Odrialink2
            ic.CommandText = s1
            ic.ExecuteScalar()
        Catch ex As Exception
            MsgBox("Chyba při zápisu do databáze: " + ex.Message, , "CHYBA")
            Exit Sub
        End Try
        ELrec.Clear()
        ELdat.Fill(ELrec, "el")
        ELcount = ELrec.Tables("el").Rows.Count
        Call FillForm()
    End Sub

    Private Sub Frm_Elements_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim eec As New OleDbCommand
        eec.Connection = Odrialink2
        eec.CommandText = "select * from Elements order by Element"
        ELdat.SelectCommand = eec
        ELrec.Clear()
        ELdat.Fill(ELrec, "el")
        ELcount = ELrec.Tables("el").Rows.Count
        ApplyColor()
        Call FillForm()
        EL = True
    End Sub

    Private Sub Frm_Elements_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        EL = False
        ELrec.Clear()
    End Sub

    Sub FillForm()
        Lv_EL.Items.Clear()
        For b = 0 To ELcount - 1
            lvi = Lv_EL.Items.Add(CType(ELrec.Tables("el").Rows(b)("Element"), String))
            lvi.SubItems.Add(CType(ELrec.Tables("el").Rows(b)("What_it_is"), String))
        Next
        Txt_count.Text = ELcount
    End Sub

    Private Sub Cmd_Print_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Print.Click
        Dim ELrint As New ELPrint
        ELrint.Show()
    End Sub

    Private Sub Lv_EL_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles Lv_EL.ColumnClick
        Lv_EL.ListViewItemSorter = New SortRoutines.CompareListViewItems(e.Column, Lv_EL)
    End Sub

    Sub ApplyColor()
        Me.BackColor = Color.FromArgb(FEB)
        Cmd_Add.BackColor = Color.FromArgb(COI)
        Cmd_Print.BackColor = Color.FromArgb(COP)
        Cmd_Add.ForeColor = Color.FromArgb(COFO)
        Cmd_Print.ForeColor = Color.FromArgb(COFO)
        Label1.ForeColor = Color.FromArgb(FEFO)
        Txt_count.ForeColor = Color.FromArgb(FEFO)
        Txt_e.ForeColor = Color.FromArgb(FEFO)
        Txt_pop.ForeColor = Color.FromArgb(FEFO)
        Lv_EL.ForeColor = Color.FromArgb(FEFO)
    End Sub
End Class