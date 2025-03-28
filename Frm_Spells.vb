Option Strict Off
Option Explicit On 
Imports System.Data.oledb
Friend Class Frm_Spells
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
	Public WithEvents Cmd_Order As System.Windows.Forms.Button
	Public WithEvents Cmd_Print As System.Windows.Forms.Button
	Public WithEvents Txt_Num As System.Windows.Forms.TextBox
	Public WithEvents Cmd_New As System.Windows.Forms.Button
	Public WithEvents Cmd_Find As System.Windows.Forms.Button
	Public WithEvents Cmd_Del As System.Windows.Forms.Button
	Public WithEvents Cmd_Ins As System.Windows.Forms.Button
	Public WithEvents Cmd_Last As System.Windows.Forms.Button
	Public WithEvents Cmd_Forward As System.Windows.Forms.Button
	Public WithEvents Cmd_Back As System.Windows.Forms.Button
	Public WithEvents Cmd_First As System.Windows.Forms.Button
	Public WithEvents Txt_T4 As System.Windows.Forms.TextBox
	Public WithEvents Txt_T3 As System.Windows.Forms.TextBox
	Public WithEvents Txt_T2 As System.Windows.Forms.TextBox
	Public WithEvents Txt_T1 As System.Windows.Forms.TextBox
	Public WithEvents Txt_Popis As System.Windows.Forms.TextBox
	Public WithEvents Txt_Date As System.Windows.Forms.TextBox
	Public WithEvents Txt_Unava As System.Windows.Forms.TextBox
	Public WithEvents Txt_Cas As System.Windows.Forms.TextBox
	Public WithEvents Txt_Nar As System.Windows.Forms.TextBox
	Public WithEvents Txt_Spellcast As System.Windows.Forms.TextBox
	Public WithEvents Txt_Zar As System.Windows.Forms.TextBox
	Public WithEvents Txt_Rozsah As System.Windows.Forms.TextBox
	Public WithEvents Txt_Dosah As System.Windows.Forms.TextBox
	Public WithEvents Txt_Trv As System.Windows.Forms.TextBox
	Public WithEvents Txt_Vyvol As System.Windows.Forms.TextBox
	Public WithEvents Txt_Magenergy As System.Windows.Forms.TextBox
	Public WithEvents Txt_Spellczech As System.Windows.Forms.TextBox
	Public WithEvents Txt_Spellname As System.Windows.Forms.TextBox
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Spells))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Cmd_Order = New System.Windows.Forms.Button
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Cmd_New = New System.Windows.Forms.Button
        Me.Cmd_Find = New System.Windows.Forms.Button
        Me.Cmd_Del = New System.Windows.Forms.Button
        Me.Cmd_Ins = New System.Windows.Forms.Button
        Me.Cmd_Last = New System.Windows.Forms.Button
        Me.Cmd_Forward = New System.Windows.Forms.Button
        Me.Cmd_Back = New System.Windows.Forms.Button
        Me.Cmd_First = New System.Windows.Forms.Button
        Me.Txt_Num = New System.Windows.Forms.TextBox
        Me.Txt_T4 = New System.Windows.Forms.TextBox
        Me.Txt_T3 = New System.Windows.Forms.TextBox
        Me.Txt_T2 = New System.Windows.Forms.TextBox
        Me.Txt_T1 = New System.Windows.Forms.TextBox
        Me.Txt_Popis = New System.Windows.Forms.TextBox
        Me.Txt_Date = New System.Windows.Forms.TextBox
        Me.Txt_Unava = New System.Windows.Forms.TextBox
        Me.Txt_Cas = New System.Windows.Forms.TextBox
        Me.Txt_Nar = New System.Windows.Forms.TextBox
        Me.Txt_Spellcast = New System.Windows.Forms.TextBox
        Me.Txt_Zar = New System.Windows.Forms.TextBox
        Me.Txt_Rozsah = New System.Windows.Forms.TextBox
        Me.Txt_Dosah = New System.Windows.Forms.TextBox
        Me.Txt_Trv = New System.Windows.Forms.TextBox
        Me.Txt_Vyvol = New System.Windows.Forms.TextBox
        Me.Txt_Magenergy = New System.Windows.Forms.TextBox
        Me.Txt_Spellczech = New System.Windows.Forms.TextBox
        Me.Txt_Spellname = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
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
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_Exit.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Exit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(881, 665)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Exit.Size = New System.Drawing.Size(61, 156)
        Me.Cmd_Exit.TabIndex = 45
        Me.Cmd_Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Exit, "Zavřít toto okno")
        Me.Cmd_Exit.UseVisualStyleBackColor = False
        '
        'Cmd_Order
        '
        Me.Cmd_Order.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Order.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Order.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Order.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Order.Location = New System.Drawing.Point(782, 246)
        Me.Cmd_Order.Name = "Cmd_Order"
        Me.Cmd_Order.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Order.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_Order.TabIndex = 44
        Me.Cmd_Order.Text = "ŘAZENÍ"
        Me.ToolTip1.SetToolTip(Me.Cmd_Order, "Změnit parametry řazení kouzel")
        Me.Cmd_Order.UseVisualStyleBackColor = False
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.Cyan
        Me.Cmd_Print.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Print.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Print.Location = New System.Drawing.Point(782, 199)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Print.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_Print.TabIndex = 43
        Me.Cmd_Print.Text = "TISK"
        Me.ToolTip1.SetToolTip(Me.Cmd_Print, "Tisk kouzla anebo sestavy")
        Me.Cmd_Print.UseVisualStyleBackColor = False
        '
        'Cmd_New
        '
        Me.Cmd_New.BackColor = System.Drawing.Color.White
        Me.Cmd_New.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_New.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_New.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_New.Location = New System.Drawing.Point(782, 152)
        Me.Cmd_New.Name = "Cmd_New"
        Me.Cmd_New.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_New.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_New.TabIndex = 41
        Me.Cmd_New.Text = "NOVÉ"
        Me.ToolTip1.SetToolTip(Me.Cmd_New, "Vymaže pole, příprava na vepsání nového kouzla")
        Me.Cmd_New.UseVisualStyleBackColor = False
        '
        'Cmd_Find
        '
        Me.Cmd_Find.BackColor = System.Drawing.Color.Yellow
        Me.Cmd_Find.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Find.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Find.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Find.Location = New System.Drawing.Point(585, 246)
        Me.Cmd_Find.Name = "Cmd_Find"
        Me.Cmd_Find.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Find.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_Find.TabIndex = 40
        Me.Cmd_Find.Text = "NAJÍT"
        Me.ToolTip1.SetToolTip(Me.Cmd_Find, "Najít kouzlo")
        Me.Cmd_Find.UseVisualStyleBackColor = False
        '
        'Cmd_Del
        '
        Me.Cmd_Del.BackColor = System.Drawing.Color.Red
        Me.Cmd_Del.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Del.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Del.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Del.Location = New System.Drawing.Point(585, 199)
        Me.Cmd_Del.Name = "Cmd_Del"
        Me.Cmd_Del.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Del.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_Del.TabIndex = 39
        Me.Cmd_Del.Text = "SMAZAT"
        Me.ToolTip1.SetToolTip(Me.Cmd_Del, "Smazat aktuální kouzlo")
        Me.Cmd_Del.UseVisualStyleBackColor = False
        '
        'Cmd_Ins
        '
        Me.Cmd_Ins.BackColor = System.Drawing.Color.Green
        Me.Cmd_Ins.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Ins.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Ins.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Ins.Location = New System.Drawing.Point(585, 152)
        Me.Cmd_Ins.Name = "Cmd_Ins"
        Me.Cmd_Ins.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Ins.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_Ins.TabIndex = 38
        Me.Cmd_Ins.Text = "VLOŽIT"
        Me.ToolTip1.SetToolTip(Me.Cmd_Ins, "Vložit nové kouzlo anebo updatnout stávající")
        Me.Cmd_Ins.UseVisualStyleBackColor = False
        '
        'Cmd_Last
        '
        Me.Cmd_Last.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_Last.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Last.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Last.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Last.Image = CType(resources.GetObject("Cmd_Last.Image"), System.Drawing.Image)
        Me.Cmd_Last.Location = New System.Drawing.Point(887, 87)
        Me.Cmd_Last.Name = "Cmd_Last"
        Me.Cmd_Last.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Last.Size = New System.Drawing.Size(55, 42)
        Me.Cmd_Last.TabIndex = 37
        Me.Cmd_Last.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Last, "Na konec")
        Me.Cmd_Last.UseVisualStyleBackColor = False
        '
        'Cmd_Forward
        '
        Me.Cmd_Forward.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_Forward.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Forward.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Forward.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Forward.Image = CType(resources.GetObject("Cmd_Forward.Image"), System.Drawing.Image)
        Me.Cmd_Forward.Location = New System.Drawing.Point(835, 87)
        Me.Cmd_Forward.Name = "Cmd_Forward"
        Me.Cmd_Forward.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Forward.Size = New System.Drawing.Size(55, 42)
        Me.Cmd_Forward.TabIndex = 36
        Me.Cmd_Forward.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Forward, "O 1 vpřed")
        Me.Cmd_Forward.UseVisualStyleBackColor = False
        '
        'Cmd_Back
        '
        Me.Cmd_Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_Back.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Back.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Back.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Back.Image = CType(resources.GetObject("Cmd_Back.Image"), System.Drawing.Image)
        Me.Cmd_Back.Location = New System.Drawing.Point(638, 87)
        Me.Cmd_Back.Name = "Cmd_Back"
        Me.Cmd_Back.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Back.Size = New System.Drawing.Size(55, 42)
        Me.Cmd_Back.TabIndex = 35
        Me.Cmd_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Back, "O 1 vzad")
        Me.Cmd_Back.UseVisualStyleBackColor = False
        '
        'Cmd_First
        '
        Me.Cmd_First.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_First.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_First.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_First.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_First.Image = CType(resources.GetObject("Cmd_First.Image"), System.Drawing.Image)
        Me.Cmd_First.Location = New System.Drawing.Point(586, 87)
        Me.Cmd_First.Name = "Cmd_First"
        Me.Cmd_First.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_First.Size = New System.Drawing.Size(55, 42)
        Me.Cmd_First.TabIndex = 34
        Me.Cmd_First.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_First, "Na začátek")
        Me.Cmd_First.UseVisualStyleBackColor = False
        '
        'Txt_Num
        '
        Me.Txt_Num.AcceptsReturn = True
        Me.Txt_Num.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_Num.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Num.Font = New System.Drawing.Font("Arial", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Num.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Num.Location = New System.Drawing.Point(690, 87)
        Me.Txt_Num.MaxLength = 0
        Me.Txt_Num.Name = "Txt_Num"
        Me.Txt_Num.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Num.Size = New System.Drawing.Size(148, 40)
        Me.Txt_Num.TabIndex = 42
        Me.Txt_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_T4
        '
        Me.Txt_T4.AcceptsReturn = True
        Me.Txt_T4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_T4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_T4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_T4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_T4.Location = New System.Drawing.Point(497, 730)
        Me.Txt_T4.MaxLength = 0
        Me.Txt_T4.Multiline = True
        Me.Txt_T4.Name = "Txt_T4"
        Me.Txt_T4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_T4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_T4.Size = New System.Drawing.Size(360, 91)
        Me.Txt_T4.TabIndex = 33
        '
        'Txt_T3
        '
        Me.Txt_T3.AcceptsReturn = True
        Me.Txt_T3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_T3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_T3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_T3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_T3.Location = New System.Drawing.Point(497, 633)
        Me.Txt_T3.MaxLength = 0
        Me.Txt_T3.Multiline = True
        Me.Txt_T3.Name = "Txt_T3"
        Me.Txt_T3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_T3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_T3.Size = New System.Drawing.Size(360, 91)
        Me.Txt_T3.TabIndex = 31
        '
        'Txt_T2
        '
        Me.Txt_T2.AcceptsReturn = True
        Me.Txt_T2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_T2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_T2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_T2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_T2.Location = New System.Drawing.Point(72, 730)
        Me.Txt_T2.MaxLength = 0
        Me.Txt_T2.Multiline = True
        Me.Txt_T2.Name = "Txt_T2"
        Me.Txt_T2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_T2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_T2.Size = New System.Drawing.Size(360, 91)
        Me.Txt_T2.TabIndex = 29
        '
        'Txt_T1
        '
        Me.Txt_T1.AcceptsReturn = True
        Me.Txt_T1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_T1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_T1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_T1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_T1.Location = New System.Drawing.Point(72, 633)
        Me.Txt_T1.MaxLength = 0
        Me.Txt_T1.Multiline = True
        Me.Txt_T1.Name = "Txt_T1"
        Me.Txt_T1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_T1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_T1.Size = New System.Drawing.Size(360, 91)
        Me.Txt_T1.TabIndex = 27
        '
        'Txt_Popis
        '
        Me.Txt_Popis.AcceptsReturn = True
        Me.Txt_Popis.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_Popis.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Popis.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Popis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Popis.Location = New System.Drawing.Point(112, 326)
        Me.Txt_Popis.MaxLength = 0
        Me.Txt_Popis.Multiline = True
        Me.Txt_Popis.Name = "Txt_Popis"
        Me.Txt_Popis.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Popis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Popis.Size = New System.Drawing.Size(830, 291)
        Me.Txt_Popis.TabIndex = 25
        '
        'Txt_Date
        '
        Me.Txt_Date.AcceptsReturn = True
        Me.Txt_Date.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_Date.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Date.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Date.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Date.Location = New System.Drawing.Point(436, 294)
        Me.Txt_Date.MaxLength = 0
        Me.Txt_Date.Name = "Txt_Date"
        Me.Txt_Date.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Date.Size = New System.Drawing.Size(133, 26)
        Me.Txt_Date.TabIndex = 23
        '
        'Txt_Unava
        '
        Me.Txt_Unava.AcceptsReturn = True
        Me.Txt_Unava.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_Unava.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Unava.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Unava.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Unava.Location = New System.Drawing.Point(112, 294)
        Me.Txt_Unava.MaxLength = 0
        Me.Txt_Unava.Name = "Txt_Unava"
        Me.Txt_Unava.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Unava.Size = New System.Drawing.Size(208, 26)
        Me.Txt_Unava.TabIndex = 21
        '
        'Txt_Cas
        '
        Me.Txt_Cas.AcceptsReturn = True
        Me.Txt_Cas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_Cas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Cas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Cas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Cas.Location = New System.Drawing.Point(112, 262)
        Me.Txt_Cas.MaxLength = 0
        Me.Txt_Cas.Name = "Txt_Cas"
        Me.Txt_Cas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Cas.Size = New System.Drawing.Size(208, 26)
        Me.Txt_Cas.TabIndex = 19
        '
        'Txt_Nar
        '
        Me.Txt_Nar.AcceptsReturn = True
        Me.Txt_Nar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_Nar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Nar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Nar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Nar.Location = New System.Drawing.Point(112, 230)
        Me.Txt_Nar.MaxLength = 0
        Me.Txt_Nar.Name = "Txt_Nar"
        Me.Txt_Nar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Nar.Size = New System.Drawing.Size(457, 26)
        Me.Txt_Nar.TabIndex = 17
        '
        'Txt_Spellcast
        '
        Me.Txt_Spellcast.AcceptsReturn = True
        Me.Txt_Spellcast.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_Spellcast.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Spellcast.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Spellcast.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Spellcast.Location = New System.Drawing.Point(454, 198)
        Me.Txt_Spellcast.MaxLength = 0
        Me.Txt_Spellcast.Name = "Txt_Spellcast"
        Me.Txt_Spellcast.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Spellcast.Size = New System.Drawing.Size(115, 26)
        Me.Txt_Spellcast.TabIndex = 15
        '
        'Txt_Zar
        '
        Me.Txt_Zar.AcceptsReturn = True
        Me.Txt_Zar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_Zar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Zar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Zar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Zar.Location = New System.Drawing.Point(112, 198)
        Me.Txt_Zar.MaxLength = 0
        Me.Txt_Zar.Name = "Txt_Zar"
        Me.Txt_Zar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Zar.Size = New System.Drawing.Size(336, 26)
        Me.Txt_Zar.TabIndex = 14
        '
        'Txt_Rozsah
        '
        Me.Txt_Rozsah.AcceptsReturn = True
        Me.Txt_Rozsah.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_Rozsah.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Rozsah.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Rozsah.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Rozsah.Location = New System.Drawing.Point(112, 166)
        Me.Txt_Rozsah.MaxLength = 0
        Me.Txt_Rozsah.Name = "Txt_Rozsah"
        Me.Txt_Rozsah.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Rozsah.Size = New System.Drawing.Size(457, 26)
        Me.Txt_Rozsah.TabIndex = 12
        '
        'Txt_Dosah
        '
        Me.Txt_Dosah.AcceptsReturn = True
        Me.Txt_Dosah.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_Dosah.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Dosah.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Dosah.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Dosah.Location = New System.Drawing.Point(112, 134)
        Me.Txt_Dosah.MaxLength = 0
        Me.Txt_Dosah.Name = "Txt_Dosah"
        Me.Txt_Dosah.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Dosah.Size = New System.Drawing.Size(457, 26)
        Me.Txt_Dosah.TabIndex = 10
        '
        'Txt_Trv
        '
        Me.Txt_Trv.AcceptsReturn = True
        Me.Txt_Trv.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_Trv.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Trv.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Trv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Trv.Location = New System.Drawing.Point(112, 102)
        Me.Txt_Trv.MaxLength = 0
        Me.Txt_Trv.Name = "Txt_Trv"
        Me.Txt_Trv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Trv.Size = New System.Drawing.Size(457, 26)
        Me.Txt_Trv.TabIndex = 8
        '
        'Txt_Vyvol
        '
        Me.Txt_Vyvol.AcceptsReturn = True
        Me.Txt_Vyvol.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_Vyvol.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Vyvol.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Vyvol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Vyvol.Location = New System.Drawing.Point(112, 70)
        Me.Txt_Vyvol.MaxLength = 0
        Me.Txt_Vyvol.Name = "Txt_Vyvol"
        Me.Txt_Vyvol.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Vyvol.Size = New System.Drawing.Size(457, 26)
        Me.Txt_Vyvol.TabIndex = 6
        '
        'Txt_Magenergy
        '
        Me.Txt_Magenergy.AcceptsReturn = True
        Me.Txt_Magenergy.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_Magenergy.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Magenergy.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Magenergy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Magenergy.Location = New System.Drawing.Point(112, 38)
        Me.Txt_Magenergy.MaxLength = 0
        Me.Txt_Magenergy.Name = "Txt_Magenergy"
        Me.Txt_Magenergy.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Magenergy.Size = New System.Drawing.Size(633, 26)
        Me.Txt_Magenergy.TabIndex = 4
        '
        'Txt_Spellczech
        '
        Me.Txt_Spellczech.AcceptsReturn = True
        Me.Txt_Spellczech.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_Spellczech.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Spellczech.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Spellczech.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Spellczech.Location = New System.Drawing.Point(618, 5)
        Me.Txt_Spellczech.MaxLength = 0
        Me.Txt_Spellczech.Name = "Txt_Spellczech"
        Me.Txt_Spellczech.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Spellczech.Size = New System.Drawing.Size(329, 26)
        Me.Txt_Spellczech.TabIndex = 2
        '
        'Txt_Spellname
        '
        Me.Txt_Spellname.AcceptsReturn = True
        Me.Txt_Spellname.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_Spellname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Spellname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Spellname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Spellname.Location = New System.Drawing.Point(86, 6)
        Me.Txt_Spellname.MaxLength = 0
        Me.Txt_Spellname.Name = "Txt_Spellname"
        Me.Txt_Spellname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Spellname.Size = New System.Drawing.Size(526, 26)
        Me.Txt_Spellname.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(450, 731)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(41, 27)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "T4"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(450, 633)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(41, 17)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "T3"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(18, 730)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(33, 17)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "T2"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(18, 634)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(43, 31)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "T1"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(8, 326)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(89, 17)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Popis"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(348, 297)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(65, 17)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Datum"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(8, 297)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(97, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Únava"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(9, 265)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(97, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Čas"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(9, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(97, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Náročnost"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(8, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(97, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Zařazení"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(9, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(97, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Rozsah"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(9, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(89, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Dosah"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(97, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Trvání"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(9, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Vyvolání"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(9, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Magenergie"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kouzlo"
        '
        'Bt_List
        '
        Me.Bt_List.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Bt_List.Image = CType(resources.GetObject("Bt_List.Image"), System.Drawing.Image)
        Me.Bt_List.Location = New System.Drawing.Point(12, 357)
        Me.Bt_List.Name = "Bt_List"
        Me.Bt_List.Size = New System.Drawing.Size(93, 260)
        Me.Bt_List.TabIndex = 46
        Me.Bt_List.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Frm_Spells
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(954, 834)
        Me.Controls.Add(Me.Bt_List)
        Me.Controls.Add(Me.Cmd_Exit)
        Me.Controls.Add(Me.Cmd_Order)
        Me.Controls.Add(Me.Cmd_Print)
        Me.Controls.Add(Me.Txt_Num)
        Me.Controls.Add(Me.Cmd_New)
        Me.Controls.Add(Me.Cmd_Find)
        Me.Controls.Add(Me.Cmd_Del)
        Me.Controls.Add(Me.Cmd_Ins)
        Me.Controls.Add(Me.Cmd_Last)
        Me.Controls.Add(Me.Cmd_Forward)
        Me.Controls.Add(Me.Cmd_Back)
        Me.Controls.Add(Me.Cmd_First)
        Me.Controls.Add(Me.Txt_T4)
        Me.Controls.Add(Me.Txt_T3)
        Me.Controls.Add(Me.Txt_T2)
        Me.Controls.Add(Me.Txt_T1)
        Me.Controls.Add(Me.Txt_Popis)
        Me.Controls.Add(Me.Txt_Date)
        Me.Controls.Add(Me.Txt_Unava)
        Me.Controls.Add(Me.Txt_Cas)
        Me.Controls.Add(Me.Txt_Nar)
        Me.Controls.Add(Me.Txt_Spellcast)
        Me.Controls.Add(Me.Txt_Zar)
        Me.Controls.Add(Me.Txt_Rozsah)
        Me.Controls.Add(Me.Txt_Dosah)
        Me.Controls.Add(Me.Txt_Trv)
        Me.Controls.Add(Me.Txt_Vyvol)
        Me.Controls.Add(Me.Txt_Magenergy)
        Me.Controls.Add(Me.Txt_Spellczech)
        Me.Controls.Add(Me.Txt_Spellname)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
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
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.Name = "Frm_Spells"
        Me.Opacity = 0.9
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "GC AVATAR - Odria Spells"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As Frm_Spells
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Frm_Spells
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Frm_Spells()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal value As Frm_Spells)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region

    Private Sub Frm_SPsez_Unload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles my_sez.Closed
        If Tspell <> "" Then
            SPposition = 0
            Do Until SPrec.Tables("Sp").Rows(SPposition)("Orig_name") = Tspell
                SPposition += 1
            Loop
            FillForm()
            Me.Refresh()
        End If
    End Sub

    Private Sub Cmd_Back_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Back.Click
        SPposition -= 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Del_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Del.Click
        Dim tsc As New OleDbCommand
        If MsgBox("Opravdu vymazat kouzlo " & Txt_Spellname.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Upozornění") = MsgBoxResult.Yes Then
            Try
                tsc.Connection = Odrialink2
                tsc.CommandText = "DELETE from Spells WHERE ID = @ID"
                tsc.Parameters.AddWithValue("@ID", SPrec.Tables("Sp").Rows(SPposition)("ID"))
                tsc.ExecuteScalar()
            Catch ex As Exception
                Throw New Exception("Chyba při výmazu případu: " + ex.Message)
                Exit Sub
            End Try
        Else
            Exit Sub
        End If
        SPrec.Clear()
        SPdat.Fill(SPrec, "Sp")
        SPcount = SPrec.Tables("Sp").Rows.Count
        If SPposition = SPcount Then
            SPposition -= 1
        End If
        Call FillForm()
    End Sub

    Private Sub Cmd_Exit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Cmd_Find_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Find.Click
        Dim SPse As New OleDbCommand
        Dim SPre As OleDbDataReader
        Dim s As String
        Dim q1 As Long
        Dim na, cz, ma, vy, dos, ro, za, sc, nc, ti, fa, po As Boolean
        SPse.Connection = Odrialink2
        Txt_Spellname.Text = Txt_Spellname.Text.ToUpper()
        s = "SELECT * from Spells WHERE "
        If Txt_Spellname.Text <> "" Then
            s = s & "Orig_name LIKE @Orig_name"
            SPse.Parameters.AddWithValue("@Orig_name", "%" & Trim(Txt_Spellname.Text) & "%")
            na = True
        End If
        If Txt_Spellczech.Text <> "" Then
            If na Then
                s = s & " AND "
            End If
            s = s & "Czech_name LIKE @Czech_name"
            SPse.Parameters.AddWithValue("@Czech_name", "%" & Trim(Txt_Spellczech.Text) & "%")
            cz = True
        End If
        If Txt_Magenergy.Text <> "" Then
            If na Or cz Then
                s = s & " AND "
            End If
            s = s & "Magenergy LIKE @Magenergy"
            SPse.Parameters.AddWithValue("@Magenergy", "%" & Trim(Txt_Magenergy.Text) & "%")
            ma = True
        End If
        If Txt_Vyvol.Text <> "" Then
            If na Or cz Or ma Then
                s = s & " AND "
            End If
            s = s & "Cast_rounds LIKE @Cast_rounds"
            SPse.Parameters.AddWithValue("@Cast_rounds", "%" & Trim(Txt_Vyvol.Text) & "%")
            vy = True
        End If
        If Txt_Dosah.Text <> "" Then
            If na Or cz Or ma Or vy Then
                s = s & " AND "
            End If
            s = s & "Reach LIKE @Reach"
            SPse.Parameters.AddWithValue("@Reach", "%" & Trim(Txt_Dosah.Text) & "%")
            dos = True
        End If
        If Txt_Rozsah.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Then
                s = s & " AND "
            End If
            s = s & "Affect LIKE @Affect"
            SPse.Parameters.AddWithValue("@Affect", "%" & Trim(Txt_Rozsah.Text) & "%")
            ro = True
        End If
        If Txt_Zar.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Then
                s = s & " AND "
            End If
            s = s & "Spell_type LIKE @Spell_type"
            SPse.Parameters.AddWithValue("@Spell_type", "%" & Trim(Txt_Zar.Text) & "%")
            za = True
        End If
        If Txt_Spellcast.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Then
                s = s & " AND "
            End If
            s = s & "Spelling_cast LIKE @Spelling_cast"
            SPse.Parameters.AddWithValue("@Spelling_cast", "%" & Trim(Txt_Spellcast.Text) & "%")
            sc = True
        End If
        If Txt_Nar.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Then
                s = s & " AND "
            End If
            s = s & "Difficulty LIKE @Difficulty"
            SPse.Parameters.AddWithValue("@Difficulty", "%" & Trim(Txt_Nar.Text) & "%")
            nc = True
        End If
        If Txt_Cas.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Then
                s = s & " AND "
            End If
            s = s & "Cast_time = @Cast_time"
            SPse.Parameters.AddWithValue("@Cast_time", Trim(Txt_Cas.Text))
            ti = True
        End If
        If Txt_Unava.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Then
                s = s & " AND "
            End If
            s = s & "Fatigue = @Fatigue"
            SPse.Parameters.AddWithValue("@Fatigue", Trim(Txt_Unava.Text))
            fa = True
        End If
        If Txt_Popis.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Then
                s = s & " AND "
            End If
            s = s & "Texto LIKE @Texto"
            SPse.Parameters.AddWithValue("@Texto", "%" & Trim(Txt_Popis.Text) & "%")
            po = True
        End If
        SPposition = 0
        If s = "SELECT * from Spells WHERE " Then
            SPrecopen()
            FillForm()
            Exit Sub
        End If
        Try
            SPse.CommandText = s
            SPre = SPse.ExecuteReader
            If SPre.HasRows Then
                q1 = 0
                While SPre.Read()
                    q1 += 1
                End While
                SPre.Close()
                If q1 = 1 Then
                    Do
                        If Txt_Spellname.Text = SPrec.Tables("Sp").Rows(SPposition)("Orig_name") Then
                            Exit Do
                        End If
                        SPposition += 1
                    Loop Until SPposition + 1 = SPcount
                Else
                    SPdat.SelectCommand = SPse
                    SPrec.Clear()
                    SPdat.Fill(SPrec, "Sp")
                    SPcount = SPrec.Tables("Sp").Rows.Count
                    If GC_list = 1 Then
                        If my_sez Is Nothing Then
                            my_sez = New Frm_SPsez
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
                SPre.Close()
                MsgBox("Žádný záznam neodpovídá zvoleným parametrům.", , "Nenalezeno")
                Exit Sub
            End If
            SPre.Close()
        Catch ex As Exception
            MsgBox("Chyba při čtení databáze." + ex.Message, , "Chyba")
            Exit Sub
        End Try

        Call FillForm()
    End Sub

    Private Sub Cmd_First_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_First.Click
        SPposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Forward_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Forward.Click
        SPposition += 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Ins_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Ins.Click
        If Txt_Spellname.Text = "" Then
            MsgBox("Kouzlo musí mít jméno!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        If Txt_Date.Text = "" Then
            If MsgBox("U kouzla musí být uvedeno datum vytvoření! Chcete zadat dnešní datum " & Today & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Chyba") = MsgBoxResult.Yes Then
                Txt_Date.Text = CStr(Today)
            Else
                Exit Sub
            End If
        End If
        Txt_Spellname.Text = Txt_Spellname.Text.ToUpper()
        Dim tsc As New OleDbCommand
        Dim treader As OleDbDataReader
        Try
            tsc.Connection = Odrialink2
            tsc.CommandText = "select * from spells where Orig_name = @on"
            tsc.Parameters.AddWithValue("@on", Txt_Spellname.Text)
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
                s1 = "INSERT INTO Spells (Orig_name"
                s2 = " VALUES (@Orig_name"
                ic.Parameters.AddWithValue("@Orig_name", Trim(Txt_Spellname.Text))
                If Txt_Spellczech.Text <> "" Then
                    ic.Parameters.AddWithValue("@Czech_name", Txt_Spellczech.Text)
                    s1 = s1 & ", Czech_name"
                    s2 = s2 & ", @Czech_name"
                End If
                If Txt_Magenergy.Text <> "" Then
                    ic.Parameters.AddWithValue("@Magenergy", Txt_Magenergy.Text)
                    s1 = s1 & ", Magenergy"
                    s2 = s2 & ", @Magenergy"
                End If
                If Txt_Vyvol.Text <> "" Then
                    ic.Parameters.AddWithValue("@Cast_rounds", Txt_Vyvol.Text)
                    s1 = s1 & ", Cast_rounds"
                    s2 = s2 & ", @Cast_rounds"
                End If
                If Txt_Trv.Text <> "" Then
                    ic.Parameters.AddWithValue("@Duration", Txt_Trv.Text)
                    s1 = s1 & ", Duration"
                    s2 = s2 & ", @Duration"
                End If
                If Txt_Dosah.Text <> "" Then
                    ic.Parameters.AddWithValue("@Reach", Txt_Dosah.Text)
                    s1 = s1 & ", Reach"
                    s2 = s2 & ", @Reach"
                End If
                If Txt_Rozsah.Text <> "" Then
                    ic.Parameters.AddWithValue("@Affect", Txt_Rozsah.Text)
                    s1 = s1 & ", Affect"
                    s2 = s2 & ", @Affect"
                End If
                If Txt_Zar.Text <> "" Then
                    ic.Parameters.AddWithValue("@Spell_type", Txt_Zar.Text)
                    s1 = s1 & ", Spell_type"
                    s2 = s2 & ", @Spell_type"
                End If
                If Txt_Spellcast.Text <> "" Then
                    ic.Parameters.AddWithValue("@Spelling_cast", Txt_Spellcast.Text)
                    s1 = s1 & ", Spelling_cast"
                    s2 = s2 & ", @Spelling_cast"
                End If
                If Txt_Nar.Text <> "" Then
                    ic.Parameters.AddWithValue("@Difficulty", Txt_Nar.Text)
                    s1 = s1 & ", Difficulty"
                    s2 = s2 & ", @Difficulty"
                End If
                If Txt_Cas.Text <> "" Then
                    ic.Parameters.AddWithValue("@Cast_time", Txt_Cas.Text)
                    s1 = s1 & ", Cast_time"
                    s2 = s2 & ", @Cast_time"
                End If
                If Txt_Unava.Text <> "" Then
                    ic.Parameters.AddWithValue("@Fatigue", Txt_Unava.Text)
                    s1 = s1 & ", Fatigue"
                    s2 = s2 & ", @Fatigue"
                End If
                If Txt_Popis.Text <> "" Then
                    ic.Parameters.AddWithValue("@Texto", Txt_Popis.Text)
                    s1 = s1 & ", Texto"
                    s2 = s2 & ", @Texto"
                End If
                ic.Parameters.AddWithValue("@DateCre", Txt_Date.Text)
                s1 = s1 & ", DateCre"
                s2 = s2 & ", @DateCre"
                If Txt_T1.Text <> "" Then
                    ic.Parameters.AddWithValue("@t1", Txt_T1.Text)
                    s1 = s1 & ", t1"
                    s2 = s2 & ", @t1"
                End If
                If Txt_T2.Text <> "" Then
                    ic.Parameters.AddWithValue("@t2", Txt_T2.Text)
                    s1 = s1 & ", t2"
                    s2 = s2 & ", @t2"
                End If
                If Txt_T3.Text <> "" Then
                    ic.Parameters.AddWithValue("@t3", Txt_T3.Text)
                    s1 = s1 & ", t3"
                    s2 = s2 & ", @t3"
                End If
                If Txt_T4.Text <> "" Then
                    ic.Parameters.AddWithValue("@t4", Txt_T4.Text)
                    s1 = s1 & ", t4"
                    s2 = s2 & ", @t4"
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
            SPrec.Clear()
            SPdat.Fill(SPrec, "Sp")
            SPcount = SPrec.Tables("Sp").Rows.Count
            Call FillForm()
        Else
            treader.Close()
            If MsgBox("Kouzlo tohoto jména již v databázi existuje, chcete jej přepsat?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Upozornění") = MsgBoxResult.Yes Then
                Try
                    Dim s3 As String
                    Dim uc As New OleDbCommand
                    s3 = "UPDATE Spells set Orig_name = @Orig_name, Czech_name = @Czech_name, Magenergy = @Magenergy, Cast_rounds = @Cast_rounds, Duration = @Duration, Reach = @Reach, Affect = @Affect, Spell_type = @Spell_type, Spelling_cast = @Spelling_cast, Difficulty = @Difficulty, Cast_time = @Cast_time, Fatigue = @Fatigue, Texto = @Texto, DateCre = @DateCre, t1 = @t1, t2 = @t2, t3 = @t3, t4 = @t4 WHERE ID = @ID"
                    uc.Parameters.AddWithValue("@Orig_name", Trim(Txt_Spellname.Text))
                    If Txt_Spellczech.Text = "" Then
                        uc.Parameters.AddWithValue("@Czech_name", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Czech_name", Trim(Txt_Spellczech.Text))
                    End If
                    If Txt_Magenergy.Text = "" Then
                        uc.Parameters.AddWithValue("@Magenergy", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Magenergy", Trim(Txt_Magenergy.Text))
                    End If
                    If Txt_Vyvol.Text = "" Then
                        uc.Parameters.AddWithValue("@Cast_rounds", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Cast_rounds", Trim(Txt_Vyvol.Text))
                    End If
                    If Txt_Trv.Text = "" Then
                        uc.Parameters.AddWithValue("@Duration", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Duration", Trim(Txt_Trv.Text))
                    End If
                    If Txt_Dosah.Text = "" Then
                        uc.Parameters.AddWithValue("@Reach", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Reach", Trim(Txt_Dosah.Text))
                    End If
                    If Txt_Rozsah.Text = "" Then
                        uc.Parameters.AddWithValue("@Affect", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Affect", Trim(Txt_Rozsah.Text))
                    End If
                    If Txt_Zar.Text = "" Then
                        uc.Parameters.AddWithValue("@Spell_type", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Spell_type", Trim(Txt_Zar.Text))
                    End If
                    If Txt_Spellcast.Text = "" Then
                        uc.Parameters.AddWithValue("@Spelling_cast", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Spelling_cast", Trim(Txt_Spellcast.Text))
                    End If
                    If Txt_Nar.Text = "" Then
                        uc.Parameters.AddWithValue("@Difficulty", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Difficulty", Trim(Txt_Nar.Text))
                    End If
                    If Txt_Cas.Text = "" Then
                        uc.Parameters.AddWithValue("@Cast_time", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Cast_time", Trim(Txt_Cas.Text))
                    End If
                    If Txt_Unava.Text = "" Then
                        uc.Parameters.AddWithValue("@Fatigue", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Fatigue", Trim(Txt_Unava.Text))
                    End If
                    If Txt_Popis.Text = "" Then
                        uc.Parameters.AddWithValue("@Texto", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Texto", Trim(Txt_Popis.Text))
                    End If
                    uc.Parameters.AddWithValue("@DateCre", CDate(Txt_Date.Text))
                    If Txt_T1.Text = "" Then
                        uc.Parameters.AddWithValue("@t1", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@t1", Trim(Txt_T1.Text))
                    End If
                    If Txt_T2.Text = "" Then
                        uc.Parameters.AddWithValue("@t2", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@t2", Trim(Txt_T2.Text))
                    End If
                    If Txt_T3.Text = "" Then
                        uc.Parameters.AddWithValue("@t3", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@t3", Trim(Txt_T3.Text))
                    End If
                    If Txt_T4.Text = "" Then
                        uc.Parameters.AddWithValue("@t4", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@t4", Trim(Txt_T4.Text))
                    End If
                    uc.Parameters.AddWithValue("@ID", SPrec.Tables("Sp").Rows(SPposition)("ID"))
                    uc.Connection = Odrialink2
                    uc.CommandText = s3
                    uc.ExecuteScalar()
                Catch ex As Exception
                    MsgBox("Chyba updatu případu: " + ex.Message, , "Pokus o update")
                    Exit Sub
                End Try
                SPrec.Clear()
                SPdat.Fill(SPrec, "Sp")
                Call FillForm()
            Else
                Exit Sub
            End If
        End If

    End Sub

    Private Sub Cmd_Last_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Last.Click
        SPposition = SPcount - 1
        Call FillForm()
    End Sub

    Private Sub Cmd_New_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_New.Click
        Txt_Spellname.Text = ""
        Txt_Spellczech.Text = ""
        Txt_Magenergy.Text = ""
        Txt_Vyvol.Text = ""
        Txt_Trv.Text = ""
        Txt_Dosah.Text = ""
        Txt_Rozsah.Text = ""
        Txt_Zar.Text = ""
        Txt_Spellcast.Text = ""
        Txt_Nar.Text = ""
        Txt_Cas.Text = ""
        Txt_Unava.Text = ""
        Txt_Popis.Text = ""
        Txt_Date.Text = ""
        Txt_T1.Text = ""
        Txt_T2.Text = ""
        Txt_T3.Text = ""
        Txt_T4.Text = ""
        Cmd_Print.Enabled = False
        Cmd_Del.Enabled = False
        Txt_Num.Text = "NEW"

    End Sub

    Private Sub Cmd_Order_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Order.Click
        OrderControl = "SP"
        FO = New Frm_Ordering
        FO.ShowDialog()
        FO = Nothing
        SPrec.Clear()
        Call SPrecopen()
        SPposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Print_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Print.Click
        Dim SPrint As New SPPrint
        SPrint.Show()
    End Sub

    Private Sub Frm_Spells_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim Tpress As String
        Call SPrecopen()
        SPposition = 0
        Tpress = ""
        ApplyColor()
        Call FillForm()
        SP = True
    End Sub


    Sub FillForm()


        Txt_Spellname.Text = SPrec.Tables("Sp").Rows(SPposition)("Orig_name")
        If Not IsDBNull(SPrec.Tables("Sp").Rows(SPposition)("Czech_name")) Then
            Txt_Spellczech.Text = SPrec.Tables("Sp").Rows(SPposition)("Czech_name")
        Else
            Txt_Spellczech.Text = ""
        End If
        If Not IsDBNull(SPrec.Tables("Sp").Rows(SPposition)("Magenergy")) Then
            Txt_Magenergy.Text = SPrec.Tables("Sp").Rows(SPposition)("Magenergy")
        Else
            Txt_Magenergy.Text = ""
        End If
        If Not IsDBNull(SPrec.Tables("Sp").Rows(SPposition)("Cast_rounds")) Then
            Txt_Vyvol.Text = SPrec.Tables("Sp").Rows(SPposition)("Cast_rounds")
        Else
            Txt_Vyvol.Text = ""
        End If
        If Not IsDBNull(SPrec.Tables("Sp").Rows(SPposition)("Duration")) Then
            Txt_Trv.Text = SPrec.Tables("Sp").Rows(SPposition)("Duration")
        Else
            Txt_Trv.Text = ""
        End If
        If Not IsDBNull(SPrec.Tables("Sp").Rows(SPposition)("Reach")) Then
            Txt_Dosah.Text = SPrec.Tables("Sp").Rows(SPposition)("Reach")
        Else
            Txt_Dosah.Text = ""
        End If
        If Not IsDBNull(SPrec.Tables("Sp").Rows(SPposition)("Affect")) Then
            Txt_Rozsah.Text = SPrec.Tables("Sp").Rows(SPposition)("Affect")
        Else
            Txt_Rozsah.Text = ""
        End If
        If Not IsDBNull(SPrec.Tables("Sp").Rows(SPposition)("Spell_type")) Then
            Txt_Zar.Text = SPrec.Tables("Sp").Rows(SPposition)("Spell_type")
        Else
            Txt_Zar.Text = ""
        End If
        If Not IsDBNull(SPrec.Tables("Sp").Rows(SPposition)("Spelling_cast")) Then
            Txt_Spellcast.Text = SPrec.Tables("Sp").Rows(SPposition)("Spelling_cast")
        Else
            Txt_Spellcast.Text = ""
        End If
        If Not IsDBNull(SPrec.Tables("Sp").Rows(SPposition)("Difficulty")) Then
            Txt_Nar.Text = SPrec.Tables("Sp").Rows(SPposition)("Difficulty")
        Else
            Txt_Nar.Text = ""
        End If
        If Not IsDBNull(SPrec.Tables("Sp").Rows(SPposition)("Cast_time")) Then
            Txt_Cas.Text = SPrec.Tables("Sp").Rows(SPposition)("Cast_time")
        Else
            Txt_Cas.Text = ""
        End If
        If Not IsDBNull(SPrec.Tables("Sp").Rows(SPposition)("Fatigue")) Then
            Txt_Unava.Text = SPrec.Tables("Sp").Rows(SPposition)("Fatigue")
        Else
            Txt_Unava.Text = ""
        End If
        If Not IsDBNull(SPrec.Tables("Sp").Rows(SPposition)("Texto")) Then
            Txt_Popis.Text = SPrec.Tables("Sp").Rows(SPposition)("Texto")
        Else
            Txt_Popis.Text = ""
        End If
        Txt_Date.Text = SPrec.Tables("Sp").Rows(SPposition)("DateCre")
        If Not IsDBNull(SPrec.Tables("Sp").Rows(SPposition)("t1")) Then
            Txt_T1.Text = SPrec.Tables("Sp").Rows(SPposition)("t1")
        Else
            Txt_T1.Text = ""
        End If
        If Not IsDBNull(SPrec.Tables("Sp").Rows(SPposition)("t2")) Then
            Txt_T2.Text = SPrec.Tables("Sp").Rows(SPposition)("t2")
        Else
            Txt_T2.Text = ""
        End If
        If Not IsDBNull(SPrec.Tables("Sp").Rows(SPposition)("t3")) Then
            Txt_T3.Text = SPrec.Tables("Sp").Rows(SPposition)("t3")
        Else
            Txt_T3.Text = ""
        End If
        If Not IsDBNull(SPrec.Tables("Sp").Rows(SPposition)("t4")) Then
            Txt_T4.Text = SPrec.Tables("Sp").Rows(SPposition)("t4")
        Else
            Txt_T4.Text = ""
        End If
        If SPposition = 0 Then
            Cmd_Back.Enabled = False
        Else
            Cmd_Back.Enabled = True
        End If
        Cmd_Del.Enabled = True
        Cmd_Find.Enabled = True
        If SPposition + 1 = SPcount Then
            Cmd_Forward.Enabled = False
        Else
            Cmd_Forward.Enabled = True
        End If
        Cmd_Ins.Enabled = True
        Cmd_New.Enabled = True
        Cmd_Print.Enabled = True
        Select Case GC_lrgtext_s
            Case Is = 10
                Txt_Popis.Font = VB6.FontChangeSize(Txt_Popis.Font, 12)
                Txt_T1.Font = VB6.FontChangeSize(Txt_T1.Font, 12)
                Txt_T2.Font = VB6.FontChangeSize(Txt_T2.Font, 12)
                Txt_T3.Font = VB6.FontChangeSize(Txt_T3.Font, 12)
                Txt_T4.Font = VB6.FontChangeSize(Txt_T4.Font, 12)
            Case Is = 12
                Txt_Popis.Font = VB6.FontChangeSize(Txt_Popis.Font, 14)
                Txt_T1.Font = VB6.FontChangeSize(Txt_T1.Font, 14)
                Txt_T2.Font = VB6.FontChangeSize(Txt_T2.Font, 14)
                Txt_T3.Font = VB6.FontChangeSize(Txt_T3.Font, 14)
                Txt_T4.Font = VB6.FontChangeSize(Txt_T4.Font, 14)
            Case Else
                Txt_Popis.Font = VB6.FontChangeSize(Txt_Popis.Font, 10)
                Txt_T1.Font = VB6.FontChangeSize(Txt_T1.Font, 10)
                Txt_T2.Font = VB6.FontChangeSize(Txt_T2.Font, 10)
                Txt_T3.Font = VB6.FontChangeSize(Txt_T3.Font, 10)
                Txt_T4.Font = VB6.FontChangeSize(Txt_T4.Font, 10)
        End Select

        Txt_Num.Text = (SPposition + 1) & "/" & SPcount

    End Sub

    Private Sub Frm_Spells_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        SP = False
        SPrec.Clear()
    End Sub




    Private Sub Txt_Num_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Num.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            If Not IsNumeric(Txt_Num.Text) Then
                MsgBox("Tady musí být číslo!", MsgBoxStyle.OKOnly, "Chyba")
                GoTo EventExitSub
            End If
            If CShort(Txt_Num.Text) > SPcount Or CShort(Txt_Num.Text) < 1 Then
                MsgBox("Číslo musí být v rozsahu 1 - počet záznamů!", MsgBoxStyle.OKOnly, "Chyba")
                GoTo EventExitSub
            End If
            KeyAscii = 0
            SPposition = CShort(Txt_Num.Text) - 1
            Call FillForm()
        End If
EventExitSub:
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub SPrecopen()
        Dim ssc As New OleDbCommand
        ssc.Connection = Odrialink2
        Select Case SPorder
            Case Is = 1
                If SPdirect = 1 Then
                    ssc.CommandText = "select * from Spells order by Orig_name"
                Else
                    ssc.CommandText = "select * from Spells order by Orig_name desc"
                End If
            Case Is = 2
                If SPdirect = 1 Then
                    ssc.CommandText = "select * from Spells order by DateCre, Orig_name"
                Else
                    ssc.CommandText = "select * from Spells order by DateCre, Orig_name desc"
                End If
            Case Is = 3
                If SPdirect = 1 Then
                    ssc.CommandText = "select * from Spells order by Spell_type, Spelling_cast, Orig_name"
                Else
                    ssc.CommandText = "select * from Spells order by Spell_type, Spelling_cast, Orig_name desc"
                End If
        End Select
        SPdat.SelectCommand = ssc
        SPrec.Clear()
        SPdat.Fill(SPrec, "Sp")
        SPcount = SPrec.Tables("Sp").Rows.Count
    End Sub

    Private Sub Bt_List_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_List.Click
        If my_sez Is Nothing Then
            my_sez = New Frm_SPsez
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
        Me.BackColor = Color.FromArgb(FSPB)
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
        Label1.ForeColor = Color.FromArgb(FSPFO)
        Label2.ForeColor = Color.FromArgb(FSPFO)
        Label3.ForeColor = Color.FromArgb(FSPFO)
        Label4.ForeColor = Color.FromArgb(FSPFO)
        Label5.ForeColor = Color.FromArgb(FSPFO)
        Label6.ForeColor = Color.FromArgb(FSPFO)
        Label7.ForeColor = Color.FromArgb(FSPFO)
        Label8.ForeColor = Color.FromArgb(FSPFO)
        Label9.ForeColor = Color.FromArgb(FSPFO)
        Label10.ForeColor = Color.FromArgb(FSPFO)
        Label11.ForeColor = Color.FromArgb(FSPFO)
        Label12.ForeColor = Color.FromArgb(FSPFO)
        Label13.ForeColor = Color.FromArgb(FSPFO)
        Label14.ForeColor = Color.FromArgb(FSPFO)
        Label15.ForeColor = Color.FromArgb(FSPFO)
        Label16.ForeColor = Color.FromArgb(FSPFO)
        Txt_Num.ForeColor = Color.FromArgb(FSPFO)
        Txt_Cas.ForeColor = Color.FromArgb(FSPFO)
        Txt_Date.ForeColor = Color.FromArgb(FSPFO)
        Txt_Dosah.ForeColor = Color.FromArgb(FSPFO)
        Txt_Magenergy.ForeColor = Color.FromArgb(FSPFO)
        Txt_Nar.ForeColor = Color.FromArgb(FSPFO)
        Txt_Popis.ForeColor = Color.FromArgb(FSPFO)
        Txt_Rozsah.ForeColor = Color.FromArgb(FSPFO)
        Txt_Spellcast.ForeColor = Color.FromArgb(FSPFO)
        Txt_Spellczech.ForeColor = Color.FromArgb(FSPFO)
        Txt_Spellname.ForeColor = Color.FromArgb(FSPFO)
        Txt_T1.ForeColor = Color.FromArgb(FSPFO)
        Txt_T2.ForeColor = Color.FromArgb(FSPFO)
        Txt_T3.ForeColor = Color.FromArgb(FSPFO)
        Txt_T4.ForeColor = Color.FromArgb(FSPFO)
        Txt_Trv.ForeColor = Color.FromArgb(FSPFO)
        Txt_Unava.ForeColor = Color.FromArgb(FSPFO)
        Txt_Vyvol.ForeColor = Color.FromArgb(FSPFO)
        Txt_Zar.ForeColor = Color.FromArgb(FSPFO)
    End Sub

End Class