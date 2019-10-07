Option Strict Off
Option Explicit On 
Imports System.Data.oledb
Friend Class Frm_Races
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
	Public WithEvents Cmd_Last As System.Windows.Forms.Button
	Public WithEvents Cmd_Forward As System.Windows.Forms.Button
	Public WithEvents Txt_Num As System.Windows.Forms.TextBox
	Public WithEvents Cmd_Back As System.Windows.Forms.Button
	Public WithEvents Cmd_First As System.Windows.Forms.Button
	Public WithEvents Txt_date As System.Windows.Forms.TextBox
	Public WithEvents Txt_rar As System.Windows.Forms.TextBox
	Public WithEvents Txt_lspan As System.Windows.Forms.TextBox
	Public WithEvents Txt_cena As System.Windows.Forms.TextBox
	Public WithEvents Txt_habits As System.Windows.Forms.TextBox
	Public WithEvents Txt_ucoc As System.Windows.Forms.TextBox
	Public WithEvents Txt_talents As System.Windows.Forms.TextBox
	Public WithEvents Txt_kra As System.Windows.Forms.TextBox
	Public WithEvents Txt_jed As System.Windows.Forms.TextBox
	Public WithEvents Txt_mou As System.Windows.Forms.TextBox
	Public WithEvents Txt_IQ As System.Windows.Forms.TextBox
	Public WithEvents Txt_Podl As System.Windows.Forms.TextBox
	Public WithEvents Txt_fodl As System.Windows.Forms.TextBox
	Public WithEvents Txt_zru As System.Windows.Forms.TextBox
	Public WithEvents Txt_hbi As System.Windows.Forms.TextBox
	Public WithEvents Txt_sil As System.Windows.Forms.TextBox
	Public WithEvents Txt_pop As System.Windows.Forms.TextBox
	Public WithEvents Txt_name As System.Windows.Forms.TextBox
	Public WithEvents Cmd_Order As System.Windows.Forms.Button
	Public WithEvents Cmd_Print As System.Windows.Forms.Button
	Public WithEvents Cmd_New As System.Windows.Forms.Button
	Public WithEvents Cmd_Find As System.Windows.Forms.Button
	Public WithEvents Cmd_Del As System.Windows.Forms.Button
	Public WithEvents Cmd_Ins As System.Windows.Forms.Button
	Public WithEvents Cmd_Exit As System.Windows.Forms.Button
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Races))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Cmd_Last = New System.Windows.Forms.Button
        Me.Cmd_Forward = New System.Windows.Forms.Button
        Me.Cmd_Back = New System.Windows.Forms.Button
        Me.Cmd_First = New System.Windows.Forms.Button
        Me.Cmd_Order = New System.Windows.Forms.Button
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Cmd_New = New System.Windows.Forms.Button
        Me.Cmd_Find = New System.Windows.Forms.Button
        Me.Cmd_Del = New System.Windows.Forms.Button
        Me.Cmd_Ins = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Txt_Num = New System.Windows.Forms.TextBox
        Me.Txt_date = New System.Windows.Forms.TextBox
        Me.Txt_rar = New System.Windows.Forms.TextBox
        Me.Txt_lspan = New System.Windows.Forms.TextBox
        Me.Txt_cena = New System.Windows.Forms.TextBox
        Me.Txt_habits = New System.Windows.Forms.TextBox
        Me.Txt_ucoc = New System.Windows.Forms.TextBox
        Me.Txt_talents = New System.Windows.Forms.TextBox
        Me.Txt_kra = New System.Windows.Forms.TextBox
        Me.Txt_jed = New System.Windows.Forms.TextBox
        Me.Txt_mou = New System.Windows.Forms.TextBox
        Me.Txt_IQ = New System.Windows.Forms.TextBox
        Me.Txt_Podl = New System.Windows.Forms.TextBox
        Me.Txt_fodl = New System.Windows.Forms.TextBox
        Me.Txt_zru = New System.Windows.Forms.TextBox
        Me.Txt_hbi = New System.Windows.Forms.TextBox
        Me.Txt_sil = New System.Windows.Forms.TextBox
        Me.Txt_pop = New System.Windows.Forms.TextBox
        Me.Txt_name = New System.Windows.Forms.TextBox
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
        'Cmd_Last
        '
        Me.Cmd_Last.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_Last.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Last.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Last.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Last.Image = CType(resources.GetObject("Cmd_Last.Image"), System.Drawing.Image)
        Me.Cmd_Last.Location = New System.Drawing.Point(805, 553)
        Me.Cmd_Last.Name = "Cmd_Last"
        Me.Cmd_Last.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Last.Size = New System.Drawing.Size(55, 42)
        Me.Cmd_Last.TabIndex = 47
        Me.Cmd_Last.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Last, "Na konec")
        Me.Cmd_Last.UseVisualStyleBackColor = False
        '
        'Cmd_Forward
        '
        Me.Cmd_Forward.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_Forward.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Forward.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Forward.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Forward.Image = CType(resources.GetObject("Cmd_Forward.Image"), System.Drawing.Image)
        Me.Cmd_Forward.Location = New System.Drawing.Point(750, 553)
        Me.Cmd_Forward.Name = "Cmd_Forward"
        Me.Cmd_Forward.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Forward.Size = New System.Drawing.Size(55, 42)
        Me.Cmd_Forward.TabIndex = 46
        Me.Cmd_Forward.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Forward, "O 1 vpřed")
        Me.Cmd_Forward.UseVisualStyleBackColor = False
        '
        'Cmd_Back
        '
        Me.Cmd_Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_Back.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Back.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Back.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Back.Image = CType(resources.GetObject("Cmd_Back.Image"), System.Drawing.Image)
        Me.Cmd_Back.Location = New System.Drawing.Point(528, 553)
        Me.Cmd_Back.Name = "Cmd_Back"
        Me.Cmd_Back.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Back.Size = New System.Drawing.Size(55, 42)
        Me.Cmd_Back.TabIndex = 44
        Me.Cmd_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Back, "O 1 vzad")
        Me.Cmd_Back.UseVisualStyleBackColor = False
        '
        'Cmd_First
        '
        Me.Cmd_First.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_First.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_First.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_First.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_First.Image = CType(resources.GetObject("Cmd_First.Image"), System.Drawing.Image)
        Me.Cmd_First.Location = New System.Drawing.Point(473, 553)
        Me.Cmd_First.Name = "Cmd_First"
        Me.Cmd_First.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_First.Size = New System.Drawing.Size(55, 42)
        Me.Cmd_First.TabIndex = 43
        Me.Cmd_First.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_First, "Na začátek")
        Me.Cmd_First.UseVisualStyleBackColor = False
        '
        'Cmd_Order
        '
        Me.Cmd_Order.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Order.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Order.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Order.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Order.Location = New System.Drawing.Point(838, 312)
        Me.Cmd_Order.Name = "Cmd_Order"
        Me.Cmd_Order.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Order.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_Order.TabIndex = 6
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
        Me.Cmd_Print.Location = New System.Drawing.Point(838, 263)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Print.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_Print.TabIndex = 5
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
        Me.Cmd_New.Location = New System.Drawing.Point(838, 215)
        Me.Cmd_New.Name = "Cmd_New"
        Me.Cmd_New.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_New.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_New.TabIndex = 4
        Me.Cmd_New.Text = "NOVÁ"
        Me.ToolTip1.SetToolTip(Me.Cmd_New, "Vymaže pole, příprava na vepsání nového kouzla")
        Me.Cmd_New.UseVisualStyleBackColor = False
        '
        'Cmd_Find
        '
        Me.Cmd_Find.BackColor = System.Drawing.Color.Yellow
        Me.Cmd_Find.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Find.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Find.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Find.Location = New System.Drawing.Point(838, 134)
        Me.Cmd_Find.Name = "Cmd_Find"
        Me.Cmd_Find.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Find.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_Find.TabIndex = 3
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
        Me.Cmd_Del.Location = New System.Drawing.Point(838, 85)
        Me.Cmd_Del.Name = "Cmd_Del"
        Me.Cmd_Del.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Del.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_Del.TabIndex = 2
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
        Me.Cmd_Ins.Location = New System.Drawing.Point(838, 36)
        Me.Cmd_Ins.Name = "Cmd_Ins"
        Me.Cmd_Ins.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Ins.Size = New System.Drawing.Size(160, 50)
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
        Me.Cmd_Exit.Location = New System.Drawing.Point(838, 389)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Exit.Size = New System.Drawing.Size(160, 87)
        Me.Cmd_Exit.TabIndex = 0
        Me.Cmd_Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Exit, "Zavřít toto okno")
        Me.Cmd_Exit.UseVisualStyleBackColor = False
        '
        'Txt_Num
        '
        Me.Txt_Num.AcceptsReturn = True
        Me.Txt_Num.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Num.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Num.Font = New System.Drawing.Font("Arial", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Num.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Num.Location = New System.Drawing.Point(580, 553)
        Me.Txt_Num.MaxLength = 0
        Me.Txt_Num.Name = "Txt_Num"
        Me.Txt_Num.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Num.Size = New System.Drawing.Size(170, 40)
        Me.Txt_Num.TabIndex = 45
        Me.Txt_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_date
        '
        Me.Txt_date.AcceptsReturn = True
        Me.Txt_date.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_date.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_date.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_date.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_date.Location = New System.Drawing.Point(219, 560)
        Me.Txt_date.MaxLength = 0
        Me.Txt_date.Name = "Txt_date"
        Me.Txt_date.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_date.Size = New System.Drawing.Size(121, 26)
        Me.Txt_date.TabIndex = 42
        '
        'Txt_rar
        '
        Me.Txt_rar.AcceptsReturn = True
        Me.Txt_rar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_rar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_rar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_rar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_rar.Location = New System.Drawing.Point(830, 493)
        Me.Txt_rar.MaxLength = 0
        Me.Txt_rar.Name = "Txt_rar"
        Me.Txt_rar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_rar.Size = New System.Drawing.Size(149, 26)
        Me.Txt_rar.TabIndex = 40
        '
        'Txt_lspan
        '
        Me.Txt_lspan.AcceptsReturn = True
        Me.Txt_lspan.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_lspan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_lspan.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_lspan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_lspan.Location = New System.Drawing.Point(480, 493)
        Me.Txt_lspan.MaxLength = 0
        Me.Txt_lspan.Name = "Txt_lspan"
        Me.Txt_lspan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_lspan.Size = New System.Drawing.Size(147, 26)
        Me.Txt_lspan.TabIndex = 38
        '
        'Txt_cena
        '
        Me.Txt_cena.AcceptsReturn = True
        Me.Txt_cena.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_cena.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_cena.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_cena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_cena.Location = New System.Drawing.Point(105, 493)
        Me.Txt_cena.MaxLength = 0
        Me.Txt_cena.Name = "Txt_cena"
        Me.Txt_cena.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_cena.Size = New System.Drawing.Size(119, 26)
        Me.Txt_cena.TabIndex = 36
        '
        'Txt_habits
        '
        Me.Txt_habits.AcceptsReturn = True
        Me.Txt_habits.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_habits.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_habits.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_habits.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_habits.Location = New System.Drawing.Point(105, 406)
        Me.Txt_habits.MaxLength = 0
        Me.Txt_habits.Multiline = True
        Me.Txt_habits.Name = "Txt_habits"
        Me.Txt_habits.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_habits.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_habits.Size = New System.Drawing.Size(700, 70)
        Me.Txt_habits.TabIndex = 34
        '
        'Txt_ucoc
        '
        Me.Txt_ucoc.AcceptsReturn = True
        Me.Txt_ucoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_ucoc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_ucoc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_ucoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_ucoc.Location = New System.Drawing.Point(105, 328)
        Me.Txt_ucoc.MaxLength = 0
        Me.Txt_ucoc.Multiline = True
        Me.Txt_ucoc.Name = "Txt_ucoc"
        Me.Txt_ucoc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_ucoc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_ucoc.Size = New System.Drawing.Size(700, 70)
        Me.Txt_ucoc.TabIndex = 32
        '
        'Txt_talents
        '
        Me.Txt_talents.AcceptsReturn = True
        Me.Txt_talents.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_talents.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_talents.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_talents.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_talents.Location = New System.Drawing.Point(105, 252)
        Me.Txt_talents.MaxLength = 0
        Me.Txt_talents.Multiline = True
        Me.Txt_talents.Name = "Txt_talents"
        Me.Txt_talents.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_talents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_talents.Size = New System.Drawing.Size(700, 70)
        Me.Txt_talents.TabIndex = 30
        '
        'Txt_kra
        '
        Me.Txt_kra.AcceptsReturn = True
        Me.Txt_kra.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_kra.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_kra.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_kra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_kra.Location = New System.Drawing.Point(689, 214)
        Me.Txt_kra.MaxLength = 0
        Me.Txt_kra.Name = "Txt_kra"
        Me.Txt_kra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_kra.Size = New System.Drawing.Size(116, 26)
        Me.Txt_kra.TabIndex = 28
        '
        'Txt_jed
        '
        Me.Txt_jed.AcceptsReturn = True
        Me.Txt_jed.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_jed.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_jed.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_jed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_jed.Location = New System.Drawing.Point(387, 214)
        Me.Txt_jed.MaxLength = 0
        Me.Txt_jed.Name = "Txt_jed"
        Me.Txt_jed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_jed.Size = New System.Drawing.Size(121, 26)
        Me.Txt_jed.TabIndex = 26
        '
        'Txt_mou
        '
        Me.Txt_mou.AcceptsReturn = True
        Me.Txt_mou.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_mou.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_mou.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_mou.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_mou.Location = New System.Drawing.Point(105, 212)
        Me.Txt_mou.MaxLength = 0
        Me.Txt_mou.Name = "Txt_mou"
        Me.Txt_mou.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_mou.Size = New System.Drawing.Size(121, 26)
        Me.Txt_mou.TabIndex = 24
        '
        'Txt_IQ
        '
        Me.Txt_IQ.AcceptsReturn = True
        Me.Txt_IQ.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_IQ.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_IQ.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_IQ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_IQ.Location = New System.Drawing.Point(689, 182)
        Me.Txt_IQ.MaxLength = 0
        Me.Txt_IQ.Name = "Txt_IQ"
        Me.Txt_IQ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_IQ.Size = New System.Drawing.Size(116, 26)
        Me.Txt_IQ.TabIndex = 22
        '
        'Txt_Podl
        '
        Me.Txt_Podl.AcceptsReturn = True
        Me.Txt_Podl.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Podl.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Podl.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Podl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Podl.Location = New System.Drawing.Point(387, 182)
        Me.Txt_Podl.MaxLength = 0
        Me.Txt_Podl.Name = "Txt_Podl"
        Me.Txt_Podl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Podl.Size = New System.Drawing.Size(121, 26)
        Me.Txt_Podl.TabIndex = 20
        '
        'Txt_fodl
        '
        Me.Txt_fodl.AcceptsReturn = True
        Me.Txt_fodl.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_fodl.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_fodl.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_fodl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_fodl.Location = New System.Drawing.Point(105, 180)
        Me.Txt_fodl.MaxLength = 0
        Me.Txt_fodl.Name = "Txt_fodl"
        Me.Txt_fodl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_fodl.Size = New System.Drawing.Size(121, 26)
        Me.Txt_fodl.TabIndex = 18
        '
        'Txt_zru
        '
        Me.Txt_zru.AcceptsReturn = True
        Me.Txt_zru.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_zru.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_zru.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_zru.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_zru.Location = New System.Drawing.Point(689, 150)
        Me.Txt_zru.MaxLength = 0
        Me.Txt_zru.Name = "Txt_zru"
        Me.Txt_zru.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_zru.Size = New System.Drawing.Size(116, 26)
        Me.Txt_zru.TabIndex = 16
        '
        'Txt_hbi
        '
        Me.Txt_hbi.AcceptsReturn = True
        Me.Txt_hbi.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_hbi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_hbi.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_hbi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_hbi.Location = New System.Drawing.Point(387, 150)
        Me.Txt_hbi.MaxLength = 0
        Me.Txt_hbi.Name = "Txt_hbi"
        Me.Txt_hbi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_hbi.Size = New System.Drawing.Size(121, 26)
        Me.Txt_hbi.TabIndex = 14
        '
        'Txt_sil
        '
        Me.Txt_sil.AcceptsReturn = True
        Me.Txt_sil.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_sil.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_sil.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_sil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_sil.Location = New System.Drawing.Point(105, 148)
        Me.Txt_sil.MaxLength = 0
        Me.Txt_sil.Name = "Txt_sil"
        Me.Txt_sil.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_sil.Size = New System.Drawing.Size(121, 26)
        Me.Txt_sil.TabIndex = 12
        '
        'Txt_pop
        '
        Me.Txt_pop.AcceptsReturn = True
        Me.Txt_pop.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_pop.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_pop.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_pop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_pop.Location = New System.Drawing.Point(105, 59)
        Me.Txt_pop.MaxLength = 0
        Me.Txt_pop.Multiline = True
        Me.Txt_pop.Name = "Txt_pop"
        Me.Txt_pop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_pop.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_pop.Size = New System.Drawing.Size(700, 76)
        Me.Txt_pop.TabIndex = 10
        '
        'Txt_name
        '
        Me.Txt_name.AcceptsReturn = True
        Me.Txt_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_name.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_name.Location = New System.Drawing.Point(105, 12)
        Me.Txt_name.MaxLength = 0
        Me.Txt_name.Name = "Txt_name"
        Me.Txt_name.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_name.Size = New System.Drawing.Size(478, 29)
        Me.Txt_name.TabIndex = 8
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(14, 560)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(169, 25)
        Me.Label18.TabIndex = 41
        Me.Label18.Text = "Datum vytvoření"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(729, 493)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(105, 26)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "Rarita"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(317, 493)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(128, 26)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Délka života"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(16, 493)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(64, 26)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Cena"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(8, 406)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(72, 25)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Zvyky"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(7, 328)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(91, 48)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Útoky / Obrany"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(7, 252)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(91, 26)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Talenty"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(559, 214)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(73, 26)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Krása"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(261, 214)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(92, 26)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Jednání"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(7, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(102, 30)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Moudrost"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(559, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(43, 26)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "IQ"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(261, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(70, 24)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Podl"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(7, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(65, 24)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Fodl"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(559, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(98, 26)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Zručnost"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(261, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(92, 24)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Hbitost"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(7, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(49, 24)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Síla"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(64, 28)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Popis"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(7, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(72, 33)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Rasa"
        '
        'Bt_List
        '
        Me.Bt_List.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Bt_List.Image = CType(resources.GetObject("Bt_List.Image"), System.Drawing.Image)
        Me.Bt_List.Location = New System.Drawing.Point(900, 539)
        Me.Bt_List.Name = "Bt_List"
        Me.Bt_List.Size = New System.Drawing.Size(108, 73)
        Me.Bt_List.TabIndex = 50
        Me.Bt_List.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Frm_Races
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1020, 624)
        Me.Controls.Add(Me.Bt_List)
        Me.Controls.Add(Me.Cmd_Last)
        Me.Controls.Add(Me.Cmd_Forward)
        Me.Controls.Add(Me.Txt_Num)
        Me.Controls.Add(Me.Cmd_Back)
        Me.Controls.Add(Me.Cmd_First)
        Me.Controls.Add(Me.Txt_date)
        Me.Controls.Add(Me.Txt_rar)
        Me.Controls.Add(Me.Txt_lspan)
        Me.Controls.Add(Me.Txt_cena)
        Me.Controls.Add(Me.Txt_habits)
        Me.Controls.Add(Me.Txt_ucoc)
        Me.Controls.Add(Me.Txt_talents)
        Me.Controls.Add(Me.Txt_kra)
        Me.Controls.Add(Me.Txt_jed)
        Me.Controls.Add(Me.Txt_mou)
        Me.Controls.Add(Me.Txt_IQ)
        Me.Controls.Add(Me.Txt_Podl)
        Me.Controls.Add(Me.Txt_fodl)
        Me.Controls.Add(Me.Txt_zru)
        Me.Controls.Add(Me.Txt_hbi)
        Me.Controls.Add(Me.Txt_sil)
        Me.Controls.Add(Me.Txt_pop)
        Me.Controls.Add(Me.Txt_name)
        Me.Controls.Add(Me.Cmd_Order)
        Me.Controls.Add(Me.Cmd_Print)
        Me.Controls.Add(Me.Cmd_New)
        Me.Controls.Add(Me.Cmd_Find)
        Me.Controls.Add(Me.Cmd_Del)
        Me.Controls.Add(Me.Cmd_Ins)
        Me.Controls.Add(Me.Cmd_Exit)
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
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.Name = "Frm_Races"
        Me.Opacity = 0.9
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "GC AVATAR - Odria Races"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As Frm_Races
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Frm_Races
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Frm_Races()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal value As Frm_Races)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region

    Private Sub Frm_RAsez_Unload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles my_sez.Closed
        If Trac <> "" Then
            RAposition = 0
            Do Until RArec.Tables("ra").Rows(RAposition)("Race_name") = Trac
                RAposition += 1
            Loop
            FillForm()
            Me.Refresh()
        End If
    End Sub

    Private Sub Cmd_Back_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Back.Click

        RAposition -= 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Del_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Del.Click
        Dim tsc As New OleDbCommand
        If MsgBox("Opravdu vymazat rasu " & Txt_name.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Upozornění") = MsgBoxResult.Yes Then
            Try
                tsc.Connection = Odrialink2
                tsc.CommandText = "DELETE from Races WHERE ID = @ID"
                tsc.Parameters.AddWithValue("@ID", RArec.Tables("ra").Rows(RAposition)("ID"))
                tsc.ExecuteScalar()
            Catch ex As Exception
                Throw New Exception("Chyba při výmazu případu: " + ex.Message)
                Exit Sub
            End Try
        Else
            Exit Sub
        End If
        RArec.Clear()
        RAdat.Fill(RArec, "ra")
        RAcount = RArec.Tables("ra").Rows.Count
        If RAposition = RAcount Then
            RAposition -= 1
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
        Dim na, cz, ma, vy, dos, ro, za, sc, nc, ti, fa, po, aa, ab, ac, ad, ae, af As Boolean
        SPse.Connection = Odrialink2
        s = "SELECT * from Races WHERE "
        If Txt_name.Text <> "" Then
            s = s & "Race_name LIKE @Orig_name"
            SPse.Parameters.AddWithValue("@Orig_name", "%" & Trim(Txt_name.Text) & "%")
            na = True
        End If
        If Txt_pop.Text <> "" Then
            If na Then
                s = s & " AND "
            End If
            s = s & "Race_popis LIKE @Czech_name"
            SPse.Parameters.AddWithValue("@Czech_name", "%" & Trim(Txt_pop.Text) & "%")
            cz = True
        End If
        If Txt_sil.Text <> "" Then
            If na Or cz Then
                s = s & " AND "
            End If
            s = s & "Racial_str = @Magenergy"
            SPse.Parameters.AddWithValue("@Magenergy", Trim(Txt_sil.Text))
            ma = True
        End If
        If Txt_hbi.Text <> "" Then
            If na Or cz Or ma Then
                s = s & " AND "
            End If
            s = s & "Racial_dex = @Cast_rounds"
            SPse.Parameters.AddWithValue("@Cast_rounds", Trim(Txt_hbi.Text))
            vy = True
        End If
        If Txt_zru.Text <> "" Then
            If na Or cz Or ma Or vy Then
                s = s & " AND "
            End If
            s = s & "Racial_skill = @Reach"
            SPse.Parameters.AddWithValue("@Reach", Trim(Txt_zru.Text))
            dos = True
        End If
        If Txt_fodl.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Then
                s = s & " AND "
            End If
            s = s & "Racial_fodl = @Affect"
            SPse.Parameters.AddWithValue("@Affect", Trim(Txt_fodl.Text))
            ro = True
        End If
        If Txt_Podl.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Then
                s = s & " AND "
            End If
            s = s & "Racial_podl = @Spell_type"
            SPse.Parameters.AddWithValue("@Spell_type", Trim(Txt_Podl.Text))
            za = True
        End If
        If Txt_IQ.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Then
                s = s & " AND "
            End If
            s = s & "Racial_IQ = @Spelling_cast"
            SPse.Parameters.AddWithValue("@Spelling_cast", Trim(Txt_IQ.Text))
            sc = True
        End If
        If Txt_mou.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Then
                s = s & " AND "
            End If
            s = s & "Racial_wis = @Difficulty"
            SPse.Parameters.AddWithValue("@Difficulty", Trim(Txt_mou.Text))
            nc = True
        End If
        If Txt_jed.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Then
                s = s & " AND "
            End If
            s = s & "Racial_beh = @Cast_time"
            SPse.Parameters.AddWithValue("@Cast_time", Trim(Txt_jed.Text))
            ti = True
        End If
        If Txt_kra.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Then
                s = s & " AND "
            End If
            s = s & "Racial_beau = @Fatigue"
            SPse.Parameters.AddWithValue("@Fatigue", Trim(Txt_kra.Text))
            fa = True
        End If
        If Txt_talents.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Then
                s = s & " AND "
            End If
            s = s & "Racial_talents LIKE @Texto"
            SPse.Parameters.AddWithValue("@Texto", "%" & Trim(Txt_talents.Text) & "%")
            po = True
        End If
        If Txt_ucoc.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Then
                s = s & " AND "
            End If
            s = s & "Racial_attacks_defenses LIKE @aa"
            SPse.Parameters.AddWithValue("@aa", "%" & Trim(Txt_ucoc.Text) & "%")
            aa = True
        End If
        If Txt_habits.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Then
                s = s & " AND "
            End If
            s = s & "Racial_habits LIKE @ab"
            SPse.Parameters.AddWithValue("@ab", "%" & Trim(Txt_habits.Text) & "%")
            ab = True
        End If
        If Txt_cena.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Or ab Then
                s = s & " AND "
            End If
            s = s & "Racial_cost = @ac"
            SPse.Parameters.AddWithValue("@ac", Trim(Txt_cena.Text))
            ac = True
        End If
        If Txt_lspan.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Or ab Or ac Then
                s = s & " AND "
            End If
            s = s & "Racial_lifespan = @ad"
            SPse.Parameters.AddWithValue("@ad", Trim(Txt_lspan.Text))
            ad = True
        End If
        If Txt_rar.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Or ab Or ac Or ad Then
                s = s & " AND "
            End If
            s = s & "Rarity LIKE @ae"
            SPse.Parameters.AddWithValue("@ae", "%" & Trim(Txt_rar.Text) & "%")
            ae = True
        End If
        If Txt_date.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Or ab Or ac Or ad Or ae Then
                s = s & " AND "
            End If
            s = s & "Date_created = @af"
            SPse.Parameters.AddWithValue("@af", CDate(Txt_date.Text))
            af = True
        End If
        RAposition = 0
        If s = "SELECT * from Races WHERE " Then
            RArecopen()
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
                RAdat.SelectCommand = SPse
                RArec.Clear()
                RAdat.Fill(RArec, "ra")
                RAcount = RArec.Tables("ra").Rows.Count
                If GC_list = 1 Then
                    If my_sez Is Nothing Then
                        my_sez = New Frm_RAsez
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

    Private Sub Cmd_First_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_First.Click
        RAposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Forward_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Forward.Click
        RAposition += 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Ins_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Ins.Click
        If Txt_name.Text = "" Then
            MsgBox("Rasa musí mít jméno!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        If Txt_date.Text = "" Then
            If MsgBox("U rasy musí být uvedeno datum vytvoření! Chcete zadat dnešní datum " & Today & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Chyba") = MsgBoxResult.Yes Then
                Txt_date.Text = CStr(Today)
            Else
                Exit Sub
            End If
        End If
        Txt_name.Text = Txt_name.Text.ToUpper()
        Dim tsc As New OleDbCommand
        Dim treader As OleDbDataReader
        Try
            tsc.Connection = Odrialink2
            tsc.CommandText = "select * from Races where Race_name = @on"
            tsc.Parameters.AddWithValue("@on", Txt_name.Text)
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
                s1 = "INSERT INTO Races (Race_name"
                s2 = " VALUES (@Orig_name"
                ic.Parameters.AddWithValue("@Orig_name", Trim(Txt_name.Text))
                If Txt_pop.Text <> "" Then
                    ic.Parameters.AddWithValue("@rp", Txt_pop.Text)
                    s1 = s1 & ", Race_popis"
                    s2 = s2 & ", @rp"
                End If
                If Txt_sil.Text <> "" Then
                    ic.Parameters.AddWithValue("@rs", Txt_sil.Text)
                    s1 = s1 & ", Racial_str"
                    s2 = s2 & ", @rs"
                End If
                If Txt_hbi.Text <> "" Then
                    ic.Parameters.AddWithValue("@rh", Txt_hbi.Text)
                    s1 = s1 & ", Racial_dex"
                    s2 = s2 & ", @rh"
                End If
                If Txt_zru.Text <> "" Then
                    ic.Parameters.AddWithValue("@rz", Txt_zru.Text)
                    s1 = s1 & ", Racial_skill"
                    s2 = s2 & ", @rz"
                End If
                If Txt_fodl.Text <> "" Then
                    ic.Parameters.AddWithValue("@rf", Txt_fodl.Text)
                    s1 = s1 & ", Racial_fodl"
                    s2 = s2 & ", @rf"
                End If
                If Txt_Podl.Text <> "" Then
                    ic.Parameters.AddWithValue("@ro", Txt_Podl.Text)
                    s1 = s1 & ", Racial_podl"
                    s2 = s2 & ", @ro"
                End If
                If Txt_IQ.Text <> "" Then
                    ic.Parameters.AddWithValue("@ri", Txt_IQ.Text)
                    s1 = s1 & ", Racial_IQ"
                    s2 = s2 & ", @ri"
                End If
                If Txt_mou.Text <> "" Then
                    ic.Parameters.AddWithValue("@rw", Txt_mou.Text)
                    s1 = s1 & ", Racial_wis"
                    s2 = s2 & ", @rw"
                End If
                If Txt_jed.Text <> "" Then
                    ic.Parameters.AddWithValue("@rj", Txt_jed.Text)
                    s1 = s1 & ", Racial_beh"
                    s2 = s2 & ", @rj"
                End If
                If Txt_kra.Text <> "" Then
                    ic.Parameters.AddWithValue("@rk", Txt_kra.Text)
                    s1 = s1 & ", Racial_beau"
                    s2 = s2 & ", @rk"
                End If
                If Txt_talents.Text <> "" Then
                    ic.Parameters.AddWithValue("@rt", Txt_talents.Text)
                    s1 = s1 & ", Racial_talents"
                    s2 = s2 & ", @rt"
                End If
                If Txt_ucoc.Text <> "" Then
                    ic.Parameters.AddWithValue("@ru", Txt_ucoc.Text)
                    s1 = s1 & ", Racial_attacks_defenses"
                    s2 = s2 & ", @ru"
                End If
                ic.Parameters.AddWithValue("@dc", Txt_date.Text)
                s1 = s1 & ", Date_created"
                s2 = s2 & ", @dc"
                If Txt_habits.Text <> "" Then
                    ic.Parameters.AddWithValue("@ha", Txt_habits.Text)
                    s1 = s1 & ", Racial_habits"
                    s2 = s2 & ", @ha"
                End If
                If Txt_cena.Text <> "" Then
                    ic.Parameters.AddWithValue("@co", Txt_cena.Text)
                    s1 = s1 & ", Racial_cost"
                    s2 = s2 & ", @co"
                End If
                If Txt_lspan.Text <> "" Then
                    ic.Parameters.AddWithValue("@rl", Txt_lspan.Text)
                    s1 = s1 & ", Racial_lifespan"
                    s2 = s2 & ", @rl"
                End If
                If Txt_rar.Text <> "" Then
                    ic.Parameters.AddWithValue("@rr", Txt_rar.Text)
                    s1 = s1 & ", Rarity"
                    s2 = s2 & ", @rr"
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
            RArec.Clear()
            RAdat.Fill(RArec, "ra")
            RAcount = RArec.Tables("ra").Rows.Count
            Call FillForm()
        Else
            treader.Close()
            If MsgBox("Rasa tohoto jména již v databázi existuje, chcete jí přepsat?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Upozornění") = MsgBoxResult.Yes Then
                Try
                    Dim s3 As String
                    Dim uc As New OleDbCommand
                    s3 = "UPDATE Races set Race_name = @Orig_name, Race_popis = @Czech_name, Racial_str = @Magenergy, Racial_dex = @Cast_rounds, Racial_skill = @Duration, Racial_fodl = @Reach, Racial_podl = @Affect, Racial_IQ = @Spell_type, Racial_wis = @Spelling_cast, Racial_beh = @Difficulty, Racial_beau = @Cast_time, Racial_talents = @Fatigue, Racial_attacks_defenses = @Texto, Racial_cost = @DateCre, Racial_lifespan = @t1, Racial_habits = @t2, Rarity = @t3, Date_created = @t4 WHERE ID = @ID"
                    uc.Parameters.AddWithValue("@Orig_name", Trim(Txt_name.Text))
                    If Txt_pop.Text = "" Then
                        uc.Parameters.AddWithValue("@Czech_name", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Czech_name", Trim(Txt_pop.Text))
                    End If
                    If Txt_sil.Text = "" Then
                        uc.Parameters.AddWithValue("@Magenergy", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Magenergy", Trim(Txt_sil.Text))
                    End If
                    If Txt_hbi.Text = "" Then
                        uc.Parameters.AddWithValue("@Cast_rounds", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Cast_rounds", Trim(Txt_hbi.Text))
                    End If
                    If Txt_zru.Text = "" Then
                        uc.Parameters.AddWithValue("@Duration", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Duration", Trim(Txt_zru.Text))
                    End If
                    If Txt_fodl.Text = "" Then
                        uc.Parameters.AddWithValue("@Reach", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Reach", Trim(Txt_fodl.Text))
                    End If
                    If Txt_Podl.Text = "" Then
                        uc.Parameters.AddWithValue("@Affect", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Affect", Trim(Txt_fodl.Text))
                    End If
                    If Txt_IQ.Text = "" Then
                        uc.Parameters.AddWithValue("@Spell_type", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Spell_type", Trim(Txt_IQ.Text))
                    End If
                    If Txt_mou.Text = "" Then
                        uc.Parameters.AddWithValue("@Spelling_cast", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Spelling_cast", Trim(Txt_mou.Text))
                    End If
                    If Txt_jed.Text = "" Then
                        uc.Parameters.AddWithValue("@Difficulty", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Difficulty", Trim(Txt_jed.Text))
                    End If
                    If Txt_kra.Text = "" Then
                        uc.Parameters.AddWithValue("@Cast_time", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Cast_time", Trim(Txt_kra.Text))
                    End If
                    If Txt_talents.Text = "" Then
                        uc.Parameters.AddWithValue("@Fatigue", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Fatigue", Trim(Txt_talents.Text))
                    End If
                    If Txt_ucoc.Text = "" Then
                        uc.Parameters.AddWithValue("@Texto", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Texto", Trim(Txt_ucoc.Text))
                    End If
                    uc.Parameters.AddWithValue("@DateCre", CDate(Txt_date.Text))
                    If Txt_habits.Text = "" Then
                        uc.Parameters.AddWithValue("@t1", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@t1", Trim(Txt_habits.Text))
                    End If
                    If Txt_cena.Text = "" Then
                        uc.Parameters.AddWithValue("@t2", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@t2", Trim(Txt_cena.Text))
                    End If
                    If Txt_lspan.Text = "" Then
                        uc.Parameters.AddWithValue("@t3", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@t3", Trim(Txt_lspan.Text))
                    End If
                    If Txt_rar.Text = "" Then
                        uc.Parameters.AddWithValue("@t4", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@t4", Trim(Txt_rar.Text))
                    End If
                    uc.Parameters.AddWithValue("@ID", RArec.Tables("ra").Rows(RAposition)("ID"))
                    uc.Connection = Odrialink2
                    uc.CommandText = s3
                    uc.ExecuteScalar()
                Catch ex As Exception
                    MsgBox("Chyba updatu případu: " + ex.Message, , "Pokus o update")
                    Exit Sub
                End Try
                RArec.Clear()
                RAdat.Fill(RArec, "ra")
                Call FillForm()
            Else
                Exit Sub
            End If
        End If

    End Sub

    Private Sub Cmd_Last_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Last.Click
        RAposition = RAcount - 1
        Call FillForm()
    End Sub

    Private Sub Cmd_New_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_New.Click
        Txt_name.Text = ""
        Txt_pop.Text = ""
        Txt_sil.Text = ""
        Txt_hbi.Text = ""
        Txt_zru.Text = ""
        Txt_fodl.Text = ""
        Txt_Podl.Text = ""
        Txt_IQ.Text = ""
        Txt_mou.Text = ""
        Txt_jed.Text = ""
        Txt_kra.Text = ""
        Txt_talents.Text = ""
        Txt_ucoc.Text = ""
        Txt_date.Text = ""
        Txt_habits.Text = ""
        Txt_cena.Text = ""
        Txt_lspan.Text = ""
        Txt_rar.Text = ""
        Cmd_Print.Enabled = False
        Cmd_Del.Enabled = False
        Txt_Num.Text = "NEW"

    End Sub

    Private Sub Cmd_Order_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Order.Click
        OrderControl = "RA"
        FO = New Frm_Ordering
        FO.ShowDialog()
        FO = Nothing
        RArec.Clear()
        Call RArecopen()
        RAposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Print_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Print.Click
        Dim RArint As New RAPrint
        RArint.Show()
    End Sub

    Private Sub Frm_Races_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Call RArecopen()
        RAposition = 0
        ApplyColor()
        Call FillForm()
        RA = True
    End Sub


    Sub FillForm()


        Txt_name.Text = RArec.Tables("ra").Rows(RAposition)("Race_name")
        If Not IsDBNull(RArec.Tables("ra").Rows(RAposition)("Race_popis")) Then
            Txt_pop.Text = RArec.Tables("ra").Rows(RAposition)("Race_popis")
        Else
            Txt_pop.Text = ""
        End If
        If Not IsDBNull(RArec.Tables("ra").Rows(RAposition)("Racial_str")) Then
            Txt_sil.Text = RArec.Tables("ra").Rows(RAposition)("Racial_str")
        Else
            Txt_sil.Text = ""
        End If
        If Not IsDBNull(RArec.Tables("ra").Rows(RAposition)("Racial_dex")) Then
            Txt_hbi.Text = RArec.Tables("ra").Rows(RAposition)("Racial_dex")
        Else
            Txt_hbi.Text = ""
        End If
        If Not IsDBNull(RArec.Tables("ra").Rows(RAposition)("Racial_skill")) Then
            Txt_zru.Text = RArec.Tables("ra").Rows(RAposition)("Racial_skill")
        Else
            Txt_zru.Text = ""
        End If
        If Not IsDBNull(RArec.Tables("ra").Rows(RAposition)("Racial_fodl")) Then
            Txt_fodl.Text = RArec.Tables("ra").Rows(RAposition)("Racial_fodl")
        Else
            Txt_fodl.Text = ""
        End If
        If Not IsDBNull(RArec.Tables("ra").Rows(RAposition)("Racial_podl")) Then
            Txt_Podl.Text = RArec.Tables("ra").Rows(RAposition)("Racial_podl")
        Else
            Txt_Podl.Text = ""
        End If
        If Not IsDBNull(RArec.Tables("ra").Rows(RAposition)("Racial_IQ")) Then
            Txt_IQ.Text = RArec.Tables("ra").Rows(RAposition)("Racial_IQ")
        Else
            Txt_IQ.Text = ""
        End If
        If Not IsDBNull(RArec.Tables("ra").Rows(RAposition)("Racial_wis")) Then
            Txt_mou.Text = RArec.Tables("ra").Rows(RAposition)("Racial_wis")
        Else
            Txt_mou.Text = ""
        End If
        If Not IsDBNull(RArec.Tables("ra").Rows(RAposition)("Racial_beh")) Then
            Txt_jed.Text = RArec.Tables("ra").Rows(RAposition)("Racial_beh")
        Else
            Txt_jed.Text = ""
        End If
        If Not IsDBNull(RArec.Tables("ra").Rows(RAposition)("Racial_beau")) Then
            Txt_kra.Text = RArec.Tables("ra").Rows(RAposition)("Racial_beau")
        Else
            Txt_kra.Text = ""
        End If
        If Not IsDBNull(RArec.Tables("ra").Rows(RAposition)("Racial_talents")) Then
            Txt_talents.Text = RArec.Tables("ra").Rows(RAposition)("Racial_talents")
        Else
            Txt_talents.Text = ""
        End If
        If Not IsDBNull(RArec.Tables("ra").Rows(RAposition)("Racial_attacks_defenses")) Then
            Txt_ucoc.Text = RArec.Tables("ra").Rows(RAposition)("Racial_attacks_defenses")
        Else
            Txt_ucoc.Text = ""
        End If
        Txt_date.Text = RArec.Tables("ra").Rows(RAposition)("Date_created")
        If Not IsDBNull(RArec.Tables("ra").Rows(RAposition)("Racial_habits")) Then
            Txt_habits.Text = RArec.Tables("ra").Rows(RAposition)("Racial_habits")
        Else
            Txt_habits.Text = ""
        End If
        If Not IsDBNull(RArec.Tables("ra").Rows(RAposition)("Racial_cost")) Then
            Txt_cena.Text = RArec.Tables("ra").Rows(RAposition)("Racial_cost")
        Else
            Txt_cena.Text = ""
        End If
        If Not IsDBNull(RArec.Tables("ra").Rows(RAposition)("Racial_lifespan")) Then
            Txt_lspan.Text = RArec.Tables("ra").Rows(RAposition)("Racial_lifespan")
        Else
            Txt_lspan.Text = ""
        End If
        If Not IsDBNull(RArec.Tables("ra").Rows(RAposition)("Rarity")) Then
            Txt_rar.Text = RArec.Tables("ra").Rows(RAposition)("Rarity")
        Else
            Txt_rar.Text = ""
        End If
        If RAposition = 0 Then
            Cmd_Back.Enabled = False
        Else
            Cmd_Back.Enabled = True
        End If
        Cmd_Del.Enabled = True
        Cmd_Find.Enabled = True
        If RAposition + 1 = RAcount Then
            Cmd_Forward.Enabled = False
        Else
            Cmd_Forward.Enabled = True
        End If
        Cmd_Ins.Enabled = True
        Cmd_New.Enabled = True
        Cmd_Print.Enabled = True


        Txt_Num.Text = (RAposition + 1) & "/" & RAcount

    End Sub

    Private Sub Frm_Races_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        RA = False
        RArec.Clear()
    End Sub




    Private Sub Txt_Num_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Num.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            If Not IsNumeric(Txt_Num.Text) Then
                MsgBox("Tady musí být číslo!", MsgBoxStyle.OKOnly, "Chyba")
                GoTo EventExitSub
            End If
            If CShort(Txt_Num.Text) > RAcount Or CShort(Txt_Num.Text) < 1 Then
                MsgBox("Číslo musí být v rozsahu 1 - počet záznamů!", MsgBoxStyle.OKOnly, "Chyba")
                GoTo EventExitSub
            End If
            KeyAscii = 0
            RAposition = CShort(Txt_Num.Text) - 1
            Call FillForm()
        End If
EventExitSub:
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub RArecopen()
        Dim ssc As New OleDbCommand
        ssc.Connection = Odrialink2
        Select Case RAorder
            Case Is = 1
                If RAdirect = 1 Then
                    ssc.CommandText = "select * from Races order by Race_name"
                Else
                    ssc.CommandText = "select * from Races order by Race_name desc"
                End If
            Case Is = 2
                If RAdirect = 1 Then
                    ssc.CommandText = "select * from Races order by Date_created"
                Else
                    ssc.CommandText = "select * from Races order by Date_created desc"
                End If
            Case Is = 3
                If RAdirect = 1 Then
                    ssc.CommandText = "select * from Races order by Racial_cost"
                Else
                    ssc.CommandText = "select * from Races order by Racial_cost desc"
                End If
        End Select
        RAdat.SelectCommand = ssc
        RArec.Clear()
        RAdat.Fill(RArec, "ra")
        RAcount = RArec.Tables("ra").Rows.Count
    End Sub

    Private Sub Bt_List_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_List.Click
        If my_sez Is Nothing Then
            my_sez = New Frm_RAsez
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
        Me.BackColor = Color.FromArgb(FRB)
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
        Label1.ForeColor = Color.FromArgb(FRFO)
        Label2.ForeColor = Color.FromArgb(FRFO)
        Label3.ForeColor = Color.FromArgb(FRFO)
        Label4.ForeColor = Color.FromArgb(FRFO)
        Label5.ForeColor = Color.FromArgb(FRFO)
        Label6.ForeColor = Color.FromArgb(FRFO)
        Label7.ForeColor = Color.FromArgb(FRFO)
        Label8.ForeColor = Color.FromArgb(FRFO)
        Label9.ForeColor = Color.FromArgb(FRFO)
        Label10.ForeColor = Color.FromArgb(FRFO)
        Label11.ForeColor = Color.FromArgb(FRFO)
        Label12.ForeColor = Color.FromArgb(FRFO)
        Label13.ForeColor = Color.FromArgb(FRFO)
        Label14.ForeColor = Color.FromArgb(FRFO)
        Label15.ForeColor = Color.FromArgb(FRFO)
        Label16.ForeColor = Color.FromArgb(FRFO)
        Label17.ForeColor = Color.FromArgb(FRFO)
        Label18.ForeColor = Color.FromArgb(FRFO)
        Txt_Num.ForeColor = Color.FromArgb(FRFO)
        Txt_name.ForeColor = Color.FromArgb(FRFO)
        Txt_pop.ForeColor = Color.FromArgb(FRFO)
        Txt_sil.ForeColor = Color.FromArgb(FRFO)
        Txt_hbi.ForeColor = Color.FromArgb(FRFO)
        Txt_zru.ForeColor = Color.FromArgb(FRFO)
        Txt_Podl.ForeColor = Color.FromArgb(FRFO)
        Txt_fodl.ForeColor = Color.FromArgb(FRFO)
        Txt_IQ.ForeColor = Color.FromArgb(FRFO)
        Txt_mou.ForeColor = Color.FromArgb(FRFO)
        Txt_jed.ForeColor = Color.FromArgb(FRFO)
        Txt_kra.ForeColor = Color.FromArgb(FRFO)
        Txt_rar.ForeColor = Color.FromArgb(FRFO)
        Txt_talents.ForeColor = Color.FromArgb(FRFO)
        Txt_ucoc.ForeColor = Color.FromArgb(FRFO)
        Txt_lspan.ForeColor = Color.FromArgb(FRFO)
        Txt_cena.ForeColor = Color.FromArgb(FRFO)
        Txt_habits.ForeColor = Color.FromArgb(FRFO)
        Txt_date.ForeColor = Color.FromArgb(FRFO)
    End Sub

End Class