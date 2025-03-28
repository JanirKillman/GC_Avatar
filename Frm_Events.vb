Option Strict Off
Option Explicit On 
Imports System.Data.OleDb
Friend Class Frm_Events
    Inherits System.Windows.Forms.Form
    Private WithEvents my_sez As Form
    Dim qq, dd, mm As String
    Dim yy, ee As String
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
	Public WithEvents Txt_rem As System.Windows.Forms.TextBox
	Public WithEvents Txt_kw As System.Windows.Forms.TextBox
	Public WithEvents Txt_imp As System.Windows.Forms.TextBox
	Public WithEvents Txt_pop As System.Windows.Forms.TextBox
	Public WithEvents Txt_tit As System.Windows.Forms.TextBox
	Public WithEvents Txt_dat As System.Windows.Forms.TextBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Events))
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
        Me.Txt_rem = New System.Windows.Forms.TextBox
        Me.Txt_kw = New System.Windows.Forms.TextBox
        Me.Txt_imp = New System.Windows.Forms.TextBox
        Me.Txt_pop = New System.Windows.Forms.TextBox
        Me.Txt_tit = New System.Windows.Forms.TextBox
        Me.Txt_dat = New System.Windows.Forms.TextBox
        Me.Txt_Num = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
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
        Me.Cmd_Exit.Location = New System.Drawing.Point(24, 552)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Exit.Size = New System.Drawing.Size(297, 57)
        Me.Cmd_Exit.TabIndex = 11
        Me.Cmd_Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Exit, "Zavřít toto okno")
        Me.Cmd_Exit.UseVisualStyleBackColor = False
        '
        'Cmd_Ins
        '
        Me.Cmd_Ins.BackColor = System.Drawing.Color.Green
        Me.Cmd_Ins.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Ins.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Ins.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Ins.Location = New System.Drawing.Point(24, 440)
        Me.Cmd_Ins.Name = "Cmd_Ins"
        Me.Cmd_Ins.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Ins.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Ins.TabIndex = 10
        Me.Cmd_Ins.Text = "VLOŽIT"
        Me.ToolTip1.SetToolTip(Me.Cmd_Ins, "Vložit nové kouzlo anebo updatnout stávající")
        Me.Cmd_Ins.UseVisualStyleBackColor = False
        '
        'Cmd_Del
        '
        Me.Cmd_Del.BackColor = System.Drawing.Color.Red
        Me.Cmd_Del.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Del.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Del.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Del.Location = New System.Drawing.Point(24, 472)
        Me.Cmd_Del.Name = "Cmd_Del"
        Me.Cmd_Del.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Del.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Del.TabIndex = 9
        Me.Cmd_Del.Text = "SMAZAT"
        Me.ToolTip1.SetToolTip(Me.Cmd_Del, "Smazat aktuální kouzlo")
        Me.Cmd_Del.UseVisualStyleBackColor = False
        '
        'Cmd_Find
        '
        Me.Cmd_Find.BackColor = System.Drawing.Color.Yellow
        Me.Cmd_Find.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Find.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Find.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Find.Location = New System.Drawing.Point(24, 504)
        Me.Cmd_Find.Name = "Cmd_Find"
        Me.Cmd_Find.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Find.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Find.TabIndex = 8
        Me.Cmd_Find.Text = "NAJÍT"
        Me.ToolTip1.SetToolTip(Me.Cmd_Find, "Najít kouzlo")
        Me.Cmd_Find.UseVisualStyleBackColor = False
        '
        'Cmd_New
        '
        Me.Cmd_New.BackColor = System.Drawing.Color.White
        Me.Cmd_New.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_New.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_New.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_New.Location = New System.Drawing.Point(208, 440)
        Me.Cmd_New.Name = "Cmd_New"
        Me.Cmd_New.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_New.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_New.TabIndex = 7
        Me.Cmd_New.Text = "NOVÁ"
        Me.ToolTip1.SetToolTip(Me.Cmd_New, "Vymaže pole, příprava na vepsání nového kouzla")
        Me.Cmd_New.UseVisualStyleBackColor = False
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.Cyan
        Me.Cmd_Print.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Print.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Print.Location = New System.Drawing.Point(208, 472)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Print.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Print.TabIndex = 6
        Me.Cmd_Print.Text = "TISK"
        Me.ToolTip1.SetToolTip(Me.Cmd_Print, "Tisk kouzla anebo sestavy")
        Me.Cmd_Print.UseVisualStyleBackColor = False
        '
        'Cmd_Order
        '
        Me.Cmd_Order.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Order.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Order.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Order.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Order.Location = New System.Drawing.Point(208, 504)
        Me.Cmd_Order.Name = "Cmd_Order"
        Me.Cmd_Order.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Order.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Order.TabIndex = 5
        Me.Cmd_Order.Text = "ŘAZENÍ"
        Me.ToolTip1.SetToolTip(Me.Cmd_Order, "Změnit parametry řazení kouzel")
        Me.Cmd_Order.UseVisualStyleBackColor = False
        '
        'Cmd_Last
        '
        Me.Cmd_Last.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Last.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Last.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Last.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Last.Image = CType(resources.GetObject("Cmd_Last.Image"), System.Drawing.Image)
        Me.Cmd_Last.Location = New System.Drawing.Point(280, 392)
        Me.Cmd_Last.Name = "Cmd_Last"
        Me.Cmd_Last.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Last.Size = New System.Drawing.Size(41, 33)
        Me.Cmd_Last.TabIndex = 4
        Me.Cmd_Last.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Last, "Na konec")
        Me.Cmd_Last.UseVisualStyleBackColor = False
        '
        'Cmd_Forward
        '
        Me.Cmd_Forward.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Forward.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Forward.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Forward.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Forward.Image = CType(resources.GetObject("Cmd_Forward.Image"), System.Drawing.Image)
        Me.Cmd_Forward.Location = New System.Drawing.Point(240, 392)
        Me.Cmd_Forward.Name = "Cmd_Forward"
        Me.Cmd_Forward.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Forward.Size = New System.Drawing.Size(41, 33)
        Me.Cmd_Forward.TabIndex = 3
        Me.Cmd_Forward.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Forward, "O 1 vpřed")
        Me.Cmd_Forward.UseVisualStyleBackColor = False
        '
        'Cmd_Back
        '
        Me.Cmd_Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Back.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Back.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Back.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Back.Image = CType(resources.GetObject("Cmd_Back.Image"), System.Drawing.Image)
        Me.Cmd_Back.Location = New System.Drawing.Point(64, 392)
        Me.Cmd_Back.Name = "Cmd_Back"
        Me.Cmd_Back.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Back.Size = New System.Drawing.Size(41, 33)
        Me.Cmd_Back.TabIndex = 1
        Me.Cmd_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Back, "O 1 vzad")
        Me.Cmd_Back.UseVisualStyleBackColor = False
        '
        'Cmd_First
        '
        Me.Cmd_First.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_First.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_First.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_First.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_First.Image = CType(resources.GetObject("Cmd_First.Image"), System.Drawing.Image)
        Me.Cmd_First.Location = New System.Drawing.Point(24, 392)
        Me.Cmd_First.Name = "Cmd_First"
        Me.Cmd_First.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_First.Size = New System.Drawing.Size(41, 33)
        Me.Cmd_First.TabIndex = 0
        Me.Cmd_First.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_First, "Na začátek")
        Me.Cmd_First.UseVisualStyleBackColor = False
        '
        'Txt_rem
        '
        Me.Txt_rem.AcceptsReturn = True
        Me.Txt_rem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_rem.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_rem.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_rem.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_rem.Location = New System.Drawing.Point(112, 344)
        Me.Txt_rem.MaxLength = 0
        Me.Txt_rem.Multiline = True
        Me.Txt_rem.Name = "Txt_rem"
        Me.Txt_rem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_rem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_rem.Size = New System.Drawing.Size(225, 33)
        Me.Txt_rem.TabIndex = 23
        '
        'Txt_kw
        '
        Me.Txt_kw.AcceptsReturn = True
        Me.Txt_kw.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_kw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_kw.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_kw.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_kw.Location = New System.Drawing.Point(112, 304)
        Me.Txt_kw.MaxLength = 0
        Me.Txt_kw.Multiline = True
        Me.Txt_kw.Name = "Txt_kw"
        Me.Txt_kw.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_kw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_kw.Size = New System.Drawing.Size(225, 33)
        Me.Txt_kw.TabIndex = 21
        '
        'Txt_imp
        '
        Me.Txt_imp.AcceptsReturn = True
        Me.Txt_imp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_imp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_imp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_imp.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_imp.Location = New System.Drawing.Point(112, 280)
        Me.Txt_imp.MaxLength = 0
        Me.Txt_imp.Name = "Txt_imp"
        Me.Txt_imp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_imp.Size = New System.Drawing.Size(49, 19)
        Me.Txt_imp.TabIndex = 19
        '
        'Txt_pop
        '
        Me.Txt_pop.AcceptsReturn = True
        Me.Txt_pop.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_pop.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_pop.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_pop.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_pop.Location = New System.Drawing.Point(8, 88)
        Me.Txt_pop.MaxLength = 0
        Me.Txt_pop.Multiline = True
        Me.Txt_pop.Name = "Txt_pop"
        Me.Txt_pop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_pop.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_pop.Size = New System.Drawing.Size(329, 185)
        Me.Txt_pop.TabIndex = 17
        '
        'Txt_tit
        '
        Me.Txt_tit.AcceptsReturn = True
        Me.Txt_tit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_tit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_tit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_tit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_tit.Location = New System.Drawing.Point(144, 40)
        Me.Txt_tit.MaxLength = 0
        Me.Txt_tit.Name = "Txt_tit"
        Me.Txt_tit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_tit.Size = New System.Drawing.Size(193, 19)
        Me.Txt_tit.TabIndex = 15
        '
        'Txt_dat
        '
        Me.Txt_dat.AcceptsReturn = True
        Me.Txt_dat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_dat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_dat.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_dat.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_dat.Location = New System.Drawing.Point(8, 40)
        Me.Txt_dat.MaxLength = 0
        Me.Txt_dat.Name = "Txt_dat"
        Me.Txt_dat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_dat.Size = New System.Drawing.Size(129, 19)
        Me.Txt_dat.TabIndex = 14
        '
        'Txt_Num
        '
        Me.Txt_Num.AcceptsReturn = True
        Me.Txt_Num.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_Num.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Num.Font = New System.Drawing.Font("Arial", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Num.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Num.Location = New System.Drawing.Point(104, 392)
        Me.Txt_Num.MaxLength = 0
        Me.Txt_Num.Name = "Txt_Num"
        Me.Txt_Num.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Num.Size = New System.Drawing.Size(137, 33)
        Me.Txt_Num.TabIndex = 2
        Me.Txt_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(8, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(97, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Poznámky"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(8, 304)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(97, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Klíčová slova"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Důležitost"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Popis"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(184, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(105, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Titulek"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(129, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Datum události"
        '
        'Bt_List
        '
        Me.Bt_List.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Bt_List.Image = CType(resources.GetObject("Bt_List.Image"), System.Drawing.Image)
        Me.Bt_List.Location = New System.Drawing.Point(144, 440)
        Me.Bt_List.Name = "Bt_List"
        Me.Bt_List.Size = New System.Drawing.Size(56, 96)
        Me.Bt_List.TabIndex = 47
        Me.Bt_List.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Frm_Events
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(345, 616)
        Me.Controls.Add(Me.Bt_List)
        Me.Controls.Add(Me.Txt_rem)
        Me.Controls.Add(Me.Txt_kw)
        Me.Controls.Add(Me.Txt_imp)
        Me.Controls.Add(Me.Txt_pop)
        Me.Controls.Add(Me.Txt_tit)
        Me.Controls.Add(Me.Txt_dat)
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
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.Name = "Frm_Events"
        Me.Opacity = 0.9
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "GC AVATAR - Odria Events"
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As Frm_Events
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Frm_Events
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Frm_Events()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal value As Frm_Events)
            m_vb6FormDefInstance = value
        End Set
    End Property
#End Region

    Private Sub Frm_SPsez_Unload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles my_sez.Closed
        If Ttit <> "" Then
            EVposition = 0
            If Tday <> "" Then
                Do Until (EVrec.Tables("E").Rows(EVposition)("Event_Title") = Ttit) And (EVrec.Tables("E").Rows(EVposition)("Day_E") = Tday) And (EVrec.Tables("E").Rows(EVposition)("Month_E") = Tmonth) And (EVrec.Tables("E").Rows(EVposition)("E_Year") = Tyear) And (EVrec.Tables("E").Rows(EVposition)("Epoch") = Tepoch)
                    EVposition += 1
                Loop
            Else
                If Tmonth <> "" Then
                    Do Until (EVrec.Tables("E").Rows(EVposition)("Event_Title") = Ttit) And (EVrec.Tables("E").Rows(EVposition)("Month_E") = Tmonth) And (EVrec.Tables("E").Rows(EVposition)("E_Year") = Tyear) And (EVrec.Tables("E").Rows(EVposition)("Epoch") = Tepoch)
                        EVposition += 1
                    Loop
                Else
                    Do Until (EVrec.Tables("E").Rows(EVposition)("Event_Title") = Ttit) And (EVrec.Tables("E").Rows(EVposition)("E_Year") = Tyear) And (EVrec.Tables("E").Rows(EVposition)("Epoch") = Tepoch)
                        EVposition += 1
                    Loop
                End If
            End If
            FillForm()
            Me.Refresh()
        End If
    End Sub

    Private Sub Cmd_Back_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Back.Click
        EVposition -= 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Exit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Cmd_First_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_First.Click
        EVposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Forward_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Forward.Click
        EVposition += 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Last_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Last.Click
        EVposition = EVcount - 1
        Call FillForm()
    End Sub

    Private Sub Cmd_New_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_New.Click
        Txt_dat.Text = ""
        Txt_tit.Text = ""
        Txt_pop.Text = ""
        Txt_imp.Text = ""
        Txt_kw.Text = ""
        Txt_rem.Text = ""
        Cmd_Print.Enabled = False
        Cmd_Del.Enabled = False
        Txt_Num.Text = "NEW"
    End Sub

    Private Sub Frm_Events_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Call EVrecopen()
        EVposition = 0
        ApplyColor()
        Call FillForm()
        EV = True
    End Sub


    Private Sub EVrecopen()
        Dim eec As New OleDbCommand
        eec.Connection = Odrialink2
        Select Case EVorder
            Case Is = 1
                If EVdirect = 1 Then
                    eec.CommandText = "select * from Events order by Epoch, E_Year, Month_E, Day_E, E_Importance, Event_Title"
                Else
                    eec.CommandText = "select * from Events order by Epoch, E_Year, Month_E, Day_E, E_Importance, Event_Title desc"
                End If
            Case Is = 2
                If EVdirect = 1 Then
                    eec.CommandText = "select * from Events order by E_Importance, Epoch, E_Year, Month_E, Day_E, Event_Title"
                Else
                    eec.CommandText = "select * from Events order by E_Importance, Epoch, E_Year, Month_E, Day_E, Event_Title desc"
                End If
            Case Is = 3
                If EVdirect = 1 Then
                    eec.CommandText = "select * from Events order by Event_Title, Epoch, E_Year, Month_E, Day_E, E_Importance"
                Else
                    eec.CommandText = "select * from Events order by Event_Title, Epoch, E_Year, Month_E, Day_E, E_Importance desc"
                End If
        End Select
        EVdat.SelectCommand = eec
        EVrec.Clear()
        EVdat.Fill(EVrec, "E")
        EVcount = EVrec.Tables("E").Rows.Count
    End Sub


    Sub FillForm()
        If IsDBNull(EVrec.Tables("E").Rows(EVposition)("Month_E")) Then
            Txt_dat.Text = EVrec.Tables("E").Rows(EVposition)("E_Year")
        Else
            If IsDBNull(EVrec.Tables("E").Rows(EVposition)("Day_E")) Then
                Txt_dat.Text = EVrec.Tables("E").Rows(EVposition)("Month_E") & "." & EVrec.Tables("E").Rows(EVposition)("E_Year")
            Else
                Txt_dat.Text = EVrec.Tables("E").Rows(EVposition)("Day_E") & "." & EVrec.Tables("E").Rows(EVposition)("Month_E") & "." & EVrec.Tables("E").Rows(EVposition)("E_Year")
            End If
        End If
        Select Case EVrec.Tables("E").Rows(EVposition)("Epoch")
            Case Is = 500
                Txt_dat.Text = Txt_dat.Text & " AC"
            Case Is = 490
                Txt_dat.Text = Txt_dat.Text & " TC"
            Case Is = 480
                Txt_dat.Text = Txt_dat.Text & " XC"
        End Select
        Txt_tit.Text = EVrec.Tables("E").Rows(EVposition)("Event_Title")
        If Not IsDBNull(EVrec.Tables("E").Rows(EVposition)("Event_Log")) Then
            Txt_pop.Text = EVrec.Tables("E").Rows(EVposition)("Event_Log")
        Else
            Txt_pop.Text = ""
        End If
        If Not IsDBNull(EVrec.Tables("E").Rows(EVposition)("E_Importance")) Then
            Txt_imp.Text = EVrec.Tables("E").Rows(EVposition)("E_Importance")
        Else
            Txt_imp.Text = ""
        End If
        If Not IsDBNull(EVrec.Tables("E").Rows(EVposition)("E_Keywords")) Then
            Txt_kw.Text = EVrec.Tables("E").Rows(EVposition)("E_Keywords")
        Else
            Txt_kw.Text = ""
        End If
        If Not IsDBNull(EVrec.Tables("E").Rows(EVposition)("E_Remarks")) Then
            Txt_rem.Text = EVrec.Tables("E").Rows(EVposition)("E_Remarks")
        Else
            Txt_rem.Text = ""
        End If
        If EVposition = 0 Then
            Cmd_Back.Enabled = False
        Else
            Cmd_Back.Enabled = True
        End If
        Cmd_Del.Enabled = True
        Cmd_Find.Enabled = True
        If EVposition + 1 = EVcount Then
            Cmd_Forward.Enabled = False
        Else
            Cmd_Forward.Enabled = True
        End If
        Cmd_Ins.Enabled = True
        Cmd_New.Enabled = True
        Cmd_Print.Enabled = True


        Txt_Num.Text = (EVposition + 1) & "/" & EVcount

    End Sub


    Private Sub Frm_Events_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        EV = False
        EVrec.Clear()
    End Sub


    Private Sub Txt_Num_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Num.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            If Not IsNumeric(Txt_Num.Text) Then
                MsgBox("Tady musí být číslo!", MsgBoxStyle.OkOnly, "Chyba")
                GoTo EventExitSub
            End If
            If CShort(Txt_Num.Text) > EVcount Or CShort(Txt_Num.Text) < 1 Then
                MsgBox("Číslo musí být v rozsahu 1 - počet záznamů!", MsgBoxStyle.OkOnly, "Chyba")
                GoTo EventExitSub
            End If
            KeyAscii = 0
            EVposition = CShort(Txt_Num.Text) - 1
            Call FillForm()
        End If
EventExitSub:
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub Cmd_Print_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Print.Click
        Dim EVrint As New EVPrint
        EVrint.Show()
    End Sub

    Private Sub Cmd_Order_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Order.Click
        OrderControl = "EV"
        FO = New Frm_Ordering
        FO.ShowDialog()
        FO = Nothing
        EVrec.Clear()
        Call EVrecopen()
        EVposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Ins_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Ins.Click
        If Txt_dat.Text = "" Then
            MsgBox("Událost musí mít datum!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        If Txt_tit.Text = "" Then
            MsgBox("Událost musí mít titulek!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        Txt_dat.Text = Txt_dat.Text.ToUpper
        Txt_tit.Text = Txt_tit.Text.ToUpper
        qq = Txt_dat.Text
        If InStr(qq, ".") = 0 Then
            dd = ""
            mm = ""
            DetEra()
        Else
            If InStr(qq, ".") = 2 Then
                mm = Mid(qq, 1, 1)
                qq = Mid(qq, 3, Len(qq) - 2)
            Else
                mm = Mid(qq, 1, 2)
                qq = Mid(qq, 4, Len(qq) - 3)
            End If
            If InStr(qq, ".") <> 0 Then
                dd = mm
                If InStr(qq, ".") = 2 Then
                    mm = Mid(qq, 1, 1)
                    qq = Mid(qq, 3, Len(qq) - 2)
                Else
                    mm = Mid(qq, 1, 2)
                    qq = Mid(qq, 4, Len(qq) - 3)
                End If
            End If
            DetEra()
        End If
        If dd <> "" And Not IsNumeric(dd) Then
            MsgBox("Chybné určení dne!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        If mm <> "" And Not IsNumeric(mm) Then
            MsgBox("Chybné určení měsíce!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        If yy = "" Then
            MsgBox("Chybné určení roku!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        If ee = "" Then
            MsgBox("Chybné určení letopočtu!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        Dim tsc As New OleDbCommand
        Dim treader As OleDbDataReader
        Try
            tsc.Connection = Odrialink2
            tsc.CommandText = "select * from Events where Day_E = @de and Month_E = @me and E_Year = @ey and Epoch = @ep and Event_Title = @et"
            If dd = "" Then
                tsc.Parameters.AddWithValue("@de", System.DBNull.Value)
            Else
                tsc.Parameters.AddWithValue("@de", dd)
            End If
            If mm = "" Then
                tsc.Parameters.AddWithValue("@me", System.DBNull.Value)
            Else
                tsc.Parameters.AddWithValue("@me", mm)
            End If
            tsc.Parameters.AddWithValue("@ey", yy)
            tsc.Parameters.AddWithValue("@ep", ee)
            tsc.Parameters.AddWithValue("@et", Txt_tit.Text)
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
                s1 = "INSERT INTO Events (Epoch, E_Year, Event_Title"
                s2 = " VALUES (@ep, @ey, @et"
                ic.Parameters.AddWithValue("@ep", ee)
                ic.Parameters.AddWithValue("@ey", yy)
                ic.Parameters.AddWithValue("@et", Txt_tit.Text)
                If dd <> "" Then
                    ic.Parameters.AddWithValue("@ed", dd)
                    s1 = s1 & ", Day_E"
                    s2 = s2 & ", @ed"
                End If
                If mm <> "" Then
                    ic.Parameters.AddWithValue("@md", mm)
                    s1 = s1 & ", Month_E"
                    s2 = s2 & ", @md"
                End If
                If Txt_pop.Text <> "" Then
                    ic.Parameters.AddWithValue("@el", Trim(Txt_pop.Text))
                    s1 = s1 & ", Event_Log"
                    s2 = s2 & ", @el"
                End If
                If Txt_imp.Text <> "" Then
                    ic.Parameters.AddWithValue("@im", Txt_imp.Text)
                    s1 = s1 & ", E_Importance"
                    s2 = s2 & ", @im"
                End If
                If Txt_kw.Text <> "" Then
                    ic.Parameters.AddWithValue("@kw", Trim(Txt_kw.Text))
                    s1 = s1 & ", E_Keywords"
                    s2 = s2 & ", @kw"
                End If
                If Txt_rem.Text <> "" Then
                    ic.Parameters.AddWithValue("@re", Trim(Txt_rem.Text))
                    s1 = s1 & ", E_Remarks"
                    s2 = s2 & ", @re"
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
            EVrec.Clear()
            EVdat.Fill(EVrec, "E")
            EVcount = EVrec.Tables("E").Rows.Count
            Call FillForm()
        Else
            Dim pID As Int64
            pID = treader.GetInt64(7)
            treader.Close()
            If MsgBox("Událost tohoto data a jména již v databázi existuje, chcete jí přepsat?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Upozornění") = MsgBoxResult.Yes Then
                Try
                    Dim s3 As String
                    Dim uc As New OleDbCommand
                    s3 = "UPDATE Events set Epoch = @ep, E_Year = @ey, Day_E = @de, Month_E = @me, Event_Title = @et, Event_Log = @el, E_Importance = @im, E_Keywords = @kw, E_Remarks = @re WHERE ID = @ID"
                    uc.Parameters.AddWithValue("@ep", ee)
                    uc.Parameters.AddWithValue("@ey", yy)
                    If dd = "" Then
                        uc.Parameters.AddWithValue("@de", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@de", dd)
                    End If
                    If mm = "" Then
                        uc.Parameters.AddWithValue("@me", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@me", mm)
                    End If
                    uc.Parameters.AddWithValue("@et", Txt_tit.Text)
                    If Txt_pop.Text = "" Then
                        uc.Parameters.AddWithValue("@el", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@el", Trim(Txt_pop.Text))
                    End If
                    If Txt_imp.Text = "" Then
                        uc.Parameters.AddWithValue("@im", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@im", Txt_imp.Text)
                    End If
                    If Txt_kw.Text = "" Then
                        uc.Parameters.AddWithValue("@kw", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@kw", Trim(Txt_kw.Text))
                    End If
                    If Txt_rem.Text = "" Then
                        uc.Parameters.AddWithValue("@re", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@re", Trim(Txt_rem.Text))
                    End If
                    uc.Parameters.AddWithValue("@ID", pID)
                    uc.Connection = Odrialink2
                    uc.CommandText = s3
                    uc.ExecuteScalar()
                Catch ex As Exception
                    MsgBox("Chyba updatu případu: " + ex.Message, , "Pokus o update")
                    Exit Sub
                End Try
                EVrec.Clear()
                EVdat.Fill(EVrec, "E")
                Call FillForm()
            Else
                Exit Sub
            End If
        End If

    End Sub
    Private Sub DetEra()
        If Len(qq) > 3 Then
            yy = Mid(qq, 1, Len(qq) - 3)
        Else
            yy = ""
        End If
        Select Case Mid(qq, Len(qq) - 1, 2)
            Case Is = "AC"
                ee = 500
            Case Is = "TC"
                ee = 490
            Case Is = "XC"
                ee = 480
            Case Else
                ee = ""
        End Select
    End Sub

    Private Sub Cmd_Find_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Find.Click
        Dim EVse As New OleDbCommand
        Dim EVre As OleDbDataReader
        Dim s As String
        Dim da, ma, ye, ep, ti, po, im, kw, re As Boolean
        EVse.Connection = Odrialink2
        Txt_tit.Text = Txt_tit.Text.ToUpper()
        Txt_dat.Text = Txt_dat.Text.ToUpper()
        s = "SELECT * from Events WHERE "
        qq = Txt_dat.Text
        If qq <> "" Then
            If InStr(qq, ".") = 0 Then
                dd = ""
                mm = ""
                DetEra()
            Else
                If InStr(qq, ".") = 2 Then
                    mm = Mid(qq, 1, 1)
                    qq = Mid(qq, 3, Len(qq) - 2)
                Else
                    mm = Mid(qq, 1, 2)
                    qq = Mid(qq, 4, Len(qq) - 3)
                End If
                If InStr(qq, ".") <> 0 Then
                    dd = mm
                    If InStr(qq, ".") = 2 Then
                        mm = Mid(qq, 1, 1)
                        qq = Mid(qq, 3, Len(qq) - 2)
                    Else
                        mm = Mid(qq, 1, 2)
                        qq = Mid(qq, 4, Len(qq) - 3)
                    End If
                End If
                DetEra()
            End If
        End If
        If dd <> "" Then
            s = s & "Day_E = @da"
            EVse.Parameters.AddWithValue("@da", dd)
            da = True
        End If
        If mm <> "" Then
            If da Then
                s = s & " AND "
            End If
            s = s & "Month_E = @ye"
            EVse.Parameters.AddWithValue("@ma", mm)
            ma = True
        End If
        If yy <> "" Then
            If da Or ma Then
                s = s & " AND "
            End If
            s = s & "E_Year LIKE @ye"
            EVse.Parameters.AddWithValue("@ye", "%" & yy & "%")
            ye = True
        End If
        If ee <> "" Then
            If da Or ma Or ye Then
                s = s & " AND "
            End If
            s = s & "Epoch = @ep"
            EVse.Parameters.AddWithValue("@ep", ee)
            ep = True
        End If
        If Txt_tit.Text <> "" Then
            If da Or ma Or ye Or ep Then
                s = s & " AND "
            End If
            s = s & "Event_Title LIKE @ti"
            EVse.Parameters.AddWithValue("@ti", "%" & Trim(Txt_tit.Text) & "%")
            ti = True
        End If
        If Txt_pop.Text <> "" Then
            If da Or ma Or ye Or ep Or ti Then
                s = s & " AND "
            End If
            s = s & "Event_Log LIKE @po"
            EVse.Parameters.AddWithValue("@po", "%" & Trim(Txt_pop.Text) & "%")
            po = True
        End If
        If Txt_imp.Text <> "" Then
            If da Or ma Or ye Or ep Or ti Or po Then
                s = s & " AND "
            End If
            s = s & "E_Importance = @im"
            EVse.Parameters.AddWithValue("@im", Txt_imp.Text)
            im = True
        End If
        If Txt_kw.Text <> "" Then
            If da Or ma Or ye Or ep Or ti Or po Or im Then
                s = s & " AND "
            End If
            s = s & "E_Keywords LIKE @kw"
            EVse.Parameters.AddWithValue("@kw", "%" & Trim(Txt_kw.Text) & "%")
            kw = True
        End If
        If Txt_rem.Text <> "" Then
            If da Or ma Or ye Or ep Or ti Or po Or im Or kw Then
                s = s & " AND "
            End If
            s = s & "E_Remarks LIKE @re"
            EVse.Parameters.AddWithValue("@re", "%" & Trim(Txt_rem.Text) & "%")
            re = True
        End If
        EVposition = 0
        If s = "SELECT * from Events WHERE " Then
            EVrecopen()
            FillForm()
            Exit Sub
        End If
        Try
            EVse.CommandText = s
            EVre = EVse.ExecuteReader
            If EVre.HasRows Then
                EVre.Close()
                EVdat.SelectCommand = EVse
                EVrec.Clear()
                EVdat.Fill(EVrec, "E")
                EVcount = EVrec.Tables("E").Rows.Count
                If GC_list = 1 Then
                    If my_sez Is Nothing Then
                        my_sez = New Frm_EVsez
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
                EVre.Close()
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
        If MsgBox("Opravdu vymazat událost " & Txt_dat.Text & " " & Txt_tit.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Upozornění") = MsgBoxResult.Yes Then
            Try
                tsc.Connection = Odrialink2
                tsc.CommandText = "DELETE from Events WHERE ID = @ID"
                tsc.Parameters.AddWithValue("@ID", EVrec.Tables("E").Rows(SPposition)("ID"))
                tsc.ExecuteScalar()
            Catch ex As Exception
                Throw New Exception("Chyba při výmazu případu: " + ex.Message)
                Exit Sub
            End Try
        Else
            Exit Sub
        End If
        EVrec.Clear()
        EVdat.Fill(EVrec, "E")
        EVcount = EVrec.Tables("E").Rows.Count
        If EVposition = EVcount Then
            EVposition -= 1
        End If
        Call FillForm()
    End Sub

    Private Sub Bt_List_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_List.Click
        If my_sez Is Nothing Then
            my_sez = New Frm_EVsez
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
        Me.BackColor = Color.FromArgb(FVB)
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
        Label1.ForeColor = Color.FromArgb(FVF)
        Label2.ForeColor = Color.FromArgb(FVF)
        Label3.ForeColor = Color.FromArgb(FVF)
        Label4.ForeColor = Color.FromArgb(FVF)
        Label5.ForeColor = Color.FromArgb(FVF)
        Label6.ForeColor = Color.FromArgb(FVF)
        Txt_Num.ForeColor = Color.FromArgb(FVF)
        Txt_dat.ForeColor = Color.FromArgb(FVF)
        Txt_tit.ForeColor = Color.FromArgb(FVF)
        Txt_pop.ForeColor = Color.FromArgb(FVF)
        Txt_imp.ForeColor = Color.FromArgb(FVF)
        Txt_kw.ForeColor = Color.FromArgb(FVF)
        Txt_rem.ForeColor = Color.FromArgb(FVF)
    End Sub
End Class