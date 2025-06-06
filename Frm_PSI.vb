Option Strict Off
Option Explicit On 
Imports System.Data.OleDb
Friend Class Frm_PSI
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
	Public WithEvents Cmd_Exit As System.Windows.Forms.Button
	Public WithEvents Cmd_Ins As System.Windows.Forms.Button
	Public WithEvents Cmd_Del As System.Windows.Forms.Button
	Public WithEvents Cmd_Find As System.Windows.Forms.Button
	Public WithEvents Cmd_New As System.Windows.Forms.Button
	Public WithEvents Cmd_Print As System.Windows.Forms.Button
	Public WithEvents Cmd_Order As System.Windows.Forms.Button
	Public WithEvents Cmd_Last As System.Windows.Forms.Button
	Public WithEvents Cmd_Forward As System.Windows.Forms.Button
	Public WithEvents Txt_Num As System.Windows.Forms.TextBox
	Public WithEvents Cmd_Back As System.Windows.Forms.Button
	Public WithEvents Cmd_First As System.Windows.Forms.Button
	Public WithEvents Txt_skill As System.Windows.Forms.TextBox
	Public WithEvents Txt_t As System.Windows.Forms.TextBox
	Public WithEvents Txt_d As System.Windows.Forms.TextBox
	Public WithEvents Txt_adv As System.Windows.Forms.TextBox
	Public WithEvents Txt_class As System.Windows.Forms.TextBox
	Public WithEvents Txt_cost As System.Windows.Forms.TextBox
	Public WithEvents Txt_fat As System.Windows.Forms.TextBox
	Public WithEvents Txt_zar As System.Windows.Forms.TextBox
	Public WithEvents Txt_pre As System.Windows.Forms.TextBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents Bt_List As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_PSI))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Cmd_Ins = New System.Windows.Forms.Button
        Me.Cmd_Del = New System.Windows.Forms.Button
        Me.Cmd_Find = New System.Windows.Forms.Button
        Me.Cmd_New = New System.Windows.Forms.Button
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Cmd_Order = New System.Windows.Forms.Button
        Me.Cmd_Last = New System.Windows.Forms.Button
        Me.Cmd_Forward = New System.Windows.Forms.Button
        Me.Cmd_Back = New System.Windows.Forms.Button
        Me.Cmd_First = New System.Windows.Forms.Button
        Me.Txt_Num = New System.Windows.Forms.TextBox
        Me.Txt_skill = New System.Windows.Forms.TextBox
        Me.Txt_t = New System.Windows.Forms.TextBox
        Me.Txt_d = New System.Windows.Forms.TextBox
        Me.Txt_adv = New System.Windows.Forms.TextBox
        Me.Txt_class = New System.Windows.Forms.TextBox
        Me.Txt_cost = New System.Windows.Forms.TextBox
        Me.Txt_fat = New System.Windows.Forms.TextBox
        Me.Txt_zar = New System.Windows.Forms.TextBox
        Me.Txt_pre = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Bt_List = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_Exit.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Exit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(231, 629)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Exit.Size = New System.Drawing.Size(450, 88)
        Me.Cmd_Exit.TabIndex = 20
        Me.Cmd_Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Exit, "Zavřít toto okno")
        Me.Cmd_Exit.UseVisualStyleBackColor = False
        '
        'Cmd_Ins
        '
        Me.Cmd_Ins.BackColor = System.Drawing.Color.Green
        Me.Cmd_Ins.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Ins.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Ins.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Ins.Location = New System.Drawing.Point(32, 582)
        Me.Cmd_Ins.Name = "Cmd_Ins"
        Me.Cmd_Ins.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Ins.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_Ins.TabIndex = 19
        Me.Cmd_Ins.Text = "VLOŽIT"
        Me.ToolTip1.SetToolTip(Me.Cmd_Ins, "Vložit novou Psionickou dovednost anebo updatnout stávající")
        Me.Cmd_Ins.UseVisualStyleBackColor = False
        '
        'Cmd_Del
        '
        Me.Cmd_Del.BackColor = System.Drawing.Color.Red
        Me.Cmd_Del.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Del.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Del.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Del.Location = New System.Drawing.Point(32, 629)
        Me.Cmd_Del.Name = "Cmd_Del"
        Me.Cmd_Del.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Del.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_Del.TabIndex = 18
        Me.Cmd_Del.Text = "SMAZAT"
        Me.ToolTip1.SetToolTip(Me.Cmd_Del, "Smazat aktuální psionickou dovednost")
        Me.Cmd_Del.UseVisualStyleBackColor = False
        '
        'Cmd_Find
        '
        Me.Cmd_Find.BackColor = System.Drawing.Color.Yellow
        Me.Cmd_Find.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Find.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Find.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Find.Location = New System.Drawing.Point(32, 677)
        Me.Cmd_Find.Name = "Cmd_Find"
        Me.Cmd_Find.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Find.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_Find.TabIndex = 17
        Me.Cmd_Find.Text = "NAJÍT"
        Me.ToolTip1.SetToolTip(Me.Cmd_Find, "Najít psionickou dovednost")
        Me.Cmd_Find.UseVisualStyleBackColor = False
        '
        'Cmd_New
        '
        Me.Cmd_New.BackColor = System.Drawing.Color.White
        Me.Cmd_New.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_New.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_New.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_New.Location = New System.Drawing.Point(726, 582)
        Me.Cmd_New.Name = "Cmd_New"
        Me.Cmd_New.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_New.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_New.TabIndex = 16
        Me.Cmd_New.Text = "NOVÁ"
        Me.ToolTip1.SetToolTip(Me.Cmd_New, "Vymaže pole, příprava na vepsání nové psionické dovednosti")
        Me.Cmd_New.UseVisualStyleBackColor = False
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.Cyan
        Me.Cmd_Print.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Print.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Print.Location = New System.Drawing.Point(726, 629)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Print.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_Print.TabIndex = 15
        Me.Cmd_Print.Text = "TISK"
        Me.ToolTip1.SetToolTip(Me.Cmd_Print, "Tisk psionické dovednosti anebo sestavy")
        Me.Cmd_Print.UseVisualStyleBackColor = False
        '
        'Cmd_Order
        '
        Me.Cmd_Order.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Order.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Order.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Order.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Order.Location = New System.Drawing.Point(726, 676)
        Me.Cmd_Order.Name = "Cmd_Order"
        Me.Cmd_Order.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Order.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_Order.TabIndex = 14
        Me.Cmd_Order.Text = "ŘAZENÍ"
        Me.ToolTip1.SetToolTip(Me.Cmd_Order, "Změnit parametry řazení psionických dovedností")
        Me.Cmd_Order.UseVisualStyleBackColor = False
        '
        'Cmd_Last
        '
        Me.Cmd_Last.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_Last.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Last.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Last.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Last.Image = CType(resources.GetObject("Cmd_Last.Image"), System.Drawing.Image)
        Me.Cmd_Last.Location = New System.Drawing.Point(602, 567)
        Me.Cmd_Last.Name = "Cmd_Last"
        Me.Cmd_Last.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Last.Size = New System.Drawing.Size(55, 42)
        Me.Cmd_Last.TabIndex = 13
        Me.Cmd_Last.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Last, "Na konec")
        Me.Cmd_Last.UseVisualStyleBackColor = False
        '
        'Cmd_Forward
        '
        Me.Cmd_Forward.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_Forward.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Forward.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Forward.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Forward.Image = CType(resources.GetObject("Cmd_Forward.Image"), System.Drawing.Image)
        Me.Cmd_Forward.Location = New System.Drawing.Point(550, 567)
        Me.Cmd_Forward.Name = "Cmd_Forward"
        Me.Cmd_Forward.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Forward.Size = New System.Drawing.Size(55, 42)
        Me.Cmd_Forward.TabIndex = 12
        Me.Cmd_Forward.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Forward, "O 1 vpřed")
        Me.Cmd_Forward.UseVisualStyleBackColor = False
        '
        'Cmd_Back
        '
        Me.Cmd_Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_Back.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Back.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Back.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Back.Image = CType(resources.GetObject("Cmd_Back.Image"), System.Drawing.Image)
        Me.Cmd_Back.Location = New System.Drawing.Point(310, 567)
        Me.Cmd_Back.Name = "Cmd_Back"
        Me.Cmd_Back.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Back.Size = New System.Drawing.Size(55, 42)
        Me.Cmd_Back.TabIndex = 10
        Me.Cmd_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Back, "O 1 vzad")
        Me.Cmd_Back.UseVisualStyleBackColor = False
        '
        'Cmd_First
        '
        Me.Cmd_First.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_First.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_First.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_First.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_First.Image = CType(resources.GetObject("Cmd_First.Image"), System.Drawing.Image)
        Me.Cmd_First.Location = New System.Drawing.Point(257, 567)
        Me.Cmd_First.Name = "Cmd_First"
        Me.Cmd_First.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_First.Size = New System.Drawing.Size(55, 42)
        Me.Cmd_First.TabIndex = 9
        Me.Cmd_First.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_First, "Na začátek")
        Me.Cmd_First.UseVisualStyleBackColor = False
        '
        'Txt_Num
        '
        Me.Txt_Num.AcceptsReturn = True
        Me.Txt_Num.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_Num.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Num.Font = New System.Drawing.Font("Arial", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Num.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Num.Location = New System.Drawing.Point(361, 567)
        Me.Txt_Num.MaxLength = 0
        Me.Txt_Num.Name = "Txt_Num"
        Me.Txt_Num.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Num.Size = New System.Drawing.Size(192, 40)
        Me.Txt_Num.TabIndex = 11
        Me.Txt_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_skill
        '
        Me.Txt_skill.AcceptsReturn = True
        Me.Txt_skill.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_skill.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_skill.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_skill.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_skill.Location = New System.Drawing.Point(88, 16)
        Me.Txt_skill.MaxLength = 0
        Me.Txt_skill.Name = "Txt_skill"
        Me.Txt_skill.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_skill.Size = New System.Drawing.Size(798, 29)
        Me.Txt_skill.TabIndex = 8
        '
        'Txt_t
        '
        Me.Txt_t.AcceptsReturn = True
        Me.Txt_t.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_t.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_t.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_t.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_t.Location = New System.Drawing.Point(88, 173)
        Me.Txt_t.MaxLength = 0
        Me.Txt_t.Multiline = True
        Me.Txt_t.Name = "Txt_t"
        Me.Txt_t.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_t.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_t.Size = New System.Drawing.Size(798, 196)
        Me.Txt_t.TabIndex = 7
        '
        'Txt_d
        '
        Me.Txt_d.AcceptsReturn = True
        Me.Txt_d.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_d.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_d.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_d.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_d.Location = New System.Drawing.Point(484, 518)
        Me.Txt_d.MaxLength = 0
        Me.Txt_d.Name = "Txt_d"
        Me.Txt_d.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_d.Size = New System.Drawing.Size(173, 26)
        Me.Txt_d.TabIndex = 6
        '
        'Txt_adv
        '
        Me.Txt_adv.AcceptsReturn = True
        Me.Txt_adv.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_adv.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_adv.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_adv.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_adv.Location = New System.Drawing.Point(88, 387)
        Me.Txt_adv.MaxLength = 0
        Me.Txt_adv.Multiline = True
        Me.Txt_adv.Name = "Txt_adv"
        Me.Txt_adv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_adv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_adv.Size = New System.Drawing.Size(798, 119)
        Me.Txt_adv.TabIndex = 5
        '
        'Txt_class
        '
        Me.Txt_class.AcceptsReturn = True
        Me.Txt_class.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_class.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_class.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_class.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_class.Location = New System.Drawing.Point(88, 56)
        Me.Txt_class.MaxLength = 0
        Me.Txt_class.Name = "Txt_class"
        Me.Txt_class.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_class.Size = New System.Drawing.Size(287, 29)
        Me.Txt_class.TabIndex = 4
        '
        'Txt_cost
        '
        Me.Txt_cost.AcceptsReturn = True
        Me.Txt_cost.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_cost.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_cost.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_cost.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_cost.Location = New System.Drawing.Point(88, 135)
        Me.Txt_cost.MaxLength = 0
        Me.Txt_cost.Name = "Txt_cost"
        Me.Txt_cost.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_cost.Size = New System.Drawing.Size(341, 26)
        Me.Txt_cost.TabIndex = 3
        '
        'Txt_fat
        '
        Me.Txt_fat.AcceptsReturn = True
        Me.Txt_fat.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_fat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_fat.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_fat.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_fat.Location = New System.Drawing.Point(504, 135)
        Me.Txt_fat.MaxLength = 0
        Me.Txt_fat.Name = "Txt_fat"
        Me.Txt_fat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_fat.Size = New System.Drawing.Size(382, 26)
        Me.Txt_fat.TabIndex = 2
        '
        'Txt_zar
        '
        Me.Txt_zar.AcceptsReturn = True
        Me.Txt_zar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_zar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_zar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_zar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_zar.Location = New System.Drawing.Point(148, 518)
        Me.Txt_zar.MaxLength = 0
        Me.Txt_zar.Name = "Txt_zar"
        Me.Txt_zar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_zar.Size = New System.Drawing.Size(183, 26)
        Me.Txt_zar.TabIndex = 1
        '
        'Txt_pre
        '
        Me.Txt_pre.AcceptsReturn = True
        Me.Txt_pre.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_pre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_pre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_pre.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_pre.Location = New System.Drawing.Point(127, 98)
        Me.Txt_pre.MaxLength = 0
        Me.Txt_pre.Name = "Txt_pre"
        Me.Txt_pre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_pre.Size = New System.Drawing.Size(759, 26)
        Me.Txt_pre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(57, 29)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Skill"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(66, 29)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Popis"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(376, 518)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(74, 26)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Ze dne"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(16, 387)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Vývoj"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(16, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Obor"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(16, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Cena"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(435, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(63, 26)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Únava"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(56, 518)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(86, 26)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Zařazení"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(16, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(105, 26)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Prerekvisity"
        '
        'Bt_List
        '
        Me.Bt_List.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Bt_List.Image = CType(resources.GetObject("Bt_List.Image"), System.Drawing.Image)
        Me.Bt_List.Location = New System.Drawing.Point(16, 205)
        Me.Bt_List.Name = "Bt_List"
        Me.Bt_List.Size = New System.Drawing.Size(56, 88)
        Me.Bt_List.TabIndex = 47
        Me.Bt_List.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Frm_PSI
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(924, 749)
        Me.Controls.Add(Me.Bt_List)
        Me.Controls.Add(Me.Cmd_Exit)
        Me.Controls.Add(Me.Cmd_Ins)
        Me.Controls.Add(Me.Cmd_Del)
        Me.Controls.Add(Me.Cmd_Find)
        Me.Controls.Add(Me.Cmd_New)
        Me.Controls.Add(Me.Cmd_Print)
        Me.Controls.Add(Me.Cmd_Order)
        Me.Controls.Add(Me.Cmd_Last)
        Me.Controls.Add(Me.Cmd_Forward)
        Me.Controls.Add(Me.Txt_Num)
        Me.Controls.Add(Me.Cmd_Back)
        Me.Controls.Add(Me.Cmd_First)
        Me.Controls.Add(Me.Txt_skill)
        Me.Controls.Add(Me.Txt_t)
        Me.Controls.Add(Me.Txt_d)
        Me.Controls.Add(Me.Txt_adv)
        Me.Controls.Add(Me.Txt_class)
        Me.Controls.Add(Me.Txt_cost)
        Me.Controls.Add(Me.Txt_fat)
        Me.Controls.Add(Me.Txt_zar)
        Me.Controls.Add(Me.Txt_pre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 30)
        Me.MaximizeBox = False
        Me.Name = "Frm_PSI"
        Me.Opacity = 0.9
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "GC AVATAR - Odria Psionics"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As Frm_PSI
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Frm_PSI
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Frm_PSI()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal value As Frm_PSI)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region

    Private Sub Frm_PSsez_Unload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles my_sez.Closed
        If Tskill <> "" Then
            PSposition = 0
            Do Until PSrec.Tables("P").Rows(PSposition)("PSI_skill") = Tskill
                PSposition += 1
            Loop
            FillForm()
            Me.Refresh()
        End If
    End Sub

    Private Sub Cmd_Back_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Back.Click
        PSposition -= 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Exit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Cmd_First_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_First.Click
        PSposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Forward_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Forward.Click
        PSposition += 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Last_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Last.Click
        PSposition = PScount - 1
        Call FillForm()
    End Sub

    Private Sub Cmd_New_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_New.Click
        Txt_skill.Text = ""
        Txt_t.Text = ""
        Txt_d.Text = ""
        Txt_class.Text = ""
        Txt_fat.Text = ""
        Txt_cost.Text = ""
        Txt_zar.Text = ""
        Txt_pre.Text = ""
        Txt_adv.Text = ""
        Cmd_Print.Enabled = False
        Cmd_Del.Enabled = False
        Txt_Num.Text = "NEW"
    End Sub

    Private Sub Frm_PSI_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Call PSrecopen()
        PSposition = 0
        ApplyColor()
        Call FillForm()
        PS = True
    End Sub


    Private Sub PSrecopen()
        Dim ppc As New OleDbCommand
        ppc.Connection = Odrialink2
        Select Case PSorder
            Case Is = 1
                If PSdirect = 1 Then
                    ppc.CommandText = "select * from Psionics order by PSI_skill"
                Else
                    ppc.CommandText = "select * from Psionics order by PSI_skill desc"
                End If
            Case Is = 2
                If PSdirect = 1 Then
                    ppc.CommandText = "select * from Psionics order by PSI_branch"
                Else
                    ppc.CommandText = "select * from Psionics order by PSI_branch desc"
                End If
            Case Is = 3
                If PSdirect = 1 Then
                    ppc.CommandText = "select * from Psionics order by PSI_datecre, ID"
                Else
                    ppc.CommandText = "select * from Psionics order by PSI_datecre, ID desc"
                End If
        End Select
        PSdat.SelectCommand = ppc
        PSrec.Clear()
        PSdat.Fill(PSrec, "P")
        PScount = PSrec.Tables("P").Rows.Count
    End Sub


    Private Sub FillForm()


        Txt_skill.Text = PSrec.Tables("P").Rows(PSposition)("PSI_skill")
        If Not IsDBNull(PSrec.Tables("P").Rows(PSposition)("PSI_popis")) Then
            Txt_t.Text = PSrec.Tables("P").Rows(PSposition)("PSI_popis")
        Else
            Txt_t.Text = ""
        End If
        Txt_d.Text = PSrec.Tables("P").Rows(PSposition)("PSI_datecre")
        If Not IsDBNull(PSrec.Tables("P").Rows(PSposition)("PSI_branch")) Then
            Txt_class.Text = PSrec.Tables("P").Rows(PSposition)("PSI_branch")
        Else
            Txt_class.Text = ""
        End If
        If Not IsDBNull(PSrec.Tables("P").Rows(PSposition)("PSI_cost")) Then
            Txt_cost.Text = PSrec.Tables("P").Rows(PSposition)("PSI_cost")
        Else
            Txt_cost.Text = ""
        End If
        If Not IsDBNull(PSrec.Tables("P").Rows(PSposition)("PSI_fatigue")) Then
            Txt_fat.Text = PSrec.Tables("P").Rows(PSposition)("PSI_fatigue")
        Else
            Txt_fat.Text = ""
        End If
        If Not IsDBNull(PSrec.Tables("P").Rows(PSposition)("PSI_prereq")) Then
            Txt_pre.Text = PSrec.Tables("P").Rows(PSposition)("PSI_prereq")
        Else
            Txt_pre.Text = ""
        End If
        If Not IsDBNull(PSrec.Tables("P").Rows(PSposition)("PSI_progress")) Then
            Txt_adv.Text = PSrec.Tables("P").Rows(PSposition)("PSI_progress")
        Else
            Txt_adv.Text = ""
        End If
        If Not IsDBNull(PSrec.Tables("P").Rows(PSposition)("PSI_level")) Then
            Txt_zar.Text = PSrec.Tables("P").Rows(PSposition)("PSI_level")
        Else
            Txt_zar.Text = ""
        End If

        If PSposition = 0 Then
            Cmd_Back.Enabled = False
        Else
            Cmd_Back.Enabled = True
        End If
        Cmd_Del.Enabled = True
        Cmd_Find.Enabled = True
        If PSposition + 1 = PScount Then
            Cmd_Forward.Enabled = False
        Else
            Cmd_Forward.Enabled = True
        End If
        Cmd_Ins.Enabled = True
        Cmd_New.Enabled = True
        Cmd_Print.Enabled = True


        Txt_Num.Text = (PSposition + 1) & "/" & PScount

    End Sub


    Private Sub Frm_PSI_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        PS = False
        PSrec.Clear()
    End Sub

    Private Sub Txt_Num_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Num.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            If Not IsNumeric(Txt_Num.Text) Then
                MsgBox("Tady musí být číslo!", MsgBoxStyle.OKOnly, "Chyba")
                GoTo EventExitSub
            End If
            If CShort(Txt_Num.Text) > PScount Or CShort(Txt_Num.Text) < 1 Then
                MsgBox("Číslo musí být v rozsahu 1 - počet záznamů!", MsgBoxStyle.OKOnly, "Chyba")
                GoTo EventExitSub
            End If
            KeyAscii = 0
            PSposition = CShort(Txt_Num.Text) - 1
            Call FillForm()
        End If
EventExitSub:
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub Cmd_Print_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Print.Click
        Dim PSrint As New PSprint
        PSrint.Show()
    End Sub

    Private Sub Cmd_Order_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Order.Click
        OrderControl = "PS"
        FO = New Frm_Ordering
        FO.ShowDialog()
        FO = Nothing
        PSrec.Clear()
        Call PSrecopen()
        PSposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Ins_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Ins.Click
        If Txt_skill.Text = "" Then
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
            MsgBox("Skill musí patřit do nějakého oboru!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        Txt_skill.Text = Txt_skill.Text.ToUpper
        Txt_class.Text = Txt_class.Text.ToUpper

        Dim tsc As New OleDbCommand
        Dim treader As OleDbDataReader
        Try
            tsc.Connection = Odrialink2
            tsc.CommandText = "select * from Psionics where PSI_skill =  @sk"
            tsc.Parameters.AddWithValue("@sk", Txt_skill.Text)
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
                s1 = "INSERT INTO Psionics (PSI_skill, PSI_datecre, PSI_branch"
                s2 = " VALUES (@ps, @dc, @pb"
                ic.Parameters.AddWithValue("@ps", Trim(Txt_skill.Text))
                ic.Parameters.AddWithValue("@dc", Trim(Txt_d.Text))
                ic.Parameters.AddWithValue("@pb", Trim(Txt_class.Text))
                If Txt_t.Text <> "" Then
                    ic.Parameters.AddWithValue("@pp", Txt_t.Text)
                    s1 = s1 & ", PSI_popis"
                    s2 = s2 & ", @pp"
                End If
                If Txt_fat.Text <> "" Then
                    ic.Parameters.AddWithValue("@pf", Txt_fat.Text)
                    s1 = s1 & ", PSI_fatigue"
                    s2 = s2 & ", @pf"
                End If
                If Txt_cost.Text <> "" Then
                    ic.Parameters.AddWithValue("@pc", Txt_cost.Text)
                    s1 = s1 & ", PSI_cost"
                    s2 = s2 & ", @pc"
                End If
                If Txt_zar.Text <> "" Then
                    ic.Parameters.AddWithValue("@pl", Txt_zar.Text)
                    s1 = s1 & ", PSI_level"
                    s2 = s2 & ", @pl"
                End If
                If Txt_pre.Text <> "" Then
                    ic.Parameters.AddWithValue("@pq", Txt_pre.Text)
                    s1 = s1 & ", PSI_prereq"
                    s2 = s2 & ", @pq"
                End If
                If Txt_adv.Text <> "" Then
                    ic.Parameters.AddWithValue("@pg", Txt_adv.Text)
                    s1 = s1 & ", PSI_progress"
                    s2 = s2 & ", @pg"
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
            PSrec.Clear()
            PSdat.Fill(PSrec, "P")
            PScount = PSrec.Tables("P").Rows.Count
            Call FillForm()
        Else
            treader.Close()
            If MsgBox("Skill tohoto jména již v databázi existuje, chcete jej přepsat?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Upozornění") = MsgBoxResult.Yes Then
                Try
                    Dim s3 As String
                    Dim uc As New OleDbCommand
                    s3 = "UPDATE Psionics set PSI_skill = @ps, PSI_popis = @pp, PSI_datecre = @dc, PSI_branch = @pb, PSI_fatigue = @pf, PSI_cost = @pc, PSI_level = @pl, PSI_prereq = @pq, PSI_progress = @pg WHERE ID = @ID"
                    uc.Parameters.AddWithValue("@ps", Trim(Txt_skill.Text))
                    If Txt_t.Text = "" Then
                        uc.Parameters.AddWithValue("@pp", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@pp", Trim(Txt_t.Text))
                    End If
                    uc.Parameters.AddWithValue("@dc", Trim(Txt_d.Text))
                    uc.Parameters.AddWithValue("@pb", Trim(Txt_class.Text))
                    If Txt_fat.Text = "" Then
                        uc.Parameters.AddWithValue("@pf", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@pf", Trim(Txt_fat.Text))
                    End If
                    If Txt_cost.Text = "" Then
                        uc.Parameters.AddWithValue("@pc", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@pc", Trim(Txt_cost.Text))
                    End If
                    If Txt_zar.Text = "" Then
                        uc.Parameters.AddWithValue("@pl", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@pl", Trim(Txt_zar.Text))
                    End If
                    If Txt_pre.Text = "" Then
                        uc.Parameters.AddWithValue("@pq", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@pq", Trim(Txt_pre.Text))
                    End If
                    If Txt_adv.Text = "" Then
                        uc.Parameters.AddWithValue("@pg", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@pg", Trim(Txt_adv.Text))
                    End If
                    uc.Parameters.AddWithValue("@ID", PSrec.Tables("P").Rows(PSposition)("ID"))
                    uc.Connection = Odrialink2
                    uc.CommandText = s3
                    uc.ExecuteScalar()
                Catch ex As Exception
                    MsgBox("Chyba updatu případu: " + ex.Message, , "Pokus o update")
                    Exit Sub
                End Try
                PSrec.Clear()
                PSdat.Fill(PSrec, "P")
                Call FillForm()
            Else
                Exit Sub
            End If
        End If

    End Sub

    Private Sub Cmd_Find_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Find.Click
        Dim PSse As New OleDbCommand
        Dim PSre As OleDbDataReader
        Dim s As String
        Dim q1 As Long
        Dim sk, br, pq, co, fa, po, ad, le, dc As Boolean
        PSse.Connection = Odrialink2
        Txt_skill.Text = Txt_skill.Text.ToUpper()
        s = "SELECT * from Psionics WHERE "
        If Txt_skill.Text <> "" Then
            s = s & "PSI_skill LIKE @ps"
            PSse.Parameters.AddWithValue("@ps", "%" & Trim(Txt_skill.Text) & "%")
            sk = True
        End If
        If Txt_class.Text <> "" Then
            If sk Then
                s = s & " AND "
            End If
            s = s & "PSI_branch = @cl"
            PSse.Parameters.AddWithValue("@cl", Trim(Txt_class.Text))
            br = True
        End If
        If Txt_pre.Text <> "" Then
            If sk Or br Then
                s = s & " AND "
            End If
            s = s & "PSI_prereq LIKE @pr"
            PSse.Parameters.AddWithValue("@pr", "%" & Trim(Txt_pre.Text) & "%")
            pq = True
        End If
        If Txt_cost.Text <> "" Then
            If sk Or br Or pq Then
                s = s & " AND "
            End If
            s = s & "PSI_cost LIKE @cs"
            PSse.Parameters.AddWithValue("@cs", "%" & Trim(Txt_cost.Text) & "%")
            co = True
        End If
        If Txt_fat.Text <> "" Then
            If sk Or br Or pq Or co Then
                s = s & " AND "
            End If
            s = s & "PSI_fatigue LIKE @ft"
            PSse.Parameters.AddWithValue("@ft", "%" & Trim(Txt_fat.Text) & "%")
            fa = True
        End If
        If Txt_t.Text <> "" Then
            If sk Or br Or pq Or co Or fa Then
                s = s & " AND "
            End If
            s = s & "PSI_popis LIKE @pp"
            PSse.Parameters.AddWithValue("@pp", "%" & Trim(Txt_t.Text) & "%")
            po = True
        End If
        If Txt_adv.Text <> "" Then
            If sk Or br Or pq Or co Or fa Or po Then
                s = s & " AND "
            End If
            s = s & "PSI_progress LIKE @av"
            PSse.Parameters.AddWithValue("@av", "%" & Trim(Txt_adv.Text) & "%")
            ad = True
        End If
        If Txt_zar.Text <> "" Then
            If sk Or br Or pq Or co Or fa Or po Or ad Then
                s = s & " AND "
            End If
            s = s & "PSI_level LIKE @lv"
            PSse.Parameters.AddWithValue("@lv", "%" & Trim(Txt_zar.Text) & "%")
            le = True
        End If
        If Txt_d.Text <> "" Then
            If sk Or br Or pq Or co Or fa Or po Or ad Or le Then
                s = s & " AND "
            End If
            s = s & "PSI_datecre = @da"
            PSse.Parameters.AddWithValue("@da", CDate(Txt_d.Text))
            dc = True
        End If
        PSposition = 0
        If s = "SELECT * from Psionics WHERE " Then
            PSrecopen()
            FillForm()
            Exit Sub
        End If
        Try
            PSse.CommandText = s
            PSre = PSse.ExecuteReader
            If PSre.HasRows Then
                q1 = 0
                While PSre.Read()
                    q1 += 1
                End While
                PSre.Close()
                If q1 = 1 Then
                    Do
                        If Txt_skill.Text = PSrec.Tables("P").Rows(PSposition)("PSI_skill") Then
                            Exit Do
                        End If
                        PSposition += 1
                    Loop Until PSposition + 1 = PScount
                Else
                    PSdat.SelectCommand = PSse
                    PSrec.Clear()
                    PSdat.Fill(PSrec, "P")
                    PScount = PSrec.Tables("P").Rows.Count
                    If GC_list = 1 Then
                        If my_sez Is Nothing Then
                            my_sez = New Frm_PSsez
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
                End If
            Else
                PSre.Close()
                MsgBox("Žádný záznam neodpovídá zvoleným parametrům.", , "Nenalezeno")
                Exit Sub
            End If
            PSre.Close()
        Catch ex As Exception
            MsgBox("Chyba při čtení databáze." + ex.Message, , "Chyba")
            Exit Sub
        End Try
        Call FillForm()
    End Sub

    Private Sub Cmd_Del_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Del.Click
        Dim tsc As New OleDbCommand
        If MsgBox("Opravdu vymazat skill " & Txt_skill.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Upozornění") = MsgBoxResult.Yes Then
            Try
                tsc.Connection = Odrialink2
                tsc.CommandText = "DELETE from Psionics WHERE ID = @ID"
                tsc.Parameters.AddWithValue("@ID", PSrec.Tables("P").Rows(SPposition)("ID"))
                tsc.ExecuteScalar()
            Catch ex As Exception
                Throw New Exception("Chyba při výmazu případu: " + ex.Message)
                Exit Sub
            End Try
        Else
            Exit Sub
        End If
        PSrec.Clear()
        PSdat.Fill(PSrec, "P")
        PScount = PSrec.Tables("P").Rows.Count
        If PSposition = PScount Then
            PSposition -= 1
        End If
        Call FillForm()
    End Sub

    Private Sub Bt_List_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_List.Click
        If my_sez Is Nothing Then
            my_sez = New Frm_PSsez
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
        Me.BackColor = Color.FromArgb(FPSB)
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
        Label1.ForeColor = Color.FromArgb(FPSFO)
        Label2.ForeColor = Color.FromArgb(FPSFO)
        Label3.ForeColor = Color.FromArgb(FPSFO)
        Label4.ForeColor = Color.FromArgb(FPSFO)
        Label5.ForeColor = Color.FromArgb(FPSFO)
        Label6.ForeColor = Color.FromArgb(FPSFO)
        Label7.ForeColor = Color.FromArgb(FPSFO)
        Label8.ForeColor = Color.FromArgb(FPSFO)
        Label9.ForeColor = Color.FromArgb(FPSFO)
        Txt_Num.ForeColor = Color.FromArgb(FPSFO)
        Txt_skill.ForeColor = Color.FromArgb(FPSFO)
        Txt_t.ForeColor = Color.FromArgb(FPSFO)
        Txt_class.ForeColor = Color.FromArgb(FPSFO)
        Txt_d.ForeColor = Color.FromArgb(FPSFO)
        Txt_adv.ForeColor = Color.FromArgb(FPSFO)
        Txt_cost.ForeColor = Color.FromArgb(FPSFO)
        Txt_fat.ForeColor = Color.FromArgb(FPSFO)
        Txt_pre.ForeColor = Color.FromArgb(FPSFO)
        Txt_zar.ForeColor = Color.FromArgb(FPSFO)
    End Sub

End Class