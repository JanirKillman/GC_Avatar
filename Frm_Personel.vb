Option Strict Off
Option Explicit On 
Imports System.Data.OleDb
Friend Class Frm_Personel
    Inherits System.Windows.Forms.Form
    Private WithEvents my_sez As Form
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
	Public WithEvents Txt_pos As System.Windows.Forms.TextBox
	Public WithEvents Txt_id As System.Windows.Forms.TextBox
	Public WithEvents Txt_go As System.Windows.Forms.TextBox
	Public WithEvents Cmd_sa As System.Windows.Forms.Button
	Public WithEvents Lst_art As System.Windows.Forms.ListBox
	Public WithEvents Txt_age As System.Windows.Forms.TextBox
	Public WithEvents Txt_side As System.Windows.Forms.TextBox
	Public WithEvents Txt_sp As System.Windows.Forms.TextBox
	Public WithEvents Txt_hom As System.Windows.Forms.TextBox
	Public WithEvents Txt_stat As System.Windows.Forms.TextBox
	Public WithEvents Txt_rname As System.Windows.Forms.TextBox
	Public WithEvents Txt_name As System.Windows.Forms.TextBox
	Public WithEvents Cmd_First As System.Windows.Forms.Button
	Public WithEvents Cmd_Back As System.Windows.Forms.Button
	Public WithEvents Txt_Num As System.Windows.Forms.TextBox
	Public WithEvents Cmd_Forward As System.Windows.Forms.Button
	Public WithEvents Cmd_Last As System.Windows.Forms.Button
	Public WithEvents Cmd_Order As System.Windows.Forms.Button
	Public WithEvents Cmd_Print As System.Windows.Forms.Button
	Public WithEvents Cmd_New As System.Windows.Forms.Button
	Public WithEvents Cmd_Find As System.Windows.Forms.Button
	Public WithEvents Cmd_Del As System.Windows.Forms.Button
	Public WithEvents Cmd_Ins As System.Windows.Forms.Button
	Public WithEvents Cmd_Exit As System.Windows.Forms.Button
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents Bt_List As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Personel))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Cmd_First = New System.Windows.Forms.Button
        Me.Cmd_Back = New System.Windows.Forms.Button
        Me.Cmd_Forward = New System.Windows.Forms.Button
        Me.Cmd_Last = New System.Windows.Forms.Button
        Me.Cmd_Order = New System.Windows.Forms.Button
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Cmd_New = New System.Windows.Forms.Button
        Me.Cmd_Find = New System.Windows.Forms.Button
        Me.Cmd_Del = New System.Windows.Forms.Button
        Me.Cmd_Ins = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Txt_pos = New System.Windows.Forms.TextBox
        Me.Txt_id = New System.Windows.Forms.TextBox
        Me.Txt_go = New System.Windows.Forms.TextBox
        Me.Cmd_sa = New System.Windows.Forms.Button
        Me.Lst_art = New System.Windows.Forms.ListBox
        Me.Txt_age = New System.Windows.Forms.TextBox
        Me.Txt_side = New System.Windows.Forms.TextBox
        Me.Txt_sp = New System.Windows.Forms.TextBox
        Me.Txt_hom = New System.Windows.Forms.TextBox
        Me.Txt_stat = New System.Windows.Forms.TextBox
        Me.Txt_rname = New System.Windows.Forms.TextBox
        Me.Txt_name = New System.Windows.Forms.TextBox
        Me.Txt_Num = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Bt_List = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Cmd_First
        '
        Me.Cmd_First.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_First.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_First.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_First.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_First.Image = CType(resources.GetObject("Cmd_First.Image"), System.Drawing.Image)
        Me.Cmd_First.Location = New System.Drawing.Point(136, 272)
        Me.Cmd_First.Name = "Cmd_First"
        Me.Cmd_First.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_First.Size = New System.Drawing.Size(41, 33)
        Me.Cmd_First.TabIndex = 11
        Me.Cmd_First.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_First, "Na začátek")
        Me.Cmd_First.UseVisualStyleBackColor = False
        '
        'Cmd_Back
        '
        Me.Cmd_Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Back.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Back.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Back.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Back.Image = CType(resources.GetObject("Cmd_Back.Image"), System.Drawing.Image)
        Me.Cmd_Back.Location = New System.Drawing.Point(176, 272)
        Me.Cmd_Back.Name = "Cmd_Back"
        Me.Cmd_Back.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Back.Size = New System.Drawing.Size(41, 33)
        Me.Cmd_Back.TabIndex = 10
        Me.Cmd_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Back, "O 1 vzad")
        Me.Cmd_Back.UseVisualStyleBackColor = False
        '
        'Cmd_Forward
        '
        Me.Cmd_Forward.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Forward.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Forward.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Forward.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Forward.Image = CType(resources.GetObject("Cmd_Forward.Image"), System.Drawing.Image)
        Me.Cmd_Forward.Location = New System.Drawing.Point(352, 272)
        Me.Cmd_Forward.Name = "Cmd_Forward"
        Me.Cmd_Forward.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Forward.Size = New System.Drawing.Size(41, 33)
        Me.Cmd_Forward.TabIndex = 8
        Me.Cmd_Forward.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Forward, "O 1 vpřed")
        Me.Cmd_Forward.UseVisualStyleBackColor = False
        '
        'Cmd_Last
        '
        Me.Cmd_Last.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Last.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Last.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Last.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Last.Image = CType(resources.GetObject("Cmd_Last.Image"), System.Drawing.Image)
        Me.Cmd_Last.Location = New System.Drawing.Point(392, 272)
        Me.Cmd_Last.Name = "Cmd_Last"
        Me.Cmd_Last.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Last.Size = New System.Drawing.Size(41, 33)
        Me.Cmd_Last.TabIndex = 7
        Me.Cmd_Last.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Last, "Na konec")
        Me.Cmd_Last.UseVisualStyleBackColor = False
        '
        'Cmd_Order
        '
        Me.Cmd_Order.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Order.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Order.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Order.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Order.Location = New System.Drawing.Point(448, 344)
        Me.Cmd_Order.Name = "Cmd_Order"
        Me.Cmd_Order.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Order.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Order.TabIndex = 6
        Me.Cmd_Order.Text = "ŘAZENÍ"
        Me.ToolTip1.SetToolTip(Me.Cmd_Order, "Změnit parametry řazení kouzel")
        Me.Cmd_Order.UseVisualStyleBackColor = False
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.Cyan
        Me.Cmd_Print.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Print.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Print.Location = New System.Drawing.Point(448, 312)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Print.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Print.TabIndex = 5
        Me.Cmd_Print.Text = "TISK"
        Me.ToolTip1.SetToolTip(Me.Cmd_Print, "Tisk kouzla anebo sestavy")
        Me.Cmd_Print.UseVisualStyleBackColor = False
        '
        'Cmd_New
        '
        Me.Cmd_New.BackColor = System.Drawing.Color.White
        Me.Cmd_New.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_New.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_New.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_New.Location = New System.Drawing.Point(448, 280)
        Me.Cmd_New.Name = "Cmd_New"
        Me.Cmd_New.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_New.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_New.TabIndex = 4
        Me.Cmd_New.Text = "NOVÁ"
        Me.ToolTip1.SetToolTip(Me.Cmd_New, "Vymaže pole, příprava na vepsání nového kouzla")
        Me.Cmd_New.UseVisualStyleBackColor = False
        '
        'Cmd_Find
        '
        Me.Cmd_Find.BackColor = System.Drawing.Color.Yellow
        Me.Cmd_Find.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Find.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Find.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Find.Location = New System.Drawing.Point(8, 344)
        Me.Cmd_Find.Name = "Cmd_Find"
        Me.Cmd_Find.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Find.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Find.TabIndex = 3
        Me.Cmd_Find.Text = "NAJÍT"
        Me.ToolTip1.SetToolTip(Me.Cmd_Find, "Najít kouzlo")
        Me.Cmd_Find.UseVisualStyleBackColor = False
        '
        'Cmd_Del
        '
        Me.Cmd_Del.BackColor = System.Drawing.Color.Red
        Me.Cmd_Del.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Del.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Del.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Del.Location = New System.Drawing.Point(8, 312)
        Me.Cmd_Del.Name = "Cmd_Del"
        Me.Cmd_Del.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Del.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Del.TabIndex = 2
        Me.Cmd_Del.Text = "SMAZAT"
        Me.ToolTip1.SetToolTip(Me.Cmd_Del, "Smazat aktuální kouzlo")
        Me.Cmd_Del.UseVisualStyleBackColor = False
        '
        'Cmd_Ins
        '
        Me.Cmd_Ins.BackColor = System.Drawing.Color.Green
        Me.Cmd_Ins.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Ins.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Ins.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Ins.Location = New System.Drawing.Point(8, 280)
        Me.Cmd_Ins.Name = "Cmd_Ins"
        Me.Cmd_Ins.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Ins.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Ins.TabIndex = 1
        Me.Cmd_Ins.Text = "VLOŽIT"
        Me.ToolTip1.SetToolTip(Me.Cmd_Ins, "Vložit nové kouzlo anebo updatnout stávající")
        Me.Cmd_Ins.UseVisualStyleBackColor = False
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_Exit.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Exit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(136, 320)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Exit.Size = New System.Drawing.Size(297, 57)
        Me.Cmd_Exit.TabIndex = 0
        Me.Cmd_Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Exit, "Zavřít toto okno")
        Me.Cmd_Exit.UseVisualStyleBackColor = False
        '
        'Txt_pos
        '
        Me.Txt_pos.AcceptsReturn = True
        Me.Txt_pos.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_pos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_pos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_pos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_pos.Location = New System.Drawing.Point(72, 216)
        Me.Txt_pos.MaxLength = 0
        Me.Txt_pos.Multiline = True
        Me.Txt_pos.Name = "Txt_pos"
        Me.Txt_pos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_pos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_pos.Size = New System.Drawing.Size(313, 41)
        Me.Txt_pos.TabIndex = 34
        '
        'Txt_id
        '
        Me.Txt_id.AcceptsReturn = True
        Me.Txt_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_id.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_id.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_id.Location = New System.Drawing.Point(72, 160)
        Me.Txt_id.MaxLength = 0
        Me.Txt_id.Multiline = True
        Me.Txt_id.Name = "Txt_id"
        Me.Txt_id.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_id.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_id.Size = New System.Drawing.Size(313, 49)
        Me.Txt_id.TabIndex = 32
        '
        'Txt_go
        '
        Me.Txt_go.AcceptsReturn = True
        Me.Txt_go.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_go.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_go.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_go.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_go.Location = New System.Drawing.Point(72, 112)
        Me.Txt_go.MaxLength = 0
        Me.Txt_go.Multiline = True
        Me.Txt_go.Name = "Txt_go"
        Me.Txt_go.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_go.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_go.Size = New System.Drawing.Size(313, 41)
        Me.Txt_go.TabIndex = 30
        '
        'Cmd_sa
        '
        Me.Cmd_sa.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_sa.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_sa.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_sa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_sa.Image = CType(resources.GetObject("Cmd_sa.Image"), System.Drawing.Image)
        Me.Cmd_sa.Location = New System.Drawing.Point(472, 232)
        Me.Cmd_sa.Name = "Cmd_sa"
        Me.Cmd_sa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_sa.Size = New System.Drawing.Size(25, 25)
        Me.Cmd_sa.TabIndex = 28
        Me.Cmd_sa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_sa.UseVisualStyleBackColor = False
        '
        'Lst_art
        '
        Me.Lst_art.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lst_art.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lst_art.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_art.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Lst_art.ItemHeight = 14
        Me.Lst_art.Location = New System.Drawing.Point(400, 112)
        Me.Lst_art.Name = "Lst_art"
        Me.Lst_art.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lst_art.Size = New System.Drawing.Size(161, 102)
        Me.Lst_art.TabIndex = 26
        '
        'Txt_age
        '
        Me.Txt_age.AcceptsReturn = True
        Me.Txt_age.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_age.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_age.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_age.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_age.Location = New System.Drawing.Point(256, 88)
        Me.Txt_age.MaxLength = 0
        Me.Txt_age.Name = "Txt_age"
        Me.Txt_age.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_age.Size = New System.Drawing.Size(129, 19)
        Me.Txt_age.TabIndex = 25
        '
        'Txt_side
        '
        Me.Txt_side.AcceptsReturn = True
        Me.Txt_side.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_side.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_side.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_side.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_side.Location = New System.Drawing.Point(72, 88)
        Me.Txt_side.MaxLength = 0
        Me.Txt_side.Name = "Txt_side"
        Me.Txt_side.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_side.Size = New System.Drawing.Size(113, 19)
        Me.Txt_side.TabIndex = 23
        '
        'Txt_sp
        '
        Me.Txt_sp.AcceptsReturn = True
        Me.Txt_sp.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_sp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_sp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_sp.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_sp.Location = New System.Drawing.Point(432, 64)
        Me.Txt_sp.MaxLength = 0
        Me.Txt_sp.Name = "Txt_sp"
        Me.Txt_sp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_sp.Size = New System.Drawing.Size(129, 19)
        Me.Txt_sp.TabIndex = 21
        '
        'Txt_hom
        '
        Me.Txt_hom.AcceptsReturn = True
        Me.Txt_hom.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_hom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_hom.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_hom.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_hom.Location = New System.Drawing.Point(256, 64)
        Me.Txt_hom.MaxLength = 0
        Me.Txt_hom.Name = "Txt_hom"
        Me.Txt_hom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_hom.Size = New System.Drawing.Size(129, 19)
        Me.Txt_hom.TabIndex = 19
        '
        'Txt_stat
        '
        Me.Txt_stat.AcceptsReturn = True
        Me.Txt_stat.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_stat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_stat.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_stat.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_stat.Location = New System.Drawing.Point(72, 64)
        Me.Txt_stat.MaxLength = 0
        Me.Txt_stat.Name = "Txt_stat"
        Me.Txt_stat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_stat.Size = New System.Drawing.Size(113, 19)
        Me.Txt_stat.TabIndex = 17
        '
        'Txt_rname
        '
        Me.Txt_rname.AcceptsReturn = True
        Me.Txt_rname.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_rname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_rname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_rname.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_rname.Location = New System.Drawing.Point(120, 40)
        Me.Txt_rname.MaxLength = 0
        Me.Txt_rname.Name = "Txt_rname"
        Me.Txt_rname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_rname.Size = New System.Drawing.Size(329, 19)
        Me.Txt_rname.TabIndex = 14
        '
        'Txt_name
        '
        Me.Txt_name.AcceptsReturn = True
        Me.Txt_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_name.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_name.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_name.Location = New System.Drawing.Point(72, 8)
        Me.Txt_name.MaxLength = 0
        Me.Txt_name.Name = "Txt_name"
        Me.Txt_name.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_name.Size = New System.Drawing.Size(377, 19)
        Me.Txt_name.TabIndex = 12
        '
        'Txt_Num
        '
        Me.Txt_Num.AcceptsReturn = True
        Me.Txt_Num.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_Num.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Num.Font = New System.Drawing.Font("Arial", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Num.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Num.Location = New System.Drawing.Point(216, 272)
        Me.Txt_Num.MaxLength = 0
        Me.Txt_Num.Name = "Txt_Num"
        Me.Txt_Num.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Num.Size = New System.Drawing.Size(137, 33)
        Me.Txt_Num.TabIndex = 9
        Me.Txt_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(8, 216)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(57, 17)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Majetek"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(8, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(57, 17)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Identita"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(8, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(41, 17)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Cíle"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(424, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(113, 17)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Vlastní Artefakty"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(192, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(57, 17)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Věk"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(8, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(57, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Starna"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(392, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(33, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Síla"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(192, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Domov"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Status"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Původní jméno"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(64, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Jméno"
        '
        'Bt_List
        '
        Me.Bt_List.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Bt_List.Image = CType(resources.GetObject("Bt_List.Image"), System.Drawing.Image)
        Me.Bt_List.Location = New System.Drawing.Point(456, 8)
        Me.Bt_List.Name = "Bt_List"
        Me.Bt_List.Size = New System.Drawing.Size(104, 48)
        Me.Bt_List.TabIndex = 49
        Me.Bt_List.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Frm_Personel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(569, 385)
        Me.Controls.Add(Me.Bt_List)
        Me.Controls.Add(Me.Txt_pos)
        Me.Controls.Add(Me.Txt_id)
        Me.Controls.Add(Me.Txt_go)
        Me.Controls.Add(Me.Cmd_sa)
        Me.Controls.Add(Me.Lst_art)
        Me.Controls.Add(Me.Txt_age)
        Me.Controls.Add(Me.Txt_side)
        Me.Controls.Add(Me.Txt_sp)
        Me.Controls.Add(Me.Txt_hom)
        Me.Controls.Add(Me.Txt_stat)
        Me.Controls.Add(Me.Txt_rname)
        Me.Controls.Add(Me.Txt_name)
        Me.Controls.Add(Me.Cmd_First)
        Me.Controls.Add(Me.Cmd_Back)
        Me.Controls.Add(Me.Txt_Num)
        Me.Controls.Add(Me.Cmd_Forward)
        Me.Controls.Add(Me.Cmd_Last)
        Me.Controls.Add(Me.Cmd_Order)
        Me.Controls.Add(Me.Cmd_Print)
        Me.Controls.Add(Me.Cmd_New)
        Me.Controls.Add(Me.Cmd_Find)
        Me.Controls.Add(Me.Cmd_Del)
        Me.Controls.Add(Me.Cmd_Ins)
        Me.Controls.Add(Me.Cmd_Exit)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.Name = "Frm_Personel"
        Me.Opacity = 0.9
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "GC AVATAR - Odria Personel"
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As Frm_Personel
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Frm_Personel
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Frm_Personel()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal value As Frm_Personel)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region

    Private Sub Frm_PEsez_Unload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles my_sez.Closed
        If Tper <> "" Then
            PEposition = 0
            Do Until (PErec.Tables("pe").Rows(PEposition)("Name") = Tper)
                PEposition += 1
            Loop
        End If
        FillForm()
        Me.Refresh()
    End Sub

    Private Sub Cmd_Back_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Back.Click
        PEposition -= 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Exit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Cmd_First_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_First.Click
        PEposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Forward_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Forward.Click
        PEposition += 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Last_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Last.Click
        PEposition = PEcount - 1
        Call FillForm()
    End Sub

    Private Sub Cmd_New_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_New.Click
        Txt_name.Text = ""
        Txt_rname.Text = ""
        Txt_stat.Text = ""
        Txt_hom.Text = ""
        Txt_sp.Text = ""
        Txt_side.Text = ""
        Txt_age.Text = ""
        Txt_go.Text = ""
        Txt_id.Text = ""
        Txt_pos.Text = ""
        Lst_art.Items.Clear()
        Cmd_Print.Enabled = False
        Cmd_Del.Enabled = False
        Txt_Num.Text = "NEW"
    End Sub

    Private Sub Cmd_sa_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_sa.Click
        If Lst_art.Text <> "" Then
            If AR Then
                FArtif.Txt_art.Text = Lst_art.Text
                Call ARSearch()
                FArtif.Show()
            Else

                FArtif = New Frm_Artifacts
                FArtif.Show()
                Do
                    System.Windows.Forms.Application.DoEvents()
                Loop Until AR
                FArtif.Txt_art.Text = Lst_art.Text
                Call ARSearch()
                FArtif.Show()
            End If
        End If
    End Sub

    Private Sub Frm_Personel_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Call PErecopen()
        PEposition = 0
        ApplyColor()
        Call FillForm()
        PE = True
    End Sub


    Private Sub PErecopen()
        Dim skc As New OleDbCommand
        skc.Connection = Odrialink2
        Select Case PEorder
            Case Is = 1
                If PEdirect = 1 Then
                    skc.CommandText = "select * from Personel order by Name"
                Else
                    skc.CommandText = "select * from Personel order by Name desc"
                End If
            Case Is = 2
                If PEdirect = 1 Then
                    skc.CommandText = "select * from Personel order by Home_site"
                Else
                    skc.CommandText = "select * from Personel order by Home_site desc"
                End If
            Case Is = 3
                If PEdirect = 1 Then
                    skc.CommandText = "select * from Personel order by Ap_power"
                Else
                    skc.CommandText = "select * from Personel order by Ap_power desc"
                End If
        End Select
        PEdat.SelectCommand = skc
        PErec.Clear()
        PEdat.Fill(PErec, "pe")
        PEcount = PErec.Tables("pe").Rows.Count
    End Sub


    Sub FillForm()
        Txt_name.Text = PErec.Tables("pe").Rows(PEposition)("Name")
        If Not IsDBNull(PErec.Tables("pe").Rows(PEposition)("Real_name")) Then
            Txt_rname.Text = PErec.Tables("pe").Rows(PEposition)("Real_name")
        Else
            Txt_rname.Text = ""
        End If
        If Not IsDBNull(PErec.Tables("pe").Rows(PEposition)("Statusx")) Then
            Txt_stat.Text = PErec.Tables("pe").Rows(PEposition)("Statusx")
        Else
            Txt_stat.Text = ""
        End If
        If Not IsDBNull(PErec.Tables("pe").Rows(PEposition)("Home_site")) Then
            Txt_hom.Text = PErec.Tables("pe").Rows(PEposition)("Home_site")
        Else
            Txt_hom.Text = ""
        End If
        If Not IsDBNull(PErec.Tables("pe").Rows(PEposition)("Ap_power")) Then
            Txt_sp.Text = PErec.Tables("pe").Rows(PEposition)("Ap_power")
        Else
            Txt_sp.Text = ""
        End If
        If Not IsDBNull(PErec.Tables("pe").Rows(PEposition)("Known_alegiance")) Then
            Txt_side.Text = PErec.Tables("pe").Rows(PEposition)("Known_alegiance")
        Else
            Txt_side.Text = ""
        End If
        If Not IsDBNull(PErec.Tables("pe").Rows(PEposition)("Age")) Then
            Txt_age.Text = PErec.Tables("pe").Rows(PEposition)("Age")
        Else
            Txt_age.Text = ""
        End If
        If Not IsDBNull(PErec.Tables("pe").Rows(PEposition)("Goals")) Then
            Txt_go.Text = PErec.Tables("pe").Rows(PEposition)("Goals")
        Else
            Txt_go.Text = ""
        End If
        If Not IsDBNull(PErec.Tables("pe").Rows(PEposition)("Identityx")) Then
            Txt_id.Text = PErec.Tables("pe").Rows(PEposition)("Identityx")
        Else
            Txt_id.Text = ""
        End If
        If Not IsDBNull(PErec.Tables("pe").Rows(PEposition)("Propertyx")) Then
            Txt_pos.Text = PErec.Tables("pe").Rows(PEposition)("Propertyx")
        Else
            Txt_pos.Text = ""
        End If
        Lst_art.Items.Clear()
        Dim sx As New OleDbCommand
        Dim a, ax As Int16
        Try
            sx.Connection = Odrialink2
            sx.CommandText = "select * from Artifacts where Property_of = @oser"
            sx.Parameters.AddWithValue("@oser", Txt_name.Text)
            PEARdat.SelectCommand = sx
            PEAR.Clear()
            PEARdat.Fill(PEAR, "sp")
            ax = PEAR.Tables("sp").Rows.Count
        Catch ex As Exception
            MsgBox("Chyba při čtení z databáze: " + ex.Message, , "CHYBA")
            Exit Sub
        End Try
        a = 0
        If ax > 0 Then
            Do
                Lst_art.Items.Add((PEAR.Tables("sp").Rows(a)("Artifact")))
                a += 1
            Loop Until a = ax
            Cmd_sa.Enabled = True
        Else
            Cmd_sa.Enabled = False
        End If
        Cmd_Del.Enabled = True
        Cmd_Find.Enabled = True
        If PEposition = 0 Then
            Cmd_Back.Enabled = False
        Else
            Cmd_Back.Enabled = True
        End If
        If PEposition + 1 = PEcount Then
            Cmd_Forward.Enabled = False
        Else
            Cmd_Forward.Enabled = True
        End If
        Cmd_Ins.Enabled = True
        Cmd_New.Enabled = True
        Cmd_Print.Enabled = True
        PEAR.Clear()

        Txt_Num.Text = (PEposition + 1) & "/" & PEcount

    End Sub

    Private Sub Frm_Personel_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        PE = False
        PErec.Clear()
    End Sub

    Private Sub Txt_Num_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Num.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            If Not IsNumeric(Txt_Num.Text) Then
                MsgBox("Tady musí být číslo!", MsgBoxStyle.OKOnly, "Chyba")
                GoTo EventExitSub
            End If
            If CShort(Txt_Num.Text) > PEcount Or CShort(Txt_Num.Text) < 1 Then
                MsgBox("Číslo musí být v rozsahu 1 - počet záznamů!", MsgBoxStyle.OKOnly, "Chyba")
                GoTo EventExitSub
            End If
            KeyAscii = 0
            PEposition = CShort(Txt_Num.Text) - 1
            Call FillForm()
        End If
EventExitSub:
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub Cmd_Print_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Print.Click
        Dim PErint As New PEPrint
        PErint.Show()
    End Sub

    Private Sub Cmd_Order_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Order.Click
        OrderControl = "PE"
        FO = New Frm_Ordering
        FO.ShowDialog()
        FO = Nothing
        PErec.Clear()
        Call PErecopen()
        PEposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Ins_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Ins.Click
        If Txt_name.Text = "" Then
            MsgBox("Osoba musí mít jméno!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        Dim tsc As New OleDbCommand
        Dim treader As OleDbDataReader
        Try
            tsc.Connection = Odrialink2
            tsc.CommandText = "select * from Personel where Name = @sk"
            tsc.Parameters.AddWithValue("@sk", Txt_name.Text)
            treader = tsc.ExecuteReader
        Catch ex As Exception
            MsgBox("Chyba při čtení databáze: " + ex.Message, , "CHYBA")
            treader.Close()
            Exit Sub
        End Try
        If Not treader.HasRows Then
            treader.Close()
            Try
                Dim ic As New OleDbCommand
                Dim s1, s2 As String
                s1 = "INSERT INTO Personel (Name"
                s2 = " VALUES (@sk"
                ic.Parameters.AddWithValue("@sk", Txt_name.Text)
                If Txt_rname.Text <> "" Then
                    ic.Parameters.AddWithValue("@po", Trim(Txt_rname.Text))
                    s1 = s1 & ", Real_name"
                    s2 = s2 & ", @po"
                End If
                If Txt_stat.Text <> "" Then
                    ic.Parameters.AddWithValue("@si", Trim(Txt_stat.Text))
                    s1 = s1 & ", Statusx"
                    s2 = s2 & ", @si"
                End If
                If Txt_hom.Text <> "" Then
                    ic.Parameters.AddWithValue("@co", Trim(Txt_hom.Text))
                    s1 = s1 & ", Home_site"
                    s2 = s2 & ", @co"
                End If
                If Txt_sp.Text <> "" Then
                    ic.Parameters.AddWithValue("@ma", Trim(Txt_sp.Text))
                    s1 = s1 & ", Ap_power"
                    s2 = s2 & ", @ma"
                End If
                If Txt_side.Text <> "" Then
                    ic.Parameters.AddWithValue("@pr", Trim(Txt_side.Text))
                    s1 = s1 & ", Known_alegiance"
                    s2 = s2 & ", @pr"
                End If
                If Txt_age.Text <> "" Then
                    ic.Parameters.AddWithValue("@ra", Trim(Txt_age.Text))
                    s1 = s1 & ", Age"
                    s2 = s2 & ", @ra"
                End If
                If Txt_go.Text <> "" Then
                    ic.Parameters.AddWithValue("@dc", Trim(Txt_go.Text))
                    s1 = s1 & ", Goals"
                    s2 = s2 & ", @dc"
                End If
                If Txt_id.Text <> "" Then
                    ic.Parameters.AddWithValue("@na", Trim(Txt_id.Text))
                    s1 = s1 & ", Identityx"
                    s2 = s2 & ", @na"
                End If
                If Txt_pos.Text <> "" Then
                    ic.Parameters.AddWithValue("@xx", Trim(Txt_pos.Text))
                    s1 = s1 & ", Propertyx"
                    s2 = s2 & ", @xx"
                End If
                s1 = s1 & ")"
                s2 = s2 & ")"
                ic.Connection = Odrialink2
                ic.CommandText = s1 + s2
                ic.ExecuteScalar()
            Catch ex As Exception
                MsgBox("Chyba při zápisu do databáze: " + ex.Message, , "CHYBA")
                Exit Sub
            End Try
            PErec.Clear()
            PEdat.Fill(PErec, "pe")
            PEcount = PErec.Tables("pe").Rows.Count
            Call FillForm()
        Else
            treader.Close()
            If MsgBox("Osoba tohoto jména již v databázi existuje, chcete ji přepsat?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Upozornění") = MsgBoxResult.Yes Then
                Try
                    Dim s3 As String
                    Dim uc As New OleDbCommand
                    s3 = "UPDATE Personel set Name = @in, Real_name = @if, Statusx = @kn, Home_site = @si, Ap_power = @co, Known_alegiance = @pr, Age = @ra, Goals = @po, Identityx = @ma, Propertyx = @px WHERE ID = @ID"
                    uc.Parameters.AddWithValue("@in", Txt_name.Text)

                    If Txt_rname.Text = "" Then
                        uc.Parameters.AddWithValue("@if", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@if", Txt_rname.Text)
                    End If
                    If Txt_stat.Text = "" Then
                        uc.Parameters.AddWithValue("@kn", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@kn", Txt_stat.Text)
                    End If
                    If Txt_hom.Text = "" Then
                        uc.Parameters.AddWithValue("@si", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@si", Txt_hom.Text)
                    End If
                    If Txt_sp.Text = "" Then
                        uc.Parameters.AddWithValue("@co", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@co", Txt_sp.Text)
                    End If
                    If Txt_side.Text = "" Then
                        uc.Parameters.AddWithValue("@pr", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@pr", Txt_side.Text)
                    End If
                    If Txt_age.Text = "" Then
                        uc.Parameters.AddWithValue("@ra", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@ra", Txt_age.Text)
                    End If
                    If Txt_go.Text = "" Then
                        uc.Parameters.AddWithValue("@po", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@po", Txt_go.Text)
                    End If
                    If Txt_id.Text = "" Then
                        uc.Parameters.AddWithValue("@ma", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@ma", Txt_id.Text)
                    End If
                    If Txt_pos.Text = "" Then
                        uc.Parameters.AddWithValue("@px", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@px", Txt_pos.Text)
                    End If
                    uc.Parameters.AddWithValue("@ID", PErec.Tables("pe").Rows(PEposition)("ID"))
                    uc.Connection = Odrialink2
                    uc.CommandText = s3
                    uc.ExecuteScalar()
                Catch ex As Exception
                    MsgBox("Chyba updatu případu: " + ex.Message, , "Pokus o update")
                    Exit Sub
                End Try
                PErec.Clear()
                PEdat.Fill(PErec, "pe")
                Call FillForm()
            Else
                Exit Sub
            End If
        End If

    End Sub

    Private Sub Cmd_Find_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Find.Click
        Dim se As New OleDbCommand
        Dim re As OleDbDataReader
        Dim s As String
        Dim q1 As Long
        Dim ski, dif, aat, usa, cos, pre, rap, pop, maa, mab As Boolean
        se.Connection = Odrialink2
        s = "SELECT * from Personel WHERE "

        If Txt_name.Text <> "" Then
            s = s & "Name LIKE @sk"
            se.Parameters.AddWithValue("@sk", "%" & Txt_name.Text & "%")
            ski = True
        End If
        If Txt_rname.Text <> "" Then
            If ski Then
                s = s & " AND "
            End If
            s = s & "Real_name LIKE @di"
            se.Parameters.AddWithValue("@di", "%" & Txt_rname.Text & "%")
            dif = True
        End If
        If Txt_stat.Text <> "" Then
            If ski Or dif Then
                s = s & " AND "
            End If
            s = s & "Statusx LIKE @aa"
            se.Parameters.AddWithValue("@aa", "%" & Txt_stat.Text & "%")
            aat = True
        End If
        If Txt_age.Text <> "" Then
            If ski Or dif Or aat Then
                s = s & " AND "
            End If
            s = s & "Age = @us"
            se.Parameters.AddWithValue("@us", Txt_age.Text)
            usa = True
        End If
        If Txt_go.Text <> "" Then
            If ski Or dif Or aat Or usa Then
                s = s & " AND "
            End If
            s = s & "Goals LIKE @co"
            se.Parameters.AddWithValue("@co", "%" & Txt_go.Text & "%")
            cos = True
        End If
        If Txt_id.Text <> "" Then
            If ski Or dif Or aat Or usa Or cos Then
                s = s & " AND "
            End If
            s = s & "Identityx LIKE @pr"
            se.Parameters.AddWithValue("@pr", "%" & Txt_id.Text & "%")
            pre = True
        End If
        If Txt_hom.Text <> "" Then
            If ski Or dif Or aat Or usa Or cos Or pre Then
                s = s & " AND "
            End If
            s = s & "Home_site LIKE @ra"
            se.Parameters.AddWithValue("@ra", "%" & Txt_hom.Text & "%")
            rap = True
        End If
        If Txt_sp.Text <> "" Then
            If ski Or dif Or aat Or usa Or cos Or pre Or rap Then
                s = s & " AND "
            End If
            s = s & "Ap_power = @po"
            se.Parameters.AddWithValue("@po", Txt_sp.Text)
            pop = True
        End If
        If Txt_side.Text <> "" Then
            If ski Or dif Or aat Or usa Or cos Or pre Or rap Or pop Then
                s = s & " AND "
            End If
            s = s & "Known_alegiance LIKE @ma"
            se.Parameters.AddWithValue("@ma", "%" & Txt_side.Text & "%")
            maa = True
        End If
        If Txt_pos.Text <> "" Then
            If ski Or dif Or aat Or usa Or cos Or pre Or rap Or pop Or maa Then
                s = s & " AND "
            End If
            s = s & "Propertyx LIKE @maq"
            se.Parameters.AddWithValue("@maq", "%" & Txt_pos.Text & "%")
            mab = True
        End If
        PEposition = 0
        If s = "SELECT * from Personel WHERE " Then
            PErecopen()
            FillForm()
            Exit Sub
        End If
        Try
            se.CommandText = s
            re = se.ExecuteReader
            If re.HasRows Then
                q1 = 0
                While re.Read()
                    q1 += 1
                End While
                re.Close()
                PEdat.SelectCommand = se
                PErec.Clear()
                PEdat.Fill(PErec, "pe")
                PEcount = PErec.Tables("pe").Rows.Count
                If GC_list = 1 Then
                    If my_sez Is Nothing Then
                        my_sez = New Frm_PEsez
                        my_sez.Show()
                    Else
                        If my_sez.WindowState = FormWindowState.Minimized Or my_sez.WindowState = FormWindowState.Maximized Then
                            my_sez.WindowState = FormWindowState.Normal
                        Else
                            my_sez.Close()
                            my_sez = Nothing
                        End If
                    End If
                    Exit Sub
                End If
            Else
                re.Close()
                MsgBox("Žádný záznam neodpovídá zvoleným parametrům.", , "Nenalezeno")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Chyba při čtení databáze." + ex.Message, , "Chyba")
            Exit Sub
        End Try
        Call FillForm()
    End Sub

    Private Sub Cmd_Del_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Del.Click
        Dim tsc As New OleDbCommand
        If MsgBox("Opravdu vymazat osobu " & Txt_name.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Upozornění") = MsgBoxResult.Yes Then
            Try
                tsc.Connection = Odrialink2
                tsc.CommandText = "DELETE from Personel WHERE ID = @ID"
                tsc.Parameters.AddWithValue("@ID", PErec.Tables("pe").Rows(PEposition)("ID"))
                tsc.ExecuteScalar()
            Catch ex As Exception
                Throw New Exception("Chyba při výmazu případu: " + ex.Message)
                Exit Sub
            End Try
        Else
            Exit Sub
        End If
        PErec.Clear()
        PEdat.Fill(PErec, "pe")
        PEcount = PErec.Tables("pe").Rows.Count
        If PEposition = PEcount Then
            PEposition -= 1
        End If
        Call FillForm()
    End Sub

    Private Sub Bt_List_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_List.Click
        If my_sez Is Nothing Then
            my_sez = New Frm_PEsez
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

    Sub ApplyColor()
        Me.BackColor = Color.FromArgb(FPEB)
        Cmd_Exit.BackColor = Color.FromArgb(COE)
        Cmd_Ins.BackColor = Color.FromArgb(COI)
        Cmd_Del.BackColor = Color.FromArgb(COD)
        Cmd_Find.BackColor = Color.FromArgb(COF)
        Cmd_New.BackColor = Color.FromArgb(CON)
        Cmd_Print.BackColor = Color.FromArgb(COP)
        Cmd_Order.BackColor = Color.FromArgb(COO)
        Cmd_Ins.ForeColor = Color.FromArgb(COFO)
        Cmd_Del.ForeColor = Color.FromArgb(COFO)
        Cmd_Find.ForeColor = Color.FromArgb(COFO)
        Cmd_New.ForeColor = Color.FromArgb(COFO)
        Cmd_Print.ForeColor = Color.FromArgb(COFO)
        Cmd_Order.ForeColor = Color.FromArgb(COFO)
        Label1.ForeColor = Color.FromArgb(FPEFO)
        Label2.ForeColor = Color.FromArgb(FPEFO)
        Label3.ForeColor = Color.FromArgb(FPEFO)
        Label4.ForeColor = Color.FromArgb(FPEFO)
        Label5.ForeColor = Color.FromArgb(FPEFO)
        Label6.ForeColor = Color.FromArgb(FPEFO)
        Label7.ForeColor = Color.FromArgb(FPEFO)
        Label8.ForeColor = Color.FromArgb(FPEFO)
        Label9.ForeColor = Color.FromArgb(FPEFO)
        Label10.ForeColor = Color.FromArgb(FPEFO)
        Label11.ForeColor = Color.FromArgb(FPEFO)
        Txt_Num.ForeColor = Color.FromArgb(FPEFO)
        Txt_name.ForeColor = Color.FromArgb(FPEFO)
        Txt_rname.ForeColor = Color.FromArgb(FPEFO)
        Txt_stat.ForeColor = Color.FromArgb(FPEFO)
        Txt_age.ForeColor = Color.FromArgb(FPEFO)
        Txt_id.ForeColor = Color.FromArgb(FPEFO)
        Txt_pos.ForeColor = Color.FromArgb(FPEFO)
        Txt_side.ForeColor = Color.FromArgb(FPEFO)
        Txt_sp.ForeColor = Color.FromArgb(FPEFO)
        Txt_hom.ForeColor = Color.FromArgb(FPEFO)
        Txt_go.ForeColor = Color.FromArgb(FPEFO)
        Lst_art.ForeColor = Color.FromArgb(FPEFO)
        Lst_art.BackColor = Color.FromArgb(FPEB)

    End Sub
End Class