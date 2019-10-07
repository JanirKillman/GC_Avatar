Option Strict Off
Option Explicit On 
Imports System.Data.oledb
Friend Class Frm_Beasts
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
	Public WithEvents Txt_pop As System.Windows.Forms.TextBox
	Public WithEvents Txt_date As System.Windows.Forms.TextBox
	Public WithEvents Txt_ment As System.Windows.Forms.TextBox
	Public WithEvents Txt_mag As System.Windows.Forms.TextBox
	Public WithEvents Txt_beha As System.Windows.Forms.TextBox
	Public WithEvents Txt_res As System.Windows.Forms.TextBox
	Public WithEvents Txt_sdef As System.Windows.Forms.TextBox
	Public WithEvents Txt_satta As System.Windows.Forms.TextBox
	Public WithEvents Txt_def As System.Windows.Forms.TextBox
	Public WithEvents Txt_atta As System.Windows.Forms.TextBox
	Public WithEvents Txt_tre As System.Windows.Forms.TextBox
	Public WithEvents Txt_exp As System.Windows.Forms.TextBox
	Public WithEvents Txt_SM As System.Windows.Forms.TextBox
	Public WithEvents Txt_mg As System.Windows.Forms.TextBox
	Public WithEvents Txt_spd As System.Windows.Forms.TextBox
	Public WithEvents Txt_size As System.Windows.Forms.TextBox
	Public WithEvents Txt_jed As System.Windows.Forms.TextBox
	Public WithEvents Txt_wis As System.Windows.Forms.TextBox
	Public WithEvents Txt_IQ As System.Windows.Forms.TextBox
	Public WithEvents Txt_podl As System.Windows.Forms.TextBox
	Public WithEvents Txt_fodl As System.Windows.Forms.TextBox
	Public WithEvents Txt_ski As System.Windows.Forms.TextBox
	Public WithEvents Txt_dex As System.Windows.Forms.TextBox
	Public WithEvents Txt_str As System.Windows.Forms.TextBox
	Public WithEvents Txt_level As System.Windows.Forms.TextBox
	Public WithEvents Txt_typ As System.Windows.Forms.TextBox
	Public WithEvents Txt_beastname As System.Windows.Forms.TextBox
	Public WithEvents Label27 As System.Windows.Forms.Label
	Public WithEvents Label26 As System.Windows.Forms.Label
	Public WithEvents Label25 As System.Windows.Forms.Label
	Public WithEvents Label24 As System.Windows.Forms.Label
	Public WithEvents Label23 As System.Windows.Forms.Label
	Public WithEvents Label22 As System.Windows.Forms.Label
	Public WithEvents Label21 As System.Windows.Forms.Label
	Public WithEvents Label20 As System.Windows.Forms.Label
	Public WithEvents Label19 As System.Windows.Forms.Label
	Public WithEvents Label18 As System.Windows.Forms.Label
	Public WithEvents Label17 As System.Windows.Forms.Label
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Beasts))
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
        Me.Txt_pop = New System.Windows.Forms.TextBox
        Me.Txt_date = New System.Windows.Forms.TextBox
        Me.Txt_ment = New System.Windows.Forms.TextBox
        Me.Txt_mag = New System.Windows.Forms.TextBox
        Me.Txt_beha = New System.Windows.Forms.TextBox
        Me.Txt_res = New System.Windows.Forms.TextBox
        Me.Txt_sdef = New System.Windows.Forms.TextBox
        Me.Txt_satta = New System.Windows.Forms.TextBox
        Me.Txt_def = New System.Windows.Forms.TextBox
        Me.Txt_atta = New System.Windows.Forms.TextBox
        Me.Txt_tre = New System.Windows.Forms.TextBox
        Me.Txt_exp = New System.Windows.Forms.TextBox
        Me.Txt_SM = New System.Windows.Forms.TextBox
        Me.Txt_mg = New System.Windows.Forms.TextBox
        Me.Txt_spd = New System.Windows.Forms.TextBox
        Me.Txt_size = New System.Windows.Forms.TextBox
        Me.Txt_jed = New System.Windows.Forms.TextBox
        Me.Txt_wis = New System.Windows.Forms.TextBox
        Me.Txt_IQ = New System.Windows.Forms.TextBox
        Me.Txt_podl = New System.Windows.Forms.TextBox
        Me.Txt_fodl = New System.Windows.Forms.TextBox
        Me.Txt_ski = New System.Windows.Forms.TextBox
        Me.Txt_dex = New System.Windows.Forms.TextBox
        Me.Txt_str = New System.Windows.Forms.TextBox
        Me.Txt_level = New System.Windows.Forms.TextBox
        Me.Txt_typ = New System.Windows.Forms.TextBox
        Me.Txt_beastname = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
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
        Me.Cmd_Exit.Location = New System.Drawing.Point(429, 854)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Exit.Size = New System.Drawing.Size(401, 84)
        Me.Cmd_Exit.TabIndex = 65
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
        Me.Cmd_Ins.Location = New System.Drawing.Point(7, 795)
        Me.Cmd_Ins.Name = "Cmd_Ins"
        Me.Cmd_Ins.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Ins.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_Ins.TabIndex = 64
        Me.Cmd_Ins.Text = "VLOŽIT"
        Me.ToolTip1.SetToolTip(Me.Cmd_Ins, "Vložit nové kouzlo anebo updatnout stávající")
        Me.Cmd_Ins.UseVisualStyleBackColor = False
        '
        'Cmd_Del
        '
        Me.Cmd_Del.BackColor = System.Drawing.Color.Red
        Me.Cmd_Del.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Del.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Del.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Del.Location = New System.Drawing.Point(7, 842)
        Me.Cmd_Del.Name = "Cmd_Del"
        Me.Cmd_Del.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Del.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_Del.TabIndex = 63
        Me.Cmd_Del.Text = "SMAZAT"
        Me.ToolTip1.SetToolTip(Me.Cmd_Del, "Smazat aktuální kouzlo")
        Me.Cmd_Del.UseVisualStyleBackColor = False
        '
        'Cmd_Find
        '
        Me.Cmd_Find.BackColor = System.Drawing.Color.Yellow
        Me.Cmd_Find.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Find.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Find.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Find.Location = New System.Drawing.Point(6, 888)
        Me.Cmd_Find.Name = "Cmd_Find"
        Me.Cmd_Find.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Find.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_Find.TabIndex = 62
        Me.Cmd_Find.Text = "NAJÍT"
        Me.ToolTip1.SetToolTip(Me.Cmd_Find, "Najít kouzlo")
        Me.Cmd_Find.UseVisualStyleBackColor = False
        '
        'Cmd_New
        '
        Me.Cmd_New.BackColor = System.Drawing.Color.White
        Me.Cmd_New.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_New.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_New.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_New.Location = New System.Drawing.Point(238, 795)
        Me.Cmd_New.Name = "Cmd_New"
        Me.Cmd_New.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_New.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_New.TabIndex = 61
        Me.Cmd_New.Text = "NOVÁ"
        Me.ToolTip1.SetToolTip(Me.Cmd_New, "Vymaže pole, příprava na vepsání nového kouzla")
        Me.Cmd_New.UseVisualStyleBackColor = False
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.Cyan
        Me.Cmd_Print.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Print.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Print.Location = New System.Drawing.Point(237, 842)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Print.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_Print.TabIndex = 60
        Me.Cmd_Print.Text = "TISK"
        Me.ToolTip1.SetToolTip(Me.Cmd_Print, "Tisk kouzla anebo sestavy")
        Me.Cmd_Print.UseVisualStyleBackColor = False
        '
        'Cmd_Order
        '
        Me.Cmd_Order.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Order.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Order.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Order.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Order.Location = New System.Drawing.Point(237, 888)
        Me.Cmd_Order.Name = "Cmd_Order"
        Me.Cmd_Order.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Order.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_Order.TabIndex = 59
        Me.Cmd_Order.Text = "ŘAZENÍ"
        Me.ToolTip1.SetToolTip(Me.Cmd_Order, "Změnit parametry řazení kouzel")
        Me.Cmd_Order.UseVisualStyleBackColor = False
        '
        'Cmd_Last
        '
        Me.Cmd_Last.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_Last.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Last.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Last.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Last.Image = CType(resources.GetObject("Cmd_Last.Image"), System.Drawing.Image)
        Me.Cmd_Last.Location = New System.Drawing.Point(766, 806)
        Me.Cmd_Last.Name = "Cmd_Last"
        Me.Cmd_Last.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Last.Size = New System.Drawing.Size(55, 42)
        Me.Cmd_Last.TabIndex = 58
        Me.Cmd_Last.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Last, "Na konec")
        Me.Cmd_Last.UseVisualStyleBackColor = False
        '
        'Cmd_Forward
        '
        Me.Cmd_Forward.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_Forward.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Forward.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Forward.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Forward.Image = CType(resources.GetObject("Cmd_Forward.Image"), System.Drawing.Image)
        Me.Cmd_Forward.Location = New System.Drawing.Point(714, 806)
        Me.Cmd_Forward.Name = "Cmd_Forward"
        Me.Cmd_Forward.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Forward.Size = New System.Drawing.Size(55, 42)
        Me.Cmd_Forward.TabIndex = 57
        Me.Cmd_Forward.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Forward, "O 1 vpřed")
        Me.Cmd_Forward.UseVisualStyleBackColor = False
        '
        'Cmd_Back
        '
        Me.Cmd_Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_Back.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Back.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Back.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Back.Image = CType(resources.GetObject("Cmd_Back.Image"), System.Drawing.Image)
        Me.Cmd_Back.Location = New System.Drawing.Point(481, 806)
        Me.Cmd_Back.Name = "Cmd_Back"
        Me.Cmd_Back.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Back.Size = New System.Drawing.Size(55, 42)
        Me.Cmd_Back.TabIndex = 55
        Me.Cmd_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Back, "O 1 vzad")
        Me.Cmd_Back.UseVisualStyleBackColor = False
        '
        'Cmd_First
        '
        Me.Cmd_First.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_First.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_First.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_First.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_First.Image = CType(resources.GetObject("Cmd_First.Image"), System.Drawing.Image)
        Me.Cmd_First.Location = New System.Drawing.Point(429, 806)
        Me.Cmd_First.Name = "Cmd_First"
        Me.Cmd_First.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_First.Size = New System.Drawing.Size(55, 42)
        Me.Cmd_First.TabIndex = 54
        Me.Cmd_First.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_First, "Na začátek")
        Me.Cmd_First.UseVisualStyleBackColor = False
        '
        'Txt_Num
        '
        Me.Txt_Num.AcceptsReturn = True
        Me.Txt_Num.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Num.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Num.Font = New System.Drawing.Font("Arial", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Num.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_Num.Location = New System.Drawing.Point(533, 807)
        Me.Txt_Num.MaxLength = 0
        Me.Txt_Num.Name = "Txt_Num"
        Me.Txt_Num.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Num.Size = New System.Drawing.Size(182, 40)
        Me.Txt_Num.TabIndex = 56
        Me.Txt_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_pop
        '
        Me.Txt_pop.AcceptsReturn = True
        Me.Txt_pop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_pop.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_pop.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_pop.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_pop.Location = New System.Drawing.Point(103, 599)
        Me.Txt_pop.MaxLength = 0
        Me.Txt_pop.Multiline = True
        Me.Txt_pop.Name = "Txt_pop"
        Me.Txt_pop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_pop.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_pop.Size = New System.Drawing.Size(733, 190)
        Me.Txt_pop.TabIndex = 53
        '
        'Txt_date
        '
        Me.Txt_date.AcceptsReturn = True
        Me.Txt_date.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_date.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_date.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_date.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_date.Location = New System.Drawing.Point(103, 556)
        Me.Txt_date.MaxLength = 0
        Me.Txt_date.Name = "Txt_date"
        Me.Txt_date.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_date.Size = New System.Drawing.Size(161, 26)
        Me.Txt_date.TabIndex = 51
        '
        'Txt_ment
        '
        Me.Txt_ment.AcceptsReturn = True
        Me.Txt_ment.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_ment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_ment.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_ment.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_ment.Location = New System.Drawing.Point(447, 530)
        Me.Txt_ment.MaxLength = 0
        Me.Txt_ment.Multiline = True
        Me.Txt_ment.Name = "Txt_ment"
        Me.Txt_ment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_ment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_ment.Size = New System.Drawing.Size(389, 58)
        Me.Txt_ment.TabIndex = 49
        '
        'Txt_mag
        '
        Me.Txt_mag.AcceptsReturn = True
        Me.Txt_mag.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_mag.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_mag.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_mag.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_mag.Location = New System.Drawing.Point(447, 498)
        Me.Txt_mag.MaxLength = 0
        Me.Txt_mag.Name = "Txt_mag"
        Me.Txt_mag.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_mag.Size = New System.Drawing.Size(389, 26)
        Me.Txt_mag.TabIndex = 47
        '
        'Txt_beha
        '
        Me.Txt_beha.AcceptsReturn = True
        Me.Txt_beha.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_beha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_beha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_beha.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_beha.Location = New System.Drawing.Point(447, 434)
        Me.Txt_beha.MaxLength = 0
        Me.Txt_beha.Multiline = True
        Me.Txt_beha.Name = "Txt_beha"
        Me.Txt_beha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_beha.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_beha.Size = New System.Drawing.Size(389, 58)
        Me.Txt_beha.TabIndex = 45
        '
        'Txt_res
        '
        Me.Txt_res.AcceptsReturn = True
        Me.Txt_res.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_res.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_res.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_res.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_res.Location = New System.Drawing.Point(447, 370)
        Me.Txt_res.MaxLength = 0
        Me.Txt_res.Multiline = True
        Me.Txt_res.Name = "Txt_res"
        Me.Txt_res.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_res.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_res.Size = New System.Drawing.Size(389, 58)
        Me.Txt_res.TabIndex = 43
        '
        'Txt_sdef
        '
        Me.Txt_sdef.AcceptsReturn = True
        Me.Txt_sdef.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_sdef.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_sdef.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_sdef.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_sdef.Location = New System.Drawing.Point(447, 287)
        Me.Txt_sdef.MaxLength = 0
        Me.Txt_sdef.Multiline = True
        Me.Txt_sdef.Name = "Txt_sdef"
        Me.Txt_sdef.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_sdef.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_sdef.Size = New System.Drawing.Size(389, 77)
        Me.Txt_sdef.TabIndex = 41
        '
        'Txt_satta
        '
        Me.Txt_satta.AcceptsReturn = True
        Me.Txt_satta.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_satta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_satta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_satta.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_satta.Location = New System.Drawing.Point(447, 218)
        Me.Txt_satta.MaxLength = 0
        Me.Txt_satta.Multiline = True
        Me.Txt_satta.Name = "Txt_satta"
        Me.Txt_satta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_satta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_satta.Size = New System.Drawing.Size(389, 63)
        Me.Txt_satta.TabIndex = 39
        '
        'Txt_def
        '
        Me.Txt_def.AcceptsReturn = True
        Me.Txt_def.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_def.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_def.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_def.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_def.Location = New System.Drawing.Point(447, 144)
        Me.Txt_def.MaxLength = 0
        Me.Txt_def.Multiline = True
        Me.Txt_def.Name = "Txt_def"
        Me.Txt_def.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_def.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_def.Size = New System.Drawing.Size(389, 68)
        Me.Txt_def.TabIndex = 37
        '
        'Txt_atta
        '
        Me.Txt_atta.AcceptsReturn = True
        Me.Txt_atta.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_atta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_atta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_atta.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_atta.Location = New System.Drawing.Point(447, 63)
        Me.Txt_atta.MaxLength = 0
        Me.Txt_atta.Multiline = True
        Me.Txt_atta.Name = "Txt_atta"
        Me.Txt_atta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_atta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_atta.Size = New System.Drawing.Size(389, 75)
        Me.Txt_atta.TabIndex = 35
        '
        'Txt_tre
        '
        Me.Txt_tre.AcceptsReturn = True
        Me.Txt_tre.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_tre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_tre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_tre.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_tre.Location = New System.Drawing.Point(103, 520)
        Me.Txt_tre.MaxLength = 0
        Me.Txt_tre.Name = "Txt_tre"
        Me.Txt_tre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_tre.Size = New System.Drawing.Size(161, 26)
        Me.Txt_tre.TabIndex = 33
        '
        'Txt_exp
        '
        Me.Txt_exp.AcceptsReturn = True
        Me.Txt_exp.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_exp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_exp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_exp.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_exp.Location = New System.Drawing.Point(120, 488)
        Me.Txt_exp.MaxLength = 0
        Me.Txt_exp.Name = "Txt_exp"
        Me.Txt_exp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_exp.Size = New System.Drawing.Size(144, 26)
        Me.Txt_exp.TabIndex = 31
        '
        'Txt_SM
        '
        Me.Txt_SM.AcceptsReturn = True
        Me.Txt_SM.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_SM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_SM.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_SM.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_SM.Location = New System.Drawing.Point(120, 456)
        Me.Txt_SM.MaxLength = 0
        Me.Txt_SM.Name = "Txt_SM"
        Me.Txt_SM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_SM.Size = New System.Drawing.Size(144, 26)
        Me.Txt_SM.TabIndex = 29
        '
        'Txt_mg
        '
        Me.Txt_mg.AcceptsReturn = True
        Me.Txt_mg.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_mg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_mg.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_mg.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_mg.Location = New System.Drawing.Point(136, 424)
        Me.Txt_mg.MaxLength = 0
        Me.Txt_mg.Name = "Txt_mg"
        Me.Txt_mg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_mg.Size = New System.Drawing.Size(128, 26)
        Me.Txt_mg.TabIndex = 27
        '
        'Txt_spd
        '
        Me.Txt_spd.AcceptsReturn = True
        Me.Txt_spd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_spd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_spd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_spd.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_spd.Location = New System.Drawing.Point(136, 392)
        Me.Txt_spd.MaxLength = 0
        Me.Txt_spd.Name = "Txt_spd"
        Me.Txt_spd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_spd.Size = New System.Drawing.Size(86, 26)
        Me.Txt_spd.TabIndex = 25
        '
        'Txt_size
        '
        Me.Txt_size.AcceptsReturn = True
        Me.Txt_size.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_size.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_size.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_size.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_size.Location = New System.Drawing.Point(120, 360)
        Me.Txt_size.MaxLength = 0
        Me.Txt_size.Name = "Txt_size"
        Me.Txt_size.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_size.Size = New System.Drawing.Size(102, 26)
        Me.Txt_size.TabIndex = 23
        '
        'Txt_jed
        '
        Me.Txt_jed.AcceptsReturn = True
        Me.Txt_jed.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_jed.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_jed.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_jed.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_jed.Location = New System.Drawing.Point(120, 328)
        Me.Txt_jed.MaxLength = 0
        Me.Txt_jed.Name = "Txt_jed"
        Me.Txt_jed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_jed.Size = New System.Drawing.Size(102, 26)
        Me.Txt_jed.TabIndex = 21
        '
        'Txt_wis
        '
        Me.Txt_wis.AcceptsReturn = True
        Me.Txt_wis.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_wis.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_wis.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_wis.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_wis.Location = New System.Drawing.Point(120, 296)
        Me.Txt_wis.MaxLength = 0
        Me.Txt_wis.Name = "Txt_wis"
        Me.Txt_wis.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_wis.Size = New System.Drawing.Size(102, 26)
        Me.Txt_wis.TabIndex = 19
        '
        'Txt_IQ
        '
        Me.Txt_IQ.AcceptsReturn = True
        Me.Txt_IQ.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_IQ.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_IQ.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_IQ.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_IQ.Location = New System.Drawing.Point(120, 264)
        Me.Txt_IQ.MaxLength = 0
        Me.Txt_IQ.Name = "Txt_IQ"
        Me.Txt_IQ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_IQ.Size = New System.Drawing.Size(102, 26)
        Me.Txt_IQ.TabIndex = 17
        '
        'Txt_podl
        '
        Me.Txt_podl.AcceptsReturn = True
        Me.Txt_podl.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_podl.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_podl.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_podl.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_podl.Location = New System.Drawing.Point(120, 232)
        Me.Txt_podl.MaxLength = 0
        Me.Txt_podl.Name = "Txt_podl"
        Me.Txt_podl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_podl.Size = New System.Drawing.Size(102, 26)
        Me.Txt_podl.TabIndex = 15
        '
        'Txt_fodl
        '
        Me.Txt_fodl.AcceptsReturn = True
        Me.Txt_fodl.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_fodl.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_fodl.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_fodl.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_fodl.Location = New System.Drawing.Point(120, 200)
        Me.Txt_fodl.MaxLength = 0
        Me.Txt_fodl.Name = "Txt_fodl"
        Me.Txt_fodl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_fodl.Size = New System.Drawing.Size(102, 26)
        Me.Txt_fodl.TabIndex = 13
        '
        'Txt_ski
        '
        Me.Txt_ski.AcceptsReturn = True
        Me.Txt_ski.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_ski.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_ski.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_ski.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_ski.Location = New System.Drawing.Point(120, 168)
        Me.Txt_ski.MaxLength = 0
        Me.Txt_ski.Name = "Txt_ski"
        Me.Txt_ski.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_ski.Size = New System.Drawing.Size(102, 26)
        Me.Txt_ski.TabIndex = 11
        '
        'Txt_dex
        '
        Me.Txt_dex.AcceptsReturn = True
        Me.Txt_dex.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_dex.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_dex.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_dex.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_dex.Location = New System.Drawing.Point(120, 135)
        Me.Txt_dex.MaxLength = 0
        Me.Txt_dex.Name = "Txt_dex"
        Me.Txt_dex.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_dex.Size = New System.Drawing.Size(102, 26)
        Me.Txt_dex.TabIndex = 9
        '
        'Txt_str
        '
        Me.Txt_str.AcceptsReturn = True
        Me.Txt_str.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_str.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_str.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_str.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_str.Location = New System.Drawing.Point(120, 103)
        Me.Txt_str.MaxLength = 0
        Me.Txt_str.Name = "Txt_str"
        Me.Txt_str.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_str.Size = New System.Drawing.Size(102, 26)
        Me.Txt_str.TabIndex = 7
        '
        'Txt_level
        '
        Me.Txt_level.AcceptsReturn = True
        Me.Txt_level.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_level.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_level.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_level.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_level.Location = New System.Drawing.Point(176, 63)
        Me.Txt_level.MaxLength = 0
        Me.Txt_level.Name = "Txt_level"
        Me.Txt_level.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_level.Size = New System.Drawing.Size(159, 26)
        Me.Txt_level.TabIndex = 5
        '
        'Txt_typ
        '
        Me.Txt_typ.AcceptsReturn = True
        Me.Txt_typ.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_typ.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_typ.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_typ.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_typ.Location = New System.Drawing.Point(599, 24)
        Me.Txt_typ.MaxLength = 0
        Me.Txt_typ.Name = "Txt_typ"
        Me.Txt_typ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_typ.Size = New System.Drawing.Size(237, 26)
        Me.Txt_typ.TabIndex = 3
        '
        'Txt_beastname
        '
        Me.Txt_beastname.AcceptsReturn = True
        Me.Txt_beastname.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_beastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_beastname.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_beastname.ForeColor = System.Drawing.Color.Yellow
        Me.Txt_beastname.Location = New System.Drawing.Point(120, 24)
        Me.Txt_beastname.MaxLength = 0
        Me.Txt_beastname.Name = "Txt_beastname"
        Me.Txt_beastname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_beastname.Size = New System.Drawing.Size(416, 29)
        Me.Txt_beastname.TabIndex = 1
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label27.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Yellow
        Me.Label27.Location = New System.Drawing.Point(12, 599)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(101, 32)
        Me.Label27.TabIndex = 52
        Me.Label27.Text = "Popis"
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Yellow
        Me.Label26.Location = New System.Drawing.Point(12, 556)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(121, 29)
        Me.Label26.TabIndex = 50
        Me.Label26.Text = "Datum "
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Yellow
        Me.Label25.Location = New System.Drawing.Point(333, 536)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(129, 49)
        Me.Label25.TabIndex = 48
        Me.Label25.Text = "Mentální schopnosti"
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Yellow
        Me.Label24.Location = New System.Drawing.Point(341, 498)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(121, 26)
        Me.Label24.TabIndex = 46
        Me.Label24.Text = "Magie"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Yellow
        Me.Label23.Location = New System.Drawing.Point(341, 434)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(113, 32)
        Me.Label23.TabIndex = 44
        Me.Label23.Text = "Chování"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Yellow
        Me.Label22.Location = New System.Drawing.Point(341, 370)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(129, 26)
        Me.Label22.TabIndex = 42
        Me.Label22.Text = "Resistence"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Yellow
        Me.Label21.Location = New System.Drawing.Point(341, 287)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(129, 51)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "Speciální obrany"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Yellow
        Me.Label20.Location = New System.Drawing.Point(341, 224)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(129, 50)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "Speciální útoky"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Yellow
        Me.Label19.Location = New System.Drawing.Point(341, 144)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(113, 33)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "Obrany"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Yellow
        Me.Label18.Location = New System.Drawing.Point(341, 63)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(100, 26)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Útoky"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Yellow
        Me.Label17.Location = New System.Drawing.Point(12, 520)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(85, 29)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Poklady"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Yellow
        Me.Label16.Location = New System.Drawing.Point(12, 488)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(117, 29)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Zkušenost"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Yellow
        Me.Label15.Location = New System.Drawing.Point(12, 456)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(101, 32)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "SM"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Yellow
        Me.Label14.Location = New System.Drawing.Point(12, 424)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(133, 32)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Magenergie"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(12, 392)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(117, 32)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Rychlost"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(12, 360)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(102, 32)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Velikost"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Yellow
        Me.Label11.Location = New System.Drawing.Point(12, 328)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(101, 30)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Jednání"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Yellow
        Me.Label10.Location = New System.Drawing.Point(12, 296)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(102, 26)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Moudrost"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(12, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(69, 26)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "IQ"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(12, 232)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(85, 32)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Podl"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(12, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(85, 26)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fodl"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(12, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(101, 32)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Zručnost"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(12, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(101, 26)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Hbitost"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(12, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(85, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Síla"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(9, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(213, 33)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Životaschopnost"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(542, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(70, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Typ"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(11, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(134, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bestie"
        '
        'Bt_List
        '
        Me.Bt_List.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Bt_List.Image = CType(resources.GetObject("Bt_List.Image"), System.Drawing.Image)
        Me.Bt_List.Location = New System.Drawing.Point(228, 104)
        Me.Bt_List.Name = "Bt_List"
        Me.Bt_List.Size = New System.Drawing.Size(107, 314)
        Me.Bt_List.TabIndex = 66
        Me.Bt_List.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Frm_Beasts
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(848, 951)
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
        Me.Controls.Add(Me.Txt_pop)
        Me.Controls.Add(Me.Txt_date)
        Me.Controls.Add(Me.Txt_ment)
        Me.Controls.Add(Me.Txt_mag)
        Me.Controls.Add(Me.Txt_beha)
        Me.Controls.Add(Me.Txt_res)
        Me.Controls.Add(Me.Txt_sdef)
        Me.Controls.Add(Me.Txt_satta)
        Me.Controls.Add(Me.Txt_def)
        Me.Controls.Add(Me.Txt_atta)
        Me.Controls.Add(Me.Txt_tre)
        Me.Controls.Add(Me.Txt_exp)
        Me.Controls.Add(Me.Txt_SM)
        Me.Controls.Add(Me.Txt_mg)
        Me.Controls.Add(Me.Txt_spd)
        Me.Controls.Add(Me.Txt_size)
        Me.Controls.Add(Me.Txt_jed)
        Me.Controls.Add(Me.Txt_wis)
        Me.Controls.Add(Me.Txt_IQ)
        Me.Controls.Add(Me.Txt_podl)
        Me.Controls.Add(Me.Txt_fodl)
        Me.Controls.Add(Me.Txt_ski)
        Me.Controls.Add(Me.Txt_dex)
        Me.Controls.Add(Me.Txt_str)
        Me.Controls.Add(Me.Txt_level)
        Me.Controls.Add(Me.Txt_typ)
        Me.Controls.Add(Me.Txt_beastname)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
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
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Yellow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.Name = "Frm_Beasts"
        Me.Opacity = 0.9
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "GC AVATAR - Odria Beasts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As Frm_Beasts
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Frm_Beasts
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Frm_Beasts()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal value As Frm_Beasts)
            m_vb6FormDefInstance = value
        End Set
    End Property
#End Region

    Private Sub Frm_BEsez_Unload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles my_sez.Closed
        If Tbe <> "" Then
            BEposition = 0
            Do Until BErec.Tables("be").Rows(BEposition)("B_name") = Tbe
                BEposition += 1
            Loop
            FillForm()
            Me.Refresh()
        End If
    End Sub

    Private Sub Cmd_Back_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Back.Click
        BEposition -= 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Exit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Cmd_First_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_First.Click
        BEposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Forward_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Forward.Click
        BEposition += 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Last_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Last.Click
        BEposition = BEcount - 1
        Call FillForm()
    End Sub

    Private Sub Cmd_New_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_New.Click
        Txt_beastname.Text = ""
        Txt_typ.Text = ""
        Txt_level.Text = ""
        Txt_str.Text = ""
        Txt_atta.Text = ""
        Txt_dex.Text = ""
        Txt_def.Text = ""
        Txt_satta.Text = ""
        Txt_sdef.Text = ""
        Txt_size.Text = ""
        Txt_fodl.Text = ""
        Txt_res.Text = ""
        Txt_IQ.Text = ""
        Txt_date.Text = ""
        Txt_wis.Text = ""
        Txt_ski.Text = ""
        Txt_podl.Text = ""
        Txt_jed.Text = ""
        Txt_mg.Text = ""
        Txt_mag.Text = ""
        Txt_SM.Text = ""
        Txt_ment.Text = ""
        Txt_spd.Text = ""
        Txt_beha.Text = ""
        Txt_exp.Text = ""
        Txt_tre.Text = ""
        Txt_pop.Text = ""
        Cmd_Print.Enabled = False
        Cmd_Del.Enabled = False
        Txt_Num.Text = "NEW"
    End Sub

    Private Sub Frm_Beasts_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Call BErecopen()
        BEposition = 0
        ApplyColor()
        Call FillForm()
        BE = True
    End Sub


    Private Sub BErecopen()
        Dim ssc As New OleDbCommand
        ssc.Connection = Odrialink2
        Select Case BEorder
            Case Is = 1
                If BEdirect = 1 Then
                    ssc.CommandText = "select * from Beasts order by B_name"
                Else
                    ssc.CommandText = "select * from Beasts order by B_name desc"
                End If
            Case Is = 2
                If BEdirect = 1 Then
                    ssc.CommandText = "select * from Beasts order by B_datecreated"
                Else
                    ssc.CommandText = "select * from Beasts order by B_datecreated desc"
                End If
            Case Is = 3
                If BEdirect = 1 Then
                    ssc.CommandText = "select * from Beasts order by B_type"
                Else
                    ssc.CommandText = "select * from Beasts order by B_type desc"
                End If
        End Select
        BEdat.SelectCommand = ssc
        BErec.Clear()
        BEdat.Fill(BErec, "be")
        BEcount = BErec.Tables("be").Rows.Count
    End Sub


    Sub FillForm()


        Txt_beastname.Text = BErec.Tables("be").Rows(BEposition)("B_name")
        If Not IsDBNull(BErec.Tables("be").Rows(BEposition)("B_type")) Then
            Txt_typ.Text = BErec.Tables("be").Rows(BEposition)("B_type")
        Else
            Txt_typ.Text = ""
        End If
        If Not IsDBNull(BErec.Tables("be").Rows(BEposition)("B_level")) Then
            Txt_level.Text = BErec.Tables("be").Rows(BEposition)("B_level")
        Else
            Txt_level.Text = ""
        End If
        If Not IsDBNull(BErec.Tables("be").Rows(BEposition)("B_strength")) Then
            Txt_str.Text = BErec.Tables("be").Rows(BEposition)("B_strength")
        Else
            Txt_str.Text = ""
        End If
        If Not IsDBNull(BErec.Tables("be").Rows(BEposition)("B_attacks")) Then
            Txt_atta.Text = BErec.Tables("be").Rows(BEposition)("B_attacks")
        Else
            Txt_atta.Text = ""
        End If
        If Not IsDBNull(BErec.Tables("be").Rows(BEposition)("B_dexterity")) Then
            Txt_dex.Text = BErec.Tables("be").Rows(BEposition)("B_dexterity")
        Else
            Txt_dex.Text = ""
        End If
        If Not IsDBNull(BErec.Tables("be").Rows(BEposition)("B_defences")) Then
            Txt_def.Text = BErec.Tables("be").Rows(BEposition)("B_defences")
        Else
            Txt_def.Text = ""
        End If
        If Not IsDBNull(BErec.Tables("be").Rows(BEposition)("B_specattacks")) Then
            Txt_satta.Text = BErec.Tables("be").Rows(BEposition)("B_specattacks")
        Else
            Txt_satta.Text = ""
        End If
        If Not IsDBNull(BErec.Tables("be").Rows(BEposition)("B_specdefences")) Then
            Txt_sdef.Text = BErec.Tables("be").Rows(BEposition)("B_specdefences")
        Else
            Txt_sdef.Text = ""
        End If
        If Not IsDBNull(BErec.Tables("be").Rows(BEposition)("B_size")) Then
            Txt_size.Text = BErec.Tables("be").Rows(BEposition)("B_size")
        Else
            Txt_size.Text = ""
        End If
        If Not IsDBNull(BErec.Tables("be").Rows(BEposition)("B_fodl")) Then
            Txt_fodl.Text = BErec.Tables("be").Rows(BEposition)("B_fodl")
        Else
            Txt_fodl.Text = ""
        End If
        If Not IsDBNull(BErec.Tables("be").Rows(BEposition)("B_resistances")) Then
            Txt_res.Text = BErec.Tables("be").Rows(BEposition)("B_resistances")
        Else
            Txt_res.Text = ""
        End If
        If Not IsDBNull(BErec.Tables("be").Rows(BEposition)("B_IQ")) Then
            Txt_IQ.Text = BErec.Tables("be").Rows(BEposition)("B_IQ")
        Else
            Txt_IQ.Text = ""
        End If
        Txt_date.Text = BErec.Tables("be").Rows(BEposition)("B_datecreated")
        If Not IsDBNull(BErec.Tables("be").Rows(BEposition)("B_wisdom")) Then
            Txt_wis.Text = BErec.Tables("be").Rows(BEposition)("B_wisdom")
        Else
            Txt_wis.Text = ""
        End If
        If Not IsDBNull(BErec.Tables("be").Rows(BEposition)("B_skill")) Then
            Txt_ski.Text = BErec.Tables("be").Rows(BEposition)("B_skill")
        Else
            Txt_ski.Text = ""
        End If
        If Not IsDBNull(BErec.Tables("be").Rows(BEposition)("B_podl")) Then
            Txt_podl.Text = BErec.Tables("be").Rows(BEposition)("B_podl")
        Else
            Txt_podl.Text = ""
        End If
        If Not IsDBNull(BErec.Tables("be").Rows(BEposition)("B_jed")) Then
            Txt_jed.Text = BErec.Tables("be").Rows(BEposition)("B_jed")
        Else
            Txt_jed.Text = ""
        End If
        If Not IsDBNull(BErec.Tables("be").Rows(BEposition)("B_MG")) Then
            Txt_mg.Text = BErec.Tables("be").Rows(BEposition)("B_MG")
        Else
            Txt_mg.Text = ""
        End If
        If Not IsDBNull(BErec.Tables("be").Rows(BEposition)("B_maxspelltype")) Then
            Txt_mag.Text = BErec.Tables("be").Rows(BEposition)("B_maxspelltype")
        Else
            Txt_mag.Text = ""
        End If
        If Not IsDBNull(BErec.Tables("be").Rows(BEposition)("B_mental")) Then
            Txt_SM.Text = BErec.Tables("be").Rows(BEposition)("B_mental")
        Else
            Txt_SM.Text = ""
        End If
        If Not IsDBNull(BErec.Tables("be").Rows(BEposition)("B_mentalskills")) Then
            Txt_ment.Text = BErec.Tables("be").Rows(BEposition)("B_mentalskills")
        Else
            Txt_ment.Text = ""
        End If
        If Not IsDBNull(BErec.Tables("be").Rows(BEposition)("B_speed")) Then
            Txt_spd.Text = BErec.Tables("be").Rows(BEposition)("B_speed")
        Else
            Txt_spd.Text = ""
        End If
        If Not IsDBNull(BErec.Tables("be").Rows(BEposition)("B_behavior")) Then
            Txt_beha.Text = BErec.Tables("be").Rows(BEposition)("B_behavior")
        Else
            Txt_beha.Text = ""
        End If
        If Not IsDBNull(BErec.Tables("be").Rows(BEposition)("B_experience")) Then
            Txt_exp.Text = BErec.Tables("be").Rows(BEposition)("B_experience")
        Else
            Txt_exp.Text = ""
        End If
        If Not IsDBNull(BErec.Tables("be").Rows(BEposition)("B_treasures")) Then
            Txt_tre.Text = BErec.Tables("be").Rows(BEposition)("B_treasures")
        Else
            Txt_tre.Text = ""
        End If
        If Not IsDBNull(BErec.Tables("be").Rows(BEposition)("B_popis")) Then
            Txt_pop.Text = BErec.Tables("be").Rows(BEposition)("B_popis")
        Else
            Txt_pop.Text = ""
        End If
        If BEposition = 0 Then
            Cmd_Back.Enabled = False
        Else
            Cmd_Back.Enabled = True
        End If
        Cmd_Del.Enabled = True
        Cmd_Find.Enabled = True
        If BEposition + 1 = BEcount Then
            Cmd_Forward.Enabled = False
        Else
            Cmd_Forward.Enabled = True
        End If
        Cmd_Ins.Enabled = True
        Cmd_New.Enabled = True
        Cmd_Print.Enabled = True


        Txt_Num.Text = (BEposition + 1) & "/" & BEcount

    End Sub


    Private Sub Frm_Beasts_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        BE = False
        BErec.Clear()
    End Sub

    Private Sub Txt_Num_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Num.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            If Not IsNumeric(Txt_Num.Text) Then
                MsgBox("Tady musí být číslo!", MsgBoxStyle.OkOnly, "Chyba")
                GoTo EventExitSub
            End If
            If CShort(Txt_Num.Text) > BEcount Or CShort(Txt_Num.Text) < 1 Then
                MsgBox("Číslo musí být v rozsahu 1 - počet záznamů!", MsgBoxStyle.OkOnly, "Chyba")
                GoTo EventExitSub
            End If
            KeyAscii = 0
            BEposition = CShort(Txt_Num.Text) - 1
            Call FillForm()
        End If
EventExitSub:
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub Cmd_Print_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Print.Click
        Dim BErint As New BEPrint
        BErint.Show()
    End Sub

    Private Sub Cmd_Order_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Order.Click
        OrderControl = "BE"
        FO = New Frm_Ordering
        FO.ShowDialog()
        FO = Nothing
        BErec.Clear()
        Call BErecopen()
        BEposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Ins_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Ins.Click
        If Txt_beastname.Text = "" Then
            MsgBox("Bestie musí mít jméno!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        If Txt_date.Text = "" Then
            If MsgBox("U bestie musí být uvedeno datum vytvoření! Chcete zadat dnešní datum " & Today & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Chyba") = MsgBoxResult.Yes Then
                Txt_date.Text = CStr(Today)
            Else
                Exit Sub
            End If
        End If
        Txt_beastname.Text = Txt_beastname.Text.ToUpper()
        Dim tsc As New OleDbCommand
        Dim treader As OleDbDataReader
        Try
            tsc.Connection = Odrialink2
            tsc.CommandText = "select * from Beasts where B_name = @on"
            tsc.Parameters.AddWithValue("@on", Txt_beastname.Text)
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
                s1 = "INSERT INTO Beasts (B_name"
                s2 = " VALUES (@Orig_name"
                ic.Parameters.AddWithValue("@Orig_name", Trim(Txt_beastname.Text))
                If Txt_typ.Text <> "" Then
                    ic.Parameters.AddWithValue("@rp", Txt_typ.Text)
                    s1 = s1 & ", B_type"
                    s2 = s2 & ", @rp"
                End If
                If Txt_level.Text <> "" Then
                    ic.Parameters.AddWithValue("@rs", Txt_level.Text)
                    s1 = s1 & ", B_level"
                    s2 = s2 & ", @rs"
                End If
                If Txt_str.Text <> "" Then
                    ic.Parameters.AddWithValue("@rh", Txt_str.Text)
                    s1 = s1 & ", B_strength"
                    s2 = s2 & ", @rh"
                End If
                If Txt_atta.Text <> "" Then
                    ic.Parameters.AddWithValue("@rz", Txt_atta.Text)
                    s1 = s1 & ", B_attacks"
                    s2 = s2 & ", @rz"
                End If
                If Txt_dex.Text <> "" Then
                    ic.Parameters.AddWithValue("@rf", Txt_dex.Text)
                    s1 = s1 & ", B_dexterity"
                    s2 = s2 & ", @rf"
                End If
                If Txt_def.Text <> "" Then
                    ic.Parameters.AddWithValue("@ro", Txt_def.Text)
                    s1 = s1 & ", B_defences"
                    s2 = s2 & ", @ro"
                End If
                If Txt_satta.Text <> "" Then
                    ic.Parameters.AddWithValue("@ri", Txt_satta.Text)
                    s1 = s1 & ", B_specattacks"
                    s2 = s2 & ", @ri"
                End If
                If Txt_sdef.Text <> "" Then
                    ic.Parameters.AddWithValue("@rw", Txt_sdef.Text)
                    s1 = s1 & ", B_specdefences"
                    s2 = s2 & ", @rw"
                End If
                If Txt_size.Text <> "" Then
                    ic.Parameters.AddWithValue("@rj", Txt_size.Text)
                    s1 = s1 & ", B_size"
                    s2 = s2 & ", @rj"
                End If
                If Txt_fodl.Text <> "" Then
                    ic.Parameters.AddWithValue("@rk", Txt_fodl.Text)
                    s1 = s1 & ", B_fodl"
                    s2 = s2 & ", @rk"
                End If
                If Txt_res.Text <> "" Then
                    ic.Parameters.AddWithValue("@rt", Txt_res.Text)
                    s1 = s1 & ", B_resistances"
                    s2 = s2 & ", @rt"
                End If
                If Txt_pop.Text <> "" Then
                    ic.Parameters.AddWithValue("@ru", Txt_pop.Text)
                    s1 = s1 & ", B_popis"
                    s2 = s2 & ", @ru"
                End If
                ic.Parameters.AddWithValue("@da", Txt_date.Text)
                s1 = s1 & ", B_datecreated"
                s2 = s2 & ", @da"
                If Txt_IQ.Text <> "" Then
                    ic.Parameters.AddWithValue("@ha", Txt_IQ.Text)
                    s1 = s1 & ", B_IQ"
                    s2 = s2 & ", @ha"
                End If
                If Txt_wis.Text <> "" Then
                    ic.Parameters.AddWithValue("@co", Txt_wis.Text)
                    s1 = s1 & ", B_wisdom"
                    s2 = s2 & ", @co"
                End If
                If Txt_ski.Text <> "" Then
                    ic.Parameters.AddWithValue("@rl", Txt_ski.Text)
                    s1 = s1 & ", B_skill"
                    s2 = s2 & ", @rl"
                End If
                If Txt_podl.Text <> "" Then
                    ic.Parameters.AddWithValue("@rr", Txt_podl.Text)
                    s1 = s1 & ", B_podl"
                    s2 = s2 & ", @rr"
                End If
                If Txt_jed.Text <> "" Then
                    ic.Parameters.AddWithValue("@bj", Txt_jed.Text)
                    s1 = s1 & ", B_jed"
                    s2 = s2 & ", @bj"
                End If
                If Txt_mg.Text <> "" Then
                    ic.Parameters.AddWithValue("@bmg", Txt_mg.Text)
                    s1 = s1 & ", B_MG"
                    s2 = s2 & ", @bmg"
                End If
                If Txt_mag.Text <> "" Then
                    ic.Parameters.AddWithValue("@mst", Txt_mag.Text)
                    s1 = s1 & ", B_maxspelltype"
                    s2 = s2 & ", @mst"
                End If
                If Txt_SM.Text <> "" Then
                    ic.Parameters.AddWithValue("@bsm", Txt_SM.Text)
                    s1 = s1 & ", B_mental"
                    s2 = s2 & ", @bsm"
                End If
                If Txt_ment.Text <> "" Then
                    ic.Parameters.AddWithValue("@bms", Txt_ment.Text)
                    s1 = s1 & ", B_mentalskills"
                    s2 = s2 & ", @bms"
                End If
                If Txt_spd.Text <> "" Then
                    ic.Parameters.AddWithValue("@bee", Txt_spd.Text)
                    s1 = s1 & ", B_speed"
                    s2 = s2 & ", @bee"
                End If
                If Txt_beha.Text <> "" Then
                    ic.Parameters.AddWithValue("@eh", Txt_beha.Text)
                    s1 = s1 & ", B_behavior"
                    s2 = s2 & ", @eh"
                End If
                If Txt_exp.Text <> "" Then
                    ic.Parameters.AddWithValue("@bx", Txt_exp.Text)
                    s1 = s1 & ", B_experience"
                    s2 = s2 & ", @bx"
                End If
                If Txt_tre.Text <> "" Then
                    ic.Parameters.AddWithValue("@tr", Txt_tre.Text)
                    s1 = s1 & ", B_treasures"
                    s2 = s2 & ", @tr"
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
            BErec.Clear()
            BEdat.Fill(BErec, "be")
            BEcount = BErec.Tables("be").Rows.Count
            Call FillForm()
        Else
            treader.Close()
            If MsgBox("Bestie tohoto jména již v databázi existuje, chcete jí přepsat?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Upozornění") = MsgBoxResult.Yes Then
                Try
                    Dim cmdbuilder As OleDbCommandBuilder = New OleDbCommandBuilder(BEdat)
                    BErec.Tables("be").Rows(BEposition)("B_name") = Trim(Txt_beastname.Text)

                    If Txt_typ.Text = "" Then
                        BErec.Tables("be").Rows(BEposition)("B_type") = System.DBNull.Value
                    Else
                        BErec.Tables("be").Rows(BEposition)("B_type") = Trim(Txt_typ.Text)
                    End If
                    If Txt_level.Text = "" Then
                        BErec.Tables("be").Rows(BEposition)("B_level") = System.DBNull.Value
                    Else
                        BErec.Tables("be").Rows(BEposition)("B_level") = Trim(Txt_level.Text)
                    End If
                    If Txt_str.Text = "" Then
                        BErec.Tables("be").Rows(BEposition)("B_strength") = System.DBNull.Value
                    Else
                        BErec.Tables("be").Rows(BEposition)("B_strength") = Trim(Txt_str.Text)
                    End If
                    If Txt_atta.Text = "" Then
                        BErec.Tables("be").Rows(BEposition)("B_attacks") = System.DBNull.Value
                    Else
                        BErec.Tables("be").Rows(BEposition)("B_attacks") = Trim(Txt_atta.Text)
                    End If
                    If Txt_dex.Text = "" Then
                        BErec.Tables("be").Rows(BEposition)("B_dexterity") = System.DBNull.Value
                    Else
                        BErec.Tables("be").Rows(BEposition)("B_dexterity") = Trim(Txt_dex.Text)
                    End If
                    If Txt_def.Text = "" Then
                        BErec.Tables("be").Rows(BEposition)("B_defences") = System.DBNull.Value
                    Else
                        BErec.Tables("be").Rows(BEposition)("B_defences") = Trim(Txt_def.Text)
                    End If
                    If Txt_satta.Text = "" Then
                        BErec.Tables("be").Rows(BEposition)("B_specattacks") = System.DBNull.Value
                    Else
                        BErec.Tables("be").Rows(BEposition)("B_specattacks") = Trim(Txt_satta.Text)
                    End If
                    If Txt_sdef.Text = "" Then
                        BErec.Tables("be").Rows(BEposition)("B_specdefences") = System.DBNull.Value
                    Else
                        BErec.Tables("be").Rows(BEposition)("B_specdefences") = Trim(Txt_sdef.Text)
                    End If
                    If Txt_size.Text = "" Then
                        BErec.Tables("be").Rows(BEposition)("B_size") = System.DBNull.Value
                    Else
                        BErec.Tables("be").Rows(BEposition)("B_size") = Trim(Txt_size.Text)
                    End If
                    If Txt_fodl.Text = "" Then
                        BErec.Tables("be").Rows(BEposition)("B_fodl") = System.DBNull.Value
                    Else
                        BErec.Tables("be").Rows(BEposition)("B_fodl") = Trim(Txt_fodl.Text)
                    End If
                    If Txt_res.Text = "" Then
                        BErec.Tables("be").Rows(BEposition)("B_resistances") = System.DBNull.Value
                    Else
                        BErec.Tables("be").Rows(BEposition)("B_resistances") = Trim(Txt_res.Text)
                    End If
                    If Txt_pop.Text = "" Then
                        BErec.Tables("be").Rows(BEposition)("B_popis") = System.DBNull.Value
                    Else
                        BErec.Tables("be").Rows(BEposition)("B_popis") = Trim(Txt_pop.Text)
                    End If
                    BErec.Tables("be").Rows(BEposition)("B_datecreated") = CDate(Txt_date.Text)
                    If Txt_IQ.Text = "" Then
                        BErec.Tables("be").Rows(BEposition)("B_IQ") = System.DBNull.Value
                    Else
                        BErec.Tables("be").Rows(BEposition)("B_IQ") = Trim(Txt_IQ.Text)
                    End If
                    If Txt_wis.Text = "" Then
                        BErec.Tables("be").Rows(BEposition)("B_wisdom") = System.DBNull.Value
                    Else
                        BErec.Tables("be").Rows(BEposition)("B_wisdom") = Trim(Txt_wis.Text)
                    End If
                    If Txt_ski.Text = "" Then
                        BErec.Tables("be").Rows(BEposition)("B_skill") = System.DBNull.Value
                    Else
                        BErec.Tables("be").Rows(BEposition)("B_skill") = Trim(Txt_ski.Text)
                    End If
                    If Txt_podl.Text = "" Then
                        BErec.Tables("be").Rows(BEposition)("B_podl") = System.DBNull.Value
                    Else
                        BErec.Tables("be").Rows(BEposition)("B_podl") = Trim(Txt_podl.Text)
                    End If
                    If Txt_jed.Text = "" Then
                        BErec.Tables("be").Rows(BEposition)("B_jed") = System.DBNull.Value
                    Else
                        BErec.Tables("be").Rows(BEposition)("B_jed") = Trim(Txt_jed.Text)
                    End If
                    If Txt_mg.Text = "" Then
                        BErec.Tables("be").Rows(BEposition)("B_MG") = System.DBNull.Value
                    Else
                        BErec.Tables("be").Rows(BEposition)("B_MG") = Trim(Txt_mg.Text)
                    End If
                    If Txt_mag.Text = "" Then
                        BErec.Tables("be").Rows(BEposition)("B_maxspelltype") = System.DBNull.Value
                    Else
                        BErec.Tables("be").Rows(BEposition)("B_maxspelltype") = Trim(Txt_mag.Text)
                    End If
                    If Txt_SM.Text = "" Then
                        BErec.Tables("be").Rows(BEposition)("B_mental") = System.DBNull.Value
                    Else
                        BErec.Tables("be").Rows(BEposition)("B_mental") = Trim(Txt_SM.Text)
                    End If
                    If Txt_ment.Text = "" Then
                        BErec.Tables("be").Rows(BEposition)("B_mentalskills") = System.DBNull.Value
                    Else
                        BErec.Tables("be").Rows(BEposition)("B_mentalskills") = Trim(Txt_ment.Text)
                    End If
                    If Txt_spd.Text = "" Then
                        BErec.Tables("be").Rows(BEposition)("B_speed") = System.DBNull.Value
                    Else
                        BErec.Tables("be").Rows(BEposition)("B_speed") = Trim(Txt_spd.Text)
                    End If
                    If Txt_beha.Text = "" Then
                        BErec.Tables("be").Rows(BEposition)("B_behavior") = System.DBNull.Value
                    Else
                        BErec.Tables("be").Rows(BEposition)("B_behavior") = Trim(Txt_beha.Text)
                    End If
                    If Txt_exp.Text = "" Then
                        BErec.Tables("be").Rows(BEposition)("B_experience") = System.DBNull.Value
                    Else
                        BErec.Tables("be").Rows(BEposition)("B_experience") = Trim(Txt_exp.Text)
                    End If
                    If Txt_tre.Text = "" Then
                        BErec.Tables("be").Rows(BEposition)("B_treasures") = System.DBNull.Value
                    Else
                        BErec.Tables("be").Rows(BEposition)("B_treasures") = Trim(Txt_tre.Text)
                    End If
                    BEdat.Update(BErec, "be")
                Catch ex As Exception
                    MsgBox("Chyba updatu případu: " + ex.Message, , "Pokus o update")
                    Exit Sub
                End Try
                Call FillForm()
            Else
                Exit Sub
            End If
        End If

    End Sub

    Private Sub Cmd_Find_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Find.Click
        Dim SPse As New OleDbCommand
        Dim SPre As OleDbDataReader
        Dim s As String
        Dim q1 As Long
        Dim na, cz, ma, vy, dos, ro, za, sc, nc, ti, fa, po, aa, ab, ac, ad, ae, af, ag, ah, ai, aj, ak, al, am, an, ao As Boolean
        SPse.Connection = Odrialink2
        s = "SELECT * from Beasts WHERE "
        If Txt_beastname.Text <> "" Then
            s = s & "B_name LIKE @Orig_name"
            SPse.Parameters.AddWithValue("@Orig_name", "%" & Trim(Txt_beastname.Text) & "%")
            na = True
        End If
        If Txt_typ.Text <> "" Then
            If na Then
                s = s & " AND "
            End If
            s = s & "B_type LIKE @Czech_name"
            SPse.Parameters.AddWithValue("@Czech_name", "%" & Trim(Txt_typ.Text) & "%")
            cz = True
        End If
        If Txt_level.Text <> "" Then
            If na Or cz Then
                s = s & " AND "
            End If
            s = s & "B_level LIKE @Magenergy"
            SPse.Parameters.AddWithValue("@Magenergy", "%" & Trim(Txt_level.Text) & "%")
            ma = True
        End If
        If Txt_str.Text <> "" Then
            If na Or cz Or ma Then
                s = s & " AND "
            End If
            s = s & "B_strength LIKE @Cast_rounds"
            SPse.Parameters.AddWithValue("@Cast_rounds", "%" & Trim(Txt_str.Text) & "%")
            vy = True
        End If
        If Txt_atta.Text <> "" Then
            If na Or cz Or ma Or vy Then
                s = s & " AND "
            End If
            s = s & "B_attacks LIKE @Reach"
            SPse.Parameters.AddWithValue("@Reach", "%" & Trim(Txt_atta.Text) & "%")
            dos = True
        End If
        If Txt_dex.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Then
                s = s & " AND "
            End If
            s = s & "B_dexterity LIKE @Affect"
            SPse.Parameters.AddWithValue("@Affect", "%" & Trim(Txt_dex.Text) & "%")
            ro = True
        End If
        If Txt_def.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Then
                s = s & " AND "
            End If
            s = s & "B_defences LIKE @Spell_type"
            SPse.Parameters.AddWithValue("@Spell_type", "%" & Trim(Txt_def.Text) & "%")
            za = True
        End If
        If Txt_satta.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Then
                s = s & " AND "
            End If
            s = s & "B_specattacks LIKE @Spelling_cast"
            SPse.Parameters.AddWithValue("@Spelling_cast", "%" & Trim(Txt_satta.Text) & "%")
            sc = True
        End If
        If Txt_sdef.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Then
                s = s & " AND "
            End If
            s = s & "B_specdefences LIKE @Difficulty"
            SPse.Parameters.AddWithValue("@Difficulty", "%" & Trim(Txt_sdef.Text) & "%")
            nc = True
        End If
        If Txt_size.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Then
                s = s & " AND "
            End If
            s = s & "B_size LIKE @Cast_time"
            SPse.Parameters.AddWithValue("@Cast_time", "%" & Trim(Txt_size.Text) & "%")
            ti = True
        End If
        If Txt_fodl.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Then
                s = s & " AND "
            End If
            s = s & "B_fodl LIKE @Fatigue"
            SPse.Parameters.AddWithValue("@Fatigue", "%" & Trim(Txt_fodl.Text) & "%")
            fa = True
        End If
        If Txt_res.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Then
                s = s & " AND "
            End If
            s = s & "B_resistances LIKE @Texto"
            SPse.Parameters.AddWithValue("@Texto", "%" & Trim(Txt_res.Text) & "%")
            po = True
        End If
        If Txt_pop.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Then
                s = s & " AND "
            End If
            s = s & "B_popis LIKE @aa"
            SPse.Parameters.AddWithValue("@aa", "%" & Trim(Txt_pop.Text) & "%")
            aa = True
        End If
        If Txt_IQ.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Then
                s = s & " AND "
            End If
            s = s & "B_IQ LIKE @ab"
            SPse.Parameters.AddWithValue("@ab", "%" & Trim(Txt_IQ.Text) & "%")
            ab = True
        End If
        If Txt_wis.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Or ab Then
                s = s & " AND "
            End If
            s = s & "B_wisdom LIKE @ac"
            SPse.Parameters.AddWithValue("@ac", "%" & Trim(Txt_wis.Text) & "%")
            ac = True
        End If
        If Txt_ski.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Or ab Or ac Then
                s = s & " AND "
            End If
            s = s & "B_skill LIKE @ad"
            SPse.Parameters.AddWithValue("@ad", "%" & Trim(Txt_ski.Text) & "%")
            ad = True
        End If
        If Txt_podl.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Or ab Or ac Or ad Then
                s = s & " AND "
            End If
            s = s & "B_podl LIKE @ae"
            SPse.Parameters.AddWithValue("@ae", "%" & Trim(Txt_podl.Text) & "%")
            ae = True
        End If
        If Txt_date.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Or ab Or ac Or ad Or ae Then
                s = s & " AND "
            End If
            s = s & "B_datecreated = @af"
            SPse.Parameters.AddWithValue("@af", CDate(Txt_date.Text))
            af = True
        End If
        If Txt_jed.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Or ab Or ac Or ad Or ae Or af Then
                s = s & " AND "
            End If
            s = s & "B_jed LIKE @ag"
            SPse.Parameters.AddWithValue("@ag", "%" & Trim(Txt_jed.Text) & "%")
            ag = True
        End If
        If Txt_mg.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Or ab Or ac Or ad Or ae Or af Or ag Then
                s = s & " AND "
            End If
            s = s & "B_MG LIKE @ah"
            SPse.Parameters.AddWithValue("@ah", "%" & Trim(Txt_mg.Text) & "%")
            ah = True
        End If
        If Txt_mag.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Or ab Or ac Or ad Or ae Or af Or ag Or ah Then
                s = s & " AND "
            End If
            s = s & "B_maxspelltype LIKE @ai"
            SPse.Parameters.AddWithValue("@ai", "%" & Trim(Txt_mag.Text) & "%")
            ai = True
        End If
        If Txt_SM.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Or ab Or ac Or ad Or ae Or af Or ag Or ah Or ai Then
                s = s & " AND "
            End If
            s = s & "B_mental LIKE @aj"
            SPse.Parameters.AddWithValue("@aj", "%" & Trim(Txt_SM.Text) & "%")
            aj = True
        End If
        If Txt_ment.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Or ab Or ac Or ad Or ae Or af Or ag Or ah Or ai Or aj Then
                s = s & " AND "
            End If
            s = s & "B_mentalskills LIKE @ak"
            SPse.Parameters.AddWithValue("@ak", "%" & Trim(Txt_ment.Text) & "%")
            ak = True
        End If
        If Txt_spd.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Or ab Or ac Or ad Or ae Or af Or ag Or ah Or ai Or aj Or ak Then
                s = s & " AND "
            End If
            s = s & "B_speed LIKE @al"
            SPse.Parameters.AddWithValue("@al", "%" & Trim(Txt_spd.Text) & "%")
            al = True
        End If
        If Txt_beha.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Or ab Or ac Or ad Or ae Or af Or ag Or ah Or ai Or aj Or ak Or al Then
                s = s & " AND "
            End If
            s = s & "B_behavior LIKE @am"
            SPse.Parameters.AddWithValue("@am", "%" & Trim(Txt_beha.Text) & "%")
            am = True
        End If
        If Txt_exp.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Or ab Or ac Or ad Or ae Or af Or ag Or ah Or ai Or aj Or ak Or al Or am Then
                s = s & " AND "
            End If
            s = s & "B_experience LIKE @an"
            SPse.Parameters.AddWithValue("@an", "%" & Trim(Txt_exp.Text) & "%")
            an = True
        End If
        If Txt_tre.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Or ab Or ac Or ad Or ae Or af Or ag Or ah Or ai Or aj Or ak Or al Or am Or an Then
                s = s & " AND "
            End If
            s = s & "B_treasures LIKE @ao"
            SPse.Parameters.AddWithValue("@ao", "%" & Trim(Txt_tre.Text) & "%")
            ao = True
        End If
        BEposition = 0
        If s = "SELECT * from Beasts WHERE " Then
            BErecopen()
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
                BEdat.SelectCommand = SPse
                BErec.Clear()
                BEdat.Fill(BErec, "be")
                BEcount = BErec.Tables("be").Rows.Count
                If GC_list = 1 Then
                    If my_sez Is Nothing Then
                        my_sez = New Frm_BEsez
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

    Private Sub Cmd_Del_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Del.Click
        Dim tsc As New OleDbCommand
        If MsgBox("Opravdu vymazat bestii " & Txt_beastname.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Upozornění") = MsgBoxResult.Yes Then
            Try
                tsc.Connection = Odrialink2
                tsc.CommandText = "DELETE from Beasts WHERE ID = @ID"
                tsc.Parameters.AddWithValue("@ID", BErec.Tables("be").Rows(BEposition)("ID"))
                tsc.ExecuteScalar()
            Catch ex As Exception
                Throw New Exception("Chyba při výmazu případu: " + ex.Message)
                Exit Sub
            End Try
        Else
            Exit Sub
        End If
        BErec.Clear()
        BEdat.Fill(BErec, "be")
        BEcount = BErec.Tables("be").Rows.Count
        If BEposition = BEcount Then
            BEposition -= 1
        End If
        Call FillForm()
    End Sub

    Private Sub Bt_List_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_List.Click
        If my_sez Is Nothing Then
            my_sez = New Frm_BEsez
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
        Me.BackColor = Color.FromArgb(FBB)
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
        Label1.ForeColor = Color.FromArgb(FBFO)
        Label2.ForeColor = Color.FromArgb(FBFO)
        Label3.ForeColor = Color.FromArgb(FBFO)
        Label4.ForeColor = Color.FromArgb(FBFO)
        Label5.ForeColor = Color.FromArgb(FBFO)
        Label6.ForeColor = Color.FromArgb(FBFO)
        Label7.ForeColor = Color.FromArgb(FBFO)
        Label8.ForeColor = Color.FromArgb(FBFO)
        Label9.ForeColor = Color.FromArgb(FBFO)
        Label10.ForeColor = Color.FromArgb(FBFO)
        Label11.ForeColor = Color.FromArgb(FBFO)
        Label12.ForeColor = Color.FromArgb(FBFO)
        Label13.ForeColor = Color.FromArgb(FBFO)
        Label14.ForeColor = Color.FromArgb(FBFO)
        Label15.ForeColor = Color.FromArgb(FBFO)
        Label16.ForeColor = Color.FromArgb(FBFO)
        Label17.ForeColor = Color.FromArgb(FBFO)
        Label18.ForeColor = Color.FromArgb(FBFO)
        Label19.ForeColor = Color.FromArgb(FBFO)
        Label20.ForeColor = Color.FromArgb(FBFO)
        Label21.ForeColor = Color.FromArgb(FBFO)
        Label22.ForeColor = Color.FromArgb(FBFO)
        Label23.ForeColor = Color.FromArgb(FBFO)
        Label24.ForeColor = Color.FromArgb(FBFO)
        Label25.ForeColor = Color.FromArgb(FBFO)
        Label26.ForeColor = Color.FromArgb(FBFO)
        Label27.ForeColor = Color.FromArgb(FBFO)
        Txt_Num.ForeColor = Color.FromArgb(FBFO)
        Txt_beastname.ForeColor = Color.FromArgb(FBFO)
        Txt_typ.ForeColor = Color.FromArgb(FBFO)
        Txt_level.ForeColor = Color.FromArgb(FBFO)
        Txt_str.ForeColor = Color.FromArgb(FBFO)
        Txt_atta.ForeColor = Color.FromArgb(FBFO)
        Txt_podl.ForeColor = Color.FromArgb(FBFO)
        Txt_fodl.ForeColor = Color.FromArgb(FBFO)
        Txt_IQ.ForeColor = Color.FromArgb(FBFO)
        Txt_wis.ForeColor = Color.FromArgb(FBFO)
        Txt_jed.ForeColor = Color.FromArgb(FBFO)
        Txt_dex.ForeColor = Color.FromArgb(FBFO)
        Txt_ski.ForeColor = Color.FromArgb(FBFO)
        Txt_def.ForeColor = Color.FromArgb(FBFO)
        Txt_satta.ForeColor = Color.FromArgb(FBFO)
        Txt_sdef.ForeColor = Color.FromArgb(FBFO)
        Txt_size.ForeColor = Color.FromArgb(FBFO)
        Txt_res.ForeColor = Color.FromArgb(FBFO)
        Txt_date.ForeColor = Color.FromArgb(FBFO)
        Txt_pop.ForeColor = Color.FromArgb(FBFO)
        Txt_mg.ForeColor = Color.FromArgb(FBFO)
        Txt_mag.ForeColor = Color.FromArgb(FBFO)
        Txt_SM.ForeColor = Color.FromArgb(FBFO)
        Txt_ment.ForeColor = Color.FromArgb(FBFO)
        Txt_spd.ForeColor = Color.FromArgb(FBFO)
        Txt_beha.ForeColor = Color.FromArgb(FBFO)
        Txt_exp.ForeColor = Color.FromArgb(FBFO)
        Txt_tre.ForeColor = Color.FromArgb(FBFO)
    End Sub

End Class