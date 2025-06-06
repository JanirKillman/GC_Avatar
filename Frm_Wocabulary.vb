Option Strict Off
Option Explicit On 
Imports System.Data.OleDb
Friend Class Frm_Wocabulary
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
	Public WithEvents Txt_jj3 As System.Windows.Forms.TextBox
	Public WithEvents Txt_jj2 As System.Windows.Forms.TextBox
	Public WithEvents Txt_jj1 As System.Windows.Forms.TextBox
	Public WithEvents Txt_gob As System.Windows.Forms.TextBox
	Public WithEvents Txt_ne As System.Windows.Forms.TextBox
	Public WithEvents Txt_se As System.Windows.Forms.TextBox
	Public WithEvents Txt_word As System.Windows.Forms.TextBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Wocabulary))
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
        Me.Txt_jj3 = New System.Windows.Forms.TextBox
        Me.Txt_jj2 = New System.Windows.Forms.TextBox
        Me.Txt_jj1 = New System.Windows.Forms.TextBox
        Me.Txt_gob = New System.Windows.Forms.TextBox
        Me.Txt_ne = New System.Windows.Forms.TextBox
        Me.Txt_se = New System.Windows.Forms.TextBox
        Me.Txt_word = New System.Windows.Forms.TextBox
        Me.Txt_Num = New System.Windows.Forms.TextBox
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
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_Exit.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Exit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(8, 352)
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
        Me.Cmd_Ins.Location = New System.Drawing.Point(8, 240)
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
        Me.Cmd_Del.Location = New System.Drawing.Point(8, 272)
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
        Me.Cmd_Find.Location = New System.Drawing.Point(8, 304)
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
        Me.Cmd_New.Location = New System.Drawing.Point(192, 240)
        Me.Cmd_New.Name = "Cmd_New"
        Me.Cmd_New.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_New.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_New.TabIndex = 7
        Me.Cmd_New.Text = "NOVÉ"
        Me.ToolTip1.SetToolTip(Me.Cmd_New, "Vymaže pole, příprava na vepsání nového kouzla")
        Me.Cmd_New.UseVisualStyleBackColor = False
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.Cyan
        Me.Cmd_Print.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Print.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Print.Location = New System.Drawing.Point(192, 272)
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
        Me.Cmd_Order.Location = New System.Drawing.Point(192, 304)
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
        Me.Cmd_Last.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_Last.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Last.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Last.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Last.Image = CType(resources.GetObject("Cmd_Last.Image"), System.Drawing.Image)
        Me.Cmd_Last.Location = New System.Drawing.Point(264, 192)
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
        Me.Cmd_Forward.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_Forward.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Forward.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Forward.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Forward.Image = CType(resources.GetObject("Cmd_Forward.Image"), System.Drawing.Image)
        Me.Cmd_Forward.Location = New System.Drawing.Point(224, 192)
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
        Me.Cmd_Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_Back.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Back.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Back.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Back.Image = CType(resources.GetObject("Cmd_Back.Image"), System.Drawing.Image)
        Me.Cmd_Back.Location = New System.Drawing.Point(48, 192)
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
        Me.Cmd_First.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_First.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_First.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_First.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_First.Image = CType(resources.GetObject("Cmd_First.Image"), System.Drawing.Image)
        Me.Cmd_First.Location = New System.Drawing.Point(8, 192)
        Me.Cmd_First.Name = "Cmd_First"
        Me.Cmd_First.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_First.Size = New System.Drawing.Size(41, 33)
        Me.Cmd_First.TabIndex = 0
        Me.Cmd_First.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_First, "Na začátek")
        Me.Cmd_First.UseVisualStyleBackColor = False
        '
        'Txt_jj3
        '
        Me.Txt_jj3.AcceptsReturn = True
        Me.Txt_jj3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_jj3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_jj3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_jj3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_jj3.Location = New System.Drawing.Point(112, 160)
        Me.Txt_jj3.MaxLength = 0
        Me.Txt_jj3.Name = "Txt_jj3"
        Me.Txt_jj3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_jj3.Size = New System.Drawing.Size(193, 19)
        Me.Txt_jj3.TabIndex = 25
        '
        'Txt_jj2
        '
        Me.Txt_jj2.AcceptsReturn = True
        Me.Txt_jj2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_jj2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_jj2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_jj2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_jj2.Location = New System.Drawing.Point(112, 136)
        Me.Txt_jj2.MaxLength = 0
        Me.Txt_jj2.Name = "Txt_jj2"
        Me.Txt_jj2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_jj2.Size = New System.Drawing.Size(193, 19)
        Me.Txt_jj2.TabIndex = 23
        '
        'Txt_jj1
        '
        Me.Txt_jj1.AcceptsReturn = True
        Me.Txt_jj1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_jj1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_jj1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_jj1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_jj1.Location = New System.Drawing.Point(112, 112)
        Me.Txt_jj1.MaxLength = 0
        Me.Txt_jj1.Name = "Txt_jj1"
        Me.Txt_jj1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_jj1.Size = New System.Drawing.Size(193, 19)
        Me.Txt_jj1.TabIndex = 21
        '
        'Txt_gob
        '
        Me.Txt_gob.AcceptsReturn = True
        Me.Txt_gob.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_gob.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_gob.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_gob.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_gob.Location = New System.Drawing.Point(112, 88)
        Me.Txt_gob.MaxLength = 0
        Me.Txt_gob.Name = "Txt_gob"
        Me.Txt_gob.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_gob.Size = New System.Drawing.Size(193, 19)
        Me.Txt_gob.TabIndex = 19
        '
        'Txt_ne
        '
        Me.Txt_ne.AcceptsReturn = True
        Me.Txt_ne.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_ne.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_ne.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ne.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_ne.Location = New System.Drawing.Point(112, 64)
        Me.Txt_ne.MaxLength = 0
        Me.Txt_ne.Name = "Txt_ne"
        Me.Txt_ne.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_ne.Size = New System.Drawing.Size(193, 19)
        Me.Txt_ne.TabIndex = 17
        '
        'Txt_se
        '
        Me.Txt_se.AcceptsReturn = True
        Me.Txt_se.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_se.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_se.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_se.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_se.Location = New System.Drawing.Point(112, 40)
        Me.Txt_se.MaxLength = 0
        Me.Txt_se.Name = "Txt_se"
        Me.Txt_se.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_se.Size = New System.Drawing.Size(193, 19)
        Me.Txt_se.TabIndex = 15
        '
        'Txt_word
        '
        Me.Txt_word.AcceptsReturn = True
        Me.Txt_word.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_word.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_word.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_word.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_word.Location = New System.Drawing.Point(88, 8)
        Me.Txt_word.MaxLength = 0
        Me.Txt_word.Name = "Txt_word"
        Me.Txt_word.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_word.Size = New System.Drawing.Size(217, 19)
        Me.Txt_word.TabIndex = 13
        '
        'Txt_Num
        '
        Me.Txt_Num.AcceptsReturn = True
        Me.Txt_Num.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_Num.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Num.Font = New System.Drawing.Font("Arial", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Num.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Num.Location = New System.Drawing.Point(88, 192)
        Me.Txt_Num.MaxLength = 0
        Me.Txt_Num.Name = "Txt_Num"
        Me.Txt_Num.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Num.Size = New System.Drawing.Size(137, 33)
        Me.Txt_Num.TabIndex = 2
        Me.Txt_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(8, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(97, 17)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Jiný jazyk 3"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(8, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(97, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Jiný jazyk 2"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(8, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(97, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Jiný jazyk 1"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Skřetština"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Nová elfština"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Stará elfština"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Slovo"
        '
        'Bt_List
        '
        Me.Bt_List.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Bt_List.Image = CType(resources.GetObject("Bt_List.Image"), System.Drawing.Image)
        Me.Bt_List.Location = New System.Drawing.Point(128, 240)
        Me.Bt_List.Name = "Bt_List"
        Me.Bt_List.Size = New System.Drawing.Size(56, 96)
        Me.Bt_List.TabIndex = 47
        Me.Bt_List.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Frm_Wocabulary
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(315, 418)
        Me.Controls.Add(Me.Bt_List)
        Me.Controls.Add(Me.Txt_jj3)
        Me.Controls.Add(Me.Txt_jj2)
        Me.Controls.Add(Me.Txt_jj1)
        Me.Controls.Add(Me.Txt_gob)
        Me.Controls.Add(Me.Txt_ne)
        Me.Controls.Add(Me.Txt_se)
        Me.Controls.Add(Me.Txt_word)
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
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.Name = "Frm_Wocabulary"
        Me.Opacity = 0.9
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "GC AVATAR - Odria Wocabulary"
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As Frm_Wocabulary
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Frm_Wocabulary
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Frm_Wocabulary()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal value As Frm_Wocabulary)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region
    Private Sub Frm_WOsez_Unload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles my_sez.Closed
        If Twoc <> "" Then
            WOposition = 0
            Do Until (WOrec.Tables("wo").Rows(WOposition)("Word") = Twoc)
                WOposition += 1
            Loop
        End If
        FillForm()
        Me.Refresh()
    End Sub

    Private Sub Cmd_Back_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Back.Click
        WOposition -= 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Exit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Cmd_First_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_First.Click
        WOposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Forward_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Forward.Click
        WOposition += 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Last_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Last.Click
        WOposition = WOcount - 1
        Call FillForm()
    End Sub

    Private Sub Cmd_New_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_New.Click
        Txt_word.Text = ""
        Txt_se.Text = ""
        Txt_ne.Text = ""
        Txt_gob.Text = ""
        Txt_jj1.Text = ""
        Txt_jj2.Text = ""
        Txt_jj3.Text = ""
        Cmd_Print.Enabled = False
        Cmd_Del.Enabled = False
        Txt_Num.Text = "NEW"
    End Sub

    Private Sub Frm_Wocabulary_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Call WOrecopen()
        WOposition = 0
        ApplyColor()
        Call FillForm()
        WO = True
    End Sub


    Private Sub WOrecopen()
        Dim skc As New OleDbCommand
        skc.Connection = Odrialink2
        Select Case WOorder
            Case Is = 1
                If WOdirect = 1 Then
                    skc.CommandText = "select * from Wocabulary order by Word"
                Else
                    skc.CommandText = "select * from Wocabulary order by Word desc"
                End If
            Case Is = 2
                If WOdirect = 1 Then
                    skc.CommandText = "select * from Wocabulary order by Old_Elvish"
                Else
                    skc.CommandText = "select * from Wocabulary order by Old_Elvish desc"
                End If
            Case Is = 3
                If WOdirect = 1 Then
                    skc.CommandText = "select * from Wocabulary order by Goblinish"
                Else
                    skc.CommandText = "select * from Wocabulary order by Goblinish desc"
                End If
        End Select
        WOdat.SelectCommand = skc
        WOrec.Clear()
        WOdat.Fill(WOrec, "wo")
        WOcount = WOrec.Tables("wo").Rows.Count
    End Sub


    Sub FillForm()


        Txt_word.Text = WOrec.Tables("wo").Rows(WOposition)("Word")
        If Not IsDBNull(WOrec.Tables("wo").Rows(WOposition)("Old_Elvish")) Then
            Txt_se.Text = WOrec.Tables("wo").Rows(WOposition)("Old_Elvish")
        Else
            Txt_se.Text = ""
        End If
        If Not IsDBNull(WOrec.Tables("wo").Rows(WOposition)("New_Elvish")) Then
            Txt_ne.Text = WOrec.Tables("wo").Rows(WOposition)("New_Elvish")
        Else
            Txt_ne.Text = ""
        End If
        If Not IsDBNull(WOrec.Tables("wo").Rows(WOposition)("Goblinish")) Then
            Txt_gob.Text = WOrec.Tables("wo").Rows(WOposition)("Goblinish")
        Else
            Txt_gob.Text = ""
        End If
        If Not IsDBNull(WOrec.Tables("wo").Rows(WOposition)("Other1")) Then
            Txt_jj1.Text = WOrec.Tables("wo").Rows(WOposition)("Other1")
        Else
            Txt_jj1.Text = ""
        End If
        If Not IsDBNull(WOrec.Tables("wo").Rows(WOposition)("Other2")) Then
            Txt_jj2.Text = WOrec.Tables("wo").Rows(WOposition)("Other2")
        Else
            Txt_jj2.Text = ""
        End If
        If Not IsDBNull(WOrec.Tables("wo").Rows(WOposition)("Other3")) Then
            Txt_jj3.Text = WOrec.Tables("wo").Rows(WOposition)("Other3")
        Else
            Txt_jj3.Text = ""
        End If
        If WOposition = 0 Then
            Cmd_Back.Enabled = False
        Else
            Cmd_Back.Enabled = True
        End If
        Cmd_Del.Enabled = True
        Cmd_Find.Enabled = True
        If WOposition + 1 = WOcount Then
            Cmd_Forward.Enabled = False
        Else
            Cmd_Forward.Enabled = True
        End If
        Cmd_Ins.Enabled = True
        Cmd_New.Enabled = True
        Cmd_Print.Enabled = True


        Txt_Num.Text = (WOposition + 1) & "/" & WOcount

    End Sub


    Private Sub Frm_Wocabulary_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        WO = False
        WOrec.Clear()
    End Sub

    Private Sub Txt_Num_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Num.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            If Not IsNumeric(Txt_Num.Text) Then
                MsgBox("Tady musí být číslo!", MsgBoxStyle.OKOnly, "Chyba")
                GoTo EventExitSub
            End If
            If CShort(Txt_Num.Text) > WOcount Or CShort(Txt_Num.Text) < 1 Then
                MsgBox("Číslo musí být v rozsahu 1 - počet záznamů!", MsgBoxStyle.OKOnly, "Chyba")
                GoTo EventExitSub
            End If
            KeyAscii = 0
            WOposition = CShort(Txt_Num.Text) - 1
            Call FillForm()
        End If
EventExitSub:
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub Cmd_Print_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Print.Click
        Dim WOrint As New WOPrint
        WOrint.Show()
    End Sub

    Private Sub Cmd_Order_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Order.Click
        OrderControl = "WO"
        FO = New Frm_Ordering
        FO.ShowDialog()
        FO = Nothing
        WOrec.Clear()
        Call WOrecopen()
        WOposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Ins_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Ins.Click
        If Txt_word.Text = "" Then
            MsgBox("Slovo mus být uvedeno!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        Dim tsc As New OleDbCommand
        Dim treader As OleDbDataReader
        Try
            tsc.Connection = Odrialink2
            tsc.CommandText = "select * from Wocabulary where Word = @sk"
            tsc.Parameters.AddWithValue("@sk", Txt_word.Text)
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
                s1 = "INSERT INTO Wocabulary (Word"
                s2 = " VALUES (@sk"
                ic.Parameters.AddWithValue("@sk", Txt_word.Text)

                If Txt_se.Text <> "" Then
                    ic.Parameters.AddWithValue("@se", Trim(Txt_se.Text))
                    s1 = s1 & ", Old_Elvish"
                    s2 = s2 & ", @se"
                End If
                If Txt_ne.Text <> "" Then
                    ic.Parameters.AddWithValue("@ne", Trim(Txt_ne.Text))
                    s1 = s1 & ", New_Elwish"
                    s2 = s2 & ", @ne"
                End If
                If Txt_gob.Text <> "" Then
                    ic.Parameters.AddWithValue("@go", Trim(Txt_gob.Text))
                    s1 = s1 & ", Goblinish"
                    s2 = s2 & ", @go"
                End If
                If Txt_jj1.Text <> "" Then
                    ic.Parameters.AddWithValue("@j1", Trim(Txt_jj1.Text))
                    s1 = s1 & ", Other1"
                    s2 = s2 & ", @j1"
                End If
                If Txt_jj2.Text <> "" Then
                    ic.Parameters.AddWithValue("@j2", Trim(Txt_jj2.Text))
                    s1 = s1 & ", Other2"
                    s2 = s2 & ", @j2"
                End If
                If Txt_jj3.Text <> "" Then
                    ic.Parameters.AddWithValue("@j3", Trim(Txt_jj3.Text))
                    s1 = s1 & ", Other3"
                    s2 = s2 & ", @j3"
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
            WOrec.Clear()
            WOdat.Fill(WOrec, "wo")
            WOcount = WOrec.Tables("wo").Rows.Count
            Call FillForm()
        Else
            treader.Close()
            If MsgBox("Toto slovo již v databázi existuje, chcete jej přepsat?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Upozornění") = MsgBoxResult.Yes Then
                Try
                    Dim s3 As String
                    Dim uc As New OleDbCommand
                    s3 = "UPDATE Wocabulary set Word = @sk, Old_Elvish = @di, New_Elvish = @aa, Goblinish = @us, Other1 = @hi, Other2 = @re, Other3 = @o3 WHERE ID = @ID"
                    uc.Parameters.AddWithValue("@sk", Txt_word.Text)

                    If Txt_se.Text = "" Then
                        uc.Parameters.AddWithValue("@di", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@di", Trim(Txt_se.Text))
                    End If
                    If Txt_ne.Text = "" Then
                        uc.Parameters.AddWithValue("@aa", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@aa", Trim(Txt_ne.Text))
                    End If
                    If Txt_gob.Text = "" Then
                        uc.Parameters.AddWithValue("@us", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@us", Trim(Txt_gob.Text))
                    End If
                    If Txt_jj1.Text = "" Then
                        uc.Parameters.AddWithValue("@hi", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@hi", Trim(Txt_jj1.Text))
                    End If
                    If Txt_jj2.Text = "" Then
                        uc.Parameters.AddWithValue("@re", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@re", Trim(Txt_jj2.Text))
                    End If
                    If Txt_jj3.Text = "" Then
                        uc.Parameters.AddWithValue("@o3", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@o3", Trim(Txt_jj3.Text))
                    End If
                    uc.Parameters.AddWithValue("@ID", WOrec.Tables("wo").Rows(WOposition)("ID"))
                    uc.Connection = Odrialink2
                    uc.CommandText = s3
                    uc.ExecuteScalar()
                Catch ex As Exception
                    MsgBox("Chyba updatu případu: " + ex.Message, , "Pokus o update")
                    Exit Sub
                End Try
                WOrec.Clear()
                WOdat.Fill(WOrec, "wo")
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
        Dim ski, dif, aat, usa, his, rea, jj As Boolean
        se.Connection = Odrialink2
        s = "SELECT * from Wocabulary WHERE "

        If Txt_word.Text <> "" Then
            s = s & "Word LIKE @sk"
            se.Parameters.AddWithValue("@sk", "%" & Txt_word.Text & "%")
            ski = True
        End If
        If Txt_se.Text <> "" Then
            If ski Then
                s = s & " AND "
            End If
            s = s & "Old_Elvish LIKE @di"
            se.Parameters.AddWithValue("@di", "%" & Txt_se.Text & "%")
            dif = True
        End If
        If Txt_ne.Text <> "" Then
            If ski Or dif Then
                s = s & " AND "
            End If
            s = s & "New_Elvish LIKE @aa"
            se.Parameters.AddWithValue("@aa", "%" & Txt_ne.Text & "%")
            aat = True
        End If
        If Txt_gob.Text <> "" Then
            If ski Or dif Or aat Then
                s = s & " AND "
            End If
            s = s & "Goblinish LIKE @us"
            se.Parameters.AddWithValue("@us", "%" & Txt_gob.Text & "%")
            usa = True
        End If
        If Txt_jj1.Text <> "" Then
            If ski Or dif Or aat Or usa Then
                s = s & " AND "
            End If
            s = s & "Other1 LIKE @hi"
            se.Parameters.AddWithValue("@hi", "%" & Txt_jj1.Text & "%")
            his = True
        End If
        If Txt_jj2.Text <> "" Then
            If ski Or dif Or aat Or usa Or his Then
                s = s & " AND "
            End If
            s = s & "Other2 LIKE @re"
            se.Parameters.AddWithValue("@re", "%" & Txt_jj2.Text & "%")
            rea = True
        End If
        If Txt_jj3.Text <> "" Then
            If ski Or dif Or aat Or usa Or his Or rea Then
                s = s & " AND "
            End If
            s = s & "Other3 LIKE @o3"
            se.Parameters.AddWithValue("@o3", "%" & Txt_jj3.Text & "%")
            jj = True
        End If
        WOposition = 0
        If s = "SELECT * from Wocabulary WHERE " Then
            WOrecopen()
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
                If q1 = 1 Then
                    Do
                        If Txt_word.Text = WOrec.Tables("wo").Rows(WOposition)("Word") Then
                            Exit Do
                        End If
                        WOposition += 1
                    Loop Until WOposition + 1 = WOcount
                Else
                    WOdat.SelectCommand = se
                    WOrec.Clear()
                    WOdat.Fill(WOrec, "wo")
                    WOcount = WOrec.Tables("wo").Rows.Count
                    If GC_list = 1 Then
                        If my_sez Is Nothing Then
                            my_sez = New Frm_WOsez
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
        If MsgBox("Opravdu vymazat slovo " & Txt_word.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Upozornění") = MsgBoxResult.Yes Then
            Try
                tsc.Connection = Odrialink2
                tsc.CommandText = "DELETE from Wocabulary WHERE ID = @ID"
                tsc.Parameters.AddWithValue("@ID", WOrec.Tables("wo").Rows(WOposition)("ID"))
                tsc.ExecuteScalar()
            Catch ex As Exception
                Throw New Exception("Chyba při výmazu případu: " + ex.Message)
                Exit Sub
            End Try
        Else
            Exit Sub
        End If
        WOrec.Clear()
        WOdat.Fill(WOrec, "wo")
        WOcount = WOrec.Tables("wo").Rows.Count
        If WOposition = WOcount Then
            WOposition -= 1
        End If
        Call FillForm()
    End Sub

    Private Sub Bt_List_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_List.Click
        If my_sez Is Nothing Then
            my_sez = New Frm_WOsez
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
        Me.BackColor = Color.FromArgb(FWOB)
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
        Label1.ForeColor = Color.FromArgb(FWOFO)
        Label2.ForeColor = Color.FromArgb(FWOFO)
        Label3.ForeColor = Color.FromArgb(FWOFO)
        Label4.ForeColor = Color.FromArgb(FWOFO)
        Label5.ForeColor = Color.FromArgb(FWOFO)
        Label6.ForeColor = Color.FromArgb(FWOFO)
        Label7.ForeColor = Color.FromArgb(FWOFO)
        Txt_Num.ForeColor = Color.FromArgb(FWOFO)
        Txt_word.ForeColor = Color.FromArgb(FWOFO)
        Txt_se.ForeColor = Color.FromArgb(FWOFO)
        Txt_ne.ForeColor = Color.FromArgb(FWOFO)
        Txt_gob.ForeColor = Color.FromArgb(FWOFO)
        Txt_jj1.ForeColor = Color.FromArgb(FWOFO)
        Txt_jj2.ForeColor = Color.FromArgb(FWOFO)
        Txt_jj3.ForeColor = Color.FromArgb(FWOFO)

    End Sub
End Class