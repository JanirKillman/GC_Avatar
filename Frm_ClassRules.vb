Option Strict Off
Option Explicit On 
Imports System.Data.OleDb
Friend Class Frm_ClassRules
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
	Public WithEvents CHck_mane As System.Windows.Forms.CheckBox
	Public WithEvents Txt_pre As System.Windows.Forms.TextBox
	Public WithEvents Txt_max As System.Windows.Forms.TextBox
	Public WithEvents Txt_cost As System.Windows.Forms.TextBox
	Public WithEvents Txt_sign As System.Windows.Forms.TextBox
	Public WithEvents Txt_class As System.Windows.Forms.TextBox
	Public WithEvents Txt_rapp As System.Windows.Forms.TextBox
	Public WithEvents Txt_d As System.Windows.Forms.TextBox
	Public WithEvents Txt_t As System.Windows.Forms.TextBox
	Public WithEvents Txt_p As System.Windows.Forms.TextBox
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
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents Bt_List As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ClassRules))
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
        Me.CHck_mane = New System.Windows.Forms.CheckBox
        Me.Txt_pre = New System.Windows.Forms.TextBox
        Me.Txt_max = New System.Windows.Forms.TextBox
        Me.Txt_cost = New System.Windows.Forms.TextBox
        Me.Txt_sign = New System.Windows.Forms.TextBox
        Me.Txt_class = New System.Windows.Forms.TextBox
        Me.Txt_rapp = New System.Windows.Forms.TextBox
        Me.Txt_d = New System.Windows.Forms.TextBox
        Me.Txt_t = New System.Windows.Forms.TextBox
        Me.Txt_p = New System.Windows.Forms.TextBox
        Me.Txt_Num = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Bt_List = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Cmd_First
        '
        Me.Cmd_First.BackColor = System.Drawing.Color.Green
        Me.Cmd_First.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_First.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_First.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_First.Image = CType(resources.GetObject("Cmd_First.Image"), System.Drawing.Image)
        Me.Cmd_First.Location = New System.Drawing.Point(152, 384)
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
        Me.Cmd_Back.BackColor = System.Drawing.Color.Green
        Me.Cmd_Back.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Back.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Back.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Back.Image = CType(resources.GetObject("Cmd_Back.Image"), System.Drawing.Image)
        Me.Cmd_Back.Location = New System.Drawing.Point(192, 384)
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
        Me.Cmd_Forward.BackColor = System.Drawing.Color.Green
        Me.Cmd_Forward.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Forward.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Forward.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Forward.Image = CType(resources.GetObject("Cmd_Forward.Image"), System.Drawing.Image)
        Me.Cmd_Forward.Location = New System.Drawing.Point(368, 384)
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
        Me.Cmd_Last.BackColor = System.Drawing.Color.Green
        Me.Cmd_Last.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Last.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Last.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Last.Image = CType(resources.GetObject("Cmd_Last.Image"), System.Drawing.Image)
        Me.Cmd_Last.Location = New System.Drawing.Point(408, 384)
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
        Me.Cmd_Order.Location = New System.Drawing.Point(472, 448)
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
        Me.Cmd_Print.Location = New System.Drawing.Point(472, 416)
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
        Me.Cmd_New.Location = New System.Drawing.Point(472, 384)
        Me.Cmd_New.Name = "Cmd_New"
        Me.Cmd_New.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_New.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_New.TabIndex = 4
        Me.Cmd_New.Text = "NOVÉ"
        Me.ToolTip1.SetToolTip(Me.Cmd_New, "Vymaže pole, příprava na vepsání nového kouzla")
        Me.Cmd_New.UseVisualStyleBackColor = False
        '
        'Cmd_Find
        '
        Me.Cmd_Find.BackColor = System.Drawing.Color.Yellow
        Me.Cmd_Find.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Find.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Find.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Find.Location = New System.Drawing.Point(16, 448)
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
        Me.Cmd_Del.Location = New System.Drawing.Point(16, 416)
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
        Me.Cmd_Ins.Location = New System.Drawing.Point(16, 384)
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
        Me.Cmd_Exit.Location = New System.Drawing.Point(152, 424)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Exit.Size = New System.Drawing.Size(297, 57)
        Me.Cmd_Exit.TabIndex = 0
        Me.Cmd_Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Exit, "Zavřít toto okno")
        Me.Cmd_Exit.UseVisualStyleBackColor = False
        '
        'CHck_mane
        '
        Me.CHck_mane.BackColor = System.Drawing.Color.Green
        Me.CHck_mane.Cursor = System.Windows.Forms.Cursors.Default
        Me.CHck_mane.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CHck_mane.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CHck_mane.Location = New System.Drawing.Point(336, 352)
        Me.CHck_mane.Name = "CHck_mane"
        Me.CHck_mane.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CHck_mane.Size = New System.Drawing.Size(105, 17)
        Me.CHck_mane.TabIndex = 30
        Me.CHck_mane.Text = "Menévr"
        Me.CHck_mane.UseVisualStyleBackColor = False
        '
        'Txt_pre
        '
        Me.Txt_pre.AcceptsReturn = True
        Me.Txt_pre.BackColor = System.Drawing.Color.Green
        Me.Txt_pre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_pre.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_pre.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_pre.Location = New System.Drawing.Point(104, 104)
        Me.Txt_pre.MaxLength = 0
        Me.Txt_pre.Name = "Txt_pre"
        Me.Txt_pre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_pre.Size = New System.Drawing.Size(481, 19)
        Me.Txt_pre.TabIndex = 29
        '
        'Txt_max
        '
        Me.Txt_max.AcceptsReturn = True
        Me.Txt_max.BackColor = System.Drawing.Color.Green
        Me.Txt_max.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_max.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_max.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_max.Location = New System.Drawing.Point(88, 80)
        Me.Txt_max.MaxLength = 0
        Me.Txt_max.Name = "Txt_max"
        Me.Txt_max.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_max.Size = New System.Drawing.Size(497, 19)
        Me.Txt_max.TabIndex = 27
        '
        'Txt_cost
        '
        Me.Txt_cost.AcceptsReturn = True
        Me.Txt_cost.BackColor = System.Drawing.Color.Green
        Me.Txt_cost.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_cost.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_cost.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_cost.Location = New System.Drawing.Point(304, 56)
        Me.Txt_cost.MaxLength = 0
        Me.Txt_cost.Name = "Txt_cost"
        Me.Txt_cost.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_cost.Size = New System.Drawing.Size(281, 19)
        Me.Txt_cost.TabIndex = 25
        '
        'Txt_sign
        '
        Me.Txt_sign.AcceptsReturn = True
        Me.Txt_sign.BackColor = System.Drawing.Color.Green
        Me.Txt_sign.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_sign.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_sign.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_sign.Location = New System.Drawing.Point(88, 56)
        Me.Txt_sign.MaxLength = 0
        Me.Txt_sign.Name = "Txt_sign"
        Me.Txt_sign.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_sign.Size = New System.Drawing.Size(161, 19)
        Me.Txt_sign.TabIndex = 23
        '
        'Txt_class
        '
        Me.Txt_class.AcceptsReturn = True
        Me.Txt_class.BackColor = System.Drawing.Color.Green
        Me.Txt_class.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_class.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_class.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_class.Location = New System.Drawing.Point(24, 32)
        Me.Txt_class.MaxLength = 0
        Me.Txt_class.Name = "Txt_class"
        Me.Txt_class.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_class.Size = New System.Drawing.Size(129, 19)
        Me.Txt_class.TabIndex = 20
        '
        'Txt_rapp
        '
        Me.Txt_rapp.AcceptsReturn = True
        Me.Txt_rapp.BackColor = System.Drawing.Color.Green
        Me.Txt_rapp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_rapp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_rapp.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_rapp.Location = New System.Drawing.Point(88, 144)
        Me.Txt_rapp.MaxLength = 0
        Me.Txt_rapp.Multiline = True
        Me.Txt_rapp.Name = "Txt_rapp"
        Me.Txt_rapp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_rapp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_rapp.Size = New System.Drawing.Size(497, 97)
        Me.Txt_rapp.TabIndex = 18
        '
        'Txt_d
        '
        Me.Txt_d.AcceptsReturn = True
        Me.Txt_d.BackColor = System.Drawing.Color.Green
        Me.Txt_d.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_d.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_d.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_d.Location = New System.Drawing.Point(88, 352)
        Me.Txt_d.MaxLength = 0
        Me.Txt_d.Name = "Txt_d"
        Me.Txt_d.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_d.Size = New System.Drawing.Size(121, 19)
        Me.Txt_d.TabIndex = 14
        '
        'Txt_t
        '
        Me.Txt_t.AcceptsReturn = True
        Me.Txt_t.BackColor = System.Drawing.Color.Green
        Me.Txt_t.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_t.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_t.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_t.Location = New System.Drawing.Point(88, 248)
        Me.Txt_t.MaxLength = 0
        Me.Txt_t.Multiline = True
        Me.Txt_t.Name = "Txt_t"
        Me.Txt_t.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_t.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_t.Size = New System.Drawing.Size(497, 97)
        Me.Txt_t.TabIndex = 13
        '
        'Txt_p
        '
        Me.Txt_p.AcceptsReturn = True
        Me.Txt_p.BackColor = System.Drawing.Color.Green
        Me.Txt_p.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_p.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_p.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_p.Location = New System.Drawing.Point(208, 32)
        Me.Txt_p.MaxLength = 0
        Me.Txt_p.Name = "Txt_p"
        Me.Txt_p.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_p.Size = New System.Drawing.Size(361, 19)
        Me.Txt_p.TabIndex = 12
        '
        'Txt_Num
        '
        Me.Txt_Num.AcceptsReturn = True
        Me.Txt_Num.BackColor = System.Drawing.Color.Green
        Me.Txt_Num.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Num.Font = New System.Drawing.Font("Arial", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Num.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Num.Location = New System.Drawing.Point(232, 384)
        Me.Txt_Num.MaxLength = 0
        Me.Txt_Num.Name = "Txt_Num"
        Me.Txt_Num.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Num.Size = New System.Drawing.Size(137, 33)
        Me.Txt_Num.TabIndex = 9
        Me.Txt_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Green
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(8, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(89, 17)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Prerekvisity"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Green
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(8, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(72, 17)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Maximum"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Green
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(256, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(41, 17)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Cena"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Green
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(8, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Označení"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Green
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(56, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Povolání"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Green
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Pravidlově"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Green
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 352)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Ze dne"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Green
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Popis"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Green
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(344, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Skill"
        '
        'Bt_List
        '
        Me.Bt_List.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Bt_List.Image = CType(resources.GetObject("Bt_List.Image"), System.Drawing.Image)
        Me.Bt_List.Location = New System.Drawing.Point(8, 168)
        Me.Bt_List.Name = "Bt_List"
        Me.Bt_List.Size = New System.Drawing.Size(72, 72)
        Me.Bt_List.TabIndex = 62
        Me.Bt_List.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Frm_ClassRules
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(601, 496)
        Me.Controls.Add(Me.Bt_List)
        Me.Controls.Add(Me.CHck_mane)
        Me.Controls.Add(Me.Txt_pre)
        Me.Controls.Add(Me.Txt_max)
        Me.Controls.Add(Me.Txt_cost)
        Me.Controls.Add(Me.Txt_sign)
        Me.Controls.Add(Me.Txt_class)
        Me.Controls.Add(Me.Txt_rapp)
        Me.Controls.Add(Me.Txt_d)
        Me.Controls.Add(Me.Txt_t)
        Me.Controls.Add(Me.Txt_p)
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
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 30)
        Me.MaximizeBox = False
        Me.Name = "Frm_ClassRules"
        Me.Opacity = 0.9
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "GC AVATAR - Odria ClassRules"
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As Frm_ClassRules
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Frm_ClassRules
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Frm_ClassRules()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal value As Frm_ClassRules)
            m_vb6FormDefInstance = value
        End Set
    End Property
#End Region

    Private Sub Frm_CRsez_Unload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles my_sez.Closed
        If Tcr <> "" Then
            CRposition = 0
            Do Until (CRrec.Tables("cr").Rows(CRposition)("ID") = Tcr)
                CRposition += 1
            Loop
        End If
        FillForm()
        Me.Refresh()
    End Sub

    Private Sub Cmd_Back_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Back.Click
        CRposition -= 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Exit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Cmd_First_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_First.Click
        CRposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Forward_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Forward.Click
        CRposition += 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Last_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Last.Click
        CRposition = CRcount - 1
        Call FillForm()
    End Sub

    Private Sub Cmd_New_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_New.Click
        Txt_p.Text = ""
        Txt_t.Text = ""
        Txt_d.Text = ""
        Txt_class.Text = ""
        Txt_sign.Text = ""
        Txt_cost.Text = ""
        Txt_max.Text = ""
        Txt_pre.Text = ""
        Txt_rapp.Text = ""
        CHck_mane.CheckState = System.Windows.Forms.CheckState.Unchecked
        Cmd_Print.Enabled = False
        Cmd_Del.Enabled = False
        Txt_Num.Text = "NEW"
    End Sub

    Private Sub Frm_ClassRules_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Call CRrecopen()
        CRposition = 0
        ApplyColor()
        Call FillForm()
        CR = True
    End Sub


    Private Sub CRrecopen()
        Dim skc As New OleDbCommand
        skc.Connection = Odrialink2
        Select Case CRorder
            Case Is = 1
                If CRdirect = 1 Then
                    skc.CommandText = "select * from Class_skills order by Namex"
                Else
                    skc.CommandText = "select * from Class_skills order by Namex desc"
                End If
            Case Is = 2
                If CRdirect = 2 Then
                    skc.CommandText = "select * from Class_skills order by Classx, Namex"
                Else
                    skc.CommandText = "select * from Class_skills order by Classx, Namex desc"
                End If
            Case Is = 3
                If CRdirect = 3 Then
                    skc.CommandText = "select * from Class_skills order by Date_cre, ID"
                Else
                    skc.CommandText = "select * from Class_skills order by Date_cre, ID desc"
                End If
        End Select
        CRdat.SelectCommand = skc
        CRrec.Clear()
        CRdat.Fill(CRrec, "cr")
        CRcount = CRrec.Tables("cr").Rows.Count
    End Sub


    Private Sub FillForm()


        Txt_p.Text = CRrec.Tables("cr").Rows(CRposition)("Namex")
        If Not IsDBNull(CRrec.Tables("cr").Rows(CRposition)("Popis")) Then
            Txt_t.Text = CRrec.Tables("cr").Rows(CRposition)("Popis")
        Else
            Txt_t.Text = ""
        End If
        Txt_d.Text = CRrec.Tables("cr").Rows(CRposition)("Date_cre")
        If Not IsDBNull(CRrec.Tables("cr").Rows(CRposition)("Classx")) Then
            Txt_class.Text = CRrec.Tables("cr").Rows(CRposition)("Classx")
        Else
            Txt_class.Text = ""
        End If
        If Not IsDBNull(CRrec.Tables("cr").Rows(CRposition)("Signx")) Then
            Txt_sign.Text = CRrec.Tables("cr").Rows(CRposition)("Signx")
        Else
            Txt_sign.Text = ""
        End If
        If Not IsDBNull(CRrec.Tables("cr").Rows(CRposition)("Cost")) Then
            Txt_cost.Text = CRrec.Tables("cr").Rows(CRposition)("Cost")
        Else
            Txt_cost.Text = ""
        End If
        If Not IsDBNull(CRrec.Tables("cr").Rows(CRposition)("Prereq")) Then
            Txt_pre.Text = CRrec.Tables("cr").Rows(CRposition)("Prereq")
        Else
            Txt_pre.Text = ""
        End If
        If Not IsDBNull(CRrec.Tables("cr").Rows(CRposition)("Maxx")) Then
            Txt_max.Text = CRrec.Tables("cr").Rows(CRposition)("Maxx")
        Else
            Txt_max.Text = ""
        End If
        If Not IsDBNull(CRrec.Tables("cr").Rows(CRposition)("Rules_app")) Then
            Txt_rapp.Text = CRrec.Tables("cr").Rows(CRposition)("Rules_app")
        Else
            Txt_rapp.Text = ""
        End If
        If CRrec.Tables("cr").Rows(CRposition)("Maneuver") = True Then
            CHck_mane.CheckState = System.Windows.Forms.CheckState.Checked
        Else
            CHck_mane.CheckState = System.Windows.Forms.CheckState.Unchecked
        End If

        If CRposition = 0 Then
            Cmd_Back.Enabled = False
        Else
            Cmd_Back.Enabled = True
        End If
        Cmd_Del.Enabled = True
        Cmd_Find.Enabled = True
        If CRposition + 1 = CRcount Then
            Cmd_Forward.Enabled = False
        Else
            Cmd_Forward.Enabled = True
        End If
        Cmd_Ins.Enabled = True
        Cmd_New.Enabled = True
        Cmd_Print.Enabled = True


        Txt_Num.Text = (CRposition + 1) & "/" & CRcount

    End Sub


    Private Sub Frm_ClassRules_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        CR = False
        CRrec.Clear()
    End Sub


    Private Sub Txt_Num_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Num.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            If Not IsNumeric(Txt_Num.Text) Then
                MsgBox("Tady musí být číslo!", MsgBoxStyle.OkOnly, "Chyba")
                GoTo EventExitSub
            End If
            If CShort(Txt_Num.Text) > CRcount Or CShort(Txt_Num.Text) < 1 Then
                MsgBox("Číslo musí být v rozsahu 1 - počet záznamů!", MsgBoxStyle.OkOnly, "Chyba")
                GoTo EventExitSub
            End If
            KeyAscii = 0
            CRposition = CShort(Txt_Num.Text) - 1
            Call FillForm()
        End If
EventExitSub:
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub Cmd_Print_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Print.Click
        Dim CRrint As New CRPrint
        CRrint.Show()
    End Sub

    Private Sub Cmd_Order_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Order.Click
        OrderControl = "CR"
        FO = New Frm_Ordering
        FO.ShowDialog()
        FO = Nothing
        CRrec.Clear()
        Call CRrecopen()
        CRposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Ins_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Ins.Click
        If Txt_p.Text = "" Then
            MsgBox("Skill musí mít jméno!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        If Txt_d.Text = "" Then
            If MsgBox("U skillu musí být uvedeno datum vytvoření! Chcete zadat dnešní datum " & Today & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Chyba") = MsgBoxResult.Yes Then
                Txt_d.Text = CStr(Today)
            Else
                Exit Sub
            End If
        End If
        If Txt_class.Text = "" Then
            MsgBox("Skill musí být pro nějaké povolání!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        Txt_p.Text = Txt_p.Text.ToUpper
        Dim tsc As New OleDbCommand
        Dim treader As OleDbDataReader
        Try
            tsc.Connection = Odrialink2
            tsc.CommandText = "select * from Class_skills where Classx = @sk and Namex = @na"
            tsc.Parameters.AddWithValue("@sk", Txt_class.Text)
            tsc.Parameters.AddWithValue("@na", Txt_p.Text)
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
                s1 = "INSERT INTO Class_skills (Classx"
                s2 = " VALUES (@sk"
                ic.Parameters.AddWithValue("@sk", Txt_class.Text)
                ic.Parameters.AddWithValue("@na", Trim(Txt_p.Text))
                s1 = s1 & ", Namex"
                s2 = s2 & ", @na"
                ic.Parameters.AddWithValue("@dc", Trim(Txt_d.Text))
                s1 = s1 & ", Date_cre"
                s2 = s2 & ", @dc"
                If Txt_t.Text <> "" Then
                    ic.Parameters.AddWithValue("@po", Trim(Txt_t.Text))
                    s1 = s1 & ", Popis"
                    s2 = s2 & ", @po"
                End If
                If Txt_sign.Text <> "" Then
                    ic.Parameters.AddWithValue("@si", Trim(Txt_sign.Text))
                    s1 = s1 & ", Signx"
                    s2 = s2 & ", @si"
                End If
                If Txt_cost.Text <> "" Then
                    ic.Parameters.AddWithValue("@co", Trim(Txt_cost.Text))
                    s1 = s1 & ", Cost"
                    s2 = s2 & ", @co"
                End If
                If Txt_max.Text <> "" Then
                    ic.Parameters.AddWithValue("@ma", Trim(Txt_max.Text))
                    s1 = s1 & ", Maxx"
                    s2 = s2 & ", @ma"
                End If
                If Txt_pre.Text <> "" Then
                    ic.Parameters.AddWithValue("@pr", Trim(Txt_pre.Text))
                    s1 = s1 & ", Prereq"
                    s2 = s2 & ", @pr"
                End If
                If Txt_rapp.Text <> "" Then
                    ic.Parameters.AddWithValue("@ra", Trim(Txt_rapp.Text))
                    s1 = s1 & ", Rules_app"
                    s2 = s2 & ", @ra"
                End If
                s1 = s1 & ", Maneuver"
                s2 = s2 & ", @Maneuver"
                If CHck_mane.CheckState = 0 Then
                    ic.Parameters.AddWithValue("@Maneuver", False)
                Else
                    ic.Parameters.AddWithValue("@Maneuver", True)
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
            CRrec.Clear()
            CRdat.Fill(CRrec, "cr")
            CRcount = CRrec.Tables("cr").Rows.Count
            Call FillForm()
        Else
            treader.Close()
            If MsgBox("Skill tohoto jména již v databázi existuje, chcete jej přepsat?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Upozornění") = MsgBoxResult.Yes Then
                Try
                    Dim s3 As String
                    Dim uc As New OleDbCommand
                    s3 = "UPDATE Class_skills set Classx = @aa, Namex = @bb, Date_cre = @cc, Popis = @hh,  Signx = @dd,  Cost = @ee,  Maxx = @ii,  Prereq = @ff, Rules_app = @gg, Maneuver = @jj WHERE ID = @kk"
                    uc.Parameters.AddWithValue("@aa", Txt_class.Text)
                    uc.Parameters.AddWithValue("@bb", Txt_p.Text)
                    uc.Parameters.AddWithValue("@cc", Txt_d.Text)

                    If Txt_t.Text = "" Then
                        uc.Parameters.AddWithValue("@hh", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@hh", Txt_t.Text)
                    End If
                    If Txt_sign.Text = "" Then
                        uc.Parameters.AddWithValue("@dd", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@dd", Txt_sign.Text)
                    End If
                    If Txt_cost.Text = "" Then
                        uc.Parameters.AddWithValue("@ee", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@ee", Txt_cost.Text)
                    End If
                    If Txt_max.Text = "" Then
                        uc.Parameters.AddWithValue("@ii", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@ii", Txt_max.Text)
                    End If
                    If Txt_pre.Text = "" Then
                        uc.Parameters.AddWithValue("@ff", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@ff", Txt_pre.Text)
                    End If
                    If Txt_rapp.Text = "" Then
                        uc.Parameters.AddWithValue("@gg", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@gg", Txt_rapp.Text)
                    End If
                    If CHck_mane.CheckState = 0 Then
                        uc.Parameters.AddWithValue("@jj", False)
                    Else
                        uc.Parameters.AddWithValue("@jj", True)
                    End If
                    uc.Parameters.AddWithValue("@kk", CRrec.Tables("cr").Rows(CRposition)("ID"))
                    uc.Connection = Odrialink2
                    uc.CommandText = s3
                    uc.ExecuteScalar()
                Catch ex As Exception
                    MsgBox("Chyba updatu případu: " + ex.Message, , "Pokus o update")
                    Exit Sub
                End Try
                CRrec.Clear()
                CRdat.Fill(CRrec, "cr")
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
        Dim ski, dif, aat, usa, cos, pre, rap, pop, maa, dac As Boolean
        se.Connection = Odrialink2
        s = "SELECT * from Class_skills WHERE "

        If Txt_class.Text <> "" Then
            s = s & "Classx LIKE @sk"
            se.Parameters.AddWithValue("@sk", "%" & Txt_class.Text & "%")
            ski = True
        End If
        If Txt_p.Text <> "" Then
            If ski Then
                s = s & " AND "
            End If
            s = s & "Namex LIKE @di"
            se.Parameters.AddWithValue("@di", "%" & Txt_p.Text & "%")
            dif = True
        End If
        If Txt_sign.Text <> "" Then
            If ski Or dif Then
                s = s & " AND "
            End If
            s = s & "Signx LIKE @aa"
            se.Parameters.AddWithValue("@aa", "%" & Txt_sign.Text & "%")
            aat = True
        End If
        If CHck_mane.Checked = True Then
            If ski Or dif Or aat Then
                s = s & " AND "
            End If
            s = s & "Maneuver = @us"
            se.Parameters.AddWithValue("@us", True)
            usa = True
        End If
        If Txt_cost.Text <> "" Then
            If ski Or dif Or aat Or usa Then
                s = s & " AND "
            End If
            s = s & "Cost LIKE @co"
            se.Parameters.AddWithValue("@co", "%" & Txt_cost.Text & "%")
            cos = True
        End If
        If Txt_pre.Text <> "" Then
            If ski Or dif Or aat Or usa Or cos Then
                s = s & " AND "
            End If
            s = s & "Prereq LIKE @pr"
            se.Parameters.AddWithValue("@pr", "%" & Txt_pre.Text & "%")
            pre = True
        End If
        If Txt_rapp.Text <> "" Then
            If ski Or dif Or aat Or usa Or cos Or pre Then
                s = s & " AND "
            End If
            s = s & "Rules_app LIKE @ra"
            se.Parameters.AddWithValue("@ra", "%" & Txt_rapp.Text & "%")
            rap = True
        End If
        If Txt_t.Text <> "" Then
            If ski Or dif Or aat Or usa Or cos Or pre Or rap Then
                s = s & " AND "
            End If
            s = s & "Popis LIKE @po"
            se.Parameters.AddWithValue("@po", "%" & Txt_t.Text & "%")
            pop = True
        End If
        If Txt_max.Text <> "" Then
            If ski Or dif Or aat Or usa Or cos Or pre Or rap Or pop Then
                s = s & " AND "
            End If
            s = s & "Maxx LIKE @ma"
            se.Parameters.AddWithValue("@ma", "%" & Txt_max.Text & "%")
            maa = True
        End If
        If Txt_d.Text <> "" Then
            If ski Or dif Or aat Or usa Or cos Or pre Or rap Or pop Or maa Then
                s = s & " AND "
            End If
            s = s & "Date_cre = @dc"
            se.Parameters.AddWithValue("@dc", CDate(Txt_d.Text))
            dac = True
        End If
        CRposition = 0
        If s = "SELECT * from Class_skills WHERE " Then
            CRrecopen()
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
                CRdat.SelectCommand = se
                CRrec.Clear()
                CRdat.Fill(CRrec, "cr")
                CRcount = CRrec.Tables("cr").Rows.Count
                If GC_list = 1 Then
                    If my_sez Is Nothing Then
                        my_sez = New Frm_CRsez
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
        If MsgBox("Opravdu vymazat skill " & Txt_class.Text & " " & Txt_p.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Upozornění") = MsgBoxResult.Yes Then
            Try
                tsc.Connection = Odrialink2
                tsc.CommandText = "DELETE from Class_skills WHERE ID = @ID"
                tsc.Parameters.AddWithValue("@ID", CRrec.Tables("cr").Rows(CRposition)("ID"))
                tsc.ExecuteScalar()
            Catch ex As Exception
                Throw New Exception("Chyba při výmazu případu: " + ex.Message)
                Exit Sub
            End Try
        Else
            Exit Sub
        End If
        CRrec.Clear()
        CRdat.Fill(CRrec, "cr")
        CRcount = CRrec.Tables("cr").Rows.Count
        If CRposition = CRcount Then
            CRposition -= 1
        End If
        Call FillForm()
    End Sub

    Private Sub Bt_List_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_List.Click
        If my_sez Is Nothing Then
            my_sez = New Frm_CRsez
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
        Me.BackColor = Color.FromArgb(FCRB)
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
        Label1.ForeColor = Color.FromArgb(FCRFO)
        Label2.ForeColor = Color.FromArgb(FCRFO)
        Label3.ForeColor = Color.FromArgb(FCRFO)
        Label4.ForeColor = Color.FromArgb(FCRFO)
        Label5.ForeColor = Color.FromArgb(FCRFO)
        Label6.ForeColor = Color.FromArgb(FCRFO)
        Label7.ForeColor = Color.FromArgb(FCRFO)
        Label8.ForeColor = Color.FromArgb(FCRFO)
        Label9.ForeColor = Color.FromArgb(FCRFO)
        Txt_Num.ForeColor = Color.FromArgb(FCRFO)
        Txt_class.ForeColor = Color.FromArgb(FCRFO)
        Txt_p.ForeColor = Color.FromArgb(FCRFO)
        Txt_d.ForeColor = Color.FromArgb(FCRFO)
        Txt_t.ForeColor = Color.FromArgb(FCRFO)
        Txt_cost.ForeColor = Color.FromArgb(FCRFO)
        Txt_sign.ForeColor = Color.FromArgb(FCRFO)
        Txt_rapp.ForeColor = Color.FromArgb(FCRFO)
        Txt_max.ForeColor = Color.FromArgb(FCRFO)
        Txt_pre.ForeColor = Color.FromArgb(FCRFO)
        CHck_mane.ForeColor = Color.FromArgb(FCRFO)

    End Sub
End Class